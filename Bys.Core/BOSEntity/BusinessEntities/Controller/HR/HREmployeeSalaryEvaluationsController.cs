﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region HREmployeeSalaryEvaluations
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeeSalaryEvaluationsController
    //Created Date:Friday, December 13, 2019
    //-----------------------------------------------------------

    public class HREmployeeSalaryEvaluationsController : BaseBusinessController
    {
        public HREmployeeSalaryEvaluationsController()
        {
            dal = new DALBaseProvider("HREmployeeSalaryEvaluations", typeof(HREmployeeSalaryEvaluationsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<HREmployeeSalaryEvaluationsInfo> list = new List<HREmployeeSalaryEvaluationsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HREmployeeSalaryEvaluationsInfo obj = (HREmployeeSalaryEvaluationsInfo)GetObjectFromDataRow(row);
                    list.Add(obj);
                }
            }
            ds.Dispose();
            return list;
        }

        public List<HREmployeeSalaryEvaluationsInfo> GetListBySalaryEvaluationID(int salaryEvaluationID)
        {
            return (List<HREmployeeSalaryEvaluationsInfo>)GetListFromDataSet(dal.GetDataSet("HREmployeeSalaryEvaluations_GetListBySalaryEvaluationID", salaryEvaluationID));
        }
    }
    #endregion
}