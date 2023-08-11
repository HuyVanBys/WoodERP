﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMMaterialDepartments
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMMaterialDepartmentsController
    //Created Date:Wednesday, July 17, 2019
    //-----------------------------------------------------------

    public class MMMaterialDepartmentsController : BaseBusinessController
    {
        public MMMaterialDepartmentsController()
        {
            dal = new DALBaseProvider("MMMaterialDepartments", typeof(MMMaterialDepartmentsInfo));
        }
        public List<MMMaterialDepartmentsInfo> GetListFromDataSet(DataSet ds)
        {
            List<MMMaterialDepartmentsInfo> FormulaConfigs = new List<MMMaterialDepartmentsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMMaterialDepartmentsInfo objFormulaConfigsInfo = (MMMaterialDepartmentsInfo)GetObjectFromDataRow(row);
                    FormulaConfigs.Add(objFormulaConfigsInfo);
                }
            }

            ds.Dispose();
            return FormulaConfigs;
        }
        public List<MMMaterialDepartmentsInfo> GetAllMaterialDepartment()
        {
            DataSet ds = this.GetAllObjects();
            if (ds != null && ds.Tables.Count > 0)
                return (List<MMMaterialDepartmentsInfo>)GetListFromDataSet(ds);
            else
                return null;
        }
    }
    #endregion
}