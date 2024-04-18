using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Data;
using System.Linq;


namespace BOSERP.Modules.ProductionPlanning
{
    public class ProductionPlanningEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the receipt item list
        /// </summary>
        public BOSList<ARProductionPlanningItemsInfo> ProductionPlanningItemList { get; set; }

        #endregion

        #region Constructor
        public ProductionPlanningEntities()
            : base()
        {
            ProductionPlanningItemList = new BOSList<ARProductionPlanningItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ARProductionPlanningsInfo();
            SearchObject = new ARProductionPlanningsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARProductionPlanningItemsTablename, new ARProductionPlanningItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            ProductionPlanningItemList.InitBOSList(this,
                                                   TableName.ARProductionPlanningsTableName,
                                                   TableName.ARProductionPlanningItemsTablename,
                                                   BOSList<ARProductionPlanningItemsInfo>.cstRelationForeign);
            ProductionPlanningItemList.ItemTableForeignKey = "FK_ARProductionPlanningID";
        }

        public override void InitGridControlInBOSList()
        {
            ProductionPlanningItemList.InitBOSListGridControl(ProductionPlanningModule.ProductionPlanningItemGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ProductionPlanningItemList.SetDefaultListAndRefreshGridControl();
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

            ARProductionPlanningsInfo mainobject = (ARProductionPlanningsInfo)MainObject;
            DateTime today = BOSApp.GetCurrentServerDate();
            MMWorkShopsController objWorkShopsController = new MMWorkShopsController();
            MMWorkShopsInfo objWorkShopsInfo = objWorkShopsController.GetAllWorkShops().FirstOrDefault();
            mainobject.ARProductionPlanningDate = today;
            mainobject.ARProductionPlanningFromDate = today;
            mainobject.ARProductionPlanningToDate = today.AddMonths(1);
            mainobject.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            mainobject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            mainobject.ARProductionPlanningName = DefinePlanningName(mainobject.ARProductionPlanningFromDate, mainobject.ARProductionPlanningToDate);
            mainobject.ARProductionPlanningDesc = new byte[0];
            if (objWorkShopsInfo != null)
            {
                mainobject.FK_MMWorkShopID = objWorkShopsInfo.MMWorkShopID;
            }    
            
            UpdateMainObjectBindingSource();
        }

        public string DefinePlanningName(DateTime FromDate, DateTime ToDate)
        {
            string result = string.Empty;

            result = string.Format(ProductionPlanningLocalizedResources.ARProductionPlanningNameSampleText
                                   , FromDate.ToString("dd/MM/yyyy") + "-" + ToDate.ToString("dd/MM/yyyy"));
            return result;
        }

        #region Invalidate Module Objects Functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            //ProductionPlanningItemList.Invalidate(iObjectID);
            ARProductionPlanningItemsController objProductionPlanningItemsController = new ARProductionPlanningItemsController();
            DataSet ds = objProductionPlanningItemsController.GetProductionPlanningItemListDataSetByProductionPlanningID(iObjectID);
            ProductionPlanningItemList.Invalidate(ds);
        }
        #endregion

        #region Save Module Objects Functions
        public override void SaveModuleObjects()
        {
            ProductionPlanningItemList.SaveItemObjects();
        }
        #endregion

        public override void SetValuesAfterValidateProduct(int iICProductID)
        {
            SetValuesAfterValidateProduct(iICProductID, ModuleObjects[TableName.ARProductionPlanningItemsTablename]);
            UpdateModuleObjectBindingSource(TableName.ARProductionPlanningItemsTablename);
        }

        public override void SetValuesAfterValidateProduct(int productID, BusinessObject item)
        {
            ARProductionPlanningsInfo objARProductionPlanningsInfo = (ARProductionPlanningsInfo)MainObject;
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(productID);
            if (objProductsInfo != null)
            {
                ARProductionPlanningItemsInfo receiptItem = (ARProductionPlanningItemsInfo)item;
                receiptItem.FK_ICProductID = objProductsInfo.ICProductID;
                SetDefaultValuesFromProduct(productID, receiptItem);
                SetProductCost(receiptItem);
                // receiptItem.FK_ICStockID = objARProductionPlanningsInfo.FK_ICStockID;
                receiptItem.FK_ICMeasureUnitID = objProductsInfo.FK_ICProductPurchaseUnitID;
            }
        }

