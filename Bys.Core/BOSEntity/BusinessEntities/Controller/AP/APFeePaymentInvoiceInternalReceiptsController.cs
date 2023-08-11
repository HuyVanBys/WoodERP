﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region APFeePaymentInvoiceInternalReceipts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APFeePaymentInvoiceInternalReceiptsController
    //Created Date:Sunday, August 19, 2018
    //-----------------------------------------------------------

    public class APFeePaymentInvoiceInternalReceiptsController : BaseBusinessController
    {
        public APFeePaymentInvoiceInternalReceiptsController()
        {
            dal = new DALBaseProvider("APFeePaymentInvoiceInternalReceipts", typeof(APFeePaymentInvoiceInternalReceiptsInfo));
        }

        public List<APFeePaymentInvoiceInternalReceiptsInfo> GetReceiptsByFeePaymentID(int feePaymentID)
        {
            DataSet ds = dal.GetDataSet("APFeePaymentInvoiceInternalReceipts_GetReceiptsByFeePaymentID", feePaymentID);
            return (List<APFeePaymentInvoiceInternalReceiptsInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<APFeePaymentInvoiceInternalReceiptsInfo> receipts = new List<APFeePaymentInvoiceInternalReceiptsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    APFeePaymentInvoiceInternalReceiptsInfo objFeePaymentReceiptsInfo = (APFeePaymentInvoiceInternalReceiptsInfo)GetObjectFromDataRow(row);
                    receipts.Add(objFeePaymentReceiptsInfo);
                }
            }
            ds.Dispose();
            return receipts;
        }
    }
    #endregion
}