using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region APPurchaseOrders
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APPurchaseOrdersController
    //Created Date:Sunday, November 14, 2010
    //-----------------------------------------------------------

    public class APPurchaseOrdersController : BaseBusinessController
    {
        public APPurchaseOrdersController()
        {
            dal = new DALBaseProvider("APPurchaseOrders", typeof(APPurchaseOrdersInfo));
        }
        public DataSet GetAllPurchaseOrderForLookupControl()
        {
            DataSet ds = dal.GetDataSet("APPurchaseOrders_GetAllAPPurchaseOrdersForLookupControl");
            return ds;
        }
        /// <summary>
        /// Get purchase order list based on some criteria
        /// </summary>
        /// <param name="supplierID"></param>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <returns></returns>
        public DataSet GetPurchaseOrderList(string purchaseOrderNo,
                                            int? supplierID,
                                            int? employeeID,
                                            int? branchID,
                                            int? locationID,
                                            DateTime? dateFrom,
                                            DateTime? dateTo)
        {
            DataSet ds = dal.GetDataSet("APPurchaseOrders_GetPurchaseOrderList", purchaseOrderNo, supplierID, employeeID, branchID, locationID, dateFrom, dateTo);
            return ds;
        }

        /// <summary>
        /// Get the list of purchase orders based on some criteria
        /// </summary>
        /// <param name="supplierID">Supplier ID</param>
        /// <param name="dateFrom">Date which the result is searched from</param>
        /// <param name="dateTo">Date which the result is searched to</param>
        /// <returns>List of purchase orders</returns>
        public DataSet GetPurchaseOrderList(int? supplierID, DateTime? dateFrom, DateTime? dateTo)
        {
            return GetPurchaseOrderList(null, supplierID, null, null, null, dateFrom, dateTo);
        }

        /// <summary>
        /// Get purchase order by delivery due days with out status is receipted
        /// </summary>
        /// <param name="deliveryDueDays">Delivery due day</param>
        /// <returns>Data of purchase order</returns>
        public DataSet GetPurchaseOrderByDeliveryDueDays(int deliveryDueDays)
        {
            DataSet ds = dal.GetDataSet("APPurchaseOrders_GetPurchaseOrderByDeliveryDueDays", deliveryDueDays);
            return ds;
        }

        /// <summary>
        /// Get purchase order item by purchase order id
        /// </summary>
        /// <param name="purchaseOrderID">Purchase order id</param>
        /// <returns>Data of purchase order</returns>
        public DataSet GetPurchaseOrderItemByPurchaseOrderID(int purchaseOrderID)
        {
            DataSet ds = dal.GetDataSet("Report_GetPurchaseOrderItemByPurchaseOrderID", purchaseOrderID);
            return ds;
        }

        /// <summary>
        /// Get the purchase order list for invoicing
        /// </summary>
        /// <returns>List of purchase orders</returns>
        public List<APPurchaseOrdersInfo> GetPurchaseOrdersForInvoicing()
        {
            DataSet ds = dal.GetDataSet("APPurchaseOrders_GetPurchaseOrdersForInvoicing");
            List<APPurchaseOrdersInfo> purchaseOrderList = new List<APPurchaseOrdersInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)GetObjectFromDataRow(row);
                    purchaseOrderList.Add(objPurchaseOrdersInfo);
                }
            }
            return purchaseOrderList;
        }

        /// <summary>
        /// Get the purchase order list for invoicing by user's Permission
        /// </summary>
        /// <returns>List of purchase orders</returns>
        public List<APPurchaseOrdersInfo> GetPurchaseOrdersForInvoicingByUserPermission(int userID, string moduleName, string dataViewPermissionType)
        {
            DataSet ds = dal.GetDataSet("APPurchaseOrders_GetPurchaseOrdersForInvoicingByUserPermission", userID, moduleName, dataViewPermissionType);
            List<APPurchaseOrdersInfo> purchaseOrderList = new List<APPurchaseOrdersInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)GetObjectFromDataRow(row);
                    purchaseOrderList.Add(objPurchaseOrdersInfo);
                }
            }
            return purchaseOrderList;
        }


        /// <summary>
        /// Get purchase order by search
        /// </summary>
        /// <param name="purchaseOrderNo">Purchase order no</param>
        /// <param name="supplierID">Supplier id</param>
        /// <param name="employeeID">Employee id</param>
        /// <param name="branchID">Branch ID</param>
        /// <param name="locationID">Location id</param>
        /// <param name="dateFromPurchase">Date from purchase</param>
        /// <param name="dateToPurchase">Date to purchase</param>
        /// <param name="dateFromDelivery">Date from delivery</param>
        /// <param name="dateToDelivery">Date to delivery</param>
        /// <returns>List of purchase order </returns>
        public DataSet GetPurchaseOrdersBySearch(string purchaseOrderNo, int? supplierID, int? employeeID, int? branchID,
                                                int? locationID, DateTime? dateFromPurchase, DateTime? dateToPurchase,
                                                DateTime? dateFromDelivery, DateTime? dateToDelivery)
        {
            DataSet ds = dal.GetDataSet("APPurchaseOrders_GetPurchaseOrderListBySearch", purchaseOrderNo, supplierID,
                                        employeeID, branchID, locationID, dateFromPurchase, dateToPurchase,
                                        dateFromDelivery, dateToDelivery);
            return ds;
        }

        public DataSet GetPurchaseOrderListByListOfBranchID(string purchaseOrderNo,
                                           int? supplierID,
                                           int? employeeID,
                                           int? branchID,
                                           int? locationID,
                                           DateTime? dateFrom,
                                           DateTime? dateTo, List<BRBranchsInfo> branchList)
        {
            DataSet rtn = new DataSet();
            foreach (BRBranchsInfo ojbBranchsInfo in branchList)
            {
                DataSet ds = GetPurchaseOrderList(purchaseOrderNo, supplierID, employeeID, ojbBranchsInfo.BRBranchID, locationID, dateFrom, dateTo);
                rtn.Merge(ds);
            }

            return rtn;
        }
        //public int APPurchaseOrderID_ICReceipts_APInvoiceIns(int purchaseOrderID);
        public double GetAPPurchaseOrderID_ForICReceipts_APInvoiceIns(int purchaseOrderID)
        {
            Object obj = dal.GetSingleValue("APPurchaseOrderID_ICReceipts_APInvoiceIns", purchaseOrderID);
            double Debt = 0;
            if (obj != null)
                Double.TryParse(obj.ToString(), out Debt);

            return Debt;
        }

        public List<APPurchaseOrdersInfo> GetPurchaseOrdersForFeePaymentByUserPermission(int userID, string moduleName, string dataViewPermissionType)
        {
            DataSet ds = dal.GetDataSet("APPurchaseOrders_GetPurchaseOrdersForFeePaymentByUserPermission", userID, moduleName, dataViewPermissionType);
            return (List<APPurchaseOrdersInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<APPurchaseOrdersInfo> products = new List<APPurchaseOrdersInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    APPurchaseOrdersInfo objProductsInfo = (APPurchaseOrdersInfo)GetObjectFromDataRow(row);
                    products.Add(objProductsInfo);
                }
            }
            ds.Dispose();
            return products;
        }
        public DataSet GetPurchaseOrderListByTypeInOutSourcing(int supplierID, DateTime fromDate, DateTime toDate, string purchaseOrderType)
        {
            DataSet ds = dal.GetDataSet("APPurchaseOrders_GetPurchaseOrderListByTypeInOutSourcing", supplierID, fromDate, toDate, purchaseOrderType);
            return ds;
        }
        public DataSet GetPurchaseOrderListByTypeNotInOutSourcing(int supplierID, DateTime fromDate, DateTime toDate, string purchaseOrderType)
        {
            DataSet ds = dal.GetDataSet("APPurchaseOrders_GetPurchaseOrderListByTypeNotInOutSourcing", supplierID, fromDate, toDate, purchaseOrderType);
            return ds;
        }

        public List<APPurchaseOrdersInfo> GetPurchaseOrdersForInvoiceInID(int purchaseOrderID)
        {
            DataSet ds = dal.GetDataSet("APPurchaseOrders_GetPurchaseOrdersForInvoiceID", purchaseOrderID);
            List<APPurchaseOrdersInfo> purchaseOrderList = new List<APPurchaseOrdersInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)GetObjectFromDataRow(row);
                    purchaseOrderList.Add(objPurchaseOrdersInfo);
                }
            }
            return purchaseOrderList;
        }
        public List<APPurchaseOrdersInfo> GetPurchaseOrdersForProposalPayment(int paymentProposalID)
        {
            DataSet ds = dal.GetDataSet("APPurchaseOrders_GetPurchaseOrdersForProposalPayment", paymentProposalID);
            List<APPurchaseOrdersInfo> purchaseOrderList = new List<APPurchaseOrdersInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)GetObjectFromDataRow(row);
                    purchaseOrderList.Add(objPurchaseOrdersInfo);
                }
            }
            return purchaseOrderList;
        }

        public DataSet GetDataSetPurchaseOrderListByBranchID(string purchaseOrderNo,
                                            int? acObjectID,
                                            string acObjectType,
                                            int? employeeID,
                                            int? branchID,
                                            int? locationID,
                                            DateTime? dateFrom,
                                            DateTime? dateTo)
        {
            DataSet ds = dal.GetDataSet("APPurchaseOrders_GetDataSetPurchaseOrderList", purchaseOrderNo, acObjectID, acObjectType, employeeID, branchID, locationID, dateFrom, dateTo);
            return ds;
        }

        public DataSet GetDataSetPurchaseOrderListByListBranch(string purchaseOrderNo,
                                           int? acObjectID,
                                           string acObjectType,
                                           int? employeeID,
                                           int? branchID,
                                           int? locationID,
                                           DateTime? dateFrom,
                                           DateTime? dateTo, List<BRBranchsInfo> branchList)
        {
            DataSet rtn = new DataSet();
            foreach (BRBranchsInfo ojbBranchsInfo in branchList)
            {
                DataSet ds = GetDataSetPurchaseOrderListByBranchID(purchaseOrderNo, acObjectID, acObjectType, employeeID, ojbBranchsInfo.BRBranchID, locationID, dateFrom, dateTo);
                rtn.Merge(ds);
            }

            return rtn;
        }

        public List<APPurchaseOrdersInfo> GetAllPurchaseOrdersForHome(DateTime? purchaseOrderFromDate, DateTime? purchaseOrderToDate, string purchaseOrderStatus)
        {
            DataSet ds = dal.GetDataSet("APPurchaseOrders_GetAllPurchaseOrdersForHome", purchaseOrderFromDate, purchaseOrderToDate, purchaseOrderStatus);
            return (List<APPurchaseOrdersInfo>)GetListFromDataSet(ds);
        }

        public List<APPurchaseOrdersInfo> GetPurchaseOrdersForTransferOutsourcing()
        {
            DataSet ds = dal.GetDataSet("APPurchaseOrders_GetPurchaseOrdersForTransferOutsourcing");
            return (List<APPurchaseOrdersInfo>)GetListFromDataSet(ds);
        }

        public List<APPurchaseOrdersInfo> GetPurchaseOrderByBatchProductID(int? batchProductID)
        {
            DataSet ds = dal.GetDataSet("APPurchaseOrders_GetPurchaseOrderByBatchProductID", batchProductID);
            return (List<APPurchaseOrdersInfo>)GetListFromDataSet(ds);
        }

        public List<APPurchaseOrdersInfo> GetPurchaseOrderOutSourcingByBatchProductID(int batchProductID)
        {
            DataSet ds = dal.GetDataSet("APPurchaseOrders_GetPurchaseOrderOutSourcingByBatchProductID", batchProductID);
            return (List<APPurchaseOrdersInfo>)GetListFromDataSet(ds);
        }

        public APPurchaseOrdersInfo GetDataSourceForRPPurchaseOrderTV(int purchaseOrderID)
        {
            return (APPurchaseOrdersInfo)GetDataObject("APPurchaseOrders_GetDataSourceForRPPurchaseOrderTV", purchaseOrderID);
        }

        public void UpdateReferencePurchaseOrdersAndItemByInvoiceInID(int invoiceID)
        {
            dal.ExecuteStoredProcedure("APPurchaseOrders_UpdateReferencePurchaseOrdersAndItemByInvoiceInID", invoiceID);
        }

        public List<APPurchaseOrdersInfo> GetPurchaseOrderByListID(string listID)
        {
            DataSet ds = dal.GetDataSet("APPurchaseOrders_GetPurchaseOrderByListID", listID);
            return (List<APPurchaseOrdersInfo>)GetListFromDataSet(ds);
        }

        public void UpdatePurchaseOrderStatus(string listID, string userName)
        {
            dal.ExecuteStoredProcedure("APPurchaseOrders_UpdatePurchaseOrderStatus", listID, userName);
        }

        public void UpdateCanceledPurchaseOrderStatus(string listID, string userName)
        {
            dal.ExecuteStoredProcedure("APPurchaseOrders_UpdateCanceledPurchaseOrderStatus", listID, userName);
        }

        public void DeleteAllItemByPurchaseOrderID(int purchaseOrderID)
        {
            dal.ExecuteStoredProcedure("APPurchaseOrders_DeleteAllItemByPurchaseOrderID", purchaseOrderID);
        }

        public void RollbackReferencePurchaseOrdersAndItemByInvoiceInID(int invoiceID)
        {
            dal.ExecuteStoredProcedure("APPurchaseOrders_RollbackReferencePurchaseOrdersAndItemByInvoiceInID", invoiceID);
        }

        public List<APPurchaseOrdersInfo> GetListPurchaseOrderByCancelPurchaseOrderID(int cancelPurchaseOrderID)
        {
            DataSet ds = dal.GetDataSet("APPurchaseOrders_GetListPurchaseOrderByCancelPurchaseOrderID", cancelPurchaseOrderID);
            return (List<APPurchaseOrdersInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}