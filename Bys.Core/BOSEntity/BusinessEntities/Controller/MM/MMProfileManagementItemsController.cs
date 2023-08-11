﻿using BOSLib;
using System.Collections.Generic;
using System.Data;

namespace BOSERP
{
    #region MMProfileManagementItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProfileManagementItemsController
    //Created Date:Thursday, November 05, 2015
    //-----------------------------------------------------------

    public class MMProfileManagementItemsController : BaseBusinessController
    {
        public MMProfileManagementItemsController()
        {
            dal = new DALBaseProvider("MMProfileManagementItems", typeof(MMProfileManagementItemsInfo));
        }
        public List<MMProfileManagementItemsInfo> GetProfileByNormID(int normID)
        {
            DataSet ds = dal.GetDataSet("MMProfileManagementItems_GetProfileByNormID", normID);
            List<MMProfileManagementItemsInfo> list = new List<MMProfileManagementItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMProfileManagementItemsInfo item = (MMProfileManagementItemsInfo)GetObjectFromDataRow(row);
                    list.Add(item);
                }
            }

            ds.Dispose();
            return list;
        }
    }
    #endregion
}