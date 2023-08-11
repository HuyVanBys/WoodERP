﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region HREmployeeATMCardManages
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeeATMCardManagesController
    //Created Date:Thursday, February 20, 2020
    //-----------------------------------------------------------

    public class HREmployeeATMCardManagesController : BaseBusinessController
    {
        public HREmployeeATMCardManagesController()
        {
            dal = new DALBaseProvider("HREmployeeATMCardManages", typeof(HREmployeeATMCardManagesInfo));
        }

        public List<HREmployeeATMCardManagesInfo> GetEmployeeATMCardByEmployeeIDAndDate(int employeeID, DateTime date)
        {
            DataSet ds = dal.GetDataSet("HREmployeeATMCardManages_GetEmployeeATMCardByEmployeeIDAndDate", employeeID, date);
            List<HREmployeeATMCardManagesInfo> list = new List<HREmployeeATMCardManagesInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HREmployeeATMCardManagesInfo item = (HREmployeeATMCardManagesInfo)GetObjectFromDataRow(row);
                    list.Add(item);
                }
            }
            ds.Dispose();
            return list;
        }
    }
    #endregion
}