﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace BOSERP
{
    #region HRTimesheetConfigs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRTimesheetConfigsController
    //Created Date:Tuesday, June 14, 2016
    //-----------------------------------------------------------

    public class HRTimesheetConfigsController : BaseBusinessController
    {
        public HRTimesheetConfigsController()
        {
            dal = new DALBaseProvider("HRTimesheetConfigs", typeof(HRTimesheetConfigsInfo));
        }
        public List<HRTimesheetConfigsInfo> GetTimesheetConfigList()
        {
            DataSet ds = dal.GetDataSet("HRTimesheetConfigs_GetTimesheetConfigList");
            List<HRTimesheetConfigsInfo> result = (List<HRTimesheetConfigsInfo>)GetListFromDataSet(ds);
            ds.Dispose();
            return result;
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<HRTimesheetConfigsInfo> list = new List<HRTimesheetConfigsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRTimesheetConfigsInfo objTimesheetConfigsInfo = (HRTimesheetConfigsInfo)GetObjectFromDataRow(row);
                    list.Add(objTimesheetConfigsInfo);
                }
            }
            ds.Dispose();
            return list;
        }

        public int GetDaysPerMonthByEmployeeFormullaID(int employeePayrollFormulaID, int month)
        {
            try
            {
                DataSet ds = dal.GetAllObject();
                List<HRTimesheetConfigsInfo> list = (List<HRTimesheetConfigsInfo>)GetListFromDataSet(ds);
                HRTimesheetConfigsInfo objTimesheetConfigsInfo = list.Where(p => p.FK_HREmployeePayrollFormulaID == employeePayrollFormulaID).FirstOrDefault();
                ds.Dispose();
                string[] str = new string[] {"HRTimesheetConfigJan", "HRTimesheetConfigFeb", "HRTimesheetConfigMar",
            "HRTimesheetConfigApr", "HRTimesheetConfigMay", "HRTimesheetConfigJun", "HRTimesheetConfigJul", "HRTimesheetConfigAug",
            "HRTimesheetConfigSep", "HRTimesheetConfigOct", "HRTimesheetConfigNov", "HRTimesheetConfigDec" };
                if (objTimesheetConfigsInfo != null)
                {
                    BusinessObject obj = (BusinessObject)objTimesheetConfigsInfo;
                    BOSDbUtil util = new BOSDbUtil();
                    object o = util.GetPropertyValue(objTimesheetConfigsInfo, str[month - 1]);
                    return int.Parse(o.ToString());
                }

                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
    #endregion
}