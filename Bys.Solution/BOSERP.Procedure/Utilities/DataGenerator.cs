using BOSCommon;
using BOSLib;
using System;
using System.Collections.Generic;

namespace BOSERP
{
    public class DataGenerator
    {
        /// <summary>
        /// Generate an invoice from a given sale order
        /// </summary>
        /// <param name="objSaleOrdersInfo">Given sale order</param>
        /// <returns>Generated invoice</returns>
        public static ARInvoicesInfo GenerateInvoiceFromSaleOrder(ARSaleOrdersInfo objSaleOrdersInfo)
        {
            ARInvoicesInfo objInvoicesInfo = new ARInvoicesInfo();
            BOSUtil.CopyObject(objSaleOrdersInfo, objInvoicesInfo);

            //Set own properties of invoice
            objInvoicesInfo.AACreatedUser = BOSApp.CurrentUser;
            objInvoicesInfo.AACreatedDate = DateTime.Now;
            objInvoicesInfo.ARInvoiceDeliveryDate = DateTime.Now;
            objInvoicesInfo.ARInvoiceValidateDate = DateTime.Now;
            objInvoicesInfo.ARInvoiceReference = objSaleOrdersInfo.ARSaleOrderNo;
            objInvoicesInfo.ARInvoiceStatus = InvoiceStatus.Complete.ToString();
            objInvoicesInfo.ARInvoiceDepositBalance = objSaleOrdersInfo.ARSaleOrderDepositBalance;
            objInvoicesInfo.ARInvoiceBalanceDue = objSaleOrdersInfo.ARSaleOrderBalanceDue;
            if (BOSApp.CurrentCompanyInfo != null)
                objInvoicesInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            return objInvoicesInfo;
        }

        /// <summary>
        /// Generate a list of invoice items from a given list of sale order items
        /// </summary>
        /// <param name="saleOrderItemList">Given list of sale order items</param>
        /// <returns>Generated list of invoice items</returns>
        public static List<ARInvoiceItemsInfo> GenerateInvoiceItemsFromSaleOrderItems(
                                                                    List<ARSaleOrderItemsInfo> saleOrderItemList)
        {
            return new List<ARInvoiceItemsInfo>();
        }

        /// <summary>
        /// Generate a shipment from a given invoice
        /// </summary>
        /// <param name="objInvoicesInfo">Given invoice</param>
        /// <returns>Generated shipment</returns>
        public static ICShipmentsInfo GenerateShipmentFromInvoice(ARInvoicesInfo objInvoicesInfo)
        {
            ICShipmentsInfo objShipmentsInfo = new ICShipmentsInfo();
            BOSUtil.CopyObject(objInvoicesInfo, objShipmentsInfo);

            //Set own properties of shipment
            objShipmentsInfo.AACreatedUser = BOSApp.CurrentUser;
            objShipmentsInfo.AACreatedDate = DateTime.Now;
            objShipmentsInfo.FK_ACObjectID = objInvoicesInfo.FK_ARCustomerID;
            objShipmentsInfo.ICObjectType = ObjectType.Customer.ToString();
            objShipmentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objShipmentsInfo.ICShipmentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objShipmentsInfo.ICShipmentDeliveryDate = DateTime.Now;
            objShipmentsInfo.ICShipmentValidateDate = DateTime.Now;
            objShipmentsInfo.ICShipmentTypeCombo = ShipmentType.SaleShipment.ToString();
            objShipmentsInfo.ICShipmentReference = objInvoicesInfo.ARInvoiceNo;
            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.Complete.ToString();
            objShipmentsInfo.ICShipmentSubTotalAmount = 0;
            objShipmentsInfo.ICShipmentDiscountFix = 0;
            objShipmentsInfo.ICShipmentTaxAmount = 0;
            objShipmentsInfo.ICShipmentTotalAmount = 0;
            return objShipmentsInfo;
        }

        /// <summary>
        /// Generate a list of shipment items from a given list of invoice items
        /// </summary>        
        /// <param name="invoiceItemList">Given list of invoice items</param>
        /// <returns>Generated list of shipment items</returns>
        public static List<ICShipmentItemsInfo> GenerateShipmentItemsFromInvoiceItems(List<ARInvoiceItemsInfo> invoiceItemList)
        {
            List<ICShipmentItemsInfo> shipmentItemList = new List<ICShipmentItemsInfo>();
            foreach (ARInvoiceItemsInfo invoiceItem in invoiceItemList)
            {
                ICShipmentItemsInfo shipmentItem = new ICShipmentItemsInfo();
                BOSUtil.CopyObject(invoiceItem, shipmentItem);
                shipmentItem.FK_ACAccountID = invoiceItem.FK_ACAccountID;
                shipmentItem.FK_ARInvoiceID = invoiceItem.FK_ARInvoiceID;
                shipmentItem.FK_ARInvoiceItemID = invoiceItem.ARInvoiceItemID;
                shipmentItem.ICShipmentItemProductQty = invoiceItem.ARInvoiceItemProductQty;
                shipmentItem.ICShipmentItemProductUnitPrice = invoiceItem.ARInvoiceItemProductUnitCost;
                shipmentItem.ICShipmentItemPrice = shipmentItem.ICShipmentItemProductUnitPrice * shipmentItem.ICShipmentItemProductQty;
                shipmentItem.ICShipmentItemDiscountAmount = 0;
                shipmentItem.ICShipmentItemTaxAmount = 0;
                shipmentItem.ICShipmentItemTotalAmount = shipmentItem.ICShipmentItemPrice;
                shipmentItemList.Add(shipmentItem);
            }
            return shipmentItemList;
        }

