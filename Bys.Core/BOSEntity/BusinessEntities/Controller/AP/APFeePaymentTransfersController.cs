﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region APFeePaymentTransfers
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APFeePaymentTransfersController
    //Created Date:Saturday, August 18, 2018
    //-----------------------------------------------------------

    public class APFeePaymentTransfersController : BaseBusinessController
    {
        public APFeePaymentTransfersController()
        {
            dal = new DALBaseProvider("APFeePaymentTransfers", typeof(APFeePaymentTransfersInfo));
        }

        public List<APFeePaymentTransfersInfo> GetTransfersByFeePaymentID(int feePaymentID)
        {
            DataSet ds = dal.GetDataSet("APFeePaymentTransfers_GetTransfersByFeePaymentID", feePaymentID);
            return (List<APFeePaymentTransfersInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<APFeePaymentTransfersInfo> Transfers = new List<APFeePaymentTransfersInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    APFeePaymentTransfersInfo objFeePaymentTransfersInfo = (APFeePaymentTransfersInfo)GetObjectFromDataRow(row);
                    Transfers.Add(objFeePaymentTransfersInfo);
                }
            }
            ds.Dispose();
            return Transfers;
        }
    }
    #endregion
}