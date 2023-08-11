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
using System.Text;
using System.Windows.Forms;

namespace BOSERP.Modules.ReceiptVoucher
{
    public class ReceiptVoucherModule : BaseTransactionModule
    {
        #region Constant
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], ENDs
        public const string CSCashFundLookupEditControlName = "fld_lkeFK_CSCashFundID";
        #endregion

        #region Variables

        #endregion

        #region Public properties
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public BOSLookupEdit CSCashFundLookupEditControl;
        #endregion

        #region Constructor
        public ReceiptVoucherModule()
        {
            Name = "ReceiptVoucher";
            CurrentModuleEntity = new ReceiptVoucherEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[ReceiptVoucherModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
            CSCashFundLookupEditControl = (BOSLookupEdit)Controls[ReceiptVoucherModule.CSCashFundLookupEditControlName];
            CSCashFundsController objCashFundsController = new CSCashFundsController();
            CSCashFundLookupEditControl.Properties.DataSource = objCashFundsController.GetListCashFundsByBranchID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
        }
        #endregion

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            ARReceiptVouchersController objReceiptVouchersController = new ARReceiptVouchersController();
            ACObjectsController objObjectsController = new ACObjectsController();
            ARReceiptVouchersInfo searchObject = (ARReceiptVouchersInfo)CurrentModuleEntity.SearchObject;
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(searchObject.ACObjectAccessKey);
            //NUThao [ADD] [08/04/2014] [DB centre]earchObject.ARInvoiceSOContactPhone);
            //DataSet ds = objReceiptVouchersController.GetReceiptVoucherList(
            //                                                           searchObject.ARReceiptVoucherNo,
            //                                                           objObjectsInfo.ACObjectID,
            //                                                           objObjectsInfo.ACObjectType,
            //                                                           searchObject.ARReceiptVoucherType,
            //                                                           searchObject.FK_HREmployeeID,
            //                                                           searchObject.ReceiptVoucherDateFrom,
            //                                                           searchObject.ReceiptVoucherDateTo);
            DataSet ds = new DataSet();
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objReceiptVouchersController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objReceiptVouchersController.GetReceiptVoucherListDatasetByListOfBranchID(
                                                                        searchObject.ARReceiptVoucherNo,
                                                                        objObjectsInfo.ACObjectID,
                                                                        objObjectsInfo.ACObjectType,
                                                                        searchObject.ARReceiptVoucherType,
                                                                        searchObject.FK_HREmployeeID,
                                                                        searchObject.ReceiptVoucherDateFrom,
                                                                        searchObject.ReceiptVoucherDateTo,
                                                                        BranchList);
                }
            }
            else
            {
                ds = objReceiptVouchersController.GetReceiptVoucherListDataset(
                                                                        searchObject.ARReceiptVoucherNo,
                                                                        objObjectsInfo.ACObjectID,
                                                                        objObjectsInfo.ACObjectType,
                                                                        searchObject.ARReceiptVoucherType,
                                                                        searchObject.FK_HREmployeeID,
                                                                        searchObject.ReceiptVoucherDateFrom,
                                                                        searchObject.ReceiptVoucherDateTo,
                                                                        searchObject.FK_BRBranchID);
            }

            return ds;

            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END

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
        /// Update receipt voucher total amount and exchange amount
        /// </summary>
        private void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                ReceiptVoucherEntities entity = (ReceiptVoucherEntities)CurrentModuleEntity;
                ARReceiptVouchersInfo objReceiptVouchersInfo = (ARReceiptVouchersInfo)entity.MainObject;
                objReceiptVouchersInfo.ARReceiptVoucherTotalAmount = entity.ReceiptVoucherItemList.Sum(i => i.ARReceiptVoucherItemAmount);
                BOSApp.RoundByCurrency(objReceiptVouchersInfo, "ARReceiptVoucherTotalAmount", objReceiptVouchersInfo.FK_GECurrencyID);
                objReceiptVouchersInfo.ARReceiptVoucherExchangeAmount = entity.ReceiptVoucherItemList.Sum(i => i.ARReceiptVoucherItemExchangeAmount);
                BOSApp.RoundByCurrency(objReceiptVouchersInfo, "ARReceiptVoucherExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);

                entity.UpdateMainObjectBindingSource();
                UpdateDocumentEntries();
            }
        }

        /// <summary>
        /// Called when the user changes the amount of a voucher item
        /// </summary>
        /// <param name="objReceiptVoucherItemsInfo">Changed item</param>
        public void ChangeReceiptVoucherItemAmount(ARReceiptVoucherItemsInfo objReceiptVoucherItemsInfo)
        {
            ARReceiptVouchersInfo receiptVoucher = (ARReceiptVouchersInfo)CurrentModuleEntity.MainObject;
            objReceiptVoucherItemsInfo.ARReceiptVoucherItemExchangeAmount = objReceiptVoucherItemsInfo.ARReceiptVoucherItemAmount * receiptVoucher.ARReceiptVoucherExchangeRate;
            BOSApp.RoundByCurrency(objReceiptVoucherItemsInfo, "ARReceiptVoucherItemAmount", receiptVoucher.FK_GECurrencyID);
            BOSApp.RoundByCurrency(objReceiptVoucherItemsInfo, "ARReceiptVoucherExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
        }
        public void ChangeExchangeRate()
        {
            ReceiptVoucherEntities entity = (ReceiptVoucherEntities)CurrentModuleEntity;
            ARReceiptVouchersInfo receiptVoucher = (ARReceiptVouchersInfo)entity.MainObject;
            entity.ReceiptVoucherItemList.ForEach(p =>
            {
                ChangeReceiptVoucherItemAmount(p);
            });
            UpdateDocumentEntries();
            entity.ReceiptVoucherItemList.GridControl.RefreshDataSource();
        }
        /// <summary>
        /// Called when the user changes the object
        /// </summary>
        /// <param name="objectAccessKey">Target object access key</param>
        public void ChangeObject(string objectAccessKey)
        {
            ReceiptVoucherEntities entity = (ReceiptVoucherEntities)CurrentModuleEntity;
            ARReceiptVouchersInfo objReceiptVoucher = (ARReceiptVouchersInfo)CurrentModuleEntity.MainObject;
            objReceiptVoucher.ACObjectAccessKey = objectAccessKey;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            if (objObjectsInfo != null)
            {
                objReceiptVoucher.FK_ACObjectID = objObjectsInfo.ACObjectID;
                objReceiptVoucher.ARObjectType = objObjectsInfo.ACObjectType;
                objReceiptVoucher.ARReceiptVoucherSenderName = objObjectsInfo.ACObjectName;
                objReceiptVoucher.ACObjectName = objObjectsInfo.ACObjectName;
                objReceiptVoucher.ARReceiptVoucherObjectTaxNumber = objObjectsInfo.ACObjectTaxNumber;
                entity.ReceiptVoucherItemList.ForEach(x =>
                {
                    if(x.FK_ACCreditAccountID <= 0 || objReceiptVoucher.ARReceiptVoucherPurpose == ReceiptVoucherPurpose.Normal.ToString())
                    {
                        x.FK_ACCreditAccountID = objObjectsInfo.FK_ACAccountSaleID;
                    }
                });
                entity.UpdateMainObjectBindingSource();
                entity.ReceiptVoucherItemList.GridControl?.RefreshDataSource();
            }
        }

        /// <summary>
        /// Called when the user changes the cash fund
        /// </summary>
        /// <param name="cashFundID">Selected cash fund id</param>
        public void ChangeCashFund(int cashFundID)
        {
            ReceiptVoucherEntities entity = (ReceiptVoucherEntities)CurrentModuleEntity;
            ARReceiptVouchersInfo objARReceiptVouchersInfo = (ARReceiptVouchersInfo)entity.MainObject;
            objARReceiptVouchersInfo.FK_CSCashFundID = cashFundID;
            CSCashFundsController objCSCashFundsController = new CSCashFundsController();
            CSCashFundsInfo objCSCashFundsInfo = (CSCashFundsInfo)objCSCashFundsController.GetObjectByID(objARReceiptVouchersInfo.FK_CSCashFundID);
            if (objCSCashFundsInfo != null && objCSCashFundsInfo.FK_ACAcountID > 0)
            {
                entity.ReceiptVoucherItemList.ForEach(x => x.FK_ACDebitAccountID = objCSCashFundsInfo.FK_ACAcountID);
                entity.ReceiptVoucherItemList.GridControl.RefreshDataSource();
            }
            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }
        /// <summary>
        /// Remove the selected receipt voucher item from its list
        /// </summary>
        public void RemoveSelectedItem()
        {
            ReceiptVoucherEntities entity = (ReceiptVoucherEntities)CurrentModuleEntity;
            entity.ReceiptVoucherItemList.RemoveSelectedRowObjectFromList();
            UpdateTotalAmount();
        }

        public override int ActionSave()
        {
            ReceiptVoucherEntities entity = (ReceiptVoucherEntities)CurrentModuleEntity;
            ARReceiptVouchersInfo receiptVoucher = (ARReceiptVouchersInfo)CurrentModuleEntity.MainObject;
            if (string.IsNullOrEmpty(receiptVoucher.ACObjectAccessKey))
            {
                MessageBox.Show("Vui lòng chọn đối tượng.", "#message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }

            if (receiptVoucher.FK_CSCashFundID <= 0)
            {
                MessageBox.Show("Vui lòng chọn quỹ tiền mặt.", "#message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            if (entity.ReceiptVoucherItemList != null && entity.ReceiptVoucherItemList.Count() > 0)
            {
                bool allowSave = true;
                HRAdvanceRefundsController objAdvanceRefundsController = new HRAdvanceRefundsController();
                HRAdvanceRefundsInfo objAdvanceRefundsInfo = null;
                entity.ReceiptVoucherItemList.ForEach(o =>
                {
                    if (o.FK_HRAdvanceRefundID > 0)
                    {
                        objAdvanceRefundsInfo = objAdvanceRefundsController.GetObjectByID(o.FK_HRAdvanceRefundID) as HRAdvanceRefundsInfo;
                        if (objAdvanceRefundsInfo != null && objAdvanceRefundsInfo.HRAdvanceRefundTotalAmount < o.ARReceiptVoucherItemAmount)
                            allowSave = false;
                    }
                });
                if (allowSave == false)
                {
                    MessageBox.Show("Số tiền không thể vượt quá tổng tiền ở Phiếu hoàn ứng!", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 0;
                }
            }

            if (receiptVoucher.ARReceiptVoucherPurpose == ReceiptVoucherPurpose.AdvanceRefund.ToString() ||
                receiptVoucher.ARReceiptVoucherPurpose == ReceiptVoucherPurpose.Normal.ToString() ||
                receiptVoucher.ARReceiptVoucherPurpose == ReceiptVoucherPurpose.SupplierRepaid.ToString())
            {
                if (entity.ReceiptVoucherItemList != null && entity.ReceiptVoucherItemList.Count > 0
                        && entity.ReceiptVoucherItemList.Where(x => (x.FK_ACCreditAccountID == 0 || x.FK_ACDebitAccountID == 0)).ToList().Count > 0)
                {
                    BOSApp.ShowMessage("Vui lòng chọn tài khoản  ở dưới lưới!");
                    return 0;
                }
            }


            //foreach (ARReceiptVoucherItemsInfo item in entity.ReceiptVoucherItemList)
            //{
            //    ACAccountsController objAccountsController = new ACAccountsController();
            //    List<ACAccountsInfo> accountsList = (List<ACAccountsInfo>)objAccountsController.IsAccountOrChildOfAccount(item.FK_ACCreditAccountID, AccAccount.Acc131.ToString());
            //    if (accountsList != null && accountsList.Count > 0)
            //    {
            //        allowSave = false;
            //    }
            //}
            //if (allowSave == false)
            //{
            //    MessageBox.Show("Không được phép chọn tài khoản 131.", "#message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return 0;
            //}
            entity.ReceiptVoucherItemList.EndCurrentEdit();
            if (entity.ReceiptVoucherItemList.Count() > 0)
            {
                receiptVoucher.ARReceiptVoucherReference = entity.ReceiptVoucherItemList.GroupBy(x => x.ARReceiptVoucherItemReference).Aggregate(
                    new StringBuilder(),
                    (current, next) => current.Append(current.Length == 0 ? "" : ", ").Append(next.FirstOrDefault().ARReceiptVoucherItemReference))
                .ToString();
            }
            UpdateTotalAmount();
            int receiptVoucherID = base.ActionSave();
            return receiptVoucherID;
        }

        public override int GetDocumentTypeID()
        {
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            int documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.PhieuThu.ToString());
            return documentTypeID;
        }

        /// <summary>
        /// Init receipt voucher report for displaying
        /// </summary>
        /// <param name="report">Report</param>
        /// <param name="receiptVoucherID">Receipt voucher id</param>
        private static void InitReceiptVoucherReport(XtraReport report, int receiptVoucherID)
        {
            ADReportsController objReportsController = new ADReportsController();
            GECurrenciesController objCurrencyController = new GECurrenciesController();
            List<ARReceiptVoucherItemsInfo> receiptVoucherItemList = objReportsController.GetReceiptVoucherItemListByReceiptVoucherID(receiptVoucherID);
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
            ARReceiptVouchersInfo objReceiptVouchersInfo = (ARReceiptVouchersInfo)objReceiptVouchersController.GetObjectByID(receiptVoucherID);
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
                        amountWordTop.Text = "Đã nhận đủ số tiền " + ConvertAmountToWord.ReadAmount(objReceiptVouchersInfo.ARReceiptVoucherExchangeAmount.ToString(), defaultCurrencyID);
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

        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                PrintReceiptVoucher(Toolbar.CurrentObjectID);
            }
        }

        /// <summary>
        /// Print a receipt voucher
        /// </summary>
        /// <param name="receiptVoucherID">Receipt voucher id</param>
        public static void PrintReceiptVoucher(int receiptVoucherID)
        {
            RPReceiptVoucher report = new RPReceiptVoucher();
            //report.LoadLayout(BOSCommon.Constants.Report.DevInvoiceItemReportPath);
            InitReceiptVoucherReport(report, receiptVoucherID);
            XRLabel label = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel13"];
            if (label != null)
            {
                label.Visible = false;
            }
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevReceiptVoucherPath, true);
            reviewer.Show();
        }

        public static void PrintReceiptVoucher(int receiptVoucherID, string customerPaymentType)
        {
            RPReceiptVoucher report = new RPReceiptVoucher();
            //report.LoadLayout(BOSCommon.Constants.Report.DevInvoiceItemReportPath);
            InitReceiptVoucherReport(report, receiptVoucherID);
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

        #region Accounting
        public bool IsCreateFromAdvanceRefund()
        {
            ReceiptVoucherEntities entity = (ReceiptVoucherEntities)CurrentModuleEntity;

            ARReceiptVoucherItemsInfo pvi = entity.ReceiptVoucherItemList.FirstOrDefault(t => t.FK_HRAdvanceRefundID > 0);

            return (pvi != null);
        }

        protected override void UpdateDocumentEntries()
        {
            ReceiptVoucherEntities entity = (ReceiptVoucherEntities)CurrentModuleEntity;
            ARReceiptVouchersInfo objARReceiptVouchersInfo = (ARReceiptVouchersInfo)entity.MainObject;
            entity.DocumentEntryList.Clear();
            //ACAccountsController accountController = new ACAccountsController();
            //ACAccountsInfo account = accountController.GetObjectByNo(AccAccount.Acc1111) as ACAccountsInfo;

            CSCashFundsController objCSCashFundsController = new CSCashFundsController();
            CSCashFundsInfo objCSCashFundsInfo = (CSCashFundsInfo)objCSCashFundsController.GetObjectByID(objARReceiptVouchersInfo.FK_CSCashFundID);
            ACEntryTypesController objACEntryTypesController = new ACEntryTypesController();
            ACEntryTypesInfo objACEntryTypesInfo;
            ACObjectsController objectsController = new ACObjectsController();
            ACObjectsInfo objectsInfo = objectsController.GetObjectByIDAndType(objARReceiptVouchersInfo.FK_ACObjectID, objARReceiptVouchersInfo.ARObjectType);
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                       AccDocumentType.PhieuThu.ToString(),
                                                                       AccEntryType.ThuTienNhaCungCap.ToString());
            foreach (ARReceiptVoucherItemsInfo item in entity.ReceiptVoucherItemList)
            {
                if (objCSCashFundsInfo != null && objCSCashFundsInfo.FK_ACAcountID > 0)
                {
                    item.FK_ACDebitAccountID = objCSCashFundsInfo.FK_ACAcountID;
                }
                if (IsCreateFromAdvanceRefund())
                {
                    objACEntryTypesInfo = (ACEntryTypesInfo)objACEntryTypesController.GetObjectByName(AccEntryType.ThuTienHoanUng.ToString());
                }
                else
                {
                    objACEntryTypesInfo = (ACEntryTypesInfo)objACEntryTypesController.GetObjectByName(AccEntryType.ThuTienKhachHang.ToString());
                }
                if (objACEntryTypesInfo != null)
                {
                    item.FK_ACEntryTypeID = objACEntryTypesInfo.ACEntryTypeID;
                }
                if (IsCreateFromAdvanceRefund())
                {
                    ACDocumentsController objDocumentsController = new ACDocumentsController();
                    ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                    ARReceiptVoucherItemsInfo pvi = entity.ReceiptVoucherItemList.FirstOrDefault(t => t.FK_HRAdvanceRefundID > 0);
                    ACDocumentsInfo objDocumentsInfo = (ACDocumentsInfo)objDocumentsController.GetObjectByNo(pvi.ARReceiptVoucherItemReference);
                    if (objDocumentsInfo != null)
                    {
                        List<ACDocumentEntrysInfo> listDocumentEntrysInfo = objDocumentEntrysController.GetAccountingEntries("AdvanceRefund", objDocumentsInfo.ACDocumentID, objDocumentsInfo.ACDocumentNo);
                        ACDocumentEntrysInfo objDocumentEntrysInfo = listDocumentEntrysInfo.Where(p => p.ACDocumentEntryDebitAmount > 0).FirstOrDefault();
                        if (objDocumentEntrysInfo != null)
                            item.FK_ACCreditAccountID = objDocumentEntrysInfo.FK_ACCreditAccountID;
                    }
                }
                else if (objARReceiptVouchersInfo.ARReceiptVoucherPurpose == ReceiptVoucherPurpose.SupplierRepaid.ToString())
                {
                    if (objectsInfo != null && objectsInfo.FK_ACAccountPurchaseID > 0)
                    {
                        item.FK_ACCreditAccountID = objectsInfo.FK_ACAccountPurchaseID;
                    }
                    else
                    {
                        item.FK_ACCreditAccountID = defaultEntry.ACDocTypeEntryAccountDefaultCredit;
                    }
                }
                ACDocumentEntrysInfo entry = new ACDocumentEntrysInfo();
                BOSUtil.CopyObject(item, entry);
                entry.FK_ACDocumentTypeID = entity.DocumentTypeID;
                entity.DocumentEntryList.Add(entry);
            }
        }
        public void UpdateTotalAmountByCurrency(int currencieID)
        {
            ReceiptVoucherEntities entity = (ReceiptVoucherEntities)CurrentModuleEntity;
            ARReceiptVouchersInfo mainObject = (ARReceiptVouchersInfo)entity.MainObject;
            mainObject.FK_GECurrencyID = currencieID;
            decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateTransferByCurrencyAndDate(mainObject.FK_GECurrencyID, mainObject.ARReceiptVoucherDate);
            mainObject.ARReceiptVoucherExchangeRate = (dCurrencyExchangeRate > 0)
                                                               ? dCurrencyExchangeRate
                                                               : 1;
            foreach (ARReceiptVoucherItemsInfo item in entity.ReceiptVoucherItemList)
            {
                BOSApp.RoundByCurrency(item, mainObject.FK_GECurrencyID);
            }
            UpdateTotalAmount();
            entity.ReceiptVoucherItemList.GridControl.RefreshDataSource();

            entity.UpdateMainObjectBindingSource();
        }

        #endregion

        public override void ActionNew()
        {
            base.ActionNew();
            ARReceiptVouchersInfo mainObject = (ARReceiptVouchersInfo)CurrentModuleEntity.MainObject;
            mainObject.ARReceiptVoucherPurpose = ReceiptVoucherPurpose.Normal.ToString();
        }

        public override bool ActionComplete()
        {
            GenerateAccountingData();
            UpdateDocumentEntries();
            return base.ActionComplete();
        }

        public override void ModuleAfterCompleted()
        {
            ActionPosted();
            base.ModuleAfterCompleted();
        }

        public override void InvalidateToolbar()
        {
            ARReceiptVouchersInfo mainObject = (ARReceiptVouchersInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            ParentScreen.SetEnableOfToolbarButton("CancelDocument", false);
            ParentScreen.SetEnableOfToolbarButton("CancelComplete", false);
            if (mainObject.ARReceiptVoucherID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
                ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
                ParentScreen.SetEnableOfToolbarButton("CancelDocument", true);
                if (mainObject.ARReceiptVoucherStatus == ReceiptVoucherStatus.Completed.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                            mainObject.ARReceiptVoucherPostedStatus != PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                        mainObject.ARReceiptVoucherPostedStatus == PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton("CancelDocument", false);
                    ParentScreen.SetEnableOfToolbarButton("CancelComplete", true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, true);
                }
                if (mainObject.ARReceiptVoucherStatus == ReceiptVoucherStatus.Canceled.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton("CancelDocument", false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonPrint, false);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
                }
                if (Toolbar.IsEditAction())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, true);
                }
            }

            base.InvalidateToolbar();
        }

        #region Refund
        public void ActionNewFromAdvanceRefund()
        {
            //if (Toolbar.IsNullOrNoneAction())
            //{
            ActionNew();

            ReceiptVoucherEntities entity = (ReceiptVoucherEntities)CurrentModuleEntity;
            ARReceiptVouchersInfo receiptVoucher = (ARReceiptVouchersInfo)entity.MainObject;
            receiptVoucher.ARReceiptVoucherPurpose = ReceiptVoucherPurpose.AdvanceRefund.ToString();
            HRAdvanceRefundsController harController = new HRAdvanceRefundsController();
            List<HRAdvanceRefundsInfo> harList = harController.GetRefundByType(AdvanceRefundPaymentType.Receipt.ToString());


            guiFind<HRAdvanceRefundsInfo> guiFind = new guiFind<HRAdvanceRefundsInfo>(TableName.HRAdvanceRefundsTableName
                                                                                       , harList
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
                                    , "Thông báo"
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
                                    , "Thông báo"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);
                    goto stampp;
                }
                #endregion

                //Main object
                HRAdvanceRefundsInfo defaultRefund = guiFind.SelectedObjects[0];
                receiptVoucher.FK_ACObjectID = defaultRefund.FK_HREmployeeID;
                receiptVoucher.ARObjectType = ObjectType.Employee.ToString();
                receiptVoucher.FK_GECurrencyID = defaultRefund.FK_GECurrencyID;
                receiptVoucher.ACObjectAccessKey = receiptVoucher.FK_ACObjectID + ";" + receiptVoucher.ARObjectType;
                if (defaultRefund.FK_HREmployeeID > 0)
                {
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    receiptVoucher.ARReceiptVoucherSenderName = objEmployeesController.GetObjectNameByID(defaultRefund.FK_HREmployeeID);
                }

                decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateTransferByCurrencyAndDate(receiptVoucher.FK_GECurrencyID, receiptVoucher.ARReceiptVoucherDate);
                receiptVoucher.ARReceiptVoucherExchangeRate = (dCurrencyExchangeRate > 0) ? dCurrencyExchangeRate : defaultRefund.HRAdvanceRefundExchangeRate;
                receiptVoucher.ARReceiptVoucherDesc = String.Empty;

                //Module Object
                ACDocumentEntrysController entryController = new ACDocumentEntrysController();
                ACDocumentEntrysInfo docEntry = entryController.GetDefaultDocumentEntryByEntryAndDocumentType(AccDocumentType.PhieuThu.ToString()
                                                                                                                , AccEntryType.ThuTienHoanUng.ToString());
                if (docEntry == null)
                {
                    MessageBox.Show("Vui lòng cấu hình bút toán cho loại chứng từ này trước."
                                    , "Thông báo"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);
                    ActionCancel();
                }
                else
                {
                    List<ARReceiptVoucherItemsInfo> pviList = new List<ARReceiptVoucherItemsInfo>();
                    ARReceiptVoucherItemsInfo pviInfo;
                    foreach (HRAdvanceRefundsInfo advanceRefund in guiFind.SelectedObjects)
                    {
                        pviInfo = new ARReceiptVoucherItemsInfo();
                        pviInfo.FK_ACEntryTypeID = docEntry.FK_ACEntryTypeID;
                        pviInfo.FK_ACCreditAccountID = docEntry.FK_ACCreditAccountID;
                        if (advanceRefund.FK_ACCreditAccountID > 0)
                            pviInfo.FK_ACCreditAccountID = advanceRefund.FK_ACCreditAccountID;
                        pviInfo.FK_ACDebitAccountID = docEntry.FK_ACDebitAccountID;
                        pviInfo.FK_ACObjectID = receiptVoucher.FK_ACObjectID;
                        pviInfo.ARObjectType = receiptVoucher.ARObjectType;
                        pviInfo.ARReceiptVoucherItemDesc = docEntry.ACDocumentEntryDesc + " - " + advanceRefund.HRAdvanceRefundNo;
                        pviInfo.FK_HRAdvanceRefundID = advanceRefund.HRAdvanceRefundID;
                        pviInfo.ARReceiptVoucherItemAmount = advanceRefund.HRAdvanceRefundTotalAmount - advanceRefund.HRAdvanceRefundExchangePaymentAmount;
                        pviInfo.ARReceiptVoucherItemExchangeAmount = pviInfo.ARReceiptVoucherItemAmount * receiptVoucher.ARReceiptVoucherExchangeRate;
                        receiptVoucher.ARReceiptVoucherDesc += advanceRefund.HRAdvanceRefundDesc + "\r\n";
                        pviInfo.ARReceiptVoucherItemReference = advanceRefund.HRAdvanceRefundNo;
                        pviList.Add(pviInfo);
                    }

                    entity.ReceiptVoucherItemList.Invalidate(pviList);
                    entity.ReceiptVoucherItemList.GridControl.RefreshDataSource();

                    UpdateTotalAmount();
                    entity.UpdateMainObjectBindingSource();
                }

            }
            else
            {
                ActionCancel();
            }
            //}
        }
        #endregion
        public void ActionNewSupplierRepaid()
        {
            base.ActionNew();
            ReceiptVoucherEntities entity = (ReceiptVoucherEntities)CurrentModuleEntity;
            ARReceiptVouchersInfo mainObject = (ARReceiptVouchersInfo)entity.MainObject;
            mainObject.ARReceiptVoucherPurpose = ReceiptVoucherPurpose.SupplierRepaid.ToString();
            this.GenerateAccountingData();
            APReturnSuppliersController objReturnSuppliersController = new APReturnSuppliersController();
            List<APReturnSuppliersInfo> listReturnSuppliers = objReturnSuppliersController.GetReturnSuppliersForReceiptVoucher(mainObject.FK_BRBranchID);
            ShowSupplierRepaid(listReturnSuppliers);
        }

        private void ShowSupplierRepaid(List<APReturnSuppliersInfo> listReturnSuppliers)
        {
            ReceiptVoucherEntities entity = (ReceiptVoucherEntities)CurrentModuleEntity;
            ARReceiptVouchersInfo mainObject = (ARReceiptVouchersInfo)entity.MainObject;
            guiFind<APReturnSuppliersInfo> guiFind = new guiFind<APReturnSuppliersInfo>(TableName.APReturnSuppliersTableName
                                                                                           , listReturnSuppliers
                                                                                           , this
                                                                                           , true);
        stampp:
            if (guiFind.ShowDialog() == DialogResult.OK)
            {
                List<APReturnSuppliersInfo> results = (List<APReturnSuppliersInfo>)guiFind.SelectedObjects;
                if (results.Count == 0)
                {
                    MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    goto stampp;
                }
                ARReceiptVoucherItemsInfo objReceiptVoucherItemsInfo;
                mainObject.ARReceiptVoucherDesc = ReceiptVoucherLocalizedResources.SupplierRepaidItemDesc;

                APReturnSuppliersInfo invalidSupplierReturn = guiFind.SelectedObjects.FirstOrDefault(t => t.FK_GECurrencyID != guiFind.SelectedObjects[0].FK_GECurrencyID);
                if (invalidSupplierReturn != null)
                {
                    MessageBox.Show(ClearingDebtLocalizedResources.ErrorCurrency,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    goto stampp;
                }
                invalidSupplierReturn = guiFind.SelectedObjects.FirstOrDefault(t => t.FK_ACObjectID != guiFind.SelectedObjects[0].FK_ACObjectID);
                if (invalidSupplierReturn != null)
                {
                    MessageBox.Show(PaymentVoucherLocalizedResources.ErrorObject,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    goto stampp;
                }

                foreach (APReturnSuppliersInfo item in results)
                {
                    mainObject.ARReceiptVoucherDesc += " " + item.ACObjectName + ",";
                    objReceiptVoucherItemsInfo = new ARReceiptVoucherItemsInfo();
                    objReceiptVoucherItemsInfo.ARReceiptVoucherItemReference = item.APReturnSupplierNo;
                    objReceiptVoucherItemsInfo.ARReceiptVoucherItemAmount = item.APReturnSupplierTotalCost;
                    objReceiptVoucherItemsInfo.ARReceiptVoucherItemExchangeAmount = item.APReturnSupplierTotalCost * mainObject.ARReceiptVoucherExchangeRate;
                    objReceiptVoucherItemsInfo.ARReceiptVoucherItemDesc = ReceiptVoucherLocalizedResources.SupplierRepaidItemDesc + " " + item.APReturnSupplierNo;

                    entity.ReceiptVoucherItemList.Add(objReceiptVoucherItemsInfo);
                    entity.ReceiptVoucherItemList.GridControl.RefreshDataSource();
                }
                mainObject.FK_GECurrencyID = results[0].FK_GECurrencyID;
                decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateTransferByCurrencyAndDate(mainObject.FK_GECurrencyID, mainObject.ARReceiptVoucherDate);
                mainObject.ARReceiptVoucherExchangeRate = (dCurrencyExchangeRate > 0) ? dCurrencyExchangeRate : results[0].APReturnSupplierExchangeRate;
                mainObject.FK_ACObjectID = results[0].FK_ACObjectID;
                mainObject.ARObjectType = results[0].APObjectType;
                mainObject.ACObjectAccessKey = mainObject.FK_ACObjectID + ";" + mainObject.ARObjectType;
                mainObject.FK_PMProjectID = results[0].FK_PMProjectID;

                string[] str = mainObject.ARReceiptVoucherDesc.Split(',');
                mainObject.ARReceiptVoucherDesc = str[0];
                UpdateTotalAmount();
                entity.UpdateMainObjectBindingSource();
            }
            else
                ActionCancel();
        }
        public void UpdateItemDesc()
        {
            ReceiptVoucherEntities entity = (ReceiptVoucherEntities)CurrentModuleEntity;
            ARReceiptVouchersInfo mainObject = (ARReceiptVouchersInfo)entity.MainObject;
            if (mainObject.ARReceiptVoucherPurpose == ReceiptVoucherPurpose.Normal.ToString())
            {
                foreach (ARReceiptVoucherItemsInfo item in entity.ReceiptVoucherItemList)
                {
                    item.ARReceiptVoucherItemDesc = mainObject.ARReceiptVoucherDesc;
                }
            }
        }
        public void ActionPosted()
        {
            if (!CheckLock()) return;
            ReceiptVoucherEntities entity = (ReceiptVoucherEntities)CurrentModuleEntity;
            ARReceiptVouchersInfo mainObject = (ARReceiptVouchersInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ARReceiptVoucherPostedStatus = PostedTransactionStatus.Posted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ARReceiptVoucherID, PostedTransactionStatus.Posted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.PostedTransactions(this.Name, mainObject.ARReceiptVoucherID, ModulePostingType.Accounting);
            InvalidateToolbar();
        }

        public void ActionUnPosted()
        {
            if (!CheckLock()) return;
            ReceiptVoucherEntities entity = (ReceiptVoucherEntities)CurrentModuleEntity;
            ARReceiptVouchersInfo mainObject = (ARReceiptVouchersInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.ARReceiptVoucherPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ARReceiptVoucherID, PostedTransactionStatus.UnPosted.ToString());
            entity.SetPropertyChangeEventLock(true);
            GLHelper.UnPostedTransactions(this.Name, mainObject.ARReceiptVoucherID, ModulePostingType.Accounting);
            InvalidateToolbar();
        }

        #region Hủy chứng từ
        public void ActionCancelDocument()
        {
            ReceiptVoucherEntities entity = (ReceiptVoucherEntities)CurrentModuleEntity;
            ARReceiptVouchersInfo mainObject = (ARReceiptVouchersInfo)entity.MainObject;
            if (mainObject.ARReceiptVoucherID > 0)
            {
                if (!CheckRelativeDocument())
                {
                    return;
                }
                entity.SetPropertyChangeEventLock(false);
                if (mainObject.ARReceiptVoucherPostedStatus == PostedTransactionStatus.Posted.ToString())
                {
                    ActionUnPosted();
                }
                mainObject.ARReceiptVoucherStatus = ReceiptVoucherStatus.Canceled.ToString();
                entity.UpdateMainObject();
                entity.SetPropertyChangeEventLock(true);
                InvalidateToolbar();
            }
        }
        #endregion

        #region Mở chứng từ
        public override bool ActionCancelComplete()
        {
            ReceiptVoucherEntities entity = (ReceiptVoucherEntities)CurrentModuleEntity;
            ARReceiptVouchersInfo mainObject = (ARReceiptVouchersInfo)entity.MainObject;
            if (mainObject.ARReceiptVoucherID > 0)
            {
                if (!CheckLock()) return false;
                if (!CheckRelativeDocument())
                {
                    return false;
                }
                entity.SetPropertyChangeEventLock(false);
                if (mainObject.ARReceiptVoucherPostedStatus == PostedTransactionStatus.Posted.ToString())
                {
                    ActionUnPosted();
                }
                mainObject.ARReceiptVoucherStatus = ReceiptVoucherStatus.New.ToString();
                entity.UpdateMainObject();
                entity.SetPropertyChangeEventLock(true);
                base.ActionCancelComplete();
                InvalidateToolbar();
            }
            return true;
        }
        #endregion

        #region Xóa chứng từ
        public override void ActionDelete()
        {
            ReceiptVoucherEntities entity = (ReceiptVoucherEntities)CurrentModuleEntity;
            ARReceiptVouchersInfo mainObject = (ARReceiptVouchersInfo)entity.MainObject.Clone();
            if (mainObject.ARReceiptVoucherID > 0)
            {
                if (!CheckRelativeDocument())
                {
                    return;
                }
                if (mainObject.ARReceiptVoucherPostedStatus == PostedTransactionStatus.Posted.ToString())
                {
                    ActionUnPosted();
                }
                base.ActionDelete();
            }
        }
        #endregion

        private bool CheckRelativeDocument()
        {
            ARReceiptVouchersInfo mainObject = (ARReceiptVouchersInfo)CurrentModuleEntity.MainObject;
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            List<ACDocumentsInfo> documentsList = objDocumentsController.GetRelativeDocumentListByReceiptVoucherID(mainObject.ARReceiptVoucherID);

            if (documentsList.Count() > 0)
            {
                MessageBox.Show(string.Format("Không thể thực hiện do đã tạo các chứng từ sau:" + Environment.NewLine + "-{0}", string.Join("\n-", documentsList.Select(o => o.ACDocumentNo).ToArray()))
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public override void ActionDuplicate()
        {
            ReceiptVoucherEntities entity = (ReceiptVoucherEntities)CurrentModuleEntity;
            ARReceiptVouchersInfo mainObject = (ARReceiptVouchersInfo)entity.MainObject;
            if (mainObject.ARReceiptVoucherPurpose != ReceiptVoucherPurpose.Normal.ToString())
            {
                MessageBox.Show("Không thể tạo bản sảo cho chứng từ tạo mới khác thông thường",
                                    CommonLocalizedResources.MessageBoxDefaultCaption,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            base.ActionDuplicate();
            mainObject.ARReceiptVoucherStatus = ReceiptVoucherStatus.New.ToString();
            mainObject.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            mainObject.AAUpdatedDate = DateTime.MaxValue;
            mainObject.AAUpdatedUser = String.Empty;
            mainObject.ARReceiptVoucherPurpose = ReceiptVoucherPurpose.Normal.ToString();
            ToolbarNewActionName = mainObject.STToolbarActionName;

            entity.ReceiptVoucherItemList.Duplicate();
            entity.ReceiptVoucherItemList.GridControl?.RefreshDataSource();
            entity.DocumentEntryList.GridControl?.RefreshDataSource();
        }
    }
}
