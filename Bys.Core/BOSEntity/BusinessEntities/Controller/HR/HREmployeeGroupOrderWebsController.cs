﻿using BOSLib;
using System.Data;


namespace BOSERP
{
    #region HREmployeeGroupOrderWebs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeeGroupOrderWebsController
    //Created Date:Tuesday, October 9, 2018
    //-----------------------------------------------------------

    public class HREmployeeGroupOrderWebsController : BaseBusinessController
    {
        public HREmployeeGroupOrderWebsController()
        {
            dal = new DALBaseProvider("HREmployeeGroupOrderWebs", typeof(HREmployeeGroupOrderWebsInfo));
        }

        public DataSet GetHREmployeeByADGroupOrderWebID(int hrGroupID)
        {
            DataSet ds = dal.GetDataSet("HREmployeeGroupOrderWebs_GetHREmployeeByADGroupOrderWebID", hrGroupID);
            return ds;
        }

        public HREmployeeGroupOrderWebsInfo GetEmployeeByADGroupOrderAndHREmployeeID(int GroupID, int EmployeeID)
        {
            DataSet ds = dal.GetDataSet("HREmployeeGroupOrderWebs_GetEmployeeByADGroupOrderAndHREmployeeID", GroupID, EmployeeID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                HREmployeeGroupOrderWebsInfo objEmployeeGroupOrderWebsInfo = (HREmployeeGroupOrderWebsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                return objEmployeeGroupOrderWebsInfo;
            }
            return null;
        }
    }
    #endregion
}