﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region APPOPaymentTimeInvoiceInDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APPOPaymentTimeInvoiceInDetailsController
    //Created Date:Tuesday, November 10, 2015
    //-----------------------------------------------------------

    public class APPOPaymentTimeInvoiceInDetailsController : BaseBusinessController
    {
        public APPOPaymentTimeInvoiceInDetailsController()
        {
            dal = new DALBaseProvider("APPOPaymentTimeInvoiceInDetails", typeof(APPOPaymentTimeInvoiceInDetailsInfo));
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<APPOPaymentTimeInvoiceInDetailsInfo> paymentTimeInvoiceInDetails = new List<APPOPaymentTimeInvoiceInDetailsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    APPOPaymentTimeInvoiceInDetailsInfo objPOPaymentTimeInvoiceInDetailsInfo = (APPOPaymentTimeInvoiceInDetailsInfo)GetObjectFromDataRow(row);
                    paymentTimeInvoiceInDetails.Add(objPOPaymentTimeInvoiceInDetailsInfo);
                }
            }
            ds.Dispose();
            return paymentTimeInvoiceInDetails;
        }
        public List<APPOPaymentTimeInvoiceInDetailsInfo> GetItemByPurchaseOrderID(int purchaseOrderID)
        {
            DataSet ds = dal.GetDataSet("APPOPaymentTimeInvoiceInDetails_GetItemByPurchaseOrderID", purchaseOrderID);
            return (List<APPOPaymentTimeInvoiceInDetailsInfo>)GetListFromDataSet(ds);
        }
        public List<APPOPaymentTimeInvoiceInDetailsInfo> GetItemPurchaseOrderIDAndInvoiceInID(int purchaseOrderID, int invoiceInID)
        {
            DataSet ds = dal.GetDataSet("APPOPaymentTimeInvoiceInDetails_GetItemPurchaseOrderIDAndInvoiceInID", purchaseOrderID, invoiceInID);
            return (List<APPOPaymentTimeInvoiceInDetailsInfo>)GetListFromDataSet(ds);
        }
        public List<APPOPaymentTimeInvoiceInDetailsInfo> GetDetailDepositByPurchaseOrderNo(string purchaseOrderNo)
        {
            DataSet ds = dal.GetDataSet("APPOPaymentTimeInvoiceInDetails_GetDetailDepositByPurchaseOrderNo", purchaseOrderNo);
            return (List<APPOPaymentTimeInvoiceInDetailsInfo>)GetListFromDataSet(ds);
        }

        public void ClearExistedDetailOfInvoiceIn(int invoiceInID)
        {
            dal.ExecuteStoredProcedure("APPOPaymentTimeInvoiceInDetails_ClearExistedDetailOfInvoiceIn", invoiceInID);

        }

        public List<APPOPaymentTimeInvoiceInDetailsInfo> GetDetailClearingByInvoiceInID(int invoiceInID)
        {
            DataSet ds = dal.GetDataSet("APPOPaymentTimeInvoiceInDetails_GetDetailClearingByInvoiceInID", invoiceInID);
            return (List<APPOPaymentTimeInvoiceInDetailsInfo>)GetListFromDataSet(ds);
        }

        public List<APPOPaymentTimeInvoiceInDetailsInfo> GetDetailPaidByInvoiceInID(int invoiceInID)
        {
            DataSet ds = dal.GetDataSet("APPOPaymentTimeInvoiceInDetails_GetDetailPaidByInvoiceInID", invoiceInID);
            return (List<APPOPaymentTimeInvoiceInDetailsInfo>)GetListFromDataSet(ds);
        }

        public void InsertDetailByAssetReceiptNo(string assetReceiptNo, string moduleName)
        {
            dal.ExecuteStoredProcedure("APPOPaymentTimeInvoiceInDetails_InsertDetailByAssetReceiptNo", assetReceiptNo, moduleName);
        }

        public void InsertDetailByEquimentReceiptNo(string equimentReceiptNo, string moduleName)
        {
            dal.ExecuteStoredProcedure("APPOPaymentTimeInvoiceInDetails_InsertDetailByEquimentReceiptNo", equimentReceiptNo, moduleName);
        }

        public void ClearExistedDetailOfDocument(int documentID)
        {
            dal.ExecuteStoredProcedure("APPOPaymentTimeInvoiceInDetails_ClearExistedDetailOfDocument", documentID);
        }

        public List<APPOPaymentTimeInvoiceInDetailsInfo> GetClearingInfoByDocumentNoAndInvoiceInID(string documentNo, int invoiceInID)
        {
            DataSet ds = dal.GetDataSet("APPOPaymentTimeInvoiceInDetails_GetClearingInfoByDocumentNoAndInvoiceInID", documentNo, invoiceInID);
            return (List<APPOPaymentTimeInvoiceInDetailsInfo>)GetListFromDataSet(ds);
        }

        public List<APPOPaymentTimeInvoiceInDetailsInfo> GetClearingInfoByInvoiceInID(int invoiceInID)
        {
            DataSet ds = dal.GetDataSet("APPOPaymentTimeInvoiceInDetails_GetClearingInfoByInvoiceInID", invoiceInID);
            return (List<APPOPaymentTimeInvoiceInDetailsInfo>)GetListFromDataSet(ds);
        }

        public APPOPaymentTimeInvoiceInDetailsInfo GetInvoiceInInfoByInvoiceInID(int invoiceInID)
        {
            DataSet ds = dal.GetDataSet("APPOPaymentTimeInvoiceInDetails_GetInvoiceInInfoByInvoiceInID", invoiceInID);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                APPOPaymentTimeInvoiceInDetailsInfo objPOPaymentTimeInvoiceInDetailsInfo = (APPOPaymentTimeInvoiceInDetailsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                return objPOPaymentTimeInvoiceInDetailsInfo;
            }
            return null;
        }

        public List<APPOPaymentTimeInvoiceInDetailsInfo> GetPaidPaymentByPurchaseOrderID(int purchaseOrderID)
        {
            DataSet ds = dal.GetDataSet("APPOPaymentTimeInvoiceInDetails_GetPaidPaymentByPurchaseOrderID", purchaseOrderID);
            return (List<APPOPaymentTimeInvoiceInDetailsInfo>)GetListFromDataSet(ds);
        }

        public void InsertDetailByPurchaseOrderID(int purchaseOrderID, string moduleName, string userName)
        {
            dal.ExecuteStoredProcedure("APPOPaymentTimeInvoiceInDetails_InsertDetailByPurchaseOrderID", purchaseOrderID, moduleName, userName);

        }
        public List<APPOPaymentTimeInvoiceInDetailsInfo> GetUsedPaymentByPurchaseOrdersList(string purchaseOrderIDs)
        {
            DataSet ds = dal.GetDataSet("APPOPaymentTimeInvoiceInDetails_GetUsedPaymentByPurchaseOrdersList", purchaseOrderIDs);
            return (List<APPOPaymentTimeInvoiceInDetailsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}