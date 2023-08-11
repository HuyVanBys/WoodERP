using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP102 : ReportForm
    {
        //Main List
        List<ACDocumentsInfo> DocumentList = new List<ACDocumentsInfo>();
        //SubList
        #region Nợ/Debit
        List<ACDocumentsInfo> SupplierDebitList = new List<ACDocumentsInfo>();
        List<ACDocumentsInfo> CustomerDebitList = new List<ACDocumentsInfo>();
        List<ACDocumentsInfo> CustomerPromotionDebitList = new List<ACDocumentsInfo>();
        List<ACDocumentsInfo> BankDebitList = new List<ACDocumentsInfo>();
        #endregion

        #region Có/Credit
        List<ACDocumentsInfo> SupplierCreditList = new List<ACDocumentsInfo>();
        List<ACDocumentsInfo> SupplierPromotionCreditList = new List<ACDocumentsInfo>();
        List<ACDocumentsInfo> SupplierDiscountCreditList = new List<ACDocumentsInfo>();
        List<ACDocumentsInfo> CustomerCreditList = new List<ACDocumentsInfo>();
        #endregion

        #region Tiền & Ngân hàng/Bank
        List<ACDocumentsInfo> InBankAmountList = new List<ACDocumentsInfo>();
        List<ACDocumentsInfo> CashAmountList = new List<ACDocumentsInfo>();
        #endregion

        List<ARCustomersInfo> CustomerList = new List<ARCustomersInfo>();
        List<APSuppliersInfo> SupplierList = new List<APSuppliersInfo>();
        List<CSCompanyBanksInfo> BankList = new List<CSCompanyBanksInfo>();
        // List<ICProductsInfo> ProductList = new List<ICProductsInfo>();

        #region Amount
        public decimal SupplierDebitAmount = 0;
        public decimal SupplierCreditAmount = 0;
        public decimal SupplierPromotionCreditAmount = 0;
        public decimal SupplierDiscountCreditAmount = 0;
        public decimal CustomerDebitAmount = 0;
        public decimal CustomerCreditAmount = 0;
        public decimal CustomerPromotionDebitAmount = 0;
        public decimal BankDebitAmount = 0;
        public decimal InBankAmount = 0;
        public decimal CashAmount = 0;
        #endregion
        public RP102()
        {
            InitializeComponent();

            ARCustomersController objCustomersController = new ARCustomersController();
            CustomerList = objCustomersController.GetAllCustomer();

            APSuppliersController objSuppliersController = new APSuppliersController();
            SupplierList = objSuppliersController.GetAllSuppliers();

            CSCompanyBanksController objBannksController = new CSCompanyBanksController();
            BankList = objBannksController.GetAllBanks();

            //ICProductsController objProductsController = new ICProductsController();
            //ProductList = objProductsController.GetProductAll();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ShowReportData();
        }

        public ACDocumentsInfo ConvertToDocument(string documentNo, string documentDesc, decimal documentTotalAmount)
        {
            ACDocumentsInfo objDocumentsInfo = new ACDocumentsInfo();
            objDocumentsInfo.ACDocumentNo = documentNo;
            objDocumentsInfo.ACDocumentDesc = documentDesc;
            objDocumentsInfo.ACDocumentTotalAmount = documentTotalAmount;
            return objDocumentsInfo;
        }

        private void ShowReportData()
        {
            BOSProgressBar.Start("Đang khởi tạo báo cáo");
            DateTime fromDate = fld_dteSearchFromARInvoiceDate.DateTime;
            DateTime toDate = fld_dteSearchToARInvoiceDate.DateTime;
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            DocumentList = new List<ACDocumentsInfo>();
            #region NCC
            BOSProgressBar.Close();
            BOSProgressBar.Start("Đang lấy dữ liệu Nhà cung cấp");
            decimal supplierDebitAmount = 0;
            decimal supplierCreditAmount = 0;
            decimal supplierPromotionCreditAmount = 0;
            decimal supplierDiscountCreditAmount = 0;
            SupplierDebitList = new List<ACDocumentsInfo>();
            SupplierCreditList = new List<ACDocumentsInfo>();
            SupplierPromotionCreditList = new List<ACDocumentsInfo>();
            SupplierDiscountCreditList = new List<ACDocumentsInfo>();
            foreach (APSuppliersInfo supplier in SupplierList)
            {

                decimal endBalance = objDocumentEntrysController.GetAccountBalance(
                                                                                  AccAccount.Acc331,
                                                                                  toDate,
                                                                                  supplier.APSupplierID,
                                                                                  ObjectType.Supplier.ToString(),
                                                                                  0,
                                                                                  null,
                                                                                  0,
                                                                                  0);
                #region Debit
                if (endBalance > 0)
                {
                    ACDocumentsInfo objSupplierDebitDocsInfo = new ACDocumentsInfo();
                    objSupplierDebitDocsInfo = ConvertToDocument(supplier.APSupplierNo, supplier.APSupplierName, endBalance);
                    SupplierDebitList.Add(objSupplierDebitDocsInfo);

                    supplierDebitAmount += objSupplierDebitDocsInfo.ACDocumentTotalAmount;
                }
                #endregion
                #region Credit
                if (endBalance < 0)
                {
                    ACDocumentsInfo objSupplierCreditDocsInfo = new ACDocumentsInfo();
                    objSupplierCreditDocsInfo = ConvertToDocument(supplier.APSupplierNo, supplier.APSupplierName, -endBalance);
                    SupplierCreditList.Add(objSupplierCreditDocsInfo);

                    supplierCreditAmount += objSupplierCreditDocsInfo.ACDocumentTotalAmount;
                }

                #endregion


            }
            ACDocumentsInfo objSupplierDebitMainDocsInfo = new ACDocumentsInfo();
            objSupplierDebitMainDocsInfo = ConvertToDocument(SupplierString, DebitTypeString, supplierDebitAmount);
            DocumentList.Add(objSupplierDebitMainDocsInfo);

            ACDocumentsInfo objSupplierCreditMainDocsInfo = new ACDocumentsInfo();
            objSupplierCreditMainDocsInfo = ConvertToDocument(SupplierString, CreditTypeString, supplierCreditAmount);
            DocumentList.Add(objSupplierCreditMainDocsInfo);


            #endregion

            #region KH
            BOSProgressBar.Close();
            BOSProgressBar.Start("Đang lấy dữ liệu Khách hàng");
            decimal customerDebitAmount = 0;
            decimal customerCreditAmount = 0;
            decimal customerPromotionDebitAmount = 0;
            CustomerDebitList = new List<ACDocumentsInfo>();
            CustomerCreditList = new List<ACDocumentsInfo>();
            CustomerPromotionDebitList = new List<ACDocumentsInfo>();

            foreach (ARCustomersInfo customer in CustomerList)
            {
                decimal endBalance = objDocumentEntrysController.GetAccountBalance(
                                                                               AccAccount.Acc131,
                                                                               toDate,
                                                                               customer.ARCustomerID,
                                                                               ObjectType.Customer.ToString(),
                                                                               0,
                                                                               null,
                                                                               0,
                                                                               0);
                #region Debit
                if (endBalance < 0)
                {
                    ACDocumentsInfo objCustomerDebitDocsInfo = new ACDocumentsInfo();
                    objCustomerDebitDocsInfo = ConvertToDocument(customer.ARCustomerNo, customer.ARCustomerName, -endBalance);
                    CustomerDebitList.Add(objCustomerDebitDocsInfo);

                    customerDebitAmount += -endBalance;
                }

                #endregion
                #region Credit
                if (endBalance > 0)
                {
                    ACDocumentsInfo objCustomerCreditDocsInfo = new ACDocumentsInfo();
                    objCustomerCreditDocsInfo = ConvertToDocument(customer.ARCustomerNo, customer.ARCustomerName, endBalance);
                    CustomerCreditList.Add(objCustomerCreditDocsInfo);

                    customerCreditAmount += endBalance;
                }
                #endregion

            }

            ACDocumentsInfo objCustomerDebitMainDocsInfo = new ACDocumentsInfo();
            objCustomerDebitMainDocsInfo = ConvertToDocument(CustomerString, DebitTypeString, customerDebitAmount);
            DocumentList.Add(objCustomerDebitMainDocsInfo);

            ACDocumentsInfo objCustomerCreditMainDocsInfo = new ACDocumentsInfo();
            objCustomerCreditMainDocsInfo = ConvertToDocument(CustomerString, CreditTypeString, customerCreditAmount);
            DocumentList.Add(objCustomerCreditMainDocsInfo);


            #endregion

            #region Tiền & Ngân hàng
            BOSProgressBar.Close();
            BOSProgressBar.Start("Đang lấy dữ liệu Tiền & Ngân hàng");
            // Vay ngân hàng
            BankDebitList = new List<ACDocumentsInfo>();
            decimal bankDebitAmount = 0;
            // Tiền trong ngân hàng
            InBankAmountList = new List<ACDocumentsInfo>();
            decimal inBankAmount = 0;
            // Tiền mặt
            CashAmountList = new List<ACDocumentsInfo>();
            decimal cashAmount = 0;
            foreach (CSCompanyBanksInfo bank in BankList)
            {
                #region Vay ngân hàng
                decimal endBlance3411 = objDocumentEntrysController.GetAccountBalance(
                                                                                  AccAccount.Acc341,
                                                                                  toDate,
                                                                                   0,
                                                                                  null,
                                                                                  0,
                                                                                  bank.CSCompanyBankID,
                                                                                  0,
                                                                                  0);
                if (endBlance3411 > 0)
                {
                    ACDocumentsInfo objBankDebitDocsInfo = new ACDocumentsInfo();
                    objBankDebitDocsInfo = ConvertToDocument("", bank.CSCompanyBankName, endBlance3411);
                    BankDebitList.Add(objBankDebitDocsInfo);
                    bankDebitAmount += endBlance3411;
                }
                #endregion

                #region Tiền trong ngân hàng
                decimal endBlance112 = objDocumentEntrysController.GetAccountBalance(
                                                                                  AccAccount.Acc112,
                                                                                  toDate,
                                                                                   0,
                                                                                  null,
                                                                                  0,
                                                                                  bank.CSCompanyBankID,
                                                                                  0,
                                                                                  0);
                if (endBlance112 > 0)
                {
                    ACDocumentsInfo objInBankAmountDocsInfo = new ACDocumentsInfo();
                    objInBankAmountDocsInfo = ConvertToDocument("", bank.CSCompanyBankName, endBlance112);
                    InBankAmountList.Add(objInBankAmountDocsInfo);
                    inBankAmount += endBlance112;
                }
                #endregion


            }
            #region Tiền mặt
            decimal endBlance111 = objDocumentEntrysController.GetAccountBalance(
                                                                            AccAccount.Acc111,
                                                                            toDate,
                                                                             0,
                                                                            null,
                                                                            0,
                                                                           0,
                                                                            0,
                                                                            0);
            if (endBlance111 > 0)
            {
                ACDocumentsInfo objCashAmountDocsInfo = new ACDocumentsInfo();
                objCashAmountDocsInfo = ConvertToDocument("", ReportLocalizedResources.CashAmountString, endBlance111);
                CashAmountList.Add(objCashAmountDocsInfo);
                cashAmount += endBlance111;
            }
            #endregion

            //Vay ngân hàng
            ACDocumentsInfo objBankDebitMainDocsInfo = new ACDocumentsInfo();
            objBankDebitMainDocsInfo = ConvertToDocument(BankDebitString, DebitTypeString, bankDebitAmount);
            DocumentList.Add(objBankDebitMainDocsInfo);
            //Tiền trong ngân hàng
            ACDocumentsInfo objInBankAmountMainDocsInfo = new ACDocumentsInfo();
            objInBankAmountMainDocsInfo = ConvertToDocument(InBankAmountString, BankTypeString, inBankAmount);
            DocumentList.Add(objInBankAmountMainDocsInfo);
            //Tiền mặt
            ACDocumentsInfo objCashAmountMainDocsInfo = new ACDocumentsInfo();
            objCashAmountMainDocsInfo = ConvertToDocument(CashAmountString, BankTypeString, cashAmount);
            DocumentList.Add(objCashAmountMainDocsInfo);
            #endregion

            #region set Amount
            SupplierDebitAmount = supplierDebitAmount;
            SupplierCreditAmount = supplierCreditAmount;
            SupplierPromotionCreditAmount = supplierPromotionCreditAmount;
            SupplierDiscountCreditAmount = supplierDiscountCreditAmount;
            CustomerDebitAmount = customerDebitAmount;
            CustomerCreditAmount = customerCreditAmount;
            CustomerPromotionDebitAmount = customerPromotionDebitAmount;
            BankDebitAmount = bankDebitAmount;
            InBankAmount = inBankAmount;
            CashAmount = cashAmount;
            #endregion

            RP143ACDocuments.DataSource = DocumentList;
            //Set From Date, To Date
            fld_lblFromdateTodate.Text = string.Format("{0} {1} {2} {3}",
                ReportLocalizedResources.FromDateTitle, fld_dteSearchFromARInvoiceDate.Text,
                ReportLocalizedResources.ToDateTitle, fld_dteSearchToARInvoiceDate.Text);
            BOSProgressBar.Close();
        }


        #region Constant
        public string DebitTypeString = ReportLocalizedResources.DebitTypeString;
        public string SupplierString = ReportLocalizedResources.SupplierString;
        public string CreditTypeString = ReportLocalizedResources.CreditTypeString;
        public string CustomerString = ReportLocalizedResources.CustomerString;
        public string BankDebitString = ReportLocalizedResources.BankDebitString;
        public string InBankAmountString = ReportLocalizedResources.InBankAmountString;
        public string BankTypeString = ReportLocalizedResources.BankTypeString;
        public string CashAmountString = ReportLocalizedResources.CashAmountString;
        public string CustomerPromotionString = ReportLocalizedResources.CustomerPromotionString;
        public string SupplierPromotionString = ReportLocalizedResources.SupplierPromotionString;
        public string SupplierDiscountString = ReportLocalizedResources.SupplierDiscountString;
        #endregion
        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void RP001_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromARInvoiceDate.EditValue = DateTime.Now;
            fld_dteSearchToARInvoiceDate.EditValue = DateTime.Now;

        }


        private void SetDefaultCurrentBranchAndTitle(XtraReport report, int branchID)
        {
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchName = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchName"];
            branchName.Text += string.Format(" {0}", objBranchsController.GetObjectNameByID(branchID));
            XRLabel datetTime = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            datetTime.Text = string.Format(" {0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromARInvoiceDate.Text,
                                                                           ReportLocalizedResources.ToDateTitle, fld_dteSearchToARInvoiceDate.Text);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];

            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {

            GridView gridView = null;

            gridView = (GridView)RP143ACDocuments.MainView;

            if (gridView != null)
            {
                ExportToXls(gridView);
            }
        }

        public void ShowDetails(int currentIndex)
        {
            ACDocumentsInfo objCurrentSelectedDocsInfo = new ACDocumentsInfo();
            objCurrentSelectedDocsInfo = (ACDocumentsInfo)RP143ACDocuments.MainView.GetRow(currentIndex);

            if (objCurrentSelectedDocsInfo != null)
            {
                string titleString = string.Empty;
                List<ACDocumentsInfo> selectedList = new List<ACDocumentsInfo>();
                if (objCurrentSelectedDocsInfo.ACDocumentNo == CustomerString)
                {
                    if (objCurrentSelectedDocsInfo.ACDocumentDesc == DebitTypeString)
                    {
                        selectedList = CustomerDebitList;
                        titleString = DebitTypeString + " - " + CustomerString;
                    }
                    else if (objCurrentSelectedDocsInfo.ACDocumentDesc == CreditTypeString)
                    {
                        selectedList = CustomerCreditList;
                        titleString = CreditTypeString + " - " + CustomerString;
                    }
                }
                else if (objCurrentSelectedDocsInfo.ACDocumentNo == SupplierString)
                {
                    if (objCurrentSelectedDocsInfo.ACDocumentDesc == DebitTypeString)
                    {
                        selectedList = SupplierDebitList;
                        titleString = DebitTypeString + " - " + SupplierString;
                    }
                    else if (objCurrentSelectedDocsInfo.ACDocumentDesc == CreditTypeString)
                    {
                        selectedList = SupplierCreditList;
                        titleString = CreditTypeString + " - " + SupplierString;
                    }
                }
                else if (objCurrentSelectedDocsInfo.ACDocumentNo == BankDebitString)
                {
                    selectedList = BankDebitList;
                    titleString = DebitTypeString + " - " + BankDebitString;
                }
                else if (objCurrentSelectedDocsInfo.ACDocumentNo == InBankAmountString)
                {
                    selectedList = InBankAmountList;
                    titleString = BankTypeString + " - " + InBankAmountString;
                }
                else if (objCurrentSelectedDocsInfo.ACDocumentNo == CashAmountString)
                {
                    selectedList = CashAmountList;
                    titleString = BankTypeString + " - " + CashAmountString;
                }
                else if (objCurrentSelectedDocsInfo.ACDocumentNo == CustomerPromotionString)
                {
                    selectedList = CustomerPromotionDebitList;
                    titleString = DebitTypeString + " - " + CustomerPromotionString;
                }
                else if (objCurrentSelectedDocsInfo.ACDocumentNo == SupplierPromotionString)
                {
                    selectedList = SupplierPromotionCreditList;
                    titleString = CreditTypeString + " - " + SupplierPromotionString;
                }
                else if (objCurrentSelectedDocsInfo.ACDocumentNo == SupplierDiscountString)
                {
                    selectedList = SupplierDiscountCreditList;
                    titleString = CreditTypeString + " - " + SupplierDiscountString;
                }
                RP102Item rp = new RP102Item(selectedList);
                rp.Module = this.Module;
                rp.Text = titleString;
                rp.Show();
            }
        }



        public decimal GetFinalTotalAmount()
        {
            decimal TotalAmount = 0;

            TotalAmount = ((InBankAmount + CashAmount) + (CustomerCreditAmount + SupplierCreditAmount))
                - (SupplierDebitAmount + CustomerDebitAmount + BankDebitAmount);
            return TotalAmount;
        }
    }
}