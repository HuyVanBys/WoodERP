﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMPurchasePlanInPutItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMPurchasePlanInPutItemsController
    //Created Date:Saturday, April 20, 2019
    //-----------------------------------------------------------

    public class MMPurchasePlanInPutItemsController : BaseBusinessController
    {
        public MMPurchasePlanInPutItemsController()
        {
            dal = new DALBaseProvider("MMPurchasePlanInPutItems", typeof(MMPurchasePlanInPutItemsInfo));
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<MMPurchasePlanInPutItemsInfo> countries = new List<MMPurchasePlanInPutItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMPurchasePlanInPutItemsInfo objCountrysInfo = (MMPurchasePlanInPutItemsInfo)GetObjectFromDataRow(row);
                    countries.Add(objCountrysInfo);
                }
            }
            ds.Dispose();
            return countries;
        }

        public List<MMPurchasePlanInPutItemsInfo> GetListForTransfer()
        {
            DataSet ds = dal.GetDataSet("MMPurchasePlanInPutItems_GetListForTransfer");
            return (List<MMPurchasePlanInPutItemsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}