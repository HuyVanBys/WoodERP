﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ACLoanReceiptPaymentPlans
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACLoanReceiptPaymentPlansController
    //Created Date:17 Tháng Bảy 2018
    //-----------------------------------------------------------

    public class ACLoanReceiptPaymentPlansController : BaseBusinessController
    {
        public ACLoanReceiptPaymentPlansController()
        {
            dal = new DALBaseProvider("ACLoanReceiptPaymentPlans", typeof(ACLoanReceiptPaymentPlansInfo));
        }

        public List<ACLoanReceiptPaymentPlansInfo> GetLoanReceiptPaymentPlansForPaymentVoucher()
        {
            DataSet ds = dal.GetDataSet("ACLoanReceiptPaymentPlans_GetLoanReceiptPaymentPlansForPaymentVoucher");
            List<ACLoanReceiptPaymentPlansInfo> paymentPlans = new List<ACLoanReceiptPaymentPlansInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ACLoanReceiptPaymentPlansInfo objLoanReceiptPaymentPlansInfo = (ACLoanReceiptPaymentPlansInfo)GetObjectFromDataRow(row);
                    paymentPlans.Add(objLoanReceiptPaymentPlansInfo);
                }
            }
            return paymentPlans;
        }

        public List<ACLoanReceiptPaymentPlansInfo> GetLoanReceiptPaymentPlansByPaymentPlanDate(DateTime date)
        {
            DataSet ds = dal.GetDataSet("ACLoanReceiptPaymentPlans_GetLoanReceiptPaymentPlansByPaymentPlanDate", date);
            List<ACLoanReceiptPaymentPlansInfo> paymentPlans = new List<ACLoanReceiptPaymentPlansInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ACLoanReceiptPaymentPlansInfo objLoanReceiptPaymentPlansInfo = (ACLoanReceiptPaymentPlansInfo)GetObjectFromDataRow(row);
                    paymentPlans.Add(objLoanReceiptPaymentPlansInfo);
                }
            }
            return paymentPlans;
        }

        public List<ACLoanReceiptPaymentPlansInfo> GetLoanReceiptPaymentPlansByLoanReceiptID(int loanReceiptID)
        {
            DataSet ds = dal.GetDataSet("ACLoanReceiptPaymentPlans_GetLoanReceiptPaymentPlansByLoanReceiptID", loanReceiptID);
            List<ACLoanReceiptPaymentPlansInfo> paymentPlans = new List<ACLoanReceiptPaymentPlansInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ACLoanReceiptPaymentPlansInfo objLoanReceiptPaymentPlansInfo = (ACLoanReceiptPaymentPlansInfo)GetObjectFromDataRow(row);
                    paymentPlans.Add(objLoanReceiptPaymentPlansInfo);
                }
            }
            return paymentPlans;
        }
    }
    #endregion
}