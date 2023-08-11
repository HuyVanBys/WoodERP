using BOSCommon;
using System;

namespace BOSERP
{
    public class TransactionUtil
    {
        #region Constant
        public const string cstInventoryShipment = "Shipment";
        public const string cstInventoryProposal = "Proposal";
        public const string cstInventorySaleOrder = "SaleOrder";
        public const string cstInventoryPurchaseOrder = "PurchaseOrder";
        public const string cstInventoryReceipt = "Receipt";
        public const string cstInventoryAdjust = "Adjustment";
        #endregion

        #region Update Inventory functions
        /// <summary>
        /// Update inventory package
        /// </summary>
        /// <param name="packageID">The package id</param>
        /// <param name="stockID">The stock id</param>
        /// <param name="productID">Product id</param>
        /// <param name="qty">Qty needs to be updated</param>
        /// <param name="updateType">The update type</param>
        /// <returns>The inventory package id</returns>
        public static int UpdateInventoryPackage(int packageID, int stockID, int productID, decimal qty, string updateType)
        {
            int inventoryPackageID = 0;
            ICInventoryPackagesController objInventoryPackagesController = new ICInventoryPackagesController();
            ICInventoryPackagesInfo objInventoryPackagesInfo = objInventoryPackagesController.GetInventoryPackageByPackageIDAndStockIDAndProductID(packageID, stockID, productID);
            if (objInventoryPackagesInfo != null)
            {
                UpdateInventoryPackageQuantity(objInventoryPackagesInfo, qty, updateType);
                inventoryPackageID = objInventoryPackagesController.UpdateObject(objInventoryPackagesInfo);
            }
            else
            {
                objInventoryPackagesInfo = new ICInventoryPackagesInfo();
                objInventoryPackagesInfo.FK_ICStockID = stockID;
                objInventoryPackagesInfo.FK_ICPackageID = packageID;
                objInventoryPackagesInfo.FK_ICProductID = productID;
                UpdateInventoryPackageQuantity(objInventoryPackagesInfo, qty, updateType);
                inventoryPackageID = objInventoryPackagesController.CreateObject(objInventoryPackagesInfo);
            }
            return inventoryPackageID;
        }

        public static int UpdateInventoryStock(
                                        int productID,
                                        int stockID,
                                        decimal productQty,
                                        string updateType)
        {
            return UpdateInventoryStock(productID, stockID, 0, productQty, 0, updateType);
        }

        public static int UpdateInventoryStock(
                                        int productID,
                                        int stockID,
                                        decimal productQty,
                                        decimal unitCost,
                                        string updateType)
        {
            return UpdateInventoryStock(productID, stockID, 0, productQty, unitCost, updateType);
        }

        public static int UpdateInventoryStock(
                                       int productID,
                                       int stockID,
                                       int productSerieID,
                                       decimal productQty,
                                       string updateType)
        {
            return UpdateInventoryStock(productID, stockID, productSerieID, productQty, 0, updateType);
        }

