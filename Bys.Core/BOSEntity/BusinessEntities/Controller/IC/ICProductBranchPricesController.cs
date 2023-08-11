﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ICProductBranchPrices
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICProductBranchPricesController
    //Created Date:Tuesday, September 27, 2011
    //-----------------------------------------------------------

    public class ICProductBranchPricesController : BaseBusinessController
    {
        public ICProductBranchPricesController()
        {
            dal = new DALBaseProvider("ICProductBranchPrices", typeof(ICProductBranchPricesInfo));
        }

        /// <summary>
        /// Get product branch price by branch id and product id.
        /// </summary>
        /// <param name="branchID">The branch id</param>
        /// <param name="productID">The product id</param>
        /// <returns>Info of product branch price</returns>
        public ICProductBranchPricesInfo GetDataByBranchIDAndProductID(int branchID, int productID)
        {
            DataSet ds = dal.GetDataSet("ICProductBranchPrices_GetDataByBranchIDAndProductID", branchID, productID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ICProductBranchPricesController objProductBranchPricesController = new ICProductBranchPricesController();
                ICProductBranchPricesInfo objProductBranchPricesInfo = (ICProductBranchPricesInfo)objProductBranchPricesController.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                return objProductBranchPricesInfo;
            }
            else
                return null;
        }

        /// <summary>
        /// Get product branch price by product branch price id and product branch price type
        /// </summary>
        ///<param name="productBranchPriceID">The product id</param>
        /// <param name="productPriceType">The product branch price type</param>
        /// <returns>List of product branh price</returns>
        public List<ICProductBranchPricesInfo> GetProductBranchPriceByProductIDAndType(int productID, string productPriceType)
        {
            DataSet ds = dal.GetDataSet("ICProductBranchPrices_GetProductBranchPriceByProductIDAndType", productID, productPriceType);
            List<ICProductBranchPricesInfo> productBranchPrices = new List<ICProductBranchPricesInfo>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                ICProductBranchPricesController objProductBranchPricesController = new ICProductBranchPricesController();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ICProductBranchPricesInfo objProductBranchPricesInfo = (ICProductBranchPricesInfo)objProductBranchPricesController.GetObjectFromDataRow(dr);
                    productBranchPrices.Add(objProductBranchPricesInfo);
                }
            }
            return productBranchPrices;
        }

        /// <summary>
        /// Get the price of a product by branch, curreny and type
        /// </summary>
        /// <param name="productID">Product id</param>
        /// <param name="branchID">Branch id</param>
        /// <param name="currencyID">Currency id</param>
        /// <param name="type">Type of price</param>
        /// <returns>Product price object</returns>
        public ICProductBranchPricesInfo GetProductPriceByProductIDAndBranchIDAndCurrencyIDAndType(int productID, int branchID, int currencyID, string type)
        {
            return (ICProductBranchPricesInfo)dal.GetDataObject("ICProductBranchPrices_GetPriceByProductIDAndBranchIDAndCurrenyIDAndType",
                                      productID,
                                      branchID,
                                      currencyID,
                                      type);
        }
    }
    #endregion
}