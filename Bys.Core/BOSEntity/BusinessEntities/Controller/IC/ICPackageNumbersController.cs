﻿using BOSLib;
using System;
using System.Data;


namespace BOSERP
{
    #region ICPackageNumbers
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICPackageNumbersController
    //Created Date:Wednesday, September 21, 2011
    //-----------------------------------------------------------

    public class ICPackageNumbersController : BaseBusinessController
    {
        public ICPackageNumbersController()
        {
            dal = new DALBaseProvider("ICPackageNumbers", typeof(ICPackageNumbersInfo));
        }

        /// <summary>
        /// Get package number by date
        /// </summary>
        /// <param name="date">Package number date</param>
        /// <returns>Package number info</returns>
        public ICPackageNumbersInfo GetPackageNumberByPackageNumberDate(DateTime date)
        {
            DataSet ds = dal.GetDataSet("ICPackageNumbers_GetPackageNumberByPackageNumberDate", date);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ICPackageNumbersInfo objPackageNumbersInfo = (ICPackageNumbersInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                ds.Dispose();
                return objPackageNumbersInfo;
            }
            ds.Dispose();
            return null;
        }
    }
    #endregion
}