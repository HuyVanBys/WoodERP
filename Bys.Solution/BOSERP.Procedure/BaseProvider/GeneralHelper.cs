using BOSLib;
using System;

namespace BOSERP
{
    public class GeneralHelper
    {
        /// <summary>
        /// Code and Solution based on ERPLamVietV2's source code, just design for using in multiple modules
        /// </summary>
        /// <param name="item"></param>
        /// <param name="newMeasureUnitID"></param>
        public static void ChangePurchaseItemMeasureUnitID(BusinessObject item, int newMeasureUnitID)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String strTableName = BOSUtil.GetTableNameFromBusinessObject(item);
            ICProductMeasureUnitsController objProductMeasureUnitsController = new ICProductMeasureUnitsController();

            dbUtil.SetPropertyValue(item, "FK_ICMeasureUnitID", newMeasureUnitID);
            int productID = 0;
            int measureUnitBeforeChangeID = 0;
            int.TryParse(dbUtil.GetPropertyValue(item, "FK_ICProductID").ToString(), out productID);
            int.TryParse(dbUtil.GetPropertyValue(item, "FK_ICMeasureUnitBeforeChangeID").ToString(), out measureUnitBeforeChangeID);

            decimal factor = CalculateProductMeasureUnitFactor(productID, measureUnitBeforeChangeID, newMeasureUnitID);

            decimal productQty = decimal.Parse(dbUtil.GetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductQty").ToString());
            decimal unitCost = decimal.Parse(dbUtil.GetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductUnitCost").ToString());
            unitCost = Math.Round(unitCost / factor, 2, MidpointRounding.AwayFromZero);

            ICProductMeasureUnitsInfo objProductMeasureUnitsInfo = objProductMeasureUnitsController.GetProductMeasureUnitByProductIDAndMeasureUnitID(productID, newMeasureUnitID);
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo != null && objProductsInfo.FK_ICProductBasicUnitID == newMeasureUnitID)
                dbUtil.SetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductFactor", (decimal)1);
            else if (objProductMeasureUnitsInfo != null)
                dbUtil.SetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductFactor", objProductMeasureUnitsInfo.ICProductMeasureUnitFactor);
            dbUtil.SetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductQty", Math.Round(productQty * factor,5,MidpointRounding.AwayFromZero));
            dbUtil.SetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductUnitCost", unitCost);
            dbUtil.SetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ExchangeUnitCost", unitCost / ((objProductMeasureUnitsInfo == null|| objProductMeasureUnitsInfo.ICProductMeasureUnitFactor ==0 ) ? 1 : objProductMeasureUnitsInfo.ICProductMeasureUnitFactor));
        }
        /// <summary>
        /// Code and Solution based on ERPLamVietV2's source code, just design for using in multiple modules
        /// </summary>
        /// <param name="item"></param>
        /// <param name="newMeasureUnitID"></param>
        public static void ChangeSaleItemMeasureUnitID(BusinessObject item, int newMeasureUnitID)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String strTableName = BOSUtil.GetTableNameFromBusinessObject(item);
            ICProductMeasureUnitsController objProductMeasureUnitsController = new ICProductMeasureUnitsController();

            dbUtil.SetPropertyValue(item, "FK_ICMeasureUnitID", newMeasureUnitID);
            int productID = 0;
            int measureUnitBeforeChangeID = 0;
            int.TryParse(dbUtil.GetPropertyValue(item, "FK_ICProductID").ToString(), out productID);
            int.TryParse(dbUtil.GetPropertyValue(item, "FK_ICMeasureUnitBeforeChangeID").ToString(), out measureUnitBeforeChangeID);

            decimal factor = CalculateProductMeasureUnitFactor(productID, measureUnitBeforeChangeID, newMeasureUnitID);

            decimal productQty = decimal.Parse(dbUtil.GetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductQty").ToString());
            decimal unitPrice = decimal.Parse(dbUtil.GetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductUnitPrice").ToString());
            object stringUnitPrice2 = dbUtil.GetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductUnitPrice2");
            decimal unitPrice2 = 0;
            if (stringUnitPrice2 != null)
            {
                unitPrice2 = decimal.Parse(stringUnitPrice2.ToString());
            }    
            
            unitPrice = Math.Round(unitPrice / factor, 2, MidpointRounding.AwayFromZero);
            unitPrice2 = Math.Round(unitPrice2 / factor, 2, MidpointRounding.AwayFromZero);

            ICProductMeasureUnitsInfo objProductMeasureUnitsInfo = objProductMeasureUnitsController.GetProductMeasureUnitByProductIDAndMeasureUnitID(productID, newMeasureUnitID);
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo != null && objProductsInfo.FK_ICProductBasicUnitID == newMeasureUnitID)
                dbUtil.SetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductFactor", (decimal)1);
            else if (objProductMeasureUnitsInfo != null)
                dbUtil.SetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductFactor", objProductMeasureUnitsInfo.ICProductMeasureUnitFactor);

            stringUnitPrice2 = dbUtil.GetPropertyValue(item, "ICProductUnitPrice");
            decimal productUnitPrice = 0;
            if (stringUnitPrice2 != null)
            {
                productUnitPrice = decimal.Parse(stringUnitPrice2.ToString());
            }            
            productUnitPrice = Math.Round(productUnitPrice / factor, 2, MidpointRounding.AwayFromZero);

            dbUtil.SetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductQty", productQty * factor);
            dbUtil.SetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductUnitPrice", unitPrice);
            dbUtil.SetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductUnitPrice2", unitPrice2);
            dbUtil.SetPropertyValue(item, "ICProductUnitPrice", productUnitPrice);
        }

