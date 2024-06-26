﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARCancelSaleForecastItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARCancelSaleForecastItemsController
    //Created Date:Tuesday, November 10, 2015
    //-----------------------------------------------------------

    public class ARCancelSaleForecastItemsController : BaseBusinessController
    {
        public ARCancelSaleForecastItemsController()
        {
            dal = new DALBaseProvider("ARCancelSaleForecastItems", typeof(ARCancelSaleForecastItemsInfo));
        }

        public List<ARCancelSaleForecastItemsInfo> GetComponentItemsByCancelSaleForecastID(int cancelSaleForecastID)
        {
            DataSet ds = dal.GetDataSet("ARCancelSaleForecastItems_GetComponentItemsByCancelSaleForecastID", cancelSaleForecastID);
            List<ARCancelSaleForecastItemsInfo> cancelSaleForecastItems = new List<ARCancelSaleForecastItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARCancelSaleForecastItemsInfo objCancelSaleForecastItemsInfo = (ARCancelSaleForecastItemsInfo)GetObjectFromDataRow(row);
                    cancelSaleForecastItems.Add(objCancelSaleForecastItemsInfo);
                }
            }
            return cancelSaleForecastItems;
        }
    }
    #endregion
}