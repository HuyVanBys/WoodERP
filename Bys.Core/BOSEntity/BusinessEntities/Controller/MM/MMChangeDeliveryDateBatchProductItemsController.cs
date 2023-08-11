﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMChangeDeliveryDateBatchProductItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMChangeDeliveryDateBatchProductItemsController
    //Created Date:Friday, January 04, 2019
    //-----------------------------------------------------------

    public class MMChangeDeliveryDateBatchProductItemsController : BaseBusinessController
    {
        public MMChangeDeliveryDateBatchProductItemsController()
        {
            dal = new DALBaseProvider("MMChangeDeliveryDateBatchProductItems", typeof(MMChangeDeliveryDateBatchProductItemsInfo));
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<MMChangeDeliveryDateBatchProductItemsInfo> BatchProducts = new List<MMChangeDeliveryDateBatchProductItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMChangeDeliveryDateBatchProductItemsInfo objBatchProductsInfo = (MMChangeDeliveryDateBatchProductItemsInfo)GetObjectFromDataRow(row);
                    BatchProducts.Add(objBatchProductsInfo);
                }
            }
            ds.Dispose();
            return BatchProducts;
        }
        public List<MMChangeDeliveryDateBatchProductItemsInfo> GetBatchProductItemByCusotmerID(int customerID, int batchProductID)
        {
            DataSet ds = dal.GetDataSet("MMCDDBatchProductItems_GetBatchProductItemByCusotmerID", customerID, batchProductID);
            return (List<MMChangeDeliveryDateBatchProductItemsInfo>)GetListFromDataSet(ds);
        }
        public List<MMChangeDeliveryDateBatchProductItemsInfo> GetCDDBatchProductItemByCusotmerID(int customerID, int batchProductID, int mainobjectID)
        {
            DataSet ds = dal.GetDataSet("MMCDDBatchProductItems_GetCDDBatchProductItemByCusotmerID", customerID, batchProductID, mainobjectID);
            return (List<MMChangeDeliveryDateBatchProductItemsInfo>)GetListFromDataSet(ds);
        }
        public List<MMChangeDeliveryDateBatchProductItemsInfo> GetListForContainerLoader()
        {
            DataSet ds = dal.GetDataSet("MMCDDBatchProductItems_GetListForContainerLoader");
            return (List<MMChangeDeliveryDateBatchProductItemsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}