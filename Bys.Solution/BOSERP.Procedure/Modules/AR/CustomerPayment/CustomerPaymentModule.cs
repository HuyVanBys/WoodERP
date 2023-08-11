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


namespace BOSERP.Modules.CustomerPayment
{
    public class CustomerPaymentModule : BaseTransactionModule
    {
        #region Constant
        public const string CustomerPaymentDetailsGridControlName = "fld_dgcARCustomerPaymentDetails";
        public const string DocumentEntryGridControlName = "fld_dgcDocumentEntrys";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        #endregion

        #region Variables
        /// <summary>
        /// A variable indicates whether the user is creating a new receipt voucher
        /// </summary>
        private bool CreateReceiptVoucher = false;

        /// <summary>
        /// A variable indicates whether the user is creating a new bank transfer
        /// </summary>
        private bool CreateBankTransfer = false;


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

        #region Public Properties

        #endregion

        #region Constructor
        public CustomerPaymentModule()
        {
            Name = "CustomerPayment";
            CurrentModuleEntity = new CustomerPaymentEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            CustomerPaymentEntities entity = (CustomerPaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentDetailsGridControl gridControl = Controls[CustomerPaymentModule.CustomerPaymentDetailsGridControlName] as ARCustomerPaymentDetailsGridControl;
            gridControl.CustomerPaymentDetailList = entity.CustomerPaymentDetailList;
            gridControl.InitGridControlDataSource();

            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[CustomerPaymentModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        }
        #endregion        

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
            ARCustomerPaymentsInfo searchObject = (ARCustomerPaymentsInfo)CurrentModuleEntity.SearchObject;
            //NUThao [EDIT] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            //DataSet ds = objCustomerPaymentsController.GetPaymentList(
            //                                                        searchObject.ARCustomerPaymentNo,
            //                                                        searchObject.ARInvoiceNo,
            //                                                        searchObject.FK_ARCustomerID,
            //                                                        searchObject.FK_HREmployeeID,
            //                                                        CustomerPaymentType.SaleOrder.ToString(),
            //                                                        searchObject.CustomerPaymentDateFrom,
            //                                                        searchObject.CustomerPaymentDateTo);

            DataSet ds = new DataSet();

            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objCustomerPaymentsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objCustomerPaymentsController.GetCustomerPaymentDatasetByListOfBranchID(
                                                                    searchObject.ARCustomerPaymentNo,
                                                                    searchObject.ARInvoiceNo,
                                                                    searchObject.FK_ACObjectID,
                                                                    searchObject.ARObjectType,
                                                                    searchObject.FK_HREmployeeID,
                                                                    CustomerPaymentType.SaleOrder.ToString(),
                                                                    searchObject.CustomerPaymentDateFrom,
                                                                    searchObject.CustomerPaymentDateTo,
                                                                    BranchList);
                }
            }
            else
            {
                ds = objCustomerPaymentsController.GetPaymentList(
                                                                    searchObject.ARCustomerPaymentNo,
                                                                    searchObject.ARInvoiceNo,
                                                                    searchObject.FK_ACObjectID,
                                                                    searchObject.ARObjectType,
                                                                    searchObject.FK_HREmployeeID,
                                                                    CustomerPaymentType.SaleOrder.ToString(),
                                                                    searchObject.FK_BRBranchID,
                                                                    searchObject.CustomerPaymentDateFrom,
                                                                    searchObject.CustomerPaymentDateTo);

            }
            //NUThao [EDIT] [08/04/2014] [DB centre] [Search document by BRBranchID], END
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

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);

            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            ARCustomerPaymentDetailsGridControl gridControl = (ARCustomerPaymentDetailsGridControl)Controls[CustomerPaymentModule.CustomerPaymentDetailsGridControlName];
            gridControl.PaymentAmount = objCustomerPaymentsInfo.ARCustomerPaymentTotalAmount;
        }

        /// <summary>
        /// Called when the user create a new receipt voucher for 
        /// a new customer payment
        /// </summary>
        public void ActionCreateReceiptVoucher()
        {
            CreateReceiptVoucher = true;

            ActionNew();
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            customerPayment.ARPaymentMethodCombo = PaymentMethod.Cash.ToString();
            ARCustomerPaymentDetailsGridControl gridControl = (ARCustomerPaymentDetailsGridControl)Controls[CustomerPaymentModule.CustomerPaymentDetailsGridControlName];
            gridControl.PaymentAmount = 0;
            gridControl.RequiredMethod = PaymentMethod.Cash.ToString();

            CreateReceiptVoucher = false;
        }

        /// <summary>
        /// Called when the user create a new bank transfer for 
        /// a new customer payment
        /// </summary>
        public void ActionCreateBankTransfer()
        {
            CreateBankTransfer = true;

            ActionNew();
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            customerPayment.ARPaymentMethodCombo = PaymentMethod.BankTransfer.ToString();
            ARCustomerPaymentDetailsGridControl gridControl = (ARCustomerPaymentDetailsGridControl)Controls[CustomerPaymentModule.CustomerPaymentDetailsGridControlName];
            gridControl.PaymentAmount = 0;
            gridControl.RequiredMethod = PaymentMethod.BankTransfer.ToString();

            CreateBankTransfer = false;
        }

        /// <summary>
        /// Called when the user create a new payment by owing
        /// </summary>
        public void ActionCreateOwingExchange()
        {
            CreateOwingExchange = true;

            ActionNew();
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            customerPayment.ARPaymentMethodCombo = PaymentMethod.OwingExchange.ToString();
            ARCustomerPaymentDetailsGridControl gridControl = (ARCustomerPaymentDetailsGridControl)Controls[CustomerPaymentModule.CustomerPaymentDetailsGridControlName];
            gridControl.PaymentAmount = 0;
            gridControl.RequiredMethod = string.Empty;
            CreateOwingExchange = false;
        }

        public override int ActionSave()
        {
            CustomerPaymentEntities entity = (CustomerPaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)entity.MainObject;
            entity.ARInvoiceList.EndCurrentEdit();
            UpdateTotalAmount();

            entity.CustomerPaymentDetailList.EndCurrentEdit();
            bool isAccepted = AcceptPayment(entity.CustomerPaymentDetailList, customerPayment.FK_ARCustomerID, customerPayment.ARCustomerPaymentTotalAmount);
            int objectID = 0;
            if (isAccepted)
            {
                SetDefaultDesc();

                objectID = base.ActionSave();
                if (objectID > 0)
                {
                    //Update backup list of invoice items
                    entity.ARInvoiceList.BackupList.Clear();
                    foreach (ARInvoicesInfo objInvoicesInfo in entity.ARInvoiceList)
                    {
                        entity.ARInvoiceList.BackupList.Add((ARInvoicesInfo)objInvoicesInfo.Clone());
                    }
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
                CustomerPaymentEntities entity = (CustomerPaymentEntities)CurrentModuleEntity;
                string invoiceNo = string.Empty;
                foreach (ARInvoicesInfo invoice in entity.ARInvoiceList)
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
                ARReceiptVouchersController objReceiptVouchersController = new ARReceiptVouchersController();
                ARReceiptVouchersInfo receiptVoucher = (ARReceiptVouchersInfo)objReceiptVouchersController.GetObjectByNo(customerPayment.ARCustomerPaymentNo);
                if (receiptVoucher != null)
                {
                    ReceiptVoucher.ReceiptVoucherModule.PrintReceiptVoucher(receiptVoucher.ARReceiptVoucherID);
                }
            }
            else if (customerPayment.ARPaymentMethodCombo == PaymentMethod.BankTransfer.ToString())
            {
                ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
                ACBankTransactionsInfo bankTransfer = (ACBankTransactionsInfo)objBankTransactionsController.GetObjectByNo(customerPayment.ARCustomerPaymentNo);
                if (bankTransfer != null)
                {
                    BankTransaction.BankTransactionModule.PrintBankTransfer(bankTransfer.ACBankTransactionID);
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

        #region Utility functions
        public static bool AcceptPayment(BOSList<ARCustomerPaymentDetailsInfo> paymentDetails, int customerID, decimal paymentAmount)
        {
            decimal totalAmount = paymentDetails.Sum(pd => pd.ARCustomerPaymentDetailAmount);
            if (totalAmount < paymentAmount)
            {
                MessageBox.Show(CommonLocalizedResources.TotalAmountCannotBeLessThanPaymentAmountMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            BOSDbUtil dbUtil = new BOSDbUtil();
            foreach (ARCustomerPaymentDetailsInfo paymentDetail in paymentDetails)
            {
                if (paymentDetail.ARCustomerPaymentDetailAmount > 0)
                {
                    if (paymentDetail.ARPaymentMethodCombo == PaymentMethod.OwingExchange.ToString())
                    {
                        //ARInvoicesController objInvoicesController = new ARInvoicesController();                        
                        //string[] invoiceNumbers = paymentDetail.ARCustomerPaymentDetailInfo.Trim().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);                        
                        //decimal totalBalanceDue = 0;
                        //foreach (string temp in invoiceNumbers)
                        //{
                        //    string invoiceNo = temp.Trim();
                        //    ARInvoicesInfo invoice = (ARInvoicesInfo)objInvoicesController.GetObjectByNo(invoiceNo);
                        //    if (invoice == null)
                        //    {
                        //        MessageBox.Show(string.Format(CommonLocalizedResources.InvoiceDoesNotExistMessage, invoiceNo),
                        //                        CommonLocalizedResources.MessageBoxDefaultCaption,
                        //                        MessageBoxButtons.OK,
                        //                        MessageBoxIcon.Error);
                        //        return false;
                        //    }
                        //    //invoice.ARInvoiceBalanceDue = objInvoicesController.GetInvoiceBalance(invoiceNo);
                        //    decimal dueAmount = 0;
                        //    if (paymentDetails.BackupList != null)
                        //    {
                        //        ARCustomerPaymentDetailsInfo oldPaymentDetail = paymentDetails.BackupList.Where(pd => pd.ARPaymentMethodCombo == paymentDetail.ARPaymentMethodCombo)
                        //                                                                                .FirstOrDefault();
                        //        if (oldPaymentDetail != null)
                        //        {
                        //            string[] oldInvoiceNumbers = oldPaymentDetail.ARCustomerPaymentDetailInfo.Trim().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        //            for (int i = 0; i < oldInvoiceNumbers.Length; i++)
                        //            {
                        //                if (oldInvoiceNumbers[i].Trim().ToLower() == invoiceNo.ToLower())
                        //                {
                        //                    dueAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(oldPaymentDetail, string.Format("ARCustomerPaymentDetailSubAmount{0}", i + 1)));
                        //                }
                        //            }
                        //        }
                        //    }
                        //    decimal balanceDue = invoice.ARInvoiceBalanceDue - dueAmount;
                        //    if (balanceDue >= 0)
                        //    {
                        //        MessageBox.Show(string.Format(CommonLocalizedResources.InvoiceHasNoNegativeOwingMessage, invoiceNo),
                        //                        CommonLocalizedResources.MessageBoxDefaultCaption,
                        //                        MessageBoxButtons.OK,
                        //                        MessageBoxIcon.Error);
                        //        return false;
                        //    }

                        //    totalBalanceDue += Math.Abs(balanceDue);
                        //}
                        //if (totalBalanceDue < paymentDetail.ARCustomerPaymentDetailAmount)
                        //{
                        //    MessageBox.Show(CommonLocalizedResources.OwingExchangePaymentExceedsRemainedAmountMessage,
                        //                    CommonLocalizedResources.MessageBoxDefaultCaption,
                        //                    MessageBoxButtons.OK,
                        //                    MessageBoxIcon.Error);
                        //    return false;
                        //}
                    }
                    else if (paymentDetail.ARPaymentMethodCombo == PaymentMethod.DepositTransfer.ToString())
                    {
                        ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
                        string[] depositNumbers = paymentDetail.ARCustomerPaymentDetailInfo.Trim().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string temp in depositNumbers)
                        {
                            string depositNo = temp.Trim();
                            ARCustomerPaymentsInfo deposit = (ARCustomerPaymentsInfo)objCustomerPaymentsController.GetObjectByNo(depositNo);
                            if (deposit == null)
                            {
                                MessageBox.Show(string.Format(CommonLocalizedResources.DepositDoesNotExistMessage, depositNo),
                                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        if (depositNumbers == null || depositNumbers.Length == 0)
                        {
                            MessageBox.Show(CommonLocalizedResources.InputDepositNumberForTranferingMessage,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else if (paymentDetail.ARPaymentMethodCombo == PaymentMethod.CreditNote.ToString())
                    {
                        ARCreditNotesController objCreditNotesController = new ARCreditNotesController();
                        ARCreditNotesInfo objCreditNotesInfo = (ARCreditNotesInfo)objCreditNotesController.GetCreditNoteByNoAndType(paymentDetail.ARCustomerPaymentDetailInfo.Trim(), CreditNoteType.CreditNote.ToString());
                        if (objCreditNotesInfo == null)
                        {
                            MessageBox.Show(CommonLocalizedResources.CreditNoteDoesNotExistMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        if (objCreditNotesInfo.ARCreditNoteExpiryDate.CompareTo(DateTime.Now) < 0)
                        {
                            MessageBox.Show(
                                            string.Format(CommonLocalizedResources.CreditNoteHasExpiredMessage, objCreditNotesInfo.ARCreditNoteExpiryDate.ToShortDateString()),
                                            CommonLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            return false;
                        }
                        if (objCreditNotesInfo.ARCreditNoteRemainedAmount < paymentDetail.ARCustomerPaymentDetailAmount)
                        {
                            MessageBox.Show(string.Format(CommonLocalizedResources.CreditNotePaymentExceedsRemainingAmountMessage, BOSUtil.GetNumberDisplayFormat(objCreditNotesInfo.ARCreditNoteRemainedAmount)),
                                            CommonLocalizedResources.MessageBoxDefaultCaption,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else if (paymentDetail.ARPaymentMethodCombo == PaymentMethod.GiftVoucher.ToString())
                    {
                        //ARCreditNotesController objCreditNotesController = new ARCreditNotesController();
                        //string[] creditNoteNumbers = paymentDetail.ARCustomerPaymentDetailInfo.Trim().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        //decimal totalCreditNoteAmount = 0;
                        //foreach (string temp in creditNoteNumbers)
                        //{
                        //    string creditNoteNo = temp.Trim();
                        //    ARCreditNotesInfo objCreditNotesInfo = (ARCreditNotesInfo)objCreditNotesController.GetCreditNoteByNoAndType(creditNoteNo, CreditNoteType.GiftVoucher.ToString());
                        //    if (objCreditNotesInfo == null)
                        //    {
                        //        MessageBox.Show(string.Format(CommonLocalizedResources.GiftVoucherDoesNotExistMessage, creditNoteNo),
                        //                    CommonLocalizedResources.MessageBoxDefaultCaption,
                        //                    MessageBoxButtons.OK,
                        //                    MessageBoxIcon.Error);
                        //        return false;
                        //    }
                        //    if (objCreditNotesInfo.ARCreditNoteExpiryDate.CompareTo(DateTime.Now) < 0)
                        //    {
                        //        MessageBox.Show(string.Format(CommonLocalizedResources.GiftVoucherHasExpiredMessage, creditNoteNo, objCreditNotesInfo.ARCreditNoteExpiryDate.ToShortDateString()),
                        //                        CommonLocalizedResources.MessageBoxDefaultCaption,
                        //                        MessageBoxButtons.OK,
                        //                        MessageBoxIcon.Error);
                        //        return false;
                        //    }

                        //    decimal dueAmount = 0;
                        //    if (paymentDetails.BackupList != null)
                        //    {
                        //        ARCustomerPaymentDetailsInfo oldPaymentDetail = paymentDetails.BackupList.Where(pd => pd.ARPaymentMethodCombo == paymentDetail.ARPaymentMethodCombo).FirstOrDefault();
                        //        if (oldPaymentDetail != null)
                        //        {
                        //            string[] oldCreditNoteNumbers = oldPaymentDetail.ARCustomerPaymentDetailInfo.Trim().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        //            for (int i = 0; i < oldCreditNoteNumbers.Length; i++)
                        //            {
                        //                if (oldCreditNoteNumbers[i].Trim().ToLower() == creditNoteNo.ToLower())
                        //                {
                        //                    dueAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(oldPaymentDetail, string.Format("ARCustomerPaymentDetailSubAmount{0}", i + 1)));
                        //                }
                        //            }
                        //        }
                        //    }
                        //    totalCreditNoteAmount += objCreditNotesInfo.ARCreditNoteRemainedAmount + dueAmount;
                        //}

                        //if (totalCreditNoteAmount < paymentDetail.ARCustomerPaymentDetailAmount)
                        //{
                        //    MessageBox.Show(CommonLocalizedResources.GiftVoucherPaymentExceedsRemainingAmountMessage,
                        //                    CommonLocalizedResources.MessageBoxDefaultCaption,
                        //                    MessageBoxButtons.OK,
                        //                    MessageBoxIcon.Error);
                        //    return false;
                        //}
                    }
                }
            }
            return true;
        }

        public static bool AcceptRefund(BOSList<ARCustomerPaymentDetailsInfo> lstPayments, decimal totalRefund, ref decimal refundAmount)
        {
            refundAmount = 0;
            foreach (ARCustomerPaymentDetailsInfo objCustomerPaymentDetailsInfo in lstPayments)
                refundAmount += objCustomerPaymentDetailsInfo.ARCustomerPaymentDetailAmount;
            if (refundAmount < totalRefund)
            {
                MessageBox.Show("The refund amount is less than the total refund.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static ARCustomerPaymentsInfo TakePayment(AROpenDocumentsInfo objOpenDocumentsInfo, decimal totalAmount, BOSList<ARCustomerPaymentDetailsInfo> lstPaymentDetails)
        {
            if (objOpenDocumentsInfo.AROpenDocumentID > 0)
            {
                ARCustomerPaymentsInfo objCustomerPaymentsInfo = CreateCustomerPayments(objOpenDocumentsInfo, totalAmount);
                if (objCustomerPaymentsInfo.ARCustomerPaymentID > 0)
                {
                    ARDocumentPaymentsInfo objDocumentPaymentsInfo = CreateDocumentPayments(objOpenDocumentsInfo, objCustomerPaymentsInfo, totalAmount);
                    CreateCustomerPaymentDetails(objCustomerPaymentsInfo, lstPaymentDetails);
                    return objCustomerPaymentsInfo;
                }
            }
            return null;
        }

        public static ARCustomerPaymentsInfo TakePayment(AROpenDocumentsInfo objOpenDocumentsInfo, decimal totalAmount, BOSList<ARPOSPaymentDetailsInfo> lstPaymentDetails)
        {
            if (objOpenDocumentsInfo.AROpenDocumentID > 0)
            {
                ARCustomerPaymentsInfo objCustomerPaymentsInfo = CreateCustomerPayments(objOpenDocumentsInfo, totalAmount);
                if (objCustomerPaymentsInfo.ARCustomerPaymentID > 0)
                {
                    ARDocumentPaymentsInfo objDocumentPaymentsInfo = CreateDocumentPayments(objOpenDocumentsInfo, objCustomerPaymentsInfo, totalAmount);
                    return objCustomerPaymentsInfo;
                }
            }
            return null;
        }

        public static void TakePayment(AROpenDocumentsInfo objOpenDocumentsInfo, decimal totalAmount)
        {
            if (objOpenDocumentsInfo.AROpenDocumentID > 0)
            {
                ARCustomerPaymentsInfo objCustomerPaymentsInfo = CreateCustomerPayments(objOpenDocumentsInfo, totalAmount);
                if (objCustomerPaymentsInfo.ARCustomerPaymentID > 0)
                {
                    ARDocumentPaymentsInfo objDocumentPaymentsInfo = CreateDocumentPayments(objOpenDocumentsInfo, objCustomerPaymentsInfo, totalAmount);
                }
            }
        }

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
            return CustomerPaymentModule.CreateDocumentPayments(objOpenDocumentsInfo, objCustomerPaymentsInfo, totalAmount, 1);
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

        public static void CreateCustomerPaymentDetails(ARCustomerPaymentsInfo objCustomerPaymentsInfo, BOSList<ARCustomerPaymentDetailsInfo> lstPaymentDetails)
        {
            ARCustomerPaymentDetailsController objCustomerPaymentDetailsController = new ARCustomerPaymentDetailsController();
            if (lstPaymentDetails != null)
            {
                foreach (ARCustomerPaymentDetailsInfo objCustomerPaymentDetailsInfo in lstPaymentDetails)
                {
                    UpdateRelativeDataOfPaymentDetail(objCustomerPaymentDetailsInfo, objCustomerPaymentsInfo.FK_ARCustomerID);

                    objCustomerPaymentDetailsInfo.FK_ARCustomerPaymentID = objCustomerPaymentsInfo.ARCustomerPaymentID;
                    objCustomerPaymentDetailsController.CreateObject(objCustomerPaymentDetailsInfo);

                    if (objCustomerPaymentDetailsInfo.PaymentCurrencys != null)
                    {
                        ARCustomerPaymentCurrencysController objCustomerPaymentCurrencysController = new ARCustomerPaymentCurrencysController();
                        foreach (ARCustomerPaymentCurrencysInfo objCustomerPaymentCurrencysInfo in objCustomerPaymentDetailsInfo.PaymentCurrencys)
                        {
                            objCustomerPaymentCurrencysInfo.FK_ARCustomerPaymentDetailID = objCustomerPaymentDetailsInfo.ARCustomerPaymentDetailID;
                            objCustomerPaymentCurrencysController.CreateObject(objCustomerPaymentCurrencysInfo);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Update customer payment details of a payment
        /// </summary>
        /// <param name="customerPayment">Customer payment object</param>
        /// <param name="paymentDetails">List of payment details</param>
        public static void UpdateCustomerPaymentDetails(ARCustomerPaymentsInfo customerPayment, List<ARCustomerPaymentDetailsInfo> paymentDetails)
        {
            ARCustomerPaymentDetailsController objCustomerPaymentDetailsController = new ARCustomerPaymentDetailsController();
            ARCustomerPaymentCurrencysController objCustomerPaymentCurrencysController = new ARCustomerPaymentCurrencysController();
            List<ARCustomerPaymentDetailsInfo> oldPaymentDetails = objCustomerPaymentDetailsController.GetDetailsByPaymentID(customerPayment.ARCustomerPaymentID);
            foreach (ARCustomerPaymentDetailsInfo oldPaymentDetail in oldPaymentDetails)
            {
                RollbackRelativeDataOfPaymentDetail((ARCustomerPaymentDetailsInfo)oldPaymentDetail);
            }
            foreach (ARCustomerPaymentDetailsInfo paymentDetail in paymentDetails)
            {
                ARCustomerPaymentDetailsInfo oldPaymentDetail = oldPaymentDetails.Where(pd => pd.ARPaymentMethodCombo == paymentDetail.ARPaymentMethodCombo).FirstOrDefault();
                if (oldPaymentDetail != null)
                {
                    UpdateRelativeDataOfPaymentDetail(paymentDetail, customerPayment.FK_ARCustomerID);

                    paymentDetail.FK_ARCustomerPaymentID = oldPaymentDetail.FK_ARCustomerPaymentID;
                    paymentDetail.ARCustomerPaymentDetailID = oldPaymentDetail.ARCustomerPaymentDetailID;
                    objCustomerPaymentDetailsController.UpdateObject(paymentDetail);

                    objCustomerPaymentCurrencysController.DeleteByForeignColumn("FK_ARCustomerPaymentDetailID", paymentDetail.ARCustomerPaymentDetailID);
                    if (paymentDetail.PaymentCurrencys != null)
                    {
                        foreach (ARCustomerPaymentCurrencysInfo objCustomerPaymentCurrencysInfo in paymentDetail.PaymentCurrencys)
                        {
                            objCustomerPaymentCurrencysInfo.FK_ARCustomerPaymentDetailID = paymentDetail.ARCustomerPaymentDetailID;
                            objCustomerPaymentCurrencysController.CreateObject(objCustomerPaymentCurrencysInfo);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Rollback relative data of a payment detail
        /// </summary>
        /// <param name="paymentDetail">Given payment detail</param>
        public static void RollbackRelativeDataOfPaymentDetail(ARCustomerPaymentDetailsInfo paymentDetail)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            if (paymentDetail.ARPaymentMethodCombo == PaymentMethod.OwingExchange.ToString())
            {
                ARInvoicesController objInvoicesController = new ARInvoicesController();
                string[] invoiceNumbers = paymentDetail.ARCustomerPaymentDetailInfo.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                decimal paymentAmount = paymentDetail.ARCustomerPaymentDetailAmount;
                for (int i = 0; i < invoiceNumbers.Length; i++)
                {
                    string invoiceNo = invoiceNumbers[i].Trim();
                    if (paymentAmount > 0)
                    {
                        ARInvoicesInfo invoice = (ARInvoicesInfo)objInvoicesController.GetObjectByNo(invoiceNo);
                        if (invoice != null)
                        {
                            decimal dueAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(paymentDetail, string.Format("ARCustomerPaymentDetailSubAmount{0}", i + 1)));
                            invoice.ARInvoiceBalanceDue -= dueAmount;
                            objInvoicesController.UpdateObject(invoice);
                            paymentAmount -= dueAmount;
                        }
                    }
                }
            }
            else if (paymentDetail.ARPaymentMethodCombo == PaymentMethod.CreditNote.ToString() ||
                       paymentDetail.ARPaymentMethodCombo == PaymentMethod.GiftVoucher.ToString())
            {
                ARCreditNotesController objCreditNotesController = new ARCreditNotesController();
                string[] creditNoteNumbers = paymentDetail.ARCustomerPaymentDetailInfo.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                decimal paymentAmount = paymentDetail.ARCustomerPaymentDetailAmount;
                for (int i = 0; i < creditNoteNumbers.Length; i++)
                {
                    string creditNoteNo = creditNoteNumbers[i].Trim();
                    if (paymentAmount > 0)
                    {
                        ARCreditNotesInfo objCreditNotesInfo = (ARCreditNotesInfo)objCreditNotesController.GetObjectByNo(creditNoteNo);
                        if (objCreditNotesInfo != null)
                        {
                            decimal dueAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(paymentDetail, string.Format("ARCustomerPaymentDetailSubAmount{0}", i + 1)));
                            objCreditNotesInfo.ARCreditNoteDueAmount -= dueAmount;
                            objCreditNotesController.UpdateObject(objCreditNotesInfo);
                            paymentAmount -= dueAmount;
                        }
                    }
                }
            }
            else if (paymentDetail.ARPaymentMethodCombo == PaymentMethod.DepositTransfer.ToString())
            {
                ARCustomerPaymentsController customerPaymentController = new ARCustomerPaymentsController();
                ARSaleOrdersController saleOrderController = new ARSaleOrdersController();

                string[] customerPaymentNumbers = paymentDetail.ARCustomerPaymentDetailInfo.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                decimal paymentAmount = paymentDetail.ARCustomerPaymentDetailAmount;
                for (int i = 0; i < customerPaymentNumbers.Length; i++)
                {
                    string customerPaymentNo = customerPaymentNumbers[i].Trim();
                    if (paymentAmount > 0)
                    {
                        ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)customerPaymentController.GetObjectByNo(customerPaymentNo);
                        if (customerPayment != null)
                        {
                            ARSaleOrdersInfo saleOrder = saleOrderController.GetSaleOrderByDepositNo(customerPaymentNo);
                            decimal dueAmount = Convert.ToDecimal(dbUtil.GetPropertyValue(paymentDetail, string.Format("ARCustomerPaymentDetailSubAmount{0}", i + 1)));
                            saleOrder.ARSaleOrderDepositBalance += dueAmount;
                            saleOrder.ARSaleOrderBalanceDue -= dueAmount;
                            saleOrderController.UpdateObject(saleOrder);
                            paymentAmount -= dueAmount;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Update relative data of a payment detail
        /// </summary>
        /// <param name="paymentDetail">Given payment detail</param>
        /// <param name="customerID">Customer id</param>
        private static void UpdateRelativeDataOfPaymentDetail(ARCustomerPaymentDetailsInfo paymentDetail, int customerID)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            if (paymentDetail.ARCustomerPaymentDetailAmount != 0)
            {
                if (paymentDetail.ARPaymentMethodCombo == PaymentMethod.Account.ToString())
                {
                    ARCustomersController objCustomersController = new ARCustomersController();
                    ARCustomersInfo objCustomersInfo = (ARCustomersInfo)objCustomersController.GetObjectByID(customerID);
                    if (objCustomersInfo != null)
                    {
                        objCustomersInfo.AAUpdatedUser = BOSApp.CurrentUser;
                        objCustomersInfo.AAUpdatedDate = DateTime.Now;
                        objCustomersInfo.ARCustomerOwing += paymentDetail.ARCustomerPaymentDetailAmount;
                        objCustomersController.UpdateObject(objCustomersInfo);
                    }
                }
                else if (paymentDetail.ARPaymentMethodCombo == PaymentMethod.OwingExchange.ToString())
                {
                    ARInvoicesController objInvoicesController = new ARInvoicesController();
                    string[] invoiceNumbers = paymentDetail.ARCustomerPaymentDetailInfo.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    decimal paymentAmount = paymentDetail.ARCustomerPaymentDetailAmount;
                    for (int i = 0; i < invoiceNumbers.Length; i++)
                    {
                        string invoiceNo = invoiceNumbers[i].Trim();
                        if (paymentAmount > 0)
                        {
                            ARInvoicesInfo invoice = (ARInvoicesInfo)objInvoicesController.GetObjectByNo(invoiceNo);
                            if (invoice != null)
                            {
                                decimal dueAmount = Math.Min(Math.Abs(invoice.ARInvoiceBalanceDue), paymentAmount);
                                invoice.ARInvoiceBalanceDue += dueAmount;
                                objInvoicesController.UpdateObject(invoice);
                                paymentAmount -= dueAmount;
                                dbUtil.SetPropertyValue(paymentDetail, string.Format("ARCustomerPaymentDetailSubAmount{0}", i + 1), dueAmount);
                            }
                        }
                    }
                }
                else if (paymentDetail.ARPaymentMethodCombo == PaymentMethod.CreditNote.ToString() ||
                        paymentDetail.ARPaymentMethodCombo == PaymentMethod.GiftVoucher.ToString())
                {
                    ARCreditNotesController objCreditNotesController = new ARCreditNotesController();
                    string[] creditNoteNumbers = paymentDetail.ARCustomerPaymentDetailInfo.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    decimal paymentAmount = paymentDetail.ARCustomerPaymentDetailAmount;
                    for (int i = 0; i < creditNoteNumbers.Length; i++)
                    {
                        string creditNoteNo = creditNoteNumbers[i].Trim();
                        if (paymentAmount > 0)
                        {
                            ARCreditNotesInfo objCreditNotesInfo = (ARCreditNotesInfo)objCreditNotesController.GetObjectByNo(creditNoteNo);
                            if (objCreditNotesInfo != null)
                            {
                                decimal dueAmount = Math.Min(objCreditNotesInfo.ARCreditNoteTotalAmount - objCreditNotesInfo.ARCreditNoteDueAmount, paymentAmount);
                                objCreditNotesInfo.ARCreditNoteDueAmount += dueAmount;
                                objCreditNotesController.UpdateObject(objCreditNotesInfo);
                                paymentAmount -= dueAmount;
                                dbUtil.SetPropertyValue(paymentDetail, string.Format("ARCustomerPaymentDetailSubAmount{0}", i + 1), dueAmount);
                            }
                        }
                    }
                }
                else if (paymentDetail.ARPaymentMethodCombo == PaymentMethod.DepositTransfer.ToString())
                {
                    ARCustomerPaymentsController customerPaymentController = new ARCustomerPaymentsController();
                    ARSaleOrdersController saleOrderController = new ARSaleOrdersController();

                    string[] customerPaymentNumbers = paymentDetail.ARCustomerPaymentDetailInfo.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    decimal paymentAmount = paymentDetail.ARCustomerPaymentDetailAmount;
                    for (int i = 0; i < customerPaymentNumbers.Length; i++)
                    {
                        string customerPaymentNo = customerPaymentNumbers[i].Trim();
                        if (paymentAmount > 0)
                        {
                            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)customerPaymentController.GetObjectByNo(customerPaymentNo);
                            if (customerPayment != null)
                            {
                                ARSaleOrdersInfo saleOrder = saleOrderController.GetSaleOrderByDepositNo(customerPaymentNo);
                                decimal transferedAmount = customerPaymentController.GetTransferedDepositAmountByASpecifiedDeposit(customerPayment.ARCustomerPaymentNo);
                                decimal balance = customerPayment.ARCustomerPaymentTotalAmount - transferedAmount;
                                decimal dueAmount = Math.Min(Math.Abs(balance), paymentAmount);
                                saleOrder.ARSaleOrderDepositBalance -= dueAmount;
                                saleOrder.ARSaleOrderBalanceDue += dueAmount;
                                saleOrderController.UpdateObject(saleOrder);
                                paymentAmount -= dueAmount;
                                dbUtil.SetPropertyValue(paymentDetail, string.Format("ARCustomerPaymentDetailSubAmount{0}", i + 1), dueAmount);
                            }
                        }
                    }
                }
            }
        }
        #endregion

        /// <summary>
        /// Show owing invoices of a customer
        /// </summary>
        /// <param name="customerID">Customer id</param>
        public void ShowOwingInvoices(int customerID)
        {
            guiOwingInvoice guiOwingInvoice = new guiOwingInvoice();
            guiOwingInvoice.Module = this;
            if (guiOwingInvoice.ShowDialog() == DialogResult.OK)
            {
                AddItemToInvoiceList();
            }
        }

        /// <summary>
        ///  Get all owing invoice
        /// </summary>
        /// <param name="invoiceNo">The invoice no control's BOSTextBox</param>
        /// <param name="searchFromInvoiceDate">The search from invoice date control's BOSDateEdit</param>
        /// <param name="searchToInvoiceDate">The invoice to invoice date control's BOSDateEdit</param>
        /// <param name="chkSelectAllOwingInvoice">The control check select owing invoice</param>
        public void GetAllOwingInvoices(string invoiceNo, DateTime searchFromInvoiceDate, DateTime searchToInvoiceDate, BOSCheckEdit chkSelectAllOwingInvoice)
        {
            CustomerPaymentEntities entity = (CustomerPaymentEntities)CurrentModuleEntity;
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
            CustomerPaymentEntities entity = (CustomerPaymentEntities)CurrentModuleEntity;
            if (chkSelectAllOwingInvoice.Checked == true)
                entity.OwingInvoicesList.ForEach(invoice => invoice.Selected = true);
            else
                entity.OwingInvoicesList.ForEach(invoice => invoice.Selected = false);
            entity.OwingInvoicesList.GridControl.RefreshDataSource();
        }

        /// <summary>
        /// Add owing inovices after check to invoice list
        /// </summary>
        public void AddItemToInvoiceList()
        {
            CustomerPaymentEntities entity = (CustomerPaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)entity.MainObject;
            foreach (ARInvoicesInfo objInvoicesInfo in entity.OwingInvoicesList)
            {
                if (objInvoicesInfo.Selected && !entity.ARInvoiceList.Exists(i => i.ARInvoiceID == objInvoicesInfo.ARInvoiceID))
                {
                    objCustomerPaymentsInfo.FK_ARCustomerID = objInvoicesInfo.FK_ARCustomerID;
                    objInvoicesInfo.ARDocumentPaymentExchangeRate = 1;
                    entity.ARInvoiceList.Add(objInvoicesInfo);
                }
            }
            entity.ARInvoiceList.GridControl.InvalidateLookupEditColumns();
            entity.ARInvoiceList.GridControl.RefreshDataSource();
            entity.UpdateMainObjectBindingSource();
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

                CustomerPaymentEntities entity = (CustomerPaymentEntities)CurrentModuleEntity;
                ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)entity.MainObject;
                //objCustomerPaymentsInfo.ARCustomerPaymentTotalAmount = entity.DocumentEntryList.Sum(e => e.ACDocumentEntryAmount);
                objCustomerPaymentsInfo.ARCustomerPaymentTotalAmount = entity.ARInvoiceList.Sum(e => e.ARDocumentPaymentAmount);
                BOSApp.RoundByCurrency(objCustomerPaymentsInfo, "ARCustomerPaymentTotalAmount", objCustomerPaymentsInfo.FK_GECurrencyID);
                objCustomerPaymentsInfo.ARCustomerPaymentExchangeAmount = objCustomerPaymentsInfo.ARCustomerPaymentTotalAmount * objCustomerPaymentsInfo.ARCustomerPaymentExchangeRate;
                BOSApp.RoundByCurrency(objCustomerPaymentsInfo, "ARCustomerPaymentExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                entity.UpdateMainObjectBindingSource();

                ARCustomerPaymentDetailsGridControl gridControl = (ARCustomerPaymentDetailsGridControl)Controls[CustomerPaymentModule.CustomerPaymentDetailsGridControlName];
                gridControl.PaymentAmount = objCustomerPaymentsInfo.ARCustomerPaymentTotalAmount;
                gridControl.ProposeRemainingAmount();
            }
        }

        /// <summary>
        /// Delete selected invoice from invoice list
        /// </summary>
        public void DeleteSelectedInvoice()
        {
            CustomerPaymentEntities entity = (CustomerPaymentEntities)CurrentModuleEntity;
            entity.ARInvoiceList.RemoveSelectedRowObjectFromList();
            UpdateTotalAmount();
        }

        /// <summary>
        /// Called when user wants to change the bank
        /// </summary>
        public void ChangeBank(int bankID)
        {
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(bankID);
            if (objCompanyBanksInfo != null)
            {
                objCustomerPaymentsInfo.ARCustomerPaymentBankAccount = objCompanyBanksInfo.CSCompanyBankAccount;
                CurrentModuleEntity.UpdateMainObjectBindingSource();
            }
        }

        /// <summary>
        /// Called when the user changes the customer
        /// </summary>
        /// <param name="customerID">Selected customer id</param>
        public void ChangeCustomer(int customerID)
        {
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)CurrentModuleEntity.MainObject;
            customerPayment.FK_ARCustomerID = customerID;
            if (!Toolbar.IsNullOrNoneAction())
            {
                ARCustomersController objCustomersController = new ARCustomersController();
                ARCustomersInfo customer = (ARCustomersInfo)objCustomersController.GetObjectByID(customerID);
                if (customer != null)
                {
                    customerPayment.ARCustomerPaymentSenderName = customer.ARCustomerName;
                }
            }
        }

        /// <summary>
        /// Check whether selected owing invoices is valid
        /// </summary>
        /// <returns>True if valid, otherwise false</returns>
        public bool CheckForValidOwingInvoices()
        {
            CustomerPaymentEntities entity = (CustomerPaymentEntities)CurrentModuleEntity;
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
            CustomerPaymentEntities entity = (CustomerPaymentEntities)CurrentModuleEntity;
            if (CreateReceiptVoucher)
            {
                GenerateAccountingData(new string[] { AccDocumentType.PhieuThu.ToString() });
                List<ACDocumentEntrysInfo> entries = entity.DocumentEntryList.Where(e => e.ACEntryTypeName == AccEntryType.ThuTienKhachHang.ToString()).ToList();
                entity.DocumentEntryList.Invalidate(entries);
            }
            else if (CreateBankTransfer)
            {
                GenerateAccountingData(new string[] { AccDocumentType.NopTienVaoTaiKhoan.ToString() });
                List<ACDocumentEntrysInfo> entries = entity.DocumentEntryList.Where(e => e.ACEntryTypeName == AccEntryType.ThuTienKhachHang.ToString()).ToList();
                entity.DocumentEntryList.Invalidate(entries);
            }
            else if (CreateOwingExchange)
            {
                GenerateAccountingData(new string[] { AccDocumentType.NghiepVuKhac.ToString() });
                entity.DocumentEntryList.Invalidate(new List<ACDocumentEntrysInfo>());
            }
        }

        protected override void UpdateDocumentEntries()
        {
            CustomerPaymentEntities entity = (CustomerPaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)entity.MainObject;
            foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
            {
                if (entry.ACEntryTypeName == AccEntryType.ThuTienKhachHang.ToString())
                {
                    if (entity.ARInvoiceList.Count > 0)
                    {
                        entry.ACDocumentEntryAmount = entity.ARInvoiceList.Sum(i => i.ARDocumentPaymentAmount);
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
            CustomerPaymentEntities entity = (CustomerPaymentEntities)CurrentModuleEntity;
            ARCustomerPaymentsInfo mainObject = (ARCustomerPaymentsInfo)entity.MainObject;
            mainObject.FK_GECurrencyID = currencieID;
            foreach (ARCustomerPaymentDetailsInfo item in entity.CustomerPaymentDetailList)
            {
                BOSApp.RoundByCurrency(item, mainObject.FK_GECurrencyID);
            }
            UpdateTotalAmount();
            entity.CustomerPaymentDetailList.GridControl.RefreshDataSource();

            entity.UpdateMainObjectBindingSource();
        }
    }
}
