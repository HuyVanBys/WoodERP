using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BOSCommon;
using BOSERP.Modules.Shipment;
using BOSLib;

namespace BOSERP.Modules.BatchShipmentRoundWood
{
    public class BatchShipmentRoundWoodEntities : BaseTransactionEntities
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
        public BatchShipmentRoundWoodEntities()
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
            ShipmentItemList.InitBOSListGridControl(BatchShipmentRoundWoodModule.ShipmentItemGridControlName);
            DocumentEntryList.InitBOSListGridControl(BatchShipmentRoundWoodModule.DocumentEntryGridControlName);
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

        public override void SetDefaultMainObject()
         {
             base.SetDefaultMainObject();
             ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
             objShipmentsInfo.ICShipmentTypeCombo = ShipmentType.RoundwoodShipment.ToString();
             objShipmentsInfo.ICShipmentDate = DateTime.Now;
             objShipmentsInfo.ICShipmentStatus = ShipmentStatus.New.ToString();
             objShipmentsInfo.FK_ICStockID = 5;
             objShipmentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
             objShipmentsInfo.ICShipmentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
             objShipmentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
             //objShipmentsInfo.ICShipmentAcceptanceType = ShipmentAcceptanceType.Production.ToString();
             UpdateMainObjectBindingSource();
         }
        #endregion

         

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ShipmentItemList.Invalidate(iObjectID);

            InvalidateItemComponents();
        }
        #endregion

        public override void SaveModuleObjects()
        {
            ShipmentItemList.SaveItemObjects();
            SaveAccountingData();
        }
        public void UpdateProductQty()
        {
            //ShipmentItemList.GridControl.RefreshDataSource();
            ICShipmentItemsInfo objShipmentItemsInfo = (ICShipmentItemsInfo)ModuleObjects[TableName.ICShipmentItemsTableName];
            if (objShipmentItemsInfo != null)
            {
                objShipmentItemsInfo.ICShipmentItemProductQty = objShipmentItemsInfo.ICShipmentItemWoodQty * objShipmentItemsInfo.ICShipmentItemLength * objShipmentItemsInfo.ICShipmentItemPerimeter;
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

        public void ApprovedBatchShipmentRoundwood()
        {
            //Update shipment status
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.Complete.ToString();
            UpdateMainObject();
            ShipmentItemList.SaveItemObjects();

            InvalidateItemComponents();
            MMAllocationProposalItemsController objAllocationProposalItemsController = new MMAllocationProposalItemsController();
            if (ShipmentItemList != null)
            {
                foreach (ICShipmentItemsInfo item in ShipmentItemList)
                {
                    MMAllocationProposalItemsInfo objAllocationProposalItemsInfo = (MMAllocationProposalItemsInfo)objAllocationProposalItemsController.GetObjectByID(item.FK_MMAllocationProposalItemID);
                    if (objAllocationProposalItemsInfo != null)
                    {
                        objAllocationProposalItemsInfo.MMAllocationProposalItemShippedQty += item.ICShipmentItemProductQty;
                        //objAllocationProposalItemsInfo.MMAllocationProposalItemShippedWoodQty += item.ICShipmentItemWoodQty;
                        objAllocationProposalItemsController.UpdateObject(objAllocationProposalItemsInfo);
                    }
                }
            }
            
            UpdateReceiptItemReference();
            SaveAccountingData();
        }

        public void UpdateReceiptItemReference()
        {
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            foreach (ICShipmentItemsInfo item in ShipmentItemList)
            {
                if (item.FK_ICReceiptItemID > 0)
                {
                    ICReceiptItemsInfo objReceiptItemsInfo = (ICReceiptItemsInfo)objReceiptItemsController.GetObjectByID(item.FK_ICReceiptItemID);
                    if (objReceiptItemsInfo != null)
                    {
                        objReceiptItemsInfo.ICReceiptItemIsSplitted = true;
                        objReceiptItemsController.UpdateObject(objReceiptItemsInfo);
                    }
                }
            }
        }

        #region Accounting
        public override bool SaveAccountingData()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            List<ACDocumentsInfo> docList = objDocumentsController.GetListItemByACDocumentNo(objShipmentsInfo.ICShipmentNo);
            if (!objShipmentsInfo.ICShipmentAcceptanceType.Equals(ShipmentAcceptanceType.RoundWoodSplit.ToString()))
            {
                foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
                {
                    BOSUtil.CopyObject(objShipmentsInfo, objDocumentsInfo);
                }
            }              
            if (docList != null)
            {
                foreach (ACDocumentsInfo item in docList)
                {
                    objDocumentsController.DeleteByID(item.ACDocumentID);
                }
            }
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            foreach (ACDocumentsInfo objDocumentsInfo in docList)
            {
               objDocumentEntrysController.DeleteByForeignColumn("FK_ACDocumentID", objDocumentsInfo.ACDocumentID);
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
            ApprovedBatchShipmentRoundwood();
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)MainObject;
            ((BatchShipmentRoundWoodModule)Module).UpdateReceiptItemReference(objShipmentsInfo.ICShipmentID);
       

            return true;
        }
    }
}
