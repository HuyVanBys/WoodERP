﻿using BOSLib;
using System.Data;


namespace BOSERP
{
    #region HREmployeeGroups
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeeGroupsController
    //Created Date:20 Tháng Sáu 2018
    //-----------------------------------------------------------

    public class HREmployeeGroupsController : BaseBusinessController
    {
        public HREmployeeGroupsController()
        {
            dal = new DALBaseProvider("HREmployeeGroups", typeof(HREmployeeGroupsInfo));
        }

        public DataSet GetHREmployeeByHRGroupID(int hrGroupID)
        {
            DataSet ds = dal.GetDataSet("HREmployeeGroups_GetHREmployeeByHRGroupID", hrGroupID);
            return ds;
        }

        public HREmployeeGroupsInfo GetEmployeeByHRGroupAndHREmployeeID(int GroupID, int EmployeeID)
        {
            DataSet ds = dal.GetDataSet("HREmployeeGroups_GetEmployeeByHRGroupAndHREmployeeID", GroupID, EmployeeID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                HREmployeeGroupsInfo objHREmployeeGroupsInfo = (HREmployeeGroupsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                return objHREmployeeGroupsInfo;
            }
            return null;
        }
    }

    #endregion
}