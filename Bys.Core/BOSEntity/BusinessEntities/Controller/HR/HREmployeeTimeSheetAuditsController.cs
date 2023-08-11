using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region HREmployeeTimeSheetAudits
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeeTimeSheetAuditsController
    //Created Date:Monday, November 27, 2017
    //-----------------------------------------------------------

    public class HREmployeeTimeSheetAuditsController : BaseBusinessController
    {
        public HREmployeeTimeSheetAuditsController()
        {
            dal = new DALBaseProvider("HREmployeeTimeSheetAudits", typeof(HREmployeeTimeSheetAuditsInfo));
        }

        public List<HREmployeeTimeSheetAuditsInfo> GetEmployeeTimeSheetByTimeSheetAuditIDAndUserGroup(int timeSheetAuditID, int userGroupID)
        {
            HREmployeeTimeSheetAuditsController objEmployeeTimeSheetAuditsController = new HREmployeeTimeSheetAuditsController();
            DataSet ds = dal.GetDataSet("HREmployeeTimeSheetAudits_GetEmployeeTimeSheetByTimeSheetAuditIDAndUserGroup", timeSheetAuditID, userGroupID);
            List<HREmployeeTimeSheetAuditsInfo> objEmployeeTimeSheetAuditsInfo = (List<HREmployeeTimeSheetAuditsInfo>)objEmployeeTimeSheetAuditsController.GetListFromDataSet(ds);
            ds.Dispose();
            return objEmployeeTimeSheetAuditsInfo;
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<HREmployeeTimeSheetAuditsInfo> employeeTimeSheetAuditsInfo = new List<HREmployeeTimeSheetAuditsInfo>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HREmployeeTimeSheetAuditsInfo objEmployeeTimeSheetAuditsInfo = (HREmployeeTimeSheetAuditsInfo)GetObjectFromDataRow(row);
                    employeeTimeSheetAuditsInfo.Add(objEmployeeTimeSheetAuditsInfo);
                }
            }
            ds.Dispose();
            return employeeTimeSheetAuditsInfo;
        }

        public List<HREmployeeTimeSheetAuditsInfo> GetEmployeeTimeSheetAuditByTimeSheetAuditIDAndUserGroup(int timeSheetAuditID, int userGroupID)
        {
            DataSet ds = dal.GetDataSet("HREmployeeTimeSheetAudits_GetEmployeeTimeSheetAuditByTimeSheetAuditIDAndUserGroup", timeSheetAuditID, userGroupID);
            return (List<HREmployeeTimeSheetAuditsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}