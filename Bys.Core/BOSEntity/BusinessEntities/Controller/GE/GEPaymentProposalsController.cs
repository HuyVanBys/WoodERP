﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region APPaymentProposals
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APPaymentProposalsController
    //Created Date:Monday, November 09, 2015
    //-----------------------------------------------------------

    public class GEPaymentProposalsController : BaseBusinessController
    {
        public GEPaymentProposalsController()
        {
            dal = new DALBaseProvider("GEPaymentProposals", typeof(GEPaymentProposalsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<GEPaymentProposalsInfo> leaveDays = new List<GEPaymentProposalsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    GEPaymentProposalsInfo leaveDay = (GEPaymentProposalsInfo)GetObjectFromDataRow(row);
                    leaveDays.Add(leaveDay);
                }
            }
            ds.Dispose();
            return leaveDays;
        }

        public List<GEPaymentProposalsInfo> GetAllPaymentForHome(DateTime fromDate, DateTime toDate)
        {
            DataSet ds = dal.GetDataSet("GEPaymentProposals_GetAllPaymentForHome", fromDate, toDate);
            return (List<GEPaymentProposalsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}