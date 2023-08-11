﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region HRAdvanceRequests
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRAdvanceRequestsController
    //Created Date:Monday, June 13, 2016
    //-----------------------------------------------------------

    public class HRAdvanceRequestsController : BaseBusinessController
    {
        public HRAdvanceRequestsController()
        {
            dal = new DALBaseProvider("HRAdvanceRequests", typeof(HRAdvanceRequestsInfo));
        }
        /// <summary>
        /// Get the purchase order list for invoicing
        /// </summary>
        /// <returns>List of purchase orders</returns>
        public List<HRAdvanceRequestsInfo> GetAdvanceRequestsForPaymentVoucher()
        {
            DataSet ds = dal.GetDataSet("HRAdvanceRequests_GetAdvanceRequestsForPaymentVoucher");
            List<HRAdvanceRequestsInfo> advanceRequestList = new List<HRAdvanceRequestsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRAdvanceRequestsInfo objAdvanceRequestsInfo = (HRAdvanceRequestsInfo)GetObjectFromDataRow(row);
                    advanceRequestList.Add(objAdvanceRequestsInfo);
                }
            }
            return advanceRequestList;
        }
        public DataSet GetAdvanceRequestsList()
        {
            return dal.GetDataSet("HRAdvanceRequests_GetAdvanceRequestList");
        }
    }
    #endregion
}