        public static int UpdateInventoryStock(
                                          int productID,
                                          int stockID,
                                          int productSerieID,
                                          decimal productQty,
                                          decimal unitCost,
                                          string updateType)
        {
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            int inventoryStockID = 0;
            bool isValid = true;
            //if (objProductsInfo != null && !objProductsInfo.HasComponent)
            if (objProductsInfo != null)
            {
                ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
                ICInventoryStocksInfo objInventoryStocksInfo = objInventoryStocksController.GetInventoryStockByStockIDAndProductIDAndSerieID(stockID, productID, productSerieID);
                if (objInventoryStocksInfo != null)
                {
                    if (updateType == cstInventoryShipment)
                    {
                        decimal result = objInventoryStocksInfo.ICInventoryStockQuantity - productQty;
                        if (result < 0)
                        {
                            isValid = false;
                        }
                    }
                    else if (updateType == cstInventoryReceipt)
                    {
                        decimal result = objInventoryStocksInfo.ICInventoryStockQuantity + productQty;
                        if (result < 0)
                        {
                            isValid = false;
                        }
                    }
                    UpdateInventoryStockQuantity(
                        objInventoryStocksInfo,
                        productQty,
                        updateType);
                    if (unitCost > 0)
                    {
                        objInventoryStocksInfo.ICInventoryStockUnitCost = unitCost;
                    }
                    inventoryStockID = objInventoryStocksController.UpdateObject(objInventoryStocksInfo);
                }
                else
                {
                    objInventoryStocksInfo = new ICInventoryStocksInfo();
                    objInventoryStocksInfo.FK_ICStockID = stockID;
                    objInventoryStocksInfo.FK_ICProductID = productID;
                    objInventoryStocksInfo.FK_ICProductSerieID = productSerieID;
                    objInventoryStocksInfo.ICInventoryStockUnitCost = unitCost;

                    if (updateType == cstInventoryShipment)
                    {
                        decimal result = objInventoryStocksInfo.ICInventoryStockQuantity - productQty;
                        if (result < 0)
                        {
                            isValid = false;
                        }
                    }
                    else if (updateType == cstInventoryReceipt)
                    {
                        decimal result = objInventoryStocksInfo.ICInventoryStockQuantity + productQty;
                        if (result < 0)
                        {
                            isValid = false;
                        }
                    }
                    UpdateInventoryStockQuantity(
                        objInventoryStocksInfo,
                        productQty,
                        updateType);

                    inventoryStockID = objInventoryStocksController.CreateObject(objInventoryStocksInfo);
                }
            }
            if (!isValid)
            {
                inventoryStockID = 0;
            }
            return inventoryStockID;
        }

        //CTChinh 04-01-2016 - Begin
        public static int UpdateInventoryStock(
                                          int productID,
                                          int stockID,
                                          int productSerieID,
                                          decimal productQty,
                                          decimal productWoodQty,
                                          decimal unitCost,
                                          string updateType)
        {
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            int inventoryStockID = 0;
            bool isValid = true;
            //if (objProductsInfo != null && !objProductsInfo.HasComponent)
            if (objProductsInfo != null)
            {
                ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
                ICInventoryStocksInfo objInventoryStocksInfo = objInventoryStocksController.GetInventoryStockByStockIDAndProductIDAndSerieID(stockID, productID, productSerieID);
                if (objInventoryStocksInfo != null)
                {
                    objInventoryStocksInfo.ICInventoryStockQuantity = Math.Round(objInventoryStocksInfo.ICInventoryStockQuantity, 4);
                    productQty = Math.Round(productQty, 4);
                    if (updateType == cstInventoryShipment)
                    {
                        decimal result = objInventoryStocksInfo.ICInventoryStockQuantity - productQty;
                        if (result < 0)
                        {
                            isValid = false;
                        }
                    }
                    else if (updateType == cstInventoryReceipt)
                    {
                        decimal result = objInventoryStocksInfo.ICInventoryStockQuantity - productQty;
                        if (result < 0)
                        {
                            isValid = false;
                        }
                    }
                    UpdateInventoryStockQuantity(
                        objInventoryStocksInfo,
                        productQty,
                        productWoodQty,
                        updateType);
                    if (unitCost > 0)
                    {
                        objInventoryStocksInfo.ICInventoryStockUnitCost = unitCost;
                    }

                    inventoryStockID = objInventoryStocksController.UpdateObject(objInventoryStocksInfo);
                }
                else
                {
                    objInventoryStocksInfo = new ICInventoryStocksInfo();
                    objInventoryStocksInfo.FK_ICStockID = stockID;
                    objInventoryStocksInfo.FK_ICProductID = productID;
                    objInventoryStocksInfo.FK_ICProductSerieID = productSerieID;
                    objInventoryStocksInfo.ICInventoryStockUnitCost = unitCost;
                    if (updateType == cstInventoryShipment)
                    {
                        decimal result = objInventoryStocksInfo.ICInventoryStockQuantity - productQty;
                        if (result < 0)
                        {
                            isValid = false;
                        }
                    }
                    else if (updateType == cstInventoryReceipt)
                    {
                        decimal result = objInventoryStocksInfo.ICInventoryStockQuantity - productQty;
                        if (result < 0)
                        {
                            isValid = false;
                        }
                    }
                    UpdateInventoryStockQuantity(
                        objInventoryStocksInfo,
                        productQty,
                        productWoodQty,
                        updateType);

                    inventoryStockID = objInventoryStocksController.CreateObject(objInventoryStocksInfo);
                }
            }
            if (!isValid)
            {
                inventoryStockID = 0;
            }
            return inventoryStockID;
        }

