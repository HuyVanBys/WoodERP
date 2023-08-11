﻿using BOSLib;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace BOSERP
{
    #region HREmployeePayrollFormulas
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeePayrollFormulasController
    //Created Date:Tuesday, June 14, 2016
    //-----------------------------------------------------------

    public class HREmployeePayrollFormulasController : BaseBusinessController
    {
        public HREmployeePayrollFormulasController()
        {
            dal = new DALBaseProvider("HREmployeePayrollFormulas", typeof(HREmployeePayrollFormulasInfo));
        }

        public List<HREmployeePayrollFormulasInfo> GetAllEmployeePayrollFormulas()
        {
            DataSet ds = dal.GetAllObject();
            List<HREmployeePayrollFormulasInfo> list = new List<HREmployeePayrollFormulasInfo>();
            if (ds.Tables.Count > 0)
            {
                HREmployeePayrollFormulasInfo objEmployeePayrollFormulasInfo;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    objEmployeePayrollFormulasInfo = (HREmployeePayrollFormulasInfo)GetObjectFromDataRow(row);
                    list.Add(objEmployeePayrollFormulasInfo);
                }
            }
            ds.Dispose();
            return list;
        }
        public List<HREmployeePayrollFormulasInfo> GetAllEmployeePayrollFormulaForSellStaff()
        {
            DataSet ds = GetAllObjects();
            return ((List<HREmployeePayrollFormulasInfo>)GetListFromDataSet(ds)).Where(p => p.HREmployeePayrollFormulaID > 0).ToList();
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<HREmployeePayrollFormulasInfo> employeePayrollFormulas = new List<HREmployeePayrollFormulasInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HREmployeePayrollFormulasInfo objEmployeePayrollFormulasInfo = (HREmployeePayrollFormulasInfo)GetObjectFromDataRow(row);
                    employeePayrollFormulas.Add(objEmployeePayrollFormulasInfo);
                }
            }
            ds.Dispose();
            return employeePayrollFormulas;
        }
    }
    #endregion
}