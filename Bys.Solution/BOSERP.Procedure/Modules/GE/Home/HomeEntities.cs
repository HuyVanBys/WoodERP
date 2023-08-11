using BOSCommon.Constants;
using BOSLib;
using System;
using System.Reflection;
using System.Transactions;

namespace BOSERP.Modules.Home
{
    public class HomeEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the sale order list
        /// </summary>
        public BOSList<ARSaleOrdersInfo> SaleOrderList { get; set; }

        /// <summary>
        /// Gets or sets the purchase order list
        /// </summary>
        public BOSList<APPurchaseOrdersInfo> PurchaseOrderList { get; set; }

        /// <summary>
        /// Gets or sets the history detail list
        /// </summary>
        public BOSList<GEHistoryDetailsInfo> HistoryDetailList { get; set; }

        /// <summary>
        /// Gets or sets the history detail of sale order list 
        /// </summary>
        public BOSList<GEHistoryDetailsInfo> HistoryDetailOfSaleOrderList { get; set; }

        /// <summary>
        /// Gets or sets the history detail of prouct list
        /// </summary>
        public BOSList<GEHistoryDetailsInfo> HistoryDetailsOfProductsList { get; set; }

        public BOSList<ICReceiptItemsInfo> GoodsReceiptList;

        public BOSList<ICProductsInfo> ProductList { get; set; }

        public BOSList<ARDeliveryPlanTruckPointsInfo> DeliveryPlanTruckPointList { get; set; }

        public BOSList<ARSaleOrdersInfo> SaleOrdersFilterList { get; set; }

        public BOSList<APPurchaseOrdersInfo> PurchaseOrderFilterList { get; set; }

        public BOSList<APProposalsInfo> PurchaseProposalFilterList { get; set; }

        public BOSList<ARRemindsInfo> RemindsList { get; set; }

        public BOSList<MMBatchProductsInfo> BatchProductsList { get; set; }

        public BOSList<MMProposalsInfo> BatchProposalList { get; set; }

        public BOSList<HREmployeesInfo> EmployeesList { get; set; }

        public BOSList<ICShipmentsInfo> ShipmentSaleOrderList { get; set; }

        public BOSList<ICTransferProposalsInfo> TransferProposalList { get; set; }

        public BOSList<MMAllocationPlansInfo> AllocationPlanList { get; set; }

        public BOSList<HRRequestLeaveDaysInfo> LeaveApplicationsList { get; set; }
        public BOSList<GEPaymentProposalsInfo> PaymentProposalsList { get; set; }
        public BOSList<HREmployeesInfo> EmployeeMissingRecordList { get; set; }
        public BOSList<ICShipmentsInfo> ShipmentUnExecutedInvoiceList { get; set; }
        #endregion

