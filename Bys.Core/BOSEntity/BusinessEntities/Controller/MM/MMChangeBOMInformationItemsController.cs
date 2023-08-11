﻿using BOSLib;
using System.Data;


namespace BOSERP
{
    #region MMChangeBOMInformationItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMChangeBOMInformationItemsController
    //Created Date:Tuesday, December 01, 2015
    //-----------------------------------------------------------

    public class MMChangeBOMInformationItemsController : BaseBusinessController
    {
        public MMChangeBOMInformationItemsController()
        {
            dal = new DALBaseProvider("MMChangeBOMInformationItems", typeof(MMChangeBOMInformationItemsInfo));
        }


        public MMChangeBOMInformationItemsInfo GetChangeBOMInformationByGEObjectHistoryID(int objectHistoryID)
        {
            DataSet ds = dal.GetDataSet("MMChangeBOMInformationItems_GetChangeBOMInformationByGEObjectHistoryID", objectHistoryID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MMChangeBOMInformationItemsInfo objProductsInfo = (MMChangeBOMInformationItemsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                ds.Dispose();
                return objProductsInfo;
            }
            ds.Dispose();
            return null;
        }
    }
    #endregion
}