﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region HRTimeSheetEntrys
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRTimeSheetEntrysController
    //Created Date:Tuesday, March 29, 2011 
    //-----------------------------------------------------------

    public class HRTimeSheetEntrysController : BaseBusinessController
    {
        public HRTimeSheetEntrysController()
        {
            dal = new DALBaseProvider("HRTimeSheetEntrys", typeof(HRTimeSheetEntrysInfo));
        }

        /// <summary>
        /// Get time sheet entrys by time sheet and employee time sheet
        /// </summary>
        /// <param name="timeSheetID">int timeSheetID</param>
        /// <param name="employeeTimeSheetID">int employeeTimeSheetID</param>
        /// <returns></returns>
        public DataSet GetTimeSheetEntrysByTimeSheetIDAndEmployeeTimeSheetID(int timeSheetID, int employeeTimeSheetID)
        {
            return dal.GetDataSet("HRTimeSheetEntrys_GetTimeSheetEntrysByTimeSheetIDAndEmployeeTimeSheetID", timeSheetID, employeeTimeSheetID);
        }

        /// <summary>
        /// Get time sheet entrys by time sheet and employee time sheet
        /// </summary>
        /// <param name="timeSheetID">int timeSheetID</param>
        /// <param name="employeeTimeSheetID">int employeeTimeSheetID</param>
        /// <returns>The list of time sheet entry</returns>
        public List<HRTimeSheetEntrysInfo> GetTimeSheetEntryByTimeSheetIDAndEmployeeTimeSheetID(int timeSheetID, int employeeTimeSheetID)
        {
            List<HRTimeSheetEntrysInfo> timeSheetEntryList = new List<HRTimeSheetEntrysInfo>();
            DataSet ds = dal.GetDataSet("HRTimeSheetEntrys_GetTimeSheetEntrysByTimeSheetIDAndEmployeeTimeSheetID", timeSheetID, employeeTimeSheetID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRTimeSheetEntrysInfo objTimeSheetEntrysInfo = (HRTimeSheetEntrysInfo)GetObjectFromDataRow(row);
                    timeSheetEntryList.Add(objTimeSheetEntrysInfo);
                }
            }
            ds.Dispose();
            return timeSheetEntryList;
        }

        public List<HRTimeSheetEntrysInfo> GetTotalTimeSheetEntryByTimeSheetIDAndEmployeeTimeSheetID(int? timeSheetID, int employeeTimeSheetID)
        {
            List<HRTimeSheetEntrysInfo> timeSheetEntryList = new List<HRTimeSheetEntrysInfo>();
            DataSet ds = dal.GetDataSet("HRTimeSheetEntrys_GetTotalTimeSheetEntryByTimeSheetIDAndEmployeeTimeSheetID", timeSheetID, employeeTimeSheetID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRTimeSheetEntrysInfo objTimeSheetEntrysInfo = (HRTimeSheetEntrysInfo)GetObjectFromDataRow(row);
                    timeSheetEntryList.Add(objTimeSheetEntrysInfo);
                }
            }
            ds.Dispose();
            return timeSheetEntryList;
        }
        public List<HRTimeSheetEntrysInfo> GetTotalTimeSheetEntryByTimeSheetID(int timeSheetID)
        {
            List<HRTimeSheetEntrysInfo> timeSheetEntryList = new List<HRTimeSheetEntrysInfo>();
            DataSet ds = dal.GetDataSet("HRTimeSheetEntrys_GetTotalTimeSheetEntryByTimeSheetID", timeSheetID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRTimeSheetEntrysInfo objTimeSheetEntrysInfo = (HRTimeSheetEntrysInfo)GetObjectFromDataRow(row);
                    timeSheetEntryList.Add(objTimeSheetEntrysInfo);
                }
            }
            ds.Dispose();
            return timeSheetEntryList;
        }
        public DataTable GetTimeSheetEntryListByTimeSheetID(int timeSheetID)
        {
            DataTable dt = new DataTable();
            DataSet ds = dal.GetDataSet("HRTimeSheetEntrys_GetTimeSheetEntryListByTimeSheetID", timeSheetID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
            }
            ds.Dispose();
            return dt;
        }

        public List<HRTimeSheetEntrysInfo> GetTimeSheetEntryListByTimeSheetIDReport(int timeSheetID)
        {
            List<HRTimeSheetEntrysInfo> timeSheetEntryList = new List<HRTimeSheetEntrysInfo>();
            DataSet ds = dal.GetDataSet("Report_GetTimeSheetEntryListByTimeSheetID", timeSheetID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRTimeSheetEntrysInfo objTimeSheetEntrysInfo = (HRTimeSheetEntrysInfo)GetObjectFromDataRow(row);
                    timeSheetEntryList.Add(objTimeSheetEntrysInfo);
                }
            }
            ds.Dispose();
            return timeSheetEntryList;
        }

        public decimal GetTotalNPNQty(int employeeID)
        {
            DataSet ds = dal.GetDataSet("HRTimeSheetEntrys_GetTotalNPNQty", employeeID);
            decimal qty = 0;
            if (ds.Tables[0].Rows.Count > 0)
            {
                decimal.TryParse(ds.Tables[0].Rows[0].ItemArray[0].ToString(), out qty);
            }
            ds.Dispose();
            return qty;
        }

    }
    #endregion
}