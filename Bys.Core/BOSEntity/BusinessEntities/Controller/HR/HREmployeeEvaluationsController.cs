﻿using BOSLib;
using System;
using System.Data;


namespace BOSERP
{
    #region HREmployeeEvaluations
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeeEvaluationsController
    //Created Date:Thursday, May 19, 2011
    //-----------------------------------------------------------

    public class HREmployeeEvaluationsController : BaseBusinessController
    {
        public HREmployeeEvaluationsController()
        {
            dal = new DALBaseProvider("HREmployeeEvaluations", typeof(HREmployeeEvaluationsInfo));
        }

        /// <summary>
        /// Get employee evaluation by ID of evaluation and their type
        /// </summary>
        /// <param name="evaluationID">ID of evaluation</param>
        /// <param name="employeeEvaluationType">Type of employee evaluation </param>
        /// <returns>DataSet of employee evaluation</returns>
        public DataSet GetEmployeeEvaluationByEvaluationIDAndType(int evaluationID, string employeeEvaluationType)
        {
            return dal.GetDataSet("HREmployeeEvaluations_GetEmployeeEvaluationByEvaluationIDAndType", evaluationID, employeeEvaluationType);
        }

        /// <summary>
        /// Get employee evaluation by ID of evaluation and their type
        /// </summary>
        /// <param name="evaluationID">ID of evaluation</param>
        /// <param name="employeeEvaluationType">Type of employee evaluation </param>
        /// <returns>DataSet of employee evaluation</returns>
        public DataSet GetEmployeeEvaluationByEvaluationIDAndEvaluationType(int evaluationID, string employeeEvaluationType)
        {
            return dal.GetDataSet("HREmployeeEvaluations_GetEmployeeEvaluationByEvaluationIDAndEvaluationType", evaluationID, employeeEvaluationType);
        }

        /// <summary>
        /// Get employee evaluation by ID of employee and from date to date
        /// </summary>
        /// <param name="employeeID">ID of employee</param>
        /// <param name="fromDate">Start date </param>
        /// <param name="toDate">End date</param>
        /// <returns></returns>
        public DataSet GetEmployeeEvaluationByEmployeeIDAndFromDateToDate(int employeeID, DateTime fromDate, DateTime toDate)
        {
            return dal.GetDataSet("HREmployeeEvaluations_GetEmployeeEvaluationByEmployeeIDAndFromDateToDate", employeeID, fromDate, toDate);
        }

        /// <summary>
        /// Get employee evaluation by evaluation id and employee id
        /// </summary>
        /// <param name="evaluationID">ID of evaluation</param>
        /// <param name="employeeID">ID of employee</param>
        /// <returns>employee evaluation</returns>
        public HREmployeeEvaluationsInfo GetEmployeeEvaluationByEvaluationIDAndEmployeeID(int evaluationID, int employeeID)
        {
            DataSet ds = dal.GetDataSet("HREmployeeEvaluations_GetEmployeeEvaluationByEvaluationIDAndEmployeeID", evaluationID, employeeID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                HREmployeeEvaluationsController objEmployeeEvaluationsController = new HREmployeeEvaluationsController();
                HREmployeeEvaluationsInfo objEmployeeEvaluationsInfo = new HREmployeeEvaluationsInfo();
                objEmployeeEvaluationsInfo = (HREmployeeEvaluationsInfo)objEmployeeEvaluationsController.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                return objEmployeeEvaluationsInfo;
            }
            return null;
        }
    }
    #endregion
}