        //CTChinh 04-01-2016 - End


        //NN GIANG 07-03-2016 Start

        /// <summary>
        /// Update the inventory cost of a product in a stock
        /// </summary>
        /// <param name="productID">Product id</param>
        /// <param name="stockID">Stock id</param>
        /// <param name="productSerieID">Serie id</param>
        /// <param name="inventoryCost">Inventory cost</param>
        public static void UpdateInventoryCost(int productID, int stockID, int productSerieID, decimal inventoryCost)
        {
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            ICInventoryStocksInfo inventoryStock = objInventoryStocksController.GetInventoryStockByStockIDAndProductIDAndSerieID(
                                                                                                                        stockID,
                                                                                                                        productID,
                                                                                                                        productSerieID);
            if (inventoryStock != null)
            {
                inventoryStock.ICInventoryStockUnitCost = inventoryCost;
                objInventoryStocksController.UpdateObject(inventoryStock);
            }
        }

        /// <summary>
        /// Update inventory adjustment for a product in a stock
        /// to adjust its inventory automatically at branches
        /// </summary>
        /// <param name="productID">Product id</param>
        /// <param name="stockID">Stock id</param>
        /// <param name="productSerieID">Serie id</param>
        /// <param name="productQty">Adjusted quantity</param>
        /// <param name="unitCost">Adjusted inventory cost</param>
        /// <param name="updateType">Quantity adjustment type</param>
        public static void UpdateInventoryAdjustment(
                                        int productID,
                                        int stockID,
                                        int productSerieID,
                                        decimal productQty,
                                        decimal unitCost,
                                        string updateType)
        {
            ICInvAdjustmentsController objInvAdjustmentsController = new ICInvAdjustmentsController();
            ICInvAdjustmentsInfo objInvAdjustmentsInfo = objInvAdjustmentsController.GetInvAdjustmentByStockIDAndProductIDAndSerieID(
                                                                                                    stockID,
                                                                                                    productID,
                                                                                                    productSerieID);
            if (objInvAdjustmentsInfo != null)
            {
                if (unitCost > 0)
                {
                    objInvAdjustmentsInfo.ICInvAdjustmentUnitCost = unitCost;
                }
                if (updateType == TransactionUtil.cstInventoryReceipt)
                {
                    objInvAdjustmentsInfo.ICInvAdjustmentQty += productQty;
                }
                else if (updateType == TransactionUtil.cstInventoryShipment)
                {
                    objInvAdjustmentsInfo.ICInvAdjustmentQty -= productQty;
                }
                objInvAdjustmentsController.UpdateObject(objInvAdjustmentsInfo);
            }
            else
            {
                objInvAdjustmentsInfo = new ICInvAdjustmentsInfo();
                objInvAdjustmentsInfo.FK_ICProductID = productID;
                objInvAdjustmentsInfo.FK_ICStockID = stockID;
                objInvAdjustmentsInfo.FK_ICProductSerieID = productSerieID;
                objInvAdjustmentsInfo.ICInvAdjustmentUnitCost = unitCost;
                if (updateType == TransactionUtil.cstInventoryReceipt)
                {
                    objInvAdjustmentsInfo.ICInvAdjustmentQty += productQty;
                }
                else if (updateType == TransactionUtil.cstInventoryShipment)
                {
                    objInvAdjustmentsInfo.ICInvAdjustmentQty -= productQty;
                }
                objInvAdjustmentsController.CreateObject(objInvAdjustmentsInfo);
            }
        }