        #region Constructor
        public HomeEntities()
            : base()
        {
            SaleOrderList = new BOSList<ARSaleOrdersInfo>();
            PurchaseOrderList = new BOSList<APPurchaseOrdersInfo>();
            HistoryDetailList = new BOSList<GEHistoryDetailsInfo>();
            HistoryDetailOfSaleOrderList = new BOSList<GEHistoryDetailsInfo>();
            HistoryDetailsOfProductsList = new BOSList<GEHistoryDetailsInfo>();
            GoodsReceiptList = new BOSList<ICReceiptItemsInfo>();
            ProductList = new BOSList<ICProductsInfo>();
            DeliveryPlanTruckPointList = new BOSList<ARDeliveryPlanTruckPointsInfo>();
            SaleOrdersFilterList = new BOSList<ARSaleOrdersInfo>();
            PurchaseOrderFilterList = new BOSList<APPurchaseOrdersInfo>();
            PurchaseProposalFilterList = new BOSList<APProposalsInfo>();
            RemindsList = new BOSList<ARRemindsInfo>();
            BatchProductsList = new BOSList<MMBatchProductsInfo>();
            BatchProposalList = new BOSList<MMProposalsInfo>();
            EmployeesList = new BOSList<HREmployeesInfo>();
            ShipmentSaleOrderList = new BOSList<ICShipmentsInfo>();
            TransferProposalList = new BOSList<ICTransferProposalsInfo>();
            AllocationPlanList = new BOSList<MMAllocationPlansInfo>();
            LeaveApplicationsList = new BOSList<HRRequestLeaveDaysInfo>();
            PaymentProposalsList = new BOSList<GEPaymentProposalsInfo>();
            EmployeeMissingRecordList = new BOSList<HREmployeesInfo>();
            ShipmentUnExecutedInvoiceList = new BOSList<ICShipmentsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARSaleOrdersTableName, new ARSaleOrdersInfo());
            ModuleObjects.Add(TableName.ARCustomersTableName, new ARCustomersInfo());
            ModuleObjects.Add(TableName.APPurchaseOrdersTableName, new APPurchaseOrdersInfo());
            ModuleObjects.Add(TableName.ICProductsTableName, new ICProductsInfo());
            ModuleObjects.Add(TableName.ICReceiptItemsTableName, new ICReceiptItemsInfo());
            //ModuleObjects.Add(TableName.ICProductsTableName, new ICProductsInfo());
            ModuleObjects.Add(TableName.ARDeliveryPlanTruckPointsTableName, new ARDeliveryPlanTruckPointsInfo());
            ModuleObjects.Add(TableName.MMBatchProductsTableName, new MMBatchProductsInfo());
            ModuleObjects.Add(TableName.MMProposalsTableName, new MMProposalsInfo());
            ModuleObjects.Add(TableName.HREmployeesTableName, new HREmployeesInfo());
            ModuleObjects.Add(TableName.HRRequestLeaveDaysTableName, new HRRequestLeaveDaysInfo());
        }

        public override void InitModuleObjectList()
        {
            SaleOrderList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ARSaleOrdersTableName,
                                           BOSList<ARSaleOrdersInfo>.cstRelationNone);
            PurchaseOrderList.InitBOSList(this,
                                           String.Empty,
                                           TableName.APPurchaseOrdersTableName,
                                           BOSList<APPurchaseOrdersInfo>.cstRelationNone);

            HistoryDetailList.InitBOSList(this,
                                         TableName.GEObjectHistoryTableName,
                                         TableName.GEHistoryDetailsTableName,
                                         BOSList<GEHistoryDetailsInfo>.cstRelationForeign);
            HistoryDetailOfSaleOrderList.InitBOSList(this,
                                                     TableName.GEObjectHistoryTableName,
                                                     TableName.GEHistoryDetailsTableName,
                                                     BOSList<GEHistoryDetailsInfo>.cstRelationForeign);
            HistoryDetailsOfProductsList.InitBOSList(this,
                                                     TableName.GEObjectHistoryTableName,
                                                     TableName.GEHistoryDetailsTableName,
                                                     BOSList<GEHistoryDetailsInfo>.cstRelationForeign);
            GoodsReceiptList.InitBOSList(this,
                                        String.Empty,
                                        TableName.ICReceiptItemsTableName,
                                        BOSList<ICReceiptItemsInfo>.cstRelationNone);
            ProductList.InitBOSList(this,
                                       String.Empty,
                                       TableName.ICProductsTableName,
                                       BOSList<ICProductsInfo>.cstRelationNone);
            DeliveryPlanTruckPointList.InitBOSList(this,
                                        String.Empty,
                                        TableName.ARDeliveryPlanTruckPointsTableName,
                                        BOSList<ARDeliveryPlanTruckPointsInfo>.cstRelationNone);
            SaleOrdersFilterList.InitBOSList(this,
                                          String.Empty,
                                          TableName.ARSaleOrdersTableName,
                                          BOSList<ARSaleOrdersInfo>.cstRelationNone);
            PurchaseOrderFilterList.InitBOSList(this,
                                          String.Empty,
                                          TableName.APPurchaseOrdersTableName,
                                          BOSList<APPurchaseOrdersInfo>.cstRelationNone);
            PurchaseProposalFilterList.InitBOSList(this,
                                          String.Empty,
                                          TableName.APProposalsTableName,
                                          BOSList<APProposalsInfo>.cstRelationNone);
            RemindsList.InitBOSList(this,
                                    String.Empty,
                                    TableName.ARRemindsTableName,
                                    BOSList<ARRemindsInfo>.cstRelationNone);

            BatchProductsList.InitBOSList(this,
                                    String.Empty,
                                    TableName.MMBatchProductsTableName,
                                    BOSList<MMBatchProductsInfo>.cstRelationNone);
            BatchProposalList.InitBOSList(this,
                                    String.Empty,
                                    TableName.MMProposalsTableName,
                                    BOSList<MMProposalsInfo>.cstRelationNone);
            EmployeesList.InitBOSList(this,
                                    String.Empty,
                                    TableName.HREmployeesTableName,
                                    BOSList<HREmployeesInfo>.cstRelationNone);
            ShipmentSaleOrderList.InitBOSList(this,
                                    String.Empty,
                                    TableName.ICShipmentsTableName,
                                    BOSList<ICShipmentsInfo>.cstRelationNone);
            TransferProposalList.InitBOSList(this,
                                    String.Empty,
                                    TableName.ICTransferProposalsTableName,
                                    BOSList<ICShipmentsInfo>.cstRelationNone);
            AllocationPlanList.InitBOSList(this,
                                    String.Empty,
                                    TableName.MMAllocationPlansTableName,
                                    BOSList<ICShipmentsInfo>.cstRelationNone);
            LeaveApplicationsList.InitBOSList(this,
                                   String.Empty,
                                   TableName.HRRequestLeaveDaysTableName,
                                   BOSList<HRRequestLeaveDaysInfo>.cstRelationNone);
            PaymentProposalsList.InitBOSList(this,
                                   String.Empty,
                                   "GEPaymentProposals",
                                   BOSList<GEPaymentProposalsInfo>.cstRelationNone);
            EmployeeMissingRecordList.InitBOSList(this,
                                           String.Empty,
                                           TableName.HREmployeesTableName,
                                           BOSList<HREmployeesInfo>.cstRelationNone);
            ShipmentUnExecutedInvoiceList.InitBOSList(this,
                                                string.Empty,
                                                "ICShipments",
                                                BOSList<ICShipmentsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            SaleOrderList.InitBOSListGridControl();
            PurchaseOrderList.InitBOSListGridControl();
            ShipmentSaleOrderList.InitBOSListGridControl();
            HistoryDetailList.InitBOSListGridControl();
            HistoryDetailOfSaleOrderList.InitBOSListGridControl(HomeModule.ChangeInvoiceGridControlName);
            HistoryDetailsOfProductsList.InitBOSListGridControl(HomeModule.ChangeProductsGridControlName);
            GoodsReceiptList.InitBOSListGridControl(HomeModule.ICReceiptItemsGridControlName);
            ProductList.InitBOSListGridControl(HomeModule.ICProductsGridControlName);
            DeliveryPlanTruckPointList.InitBOSListGridControl(HomeModule.ARDeliveryPlanTruckPointsGridControlName);
            SaleOrdersFilterList.InitBOSListGridControl(HomeModule.SaleOrdersFilterListGridControlName);
            PurchaseOrderFilterList.InitBOSListGridControl(HomeModule.PurchaseOrderFilterListGridControlName);
            PurchaseProposalFilterList.InitBOSListGridControl(HomeModule.PurchaseProposalFilterListGridControlName);
            RemindsList.InitBOSListGridControl(HomeModule.RemindsGridControlName);
            BatchProductsList.InitBOSListGridControl(HomeModule.RemindsGridControlName);
            BatchProposalList.InitBOSListGridControl(HomeModule.BatchProposalGridControlName);
            EmployeesList.InitBOSListGridControl(HomeModule.EmployeesGridControlName);
            TransferProposalList.InitBOSListGridControl(HomeModule.TransferProposalGridControlName);
            AllocationPlanList.InitBOSListGridControl(HomeModule.AllocationPlansGridControlName);
            LeaveApplicationsList.InitBOSListGridControl();
            PaymentProposalsList.InitBOSListGridControl(HomeModule.PaymentProposalsGridControlName);
            EmployeeMissingRecordList.InitBOSListGridControl(HomeModule.EmployeeMissingRecordsGridControlName);
            ShipmentUnExecutedInvoiceList.InitBOSListGridControl(HomeModule.ShipmenttUnExecutedInvoiceControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                SaleOrderList.SetDefaultListAndRefreshGridControl();
                HistoryDetailList.SetDefaultListAndRefreshGridControl();
                PurchaseOrderList.SetDefaultListAndRefreshGridControl();
                HistoryDetailOfSaleOrderList.SetDefaultListAndRefreshGridControl();
                HistoryDetailsOfProductsList.SetDefaultListAndRefreshGridControl();
                GoodsReceiptList.SetDefaultListAndRefreshGridControl();
                ProductList.SetDefaultListAndRefreshGridControl();
                DeliveryPlanTruckPointList.SetDefaultListAndRefreshGridControl();
                SaleOrdersFilterList.SetDefaultListAndRefreshGridControl();
                PurchaseOrderFilterList.SetDefaultListAndRefreshGridControl();
                PurchaseProposalFilterList.SetDefaultListAndRefreshGridControl();
                RemindsList.SetDefaultListAndRefreshGridControl();
                BatchProductsList.SetDefaultListAndRefreshGridControl();
                BatchProposalList.SetDefaultListAndRefreshGridControl();
                EmployeesList.SetDefaultListAndRefreshGridControl();
                ShipmentSaleOrderList.SetDefaultListAndRefreshGridControl();
                LeaveApplicationsList.SetDefaultListAndRefreshGridControl();
                PaymentProposalsList.SetDefaultListAndRefreshGridControl();
                EmployeeMissingRecordList.SetDefaultListAndRefreshGridControl();
                ShipmentUnExecutedInvoiceList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion

        /// <summary>
        /// Rollback changes to customer by history detail
        /// </summary>
        /// <param name="objHistoryDetailsInfo">Info of history detail</param>        
        public void RollbackCustomerByHistoryDetail(GEHistoryDetailsInfo objHistoryDetailsInfo)
        {
            ARCustomersController objCustomersController = new ARCustomersController();
            ARCustomersInfo objCustomersInfo = objCustomersController.GetCustomerByHistoryDetailID(objHistoryDetailsInfo.GEHistoryDetailID);
            if (objCustomersInfo != null)
            {
                BOSDbUtil dbUtil = new BOSDbUtil();
                Type customersInfoType = objCustomersInfo.GetType();
                foreach (PropertyInfo proInfo in customersInfoType.GetProperties())
                {
                    if (proInfo.Name.Equals(objHistoryDetailsInfo.GEHistoryDetailColumnName))
                    {
                        try
                        {
                            dbUtil.SetPropertyValue(objCustomersInfo, proInfo.Name, Convert.ChangeType(objHistoryDetailsInfo.GEHistoryDetailOldValue, proInfo.PropertyType));
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
            }

            GEHistoryDetailsController objHistoryDetailsController = new GEHistoryDetailsController();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    //Delete history details
                    objHistoryDetailsController.DeleteObject(objHistoryDetailsInfo.GEHistoryDetailID);
                    //Rollback customer
                    if (objCustomersInfo != null)
                    {
                        objCustomersController.UpdateObject(objCustomersInfo);
                    }
                    scope.Complete();
                }
                catch (Exception)
                {
                    scope.Dispose();
                }
            }
        }

        /// <summary>
        /// Rollback changes to product by history detail
        /// </summary>
        /// <param name="objHistoryDetailsInfo">Info of history detail</param>
        public void RollbackProductByHistoryDetail(GEHistoryDetailsInfo objHistoryDetailsInfo)
        {
            ICProductsController objProductsController = new ICProductsController();
            ICProductsInfo objProductsInfo = objProductsController.GetProductByHistoryDetailID(objHistoryDetailsInfo.GEHistoryDetailID);
            if (objProductsInfo != null)
            {
                Type productsInfoType = objProductsInfo.GetType();
                foreach (PropertyInfo proInfo in productsInfoType.GetProperties())
                {
                    if (proInfo.Name.Equals(objHistoryDetailsInfo.GEHistoryDetailColumnName))
                    {
                        BOSDbUtil dbUtil = new BOSDbUtil();
                        try
                        {
                            dbUtil.SetPropertyValue(objProductsInfo, proInfo.Name, Convert.ChangeType(objHistoryDetailsInfo.GEHistoryDetailOldValue, proInfo.PropertyType));
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
            }

            GEHistoryDetailsController objHistoryDetailsController = new GEHistoryDetailsController();
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    //Delete history details
                    objHistoryDetailsController.DeleteObject(objHistoryDetailsInfo.GEHistoryDetailID);
                    //Rollback product
                    if (objProductsInfo != null)
                    {
                        objProductsController.UpdateObject(objProductsInfo);
                    }
                    scope.Complete();
                }
                catch (Exception)
                {
                    scope.Dispose();
                }
            }
        }

        /// <summary>
        /// Delete given history details
        /// </summary>
        /// <param name="objHistoryDetailsInfo">Given history details</param>
        public void DeleteHistoryDetails(GEHistoryDetailsInfo objHistoryDetailsInfo)
        {
            GEHistoryDetailsController objHistoryDetailsController = new GEHistoryDetailsController();
            objHistoryDetailsController.DeleteObject(objHistoryDetailsInfo.GEHistoryDetailID);
        }
    }
}
