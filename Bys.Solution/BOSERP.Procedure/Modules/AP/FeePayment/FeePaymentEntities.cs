using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.FeePayment
{
    public class FeePaymentEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        /// <summary>
        /// Gets or sets the list of receipts whose fee is paid by the payment
        /// </summary>
        public BOSList<APFeePaymentReceiptsInfo> FeePaymentReceiptList { get; set; }
        public BOSList<APFeePaymentInvoiceInternalReceiptsInfo> FeePaymentInvoiceInternalReceiptList { get; set; }
        public BOSList<APFeePaymentTransfersInfo> FeePaymentTransferList { get; set; }
        public List<ICReceiptItemsInfo> ReceiptItemList { get; set; }
        public List<ICReceiptItemsInfo> InvoiceInternalReceiptItemList { get; set; }
        public List<ICTransferItemsInfo> TransferItemList { get; set; }
        public List<int> RemovedItemIDs { get; set; }
        public List<int> RemovedInvoiceInternalReceiptItemIDs { get; set; }
        public List<int> RemovedTransferItemIDs { get; set; }
        public BOSList<APFeePaymentPurchaseOrdersInfo> FeePaymentPurchaseOrderList { get; set; }
        //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],START
        public BOSList<APFeePaymentInvoiceInsInfo> FeePaymentInvoiceInList { get; set; }
        //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],END
        public BOSList<APFeePaymentInvoicesInfo> FeePaymentInvoiceList { get; set; }
        public BOSList<APFeePaymentFeeConfigsInfo> FeePaymentFeeConfigList { get; set; }
        public BOSList<APFeePaymentItemsInfo> FeePaymentItemList { get; set; }
        #endregion

        #region Constructor
        public FeePaymentEntities()
            : base()
        {
            FeePaymentReceiptList = new BOSList<APFeePaymentReceiptsInfo>();
            FeePaymentInvoiceInternalReceiptList = new BOSList<APFeePaymentInvoiceInternalReceiptsInfo>();
            FeePaymentTransferList = new BOSList<APFeePaymentTransfersInfo>();
            ReceiptItemList = new List<ICReceiptItemsInfo>();
            InvoiceInternalReceiptItemList = new List<ICReceiptItemsInfo>();
            TransferItemList = new List<ICTransferItemsInfo>();
            RemovedItemIDs = new List<int>();
            RemovedInvoiceInternalReceiptItemIDs = new List<int>();
            RemovedTransferItemIDs = new List<int>();
            FeePaymentPurchaseOrderList = new BOSList<APFeePaymentPurchaseOrdersInfo>();
            FeePaymentItemList = new BOSList<APFeePaymentItemsInfo>();
            //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],START
            FeePaymentInvoiceInList = new BOSList<APFeePaymentInvoiceInsInfo>();
            //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],END
            FeePaymentInvoiceList = new BOSList<APFeePaymentInvoicesInfo>();
            FeePaymentFeeConfigList = new BOSList<APFeePaymentFeeConfigsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACDocumentsInfo();
            SearchObject = new ACDocumentsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.APFeePaymentReceiptsTableName, new APFeePaymentReceiptsInfo());
            ModuleObjects.Add(TableName.APFeePaymentPurchaseOrdersTableName, new APFeePaymentPurchaseOrdersInfo());
            //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],START
            ModuleObjects.Add(TableName.APFeePaymentInvoiceInsTableName, new APFeePaymentInvoiceInsInfo());
            //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],END
            ModuleObjects.Add(TableName.APFeePaymentFeeConfigsTableName, new APFeePaymentFeeConfigsInfo());
        }

        public override void InitModuleObjectList()
        {
            FeePaymentReceiptList.InitBOSList(
                                    this,
                                    TableName.ACDocumentsTableName,
                                    TableName.APFeePaymentReceiptsTableName,
                                    BOSList<APFeePaymentReceiptsInfo>.cstRelationForeign);
            FeePaymentReceiptList.ItemTableForeignKey = "FK_ACDocumentID";

            FeePaymentInvoiceInternalReceiptList.InitBOSList(
                                    this,
                                    TableName.ACDocumentsTableName,
                                    TableName.APFeePaymentInvoiceInternalReceiptsTableName,
                                    BOSList<APFeePaymentInvoiceInternalReceiptsInfo>.cstRelationForeign);
            FeePaymentInvoiceInternalReceiptList.ItemTableForeignKey = "FK_ACDocumentID";

            FeePaymentTransferList.InitBOSList(
                                    this,
                                    TableName.ACDocumentsTableName,
                                    TableName.APFeePaymentTransfersTableName,
                                    BOSList<APFeePaymentTransfersInfo>.cstRelationForeign);
            FeePaymentTransferList.ItemTableForeignKey = "FK_ACDocumentID";

            DocumentEntryList.InitBOSList(
                                                   this,
                                                   TableName.ACDocumentsTableName,
                                                   TableName.ACDocumentEntrysTableName,
                                                   BOSList<ACDocumentEntrysInfo>.cstRelationForeign);
            DocumentEntryList.ItemTableForeignKey = "FK_ACDocumentID";
            FeePaymentPurchaseOrderList.InitBOSList(
                                    this,
                                    TableName.ACDocumentsTableName,
                                    TableName.APFeePaymentPurchaseOrdersTableName,
                                    BOSList<APFeePaymentPurchaseOrdersInfo>.cstRelationForeign);
            FeePaymentPurchaseOrderList.ItemTableForeignKey = "FK_ACDocumentID";
            //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],START
            FeePaymentInvoiceInList.InitBOSList(
                                    this,
                                    TableName.ACDocumentsTableName,
                                    TableName.APFeePaymentInvoiceInsTableName,
                                    BOSList<APFeePaymentInvoiceInsInfo>.cstRelationForeign);
            FeePaymentInvoiceInList.ItemTableForeignKey = "FK_ACDocumentID";
            //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],END
            FeePaymentInvoiceList.InitBOSList(
                                    this,
                                    TableName.ACDocumentsTableName,
                                    TableName.APFeePaymentInvoicesTableName,
                                    BOSList<APFeePaymentInvoicesInfo>.cstRelationForeign);
            FeePaymentInvoiceList.ItemTableForeignKey = "FK_ACDocumentID";

            FeePaymentFeeConfigList.InitBOSList(
                                    this,
                                    TableName.ACDocumentsTableName,
                                    TableName.APFeePaymentFeeConfigsTableName,
                                    BOSList<APFeePaymentInvoiceInsInfo>.cstRelationForeign);
            FeePaymentFeeConfigList.ItemTableForeignKey = "FK_ACDocumentID";
            FeePaymentItemList.InitBOSList(
                                   this,
                                   TableName.ACDocumentsTableName,
                                   TableName.APFeePaymentItemsTableName,
                                   BOSList<APFeePaymentItemsInfo>.cstRelationForeign);
            FeePaymentItemList.ItemTableForeignKey = "FK_ACDocumentID";
        }

        public override void InitGridControlInBOSList()
        {
            FeePaymentReceiptList.InitBOSListGridControl(FeePaymentModule.FeePaymentReceiptGridControlName);
            FeePaymentInvoiceInternalReceiptList.InitBOSListGridControl(FeePaymentModule.FeePaymentInvoiceInternalReceiptGridControlName);
            FeePaymentTransferList.InitBOSListGridControl(FeePaymentModule.FeePaymentTransferGridControlName);
            DocumentEntryList.InitBOSListGridControl(FeePaymentModule.DocumentEntryGridControlName);
            FeePaymentPurchaseOrderList.InitBOSListGridControl(FeePaymentModule.FeePaymentPurchaseOrderGridControlName);
            //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],START
            FeePaymentInvoiceInList.InitBOSListGridControl(FeePaymentModule.FeePaymentInvoiceInGridControlName);
            //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],END
            FeePaymentInvoiceList.InitBOSListGridControl(FeePaymentModule.FeePaymentInvoiceGridControlName);
            FeePaymentFeeConfigList.InitBOSListGridControl();
            FeePaymentItemList.InitBOSListGridControl(FeePaymentModule.FeePaymentItemGridControlName);
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)MainObject;
            objDocumentsInfo.ACDocumentDate = DateTime.Now;
            objDocumentsInfo.FK_ACDocumentTypeID = ((FeePaymentModule)Module).GetDocumentTypeID();
            objDocumentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GEPurchaseCurrencyID;
            objDocumentsInfo.ACDocumentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanyPurchaseExchangeRate;
            objDocumentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objDocumentsInfo.ACDocumentAllocationCriteria = DocumentAllocationCriteria.Amount.ToString();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                FeePaymentReceiptList.SetDefaultListAndRefreshGridControl();
                FeePaymentInvoiceInternalReceiptList.SetDefaultListAndRefreshGridControl();
                FeePaymentTransferList.SetDefaultListAndRefreshGridControl();
                DocumentEntryList.SetDefaultListAndRefreshGridControl();
                FeePaymentPurchaseOrderList.SetDefaultListAndRefreshGridControl();
                FeePaymentInvoiceInList.SetDefaultListAndRefreshGridControl();
                FeePaymentInvoiceList.SetDefaultListAndRefreshGridControl();
                FeePaymentFeeConfigList.SetDefaultListAndRefreshGridControl();
                FeePaymentItemList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Main Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            FeePaymentFeeConfigList.Invalidate(iObjectID);
            APFeePaymentReceiptsController objFeePaymentReceiptsController = new APFeePaymentReceiptsController();
            List<APFeePaymentReceiptsInfo> receipts = objFeePaymentReceiptsController.GetReceiptsByFeePaymentID(iObjectID);
            foreach (APFeePaymentReceiptsInfo item in receipts)
            {
                if (!((FeePaymentModule)Module).CheckIsExistShipment(item.FK_ICReceiptID))
                {
                    item.IsExistShipment = true;
                }    
            }    
            FeePaymentReceiptList.Invalidate(receipts);

            ReceiptItemList.Clear();
            if (receipts != null)
            {
                ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
                ICProductsController obj = new ICProductsController();
                foreach (APFeePaymentReceiptsInfo receipt in receipts)
                {
                    List<ICReceiptItemsInfo> items = objReceiptItemsController.GetItemsByReceiptID(receipt.FK_ICReceiptID);
                    foreach (var item in items)
                    {
                        ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(item.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            item.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                            ReceiptItemList.Add(item);
                        }
                    }
                }
            }

            APFeePaymentInvoiceInternalReceiptsController fiirController = new APFeePaymentInvoiceInternalReceiptsController();
            List<APFeePaymentInvoiceInternalReceiptsInfo> fiirList = fiirController.GetReceiptsByFeePaymentID(iObjectID);
            FeePaymentInvoiceInternalReceiptList.Invalidate(fiirList);

            InvoiceInternalReceiptItemList.Clear();
            if (fiirList != null)
            {
                ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
                ICProductsController obj = new ICProductsController();
                foreach (APFeePaymentInvoiceInternalReceiptsInfo receipt in fiirList)
                {
                    List<ICReceiptItemsInfo> items = objReceiptItemsController.GetItemsByReceiptID(receipt.FK_ICInvoiceInternalReceiptID);
                    foreach (var item in items)
                    {
                        ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(item.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            item.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                            InvoiceInternalReceiptItemList.Add(item);
                        }
                    }
                }
            }

            APFeePaymentTransfersController fptController = new APFeePaymentTransfersController();
            List<APFeePaymentTransfersInfo> transfers = fptController.GetTransfersByFeePaymentID(iObjectID);
            FeePaymentTransferList.Invalidate(transfers);

            TransferItemList.Clear();
            if (transfers != null)
            {
                ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
                ICProductsController obj = new ICProductsController();
                foreach (APFeePaymentTransfersInfo Transfer in transfers)
                {
                    List<ICTransferItemsInfo> items = objTransferItemsController.GetItemsByTransferID(Transfer.FK_ICTransferID);
                    foreach (var item in items)
                    {
                        ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(item.FK_ICProductID);
                        if (objProductsInfo != null)
                        {
                            item.FK_ACAccountID = objProductsInfo.FK_ACAccountID;
                            TransferItemList.Add(item);
                        }
                    }
                }
            }

            APFeePaymentPurchaseOrdersController objFeePaymentPurchaseOrdersController = new APFeePaymentPurchaseOrdersController();
            List<APFeePaymentPurchaseOrdersInfo> purchaseOrders = objFeePaymentPurchaseOrdersController.GetPurchaseOrdersByFeePaymentID(iObjectID);
            FeePaymentPurchaseOrderList.Invalidate(purchaseOrders);
            //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],START
            APFeePaymentInvoiceInsController iiController = new APFeePaymentInvoiceInsController();
            List<APFeePaymentInvoiceInsInfo> iiList = iiController.GetInvoiceInsByFeePaymentID(iObjectID);
            FeePaymentInvoiceInList.Invalidate(iiList);
            //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],END

            APFeePaymentInvoicesController iController = new APFeePaymentInvoicesController();
            List<APFeePaymentInvoicesInfo> iList = iController.GetInvoicesByFeePaymentID(iObjectID);
            FeePaymentInvoiceList.Invalidate(iList);            
            FeePaymentFeeConfigList.ForEach(o => o.ACObjectAccessKey = o.FK_ACObjectID + ";" + o.APObjectType);
            APFeePaymentItemsController objFeePaymentItemsController = new APFeePaymentItemsController();
            List<APFeePaymentItemsInfo> feePaymentItemList = objFeePaymentItemsController.GetFeePaymentItemPendingOrAliveByFeePaymentID(iObjectID);
            if (feePaymentItemList == null || feePaymentItemList.Count == 0)
            {
                feePaymentItemList = GetValueFeePaymentItemByObjectID(iObjectID);
            }
            FeePaymentItemList.Invalidate(feePaymentItemList);
        }
        #endregion

        #region Save Module Objects and Main Object functions
        public override int SaveMainObject()
        {
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)MainObject;
            //objDocumentsInfo.ACDocumentTotalAmount = DocumentEntryList.Sum(e => e.ACDocumentEntryAmount);
            //objDocumentsInfo.ACDocumentExchangeAmount = DocumentEntryList.Sum(e => e.ACDocumentEntryExchangeAmount);
            objDocumentsInfo.ACDocumentTotalAmount = FeePaymentFeeConfigList.Sum(e => (e.APFeePaymentFeeConfigAmount + e.APFeePaymentFeeConfigTaxAmount));
            objDocumentsInfo.ACDocumentExchangeAmount = objDocumentsInfo.ACDocumentTotalAmount * objDocumentsInfo.ACDocumentExchangeRate;
            objDocumentsInfo.ACVATDocumentType = objDocumentsInfo.ACVATDocumentTypeFeePayment;
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            RemovedItemIDs.Clear();
            foreach (APFeePaymentReceiptsInfo feePaymentReceipt in FeePaymentReceiptList.BackupList)
            {
                if (!FeePaymentReceiptList.Exists(fpr => fpr.APFeePaymentReceiptID == feePaymentReceipt.APFeePaymentReceiptID))
                {
                    //UpdateInventoryCost(feePaymentReceipt.FK_ICReceiptID);
                    RemovedItemIDs.Add(feePaymentReceipt.FK_ICReceiptID);
                }
            }

            RemovedInvoiceInternalReceiptItemIDs.Clear();
            foreach (APFeePaymentInvoiceInternalReceiptsInfo feePaymentReceipt in FeePaymentInvoiceInternalReceiptList.BackupList)
            {
                if (!FeePaymentReceiptList.Exists(fpr => fpr.APFeePaymentReceiptID == feePaymentReceipt.APFeePaymentInvoiceInternalReceiptID))
                {
                    //UpdateInventoryCost(feePaymentReceipt.FK_ICReceiptID);
                    RemovedInvoiceInternalReceiptItemIDs.Add(feePaymentReceipt.FK_ICInvoiceInternalReceiptID);
                }
            }


            RemovedTransferItemIDs.Clear();
            foreach (APFeePaymentTransfersInfo feePaymentTransfer in FeePaymentTransferList.BackupList)
            {
                if (!FeePaymentTransferList.Exists(fpr => fpr.APFeePaymentTransferID == feePaymentTransfer.APFeePaymentTransferID))
                {
                    //UpdateInventoryCost(feePaymentTransfer.FK_ICTransferID);
                    RemovedTransferItemIDs.Add(feePaymentTransfer.FK_ICTransferID);
                }
            }

            FeePaymentReceiptList.SaveItemObjects();
            FeePaymentInvoiceInternalReceiptList.SaveItemObjects();
            FeePaymentTransferList.SaveItemObjects();

            FeePaymentPurchaseOrderList.SaveItemObjects();

            SaveDocumentEntrys((ACDocumentsInfo)MainObject);

            //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],START
            FeePaymentInvoiceInList.SaveItemObjects();
            //TNDLoc [ADD][30/07/2018][Fee Payment InvoiceIn],END
            FeePaymentFeeConfigList.SaveItemObjects();
            FeePaymentInvoiceList.SaveItemObjects();
            FeePaymentItemList.SaveItemObjects();
        }

        public override void DuplicateModuleObjectList()
        {
            FeePaymentReceiptList.Duplicate();
            FeePaymentPurchaseOrderList.Duplicate();
            FeePaymentTransferList.Duplicate();
            FeePaymentInvoiceInternalReceiptList.Duplicate();
            FeePaymentInvoiceList.Duplicate();
            FeePaymentItemList.Duplicate();
            FeePaymentInvoiceInList.Duplicate();
            FeePaymentFeeConfigList.Duplicate();
            DocumentEntryList.ForEach(a =>
                {
                    a.ACDocumentEntryAmount = 0;
                    a.ACDocumentEntryExchangeAmount = 0;
                });
            DocumentList.ForEach(a =>
                {
                    a.ACDocumentTotalAmount = 0;
                    a.ACDocumentExchangeAmount = 0;
                });
        }

        /// <summary>
        /// Update the inventory cost of receipted products due to fee changes
        /// </summary>
        /// <param name="receiptID">Receipt id</param>
        public void UpdateInventoryCost(int receiptID)
        {
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            APFeePaymentReceiptsController objFeePaymentReceiptsController = new APFeePaymentReceiptsController();

            BOSDbUtil dbUtil = new BOSDbUtil();

            List<ACDocumentsInfo> feePayments = objDocumentsController.GetFeePaymentsByReceiptID(receiptID);

            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            List<ACDocumentEntrysInfo> paymentEntryList = new List<ACDocumentEntrysInfo>();
            foreach (ACDocumentsInfo feePayment in feePayments)
            {
                List<ACDocumentEntrysInfo> entryList = objDocumentEntrysController.GetDocumentEntryByDocumentID(feePayment.ACDocumentID);
                foreach (var item in entryList)
                {
                    paymentEntryList.Add(item);
                }
            }

            decimal extCost = 0;
            Dictionary<int, object[]> list = new Dictionary<int, object[]>();
            int n1 = 1;
            foreach (ACDocumentsInfo feePayment in feePayments)
            {
                List<APFeePaymentReceiptsInfo> feePaymentReceipts = objFeePaymentReceiptsController.GetReceiptsByFeePaymentID(feePayment.ACDocumentID);

                foreach (APFeePaymentReceiptsInfo feePaymentReceipt in feePaymentReceipts)
                {
                    List<ICReceiptItemsInfo> receiptItemList = objReceiptItemsController.GetItemsByReceiptID(feePaymentReceipt.FK_ICReceiptID);
                    ICProductsController obj = new ICProductsController();
                    if (list.Where(p => p.Value[2].ToString() == feePaymentReceipt.FK_ICReceiptID.ToString()).Count() == 0)
                    {
                        foreach (var objReceiptItemsInfo in receiptItemList)
                        {
                            //TNDLoc 17/08/2016 lấy accountID theo receiptItem, START
                            //ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(objReceiptItemsInfo.FK_ICProductID);
                            //TNDLoc 17/08/2016 lấy accountID theo receiptItem, END
                            decimal price = objReceiptItemsInfo.ICReceiptItemInventoryCost * objReceiptItemsInfo.ICReceiptItemProductQty;
                            //ICReceiptItemProductUnitCost has minused discount
                            //price -= price * (objReceiptItemsInfo.ICReceiptItemProductDiscount / 100.0);

                            list.Add(n1++, new object[] {
                            //TNDLoc 17/08/2016 lấy accountID theo receiptItem, START
                            //objProductsInfo.FK_ACAccountID,
                            objReceiptItemsInfo.FK_ACAccountID,
                            //TNDLoc 17/08/2016 lấy accountID theo receiptItem, END
                            price * objReceiptItemsInfo.ICReceiptExchangeRate,
                            //price,
                            feePaymentReceipt.FK_ICReceiptID});
                        }
                    }
                }
            }
            decimal totalFee = 0;

            List<ICReceiptItemsInfo> items = objReceiptItemsController.GetItemsByReceiptID(receiptID);

            //get product's average price
            Dictionary<string, List<ICReceiptItemsInfo>> dictionary = new Dictionary<string, List<ICReceiptItemsInfo>>();
            Dictionary<string, object[]> dictionary1 = new Dictionary<string, object[]>();
            string key = string.Empty;
            decimal inventoryCost = 0;
            decimal quantity = 0;
            decimal productPrice = 0;
            //Update on-hand quantity
            foreach (ICReceiptItemsInfo item in items)
            {
                key = item.FK_ICProductID + "-" + item.FK_ICProductSerieID;
                if (!dictionary.Keys.Contains(key))
                    dictionary.Add(key, new List<ICReceiptItemsInfo>());
                dictionary[key].Add(item);
            }

            foreach (string key1 in dictionary.Keys)
            {
                quantity = 0;
                inventoryCost = 0;

                foreach (ICReceiptItemsInfo receiptItem in dictionary[key1])
                {
                    quantity += receiptItem.ICReceiptItemProductQty;

                    productPrice = receiptItem.ICReceiptItemProductQty * receiptItem.ICReceiptItemInventoryCost;
                    //ICReceiptItemProductUnitCost has minused discount
                    //productPrice -= productPrice * (receiptItem.ICReceiptItemProductDiscount / 100.0);
                    inventoryCost += productPrice * receiptItem.ICReceiptExchangeRate;
                    //inventoryCost += productPrice;
                }
                if (quantity != 0)
                    inventoryCost = (inventoryCost / quantity);
                dictionary1.Add(key1, new object[] { inventoryCost, quantity });
            }

            foreach (ICReceiptItemsInfo item in items)
            {
                ICProductsController obj = new ICProductsController();
                //TNDLoc 17/08/2016 lấy accountID theo receiptItem, START
                //ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(item.FK_ICProductID);
                //TNDLoc 17/08/2016 lấy accountID theo receiptItem, END
                extCost = 0;
                foreach (var i in list)
                {
                    //TNDLoc 17/08/2016 lấy accountID theo receiptItem, START
                    //if (int.Parse(i.Value[0].ToString()) == objProductsInfo.FK_ACAccountID)
                    //{
                    //    extCost += (decimal)i.Value[1];
                    //}
                    //TNDLoc 17/08/2016 lấy accountID theo receiptItem, END

                    if (int.Parse(i.Value[0].ToString()) == item.FK_ACAccountID)
                    {
                        extCost += (decimal)i.Value[1];
                    }
                }
                totalFee = 0;
                foreach (var i in paymentEntryList)
                {
                    //TNDLoc 17/08/2016 lấy accountID theo receiptItem, START
                    //if (i.FK_ACDebitAccountID == objProductsInfo.FK_ACAccountID)
                    //{
                    //    totalFee += i.ACDocumentEntryExchangeAmount;
                    //}
                    //TNDLoc 17/08/2016 lấy accountID theo receiptItem, END

                    if (i.FK_ACDebitAccountID == item.FK_ACAccountID)
                    {
                        totalFee += i.ACDocumentEntryExchangeAmount;
                    }
                }
                inventoryCost = 0;

                decimal price = item.ICReceiptItemInventoryCost * item.ICReceiptItemProductQty;
                //ICReceiptItemProductUnitCost has minused discount
                //price -= price * (item.ICReceiptItemProductDiscount / 100.0);

                price *= item.ICReceiptExchangeRate;
                quantity = item.ICReceiptItemProductQty;

                key = item.FK_ICProductID + "-" + item.FK_ICProductSerieID;
                if (dictionary1.Keys.Contains(key))
                {
                    price = decimal.Parse(dictionary1[key][0].ToString());
                    quantity = decimal.Parse(dictionary1[key][1].ToString());
                }

                if (price != 0 && quantity != 0)
                {
                    extCost = extCost == 0 ? 1 : price * quantity / extCost;
                    //decimal chiphisp = (totalFee * extCost) / item.ICReceiptItemProductQty;
                    decimal chiphisp = (totalFee * extCost) / quantity;
                    //chiphisp /= item.ICReceiptExchangeRate == 0 ? 1 : item.ICReceiptExchangeRate;
                    //inventoryCost = item.ICReceiptItemInventoryCost + chiphisp;
                    //inventoryCost *= item.ICReceiptExchangeRate;
                    inventoryCost = price + chiphisp;
                }

                //Update ICReceiptItemInventoryCost

                //item.ICReceiptItemInventoryCost = inventoryCost;

                //BOSApp.RoundByCurrency(item, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);

                //objReceiptItemsController.UpdateObject(item);

                //if (extCost > 0)
                //{
                //    decimal factor = (item.ICReceiptItemExtCost * item.ICReceiptExchangeRate) / extCost;
                //    if (item.ICReceiptItemProductQty > 0)
                //    {
                //        inventoryCost += (factor * totalFee) / item.ICReceiptItemProductQty;
                //    }
                //}
                List<ICInventoryStocksInfo> inventoryStocks = objInventoryStocksController.GetInventoryStocksByProductIDAndSerieID(
                                                                                                        item.FK_ICProductID,
                                                                                                        item.FK_ICProductSerieID);
                foreach (ICInventoryStocksInfo inventoryStock in inventoryStocks)
                {
                    TransactionUtil.UpdateInventoryCost(
                                                    inventoryStock.FK_ICProductID,
                                                    inventoryStock.FK_ICStockID,
                                                    inventoryStock.FK_ICProductSerieID,
                                                    inventoryCost);
                }

                if (item.FK_BRBranchID != BOSApp.CurrentCompanyInfo.FK_BRBranchID)
                {
                    TransactionUtil.UpdateInventoryAdjustment(item.FK_ICProductID, item.FK_ICStockID, item.FK_ICProductSerieID, inventoryCost);
                }

                //update relatived documents
                dbUtil.ExecuteNonQuery("UpdateInventoryCostForFeePayment", item.FK_ICProductID, item.FK_ICProductSerieID, inventoryCost, item.FK_ICReceiptID);
            }
        }
        public override bool CompleteTransaction()
        {
            ACDocumentsInfo document = (ACDocumentsInfo)MainObject;
            document.ACDocumentStatus = DocumentStatus.Complete.ToString();
            UpdateMainObject();
            return base.CompleteTransaction();
        }

        public void UpdateTransferInventoryCost(int TransferID)
        {
            ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            APFeePaymentTransfersController objFeePaymentTransfersController = new APFeePaymentTransfersController();

            BOSDbUtil dbUtil = new BOSDbUtil();

            List<ACDocumentsInfo> feePayments = objDocumentsController.GetFeePaymentsByTransferID(TransferID);

            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            List<ACDocumentEntrysInfo> paymentEntryList = new List<ACDocumentEntrysInfo>();
            foreach (ACDocumentsInfo feePayment in feePayments)
            {
                List<ACDocumentEntrysInfo> entryList = objDocumentEntrysController.GetDocumentEntryByDocumentID(feePayment.ACDocumentID);
                foreach (var item in entryList)
                {
                    paymentEntryList.Add(item);
                }
            }

            decimal extCost = 0;
            Dictionary<int, object[]> list = new Dictionary<int, object[]>();
            int n1 = 1;
            foreach (ACDocumentsInfo feePayment in feePayments)
            {
                List<APFeePaymentTransfersInfo> feePaymentTransfers = objFeePaymentTransfersController.GetTransfersByFeePaymentID(feePayment.ACDocumentID);

                foreach (APFeePaymentTransfersInfo feePaymentTransfer in feePaymentTransfers)
                {
                    List<ICTransferItemsInfo> TransferItemList = objTransferItemsController.GetItemsByTransferID(feePaymentTransfer.FK_ICTransferID);
                    ICProductsController obj = new ICProductsController();
                    if (list.Where(p => p.Value[2].ToString() == feePaymentTransfer.FK_ICTransferID.ToString()).Count() == 0)
                    {
                        foreach (var objTransferItemsInfo in TransferItemList)
                        {
                            //TNDLoc 17/08/2016 lấy accountID theo TransferItem, START
                            //ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(objTransferItemsInfo.FK_ICProductID);
                            //TNDLoc 17/08/2016 lấy accountID theo TransferItem, END
                            decimal price = objTransferItemsInfo.ICTransferItemProductUnitCost * objTransferItemsInfo.ICTransferItemProductQty;
                            //ICTransferItemProductUnitCost has minused discount
                            //price -= price * (objTransferItemsInfo.ICTransferItemProductDiscount / 100.0);

                            list.Add(n1++, new object[] {
                            //TNDLoc 17/08/2016 lấy accountID theo TransferItem, START
                            //objProductsInfo.FK_ACAccountID,
                            objTransferItemsInfo.FK_ACAccountID,
                            //TNDLoc 17/08/2016 lấy accountID theo TransferItem, END
                            price,
                            //price,
                            feePaymentTransfer.FK_ICTransferID});
                        }
                    }
                }
            }
            decimal totalFee = 0;

            List<ICTransferItemsInfo> items = objTransferItemsController.GetItemsByTransferID(TransferID);

            //get product's average price
            Dictionary<string, List<ICTransferItemsInfo>> dictionary = new Dictionary<string, List<ICTransferItemsInfo>>();
            Dictionary<string, object[]> dictionary1 = new Dictionary<string, object[]>();
            string key = string.Empty;
            decimal inventoryCost = 0;
            decimal quantity = 0;
            decimal productPrice = 0;
            //Update on-hand quantity
            foreach (ICTransferItemsInfo item in items)
            {
                key = item.FK_ICProductID + "-" + item.FK_ICProductSerieID;
                if (!dictionary.Keys.Contains(key))
                    dictionary.Add(key, new List<ICTransferItemsInfo>());
                dictionary[key].Add(item);
            }

            foreach (string key1 in dictionary.Keys)
            {
                quantity = 0;
                inventoryCost = 0;

                foreach (ICTransferItemsInfo TransferItem in dictionary[key1])
                {
                    quantity += TransferItem.ICTransferItemProductQty;

                    productPrice = TransferItem.ICTransferItemProductQty * TransferItem.ICTransferItemProductUnitCost;
                    //ICTransferItemProductUnitCost has minused discount
                    //productPrice -= productPrice * (TransferItem.ICTransferItemProductDiscount / 100.0);
                    inventoryCost += productPrice;
                    //inventoryCost += productPrice;
                }
                if (quantity != 0)
                    inventoryCost = (inventoryCost / quantity);
                dictionary1.Add(key1, new object[] { inventoryCost, quantity });
            }

            foreach (ICTransferItemsInfo item in items)
            {
                ICProductsController obj = new ICProductsController();
                //TNDLoc 17/08/2016 lấy accountID theo TransferItem, START
                //ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(item.FK_ICProductID);
                //TNDLoc 17/08/2016 lấy accountID theo TransferItem, END
                extCost = 0;
                foreach (var i in list)
                {
                    //TNDLoc 17/08/2016 lấy accountID theo TransferItem, START
                    //if (int.Parse(i.Value[0].ToString()) == objProductsInfo.FK_ACAccountID)
                    //{
                    //    extCost += (decimal)i.Value[1];
                    //}
                    //TNDLoc 17/08/2016 lấy accountID theo TransferItem, END

                    if (int.Parse(i.Value[0].ToString()) == item.FK_ACAccountID)
                    {
                        extCost += (decimal)i.Value[1];
                    }
                }
                totalFee = 0;
                foreach (var i in paymentEntryList)
                {
                    //TNDLoc 17/08/2016 lấy accountID theo TransferItem, START
                    //if (i.FK_ACDebitAccountID == objProductsInfo.FK_ACAccountID)
                    //{
                    //    totalFee += i.ACDocumentEntryExchangeAmount;
                    //}
                    //TNDLoc 17/08/2016 lấy accountID theo TransferItem, END

                    if (i.FK_ACDebitAccountID == item.FK_ACAccountID)
                    {
                        totalFee += i.ACDocumentEntryExchangeAmount;
                    }
                }
                inventoryCost = 0;

                decimal price = item.ICTransferItemProductUnitCost * item.ICTransferItemProductQty;
                //ICTransferItemProductUnitCost has minused discount
                //price -= price * (item.ICTransferItemProductDiscount / 100.0);

                //price *= item.ICTransferExchangeRate;
                quantity = item.ICTransferItemProductQty;

                key = item.FK_ICProductID + "-" + item.FK_ICProductSerieID;
                if (dictionary1.Keys.Contains(key))
                {
                    price = decimal.Parse(dictionary1[key][0].ToString());
                    quantity = decimal.Parse(dictionary1[key][1].ToString());
                }

                if (price != 0 && quantity != 0)
                {
                    extCost = extCost == 0 ? 1 : price * quantity / extCost;
                    //decimal chiphisp = (totalFee * extCost) / item.ICTransferItemProductQty;
                    decimal chiphisp = (totalFee * extCost) / quantity;
                    //chiphisp /= item.ICTransferExchangeRate == 0 ? 1 : item.ICTransferExchangeRate;
                    //inventoryCost = item.ICTransferItemInventoryCost + chiphisp;
                    //inventoryCost *= item.ICTransferExchangeRate;
                    inventoryCost = price + chiphisp;
                }

                //Update ICTransferItemInventoryCost

                //item.ICTransferItemInventoryCost = inventoryCost;

                //BOSApp.RoundByCurrency(item, BOSApp.CurrentCompanyInfo.FK_GECurrencyID);

                //objTransferItemsController.UpdateObject(item);

                //if (extCost > 0)
                //{
                //    decimal factor = (item.ICTransferItemExtCost * item.ICTransferExchangeRate) / extCost;
                //    if (item.ICTransferItemProductQty > 0)
                //    {
                //        inventoryCost += (factor * totalFee) / item.ICTransferItemProductQty;
                //    }
                //}
                List<ICInventoryStocksInfo> inventoryStocks = objInventoryStocksController.GetInventoryStocksByProductIDAndSerieID(
                                                                                                        item.FK_ICProductID,
                                                                                                        item.FK_ICProductSerieID);
                foreach (ICInventoryStocksInfo inventoryStock in inventoryStocks)
                {
                    TransactionUtil.UpdateInventoryCost(
                                                    inventoryStock.FK_ICProductID,
                                                    inventoryStock.FK_ICStockID,
                                                    inventoryStock.FK_ICProductSerieID,
                                                    inventoryCost);
                }

                //if (item.FK_BRBranchID != BOSApp.CurrentCompanyInfo.FK_BRBranchID)
                //{
                TransactionUtil.UpdateInventoryAdjustment(item.FK_ICProductID, item.FK_ICStockID, item.FK_ICProductSerieID, inventoryCost);
                // }

                //update relatived documents
                dbUtil.ExecuteNonQuery("UpdateInventoryCostForFeePayment", item.FK_ICProductID, item.FK_ICProductSerieID, inventoryCost, item.FK_ICTransferID);
            }
        }


        public void UpdateInvoiceInternalReceiptInventoryCost(int receiptID)
        {
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            APFeePaymentInvoiceInternalReceiptsController objFeePaymentReceiptsController = new APFeePaymentInvoiceInternalReceiptsController();

            BOSDbUtil dbUtil = new BOSDbUtil();

            List<ACDocumentsInfo> feePayments = objDocumentsController.GetFeePaymentsByInvoiceInternalReceiptID(receiptID);

            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            List<ACDocumentEntrysInfo> paymentEntryList = new List<ACDocumentEntrysInfo>();
            foreach (ACDocumentsInfo feePayment in feePayments)
            {
                List<ACDocumentEntrysInfo> entryList = objDocumentEntrysController.GetDocumentEntryByDocumentID(feePayment.ACDocumentID);
                foreach (var item in entryList)
                {
                    paymentEntryList.Add(item);
                }
            }

            decimal extCost = 0;
            Dictionary<int, object[]> list = new Dictionary<int, object[]>();
            int n1 = 1;
            foreach (ACDocumentsInfo feePayment in feePayments)
            {
                List<APFeePaymentInvoiceInternalReceiptsInfo> feePaymentReceipts = objFeePaymentReceiptsController.GetReceiptsByFeePaymentID(feePayment.ACDocumentID);

                foreach (APFeePaymentInvoiceInternalReceiptsInfo feePaymentReceipt in feePaymentReceipts)
                {
                    List<ICReceiptItemsInfo> receiptItemList = objReceiptItemsController.GetItemsByReceiptID(feePaymentReceipt.FK_ICInvoiceInternalReceiptID);
                    ICProductsController obj = new ICProductsController();
                    if (list.Where(p => p.Value[2].ToString() == feePaymentReceipt.FK_ICInvoiceInternalReceiptID.ToString()).Count() == 0)
                    {
                        foreach (var objReceiptItemsInfo in receiptItemList)
                        {
                            //TNDLoc 17/08/2016 lấy accountID theo receiptItem, START
                            //ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(objReceiptItemsInfo.FK_ICProductID);
                            //TNDLoc 17/08/2016 lấy accountID theo receiptItem, END
                            decimal price = objReceiptItemsInfo.ICReceiptItemInventoryCost * objReceiptItemsInfo.ICReceiptItemProductQty;
                            //ICReceiptItemProductUnitCost has minused discount
                            //price -= price * (objReceiptItemsInfo.ICReceiptItemProductDiscount / 100.0);

                            list.Add(n1++, new object[] {
                            //TNDLoc 17/08/2016 lấy accountID theo receiptItem, START
                            //objProductsInfo.FK_ACAccountID,
                            objReceiptItemsInfo.FK_ACAccountID,
                            //TNDLoc 17/08/2016 lấy accountID theo receiptItem, END
                            price * objReceiptItemsInfo.ICReceiptExchangeRate,
                            //price,
                            feePaymentReceipt.FK_ICInvoiceInternalReceiptID});
                        }
                    }
                }
            }
            decimal totalFee = 0;

            List<ICReceiptItemsInfo> items = objReceiptItemsController.GetItemsByReceiptID(receiptID);

            //get product's average price
            Dictionary<string, List<ICReceiptItemsInfo>> dictionary = new Dictionary<string, List<ICReceiptItemsInfo>>();
            Dictionary<string, object[]> dictionary1 = new Dictionary<string, object[]>();
            string key = string.Empty;
            decimal inventoryCost = 0;
            decimal quantity = 0;
            decimal productPrice = 0;
            //Update on-hand quantity
            foreach (ICReceiptItemsInfo item in items)
            {
                key = item.FK_ICProductID + "-" + item.FK_ICProductSerieID;
                if (!dictionary.Keys.Contains(key))
                    dictionary.Add(key, new List<ICReceiptItemsInfo>());
                dictionary[key].Add(item);
            }

            foreach (string key1 in dictionary.Keys)
            {
                quantity = 0;
                inventoryCost = 0;

                foreach (ICReceiptItemsInfo receiptItem in dictionary[key1])
                {
                    quantity += receiptItem.ICReceiptItemProductQty;

                    productPrice = receiptItem.ICReceiptItemProductQty * receiptItem.ICReceiptItemInventoryCost;
                    //ICReceiptItemProductUnitCost has minused discount
                    //productPrice -= productPrice * (receiptItem.ICReceiptItemProductDiscount / 100.0);
                    inventoryCost += productPrice * receiptItem.ICReceiptExchangeRate;
                    //inventoryCost += productPrice;
                }
                if (quantity != 0)
                    inventoryCost = (inventoryCost / quantity);
                dictionary1.Add(key1, new object[] { inventoryCost, quantity });
            }

            foreach (ICReceiptItemsInfo item in items)
            {
                ICProductsController obj = new ICProductsController();
                //TNDLoc 17/08/2016 lấy accountID theo receiptItem, START
                //ICProductsInfo objProductsInfo = (ICProductsInfo)obj.GetObjectByID(item.FK_ICProductID);
                //TNDLoc 17/08/2016 lấy accountID theo receiptItem, END
                extCost = 0;
                foreach (var i in list)
                {
                    //TNDLoc 17/08/2016 lấy accountID theo receiptItem, START
                    //if (int.Parse(i.Value[0].ToString()) == objProductsInfo.FK_ACAccountID)
                    //{
                    //    extCost += (decimal)i.Value[1];
                    //}
                    //TNDLoc 17/08/2016 lấy accountID theo receiptItem, END

                    if (int.Parse(i.Value[0].ToString()) == item.FK_ACAccountID)
                    {
                        extCost += (decimal)i.Value[1];
                    }
                }
                totalFee = 0;
                foreach (var i in paymentEntryList)
                {
                    //TNDLoc 17/08/2016 lấy accountID theo receiptItem, START
                    //if (i.FK_ACDebitAccountID == objProductsInfo.FK_ACAccountID)
                    //{
                    //    totalFee += i.ACDocumentEntryExchangeAmount;
                    //}
                    //TNDLoc 17/08/2016 lấy accountID theo receiptItem, END

                    if (i.FK_ACDebitAccountID == item.FK_ACAccountID)
                    {
                        totalFee += i.ACDocumentEntryExchangeAmount;
                    }
                }
                inventoryCost = 0;

                decimal price = item.ICReceiptItemInventoryCost * item.ICReceiptItemProductQty;
                //ICReceiptItemProductUnitCost has minused discount
                //price -= price * (item.ICReceiptItemProductDiscount / 100.0);

                price *= item.ICReceiptExchangeRate;
                quantity = item.ICReceiptItemProductQty;

                key = item.FK_ICProductID + "-" + item.FK_ICProductSerieID;
                if (dictionary1.Keys.Contains(key))
                {
                    price = decimal.Parse(dictionary1[key][0].ToString());
                    quantity = decimal.Parse(dictionary1[key][1].ToString());
                }

                if (price != 0 && quantity != 0)
                {
                    extCost = extCost == 0 ? 1 : price * quantity / extCost;
                    //decimal chiphisp = (totalFee * extCost) / item.ICReceiptItemProductQty;
                    decimal chiphisp = (totalFee * extCost) / quantity;
                    //chiphisp /= item.ICReceiptExchangeRate == 0 ? 1 : item.ICReceiptExchangeRate;
                    //inventoryCost = item.ICReceiptItemInventoryCost + chiphisp;
                    //inventoryCost *= item.ICReceiptExchangeRate;
                    inventoryCost = price + chiphisp;
                }

                List<ICInventoryStocksInfo> inventoryStocks = objInventoryStocksController.GetInventoryStocksByProductIDAndSerieID(
                                                                                                        item.FK_ICProductID,
                                                                                                        item.FK_ICProductSerieID);
                foreach (ICInventoryStocksInfo inventoryStock in inventoryStocks)
                {
                    TransactionUtil.UpdateInventoryCost(
                                                    inventoryStock.FK_ICProductID,
                                                    inventoryStock.FK_ICStockID,
                                                    inventoryStock.FK_ICProductSerieID,
                                                    inventoryCost);
                }

                if (item.FK_BRBranchID != BOSApp.CurrentCompanyInfo.FK_BRBranchID)
                {
                    TransactionUtil.UpdateInventoryAdjustment(item.FK_ICProductID, item.FK_ICStockID, item.FK_ICProductSerieID, inventoryCost);
                }

                //update relatived documents
                dbUtil.ExecuteNonQuery("UpdateInventoryCostForFeePayment", item.FK_ICProductID, item.FK_ICProductSerieID, inventoryCost, item.FK_ICReceiptID);
            }
        }
        #endregion

        #region Cập nhật theo công thức mới
        public void UpdateInventoryCostByReceipt()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            ACDocumentsInfo document = (ACDocumentsInfo)MainObject;
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            //Trừ lại
            if (FeePaymentItemList.BackupList != null)
            {
                foreach (APFeePaymentItemsInfo item in FeePaymentItemList.BackupList)
                {
                    decimal cost = Math.Round((item.APFeePaymentItemCostAttribution / item.APFeePaymentItemQty * document.ACDocumentExchangeRate), 0, MidpointRounding.AwayFromZero);
                    ICReceiptItemsInfo objReceiptItemsInfo = (ICReceiptItemsInfo)objReceiptItemsController.GetObjectByID(item.APFeePaymentItemReferenceItemID);
                    if (objReceiptItemsInfo != null)
                    {
                        List<ICInventoryStocksInfo> inventoryStocks = objInventoryStocksController.GetInventoryStocksByProductIDAndSerieNoAndStockID(
                                                                                                                             objReceiptItemsInfo.FK_ICProductID,
                                                                                                                             objReceiptItemsInfo.ICReceiptItemProductSerialNo,
                                                                                                                             objReceiptItemsInfo.FK_ICStockID);
                        foreach (ICInventoryStocksInfo inventoryStock in inventoryStocks)
                        {
                            decimal inventoryCost = Math.Round(inventoryStock.ICInventoryStockUnitCost - cost, 0, MidpointRounding.AwayFromZero);
                            TransactionUtil.UpdateInventoryCost(
                                                            inventoryStock.FK_ICProductID,
                                                            inventoryStock.FK_ICStockID,
                                                            inventoryStock.FK_ICProductSerieID,
                                                            inventoryCost);
                        }
                    }

                }
            }
            //Lưu mới
            foreach (APFeePaymentItemsInfo item in FeePaymentItemList)
            {
                decimal cost = Math.Round((item.APFeePaymentItemCostAttribution / item.APFeePaymentItemQty * document.ACDocumentExchangeRate), 0, MidpointRounding.AwayFromZero);
                ICReceiptItemsInfo objReceiptItemsInfo = (ICReceiptItemsInfo)objReceiptItemsController.GetObjectByID(item.APFeePaymentItemReferenceItemID);
                if (objReceiptItemsInfo != null)
                {
                    List<ICInventoryStocksInfo> inventoryStocks = objInventoryStocksController.GetInventoryStocksByProductIDAndSerieNoAndStockID(
                                                                                                                         objReceiptItemsInfo.FK_ICProductID,
                                                                                                                         objReceiptItemsInfo.ICReceiptItemProductSerialNo,
                                                                                                                         objReceiptItemsInfo.FK_ICStockID);
                    foreach (ICInventoryStocksInfo inventoryStock in inventoryStocks)
                    {
                        decimal inventoryCost = Math.Round(inventoryStock.ICInventoryStockUnitCost + cost, 0, MidpointRounding.AwayFromZero);
                        TransactionUtil.UpdateInventoryCost(
                                                        inventoryStock.FK_ICProductID,
                                                        inventoryStock.FK_ICStockID,
                                                        inventoryStock.FK_ICProductSerieID,
                                                        inventoryCost);
                        if (objReceiptItemsInfo.FK_BRBranchID != BOSApp.CurrentCompanyInfo.FK_BRBranchID)
                        {
                            TransactionUtil.UpdateInventoryAdjustment(objReceiptItemsInfo.FK_ICProductID, objReceiptItemsInfo.FK_ICStockID, objReceiptItemsInfo.FK_ICProductSerieID, inventoryCost);
                        }

                        //update relatived documents
                        dbUtil.ExecuteNonQuery("UpdateInventoryCostForFeePayment", objReceiptItemsInfo.FK_ICProductID, objReceiptItemsInfo.FK_ICProductSerieID, inventoryCost, objReceiptItemsInfo.FK_ICReceiptID);
                    }
                }

            }
        }

        public void UpdateInventoryCostByTransferReceipt()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            ACDocumentsInfo document = (ACDocumentsInfo)MainObject;
            ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            //Trừ lại
            if (FeePaymentItemList.BackupList != null)
            {
                foreach (APFeePaymentItemsInfo item in FeePaymentItemList.BackupList)
                {
                    decimal cost = Math.Round((item.APFeePaymentItemCostAttribution / item.APFeePaymentItemQty * document.ACDocumentExchangeRate), 0, MidpointRounding.AwayFromZero);
                    ICTransferItemsInfo objReceiptItemsInfo = (ICTransferItemsInfo)objTransferItemsController.GetObjectByID(item.APFeePaymentItemReferenceItemID);
                    if (objReceiptItemsInfo != null)
                    {
                        List<ICInventoryStocksInfo> inventoryStocks = objInventoryStocksController.GetInventoryStocksByProductIDAndSerieNoAndStockID(
                                                                                                                             objReceiptItemsInfo.FK_ICProductID,
                                                                                                                             objReceiptItemsInfo.ICTransferItemProductSerialNo,
                                                                                                                             objReceiptItemsInfo.FK_ICToStockID);
                        foreach (ICInventoryStocksInfo inventoryStock in inventoryStocks)
                        {
                            decimal inventoryCost = Math.Round(inventoryStock.ICInventoryStockUnitCost - cost, 0, MidpointRounding.AwayFromZero);
                            TransactionUtil.UpdateInventoryCost(
                                                            inventoryStock.FK_ICProductID,
                                                            inventoryStock.FK_ICStockID,
                                                            inventoryStock.FK_ICProductSerieID,
                                                            inventoryCost);
                        }
                    }

                }
            }
            //Lưu mới
            foreach (APFeePaymentItemsInfo item in FeePaymentItemList)
            {
                decimal cost = Math.Round((item.APFeePaymentItemCostAttribution / item.APFeePaymentItemQty * document.ACDocumentExchangeRate), 0, MidpointRounding.AwayFromZero);
                ICTransferItemsInfo objTransferItemsInfo = (ICTransferItemsInfo)objTransferItemsController.GetObjectByID(item.APFeePaymentItemReferenceItemID);
                if (objTransferItemsInfo != null)
                {
                    List<ICInventoryStocksInfo> inventoryStocks = objInventoryStocksController.GetInventoryStocksByProductIDAndSerieNoAndStockID(
                                                                                                                         objTransferItemsInfo.FK_ICProductID,
                                                                                                                         objTransferItemsInfo.ICTransferItemProductSerialNo,
                                                                                                                         objTransferItemsInfo.FK_ICToStockID);
                    foreach (ICInventoryStocksInfo inventoryStock in inventoryStocks)
                    {
                        decimal inventoryCost = Math.Round(inventoryStock.ICInventoryStockUnitCost + cost, 0, MidpointRounding.AwayFromZero);
                        TransactionUtil.UpdateInventoryCost(
                                                        inventoryStock.FK_ICProductID,
                                                        inventoryStock.FK_ICStockID,
                                                        inventoryStock.FK_ICProductSerieID,
                                                        inventoryCost);

                        TransactionUtil.UpdateInventoryAdjustment(objTransferItemsInfo.FK_ICProductID, objTransferItemsInfo.FK_ICToStockID, objTransferItemsInfo.FK_ICProductSerieID, inventoryCost);

                        //update relatived documents
                        dbUtil.ExecuteNonQuery("UpdateInventoryCostForFeePayment", objTransferItemsInfo.FK_ICProductID, objTransferItemsInfo.FK_ICProductSerieID, inventoryCost, objTransferItemsInfo.FK_ICTransferID);
                    }
                }


            }
        }
        #endregion

        #region Lấy dữ liệu cũ
        public List<APFeePaymentItemsInfo> GetValueFeePaymentItemByObjectID(int ObjectID)
        {
            List<APFeePaymentItemsInfo> feePaymentItemList = new List<APFeePaymentItemsInfo>();
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)objDocumentsController.GetObjectByID(ObjectID);
            if (objDocumentsInfo != null)
            {
                if (objDocumentsInfo.ACDocumentCreateFrom == DocumentCreateFrom.InvoiceIn.ToString())
                {
                    APInvoiceInItemsController invoiceInItemController = new APInvoiceInItemsController();
                    foreach (APFeePaymentInvoiceInsInfo invoiceIn in FeePaymentInvoiceInList)
                    {
                        DataSet dataInvoiceInItems = invoiceInItemController.GetInvoiceInItemByInvoiceInID(invoiceIn.FK_APInvoiceInID);
                        List<APInvoiceInItemsInfo> invoiceInItems = (List<APInvoiceInItemsInfo>)invoiceInItemController.GetListFromDataSet(dataInvoiceInItems);
                        APFeePaymentItemsInfo objFeePaymentItemsInfo;
                        foreach (APInvoiceInItemsInfo item in invoiceInItems)
                        {
                            objFeePaymentItemsInfo = new APFeePaymentItemsInfo();
                            objFeePaymentItemsInfo.FK_ICProductID = item.FK_ICProductID;
                            objFeePaymentItemsInfo.FK_ACAccountID = item.FK_ACAccountID;
                            objFeePaymentItemsInfo.FK_ACDocumentID = objDocumentsInfo.ACDocumentID;
                            objFeePaymentItemsInfo.APFeePaymentItemName = item.APInvoiceInItemProductDesc;
                            objFeePaymentItemsInfo.APFeePaymentItemQty = item.APInvoiceInItemProductQty;
                            objFeePaymentItemsInfo.APFeePaymentItemUnitCost = item.APInvoiceInItemProductUnitCost;
                            objFeePaymentItemsInfo.APFeePaymentItemTotalCost = item.APInvoiceInItemTotalCost;
                            objFeePaymentItemsInfo.APFeePaymentItemReferenceNo = invoiceIn.APInvoiceInNo;
                            objFeePaymentItemsInfo.APFeePaymentItemReferenceItemID = item.APInvoiceInItemID;
                            feePaymentItemList.Add(objFeePaymentItemsInfo);
                        }
                    }
                }
                else if (objDocumentsInfo.ACDocumentCreateFrom == DocumentCreateFrom.Invoice.ToString())
                {
                    ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
                    foreach (APFeePaymentInvoicesInfo invoice in FeePaymentInvoiceList)
                    {
                        List<ARInvoiceItemsInfo> items = objInvoiceItemsController.GetItemsByInvoiceID(invoice.FK_ARInvoiceID);
                        if (items != null && items.Count > 0)
                        {
                            APFeePaymentItemsInfo objFeePaymentItemsInfo;
                            foreach (ARInvoiceItemsInfo item in items)
                            {
                                objFeePaymentItemsInfo = new APFeePaymentItemsInfo();
                                objFeePaymentItemsInfo.FK_ICProductID = item.FK_ICProductID;
                                objFeePaymentItemsInfo.FK_ACAccountID = item.FK_ACAccountID;
                                objFeePaymentItemsInfo.FK_ACDocumentID = objDocumentsInfo.ACDocumentID;
                                objFeePaymentItemsInfo.APFeePaymentItemName = item.ARInvoiceItemProductDesc;
                                objFeePaymentItemsInfo.APFeePaymentItemQty = item.ARInvoiceItemProductQty;
                                objFeePaymentItemsInfo.APFeePaymentItemUnitCost = item.ARInvoiceItemProductUnitCost;
                                objFeePaymentItemsInfo.APFeePaymentItemTotalCost = item.ARInvoiceItemTotalCost;
                                objFeePaymentItemsInfo.APFeePaymentItemReferenceNo = invoice.ARInvoiceNo;
                                objFeePaymentItemsInfo.APFeePaymentItemReferenceItemID = item.ARInvoiceItemID;
                                feePaymentItemList.Add(objFeePaymentItemsInfo);
                            }
                        }
                    }
                }
                else if (objDocumentsInfo.ACDocumentCreateFrom == DocumentCreateFrom.InvoiceInternalReceipt.ToString())
                {
                    ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
                    foreach (APFeePaymentInvoiceInternalReceiptsInfo receipt in FeePaymentInvoiceInternalReceiptList)
                    {
                        List<ICReceiptItemsInfo> items = objReceiptItemsController.GetItemsByReceiptID(receipt.FK_ICInvoiceInternalReceiptID);
                        APFeePaymentItemsInfo objFeePaymentItemsInfo;
                        foreach (var item in items)
                        {
                            objFeePaymentItemsInfo = new APFeePaymentItemsInfo();
                            objFeePaymentItemsInfo.FK_ACAccountID = item.FK_ACAccountID;
                            objFeePaymentItemsInfo.FK_ICProductID = item.FK_ICProductID;
                            objFeePaymentItemsInfo.FK_ACDocumentID = objDocumentsInfo.ACDocumentID;
                            objFeePaymentItemsInfo.APFeePaymentItemName = item.ICReceiptItemProductDesc;
                            objFeePaymentItemsInfo.APFeePaymentItemQty = item.ICReceiptItemProductQty;
                            objFeePaymentItemsInfo.APFeePaymentItemUnitCost = item.ICReceiptItemProductUnitCost;
                            objFeePaymentItemsInfo.APFeePaymentItemTotalCost = item.ICReceiptItemTotalCost;
                            objFeePaymentItemsInfo.APFeePaymentItemReferenceNo = receipt.ICReceiptNo;
                            objFeePaymentItemsInfo.APFeePaymentItemReferenceItemID = item.Id;
                            feePaymentItemList.Add(objFeePaymentItemsInfo);
                        }
                    }
                }
                else if (objDocumentsInfo.ACDocumentCreateFrom == DocumentCreateFrom.TransferReceipt.ToString())
                {
                    ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
                    foreach (APFeePaymentTransfersInfo transfer in FeePaymentTransferList)
                    {
                        List<ICTransferItemsInfo> items = objTransferItemsController.GetItemsByTransferID(transfer.FK_ICTransferID);
                        APFeePaymentItemsInfo objFeePaymentItemsInfo;
                        foreach (var item in items)
                        {
                            objFeePaymentItemsInfo = new APFeePaymentItemsInfo();
                            objFeePaymentItemsInfo.FK_ACAccountID = item.FK_ACAccountID;
                            objFeePaymentItemsInfo.FK_ICProductID = item.FK_ICProductID;
                            objFeePaymentItemsInfo.FK_ACDocumentID = objDocumentsInfo.ACDocumentID;
                            objFeePaymentItemsInfo.APFeePaymentItemName = item.ICTransferItemProductDesc;
                            objFeePaymentItemsInfo.APFeePaymentItemQty = item.ICTransferItemProductQty;
                            objFeePaymentItemsInfo.APFeePaymentItemUnitCost = item.ICTransferItemProductUnitCost;
                            objFeePaymentItemsInfo.APFeePaymentItemTotalCost = objFeePaymentItemsInfo.APFeePaymentItemUnitCost * objFeePaymentItemsInfo.APFeePaymentItemTotalCost;
                            objFeePaymentItemsInfo.APFeePaymentItemReferenceNo = transfer.ICTransferNo;
                            objFeePaymentItemsInfo.APFeePaymentItemReferenceItemID = item.ICTransferItemID;
                            feePaymentItemList.Add(objFeePaymentItemsInfo);
                        }
                    }
                }
                else if (objDocumentsInfo.ACDocumentCreateFrom == DocumentCreateFrom.PurchaseReceipt.ToString())
                {
                    ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
                    foreach (APFeePaymentReceiptsInfo receipt in FeePaymentReceiptList)
                    {
                        List<ICReceiptItemsInfo> items = objReceiptItemsController.GetItemsByReceiptID(receipt.FK_ICReceiptID);
                        APFeePaymentItemsInfo objFeePaymentItemsInfo;
                        foreach (var item in items)
                        {
                            objFeePaymentItemsInfo = new APFeePaymentItemsInfo();
                            objFeePaymentItemsInfo.FK_ACAccountID = item.FK_ACAccountID;
                            objFeePaymentItemsInfo.FK_ICProductID = item.FK_ICProductID;
                            objFeePaymentItemsInfo.FK_ACDocumentID = objDocumentsInfo.ACDocumentID;
                            objFeePaymentItemsInfo.APFeePaymentItemName = item.ICReceiptItemProductDesc;
                            objFeePaymentItemsInfo.APFeePaymentItemQty = item.ICReceiptItemProductQty;
                            objFeePaymentItemsInfo.APFeePaymentItemUnitCost = item.ICReceiptItemProductUnitCost;
                            objFeePaymentItemsInfo.APFeePaymentItemTotalCost = item.ICReceiptItemTotalCost;
                            objFeePaymentItemsInfo.APFeePaymentItemReferenceNo = receipt.ICReceiptNo;
                            objFeePaymentItemsInfo.APFeePaymentItemReferenceItemID = item.Id;
                            feePaymentItemList.Add(objFeePaymentItemsInfo);
                        }
                    }
                }
            }
            return feePaymentItemList;
        }
        #endregion
    }

}
