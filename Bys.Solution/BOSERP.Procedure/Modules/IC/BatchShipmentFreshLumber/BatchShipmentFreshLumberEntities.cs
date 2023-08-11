using BOSCommon;
using BOSCommon.Constants;
using BOSERP.GenaralLeadger;
using BOSLib;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.BatchShipmentFreshLumber
{
    public class BatchShipmentFreshLumberEntities : GLShipmentEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the item list of the shipment
        /// </summary>
        public BOSItemsEntityList<ICShipmentItemsInfo> ShipmentItemList { get; set; }
        /// <summary>
        /// Gets or sets shipment item list including the item's components        
        /// </summary>
        public BOSItemsEntityList<ICShipmentItemsInfo> ComponentShipmentItemList { get; set; }
        #endregion

        #region Constructor
        public BatchShipmentFreshLumberEntities()
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

            ShipmentItemList.InitBOSList(this,
                                         TableName.ICShipmentsTableName,
                                         TableName.ICShipmentItemsTableName,
                                         BOSList<ICShipmentItemsInfo>.cstRelationForeign);
            ShipmentItemList.ItemTableForeignKey = "FK_ICShipmentID";
        }
        public override void InitGridControlInBOSList()
        {
            ShipmentItemList.InitBOSListGridControl(BatchShipmentFreshLumberModule.ShipmentItemGridControlName);
            DocumentEntryList.InitBOSListGridControl(BatchShipmentFreshLumberModule.DocumentEntryGridControlName);
        }
        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ShipmentItemList.SetDefaultListAndRefreshGridControl();
                DocumentEntryList.SetDefaultListAndRefreshGridControl();
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
            objShipmentsInfo.ICShipmentTypeCombo = ShipmentType.FreshLumber.ToString();
            objShipmentsInfo.ICShipmentDate = DateTime.Now;
            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.New.ToString();
            objShipmentsInfo.ICShipmentShipmentType = ShipmentType.FreshLumber.ToString();
            ICStocksController objStocksController = new ICStocksController();
            ICStocksInfo objStocksInfo = (ICStocksInfo)objStocksController.GetObjectByNo(StockNo.FreshLumberStock);
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

        public void UpdateProductQty()
        {
            //ShipmentItemList.GridControl.RefreshDataSource();
            ICShipmentItemsInfo objShipmentItemsInfo = (ICShipmentItemsInfo)ModuleObjects[TableName.ICShipmentItemsTableName];
            if (objShipmentItemsInfo != null)
            {
                //  objShipmentItemsInfo.ICShipmentItemProductQty = objShipmentItemsInfo.ICShipmentItemWoodQty * objShipmentItemsInfo.ICShipmentItemLength * objShipmentItemsInfo.ICShipmentItemPerimeter;
                ShipmentItemList.ChangeObjectFromList();
            }

        }

        public void UpdateTotalAmount()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentSubTotalAmount = 0;
            foreach (ICShipmentItemsInfo entItem in ShipmentItemList)
            {
                objShipmentsInfo.ICShipmentSubTotalAmount += entItem.ICShipmentItemTotalAmount;
            }
            objShipmentsInfo.ICShipmentTotalAmount = objShipmentsInfo.ICShipmentSubTotalAmount;
            UpdateMainObjectBindingSource();
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

        public void ApproveBatchShipmentFreshLumber()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.Complete.ToString();
            UpdateMainObject();
            ShipmentItemList.SaveItemObjects();
            InvalidateItemComponents();
            SaveAccountingData();
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
        #region Accounting
        public override bool SaveAccountingData()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            List<ACDocumentsInfo> docList = objDocumentsController.GetListItemByACDocumentNo(objShipmentsInfo.ICShipmentNo);
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
            {
                BOSUtil.CopyObject(objShipmentsInfo, objDocumentsInfo);
            }
            if (docList != null)
            {
                foreach (ACDocumentsInfo item in docList)
                {
                    objDocumentsController.DeleteByID(item.ACDocumentID);
                }
            }
            foreach (ACDocumentEntrysInfo item in DocumentEntryList)
            {
                item.ACDocumentEntryID = 0;
            }
            return base.SaveAccountingData();
        }
        #endregion


        public override bool CompleteTransaction()
        {
            ApproveBatchShipmentFreshLumber();
            UpdateAAlocationProposalItemQty();

            return true;
        }
    }
}
