﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region HRTimeKeeperHistoryDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRTimeKeeperHistoryDetailsController
    //Created Date:Monday, July 9, 2018
    //-----------------------------------------------------------

    public class HRTimeKeeperHistoryDetailsController : BaseBusinessController
    {
        public HRTimeKeeperHistoryDetailsController()
        {
            dal = new DALBaseProvider("HRTimeKeeperHistoryDetails", typeof(HRTimeKeeperHistoryDetailsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<HRTimeKeeperHistoryDetailsInfo> TimeKeeperHistoryDetailList = new List<HRTimeKeeperHistoryDetailsInfo>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRTimeKeeperHistoryDetailsInfo objTimeKeeperHistoryDetailsInfo = (HRTimeKeeperHistoryDetailsInfo)GetObjectFromDataRow(row);
                    TimeKeeperHistoryDetailList.Add(objTimeKeeperHistoryDetailsInfo);
                }
            }
            ds.Dispose();
            return TimeKeeperHistoryDetailList;
        }
        public List<HRTimeKeeperHistoryDetailsInfo> GetDataForTimeKeeperHistoryDetailsBySomeCriteria(
                                    int? FK_HRDepartmentID,
                                    int? FK_HRDepartmentRoomID,
                                    int? HREmployeeID,
                                    int? employeePayrollFormulaID,
                                    DateTime? searchHistoryFromDateView,
                                    DateTime? searchHistoryToDateView
                                    )
        {
            DataSet ds = dal.GetDataSet("HRTimeKeeperHistoryDetails_GetDataForTimeKeeperHistoryDetailsBySomeCriteria",
                                        searchHistoryFromDateView,
                                        searchHistoryToDateView,
                                        FK_HRDepartmentID,
                                        FK_HRDepartmentRoomID,
                                        HREmployeeID,
                                        employeePayrollFormulaID);
            return (List<HRTimeKeeperHistoryDetailsInfo>)GetListFromDataSet(ds);
        }
        public List<HRTimeKeeperHistoryDetailsInfo> GetTimeKeeperHistoryDetails(int employeePayrollFormulaID)
        {
            return (List<HRTimeKeeperHistoryDetailsInfo>)GetListFromDataSet(dal.GetDataSet("HRTimeKeeperHistorys_GetTimeKeeperHistoryDetails", employeePayrollFormulaID));
        }
    }
    #endregion
}