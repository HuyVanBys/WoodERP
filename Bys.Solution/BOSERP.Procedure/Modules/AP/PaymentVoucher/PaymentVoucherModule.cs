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

namespace BOSERP.Modules.PaymentVoucher
{
    public class PaymentVoucherModule : BaseTransactionModule
    {
        #region Constant
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        public const string DocumentEntryGridControlName = "fld_dgcDocumentEntrys";
        public const string PaymentVoucherItemsGridControlName = "fld_dgcAPPaymentVoucherItems";
        public const string ToolbarButtonApprove = "Approve";
        public const string CSCashFundLookupEditControlName = "fld_lkeFK_CSCashFundID";
        public const string CSCompanyBankLookupEditControlName = "fld_lkeFK_CSCompanyBankID";
        #endregion

        #region Variables
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        public APPaymentVoucherItemsGridControl PaymentVoucherItemGridControl;
        public BOSLookupEdit CSCashFundLookupEditControl;
        public BOSLookupEdit CSCompanyBankLookupEditControl;
        #endregion

        #region Constructor
        public PaymentVoucherModule()
        {
            Name = "PaymentVoucher";
            CurrentModuleEntity = new PaymentVoucherEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[PaymentVoucherModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
            PaymentVoucherItemGridControl = (APPaymentVoucherItemsGridControl)Controls[PaymentVoucherItemsGridControlName];
            CSCashFundLookupEditControl = (BOSLookupEdit)Controls[PaymentVoucherModule.CSCashFundLookupEditControlName];
            CSCashFundsController objCashFundsController = new CSCashFundsController();
            CSCashFundLookupEditControl.Properties.DataSource = objCashFundsController.GetListCashFundsByBranchID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            CSCompanyBankLookupEditControl = (BOSLookupEdit)Controls[PaymentVoucherModule.CSCompanyBankLookupEditControlName];
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            CSCompanyBankLookupEditControl.Properties.DataSource = objCompanyBanksController.GetListCompanyBanksByBranchID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
        }
        #endregion

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            APPaymentVouchersController objPaymentVouchersController = new APPaymentVouchersController();
            ACObjectsController objObjectsController = new ACObjectsController();
            APPaymentVouchersInfo searchObject = (APPaymentVouchersInfo)CurrentModuleEntity.SearchObject;
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);

