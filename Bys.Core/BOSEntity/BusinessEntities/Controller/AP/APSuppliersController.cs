using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;


namespace BOSERP
{
    #region APSuppliers
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APSuppliersController
    //Created Date:Friday, March 14, 2008
    //-----------------------------------------------------------

    public class APSuppliersController : BaseBusinessController
    {
        public APSuppliersController()
        {
            dal = new DALBaseProvider("APSuppliers", typeof(APSuppliersInfo));
        }

        /// <summary>
        /// Get supplier list based on some criteria
        /// </summary>
        /// <param name="supplierNo">Supplier no</param>
        /// <param name="supplierName">Supplier name</param>
        /// <param name="branchID">Branch id</param>
        /// <returns>List of suppliers</returns>
        public DataSet GetSupplierList(
                                    string supplierNo,
                                    string supplierName,
                                    string supplierType,
                                    string contactPhone,
                                    string contactAddress,
                                    int? branchID)
        {
            return dal.GetDataSet("APSuppliers_GetSupplierList",
                                supplierNo,
                                supplierName,
                                supplierType,
                                contactPhone,
                                contactAddress,
                                branchID);
        }

        /// <summary>
        /// Get supplier list based on some criteria
        /// </summary>
        /// <param name="supplierNo">Supplier no</param>
        /// <param name="supplierName">Supplier name</param>
        /// <param name="branchID">Branch id</param>
        /// <returns>List of suppliers</returns>
        public DataSet GetSupplierListByListOfBranchID(
                                    string supplierNo,
                                    string supplierName,
                                    string supplierType,
                                    string contactPhone,
                                    string contactAddress,
                                    List<BRBranchsInfo> branchList)
        {
            DataSet rtn = new DataSet();
            foreach (BRBranchsInfo ojbBranchsInfo in branchList)
            {
                DataSet ds = GetSupplierList(supplierNo, supplierName, supplierType, contactPhone, contactAddress, ojbBranchsInfo.BRBranchID);
                rtn.Merge(ds);
            }

            return rtn;
        }

        /// <summary>
        /// Get supplier list based on some criteria
        /// </summary>
        /// <param name="branchID">Branch id</param>
        /// <returns>List of suppliers</returns>
        public DataSet GetSupplierList(int? branchID)
        {
            return GetSupplierList(null, null, null, null, null, branchID);
        }

        /// <summary>
        /// Get all suppliers
        /// </summary>
        /// <returns>The supplier list</returns>
        public List<APSuppliersInfo> GetAllSuppliers()
        {
            DataSet ds = GetSupplierList(null, null, null, null, null, null);
            return (List<APSuppliersInfo>)GetListFromDataSet(ds);
        }

        /// <summary>
        /// Get the purchase order summary of a supplier
        /// </summary>
        /// <param name="objSuppliersInfo">Supplier is used to retrieve data</param>
        /// <param name="from">Date which the result is filtered from</param>
        /// <param name="to">Date which the result is filtered to</param>
        public void GetPurchaseOrderSummary(APSuppliersInfo objSuppliersInfo, DateTime? from, DateTime? to)
        {
            DbCommand cmd = dal.GetStoredProcedureCommand("APSuppliers_GetPurchaseOrderSummary");
            dal.AddParameter(cmd, "APSupplierID", DbType.Int32, ParameterDirection.Input, objSuppliersInfo.APSupplierID);
            dal.AddParameter(cmd, "DateFrom", DbType.DateTime, ParameterDirection.Input, from);
            dal.AddParameter(cmd, "DateTo", DbType.DateTime, ParameterDirection.Input, to);
            dal.AddParameter(cmd, "TotalOrderCost", DbType.Double, ParameterDirection.Output, objSuppliersInfo.TotalOrderCost);
            dal.AddParameter(cmd, "TotalOrderQty", DbType.Double, ParameterDirection.Output, objSuppliersInfo.TotalOrderQty);
            dal.GetDataSet(cmd);

            objSuppliersInfo.TotalOrderCost = Convert.ToDecimal(dal.GetParameterValue(cmd, "TotalOrderCost"));
            objSuppliersInfo.TotalOrderQty = Convert.ToDecimal(dal.GetParameterValue(cmd, "TotalOrderQty"));
        }

