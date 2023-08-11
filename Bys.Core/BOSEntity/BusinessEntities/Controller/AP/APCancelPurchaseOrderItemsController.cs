﻿using BOSLib;
using System.Collections.Generic;
using System.Data;

namespace BOSERP
{
    #region APCancelPurchaseOrderItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APCancelPurchaseOrderItemsController
    //Created Date:Tuesday, May 31, 2016
    //-----------------------------------------------------------

    public class APCancelPurchaseOrderItemsController : BaseBusinessController
    {
        public APCancelPurchaseOrderItemsController()
        {
            dal = new DALBaseProvider("APCancelPurchaseOrderItems", typeof(APCancelPurchaseOrderItemsInfo));
        }

        public decimal GetAllowCancelQty(int purchaseOrderItemID, int cancelPurchaseOrderItemID)
        {
            return (decimal)dal.GetSingleValue("APCancelPurchaseOrderItems_GetAllowCancelQty", purchaseOrderItemID, cancelPurchaseOrderItemID);
        }
        public List<APCancelPurchaseOrderItemsInfo> GetAllItemsFromCancelPurchaseOrderID(int cancelPurchaseOrderID)
        {
            DataSet ds = dal.GetDataSet("APCancelPurchaseOrderItems_GetAllItemsFromCancelPurchaseOrderID", cancelPurchaseOrderID);
            return (List<APCancelPurchaseOrderItemsInfo>)GetListFromDataSet(ds);
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<APCancelPurchaseOrderItemsInfo> list = new List<APCancelPurchaseOrderItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    APCancelPurchaseOrderItemsInfo obj = (APCancelPurchaseOrderItemsInfo)GetObjectFromDataRow(row);
                    list.Add(obj);
                }
            }
            ds.Dispose();
            return list;
        }
    }
    #endregion
}