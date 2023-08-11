﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMProductPrices
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProductPricesController
    //Created Date:Monday, December 07, 2015
    //-----------------------------------------------------------

    public class MMProductPricesController : BaseBusinessController
    {
        public MMProductPricesController()
        {
            dal = new DALBaseProvider("MMProductPrices", typeof(MMProductPricesInfo));
        }

        public List<MMProductPricesInfo> GetProductPriceByDate(DateTime fromDate, DateTime toDate)
        {
            List<MMProductPricesInfo> productPriceList = new List<MMProductPricesInfo>();

            DataSet ds = dal.GetDataSet("MMProductPrices_GetProductPriceByDate", fromDate, toDate);

            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMProductPricesInfo objProductPricesInfo = (MMProductPricesInfo)GetObjectFromDataRow(row);
                    productPriceList.Add(objProductPricesInfo);
                }
            }
            return productPriceList;
        }
    }
    #endregion
}