        /// <summary>
        /// Update inventory adjustment for a product in a stock
        /// to adjust its inventory automatically at branches
        /// </summary>
        /// <param name="productID">Product id</param>
        /// <param name="stockID">Stock id</param>
        /// <param name="productSerieID">Serie id</param>
        /// <param name="unitCost">Inventory cost</param>
        public static void UpdateInventoryAdjustment(
                                            int productID,
                                            int stockID,
                                            int productSerieID,
                                            decimal unitCost)
        {
            ICInvAdjustmentsController objInvAdjustmentsController = new ICInvAdjustmentsController();
            ICInvAdjustmentsInfo objInvAdjustmentsInfo = objInvAdjustmentsController.GetInvAdjustmentByStockIDAndProductIDAndSerieID(
                                                                                                    stockID,
                                                                                                    productID,
                                                                                                    productSerieID);
            if (objInvAdjustmentsInfo != null)
            {
                objInvAdjustmentsInfo.ICInvAdjustmentUnitCost = unitCost;
                objInvAdjustmentsController.UpdateObject(objInvAdjustmentsInfo);
            }
            else
            {
                objInvAdjustmentsInfo = new ICInvAdjustmentsInfo();
                objInvAdjustmentsInfo.FK_ICProductID = productID;
                objInvAdjustmentsInfo.FK_ICStockID = stockID;
                objInvAdjustmentsInfo.FK_ICProductSerieID = productSerieID;
                objInvAdjustmentsInfo.ICInvAdjustmentUnitCost = unitCost;
                objInvAdjustmentsController.CreateObject(objInvAdjustmentsInfo);
            }
        }

        private static void UpdateInventoryStockQuantity(
                                ICInventoryStocksInfo objICInventoryStocksInfo,
                                decimal dbProductQuantity,
                                String strUpdateType)
        {
            switch (strUpdateType)
            {
                case cstInventoryProposal:
                    {
                        objICInventoryStocksInfo.ICInventoryStockProposalQuantity += dbProductQuantity;
                        break;
                    }
                case cstInventoryPurchaseOrder:
                    {
                        objICInventoryStocksInfo.ICInventoryStockPurchaseOrderQuantity += dbProductQuantity;
                        break;
                    }
                case cstInventorySaleOrder:
                    {
                        objICInventoryStocksInfo.ICInventoryStockSaleOrderQuantity += dbProductQuantity;
                        break;
                    }
                case cstInventoryShipment:
                    {
                        objICInventoryStocksInfo.ICInventoryStockQuantity -= dbProductQuantity;
                        break;
                    }

                case cstInventoryReceipt:
                    {
                        objICInventoryStocksInfo.ICInventoryStockQuantity += dbProductQuantity;
                        break;
                    }
                case cstInventoryAdjust:
                    {
                        objICInventoryStocksInfo.ICInventoryStockQuantity = dbProductQuantity;
                        break;
                    }

            }
        }

        // CTChinh 04-01-2016 - Begin
        private static void UpdateInventoryStockQuantity(
                                ICInventoryStocksInfo objICInventoryStocksInfo,
                                decimal dbProductQuantity,
                                decimal dbProductWoodQuantity,
                                String strUpdateType)
        {
            switch (strUpdateType)
            {
                case cstInventoryProposal:
                    {
                        objICInventoryStocksInfo.ICInventoryStockProposalQuantity += dbProductQuantity;
                        break;
                    }
                case cstInventoryPurchaseOrder:
                    {
                        objICInventoryStocksInfo.ICInventoryStockPurchaseOrderQuantity += dbProductQuantity;
                        break;
                    }
                case cstInventorySaleOrder:
                    {
                        objICInventoryStocksInfo.ICInventoryStockSaleOrderQuantity += dbProductQuantity;
                        break;
                    }
                case cstInventoryShipment:
                    {
                        objICInventoryStocksInfo.ICInventoryStockQuantity -= dbProductQuantity;
                        objICInventoryStocksInfo.ICInventoryStockWoodQuantity -= dbProductWoodQuantity;
                        break;
                    }

                case cstInventoryReceipt:
                    {
                        objICInventoryStocksInfo.ICInventoryStockQuantity += dbProductQuantity;
                        objICInventoryStocksInfo.ICInventoryStockWoodQuantity += dbProductWoodQuantity;
                        break;
                    }
                case cstInventoryAdjust:
                    {
                        objICInventoryStocksInfo.ICInventoryStockQuantity = dbProductQuantity;
                        break;
                    }

            }
        }
        // CTChinh 04-01-2016 - End

        /// <summary>
        /// Update inventory package quantity
        /// </summary>
        /// <param name="objInventoryPackagesInfo">Info of package</param>
        /// <param name="packageQuantity">The package quantity</param>
        /// <param name="updateType">The update type</param>
        private static void UpdateInventoryPackageQuantity(ICInventoryPackagesInfo objInventoryPackagesInfo,
                                                            decimal packageQuantity,
                                                            string updateType)
        {
            if (updateType.Equals(TransactionUtil.cstInventoryShipment.ToString()))
            {
                objInventoryPackagesInfo.ICInventoryPackageQty -= packageQuantity;
            }
            if (updateType.Equals(TransactionUtil.cstInventoryReceipt.ToString()))
            {
                objInventoryPackagesInfo.ICInventoryPackageQty += packageQuantity;
            }
        }


