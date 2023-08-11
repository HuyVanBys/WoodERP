﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region APPurchaseOrderItemOutSourcings
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APPurchaseOrderItemOutSourcingsController
    //Created Date:Monday, October 28, 2019
    //-----------------------------------------------------------

    public class APPurchaseOrderItemOutSourcingsController : BaseBusinessController
    {
        public APPurchaseOrderItemOutSourcingsController()
        {
            dal = new DALBaseProvider("APPurchaseOrderItemOutSourcings", typeof(APPurchaseOrderItemOutSourcingsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<APPurchaseOrderItemOutSourcingsInfo> itemOutSourcingsList = new List<APPurchaseOrderItemOutSourcingsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    APPurchaseOrderItemOutSourcingsInfo objPOtemOutSourcingsInfo = (APPurchaseOrderItemOutSourcingsInfo)GetObjectFromDataRow(row);
                    itemOutSourcingsList.Add(objPOtemOutSourcingsInfo);
                }
            }
            ds.Dispose();
            return itemOutSourcingsList;
        }

        public List<APPurchaseOrderItemOutSourcingsInfo> GetItemForTransfer(int purchaseOrderID, DateTime fromDate, DateTime toDate)
        {
            DataSet ds = dal.GetDataSet("APPurchaseOrderItemOutSourcings_GetItemForTransfer", purchaseOrderID, fromDate, toDate);
            return (List<APPurchaseOrderItemOutSourcingsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}