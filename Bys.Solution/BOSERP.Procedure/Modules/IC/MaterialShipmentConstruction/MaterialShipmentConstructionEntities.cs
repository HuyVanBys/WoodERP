using BOSCommon;
using BOSCommon.Constants;
using BOSERP.GenaralLeadger;
using BOSLib;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.MaterialShipmentConstruction
{
    public class MaterialShipmentConstructionEntities : GLShipmentEntities
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
        #endregion

        #region Constructor
        public MaterialShipmentConstructionEntities()
            : base()
        {
            ShipmentItemList = new BOSItemsEntityList<ICShipmentItemsInfo>();
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
        }
        public override void InitGridControlInBOSList()
        {
            ShipmentItemList.InitBOSListGridControl(MaterialShipmentConstructionModule.ShipmentItemGridControlName);
            DocumentEntryList.InitBOSListGridControl(MaterialShipmentConstructionModule.DocumentEntryGridControlName);
        }
        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ShipmentItemList.SetDefaultListAndRefreshGridControl();
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
            objShipmentsInfo.ICShipmentTypeCombo = ShipmentType.MaterialShipmentConstruction.ToString();
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
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ShipmentItemList.Invalidate(iObjectID);
            InvalidateItemComponents();
        }
        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            ShipmentItemList.SaveItemObjects();
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
            objShipmentsInfo.ICShipmentTotalAmount = objShipmentsInfo.ICShipmentSubTotalAmount;
            BOSApp.RoundByCurrency(objShipmentsInfo, objShipmentsInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }

        public override bool CompleteTransaction()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.Complete.ToString();
            ICProductSeriesInfo objProductSeriesInfo = new ICProductSeriesInfo();
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            UpdateMainObject();
            MMAllocationProposalItemsController objAllocationProposalItemsController = new MMAllocationProposalItemsController();

            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentItemList = new List<ICShipmentItemsInfo>();
            ShipmentItemList.SaveItemObjects();
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
