﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARSOPaymentTimeInvoiceDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARSOPaymentTimeInvoiceDetailsController
    //Created Date:Wednesday, July 22, 2015
    //-----------------------------------------------------------

    public class ARSOPaymentTimeInvoiceDetailsController : BaseBusinessController
    {
        public ARSOPaymentTimeInvoiceDetailsController()
        {
            dal = new DALBaseProvider("ARSOPaymentTimeInvoiceDetails", typeof(ARSOPaymentTimeInvoiceDetailsInfo));
        }

        public List<ARSOPaymentTimeInvoiceDetailsInfo> GetDetailBySomeCondition(int saleOrderID, int invoiceID)
        {
            DataSet ds = dal.GetDataSet("ARSOPaymentTimeInvoiceDetails_GetDetailBySomeCondition", saleOrderID, invoiceID);
            return (List<ARSOPaymentTimeInvoiceDetailsInfo>)GetListFromDataSet(ds);
        }

        public List<ARSOPaymentTimeInvoiceDetailsInfo> GetItemBySaleOrderID(int saleOrderID)
        {
            DataSet ds = dal.GetDataSet("ARSOPaymentTimeInvoiceDetails_GetItemBySaleOrderID", saleOrderID);
            return (List<ARSOPaymentTimeInvoiceDetailsInfo>)GetListFromDataSet(ds);
        }

        public ARSOPaymentTimeInvoiceDetailsInfo GetDetailBySomeInvoiceID(int invoiceID)
        {
            DataSet ds = dal.GetDataSet("ARSOPaymentTimeInvoiceDetails_GetDetailBySomeInvoiceID", invoiceID);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARSOPaymentTimeInvoiceDetailsInfo objInvoicesInfo = (ARSOPaymentTimeInvoiceDetailsInfo)GetObjectFromDataRow(row);
                    return objInvoicesInfo;
                }
            }
            return null;
        }

        public ARSOPaymentTimeInvoiceDetailsInfo GetDetailBySomeInvoiceNoAndCustomerPaymentNo(string invoiceNo, string customerpaymentno)
        {
            DataSet ds = dal.GetDataSet("ARSOPaymentTimeInvoiceDetails_GetDetailBySomeInvoiceNoAndCustomerPaymentNo", invoiceNo, customerpaymentno);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARSOPaymentTimeInvoiceDetailsInfo objInvoicesInfo = (ARSOPaymentTimeInvoiceDetailsInfo)GetObjectFromDataRow(row);
                    return objInvoicesInfo;
                }
            }
            return null;
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ARSOPaymentTimeInvoiceDetailsInfo> invoices = new List<ARSOPaymentTimeInvoiceDetailsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARSOPaymentTimeInvoiceDetailsInfo objInvoicesInfo = (ARSOPaymentTimeInvoiceDetailsInfo)GetObjectFromDataRow(row);
                    invoices.Add(objInvoicesInfo);
                }
            }
            ds.Dispose();
            return invoices;
        }

        public ARSOPaymentTimeInvoiceDetailsInfo GetByCancelVoucherNo(string cancelVoucherNo)
        {
            DataSet ds = dal.GetDataSet("ARSOPaymentTimeInvoiceDetails_GetByCancelVoucherNo", cancelVoucherNo);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARSOPaymentTimeInvoiceDetailsInfo objInvoicesInfo = (ARSOPaymentTimeInvoiceDetailsInfo)GetObjectFromDataRow(row);
                    return objInvoicesInfo;
                }
            }
            return null;
        }

        public ARSOPaymentTimeInvoiceDetailsInfo GetBySaleReturnNo(string saleReturnNo)
        {
            DataSet ds = dal.GetDataSet("ARSOPaymentTimeInvoiceDetails_GetBySaleReturnNo", saleReturnNo);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARSOPaymentTimeInvoiceDetailsInfo objInvoicesInfo = (ARSOPaymentTimeInvoiceDetailsInfo)GetObjectFromDataRow(row);
                    return objInvoicesInfo;
                }
            }
            return null;
        }

        public List<ARSOPaymentTimeInvoiceDetailsInfo> GetDetailDepositBySaleOrderID(int saleOrderID)
        {
            DataSet ds = dal.GetDataSet("ARSOPaymentTimeInvoiceDetails_GetDetailDepositBySaleOrderID", saleOrderID);
            return (List<ARSOPaymentTimeInvoiceDetailsInfo>)GetListFromDataSet(ds);
        }

        public List<ARSOPaymentTimeInvoiceDetailsInfo> GetDetailClearingByInvoiceID(int invoiceID)
        {
            DataSet ds = dal.GetDataSet("ARSOPaymentTimeInvoiceDetails_GetDetailClearingByInvoiceID", invoiceID);
            return (List<ARSOPaymentTimeInvoiceDetailsInfo>)GetListFromDataSet(ds);
        }

        public List<ARSOPaymentTimeInvoiceDetailsInfo> GetDetailPaidByInvoiceID(int invoiceID)
        {
            DataSet ds = dal.GetDataSet("ARSOPaymentTimeInvoiceDetails_GetDetailPaidByInvoiceID", invoiceID);
            return (List<ARSOPaymentTimeInvoiceDetailsInfo>)GetListFromDataSet(ds);
        }

        public List<ARSOPaymentTimeInvoiceDetailsInfo> GetClearingInfoByInvoiceID(int invoiceID)
        {
            DataSet ds = dal.GetDataSet("ARSOPaymentTimeInvoiceDetails_GetClearingInfoByInvoiceID", invoiceID);
            return (List<ARSOPaymentTimeInvoiceDetailsInfo>)GetListFromDataSet(ds);
        }

        public ARSOPaymentTimeInvoiceDetailsInfo GetInvoiceInfoByInvoiceID(int invoiceInID)
        {
            DataSet ds = dal.GetDataSet("ARSOPaymentTimeInvoiceDetails_GetInvoiceInfoByInvoiceID", invoiceInID);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                ARSOPaymentTimeInvoiceDetailsInfo objSOPaymentTimeInvoiceDetailsInfo = (ARSOPaymentTimeInvoiceDetailsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                return objSOPaymentTimeInvoiceDetailsInfo;
            }
            return null;
        }
    }
    #endregion
}