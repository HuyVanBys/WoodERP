using BOSCommon;
using BOSCommon.Constants;
using BOSERP.GenaralLeadger;
using BOSERP.Modules.IC.BatchShipmentDryLumber.Localization;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchShipmentFreshLumber
{
    #region BatchShipmentFreshLumber
    public class BatchShipmentFreshLumberModule : GLShipmentModule
    {

        #region Constants
        private const string NewConstants = "***NEW***";
        public const string ShipmentItemGridControlName = "fld_dgcICShipmentItem1s";
        public const string DocumentEntryGridControlName = "fld_dgcACDocumentEntrys";
        public const string ButtonShowInventoryStock = "fld_btnShowInventoryStock";
        #endregion
        #region Private Properties

        BOSComponent.BOSButton InventoryStock;
        #endregion
        public BatchShipmentFreshLumberModule()
        {
            Name = "BatchShipmentFreshLumber";
            CurrentModuleEntity = new BatchShipmentFreshLumberEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            InventoryStock = (BOSComponent.BOSButton)Controls[BatchShipmentFreshLumberModule.ButtonShowInventoryStock];
        }
        public override void ActionEdit()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                InventoryStock.Visible = true;
                base.ActionEdit();
            }
        }

        public override void ActionNew()
        {
            BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentsInfo.ICShipmentAcceptanceType = ShipmentAcceptanceType.None.ToString();
            InventoryStock.Visible = true;
            base.ActionNew();
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            //return base.GetSearchData(ref searchQuery);
            ICShipmentsController objShipmentsController = new ICShipmentsController();
            ACObjectsController objObjectsController = new ACObjectsController();
            ICShipmentsInfo searchObject = (ICShipmentsInfo)CurrentModuleEntity.SearchObject;
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);
            DataSet ds = objShipmentsController.GetShipmentListAllType(searchObject.ICShipmentNo,
                                                                    searchObject.FK_BRBranchID,
                                                                    objObjectsInfo.ACObjectID,
                                                                    objObjectsInfo.ACObjectType,
                                                                    searchObject.FK_ICStockID,
                                                                    searchObject.FK_HREmployeeID,
                                                                    ShipmentType.FreshLumber.ToString(),
                                                                    null,
                                                                    searchObject.ShipmentDateFrom,
                                                                    searchObject.ShipmentDateTo);

            return ds;
        }
        public void AddItemToShipmentItemsList()
        {
            BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
            ICShipmentItemsInfo objShipmentItemsInfo = (ICShipmentItemsInfo)entity.ModuleObjects[TableName.ICShipmentItemsTableName];
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            ACAccountsInfo objAccountsInfo = new ACAccountsInfo();
            ACAccountsController objAccountsControlle = new ACAccountsController();
            objAccountsInfo = (ACAccountsInfo)objAccountsControlle.GetObjectByNo(AccAccount.Acc1542);
            string CD = string.Empty;
            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = new MMOperationsInfo();
            objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByID(objShipmentsInfo.FK_MMOperationID);
            if (objOperationsInfo != null)
            {
                CD = objOperationsInfo.MMOperationNo;
            }
            if (objShipmentItemsInfo.FK_ICProductID > 0)
            {
                //ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objShipmentItemsInfo.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    entity.SetValuesAfterValidateProduct(objShipmentItemsInfo.FK_ICProductID, objShipmentItemsInfo);
                    objShipmentItemsInfo.FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
                    objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                }
                if (objAccountsInfo != null && CD == OperationNo.Say.ToString())
                {
                    objShipmentItemsInfo.FK_ACAccountID = objAccountsInfo.ACAccountID;
                }

                if (objShipmentsInfo != null)
                {
                    objShipmentItemsInfo.FK_MMBatchProductID = objShipmentsInfo.FK_MMBatchProductID;
                    objShipmentItemsInfo.FK_MMOperationID = objShipmentsInfo.FK_MMOperationID;
                    objShipmentItemsInfo.FK_ICProductAttributeWoodTypeID = objShipmentsInfo.FK_ICProductAttributeWoodTypeID;
                    objShipmentItemsInfo.FK_GECountryID = objShipmentsInfo.FK_GECountryID;
                    objShipmentItemsInfo.FK_ICProductAttributeTTMTID = objShipmentsInfo.FK_ICProductAttributeTTMTID;
                }
                entity.ShipmentItemList.AddObjectToList();
                //entity.ShipmentItemList.Add(objShipmentItemsInfo);
                entity.ShipmentItemList.GridControl.RefreshDataSource();

            }
            UpdateTotalAmount();
        }
        //delete item list
        public void DeleteItemFromShipmentItemsList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
                entity.ShipmentItemList.RemoveSelectedRowObjectFromList();
                ChangeItemFromShipmentItemsList();
            }
        }
        public void ChangeItemFromShipmentItemsList(ICShipmentItemsInfo objShipmentItemsInfo)
        {
            BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
            objShipmentItemsInfo.ICShipmentItemProductQty = Math.Round((objShipmentItemsInfo.ICShipmentItemWoodQty
                                                          * objShipmentItemsInfo.ICShipmentItemLength
                                                          * objShipmentItemsInfo.ICShipmentItemPerimeter), 4, MidpointRounding.AwayFromZero);
            entity.SetProductPriceByProductUnitPrice();
            //UpdateProductQty();
            //entity.ShipmentItemList.ChangeObjectFromList();
            // UpdateProductQty();
        }
        public void ChangeItemFromShipmentItemsList()
        {
            BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
            entity.SetProductPriceByProductUnitPrice();
            entity.ShipmentItemList.ChangeObjectFromList();

            UpdateTotalAmount();
        }
        public void SelectSeriesNoDefault()
        {
            BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
            //GIANG ADD - START- 10-03-2016 - GET SERIESNO BY STOCK AND PRODUCTID - PRODUCTDESC
            //DataGenerator.SelectSeriesNoDefault(entity.ShipmentItemList);
            //GIANG ADD - END- 10-03-2016 - GET SERIESNO BY STOCK AND PRODUCTID - PRODUCTDESC
            entity.ShipmentItemList.GridControl.RefreshDataSource();
        }

        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
                entity.UpdateTotalAmount();
                UpdateDocumentEntries();
            }
        }

        public void ChangeItemlist(ICShipmentItemsInfo item)
        {
            BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            ICProductSeriesInfo objProductSeriesInfo = (ICProductSeriesInfo)objProductSeriesController.GetObjectByID(item.FK_ICProductSerieID);
            int stockid = item.FK_ICStockID;
            if (objProductSeriesInfo != null)
            {
                // UpdateProductQty();
                BOSUtil.CopyObject(objProductSeriesInfo, item);
                item.FK_ICStockID = stockid;
                item.ICShipmentItemProductSerialNo = objProductSeriesInfo.ICProductSerieNo;
                item.ICShipmentItemLength = objProductSeriesInfo.ICProductSerieProductLength;
                item.ICShipmentItemPerimeter = objProductSeriesInfo.ICProductSerieProductPerimeter;
                item.ICShipmentItemProductQty = item.ICShipmentItemWoodQty * item.ICShipmentItemLength * item.ICShipmentItemPerimeter;
                // ShipmentItemList.ChangeObjectFromList();
                entity.ShipmentItemList.GridControl.RefreshDataSource();
                //UpdateProductQty();           
            }
            if (objShipmentsInfo != null)
            {
                item.FK_MMBatchProductID = objShipmentsInfo.FK_MMBatchProductID;
                item.FK_MMOperationID = objShipmentsInfo.FK_MMOperationID;
            }
            // entity.ShipmentItemList.ChangeObjectFromList();
            // UpdateProductQty();

        }
        public void UpdateProductQty()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
                entity.UpdateProductQty();
            }
        }

        public void NewFromBatchLumber()
        {
            ActionNew();
            BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            ICProductsController objProductsController = new ICProductsController();

            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<ICReceiptItemsInfo> receiptItemList = objReceiptItemsController.GetItemForFreshLumberShipment();

            guiFind<ICReceiptItemsInfo> guiFind = new guiFind<ICReceiptItemsInfo>(TableName.ICReceiptItemsTableName,
                                                                                  receiptItemList,
                                                                                  this, true, true,
                                                                                    new string[] { "MMBatchProductNo"
                                                                                                        , "ICReceiptNo"}, true, true);
            if (guiFind.ShowDialog() == DialogResult.OK)
            {
                List<ICReceiptItemsInfo> selectedReceiptItemList = (List<ICReceiptItemsInfo>)guiFind.SelectedObjects;
                List<ICReceiptItemsInfo> receiptCheckList = new List<ICReceiptItemsInfo>();
                if (guiFind.SelectedObjects != null && guiFind.SelectedObjects.Count > 0)
                {
                    receiptCheckList = (List<ICReceiptItemsInfo>)selectedReceiptItemList.Where(x => x.FK_MMBatchProductID != guiFind.SelectedObjects[0].FK_MMBatchProductID).ToList();
                }
                if (receiptCheckList != null && receiptCheckList.Count > 0)
                {
                    MessageBox.Show(BatchShipmentFreshLumberLocalizedResources.ChooseMultiBatchProduct, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ActionCancel();
                    NewFromBatchLumber();
                }
                else
                {
                    objShipmentsInfo.FK_MMBatchProductID = selectedReceiptItemList[0].FK_MMBatchProductID;
                    ICReceiptsController objReceiptsController = new ICReceiptsController();
                    ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)objReceiptsController.GetObjectByID(selectedReceiptItemList[0].FK_ICReceiptID);
                    if (objReceiptsInfo != null)
                    {
                        BOSUtil.CopyObject(objReceiptsInfo, objShipmentsInfo);
                        objShipmentsInfo.ICShipmentNo = NewConstants;
                        objShipmentsInfo.ICShipmentTypeCombo = ShipmentType.FreshLumber.ToString();
                        objShipmentsInfo.ICShipmentDate = DateTime.Now;
                        objShipmentsInfo.ICShipmentStatus = ShipmentStatus.New.ToString();
                        objShipmentsInfo.ICShipmentShipmentType = ShipmentType.FreshLumber.ToString();
                        ICStocksController objStocksController = new ICStocksController();
                        objShipmentsInfo.ICShipmentAcceptanceType = ShipmentAcceptanceType.BatchProduct.ToString();
                        ICStocksInfo objStocksInfo = (ICStocksInfo)objStocksController.GetObjectByNo(StockNo.FreshLumberStock);
                        if (objStocksInfo != null)
                        {
                            objShipmentsInfo.FK_ICStockID = objStocksInfo.ICStockID;
                        }
                        objShipmentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
                        objShipmentsInfo.ICShipmentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
                        objShipmentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;

                    }
                    if (selectedReceiptItemList != null)
                    {
                        foreach (ICReceiptItemsInfo item in selectedReceiptItemList)
                        {
                            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
                            BOSUtil.CopyObject(item, objShipmentItemsInfo);
                            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                            if (objProductsInfo != null)
                                objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                            objShipmentItemsInfo.FK_ICProductID = item.FK_ICProductID;
                            //TNDLoc [ADD][09/03/2016][References ID],START
                            objShipmentItemsInfo.FK_ICReceiptItemID = item.Id;
                            //TNDLoc [ADD][09/03/2016][References ID],END
                            objShipmentItemsInfo.ICShipmentItemWoodQty = item.ICReceiptItemWoodQty;
                            objShipmentItemsInfo.ICShipmentItemProductQty = item.ICReceiptItemProductQty;
                            objShipmentItemsInfo.FK_ICProductAttributeTTMTID = item.FK_ICProductAttributeTTMTID;
                            objShipmentItemsInfo.ICShipmentItemWidth = item.ICReceiptItemProductWidth;
                            objShipmentItemsInfo.ICShipmentItemLength = item.ICReceiptItemProductLength;
                            objShipmentItemsInfo.ICShipmentItemHeight = item.ICReceiptItemProductHeight;
                            objShipmentItemsInfo.ICShipmentItemWidthMax = item.ICReceiptItemWidthMax;
                            objShipmentItemsInfo.ICShipmentItemHeightMax = item.ICReceiptItemHeightMax;
                            objShipmentItemsInfo.ICShipmentItemLengthMax = item.ICReceiptItemLenghtMax;
                            objShipmentItemsInfo.ICShipmentItemPerimeter = item.ICReceiptItemProductPerimeter;
                            objShipmentItemsInfo.ICShipmentItemTotalAmount = item.ICReceiptItemTotalCost;
                            objShipmentItemsInfo.ICShipmentItemProductUnitPrice = item.ICReceiptItemProductUnitCost;
                            objShipmentItemsInfo.ICShipmentItemProductQty = Math.Round(item.ICReceiptItemProductQty, 4, MidpointRounding.AwayFromZero);
                            entity.ShipmentItemList.Add(objShipmentItemsInfo);
                            entity.SetProductPriceByProductUnitPrice(objShipmentItemsInfo);
                            entity.ShipmentItemList.GridControl.RefreshDataSource();
                        }
                    }
                    UpdateTotalAmount();
                }
            }
            else
            {
                ActionCancel();
            }
        }

        public void NewFromAlloactionProposal()
        {
            ActionNew();
            BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
            // ICShipmentsInfo oldshipmentsInfo = (ICShipmentsInfo)entity.MainObject.OldObject;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            ICProductsController objProductsController = new ICProductsController();

            MMAllocationProposalItemsController objAllocationProposalItemsController = new MMAllocationProposalItemsController();
            List<MMAllocationProposalItemsInfo> objAllocationProposalItemsCheck = new List<MMAllocationProposalItemsInfo>();
            List<MMAllocationProposalItemsInfo> allocationProposalItemList = objAllocationProposalItemsController.GetItemForFreshLumberShipment();
            guiFind<MMAllocationProposalItemsInfo> guiFind = new guiFind<MMAllocationProposalItemsInfo>(TableName.MMAllocationProposalItemsTableName,
                                                                                                        allocationProposalItemList,
                                                                                                        this,
                                                                                                        true,
                                                                                                        true,
                                                                                                        new string[] { "MMBatchProductNo"
                                                                                                        , "MMAllocationProposalNo"});
            if (guiFind.ShowDialog() == DialogResult.OK)
            {
                List<MMAllocationProposalItemsInfo> AllocationProposalItemsList = (List<MMAllocationProposalItemsInfo>)guiFind.SelectedObjects;

                if (guiFind.SelectedObjects != null && guiFind.SelectedObjects.Count > 0)
                {
                    objAllocationProposalItemsCheck = (List<MMAllocationProposalItemsInfo>)AllocationProposalItemsList.Where(x => x.FK_MMAllocationProposalID != guiFind.SelectedObjects[0].FK_MMAllocationProposalID).ToList();
                }
                if (objAllocationProposalItemsCheck != null && objAllocationProposalItemsCheck.Count > 0)
                {
                    MessageBox.Show(string.Format(MaterialShipmentLocalizedResources.ChooseMulltiSaleOrderMessage), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ActionCancel();
                    NewFromAlloactionProposal();
                }
                else
                {
                    MMAllocationProposalsController objAllocationProposalsController = new MMAllocationProposalsController();
                    MMAllocationProposalsInfo objAllocationProposalsInfo = (MMAllocationProposalsInfo)objAllocationProposalsController.GetObjectByID(guiFind.SelectedObjects[0].FK_MMAllocationProposalID);
                    if (objAllocationProposalsInfo != null)
                    {
                        objShipmentsInfo.FK_ICProductID = objAllocationProposalsInfo.FK_ICProductID;
                        objShipmentsInfo.FK_MMBatchProductID = objAllocationProposalsInfo.FK_MMBatchProductID;
                        objShipmentsInfo.FK_MMOperationID = objAllocationProposalsInfo.FK_MMOperationID;
                        // objShipmentsInfo.ICShipmentShipmentType = ShipmentType.Wood.ToString();
                        objShipmentsInfo.FK_ICProductAttributeTTMTID = objAllocationProposalsInfo.FK_ICProductAttributeTTMTID;
                        //objShipmentsInfo.FK_MMOperationID = objAllocationProposalsInfo.FK_MMOperationID;
                        objShipmentsInfo.ICShipmentAcceptanceType = ShipmentAcceptanceType.Allocation.ToString();
                        objShipmentsInfo.ICShipmentPONo = objAllocationProposalsInfo.MMAllocationProposalPONo;

                        entity.UpdateMainObjectBindingSource();
                    }
                    if (AllocationProposalItemsList != null)
                    {
                        foreach (MMAllocationProposalItemsInfo item in AllocationProposalItemsList)
                        {
                            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
                            BOSUtil.CopyObject(item, objShipmentItemsInfo);
                            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                            if (objProductsInfo != null)
                                objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                            objShipmentItemsInfo.ICShipmentItemProductQty = Math.Round((item.MMAllocationProposalItemQty - item.MMAllocationProposalItemShippedQty - item.MMAllocationProposalItemCanceledQty), 4, MidpointRounding.AwayFromZero);
                            objShipmentItemsInfo.FK_MMAllocationProposalItemID = item.MMAllocationProposalItemID;
                            objShipmentItemsInfo.ICShipmentItemWoodQty = item.MMAllocationProposalItemWoodQty - item.MMAllocationProposalItemShippedWoodQty;
                            //objShipmentItemsInfo.ICShipmentItemLength=item.MMa
                            objShipmentItemsInfo.FK_ICProductID = item.FK_ICProductID;
                            objShipmentItemsInfo.FK_ICProductAttributeTTMTID = item.FK_ICProductAttributeTTMTID;
                            //entity.SetProductPriceByProductUnitPrice(objShipmentItemsInfo);
                            entity.ShipmentItemList.Add(objShipmentItemsInfo);
                            entity.ShipmentItemList.GridControl.RefreshDataSource();
                        }
                    }
                    UpdateTotalAmount();
                }
            }
            else
            {
                ActionCancel();
            }

        }
        public void ActionNewFromBatchProductSheduleWood()
        {
            ActionNew();
            BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            MMAllocationProposalItemsController objAllocationProposalItemsController = new MMAllocationProposalItemsController();
            MMAllocationProposalsController objAllocationProposalsController = new MMAllocationProposalsController();
            ICProductsController objProductsController = new ICProductsController();

            List<MMAllocationProposalItemsInfo> objAllocationProposalItemsCheck = new List<MMAllocationProposalItemsInfo>();
            List<MMAllocationProposalItemsInfo> allocationProposalItemsList = objAllocationProposalItemsController.GetNewProposalFromWood(ShipmentType.Wood.ToString(),
                                                                                                                                            BOSApp.CurrentUsersInfo.ADUserID,
                                                                                                                                            ModuleName.AllocationProposal,
                                                                                                                                            ADDataViewPermissionType.Module,
                                                                                                                                            BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            guiFind<MMAllocationProposalItemsInfo> guifind = new guiFind<MMAllocationProposalItemsInfo>(TableName.MMAllocationProposalItemsTableName, allocationProposalItemsList, this, true, true, new string[] { "MMAllocationProposalNo" }, true, true);
            guifind.ShowDialog();
            if (guifind.DialogResult == DialogResult.OK)
            {
                //ChangeAllocationProposalProductType(MMAllocationProposalType);
                List<MMAllocationProposalItemsInfo> AllocationProposalItemsList = (List<MMAllocationProposalItemsInfo>)guifind.SelectedObjects;

                if (guifind.SelectedObjects != null && guifind.SelectedObjects.Count > 0)
                {
                    objAllocationProposalItemsCheck = (List<MMAllocationProposalItemsInfo>)AllocationProposalItemsList.Where(x => x.FK_MMAllocationProposalID != guifind.SelectedObjects[0].FK_MMAllocationProposalID).ToList();
                }
                if (objAllocationProposalItemsCheck != null && objAllocationProposalItemsCheck.Count > 0)
                {
                    MessageBox.Show(string.Format(MaterialShipmentLocalizedResources.ChooseMulltiSaleOrderMessage), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ActionCancel();
                    ActionNewFromBatchProductSheduleWood();
                }
                else
                {

                    MMAllocationProposalsInfo objAllocationProposalsInfo = (MMAllocationProposalsInfo)objAllocationProposalsController.GetObjectByID(guifind.SelectedObjects[0].FK_MMAllocationProposalID);
                    if (objAllocationProposalsInfo != null)
                    {
                        objShipmentsInfo.FK_ICProductID = objAllocationProposalsInfo.FK_ICProductID;
                        objShipmentsInfo.FK_MMBatchProductID = objAllocationProposalsInfo.FK_MMBatchProductID;
                        objShipmentsInfo.FK_MMOperationID = objAllocationProposalsInfo.FK_MMOperationID;
                        objShipmentsInfo.ICShipmentShipmentType = ShipmentType.Wood.ToString();
                        objShipmentsInfo.FK_ICProductAttributeTTMTID = objAllocationProposalsInfo.FK_ICProductAttributeTTMTID;
                        //objShipmentsInfo.FK_MMOperationID = objAllocationProposalsInfo.FK_MMOperationID;

                        entity.UpdateMainObjectBindingSource();
                    }
                    if (AllocationProposalItemsList != null)
                    {
                        foreach (MMAllocationProposalItemsInfo item in AllocationProposalItemsList)
                        {
                            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
                            BOSUtil.CopyObject(item, objShipmentItemsInfo);
                            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                            if (objProductsInfo != null)
                                objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                            objShipmentItemsInfo.ICShipmentItemProductQty = Math.Round((item.MMAllocationProposalItemQty - item.MMAllocationProposalItemShippedQty - item.MMAllocationProposalItemCanceledQty), 4, MidpointRounding.AwayFromZero);
                            objShipmentItemsInfo.FK_MMAllocationProposalItemID = item.MMAllocationProposalItemID;
                            objShipmentItemsInfo.ICShipmentItemWoodQty = item.MMAllocationProposalItemWoodQty - item.MMAllocationProposalItemShippedWoodQty;
                            //objShipmentItemsInfo.ICShipmentItemLength=item.MMa
                            objShipmentItemsInfo.FK_ICProductAttributeTTMTID = item.FK_ICProductAttributeTTMTID;
                            entity.SetProductPriceByProductUnitPrice(objShipmentItemsInfo);
                            entity.ShipmentItemList.Add(objShipmentItemsInfo);
                            entity.ShipmentItemList.GridControl.RefreshDataSource();
                        }
                    }
                    UpdateTotalAmount();
                }
            }
            else
                ActionCancel();
        }
        public void NewAcceptance()
        {
            ActionNew();
            BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            ICReceiptsController objReceiptsController = new ICReceiptsController();
            ICProductsController objProductsController = new ICProductsController();
            List<ICReceiptItemsInfo> objreceiptItemCheck = new List<ICReceiptItemsInfo>();
            List<ICReceiptItemsInfo> receiptItemList = objReceiptItemsController.GetReceiptItemByTypeLumber(ReceiptType.PurchaseReceipt.ToString(), ReceiptReceiptType.Lumber.ToString());
            guiFind<ICReceiptItemsInfo> guifind = new guiFind<ICReceiptItemsInfo>(TableName.ICReceiptItemsTableName
                                                                                  , receiptItemList
                                                                                  , this
                                                                                  , true
                                                                                  , true
                                                                                  , new string[] { "ICReceiptNo" });
            guifind.ShowDialog();
            if (guifind.DialogResult == DialogResult.OK)
            {
                //ChangeAllocationProposalProductType(MMAllocationProposalType);
                List<ICReceiptItemsInfo> itemList = (List<ICReceiptItemsInfo>)guifind.SelectedObjects;

                if (guifind.SelectedObjects != null && guifind.SelectedObjects.Count > 0)
                {
                    objreceiptItemCheck = (List<ICReceiptItemsInfo>)itemList.Where(x => x.FK_ICReceiptID != guifind.SelectedObjects[0].FK_ICReceiptID).ToList();
                }
                if (objreceiptItemCheck != null && objreceiptItemCheck.Count > 0)
                {
                    MessageBox.Show(string.Format(BatchShipmentDryLumberLocalizedResources.ChooseMulltiReceiptMessage), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ActionCancel();
                    NewAcceptance();
                }
                else
                {

                    ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)objReceiptsController.GetObjectByID(guifind.SelectedObjects[0].FK_ICReceiptID);
                    if (objReceiptsInfo != null)
                    {
                        objShipmentsInfo.FK_ICProductID = objReceiptsInfo.FK_ICProductID;
                        objShipmentsInfo.FK_GECountryID = objReceiptsInfo.FK_GECountryID;
                        objShipmentsInfo.FK_ICProductAttributeWoodTypeID = objReceiptsInfo.FK_ICProductAttributeWoodTypeID;
                        objShipmentsInfo.FK_ICStockID = objReceiptsInfo.FK_ICStockID;
                        objShipmentsInfo.ICShipmentExchangeRate = objReceiptsInfo.ICReceiptExchangeRate;
                        objShipmentsInfo.FK_ICProductAttributeTTMTID = objReceiptsInfo.FK_ICProductAttributeTTMTID;
                        objShipmentsInfo.ICShipmentContainerNo = objReceiptsInfo.ICReceiptContainerNo;
                        objShipmentsInfo.ICShipmentReference = objReceiptsInfo.ICReceiptNo;
                        objShipmentsInfo.ICShipmentShipmentType = ShipmentShipmentType.FreshLumber.ToString();
                        objShipmentsInfo.ICShipmentAcceptanceType = ShipmentAcceptanceType.Acceptance.ToString();
                        entity.UpdateMainObjectBindingSource();
                    }
                    if (itemList != null)
                    {
                        foreach (ICReceiptItemsInfo item in itemList)
                        {
                            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
                            BOSUtil.CopyObject(item, objShipmentItemsInfo);
                            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                            if (objProductsInfo != null && item.FK_ACAccountID == 0)
                            {
                                objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                            }
                            objShipmentItemsInfo.ICShipmentItemBatchProductItemProductSerial = item.ICReceiptItemProductSerialNo;
                            objShipmentItemsInfo.FK_ICProductAttributeWoodTypeID = item.FK_ICProductAttributeWoodTypeID;
                            objShipmentItemsInfo.FK_ICProductAttributeTTMTID = item.FK_ICProductAttributeTTMTID;
                            objShipmentItemsInfo.FK_ICProductAttributeQualityID = item.FK_ICProductAttributeQualityID;
                            //objShipmentItemsInfo.ICShipmentItemProductUnitPrice = item.ICReceiptItemProductUnitCost;
                            //objShipmentItemsInfo.ICShipmentItemTotalAmount = item.ICReceiptItemTotalCost;
                            objShipmentItemsInfo.ICShipmentItemProductUnitPrice = item.ICInventoryStockUnitCost;
                            objShipmentItemsInfo.ICShipmentItemTotalAmount = item.ICInventoryStockUnitCost * item.ICReceiptItemProductQty;

                            objShipmentItemsInfo.FK_ICReceiptItemID = item.Id;
                            objShipmentItemsInfo.ICShipmentItemLength = item.ICReceiptItemProductLength;
                            objShipmentItemsInfo.ICShipmentItemLengthMax = item.ICReceiptItemLenghtMax;
                            objShipmentItemsInfo.ICShipmentItemLengthMin = item.ICReceiptItemLenghtMin;
                            objShipmentItemsInfo.ICShipmentItemHeight = item.ICReceiptItemProductHeight;
                            objShipmentItemsInfo.ICShipmentItemWidth = item.ICReceiptItemProductWidth;
                            objShipmentItemsInfo.ICShipmentItemWidthMin = item.ICReceiptItemWidthMin;
                            objShipmentItemsInfo.ICShipmentItemProductQty = Math.Round(item.ICReceiptItemProductQty, 4, MidpointRounding.AwayFromZero);
                            entity.ShipmentItemList.Add(objShipmentItemsInfo);

                        }
                        entity.ShipmentItemList.GridControl.RefreshDataSource();
                    }
                    UpdateTotalAmount();
                }
            }
            else
                ActionCancel();
        }
        /// <summary>
        /// Called from the screen, when the user changes the object
        /// </summary>
        /// <param name="objectAccessKey">Object access key</param>
        public void ChangeObject(string objectAccessKey)
        {
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo obj = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            ICShipmentsInfo shipment = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            shipment.ACObjectAccessKey = objectAccessKey;
            obj = objObjectsController.GetObjectByIDAndType(obj.ACObjectID, obj.ACObjectType);
            if (obj != null)
            {
                shipment.ICShipmentDeliveryContactName = obj.ACObjectName;
                CurrentModuleEntity.UpdateMainObjectBindingSource();
            }
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            if (objShipmentsInfo.ICShipmentStatus == ShipmentStatus.Complete.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchShipmentFreshLumber", false);
                InventoryStock.Visible = false;
            }
            else
            {
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchShipmentFreshLumber", true);
            }
        }

        public void ApproveBatchShipmentFreshLumber()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
                entity.ShipmentItemList.EndCurrentEdit();
                //TNDLoc [ADD][15/12/2015][Check product serie ID],START
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = new ICProductsInfo();
                foreach (ICShipmentItemsInfo objShipmentItemsInfo in entity.ShipmentItemList)
                {
                    objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objShipmentItemsInfo.FK_ICProductID);
                    if (objProductsInfo.ICProductType != ProductType.Service.ToString() && !objProductsInfo.IsAsset)
                    {
                        if (!objShipmentItemsInfo.HasComponent && objShipmentItemsInfo.FK_ICProductSerieID == 0)
                        {
                            MessageBox.Show(string.Format(ShipmentLocalizedResources.ItemSerieNoIsRequiredMessage, objShipmentItemsInfo.ICShipmentItemProductDesc), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                //TNDLoc [ADD][15/12/2015][Check product serie ID],END
                entity.ShipmentItemList.BackupList.Clear();
                if (entity.ShipmentItemList.IsInvalidInventory(TransactionUtil.cstInventoryShipment))
                {
                    return;
                }
                //TNDLoc [ADD][29/12/2015][Check WoodQty],START
                if (entity.ShipmentItemList.IsInvalidWoodQty())
                {
                    return;
                }
                //TNDLoc [ADD][29/12/2015][Check WoodQty],END

                ActionComplete();

                //ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
                //entity.ApproveBatchShipmentFreshLumber();
                ////if (objShipmentsInfo.ICShipmentShipmentType == ShipmentType.Wood.ToString())
                ////{
                //    entity.UpdateAAlocationProposalItemQty();
                ////}
                //ModuleAfterCompleted();
            }
        }

        public override int ActionSave()
        {
            //NNGiang ADD - 13-04-2016 Start [Check QTY With RECEIPT QTY]
            BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
            entity.ShipmentItemList.EndCurrentEdit();
            if (!CheckQtyInReceiptItem(entity.ShipmentItemList))
            {
                return 0;
            }
            //NNGiang ADD - 13-04-2016 END [Check QTY With RECEIPT QTY]
            return base.ActionSave();
        }

        public List<ICProductAttributesInfo> GetProductItemAttributeQuality()
        {
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributesList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.Quality.ToString());
            if (productAttributesList != null)
            {
                return productAttributesList;
            }
            else
                return null;
        }
        public List<ICProductAttributesInfo> GetProductItemAttributeWoodType()
        {
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributesList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.WoodType.ToString());
            if (productAttributesList != null)
            {
                return productAttributesList;
            }
            else
                return null;
        }
        public List<ICProductAttributesInfo> GetProductItemAttributeTTMT()
        {
            ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
            List<ICProductAttributesInfo> productAttributesList = objProductAttributesController.GetProductAttributesByProductAttributeGroup(ProductAttributeGroup.TTMT.ToString());
            if (productAttributesList != null)
            {
                return productAttributesList;
            }
            else
                return null;
        }
        #region Accounting
        protected override void UpdateDocumentEntries()
        {
            BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;

            ICProductsController productController = new ICProductsController();
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();

            string documentType = AccDocumentType.XuatKhoPhachTuoiCongDoanCua.ToString();
            string entryType = AccEntryType.XuatKhoPhachTuoiCongDoanCua.ToString();

            if (objShipmentsInfo.ICShipmentTypeCombo == ShipmentType.FreshLumber.ToString())
            {
                MMOperationsInfo objOperationsInfo = new MMOperationsInfo();
                MMOperationsController objOperationsController = new MMOperationsController();
                string CD = string.Empty;
                objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByID(objShipmentsInfo.FK_MMOperationID);
                if (objOperationsInfo != null)
                {
                    CD = objOperationsInfo.MMOperationNo;
                }
                if (CD == OperationNo.Say.ToString())
                {
                    documentType = AccDocumentType.XuatKhoPhachTuoiCongDoanSay.ToString();
                    entryType = AccEntryType.XuatKhoPhachTuoiCongDoanSay.ToString();
                }
                else
                {
                    documentType = AccDocumentType.XuatKhoPhachTuoiCongDoanCua.ToString();
                    entryType = AccEntryType.XuatKhoPhachTuoiCongDoanCua.ToString();
                }




            }

            //else if (objShipmentsInfo.ICShipmentTypeCombo == ShipmentType.SaleShipment.ToString())
            //{
            //    documentType = AccDocumentType.XuatKhoBanHang.ToString();
            //    entryType = AccEntryType.XuatKhoBanHang.ToString();
            //}
            //else if (objShipmentsInfo.ICShipmentTypeCombo == ShipmentType.EquipmentDecreasing.ToString())
            //{
            //    documentType = AccDocumentType.GiamCCDC.ToString();
            //    entryType = AccEntryType.GhiGiamCCDC.ToString();
            //}
            //else if (objShipmentsInfo.ICShipmentTypeCombo == ShipmentType.EquipmentShipment.ToString())
            //{
            //    documentType = AccDocumentType.XuatCCDC.ToString();
            //    entryType = AccEntryType.XuatCCDC.ToString();
            //}


            ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        documentType,
                                                                        entryType);
            Dictionary<ACDocumentEntrysInfo, List<ICShipmentItemsInfo>> documentEntryAccounts = new Dictionary<ACDocumentEntrysInfo, List<ICShipmentItemsInfo>>();
            List<int> productAccountID = new List<int>();

            if (entity.ShipmentItemList != null)
            {

                foreach (ICShipmentItemsInfo shipmentItem in entity.ShipmentItemList)
                {

                    ACDocumentEntrysInfo entry = entity.DocumentEntryList.FirstOrDefault(e => e.ACEntryTypeName == entryType
                                                                   && e.FK_ACCreditAccountID == shipmentItem.FK_ACAccountID);
                    //if (defaultEntry != null && entry!=null)
                    //{
                    //    entry.FK_ACCreditAccountID = defaultEntry.ACDocTypeEntryAccountDefaultCredit;
                    //    entry.FK_ACDebitAccountID = defaultEntry.ACDocTypeEntryAccountDefaultDebit;
                    //}

                    if (entry == null && defaultEntry != null)
                    {
                        entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, entity.DocumentEntryList);
                        entry.FK_ACCreditAccountID = shipmentItem.FK_ACAccountID;
                    }
                    if (entry != null && !documentEntryAccounts.ContainsKey(entry))
                    {
                        documentEntryAccounts.Add(entry, new List<ICShipmentItemsInfo>());
                        productAccountID.Add(entry.FK_ACCreditAccountID);
                    }
                    if (entry != null)
                        documentEntryAccounts[entry].Add(shipmentItem);
                }
            }

            //update document entry amount
            if (documentEntryAccounts.Count != 0)
            {
                ACDocumentEntrysInfo item = null;
                foreach (ACDocumentEntrysInfo entry in documentEntryAccounts.Keys)
                {
                    entry.ACDocumentEntryAmount = documentEntryAccounts[entry].Sum(i => i.ICShipmentItemProductUnitPrice * i.ICShipmentItemProductQty);
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objShipmentsInfo.ICShipmentExchangeRate;
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryAmount", objShipmentsInfo.FK_GECurrencyID);
                    item = entry;
                }


                ACDocumentsInfo objDocumentsInfo = entity.DocumentList.FirstOrDefault(d => d.ACDocumentTypeName == documentType);
                if (objDocumentsInfo == null)
                {
                    objDocumentsInfo = new ACDocumentsInfo();
                    objDocumentsInfo.FK_ACDocumentTypeID = item.FK_ACDocumentTypeID;
                    objDocumentsInfo.ACDocumentTypeName = item.ACDocumentTypeName;
                    entity.DocumentList.Add(objDocumentsInfo);
                }
            }

            //remove the redundance document entries 
            List<ACDocumentEntrysInfo> removedItems = entity.DocumentEntryList.Where(item => item.ACEntryTypeName == entryType
                                                                              && !productAccountID.Any(accountID => accountID == item.FK_ACCreditAccountID)).ToList();
            if (removedItems != null)
            {
                foreach (ACDocumentEntrysInfo item in removedItems)
                    entity.DocumentEntryList.Remove(item);
            }
            //remove DocumentsList
            List<ACDocumentsInfo> removed = entity.DocumentList.Where(x => x.ACDocumentTypeName != documentType).ToList();
            if (removed != null)
            {
                foreach (ACDocumentsInfo item in removed)
                    entity.DocumentList.Remove(item);
            }

            //ShipmentEntities entity = (ShipmentEntities)CurrentModuleEntity;            
            //ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;

            //foreach (var item in entity.DocumentEntryList)
            //{
            //    item.ACDocumentEntryAmount = 0;
            //    item.ACDocumentEntryExchangeAmount = 0;
            //}
            //foreach (var item in entity.ShipmentItemList)
            //{
            //    ICProductsController obj = new ICProductsController();
            //    ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(item.FK_ICProductID);
            //    if (objProductsInfo != null)
            //    UpdateDocumentEntryList(objProductsInfo.FK_ACAccountID, item.ICShipmentItemPrice, entity, objShipmentsInfo.ICShipmentExchangeRate);
            //}

            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }
        public void GetDefaultProductAccount(ICProductsInfo objProductsInfo)
        {
            ACAccountsController objAccountsController = new ACAccountsController();
            ACAccountsInfo objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(DefaultAccountNo);
            if (objAccountsInfo != null)
            {
                objProductsInfo.FK_ACAccountID = objAccountsInfo.ACAccountID;
            }
        }
        public const string DefaultAccountNo = "155";
        #endregion
        public void SetShipmentItemStock(int stockID)
        {

            BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
            foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
            {
                item.FK_ICStockID = stockID;
            }

            //GIANG ADD - START- 10-03-2016 - GET SERIESNO BY STOCK AND PRODUCTID - PRODUCTDESC
            //DataGenerator.SelectSeriesNoDefault(entity.ShipmentItemList);
            //GIANG ADD - END- 10-03-2016 - GET SERIESNO BY STOCK AND PRODUCTID - PRODUCTDESC

            entity.ShipmentItemList.GridControl.RefreshDataSource();
        }
        public void ShownInventoryStocks()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
                ICInventoryStocksInfo objInventoryStocksInfo = new ICInventoryStocksInfo();
                ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
                //List<ICInventoryStocksInfo> InventoryStocksList = new List<ICInventoryStocksInfo>();
                guiShowInventoryStock guiShowInventoryStock = new guiShowInventoryStock(objShipmentsInfo.ICShipmentShipmentType);
                guiShowInventoryStock.Module = this;
                guiShowInventoryStock.ShowDialog();
                List<ICProductSeriesInfo> SeriesList = new List<ICProductSeriesInfo>();
                SeriesList = guiShowInventoryStock.ProductSeriesInfoList;
                if (SeriesList.Count > 0)
                {
                    GetSelectedSeriesList(SeriesList);
                }
            }
        }
        public void GetSelectedSeriesList(List<ICProductSeriesInfo> SeriesList)
        {
            string type = string.Empty;
            BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(SeriesList[0].FK_ICProductID);
            foreach (ICProductSeriesInfo item in SeriesList)
            {
                ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
                DataGenerator.SetShipmentItemsfromProductSeries(objShipmentItemsInfo, item);
                if (objProductsInfo != null)
                {
                    objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                }
                objShipmentItemsInfo.FK_MMBatchProductID = objShipmentsInfo.FK_MMBatchProductID;
                objShipmentItemsInfo.FK_MMOperationID = objShipmentsInfo.FK_MMOperationID;
                objShipmentItemsInfo.FK_ICProductAttributeTTMTID = objShipmentsInfo.FK_ICProductAttributeTTMTID;
                objShipmentItemsInfo.FK_GECountryID = objShipmentsInfo.FK_GECountryID;
                objShipmentItemsInfo.FK_ICProductAttributeWoodTypeID = objShipmentsInfo.FK_ICProductAttributeWoodTypeID;
                //TNDLoc [ADD][21/01/2016][Copy ProductSerieID],START
                objShipmentItemsInfo.FK_ICProductSerieID = item.ICProductSerieID;
                //TNDLoc [ADD][21/01/2016][Copy ProductSerieID],END
                entity.ShipmentItemList.Add(objShipmentItemsInfo);
            }
            entity.ShipmentItemList.GridControl.RefreshDataSource();
            UpdateTotalAmount();
        }
        public void UpdateTTMT(int TTMTID)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
                if (entity.ShipmentItemList.Count > 0)
                {
                    foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
                    {
                        item.FK_ICProductAttributeTTMTID = TTMTID;
                    }
                    entity.ShipmentItemList.GridControl.RefreshDataSource();
                }
            }
        }
        public void UpdateBatchProductID(int batchProductID)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
                if (entity.ShipmentItemList.Count > 0)
                {
                    foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
                    {
                        item.FK_MMBatchProductID = batchProductID;
                    }
                    entity.ShipmentItemList.GridControl.RefreshDataSource();
                }
            }
        }
        public void UpdateGECountryID(int GECountryID)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
                if (entity.ShipmentItemList.Count > 0)
                {
                    foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
                    {
                        item.FK_GECountryID = GECountryID;
                    }
                    entity.ShipmentItemList.GridControl.RefreshDataSource();
                }
            }
        }
        public void UpdateWoodTypeID(int WoodTypeID)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
                if (entity.ShipmentItemList.Count > 0)
                {
                    foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
                    {
                        item.FK_ICProductAttributeWoodTypeID = WoodTypeID;
                    }
                    entity.ShipmentItemList.GridControl.RefreshDataSource();
                }
            }
        }
        public void UpdateOperation(int OperationID)
        {
            //if (!Toolbar.IsNullOrNoneAction())
            {
                MMOperationsInfo objOperationsInfo = new MMOperationsInfo();
                MMOperationsController objOperationsController = new MMOperationsController();
                BatchShipmentFreshLumberEntities entity = (BatchShipmentFreshLumberEntities)CurrentModuleEntity;
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
                objShipmentsInfo.FK_MMOperationID = OperationID;

                ACAccountsInfo objAccountCredit = new ACAccountsInfo();
                ACAccountsInfo objAccountDebit = new ACAccountsInfo();
                ACAccountsController objAccountsController = new ACAccountsController();


                int AccountCreditID = 0;
                string CD = string.Empty;
                //Tài khoản nợ
                objAccountCredit = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc15221);
                if (objAccountCredit != null)
                {
                    AccountCreditID = objAccountCredit.ACAccountID;
                }
                //Công đoạn MainObject 
                objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByID(objShipmentsInfo.FK_MMOperationID);
                if (objOperationsInfo != null)
                {
                    CD = objOperationsInfo.MMOperationNo;
                }





                if (entity.ShipmentItemList.Count > 0)
                {
                    foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
                    {
                        item.FK_MMOperationID = OperationID;
                        if (CD == OperationNo.Say.ToString())
                        {
                            item.FK_ACAccountID = AccountCreditID;
                        }
                    }
                    //GenerateAccountingData();
                    entity.DocumentEntryList.Clear();
                    UpdateDocumentEntries();
                    entity.ShipmentItemList.GridControl.RefreshDataSource();
                }



            }
        }
        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                BatchShipmentFreshLumber.BatchShipmentFreshLumberModule.PrintShipment(Toolbar.CurrentObjectID);
            }
        }
        public static void PrintShipment(int ShipmentID)
        {
            RP_ShipmentLumber report = new RP_ShipmentLumber();
            //report.LoadLayout(BOSCommon.Constants.Report.DevReceiptItemReportPath);
            InitReceiptReport(report, ShipmentID);
            guiReportPreview viewer = new guiReportPreview(report);
            viewer.Show();
        }

        private static void InitReceiptReport(XtraReport report, int ShipmentID)
        {
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objBranchsInfo != null)
            {
                XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
                if (label != null)
                {
                    label.Text = objBranchsInfo.BRBranchContactAddressLine3;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
                if (label != null)
                {
                    label.Text = objBranchsInfo.BRBranchContactPhone;
                }

                label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
                if (label != null)
                {
                    label.Text = objBranchsInfo.BRBranchContactFax;
                }
            }

            ICShipmentsController objShipmentsController = new ICShipmentsController();
            ICShipmentsInfo shipment = (ICShipmentsInfo)objShipmentsController.GetObjectByID(ShipmentID);
            #region Hạch toán
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
            if (shipment != null)
            {
                ACDocumentsController objDocumentsController = new ACDocumentsController();
                ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                ACDocumentsInfo document = null;
                if (shipment.ICShipmentTypeCombo == ShipmentType.FreshLumber.ToString())
                {
                    document = objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.XuatKhoPhachTuoiCongDoanCua.ToString(), shipment.ICShipmentNo);
                }
                //else if (receipt.ICReceiptTypeCombo == ShipmentType..ToString())
                //{
                //    if (!string.IsNullOrEmpty(receipt.ICReceiptReference))
                //    {
                //        document = objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.NhapKhoMuaHangHoaDon.ToString(), receipt.ICReceiptNo);
                //    }
                //    else
                //    {
                //        document = objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.NhapKhoMuaHang.ToString(), receipt.ICReceiptNo);
                //    }
                //}
                //else if (receipt.ICReceiptTypeCombo == ReceiptType.EquipmentReceipt.ToString())
                //{
                //    document = objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.NhapCCDC.ToString(), receipt.ICReceiptNo);
                //}
                if (document != null)
                {
                    entries = objDocumentEntrysController.GetDocumentEntryByDocumentID(document.ACDocumentID);
                }
            }
            XRLabel accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblDebitAccountNo"];
            if (accLabel != null)
            {
                string debitAccountNo = string.Empty;
                foreach (ACDocumentEntrysInfo entry in entries)
                {
                    if (!debitAccountNo.Contains(entry.ACDocumentDebitAccount))
                    {
                        debitAccountNo += string.Format(" {0},", entry.ACDocumentDebitAccount);
                    }
                }
                if (!string.IsNullOrEmpty(debitAccountNo))
                {
                    debitAccountNo = debitAccountNo.Substring(0, debitAccountNo.Length - 1);
                }
                accLabel.Text = debitAccountNo;
            }

            accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblCreditAccountNo"];
            if (accLabel != null)
            {
                string creditAccountNo = string.Empty;
                foreach (ACDocumentEntrysInfo entry in entries)
                {
                    if (entry.ACDocumentCreditAccount != null)
                    {
                        if (!creditAccountNo.Contains(entry.ACDocumentCreditAccount))
                        {
                            creditAccountNo += string.Format(" {0},", entry.ACDocumentCreditAccount);
                        }
                    }
                }
                if (!string.IsNullOrEmpty(creditAccountNo))
                {
                    creditAccountNo = creditAccountNo.Substring(0, creditAccountNo.Length - 1);
                }
                accLabel.Text = creditAccountNo;
            }
            #endregion

            accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel28"];
            if (accLabel != null)
            {
                accLabel.Text = shipment.ICShipmentDate.ToString("dd/MM/yyyy");
            }
            accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel29"];
            if (accLabel != null)
            {
                accLabel.Text = shipment.ICShipmentDate.ToString("dd/MM/yyyy");
            }

            //GECurrenciesController objCurrenciesController = new GECurrenciesController();
            //GECurrenciesInfo currency = (GECurrenciesInfo)objCurrenciesController.GetObjectByID(receipt.FK_GECurrencyID);
            //accLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xrLabel27"];
            //if (accLabel != null)
            //{
            //    accLabel.Text = ConvertAmountToWord.ReadAmount(receipt.ICReceiptTotalCost.ToString(), currency.GECurrencyID);
            //}



            ADReportsController objReportsController = new ADReportsController();
            decimal Tongsoluong = 0;
            foreach (ICShipmentItemsInfo item in objReportsController.GetListShipmentItemByShipmentID(ShipmentID))
            {
                if (item != null)
                {
                    item.ICShipmentItemWoodQty = Math.Round(item.ICShipmentItemWoodQty, 0);
                    Tongsoluong += item.ICShipmentItemWoodQty;
                }
            }
            accLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xrLabel17"];
            if (accLabel != null)
            {
                accLabel.Text = Tongsoluong.ToString();
            }
            report.DataSource = objReportsController.GetListShipmentItemByShipmentID(ShipmentID);
            //report.DataMember = BOSCommon.Constants.Report.DevReceiptItemReportName;
        }

    }
    #endregion
}
