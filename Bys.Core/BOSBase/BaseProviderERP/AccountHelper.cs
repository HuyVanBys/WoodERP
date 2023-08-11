using BOSCommon;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP
{
    public class AccountHelper
    {

        #region Utilities
        /// <summary>
        /// Get a document entry from a default one
        /// </summary>
        /// <param name="defaultEntry">Default entry</param>
        /// <returns>Document entry</returns>
        public static ACDocumentEntrysInfo GetDocumentEntryFromDefaultEntry(ACDocTypeEntrysInfo defaultEntry)
        {
            ACDocumentEntrysInfo entry = new ACDocumentEntrysInfo();
            entry.FK_ACDocumentTypeID = defaultEntry.FK_ACDocumentTypeID;
            entry.ACDocumentTypeName = defaultEntry.ACDocumentTypeName;
            entry.FK_ACEntryTypeID = defaultEntry.FK_ACEntryTypeID;
            entry.ACEntryTypeName = defaultEntry.ACEntryTypeName;
            entry.FK_ACCreditAccountID = defaultEntry.ACDocTypeEntryAccountDefaultCredit;
            entry.FK_ACDebitAccountID = defaultEntry.ACDocTypeEntryAccountDefaultDebit;
            entry.ACDocumentEntryDesc = defaultEntry.ACEntryTypeDesc;
            return entry;
        }

        /// <summary>
        /// Add the item to document entry list
        /// </summary>
        /// <param name="objDocTypeEntrysInfo">Given document type entry</param>
        /// <param name="documentEntryList">The current document entry list</param>        
        public static ACDocumentEntrysInfo AddItemToDocumentEntryList(ACDocTypeEntrysInfo objDocTypeEntrysInfo, List<ACDocumentEntrysInfo> documentEntryList)
        {
            ACDocumentEntrysInfo entry = AccountHelper.GetDocumentEntryFromDefaultEntry(objDocTypeEntrysInfo);
            documentEntryList.Add(entry);
            return entry;
        }
        public static ACDocumentEntrysInfo AddItemToDocumentEntryList(ACDocTypeEntrysInfo objDocTypeEntrysInfo)
        {
            ACDocumentEntrysInfo entry = AccountHelper.GetDocumentEntryFromDefaultEntry(objDocTypeEntrysInfo);
            //documentEntryList.Add(entry);
            return entry;
        }

        /// <summary>
        /// Set product with price level is regular
        /// </summary>
        /// <param name="entItem">Item of the invoice</param>
        /// <returns>Amout of product price regular</returns>
        private static decimal SetProductPriceRegular(ARInvoiceItemsInfo entItem)
        {
            return 0;
        }

        /// <summary>
        /// Check relative document exist in list or not
        /// </summary>
        /// <param name="objRelativeDocumentsInfo">Relative document info</param>
        /// <returns></returns>
        private static bool CheckExistRelativeDocument(ACRelativeDocumentsInfo objRelativeDocumentsInfo)
        {
            ACRelativeDocumentsController objRelativeDocumentsController = new ACRelativeDocumentsController();
            ACRelativeDocumentsInfo existingRelativeDocument = objRelativeDocumentsController.GetObjectByDocumentIDAndRelativeDocumentID(
                                                                                    objRelativeDocumentsInfo.FK_ACDocumentID,
                                                                                    objRelativeDocumentsInfo.FK_ACRelativeDocumentID);
            if (existingRelativeDocument != null)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Calculate
        /// <summary>
        /// Calculate cost of goods sold of a product
        /// </summary>
        /// <param name="stockID">Stock id</param>
        /// <param name="productID">Product id</param>
        /// <param name="serieID">Serie id</param>        
        /// <param name="fromDate">Start date of the report period</param>
        /// <param name="toDate">End date of the report period</param>
        /// <param name="documentDate">Document date</param>
        /// <returns>Cost of goods sold</returns>
        public static decimal CalculateGoodsSoldCost(int stockID, int productID, int serieID, DateTime fromDate, DateTime toDate, DateTime documentDate)
        {
            string costMethod = BOSApp.CurrentCompanyInfo.CSCostMethod;
            decimal unitCost = 0;
            if (costMethod == AccCostMethod.SpecificIdentification.ToString())
            {
                //  unitCost = GetInventoryCost(stockID, productID, serieID);
                unitCost = GetInventoryCostNotAcceptNull(stockID, productID, serieID);
            }
            else if (costMethod == AccCostMethod.ContinuousWeightedAverage.ToString())
            {
                ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
                ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
                DateTime prevPeriodEndDate = fromDate.AddDays(-1);
                decimal prevPeriodTotalCost = objInventoryStocksController.GetTotalInventoryCost(productID, null, prevPeriodEndDate);
                decimal prevPeriodTotalQty = objInventoryStocksController.GetTotalInventoryQty(productID, null, prevPeriodEndDate);
                decimal prevReceiptedTotalCost = objReceiptItemsController.GetTotalInventoryCostByProductIDAndDate(productID, fromDate, documentDate.AddDays(-1));
                decimal prevReceiptedTotalQty = objReceiptItemsController.GetTotalQtyByProductIDAndDate(productID, fromDate, documentDate.AddDays(-1));
                unitCost = (prevPeriodTotalCost + prevReceiptedTotalCost) / (prevPeriodTotalQty + prevReceiptedTotalQty);
            }
            else if (costMethod == AccCostMethod.PeriodicWeightedAverage.ToString())
            {
                ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
                ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
                DateTime prevPeriodEndDate = fromDate.AddDays(-1);
                decimal prevPeriodTotalCost = objInventoryStocksController.GetTotalInventoryCost(productID, null, prevPeriodEndDate);
                decimal prevPeriodTotalQty = objInventoryStocksController.GetTotalInventoryQty(productID, null, prevPeriodEndDate);
                decimal receiptedTotalCost = objReceiptItemsController.GetTotalInventoryCostByProductIDAndDate(productID, fromDate, toDate);
                decimal receiptedTotalQty = objReceiptItemsController.GetTotalQtyByProductIDAndDate(productID, fromDate, toDate);
                unitCost = (prevPeriodTotalCost + receiptedTotalCost) / (prevPeriodTotalQty + receiptedTotalQty);
            }
            return unitCost;
        }

        ///// <summary>
        ///// Get the inventory cost of a product
        ///// </summary>
        ///// <param name="stockID">Stock id</param>
        ///// <param name="productID">Product id</param>
        ///// <param name="serieID">Serie id</param>
        //public static decimal GetInventoryCost(int stockID, int productID, int serieID)
        //{
        //    decimal inventoryCost = 0;
        //    ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
        //    ICInventoryStocksInfo objInventoryStocksInfo = objInventoryStocksController.GetInventoryStockByStockIDAndProductIDAndSerieID(stockID, productID, serieID);
        //    if (objInventoryStocksInfo != null)
        //    {
        //        inventoryCost = objInventoryStocksInfo.ICInventoryStockUnitCost;
        //    }
        //    return inventoryCost;
        //}

        public static decimal GetInventoryCost(int stockID, int productID, string productSerieNo, DateTime toDate)
        {
            return GetProductUnitCost(stockID, productID, productSerieNo, toDate);
        }

        public static decimal GetInventoryCostNotAcceptNull(int stockID, int productID, int serieID)
        {
            decimal inventoryCost = 0;
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            ICInventoryStocksInfo objInventoryStocksInfo = objInventoryStocksController.GetInventoryStockByStockIDAndProductIDAndSerieID(stockID, productID, serieID);
            if (objInventoryStocksInfo != null)
            {
                inventoryCost = objInventoryStocksInfo.ICInventoryStockUnitCost;
            }
            else
            {
                inventoryCost = decimal.MinValue;
            }
            return inventoryCost;
        }

        /// <summary>
        /// Get the inventory cost of a product
        /// </summary>        
        /// <param name="productID">Product id</param>
        /// <param name="serieID">Serie id</param>
        public static decimal GetInventoryCost(int productID, int serieID)
        {
            decimal inventoryCost = 0;
            if (serieID > 0)
            {
                ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
                List<ICInventoryStocksInfo> inventoryStocks = objInventoryStocksController.GetInventoryStocksByProductIDAndSerieID(productID, serieID);
                if (inventoryStocks.Count > 0)
                {
                    inventoryCost = inventoryStocks.Max(i => i.ICInventoryStockUnitCost);
                }
            }
            return inventoryCost;
        }

        ///// <summary>
        ///// Calculate stock price
        ///// </summary>
        ///// <returns>Stock price</returns>
        //public static decimal CalculateStockPrice()
        //{
        //    return 0;
        //}

        ///// <summary>
        ///// Calculate the sales income 
        ///// </summary>
        ///// <param name="objInvoicesInfo">Info of the invoice</param>
        ///// <returns>Income</returns>
        //public static decimal CalculateIncome(ARInvoicesInfo objInvoicesInfo)
        //{
        //    return objInvoicesInfo.ARInvoiceTotalAmount;
        //}

        ///// <summary>
        ///// Calculate discount
        ///// </summary>
        ///// <param name="objInvoicesInfo">Info of the Invoice</param>
        ///// <returns>Discount</returns>
        //public static decimal CalculateDiscount(ARInvoicesInfo objInvoicesInfo)
        //{
        //    decimal discountAmountTotal = 0;
        //    ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
        //    DataSet ds = objInvoiceItemsController.GetAllDataByForeignColumn("FK_ARInvoiceID", objInvoicesInfo.ARInvoiceID);
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        foreach (DataRow row in ds.Tables[0].Rows)
        //        {
        //            ARInvoiceItemsInfo objInvoiceItemsInfo = (ARInvoiceItemsInfo)objInvoiceItemsController.GetObjectFromDataRow(row);
        //            discountAmountTotal += objInvoiceItemsInfo.ARInvoiceItemDiscountAmount;
        //        }
        //    }
        //    discountAmountTotal += objInvoicesInfo.ARInvoiceDiscountFix;
        //    return discountAmountTotal;
        //}

        ///// <summary>
        ///// Total price difference compared to regular price
        ///// </summary>
        ///// <param name="entity">Current module entity</param>
        ///// <param name="invoiceItemList">The list of the invoice item</param>
        ///// <returns>Price deduct</returns>
        //public static decimal CalculatePriceDeduct(ERPModuleEntities entity, List<ARInvoiceItemsInfo> invoiceItemList)
        //{
        //    decimal priceDeduct = 0;
        //    ARPriceLevelsController objPriceLevelsController = new ARPriceLevelsController();
        //    int priceLevelID = objPriceLevelsController.GetObjectIDByNo(PriceLevel.Regular.ToString());
        //    ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)entity.MainObject;
        //    if (objInvoicesInfo.FK_ARPriceLevelID != priceLevelID)
        //    {
        //        decimal currentAmoutTotal = objInvoicesInfo.ARInvoiceTotalAmount;
        //        //Calculate price regular
        //        if (invoiceItemList.Count > 0)
        //        {
        //            objInvoicesInfo.ARInvoiceSubTotalAmount = 0;
        //            foreach (ARInvoiceItemsInfo entItem in invoiceItemList)
        //            {

        //                SetProductPriceRegular(entItem);
        //                objInvoicesInfo.ARInvoiceSubTotalAmount += entItem.ARInvoiceItemTotalAmount;
        //            }
        //            objInvoicesInfo.ARInvoiceDiscountFix = objInvoicesInfo.ARInvoiceSubTotalAmount * objInvoicesInfo.ARInvoiceDiscountPerCent / 100;
        //            decimal regularAmountTotal = objInvoicesInfo.ARInvoiceSubTotalAmount - objInvoicesInfo.ARInvoiceDiscountFix;
        //            priceDeduct = regularAmountTotal - currentAmoutTotal;
        //        }
        //    }
        //    return priceDeduct;
        //}

        ///// <summary>
        ///// Calculate tax
        ///// </summary>
        ///// <param name="objInvoicesInfo">Info of the Invoice</param>
        ///// <returns>Tax</returns>
        //public static decimal CalculateTax(ARInvoicesInfo objInvoicesInfo)
        //{
        //    return objInvoicesInfo.ARInvoiceTaxAmount;
        //}

        ///// <summary>
        ///// Calculate return discount
        ///// </summary>
        ///// <param name="objInvoicesInfo">Info of the Invoice</param>
        ///// <returns>Return discount</returns>
        //public static decimal CalculateReturnDiscount(ARInvoicesInfo objInvoicesInfo)
        //{
        //    return 0;
        //}

        ///// <summary>
        ///// Calculate return discount
        ///// </summary>
        ///// <param name="objInvoicesInfo">Info of the sale return</param>
        ///// <returns>Return discount</returns>
        //public static decimal CalculateReturnDiscount(ARSaleReturnsInfo objSaleReturnsInfo)
        //{
        //    return 0;
        //}

        ///// <summary>
        ///// Calculate payment term
        ///// </summary>
        ///// <param name="invoiceList">The invoice list</param>
        ///// <returns>return payment term</returns>
        //public static decimal CalculatePaymentTerm(List<ARInvoicesInfo> invoiceList)
        //{
        //    return 0;
        //}

        public static decimal GetProductUnitCost(int stockID, int productID, string productSerieNo, DateTime toDate)
        {
            ICTransactionsController controller = new ICTransactionsController();
            return controller.GetProductUnitCost(stockID, productID, productSerieNo, toDate);
        }
        #endregion
    }
}
