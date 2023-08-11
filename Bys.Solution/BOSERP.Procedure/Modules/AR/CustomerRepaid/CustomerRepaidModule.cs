using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.CustomerRepaid
{
    public class CustomerRepaidModule : BaseTransactionModule
    {
        #region Constants
        public const string InvoiceGridControlName = "fld_dgcInvoices";
        public const string CustomerPaymentDetailGridControlName = "fld_dgcCustomerPaymentDetails";
        public const string DocumentEntryGridControlName = "fld_dgcDocumentEntrys";

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        #endregion

        #region Variables
        /// <summary>
        /// A variable indicates whether the user is creating a new payment voucher
        /// </summary>
        private bool CreatePaymentVoucher = false;

        /// <summary>
        /// A variable indicates whether the user is creating a new payment order
        /// </summary>
        private bool CreatePaymentOrder = false;

        /// <summary>
        /// A variable indicates whether the user is creating a new payment by owing
        /// </summary>
        private bool CreateOwingExchange = false;

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        #endregion

        public CustomerRepaidModule()
        {
            Name = ModuleName.CustomerRepaid;
            CurrentModuleEntity = new CustomerRepaidEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            CustomerRepaidEntities entity = (CustomerRepaidEntities)CurrentModuleEntity;
            ARCustomerPaymentDetailsGridControl gridControl = Controls[CustomerRepaidModule.CustomerPaymentDetailGridControlName] as ARCustomerPaymentDetailsGridControl;
            gridControl.CustomerPaymentDetailList = entity.PaymentDetailList;
            gridControl.InitGridControlDataSource();

            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[CustomerRepaidModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        }

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START

        //public override string GenerateSearchQuery(string strTableName)
        //{
        //    string query = base.GenerateSearchQuery(strTableName);
        //    query += string.Format(" and ARCustomerPaymentType = '{0}'", CustomerPaymentType.Repaid.ToString());
        //    return query;
        //}

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
            ARCustomerPaymentsInfo searchObject = (ARCustomerPaymentsInfo)CurrentModuleEntity.SearchObject;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);

            DataSet ds = new DataSet();

            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objCustomerPaymentsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objCustomerPaymentsController.GetCustomerPaymentDatasetFromBranchList(
                                                                    searchObject.ARCustomerPaymentNo,
                                                                    null,
                                                                    objObjectsInfo.ACObjectID,
                                                                    objObjectsInfo.ACObjectType,
                                                                    searchObject.FK_HREmployeeID,
                                                                    CustomerPaymentType.Repaid.ToString(),
                                                                    searchObject.CustomerPaymentDateFrom,
                                                                    searchObject.CustomerPaymentDateTo,
                                                                    BranchList);
                }
            }
            else
            {
                ds = objCustomerPaymentsController.GetCustomerPaymentDatasetFromBranchID(
                                                                    searchObject.ARCustomerPaymentNo,
                                                                    null,
                                                                    objObjectsInfo.ACObjectID,
                                                                    objObjectsInfo.ACObjectType,
                                                                    searchObject.FK_HREmployeeID,
                                                                    CustomerPaymentType.Repaid.ToString(),
                                                                    searchObject.FK_BRBranchID,
                                                                    searchObject.CustomerPaymentDateFrom,
                                                                    searchObject.CustomerPaymentDateTo);

            }

            return ds;
        }

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public void GetCurrentModuleDataViewPermission()
        {
            CurrentModuleDataViewPermissionList = BOSApp.CurrentADDataViewPermissionList.Where(i => i.STModuleName == Name && i.ADDataViewPermissionType == ADDataViewPermissionType.Module).ToList();

            List<int> branchIDList = new List<int>();
            foreach (ADDataViewPermissionsInfo dataViewPermissionsInfo in CurrentModuleDataViewPermissionList)
            {
                branchIDList.Add(dataViewPermissionsInfo.FK_BRBranchID);
            }

            if (branchIDList.Count == 0)
            {
                BranchList = new List<BRBranchsInfo>();
            }
            else
            {
                BRBranchsController objBranchsController = new BRBranchsController();
                List<BRBranchsInfo> branchList = objBranchsController.GetAllBranches();

                BranchList = branchList.Where(i => branchIDList.IndexOf(i.BRBranchID) > -1).ToList();
            }
        }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

        /// <summary>
        /// Called when the user create a new payment voucher for 
        /// a new customer payment
        /// </summary>
        public void ActionCreatePaymentVoucher()
        {
            CreatePaymentVoucher = true;
            CreatePaymentOrder = false;
            CreateOwingExchange = false;
            ActionNew();
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            customerPayment.ARPaymentMethodCombo = PaymentMethod.Cash.ToString();
            ARCustomerPaymentDetailsGridControl gridControl = (ARCustomerPaymentDetailsGridControl)Controls[CustomerRepaidModule.CustomerPaymentDetailGridControlName];
            gridControl.PaymentAmount = 0;
            gridControl.RequiredMethod = PaymentMethod.Cash.ToString();
        }

        /// <summary>
        /// Called when the user create a new payment order for 
        /// a new customer payment
        /// </summary>
        public void ActionCreatePaymentOrder()
        {
            CreatePaymentOrder = true;
            CreatePaymentVoucher = false;
            CreateOwingExchange = false;
            ActionNew();
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            customerPayment.ARPaymentMethodCombo = PaymentMethod.PaymentOrder.ToString();
            ARCustomerPaymentDetailsGridControl gridControl = (ARCustomerPaymentDetailsGridControl)Controls[CustomerRepaidModule.CustomerPaymentDetailGridControlName];
            gridControl.PaymentAmount = 0;
            gridControl.RequiredMethod = PaymentMethod.PaymentOrder.ToString();

            //CreatePaymentOrder = false;
        }

        /// <summary>
        /// Called when the user create a new payment by owing
        /// </summary>
        public void ActionCreateOwingExchange()
        {
            CreateOwingExchange = true;
            CreatePaymentVoucher = false;
            CreatePaymentOrder = false;

            ActionNew();
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            customerPayment.ARPaymentMethodCombo = PaymentMethod.OwingExchange.ToString();
            ARCustomerPaymentDetailsGridControl gridControl = (ARCustomerPaymentDetailsGridControl)Controls[CustomerRepaidModule.CustomerPaymentDetailGridControlName];
            gridControl.PaymentAmount = 0;
            gridControl.RequiredMethod = string.Empty;
            //CreateOwingExchange = false;
        }

        public override int ActionSave()
        {
            SetDefaultDesc();
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            if (CreatePaymentVoucher && customerPayment.FK_CSCashFundID <= 0)
            {
                MessageBox.Show(CustomerPaymentTimePaymentLocalizedResources.RequireCashFund
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return 0;
            }
            if (CreatePaymentOrder && customerPayment.FK_CSCompanyBankID <= 0)
            {
                MessageBox.Show(CustomerPaymentTimePaymentLocalizedResources.RequireCompanyBank
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return 0;
            }
            CustomerRepaidEntities entity = (CustomerRepaidEntities)CurrentModuleEntity;
            entity.InvoiceList.EndCurrentEdit();
            UpdateTotalAmount();

            int objectID = base.ActionSave();
            if (objectID > 0)
            {
                //Update backup list of document payments
                entity.InvoiceList.BackupList.Clear();
                foreach (ARInvoicesInfo objDocumentPaymentsInfo in entity.InvoiceList)
                {
                    entity.InvoiceList.BackupList.Add((ARInvoicesInfo)objDocumentPaymentsInfo.Clone());
                }
            }
            return objectID;
        }

        /// <summary>
        /// Set the default desc for the payment
        /// </summary>
        private void SetDefaultDesc()
        {
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            ARCustomersController objCustomersController = new ARCustomersController();
            ARCustomersInfo customer = (ARCustomersInfo)objCustomersController.GetObjectByID(customerPayment.FK_ARCustomerID);
            if (customer != null)
            {
                CustomerRepaidEntities entity = (CustomerRepaidEntities)CurrentModuleEntity;
                string invoiceNo = string.Empty;
                foreach (ARInvoicesInfo invoice in entity.InvoiceList)
                {
                    invoiceNo += string.Format(" {0} - {1},", invoice.ARInvoiceNo, invoice.ARInvoiceDate.ToString("dd/MM/yyyy"));
                }
                if (!string.IsNullOrEmpty(invoiceNo))
                {
                    invoiceNo = invoiceNo.Substring(0, invoiceNo.Length - 1);
                }
                customerPayment.ARCustomerPaymentDesc = customerPayment.ARCustomerPaymentDesc.Replace("{0}", customer.ARCustomerName);
                customerPayment.ARCustomerPaymentDesc = customerPayment.ARCustomerPaymentDesc.Replace("{1}", invoiceNo);
            }
        }

        public override void ActionPrint()
        {
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            if (customerPayment.ARPaymentMethodCombo == PaymentMethod.Cash.ToString())
            {
                APPaymentVouchersController objPaymentVouchersController = new APPaymentVouchersController();
                APPaymentVouchersInfo paymentVoucher = (APPaymentVouchersInfo)objPaymentVouchersController.GetObjectByNo(customerPayment.ARCustomerPaymentNo);
                if (paymentVoucher != null)
                {
                    PaymentVoucher.PaymentVoucherModule.PrintPaymentVoucher(paymentVoucher.APPaymentVoucherID);
                }
            }
            else if (customerPayment.ARPaymentMethodCombo == PaymentMethod.PaymentOrder.ToString())
            {
                ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
                ACBankTransactionsInfo paymentOrder = (ACBankTransactionsInfo)objBankTransactionsController.GetObjectByNo(customerPayment.ARCustomerPaymentNo);
                if (paymentOrder != null)
                {
                    PaymentOrder.PaymentOrderModule.PrintPaymentOrder(paymentOrder.ACBankTransactionID);
                }
            }
            else
            {
                ACDocumentsController objDocumentsController = new ACDocumentsController();
                ACDocumentsInfo document = objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.NghiepVuKhac.ToString(),
                                                                                        customerPayment.ARCustomerPaymentNo);
                if (document != null)
                {
                    Document.DocumentModule.PrintDocument(document.ACDocumentID);
                }
            }
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);

            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            ARCustomerPaymentDetailsGridControl gridControl = (ARCustomerPaymentDetailsGridControl)Controls[CustomerRepaidModule.CustomerPaymentDetailGridControlName];
            gridControl.PaymentAmount = objCustomerPaymentsInfo.ARCustomerPaymentTotalAmount;
        }

        /// <summary>
        /// Called when user changes the amount for an invoice
        /// </summary>
        /// <param name="objInvoicesInfo">Invoice object</param>
        public void ChangeInvoicePaymentAmount(ARInvoicesInfo objInvoicesInfo)
        {
            UpdateTotalAmount();
        }

        /// <summary>
        /// Update total amount of the customer repaying
        /// </summary>
        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                UpdateDocumentEntries();

                CustomerRepaidEntities entity = (CustomerRepaidEntities)CurrentModuleEntity;
                ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)entity.MainObject;
                foreach (ACDocumentEntrysInfo item in entity.DocumentEntryList)
                {
                    BOSApp.RoundByCurrency(item, objCustomerPaymentsInfo.FK_GECurrencyID);
                }
                if (entity.DocumentEntryList.Count != 0)
                    objCustomerPaymentsInfo.ARCustomerPaymentTotalAmount = entity.DocumentEntryList.Sum(e => e.ACDocumentEntryAmount);
                else
                    objCustomerPaymentsInfo.ARCustomerPaymentTotalAmount = entity.InvoiceList.Sum(e => e.ARDocumentPaymentAmount);
                BOSApp.RoundByCurrency(objCustomerPaymentsInfo, "ARCustomerPaymentTotalAmount", objCustomerPaymentsInfo.FK_GECurrencyID);
                objCustomerPaymentsInfo.ARCustomerPaymentExchangeAmount = objCustomerPaymentsInfo.ARCustomerPaymentTotalAmount * objCustomerPaymentsInfo.ARCustomerPaymentExchangeRate;
                BOSApp.RoundByCurrency(objCustomerPaymentsInfo, objCustomerPaymentsInfo.FK_GECurrencyID);
                entity.UpdateMainObjectBindingSource();

                ARCustomerPaymentDetailsGridControl gridControl = (ARCustomerPaymentDetailsGridControl)Controls[CustomerRepaidModule.CustomerPaymentDetailGridControlName];
                gridControl.PaymentAmount = objCustomerPaymentsInfo.ARCustomerPaymentTotalAmount;
                gridControl.ProposeRemainingAmount();
            }
        }

        /// <summary>
        /// Called when user wants to choose owing invoices for repaying
        /// </summary>
        public void ChooseOwingInvoices()
        {
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            //List<ARInvoicesInfo> invoices = objInvoicesController.GetOwingInvoices(objCustomerPaymentsInfo.FK_ARCustomerID);
            List<ARInvoicesInfo> invoices = objInvoicesController.GetOwingInvoicesByUserPermission(objCustomerPaymentsInfo.FK_ARCustomerID, null, null, null, null,
                                                                                        null, null, BOSApp.CurrentUsersInfo.ADUserID,
                                                                                        ModuleName.Invoice, ADDataViewPermissionType.Module);
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

            invoices = invoices.Where(i => i.ARInvoiceBalanceDue < 0).ToList();
            guiFind<ARInvoicesInfo> guiFind = new guiFind<ARInvoicesInfo>(TableName.ARInvoicesTableName, invoices, this, true);
            if (guiFind.ShowDialog() == DialogResult.OK)
            {
                CustomerRepaidEntities entity = (CustomerRepaidEntities)CurrentModuleEntity;
                foreach (ARInvoicesInfo objInvoicesInfo in guiFind.SelectedObjects)
                {
                    if (!entity.InvoiceList.Exists(i => i.ARInvoiceID == objInvoicesInfo.ARInvoiceID))
                    {
                        objInvoicesInfo.ARDocumentPaymentExchangeRate = 1;
                        entity.InvoiceList.Add(objInvoicesInfo);
                    }
                    objCustomerPaymentsInfo.FK_ARCustomerID = objInvoicesInfo.FK_ARCustomerID;
                }
                entity.InvoiceList.GridControl.InvalidateLookupEditColumns();
                entity.InvoiceList.GridControl.RefreshDataSource();
                entity.UpdateMainObjectBindingSource();
            }
        }

        /// <summary>
        /// Remove an selected invoice from its list
        /// </summary>
        public void RemoveSelectedInvoice()
        {
            CustomerRepaidEntities entity = (CustomerRepaidEntities)CurrentModuleEntity;
            entity.InvoiceList.RemoveSelectedRowObjectFromList();
        }

        /// <summary>
        /// Called when user changes the total amount
        /// </summary>
        public void ChangeTotalAmount()
        {
            UpdateTotalAmount();
        }

        /// <summary>
        /// Called when user changes the bank
        /// </summary>
        /// <param name="bankID">Target bank id</param>
        public void ChangeBank(int bankID)
        {
            CustomerRepaidEntities entity = (CustomerRepaidEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)entity.MainObject;
            objCustomerPaymentsInfo.FK_CSCompanyBankID = bankID;
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(bankID);
            if (objCompanyBanksInfo != null)
            {
                objCustomerPaymentsInfo.ARCustomerPaymentBankAccount = objCompanyBanksInfo.CSCompanyBankAccount;
                CurrentModuleEntity.UpdateMainObjectBindingSource();
                if (CreatePaymentOrder && objCompanyBanksInfo.FK_ACAcountID > 0)
                {
                    entity.DocumentEntryList.ForEach(x => x.FK_ACCreditAccountID = objCompanyBanksInfo.FK_ACAcountID);
                    entity.DocumentEntryList.GridControl.RefreshDataSource();
                }
            }
        }

        /// <summary>
        /// Called when user wants to change the cash fund
        /// </summary>
        public void ChangeCashFund(int cashFundID)
        {
            CustomerRepaidEntities entity = (CustomerRepaidEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)entity.MainObject;
            objCustomerPaymentsInfo.FK_CSCashFundID = cashFundID;
            CSCashFundsController objCashFundsController = new CSCashFundsController();
            CSCashFundsInfo objCashFundsInfo = (CSCashFundsInfo)objCashFundsController.GetObjectByID(cashFundID);
            if (objCashFundsInfo != null && CreatePaymentVoucher && objCashFundsInfo.FK_ACAcountID > 0)
            {
                entity.DocumentEntryList.ForEach(x => x.FK_ACCreditAccountID = objCashFundsInfo.FK_ACAcountID);
                entity.DocumentEntryList.GridControl.RefreshDataSource();
            }
        }

        /// <summary>
        /// Called when the user changes the customer
        /// </summary>
        /// <param name="customerID">Selected customer id</param>
        public void ChangeCustomer(int customerID)
        {
            CustomerRepaidEntities entity = (CustomerRepaidEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)entity.MainObject;
            customerPayment.FK_ARCustomerID = customerID;
            if (!Toolbar.IsNullOrNoneAction())
            {
                ARCustomersController objCustomersController = new ARCustomersController();
                ARCustomersInfo customer = (ARCustomersInfo)objCustomersController.GetObjectByID(customerID);
                if (customer != null && customer.FK_ACAccountSaleID > 0)
                {
                    customerPayment.ARCustomerPaymentSenderName = customer.ARCustomerName;
                    entity.DocumentEntryList.ForEach(x => x.FK_ACDebitAccountID = customer.FK_ACAccountSaleID);
                    entity.DocumentEntryList.GridControl.RefreshDataSource();
                }
            }
        }

        #region Accounting
        protected override void UpdateDocumentEntries()
        {
            CustomerRepaidEntities entity = (CustomerRepaidEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)entity.MainObject;

            ARCustomersController objCustomersController = new ARCustomersController();
            ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(objCustomerPaymentsInfo.FK_ARCustomerID);
            foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
            {
                //Update Dedit Account ID
                if (objCustomersInfo != null && objCustomersInfo.FK_ACAccountSaleID > 0)
                {
                    entry.FK_ACDebitAccountID = objCustomersInfo.FK_ACAccountSaleID;
                }
                //Update Credit Account ID 
                if (CreatePaymentVoucher)
                {
                    CSCashFundsController objCashFundsController = new CSCashFundsController();
                    CSCashFundsInfo objCashFundsInfo = (CSCashFundsInfo)objCashFundsController.GetObjectByID(objCustomerPaymentsInfo.FK_CSCashFundID);
                    if (objCashFundsInfo != null && objCashFundsInfo.FK_ACAcountID > 0)
                    {
                        entry.FK_ACCreditAccountID = objCashFundsInfo.FK_ACAcountID;
                    }
                }
                else if (CreatePaymentOrder)
                {
                    CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
                    CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(objCustomerPaymentsInfo.FK_CSCompanyBankID);
                    if (objCompanyBanksInfo != null && objCompanyBanksInfo.FK_ACAcountID > 0)
                    {
                        entry.FK_ACCreditAccountID = objCompanyBanksInfo.FK_ACAcountID;
                    }
                }
                if (entry.ACEntryTypeName == AccEntryType.TraTienKhachHang.ToString())
                {
                    if (entity.InvoiceList.Count > 0)
                    {
                        entry.ACDocumentEntryAmount = entity.InvoiceList.Sum(i => i.ARDocumentPaymentAmount);
                    }
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryAmount", objCustomerPaymentsInfo.FK_GECurrencyID);
                    entry.ACDocumentEntryExchangeAmount = entry.ACDocumentEntryAmount * objCustomerPaymentsInfo.ARCustomerPaymentExchangeRate;
                    BOSApp.RoundByCurrency(entry, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                }
            }
        }
        #endregion

        public void UpdateTotalAmountByCurrency(int currencieID)
        {
            CustomerRepaidEntities entity = (CustomerRepaidEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo mainObject = (ARCustomerPaymentsInfo)entity.MainObject;
            mainObject.FK_GECurrencyID = currencieID;
            foreach (ARCustomerPaymentDetailsInfo item in entity.PaymentDetailList)
            {
                BOSApp.RoundByCurrency(item, mainObject.FK_GECurrencyID);
            }
            UpdateTotalAmount();
            entity.PaymentDetailList.GridControl.RefreshDataSource();

            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeObject(string objectAccessKey)
        {
            CustomerRepaidEntities entity = (CustomerRepaidEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            objCustomerPaymentsInfo.ACObjectAccessKey = objectAccessKey;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            if (objObjectsInfo != null && objObjectsInfo.FK_ACAccountSaleID > 0)
            {
                if (objObjectsInfo.ACObjectType == ObjectType.Customer.ToString())
                    objCustomerPaymentsInfo.FK_ARCustomerID = objObjectsInfo.ACObjectID;
                objCustomerPaymentsInfo.ARCustomerPaymentSenderName = objObjectsInfo.ACObjectName;
                entity.DocumentEntryList.ForEach(x => x.FK_ACDebitAccountID = objObjectsInfo.FK_ACAccountSaleID);
                entity.DocumentEntryList.GridControl.RefreshDataSource();
            }
        }

        public void ActionPosted()
        {
            if (!CheckLock()) return;
            CustomerRepaidEntities entity = (CustomerRepaidEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo mainObject = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ARCustomerPaymentPostedStatus = PostedTransactionStatus.Posted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ARCustomerPaymentID, PostedTransactionStatus.Posted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.PostedTransactions(this.Name, mainObject.ARCustomerPaymentID, ModulePostingType.Accounting, ModulePostingType.InvoiceTrans);
            InvalidateToolbar();
        }

        public void ActionUnPosted()
        {
            if (!CheckLock()) return;
            CustomerRepaidEntities entity = (CustomerRepaidEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo mainObject = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ARCustomerPaymentPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ARCustomerPaymentID, PostedTransactionStatus.UnPosted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.UnPostedTransactions(this.Name, mainObject.ARCustomerPaymentID, ModulePostingType.Accounting, ModulePostingType.InvoiceTrans);
            InvalidateToolbar();
        }

        public override void InvalidateToolbar()
        {
            CustomerRepaidEntities entity = (CustomerRepaidEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo mainObject = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            if (mainObject.ARCustomerPaymentID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                    mainObject.ARCustomerPaymentPostedStatus != PostedTransactionStatus.Posted.ToString());
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                    mainObject.ARCustomerPaymentPostedStatus == PostedTransactionStatus.Posted.ToString());
            }
            base.InvalidateToolbar();
        }
    }
}
