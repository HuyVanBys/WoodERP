using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Utilities;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace BOSERP.Modules.CustomerPaymentTimePayment
{
    public class CustomerPaymentTimePaymentModule : BaseTransactionModule
    {
        #region Constant
        public const string CustomerPaymentDocumentGridControlName = "fld_dgcARCustomerPaymentDocuments";
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        public const string CustomerPaymentsInfosTabControlName = "fld_tabCustomerPayments";
        public const string CustomerPaymentTotalAmountTextBoxName = "fld_txtARCustomerPaymentTotalAmount";
        public const string CompanyBankIDLookupEditControlName = "fld_lkeFK_CSCompanyBankID";
        public const string CashFundIDLookupEditControlName = "fld_lkeFK_CSCashFundID";
        public const string ProjectIDLookupEditControlName = "fld_lkeFK_PMProjectID";
        public const string PickLabelName = "pick";
        #endregion

        #region Variables
        public BOSLookupEdit SearchBranchLookupEditControl;
        public BOSLookupEdit ProjectIDLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        #endregion

        #region Public Properties

        public BOSTabControl CustomerPaymentsInfosTabControl;
        public BOSTextBox CustomerPaymentTotalAmountTextBox;
        public BOSLookupEdit CompanyBankIDLookupEditControl;
        public BOSLookupEdit CashFundIDLookupEditControl;
        public BOSLabel PickLabel;
        public ARCustomerPaymentDocumentsGridControl gridPaymentDocumentControl;
        #endregion

        #region Constructor
        public CustomerPaymentTimePaymentModule()
        {
            Name = "CustomerPaymentTimePayment";
            CurrentModuleEntity = new CustomerPaymentTimePaymentEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[CustomerPaymentTimePaymentModule.SearchBranchLookupEditControlName];
            if(SearchBranchLookupEditControl != null)
            {
                SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            }

            CustomerPaymentsInfosTabControl = (BOSTabControl)Controls[CustomerPaymentTimePaymentModule.CustomerPaymentsInfosTabControlName];
            CustomerPaymentTotalAmountTextBox = (BOSTextBox)Controls[CustomerPaymentTimePaymentModule.CustomerPaymentTotalAmountTextBoxName];
            CompanyBankIDLookupEditControl = (BOSLookupEdit)Controls[CustomerPaymentTimePaymentModule.CompanyBankIDLookupEditControlName];
            if(CompanyBankIDLookupEditControl != null)
            {
                CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
                CompanyBankIDLookupEditControl.Properties.DataSource = objCompanyBanksController.GetListCompanyBanksByBranchID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            }

            CashFundIDLookupEditControl = (BOSLookupEdit)Controls[CustomerPaymentTimePaymentModule.CashFundIDLookupEditControlName];
            if(CashFundIDLookupEditControl != null)
            {
                CSCashFundsController objCashFundsController = new CSCashFundsController();
                CashFundIDLookupEditControl.Properties.DataSource = objCashFundsController.GetListCashFundsByBranchID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            }

            ProjectIDLookupEditControl = (BOSLookupEdit)Controls[CustomerPaymentTimePaymentModule.ProjectIDLookupEditControlName];
            PickLabel = (BOSLabel)Controls[CustomerPaymentTimePaymentModule.PickLabelName];
            gridPaymentDocumentControl = Controls[CustomerPaymentTimePaymentModule.CustomerPaymentDocumentGridControlName] as ARCustomerPaymentDocumentsGridControl;
            if (gridPaymentDocumentControl != null)
            {
                gridPaymentDocumentControl.Visible = false;
            }   
        }
        #endregion

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
            ARCustomerPaymentsInfo searchObject = (ARCustomerPaymentsInfo)CurrentModuleEntity.SearchObject;

            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);
            DataSet ds = new DataSet();

            if (SearchBranchLookupEditControl != null 
                    && (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0"))
            {
                if (BranchList.Count == 0)
                {
                    ds = objCustomerPaymentsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objCustomerPaymentsController.GetCustomerPaymentDatasetByBranchListID(
                                                                    searchObject.ARCustomerPaymentNo,
                                                                    searchObject.ARInvoiceNo,
                                                                    objObjectsInfo.ACObjectID,
                                                                    objObjectsInfo.ACObjectType,
                                                                    searchObject.FK_HREmployeeID,
                                                                    new List<String> { CustomerPaymentType.SaleOrder.ToString(), CustomerPaymentType.AdvancePayment.ToString() },
                                                                    searchObject.CustomerPaymentDateFrom,
                                                                    searchObject.CustomerPaymentDateTo,
                                                                    BranchList);
                }
            }
            else
            {
                ds = objCustomerPaymentsController.GetCustomerPaymentDataset(
                                                                    searchObject.ARCustomerPaymentNo,
                                                                    searchObject.ARInvoiceNo,
                                                                    objObjectsInfo.ACObjectID,
                                                                    objObjectsInfo.ACObjectType,
                                                                    searchObject.FK_HREmployeeID,
                                                                    new List<String> { CustomerPaymentType.SaleOrder.ToString(), CustomerPaymentType.AdvancePayment.ToString() },
                                                                    searchObject.CustomerPaymentDateFrom,
                                                                    searchObject.CustomerPaymentDateTo,
                                                                    searchObject.FK_BRBranchID);

            }
            return ds;
        }

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


        private void EnableControls()
        {
            ARCustomerPaymentsInfo mainObject = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            bool isReceiptVoucher = mainObject.ARPaymentMethodCombo == PaymentMethod.Cash.ToString() ? true : false;
            if(CashFundIDLookupEditControl != null)
            {
                CashFundIDLookupEditControl.Enabled = isReceiptVoucher;
            }
            if(CompanyBankIDLookupEditControl != null)
            {
                CompanyBankIDLookupEditControl.Enabled = !isReceiptVoucher;
            }
            if(PickLabel != null)
            {
                PickLabel.Visible = isReceiptVoucher;
            }
        }

        public override void ActionNew()
        {
            base.ActionNew();
            EnableControls();
        }

        /// <summary>
        /// Called when the user create a new receipt voucher for 
        /// a new customer payment
        /// </summary>
        public void ActionCreateReceiptVoucher()
        {
            ActionNew();
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            customerPayment.ARPaymentMethodCombo = PaymentMethod.Cash.ToString();
            customerPayment.ARCustomerPaymentFromType = CustomerPaymentFromType.ReceiptVoucher.ToString();
            EnableControls();
            GenerateAccountingData();
            GeneratePaymentDocumentData();
        }

        /// <summary>
        /// Called when the user create a new bank transfer for 
        /// a new customer payment
        /// </summary>
        public void ActionCreateBankTransfer()
        {
            ActionNew();
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            customerPayment.ARPaymentMethodCombo = PaymentMethod.BankTransfer.ToString();
            customerPayment.ARCustomerPaymentFromType = CustomerPaymentFromType.BankTransfer.ToString();
            EnableControls();
            GenerateAccountingData();
            GeneratePaymentDocumentData();
        }

        /// <summary>
        /// Called when the user create a new payment by owing
        /// </summary>
        public void ActionCreateOwingExchange()
        {
            ActionNew();
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            customerPayment.ARPaymentMethodCombo = PaymentMethod.OwingExchange.ToString();
            customerPayment.ARCustomerPaymentFromType = CustomerPaymentFromType.OwingExchange.ToString();
            GenerateAccountingData();
            GeneratePaymentDocumentData();
        }

        public void ChangeExchangeRate()
        {
            UpdateTotalAmount();

        }

        public override int ActionSave()
        {
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)entity.MainObject;

            if (customerPayment.FK_ACObjectID == 0)
            {
                MessageBox.Show(
                                CustomerPaymentTimePaymentLocalizedResources.ChooseObject
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                return 0;
            }

            if (entity.CustomerPaymentDocumentList == null || entity.CustomerPaymentDocumentList.Count == 0)
            {
                MessageBox.Show(CustomerPaymentTimePaymentLocalizedResources.EntryIsEmpty
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                return 0;
            }
            GECurrenciesController objGECurrenciesController = new GECurrenciesController();
            GECurrenciesInfo objGECurrenciesInfo = new GECurrenciesInfo();
            objGECurrenciesInfo = (GECurrenciesInfo)objGECurrenciesController.GetObjectByNo(CurrencyNo.VND.ToString());
            if (customerPayment.FK_GECurrencyID != objGECurrenciesInfo.GECurrencyID && customerPayment.ARCustomerPaymentExchangeRate == 1)
            {
                MessageBox.Show(CustomerPaymentTimePaymentLocalizedResources.ARCustomerPaymentExchangeRateRequiredMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            if (customerPayment.ARCustomerPaymentFromType == CustomerPaymentFromType.BankTransfer.ToString() && customerPayment.FK_CSCompanyBankID <= 0)
            {
                MessageBox.Show(CustomerPaymentTimePaymentLocalizedResources.RequireCompanyBank
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
                return 0;
            }
            if (customerPayment.ARCustomerPaymentFromType == CustomerPaymentFromType.ReceiptVoucher.ToString() && customerPayment.FK_CSCashFundID <= 0)
            {
                MessageBox.Show(CustomerPaymentTimePaymentLocalizedResources.ChooseCashFun
                            , CommonLocalizedResources.MessageBoxDefaultCaption
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Information);
                return 0;
            }
            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            entity.ARCustomerPaymentTimePaymentList.EndCurrentEdit();

            foreach (ARCustomerPaymentTimePaymentsInfo item in entity.ARCustomerPaymentTimePaymentList)
            {
                if (item.FK_ARSaleOrderID > 0 && item.FK_ARInvoiceID == 0)
                {
                    ARSaleOrdersInfo objSO = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(item.FK_ARSaleOrderID);
                    if (objSO != null)
                    {
                        if (string.IsNullOrEmpty(customerPayment.ARCustomerPaymentDesc))
                        {
                            customerPayment.ARCustomerPaymentDesc = objSO.ARSaleOrderNo;
                        }
                        else
                        {
                            if (customerPayment.ARCustomerPaymentDesc.Contains(objSO.ARSaleOrderNo))
                            {
                                customerPayment.ARCustomerPaymentDesc = customerPayment.ARCustomerPaymentDesc;
                            }
                            else
                            {
                                customerPayment.ARCustomerPaymentDesc = customerPayment.ARCustomerPaymentDesc + "; " + objSO.ARSaleOrderNo;
                            }
                        }
                    }
                }
                if (item.FK_ARInvoiceID > 0)
                {
                    ARInvoicesInfo objIV = (ARInvoicesInfo)objInvoicesController.GetObjectByID(item.FK_ARInvoiceID);
                    if (objIV != null)
                    {
                        if (string.IsNullOrEmpty(customerPayment.ARCustomerPaymentDesc))
                        {
                            customerPayment.ARCustomerPaymentDesc = objIV.ARInvoiceVATInvoiceNo;
                        }
                        else
                        {
                            if (customerPayment.ARCustomerPaymentDesc.Contains(objIV.ARInvoiceVATInvoiceNo))
                            {
                                customerPayment.ARCustomerPaymentDesc = customerPayment.ARCustomerPaymentDesc;
                            }
                            else
                            {
                                customerPayment.ARCustomerPaymentDesc = customerPayment.ARCustomerPaymentDesc + "; " + objIV.ARInvoiceVATInvoiceNo;
                            }
                        }
                    }
                }
            }

            SetDefaultDesc();
            BOSList<ACDocumentEntrysInfo> documentEntryList = new BOSList<ACDocumentEntrysInfo>();
            foreach (ARCustomerPaymentDocumentsInfo item in entity.CustomerPaymentDocumentList)
            {
                ACDocumentEntrysInfo objDocumentEntrysInfo = new ACDocumentEntrysInfo();
                objDocumentEntrysInfo.ACDocumentEntryAmount = item.ARCustomerPaymentDocumentAmount;
                objDocumentEntrysInfo.ACDocumentEntryExchangeAmount = item.ARCustomerPaymentDocumentExchangeAmount;
                objDocumentEntrysInfo.FK_ACDebitAccountID = item.FK_ACDebitAccountID;
                objDocumentEntrysInfo.FK_ACCreditAccountID = item.FK_ACCreditAccountID;
                objDocumentEntrysInfo.ACDocumentEntryDesc = item.ARCustomerPaymentDocumentDesc;
                objDocumentEntrysInfo.FK_ACCostObjectID = item.FK_ACCostObjectID;
                documentEntryList.Add(objDocumentEntrysInfo);
            }
            entity.DocumentEntryList.Invalidate(documentEntryList);

            for (int i = 0; i < entity.ARCustomerPaymentTimePaymentList.Count; i++)
            {
                if (entity.ARCustomerPaymentTimePaymentList[i].ARCustomerPaymentTimePaymentAmount <= 0)
                {
                    entity.ARCustomerPaymentTimePaymentList.RemoveAt(i);
                    i--;
                }
            }
            int currentCustomerPaymentID = 0;
            currentCustomerPaymentID = base.ActionSave();
            //Modules.CustomerPaymentTimePayment.CustomerPaymentTimePaymentModule CustomerPaymentModule = (Modules.CustomerPaymentTimePayment.CustomerPaymentTimePaymentModule)BOSApp.ShowModule("CustomerPaymentTimePayment");
            //CustomerPaymentModule.ActionInvalidate(currentCustomerPaymentID);
            if (currentCustomerPaymentID > 0)
                Invalidate(currentCustomerPaymentID);
            return currentCustomerPaymentID;
        }

        /// <summary>
        /// Set the default desc for the payment
        /// </summary>
        private void SetDefaultDesc()
        {
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            //ARCustomersController objCustomersController = new ARCustomersController();
            //ARCustomersInfo customer = (ARCustomersInfo)objCustomersController.GetObjectByID(customerPayment.FK_ARCustomerID);

            ACObjectsController objectController = new ACObjectsController();
            ACObjectsInfo customer = objectController.GetObjectByIDAndType(customerPayment.FK_ACObjectID, customerPayment.ARObjectType);
            if (customer != null)
            {
                CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
                string invoiceNo = string.Empty;
                //foreach (ARCustomerPaymentTimePaymentsInfo invoice in entity.ARCustomerPaymentTimePaymentList)
                //{
                //    invoiceNo += string.Format(" {0} - {1},", invoice, invoice.ARInvoiceDate.ToString("dd/MM/yyyy"));
                //}
                if (!string.IsNullOrEmpty(invoiceNo))
                {
                    invoiceNo = invoiceNo.Substring(0, invoiceNo.Length - 1);
                }
                customerPayment.ARCustomerPaymentDesc = customerPayment.ARCustomerPaymentDesc.Replace("{0}", customer.ACObjectName);
                customerPayment.ARCustomerPaymentDesc = customerPayment.ARCustomerPaymentDesc.Replace("{1}", invoiceNo);
            }
        }

        public override void ActionPrint()
        {
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            if (customerPayment.ARPaymentMethodCombo == PaymentMethod.Cash.ToString())
            {
                if (customerPayment.ARCustomerPaymentStatus != CustomerPaymentStatus.Completed.ToString())
                {
                    if (customerPayment.ARCustomerPaymentType == CustomerPaymentType.AdvancePayment.ToString())
                        PrintReceiptVoucher(CustomerPaymentType.AdvancePayment.ToString());
                    else
                        PrintReceiptVoucher(string.Empty);

                }
            }
            else if (customerPayment.ARPaymentMethodCombo == PaymentMethod.BankTransfer.ToString())
            {
                if (customerPayment.ARCustomerPaymentStatus != CustomerPaymentStatus.Completed.ToString())
                {
                    PrintBankTransferA5();
                }
            }
            else
            {
                if (customerPayment.ARCustomerPaymentStatus != CustomerPaymentStatus.Completed.ToString())
                {
                    PrintDocumentA5();
                }
                else
                {
                    ACDocumentsController objDocumentsController = new ACDocumentsController();
                    ACDocumentsInfo document = objDocumentsController.GetDocumentByTypeAndNo(AccDocumentType.NghiepVuKhac.ToString(),
                                                                                            customerPayment.ARCustomerPaymentNo);
                    if (document != null)
                    {
                        Document.DocumentModule.PrintDocumentA5(document.ACDocumentID);
                    }
                }
            }
        }

        public void PrintDocumentA5()
        {
            RPDocumentA5 report = new RPDocumentA5();
            InitDocumentReportA5(report);
            guiReportPreview viewer = new guiReportPreview(report);
            viewer.Show();
        }

        private void InitDocumentReportA5(RPDocumentA5 report)
        {
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo mainObject = (ARCustomerPaymentsInfo)entity.MainObject;

            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(mainObject.FK_ACObjectID, mainObject.ARObjectType);
            //Set current branch info
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.PageHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;

            ADReportsController objReportsController = new ADReportsController();
            //List<ACDocumentEntrysInfo> entries = objReportsController.GetEntriesByDocumentID(documentID);
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
            ACDocumentEntrysInfo objDocumentEntrysInfo = null;
            ACAccountsController objAccountsController = new ACAccountsController();
            ACAccountsInfo objAccountsInfo = null;
            ARCustomersController objCustomersController = new ARCustomersController();
            ARCustomersInfo objCustomersInfo = null;
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = objEmployeesController.GetObjectByID(mainObject.FK_HREmployeeID) as HREmployeesInfo;
            entity.CustomerPaymentDocumentList.ForEach(o =>
            {
                objDocumentEntrysInfo = new ACDocumentEntrysInfo();
                objDocumentEntrysInfo.ACDocumentNo = mainObject.ARCustomerPaymentNo;
                objDocumentEntrysInfo.ACDocumentDate = mainObject.ARCustomerPaymentDate;
                objDocumentEntrysInfo.ACDocumentEntryDesc = o.ARCustomerPaymentDocumentDesc;
                if (objEmployeesInfo != null)
                    objDocumentEntrysInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
                if (mainObject.ARObjectType == ObjectType.Customer.ToString())
                {
                    objCustomersInfo = objCustomersController.GetObjectByID(mainObject.FK_ACObjectID) as ARCustomersInfo;
                    if (objCustomersInfo != null)
                        objDocumentEntrysInfo.ACObjectContactAddress = objCustomersInfo.ARCustomerContactAddressLine1;
                }
                else
                {
                    if (objObjectsInfo != null)
                        objDocumentEntrysInfo.ACObjectContactAddress = objObjectsInfo.ACObjectContactAddressLine3;
                }

                if (objObjectsInfo != null)
                    objDocumentEntrysInfo.ACObjectName = objObjectsInfo.ACObjectName;
                if (objAccountsInfo != null)
                    objDocumentEntrysInfo.ACDocumentCreditAccount = objAccountsInfo.ACAccountNo;
                objAccountsInfo = objAccountsController.GetObjectByID(o.FK_ACDebitAccountID) as ACAccountsInfo;
                if (objAccountsInfo != null)
                    objDocumentEntrysInfo.ACDocumentDebitAccount = objAccountsInfo.ACAccountNo;
                objDocumentEntrysInfo.ACDocumentEntryAmount = o.ARCustomerPaymentDocumentAmount;
                entries.Add(objDocumentEntrysInfo);
            });
            report.DataSource = entries;

            ACDocumentsInfo objDocumentsInfo = new ACDocumentsInfo();
            objDocumentsInfo.ACDocumentTotalAmount = mainObject.ARCustomerPaymentTotalAmount;
            objDocumentsInfo.FK_GECurrencyID = mainObject.FK_GECurrencyID;

            //XRLabel xr_lblTotalAmount = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xrTableCell19"];
            if (objDocumentsInfo != null)
            {
                XRLabel amountWordTop = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblReadAmount"];
                if (amountWordTop != null)
                    amountWordTop.Text = ConvertAmountToWord.ReadAmount(objDocumentsInfo.ACDocumentTotalAmount.ToString(), objDocumentsInfo.FK_GECurrencyID);
            }
        }

        public void PrintBankTransferA5()
        {
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo mainObject = (ARCustomerPaymentsInfo)entity.MainObject;

            ADReportsController objReportsController = new ADReportsController();
            RPBankTransactionA5 report = new RPBankTransactionA5();

            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(mainObject.FK_ACObjectID, mainObject.ARObjectType);
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            string bankName = objCompanyBanksController.GetObjectNameByID(mainObject.FK_CSCompanyBankID);
            List<ACBankTransactionItemsInfo> bankTransactionItemList = new List<ACBankTransactionItemsInfo>();
            ACBankTransactionItemsInfo objBankTransactionItemsInfo = null;
            ACAccountsController objAccountsController = new ACAccountsController();
            ACAccountsInfo objAccountsInfo = null;
            entity.CustomerPaymentDocumentList.ForEach(o =>
            {
                objBankTransactionItemsInfo = new ACBankTransactionItemsInfo();
                objBankTransactionItemsInfo.ACBankTransactionNo = mainObject.ARCustomerPaymentNo;
                objBankTransactionItemsInfo.ACBankTransactionDate = mainObject.ARCustomerPaymentDate;
                objBankTransactionItemsInfo.ACBankTransactionSenderName = mainObject.ARCustomerPaymentSenderName;
                objBankTransactionItemsInfo.ACBankTransactionReceiverAccount = mainObject.ARCustomerPaymentBankAccount;
                objBankTransactionItemsInfo.ACBankTransactionReceiverBankName = bankName;
                if (objObjectsInfo != null)
                    objBankTransactionItemsInfo.ACObjectName = objObjectsInfo.ACObjectName;
                objBankTransactionItemsInfo.ACBankTransactionItemDesc = o.ARCustomerPaymentDocumentDesc;
                objBankTransactionItemsInfo.ACBankTransactionItemAmount = o.ARCustomerPaymentDocumentAmount;
                objBankTransactionItemsInfo.ACBankTransactionItemExchangeAmount = o.ARCustomerPaymentDocumentExchangeAmount;
                objAccountsInfo = objAccountsController.GetObjectByID(o.FK_ACCreditAccountID) as ACAccountsInfo;
                if (objAccountsInfo != null)
                    objBankTransactionItemsInfo.CreditAccountNo = objAccountsInfo.ACAccountNo;
                objAccountsInfo = objAccountsController.GetObjectByID(o.FK_ACDebitAccountID) as ACAccountsInfo;
                if (objAccountsInfo != null)
                    objBankTransactionItemsInfo.DebitAccountNo = objAccountsInfo.ACAccountNo;
                bankTransactionItemList.Add(objBankTransactionItemsInfo);
            });

            foreach (ACBankTransactionItemsInfo item in bankTransactionItemList)
            {
                item.ACBankTransactionItemDesc += String.Format(" theo HĐ/ĐBH: {0}", item.ACBankTransactionNo);
            }
            report.DataSource = bankTransactionItemList;
            InitBankTransferReport(report);
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRPBankTransactionPath, true);
            reviewer.Show();
        }

        private void InitBankTransferReport(XtraReport report)
        {
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo mainObject = (ARCustomerPaymentsInfo)entity.MainObject;
            //Set current branch
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;

            //Set employee name
            XRLabel employeeNameLabel = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblEmployeeName"];
            HREmployeesController objEmployessController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployessController.GetObjectByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            if (objEmployeesInfo != null)
            {
                employeeNameLabel.Text = objEmployeesInfo.HREmployeeName;
            }
            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            ACBankTransactionsInfo objBankTransactionsInfo = new ACBankTransactionsInfo();
            objBankTransactionsInfo.FK_GECurrencyID = mainObject.FK_GECurrencyID;
            objBankTransactionsInfo.ACBankTransactionTotalAmount = mainObject.ARCustomerPaymentTotalAmount;
            if (objBankTransactionsInfo != null)
            {
                if (objBankTransactionsInfo.ACBankTransactionTotalAmount != 0)
                {
                    XRLabel amountWordTop = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblReadAmount"];
                    if (amountWordTop != null)
                        amountWordTop.Text = ConvertAmountToWord.ReadAmount(
                                                                        objBankTransactionsInfo.ACBankTransactionTotalAmount.ToString(),
                                                                        objBankTransactionsInfo.FK_GECurrencyID);
                }
            }
        }

        public void PrintReceiptVoucher(string customerPaymentType)
        {
            RPReceiptVoucher report = new RPReceiptVoucher();
            //report.LoadLayout(BOSCommon.Constants.Report.DevInvoiceItemReportPath);
            InitReceiptVoucherReport(report);
            if (customerPaymentType == CustomerPaymentType.AdvancePayment.ToString())
            {
                XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel13"];
                if (label != null)
                {
                    label.Visible = true;
                }
            }
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevReceiptVoucherPath, true);
            reviewer.Show();
        }

        private void InitReceiptVoucherReport(XtraReport report)
        {
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo mainObject = (ARCustomerPaymentsInfo)entity.MainObject;

            ADReportsController objReportsController = new ADReportsController();
            GECurrenciesController objCurrencyController = new GECurrenciesController();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(mainObject.FK_ACObjectID, mainObject.ARObjectType);
            ARCustomersController objCustomersController = new ARCustomersController();
            ARCustomersInfo objCustomersInfo = null;
            List<ARReceiptVoucherItemsInfo> receiptVoucherItemList = new List<ARReceiptVoucherItemsInfo>();
            ARReceiptVoucherItemsInfo objReceiptVoucherItemsInfo = null;
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = objEmployeesController.GetObjectByID(mainObject.FK_HREmployeeID) as HREmployeesInfo;
            ACAccountsController objAccountsController = new ACAccountsController();
            ACAccountsInfo objAccountsInfo = null;
            entity.CustomerPaymentDocumentList.ForEach(o =>
            {
                objReceiptVoucherItemsInfo = new ARReceiptVoucherItemsInfo();
                objReceiptVoucherItemsInfo.ARReceiptVoucherNo = mainObject.ARCustomerPaymentNo;
                objReceiptVoucherItemsInfo.ARReceiptVoucherDate = mainObject.ARCustomerPaymentDate;
                if (objObjectsInfo != null)
                    objReceiptVoucherItemsInfo.ACObjectName = objObjectsInfo.ACObjectName;
                if (mainObject.ARObjectType == ObjectType.Customer.ToString())
                {
                    objCustomersInfo = objCustomersController.GetObjectByID(mainObject.FK_ACObjectID) as ARCustomersInfo;
                    if (objCustomersInfo != null)
                        objReceiptVoucherItemsInfo.ACObjectContactAddress = objCustomersInfo.ARCustomerContactAddressLine1;
                }
                else
                {
                    if (objObjectsInfo != null)
                        objReceiptVoucherItemsInfo.ACObjectContactAddress = objObjectsInfo.ACObjectContactAddressLine3;
                }
                if (objEmployeesInfo != null)
                    objReceiptVoucherItemsInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
                objReceiptVoucherItemsInfo.ARReceiptVoucherDesc = mainObject.ARCustomerPaymentDesc;
                objReceiptVoucherItemsInfo.ARReceiptVoucherTotalAmount = mainObject.ARCustomerPaymentTotalAmount;
                objAccountsInfo = objAccountsController.GetObjectByID(o.FK_ACCreditAccountID) as ACAccountsInfo;
                if (objAccountsInfo != null)
                    objReceiptVoucherItemsInfo.ACCreditAccountNo = objAccountsInfo.ACAccountNo;
                objAccountsInfo = objAccountsController.GetObjectByID(o.FK_ACDebitAccountID) as ACAccountsInfo;
                if (objAccountsInfo != null)
                    objReceiptVoucherItemsInfo.ACDebitAccountNo = objAccountsInfo.ACAccountNo;
                receiptVoucherItemList.Add(objReceiptVoucherItemsInfo);
            });
            report.DataSource = receiptVoucherItemList;
            //Set default current branch
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;
            XRLabel taxNumber = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblMST"];
            if (taxNumber != null)
            {
                taxNumber.Text = BOSApp.CurrentCompanyInfo.CSCompanyTaxNumber;
            }
            ARReceiptVouchersController objReceiptVouchersController = new ARReceiptVouchersController();
            ARReceiptVouchersInfo objReceiptVouchersInfo = new ARReceiptVouchersInfo();
            objReceiptVouchersInfo.FK_GECurrencyID = mainObject.FK_GECurrencyID;
            objReceiptVouchersInfo.ARReceiptVoucherTotalAmount = mainObject.ARCustomerPaymentTotalAmount;
            objReceiptVouchersInfo.ARReceiptVoucherExchangeAmount = mainObject.ARCustomerPaymentTotalAmount * mainObject.ARCustomerPaymentExchangeRate;
            GECurrenciesInfo currency = (GECurrenciesInfo)objCurrencyController.GetObjectByID(objReceiptVouchersInfo.FK_GECurrencyID);
            if (currency != null)
                ((RPReceiptVoucher)report).bsGECurrenciesInfo.DataSource = currency;
            int defaultCurrencyID = currency.GECurrencyID;
            if (objReceiptVouchersInfo != null)
            {
                if (objReceiptVouchersInfo.ARReceiptVoucherTotalAmount != 0)
                {
                    XRLabel amountWordTop = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblAmountWordTop"];
                    if (amountWordTop != null)
                    {
                        amountWordTop.Text = "Đã nhận đủ số tiền " + ConvertAmountToWord.ReadAmount(objReceiptVouchersInfo.ARReceiptVoucherTotalAmount.ToString(), defaultCurrencyID);
                    }
                    XRLabel amountWordBottom = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblAmountWordBottom"];
                    if (amountWordBottom != null)
                    {
                        amountWordBottom.Text = amountWordTop.Text;
                    }
                }

                string accountDebitNo = string.Empty;
                string accountCreditNo = string.Empty;
                foreach (ARReceiptVoucherItemsInfo item in receiptVoucherItemList)
                {
                    accountDebitNo += string.Format(" {0},", item.ACDebitAccountNo);
                    accountCreditNo += string.Format(" {0},", item.ACCreditAccountNo);
                }
                if (!string.IsNullOrEmpty(accountDebitNo))
                {
                    XRLabel accountDebitLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblAccountDebitNo"];
                    if (accountDebitLabel != null)
                    {
                        accountDebitLabel.Text = accountDebitNo.Substring(0, accountDebitNo.Length - 1);
                    }
                }
                if (!string.IsNullOrEmpty(accountCreditNo))
                {
                    XRLabel accountCreditLabel = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblAccountCreditNo"];
                    if (accountCreditLabel != null)
                    {
                        accountCreditLabel.Text = accountCreditNo.Substring(0, accountCreditNo.Length - 1);
                    }
                }

                XRPanel exchangeInfoPanel = (XRPanel)report.Bands[BandKind.ReportFooter].Controls["xr_pnlExchangeInfo"];
                if (exchangeInfoPanel != null)
                {
                    if (currency.GECurrencyID != defaultCurrencyID)
                    {
                        exchangeInfoPanel.Visible = true;
                    }
                    else
                    {
                        exchangeInfoPanel.Visible = false;
                    }
                }
            }
        }

        #region Utility functions
        public static ARCustomerPaymentsInfo CreateCustomerPayments(AROpenDocumentsInfo objOpenDocumentsInfo, decimal totalAmount)
        {
            ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = new ARCustomerPaymentsInfo();
            objCustomerPaymentsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objCustomerPaymentsInfo.FK_ARCustomerID = objOpenDocumentsInfo.FK_ARCustomerID;
            objCustomerPaymentsInfo.FK_GECurrencyID = objOpenDocumentsInfo.FK_GECurrencyID;
            objCustomerPaymentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objCustomerPaymentsInfo.AACreatedUser = BOSApp.CurrentUser;
            objCustomerPaymentsInfo.AACreatedDate = DateTime.Now;
            objCustomerPaymentsInfo.ARCustomerPaymentDate = DateTime.Now;
            objCustomerPaymentsInfo.ARCustomerPaymentTotalAmount = totalAmount;
            objCustomerPaymentsInfo.ARCustomerPaymentExchangeRate = objOpenDocumentsInfo.AROpenDocumentExchangeRate;
            objCustomerPaymentsController.CreateObject(objCustomerPaymentsInfo);
            return objCustomerPaymentsInfo;
        }

        public static ARDocumentPaymentsInfo CreateDocumentPayments(
                                                           AROpenDocumentsInfo objOpenDocumentsInfo,
                                                           ARCustomerPaymentsInfo objCustomerPaymentsInfo,
                                                           decimal totalAmount)
        {
            return CustomerPaymentTimePaymentModule.CreateDocumentPayments(objOpenDocumentsInfo, objCustomerPaymentsInfo, totalAmount, 1);
        }

        public static ARDocumentPaymentsInfo CreateDocumentPayments(
                                                            AROpenDocumentsInfo objOpenDocumentsInfo,
                                                            ARCustomerPaymentsInfo objCustomerPaymentsInfo,
                                                            decimal totalAmount,
                                                            decimal exchangeRate)
        {
            ARDocumentPaymentsController objDocumentPaymentsController = new ARDocumentPaymentsController();
            ARDocumentPaymentsInfo objDocumentPaymentsInfo = new ARDocumentPaymentsInfo();
            objDocumentPaymentsInfo.AACreatedUser = BOSApp.CurrentUser;
            objDocumentPaymentsInfo.AACreatedDate = DateTime.Now;
            objDocumentPaymentsInfo.ARDocumentPaymentDate = DateTime.Now;
            objDocumentPaymentsInfo.FK_AROpenDocumentID = objOpenDocumentsInfo.AROpenDocumentID;
            objDocumentPaymentsInfo.FK_ARCustomerPaymentID = objCustomerPaymentsInfo.ARCustomerPaymentID;
            objDocumentPaymentsInfo.ARDocumentPaymentAmount = totalAmount;
            objDocumentPaymentsInfo.ARDocumentPaymentExchangeRate = exchangeRate;
            objDocumentPaymentsController.CreateObject(objDocumentPaymentsInfo);
            return objDocumentPaymentsInfo;
        }
        #endregion

        /// <summary>
        ///  Get all owing invoice
        /// </summary>
        /// <param name="invoiceNo">The invoice no control's BOSTextBox</param>
        /// <param name="searchFromInvoiceDate">The search from invoice date control's BOSDateEdit</param>
        /// <param name="searchToInvoiceDate">The invoice to invoice date control's BOSDateEdit</param>
        /// <param name="chkSelectAllOwingInvoice">The control check select owing invoice</param>
        public void GetAllOwingInvoices(string invoiceNo, DateTime searchFromInvoiceDate, DateTime searchToInvoiceDate, BOSCheckEdit chkSelectAllOwingInvoice)
        {
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)entity.MainObject;
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            //List<ARInvoicesInfo> owingInvoices = objInvoicesController.GetOwingInvoices(objCustomerPaymentsInfo.FK_ARCustomerID, invoiceNo, searchFromInvoiceDate, searchToInvoiceDate);
            List<ARInvoicesInfo> owingInvoices = objInvoicesController.GetOwingInvoicesByUserPermission(objCustomerPaymentsInfo.FK_ARCustomerID, invoiceNo, null, null, null,
                                                                                        searchFromInvoiceDate, searchToInvoiceDate, BOSApp.CurrentUsersInfo.ADUserID,
                                                                                        ModuleName.Invoice, ADDataViewPermissionType.Module);
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
            owingInvoices = owingInvoices.Where(i => i.ARInvoiceBalanceDue > 0).ToList();
            entity.OwingInvoicesList.Invalidate(owingInvoices);
        }

        /// <summary>
        /// Select all owing invoices 
        /// </summary>
        /// <param name="chkSelectAllOwingInvoice">The select all owing invoice check edit control</param>
        public void SelectAllOwingInvoices(BOSCheckEdit chkSelectAllOwingInvoice)
        {
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
            if (chkSelectAllOwingInvoice.Checked == true)
                entity.OwingInvoicesList.ForEach(invoice => invoice.Selected = true);
            else
                entity.OwingInvoicesList.ForEach(invoice => invoice.Selected = false);
            entity.OwingInvoicesList.GridControl?.RefreshDataSource();
        }

        /// <summary>
        /// Called when user changes the payment amount of an invoice
        /// </summary>
        /// <param name="objInvoicesInfo">Info of invoice</param>
        public void ChangeInvoicePaymentAmount(ARInvoicesInfo objInvoicesInfo)
        {
            UpdateTotalAmount();
        }

        /// <summary>
        /// Update total amount of the customer payment
        /// </summary>
        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                UpdateDocumentEntries();

                CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
                ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)entity.MainObject;
                foreach (ARCustomerPaymentTimePaymentsInfo item in entity.ARCustomerPaymentTimePaymentList)
                {
                    item.ARCustomerPaymentTimePaymentExchangeRate = objCustomerPaymentsInfo.ARCustomerPaymentExchangeRate;
                    BOSApp.RoundByCurrency(item, objCustomerPaymentsInfo.FK_GECurrencyID);
                }
                if (objCustomerPaymentsInfo.ARCustomerPaymentType != CustomerPaymentType.AdvancePayment.ToString())
                {
                    objCustomerPaymentsInfo.ARCustomerPaymentTotalAmount = entity.ARCustomerPaymentTimePaymentList.Sum(e => e.ARCustomerPaymentTimePaymentAmount);
                }

                objCustomerPaymentsInfo.ARCustomerPaymentExchangeAmount = objCustomerPaymentsInfo.ARCustomerPaymentTotalAmount * objCustomerPaymentsInfo.ARCustomerPaymentExchangeRate;
                BOSApp.RoundByCurrency(objCustomerPaymentsInfo, objCustomerPaymentsInfo.FK_GECurrencyID);
                entity.UpdateMainObjectBindingSource();
                entity.ARCustomerPaymentTimePaymentList.GridControl?.RefreshDataSource();
            }
        }

        /// <summary>
        /// Delete selected invoice from invoice list
        /// </summary>
        public void DeleteSelectedInvoice()
        {
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
            entity.ARCustomerPaymentTimePaymentList.RemoveSelectedRowObjectFromList();
            UpdateTotalAmount();
        }

        /// <summary>
        /// Called when user wants to change the bank
        /// </summary>
        public void ChangeBank(int bankID)
        {
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            objCustomerPaymentsInfo.FK_CSCompanyBankID = bankID;
            CSCompanyBanksInfo objCompanyBanksInfo = objCompanyBanksController.GetObjectByID(bankID) as CSCompanyBanksInfo;
            if (objCompanyBanksInfo != null)
                objCustomerPaymentsInfo.ARCustomerPaymentBankAccount = objCompanyBanksInfo.CSCompanyBankAccount;
            entity.UpdateMainObjectBindingSource();
            UpdateDocumentEntries();
        }

        /// <summary>
        /// Called when user wants to change the cash fund
        /// </summary>
        public void ChangeCashFund(int cashFundID)
        {
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            objCustomerPaymentsInfo.FK_CSCashFundID = cashFundID;
            UpdateDocumentEntries();
        }

        /// <summary>
        /// Called when the user changes the customer
        /// </summary>
        /// <param name="customerID">Selected customer id</param>
        public void ChangeCustomer(int customerID)
        {
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)entity.MainObject;
            customerPayment.FK_ARCustomerID = customerID;
            if (!Toolbar.IsNullOrNoneAction())
            {
                ARCustomersController objCustomersController = new ARCustomersController();
                ARCustomersInfo customer = (ARCustomersInfo)objCustomersController.GetObjectByID(customerID);
                if (customer != null && customer.FK_ACAccountSaleID > 0)
                {
                    customerPayment.ARCustomerPaymentSenderName = customer.ARCustomerName;
                    entity.CustomerPaymentDocumentList.ForEach(x => x.FK_ACCreditAccountID = customer.FK_ACAccountSaleID);
                    //entity.CustomerPaymentDocumentList.GridControl?.RefreshDataSource();
                }
            }
        }

        /// <summary>
        /// Check whether selected owing invoices is valid
        /// </summary>
        /// <returns>True if valid, otherwise false</returns>
        public bool CheckForValidOwingInvoices()
        {
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)entity.MainObject;
            if (!entity.OwingInvoicesList.Exists(i => i.Selected == true))
            {
                MessageBox.Show(CustomerPaymentLocalizedResources.ChooseOwingInvoiceMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            int customerID = 0;
            ARInvoicesInfo firstOwingInvoice = entity.OwingInvoicesList.Where(i => i.Selected == true).FirstOrDefault();
            if (firstOwingInvoice != null)
            {
                customerID = firstOwingInvoice.FK_ARCustomerID;
            }
            if (customerID > 0 && entity.OwingInvoicesList.Exists(i => i.Selected == true && i.FK_ARCustomerID != customerID))
            {
                MessageBox.Show(CustomerPaymentLocalizedResources.SelectedInvoicesNotSameCustomerMessage,
                            CommonLocalizedResources.MessageBoxDefaultCaption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        #region Accounting
        public override int GetDocumentTypeID()
        {
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            int documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.PhieuThu.ToString());
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            if (objCustomerPaymentsInfo.ARPaymentMethodCombo == PaymentMethod.BankTransfer.ToString())
            {
                documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.NopTienVaoTaiKhoan.ToString());
            }
            else if (objCustomerPaymentsInfo.ARPaymentMethodCombo == PaymentMethod.OwingExchange.ToString())
            {
                documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.NghiepVuKhac.ToString());
            }
            else if (objCustomerPaymentsInfo.ARPaymentMethodCombo == PaymentMethod.CreditCard.ToString())
            {
                documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.NghiepVuKhac.ToString());
            }
            return documentTypeID;
        }

        public override void GenerateAccountingData()
        {
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo mainObject = (ARCustomerPaymentsInfo)entity.MainObject;
            if (mainObject.ARCustomerPaymentFromType == CustomerPaymentFromType.ReceiptVoucher.ToString())
            {
                GenerateAccountingData(new string[] { AccDocumentType.PhieuThu.ToString() });
                List<ACDocumentEntrysInfo> entries = entity.DocumentEntryList.Where(e => e.ACEntryTypeName == AccEntryType.ThuTienKhachHang.ToString()).ToList();
                entity.DocumentEntryList.Invalidate(entries);
            }
            else if (mainObject.ARCustomerPaymentFromType == CustomerPaymentFromType.BankTransfer.ToString())
            {
                GenerateAccountingData(new string[] { AccDocumentType.NopTienVaoTaiKhoan.ToString() });
                List<ACDocumentEntrysInfo> entries = entity.DocumentEntryList.Where(e => e.ACEntryTypeName == AccEntryType.ThuTienKhachHang.ToString()).ToList();
                entity.DocumentEntryList.Invalidate(entries);
            }
            else if (mainObject.ARCustomerPaymentFromType == CustomerPaymentFromType.OwingExchange.ToString())
            {
                GenerateAccountingData(new string[] { AccDocumentType.NghiepVuKhac.ToString() });
                //entity.DocumentEntryList.Invalidate(new List<ACDocumentEntrysInfo>());
            }
            else if (mainObject.ARCustomerPaymentFromType == CustomerPaymentFromType.AdvancePayment.ToString())
            {
                GenerateAccountingData(new string[] { AccDocumentType.PhieuThu.ToString() });
                List<ACDocumentEntrysInfo> entries = entity.DocumentEntryList.Where(e => e.ACEntryTypeName == AccEntryType.ThuTienKhachHang.ToString()).ToList();
                entity.DocumentEntryList.Invalidate(entries);
            }

        }

        private void GeneratePaymentDocumentData()
        {
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo mainObject = (ARCustomerPaymentsInfo)entity.MainObject;
            if (entity.CustomerPaymentDocumentList.Count == 0)
            {
                entity.DocumentEntryList.ForEach(o =>
                {
                    ARCustomerPaymentDocumentsInfo objCustomerPaymentDocumentsInfo = new ARCustomerPaymentDocumentsInfo()
                    {
                        FK_ARCustomerPaymentID = mainObject.ARCustomerPaymentID,
                        FK_ACEntryTypeID = o.FK_ACEntryTypeID,
                        FK_ACDebitAccountID = o.FK_ACDebitAccountID,
                        FK_ACCreditAccountID = o.FK_ACCreditAccountID,
                        FK_ACCostObjectID = o.FK_ACCostObjectID,
                        ARCustomerPaymentDocumentDesc = o.ACDocumentEntryDesc,
                        ARCustomerPaymentDocumentAmount = o.ACDocumentEntryAmount,
                        ARCustomerPaymentDocumentExchangeAmount = o.ACDocumentEntryExchangeAmount,
                        FK_ACUnfinishedConstructionCostID = o.FK_ACUnfinishedConstructionCostID,
                        ACEntryTypeName = o.ACEntryTypeName,
                    };
                    entity.CustomerPaymentDocumentList.Add(objCustomerPaymentDocumentsInfo);
                });
                entity.CustomerPaymentDocumentList.GridControl?.RefreshDataSource();
            }
        }

        protected override void UpdateDocumentEntries()
        {
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)entity.MainObject;

            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = (ACObjectsInfo)objObjectsController.GetObjectByIDAndType(objCustomerPaymentsInfo.FK_ACObjectID, objCustomerPaymentsInfo.ARObjectType);

            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            GECurrenciesInfo objCurrenciesInfo = (GECurrenciesInfo)objCurrenciesController.GetObjectByID(objCustomerPaymentsInfo.FK_GECurrencyID);

            #region Tinh chenh lech ti gia
            ACEntryTypesController objEntryTypesController = new ACEntryTypesController();
            ACAccountsController objAccountsController = new ACAccountsController();
            decimal tienlai = 0;
            decimal tienlo = 0;
            decimal tienConLai = 0;
            decimal tienConLaiQD = 0;
            decimal tyGiaTB = 0;
            decimal tyGiaTT = 0;
            if (objCustomerPaymentsInfo.ARCustomerPaymentType != CustomerPaymentType.AdvancePayment.ToString())
            {
                if (objCurrenciesInfo != null)
                {
                    if (objCurrenciesInfo.GECurrencyNo != CurrencyNo.VND.ToString()
                        || objCustomerPaymentsInfo.ARCustomerPaymentExchangeRate != 1)
                    {
                        ARInvoicesController objInvoicesController = new ARInvoicesController();
                        List<ARCustomerPaymentTimePaymentsInfo> invoiceList = entity.ARCustomerPaymentTimePaymentList.Where(a => a.FK_ARInvoiceID > 0).ToList();
                        ARInvoiceTransactionsController objSOPTIDController = new ARInvoiceTransactionsController();
                        List<ARInvoiceTransactionsInfo> sOPaymentTimeInvoiceDetails = null;
                        ARInvoiceTransactionsInfo objSOPaymentTimeInvoiceDetailsInfo = null;
                        if (invoiceList != null && invoiceList.Count > 0)
                        {
                            ARInvoiceTransactionsController ptiController = new ARInvoiceTransactionsController();
                            invoiceList.ForEach(a =>
                            {

                                sOPaymentTimeInvoiceDetails = objSOPTIDController.GetClearingInfoByInvoiceID(a.FK_ARInvoiceID, a.ARCustomerPaymentTimePaymentInvoiceNo, objCustomerPaymentsInfo.FK_ACObjectID, objCustomerPaymentsInfo.ARObjectType);
                                objSOPaymentTimeInvoiceDetailsInfo = objSOPTIDController.GetInvoiceInfoByInvoiceID(a.FK_ARInvoiceID, a.ARCustomerPaymentTimePaymentInvoiceNo, objCustomerPaymentsInfo.FK_ACObjectID, objCustomerPaymentsInfo.ARObjectType) as ARInvoiceTransactionsInfo;

                                if (objSOPaymentTimeInvoiceDetailsInfo != null)
                                {
                                    tienConLai = objSOPaymentTimeInvoiceDetailsInfo.ARInvoiceAmount - sOPaymentTimeInvoiceDetails.Sum(o => o.ARInvoicePaymentAmount);
                                    tienConLaiQD = objSOPaymentTimeInvoiceDetailsInfo.ARInvoiceAmountExchange
                                        - sOPaymentTimeInvoiceDetails.Sum(o => o.ARInvoicePaymentAmountExchange);
                                    if (tienConLai > 0)
                                    {
                                        tyGiaTB = tienConLaiQD / tienConLai;
                                    }
                                    tyGiaTT = Math.Min(tyGiaTB, objCustomerPaymentsInfo.ARCustomerPaymentExchangeRate);
                                }

                                if (tyGiaTB > objCustomerPaymentsInfo.ARCustomerPaymentExchangeRate)
                                {
                                    tienlo += a.ARCustomerPaymentTimePaymentAmount * (tyGiaTB - objCustomerPaymentsInfo.ARCustomerPaymentExchangeRate);
                                }
                                if (tyGiaTB < objCustomerPaymentsInfo.ARCustomerPaymentExchangeRate)
                                {
                                    tienlai += a.ARCustomerPaymentTimePaymentAmount * (objCustomerPaymentsInfo.ARCustomerPaymentExchangeRate - tyGiaTB);
                                }
                            });
                            if (tienlai > 0)
                            {
                                ACEntryTypesInfo objEntryTypes = (ACEntryTypesInfo)objEntryTypesController.GetObjectByName(AccEntryName.ChenhLechLai);
                                if (objEntryTypes != null)
                                {
                                    ARCustomerPaymentDocumentsInfo objCustomerPaymentDocumentsInfo = new ARCustomerPaymentDocumentsInfo();
                                    objCustomerPaymentDocumentsInfo.FK_ACEntryTypeID = objEntryTypes.ACEntryTypeID;
                                    objCustomerPaymentDocumentsInfo.ACEntryTypeName = objEntryTypes.ACEntryTypeName;
                                    objCustomerPaymentDocumentsInfo.ARCustomerPaymentDocumentDesc = objEntryTypes.ACEntryTypeDesc;
                                    ARCustomerPaymentDocumentsInfo paymentDocument = entity.CustomerPaymentDocumentList.FirstOrDefault(a => a.ACEntryTypeName == AccEntryName.ChenhLechLai);
                                    if (paymentDocument == null)
                                    {
                                        entity.CustomerPaymentDocumentList.Add(objCustomerPaymentDocumentsInfo);
                                    }
                                }
                            }
                            else
                            {
                                ARCustomerPaymentDocumentsInfo paymentDocument = entity.CustomerPaymentDocumentList.FirstOrDefault(a => a.ACEntryTypeName == AccEntryName.ChenhLechLai);
                                if (paymentDocument != null)
                                {
                                    entity.CustomerPaymentDocumentList.Remove(paymentDocument);
                                }
                            }
                            if (tienlo > 0)
                            {
                                ACEntryTypesInfo objEntryTypes = (ACEntryTypesInfo)objEntryTypesController.GetObjectByName(AccEntryName.ChenhLechLo);
                                if (objEntryTypes != null)
                                {
                                    ARCustomerPaymentDocumentsInfo objCustomerPaymentDocumentsInfo = new ARCustomerPaymentDocumentsInfo();
                                    objCustomerPaymentDocumentsInfo.FK_ACEntryTypeID = objEntryTypes.ACEntryTypeID;
                                    objCustomerPaymentDocumentsInfo.ACEntryTypeName = objEntryTypes.ACEntryTypeName;
                                    objCustomerPaymentDocumentsInfo.ARCustomerPaymentDocumentDesc = objEntryTypes.ACEntryTypeDesc;
                                    ARCustomerPaymentDocumentsInfo paymentDocument = entity.CustomerPaymentDocumentList.FirstOrDefault(a => a.ACEntryTypeName == AccEntryName.ChenhLechLo);
                                    if (paymentDocument == null)
                                    {
                                        entity.CustomerPaymentDocumentList.Add(objCustomerPaymentDocumentsInfo);
                                    }
                                }
                            }
                            else
                            {
                                ARCustomerPaymentDocumentsInfo paymentDocument = entity.CustomerPaymentDocumentList.FirstOrDefault(a => a.ACEntryTypeName == AccEntryName.ChenhLechLo);
                                if (paymentDocument != null)
                                {
                                    entity.CustomerPaymentDocumentList.Remove(paymentDocument);
                                }
                            }
                        }
                    }
                }
            }
            #endregion

            CSCashFundsController objCashFundsController = new CSCashFundsController();
            CSCashFundsInfo objCashFundsInfo = (CSCashFundsInfo)objCashFundsController.GetObjectByID(objCustomerPaymentsInfo.FK_CSCashFundID);

            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(objCustomerPaymentsInfo.FK_CSCompanyBankID);
            entity.CustomerPaymentDocumentList.ForEach(o =>
            {
                //Update Credit Account ID
                if (objObjectsInfo != null && objObjectsInfo.FK_ACAccountSaleID > 0)
                {
                    o.FK_ACCreditAccountID = objObjectsInfo.FK_ACAccountSaleID;
                }
                //Update Debit Account ID 
                if (objCustomerPaymentsInfo.ARCustomerPaymentFromType == CustomerPaymentFromType.ReceiptVoucher.ToString())
                {
                    if (objCashFundsInfo != null && objCashFundsInfo.FK_ACAcountID > 0)
                    {
                        o.FK_ACDebitAccountID = objCashFundsInfo.FK_ACAcountID;
                    }
                }
                else if (objCustomerPaymentsInfo.ARCustomerPaymentFromType == CustomerPaymentFromType.BankTransfer.ToString())
                {
                    if (objCompanyBanksInfo != null && objCompanyBanksInfo.FK_ACAcountID > 0)
                    {
                        o.FK_ACDebitAccountID = objCompanyBanksInfo.FK_ACAcountID;
                    }
                }
                if (o.ACEntryTypeName == AccEntryType.ThuTienKhachHang.ToString())
                {
                    if (entity.ARCustomerPaymentTimePaymentList.Count > 0)
                    {
                        o.ARCustomerPaymentDocumentAmount = entity.ARCustomerPaymentTimePaymentList.Sum(i => i.ARCustomerPaymentTimePaymentAmount);
                    }
                    if (objCustomerPaymentsInfo.ARCustomerPaymentType == CustomerPaymentType.AdvancePayment.ToString())
                    {
                        o.ARCustomerPaymentDocumentAmount = objCustomerPaymentsInfo.ARCustomerPaymentTotalAmount;
                    }
                    BOSApp.RoundByCurrency(o, "ARCustomerPaymentDocumentAmount", objCustomerPaymentsInfo.FK_GECurrencyID);
                    o.ARCustomerPaymentDocumentExchangeAmount = o.ARCustomerPaymentDocumentAmount * objCustomerPaymentsInfo.ARCustomerPaymentExchangeRate;
                    if (tienlo > 0 || tienlai > 0)
                    {
                        o.ARCustomerPaymentDocumentExchangeAmount = tyGiaTT * o.ARCustomerPaymentDocumentAmount;
                    }

                    BOSApp.RoundByCurrency(o, "ARCustomerPaymentDocumentExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                }
                ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                ACDocumentEntrysInfo defaultDocumentEntrysInfo;
                if (o.ACEntryTypeName == AccEntryType.ChenhLechLai.ToString())
                {
                    defaultDocumentEntrysInfo = objDocumentEntrysController.GetDefaultDocumentEntryByEntryAndDocumentType(AccDocumentType.ChenhLechTyGia.ToString(), AccEntryType.ChenhLechLai.ToString());
                    if (defaultDocumentEntrysInfo != null)
                    {
                        o.FK_ACCreditAccountID = defaultDocumentEntrysInfo.FK_ACCreditAccountID;
                    }
                    o.ARCustomerPaymentDocumentAmount = 0;
                    o.ARCustomerPaymentDocumentExchangeAmount = tienlai;
                }
                if (o.ACEntryTypeName == AccEntryType.ChenhLechLo.ToString())
                {
                    defaultDocumentEntrysInfo = objDocumentEntrysController.GetDefaultDocumentEntryByEntryAndDocumentType(AccDocumentType.ChenhLechTyGia.ToString(), AccEntryType.ChenhLechLo.ToString());
                    if (defaultDocumentEntrysInfo != null)
                    {
                        o.FK_ACDebitAccountID = defaultDocumentEntrysInfo.FK_ACDebitAccountID;
                    }
                    o.ARCustomerPaymentDocumentAmount = 0;
                    o.ARCustomerPaymentDocumentExchangeAmount = tienlo;
                }
            });
            entity.CustomerPaymentDocumentList.GridControl?.RefreshDataSource();
        }
        #endregion

        //TNDLoc [ADD][23/07/2015][Issue sale payment],START
        public void GetSaleOrderForPayment()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                return;
            }

            ARCustomerPaymentTimePaymentsController objPaymentsController = new ARCustomerPaymentTimePaymentsController();

            //Thu tiền từ Đề nghị thu tiền
            //List<ARCustomerPaymentTimePaymentsInfo> paymentList = objPaymentsController.GetCustomerPaymentTimePaymentsFromPaymentProposalItems();

            //Thu tiền ko qua Đề nghị thu tiền
            List<ARCustomerPaymentTimePaymentsInfo> paymentList = objPaymentsController.GetCustomerPaymentTimePaymentsForPaymentNoneProposal(BOSApp.CurrentCompanyInfo.FK_BRBranchID);

            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)entity.MainObject;

            ARSaleOrdersController objSaleOrdersController = new ARSaleOrdersController();
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            if (objCustomerPaymentsInfo.FK_ACObjectID > 0)
            {
                paymentList = paymentList.Where(p => p.FK_ACObjectID == objCustomerPaymentsInfo.FK_ACObjectID
                                                && p.ARObjectType == objCustomerPaymentsInfo.ARObjectType).ToList();
            }
            guiFind<ARCustomerPaymentTimePaymentsInfo> guiFind = new guiFind<ARCustomerPaymentTimePaymentsInfo>(TableName.ARCustomerPaymentTimePaymentTableName, paymentList, this, true);
            guiFind.Module = this;
        Stamp:
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                if (guiFind.SelectedObjects.Count > 0)
                {
                    if (guiFind.SelectedObjects.Count > 1)
                    {
                        if (guiFind.SelectedObjects.FirstOrDefault(s => s.FK_ACObjectID != guiFind.SelectedObjects[0].FK_ACObjectID
                                                                        || s.ARObjectType != guiFind.SelectedObjects[0].ARObjectType) != null)
                        {
                            MessageBox.Show(CustomerPaymentTimePaymentLocalizedResources.NotMatchCustomer,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                            goto Stamp;
                        }
                        if (guiFind.SelectedObjects.FirstOrDefault(s => s.FK_PMProjectID != guiFind.SelectedObjects[0].FK_PMProjectID) != null)
                        {
                            MessageBox.Show(CustomerPaymentTimePaymentLocalizedResources.NotMatchProject,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                            goto Stamp;
                        }
                        if (guiFind.SelectedObjects.FirstOrDefault(s => s.FK_GECurrencyID != guiFind.SelectedObjects[0].FK_GECurrencyID) != null)
                        {
                            MessageBox.Show(ClearingDebtLocalizedResources.ErrorCurrency,
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                            goto Stamp;
                        }
                    }
                    if (objCustomerPaymentsInfo.FK_ACObjectID == 0)
                    {
                        objCustomerPaymentsInfo.FK_ACObjectID = guiFind.SelectedObjects[0].FK_ACObjectID;
                        objCustomerPaymentsInfo.ARObjectType = guiFind.SelectedObjects[0].ARObjectType;
                        objCustomerPaymentsInfo.ACObjectAccessKey = objCustomerPaymentsInfo.FK_ACObjectID + ";" + objCustomerPaymentsInfo.ARObjectType;
                        objCustomerPaymentsInfo.ARCustomerPaymentSenderName = guiFind.SelectedObjects[0].ACObjectName;
                    }
                    objCustomerPaymentsInfo.FK_GECurrencyID = guiFind.SelectedObjects[0].FK_GECurrencyID;
                    objCustomerPaymentsInfo.FK_PMProjectID = guiFind.SelectedObjects[0].FK_PMProjectID;
                    decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateTransferByCurrencyAndDate(objCustomerPaymentsInfo.FK_GECurrencyID, objCustomerPaymentsInfo.ARCustomerPaymentDate);
                    objCustomerPaymentsInfo.ARCustomerPaymentExchangeRate = dCurrencyExchangeRate > 0 ? dCurrencyExchangeRate : 1;

                    //TKChinh Add PO No
                    ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)objSaleOrdersController.GetObjectByID(guiFind.SelectedObjects[0].FK_ARSaleOrderID);
                    if (objSaleOrdersInfo != null)
                    {
                        objCustomerPaymentsInfo.ARCustomerPaymentPONo = objSaleOrdersInfo.ARSaleOrderPONo;
                        objCustomerPaymentsInfo.ARSaleOrderSaleAgreement = objSaleOrdersInfo.ARSaleOrderSaleAgreement;
                        objCustomerPaymentsInfo.FK_ARSaleContractID = objSaleOrdersInfo.FK_ARSaleContractID;
                    }
                    objCustomerPaymentsInfo.ARCustomerPaymentProject = String.Join(", ", guiFind.SelectedObjects.Select(o => o.ARCustomerPaymentProject).Distinct().ToArray());
                    objCustomerPaymentsInfo.ARCustomerPaymentSaleContract = String.Join(", ", guiFind.SelectedObjects.Select(o => o.ARCustomerPaymentSaleContract).Distinct().ToArray());
                    objCustomerPaymentsInfo.FK_ACSegmentID = guiFind.SelectedObjects[0].FK_ACSegmentID;
                    objCustomerPaymentsInfo.FK_PMProjectID = guiFind.SelectedObjects[0].FK_PMProjectID;

                    decimal percentDeposit = 0;
                    foreach (ARCustomerPaymentTimePaymentsInfo item in guiFind.SelectedObjects)
                    {

                        //TKChinh Add [05/07/2016] 
                        int Count = objPaymentsController.GetCountInvoice(item.FK_ARInvoiceID);
                        if (Count == 0)
                        {
                            ARSaleOrderPaymentTimesController objSaleOrderPaymentTimesController = new ARSaleOrderPaymentTimesController();
                            percentDeposit = objSaleOrderPaymentTimesController.GetPercentDepositPerOneInvoice(item.FK_ARSaleOrderID);
                            //ARInvoicesController objInvoicesController = new ARInvoicesController();
                            ARInvoicesInfo objInvoicesInfo = (ARInvoicesInfo)objInvoicesController.GetObjectByID(item.FK_ARInvoiceID);
                            if (objInvoicesInfo != null)
                            {
                                item.ARCustomerPaymentTimePaymentDepositPerInvoice = objInvoicesInfo.ARInvoiceTotalAmount * percentDeposit;
                                BOSApp.RoundByCurrency(item, objInvoicesInfo.FK_GECurrencyID);
                            }
                        }
                        else
                        {
                            item.ARCustomerPaymentTimePaymentDepositPerInvoice = 0;
                        }
                        item.ARCustomerPaymentTimePaymentAmount = item.ARCustomerPaymentTimePaymentRemainAmount;
                        item.ARInvoiceExchangeRate = item.ARCustomerPaymentTimePaymentExchangeRate;
                        BOSApp.RoundByCurrency(item, objCustomerPaymentsInfo.FK_GECurrencyID);
                    }
                    foreach (ARCustomerPaymentTimePaymentsInfo item in guiFind.SelectedObjects)
                    {
                        item.ARCustomerPaymentTimePaymentPercent = item.ARCustomerPaymentTimePaymentRemainAmount <= 0 ? 0 : (item.ARCustomerPaymentTimePaymentAmount / (item.ARCustomerPaymentTimePaymentRemainAmount)) * 100;
                    }

                    if (objCustomerPaymentsInfo.ARCustomerPaymentID > 0)
                    {
                        entity.ARCustomerPaymentTimePaymentList.AddRange(guiFind.SelectedObjects.OrderBy(p => p.ARCustomerPaymentTimePaymentDate).ToList());
                    }
                    else
                    {
                        entity.ARCustomerPaymentTimePaymentList.Invalidate(guiFind.SelectedObjects.OrderBy(p => p.ARCustomerPaymentTimePaymentDate).ToList());
                    }
                    entity.ARCustomerPaymentTimePaymentList.GridControl?.RefreshDataSource();
                    entity.UpdateMainObjectBindingSource();
                }

                UpdateTotalAmount();
            }
        }

        public void ChangePaymentAmount()
        {
            UpdateTotalAmount();
        }

        public bool ChangeProposalPaymentAmount(ARCustomerPaymentTimePaymentsInfo objPaymentProposalsInfo, bool isFromPercent)
        {
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;

            if (entity.ARCustomerPaymentTimePaymentList[entity.ARCustomerPaymentTimePaymentList.CurrentIndex].ARCustomerPaymentTimePaymentPercent > 100
                && entity.ARCustomerPaymentTimePaymentList[entity.ARCustomerPaymentTimePaymentList.CurrentIndex].FK_ARInvoiceID > 0)
            {
                MessageBox.Show(CustomerPaymentTimePaymentLocalizedResources.PercentCheckMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (entity.ARCustomerPaymentTimePaymentList[entity.ARCustomerPaymentTimePaymentList.CurrentIndex].ARCustomerPaymentTimePaymentPercent > 120
                && entity.ARCustomerPaymentTimePaymentList[entity.ARCustomerPaymentTimePaymentList.CurrentIndex].FK_ARSaleOrderID > 0)
            {
                MessageBox.Show(CustomerPaymentTimePaymentLocalizedResources.PercentCheckMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }    
            if (entity.ARCustomerPaymentTimePaymentList[entity.ARCustomerPaymentTimePaymentList.CurrentIndex].ARCustomerPaymentTimePaymentBankFeeAmount > entity.ARCustomerPaymentTimePaymentList[entity.ARCustomerPaymentTimePaymentList.CurrentIndex].ARCustomerPaymentTimePaymentAmount)
            {
                MessageBox.Show(CustomerPaymentTimePaymentLocalizedResources.ErrorBankFeeAmount, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (isFromPercent)
                {
                    entity.ARCustomerPaymentTimePaymentList[entity.ARCustomerPaymentTimePaymentList.CurrentIndex].ARCustomerPaymentTimePaymentAmount
                        = (entity.ARCustomerPaymentTimePaymentList[entity.ARCustomerPaymentTimePaymentList.CurrentIndex].ARCustomerPaymentTimePaymentPercent / 100) *
                        (entity.ARCustomerPaymentTimePaymentList[entity.ARCustomerPaymentTimePaymentList.CurrentIndex].ARCustomerPaymentTimePaymentRemainAmount);
                    entity.ARCustomerPaymentTimePaymentList.GridControl?.RefreshDataSource();
                }
                else
                {
                    decimal paymentPercent = 0;
                    paymentPercent = (entity.ARCustomerPaymentTimePaymentList[entity.ARCustomerPaymentTimePaymentList.CurrentIndex].ARCustomerPaymentTimePaymentAmount /
                            (entity.ARCustomerPaymentTimePaymentList[entity.ARCustomerPaymentTimePaymentList.CurrentIndex].ARCustomerPaymentTimePaymentRemainAmount)) * 100;
                    if (paymentPercent > 120 && entity.ARCustomerPaymentTimePaymentList[entity.ARCustomerPaymentTimePaymentList.CurrentIndex].FK_ARSaleOrderID > 0)
                    {
                        MessageBox.Show(CustomerPaymentTimePaymentLocalizedResources.PercentCheckMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else if (paymentPercent > 100 && entity.ARCustomerPaymentTimePaymentList[entity.ARCustomerPaymentTimePaymentList.CurrentIndex].FK_ARInvoiceID > 0)
                    {
                        MessageBox.Show(CustomerPaymentTimePaymentLocalizedResources.PercentCheckMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        entity.ARCustomerPaymentTimePaymentList[entity.ARCustomerPaymentTimePaymentList.CurrentIndex].ARCustomerPaymentTimePaymentPercent = paymentPercent;
                        entity.ARCustomerPaymentTimePaymentList.GridControl?.RefreshDataSource();
                    }
                }
                UpdateTotalAmount();
                return true;
            }
        }

        public void UpdateTotalAmountByCurrency(int currencieID)
        {
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo mainObject = (ARCustomerPaymentsInfo)entity.MainObject;
            mainObject.FK_GECurrencyID = currencieID;

            GECurrencyExchangeRatesController objCurrencyExchangeRatesController = new GECurrencyExchangeRatesController();
            decimal exchangeRateValue = objCurrencyExchangeRatesController.GetCurrencyExchangeRateTransferByCurrencyIDAndDate(currencieID, mainObject.ARCustomerPaymentDate);
            if (exchangeRateValue > 0)
            {
                mainObject.ARCustomerPaymentExchangeRate = exchangeRateValue;
            }
            UpdateTotalAmount();
            entity.UpdateMainObjectBindingSource();
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            CustomerPaymentsInfosTabControl.TabPages[0].PageEnabled = true;
            CustomerPaymentTotalAmountTextBox.Properties.ReadOnly = true;
            ARCustomerPaymentsInfo mainObject = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton("CancelDocument", false);
            ParentScreen.SetEnableOfToolbarButton("CancelComplete", false);
            if (mainObject.ARCustomerPaymentType == CustomerPaymentType.AdvancePayment.ToString())
            {
                CustomerPaymentsInfosTabControl.TabPages[0].PageEnabled = false;
                CustomerPaymentTotalAmountTextBox.Properties.ReadOnly = false;
            }
            if (mainObject.ARCustomerPaymentID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPrint, false);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPrint, true);
                ParentScreen.SetEnableOfToolbarButton("CancelDocument", true);
                if (mainObject.ARCustomerPaymentStatus == CustomerPaymentStatus.Completed.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                       mainObject.ARCustomerPaymentPostedStatus != PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                        mainObject.ARCustomerPaymentPostedStatus == PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton("CancelDocument", false);
                    ParentScreen.SetEnableOfToolbarButton("CancelComplete", true);
                }
                else if (mainObject.ARCustomerPaymentStatus == CustomerPaymentStatus.Canceled.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton("CancelDocument", false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPrint, false);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
                }
                if(mainObject.ARPaymentMethodCombo == PaymentMethod.Cash.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPrint, true);
                }
                else
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPrint, false);
                }
            }
            EnableControls();
        }

        public void ChangeCustomerPaymentTotalAmount()
        {
            UpdateTotalAmount();
        }

        public void ChangeObject(string objectAccessKey)
        {
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            objCustomerPaymentsInfo.ACObjectAccessKey = objectAccessKey;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            if (objObjectsInfo != null)
            {
                if (objObjectsInfo.ACObjectType == ObjectType.Customer.ToString())
                    objCustomerPaymentsInfo.FK_ARCustomerID = objObjectsInfo.ACObjectID;
                objCustomerPaymentsInfo.FK_ACObjectID = objObjectsInfo.ACObjectID;
                objCustomerPaymentsInfo.ARObjectType = objObjectsInfo.ACObjectType;
                objCustomerPaymentsInfo.ARCustomerPaymentSenderName = objObjectsInfo.ACObjectName;
                objCustomerPaymentsInfo.FK_PMProjectID = 0;
                entity.CustomerPaymentDocumentList.ForEach(o => o.FK_ACCreditAccountID = objObjectsInfo.FK_ACAccountSaleID);
            }
            else
            {
                objCustomerPaymentsInfo.FK_ACObjectID = 0;
                objCustomerPaymentsInfo.ARObjectType = string.Empty;
                objCustomerPaymentsInfo.ARCustomerPaymentSenderName = string.Empty;
                objCustomerPaymentsInfo.FK_ARCustomerID = 0;
            }
        }

        public override bool ActionComplete()
        {
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo mainObject = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            GenerateAccountingData();
            UpdateTotalAmount();
            bool isComplete = base.ActionComplete();
            if (isComplete)
            {
                ARCustomerPaymentTimePaymentsController objCustomerPaymentTimePaymentsController = new ARCustomerPaymentTimePaymentsController();
                entity.ARCustomerPaymentTimePaymentList.ForEach(o =>
                {
                    o.ARCustomerPaymentTimePaymentPaidAmount += o.ARCustomerPaymentTimePaymentAmount;
                    o.ARCustomerPaymentTimePaymentRemainAmount -= o.ARCustomerPaymentTimePaymentAmount;
                    objCustomerPaymentTimePaymentsController.UpdateObject(o);
                });
                entity.ARCustomerPaymentTimePaymentList.GridControl?.RefreshDataSource();
                entity.UpdateReferPaymentData(false);
            }
            entity.SetPropertyChangeEventLock(true);
            return isComplete;
        }

        public void InvalidatePMProjectIDDatasorce()
        {
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo mainobject = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            PMProjectsController objProjectsController = new PMProjectsController();
            List<PMProjectsInfo> projectList = objProjectsController.GetAllProjectForLookupByAcobjectIDAndType(mainobject.FK_ACObjectID, mainobject.ARObjectType);
            if (projectList.Count() > 0)
            {
                PMProjectsInfo objProjectDummyInfo = new PMProjectsInfo();
                projectList.Insert(0, objProjectDummyInfo);
            }
            ProjectIDLookupEditControl.Properties.DataSource = projectList;
        }

        public void ActionPosted()
        {
            if (!CheckLock()) return;
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
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
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo mainObject = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ARCustomerPaymentPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ARCustomerPaymentID, PostedTransactionStatus.UnPosted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.UnPostedTransactions(this.Name, mainObject.ARCustomerPaymentID, ModulePostingType.Accounting, ModulePostingType.InvoiceTrans);
            InvalidateToolbar();

        }

        public override void ModuleAfterCompleted()
        {
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo mainObject = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ARCustomerPaymentPostedStatus = PostedTransactionStatus.Posted.ToString();
            entity.UpdateMainObject();
            GLHelper.PostedTransactions(this.Name, mainObject.ARCustomerPaymentID, ModulePostingType.Accounting, ModulePostingType.InvoiceTrans);
            entity.SetPropertyChangeEventLock(true);
            base.ModuleAfterCompleted();
        }

        public void ActionCancelDocument()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                if (!CheckLock()) return;
                CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
                ARCustomerPaymentsInfo mainObject = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
                if (mainObject.ARCustomerPaymentPostedStatus == PostedTransactionStatus.Posted.ToString())
                    ActionUnPosted();
                entity.SetPropertyChangeEventLock(false);
                mainObject.ARCustomerPaymentStatus = CustomerPaymentStatus.Canceled.ToString();
                entity.UpdateMainObject();
                entity.SetPropertyChangeEventLock(true);
                ARPaymentProposalItemsController ppiController = new ARPaymentProposalItemsController();
                ppiController.UpdatePaidAmountByCustomerPaymentID(mainObject.ARCustomerPaymentID);
                InvalidateToolbar();
            }
        }

        public override bool ActionCancelComplete()
        {
            if (!CheckLock()) return false;
            CustomerPaymentTimePaymentEntities entity = (CustomerPaymentTimePaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo mainObject = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            if (mainObject.ARCustomerPaymentStatus != CustomerPaymentStatus.Completed.ToString())
                return false;

            ACDocumentsController objDocumentsController = new ACDocumentsController();
            List<ACDocumentsInfo> documentsList = objDocumentsController.GetRelativeDocumentListByCustomerPaymentID(mainObject.ARCustomerPaymentID);

            if (documentsList.Count() > 0)
            {
                MessageBox.Show(string.Format("Đã cấn trừ cho chứng từ sau: \n-{0}", string.Join("\n-", documentsList.Select(o => o.ACDocumentNo).ToArray())), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            base.ActionCancelComplete();

            ARCustomerPaymentTimePaymentsController objCustomerPaymentTimePaymentsController = new ARCustomerPaymentTimePaymentsController();
            entity.ARCustomerPaymentTimePaymentList.ForEach(o =>
            {
                o.ARCustomerPaymentTimePaymentPaidAmount -= o.ARCustomerPaymentTimePaymentAmount;
                o.ARCustomerPaymentTimePaymentRemainAmount += o.ARCustomerPaymentTimePaymentAmount;
                objCustomerPaymentTimePaymentsController.UpdateObject(o);
            });
            entity.ARCustomerPaymentTimePaymentList.GridControl?.RefreshDataSource();
            ActionUnPosted();
            entity.UpdateReferPaymentData(true);
            return true;
        }
    }
}
