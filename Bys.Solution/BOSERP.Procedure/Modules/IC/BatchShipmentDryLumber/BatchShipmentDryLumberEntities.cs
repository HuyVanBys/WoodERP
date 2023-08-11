using BOSCommon;
using BOSCommon.Constants;
using BOSERP.GenaralLeadger;
using BOSLib;
using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.BatchShipmentDryLumber
{
    public class BatchShipmentDryLumberEntities : GLShipmentEntities
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
        public BatchShipmentDryLumberEntities()
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

            ShipmentItemList.InitBOSList(this,
                                         TableName.ICShipmentsTableName,
                                         TableName.ICShipmentItemsTableName,
                                         BOSList<ICShipmentItemsInfo>.cstRelationForeign);
            ShipmentItemList.ItemTableForeignKey = "FK_ICShipmentID";

            TotalShipmentItemsList.InitBOSList(
                                       this,
                                       TableName.ICShipmentsTableName,
                                       TableName.ICShipmentItemsTableName,
                                       BOSList<ICShipmentItemsInfo>.cstRelationForeign);
            TotalShipmentItemsList.ItemTableForeignKey = "FK_ICShipmentID";
        }

        public override void InitGridControlInBOSList()
        {
            ShipmentItemList.InitBOSListGridControl(BatchShipmentDryLumberModule.ShipmentItemGridControlName);
            DocumentEntryList.InitBOSListGridControl(BatchShipmentDryLumberModule.DocumentEntryGridControlName);
            TotalShipmentItemsList.InitBOSListGridControl("fld_dgcShipmentItemVMsGridControl");
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ShipmentItemList.SetDefaultListAndRefreshGridControl();
                DocumentEntryList.SetDefaultListAndRefreshGridControl();
                TotalShipmentItemsList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentTypeCombo = ShipmentType.DryLumber.ToString();
            objShipmentsInfo.ICShipmentShipmentType = ShipmentType.DryLumber.ToString();
            objShipmentsInfo.ICShipmentDate = DateTime.Now;
            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.New.ToString();
            ICStocksController objStocksController = new ICStocksController();
            ICStocksInfo objStocksInfo = (ICStocksInfo)objStocksController.GetObjectByNo(StockNo.DryLumberStock);
            if (objStocksInfo != null)
            {
                objShipmentsInfo.FK_ICStockID = objStocksInfo.ICStockID;
            }
            objShipmentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objShipmentsInfo.ICShipmentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objShipmentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            UpdateMainObjectBindingSource();
        }
        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            //ICProductsController objProductsController = new ICProductsController();
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> listShipmentItemsInfo = objShipmentItemsController.GetItemByShipmentID(iObjectID);
            //MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
            //listShipmentItemsInfo.ForEach(o =>
            //{
            //    MMBatchProductItemsInfo objBatchProductItemsInfo = (MMBatchProductItemsInfo)objBatchProductItemsController.GetObjectByID(o.FK_MMBatchProductItemID);
            //    if (objBatchProductItemsInfo != null)
            //    {
            //        o.ICShipmentItemSOName = objBatchProductItemsInfo.MMBatchProductItemSOName;
            //    }
            //});
            ShipmentItemList.Invalidate(listShipmentItemsInfo);
            ShipmentItemList.ForEach(o =>
            {
                o.VirtualID = Guid.NewGuid();
                //ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(o.FK_ICProductForBatchID);
                //if (objProductsInfo != null)
                //    o.ICShipmentItemProductName2 = objProductsInfo.ICProductName2;
            });
            List<ICShipmentItemsInfo> shipmentItemList = ShipmentItemList.Select(o => (ICShipmentItemsInfo)o.Clone()).ToList();
            List<ICShipmentItemVMsInfo> totalList = GenerateTotalShipmentItemsList(shipmentItemList);
            TotalShipmentItemsList.Invalidate(totalList);
            //InvalidateItemComponents();
        }

        public List<ICShipmentItemVMsInfo> GenerateTotalShipmentItemsList(IList<ICShipmentItemsInfo> shipmentItemList)
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            MMConfigMaterialShipmentUtilitysController objConfigMSUController = new MMConfigMaterialShipmentUtilitysController();
            MMConfigMaterialShipmentUtilitysInfo objConfigMSUInfo = (MMConfigMaterialShipmentUtilitysInfo)objConfigMSUController.GetDefualtConfigMaterialShipmentUtilitys();
            List<ICShipmentItemVMsInfo> totalList = new List<ICShipmentItemVMsInfo>();
            if (objConfigMSUInfo == null)
                return totalList;
            if (objConfigMSUInfo.MMConfigMaterialShipmentUtilityType == ConfigMaterialShipmentUtilityType.BySemiProduct.ToString())
            {
                shipmentItemList.ForEach(o =>
                {
                    ICShipmentItemVMsInfo objShipmentItemVMsInfo = new ICShipmentItemVMsInfo();
                    BOSUtil.CopyObject(o, objShipmentItemVMsInfo);
                    objShipmentItemVMsInfo.ICShipmentItemRef = o.VirtualID.ToString();
                    objShipmentItemVMsInfo.ICShipmentItemRefID = o.Id.ToString();
                    objShipmentItemVMsInfo.MMAllocationPlanItemRef = o.FK_MMAllocationPlanItemID > 0 ? o.FK_MMAllocationPlanItemID.ToString() : string.Empty;
                    objShipmentItemVMsInfo.FK_MMOperationID = o.FK_MMAllocationPlanItemID > 0 ? o.FK_MMOperationID : 0;
                    totalList.Add(objShipmentItemVMsInfo);
                });
            }
            else if (objConfigMSUInfo.MMConfigMaterialShipmentUtilityType == ConfigMaterialShipmentUtilityType.ByMasterData.ToString())
            {
                totalList = shipmentItemList.GroupBy(o => new
                {
                    o.FK_ICProductID,
                    o.FK_ICStockID,
                    o.FK_ICMeasureUnitID,
                    o.FK_MMBatchProductID,
                    //FK_MMBatchProductItemID = o.FK_MMAllocationPlanItemID > 0 ? o.FK_MMBatchProductItemID : 0,
                    //o.FK_ICProductForBatchID,
                    //o.FK_HRDepartmentRoomGroupItemID,
                    //o.FK_MMLineID,
                    //o.FK_MMWorkShopID,
                    o.FK_ICProductSerieID,

                    o.ICShipmentItemProductName,
                    //o.ICShipmentItemProductName2,
                    o.ICShipmentItemProductDesc,
                    o.ICShipmentItemProductUnitPrice,
                    o.ICShipmentItemProductSerialNo,
                    o.ICShipmentItemLotNo,
                    o.ICShipmentItemProductFactor,
                    //o.ICShipmentItemComment,
                    ICShipmentItemPerimeter = o.FK_ICProductSerieID > 0 ? o.ICShipmentItemPerimeter : 0,
                    ICShipmentItemLength = o.FK_ICProductSerieID > 0 ? o.ICShipmentItemLength : 0,
                    ICShipmentItemWidth = o.FK_ICProductSerieID > 0 ? o.ICShipmentItemWidth : 0,
                    o.ICShipmentItemHeight,

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
                    //FK_HRDepartmentRoomGroupItemID = o.Key.FK_HRDepartmentRoomGroupItemID,
                    //FK_MMLineID = o.Key.FK_MMLineID,
                    //FK_MMWorkShopID = o.Key.FK_MMWorkShopID,
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
                    ICShipmentItemPerimeter = o.Key.ICShipmentItemPerimeter,
                    ICShipmentItemLength = o.Key.ICShipmentItemLength,
                    //ICShipmentItemBatchProductItemProductSerial = o.Key.ICShipmentItemBatchProductItemProductSerial,
                    FK_MMOperationID = o.Key.FK_MMOperationID,
                    ICShipmentItemProductUnitCost = o.Key.ICShipmentItemProductUnitCost,
                    ICShipmentItemIsSpecificCalculation = o.Key.ICShipmentItemIsSpecificCalculation,

                    ICShipmentItemProductQty = o.Sum(item => item.ICShipmentItemProductQty),
                    ICShipmentItemProductExchangeQty = o.Key.ICShipmentItemProductFactor * o.Sum(item => item.ICShipmentItemProductQty),
                    ICShipmentItemWoodQty = o.Sum(item => item.ICShipmentItemWoodQty),

                    ICShipmentItemRef = string.Join(",", o.Select(item => item.VirtualID.ToString()).ToArray()),
                    ICShipmentItemRefID = string.Join(",", o.Where(item => item.Id > 0).Select(item => item.Id.ToString()).ToArray()),
                    MMAllocationPlanItemRef = o.Key.IsBelongPlan ? string.Join(",", o.Where(item => item.FK_MMAllocationPlanItemID > 0).Select(item => item.FK_MMAllocationPlanItemID.ToString()).ToArray()) : string.Empty,
                    ICShipmentItemSOName = string.Join(", ", o.Where(item => !string.IsNullOrWhiteSpace(item.ICShipmentItemSOName)).Select(item => item.ICShipmentItemSOName).Distinct().ToArray())
                }).ToList();
            }
            return totalList;
        }

        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            ShipmentItemList.SaveItemObjects();
        }
        #endregion

        public void UpdateProductQty()
        {
            ICShipmentItemsInfo objShipmentItemsInfo = (ICShipmentItemsInfo)ModuleObjects[TableName.ICShipmentItemsTableName];
            if (objShipmentItemsInfo != null)
            {
                ShipmentItemList.ChangeObjectFromList();
            }
        }
        /// <summary>
        /// Invalidate item components of the shipment items
        /// </summary>
        public void InvalidateItemComponents()
        {
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            List<ICShipmentItemsInfo> items = objShipmentItemsController.GetItemsByShipmentID(objShipmentsInfo.ICShipmentID);
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

        public override bool CompleteTransaction()
        {
            ApproveBatchShipmentDryLumber();
            //UpdateAAlocationProposalItemQty();
            return true;
        }

        public bool ApproveBatchShipmentDryLumber()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.Complete.ToString();
            UpdateMainObject();
            //ShipmentItemList.SaveItemObjects();

            //InvalidateItemComponents();

            //SaveAccountingData();
            return true;
        }

        public void UpdateAAlocationProposalItemQty()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            //AllocationProposalEntities entity = new AllocationProposalEntities();

            //get allocation plan stock
            int saleOrderStockID = 0;
            ICStocksController objStocksController = new ICStocksController();
            ICStocksInfo objStocksInfo = objStocksController.GetStockByTypeAndBranchID(StockType.AllocationPlan.ToString(), objShipmentsInfo.FK_BRBranchID);
            if (objStocksInfo != null)
            {
                saleOrderStockID = objStocksInfo.ICStockID;
            }

            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> ShipmentItemList = objShipmentItemsController.GetItemByShipmentID(objShipmentsInfo.ICShipmentID);
            foreach (ICShipmentItemsInfo item in ShipmentItemList)
            {
                MMAllocationProposalItemsController objAllocationProposalItemsController = new MMAllocationProposalItemsController();
                MMAllocationProposalItemsInfo objAllocationProposalItemsInfo = (MMAllocationProposalItemsInfo)objAllocationProposalItemsController.GetObjectByID(item.FK_MMAllocationProposalItemID);
                if (objAllocationProposalItemsInfo != null)
                {
                    objAllocationProposalItemsInfo.MMAllocationProposalItemShippedQty += item.ICShipmentItemProductQty;
                    objAllocationProposalItemsInfo.MMAllocationProposalItemShippedWoodQty += item.ICShipmentItemWoodQty;
                    objAllocationProposalItemsController.UpdateObject(objAllocationProposalItemsInfo);
                }
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
        #endregion

        public override string GetMainObjectNo(ref int numberingStart)
        {
            ICShipmentsInfo mainObject = (ICShipmentsInfo)MainObject;
            ICStocksController objStocksController = new ICStocksController();
            ICStocksInfo objICStocksInfo = new ICStocksInfo();
            DataRow row = BOSApp.GetObjectFromCatche("ICStocks", "ICStockID", mainObject.FK_ICStockID);
            if (row != null) objICStocksInfo = (ICStocksInfo)objStocksController.GetObjectFromDataRow(row);
            else objICStocksInfo = (ICStocksInfo)objStocksController.GetObjectByID(mainObject.FK_ICStockID);
            string mainObjectNo = objICStocksInfo == null
                                    ? base.GetMainObjectNo(ref numberingStart)
                                    : base.GetMainObjectNo(ref numberingStart, objICStocksInfo);
            return mainObjectNo;
        }

        public override void UpdateObjectNumbering(int numberingStart)
        {
            ICShipmentsInfo mainObject = (ICShipmentsInfo)MainObject;
            ICStocksController objStocksController = new ICStocksController();
            ICStocksInfo objICStocksInfo = new ICStocksInfo();
            DataRow row = BOSApp.GetObjectFromCatche("ICStocks", "ICStockID", mainObject.FK_ICStockID);
            if (row != null) objICStocksInfo = (ICStocksInfo)objStocksController.GetObjectFromDataRow(row);
            else objICStocksInfo = (ICStocksInfo)objStocksController.GetObjectByID(mainObject.FK_ICStockID);

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

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            string strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            if (MainObject != null && strTableName == strMainObjectTableName)
            {
                ShipmentItemList.DeleteItemObjects();
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