        /// <summary>
        /// Generate open document from sale order
        /// </summary>
        /// <param name="objSaleOrdersInfo">Info of sale order</param>
        /// <returns>Info of open document</returns>
        public static AROpenDocumentsInfo GenerateOpenDocumentFromSaleOrder(ARSaleOrdersInfo objSaleOrdersInfo)
        {
            AROpenDocumentsInfo objOpenDocumentsInfo = new AROpenDocumentsInfo();
            BOSUtil.CopyObject(objSaleOrdersInfo, objOpenDocumentsInfo);
            objOpenDocumentsInfo.AACreatedUser = BOSApp.CurrentUser;
            objOpenDocumentsInfo.AACreatedDate = DateTime.Now;
            objOpenDocumentsInfo.AROpenDocumentNo = objSaleOrdersInfo.ARSaleOrderNo;
            return objOpenDocumentsInfo;
        }

        /// <summary>
        /// Generate open document from a purchase order
        /// </summary>
        /// <param name="objPurchaseOrdersInfo">Purchase order object</param>
        /// <returns>Open document object</returns>
        public static APOpenDocumentsInfo GenerateOpenDocumentFromPurchaseOrder(APPurchaseOrdersInfo objPurchaseOrdersInfo)
        {
            APOpenDocumentsInfo objOpenDocumentsInfo = new APOpenDocumentsInfo();
            BOSUtil.CopyObject(objPurchaseOrdersInfo, objOpenDocumentsInfo);
            objOpenDocumentsInfo.AACreatedUser = BOSApp.CurrentUser;
            objOpenDocumentsInfo.AACreatedDate = DateTime.Now;
            return objOpenDocumentsInfo;
        }

        /// <summary>
        /// Generate a receipt from a sale return
        /// </summary>
        /// <param name="objSaleReturnsInfo">Given Sale return</param>
        /// <returns>Generated receipt</returns>
        public static ICReceiptsInfo GenerateReceiptFromSaleReturn(ARSaleReturnsInfo objSaleReturnsInfo)
        {
            ICReceiptsInfo objReceiptsInfo = new ICReceiptsInfo();
            BOSUtil.CopyObject(objSaleReturnsInfo, objReceiptsInfo);

            //Set own properties of receipt
            objReceiptsInfo.AACreatedUser = BOSApp.CurrentUser;
            objReceiptsInfo.AACreatedDate = DateTime.Now;
            objReceiptsInfo.FK_ACObjectID = objSaleReturnsInfo.FK_ARCustomerID;
            objReceiptsInfo.ICObjectType = ObjectType.Customer.ToString();
            objReceiptsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objReceiptsInfo.ICReceiptExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objReceiptsInfo.ICReceiptTypeCombo = ReceiptType.ReturnReceipt.ToString();
            objReceiptsInfo.ICReceiptStatus = ReceiptStatus.Complete.ToString();
            objReceiptsInfo.ICReceiptReference = objSaleReturnsInfo.ARSaleReturnNo;
            objReceiptsInfo.ICReceiptSubTotalCost = 0;
            objReceiptsInfo.ICReceiptDiscountFix = 0;
            objReceiptsInfo.ICReceiptTaxAmount = 0;
            objReceiptsInfo.ICReceiptTotalCost = 0;
            return objReceiptsInfo;
        }

        /// <summary>
        /// Generate a list of receipt items from a given list of sale return items
        /// </summary>        
        /// <param name="saleReturnItemList">Given list of sale return items</param>
        /// <returns>Generated list of receipt items</returns>
        public static List<ICReceiptItemsInfo> GenerateReceiptItemsFromSaleReturnItems(List<ARSaleReturnItemsInfo> saleReturnItemList)
        {
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<ICReceiptItemsInfo> receiptItemList = new List<ICReceiptItemsInfo>();
            foreach (ARSaleReturnItemsInfo saleReturnItem in saleReturnItemList)
            {
                ICReceiptItemsInfo receiptItem = new ICReceiptItemsInfo();
                BOSUtil.CopyObject(saleReturnItem, receiptItem);
                receiptItem.FK_ARSaleReturnID = saleReturnItem.FK_ARSaleReturnID;
                receiptItem.FK_ARSaleReturnItemID = saleReturnItem.ARSaleReturnItemID;
                receiptItem.ICReceiptItemProductUnitCost = saleReturnItem.ARSaleReturnItemProductUnitCost;
                receiptItem.ICReceiptItemInventoryCost = receiptItem.ICReceiptItemProductUnitCost;
                receiptItem.ICReceiptItemExtCost = receiptItem.ICReceiptItemProductUnitCost * receiptItem.ICReceiptItemProductQty;
                receiptItem.ICReceiptItemDiscountAmount = 0;
                receiptItem.ICReceiptItemTaxAmount = 0;
                receiptItem.ICReceiptItemTotalCost = receiptItem.ICReceiptItemExtCost;
                receiptItem.ICReceiptItemProductFactor = receiptItem.ICReceiptItemProductFactor == 0 ? 1 : receiptItem.ICReceiptItemProductFactor;
                receiptItem.ICReceiptItemProductExchangeQty = receiptItem.ICReceiptItemProductQty * receiptItem.ICReceiptItemProductFactor;

                receiptItemList.Add(receiptItem);
            }
            return receiptItemList;
        }

