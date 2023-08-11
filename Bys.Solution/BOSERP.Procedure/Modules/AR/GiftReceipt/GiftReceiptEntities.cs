using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.GiftReceipt
{
    public class GiftReceiptEntities : BaseTransactionEntities
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
        public BOSList<ARCustomerPaymentDetailsInfo> CustomerPaymentDetailList { get; set; }
        #endregion

        #region Constructor
        public GiftReceiptEntities()
            : base()
        {
            InvoiceItemList = new BOSItemsEntityList<ARInvoiceItemsInfo>();
            CustomerPaymentDetailList = new BOSList<ARCustomerPaymentDetailsInfo>();
            ComponentInvoiceItemList = new BOSItemsEntityList<ARInvoiceItemsInfo>();
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

            CustomerPaymentDetailList.InitBOSList(this,
                                                  String.Empty,
                                                  TableName.ARCustomerPaymentDetailsTableName,
                                                  BOSList<ARCustomerPaymentDetailsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            InvoiceItemList.InitBOSListGridControl();
            CustomerPaymentDetailList.InitBOSListGridControl();
            DocumentEntryList.InitBOSListGridControl(GiftReceiptModule.DocumentEntryGridControlName);
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
            objInvoicesInfo.ARInvoiceTypeCombo = InvoiceType.GiftReceipt.ToString();
            objInvoicesInfo.ARInvoiceDate = DateTime.Now;
            objInvoicesInfo.FK_ARPriceLevelID = 1;
            objInvoicesInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objInvoicesInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objInvoicesInfo.ARInvoiceExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objInvoicesInfo.ARInvoiceDesc = GiftReceiptLocalizedResources.GiftReceiptDefaultDesc;

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
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(iICProductID);
            if (objProductsInfo != null)
            {
                ARInvoiceItemsInfo objInvoiceItemsInfo = (ARInvoiceItemsInfo)ModuleObjects[TableName.ARInvoiceItemsTableName];
                objInvoiceItemsInfo.FK_ICProductID = objProductsInfo.ICProductID;
                base.SetValuesAfterValidateProduct(objProductsInfo.ICProductID);
                objInvoiceItemsInfo.FK_ICStockID = BOSApp.CurrentCompanyInfo.FK_ICStockID;
                objInvoiceItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductSaleUnitID;
                objInvoiceItemsInfo.ICProductUnitPrice = objInvoiceItemsInfo.ARInvoiceItemProductUnitPrice;
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
            objInvoicesInfo.ARInvoiceDiscountFix = objInvoicesInfo.ARInvoiceSubTotalAmount * objInvoicesInfo.ARInvoiceDiscountPerCent / 100;
            objInvoicesInfo.ARInvoiceTaxAmount = (objInvoicesInfo.ARInvoiceSubTotalAmount - objInvoicesInfo.ARInvoiceDiscountFix) * objInvoicesInfo.ARInvoiceTaxPercent / 100;
            objInvoicesInfo.ARInvoiceTotalAmount = objInvoicesInfo.ARInvoiceSubTotalAmount + objInvoicesInfo.ARInvoiceTaxAmount - objInvoicesInfo.ARInvoiceDiscountFix;
            UpdateMainObjectBindingSource();
        }

        public override bool CompleteTransaction()
        {
            //Update GiftReceipt status
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
                    item.ARInvoiceItemProductUnitCost = AccountHelper.GetInventoryCost(item.FK_ICStockID, item.FK_ICProductID, item.ARInvoiceItemProductSerialNo, objInvoicesInfo.ARInvoiceDate);
                    objInvoiceItemsController.UpdateObject(item);
                }
            }

            //Generate shipment 
            GenerateShipment(objInvoicesInfo);
            return true;
        }

        /// <summary>
        /// Generate shipment from invoice
        /// </summary>
        /// <param name="objInvoicesInfo">Invoice info</param>
        public void GenerateShipment(ARInvoicesInfo objInvoicesInfo)
        {
            //Generate shipment from invoice
            ICShipmentsController objShipmentsController = new ICShipmentsController();
            List<ARInvoiceItemsInfo> componentInvoiceItems = ComponentInvoiceItemList.Where(i => i.HasComponent == false).ToList();
            List<ICShipmentItemsInfo> shipmentItemList = DataGenerator.GenerateShipmentItemsFromInvoiceItems(componentInvoiceItems);
            ICShipmentsInfo shipment = (ICShipmentsInfo)objShipmentsController.GetObjectByNo(objInvoicesInfo.ARInvoiceNo);
            if (shipment != null)
            {
                int shipmentID = shipment.ICShipmentID;
                shipment = DataGenerator.GenerateShipmentFromInvoice(objInvoicesInfo);
                shipment.ICShipmentTypeCombo = ShipmentType.PresentingShipment.ToString();
                shipment.ICShipmentSubTotalAmount = shipmentItemList.Sum(i => i.ICShipmentItemTotalAmount);
                shipment.ICShipmentTotalAmount = shipment.ICShipmentSubTotalAmount;
                if (ComponentInvoiceItemList.Count > 0)
                {
                    shipment.FK_ICStockID = ComponentInvoiceItemList[0].FK_ICStockID;
                }
                shipment.ICShipmentID = shipmentID;
                objShipmentsController.UpdateObject(shipment);
            }
            else
            {
                shipment = DataGenerator.GenerateShipmentFromInvoice(objInvoicesInfo);
                shipment.ICShipmentTypeCombo = ShipmentType.PresentingShipment.ToString();
                shipment.ICShipmentSubTotalAmount = shipmentItemList.Sum(i => i.ICShipmentItemTotalAmount);
                shipment.ICShipmentTotalAmount = shipment.ICShipmentSubTotalAmount;
                if (ComponentInvoiceItemList.Count > 0)
                {
                    shipment.FK_ICStockID = ComponentInvoiceItemList[0].FK_ICStockID;
                }
                objShipmentsController.CreateObject(shipment);
            }

            //Generate shipment item from invoice item                        
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            objShipmentItemsController.DeleteByForeignColumn("FK_ICShipmentID", shipment.ICShipmentID);
            foreach (ICShipmentItemsInfo item in shipmentItemList)
            {
                item.FK_ICShipmentID = shipment.ICShipmentID;
                objShipmentItemsController.CreateObject(item);
            }

            SaveShipmentEntries(shipment);
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
                                                                        AccDocumentType.XuatKhoTangHang.ToString(),
                                                                        AccEntryType.XuatKhoTangHang.ToString());
            Dictionary<ACDocumentEntrysInfo, List<ARInvoiceItemsInfo>> documentEntryAccounts = new Dictionary<ACDocumentEntrysInfo, List<ARInvoiceItemsInfo>>();
            List<int> productAccountID = new List<int>();
            if (ComponentInvoiceItemList != null)
            {
                foreach (ARInvoiceItemsInfo invoiceItem in ComponentInvoiceItemList)
                {
                    ICProductsInfo product = productController.GetObjectByID(invoiceItem.FK_ICProductID) as ICProductsInfo;
                    ACDocumentEntrysInfo entry = DocumentEntryList.FirstOrDefault(e => e.ACEntryTypeName == AccEntryType.XuatKhoTangHang.ToString()
                                                                        && e.FK_ACCreditAccountID == product.FK_ACAccountID);
                    if (entry == null && defaultEntry != null)
                    {
                        entry = AccountHelper.AddItemToDocumentEntryList(defaultEntry, DocumentEntryList);
                        entry.FK_ACCreditAccountID = product.FK_ACAccountID;
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


                ACDocumentsInfo objDocumentsInfo = DocumentList.Where(d => d.ACDocumentTypeName == AccDocumentType.XuatKhoTangHang.ToString()).FirstOrDefault();
                if (objDocumentsInfo == null)
                {
                    objDocumentsInfo = new ACDocumentsInfo();
                    objDocumentsInfo.FK_ACDocumentTypeID = item.FK_ACDocumentTypeID;
                    objDocumentsInfo.ACDocumentTypeName = item.ACDocumentTypeName;
                    DocumentList.Add(objDocumentsInfo);
                }
            }

            List<ACDocumentEntrysInfo> removedItems = DocumentEntryList.Where(item => item.ACEntryTypeName == AccEntryType.XuatKhoTangHang.ToString()
                                                                              && !productAccountID.Any(accountID => accountID == item.FK_ACCreditAccountID)).ToList();
            if (removedItems != null)
            {
                foreach (ACDocumentEntrysInfo item in removedItems)
                    DocumentEntryList.Remove(item);
            }
            SaveAccountingData();

            //ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            //ACDocumentEntrysInfo entry = DocumentEntryList.Where(e => e.ACEntryTypeName == AccEntryType.XuatKhoTangHang.ToString()).FirstOrDefault();
            //if (entry == null)
            //{
            //    ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            //    ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
            //                                                            AccDocumentType.XuatKhoTangHang.ToString(),
            //                                                            AccEntryType.XuatKhoTangHang.ToString());
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

            //ACDocumentsInfo objDocumentsInfo = DocumentList.Where(d => d.ACDocumentTypeName == AccDocumentType.XuatKhoTangHang.ToString()).FirstOrDefault();
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
            //        ((GiftReceiptModule)Module).UpdateDocumentEntryList(objProductsInfo.FK_ACAccountID, item.ARInvoiceItemProductUnitCost * item.ARInvoiceItemProductQty, this, objShipmentsInfo.ICShipmentExchangeRate);
            //    }
            //}
            //List<ACDocumentEntrysInfo> deletedItems = DocumentEntryList.Where(item => item.ACEntryTypeName == AccEntryType.XuatKhoTangHang.ToString() &&
            //                                           !productAccountIDs.Any(accountID => item.FK_ACCreditAccountID == accountID ||
            //                                               item.FK_ACDebitAccountID == accountID)).ToList();
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

        public override bool SaveAccountingData()
        {
            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)MainObject;
            foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
            {
                if (objDocumentsInfo.ACDocumentTypeName == AccDocumentType.PhieuTangHang.ToString())
                {
                    BOSUtil.CopyObject(MainObject, objDocumentsInfo);
                }
                else if (objDocumentsInfo.ACDocumentTypeName == AccDocumentType.XuatKhoTangHang.ToString())
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
        #endregion
    }
}
