using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region HRManufactureTimeSheetItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRManufactureTimeSheetItemsController
    //Created Date:Friday, December 20, 2013
    //-----------------------------------------------------------

    public class HRManufactureTimeSheetItemsController : BaseBusinessController
    {
        public HRManufactureTimeSheetItemsController()
        {
            dal = new DALBaseProvider("HRManufactureTimeSheetItems", typeof(HRManufactureTimeSheetItemsInfo));
        }

        public List<HRManufactureTimeSheetItemsInfo> GetManufactureTimeSheetItemsByIDAndEmployeeID(int id, int employeeID)
        {
            List<HRManufactureTimeSheetItemsInfo> result = null;
            DataSet ds = dal.GetDataSet("HRManufactureTimeSheetItems_GetManufactureTimeSheetItemsByIDAndEmployeeID", id, employeeID);
            if (ds != null && ds.Tables.Count != 0)
            {
                result = new List<HRManufactureTimeSheetItemsInfo>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRManufactureTimeSheetItemsInfo item = GetObjectFromDataRow(row) as HRManufactureTimeSheetItemsInfo;
                    if (item != null)
                        result.Add(item);
                }
            }
            ds.Dispose();
            return result;

        }
        /// <summary>
        /// Get Product quantity by batchid and employeeid
        /// </summary>
        /// <param name="batchID"></param>
        /// <returns></returns>
        public List<HRManufactureTimeSheetItemsInfo> GetProductQtyByBatchIDAndEmployeeID(int batchID)
        {
            List<HRManufactureTimeSheetItemsInfo> result = null;
            DataSet ds = dal.GetDataSet("HRManufactureTimeSheets_GetProductQtyByBatchIDAndEmployeeID", batchID);
            if (ds != null && ds.Tables.Count != 0)
            {
                result = new List<HRManufactureTimeSheetItemsInfo>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRManufactureTimeSheetItemsInfo item = GetObjectFromDataRow(row) as HRManufactureTimeSheetItemsInfo;
                    if (item != null)
                        result.Add(item);
                }
            }
            ds.Dispose();
            return result;

        }

        ///// <summary>
        ///// Get manufacture time sheet item list by remaning operation
        ///// </summary>
        ///// <returns> List HRManufactureTimeSheetItemsInfo</returns>
        //public List<HRManufactureTimeSheetItemsInfo> GetManufactureTimeSheetItemListByRemaningOperation()
        //{
        //    List<HRManufactureTimeSheetItemsInfo> result = null;
        //    DataSet ds = dal.GetDataSet("HRManufactureTimeSheets_GetManufactureTimeSheetItemListByRemaningOperation");
        //    if (ds != null && ds.Tables.Count != 0)
        //    {
        //        result = new List<HRManufactureTimeSheetItemsInfo>();
        //        foreach (DataRow row in ds.Tables[0].Rows)
        //        {
        //            HRManufactureTimeSheetItemsInfo item = GetObjectFromDataRow(row) as HRManufactureTimeSheetItemsInfo;
        //            if (item != null)
        //                result.Add(item);
        //        }
        //    }

        //    return result;

        //}
        /// <summary>
        /// Get Product quantity by batch item and employee
        /// </summary>
        /// <param name="batchID">batchID</param>
        /// <param name="proposalID">proposalID</param>
        /// <param name="saleOrderID">saleOrderID</param>
        /// <param name="productID">productID</param>
        /// <param name="productComponent">productComponent</param>
        /// <param name="employeeID">employeeID</param>
        /// <returns></returns>
        public List<HRManufactureTimeSheetItemsInfo> GetProductQtyByBatchItemAndEmployee(int? batchID,
                                                                                         int? proposalID,
                                                                                         int? saleOrderID,
                                                                                         int? productID,
                                                                                         int? productComponent,
                                                                                         int? employeeID,
                                                                                         DateTime fromDate,
                                                                                         DateTime toDate)
        {
            List<HRManufactureTimeSheetItemsInfo> result = null;
            DataSet ds = dal.GetDataSet("HRManufactureTimeSheets_GetProductQtyByBatchItemAndEmployee",
                batchID, proposalID, saleOrderID, productID, productComponent, employeeID, fromDate, toDate);
            if (ds != null && ds.Tables.Count != 0)
            {
                result = new List<HRManufactureTimeSheetItemsInfo>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRManufactureTimeSheetItemsInfo item = GetObjectFromDataRow(row) as HRManufactureTimeSheetItemsInfo;
                    if (item != null)
                        result.Add(item);
                }
            }
            ds.Dispose();
            return result;
        }

        ///// <summary>
        ///// Get Product quantity by batch item and employee
        ///// </summary>
        ///// <param name="batchID">batchID</param>
        ///// <param name="proposalID">proposalID</param>
        ///// <param name="saleOrderID">saleOrderID</param>
        ///// <param name="productID">productID</param>
        ///// <param name="productComponent">productComponent</param>
        ///// <param name="employeeID">employeeID</param>
        ///// <returns></returns>
        //public List<HRManufactureTimeSheetItemsInfo> GetManufactureTimeSheetItembySomeCreatia(  int? batchID,
        //                                                                                        int? proposalID,
        //                                                                                        int? saleOrderID,
        //                                                                                        int? productID,
        //                                                                                        int? productComponent,
        //                                                                                        DateTime fromDate,
        //                                                                                        DateTime toDate)
        //{
        //    List<HRManufactureTimeSheetItemsInfo> result = null;
        //    DataSet ds = dal.GetDataSet("HRManufactureTimeSheetItems_GetManufactureTimeSheetItembySomeCreatia",
        //        batchID, proposalID, saleOrderID, productID, productComponent, fromDate, toDate);
        //    if (ds != null && ds.Tables.Count != 0)
        //    {
        //        result = new List<HRManufactureTimeSheetItemsInfo>();
        //        foreach (DataRow row in ds.Tables[0].Rows)
        //        {
        //            HRManufactureTimeSheetItemsInfo item = GetObjectFromDataRow(row) as HRManufactureTimeSheetItemsInfo;
        //            if (item != null)
        //                result.Add(item);
        //        }
        //    }
        //    return result;
        //}
        /// <summary>
        /// Get Product quantity by batch item and employee not batch component
        /// </summary>
        /// <param name="batchID">batchID</param>
        /// <param name="proposalID">proposalID</param>
        /// <param name="saleOrderID">saleOrderID</param>
        /// <param name="productID">productID</param>
        /// <param name="employeeID">employeeID</param>
        /// <returns></returns>
        public List<HRManufactureTimeSheetItemsInfo> GetProductQtyByBatchItemAndEmployeeNotBatchComponent(int? batchID,
                                                                                         int? proposalID,
                                                                                         int? saleOrderID,
                                                                                         int? productID,
                                                                                         int? employeeID,
                                                                                         DateTime fromDate,
                                                                                         DateTime toDate)
        {
            List<HRManufactureTimeSheetItemsInfo> result = null;
            DataSet ds = dal.GetDataSet("HRManufactureTimeSheets_GetProductQtyByBatchItemAndEmployeeNotBatchComponent",
                batchID, proposalID, saleOrderID, productID, employeeID, fromDate, toDate);
            if (ds != null && ds.Tables.Count != 0)
            {
                result = new List<HRManufactureTimeSheetItemsInfo>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRManufactureTimeSheetItemsInfo item = GetObjectFromDataRow(row) as HRManufactureTimeSheetItemsInfo;
                    if (item != null)
                        result.Add(item);
                }
            }
            ds.Dispose();
            return result;
        }


        /// <summary>
        /// Get Product quantity by batch item and operation id and employee
        /// </summary>
        /// <param name="batchID">batchID</param>
        /// <param name="proposalID">proposalID</param>
        /// <param name="saleOrderID">saleOrderID</param>
        /// <param name="productID">productID</param>
        /// <param name="productComponent">productComponent</param>
        /// <param name="employeeID">employeeID</param>
        /// <param name="operationID">operationID</param>
        /// <param name="fromDate">fromDate</param>
        /// <param name="toDate">toDate</param>
        /// <returns>List<HRManufactureTimeSheetItemsInfo></returns>
        public List<HRManufactureTimeSheetItemsInfo> GetProductQtyByBatchItemAndOperationIDAndEmployeeAndManufactureTimeSheetID(int? batchID,
                                                                                         int? proposalID,
                                                                                         int? saleOrderID,
                                                                                         int? productID,
                                                                                         int? productComponent,
                                                                                         int? employeeID,
                                                                                         int? operationID,
                                                                                         int? manufactureTimeSheetID,
                                                                                         DateTime fromDate,
                                                                                         DateTime toDate)
        {
            List<HRManufactureTimeSheetItemsInfo> result = null;
            DataSet ds = dal.GetDataSet("HRManufactureTimeSheets_GetProductQtyByBatchItemAndOperationIDAndEmployee",
                batchID, proposalID, saleOrderID, productID, productComponent, employeeID, operationID, manufactureTimeSheetID, fromDate, toDate);
            if (ds != null && ds.Tables.Count != 0)
            {
                result = new List<HRManufactureTimeSheetItemsInfo>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRManufactureTimeSheetItemsInfo item = GetObjectFromDataRow(row) as HRManufactureTimeSheetItemsInfo;
                    if (item != null)
                        result.Add(item);
                }
            }
            ds.Dispose();
            return result;
        }

        /// <summary>
        /// Get Product quantity by batch item and operation id and employee not batch component
        /// </summary>
        /// <param name="batchID">batchID</param>
        /// <param name="proposalID">proposalID</param>
        /// <param name="saleOrderID">saleOrderID</param>
        /// <param name="productID">productID</param>
        /// <param name="employeeID">employeeID</param>
        /// <param name="operationID">operationID</param>
        /// <param name="fromDate">fromDate</param>
        /// <param name="toDate">toDate</param>
        /// <returns>List<HRManufactureTimeSheetItemsInfo></returns>
        public List<HRManufactureTimeSheetItemsInfo> GetProductQtyByBatchItemAndOperationIDAndEmployeeManufactureTimeSheetIDNotBatchComponent(int? batchID,
                                                                                         int? proposalID,
                                                                                         int? saleOrderID,
                                                                                         int? productID,
                                                                                         int? employeeID,
                                                                                         int? operationID,
                                                                                         int? manufactureTimeSheetID,
                                                                                         DateTime fromDate,
                                                                                         DateTime toDate)
        {
            List<HRManufactureTimeSheetItemsInfo> result = null;
            DataSet ds = dal.GetDataSet("HRManufactureTimeSheets_GetProductQtyByBatchItemAndOperationIDAndEmployeeNotBatchComponent",
                batchID, proposalID, saleOrderID, productID, employeeID, operationID, manufactureTimeSheetID, fromDate, toDate);
            if (ds != null && ds.Tables.Count != 0)
            {
                result = new List<HRManufactureTimeSheetItemsInfo>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRManufactureTimeSheetItemsInfo item = GetObjectFromDataRow(row) as HRManufactureTimeSheetItemsInfo;
                    if (item != null)
                        result.Add(item);
                }
            }
            ds.Dispose();
            return result;
        }


        /// <summary>
        /// Get Product quantity by batch item and operation 
        /// </summary>
        /// <param name="batchID">batchID</param>
        /// <param name="proposalID">proposalID</param>
        /// <param name="saleOrderID">saleOrderID</param>
        /// <param name="productID">productID</param>
        /// <param name="productComponent">productComponent</param>
        /// <param name="operationID">operationID</param>
        /// <returns>List<HRManufactureTimeSheetItemsInfo></returns>
        public List<HRManufactureTimeSheetItemsInfo> GetProductQtyByBatchItemAndOperation(int? batchID,
                                                                                         int? proposalID,
                                                                                         int? saleOrderID,
                                                                                         int? productID,
                                                                                         int? productComponent,
                                                                                         int? operationID)

        {
            List<HRManufactureTimeSheetItemsInfo> result = null;
            DataSet ds = dal.GetDataSet("HRManufactureTimeSheetItems_GetProductQtyByBatchItemAndOperation",
                batchID, proposalID, saleOrderID, productID, productComponent, operationID);
            if (ds != null && ds.Tables.Count != 0)
            {
                result = new List<HRManufactureTimeSheetItemsInfo>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRManufactureTimeSheetItemsInfo item = GetObjectFromDataRow(row) as HRManufactureTimeSheetItemsInfo;
                    if (item != null)
                        result.Add(item);
                }
            }
            ds.Dispose();
            return result;
        }
        /// <summary>
        /// Get Product quantity by batch item and operation 
        /// </summary>
        /// <param name="batchID">batchID</param>
        /// <param name="proposalID">proposalID</param>
        /// <param name="saleOrderID">saleOrderID</param>
        /// <param name="productID">productID</param>
        /// <param name="productComponent">productComponent</param>
        /// <param name="operationID">operationID</param>
        /// <returns>List<HRManufactureTimeSheetItemsInfo></returns>
        public List<HRManufactureTimeSheetItemsInfo> GetProductQtyByBatchItemAndOperationNotBatchComponent(int? batchID,
                                                                                         int? proposalID,
                                                                                         int? saleOrderID,
                                                                                         int? productID,
                                                                                         int? operationID)
        {
            List<HRManufactureTimeSheetItemsInfo> result = null;
            DataSet ds = dal.GetDataSet("HRManufactureTimeSheetItems_GetProductQtyByBatchItemAndOperationNotBatchComponent",
                batchID, proposalID, saleOrderID, productID, operationID);
            if (ds != null && ds.Tables.Count != 0)
            {
                result = new List<HRManufactureTimeSheetItemsInfo>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRManufactureTimeSheetItemsInfo item = GetObjectFromDataRow(row) as HRManufactureTimeSheetItemsInfo;
                    if (item != null)
                        result.Add(item);
                }
            }
            ds.Dispose();
            return result;
        }


        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<HRManufactureTimeSheetItemsInfo> ManufactureTimeSheetItem = new List<HRManufactureTimeSheetItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRManufactureTimeSheetItemsInfo objManufactureTimeSheetIteminfo = (HRManufactureTimeSheetItemsInfo)GetObjectFromDataRow(row);
                    ManufactureTimeSheetItem.Add(objManufactureTimeSheetIteminfo);
                }
            }
            ds.Dispose();
            return ManufactureTimeSheetItem;
        }

    }
    #endregion
}