        /// <summary>
        /// Generate an open document from a given invoice
        /// </summary>
        /// <param name="objInvoicesInfo">Given invoice</param>
        /// <returns>Open document object</returns>
        public static AROpenDocumentsInfo GenerateOpenDocumentFromInvoice(ARInvoicesInfo objInvoicesInfo)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            AROpenDocumentsInfo objOpenDocumentsInfo = new AROpenDocumentsInfo();
            BOSUtil.CopyObject(objInvoicesInfo, objOpenDocumentsInfo);

            //Set own properties of open document
            objOpenDocumentsInfo.AACreatedUser = BOSApp.CurrentUser;
            objOpenDocumentsInfo.AACreatedDate = DateTime.Now;
            objOpenDocumentsInfo.FK_ARInvoiceID = objInvoicesInfo.ARInvoiceID;
            objOpenDocumentsInfo.AROpenDocumentType = objInvoicesInfo.ARInvoiceTypeCombo;
            return objOpenDocumentsInfo;
        }

        /// <summary>
        /// Generate an open document from a given invoice
        /// </summary>
        /// <param name="objInvoicesInfo">Given invoice</param>
        /// <returns>Open document object</returns>
        public static APOpenDocumentsInfo GenerateOpenDocumentFromInvoice(APInvoiceInsInfo objInvoicesInfo)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            APOpenDocumentsInfo objOpenDocumentsInfo = new APOpenDocumentsInfo();
            BOSUtil.CopyObject(objInvoicesInfo, objOpenDocumentsInfo);

