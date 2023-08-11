﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMProductionCostCalculationDetailCosts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProductionCostCalculationDetailCostsController
    //Created Date:Thursday, October 04, 2018
    //-----------------------------------------------------------

    public class MMProductionCostCalculationDetailCostsController : BaseBusinessController
    {
        public MMProductionCostCalculationDetailCostsController()
        {
            dal = new DALBaseProvider("MMProductionCostCalculationDetailCosts", typeof(MMProductionCostCalculationDetailCostsInfo));
        }

        public List<MMProductionCostCalculationDetailCostsInfo> GetDetailByFormulaIDForProductionCost(int formulaID, DateTime fromDate, DateTime toDate)
        {
            List<MMProductionCostCalculationDetailCostsInfo> invoices = new List<MMProductionCostCalculationDetailCostsInfo>();
            DataSet ds = dal.GetDataSet("MMProductionCostCalculationDetailCosts_GetDetailByFormulaIDForProductionCost", formulaID, fromDate, toDate);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMProductionCostCalculationDetailCostsInfo objInvoicesInfo = (MMProductionCostCalculationDetailCostsInfo)GetObjectFromDataRow(row);
                    invoices.Add(objInvoicesInfo);
                }
            }
            return invoices;
        }

        public List<MMProductionCostCalculationDetailCostsInfo> GetDetailByFormulaIDForProductionCostAndProgressStatistic(int formulaID, int OperationID, DateTime fromDate, DateTime toDate)
        {
            List<MMProductionCostCalculationDetailCostsInfo> invoices = new List<MMProductionCostCalculationDetailCostsInfo>();
            DataSet ds = dal.GetDataSet("MMProductionCostCalculationDetailCosts_GetDetailByFormulaIDForProductionCostAndProgressStatistic", formulaID, OperationID, fromDate, toDate);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMProductionCostCalculationDetailCostsInfo objInvoicesInfo = (MMProductionCostCalculationDetailCostsInfo)GetObjectFromDataRow(row);
                    invoices.Add(objInvoicesInfo);
                }
            }
            ds.Dispose();
            return invoices;
        }

        public List<MMProductionCostCalculationDetailCostsInfo> GetInProgressDetailForProductionCost(DateTime fromDate, int formulaID)
        {
            List<MMProductionCostCalculationDetailCostsInfo> invoices = new List<MMProductionCostCalculationDetailCostsInfo>();
            DataSet ds = dal.GetDataSet("MMProductionCostCalculationDetailCosts_GetInProgressDetailForProductionCost", fromDate, formulaID);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMProductionCostCalculationDetailCostsInfo objInvoicesInfo = (MMProductionCostCalculationDetailCostsInfo)GetObjectFromDataRow(row);
                    invoices.Add(objInvoicesInfo);
                }
            }
            return invoices;
        }


    }
    #endregion
}