        public override string GetMainObjectNo(ref int numberingStart)
        {
            string mainObjectNo = base.GetMainObjectNo(ref numberingStart);
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARProductionPlanningsInfo mainObject = (ARProductionPlanningsInfo)MainObject;
            //String currentYear = DateTime.Now.ToString("yy");
            string[] objectNo = mainObjectNo.Split('-');
            bool isNewFromSaleOrder = ProductionPlanningItemList.Select(p => p.FK_ARSaleOrderID).Count() > 0 ? true : false;
            //string PI = string.Empty;
            //if (objProposalsInfo.FK_ARSaleOrderID > 0)
            //{
            //    ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(objProposalsInfo.FK_ARSaleOrderID);
            //    if (objSaleOrdersInfo != null)
            //    {
            //        if (PI.Length > 6)
            //            PI = objSaleOrdersInfo.ARSaleOrderNo.Substring(objSaleOrdersInfo.ARSaleOrderNo.Length - 6);
            //    }
            //}

            if (objectNo != null && objectNo.Length > 1)
            {
                if (mainObject != null && mainObject.ARProductionPlanningType == SaleOrderType.FOCSample.ToString() ||
                    mainObject != null && mainObject.ARProductionPlanningType == SaleOrderType.PaymentSample.ToString() ||
                    mainObject != null && mainObject.ARProductionPlanningType == SaleOrderType.PaymentSpareSample.ToString() ||
                    mainObject != null && mainObject.ARProductionPlanningType == SaleOrderType.SpareFOCSample.ToString())
                {
                    mainObjectNo = objectNo[0] + ".M" + "-" + objectNo[1];
                }
                else
                {
                    mainObjectNo =
                        isNewFromSaleOrder
                        ? objectNo[0] + ".M" + "-" + objectNo[1]
                        : objectNo[0] + ".D" + "-" + objectNo[1];
                }
            }
            return mainObjectNo;
        }

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
            int saleOrderID = 0;
            saleOrderID = Convert.ToInt32(dbUtil.GetPropertyValue(item, "FK_ARSaleOrderID"));
            if (saleOrderID == 0 && ProductionPlanningItemList.Count() > 0)
                saleOrderID = (ProductionPlanningItemList.Where(o => o.FK_ARSaleOrderID > 0).FirstOrDefault() == null ? ProductionPlanningItemList.Where(o => o.FK_ARSaleOrderID > 0).FirstOrDefault().FK_ARSaleOrderID : 0);
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            if (saleOrderID > 0)
            {
                ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(saleOrderID);
                if (objSaleOrdersInfo != null)
                {
                    decimalNumber = BOSApp.GetDecimalNumberByCurrencyID(objSaleOrdersInfo.FK_GECurrencyID);
                }
            }
            //Math Round Start
            //ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);

            //Get Item Unit Price
            string columnName = itemTablePrefix + "ProductUnitPrice";
            decimal unitPrice = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));
            if (Module.Name == ModuleName.ShipmentSaleOrder || Module.Name == ModuleName.ProductionPlanning)
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
            columnName = itemTablePrefix + "ExchangeTotalCost";
            dbUtil.SetPropertyValue(item, columnName, (qty * unitCost) * exchangeRate);

            //Set Item Exchange Unit Cost
            columnName = itemTablePrefix + "ExchangeUnitCost";
            dbUtil.SetPropertyValue(item, columnName, unitCost * exchangeRate);

            //Get item factor
            columnName = itemTablePrefix + "ProductFactor";
            decimal factor = Convert.ToDecimal(dbUtil.GetPropertyValue(item, columnName));

            //Set Item Exchange Qty
            columnName = itemTablePrefix + "ProductExchangeQty";
            dbUtil.SetPropertyValue(item, columnName, qty * factor);

            BOSApp.RoundByCurrency(item, currencyID);

            item.OldObject = (BusinessObject)item.Clone();
        }
        public override void DeleteObjectRelations(String strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);
            string strMainObjectTableName = BOSUtil.GetTableNameFromBusinessObject(MainObject);
            if (MainObject != null && strTableName == strMainObjectTableName)
            {
                ProductionPlanningItemList.DeleteItemObjects();
            }
        }

        public override void DuplicateModuleObjectList()
        {
            ProductionPlanningItemList.Duplicate();
            ProductionPlanningItemList.ForEach(o =>
            {
                o.ARProductionPlanningItemID = 0;
                o.FK_ARProductionPlanningID = 0;
                o.FK_ARSaleOrderID = 0;
                o.FK_ARSaleOrderItemID = 0;
                o.ARProductionPlanningItemSaleOrderNo = String.Empty;
                o.ARProductionPlanningItemSaleOrderName = String.Empty;
                o.ARProductionPlanningItemCanceledQty = 0;
                o.ARProductionPlanningItemShippedQty = 0;
                o.ARProductionPlanningItemProductPakagingQty = 0;
            });
        }
    }
}