            //Set own properties of open document
            objOpenDocumentsInfo.AACreatedUser = BOSApp.CurrentUser;
            objOpenDocumentsInfo.AACreatedDate = DateTime.Now;
            objOpenDocumentsInfo.FK_APInvoiceInID = objInvoicesInfo.APInvoiceInID;
            objOpenDocumentsInfo.APOpenDocumentType = objInvoicesInfo.APInvoiceInType;
            return objOpenDocumentsInfo;
        }

        /// <summary>
        /// Generate an associating invoice from a sale return
        /// </summary>
        /// <param name="objSaleReturnsInfo">Given sale return</param>
        /// <returns>Invoice object</returns>
        public static ARInvoicesInfo GenerateInvoiceFromSaleReturn(ARSaleReturnsInfo objSaleReturnsInfo)
        {
            ARInvoicesInfo objInvoicesInfo = new ARInvoicesInfo();
            BOSUtil.CopyObject(objSaleReturnsInfo, objInvoicesInfo);
            objInvoicesInfo.ARInvoiceTypeCombo = InvoiceType.SaleReturn.ToString();
            objInvoicesInfo.ARInvoiceNetAmount = -objInvoicesInfo.ARInvoiceNetAmount;
            objInvoicesInfo.ARInvoiceDiscountFix = -objInvoicesInfo.ARInvoiceDiscountFix;
            objInvoicesInfo.ARInvoiceTaxAmount = -objInvoicesInfo.ARInvoiceTaxAmount;
            objInvoicesInfo.ARInvoiceSubTotalAmount = -objInvoicesInfo.ARInvoiceSubTotalAmount;
            objInvoicesInfo.ARInvoiceTotalAmount = -objInvoicesInfo.ARInvoiceTotalAmount;
            return objInvoicesInfo;
        }

        /// <summary>
        /// Generate the list of invoice items associating with sale return items
        /// </summary>
        /// <param name="saleReturnItems">List of sale return items</param>
        /// <returns>List of invoice items</returns>
        public static List<ARInvoiceItemsInfo> GenerateInvoiceItemsFromSaleReturnItems(List<ARSaleReturnItemsInfo> saleReturnItems)
        {
            List<ARInvoiceItemsInfo> invoiceItems = new List<ARInvoiceItemsInfo>();
            foreach (ARSaleReturnItemsInfo objSaleReturnItemsInfo in saleReturnItems)
            {
                ARInvoiceItemsInfo objInvoiceItemsInfo = new ARInvoiceItemsInfo();
                BOSUtil.CopyObject(objSaleReturnItemsInfo, objInvoiceItemsInfo);
                objInvoiceItemsInfo.ARInvoiceItemProductQty = -objInvoiceItemsInfo.ARInvoiceItemProductQty;
                objInvoiceItemsInfo.ARInvoiceItemPrice = -objInvoiceItemsInfo.ARInvoiceItemPrice;
                objInvoiceItemsInfo.ARInvoiceItemDiscountAmount = -objInvoiceItemsInfo.ARInvoiceItemDiscountAmount;
                objInvoiceItemsInfo.ARInvoiceItemTaxAmount = -objInvoiceItemsInfo.ARInvoiceItemTaxAmount;
                objInvoiceItemsInfo.ARInvoiceItemNetAmount = -objInvoiceItemsInfo.ARInvoiceItemNetAmount;
                objInvoiceItemsInfo.ARInvoiceItemTotalAmount = -objInvoiceItemsInfo.ARInvoiceItemTotalAmount;
                invoiceItems.Add(objInvoiceItemsInfo);
            }
            return invoiceItems;
        }


        /// <summary>
        /// Generate the list of ICShipment items associating with ICSerial return items
        /// </summary>
        /// <param name="saleReturnItems">List of sale return items</param>
        /// <returns>List of invoice items</returns>
        public static void SetShipmentItemsfromProductSeries(ICShipmentItemsInfo objShipmentItemsInfo, ICProductSeriesInfo objProductSeriesInfo)
        {
            if (objShipmentItemsInfo != null && objProductSeriesInfo != null)
            {
                decimal qty = 0;
                ICProductsController objProductsController = new ICProductsController();
                ICProductsInfo objProductsInfo = new ICProductsInfo();

                BOSUtil.CopyObject(objProductSeriesInfo, objShipmentItemsInfo);

                objShipmentItemsInfo.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                objShipmentItemsInfo.ICShipmentItemProductSerialNo = objProductSeriesInfo.ICProductSerieNo;
                objShipmentItemsInfo.ICShipmentItemLotNo = objProductSeriesInfo.ICProductSerieLotNo;
                objShipmentItemsInfo.ICShipmentItemProductQty = objProductSeriesInfo.ICInventoryStockQuantity;
                objShipmentItemsInfo.ICShipmentItemWoodQty = objProductSeriesInfo.ICInventoryStockWoodQuantity;

                objShipmentItemsInfo.ICShipmentItemPerimeter = objProductSeriesInfo.ICProductSerieProductPerimeter;
                objShipmentItemsInfo.ICShipmentItemPerimeterMax = objProductSeriesInfo.ICProductSerieProductPerimeterMax;
                objShipmentItemsInfo.ICShipmentItemLength = objProductSeriesInfo.ICProductSerieProductLength;
                objShipmentItemsInfo.ICShipmentItemLengthMax = objProductSeriesInfo.ICProductSerieProductLengthMax;
                objShipmentItemsInfo.ICShipmentItemWidth = objProductSeriesInfo.ICProductSerieProductWidth;
                objShipmentItemsInfo.ICShipmentItemWidthMax = objProductSeriesInfo.ICProductSerieProductWidthMax;
                objShipmentItemsInfo.ICShipmentItemHeight = objProductSeriesInfo.ICProductSerieProductHeight;

                objShipmentItemsInfo.ICShipmentItemHeightMin = 0;
                objShipmentItemsInfo.ICShipmentItemWidthMin = objProductSeriesInfo.ICProductSerieProductWidth;
                objShipmentItemsInfo.ICShipmentItemLengthMin = objProductSeriesInfo.ICProductSerieProductLength;
                objShipmentItemsInfo.ICShipmentItemPerimeterMin = objProductSeriesInfo.ICProductSerieProductPerimeter;
                objShipmentItemsInfo.ICShipmentItemHeightMax = 0;

                objShipmentItemsInfo.ICShipmentItemProductUnitPrice = objProductSeriesInfo.ICInventoryStockUnitCost;

                objShipmentItemsInfo.FK_ICProductAttributeWoodTypeID = objProductSeriesInfo.FK_ICProductAttributeWoodTypeID;
                objShipmentItemsInfo.FK_ICProductAttributeQualityID = objProductSeriesInfo.FK_ICProductAttributeQualityID;
                objShipmentItemsInfo.FK_ICProductAttributeTTMTID = objProductSeriesInfo.FK_ICProductAttributeTTMTID;
                objShipmentItemsInfo.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;

                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(objProductSeriesInfo.FK_ICProductID);
                if (objProductsInfo != null)
                {
                    objShipmentItemsInfo.ICShipmentItemProductDesc = objProductsInfo.ICProductDesc;
                    objShipmentItemsInfo.ICShipmentItemProductName = objProductsInfo.ICProductGroupName;
                    objShipmentItemsInfo.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductBasicUnitID;
                    if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                              objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Verneer.ToString() ||
                              objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString())
                    {
                        qty = Math.Round(objProductSeriesInfo.ICInventoryStockQuantity, 4, MidpointRounding.AwayFromZero);
                    }
                    else
                    {
                        qty = Math.Round(objProductSeriesInfo.ICInventoryStockQuantity, 3, MidpointRounding.AwayFromZero);
                    }
                }
                objShipmentItemsInfo.ICShipmentItemProductQty = qty;
                objShipmentItemsInfo.ICShipmentItemTotalAmount = (qty * objProductSeriesInfo.ICInventoryStockUnitCost);
            }
        }

        public static void ChangeValuesShipmentItemsGridFromProductSeries(ICShipmentItemsInfo item)
        {
            if (item != null)
            {
                ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
                ICProductSeriesInfo objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.ICShipmentItemProductSerialNo);
                ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
                ICProductsInfo objProductsInfo = new ICProductsInfo();
                ICProductsController objProductsController = new ICProductsController();
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                decimal qty = 0;
                if (objProductSeriesInfo != null)
                {
                    //int stockID = item.FK_ICStockID;
                    //string desc = item.ICShipmentItemProductDesc;
                    //BOSUtil.CopyObject(objProductSeriesInfo, item);
                    //item.FK_ICStockID = stockID;
                    //item.ICShipmentItemProductDesc = desc;
                    item.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                    //item.ICShipmentItemWidth = objProductSeriesInfo.ICProductSerieProductWidth;
                    //item.ICShipmentItemLength = objProductSeriesInfo.ICProductSerieProductLength;
                    //item.ICShipmentItemPerimeter = objProductSeriesInfo.ICProductSerieProductPerimeter;
                    //item.ICShipmentItemHeight = objProductSeriesInfo.ICProductSerieProductHeight;

                    //item.ICShipmentItemWidthMax = objProductSeriesInfo.ICProductSerieProductWidthMax;
                    //item.ICShipmentItemLengthMax = objProductSeriesInfo.ICProductSerieProductLengthMax;
                    //item.ICShipmentItemPerimeterMax = objProductSeriesInfo.ICProductSerieProductPerimeterMax;

                    //item.ICShipmentItemHeightMin = 0;
                    //item.ICShipmentItemWidthMin = objProductSeriesInfo.ICProductSerieProductWidth;
                    //item.ICShipmentItemLengthMin = objProductSeriesInfo.ICProductSerieProductLength;
                    //item.ICShipmentItemPerimeterMin = objProductSeriesInfo.ICProductSerieProductPerimeter;
                    //item.ICShipmentItemHeightMax = 0;

                    item.ICShipmentItemProductSerialNo = objProductSeriesInfo.ICProductSerieNo;
                    //item.FK_ICProductAttributeTTMTID = objProductSeriesInfo.FK_ICProductAttributeTTMTID;
                    //item.FK_ICProductAttributeQualityID = objProductSeriesInfo.FK_ICProductAttributeQualityID;
                    item.FK_GECountryID = objProductSeriesInfo.FK_GECountryID;
                    item.ICShipmentItemContainerNo = objProductSeriesInfo.ICProductSerieContainerNo;
                    item.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;

                    //ICInventoryStocksInfo objInventoryStocksInfo = new ICInventoryStocksInfo();

                    //objInventoryStocksInfo = (ICInventoryStocksInfo)objInventoryStocksController.ICShipment_ICInventoryStockQuantity_WoodQty_UnitCost(objProductSeriesInfo.ICProductSerieID, item.FK_ICStockID, objProductSeriesInfo.FK_ICProductID);
                    //if (objInventoryStocksInfo != null && objProductsInfo != null)
                    //{
                    //    item.ICShipmentItemWoodQty = objInventoryStocksInfo.ICInventoryStockWoodQuantity;

                    //    item.ICShipmentItemProductUnitPrice = objInventoryStocksInfo.ICInventoryStockUnitCost;
                    //    if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                    //           objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                    //           objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                    //           objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                    //           objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                    //           objProductsInfo.ICProductType == ProductType.Verneer.ToString() ||
                    //           objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString())
                    //    {
                    //        qty = Math.Round(objInventoryStocksInfo.ICInventoryStockQuantity, 4, MidpointRounding.AwayFromZero);
                    //    }
                    //    else
                    //    {
                    //        qty = Math.Round(objInventoryStocksInfo.ICInventoryStockQuantity, 2, MidpointRounding.AwayFromZero);
                    //    }
                    //    item.ICShipmentItemProductQty = qty;


                    //}
                    //else
                    //{
                    //    item.ICShipmentItemWoodQty = 0;
                    //    item.ICShipmentItemProductQty = 0;
                    //    item.ICShipmentItemProductUnitPrice = 0;
                    //}
                    //item.ICShipmentItemTotalAmount = item.ICShipmentItemProductQty * item.ICShipmentItemProductUnitPrice;
                }
            }
        }
        public static void ChangeValuesARSaleOderItemsGridFromProductSeries(ARSaleOrderItemsInfo item)
        {
            if (item != null)
            {
                ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
                ICProductSeriesInfo objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(item.FK_ICProductID, item.ARSaleOrderItemProductSerialNo);
                ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
                ICProductsInfo objProductsInfo = new ICProductsInfo();
                ICProductsController objProductsController = new ICProductsController();
                objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                decimal qty = 0;
                if (objProductSeriesInfo != null)
                {
                    int stockID = item.FK_ICStockID;
                    string desc = item.ARSaleOrderItemProductDesc;
                    BOSUtil.CopyObject(objProductSeriesInfo, item);
                    item.FK_ICStockID = stockID;
                    item.ARSaleOrderItemProductDesc = desc;
                    item.ARSaleOrderItemWidth = objProductSeriesInfo.ICProductSerieProductWidth;
                    item.ARSaleOrderItemLength = objProductSeriesInfo.ICProductSerieProductLength;
                    item.ARSaleOrderItemPerimeter = objProductSeriesInfo.ICProductSerieProductPerimeter;
                    item.ARSaleOrderItemHeight = objProductSeriesInfo.ICProductSerieProductHeight;

                    item.ARSaleOrderItemWidthMax = objProductSeriesInfo.ICProductSerieProductWidthMax;
                    item.ARSaleOrderItemLentghMax = objProductSeriesInfo.ICProductSerieProductLengthMax;
                    item.ARSaleOrderItemPerimeterMax = objProductSeriesInfo.ICProductSerieProductPerimeterMax;

                    item.ARSaleOrderItemHeightMin = 0;
                    item.ARSaleOrderItemWidthMin = objProductSeriesInfo.ICProductSerieProductWidth;
                    item.ARSaleOrderItemLengthMin = objProductSeriesInfo.ICProductSerieProductLength;
                    item.ARSaleOrderItemPerimeterMin = objProductSeriesInfo.ICProductSerieProductPerimeter;
                    item.ARSaleOrderItemHeightMax = 0;

                    item.ARSaleOrderItemProductSerialNo = objProductSeriesInfo.ICProductSerieNo;
                    item.FK_ICProductAttributeTTMTID = objProductSeriesInfo.FK_ICProductAttributeTTMTID;
                    item.FK_ICProductAttributeQualityID = objProductSeriesInfo.FK_ICProductAttributeQualityID;
                    item.FK_GECountryID = objProductSeriesInfo.FK_GECountryID;
                    item.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                    //item.ICShipmentItemContainerNo = objProductSeriesInfo.ICProductSerieContainerNo;

                    ICInventoryStocksInfo objInventoryStocksInfo = new ICInventoryStocksInfo();

                    objInventoryStocksInfo = (ICInventoryStocksInfo)objInventoryStocksController.ICShipment_ICInventoryStockQuantity_WoodQty_UnitCost(objProductSeriesInfo.ICProductSerieID, item.FK_ICStockID, objProductSeriesInfo.FK_ICProductID);
                    if (objInventoryStocksInfo != null && objProductsInfo != null)
                    {
                        item.ARSaleOrderItemWoodQty = objInventoryStocksInfo.ICInventoryStockWoodQuantity;

                        item.ARSaleOrderItemProductUnitPrice = objInventoryStocksInfo.ICInventoryStockUnitCost;
                        item.ICProductUnitPrice = item.ARSaleOrderItemProductUnitPrice;
                        if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
                              objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
                              objProductsInfo.ICProductType == ProductType.Verneer.ToString() ||
                              objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString())
                        {
                            qty = Math.Round(objInventoryStocksInfo.ICInventoryStockQuantity, 4, MidpointRounding.AwayFromZero);
                        }
                        else
                        {
                            qty = Math.Round(objInventoryStocksInfo.ICInventoryStockQuantity, 2, MidpointRounding.AwayFromZero);
                        }
                        item.ARSaleOrderItemProductQty = qty;
                        item.ARSaleOrderItemProductInventoryQty = qty;
                    }
                    else
                    {
                        item.ARSaleOrderItemWoodQty = 0;
                        item.ARSaleOrderItemProductQty = 0;
                        item.ARSaleOrderItemProductUnitPrice = 0;
                        item.ICProductUnitPrice = item.ARSaleOrderItemProductUnitPrice;
                    }
                }
            }
        }
        public static void SelectSeriesNoDefault(List<ICShipmentItemsInfo> ListItem)
        {
            ICProductSeriesInfo objProductSeriesInfo = new ICProductSeriesInfo();
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            foreach (ICShipmentItemsInfo item in ListItem)
            {
                objProductSeriesInfo = (ICProductSeriesInfo)objProductSeriesController.GetSeriesNoByStockAndProduct(item.FK_ICStockID, item.FK_ICProductID, item.ICShipmentItemProductDesc, item.ICShipmentItemProductQty);
                if (objProductSeriesInfo != null)
                {
                    item.ICShipmentItemProductSerialNo = objProductSeriesInfo.ICProductSerieNo;
                    item.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                }
                else
                {
                    item.ICShipmentItemProductSerialNo = string.Empty;
                    item.FK_ICProductSerieID = 0;
                }
            }
        }

        public static void SelectSeriesNoDefault1(BOSList<ICShipmentProposalItemsInfo> ListItem)
        {
            ICProductSeriesInfo objProductSeriesInfo = new ICProductSeriesInfo();
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            foreach (ICShipmentProposalItemsInfo item in ListItem)
            {
                objProductSeriesInfo = (ICProductSeriesInfo)objProductSeriesController.GetSeriesNoByStockAndProduct(item.FK_ICStockID, item.FK_ICProductID, item.ICShipmentProposalItemProductDesc, item.ICShipmentProposalItemProductQty);
                if (objProductSeriesInfo != null)
                {
                    item.ICShipmentProposalItemProductSerialNo = objProductSeriesInfo.ICProductSerieNo;
                    item.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                }
                else
                {
                    item.ICShipmentProposalItemProductSerialNo = string.Empty;
                    item.FK_ICProductSerieID = 0;
                }
            }
        }

        public static void SelectSeriesNoDefault2(BOSList<ARDeliveryPlanItemsInfo> ListItem)
        {
            ICProductSeriesInfo objProductSeriesInfo = new ICProductSeriesInfo();
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            foreach (ARDeliveryPlanItemsInfo item in ListItem)
            {
                objProductSeriesInfo = (ICProductSeriesInfo)objProductSeriesController.GetSeriesNoByStockAndProduct(item.FK_ICStockID, item.FK_ICProductID, item.ARDeliveryPlanItemProductDesc, item.ARDeliveryPlanItemProductQty);
                if (objProductSeriesInfo != null)
                {
                    item.ARDeliveryPlanItemProductSerialNo = objProductSeriesInfo.ICProductSerieNo;
                    item.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                }
                else
                {
                    item.ARDeliveryPlanItemProductSerialNo = string.Empty;
                    item.FK_ICProductSerieID = 0;
                }
            }
        }

        public static List<ICShipmentItemsInfo> GenerateShipmentItemsFromInventoryAdjustItems(List<ICAssembleProductDetailsInfo> inventoryAdjustItemList)
        {
            List<ICShipmentItemsInfo> shipmentItemList = new List<ICShipmentItemsInfo>();
            ICProductSeriesController psController = new ICProductSeriesController();
            ICProductSeriesInfo ps;
            ICInventoryStocksController ivController = new ICInventoryStocksController();
            ICInventoryStocksInfo iv;
            ICProductsController pController = new ICProductsController();
            ICProductsInfo product;
            foreach (ICAssembleProductDetailsInfo inventoryAdjustItem in inventoryAdjustItemList)
            {
                ICShipmentItemsInfo shipmentItem = new ICShipmentItemsInfo();
                BOSUtil.CopyObject(inventoryAdjustItem, shipmentItem);

                iv = ivController.GetInventoryStockByStockIDAndProductIDAndSerieID(inventoryAdjustItem.FK_ICStockID
                                                                                , inventoryAdjustItem.FK_ICProductID
                                                                                , inventoryAdjustItem.FK_ICProductSerieID);
                if (iv != null)
                {
                    shipmentItem.ICShipmentItemProductUnitPrice = iv.ICInventoryStockUnitCost;
                }

                product = (ICProductsInfo)pController.GetObjectByID(inventoryAdjustItem.FK_ICProductID);
                if (product != null)
                {
                    shipmentItem.FK_ACAccountID = product.FK_ACAccountID;
                }
                shipmentItem.ICShipmentItemProductName = inventoryAdjustItem.ICAssembleProductDetailProductName;
                shipmentItem.ICShipmentItemProductDesc = inventoryAdjustItem.ICAssembleProductDetailProductDesc;
                shipmentItem.ICShipmentItemProductQty = inventoryAdjustItem.ICAssembleProductDetailProductQty;
                shipmentItem.ICShipmentItemPrice = shipmentItem.ICShipmentItemProductUnitPrice * shipmentItem.ICShipmentItemProductQty;
                shipmentItem.ICShipmentItemDiscountAmount = 0;
                shipmentItem.ICShipmentItemTaxAmount = 0;
                shipmentItem.ICShipmentItemTotalAmount = shipmentItem.ICShipmentItemPrice;
                ps = (ICProductSeriesInfo)psController.GetObjectByID(inventoryAdjustItem.FK_ICProductSerieID);
                if (ps != null)
                {
                    shipmentItem.ICShipmentItemProductSerialNo = ps.ICProductSerieNo;
                    shipmentItem.ICShipmentItemLotNo = ps.ICProductSerieLotNo;
                    shipmentItem.ICShipmentItemContainerNo = ps.ICProductSerieContainerNo;
                    shipmentItem.FK_ICProductSerieID = ps.ICProductSerieID;
                }
                shipmentItem.ICShipmentItemIsAverageCalculation = inventoryAdjustItem.ICAssembleProductDetailIsAverageCalculation;
                shipmentItem.ICShipmentItemIsSpecificCalculation = inventoryAdjustItem.ICAssembleProductDetailIsSpecificCalculation;
                shipmentItemList.Add(shipmentItem);
            }
            return shipmentItemList;
        }

        public static ICShipmentsInfo GenerateShipmentFromInventoryAdjust(ICAssembleProductsInfo inventoryAdjust)
        {
            ICShipmentsInfo objShipmentsInfo = new ICShipmentsInfo();
            BOSUtil.CopyObject(inventoryAdjust, objShipmentsInfo);

            //Set own properties of shipment
            objShipmentsInfo.AACreatedUser = BOSApp.CurrentUser;
            objShipmentsInfo.AACreatedDate = BOSApp.GetCurrentServerDate();
            objShipmentsInfo.FK_ACObjectID = 0;
            objShipmentsInfo.ICObjectType = string.Empty;
            objShipmentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objShipmentsInfo.ICShipmentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objShipmentsInfo.ICShipmentDeliveryDate = BOSApp.GetCurrentServerDate();
            objShipmentsInfo.ICShipmentValidateDate = BOSApp.GetCurrentServerDate();
            objShipmentsInfo.ICShipmentTypeCombo = ShipmentType.AssembleShipment.ToString();
            objShipmentsInfo.ICShipmentReference = inventoryAdjust.ICAssembleProductNo;
            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.Complete.ToString();
            objShipmentsInfo.ICShipmentSubTotalAmount = 0;
            objShipmentsInfo.ICShipmentDiscountFix = 0;
            objShipmentsInfo.ICShipmentTaxAmount = 0;
            objShipmentsInfo.ICShipmentTotalAmount = 0;
            objShipmentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objShipmentsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            return objShipmentsInfo;
        }

        public static ICShipmentsInfo GenerateShipmentFromDisassembleProduct(ICDisassembleProductsInfo inventoryAdjust)
        {
            ICShipmentsInfo objShipmentsInfo = new ICShipmentsInfo();
            BOSUtil.CopyObject(inventoryAdjust, objShipmentsInfo);

            //Set own properties of shipment
            objShipmentsInfo.AACreatedUser = BOSApp.CurrentUser;
            objShipmentsInfo.AACreatedDate = DateTime.Now;
            objShipmentsInfo.FK_ACObjectID = 0;
            objShipmentsInfo.ICObjectType = string.Empty;
            objShipmentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objShipmentsInfo.ICShipmentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objShipmentsInfo.ICShipmentDeliveryDate = DateTime.Now;
            objShipmentsInfo.ICShipmentValidateDate = DateTime.Now;
            objShipmentsInfo.ICShipmentTypeCombo = ShipmentType.DisassembleShipment.ToString();
            objShipmentsInfo.ICShipmentReference = inventoryAdjust.ICDisassembleProductNo;
            objShipmentsInfo.ICShipmentStatus = ShipmentStatus.Complete.ToString();
            objShipmentsInfo.ICShipmentSubTotalAmount = 0;
            objShipmentsInfo.ICShipmentDiscountFix = 0;
            objShipmentsInfo.ICShipmentTaxAmount = 0;
            objShipmentsInfo.ICShipmentTotalAmount = 0;
            objShipmentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objShipmentsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            return objShipmentsInfo;
        }

        public static ICReceiptsInfo GenerateReceiptFromInventoryAdjust(ICAssembleProductsInfo inventoryAdjust)
        {
            ICReceiptsInfo objReceiptsInfo = new ICReceiptsInfo();
            BOSUtil.CopyObject(inventoryAdjust, objReceiptsInfo);

            //Set own properties of receipt
            objReceiptsInfo.AACreatedUser = BOSApp.CurrentUser;
            objReceiptsInfo.AACreatedDate = BOSApp.GetCurrentServerDate();
            objReceiptsInfo.FK_ACObjectID = 0;
            objReceiptsInfo.ICObjectType = string.Empty;
            objReceiptsInfo.ICReceiptPackNo = inventoryAdjust.ICAssembleProductLotNo;
            objReceiptsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objReceiptsInfo.ICReceiptExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objReceiptsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objReceiptsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objReceiptsInfo.ICReceiptTypeCombo = ReceiptType.AssembleReceipt.ToString();
            objReceiptsInfo.ICReceiptStatus = ShipmentStatus.Complete.ToString();
            return objReceiptsInfo;
        }


        public static ICReceiptsInfo GenerateReceiptFromDisassembleProduct(ICDisassembleProductsInfo inventoryAdjust)
        {
            ICReceiptsInfo objReceiptsInfo = new ICReceiptsInfo();
            BOSUtil.CopyObject(inventoryAdjust, objReceiptsInfo);

            //Set own properties of receipt
            objReceiptsInfo.AACreatedUser = BOSApp.CurrentUser;
            objReceiptsInfo.AACreatedDate = BOSApp.GetCurrentServerDate();
            objReceiptsInfo.FK_ACObjectID = 0;
            objReceiptsInfo.ICObjectType = string.Empty;
            // objReceiptsInfo.ICReceiptPackNo = inventoryAdjust.ICDisassembleProductLotNo;
            objReceiptsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objReceiptsInfo.ICReceiptExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objReceiptsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objReceiptsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objReceiptsInfo.ICReceiptTypeCombo = ReceiptType.DisassembleReceipt.ToString();
            objReceiptsInfo.ICReceiptStatus = ShipmentStatus.Complete.ToString();
            return objReceiptsInfo;
        }

        public static List<ICShipmentItemsInfo> GenerateShipmentItemsFromDiassembleProduct(ICDisassembleProductsInfo disassembleProduct)
        {
            List<ICShipmentItemsInfo> shipmentItemList = new List<ICShipmentItemsInfo>();
            ICProductSeriesController psController = new ICProductSeriesController();
            ICProductSeriesInfo ps;
            ICInventoryStocksController ivController = new ICInventoryStocksController();
            ICInventoryStocksInfo iv;
            ICProductsController pController = new ICProductsController();
            ICProductsInfo product;
            // foreach (ICAssembleProductDetailsInfo inventoryAdjustItem in inventoryAdjustItemList)
            {
                ICShipmentItemsInfo shipmentItem = new ICShipmentItemsInfo();
                BOSUtil.CopyObject(disassembleProduct, shipmentItem);

                iv = ivController.GetInventoryStockByStockIDAndProductIDAndSerieID(disassembleProduct.FK_ICStockID
                                                                                , disassembleProduct.FK_ICProductID
                                                                                , disassembleProduct.FK_ICProductSerieID);
                if (iv != null)
                {
                    shipmentItem.ICShipmentItemProductUnitPrice = iv.ICInventoryStockUnitCost;
                }

                product = (ICProductsInfo)pController.GetObjectByID(disassembleProduct.FK_ICProductID);
                if (product != null)
                {
                    shipmentItem.FK_ACAccountID = product.FK_ACAccountID;
                }
                shipmentItem.ICShipmentItemProductName = disassembleProduct.ICDisassembleProductName;
                shipmentItem.ICShipmentItemProductDesc = disassembleProduct.ICDisassembleProductDesc;
                shipmentItem.ICShipmentItemProductQty = disassembleProduct.ICDisassembleProductQty;
                shipmentItem.ICShipmentItemPrice = shipmentItem.ICShipmentItemProductUnitPrice * shipmentItem.ICShipmentItemProductQty;
                shipmentItem.ICShipmentItemDiscountAmount = 0;
                shipmentItem.ICShipmentItemTaxAmount = 0;
                shipmentItem.ICShipmentItemTotalAmount = shipmentItem.ICShipmentItemPrice;
                shipmentItem.ICShipmentItemIsAverageCalculation = disassembleProduct.ICDisassembleProductIsAverageCalculation;
                shipmentItem.ICShipmentItemIsSpecificCalculation = disassembleProduct.ICDisassembleProductIsSpecificCalculation;
                ps = (ICProductSeriesInfo)psController.GetObjectByID(disassembleProduct.FK_ICProductSerieID);
                if (ps != null)
                {
                    shipmentItem.ICShipmentItemProductSerialNo = ps.ICProductSerieNo;
                    shipmentItem.ICShipmentItemLotNo = ps.ICProductSerieLotNo;
                    shipmentItem.ICShipmentItemContainerNo = ps.ICProductSerieContainerNo;
                    shipmentItem.FK_ICProductSerieID = ps.ICProductSerieID;
                }
                shipmentItemList.Add(shipmentItem);
            }
            return shipmentItemList;
        }

    }
}

