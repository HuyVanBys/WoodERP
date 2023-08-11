﻿using BOSLib;
using System;
using System.Data;


namespace BOSERP
{
    #region ARCancelSaleForecasts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARCancelSaleForecastsController
    //Created Date:Tuesday, November 10, 2015
    //-----------------------------------------------------------

    public class ARCancelSaleForecastsController : BaseBusinessController
    {
        public ARCancelSaleForecastsController()
        {
            dal = new DALBaseProvider("ARCancelSaleForecasts", typeof(ARCancelSaleForecastsInfo));
        }

        public DataSet GetCancelSaleForecastsBySomeCriteria(string cancelSaleForecastNo,
                                                                    int saleForecastID,
                                                                    int customerID,
                                                                    int employeeID,
                                                                    int branchID,
                                                                    DateTime fromDate,
                                                                    DateTime toDate)
        {
            DataSet ds = dal.GetDataSet("ARCancelSaleForecasts_GetCancelSaleForecastsBySomeCriteria",
                                                                        cancelSaleForecastNo,
                                                                        saleForecastID,
                                                                        customerID,
                                                                        employeeID,
                                                                        branchID,
                                                                        fromDate,
                                                                        toDate);
            return ds;
        }


    }
    #endregion
}