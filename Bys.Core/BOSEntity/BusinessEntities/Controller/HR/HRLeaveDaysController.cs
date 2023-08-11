﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace BOSERP
{
    #region HRLeaveDays
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRLeaveDaysController
    //Created Date:Tuesday, May 10, 2011
    //-----------------------------------------------------------

    public class HRLeaveDaysController : BaseBusinessController
    {
        public HRLeaveDaysController()
        {
            dal = new DALBaseProvider("HRLeaveDays", typeof(HRLeaveDaysInfo));
        }

        /// <summary>
        /// Get leave day list of employees searched by some criteria
        /// </summary>
        /// <param name="branchID">Branch id</param>
        /// <param name="departmentID">Department id</param>
        /// <param name="departmentRoomID">Department room id</param>
        /// <param name="employeeID">Employee id</param>
        /// <param name="date">Month of leave days</param>
        /// <returns>List of leave days</returns>
        public List<HRLeaveDaysInfo> GetLeaveDayList(int? branchID, int? departmentID, int? departmentRoomID, int? employeeID, DateTime? dateFrom, DateTime? dateTo, int? employeePayrollFormulaID)
        {
            DataSet ds = dal.GetDataSet("HRLeaveDays_GetLeaveDayList", branchID, departmentID, departmentRoomID, employeeID, dateFrom, dateTo, employeePayrollFormulaID);
            return (List<HRLeaveDaysInfo>)GetListFromDataSet(ds);
        }

        /// <summary>
        /// Get leave day list in a month
        /// </summary>
        /// <param name="date">Month of leave days</param>
        /// <returns>List of leave days</returns>
        public List<HRLeaveDaysInfo> GetLeaveDayList(DateTime? dateFrom, DateTime? dateTo)
        {
            return GetLeaveDayList(null, null, null, null, dateFrom, dateTo, null);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<HRLeaveDaysInfo> leaveDays = new List<HRLeaveDaysInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRLeaveDaysInfo leaveDay = (HRLeaveDaysInfo)GetObjectFromDataRow(row);
                    leaveDays.Add(leaveDay);
                }
            }
            ds.Dispose();
            return leaveDays;
        }

        /// <summary>
        /// Delete all leave days of an employee in a month
        /// </summary>
        /// <param name="employeeID">Employee id</param>
        /// <param name="date">Date contains the month</param>
        public void DeleteByEmployeeIDAndDate(int employeeID, DateTime date, string userName)
        {
            dal.ExecuteStoredProcedure("HRLeaveDays_DeleteByEmployeeIDAndDate", employeeID, date, userName);
        }

        public List<HRLeaveDaysInfo> GetListLeaveDayByHREmployeeID(int employeeID, DateTime? datefrom, DateTime? dateto)
        {
            DataSet ds = dal.GetDataSet("HRLeaveDays_GetLeaveDayListByHREmployeeID", employeeID, datefrom, dateto);
            //return (List<HRLeaveDaysInfo>)GetListFromDataSet(ds);
            List<HRLeaveDaysInfo> leaveDays = new List<HRLeaveDaysInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRLeaveDaysInfo leaveDay = (HRLeaveDaysInfo)GetObjectFromDataRow(row);
                    leaveDay.HRLeaveDayFromDate = leaveDay.HRLeaveDayDate;
                    leaveDay.HRLeaveDayToDate = leaveDay.HRLeaveDayDate;
                    if (leaveDay.HRTimeSheetParamName != "" || leaveDay.HRTimeSheetParamName == null)
                        leaveDay.HRLeaveDayType = leaveDay.HRTimeSheetParamName;
                    leaveDays.Add(leaveDay);
                }
            }
            ds.Dispose();
            return leaveDays;
        }
        public List<HRLeaveDaysInfo> GetSumLeaveDayByHREmployeeID(int? employeeID, DateTime? datefrom, DateTime? dateto)
        {
            DataSet ds = dal.GetDataSet("HRLeaveDays_GetSumLeaveDayByHREmployeeID", employeeID, datefrom, dateto);
            List<HRLeaveDaysInfo> leaveDays = new List<HRLeaveDaysInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRLeaveDaysInfo leaveDay = (HRLeaveDaysInfo)GetObjectFromDataRow(row);
                    leaveDays.Add(leaveDay);
                }
            }
            ds.Dispose();
            return leaveDays;
        }

        public double GetSumLeavedays(int employeeID, DateTime? datefrom, DateTime? dateto)
        {
            object obj = dal.GetSingleValue("HRLeaveDays_GetSumLeavedays", employeeID, datefrom, dateto);
            if (obj == null) return 0;
            return double.Parse(obj.ToString());
        }

        public double GetSumOffYear(int employeeID, DateTime? datefrom, DateTime? dateto)
        {
            object obj = dal.GetSingleValue("HRLeaveDays_GetSumOffYear", employeeID, datefrom, dateto);
            if (obj == null) return 0;
            return double.Parse(obj.ToString());
        }

        public List<HRLeaveDaysInfo> GetNKLByHREmployeeID(int? employeeID, DateTime? datefrom, DateTime? dateto)
        {
            DataSet ds = dal.GetDataSet("HRLeaveDays_GetNKLByHREmployeeID", employeeID, datefrom, dateto);
            List<HRLeaveDaysInfo> leaveDays = new List<HRLeaveDaysInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRLeaveDaysInfo leaveDay = (HRLeaveDaysInfo)GetObjectFromDataRow(row);
                    leaveDays.Add(leaveDay);
                }
            }
            ds.Dispose();
            return leaveDays;
        }

        public List<HRLeaveDaysInfo> GetLeaveDayOnYearByHREmployeeID(int? employeeID)
        {
            DataSet ds = dal.GetDataSet("HRLeaveDays_GetLeaveDayOnYearByHREmployeeID", employeeID);
            List<HRLeaveDaysInfo> leaveDays = new List<HRLeaveDaysInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRLeaveDaysInfo leaveDay = (HRLeaveDaysInfo)GetObjectFromDataRow(row);
                    leaveDays.Add(leaveDay);
                }
            }
            ds.Dispose();
            return leaveDays;
        }
        public List<HRLeaveDaysInfo> GetLeaveDayListByConditionFilter(int? branchID, int? departmentID, int? departmentRoomID, int? employeeID, int? employeePayrollFormulaID, DateTime? dateFrom, DateTime? dateTo)
        {
            DataSet ds = dal.GetDataSet("HRLeaveDays_GetLeaveDayListByConditionFilter", branchID, departmentID, departmentRoomID, employeeID, employeePayrollFormulaID, dateFrom, dateTo);
            return (List<HRLeaveDaysInfo>)GetListFromDataSet(ds);
        }

        public DataSet GetAllDataByEmployeeLeaveFromTo(int iEmployeeID, DateTime dtFrom, DateTime dtTo)
        {
            String str = String.Format(@"   SELECT (CASE WHEN HRTimeSheetParamType = 'PN1P2' THEN 0.5 WHEN  HRTimeSheetParamType = 'PN' THEN 1 ELSE 0 END) AS HRTimeSheetParamValue1,* 
                                            FROM dbo.HRLeaveDays 
                                             JOIN dbo.HRTimeSheetParams ON 
		                                     (HRTimeSheetParams.HRTimeSheetParamID = HRLeaveDays.FK_HRTimeSheetParamID AND HRLeaveDays.AAStatus = HRTimeSheetParams.AAStatus)
                                            WHERE HRTimeSheetParams.AAStatus='Alive' AND (HRTimeSheetParams.HRTimeSheetParamType='PN' OR HRTimeSheetParams.HRTimeSheetParamType='PN1P2')
                                            AND (FK_HREmployeeID={0} OR {0} = 0)
                                            AND 
                                            (
                                                (
                                                    CONVERT(VARCHAR(10),HRLeaveDayDate, 112) >= CONVERT(VARCHAR(10),'{1}', 112)
	                                                AND
	                                                CONVERT(VARCHAR(10),HRLeaveDayDate, 112) <= CONVERT(VARCHAR(10),'{2}', 112)
                                                )
                                                OR 
                                                (
	                                                CONVERT(VARCHAR(10),HRLeaveDayDate, 112) < CONVERT(VARCHAR(10),'{1}', 112)
	                                                AND 
	                                                CONVERT(VARCHAR(10),HRLeaveDayDate, 112) >= CONVERT(VARCHAR(10),'{1}', 112)
	                                                AND
	                                                CONVERT(VARCHAR(10),HRLeaveDayDate, 112) <= CONVERT(VARCHAR(10),'{2}', 112)
                                                )
                                            )
                                        ", iEmployeeID, dtFrom.ToString("yyyyMMdd"), dtTo.ToString("yyyyMMdd"));
            return dal.GetDataSet(str);
        }

        public HRLeaveDaysInfo GetmaxYearCal()
        {
            String strQuery = String.Format(@"SELECT TOP 1 * FROM dbo.HRLeaveDays
						                        WHERE HRLeaveDayDate=(SELECT MAX(HRLeaveDayDate) FROM dbo.HRLeaveDays WHERE AAStatus='Alive') AND AAStatus='Alive'");
            DataSet ds = dal.GetDataSet(strQuery);
            List<HRLeaveDaysInfo> lstLeaveDays = (List<HRLeaveDaysInfo>)GetListFromDataSet(ds);
            if (lstLeaveDays != null)
                return lstLeaveDays.FirstOrDefault();
            return null;

        }

        public decimal GetSumPNLeavedays(int employeeID, DateTime? datefrom, DateTime? dateto)
        {
            object obj = dal.GetSingleValue("HRLeaveDays_GetSumPNLeavedays", employeeID, datefrom, dateto);
            if (obj == null) return 0;
            return decimal.Parse(obj.ToString());
        }

        public void CheckAndUpdateByEmployeeIDAndDate(int employeeID, int timeSheetParamID, DateTime date)
        {
            dal.ExecuteStoredProcedure("HRLeaveDays_CheckAndUpdateByEmployeeIDAndDate", employeeID, timeSheetParamID, date);
        }

        public decimal GetLeaveDayTotalQtyRemain(DateTime? dateTo, int employeeID)
        {
            object obj = dal.GetSingleValue("HRLeaveDays_GetLeaveDayTotalQtyRemain", dateTo, employeeID);
            if (obj == null) return 0;
            return decimal.Parse(obj.ToString());
        }
    }
    #endregion
}