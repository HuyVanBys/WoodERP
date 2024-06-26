using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region HREmployeeTranfers
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeeTranfersController
    //Created Date:Thursday, October 10, 2013
    //-----------------------------------------------------------

    public class HREmployeeTranfersController : BaseBusinessController
    {
        public HREmployeeTranfersController()
        {
            dal = new DALBaseProvider("HREmployeeTranfers", typeof(HREmployeeTranfersInfo));
        }

        public HREmployeeTranfersInfo GetOldEmployeeTranferByTranferID(int tranferID, int employeeID)
        {
            return (HREmployeeTranfersInfo)dal.GetDataObject("HREmployeeTranfers_GetOldEmployeeTranferByTranferID", tranferID, employeeID);
        }

        public HREmployeeTranfersInfo GetEmployeeTranfersByEmployeeIDAndDateFrom(int employeeID, DateTime dateFrom)
        {
            return (HREmployeeTranfersInfo)dal.GetDataObject("HREmployeeTranfers_GetEmployeeTranfersByEmployeeIDAndDateFrom", employeeID, dateFrom);
        }

        public HREmployeeTranfersInfo GetEmployeeTranfersByEmployeeIDAndDate(int? employeeID, DateTime dateFrom, DateTime dateTo)
        {
            return (HREmployeeTranfersInfo)dal.GetDataObject("HREmployeeTranfers_GetEmployeeTranfersByEmployeeIDAndDate", employeeID, dateFrom, dateTo);
        }
        public List<HREmployeeTranfersInfo> GetEmployeeTranfersByEmployeeIDAndDate(DateTime dateFrom, DateTime dateTo)
        {
            DataSet ds = dal.GetDataSet("HREmployeeTranfers_GetEmployeeTranfersByEmployeeIDAndDate", null, dateFrom, dateTo);
            return (List<HREmployeeTranfersInfo>)GetListFromDataSet(ds);
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<HREmployeeTranfersInfo> entries = new List<HREmployeeTranfersInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HREmployeeTranfersInfo entry = (HREmployeeTranfersInfo)GetObjectFromDataRow(row);
                    entries.Add(entry);
                }
            }
            ds.Dispose();
            return entries;
        }
    }
    #endregion
}