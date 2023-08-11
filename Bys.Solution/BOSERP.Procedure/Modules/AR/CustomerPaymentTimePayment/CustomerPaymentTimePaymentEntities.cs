using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.CustomerPaymentTimePayment
{
    public class CustomerPaymentTimePaymentEntities : BaseTransactionEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<ARCustomerPaymentTimePaymentsInfo> ARCustomerPaymentTimePaymentList { get; set; }

        public BOSList<ARInvoicesInfo> OwingInvoicesList { get; set; }

        public BOSList<ARCustomerPaymentDocumentsInfo> CustomerPaymentDocumentList { get; set; }
        #endregion

        #region Constructor
        public CustomerPaymentTimePaymentEntities()
            : base()
        {
            ARCustomerPaymentTimePaymentList = new BOSList<ARCustomerPaymentTimePaymentsInfo>();
            CustomerPaymentDocumentList = new BOSList<ARCustomerPaymentDocumentsInfo>();
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
            ModuleObjects.Add(TableName.ARCustomerPaymentDetailsTableName, new ARCustomerPaymentDetailsInfo());
            ModuleObjects.Add(TableName.ARCustomerPaymentTimePaymentTableName, new ARCustomerPaymentTimePaymentsInfo());
            ModuleObjects.Add(TableName.ARCustomerPaymentDocumentsTableName, new ARCustomerPaymentDocumentsInfo());
        }

        public override void InitModuleObjectList()
        {
            ARCustomerPaymentTimePaymentList.InitBOSList(this,
                                                        TableName.ARCustomerPaymentsTableName,
                                                        TableName.ARCustomerPaymentTimePaymentTableName,
                                                        BOSList<ARCustomerPaymentTimePaymentsInfo>.cstRelationForeign);
            ARCustomerPaymentTimePaymentList.ItemTableForeignKey = "FK_ARCustomerPaymentID";

            CustomerPaymentDocumentList.InitBOSList(this,
                                                    TableName.ARCustomerPaymentsTableName,
                                                    TableName.ARCustomerPaymentDocumentsTableName,
                                                    BOSList<ARCustomerPaymentDocumentsInfo>.cstRelationForeign);
            CustomerPaymentDocumentList.ItemTableForeignKey = "FK_ARCustomerPaymentID";
        }

        public override void InitGridControlInBOSList()
        {
            CustomerPaymentDocumentList.InitBOSListGridControl(CustomerPaymentTimePaymentModule.CustomerPaymentDocumentGridControlName);
            DocumentEntryList.InitBOSListGridControl("fld_dgcDocumentEntrys");
            ARCustomerPaymentTimePaymentList.InitBOSListGridControl();
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
            objCustomerPaymentsInfo.ARCustomerPaymentTotalAmount = 0;
            CSCashFundsController objCSCashFundsController = new CSCashFundsController();
            List<CSCashFundsInfo> lstCSCashFundsInfo = objCSCashFundsController.GetListCashFundsByBranchID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (lstCSCashFundsInfo != null && lstCSCashFundsInfo.Any(o => o.CSCashFundNo.Contains(CurrencyNo.VND.ToString())))
            {
                objCustomerPaymentsInfo.FK_CSCashFundID = lstCSCashFundsInfo.Where(o => o.CSCashFundNo.Contains(CurrencyNo.VND.ToString())).FirstOrDefault().CSCashFundID;
            }
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ARCustomerPaymentTimePaymentList.SetDefaultListAndRefreshGridControl();
                CustomerPaymentDocumentList.SetDefaultListAndRefreshGridControl();
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
            ARCustomerPaymentTimePaymentsController objCustomerPaymentTimePaymentsController = new ARCustomerPaymentTimePaymentsController();
            List<ARCustomerPaymentTimePaymentsInfo> customerPaymentTimePaymentsList = objCustomerPaymentTimePaymentsController.GetCustomerPaymentTimePaymentsByCustomerPaymentID(iObjectID);
            ARCustomerPaymentTimePaymentList.Invalidate(customerPaymentTimePaymentsList);
            CustomerPaymentDocumentList.Invalidate(iObjectID);
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
                ARReceiptVouchersController objReceiptVouchersController = new ARReceiptVouchersController();
                while (objReceiptVouchersController.IsExist(mainObjectNo))
                {
                    BOSApp.UpdateObjectNumbering(ModuleName.ReceiptVoucher);
                    mainObjectNo = BOSApp.GetMainObjectNo(ModuleName.ReceiptVoucher, customerPayment);
                }
            }
            else if (customerPayment.ARPaymentMethodCombo == PaymentMethod.BankTransfer.ToString())
            {
                mainObjectNo = BOSApp.GetMainObjectNo(ModuleName.BankTransaction, customerPayment);
                ACBankTransactionsController objBankTransactionsController = new ACBankTransactionsController();
                while (objBankTransactionsController.IsExist(mainObjectNo))
                {
                    BOSApp.UpdateObjectNumbering(ModuleName.BankTransaction);
                    mainObjectNo = BOSApp.GetMainObjectNo(ModuleName.BankTransaction, customerPayment);
                }
            }
            else
            {
                mainObjectNo = BOSApp.GetMainObjectNo(ModuleName.Document, customerPayment);
                ACDocumentsController objDocumentsController = new ACDocumentsController();
                while (objDocumentsController.IsExist(mainObjectNo))
                {
                    BOSApp.UpdateObjectNumbering(ModuleName.Document);
                    mainObjectNo = BOSApp.GetMainObjectNo(ModuleName.Document, customerPayment);
                }
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
            else
            {
                BOSApp.UpdateObjectNumbering(ModuleName.Document);
            }
        }

        public override void SaveModuleObjects()
        {
            ARCustomerPaymentTimePaymentList.SaveItemObjects();
            CustomerPaymentDocumentList.SaveItemObjects();
        }
        #endregion

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
            DocumentEntryList.Clear();
            ACDocumentsInfo objDocumentsInfo = DocumentList.FirstOrDefault();
            BOSUtil.CopyObject(objCustomerPaymentsInfo, objDocumentsInfo);
            objDocumentsInfo.FK_ACObjectID = objCustomerPaymentsInfo.FK_ACObjectID;
            objDocumentsInfo.ACObjectType = objCustomerPaymentsInfo.ARObjectType;
            objDocumentsInfo.STToolbarActionName = objCustomerPaymentsInfo.STToolbarActionName;
            objDocumentsInfo.ACDocumentDate = objCustomerPaymentsInfo.ARCustomerPaymentDate;
            CustomerPaymentDocumentList.ForEach(o =>
            {
                ACDocumentEntrysInfo entry = new ACDocumentEntrysInfo();
                BOSUtil.CopyObject(o, entry);
                entry.FK_ACDocumentTypeID = objDocumentsInfo.FK_ACDocumentTypeID;
                DocumentEntryList.Add(entry);
            });
            return base.SaveAccountingData();
        }
        #endregion

        public override bool CompleteTransaction()
        {
            ARCustomerPaymentsInfo mainObject = (ARCustomerPaymentsInfo)MainObject;
            if (mainObject.ARCustomerPaymentStatus == CustomerPaymentStatus.New.ToString())
            {
                mainObject.FK_HREmployeeCompletedID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                mainObject.ARCustomerPaymentStatus = CustomerPaymentStatus.Completed.ToString();
                UpdateMainObject();
            }

            ARCustomerPaymentTimePaymentList.SaveItemObjects();
            ARPaymentProposalItemsController ppiController = new ARPaymentProposalItemsController();
            ppiController.UpdatePaidAmountByCustomerPaymentID(mainObject.ARCustomerPaymentID);

            SaveAccountingData();
            return base.CompleteTransaction();
        }

        public override bool CancelCompleteTransaction()
        {
            ARCustomerPaymentsInfo mainObject = (ARCustomerPaymentsInfo)MainObject;
            if (mainObject.ARCustomerPaymentStatus == CustomerPaymentStatus.Completed.ToString())
            {
                mainObject.ARCustomerPaymentStatus = CustomerPaymentStatus.New.ToString();
                mainObject.ARCustomerPaymentPostedStatus = CustomerPaymentStatus.New.ToString();
                SaveMainObject();
            }
            return true;
        }

        public void UpdateReferPaymentData(bool isRollBack)
        {
            ARCustomerPaymentsInfo mainObject = (ARCustomerPaymentsInfo)MainObject;
            (new ARCustomerPaymentTimePaymentsController()).UpdateReferPaymentDataByCustomerPayment(mainObject.ARCustomerPaymentID, isRollBack);
        }
    }
}