﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMBatchProductItemViews
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMBatchProductItemViewsController
    //Created Date:Thursday, November 05, 2015
    //-----------------------------------------------------------

    public class MMBatchProductItemViewsController : BaseBusinessController
    {
        public MMBatchProductItemViewsController()
        {
            dal = new DALBaseProvider("MMBatchProductItemViews", typeof(MMBatchProductItemViewsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<MMBatchProductItemViewsInfo> batchProductItemList = new List<MMBatchProductItemViewsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMBatchProductItemViewsInfo objBatchProductItemViewsInfo = (MMBatchProductItemViewsInfo)GetObjectFromDataRow(row);
                    batchProductItemList.Add(objBatchProductItemViewsInfo);
                }
            }
            ds.Dispose();
            return batchProductItemList;
        }

        public List<MMBatchProductItemViewsInfo> GetItemByBatchProductID(int batchProductID)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductItemViews_GetItemByBatchProductID", batchProductID);
            return (List<MMBatchProductItemViewsInfo>)GetListFromDataSet(ds);
        }

        public List<MMBatchProductItemViewsInfo> GetProductedQty(int batchProductID, int batchProductItemID = 0)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductItemViews_GetProductedQty", batchProductID, batchProductItemID);
            return (List<MMBatchProductItemViewsInfo>)GetListFromDataSet(ds);
        }

        public void CloseBatchProductItem(int batchProductItemID)
        {
            dal.ExecuteStoredProcedure("MMBatchProductItemViews_CloseBatchProductItem", batchProductItemID);
        }
    }
    #endregion
}