﻿using BOSLib;
using System;
using System.Data;


namespace BOSERP
{
    #region HREmployeeWorkingShifts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeeWorkingShiftsController
    //Created Date:Monday, May 09, 2011
    //-----------------------------------------------------------

    public class HREmployeeWorkingShiftsController : BaseBusinessController
    {
        public HREmployeeWorkingShiftsController()
        {
            dal = new DALBaseProvider("HREmployeeWorkingShifts", typeof(HREmployeeWorkingShiftsInfo));
        }

        /// <summary>
        /// Get employee working shift  by employee and date
        /// </summary>
        /// <param name="employeeID"></param>
        /// <param name="workingShiftDate"></param>
        /// <returns></returns>
        public DataSet GetEmployeeWorkingByEmployeeIDAndDate(int employeeID, DateTime workingShiftDate)
        {
            return dal.GetDataSet("HREmployeeWorkingShifts_GetEmployeeWorkingByEmployeeIDAndDate", employeeID, workingShiftDate);
        }


        /// <summary>
        /// Get working shift of employee from date to date
        /// </summary>
        /// <param name="employeeID">ID of employee</param>
        /// <param name="dateFrom">From date</param>
        /// <param name="dateTo">To date</param>
        /// <returns></returns>
        public DataSet GetWorkingShiftListByDateAndEmployeeID(int employeeID, DateTime @dateFrom, DateTime @dateTo)
        {
            return dal.GetDataSet("HREmployeeWorkingShifts_GetWorkingShiftListByDateAndEmployeeID", dateFrom, dateTo, employeeID);
        }
    }
    #endregion
}