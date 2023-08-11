using BOSCommon;
using BOSCommon.Constants;
using BOSERP.Modules.CustomerPayment;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.CustomerRepaid
{
    public class CustomerRepaidEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the document payments of the customer payment
        /// </summary>
        public BOSList<ARInvoicesInfo> InvoiceList { get; set; }

        /// <summary>
        /// Gets or sets the payment details of the customer payment
        /// </summary>
        public BOSList<ARCustomerPaymentDetailsInfo> PaymentDetailList { get; set; }
        #endregion

        #region Constructor
        public CustomerRepaidEntities()
            : base()
        {
            InvoiceList = new BOSList<ARInvoicesInfo>();
            PaymentDetailList = new BOSList<ARCustomerPaymentDetailsInfo>();
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
        }

        public override void InitModuleObjectList()
        {
            InvoiceList.InitBOSList(
                                         this,
                                         string.Empty,
                                         TableName.ARInvoicesTableName,
                                         BOSList<ARDocumentPaymentsInfo>.cstRelationNone);

            PaymentDetailList.InitBOSList(
                                                this,
                                                string.Empty,
                                                TableName.ARCustomerPaymentDetailsTableName);
        }

        public override void InitGridControlInBOSList()
        {
            InvoiceList.InitBOSListGridControl(CustomerRepaidModule.InvoiceGridControlName);
            PaymentDetailList.InitBOSListGridControl(CustomerRepaidModule.CustomerPaymentDetailGridControlName);
            DocumentEntryList.InitBOSListGridControl(CustomerRepaidModule.DocumentEntryGridControlName);
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)MainObject;
            objCustomerPaymentsInfo.ARCustomerPaymentType = CustomerPaymentType.Repaid.ToString();
            objCustomerPaymentsInfo.ARCustomerPaymentDate = DateTime.Now;
            objCustomerPaymentsInfo.FK_GECurrencyID = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
            objCustomerPaymentsInfo.ARCustomerPaymentExchangeRate = BOSApp.CurrentCompanyInfo.CSCompanySaleExchangeRate;
            objCustomerPaymentsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objCustomerPaymentsInfo.ARCustomerPaymentDesc = CustomerRepaidLocalizedResources.CustomerRepaidDefaultDesc;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                InvoiceList.SetDefaultListAndRefreshGridControl();

                List<ARCustomerPaymentDetailsInfo> paymentDetails = GetDefaultPaymentMethods();
                PaymentDetailList.Invalidate(paymentDetails);
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

            ARCustomerPaymentsInfo objCustomerPaymentsInfo = new ARCustomerPaymentsInfo();
            APPaymentVouchersController objPaymentVouchersController = new APPaymentVouchersController();
            APPaymentVouchersInfo objPaymentVouchersInfo = (APPaymentVouchersInfo)objPaymentVouchersController.GetObjectByNo(objCustomerPaymentsInfo.ARCustomerPaymentNo);
            if (objPaymentVouchersInfo != null)
            {
                objCustomerPaymentsInfo.APPaymentVoucherID = objPaymentVouchersInfo.APPaymentVoucherID;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)MainObject;
            List<ARInvoicesInfo> invoices = objInvoicesController.GetInvoicesByCustomerPaymentID(objCustomerPaymentsInfo.ARCustomerPaymentID);
            InvoiceList.Invalidate(invoices);

            ARCustomerPaymentDetailsController objCustomerPaymentDetailsController = new ARCustomerPaymentDetailsController();
            DataSet ds = objCustomerPaymentDetailsController.GetAllDataByForeignColumn("FK_ARCustomerPaymentID", objCustomerPaymentsInfo.ARCustomerPaymentID);
            PaymentDetailList.Invalidate(ds);
        }
        #endregion

        #region Save Module Objects functions
        public override string GetMainObjectNo(ref int numberingStart)
        {
            string mainObjectNo = string.Empty;
            ARCustomerPaymentsInfo customerPayment = (ARCustomerPaymentsInfo)MainObject;
            if (customerPayment.ARPaymentMethodCombo == PaymentMethod.Cash.ToString())
            {
                mainObjectNo = BOSApp.GetMainObjectNo(ModuleName.PaymentVoucher, customerPayment);
            }
            else if (customerPayment.ARPaymentMethodCombo == PaymentMethod.PaymentOrder.ToString())
            {
                mainObjectNo = BOSApp.GetMainObjectNo(ModuleName.PaymentOrder, customerPayment);
            }
            else if (customerPayment.ARPaymentMethodCombo == PaymentMethod.OwingExchange.ToString())
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
                BOSApp.UpdateObjectNumbering(ModuleName.PaymentVoucher);
            }
            else if (customerPayment.ARPaymentMethodCombo == PaymentMethod.PaymentOrder.ToString())
            {
                BOSApp.UpdateObjectNumbering(ModuleName.PaymentOrder);
            }
            else if (customerPayment.ARPaymentMethodCombo == PaymentMethod.OwingExchange.ToString())
            {
                BOSApp.UpdateObjectNumbering(ModuleName.Document);
            }
        }

        public override void SaveModuleObjects()
        {
            ARCustomerPaymentsController objCustomerPaymentsController = new ARCustomerPaymentsController();
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)MainObject;

            ////Rollback deposit and balance due of invoice            
            //foreach (ARInvoicesInfo objInvoicesInfo in InvoiceList.BackupList)
            //{
            //    objInvoicesInfo.ARInvoiceBalanceDue -= objInvoicesInfo.ARDocumentPaymentAmount * objInvoicesInfo.ARDocumentPaymentExchangeRate;
            //    objInvoicesController.UpdateObject(objInvoicesInfo);
            //}

            //Delete document payments
            ARDocumentPaymentsController objDocumentPaymentsController = new ARDocumentPaymentsController();
            objDocumentPaymentsController.DeleteByForeignColumn("FK_ARCustomerPaymentID", objCustomerPaymentsInfo.ARCustomerPaymentID);

            foreach (ARInvoicesInfo objInvoicesInfo in InvoiceList)
            {
                //Update new deposit and balance due
                ARInvoicesInfo existingInvoice = InvoiceList.BackupList.Where(i => i.ARInvoiceID == objInvoicesInfo.ARInvoiceID).FirstOrDefault();
                if (existingInvoice != null)
                {
                    objInvoicesInfo.ARInvoiceBalanceDue -= existingInvoice.ARDocumentPaymentAmount * existingInvoice.ARDocumentPaymentExchangeRate;
                }
                objInvoicesInfo.ARInvoiceBalanceDue += objInvoicesInfo.ARDocumentPaymentAmount * objInvoicesInfo.ARDocumentPaymentExchangeRate;
                BOSApp.RoundByCurrency(objInvoicesInfo, objCustomerPaymentsInfo.FK_GECurrencyID);
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
                                                        objCustomerPaymentsInfo,
                                                        objInvoicesInfo.ARDocumentPaymentAmount,
                                                        objInvoicesInfo.ARDocumentPaymentExchangeRate);
            }

            //Save payment details                 
            if (Module.Toolbar.IsNewAction())
            {
                CustomerPaymentModule.CreateCustomerPaymentDetails(objCustomerPaymentsInfo, PaymentDetailList);
            }
            else
            {
                CustomerPaymentModule.UpdateCustomerPaymentDetails(objCustomerPaymentsInfo, PaymentDetailList);
            }

            SaveAccountingData();
        }
        #endregion

        /// <summary>
        /// Get default payment methods for a customer repaying
        /// </summary>
        private List<ARCustomerPaymentDetailsInfo> GetDefaultPaymentMethods()
        {
            ARCustomerPaymentDetailsController objCustomerPaymentDetailsController = new ARCustomerPaymentDetailsController();
            List<ARCustomerPaymentDetailsInfo> paymentDetailList = objCustomerPaymentDetailsController.GetDefaultPaymentDetails();
            paymentDetailList = paymentDetailList.Where(p =>
                                    p.ARPaymentMethodCombo == PaymentMethod.Cash.ToString() ||
                                    p.ARPaymentMethodCombo == PaymentMethod.PaymentOrder.ToString() ||
                                    p.ARPaymentMethodCombo == PaymentMethod.OwingExchange.ToString()).ToList();
            return paymentDetailList;
        }

        #region Accounting
        public override bool SaveAccountingData()
        {
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)MainObject;
            if (objCustomerPaymentsInfo.ARPaymentMethodCombo == PaymentMethod.Cash.ToString())
            {
                CreatePaymentVoucher();
            }
            else if (objCustomerPaymentsInfo.ARPaymentMethodCombo == PaymentMethod.PaymentOrder.ToString())
            {
                CreatePaymentOrder();
            }

            foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
            {
                BOSUtil.CopyObject(objCustomerPaymentsInfo, objDocumentsInfo);
                objDocumentsInfo.FK_ACObjectID = objCustomerPaymentsInfo.FK_ARCustomerID;
                objDocumentsInfo.ACObjectType = ObjectType.Customer.ToString();
                objDocumentsInfo.STToolbarActionName = objCustomerPaymentsInfo.STToolbarActionName;
            }
            return base.SaveAccountingData();
        }

        /// <summary>
        /// Create a payment voucher associating with the customer repaying
        /// </summary>
        private void CreatePaymentVoucher()
        {
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)MainObject;
            ARCustomersController objCustomersController = new ARCustomersController();
            string customerName = objCustomersController.GetObjectNameByID(objCustomerPaymentsInfo.FK_ARCustomerID);

            APPaymentVouchersController objPaymentVouchersController = new APPaymentVouchersController();
            APPaymentVoucherItemsController objPaymentVoucherItemsController = new APPaymentVoucherItemsController();
            int paymentVoucherID = 0;
            APPaymentVouchersInfo objPaymentVouchersInfo = (APPaymentVouchersInfo)objPaymentVouchersController.GetObjectByNo(objCustomerPaymentsInfo.ARCustomerPaymentNo);
            if (objPaymentVouchersInfo != null)
            {
                paymentVoucherID = objPaymentVouchersInfo.APPaymentVoucherID;
                BOSUtil.CopyObject(objCustomerPaymentsInfo, objPaymentVouchersInfo);
                objPaymentVouchersInfo.APPaymentVoucherType = PaymentVoucherType.CustomerRepaid.ToString();
                objPaymentVouchersInfo.FK_ACObjectID = objCustomerPaymentsInfo.FK_ARCustomerID;
                objPaymentVouchersInfo.APObjectType = ObjectType.Customer.ToString();
                objPaymentVouchersInfo.APPaymentVoucherReceiverName = customerName;
                objPaymentVouchersInfo.STToolbarActionName = objCustomerPaymentsInfo.STToolbarActionName;
                objPaymentVouchersInfo.APPaymentVoucherExchangeAmount = objPaymentVouchersInfo.APPaymentVoucherTotalAmount * objPaymentVouchersInfo.APPaymentVoucherExchangeRate;
                BOSApp.RoundByCurrency(objPaymentVouchersInfo, objPaymentVouchersInfo.FK_GECurrencyID);
                objPaymentVouchersController.UpdateObject(objPaymentVouchersInfo);
            }
            else
            {
                objPaymentVouchersInfo = new APPaymentVouchersInfo();
                BOSUtil.CopyObject(objCustomerPaymentsInfo, objPaymentVouchersInfo);
                objPaymentVouchersInfo.APPaymentVoucherType = PaymentVoucherType.CustomerRepaid.ToString();
                objPaymentVouchersInfo.FK_ACObjectID = objCustomerPaymentsInfo.FK_ARCustomerID;
                objPaymentVouchersInfo.APObjectType = ObjectType.Customer.ToString();
                objPaymentVouchersInfo.APPaymentVoucherReceiverName = customerName;
                objPaymentVouchersInfo.STToolbarActionName = objCustomerPaymentsInfo.STToolbarActionName;
                objPaymentVouchersInfo.APPaymentVoucherExchangeAmount = objPaymentVouchersInfo.APPaymentVoucherTotalAmount * objPaymentVouchersInfo.APPaymentVoucherExchangeRate;
                BOSApp.RoundByCurrency(objPaymentVouchersInfo, objPaymentVouchersInfo.FK_GECurrencyID);
                paymentVoucherID = objPaymentVouchersController.CreateObject(objPaymentVouchersInfo);
            }

            objPaymentVoucherItemsController.DeleteByForeignColumn("FK_APPaymentVoucherID", objPaymentVouchersInfo.APPaymentVoucherID);
            foreach (ACDocumentEntrysInfo entry in DocumentEntryList)
            {
                APPaymentVoucherItemsInfo item = new APPaymentVoucherItemsInfo();
                BOSUtil.CopyObject(entry, item);
                item.FK_APPaymentVoucherID = objPaymentVouchersInfo.APPaymentVoucherID;
                objPaymentVoucherItemsController.CreateObject(item);
            }
        }

        /// <summary>
        /// Create a payment order associating with the customer repaying
        /// </summary>
        private void CreatePaymentOrder()
        {
            ARCustomerPaymentsInfo objCustomerPaymentsInfo = (ARCustomerPaymentsInfo)MainObject;
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            string bankName = objCompanyBanksController.GetObjectNameByID(objCustomerPaymentsInfo.FK_CSCompanyBankID);
            ARCustomersController objCustomersController = new ARCustomersController();
            ARCustomersInfo customer = (ARCustomersInfo)objCustomersController.GetObjectByID(objCustomerPaymentsInfo.FK_ARCustomerID);

            ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
            ACBankTransactionItemsController objBankTransactionItemsController = new ACBankTransactionItemsController();
            int paymentOrderID = 0;
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)objBankTransactionsController.GetObjectByNo(objCustomerPaymentsInfo.ARCustomerPaymentNo);
            if (objBankTransactionsInfo != null)
            {
                paymentOrderID = objBankTransactionsInfo.ACBankTransactionID;
                BOSUtil.CopyObject(objCustomerPaymentsInfo, objBankTransactionsInfo);
                objBankTransactionsInfo.FK_ACObjectID = objCustomerPaymentsInfo.FK_ARCustomerID;
                objBankTransactionsInfo.ACObjectType = ObjectType.Customer.ToString();
                objBankTransactionsInfo.ACBankTransactionType = BankTransactionType.PaymentOrder.ToString();
                objBankTransactionsInfo.ACBankTransactionSenderBankName = bankName;
                objBankTransactionsInfo.STToolbarActionName = objCustomerPaymentsInfo.STToolbarActionName;
                objBankTransactionsInfo.ACBankTransactionSenderAccount = objCustomerPaymentsInfo.ARCustomerPaymentBankAccount;
                if (customer != null)
                {
                    objBankTransactionsInfo.ACBankTransactionReceiverName = customer.ARCustomerName;
                    objBankTransactionsInfo.ACBankTransactionReceiverContactAddress = customer.ARCustomerContactAddressLine3;
                    objBankTransactionsInfo.ACBankTransactionReceiverBankName = customer.ARCustomerBankName;
                    objBankTransactionsInfo.ACBankTransactionReceiverAccount = customer.ARCustomerBankAccount1;
                }
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
                objBankTransactionsInfo.ACBankTransactionType = BankTransactionType.PaymentOrder.ToString();
                objBankTransactionsInfo.ACBankTransactionSenderBankName = bankName;
                objBankTransactionsInfo.STToolbarActionName = objCustomerPaymentsInfo.STToolbarActionName;
                objBankTransactionsInfo.ACBankTransactionSenderAccount = objCustomerPaymentsInfo.ARCustomerPaymentBankAccount;
                if (customer != null)
                {
                    objBankTransactionsInfo.ACBankTransactionReceiverName = customer.ARCustomerName;
                    objBankTransactionsInfo.ACBankTransactionReceiverContactAddress = customer.ARCustomerContactAddressLine3;
                    objBankTransactionsInfo.ACBankTransactionReceiverBankName = customer.ARCustomerBankName;
                    objBankTransactionsInfo.ACBankTransactionReceiverAccount = customer.ARCustomerBankAccount1;
                }
                objBankTransactionsInfo.ACBankTransactionExchangeAmount = objBankTransactionsInfo.ACBankTransactionTotalAmount * objBankTransactionsInfo.ACBankTransactionExchangeRate;
                BOSApp.RoundByCurrency(objBankTransactionsInfo, objCustomerPaymentsInfo.FK_GECurrencyID);
                paymentOrderID = objBankTransactionsController.CreateObject(objBankTransactionsInfo);
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
