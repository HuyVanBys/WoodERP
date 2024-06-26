﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMBatchProductItemOperationInfos
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMBatchProductItemOperationInfosController
    //Created Date:Tuesday, April 17, 2018
    //-----------------------------------------------------------

    public class MMBatchProductItemOperationInfosController : BaseBusinessController
    {
        public MMBatchProductItemOperationInfosController()
        {
            dal = new DALBaseProvider("MMBatchProductItemOperationInfos", typeof(MMBatchProductItemOperationInfosInfo));
        }

        /// <summary>
        /// Get Operations process By BatchProductProductionNormItem
        /// </summary>
        /// <param name="batchProductProductionNormItemID"></param>
        /// <returns></returns>
        public List<MMBatchProductItemOperationInfosInfo> GetOperationProcesssByBatchProductProductionNormItem(int batchProductProductionNormItemID)
        {
            DataSet ds = dal.GetDataSet("MMProductionNormItemOperations_GetOperationProcesssByBatchProductProductionNormItem", batchProductProductionNormItemID);
            List<MMBatchProductItemOperationInfosInfo> productionNormsList = new List<MMBatchProductItemOperationInfosInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMBatchProductItemOperationInfosInfo obj = (MMBatchProductItemOperationInfosInfo)GetObjectFromDataRow(row);
                    productionNormsList.Add(obj);
                }
            }
            ds.Dispose();
            return productionNormsList;
        }
        public DataSet GetDataOperationProcesssByBatchProductProductionNormItem(int batchProductProductionNormItemID)
        {
            DataSet ds = dal.GetDataSet("MMProductionNormItemOperations_GetDataOperationProcesssByBatchProductProductionNormItem", batchProductProductionNormItemID);
            return ds;
        }
        public DataSet GetDataOperationProcesssBySomeCriteria(int batchProductProductionNormItemID, int batchProductItemID, int productID, int productionNormItemID, int? FK_MMOperationID)
        {
            DataSet ds = dal.GetDataSet("MMProductionNormItemOperations_GetDataOperationProcesssBySomeCriteria", batchProductProductionNormItemID, batchProductItemID, productID, productionNormItemID, FK_MMOperationID);
            return ds;
        }
        public void InsertItemFromProductionNormOperationProcess(int productionNormID, int batchProductItemID, int batchProductID, string createdUser)
        {
            dal.ExecuteStoredProcedure("MMBatchProductItemOperationInfos_InsertItemFromProductionNormOperationProcess", productionNormID, batchProductItemID, batchProductID, createdUser);
        }
        public void InsertProductionNormProcessByOperation(int productionNormID, int batchProductItemID, int batchProductID, string user, int BatchProductItemOperationByID)
        {
            dal.ExecuteStoredProcedure("MMBatchProductItemOperationInfos_InsertProductionNormProcessByOperation", productionNormID, batchProductItemID, batchProductID, user, BatchProductItemOperationByID);
        }
        public List<MMBatchProductItemOperationInfosInfo> GetItemBySomeConditions(int batchProductID, string productGroup, bool isHaveParent)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductItemOperationInfos_GetItemBySomeConditions", batchProductID, productGroup, isHaveParent);
            List<MMBatchProductItemOperationInfosInfo> productionNormItemsList = new List<MMBatchProductItemOperationInfosInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMBatchProductItemOperationInfosInfo objProductionNormItemsInfo = (MMBatchProductItemOperationInfosInfo)GetObjectFromDataRow(row);
                    productionNormItemsList.Add(objProductionNormItemsInfo);
                }
            }
            ds.Dispose();
            return productionNormItemsList;
        }

        public List<MMBatchProductItemOperationInfosInfo> GetDataOperationProcesssByBarcode(int batchProductProductionNormItemID, int batchProductItemID, int productID, int productionNormItemID)
        {
            DataSet ds = dal.GetDataSet("MMProductionNormItemOperations_GetDataOperationProcesssByBarcode", batchProductProductionNormItemID, batchProductItemID, productID, productionNormItemID);
            List<MMBatchProductItemOperationInfosInfo> productionNormItemsList = new List<MMBatchProductItemOperationInfosInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMBatchProductItemOperationInfosInfo objProductionNormItemsInfo = (MMBatchProductItemOperationInfosInfo)GetObjectFromDataRow(row);
                    productionNormItemsList.Add(objProductionNormItemsInfo);
                }
            }
            ds.Dispose();
            return productionNormItemsList;
        }

        /// <summary>
        /// Get Operations process By BatchProductProductionNormItem
        /// </summary>
        /// <param name="batchProductProductionNormItemID"></param>
        /// <returns></returns>
        public MMBatchProductItemOperationInfosInfo GetOperationProcesssByBatchProduct(int batchProductID)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductItemOperationInfos_GetOperationProcesssByBatchProduct", batchProductID);
            List<MMBatchProductItemOperationInfosInfo> productionNormsList = new List<MMBatchProductItemOperationInfosInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMBatchProductItemOperationInfosInfo obj = (MMBatchProductItemOperationInfosInfo)GetObjectFromDataRow(row);
                    ds.Dispose();
                    return obj;
                }
            }
            ds.Dispose();
            return null;
        }
        /// <summary>
        /// Get Operations process By BatchProductProductionNormItem
        /// </summary>
        /// <param name="batchProductProductionNormItemID"></param>
        /// <returns></returns>
        public List<MMBatchProductItemOperationInfosInfo> GetOperationProcesssByListBatchProductItem(string batchProductItemList)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductItemOperationInfos_GetOperationProcesssByListBatchProduct", batchProductItemList);
            List<MMBatchProductItemOperationInfosInfo> productionNormItemsList = new List<MMBatchProductItemOperationInfosInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMBatchProductItemOperationInfosInfo objProductionNormItemsInfo = (MMBatchProductItemOperationInfosInfo)GetObjectFromDataRow(row);
                    productionNormItemsList.Add(objProductionNormItemsInfo);
                }
            }
            ds.Dispose();
            return productionNormItemsList;
        }
    }
    #endregion
}