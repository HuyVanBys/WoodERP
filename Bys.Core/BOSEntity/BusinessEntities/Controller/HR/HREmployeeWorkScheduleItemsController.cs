﻿using BOSLib;
using System.Data;


namespace BOSERP
{
    #region HREmployeeWorkScheduleItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HREmployeeWorkScheduleItemsController
    //Created Date:Tuesday, June 14, 2016
    //-----------------------------------------------------------

    public class HREmployeeWorkScheduleItemsController : BaseBusinessController
    {
        public HREmployeeWorkScheduleItemsController()
        {
            dal = new DALBaseProvider("HREmployeeWorkScheduleItems", typeof(HREmployeeWorkScheduleItemsInfo));
        }
        public DataSet GetAllDataByOverTimeID(int overTimeID)
        {
            return dal.GetDataSet("HREmployeeWorkScheduleItems_GetAllDataByOverTimeID", overTimeID);
        }
    }
    #endregion
}