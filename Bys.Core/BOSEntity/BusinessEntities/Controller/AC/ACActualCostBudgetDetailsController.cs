﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ACActualCostBudgetDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACActualCostBudgetDetailsController
    //Created Date:Tuesday, April 10, 2018
    //-----------------------------------------------------------

    public class ACActualCostBudgetDetailsController : BaseBusinessController
    {
        public ACActualCostBudgetDetailsController()
        {
            dal = new DALBaseProvider("ACActualCostBudgetDetails", typeof(ACActualCostBudgetDetailsInfo));
        }
        public decimal GetTotalActualCostBudgetDetailBySomeCriteria(int? actualCostBudgetID, int? brBranchID, int? FK_ACDebitAccountID, int? FK_ACCreditAccountID)
        {
            ACActualCostBudgetDetailsInfo objActualCostBudgetDetailsInfo = new ACActualCostBudgetDetailsInfo();
            DataSet ds = dal.GetDataSet("ACActualCostBudgetDetails_GetTotalActualCostBudgetDetailBySomeCriteria", actualCostBudgetID, brBranchID, FK_ACDebitAccountID, FK_ACCreditAccountID);
            List<ACActualCostBudgetDetailsInfo> List = (List<ACActualCostBudgetDetailsInfo>)GetListFromDataSet(ds);
            List.ForEach(o =>
            {
                if (o.ACBudgetTrackingItemMonthPerformAmount != null && o.ACBudgetTrackingItemMonthPerformAmount > 0)
                    objActualCostBudgetDetailsInfo.ACBudgetTrackingItemMonthPerformAmount += o.ACBudgetTrackingItemMonthPerformAmount;
            });
            return objActualCostBudgetDetailsInfo.ACBudgetTrackingItemMonthPerformAmount;
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ACActualCostBudgetDetailsInfo> list = new List<ACActualCostBudgetDetailsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ACActualCostBudgetDetailsInfo objActualCostBudgetDetailsInfo = (ACActualCostBudgetDetailsInfo)GetObjectFromDataRow(row);
                    list.Add(objActualCostBudgetDetailsInfo);
                }
            }
            ds.Dispose();
            return list;
        }
        public void InsertByEndingAllocation(string documentNo, string documenttype, string userName)
        {
            dal.ExecuteStoredProcedure("ACActualCostBudgetDetails_InsertByEndingAllocation", documentNo, documenttype, userName);
        }
        public void InsertDetailByAllcationCostDocument(string documentNo, string userName, string type)
        {
            dal.ExecuteStoredProcedure("ACActualCostBudgetDetails_InsertDetailByAllcationCostDocument", documentNo, userName, type);
        }

        public List<ACActualCostBudgetDetailsInfo> GetDetailForCalGeneralCost(DateTime fromDate, DateTime toDate, int debitAccountID, int creditAccountID, string moduleName)
        {
            List<ACActualCostBudgetDetailsInfo> invoices = new List<ACActualCostBudgetDetailsInfo>();
            DataSet ds = dal.GetDataSet("ACActualCostBudgetDetails_GetDetailForCalGeneralCost", fromDate, toDate, debitAccountID, creditAccountID, moduleName);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ACActualCostBudgetDetailsInfo objInvoicesInfo = (ACActualCostBudgetDetailsInfo)GetObjectFromDataRow(row);
                    invoices.Add(objInvoicesInfo);
                }
            }
            ds.Dispose();
            return invoices;
        }
        public List<ACActualCostBudgetDetailsInfo> GetTranForCalGeneralCost(DateTime fromDate, DateTime toDate, int? debitAccountID, int? creditAccountID, string moduleName)
        {
            List<ACActualCostBudgetDetailsInfo> invoices = new List<ACActualCostBudgetDetailsInfo>();
            DataSet ds = dal.GetDataSet("ACActualCostBudgetDetails_GetTranForCalGeneralCost", fromDate, toDate, debitAccountID, creditAccountID, moduleName);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ACActualCostBudgetDetailsInfo objInvoicesInfo = (ACActualCostBudgetDetailsInfo)GetObjectFromDataRow(row);
                    invoices.Add(objInvoicesInfo);
                }
            }
            ds.Dispose();
            return invoices;
        }
    }
    #endregion
}