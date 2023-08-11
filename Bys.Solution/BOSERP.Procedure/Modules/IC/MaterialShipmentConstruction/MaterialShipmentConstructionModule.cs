using BOSCommon;
using BOSCommon.Constants;
using BOSERP.GenaralLeadger;
using BOSLib;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.MaterialShipmentConstruction
{
    #region MaterialShipment
    public class MaterialShipmentConstructionModule : GLShipmentModule
    {
        #region Constants
        public const string ShipmentItemGridControlName = "fld_dgcICShipmentItem1s";
        public const string DocumentEntryGridControlName = "fld_dgcACDocumentEntrys";
        public const string TabControlName = "fld_tabShiptmentItems";
        public const string ICShipmentShipmentTypeLookupEditControlName = "fld_lkeICShipmentShipmentType";
        public const string ICProductLookupEditControlName = "fld_lkeICProductID2";
        public const string MMOperationLookupEditControlName = "fld_lkeFK_MMOperationID";
        public const string ButtonShowAllocationProposal = "fld_btnShowAllocationProposal";
        public const string ICShipmentItemGridControlName = "fld_dgcICShipmentItems";

        #endregion
        #region Properties
        BOSComponent.BOSTabControl Tab;
        BOSComponent.BOSLookupEdit IShipmentShipmentType;
        BOSComponent.BOSLookupEdit ProductLookupEditControl;
        BOSComponent.BOSLookupEdit MMOperationLookupEditControl;
        BOSComponent.BOSButton ShowAllocationProposal;
        #endregion
        public MaterialShipmentConstructionModule()
        {
            Name = ModuleName.MaterialShipmentConstruction;
            CurrentModuleEntity = new MaterialShipmentConstructionEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            Tab = (BOSComponent.BOSTabControl)Controls[MaterialShipmentConstructionModule.TabControlName];
            IShipmentShipmentType = (BOSComponent.BOSLookupEdit)Controls[MaterialShipmentConstructionModule.ICShipmentShipmentTypeLookupEditControlName];
            ProductLookupEditControl = (BOSComponent.BOSLookupEdit)Controls[MaterialShipmentConstructionModule.ICProductLookupEditControlName];
            MMOperationLookupEditControl = (BOSComponent.BOSLookupEdit)Controls[MaterialShipmentConstructionModule.MMOperationLookupEditControlName];
            ShowAllocationProposal = (BOSComponent.BOSButton)Controls[MaterialShipmentConstructionModule.ButtonShowAllocationProposal];
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
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
                                                                    ShipmentType.MaterialShipmentConstruction.ToString(),
                                                                    null,
                                                                    searchObject.ShipmentDateFrom,
                                                                    searchObject.ShipmentDateTo);

            return ds;
        }

        public void ChangeItemFromShipmentItemsList()
        {
            MaterialShipmentConstructionEntities entity = (MaterialShipmentConstructionEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            int index = entity.ShipmentItemList.CurrentIndex;
            if (index >= 0)
            {
                ICShipmentItemsInfo objShipmentItemsInfo = entity.ShipmentItemList[index];
                if (objShipmentItemsInfo != null)
                {
                    objShipmentItemsInfo.ICShipmentItemTotalAmount = objShipmentItemsInfo.ICShipmentItemProductQty * objShipmentItemsInfo.ICShipmentItemProductUnitPrice;
                    BOSApp.RoundByCurrency(objShipmentItemsInfo, objShipmentsInfo.FK_GECurrencyID);
                    entity.SetProductCostByProductUnitCost(objShipmentItemsInfo);
                }
                entity.ShipmentItemList.GridControl.RefreshDataSource();
            }
            UpdateDocumentEntries();
        }

        public void ChangeItemProductQty()
        {
            MaterialShipmentConstructionEntities entity = (MaterialShipmentConstructionEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            int index = entity.ShipmentItemList.CurrentIndex;
            if (index < 0)
                return;
            ICShipmentItemsInfo objShipmentItemsInfo = entity.ShipmentItemList[index];
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();

            ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
            ICTransferItemsInfo objTransferItemsInfo = (ICTransferItemsInfo)objTransferItemsController.GetObjectByID(objShipmentItemsInfo.FK_ICTransferItemID);
            if (objTransferItemsInfo == null)
                objTransferItemsInfo = new ICTransferItemsInfo();

            List<ICShipmentItemsInfo> shipmentItems = objShipmentItemsController.GetAllShipmentItemsByTransferItemID(objShipmentItemsInfo.FK_ARDeliveryPlanItemID);
            decimal totalQty = shipmentItems.Where(o => o.Id != objShipmentItemsInfo.Id
                                                    && o.FK_ICTransferItemID != 0).Select(o => o.ICShipmentItemProductQty).Sum();

            if ((objShipmentItemsInfo.ICShipmentItemProductQty > objTransferItemsInfo.ICTransferItemProductQty - totalQty) && objShipmentItemsInfo.FK_ICTransferItemID != 0)
            {
                MessageBox.Show(OutsourcingShipmentLocalizedResources.ShipmentItemMaxProductQtyErrorMessages, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objShipmentItemsInfo.ICShipmentItemProductQty = objTransferItemsInfo.ICTransferItemProductQty - totalQty;
                return;
            }

            objShipmentItemsInfo.ICShipmentItemTaxAmount = objShipmentItemsInfo.ICShipmentItemProductQty * objShipmentItemsInfo.ICShipmentItemProductUnitPrice;
            entity.SetProductCostByProductUnitCost(objShipmentItemsInfo);
            entity.ShipmentItemList.GridControl.RefreshDataSource();
            UpdateDocumentEntries();
        }

        public void SelectSeriesNoDefault()
        {
            MaterialShipmentConstructionEntities entity = (MaterialShipmentConstructionEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;

            DataGenerator.SelectSeriesNoDefault(entity.ShipmentItemList);
            entity.ShipmentItemList.GridControl.RefreshDataSource();
        }

        public void AddItemToShipmentItemsList()
        {
            MaterialShipmentConstructionEntities entity = (MaterialShipmentConstructionEntities)CurrentModuleEntity;
            ICShipmentItemsInfo objShipmentItemsInfo = (ICShipmentItemsInfo)entity.ModuleObjects[TableName.ICShipmentItemsTableName];
            objShipmentItemsInfo.FK_ICTransferID = 0;
            objShipmentItemsInfo.FK_ICTransferItemID = 0;
            if (objShipmentItemsInfo.FK_ICProductID > 0)
            {
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objShipmentItemsInfo.FK_ICProductID);

                if (objShipmentsInfo != null)
                {
                    objShipmentItemsInfo.FK_MMBatchProductID = objShipmentsInfo.FK_MMBatchProductID;
                    objShipmentItemsInfo.FK_MMOperationID = objShipmentsInfo.FK_MMOperationID;
                    objShipmentItemsInfo.FK_ICImportAndExportReasonID = objShipmentsInfo.FK_ICImportAndExportReasonID;
                }
                if (objProductsInfo != null)
                {
                    entity.SetValuesAfterValidateProduct(objShipmentItemsInfo.FK_ICProductID, objShipmentItemsInfo);
                    objShipmentItemsInfo.FK_ICProductAttributeWoodTypeID = objProductsInfo.FK_ICProductAttributeWoodTypeID;
                    objShipmentItemsInfo.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                    objShipmentItemsInfo.FK_ACAccountID = GetAccountByStock(objShipmentItemsInfo.FK_ICStockID, objShipmentItemsInfo.FK_ACAccountID);
                }
                if (objShipmentsInfo.ICShipmentShipmentType.ToString() == AllocationProposalProductType.DryLumber.ToString())
                {
                    entity.ShipmentItemList.AddObjectToList();
                    entity.ShipmentItemList.GridControl.RefreshDataSource();
                }
                else
                {
                    entity.ShipmentItemList.AddObjectToList();
                    entity.ShipmentItemList.GridControl.RefreshDataSource();
                }
            }
            UpdateDocumentEntries();
        }

        public override void InvalidateToolbar()
        {
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
            if (objShipmentsInfo.ICShipmentStatus == ShipmentStatus.New.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton("Approve", true);
            }
            if (objShipmentsInfo.ICShipmentStatus == ShipmentStatus.Complete.ToString())
            {
                ParentScreen.SetEnableOfToolbarButton("Approve", false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                    objShipmentsInfo.ICShipmentPostedStatus != PostedTransactionStatus.Posted.ToString());
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                    objShipmentsInfo.ICShipmentPostedStatus == PostedTransactionStatus.Posted.ToString());
            }
            base.InvalidateToolbar();
        }

        public override int ActionSave()
        {
            InvalidateToolbar();
            return base.ActionSave();
        }

        public void DeleteItemFromShipmentItemsList()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                MaterialShipmentConstructionEntities entity = (MaterialShipmentConstructionEntities)CurrentModuleEntity;
                entity.ShipmentItemList.RemoveSelectedRowObjectFromList();
                UpdateDocumentEntries();
            }
        }

        public void ApproveMaterialShipment()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                ActionComplete();
            }
        }
        public override bool ActionComplete()
        {
            MaterialShipmentConstructionEntities entity = (MaterialShipmentConstructionEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();

            entity.ShipmentItemList.EndCurrentEdit();
            foreach (ICShipmentItemsInfo objShipmentItemsInfo in entity.ShipmentItemList)
            {
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objShipmentItemsInfo.FK_ICProductID);
                if (objProductsInfo.ICProductType != ProductType.Service.ToString()
                    && !objProductsInfo.IsAsset
                    && objProductsInfo.ICPriceCalculationMethodMethod != PriceCalculationMethod.Average.ToString())
                {
                    if (objShipmentItemsInfo.FK_ICProductSerieID == 0)
                    {
                        MessageBox.Show(string.Format(ShipmentLocalizedResources.ItemSerieNoIsRequiredMessage, objShipmentItemsInfo.ICShipmentItemProductDesc), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            if (entity.ShipmentItemList.BackupList != null && entity.ShipmentItemList.BackupList.Count > 0)
            {
                entity.ShipmentItemList.BackupList.Clear();
            }
            if (entity.ShipmentItemList.IsInvalidInventory(TransactionUtil.cstInventoryShipment))
            {
                return false;
            }
            return base.ActionComplete();
        }

        #region ActionNew
        public override void ActionNew()
        {
            base.ActionNew();
            MaterialShipmentConstructionEntities entity = (MaterialShipmentConstructionEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentsInfo.ICShipmentShipmentType = ShipmentShipmentType.Other.ToString();
            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
            objShipmentItemsInfo.ICShipmentType = ShipmentType.MaterialShipmentConstruction.ToString();
        }

        public void ActionNewFromManual()
        {
            ActionNew();
        }

        public void ActionNewFromTranferConstruction()
        {
            ActionNew();
            MaterialShipmentConstructionEntities entity = (MaterialShipmentConstructionEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;

            ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
            List<ICTransferItemsInfo> transferItemsList = objTransferItemsController.GetTransferItemsFormShipmentConstruction();
            guiAddTransferItem guiFind = new guiAddTransferItem(transferItemsList);
            guiFind.Module = this;
            guiFind.ShowDialog();
            if (guiFind.DialogResult != DialogResult.OK)
            {
                base.ActionCancel();
                return;
            }
            transferItemsList = (List<ICTransferItemsInfo>)guiFind.SelectedObjects;
            if (transferItemsList.Count == 0)
                return;
            ICTransferItemsInfo objTransferItemsInfo = guiFind.SelectedObjects[0];
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(objTransferItemsInfo.FK_ARSaleOrderID);
            if (objSaleOrdersInfo != null)
            {
                objShipmentsInfo.ICShipmentPONo = objSaleOrdersInfo.ARSaleOrderNo;
                objShipmentsInfo.FK_ACObjectID = objSaleOrdersInfo.FK_ACObjectID;
                objShipmentsInfo.ICObjectType = objSaleOrdersInfo.ARObjectType;
                objShipmentsInfo.ACObjectAccessKey = objShipmentsInfo.FK_ACObjectID + ";" + objShipmentsInfo.ICObjectType;
            }

            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            transferItemsList.ForEach(o =>
            {
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(o.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    o.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                    o.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                }
                objShipmentItemsInfo = ToShipmentItemInfo(o);
                entity.ShipmentItemList.Add(objShipmentItemsInfo);
            });
            entity.ShipmentItemList.GridControl.RefreshDataSource();
            UpdateTotalAmount();
        }

        private ICShipmentItemsInfo ToShipmentItemInfo(ICTransferItemsInfo objTransferItemsInfo)
        {
            return new ICShipmentItemsInfo()
            {
                FK_ARSaleOrderID = objTransferItemsInfo.FK_ARSaleOrderID,
                FK_ARSaleOrderItemWorkID = objTransferItemsInfo.FK_ARSaleOrderItemWorkID,
                FK_ICMeasureUnitID = objTransferItemsInfo.FK_ICMeasureUnitID,
                FK_ICDepartmentID = objTransferItemsInfo.FK_ICDepartmentID,
                FK_ICModelID = objTransferItemsInfo.FK_ICModelID,
                FK_ICProductID = objTransferItemsInfo.FK_ICProductID,
                FK_ICProductGroupID = objTransferItemsInfo.FK_ICProductGroupID,
                FK_ICProductSerieID = objTransferItemsInfo.FK_ICProductSerieID,
                ICShipmentItemProductName = objTransferItemsInfo.ICTransferItemProductName,
                ICShipmentItemProductDesc = objTransferItemsInfo.ICTransferItemProductDesc,
                ICShipmentItemProductQty = objTransferItemsInfo.ICTransferItemProductQty,
                ICShipmentItemProductUnitPrice = objTransferItemsInfo.ICTransferItemProductUnitPrice,
                ICShipmentItemProductUnitCost = objTransferItemsInfo.ICTransferItemProductUnitCost,
                FK_ICTransferID = objTransferItemsInfo.FK_ICTransferID,
                FK_ICTransferItemID = objTransferItemsInfo.ICTransferItemID,
                FK_ICStockID = objTransferItemsInfo.FK_ICToStockID,
                ICShipmentItemProductSerialNo = objTransferItemsInfo.ICTransferItemProductSerialNo,
                FK_ACAccountID = objTransferItemsInfo.FK_ACAccountID,
            };
        }

        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                MaterialShipmentConstructionEntities entity = (MaterialShipmentConstructionEntities)CurrentModuleEntity;
                entity.UpdateTotalAmount();
                UpdateDocumentEntries();
            }
        }
        #endregion
        public void ReadOnlyControl(bool check)
        {
            IShipmentShipmentType.Properties.ReadOnly = check;
        }

        public void ChangeOperation(int operation)
        {
            MaterialShipmentConstructionEntities entity = (MaterialShipmentConstructionEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentsInfo.FK_MMOperationID = operation;
            UpdateDocumentEntries();
        }

        public void ChangeDepartment(int department)
        {
            MaterialShipmentConstructionEntities entity = (MaterialShipmentConstructionEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentsInfo.FK_HRDepartmentID = department;
            UpdateDocumentEntries();
        }

        #region Accounting
        protected override void UpdateDocumentEntries()
        {
            MaterialShipmentConstructionEntities entity = (MaterialShipmentConstructionEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            ACAccountsInfo objACAccountsInfo = new ACAccountsInfo();
            ACAccountsController objAccountsController = new ACAccountsController();

            ICImportAndExportReasonsController objIAERController = new ICImportAndExportReasonsController();
            ICImportAndExportReasonsInfo objIAERInfo = null;
            int accountDebit = 0;
            if (objShipmentsInfo.FK_ICImportAndExportReasonID > 0)
            {
                objIAERInfo = objIAERController.GetObjectByID(objShipmentsInfo.FK_ICImportAndExportReasonID) as ICImportAndExportReasonsInfo;
                if (objIAERInfo != null)
                    accountDebit = objIAERInfo.FK_ACAcountID;
            }

            ICStocksController objStockController = new ICStocksController();
            ICStocksInfo objStockInfo = (ICStocksInfo)objStockController.GetObjectByID(objShipmentsInfo.FK_ICStockID);
            int accountStockID = 0;

            if (objStockInfo != null)
            {
                accountStockID = objStockInfo.FK_ACAccountID;
            }
            ICProductsController productController = new ICProductsController();
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();

            string documentType = AccDocumentType.XuatKhoVatTu.ToString();
            string entryType = AccEntryType.XuatKhoVatTu.ToString();

            ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        documentType,
                                                                        entryType);
            Dictionary<ACDocumentEntrysInfo, List<ICShipmentItemsInfo>> documentEntryAccounts = new Dictionary<ACDocumentEntrysInfo, List<ICShipmentItemsInfo>>();
            List<int> productAccountID = new List<int>();
            if (entity.ShipmentItemList != null)
            {
                ACDocumentEntrysInfo entry = new ACDocumentEntrysInfo();
                List<ACDocumentEntrysInfo> removedDocuments = entity.DocumentEntryList.Where(item => item.ACEntryTypeName == entryType).ToList();
                if (removedDocuments != null)
                {
                    foreach (ACDocumentEntrysInfo item in removedDocuments)
                        entity.DocumentEntryList.Remove(item);
                }


                int accountCompareID = 0;

                foreach (ICShipmentItemsInfo shipmentItem in entity.ShipmentItemList)
                {
                    ICProductsInfo objProductInfo = (ICProductsInfo)productController.GetObjectByID(shipmentItem.FK_ICProductID);
                    int accountProduct = 0;
                    accountProduct = objProductInfo.FK_ACAccountCostPriceID;

                    if (accountStockID > 0)
                    {
                        accountCompareID = accountStockID;
                    }
                    else
                    {
                        accountCompareID = shipmentItem.FK_ACAccountID;
                    }
                    entry = entity.DocumentEntryList.FirstOrDefault(e => e.ACEntryTypeName == entryType
                                                                        && e.FK_ACDebitAccountID == accountDebit
                                                                       && e.FK_ACCreditAccountID == accountCompareID);
                    {
                        if (entry == null && defaultEntry != null)
                        {
                            entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, entity.DocumentEntryList);
                            entry.FK_ACCreditAccountID = accountCompareID;
                            if (accountDebit > 0)
                                entry.FK_ACDebitAccountID = accountDebit;
                        }
                        if (entry != null && !documentEntryAccounts.ContainsKey(entry))
                        {
                            documentEntryAccounts.Add(entry, new List<ICShipmentItemsInfo>());
                            if (accountDebit > 0)
                                entry.FK_ACDebitAccountID = accountDebit;
                            productAccountID.Add(entry.FK_ACCreditAccountID);
                        }
                        documentEntryAccounts[entry].Add(shipmentItem);
                    }
                }
            }

            if (documentEntryAccounts.Count != 0)
            {
                ACDocumentEntrysInfo item = null;
                foreach (ACDocumentEntrysInfo entry in documentEntryAccounts.Keys)
                {
                    entry.ACDocumentEntryAmount = documentEntryAccounts[entry].Sum(i => i.ICShipmentItemProductUnitCost * i.ICShipmentItemProductQty);
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

            List<ACDocumentEntrysInfo> removedItems = entity.DocumentEntryList.Where(item => item.ACEntryTypeName == entryType
                                                                              && !productAccountID.Any(accountID => accountID == item.FK_ACCreditAccountID)).ToList();
            if (removedItems != null)
            {
                foreach (ACDocumentEntrysInfo item in removedItems)
                    entity.DocumentEntryList.Remove(item);
            }
            entity.DocumentEntryList.GridControl.RefreshDataSource();
        }
        #endregion

        public void ChangeItemSerieNo(ICShipmentItemsInfo item, int listIndex)
        {
            MaterialShipmentConstructionEntities entity = (MaterialShipmentConstructionEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)entity.MainObject;
            item.ICShipmentItemProductUnitCost = AccountHelper.GetInventoryCost(item.FK_ICStockID, item.FK_ICProductID, item.ICShipmentItemProductSerialNo, objShipmentInfo.ICShipmentDate);
            ICProductSeriesController productSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo objProductSeriesInfo = (ICProductSeriesInfo)productSeriesController.GetObjectByID(item.FK_ICProductSerieID);
            if (objProductSeriesInfo != null)
            {
                item.FK_ICModelID = objProductSeriesInfo.FK_ICModelID;
                item.FK_ICModelDetailID = objProductSeriesInfo.FK_ICModelDetailID;
            }
            GeneralAccountInShipmentItemByStock(item);
            entity.SetProductPriceByProductUnitPrice(item);
            entity.ShipmentItemList.GridControl.RefreshDataSource();
            UpdateTotalAmount();
            UpdateDocumentEntries();
        }

        public void ChangeStock(int stockID)
        {
            MaterialShipmentConstructionEntities entity = (MaterialShipmentConstructionEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentInfo.FK_ICStockID = stockID;
            if (Toolbar.IsNullOrNoneAction())
                return;

            if (entity.ShipmentItemList.Count > 0)
            {
                foreach (ICShipmentItemsInfo item in entity.ShipmentItemList)
                {
                    item.FK_ICStockID = stockID;
                    item.ICShipmentItemProductSerialNo = string.Empty;
                    item.ICShipmentItemLotNo = string.Empty;
                    GeneralAccountInShipmentItemByStock(item);
                }
                UpdateDocumentEntries();
                entity.ShipmentItemList.GridControl.RefreshDataSource();
            }
        }

        public void GeneralAccountInShipmentItemByStock(ICShipmentItemsInfo item)
        {
            int accoutTemp = 0;
            if (item.FK_ICStockID > 0)
            {
                item.FK_ACAccountID = GetAccountByStock(item.FK_ICStockID, item.FK_ACAccountID);
            }
        }

        public void ResetProductSerialNo(ICShipmentItemsInfo item)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
            if (objProductsInfo != null && objProductsInfo.ICProductType == ProductType.IngredientPackaging.ToString())
            {
                item.FK_ICProductSerieID = 0;
                item.ICShipmentItemProductSerialNo = string.Empty;
                item.ICShipmentItemLotNo = string.Empty;
            }
        }

        public void ChangeImportAndExportReason(int importAndExportReasonID)
        {
            MaterialShipmentConstructionEntities entity = (MaterialShipmentConstructionEntities)CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            objShipmentsInfo.FK_ICImportAndExportReasonID = importAndExportReasonID;
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (entity.ShipmentItemList.Count > 0)
                {
                    entity.ShipmentItemList.ForEach(o => o.FK_ICImportAndExportReasonID = importAndExportReasonID);
                    entity.ShipmentItemList.GridControl.RefreshDataSource();
                }
            }
            UpdateTotalAmount();
        }

        public void ActionPosted()
        {
            if (!CheckLock()) return;
            MaterialShipmentConstructionEntities entity = (MaterialShipmentConstructionEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ICShipmentPostedStatus = PostedTransactionStatus.Posted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ICShipmentID, PostedTransactionStatus.Posted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.PostedTransactions(this.Name, mainObject.ICShipmentID, ModulePostingType.Accounting);
            InvalidateToolbar();
        }

        public void ActionUnPosted()
        {
            if (!CheckLock()) return;
            MaterialShipmentConstructionEntities entity = (MaterialShipmentConstructionEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ICShipmentPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ICShipmentID, PostedTransactionStatus.UnPosted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.UnPostedTransactions(this.Name, mainObject.ICShipmentID, ModulePostingType.Accounting);
            InvalidateToolbar();
        }

        public override void ModuleAfterCompleted()
        {
            MaterialShipmentConstructionEntities entity = (MaterialShipmentConstructionEntities)CurrentModuleEntity;
            ICShipmentsInfo mainObject = (ICShipmentsInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ICShipmentPostedStatus = PostedTransactionStatus.Posted.ToString();
            entity.UpdateMainObject();
            GLHelper.PostedTransactions(this.Name, mainObject.ICShipmentID, ModulePostingType.Accounting);
            entity.SetPropertyChangeEventLock(true);
            base.ModuleAfterCompleted();
        }
    }
    #endregion

}
