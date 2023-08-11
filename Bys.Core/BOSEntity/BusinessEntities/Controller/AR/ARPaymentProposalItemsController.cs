﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARPaymentProposalItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARPaymentProposalItemsController
    //Created Date:Friday, May 4, 2018
    //-----------------------------------------------------------

    public class ARPaymentProposalItemsController : BaseBusinessController
    {
        public ARPaymentProposalItemsController()
        {
            dal = new DALBaseProvider("ARPaymentProposalItems", typeof(ARPaymentProposalItemsInfo));
        }

        public List<ARPaymentProposalItemsInfo> GetPaymentProposalItemsForPaymentProposal()
        {
            DataSet ds = dal.GetDataSet("ARPaymentProposalItems_GetPaymentProposalItemsForPaymentProposal");
            return (List<ARPaymentProposalItemsInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ARPaymentProposalItemsInfo> paymentProposalPayments = new List<ARPaymentProposalItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARPaymentProposalItemsInfo objPaymentProposalPaymentsInfo = (ARPaymentProposalItemsInfo)GetObjectFromDataRow(row);
                    paymentProposalPayments.Add(objPaymentProposalPaymentsInfo);
                }
            }
            ds.Dispose();
            return paymentProposalPayments;
        }

        public void UpdatePaidAmountByCustomerPaymentID(int customerPaymentID)
        {
            dal.ExecuteStoredProcedure("ARPaymentProposalItems_UpdatePaidAmountByCustomerPaymentID", customerPaymentID);

        }

        public List<ARPaymentProposalItemsInfo> GetDepositBySaleOrderID(int saleOrderID)
        {
            DataSet ds = dal.GetDataSet("ARPaymentProposalItems_GetDepositBySaleOrderID", saleOrderID);
            return (List<ARPaymentProposalItemsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}