        public static decimal CalculateProductMeasureUnitFactor(int productID, int measureUnitBeforeChangeID, int newMeasureUnitID)
        {
            ICProductMeasureUnitsController objProductMeasureUnitsController = new ICProductMeasureUnitsController();
            ICProductMeasureUnitsInfo objProductMeasureUnitsInfo = objProductMeasureUnitsController.GetProductMeasureUnitByProductIDAndMeasureUnitID(productID, newMeasureUnitID);
            ICProductMeasureUnitsInfo objBeforeChangeProductMeasureUnitsInfo = objProductMeasureUnitsController.GetProductMeasureUnitByProductIDAndMeasureUnitID(productID, measureUnitBeforeChangeID);
            decimal factor = (objBeforeChangeProductMeasureUnitsInfo == null || objBeforeChangeProductMeasureUnitsInfo.ICProductMeasureUnitFactor == 0 ? 1 : objBeforeChangeProductMeasureUnitsInfo.ICProductMeasureUnitFactor)
                                                                   / (objProductMeasureUnitsInfo == null || objProductMeasureUnitsInfo.ICProductMeasureUnitFactor == 0 ? 1 : objProductMeasureUnitsInfo.ICProductMeasureUnitFactor);
            return factor;
        }

        public static void ChangeDeliveryItemMeasureUnitID(BusinessObject item, int newMeasureUnitID)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String strTableName = BOSUtil.GetTableNameFromBusinessObject(item);

            dbUtil.SetPropertyValue(item, "FK_ICMeasureUnitID", newMeasureUnitID);
            int productID = 0;
            int measureUnitBeforeChangeID = 0;
            int.TryParse(dbUtil.GetPropertyValue(item, "FK_ICProductID").ToString(), out productID);
            int.TryParse(dbUtil.GetPropertyValue(item, "FK_ICMeasureUnitBeforeChangeID").ToString(), out measureUnitBeforeChangeID);

            decimal factor = CalculateProductMeasureUnitFactor(productID, measureUnitBeforeChangeID, newMeasureUnitID);

            decimal productQty = decimal.Parse(dbUtil.GetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductQty").ToString());

            dbUtil.SetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductQty", productQty * factor);
        }

        public static void ChangeShipmenttemMeasureUnitID(BusinessObject item, int newMeasureUnitID)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            String strTableName = BOSUtil.GetTableNameFromBusinessObject(item);
            ICProductsController objProductsController = new ICProductsController();
            ICProductMeasureUnitsController objProductMeasureUnitsController = new ICProductMeasureUnitsController();

            dbUtil.SetPropertyValue(item, "FK_ICMeasureUnitID", newMeasureUnitID);
            int productID = 0;
            int measureUnitBeforeChangeID = 0;
            int.TryParse(dbUtil.GetPropertyValue(item, "FK_ICProductID").ToString(), out productID);
            int.TryParse(dbUtil.GetPropertyValue(item, "FK_ICMeasureUnitBeforeChangeID").ToString(), out measureUnitBeforeChangeID);

            decimal factor = CalculateProductMeasureUnitFactor(productID, measureUnitBeforeChangeID, newMeasureUnitID);

            decimal productQty = decimal.Parse(dbUtil.GetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductQty").ToString());
            decimal unitCost = decimal.Parse(dbUtil.GetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductUnitCost").ToString());
            decimal unitPrice = decimal.Parse(dbUtil.GetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductUnitPrice").ToString());
            unitCost = Math.Round(unitCost / factor, 2, MidpointRounding.AwayFromZero);
            unitPrice = Math.Round(unitPrice / factor, 2, MidpointRounding.AwayFromZero);

            ICProductMeasureUnitsInfo objProductMeasureUnitsInfo = objProductMeasureUnitsController.GetProductMeasureUnitByProductIDAndMeasureUnitID(productID, newMeasureUnitID);
            ICProductsInfo objProductsInfo = BOSApp.GetProductFromCurrentProductList(productID);
            if (objProductsInfo != null && objProductsInfo.FK_ICProductBasicUnitID == newMeasureUnitID)
                dbUtil.SetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductFactor", (decimal)1);
            else if (objProductMeasureUnitsInfo != null)
                dbUtil.SetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductFactor", objProductMeasureUnitsInfo.ICProductMeasureUnitFactor);
            dbUtil.SetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductQty", productQty * factor);
            dbUtil.SetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductUnitCost", unitCost);
            dbUtil.SetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ExchangeUnitCost", unitCost / ((objProductMeasureUnitsInfo == null || objProductMeasureUnitsInfo.ICProductMeasureUnitFactor == 0) ? 1 : objProductMeasureUnitsInfo.ICProductMeasureUnitFactor));
            dbUtil.SetPropertyValue(item, strTableName.Substring(0, strTableName.Length - 1) + "ProductUnitPrice", unitPrice);
        }
    }
}
