﻿using BOSCommon.Extensions;
using BOSLib;
using BOSLib.Extensions;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP
{
    #region ICTransactions
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICTransactionsController
    //Created Date:21 Tháng Mười Hai 2018
    //-----------------------------------------------------------

    public class ICTransactionsController : BaseBusinessController
    {
        public ICTransactionsController()
        {
            dal = new DALBaseProvider("ICTransactions", typeof(ICTransactionsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ICTransactionsInfo> list = new List<ICTransactionsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICTransactionsInfo obj = (ICTransactionsInfo)GetObjectFromDataRow(row);
                    list.Add(obj);
                }
            }
            ds.Dispose();
            return list;
        }

        public decimal GetProductUnitCost(int stockID, int productID, string productSerieNo, DateTime toDate)
        {
            decimal result = 0;
            object unitCost = dal.GetSingleValue("ICTransactions_GetProductUnitCost", stockID, productID, productSerieNo, toDate);
            if (unitCost != null)
                result = Convert.ToDecimal(unitCost);
            return result;
        }

        public decimal GetInventoryStockQty(int stockID, int productID, string productSerieNo, DateTime toDate)
        {
            decimal result = 0;
            object unitCost = dal.GetSingleValue("ICTransactions_GetInventoryStockQty", stockID, productID, productSerieNo, toDate);
            if (unitCost != null)
                result = Convert.ToDecimal(unitCost);
            return result;
        }

        public void PostTransactionByFeePayment(int documentID, string documentNo, string documentAllocationForm)
        {
            dal.ExecuteStoredProcedure("ICTransactions_PostTransactionByFeePayment", documentID, documentNo, documentAllocationForm);
        }

        //public ICTransactionsInfo GetInventoryStockByProductID(int productID, string productSerieNo)
        //{
        //    return (ICTransactionsInfo)dal.GetDataObject("ICTransactions_GetTransactionsByProductIDAndProductSerie", productID, productSerieNo);
        //}

        public List<ICTransactionsInfo> GetInventoryCard(DateTime fromDate, DateTime toDate, int? productID, int? stockID)
        {
            DataSet ds = dal.GetDataSet("ICTransactions_GetInventoryCard", fromDate, toDate, productID, stockID);
            return (List<ICTransactionsInfo>)GetListFromDataSet(ds);
        }
        public List<ICTransactionsInfo> GetInventoryCardBySomeCriteria(DateTime fromDate, DateTime toDate, int? productID, int? stockID, int? serieID, bool isGetAccumulatedQty)
        {
            DataSet ds = dal.GetTimeOutDataSet("ICTransactions_GetInventoryCardBySomeCriteria", 500,fromDate, toDate, productID, stockID, serieID, isGetAccumulatedQty);
            return (List<ICTransactionsInfo>)GetListFromDataSet(ds);
        }
        public List<ICTransactionsInfo> GetInventoryStatistics(DateTime fromDate, DateTime toDate, int? productID, int? departmentID, int? productGroupID, int? supplierID, int? stockID, int? batchID, bool isGroupByStock)
        {
            DataSet ds = dal.GetDataSet("ICTransactions_GetInventoryStatistics1", fromDate, toDate, productID, departmentID, productGroupID, supplierID, stockID, batchID, isGroupByStock);
            return (List<ICTransactionsInfo>)GetListFromDataSet(ds);
        }

        public List<ICTransactionsInfo> GetInventoryStatisticsBySomeConditions(DateTime fromDate, DateTime toDate, int? productID, int? departmentID, int? productGroupID, int? supplierID, string stockIDs, int accountID, bool isGroupByStock)
        {
            DataSet ds = dal.GetDataSet("ICTransactions_GetInventoryStatisticsBySomeConditions", fromDate, toDate, productID, departmentID, productGroupID, supplierID, stockIDs, accountID, isGroupByStock);
            return (List<ICTransactionsInfo>)GetListFromDataSet(ds);
        }

        public List<ICTransactionsInfo> GetTransactionApplyCost(int? month, int? year, int? stockID, int? productGroupID, int? productID)
        {
            DataSet ds = dal.GetDataSet("ICTransactions_GetTransactionApplyCost", month, year, stockID, productGroupID, productID);
            return (List<ICTransactionsInfo>)GetListFromDataSet(ds);
        }
        public void PostProductionCostCalculation(int MMProductionCostCalculationID)
        {
            dal.ExecuteStoredProcedureNonQuery("ICTransactions_PostProductionCostCalculation", MMProductionCostCalculationID);
        }
        public List<ICTransactionsInfo> GetTransactionProductionCostCalculation(int productionCostCalculationID)
        {
            DataSet ds = dal.GetDataSet("ICTransactions_GetTransactionProductionCostCalculation", productionCostCalculationID);
            return (List<ICTransactionsInfo>)GetListFromDataSet(ds);
        }

        public List<ICTransactionsInfo> GetAvailableInventoryStockQty(string productRef, string stockRef = "", int branchID = 0)
        {
            List<int> productIds = new List<int>();
            if (!productRef.IsNullOrEmpty())
                productIds = productRef.Split(',').Select(o => Int32.Parse(o)).ToList();
            List<int> stockIds = new List<int>();
            if (!stockRef.IsNullOrEmpty())
                stockIds = stockRef.Split(',').Select(o => Int32.Parse(o)).ToList();

            return GetInventoryStockListByProductRef(productIds, stockIds, branchID);
        }

        public List<ICTransactionsInfo> GetInventoryStockListByProductRef(List<int> productIds, List<int> stockIds = null, int? branchID = 0)
        {
            DataTable productDt = productIds.ToDataTableIds();
            DataTable stockDt = stockIds.ToDataTableIds();
            var parameters = new DynamicParameters();
            parameters.Add("@ProductIds", productDt.AsTableValuedParameter("Type_ObjectID"), DbType.Object, ParameterDirection.Input);
            parameters.Add("@StockIds", stockDt.AsTableValuedParameter("Type_ObjectID"), DbType.Object, ParameterDirection.Input);
            parameters.Add("@BranchID", branchID, DbType.Int32, ParameterDirection.Input);
            var results = dal.Connection.ExecuteReader("ICTransactions_GetAvailableInventoryStockQty", parameters, commandType: CommandType.StoredProcedure);
            return results.ConvertToList<ICTransactionsInfo>().ToList();
        }
        public List<ICTransactionsInfo> GetInventoryStockListBySomeCreteria(List<int> productIds, List<int> stockIds = null, int? branchID = 0)
        {
            DataTable productDt = productIds.ToDataTableIds();
            DataTable stockDt = stockIds.ToDataTableIds();
            var parameters = new DynamicParameters();
            parameters.Add("@ProductIds", productDt.AsTableValuedParameter("Type_ObjectID"), DbType.Object, ParameterDirection.Input);
            parameters.Add("@StockIds", stockDt.AsTableValuedParameter("Type_ObjectID"), DbType.Object, ParameterDirection.Input);
            parameters.Add("@BranchID", branchID, DbType.Int32, ParameterDirection.Input);
            var results = dal.Connection.ExecuteReader("ICTransactions_GetInventoryStockListBySomeCreteria", parameters, commandType: CommandType.StoredProcedure);
            return results.ConvertToList<ICTransactionsInfo>().ToList();
        }

        public decimal GetInventoryQtyByProductIDAndStockID(int productID, int stockID, int userGroupID)
        {
            decimal result = 0;
            object unitCost = dal.GetSingleValue("ICTransactions_GetInventoryQtyByProductIDAndStockID", productID, stockID, userGroupID);
            if (unitCost != null)
                result = Convert.ToDecimal(unitCost);
            return result;
        }

        public List<ICTransactionsInfo> GetDataByDateAndBatchProductIDList(DateTime Date, string BatchProductIDList)
        {
            DataSet ds = dal.GetDataSet("ICTransactions_GetDataByDateAndBatchProductIDList", Date, BatchProductIDList);
            return (List<ICTransactionsInfo>)GetListFromDataSet(ds);
        }

        public List<ICTransactionsInfo> GetAllReceiptItemsForProductionCostByFormulaID(string BatchProductIDList, int formulaID, DateTime Date)
        {
            DataSet ds = dal.GetDataSet("ICTransactions_GetAllReceiptItemsForProductionCostByFormulaID", BatchProductIDList, formulaID, Date);
            return (List<ICTransactionsInfo>)GetListFromDataSet(ds);
        }
        public List<ICTransactionsInfo> GetDetailFormulaDetailTransactionByFormulaIDAndDate(string InProgressClassifyType, int FormulaID, DateTime FromDate, DateTime ToDate)
        {
            DataSet ds = dal.GetDataSet("ICTransactions_GetDetailFormulaDetailTransactionByFormulaIDAndDate", InProgressClassifyType, FormulaID, FromDate, ToDate);
            return (List<ICTransactionsInfo>)GetListFromDataSet(ds);
        }
        public List<ICTransactionsInfo> GetListInventoryStockQty(DataTable Type_SomeParaInventoryStocks)
        {
            DataSet ds = SqlDatabaseHelper.GetDataUsingStringType(Type_SomeParaInventoryStocks, "Type_SomeParaInventoryStocks", "ICTransactions_GetListInventoryStockQty");
            return (List<ICTransactionsInfo>)GetListFromDataSet(ds);
        }
		public List<ICTransactionsInfo> GetListInventoryStockQtyForInventoryStockCount(DataTable Type_SomeParaInventoryStocks)
        {
            DataSet ds = SqlDatabaseHelper.GetDataUsingStringType(Type_SomeParaInventoryStocks, "Type_SomeParaInventoryStocks", "ICTransactions_GetListInventoryStockQtyForInventoryStockCount");
            return (List<ICTransactionsInfo>)GetListFromDataSet(ds);
        }
        public List<ICTransactionsInfo> CheckDataBySomeCriteria(string type, DateTime fromDate, DateTime toDate)
        {
            DataSet ds = dal.GetDataSet("ICTransactions_CheckDataBySomeCriteria", type, fromDate, toDate);
            if (ds == null)
            {
                return null;
            }
            return (List<ICTransactionsInfo>)GetListFromDataSet(ds);
        }

        public List<ICTransactionsInfo> GetListInvalidSerialNo(DataTable Type_SomeParaInventoryStocks)
        {
            DataSet ds = SqlDatabaseHelper.GetDataUsingStringType(Type_SomeParaInventoryStocks, "Type_SomeParaInventoryStocks", "ICTransactions_GetListInvalidSerialNo");
            return (List<ICTransactionsInfo>)GetListFromDataSet(ds);
        }
        public List<ICTransactionsInfo> GetListInvalidSerialNoBySomeCriteria(DataTable Type_SomeParaInventoryStocks)
        {
            DataSet ds = SqlDatabaseHelper.GetDataUsingStringType(Type_SomeParaInventoryStocks, "Type_CheckExitSerialNo", "ICTransactions_GetListInvalidSerialNoBySomeCriteria");
            return (List<ICTransactionsInfo>)GetListFromDataSet(ds);
        }
        public List<ICTransactionsInfo> CheckDocumentMissICtransaction(int stockID, DateTime fromDate, DateTime toDate)
        {
            DataSet ds = dal.GetDataSet("ICTransactions_CheckDocumentMissICtransaction", stockID, fromDate, toDate);
            return (List<ICTransactionsInfo>)GetListFromDataSet(ds);
        }

        public List<ICTransactionsInfo> GetShipmentReferenceByReceiptID(int receiptID, string tableName)
        {
            DataSet ds = dal.GetDataSet("ICTransactions_GetShipmentReferenceByReceiptID", receiptID, tableName);
            return (List<ICTransactionsInfo>)GetListFromDataSet(ds);
        }
        public bool GetTransactionByProductID(int productID)
        {
            bool result = false;
            object isTransaction = dal.GetSingleValue("ICTransactions_GetTransactionByProductID", productID);
            if (isTransaction != null)
                result = Convert.ToBoolean(isTransaction);
            return result;
        }

        public List<ICTransactionsInfo> CheckAvailableQty(DataTable Type_SomeParaInventoryStocks)
        {
            DataSet ds = SqlDatabaseHelper.GetDataUsingStringType(Type_SomeParaInventoryStocks, "Type_SomeParaInventoryStocks", "ICTransactions_CheckAvailableQty");
            return (List<ICTransactionsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}