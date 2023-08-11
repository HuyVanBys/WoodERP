﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMWoodPlanItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMWoodPlanItemsController
    //Created Date:Friday, November 13, 2015
    //-----------------------------------------------------------

    public class MMWoodPlanItemsController : BaseBusinessController
    {
        public MMWoodPlanItemsController()
        {
            dal = new DALBaseProvider("MMWoodPlanItems", typeof(MMWoodPlanItemsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<MMWoodPlanItemsInfo> list = new List<MMWoodPlanItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMWoodPlanItemsInfo obj = (MMWoodPlanItemsInfo)GetObjectFromDataRow(row);
                    list.Add(obj);
                }
            }
            ds.Dispose();
            return list;
        }

        public List<MMWoodPlanItemsInfo> GetWoodPlanItemByWoodPlanID(int WoodPlanID)
        {
            DataSet ds = dal.GetDataSet("MMWoodPlanItems_GetWoodPlanItemByWoodPlanID", WoodPlanID);
            return (List<MMWoodPlanItemsInfo>)GetListFromDataSet(ds);
        }

        public void UpdateWoodPlanItemProductNo(int ProductID, string ProductNo, string ParentNo)
        {
            dal.ExecuteStoredProcedure("MMWoodPlanItems_UpdateWoodPlanItemProductNo", ProductID, ProductNo, ParentNo);
        }
        public List<MMWoodPlanItemsInfo> GetListItemNotInAllocationPlanItems(int WoodPlanID)
        {
            DataSet ds = dal.GetDataSet("MMWoodPlanItems_GetListItemNotInAllocationPlanItems", WoodPlanID);
            return (List<MMWoodPlanItemsInfo>)GetListFromDataSet(ds);

        }
        public List<MMWoodPlanItemsInfo> GetListItemByWoodPlanID(int woodPlanID, int BatchProductItemID)
        {
            DataSet ds = dal.GetDataSet("MMWoodPlanItems_GetListItemByWoodPlanID", woodPlanID, BatchProductItemID);
            return (List<MMWoodPlanItemsInfo>)GetListFromDataSet(ds);
        }

    }
    #endregion
}