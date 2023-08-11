using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.DataExchange
{
    public class DataExchangeModule : BaseModuleERP
    {
        #region Constants
        public const string TransferInventoryToCentreButtonName = "fld_btnTransferInventoryToCentre";
        public const string TransferSaleDataToCentreButtonName = "fld_btnTransferSaleDataToCentre";
        public const string TransferPurchaseDataToCentreButtonName = "fld_btnTransferPurchaseDataToCentre";
        public const string TransferAccountingDataToCentreButtonName = "fld_btnTransferAccountingDataToCentre";
        public const string TransferTransactionDataToBranchButtonName = "fld_btnTransferTransactionDataToBranch";
        public const string RegionalPostingHistoryGridControlName = "fld_dgcRegionalPostingHistory";
        #endregion

        #region Variables
        private String TransferType;
        private String TransferStatus;
        private System.Windows.Forms.Timer TransferTimer;
        #endregion

        public DataExchangeModule()
        {
            Name = "DataExchange";
            CurrentModuleEntity = new DataExchangeEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            TransferTimer = new System.Windows.Forms.Timer();
            TransferTimer.Interval = 50000;
            TransferTimer.Tick += new EventHandler(TransferTimer_Tick);
        }

        public void TransferTimer_Tick(object sender, EventArgs e)
        {
            if (TransferStatus == DataExchangeStatus.New.ToString())
            {
                if (TransferType == DataExchangeType.Inventory.ToString())
                {
                    TransferInventoryFromBranchToCentre();
                }
                else if (TransferType == DataExchangeType.Sale.ToString())
                {
                    TransferSaleDataFromBranchToCentre();
                }
                else if (TransferType == DataExchangeType.Customer.ToString())
                {
                    TransferCustomersFromBranchToCentre();
                }
                else if (TransferType == DataExchangeType.Purchase.ToString())
                {
                    TransferPurchaseDataFromBranchToCentre();
                }
                else if (TransferType == DataExchangeType.Accounting.ToString())
                {
                    TransferAccountingDataFromBranchToCentre();
                }
                else if (TransferType == DataExchangeType.HumanResource.ToString())
                {
                    TransferHumanResourceDataToCentre();
                }
                else if (TransferType == DataExchangeType.AccountInitData.ToString())
                {
                    TransferAccountInitDataToCentre();
                }
            }
        }

        #region From Headquarters to Remote Branches
        public void TransferInventory()
        {
            DataExchangeEntities entity = (DataExchangeEntities)CurrentModuleEntity;
            foreach (BRBranchsInfo objBranchsInfo in entity.BRBranchsList)
            {
                BOSProgressBar.Start(String.Format(DataExchangeLocalizedResources.TransferringInventoryMessage, objBranchsInfo.BRBranchName));
                if (objBranchsInfo.Selected)
                {
                    bool isCompleted = DataExchangeHelper.SynchronizeData("InventoryPublication", objBranchsInfo.BRBranchServerAliasName, objBranchsInfo.BRBranchDatabase, null);
                    if (isCompleted)
                    {
                        objBranchsInfo.BRBranchTransferMessage = DataExchangeLocalizedResources.TransferDoneMessage;
                    }
                    else
                    {
                        objBranchsInfo.BRBranchTransferMessage = DataExchangeLocalizedResources.TransferErrorMessage;
                    }
                }
            }
            BOSProgressBar.Close();
            entity.BRBranchsList.GridControl.RefreshDataSource();
        }

        public void TransferCompanyPreferences()
        {
            DataExchangeEntities entity = (DataExchangeEntities)CurrentModuleEntity;
            foreach (BRBranchsInfo objBranchsInfo in entity.BRBranchsList)
            {
                if (objBranchsInfo.Selected)
                {
                    BOSProgressBar.Start(String.Format(DataExchangeLocalizedResources.TransferringCompanyPreferencesMessage, objBranchsInfo.BRBranchName));
                    bool isCompleted = DataExchangeHelper.SynchronizeData("CompanyPreferencePublication", objBranchsInfo.BRBranchServerAliasName, objBranchsInfo.BRBranchDatabase, null);
                    if (isCompleted)
                    {
                        objBranchsInfo.BRBranchTransferMessage = DataExchangeLocalizedResources.TransferDoneMessage;
                    }
                    else
                    {
                        objBranchsInfo.BRBranchTransferMessage = DataExchangeLocalizedResources.TransferErrorMessage;
                    }
                }
            }
            entity.BRBranchsList.GridControl.RefreshDataSource();
            BOSProgressBar.Close();
        }

        public void TransferCustomers()
        {
            DataExchangeEntities entity = (DataExchangeEntities)CurrentModuleEntity;
            List<ARCustomersInfo> transferredCustomers = new List<ARCustomersInfo>();
            List<ARCreditNotesInfo> transferredCreditNotes = new List<ARCreditNotesInfo>();
            int count = 0;
            foreach (BRBranchsInfo objBranchsInfo in entity.BRBranchsList)
            {
                if (objBranchsInfo.Selected)
                {
                    ARCustomersController objCustomersController = new ARCustomersController();
                    ARCustomerContactsController objCustomerContactsController = new ARCustomerContactsController();
                    List<ARCustomersInfo> customers = objCustomersController.GetCustomersForBroadcasting(objBranchsInfo.BRBranchID);
                    foreach (ARCustomersInfo objCustomersInfo in customers)
                    {
                        objCustomersInfo.CustomerContacts = new BOSList<ARCustomerContactsInfo>(TableName.ARCustomerContactsTableName);
                        DataSet ds = objCustomerContactsController.GetAllDataByForeignColumn("FK_ARCustomerID", objCustomersInfo.ARCustomerID);
                        objCustomersInfo.CustomerContacts.Invalidate(ds);
                    }

                    ARCreditNotesController objCreditNotesController = new ARCreditNotesController();
                    List<ARCreditNotesInfo> creditNotes = objCreditNotesController.GetCreditNotesForBroadcasting(objBranchsInfo.BRBranchID);

                    try
                    {
                        BOSProgressBar.Start(String.Format(DataExchangeLocalizedResources.TransferringCustomerMessage, objBranchsInfo.BRBranchName));
                        BOSApp.SwitchConnection(objBranchsInfo.BRBranchID);
                        if (BOSApp.TestCurrentConnection())
                        {
                            #region Transfer customers
                            foreach (ARCustomersInfo objCustomersInfo in customers)
                            {
                                ARCustomersInfo branchCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objCustomersInfo.ARCustomerNo);
                                if (branchCustomer != null)
                                {
                                    //Update existing customer
                                    int branchCustomerID = branchCustomer.ARCustomerID;
                                    branchCustomer = (ARCustomersInfo)objCustomersInfo.Clone();
                                    branchCustomer.ARCustomerID = branchCustomerID;
                                    branchCustomer.IsTransferred = true;
                                    branchCustomer.ARCustomerTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    objCustomersController.UpdateObject(branchCustomer);

                                    TransferCustomerContacts(objCustomersInfo.CustomerContacts, branchCustomer.ARCustomerID);
                                }
                                else
                                {
                                    //Create new customer
                                    branchCustomer = (ARCustomersInfo)objCustomersInfo.Clone();
                                    branchCustomer.IsTransferred = true;
                                    branchCustomer.ARCustomerTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    branchCustomer.AAUpdatedDate = DateTime.MaxValue;
                                    int branchCustomerID = objCustomersController.CreateObject(branchCustomer);

                                    TransferCustomerContacts(objCustomersInfo.CustomerContacts, branchCustomerID);
                                }
                                if (!transferredCustomers.Exists(c => c.ARCustomerID == objCustomersInfo.ARCustomerID))
                                {
                                    transferredCustomers.Add(objCustomersInfo);
                                }
                            }
                            #endregion

                            #region Transfer credit notes
                            foreach (ARCreditNotesInfo creditNote in creditNotes)
                            {
                                ARCreditNotesInfo branchCreditNote = (ARCreditNotesInfo)objCreditNotesController.GetObjectByNo(creditNote.ARCreditNoteNo);
                                if (branchCreditNote != null)
                                {
                                    int branchCreditNoteID = branchCreditNote.ARCreditNoteID;
                                    branchCreditNote = (ARCreditNotesInfo)creditNote.Clone();
                                    branchCreditNote.ARCreditNoteID = branchCreditNoteID;
                                    branchCreditNote.FK_ARCustomerID = 0;
                                    if (!string.IsNullOrEmpty(creditNote.ARCustomerNo))
                                    {
                                        ARCustomersInfo branchCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(creditNote.ARCustomerNo);
                                        if (branchCustomer != null)
                                        {
                                            branchCreditNote.FK_ARCustomerID = branchCustomer.ARCustomerID;
                                        }
                                    }
                                    branchCreditNote.IsTransferred = true;
                                    branchCreditNote.ARCreditNoteTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    objCreditNotesController.UpdateObject(branchCreditNote);
                                }
                                else
                                {
                                    branchCreditNote = (ARCreditNotesInfo)creditNote.Clone();
                                    branchCreditNote.FK_ARCustomerID = 0;
                                    if (!string.IsNullOrEmpty(creditNote.ARCustomerNo))
                                    {
                                        ARCustomersInfo branchCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(creditNote.ARCustomerNo);
                                        if (branchCustomer != null)
                                        {
                                            branchCreditNote.FK_ARCustomerID = branchCustomer.ARCustomerID;
                                        }
                                    }
                                    branchCreditNote.IsTransferred = true;
                                    branchCreditNote.ARCreditNoteTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    branchCreditNote.AAUpdatedDate = DateTime.MaxValue;
                                    objCreditNotesController.CreateObject(branchCreditNote);
                                }
                                if (!transferredCreditNotes.Exists(cn => cn.ARCreditNoteID == creditNote.ARCreditNoteID))
                                {
                                    transferredCreditNotes.Add(creditNote);
                                }
                            }
                            #endregion

                            count++;
                            objBranchsInfo.BRBranchTransferMessage = DataExchangeLocalizedResources.TransferDoneMessage;
                        }
                        else
                        {
                            objBranchsInfo.BRBranchTransferMessage = string.Format(DataExchangeLocalizedResources.CannotConnectToBranch, objBranchsInfo.BRBranchName);
                        }
                    }
                    catch (Exception)
                    {
                        objBranchsInfo.BRBranchTransferMessage = DataExchangeLocalizedResources.TransferErrorMessage;
                    }
                    finally
                    {
                        BOSApp.RollbackLocalConnection();
                    }
                }
            }

            int transferredCount = entity.BRBranchsList.Where(b => !string.IsNullOrEmpty(b.BRBranchServerName) && b.BRBranchType == BranchType.Branch.ToString()).Count();
            int selectedCount = entity.BRBranchsList.Where(b => b.Selected).Count();
            if (count == transferredCount)
            {
                UpdateLocalCustomerStatus(transferredCustomers);
                UpdateLocalCreditNoteStatus(transferredCreditNotes);
            }
            if (count == selectedCount)
            {
                //Enable the button for broadcasting transactional data
                (Controls[DataExchangeModule.TransferTransactionDataToBranchButtonName] as BOSButton).Enabled = true;
            }
            entity.BRBranchsList.GridControl.RefreshDataSource();
            BOSProgressBar.Close();
        }

        /// <summary>
        /// Update the status of local customers after transferring them
        /// to track for the next one
        /// </summary>
        /// <param name="customers">Transferred customers</param>
        private void UpdateLocalCustomerStatus(List<ARCustomersInfo> customers)
        {
            ARCustomersController objCustomersController = new ARCustomersController();
            foreach (ARCustomersInfo customer in customers)
            {
                customer.IsTransferred = true;
                customer.ARCustomerTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objCustomersController.UpdateObject(customer);
            }
        }


        /// <summary>
        /// Update the status of local credit notes after transferring them
        /// to track for the next one
        /// </summary>
        /// <param name="creditNotes">Transferred credit notes</param>        
        private void UpdateLocalCreditNoteStatus(List<ARCreditNotesInfo> creditNotes)
        {
            ARCreditNotesController objCreditNotesController = new ARCreditNotesController();
            foreach (ARCreditNotesInfo creditNote in creditNotes)
            {
                creditNote.IsTransferred = true;
                creditNote.ARCreditNoteTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objCreditNotesController.UpdateObject(creditNote);
            }
        }

        public void TransferStaffs()
        {
            DataExchangeEntities entity = (DataExchangeEntities)CurrentModuleEntity;
            foreach (BRBranchsInfo objBranchsInfo in entity.BRBranchsList)
            {
                if (objBranchsInfo.Selected)
                {
                    BOSProgressBar.Start(String.Format(DataExchangeLocalizedResources.TransferringStaffMessage, objBranchsInfo.BRBranchName));
                    bool isCompleted = DataExchangeHelper.SynchronizeData("StaffPublication", objBranchsInfo.BRBranchServerAliasName, objBranchsInfo.BRBranchDatabase, null);
                    if (isCompleted)
                    {
                        objBranchsInfo.BRBranchTransferMessage = DataExchangeLocalizedResources.TransferDoneMessage;
                    }
                    else
                    {
                        objBranchsInfo.BRBranchTransferMessage = DataExchangeLocalizedResources.TransferErrorMessage;
                    }
                }
            }
            entity.BRBranchsList.GridControl.RefreshDataSource();
            BOSProgressBar.Close();
        }

        public void RefreshPostingHistory()
        {
            DataExchangeEntities entity = (DataExchangeEntities)CurrentModuleEntity;
            DataSet ds = new BRPostingHistorysController().GetAllObjects();
            entity.BRPostingHistoryList.Invalidate(ds);
            entity.BRPostingHistoryList.GridControl.RefreshDataSource();
        }

        public void RefreshRegionalPostingHistory()
        {
            DataExchangeEntities entity = (DataExchangeEntities)CurrentModuleEntity;
            DataSet ds = new BRPostingHistorysController().GetAllObjects();
            entity.RegionalPostingHistoryList.Invalidate(ds);
            entity.RegionalPostingHistoryList.GridControl.RefreshDataSource();
        }

        /// <summary>
        /// Transfer transaction data from the centre to branches
        /// </summary>
        public void TransferTransactionData()
        {
            TransferSaleData();

            TransferPurchaseData();

            TransferAccountingData();

            //Disable the button to force user to transfer the customer before transferring transactional
            //data again
            (Controls[DataExchangeModule.TransferTransactionDataToBranchButtonName] as BOSButton).Enabled = false;
        }

        /// <summary>
        /// Transfer sale data from the centre to branches
        /// </summary>
        public void TransferSaleData()
        {
            DataExchangeEntities entity = (DataExchangeEntities)CurrentModuleEntity;
            int count = 0;
            List<ARSaleOrdersInfo> transferredSaleOrders = new List<ARSaleOrdersInfo>();
            List<ARInvoicesInfo> transferredInvoices = new List<ARInvoicesInfo>();
            List<ARCancelVouchersInfo> transferredCancelVouchers = new List<ARCancelVouchersInfo>();
            List<ARSaleReturnsInfo> transferredSaleReturns = new List<ARSaleReturnsInfo>();
            List<ARCustomerPaymentsInfo> transferredCustomerPayments = new List<ARCustomerPaymentsInfo>();
            List<AROpenDocumentsInfo> transferredOpenDocuments = new List<AROpenDocumentsInfo>();
            foreach (BRBranchsInfo branch in entity.BRBranchsList)
            {
                if (branch.Selected)
                {
                    BOSProgressBar.Start(String.Format(DataExchangeLocalizedResources.TransferringSaleDataMessage, branch.BRBranchName));
                    ARCustomersController objCustomersController = new ARCustomersController();

                    #region Get sale orders at local
                    ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                    ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
                    ARSOItemComponentsController objSOItemComponentsController = new ARSOItemComponentsController();
                    List<ARSaleOrdersInfo> saleOrders = objSaleOrdersController.GetSaleOrdersForBroadcasting(branch.BRBranchID);
                    foreach (ARSaleOrdersInfo objSaleOrdersInfo in saleOrders)
                    {
                        objSaleOrdersInfo.SaleOrderItems = new BOSList<ARSaleOrderItemsInfo>(TableName.ARSaleOrderItemsTableName);
                        List<ARSaleOrderItemsInfo> items = objSaleOrderItemsController.GetItemsBySaleOrderID(objSaleOrdersInfo.ARSaleOrderID);
                        objSaleOrdersInfo.SaleOrderItems.Invalidate(items);

                        foreach (ARSaleOrderItemsInfo objSaleOrderItemsInfo in objSaleOrdersInfo.SaleOrderItems)
                        {
                            objSaleOrderItemsInfo.ARSOItemComponentList = new BOSList<ARSOItemComponentsInfo>(TableName.ARSOItemComponentsTableName);
                            List<ARSOItemComponentsInfo> components = objSOItemComponentsController.GetSOItemComponentListBySOItemID(objSaleOrderItemsInfo.ARSaleOrderItemID);
                            objSaleOrderItemsInfo.ARSOItemComponentList.Invalidate(components);
                        }
                    }
                    #endregion

                    #region Get invoices at local
                    ARInvoicesController objInvoicesController = new ARInvoicesController();
                    ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
                    ARInvoiceItemComponentsController objInvoiceItemComponentsController = new ARInvoiceItemComponentsController();
                    List<ARInvoicesInfo> invoices = objInvoicesController.GetInvoicesForBroadcasting(branch.BRBranchID);
                    foreach (ARInvoicesInfo objInvoicesInfo in invoices)
                    {
                        //Get invoice items
                        List<ARInvoiceItemsInfo> items = objInvoiceItemsController.GetItemsByInvoiceID(objInvoicesInfo.ARInvoiceID);
                        objInvoicesInfo.InvoiceItems = new BOSList<ARInvoiceItemsInfo>(TableName.ARInvoiceItemsTableName);
                        objInvoicesInfo.InvoiceItems.Invalidate(items);

                        foreach (ARInvoiceItemsInfo objInvoiceItemsInfo in objInvoicesInfo.InvoiceItems)
                        {
                            List<ARInvoiceItemComponentsInfo> components = objInvoiceItemComponentsController.GetInvoiceItemComponentListByInvoiceItemID(objInvoiceItemsInfo.ARInvoiceItemID);
                            objInvoiceItemsInfo.InvoiceItemComponentList = new BOSList<ARInvoiceItemComponentsInfo>(TableName.ARInvoiceItemComponentsTableName);
                            objInvoiceItemsInfo.InvoiceItemComponentList.Invalidate(components);
                        }
                    }
                    #endregion

                    #region Get cancel vouchers at local
                    ARCancelVouchersController objCancelVouchersController = new ARCancelVouchersController();
                    ARCancelVoucherItemsController objCancelVoucherItemsController = new ARCancelVoucherItemsController();
                    List<ARCancelVouchersInfo> cancelVouchers = objCancelVouchersController.GetCancelVouchersForBroadcasting(branch.BRBranchID);
                    foreach (ARCancelVouchersInfo objCancelVouchersInfo in cancelVouchers)
                    {
                        objCancelVouchersInfo.CancelVoucherItems = new BOSList<ARCancelVoucherItemsInfo>(TableName.ARCancelVoucherItemsTableName);
                        DataSet ds = objCancelVoucherItemsController.GetAllDataByForeignColumn("FK_ARCancelVoucherID", objCancelVouchersInfo.ARCancelVoucherID);
                        objCancelVouchersInfo.CancelVoucherItems.Invalidate(ds);
                    }
                    #endregion

                    #region Get sale returns at local
                    ARSaleReturnsController objSaleReturnsController = new ARSaleReturnsController();
                    ARSaleReturnItemsController objSaleReturnItemsController = new ARSaleReturnItemsController();
                    List<ARSaleReturnsInfo> saleReturns = objSaleReturnsController.GetSaleReturnsForBroadcasting(branch.BRBranchID);
                    foreach (ARSaleReturnsInfo objSaleReturnsInfo in saleReturns)
                    {
                        objSaleReturnsInfo.SaleReturnItems = new BOSList<ARSaleReturnItemsInfo>(TableName.ARSaleReturnItemsTableName);
                        List<ARSaleReturnItemsInfo> items = objSaleReturnItemsController.GetItemsBySaleReturnID(objSaleReturnsInfo.ARSaleReturnID);
                        objSaleReturnsInfo.SaleReturnItems.Invalidate(items);
                    }
                    #endregion

                    #region Get customer payments at local
                    ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
                    ARDocumentPaymentsController objDocumentPaymentsController = new ARDocumentPaymentsController();
                    ARCustomerPaymentDetailsController objCustomerPaymentDetailsController = new ARCustomerPaymentDetailsController();
                    ARCustomerPaymentCurrencysController objCustomerPaymentCurrencysController = new ARCustomerPaymentCurrencysController();
                    List<ARCustomerPaymentsInfo> customerPayments = objCustomerPaymentsController.GetCustomerPaymentsForBroadcasting(branch.BRBranchID);
                    foreach (ARCustomerPaymentsInfo objCustomerPaymentsInfo in customerPayments)
                    {
                        objCustomerPaymentsInfo.PaymentDetails = new BOSList<ARCustomerPaymentDetailsInfo>(TableName.ARCustomerPaymentDetailsTableName);
                        DataSet ds = objCustomerPaymentDetailsController.GetAllDataByForeignColumn("FK_ARCustomerPaymentID", objCustomerPaymentsInfo.ARCustomerPaymentID);
                        objCustomerPaymentsInfo.PaymentDetails.Invalidate(ds);

                        //Get payments by currencies of payment details                            
                        foreach (ARCustomerPaymentDetailsInfo objCustomerPaymentDetailsInfo in objCustomerPaymentsInfo.PaymentDetails)
                        {
                            objCustomerPaymentDetailsInfo.PaymentCurrencys = new BOSList<ARCustomerPaymentCurrencysInfo>(TableName.ARCustomerPaymentCurrencysTableName);
                            ds = objCustomerPaymentCurrencysController.GetAllDataByForeignColumn("FK_ARCustomerPaymentDetailID", objCustomerPaymentDetailsInfo.ARCustomerPaymentDetailID);
                            objCustomerPaymentDetailsInfo.PaymentCurrencys.Invalidate(ds);
                        }

                        //Get document payments
                        objCustomerPaymentsInfo.DocumentPayments = new BOSList<ARDocumentPaymentsInfo>(TableName.ARDocumentPaymentsTableName);
                        List<ARDocumentPaymentsInfo> documentPayments = objDocumentPaymentsController.GetDocumentPaymentsByCustomerPaymentID(objCustomerPaymentsInfo.ARCustomerPaymentID);
                        objCustomerPaymentsInfo.DocumentPayments.Invalidate(documentPayments);
                    }

                    //Get open documents
                    AROpenDocumentsController objOpenDocumentsController = new AROpenDocumentsController();
                    List<AROpenDocumentsInfo> openDocuments = objOpenDocumentsController.GetOpenDocumentsForBroadcasting(branch.BRBranchID);
                    #endregion

                    bool isCompleted = false;
                    string log = string.Empty;
                    try
                    {
                        BOSApp.SwitchConnection(branch.BRBranchID);
                        if (BOSApp.TestCurrentConnection())
                        {
                            #region Transfer sale orders
                            foreach (ARSaleOrdersInfo objSaleOrdersInfo in saleOrders)
                            {
                                ARSaleOrdersInfo branchSaleOrder = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByNo(objSaleOrdersInfo.ARSaleOrderNo);
                                int branchSaleOrderID = 0;
                                if (branchSaleOrder != null)
                                {
                                    branchSaleOrderID = branchSaleOrder.ARSaleOrderID;
                                    branchSaleOrder = (ARSaleOrdersInfo)objSaleOrdersInfo.Clone();
                                    branchSaleOrder.ARSaleOrderID = branchSaleOrderID;
                                    branchSaleOrder.FK_ARCustomerID = 0;
                                    ARCustomersInfo branchCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objSaleOrdersInfo.ARCustomerNo);
                                    if (branchCustomer != null)
                                    {
                                        branchSaleOrder.FK_ARCustomerID = branchCustomer.ARCustomerID;
                                    }
                                    branchSaleOrder.IsTransferred = true;
                                    branchSaleOrder.ARSaleOrderTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    branchSaleOrderID = objSaleOrdersController.UpdateObject(branchSaleOrder);
                                }
                                else
                                {
                                    branchSaleOrder = (ARSaleOrdersInfo)objSaleOrdersInfo.Clone();
                                    branchSaleOrder.FK_ARCustomerID = 0;
                                    ARCustomersInfo branchCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objSaleOrdersInfo.ARCustomerNo);
                                    if (branchCustomer != null)
                                    {
                                        branchSaleOrder.FK_ARCustomerID = branchCustomer.ARCustomerID;
                                    }
                                    branchSaleOrder.IsTransferred = true;
                                    branchSaleOrder.ARSaleOrderTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    branchSaleOrder.AAUpdatedDate = DateTime.MaxValue;
                                    branchSaleOrderID = objSaleOrdersController.CreateObject(branchSaleOrder);
                                }

                                if (branchSaleOrderID > 0)
                                {
                                    //Transfer invoice items
                                    TransferSaleOrderItemsToCentre(objSaleOrdersInfo.SaleOrderItems, branchSaleOrderID);
                                    if (!transferredSaleOrders.Exists(so => so.ARSaleOrderID == objSaleOrdersInfo.ARSaleOrderID))
                                    {
                                        transferredSaleOrders.Add(objSaleOrdersInfo);
                                    }
                                }
                            }
                            #endregion

                            #region Transfer invoices
                            foreach (ARInvoicesInfo objInvoicesInfo in invoices)
                            {
                                ARInvoicesInfo branchInvoice = (ARInvoicesInfo)objInvoicesController.GetObjectByNo(objInvoicesInfo.ARInvoiceNo);
                                int branchInvoiceID = 0;
                                if (branchInvoice != null)
                                {
                                    branchInvoiceID = branchInvoice.ARInvoiceID;
                                    branchInvoice = (ARInvoicesInfo)objInvoicesInfo.Clone();
                                    branchInvoice.ARInvoiceID = branchInvoiceID;
                                    branchInvoice.FK_ARCustomerID = 0;
                                    ARCustomersInfo branchCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objInvoicesInfo.ARCustomerNo);
                                    if (branchCustomer != null)
                                    {
                                        branchInvoice.FK_ARCustomerID = branchCustomer.ARCustomerID;
                                    }
                                    branchInvoice.IsTransferred = true;
                                    branchInvoice.ARInvoiceTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    branchInvoiceID = objInvoicesController.UpdateObject(branchInvoice);
                                }
                                else
                                {
                                    branchInvoice = (ARInvoicesInfo)objInvoicesInfo.Clone();
                                    branchInvoice.FK_ARCustomerID = 0;
                                    ARCustomersInfo branchCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objInvoicesInfo.ARCustomerNo);
                                    if (branchCustomer != null)
                                    {
                                        branchInvoice.FK_ARCustomerID = branchCustomer.ARCustomerID;
                                    }
                                    branchInvoice.IsTransferred = true;
                                    branchInvoice.ARInvoiceTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    branchInvoice.AAUpdatedDate = DateTime.MaxValue;
                                    branchInvoiceID = objInvoicesController.CreateObject(branchInvoice);
                                }

                                if (branchInvoiceID > 0)
                                {
                                    TransferInvoiceItemsToCentre(objInvoicesInfo.InvoiceItems, branchInvoiceID);
                                    if (!transferredInvoices.Exists(i => i.ARInvoiceID == objInvoicesInfo.ARInvoiceID))
                                    {
                                        transferredInvoices.Add(objInvoicesInfo);
                                    }
                                }
                            }
                            #endregion

                            #region Transfer cancel vouchers
                            foreach (ARCancelVouchersInfo objCancelVouchersInfo in cancelVouchers)
                            {
                                int branchCancelVoucherID = 0;
                                ARCancelVouchersInfo branchCancelVoucher = (ARCancelVouchersInfo)objCancelVouchersController.GetObjectByNo(objCancelVouchersInfo.ARCancelVoucherNo);
                                if (branchCancelVoucher != null)
                                {
                                    branchCancelVoucherID = branchCancelVoucher.ARCancelVoucherID;
                                    int branchSaleOrderID = branchCancelVoucher.FK_ARSaleOrderID;
                                    branchCancelVoucher = (ARCancelVouchersInfo)objCancelVouchersInfo.Clone();
                                    branchCancelVoucher.ARCancelVoucherID = branchCancelVoucherID;
                                    branchCancelVoucher.FK_ARCustomerID = 0;
                                    ARCustomersInfo branchCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objCancelVouchersInfo.ARCustomerNo);
                                    if (branchCustomer != null)
                                    {
                                        branchCancelVoucher.FK_ARCustomerID = branchCustomer.ARCustomerID;
                                    }
                                    branchCancelVoucher.FK_ARSaleOrderID = branchSaleOrderID;
                                    branchCancelVoucher.IsTransferred = true;
                                    branchCancelVoucher.ARCancelVoucherTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    objCancelVouchersController.UpdateObject(branchCancelVoucher);
                                }
                                else
                                {
                                    branchCancelVoucher = (ARCancelVouchersInfo)objCancelVouchersInfo.Clone();
                                    branchCancelVoucher.FK_ARCustomerID = 0;
                                    ARCustomersInfo branchCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objCancelVouchersInfo.ARCustomerNo);
                                    if (branchCustomer != null)
                                    {
                                        branchCancelVoucher.FK_ARCustomerID = branchCustomer.ARCustomerID;
                                    }

                                    ARSaleOrdersInfo refSaleOrder = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByNo(objCancelVouchersInfo.ARSaleOrderNo);
                                    if (refSaleOrder != null)
                                    {
                                        branchCancelVoucher.FK_ARSaleOrderID = refSaleOrder.ARSaleOrderID;
                                    }
                                    branchCancelVoucher.IsTransferred = true;
                                    branchCancelVoucher.ARCancelVoucherTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    branchCancelVoucher.AAUpdatedDate = DateTime.MaxValue;
                                    branchCancelVoucherID = objCancelVouchersController.CreateObject(branchCancelVoucher);
                                }

                                if (branchCancelVoucherID > 0)
                                {
                                    TransferCancelVoucherItemsToCentre(objCancelVouchersInfo.CancelVoucherItems, branchCancelVoucherID);
                                    if (!transferredCancelVouchers.Exists(cv => cv.ARCancelVoucherID == objCancelVouchersInfo.ARCancelVoucherID))
                                    {
                                        transferredCancelVouchers.Add(objCancelVouchersInfo);
                                    }
                                }
                            }
                            #endregion

                            #region Transfer sale returns
                            foreach (ARSaleReturnsInfo objSaleReturnsInfo in saleReturns)
                            {
                                int branchSaleReturnID = 0;
                                ARSaleReturnsInfo branchSaleReturn = (ARSaleReturnsInfo)objSaleReturnsController.GetObjectByNo(objSaleReturnsInfo.ARSaleReturnNo);
                                if (branchSaleReturn != null)
                                {
                                    branchSaleReturnID = branchSaleReturn.ARSaleReturnID;
                                    int branchInvoiceID = branchSaleReturn.FK_ARInvoiceID;
                                    branchSaleReturn = (ARSaleReturnsInfo)objSaleReturnsInfo.Clone();
                                    branchSaleReturn.ARSaleReturnID = branchSaleReturnID;
                                    branchSaleReturn.FK_ARCustomerID = 0;
                                    ARCustomersInfo branchCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objSaleReturnsInfo.ARCustomerNo);
                                    if (branchCustomer != null)
                                    {
                                        branchSaleReturn.FK_ARCustomerID = branchCustomer.ARCustomerID;
                                    }
                                    branchSaleReturn.FK_ARInvoiceID = branchInvoiceID;
                                    branchSaleReturn.IsTransferred = true;
                                    branchSaleReturn.ARSaleReturnTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    objSaleReturnsController.UpdateObject(branchSaleReturn);
                                }
                                else
                                {
                                    branchSaleReturn = (ARSaleReturnsInfo)objSaleReturnsInfo.Clone();
                                    branchSaleReturn.FK_ARCustomerID = 0;
                                    ARCustomersInfo branchCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objSaleReturnsInfo.ARCustomerNo);
                                    if (branchCustomer != null)
                                    {
                                        branchSaleReturn.FK_ARCustomerID = branchCustomer.ARCustomerID;
                                    }

                                    ARInvoicesInfo refInvoice = (ARInvoicesInfo)objInvoicesController.GetObjectByNo(objSaleReturnsInfo.ARInvoiceNo);
                                    if (refInvoice != null)
                                    {
                                        branchSaleReturn.FK_ARInvoiceID = refInvoice.ARInvoiceID;
                                    }
                                    branchSaleReturn.IsTransferred = true;
                                    branchSaleReturn.ARSaleReturnTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    branchSaleReturn.AAUpdatedDate = DateTime.MaxValue;
                                    branchSaleReturnID = objSaleReturnsController.CreateObject(branchSaleReturn);
                                }

                                if (branchSaleReturnID > 0)
                                {
                                    TransferSaleReturnItemsToCentre(objSaleReturnsInfo.SaleReturnItems, branchSaleReturnID);
                                    if (!transferredSaleReturns.Exists(sr => sr.ARSaleReturnID == objSaleReturnsInfo.ARSaleReturnID))
                                    {
                                        transferredSaleReturns.Add(objSaleReturnsInfo);
                                    }
                                }
                            }
                            #endregion

                            #region Transfer customer payments
                            TransferOpenDocumentsToBranch(openDocuments, ref transferredOpenDocuments);

                            TransferCustomerPaymentsToBranch(customerPayments, ref transferredCustomerPayments);
                            #endregion

                            isCompleted = true;
                        }
                        else
                        {
                            log = string.Format(DataExchangeLocalizedResources.CannotConnectToBranch, branch.BRBranchName);
                        }
                    }
                    catch (Exception ex)
                    {
                        log = ex.Message;
                    }
                    finally
                    {
                        BOSApp.RollbackLocalConnection();

                        if (isCompleted)
                        {
                            count++;
                            branch.BRBranchTransferMessage = DataExchangeLocalizedResources.TransferDoneMessage;
                        }
                        else
                        {
                            branch.BRBranchTransferMessage = log;
                        }
                    }
                }
            }

            UpdateLocalSaleOrderStatus(transferredSaleOrders);
            UpdateLocalInvoiceStatus(transferredInvoices);
            UpdateLocalCancelVoucherStatus(transferredCancelVouchers);
            UpdateLocalSaleReturnStatus(transferredSaleReturns);
            UpdateLocalOpenDocumentStatus(transferredOpenDocuments);
            UpdateLocalCustomerPaymentStatus(transferredCustomerPayments);

            BOSProgressBar.Close();
        }

        private void TransferOpenDocumentsToBranch(List<AROpenDocumentsInfo> openDocuments, ref List<AROpenDocumentsInfo> transferredOpenDocuments)
        {
            AROpenDocumentsController objOpenDocumentsController = new AROpenDocumentsController();
            ARCustomersController objCustomersController = new ARCustomersController();
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            foreach (AROpenDocumentsInfo objOpenDocumentsInfo in openDocuments)
            {
                AROpenDocumentsInfo branchOpenDocument = (AROpenDocumentsInfo)objOpenDocumentsController.GetObjectByNo(objOpenDocumentsInfo.AROpenDocumentNo);
                if (branchOpenDocument != null)
                {
                    int branchOpenDocumentID = branchOpenDocument.AROpenDocumentID;
                    int branchInvoiceID = branchOpenDocument.FK_ARInvoiceID;
                    branchOpenDocument = (AROpenDocumentsInfo)objOpenDocumentsInfo.Clone();
                    branchOpenDocument.AROpenDocumentID = branchOpenDocumentID;
                    branchOpenDocument.FK_ARCustomerID = 0;
                    ARCustomersInfo branchCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objOpenDocumentsInfo.ARCustomerNo);
                    if (branchCustomer != null)
                    {
                        branchOpenDocument.FK_ARCustomerID = branchCustomer.ARCustomerID;
                    }
                    branchOpenDocument.FK_ARInvoiceID = branchInvoiceID;
                    branchOpenDocument.IsTransferred = true;
                    branchOpenDocument.AROpenDocumentTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                    objOpenDocumentsController.UpdateObject(branchOpenDocument);
                }
                else
                {
                    branchOpenDocument = (AROpenDocumentsInfo)objOpenDocumentsInfo.Clone();
                    branchOpenDocument.FK_ARCustomerID = 0;
                    ARCustomersInfo branchCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objOpenDocumentsInfo.ARCustomerNo);
                    if (branchCustomer != null)
                    {
                        branchOpenDocument.FK_ARCustomerID = branchCustomer.ARCustomerID;
                    }

                    branchOpenDocument.FK_ARInvoiceID = 0;
                    if (!string.IsNullOrEmpty(objOpenDocumentsInfo.ARInvoiceNo))
                    {
                        ARInvoicesInfo branchInvoice = (ARInvoicesInfo)objInvoicesController.GetObjectByNo(objOpenDocumentsInfo.ARInvoiceNo);
                        if (branchInvoice != null)
                        {
                            branchOpenDocument.FK_ARInvoiceID = branchInvoice.ARInvoiceID;
                        }
                    }
                    branchOpenDocument.IsTransferred = true;
                    branchOpenDocument.AROpenDocumentTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                    branchOpenDocument.AAUpdatedDate = DateTime.MaxValue;
                    objOpenDocumentsController.CreateObject(branchOpenDocument);
                }

                if (!transferredOpenDocuments.Exists(d => d.AROpenDocumentID == objOpenDocumentsInfo.AROpenDocumentID))
                {
                    transferredOpenDocuments.Add(objOpenDocumentsInfo);
                }
            }
        }

        private void TransferCustomerPaymentsToBranch(List<ARCustomerPaymentsInfo> customerPayments, ref List<ARCustomerPaymentsInfo> transferredCustomerPayments)
        {
            ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
            ARCustomerPaymentDetailsController objCustomerPaymentDetailsController = new ARCustomerPaymentDetailsController();
            ARCustomerPaymentCurrencysController objCustomerPaymentCurrencysController = new ARCustomerPaymentCurrencysController();
            ARDocumentPaymentsController objDocumentPaymentsController = new ARDocumentPaymentsController();
            ARCustomersController objCustomersController = new ARCustomersController();
            AROpenDocumentsController objOpenDocumentsController = new AROpenDocumentsController();
            foreach (ARCustomerPaymentsInfo objCustomerPaymentsInfo in customerPayments)
            {
                ARCustomerPaymentsInfo branchCustomerPayment = (ARCustomerPaymentsInfo)objCustomerPaymentsController.GetObjectByNo(objCustomerPaymentsInfo.ARCustomerPaymentNo);
                int branchCustomerPaymentID = 0;
                if (branchCustomerPayment != null)
                {
                    branchCustomerPaymentID = branchCustomerPayment.ARCustomerPaymentID;
                    branchCustomerPayment = (ARCustomerPaymentsInfo)objCustomerPaymentsInfo.Clone();
                    branchCustomerPayment.ARCustomerPaymentID = branchCustomerPaymentID;
                    branchCustomerPayment.FK_ARCustomerID = 0;
                    ARCustomersInfo branchCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objCustomerPaymentsInfo.ARCustomerNo);
                    if (branchCustomer != null)
                    {
                        branchCustomerPayment.FK_ARCustomerID = branchCustomer.ARCustomerID;
                    }
                    branchCustomerPayment.IsTransferred = true;
                    branchCustomerPayment.ARCustomerPaymentTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                    branchCustomerPaymentID = objCustomerPaymentsController.UpdateObject(branchCustomerPayment);
                }
                else
                {
                    branchCustomerPayment = (ARCustomerPaymentsInfo)objCustomerPaymentsInfo.Clone();
                    branchCustomerPayment.FK_ARCustomerID = 0;
                    ARCustomersInfo branchCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objCustomerPaymentsInfo.ARCustomerNo);
                    if (branchCustomer != null)
                    {
                        branchCustomerPayment.FK_ARCustomerID = branchCustomer.ARCustomerID;
                    }
                    branchCustomerPayment.IsTransferred = true;
                    branchCustomerPayment.ARCustomerPaymentTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                    branchCustomerPayment.AAUpdatedDate = DateTime.MaxValue;
                    branchCustomerPaymentID = objCustomerPaymentsController.CreateObject(branchCustomerPayment);
                }

                //Delete all relative data of the payment
                objCustomerPaymentDetailsController.DeleteByCustomerPaymentID(branchCustomerPaymentID);

                //Transfer payment details                                
                foreach (ARCustomerPaymentDetailsInfo objCustomerPaymentDetailsInfo in objCustomerPaymentsInfo.PaymentDetails)
                {
                    objCustomerPaymentDetailsInfo.FK_ARCustomerPaymentID = branchCustomerPaymentID;
                    objCustomerPaymentDetailsController.CreateObject(objCustomerPaymentDetailsInfo);

                    //Transfer payments by currencies of the payment details
                    foreach (ARCustomerPaymentCurrencysInfo objCustomerPaymentCurrencysInfo in objCustomerPaymentDetailsInfo.PaymentCurrencys)
                    {
                        objCustomerPaymentCurrencysInfo.FK_ARCustomerPaymentDetailID = objCustomerPaymentDetailsInfo.ARCustomerPaymentDetailID;
                        objCustomerPaymentCurrencysController.CreateObject(objCustomerPaymentCurrencysInfo);
                    }
                }

                //Transfer document payments
                foreach (ARDocumentPaymentsInfo objDocumentPaymentsInfo in objCustomerPaymentsInfo.DocumentPayments)
                {
                    ARDocumentPaymentsInfo branchDocumentPayment = (ARDocumentPaymentsInfo)objDocumentPaymentsInfo.Clone();
                    branchDocumentPayment.FK_ARCustomerPaymentID = branchCustomerPaymentID;
                    branchDocumentPayment.FK_AROpenDocumentID = 0;
                    AROpenDocumentsInfo branchOpenDocument = (AROpenDocumentsInfo)objOpenDocumentsController.GetObjectByNo(objDocumentPaymentsInfo.AROpenDocumentNo);
                    if (branchOpenDocument != null)
                    {
                        branchDocumentPayment.FK_AROpenDocumentID = branchOpenDocument.AROpenDocumentID;
                    }
                    objDocumentPaymentsController.CreateObject(branchDocumentPayment);
                }

                if (!transferredCustomerPayments.Exists(cp => cp.ARCustomerPaymentID == objCustomerPaymentsInfo.ARCustomerPaymentID))
                {
                    transferredCustomerPayments.Add(objCustomerPaymentsInfo);
                }
            }
        }

        private void TransferPurchaseData()
        {
            DataExchangeEntities entity = (DataExchangeEntities)CurrentModuleEntity;
            List<APInvoiceInsInfo> transferredInvoices = new List<APInvoiceInsInfo>();
            List<APOpenDocumentsInfo> transferredOpenDocuments = new List<APOpenDocumentsInfo>();
            List<APSupplierPaymentsInfo> transferredSupplierPayments = new List<APSupplierPaymentsInfo>();
            foreach (BRBranchsInfo branch in entity.BRBranchsList)
            {
                if (branch.Selected)
                {
                    APSuppliersController objSuppliersController = new APSuppliersController();

                    #region Get invoices at local
                    APInvoiceInsController objInvoicesController = new APInvoiceInsController();
                    APInvoiceInItemsController objInvoiceItemsController = new APInvoiceInItemsController();
                    List<APInvoiceInsInfo> invoices = objInvoicesController.GetInvoicesForBroadcasting(branch.BRBranchID);
                    foreach (APInvoiceInsInfo objInvoicesInfo in invoices)
                    {
                        //Get invoice items
                        objInvoicesInfo.InvoiceItems = objInvoiceItemsController.GetItemsByInvoiceID(objInvoicesInfo.APInvoiceInID);
                    }
                    #endregion

                    #region Get supplier payments at local
                    APSupplierPaymentsController objSupplierPaymentsController = new APSupplierPaymentsController();
                    APDocumentPaymentsController objDocumentPaymentsController = new APDocumentPaymentsController();
                    APSupplierPaymentDetailsController objSupplierPaymentDetailsController = new APSupplierPaymentDetailsController();
                    List<APSupplierPaymentsInfo> supplierPayments = objSupplierPaymentsController.GetSupplierPaymentsForBroadcasting(branch.BRBranchID);
                    foreach (APSupplierPaymentsInfo objSupplierPaymentsInfo in supplierPayments)
                    {
                        //Get payment details
                        objSupplierPaymentsInfo.PaymentDetails = objSupplierPaymentDetailsController.GetDetailsByPaymentID(objSupplierPaymentsInfo.APSupplierPaymentID);

                        //Get document payments
                        objSupplierPaymentsInfo.DocumentPayments = objDocumentPaymentsController.GetDocumentPaymentsBySupplierPaymentID(objSupplierPaymentsInfo.APSupplierPaymentID);
                    }

                    //Get open documents
                    APOpenDocumentsController objOpenDocumentsController = new APOpenDocumentsController();
                    List<APOpenDocumentsInfo> openDocuments = objOpenDocumentsController.GetOpenDocumentsForBroadcasting(branch.BRBranchID);
                    #endregion

                    bool isCompleted = false;
                    string log = string.Empty;
                    try
                    {
                        BOSApp.SwitchConnection(branch.BRBranchID);
                        if (BOSApp.TestCurrentConnection())
                        {
                            #region Transfer invoices
                            foreach (APInvoiceInsInfo objInvoicesInfo in invoices)
                            {
                                APInvoiceInsInfo branchInvoice = (APInvoiceInsInfo)objInvoicesController.GetObjectByNo(objInvoicesInfo.APInvoiceInNo);
                                int branchInvoiceID = 0;
                                if (branchInvoice != null)
                                {
                                    branchInvoiceID = branchInvoice.APInvoiceInID;
                                    branchInvoice = (APInvoiceInsInfo)objInvoicesInfo.Clone();
                                    branchInvoice.APInvoiceInID = branchInvoiceID;
                                    branchInvoice.APInvoiceInTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    branchInvoiceID = objInvoicesController.UpdateObject(branchInvoice);
                                }
                                else
                                {
                                    branchInvoice = (APInvoiceInsInfo)objInvoicesInfo.Clone();
                                    branchInvoice.AAUpdatedDate = DateTime.MaxValue;
                                    branchInvoiceID = objInvoicesController.CreateObject(branchInvoice);
                                }

                                if (branchInvoiceID > 0)
                                {
                                    TransferInvoiceItemsToCentre(objInvoicesInfo.InvoiceItems, branchInvoiceID);
                                    if (!transferredInvoices.Exists(i => i.APInvoiceInID == objInvoicesInfo.APInvoiceInID))
                                    {
                                        transferredInvoices.Add(objInvoicesInfo);
                                    }
                                }
                            }
                            #endregion

                            #region Transfer supplier payments
                            TransferOpenDocumentsToBranch(openDocuments, ref transferredOpenDocuments);

                            TransferSupplierPaymentsToBranch(supplierPayments, ref transferredSupplierPayments);
                            #endregion

                            isCompleted = true;
                        }
                        else
                        {
                            log = string.Format(DataExchangeLocalizedResources.CannotConnectToBranch, branch.BRBranchName);
                        }
                    }
                    catch (Exception ex)
                    {
                        log = ex.Message;
                    }
                    finally
                    {
                        BOSApp.RollbackLocalConnection();

                        if (isCompleted)
                        {
                            branch.BRBranchTransferMessage = DataExchangeLocalizedResources.TransferDoneMessage;
                        }
                        else
                        {
                            branch.BRBranchTransferMessage = log;
                        }
                    }
                }
            }

            //Update purchase data at local
            UpdateLocalInvoiceStatus(transferredInvoices);
            UpdateLocalOpenDocumentStatus(transferredOpenDocuments);
            UpdateLocalSupplierPaymentStatus(transferredSupplierPayments);

            BOSProgressBar.Close();
        }

        /// <summary>
        /// Transfer open documents to the centre
        /// </summary>
        /// <param name="openDocuments">Transferred open documents</param>
        private void TransferOpenDocumentsToBranch(List<APOpenDocumentsInfo> openDocuments, ref List<APOpenDocumentsInfo> transferredOpenDocuments)
        {
            APOpenDocumentsController objOpenDocumentsController = new APOpenDocumentsController();
            APSuppliersController objSuppliersController = new APSuppliersController();
            APInvoiceInsController objInvoicesController = new APInvoiceInsController();
            foreach (APOpenDocumentsInfo objOpenDocumentsInfo in openDocuments)
            {
                APOpenDocumentsInfo branchOpenDocument = (APOpenDocumentsInfo)objOpenDocumentsController.GetObjectByNo(objOpenDocumentsInfo.APOpenDocumentNo);
                if (branchOpenDocument != null)
                {
                    int branchOpenDocumentID = branchOpenDocument.APOpenDocumentID;
                    int branchInvoiceID = branchOpenDocument.FK_APInvoiceInID;
                    branchOpenDocument = (APOpenDocumentsInfo)objOpenDocumentsInfo.Clone();
                    branchOpenDocument.APOpenDocumentID = branchOpenDocumentID;
                    branchOpenDocument.FK_APInvoiceInID = branchInvoiceID;
                    branchOpenDocument.APOpenDocumentTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                    objOpenDocumentsController.UpdateObject(branchOpenDocument);
                }
                else
                {
                    branchOpenDocument = (APOpenDocumentsInfo)objOpenDocumentsInfo.Clone();
                    branchOpenDocument.FK_APInvoiceInID = 0;
                    if (!string.IsNullOrEmpty(objOpenDocumentsInfo.APInvoiceInNo))
                    {
                        APInvoiceInsInfo branchInvoice = (APInvoiceInsInfo)objInvoicesController.GetObjectByNo(objOpenDocumentsInfo.APInvoiceInNo);
                        if (branchInvoice != null)
                        {
                            branchOpenDocument.FK_APInvoiceInID = branchInvoice.APInvoiceInID;
                        }
                    }
                    branchOpenDocument.AAUpdatedDate = DateTime.MaxValue;
                    objOpenDocumentsController.CreateObject(branchOpenDocument);
                }

                if (!transferredOpenDocuments.Exists(d => d.APOpenDocumentID == objOpenDocumentsInfo.APOpenDocumentID))
                {
                    transferredOpenDocuments.Add(objOpenDocumentsInfo);
                }
            }
        }

        /// <summary>
        /// Transfer payments to the centre
        /// </summary>
        /// <param name="supplierPayments">Transferred payments</param>
        private void TransferSupplierPaymentsToBranch(List<APSupplierPaymentsInfo> supplierPayments, ref List<APSupplierPaymentsInfo> transferredSupplierPayments)
        {
            APSupplierPaymentsController objSupplierPaymentsController = new APSupplierPaymentsController();
            APSupplierPaymentDetailsController objSupplierPaymentDetailsController = new APSupplierPaymentDetailsController();
            APDocumentPaymentsController objDocumentPaymentsController = new APDocumentPaymentsController();
            APSuppliersController objSuppliersController = new APSuppliersController();
            APOpenDocumentsController objOpenDocumentsController = new APOpenDocumentsController();
            foreach (APSupplierPaymentsInfo objSupplierPaymentsInfo in supplierPayments)
            {
                APSupplierPaymentsInfo branchSupplierPayment = (APSupplierPaymentsInfo)objSupplierPaymentsController.GetObjectByNo(objSupplierPaymentsInfo.APSupplierPaymentNo);
                int branchSupplierPaymentID = 0;
                if (branchSupplierPayment != null)
                {
                    branchSupplierPaymentID = branchSupplierPayment.APSupplierPaymentID;
                    branchSupplierPayment = (APSupplierPaymentsInfo)objSupplierPaymentsInfo.Clone();
                    branchSupplierPayment.APSupplierPaymentID = branchSupplierPaymentID;
                    branchSupplierPayment.APSupplierPaymentTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                    branchSupplierPaymentID = objSupplierPaymentsController.UpdateObject(branchSupplierPayment);
                }
                else
                {
                    branchSupplierPayment = (APSupplierPaymentsInfo)objSupplierPaymentsInfo.Clone();
                    branchSupplierPayment.AAUpdatedDate = DateTime.MaxValue;
                    branchSupplierPaymentID = objSupplierPaymentsController.CreateObject(branchSupplierPayment);
                }

                //Delete all relative data of the payment
                objSupplierPaymentDetailsController.DeleteBySupplierPaymentID(branchSupplierPaymentID);

                //Transfer payment details                                
                foreach (APSupplierPaymentDetailsInfo objSupplierPaymentDetailsInfo in objSupplierPaymentsInfo.PaymentDetails)
                {
                    objSupplierPaymentDetailsInfo.FK_APSupplierPaymentID = branchSupplierPaymentID;
                    objSupplierPaymentDetailsController.CreateObject(objSupplierPaymentDetailsInfo);
                }

                //Transfer document payments
                foreach (APDocumentPaymentsInfo objDocumentPaymentsInfo in objSupplierPaymentsInfo.DocumentPayments)
                {
                    APDocumentPaymentsInfo branchDocumentPayment = (APDocumentPaymentsInfo)objDocumentPaymentsInfo.Clone();
                    branchDocumentPayment.FK_APSupplierPaymentID = branchSupplierPaymentID;
                    branchDocumentPayment.FK_APOpenDocumentID = 0;
                    APOpenDocumentsInfo branchOpenDocument = (APOpenDocumentsInfo)objOpenDocumentsController.GetObjectByNo(objDocumentPaymentsInfo.APOpenDocumentNo);
                    if (branchOpenDocument != null)
                    {
                        branchDocumentPayment.FK_APOpenDocumentID = branchOpenDocument.APOpenDocumentID;
                    }
                    objDocumentPaymentsController.CreateObject(branchDocumentPayment);
                }

                if (!transferredSupplierPayments.Exists(sp => sp.APSupplierPaymentID == objSupplierPaymentsInfo.APSupplierPaymentID))
                {
                    transferredSupplierPayments.Add(objSupplierPaymentsInfo);
                }
            }
        }

        /// <summary>
        /// Transfer accounting data from the centre to branches
        /// </summary>
        public void TransferAccountingData()
        {
            DataExchangeEntities entity = (DataExchangeEntities)CurrentModuleEntity;
            int count = 0;
            List<ICReceiptsInfo> transferredReceipts = new List<ICReceiptsInfo>();
            List<ICShipmentsInfo> transferredShipments = new List<ICShipmentsInfo>();
            List<ICTransfersInfo> transferredStockTransfers = new List<ICTransfersInfo>();
            List<ARReceiptVouchersInfo> transferredReceiptVouchers = new List<ARReceiptVouchersInfo>();
            List<APPaymentVouchersInfo> transferredPaymentVouchers = new List<APPaymentVouchersInfo>();
            List<ACBankTransactionsInfo> transferredBankTransactions = new List<ACBankTransactionsInfo>();
            List<ACAssetsInfo> transferredAssets = new List<ACAssetsInfo>();
            List<ACAssetReceiptsInfo> transferredAssetReceipts = new List<ACAssetReceiptsInfo>();
            List<ICShipmentsInfo> transferredEquipmentShipments = new List<ICShipmentsInfo>();
            List<ACDocumentsInfo> transferredDocuments = new List<ACDocumentsInfo>();
            foreach (BRBranchsInfo branch in entity.BRBranchsList)
            {
                if (branch.Selected)
                {
                    BOSProgressBar.Start(String.Format(DataExchangeLocalizedResources.TransferringAccountingDataMessage, branch.BRBranchName));
                    ACObjectsController objObjectsController = new ACObjectsController();

                    #region Get receipts at local
                    ICReceiptsController objReceiptsController = new ICReceiptsController();
                    ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
                    List<ICReceiptsInfo> receipts = objReceiptsController.GetReceiptsForBroadcasting(branch.BRBranchID);
                    foreach (ICReceiptsInfo objReceiptsInfo in receipts)
                    {
                        objReceiptsInfo.ReceiptItems = new BOSList<ICReceiptItemsInfo>(TableName.ICReceiptItemsTableName);
                        List<ICReceiptItemsInfo> items = objReceiptItemsController.GetItemsByReceiptID(objReceiptsInfo.ICReceiptID);
                        objReceiptsInfo.ReceiptItems.Invalidate(items);
                    }
                    #endregion

                    #region Get shipments at local
                    ICShipmentsController objShipmentsController = new ICShipmentsController();
                    ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
                    List<ICShipmentsInfo> shipments = objShipmentsController.GetShipmentsForBroadcasting(branch.BRBranchID);
                    foreach (ICShipmentsInfo objShipmentsInfo in shipments)
                    {
                        objShipmentsInfo.ShipmentItems = new BOSList<ICShipmentItemsInfo>(TableName.ICShipmentItemsTableName);
                        List<ICShipmentItemsInfo> items = objShipmentItemsController.GetItemsByShipmentID(objShipmentsInfo.ICShipmentID);
                        objShipmentsInfo.ShipmentItems.Invalidate(items);
                    }
                    #endregion

                    #region Get transfers at local
                    ICTransfersController objTransfersController = new ICTransfersController();
                    ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
                    List<ICTransfersInfo> transfers = objTransfersController.GetTransfersForBroadcasting(branch.BRBranchID);
                    foreach (ICTransfersInfo transfer in transfers)
                    {
                        transfer.TransferItems = new BOSList<ICTransferItemsInfo>(TableName.ICTransferItemsTableName);
                        List<ICTransferItemsInfo> items = objTransferItemsController.GetTransferItemsByTransferID(transfer.ICTransferID);
                        transfer.TransferItems.Invalidate(items);
                    }
                    #endregion

                    #region Get budget at local
                    ARReceiptVouchersController objReceiptVouchersController = new ARReceiptVouchersController();
                    ARReceiptVoucherItemsController objReceiptVoucherItemsController = new ARReceiptVoucherItemsController();
                    List<ARReceiptVouchersInfo> receiptVouchers = objReceiptVouchersController.GetReceiptVouchersForBroadcasting(branch.BRBranchID);
                    foreach (ARReceiptVouchersInfo receiptVoucher in receiptVouchers)
                    {
                        receiptVoucher.ReceiptVoucherItems = objReceiptVoucherItemsController.GetItemsByReceiptVoucherID(receiptVoucher.ARReceiptVoucherID);
                    }

                    APPaymentVouchersController objPaymentVouchersController = new APPaymentVouchersController();
                    APPaymentVoucherItemsController objPaymentVoucherItemsController = new APPaymentVoucherItemsController();
                    List<APPaymentVouchersInfo> paymentVouchers = objPaymentVouchersController.GetPaymentVouchersForBroadcasting(branch.BRBranchID);
                    foreach (APPaymentVouchersInfo paymentVoucher in paymentVouchers)
                    {
                        paymentVoucher.PaymentVoucherItems = objPaymentVoucherItemsController.GetItemsByPaymentVoucherID(paymentVoucher.APPaymentVoucherID);
                    }
                    #endregion

                    #region Get bank transactions at local
                    ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
                    ACBankTransactionItemsController objBankTransactionItemsController = new ACBankTransactionItemsController();
                    List<ACBankTransactionsInfo> bankTransactions = objBankTransactionsController.GetBankTransactionsForBroadcasting(branch.BRBranchID);
                    foreach (ACBankTransactionsInfo bankTransaction in bankTransactions)
                    {
                        bankTransaction.BankTransactionItems = objBankTransactionItemsController.GetItemsByTransactionID(bankTransaction.ACBankTransactionID);
                    }
                    #endregion

                    #region Get asset data at local
                    ACAssetsController objAssetsController = new ACAssetsController();
                    List<ACAssetsInfo> assets = objAssetsController.GetAssetsForBroadcasting(branch.BRBranchID);

                    ACAssetReceiptsController objAssetReceiptsController = new ACAssetReceiptsController();
                    ACAssetReceiptItemsController objAssetReceiptItemsController = new ACAssetReceiptItemsController();
                    List<ACAssetReceiptsInfo> assetReceipts = objAssetReceiptsController.GetAssetReceiptsForBroadcasting(branch.BRBranchID);
                    foreach (ACAssetReceiptsInfo receipt in assetReceipts)
                    {
                        receipt.AssetReceiptItems = objAssetReceiptItemsController.GetItemsByAssetReceiptID(receipt.ACAssetReceiptID);
                    }

                    ACDocumentsController objDocumentsController = new ACDocumentsController();
                    ACAssetShipmentItemsController objAssetShipmentItemsController = new ACAssetShipmentItemsController();
                    List<ACDocumentsInfo> assetShipments = objDocumentsController.GetAssetShipmentsForBroadcasting(branch.BRBranchID);
                    foreach (ACDocumentsInfo assetShipment in assetShipments)
                    {
                        assetShipment.AssetShipmentItems = objAssetShipmentItemsController.GetItemsByDocumentID(assetShipment.ACDocumentID);
                    }

                    ACAssetTransferItemsController objAssetTransferItemsController = new ACAssetTransferItemsController();
                    List<ACDocumentsInfo> assetTransfers = objDocumentsController.GetAssetTransfersForBroadcasting(branch.BRBranchID);
                    foreach (ACDocumentsInfo assetTransfer in assetTransfers)
                    {
                        assetTransfer.AssetTransferItems = objAssetTransferItemsController.GetItemsByDocumentID(assetTransfer.ACDocumentID);
                    }
                    #endregion

                    #region Get equipment data at local
                    List<ICShipmentsInfo> equipmentShipments = objShipmentsController.GetEquipmentShipmentsForBroadcasting(branch.BRBranchID);
                    foreach (ICShipmentsInfo shipment in equipmentShipments)
                    {
                        List<ICShipmentItemsInfo> items = objShipmentItemsController.GetItemsByShipmentID(shipment.ICShipmentID);
                        shipment.ShipmentItems = new BOSList<ICShipmentItemsInfo>(TableName.ICShipmentItemsTableName);
                        shipment.ShipmentItems.Invalidate(items);
                    }

                    ACEquipmentTransferItemsController objEquipmentTransferItemsController = new ACEquipmentTransferItemsController();
                    List<ACDocumentsInfo> equipmentTransfers = objDocumentsController.GetEquipmentTransfersForBroadcasting(branch.BRBranchID);
                    foreach (ACDocumentsInfo equipmentTransfer in equipmentTransfers)
                    {
                        equipmentTransfer.EquipmentTransferItems = objEquipmentTransferItemsController.GetItemsByDocumentID(equipmentTransfer.ACDocumentID);
                    }
                    #endregion

                    #region Get general accounting data at local
                    ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                    ACRelativeDocumentsController objRelativeDocumentsController = new ACRelativeDocumentsController();
                    List<ACDocumentsInfo> documents = objDocumentsController.GetDocumentsForBroadcasting(branch.BRBranchID);

                    foreach (ACAssetReceiptsInfo assetReceipt in assetReceipts)
                    {
                        if (!documents.Exists(d => d.ACDocumentNo == assetReceipt.ACAssetReceiptNo))
                        {
                            ACDocumentsInfo document = objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.TangTSCD.ToString(), assetReceipt.ACAssetReceiptNo);
                            if (document != null)
                            {
                                documents.Add(document);
                            }
                        }
                    }
                    foreach (ACDocumentsInfo document in assetShipments)
                    {
                        if (!documents.Exists(d => d.ACDocumentID == document.ACDocumentID))
                        {
                            documents.Add(document);
                        }
                    }
                    foreach (ACDocumentsInfo document in assetTransfers)
                    {
                        if (!documents.Exists(d => d.ACDocumentID == document.ACDocumentID))
                        {
                            documents.Add(document);
                        }
                    }
                    foreach (ICShipmentsInfo shipment in equipmentShipments)
                    {
                        if (!documents.Exists(d => d.ACDocumentNo == shipment.ICShipmentNo))
                        {
                            ACDocumentsInfo document = null;
                            if (shipment.ICShipmentTypeCombo == ShipmentType.EquipmentShipment.ToString())
                            {
                                document = objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.XuatCCDC.ToString(), shipment.ICShipmentNo);
                            }
                            else if (shipment.ICShipmentTypeCombo == ShipmentType.EquipmentIncreasing.ToString())
                            {
                                document = objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.TangCCDC.ToString(), shipment.ICShipmentNo);
                            }
                            else if (shipment.ICShipmentTypeCombo == ShipmentType.EquipmentDecreasing.ToString())
                            {
                                document = objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.GiamCCDC.ToString(), shipment.ICShipmentNo);
                            }
                            if (document != null)
                            {
                                documents.Add(document);
                            }
                        }
                    }
                    foreach (ACDocumentsInfo document in equipmentTransfers)
                    {
                        if (!documents.Exists(d => d.ACDocumentID == document.ACDocumentID))
                        {
                            documents.Add(document);
                        }
                    }

                    foreach (ACDocumentsInfo document in documents)
                    {
                        document.DocumentEntries = objDocumentEntrysController.GetDocumentEntryByDocumentID(document.ACDocumentID);
                        document.RelativeDocuments = objRelativeDocumentsController.GetRelativeDocumentByDocumentID(document.ACDocumentID);
                    }
                    #endregion

                    bool isCompleted = false;
                    string log = string.Empty;
                    try
                    {
                        BOSApp.SwitchConnection(branch.BRBranchID);
                        if (BOSApp.TestCurrentConnection())
                        {
                            #region Transfer receipts
                            foreach (ICReceiptsInfo objReceiptsInfo in receipts)
                            {
                                ICReceiptsInfo branchReceipt = (ICReceiptsInfo)objReceiptsController.GetObjectByNo(objReceiptsInfo.ICReceiptNo);
                                if (branchReceipt != null)
                                {
                                    int branchReceiptID = branchReceipt.ICReceiptID;
                                    branchReceipt = (ICReceiptsInfo)objReceiptsInfo.Clone();
                                    branchReceipt.ICReceiptID = branchReceiptID;
                                    branchReceipt.FK_ACObjectID = 0;
                                    if (!string.IsNullOrEmpty(objReceiptsInfo.ACObjectNo))
                                    {
                                        ACObjectsInfo branchObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                                   objReceiptsInfo.ACObjectNo,
                                                                                                                   objReceiptsInfo.ICObjectType);
                                        if (branchObject != null)
                                        {
                                            branchReceipt.FK_ACObjectID = branchObject.ACObjectID;
                                        }
                                    }
                                    branchReceipt.IsTransferred = true;
                                    branchReceipt.ICReceiptTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    objReceiptsController.UpdateObject(branchReceipt);
                                }
                                else
                                {
                                    branchReceipt = (ICReceiptsInfo)objReceiptsInfo.Clone();
                                    branchReceipt.FK_ACObjectID = 0;
                                    if (!string.IsNullOrEmpty(objReceiptsInfo.ACObjectNo))
                                    {
                                        ACObjectsInfo branchObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                                   objReceiptsInfo.ACObjectNo,
                                                                                                                   objReceiptsInfo.ICObjectType);
                                        if (branchObject != null)
                                        {
                                            branchReceipt.FK_ACObjectID = branchObject.ACObjectID;
                                        }
                                    }
                                    branchReceipt.IsTransferred = true;
                                    branchReceipt.ICReceiptTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    branchReceipt.AAUpdatedDate = DateTime.MaxValue;
                                    objReceiptsController.CreateObject(branchReceipt);
                                }

                                if (branchReceipt.ICReceiptID > 0)
                                {
                                    TransferReceiptItemsToCentre(objReceiptsInfo.ReceiptItems, branchReceipt.ICReceiptID);
                                    if (!transferredReceipts.Exists(r => r.ICReceiptID == objReceiptsInfo.ICReceiptID))
                                    {
                                        transferredReceipts.Add(objReceiptsInfo);
                                    }
                                }
                            }
                            #endregion

                            #region Transfer shipments
                            foreach (ICShipmentsInfo objShipmentsInfo in shipments)
                            {
                                ICShipmentsInfo branchShipment = (ICShipmentsInfo)objShipmentsController.GetObjectByNo(objShipmentsInfo.ICShipmentNo);
                                if (branchShipment != null)
                                {
                                    int branchShipmentID = branchShipment.ICShipmentID;
                                    branchShipment = (ICShipmentsInfo)objShipmentsInfo.Clone();
                                    branchShipment.ICShipmentID = branchShipmentID;
                                    branchShipment.FK_ACObjectID = 0;
                                    if (!string.IsNullOrEmpty(objShipmentsInfo.ACObjectNo))
                                    {
                                        ACObjectsInfo branchObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                                    objShipmentsInfo.ACObjectNo,
                                                                                                                    objShipmentsInfo.ICObjectType);
                                        if (branchObject != null)
                                        {
                                            branchShipment.FK_ACObjectID = branchObject.ACObjectID;
                                        }
                                    }
                                    branchShipment.IsTransferred = true;
                                    branchShipment.ICShipmentTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    objShipmentsController.UpdateObject(branchShipment);
                                }
                                else
                                {
                                    branchShipment = (ICShipmentsInfo)objShipmentsInfo.Clone();
                                    branchShipment.FK_ACObjectID = 0;
                                    if (!string.IsNullOrEmpty(objShipmentsInfo.ACObjectNo))
                                    {
                                        ACObjectsInfo branchObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                                    objShipmentsInfo.ACObjectNo,
                                                                                                                    objShipmentsInfo.ICObjectType);
                                        if (branchObject != null)
                                        {
                                            branchShipment.FK_ACObjectID = branchObject.ACObjectID;
                                        }
                                    }
                                    branchShipment.IsTransferred = true;
                                    branchShipment.ICShipmentTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    branchShipment.AAUpdatedDate = DateTime.MaxValue;
                                    objShipmentsController.CreateObject(branchShipment);
                                }

                                if (branchShipment.ICShipmentID > 0)
                                {
                                    TransferShipmentItemsToCentre(objShipmentsInfo.ShipmentItems, branchShipment.ICShipmentID);
                                    if (!transferredShipments.Exists(s => s.ICShipmentID == objShipmentsInfo.ICShipmentID))
                                    {
                                        transferredShipments.Add(objShipmentsInfo);
                                    }
                                }
                            }
                            #endregion

                            #region Transfer stock transfers
                            foreach (ICTransfersInfo objTransfersInfo in transfers)
                            {
                                ICTransfersInfo branchTransfer = (ICTransfersInfo)objTransfersController.GetObjectByNo(objTransfersInfo.ICTransferNo);
                                if (branchTransfer != null)
                                {
                                    int branchTransferID = branchTransfer.ICTransferID;
                                    branchTransfer = (ICTransfersInfo)objTransfersInfo.Clone();
                                    branchTransfer.ICTransferID = branchTransferID;
                                    branchTransfer.IsTransferred = true;
                                    branchTransfer.ICTransferTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    objTransfersController.UpdateObject(branchTransfer);
                                }
                                else
                                {
                                    branchTransfer = (ICTransfersInfo)objTransfersInfo.Clone();
                                    branchTransfer.IsTransferred = true;
                                    branchTransfer.ICTransferTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    branchTransfer.AAUpdatedDate = DateTime.MaxValue;
                                    objTransfersController.CreateObject(branchTransfer);
                                }

                                if (branchTransfer.ICTransferID > 0)
                                {
                                    TransferStockTransferItemsToCentre(objTransfersInfo.TransferItems, branchTransfer.ICTransferID);
                                    if (!transferredStockTransfers.Exists(t => t.ICTransferID == objTransfersInfo.ICTransferID))
                                    {
                                        transferredStockTransfers.Add(objTransfersInfo);
                                    }
                                }
                            }
                            #endregion

                            #region Transfer budget data

                            #region Receipt voucher
                            foreach (ARReceiptVouchersInfo receiptVoucher in receiptVouchers)
                            {
                                ARReceiptVouchersInfo branchReceiptVoucher = (ARReceiptVouchersInfo)objReceiptVouchersController.GetObjectByNo(receiptVoucher.ARReceiptVoucherNo);
                                if (branchReceiptVoucher != null)
                                {
                                    int branchReceiptVoucherID = branchReceiptVoucher.ARReceiptVoucherID;
                                    branchReceiptVoucher = (ARReceiptVouchersInfo)receiptVoucher.Clone();
                                    branchReceiptVoucher.ARReceiptVoucherID = branchReceiptVoucherID;
                                    branchReceiptVoucher.FK_ACObjectID = 0;
                                    if (!string.IsNullOrEmpty(receiptVoucher.ACObjectNo))
                                    {
                                        ACObjectsInfo branchObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                                    receiptVoucher.ACObjectNo,
                                                                                                                    receiptVoucher.ARObjectType);
                                        if (branchObject != null)
                                        {
                                            branchReceiptVoucher.FK_ACObjectID = branchObject.ACObjectID;
                                        }
                                    }
                                    branchReceiptVoucher.IsTransferred = true;
                                    branchReceiptVoucher.ARReceiptVoucherTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    objReceiptVouchersController.UpdateObject(branchReceiptVoucher);
                                }
                                else
                                {
                                    branchReceiptVoucher = (ARReceiptVouchersInfo)receiptVoucher.Clone();
                                    branchReceiptVoucher.FK_ACObjectID = 0;
                                    if (!string.IsNullOrEmpty(receiptVoucher.ACObjectNo))
                                    {
                                        ACObjectsInfo branchObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                                    receiptVoucher.ACObjectNo,
                                                                                                                    receiptVoucher.ARObjectType);
                                        if (branchObject != null)
                                        {
                                            branchReceiptVoucher.FK_ACObjectID = branchObject.ACObjectID;
                                        }
                                    }
                                    branchReceiptVoucher.IsTransferred = true;
                                    branchReceiptVoucher.ARReceiptVoucherTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    branchReceiptVoucher.AAUpdatedDate = DateTime.MaxValue;
                                    objReceiptVouchersController.CreateObject(branchReceiptVoucher);
                                }

                                if (branchReceiptVoucher.ARReceiptVoucherID > 0)
                                {
                                    TransferReceiptVoucherItemsToCentre(receiptVoucher.ReceiptVoucherItems, branchReceiptVoucher.ARReceiptVoucherID);
                                    if (!transferredReceiptVouchers.Exists(rv => rv.ARReceiptVoucherID == receiptVoucher.ARReceiptVoucherID))
                                    {
                                        transferredReceiptVouchers.Add(receiptVoucher);
                                    }
                                }
                            }
                            #endregion

                            #region Payment voucher
                            foreach (APPaymentVouchersInfo paymentVoucher in paymentVouchers)
                            {
                                APPaymentVouchersInfo branchPaymentVoucher = (APPaymentVouchersInfo)objPaymentVouchersController.GetObjectByNo(paymentVoucher.APPaymentVoucherNo);
                                if (branchPaymentVoucher != null)
                                {
                                    int branchPaymentVoucherID = branchPaymentVoucher.APPaymentVoucherID;
                                    branchPaymentVoucher = (APPaymentVouchersInfo)paymentVoucher.Clone();
                                    branchPaymentVoucher.APPaymentVoucherID = branchPaymentVoucherID;
                                    branchPaymentVoucher.FK_ACObjectID = 0;
                                    if (!string.IsNullOrEmpty(paymentVoucher.ACObjectNo))
                                    {
                                        ACObjectsInfo branchObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                                    paymentVoucher.ACObjectNo,
                                                                                                                    paymentVoucher.APObjectType);
                                        if (branchObject != null)
                                        {
                                            branchPaymentVoucher.FK_ACObjectID = branchObject.ACObjectID;
                                        }
                                    }
                                    branchPaymentVoucher.IsTransferred = true;
                                    branchPaymentVoucher.APPaymentVoucherTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    objPaymentVouchersController.UpdateObject(branchPaymentVoucher);
                                }
                                else
                                {
                                    branchPaymentVoucher = (APPaymentVouchersInfo)paymentVoucher.Clone();
                                    branchPaymentVoucher.FK_ACObjectID = 0;
                                    if (!string.IsNullOrEmpty(paymentVoucher.ACObjectNo))
                                    {
                                        ACObjectsInfo branchObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                                    paymentVoucher.ACObjectNo,
                                                                                                                    paymentVoucher.APObjectType);
                                        if (branchObject != null)
                                        {
                                            branchPaymentVoucher.FK_ACObjectID = branchObject.ACObjectID;
                                        }
                                    }
                                    branchPaymentVoucher.IsTransferred = true;
                                    branchPaymentVoucher.APPaymentVoucherTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    branchPaymentVoucher.AAUpdatedDate = DateTime.MaxValue;
                                    objPaymentVouchersController.CreateObject(branchPaymentVoucher);
                                }

                                if (branchPaymentVoucher.APPaymentVoucherID > 0)
                                {
                                    TransferPaymentVoucherItemsToCentre(paymentVoucher.PaymentVoucherItems, branchPaymentVoucher.APPaymentVoucherID);
                                    if (!transferredPaymentVouchers.Exists(pv => pv.APPaymentVoucherID == paymentVoucher.APPaymentVoucherID))
                                    {
                                        transferredPaymentVouchers.Add(paymentVoucher);
                                    }
                                }
                            }
                            #endregion

                            #endregion

                            #region Transfer bank transactions
                            foreach (ACBankTransactionsInfo bankTransaction in bankTransactions)
                            {
                                ACBankTransactionsInfo branchBankTransaction = (ACBankTransactionsInfo)objBankTransactionsController.GetObjectByNo(bankTransaction.ACBankTransactionNo);
                                if (branchBankTransaction != null)
                                {
                                    int branchBankTransactionID = branchBankTransaction.ACBankTransactionID;
                                    branchBankTransaction = (ACBankTransactionsInfo)bankTransaction.Clone();
                                    branchBankTransaction.ACBankTransactionID = branchBankTransactionID;
                                    branchBankTransaction.FK_ACObjectID = 0;
                                    if (!string.IsNullOrEmpty(bankTransaction.ACObjectNo))
                                    {
                                        ACObjectsInfo branchObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                                    bankTransaction.ACObjectNo,
                                                                                                                    bankTransaction.ACObjectType);
                                        if (branchObject != null)
                                        {
                                            branchBankTransaction.FK_ACObjectID = branchObject.ACObjectID;
                                        }
                                    }
                                    branchBankTransaction.IsTransferred = true;
                                    branchBankTransaction.ACBankTransactionTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    objBankTransactionsController.UpdateObject(branchBankTransaction);
                                }
                                else
                                {
                                    branchBankTransaction = (ACBankTransactionsInfo)bankTransaction.Clone();
                                    branchBankTransaction.FK_ACObjectID = 0;
                                    if (!string.IsNullOrEmpty(bankTransaction.ACObjectNo))
                                    {
                                        ACObjectsInfo branchObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                                    bankTransaction.ACObjectNo,
                                                                                                                    bankTransaction.ACObjectType);
                                        if (branchObject != null)
                                        {
                                            branchBankTransaction.FK_ACObjectID = branchObject.ACObjectID;
                                        }
                                    }
                                    branchBankTransaction.IsTransferred = true;
                                    branchBankTransaction.ACBankTransactionTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    branchBankTransaction.AAUpdatedDate = DateTime.MaxValue;
                                    objBankTransactionsController.CreateObject(branchBankTransaction);
                                }

                                if (branchBankTransaction.ACBankTransactionID > 0)
                                {
                                    TransferBankTransactionItemsToCentre(bankTransaction.BankTransactionItems, branchBankTransaction.ACBankTransactionID);
                                    if (!transferredBankTransactions.Exists(bt => bt.ACBankTransactionID == bankTransaction.ACBankTransactionID))
                                    {
                                        transferredBankTransactions.Add(bankTransaction);
                                    }
                                }
                            }
                            #endregion

                            #region Transfer asset data

                            #region Asset
                            foreach (ACAssetsInfo asset in assets)
                            {
                                ACAssetsInfo branchAsset = (ACAssetsInfo)objAssetsController.GetObjectByNo(asset.ACAssetNo);
                                if (branchAsset != null)
                                {
                                    int branchAssetID = branchAsset.ACAssetID;
                                    branchAsset = (ACAssetsInfo)asset.Clone();
                                    branchAsset.ACAssetID = branchAssetID;
                                    branchAsset.IsTransferred = true;
                                    branchAsset.ACAssetTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    objAssetsController.UpdateObject(branchAsset);
                                }
                                else
                                {
                                    branchAsset = (ACAssetsInfo)asset.Clone();
                                    branchAsset.IsTransferred = true;
                                    branchAsset.ACAssetTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    branchAsset.AAUpdatedDate = DateTime.MaxValue;
                                    objAssetsController.CreateObject(branchAsset);
                                }
                                if (!transferredAssets.Exists(a => a.ACAssetID == asset.ACAssetID))
                                {
                                    transferredAssets.Add(asset);
                                }
                            }
                            #endregion

                            #region Asset receipts
                            foreach (ACAssetReceiptsInfo assetReceipt in assetReceipts)
                            {
                                ACAssetReceiptsInfo branchAssetReceipt = (ACAssetReceiptsInfo)objAssetReceiptsController.GetObjectByNo(assetReceipt.ACAssetReceiptNo);
                                if (branchAssetReceipt != null)
                                {
                                    int branchAssetReceiptID = branchAssetReceipt.ACAssetReceiptID;
                                    branchAssetReceipt = (ACAssetReceiptsInfo)assetReceipt.Clone();
                                    branchAssetReceipt.ACAssetReceiptID = branchAssetReceiptID;
                                    branchAssetReceipt.IsTransferred = true;
                                    branchAssetReceipt.ACAssetReceiptTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    objAssetReceiptsController.UpdateObject(branchAssetReceipt);
                                }
                                else
                                {
                                    branchAssetReceipt = (ACAssetReceiptsInfo)assetReceipt.Clone();
                                    branchAssetReceipt.IsTransferred = true;
                                    branchAssetReceipt.ACAssetReceiptTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    branchAssetReceipt.AAUpdatedDate = DateTime.MaxValue;
                                    objAssetReceiptsController.CreateObject(branchAssetReceipt);
                                }

                                if (branchAssetReceipt.ACAssetReceiptID > 0)
                                {
                                    TransferAssetReceiptItemsToCentre(assetReceipt.AssetReceiptItems, branchAssetReceipt.ACAssetReceiptID);
                                    if (!transferredAssetReceipts.Exists(ar => ar.ACAssetReceiptID == assetReceipt.ACAssetReceiptID))
                                    {
                                        transferredAssetReceipts.Add(assetReceipt);
                                    }
                                }
                            }
                            #endregion

                            #region Asset shipments
                            foreach (ACDocumentsInfo assetShipment in assetShipments)
                            {
                                ACDocumentsInfo branchAssetShipment = TransferDocumentToBranch(assetShipment);
                                if (branchAssetShipment.ACDocumentID > 0)
                                {
                                    TransferAssetShipmentItemsToCentre(assetShipment.AssetShipmentItems, branchAssetShipment.ACDocumentID);
                                    if (!transferredDocuments.Exists(d => d.ACDocumentID == assetShipment.ACDocumentID))
                                    {
                                        transferredDocuments.Add(assetShipment);
                                    }
                                }
                            }
                            #endregion

                            #region Asset trasfers
                            foreach (ACDocumentsInfo assetTransfer in assetTransfers)
                            {
                                ACDocumentsInfo branchAssetTransfer = TransferDocumentToBranch(assetTransfer);
                                if (branchAssetTransfer.ACDocumentID > 0)
                                {
                                    TransferAssetTransferItemsToCentre(assetTransfer.AssetTransferItems, branchAssetTransfer.ACDocumentID);
                                    if (!transferredDocuments.Exists(d => d.ACDocumentID == assetTransfer.ACDocumentID))
                                    {
                                        transferredDocuments.Add(assetTransfer);
                                    }
                                }
                            }
                            #endregion

                            #endregion

                            #region Transfer equipment data

                            #region Transfer equipment shipments
                            foreach (ICShipmentsInfo shipment in equipmentShipments)
                            {
                                ICShipmentsInfo branchShipment = (ICShipmentsInfo)objShipmentsController.GetObjectByNo(shipment.ICShipmentNo);
                                if (branchShipment != null)
                                {
                                    int branchShipmentID = branchShipment.ICShipmentID;
                                    branchShipment = (ICShipmentsInfo)shipment.Clone();
                                    branchShipment.ICShipmentID = branchShipmentID;
                                    branchShipment.IsTransferred = true;
                                    branchShipment.ICShipmentTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    objShipmentsController.UpdateObject(branchShipment);
                                }
                                else
                                {
                                    branchShipment = (ICShipmentsInfo)shipment.Clone();
                                    branchShipment.IsTransferred = true;
                                    branchShipment.ICShipmentTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                                    branchShipment.AAUpdatedDate = DateTime.MaxValue;
                                    objShipmentsController.CreateObject(branchShipment);
                                }

                                if (branchShipment.ICShipmentID > 0)
                                {
                                    TransferShipmentItemsToCentre(shipment.ShipmentItems, branchShipment.ICShipmentID);
                                    if (!transferredEquipmentShipments.Exists(s => s.ICShipmentID == shipment.ICShipmentID))
                                    {
                                        transferredEquipmentShipments.Add(shipment);
                                    }
                                }
                            }
                            #endregion

                            #region Transfer equipment transfers
                            foreach (ACDocumentsInfo equipmentTransfer in equipmentTransfers)
                            {
                                ACDocumentsInfo branchEquipmentTransfer = TransferDocumentToBranch(equipmentTransfer);
                                if (branchEquipmentTransfer.ACDocumentID > 0)
                                {
                                    TransferEquipmentTransferItemsToCentre(equipmentTransfer.EquipmentTransferItems, branchEquipmentTransfer.ACDocumentID);
                                    if (!transferredDocuments.Exists(d => d.ACDocumentID == equipmentTransfer.ACDocumentID))
                                    {
                                        transferredDocuments.Add(equipmentTransfer);
                                    }
                                }
                            }
                            #endregion

                            #endregion

                            #region Transfer general accounting data
                            SortedList<int, int> branchDocumentIDs = new SortedList<int, int>();
                            foreach (ACDocumentsInfo document in documents)
                            {
                                ACDocumentsInfo branchDocument = TransferDocumentToBranch(document);
                                if (branchDocument.ACDocumentID > 0)
                                {
                                    TransferDocumentEntriesToCentre(document.DocumentEntries, branchDocument);
                                    branchDocumentIDs.Add(document.ACDocumentID, branchDocument.ACDocumentID);
                                }
                            }

                            foreach (var document in documents)
                            {
                                if (branchDocumentIDs.ContainsKey(document.ACDocumentID))
                                {
                                    TransferRelativeDocumentsToCentre(document.RelativeDocuments, branchDocumentIDs[document.ACDocumentID]);
                                }
                                if (!transferredDocuments.Exists(d => d.ACDocumentID == document.ACDocumentID))
                                {
                                    transferredDocuments.Add(document);
                                }
                            }
                            #endregion

                            isCompleted = true;
                        }
                        else
                        {
                            log = string.Format(DataExchangeLocalizedResources.CannotConnectToBranch, branch.BRBranchName);
                        }
                    }
                    catch (Exception ex)
                    {
                        log = ex.Message;
                    }
                    finally
                    {
                        BOSApp.RollbackLocalConnection();

                        if (isCompleted)
                        {
                            count++;
                            branch.BRBranchTransferMessage = DataExchangeLocalizedResources.TransferDoneMessage;
                        }
                        else
                        {
                            branch.BRBranchTransferMessage = log;
                        }
                    }
                }
            }

            //Update accounting data at local
            UpdateLocalReceiptStatus(transferredReceipts);
            UpdateLocalShipmentStatus(transferredShipments);
            UpdateLocalTransferStatus(transferredStockTransfers);
            UpdateLocalReceiptVoucherStatus(transferredReceiptVouchers);
            UpdateLocalPaymentVoucherStatus(transferredPaymentVouchers);
            UpdateLocalBankTransactionStatus(transferredBankTransactions);
            UpdateLocalAssetReceiptStatus(transferredAssetReceipts);
            UpdateLocalShipmentStatus(transferredEquipmentShipments);
            UpdateLocalDocumentStatus(transferredDocuments);

            int transferredCount = entity.BRBranchsList.Where(b => !string.IsNullOrEmpty(b.BRBranchServerName) && b.BRBranchType == BranchType.Branch.ToString()).Count();
            if (count == transferredCount)
            {
                UpdateLocalAssetStatus(transferredAssets);
            }
            BOSProgressBar.Close();
        }

        /// <summary>
        /// Transfer a document to the branch
        /// </summary>
        /// <param name="document">Transferred document</param>
        /// <returns>Branch document</returns>
        private ACDocumentsInfo TransferDocumentToBranch(ACDocumentsInfo document)
        {
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACDocumentsInfo branchDocument = (ACDocumentsInfo)objDocumentsController.GetDocumentByDocumentTypeIDAndDocumentNo(document.FK_ACDocumentTypeID, document.ACDocumentNo);
            if (branchDocument != null)
            {
                int branchDocumentID = branchDocument.ACDocumentID;
                branchDocument = (ACDocumentsInfo)document.Clone();
                branchDocument.ACDocumentID = branchDocumentID;
                branchDocument.FK_ACObjectID = 0;
                if (!string.IsNullOrEmpty(document.ACObjectNo))
                {
                    ACObjectsInfo branchObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                document.ACObjectNo,
                                                                                                document.ACObjectType);
                    if (branchObject != null)
                    {
                        branchDocument.FK_ACObjectID = branchObject.ACObjectID;
                    }
                }
                branchDocument.FK_ACAssObjectID = 0;
                if (!string.IsNullOrEmpty(document.ACAssObjectNo))
                {
                    ACObjectsInfo branchObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                document.ACAssObjectNo,
                                                                                                document.ACAssObjectType);
                    if (branchObject != null)
                    {
                        branchDocument.FK_ACAssObjectID = branchObject.ACObjectID;
                    }
                }
                branchDocument.IsTransferred = true;
                branchDocument.ACDocumentTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objDocumentsController.UpdateObject(branchDocument);
            }
            else
            {
                branchDocument = (ACDocumentsInfo)document.Clone();
                branchDocument.FK_ACObjectID = 0;
                if (!string.IsNullOrEmpty(document.ACObjectNo))
                {
                    ACObjectsInfo branchObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                document.ACObjectNo,
                                                                                                document.ACObjectType);
                    if (branchObject != null)
                    {
                        branchDocument.FK_ACObjectID = branchObject.ACObjectID;
                    }
                }
                branchDocument.FK_ACAssObjectID = 0;
                if (!string.IsNullOrEmpty(document.ACAssObjectNo))
                {
                    ACObjectsInfo branchObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                document.ACAssObjectNo,
                                                                                                document.ACAssObjectType);
                    if (branchObject != null)
                    {
                        branchDocument.FK_ACAssObjectID = branchObject.ACObjectID;
                    }
                }
                branchDocument.IsTransferred = true;
                branchDocument.ACDocumentTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                branchDocument.AAUpdatedDate = DateTime.MaxValue;
                objDocumentsController.CreateObject(branchDocument);
            }
            return branchDocument;
        }
        #endregion

        #region From Branch to Headquarters

        #region Transfer inventory
        public void TransferInventoryFromBranchToCentre(object sender)
        {
            BOSProgressBar.Start(DataExchangeLocalizedResources.TransferringInventoryToHeadquarterMessage);
            TransferType = DataExchangeType.Inventory.ToString();
            TransferStatus = DataExchangeStatus.New.ToString();
            TransferTimer.Start();

            TransferInventoryFromBranchToCentre();
        }

        public void TransferInventoryFromBranchToCentre()
        {
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objBranchsInfo != null && objBranchsInfo.BRBranchParentID > 0)
            {
                BRBranchsInfo centre = (BRBranchsInfo)objBranchsController.GetObjectByID(objBranchsInfo.BRBranchParentID);
                if (centre != null)
                {
                    #region Get inventory at local
                    ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
                    ICInvAdjustmentsController objInvAdjustmentsController = new ICInvAdjustmentsController();
                    //NUThao [EDIT] [08/04/2014] [DB centre] [CSCompany issue], START
                    int companyID = BOSApp.CurrentCompanyInfo.CSCompanyID;
                    //List<ICInventoryStocksInfo> inventoryStocks = objInventoryStocksController.GetInventoryStocksForTransferring();
                    List<ICInventoryStocksInfo> inventoryStocks = objInventoryStocksController.GetInventoryStocksForTransferring(companyID);
                    //NUThao [EDIT] [08/04/2014] [DB centre] [CSCompany issue], END
                    List<ICInvAdjustmentsInfo> invAdjustments = objInvAdjustmentsController.GetInvAdjustmentsForTransferring(objBranchsInfo.BRBranchID);
                    List<ICInvAdjustmentsInfo> transferredInvAdjustments = new List<ICInvAdjustmentsInfo>();
                    #endregion

                    #region Get receipts at local
                    ICReceiptsController objReceiptsController = new ICReceiptsController();
                    ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
                    List<ICReceiptsInfo> receipts = objReceiptsController.GetReceiptsForTransferring();
                    foreach (ICReceiptsInfo objReceiptsInfo in receipts)
                    {
                        objReceiptsInfo.ReceiptItems = new BOSList<ICReceiptItemsInfo>(TableName.ICReceiptItemsTableName);
                        List<ICReceiptItemsInfo> items = objReceiptItemsController.GetItemsByReceiptID(objReceiptsInfo.ICReceiptID);
                        objReceiptsInfo.ReceiptItems.Invalidate(items);
                    }
                    #endregion

                    #region Get shipments at local
                    ICShipmentsController objShipmentsController = new ICShipmentsController();
                    ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
                    List<ICShipmentsInfo> shipments = objShipmentsController.GetShipmentsForTransferring();
                    foreach (ICShipmentsInfo objShipmentsInfo in shipments)
                    {
                        objShipmentsInfo.ShipmentItems = new BOSList<ICShipmentItemsInfo>(TableName.ICShipmentItemsTableName);
                        List<ICShipmentItemsInfo> items = objShipmentItemsController.GetItemsByShipmentID(objShipmentsInfo.ICShipmentID);
                        objShipmentsInfo.ShipmentItems.Invalidate(items);
                    }
                    #endregion

                    #region Get stock transfers at local
                    ICTransfersController objTransfersController = new ICTransfersController();
                    ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
                    List<ICTransfersInfo> transfers = objTransfersController.GetStockTransfersForTransferring();
                    foreach (ICTransfersInfo objTransfersInfo in transfers)
                    {
                        objTransfersInfo.TransferItems = new BOSList<ICTransferItemsInfo>(TableName.ICTransferItemsTableName);
                        List<ICTransferItemsInfo> items = objTransferItemsController.GetTransferItemsByTransferID(objTransfersInfo.ICTransferID);
                        objTransfersInfo.TransferItems.Invalidate(items);
                    }
                    #endregion

                    bool isCompleted = false;
                    int postingHistoryID = 0;
                    string log = string.Empty;
                    try
                    {
                        BOSApp.SwitchConnection(centre.BRBranchID);
                        if (BOSApp.TestCurrentConnection())
                        {
                            //Check for existing branch posting
                            BRPostingHistorysController objPostingHistorysController = new BRPostingHistorysController();
                            BRPostingHistorysInfo objPostingHistorysInfo = objPostingHistorysController.GetPostingHistoryByStatusAndType(DataExchangeStatus.Posting.ToString(), DataExchangeType.Inventory.ToString());
                            if (objPostingHistorysInfo != null)
                            {
                                return;
                            }

                            TransferStatus = DataExchangeStatus.Posting.ToString();
                            //Create posting history with status is 'posting' to prevent branchs from post
                            postingHistoryID = CreatePostingHistory(0, objBranchsInfo.BRBranchID, DataExchangeType.Inventory.ToString(), DataExchangeStatus.Posting.ToString());
                            #region Transfer inventory to centre
                            foreach (ICInventoryStocksInfo objInventoryStocksInfo in inventoryStocks)
                            {
                                ICInventoryStocksInfo centralInventoryStock = (ICInventoryStocksInfo)objInventoryStocksInfo.Clone();

                                SynProductSerie(centralInventoryStock);

                                int centralInventoryStockID;
                                ICInventoryStocksInfo existingInventoryStock =
                                    objInventoryStocksController.GetInventoryStockByStockIDAndProductIDAndSerieID(
                                                                    centralInventoryStock.FK_ICStockID,
                                                                    centralInventoryStock.FK_ICProductID,
                                                                    centralInventoryStock.FK_ICProductSerieID);
                                if (existingInventoryStock != null)
                                {
                                    centralInventoryStock.ICInventoryStockID = existingInventoryStock.ICInventoryStockID;
                                    centralInventoryStockID = objInventoryStocksController.UpdateObject(centralInventoryStock);
                                }
                                else
                                {
                                    centralInventoryStockID = objInventoryStocksController.CreateObject(centralInventoryStock);
                                }
                            }
                            #endregion

                            #region Transfer inventory adjustments to centre                            
                            foreach (ICInvAdjustmentsInfo objInvAdjustmentsInfo in invAdjustments)
                            {
                                ICInvAdjustmentsInfo centralInvAdjustment = (ICInvAdjustmentsInfo)objInvAdjustmentsInfo.Clone();

                                SynProductSerie(centralInvAdjustment);

                                int centralInvAdjustmentID;
                                ICInvAdjustmentsInfo existingInvAdjustment =
                                    objInvAdjustmentsController.GetInactiveInvAdjustmentByStockIDAndProductIDAndSerieID(
                                                                    centralInvAdjustment.FK_ICStockID,
                                                                    centralInvAdjustment.FK_ICProductID,
                                                                    centralInvAdjustment.FK_ICProductSerieID);
                                if (existingInvAdjustment != null)
                                {
                                    centralInvAdjustment.ICInvAdjustmentID = existingInvAdjustment.ICInvAdjustmentID;
                                    centralInvAdjustment.AAStatus = BusinessObject.InactiveStatus;
                                    centralInvAdjustmentID = objInvAdjustmentsController.UpdateObject(centralInvAdjustment);
                                }
                                else
                                {
                                    centralInvAdjustment.AAStatus = BusinessObject.InactiveStatus;
                                    centralInvAdjustmentID = objInvAdjustmentsController.CreateObject(centralInvAdjustment);
                                }
                                transferredInvAdjustments.Add(objInvAdjustmentsInfo);
                            }
                            #endregion

                            #region Transfer receipts to centre
                            ACObjectsController objObjectsController = new ACObjectsController();
                            foreach (ICReceiptsInfo objReceiptsInfo in receipts)
                            {
                                ICReceiptsInfo centralReceipt = (ICReceiptsInfo)objReceiptsController.GetObjectByNo(objReceiptsInfo.ICReceiptNo);
                                if (centralReceipt != null)
                                {
                                    int centralReceiptID = centralReceipt.ICReceiptID;
                                    centralReceipt = (ICReceiptsInfo)objReceiptsInfo.Clone();
                                    centralReceipt.ICReceiptID = centralReceiptID;
                                    centralReceipt.FK_ACObjectID = 0;
                                    if (!string.IsNullOrEmpty(objReceiptsInfo.ACObjectNo))
                                    {
                                        ACObjectsInfo centralObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                                   objReceiptsInfo.ACObjectNo,
                                                                                                                   objReceiptsInfo.ICObjectType);
                                        if (centralObject != null)
                                        {
                                            centralReceipt.FK_ACObjectID = centralObject.ACObjectID;
                                        }
                                    }
                                    centralReceipt.ICReceiptTransferredDate = BOSApp.GetCurrentServerDate();
                                    objReceiptsController.UpdateObject(centralReceipt);
                                }
                                else
                                {
                                    centralReceipt = (ICReceiptsInfo)objReceiptsInfo.Clone();
                                    centralReceipt.FK_ACObjectID = 0;
                                    if (!string.IsNullOrEmpty(objReceiptsInfo.ACObjectNo))
                                    {
                                        ACObjectsInfo centralObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                                   objReceiptsInfo.ACObjectNo,
                                                                                                                   objReceiptsInfo.ICObjectType);
                                        if (centralObject != null)
                                        {
                                            centralReceipt.FK_ACObjectID = centralObject.ACObjectID;
                                        }
                                    }
                                    centralReceipt.AAUpdatedDate = DateTime.MaxValue;
                                    objReceiptsController.CreateObject(centralReceipt);
                                }

                                if (centralReceipt.ICReceiptID > 0)
                                {
                                    TransferReceiptItemsToCentre(objReceiptsInfo.ReceiptItems, centralReceipt.ICReceiptID);
                                }
                            }
                            #endregion

                            #region Transfer shipments to centre
                            foreach (ICShipmentsInfo objShipmentsInfo in shipments)
                            {
                                ICShipmentsInfo centralShipment = (ICShipmentsInfo)objShipmentsController.GetObjectByNo(objShipmentsInfo.ICShipmentNo);
                                if (centralShipment != null)
                                {
                                    int centralShipmentID = centralShipment.ICShipmentID;
                                    centralShipment = (ICShipmentsInfo)objShipmentsInfo.Clone();
                                    centralShipment.ICShipmentID = centralShipmentID;
                                    centralShipment.FK_ACObjectID = 0;
                                    if (!string.IsNullOrEmpty(objShipmentsInfo.ACObjectNo))
                                    {
                                        ACObjectsInfo centralObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                                    objShipmentsInfo.ACObjectNo,
                                                                                                                    objShipmentsInfo.ICObjectType);
                                        if (centralObject != null)
                                        {
                                            centralShipment.FK_ACObjectID = centralObject.ACObjectID;
                                        }
                                    }
                                    centralShipment.ICShipmentTransferredDate = BOSApp.GetCurrentServerDate();
                                    objShipmentsController.UpdateObject(centralShipment);
                                }
                                else
                                {
                                    centralShipment = (ICShipmentsInfo)objShipmentsInfo.Clone();
                                    centralShipment.FK_ACObjectID = 0;
                                    if (!string.IsNullOrEmpty(objShipmentsInfo.ACObjectNo))
                                    {
                                        ACObjectsInfo centralObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                                    objShipmentsInfo.ACObjectNo,
                                                                                                                    objShipmentsInfo.ICObjectType);
                                        if (centralObject != null)
                                        {
                                            centralShipment.FK_ACObjectID = centralObject.ACObjectID;
                                        }
                                    }
                                    centralShipment.AAUpdatedDate = DateTime.MaxValue;
                                    objShipmentsController.CreateObject(centralShipment);
                                }

                                if (centralShipment.ICShipmentID > 0)
                                {
                                    TransferShipmentItemsToCentre(objShipmentsInfo.ShipmentItems, centralShipment.ICShipmentID);
                                }
                            }
                            #endregion

                            #region Transfer stock transfers to centre
                            foreach (ICTransfersInfo objTransfersInfo in transfers)
                            {
                                ICTransfersInfo centralTransfer = (ICTransfersInfo)objTransfersController.GetObjectByNo(objTransfersInfo.ICTransferNo);
                                if (centralTransfer != null)
                                {
                                    int centralTransferID = centralTransfer.ICTransferID;
                                    centralTransfer = (ICTransfersInfo)objTransfersInfo.Clone();
                                    centralTransfer.ICTransferID = centralTransferID;
                                    centralTransfer.ICTransferTransferredDate = BOSApp.GetCurrentServerDate();
                                    objTransfersController.UpdateObject(centralTransfer);
                                }
                                else
                                {
                                    centralTransfer = (ICTransfersInfo)objTransfersInfo.Clone();
                                    centralTransfer.AAUpdatedDate = DateTime.MaxValue;
                                    objTransfersController.CreateObject(centralTransfer);
                                }

                                if (centralTransfer.ICTransferID > 0)
                                {
                                    TransferStockTransferItemsToCentre(objTransfersInfo.TransferItems, centralTransfer.ICTransferID);
                                }
                            }
                            #endregion

                            isCompleted = true;
                            MessageBox.Show(DataExchangeLocalizedResources.TransferSuccessMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(string.Format(DataExchangeLocalizedResources.CannotConnectToCentre, centre.BRBranchName), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        log = ex.Message;
                    }
                    finally
                    {
                        if (postingHistoryID > 0)
                        {
                            //Update posting history in centre
                            if (isCompleted)
                            {
                                CreatePostingHistory(postingHistoryID, objBranchsInfo.BRBranchID, DataExchangeType.Inventory.ToString(), DataExchangeStatus.Complete.ToString());
                            }
                            else
                            {
                                CreatePostingHistory(postingHistoryID, objBranchsInfo.BRBranchID, DataExchangeType.Inventory.ToString(), DataExchangeStatus.Failed.ToString(), log);
                            }
                        }
                        BOSApp.RollbackLocalConnection();
                        if (postingHistoryID > 0)
                        {
                            //Update data at local
                            if (isCompleted)
                            {
                                UpdateLocalInventoryStatus(inventoryStocks);
                                DeleteLocalInvAdjustments(transferredInvAdjustments);
                                UpdateLocalReceiptStatus(receipts);
                                UpdateLocalShipmentStatus(shipments);
                                UpdateLocalTransferStatus(transfers);
                            }

                            //Create posting history in branch
                            if (isCompleted)
                            {
                                CreatePostingHistory(0, objBranchsInfo.BRBranchID, DataExchangeType.Inventory.ToString(), DataExchangeStatus.Complete.ToString());
                            }
                            else
                            {
                                CreatePostingHistory(0, objBranchsInfo.BRBranchID, DataExchangeType.Inventory.ToString(), DataExchangeStatus.Failed.ToString(), log);
                            }
                        }
                    }

                    //Switch to centre and make inactive inventory adjustment objects active ones that
                    //are ready for adjusting at target branch
                    try
                    {
                        BOSApp.SwitchConnection(centre.BRBranchID);
                        if (BOSApp.TestCurrentConnection())
                        {
                            objInvAdjustmentsController.UpdateStatusForInactiveObjects(BOSApp.CurrentCompanyInfo.FK_BRBranchID,
                                                                                    BusinessObject.DefaultAAStatus);
                        }
                    }
                    catch (Exception)
                    {

                    }
                    finally
                    {
                        BOSApp.RollbackLocalConnection();

                        if (isCompleted)
                        {
                            Control button = Controls[DataExchangeModule.TransferSaleDataToCentreButtonName];
                            button.Enabled = true;
                        }
                    }
                }
            }
            TransferTimer.Stop();
            BOSProgressBar.Close();
        }

        /// <summary>
        /// Delete local inventory adjustments, to prevent them from transferring
        /// to the center again
        /// </summary>
        /// <param name="transferredInvAdjustments">Transferred inventory adjustments</param>
        private void DeleteLocalInvAdjustments(List<ICInvAdjustmentsInfo> transferredInvAdjustments)
        {
            ICInvAdjustmentsController objInvAdjustmentsController = new ICInvAdjustmentsController();
            foreach (ICInvAdjustmentsInfo invAdjustment in transferredInvAdjustments)
            {
                objInvAdjustmentsController.DeleteObject(invAdjustment.ICInvAdjustmentID);
            }
        }

        /// <summary>
        /// Transfer items of a receipt to centre
        /// </summary>
        /// <param name="receiptItems">Receipt items need to transfer</param>
        /// <param name="centralReceiptID">Central receipt id</param>
        private void TransferReceiptItemsToCentre(IList<ICReceiptItemsInfo> receiptItems, int centralReceiptID)
        {
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            objReceiptItemsController.DeleteByForeignColumn("FK_ICReceiptID", centralReceiptID);
            foreach (ICReceiptItemsInfo objReceiptItemsInfo in receiptItems)
            {
                ICReceiptItemsInfo centralItem = (ICReceiptItemsInfo)objReceiptItemsInfo.Clone();
                centralItem.FK_ICReceiptID = centralReceiptID;
                SynProductSerie(centralItem);
                centralItem.FK_APInvoiceInID = 0;
                centralItem.FK_APInvoiceInItemID = 0;
                centralItem.FK_ARSaleReturnID = 0;
                centralItem.FK_ARSaleReturnItemID = 0;
                objReceiptItemsController.CreateObject(centralItem);
            }
        }

        /// <summary>
        /// Transfer items of a shipment to centre
        /// </summary>
        /// <param name="shipmentItems">Shipment items need to transfer</param>
        /// <param name="centralShipmentID">Central shipment id</param>
        private void TransferShipmentItemsToCentre(IList<ICShipmentItemsInfo> shipmentItems, int centralShipmentID)
        {
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            objShipmentItemsController.DeleteByForeignColumn("FK_ICShipmentID", centralShipmentID);
            foreach (ICShipmentItemsInfo objShipmentItemsInfo in shipmentItems)
            {
                ICShipmentItemsInfo centralItem = (ICShipmentItemsInfo)objShipmentItemsInfo.Clone();
                centralItem.FK_ICShipmentID = centralShipmentID;
                SynProductSerie(centralItem);
                centralItem.FK_ARInvoiceID = 0;
                centralItem.FK_ARInvoiceItemID = 0;
                objShipmentItemsController.CreateObject(centralItem);
            }
        }

        /// <summary>
        /// Transfer items of a stock transfer to centre
        /// </summary>
        /// <param name="transferItems">Transfer items need to transfer</param>
        /// <param name="centralTransferID">Central transfer id</param>        
        private void TransferStockTransferItemsToCentre(IList<ICTransferItemsInfo> transferItems, int centralTransferID)
        {
            ICTransferItemsController objTransferItemsController = new ICTransferItemsController();
            objTransferItemsController.DeleteByForeignColumn("FK_ICTransferID", centralTransferID);
            foreach (ICTransferItemsInfo objTransferItemsInfo in transferItems)
            {
                ICTransferItemsInfo centralItem = (ICTransferItemsInfo)objTransferItemsInfo.Clone();
                centralItem.FK_ICTransferID = centralTransferID;
                SynProductSerie(centralItem);
                objTransferItemsController.CreateObject(centralItem);
            }
        }

        /// <summary>
        /// Update the status of local inventory after transferring them
        /// to track for the next one
        /// </summary>
        /// <param name="inventoryStocks">Transferred inventory</param>
        private void UpdateLocalInventoryStatus(List<ICInventoryStocksInfo> inventoryStocks)
        {
            ICInventoryStocksController objInventoryStocksController = new ICInventoryStocksController();
            foreach (ICInventoryStocksInfo inventoryStock in inventoryStocks)
            {
                inventoryStock.IsTransferred = true;
                inventoryStock.ICInventoryStockTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objInventoryStocksController.UpdateObject(inventoryStock);
            }
        }

        /// <summary>
        /// Update the status of transferred receipts at local
        /// </summary>
        /// <param name="receipts">List of receipts</param>
        private void UpdateLocalReceiptStatus(List<ICReceiptsInfo> receipts)
        {
            ICReceiptsController objReceiptsController = new ICReceiptsController();
            foreach (ICReceiptsInfo objReceiptsInfo in receipts)
            {
                objReceiptsInfo.IsTransferred = true;
                objReceiptsInfo.ICReceiptTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objReceiptsController.UpdateObject(objReceiptsInfo);
            }
        }

        /// <summary>
        /// Update the status of transferred shipments at local
        /// </summary>
        /// <param name="shipments">List of shipments</param>
        private void UpdateLocalShipmentStatus(List<ICShipmentsInfo> shipments)
        {
            ICShipmentsController objShipmentsController = new ICShipmentsController();
            foreach (ICShipmentsInfo objShipmentsInfo in shipments)
            {
                objShipmentsInfo.IsTransferred = true;
                objShipmentsInfo.ICShipmentTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objShipmentsController.UpdateObject(objShipmentsInfo);
            }
        }

        /// <summary>
        /// Update the status of transferred stock transfers at local
        /// </summary>
        /// <param name="transfers">List of transfers</param>
        private void UpdateLocalTransferStatus(List<ICTransfersInfo> transfers)
        {
            ICTransfersController objTransfersController = new ICTransfersController();
            foreach (ICTransfersInfo objTransfersInfo in transfers)
            {
                objTransfersInfo.IsTransferred = true;
                objTransfersInfo.ICTransferTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objTransfersController.UpdateObject(objTransfersInfo);
            }
        }
        #endregion

        #region Transfer sale data
        public void TransferSaleDataFromBranchToCentre(object sender)
        {
            BOSProgressBar.Start(DataExchangeLocalizedResources.TransferringSaleDataToHeadquarterMessage);
            TransferType = DataExchangeType.Sale.ToString();
            TransferStatus = DataExchangeStatus.New.ToString();
            TransferTimer.Start();

            TransferSaleDataFromBranchToCentre();
        }

        public void TransferSaleDataFromBranchToCentre()
        {
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objBranchsInfo != null && objBranchsInfo.BRBranchParentID > 0)
            {
                BRBranchsInfo centre = (BRBranchsInfo)objBranchsController.GetObjectByID(objBranchsInfo.BRBranchParentID);
                if (centre != null)
                {
                    ARCustomersController objCustomersController = new ARCustomersController();

                    #region Get sale orders at local
                    ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
                    ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
                    ARSOItemComponentsController objSOItemComponentsController = new ARSOItemComponentsController();
                    List<ARSaleOrdersInfo> saleOrders = objSaleOrdersController.GetSaleOrdersForTransferring();
                    foreach (ARSaleOrdersInfo objSaleOrdersInfo in saleOrders)
                    {
                        objSaleOrdersInfo.SaleOrderItems = new BOSList<ARSaleOrderItemsInfo>(TableName.ARSaleOrderItemsTableName);
                        List<ARSaleOrderItemsInfo> items = objSaleOrderItemsController.GetItemsBySaleOrderID(objSaleOrdersInfo.ARSaleOrderID);
                        objSaleOrdersInfo.SaleOrderItems.Invalidate(items);

                        foreach (ARSaleOrderItemsInfo objSaleOrderItemsInfo in objSaleOrdersInfo.SaleOrderItems)
                        {
                            objSaleOrderItemsInfo.ARSOItemComponentList = new BOSList<ARSOItemComponentsInfo>(TableName.ARSOItemComponentsTableName);
                            List<ARSOItemComponentsInfo> components = objSOItemComponentsController.GetSOItemComponentListBySOItemID(objSaleOrderItemsInfo.ARSaleOrderItemID);
                            objSaleOrderItemsInfo.ARSOItemComponentList.Invalidate(components);
                        }
                    }
                    #endregion

                    #region Get invoices at local
                    ARInvoicesController objInvoicesController = new ARInvoicesController();
                    ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
                    ARInvoiceItemComponentsController objInvoiceItemComponentsController = new ARInvoiceItemComponentsController();
                    List<ARInvoicesInfo> invoices = objInvoicesController.GetInvoicesForTransferring();
                    foreach (ARInvoicesInfo objInvoicesInfo in invoices)
                    {
                        //Get invoice items
                        List<ARInvoiceItemsInfo> items = objInvoiceItemsController.GetItemsByInvoiceID(objInvoicesInfo.ARInvoiceID);
                        objInvoicesInfo.InvoiceItems = new BOSList<ARInvoiceItemsInfo>(TableName.ARInvoiceItemsTableName);
                        objInvoicesInfo.InvoiceItems.Invalidate(items);

                        foreach (ARInvoiceItemsInfo objInvoiceItemsInfo in objInvoicesInfo.InvoiceItems)
                        {
                            List<ARInvoiceItemComponentsInfo> components = objInvoiceItemComponentsController.GetInvoiceItemComponentListByInvoiceItemID(objInvoiceItemsInfo.ARInvoiceItemID);
                            objInvoiceItemsInfo.InvoiceItemComponentList = new BOSList<ARInvoiceItemComponentsInfo>(TableName.ARInvoiceItemComponentsTableName);
                            objInvoiceItemsInfo.InvoiceItemComponentList.Invalidate(components);
                        }
                    }
                    #endregion

                    #region Get cancel vouchers at local
                    ARCancelVouchersController objCancelVouchersController = new ARCancelVouchersController();
                    ARCancelVoucherItemsController objCancelVoucherItemsController = new ARCancelVoucherItemsController();
                    List<ARCancelVouchersInfo> cancelVouchers = objCancelVouchersController.GetCancelVouchersForTransferring();
                    foreach (ARCancelVouchersInfo objCancelVouchersInfo in cancelVouchers)
                    {
                        objCancelVouchersInfo.CancelVoucherItems = new BOSList<ARCancelVoucherItemsInfo>(TableName.ARCancelVoucherItemsTableName);
                        DataSet ds = objCancelVoucherItemsController.GetAllDataByForeignColumn("FK_ARCancelVoucherID", objCancelVouchersInfo.ARCancelVoucherID);
                        objCancelVouchersInfo.CancelVoucherItems.Invalidate(ds);
                    }
                    #endregion

                    #region Get sale returns at local
                    ARSaleReturnsController objSaleReturnsController = new ARSaleReturnsController();
                    ARSaleReturnItemsController objSaleReturnItemsController = new ARSaleReturnItemsController();
                    List<ARSaleReturnsInfo> saleReturns = objSaleReturnsController.GetSaleReturnsForTransferring();
                    foreach (ARSaleReturnsInfo objSaleReturnsInfo in saleReturns)
                    {
                        objSaleReturnsInfo.SaleReturnItems = new BOSList<ARSaleReturnItemsInfo>(TableName.ARSaleReturnItemsTableName);
                        List<ARSaleReturnItemsInfo> items = objSaleReturnItemsController.GetItemsBySaleReturnID(objSaleReturnsInfo.ARSaleReturnID);
                        objSaleReturnsInfo.SaleReturnItems.Invalidate(items);
                    }
                    #endregion

                    #region Get customer payments at local
                    ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
                    ARDocumentPaymentsController objDocumentPaymentsController = new ARDocumentPaymentsController();
                    ARCustomerPaymentDetailsController objCustomerPaymentDetailsController = new ARCustomerPaymentDetailsController();
                    ARCustomerPaymentCurrencysController objCustomerPaymentCurrencysController = new ARCustomerPaymentCurrencysController();
                    List<ARCustomerPaymentsInfo> customerPayments = objCustomerPaymentsController.GetCustomerPaymentsForTransferring();
                    foreach (ARCustomerPaymentsInfo objCustomerPaymentsInfo in customerPayments)
                    {
                        objCustomerPaymentsInfo.PaymentDetails = new BOSList<ARCustomerPaymentDetailsInfo>(TableName.ARCustomerPaymentDetailsTableName);
                        DataSet ds = objCustomerPaymentDetailsController.GetAllDataByForeignColumn("FK_ARCustomerPaymentID", objCustomerPaymentsInfo.ARCustomerPaymentID);
                        objCustomerPaymentsInfo.PaymentDetails.Invalidate(ds);

                        //Get payments by currencies of payment details                            
                        foreach (ARCustomerPaymentDetailsInfo objCustomerPaymentDetailsInfo in objCustomerPaymentsInfo.PaymentDetails)
                        {
                            objCustomerPaymentDetailsInfo.PaymentCurrencys = new BOSList<ARCustomerPaymentCurrencysInfo>(TableName.ARCustomerPaymentCurrencysTableName);
                            ds = objCustomerPaymentCurrencysController.GetAllDataByForeignColumn("FK_ARCustomerPaymentDetailID", objCustomerPaymentDetailsInfo.ARCustomerPaymentDetailID);
                            objCustomerPaymentDetailsInfo.PaymentCurrencys.Invalidate(ds);
                        }

                        //Get document payments
                        objCustomerPaymentsInfo.DocumentPayments = new BOSList<ARDocumentPaymentsInfo>(TableName.ARDocumentPaymentsTableName);
                        List<ARDocumentPaymentsInfo> documentPayments = objDocumentPaymentsController.GetDocumentPaymentsByCustomerPaymentID(objCustomerPaymentsInfo.ARCustomerPaymentID);
                        objCustomerPaymentsInfo.DocumentPayments.Invalidate(documentPayments);
                    }

                    //Get open documents
                    AROpenDocumentsController objOpenDocumentsController = new AROpenDocumentsController();
                    List<AROpenDocumentsInfo> openDocuments = objOpenDocumentsController.GetOpenDocumentsForTransferring();
                    #endregion

                    bool isCompleted = false;
                    int postingHistoryID = 0;
                    string log = string.Empty;
                    try
                    {
                        BOSApp.SwitchConnection(centre.BRBranchID);
                        if (BOSApp.TestCurrentConnection())
                        {
                            BRPostingHistorysController objPostingHistorysController = new BRPostingHistorysController();
                            BRPostingHistorysInfo objPostingHistorysInfo = objPostingHistorysController.GetPostingHistoryByStatusAndType(
                                                                                                    DataExchangeStatus.Posting.ToString(),
                                                                                                    DataExchangeType.Sale.ToString());
                            if (objPostingHistorysInfo != null)
                            {
                                return;
                            }

                            TransferStatus = DataExchangeStatus.Posting.ToString();
                            postingHistoryID = CreatePostingHistory(0, objBranchsInfo.BRBranchID, DataExchangeType.Sale.ToString(), DataExchangeStatus.Posting.ToString());

                            #region Transfer sale orders
                            foreach (ARSaleOrdersInfo objSaleOrdersInfo in saleOrders)
                            {
                                ARSaleOrdersInfo centralSaleOrder = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByNo(objSaleOrdersInfo.ARSaleOrderNo);
                                int centralSaleOrderID = 0;
                                if (centralSaleOrder != null)
                                {
                                    centralSaleOrderID = centralSaleOrder.ARSaleOrderID;
                                    centralSaleOrder = (ARSaleOrdersInfo)objSaleOrdersInfo.Clone();
                                    centralSaleOrder.ARSaleOrderID = centralSaleOrderID;
                                    centralSaleOrder.FK_ARCustomerID = 0;
                                    ARCustomersInfo centralCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objSaleOrdersInfo.ARCustomerNo);
                                    if (centralCustomer != null)
                                    {
                                        centralSaleOrder.FK_ARCustomerID = centralCustomer.ARCustomerID;
                                    }
                                    centralSaleOrder.ARSaleOrderTransferredDate = BOSApp.GetCurrentServerDate();
                                    centralSaleOrderID = objSaleOrdersController.UpdateObject(centralSaleOrder);
                                }
                                else
                                {
                                    centralSaleOrder = (ARSaleOrdersInfo)objSaleOrdersInfo.Clone();
                                    centralSaleOrder.FK_ARCustomerID = 0;
                                    ARCustomersInfo centralCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objSaleOrdersInfo.ARCustomerNo);
                                    if (centralCustomer != null)
                                    {
                                        centralSaleOrder.FK_ARCustomerID = centralCustomer.ARCustomerID;
                                    }
                                    centralSaleOrder.AAUpdatedDate = DateTime.MaxValue;
                                    centralSaleOrderID = objSaleOrdersController.CreateObject(centralSaleOrder);
                                }

                                if (centralSaleOrderID > 0)
                                {
                                    //Transfer invoice items
                                    TransferSaleOrderItemsToCentre(objSaleOrdersInfo.SaleOrderItems, centralSaleOrderID);
                                }
                            }
                            #endregion

                            #region Transfer invoices
                            foreach (ARInvoicesInfo objInvoicesInfo in invoices)
                            {
                                ARInvoicesInfo centralInvoice = (ARInvoicesInfo)objInvoicesController.GetObjectByNo(objInvoicesInfo.ARInvoiceNo);
                                int centralInvoiceID = 0;
                                if (centralInvoice != null)
                                {
                                    centralInvoiceID = centralInvoice.ARInvoiceID;
                                    centralInvoice = (ARInvoicesInfo)objInvoicesInfo.Clone();
                                    centralInvoice.ARInvoiceID = centralInvoiceID;
                                    centralInvoice.FK_ARCustomerID = 0;
                                    ARCustomersInfo centralCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objInvoicesInfo.ARCustomerNo);
                                    if (centralCustomer != null)
                                    {
                                        centralInvoice.FK_ARCustomerID = centralCustomer.ARCustomerID;
                                    }
                                    centralInvoice.ARInvoiceTransferredDate = BOSApp.GetCurrentServerDate();
                                    centralInvoiceID = objInvoicesController.UpdateObject(centralInvoice);
                                }
                                else
                                {
                                    centralInvoice = (ARInvoicesInfo)objInvoicesInfo.Clone();
                                    centralInvoice.FK_ARCustomerID = 0;
                                    ARCustomersInfo centralCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objInvoicesInfo.ARCustomerNo);
                                    if (centralCustomer != null)
                                    {
                                        centralInvoice.FK_ARCustomerID = centralCustomer.ARCustomerID;
                                    }
                                    centralInvoice.AAUpdatedDate = DateTime.MaxValue;
                                    centralInvoiceID = objInvoicesController.CreateObject(centralInvoice);
                                }

                                if (centralInvoiceID > 0)
                                {
                                    TransferInvoiceItemsToCentre(objInvoicesInfo.InvoiceItems, centralInvoiceID);
                                }
                            }
                            #endregion

                            #region Transfer cancel vouchers
                            foreach (ARCancelVouchersInfo objCancelVouchersInfo in cancelVouchers)
                            {
                                int centralCancelVoucherID = 0;
                                ARCancelVouchersInfo centralCancelVoucher = (ARCancelVouchersInfo)objCancelVouchersController.GetObjectByNo(objCancelVouchersInfo.ARCancelVoucherNo);
                                if (centralCancelVoucher != null)
                                {
                                    centralCancelVoucherID = centralCancelVoucher.ARCancelVoucherID;
                                    int centralSaleOrderID = centralCancelVoucher.FK_ARSaleOrderID;
                                    centralCancelVoucher = (ARCancelVouchersInfo)objCancelVouchersInfo.Clone();
                                    centralCancelVoucher.ARCancelVoucherID = centralCancelVoucherID;
                                    centralCancelVoucher.FK_ARCustomerID = 0;
                                    ARCustomersInfo centralCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objCancelVouchersInfo.ARCustomerNo);
                                    if (centralCustomer != null)
                                    {
                                        centralCancelVoucher.FK_ARCustomerID = centralCustomer.ARCustomerID;
                                    }
                                    centralCancelVoucher.FK_ARSaleOrderID = centralSaleOrderID;
                                    centralCancelVoucher.ARCancelVoucherTransferredDate = BOSApp.GetCurrentServerDate();
                                    objCancelVouchersController.UpdateObject(centralCancelVoucher);
                                }
                                else
                                {
                                    centralCancelVoucher = (ARCancelVouchersInfo)objCancelVouchersInfo.Clone();
                                    centralCancelVoucher.FK_ARCustomerID = 0;
                                    ARCustomersInfo centralCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objCancelVouchersInfo.ARCustomerNo);
                                    if (centralCustomer != null)
                                    {
                                        centralCancelVoucher.FK_ARCustomerID = centralCustomer.ARCustomerID;
                                    }

                                    ARSaleOrdersInfo refSaleOrder = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByNo(objCancelVouchersInfo.ARSaleOrderNo);
                                    if (refSaleOrder != null)
                                    {
                                        centralCancelVoucher.FK_ARSaleOrderID = refSaleOrder.ARSaleOrderID;
                                    }
                                    centralCancelVoucher.AAUpdatedDate = DateTime.MaxValue;
                                    centralCancelVoucherID = objCancelVouchersController.CreateObject(centralCancelVoucher);
                                }

                                if (centralCancelVoucherID > 0)
                                {
                                    TransferCancelVoucherItemsToCentre(objCancelVouchersInfo.CancelVoucherItems, centralCancelVoucherID);
                                }
                            }
                            #endregion

                            #region Transfer sale returns
                            foreach (ARSaleReturnsInfo objSaleReturnsInfo in saleReturns)
                            {
                                int centralSaleReturnID = 0;
                                ARSaleReturnsInfo centralSaleReturn = (ARSaleReturnsInfo)objSaleReturnsController.GetObjectByNo(objSaleReturnsInfo.ARSaleReturnNo);
                                if (centralSaleReturn != null)
                                {
                                    centralSaleReturnID = centralSaleReturn.ARSaleReturnID;
                                    int centralInvoiceID = centralSaleReturn.FK_ARInvoiceID;
                                    centralSaleReturn = (ARSaleReturnsInfo)objSaleReturnsInfo.Clone();
                                    centralSaleReturn.ARSaleReturnID = centralSaleReturnID;
                                    centralSaleReturn.FK_ARCustomerID = 0;
                                    ARCustomersInfo centralCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objSaleReturnsInfo.ARCustomerNo);
                                    if (centralCustomer != null)
                                    {
                                        centralSaleReturn.FK_ARCustomerID = centralCustomer.ARCustomerID;
                                    }
                                    centralSaleReturn.FK_ARInvoiceID = centralInvoiceID;
                                    centralSaleReturn.ARSaleReturnTransferredDate = BOSApp.GetCurrentServerDate();
                                    objSaleReturnsController.UpdateObject(centralSaleReturn);
                                }
                                else
                                {
                                    centralSaleReturn = (ARSaleReturnsInfo)objSaleReturnsInfo.Clone();
                                    centralSaleReturn.FK_ARCustomerID = 0;
                                    ARCustomersInfo centralCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objSaleReturnsInfo.ARCustomerNo);
                                    if (centralCustomer != null)
                                    {
                                        centralSaleReturn.FK_ARCustomerID = centralCustomer.ARCustomerID;
                                    }

                                    ARInvoicesInfo refInvoice = (ARInvoicesInfo)objInvoicesController.GetObjectByNo(objSaleReturnsInfo.ARInvoiceNo);
                                    if (refInvoice != null)
                                    {
                                        centralSaleReturn.FK_ARInvoiceID = refInvoice.ARInvoiceID;
                                    }
                                    centralSaleReturn.AAUpdatedDate = DateTime.MaxValue;
                                    centralSaleReturnID = objSaleReturnsController.CreateObject(centralSaleReturn);
                                }

                                if (centralSaleReturnID > 0)
                                {
                                    TransferSaleReturnItemsToCentre(objSaleReturnsInfo.SaleReturnItems, centralSaleReturnID);
                                }
                            }
                            #endregion

                            #region Transfer customer payments
                            TransferOpenDocumentsToCentre(openDocuments);

                            TransferCustomerPaymentsToCentre(customerPayments);
                            #endregion

                            isCompleted = true;
                            MessageBox.Show(DataExchangeLocalizedResources.TransferSuccessMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(string.Format(DataExchangeLocalizedResources.CannotConnectToCentre, centre.BRBranchName), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        log = ex.Message;
                    }
                    finally
                    {
                        if (postingHistoryID > 0)
                        {
                            //Update posting history in centre
                            if (isCompleted)
                            {
                                CreatePostingHistory(postingHistoryID, objBranchsInfo.BRBranchID, DataExchangeType.Sale.ToString(), DataExchangeStatus.Complete.ToString());
                            }
                            else
                            {
                                CreatePostingHistory(postingHistoryID, objBranchsInfo.BRBranchID, DataExchangeType.Sale.ToString(), DataExchangeStatus.Failed.ToString(), log);
                            }
                        }
                        BOSApp.RollbackLocalConnection();

                        if (postingHistoryID > 0)
                        {
                            if (isCompleted)
                            {
                                //Update sale data at local
                                UpdateLocalSaleOrderStatus(saleOrders);
                                UpdateLocalInvoiceStatus(invoices);
                                UpdateLocalCancelVoucherStatus(cancelVouchers);
                                UpdateLocalSaleReturnStatus(saleReturns);
                                UpdateLocalOpenDocumentStatus(openDocuments);
                                UpdateLocalCustomerPaymentStatus(customerPayments);

                                //Enable the button for transferring purchase data
                                (Controls[DataExchangeModule.TransferPurchaseDataToCentreButtonName] as BOSButton).Enabled = true;
                            }

                            //Create posting history in branch
                            if (isCompleted)
                                CreatePostingHistory(0, objBranchsInfo.BRBranchID, DataExchangeType.Sale.ToString(), DataExchangeStatus.Complete.ToString());
                            else
                                CreatePostingHistory(0, objBranchsInfo.BRBranchID, DataExchangeType.Sale.ToString(), DataExchangeStatus.Failed.ToString(), log);
                        }
                    }
                }
            }
            TransferTimer.Stop();
            BOSProgressBar.Close();
        }

        /// <summary>
        /// Transfer the item list of a sale order to centre
        /// </summary>
        /// <param name="saleOrderItems">Sale order item list</param>
        /// <param name="centralSaleOrderID">ID of the central sale order</param>
        private void TransferSaleOrderItemsToCentre(IList<ARSaleOrderItemsInfo> saleOrderItems, int centralSaleOrderID)
        {
            ARSaleOrderItemsController objSaleOrderItemsController = new ARSaleOrderItemsController();
            ARSOItemComponentsController objSOItemComponentsController = new ARSOItemComponentsController();
            objSaleOrderItemsController.DeleteBySaleOrderID(centralSaleOrderID);
            foreach (ARSaleOrderItemsInfo objSaleOrderItemsInfo in saleOrderItems)
            {
                ARSaleOrderItemsInfo centralItem = (ARSaleOrderItemsInfo)objSaleOrderItemsInfo.Clone();
                centralItem.FK_ARSaleOrderID = centralSaleOrderID;
                SynProductSerie(centralItem);
                int centralSaleOrderItemID = objSaleOrderItemsController.CreateObject(centralItem);

                foreach (ARSOItemComponentsInfo objSOItemComponentsInfo in objSaleOrderItemsInfo.ARSOItemComponentList)
                {
                    ARSOItemComponentsInfo centralItemComponent = (ARSOItemComponentsInfo)objSOItemComponentsInfo.Clone();
                    centralItemComponent.FK_ARSaleOrderItemID = centralSaleOrderItemID;
                    SynProductSerie(centralItemComponent);
                    objSOItemComponentsController.CreateObject(centralItemComponent);
                }
            }
        }

        private void TransferInvoiceItemsToCentre(IList<ARInvoiceItemsInfo> invoiceItems, int centralInvoiceID)
        {
            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
            ARInvoiceItemComponentsController objInvoiceItemComponentsController = new ARInvoiceItemComponentsController();
            objInvoiceItemsController.DeleteByInvoiceID(centralInvoiceID);

            foreach (ARInvoiceItemsInfo objInvoiceItemsInfo in invoiceItems)
            {
                ARInvoiceItemsInfo centralItem = (ARInvoiceItemsInfo)objInvoiceItemsInfo.Clone();
                centralItem.FK_ARInvoiceID = centralInvoiceID;
                SynProductSerie(centralItem);
                centralItem.FK_ARSaleOrderID = 0;
                centralItem.FK_ARSaleOrderItemID = 0;
                int centralInvoiceItemID = objInvoiceItemsController.CreateObject(centralItem);

                foreach (ARInvoiceItemComponentsInfo objInvoiceItemComponentsInfo in objInvoiceItemsInfo.InvoiceItemComponentList)
                {
                    ARInvoiceItemComponentsInfo centralItemComponent = (ARInvoiceItemComponentsInfo)objInvoiceItemComponentsInfo.Clone();
                    centralItemComponent.FK_ARInvoiceItemID = centralInvoiceItemID;
                    SynProductSerie(centralItemComponent);
                    objInvoiceItemComponentsController.CreateObject(centralItemComponent);
                }
            }
        }

        #region Transfer customer payments to centre
        private void TransferOpenDocumentsToCentre(List<AROpenDocumentsInfo> openDocuments)
        {
            AROpenDocumentsController objOpenDocumentsController = new AROpenDocumentsController();
            ARCustomersController objCustomersController = new ARCustomersController();
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            foreach (AROpenDocumentsInfo objOpenDocumentsInfo in openDocuments)
            {
                AROpenDocumentsInfo centralOpenDocument = (AROpenDocumentsInfo)objOpenDocumentsController.GetObjectByNo(objOpenDocumentsInfo.AROpenDocumentNo);
                if (centralOpenDocument != null)
                {
                    int centralOpenDocumentID = centralOpenDocument.AROpenDocumentID;
                    int centralInvoiceID = centralOpenDocument.FK_ARInvoiceID;
                    centralOpenDocument = (AROpenDocumentsInfo)objOpenDocumentsInfo.Clone();
                    centralOpenDocument.AROpenDocumentID = centralOpenDocumentID;
                    centralOpenDocument.FK_ARCustomerID = 0;
                    ARCustomersInfo centralCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objOpenDocumentsInfo.ARCustomerNo);
                    if (centralCustomer != null)
                    {
                        centralOpenDocument.FK_ARCustomerID = centralCustomer.ARCustomerID;
                    }
                    centralOpenDocument.FK_ARInvoiceID = centralInvoiceID;
                    centralOpenDocument.AROpenDocumentTransferredDate = BOSApp.GetCurrentServerDate();
                    objOpenDocumentsController.UpdateObject(centralOpenDocument);
                }
                else
                {
                    centralOpenDocument = (AROpenDocumentsInfo)objOpenDocumentsInfo.Clone();
                    centralOpenDocument.FK_ARCustomerID = 0;
                    centralOpenDocument.FK_ARInvoiceID = 0;
                    ARCustomersInfo centralCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objOpenDocumentsInfo.ARCustomerNo);
                    if (centralCustomer != null)
                    {
                        centralOpenDocument.FK_ARCustomerID = centralCustomer.ARCustomerID;
                    }

                    if (!string.IsNullOrEmpty(objOpenDocumentsInfo.ARInvoiceNo))
                    {
                        ARInvoicesInfo centralInvoice = (ARInvoicesInfo)objInvoicesController.GetObjectByNo(objOpenDocumentsInfo.ARInvoiceNo);
                        if (centralInvoice != null)
                        {
                            centralOpenDocument.FK_ARInvoiceID = centralInvoice.ARInvoiceID;
                        }
                    }
                    centralOpenDocument.AAUpdatedDate = DateTime.MaxValue;
                    objOpenDocumentsController.CreateObject(centralOpenDocument);
                }
            }
        }

        private void TransferCustomerPaymentsToCentre(List<ARCustomerPaymentsInfo> customerPayments)
        {
            ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
            ARCustomerPaymentDetailsController objCustomerPaymentDetailsController = new ARCustomerPaymentDetailsController();
            ARCustomerPaymentCurrencysController objCustomerPaymentCurrencysController = new ARCustomerPaymentCurrencysController();
            ARDocumentPaymentsController objDocumentPaymentsController = new ARDocumentPaymentsController();
            ARCustomersController objCustomersController = new ARCustomersController();
            AROpenDocumentsController objOpenDocumentsController = new AROpenDocumentsController();
            foreach (ARCustomerPaymentsInfo objCustomerPaymentsInfo in customerPayments)
            {
                ARCustomerPaymentsInfo centralCustomerPayment = (ARCustomerPaymentsInfo)objCustomerPaymentsController.GetObjectByNo(objCustomerPaymentsInfo.ARCustomerPaymentNo);
                int centralCustomerPaymentID = 0;
                if (centralCustomerPayment != null)
                {
                    centralCustomerPaymentID = centralCustomerPayment.ARCustomerPaymentID;
                    centralCustomerPayment = (ARCustomerPaymentsInfo)objCustomerPaymentsInfo.Clone();
                    centralCustomerPayment.ARCustomerPaymentID = centralCustomerPaymentID;
                    centralCustomerPayment.FK_ARCustomerID = 0;
                    ARCustomersInfo centralCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objCustomerPaymentsInfo.ARCustomerNo);
                    if (centralCustomer != null)
                    {
                        centralCustomerPayment.FK_ARCustomerID = centralCustomer.ARCustomerID;
                    }
                    centralCustomerPayment.ARCustomerPaymentTransferredDate = BOSApp.GetCurrentServerDate();
                    centralCustomerPaymentID = objCustomerPaymentsController.UpdateObject(centralCustomerPayment);
                }
                else
                {
                    centralCustomerPayment = (ARCustomerPaymentsInfo)objCustomerPaymentsInfo.Clone();
                    centralCustomerPayment.FK_ARCustomerID = 0;
                    ARCustomersInfo centralCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objCustomerPaymentsInfo.ARCustomerNo);
                    if (centralCustomer != null)
                    {
                        centralCustomerPayment.FK_ARCustomerID = centralCustomer.ARCustomerID;
                    }
                    centralCustomerPayment.AAUpdatedDate = DateTime.MaxValue;
                    centralCustomerPaymentID = objCustomerPaymentsController.CreateObject(centralCustomerPayment);
                }

                //Delete all relative data of the payment
                objCustomerPaymentDetailsController.DeleteByCustomerPaymentID(centralCustomerPaymentID);

                //Transfer payment details                                
                foreach (ARCustomerPaymentDetailsInfo objCustomerPaymentDetailsInfo in objCustomerPaymentsInfo.PaymentDetails)
                {
                    objCustomerPaymentDetailsInfo.FK_ARCustomerPaymentID = centralCustomerPaymentID;
                    objCustomerPaymentDetailsController.CreateObject(objCustomerPaymentDetailsInfo);

                    //Transfer payments by currencies of the payment details
                    foreach (ARCustomerPaymentCurrencysInfo objCustomerPaymentCurrencysInfo in objCustomerPaymentDetailsInfo.PaymentCurrencys)
                    {
                        objCustomerPaymentCurrencysInfo.FK_ARCustomerPaymentDetailID = objCustomerPaymentDetailsInfo.ARCustomerPaymentDetailID;
                        objCustomerPaymentCurrencysController.CreateObject(objCustomerPaymentCurrencysInfo);
                    }
                }

                //Transfer document payments
                foreach (ARDocumentPaymentsInfo objDocumentPaymentsInfo in objCustomerPaymentsInfo.DocumentPayments)
                {
                    ARDocumentPaymentsInfo centralDocumentPayment = (ARDocumentPaymentsInfo)objDocumentPaymentsInfo.Clone();
                    centralDocumentPayment.FK_ARCustomerPaymentID = centralCustomerPaymentID;
                    centralDocumentPayment.FK_AROpenDocumentID = 0;
                    AROpenDocumentsInfo centralOpenDocument = (AROpenDocumentsInfo)objOpenDocumentsController.GetObjectByNo(objDocumentPaymentsInfo.AROpenDocumentNo);
                    if (centralOpenDocument != null)
                    {
                        centralDocumentPayment.FK_AROpenDocumentID = centralOpenDocument.AROpenDocumentID;
                    }
                    objDocumentPaymentsController.CreateObject(centralDocumentPayment);
                }
            }
        }
        #endregion

        /// <summary>
        /// Transfer the item list of a cancel voucher to centre
        /// </summary>
        /// <param name="cancelVoucherItems">Cancel voucher item list</param>
        /// <param name="centralCancelVoucherID">ID of the central cancel voucher</param>        
        private void TransferCancelVoucherItemsToCentre(IList<ARCancelVoucherItemsInfo> cancelVoucherItems, int centralCancelVoucherID)
        {
            ARCancelVoucherItemsController objCancelVoucherItemsController = new ARCancelVoucherItemsController();
            objCancelVoucherItemsController.DeleteByForeignColumn("FK_ARCancelVoucherID", centralCancelVoucherID);
            foreach (ARCancelVoucherItemsInfo objCancelVoucherItemsInfo in cancelVoucherItems)
            {
                ARCancelVoucherItemsInfo centralCancelVoucherItem = (ARCancelVoucherItemsInfo)objCancelVoucherItemsInfo.Clone();
                centralCancelVoucherItem.FK_ARCancelVoucherID = centralCancelVoucherID;
                centralCancelVoucherItem.FK_ARSaleOrderID = 0;
                centralCancelVoucherItem.FK_ARSaleOrderItemID = 0;
                objCancelVoucherItemsController.CreateObject(centralCancelVoucherItem);
            }
        }

        /// <summary>
        /// Transfer the item list of a sale return to centre
        /// </summary>
        /// <param name="saleReturnItems">Sale return item list</param>
        /// <param name="centralSaleReturnID">ID of the central sale return</param>        
        private void TransferSaleReturnItemsToCentre(IList<ARSaleReturnItemsInfo> saleReturnItems, int centralSaleReturnID)
        {
            ARSaleReturnItemsController objSaleReturnItemsController = new ARSaleReturnItemsController();
            objSaleReturnItemsController.DeleteByForeignColumn("FK_ARSaleReturnID", centralSaleReturnID);
            foreach (ARSaleReturnItemsInfo objSaleReturnItemsInfo in saleReturnItems)
            {
                ARSaleReturnItemsInfo centralItem = (ARSaleReturnItemsInfo)objSaleReturnItemsInfo.Clone();
                centralItem.FK_ARSaleReturnID = centralSaleReturnID;
                SynProductSerie(centralItem);
                centralItem.FK_ARInvoiceID = 0;
                centralItem.FK_ARInvoiceItemID = 0;
                objSaleReturnItemsController.CreateObject(centralItem);
            }
        }

        /// <summary>
        /// Update the status of transferred sale orders at local
        /// </summary>
        /// <param name="transferredSaleOrders">List of transferred sale orders</param>
        private void UpdateLocalSaleOrderStatus(List<ARSaleOrdersInfo> transferredSaleOrders)
        {
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            foreach (ARSaleOrdersInfo objSaleOrdersInfo in transferredSaleOrders)
            {
                objSaleOrdersInfo.IsTransferred = true;
                objSaleOrdersInfo.ARSaleOrderTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objSaleOrdersController.UpdateObject(objSaleOrdersInfo);
            }
        }

        /// <summary>
        /// Update the status of transferred invoices at local
        /// </summary>
        /// <param name="transferredInvoices">Transferred invoices</param>
        private void UpdateLocalInvoiceStatus(List<ARInvoicesInfo> transferredInvoices)
        {
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            foreach (ARInvoicesInfo objInvoicesInfo in transferredInvoices)
            {
                objInvoicesInfo.IsTransferred = true;
                objInvoicesInfo.ARInvoiceTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objInvoicesController.UpdateObject(objInvoicesInfo);
            }
        }

        /// <summary>
        /// Update the status of transferred cancel vouchers at local
        /// </summary>
        /// <param name="transferredCancelVouchers">List of transferred cancel vouchers</param>
        private void UpdateLocalCancelVoucherStatus(List<ARCancelVouchersInfo> transferredCancelVouchers)
        {
            ARCancelVouchersController objCancelVouchersController = new ARCancelVouchersController();
            foreach (ARCancelVouchersInfo objCancelVouchersInfo in transferredCancelVouchers)
            {
                objCancelVouchersInfo.IsTransferred = true;
                objCancelVouchersInfo.ARCancelVoucherTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objCancelVouchersController.UpdateObject(objCancelVouchersInfo);
            }
        }

        /// <summary>
        /// Update the status of transferred sale returns at local
        /// </summary>
        /// <param name="transferredSaleReturns">List of transferred sale returns</param>
        private void UpdateLocalSaleReturnStatus(List<ARSaleReturnsInfo> transferredSaleReturns)
        {
            ARSaleReturnsController objSaleReturnsController = new ARSaleReturnsController();
            foreach (ARSaleReturnsInfo objSaleReturnsInfo in transferredSaleReturns)
            {
                objSaleReturnsInfo.IsTransferred = true;
                objSaleReturnsInfo.ARSaleReturnTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objSaleReturnsController.UpdateObject(objSaleReturnsInfo);
            }
        }

        /// <summary>
        /// Update the status of transferred open documents at local
        /// </summary>
        /// <param name="transferredOpenDocuments">List of transferred open documents</param>
        private void UpdateLocalOpenDocumentStatus(List<AROpenDocumentsInfo> transferredOpenDocuments)
        {
            AROpenDocumentsController objOpenDocumentsController = new AROpenDocumentsController();
            foreach (AROpenDocumentsInfo objOpenDocumentsInfo in transferredOpenDocuments)
            {
                objOpenDocumentsInfo.IsTransferred = true;
                objOpenDocumentsInfo.AROpenDocumentTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objOpenDocumentsController.UpdateObject(objOpenDocumentsInfo);
            }
        }

        /// <summary>
        /// Update the status of transferred customer payments at local
        /// </summary>
        /// <param name="transferredCustomerPayments">List of transferred customer payments</param>
        private void UpdateLocalCustomerPaymentStatus(List<ARCustomerPaymentsInfo> transferredCustomerPayments)
        {
            ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
            foreach (ARCustomerPaymentsInfo objCustomerPaymentsInfo in transferredCustomerPayments)
            {
                objCustomerPaymentsInfo.IsTransferred = true;
                objCustomerPaymentsInfo.ARCustomerPaymentTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objCustomerPaymentsController.UpdateObject(objCustomerPaymentsInfo);
            }
        }
        #endregion

        #region Transfer customers
        public void TransferCustomersFromBranchToCentre(object sender)
        {
            BOSProgressBar.Start(DataExchangeLocalizedResources.TransferringCustomerToHeadquarterMessage);
            TransferType = DataExchangeType.Customer.ToString();
            TransferStatus = DataExchangeStatus.New.ToString();
            TransferTimer.Start();

            TransferCustomersFromBranchToCentre();
        }

        public void TransferCustomersFromBranchToCentre()
        {
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objBranchsInfo != null && objBranchsInfo.BRBranchParentID > 0)
            {
                BRBranchsInfo centre = (BRBranchsInfo)objBranchsController.GetObjectByID(objBranchsInfo.BRBranchParentID);
                if (centre != null)
                {
                    ARCustomersController objCustomersController = new ARCustomersController();
                    ARCustomerContactsController objCustomerContactsController = new ARCustomerContactsController();
                    List<ARCustomersInfo> customers = objCustomersController.GetCustomersForTransferring();
                    foreach (ARCustomersInfo objCustomersInfo in customers)
                    {
                        objCustomersInfo.CustomerContacts = new BOSList<ARCustomerContactsInfo>(TableName.ARCustomerContactsTableName);
                        DataSet ds = objCustomerContactsController.GetAllDataByForeignColumn("FK_ARCustomerID", objCustomersInfo.ARCustomerID);
                        objCustomersInfo.CustomerContacts.Invalidate(ds);
                    }

                    ARCreditNotesController objCreditNotesController = new ARCreditNotesController();
                    List<ARCreditNotesInfo> creditNotes = objCreditNotesController.GetCreditNotesForTransferring();

                    bool isCompleted = false;
                    int postingHistoryID = 0;
                    string log = string.Empty;
                    try
                    {
                        BOSApp.SwitchConnection(centre.BRBranchID);
                        if (BOSApp.TestCurrentConnection())
                        {
                            //Check for existing branch posting
                            BRPostingHistorysInfo objPostingHistorysInfo = new BRPostingHistorysController().GetPostingHistoryByStatusAndType(DataExchangeStatus.Posting.ToString(), DataExchangeType.Customer.ToString());
                            if (objPostingHistorysInfo != null)
                            {
                                return;
                            }

                            TransferStatus = DataExchangeStatus.Posting.ToString();
                            //Create posting history with status is 'posting' to prevent branchs from post
                            postingHistoryID = CreatePostingHistory(0, objBranchsInfo.BRBranchID, DataExchangeType.Customer.ToString(), DataExchangeStatus.Posting.ToString());

                            #region Transfer customers
                            foreach (ARCustomersInfo objCustomersInfo in customers)
                            {
                                ARCustomersInfo centralCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(objCustomersInfo.ARCustomerNo);
                                if (centralCustomer != null)
                                {
                                    //Update existing customer
                                    int centralCustomerID = centralCustomer.ARCustomerID;
                                    centralCustomer = (ARCustomersInfo)objCustomersInfo.Clone();
                                    centralCustomer.ARCustomerID = centralCustomerID;
                                    centralCustomer.ARCustomerTransferredDate = BOSApp.GetCurrentServerDate();
                                    objCustomersController.UpdateObject(centralCustomer);

                                    TransferCustomerContacts(objCustomersInfo.CustomerContacts, centralCustomer.ARCustomerID);
                                }
                                else
                                {
                                    //Create new customer
                                    centralCustomer = (ARCustomersInfo)objCustomersInfo.Clone();
                                    centralCustomer.AAUpdatedDate = DateTime.MaxValue;
                                    int centralCustomerID = objCustomersController.CreateObject(centralCustomer);

                                    TransferCustomerContacts(objCustomersInfo.CustomerContacts, centralCustomerID);
                                }
                            }
                            #endregion

                            #region Transfer credit notes
                            foreach (ARCreditNotesInfo creditNote in creditNotes)
                            {
                                ARCreditNotesInfo centralCreditNote = (ARCreditNotesInfo)objCreditNotesController.GetObjectByNo(creditNote.ARCreditNoteNo);
                                if (centralCreditNote != null)
                                {
                                    int centralCreditNoteID = centralCreditNote.ARCreditNoteID;
                                    int customerID = centralCreditNote.FK_ARCustomerID;
                                    centralCreditNote = (ARCreditNotesInfo)creditNote.Clone();
                                    centralCreditNote.ARCreditNoteID = centralCreditNoteID;
                                    centralCreditNote.FK_ARCustomerID = customerID;
                                    centralCreditNote.ARCreditNoteTransferredDate = BOSApp.GetCurrentServerDate();
                                    objCreditNotesController.UpdateObject(centralCreditNote);
                                }
                                else
                                {
                                    centralCreditNote = (ARCreditNotesInfo)creditNote.Clone();
                                    centralCreditNote.FK_ARCustomerID = 0;
                                    if (!string.IsNullOrEmpty(centralCreditNote.ARCustomerNo))
                                    {
                                        ARCustomersInfo branchCustomer = (ARCustomersInfo)objCustomersController.GetObjectByNo(creditNote.ARCustomerNo);
                                        if (branchCustomer != null)
                                        {
                                            centralCreditNote.FK_ARCustomerID = branchCustomer.ARCustomerID;
                                        }
                                    }
                                    centralCreditNote.AAUpdatedDate = DateTime.MaxValue;
                                    objCreditNotesController.CreateObject(centralCreditNote);
                                }
                            }
                            #endregion

                            isCompleted = true;
                            MessageBox.Show(DataExchangeLocalizedResources.TransferSuccessMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(string.Format(DataExchangeLocalizedResources.CannotConnectToCentre, centre.BRBranchName), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        log = ex.Message;
                    }
                    finally
                    {
                        //Create posting history in centre
                        if (postingHistoryID > 0)
                        {
                            if (isCompleted)
                                CreatePostingHistory(postingHistoryID, objBranchsInfo.BRBranchID, DataExchangeType.Customer.ToString(), DataExchangeStatus.Complete.ToString());
                            else
                                CreatePostingHistory(postingHistoryID, objBranchsInfo.BRBranchID, DataExchangeType.Customer.ToString(), DataExchangeStatus.Failed.ToString(), log);
                        }
                        BOSApp.RollbackLocalConnection();
                        if (postingHistoryID > 0)
                        {
                            //Create posting history in branch
                            if (isCompleted)
                            {
                                UpdateLocalCustomerStatus(customers);
                                UpdateLocalCreditNoteStatus(creditNotes);

                                CreatePostingHistory(0, objBranchsInfo.BRBranchID, DataExchangeType.Customer.ToString(), DataExchangeStatus.Complete.ToString());
                            }
                            else
                                CreatePostingHistory(postingHistoryID, objBranchsInfo.BRBranchID, DataExchangeType.Customer.ToString(), DataExchangeStatus.Failed.ToString(), log);
                        }

                        if (isCompleted)
                        {
                            Control button = Controls[DataExchangeModule.TransferInventoryToCentreButtonName];
                            button.Enabled = true;
                        }
                    }
                }
            }

            TransferTimer.Stop();
            BOSProgressBar.Close();
        }

        /// <summary>
        /// Transfer the contacts of a customer to the branch
        /// </summary>
        /// <param name="branchCustomerID">Customer id</param>
        private void TransferCustomerContacts(IList<ARCustomerContactsInfo> customerContacts, int branchCustomerID)
        {
            //Delete existing contacts
            ARCustomerContactsController objCustomerContactsController = new ARCustomerContactsController();
            objCustomerContactsController.DeleteByForeignColumn("FK_ARCustomerID", branchCustomerID);

            //Create new contacts
            foreach (ARCustomerContactsInfo objCustomerContactsInfo in customerContacts)
            {
                objCustomerContactsInfo.FK_ARCustomerID = branchCustomerID;
                objCustomerContactsController.CreateObject(objCustomerContactsInfo);
            }
        }
        #endregion

        #region Transfer purchase data
        /// <summary>
        /// Called when user transfers purchase data to the centre
        /// </summary>
        /// <param name="sender">Event sender</param>
        public void TransferPurchaseDataFromBranchToCentre(object sender)
        {
            BOSProgressBar.Start(DataExchangeLocalizedResources.TransferringPurchaseDataToHeadquarterMessage);
            TransferType = DataExchangeType.Purchase.ToString();
            TransferStatus = DataExchangeStatus.New.ToString();
            TransferTimer.Start();

            TransferPurchaseDataFromBranchToCentre();
        }

        /// <summary>
        /// Transfer purchase data from the current branch to the centre
        /// </summary>
        private void TransferPurchaseDataFromBranchToCentre()
        {
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objBranchsInfo != null && objBranchsInfo.BRBranchParentID > 0)
            {
                BRBranchsInfo centre = (BRBranchsInfo)objBranchsController.GetObjectByID(objBranchsInfo.BRBranchParentID);
                if (centre != null)
                {
                    APSuppliersController objSuppliersController = new APSuppliersController();

                    #region Get invoices at local
                    APInvoiceInsController objInvoicesController = new APInvoiceInsController();
                    APInvoiceInItemsController objInvoiceItemsController = new APInvoiceInItemsController();
                    List<APInvoiceInsInfo> invoices = objInvoicesController.GetInvoicesForTransferring();
                    foreach (APInvoiceInsInfo objInvoicesInfo in invoices)
                    {
                        //Get invoice items
                        objInvoicesInfo.InvoiceItems = objInvoiceItemsController.GetItemsByInvoiceID(objInvoicesInfo.APInvoiceInID);
                    }
                    #endregion

                    #region Get supplier payments at local
                    APSupplierPaymentsController objSupplierPaymentsController = new APSupplierPaymentsController();
                    APDocumentPaymentsController objDocumentPaymentsController = new APDocumentPaymentsController();
                    APSupplierPaymentDetailsController objSupplierPaymentDetailsController = new APSupplierPaymentDetailsController();
                    List<APSupplierPaymentsInfo> supplierPayments = objSupplierPaymentsController.GetSupplierPaymentsForTransferring();
                    foreach (APSupplierPaymentsInfo objSupplierPaymentsInfo in supplierPayments)
                    {
                        //Get payment details
                        objSupplierPaymentsInfo.PaymentDetails = objSupplierPaymentDetailsController.GetDetailsByPaymentID(objSupplierPaymentsInfo.APSupplierPaymentID);

                        //Get document payments
                        objSupplierPaymentsInfo.DocumentPayments = objDocumentPaymentsController.GetDocumentPaymentsBySupplierPaymentID(objSupplierPaymentsInfo.APSupplierPaymentID);
                    }

                    //Get open documents
                    APOpenDocumentsController objOpenDocumentsController = new APOpenDocumentsController();
                    List<APOpenDocumentsInfo> openDocuments = objOpenDocumentsController.GetOpenDocumentsForTransferring();
                    #endregion

                    bool isCompleted = false;
                    int postingHistoryID = 0;
                    string log = string.Empty;
                    try
                    {
                        BOSApp.SwitchConnection(centre.BRBranchID);
                        if (BOSApp.TestCurrentConnection())
                        {
                            BRPostingHistorysController objPostingHistorysController = new BRPostingHistorysController();
                            BRPostingHistorysInfo objPostingHistorysInfo = objPostingHistorysController.GetPostingHistoryByStatusAndType(
                                                                                                    DataExchangeStatus.Posting.ToString(),
                                                                                                    DataExchangeType.Purchase.ToString());
                            if (objPostingHistorysInfo != null)
                            {
                                return;
                            }

                            TransferStatus = DataExchangeStatus.Posting.ToString();
                            postingHistoryID = CreatePostingHistory(0, objBranchsInfo.BRBranchID, DataExchangeType.Purchase.ToString(), DataExchangeStatus.Posting.ToString());

                            #region Transfer invoices
                            foreach (APInvoiceInsInfo objInvoicesInfo in invoices)
                            {
                                APInvoiceInsInfo centralInvoice = (APInvoiceInsInfo)objInvoicesController.GetObjectByNo(objInvoicesInfo.APInvoiceInNo);
                                int centralInvoiceID = 0;
                                if (centralInvoice != null)
                                {
                                    centralInvoiceID = centralInvoice.APInvoiceInID;
                                    centralInvoice = (APInvoiceInsInfo)objInvoicesInfo.Clone();
                                    centralInvoice.APInvoiceInID = centralInvoiceID;
                                    centralInvoice.APInvoiceInTransferredDate = BOSApp.GetCurrentServerDate();
                                    centralInvoiceID = objInvoicesController.UpdateObject(centralInvoice);
                                }
                                else
                                {
                                    centralInvoice = (APInvoiceInsInfo)objInvoicesInfo.Clone();
                                    centralInvoice.AAUpdatedDate = DateTime.MaxValue;
                                    centralInvoiceID = objInvoicesController.CreateObject(centralInvoice);
                                }

                                if (centralInvoiceID > 0)
                                {
                                    TransferInvoiceItemsToCentre(objInvoicesInfo.InvoiceItems, centralInvoiceID);
                                }
                            }
                            #endregion

                            #region Transfer supplier payments
                            TransferOpenDocumentsToCentre(openDocuments);

                            TransferSupplierPaymentsToCentre(supplierPayments);
                            #endregion

                            isCompleted = true;
                            MessageBox.Show(DataExchangeLocalizedResources.TransferSuccessMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(string.Format(DataExchangeLocalizedResources.CannotConnectToCentre, centre.BRBranchName), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        log = ex.Message;
                    }
                    finally
                    {
                        if (postingHistoryID > 0)
                        {
                            //Update posting history in centre
                            if (isCompleted)
                            {
                                CreatePostingHistory(postingHistoryID, objBranchsInfo.BRBranchID, DataExchangeType.Purchase.ToString(), DataExchangeStatus.Complete.ToString());
                            }
                            else
                            {
                                CreatePostingHistory(postingHistoryID, objBranchsInfo.BRBranchID, DataExchangeType.Purchase.ToString(), DataExchangeStatus.Failed.ToString(), log);
                            }
                        }
                        BOSApp.RollbackLocalConnection();

                        if (postingHistoryID > 0)
                        {
                            if (isCompleted)
                            {
                                //Update purchase data at local
                                UpdateLocalInvoiceStatus(invoices);
                                UpdateLocalOpenDocumentStatus(openDocuments);
                                UpdateLocalSupplierPaymentStatus(supplierPayments);

                                //Enable the button for transferring accounting data
                                (Controls[DataExchangeModule.TransferAccountingDataToCentreButtonName] as BOSButton).Enabled = true;
                            }

                            //Create posting history in branch
                            if (isCompleted)
                                CreatePostingHistory(0, objBranchsInfo.BRBranchID, DataExchangeType.Purchase.ToString(), DataExchangeStatus.Complete.ToString());
                            else
                                CreatePostingHistory(0, objBranchsInfo.BRBranchID, DataExchangeType.Purchase.ToString(), DataExchangeStatus.Failed.ToString(), log);


                        }
                    }
                }
            }
            TransferTimer.Stop();
            BOSProgressBar.Close();
        }

        /// <summary>
        /// Transfer items of purchase invoices to the centre
        /// </summary>
        /// <param name="invoiceItems">Transferred items</param>
        /// <param name="centralInvoiceID">Central invoice id</param>
        private void TransferInvoiceItemsToCentre(IList<APInvoiceInItemsInfo> invoiceItems, int centralInvoiceID)
        {
            APInvoiceInItemsController objInvoiceItemsController = new APInvoiceInItemsController();
            objInvoiceItemsController.DeleteByForeignColumn("FK_APInvoiceInID", centralInvoiceID);

            foreach (APInvoiceInItemsInfo objInvoiceItemsInfo in invoiceItems)
            {
                APInvoiceInItemsInfo centralItem = (APInvoiceInItemsInfo)objInvoiceItemsInfo.Clone();
                centralItem.FK_APInvoiceInID = centralInvoiceID;
                centralItem.FK_APPurchaseOrderID = 0;
                centralItem.FK_APPurchaseOrderItemID = 0;
                objInvoiceItemsController.CreateObject(centralItem);
            }
        }

        /// <summary>
        /// Transfer open documents to the centre
        /// </summary>
        /// <param name="openDocuments">Transferred open documents</param>
        private void TransferOpenDocumentsToCentre(List<APOpenDocumentsInfo> openDocuments)
        {
            APOpenDocumentsController objOpenDocumentsController = new APOpenDocumentsController();
            APSuppliersController objSuppliersController = new APSuppliersController();
            APInvoiceInsController objInvoicesController = new APInvoiceInsController();
            foreach (APOpenDocumentsInfo objOpenDocumentsInfo in openDocuments)
            {
                APOpenDocumentsInfo centralOpenDocument = (APOpenDocumentsInfo)objOpenDocumentsController.GetObjectByNo(objOpenDocumentsInfo.APOpenDocumentNo);
                if (centralOpenDocument != null)
                {
                    int centralOpenDocumentID = centralOpenDocument.APOpenDocumentID;
                    int centralInvoiceID = centralOpenDocument.FK_APInvoiceInID;
                    centralOpenDocument = (APOpenDocumentsInfo)objOpenDocumentsInfo.Clone();
                    centralOpenDocument.APOpenDocumentID = centralOpenDocumentID;
                    centralOpenDocument.FK_APInvoiceInID = centralInvoiceID;
                    centralOpenDocument.APOpenDocumentTransferredDate = BOSApp.GetCurrentServerDate();
                    objOpenDocumentsController.UpdateObject(centralOpenDocument);
                }
                else
                {
                    centralOpenDocument = (APOpenDocumentsInfo)objOpenDocumentsInfo.Clone();
                    centralOpenDocument.FK_APInvoiceInID = 0;
                    if (!string.IsNullOrEmpty(objOpenDocumentsInfo.APInvoiceInNo))
                    {
                        APInvoiceInsInfo centralInvoice = (APInvoiceInsInfo)objInvoicesController.GetObjectByNo(objOpenDocumentsInfo.APInvoiceInNo);
                        if (centralInvoice != null)
                        {
                            centralOpenDocument.FK_APInvoiceInID = centralInvoice.APInvoiceInID;
                        }
                    }
                    centralOpenDocument.AAUpdatedDate = DateTime.MaxValue;
                    objOpenDocumentsController.CreateObject(centralOpenDocument);
                }
            }
        }

        /// <summary>
        /// Transfer payments to the centre
        /// </summary>
        /// <param name="supplierPayments">Transferred payments</param>
        private void TransferSupplierPaymentsToCentre(List<APSupplierPaymentsInfo> supplierPayments)
        {
            APSupplierPaymentsController objSupplierPaymentsController = new APSupplierPaymentsController();
            APSupplierPaymentDetailsController objSupplierPaymentDetailsController = new APSupplierPaymentDetailsController();
            APDocumentPaymentsController objDocumentPaymentsController = new APDocumentPaymentsController();
            APSuppliersController objSuppliersController = new APSuppliersController();
            APOpenDocumentsController objOpenDocumentsController = new APOpenDocumentsController();
            foreach (APSupplierPaymentsInfo objSupplierPaymentsInfo in supplierPayments)
            {
                APSupplierPaymentsInfo centralSupplierPayment = (APSupplierPaymentsInfo)objSupplierPaymentsController.GetObjectByNo(objSupplierPaymentsInfo.APSupplierPaymentNo);
                int centralSupplierPaymentID = 0;
                if (centralSupplierPayment != null)
                {
                    centralSupplierPaymentID = centralSupplierPayment.APSupplierPaymentID;
                    centralSupplierPayment = (APSupplierPaymentsInfo)objSupplierPaymentsInfo.Clone();
                    centralSupplierPayment.APSupplierPaymentID = centralSupplierPaymentID;
                    centralSupplierPayment.APSupplierPaymentTransferredDate = BOSApp.GetCurrentServerDate();
                    centralSupplierPaymentID = objSupplierPaymentsController.UpdateObject(centralSupplierPayment);
                }
                else
                {
                    centralSupplierPayment = (APSupplierPaymentsInfo)objSupplierPaymentsInfo.Clone();
                    centralSupplierPayment.AAUpdatedDate = DateTime.MaxValue;
                    centralSupplierPaymentID = objSupplierPaymentsController.CreateObject(centralSupplierPayment);
                }

                //Delete all relative data of the payment
                objSupplierPaymentDetailsController.DeleteBySupplierPaymentID(centralSupplierPaymentID);

                //Transfer payment details                                
                foreach (APSupplierPaymentDetailsInfo objSupplierPaymentDetailsInfo in objSupplierPaymentsInfo.PaymentDetails)
                {
                    objSupplierPaymentDetailsInfo.FK_APSupplierPaymentID = centralSupplierPaymentID;
                    objSupplierPaymentDetailsController.CreateObject(objSupplierPaymentDetailsInfo);
                }

                //Transfer document payments
                foreach (APDocumentPaymentsInfo objDocumentPaymentsInfo in objSupplierPaymentsInfo.DocumentPayments)
                {
                    APDocumentPaymentsInfo centralDocumentPayment = (APDocumentPaymentsInfo)objDocumentPaymentsInfo.Clone();
                    centralDocumentPayment.FK_APSupplierPaymentID = centralSupplierPaymentID;
                    centralDocumentPayment.FK_APOpenDocumentID = 0;
                    APOpenDocumentsInfo centralOpenDocument = (APOpenDocumentsInfo)objOpenDocumentsController.GetObjectByNo(objDocumentPaymentsInfo.APOpenDocumentNo);
                    if (centralOpenDocument != null)
                    {
                        centralDocumentPayment.FK_APOpenDocumentID = centralOpenDocument.APOpenDocumentID;
                    }
                    objDocumentPaymentsController.CreateObject(centralDocumentPayment);
                }
            }
        }

        /// <summary>
        /// Update the status of transferred invoices at local, to track
        /// for the next transfer
        /// </summary>
        /// <param name="invoices">Transferred invoices</param>
        public void UpdateLocalInvoiceStatus(List<APInvoiceInsInfo> invoices)
        {
            APInvoiceInsController objInvoicesController = new APInvoiceInsController();
            foreach (APInvoiceInsInfo invoice in invoices)
            {
                invoice.IsTransferred = true;
                invoice.APInvoiceInTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objInvoicesController.UpdateObject(invoice);
            }
        }

        /// <summary>
        /// Update the status of transferred open documents at local, to track
        /// for the next transfer
        /// </summary>
        /// <param name="openDocuments">Transferred open documents</param>
        public void UpdateLocalOpenDocumentStatus(List<APOpenDocumentsInfo> openDocuments)
        {
            APOpenDocumentsController objOpenDocumentsController = new APOpenDocumentsController();
            foreach (APOpenDocumentsInfo openDocument in openDocuments)
            {
                openDocument.IsTransferred = true;
                openDocument.APOpenDocumentTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objOpenDocumentsController.UpdateObject(openDocument);
            }
        }

        /// <summary>
        /// Update the status of transferred payments at local, to track
        /// for the next transfer
        /// </summary>
        /// <param name="supplierPayments">Transferred payments</param>
        public void UpdateLocalSupplierPaymentStatus(List<APSupplierPaymentsInfo> supplierPayments)
        {
            APSupplierPaymentsController objSupplierPaymentsController = new APSupplierPaymentsController();
            foreach (APSupplierPaymentsInfo supplierPayment in supplierPayments)
            {
                supplierPayment.IsTransferred = true;
                supplierPayment.APSupplierPaymentTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objSupplierPaymentsController.UpdateObject(supplierPayment);
            }
        }
        #endregion

        #region Transfer accounting data
        /// <summary>
        /// Called when user transfers accounting data to the centre
        /// </summary>
        /// <param name="sender">Event sender</param>
        public void TransferAccountingDataFromBranchToCentre(object sender)
        {
            BOSProgressBar.Start(DataExchangeLocalizedResources.TransferringAccountingDataToHeadquarterMessage);
            TransferType = DataExchangeType.Accounting.ToString();
            TransferStatus = DataExchangeStatus.New.ToString();
            TransferTimer.Start();

            TransferAccountingDataFromBranchToCentre();
        }

        /// <summary>
        /// Transfer accounting data from the current branch to the centre
        /// </summary>
        private void TransferAccountingDataFromBranchToCentre()
        {
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objBranchsInfo != null && objBranchsInfo.BRBranchParentID > 0)
            {
                BRBranchsInfo centre = (BRBranchsInfo)objBranchsController.GetObjectByID(objBranchsInfo.BRBranchParentID);
                if (centre != null)
                {
                    #region Get cost objects at local
                    ACCostObjectsController objCostObjectsController = new ACCostObjectsController();
                    List<ACCostObjectsInfo> costObjects = objCostObjectsController.GetCostObjectsForTransferring();
                    #endregion

                    #region Get budget at local
                    ARReceiptVouchersController objReceiptVouchersController = new ARReceiptVouchersController();
                    ARReceiptVoucherItemsController objReceiptVoucherItemsController = new ARReceiptVoucherItemsController();
                    List<ARReceiptVouchersInfo> receiptVouchers = objReceiptVouchersController.GetReceiptVouchersForTransferring();
                    foreach (ARReceiptVouchersInfo receiptVoucher in receiptVouchers)
                    {
                        receiptVoucher.ReceiptVoucherItems = objReceiptVoucherItemsController.GetItemsByReceiptVoucherID(receiptVoucher.ARReceiptVoucherID);
                    }

                    APPaymentVouchersController objPaymentVouchersController = new APPaymentVouchersController();
                    APPaymentVoucherItemsController objPaymentVoucherItemsController = new APPaymentVoucherItemsController();
                    List<APPaymentVouchersInfo> paymentVouchers = objPaymentVouchersController.GetPaymentVouchersForTransferring();
                    foreach (APPaymentVouchersInfo paymentVoucher in paymentVouchers)
                    {
                        paymentVoucher.PaymentVoucherItems = objPaymentVoucherItemsController.GetItemsByPaymentVoucherID(paymentVoucher.APPaymentVoucherID);
                    }
                    #endregion

                    #region Get bank transactions at local
                    ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
                    ACBankTransactionItemsController objBankTransactionItemsController = new ACBankTransactionItemsController();
                    List<ACBankTransactionsInfo> bankTransactions = objBankTransactionsController.GetBankTransactionsForTransferring();
                    foreach (ACBankTransactionsInfo bankTransaction in bankTransactions)
                    {
                        bankTransaction.BankTransactionItems = objBankTransactionItemsController.GetItemsByTransactionID(bankTransaction.ACBankTransactionID);
                    }
                    #endregion

                    #region Get asset data at local
                    ACAssetsController objAssetsController = new ACAssetsController();
                    List<ACAssetsInfo> assets = objAssetsController.GetAssetsForTransferring();

                    ACAssetReceiptsController objAssetReceiptsController = new ACAssetReceiptsController();
                    ACAssetReceiptItemsController objAssetReceiptItemsController = new ACAssetReceiptItemsController();
                    List<ACAssetReceiptsInfo> assetReceipts = objAssetReceiptsController.GetAssetReceiptsForTransferring();
                    foreach (ACAssetReceiptsInfo receipt in assetReceipts)
                    {
                        receipt.AssetReceiptItems = objAssetReceiptItemsController.GetItemsByAssetReceiptID(receipt.ACAssetReceiptID);
                    }

                    ACDocumentsController objDocumentsController = new ACDocumentsController();
                    ACAssetShipmentItemsController objAssetShipmentItemsController = new ACAssetShipmentItemsController();
                    List<ACDocumentsInfo> assetShipments = objDocumentsController.GetDocumentsForTransferring(AccDocumentType.GiamTSCD.ToString());
                    foreach (ACDocumentsInfo assetShipment in assetShipments)
                    {
                        assetShipment.AssetShipmentItems = objAssetShipmentItemsController.GetItemsByDocumentID(assetShipment.ACDocumentID);
                    }

                    ACAssetTransferItemsController objAssetTransferItemsController = new ACAssetTransferItemsController();
                    List<ACDocumentsInfo> assetTransfers = objDocumentsController.GetDocumentsForTransferring(AccDocumentType.DieuChuyenTSCD.ToString());
                    foreach (ACDocumentsInfo assetTransfer in assetTransfers)
                    {
                        assetTransfer.AssetTransferItems = objAssetTransferItemsController.GetItemsByDocumentID(assetTransfer.ACDocumentID);
                    }
                    #endregion

                    #region Get equipment data at local
                    ACEquipmentTransferItemsController objEquipmentTransferItemsController = new ACEquipmentTransferItemsController();
                    List<ACDocumentsInfo> equipmentTransfers = objDocumentsController.GetDocumentsForTransferring(AccDocumentType.DieuChuyenCCDC.ToString());
                    foreach (ACDocumentsInfo equipmentTransfer in equipmentTransfers)
                    {
                        equipmentTransfer.EquipmentTransferItems = objEquipmentTransferItemsController.GetItemsByDocumentID(equipmentTransfer.ACDocumentID);
                    }
                    #endregion                    

                    #region Get general accounting data at local
                    ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                    ACRelativeDocumentsController objRelativeDocumentsController = new ACRelativeDocumentsController();
                    List<ACDocumentsInfo> documents = objDocumentsController.GetDocumentsForTransferring();
                    foreach (ACDocumentsInfo document in documents)
                    {
                        document.DocumentEntries = objDocumentEntrysController.GetDocumentEntryByDocumentID(document.ACDocumentID);
                        document.RelativeDocuments = objRelativeDocumentsController.GetRelativeDocumentByDocumentID(document.ACDocumentID);
                    }
                    #endregion

                    bool isCompleted = false;
                    int postingHistoryID = 0;
                    string log = string.Empty;
                    try
                    {
                        BOSApp.SwitchConnection(centre.BRBranchID);
                        if (BOSApp.TestCurrentConnection())
                        {
                            BRPostingHistorysController objPostingHistorysController = new BRPostingHistorysController();
                            BRPostingHistorysInfo objPostingHistorysInfo = objPostingHistorysController.GetPostingHistoryByStatusAndType(
                                                                                                    DataExchangeStatus.Posting.ToString(),
                                                                                                    DataExchangeType.Accounting.ToString());
                            if (objPostingHistorysInfo != null)
                            {
                                return;
                            }

                            TransferStatus = DataExchangeStatus.Posting.ToString();
                            postingHistoryID = CreatePostingHistory(0, objBranchsInfo.BRBranchID, DataExchangeType.Accounting.ToString(), DataExchangeStatus.Posting.ToString());

                            #region Transfer cost object
                            foreach (ACCostObjectsInfo costObject in costObjects)
                            {
                                ACCostObjectsInfo centralCostObject = (ACCostObjectsInfo)objCostObjectsController.GetObjectByNo(costObject.ACCostObjectNo);
                                if (centralCostObject != null)
                                {
                                    int centralCostObjectID = centralCostObject.ACCostObjectID;
                                    centralCostObject = (ACCostObjectsInfo)costObject.Clone();
                                    centralCostObject.ACCostObjectID = centralCostObjectID;
                                    centralCostObject.ACCostObjectTransferredDate = BOSApp.GetCurrentServerDate();
                                    objCostObjectsController.UpdateObject(centralCostObject);
                                }
                                else
                                {
                                    centralCostObject = (ACCostObjectsInfo)costObject.Clone();
                                    centralCostObject.AAUpdatedDate = DateTime.MaxValue;
                                    objCostObjectsController.CreateObject(centralCostObject);
                                }
                            }
                            #endregion

                            #region Transfer budget data

                            #region Receipt voucher
                            ACObjectsController objObjectsController = new ACObjectsController();
                            foreach (ARReceiptVouchersInfo receiptVoucher in receiptVouchers)
                            {
                                ARReceiptVouchersInfo centralReceiptVoucher = (ARReceiptVouchersInfo)objReceiptVouchersController.GetObjectByNo(receiptVoucher.ARReceiptVoucherNo);
                                if (centralReceiptVoucher != null)
                                {
                                    int centralReceiptVoucherID = centralReceiptVoucher.ARReceiptVoucherID;
                                    centralReceiptVoucher = (ARReceiptVouchersInfo)receiptVoucher.Clone();
                                    centralReceiptVoucher.ARReceiptVoucherID = centralReceiptVoucherID;
                                    centralReceiptVoucher.FK_ACObjectID = 0;
                                    if (!string.IsNullOrEmpty(receiptVoucher.ACObjectNo))
                                    {
                                        ACObjectsInfo centralObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                                    receiptVoucher.ACObjectNo,
                                                                                                                    receiptVoucher.ARObjectType);
                                        if (centralObject != null)
                                        {
                                            centralReceiptVoucher.FK_ACObjectID = centralObject.ACObjectID;
                                        }
                                    }
                                    centralReceiptVoucher.ARReceiptVoucherTransferredDate = BOSApp.GetCurrentServerDate();
                                    objReceiptVouchersController.UpdateObject(centralReceiptVoucher);
                                }
                                else
                                {
                                    centralReceiptVoucher = (ARReceiptVouchersInfo)receiptVoucher.Clone();
                                    centralReceiptVoucher.FK_ACObjectID = 0;
                                    if (!string.IsNullOrEmpty(receiptVoucher.ACObjectNo))
                                    {
                                        ACObjectsInfo centralObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                                    receiptVoucher.ACObjectNo,
                                                                                                                    receiptVoucher.ARObjectType);
                                        if (centralObject != null)
                                        {
                                            centralReceiptVoucher.FK_ACObjectID = centralObject.ACObjectID;
                                        }
                                    }
                                    centralReceiptVoucher.AAUpdatedDate = DateTime.MaxValue;
                                    objReceiptVouchersController.CreateObject(centralReceiptVoucher);
                                }

                                if (centralReceiptVoucher.ARReceiptVoucherID > 0)
                                {
                                    TransferReceiptVoucherItemsToCentre(receiptVoucher.ReceiptVoucherItems, centralReceiptVoucher.ARReceiptVoucherID);
                                }
                            }
                            #endregion

                            #region Payment voucher
                            foreach (APPaymentVouchersInfo paymentVoucher in paymentVouchers)
                            {
                                APPaymentVouchersInfo centralPaymentVoucher = (APPaymentVouchersInfo)objPaymentVouchersController.GetObjectByNo(paymentVoucher.APPaymentVoucherNo);
                                if (centralPaymentVoucher != null)
                                {
                                    int centralPaymentVoucherID = centralPaymentVoucher.APPaymentVoucherID;
                                    centralPaymentVoucher = (APPaymentVouchersInfo)paymentVoucher.Clone();
                                    centralPaymentVoucher.APPaymentVoucherID = centralPaymentVoucherID;
                                    centralPaymentVoucher.FK_ACObjectID = 0;
                                    if (!string.IsNullOrEmpty(paymentVoucher.ACObjectNo))
                                    {
                                        ACObjectsInfo centralObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                                    paymentVoucher.ACObjectNo,
                                                                                                                    paymentVoucher.APObjectType);
                                        if (centralObject != null)
                                        {
                                            centralPaymentVoucher.FK_ACObjectID = centralObject.ACObjectID;
                                        }
                                    }
                                    centralPaymentVoucher.APPaymentVoucherTransferredDate = BOSApp.GetCurrentServerDate();
                                    objPaymentVouchersController.UpdateObject(centralPaymentVoucher);
                                }
                                else
                                {
                                    centralPaymentVoucher = (APPaymentVouchersInfo)paymentVoucher.Clone();
                                    centralPaymentVoucher.FK_ACObjectID = 0;
                                    if (!string.IsNullOrEmpty(paymentVoucher.ACObjectNo))
                                    {
                                        ACObjectsInfo centralObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                                    paymentVoucher.ACObjectNo,
                                                                                                                    paymentVoucher.APObjectType);
                                        if (centralObject != null)
                                        {
                                            centralPaymentVoucher.FK_ACObjectID = centralObject.ACObjectID;
                                        }
                                    }
                                    centralPaymentVoucher.AAUpdatedDate = DateTime.MaxValue;
                                    objPaymentVouchersController.CreateObject(centralPaymentVoucher);
                                }

                                if (centralPaymentVoucher.APPaymentVoucherID > 0)
                                {
                                    TransferPaymentVoucherItemsToCentre(paymentVoucher.PaymentVoucherItems, centralPaymentVoucher.APPaymentVoucherID);
                                }
                            }
                            #endregion

                            #endregion

                            #region Transfer bank transactions
                            foreach (ACBankTransactionsInfo bankTransaction in bankTransactions)
                            {
                                ACBankTransactionsInfo centralBankTransaction = (ACBankTransactionsInfo)objBankTransactionsController.GetObjectByNo(bankTransaction.ACBankTransactionNo);
                                if (centralBankTransaction != null)
                                {
                                    int centralBankTransactionID = centralBankTransaction.ACBankTransactionID;
                                    centralBankTransaction = (ACBankTransactionsInfo)bankTransaction.Clone();
                                    centralBankTransaction.ACBankTransactionID = centralBankTransactionID;
                                    centralBankTransaction.FK_ACObjectID = 0;
                                    if (!string.IsNullOrEmpty(bankTransaction.ACObjectNo))
                                    {
                                        ACObjectsInfo centralObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                                    bankTransaction.ACObjectNo,
                                                                                                                    bankTransaction.ACObjectType);
                                        if (centralObject != null)
                                        {
                                            centralBankTransaction.FK_ACObjectID = centralObject.ACObjectID;
                                        }
                                    }
                                    centralBankTransaction.ACBankTransactionTransferredDate = BOSApp.GetCurrentServerDate();
                                    objBankTransactionsController.UpdateObject(centralBankTransaction);
                                }
                                else
                                {
                                    centralBankTransaction = (ACBankTransactionsInfo)bankTransaction.Clone();
                                    centralBankTransaction.FK_ACObjectID = 0;
                                    if (!string.IsNullOrEmpty(bankTransaction.ACObjectNo))
                                    {
                                        ACObjectsInfo centralObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                                    bankTransaction.ACObjectNo,
                                                                                                                    bankTransaction.ACObjectType);
                                        if (centralObject != null)
                                        {
                                            centralBankTransaction.FK_ACObjectID = centralObject.ACObjectID;
                                        }
                                    }
                                    centralBankTransaction.AAUpdatedDate = DateTime.MaxValue;
                                    objBankTransactionsController.CreateObject(centralBankTransaction);
                                }

                                if (centralBankTransaction.ACBankTransactionID > 0)
                                {
                                    TransferBankTransactionItemsToCentre(bankTransaction.BankTransactionItems, centralBankTransaction.ACBankTransactionID);
                                }
                            }
                            #endregion

                            #region Transfer asset data

                            #region Asset
                            foreach (ACAssetsInfo asset in assets)
                            {
                                ACAssetsInfo centralAsset = (ACAssetsInfo)objAssetsController.GetObjectByNo(asset.ACAssetNo);
                                if (centralAsset != null)
                                {
                                    int centralAssetID = centralAsset.ACAssetID;
                                    centralAsset = (ACAssetsInfo)asset.Clone();
                                    centralAsset.ACAssetID = centralAssetID;
                                    centralAsset.ACAssetTransferredDate = BOSApp.GetCurrentServerDate();
                                    objAssetsController.UpdateObject(centralAsset);
                                }
                                else
                                {
                                    centralAsset = (ACAssetsInfo)asset.Clone();
                                    centralAsset.AAUpdatedDate = DateTime.MaxValue;
                                    objAssetsController.CreateObject(centralAsset);
                                }
                            }
                            #endregion

                            #region Asset receipts
                            foreach (ACAssetReceiptsInfo assetReceipt in assetReceipts)
                            {
                                ACAssetReceiptsInfo centralAssetReceipt = (ACAssetReceiptsInfo)objAssetReceiptsController.GetObjectByNo(assetReceipt.ACAssetReceiptNo);
                                if (centralAssetReceipt != null)
                                {
                                    int centralAssetReceiptID = centralAssetReceipt.ACAssetReceiptID;
                                    centralAssetReceipt = (ACAssetReceiptsInfo)assetReceipt.Clone();
                                    centralAssetReceipt.ACAssetReceiptID = centralAssetReceiptID;
                                    centralAssetReceipt.ACAssetReceiptTransferredDate = BOSApp.GetCurrentServerDate();
                                    objAssetReceiptsController.UpdateObject(centralAssetReceipt);
                                }
                                else
                                {
                                    centralAssetReceipt = (ACAssetReceiptsInfo)assetReceipt.Clone();
                                    centralAssetReceipt.AAUpdatedDate = DateTime.MaxValue;
                                    objAssetReceiptsController.CreateObject(centralAssetReceipt);
                                }

                                if (centralAssetReceipt.ACAssetReceiptID > 0)
                                {
                                    TransferAssetReceiptItemsToCentre(assetReceipt.AssetReceiptItems, centralAssetReceipt.ACAssetReceiptID);
                                }
                            }
                            #endregion

                            #region Asset shipments
                            foreach (ACDocumentsInfo assetShipment in assetShipments)
                            {
                                ACDocumentsInfo centralAssetShipment = TransferDocumentToCentre(assetShipment);
                                if (centralAssetShipment.ACDocumentID > 0)
                                {
                                    TransferAssetShipmentItemsToCentre(assetShipment.AssetShipmentItems, centralAssetShipment.ACDocumentID);
                                }
                            }
                            #endregion

                            #region Asset trasfers
                            foreach (ACDocumentsInfo assetTransfer in assetTransfers)
                            {
                                ACDocumentsInfo centralAssetTransfer = TransferDocumentToCentre(assetTransfer);
                                if (centralAssetTransfer.ACDocumentID > 0)
                                {
                                    TransferAssetTransferItemsToCentre(assetTransfer.AssetTransferItems, centralAssetTransfer.ACDocumentID);
                                }
                            }
                            #endregion

                            #endregion

                            #region Transfer equipment data
                            foreach (ACDocumentsInfo equipmentTransfer in equipmentTransfers)
                            {
                                ACDocumentsInfo centralEquipmentTransfer = TransferDocumentToCentre(equipmentTransfer);
                                if (centralEquipmentTransfer.ACDocumentID > 0)
                                {
                                    TransferEquipmentTransferItemsToCentre(equipmentTransfer.EquipmentTransferItems, centralEquipmentTransfer.ACDocumentID);
                                }
                            }
                            #endregion

                            #region Transfer general accounting data
                            SortedList<int, int> centralDocumentIDs = new SortedList<int, int>();
                            foreach (ACDocumentsInfo document in documents)
                            {
                                ACDocumentsInfo centralDocument = TransferDocumentToCentre(document);
                                if (centralDocument.ACDocumentID > 0)
                                {
                                    TransferDocumentEntriesToCentre(document.DocumentEntries, centralDocument);
                                    centralDocumentIDs.Add(document.ACDocumentID, centralDocument.ACDocumentID);
                                }
                            }

                            foreach (var document in documents)
                            {
                                if (centralDocumentIDs.ContainsKey(document.ACDocumentID))
                                {
                                    TransferRelativeDocumentsToCentre(document.RelativeDocuments, centralDocumentIDs[document.ACDocumentID]);
                                }
                            }
                            #endregion

                            isCompleted = true;
                            MessageBox.Show(DataExchangeLocalizedResources.TransferSuccessMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(string.Format(DataExchangeLocalizedResources.CannotConnectToCentre, centre.BRBranchName), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        log = ex.Message;
                    }
                    finally
                    {
                        if (postingHistoryID > 0)
                        {
                            //Update posting history in centre
                            if (isCompleted)
                            {
                                CreatePostingHistory(postingHistoryID, objBranchsInfo.BRBranchID, DataExchangeType.Accounting.ToString(), DataExchangeStatus.Complete.ToString());
                            }
                            else
                            {
                                CreatePostingHistory(postingHistoryID, objBranchsInfo.BRBranchID, DataExchangeType.Accounting.ToString(), DataExchangeStatus.Failed.ToString(), log);
                            }
                        }
                        BOSApp.RollbackLocalConnection();

                        if (postingHistoryID > 0)
                        {
                            //Update purchase data at local
                            if (isCompleted)
                            {
                                UpdateLocalCostObjectStatus(costObjects);
                                UpdateLocalReceiptVoucherStatus(receiptVouchers);
                                UpdateLocalPaymentVoucherStatus(paymentVouchers);
                                UpdateLocalBankTransactionStatus(bankTransactions);
                                UpdateLocalAssetStatus(assets);
                                UpdateLocalAssetReceiptStatus(assetReceipts);
                                UpdateLocalDocumentStatus(assetShipments);
                                UpdateLocalDocumentStatus(assetTransfers);
                                UpdateLocalDocumentStatus(equipmentTransfers);
                                UpdateLocalDocumentStatus(documents);
                            }

                            //Create posting history in branch
                            if (isCompleted)
                                CreatePostingHistory(0, objBranchsInfo.BRBranchID, DataExchangeType.Accounting.ToString(), DataExchangeStatus.Complete.ToString());
                            else
                                CreatePostingHistory(0, objBranchsInfo.BRBranchID, DataExchangeType.Accounting.ToString(), DataExchangeStatus.Failed.ToString(), log);
                        }
                    }
                }
            }
            TransferTimer.Stop();
            BOSProgressBar.Close();
        }

        /// <summary>
        /// Transfer items of a receipt voucher to the centre
        /// </summary>
        /// <param name="receiptVoucherItems">Given items</param>
        /// <param name="centralReceiptVoucherID">Id of the central receipt voucher</param>
        private void TransferReceiptVoucherItemsToCentre(List<ARReceiptVoucherItemsInfo> receiptVoucherItems, int centralReceiptVoucherID)
        {
            ARReceiptVoucherItemsController objReceiptVoucherItemsController = new ARReceiptVoucherItemsController();
            objReceiptVoucherItemsController.DeleteByForeignColumn("FK_ARReceiptVoucherID", centralReceiptVoucherID);

            foreach (ARReceiptVoucherItemsInfo item in receiptVoucherItems)
            {
                item.FK_ARReceiptVoucherID = centralReceiptVoucherID;
                objReceiptVoucherItemsController.CreateObject(item);
            }
        }

        /// <summary>
        /// Transfer items of a payment voucher to the centre
        /// </summary>
        /// <param name="paymentVoucherItems">Given items</param>
        /// <param name="centralPaymentVoucherID">Id of the central payment voucher</param>
        private void TransferPaymentVoucherItemsToCentre(List<APPaymentVoucherItemsInfo> paymentVoucherItems, int centralPaymentVoucherID)
        {
            APPaymentVoucherItemsController objPaymentVoucherItemsController = new APPaymentVoucherItemsController();
            objPaymentVoucherItemsController.DeleteByForeignColumn("FK_APPaymentVoucherID", centralPaymentVoucherID);

            ACCostObjectsController objCostObjectsController = new ACCostObjectsController();
            foreach (APPaymentVoucherItemsInfo item in paymentVoucherItems)
            {
                item.FK_APPaymentVoucherID = centralPaymentVoucherID;
                item.FK_ACCostObjectID = 0;
                if (!string.IsNullOrEmpty(item.ACCostObjectNo))
                {
                    ACCostObjectsInfo centralCostObject = (ACCostObjectsInfo)objCostObjectsController.GetObjectByNo(item.ACCostObjectNo);
                    if (centralCostObject != null)
                    {
                        item.FK_ACCostObjectID = centralCostObject.ACCostObjectID;
                    }
                }
                objPaymentVoucherItemsController.CreateObject(item);
            }
        }

        /// <summary>
        /// Transfer items of a bank transaction to the centre
        /// </summary>
        /// <param name="bankTransactionItems">Given items</param>
        /// <param name="centralBankTransactionID">Id of the central bank transaction</param>
        private void TransferBankTransactionItemsToCentre(List<ACBankTransactionItemsInfo> bankTransactionItems, int centralBankTransactionID)
        {
            ACBankTransactionItemsController objBankTransactionItemsController = new ACBankTransactionItemsController();
            objBankTransactionItemsController.DeleteByForeignColumn("FK_ACBankTransactionID", centralBankTransactionID);

            ACCostObjectsController objCostObjectsController = new ACCostObjectsController();
            foreach (ACBankTransactionItemsInfo item in bankTransactionItems)
            {
                item.FK_ACBankTransactionID = centralBankTransactionID;
                item.FK_ACCostObjectID = 0;
                if (!string.IsNullOrEmpty(item.ACCostObjectNo))
                {
                    ACCostObjectsInfo centralCostObject = (ACCostObjectsInfo)objCostObjectsController.GetObjectByNo(item.ACCostObjectNo);
                    if (centralCostObject != null)
                    {
                        item.FK_ACCostObjectID = centralCostObject.ACCostObjectID;
                    }
                }
                objBankTransactionItemsController.CreateObject(item);
            }
        }

        /// <summary>
        /// Transfer items of an asset receipt to the centre
        /// </summary>
        /// <param name="assetReceiptItems">Given items</param>
        /// <param name="centralAssetReceiptID">Id of the central asset receipt</param>
        private void TransferAssetReceiptItemsToCentre(List<ACAssetReceiptItemsInfo> assetReceiptItems, int centralAssetReceiptID)
        {
            ACAssetReceiptItemsController objAssetReceiptItemsController = new ACAssetReceiptItemsController();
            objAssetReceiptItemsController.DeleteByForeignColumn("FK_ACAssetReceiptID", centralAssetReceiptID);

            ACAssetsController objAssetsController = new ACAssetsController();
            foreach (ACAssetReceiptItemsInfo item in assetReceiptItems)
            {
                item.FK_ACAssetReceiptID = centralAssetReceiptID;
                item.FK_ACAssetID = 0;
                if (!string.IsNullOrEmpty(item.ACAssetNo))
                {
                    ACAssetsInfo centralAsset = (ACAssetsInfo)objAssetsController.GetObjectByNo(item.ACAssetNo);
                    if (centralAsset != null)
                    {
                        item.FK_ACAssetID = centralAsset.ACAssetID;
                    }
                }
                objAssetReceiptItemsController.CreateObject(item);
            }
        }

        /// <summary>
        /// Transfer a document to the centre
        /// </summary>
        /// <param name="document">Given document</param>
        /// <returns>Central document</returns>
        private ACDocumentsInfo TransferDocumentToCentre(ACDocumentsInfo document)
        {
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACDocumentsInfo centralDocument = (ACDocumentsInfo)objDocumentsController.GetDocumentByDocumentTypeIDAndDocumentNo(document.FK_ACDocumentTypeID, document.ACDocumentNo);
            if (centralDocument != null)
            {
                int centralDocumentID = centralDocument.ACDocumentID;
                centralDocument = (ACDocumentsInfo)document.Clone();
                centralDocument.ACDocumentID = centralDocumentID;
                centralDocument.FK_ACObjectID = 0;
                if (!string.IsNullOrEmpty(document.ACObjectNo))
                {
                    ACObjectsInfo centralObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                document.ACObjectNo,
                                                                                                document.ACObjectType);
                    if (centralObject != null)
                    {
                        centralDocument.FK_ACObjectID = centralObject.ACObjectID;
                    }
                }
                centralDocument.FK_ACAssObjectID = 0;
                if (!string.IsNullOrEmpty(document.ACAssObjectNo))
                {
                    ACObjectsInfo centralObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                document.ACAssObjectNo,
                                                                                                document.ACAssObjectType);
                    if (centralObject != null)
                    {
                        centralDocument.FK_ACAssObjectID = centralObject.ACObjectID;
                    }
                }
                centralDocument.ACDocumentTransferredDate = BOSApp.GetCurrentServerDate();
                objDocumentsController.UpdateObject(centralDocument);
            }
            else
            {
                centralDocument = (ACDocumentsInfo)document.Clone();
                centralDocument.FK_ACObjectID = 0;
                if (!string.IsNullOrEmpty(document.ACObjectNo))
                {
                    ACObjectsInfo centralObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                document.ACObjectNo,
                                                                                                document.ACObjectType);
                    if (centralObject != null)
                    {
                        centralDocument.FK_ACObjectID = centralObject.ACObjectID;
                    }
                }
                centralDocument.FK_ACAssObjectID = 0;
                if (!string.IsNullOrEmpty(document.ACAssObjectNo))
                {
                    ACObjectsInfo centralObject = (ACObjectsInfo)objObjectsController.GetObjectByNoAndType(
                                                                                                document.ACAssObjectNo,
                                                                                                document.ACAssObjectType);
                    if (centralObject != null)
                    {
                        centralDocument.FK_ACAssObjectID = centralObject.ACObjectID;
                    }
                }
                centralDocument.AAUpdatedDate = DateTime.MaxValue;
                objDocumentsController.CreateObject(centralDocument);
            }
            return centralDocument;
        }

        /// <summary>
        /// Transfer items of an asset shipment to the centre
        /// </summary>
        /// <param name="assetShipmentItems">Given items</param>
        /// <param name="centralAssetShipmentID">Id of the central asset shipment</param>
        private void TransferAssetShipmentItemsToCentre(List<ACAssetShipmentItemsInfo> assetShipmentItems, int centralAssetShipmentID)
        {
            ACAssetShipmentItemsController objAssetShipmentItemsController = new ACAssetShipmentItemsController();
            objAssetShipmentItemsController.DeleteByForeignColumn("FK_ACDocumentID", centralAssetShipmentID);

            ACAssetsController objAssetsController = new ACAssetsController();
            foreach (ACAssetShipmentItemsInfo item in assetShipmentItems)
            {
                item.FK_ACDocumentID = centralAssetShipmentID;
                item.FK_ACAssetID = 0;
                if (!string.IsNullOrEmpty(item.ACAssetNo))
                {
                    ACAssetsInfo centralAsset = (ACAssetsInfo)objAssetsController.GetObjectByNo(item.ACAssetNo);
                    if (centralAsset != null)
                    {
                        item.FK_ACAssetID = centralAsset.ACAssetID;
                    }
                }
                objAssetShipmentItemsController.CreateObject(item);
            }
        }

        /// <summary>
        /// Transfer items of an asset transfer to the centre
        /// </summary>
        /// <param name="assetTransferItems">Given items</param>
        /// <param name="centralAssetTransferID">Id of the central asset transfer</param>
        private void TransferAssetTransferItemsToCentre(List<ACAssetTransferItemsInfo> assetTransferItems, int centralAssetTransferID)
        {
            ACAssetTransferItemsController objAssetTransferItemsController = new ACAssetTransferItemsController();
            objAssetTransferItemsController.DeleteByForeignColumn("FK_ACDocumentID", centralAssetTransferID);

            ACAssetsController objAssetsController = new ACAssetsController();
            foreach (ACAssetTransferItemsInfo item in assetTransferItems)
            {
                item.FK_ACDocumentID = centralAssetTransferID;
                item.FK_ACAssetID = 0;
                if (!string.IsNullOrEmpty(item.ACAssetNo))
                {
                    ACAssetsInfo centralAsset = (ACAssetsInfo)objAssetsController.GetObjectByNo(item.ACAssetNo);
                    if (centralAsset != null)
                    {
                        item.FK_ACAssetID = centralAsset.ACAssetID;
                    }
                }
                objAssetTransferItemsController.CreateObject(item);
            }
        }

        /// <summary>
        /// Transfer items of an equipment transfer to the centre
        /// </summary>
        /// <param name="equipmentTransferItems">Given items</param>
        /// <param name="centralEquipmentTransferID">Id of the central equipment transfer</param>
        private void TransferEquipmentTransferItemsToCentre(List<ACEquipmentTransferItemsInfo> equipmentTransferItems, int centralEquipmentTransferID)
        {
            ACEquipmentTransferItemsController objEquipmentTransferItemsController = new ACEquipmentTransferItemsController();
            objEquipmentTransferItemsController.DeleteByForeignColumn("FK_ACDocumentID", centralEquipmentTransferID);

            foreach (ACEquipmentTransferItemsInfo item in equipmentTransferItems)
            {
                item.FK_ACDocumentID = centralEquipmentTransferID;
                SynProductSerie(item);
                objEquipmentTransferItemsController.CreateObject(item);
            }
        }

        /// <summary>
        /// Transfer entries of a document to the centre
        /// </summary>
        /// <param name="entries">Given entries</param>
        /// <param name="centralDocument">Central document</param>
        private void TransferDocumentEntriesToCentre(List<ACDocumentEntrysInfo> entries, ACDocumentsInfo centralDocument)
        {
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            objDocumentEntrysController.DeleteByForeignColumn("FK_ACDocumentID", centralDocument.ACDocumentID);

            ACCostObjectsController objCostObjectsController = new ACCostObjectsController();
            ACAssetsController objAssetsController = new ACAssetsController();
            foreach (ACDocumentEntrysInfo entry in entries)
            {
                entry.FK_ACDocumentID = centralDocument.ACDocumentID;
                entry.FK_ACObjectID = centralDocument.FK_ACObjectID;
                entry.FK_ACAssObjectID = centralDocument.FK_ACAssObjectID;
                entry.FK_ACCostObjectID = 0;
                if (!string.IsNullOrEmpty(entry.ACCostObjectNo))
                {
                    ACCostObjectsInfo centralCostObject = (ACCostObjectsInfo)objCostObjectsController.GetObjectByNo(entry.ACCostObjectNo);
                    if (centralCostObject != null)
                    {
                        entry.FK_ACCostObjectID = centralCostObject.ACCostObjectID;
                    }
                }
                entry.ACAssetID = 0;
                if (!string.IsNullOrEmpty(entry.ACAssetNo))
                {
                    ACAssetsInfo centralAsset = (ACAssetsInfo)objAssetsController.GetObjectByNo(entry.ACAssetNo);
                    if (centralAsset != null)
                    {
                        entry.ACAssetID = centralAsset.ACAssetID;
                    }
                }
                entry.ICEquipmentShipmentItemID = 0;
                entry.ACEquipmentTransferItemID = 0;
                entry.ACAllocatedDocumentEntryID = 0;
                objDocumentEntrysController.CreateObject(entry);
            }
        }

        /// <summary>
        /// Transfer relative documents of a document to the centre
        /// </summary>
        /// <param name="centralDocumentID">Id of the central document</param>
        private void TransferRelativeDocumentsToCentre(List<ACRelativeDocumentsInfo> relativeDocuments, int centralDocumentID)
        {
            ACRelativeDocumentsController objRelativeDocumentsController = new ACRelativeDocumentsController();
            objRelativeDocumentsController.DeleteByForeignColumn("FK_ACDocumentID", centralDocumentID);

            ACDocumentsController objDocumentsController = new ACDocumentsController();
            foreach (ACRelativeDocumentsInfo relativeDocument in relativeDocuments)
            {
                relativeDocument.FK_ACDocumentID = centralDocumentID;
                if (!string.IsNullOrEmpty(relativeDocument.ACRelativeDocumentNo))
                {
                    ACDocumentsInfo centralRelativeDocument = (ACDocumentsInfo)objDocumentsController.GetDocumentByDocumentTypeIDAndDocumentNo(
                                                                                                            relativeDocument.ACRelativeDocumentTypeID,
                                                                                                            relativeDocument.ACRelativeDocumentNo);
                    if (centralRelativeDocument != null)
                    {
                        relativeDocument.FK_ACRelativeDocumentID = centralRelativeDocument.ACDocumentID;
                        objRelativeDocumentsController.CreateObject(relativeDocument);
                    }
                }
            }
        }

        /// <summary>
        /// Update the status of transferred cost objects at local,
        /// to track for the next transfer
        /// </summary>
        /// <param name="costObjects">Transferred cost objects</param>
        private void UpdateLocalCostObjectStatus(List<ACCostObjectsInfo> costObjects)
        {
            ACCostObjectsController objCostObjectsController = new ACCostObjectsController();
            foreach (ACCostObjectsInfo costObject in costObjects)
            {
                costObject.IsTransferred = true;
                costObject.ACCostObjectTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objCostObjectsController.UpdateObject(costObject);
            }
        }

        /// <summary>
        /// Update the status of transferred receipt vouchers at local,
        /// to track for the next transfer
        /// </summary>
        /// <param name="receiptVouchers">Transferred receipt vouchers</param>
        private void UpdateLocalReceiptVoucherStatus(List<ARReceiptVouchersInfo> receiptVouchers)
        {
            ARReceiptVouchersController objReceiptVouchersController = new ARReceiptVouchersController();
            foreach (ARReceiptVouchersInfo receiptVoucher in receiptVouchers)
            {
                receiptVoucher.IsTransferred = true;
                receiptVoucher.ARReceiptVoucherTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objReceiptVouchersController.UpdateObject(receiptVoucher);
            }
        }

        /// <summary>
        /// Update the status of transferred payment vouchers at local,
        /// to track for the next transfer
        /// </summary>
        /// <param name="paymentVouchers">Transferred payment vouchers</param>
        private void UpdateLocalPaymentVoucherStatus(List<APPaymentVouchersInfo> paymentVouchers)
        {
            APPaymentVouchersController objPaymentVouchersController = new APPaymentVouchersController();
            foreach (APPaymentVouchersInfo paymentVoucher in paymentVouchers)
            {
                paymentVoucher.IsTransferred = true;
                paymentVoucher.APPaymentVoucherTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objPaymentVouchersController.UpdateObject(paymentVoucher);
            }
        }

        /// <summary>
        /// Update the status of transferred bank transactions at local,
        /// to track for the next transfer
        /// </summary>
        /// <param name="bankTransactions">Transferred bank transactions</param>
        private void UpdateLocalBankTransactionStatus(List<ACBankTransactionsInfo> bankTransactions)
        {
            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            foreach (ACBankTransactionsInfo bankTransaction in bankTransactions)
            {
                bankTransaction.IsTransferred = true;
                bankTransaction.ACBankTransactionTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objBankTransactionsController.UpdateObject(bankTransaction);
            }
        }


        /// <summary>
        /// Update the status of transferred assets at local,
        /// to track for the next transfer
        /// </summary>
        /// <param name="assets">Transferred assets</param>
        private void UpdateLocalAssetStatus(List<ACAssetsInfo> assets)
        {
            ACAssetsController objAssetsController = new ACAssetsController();
            foreach (ACAssetsInfo asset in assets)
            {
                asset.IsTransferred = true;
                asset.ACAssetTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objAssetsController.UpdateObject(asset);
            }
        }

        /// <summary>
        /// Update the status of transferred asset receipts at local,
        /// to track for the next transfer
        /// </summary>
        /// <param name="assetReceipts">Transferred asset receipts</param>
        private void UpdateLocalAssetReceiptStatus(List<ACAssetReceiptsInfo> assetReceipts)
        {
            ACAssetReceiptsController objAssetReceiptsController = new ACAssetReceiptsController();
            foreach (ACAssetReceiptsInfo assetReceipt in assetReceipts)
            {
                assetReceipt.IsTransferred = true;
                assetReceipt.ACAssetReceiptTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objAssetReceiptsController.UpdateObject(assetReceipt);
            }
        }

        /// <summary>
        /// Update the status of transferred documents at local,
        /// to track for the next transfer
        /// </summary>
        /// <param name="documents">Transferred documents</param>
        private void UpdateLocalDocumentStatus(List<ACDocumentsInfo> documents)
        {
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            foreach (ACDocumentsInfo document in documents)
            {
                document.IsTransferred = true;
                document.ACDocumentTransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objDocumentsController.UpdateObject(document);
            }
        }

        /// <summary>
        /// Called when user transfers accounting initial data to the centre
        /// </summary>
        /// <param name="sender">Event sender</param>
        public void TransferAccountInitDataToCentre(object sender)
        {
            BOSProgressBar.Start(DataExchangeLocalizedResources.TransferringAccountingDataToHeadquarterMessage);
            TransferType = DataExchangeType.AccountInitData.ToString();
            TransferStatus = DataExchangeStatus.New.ToString();
            TransferTimer.Start();

            TransferAccountInitDataToCentre();
        }

        /// <summary>
        /// Transfer account initial data to the centre
        /// </summary>
        private void TransferAccountInitDataToCentre()
        {
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo branch = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (branch != null && branch.BRBranchParentID > 0)
            {
                BRBranchsInfo centre = (BRBranchsInfo)objBranchsController.GetObjectByID(branch.BRBranchParentID);
                if (centre != null)
                {
                    //Get account initial data at local
                    ACAccountDetailsController objAccountDetailsController = new ACAccountDetailsController();
                    //NUThao [EDIT] [08/04/2014] [DB centre] [CSCompany issue], START
                    int cSCompanyID = BOSApp.CurrentCompanyInfo.CSCompanyID;
                    //List<ACAccountDetailsInfo> accountDetails = objAccountDetailsController.GetAccountDetailsForTransferring();
                    List<ACAccountDetailsInfo> accountDetails = objAccountDetailsController.GetAccountDetailsForTransferring(cSCompanyID);
                    //NUThao [EDIT] [08/04/2014] [DB centre] [CSCompany issue], END

                    bool isComplete = false;
                    int postingHistoryID = 0;
                    string log = string.Empty;
                    try
                    {
                        BOSApp.SwitchConnection(centre.BRBranchID);
                        if (BOSApp.TestCurrentConnection())
                        {
                            BRPostingHistorysController objPostingHistorysController = new BRPostingHistorysController();
                            BRPostingHistorysInfo objPostingHistorysInfo = objPostingHistorysController.GetPostingHistoryByStatusAndType(
                                                                                                    DataExchangeStatus.Posting.ToString(),
                                                                                                    DataExchangeType.AccountInitData.ToString());
                            if (objPostingHistorysInfo != null)
                            {
                                return;
                            }

                            TransferStatus = DataExchangeStatus.Posting.ToString();
                            postingHistoryID = CreatePostingHistory(0, branch.BRBranchID, DataExchangeType.AccountInitData.ToString(), DataExchangeStatus.Posting.ToString());

                            #region Transfer account initial data
                            ACObjectsController objObjectsController = new ACObjectsController();
                            foreach (ACAccountDetailsInfo accountDetail in accountDetails)
                            {
                                ACAccountDetailsInfo centralAccountDetail = null;
                                ACObjectsInfo centralObject = null;
                                if (accountDetail.FK_ACObjectID > 0)
                                {
                                    centralObject = objObjectsController.GetObjectByNoAndType(accountDetail.ACObjectNo, accountDetail.ACObjectType);
                                    if (centralObject != null)
                                    {
                                        centralAccountDetail = objAccountDetailsController.GetAccountDetail(
                                                                                accountDetail.FK_ACAccountID,
                                                                                centralObject.ACObjectID,
                                                                                centralObject.ACObjectType,
                                                                                accountDetail.FK_GECurrencyID);
                                    }
                                }
                                else if (accountDetail.FK_CSCompanyBankID > 0)
                                {
                                    centralAccountDetail = objAccountDetailsController.GetAccountDetail(
                                                                            accountDetail.FK_ACAccountID,
                                                                            accountDetail.FK_CSCompanyBankID,
                                                                            accountDetail.FK_GECurrencyID);
                                }
                                if (centralAccountDetail != null)
                                {
                                    int centralAccountDetailID = centralAccountDetail.ACAccountDetailID;
                                    centralAccountDetail = (ACAccountDetailsInfo)accountDetail.Clone();
                                    if (accountDetail.FK_ACObjectID > 0)
                                    {
                                        centralAccountDetail.FK_ACObjectID = 0;
                                        if (centralObject != null)
                                        {
                                            centralAccountDetail.FK_ACObjectID = centralObject.ACObjectID;
                                        }
                                    }
                                    centralAccountDetail.ACAccountDetailID = centralAccountDetailID;
                                    objAccountDetailsController.UpdateObject(centralAccountDetail);
                                }
                                else
                                {
                                    centralAccountDetail = (ACAccountDetailsInfo)accountDetail.Clone();
                                    if (accountDetail.FK_ACObjectID > 0)
                                    {
                                        centralAccountDetail.FK_ACObjectID = 0;
                                        if (centralObject != null)
                                        {
                                            centralAccountDetail.FK_ACObjectID = centralObject.ACObjectID;
                                        }
                                    }
                                    objAccountDetailsController.CreateObject(centralAccountDetail);
                                }
                            }
                            #endregion                            

                            isComplete = true;
                            MessageBox.Show(DataExchangeLocalizedResources.TransferSuccessMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(string.Format(DataExchangeLocalizedResources.CannotConnectToCentre, centre.BRBranchName), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        log = ex.Message;
                    }
                    finally
                    {
                        if (postingHistoryID > 0)
                        {
                            //Update posting history at centre
                            if (isComplete)
                            {
                                CreatePostingHistory(postingHistoryID, branch.BRBranchID, DataExchangeType.AccountInitData.ToString(), DataExchangeStatus.Complete.ToString());
                            }
                            else
                            {
                                CreatePostingHistory(postingHistoryID, branch.BRBranchID, DataExchangeType.AccountInitData.ToString(), DataExchangeStatus.Failed.ToString(), log);
                            }
                        }
                        BOSApp.RollbackLocalConnection();

                        if (postingHistoryID > 0)
                        {
                            //Create posting history at local
                            if (isComplete)
                            {
                                CreatePostingHistory(0, branch.BRBranchID, DataExchangeType.AccountInitData.ToString(), DataExchangeStatus.Complete.ToString());
                            }
                            else
                            {
                                CreatePostingHistory(0, branch.BRBranchID, DataExchangeType.AccountInitData.ToString(), DataExchangeStatus.Failed.ToString(), log);
                            }
                        }
                    }
                    TransferTimer.Stop();
                    BOSProgressBar.Close();
                }
            }
        }
        #endregion

        #region Transfer human resource data
        /// <summary>
        /// Called when user transfers human resource data to the centre
        /// </summary>
        /// <param name="sender">Event sender</param>
        public void TransferHumanResourceDataToCentre(object sender)
        {
            BOSProgressBar.Start(DataExchangeLocalizedResources.TransferringHumanResourceDataToHeadquarterMessage);
            TransferType = DataExchangeType.HumanResource.ToString();
            TransferStatus = DataExchangeStatus.New.ToString();
            TransferTimer.Start();

            TransferHumanResourceDataToCentre();
        }

        /// <summary>
        /// Transfer human resource data to the centre
        /// </summary>
        public void TransferHumanResourceDataToCentre()
        {
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo branch = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (branch != null && branch.BRBranchParentID > 0)
            {
                BRBranchsInfo centre = (BRBranchsInfo)objBranchsController.GetObjectByID(branch.BRBranchParentID);
                if (centre != null)
                {
                    //Get employees at local
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    List<HREmployeesInfo> employees = objEmployeesController.GetEmployeesForTransferring();

                    //Get time sheets at local
                    HRTimeSheetsController objTimeSheetsController = new HRTimeSheetsController();
                    HREmployeeTimeSheetsController objEmployeeTimeSheetsController = new HREmployeeTimeSheetsController();
                    HRTimeSheetEntrysController objTimeSheetEntrysController = new HRTimeSheetEntrysController();
                    List<HRTimeSheetsInfo> timeSheets = objTimeSheetsController.GetTimeSheetsForTransferring();
                    foreach (HRTimeSheetsInfo timeSheet in timeSheets)
                    {
                        timeSheet.EmployeeTimeSheets = objEmployeeTimeSheetsController.GetEmployeeTimeSheetsByTimeSheetID(timeSheet.HRTimeSheetID);
                        foreach (HREmployeeTimeSheetsInfo employeeTimeSheet in timeSheet.EmployeeTimeSheets)
                        {
                            employeeTimeSheet.HRTimeSheetEntrysList = objTimeSheetEntrysController.GetTimeSheetEntryByTimeSheetIDAndEmployeeTimeSheetID(
                                                                                                                                    timeSheet.HRTimeSheetID,
                                                                                                                                    employeeTimeSheet.HREmployeeTimeSheetID);
                        }
                    }

                    //Get payrolls at local
                    HRPayRollsController objPayRollsController = new HRPayRollsController();
                    HREmployeePayRollsController objEmployeePayRollsController = new HREmployeePayRollsController();
                    List<HRPayRollsInfo> payrolls = objPayRollsController.GetPayRollsForTransferring();
                    foreach (HRPayRollsInfo payroll in payrolls)
                    {
                        payroll.EmployeePayrolls = objEmployeePayRollsController.GetEmployeePayRollListByPayRollID(payroll.HRPayRollID);
                    }

                    bool isComplete = false;
                    int postingHistoryID = 0;
                    string log = string.Empty;
                    try
                    {
                        BOSApp.SwitchConnection(centre.BRBranchID);
                        if (BOSApp.TestCurrentConnection())
                        {
                            BRPostingHistorysController objPostingHistorysController = new BRPostingHistorysController();
                            BRPostingHistorysInfo objPostingHistorysInfo = objPostingHistorysController.GetPostingHistoryByStatusAndType(
                                                                                                    DataExchangeStatus.Posting.ToString(),
                                                                                                    DataExchangeType.HumanResource.ToString());
                            if (objPostingHistorysInfo != null)
                            {
                                return;
                            }

                            TransferStatus = DataExchangeStatus.Posting.ToString();
                            postingHistoryID = CreatePostingHistory(0, branch.BRBranchID, DataExchangeType.HumanResource.ToString(), DataExchangeStatus.Posting.ToString());

                            #region Transfer employees
                            foreach (HREmployeesInfo employee in employees)
                            {
                                HREmployeesInfo centralEmployee = (HREmployeesInfo)objEmployeesController.GetObjectByNo(employee.HREmployeeNo);
                                int centralEmployeeID = 0;
                                if (centralEmployee != null)
                                {
                                    centralEmployeeID = centralEmployee.HREmployeeID;
                                    centralEmployee = (HREmployeesInfo)employee.Clone();
                                    centralEmployee.HREmployeeID = centralEmployeeID;
                                    centralEmployee.FK_HRTimeSheetScaleID = 0;
                                    centralEmployee.AATransferredDate = BOSApp.GetCurrentServerDate();
                                    centralEmployeeID = objEmployeesController.UpdateObject(centralEmployee);
                                }
                            }
                            #endregion

                            #region Transfer time sheets
                            foreach (HRTimeSheetsInfo timeSheet in timeSheets)
                            {
                                HRTimeSheetsInfo centralTimeSheet = (HRTimeSheetsInfo)objTimeSheetsController.GetObjectByNo(timeSheet.HRTimeSheetNo);
                                int centralTimeSheetID = 0;
                                if (centralTimeSheet != null)
                                {
                                    centralTimeSheetID = centralTimeSheet.HRTimeSheetID;
                                    centralTimeSheet = (HRTimeSheetsInfo)timeSheet.Clone();
                                    centralTimeSheet.HRTimeSheetID = centralTimeSheetID;
                                    centralTimeSheet.AATransferredDate = BOSApp.GetCurrentServerDate();
                                    centralTimeSheetID = objTimeSheetsController.UpdateObject(centralTimeSheet);
                                }
                                else
                                {
                                    centralTimeSheet = (HRTimeSheetsInfo)timeSheet.Clone();
                                    centralTimeSheet.AAUpdatedDate = DateTime.MaxValue;
                                    centralTimeSheetID = objTimeSheetsController.CreateObject(centralTimeSheet);
                                }

                                if (centralTimeSheetID > 0)
                                {
                                    TransferEmployeeTimeSheetsToCentre(timeSheet.EmployeeTimeSheets, centralTimeSheetID);
                                }
                            }
                            #endregion

                            #region Transfer payrolls
                            foreach (HRPayRollsInfo payroll in payrolls)
                            {
                                HRPayRollsInfo centralPayRoll = (HRPayRollsInfo)objPayRollsController.GetObjectByNo(payroll.HRPayRollNo);
                                int centralPayRollID = 0;
                                if (centralPayRoll != null)
                                {
                                    centralPayRollID = centralPayRoll.HRPayRollID;
                                    centralPayRoll = (HRPayRollsInfo)payroll.Clone();
                                    centralPayRoll.HRPayRollID = centralPayRollID;
                                    centralPayRoll.AATransferredDate = BOSApp.GetCurrentServerDate();
                                    centralPayRollID = objPayRollsController.UpdateObject(centralPayRoll);
                                }
                                else
                                {
                                    centralPayRoll = (HRPayRollsInfo)payroll.Clone();
                                    centralPayRoll.AAUpdatedDate = DateTime.MaxValue;
                                    centralPayRollID = objPayRollsController.CreateObject(centralPayRoll);
                                }

                                if (centralPayRollID > 0)
                                {
                                    TransferEmployeePayrollsToCentre(payroll.EmployeePayrolls, centralPayRollID);
                                }
                            }
                            #endregion

                            isComplete = true;
                            MessageBox.Show(DataExchangeLocalizedResources.TransferSuccessMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(string.Format(DataExchangeLocalizedResources.CannotConnectToCentre, centre.BRBranchName), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        log = ex.Message;
                    }
                    finally
                    {
                        if (postingHistoryID > 0)
                        {
                            //Update posting history at centre
                            if (isComplete)
                            {
                                CreatePostingHistory(postingHistoryID, branch.BRBranchID, DataExchangeType.HumanResource.ToString(), DataExchangeStatus.Complete.ToString());
                            }
                            else
                            {
                                CreatePostingHistory(postingHistoryID, branch.BRBranchID, DataExchangeType.HumanResource.ToString(), DataExchangeStatus.Failed.ToString(), log);
                            }
                        }
                        BOSApp.RollbackLocalConnection();

                        if (postingHistoryID > 0)
                        {
                            if (isComplete)
                            {
                                //Update purchase data at local
                                UpdateLocalTimeSheetStatus(timeSheets);
                                UpdateLocalPayrollStatus(payrolls);
                            }

                            //Create posting history at local
                            if (isComplete)
                            {
                                CreatePostingHistory(0, branch.BRBranchID, DataExchangeType.HumanResource.ToString(), DataExchangeStatus.Complete.ToString());
                            }
                            else
                            {
                                CreatePostingHistory(0, branch.BRBranchID, DataExchangeType.HumanResource.ToString(), DataExchangeStatus.Failed.ToString(), log);
                            }
                        }
                    }
                    TransferTimer.Stop();
                    BOSProgressBar.Close();
                }
            }
        }

        /// <summary>
        /// Transfer the time sheets of employees to the centre
        /// </summary>
        /// <param name="employeeTimeSheets">Transferred employee time sheets</param>
        /// <param name="centralTimeSheetID">Time sheet id at centre</param>
        private void TransferEmployeeTimeSheetsToCentre(List<HREmployeeTimeSheetsInfo> employeeTimeSheets, int centralTimeSheetID)
        {
            HREmployeeTimeSheetsController objEmployeeTimeSheetsController = new HREmployeeTimeSheetsController();
            HRTimeSheetEntrysController objTimeSheetEntrysController = new HRTimeSheetEntrysController();
            objEmployeeTimeSheetsController.DeleteByTimeSheetID(centralTimeSheetID);

            foreach (HREmployeeTimeSheetsInfo employeeTimeSheet in employeeTimeSheets)
            {
                HREmployeeTimeSheetsInfo centralEmployeeTimeSheet = (HREmployeeTimeSheetsInfo)employeeTimeSheet.Clone();
                centralEmployeeTimeSheet.FK_HRTimeSheetID = centralTimeSheetID;
                int employeeTimeSheetID = objEmployeeTimeSheetsController.CreateObject(centralEmployeeTimeSheet);
                if (employeeTimeSheetID > 0)
                {
                    foreach (HRTimeSheetEntrysInfo entry in employeeTimeSheet.HRTimeSheetEntrysList)
                    {
                        HRTimeSheetEntrysInfo centralEntry = (HRTimeSheetEntrysInfo)entry.Clone();
                        centralEntry.FK_HRTimeSheetID = centralTimeSheetID;
                        centralEntry.FK_HREmployeeTimeSheetID = employeeTimeSheetID;
                        objTimeSheetEntrysController.CreateObject(centralEntry);
                    }
                }
            }
        }

        /// <summary>
        /// Transfer the payrolls of employees to the centre
        /// </summary>
        /// <param name="employeePayrolls">Transferred employee payrolls</param>
        /// <param name="centralPayrollID">Payroll id at centre</param>
        private void TransferEmployeePayrollsToCentre(List<HREmployeePayRollsInfo> employeePayrolls, int centralPayrollID)
        {
            HREmployeePayRollsController objEmployeePayRollsController = new HREmployeePayRollsController();
            objEmployeePayRollsController.DeleteByForeignColumn("FK_HRPayRollID", centralPayrollID);

            foreach (HREmployeePayRollsInfo employeePayroll in employeePayrolls)
            {
                HREmployeePayRollsInfo centralEmployeePayroll = (HREmployeePayRollsInfo)employeePayroll.Clone();
                centralEmployeePayroll.FK_HRPayRollID = centralPayrollID;
                objEmployeePayRollsController.CreateObject(centralEmployeePayroll);
            }
        }

        /// <summary>
        /// Update the status of time sheets at local, to track changes 
        /// for the next transfer
        /// </summary>
        /// <param name="timeSheets">Transferred time sheets</param>
        private void UpdateLocalTimeSheetStatus(List<HRTimeSheetsInfo> timeSheets)
        {
            HRTimeSheetsController objTimeSheetsController = new HRTimeSheetsController();
            foreach (HRTimeSheetsInfo timeSheet in timeSheets)
            {
                timeSheet.IsTransferred = true;
                timeSheet.AATransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objTimeSheetsController.UpdateObject(timeSheet);
            }
        }

        /// <summary>
        /// Update the status of payrolls at local, to track changes for the next transfer
        /// </summary>
        /// <param name="payrolls">Transferred payrolls</param>
        private void UpdateLocalPayrollStatus(List<HRPayRollsInfo> payrolls)
        {
            HRPayRollsController objPayrollsController = new HRPayRollsController();
            foreach (HRPayRollsInfo payroll in payrolls)
            {
                payroll.IsTransferred = true;
                payroll.AATransferredDate = BOSApp.GetCurrentServerDate().AddSeconds(App.UpdateSeconds);
                objPayrollsController.UpdateObject(payroll);
            }
        }
        #endregion

        #endregion

        public int CreatePostingHistory(
                                    int postingHistoryID,
                                    int branchID,
                                    string type,
                                    string status)
        {
            return CreatePostingHistory(postingHistoryID, branchID, type, status, string.Empty);
        }

        public int CreatePostingHistory(
                                    int postingHistoryID,
                                    int branchID,
                                    string type,
                                    string status,
                                    string log)
        {
            BRPostingHistorysController objPostingHistorysController = new BRPostingHistorysController();
            BRPostingHistorysInfo objPostingHistorysInfo = new BRPostingHistorysInfo();
            objPostingHistorysInfo.BRPostingHistoryUserName = BOSApp.CurrentUser;
            objPostingHistorysInfo.FK_BRBranchID = branchID;
            objPostingHistorysInfo.BRPostingHistoryDate = BOSApp.GetCurrentServerDate();
            objPostingHistorysInfo.BRPostingHistoryType = type;
            objPostingHistorysInfo.BRPostingHistoryStatus = status;
            objPostingHistorysInfo.BRPostingHistoryLog = log;
            if (postingHistoryID == 0)
            {
                return objPostingHistorysController.CreateObject(objPostingHistorysInfo);
            }
            else
            {
                objPostingHistorysInfo.BRPostingHistoryID = postingHistoryID;
                return objPostingHistorysController.UpdateObject(objPostingHistorysInfo);
            }
        }
    }
}
