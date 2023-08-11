﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMProductionCostCalculationItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProductionCostCalculationItemsController
    //Created Date:Thursday, January 17, 2019
    //-----------------------------------------------------------

    public class MMProductionCostCalculationItemsController : BaseBusinessController
    {
        public MMProductionCostCalculationItemsController()
        {
            dal = new DALBaseProvider("MMProductionCostCalculationItems", typeof(MMProductionCostCalculationItemsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            var result = new List<MMProductionCostCalculationItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    var item = (MMProductionCostCalculationItemsInfo)GetObjectFromDataRow(row);
                    result.Add(item);
                }
            }
            ds.Dispose();
            return result;
        }

        public List<MMProductionCostCalculationItemsInfo> GetItemForProductionCost(DateTime fromDate, DateTime toDate, int formulaID)
        {
            DataSet ds = dal.GetDataSet("MMProductionCostCalculationItems_GetItemForProductionCost", fromDate, toDate, formulaID);
            return (List<MMProductionCostCalculationItemsInfo>)GetListFromDataSet(ds);
        }

        public List<MMProductionCostCalculationItemsInfo> GetItemForProductionCostByOperationID(DateTime fromDate, DateTime toDate, int formulaID, int operationID)
        {
            DataSet ds = dal.GetDataSet("MMProductionCostCalculationItems_GetItemForProductionCostByOperationID", fromDate, toDate, formulaID, operationID);
            return (List<MMProductionCostCalculationItemsInfo>)GetListFromDataSet(ds);
        }

        public MMProductionCostCalculationItemsInfo GetItemTotalQty(DateTime fromDate, DateTime toDate, int formulaID, int operationID)
        {
            MMProductionCostCalculationItemsInfo returnedObj = (MMProductionCostCalculationItemsInfo)dal.GetDataObject("MMProductionCostCalculationItems_GetItemTotalQty", fromDate, toDate, formulaID, operationID);
            return returnedObj;
        }



    }
    #endregion
}