        private static void UpdateInventoryStockSlotQuantity(
                                ICInventoryStockSlotsInfo objICInventoryStockSlotsInfo,
                                decimal dbProductQuantity,
                                String strUpdateType)
        {
            switch (strUpdateType)
            {
                case cstInventoryProposal:
                    {
                        objICInventoryStockSlotsInfo.ICInventoryStockSlotProposalQuantity += dbProductQuantity;
                        break;
                    }
                case cstInventoryPurchaseOrder:
                    {
                        objICInventoryStockSlotsInfo.ICInventoryStockSlotPurchaseOrderQuantity += dbProductQuantity;
                        break;
                    }
                case cstInventorySaleOrder:
                    {
                        objICInventoryStockSlotsInfo.ICInventoryStockSlotSaleOrderQuantity += dbProductQuantity;
                        break;
                    }
                case cstInventoryShipment:
                    {
                        objICInventoryStockSlotsInfo.ICInventoryStockSlotQuantity -= dbProductQuantity;
                        break;
                    }

                case cstInventoryReceipt:
                    {
                        objICInventoryStockSlotsInfo.ICInventoryStockSlotQuantity += dbProductQuantity;
                        break;
                    }
                case cstInventoryAdjust:
                    {
                        objICInventoryStockSlotsInfo.ICInventoryStockSlotQuantity = dbProductQuantity;
                        break;
                    }
            }
        }