            DataSet ds = new DataSet();
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objPaymentVouchersController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objPaymentVouchersController.GetPaymentVoucherListDatasetByListOfBranchID(
                                                                       searchObject.APPaymentVoucherNo,
                                                                       objObjectsInfo.ACObjectID,
                                                                       objObjectsInfo.ACObjectType,
                                                                       searchObject.APPaymentVoucherType,
                                                                       searchObject.FK_HREmployeeID,
                                                                       searchObject.PaymentVoucherDateFrom,
                                                                       searchObject.PaymentVoucherDateTo,
                                                                        BranchList);
                }
            }
            else
            {
                ds = objPaymentVouchersController.GetPaymentVoucherListDataset(
                                                                       searchObject.APPaymentVoucherNo,
                                                                       objObjectsInfo.ACObjectID,
                                                                       objObjectsInfo.ACObjectType,
                                                                       searchObject.APPaymentVoucherType,
                                                                       searchObject.FK_HREmployeeID,
                                                                       searchObject.PaymentVoucherDateFrom,
                                                                       searchObject.PaymentVoucherDateTo,
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
        /// <summary>
        /// Update payment voucher total amount and exchange amount
        /// </summary>
        private void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                UpdatePaymentVoucherItems();
                UpdateDocumentEntries();
                PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
                APPaymentVouchersInfo objPaymentVouchersInfo = (APPaymentVouchersInfo)entity.MainObject;
                objPaymentVouchersInfo.APPaymentVoucherTotalAmount = entity.PaymentVoucherItemList.Sum(i => i.APPaymentVoucherItemAmount);
                objPaymentVouchersInfo.APPaymentVoucherExchangeAmount = entity.PaymentVoucherItemList.Sum(i => i.APPaymentVoucherItemExchangeAmount);
                entity.UpdateMainObjectBindingSource();
            }
        }


        /// <summary>
        /// Called when the user changes the amount of a voucher item
        /// </summary>
        /// <param name="objPaymentVoucherItemsInfo">Changed item</param>
        public void ChangePaymentVoucherItemAmount(APPaymentVoucherItemsInfo objPaymentVoucherItemsInfo)
        {
            APPaymentVouchersInfo paymentVoucher = (APPaymentVouchersInfo)CurrentModuleEntity.MainObject;
            objPaymentVoucherItemsInfo.APPaymentVoucherItemExchangeAmount = objPaymentVoucherItemsInfo.APPaymentVoucherItemAmount * paymentVoucher.APPaymentVoucherExchangeRate;
            objPaymentVoucherItemsInfo.APPaymentVoucherItemTaxAmount = objPaymentVoucherItemsInfo.APPaymentVoucherItemAmount * objPaymentVoucherItemsInfo.APPaymentVoucherItemTaxPercent / 100;
            objPaymentVoucherItemsInfo.APPaymentVoucherItemTotalAmount = objPaymentVoucherItemsInfo.APPaymentVoucherItemAmount + objPaymentVoucherItemsInfo.APPaymentVoucherItemTaxAmount;
            objPaymentVoucherItemsInfo.APPaymentVoucherItemTotalExchangeAmount = objPaymentVoucherItemsInfo.APPaymentVoucherItemTotalAmount * paymentVoucher.APPaymentVoucherExchangeRate;

            BOSApp.RoundByCurrency(objPaymentVoucherItemsInfo, "APPaymentVoucherItemAmount", paymentVoucher.FK_GECurrencyID);
            BOSApp.RoundByCurrency(objPaymentVoucherItemsInfo, "APPaymentVoucherItemExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
            BOSApp.RoundByCurrency(objPaymentVoucherItemsInfo, "APPaymentVoucherItemTotalAmount", paymentVoucher.FK_GECurrencyID);
            BOSApp.RoundByCurrency(objPaymentVoucherItemsInfo, "APPaymentVoucherItemTotalExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
            UpdateTotalAmount();
        }

        public void ChangeAdvanceRequestPaymentTimeAmount(HRAdvanceRequestPaymentTimesInfo objAdvanceRequestPaymentTimesInfo)
        {
            if (IsCreateFromAdvanceRefund())
                return;
            if (!IsCreatedFromAdvanceRequest())
                return;
            if (objAdvanceRequestPaymentTimesInfo.HRAdvanceRequestPaymentTimeAmount > objAdvanceRequestPaymentTimesInfo.HRAdvanceRequestPaymentTimeTotalAmount)
            {
                objAdvanceRequestPaymentTimesInfo.HRAdvanceRequestPaymentTimeAmount = 0;
                MessageBox.Show(PaymentVoucherLocalizedResources.AmountCannotLargerTotalAmount, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateTotalAmount();
        }
        /// <summary>
        /// Called when the user changes the object
        /// </summary>
        /// <param name="objectAccessKey">Target object access key</param>
        public void ChangeObject(string objectAccessKey)
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVouchersInfo paymentVoucher = (APPaymentVouchersInfo)CurrentModuleEntity.MainObject;
            paymentVoucher.ACObjectAccessKey = objectAccessKey;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo obj = new ACObjectsInfo();
            obj = objObjectsController.GetObjectByAccessKey(paymentVoucher.ACObjectAccessKey);
            if (!string.IsNullOrEmpty(objectAccessKey))
            {
                obj = objObjectsController.GetObjectByIDAndType(obj.ACObjectID, obj.ACObjectType);
                if (obj == null)
                {
                    obj = objObjectsController.GetObjectList(obj.ACObjectNo, obj.ACObjectType).FirstOrDefault();
                }   
            }
            if (obj != null)
            {
                paymentVoucher.FK_ACObjectID = obj.ACObjectID;
                paymentVoucher.APObjectType = obj.ACObjectType;
                paymentVoucher.APPaymentVoucherReceiverName = obj.ACObjectName;
                paymentVoucher.APPaymentVoucherObjectTaxNumber = obj.ACObjectTaxNumber;
                paymentVoucher.APPaymentVoucherAddress = obj.ACObjectContactAddress;
                foreach (APPaymentVoucherItemsInfo item in entity.PaymentVoucherItemList)
                {
                    item.ACObjectAccessKey = paymentVoucher.ACObjectAccessKey;
                    item.FK_ACObjectID = obj.ACObjectID;
                    item.APObjectType = obj.ACObjectType;
                    item.APObjectName = obj.ACObjectName;
                    item.APPaymentVoucherItemTaxNumber = obj.ACObjectTaxNumber;
                    if(item.FK_ACDebitAccountID <= 0 || paymentVoucher.APPaymentVoucherPurpose == PaymentVoucherPurpose.Payment.ToString())
                    {
                        item.FK_ACDebitAccountID = obj.FK_ACAccountPurchaseID;
                    }
                }
                CurrentModuleEntity.UpdateMainObjectBindingSource();
                entity.PaymentVoucherItemList.GridControl.RefreshDataSource();
            }
        }

        /// <summary>
        /// Called when the user changes the bank
        /// </summary>
        /// <param name="bankID">Selected bank id</param>
        public void ChangeBank(int bankID)
        {
            APPaymentVouchersInfo paymentVoucher = (APPaymentVouchersInfo)CurrentModuleEntity.MainObject;
            paymentVoucher.FK_CSCompanyBankID = bankID;
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            CSCompanyBanksInfo bank = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(bankID);
            if (bank != null)
            {
                paymentVoucher.APPaymentVoucherBankAccount = bank.CSCompanyBankAccount;
            }
            else
            {
                paymentVoucher.APPaymentVoucherBankAccount = string.Empty;
            }
            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        /// <summary>
        /// Remove the selected payment voucher item from its list
        /// </summary>
        public void RemoveSelectedItem()
        {
            if (IsCreatedFromAdvanceRequest())
                return;
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            entity.PaymentVoucherItemList.RemoveSelectedRowObjectFromList();
            UpdateTotalAmount();
        }

        public void RemoveSelectedAdvanceRequestPaymentTimes()
        {
            if (IsCreateFromAdvanceRefund())
                return;
            if (!IsCreatedFromAdvanceRequest())
                return;
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            entity.AdvanceRequestPaymentTimeList.RemoveSelectedRowObjectFromList();
            UpdateTotalAmount();
        }

        #region Method
        public override int ActionSave()
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVouchersInfo paymentVoucher = (APPaymentVouchersInfo)CurrentModuleEntity.MainObject;
            if (string.IsNullOrEmpty(paymentVoucher.ACObjectAccessKey) && paymentVoucher.APPaymentVoucherPurpose != PaymentVoucherPurpose.LoanReceipt.ToString())
            {
                MessageBox.Show("Vui lòng chọn đối tượng.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            if (paymentVoucher.FK_CSCashFundID <= 0)
            {
                MessageBox.Show(PaymentVoucherLocalizedResources.RequireCashFund, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }

            bool allowSave = true;
            if (paymentVoucher.FK_ACLoanReceiptID == 0)
            {
                foreach (APPaymentVoucherItemsInfo item in entity.PaymentVoucherItemList)
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
                MessageBox.Show(PaymentVoucherLocalizedResources.PleaseChooseLoanReceiptForAcccount341, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            if (entity.PaymentVoucherItemList != null && entity.PaymentVoucherItemList.Count > 0
                && entity.PaymentVoucherItemList.Where(x => (x.FK_ACCreditAccountID == 0 || x.FK_ACDebitAccountID == 0)).ToList().Count > 0)
            {
                BOSApp.ShowMessage("Vui lòng chọn đủ tài khoản nợ/ có dưới lưới!");
                return 0;
            }

            entity.PaymentVoucherItemList.EndCurrentEdit();
            if (entity.PaymentVoucherItemList != null && entity.PaymentVoucherItemList.Count() > 0)
            {
                HRAdvanceRefundsController objAdvanceRefundsController = new HRAdvanceRefundsController();
                HRAdvanceRefundsInfo objAdvanceRefundsInfo = null;
                entity.PaymentVoucherItemList.GroupBy(o => new { o.FK_HRAdvanceRefundID }).All(o =>
                {
                    if (o.Key.FK_HRAdvanceRefundID > 0)
                    {
                        objAdvanceRefundsInfo = objAdvanceRefundsController.GetObjectByID(o.Key.FK_HRAdvanceRefundID) as HRAdvanceRefundsInfo;
                        if (objAdvanceRefundsInfo != null && objAdvanceRefundsInfo.HRAdvanceRefundTotalAmount < o.Sum(x => x.APPaymentVoucherItemAmount))
                            allowSave = false;
                    }
                    return true;
                });
                if (allowSave == false)
                {
                    MessageBox.Show("Số tiền không thể vượt quá tổng tiền ở Phiếu hoàn ứng!", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 0;
                }
            }
            if (entity.PaymentVoucherItemList.Count() > 0)
            {
                paymentVoucher.APPaymentVoucherReference = entity.PaymentVoucherItemList.GroupBy(x => x.APPaymentVoucherItemReference).Aggregate(
                    new StringBuilder(),
                    (current, next) => current.Append(current.Length == 0 ? "" : ", ").Append(next.FirstOrDefault().APPaymentVoucherItemReference))
                .ToString();
            }
            if (paymentVoucher.APPaymentVoucherPurpose == PaymentVoucherPurpose.LoanReceipt.ToString())
            {
                if (!IsValidAmountLoanReceiptPaymentPlan())
                    return 0;
            }
            string VATInfo = string.Empty;
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            foreach (APPaymentVoucherItemsInfo item in entity.PaymentVoucherItemList)
            {
                List<ACDocumentsInfo> transactionList = objDocumentsController.CheckAvailableVATInfo(item.APPaymentVoucherItemVoucherNo, item.APPaymentVoucherItemInvoiceDate, item.APPaymentVoucherItemVATSymbol, item.APPaymentVoucherItemTaxNumber);
                if (transactionList != null && transactionList.Count() > 0)
                {
                    VATInfo += String.Format("(Số hoá đơn: {0}, số seri: {1}, mã số thuế: {2})", item.APPaymentVoucherItemVoucherNo, item.APPaymentVoucherItemVATSymbol, item.APPaymentVoucherItemTaxNumber);
                    VATInfo += Environment.NewLine;
                }
            }
            if (!string.IsNullOrEmpty(VATInfo))
            {
                if (MessageBox.Show(String.Format("Hoá đơn kê khai đã tồn tại /n {0}, có lưu lại chứng từ không?", VATInfo), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return 0;
                }
            }
            //foreach (APPaymentVoucherItemsInfo item in entity.PaymentVoucherItemList)
            //{
            //    ACAccountsController objAccountsController = new ACAccountsController();
            //    List<ACAccountsInfo> accountsList = (List<ACAccountsInfo>)objAccountsController.IsAccountOrChildOfAccount(item.FK_ACDebitAccountID, AccAccount.Acc331.ToString());
            //    if (accountsList != null && accountsList.Count > 0)
            //    {
            //        allowSave = false;
            //    }
            //}
            //if (allowSave == false)
            //{
            //    MessageBox.Show(PaymentVoucherLocalizedResources.CannotChooseAccount331, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return 0;
            //}
            entity.PaymentVoucherItemList.EndCurrentEdit();
            UpdateTotalAmount();
            int paymentVoucherID = base.ActionSave();
            return paymentVoucherID;
        }

        public override int GetDocumentTypeID()
        {
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            APPaymentVouchersInfo paymentVoucher = (APPaymentVouchersInfo)CurrentModuleEntity.MainObject;
            int documentTypeID = 0;
            if (paymentVoucher.APPaymentVoucherPurpose == PaymentVoucherPurpose.DirectPayment.ToString())
            {
                documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.ThanhToanTrucTiep.ToString());
            }
            else if (paymentVoucher.APPaymentVoucherPurpose == PaymentVoucherPurpose.LoanReceipt.ToString())
            {
                documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.KheUocVay.ToString());
            }
            else if (paymentVoucher.APPaymentVoucherPurpose == PaymentVoucherPurpose.BillOfLading.ToString())
            {
                documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.ToKhaiHaiQuanNK.ToString());
            }
            else
            {
                documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.PhieuChi.ToString());
            }
            //int documentTypeID = 0;
            //if (paymentVoucher.APPaymentVoucherPurpose != PaymentVoucherPurpose.DirectPayment.ToString())
            //    documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.PhieuChi.ToString());
            //else
            //    documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.ThanhToanTrucTiep.ToString());
            return documentTypeID;
        }

        /// <summary>
        /// Init payment voucher report for displaying
        /// </summary>
        /// <param name="report">Report</param>
        /// <param name="paymentVoucherID">Payment voucher id</param>
        private static void InitPaymentVoucherReport(XtraReport report, int paymentVoucherID)
        {
            ADReportsController objReportsController = new ADReportsController();
            APPaymentVouchersController objPaymentVouchersController = new APPaymentVouchersController();
            List<APPaymentVoucherItemsInfo> paymentVoucherItemList = objReportsController.GetPaymentVoucherItemListByPaymentVoucherID(paymentVoucherID);
            APSupplierPaymentsController objSupplierPaymentsController = new APSupplierPaymentsController();
            paymentVoucherItemList.ForEach(o =>
            {
                APSupplierPaymentsInfo objSupplierPaymentsInfo = (APSupplierPaymentsInfo)objSupplierPaymentsController.GetObjectByNo(o.APPaymentVoucherNo);
                // Lấy người nhận tiền và địa chỉ từ Trả tiền NCC
                if (objSupplierPaymentsInfo != null)
                {
                    o.APPaymentVoucherReceiverName = objSupplierPaymentsInfo.APSupplierPaymentObjectReceiptName;
                    o.APPaymentVoucherAddress = objSupplierPaymentsInfo.APSupplierPaymentReceiptAddress;
                }
                else
                {
                    APPaymentVouchersInfo objPaymentVoucherInfo = (APPaymentVouchersInfo)objPaymentVouchersController.GetObjectByID(paymentVoucherID);
                    o.APPaymentVoucherReceiverName = objPaymentVoucherInfo.APPaymentVoucherReceiverName;
                    o.APPaymentVoucherAddress = objPaymentVoucherInfo.APPaymentVoucherAddress;
                }
            });
            report.DataSource = paymentVoucherItemList;
            //Set default current branch
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel taxNumber = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblMST"];
            if (taxNumber != null)
                taxNumber.Text = BOSApp.CurrentCompanyInfo.CSCompanyTaxNumber;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;
            APPaymentVouchersInfo objPaymentVouchersInfo = (APPaymentVouchersInfo)objPaymentVouchersController.GetObjectByID(paymentVoucherID);
            GECurrenciesController objCurrencyController = new GECurrenciesController();
            GECurrenciesInfo currency = (GECurrenciesInfo)objCurrencyController.GetObjectByID(objPaymentVouchersInfo.FK_GECurrencyID);
            if (currency != null)
                ((RPPaymentVoucher)report).bsGECurrenciesInfo.DataSource = currency;
            int defaultCurrencyID = currency.GECurrencyID;
            if (objPaymentVouchersInfo != null)
            {
                if (objPaymentVouchersInfo.APPaymentVoucherTotalAmount != 0)
                {
                    XRLabel amountWordTop = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblAmountWordTop"];
                    if (amountWordTop != null)
                    {
                        amountWordTop.Text = "Đã nhận đủ số tiền " + ConvertAmountToWord.ReadAmount(objPaymentVouchersInfo.APPaymentVoucherTotalAmount.ToString(), defaultCurrencyID);
                    }
                    XRLabel amountWordBottom = (XRLabel)report.Bands[BandKind.ReportFooter].Controls["xr_lblAmountWordBottom"];
                    if (amountWordBottom != null)
                    {
                        amountWordBottom.Text = amountWordTop.Text;
                    }
                }

                string accountDebitNo = string.Empty;
                string accountCreditNo = string.Empty;
                foreach (APPaymentVoucherItemsInfo item in paymentVoucherItemList)
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

        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                PrintPaymentVoucher(Toolbar.CurrentObjectID);
            }
        }

        public static void PrintPaymentVoucher(int paymentVoucherID)
        {
            RPPaymentVoucher report = new RPPaymentVoucher();
            InitPaymentVoucherReport(report, paymentVoucherID);
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevPaymentVoucherPath, true);
            reviewer.Show();
        }

        /// <summary>
        /// Called when the user changes the cash fund
        /// </summary>
        /// <param name="cashFundID">Selected cash fund id</param>
        public void ChangeCashFund(int cashFundID)
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVouchersInfo objAPPaymentVouchersInfo = (APPaymentVouchersInfo)entity.MainObject;
            objAPPaymentVouchersInfo.FK_CSCashFundID = cashFundID;
            CSCashFundsController objCSCashFundsController = new CSCashFundsController();
            CSCashFundsInfo objCSCashFundsInfo = (CSCashFundsInfo)objCSCashFundsController.GetObjectByID(objAPPaymentVouchersInfo.FK_CSCashFundID);
            if (objCSCashFundsInfo != null && objCSCashFundsInfo.FK_ACAcountID > 0)
            {
                entity.PaymentVoucherItemList.ForEach(x => x.FK_ACCreditAccountID = objCSCashFundsInfo.FK_ACAcountID);
                entity.PaymentVoucherItemList.GridControl.RefreshDataSource();
            }
            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        public void ChangeExchangeRate()
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVouchersInfo paymentVoucher = (APPaymentVouchersInfo)entity.MainObject;
            entity.PaymentVoucherItemList.ForEach(p =>
            {
                ChangePaymentVoucherItemAmount(p);
            });
            UpdateDocumentEntries();
            entity.PaymentVoucherItemList.GridControl.RefreshDataSource();
        }
        #endregion

        #region Accounting
        public override void GenerateAccountingData()
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVouchersInfo objAPPaymentVouchersInfo = (APPaymentVouchersInfo)entity.MainObject;

            if (objAPPaymentVouchersInfo.APPaymentVoucherPurpose == PaymentVoucherPurpose.DirectPayment.ToString())
            {
                GenerateAccountingData(new string[] { AccDocumentType.ThanhToanTrucTiep.ToString() });
                ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
                int fK_ACDocumentTypeID = ((ACDocumentTypesInfo)objDocumentTypesController.GetObjectByName(AccDocumentType.ThanhToanTrucTiep.ToString())).ACDocumentTypeID;
                foreach (ACDocumentEntrysInfo entry in entity.DocumentEntryList)
                {
                    entry.FK_ACDocumentTypeID = fK_ACDocumentTypeID;
                }
            }
            else if (objAPPaymentVouchersInfo.APPaymentVoucherPurpose == PaymentVoucherPurpose.LoanReceipt.ToString())
            {
                GenerateAccountingData(new string[] { AccDocumentType.KheUocVay.ToString() });
            }
            else if (objAPPaymentVouchersInfo.APPaymentVoucherPurpose == PaymentVoucherPurpose.BillOfLading.ToString())
            {
                GenerateAccountingData(new string[] { AccDocumentType.ToKhaiHaiQuanNK.ToString() });
            }
            else if (objAPPaymentVouchersInfo.APPaymentVoucherPurpose == PaymentVoucherPurpose.CustomerRepaid.ToString())
            {
                GenerateAccountingData(new string[] { AccDocumentType.TraTienKhachHang.ToString() });
            }
            else
            {
                GenerateAccountingData(new string[] { AccDocumentType.PhieuChi.ToString() });
                List<ACDocumentEntrysInfo> entries;

                if (IsCreateFromAdvanceRefund())
                {
                    entries = entity.DocumentEntryList.Where(o => o.ACEntryTypeName == AccEntryType.ChiTienHoanUng.ToString()).ToList();
                }
                else if (!IsCreatedFromAdvanceRequest())
                    entries = entity.DocumentEntryList.Where(o => o.ACEntryTypeName == AccEntryType.TraTienNCC.ToString()).ToList();
                else
                    entries = entity.DocumentEntryList.Where(o => o.ACEntryTypeName == AccEntryType.TamUng.ToString()).ToList();
                entity.DocumentEntryList.Invalidate(entries);
            }
        }

        protected override void UpdateDocumentEntries()
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVouchersInfo objAPPaymentVouchersInfo = (APPaymentVouchersInfo)entity.MainObject;
            entity.DocumentEntryList.Clear();
            CSCashFundsController objCSCashFundsController = new CSCashFundsController();
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            CSCashFundsInfo objCSCashFundsInfo = (CSCashFundsInfo)objCSCashFundsController.GetObjectByID(objAPPaymentVouchersInfo.FK_CSCashFundID);
            ACEntryTypesController objACEntryTypesController = new ACEntryTypesController();
            ACEntryTypesInfo objACEntryTypesInfo;
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            ACDocTypeEntrysInfo defaultEntry;
            ACObjectsController objectsController = new ACObjectsController();
            ACObjectsInfo objectsInfo = objectsController.GetObjectByIDAndType(objAPPaymentVouchersInfo.FK_ACObjectID, objAPPaymentVouchersInfo.APObjectType);

            foreach (APPaymentVoucherItemsInfo item in entity.PaymentVoucherItemList)
            {
                if (objCSCashFundsInfo != null && objCSCashFundsInfo.FK_ACAcountID > 0)
                {
                    item.FK_ACCreditAccountID = objCSCashFundsInfo.FK_ACAcountID;
                }
                if (objAPPaymentVouchersInfo.APPaymentVoucherPurpose == PaymentVoucherPurpose.Payment.ToString() && item.FK_ACSegmentID > 0)
                {
                    ACSegmentsController objSegmentsController = new ACSegmentsController();
                    ACSegmentsInfo objSegmentsInfo = (ACSegmentsInfo)objSegmentsController.GetObjectByID(item.FK_ACSegmentID);
                    if (objSegmentsInfo != null && objSegmentsInfo.FK_ACDepreciationCostAccountID > 0)
                    {
                        item.FK_ACDebitAccountID = objSegmentsInfo.FK_ACDepreciationCostAccountID;
                    }
                }
                if (IsCreatedFromAdvanceRequest())
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
                                                                       AccDocumentType.PhieuChi.ToString(),
                                                                       accEntryType);
                    if (defaultEntry != null)
                    {
                        // [HuyNN][27/05/2019][Start]
                        if (item.FK_ACCreditAccountID == 0)
                        {
                            item.FK_ACCreditAccountID = defaultEntry.ACDocTypeEntryAccountDefaultCredit;
                        }
                        // [HuyNN][27/05/2019][End]
                        if (objAPPaymentVouchersInfo.APPaymentVoucherPurpose != PaymentVoucherPurpose.AdvanceRefund.ToString() || item.FK_ACDebitAccountID == 0)
                            item.FK_ACDebitAccountID = defaultEntry.ACDocTypeEntryAccountDefaultDebit;
                        item.FK_ACEntryTypeID = objACEntryTypesInfo.ACEntryTypeID;
                        item.ACEntryTypeName = objACEntryTypesInfo.ACEntryTypeName;
                        item.APPaymentVoucherItemDesc = objACEntryTypesInfo.ACEntryTypeDesc;
                    }
                }
                else if (objAPPaymentVouchersInfo.APPaymentVoucherPurpose == PaymentVoucherPurpose.CustomerRepaid.ToString())
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
                entry.FK_PMProjectID = objAPPaymentVouchersInfo.FK_PMProjectID;
                entity.DocumentEntryList.Add(entry);
            }
        }

        public void ActionNewFromAdvanceRequest()
        {
            ActionNew();
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVouchersInfo paymentVoucher = (APPaymentVouchersInfo)entity.MainObject;
            paymentVoucher.APPaymentVoucherPurpose = PaymentVoucherPurpose.PaymentAdvanceRequest.ToString();
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

                if (IsAdvanceRequestLoan(results.FirstOrDefault().HRAdvanceRequestItemID)
                    && results.FirstOrDefault(o => o.HRAdvanceRequestType != AdvanceRequestType.Loan.ToString()) != null)
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
                if (paymentVoucher.FK_ACObjectID == 0)
                {
                    paymentVoucher.FK_ACObjectID = results[0].FK_HREmployeeID;
                    paymentVoucher.APObjectType = ObjectType.Employee.ToString();
                    paymentVoucher.ACObjectAccessKey = paymentVoucher.FK_ACObjectID + ";" + paymentVoucher.APObjectType;
                    ACObjectsInfo objectsInfo = BOSApp.GetObjectByIDAndTypeFromCatche(paymentVoucher.FK_ACObjectID, paymentVoucher.APObjectType);
                    if (objectsInfo != null)
                    {
                        paymentVoucher.APPaymentVoucherReceiverName = objectsInfo.ACObjectName;
                    }
                }
                paymentVoucher.FK_ACSegmentID = results[0].FK_ACSegmentID;
                paymentVoucher.APPaymentVoucherDesc = String.Empty;
                paymentVoucher.FK_PMProjectID = results[0].FK_PMProjectID;
                paymentVoucher.FK_GECurrencyID = results[0].FK_GECurrencyID;
                decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateByCurrencyAndDate(paymentVoucher.FK_GECurrencyID, paymentVoucher.APPaymentVoucherDate);
                paymentVoucher.APPaymentVoucherExchangeRate = (dCurrencyExchangeRate > 0) ? dCurrencyExchangeRate : results[0].HRAdvanceRequestExchangeRate;

                List<HRAdvanceRequestItemsInfo> advanceRequestItemCheckList = results.Where(o => o.FK_HREmployeeID != paymentVoucher.FK_ACObjectID).ToList();
                if ((advanceRequestItemCheckList != null && advanceRequestItemCheckList.Count > 0) || paymentVoucher.APObjectType != ObjectType.Employee.ToString())
                {
                    MessageBox.Show(PaymentVoucherLocalizedResources.NoMatchWithEmployee, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto stampp;
                }

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
                    objHRAdvanceRequestPaymentTimesInfo.HRAdvanceRequestPaymentTimeReference = objHRAdvanceRequestsInfo.HRAdvanceRequestNo;
                    if (objHRAdvanceRequestsInfo != null)
                    {
                        StringBuilder advanceRequestPaymentTimeDesc = new StringBuilder();
                        advanceRequestPaymentTimeDesc.Append(PaymentVoucherLocalizedResources.AdvanceRequest).Append(" ").Append(objHRAdvanceRequestsInfo.HRAdvanceRequestNo);
                        objHRAdvanceRequestPaymentTimesInfo.HRAdvanceRequestPaymentTimeDesc = advanceRequestPaymentTimeDesc.ToString();
                        objHRAdvanceRequestPaymentTimesInfo.HRAdvanceRequestType = objHRAdvanceRequestsInfo.HRAdvanceRequestType;
                    }
                    paymentVoucher.APPaymentVoucherDesc += objHRAdvanceRequestsInfo.HRAdvanceRequestDesc + "\r\n";
                    entity.AdvanceRequestPaymentTimeList.Add(objHRAdvanceRequestPaymentTimesInfo);

                }
                ChangeObject(paymentVoucher.ACObjectAccessKey);
                foreach (HRAdvanceRequestPaymentTimesInfo item1 in entity.AdvanceRequestPaymentTimeList)
                {
                    entity.PaymentVoucherItemList.Add(ToPaymentVoucherItemList(item1));
                }
                UpdateTotalAmount();
                AllowEditPaymentVoucherItemGridControl(true);
                entity.PaymentVoucherItemList.GridControl.RefreshDataSource();
            }
            else
            {
                ActionCancel();
            }   
        }

        public bool IsAdvanceRequestLoan(int advanceRequestItemID)
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            HRAdvanceRequestPaymentTimesInfo objAdvanceRequestPaymentTimesInfo = entity.AdvanceRequestPaymentTimeList.FirstOrDefault(o => o.HRAdvanceRequestType == AdvanceRequestType.Loan.ToString() && o.FK_HRAdvanceRequestItemID == advanceRequestItemID);
            if (objAdvanceRequestPaymentTimesInfo != null)
            {
                return true;
            }
            return false;
        }

        public bool IsAdvanceRequestUL(int advanceRequestItemID)
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            HRAdvanceRequestPaymentTimesInfo objAdvanceRequestPaymentTimesInfo = entity.AdvanceRequestPaymentTimeList.FirstOrDefault(o => o.HRAdvanceRequestType == AdvanceRequestType.UL.ToString() && o.FK_HRAdvanceRequestItemID == advanceRequestItemID);
            if (objAdvanceRequestPaymentTimesInfo != null)
            {
                return true;
            }
            return false;
        }

        public bool IsAdvanceRequesUCT(int advanceRequestItemID)
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            HRAdvanceRequestPaymentTimesInfo objAdvanceRequestPaymentTimesInfo = entity.AdvanceRequestPaymentTimeList.FirstOrDefault(o => o.HRAdvanceRequestType == AdvanceRequestType.UCT.ToString() && o.FK_HRAdvanceRequestItemID == advanceRequestItemID);
            if (objAdvanceRequestPaymentTimesInfo != null)
            {
                return true;
            }
            return false;
        }

        public void UpdatePaymentVoucherItems()
        {
            if (IsCreateFromAdvanceRefund())
                return;
            if (!IsCreatedFromAdvanceRequest())
                return;
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVouchersInfo objAPPaymentVouchersInfo = (APPaymentVouchersInfo)entity.MainObject;
            CSCashFundsController objCSCashFundsController = new CSCashFundsController();
            CSCashFundsInfo objCSCashFundsInfo = (CSCashFundsInfo)objCSCashFundsController.GetObjectByID(objAPPaymentVouchersInfo.FK_CSCashFundID);
            foreach (APPaymentVoucherItemsInfo item in entity.PaymentVoucherItemList)
            {
                if (objCSCashFundsInfo != null && objCSCashFundsInfo.FK_ACAcountID > 0)
                {
                    item.FK_ACCreditAccountID = objCSCashFundsInfo.FK_ACAcountID;
                }
                List<HRAdvanceRequestPaymentTimesInfo> advanceRequestPaymentTimes = entity.AdvanceRequestPaymentTimeList.Where(o => o.FK_HRAdvanceRequestItemID == item.FK_HRAdvanceRequestItemID).ToList();
                item.APPaymentVoucherItemDesc = PaymentVoucherLocalizedResources.AdvanceRequest;
                item.APPaymentVoucherItemAmount = 0;
                item.IsCreateFromAdvanceRequest = true;
                item.APPaymentVoucherItemAmount = advanceRequestPaymentTimes.Sum(o => o.HRAdvanceRequestPaymentTimeAmount);
                item.APPaymentVoucherItemExchangeAmount = item.APPaymentVoucherItemAmount * objAPPaymentVouchersInfo.APPaymentVoucherExchangeRate;
                item.APPaymentVoucherItemTaxAmount = item.APPaymentVoucherItemAmount * item.APPaymentVoucherItemTaxPercent / 100;
                item.APPaymentVoucherItemTotalAmount = item.APPaymentVoucherItemAmount + item.APPaymentVoucherItemTaxAmount;
                item.APPaymentVoucherItemTotalExchangeAmount = item.APPaymentVoucherItemTotalAmount * objAPPaymentVouchersInfo.APPaymentVoucherExchangeRate;
                item.FK_ACSegmentID = objAPPaymentVouchersInfo.FK_ACSegmentID;
            }
            entity.PaymentVoucherItemList.GridControl.RefreshDataSource();
        }

        public APPaymentVoucherItemsInfo ToPaymentVoucherItemList(HRAdvanceRequestPaymentTimesInfo objAdvanceRequestPaymentTimesInfo)
        {
            APPaymentVouchersInfo mainObject = (APPaymentVouchersInfo)CurrentModuleEntity.MainObject;
            return new APPaymentVoucherItemsInfo()
            {
                APPaymentVoucherItemDesc = PaymentVoucherLocalizedResources.AdvanceRequest,
                APPaymentVoucherItemAmount = objAdvanceRequestPaymentTimesInfo.HRAdvanceRequestPaymentTimeTotalAmount,
                APPaymentVoucherItemExchangeAmount = objAdvanceRequestPaymentTimesInfo.HRAdvanceRequestPaymentTimeTotalAmount * mainObject.APPaymentVoucherExchangeRate,
                APPaymentVoucherItemTotalAmount = objAdvanceRequestPaymentTimesInfo.HRAdvanceRequestPaymentTimeTotalAmount,
                APPaymentVoucherItemTotalExchangeAmount = objAdvanceRequestPaymentTimesInfo.HRAdvanceRequestPaymentTimeTotalAmount * mainObject.APPaymentVoucherExchangeRate,
                FK_ACUnfinishedConstructionCostID = objAdvanceRequestPaymentTimesInfo.FK_ACUnfinishedConstructionCostID,
                FK_HRAdvanceRequestItemID = objAdvanceRequestPaymentTimesInfo.FK_HRAdvanceRequestItemID,
                HRAdvanceRequestType = objAdvanceRequestPaymentTimesInfo.HRAdvanceRequestType,
                APPaymentVoucherItemReference = objAdvanceRequestPaymentTimesInfo.HRAdvanceRequestPaymentTimeReference
            };
        }

        public bool IsCreateFromAdvanceRefund()
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVoucherItemsInfo pvi = entity.PaymentVoucherItemList.FirstOrDefault(t => t.FK_HRAdvanceRefundID > 0);
            return (pvi != null);
        }

        public bool IsCreatedFromAdvanceRequest()
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVoucherItemsInfo objAPPaymentVoucherItemsInfo = entity.PaymentVoucherItemList.FirstOrDefault();
            if (objAPPaymentVoucherItemsInfo != null && objAPPaymentVoucherItemsInfo.IsCreateFromAdvanceRequest)
            {
                if (entity.AdvanceRequestPaymentTimeList.Count == 0)
                    AllowEditPaymentVoucherItemGridControl(true);
                else
                    AllowEditPaymentVoucherItemGridControl(false);
                return true;
            }
            else
            {
                AllowEditPaymentVoucherItemGridControl(true);
            }
            return false;
        }

        public void AllowEditPaymentVoucherItemGridControl(bool isAllow)
        {
            GridView gridView = (GridView)PaymentVoucherItemGridControl.MainView;
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
            {
                if (column.FieldName != PaymentVoucherLocalizedResources.DebitAccountID &&
                    column.FieldName != PaymentVoucherLocalizedResources.CreditAccountID &&
                    column.FieldName != "FK_ACSegmentID" &&
                    column.FieldName != "FK_ACCostCenterID" &&
                    column.FieldName != "FK_VMVehicleID")
                {
                    column.OptionsColumn.AllowEdit = isAllow;
                }
            }
        }
        #endregion

        public void ChangePaymentVoucherItems()
        {
            UpdateTotalAmount();
        }

        public override void ActionNew()
        {
            base.ActionNew();
            APPaymentVouchersInfo paymentVoucher = (APPaymentVouchersInfo)CurrentModuleEntity.MainObject;
            paymentVoucher.APPaymentVoucherPurpose = PaymentVoucherPurpose.Payment.ToString();
        }

        #region Refund
        public void ActionNewFromAdvanceRefund()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                base.ActionNew();
                APPaymentVouchersInfo paymentVoucher = (APPaymentVouchersInfo)CurrentModuleEntity.MainObject;
                paymentVoucher.APPaymentVoucherPurpose = PaymentVoucherPurpose.AdvanceRefund.ToString();
                this.GenerateAccountingData();
                HRAdvanceRefundsController harController = new HRAdvanceRefundsController();
                List<HRAdvanceRefundsInfo> advanceRefundList = harController.GetAdvanceRefundsWithNoneDirectPaymentType(AdvanceRefundPaymentType.Payment.ToString());
                ShowAdvanceRefundList(advanceRefundList);
            }
        }

        public void NewFromDirectPayment()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                base.ActionNew();
                APPaymentVouchersInfo paymentVoucher = (APPaymentVouchersInfo)CurrentModuleEntity.MainObject;
                paymentVoucher.APPaymentVoucherPurpose = PaymentVoucherPurpose.DirectPayment.ToString();
                this.GenerateAccountingData();
                HRAdvanceRefundsController harController = new HRAdvanceRefundsController();
                List<HRAdvanceRefundsInfo> advanceRefundList = harController.GetAdvanceRefundsWithDirectPaymentType(AdvanceRefundPaymentType.Payment.ToString());
                ShowAdvanceRefundList(advanceRefundList);
                //ChangeObject(paymentVoucher.ACObjectAccessKey);
            }
        }

        private void ShowAdvanceRefundList(List<HRAdvanceRefundsInfo> advanceRefundList)
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVouchersInfo paymentVoucher = (APPaymentVouchersInfo)entity.MainObject;

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
                    MessageBox.Show("Vui lòng chọn các đề nghị hoàn ứng cùng loại tiền tệ."
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);
                    goto stampp;
                }
                #endregion

                //Main object
                HRAdvanceRefundsInfo defaultRefund = guiFind.SelectedObjects[0];
                paymentVoucher.FK_ACObjectID = defaultRefund.FK_ACObjectID;
                paymentVoucher.APObjectType = defaultRefund.HRObjectType;
                paymentVoucher.FK_GECurrencyID = defaultRefund.FK_GECurrencyID;
                paymentVoucher.ACObjectAccessKey = paymentVoucher.FK_ACObjectID + ";" + paymentVoucher.APObjectType;
                decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateByCurrencyAndDate(paymentVoucher.FK_GECurrencyID, paymentVoucher.APPaymentVoucherDate);
                paymentVoucher.APPaymentVoucherExchangeRate = (dCurrencyExchangeRate > 0) ? dCurrencyExchangeRate : defaultRefund.HRAdvanceRefundExchangeRate;
                paymentVoucher.FK_PMProjectID = defaultRefund.FK_PMProjectID;
                paymentVoucher.FK_ACSegmentID = defaultRefund.FK_ACSegmentID;
                ACObjectsInfo objectsInfo = BOSApp.GetObjectByIDAndTypeFromCatche(paymentVoucher.FK_ACObjectID, paymentVoucher.APObjectType);
                if (objectsInfo != null)
                {
                    paymentVoucher.APPaymentVoucherReceiverName = objectsInfo.ACObjectName;
                }
                paymentVoucher.APPaymentVoucherDesc = String.Empty;
                //Module Object
                ACDocumentEntrysController entryController = new ACDocumentEntrysController();
                ACDocumentEntrysInfo docEntry = entryController.GetDefaultDocumentEntryByEntryAndDocumentType(AccDocumentType.PhieuChi.ToString()
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
                    List<APPaymentVoucherItemsInfo> pviList = new List<APPaymentVoucherItemsInfo>();
                    APPaymentVoucherItemsInfo pviInfo;

                    string[] advanceRefundNoList = guiFind.SelectedObjects.Select(item => item.HRAdvanceRefundNo).ToArray();
                    string advanceRefundNos = string.Empty;
                    if (advanceRefundNoList != null)
                        advanceRefundNos = string.Join("; ", advanceRefundNoList);

                    HRAdvanceRefundItemInvoicesController advRefundItemInvoiceController = new HRAdvanceRefundItemInvoicesController();
                    List<HRAdvanceRefundItemInvoicesInfo> advRefundItemInvs = advRefundItemInvoiceController.GetAdvanceRefundItemInvoicesByAdvanceRefundNos(advanceRefundNos);

                    foreach (HRAdvanceRefundsInfo advanceRefund in guiFind.SelectedObjects)
                    {
                        if (advanceRefund.HRAdvanceRefundType != AdvanceRefundType.DirectPayment.ToString())
                        {
                            pviInfo = new APPaymentVoucherItemsInfo();
                            pviInfo.FK_ACEntryTypeID = docEntry.FK_ACEntryTypeID;
                            pviInfo.FK_ACCreditAccountID = docEntry.FK_ACCreditAccountID;
                            pviInfo.FK_ACDebitAccountID = docEntry.FK_ACDebitAccountID;
                            if (advanceRefund.FK_ACCreditAccountID > 0)
                                pviInfo.FK_ACDebitAccountID = advanceRefund.FK_ACCreditAccountID;
                            pviInfo.FK_ACObjectID = paymentVoucher.FK_ACObjectID;
                            pviInfo.APObjectType = paymentVoucher.APObjectType;
                            pviInfo.APPaymentVoucherItemDesc = docEntry.ACDocumentEntryDesc + " - " + advanceRefund.HRAdvanceRefundNo;
                            pviInfo.FK_HRAdvanceRefundID = advanceRefund.HRAdvanceRefundID;
                            pviInfo.APPaymentVoucherItemAmount = advanceRefund.HRAdvanceRefundTotalAmount - advanceRefund.HRAdvanceRefundExchangePaymentAmount;
                            pviInfo.APPaymentVoucherItemExchangeAmount = pviInfo.APPaymentVoucherItemAmount * paymentVoucher.APPaymentVoucherExchangeRate;
                            pviInfo.APPaymentVoucherItemTaxAmount = pviInfo.APPaymentVoucherItemAmount * pviInfo.APPaymentVoucherItemTaxPercent / 100;
                            pviInfo.APPaymentVoucherItemTotalAmount = pviInfo.APPaymentVoucherItemAmount + pviInfo.APPaymentVoucherItemTaxAmount;
                            pviInfo.APPaymentVoucherItemTotalExchangeAmount = pviInfo.APPaymentVoucherItemTotalAmount * paymentVoucher.APPaymentVoucherExchangeRate;
                            pviInfo.FK_ACSegmentID = advanceRefund.FK_ACSegmentID;
                            pviInfo.FK_ACCostCenterID = advanceRefund.FK_ACCostCenterID;
                            pviInfo.APPaymentVoucherItemReference = advanceRefund.HRAdvanceRefundNo;
                            pviList.Add(pviInfo);
                        }
                        else
                        {
                            List<HRAdvanceRefundItemInvoicesInfo> collection = advRefundItemInvs.Where(item => item.FK_HRAdvanceRefundID == advanceRefund.HRAdvanceRefundID).ToList();

                            if (collection != null)
                            {
                                foreach (HRAdvanceRefundItemInvoicesInfo inv in collection)
                                {
                                    pviInfo = new APPaymentVoucherItemsInfo();
                                    pviInfo.FK_ACEntryTypeID = docEntry.FK_ACEntryTypeID;
                                    pviInfo.FK_ACCreditAccountID = docEntry.FK_ACCreditAccountID;
                                    pviInfo.FK_ACDebitAccountID = inv.FK_ACDebitAccountID;
                                    pviInfo.FK_ACObjectID = inv.FK_HRObjectID;
                                    pviInfo.APObjectType = inv.HRObjectType;
                                    pviInfo.APObjectName = inv.HRAdvanceRefundItemInvoiceObjectName;
                                    pviInfo.ACObjectAccessKey = pviInfo.FK_ACObjectID + ";" + pviInfo.APObjectType;
                                    pviInfo.FK_HRAdvanceRefundID = advanceRefund.HRAdvanceRefundID;
                                    pviInfo.FK_HRAdvanceRefundItemInvoiceID = inv.HRAdvanceRefundItemInvoiceID;
                                    pviInfo.APPaymentVoucherItemReference = advanceRefund.HRAdvanceRefundNo;
                                    pviInfo.APPaymentVoucherItemVATDocumentType = inv.HRInputVATDocumentType;
                                    pviInfo.APPaymentVoucherItemTaxNumber = inv.HRAdvanceRefundItemInvoiceObjectTaxNumber;
                                    pviInfo.APPaymentVoucherItemVoucherNo = inv.HRAdvanceRefundItemInvoiceSupplierNo;
                                    pviInfo.APPaymentVoucherItemInvoiceDate = inv.HRAdvanceRefundItemInvoiceVATDate;
                                    pviInfo.APPaymentVoucherItemDesc = inv.HRAdvanceRefundItemInvoiceObjectDesc;
                                    pviInfo.APPaymentVoucherItemAmount = inv.HRAdvanceRefundItemInvoiceSubTotalAmount - inv.HRAdvanceRefundPaymentTimeSubPaidAmount;
                                    pviInfo.APPaymentVoucherItemExchangeAmount = pviInfo.APPaymentVoucherItemAmount * paymentVoucher.APPaymentVoucherExchangeRate;
                                    pviInfo.APPaymentVoucherItemTaxPercent = Convert.ToInt32(inv.HRAdvanceRefundItemInvoiceTaxPercent);
                                    pviInfo.APPaymentVoucherItemTaxAmount = pviInfo.APPaymentVoucherItemAmount * pviInfo.APPaymentVoucherItemTaxPercent / 100;
                                    pviInfo.APPaymentVoucherItemTotalAmount = pviInfo.APPaymentVoucherItemAmount + pviInfo.APPaymentVoucherItemTaxAmount;
                                    pviInfo.APPaymentVoucherItemTotalExchangeAmount = pviInfo.APPaymentVoucherItemTotalAmount * paymentVoucher.APPaymentVoucherExchangeRate;
                                    pviInfo.FK_ACCostCenterID = inv.FK_ACCostCenterID;
                                    pviInfo.FK_ACSegmentID = inv.FK_ACSegmentID;
                                    pviInfo.FK_PMProjectID = inv.FK_PMProjectID;
                                    pviInfo.FK_ACUnfinishedConstructionCostID = inv.FK_ACUnfinishedConstructionCostID;
                                    pviInfo.APPaymentVoucherItemVATSymbol = inv.HRAdvanceRefundItemInvoiceVATSymbol;
                                    pviInfo.FK_VMVehicleID = inv.FK_VMVehicleID;
                                    pviInfo.FK_ACCostObjectID = inv.FK_ACCostObjectID;
                                    pviInfo.APPaymentVoucherItemVATFormNo = inv.HRAdvanceRefundItemInvoiceVATFormNo;
                                    pviInfo.FK_ACEInvoiceTypeID = inv.FK_ACEInvoiceTypeID;
                                    pviList.Add(pviInfo);
                                }
                            }
                        }
                        paymentVoucher.APPaymentVoucherDesc += advanceRefund.HRAdvanceRefundDesc + "\r\n";
                    }

                    entity.PaymentVoucherItemList.Invalidate(pviList);
                    entity.PaymentVoucherItemList.GridControl.RefreshDataSource();

                    UpdateTotalAmount();
                }
            }
            else
            {
                ActionCancel();
            }
        }
        #endregion

        public void ActionApprove()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                CurrentModuleEntity.SetPropertyChangeEventLock(false);
                PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
                APPaymentVouchersInfo objPaymentVouchersInfo = (APPaymentVouchersInfo)entity.MainObject;
                if (objPaymentVouchersInfo.APPaymentVoucherPurpose == PaymentVoucherPurpose.Payment.ToString() && objPaymentVouchersInfo.FK_ACLoanReceiptID > 0)
                {
                    ACBankTransactionItemsController objBankTransactionItemsController = new ACBankTransactionItemsController();
                    ACBankTransactionItemsInfo objBankTransactionItemsInfo = objBankTransactionItemsController.CreateBankTransactionItemByLoanReceiptID(objPaymentVouchersInfo.FK_ACLoanReceiptID);
                    if (objBankTransactionItemsInfo != null && objBankTransactionItemsInfo.ACBankTransactionItemAmount < 0)
                    {
                        APPaymentVoucherItemsInfo objPaymentVoucherItemsInfo = entity.PaymentVoucherItemList.FirstOrDefault(o => o.FK_ACDebitAccountID == objBankTransactionItemsInfo.FK_ACDebitAccountID);
                        decimal remainAmount = 0;
                        if (objPaymentVoucherItemsInfo != null)
                        {
                            remainAmount = objPaymentVoucherItemsInfo.APPaymentVoucherItemAmount + objBankTransactionItemsInfo.ACBankTransactionItemAmount;
                            MessageBox.Show(string.Format(PaymentVoucherLocalizedResources.ErrorPaymentLoanReceipt, objBankTransactionItemsInfo.ACLoanReceiptNo, remainAmount.ToString("n2"))
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                objPaymentVouchersInfo.APPaymentVoucherStatus = PaymentVoucherStatus.Approved.ToString();
                objPaymentVouchersInfo.FK_HREmployeeApprovedID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                APSupplierPaymentsController objSupplierPaymentsController = new APSupplierPaymentsController();
                APSupplierPaymentsInfo reference = (APSupplierPaymentsInfo)objSupplierPaymentsController.GetObjectByNo(objPaymentVouchersInfo.APPaymentVoucherNo);
                if (reference != null)
                {
                    reference.APSupplierPaymentStatus = SupplierPaymentStatus.Approved.ToString();
                    objSupplierPaymentsController.UpdateObject(reference);
                }
                entity.UpdateMainObject();
                CurrentModuleEntity.SetPropertyChangeEventLock(true);
                InvalidateToolbar();
            }
        }

        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            APPaymentVouchersInfo objPaymentVouchersInfo = (APPaymentVouchersInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            ParentScreen.SetEnableOfToolbarButton(PaymentVoucherModule.ToolbarButtonApprove, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
            ParentScreen.SetEnableOfToolbarButton("CancelDocument", false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPrint, true);
            if (objPaymentVouchersInfo.APPaymentVoucherID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton("CancelDocument", true);
                if (objPaymentVouchersInfo.APPaymentVoucherStatus == SupplierPaymentStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                    ParentScreen.SetEnableOfToolbarButton(PaymentVoucherModule.ToolbarButtonApprove, true);
                }
                else if (objPaymentVouchersInfo.APPaymentVoucherStatus == SupplierPaymentStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(PaymentVoucherModule.ToolbarButtonApprove, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                }
                else if (objPaymentVouchersInfo.APPaymentVoucherStatus == PaymentVoucherStatus.Canceled.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(PaymentVoucherModule.ToolbarButtonApprove, false);
                    ParentScreen.SetEnableOfToolbarButton("CancelDocument", false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPrint, false);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
                }
                else
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(PaymentVoucherModule.ToolbarButtonApprove, false);
                    if (objPaymentVouchersInfo.APPaymentVoucherStatus == SupplierPaymentStatus.Completed.ToString())
                    {
                        ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, true);
                        ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                            objPaymentVouchersInfo.APPaymentVoucherPostedStatus != PostedTransactionStatus.Posted.ToString());
                        ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                            objPaymentVouchersInfo.APPaymentVoucherPostedStatus == PostedTransactionStatus.Posted.ToString());
                        ParentScreen.SetEnableOfToolbarButton("CancelDocument", false);
                    }
                }
                if (!Toolbar.IsNullOrNoneAction())
                {
                    ParentScreen.SetEnableOfToolbarButton(PaymentVoucherModule.ToolbarButtonApprove, false);
                }
                if (Toolbar.IsEditAction())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, true);
                }
            }
        }

        public void NewFromPaymentPlans()
        {
            base.ActionNew();
            APPaymentVouchersInfo objPaymentVouchersInfo = (APPaymentVouchersInfo)CurrentModuleEntity.MainObject;
            objPaymentVouchersInfo.APPaymentVoucherPurpose = PaymentVoucherPurpose.LoanReceipt.ToString();
            this.GenerateAccountingData();
            guiChooseDate chooseDate = new guiChooseDate();
            chooseDate.Module = this;
            chooseDate.ShowDialog();
            if (chooseDate.DialogResult == DialogResult.OK)
            {
                showLoanReceipt(chooseDate.FromMonth);
            }
            else
            {
                ActionCancel();
            }   
        }

        public void showLoanReceipt(DateTime fromMonth)
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVouchersInfo paymentVoucher = (APPaymentVouchersInfo)entity.MainObject;
            ACLoanReceiptPaymentPlansController objLoanReceiptPaymentPlansController = new ACLoanReceiptPaymentPlansController();
            ACLoanReceiptsController objLoanReceiptsController = new ACLoanReceiptsController();
            List<ACLoanReceiptPaymentPlansInfo> lrppList = objLoanReceiptPaymentPlansController.GetLoanReceiptPaymentPlansByPaymentPlanDate(fromMonth);
            guiFind<ACLoanReceiptPaymentPlansInfo> guiFind = new guiFind<ACLoanReceiptPaymentPlansInfo>(TableName.ACLoanReceiptPaymentPlansTableName
                                                                                                        , lrppList
                                                                                                        , this
                                                                                                        , false);
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                ACLoanReceiptPaymentPlansInfo objLoanReceiptPaymentPlansInfo = guiFind.SelectedObjects.FirstOrDefault();
                if (objLoanReceiptPaymentPlansInfo != null)
                {
                    paymentVoucher.FK_GECurrencyID = objLoanReceiptPaymentPlansInfo.FK_GECurrencyID;
                    decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateByCurrencyAndDate(paymentVoucher.FK_GECurrencyID, paymentVoucher.APPaymentVoucherDate);
                    paymentVoucher.APPaymentVoucherExchangeRate = (objLoanReceiptPaymentPlansInfo.ACLoanReceiptExchangeRate > 0) ? objLoanReceiptPaymentPlansInfo.ACLoanReceiptExchangeRate : dCurrencyExchangeRate;
                    paymentVoucher.FK_ACLoanReceiptID = objLoanReceiptPaymentPlansInfo.FK_ACLoanReceiptID;
                    paymentVoucher.FK_ACLoanReceiptPaymentPlanID = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanID;
                    ACLoanReceiptsInfo objLoanReceiptsInfo = (ACLoanReceiptsInfo)objLoanReceiptsController.GetObjectByID(objLoanReceiptPaymentPlansInfo.FK_ACLoanReceiptID);
                    if (objLoanReceiptsInfo != null)
                        paymentVoucher.APPaymentVoucherDesc = objLoanReceiptsInfo.ACLoanReceiptContent;
                    if (entity.DocumentEntryList != null && entity.DocumentEntryList.Count > 0)
                    {
                        entity.DocumentEntryList.ForEach(a =>
                        {
                            APPaymentVoucherItemsInfo objPaymentVoucherItemsInfo = new APPaymentVoucherItemsInfo();
                            objPaymentVoucherItemsInfo.APPaymentVoucherItemReference = objLoanReceiptPaymentPlansInfo.ACLoanReceiptNo;
                            if (a.ACEntryTypeName == AccEntryName.TraTienNoGop)
                            {
                                objPaymentVoucherItemsInfo.FK_ACDebitAccountID = objLoanReceiptPaymentPlansInfo.FK_ACAccountID;
                                objPaymentVoucherItemsInfo.APPaymentVoucherItemDesc = a.ACDocumentEntryDesc;
                                objPaymentVoucherItemsInfo.APPaymentVoucherItemAmount = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment - objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActualRootPayment;
                                objPaymentVoucherItemsInfo.APPaymentVoucherItemExchangeAmount = (objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanRootPayment - objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActualRootPayment)
                                                                                            * paymentVoucher.APPaymentVoucherExchangeRate;
                                objPaymentVoucherItemsInfo.FK_ACEntryTypeID = a.FK_ACEntryTypeID;
                            }
                            else if (a.ACEntryTypeName == AccEntryName.TraTienLaiVay)
                            {
                                objPaymentVoucherItemsInfo.FK_ACDebitAccountID = objLoanReceiptPaymentPlansInfo.FK_ACAccountCostID;
                                objPaymentVoucherItemsInfo.APPaymentVoucherItemDesc = a.ACDocumentEntryDesc;
                                objPaymentVoucherItemsInfo.APPaymentVoucherItemAmount = objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanProfitsPayment - objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActialProfitsPayment;
                                objPaymentVoucherItemsInfo.APPaymentVoucherItemExchangeAmount = (objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanProfitsPayment - objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActialProfitsPayment)
                                                                                            * paymentVoucher.APPaymentVoucherExchangeRate;
                                objPaymentVoucherItemsInfo.FK_ACEntryTypeID = a.FK_ACEntryTypeID;
                            }
                            else if (a.ACEntryTypeName == AccEntryName.TraTienLaiPhatQuaHan)
                            {
                                objPaymentVoucherItemsInfo.FK_ACDebitAccountID = objLoanReceiptPaymentPlansInfo.FK_ACAccountCostExpiredID;
                                objPaymentVoucherItemsInfo.APPaymentVoucherItemDesc = a.ACDocumentEntryDesc;
                                objPaymentVoucherItemsInfo.APPaymentVoucherItemAmount = 0;
                                objPaymentVoucherItemsInfo.APPaymentVoucherItemExchangeAmount = 0;
                                objPaymentVoucherItemsInfo.FK_ACEntryTypeID = a.FK_ACEntryTypeID;
                            }
                            objPaymentVoucherItemsInfo.APPaymentVoucherItemTotalAmount = objPaymentVoucherItemsInfo.APPaymentVoucherItemAmount + objPaymentVoucherItemsInfo.APPaymentVoucherItemTaxAmount;
                            objPaymentVoucherItemsInfo.APPaymentVoucherItemTotalExchangeAmount = objPaymentVoucherItemsInfo.APPaymentVoucherItemTotalAmount * paymentVoucher.APPaymentVoucherExchangeRate;
                            entity.PaymentVoucherItemList.Add(objPaymentVoucherItemsInfo);
                        });
                        entity.PaymentVoucherItemList.GridControl.RefreshDataSource();
                    }
                }
            }
            else
            {
                ActionCancel();
            }   
        }

        public void ActionNewFromBillOfLading()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                base.ActionNew();
                APPaymentVouchersInfo objPaymentVouchersInfo = (APPaymentVouchersInfo)CurrentModuleEntity.MainObject;
                objPaymentVouchersInfo.APPaymentVoucherPurpose = PaymentVoucherPurpose.BillOfLading.ToString();
                this.GenerateAccountingData();
                APBillOfLadingsController objBillOfLadingController = new APBillOfLadingsController();
                List<APBillOfLadingsInfo> billOfLadingList = objBillOfLadingController.GetObjectsForPaymentVoucher(objPaymentVouchersInfo.FK_BRBranchID);
                ShowBillOfLadingList(billOfLadingList);
            }
        }

        private void ShowBillOfLadingList(List<APBillOfLadingsInfo> billOfLadingList)
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVouchersInfo paymentVoucher = (APPaymentVouchersInfo)entity.MainObject;
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
                    paymentVoucher.APPaymentVoucherDesc = String.Empty;
                    foreach (APBillOfLadingsInfo item in guiFind.SelectedObjects)
                    {
                        if (!string.IsNullOrEmpty(billOfLadingNoList))
                            billOfLadingNoList += ";";
                        billOfLadingNoList += item.APBillOfLadingNo;
                    }
                    List<ACDocumentEntrysInfo> documentEntryList = objDocumentEntrysController.GetEntryByBillOfLadingNoList(billOfLadingNoList);
                    if (documentEntryList != null && documentEntryList.Count > 0)
                    {
                        foreach (ACDocumentEntrysInfo entry in documentEntryList)
                        {
                            APPaymentVoucherItemsInfo objPaymentVoucherItemsInfo = new APPaymentVoucherItemsInfo();
                            objPaymentVoucherItemsInfo.FK_ACEntryTypeID = entry.FK_ACEntryTypeID;
                            objPaymentVoucherItemsInfo.APPaymentVoucherItemAmount = entry.ACDocumentEntryAmount;
                            objPaymentVoucherItemsInfo.FK_ACDebitAccountID = entry.FK_ACCreditAccountID;
                            objPaymentVoucherItemsInfo.APPaymentVoucherItemReference = entry.APBillOfLadingNo;
                            objPaymentVoucherItemsInfo.APPaymentVoucherItemDesc = entry.ACDocumentEntryDesc;
                            objPaymentVoucherItemsInfo.APPaymentVoucherItemExchangeAmount = objPaymentVoucherItemsInfo.APPaymentVoucherItemAmount * paymentVoucher.APPaymentVoucherExchangeRate;
                            objPaymentVoucherItemsInfo.APPaymentVoucherItemTaxAmount = objPaymentVoucherItemsInfo.APPaymentVoucherItemAmount * objPaymentVoucherItemsInfo.APPaymentVoucherItemTaxPercent / 100;
                            objPaymentVoucherItemsInfo.APPaymentVoucherItemTotalAmount = objPaymentVoucherItemsInfo.APPaymentVoucherItemAmount + objPaymentVoucherItemsInfo.APPaymentVoucherItemTaxAmount;
                            objPaymentVoucherItemsInfo.APPaymentVoucherItemTotalExchangeAmount = objPaymentVoucherItemsInfo.APPaymentVoucherItemTotalAmount * paymentVoucher.APPaymentVoucherExchangeRate;
                            entity.PaymentVoucherItemList.Add(objPaymentVoucherItemsInfo);
                        }
                        entity.PaymentVoucherItemList.GridControl.RefreshDataSource();
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

        public void ActionNewCustomerRepaid()
        {
            ActionNew();
            APPaymentVouchersInfo paymentVoucher = (APPaymentVouchersInfo)CurrentModuleEntity.MainObject;
            paymentVoucher.APPaymentVoucherPurpose = PaymentVoucherPurpose.CustomerRepaid.ToString();
            this.GenerateAccountingData();
            ARSaleReturnsController objSaleReturnsController = new ARSaleReturnsController();
            List<ARSaleReturnsInfo> listSaleReturns = objSaleReturnsController.GetSaleReturnsForPayment(paymentVoucher.FK_BRBranchID);
            ShowCustomerRepaid(listSaleReturns);
        }

        private void ShowCustomerRepaid(List<ARSaleReturnsInfo> listSaleReturns)
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVouchersInfo paymentVoucher = (APPaymentVouchersInfo)entity.MainObject;
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

                paymentVoucher.FK_GECurrencyID = results[0].FK_GECurrencyID;
                decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateByCurrencyAndDate(paymentVoucher.FK_GECurrencyID, paymentVoucher.APPaymentVoucherDate);
                paymentVoucher.APPaymentVoucherExchangeRate = (dCurrencyExchangeRate > 0) ? dCurrencyExchangeRate : results[0].ARSaleReturnExchangeRate;
                paymentVoucher.FK_ACObjectID = results[0].FK_ACObjectID;
                paymentVoucher.APObjectType = results[0].ARObjectType;
                paymentVoucher.ACObjectAccessKey = paymentVoucher.FK_ACObjectID + ";" + paymentVoucher.APObjectType;
                paymentVoucher.FK_PMProjectID = results[0].FK_PMProjectID;
                paymentVoucher.APPaymentVoucherDesc = PaymentVoucherLocalizedResources.CustomerRepaidItemDesc;
                ACObjectsInfo objectsInfo = BOSApp.GetObjectByIDAndTypeFromCatche(paymentVoucher.FK_ACObjectID, paymentVoucher.APObjectType);
                if (objectsInfo != null)
                {
                    paymentVoucher.APPaymentVoucherReceiverName = objectsInfo.ACObjectName;
                }

                APPaymentVoucherItemsInfo objPaymentVoucherItemsInfo;
                foreach (ARSaleReturnsInfo item in results)
                {
                    paymentVoucher.APPaymentVoucherDesc += " " + item.ACObjectName + ",";
                    objPaymentVoucherItemsInfo = new APPaymentVoucherItemsInfo();
                    objPaymentVoucherItemsInfo.APPaymentVoucherItemReference = item.ARSaleReturnNo;
                    objPaymentVoucherItemsInfo.APPaymentVoucherItemAmount = item.ARSaleReturnTotalAmount;
                    objPaymentVoucherItemsInfo.APPaymentVoucherItemExchangeAmount = objPaymentVoucherItemsInfo.APPaymentVoucherItemAmount * paymentVoucher.APPaymentVoucherExchangeRate;
                    objPaymentVoucherItemsInfo.APPaymentVoucherItemTaxAmount = objPaymentVoucherItemsInfo.APPaymentVoucherItemAmount * objPaymentVoucherItemsInfo.APPaymentVoucherItemTaxPercent / 100;
                    objPaymentVoucherItemsInfo.APPaymentVoucherItemTotalAmount = objPaymentVoucherItemsInfo.APPaymentVoucherItemAmount + objPaymentVoucherItemsInfo.APPaymentVoucherItemTaxAmount;
                    objPaymentVoucherItemsInfo.APPaymentVoucherItemTotalExchangeAmount = objPaymentVoucherItemsInfo.APPaymentVoucherItemTotalAmount * paymentVoucher.APPaymentVoucherExchangeRate;
                    objPaymentVoucherItemsInfo.APPaymentVoucherItemInvoiceDate = item.ARSaleReturnDate;
                    objPaymentVoucherItemsInfo.APPaymentVoucherItemDesc = PaymentVoucherLocalizedResources.CustomerRepaidItemDesc;
                    entity.PaymentVoucherItemList.Add(objPaymentVoucherItemsInfo);
                }
                entity.PaymentVoucherItemList.GridControl.RefreshDataSource();

                string[] str = paymentVoucher.APPaymentVoucherDesc.Split(',');
                paymentVoucher.APPaymentVoucherDesc = str[0];
                UpdateTotalAmount();
                entity.UpdateMainObjectBindingSource();
            }
            else
            {
                ActionCancel();
            }   
        }

        public override bool ActionComplete()
        {
            GenerateAccountingData();
            UpdateDocumentEntries();
            APPaymentVouchersInfo mainObject = (APPaymentVouchersInfo)CurrentModuleEntity.MainObject;
            if (mainObject.APPaymentVoucherPurpose == PaymentVoucherPurpose.LoanReceipt.ToString())
            {
                if (!IsValidAmountLoanReceiptPaymentPlan())
                    return false;
            }
            return base.ActionComplete();
        }

        public override void ModuleAfterCompleted()
        {
            APPaymentVouchersInfo mainObject = (APPaymentVouchersInfo)CurrentModuleEntity.MainObject;
            if ((mainObject.APPaymentVoucherPurpose == PaymentVoucherPurpose.Payment.ToString() && mainObject.FK_ACLoanReceiptID > 0) || (mainObject.APPaymentVoucherPurpose == PaymentVoucherPurpose.LoanReceipt.ToString()))
            {
                CalculateExchangeRateDiffFee();
            }
            ActionPosted();
            base.ModuleAfterCompleted();
        }

        public void UpdateItemDesc()
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVouchersInfo mainObject = (APPaymentVouchersInfo)entity.MainObject;
            if (mainObject.APPaymentVoucherPurpose == PaymentVoucherPurpose.Payment.ToString() && !String.IsNullOrWhiteSpace(mainObject.APPaymentVoucherDesc))
            {
                entity.PaymentVoucherItemList.ForEach(o => o.APPaymentVoucherItemDesc = mainObject.APPaymentVoucherDesc);
            }
        }

        public void ChangeSegment(int segmentID)
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVouchersInfo mainObject = (APPaymentVouchersInfo)entity.MainObject;
            mainObject.FK_ACSegmentID = segmentID;
            if (mainObject.APPaymentVoucherPurpose == PaymentVoucherPurpose.Payment.ToString() && mainObject.FK_ACSegmentID > 0)
            {
                ACSegmentsController objSegmentsController = new ACSegmentsController();
                ACSegmentsInfo objSegmentsInfo = (ACSegmentsInfo)objSegmentsController.GetObjectByID(mainObject.FK_ACSegmentID);
                if (objSegmentsInfo != null && objSegmentsInfo.FK_ACDepreciationCostAccountID > 0)
                {
                    entity.PaymentVoucherItemList.ForEach(o =>
                    {
                        o.FK_ACSegmentID = mainObject.FK_ACSegmentID;
                        o.FK_ACDebitAccountID = objSegmentsInfo.FK_ACDepreciationCostAccountID;
                    });
                }
                else
                {
                    entity.PaymentVoucherItemList.ForEach(o =>
                    {
                        o.FK_ACSegmentID = mainObject.FK_ACSegmentID;
                    });
                }
            }
            else
            {
                entity.PaymentVoucherItemList.ForEach(o =>
                {
                    o.FK_ACSegmentID = mainObject.FK_ACSegmentID;
                });
            }
            entity.PaymentVoucherItemList.GridControl.RefreshDataSource();
        }

        public void ActionPosted()
        {
            if (!CheckLock()) return;
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVouchersInfo paymentVoucher = (APPaymentVouchersInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            paymentVoucher.APPaymentVoucherPostedStatus = PostedTransactionStatus.Posted.ToString();
            string tableName = paymentVoucher.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, paymentVoucher.APPaymentVoucherID, PostedTransactionStatus.Posted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.PostedTransactions(this.Name, paymentVoucher.APPaymentVoucherID, ModulePostingType.Accounting);

            #region Update CostObjectItems
            ACCostObjectItemsController objCostObjectItemsController = new ACCostObjectItemsController();
            foreach (APPaymentVoucherItemsInfo item in entity.PaymentVoucherItemList)
            {
                objCostObjectItemsController.InsertCostObjectItemByModuleNameAndItemID(this.Name, item.APPaymentVoucherItemID, true);
            }
            #endregion

            #region Create LoanReceiptPayDocs
            if ((paymentVoucher.APPaymentVoucherPurpose == PaymentVoucherPurpose.Payment.ToString() && paymentVoucher.FK_ACLoanReceiptID > 0) || (paymentVoucher.APPaymentVoucherPurpose == PaymentVoucherPurpose.LoanReceipt.ToString()))
            {
                ACLoanReceiptPayDocsController objLoanReceiptPayDocsController = new ACLoanReceiptPayDocsController();
                objLoanReceiptPayDocsController.InsertLoanReceiptPayDocByDocumentPaymentNo(paymentVoucher.APPaymentVoucherNo, paymentVoucher.FK_ACLoanReceiptID, true);
            }
            #endregion

            #region Update CPXD CBDD
            entity.UpdateUnifinishedCost(true);
            #endregion

            InvalidateToolbar();
        }

        public void ActionUnPosted()
        {
            if (!CheckLock()) return;
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVouchersInfo paymentVoucher = (APPaymentVouchersInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            paymentVoucher.APPaymentVoucherPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = paymentVoucher.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, paymentVoucher.APPaymentVoucherID, PostedTransactionStatus.UnPosted.ToString());
            entity.SetPropertyChangeEventLock(true);

            #region Update CostObjectItems
            ACCostObjectItemsController objCostObjectItemsController = new ACCostObjectItemsController();
            foreach (APPaymentVoucherItemsInfo item in entity.PaymentVoucherItemList)
            {
                objCostObjectItemsController.InsertCostObjectItemByModuleNameAndItemID(this.Name, item.APPaymentVoucherItemID, false);
            }
            #endregion

            #region Create LoanReceiptPayDocs
            if ((paymentVoucher.APPaymentVoucherPurpose == PaymentVoucherPurpose.Payment.ToString() && paymentVoucher.FK_ACLoanReceiptID > 0) || (paymentVoucher.APPaymentVoucherPurpose == PaymentVoucherPurpose.LoanReceipt.ToString()))
            {
                ACLoanReceiptPayDocsController objLoanReceiptPayDocsController = new ACLoanReceiptPayDocsController();
                objLoanReceiptPayDocsController.InsertLoanReceiptPayDocByDocumentPaymentNo(paymentVoucher.APPaymentVoucherNo, paymentVoucher.FK_ACLoanReceiptID, false);
            }
            #endregion

            #region Update CPXD CBDD
            entity.UpdateUnifinishedCost(false);
            #endregion

            GLHelper.UnPostedTransactions(this.Name, paymentVoucher.APPaymentVoucherID, ModulePostingType.Accounting);
            InvalidateToolbar();
        }

        #region Hủy chứng từ
        public void ActionCancelDocument()
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVouchersInfo paymentVoucher = (APPaymentVouchersInfo)entity.MainObject;
            if (paymentVoucher.APPaymentVoucherID > 0)
            {
                if (!CheckRelativeDocument())
                {
                    return;
                }
                entity.SetPropertyChangeEventLock(false);
                if (paymentVoucher.APPaymentVoucherPostedStatus == PostedTransactionStatus.Posted.ToString())
                {
                    ActionUnPosted();
                }
                paymentVoucher.APPaymentVoucherStatus = PaymentVoucherStatus.Canceled.ToString();
                entity.UpdateMainObject();
                entity.PaymentVoucherItemList.Clear();
                entity.SetPropertyChangeEventLock(true);
                InvalidateToolbar();
            }
        }
        #endregion

        #region Mở chứng từ
        public override bool ActionCancelComplete()
        {
            APPaymentVouchersInfo mainObject = (APPaymentVouchersInfo)CurrentModuleEntity.MainObject;
            if (mainObject.APPaymentVoucherID > 0)
            {
                if (!CheckLock()) return false;
                if (!CheckRelativeDocument())
                {
                    return false;
                }
                CurrentModuleEntity.SetPropertyChangeEventLock(false);
                if (mainObject.APPaymentVoucherPostedStatus == PostedTransactionStatus.Posted.ToString())
                {
                    ActionUnPosted();
                }
                mainObject.APPaymentVoucherStatus = PaymentVoucherStatus.New.ToString();
                CurrentModuleEntity.UpdateMainObject();
                CurrentModuleEntity.SetPropertyChangeEventLock(true);
                base.ActionCancelComplete();
                InvalidateToolbar();
            }
            return true;
        }
        #endregion

        #region Xóa chứng từ
        public override void ActionDelete()
        {
            APPaymentVouchersInfo mainObject = (APPaymentVouchersInfo)CurrentModuleEntity.MainObject.Clone();
            if (mainObject.APPaymentVoucherID > 0)
            {
                if (!CheckRelativeDocument())
                {
                    return;
                }
                if (mainObject.APPaymentVoucherPostedStatus == PostedTransactionStatus.Posted.ToString())
                {
                    ActionUnPosted();
                }
                base.ActionDelete();
            }
        }
        #endregion

        public void ChangeCurrency(int currencyID)
        {
            APPaymentVouchersInfo paymentVoucher = (APPaymentVouchersInfo)CurrentModuleEntity.MainObject;
            paymentVoucher.FK_GECurrencyID = currencyID;
            decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateByCurrencyAndDate(paymentVoucher.FK_GECurrencyID, paymentVoucher.APPaymentVoucherDate);
            paymentVoucher.APPaymentVoucherExchangeRate = (dCurrencyExchangeRate > 0) ? dCurrencyExchangeRate : 1;
            UpdateTotalAmount();
        }

        public bool IsValidAmountLoanReceiptPaymentPlan()
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVouchersInfo mainObject = (APPaymentVouchersInfo)entity.MainObject;
            ACLoanReceiptPaymentPlansController objLoanReceiptPaymentPlansController = new ACLoanReceiptPaymentPlansController();
            ACLoanReceiptPaymentPlansInfo objLoanReceiptPaymentPlansInfo = (ACLoanReceiptPaymentPlansInfo)objLoanReceiptPaymentPlansController.GetObjectByID(mainObject.FK_ACLoanReceiptPaymentPlanID);
            if (objLoanReceiptPaymentPlansInfo != null)
            {
                ACEntryTypesController objEntryTypesController = new ACEntryTypesController();
                ACEntryTypesInfo objNoGopEntryTypes = (ACEntryTypesInfo)objEntryTypesController.GetObjectByName(AccEntryName.TraTienNoGop);
                ACEntryTypesInfo objLaiVayEntryTypes = (ACEntryTypesInfo)objEntryTypesController.GetObjectByName(AccEntryName.TraTienLaiVay);
                int noGopEntryTypeID = objNoGopEntryTypes != null ? objNoGopEntryTypes.ACEntryTypeID : 0;
                int laiVayEntryTypeID = objLaiVayEntryTypes != null ? objLaiVayEntryTypes.ACEntryTypeID : 0;
                decimal amount = entity.PaymentVoucherItemList.Where(o => o.FK_ACEntryTypeID > 0
                                                                        && (o.FK_ACEntryTypeID == noGopEntryTypeID || o.FK_ACEntryTypeID == laiVayEntryTypeID))
                                                              .Sum(o1 => o1.APPaymentVoucherItemAmount);
                if (amount > objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanPayment - objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActualRootPayment - objLoanReceiptPaymentPlansInfo.ACLoanReceiptPaymentPlanActialProfitsPayment)
                {
                    MessageBox.Show("Tổng tiền nợ góp/lãi vay không được lớn hơn số tiền nợ góp kế hoạch còn lại của khế ước", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            return false;
        }

        public void ChangeLoanReceipt(int loanReceiptID)
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVouchersInfo mainObject = (APPaymentVouchersInfo)entity.MainObject;
            ACLoanReceiptsInfo objLoanReceiptsInfo = (new ACLoanReceiptsController()).GetLoanReceiptByID(loanReceiptID);
            if (objLoanReceiptsInfo != null)
            {
                mainObject.FK_ACLoanReceiptID = objLoanReceiptsInfo.ACLoanReceiptID;
                if (mainObject.APPaymentVoucherPurpose == PaymentVoucherPurpose.Payment.ToString())
                {
                    entity.PaymentVoucherItemList.Clear();
                    mainObject.FK_GECurrencyID = objLoanReceiptsInfo.FK_GECurrencyID;
                    mainObject.APPaymentVoucherExchangeRate = objLoanReceiptsInfo.ACLoanReceiptExchangeRate;

                    ACBankTransactionItemsController objBankTransactionItemsController = new ACBankTransactionItemsController();
                    ACBankTransactionItemsInfo objBankTransactionItemsInfo = objBankTransactionItemsController.CreateBankTransactionItemByLoanReceiptID(loanReceiptID);
                    if (objBankTransactionItemsInfo != null && objBankTransactionItemsInfo.ACBankTransactionItemAmount > 0)
                    {
                        APPaymentVoucherItemsInfo objPaymentVoucherItemsInfo = new APPaymentVoucherItemsInfo();
                        objPaymentVoucherItemsInfo.FK_ACDebitAccountID = objBankTransactionItemsInfo.FK_ACDebitAccountID;
                        objPaymentVoucherItemsInfo.FK_ACCreditAccountID = objBankTransactionItemsInfo.FK_ACCreditAccountID;
                        objPaymentVoucherItemsInfo.APPaymentVoucherItemAmount = objBankTransactionItemsInfo.ACBankTransactionItemAmount;
                        objPaymentVoucherItemsInfo.APPaymentVoucherItemDesc = objBankTransactionItemsInfo.ACBankTransactionItemDesc;
                        mainObject.APPaymentVoucherDesc = objBankTransactionItemsInfo.ACBankTransactionItemDesc;
                        entity.PaymentVoucherItemList.Add(objPaymentVoucherItemsInfo);
                    }
                    ChangeExchangeRate();
                }
                entity.UpdateMainObjectBindingSource();
            }
        }

        private bool CheckRelativeDocument()
        {
            APPaymentVouchersInfo mainObject = (APPaymentVouchersInfo)CurrentModuleEntity.MainObject;
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            List<ACDocumentsInfo> documentsList = objDocumentsController.GetRelativeDocumentListByPaymentVoucherID(mainObject.APPaymentVoucherID);

            if (documentsList.Count() > 0)
            {
                MessageBox.Show(string.Format("Không thể thực hiện do đã tạo các chứng từ sau:" + Environment.NewLine + "-{0}", string.Join("\n-", documentsList.Select(o => o.ACDocumentNo).ToArray()))
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return false;
            }
            if (mainObject.APPaymentVoucherPurpose == PaymentVoucherPurpose.LoanReceipt.ToString())
            {
                MessageBox.Show("Không thể thực hiện thao tác này với chứng từ Trả tiền lãi vay và nợ gốc cho khế ước!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return false;
            }
            return CheckUnifinishedCost();
        }

        public bool CheckUnifinishedCost()
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVoucherItemsInfo itemValidate = entity.PaymentVoucherItemList.FirstOrDefault(o => o.FK_ACUnfinishedConstructionCostID > 0);
            if (itemValidate != null)
            {
                ACUnfinishedConstructionCostsController unfinishedCostController = new ACUnfinishedConstructionCostsController();
                ACUnfinishedConstructionCostsInfo unfinishedCost = new ACUnfinishedConstructionCostsInfo();

                foreach (APPaymentVoucherItemsInfo item in entity.PaymentVoucherItemList)
                {
                    unfinishedCost = unfinishedCostController.GetObjectByID(item.FK_ACUnfinishedConstructionCostID) as ACUnfinishedConstructionCostsInfo;
                    if (unfinishedCost != null
                            && (unfinishedCost.ACUnfinishedConstructionCostStatus == UnfinishedConstructionCostStatus.Complete.ToString()
                                || unfinishedCost.ACUnfinishedConstructionCostStatus == UnfinishedConstructionCostStatus.ChuyenTSCD.ToString()))
                    {
                        MessageBox.Show(string.Format("Chi phí XDCB dở dang {0} ({1}) đã Hoàn tất hoặc Ghi tăng tài sản"
                                                        + Environment.NewLine + "Bạn không thể thực hiện thao tác này!", unfinishedCost.ACUnfinishedConstructionCostNo, unfinishedCost.ACUnfinishedConstructionCostName)
                                        , CommonLocalizedResources.MessageBoxDefaultCaption
                                        , MessageBoxButtons.OK
                                        , MessageBoxIcon.Information);
                        return false;
                    }
                }
                return true;
            }
            return true;
        }

        public override void ActionDuplicate()
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVouchersInfo mainObject = (APPaymentVouchersInfo)entity.MainObject;
            if (mainObject.APPaymentVoucherPurpose != PaymentVoucherPurpose.Payment.ToString())
            {
                MessageBox.Show("Không thể tạo bản sảo cho chứng từ tạo mới khác thông thường",
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            base.ActionDuplicate();
            mainObject.APPaymentVoucherStatus = PaymentVoucherStatus.New.ToString();
            mainObject.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            mainObject.AAUpdatedDate = DateTime.MaxValue;
            mainObject.AAUpdatedUser = String.Empty;
            mainObject.APPaymentVoucherPurpose = PaymentVoucherPurpose.Payment.ToString();
            ToolbarNewActionName = mainObject.STToolbarActionName;

            entity.PaymentVoucherItemList.Duplicate();
            entity.PaymentVoucherItemList.GridControl?.RefreshDataSource();
            entity.AdvanceRequestPaymentTimeList.GridControl?.RefreshDataSource();
            entity.DocumentEntryList.GridControl?.RefreshDataSource();
        }
        #region Xử lý chênh lệch tỷ giá Trả nợ vay
        private void CalculateExchangeRateDiffFee()
        {
            PaymentVoucherEntities entity = (PaymentVoucherEntities)CurrentModuleEntity;
            APPaymentVouchersInfo mainObject = (APPaymentVouchersInfo)entity.MainObject;
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            GECurrenciesInfo objCurrenciesInfo = (GECurrenciesInfo)objCurrenciesController.GetObjectByID(mainObject.FK_GECurrencyID);
            if ((objCurrenciesInfo != null && objCurrenciesInfo.GECurrencyNo != CurrencyNo.VND.ToString()) || mainObject.APPaymentVoucherExchangeRate != 1)
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
                        decimal traTienGoc = entity.PaymentVoucherItemList.Where(o => o.FK_ACDebitAccountID == objLoanReceiptTypesInfo.FK_ACAccountID).Sum(o => o.APPaymentVoucherItemAmount);
                        tyGiaTT = Math.Min(objLoanReceiptsInfo.ACLoanReceiptExchangeRate, mainObject.APPaymentVoucherExchangeRate);
                        if (objLoanReceiptsInfo.ACLoanReceiptExchangeRate > mainObject.APPaymentVoucherExchangeRate)
                        {
                            tienLai = traTienGoc * Math.Abs(objLoanReceiptsInfo.ACLoanReceiptExchangeRate - mainObject.APPaymentVoucherExchangeRate);
                        }
                        if (objLoanReceiptsInfo.ACLoanReceiptExchangeRate < mainObject.APPaymentVoucherExchangeRate)
                        {
                            tienLo = traTienGoc * Math.Abs(objLoanReceiptsInfo.ACLoanReceiptExchangeRate - mainObject.APPaymentVoucherExchangeRate);
                        }
                    }
                }
                if (tienLai > 0)
                {
                    mainObject.APPaymentVoucherExchangeRateDiffFee = tienLai;
                }
                else if (tienLo > 0)
                {
                    mainObject.APPaymentVoucherExchangeRateDiffFee = -tienLo;
                }
                entity.UpdateMainObject();
            }
        }
        #endregion
    }
}
