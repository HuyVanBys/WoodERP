using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.CustomerPayment
{
    public class CustomerPaymentEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or set the invoice list
        /// </summary>
        public BOSList<ARInvoicesInfo> ARInvoiceList { get; set; }
        /// <summary>
        /// Gets or sets the payment details of the customer payment
        /// </summary>
        public BOSList<ARCustomerPaymentDetailsInfo> CustomerPaymentDetailList { get; set; }

        /// <summary>
        /// Gets or sets the owing invoice list
        /// </summary>
        public BOSList<ARInvoicesInfo> OwingInvoicesList { get; set; }
        #endregion

        #region Constructor
        public CustomerPaymentEntities()
            : base()
        {
            ARInvoiceList = new BOSList<ARInvoicesInfo>();
            OwingInvoicesList = new BOSList<ARInvoicesInfo>();
            CustomerPaymentDetailList = new BOSList<ARCustomerPaymentDetailsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ARCustomerPaymentsInfo();
            SearchObject = new ARCustomerPaymentsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ARInvoicesTableName, new ARInvoicesInfo());
            ModuleObjects.Add(TableName.ARCustomerPaymentDetailsTableName, new ARCustomerPaymentDetailsInfo());
        }

        public override void InitModuleObjectList()
        {
            ARInvoiceList.InitBOSList(
                                          this,
                                          string.Empty,
                                          TableName.ARInvoicesTableName,
                                          BOSList<ARInvoicesInfo>.cstRelationNone);

            CustomerPaymentDetailList.InitBOSList(
                                                this,
                                                string.Empty,
                                                TableName.ARCustomerPaymentDetailsTableName);

            OwingInvoicesList.InitBOSList(
                                          this,
                                          string.Empty,
                                          TableName.ARInvoicesTableName,
                                          BOSList<ARInvoicesInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            ARInvoiceList.InitBOSListGridControl();
            OwingInvoicesList.InitBOSListGridControl();
            CustomerPaymentDetailList.InitBOSListGridControl(CustomerPaymentModule.CustomerPaymentDetailsGridControlName);
            DocumentEntryList.InitBOSListGridControl(CustomerPaymentModule.DocumentEntryGridControlName);
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)MainObject;
            objCustomerPaymentsInfo.ARCustomerPaymentType = CustomerPaymentType.SaleOrder.ToString();
            objCustomerPaymentsInfo.ARCustomerPaymentDate = DateTime.Now;
            objCustomerPaymentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objCustomerPaymentsInfo.ARCustomerPaymentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objCustomerPaymentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objCustomerPaymentsInfo.ARCustomerPaymentDesc = CustomerPaymentLocalizedResources.CustomerPaymentDefaultDesc;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ARInvoiceList.SetDefaultListAndRefreshGridControl();
                OwingInvoicesList.SetDefaultListAndRefreshGridControl();
                List<ARCustomerPaymentDetailsInfo> paymentDetails = GetDefaultPaymentMethods();
                CustomerPaymentDetailList.Invalidate(paymentDetails);
            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion

        #region Invalidate Main Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)MainObject;
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            List<ARInvoicesInfo> invoices = objInvoicesController.GetInvoicesByCustomerPaymentID(objCustomerPaymentsInfo.ARCustomerPaymentID);
            ARInvoiceList.Invalidate(invoices);

            ARCustomerPaymentDetailsController objCustomerPaymentDetailsController = new ARCustomerPaymentDetailsController();
            DataSet ds = objCustomerPaymentDetailsController.GetAllDataByForeignColumn("FK_ARCustomerPaymentID", objCustomerPaymentsInfo.ARCustomerPaymentID);
            CustomerPaymentDetailList.Invalidate(ds);
        }

        #endregion

        #region Save Module Objects functions
        public override string GetMainObjectNo(ref int numberingStart)
        {
            string mainObjectNo = string.Empty;
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)MainObject;
            if (customerPayment.ARPaymentMethodCombo == PaymentMethod.Cash.ToString())
            {
                mainObjectNo = BOSApp.GetMainObjectNo(ModuleName.ReceiptVoucher, customerPayment);
            }
            else if (customerPayment.ARPaymentMethodCombo == PaymentMethod.BankTransfer.ToString())
            {
                mainObjectNo = BOSApp.GetMainObjectNo(ModuleName.BankTransaction, customerPayment);
            }
            else if (customerPayment.ARPaymentMethodCombo == PaymentMethod.OwingExchange.ToString())
            {
                mainObjectNo = BOSApp.GetMainObjectNo(ModuleName.Document, customerPayment);
            }
            else if (customerPayment.ARPaymentMethodCombo == PaymentMethod.CreditCard.ToString())
            {
                mainObjectNo = BOSApp.GetMainObjectNo(ModuleName.Document, customerPayment);
            }
            return mainObjectNo;
        }

        public override void UpdateObjectNumbering(int numberingStart)
        {
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)MainObject;
            if (customerPayment.ARPaymentMethodCombo == PaymentMethod.Cash.ToString())
            {
                BOSApp.UpdateObjectNumbering(ModuleName.ReceiptVoucher);
            }
            else if (customerPayment.ARPaymentMethodCombo == PaymentMethod.BankTransfer.ToString())
            {
                BOSApp.UpdateObjectNumbering(ModuleName.BankTransaction);
            }
            else if (customerPayment.ARPaymentMethodCombo == PaymentMethod.OwingExchange.ToString())
            {
                BOSApp.UpdateObjectNumbering(ModuleName.Document);
            }
            else if (customerPayment.ARPaymentMethodCombo == PaymentMethod.CreditCard.ToString())
            {
                BOSApp.UpdateObjectNumbering(ModuleName.Document);
            }
        }

        public override void SaveModuleObjects()
        {
            ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)MainObject;

            ////Rollback deposit and balance due of invoice            
            //foreach (ARInvoicesInfo objInvoicesInfo in ARInvoiceList.BackupList)
            //{
            //    objInvoicesInfo.ARInvoiceBalanceDue += objInvoicesInfo.ARDocumentPaymentAmount * objInvoicesInfo.ARDocumentPaymentExchangeRate;
            //    objInvoicesController.UpdateObject(objInvoicesInfo);                              
            //}

            //Delete document payments
            ARDocumentPaymentsController objDocumentPaymentsController = new ARDocumentPaymentsController();
            objDocumentPaymentsController.DeleteByForeignColumn("FK_ARCustomerPaymentID", customerPayment.ARCustomerPaymentID);

            foreach (ARInvoicesInfo objInvoicesInfo in ARInvoiceList)
            {
                //Update new deposit and balance due
                ARInvoicesInfo existingInvoice = ARInvoiceList.BackupList.Where(i => i.ARInvoiceID == objInvoicesInfo.ARInvoiceID).FirstOrDefault();
                if (existingInvoice != null)
                {
                    objInvoicesInfo.ARInvoiceBalanceDue += existingInvoice.ARDocumentPaymentAmount * existingInvoice.ARDocumentPaymentExchangeRate;
                }
                objInvoicesInfo.ARInvoiceBalanceDue -= objInvoicesInfo.ARDocumentPaymentAmount * objInvoicesInfo.ARDocumentPaymentExchangeRate;
                BOSApp.RoundByCurrency(objInvoicesInfo, customerPayment.FK_GECurrencyID);
                objInvoicesController.UpdateObject(objInvoicesInfo);

                AROpenDocumentsController objOpenDocumentsController = new AROpenDocumentsController();
                AROpenDocumentsInfo objOpenDocumentsInfo = objOpenDocumentsController.GetOpenDocumentByInvoiceID(objInvoicesInfo.ARInvoiceID);
                if (objOpenDocumentsInfo == null)
                {
                    objOpenDocumentsInfo = DataGenerator.GenerateOpenDocumentFromInvoice(objInvoicesInfo);
                    objOpenDocumentsController.CreateObject(objOpenDocumentsInfo);
                }

                CustomerPaymentModule.CreateDocumentPayments(
                                                        objOpenDocumentsInfo,
                                                        customerPayment,
                                                        objInvoicesInfo.ARDocumentPaymentAmount,
                                                        objInvoicesInfo.ARDocumentPaymentExchangeRate);
            }

            //Save payment details                 
            if (Module.Toolbar.IsNewAction())
            {
                CustomerPaymentModule.CreateCustomerPaymentDetails(customerPayment, CustomerPaymentDetailList);
            }
            else
            {
                CustomerPaymentModule.UpdateCustomerPaymentDetails(customerPayment, CustomerPaymentDetailList);
            }

            SaveAccountingData();
        }
        #endregion

        /// <summary>
        /// Get default payment methods for a customer payment
        /// </summary>
        private List<ARCustomerPaymentDetailsInfo> GetDefaultPaymentMethods()
        {
            ARCustomerPaymentDetailsController objCustomerPaymentDetailsController = new ARCustomerPaymentDetailsController();
            List<ARCustomerPaymentDetailsInfo> paymentDetailList = objCustomerPaymentDetailsController.GetDefaultPaymentDetails();
            paymentDetailList = paymentDetailList.Where(p =>
                                    p.ARPaymentMethodCombo == PaymentMethod.Cash.ToString() ||
                                    p.ARPaymentMethodCombo == PaymentMethod.BankTransfer.ToString() ||
                                    p.ARPaymentMethodCombo == PaymentMethod.OwingExchange.ToString() ||
                                    p.ARPaymentMethodCombo == PaymentMethod.CreditCard.ToString()).ToList();
            return paymentDetailList;
        }

        #region Accounting
        public override bool SaveAccountingData()
        {
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)MainObject;
            if (objCustomerPaymentsInfo.ARPaymentMethodCombo == PaymentMethod.Cash.ToString())
            {
                CreateReceiptVoucher();
            }
            if (objCustomerPaymentsInfo.ARPaymentMethodCombo == PaymentMethod.BankTransfer.ToString())
            {
                CreateBankTransfer();
            }

            foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
            {
                BOSUtil.CopyObject(objCustomerPaymentsInfo, objDocumentsInfo);
                objDocumentsInfo.FK_ACObjectID = objCustomerPaymentsInfo.FK_ARCustomerID;
                objDocumentsInfo.ACObjectType = ObjectType.Customer.ToString();
            }
            return base.SaveAccountingData();
        }

        /// <summary>
        /// Create a receipt voucher associating with the customer payment
        /// </summary>
        private void CreateReceiptVoucher()
        {
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)MainObject;
            ARReceiptVouchersController objReceiptVouchersController = new ARReceiptVouchersController();
            ARReceiptVoucherItemsController objReceiptVoucherItemsController = new ARReceiptVoucherItemsController();
            int receiptVoucherID = 0;
            ARReceiptVouchersInfo objReceiptVouchersInfo = (ARReceiptVouchersInfo)objReceiptVouchersController.GetObjectByNo(objCustomerPaymentsInfo.ARCustomerPaymentNo);
            if (objReceiptVouchersInfo != null)
            {
                receiptVoucherID = objReceiptVouchersInfo.ARReceiptVoucherID;
                BOSUtil.CopyObject(objCustomerPaymentsInfo, objReceiptVouchersInfo);
                objReceiptVouchersInfo.ARReceiptVoucherType = ReceiptVoucherType.CustomerPayment.ToString();
                objReceiptVouchersInfo.FK_ACObjectID = objCustomerPaymentsInfo.FK_ARCustomerID;
                objReceiptVouchersInfo.ARObjectType = ObjectType.Customer.ToString();
                objReceiptVouchersInfo.ARReceiptVoucherSenderName = objCustomerPaymentsInfo.ARCustomerPaymentSenderName;
                objReceiptVouchersInfo.ARReceiptVoucherExchangeAmount = objReceiptVouchersInfo.ARReceiptVoucherTotalAmount * objReceiptVouchersInfo.ARReceiptVoucherExchangeRate;
                BOSApp.RoundByCurrency(objReceiptVouchersInfo, objCustomerPaymentsInfo.FK_GECurrencyID);
                objReceiptVouchersController.UpdateObject(objReceiptVouchersInfo);
            }
            else
            {
                objReceiptVouchersInfo = new ARReceiptVouchersInfo();
                BOSUtil.CopyObject(objCustomerPaymentsInfo, objReceiptVouchersInfo);
                objReceiptVouchersInfo.ARReceiptVoucherType = ReceiptVoucherType.CustomerPayment.ToString();
                objReceiptVouchersInfo.FK_ACObjectID = objCustomerPaymentsInfo.FK_ARCustomerID;
                objReceiptVouchersInfo.ARObjectType = ObjectType.Customer.ToString();
                objReceiptVouchersInfo.ARReceiptVoucherSenderName = objCustomerPaymentsInfo.ARCustomerPaymentSenderName;
                objReceiptVouchersInfo.ARReceiptVoucherExchangeAmount = objReceiptVouchersInfo.ARReceiptVoucherTotalAmount * objReceiptVouchersInfo.ARReceiptVoucherExchangeRate;
                BOSApp.RoundByCurrency(objReceiptVouchersInfo, objCustomerPaymentsInfo.FK_GECurrencyID);
                receiptVoucherID = objReceiptVouchersController.CreateObject(objReceiptVouchersInfo);
            }

            objReceiptVoucherItemsController.DeleteByForeignColumn("FK_ARReceiptVoucherID", objReceiptVouchersInfo.ARReceiptVoucherID);
            foreach (ACDocumentEntrysInfo entry in DocumentEntryList)
            {
                ARReceiptVoucherItemsInfo item = new ARReceiptVoucherItemsInfo();
                BOSUtil.CopyObject(entry, item);
                item.FK_ARReceiptVoucherID = objReceiptVouchersInfo.ARReceiptVoucherID;
                objReceiptVoucherItemsController.CreateObject(item);
            }
        }

        /// <summary>
        /// Create a bank transfer associating with the customer payment
        /// </summary>
        private void CreateBankTransfer()
        {
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)MainObject;
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            string bankName = objCompanyBanksController.GetObjectNameByID(objCustomerPaymentsInfo.FK_CSCompanyBankID);

            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            ACBankTransactionItemsController objBankTransactionItemsController = new ACBankTransactionItemsController();
            int bankTransferID = 0;
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)objBankTransactionsController.GetObjectByNo(objCustomerPaymentsInfo.ARCustomerPaymentNo);
            if (objBankTransactionsInfo != null)
            {
                bankTransferID = objBankTransactionsInfo.ACBankTransactionID;
                BOSUtil.CopyObject(objCustomerPaymentsInfo, objBankTransactionsInfo);
                objBankTransactionsInfo.FK_ACObjectID = objCustomerPaymentsInfo.FK_ARCustomerID;
                objBankTransactionsInfo.ACObjectType = ObjectType.Customer.ToString();
                objBankTransactionsInfo.ACBankTransactionType = BankTransactionType.BankTransfer.ToString();
                objBankTransactionsInfo.ACBankTransactionReceiverBankName = bankName;
                objBankTransactionsInfo.ACBankTransactionReceiverAccount = objCustomerPaymentsInfo.ARCustomerPaymentBankAccount;
                objBankTransactionsInfo.ACBankTransactionExchangeAmount = objBankTransactionsInfo.ACBankTransactionTotalAmount * objBankTransactionsInfo.ACBankTransactionExchangeRate;
                BOSApp.RoundByCurrency(objBankTransactionsInfo, objCustomerPaymentsInfo.FK_GECurrencyID);
                objBankTransactionsController.UpdateObject(objBankTransactionsInfo);
            }
            else
            {
                objBankTransactionsInfo = new ACBankTransactionsInfo();
                BOSUtil.CopyObject(objCustomerPaymentsInfo, objBankTransactionsInfo);
                objBankTransactionsInfo.FK_ACObjectID = objCustomerPaymentsInfo.FK_ARCustomerID;
                objBankTransactionsInfo.ACObjectType = ObjectType.Customer.ToString();
                objBankTransactionsInfo.ACBankTransactionType = BankTransactionType.BankTransfer.ToString();
                objBankTransactionsInfo.ACBankTransactionReceiverBankName = bankName;
                objBankTransactionsInfo.ACBankTransactionReceiverAccount = objCustomerPaymentsInfo.ARCustomerPaymentBankAccount;
                objBankTransactionsInfo.ACBankTransactionExchangeAmount = objBankTransactionsInfo.ACBankTransactionTotalAmount * objBankTransactionsInfo.ACBankTransactionExchangeRate;
                BOSApp.RoundByCurrency(objBankTransactionsInfo, objCustomerPaymentsInfo.FK_GECurrencyID);
                bankTransferID = objBankTransactionsController.CreateObject(objBankTransactionsInfo);
            }

            objBankTransactionItemsController.DeleteByForeignColumn("FK_ACBankTransactionID", objBankTransactionsInfo.ACBankTransactionID);
            foreach (ACDocumentEntrysInfo entry in DocumentEntryList)
            {
                ACBankTransactionItemsInfo item = new ACBankTransactionItemsInfo();
                BOSUtil.CopyObject(entry, item);
                item.FK_ACBankTransactionID = objBankTransactionsInfo.ACBankTransactionID;
                objBankTransactionItemsController.CreateObject(item);
            }
        }
        #endregion                        
    }
}