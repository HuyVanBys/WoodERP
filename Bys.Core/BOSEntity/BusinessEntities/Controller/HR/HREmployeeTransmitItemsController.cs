﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region HREmployeeTransmitItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeeTransmitItemsController
    //Created Date:Tuesday, September 11, 2018
    //-----------------------------------------------------------

    public class HREmployeeTransmitItemsController : BaseBusinessController
    {
        public HREmployeeTransmitItemsController()
        {
            dal = new DALBaseProvider("HREmployeeTransmitItems", typeof(HREmployeeTransmitItemsInfo));
        }
        public DataSet GetAllDataByEmployeeTransmitID(int employeeTransmitID)
        {
            return dal.GetDataSet("HREmployeeTransmitItems_GetAllDataByEmployeeTransmitID", employeeTransmitID);
        }
        public List<HREmployeeTransmitItemsInfo> GetEmployeeTransmitByDate(DateTime fromDate, DateTime toDate)
        {
            List<HREmployeeTransmitItemsInfo> EmployeeTransmitItemList = new List<HREmployeeTransmitItemsInfo>();
            DataSet ds = dal.GetDataSet("HREmployeeTransmitItems_GetEmployeeTransmitByDate", fromDate, toDate);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HREmployeeTransmitItemsInfo objEmployeeTransmitItemsInfo = (HREmployeeTransmitItemsInfo)GetObjectFromDataRow(row);
                    EmployeeTransmitItemList.Add(objEmployeeTransmitItemsInfo);
                }
            }
            ds.Dispose();
            return EmployeeTransmitItemList;
        }
    }
    #endregion
}