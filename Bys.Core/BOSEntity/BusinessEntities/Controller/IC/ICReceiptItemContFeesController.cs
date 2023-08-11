﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ICReceiptItemContFees
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICReceiptItemContFeesController
    //Created Date:Monday, March 18, 2019
    //-----------------------------------------------------------

    public class ICReceiptItemContFeesController : BaseBusinessController
    {
        public ICReceiptItemContFeesController()
        {
            dal = new DALBaseProvider("ICReceiptItemContFees", typeof(ICReceiptItemContFeesInfo));
        }

        public List<ICReceiptItemContFeesInfo> GetDataByICReceiptID(int receiptID)
        {
            DataSet ds = dal.GetDataSet("ICReceiptItemContFees_GetDataByICReceiptID", receiptID);
            return (List<ICReceiptItemContFeesInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            var result = new List<ICReceiptItemContFeesInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    var item = (ICReceiptItemContFeesInfo)GetObjectFromDataRow(row);
                    result.Add(item);
                }
            }
            ds.Dispose();
            return result;
        }
    }
    #endregion
}