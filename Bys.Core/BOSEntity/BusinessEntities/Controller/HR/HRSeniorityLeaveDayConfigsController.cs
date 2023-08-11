﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region HRSeniorityLeaveDayConfigs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRSeniorityLeaveDayConfigsController
    //Created Date:Wednesday, May 8, 2019
    //-----------------------------------------------------------

    public class HRSeniorityLeaveDayConfigsController : BaseBusinessController
    {
        public HRSeniorityLeaveDayConfigsController()
        {
            dal = new DALBaseProvider("HRSeniorityLeaveDayConfigs", typeof(HRSeniorityLeaveDayConfigsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<HRSeniorityLeaveDayConfigsInfo> lst = new List<HRSeniorityLeaveDayConfigsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRSeniorityLeaveDayConfigsInfo obj = (HRSeniorityLeaveDayConfigsInfo)GetObjectFromDataRow(row);
                    lst.Add(obj);
                }
            }
            return lst;
        }
    }
    #endregion
}