        //[NKVung]  [Update Thong Tin Ton Kho]    [START]
        /// <summary>
        /// Update the quantity in productserie table
        /// </summary>
        /// <param name="productID">Product id</param>
        /// <param name="stockID">Stock id</param>
        /// <param name="productSerieID">Serie id</param>
        public static void UpdateProductSerieQuantity(int productID,
                                                        int productSerieID,
                                                        string updateType,
                                                        string productSerieNo,
                                                        DateTime receiptDate,
                                                        int productWoodType,
                                                        int productTTMT,
                                                        int country,
                                                        int productQuality,
                                                        string productLotNo,
                                                        decimal woodQty,
                                                        string productLogListNo,
                                                        string containerNo,
                                                        string productDesc,
                                                        decimal productHeight,
                                                        decimal productWidth,
                                                        decimal productLength,
                                                        decimal productPerimeter,
                                                        decimal productWidthMax,
                                                        decimal productLenghtMax,
                                                        decimal productPerimeterMax,
                                                        decimal productWidthMin,
                                                        decimal productLenghtMin)
        {
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo productSerie = objProductSeriesController.GetSerieByProductIDAndSerieNo(productID, productSerieNo);
            if (productSerie != null)
            {
                productSerie.AAUpdatedDate = DateTime.Now;
                productSerie.ICProductSerieNo = productSerieNo;
                productSerie.ICProductSerieReceiptDate = receiptDate;
                productSerie.FK_ICProductAttributeWoodTypeID = productWoodType;
                productSerie.FK_ICProductAttributeTTMTID = productTTMT;
                productSerie.FK_GECountryID = country;
                productSerie.FK_ICProductAttributeQualityID = productQuality;
                if (updateType.Equals(TransactionUtil.cstInventoryShipment.ToString()))
                {
                    if (productSerie.ICProductSerieWoodQty >= woodQty)
                        productSerie.ICProductSerieWoodQty -= woodQty;
                    else
                        productSerie.ICProductSerieWoodQty = 0;
                }
                if (updateType.Equals(TransactionUtil.cstInventoryReceipt.ToString()))
                {
                    productSerie.ICProductSerieWoodQty += woodQty;
                }
                productSerie.ICProductSerieLogListNo = productLogListNo;
                productSerie.ICProductSerieContainerNo = containerNo;
                productSerie.ICProductSerieProductHeight = productHeight;
                //ICProductSerieProductWidth
                if (productWidthMin > 0)
                {
                    productSerie.ICProductSerieProductWidth = productWidthMin;
                }
                else
                {
                    productSerie.ICProductSerieProductWidth = productWidth;
                }
                //ICProductSerieProductLength
                if (productLenghtMin > 0)
                {
                    productSerie.ICProductSerieProductLength = productLenghtMin;
                }
                else
                {
                    productSerie.ICProductSerieProductLength = productLength;
                }
                productSerie.ICProductSerieProductPerimeter = productPerimeter;
                productSerie.ICProductSerieProductWidthMax = productWidthMax;
                productSerie.ICProductSerieProductLengthMax = productLenghtMax;
                productSerie.ICProductSerieProductPerimeterMax = productPerimeterMax;
                objProductSeriesController.UpdateObject(productSerie);
            }
            else
            {
                productSerie = new ICProductSeriesInfo();
                productSerie.AACreatedDate = DateTime.Now;
                productSerie.FK_ICProductID = productID;
                productSerie.ICProductSerieNo = productSerieNo;
                productSerie.ICProductSerieReceiptDate = receiptDate;
                productSerie.FK_ICProductAttributeWoodTypeID = productWoodType;
                productSerie.FK_ICProductAttributeTTMTID = productTTMT;
                productSerie.FK_GECountryID = country;
                productSerie.FK_ICProductAttributeQualityID = productQuality;
                productSerie.ICProductSerieLotNo = productLotNo;
                if (updateType.Equals(TransactionUtil.cstInventoryShipment.ToString()))
                {
                    if (productSerie.ICProductSerieWoodQty >= woodQty)
                        productSerie.ICProductSerieWoodQty -= woodQty;
                    else
                        productSerie.ICProductSerieWoodQty = 0;
                }
                if (updateType.Equals(TransactionUtil.cstInventoryReceipt.ToString()))
                {
                    productSerie.ICProductSerieWoodQty += woodQty;
                }
                productSerie.ICProductSerieLogListNo = productLogListNo;
                productSerie.ICProductSerieContainerNo = containerNo;
                productSerie.ICProductSerieProductDesc = productDesc;
                productSerie.ICProductSerieProductHeight = productHeight;
                //ICProductSerieProductWidth
                if (productWidthMin > 0)
                {
                    productSerie.ICProductSerieProductWidth = productWidthMin;
                }
                else
                {
                    productSerie.ICProductSerieProductWidth = productWidth;
                }
                //ICProductSerieProductLength
                if (productLenghtMin > 0)
                {
                    productSerie.ICProductSerieProductLength = productLenghtMin;
                }
                else
                {
                    productSerie.ICProductSerieProductLength = productLength;
                }
                productSerie.ICProductSerieProductPerimeter = productPerimeter;
                productSerie.ICProductSerieProductWidthMax = productWidthMax;
                productSerie.ICProductSerieProductLengthMax = productLenghtMax;
                productSerie.ICProductSerieProductPerimeterMax = productPerimeterMax;
                objProductSeriesController.CreateObject(productSerie);
            }
        }
        //[NKVung]  [Update Thong Tin Ton Kho]    [END]

