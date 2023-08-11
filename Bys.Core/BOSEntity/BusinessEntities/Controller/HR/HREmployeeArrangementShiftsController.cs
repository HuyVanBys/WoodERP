﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region HREmployeeArrangementShifts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeeArrangementShiftsController
    //Created Date:Tuesday, December 18, 2018
    //-----------------------------------------------------------

    public class HREmployeeArrangementShiftsController : BaseBusinessController
    {
        public HREmployeeArrangementShiftsController()
        {
            dal = new DALBaseProvider("HREmployeeArrangementShifts", typeof(HREmployeeArrangementShiftsInfo));
        }

        public List<HREmployeeArrangementShiftsInfo> GetEmployeeArrangementShiftByArrangementShiftIDAndUserGroup(int timeSheetID, int userGroupID)
        {
            DataSet ds = dal.GetDataSet("HREmployeeArrangementShifts_GetEmployeeArrangementShiftByArrangementShiftIDAndUserGroup", timeSheetID, userGroupID);
            return (List<HREmployeeArrangementShiftsInfo>)GetListFromDataSet(ds);
        }

        public void DeleteByArrangementShiftID(int arrangementShiftID)
        {
            dal.ExecuteStoredProcedure("HREmployeeArrangementShifts_DeleteByArrangementShiftID", arrangementShiftID);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<HREmployeeArrangementShiftsInfo> employeeArrangementShifts = new List<HREmployeeArrangementShiftsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HREmployeeArrangementShiftsInfo objemployeeArrangementShiftsInfo = (HREmployeeArrangementShiftsInfo)GetObjectFromDataRow(row);
                    employeeArrangementShifts.Add(objemployeeArrangementShiftsInfo);
                }
            }
            return employeeArrangementShifts;
        }
    }
    #endregion
}