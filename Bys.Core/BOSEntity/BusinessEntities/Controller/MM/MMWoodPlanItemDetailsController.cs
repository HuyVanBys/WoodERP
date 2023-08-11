﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMWoodPlanItemDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMWoodPlanItemDetailsController
    //Created Date:Saturday, November 14, 2015
    //-----------------------------------------------------------

    public class MMWoodPlanItemDetailsController : BaseBusinessController
    {
        public MMWoodPlanItemDetailsController()
        {
            dal = new DALBaseProvider("MMWoodPlanItemDetails", typeof(MMWoodPlanItemDetailsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<MMWoodPlanItemDetailsInfo> list = new List<MMWoodPlanItemDetailsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMWoodPlanItemDetailsInfo info = (MMWoodPlanItemDetailsInfo)GetObjectFromDataRow(row);
                    list.Add(info);
                }
            }
            ds.Dispose();
            return list;
        }

        public List<MMWoodPlanItemDetailsInfo> GetWoodPlanItemByWoodPlanItemID(int woodPlanItemID)
        {
            DataSet ds = dal.GetDataSet("MMWoodPlanItems_GetWoodPlanItemByWoodPlanItemID", woodPlanItemID);
            return (List<MMWoodPlanItemDetailsInfo>)GetListFromDataSet(ds);
        }

        public List<MMWoodPlanItemDetailsInfo> GetWoodPlanItemDetailByBatchProductAndGroup(int batchProductID)
        {
            DataSet ds = dal.GetDataSet("MMWoodPlanItemDetails_GetWoodPlanItemDetailByBatchProductAndGroup", batchProductID);
            List<MMWoodPlanItemDetailsInfo> components = new List<MMWoodPlanItemDetailsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMWoodPlanItemDetailsInfo objWoodPlanItemDetailsInfo = (MMWoodPlanItemDetailsInfo)GetObjectFromDataRow(row);
                    components.Add(objWoodPlanItemDetailsInfo);
                }
            }
            ds.Dispose();
            return components;
        }

        public List<MMWoodPlanItemDetailsInfo> GetWoodPlanItemDetailByProductionNorm(int productionNormID, decimal productQty)
        {
            DataSet ds = dal.GetDataSet("MMWoodPlanItemDetails_GetWoodPlanItemDetailByProductionNorm", productionNormID, productQty);
            List<MMWoodPlanItemDetailsInfo> components = new List<MMWoodPlanItemDetailsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMWoodPlanItemDetailsInfo objWoodPlanItemDetailsInfo = (MMWoodPlanItemDetailsInfo)GetObjectFromDataRow(row);
                    components.Add(objWoodPlanItemDetailsInfo);
                }
            }
            ds.Dispose();
            return components;
        }

        public List<MMWoodPlanItemDetailsInfo> GetWoodPlanItemDetailsForAllocationPlan(int woodPlanID)
        {
            DataSet ds = dal.GetDataSet("MMWoodPlanItemDetails_GetWoodPlanItemDetailsForAllocationPlan", woodPlanID);
            List<MMWoodPlanItemDetailsInfo> woodPlanItemDetails = new List<MMWoodPlanItemDetailsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMWoodPlanItemDetailsInfo objWoodPlanItemDetailsInfo = (MMWoodPlanItemDetailsInfo)GetObjectFromDataRow(row);
                    woodPlanItemDetails.Add(objWoodPlanItemDetailsInfo);
                }
            }
            ds.Dispose();
            return woodPlanItemDetails;
        }

        public List<MMWoodPlanItemDetailsInfo> GetWoodPlanItemDetailsForPurchasePlan(int woodPlanID)
        {
            DataSet ds = dal.GetDataSet("MMWoodPlanItemDetails_GetWoodPlanItemDetailsForPurchasePlan", woodPlanID);
            List<MMWoodPlanItemDetailsInfo> woodPlanItemDetails = new List<MMWoodPlanItemDetailsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMWoodPlanItemDetailsInfo objWoodPlanItemDetailsInfo = (MMWoodPlanItemDetailsInfo)GetObjectFromDataRow(row);
                    woodPlanItemDetails.Add(objWoodPlanItemDetailsInfo);
                }
            }
            ds.Dispose();
            return woodPlanItemDetails;
        }

        public List<MMWoodPlanItemDetailsInfo> GetWoodPlanItemDetailForReport(int batchProductID)
        {
            DataSet ds = dal.GetDataSet("MMWoodPlanItemDetails_GetWoodPlanItemDetailForReport", batchProductID);
            List<MMWoodPlanItemDetailsInfo> woodPlanItemDetails = new List<MMWoodPlanItemDetailsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMWoodPlanItemDetailsInfo objWoodPlanItemDetailsInfo = (MMWoodPlanItemDetailsInfo)GetObjectFromDataRow(row);
                    woodPlanItemDetails.Add(objWoodPlanItemDetailsInfo);
                }
            }
            ds.Dispose();
            return woodPlanItemDetails;
        }

        public List<MMWoodPlanItemDetailsInfo> GetWoodPlanItemByBatchProductID(int batchProductID)
        {
            DataSet ds = dal.GetDataSet("MMWoodPlanItems_GetWoodPlanItemByBatchProductID", batchProductID);
            return (List<MMWoodPlanItemDetailsInfo>)GetListFromDataSet(ds);
        }
        public List<MMWoodPlanItemDetailsInfo> GetKLHDCTSXTrongky(int batchProductID, DateTime fromDate, DateTime toDate)
        {
            DataSet ds = dal.GetDataSet("MMWoodPlanItems_GetKLHDCTSXTrongky", batchProductID, fromDate, toDate);
            return (List<MMWoodPlanItemDetailsInfo>)GetListFromDataSet(ds);
        }
        public List<MMWoodPlanItemDetailsInfo> GetKLHDCTSXTheoMaTrongky(int batchProductID, int productID, DateTime fromDate, DateTime toDate)
        {
            DataSet ds = dal.GetDataSet("MMWoodPlanItems_GetKLHDCTSXTheoMaTrongky", batchProductID, productID, fromDate, toDate);
            return (List<MMWoodPlanItemDetailsInfo>)GetListFromDataSet(ds);
        }
        public List<MMWoodPlanItemDetailsInfo> GetListItemNotInAllocationPlanItems(int woodPlanID)
        {
            DataSet ds = dal.GetDataSet("MMWoodPlanItemDetails_GetListItemNotInAllocationPlanItems", woodPlanID);
            return (List<MMWoodPlanItemDetailsInfo>)GetListFromDataSet(ds);
        }

        //public List<MMWoodPlanItemDetailsInfo> GetListObjectForCancel(int woodPlanID)
        //{
        //    DataSet ds = dal.GetDataSet("MMWoodPlanItemsDetails_GetListObjectForCancel", woodPlanID);
        //    List<MMWoodPlanItemDetailsInfo> woodPlanItemDetails = new List<MMWoodPlanItemDetailsInfo>();
        //    if (ds.Tables.Count > 0)
        //    {
        //        foreach (DataRow row in ds.Tables[0].Rows)
        //        {
        //            MMWoodPlanItemDetailsInfo objWoodPlanItemDetailsInfo = (MMWoodPlanItemDetailsInfo)GetObjectFromDataRow(row);
        //            if (objWoodPlanItemDetailsInfo != null)
        //            {
        //                //decimal dryblock = objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductDryBlocks - objWoodPlanItemDetailsInfo.MMWoodPlanItemDetailProductCancelDryBlock;
        //                if (objWoodPlanItemDetailsInfo.MMAllocationPlanItemQty == 0)
        //                {
        //                    objWoodPlanItemDetailsInfo.MinCancelQty = (objWoodPlanItemDetailsInfo.MMBatchProductItemProductQty - objWoodPlanItemDetailsInfo.MMBatchProductItemCancelQty - objWoodPlanItemDetailsInfo.MMCancelWoodPlanProductQty);
        //                }
        //                objWoodPlanItemDetailsInfo.MinCancelQty = Math.Floor(objWoodPlanItemDetailsInfo.MinCancelQty);
        //                woodPlanItemDetails.Add(objWoodPlanItemDetailsInfo);
        //            }
        //        }
        //    }
        //    return woodPlanItemDetails;



        //}
        //public List<MMWoodPlanItemDetailsInfo> GetListItemByWoodPlanItemID(int WoodPlanItemID)
        //{
        //    DataSet ds = dal.GetDataSet("MMWoodPlanItemDetails_GetListItemByWoodPlanItemID", WoodPlanItemID);
        //    return (List<MMWoodPlanItemDetailsInfo>)GetListFromDataSet(ds);
        //}

        public List<MMWoodPlanItemDetailsInfo> GetWoodPlanItemDetailByBatchProductID(int batchProductID)
        {
            DataSet ds = dal.GetDataSet("MMWoodPlanItemDetails_GetWoodPlanItemDetailByBatchProductID", batchProductID);
            return (List<MMWoodPlanItemDetailsInfo>)GetListFromDataSet(ds);
        }

        public decimal GetTotalWoodPlanItemBlocksByBatchProductID(int batchProductID)
        {
            decimal totalBlocks = (decimal)dal.GetSingleValue("MMWoodPlanItems_GetTotalWoodPlanItemBlocksByBatchProductID", batchProductID);
            return totalBlocks;
        }
        public List<MMWoodPlanItemDetailsInfo> GetWoodListBySomeCriteria(int MMBatchProductID, int ICProductForBatchID, int ICProductID, int ProductAttributeQualityID)
        {
            DataSet ds = dal.GetDataSet("MMWoodPlanItemDetails_GetWoodListBySomeCriteria", MMBatchProductID, ICProductForBatchID, ICProductID, ProductAttributeQualityID);
            return (List<MMWoodPlanItemDetailsInfo>)GetListFromDataSet(ds);
        }
        public List<MMWoodPlanItemDetailsInfo> GetOperationDetailPlanWoodListBySomeCriteria(int MMBatchProductID, int ICProductForBatchID, int ICProductID, int ProductAttributeQualityID, int operationDetailPlanID)
        {
            DataSet ds = dal.GetDataSet("MMWoodPlanItemDetails_GetOperationDetailPlanWoodListBySomeCriteria", MMBatchProductID, ICProductForBatchID, ICProductID, ProductAttributeQualityID, operationDetailPlanID);
            return (List<MMWoodPlanItemDetailsInfo>)GetListFromDataSet(ds);
        }
        public List<MMWoodPlanItemDetailsInfo> GetDetailByListBatchProductIDAndProductID(string batchProductList, string productList)
        {
            DataSet ds = dal.GetDataSet("MMWoodPlanItemDetails_GetDetailByListBatchProductIDAndProductID", batchProductList, productList);
            return (List<MMWoodPlanItemDetailsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}