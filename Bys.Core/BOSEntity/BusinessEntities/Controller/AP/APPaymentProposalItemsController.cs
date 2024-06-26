﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region APPaymentProposalItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APPaymentProposalItemsController
    //Created Date:Monday, November 09, 2015
    //-----------------------------------------------------------

    public class APPaymentProposalItemsController : BaseBusinessController
    {
        public APPaymentProposalItemsController()
        {
            dal = new DALBaseProvider("APPaymentProposalItems", typeof(APPaymentProposalItemsInfo));
        }

        public List<APPaymentProposalItemsInfo> GetPaymentProposalItemsForPaymentProposalFromInvoiceInTransactions(int objectID, string type)
        {
            DataSet ds = dal.GetDataSet("APPaymentProposalItems_GetPaymentProposalItemsForPaymentProposalFromInvoiceInTransactions", objectID, type);
            return (List<APPaymentProposalItemsInfo>)GetListFromDataSet(ds);
        }

        public List<APPaymentProposalItemsInfo> GetPaymentProposalItemCheckAmount(int documentID, int invoiceInID, int paymentproposalItemID, int purchaseOrderPaymentTimeID)
        {
            DataSet ds = dal.GetDataSet("APPaymentProposalItems_GetPaymentProposalItemCheckAmount", documentID, invoiceInID, paymentproposalItemID, purchaseOrderPaymentTimeID);
            return (List<APPaymentProposalItemsInfo>)GetListFromDataSet(ds);
        }

        public List<APPaymentProposalItemsInfo> GetDocumentsForPaymentProposal()
        {
            DataSet ds = dal.GetDataSet("APPaymentProposalItems_GetDocumentsForPaymentProposal");
            return (List<APPaymentProposalItemsInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<APPaymentProposalItemsInfo> invoices = new List<APPaymentProposalItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    APPaymentProposalItemsInfo objInvoicesInfo = (APPaymentProposalItemsInfo)GetObjectFromDataRow(row);
                    invoices.Add(objInvoicesInfo);
                }
            }
            ds.Dispose();
            return invoices;
        }

        public List<APPaymentProposalItemsInfo> GetPaymentProposalItemByPaymentProposalID(int paymentProposalID)
        {
            DataSet ds = dal.GetDataSet("APPaymentProposalItems_GetPaymentProposalItemByPaymentProposalID", paymentProposalID);
            return (List<APPaymentProposalItemsInfo>)GetListFromDataSet(ds);
        }

        public List<APPaymentProposalItemsInfo> GetPaymentProposalItemForPayment()
        {
            DataSet ds = dal.GetDataSet("APPaymentProposalItems_GetPaymentProposalItemForPayment");
            return (List<APPaymentProposalItemsInfo>)GetListFromDataSet(ds);
        }

        public List<APPaymentProposalItemsInfo> GetItemByPurchaseOrderIDAndType(int purchaseOrderID, string type)
        {
            DataSet ds = dal.GetDataSet("APPaymentProposalItems_GetItemByPurchaseOrderIDAndType", purchaseOrderID, type);
            return (List<APPaymentProposalItemsInfo>)GetListFromDataSet(ds);
        }
        public List<APPaymentProposalItemsInfo> GetPaymentProposalItemForIssue()
        {
            DataSet ds = dal.GetDataSet("APPaymentProposalItems_GetPaymentProposalItemForIssue");
            return (List<APPaymentProposalItemsInfo>)GetListFromDataSet(ds);
        }

        public List<APPaymentProposalItemsInfo> GetItemByPurchaseOrderID(int purchaseOrderID)
        {
            DataSet ds = dal.GetDataSet("APPaymentProposalItems_GetItemByPurchaseOrderID", purchaseOrderID);
            return (List<APPaymentProposalItemsInfo>)GetListFromDataSet(ds);
        }

        public List<APPaymentProposalItemsInfo> GetPaymentProposalItemByDocumentID(int documentID)
        {
            DataSet ds = dal.GetDataSet("APPaymentProposalItems_GetPaymentProposalItemByDocumentID", documentID);
            return (List<APPaymentProposalItemsInfo>)GetListFromDataSet(ds);
        }

        public List<APPaymentProposalItemsInfo> GetPaymentProposalItemFromTransactionByPaymentProposalID(int paymentProposalID)
        {
            DataSet ds = dal.GetDataSet("APPaymentProposalItems_GetPaymentProposalItemFromTransactionByPaymentProposalID", paymentProposalID);
            return (List<APPaymentProposalItemsInfo>)GetListFromDataSet(ds);
        }
        public void UpdateReferPaymentDataBySupplierPayment(int pupplierPaymentID, bool isRollBack)
        {
            dal.ExecuteStoredProcedure("APPaymentProposalItems_UpdateReferPaymentDataBySupplierPayment", pupplierPaymentID, isRollBack);
        }

        public List<APPaymentProposalItemsInfo> GetListProposalItemRemainDiscountFixByProposalItemID(DataTable type_ProposalItemIDs)
        {
            DataSet ds = SqlDatabaseHelper.GetDataUsingStringType(type_ProposalItemIDs, "Type_PaymentID", "APPaymentProposalItems_GetListProposalItemRemainDiscountFixByProposalItemID");
            return (List<APPaymentProposalItemsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}