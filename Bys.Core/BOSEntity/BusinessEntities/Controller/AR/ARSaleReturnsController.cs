using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARSaleReturns
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARSaleReturnsController
    //Created Date:Thursday, April 01, 2010
    //-----------------------------------------------------------

    public class ARSaleReturnsController : BaseBusinessController
    {
        public ARSaleReturnsController()
        {
            dal = new DALBaseProvider("ARSaleReturns", typeof(ARSaleReturnsInfo));
        }

        /// <summary>
        /// Get sale return list based on some criteria
        /// </summary>
        /// <returns></returns>
        public DataSet GetSaleReturnList(string saleReturnNo, string invoiceNo, int? customerID, int? employeeID, DateTime? fromDate, DateTime? toDate)
        {
            return dal.GetDataSet("ARSaleReturns_GetSaleReturnList", saleReturnNo, invoiceNo, customerID, employeeID, fromDate, toDate);
        }

        /// <summary>
        /// Get a sale return by id
        /// </summary>
        /// <param name="saleReturnID">Sale return id</param>
        /// <returns>Sale return object</returns>
        public ARSaleReturnsInfo GetSaleReturnByID(int saleReturnID)
        {
            return (ARSaleReturnsInfo)dal.GetDataObject("ARSaleReturns_GetSaleReturnByID", saleReturnID);
        }


        /// <summary>
        /// Get sale returns for transferring
        /// </summary>
        /// <returns>List of transferred sale returns</returns>
        public List<ARSaleReturnsInfo> GetSaleReturnsForTransferring()
        {
            DataSet ds = dal.GetDataSet("ARSaleReturns_GetSaleReturnsForTransferring");
            return (List<ARSaleReturnsInfo>)GetListFromDataSet(ds);
        }

        /// <summary>
        /// Get sale returns for broadcasting to a branch
        /// </summary>
        /// <param name="branchID">Branch id</param>
        /// <returns>List of broadcasted sale returns</returns>
        public List<ARSaleReturnsInfo> GetSaleReturnsForBroadcasting(int branchID)
        {
            DataSet ds = dal.GetDataSet("ARSaleReturns_GetSaleReturnsForBroadcasting", branchID);
            return (List<ARSaleReturnsInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ARSaleReturnsInfo> saleReturns = new List<ARSaleReturnsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARSaleReturnsInfo objSaleReturnsInfo = (ARSaleReturnsInfo)GetObjectFromDataRow(row);
                    saleReturns.Add(objSaleReturnsInfo);
                }
            }
            ds.Dispose();
            return saleReturns;
        }

        /// <summary>
        /// Get sale return list by branchID
        /// </summary>
        /// <param name="saleReturnNo">saleReturn No</param>
        /// <param name="invoiceNo">invoice No</param>
        /// <param name="customerID">customer ID</param>
        /// <param name="employeeID">employee ID</param>
        /// <param name="saleReturnDateFrom">sale Return Date From</param>
        /// <param name="saleReturnDateTo">sale Return Date To</param>
        /// <param name="branchID">branchID</param>
        /// <param name="branchList">branchList</param>
        /// <returns></returns>
        public DataSet GetSaleReturnListByListOfBranchID(string saleReturnNo,
                                                           string invoiceNo,
                                                           int? objectID,
                                                           string objectType,
                                                           int? employeeID,
                                                           DateTime? saleReturnDateFrom,
                                                           DateTime? saleReturnDateTo,
                                                           int? branchID,
                                                           List<BRBranchsInfo> branchList)
        {
            DataSet rtn = new DataSet();
            foreach (BRBranchsInfo ojbBranchsInfo in branchList)
            {
                DataSet ds = GetSaleReturnListByBranchID(saleReturnNo, invoiceNo, objectID, objectType, employeeID, saleReturnDateFrom, saleReturnDateTo, ojbBranchsInfo.BRBranchID);
                rtn.Merge(ds);
            }

            return rtn;
        }

        /// <summary>
        /// Get sale return list by branchID
        /// </summary>
        /// <param name="saleReturnNo">saleReturn No</param>
        /// <param name="invoiceNo">invoice No</param>
        /// <param name="customerID">customer ID</param>
        /// <param name="employeeID">employee ID</param>
        /// <param name="saleReturnDateFrom">sale Return Date From</param>
        /// <param name="saleReturnDateTo">sale Return Date To</param>
        /// <param name="branchID">branchID</param>
        /// <returns></returns>
        public DataSet GetSaleReturnListByBranchID(string saleReturnNo,
                                                   string invoiceNo,
                                                   int? objectID,
                                                   string objectType,
                                                   int? employeeID,
                                                   DateTime? saleReturnDateFrom,
                                                   DateTime? saleReturnDateTo,
                                                   int? branchID)
        {

            return dal.GetDataSet("ARSaleReturns_GetSaleReturnListByBranchID", saleReturnNo, invoiceNo, objectID, objectType, employeeID, saleReturnDateFrom, saleReturnDateTo, branchID);
        }

        public List<ARSaleReturnsInfo> GetSaleReturnsForShipping()
        {
            DataSet ds = dal.GetDataSet("ARSaleReturns_GetSaleReturnsForShipping");
            return (List<ARSaleReturnsInfo>)GetListFromDataSet(ds);
        }

        public List<ARSaleReturnsInfo> GetSaleReturnsForPayment(int? branchID)
        {
            DataSet ds = dal.GetDataSet("ARSaleReturns_GetSaleReturnsForPayment", branchID);
            return (List<ARSaleReturnsInfo>)GetListFromDataSet(ds);
        }
        public void UpdateUniCost(int saleReturnID)
        {
            dal.ExecuteStoredProcedure("ARSaleReturns_UpdateUniCost", saleReturnID);
        }
    }
    #endregion
}