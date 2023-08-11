using BOSCommon;
using BOSCommon.Constants;
using BOSERP.GenaralLeadger;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.MaterialShipment
{
    public class MaterialShipmentEntities : GLShipmentEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets shipment item list including the item's components        
        /// </summary>
        public BOSItemsEntityList<ICShipmentItemsInfo> ComponentShipmentItemList { get; set; }

        public BOSList<ICShipmentItemVMsInfo> TotalShipmentItemsList { get; set; }
        #endregion

        #region Constructor
        public MaterialShipmentEntities()
            : base()
        {
            ShipmentItemList = new BOSItemsEntityList<ICShipmentItemsInfo>();
            TotalShipmentItemsList = new BOSList<ICShipmentItemVMsInfo>();
            ComponentShipmentItemList = new BOSItemsEntityList<ICShipmentItemsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ICShipmentsInfo();
            SearchObject = new ICShipmentsInfo();
        }
        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICShipmentItemsTableName, new ICShipmentItemsInfo());
            ModuleObjects.Add(TableName.ICShipmentItemVMsTableName, new ICShipmentItemVMsInfo());
        }
        public override void InitModuleObjectList()
        {
            ShipmentItemList.InitBOSList(
                                        this,
                                        TableName.ICShipmentsTableName,
                                        TableName.ICShipmentItemsTableName,
                                        BOSList<ICShipmentItemsInfo>.cstRelationForeign);
            ShipmentItemList.ItemTableForeignKey = "FK_ICShipmentID";
            ComponentShipmentItemList.InitBOSList(this,
                                                  TableName.ICShipmentsTableName,
                                                  TableName.ICShipmentItemsTableName,
                                                  BOSList<ICShipmentItemsInfo>.cstRelationForeign);
            ComponentShipmentItemList.ItemTableForeignKey = "FK_ICShipmentID";

            TotalShipmentItemsList.InitBOSList(
                                        this,
                                        TableName.ICShipmentsTableName,
                                        TableName.ICShipmentItemsTableName,
                                        BOSList<ICShipmentItemsInfo>.cstRelationForeign);
            TotalShipmentItemsList.ItemTableForeignKey = "FK_ICShipmentID";
        }

        public override void InitGridControlInBOSList()
        {
            ShipmentItemList.InitBOSListGridControl(MaterialShipmentModule.ShipmentItemGridControlName);
            DocumentEntryList.InitBOSListGridControl(MaterialShipmentModule.DocumentEntryGridControlName);
            TotalShipmentItemsList.InitBOSListGridControl("fld_dgcShipmentItemVMsGridControl");
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ShipmentItemList.SetDefaultListAndRefreshGridControl();
                TotalShipmentItemsList.SetDefaultListAndRefreshGridControl();
                ComponentShipmentItemList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion
        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentTypeCombo = ShipmentType.MaterialShipment.ToString();
            objShipmentsInfo.ICShipmentDate = DateTime.Now;
            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.New.ToString();
            objShipmentsInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            objShipmentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objShipmentsInfo.ICShipmentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objShipmentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            UpdateMainObjectBindingSource();
        }
        #region Invalidate Module Objects functions

        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
            ICShipmentsInfo mainObject = (ICShipmentsInfo)MainObject;
            ((MaterialShipmentModule)Module).UpdateProductLookupEditControlDataSource(mainObject.ICShipmentShipmentType, mainObject.ICShipmentShipmentType);

        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            ICProductsController objProductsController = new ICProductsController();
            MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
            ShipmentItemList.Invalidate(iObjectID);
            ShipmentItemList.ForEach(o =>
            {
                o.VirtualID = Guid.NewGuid();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(o.FK_ICProductForBatchID);
                if (objProductsInfo != null)
                    o.ICShipmentItemProductName2 = objProductsInfo.ICProductName2;
                MMBatchProductItemsInfo objBatchProductItemsInfo = (MMBatchProductItemsInfo)objBatchProductItemsController.GetObjectByID(o.FK_MMBatchProductItemID);
                if (objBatchProductItemsInfo != null)
                {
                    o.ICShipmentItemSOName = objBatchProductItemsInfo.MMBatchProductItemSOName;
                }
            });
            List<ICShipmentItemsInfo> shipmentItemList = ShipmentItemList.Select(o => (ICShipmentItemsInfo)o.Clone()).ToList();
            List<ICShipmentItemVMsInfo> totalList = GenerateTotalShipmentItemsList(shipmentItemList);
            TotalShipmentItemsList.Invalidate(totalList);
            //InvalidateItemComponents();
        }

        public List<ICShipmentItemVMsInfo> GenerateTotalShipmentItemsList(IList<ICShipmentItemsInfo> shipmentItemList)
        {
            List<ICShipmentItemVMsInfo> totalList = shipmentItemList.GroupBy(o => new
            {
                o.FK_ICProductID,
                o.FK_ICStockID,
                o.FK_ICMeasureUnitID,
                o.FK_MMBatchProductID,
                //FK_MMBatchProductItemID = o.FK_MMAllocationPlanItemID > 0 ? o.FK_MMBatchProductItemID : 0,
                //o.FK_ICProductForBatchID,
                o.FK_HRDepartmentRoomGroupItemID,
                o.FK_MMLineID,
                o.FK_MMWorkShopID,
                o.FK_ICProductSerieID,

                o.ICShipmentItemProductName,
                //o.ICShipmentItemProductName2,
                o.ICShipmentItemProductDesc,
                o.ICShipmentItemProductUnitPrice,
                o.ICShipmentItemProductSerialNo,
                o.ICShipmentItemLotNo,
                o.ICShipmentItemProductFactor,
                //o.ICShipmentItemComment,

                o.ICShipmentItemHeight,
                o.ICShipmentItemWidth,
                o.ICShipmentItemLength,
                o.ICShipmentItemProductUnitCost,
                o.ICShipmentItemIsSpecificCalculation,
                IsBelongPlan = o.FK_MMAllocationPlanItemID > 0 ? true : false,
                //ICShipmentItemBatchProductItemProductSerial = o.FK_MMAllocationPlanItemID > 0 ? o.ICShipmentItemBatchProductItemProductSerial : string.Empty,
                FK_MMOperationID = o.FK_MMAllocationPlanItemID > 0 ? 0 : o.FK_MMOperationID,
            }).Select(o => new ICShipmentItemVMsInfo()
            {
                FK_ICProductID = o.Key.FK_ICProductID,
                FK_ICStockID = o.Key.FK_ICStockID,
                FK_ICMeasureUnitID = o.Key.FK_ICMeasureUnitID,
                FK_MMBatchProductID = o.Key.FK_MMBatchProductID,
                FK_HRDepartmentRoomGroupItemID = o.Key.FK_HRDepartmentRoomGroupItemID,
                FK_MMLineID = o.Key.FK_MMLineID,
                FK_MMWorkShopID = o.Key.FK_MMWorkShopID,
                FK_ICProductSerieID = o.Key.FK_ICProductSerieID,
                //FK_MMBatchProductItemID = o.Key.FK_MMBatchProductItemID,
                //FK_ICProductForBatchID = o.Key.FK_ICProductForBatchID,
                ICShipmentItemProductName = o.Key.ICShipmentItemProductName,
                //ICShipmentItemProductName2 = o.Key.ICShipmentItemProductName2,
                ICShipmentItemProductDesc = o.Key.ICShipmentItemProductDesc,
                ICShipmentItemProductUnitPrice = o.Key.ICShipmentItemProductUnitPrice,
                ICShipmentItemProductSerialNo = o.Key.ICShipmentItemProductSerialNo,
                ICShipmentItemLotNo = o.Key.ICShipmentItemLotNo,
                ICShipmentItemProductFactor = o.Key.ICShipmentItemProductFactor,
                //ICShipmentItemComment = o.Key.ICShipmentItemComment,

                ICShipmentItemHeight = o.Key.ICShipmentItemHeight,
                ICShipmentItemWidth = o.Key.ICShipmentItemWidth,
                ICShipmentItemLength = o.Key.ICShipmentItemLength,
                //ICShipmentItemBatchProductItemProductSerial = o.Key.ICShipmentItemBatchProductItemProductSerial,
                FK_MMOperationID = o.Key.FK_MMOperationID,
                ICShipmentItemProductUnitCost = o.Key.ICShipmentItemProductUnitCost,
                ICShipmentItemIsSpecificCalculation = o.Key.ICShipmentItemIsSpecificCalculation,

                ICShipmentItemProductQty = o.Sum(item => item.ICShipmentItemProductQty),
                ICShipmentItemProductExchangeQty = o.Key.ICShipmentItemProductFactor * o.Sum(item => item.ICShipmentItemProductQty),
                ICShipmentItemRef = string.Join(",", o.Select(item => item.VirtualID.ToString()).ToArray()),
                ICShipmentItemRefID = string.Join(",", o.Where(item => item.Id > 0).Select(item => item.Id.ToString()).ToArray()),
                MMAllocationPlanItemRef = o.Key.IsBelongPlan ? string.Join(",", o.Where(item => item.FK_MMAllocationPlanItemID > 0).Select(item => item.FK_MMAllocationPlanItemID.ToString()).ToArray()) : string.Empty,
                ICShipmentItemSOName = string.Join(", ", o.Where(item => !string.IsNullOrWhiteSpace(item.ICShipmentItemSOName)).Select(item => item.ICShipmentItemSOName).Distinct().ToArray())
            }).ToList();
            return totalList;
        }

        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            ShipmentItemList.SaveItemObjects();
            SaveAccountingData();
        }

        #endregion
        public override bool CompleteTransaction()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.Complete.ToString();
            SaveMainObject();
            //ShipmentItemList.SaveItemObjects();
            //UpdateUnifinishedCost();
            return base.CompleteTransaction();
        }
        /// <summary>
        /// Invalidate item components of the shipment items
        /// </summary>
        public void InvalidateItemComponents()
        {
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            List<ICShipmentItemsInfo> items = objShipmentItemsController.GetComponentItemsByShipmentID(objShipmentsInfo.ICShipmentID);
            ComponentShipmentItemList.Clear();
            ComponentShipmentItemList.OriginalList.Clear();
            ComponentShipmentItemList.BackupList.Clear();
            foreach (ICShipmentItemsInfo item in items)
            {
                ComponentShipmentItemList.Add((ICShipmentItemsInfo)item.Clone());
            }

            foreach (ICShipmentItemsInfo item in ComponentShipmentItemList)
            {
                ComponentShipmentItemList.OriginalList.Add((ICShipmentItemsInfo)item.Clone());
            }

            foreach (ICShipmentItemsInfo item in ComponentShipmentItemList)
            {
                ComponentShipmentItemList.BackupList.Add((ICShipmentItemsInfo)item.Clone());
            }
        }

        public void UpdateTotalAmount()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentSubTotalAmount = 0;
            foreach (ICShipmentItemsInfo entItem in ShipmentItemList)
            {
                objShipmentsInfo.ICShipmentSubTotalAmount += entItem.ICShipmentItemTotalAmount;
                BOSApp.RoundByCurrency(entItem, objShipmentsInfo.FK_GECurrencyID);
            }
            objShipmentsInfo.ICShipmentTotalAmount = objShipmentsInfo.ICShipmentSubTotalAmount;
            BOSApp.RoundByCurrency(objShipmentsInfo, objShipmentsInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }

        public void UpdateUnifinishedCost(bool isPosted)
        {
            ICShipmentsInfo mainObject = (ICShipmentsInfo)MainObject;
            ACUnfinishedConstructionCostsController objUnfinishedConstructionCostsController = new ACUnfinishedConstructionCostsController();
            objUnfinishedConstructionCostsController.UpdateUnfinishedConstructionCostByShipmentID(mainObject.ICShipmentID, isPosted);
        }
        #region Accounting
        public override bool SaveAccountingData()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
            {
                BOSUtil.CopyObject(objShipmentsInfo, objDocumentsInfo);
            }
            return base.SaveAccountingData();
        }
        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            string strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            if (MainObject != null && strTableName == strMainObjectTableName)
            {
                ShipmentItemList.DeleteItemObjects();
                ComponentShipmentItemList.DeleteItemObjects();
            }
        }
        #endregion

        public override string GetMainObjectNo(ref int numberingStart)
        {
            ICShipmentsInfo mainObject = (ICShipmentsInfo)MainObject;
            ICStocksController objStocksController = new ICStocksController();
            ICStocksInfo objICStocksInfo = (ICStocksInfo)objStocksController.GetObjectByID(mainObject.FK_ICStockID);

            string mainObjectNo = objICStocksInfo == null
                                    ? base.GetMainObjectNo(ref numberingStart)
                                    : base.GetMainObjectNo(ref numberingStart, objICStocksInfo);
            return mainObjectNo;
        }

        public override void UpdateObjectNumbering(int numberingStart)
        {
            ICShipmentsInfo mainObject = (ICShipmentsInfo)MainObject;
            ICStocksController objStocksController = new ICStocksController();
            ICStocksInfo objICStocksInfo = (ICStocksInfo)objStocksController.GetObjectByID(mainObject.FK_ICStockID);

            if (objICStocksInfo == null)
                base.UpdateObjectNumbering(numberingStart);
            else
                UpdateStockNumbering(numberingStart, objICStocksInfo);
        }

        public void UpdateStockNumbering(int numberingStart, ICStocksInfo objICStocksInfo)
        {
            GEStockNumberingsInfo objGEStockNumberingsInfo = (new GEStockNumberingsController()).GetGEStockNumberingByModuleNameAndStockID(Module.Name, objICStocksInfo.ICStockID);
            if (objGEStockNumberingsInfo != null)
            {
                objGEStockNumberingsInfo.GEStockNumberingStart = numberingStart + 1;
                (new GEStockNumberingsController()).UpdateObject(objGEStockNumberingsInfo);
            }
        }

        public override bool CancelCompleteTransaction()
        {
            ICShipmentsInfo mainObject = (ICShipmentsInfo)MainObject;
            bool isSuccess = base.CancelCompleteTransaction();
            if (!isSuccess)
                return false;

            mainObject.ICShipmentStatus = ShipmentStatus.New.ToString();
            UpdateMainObject();
            return isSuccess;
        }
    }
}
