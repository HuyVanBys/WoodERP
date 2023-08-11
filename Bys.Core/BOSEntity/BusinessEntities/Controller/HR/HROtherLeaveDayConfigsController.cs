﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region HROtherLeaveDayConfigs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HROtherLeaveDayConfigsController
    //Created Date:Wednesday, May 8, 2019
    //-----------------------------------------------------------

    public class HROtherLeaveDayConfigsController : BaseBusinessController
    {
        public HROtherLeaveDayConfigsController()
        {
            dal = new DALBaseProvider("HROtherLeaveDayConfigs", typeof(HROtherLeaveDayConfigsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<HROtherLeaveDayConfigsInfo> lst = new List<HROtherLeaveDayConfigsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HROtherLeaveDayConfigsInfo obj = (HROtherLeaveDayConfigsInfo)GetObjectFromDataRow(row);
                    lst.Add(obj);
                }
            }
            return lst;
        }
    }
    #endregion
}