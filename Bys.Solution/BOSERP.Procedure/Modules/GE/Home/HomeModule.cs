using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Home
{
    public class HomeModule : BaseModuleERP
    {
        #region Customer
        public const string DateFromHistoryDetailsDateEditName = "fld_dteFrom";
        public const string DateToHistoryDetailsDateEditName = "fld_dteTo";
        public const string CheckAllHistoryDetailsCheckEditName = "fld_chkCheckAll";
        #endregion

        #region Product
        public const string DateToHistoryDetailsOfProductDateEditName = "fld_dteProductTo";
        public const string DateFromHistoryDetailsOfProductDateEditName = "fld_dteProductFrom";
        public const string ProductLookupEditName = "fld_lkeICProductID";
        public const string CheckAllHistoryDetailsOfProductCheckEditName = "fld_chkCheckAllProduct";
        public const string ChangeProductsGridControlName = "fld_dgcChangeProducts";
        #endregion

        #region Sale order
        public const string DateFromHistoryDetailsOfSaleOrderDateEditName = "fld_dteFromDateEdit";
        public const string DateToHistoryDetailsOfSaleOrderDateEditName = "fld_dteToDateEdit";
        public const string CheckAllHistoryDetailsOfSaleOrderCheckEditName = "fld_chkCheckAllSaleOrder";
        public const string ChangeInvoiceGridControlName = "fld_dgcChangeInvoices";
        #endregion

        #region Proposal
        public const string ProposalGridControlName = "fld_dgcProposals";

        public const string ICReceiptItemsGridControlName = "fld_dgcICReceiptItems";
        public const string ICProductsGridControlName = "fld_dgcICProducts";
        public const string ARDeliveryPlanTruckPointsGridControlName = "fld_dgcARDeliveryPlanTruckPointsGridControl";
        #endregion
        #region Production
        public const string ProductLookupControlName = "fld_lkeFK_ICProductID";
        public const string CustomerLookupControlName = "fld_lkeFK_ARCustomerID";
        public const string ProductSysNoTextControlName = "fld_txbProductSysNo";
        public const string BatchProductLookupControlName = "fld_lkeFK_MMBatchProductID";
        #endregion

        #region Sale order Filter
        public const string SaleOrdersFilterListGridControlName = "fld_dgcSaleOrdersFilterGridControl";
        public const string SaleOrdersFilterFromDateEditName = "fld_dteSaleOrderFromDate";
        public const string SaleOrdersFilterToDateEditName = "fld_dteSaleOrderToDate";
        public const string SaleOrdersFilterStatus = "fld_lkeARSaleOrderStatus";
        public const string SaleOrderIsReceiveBill = "fld_ckeSaleOrderIsReceiveBill";

        #endregion

        #region PurchaseOrder Filter
        public const string PurchaseOrderFilterListGridControlName = "fld_dgcPurchaseOrderFilterGridControl";
        public const string PurchaseOrderFilterFromDateEditName = "fld_dtePurchaseOrdersFromDate";
        public const string PurchaseOrderFilterToDateEditName = "fld_dtePurchaseOrderToDate";
        public const string PurchaseOrderFilterStatus = "fld_lkeAPPurchaseOrderStatus";
        #endregion

        #region Purchase Proposal Filter
        public const string PurchaseProposalFilterListGridControlName = "fld_dgcAPProposalsFilterGridControl";
        public const string PurchaseProposalFilterFromDateEditName = "fld_dteAPProposalFromDate";
        public const string PurchaseProposalFilterToDateEditName = "fld_dteAPProposalToDate";
        public const string PurchaseProposalFilterStatus = "fld_lkeAPProposalStatus";
        #endregion

        #region Reminds
        public const string RemindsGridControlName = "fld_dgcARRemindsGridControl";
        public const string RemindFromDateEditName = "fld_dteARRemindFromDate";
        public const string RemindToDateEditName = "fld_dteARRemindToDate";
        #endregion

        #region BatchProduct
        public const string BatchProductsGridControlName = "fld_dgcMMBatchProductsGridControl";
        public const string BatchProductsFromDateEditName = "fld_dteBatchProductFromDate";
        public const string BatchProductsToDateEditName = "fld_dteBatchProductToDate";
        #endregion

        #region BatchProposal
        public const string BatchProposalGridControlName = "fld_dgcBatchProposalsGridControl";
        public const string BatchProposalFromDateEditName = "fld_dteBatchProposalFromDate";
        public const string BatchProposalToDateEditName = "fld_dteBatchProposalToDate";
        #endregion

        #region Employee
        public const string EmployeesGridControlName = "fld_dgcHREmployeesGridControl";
        public const string EmployeeMissingRecordsGridControlName = "fld_dgcHREmployeeMissingRecordsGridControl";
        #endregion

        #region TransferProposal
        public const string TransferProposalGridControlName = "fld_dgcICTransferProposalsGridControl";
        public const string TransferProposalFromDateEditName = "fld_dteTransferProposalFromDate";
        public const string TransferProposalToDateEditName = "fld_dteTransferProposalToDate";

        #endregion
        public const string AllocationPlansGridControlName = "fld_dgcMMAllocationPlansGridControl";
        public const string AllocationPlanFromDateEditName = "fld_dteAllocationPlansFromDate";
        public const string AllocationPlansToDateEditName = "fld_dteAllocationPlansToDate";

        #region LeaveApplication
        public const string LeaveApplicationGridControlName = "fld_dgcRequestLeaveDays";
        public const string LeaveApplicationFromDateEditName = "fld_dteLeaveApplicationFromDate";
        public const string LeaveApplicationToDateEditName = "fld_dteLeaveApplicationToDate";
        #endregion

        #region Employee
        public const string EmployeeGridControlName = "fld_dgcHREmployeesGridControl";
        public const string EmployeeFromDateEditName = "fld_dteHREmployeeFromDate";
        public const string EmployeeToDateEditName = "fld_dteHREmployeeToDate";

        public const string SaleOrderFromDateControlName = "fld_dteSaleOrderFromDate";
        public const string SaleOrderToDateControlName = "fld_dteSaleOrderToDate";
        #endregion

        #region Payment Proposal
        public const string PaymentProposalsGridControlName = "fld_dgcAPPaymentProposals";
        public const string PaymentProposalFromDateEditName = "fld_dtePaymentProposalFromDate";
        public const string PaymentProposalToDateEditName = "fld_dtePaymentProposalToDate";
        #endregion

        #region Public properties

        public BOSDateEdit SaleOrderFilterFromDateEditControl;
        public BOSDateEdit SaleOrderFilterToDateEditControl;
        #endregion

        #region Receipt
        public const string ShipmenttUnExecutedInvoiceControlName = "fld_dgcShipmentsGridControl";
        #endregion

        public HomeModule()
        {
            Name = "Home";
            CurrentModuleEntity = new HomeEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            try
            {
                BOSDateEdit dateFromHistoryDateEdit = (BOSDateEdit)Controls[HomeModule.DateFromHistoryDetailsDateEditName];
                if (dateFromHistoryDateEdit != null)
                {
                    dateFromHistoryDateEdit.EditValue = BOSApp.GetCurrentServerDate();
                }
                BOSDateEdit dateToHistoryDateEdit = (BOSDateEdit)Controls[HomeModule.DateToHistoryDetailsDateEditName];
                if(dateToHistoryDateEdit != null)
                {
                    dateToHistoryDateEdit.EditValue = BOSApp.GetCurrentServerDate();
                }

                SaleOrderFilterFromDateEditControl = (BOSDateEdit)Controls[HomeModule.SaleOrdersFilterFromDateEditName];
                SaleOrderFilterToDateEditControl = (BOSDateEdit)Controls[HomeModule.SaleOrdersFilterToDateEditName];

                //Remind
                ShowPromptDeliverySaleOrder(BOSApp.GetCurrentServerDate().AddDays(-7), BOSApp.GetCurrentServerDate().AddDays(7));
                ShowPromptDeliveryShipment();
                //ShowPromptDeliveryPurchaseOrder();
                //RemindPurchaseProposals();

                //Show history
                //ShowHistoryDetails();
                //ShowHistoryDetailsOfSaleOrder();
                //ShowProductHistoryDetails();
                //ShowGoodsReceiptList();
                
                ShowSaleOrderFilterList();
                ShowPurchaseOrderFilterList();
                ShowPurchaseProposalFilterList();
                ShowAllRemindForHome();
                ShowAllBatchProposalForHome();
                ShowShipmenttUnExecutedInvoiceList();
                ShowEmployeeMissingRecordList();
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Show prompt delivery for sale order
        /// </summary>
        public void ShowPromptDeliverySaleOrder(DateTime? fromDate, DateTime? toDate)
        {
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            if ((Controls["fld_dgcARSaleOrders"] as ARSaleOrdersGridControl) == null) return;
            
            DataSet ds = objSaleOrdersController.GetSaleOrderByDeliveryDueDays(fromDate, toDate);
            entity.SaleOrderList.Invalidate(ds);
            entity.SaleOrderList.GridControl?.RefreshDataSource();
        }
        /// <summary>
        /// Show prompt delivery for shipment sale order
        /// </summary>
        public void ShowPromptDeliveryShipment()
        {
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            ICShipmentSaleOrdersController objShipmentSaleOrdersController = new ICShipmentSaleOrdersController();
            if ((Controls["homeShipmentsGridControl1"] as HomeShipmentsGridControl) == null) return;
            DataSet ds = objShipmentSaleOrdersController.GetShipmentSaleOrderByCurrentDate();
            entity.ShipmentSaleOrderList.Invalidate(ds);
        }
        /// <summary>
        /// Show prompt delivery for purchase order
        /// </summary>
        public void ShowPromptDeliveryPurchaseOrder()
        {
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            ADConfigValuesInfo objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByConfigKey(ConfigValueKey.SaleOrderDeliveryDueDays.ToString());
            if (objConfigValuesInfo != null)
            {
                DataSet ds = objPurchaseOrdersController.GetPurchaseOrderByDeliveryDueDays(Convert.ToInt32(objConfigValuesInfo.ADConfigKeyValue));
                entity.PurchaseOrderList.Invalidate(ds);
            }
        }

        /// <summary>
        /// Show sale order screen
        /// </summary>
        /// <param name="saleOrderID">Sale order id</param>
        public void ShowSaleOrderScreen(int saleOrderID, string saleOrderType)
        {
            if (saleOrderType == InvoiceType.SaleReceipt.ToString())
            {
                Modules.POS.POSModule POSModule = null;
                if (BOSApp.IsOpenedModule(ModuleName.POS))
                {
                    POSModule = ((Modules.POS.POSModule)BOSApp.OpenModules[ModuleName.POS]);
                }
                else
                {
                    POSModule = (Modules.POS.POSModule)BOSApp.ShowModule(ModuleName.POS);
                }
                if (POSModule == null)
                    return;
                POSModule.Invalidate(saleOrderID);
                POSModule.ParentScreen.Activate();
            }
            else
            {
                Modules.SaleOrder.SaleOrderModule saleOrderModule = null;
                if (BOSApp.IsOpenedModule(ModuleName.SaleOrder))
                {
                    saleOrderModule = ((Modules.SaleOrder.SaleOrderModule)BOSApp.OpenModules[ModuleName.SaleOrder]);
                }
                else
                {
                    saleOrderModule = (Modules.SaleOrder.SaleOrderModule)BOSApp.ShowModule(ModuleName.SaleOrder);
                }
                if (saleOrderModule == null)
                    return;
                saleOrderModule.Invalidate(saleOrderID);
                saleOrderModule.ParentScreen.Activate();
            }
        }

        public void ShowBatchProductScreen(int batchProductID)
        {
            BaseModuleERP bathProductModule = BOSApp.ShowModule(ModuleName.BatchProduct);
            if (bathProductModule == null)
                return;

            bathProductModule.ActionInvalidate(batchProductID);
        }
        /// <summary>
        /// Show purchase order screen
        /// </summary>
        /// <param name="purchaseOrderID">Purchase order id</param>
        public void ShowPurchaseOrderScreen(int purchaseOrderID)
        {
            Modules.PurchaseOrder.PurchaseOrderModule purchaseOrderModule = null;
            if (BOSApp.IsOpenedModule(ModuleName.PurchaseOrder))
            {
                purchaseOrderModule = (Modules.PurchaseOrder.PurchaseOrderModule)BOSApp.OpenModules[ModuleName.PurchaseOrder];
            }
            else
            {
                purchaseOrderModule = (Modules.PurchaseOrder.PurchaseOrderModule)BOSApp.ShowModule(ModuleName.PurchaseOrder);
            }
            if (purchaseOrderModule == null)
                return;
            purchaseOrderModule.Invalidate(purchaseOrderID);
            purchaseOrderModule.ParentScreen.Activate();
        }

        #region History details of customer

        /// <summary>
        /// Show List DeliveryPlanTruckPoint
        /// </summary>
        public void DeliveryPlanTruckPointList()
        {
            BOSDateEdit dateBeginHistoryDateEdit = (BOSDateEdit)Controls[HomeModule.DateFromHistoryDetailsDateEditName];
            BOSDateEdit dateEndHistoryDateEdit = (BOSDateEdit)Controls[HomeModule.DateToHistoryDetailsDateEditName];
            DateTime dateFrom = Convert.ToDateTime(dateBeginHistoryDateEdit.EditValue);
            DateTime dateTo = Convert.ToDateTime(dateEndHistoryDateEdit.EditValue);
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            ARDeliveryPlanTruckPointsController objDeliveryPlanTruckPointsController = new ARDeliveryPlanTruckPointsController();
            List<ARDeliveryPlanTruckPointsInfo> deliveryPlanTruckPoints = objDeliveryPlanTruckPointsController.GetDeliveryPlanTruckPointsByDate(dateFrom, dateTo);
            entity.DeliveryPlanTruckPointList.Invalidate(deliveryPlanTruckPoints);
        }

        /// <summary>
        /// Show history details of customer
        /// </summary>
        public void ShowHistoryDetails()
        {
            BOSDateEdit dateBeginHistoryDateEdit = (BOSDateEdit)Controls[HomeModule.DateFromHistoryDetailsDateEditName];
            BOSDateEdit dateEndHistoryDateEdit = (BOSDateEdit)Controls[HomeModule.DateToHistoryDetailsDateEditName];
            DateTime dateFrom = Convert.ToDateTime(dateBeginHistoryDateEdit.EditValue);
            DateTime dateTo = Convert.ToDateTime(dateEndHistoryDateEdit.EditValue);
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            List<GEHistoryDetailsInfo> historyDetailList = GetHistoryDetailList(ModuleName.Customer, TableName.ARCustomersTableName, dateFrom, dateTo);
            entity.HistoryDetailList.Invalidate(historyDetailList);
        }

        /// <summary>
        /// Check all history details
        /// </summary>
        public void CheckAllHistoryDetails()
        {
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            BOSCheckEdit checkAllName = (BOSCheckEdit)Controls[HomeModule.CheckAllHistoryDetailsCheckEditName];
            foreach (GEHistoryDetailsInfo objHistoryDetailsInfo in entity.HistoryDetailList)
            {
                objHistoryDetailsInfo.IsApproved = checkAllName.Checked;
            }
            entity.HistoryDetailList.GridControl?.RefreshDataSource();
        }

        /// <summary>
        /// Delete history details
        /// </summary>
        public void DeleteHistoryDetails()
        {
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            GEHistoryDetailsController objHistoryDetailsController = new GEHistoryDetailsController();
            int count = 0;
            foreach (GEHistoryDetailsInfo objHistoryDetailsInfo in entity.HistoryDetailList)
            {
                if (objHistoryDetailsInfo.IsApproved)
                {
                    #region Delete child history details
                    DataSet ds = objHistoryDetailsController.GetAllObjectsByObjectParentID(objHistoryDetailsInfo.GEHistoryDetailID);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            GEHistoryDetailsInfo objChildHistoryDetailsInfo = (GEHistoryDetailsInfo)objHistoryDetailsController.GetObjectFromDataRow(dr);
                            objChildHistoryDetailsInfo.IsApproved = true;
                            entity.DeleteHistoryDetails(objChildHistoryDetailsInfo);
                        }
                    }
                    #endregion

                    count++;
                    entity.DeleteHistoryDetails(objHistoryDetailsInfo);
                }
            }
            if (count > 0)
            {
                ShowHistoryDetails();
            }
            else
            {
                MessageBox.Show(HomeLocalizedResources.CheckIsNullMessage, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Cancel remind with checked rows
        /// </summary>
        public void CancelRemind()
        {
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            GEHistoryDetailsController objHistoryDetailsController = new GEHistoryDetailsController();
            int count = 0;
            foreach (GEHistoryDetailsInfo objHistoryDetailsInfo in entity.HistoryDetailList)
            {
                if (objHistoryDetailsInfo.IsApproved)
                {
                    #region Cancel remind child history details
                    DataSet ds = objHistoryDetailsController.GetAllObjectsByObjectParentID(objHistoryDetailsInfo.GEHistoryDetailID);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            GEHistoryDetailsInfo objChildHistoryDetailsInfo = (GEHistoryDetailsInfo)objHistoryDetailsController.GetObjectFromDataRow(dr);
                            objChildHistoryDetailsInfo.IsApproved = true;
                            entity.RollbackCustomerByHistoryDetail(objChildHistoryDetailsInfo);
                        }

                    }
                    #endregion

                    #region Cancel remind parent history details
                    count++;
                    entity.RollbackCustomerByHistoryDetail(objHistoryDetailsInfo);
                    #endregion
                }
            }
            if (count > 0)
                ShowHistoryDetails();
            else
                MessageBox.Show(HomeLocalizedResources.CheckIsNullMessage, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region History details of sale order

        /// <summary>
        /// Show history details of sale order
        /// </summary>
        public void ShowHistoryDetailsOfSaleOrder()
        {
            BOSDateEdit dateFromHistoryDateEdit = (BOSDateEdit)Controls[HomeModule.DateFromHistoryDetailsOfSaleOrderDateEditName];
            BOSDateEdit dateToHistoryDateEdit = (BOSDateEdit)Controls[HomeModule.DateToHistoryDetailsOfSaleOrderDateEditName];
            DateTime dateFrom = Convert.ToDateTime(dateFromHistoryDateEdit.EditValue);
            DateTime dateTo = Convert.ToDateTime(dateToHistoryDateEdit.EditValue);
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            GEHistoryDetailsController objHistoryDetailsController = new GEHistoryDetailsController();
            List<GEHistoryDetailsInfo> historyDetailList = GetHistoryDetailList(ModuleName.SaleOrder, TableName.ARSaleOrdersTableName, dateFrom, dateTo);
            entity.HistoryDetailOfSaleOrderList.Invalidate(historyDetailList);
        }

        /// <summary>
        /// Check all history details of sale order
        /// </summary>
        public void CheckAllHistoryDetailsOfSaleOrder()
        {
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            BOSCheckEdit checkAllName = (BOSCheckEdit)Controls[HomeModule.CheckAllHistoryDetailsOfSaleOrderCheckEditName];
            foreach (GEHistoryDetailsInfo objHistoryDetailsInfo in entity.HistoryDetailOfSaleOrderList)
            {
                objHistoryDetailsInfo.IsApproved = checkAllName.Checked;
            }
            entity.HistoryDetailOfSaleOrderList.GridControl?.RefreshDataSource();
        }

        /// <summary>
        /// Delete history details of sale order
        /// </summary>
        public void DeleteHistoryDetailsOfSaleOrder()
        {
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            foreach (GEHistoryDetailsInfo objHistoryDetailsInfo in entity.HistoryDetailOfSaleOrderList)
            {
                if (objHistoryDetailsInfo.IsApproved)
                    entity.DeleteHistoryDetails(objHistoryDetailsInfo);
            }
            ShowHistoryDetailsOfSaleOrder();
        }

        #endregion

        #region History details of product
        /// <summary>
        /// Show history details of product
        /// </summary>
        public void ShowProductHistoryDetails()
        {
            DateTime fromDate = (Controls[HomeModule.DateFromHistoryDetailsOfProductDateEditName] as BOSDateEdit).DateTime;
            DateTime toDate = (Controls[HomeModule.DateToHistoryDetailsOfProductDateEditName] as BOSDateEdit).DateTime;
            int productID = Convert.ToInt32((Controls[HomeModule.ProductLookupEditName] as BOSLookupEdit).EditValue);
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            List<GEHistoryDetailsInfo> historyDetailList = GetHistoryDetailList(ModuleName.Product, TableName.ICProductsTableName, productID, null, fromDate, toDate);
            entity.HistoryDetailsOfProductsList.Invalidate(historyDetailList);
        }

        /// <summary>
        /// Check all history details of product
        /// </summary>
        public void CheckAllProductHistoryDetails()
        {
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            BOSCheckEdit checkAllName = (BOSCheckEdit)Controls[HomeModule.CheckAllHistoryDetailsOfProductCheckEditName];
            foreach (GEHistoryDetailsInfo objHistoryDetailsInfo in entity.HistoryDetailsOfProductsList)
            {
                objHistoryDetailsInfo.IsApproved = checkAllName.Checked;
            }
            entity.HistoryDetailsOfProductsList.GridControl?.RefreshDataSource();
        }

        /// <summary>
        /// Delete history details of product
        /// </summary>
        public void DeleteProductHistoryDetails()
        {
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            int count = 0;
            foreach (GEHistoryDetailsInfo objHistoryDetailsInfo in entity.HistoryDetailsOfProductsList)
            {
                if (objHistoryDetailsInfo.IsApproved)
                {
                    count++;
                    entity.DeleteHistoryDetails(objHistoryDetailsInfo);
                }
            }
            if (count > 0)
                ShowProductHistoryDetails();
            else
                MessageBox.Show(HomeLocalizedResources.CheckIsNullMessage, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /// <summary>
        /// Cancel remind of product with checked rows
        /// </summary>
        public void CancelProductRemind()
        {
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            int count = 0;
            foreach (GEHistoryDetailsInfo objHistoryDetailsInfo in entity.HistoryDetailsOfProductsList)
            {
                if (objHistoryDetailsInfo.IsApproved)
                {
                    count++;
                    entity.RollbackProductByHistoryDetail(objHistoryDetailsInfo);
                }
            }
            if (count > 0)
            {
                ShowProductHistoryDetails();
            }
            else
            {
                MessageBox.Show(HomeLocalizedResources.CheckIsNullMessage, CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        /// <summary>
        /// Get history detail list
        /// </summary>
        /// <param name="historyObjectName">Name of history object</param>
        /// <param name="foreignTableName">Name of foreign table</param>
        /// <param name="fromDate">Search from date</param>
        /// <param name="toDate">Search to date</param>
        /// <returns>History detail list</returns>
        public List<GEHistoryDetailsInfo> GetHistoryDetailList(string historyObjectName, string foreignTableName, DateTime fromDate, DateTime toDate)
        {
            return GetHistoryDetailList(historyObjectName, foreignTableName, null, null, fromDate, toDate);
        }

        /// <summary>
        /// Get history detail list
        /// </summary>
        /// <param name="historyObjectName">Name of history object</param>
        /// <param name="foreignTableName">Name of foreign table</param>
        /// <param name="objectID">Object id</param>
        /// <param name="objectNo">Object no</param>
        /// <param name="fromDate">Search from date</param>
        /// <param name="toDate">Search to date</param>
        /// <returns>History detail list</returns>
        public List<GEHistoryDetailsInfo> GetHistoryDetailList(string historyObjectName, string foreignTableName, int? objectID, string objectNo, DateTime? fromDate, DateTime? toDate)
        {
            GEHistoryDetailsController objHistoryDetailsController = new GEHistoryDetailsController();
            List<GEHistoryDetailsInfo> historyDetailOriginalList = objHistoryDetailsController.GetHistoryDetailList(historyObjectName, objectID, objectNo, fromDate, toDate);
            List<GEHistoryDetailsInfo> historyDetailList = new List<GEHistoryDetailsInfo>();
            if (historyDetailOriginalList != null)
            {
                foreach (GEHistoryDetailsInfo objHistoryDetailsInfo in historyDetailOriginalList)
                {
                    if (!string.IsNullOrEmpty(objHistoryDetailsInfo.AAColumnAliasCaption))
                    {
                        objHistoryDetailsInfo.OldValueDisplayedText = BOSApp.GetDisplayedTextByValue(foreignTableName, objHistoryDetailsInfo.GEHistoryDetailColumnName, objHistoryDetailsInfo.GEHistoryDetailOldValue);
                        objHistoryDetailsInfo.NewValueDisplayedText = BOSApp.GetDisplayedTextByValue(foreignTableName, objHistoryDetailsInfo.GEHistoryDetailColumnName, objHistoryDetailsInfo.GEHistoryDetailNewValue);
                        historyDetailList.Add(objHistoryDetailsInfo);
                    }
                }
            }
            return historyDetailList;
        }

        /// <summary>
        /// Remind purchase proposals
        /// </summary>        
        public void RemindPurchaseProposals()
        {
            APProposalsController objProposalsController = new APProposalsController();
            List<APProposalsInfo> proposals = objProposalsController.GetProposalsByStatus(PurchaseProposalStatus.New.ToString());
            GridControl gridControl = (GridControl)Controls[HomeModule.ProposalGridControlName];
            gridControl.DataSource = proposals;
        }

        //[NKVung] [Theo dõi hàng về] [START]
        public void ShowGoodsReceiptList()
        {
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<ICReceiptItemsInfo> ListReceiptItems = objReceiptItemsController.GetGoodsReceiptList();
            entity.GoodsReceiptList.Invalidate(ListReceiptItems);
        }
        //[END]
        public void ShowProductInProduction(int productID, int batchProductID, int customerID, string productSys)
        {
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> ListProduct = new List<ICProductsInfo>();
            ListProduct = objProductsController.GetProductByMainScreen(productID, batchProductID, customerID, productSys);
            entity.ProductList.Invalidate(ListProduct);
        }

        public void ShowSaleOrderFilterList()
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            if ((Controls["fld_dgcSaleOrdersFilterGridControl"] as ARSaleOrderFiltersGridControl) == null) return;
            BOSDateEdit fromDateEdit = (BOSDateEdit)Controls[HomeModule.SaleOrdersFilterFromDateEditName];
            if(fromDateEdit != null)
            {
                fromDate = fromDateEdit.DateTime;
            }    
            BOSDateEdit toDateEdit = (BOSDateEdit)Controls[HomeModule.SaleOrdersFilterToDateEditName];
            if (toDateEdit != null)
            {
                toDate = toDateEdit.DateTime;
            }

            bool? isReceiveBill = (Controls[HomeModule.SaleOrderIsReceiveBill] as BOSCheckEdit) != null ? (Controls[HomeModule.SaleOrderIsReceiveBill] as BOSCheckEdit).EditValue as bool? :false;
            string strSaleOrderStatus = string.Empty;
            if ((Controls[HomeModule.SaleOrdersFilterStatus] as BOSLookupEdit) != null && (Controls[HomeModule.SaleOrdersFilterStatus] as BOSLookupEdit).EditValue != null)
                strSaleOrderStatus = (Controls[HomeModule.SaleOrdersFilterStatus] as BOSLookupEdit).EditValue.ToString(); ;
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            List<ARSaleOrdersInfo> saleOrdersList = objSaleOrdersController.GetAllSaleOrderForHome(fromDate, toDate, strSaleOrderStatus, isReceiveBill);
            entity.SaleOrdersFilterList.Invalidate(saleOrdersList);
            entity.SaleOrdersFilterList.GridControl?.RefreshDataSource();
        }

        public void ShowPurchaseOrderFilterList()
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            if ((Controls["fld_dgcPurchaseOrderFilterGridControl"] as APPurchaseOrderFiltersGridControl) == null) return;
            BOSDateEdit fromDateEdit = (BOSDateEdit)Controls[HomeModule.PurchaseOrderFilterFromDateEditName];
            if (fromDateEdit != null)
            {
                fromDate = fromDateEdit.DateTime;
            }
            BOSDateEdit toDateEdit = (BOSDateEdit)Controls[HomeModule.PurchaseOrderFilterToDateEditName];
            if (toDateEdit != null)
            {
                toDate = toDateEdit.DateTime;
            }

            string strSaleOrderStatus = string.Empty;
            if ((Controls[HomeModule.PurchaseOrderFilterStatus] as BOSLookupEdit) != null && (Controls[HomeModule.PurchaseOrderFilterStatus] as BOSLookupEdit).EditValue != null)
                strSaleOrderStatus = (Controls[HomeModule.PurchaseOrderFilterStatus] as BOSLookupEdit).EditValue.ToString(); ;
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            APPurchaseOrdersController objPurchaseOrdersController = new APPurchaseOrdersController();
            List<APPurchaseOrdersInfo> purchaseOrderList = objPurchaseOrdersController.GetAllPurchaseOrdersForHome(fromDate, toDate, strSaleOrderStatus);
            entity.PurchaseOrderFilterList.Invalidate(purchaseOrderList);
            entity.PurchaseOrderFilterList.GridControl?.RefreshDataSource();
        }

        public void ShowPurchaseProposalFilterList()
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            if ((Controls["fld_dgcAPProposalsFilterGridControl"] as APPurchaseProposalsGridControl) == null) return;
            BOSDateEdit fromDateEdit = (BOSDateEdit)Controls[HomeModule.PurchaseProposalFilterFromDateEditName];
            if (fromDateEdit != null)
            {
                fromDate = fromDateEdit.DateTime;
            }
            BOSDateEdit toDateEdit = (BOSDateEdit)Controls[HomeModule.PurchaseProposalFilterToDateEditName];
            if (toDateEdit != null)
            {
                toDate = toDateEdit.DateTime;
            }

            string strPurchaseProposalStatus = string.Empty;
            if ((Controls[HomeModule.PurchaseProposalFilterStatus] as BOSLookupEdit).EditValue != null)
                strPurchaseProposalStatus = (Controls[HomeModule.PurchaseProposalFilterStatus] as BOSLookupEdit).EditValue.ToString();
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            APProposalsController objProposalsController = new APProposalsController();
            List<APProposalsInfo> purchaseProposalList = objProposalsController.GetAllPurchaseProposalsForHome(fromDate, toDate, strPurchaseProposalStatus);
            entity.PurchaseProposalFilterList.Invalidate(purchaseProposalList);
            entity.PurchaseProposalFilterList.GridControl?.RefreshDataSource();
        }

        public void ShowPurchaseProposalScreen(int purchaseProposalID)
        {
            Modules.PurchaseProposal.PurchaseProposalModule purchaseProposalModule = null;
            if (BOSApp.IsOpenedModule(ModuleName.PurchaseProposal))
            {
                purchaseProposalModule = (Modules.PurchaseProposal.PurchaseProposalModule)BOSApp.OpenModules[ModuleName.PurchaseProposal];
            }
            else
            {
                purchaseProposalModule = (Modules.PurchaseProposal.PurchaseProposalModule)BOSApp.ShowModule(ModuleName.PurchaseProposal);
            }
            if (purchaseProposalModule == null)
                return;
            purchaseProposalModule.Invalidate(purchaseProposalID);
            purchaseProposalModule.ParentScreen.Activate();
        }
        public void ShowAllRemindForHome()
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            if ((Controls["fld_dgcARRemindsGridControl"] as ARRemindGridControl) == null) return;
            BOSDateEdit fromDateEdit = (BOSDateEdit)Controls[HomeModule.RemindFromDateEditName];
            if (fromDateEdit != null)
            {
                fromDate = fromDateEdit.DateTime;
            }
            BOSDateEdit toDateEdit = (BOSDateEdit)Controls[HomeModule.RemindToDateEditName];
            if (toDateEdit != null)
            {
                toDate = toDateEdit.DateTime;
            }

            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            ARRemindsController objRemindsController = new ARRemindsController();
            List<ARRemindsInfo> remindsList = objRemindsController.GetAllRemindsForHome(fromDate, toDate);
            entity.RemindsList.Invalidate(remindsList);
            entity.RemindsList.GridControl?.RefreshDataSource();
        }

        public void ShowAllBatchProductForHome()
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            if ((Controls["fld_dgcMMBatchProductsGridControl"] as MMBatchProductsGridControl) == null) return;
            BOSDateEdit fromDateEdit = (BOSDateEdit)Controls[HomeModule.BatchProductsFromDateEditName];
            if (fromDateEdit != null)
            {
                fromDate = fromDateEdit.DateTime;
            }
            BOSDateEdit toDateEdit = (BOSDateEdit)Controls[HomeModule.BatchProductsToDateEditName];
            if (toDateEdit != null)
            {
                toDate = toDateEdit.DateTime;
            }

            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            List<MMBatchProductsInfo> batchProductsList = objBatchProductsController.ShowAllBatchProductNoPurchasePlanForHome(fromDate, toDate);
            entity.BatchProductsList.Invalidate(batchProductsList);
            entity.BatchProductsList.GridControl?.RefreshDataSource();
        }

        public void ShowBatchProposalDetail()
        {
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            if (entity.BatchProposalList.CurrentIndex >= 0)
            {
                MMProposalsInfo objProposalsInfo = entity.BatchProposalList[entity.BatchProposalList.CurrentIndex];
                if (objProposalsInfo == null)
                    objProposalsInfo = new MMProposalsInfo();
                MMProposalItemsController objProposalItemsController = new MMProposalItemsController();
                List<MMProposalItemsInfo> proposalItemList = objProposalItemsController.GetProposalItemsByProposalID(objProposalsInfo.MMProposalID);
                if (proposalItemList == null)
                    proposalItemList = new List<MMProposalItemsInfo>();
                guiShowBatchProposalItem guiFind = new guiShowBatchProposalItem(proposalItemList);
                guiFind.Module = this;
                guiFind.Show();
            }
        }

        public void ShowAllBatchProposalForHome()
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            if ((Controls["fld_dgcBatchProposalsGridControl"] as MMBatchProposalsGridControl) == null) return;
            BOSDateEdit fromDateEdit = (BOSDateEdit)Controls[HomeModule.BatchProposalFromDateEditName];
            if (fromDateEdit != null)
            {
                fromDate = fromDateEdit.DateTime;
            }
            BOSDateEdit toDateEdit = (BOSDateEdit)Controls[HomeModule.BatchProposalToDateEditName];
            if (toDateEdit != null)
            {
                toDate = toDateEdit.DateTime;
            }

            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            MMProposalsController objProposalsController = new MMProposalsController();
            List<MMProposalsInfo> batchProposalList = objProposalsController.ShowAllBatchProposalForHome(fromDate, toDate);
            entity.BatchProposalList.Invalidate(batchProposalList);
            entity.BatchProposalList.GridControl?.RefreshDataSource();
        }

        public void ShowBatchProposalScreen(int batchProposalID)
        {
            BaseModuleERP batchProposalModule = BOSApp.ShowModule(ModuleName.BatchProposal);
            if (batchProposalModule == null)
                return;

            batchProposalModule.ActionInvalidate(batchProposalID);
        }

        public void ShowAllEmployeeForHome()
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            if ((Controls["fld_dgcHREmployeesGridControl"] as HREmployeesGridControl) == null) return;
            BOSDateEdit fromDateEdit = (BOSDateEdit)Controls[HomeModule.EmployeeFromDateEditName];
            if (fromDateEdit != null)
            {
                fromDate = fromDateEdit.DateTime;
            }
            BOSDateEdit toDateEdit = (BOSDateEdit)Controls[HomeModule.EmployeeToDateEditName];
            if (toDateEdit != null)
            {
                toDate = toDateEdit.DateTime;
            }

            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            HREmployeesController objEmployeesController = new HREmployeesController();
            List<HREmployeesInfo> employeesList = objEmployeesController.ShowAllEmployeeForHome(fromDate, toDate);
            entity.EmployeesList.Invalidate(employeesList);
            entity.EmployeesList.GridControl?.RefreshDataSource();
        }

        public void ShowAllTransferProposalForHome()
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            if ((Controls["fld_dgcICTransferProposalsGridControl"] as ICTransferProposalsGridControl) == null) return;
            BOSDateEdit fromDateEdit = (BOSDateEdit)Controls[HomeModule.TransferProposalFromDateEditName];
            if (fromDateEdit != null)
            {
                fromDate = fromDateEdit.DateTime;
            }
            BOSDateEdit toDateEdit = (BOSDateEdit)Controls[HomeModule.TransferProposalToDateEditName];
            if (toDateEdit != null)
            {
                toDate = toDateEdit.DateTime;
            }

            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            ICTransferProposalsController objTransferProposalsController = new ICTransferProposalsController();
            List<ICTransferProposalsInfo> transferProposalList = objTransferProposalsController.ShowAllTransferProposalForHome(fromDate, toDate);
            entity.TransferProposalList.Invalidate(transferProposalList);
            entity.TransferProposalList.GridControl?.RefreshDataSource();
        }

        public void ShowAllocationPlansForHome()
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            if ((Controls["fld_dgcMMAllocationPlansGridControl"] as MMAllocationPlansGridControl) == null) return;
            BOSDateEdit fromDateEdit = (BOSDateEdit)Controls[HomeModule.AllocationPlanFromDateEditName];
            if (fromDateEdit != null)
            {
                fromDate = fromDateEdit.DateTime;
            }
            BOSDateEdit toDateEdit = (BOSDateEdit)Controls[HomeModule.AllocationPlansToDateEditName];
            if (toDateEdit != null)
            {
                toDate = toDateEdit.DateTime;
            }

            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            MMAllocationPlansController objAllocationPlansController = new MMAllocationPlansController();
            List<MMAllocationPlansInfo> allocationPlanList = objAllocationPlansController.ShowAllAllocationPlanForHome(fromDate, toDate);
            entity.AllocationPlanList.Invalidate(allocationPlanList);
            entity.AllocationPlanList.GridControl?.RefreshDataSource();
        }

        public void ShowAllLeaveApplicationForHome()
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            BOSDateEdit fromDateEdit = (BOSDateEdit)Controls[HomeModule.LeaveApplicationFromDateEditName];
            if (fromDateEdit != null)
            {
                fromDate = fromDateEdit.DateTime;
            }
            BOSDateEdit toDateEdit = (BOSDateEdit)Controls[HomeModule.LeaveApplicationToDateEditName];
            if (toDateEdit != null)
            {
                toDate = toDateEdit.DateTime;
            }

            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            HRRequestLeaveDaysController objLeaveApplicationsController = new HRRequestLeaveDaysController();
            List<HRRequestLeaveDaysInfo> leaveApplicationsList = objLeaveApplicationsController.ShowAllLeaveApplicationForHome(fromDate, toDate);
            entity.LeaveApplicationsList.Invalidate(leaveApplicationsList);
            entity.LeaveApplicationsList.GridControl?.RefreshDataSource();
        }

        public void ShowAllPaymentProposalForHome()
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            BOSDateEdit fromDateEdit = (BOSDateEdit)Controls[HomeModule.PaymentProposalFromDateEditName];
            if (fromDateEdit != null)
            {
                fromDate = fromDateEdit.DateTime;
            }
            BOSDateEdit toDateEdit = (BOSDateEdit)Controls[HomeModule.PaymentProposalToDateEditName];
            if (toDateEdit != null)
            {
                toDate = toDateEdit.DateTime;
            }

            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            GEPaymentProposalsController objPaymentProposalsController = new GEPaymentProposalsController();
            List<GEPaymentProposalsInfo> paymentProposalsList = objPaymentProposalsController.GetAllPaymentForHome(fromDate, toDate);
            entity.PaymentProposalsList.Invalidate(paymentProposalsList);
            entity.PaymentProposalsList.GridControl?.RefreshDataSource();
        }

        public void ChangeStatus(GEPaymentProposalsInfo objPaymentProposalsInfo)
        {
            BOSProgressBar.Start("Đang duyệt");
            try
            {
                if (objPaymentProposalsInfo.GEPaymentProposalType == PaymentProposalType.PaymentProposal.ToString())
                {
                    Modules.PaymentProposal.PaymentProposalModule paymentProposalModule = null;
                    if (BOSApp.IsOpenedModule(ModuleName.PaymentProposal))
                    {
                        paymentProposalModule = ((Modules.PaymentProposal.PaymentProposalModule)BOSApp.OpenModules[ModuleName.PaymentProposal]);
                    }
                    else
                    {
                        paymentProposalModule = (Modules.PaymentProposal.PaymentProposalModule)BOSApp.ShowModule(ModuleName.PaymentProposal);
                    }

                    if (paymentProposalModule == null)
                        return;

                    paymentProposalModule.Search();
                    paymentProposalModule.Invalidate(objPaymentProposalsInfo.GEPaymentProposalID);
                    paymentProposalModule.Approve();
                }
                if (objPaymentProposalsInfo.GEPaymentProposalType == PaymentProposalType.AdvanceRefund.ToString())
                {
                    Modules.AdvanceRefundDirect.AdvanceRefundDirectModule advanceRefundModule = null;
                    if (BOSApp.IsOpenedModule(ModuleName.AdvanceRefundDirect))
                    {
                        advanceRefundModule = ((Modules.AdvanceRefundDirect.AdvanceRefundDirectModule)BOSApp.OpenModules[ModuleName.AdvanceRefundDirect]);
                    }
                    else
                    {
                        advanceRefundModule = (Modules.AdvanceRefundDirect.AdvanceRefundDirectModule)BOSApp.ShowModule(ModuleName.AdvanceRefundDirect);
                    }

                    if (advanceRefundModule == null)
                        return;

                    advanceRefundModule.Search();
                    advanceRefundModule.Invalidate(objPaymentProposalsInfo.GEPaymentProposalID);
                    advanceRefundModule.ActionComplete();
                }
                ParentScreen.Activate();
                System.Threading.Thread.Sleep(1000);
                ShowAllPaymentProposalForHome();
            }
            catch (Exception) { }
            finally
            {
                BOSProgressBar.Close();
            }
        }

        public void ShowEmployeeMissingRecordList()
        {
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            if ((Controls["fld_dgcHREmployeeMissingRecordsGridControl"] as HREmployeeMissingRecordsGridControl) == null) return;
            HREmployeesController objEmployeesController = new HREmployeesController();
            List<HREmployeesInfo> employeeMissingRecordList = objEmployeesController.GetEmployeeEmployeeMissingRecordList();
            entity.EmployeeMissingRecordList.Invalidate(employeeMissingRecordList);
            entity.EmployeeMissingRecordList.GridControl?.RefreshDataSource();
        }
        public void ShowShipmenttUnExecutedInvoiceList()
        {
            HomeEntities entity = (HomeEntities)CurrentModuleEntity;
            if ((Controls["fld_dgcShipmentSaleOrdersGridControl"] as ShipmentSaleOrdersGridControl) == null) return;
            ICShipmentsController objShipmentsController = new ICShipmentsController();
            List<ICShipmentsInfo> shipmentUnExecutedInvoiceInList = objShipmentsController.GetShipmentUnExecutedInvoiceList();
            entity.ShipmentUnExecutedInvoiceList.Invalidate(shipmentUnExecutedInvoiceInList);
            entity.ShipmentUnExecutedInvoiceList.GridControl?.RefreshDataSource();
        }
        public void ShowShipmentSaleOrderScreen(int shipmentID)
        {
            Modules.ShipmentSaleOrder.ShipmentSaleOrderModule shipmentSaleOrderModule = (Modules.ShipmentSaleOrder.ShipmentSaleOrderModule)BOSApp.ShowModule(ModuleName.ShipmentSaleOrder);
            if (shipmentSaleOrderModule == null)
                return;
            shipmentSaleOrderModule.Invalidate(shipmentID);
        }
    }
}
