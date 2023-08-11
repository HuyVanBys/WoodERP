using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchShipmentHeat
{
    public class BatchShipmentHeatModule : BaseTransactionModule
    {
        #region Constants
        private const string NewConstants = "***NEW***";
        public const string ShipmentItemGridControlName = "fld_dgcICShipmentItem1s";
        public const string DocumentEntryGridControlName = "fld_dgcACDocumentEntrys";
        public const string ProductEditControlName = "fld_lkeFK_ICProductID";
        #endregion
        #region Variable
        #endregion
        BOSComponent.BOSLookupEdit ProductEditControl;
        #region Public properties
        #endregion

        public BatchShipmentHeatModule()
        {
            Name = "BatchShipmentHeat";
            CurrentModuleEntity = new BatchShipmentHeatEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            ProductEditControl = (BOSComponent.BOSLookupEdit)Controls[ProductEditControlName];
        }
        public override void ActionEdit()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                base.ActionEdit();
            }
        }
        public override void ActionNew()
        {
            base.ActionNew();
            // UpdateTotalAmount();
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
                                                                    ShipmentType.ShipmentHeat.ToString(),
                                                                    null,
                                                                    searchObject.ShipmentDateFrom,
                                                                    searchObject.ShipmentDateTo);

            return ds;
        }
        public void AddItemToShipmentItemsList()
        {
            int idproduct = int.Parse(ProductEditControl.EditValue.ToString());
            BatchShipmentHeatEntities entity = (BatchShipmentHeatEntities)CurrentModuleEntity;
            ICShipmentItemsInfo objShipmentItemsInfo = (ICShipmentItemsInfo)entity.ModuleObjects[TableName.ICShipmentItemsTableName];
            ACAccountsInfo objAccountsInfo = new ACAccountsInfo();
            ACAccountsController objAccountsController = new ACAccountsController();
            objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc15222);
            //if (objShipmentItemsInfo.FK_ICProductID > 0)
            //{
            //    ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            //    ICProductsController objProductsController = new ICProductsController();
            //    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objShipmentItemsInfo.FK_ICProductID);

            //    if (objShipmentsInfo != null)
            //    {
            //        objShipmentItemsInfo.FK_MMBatchProductID = objShipmentsInfo.FK_MMBatchProductID;
            //        objShipmentItemsInfo.FK_MMOperationID = objShipmentsInfo.FK_MMOperationID;
            //    }
            //    if (objProductsInfo != null)
            //    {
            //        entity.SetValuesAfterValidateProduct(objShipmentItemsInfo.FK_ICProductID, objShipmentItemsInfo);
            //        objShipmentItemsInfo.FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
            //    }
            //    entity.ShipmentItemList.AddObjectToList();
            //    //entity.ShipmentItemList.Add(objShipmentItemsInfo);
            //    entity.ShipmentItemList.GridControl.RefreshDataSource();

            //}
            if (idproduct > 0)
            {
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(idproduct);
                if (objShipmentsInfo != null)
                {
                    objShipmentItemsInfo.FK_MMBatchProductID = objShipmentsInfo.FK_MMBatchProductID;
                    objShipmentItemsInfo.FK_MMOperationID = objShipmentsInfo.FK_MMOperationID;
                }
                if (objProductsInfo != null)
                {
                    entity.SetValuesAfterValidateProduct(idproduct, objShipmentItemsInfo);
                    objShipmentItemsInfo.FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
                    //objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                }
                if (objAccountsInfo != null)
                {
                    objShipmentItemsInfo.FK_ACAccountID = objAccountsInfo.ACAccountID;
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
                BatchShipmentHeatEntities entity = (BatchShipmentHeatEntities)CurrentModuleEntity;
                entity.ShipmentItemList.RemoveSelectedRowObjectFromList();
                UpdateTotalAmount();
            }
        }
        public void ChangeItemFromShipmentItemsList(ICShipmentItemsInfo objShipmentItemsInfo)
        {
            BatchShipmentHeatEntities entity = (BatchShipmentHeatEntities)CurrentModuleEntity;
            objShipmentItemsInfo.ICShipmentItemProductQty = objShipmentItemsInfo.ICShipmentItemWoodQty
                                                          * objShipmentItemsInfo.ICShipmentItemLength
                                                          * objShipmentItemsInfo.ICShipmentItemPerimeter;
            entity.SetProductPriceByProductUnitPrice();
            //UpdateProductQty();
            //entity.ShipmentItemList.ChangeObjectFromList();
            // UpdateProductQty();
        }
        public void ChangeItemFromShipmentItemsList()
        {
            BatchShipmentHeatEntities entity = (BatchShipmentHeatEntities)CurrentModuleEntity;
            entity.SetProductPriceByProductUnitPrice();
            entity.ShipmentItemList.ChangeObjectFromList();

            UpdateTotalAmount();
        }

        public void SelectSeriesNoDefault()
        {
            BatchShipmentHeatEntities entity = (BatchShipmentHeatEntities)CurrentModuleEntity;
            //GIANG ADD - START- 10-03-2016 - GET SERIESNO BY STOCK AND PRODUCTID - PRODUCTDESC
            //DataGenerator.SelectSeriesNoDefault(entity.ShipmentItemList);
            //GIANG ADD - END- 10-03-2016 - GET SERIESNO BY STOCK AND PRODUCTID - PRODUCTDESC
            entity.ShipmentItemList.GridControl.RefreshDataSource();
        }
        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentHeatEntities entity = (BatchShipmentHeatEntities)CurrentModuleEntity;
                entity.UpdateTotalAmount();
                UpdateDocumentEntries();
            }
        }
        public void ChangeItemSerieNo(ICShipmentItemsInfo item)
        {
            BatchShipmentHeatEntities entity = (BatchShipmentHeatEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            item.ICShipmentItemProductUnitPrice = AccountHelper.GetInventoryCost(item.FK_ICStockID, item.FK_ICProductID, item.ICShipmentItemProductSerialNo, objShipmentsInfo.ICShipmentDate);

            DataGenerator.ChangeValuesShipmentItemsGridFromProductSeries(item);
            entity.SetProductPriceByProductUnitPrice(item);
            entity.ShipmentItemList.GridControl.RefreshDataSource();

            entity.SetProductCostByProductUnitCost(item);
            entity.ShipmentItemList.GridControl.RefreshDataSource();
            UpdateTotalAmount();
        }
        public void ChangeItemlist(ICShipmentItemsInfo item)
        {
            BatchShipmentHeatEntities entity = (BatchShipmentHeatEntities)CurrentModuleEntity;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            ICProductSeriesInfo objProductSeriesInfo = (ICProductSeriesInfo)objProductSeriesController.GetObjectByID(item.FK_ICProductSerieID);
            if (objProductSeriesInfo != null)
            {
                // UpdateProductQty();
                BOSUtil.CopyObject(objProductSeriesInfo, item);
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
                BatchShipmentHeatEntities entity = (BatchShipmentHeatEntities)CurrentModuleEntity;
                entity.UpdateProductQty();
            }
        }

        public void NewFromBatchLumber()
        {
            ActionNew();
            BatchShipmentHeatEntities entity = (BatchShipmentHeatEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;

            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<ICReceiptItemsInfo> receiptItemList = objReceiptItemsController.GetItemForFreshLumberShipment();

            guiFind<ICReceiptItemsInfo> guiFind = new guiFind<ICReceiptItemsInfo>(TableName.ICReceiptItemsTableName,
                                                                                  receiptItemList,
                                                                                  this, true, true,
                                                                                    new string[] { "MMBatchProductNo"
                                                                                                        , "ICReceiptNo"});
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
                            objShipmentItemsInfo.FK_ICProductID = item.FK_ICProductID;
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
                            entity.ShipmentItemList.Add(objShipmentItemsInfo);
                            entity.ShipmentItemList.GridControl.RefreshDataSource();
                        }
                    }
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
            BatchShipmentHeatEntities entity = (BatchShipmentHeatEntities)CurrentModuleEntity;
            // ICShipmentsInfo oldshipmentsInfo = (ICShipmentsInfo)entity.MainObject.OldObject;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
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

                        entity.UpdateMainObjectBindingSource();
                    }
                    if (AllocationProposalItemsList != null)
                    {
                        foreach (MMAllocationProposalItemsInfo item in AllocationProposalItemsList)
                        {
                            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
                            BOSUtil.CopyObject(item, objShipmentItemsInfo);
                            objShipmentItemsInfo.ICShipmentItemProductQty = item.MMAllocationProposalItemQty - item.MMAllocationProposalItemShippedQty - item.MMAllocationProposalItemCanceledQty;
                            objShipmentItemsInfo.FK_MMAllocationProposalItemID = item.MMAllocationProposalItemID;
                            objShipmentItemsInfo.ICShipmentItemWoodQty = item.MMAllocationProposalItemWoodQty - item.MMAllocationProposalItemShippedWoodQty;
                            //objShipmentItemsInfo.ICShipmentItemLength=item.MMa
                            objShipmentItemsInfo.FK_ICProductID = item.FK_ICProductID;
                            objShipmentItemsInfo.FK_ICProductAttributeTTMTID = item.FK_ICProductAttributeTTMTID;
                            entity.ShipmentItemList.Add(objShipmentItemsInfo);
                            entity.ShipmentItemList.GridControl.RefreshDataSource();
                        }
                    }
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
            BatchShipmentHeatEntities entity = (BatchShipmentHeatEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            MMAllocationProposalItemsController objAllocationProposalItemsController = new MMAllocationProposalItemsController();
            MMAllocationProposalsController objAllocationProposalsController = new MMAllocationProposalsController();

            List<MMAllocationProposalItemsInfo> objAllocationProposalItemsCheck = new List<MMAllocationProposalItemsInfo>();
            List<MMAllocationProposalItemsInfo> allocationProposalItemsList = objAllocationProposalItemsController.GetNewProposalFromWood(ShipmentType.Wood.ToString(),
                                                                                                                                            BOSApp.CurrentUsersInfo.ADUserID,
                                                                                                                                            ModuleName.AllocationProposal,
                                                                                                                                            ADDataViewPermissionType.Module,
                                                                                                                                            BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            guiFind<MMAllocationProposalItemsInfo> guifind = new guiFind<MMAllocationProposalItemsInfo>(TableName.MMAllocationProposalItemsTableName, allocationProposalItemsList, this, true, true, new string[] { "MMAllocationProposalNo" });
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
                            objShipmentItemsInfo.ICShipmentItemProductQty = Math.Round((item.MMAllocationProposalItemQty - item.MMAllocationProposalItemShippedQty - item.MMAllocationProposalItemCanceledQty), 4, MidpointRounding.AwayFromZero);
                            objShipmentItemsInfo.FK_MMAllocationProposalItemID = item.MMAllocationProposalItemID;
                            objShipmentItemsInfo.ICShipmentItemWoodQty = item.MMAllocationProposalItemWoodQty - item.MMAllocationProposalItemShippedWoodQty;
                            //objShipmentItemsInfo.ICShipmentItemLength=item.MMa
                            objShipmentItemsInfo.FK_ICProductAttributeTTMTID = item.FK_ICProductAttributeTTMTID;
                            entity.ShipmentItemList.Add(objShipmentItemsInfo);
                            entity.ShipmentItemList.GridControl.RefreshDataSource();
                        }
                        entity.SetProductPriceByProductUnitPrice();
                    }
                }
            }
            else
                ActionCancel();
        }
        public void ActionNewFromBatchShipmentFreshLumber()
        {
            ActionNew();
            BatchShipmentHeatEntities entity = (BatchShipmentHeatEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            ICReceiptsInfo objReceiptsInfo = new ICReceiptsInfo();
            ICReceiptItemsInfo objReceiptItemsInfo = new ICReceiptItemsInfo();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            ICReceiptsController objReceiptsController = new ICReceiptsController();
            ICProductsController objProductsController = new ICProductsController();
            //List<ICReceiptsInfo> list = objReceiptsController.GetReceiptByReceiptTypeAndStatus(ReceiptType.ReceiptHeat.ToString());
            List<ICReceiptItemsInfo> listcheck = new List<ICReceiptItemsInfo>();
            List<ICReceiptItemsInfo> ListReceiptItems = objReceiptItemsController.GetReceiptList_ByType(ReceiptType.ReceiptHeat.ToString());
            guiFind<ICReceiptItemsInfo> guifind = new guiFind<ICReceiptItemsInfo>(TableName.ICReceiptItemsTableName, ListReceiptItems, this, true, true, new string[] { "ICReceiptNo" });
            ACAccountsInfo objAccountsInfo = new ACAccountsInfo();
            ACAccountsController objAccountsController = new ACAccountsController();
            objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc15222);

            guifind.ShowDialog();
            if (guifind.DialogResult == DialogResult.OK)
            {
                List<ICReceiptItemsInfo> ICReceiptList = (List<ICReceiptItemsInfo>)guifind.SelectedObjects;
                if (guifind.SelectedObjects != null && guifind.SelectedObjects.Count > 0)
                {
                    //objAllocationProposalItemsCheck = (List<MMAllocationProposalItemsInfo>)AllocationProposalItemsList.Where(x => x.FK_MMAllocationProposalID != guifind.SelectedObjects[0].FK_MMAllocationProposalID).ToList();
                    //listcheck = (List<ICReceiptItemsInfo>)ListReceiptItems.Where(x => x.ICReceiptNo != guifind.SelectedObjects[0].ICReceiptNo).ToList();
                    int idcheck = guifind.SelectedObjects[0].FK_ICReceiptID;
                    bool error = true;
                    foreach (ICReceiptItemsInfo item in guifind.SelectedObjects)
                    {
                        if (idcheck != item.FK_ICReceiptID)
                        {
                            error = false;
                            break;
                        }
                    }
                    if (error == false)
                    {
                        MessageBox.Show(string.Format(MaterialShipmentLocalizedResources.ChooseMulltiSaleOrderMessage), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ActionCancel();
                    }
                    if (error == true)
                    {
                        //ICReceiptsInfo objReceiptsInfo = new ICReceiptsInfo();
                        //ICReceiptsController objReceiptsController = new ICReceiptsController();
                        objReceiptsInfo = (ICReceiptsInfo)objReceiptsController.GetObjectByID(idcheck);
                        if (objReceiptsInfo != null)
                        {
                            BOSUtil.CopyObject(objReceiptsInfo, objShipmentsInfo);
                            objShipmentsInfo.ICShipmentNo = NewConstants.ToString();
                            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.New.ToString();
                            entity.UpdateMainObjectBindingSource();
                            foreach (ICReceiptItemsInfo item in guifind.SelectedObjects)
                            {
                                ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
                                BOSUtil.CopyObject(item, objShipmentItemsInfo);
                                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                                //Hard ACCOUNT
                                //if (item.FK_ACAccountID == 0 && objProductsInfo != null)
                                //{
                                //    objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;                                    
                                //}
                                if (objAccountsInfo != null)
                                {
                                    objShipmentItemsInfo.FK_ACAccountID = objAccountsInfo.ACAccountID;
                                }

                                objShipmentItemsInfo.ICShipmentItemWidth = item.ICReceiptItemProductWidth;
                                objShipmentItemsInfo.ICShipmentItemLength = item.ICReceiptItemProductLength;
                                objShipmentItemsInfo.ICShipmentItemPerimeter = item.ICReceiptItemProductPerimeter;
                                objShipmentItemsInfo.ICShipmentItemHeightMax = item.ICReceiptItemProductHeight;
                                objShipmentItemsInfo.ICShipmentItemWidthMax = item.ICReceiptItemWidthMax;
                                objShipmentItemsInfo.ICShipmentItemLengthMax = item.ICReceiptItemLenghtMax;
                                objShipmentItemsInfo.ICShipmentItemLengthMin = item.ICReceiptItemLenghtMin;
                                objShipmentItemsInfo.ICShipmentItemWidthMin = item.ICReceiptItemWidthMin;
                                objShipmentItemsInfo.ICShipmentItemProductUnitPrice = item.ICReceiptItemProductUnitCost;
                                objShipmentItemsInfo.ICShipmentItemTotalAmount = item.ICReceiptItemTotalCost;
                                objShipmentItemsInfo.ICShipmentItemHeight = item.ICReceiptItemProductHeight;
                                //TNDLoc [ADD][02/02/2016][1 - 1 ReceiptItem - ShipmentItem],START
                                objShipmentItemsInfo.FK_ICReceiptItemID = item.Id;
                                //TNDLoc [ADD][02/02/2016][1 - 1 ReceiptItem - ShipmentItem],END

                                objShipmentItemsInfo.ICShipmentItemProductQty = Math.Round(item.ICReceiptItemProductQty, 4, MidpointRounding.AwayFromZero);

                                entity.ShipmentItemList.Add(objShipmentItemsInfo);
                                entity.ShipmentItemList.GridControl.RefreshDataSource();
                            }
                            entity.SetProductPriceByProductUnitPrice();
                            UpdateTotalAmount();
                        }

                    }
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
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchShipmentHeat", false);
            }
            else
            {
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchShipmentHeat", true);
            }
        }
        public void ApproveBatchShipmentHeat()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                BatchShipmentHeatEntities entity = (BatchShipmentHeatEntities)CurrentModuleEntity;
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
            BatchShipmentHeatEntities entity = (BatchShipmentHeatEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentsInfo.ICShipmentTypeCombo = ShipmentType.ShipmentHeat.ToString();
            //NNGiang ADD - 13-04-2016 Start [Check QTY With RECEIPT QTY]
            //BatchShipmentHeatEntities entity = (BatchShipmentHeatEntities)CurrentModuleEntity;
            if (!CheckQtyInReceiptItem(entity.ShipmentItemList))
            {
                return 0;
            }
            //NNGiang ADD - 13-04-2016 End [Check QTY With RECEIPT QTY]
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
            BatchShipmentHeatEntities entity = (BatchShipmentHeatEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;

            ICProductsController productController = new ICProductsController();
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();

            string documentType = AccDocumentType.XuatKhoLoSay.ToString();
            string entryType = AccEntryType.XuatKhoLoSay.ToString();

            if (objShipmentsInfo.ICShipmentTypeCombo == ShipmentType.ShipmentHeat.ToString())
            {
                documentType = AccDocumentType.XuatKhoLoSay.ToString();
                entryType = AccEntryType.XuatKhoLoSay.ToString();
            }



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

            //    //ShipmentEntities entity = (ShipmentEntities)CurrentModuleEntity;            
            //    //ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;

            //    //foreach (var item in entity.DocumentEntryList)
            //    //{
            //    //    item.ACDocumentEntryAmount = 0;
            //    //    item.ACDocumentEntryExchangeAmount = 0;
            //    //}
            //    //foreach (var item in entity.ShipmentItemList)
            //    //{
            //    //    ICProductsController obj = new ICProductsController();
            //    //    ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(item.FK_ICProductID);
            //    //    if (objProductsInfo != null)
            //    //    UpdateDocumentEntryList(objProductsInfo.FK_ACAccountID, item.ICShipmentItemPrice, entity, objShipmentsInfo.ICShipmentExchangeRate);
            //    //}

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

            BatchShipmentHeatEntities entity = (BatchShipmentHeatEntities)CurrentModuleEntity;
            foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
            {
                item.FK_ICStockID = stockID;
            }

            //GIANG ADD - START- 10-03-2016 - GET SERIESNO BY STOCK AND PRODUCTID - PRODUCTDESC
            //DataGenerator.SelectSeriesNoDefault(entity.ShipmentItemList);
            //GIANG ADD - END- 10-03-2016 - GET SERIESNO BY STOCK AND PRODUCTID - PRODUCTDESC

            entity.ShipmentItemList.GridControl.RefreshDataSource();
        }
        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                BatchShipmentHeat.BatchShipmentHeatModule.PrintShipment(Toolbar.CurrentObjectID);
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
                if (shipment.ICShipmentTypeCombo == ShipmentType.ShipmentHeat.ToString())
                {
                    document = objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.XuatKhoLoSay.ToString(), shipment.ICShipmentNo);
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
            List<ICShipmentItemsInfo> shipmentItemsList = objReportsController.GetListShipmentItemByShipmentID(ShipmentID);
            foreach (ICShipmentItemsInfo item in shipmentItemsList)
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
            report.DataSource = shipmentItemsList;
            //report.DataMember = BOSCommon.Constants.Report.DevReceiptItemReportName;
        }
    }

}

