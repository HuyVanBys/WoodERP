using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;

namespace BOSERP.Modules.POS
{
    public class POSEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets invoice item list
        /// </summary>
        public BOSItemsEntityList<ARInvoiceItemsInfo> InvoiceItemList { get; set; }

        /// <summary>
        /// Gets or sets the item list including the item's components
        /// </summary>
        public BOSItemsEntityList<ARInvoiceItemsInfo> ComponentInvoiceItemList { get; set; }

        /// <summary>
        /// Gets or sets document payment detail list
        /// </summary>
        public BOSList<ARPOSPaymentDetailsInfo> POSPaymentDetailList { get; set; }

        /// <summary>
        /// Gets or sets the credit note list
        /// </summary>
        public BOSList<ARCreditNotesInfo> CreditNoteList { get; set; }
        #endregion

        #region Constructor
        public POSEntities()
            : base()
        {
            InvoiceItemList = new BOSItemsEntityList<ARInvoiceItemsInfo>();
            POSPaymentDetailList = new BOSList<ARPOSPaymentDetailsInfo>();
            ComponentInvoiceItemList = new BOSItemsEntityList<ARInvoiceItemsInfo>();
            CreditNoteList = new BOSList<ARCreditNotesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ARInvoicesInfo();
            SearchObject = new ARInvoicesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARInvoiceItemsTableName, new ARInvoiceItemsInfo());
            ModuleObjects.Add(TableName.ARCreditNotesTableName, new ARCreditNotesInfo());
        }

        public override void InitModuleObjectList()
        {
            InvoiceItemList.InitBOSList(this,
                                        TableName.ARInvoicesTableName,
                                        TableName.ARInvoiceItemsTableName,
                                        BOSItemsEntityList<ARInvoiceItemsInfo>.cstRelationForeign);

            ComponentInvoiceItemList.InitBOSList(this,
                                                        TableName.ARInvoicesTableName,
                                                        TableName.ARInvoiceItemsTableName,
                                                        BOSItemsEntityList<ARInvoiceItemsInfo>.cstRelationForeign);
            ComponentInvoiceItemList.ItemTableForeignKey = "FK_ARInvoiceID";

            POSPaymentDetailList.InitBOSList(this,
                                             TableName.ARInvoicesTableName,
                                             TableName.ARPOSPaymentDetailsTableName,
                                             BOSList<ARPOSPaymentDetailsInfo>.cstRelationForeign);
        }

        public override void InitGridControlInBOSList()
        {
            InvoiceItemList.InitBOSListGridControl();
            POSPaymentDetailList.InitBOSListGridControl();
            DocumentEntryList.InitBOSListGridControl(POSModule.DocumentEntryGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                InvoiceItemList.SetDefaultListAndRefreshGridControl();
                ComponentInvoiceItemList.SetDefaultListAndRefreshGridControl();
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

            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            objInvoicesInfo.ARInvoiceTypeCombo = InvoiceType.SaleReceipt.ToString();
            objInvoicesInfo.ARInvoiceDate = DateTime.Now;
            //objInvoicesInfo.FK_ARPriceLevelID = 1;
            objInvoicesInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objInvoicesInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objInvoicesInfo.ARInvoiceExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objInvoicesInfo.FK_ARSellerID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            //objInvoicesInfo.ARInvoiceComment = POSLocalizedResources.Paid;
            objInvoicesInfo.ARInvoiceDesc = POSLocalizedResources.SaleReceiptDefaultDesc;
            objInvoicesInfo.ARInvoiceMainSellerCommissionPercent = 100;
            ACEInvoiceTypesController objEInvoiceTypesController = new ACEInvoiceTypesController();
            ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)objEInvoiceTypesController.GetInvoiceTypeNo();
            if (objEInvoiceTypesInfo != null)
            {
                objInvoicesInfo.FK_ACEInvoiceTypeID = objEInvoiceTypesInfo.ACEInvoiceTypeID;
                objInvoicesInfo.ARInvoiceVATFormNo = objEInvoiceTypesInfo.ACEInvoiceTypeTemplateCode;
                objInvoicesInfo.ARInvoiceVATSymbol = objEInvoiceTypesInfo.ACEInvoiceTypeSeries;
            }

            UpdateMainObjectBindingSource();
        }

        #region Invalidate Module Objects Functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            InvoiceItemList.Invalidate(iObjectID);

            //Invalidate item component
            InvalidateItemComponents();

            ComponentInvoiceItemList.BackupList.Clear();
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            if (objInvoicesInfo.ARInvoiceStatus == InvoiceStatus.Complete.ToString() ||
                objInvoicesInfo.ARInvoiceStatus == InvoiceStatus.Paid.ToString())
            {
                foreach (ARInvoiceItemsInfo item in ComponentInvoiceItemList)
                {
                    ComponentInvoiceItemList.BackupList.Add((ARInvoiceItemsInfo)item.Clone());
                }
            }
        }
        #endregion

        #region Save Module Objects Functions
        public override int SaveMainObject()
        {
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            objInvoicesInfo.ARInvoiceValidateDate = objInvoicesInfo.ARInvoiceDate;
            objInvoicesInfo.ARInvoiceDeliveryDate = objInvoicesInfo.ARInvoiceDate;
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            InvoiceItemList.SaveItemObjects();

            //Save invoice item component
            SaveInvoiceItemComponentList(InvoiceItemList);

            SaveAccountingData();
        }

        /// <summary>
        /// Save the component list of the invoice's items
        /// </summary>
        /// <param name="invoiceItemList">List of invoice items</param>
        public void SaveInvoiceItemComponentList(BOSItemsEntityList<ARInvoiceItemsInfo> invoiceItemList)
        {
            ARInvoiceItemComponentsController objInvoiceItemComponentsController = new ARInvoiceItemComponentsController();
            if (invoiceItemList != null)
            {
                foreach (ARInvoiceItemsInfo itemEntity in invoiceItemList)
                {
                    if (itemEntity.InvoiceItemComponentList != null)
                    {
                        foreach (ARInvoiceItemComponentsInfo objInvoiceItemComponentsInfo in itemEntity.InvoiceItemComponentList)
                        {
                            objInvoiceItemComponentsInfo.FK_ARInvoiceItemID = itemEntity.ARInvoiceItemID;
                        }
                        itemEntity.InvoiceItemComponentList.SaveItemObjects();
                    }
                }
            }
        }
        #endregion

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(iICProductID);
            ICProductsInfo objProductsInfo2 = (ICProductsInfo)objProductsController.GetProductWithDiscountByID(iICProductID, objInvoicesInfo.ARInvoiceDate);
            GEVATsController objVatsController = new GEVATsController();
            ICProductCustomersController objProductCustomersController = new ICProductCustomersController();
            if (objProductsInfo != null)
            {
                ARInvoiceItemsInfo objInvoiceItemsInfo = (ARInvoiceItemsInfo)ModuleObjects[TableName.ARInvoiceItemsTableName];
                objInvoiceItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                objInvoiceItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                objInvoiceItemsInfo.ARInvoiceItemProductNoOfOldSys = objProductsInfo.ICProductNoOfOldSys;
                objInvoiceItemsInfo.ARInvoiceItemProductBarCode = objProductsInfo.ICProductBarCode;
                objInvoiceItemsInfo.ARInvoiceItemProductName2 = string.IsNullOrWhiteSpace(objProductsInfo.ICProductName2) ? objProductsInfo.ICProductName : objProductsInfo.ICProductName2;
                ICProductCustomersInfo objProductCustomersInfo = (ICProductCustomersInfo)objProductCustomersController.GetProductCustomerByProductIDAndCustomerID(objInvoiceItemsInfo.FK_ICProductID, objInvoicesInfo.FK_ARCustomerID);
                objInvoiceItemsInfo.ARInvoiceItemProductCustomerNumber = objProductCustomersInfo != null ? objProductCustomersInfo.ICProductCustomerNumber : string.Empty;
                ARCustomersController objCustomersController = new ARCustomersController();
                ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(objInvoicesInfo.FK_ARCustomerID);

                base.SetValuesAfterValidateProduct(objProductsInfo.ICProductID);
                objInvoiceItemsInfo.ICProductUnitPrice = objInvoiceItemsInfo.ICProductUnitPrice <= 0 ? objProductsInfo.ICProductPrice01 : objInvoiceItemsInfo.ICProductUnitPrice;
                objInvoiceItemsInfo.ARInvoiceItemProductUnitPrice = BOSApp.CalculaterProductUnitPrice(objProductsInfo
                                                                                        , objInvoiceItemsInfo.ARInvoiceItemProductUnitPrice
                                                                                        , objInvoiceItemsInfo.ARInvoiceItemProductQty
                                                                                        , objInvoiceItemsInfo.FK_ICMeasureUnitID
                                                                                        , objCustomersInfo != null ? objCustomersInfo.ARCustomerID : 0
                                                                                        , objInvoicesInfo.ARInvoiceDate
                                                                                        , objInvoicesInfo.FK_GECurrencyID);
                objInvoiceItemsInfo.ARInvoiceItemProductTaxPercent = SetDefaultProductTaxPercent(objProductsInfo);
                SetProductPriceByProductUnitPrice();
                objInvoiceItemsInfo.FK_ICStockID = objInvoicesInfo.FK_ICStockID;
                // objInvoiceItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductSaleUnitID;
                //objInvoiceItemsInfo.ICProductUnitPrice = objInvoiceItemsInfo.ARInvoiceItemProductUnitPrice;
                if (objProductsInfo2 != null)
                {
                    objInvoiceItemsInfo.ARInvoiceItemProductUnitPrice = objProductsInfo2.ICProductCriteriaItemUnitPrice;
                    objInvoiceItemsInfo.ARInvoiceItemTotalAmount = objInvoiceItemsInfo.ARInvoiceItemProductUnitPrice * objInvoiceItemsInfo.ARInvoiceItemProductQty;
                    objInvoiceItemsInfo.ARInvoiceItemNetAmount = objInvoiceItemsInfo.ARInvoiceItemProductUnitPrice * objInvoiceItemsInfo.ARInvoiceItemProductQty;
                }

                UpdateModuleObjectBindingSource(TableName.ARInvoiceItemsTableName);
            }
        }

        public override void UpdatePriceLevel(ARCustomersInfo objCustomersInfo)
        {
            //Update price level of sale receipt
            ((ARInvoicesInfo)MainObject).FK_ARPriceLevelID = objCustomersInfo.FK_ARPriceLevelID;
            UpdateMainObjectBindingSource();

            //Update all item price basing on price level
            foreach (ARInvoiceItemsInfo entItem in InvoiceItemList)
                if (entItem.FK_ICProductID > 0)
                    SetProductPrice(entItem, TableName.ARInvoiceItemsTableName);
            InvoiceItemList.GridControl.RefreshDataSource();
            UpdateTotalAmount();
        }

        /// <summary>
        /// Update total amount
        /// </summary>
        public void UpdateTotalAmount()
        {
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            objInvoicesInfo.ARInvoiceNetAmount = 0;
            objInvoicesInfo.ARInvoiceSubTotalAmount = 0;
            foreach (ARInvoiceItemsInfo entItem in InvoiceItemList)
            {
                BOSApp.RoundByCurrency(entItem, objInvoicesInfo.FK_GECurrencyID);
                objInvoicesInfo.ARInvoiceNetAmount += entItem.ARInvoiceItemNetAmount;
                objInvoicesInfo.ARInvoiceSubTotalAmount += entItem.ARInvoiceItemTotalAmount;
            }
            BOSApp.RoundByCurrency(objInvoicesInfo, objInvoicesInfo.FK_GECurrencyID);
            objInvoicesInfo.ARInvoiceDiscountFix = objInvoicesInfo.ARInvoiceSubTotalAmount * objInvoicesInfo.ARInvoiceDiscountPerCent / 100;
            BOSApp.RoundByCurrency(objInvoicesInfo, "ARInvoiceDiscountFix", objInvoicesInfo.FK_GECurrencyID);
            objInvoicesInfo.ARInvoiceTaxAmount = (objInvoicesInfo.ARInvoiceSubTotalAmount - objInvoicesInfo.ARInvoiceDiscountFix) * objInvoicesInfo.ARInvoiceTaxPercent / 100;
            BOSApp.RoundByCurrency(objInvoicesInfo, "ARInvoiceTaxAmount", objInvoicesInfo.FK_GECurrencyID);
            objInvoicesInfo.ARInvoiceTotalAmount = objInvoicesInfo.ARInvoiceSubTotalAmount + objInvoicesInfo.ARInvoiceTaxAmount - objInvoicesInfo.ARInvoiceDiscountFix + objInvoicesInfo.ARInvoiceShippingFees;
            BOSApp.RoundByCurrency(objInvoicesInfo, "ARInvoiceTotalAmount", objInvoicesInfo.FK_GECurrencyID);
            if (objInvoicesInfo.OldObject != null)
            {
                ARInvoicesInfo oldInvoice = (ARInvoicesInfo)objInvoicesInfo.OldObject;
                objInvoicesInfo.ARInvoiceBalanceDue = oldInvoice.ARInvoiceBalanceDue +
                                                       oldInvoice.ARInvoiceDepositBalance - objInvoicesInfo.ARInvoiceDepositBalance +
                                                       objInvoicesInfo.ARInvoiceTotalAmount - oldInvoice.ARInvoiceTotalAmount;
            }
            else
            {
                objInvoicesInfo.ARInvoiceBalanceDue = objInvoicesInfo.ARInvoiceTotalAmount - objInvoicesInfo.ARInvoiceDepositBalance;
            }
            BOSApp.RoundByCurrency(objInvoicesInfo, objInvoicesInfo.FK_GECurrencyID);
            UpdateMainObjectBindingSource();
        }

        public override bool CompleteTransaction()
        {
            //Update POS status
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            if (objInvoicesInfo.ARInvoiceStatus == InvoiceStatus.New.ToString())
            {
                objInvoicesInfo.ARInvoiceStatus = InvoiceStatus.Complete.ToString();
                UpdateMainObject();
            }

            //Set cost of goods sold for invoice items
            if (BOSApp.CurrentCompanyInfo.CSCostMethod == AccCostMethod.SpecificIdentification.ToString())
            {
                ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
                foreach (ARInvoiceItemsInfo item in InvoiceItemList)
                {
                    if (item.ARInvoiceItemExchangeUnitCost == 0 || item.ARInvoiceItemProductUnitCost == 0)
                    {
                        item.ARInvoiceItemExchangeUnitCost = AccountHelper.GetInventoryCost(item.FK_ICStockID, item.FK_ICProductID, item.ARInvoiceItemProductSerialNo, objInvoicesInfo.ARInvoiceDate);
                        item.ARInvoiceItemProductUnitCost = item.ARInvoiceItemExchangeUnitCost * item.ARInvoiceItemProductFactor / (objInvoicesInfo.ARInvoiceExchangeRate > 0 ? objInvoicesInfo.ARInvoiceExchangeRate : 1);
                        SetProductPriceByProductUnitPrice(item);
                        objInvoiceItemsController.UpdateObject(item);
                    }
                }
            }
            //Create a gift voucher in case the sale receipt issues it
            if (InvoiceItemList.Exists(i => i.ARInvoiceItemProductType == CreditNoteType.GiftVoucher.ToString()))
            {
                CreateGiftVoucher();
            }

            //ARSOPaymentTimeInvoiceDetailsController soptidController = new ARSOPaymentTimeInvoiceDetailsController();
            //ARSOPaymentTimeInvoiceDetailsInfo soptid = soptidController.GetDetailBySomeInvoiceID(objInvoicesInfo.ARInvoiceID);
            //if (soptid != null)
            //{
            //    soptid.ARSOPaymentTimeInvoiceDetailRequiredAmount = objInvoicesInfo.ARInvoiceBalanceDue;
            //    soptid.ARSOPaymentTimeInvoiceDetailDepositAmount = objInvoicesInfo.ARInvoiceBalanceDue;
            //    soptidController.UpdateObject(soptid);
            //}
            //else
            //{
            //    soptid = new ARSOPaymentTimeInvoiceDetailsInfo();
            //    soptid.ARSOPaymentTimeInvoiceDetailRequiredAmount = objInvoicesInfo.ARInvoiceBalanceDue;
            //    soptid.ARSOPaymentTimeInvoiceDetailDepositAmount = objInvoicesInfo.ARInvoiceBalanceDue;
            //    soptid.FK_ARInvoiceID = objInvoicesInfo.ARInvoiceID;
            //    soptid.ARSOPaymentTimeInvoiceDetailPaymentType = SaleOrderPaymentTimePaymentType.Payment.ToString();
            //    soptid.ARInvoiceNo = objInvoicesInfo.ARInvoiceNo;
            //    soptid.FK_BRBranchID = objInvoicesInfo.FK_BRBranchID;
            //    soptidController.CreateObject(soptid);
            //}

            return true;
        }

        /// <summary>
        /// Create a gift voucher
        /// </summary>
        private void CreateGiftVoucher()
        {
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            ARCreditNotesController objCreditNotesController = new ARCreditNotesController();
            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
            foreach (ARInvoiceItemsInfo objInvoiceItemsInfo in InvoiceItemList)
            {
                if (objInvoiceItemsInfo.ARInvoiceItemProductType == CreditNoteType.GiftVoucher.ToString())
                {
                    if (string.IsNullOrEmpty(objInvoiceItemsInfo.ARInvoiceItemReference))
                    {
                        ARCreditNotesInfo objCreditNotesInfo = (ARCreditNotesInfo)ModuleObjects[TableName.ARCreditNotesTableName];
                        if (objCreditNotesInfo.ARCreditNoteNo == cstNewObjectText)
                        {
                            objCreditNotesInfo.ARCreditNoteNo = BOSApp.GetMainObjectNo(ModuleName.CreditNote, objCreditNotesInfo);
                            BOSApp.UpdateObjectNumbering(ModuleName.CreditNote);
                        }

                        objCreditNotesInfo.AACreatedUser = BOSApp.CurrentUser;
                        objCreditNotesInfo.AACreatedDate = DateTime.Now;
                        objCreditNotesInfo.ARCreditNoteDate = objInvoicesInfo.ARInvoiceDate;
                        objCreditNotesInfo.ARCreditNoteType = CreditNoteType.GiftVoucher.ToString();
                        objCreditNotesController.CreateObject(objCreditNotesInfo);

                        //Update item desc
                        objInvoiceItemsInfo.ARInvoiceItemProductDesc = String.Format("{0} {1}", POSLocalizedResources.GiftVoucher, objCreditNotesInfo.ARCreditNoteNo);
                        objInvoiceItemsInfo.ARInvoiceItemReference = objCreditNotesInfo.ARCreditNoteNo;
                        objInvoiceItemsController.UpdateObject(objInvoiceItemsInfo);
                        InvoiceItemList.GridControl.RefreshDataSource();
                    }
                    else
                    {
                        ARCreditNotesInfo objCreditNotesInfo = (ARCreditNotesInfo)objCreditNotesController.GetObjectByNo(objInvoiceItemsInfo.ARInvoiceItemReference);
                        if (objCreditNotesInfo != null)
                        {
                            objCreditNotesInfo.ARCreditNoteTotalAmount = objInvoiceItemsInfo.ARInvoiceItemTotalAmount;
                            objCreditNotesController.UpdateObject(objCreditNotesInfo);
                        }
                    }
                }
            }
        }

        public override bool IsInvalidInventory()
        {
            return ComponentInvoiceItemList.IsInvalidInventory(TransactionUtil.cstInventoryShipment);
        }

        /// <summary>
        /// Invalidate item components of the invoice items
        /// </summary>
        public void InvalidateItemComponents()
        {
            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            List<ARInvoiceItemsInfo> items = objInvoiceItemsController.GetComponentItemsByInvoiceID(objInvoicesInfo.ARInvoiceID);
            ComponentInvoiceItemList.Clear();
            ComponentInvoiceItemList.OriginalList.Clear();
            foreach (ARInvoiceItemsInfo item in items)
            {
                ComponentInvoiceItemList.Add((ARInvoiceItemsInfo)item.Clone());
            }

            foreach (ARInvoiceItemsInfo item in ComponentInvoiceItemList)
            {
                ComponentInvoiceItemList.OriginalList.Add((ARInvoiceItemsInfo)item.Clone());
            }
        }

        #region Accounting
        /// <summary>
        /// Save the shipment entries of the invoice
        /// </summary>
        /// <param name="objShipmentsInfo">Associating shipment of the invoice</param>
        private void SaveShipmentEntries(ICShipmentsInfo objShipmentsInfo)
        {
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            ICProductsController productController = new ICProductsController();
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        AccDocumentType.XuatKhoBanHang.ToString(),
                                                                        AccEntryType.XuatKhoBanHang.ToString());
            Dictionary<ACDocumentEntrysInfo, List<ARInvoiceItemsInfo>> documentEntryAccounts = new Dictionary<ACDocumentEntrysInfo, List<ARInvoiceItemsInfo>>();
            List<int> productAccountID = new List<int>();
            ICStocksController objStockController = new ICStocksController();
            ACAccountsController objAccountsController = new ACAccountsController();

            if (ComponentInvoiceItemList != null)
            {
                foreach (ARInvoiceItemsInfo invoiceItem in ComponentInvoiceItemList)
                {
                    ICStocksInfo objStockInfo = (ICStocksInfo)objStockController.GetObjectByID(invoiceItem.FK_ICStockID);

                    ICProductsInfo product = productController.GetObjectByID(invoiceItem.FK_ICProductID) as ICProductsInfo;
                    ACDocumentEntrysInfo entry = DocumentEntryList.FirstOrDefault(e => e.ACEntryTypeName == AccEntryType.XuatKhoBanHang.ToString()
                                                                        && e.FK_ACCreditAccountID == product.FK_ACAccountID);
                    if (entry == null && defaultEntry != null)
                    {
                        entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, DocumentEntryList);
                        entry.FK_ACCreditAccountID = product.FK_ACAccountID;
                        if (objStockInfo != null)
                        {
                            if (objStockInfo.FK_ACAccountID != 0)
                            {
                                entry.FK_ACCreditAccountID = objStockInfo.FK_ACAccountID;
                            }
                            else
                            {
                                if (product != null && product.FK_ACAccountID != 0)
                                    entry.FK_ACCreditAccountID = product.FK_ACAccountID;
                            }
                        }
                        if (product != null && product.FK_ACAccountCostPriceID != 0)
                        {
                            entry.FK_ACDebitAccountID = product.FK_ACAccountCostPriceID;
                        }
                        else
                        {
                            entry.FK_ACDebitAccountID = ((ACAccountsInfo)objAccountsController.GetObjectByNo(AccAccount.Acc632)).ACAccountID;
                        }

                    }
                    if (entry != null && !documentEntryAccounts.ContainsKey(entry))
                    {
                        documentEntryAccounts.Add(entry, new List<ARInvoiceItemsInfo>());
                        productAccountID.Add(entry.FK_ACCreditAccountID);
                    }
                    documentEntryAccounts[entry].Add(invoiceItem);
                }
            }

            if (documentEntryAccounts.Count != 0)
            {
                ACDocumentEntrysInfo item = null;
                foreach (ACDocumentEntrysInfo entry in documentEntryAccounts.Keys)
                {
                    entry.ACDocumentEntryAmount = documentEntryAccounts[entry].Sum(i => i.ARInvoiceItemProductUnitCost * i.ARInvoiceItemProductQty);
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objShipmentsInfo.ICShipmentExchangeRate;
                    item = entry;
                }


                ACDocumentsInfo objDocumentsInfo = DocumentList.Where(d => d.ACDocumentTypeName == AccDocumentType.XuatKhoBanHang.ToString()).FirstOrDefault();
                if (objDocumentsInfo == null)
                {
                    objDocumentsInfo = new ACDocumentsInfo();
                    objDocumentsInfo.FK_ACDocumentTypeID = item.FK_ACDocumentTypeID;
                    objDocumentsInfo.ACDocumentTypeName = item.ACDocumentTypeName;
                    DocumentList.Add(objDocumentsInfo);
                }
            }

            List<ACDocumentEntrysInfo> removedItems = DocumentEntryList.Where(item => item.ACEntryTypeName == AccEntryType.XuatKhoBanHang.ToString()
                                                                              && !productAccountID.Any(accountID => accountID == item.FK_ACCreditAccountID)).ToList();
            if (removedItems != null)
            {
                foreach (ACDocumentEntrysInfo item in removedItems)
                    DocumentEntryList.Remove(item);
            }
            SaveAccountingData();

            //ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            //ACDocumentEntrysInfo entry = DocumentEntryList.Where(e => e.ACEntryTypeName == AccEntryType.XuatKhoBanHang.ToString()).FirstOrDefault();
            //if (entry == null)
            //{
            //    ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            //    ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
            //                                                            AccDocumentType.XuatKhoBanHang.ToString(),
            //                                                            AccEntryType.XuatKhoBanHang.ToString());
            //    if (defaultEntry != null)
            //    {
            //        entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, DocumentEntryList);
            //    }
            //}

            //if (entry != null)
            //{
            //    entry.ACDocumentEntryAmount = ComponentInvoiceItemList.Sum(i => i.ARInvoiceItemProductUnitCost * i.ARInvoiceItemProductQty);
            //    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objShipmentsInfo.ICShipmentExchangeRate;
            //}

            //ACDocumentsInfo objDocumentsInfo = DocumentList.Where(d => d.ACDocumentTypeName == AccDocumentType.XuatKhoBanHang.ToString()).FirstOrDefault();
            //if (objDocumentsInfo == null)
            //{
            //    objDocumentsInfo = new ACDocumentsInfo();
            //    objDocumentsInfo.FK_ACDocumentTypeID = entry.FK_ACDocumentTypeID;
            //    objDocumentsInfo.ACDocumentTypeName = entry.ACDocumentTypeName;
            //    DocumentList.Add(objDocumentsInfo);
            //}

            //SaveAccountingData();

            //ACAccountsController objAccountsController = new ACAccountsController();
            //ACAccountsInfo objDefaultAccount = (ACAccountsInfo)objAccountsController.GetObjectByNo(AccountDefault.DefaultAccount.ToString());
            //List<int> productAccountIDs = new List<int>();
            //foreach (var item in DocumentEntryList)
            //{
            //    if (item.FK_ACCreditAccountID == objDefaultAccount.ACAccountID || 
            //        item.FK_ACDebitAccountID == objDefaultAccount.ACAccountID)
            //    {
            //        item.ACDocumentEntryAmount = 0;
            //        item.ACDocumentEntryExchangeAmount = 0;
            //    }
            //}
            //foreach (var item in ComponentInvoiceItemList)
            //{
            //    ICProductsController obj = new ICProductsController();
            //    ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(item.FK_ICProductID);
            //    if (objProductsInfo != null)
            //    {
            //        productAccountIDs.Add(objProductsInfo.FK_ACAccountID);
            //        ((POSModule)Module).UpdateDocumentEntryList(objProductsInfo.FK_ACAccountID, item.ARInvoiceItemProductUnitCost * item.ARInvoiceItemProductQty, this, objShipmentsInfo.ICShipmentExchangeRate);
            //    }
            //}

            //List<ACDocumentEntrysInfo> deletedItems = DocumentEntryList.Where(item => item.ACEntryTypeName == AccEntryType.XuatKhoBanHang.ToString() &&
            //                                            !productAccountIDs.Any(accountID => item.FK_ACCreditAccountID == accountID ||
            //                                                item.FK_ACDebitAccountID == accountID)).ToList();
            //if (deletedItems != null && deletedItems.Any())
            //{
            //    deletedItems.ForEach(item =>
            //    {
            //        DocumentEntryList.Remove(item);
            //    });
            //}

            //DocumentEntryList.SaveItemObjects();
            DocumentEntryList.GridControl.RefreshDataSource();
        }

        /// <summary>
        /// Save entries of a payment
        /// </summary>        
        /// <param name="customerPayment">Payment object</param>
        /// <returns>No of the payment</returns>
        private string SavePaymentEntries(ARCustomerPaymentsInfo customerPayment)
        {
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByIDAndType(objInvoicesInfo.FK_ACObjectID, objInvoicesInfo.ARObjectType);
            ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
            CSCashFundsController objCashFundsController = new CSCashFundsController();
            string oldReceiptVoucherNo = string.Empty;
            string oldBankTransferNo = string.Empty;
            //Delete all payment data first
            if (!string.IsNullOrEmpty(customerPayment.ARCustomerPaymentNo))
            {
                ARReceiptVouchersController objReceiptVouchersController = new ARReceiptVouchersController();
                ARReceiptVouchersInfo receiptVoucher = objReceiptVouchersController.GetReceiptVoucherByReference(customerPayment.ARCustomerPaymentNo);
                if (receiptVoucher != null)
                {
                    oldReceiptVoucherNo = receiptVoucher.ARReceiptVoucherNo;
                }

                ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
                ACBankTransactionsInfo bankTransfer = objBankTransactionsController.GetBankTransactionByReference(customerPayment.ARCustomerPaymentNo);
                if (bankTransfer != null)
                {
                    oldBankTransferNo = bankTransfer.ACBankTransactionNo;
                }
                objCustomerPaymentsController.DeletePaymentEntriesByNo(customerPayment.ARCustomerPaymentNo);
            }

            //Remove existing payment entries
            for (int i = 0; i < DocumentEntryList.Count; i++)
            {
                if (DocumentEntryList[i].ACEntryTypeName == AccEntryType.ThuTienKhachHang.ToString() ||
                    DocumentEntryList[i].ACEntryTypeName == AccEntryType.ThuPhieuGhiCo.ToString() ||
                    DocumentEntryList[i].ACEntryTypeName == AccEntryType.ThuTheTinDung.ToString())
                {
                    DocumentEntryList.RemoveAt(i);
                    i--;
                }
            }

            //Add new payment entries                       
            decimal cashAmount = POSPaymentDetailList.Where(pd => pd.ARPOSPaymentMethodCombo == PaymentMethod.Cash.ToString()).Sum(pd => pd.ARPOSPaymentDetailAmount);
            if (cashAmount > 0)
            {
                int currencyID = customerPayment.FK_GECurrencyID;
                decimal exchangeRate = customerPayment.ARCustomerPaymentExchangeRate;
                int debitAccountID = 0;
                ARPOSPaymentDetailsInfo cashDetail = POSPaymentDetailList.Where(d => d.ARPOSPaymentMethodCombo == PaymentMethod.Cash.ToString()).FirstOrDefault();
                if (cashDetail != null)
                {
                    ARCustomerPaymentCurrencysInfo paymentByCurrency = null;
                    if (cashDetail.PaymentCurrencys != null)
                    {
                        paymentByCurrency = cashDetail.PaymentCurrencys.Where(p => p.ARCustomerPaymentCurrencyAmount > 0).FirstOrDefault();
                    }
                    if (paymentByCurrency != null)
                    {
                        currencyID = paymentByCurrency.FK_GECurrencyID;
                        exchangeRate = paymentByCurrency.ARCustomerPaymentCurrencyExchangeRate;
                        cashAmount = paymentByCurrency.ARCustomerPaymentCurrencyAmount;
                    }
                    CSCashFundsInfo objCashFundsInfo1 = (CSCashFundsInfo)objCashFundsController.GetObjectByID(cashDetail.FK_CSCashFundID);
                    if (objCashFundsInfo1 != null)
                    {
                        debitAccountID = objCashFundsInfo1.FK_ACAcountID;
                    }
                }

                ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        AccDocumentType.PhieuThu.ToString(),
                                                                        AccEntryType.ThuTienKhachHang.ToString());
                if (defaultEntry != null)
                {
                    ACDocumentEntrysInfo entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, DocumentEntryList);
                    entry.FK_GECurrencyID = currencyID;
                    entry.ACDocumentExchangeRate = exchangeRate;
                    entry.ACDocumentEntryAmount = cashAmount;
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * exchangeRate;
                    entry.FK_ACDebitAccountID = debitAccountID;
                    ARReceiptVouchersInfo receiptVoucher = CreateReceiptVoucher(customerPayment, oldReceiptVoucherNo, cashAmount, currencyID, exchangeRate, debitAccountID);
                    if (receiptVoucher != null)
                    {
                        entry.ACDocumentNo = receiptVoucher.ARReceiptVoucherNo;
                    }
                }
            }

            decimal bankTransferAmount = POSPaymentDetailList.Where(pd => pd.ARPOSPaymentMethodCombo == PaymentMethod.BankTransfer.ToString()).Sum(pd => pd.ARPOSPaymentDetailAmount);
            if (bankTransferAmount > 0)
            {
                int currencyID = customerPayment.FK_GECurrencyID;
                decimal exchangeRate = customerPayment.ARCustomerPaymentExchangeRate;
                int debitAccountID = 0;
                ARPOSPaymentDetailsInfo bankTransferDetail = POSPaymentDetailList.Where(d => d.ARPOSPaymentMethodCombo == PaymentMethod.BankTransfer.ToString()).FirstOrDefault();
                if (bankTransferDetail != null)
                {
                    CSCompanyBanksController objBanksController = new CSCompanyBanksController();
                    CSCompanyBanksInfo objBanksInfo = (CSCompanyBanksInfo)objBanksController.GetObjectByID(bankTransferDetail.FK_CSCompanyBankID);
                    if (objBanksInfo != null)
                    {
                        debitAccountID = objBanksInfo.FK_ACAcountID;
                    }
                    ARCustomerPaymentCurrencysInfo paymentByCurrency = null;
                    if (bankTransferDetail.PaymentCurrencys != null)
                    {
                        paymentByCurrency = bankTransferDetail.PaymentCurrencys.Where(p => p.ARCustomerPaymentCurrencyAmount > 0).FirstOrDefault();
                    }
                    if (paymentByCurrency != null)
                    {
                        currencyID = paymentByCurrency.FK_GECurrencyID;
                        exchangeRate = paymentByCurrency.ARCustomerPaymentCurrencyExchangeRate;
                        bankTransferAmount = paymentByCurrency.ARCustomerPaymentCurrencyAmount;
                    }
                }
                ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        AccDocumentType.NopTienVaoTaiKhoan.ToString(),
                                                                        AccEntryType.ThuTienKhachHang.ToString());
                if (defaultEntry != null)
                {
                    //Hieunt[Lấy tài khoản nợ theo cấu hình][START]
                    if (bankTransferDetail != null && bankTransferDetail.FK_CSCompanyBankID != 0)
                    {
                        CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
                        CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(bankTransferDetail.FK_CSCompanyBankID);
                        if (objCompanyBanksInfo != null && objCompanyBanksInfo.FK_ACAcountID != 0)
                        {
                            ACAccountsController objAccountsController = new ACAccountsController();
                            ACAccountsInfo objAccountsInfo = (ACAccountsInfo)objAccountsController.GetAccountByID(objCompanyBanksInfo.FK_ACAcountID);
                            if (objAccountsInfo != null)
                            {
                                defaultEntry.DefaultDebitAccountNo = objAccountsInfo.ACAccountNo;
                                defaultEntry.ACDocTypeEntryAccountDefaultDebit = objAccountsInfo.ACAccountID;
                            }
                        }
                    }
                    //Hieunt[Lấy tài khoản nợ theo cấu hình][END]
                    ACDocumentEntrysInfo entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, DocumentEntryList);
                    entry.FK_GECurrencyID = currencyID;
                    entry.ACDocumentExchangeRate = exchangeRate;
                    entry.ACDocumentEntryAmount = bankTransferAmount;
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * exchangeRate;
                    if (debitAccountID != 0)
                    {
                        entry.FK_ACDebitAccountID = debitAccountID;
                    }
                    ACBankTransactionsInfo bankTransfer = CreateBankTransfer(customerPayment, oldBankTransferNo, bankTransferAmount, currencyID, exchangeRate);
                    if (bankTransfer != null)
                    {
                        entry.ACDocumentNo = bankTransfer.ACBankTransactionNo;
                    }
                }
            }

            decimal creditCardAmount = POSPaymentDetailList.Where(pd => pd.ARPOSPaymentMethodCombo == PaymentMethod.CreditCard.ToString()).Sum(pd => pd.ARPOSPaymentDetailAmount);
            if (creditCardAmount > 0)
            {
                int currencyID = customerPayment.FK_GECurrencyID;
                decimal exchangeRate = customerPayment.ARCustomerPaymentExchangeRate;
                int debitAccountID = 0;
                ARPOSPaymentDetailsInfo creditCardDetail = POSPaymentDetailList.Where(d => d.ARPOSPaymentMethodCombo == PaymentMethod.CreditCard.ToString()).FirstOrDefault();
                if (creditCardDetail != null)
                {
                    CSCompanyBanksController objBanksController = new CSCompanyBanksController();
                    CSCompanyBanksInfo objBanksInfo = (CSCompanyBanksInfo)objBanksController.GetObjectByID(creditCardDetail.FK_CSCompanyBankID);
                    if (objBanksInfo != null)
                    {
                        debitAccountID = objBanksInfo.FK_ACAcountID;
                    }
                    ARCustomerPaymentCurrencysInfo paymentByCurrency = null;
                    if (creditCardDetail.PaymentCurrencys != null)
                    {
                        paymentByCurrency = creditCardDetail.PaymentCurrencys.Where(p => p.ARCustomerPaymentCurrencyAmount > 0).FirstOrDefault();
                    }
                    if (paymentByCurrency != null)
                    {
                        currencyID = paymentByCurrency.FK_GECurrencyID;
                        exchangeRate = paymentByCurrency.ARCustomerPaymentCurrencyExchangeRate;
                        creditCardAmount = paymentByCurrency.ARCustomerPaymentCurrencyAmount;
                    }
                }

                ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        AccDocumentType.NghiepVuKhac.ToString(),
                                                                        AccEntryType.ThuTheTinDung.ToString());
                if (defaultEntry != null)
                {
                    ACDocumentEntrysInfo entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, DocumentEntryList);
                    entry.FK_GECurrencyID = currencyID;
                    entry.ACDocumentExchangeRate = exchangeRate;
                    entry.ACDocumentEntryAmount = creditCardAmount;
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * exchangeRate;
                    entry.ACDocumentNo = BOSApp.GetMainObjectNo(ModuleName.Document, new ACDocumentsInfo());
                    if (debitAccountID != 0)
                    {
                        entry.FK_ACDebitAccountID = debitAccountID;
                    }
                    BOSApp.UpdateObjectNumbering(ModuleName.Document);
                }
            }

            decimal giftVoucherAmount = POSPaymentDetailList.Where(pd => pd.ARPOSPaymentMethodCombo == PaymentMethod.GiftVoucher.ToString()).Sum(pd => pd.ARPOSPaymentDetailAmount);
            if (giftVoucherAmount > 0)
            {
                ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        AccDocumentType.NghiepVuKhac.ToString(),
                                                                        AccEntryType.ThuPhieuGhiCo.ToString());
                if (defaultEntry != null)
                {
                    ACDocumentEntrysInfo entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, DocumentEntryList);
                    entry.ACDocumentNo = BOSApp.GetMainObjectNo(ModuleName.Document, new ACDocumentsInfo());
                    BOSApp.UpdateObjectNumbering(ModuleName.Document);
                    entry.ACDocumentEntryAmount = giftVoucherAmount;
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * customerPayment.ARCustomerPaymentExchangeRate;
                    if (objObjectsInfo != null && objObjectsInfo.FK_ACAccountSaleID > 0)
                        entry.FK_ACCreditAccountID = objObjectsInfo.FK_ACAccountSaleID;
                }
            }

            decimal owingExchangeAmount = POSPaymentDetailList.Where(pd => pd.ARPOSPaymentMethodCombo == PaymentMethod.OwingExchange.ToString()).Sum(pd => pd.ARPOSPaymentDetailAmount);
            if (owingExchangeAmount > 0)
            {
                ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
                ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                        AccDocumentType.NghiepVuKhac.ToString(),
                                                                        AccEntryType.ThuCocBangPhieuGhiCo.ToString());
                if (defaultEntry != null)
                {
                    ACDocumentEntrysInfo entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, DocumentEntryList);
                    entry.ACDocumentNo = BOSApp.GetMainObjectNo(ModuleName.Document, new ACDocumentsInfo());
                    BOSApp.UpdateObjectNumbering(ModuleName.Document);
                    entry.ACDocumentEntryAmount = owingExchangeAmount;
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * customerPayment.ARCustomerPaymentExchangeRate;
                    if (objObjectsInfo != null && objObjectsInfo.FK_ACAccountSaleID > 0)
                        entry.FK_ACCreditAccountID = objObjectsInfo.FK_ACAccountSaleID;
                }
            }

            //Remove payment documents that don't have relative entries
            for (int i = 0; i < DocumentList.Count; i++)
            {
                if (!DocumentEntryList.Exists(e => e.FK_ACDocumentTypeID == DocumentList[i].FK_ACDocumentTypeID))
                {
                    DocumentList.RemoveAt(i);
                    i--;
                }
            }

            //Add new payment documents that have relative entries
            string customerPaymentNo = string.Empty;

            foreach (ACDocumentEntrysInfo entry in DocumentEntryList)
            {
                if (entry.ACEntryTypeName == AccEntryType.ThuTienKhachHang.ToString() ||
                    entry.ACEntryTypeName == AccEntryType.ThuPhieuGhiCo.ToString() ||
                    entry.ACEntryTypeName == AccEntryType.ThuTheTinDung.ToString() ||
                    entry.ACEntryTypeName == AccEntryType.ThuCocBangPhieuGhiCo.ToString())
                {
                    ACDocumentsInfo document = DocumentList.Where(d => d.ACDocumentTypeName == entry.ACDocumentTypeName &&
                                                                (string.IsNullOrEmpty(entry.ACDocumentNo) || entry.ACDocumentNo == d.ACDocumentNo)).FirstOrDefault();
                    if (document == null)
                    {
                        document = new ACDocumentsInfo();
                        document.FK_ACDocumentTypeID = entry.FK_ACDocumentTypeID;
                        document.ACDocumentTypeName = entry.ACDocumentTypeName;
                        DocumentList.Add(document);
                    }
                    BOSUtil.CopyObject(customerPayment, document);
                    if (!string.IsNullOrEmpty(entry.ACDocumentNo))
                    {
                        document.ACDocumentNo = entry.ACDocumentNo;
                    }
                    if (entry.FK_GECurrencyID > 0)
                    {
                        document.FK_GECurrencyID = entry.FK_GECurrencyID;
                        document.ACDocumentExchangeRate = entry.ACDocumentExchangeRate;
                    }
                    if (string.IsNullOrEmpty(customerPaymentNo))
                    {
                        customerPaymentNo = document.ACDocumentNo;
                    }
                }
            }

            //Set the reference info for the payment documents
            foreach (ACDocumentEntrysInfo entry in DocumentEntryList)
            {
                if (entry.ACEntryTypeName == AccEntryType.ThuTienKhachHang.ToString() ||
                    entry.ACEntryTypeName == AccEntryType.ThuPhieuGhiCo.ToString() ||
                    entry.ACEntryTypeName == AccEntryType.ThuTheTinDung.ToString() ||
                    entry.ACEntryTypeName == AccEntryType.ThuCocBangPhieuGhiCo.ToString())
                {
                    ACDocumentsInfo document = DocumentList.Where(d => d.ACDocumentTypeName == entry.ACDocumentTypeName &&
                                                                (string.IsNullOrEmpty(entry.ACDocumentNo) || entry.ACDocumentNo == d.ACDocumentNo)).FirstOrDefault();
                    if (document != null)
                    {
                        document.ACDocumentReference = customerPaymentNo;
                    }
                }
            }
            ACAccountsController objAccountController = new ACAccountsController();
            ACObjectsInfo objectsInfo = objObjectsController.GetObjectByIDAndType(objInvoicesInfo.FK_ACObjectID, objInvoicesInfo.ARObjectType);

            ARPOSPaymentDetailsInfo bank = POSPaymentDetailList.Where(d => d.ARPOSPaymentMethodCombo == PaymentMethod.BankTransfer.ToString()).FirstOrDefault();
            ARPOSPaymentDetailsInfo cash = POSPaymentDetailList.Where(d => d.ARPOSPaymentMethodCombo == PaymentMethod.Cash.ToString()).FirstOrDefault();
            ARPOSPaymentDetailsInfo creditCard = POSPaymentDetailList.Where(d => d.ARPOSPaymentMethodCombo == PaymentMethod.CreditCard.ToString()).FirstOrDefault();
            CSCompanyBanksController objCompanyBankController = new CSCompanyBanksController();
            CSCompanyBanksInfo objCompanyBankInfo = (CSCompanyBanksInfo)objCompanyBankController.GetObjectByID(bank.FK_CSCompanyBankID);

            CSCashFundsInfo objCashFundsInfo = (CSCashFundsInfo)objCashFundsController.GetObjectByID(cash.FK_CSCashFundID);

            ACDocTypeEntrysInfo defaultDocTypeEntrysTTD = new ACDocTypeEntrysInfo();
            defaultDocTypeEntrysTTD = NewDocumentTTDEntryFromDocumentInfoForInvoices(AccDocumentType.NghiepVuKhac.ToString());

            foreach (ACDocumentEntrysInfo entry in DocumentEntryList)
            {
                if (entry.ACEntryTypeName == AccEntryType.ThuTienKhachHang.ToString() ||
                    entry.ACEntryTypeName == AccEntryType.ThuPhieuGhiCo.ToString() ||
                    entry.ACEntryTypeName == AccEntryType.ThuTheTinDung.ToString())
                {
                    if (objObjectsInfo.FK_ACAccountSaleID != 0)
                        entry.FK_ACCreditAccountID = objObjectsInfo.FK_ACAccountSaleID;
                    if (bank.FK_CSCompanyBankID != 0)
                    {
                        entry.FK_ACDebitAccountID = objCompanyBankInfo.FK_ACAcountID;
                        break;
                    }
                    if (cash.FK_CSCashFundID != 0)
                    {
                        entry.FK_ACDebitAccountID = objCashFundsInfo.FK_ACAcountID;
                        break;
                    }
                    entry.FK_ACCreditAccountID = ((ACAccountsInfo)objAccountController.GetObjectByNo(AccAccount.Acc131)).ACAccountID;
                    entry.FK_ACDebitAccountID = ((ACAccountsInfo)objAccountController.GetObjectByNo(AccAccount.Acc1111)).ACAccountID;

                    if (entry.ACEntryTypeName == AccEntryType.ThuTheTinDung.ToString())
                    {
                        entry.FK_ACCreditAccountID = ((ACAccountsInfo)objAccountController.GetObjectByNo(defaultDocTypeEntrysTTD.DefaultCreditAccountNo)).ACAccountID;
                        entry.FK_ACDebitAccountID = ((ACAccountsInfo)objAccountController.GetObjectByNo(defaultDocTypeEntrysTTD.DefaultDebitAccountNo)).ACAccountID;
                        if (creditCard.FK_CSCompanyBankID != 0)
                        {
                            entry.FK_ACDebitAccountID = ((CSCompanyBanksInfo)objCompanyBankController.GetObjectByID(creditCard.FK_CSCompanyBankID)).FK_ACAcountID;
                        }
                    }
                }
            }

            SaveAccountingData();
            DocumentEntryList.GridControl.RefreshDataSource();
            return customerPaymentNo;
        }

        public override bool SaveAccountingData()
        {
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
            {
                if (objDocumentsInfo.ACDocumentTypeName == AccDocumentType.BanLe.ToString())
                {
                    BOSUtil.CopyObject(MainObject, objDocumentsInfo);
                }
                else if (objDocumentsInfo.ACDocumentTypeName == AccDocumentType.BanDichVu.ToString())
                {
                    BOSUtil.CopyObject(MainObject, objDocumentsInfo);
                }
                else if (objDocumentsInfo.ACDocumentTypeName == AccDocumentType.XuatKhoBanHang.ToString())
                {
                    BOSUtil.CopyObject(MainObject, objDocumentsInfo);
                    objDocumentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
                    objDocumentsInfo.ACDocumentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
                }
                objDocumentsInfo.FK_ACObjectID = objInvoicesInfo.FK_ARCustomerID;
                objDocumentsInfo.ACObjectType = ObjectType.Customer.ToString();
            }
            bool isComplete = base.SaveAccountingData();
            return isComplete;
        }

        /// <summary>
        /// Create a receipt voucher associating with the customer payment
        /// </summary>
        /// <param name="customerPayment">Customer payment object</param>
        /// <param name="oldReceiptVoucherNo">Old receipt voucher no</param>
        /// <param name="amount">Receipted amount</param>
        /// <param name="currencyID">Currency id</param>
        /// <param name="exchangeRate">Exchange rate</param>
        /// <returns>Receipt voucher object</returns>
        private ARReceiptVouchersInfo CreateReceiptVoucher(ARCustomerPaymentsInfo customerPayment, string oldReceiptVoucherNo, decimal amount, int currencyID, decimal exchangeRate, int debitAccountID)
        {
            ARInvoicesInfo invoice = (ARInvoicesInfo)MainObject;
            ARReceiptVouchersController objReceiptVouchersController = new ARReceiptVouchersController();
            ARReceiptVoucherItemsController objReceiptVoucherItemsController = new ARReceiptVoucherItemsController();
            ARReceiptVouchersInfo receiptVoucher = new ARReceiptVouchersInfo();
            BOSUtil.CopyObject(customerPayment, receiptVoucher);
            if (string.IsNullOrEmpty(oldReceiptVoucherNo))
            {
                receiptVoucher.ARReceiptVoucherNo = BOSApp.GetMainObjectNo(ModuleName.ReceiptVoucher, receiptVoucher);
                BOSApp.UpdateObjectNumbering(ModuleName.ReceiptVoucher);
            }
            else
            {
                receiptVoucher.ARReceiptVoucherNo = oldReceiptVoucherNo;
            }
            receiptVoucher.FK_ACObjectID = invoice.FK_ARCustomerID;
            receiptVoucher.ARObjectType = ObjectType.Customer.ToString();
            receiptVoucher.ARReceiptVoucherType = ReceiptVoucherType.CustomerPayment.ToString();
            receiptVoucher.ARReceiptVoucherReference = receiptVoucher.ARReceiptVoucherNo;
            receiptVoucher.FK_GECurrencyID = currencyID;
            receiptVoucher.ARReceiptVoucherExchangeRate = exchangeRate;
            receiptVoucher.ARReceiptVoucherTotalAmount = amount;
            receiptVoucher.ARReceiptVoucherExchangeAmount = receiptVoucher.ARReceiptVoucherTotalAmount * receiptVoucher.ARReceiptVoucherExchangeRate;
            int receiptVoucherID = objReceiptVouchersController.CreateObject(receiptVoucher);

            objReceiptVoucherItemsController.DeleteByForeignColumn("FK_ARReceiptVoucherID", receiptVoucher.ARReceiptVoucherID);
            foreach (ACDocumentEntrysInfo entry in DocumentEntryList)
            {
                if (entry.ACDocumentTypeName == AccDocumentType.PhieuThu.ToString())
                {
                    ARReceiptVoucherItemsInfo item = new ARReceiptVoucherItemsInfo();
                    BOSUtil.CopyObject(entry, item);
                    item.FK_ARReceiptVoucherID = receiptVoucher.ARReceiptVoucherID;
                    item.FK_ACDebitAccountID = debitAccountID;
                    objReceiptVoucherItemsController.CreateObject(item);
                }
            }
            return receiptVoucher;
        }

        /// <summary>
        /// Create a bank transfer associating with the customer payment
        /// </summary>
        /// <param name="customerPayment">Customer payment object</param>
        /// <param name="oldBankTransferNo">Old bank transfer no</param>
        /// <param name="amount">Transferred amount</param>
        /// <param name="currencyID">Currency id</param>
        /// <param name="exchangeRate">Exchange rate</param>
        /// <returns>Bank transaction object</returns>
        private ACBankTransactionsInfo CreateBankTransfer(ARCustomerPaymentsInfo customerPayment, string oldBankTransferNo, decimal amount, int currencyID, decimal exchangeRate)
        {
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            string bankName = objCompanyBanksController.GetObjectNameByID(customerPayment.FK_CSCompanyBankID);

            ARInvoicesInfo invoice = (ARInvoicesInfo)MainObject;
            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            ACBankTransactionItemsController objBankTransactionItemsController = new ACBankTransactionItemsController();
            ACBankTransactionsInfo bankTransfer = new ACBankTransactionsInfo();
            BOSUtil.CopyObject(customerPayment, bankTransfer);
            if (string.IsNullOrEmpty(oldBankTransferNo))
            {
                bankTransfer.ACBankTransactionNo = BOSApp.GetMainObjectNo(ModuleName.BankTransaction, bankTransfer);
                BOSApp.UpdateObjectNumbering(ModuleName.BankTransaction);
            }
            else
            {
                bankTransfer.ACBankTransactionNo = oldBankTransferNo;
            }
            bankTransfer.FK_ACObjectID = invoice.FK_ARCustomerID;
            bankTransfer.ACObjectType = ObjectType.Customer.ToString();
            bankTransfer.ACBankTransactionType = BankTransactionType.BankTransfer.ToString();
            bankTransfer.ACBankTransactionReference = bankTransfer.ACBankTransactionNo;
            bankTransfer.ACBankTransactionReceiverBankName = bankName;
            bankTransfer.ACBankTransactionReceiverAccount = customerPayment.ARCustomerPaymentBankAccount;
            bankTransfer.FK_GECurrencyID = currencyID;
            bankTransfer.ACBankTransactionExchangeRate = exchangeRate;
            bankTransfer.ACBankTransactionTotalAmount = amount;
            bankTransfer.ACBankTransactionExchangeAmount = bankTransfer.ACBankTransactionTotalAmount * bankTransfer.ACBankTransactionExchangeRate;
            int bankTransferID = objBankTransactionsController.CreateObject(bankTransfer);

            objBankTransactionItemsController.DeleteByForeignColumn("FK_ACBankTransactionID", bankTransfer.ACBankTransactionID);
            foreach (ACDocumentEntrysInfo entry in DocumentEntryList)
            {
                if (entry.ACDocumentTypeName == AccDocumentType.NopTienVaoTaiKhoan.ToString())
                {
                    ACBankTransactionItemsInfo item = new ACBankTransactionItemsInfo();
                    BOSUtil.CopyObject(entry, item);
                    item.FK_ACBankTransactionID = bankTransfer.ACBankTransactionID;
                    objBankTransactionItemsController.CreateObject(item);
                }
            }
            return bankTransfer;
        }
        #endregion

        public override void SetProductPriceByProductUnitPrice(BusinessObject item)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
            string itemTablePrefix = itemTableName.Substring(0, itemTableName.Length - 1);
            string mainTablePrefix = mainTableName.Substring(0, mainTableName.Length - 1);

            //Get Exchange Rate
            decimal exchangeRate = Convert.ToDecimal(dbUtil.GetPropertyValue(MainObject, mainTablePrefix + "ExchangeRate"));
            if (exchangeRate == 0)
                exchangeRate = 1M;

            int productID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICProductID"));
            //round by currency
            int currencyID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_GECurrencyID"));
            int decimalNumber = BOSApp.GetDecimalNumberByCurrencyID(currencyID);
            //Math Round Start

            //Get Item Unit Price
            string columnName = itemTablePrefix + "ProductUnitPrice";
            decimal unitPrice = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));
            unitPrice = Math.Round(unitPrice, decimalNumber);
            //Get Item Qty
            columnName = itemTablePrefix + "ProductQty";
            decimal qty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Get Item Unit Cost
            columnName = itemTablePrefix + "ProductUnitCost";
            decimal unitCost = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            unitCost = Math.Round(unitCost, 5, MidpointRounding.AwayFromZero);

            //Set Item Extended Price
            columnName = itemTablePrefix + "Price";
            decimal extPrice = unitPrice * qty;
            extPrice = Math.Round(extPrice, decimalNumber);
            dbUtil.SetPropertyValue(item, columnName, extPrice);

            //Set Item Net Amount
            columnName = itemTablePrefix + "NetAmount";
            decimal netAmount = extPrice;
            dbUtil.SetPropertyValue(item, columnName, netAmount);

            //Get or set item discount percent and amount
            string discountPercentColumnName = itemTablePrefix + "ProductDiscount";
            string discountAmountColumnName = itemTablePrefix + "DiscountAmount";

            decimal discountPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(item, discountPercentColumnName));

            decimal discountAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item, discountAmountColumnName));
            discountAmount = Math.Round(discountAmount, decimalNumber);

            discountAmount = extPrice * discountPercent / 100;
            discountAmount = Math.Round(discountAmount, decimalNumber);
            dbUtil.SetPropertyValue(item, discountAmountColumnName, discountAmount);

            //Get or set tax percent and amount
            string taxPercentColumnName = itemTablePrefix + "ProductTaxPercent";
            string taxAmountColumnName = itemTablePrefix + "TaxAmount";

            decimal taxPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(item, taxPercentColumnName));
            decimal taxAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item, taxAmountColumnName));

            taxAmount = Math.Round(taxAmount, decimalNumber);

            decimal oldTaxAmount = 0;
            if (item.OldObject != null)
            {
                oldTaxAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item.OldObject, taxAmountColumnName));
            }
            if (taxAmount != oldTaxAmount)
            {
                taxAmount = ((netAmount - discountAmount) * taxPercent) / 100;
                taxAmount = Math.Round(taxAmount, decimalNumber);

                dbUtil.SetPropertyValue(item, taxAmountColumnName, taxAmount);
            }
            else
            {
                taxAmount = ((netAmount - discountAmount) * taxPercent) / 100;
                taxAmount = Math.Round(taxAmount, decimalNumber);

                dbUtil.SetPropertyValue(item, taxAmountColumnName, taxAmount);
            }

            //Set Item Total Amount
            columnName = itemTablePrefix + "TotalAmount";
            dbUtil.SetPropertyValue(item, columnName, netAmount + taxAmount - discountAmount);

            //Set Item Total Cost
            columnName = itemTablePrefix + "TotalCost";
            dbUtil.SetPropertyValue(item, columnName, qty * unitCost);

            //Set Item Exchange Total Cost
            //Fix tam, HDBH tao tu XKBH gia von luon la VND, ko * exchangeRate
            int shipmentItemID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICShipmentItemID"));

            columnName = itemTablePrefix + "ExchangeTotalCost";
            if (shipmentItemID > 0 && itemTableName == TableName.ARInvoiceItemsTableName)
                dbUtil.SetPropertyValue(item, columnName, qty * unitCost);
            else
                dbUtil.SetPropertyValue(item, columnName, (qty * unitCost) * exchangeRate);

            //Get item factor
            columnName = itemTablePrefix + "ProductFactor";
            decimal factor = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Set Item Exchange Unit Cost
            columnName = itemTablePrefix + "ExchangeUnitCost";

            if (shipmentItemID > 0 && itemTableName == TableName.ARInvoiceItemsTableName)
                dbUtil.SetPropertyValue(item, columnName, unitCost /(factor !=0 ? factor : 1));
            else
                dbUtil.SetPropertyValue(item, columnName, unitCost / (factor != 0 ? factor : 1) * exchangeRate);

            //Set Item Exchange Qty
            columnName = itemTablePrefix + "ProductExchangeQty";
            dbUtil.SetPropertyValue(item, columnName, qty * factor);

            BOSApp.RoundByCurrency(item, currencyID);

            item.OldObject = (BusinessObject)item.Clone();
        }

        protected override decimal CalculateProductPriceBaseOnProductPriceLevel(ICProductsInfo productsInfo)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objICProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productsInfo.ICProductID);
            decimal dbProductPrice = objICProductsInfo.ICProductPrice01;
            int priceLevelID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_ARPriceLevelID"));
            if (priceLevelID > 0)
            {
                ICProductPricesController objProductPricesController = new ICProductPricesController();
                ICProductPricesInfo objProductPricesInfo = objProductPricesController.GetProductPriceByProductIDAndPriceLevelID(objICProductsInfo.ICProductID, priceLevelID);
                //If product has own price level
                if (objProductPricesInfo != null)
                    dbProductPrice = (1 - objProductPricesInfo.ICProductPriceMarkDown / 100) * objICProductsInfo.ICProductPrice01;
                //Else, get default price level
                else
                {
                    ARPriceLevelsController objPriceLevelsController = new ARPriceLevelsController();
                    ARPriceLevelsInfo objPriceLevelsInfo = (ARPriceLevelsInfo)objPriceLevelsController.GetObjectByID(priceLevelID);
                    if (objPriceLevelsInfo != null)
                        dbProductPrice = (1 - objPriceLevelsInfo.ARPriceLevelMarkDown / 100) * objICProductsInfo.ICProductPrice01;
                }
            }
            return dbProductPrice;
        }

        private ACDocTypeEntrysInfo NewDocumentTTDEntryFromDocumentInfoForInvoices(string documentTypes)
        {

            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            ACDocTypeEntrysInfo objDocTypeEntrysInfo = new ACDocTypeEntrysInfo();
            List<ACDocTypeEntrysInfo> entries = objDocTypeEntrysController.GetEntriesByDocumentType(documentTypes);
            objDocTypeEntrysInfo = entries.Where(o => o.ACEntryTypeName == AccEntryType.ThuTheTinDung.ToString()).FirstOrDefault();
            return objDocTypeEntrysInfo;

        }

        public void TakePaymentDetail(decimal paymentAmount)
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
                    POSPaymentDetailList.SaveItemObjects();
                    //Update invoice
                    ARInvoicesController objInvoicesController = new ARInvoicesController();
                    objInvoicesInfo.ARInvoiceStatus = InvoiceStatus.Paid.ToString();
                    objInvoicesController.UpdateObject(objInvoicesInfo);

                    scope.Complete();
                }
                catch (Exception ex)
                {
                    scope.Dispose();
                }
            }
        }
        public override bool CancelCompleteTransaction()
        {
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            objInvoicesInfo.ARInvoiceStatus = InvoiceStatus.New.ToString();
            UpdateMainObject();
            return true;
        }
    }
}
