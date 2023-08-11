﻿using BOSLib;
using System.Data;


namespace BOSERP
{
    #region HRMails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRMailsController
    //Created Date:Wednesday, April 27, 2011
    //-----------------------------------------------------------

    public class HRMailsController : BaseBusinessController
    {
        public HRMailsController()
        {
            dal = new DALBaseProvider("HRMails", typeof(HRMailsInfo));
        }

        /// <summary>
        /// Get mail list of HRMails
        /// </summary>
        /// <param name="mailType">mailType</param>
        /// <param name="employeeID">employeeID</param>
        /// <returns></returns>
        public DataSet GetMailListByMailTypeAndEmployeeID(string mailType, int employeeID)
        {
            DataSet ds = dal.GetDataSet("HRMails_GetMailListByMailTypeAndEmployeeID", mailType, employeeID);
            return ds;
        }


    }
    #endregion
}