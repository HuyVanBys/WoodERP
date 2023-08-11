using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace BOSERP
{
    partial class ERPModuleEntities
    {
        #region Set Default Values from Customer, Supplier, Employee
        public virtual void SetDefaultValuesFromCustomer(ARCustomersInfo objCustomersInfo)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String mainTablePrefix = mainTableName.Substring(0, mainTableName.Length - 1);

            dbUtil.SetPropertyValue(MainObject, String.Format("{0}PaymentMethodCombo", mainTableName.Substring(0, 2)), objCustomersInfo.ARPaymentMethodCombo);
            dbUtil.SetPropertyValue(MainObject, String.Format("{0}PaymentTerm", mainTablePrefix), objCustomersInfo.ARCustomerPaymentTerm);
            dbUtil.SetPropertyValue(MainObject, "FK_GECurrencyID", objCustomersInfo.FK_GECurrencyID);


            PropertyInfo[] props = objCustomersInfo.GetType().GetProperties();
            foreach (PropertyInfo prop in props)
            {
                //Copy addresses
                if (prop.Name.Contains("Address"))
                {
                    dbUtil.SetPropertyValue(MainObject, String.Format("{0}{1}", mainTablePrefix, prop.Name.Substring(10)), prop.GetValue(objCustomersInfo, null));
                }

                //Copy sale order contact
                if (prop.Name.Contains("Contact"))
                {
                    dbUtil.SetPropertyValue(MainObject, string.Format("{0}SO{1}", mainTablePrefix, prop.Name.Substring(10)), prop.GetValue(objCustomersInfo, null));
                }
            }
        }

        public virtual void SetDefaultValuesFromSupplier(APSuppliersInfo objSuppliersInfo)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String mainTablePrefix = mainTableName.Substring(0, mainTableName.Length - 1);
            int iFK_GECurrencyID = 0;
            DateTime dMainObjDate = Module.GetServerDate();

            dbUtil.SetPropertyValue(MainObject, String.Format("{0}PaymentMethodCombo", mainTableName.Substring(0, 2)), objSuppliersInfo.APPaymentMethodCombo);
            dbUtil.SetPropertyValue(MainObject, String.Format("{0}PaymentTerm", mainTablePrefix), objSuppliersInfo.APSupplierPaymentTerm);
            if (objSuppliersInfo.FK_GECurrencyID > 0)
                dbUtil.SetPropertyValue(MainObject, "FK_GECurrencyID", objSuppliersInfo.FK_GECurrencyID);

            iFK_GECurrencyID = objSuppliersInfo.FK_GECurrencyID;
            PropertyInfo[] props = MainObject.GetType().GetProperties();
            foreach (PropertyInfo prop in props)
            {
                if (prop.Name.Contains(string.Format("{0}{1}", mainTablePrefix, "Date")))
                {
                    dMainObjDate = Convert.ToDateTime(dbUtil.GetPropertyValue(MainObject, string.Format("{0}{1}", mainTablePrefix, "Date")));
                }
            }
            decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateByCurrencyAndDate(iFK_GECurrencyID, dMainObjDate);
            if (dCurrencyExchangeRate > 0)
            {
                dbUtil.SetPropertyValue(MainObject, string.Format("{0}{1}", mainTablePrefix, "ExchangeRate"), dCurrencyExchangeRate);
            }
        }

        public virtual void SetDefaultValuesFromEmployee(int iEmployeeID, String strPrimaryTableName)
        {

        }

        public virtual void SetDefaultValuesFromObject(ACObjectsInfo obj)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String mainTablePrefix = mainTableName.Substring(0, mainTableName.Length - 1);

            dbUtil.SetPropertyValue(MainObject, String.Format("{0}PaymentMethodCombo", mainTableName.Substring(0, 2)), obj.ACObjectPaymentMethodCombo);
            dbUtil.SetPropertyValue(MainObject, String.Format("{0}PaymentTerm", mainTablePrefix), obj.ACObjectPaymentTerm);
            dbUtil.SetPropertyValue(MainObject, "FK_GECurrencyID", obj.GECurrencyID);


            PropertyInfo[] props = obj.GetType().GetProperties();
            foreach (PropertyInfo prop in props)
            {
                //Copy addresses
                if (prop.Name.Contains("Address"))
                {
                    dbUtil.SetPropertyValue(MainObject, String.Format("{0}{1}", mainTablePrefix, prop.Name.Substring(10)), prop.GetValue(obj, null));
                }

                //Copy sale order contact
                if (prop.Name.Contains("Contact"))
                {
                    dbUtil.SetPropertyValue(MainObject, string.Format("{0}SO{1}", mainTablePrefix, prop.Name.Substring(10)), prop.GetValue(obj, null));
                }
            }
        }

        #endregion

        #region Set Default Values From Product
        public virtual void SetValuesAfterValidateProduct(int iICProductID)
        {
            SetDefaultValuesFromProduct(iICProductID);
            SetProductPrice();
        }

        public virtual void SetValuesAfterValidateProduct(int productID, string itemTableName)
        {
            SetDefaultValuesFromProduct(productID, itemTableName);
            SetProductPrice(itemTableName);
        }

        public virtual void SetValuesAfterValidateProduct(int productID, BusinessObject item)
        {
            SetDefaultValuesFromProduct(productID, item);
            SetProductPrice(item);
        }

        public virtual void SetDefaultValuesFromProduct(int iICProductID, string strItemTableName)
        {
            if (ModuleObjects[strItemTableName] != null)
            {
                SetDefaultValuesFromProduct(iICProductID, ModuleObjects[strItemTableName]);
            }
        }

        public virtual void SetDefaultValuesFromProduct(int iICProductID)
        {
            String strMainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String strItemTableName = strMainTableName.Substring(0, strMainTableName.Length - 1) + "Items";
            SetDefaultValuesFromProduct(iICProductID, strItemTableName);
        }

        public virtual void SetDefaultValuesFromProduct(int productID, BusinessObject item)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            //ICProductsController objICProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);

            string itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
            String columnName = String.Empty;

            if (objProductsInfo != null)
            {
                //Set product id                    
                dbUtil.SetPropertyValue(item, "FK_ICProductID", objProductsInfo.ICProductID);

                //Set department id
                dbUtil.SetPropertyValue(item, "FK_ICDepartmentID", objProductsInfo.FK_ICDepartmentID);

                //Set product group id
                dbUtil.SetPropertyValue(item, "FK_ICProductGroupID", objProductsInfo.FK_ICProductGroupID);

                //Set product no
                dbUtil.SetPropertyValue(item, "ICProductNo", objProductsInfo.ICProductNo);

                //Set Product Name
                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductName";
                dbUtil.SetPropertyValue(item, columnName, objProductsInfo.ICProductName);
                dbUtil.SetPropertyValue(item, "ICProductName", objProductsInfo.ICProductName);

                //Set product supplier no
                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductSupplierNo";
                dbUtil.SetPropertyValue(item, columnName, objProductsInfo.ICProductSupplierNumber);

                // Set Product Description
                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductDesc";
                dbUtil.SetPropertyValue(item, columnName, objProductsInfo.ICProductDesc);

                //Set product attribute
                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductAttribute";
                dbUtil.SetPropertyValue(item, columnName, objProductsInfo.ICProductAttribute);

                //Set Product Type
                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductType";
                dbUtil.SetPropertyValue(item, columnName, objProductsInfo.ICProductType);

                //Set Product Unit Cost
                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductUnitCost";
                dbUtil.SetPropertyValue(item, columnName, objProductsInfo.ICProductSupplierPrice);

                //Set Product Picture
                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductPicture";
                dbUtil.SetPropertyValue(item, columnName, objProductsInfo.ICProductPicture);

                //Set Product Default Tax Percent   
                decimal dbTaxPercent = SetDefaultProductTaxPercent(objProductsInfo);
                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductTaxPercent";
                dbUtil.SetPropertyValue(item, columnName, dbTaxPercent);

                //Set Product Qty
                decimal dbQty = 1M;
                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductQty";
                dbUtil.SetPropertyValue(item, columnName, dbQty);

                //Set default serial no
                dbUtil.SetPropertyValue(item, "FK_ICProductSerieID", 0);
                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductSerialNo";
                dbUtil.SetPropertyValue(item, columnName, string.Empty);


                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductFactor";
                decimal productFactor = dbUtil.GetPropertyValue(item, columnName) == null ? 0 : decimal.Parse(dbUtil.GetPropertyValue(item, columnName).ToString());

                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductExchangeQty";
                dbUtil.SetPropertyValue(item, columnName, dbQty * productFactor);

                dbUtil.SetPropertyValue(item, "FK_ICPerimeterGroupID", objProductsInfo.FK_ICPerimeterGroupID);
                dbUtil.SetPropertyValue(item, "FK_ICLengthGroupID", objProductsInfo.FK_ICLengthGroupID);
            }
        }

        public virtual void SetValuesAfterValidateProductQty()
        {
            SetProductPrice();
        }

        public virtual void SetValuesAfterValidateProductUnitPrice()
        {
            SetProductPriceByProductUnitPrice();
        }

        public virtual decimal SetDefaultProductTaxPercent(ICProductsInfo objICProductsInfo)
        {
            decimal dbTaxPercent = 0;
            int iGEVATID = objICProductsInfo.FK_GEVATID;
            if (iGEVATID > 0)
            {
                GEVATsController objGEVATsController = new GEVATsController();
                GEVATsInfo objGEVATsInfo = (GEVATsInfo)objGEVATsController.GetObjectByID(iGEVATID);
                if (objGEVATsInfo != null)
                {
                    dbTaxPercent = objGEVATsInfo.GEVATPercentValue;

                }
            }
            return dbTaxPercent;

        }

        #region Set Product Price
        public virtual void SetProductPrice(ERPModuleItemsEntity entItem, String strItemTableName)
        {
            SetProductPrice(entItem);
        }

        public virtual void SetProductPrice()
        {
            String strMainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String strItemTableName = strMainTableName.Substring(0, strMainTableName.Length - 1) + "Items";
            SetProductPrice(strItemTableName);
        }

        public virtual void SetProductPrice(string strItemTableName)
        {
            if (ModuleObjects[strItemTableName] != null)
            {
                SetProductPrice(ModuleObjects[strItemTableName]);
                UpdateModuleObjectBindingSource(strItemTableName);
            }
        }

        public virtual void SetProductPrice(BusinessObject item)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
            string itemTablePrefix = itemTableName.Substring(0, itemTableName.Length - 1);
            int productID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ICProductID"));

            String columnName = mainTableName.Substring(0, mainTableName.Length - 1) + "Date";
            DateTime date = Convert.ToDateTime(dbUtil.GetPropertyValue(MainObject, columnName));

            //Get Item Qty
            columnName = itemTablePrefix + "ProductQty";
            decimal qty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));
            if (qty == 0)
            {
                qty = 1;
                dbUtil.SetPropertyValue(item, columnName, 1m);
            }

            //Get Item Tax Percent
            columnName = itemTablePrefix + "ProductTaxPercent";
            decimal taxPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Get Item Unit Price
            int measureUnitID = dbUtil.GetPropertyIntValue(item, "FK_ICMeasureUnitID");
            decimal unitPrice = CalculateProductPrice(productID, measureUnitID);

            //Get Item Unit Cost
            columnName = itemTablePrefix + "ProductUnitCost";
            decimal unitCost = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Set Item Unit Price
            columnName = itemTablePrefix + "ProductUnitPrice";
            dbUtil.SetPropertyValue(item, columnName, unitPrice);

            //Set Item Extended Price
            columnName = itemTablePrefix + "Price";
            decimal extPrice = unitPrice * qty;
            dbUtil.SetPropertyValue(item, columnName, extPrice);

            //Set Item Net Amount
            columnName = itemTablePrefix + "NetAmount";
            decimal netAmount = extPrice;
            dbUtil.SetPropertyValue(item, columnName, netAmount);

            //Set Item Discount Amount                
            decimal discountAmount = CalculateItemDiscountAmount(item, productID, unitPrice, date, qty);
            columnName = itemTablePrefix + "DiscountAmount";
            dbUtil.SetPropertyValue(item, columnName, discountAmount);

            //Set item discount percent
            decimal discountPercent = 0;
            if (extPrice != 0)
            {
                discountPercent = discountAmount / extPrice * 100;
            }
            columnName = itemTablePrefix + "ProductDiscount";
            dbUtil.SetPropertyValue(item, columnName, discountPercent);

            //Set Item Tax Amount
            columnName = itemTablePrefix + "TaxAmount";
            decimal taxAmount = ((netAmount - discountAmount) * taxPercent) / 100;
            dbUtil.SetPropertyValue(item, columnName, taxAmount);

            //Set Item Total Amount
            columnName = itemTablePrefix + "TotalAmount";
            dbUtil.SetPropertyValue(item, columnName, netAmount + taxAmount - discountAmount);

            //Set Item Total Cost
            columnName = itemTablePrefix + "TotalCost";
            dbUtil.SetPropertyValue(item, columnName, qty * unitCost);
        }

        public virtual void SetProductPriceByProductUnitPrice(ERPModuleItemsEntity entItem, String strItemTableName)
        {
            SetProductPriceByProductUnitPrice(entItem);
        }

        public virtual void SetProductPriceByProductUnitPrice(string itemTableName)
        {
            if (ModuleObjects[itemTableName] != null)
            {
                SetProductPriceByProductUnitPrice(ModuleObjects[itemTableName]);
                UpdateModuleObjectBindingSource(itemTableName);
            }
        }

        public virtual void SetProductPriceByProductUnitPrice()
        {
            String strMainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String strItemTableName = strMainTableName.Substring(0, strMainTableName.Length - 1) + "Items";
            if (ModuleObjects[strItemTableName] != null)
            {
                SetProductPriceByProductUnitPrice(ModuleObjects[strItemTableName]);

                //round by currency
                BOSDbUtil dbUtil = new BOSDbUtil();
                int currencyID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_GECurrencyID"));
                BOSApp.RoundByCurrency(ModuleObjects[strItemTableName], currencyID);

                UpdateModuleObjectBindingSource(strItemTableName);
            }
        }
        public virtual void SetProductPriceByProductUnitPrice(BusinessObject item)
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
            //ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);

            //Get Item Unit Price
            string columnName = itemTablePrefix + "ProductUnitPrice";
            decimal unitPrice = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));
            if(Module.Name == ModuleName.ShipmentSaleOrder || Module.Name == ModuleName.ProductionPlanning)
            {
                unitPrice = Math.Round(unitPrice, 2);
            }
            else
            {
                unitPrice = Math.Round(unitPrice, decimalNumber);
            }    

            //Get Item Qty
            columnName = itemTablePrefix + "ProductQty";
            decimal qty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Math Round Qty
            //if (objProductsInfo != null)
            //{
            //    if (objProductsInfo.ICProductType == ProductType.IngredientPaint.ToString() ||
            //                  objProductsInfo.ICProductType == ProductType.Roundwood.ToString() ||
            //                  objProductsInfo.ICProductType == ProductType.Reuse.ToString() ||
            //                  objProductsInfo.ICProductType == ProductType.Lumber.ToString() ||
            //                  objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString() ||
            //                  objProductsInfo.ICProductType == ProductType.Verneer.ToString() ||
            //                  objProductsInfo.ICProductType == ProductType.ArtificialBoard.ToString())
            //    {
            //        qty = Math.Round(qty, 4, MidpointRounding.AwayFromZero);
            //    }
            //    else
            //    {
            //        qty = Math.Round(qty, 3, MidpointRounding.AwayFromZero);
            //    }
            //}
            //End

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

            //decimal oldDiscountAmount = 0;
            //if (item.OldObject == null)
            //{
            //    item.OldObject = (BusinessObject)item.Clone();
            //}
            //if (item.OldObject != null)
            //{
            //    oldDiscountAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(item.OldObject, discountAmountColumnName));
            //}
            //if (discountAmount != oldDiscountAmount)
            //{
            //    if (extPrice > 0)
            //    {
            //        discountPercent = discountAmount / extPrice * 100;
            //        dbUtil.SetPropertyValue(item, discountPercentColumnName, discountPercent);
            //    }
            //    discountAmount = extPrice * discountPercent / 100;
            //    discountAmount = Math.Round(discountAmount, decimalNumber);

            //    dbUtil.SetPropertyValue(item, discountAmountColumnName, discountAmount);
            //}
            //else
            //{
            //    discountAmount = extPrice * discountPercent / 100;
            //    discountAmount = Math.Round(discountAmount, decimalNumber);

            //    dbUtil.SetPropertyValue(item, discountAmountColumnName, discountAmount);
            //}

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
                //if (netAmount - discountAmount > 0)
                //{
                //    taxPercent = taxAmount / (netAmount - discountAmount) * 100;
                //    dbUtil.SetPropertyValue(item, taxPercentColumnName, taxPercent);
                //}            
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
            columnName = itemTablePrefix + "ExchangeTotalCost";
            dbUtil.SetPropertyValue(item, columnName, (qty * unitCost) * exchangeRate);

            //Get item factor
            columnName = itemTablePrefix + "ProductFactor";
            decimal factor = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Set Item Exchange Unit Cost
            columnName = itemTablePrefix + "ExchangeUnitCost";
            dbUtil.SetPropertyValue(item, columnName, unitCost/(factor == 0 ? 1: factor) * exchangeRate);
            //Set Item Exchange Qty
            columnName = itemTablePrefix + "ProductExchangeQty";
            dbUtil.SetPropertyValue(item, columnName, qty * factor);

            BOSApp.RoundByCurrency(item, currencyID);

            item.OldObject = (BusinessObject)item.Clone();
        }
        #endregion

        #region Set Product Cost
        /// <summary>
        /// Set cost for a new item
        /// </summary>
        /// <param name="item">Given item</param>
        public virtual void SetProductCost(BusinessObject item)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            string itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
            string mainTablePrefix = mainTableName.Substring(0, mainTableName.Length - 1);
            string itemTablePrefix = itemTableName.Substring(0, itemTableName.Length - 1);

            //Get Exchange Rate
            decimal exchangeRate = Convert.ToDecimal(dbUtil.GetPropertyValue(MainObject, mainTablePrefix + "ExchangeRate"));
            if (exchangeRate == 0)
                exchangeRate = 1;

            int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");

            //round by currency
            int currencyID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_GECurrencyID"));
            int decimalNumber = BOSApp.GetDecimalNumberByCurrencyID(currencyID);

            //Get Item Qty
            String columnName = itemTablePrefix + "ProductQty";
            decimal qty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));
            if (qty == 0)
            {
                qty = 1;
                dbUtil.SetPropertyValue(item, columnName, (decimal)1);
            }

            //Get item factor
            columnName = itemTablePrefix + "ProductFactor";
            decimal factor = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Get Item Tax Percent
            columnName = itemTablePrefix + "ProductTaxPercent";
            decimal taxPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Set Item Unit Cost                            
            columnName = itemTablePrefix + "ProductUnitCost";
            decimal unitCost = CalculateProductCost(productID);

            //Get unit cost from item
            if (unitCost == 0)
            {
                unitCost = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));
            }
            unitCost = Math.Round(unitCost, 5, MidpointRounding.AwayFromZero);
            dbUtil.SetPropertyValue(item, columnName, unitCost);

            //Set Extended Cost
            columnName = itemTablePrefix + "ExtCost";
            decimal extCost = unitCost * qty;
            extCost = Math.Round(extCost, decimalNumber);
            dbUtil.SetPropertyValue(item, columnName, extCost);

            //Set Item Tax Amount
            columnName = itemTablePrefix + "TaxAmount";
            decimal taxAmount = (extCost * taxPercent) / 100;
            taxAmount = Math.Round(taxAmount, decimalNumber);
            dbUtil.SetPropertyValue(item, columnName, taxAmount);

            //Set Item Total Cost
            columnName = itemTablePrefix + "TotalCost";
            dbUtil.SetPropertyValue(item, columnName, extCost + taxAmount);

            //Set Item Exchange Total Cost
            columnName = itemTablePrefix + "ExchangeTotalCost";
            dbUtil.SetPropertyValue(item, columnName, (extCost + taxAmount) * exchangeRate);

            //Set Item Exchange Unit Cost
            columnName = itemTablePrefix + "ExchangeUnitCost";
            dbUtil.SetPropertyValue(item, columnName, unitCost/(factor == 0 ? 1 : factor) * exchangeRate);

            //Set Item Exchange Qty
            columnName = itemTablePrefix + "ProductExchangeQty";
            dbUtil.SetPropertyValue(item, columnName, qty * factor);

            //round by currency
            BOSApp.RoundByCurrency(item, currencyID);

        }

        /// <summary>
        /// Set product cost for a new item
        /// </summary>
        /// <param name="item">Given item</param>
        /// <param name="itemTableName">Table name of item</param>
        public virtual void SetProductCost(ERPModuleItemsEntity item, string itemTableName)
        {
            SetProductCost(item);
        }

        public virtual void SetProductCostByProductUnitCost(BusinessObject objItem)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String itemTableName = BOSUtil.GetTableNameFromBusinessObject(objItem);

            string mainTablePrefix = mainTableName.Substring(0, mainTableName.Length - 1);
            string itemTablePrefix = itemTableName.Substring(0, itemTableName.Length - 1);

            //Get Exchange Rate
            decimal exchangeRate = Convert.ToDecimal(dbUtil.GetPropertyValue(MainObject, mainTablePrefix + "ExchangeRate"));
            if (exchangeRate == 0)
                exchangeRate = 1;
            //round by currency
            int currencyID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_GECurrencyID"));
            int decimalNumber = BOSApp.GetDecimalNumberByCurrencyID(currencyID);

            //Get Item Qty
            String columnName = itemTablePrefix + "ProductQty";
            decimal qty = Convert.ToDecimal(dbUtil.GetPropertyValue(objItem, columnName));

            //Get Item Unit Cost            
            columnName = itemTablePrefix + "ProductUnitCost";
            decimal unitCost = Convert.ToDecimal(dbUtil.GetPropertyValue(objItem, columnName));
            //unitCost = Math.Round(unitCost, decimalNumber);

            //Get item discount percent
            columnName = itemTablePrefix + "ProductDiscount";
            decimal discountPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(objItem, columnName));

            //Get Item Tax Percent
            columnName = itemTablePrefix + "ProductTaxPercent";
            decimal taxPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(objItem, columnName));

            //Set Extended Cost
            columnName = itemTablePrefix + "ExtCost";
            decimal extCost = unitCost * qty;
            //extCost = Math.Round(extCost, decimalNumber);
            dbUtil.SetPropertyValue(objItem, columnName, extCost);

            //Set item discount amount
            decimal discountAmount = extCost * discountPercent / 100;
            //discountAmount = Math.Round(discountAmount, decimalNumber);
            columnName = itemTablePrefix + "DiscountAmount";
            dbUtil.SetPropertyValue(objItem, columnName, discountAmount);

            //Set Item Tax Amount
            columnName = itemTablePrefix + "TaxAmount";
            decimal taxAmount = ((extCost - discountAmount) * taxPercent) / 100;
            //taxAmount = Math.Round(taxAmount, decimalNumber);
            dbUtil.SetPropertyValue(objItem, columnName, taxAmount);

            //Set Item Total Cost
            columnName = itemTablePrefix + "TotalCost";
            dbUtil.SetPropertyValue(objItem, columnName, Math.Round(extCost + taxAmount - discountAmount, 5, MidpointRounding.AwayFromZero));

            //Set Item Exchange Total Cost
            columnName = itemTablePrefix + "ExchangeTotalCost";
            dbUtil.SetPropertyValue(objItem, columnName, Math.Round((extCost + taxAmount - discountAmount) * exchangeRate, 5, MidpointRounding.AwayFromZero));

            //Get item factor
            columnName = itemTablePrefix + "ProductFactor";
            decimal factor = Convert.ToDecimal(dbUtil.GetPropertyValue(objItem, columnName));

            //Set Item Exchange Qty
            columnName = itemTablePrefix + "ProductExchangeQty";
            dbUtil.SetPropertyValue(objItem, columnName, qty * factor);

            //Set Item Exchange Unit Cost
            columnName = itemTablePrefix + "ExchangeUnitCost";
            dbUtil.SetPropertyValue(objItem, columnName, unitCost/ (factor != 0 ? factor: 1) * exchangeRate);
            //round by currency
            //BOSApp.RoundByCurrency(objItem, currencyID);

        }
        public void SetProductCostByProductUnitCostForReceiptAcceptanceType(BusinessObject objItem)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String itemTableName = BOSUtil.GetTableNameFromBusinessObject(objItem);
            string mainTablePrefix = mainTableName.Substring(0, mainTableName.Length - 1);
            string itemTablePrefix = itemTableName.Substring(0, itemTableName.Length - 1);

            //Get Exchange Rate
            decimal exchangeRate = Convert.ToDecimal(dbUtil.GetPropertyValue(MainObject, mainTablePrefix + "ExchangeRate"));
            if (exchangeRate == 0)
                exchangeRate = 1;

            //round by currency
            int currencyID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_GECurrencyID"));
            int decimalNumber = BOSApp.GetDecimalNumberByCurrencyID(currencyID);

            //Get Item Qty
            String columnName = itemTablePrefix + "ProductQty";
            decimal qty = Convert.ToDecimal(dbUtil.GetPropertyValue(objItem, columnName));

            columnName = itemTablePrefix + "TotalCost";
            decimal TotalCost = Convert.ToDecimal(dbUtil.GetPropertyValue(objItem, columnName));
            TotalCost = Math.Round(TotalCost, 5, MidpointRounding.AwayFromZero);

            columnName = itemTablePrefix + "ProductUnitCost";
            decimal unitCost = Convert.ToDecimal(dbUtil.GetPropertyValue(objItem, columnName));
            unitCost = Math.Round(unitCost, 5, MidpointRounding.AwayFromZero);

            //Get item discount percent
            columnName = itemTablePrefix + "ProductDiscount";
            decimal discountPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(objItem, columnName));

            //Get Item Tax Percent
            columnName = itemTablePrefix + "ProductTaxPercent";
            decimal taxPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(objItem, columnName));


            //Set Extended Cost
            columnName = itemTablePrefix + "ExtCost";
            decimal extCost = TotalCost;
            dbUtil.SetPropertyValue(objItem, columnName, extCost);

            //Set item discount amount
            decimal discountAmount = extCost * discountPercent / 100;
            discountAmount = Math.Round(discountAmount, decimalNumber);

            columnName = itemTablePrefix + "DiscountAmount";
            dbUtil.SetPropertyValue(objItem, columnName, discountAmount);

            //Set Item Tax Amount
            columnName = itemTablePrefix + "TaxAmount";
            decimal taxAmount = ((extCost - discountAmount) * taxPercent) / 100;
            taxAmount = Math.Round(taxAmount, decimalNumber);
            dbUtil.SetPropertyValue(objItem, columnName, taxAmount);

            //Set Item Total Cost
            columnName = itemTablePrefix + "TotalCost";
            dbUtil.SetPropertyValue(objItem, columnName, extCost + taxAmount - discountAmount);

            //Set Item Exchange Total Cost
            columnName = itemTablePrefix + "ExchangeTotalCost";
            dbUtil.SetPropertyValue(objItem, columnName, (extCost + taxAmount - discountAmount) * exchangeRate);

            //Get item factor
            columnName = itemTablePrefix + "ProductFactor";
            decimal factor = Convert.ToDecimal(dbUtil.GetPropertyValue(objItem, columnName));

            //Set Item Exchange Unit Cost
            columnName = itemTablePrefix + "ExchangeUnitCost";
            dbUtil.SetPropertyValue(objItem, columnName, unitCost / (factor != 0 ? factor : 1) * exchangeRate);

            //Set Item Exchange Qty
            columnName = itemTablePrefix + "ProductExchangeQty";
            dbUtil.SetPropertyValue(objItem, columnName, qty * factor);

            //round by currency
            BOSApp.RoundByCurrency(objItem, currencyID);
        }

        public virtual void SetProductCostByProductUnitCost(ERPModuleItemsEntity entItem, String strItemTableName)
        {
            SetProductCostByProductUnitCost(entItem);
        }

        public virtual void SetProductCostByProductUnitCost()
        {
            String strMainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String strItemTableName = strMainTableName.Substring(0, strMainTableName.Length - 1) + "Items";
            if (ModuleObjects[strItemTableName] != null)
            {
                SetProductCostByProductUnitCost(ModuleObjects[strItemTableName]);
                UpdateModuleObjectBindingSource(strItemTableName);
            }
        }
        public virtual void SetProductCostByProductUnitCostForReceiptAcceptanceType()
        {
            String strMainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String strItemTableName = strMainTableName.Substring(0, strMainTableName.Length - 1) + "Items";
            if (ModuleObjects[strItemTableName] != null)
            {
                SetProductCostByProductUnitCostForReceiptAcceptanceType(ModuleObjects[strItemTableName]);
                UpdateModuleObjectBindingSource(strItemTableName);
            }
        }

        public virtual void SetRoundWoodProductCostByProductUnitCost(string type)
        {
            String strMainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String strItemTableName = strMainTableName.Substring(0, strMainTableName.Length - 1) + "Items";
            if (ModuleObjects[strItemTableName] != null)
            {
                SetRoundWoodProductCostByProductUnitCost(ModuleObjects[strItemTableName], type);
                UpdateModuleObjectBindingSource(strItemTableName);
            }
        }
        public void SetRoundWoodProductCostByProductUnitCost(BusinessObject objItem, string type)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            String itemTableName = BOSUtil.GetTableNameFromBusinessObject(objItem);
            string itemTablePrefix = itemTableName.Substring(0, itemTableName.Length - 1);
            string mainTablePrefix = mainTableName.Substring(0, mainTableName.Length - 1);

            //Get Exchange Rate
            decimal exchangeRate = Convert.ToDecimal(dbUtil.GetPropertyValue(MainObject, mainTablePrefix + "ExchangeRate"));
            if (exchangeRate == 0)
                exchangeRate = 1;

            //round by currency
            int currencyID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_GECurrencyID"));
            int decimalNumber = BOSApp.GetDecimalNumberByCurrencyID(currencyID);
            String columnName = "";
            //Get Item Qty
            //if (type == ReceiptReceiptType.Roundwood.ToString())
            //{
            //    columnName = "ICReceiptItemNotJetExceptBlock";
            //}
            //else
            //{
            columnName = itemTablePrefix + "ProductQty";
            //}
            decimal qty = Convert.ToDecimal(dbUtil.GetPropertyValue(objItem, columnName));

            //Get Item Unit Cost            
            columnName = itemTablePrefix + "ProductUnitCost";
            decimal unitCost = Convert.ToDecimal(dbUtil.GetPropertyValue(objItem, columnName));
            unitCost = Math.Round(unitCost, 5, MidpointRounding.AwayFromZero);

            //Get item discount percent
            columnName = itemTablePrefix + "ProductDiscount";
            decimal discountPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(objItem, columnName));

            //Get Item Tax Percent
            columnName = itemTablePrefix + "ProductTaxPercent";
            decimal taxPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(objItem, columnName));

            //Set Extended Cost
            columnName = itemTablePrefix + "ExtCost";
            decimal extCost = unitCost * qty;
            extCost = Math.Round(extCost, decimalNumber);

            dbUtil.SetPropertyValue(objItem, columnName, extCost);

            //Set item discount amount
            decimal discountAmount = extCost * discountPercent / 100;
            discountAmount = Math.Round(discountAmount, decimalNumber);
            columnName = itemTablePrefix + "DiscountAmount";
            dbUtil.SetPropertyValue(objItem, columnName, discountAmount);

            //Set Item Tax Amount
            columnName = itemTablePrefix + "TaxAmount";
            decimal taxAmount = ((extCost - discountAmount) * taxPercent) / 100;
            taxAmount = Math.Round(taxAmount, decimalNumber);
            dbUtil.SetPropertyValue(objItem, columnName, taxAmount);

            //Set Item Total Cost
            columnName = itemTablePrefix + "TotalCost";
            dbUtil.SetPropertyValue(objItem, columnName, extCost + taxAmount - discountAmount);

            //Set Item Exchange Total Cost
            columnName = itemTablePrefix + "ExchangeTotalCost";
            dbUtil.SetPropertyValue(objItem, columnName, (extCost + taxAmount - discountAmount) * exchangeRate);

            //Get item factor
            columnName = itemTablePrefix + "ProductFactor";
            decimal factor = Convert.ToDecimal(dbUtil.GetPropertyValue(objItem, columnName));

            //Set Item Exchange Unit Cost
            columnName = itemTablePrefix + "ExchangeUnitCost";
            dbUtil.SetPropertyValue(objItem, columnName, unitCost / (factor != 0 ? factor : 1) * exchangeRate);

            //Set Item Exchange Qty
            columnName = itemTablePrefix + "ProductExchangeQty";
            dbUtil.SetPropertyValue(objItem, columnName, qty * factor);

            //round by currency
            BOSApp.RoundByCurrency(objItem, currencyID);
        }

        /// <summary>
        /// Calculate the product cost
        /// </summary>
        /// <param name="productID">Product id</param>
        private decimal CalculateProductCost(int productID)
        {
            decimal productCost = 0;

            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo != null)
            {
                productCost = objProductsInfo.ICProductSupplierPrice;

                ICProductBranchPricesController objProductBranchPricesController = new ICProductBranchPricesController();
                BOSDbUtil dbUtil = new BOSDbUtil();
                int currencyID = dbUtil.GetPropertyIntValue(MainObject, "FK_GECurrencyID");
                ICProductBranchPricesInfo objProductBranchPricesInfo = objProductBranchPricesController.GetProductPriceByProductIDAndBranchIDAndCurrencyIDAndType(
                                                                                                                productID,
                                                                                                                0,
                                                                                                                currencyID,
                                                                                                                ProductBranchPriceType.Purchase.ToString());
                if (objProductBranchPricesInfo != null)
                {
                    productCost = objProductBranchPricesInfo.ICProductBranchPrice;
                }
            }
            return productCost;
        }
        #endregion

        public virtual decimal CalculateItemDiscountAmount(BusinessObject item, int productID, decimal productPrice, DateTime transactionDate, decimal itemQty)
        {
            decimal discountAmount = 0;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo != null)
            {
                objProductsInfo.ICProductPrice01 = productPrice;
                objProductsInfo.ICProductPrice01 = CalculateProductPriceBaseOnProductPriceLevel(objProductsInfo);
                discountAmount += CalculateDiscountAmountFromCustomer(objProductsInfo, transactionDate, itemQty);
                discountAmount += CalculateDiscountAmountFromPromotion(item, objProductsInfo, transactionDate, itemQty);
            }
            return discountAmount;
        }

        public virtual decimal CalculateDiscountAmountFromCustomer(ICProductsInfo objProductsInfo, DateTime transactionDate, decimal itemQty)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            decimal discountAmount = 0;
            String mainTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            int customerID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_ARCustomerID"));
            if (customerID > 0)
            {
                ARCustomersController objCustomersController = new ARCustomersController();
                ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(customerID);
                if (objCustomersInfo != null)
                    discountAmount += (objProductsInfo.ICProductPrice01 * objCustomersInfo.ARCustomerDiscount / 100) * itemQty;
            }
            return discountAmount;
        }

        public virtual decimal CalculateDiscountAmountFromPromotion(BusinessObject item, ICProductsInfo objProductsInfo, DateTime transactionDate, decimal itemQty)
        {
            //Change the quantity of current unit to the quantity of basic unit
            BOSDbUtil dbUtil = new BOSDbUtil();
            int measureUnitID = dbUtil.GetPropertyIntValue(item, "FK_ICMeasureUnitID");
            ICProductUnitsController objProductUnitsController = new ICProductUnitsController();
            ICProductUnitsInfo objProductUnitsInfo = objProductUnitsController.GetProductUnitByProductIDAndUnitID(objProductsInfo.ICProductID, measureUnitID);
            if (objProductUnitsInfo != null)
            {
                itemQty = itemQty * objProductUnitsInfo.ICProductUnitFactor;
            }

            decimal discountAmount = 0;
            //ICPromotionsController objPromotionsController = new ICPromotionsController();
            //ICPromotionItemsController objPromotionItemsController = new ICPromotionItemsController();
            //DataSet ds = objPromotionItemsController.GetAllDataByForeignColumn("FK_ICProductID", objProductsInfo.ICProductID);
            //if (ds.Tables.Count > 0)
            //{
            //    foreach (DataRow row in ds.Tables[0].Rows)
            //    {
            //        ICPromotionItemsInfo objPromotionItemsInfo = (ICPromotionItemsInfo)objPromotionItemsController.GetObjectFromDataRow(row);
            //        ICPromotionsInfo objPromotionsInfo = (ICPromotionsInfo)objPromotionsController.GetObjectByID(objPromotionItemsInfo.FK_ICPromotionID);
            //        if (transactionDate.Date.CompareTo(objPromotionsInfo.ICPromotionStartDate.Date) >= 0 && transactionDate.Date.CompareTo(objPromotionsInfo.ICPromotionEndDate.Date) <= 0)
            //        {
            //            if (objPromotionsInfo.ICPromotionDiscountPercent > 0)
            //                discountAmount += Math.Floor(itemQty / objPromotionsInfo.ICPromotionDiscountQty) * (objPromotionsInfo.ICPromotionDiscountQty * objProductsInfo.ICProductPrice01 * (objPromotionsInfo.ICPromotionDiscountPercent / 100));
            //            else if (objPromotionsInfo.ICPromotionDiscountAmount > 0)
            //                discountAmount += Math.Floor(itemQty / objPromotionsInfo.ICPromotionDiscountQty) * objPromotionsInfo.ICPromotionDiscountAmount;
            //        }
            //    }
            //}
            return discountAmount;
        }

        #region Calculate Product Price

        public virtual decimal CalculateProductPrice(int productID, int measureUnitID)
        {
            decimal dbProductPrice = 0;
            ICProductsController objICProductsController = new ICProductsController();
            ARConfigOriginalUnitPricesController objcfoupController = new ARConfigOriginalUnitPricesController();
            //ARConfigOriginalUnitPricesInfo objconfig = objcfoupController.GetOriginalIsAlive();
            ICProductsInfo objICProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objICProductsInfo != null)
            {
                //Update the product's price by its unit
                //ICProductUnitsController objProductUnitsController = new ICProductUnitsController();
                //ICProductUnitsInfo objProductUnitsInfo = objProductUnitsController.GetProductUnitByProductIDAndUnitID(productID, measureUnitID);
                //if (objProductUnitsInfo != null)
                //{
                //    objICProductsInfo.ICProductPrice01 = objProductUnitsInfo.ICProductUnitPrice;
                //}

                //Update the product's price by the branch and currency
                BOSDbUtil dbUtil = new BOSDbUtil();
                ICProductBranchPricesController objProductBranchPricesController = new ICProductBranchPricesController();
                int currencyID = dbUtil.GetPropertyIntValue(MainObject, "FK_GECurrencyID");
                //H Anh hach code set lại currency theo cấu hình và module
                //if (objconfig != null &&
                //    (Module.Name == ModuleName.SaleOrder
                //    || Module.Name == ModuleName.SaleForecast
                //    //|| Module.Name == ModuleName.Proposal
                //    ))
                //{
                //    if (objconfig.ARConfigOriginalUnitPriceHachCode)
                //    {
                //        currencyID = objconfig.FK_GECurrencyID;
                //    }
                //}
                //ICProductBranchPricesInfo objProductBranchPricesInfo = objProductBranchPricesController.GetProductPriceByProductIDAndBranchIDAndCurrencyIDAndType(
                //                                                                            productID,
                //                                                                            BOSApp.CurrentCompanyInfo.FK_BRBranchID,
                //                                                                            currencyID,
                //                                                                            ProductBranchPriceType.Sale.ToString());
                //if (objProductBranchPricesInfo != null)
                //{
                //    objICProductsInfo.ICProductPrice01 = objProductBranchPricesInfo.ICProductBranchPrice;
                //}
                //else
                //{
                //    objICProductsInfo.ICProductPrice01 = 0;
                //}

                //Update the product's price based on price levels
                dbProductPrice = CalculateProductPriceBaseOnProductPriceLevel(objICProductsInfo);
            }

            return dbProductPrice;
        }

        protected virtual decimal CalculateProductPriceBaseOnProductPriceLevel(ICProductsInfo objICProductsInfo)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
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
        #endregion
        #endregion

        #region Get Range Days and Discount Percent from Payment Term
        public int GetRangeDays1FromPaymentTerm(String strPaymentTerm)
        {
            String strRangeDays1 = strPaymentTerm.Substring(0, 3);
            return Convert.ToInt32(strRangeDays1);
        }

        public decimal GetPercentDiscount1FromPaymentTerm(String strPaymentTerm)
        {
            int index = strPaymentTerm.IndexOf("%");
            String strPercentDiscount = strPaymentTerm.Substring(index - 4, 3);
            return Convert.ToDecimal(strPercentDiscount);
        }

        public int GetRangeDays2FromPaymentTerm(String strPaymentTerm)
        {
            int index = strPaymentTerm.IndexOf(";");
            String strRangeDays2 = strPaymentTerm.Substring(index + 2, 3);
            return Convert.ToInt32(strRangeDays2);
        }

        public decimal GetPercentDiscount2FromPaymentTerm(String strPaymentTerm)
        {
            int index = strPaymentTerm.LastIndexOf("%");

            String strPercentDiscount = strPaymentTerm.Substring(index - 4, 3);
            return Convert.ToDecimal(strPercentDiscount);
        }

        public int GetRangeDays3FromPaymentTerm(String strPaymentTerm)
        {
            int index = strPaymentTerm.LastIndexOf(";");
            String strRangeDays3 = strPaymentTerm.Substring(index + 2, 3);
            return Convert.ToInt32(strRangeDays3);
        }
        #endregion

        /// <summary>
        /// Check before update inventory
        /// </summary>
        public virtual bool IsInvalidInventory()
        {
            return false;
        }

        /// <summary>
        /// Get inventory status: empty, less than minimum quantity or greater than maximum quantity
        /// </summary>        
        public virtual InventoryStatus GetInventoryStatus(BusinessObject obj, String itemTableName, String inventoryUpdateType)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            int productID = dbUtil.GetPropertyIntValue(obj, "FK_ICProductID");
            int stockID = dbUtil.GetPropertyIntValue(obj, "FK_ICStockID");
            string serialNo = dbUtil.GetPropertyStringValue(obj, itemTableName.Substring(0, itemTableName.Length - 1) + "ProductSerialNo");
            decimal itemQty = Convert.ToDecimal(dbUtil.GetPropertyValue(obj, itemTableName.Substring(0, itemTableName.Length - 1) + "ProductExchangeQty"));
            if (itemQty == 0)
                itemQty = Convert.ToDecimal(dbUtil.GetPropertyValue(obj, itemTableName.Substring(0, itemTableName.Length - 1) + "ProductQty"));
            return GetInventoryStatus(stockID, productID, serialNo, itemQty, inventoryUpdateType);
        }

        /// <summary>
        /// Get inventory status: empty, less than minimum quantity or greater than maximum quantity
        /// </summary>
        public virtual InventoryStatus GetInventoryStatus(int stockID, int productID, string productSerieNo, decimal itemQty, string inventoryUpdateType)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            string mainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(this.MainObject);
            string mainObjectDatecolumn = mainObjectTableName.Substring(0, mainObjectTableName.Length - 1) + "Date";
            DateTime docDate = Convert.ToDateTime(dbUtil.GetPropertyValue(this.MainObject, mainObjectDatecolumn));
            //Check for enough quantity
            ICTransactionsController transactionCtrl = new ICTransactionsController();

            decimal InventoryStockQuantity = transactionCtrl.GetInventoryStockQty(stockID, productID, string.Empty, docDate);
            itemQty = Math.Round(itemQty, 4);
            //fix error getting wrong inventory stock quantity 
            InventoryStockQuantity = Math.Round(InventoryStockQuantity, 4);
            switch (inventoryUpdateType)
            {
                case TransactionUtil.cstInventoryReceipt:
                    InventoryStockQuantity += itemQty;
                    break;
                case TransactionUtil.cstInventoryShipment:
                    InventoryStockQuantity -= itemQty;
                    break;
                case TransactionUtil.cstInventoryAdjust:
                    InventoryStockQuantity = itemQty;
                    break;
            }
            InventoryStockQuantity = Math.Round(InventoryStockQuantity, 4);
            if (InventoryStockQuantity < 0)
            {
                return InventoryStatus.Empty;
            }

            //fix error getting wrong inventory stock quantity with product serie no
            InventoryStockQuantity = transactionCtrl.GetInventoryStockQty(stockID, productID, productSerieNo, docDate);
            itemQty = Math.Round(itemQty, 4);
            InventoryStockQuantity = Math.Round(InventoryStockQuantity, 4);
            switch (inventoryUpdateType)
            {
                case TransactionUtil.cstInventoryReceipt:
                    InventoryStockQuantity += itemQty;
                    break;
                case TransactionUtil.cstInventoryShipment:
                    InventoryStockQuantity -= itemQty;
                    break;
                case TransactionUtil.cstInventoryAdjust:
                    InventoryStockQuantity = itemQty;
                    break;
            }
            if (InventoryStockQuantity < 0)
            {
                return InventoryStatus.Empty;
            }

            //Check for min, max quantity
            //objInventoryStocksInfo = objInventoryStocksController.GetInventoryStockByProductAndStock(productID, stockID);
            InventoryStockQuantity = transactionCtrl.GetInventoryStockQty(stockID, productID, string.Empty, docDate);
            InventoryStockQuantity = Math.Round(InventoryStockQuantity, 4);
            switch (inventoryUpdateType)
            {
                case TransactionUtil.cstInventoryReceipt:
                    InventoryStockQuantity += itemQty;
                    break;
                case TransactionUtil.cstInventoryShipment:
                    InventoryStockQuantity -= itemQty;
                    break;
                case TransactionUtil.cstInventoryAdjust:
                    InventoryStockQuantity = itemQty;
                    break;
            }
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo != null && objProductsInfo.ICProductStockMax > 0)
            {
                if (DateTime.Now.CompareTo(objProductsInfo.ICProductStockMaxDateFrom) >= 0 && DateTime.Now.CompareTo(objProductsInfo.ICProductStockMaxDateTo) <= 0)
                {
                    if (InventoryStockQuantity > objProductsInfo.ICProductStockMax)
                        return InventoryStatus.GreaterThanMaxQty;
                }
            }
            return InventoryStatus.Valid;
        }

        /// <summary>
        /// Get inventory status: empty, less than minimum quantity or greater than maximum quantity
        /// </summary>
        public virtual InventoryStatus GetInventoryStatusFromCatche(int productID, decimal itemQty, string inventoryUpdateType, decimal InventoryStockQuantity, decimal minMaxQuantity)
        {
            itemQty = Math.Round(itemQty, RoundingNumber.FormatN6);
            //fix error getting wrong inventory stock quantity 
            InventoryStockQuantity = Math.Round(InventoryStockQuantity, RoundingNumber.FormatN6);
            switch (inventoryUpdateType)
            {
                case TransactionUtil.cstInventoryReceipt:
                    InventoryStockQuantity += itemQty;
                    break;
                case TransactionUtil.cstInventoryShipment:
                    InventoryStockQuantity -= itemQty;
                    break;
                case TransactionUtil.cstInventoryAdjust:
                    InventoryStockQuantity = itemQty;
                    break;
            }
            InventoryStockQuantity = Math.Round(InventoryStockQuantity, RoundingNumber.FormatN6);
            if (InventoryStockQuantity < 0)
            {
                return InventoryStatus.Empty;
            }

            //Check for min, max quantity

            minMaxQuantity = Math.Round(minMaxQuantity, RoundingNumber.FormatN6);
            switch (inventoryUpdateType)
            {
                case TransactionUtil.cstInventoryReceipt:
                    minMaxQuantity += itemQty;
                    break;
                case TransactionUtil.cstInventoryShipment:
                    minMaxQuantity -= itemQty;
                    break;
                case TransactionUtil.cstInventoryAdjust:
                    minMaxQuantity = itemQty;
                    break;
            }
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo != null && objProductsInfo.ICProductStockMax > 0)
            {
                if (DateTime.Now.CompareTo(objProductsInfo.ICProductStockMaxDateFrom) >= 0 && DateTime.Now.CompareTo(objProductsInfo.ICProductStockMaxDateTo) <= 0)
                {
                    if (minMaxQuantity > objProductsInfo.ICProductStockMax)
                        return InventoryStatus.GreaterThanMaxQty;
                }
            }
            return InventoryStatus.Valid;
        }

        public virtual InventoryStatus GetInventoryStatus(int stockID, int productID, int productSerieID, decimal itemQty, string inventoryUpdateType)
        {
            int userGroupID = BOSApp.CurrentUserGroupInfo.ADUserGroupID;
            //Check for enough quantity
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            ICInventoryStocksInfo objInventoryStocksInfo = null;
            if (productSerieID > 0)
            {
                objInventoryStocksInfo = objInventoryStocksController.GetSingleInventoryStockByStockIDAndProductIDAndSerieID(stockID, productID, productSerieID, userGroupID);
            }
            else
            {
                objInventoryStocksInfo = objInventoryStocksController.GetSingleInventoryStockByStockIDAndProductIDAndSerieID(stockID, productID, null, userGroupID);
            }
            if (objInventoryStocksInfo == null)
            {
                objInventoryStocksInfo = new ICInventoryStocksInfo();
            }
            itemQty = Math.Round(itemQty, 4);
            //fix error getting wrong inventory stock quantity 
            objInventoryStocksInfo.ICInventoryStockQuantity = Math.Round(objInventoryStocksInfo.ICInventoryStockQuantity, 4);
            switch (inventoryUpdateType)
            {
                case TransactionUtil.cstInventoryReceipt:
                    objInventoryStocksInfo.ICInventoryStockQuantity += itemQty;
                    break;
                case TransactionUtil.cstInventoryShipment:
                    objInventoryStocksInfo.ICInventoryStockQuantity -= itemQty;
                    break;
                case TransactionUtil.cstInventoryAdjust:
                    objInventoryStocksInfo.ICInventoryStockQuantity = itemQty;
                    break;
            }
            if (objInventoryStocksInfo.ICInventoryStockQuantity < 0)
            {
                return InventoryStatus.Empty;
            }

            //Check for min, max quantity
            objInventoryStocksInfo = objInventoryStocksController.GetSingleInventoryStockByStockIDAndProductIDAndSerieID(stockID, productID, null, userGroupID);
            if (objInventoryStocksInfo == null)
            {
                objInventoryStocksInfo = new ICInventoryStocksInfo();
            }

            //fix error getting wrong inventory stock quantity 
            objInventoryStocksInfo.ICInventoryStockQuantity = Math.Round(objInventoryStocksInfo.ICInventoryStockQuantity, 4);
            switch (inventoryUpdateType)
            {
                case TransactionUtil.cstInventoryReceipt:
                    objInventoryStocksInfo.ICInventoryStockQuantity += itemQty;
                    break;
                case TransactionUtil.cstInventoryShipment:
                    objInventoryStocksInfo.ICInventoryStockQuantity -= itemQty;
                    break;
                case TransactionUtil.cstInventoryAdjust:
                    objInventoryStocksInfo.ICInventoryStockQuantity = itemQty;
                    break;
            }

            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo != null && objProductsInfo.ICProductStockMax > 0)
            {
                if (DateTime.Now.CompareTo(objProductsInfo.ICProductStockMaxDateFrom) >= 0 && DateTime.Now.CompareTo(objProductsInfo.ICProductStockMaxDateTo) <= 0)
                {
                    if (objInventoryStocksInfo.ICInventoryStockQuantity > objProductsInfo.ICProductStockMax)
                        return InventoryStatus.GreaterThanMaxQty;
                }
            }
            return InventoryStatus.Valid;
        }

        /// <summary>
        /// Synchronize serie for an object when transferring from a branch to another
        /// </summary>
        /// <param name="obj">Given object</param>
        public void SynProductSerie(BusinessObject obj)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            string serieNo = dbUtil.GetPropertyStringValue(obj, "ICProductSerieNo");
            int productID = dbUtil.GetPropertyIntValue(obj, "FK_ICProductID");
            DateTime receiptDate = Convert.ToDateTime(dbUtil.GetPropertyValue(obj, "ICProductSerieReceiptDate"));
            if (!string.IsNullOrEmpty(serieNo))
            {
                ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
                ICProductSeriesInfo objProductSeriesInfo = objProductSeriesController.GetSerieByProductIDAndSerieNo(productID, serieNo);
                if (objProductSeriesInfo != null)
                {
                    dbUtil.SetPropertyValue(obj, "FK_ICProductSerieID", objProductSeriesInfo.ICProductSerieID);
                }
                else
                {
                    objProductSeriesInfo = new ICProductSeriesInfo();
                    objProductSeriesInfo.AACreatedDate = DateTime.Now;
                    objProductSeriesInfo.FK_ICProductID = productID;
                    objProductSeriesInfo.ICProductSerieNo = serieNo;
                    objProductSeriesInfo.ICProductSerieReceiptDate = receiptDate;
                    int serieID = objProductSeriesController.CreateObject(objProductSeriesInfo);

                    dbUtil.SetPropertyValue(obj, "FK_ICProductSerieID", serieID);
                }
            }
        }

        #region Asset
        /// <summary>
        /// Set values to a given item after choosing an asset
        /// </summary>
        /// <param name="item">Item contains the asset</param>
        public virtual void SetValuesAfterValidatingAsset(BusinessObject item)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            int assetID = dbUtil.GetPropertyIntValue(item, "FK_ACAssetID");
            SetDefaultValuesFromAsset(assetID, item);
            CalculateItemCost(item);
        }

        /// <summary>
        /// Set default values of an asset to a given item
        /// </summary>
        /// <param name="assetID">Asset id</param>
        /// <param name="item">Item contains the asset</param>
        public virtual void SetDefaultValuesFromAsset(int assetID, BusinessObject item)
        {
            ACAssetsController objAssetsController = new ACAssetsController();
            ACAssetsInfo objAssetsInfo = (ACAssetsInfo)objAssetsController.GetObjectByID(assetID);
            if (objAssetsInfo != null)
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                string itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
                string itemTablePrefix = itemTableName.Substring(0, itemTableName.Length - 1);

                string assetNo = dbUtil.GetPropertyStringValue(objAssetsInfo, "ACAssetNo");
                dbUtil.SetPropertyValue(item, "ACAssetNo", assetNo);

                string assetName = dbUtil.GetPropertyStringValue(objAssetsInfo, "ACAssetName");
                dbUtil.SetPropertyValue(item, "ACAssetName", assetName);

                int departmentRoomID = dbUtil.GetPropertyIntValue(objAssetsInfo, "FK_HRDepartmentRoomID");
                dbUtil.SetPropertyValue(item, "FK_HRDepartmentRoomID", departmentRoomID);

                string columnName = itemTablePrefix + "Qty";
                dbUtil.SetPropertyValue(item, columnName, (decimal)1);
            }
        }
        #endregion

        /// <summary>
        /// Calculate costs for a given item
        /// </summary>
        /// <param name="item">Item</param>
        public virtual void CalculateItemCost(BusinessObject item)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            string itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
            string itemTablePrefix = itemTableName.Substring(0, itemTableName.Length - 1);
            //round by currency
            int currencyID = Convert.ToInt32(dbUtil.GetPropertyValue(MainObject, "FK_GECurrencyID"));
            int decimalNumber = BOSApp.GetDecimalNumberByCurrencyID(currencyID);

            //Get quantity
            string columnName = itemTablePrefix + "Qty";
            decimal qty = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));
            if (qty == 0)
            {
                qty = 1;
                dbUtil.SetPropertyValue(item, columnName, 1);
            }

            //Get unit cost            
            columnName = itemTablePrefix + "UnitCost";
            decimal unitCost = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));
            unitCost = Math.Round(unitCost, 5, MidpointRounding.AwayFromZero);
            //Get item discount percent
            columnName = itemTablePrefix + "DiscountPercent";
            decimal itemDiscountPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Get item tax percent
            columnName = itemTablePrefix + "TaxPercent";
            decimal taxPercent = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Set extended cost
            columnName = itemTablePrefix + "ExtCost";
            decimal extCost = unitCost * qty;
            extCost = Math.Round(extCost, decimalNumber);
            dbUtil.SetPropertyValue(item, columnName, extCost);

            //Set item discount amount            
            decimal discountAmount = extCost * itemDiscountPercent / 100;
            discountAmount = Math.Round(discountAmount, decimalNumber);
            columnName = itemTablePrefix + "DiscountAmount";
            dbUtil.SetPropertyValue(item, columnName, discountAmount);

            //Set item tax amount
            columnName = itemTablePrefix + "TaxAmount";
            decimal taxAmount = ((extCost - discountAmount) * taxPercent) / 100;
            taxAmount = Math.Round(taxAmount, decimalNumber);
            dbUtil.SetPropertyValue(item, columnName, taxAmount);

            //Set item total cost
            columnName = itemTablePrefix + "TotalCost";
            dbUtil.SetPropertyValue(item, columnName, extCost + taxAmount - discountAmount);

            //round by currency
            BOSApp.RoundByCurrency(item, currencyID);
        }

        /// <summary>
        /// Get inventory status: empty, less than minimum quantity or greater than maximum quantity
        /// </summary>        
        public virtual InventoryStatus GetInventoryStatus(BusinessObject obj, String itemTableName, String inventoryUpdateType, String qtyColumnName, Boolean isColumQty)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            int productID = dbUtil.GetPropertyIntValue(obj, "FK_ICProductID");
            int stockID = dbUtil.GetPropertyIntValue(obj, "FK_ICStockID");
            int productSerieID = dbUtil.GetPropertyIntValue(obj, "FK_ICProductSerieID");
            decimal itemQty = Convert.ToDecimal(dbUtil.GetPropertyValue(obj, qtyColumnName));
            return GetInventoryStatus(stockID, productID, productSerieID, itemQty, inventoryUpdateType);
        }

        /// <summary>
        /// Get inventory status: empty, less than minimum quantity or greater than maximum quantity
        /// </summary>        
        public virtual InventoryStatus GetInventoryStatus(BusinessObject obj, String itemTableName, String inventoryUpdateType, decimal itemQty, Boolean isColumQty)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            int productID = dbUtil.GetPropertyIntValue(obj, "FK_ICProductID");
            int stockID = dbUtil.GetPropertyIntValue(obj, "FK_ICStockID");
            int productSerieID = dbUtil.GetPropertyIntValue(obj, "FK_ICProductSerieID");
            //decimal itemQty = Convert.ToDecimal(dbUtil.GetPropertyValue(obj, qtyColumnName));
            return GetInventoryStatus(stockID, productID, productSerieID, itemQty, inventoryUpdateType);
        }

        public virtual InventoryStatus GetInventoryStatusByAllStock(BusinessObject obj, String itemTableName, String inventoryUpdateType, decimal itemQty, Boolean isColumQty)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            int productID = dbUtil.GetPropertyIntValue(obj, "FK_ICProductID");
            int stockID = dbUtil.GetPropertyIntValue(obj, "FK_ICStockID");
            int serialID = dbUtil.GetPropertyIntValue(obj, "FK_ICProductSerieID");
            //string productSerieNo = dbUtil.GetPropertyStringValue(obj, itemTableName.Substring(0, itemTableName.Length - 1) + "ProductSerialNo");
            //int productSerieID = dbUtil.GetPropertyIntValue(obj, "FK_ICProductSerieID");
            //decimal itemQty = Convert.ToDecimal(dbUtil.GetPropertyValue(obj, qtyColumnName));
            return GetInventoryStatusByAllStock(stockID, productID, serialID, itemQty, inventoryUpdateType);
        }

        public virtual InventoryStatus GetInventoryStatusByAllStock(int stockID, int productID, int serialID, decimal itemQty, string inventoryUpdateType)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            string mainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(this.MainObject);
            string mainObjectDatecolumn = mainObjectTableName.Substring(0, mainObjectTableName.Length - 1) + "Date";
            DateTime docDate = Convert.ToDateTime(dbUtil.GetPropertyValue(this.MainObject, mainObjectDatecolumn));
            //Check for enough quantity
            //ICTransactionsController transactionCtrl = new ICTransactionsController();
            //decimal InventoryStockQuantity = transactionCtrl.GetInventoryStockQty(stockID, productID, productSerieNo, docDate);

            List<ICInventoryStocksInfo> inventoryStocks = new List<ICInventoryStocksInfo>();
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            inventoryStocks = objInventoryStocksController.GetInventoryStocksByProductIDAndStockID(productID, stockID, serialID, 0);
            inventoryStocks = inventoryStocks.Union(objInventoryStocksController.GetInventoryStocksByProductIDAndStockID(productID, stockID)).ToList();
            inventoryStocks = inventoryStocks.Where(i => i.ICInventoryStockQuantity > 0).ToList();

            decimal onHandQty = inventoryStocks.Where(i => i.ICStockType == StockType.Sale.ToString() || i.ICStockType == StockType.Central.ToString())
                                               .Sum(i => i.ICInventoryStockQuantity);
            decimal saleOrderQty = inventoryStocks.Where(i => i.ICStockType == StockType.SaleOrder.ToString())
                                                .Sum(i => i.ICInventoryStockQuantity);
            decimal purchaseOrderQty = inventoryStocks.Where(i => i.ICStockType == StockType.Purchase.ToString())
                                                .Sum(i => i.ICInventoryStockQuantity);
            decimal transitInQty = inventoryStocks.Where(i => i.ICStockType == StockType.TransitIn.ToString())
                                                .Sum(i => i.ICInventoryStockQuantity);
            decimal transitOutQty = inventoryStocks.Where(i => i.ICStockType == StockType.TransitOut.ToString())
                                                .Sum(i => i.ICInventoryStockQuantity);
            decimal woodPlanQty = inventoryStocks.Where(i => i.ICStockType == StockType.AllocationPlan.ToString())
                                                .Sum(i => i.ICInventoryStockQuantity);

            decimal InventoryStockQuantity = (onHandQty + purchaseOrderQty) - (saleOrderQty + woodPlanQty);

            itemQty = Math.Round(itemQty, 4);
            //fix error getting wrong inventory stock quantity 
            InventoryStockQuantity = Math.Round(InventoryStockQuantity, 4);
            switch (inventoryUpdateType)
            {
                case TransactionUtil.cstInventoryReceipt:
                    InventoryStockQuantity += itemQty;
                    break;
                case TransactionUtil.cstInventoryShipment:
                    InventoryStockQuantity -= itemQty;
                    break;
                case TransactionUtil.cstInventoryAdjust:
                    InventoryStockQuantity = itemQty;
                    break;
            }
            if (InventoryStockQuantity < 0)
            {
                return InventoryStatus.Empty;
            }

            //Check for min, max quantity
            //objInventoryStocksInfo = objInventoryStocksController.GetInventoryStockByProductAndStock(productID, stockID);
            //InventoryStockQuantity = transactionCtrl.GetInventoryStockQty(stockID, productID, string.Empty, docDate);
            //InventoryStockQuantity = Math.Round(InventoryStockQuantity, 4);
            //switch (inventoryUpdateType)
            //{
            //    case TransactionUtil.cstInventoryReceipt:
            //        InventoryStockQuantity += itemQty;
            //        break;
            //    case TransactionUtil.cstInventoryShipment:
            //        InventoryStockQuantity -= itemQty;
            //        break;
            //    case TransactionUtil.cstInventoryAdjust:
            //        InventoryStockQuantity = itemQty;
            //        break;
            //}
            //ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            //if (objProductsInfo != null && objProductsInfo.ICProductStockMax > 0)
            //{
            //    if (DateTime.Now.CompareTo(objProductsInfo.ICProductStockMaxDateFrom) >= 0 && DateTime.Now.CompareTo(objProductsInfo.ICProductStockMaxDateTo) <= 0)
            //    {
            //        if (InventoryStockQuantity > objProductsInfo.ICProductStockMax)
            //            return InventoryStatus.GreaterThanMaxQty;
            //    }
            //}
            return InventoryStatus.Valid;
        }
    }
}
