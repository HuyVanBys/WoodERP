﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region GEHistoryDetailOfProductBranchPrices
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:GEHistoryDetailOfProductBranchPricesController
    //Created Date:Friday, May 03, 2013
    //-----------------------------------------------------------

    public class GEHistoryDetailOfProductBranchPricesController : BaseBusinessController
    {
        public GEHistoryDetailOfProductBranchPricesController()
        {
            dal = new DALBaseProvider("GEHistoryDetailOfProductBranchPrices", typeof(GEHistoryDetailOfProductBranchPricesInfo));
        }

        /// <summary>
        /// Get history of product branch price by ID
        /// </summary>
        /// <param name="productID">ID product</param>
        /// <returns>List of product branch price</returns>
        public List<GEHistoryDetailOfProductBranchPricesInfo> GetHistoryByProductIDAndCurrencyNo(int productID, string currencyNo)
        {
            DataSet ds = dal.GetDataSet("GEHistoryDetailOfProductBranchPrices_GetHistoryDetailByProductIDAndCurrencyNo", productID, currencyNo);
            List<GEHistoryDetailOfProductBranchPricesInfo> historyDetailOfProductBranchPricesList = new List<GEHistoryDetailOfProductBranchPricesInfo>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    GEHistoryDetailOfProductBranchPricesInfo objProductBranchPricesHistoryInfo = (GEHistoryDetailOfProductBranchPricesInfo)GetObjectFromDataRow(row);
                    historyDetailOfProductBranchPricesList.Add(objProductBranchPricesHistoryInfo);
                }
            }
            return historyDetailOfProductBranchPricesList;
        }
    }
    #endregion
}