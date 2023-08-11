using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region HRTimeSheetAuditEntrys
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRTimeSheetAuditEntrysController
    //Created Date:Monday, November 27, 2017
    //-----------------------------------------------------------

    public class HRTimeSheetAuditEntrysController : BaseBusinessController
    {
        public HRTimeSheetAuditEntrysController()
        {
            dal = new DALBaseProvider("HRTimeSheetAuditEntrys", typeof(HRTimeSheetAuditEntrysInfo));
        }

        /// <summary>
        /// Get time sheet entrys by time sheet and employee time sheet
        /// </summary>
        /// <param name="timeSheetID">int timeSheetID</param>
        /// <param name="employeeTimeSheetID">int employeeTimeSheetID</param>
        /// <returns></returns>
        public DataSet GetTimeSheetAuditEntrysByTimeSheetAuditIDAndEmployeeTimeSheetAuditID(int timeSheetAuditID, int employeeTimeSheetAuditID)
        {
            return dal.GetDataSet("GetTimeSheetAuditEntrysByTimeSheetAuditIDAndEmployeeTimeSheetAuditID", timeSheetAuditID, employeeTimeSheetAuditID);
        }

        /// <summary>
        /// Get time sheet entrys by time sheet and employee time sheet
        /// </summary>
        /// <param name="timeSheetID">int timeSheetID</param>
        /// <param name="employeeTimeSheetID">int employeeTimeSheetID</param>
        /// <returns>The list of time sheet entry</returns>
        public List<HRTimeSheetAuditEntrysInfo> GetTimeSheetAuditEntryByTimeSheetAuditIDAndEmployeeTimeSheetAuditID(int timeSheetAuditID, int employeeTimeSheetAuditID)
        {
            List<HRTimeSheetAuditEntrysInfo> timeSheetAuditEntryList = new List<HRTimeSheetAuditEntrysInfo>();
            DataSet ds = dal.GetDataSet("HRTimeSheetAuditEntrys_GetTimeSheetAuditEntryByTimeSheetAuditIDAndEmployeeTimeSheetAuditID", timeSheetAuditID, employeeTimeSheetAuditID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRTimeSheetAuditEntrysInfo objTimeSheetAuditEntrysInfo = (HRTimeSheetAuditEntrysInfo)GetObjectFromDataRow(row);
                    timeSheetAuditEntryList.Add(objTimeSheetAuditEntrysInfo);
                }
            }
            ds.Dispose();
            return timeSheetAuditEntryList;
        }

        public List<HRTimeSheetAuditEntrysInfo> GetTotalTimeSheetEntryByTimeSheetAuditIDAndEmployeeTimeSheetAuditID(int timeSheetAuditID, int employeeTimeSheetAuditID)
        {
            List<HRTimeSheetAuditEntrysInfo> timeSheetAuditEntryList = new List<HRTimeSheetAuditEntrysInfo>();
            DataSet ds = dal.GetDataSet("HRTimeSheetAuditEntrys_GetTotalTimeSheetEntryByTimeSheetAuditIDAndEmployeeTimeSheetAuditID", timeSheetAuditID, employeeTimeSheetAuditID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRTimeSheetAuditEntrysInfo objTimeSheetAuditEntrysInfo = (HRTimeSheetAuditEntrysInfo)GetObjectFromDataRow(row);
                    timeSheetAuditEntryList.Add(objTimeSheetAuditEntrysInfo);
                }
            }
            ds.Dispose();
            return timeSheetAuditEntryList;
        }
        public double GetTotalNPNQty(int employeeID)
        {
            DataSet ds = dal.GetDataSet("HRTimeSheetAuditEntrys_GetTotalNPNQty", employeeID);
            double qty = 0;
            if (ds.Tables[0].Rows.Count > 0)
            {
                double.TryParse(ds.Tables[0].Rows[0].ItemArray[0].ToString(), out qty);
            }
            ds.Dispose();
            return qty;
        }

        public bool DeleteTimeSheetAuditEntryByTimeSheetAuditID(int timeSheetAuditID)
        {
            int i = 0;
            DataSet ds = dal.GetDataSet("HRTimeSheetAuditEntrys_DeleteTimeSheetAuditEntryByTimeSheetAuditID", timeSheetAuditID);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int.TryParse(ds.Tables[0].Rows[0][0].ToString(), out i);
            }
            if (i == 0)
            {
                return false;
            }
            return true;
        }
    }
    #endregion
}