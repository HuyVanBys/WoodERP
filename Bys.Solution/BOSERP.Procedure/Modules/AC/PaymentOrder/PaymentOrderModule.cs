using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Utilities;
using BOSLib;
using BOSReport;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BOSERP.Modules.PaymentOrder
{
    public class PaymentOrderModule : BaseTransactionModule
    {
        #region Constant
        public const string ListAccountBankLookUpEditControlName = "fld_lkeFK_ACListAccountBankID";
        public const string BankTransactionItemsGridControlName = "fld_dgcACBankTransactionItems";
        #endregion

        #region Public Properties
        public int DocumentTypeID { get; set; }
        #endregion
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        public BOSLookupEdit SearchBranchLookupEditControl = null;
        public BOSLookupEdit ListAccountBankLookUpEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        public const string CSCompanyBankLookupEditControlName = "fld_lkeFK_CSCompanyBankID";
        public BOSLookupEdit CSCompanyBankLookupEditControl;
        public PaymentOrderItemGridControl BankTransactionItemsGridControl;

        #region Constructor
        public PaymentOrderModule()
        {
            Name = ModuleName.PaymentOrder;
            CurrentModuleEntity = new PaymentOrderEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCurrentModuleDataViewPermission();
            ListAccountBankLookUpEditControl = (BOSLookupEdit)Controls[ListAccountBankLookUpEditControlName];
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            CSCompanyBankLookupEditControl = (BOSLookupEdit)Controls[PaymentOrderModule.CSCompanyBankLookupEditControlName];
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            CSCompanyBankLookupEditControl.Properties.DataSource = objCompanyBanksController.GetListCompanyBanksByBranchID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);

            BankTransactionItemsGridControl = (PaymentOrderItemGridControl)Controls[BankTransactionItemsGridControlName];
        }
        #endregion

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

        #region Overrides
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACBankTransactionsInfo searchObject = (ACBankTransactionsInfo)CurrentModuleEntity.SearchObject;
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);
            DataSet ds;
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objBankTransactionsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = ds = objBankTransactionsController.GetBankTransactionList(
                                                                       searchObject.ACBankTransactionNo,
                                                                       BranchList,
                                                                       objObjectsInfo.ACObjectID,
                                                                       objObjectsInfo.ACObjectType,
                                                                       BankTransactionType.PaymentOrder.ToString(),
                                                                       searchObject.FK_HREmployeeID,
                                                                       searchObject.BankTransactionDateFrom,
                                                                       searchObject.BankTransactionDateTo);
                }
            }
            else
            {
                ds = objBankTransactionsController.GetBankTransactionListByBranchID(
                                                                       searchObject.ACBankTransactionNo,
                                                                       objObjectsInfo.ACObjectID,
                                                                       objObjectsInfo.ACObjectType,
                                                                       BankTransactionType.PaymentOrder.ToString(),
                                                                       searchObject.FK_HREmployeeID,
                                                                       searchObject.BankTransactionDateFrom,
                                                                       searchObject.BankTransactionDateTo,
                                                                       searchObject.FK_BRBranchID);
            }
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
            return ds;
        }

        public override int ActionSave()
        {
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            ACBankTransactionsInfo paymentOrder = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            if (string.IsNullOrEmpty(paymentOrder.ACObjectAccessKey) && paymentOrder.ACBankTransactionCreateFrom != BankTransactionCreateFrom.LoanReceipt.ToString())
            {
                MessageBox.Show("Vui lòng chọn đối tượng.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            if (paymentOrder.FK_CSCompanyBankID <= 0)
            {
                MessageBox.Show("Vui lòng chọn ngân hàng.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }

            if (paymentOrder.ACBankTransactionCreateFrom == BankTransactionCreateFrom.LoanReceipt.ToString())
            {
                if (!IsValidAmountLoanReceiptPaymentPlan())
                    return 0;
            }

            bool allowSave = true;
            if (paymentOrder.FK_ACLoanReceiptID == 0)
            {
                foreach (ACBankTransactionItemsInfo item in entity.BankTransactionItemList)
                {
                    ACAccountsController objAccountsController = new ACAccountsController();
                    List<ACAccountsInfo> accountsList = (List<ACAccountsInfo>)objAccountsController.IsAccountOrChildOfAccount(item.FK_ACDebitAccountID, AccAccount.Acc341.ToString());
                    if (accountsList != null && accountsList.Count > 0)
                    {
                        allowSave = false;
                    }
                }
            }
            if (allowSave == false)
            {
                MessageBox.Show("Không được chọn tài khoản 341 khi tạo mới thông thường.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            if (entity.BankTransactionItemList != null && entity.BankTransactionItemList.Count > 0
                && entity.BankTransactionItemList.Where(x => x.ACBankTransactionItemAmount > 0 && (x.FK_ACCreditAccountID == 0 || x.FK_ACDebitAccountID == 0)).ToList().Count > 0)
            {
                BOSApp.ShowMessage("Vui lòng chọn đủ tài khoản nợ/ có dưới lưới!");
                return 0;
            }
            entity.BankTransactionItemList.EndCurrentEdit();
            if (entity.BankTransactionItemList.Count() > 0)
            {
                paymentOrder.ACBankTransactionReference = entity.BankTransactionItemList.GroupBy(x => x.ACBankTransactionItemReference).Aggregate(
                    new StringBuilder(),
                    (current, next) => current.Append(current.Length == 0 ? "" : ", ").Append(next.FirstOrDefault().ACBankTransactionItemReference))
                .ToString();
            }
            UpdateTotalAmount();
            return base.ActionSave();
        }

        public bool IsValidAmountLoanReceiptPaymentPlan()
        {
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            ACBankTransactionsInfo paymentOrder = (ACBankTransactionsInfo)entity.MainObject;
            ACLoanReceiptPaymentPlansController objLoanReceiptPaymentPlansController = new ACLoanReceiptPaymentPlansController();
            ACLoanReceiptPaymentPlansInfo objLoanReceiptPaymentPlansInfo = (ACLoanReceiptPaymentPlansInfo)objLoanReceiptPaymentPlansController.GetObjectByID(paymentOrder.FK_ACLoanReceiptPaymentPlanID);
            if (objLoanReceiptPaymentPlansInfo != null)
            {
                ACEntryTypesController objEntryTypesController = new ACEntryTypesController();
                ACEntryTypesInfo objNoGopEntryTypesInfo = (ACEntryTypesInfo)objEntryTypesController.GetObjectByName(AccEntryName.TraTienNoGop);
                ACEntryTypesInfo objLaiVayEntryTypesInfo = (ACEntryTypesInfo)objEntryTypesController.GetObjectByName(AccEntryName.TraTienLaiVay);
                int noGopEntryTypeID = objNoGopEntryTypesInfo != null ? objNoGopEntryTypesInfo.ACEntryTypeID : 0;
                int laiVayEntryTypeID = objLaiVayEntryTypesInfo != null ? objLaiVayEntryTypesInfo.ACEntryTypeID : 0;
                decimal amount = entity.BankTransactionItemList.Where(o1 => o1.FK_ACEntryTypeID > 0
                                                                            && (o1.FK_ACEntryTypeID == noGopEntryTypeID
                                                                            || o1.FK_ACEntryTypeID == laiVayEntryTypeID))
                                                               .Sum(o1 => o1.ACBankTransactionItemAmount);
                if (amount > objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanPayment - objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActualRootPayment - objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActialProfitsPayment)
                {
                    MessageBox.Show("Tổng tiền nợ gốc, lãi vay không lớn hơn số tiền nợ gốc kế hoạch còn lại của khế ước.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        public void PrintCoupons()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                PrintPaymentOrder(Toolbar.CurrentObjectID);
            }
        }
        public void PrintTransfersMoney()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                PrintTransfersMoneyPaymentOrder(Toolbar.CurrentObjectID);
            }
        }
        public void PrintPaPerPayment()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                PrintPaPerPaymentOrder(Toolbar.CurrentObjectID);
            }
        }
        
        /// <summary>
        /// Print a payment order
        /// </summary>
        /// <param name="paymentOrderID">Payment order id</param>
        public static void PrintPaymentOrder(int paymentOrderID)
        {
            ADReportsController objReportsController = new ADReportsController();
            XtraReport report = new RPPaymentOrder();
            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            ACBankTransactionsInfo paymentOrder = (ACBankTransactionsInfo)objBankTransactionsController.GetBankTransactionByID(paymentOrderID);
            if (paymentOrder != null)
            {
                if (paymentOrder.CSCompanyBankCode.StartsWith(Bank.ABB))
                {
                    report = new RPPaymentOrder();
                    List<ACBankTransactionItemsInfo> bankTransactionItemList = objReportsController.GetBankTransactionItemList(paymentOrderID);
                    report.DataSource = bankTransactionItemList;
                    InitPaymentOrderReport(report, paymentOrderID);
                }
                else if (paymentOrder.CSCompanyBankCode.StartsWith(Bank.ACB))
                {
                    report = new RPPaymentOrderACB();
                    List<ACBankTransactionItemsInfo> bankTransactionItemList = objReportsController.GetBankTransactionItemList(paymentOrderID);
                    report.DataSource = bankTransactionItemList;
                    InitPaymentOrderReport(report, paymentOrderID);
                }
                else if (paymentOrder.CSCompanyBankCode.StartsWith(Bank.VCB))
                {
                    report = new RPPaymentOrderVCB();
                    List<ACBankTransactionItemsInfo> bankTransactionItemList = objReportsController.GetBankTransactionItemList(paymentOrderID);
                    report.DataSource = bankTransactionItemList;
                    InitPaymentOrderReportVCB(report, paymentOrderID);
                }
                else if (paymentOrder.CSCompanyBankCode.StartsWith(Bank.NN) || paymentOrder.CSCompanyBankCode.StartsWith(Bank.VBA))
                {
                    report = new RPPaymentOrderAGRI2();
                    List<ACBankTransactionItemsInfo> bankTransactionItemList = objReportsController.GetBankTransactionItemList(paymentOrderID);
                    report.DataSource = bankTransactionItemList;
                    InitPaymentOrderReportAGRI1(report, paymentOrderID);
                }
                else
                {
                    List<ACBankTransactionItemsInfo> bankTransactionItemList = objReportsController.GetBankTransactionItemList(paymentOrderID);
                    report.DataSource = bankTransactionItemList;
                    InitPaymentOrderReport(report, paymentOrderID);
                }
            }
            //List<ACBankTransactionItemsInfo> bankTransactionItemList = objReportsController.GetBankTransactionItemList(paymentOrderID);
            //report.DataSource = bankTransactionItemList;
            //InitPaymentOrderReport(report, paymentOrderID);
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRPPaymentOrderPath, true);
            reviewer.Show();
        }

        public static void PrintTransfersMoneyPaymentOrder(int paymentOrderID)
        {
            ADReportsController objReportsController = new ADReportsController();
            XtraReport report = new RPPaymentOrder();
            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            ACBankTransactionsInfo paymentOrder = (ACBankTransactionsInfo)objBankTransactionsController.GetBankTransactionByID(paymentOrderID);
            if (paymentOrder != null)
            {
                if (paymentOrder.CSCompanyBankCode.StartsWith(Bank.VCB) || paymentOrder.CSCompanyBankCode.StartsWith(Bank.BFTVVNVX028))
                {
                    report = new RP_PaymentOrderVCB();
                    List<ACBankTransactionItemsInfo> bankTransactionItemList = objReportsController.GetBankTransactionItemList(paymentOrderID);
                    report.DataSource = bankTransactionItemList;
                    InitPaymentOrderReportVCBTranfer(report, paymentOrderID);
                }
                else if (paymentOrder.CSCompanyBankCode.StartsWith(Bank.NN) || paymentOrder.CSCompanyBankCode.StartsWith(Bank.VBAAVNVX809))
                {
                    report = new RP_PaymentOrderAGB();
                    List<ACBankTransactionItemsInfo> bankTransactionItemList = objReportsController.GetBankTransactionItemList(paymentOrderID);
                    report.DataSource = bankTransactionItemList;
                    InitPaymentOrderReportAGBTranfer(report, paymentOrderID);
                }
            }
            //List<ACBankTransactionItemsInfo> bankTransactionItemList = objReportsController.GetBankTransactionItemList(paymentOrderID);
            //report.DataSource = bankTransactionItemList;
            //InitPaymentOrderReport(report, paymentOrderID);
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRPPaymentOrderPath, true);
            reviewer.Show();
        }

        public static void PrintPaPerPaymentOrder(int paymentOrderID)
        {
            ADReportsController objReportsController = new ADReportsController();
            XtraReport report = new RP_PaPerPayment();
            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            ACBankTransactionsInfo paymentOrder = (ACBankTransactionsInfo)objBankTransactionsController.GetBankTransactionByID(paymentOrderID);
            if (paymentOrder != null)
            {
                List<ACBankTransactionItemsInfo> bankTransactionItemList = objReportsController.GetBankTransactionItemList(paymentOrderID);
                report.DataSource = bankTransactionItemList;
                InitPaymentOrderReportPaPer(report, paymentOrderID);
            }
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRPPaymentOrderPath, true);
            reviewer.Show();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Called when user wants to change the bank
        /// </summary>
        /// <param name="companyBankID">The company bank ID.</param>
        public void ChangeBank(int companyBankID)
        {
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)entity.MainObject;
            objBankTransactionsInfo.FK_CSCompanyBankID = companyBankID;
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(companyBankID);
            if (objCompanyBanksInfo != null)
            {
                objBankTransactionsInfo.ACBankTransactionSenderBankName = objCompanyBanksInfo.CSCompanyBankName;
                objBankTransactionsInfo.ACBankTransactionSenderAccount = objCompanyBanksInfo.CSCompanyBankAccount;
                if (objCompanyBanksInfo.FK_ACAcountID > 0)
                {
                    entity.BankTransactionItemList.ForEach(x => x.FK_ACCreditAccountID = objCompanyBanksInfo.FK_ACAcountID);
                    entity.BankTransactionItemList.GridControl.RefreshDataSource();
                }
                CurrentModuleEntity.UpdateMainObjectBindingSource();
            }
        }

        /// <summary>
        /// Called when the user changes object
        /// </summary>
        /// <param name="objectAccessKey">Object access key</param>
        public void ChangeObject(string objectAccessKey)
        {
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            ACBankTransactionsInfo paymentOrder = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            paymentOrder.ACObjectAccessKey = objectAccessKey;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            if (objObjectsInfo != null)
            {
                paymentOrder.ACBankTransactionReceiverName = objObjectsInfo.ACObjectName;
                paymentOrder.ACBankTransactionReceiverContactAddress = objObjectsInfo.ACObjectContactAddress;
                paymentOrder.FK_ACObjectID = objObjectsInfo.ACObjectID;
                paymentOrder.ACObjectType = objObjectsInfo.ACObjectType;
                if (objObjectsInfo.ACObjectType == ObjectType.Supplier.ToString())
                {
                    APSuppliersController objSuppliersController = new APSuppliersController();
                    APSuppliersInfo supplier = (APSuppliersInfo)objSuppliersController.GetObjectByID(objObjectsInfo.ACObjectID);
                    if (supplier != null)
                    {
                        paymentOrder.ACBankTransactionReceiverBankName = supplier.APSupplierBankName;
                        paymentOrder.ACBankTransactionReceiverAccount = supplier.APSupplierBankAccount1;
                        paymentOrder.ACBankTransactionReceiverBankCode = supplier.APSupplierBankCode;

                        //if (supplier.APSupplierBankBeneficiary != string.Empty)
                        //{
                        //    paymentOrder.ACBankTransactionReceiverName = supplier.APSupplierBankBeneficiary;
                        //    paymentOrder.ACBankTransactionReceiverBankName = supplier.APSupplierBankBranch;
                        //}
                    }
                }
                else if (objObjectsInfo.ACObjectType == ObjectType.Customer.ToString())
                {
                    ARCustomersController objCustomersController = new ARCustomersController();
                    ARCustomersInfo customer = (ARCustomersInfo)objCustomersController.GetObjectByID(objObjectsInfo.ACObjectID);
                    if (customer != null)
                    {
                        paymentOrder.ACBankTransactionReceiverBankName = customer.ARCustomerBankName;
                        paymentOrder.ACBankTransactionReceiverAccount = customer.ARCustomerBankAccount1;
                    }
                }
                foreach (ACBankTransactionItemsInfo item in entity.BankTransactionItemList)
                {
                    item.ACObjectAccessKey = paymentOrder.ACObjectAccessKey;
                    item.FK_ACObjectID = objObjectsInfo.ACObjectID;
                    item.ACObjectType = objObjectsInfo.ACObjectType;
                    item.ACObjectName = objObjectsInfo.ACObjectName;
                    item.ACBankTransactionItemTaxNumber = objObjectsInfo.ACObjectTaxNumber;
                    if (item.FK_ACDebitAccountID <= 0 || paymentOrder.ACBankTransactionCreateFrom == BankTransactionCreateFrom.Normal.ToString())
                    {
                        item.FK_ACDebitAccountID = objObjectsInfo.FK_ACAccountPurchaseID;
                    }
                }
                CurrentModuleEntity.UpdateMainObjectBindingSource();
                entity.BankTransactionItemList.GridControl.RefreshDataSource();
            }
        }

        /// <summary>
        /// Updates the total amount.
        /// </summary>
        public void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
                ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)entity.MainObject;
                objBankTransactionsInfo.ACBankTransactionTotalAmount = 0;
                objBankTransactionsInfo.ACBankTransactionExchangeAmount = 0;
                foreach (ACBankTransactionItemsInfo item in entity.BankTransactionItemList)
                {
                    BOSApp.RoundByCurrency(item, "ACBankTransactionItemAmount", objBankTransactionsInfo.FK_GECurrencyID);
                    BOSApp.RoundByCurrency(item, "ACBankTransactionItemExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);

                    objBankTransactionsInfo.ACBankTransactionTotalAmount += item.ACBankTransactionItemAmount;
                    objBankTransactionsInfo.ACBankTransactionExchangeAmount += item.ACBankTransactionItemExchangeAmount;
                }
                BOSApp.RoundByCurrency(objBankTransactionsInfo, "ACBankTransactionTotalAmount", objBankTransactionsInfo.FK_GECurrencyID);
                BOSApp.RoundByCurrency(objBankTransactionsInfo, "ACBankTransactionExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                // objBankTransactionsInfo.ACBankTransactionTotalAmount = entity.BankTransactionItemList.Sum(i => i.ACBankTransactionItemAmount);
                // objBankTransactionsInfo.ACBankTransactionExchangeAmount = entity.BankTransactionItemList.Sum(i => i.ACBankTransactionItemExchangeAmount);                
                entity.UpdateMainObjectBindingSource();
                UpdateDocumentEntries();
            }
        }

        /// <summary>
        /// Changes the payment order item amount.
        /// </summary>
        /// <param name="item">Changed item</param>
        public void ChangePaymentOrderItemAmount(ACBankTransactionItemsInfo item)
        {
            ACBankTransactionsInfo paymentOrder = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            item.ACBankTransactionItemExchangeAmount = item.ACBankTransactionItemAmount * paymentOrder.ACBankTransactionExchangeRate;
            item.ACBankTransactionItemTaxAmount = item.ACBankTransactionItemAmount * item.ACBankTransactionItemTaxPercent / 100;
            item.ACBankTransactionItemTotalAmount = item.ACBankTransactionItemAmount + item.ACBankTransactionItemTaxAmount;
            item.ACBankTransactionItemTotalExchangeAmount = item.ACBankTransactionItemTotalAmount * paymentOrder.ACBankTransactionExchangeRate;

            BOSApp.RoundByCurrency(item, "ACBankTransactionItemAmount", paymentOrder.FK_GECurrencyID);
            BOSApp.RoundByCurrency(item, "ACBankTransactionItemExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
            BOSApp.RoundByCurrency(item, "ACBankTransactionItemTotalAmount", paymentOrder.FK_GECurrencyID);
            BOSApp.RoundByCurrency(item, "ACBankTransactionItemTotalExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
        }

        public void ChangeExchangeRate()
        {
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            ACBankTransactionsInfo paymentOrder = (ACBankTransactionsInfo)entity.MainObject;
            entity.BankTransactionItemList.ForEach(p =>
            {
                ChangePaymentOrderItemAmount(p);
            });
            UpdateTotalAmount();
            entity.BankTransactionItemList.GridControl?.RefreshDataSource();
        }
        /// <summary>
        /// Remove the selected payment order item from its list
        /// </summary>
        public void RemoveSelectedItem()
        {
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            entity.BankTransactionItemList.RemoveSelectedRowObjectFromList();
            UpdateTotalAmount();
        }

        /// <summary>
        /// Inits the payment order report
        /// </summary>
        /// <param name="report">The report.</param>
        /// <param name="paymentOrderID">Payment order id</param>
        private static void InitPaymentOrderReport(XtraReport report, int paymentOrderID)
        {
            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)objBankTransactionsController.GetBankTransactionByID(paymentOrderID);
            if (objBankTransactionsInfo != null)
            {
                GECurrenciesController objCurrenciesController = new GECurrenciesController();
                GECurrenciesInfo currency = (GECurrenciesInfo)objCurrenciesController.GetObjectByID(objBankTransactionsInfo.FK_GECurrencyID);
                XRLabel totalAmount = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["rp_xrlTotalAmount"];
                if (totalAmount != null)
                {
                    string amount = "";
                    if (currency.GECurrencyNo == "VND")
                        amount = objBankTransactionsInfo.ACBankTransactionTotalAmount.ToString("##,#");
                    else
                        amount = BOSUtil.GetNumberDisplayFormat(objBankTransactionsInfo.ACBankTransactionTotalAmount);

                    totalAmount.Text = string.Format("{0}{1}{2}", amount, " ", currency.GECurrencyName);
                }

                XRLabel currentCompany = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["rp_xrlCurrentCompany"];
                currentCompany.Text = BOSApp.CurrentCompanyInfo.CSCompanyDesc;
                //currentCompany.Text = objBankTransactionsInfo.BRBranchCompanyName;

                XRLabel branchContactAddresss = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchContactAddress"];
                if (branchContactAddresss != null)
                {
                    branchContactAddresss.Text = objBankTransactionsInfo.BRBranchContactAddressLine3;
                }

                if (objBankTransactionsInfo.ACBankTransactionTotalAmount != 0)
                {
                    XRLabel amountWordTop = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblReadAmount"];
                    if (amountWordTop != null)
                    {
                        amountWordTop.Text = ConvertAmountToWord.ReadAmount(objBankTransactionsInfo.ACBankTransactionTotalAmount.ToString(), currency.GECurrencyID);
                    }
                }

            }
        }

        private static void InitPaymentOrderReportVCB(XtraReport report, int paymentOrderID)
        {
            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)objBankTransactionsController.GetBankTransactionByID(paymentOrderID);
            if (objBankTransactionsInfo != null)
            {
                GECurrenciesController objCurrenciesController = new GECurrenciesController();
                GECurrenciesInfo currency = (GECurrenciesInfo)objCurrenciesController.GetObjectByID(objBankTransactionsInfo.FK_GECurrencyID);

                //XRLabel currencies = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lbCurrency"];
                XRLabel currencies = (XRLabel)report.FindControl("xr_lbCurrency", false);
                if (currencies != null)
                {
                    currencies.Text = currency.GECurrencyName;
                }

                //XRLabel totalAmount = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["rp_xrlTotalAmount"];
                XRLabel totalAmount = (XRLabel)report.FindControl("rp_xrlTotalAmount", false);
                if (totalAmount != null)
                {
                    string amount = "";
                    if (currency.GECurrencyNo == "VND")
                        amount = objBankTransactionsInfo.ACBankTransactionTotalAmount.ToString("##,#");
                    else
                        amount = BOSUtil.GetNumberDisplayFormat(objBankTransactionsInfo.ACBankTransactionTotalAmount);

                    totalAmount.Text = string.Format(amount);
                }

                //XRLabel currentCompany = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["rp_xrlCurrentCompany"];
                XRLabel currentCompany = (XRLabel)report.FindControl("rp_xrlCurrentCompany", false);
                if (currentCompany != null)
                {
                    currentCompany.Text = BOSApp.CurrentCompanyInfo.CSCompanyDesc;
                }
                //currentCompany.Text = objBankTransactionsInfo.BRBranchCompanyName;

                //XRLabel branchContactAddresss = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchContactAddress"];
                //if (branchContactAddresss != null)
                //{
                //    branchContactAddresss.Text = objBankTransactionsInfo.BRBranchContactAddressLine3;
                //}

                if (objBankTransactionsInfo.ACBankTransactionTotalAmount != 0)
                {
                    //XRLabel amountWordTop = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblReadAmount"];
                    XRLabel amountWordTop = (XRLabel)report.FindControl("xr_lblReadAmount", false);
                    if (amountWordTop != null)
                    {
                        amountWordTop.Text = ConvertAmountToWord.ReadAmount(objBankTransactionsInfo.ACBankTransactionTotalAmount.ToString(), currency.GECurrencyID);
                    }
                }

            }
        }

        private static void InitPaymentOrderReportAGRI1(XtraReport report, int paymentOrderID)
        {
            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)objBankTransactionsController.GetBankTransactionByID(paymentOrderID);
            if (objBankTransactionsInfo != null)
            {
                GECurrenciesController objCurrenciesController = new GECurrenciesController();
                GECurrenciesInfo currency = (GECurrenciesInfo)objCurrenciesController.GetObjectByID(objBankTransactionsInfo.FK_GECurrencyID);

                //XRLabel totalAmount = (XRLabel)report.Bands[BandKind.PageHeader].Controls["rp_xrlTotalAmount"];
                XRLabel totalAmount = (XRLabel)report.FindControl("rp_xrlTotalAmount", false);
                if (totalAmount != null)
                {
                    string amount = "";
                    if (currency.GECurrencyNo == "VND")
                        amount = objBankTransactionsInfo.ACBankTransactionTotalAmount.ToString("##,#");
                    else
                        amount = BOSUtil.GetNumberDisplayFormat(objBankTransactionsInfo.ACBankTransactionTotalAmount);

                    totalAmount.Text = string.Format("{0}{1}{2}", amount, " ", currency.GECurrencyName);
                }

                XRLabel dateOfID = (XRLabel)report.FindControl("xrLabel45", false);

                if (dateOfID != null)
                {
                    if (objBankTransactionsInfo.ACBankTransactionReceiverIDDate.Year == 9999)
                    {
                        dateOfID.Visible = false;
                    }
                }

                XRLabel currentCompany = (XRLabel)report.FindControl("rp_xrlCurrentCompany", false);

                if (currentCompany != null)
                {
                    //currentCompany.Text = objBankTransactionsInfo.BRBranchCompanyName;
                    currentCompany.Text = BOSApp.CurrentCompanyInfo.CSCompanyDesc;
                }

                XRLabel branchContactAddresss = (XRLabel)report.FindControl("xr_lblBRBranchContactAddress", false);
                if (branchContactAddresss != null)
                {
                    branchContactAddresss.Text = objBankTransactionsInfo.BRBranchContactAddressLine3;
                }

                if (objBankTransactionsInfo.ACBankTransactionTotalAmount != 0)
                {
                    XRLabel amountWordTop = (XRLabel)report.FindControl("xr_lblReadAmount", false);
                    if (amountWordTop != null)
                    {
                        amountWordTop.Text = ConvertAmountToWord.ReadAmount(objBankTransactionsInfo.ACBankTransactionTotalAmount.ToString(), currency.GECurrencyID);
                    }
                }

                if (objBankTransactionsInfo.ACBankTransactionReceiverName != String.Empty)
                {
                    XRLabel ReceiverName = (XRLabel)report.FindControl("rp_xlbReceiverName", false);
                    if (ReceiverName != null)
                    {
                        ReceiverName.Text = objBankTransactionsInfo.ACBankTransactionReceiverName.ToUpper();
                    }
                }
            }
        }

        private static void InitPaymentOrderReportVCBTranfer(XtraReport report, int paymentOrderID)
        {
            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)objBankTransactionsController.GetBankTransactionByID(paymentOrderID);
            if (objBankTransactionsInfo != null)
            {
                GECurrenciesController objCurrenciesController = new GECurrenciesController();
                GECurrenciesInfo currency = (GECurrenciesInfo)objCurrenciesController.GetObjectByID(objBankTransactionsInfo.FK_GECurrencyID);
                string GECurrencyName = string.Empty;
                XRLabel currencies = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lbCurrency"];
                //XRLabel currencies = (XRLabel)report.FindControl("xr_lbCurrency", false);
                if (currency != null)
                {
                    GECurrencyName = currency.GECurrencyName;
                }

                XRLabel totalAmount = (XRLabel)report.FindControl("rp_xrlTotalAmount", false);
                if (totalAmount != null)
                {
                    string amount = "";
                    if (currency.GECurrencyNo == "VND")
                        amount = objBankTransactionsInfo.ACBankTransactionTotalAmount.ToString("##,#");
                    else
                        amount = BOSUtil.GetNumberDisplayFormat(objBankTransactionsInfo.ACBankTransactionTotalAmount);

                    totalAmount.Text = string.Format(amount) + " " + GECurrencyName;
                }
                XRLabel currentCompany = (XRLabel)report.FindControl("rp_xrlCurrentCompany", false);
                if (currentCompany != null)
                {
                    currentCompany.Text = BOSApp.CurrentCompanyInfo.CSCompanyDesc;
                }

                if (objBankTransactionsInfo.ACBankTransactionTotalAmount != 0)
                {
                    XRLabel amountWordTop = (XRLabel)report.FindControl("xr_lblReadAmount", false);
                    if (amountWordTop != null)
                    {
                        amountWordTop.Text = ConvertAmountToWord.ReadAmount(objBankTransactionsInfo.ACBankTransactionTotalAmount.ToString(), currency.GECurrencyID);
                    }
                }

            }
        }

        private static void InitPaymentOrderReportAGBTranfer(XtraReport report, int paymentOrderID)
        {
            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)objBankTransactionsController.GetBankTransactionByID(paymentOrderID);
            if (objBankTransactionsInfo != null)
            {
                GECurrenciesController objCurrenciesController = new GECurrenciesController();
                GECurrenciesInfo currency = (GECurrenciesInfo)objCurrenciesController.GetObjectByID(objBankTransactionsInfo.FK_GECurrencyID);
                string GECurrencyName = string.Empty;
                XRLabel currencies = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lbCurrency"];
                //XRLabel currencies = (XRLabel)report.FindControl("xr_lbCurrency", false);
                if (currency != null)
                {
                    GECurrencyName = currency.GECurrencyName;
                }

                XRLabel totalAmount = (XRLabel)report.FindControl("rp_xrlTotalAmount", false);
                if (totalAmount != null)
                {
                    string amount = "";
                    if (currency.GECurrencyNo == "VND")
                        amount = objBankTransactionsInfo.ACBankTransactionTotalAmount.ToString("##,#");
                    else
                        amount = BOSUtil.GetNumberDisplayFormat(objBankTransactionsInfo.ACBankTransactionTotalAmount);

                    totalAmount.Text = string.Format(amount) + " " + GECurrencyName;
                }
                XRLabel currentCompany = (XRLabel)report.FindControl("rp_xrlCurrentCompany", false);
                if (currentCompany != null)
                {
                    currentCompany.Text = BOSApp.CurrentCompanyInfo.CSCompanyDesc;
                }

                if (objBankTransactionsInfo.ACBankTransactionTotalAmount != 0)
                {
                    XRLabel amountWordTop = (XRLabel)report.FindControl("xr_lblReadAmount", false);
                    if (amountWordTop != null)
                    {
                        amountWordTop.Text = "        Số tiền bằng chữ/ Amount in words: " + ConvertAmountToWord.ReadAmount(objBankTransactionsInfo.ACBankTransactionTotalAmount.ToString(), currency.GECurrencyID);
                    }
                }
                XRLabel desc = (XRLabel)report.FindControl("xr_lbldesc", false);
                if (desc != null)
                {
                    desc.Text = "70: Nội dung thanh toán/ Details of Payment: " + objBankTransactionsInfo.ACBankTransactionDesc;
                }
            }
        }

        private static void InitPaymentOrderReportPaPer(XtraReport report, int paymentOrderID)
        {
            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)objBankTransactionsController.GetBankTransactionByID(paymentOrderID);
            if (objBankTransactionsInfo != null)
            {
                GECurrenciesController objCurrenciesController = new GECurrenciesController();
                GECurrenciesInfo currency = (GECurrenciesInfo)objCurrenciesController.GetObjectByID(objBankTransactionsInfo.FK_GECurrencyID);
                string GECurrencyName = string.Empty;
                XRLabel currencies = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lbCurrency"];
                //XRLabel currencies = (XRLabel)report.FindControl("xr_lbCurrency", false);
                if (currency != null)
                {
                    GECurrencyName = currency.GECurrencyName;
                }
                XRLabel currentCompany = (XRLabel)report.FindControl("rp_xrlCurrentCompany", false);
                if (currentCompany != null)
                {
                    currentCompany.Text = BOSApp.CurrentCompanyInfo.CSCompanyDesc;
                }
                XRLabel companyTaxNumber = (XRLabel)report.FindControl("rp_xrlCompanyTaxNumber", false);
                if (currentCompany != null)
                {
                    companyTaxNumber.Text = BOSApp.CurrentCompanyInfo.CSCompanyTaxNumber;
                }
                if (objBankTransactionsInfo.ACBankTransactionTotalAmount != 0)
                {
                    XRLabel amountWordTop = (XRLabel)report.FindControl("xr_lblReadAmount", false);
                    if (amountWordTop != null)
                    {
                        amountWordTop.Text = ConvertAmountToWord.ReadAmount(objBankTransactionsInfo.ACBankTransactionTotalAmount.ToString(), currency.GECurrencyID);
                    }
                }
            }
        }
        #endregion

        #region Accounting
        public override void GenerateAccountingData()
        {
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            if (mainObject.ACBankTransactionCreateFrom == BankTransactionCreateFrom.NewFromPayRoll.ToString())
            {
                GenerateAccountingData(new string[] { AccDocumentType.Bangluong.ToString() });
            }
            else if (mainObject.ACBankTransactionCreateFrom == BankTransactionCreateFrom.LoanReceipt.ToString())
            {
                GenerateAccountingData(new string[] { AccDocumentType.KheUocVay.ToString() });
            }
            else if (mainObject.ACBankTransactionCreateFrom == BankTransactionCreateFrom.DirectPayment.ToString())
            {
                GenerateAccountingData(new string[] { AccDocumentType.ThanhToanTrucTiep.ToString() });
            }
            else if (mainObject.ACBankTransactionCreateFrom == BankTransactionCreateFrom.CustomerRepaid.ToString())
            {
                GenerateAccountingData(new string[] { AccDocumentType.TraTienKhachHang.ToString() });
            }
            else if (mainObject.ACBankTransactionCreateFrom == BankTransactionCreateFrom.BillOfLading.ToString())
            {
                GenerateAccountingData(new string[] { AccDocumentType.ToKhaiHaiQuanNK.ToString() });
            }
            else
            {
                GenerateAccountingData(new string[] { AccDocumentType.UyNhiemChi.ToString() });
            }
        }

        public override int GetDocumentTypeID()
        {
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            int documentTypeID = 0;
            if (mainObject.ACBankTransactionCreateFrom == BankTransactionCreateFrom.NewFromPayRoll.ToString())
            {
                documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.Bangluong.ToString());
            }
            else if (mainObject.ACBankTransactionCreateFrom == BankTransactionCreateFrom.LoanReceipt.ToString())
            {
                documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.KheUocVay.ToString());
            }
            else
            {
                documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.UyNhiemChi.ToString());
            }
            return documentTypeID;
        }

        protected override void UpdateDocumentEntries()
        {
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            ACBankTransactionsInfo paymentOrder = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            entity.DocumentEntryList.Clear();
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            if (paymentOrder.ACBankTransactionCreateFrom == BankTransactionCreateFrom.NewFromPayRoll.ToString())
            {
                entity.DocumentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.Bangluong.ToString());
            }
            else if (paymentOrder.ACBankTransactionCreateFrom == BankTransactionCreateFrom.LoanReceipt.ToString())
            {
                entity.DocumentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.KheUocVay.ToString());
            }
            else
            {
                entity.DocumentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.UyNhiemChi.ToString());
            }
            CSCompanyBanksController objCSCompanyBanksController = new CSCompanyBanksController();
            CSCompanyBanksInfo objCSCompanyBanksInfo = (CSCompanyBanksInfo)objCSCompanyBanksController.GetObjectByID(paymentOrder.FK_CSCompanyBankID);
            ACEntryTypesController objACEntryTypesController = new ACEntryTypesController();
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            ACEntryTypesInfo objACEntryTypesInfo;
            ACDocTypeEntrysInfo defaultEntry;
            ACObjectsController objectsController = new ACObjectsController();
            ACObjectsInfo objectsInfo = objectsController.GetObjectByIDAndType(paymentOrder.FK_ACObjectID, paymentOrder.ACObjectType);
            foreach (ACBankTransactionItemsInfo item in entity.BankTransactionItemList)
            {
                if (objCSCompanyBanksInfo != null && objCSCompanyBanksInfo.FK_ACAcountID > 0)
                {
                    item.FK_ACCreditAccountID = objCSCompanyBanksInfo.FK_ACAcountID;
                }
                if (paymentOrder.STToolbarActionName == "NewfromManual" && item.FK_ACSegmentID > 0)
                {
                    ACSegmentsController objSegmentsController = new ACSegmentsController();
                    ACSegmentsInfo objSegmentsInfo = (ACSegmentsInfo)objSegmentsController.GetObjectByID(item.FK_ACSegmentID);
                    if (objSegmentsInfo != null && objSegmentsInfo.FK_ACDepreciationCostAccountID > 0)
                    {
                        item.FK_ACDebitAccountID = objSegmentsInfo.FK_ACDepreciationCostAccountID;
                    }
                }
                if (item.FK_HRAdvanceRequestItemID > 0)
                {
                    string accEntryType = string.Empty;
                    if (IsAdvanceRequestLoan(item.FK_HRAdvanceRequestItemID))
                    {
                        accEntryType = AccEntryType.TamUngVay.ToString();
                        objACEntryTypesInfo = (ACEntryTypesInfo)objACEntryTypesController.GetObjectByName(AccEntryType.TamUngVay.ToString());
                    }
                    else if (IsAdvanceRequestUL(item.FK_HRAdvanceRequestItemID))
                    {
                        accEntryType = AccEntryType.TamUngLuong.ToString();
                        objACEntryTypesInfo = (ACEntryTypesInfo)objACEntryTypesController.GetObjectByName(AccEntryType.TamUngLuong.ToString());
                    }
                    else if (IsAdvanceRequesUCT(item.FK_HRAdvanceRequestItemID))
                    {
                        accEntryType = AccEntryType.TamUngCongTac.ToString();
                        objACEntryTypesInfo = (ACEntryTypesInfo)objACEntryTypesController.GetObjectByName(AccEntryType.TamUngCongTac.ToString());
                    }
                    else
                    {
                        accEntryType = AccEntryType.TamUng.ToString();
                        objACEntryTypesInfo = (ACEntryTypesInfo)objACEntryTypesController.GetObjectByName(AccEntryType.TamUng.ToString());
                    }
                    defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                       AccDocumentType.UyNhiemChi.ToString(),
                                                                       accEntryType);
                    if (defaultEntry != null)
                    {
                        if (item.FK_ACDebitAccountID == 0)
                        {
                            item.FK_ACDebitAccountID = defaultEntry.ACDocTypeEntryAccountDefaultDebit;
                        }
                        item.FK_ACEntryTypeID = objACEntryTypesInfo.ACEntryTypeID;
                        item.ACEntryTypeName = objACEntryTypesInfo.ACEntryTypeName;
                        item.ACBankTransactionItemDesc = objACEntryTypesInfo.ACEntryTypeDesc;
                    }
                }
                else if (paymentOrder.ACBankTransactionCreateFrom == BankTransactionCreateFrom.CustomerRepaid.ToString())
                {
                    defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                       AccDocumentType.TraTienKhachHang.ToString(),
                                                                       AccEntryType.TraTienKhachHang.ToString());
                    if (objectsInfo != null && objectsInfo.FK_ACAccountSaleID > 0)
                        item.FK_ACDebitAccountID = objectsInfo.FK_ACAccountSaleID;
                    else if (defaultEntry != null)
                        item.FK_ACDebitAccountID = defaultEntry.ACDocTypeEntryAccountDefaultDebit;
                }
                ACDocumentEntrysInfo entry = new ACDocumentEntrysInfo();
                BOSUtil.CopyObject(item, entry);
                entry.FK_ACDocumentTypeID = entity.DocumentTypeID;
                entry.FK_PMProjectID = paymentOrder.FK_PMProjectID;
                BOSApp.RoundByCurrency(entry, "ACBankTransactionItemAmount", paymentOrder.FK_GECurrencyID);
                BOSApp.RoundByCurrency(entry, "ACBankTransactionItemExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                entity.DocumentEntryList.Add(entry);
            }
        }

        public void ChangeCurrency(int currencyID)
        {
            ACBankTransactionsInfo paymentOrder = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            paymentOrder.FK_GECurrencyID = currencyID;
            decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateTransferByCurrencyAndDate(paymentOrder.FK_GECurrencyID, paymentOrder.ACBankTransactionDate);
            paymentOrder.ACBankTransactionExchangeRate = (dCurrencyExchangeRate > 0) ? dCurrencyExchangeRate : 1;
            ChangeExchangeRate();
        }

        public override void ActionNew()
        {
            base.ActionNew();
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            mainObject.ACBankTransactionCreateFrom = BankTransactionCreateFrom.Normal.ToString();
            AllowEditBankTransactionItemGridControl(true);
        }

        public void ActionNewFromLoanReceipt()
        {
            ActionNew();
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            mainObject.ACBankTransactionCreateFrom = BankTransactionCreateFrom.LoanReceipt.ToString();
            this.GenerateAccountingData();
            guiChooseDate chooseDate = new guiChooseDate();
            chooseDate.Module = this;
            chooseDate.ShowDialog();
            if (chooseDate.DialogResult == DialogResult.OK)
            {
                ShowLoanReceipt(chooseDate.FromDate);
            }
            else
            {
                ActionCancel();
            }
        }

        public void ShowLoanReceipt(DateTime fromdate)
        {
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            ACLoanReceiptPaymentPlansController objLoanReceiptPaymentPlansController = new ACLoanReceiptPaymentPlansController();
            ACLoanReceiptsController objLoanReceiptsController = new ACLoanReceiptsController();
            List<ACLoanReceiptPaymentPlansInfo> lrppList = objLoanReceiptPaymentPlansController.GetLoanReceiptPaymentPlansByPaymentPlanDate(fromdate);

            guiFind<ACLoanReceiptPaymentPlansInfo> guiFind = new guiFind<ACLoanReceiptPaymentPlansInfo>(TableName.ACLoanReceiptPaymentPlansTableName, lrppList, this, false);
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                if (guiFind.SelectedObjects.Count > 0)
                {
                    ACLoanReceiptPaymentPlansInfo objLoanReceiptPaymentPlansInfo = guiFind.SelectedObjects.FirstOrDefault();
                    if (objLoanReceiptPaymentPlansInfo != null)
                    {
                        mainObject.FK_GECurrencyID = objLoanReceiptPaymentPlansInfo.FK_GECurrencyID;
                        decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateTransferByCurrencyAndDate(mainObject.FK_GECurrencyID, mainObject.ACBankTransactionDate);
                        mainObject.ACBankTransactionExchangeRate = (objLoanReceiptPaymentPlansInfo.ACLoanReceiptExchangeRate > 0) ? objLoanReceiptPaymentPlansInfo.ACLoanReceiptExchangeRate : dCurrencyExchangeRate;
                        mainObject.FK_ACLoanReceiptID = objLoanReceiptPaymentPlansInfo.FK_ACLoanReceiptID;
                        mainObject.FK_ACLoanReceiptPaymentPlanID = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanID;
                        ACLoanReceiptsInfo objLoanReceiptsInfo = (ACLoanReceiptsInfo)objLoanReceiptsController.GetObjectByID(objLoanReceiptPaymentPlansInfo.FK_ACLoanReceiptID);
                        if (objLoanReceiptsInfo != null)
                            mainObject.ACBankTransactionDesc = objLoanReceiptsInfo.ACLoanReceiptContent;
                        if (entity.DocumentEntryList != null && entity.DocumentEntryList.Count > 0)
                        {
                            entity.DocumentEntryList.ForEach(a =>
                            {
                                ACBankTransactionItemsInfo objBankTransactionItemsInfo = new ACBankTransactionItemsInfo();
                                if (a.ACEntryTypeName == AccEntryName.TraTienNoGop)
                                {
                                    objBankTransactionItemsInfo.FK_ACDebitAccountID = objLoanReceiptPaymentPlansInfo.FK_ACAccountID;
                                    objBankTransactionItemsInfo.ACBankTransactionItemDesc = a.ACDocumentEntryDesc;
                                    objBankTransactionItemsInfo.ACBankTransactionItemAmount = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment - objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActualRootPayment;
                                    objBankTransactionItemsInfo.ACBankTransactionItemExchangeAmount = (objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment - objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActualRootPayment)
                                                                                                * mainObject.ACBankTransactionExchangeRate;
                                    objBankTransactionItemsInfo.FK_ACEntryTypeID = a.FK_ACEntryTypeID;
                                }
                                else if (a.ACEntryTypeName == AccEntryName.TraTienLaiVay)
                                {
                                    objBankTransactionItemsInfo.FK_ACDebitAccountID = objLoanReceiptPaymentPlansInfo.FK_ACAccountCostID;
                                    objBankTransactionItemsInfo.ACBankTransactionItemDesc = a.ACDocumentEntryDesc;
                                    objBankTransactionItemsInfo.ACBankTransactionItemAmount = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanProfitsPayment - objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActialProfitsPayment;
                                    objBankTransactionItemsInfo.ACBankTransactionItemExchangeAmount = (objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanProfitsPayment - objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActialProfitsPayment)
                                                                                                * mainObject.ACBankTransactionExchangeRate;
                                    objBankTransactionItemsInfo.FK_ACEntryTypeID = a.FK_ACEntryTypeID;
                                }
                                else if (a.ACEntryTypeName == AccEntryName.TraTienLaiPhatQuaHan)
                                {
                                    objBankTransactionItemsInfo.FK_ACDebitAccountID = objLoanReceiptPaymentPlansInfo.FK_ACAccountCostExpiredID;
                                    objBankTransactionItemsInfo.ACBankTransactionItemDesc = a.ACDocumentEntryDesc;
                                    objBankTransactionItemsInfo.ACBankTransactionItemAmount = 0;
                                    objBankTransactionItemsInfo.ACBankTransactionItemExchangeAmount = 0;
                                    objBankTransactionItemsInfo.FK_ACEntryTypeID = a.FK_ACEntryTypeID;
                                }
                                objBankTransactionItemsInfo.ACBankTransactionItemTaxAmount = objBankTransactionItemsInfo.ACBankTransactionItemAmount * objBankTransactionItemsInfo.ACBankTransactionItemTaxPercent / 100;
                                objBankTransactionItemsInfo.ACBankTransactionItemTotalAmount = objBankTransactionItemsInfo.ACBankTransactionItemAmount + objBankTransactionItemsInfo.ACBankTransactionItemTaxAmount;
                                objBankTransactionItemsInfo.ACBankTransactionItemTotalExchangeAmount = objBankTransactionItemsInfo.ACBankTransactionItemTotalAmount * mainObject.ACBankTransactionExchangeRate;
                                objBankTransactionItemsInfo.ACBankTransactionItemReference = objLoanReceiptPaymentPlansInfo.ACLoanReceiptNo;
                                entity.BankTransactionItemList.Add(objBankTransactionItemsInfo);
                            });
                            entity.BankTransactionItemList.GridControl.RefreshDataSource();
                        }
                    }
                }
            }
            else
                ActionCancel();
        }

        public void ActionNewCustomerRepaid()
        {
            ActionNew();
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            mainObject.ACBankTransactionCreateFrom = BankTransactionCreateFrom.CustomerRepaid.ToString();
            this.GenerateAccountingData();
            ARSaleReturnsController objSaleReturnsController = new ARSaleReturnsController();
            List<ARSaleReturnsInfo> listSaleReturns = objSaleReturnsController.GetSaleReturnsForPayment(mainObject.FK_BRBranchID);
            ShowCustomerRepaid(listSaleReturns);
        }

        private void ShowCustomerRepaid(List<ARSaleReturnsInfo> listSaleReturns)
        {
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;
            guiFind<ARSaleReturnsInfo> guiFind = new guiFind<ARSaleReturnsInfo>(TableName.ARSaleReturnsTableName
                                                                                           , listSaleReturns
                                                                                           , this
                                                                                           , true);
        stampp:
            if (guiFind.ShowDialog() == DialogResult.OK)
            {
                List<ARSaleReturnsInfo> results = (List<ARSaleReturnsInfo>)guiFind.SelectedObjects;
                if (results.Count == 0)
                {
                    MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    goto stampp;
                }
                ACBankTransactionItemsInfo objBankTransactionItemsInfo;
                mainObject.ACBankTransactionDesc = PaymentVoucherLocalizedResources.CustomerRepaidItemDesc;

                ARSaleReturnsInfo invalidSaleReturn = guiFind.SelectedObjects.FirstOrDefault(t => t.FK_GECurrencyID != guiFind.SelectedObjects[0].FK_GECurrencyID);
                if (invalidSaleReturn != null)
                {
                    MessageBox.Show(ClearingDebtLocalizedResources.ErrorCurrency,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    goto stampp;
                }

                invalidSaleReturn = guiFind.SelectedObjects.FirstOrDefault(t => t.FK_ACObjectID != guiFind.SelectedObjects[0].FK_ACObjectID);
                if (invalidSaleReturn != null)
                {
                    MessageBox.Show(PaymentVoucherLocalizedResources.ErrorObject,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    goto stampp;
                }

                mainObject.FK_GECurrencyID = results[0].FK_GECurrencyID;
                decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateTransferByCurrencyAndDate(mainObject.FK_GECurrencyID, mainObject.ACBankTransactionDate);
                mainObject.ACBankTransactionExchangeRate = (dCurrencyExchangeRate > 0) ? dCurrencyExchangeRate : results[0].ARSaleReturnExchangeRate;
                mainObject.FK_ACObjectID = results[0].FK_ACObjectID;
                mainObject.ACObjectType = results[0].ARObjectType;
                mainObject.ACObjectAccessKey = mainObject.FK_ACObjectID + ";" + mainObject.ACObjectType;
                mainObject.FK_PMProjectID = results[0].FK_PMProjectID;
                ACObjectsInfo obj = BOSApp.GetObjectByIDAndTypeFromCatche(mainObject.FK_ACObjectID, mainObject.ACObjectType);
                if (obj != null)
                {
                    mainObject.ACBankTransactionReceiverName = obj.ACObjectName;
                    mainObject.ACBankTransactionObjectTaxNumber = obj.ACObjectTaxNumber;
                    if (obj.ACObjectContactAddress != string.Empty)
                    {
                        mainObject.ACBankTransactionReceiverContactAddress = obj.ACObjectContactAddress;
                    }
                }

                foreach (ARSaleReturnsInfo item in results)
                {
                    mainObject.ACBankTransactionDesc += " " + item.ACObjectName + ",";
                    objBankTransactionItemsInfo = new ACBankTransactionItemsInfo();
                    objBankTransactionItemsInfo.ACBankTransactionItemReference = item.ARSaleReturnNo;
                    objBankTransactionItemsInfo.ACBankTransactionItemAmount = item.ARSaleReturnTotalAmount;
                    objBankTransactionItemsInfo.ACBankTransactionItemExchangeAmount = objBankTransactionItemsInfo.ACBankTransactionItemAmount * mainObject.ACBankTransactionExchangeRate;
                    objBankTransactionItemsInfo.ACBankTransactionItemTaxAmount = objBankTransactionItemsInfo.ACBankTransactionItemAmount * objBankTransactionItemsInfo.ACBankTransactionItemTaxPercent / 100;
                    objBankTransactionItemsInfo.ACBankTransactionItemTotalAmount = objBankTransactionItemsInfo.ACBankTransactionItemAmount + objBankTransactionItemsInfo.ACBankTransactionItemTaxAmount;
                    objBankTransactionItemsInfo.ACBankTransactionItemTotalExchangeAmount = objBankTransactionItemsInfo.ACBankTransactionItemTotalAmount * mainObject.ACBankTransactionExchangeRate;
                    objBankTransactionItemsInfo.ACBankTransactionItemInvoiceDate = item.ARSaleReturnDate;
                    objBankTransactionItemsInfo.ACBankTransactionItemDesc = PaymentVoucherLocalizedResources.CustomerRepaidItemDesc + " " + item.ARSaleReturnNo;
                    entity.BankTransactionItemList.Add(objBankTransactionItemsInfo);
                    entity.BankTransactionItemList.GridControl.RefreshDataSource();
                }

                string[] str = mainObject.ACBankTransactionDesc.Split(',');
                mainObject.ACBankTransactionDesc = str[0];
                UpdateDocumentEntries();
                entity.UpdateMainObjectBindingSource();
            }
            else
                ActionCancel();
        }
        #endregion

        #region NewFromPayRoll
        public void NewFromPayRoll()
        {
            ActionNew();
            PaymentOrderEntities entity = CurrentModuleEntity as PaymentOrderEntities;
            ACBankTransactionsInfo mainObject = entity.MainObject as ACBankTransactionsInfo;
            HREmployeePayRollsController objEmployeePayRollsController = new HREmployeePayRollsController();
            ACDocTypeEntryAccountsController objDocTypeEntryAccountsController = new ACDocTypeEntryAccountsController();
            ACDocTypeEntryAccountsInfo objDocTypeEntryAccountsInfo = new ACDocTypeEntryAccountsInfo();
            ACEntryTypesController objEntryTypesController = new ACEntryTypesController();
            ACEntryTypesInfo objEntryTypesInfo = (ACEntryTypesInfo)objEntryTypesController.GetObjectByName(AccDocumentType.Bangluong.ToString());
            mainObject.ACBankTransactionCreateFrom = BankTransactionCreateFrom.NewFromPayRoll.ToString();
            DateTime fromdate = DateTime.MinValue;
            guiChooseDate chooseDate = new guiChooseDate();
            chooseDate.Module = this;
            chooseDate.ShowDialog();
            if (chooseDate.DialogResult == DialogResult.OK)
            {
                fromdate = chooseDate.FromDate;
                ACBankTransactionItemsInfo objBankTransactionItemsInfo = new ACBankTransactionItemsInfo();
                if (objEntryTypesInfo != null)
                {
                    objBankTransactionItemsInfo.FK_ACEntryTypeID = objEntryTypesInfo.ACEntryTypeID;
                    objBankTransactionItemsInfo.ACBankTransactionItemDesc = objEntryTypesInfo.ACEntryTypeDesc;
                    objBankTransactionItemsInfo.FK_ACDebitAccountID = objDocTypeEntryAccountsController.GetAcountIDByEntryTypeIDAndPostingType(objEntryTypesInfo.ACEntryTypeID, AccPostingType.Debit.ToString());
                }
                objBankTransactionItemsInfo.ACBankTransactionItemAmount = objEmployeePayRollsController.GetSalaryByMonth(fromdate);
                objBankTransactionItemsInfo.ACBankTransactionItemExchangeAmount = objBankTransactionItemsInfo.ACBankTransactionItemAmount;
                entity.BankTransactionItemList.Add(objBankTransactionItemsInfo);
            }
            entity.BankTransactionItemList.GridControl.RefreshDataSource();
        }

        public void ActionNewFromDirectPayment()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                base.ActionNew();
                ACBankTransactionsInfo mainObject = CurrentModuleEntity.MainObject as ACBankTransactionsInfo;
                mainObject.ACBankTransactionCreateFrom = BankTransactionCreateFrom.DirectPayment.ToString(); //tuong duong APPaymentVoucherPurpose
                this.GenerateAccountingData();
                HRAdvanceRefundsController harController = new HRAdvanceRefundsController();
                List<HRAdvanceRefundsInfo> advanceRefundList = harController.GetAdvanceRefundsWithDirectPaymentType(AdvanceRefundPaymentType.Payment.ToString());
                ShowAdvanceRefundList(advanceRefundList);
                //ChangeObject(mainObject.ACObjectAccessKey);
            }
        }

        private void ShowAdvanceRefundList(List<HRAdvanceRefundsInfo> advanceRefundList)
        {
            PaymentOrderEntities entity = CurrentModuleEntity as PaymentOrderEntities;
            ACBankTransactionsInfo mainObject = entity.MainObject as ACBankTransactionsInfo;

            guiFind<HRAdvanceRefundsInfo> guiFind = new guiFind<HRAdvanceRefundsInfo>(TableName.HRAdvanceRefundsTableName
                                                                                           , advanceRefundList
                                                                                           , this
                                                                                           , true);
        stampp:
            if (guiFind.ShowDialog() == DialogResult.OK)
            {
                #region check employee
                HRAdvanceRefundsInfo invalidRefund = guiFind.SelectedObjects.FirstOrDefault(t => t.FK_HREmployeeID != guiFind.SelectedObjects[0].FK_HREmployeeID);
                if (invalidRefund != null)
                {
                    MessageBox.Show("Vui lòng chọn các đề nghị hoàn ứng của cùng một nhân viên."
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);
                    goto stampp;
                }
                #endregion

                #region check currency
                invalidRefund = guiFind.SelectedObjects.FirstOrDefault(t => t.FK_GECurrencyID != guiFind.SelectedObjects[0].FK_GECurrencyID);
                if (invalidRefund != null)
                {
                    MessageBox.Show(ClearingDebtLocalizedResources.ErrorCurrency
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);
                    goto stampp;
                }
                #endregion

                //Main object\
                HRAdvanceRefundsInfo defaultRefund = guiFind.SelectedObjects[0];
                mainObject.FK_ACObjectID = defaultRefund.FK_ACObjectID;
                mainObject.ACObjectType = defaultRefund.HRObjectType;
                mainObject.FK_GECurrencyID = defaultRefund.FK_GECurrencyID;
                mainObject.ACObjectAccessKey = mainObject.FK_ACObjectID + ";" + mainObject.ACObjectType;
                decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateTransferByCurrencyAndDate(mainObject.FK_GECurrencyID, mainObject.ACBankTransactionDate);
                mainObject.ACBankTransactionExchangeRate = (dCurrencyExchangeRate > 0) ? dCurrencyExchangeRate : defaultRefund.HRAdvanceRefundExchangeRate;
                mainObject.FK_PMProjectID = defaultRefund.FK_PMProjectID;
                mainObject.FK_ACSegmentID = defaultRefund.FK_ACSegmentID;
                ACObjectsInfo objectsInfo = BOSApp.GetObjectByIDAndTypeFromCatche(mainObject.FK_ACObjectID, mainObject.ACObjectType);
                if (objectsInfo != null)
                {
                    mainObject.ACBankTransactionReceiverName = objectsInfo.ACObjectName;
                    mainObject.ACBankTransactionObjectTaxNumber = objectsInfo.ACObjectTaxNumber;
                    if (objectsInfo.ACObjectContactAddress != string.Empty)
                    {
                        mainObject.ACBankTransactionReceiverContactAddress = objectsInfo.ACObjectContactAddress;
                    }
                }

                //Module Object
                ACDocumentEntrysController entryController = new ACDocumentEntrysController();
                ACDocumentEntrysInfo docEntry = entryController.GetDefaultDocumentEntryByEntryAndDocumentType(AccDocumentType.UyNhiemChi.ToString()
                                                                                                                , AccEntryType.ChiTienHoanUng.ToString());
                ACDocumentEntrysInfo docEntryForTax = entryController.GetDefaultDocumentEntryByEntryAndDocumentType(AccDocumentType.ThanhToanTrucTiep.ToString()
                                                                                                                                , AccEntryType.ThueGTGTDuocKhauTru.ToString());
                if (docEntry == null)
                {
                    MessageBox.Show("Vui lòng cấu hình bút toán cho loại chứng từ này trước."
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);
                    ActionCancel();
                }
                else
                {
                    List<ACBankTransactionItemsInfo> pviList = new List<ACBankTransactionItemsInfo>();
                    ACBankTransactionItemsInfo pviInfo;

                    string[] advanceRefundNoList = guiFind.SelectedObjects.Select(item => item.HRAdvanceRefundNo).ToArray();
                    string advanceRefundNos = string.Empty;
                    if (advanceRefundNoList != null)
                        advanceRefundNos = string.Join("; ", advanceRefundNoList);

                    HRAdvanceRefundItemInvoicesController advRefundItemInvoiceController = new HRAdvanceRefundItemInvoicesController();
                    List<HRAdvanceRefundItemInvoicesInfo> advRefundItemInvs = advRefundItemInvoiceController.GetAdvanceRefundItemInvoicesByAdvanceRefundNos(advanceRefundNos);
                    mainObject.ACBankTransactionDesc = String.Empty;
                    foreach (HRAdvanceRefundsInfo advanceRefund in guiFind.SelectedObjects)
                    {
                        if (advanceRefund.HRAdvanceRefundType != AdvanceRefundType.DirectPayment.ToString())
                        {
                            pviInfo = new ACBankTransactionItemsInfo();
                            pviInfo.FK_ACEntryTypeID = docEntry.FK_ACEntryTypeID;
                            pviInfo.FK_ACCreditAccountID = docEntry.FK_ACCreditAccountID;
                            pviInfo.FK_ACDebitAccountID = advanceRefund.FK_ACCreditAccountID;
                            pviInfo.FK_ACCostObjectID = docEntry.FK_ACCostObjectID;
                            pviInfo.ACBankTransactionItemDesc = docEntry.ACDocumentEntryDesc + " - " + advanceRefund.HRAdvanceRefundNo;
                            pviInfo.FK_HRAdvanceRefundID = advanceRefund.HRAdvanceRefundID;
                            pviInfo.ACBankTransactionItemAmount = advanceRefund.HRAdvanceRefundTotalAmount - advanceRefund.HRAdvanceRefundExchangePaymentAmount;
                            pviInfo.ACBankTransactionItemExchangeAmount = pviInfo.ACBankTransactionItemAmount * mainObject.ACBankTransactionExchangeRate;
                            pviInfo.ACBankTransactionItemTaxAmount = pviInfo.ACBankTransactionItemAmount * pviInfo.ACBankTransactionItemTaxPercent / 100;
                            pviInfo.ACBankTransactionItemTotalAmount = pviInfo.ACBankTransactionItemAmount + pviInfo.ACBankTransactionItemTaxAmount;
                            pviInfo.ACBankTransactionItemTotalExchangeAmount = pviInfo.ACBankTransactionItemTotalAmount * mainObject.ACBankTransactionExchangeRate;
                            pviList.Add(pviInfo);
                        }
                        else
                        {
                            List<HRAdvanceRefundItemInvoicesInfo> collection = advRefundItemInvs.Where(item => item.FK_HRAdvanceRefundID == advanceRefund.HRAdvanceRefundID).ToList();
                            if (collection != null)
                            {
                                foreach (HRAdvanceRefundItemInvoicesInfo inv in collection)
                                {
                                    pviInfo = new ACBankTransactionItemsInfo();
                                    pviInfo.FK_ACEntryTypeID = docEntry.FK_ACEntryTypeID;
                                    pviInfo.FK_ACCreditAccountID = docEntry.FK_ACCreditAccountID;
                                    pviInfo.FK_ACDebitAccountID = inv.FK_ACDebitAccountID;
                                    pviInfo.FK_ACCostObjectID = docEntry.FK_ACCostObjectID;
                                    pviInfo.FK_HRAdvanceRefundID = advanceRefund.HRAdvanceRefundID;
                                    pviInfo.FK_HRAdvanceRefundItemInvoiceID = inv.HRAdvanceRefundItemInvoiceID;
                                    pviInfo.ACBankTransactionItemReference = advanceRefund.HRAdvanceRefundNo;
                                    pviInfo.ACBankTransactionItemVATDocumentType = inv.HRInputVATDocumentType;
                                    pviInfo.ACBankTransactionItemTaxNumber = inv.HRAdvanceRefundItemInvoiceObjectTaxNumber;
                                    pviInfo.ACBankTransactionItemVoucherNo = inv.HRAdvanceRefundItemInvoiceSupplierNo;
                                    pviInfo.ACBankTransactionItemInvoiceDate = inv.HRAdvanceRefundItemInvoiceVATDate;
                                    pviInfo.ACBankTransactionItemDesc = inv.HRAdvanceRefundItemInvoiceObjectDesc;
                                    pviInfo.ACBankTransactionItemAmount = inv.HRAdvanceRefundItemInvoiceSubTotalAmount - inv.HRAdvanceRefundPaymentTimeSubPaidAmount; ;
                                    pviInfo.ACBankTransactionItemExchangeAmount = pviInfo.ACBankTransactionItemAmount * mainObject.ACBankTransactionExchangeRate;
                                    pviInfo.ACBankTransactionItemTaxPercent = Convert.ToInt32(inv.HRAdvanceRefundItemInvoiceTaxPercent);
                                    pviInfo.ACBankTransactionItemTaxAmount = inv.HRAdvanceRefundItemInvoiceTaxAmount - inv.HRAdvanceRefundPaymentTimeTaxPaidAmount;
                                    pviInfo.ACBankTransactionItemTotalAmount = pviInfo.ACBankTransactionItemAmount + pviInfo.ACBankTransactionItemTaxAmount;
                                    pviInfo.ACBankTransactionItemTotalExchangeAmount = pviInfo.ACBankTransactionItemTotalAmount * mainObject.ACBankTransactionExchangeRate;
                                    pviInfo.FK_ACCostCenterID = inv.FK_ACCostCenterID;
                                    pviInfo.FK_ACSegmentID = inv.FK_ACSegmentID;
                                    pviInfo.FK_PMProjectID = inv.FK_PMProjectID;
                                    pviInfo.FK_ACUnfinishedConstructionCostID = inv.FK_ACUnfinishedConstructionCostID;
                                    pviInfo.ACBankTransactionItemVATSymbol = inv.HRAdvanceRefundItemInvoiceVATSymbol;
                                    pviInfo.FK_ACObjectID = inv.FK_HRObjectID;
                                    pviInfo.ACObjectType = inv.HRObjectType;
                                    pviInfo.ACObjectName = inv.HRAdvanceRefundItemInvoiceObjectName;
                                    pviInfo.ACObjectAccessKey = pviInfo.FK_ACObjectID + ";" + pviInfo.ACObjectType;
                                    pviInfo.FK_VMVehicleID = inv.FK_VMVehicleID;
                                    pviInfo.FK_ACCostObjectID = inv.FK_ACCostObjectID;
                                    pviInfo.ACBankTransactionItemVATFormNo = inv.HRAdvanceRefundItemInvoiceVATFormNo;
                                    pviInfo.FK_ACEInvoiceTypeID = inv.FK_ACEInvoiceTypeID;
                                    pviList.Add(pviInfo);
                                }
                            }
                        }
                        mainObject.ACBankTransactionDesc += advanceRefund.HRAdvanceRefundDesc + "\r\n";
                    }
                    entity.BankTransactionItemList.Invalidate(pviList);
                    entity.BankTransactionItemList.GridControl.RefreshDataSource();
                    AllowEditBankTransactionItemGridControl(true);

                    UpdateTotalAmount();
                    entity.UpdateMainObjectBindingSource();
                }
            }
            else
            {
                ActionCancel();
            }
        }
        #endregion

        public void UpdateItemDesc()
        {
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            if(mainObject.ACBankTransactionCreateFrom == BankTransactionCreateFrom.Normal.ToString() && !String.IsNullOrWhiteSpace(mainObject.ACBankTransactionDesc))
            {
                foreach (ACBankTransactionItemsInfo item in entity.BankTransactionItemList)
                {
                    item.ACBankTransactionItemDesc = mainObject.ACBankTransactionDesc;
                }
            }
        }

        public void ChangeSegment(int segmentID)
        {
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            mainObject.FK_ACSegmentID = segmentID;

            entity.BankTransactionItemList.ForEach(o =>
            {
                o.FK_ACSegmentID = mainObject.FK_ACSegmentID;
            });
            UpdateDocumentEntries();
            entity.BankTransactionItemList.GridControl.RefreshDataSource();
        }

        public void ActionPosted()
        {
            if (!CheckLock()) return;
            CurrentModuleEntity.SetPropertyChangeEventLock(false);
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;
            mainObject.ACBankTransactionPostedStatus = PostedTransactionStatus.Posted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACBankTransactionID, PostedTransactionStatus.Posted.ToString());
            GLHelper.PostedTransactions(this.Name, mainObject.ACBankTransactionID, ModulePostingType.Accounting);

            #region Update CostObjectItems
            ACCostObjectItemsController objCostObjectItemsController = new ACCostObjectItemsController();
            foreach (ACBankTransactionItemsInfo item in entity.BankTransactionItemList)
            {
                objCostObjectItemsController.InsertCostObjectItemByModuleNameAndItemID(this.Name, item.ACBankTransactionItemID, true);
            }
            #endregion

            #region Create LoanReceiptPayDocs
            if ((mainObject.ACBankTransactionCreateFrom == BankTransactionCreateFrom.Normal.ToString() && mainObject.FK_ACLoanReceiptID > 0) || mainObject.ACBankTransactionCreateFrom == BankTransactionCreateFrom.LoanReceipt.ToString())
            {
                ACLoanReceiptPayDocsController objLoanReceiptPayDocsController = new ACLoanReceiptPayDocsController();
                objLoanReceiptPayDocsController.InsertLoanReceiptPayDocByDocumentPaymentNo(mainObject.ACBankTransactionNo, mainObject.FK_ACLoanReceiptID, true);
            }
            #endregion
            InvalidateToolbar();
            CurrentModuleEntity.SetPropertyChangeEventLock(true);
        }

        public void ActionUnPosted()
        {
            if (!CheckLock()) return;
            CurrentModuleEntity.SetPropertyChangeEventLock(false);
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;
            mainObject.ACBankTransactionPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACBankTransactionID, PostedTransactionStatus.UnPosted.ToString());

            #region Update CostObjectItems
            ACCostObjectItemsController objCostObjectItemsController = new ACCostObjectItemsController();
            foreach (ACBankTransactionItemsInfo item in entity.BankTransactionItemList)
            {
                objCostObjectItemsController.InsertCostObjectItemByModuleNameAndItemID(this.Name, item.ACBankTransactionItemID, false);
            }
            #endregion

            #region Create LoanReceiptPayDocs
            if ((mainObject.ACBankTransactionCreateFrom == BankTransactionCreateFrom.Normal.ToString() && mainObject.FK_ACLoanReceiptID > 0) || mainObject.ACBankTransactionCreateFrom == BankTransactionCreateFrom.LoanReceipt.ToString())
            {
                ACLoanReceiptPayDocsController objLoanReceiptPayDocsController = new ACLoanReceiptPayDocsController();
                objLoanReceiptPayDocsController.InsertLoanReceiptPayDocByDocumentPaymentNo(mainObject.ACBankTransactionNo, mainObject.FK_ACLoanReceiptID, false);
            }
            #endregion

            GLHelper.UnPostedTransactions(this.Name, mainObject.ACBankTransactionID, ModulePostingType.Accounting);
            InvalidateToolbar();
            CurrentModuleEntity.SetPropertyChangeEventLock(true);
        }

        public override void InvalidateToolbar()
        {
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, false);
            if (mainObject.ACBankTransactionID > 0)
            {
                if (mainObject.ACBankTransactionStatus == BankTransactionStatus.Completed.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                            mainObject.ACBankTransactionPostedStatus != PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                            mainObject.ACBankTransactionPostedStatus == PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, true);
                }
                else if (mainObject.ACBankTransactionStatus == BankTransactionStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                }
            }
            base.InvalidateToolbar();
        }

        public void GetDSForListAccountBankLookUpEditControl()
        {
            ACBankTransactionsInfo mainObject = CurrentModuleEntity.MainObject as ACBankTransactionsInfo;
            if (mainObject.FK_ACObjectID > 0 && mainObject.ACObjectType != string.Empty)
            {
                ACListAccountBanksController objListAccountBanksController = new ACListAccountBanksController();
                List<ACListAccountBanksInfo> listAccountBanks = objListAccountBanksController.GetListByACObject(mainObject.FK_ACObjectID, mainObject.ACObjectType);
                ListAccountBankLookUpEditControl.Properties.DataSource = listAccountBanks;
            }
            else
            {
                ListAccountBankLookUpEditControl.Properties.DataSource = null;
            }
        }

        public void ChangeListAccountBank(int listAccountBankID)
        {
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            objBankTransactionsInfo.FK_ACListAccountBankID = listAccountBankID;
            ACListAccountBanksController objListAccountBanksController = new ACListAccountBanksController();
            ACListAccountBanksInfo objListAccountBanksInfo =
                (ACListAccountBanksInfo)objListAccountBanksController.GetObjectByID(listAccountBankID);
            if (objListAccountBanksInfo != null)
            {
                objBankTransactionsInfo.ACBankTransactionReceiverAccount =
                    objListAccountBanksInfo.ACListAccountBankAccount;
                objBankTransactionsInfo.ACBankTransactionReceiverBankName =
                    objListAccountBanksInfo.ACListAccountBankBranch;
                objBankTransactionsInfo.ACBankTransactionReceiverIDNumber =
                    objListAccountBanksInfo.ACListAccountBankAccountHolderIDNumber;
                objBankTransactionsInfo.ACBankTransactionReceiverName =
                    objListAccountBanksInfo.ACListAccountBankAccountHolder;
                objBankTransactionsInfo.ACBankTransactionReceiverIDDate =
                    objListAccountBanksInfo.ACListAccountBankAccountHolderIDCardDate;
                objBankTransactionsInfo.ACBankTransactionReceiverContactAddress =
                    objListAccountBanksInfo.ACListAccountBankObjectAddress;
                objBankTransactionsInfo.ACBankTransactionReceiverIDPlace =
                    objListAccountBanksInfo.ACListAccountBankAccountHolderCity;
                objBankTransactionsInfo.ACBankTransactionReceiverBankCode =
                    objListAccountBanksInfo.ACListAccountBankNo;
                CurrentModuleEntity.UpdateMainObjectBindingSource();
            }
        }

        #region AdvanceRequest
        public void ActionNewFromAdvanceRequest()
        {
            ActionNew();
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;
            mainObject.ACBankTransactionCreateFrom = BankTransactionCreateFrom.PaymentAdvanceRequest.ToString();
            HRAdvanceRequestItemsController objHRAdvanceRequestItemsController = new HRAdvanceRequestItemsController();
            List<HRAdvanceRequestItemsInfo> advanceRequestItems = (List<HRAdvanceRequestItemsInfo>)objHRAdvanceRequestItemsController.GetAdvanceRequestItemsForPaymentVoucher();
            guiFind<HRAdvanceRequestItemsInfo> guiAdvanceRequest = new guiFind<HRAdvanceRequestItemsInfo>(TableName.HRAdvanceRequestItemsTableName,
                                                                advanceRequestItems, this, true, true, new string[] { "HRAdvanceRequestTypeName", "HRAdvanceRequestNo" });
        stampp:
            if (guiAdvanceRequest.ShowDialog() == DialogResult.OK)
            {
                List<HRAdvanceRequestItemsInfo> results = (List<HRAdvanceRequestItemsInfo>)guiAdvanceRequest.SelectedObjects;
                if (results.Count == 0)
                    goto stampp;

                if (IsAdvanceRequestLoan() && results.FirstOrDefault(t => t.HRAdvanceRequestType != AdvanceRequestType.Loan.ToString()) != null)
                {
                    MessageBox.Show("Vui lòng chọn các Tạm ứng vay", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    goto stampp;
                }

                if (results.FirstOrDefault(o => o.HRAdvanceRequestType == AdvanceRequestType.Loan.ToString()) != null)
                {
                    HRAdvanceRequestPaymentTimesInfo objAdvanceRequestPaymentTimesInfo = entity.AdvanceRequestPaymentTimeList.FirstOrDefault(o => o.HRAdvanceRequestType != AdvanceRequestType.Loan.ToString());
                    if (objAdvanceRequestPaymentTimesInfo != null)
                    {
                        MessageBox.Show("Vui lòng chọn các tạm ứng cùng loại", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        goto stampp;
                    }
                }

                List<int> advanceRequestItemIDList = entity.AdvanceRequestPaymentTimeList.Select(o => o.FK_HRAdvanceRequestItemID).ToList();
                foreach (HRAdvanceRequestItemsInfo item in results)
                {
                    if (advanceRequestItemIDList.Contains(item.HRAdvanceRequestItemID))
                    {
                        MessageBox.Show(PaymentVoucherLocalizedResources.ExistedAdvanceRequestItem, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto stampp;
                    }
                    if (item.FK_GECurrencyID != results[0].FK_GECurrencyID)
                    {
                        MessageBox.Show(ClearingDebtLocalizedResources.ErrorCurrency,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        goto stampp;
                    }
                }

                if (mainObject.FK_ACObjectID == 0)
                {
                    mainObject.FK_ACObjectID = results[0].FK_HREmployeeID;
                    mainObject.ACObjectType = ObjectType.Employee.ToString();
                    mainObject.ACObjectAccessKey = mainObject.FK_ACObjectID + ";" + mainObject.ACObjectType;

                    ACObjectsInfo obj = BOSApp.GetObjectByIDAndTypeFromCatche(mainObject.FK_ACObjectID, mainObject.ACObjectType);
                    if (obj != null)
                    {
                        mainObject.ACBankTransactionReceiverName = obj.ACObjectName;
                        mainObject.ACBankTransactionObjectTaxNumber = obj.ACObjectTaxNumber;
                        if (obj.ACObjectContactAddress != string.Empty)
                        {
                            mainObject.ACBankTransactionReceiverContactAddress = obj.ACObjectContactAddress;
                        }
                    }
                }
                List<HRAdvanceRequestItemsInfo> advanceRequestItemCheckList = results.Where(o => o.FK_HREmployeeID != mainObject.FK_ACObjectID).ToList();
                if ((advanceRequestItemCheckList != null && advanceRequestItemCheckList.Count > 0) || mainObject.ACObjectType != ObjectType.Employee.ToString())
                {
                    MessageBox.Show(PaymentVoucherLocalizedResources.NoMatchWithEmployee, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto stampp;
                }
                mainObject.FK_PMProjectID = results[0].FK_PMProjectID;
                mainObject.FK_ACSegmentID = results[0].FK_ACSegmentID;
                mainObject.FK_GECurrencyID = results[0].FK_GECurrencyID;
                decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateTransferByCurrencyAndDate(mainObject.FK_GECurrencyID, mainObject.ACBankTransactionDate);
                mainObject.ACBankTransactionExchangeRate = (dCurrencyExchangeRate > 0) ? dCurrencyExchangeRate : results[0].HRAdvanceRequestExchangeRate;
                mainObject.ACBankTransactionDesc = String.Empty;

                ACEntryTypesController objACEntryTypesController = new ACEntryTypesController();
                HRAdvanceRequestsController objHRAdvanceRequestsController = new HRAdvanceRequestsController();
                HRAdvanceRequestPaymentTimesInfo objHRAdvanceRequestPaymentTimesInfo;

                foreach (HRAdvanceRequestItemsInfo item in results)
                {
                    HRAdvanceRequestsInfo objHRAdvanceRequestsInfo = (HRAdvanceRequestsInfo)objHRAdvanceRequestsController.GetObjectByID(item.FK_HRAdvanceRequestID);
                    objHRAdvanceRequestPaymentTimesInfo = new HRAdvanceRequestPaymentTimesInfo();
                    objHRAdvanceRequestPaymentTimesInfo.FK_HRAdvanceRequestID = item.FK_HRAdvanceRequestID;
                    objHRAdvanceRequestPaymentTimesInfo.FK_HRAdvanceRequestItemID = item.HRAdvanceRequestItemID;
                    objHRAdvanceRequestPaymentTimesInfo.HRAdvanceRequestPaymentTimeTotalAmount = item.HRAdvanceRequestItemTotalAmount;
                    objHRAdvanceRequestPaymentTimesInfo.HRAdvanceRequestPaymentTimeAmount = item.HRAdvanceRequestItemTotalAmount;
                    objHRAdvanceRequestPaymentTimesInfo.HRAdvanceRequestType = item.HRAdvanceRequestType;
                    objHRAdvanceRequestPaymentTimesInfo.HRAdvanceRequestPaymentTimeReference = objHRAdvanceRequestsInfo.HRAdvanceRequestNo;
                    if (objHRAdvanceRequestsInfo != null)
                    {
                        StringBuilder advanceRequestPaymentTimeDesc = new StringBuilder();
                        if (objHRAdvanceRequestPaymentTimesInfo.HRAdvanceRequestType == AdvanceRequestType.Loan.ToString())
                        {
                            advanceRequestPaymentTimeDesc.Append(PaymentVoucherLocalizedResources.AdvanceRequestLoan).Append(" ").Append(objHRAdvanceRequestsInfo.HRAdvanceRequestNo);
                        }
                        else
                        {
                            advanceRequestPaymentTimeDesc.Append(PaymentVoucherLocalizedResources.AdvanceRequest).Append(" ").Append(objHRAdvanceRequestsInfo.HRAdvanceRequestNo);
                        }
                        objHRAdvanceRequestPaymentTimesInfo.HRAdvanceRequestPaymentTimeDesc = advanceRequestPaymentTimeDesc.ToString();
                        objHRAdvanceRequestPaymentTimesInfo.HRAdvanceRequestType = objHRAdvanceRequestsInfo.HRAdvanceRequestType;
                    }
                    entity.AdvanceRequestPaymentTimeList.Add(objHRAdvanceRequestPaymentTimesInfo);

                    if (!String.IsNullOrEmpty(objHRAdvanceRequestsInfo.HRAdvanceRequestDesc))
                    {
                        mainObject.ACBankTransactionDesc += objHRAdvanceRequestsInfo.HRAdvanceRequestDesc + "; ";
                    }
                }
                if (mainObject.ACBankTransactionDesc.Length > 2)
                    mainObject.ACBankTransactionDesc = mainObject.ACBankTransactionDesc.Substring(0, mainObject.ACBankTransactionDesc.Length - 2);
                ChangeObject(mainObject.ACObjectAccessKey);
                foreach (HRAdvanceRequestPaymentTimesInfo item1 in entity.AdvanceRequestPaymentTimeList)
                {
                    entity.BankTransactionItemList.Add(ToBankTransactionItemList(item1));
                }
                UpdateTotalAmount();
                AllowEditBankTransactionItemGridControl(true);
                entity.BankTransactionItemList.GridControl.RefreshDataSource();
            }
            else
                ActionCancel();
        }

        public ACBankTransactionItemsInfo ToBankTransactionItemList(HRAdvanceRequestPaymentTimesInfo objAdvanceRequestPaymentTimesInfo)
        {
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            return new ACBankTransactionItemsInfo()
            {
                ACBankTransactionItemDesc = PaymentVoucherLocalizedResources.AdvanceRequest,
                ACBankTransactionItemAmount = objAdvanceRequestPaymentTimesInfo.HRAdvanceRequestPaymentTimeTotalAmount,
                ACBankTransactionItemExchangeAmount = objAdvanceRequestPaymentTimesInfo.HRAdvanceRequestPaymentTimeTotalAmount * mainObject.ACBankTransactionExchangeRate,
                ACBankTransactionItemTotalAmount = objAdvanceRequestPaymentTimesInfo.HRAdvanceRequestPaymentTimeTotalAmount,
                ACBankTransactionItemTotalExchangeAmount = objAdvanceRequestPaymentTimesInfo.HRAdvanceRequestPaymentTimeTotalAmount * mainObject.ACBankTransactionExchangeRate,
                FK_ACUnfinishedConstructionCostID = objAdvanceRequestPaymentTimesInfo.FK_ACUnfinishedConstructionCostID,
                FK_HRAdvanceRequestItemID = objAdvanceRequestPaymentTimesInfo.FK_HRAdvanceRequestItemID,
                ACBankTransactionItemReference = objAdvanceRequestPaymentTimesInfo.HRAdvanceRequestPaymentTimeReference
            };
        }

        public void AllowEditBankTransactionItemGridControl(bool isAllow)
        {
            GridView gridView = (GridView)BankTransactionItemsGridControl.MainView;
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "ACBankTransactionItemAmount" || column.FieldName == "ACBankTransactionItemExchangeAmount")
                {
                    column.OptionsColumn.AllowEdit = isAllow;
                }
            }
        }

        public bool IsAdvanceRequestLoan(int advanceRequestItemID)
        {
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            HRAdvanceRequestPaymentTimesInfo objAdvanceRequestPaymentTimesInfo = entity.AdvanceRequestPaymentTimeList.FirstOrDefault(o => o.HRAdvanceRequestType == AdvanceRequestType.Loan.ToString() && o.FK_HRAdvanceRequestItemID == advanceRequestItemID);
            if (objAdvanceRequestPaymentTimesInfo != null)
            {
                return true;
            }
            return false;
        }

        public bool IsAdvanceRequestUL(int advanceRequestItemID)
        {
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            HRAdvanceRequestPaymentTimesInfo objAdvanceRequestPaymentTimesInfo = entity.AdvanceRequestPaymentTimeList.FirstOrDefault(o => o.HRAdvanceRequestType == AdvanceRequestType.UL.ToString() && o.FK_HRAdvanceRequestItemID == advanceRequestItemID);
            if (objAdvanceRequestPaymentTimesInfo != null)
            {
                return true;
            }
            return false;
        }

        public bool IsAdvanceRequesUCT(int advanceRequestItemID)
        {
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            HRAdvanceRequestPaymentTimesInfo objAdvanceRequestPaymentTimesInfo = entity.AdvanceRequestPaymentTimeList.FirstOrDefault(o => o.HRAdvanceRequestType == AdvanceRequestType.UCT.ToString() && o.FK_HRAdvanceRequestItemID == advanceRequestItemID);
            if (objAdvanceRequestPaymentTimesInfo != null)
            {
                return true;
            }
            return false;
        }

        public bool IsAdvanceRequestLoan()
        {
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            HRAdvanceRequestPaymentTimesInfo loan = entity.AdvanceRequestPaymentTimeList.FirstOrDefault(t => t.HRAdvanceRequestType == AdvanceRequestType.Loan.ToString());
            if (loan != null)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Refund
        public void ActionNewFromAdvanceRefund()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                ActionNew();
                ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
                mainObject.ACBankTransactionCreateFrom = BankTransactionCreateFrom.NewFromAdvanceRefund.ToString();
                this.GenerateAccountingData();
                HRAdvanceRefundsController harController = new HRAdvanceRefundsController();
                List<HRAdvanceRefundsInfo> advanceRefundList = harController.GetAdvanceRefundsWithNoneDirectPaymentType(AdvanceRefundPaymentType.Payment.ToString());
                ShowAdvanceRefundList(advanceRefundList);
            }
        }
        #endregion

        #region BillOfLading
        public void ActionNewFromBillOfLading()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                base.ActionNew();
                ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
                mainObject.ACBankTransactionCreateFrom = BankTransactionCreateFrom.BillOfLading.ToString();
                this.GenerateAccountingData();
                APBillOfLadingsController objBillOfLadingController = new APBillOfLadingsController();
                List<APBillOfLadingsInfo> billOfLadingList = objBillOfLadingController.GetObjectsForPaymentVoucher(mainObject.FK_BRBranchID);
                ShowBillOfLadingList(billOfLadingList);
            }
        }

        private void ShowBillOfLadingList(List<APBillOfLadingsInfo> billOfLadingList)
        {
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;
            string billOfLadingNoList = string.Empty;
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            guiFind<APBillOfLadingsInfo> guiFind = new guiFind<APBillOfLadingsInfo>(TableName.APBillOfLadingsTableName
                                                                                           , billOfLadingList
                                                                                           , this
                                                                                           , false);
        stampp:
            if (guiFind.ShowDialog() == DialogResult.OK)
            {
                if (guiFind.SelectedObjects != null && guiFind.SelectedObjects.Count > 0)
                {
                    mainObject.ACBankTransactionDesc = String.Empty;
                    foreach (APBillOfLadingsInfo item in guiFind.SelectedObjects)
                    {
                        if (!string.IsNullOrEmpty(billOfLadingNoList))
                            billOfLadingNoList += ";";
                        billOfLadingNoList += item.APBillOfLadingNo;
                        mainObject.ACBankTransactionDesc += item.APBillOfLadingDesc + Environment.NewLine;
                    }
                    List<ACDocumentEntrysInfo> documentEntryList = objDocumentEntrysController.GetEntryByBillOfLadingNoList(billOfLadingNoList);
                    if (documentEntryList != null && documentEntryList.Count > 0)
                    {
                        foreach (ACDocumentEntrysInfo entry in documentEntryList)
                        {
                            ACBankTransactionItemsInfo objBankTransactionItemsInfo = new ACBankTransactionItemsInfo();
                            objBankTransactionItemsInfo.FK_ACEntryTypeID = entry.FK_ACEntryTypeID;
                            objBankTransactionItemsInfo.ACBankTransactionItemAmount = entry.ACDocumentEntryAmount;
                            objBankTransactionItemsInfo.FK_ACDebitAccountID = entry.FK_ACCreditAccountID;
                            objBankTransactionItemsInfo.ACBankTransactionItemReference = entry.APBillOfLadingNo;
                            objBankTransactionItemsInfo.ACBankTransactionItemDesc = entry.ACDocumentEntryDesc;
                            objBankTransactionItemsInfo.ACBankTransactionItemExchangeAmount = objBankTransactionItemsInfo.ACBankTransactionItemAmount * mainObject.ACBankTransactionExchangeRate;
                            objBankTransactionItemsInfo.ACBankTransactionItemTaxAmount = objBankTransactionItemsInfo.ACBankTransactionItemAmount * objBankTransactionItemsInfo.ACBankTransactionItemTaxPercent / 100;
                            objBankTransactionItemsInfo.ACBankTransactionItemTotalAmount = objBankTransactionItemsInfo.ACBankTransactionItemAmount + objBankTransactionItemsInfo.ACBankTransactionItemTaxAmount;
                            objBankTransactionItemsInfo.ACBankTransactionItemTotalExchangeAmount = objBankTransactionItemsInfo.ACBankTransactionItemTotalAmount * mainObject.ACBankTransactionExchangeRate;
                            entity.BankTransactionItemList.Add(objBankTransactionItemsInfo);
                        }
                        entity.BankTransactionItemList.GridControl.RefreshDataSource();
                    }
                }
                else
                {
                    MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    goto stampp;
                }
            }
            else
            {
                ActionCancel();
            }
        }
        #endregion

        public override bool ActionComplete()
        {
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            if (mainObject.ACBankTransactionCreateFrom == BankTransactionCreateFrom.LoanReceipt.ToString())
            {
                if (!IsValidAmountLoanReceiptPaymentPlan())
                    return false;
            }
            if (mainObject.ACBankTransactionCreateFrom == BankTransactionCreateFrom.Normal.ToString() && mainObject.FK_ACLoanReceiptID > 0)
            {
                ACBankTransactionItemsController objBankTransactionItemsController = new ACBankTransactionItemsController();
                ACBankTransactionItemsInfo objBankTransactionItemsInfo = objBankTransactionItemsController.CreateBankTransactionItemByLoanReceiptID(mainObject.FK_ACLoanReceiptID);
                if (objBankTransactionItemsInfo != null && objBankTransactionItemsInfo.ACBankTransactionItemAmount < 0)
                {
                    ACBankTransactionItemsInfo checkBankTransactionItemsInfo = entity.BankTransactionItemList.FirstOrDefault(o => o.FK_ACDebitAccountID == objBankTransactionItemsInfo.FK_ACDebitAccountID);
                    decimal remainAmount = 0;
                    if (checkBankTransactionItemsInfo != null)
                    {
                        remainAmount = checkBankTransactionItemsInfo.ACBankTransactionItemAmount + objBankTransactionItemsInfo.ACBankTransactionItemAmount;
                        MessageBox.Show(string.Format(PaymentVoucherLocalizedResources.ErrorPaymentLoanReceipt, objBankTransactionItemsInfo.ACLoanReceiptNo, remainAmount.ToString("n2"))
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            bool isComplete = base.ActionComplete();
            if (isComplete)
            {
                mainObject.FK_HREmployeeCompletedID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                CurrentModuleEntity.UpdateMainObject();
            }
            return isComplete;
        }

        public override void ModuleAfterCompleted()
        {
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            if ((mainObject.ACBankTransactionCreateFrom == BankTransactionCreateFrom.Normal.ToString() && mainObject.FK_ACLoanReceiptID > 0) || mainObject.ACBankTransactionCreateFrom == BankTransactionCreateFrom.LoanReceipt.ToString())
            {
                CalculateExchangeRateDiffFee();
            }
            ActionPosted();
            base.ModuleAfterCompleted();
        }

        public void ChangeLoanReceipt(int loanReceiptID)
        {
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;
            ACLoanReceiptsInfo objLoanReceiptsInfo = (ACLoanReceiptsInfo)(new ACLoanReceiptsController()).GetObjectByID(loanReceiptID);
            if (objLoanReceiptsInfo != null)
            {
                mainObject.FK_ACLoanReceiptID = objLoanReceiptsInfo.ACLoanReceiptID;
                if (mainObject.ACBankTransactionCreateFrom == BankTransactionCreateFrom.Normal.ToString())
                {
                    entity.BankTransactionItemList.Clear();
                    mainObject.FK_GECurrencyID = objLoanReceiptsInfo.FK_GECurrencyID;
                    mainObject.ACBankTransactionExchangeRate = objLoanReceiptsInfo.ACLoanReceiptExchangeRate;

                    ACBankTransactionItemsController objBankTransactionItemsController = new ACBankTransactionItemsController();
                    ACBankTransactionItemsInfo objBankTransactionItemsInfo = objBankTransactionItemsController.CreateBankTransactionItemByLoanReceiptID(loanReceiptID);
                    if (objBankTransactionItemsInfo != null && objBankTransactionItemsInfo.ACBankTransactionItemAmount > 0)
                    {
                        mainObject.ACBankTransactionDesc = objBankTransactionItemsInfo.ACBankTransactionItemDesc;
                        entity.BankTransactionItemList.Add(objBankTransactionItemsInfo);
                    }
                    ChangeExchangeRate();
                }
                entity.UpdateMainObjectBindingSource();
            }
        }

        public override bool ActionCancelComplete()
        {
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            if (mainObject.ACBankTransactionID > 0)
            {
                if (!CheckLock()) return false;
                if (!CheckRelativeDocument()) return false;
                bool isComplete = base.ActionCancelComplete();
                if (isComplete)
                {
                    ActionUnPosted();
                    InvalidateToolbar();
                }
                return isComplete;
            }
            return false;
        }

        private bool CheckRelativeDocument()
        {
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            List<ACDocumentsInfo> documentsList = objDocumentsController.GetRelativeDocumentListByPaymentOrderID(mainObject.ACBankTransactionID);

            if (documentsList.Count() > 0)
            {
                MessageBox.Show(string.Format("Không thể thực hiện do đã tạo các chứng từ sau:" + Environment.NewLine + "-{0}", string.Join("\n-", documentsList.Select(o => o.ACDocumentNo).ToArray()))
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return false;
            }
            if (mainObject.ACBankTransactionCreateFrom == BankTransactionCreateFrom.LoanReceipt.ToString())
            {
                MessageBox.Show("Không thể thực hiện thao tác này với chứng từ Trả tiền lãi vay và nợ gốc cho khế ước!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public override void ModuleAfterCancelCompleted()
        {
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            entity.ModuleAfterCancelCompleted();
        }
        public override void ActionDuplicate()
        {
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;
            if (mainObject.ACBankTransactionCreateFrom != BankTransactionCreateFrom.Normal.ToString())
            {
                MessageBox.Show("Không thể tạo bản sảo cho chứng từ tạo mới khác thông thường",
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            base.ActionDuplicate();

            mainObject.ACBankTransactionStatus = BankTransactionStatus.New.ToString();
            mainObject.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            mainObject.AAUpdatedDate = DateTime.MaxValue;
            mainObject.AAUpdatedUser = String.Empty;
            mainObject.ACBankTransactionCreateFrom = BankTransactionCreateFrom.Normal.ToString();
            ToolbarNewActionName = mainObject.STToolbarActionName;
            AllowEditBankTransactionItemGridControl(true);

            entity.BankTransactionItemList.Duplicate();
            entity.BankTransactionItemList.GridControl?.RefreshDataSource();
            entity.AdvanceRequestPaymentTimeList.GridControl?.RefreshDataSource();
            entity.DocumentEntryList.GridControl?.RefreshDataSource();
        }

        #region Xử lý chênh lệch tỷ giá Trả nợ vay
        private void CalculateExchangeRateDiffFee()
        {
            PaymentOrderEntities entity = (PaymentOrderEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            GECurrenciesInfo objCurrenciesInfo = (GECurrenciesInfo)objCurrenciesController.GetObjectByID(mainObject.FK_GECurrencyID);
            if ((objCurrenciesInfo != null && objCurrenciesInfo.GECurrencyNo != CurrencyNo.VND.ToString()) || mainObject.ACBankTransactionExchangeRate != 1)
            {
                decimal tienLai = 0;
                decimal tienLo = 0;
                decimal tyGiaTT = 0;

                ACLoanReceiptsInfo objLoanReceiptsInfo = (ACLoanReceiptsInfo)(new ACLoanReceiptsController()).GetObjectByID(mainObject.FK_ACLoanReceiptID);
                if (objLoanReceiptsInfo != null)
                {
                    ACLoanReceiptTypesInfo objLoanReceiptTypesInfo = (ACLoanReceiptTypesInfo)(new ACLoanReceiptTypesController()).GetObjectByID(objLoanReceiptsInfo.FK_ACLoanReceiptTypeID);
                    if (objLoanReceiptTypesInfo != null)
                    {
                        decimal traTienGoc = entity.BankTransactionItemList.Where(o => o.FK_ACDebitAccountID == objLoanReceiptTypesInfo.FK_ACAccountID).Sum(o => o.ACBankTransactionItemAmount);
                        tyGiaTT = Math.Min(objLoanReceiptsInfo.ACLoanReceiptExchangeRate, mainObject.ACBankTransactionExchangeRate);
                        if (objLoanReceiptsInfo.ACLoanReceiptExchangeRate > mainObject.ACBankTransactionExchangeRate)
                        {
                            tienLai = traTienGoc * Math.Abs(objLoanReceiptsInfo.ACLoanReceiptExchangeRate - mainObject.ACBankTransactionExchangeRate);
                        }
                        if (objLoanReceiptsInfo.ACLoanReceiptExchangeRate < mainObject.ACBankTransactionExchangeRate)
                        {
                            tienLo = traTienGoc * Math.Abs(objLoanReceiptsInfo.ACLoanReceiptExchangeRate - mainObject.ACBankTransactionExchangeRate);
                        }
                    }
                }
                if (tienLai > 0)
                {
                    mainObject.ACBankTransactionExchangeRateDiffFee = tienLai;
                }
                else if (tienLo > 0)
                {
                    mainObject.ACBankTransactionExchangeRateDiffFee = -tienLo;
                }
                entity.UpdateMainObject();
            }
        }

        #endregion
    }
}
