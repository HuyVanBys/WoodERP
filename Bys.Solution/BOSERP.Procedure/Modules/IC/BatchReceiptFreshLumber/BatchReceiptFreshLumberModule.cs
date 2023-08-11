using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.IC.BatchReceiptDryLumber.Localization;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchReceiptFreshLumber
{
    #region BatchReceiptFreshLumberModule
    class BatchReceiptFreshLumberModule : BaseTransactionModule
    {
        #region Contants
        public const string ReceiptItemGridControlName = "fld_dgcReceiptItems";
        public const string DocumentEntryGridControlName = "fld_dgcACDocumentEntrys";
        public const string ShowItemButtonName = "fld_btnShowItem";
        public const string DocumentGridControlName = "fld_dgcACDocumentEntrys";
        #endregion

        #region Public Properties
        public BOSButton ShowItemButton = null;
        #endregion
        public BatchReceiptFreshLumberModule()
        {
            Name = "BatchReceiptFreshLumber";
            CurrentModuleEntity = new BatchReceiptFreshLumberEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            ShowItemButton = (BOSButton)Controls[ShowItemButtonName];
        }

        public void AdditemtoItemRecceipt()
        {
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
            ICReceiptItemsInfo objReceiptItemsInfo = (ICReceiptItemsInfo)entity.ModuleObjects[TableName.ICReceiptItemsTableName];
            if (objReceiptItemsInfo.FK_ICProductID > 0)
            {
                ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objReceiptItemsInfo.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    entity.SetValuesAfterValidateProduct(objReceiptItemsInfo.FK_ICProductID, objReceiptItemsInfo);
                    objReceiptItemsInfo.FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
                    objReceiptItemsInfo.ICReceiptItemProductLength = objProductsInfo.ICProductLength;
                    objReceiptItemsInfo.ICReceiptItemProductHeight = objProductsInfo.ICProductHeight;
                    objReceiptItemsInfo.ICReceiptItemProductWidth = objProductsInfo.ICProductWidth;
                    //NNGiang   Round Qty 19-05-2016 Start
                    objReceiptItemsInfo.ICReceiptItemProductQty = Math.Round((objReceiptItemsInfo.ICReceiptItemProductLength * objReceiptItemsInfo.ICReceiptItemProductPerimeter *
                                                                    objReceiptItemsInfo.ICReceiptItemWoodQty), 4, MidpointRounding.AwayFromZero);
                    //NNGiang   Round Qty 19-05-2016 End
                    objReceiptItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                    objReceiptItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                }
                if (objReceiptsInfo != null)
                {
                    objReceiptItemsInfo.FK_MMBatchProductID = objReceiptsInfo.FK_MMBatchProductID;
                    objReceiptItemsInfo.FK_MMOperationID = objReceiptsInfo.FK_MMOperationID;
                    objReceiptItemsInfo.FK_ICProductAttributeTTMTID = objReceiptsInfo.FK_ICProductAttributeTTMTID;
                    objReceiptItemsInfo.ICReceiptItemLotNo = objReceiptsInfo.ICReceiptPackNo;
                }
                entity.ReceiptItemsList.AddObjectToList();
                UpdateDocumentEntries();

                entity.ReceiptItemsList.GridControl.RefreshDataSource();
            }
        }

        /// <summary>
        /// Called when user wants to change stock
        /// </summary>
        /// <param name="stockID">Selected stock id</param>
        public void ChangePackNo()
        {
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;

            if (!Toolbar.IsNullOrNoneAction())
            {
                if (entity.ReceiptItemsList.Count > 0)
                {
                    if (MessageBox.Show(WoodPurchaseReceiptLocalizedResources.ConfirmChangeItemLotNoMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (ICReceiptItemsInfo item in entity.ReceiptItemsList)
                        {
                            item.ICReceiptItemLotNo = objReceiptsInfo.ICReceiptPackNo;
                        }
                        entity.ReceiptItemsList.GridControl.RefreshDataSource();
                    }
                }
            }
        }
        public void ChangeItemSerieNo(ICReceiptItemsInfo item)
        {
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo objProductSeriesInfo = (ICProductSeriesInfo)objProductSeriesController.GetObjectByID(item.FK_ICProductSerieID);
            int stockid = item.FK_ICStockID;
            if (objProductSeriesInfo != null)
            {
                BOSUtil.CopyObject(objProductSeriesInfo, item);
                item.FK_ICStockID = stockid;
                //item.ICReceiptItemProductQty = item.ICReceiptItemProductPerimeter * item.ICReceiptItemProductLength *
                //                                item.ICReceiptItemWoodQty;
            }
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            if (objReceiptsInfo != null)
            {
                item.FK_MMBatchProductID = objReceiptsInfo.FK_MMBatchProductID;
                item.FK_MMOperationID = objReceiptsInfo.FK_MMOperationID;
            }
            UpdateDocumentEntries();
            entity.ReceiptItemsList.GridControl.RefreshDataSource();
        }
        public void ChangeItemFromReceiptItemsList()
        {
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            if (objReceiptsInfo.ICReceiptAcceptanceType.Equals(ReceiptAcceptanceType.Acceptance.ToString()))
                entity.SetProductCostByProductUnitCostForReceiptAcceptanceType();
            else
                entity.SetProductCostByProductUnitCost();

            entity.ReceiptItemsList.ChangeObjectFromList();
            UpdateTotalCost();
            UpdateProductQty();


            //entity.ReceiptItemsList.GridControl.RefreshDataSource();
        }
        public void UpdateTotalCost()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
                entity.UpdateTotalCost();
                UpdateInventoryCost();
                UpdateDocumentEntries();
            }
        }
        public void ChangeGECurrency(string stringID)
        {
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            int id = 0;
            int.TryParse(stringID, out id);
            objReceiptsInfo.FK_GECurrencyID = id;
            UpdateTotalCost();
        }
        private void UpdateInventoryCost()
        {
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            decimal extCost = entity.ReceiptItemsList.Sum(i => i.ICReceiptItemExtCost);
            foreach (ICReceiptItemsInfo item in entity.ReceiptItemsList)
            {
                item.ICReceiptItemInventoryCost = item.ICReceiptItemProductUnitCost;
            }
        }
        public void ChangeItemFromReceiptItemsListQty(ICReceiptItemsInfo item)
        {
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            //if (objReceiptsInfo.ICReceiptAcceptanceType == ReceiptAcceptanceType.Acceptance.ToString())
            //{
            //    ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
            //    ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            //    objShipmentItemsInfo = (ICShipmentItemsInfo)objShipmentItemsController.GetObjectByID(item.FK_ICShipmentItemID);
            //    if (objShipmentItemsInfo != null && item.ICReceiptItemProductQty>0)
            //    {
            //        item.ICReceiptItemProductUnitCost = objShipmentItemsInfo.ICShipmentItemTotalCost / item.ICReceiptItemProductQty;


            //    }
            //}
            if (objReceiptsInfo.ICReceiptAcceptanceType.Equals(ReceiptAcceptanceType.Acceptance.ToString()))
                entity.SetProductCostByProductUnitCostForReceiptAcceptanceType(item);
            else
                entity.SetProductCostByProductUnitCost();

            //item.ICReceiptItemProductQty = item.ICReceiptItemProductLength * item.ICReceiptItemProductPerimeter *
            //                               item.ICReceiptItemWoodQty;
            //entity.ReceiptItemsList.ChangeObjectFromList();

            UpdateDocumentEntries();
            entity.ReceiptItemsList.GridControl.RefreshDataSource();
        }
        public void ChangeQTyFromReceiptItemsList(long ReceiptItemWoodQty)
        {
            guiConfigSerialNo objguiConfigSerialNo = new guiConfigSerialNo();
            objguiConfigSerialNo.Module = this;
            if (objguiConfigSerialNo.ShowDialog() == DialogResult.OK)
            {
                BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
                ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
                ICReceiptItemsInfo objReceiptItemsInfo = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex];
                objReceiptItemsInfo.ICReceiptItemWoodQty = 1;
                objReceiptItemsInfo.ICReceiptItemProductSerialNo = objReceiptsInfo.ICReceiptPrefix + string.Format("{0}", objReceiptsInfo.ICReceiptSerialNoStart);

                entity.SetProductCostByProductUnitCost(objReceiptItemsInfo);
                ICReceiptItemsInfo newReceiptItemsInfo = null;
                ICReceiptItemsInfo objReceiptItemsInfoClone = new ICReceiptItemsInfo();
                BOSUtil.CopyObject(objReceiptItemsInfo, objReceiptItemsInfoClone);
                for (int i = 1; i < ReceiptItemWoodQty; i++)
                {
                    newReceiptItemsInfo = new ICReceiptItemsInfo();
                    BOSUtil.CopyObject(objReceiptItemsInfoClone, newReceiptItemsInfo);
                    newReceiptItemsInfo.FK_ICProductSerieID = 0;
                    newReceiptItemsInfo.ICReceiptItemProductSerialNo = objReceiptsInfo.ICReceiptPrefix + string.Format("{0}", objReceiptsInfo.ICReceiptSerialNoStart + i);
                    //newReceiptItemsInfo.ICReceiptItemProductQty = objReceiptItemsInfo.ICReceiptItemProductLength * objReceiptItemsInfo.ICReceiptItemProductPerimeter *
                    //                                            objReceiptItemsInfo.ICReceiptItemWoodQty;
                    entity.ReceiptItemsList.Insert(entity.ReceiptItemsList.CurrentIndex + i, newReceiptItemsInfo);
                }
                objReceiptsInfo.ICReceiptPrefix = string.Empty;
                objReceiptsInfo.ICReceiptSerialNoStart = 0;
            }
        }
        //delete item
        public void DeleteItemFromReceiptItemsList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
                entity.ReceiptItemsList.RemoveSelectedRowObjectFromList();
                UpdateTotalCost();
            }
        }
        public void UpdateProductQty()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
                entity.UpdateProductQty();
                UpdateDocumentEntries();
            }
        }
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            //return base.GetSearchData(ref searchQuery);
            ICReceiptsController objReceiptsController = new ICReceiptsController();
            ACObjectsController objObjectsController = new ACObjectsController();
            ICReceiptsInfo searchObject = (ICReceiptsInfo)CurrentModuleEntity.SearchObject;
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);
            DataSet ds = objReceiptsController.GetReceiptListOtherAndReturnByBranchID(
                                                           searchObject.ICReceiptNo,
                                                           objObjectsInfo.ACObjectID,
                                                           objObjectsInfo.ACObjectType,
                                                           searchObject.FK_ICStockID,
                                                           searchObject.FK_HREmployeeID,
                                                           ReceiptType.LumberReceipt.ToString(),
                                                           searchObject.ReceiptDateFrom,
                                                           searchObject.ReceiptDateTo,
                                                           searchObject.FK_BRBranchID);

            return ds;
        }
        public override int ActionSave()
        {

            //UpdateSerieNo();
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
            CheckPackNo(objReceiptsInfo);
            //if(receiptID>0)
            //{
            //   // entity.Invalidate
            //}
            //NN Giang ADD -[CHECK QTY IN SHIPMENT ITEM] - Start-14-04-2016
            if (!CheckQtyInShipmentItem(entity.ReceiptItemsList))
            {
                return 0;
            }
            //NN Giang ADD -[CHECK QTY IN SHIPMENT ITEM] - End-14-04-2016
            CalculateUnitCostFuntion(false);
            int receiptID = base.ActionSave();
            ParentScreen.SetEnableOfToolbarButton("CalculateUnitCost", true);
            return receiptID;
        }
        public void UpdateSerieNo()
        {
            BatchReceiptFreshLumberEntities entity = new BatchReceiptFreshLumberEntities();
            //ICReceiptItemsInfo objReceiptItemsInfo=(ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex];
            ICProductSeriesInfo objProductSeriesInfo = new ICProductSeriesInfo();
            foreach (ICReceiptItemsInfo item in entity.ReceiptItemsList)
            {
                if (item.ICReceiptItemProductSerialNo != null && item.FK_ICProductSerieID == 0)
                {

                }
            }
        }

        public override void InvalidateToolbar()
        {

            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton("CalculateUnitCost", true);
            if (objReceiptsInfo.ICReceiptStatus == ReceiptStatus.Complete.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchReceiptLumber", false);
                ParentScreen.SetEnableOfToolbarButton("CalculateUnitCost", false);
            }
            else
            {
                ParentScreen.SetEnableOfToolbarButton("ApproveBatchReceiptLumber", true);
                if (!Toolbar.IsNullOrNoneAction())
                {
                    ParentScreen.SetEnableOfToolbarButton("CalculateUnitCost", false);
                }
                //ParentScreen.SetEnableOfToolbarButton("CalculateUnitCost", true);
            }
            base.InvalidateToolbar();
        }

        public void ApproveBatchReceiptLumber()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
                ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
                ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
                if (!CheckExistSerialNo())
                {
                    return;
                }
                foreach (ICReceiptItemsInfo item in entity.ReceiptItemsList)
                {
                    //Check unitcost receiptItem and InventoryStock, Start
                    /*Kiểm tra đơn giá nhập và đơn giá tồn kho*/
                    decimal unitcost = objInventoryStocksController.GetInventoryStockUnitCost(item.FK_ICProductID, item.ICReceiptItemProductSerialNo);
                    if (unitcost >= 0)//unitCost < 0 là chưa có đơn gía tồn kho
                    {
                        if (Math.Round(unitcost, 0) != item.ICReceiptItemProductUnitCost)
                        {
                            MessageBox.Show(string.Format(BatchReceiptDryLumberLocalizedResources.UnitCostInventoryStock, item.ICReceiptItemProductName), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    //Check unitcost receiptItem and InventoryStock, End
                }
                //TNDLoc [ADD][10/08/2016][Tồn kho tối đa, tối thiểu],START
                /* Nếu nhiều hơn tồn kho tối đa thì không cho nhập kho */
                if (entity.ReceiptItemsList.IsInvalidInventoryStockMax(TransactionUtil.cstInventoryReceipt))
                {
                    return;
                }
                //TNDLoc [ADD][10/08/2016][Tồn kho tối đa, tối thiểu],END

                ActionComplete();

                //objReceiptsInfo.ICReceiptStatus = ReceiptStatus.Complete.ToString();
                //entity.UpdateMainObject();

                //entity.ApprovedReceipt();
                ////TNDLoc [MOD][09/12/2015][Fix module status],START
                ////ModuleAfterCompleted();
                //ActionCancel();
                ////TNDLoc [MOD][09/12/2015][Fix module status],END
            }

        }
        /// <summary>
        /// Check exist serial No
        /// </summary>
        /// <param name="serialNo">serial no</param>
        /// <returns>true/false</returns>
        public bool IsExistSerialNo(string serialNo, string productType)
        {
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo productSerie = objProductSeriesController.GetSerieBySerieNoAndProductType(serialNo, productType);
            if (productSerie != null && productSerie.ICProductSerieID > 0)
                return true;
            return false;
        }
        /// <summary>
        /// Check exist serial No
        /// </summary>
        /// <returns></returns>
        public bool CheckExistSerialNo()
        {
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            foreach (ICReceiptItemsInfo item in entity.ReceiptItemsList)
            {
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    if (objProductsInfo.ICProductType != ProductType.Service.ToString() && !objProductsInfo.IsAsset)
                    {
                        if (IsExistSerialNo(item.ICReceiptItemProductSerialNo, objProductsInfo.ICProductType))
                        {
                            if (MessageBox.Show(string.Format(ReceiptFreshLumberLocalizedResources.IsExistLotNoConfirmText,
                               item.ICReceiptItemProductSerialNo), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                return true;
                            else
                                return false;
                        }
                        else if (item.ICReceiptItemProductSerialNo.Trim() == string.Empty)
                        {
                            MessageBox.Show(ReceiptFreshLumberLocalizedResources.IsLotNoIsNull, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else
                        {

                            int countItem = 0;
                            countItem = entity.ReceiptItemsList.Where(x => x.ICReceiptItemProductSerialNo == item.ICReceiptItemProductSerialNo &&
                                x.ICReceiptItemProductSerialNo.Trim() != string.Empty).Count();
                            if (countItem > 1)
                            {
                                MessageBox.Show(ReceiptFreshLumberLocalizedResources.IsExistLotNoInListText, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
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
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;

            ICProductsController productController = new ICProductsController();
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();

            string documentType = AccDocumentType.NhapKhoPhachTuoiCongDoanCua.ToString();
            string entryType = AccEntryType.NhapKhoPhachTuoiCongDoanCua.ToString();
            if (objReceiptsInfo.ICReceiptTypeCombo == ReceiptType.FreshLumber.ToString())
            {
                documentType = AccDocumentType.NhapKhoPhachTuoiCongDoanCua.ToString();
                entryType = AccEntryType.NhapKhoPhachTuoiCongDoanCua.ToString();
            }

            //if (objReceiptsInfo.ICReceiptTypeCombo == ReceiptType.FreshLumber.ToString())
            //{
            //    if (objReceiptsInfo.ICReceiptReference.Length == 0)
            //        documentType = AccDocumentType.NhapKhoMuaHang.ToString();
            //    else
            //        documentType = AccDocumentType.NhapKhoMuaHangHoaDon.ToString();
            //    entryType = AccEntryType.NhapKhoMuaHang.ToString();
            //}
            //else if (objReceiptsInfo.ICReceiptTypeCombo == ReceiptType.ReturnReceipt.ToString())
            //{
            //    documentType = AccDocumentType.NhapKhoHangTra.ToString();
            //    entryType = AccEntryType.NhapKhoHangTra.ToString();
            //}
            //else if (objReceiptsInfo.ICReceiptTypeCombo == ReceiptType.EquipmentReceipt.ToString())
            //{
            //    documentType = AccDocumentType.NhapCCDC.ToString();
            //    entryType = AccEntryType.NhapCCDC.ToString();
            //}
            ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        documentType,
                                                                        entryType);
            Dictionary<ACDocumentEntrysInfo, List<ICReceiptItemsInfo>> documentEntryAccounts = new Dictionary<ACDocumentEntrysInfo, List<ICReceiptItemsInfo>>();
            List<int> productAccountID = new List<int>();

            if (entity.ReceiptItemsList != null)
            {
                foreach (ICReceiptItemsInfo receiptItem in entity.ReceiptItemsList)
                {
                    // ICProductsInfo product = productController.GetObjectByID(receiptItem.FK_ICProductID) as ICProductsInfo;
                    ACDocumentEntrysInfo entry = entity.DocumentEntryList.FirstOrDefault(e => e.ACEntryTypeName == entryType
                                                                        && e.FK_ACDebitAccountID == receiptItem.FK_ACAccountID);
                    if (entry == null && defaultEntry != null)
                    {
                        entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, entity.DocumentEntryList);
                        entry.FK_ACDebitAccountID = receiptItem.FK_ACAccountID;
                    }
                    if (entry != null && !documentEntryAccounts.ContainsKey(entry))
                    {
                        documentEntryAccounts.Add(entry, new List<ICReceiptItemsInfo>());
                        productAccountID.Add(entry.FK_ACDebitAccountID);
                    }
                    documentEntryAccounts[entry].Add(receiptItem);
                }
            }

            //update document entry amount
            if (documentEntryAccounts.Count != 0)
            {
                ACDocumentEntrysInfo item = null;
                foreach (ACDocumentEntrysInfo entry in documentEntryAccounts.Keys)
                {
                    entry.ACDocumentEntryAmount = documentEntryAccounts[entry].Sum(i => i.ICReceiptItemInventoryCost * i.ICReceiptItemProductQty);
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objReceiptsInfo.ICReceiptExchangeRate;
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryAmount", objReceiptsInfo.FK_GECurrencyID);
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
                                                                              && !productAccountID.Any(accountID => accountID == item.FK_ACDebitAccountID)).ToList();
            if (removedItems != null)
            {
                foreach (ACDocumentEntrysInfo item in removedItems)
                    entity.DocumentEntryList.Remove(item);
            }

            //ReceiptEntities entity = (ReceiptEntities)CurrentModuleEntity;
            //ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;

            //foreach (var item in entity.DocumentEntryList)
            //{
            //    item.ACDocumentEntryAmount = 0;
            //    item.ACDocumentEntryExchangeAmount = 0;
            //}
            //foreach (var item in entity.ReceiptItemsList)
            //{
            //    ICProductsController obj = new ICProductsController();
            //    ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(item.FK_ICProductID);
            //    if (objProductsInfo != null)
            //    UpdateDocumentEntryList(objProductsInfo.FK_ACAccountID, item.ICReceiptItemInventoryCost * item.ICReceiptItemProductQty, entity, objReceiptsInfo.ICReceiptExchangeRate);
            //}

            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }

        //protected override void UpdateDocumentEntries()
        //{
        //    BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
        //    ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
        //    foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
        //    {
        //        if (entry.ACEntryTypeName == AccEntryType.NhapKhoDieuChinh.ToString() ||
        //            entry.ACEntryTypeName == AccEntryType.NhapKhoMuaHang.ToString() ||
        //            entry.ACEntryTypeName == AccEntryType.NhapKhoHangTra.ToString() ||
        //            entry.ACEntryTypeName == AccEntryType.NhapKhoNVL.ToString())
        //        {
        //            entry.ACDocumentEntryAmount = entity.ReceiptItemsList.Sum(i => i.ICReceiptItemInventoryCost * i.ICReceiptItemProductQty);
        //            entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objReceiptsInfo.ICReceiptExchangeRate;
        //        }
        //    }
        //    entity.DocumentEntryList.GridControl.RefreshDataSource();
        //    foreach (var item in entity.ReceiptItemsList)
        //    {
        //        ICProductsController obj = new ICProductsController();
        //        ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(item.FK_ICProductID);

        //        //[NNThinh] [ADD] [16/04/2014] [ACAccountID of product for batch Receipt, will change soon ], START
        //        ACAccountsController objAccountsController = new ACAccountsController();
        //        ACAccountsInfo objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc152);

        //        //if (objAccountsInfo != null)
        //        //UpdateDocumentEntryList(objAccountsInfo.ACAccountID, item.ICReceiptItemInventoryCost * item.ICReceiptItemProductQty, entity, objReceiptsInfo.ICReceiptExchangeRate);
        //        //[NNThinh] [ADD] [16/04/2014] [ACAccountID of product for batch Receipt, will change soon ], END
        //    }

        //}
        #endregion

        //TNDLoc [ADD][09/12/2015][Issue New From BatchProduct],START
        public void ActionNewFromBatchProduct()
        {

            ActionNew();
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;

            objReceiptsInfo.ICReceiptCreateFrom = CreateFrom.BatchProduct.ToString();
            SetVisibleShowItemButton();

        }
        public override void ActionNew()
        {
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            objReceiptsInfo.ICReceiptAcceptanceType = ReceiptAcceptanceType.None.ToString();
            base.ActionNew();
        }
        public void ActionNewFromBatchLumber()
        {
            ActionNew();
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;

            MMBatchProductsInfo objBatchProductsInfo = new MMBatchProductsInfo();
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            MMBatchProductItemsInfo objBatchProductItemsInfo = new MMBatchProductItemsInfo();
            MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
            List<MMBatchProductItemsInfo> listBatchProductItem = new List<MMBatchProductItemsInfo>();
            ICReceiptsInfo objReceiptInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            listBatchProductItem = objBatchProductItemsController.GetBatchProductForReceipt();
            guiFind<MMBatchProductItemsInfo> guiItem = new guiFind<MMBatchProductItemsInfo>(TableName.MMBatchProductItemsTableName,
                                                                                                listBatchProductItem,
                                                                                                this,
                                                                                                true,
                                                                                                true,
                                                                                                new string[] { "MMBatchProductNo" });
            guiItem.ShowDialog();
            if (guiItem.DialogResult == DialogResult.OK)
            {
                List<MMBatchProductItemsInfo> batchProductItemList = (List<MMBatchProductItemsInfo>)guiItem.SelectedObjects;
                if (guiItem.SelectedObjects != null && guiItem.SelectedObjects.Count > 0)
                {
                    listBatchProductItem = batchProductItemList.Where(x => x.FK_MMBatchProductID != guiItem.SelectedObjects[0].FK_MMBatchProductID).ToList();
                }
                if (listBatchProductItem != null && listBatchProductItem.Count > 0)
                {
                    MessageBox.Show(ReceiptFreshLumberLocalizedResources.ChooseMultiBatchProduct, CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ActionCancel();
                    ActionNewFromBatchLumber();

                }
                else
                {
                    objBatchProductsInfo = (MMBatchProductsInfo)objBatchProductsController.GetObjectByID(guiItem.SelectedObjects[0].FK_MMBatchProductID);
                    if (objBatchProductsInfo != null)
                    {
                        BOSUtil.CopyObject(objBatchProductsInfo, objReceiptsInfo);
                        objReceiptsInfo.ICReceiptNo = "***NEW***";
                        objReceiptsInfo.ICReceiptDate = DateTime.Now;
                        objReceiptsInfo.FK_MMBatchProductID = objBatchProductsInfo.MMBatchProductID;
                        objReceiptsInfo.FK_ICProductAttributeTTMTID = objBatchProductsInfo.FK_ICProductAttributeTTMTID;
                        objReceiptsInfo.ICReceiptStatus = ReceiptStatus.New.ToString();
                        DisplayLabelText(objReceiptsInfo);
                        CurrentModuleEntity.UpdateMainObjectBindingSource();
                    }
                    foreach (MMBatchProductItemsInfo item in guiItem.SelectedObjects)
                    {
                        ICReceiptItemsInfo objReceiptItemsInfo = new ICReceiptItemsInfo();
                        BOSUtil.CopyObject(item, objReceiptItemsInfo);
                        //hạt code
                        objReceiptItemsInfo.ICReceiptItemProductType = ReceiptProductType.FreshLumber.ToString();
                        objReceiptItemsInfo.FK_MMBatchProductID = item.FK_MMBatchProductID;
                        objReceiptItemsInfo.FK_MMOperationID = objReceiptsInfo.FK_MMOperationID;
                        objReceiptItemsInfo.FK_ICStockID = objReceiptsInfo.FK_ICStockID;
                        objReceiptItemsInfo.ICReceiptItemLotNo = objReceiptsInfo.ICReceiptPackNo;
                        objReceiptItemsInfo.ICReceiptItemWidthMax = item.MMBatchProductItemProductMaxWidth;
                        objReceiptItemsInfo.ICReceiptItemLenghtMax = item.MMBatchProductItemProductMaxLength;
                        objReceiptItemsInfo.FK_ICProductAttributeWoodTypeID = item.FK_ICProductAttributeWoodTypeID;
                        //NNGiang   Round Qty 19-05-2016 Start
                        objReceiptItemsInfo.ICReceiptItemProductQty = Math.Round(item.MMBatchProductItemProductQty, 4, MidpointRounding.AwayFromZero);
                        //NNGiang   Round Qty 19-05-2016 End
                        objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                        if (objReceiptItemsInfo.FK_ACAccountID == 0 && objProductsInfo != null)
                        {
                            objReceiptItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                        }
                        entity.SetProductCostByProductUnitCost(objReceiptItemsInfo);
                        entity.ReceiptItemsList.Add(objReceiptItemsInfo);

                    }

                    entity.UpdateTotalCost();
                    UpdateDocumentEntries();
                    entity.ReceiptItemsList.GridControl.RefreshDataSource();

                }
            }
            else ActionCancel();

        }

        public void SetVisibleShowItemButton()
        {
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            if (objReceiptsInfo.ICReceiptCreateFrom == CreateFrom.BatchProduct.ToString())
            {
                ShowItemButton.Visible = true;
            }
            else
            {
                ShowItemButton.Visible = false;
            }
        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            SetVisibleShowItemButton();
        }
        public void ShowItem()
        {
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;

            MMBatchProductItemsController objBatchProductItemsController = new MMBatchProductItemsController();
            List<MMBatchProductItemsInfo> batchProductItemList = new List<MMBatchProductItemsInfo>();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            ICProductsController objProductsController = new ICProductsController();
            batchProductItemList = objBatchProductItemsController.GetBatchProductItemByBatchProduct(objReceiptsInfo.FK_MMBatchProductID);

            guiFind<MMBatchProductItemsInfo> guiBatchProductItem
                = new guiFind<MMBatchProductItemsInfo>(TableName.MMBatchProductItemsTableName,
                                                       batchProductItemList,
                                                       this,
                                                       true);
            if (guiBatchProductItem.ShowDialog() == DialogResult.OK)
            {
                foreach (MMBatchProductItemsInfo item in guiBatchProductItem.SelectedObjects)
                {
                    ICReceiptItemsInfo objReceiptItemsInfo = new ICReceiptItemsInfo();
                    BOSUtil.CopyObject(item, objReceiptItemsInfo);
                    objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                    if (objProductsInfo != null && objReceiptItemsInfo.FK_ACAccountID == 0)
                    {
                        objReceiptItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                    }
                    objReceiptItemsInfo.FK_MMBatchProductID = objReceiptsInfo.FK_MMBatchProductID;
                    objReceiptItemsInfo.FK_MMOperationID = objReceiptsInfo.FK_MMOperationID;
                    objReceiptItemsInfo.FK_ICStockID = objReceiptsInfo.FK_ICStockID;
                    objReceiptItemsInfo.ICReceiptItemLotNo = objReceiptsInfo.ICReceiptPackNo;
                    //NNGiang   Round Qty 19-05-2016 Start
                    objReceiptItemsInfo.ICReceiptItemProductQty = Math.Round(item.MMBatchProductItemProductQty, 4, MidpointRounding.AwayFromZero);
                    //NNGiang   Round Qty 19-05-2016 End
                    entity.ReceiptItemsList.Add(objReceiptItemsInfo);
                }
                UpdateDocumentEntries();
                entity.ReceiptItemsList.GridControl.RefreshDataSource();
            }
        }
        //TNDLoc [ADD][09/12/2015][Issue New From BatchProduct],END

        //[NKVung] [Add to item] [START]
        public void UpdateTTMT(int TTMTID)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
                if (entity.ReceiptItemsList.Count > 0)
                {
                    foreach (ICReceiptItemsInfo item in entity.ReceiptItemsList)
                    {
                        item.FK_ICProductAttributeTTMTID = TTMTID;
                    }
                    entity.ReceiptItemsList.GridControl.RefreshDataSource();
                }
            }
        }
        public void UpdateOperation(int OperationID)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
                if (entity.ReceiptItemsList.Count > 0)
                {
                    foreach (ICReceiptItemsInfo item in entity.ReceiptItemsList)
                    {
                        item.FK_MMOperationID = OperationID;
                    }
                    entity.ReceiptItemsList.GridControl.RefreshDataSource();
                }
            }
        }
        public void UpdateBatchProductID(int batchProductID)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
                if (entity.ReceiptItemsList.Count > 0)
                {
                    foreach (ICReceiptItemsInfo item in entity.ReceiptItemsList)
                    {
                        item.FK_MMBatchProductID = batchProductID;
                    }
                    entity.ReceiptItemsList.GridControl.RefreshDataSource();
                }
            }
        }
        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                BatchReceiptFreshLumber.BatchReceiptFreshLumberModule.PrintReceipt(Toolbar.CurrentObjectID);
            }
        }
        public static void PrintReceipt(int receiptID)
        {
            RP_ReceiptForLumber report = new RP_ReceiptForLumber();
            //report.LoadLayout(BOSCommon.Constants.Report.DevReceiptItemReportPath);
            InitReceiptReport(report, receiptID);
            guiReportPreview viewer = new guiReportPreview(report);
            viewer.Show();
        }
        private static void InitReceiptReport(XtraReport report, int receiptID)
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

            ICReceiptsController objReceiptsController = new ICReceiptsController();
            ICReceiptsInfo receipt = (ICReceiptsInfo)objReceiptsController.GetObjectByID(receiptID);
            #region Hạch Toán
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
            if (receipt != null)
            {
                ACDocumentsController objDocumentsController = new ACDocumentsController();
                ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                ACDocumentsInfo document = null;
                if (receipt.ICReceiptTypeCombo == ReceiptType.LumberReceipt.ToString())
                {
                    document = objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.NhapKhoPhachTuoiCongDoanCua.ToString(), receipt.ICReceiptNo);
                }
                //else if (receipt.ICReceiptTypeCombo == ReceiptType.PurchaseReceipt.ToString())
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
                    if (entry.ACDocumentDebitAccount != null)
                    {
                        if (!debitAccountNo.Contains(entry.ACDocumentDebitAccount))
                        {
                            debitAccountNo += string.Format(" {0},", entry.ACDocumentDebitAccount);
                        }
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
                accLabel.Text = receipt.ICReceiptDate.ToString("dd/MM/yyyy");
            }
            accLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel29"];
            if (accLabel != null)
            {
                accLabel.Text = receipt.ICReceiptDate.ToString("dd/MM/yyyy");
            }
            //accLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xrPageInfo2"];
            //if (accLabel != null)
            //{
            //    string str = DateTime.Now.ToString().Trim();
            //    str = str.Substring(0, 2);
            //    accLabel.Text = str;
            //}
            //accLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xrPageInfo3"];
            //if (accLabel != null)
            //{
            //    string str = DateTime.Now.ToString().Trim();
            //    str = str.Substring(3, 2);
            //    accLabel.Text = str;
            //}
            //accLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xrPageInfo4"];
            //if (accLabel != null)
            //{
            //    string str = DateTime.Now.ToString().Trim();
            //    str = str.Substring(6, 4);
            //    accLabel.Text = str;
            //}
            //GECurrenciesController objCurrenciesController = new GECurrenciesController();
            //GECurrenciesInfo currency = (GECurrenciesInfo)objCurrenciesController.GetObjectByID(receipt.FK_GECurrencyID);
            //accLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xrLabel27"];
            //if (accLabel != null)
            //{
            //    accLabel.Text = ConvertAmountToWord.ReadAmount(receipt.ICReceiptTotalCost.ToString(), currency.GECurrencyID);
            //}



            ADReportsController objReportsController = new ADReportsController();
            decimal Tongsoluong = 0;
            foreach (ICReceiptItemsInfo item in objReportsController.GetListReceiptItemByReceiptID(receiptID))
            {
                if (item != null)
                {
                    item.ICReceiptItemWoodQty = Math.Round(item.ICReceiptItemWoodQty, 0);
                    Tongsoluong += item.ICReceiptItemWoodQty;
                }
            }
            accLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xrLabel31"];
            if (accLabel != null)
            {
                accLabel.Text = Tongsoluong.ToString();
            }
            report.DataSource = objReportsController.GetListReceiptItemByReceiptID(receiptID);
            //report.DataMember = BOSCommon.Constants.Report.DevReceiptItemReportName;
        }
        //[NKVung] [END]
        #region ActionNewFromAcceptance
        public void NewFromAcceptance()
        {
            ActionNew();
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            List<ICShipmentsInfo> listItem = new List<ICShipmentsInfo>();
            ICShipmentsController objShipmentsController = new ICShipmentsController();
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            listItem = objShipmentsController.GetItemForAcceptance(ShipmentShipmentType.FreshLumber.ToString());
            ICShipmentsInfo objShipmentsInfo = new ICShipmentsInfo();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            ICProductsController objProductsController = new ICProductsController();

            guiFind<ICShipmentsInfo> guiAcceptance = new guiFind<ICShipmentsInfo>(TableName.ICShipmentsTableName,
                                                      listItem,
                                                      this,
                                                      false);
            if (guiAcceptance.ShowDialog() == DialogResult.OK)
            {
                objShipmentsInfo = (ICShipmentsInfo)objShipmentsController.GetObjectByID(guiAcceptance.SelectedObjects[0].ICShipmentID);
                if (objShipmentsInfo != null)
                {
                    BOSUtil.CopyObject(objShipmentsInfo, objReceiptsInfo);
                    objReceiptsInfo.ICReceiptNo = "***NEW***";
                    //objReceiptsInfo.FK_MMBatchProductID = objBatchProductsInfo.MMBatchProductID;
                    //objReceiptsInfo.FK_ICProductAttributeTTMTID = objBatchProductsInfo.FK_ICProductAttributeTTMTID;
                    objReceiptsInfo.ICReceiptStatus = ReceiptStatus.New.ToString();
                    objReceiptsInfo.ICReceiptTypeCombo = ReceiptType.LumberReceipt.ToString();
                    objReceiptsInfo.ICReceiptAcceptanceType = ReceiptAcceptanceType.Acceptance.ToString();
                    ICStocksController objStockController = new ICStocksController();
                    ICStocksInfo objStockInfo = (ICStocksInfo)objStockController.GetObjectByNo(StockNo.FreshLumberStock.ToString());
                    if (objStockInfo != null)
                        objReceiptsInfo.FK_ICStockID = objStockInfo.ICStockID;
                    DisplayLabelText(objReceiptsInfo);
                    CurrentModuleEntity.UpdateMainObjectBindingSource();
                }
                List<ICShipmentItemsInfo> ItemList = new List<ICShipmentItemsInfo>();
                ItemList = objShipmentItemsController.GetShipmentItemsByFK_ShipmentID(guiAcceptance.SelectedObjects[0].ICShipmentID);
                foreach (ICShipmentItemsInfo item in ItemList)
                {
                    ICReceiptItemsInfo objReceiptItemsInfo = new ICReceiptItemsInfo();
                    BOSUtil.CopyObject(item, objReceiptItemsInfo);
                    objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                    if (objReceiptItemsInfo.FK_ACAccountID == 0 && objProductsInfo != null)
                        objReceiptItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                    objReceiptItemsInfo.ICReceiptItemLotNo = objReceiptsInfo.ICReceiptPackNo;
                    objReceiptItemsInfo.FK_ICShipmentItemID = item.Id;
                    objReceiptItemsInfo.ICReceiptItemProductHeight = item.ICShipmentItemHeight;
                    objReceiptItemsInfo.ICReceiptItemProductWidth = item.ICShipmentItemWidth;
                    objReceiptItemsInfo.ICReceiptItemProductLength = item.ICShipmentItemLength;

                    objReceiptItemsInfo.ICReceiptItemWidthMax = item.ICShipmentItemWidthMax;
                    objReceiptItemsInfo.ICReceiptItemLenghtMin = item.ICShipmentItemLengthMin;
                    objReceiptItemsInfo.ICReceiptItemLenghtMax = item.ICShipmentItemLengthMax;
                    objReceiptItemsInfo.ICReceiptItemTotalCost = item.ICShipmentItemTotalAmount;
                    objReceiptItemsInfo.ICReceiptItemProductUnitCost = item.ICShipmentItemProductUnitPrice;
                    //NNGiang   Round Qty 19-05-2016 Start
                    objReceiptItemsInfo.ICReceiptItemProductQty = Math.Round(item.ICShipmentItemProductQty, 4, MidpointRounding.AwayFromZero);
                    //NNGiang   Round Qty 19-05-2016 End
                    entity.SetProductCostByProductUnitCost(objReceiptItemsInfo);
                    entity.ReceiptItemsList.Add(objReceiptItemsInfo);


                }
                UpdateTotalCost();
                entity.ReceiptItemsList.GridControl.RefreshDataSource();

            }
        }
        public void CalculateUnitCost()
        {
            CalculateUnitCostFuntion(true);

        }
        public void CalculateUnitCostFuntion(bool IsEdit)
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
                ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
                if (objReceiptsInfo.ICReceiptAcceptanceType == ReceiptAcceptanceType.Acceptance.ToString())
                {
                    if (IsEdit)
                    {
                        ActionEdit();
                    }
                    List<int> ListInt = new List<int>();
                    foreach (ICReceiptItemsInfo item in entity.ReceiptItemsList)
                    {
                        if (!ListInt.Contains(item.FK_ICShipmentItemID))
                            ListInt.Add(item.FK_ICShipmentItemID);
                    }
                    foreach (int number in ListInt)
                    {
                        decimal UnitCostPerOne = 0;
                        ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
                        ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
                        objShipmentItemsInfo = (ICShipmentItemsInfo)objShipmentItemsController.GetObjectByID(number);
                        if (objShipmentItemsInfo != null)
                        {

                            decimal qty = entity.ReceiptItemsList.Where(x => x.FK_ICShipmentItemID == number).Sum(t => t.ICReceiptItemProductQty);
                            if (qty != 0)
                            {
                                //if (objShipmentItemsInfo.ICShipmentItemTotalCost != 0)
                                //{
                                //    UnitCostPerOne = objShipmentItemsInfo.ICShipmentItemTotalCost / qty;
                                //}
                                //else
                                //{
                                UnitCostPerOne = objShipmentItemsInfo.ICShipmentItemTotalAmount / qty;
                                //}
                            }
                            foreach (ICReceiptItemsInfo item in entity.ReceiptItemsList)
                            {
                                if (item.FK_ICShipmentItemID == number)
                                {
                                    item.ICReceiptItemProductUnitCost = UnitCostPerOne;
                                    item.ICReceiptItemTotalCost = item.ICReceiptItemProductUnitCost * item.ICReceiptItemProductQty;
                                    entity.SetProductCostByProductUnitCost();
                                    UpdateTotalCost();
                                }
                            }
                        }
                    }
                    entity.ReceiptItemsList.GridControl.RefreshDataSource();
                    // ActionSave();

                }
            }
        }


        public void ActionNewFromCD()
        {
            ActionNew();
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            ICReceiptsInfo oldReceipts = (ICReceiptsInfo)CurrentModuleEntity.MainObject.Clone();
            ICShipmentsInfo objShipmentsInfo = new ICShipmentsInfo();
            ICShipmentsController objShipmentsController = new ICShipmentsController();
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentsInfo> ListCD = new List<ICShipmentsInfo>();
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            ICProductsInfo objProductsMainInfo = new ICProductsInfo();



            ListCD = objShipmentsController.GetListItemForShipmentFreshLumber();
            if (ListCD != null && ListCD.Count > 0)
            {
                guiFind<ICShipmentsInfo> guiFind = new guiFind<ICShipmentsInfo>(TableName.ICShipmentsTableName,
                                                      ListCD,
                                                      this,
                                                      true,
                                                      true,
                                                      new string[] { },
                                                      null,
                                                      true);

            Stamp: guiFind.ShowDialog();
                if (guiFind.DialogResult == DialogResult.OK)
                {

                    objShipmentsInfo = (ICShipmentsInfo)guiFind.SelectedObjects[0];
                    if (objShipmentsInfo != null)
                    {
                        BOSUtil.CopyObject(objShipmentsInfo, objReceiptsInfo);
                        objReceiptsInfo.ICReceiptDate = oldReceipts.ICReceiptDate;
                        objReceiptsInfo.ICReceiptNo = "***NEW***";
                        objReceiptsInfo.ICReceiptStatus = oldReceipts.ICReceiptStatus;
                        objReceiptsInfo.ICReceiptTypeCombo = oldReceipts.ICReceiptTypeCombo;
                        objReceiptsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                        //Do tạo từ nhiều phiếu không lấy được giá trị 2 trường 
                        // objReceiptsInfo.ICReceiptSerialPrefix = objShipmentsInfo.ICShipmentSerialPrefix;
                        if (objShipmentsInfo.IsReuse == 1)
                        {
                            objReceiptsInfo.FK_MMBatchProductID = 0;
                            objReceiptsInfo.FK_MMOperationID = 0;
                        }
                        objReceiptsInfo.ICReceiptPackNo = objShipmentsInfo.ICShipmentPackNo;
                        DisplayLabelText(objReceiptsInfo);
                        CurrentModuleEntity.UpdateMainObjectBindingSource();

                        ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
                        objProductsMainInfo = (ICProductsInfo)objProductsController.GetObjectByID(objReceiptsInfo.FK_ICProductID);

                        List<ICShipmentsInfo> selectedShipments = guiFind.SelectedObjects as List<ICShipmentsInfo>;
                        if (selectedShipments != null && selectedShipments.Count > 0)
                        {
                            foreach (ICShipmentsInfo item in selectedShipments)
                            {
                                if (item.ICShipmentPackNo != objShipmentsInfo.ICShipmentPackNo)
                                {
                                    MessageBox.Show("Vui lòng chọn các phiếu xuất cùng chung mã lô", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    entity.ReceiptItemsList.Clear();
                                    entity.ReceiptItemsList.GridControl.RefreshDataSource();
                                    goto Stamp;
                                }
                                if (item.IsReuse != objShipmentsInfo.IsReuse)
                                {
                                    MessageBox.Show("Gỗ tận dụng không thể được tạo chung với các loại gỗ khác. Vui lòng kiểm tra lại", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    entity.ReceiptItemsList.Clear();
                                    entity.ReceiptItemsList.GridControl.RefreshDataSource();
                                    goto Stamp;
                                }
                                objShipmentItemsInfo = (ICShipmentItemsInfo)objShipmentItemsController.GetListItemForShipmentFreshLumber(item.ICShipmentID);
                                if (objShipmentItemsInfo != null)
                                {
                                    ICReceiptItemsInfo objReceiptItemsInfo = new ICReceiptItemsInfo();
                                    BOSUtil.CopyObject(objShipmentItemsInfo, objReceiptItemsInfo);
                                    objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objShipmentItemsInfo.FK_ICProductID);
                                    if (objProductsInfo != null)
                                    {
                                        objReceiptItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                                        objReceiptItemsInfo.FK_ACAccountID = GetAccountByStock(objReceiptItemsInfo.FK_ICStockID, objReceiptItemsInfo.FK_ACAccountID);
                                    }

                                    objReceiptItemsInfo.FK_ICShipmentID = objReceiptItemsInfo.FK_ICShipmentID;
                                    objReceiptItemsInfo.ICReceiptItemProductHeight = objShipmentItemsInfo.ICShipmentItemHeight;
                                    objReceiptItemsInfo.ICReceiptItemWidthMin = objShipmentItemsInfo.ICShipmentItemWidthMin;
                                    objReceiptItemsInfo.ICReceiptItemWidthMax = objShipmentItemsInfo.ICShipmentItemWidthMax;
                                    objReceiptItemsInfo.ICReceiptItemLenghtMin = objShipmentItemsInfo.ICShipmentItemLengthMin;
                                    objReceiptItemsInfo.ICReceiptItemLenghtMax = objShipmentItemsInfo.ICShipmentItemLengthMax;
                                    objReceiptItemsInfo.ICReceiptItemProductWidth = objShipmentItemsInfo.ICShipmentItemWidthMin;
                                    objReceiptItemsInfo.ICReceiptItemProductLength = objShipmentItemsInfo.ICShipmentItemLengthMin;
                                    objReceiptItemsInfo.ICReceiptItemLotNo = objShipmentItemsInfo.ICShipmentItemLotNo;
                                    objReceiptItemsInfo.ICReceiptItemProductSerialNo = item.ICShipmentSerialPrefix;
                                    objReceiptItemsInfo.ICReceiptItemWoodQty = objShipmentItemsInfo.ICShipmentItemWoodQty;
                                    entity.ReceiptItemsList.Add(objReceiptItemsInfo);
                                    entity.ReceiptItemsList.GridControl.RefreshDataSource();
                                }
                            }
                            UpdateTotalCost();
                        }
                    }
                }

                else
                    ActionCancel();
            }

        }
        public void GetSelectedItem(ICShipmentItemsInfo item)
        {
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;

            ICReceiptItemsInfo objReceiptItemsInfo = new ICReceiptItemsInfo();
            BOSUtil.CopyObject(item, objReceiptItemsInfo);

            //objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
            //if (objReceiptItemsInfo.FK_ACAccountID == 0 && objProductsInfo != null)
            //    objReceiptItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;

            objReceiptItemsInfo.ICReceiptItemLotNo = objReceiptsInfo.ICReceiptPackNo;
            objReceiptItemsInfo.FK_ICShipmentID = item.FK_ICShipmentID;
            objReceiptItemsInfo.FK_ICShipmentItemID = item.Id;


            objReceiptItemsInfo.ICReceiptItemProductHeight = item.ICShipmentItemHeight;
            objReceiptItemsInfo.ICReceiptItemProductWidth = item.ICShipmentItemWidth;
            objReceiptItemsInfo.ICReceiptItemProductLength = item.ICShipmentItemLength;

            objReceiptItemsInfo.ICReceiptItemWidthMax = item.ICShipmentItemWidthMax;
            objReceiptItemsInfo.ICReceiptItemLenghtMin = item.ICShipmentItemLengthMin;
            objReceiptItemsInfo.ICReceiptItemLenghtMax = item.ICShipmentItemLengthMax;
            objReceiptItemsInfo.ICReceiptItemTotalCost = item.ICShipmentItemTotalAmount;
            objReceiptItemsInfo.ICReceiptItemProductUnitCost = item.ICShipmentItemProductUnitPrice;
            //NNGiang   Round Qty 19-05-2016 Start
            objReceiptItemsInfo.ICReceiptItemProductQty = Math.Round(item.ICShipmentItemProductQty, 4, MidpointRounding.AwayFromZero);
            //NNGiang   Round Qty 19-05-2016 End
            entity.SetProductCostByProductUnitCost(objReceiptItemsInfo);
            entity.ReceiptItemsList.Add(objReceiptItemsInfo);


        }
        public void ChangeStock(int stockID)
        {
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
            ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)CurrentModuleEntity.MainObject;
            objReceiptsInfo.FK_ICStockID = stockID;
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (entity.ReceiptItemsList.Count > 0)
                {
                    if (MessageBox.Show(BatchReceiptDryLumberLocalizedResources.ConfirmChangeItemStockMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (ICReceiptItemsInfo item in entity.ReceiptItemsList)
                        {
                            item.FK_ICStockID = stockID;
                            item.FK_ACAccountID = GetAccountByStock(stockID, item.FK_ACAccountID);
                        }
                        entity.ReceiptItemsList.GridControl.RefreshDataSource();
                    }
                    UpdateDocumentEntries();
                }
            }
        }
        public void ChangeStock(ICReceiptItemsInfo item)
        {
            BatchReceiptFreshLumberEntities entity = (BatchReceiptFreshLumberEntities)CurrentModuleEntity;
            item.FK_ACAccountID = GetAccountByStock(item.FK_ICStockID, item.FK_ACAccountID);
            entity.ReceiptItemsList.GridControl.RefreshDataSource();
            UpdateDocumentEntries();
        }





        #endregion




    }
    #endregion
}
