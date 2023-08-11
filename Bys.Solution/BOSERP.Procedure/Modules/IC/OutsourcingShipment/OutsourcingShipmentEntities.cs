using BOSCommon;
using BOSCommon.Constants;
using BOSERP.GenaralLeadger;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.OutsourcingShipment
{
    public class OutsourcingShipmentEntities : GLShipmentEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSItemsEntityList<ICShipmentItemsInfo> MaterialShipmentItemList { get; set; }
        public BOSItemsEntityList<ICShipmentItemsInfo> ComponentShipmentItemList { get; set; }
        #endregion

        #region Constructor
        public OutsourcingShipmentEntities()
            : base()
        {
            ShipmentItemList = new BOSItemsEntityList<ICShipmentItemsInfo>();
            ComponentShipmentItemList = new BOSItemsEntityList<ICShipmentItemsInfo>();
            MaterialShipmentItemList = new BOSItemsEntityList<ICShipmentItemsInfo>();
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
        }
        public override void InitModuleObjectList()
        {
            ShipmentItemList.InitBOSList(
                                        this,
                                        TableName.ICShipmentsTableName,
                                        TableName.ICShipmentItemsTableName,
                                        BOSList<ICShipmentItemsInfo>.cstRelationForeign);
            ShipmentItemList.ItemTableForeignKey = "FK_ICShipmentID";

            MaterialShipmentItemList.InitBOSList(
                                        this,
                                        TableName.ICShipmentsTableName,
                                        TableName.ICShipmentItemsTableName,
                                        BOSList<ICShipmentItemsInfo>.cstRelationForeign);
            MaterialShipmentItemList.ItemTableForeignKey = "FK_ICShipmentID";

            ComponentShipmentItemList.InitBOSList(this,
                                                  TableName.ICShipmentsTableName,
                                                  TableName.ICShipmentItemsTableName,
                                                  BOSList<ICShipmentItemsInfo>.cstRelationForeign);
            ComponentShipmentItemList.ItemTableForeignKey = "FK_ICShipmentID";
        }
        public override void InitGridControlInBOSList()
        {
            ShipmentItemList.InitBOSListGridControl("fld_dgcShipmentItemsGridControl");
            MaterialShipmentItemList.InitBOSListGridControl("fld_dgcMaterialShipmentItemsGridControl");
            DocumentEntryList.InitBOSListGridControl(OutsourcingShipmentModule.DocumentEntryGridControlName);
        }
        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ShipmentItemList.SetDefaultListAndRefreshGridControl();
                ComponentShipmentItemList.SetDefaultListAndRefreshGridControl();
                MaterialShipmentItemList.SetDefaultListAndRefreshGridControl();
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
            objShipmentsInfo.ICShipmentTypeCombo = ShipmentType.OutsourcingReceipt.ToString();
            objShipmentsInfo.ICShipmentDate = DateTime.Now;
            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.New.ToString();
            objShipmentsInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
            objShipmentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objShipmentsInfo.ICShipmentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objShipmentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            UpdateMainObjectBindingSource();
        }
        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentItemsList = objShipmentItemsController.GetAllShipmentItemByShipmentIDAndType(iObjectID, ModuleName.OutsourcingReceipt.ToString());
            ShipmentItemList.Invalidate(shipmentItemsList.Where(o => o.ICShipmentItemType == ShipmentItemType.Product.ToString()).ToList());
            MaterialShipmentItemList.Invalidate(shipmentItemsList.Where(o => o.ICShipmentItemType == ShipmentItemType.Material.ToString()).ToList());
            InvalidateItemComponents();
        }

        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            ShipmentItemList.SaveItemObjects();
            MaterialShipmentItemList.SaveItemObjects();
            SaveAccountingData();
        }

        #endregion
        public void UpdateTotalAmount()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentSubTotalAmount = 0;
            foreach (ICShipmentItemsInfo entItem in ShipmentItemList)
            {
                objShipmentsInfo.ICShipmentSubTotalAmount += entItem.ICShipmentItemTotalAmount;
                entItem.ICShipmentItemTotalAmount = entItem.ICShipmentItemProductQty * entItem.ICShipmentItemProductUnitPrice;
                BOSApp.RoundByCurrency(entItem, objShipmentsInfo.FK_GECurrencyID);
            }
            foreach (ICShipmentItemsInfo entItem in MaterialShipmentItemList)
            {
                objShipmentsInfo.ICShipmentSubTotalAmount += entItem.ICShipmentItemTotalAmount;
                entItem.ICShipmentItemTotalAmount = entItem.ICShipmentItemProductQty * entItem.ICShipmentItemProductUnitPrice;
                BOSApp.RoundByCurrency(entItem, objShipmentsInfo.FK_GECurrencyID);
            }
            objShipmentsInfo.ICShipmentTotalAmount = objShipmentsInfo.ICShipmentSubTotalAmount;
            BOSApp.RoundByCurrency(objShipmentsInfo, objShipmentsInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }

        public override bool CompleteTransaction()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.Complete.ToString();
            UpdateMainObject();
            SaveAccountingData();
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

    }

}
