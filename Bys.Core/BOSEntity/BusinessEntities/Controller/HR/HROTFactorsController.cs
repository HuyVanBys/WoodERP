﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region HROTFactors
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HROTFactorsController
    //Created Date:Monday, May 09, 2011
    //-----------------------------------------------------------

    public class HROTFactorsController : BaseBusinessController
    {
        public HROTFactorsController()
        {
            dal = new DALBaseProvider("HROTFactors", typeof(HROTFactorsInfo));
        }

        /// <summary>
        /// Get overtime factors by type
        /// </summary>
        /// <param name="factorType">Overtime type, includes holiday days or end of week</param>
        /// <returns>List of overtime factors</returns>
        public List<HROTFactorsInfo> GetOTFactorsByType(string overtimeType)
        {
            DataSet ds = dal.GetDataSet("HROTFactors_GetOTFactorByType", overtimeType);
            return (List<HROTFactorsInfo>)GetListFromDataSet(ds);
        }

        /// <summary>
        /// Get all overtime factors
        /// </summary>
        /// <returns></returns>
        public List<HROTFactorsInfo> GetAllOTFactors()
        {
            DataSet ds = GetAllObjects();
            return (List<HROTFactorsInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<HROTFactorsInfo> factors = new List<HROTFactorsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HROTFactorsInfo factor = (HROTFactorsInfo)GetObjectFromDataRow(row);
                    factors.Add(factor);
                }
            }
            ds.Dispose();
            return factors;
        }

        public List<HROTFactorsInfo> GetAllEmployeeFactors()
        {
            DataSet ds = dal.GetDataSet("HROTFactors_GetAllEmployeeFactors");
            return (List<HROTFactorsInfo>)GetListFromDataSet(ds);
        }

        public List<HROTFactorsInfo> GetOTFactorByEmployeePayrollFormulaID(int? employeePayrollFormulaID)
        {
            DataSet ds = dal.GetDataSet("HROTFactors_GetOTFactorByEmployeePayrollFormulaID", employeePayrollFormulaID);
            return (List<HROTFactorsInfo>)GetListFromDataSet(ds);
        }

        public List<HROTFactorsInfo> GetOTFactorByEmployeeID(int? employeeID)
        {
            DataSet ds = dal.GetDataSet("HROTFactors_GetOTFactorByEmployeeID", employeeID);
            return (List<HROTFactorsInfo>)GetListFromDataSet(ds);
        }

        public List<HROTFactorsInfo> GetAllDistinctFactors()
        {
            DataSet ds = dal.GetDataSet("HROTFactors_GetAllFactors");
            return (List<HROTFactorsInfo>)GetListFromDataSet(ds);
        }
        /// <summary>
        /// Get overtime factors by type
        /// </summary>
        /// <param name="factorType">Overtime type, includes holiday days or end of week</param>
        /// <returns>List of overtime factors</returns>
        public List<HROTFactorsInfo> GetHolidayAndEndOfWeekOTFactors()
        {
            DataSet ds = dal.GetDataSet("HROTFactors_GetHolidayAndEndOfWeekOTFactors");
            return (List<HROTFactorsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}