        public static void UpdateProductSerieQuantity(int productID,
                                                        int productSerieID,
                                                        string updateType,
                                                        string productSerieNo,
                                                        DateTime receiptDate,
                                                        int productWoodType,
                                                        int productTTMT,
                                                        int country,
                                                        int productQuality,
                                                        string productLotNo,
                                                        decimal woodQty,
                                                        string productLogListNo,
                                                        string containerNo,
                                                        string productDesc,
                                                        decimal productHeight,
                                                        decimal productWidth,
                                                        decimal productLength,
                                                        decimal productPerimeter,
                                                        decimal productWidthMax,
                                                        decimal productLenghtMax,
                                                        decimal productPerimeterMax,
                                                        decimal productWidthMin,
                                                        decimal productLenghtMin,
                                                        string productType)
        {
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            ICProductSeriesInfo productSerie = new ICProductSeriesInfo();
            if (productType == ProductType.IngredientPackaging.ToString())
            {
                productSerie = objProductSeriesController.GetSerieByProductIDAndSerieNoAndDesc(productID, productSerieNo, productDesc);
            }
            else
                productSerie = objProductSeriesController.GetSerieByProductIDAndSerieNo(productID, productSerieNo);
            if (productSerie != null)
            {
                productSerie.AAUpdatedDate = DateTime.Now;
                productSerie.ICProductSerieNo = productSerieNo;
                productSerie.ICProductSerieReceiptDate = receiptDate;
                productSerie.FK_ICProductAttributeWoodTypeID = productWoodType;
                productSerie.FK_ICProductAttributeTTMTID = productTTMT;
                productSerie.FK_GECountryID = country;
                productSerie.FK_ICProductAttributeQualityID = productQuality;
                if (updateType.Equals(TransactionUtil.cstInventoryShipment.ToString()))
                {
                    if (productSerie.ICProductSerieWoodQty >= woodQty)
                        productSerie.ICProductSerieWoodQty -= woodQty;
                    else
                        productSerie.ICProductSerieWoodQty = 0;
                }
                if (updateType.Equals(TransactionUtil.cstInventoryReceipt.ToString()))
                {
                    productSerie.ICProductSerieWoodQty += woodQty;
                }
                productSerie.ICProductSerieLogListNo = productLogListNo;
                productSerie.ICProductSerieContainerNo = containerNo;
                productSerie.ICProductSerieProductHeight = productHeight;
                //ICProductSerieProductWidth
                if (productWidthMin > 0)
                {
                    productSerie.ICProductSerieProductWidth = productWidthMin;
                }
                else
                {
                    productSerie.ICProductSerieProductWidth = productWidth;
                }
                //ICProductSerieProductLength
                if (productLenghtMin > 0)
                {
                    productSerie.ICProductSerieProductLength = productLenghtMin;
                }
                else
                {
                    productSerie.ICProductSerieProductLength = productLength;
                }
                productSerie.ICProductSerieProductPerimeter = productPerimeter;
                productSerie.ICProductSerieProductWidthMax = productWidthMax;
                productSerie.ICProductSerieProductLengthMax = productLenghtMax;
                productSerie.ICProductSerieProductPerimeterMax = productPerimeterMax;
                objProductSeriesController.UpdateObject(productSerie);
            }
            else
            {
                productSerie = new ICProductSeriesInfo();
                productSerie.AACreatedDate = DateTime.Now;
                productSerie.FK_ICProductID = productID;
                productSerie.ICProductSerieNo = productSerieNo;
                productSerie.ICProductSerieReceiptDate = receiptDate;
                productSerie.FK_ICProductAttributeWoodTypeID = productWoodType;
                productSerie.FK_ICProductAttributeTTMTID = productTTMT;
                productSerie.FK_GECountryID = country;
                productSerie.FK_ICProductAttributeQualityID = productQuality;
                productSerie.ICProductSerieLotNo = productLotNo;
                if (updateType.Equals(TransactionUtil.cstInventoryShipment.ToString()))
                {
                    if (productSerie.ICProductSerieWoodQty >= woodQty)
                        productSerie.ICProductSerieWoodQty -= woodQty;
                    else
                        productSerie.ICProductSerieWoodQty = 0;
                }
                if (updateType.Equals(TransactionUtil.cstInventoryReceipt.ToString()))
                {
                    productSerie.ICProductSerieWoodQty += woodQty;
                }
                productSerie.ICProductSerieLogListNo = productLogListNo;
                productSerie.ICProductSerieContainerNo = containerNo;
                productSerie.ICProductSerieProductDesc = productDesc;
                productSerie.ICProductSerieProductHeight = productHeight;
                //ICProductSerieProductWidth
                if (productWidthMin > 0)
                {
                    productSerie.ICProductSerieProductWidth = productWidthMin;
                }
                else
                {
                    productSerie.ICProductSerieProductWidth = productWidth;
                }
                //ICProductSerieProductLength
                if (productLenghtMin > 0)
                {
                    productSerie.ICProductSerieProductLength = productLenghtMin;
                }
                else
                {
                    productSerie.ICProductSerieProductLength = productLength;
                }
                productSerie.ICProductSerieProductPerimeter = productPerimeter;
                productSerie.ICProductSerieProductWidthMax = productWidthMax;
                productSerie.ICProductSerieProductLengthMax = productLenghtMax;
                productSerie.ICProductSerieProductPerimeterMax = productPerimeterMax;
                objProductSeriesController.CreateObject(productSerie);
            }
        }
        //[NKVung]  [Update Thong Tin Ton Kho]    [END]


        #endregion        
    }
}