        /// <summary>
        /// Get the invoice summary of a supplier
        /// </summary>
        /// <param name="objSuppliersInfo">Supplier is used to retrieve data</param>
        /// <param name="from">Date which the result is filtered from</param>
        /// <param name="to">Date which the result is filtered to</param>
        public void GetInvoiceSummary(APSuppliersInfo objSuppliersInfo, DateTime? from, DateTime? to)
        {
            DbCommand cmd = dal.GetStoredProcedureCommand("APSuppliers_GetInvoiceSummary");
            dal.AddParameter(cmd, "APSupplierID", DbType.Int32, ParameterDirection.Input, objSuppliersInfo.APSupplierID);
            dal.AddParameter(cmd, "DateFrom", DbType.DateTime, ParameterDirection.Input, from);
            dal.AddParameter(cmd, "DateTo", DbType.DateTime, ParameterDirection.Input, to);
            dal.AddParameter(cmd, "TotalPurchaseCost", DbType.Double, ParameterDirection.Output, objSuppliersInfo.TotalPurchaseCost);
            dal.AddParameter(cmd, "TotalPurchaseQty", DbType.Double, ParameterDirection.Output, objSuppliersInfo.TotalPurchaseQty);
            dal.AddParameter(cmd, "TotalReturnAmount", DbType.Double, ParameterDirection.Output, objSuppliersInfo.TotalReturnAmount);
            dal.AddParameter(cmd, "TotalReturnQty", DbType.Double, ParameterDirection.Output, objSuppliersInfo.TotalReturnQty);
            dal.GetDataSet(cmd);
            objSuppliersInfo.TotalPurchaseCost = Convert.ToDecimal(dal.GetParameterValue(cmd, "TotalPurchaseCost"));
            objSuppliersInfo.TotalPurchaseQty = Convert.ToDecimal(dal.GetParameterValue(cmd, "TotalPurchaseQty"));
            objSuppliersInfo.TotalReturnAmount = Convert.ToDecimal(dal.GetParameterValue(cmd, "TotalReturnAmount"));
            objSuppliersInfo.TotalReturnQty = Convert.ToDecimal(dal.GetParameterValue(cmd, "TotalReturnQty"));
        }

        /// <summary>
        /// Get total owing to a supplier
        /// </summary>
        /// <param name="supplierID">Supplier id</param>
        /// <returns>Total owing</returns>
        public double GetTotalOwing(int supplierID)
        {
            DataSet ds = dal.GetDataSet("APSuppliers_GetTotalOwing", supplierID);
            double owing = 0;
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0][0] != DBNull.Value)
                {
                    owing = Convert.ToDouble(ds.Tables[0].Rows[0][0]);
                }
            }
            return owing;
        }

        /// <summary>
        /// Get owing details by currencies of a supplier
        /// </summary>
        /// <param name="supplierID">Supplier id</param>
        /// <returns>List of owing details</returns>
        public List<OwingDetailsInfo> GetOwingDetailsByCurrency(int supplierID)
        {
            DataSet ds = dal.GetDataSet("APSuppliers_GetOwingDetailsByCurrency", supplierID);
            List<OwingDetailsInfo> owingDetails = new List<OwingDetailsInfo>();
            if (ds.Tables.Count > 0)
            {
                OwingDetailsController objOwingDetailsController = new OwingDetailsController();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    OwingDetailsInfo objOwingDetailsInfo = (OwingDetailsInfo)objOwingDetailsController.GetObjectFromDataRow(row);
                    owingDetails.Add(objOwingDetailsInfo);
                }
            }
            return owingDetails;
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<APSuppliersInfo> supplierList = new List<APSuppliersInfo>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    APSuppliersInfo objSuppliersInfo = (APSuppliersInfo)GetObjectFromDataRow(row);
                    supplierList.Add(objSuppliersInfo);
                }
            }
            ds.Dispose();
            return supplierList;
        }

        //[NUThao] [Improve Speed] [2014-09-09]
        public DataSet GetAllSuppliersForLookupControl()
        {
            return dal.GetDataSet("APSuppliers_GetAllSuppliersForLookupControl");
        }
        //[NUThao] [Improve Speed] [2014-09-09]

        public List<APSuppliersInfo> GetSupplierBySupplierNoRef(string supplierRef)
        {
            DataSet ds = dal.GetDataSet("APSuppliers_GetSupplierBySupplierNoRef", supplierRef);
            return (List<APSuppliersInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}