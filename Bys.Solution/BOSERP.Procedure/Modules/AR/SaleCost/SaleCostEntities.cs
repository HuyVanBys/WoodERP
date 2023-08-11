using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.SaleCost
{
    public class SaleCostEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        /// <summary>
        /// Gets or sets the list of receipts whose fee is paid by the payment
        /// </summary>
        public BOSList<APFeePaymentInvoicesInfo> FeePaymentInvoiceList { get; set; }
        public BOSList<APFeePaymentFeeConfigsInfo> FeePaymentFeeConfigList { get; set; }
        public BOSList<ARFeePaymentCommissionsInfo> FeePaymentCommissionList { get; set; }
        #endregion

        #region Constructor
        public SaleCostEntities()
            : base()
        {
            FeePaymentInvoiceList = new BOSList<APFeePaymentInvoicesInfo>();
            FeePaymentFeeConfigList = new BOSList<APFeePaymentFeeConfigsInfo>();
            FeePaymentCommissionList = new BOSList<ARFeePaymentCommissionsInfo>();
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
            ModuleObjects.Add(TableName.APFeePaymentFeeConfigsTableName, new APFeePaymentFeeConfigsInfo());
            ModuleObjects.Add(TableName.ARFeePaymentCommissionsTableName, new ARFeePaymentCommissionsInfo());
        }

        public override void InitModuleObjectList()
        {
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

            FeePaymentCommissionList.InitBOSList(this,
                                                TableName.ACDocumentsTableName,
                                                TableName.ARFeePaymentCommissionsTableName,
                                                BOSList<ARFeePaymentCommissionsInfo>.cstRelationForeign);
            FeePaymentCommissionList.ItemTableForeignKey = "FK_ACDocumentID";
        }

        public override void InitGridControlInBOSList()
        {
            DocumentEntryList.InitBOSListGridControl(SaleCostModule.DocumentEntryGridControlName);
            FeePaymentInvoiceList.InitBOSListGridControl(SaleCostModule.FeePaymentInvoiceGridControlName);
            FeePaymentFeeConfigList.InitBOSListGridControl();
            FeePaymentCommissionList.InitBOSListGridControl(SaleCostModule.FeePaymentCommissionGridControlName);
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)MainObject;
            objDocumentsInfo.ACDocumentDate = DateTime.Now;
            objDocumentsInfo.FK_ACDocumentTypeID = ((SaleCostModule)Module).GetDocumentTypeID();
            objDocumentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GEPurchaseCurrencyID;
            objDocumentsInfo.ACDocumentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanyPurchaseExchangeRate;
            objDocumentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                FeePaymentInvoiceList.SetDefaultListAndRefreshGridControl();
                FeePaymentFeeConfigList.SetDefaultListAndRefreshGridControl();
                FeePaymentCommissionList.SetDefaultListAndRefreshGridControl();
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
            ACDocumentsInfo mainObject = (ACDocumentsInfo)MainObject;
            APFeePaymentInvoicesController iController = new APFeePaymentInvoicesController();
            List<APFeePaymentInvoicesInfo> iList = iController.GetInvoicesByFeePaymentID(iObjectID);
            FeePaymentInvoiceList.Invalidate(iList);

            FeePaymentFeeConfigList.Invalidate(iObjectID);
            FeePaymentFeeConfigList.ForEach(o => o.ACObjectAccessKey = o.FK_ACObjectID + ";" + o.APObjectType);

            FeePaymentCommissionList.Invalidate(iObjectID);
            FeePaymentCommissionList.ForEach(o =>
            {
                o.ACObjectAccessKey = mainObject.FK_ACObjectID + ";" + mainObject.ACObjectType;
                o.FK_GECurrencyID = mainObject.FK_GECurrencyID;
            });
        }
        #endregion

        #region Save Module Objects and Main Object functions
        public override int SaveMainObject()
        {
            ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)MainObject;
            objDocumentsInfo.ACDocumentTotalAmount = FeePaymentFeeConfigList.Sum(o => o.APFeePaymentFeeConfigTotalAmount);
            objDocumentsInfo.ACDocumentExchangeAmount = objDocumentsInfo.ACDocumentTotalAmount * objDocumentsInfo.ACDocumentExchangeRate;
            objDocumentsInfo.ACVATDocumentType = objDocumentsInfo.ACVATDocumentTypeFeePayment;
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {
            CreateOrUpdatePaymentDetail();
            FeePaymentFeeConfigList.SaveItemObjects();
            FeePaymentInvoiceList.SaveItemObjects();
            FeePaymentCommissionList.SaveItemObjects();
        }

        public override void DuplicateModuleObjectList()
        {
            FeePaymentFeeConfigList.Duplicate();
            DocumentList.ForEach(a =>
                {
                    a.ACDocumentTotalAmount = 0;
                    a.ACDocumentExchangeAmount = 0;
                });
        }

        public void CreateOrUpdatePaymentDetail()
        {
            ACDocumentsInfo document = (ACDocumentsInfo)MainObject;
            APPOPaymentTimeInvoiceInDetailsController detailController = new APPOPaymentTimeInvoiceInDetailsController();
            detailController.ClearExistedDetailOfDocument(document.ACDocumentID);

            List<APPOPaymentTimeInvoiceInDetailsInfo> pOPaymentTimeInvoiceInDetailList = GeneratePOPaymentTimeInvoiceInDetailList();
            if (pOPaymentTimeInvoiceInDetailList.Count > 0)
            {
                BOSList<APPOPaymentTimeInvoiceInDetailsInfo> pOPaymentTimeInvoiceInDetails = new BOSList<APPOPaymentTimeInvoiceInDetailsInfo>("APPOPaymentTimeInvoiceInDetails");
                pOPaymentTimeInvoiceInDetails.Invalidate(pOPaymentTimeInvoiceInDetailList);
                pOPaymentTimeInvoiceInDetails.SaveItemObjects();
            }
        }

        public List<APPOPaymentTimeInvoiceInDetailsInfo> GeneratePOPaymentTimeInvoiceInDetailList()
        {
            ACDocumentsInfo document = (ACDocumentsInfo)MainObject;
            List<APPOPaymentTimeInvoiceInDetailsInfo> pOPaymentTimeInvoiceInDetails = new List<APPOPaymentTimeInvoiceInDetailsInfo>();
            APPOPaymentTimeInvoiceInDetailsInfo detail = new APPOPaymentTimeInvoiceInDetailsInfo();
            detail.APPOPaymentTimeInvoiceInDetailAmount = document.ACDocumentExchangeAmount;
            detail.APPOPaymentTimeInvoiceInDetailBalanceDue = document.ACDocumentExchangeAmount;
            detail.APPOPaymentTimeInvoiceInDetailDate = document.ACDocumentInvoiceDate;
            detail.APPOPaymentTimeInvoiceInDetailEndDate = document.ACDocumentPaymentDueDate;
            detail.FK_ACDocumentID = document.ACDocumentID;
            pOPaymentTimeInvoiceInDetails.Add(detail);
            return pOPaymentTimeInvoiceInDetails;
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
                            decimal price = objReceiptItemsInfo.ICReceiptItemInventoryCost * objReceiptItemsInfo.ICReceiptItemProductQty;
                            list.Add(n1++, new object[] {
                            objReceiptItemsInfo.FK_ACAccountID,
                            price * objReceiptItemsInfo.ICReceiptExchangeRate,
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
                    inventoryCost += productPrice * receiptItem.ICReceiptExchangeRate;
                }
                if (quantity != 0)
                    inventoryCost = (inventoryCost / quantity);
                dictionary1.Add(key1, new object[] { inventoryCost, quantity });
            }

            foreach (ICReceiptItemsInfo item in items)
            {
                ICProductsController obj = new ICProductsController();

                extCost = 0;
                foreach (var i in list)
                {

                    if (int.Parse(i.Value[0].ToString()) == item.FK_ACAccountID)
                    {
                        extCost += (decimal)i.Value[1];
                    }
                }
                totalFee = 0;
                foreach (var i in paymentEntryList)
                {


                    if (i.FK_ACDebitAccountID == item.FK_ACAccountID)
                    {
                        totalFee += i.ACDocumentEntryExchangeAmount;
                    }
                }
                inventoryCost = 0;

                decimal price = item.ICReceiptItemInventoryCost * item.ICReceiptItemProductQty;

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

                    decimal chiphisp = (totalFee * extCost) / quantity;

                    inventoryCost = price + chiphisp;
                }
                if (item.FK_BRBranchID != BOSApp.CurrentCompanyInfo.FK_BRBranchID)
                {
                    TransactionUtil.UpdateInventoryAdjustment(item.FK_ICProductID, item.FK_ICStockID, item.FK_ICProductSerieID, inventoryCost);
                }

                dbUtil.ExecuteNonQuery("UpdateInventoryCostForFeePayment", item.FK_ICProductID, item.FK_ICProductSerieID, inventoryCost, item.FK_ICReceiptID);
            }
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
                            decimal price = objTransferItemsInfo.ICTransferItemProductUnitCost * objTransferItemsInfo.ICTransferItemProductQty;
                            list.Add(n1++, new object[] {
                            objTransferItemsInfo.FK_ACAccountID,
                            price,
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

                    inventoryCost += productPrice;
                }
                if (quantity != 0)
                    inventoryCost = (inventoryCost / quantity);
                dictionary1.Add(key1, new object[] { inventoryCost, quantity });
            }

            foreach (ICTransferItemsInfo item in items)
            {
                ICProductsController obj = new ICProductsController();

                extCost = 0;
                foreach (var i in list)
                {


                    if (int.Parse(i.Value[0].ToString()) == item.FK_ACAccountID)
                    {
                        extCost += (decimal)i.Value[1];
                    }
                }
                totalFee = 0;
                foreach (var i in paymentEntryList)
                {

                    if (i.FK_ACDebitAccountID == item.FK_ACAccountID)
                    {
                        totalFee += i.ACDocumentEntryExchangeAmount;
                    }
                }
                inventoryCost = 0;

                decimal price = item.ICTransferItemProductUnitCost * item.ICTransferItemProductQty;

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

                    decimal chiphisp = (totalFee * extCost) / quantity;

                    inventoryCost = price + chiphisp;
                }


                TransactionUtil.UpdateInventoryAdjustment(item.FK_ICProductID, item.FK_ICStockID, item.FK_ICProductSerieID, inventoryCost);

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
                            decimal price = objReceiptItemsInfo.ICReceiptItemInventoryCost * objReceiptItemsInfo.ICReceiptItemProductQty;
                            list.Add(n1++, new object[] {

                            objReceiptItemsInfo.FK_ACAccountID,
                            price * objReceiptItemsInfo.ICReceiptExchangeRate,
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

                    inventoryCost += productPrice * receiptItem.ICReceiptExchangeRate;
                }
                if (quantity != 0)
                    inventoryCost = (inventoryCost / quantity);
                dictionary1.Add(key1, new object[] { inventoryCost, quantity });
            }

            foreach (ICReceiptItemsInfo item in items)
            {
                ICProductsController obj = new ICProductsController();
                extCost = 0;
                foreach (var i in list)
                {
                    if (int.Parse(i.Value[0].ToString()) == item.FK_ACAccountID)
                    {
                        extCost += (decimal)i.Value[1];
                    }
                }
                totalFee = 0;
                foreach (var i in paymentEntryList)
                {
                    if (i.FK_ACDebitAccountID == item.FK_ACAccountID)
                    {
                        totalFee += i.ACDocumentEntryExchangeAmount;
                    }
                }
                inventoryCost = 0;

                decimal price = item.ICReceiptItemInventoryCost * item.ICReceiptItemProductQty;

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
                    decimal chiphisp = (totalFee * extCost) / quantity;
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
    }
}
