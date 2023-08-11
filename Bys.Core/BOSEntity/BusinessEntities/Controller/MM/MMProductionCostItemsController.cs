﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMProductionCostItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProductionCostItemsController
    //Created Date:Tuesday, December 01, 2015
    //-----------------------------------------------------------

    public class MMProductionCostItemsController : BaseBusinessController
    {
        public MMProductionCostItemsController()
        {
            dal = new DALBaseProvider("MMProductionCostItems", typeof(MMProductionCostItemsInfo));
        }

        public List<MMProductionCostItemsInfo> GetProductionCostItemByDate(DateTime fromDate, DateTime toDate)
        {
            List<MMProductionCostItemsInfo> productionCostItemList = new List<MMProductionCostItemsInfo>();

            DataSet ds = dal.GetDataSet("MMProductionCostItems_GetProductionCostItemByDate", fromDate, toDate);

            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMProductionCostItemsInfo objProductionCostItemsInfo = (MMProductionCostItemsInfo)GetObjectFromDataRow(row);
                    productionCostItemList.Add(objProductionCostItemsInfo);
                }
            }
            return productionCostItemList;
        }

        public List<MMProductionCostItemsInfo> GetProductionCostWoodItemByDate(DateTime fromDate, DateTime toDate)
        {
            List<MMProductionCostItemsInfo> productionCostItemList = new List<MMProductionCostItemsInfo>();

            DataSet ds = dal.GetDataSet("MMProductionCostItems_GetProductionCostWoodItemByDate", fromDate, toDate);

            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMProductionCostItemsInfo objProductionCostItemsInfo = (MMProductionCostItemsInfo)GetObjectFromDataRow(row);
                    productionCostItemList.Add(objProductionCostItemsInfo);
                }
            }
            return productionCostItemList;
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<MMProductionCostItemsInfo> productionCostItemList = new List<MMProductionCostItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMProductionCostItemsInfo objProductionCostItemsInfo = (MMProductionCostItemsInfo)GetObjectFromDataRow(row);
                    productionCostItemList.Add(objProductionCostItemsInfo);
                }
            }
            ds.Dispose();
            return productionCostItemList;
        }
    }
    #endregion
}