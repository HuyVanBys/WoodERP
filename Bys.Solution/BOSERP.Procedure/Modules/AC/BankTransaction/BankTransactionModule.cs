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

namespace BOSERP.Modules.BankTransaction
{
    public class BankTransactionModule : BaseTransactionModule
    {
        #region Constant
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public const string CSCompanyBankLookupEditControlName = "fld_lkeFK_CSCompanyBankID";
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the document type id
        /// </summary>
        public int DocumentTypeID { get; set; }
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
        public BOSLookupEdit CSCompanyBankLookupEditControl;
        #endregion

        #region Constructor
        public BankTransactionModule()
        {
            Name = ModuleName.BankTransaction;
            CurrentModuleEntity = new BankTransactionEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], END
            CSCompanyBankLookupEditControl = (BOSLookupEdit)Controls[BankTransactionModule.CSCompanyBankLookupEditControlName];
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            CSCompanyBankLookupEditControl.Properties.DataSource = objCompanyBanksController.GetListCompanyBanksByBranchID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
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
            //NUThao [ADD] [08/04/2014] [DB centre] [Search document by BRBranchID], START
            //DataSet ds = objBankTransactionsController.GetBankTransactionList(
            //                                                           searchObject.ACBankTransactionNo,
            //                                                           objObjectsInfo.ACObjectID,
            //                                                           objObjectsInfo.ACObjectType,
            //                                                           BankTransactionType.BankTransfer.ToString(),
            //                                                           searchObject.FK_HREmployeeID,
            //                                                           searchObject.BankTransactionDateFrom,
            //                                                           searchObject.BankTransactionDateTo);

            DataSet ds;
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objBankTransactionsController.GetDataSetByID(-1);
                }
                else
                {

                    ds = objBankTransactionsController.GetBankTransactionListByListOfBranchID(
                                                                        searchObject.ACBankTransactionNo,
                                                                        objObjectsInfo.ACObjectID,
                                                                        objObjectsInfo.ACObjectType,
                                                                        BankTransactionType.BankTransfer.ToString(),
                                                                        searchObject.FK_HREmployeeID,
                                                                        searchObject.BankTransactionDateFrom,
                                                                        searchObject.BankTransactionDateTo,
                                                                        searchObject.FK_BRBranchID,
                                                                        BranchList);
                }
            }
            else
            {
                ds = objBankTransactionsController.GetBankTransactionListByBranchID(
                                                                        searchObject.ACBankTransactionNo,
                                                                        objObjectsInfo.ACObjectID,
                                                                        objObjectsInfo.ACObjectType,
                                                                        BankTransactionType.BankTransfer.ToString(),
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
            BankTransactionEntities entity = (BankTransactionEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;

            if (mainObject.FK_CSCompanyBankID <= 0)
            {
                MessageBox.Show("Vui lòng chọn ngân hàng.", "#message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }

            ACAccountsController objAccountsController = new ACAccountsController();
            ACAccountsInfo account;
            if (entity.BankTransactionItemList.Where(o => o.FK_ACCreditAccountID == 0 || o.FK_ACDebitAccountID == 0).Count() > 0)
            {
                MessageBox.Show(CommonLocalizedResources.ChooseAccountMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            bool isError = false;
            foreach (ACBankTransactionItemsInfo objBankTransactionItemsInfo in entity.BankTransactionItemList)
            {
                account = objAccountsController.GetAccountByID(objBankTransactionItemsInfo.FK_ACCreditAccountID);
                if (account == null || (account != null && account.HasChildAccount == false))
                    account = objAccountsController.GetAccountByID(objBankTransactionItemsInfo.FK_ACDebitAccountID);
                if (account != null && account.HasChildAccount)
                {
                    isError = true;
                    break;
                }
            }
            if (isError)
            {
                MessageBox.Show(CommonLocalizedResources.CannotMakeEntryWithParentAccountMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            entity.BankTransactionItemList.EndCurrentEdit();
            if (entity.BankTransactionItemList.Count() > 0)
            {
                mainObject.ACBankTransactionReference = entity.BankTransactionItemList.GroupBy(x => x.ACBankTransactionItemReference).Aggregate(
                    new StringBuilder(),
                    (current, next) => current.Append(current.Length == 0 ? "" : ", ").Append(next.FirstOrDefault().ACBankTransactionItemReference))
                .ToString();
            }
            UpdateTotalAmount();
            return base.ActionSave();
        }

        public override int GetDocumentTypeID()
        {
            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            int documentTypeID = objDocumentTypesController.GetObjectIDByName(AccDocumentType.NopTienVaoTaiKhoan.ToString());
            return documentTypeID;
        }

        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                PrintBankTransfer(Toolbar.CurrentObjectID);
            }
        }

        /// <summary>
        /// Print a bank transfer
        /// </summary>
        /// <param name="bankTransferID">Bank transfer id</param>
        public static void PrintBankTransfer(int bankTransferID)
        {
            ADReportsController objReportsController = new ADReportsController();
            RPBankTransaction report = new RPBankTransaction();
            List<ACBankTransactionItemsInfo> bankTransactionItemList = objReportsController.GetBankTransactionItemList(bankTransferID);
            foreach (ACBankTransactionItemsInfo objBankTransactionItemsInfo in bankTransactionItemList)
            {
                objBankTransactionItemsInfo.ACBankTransactionItemDesc += String.Format(" theo HĐ/ĐBH: {0}", objBankTransactionItemsInfo.ACBankTransactionNo);
            }
            report.DataSource = bankTransactionItemList;
            InitBankTransferReport(report, bankTransferID);
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRPBankTransactionPath, true);
            reviewer.Show();
        }

        public static void PrintBankTransferA5(int bankTransferID)
        {
            ADReportsController objReportsController = new ADReportsController();
            RPBankTransactionA5 report = new RPBankTransactionA5();
            List<ACBankTransactionItemsInfo> bankTransactionItemList = objReportsController.GetBankTransactionItemList(bankTransferID);
            foreach (ACBankTransactionItemsInfo objBankTransactionItemsInfo in bankTransactionItemList)
            {
                objBankTransactionItemsInfo.ACBankTransactionItemDesc += String.Format(" theo HĐ/ĐBH: {0}", objBankTransactionItemsInfo.ACBankTransactionNo);
            }
            report.DataSource = bankTransactionItemList;
            InitBankTransferReport(report, bankTransferID);
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRPBankTransactionPath, true);
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
            BankTransactionEntities entity = (BankTransactionEntities)CurrentModuleEntity;
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)entity.MainObject;
            objBankTransactionsInfo.FK_CSCompanyBankID = companyBankID;
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(objBankTransactionsInfo.FK_CSCompanyBankID);
            if (objCompanyBanksInfo != null)
            {
                objBankTransactionsInfo.ACBankTransactionReceiverAccount = objCompanyBanksInfo.CSCompanyBankAccount;
                CurrentModuleEntity.UpdateMainObjectBindingSource();
                if (objCompanyBanksInfo.FK_ACAcountID > 0)
                {
                    entity.BankTransactionItemList.ForEach(x => x.FK_ACDebitAccountID = objCompanyBanksInfo.FK_ACAcountID);
                    entity.BankTransactionItemList.GridControl.RefreshDataSource();
                }
                CurrentModuleEntity.UpdateMainObjectBindingSource();
            }
        }

        /// <summary>
        /// Updates the total amount.
        /// </summary>
        private void UpdateTotalAmount()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                BankTransactionEntities entity = (BankTransactionEntities)CurrentModuleEntity;
                ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)entity.MainObject;
                objBankTransactionsInfo.ACBankTransactionTotalAmount = 0;
                objBankTransactionsInfo.ACBankTransactionExchangeAmount = 0;
                foreach (ACBankTransactionItemsInfo item in entity.BankTransactionItemList)
                {
                    BOSApp.RoundByCurrency(item, "ACBankTransactionItemAmount", objBankTransactionsInfo.FK_GECurrencyID);
                    BOSApp.RoundByCurrency(item, "ACBankTransactionItemExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                    BOSApp.RoundByCurrency(item, "ACBankTransactionItemTotalAmount", objBankTransactionsInfo.FK_GECurrencyID);
                    BOSApp.RoundByCurrency(item, "ACBankTransactionItemTotalExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                    objBankTransactionsInfo.ACBankTransactionTotalAmount += item.ACBankTransactionItemTotalAmount;
                    objBankTransactionsInfo.ACBankTransactionExchangeAmount += item.ACBankTransactionItemTotalExchangeAmount;
                }
                BOSApp.RoundByCurrency(objBankTransactionsInfo, "ACBankTransactionTotalAmount", objBankTransactionsInfo.FK_GECurrencyID);
                BOSApp.RoundByCurrency(objBankTransactionsInfo, "ACBankTransactionExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                // objBankTransactionsInfo.ACBankTransactionTotalAmount = entity.BankTransactionItemList.Sum(i => i.ACBankTransactionItemAmount);
                // objBankTransactionsInfo.ACBankTransactionExchangeAmount = entity.BankTransactionItemList.Sum(i => i.ACBankTransactionItemExchangeAmount);
                entity.BankTransactionItemList.GridControl.RefreshDataSource();
                entity.UpdateMainObjectBindingSource();
                UpdateDocumentEntries();
            }
        }

        public void ChangeCurrency(int currencyID)
        {
            BankTransactionEntities entity = (BankTransactionEntities)CurrentModuleEntity;
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)entity.MainObject;
            objBankTransactionsInfo.FK_GECurrencyID = currencyID;
            decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateTransferByCurrencyAndDate(objBankTransactionsInfo.FK_GECurrencyID, objBankTransactionsInfo.ACBankTransactionDate);
            objBankTransactionsInfo.ACBankTransactionExchangeRate = dCurrencyExchangeRate > 0 ? dCurrencyExchangeRate : 1;
            ChangeExchangeRate();
        }

        public void ChangeLoanReceipt(int loanReceiptID)
        {
            BankTransactionEntities entity = (BankTransactionEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;
            ACLoanReceiptsInfo objLoanReceiptsInfo = (new ACLoanReceiptsController()).GetLoanReceiptByID(loanReceiptID);
            if (objLoanReceiptsInfo != null)
            {
                mainObject.FK_ACLoanReceiptID = objLoanReceiptsInfo.ACLoanReceiptID;
                mainObject.FK_GECurrencyID = objLoanReceiptsInfo.FK_GECurrencyID;
                decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateTransferByCurrencyAndDate(mainObject.FK_GECurrencyID, mainObject.ACBankTransactionDate);
                mainObject.ACBankTransactionExchangeRate = dCurrencyExchangeRate > 0 ? dCurrencyExchangeRate : 1;
                entity.BankTransactionItemList.ForEach(o => o.FK_ACCreditAccountID = objLoanReceiptsInfo.FK_ACAccountID);
                entity.BankTransactionItemList.GridControl.RefreshDataSource();
                entity.UpdateMainObjectBindingSource();
            }
        }

        /// <summary>
        /// Changes the bank transfer item amount.
        /// </summary>
        /// <param name="item">Changed item</param>
        public void ChangeBankTransferItemAmount(ACBankTransactionItemsInfo item)
        {
            ACBankTransactionsInfo bankTransfer = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            item.ACBankTransactionItemExchangeAmount = item.ACBankTransactionItemAmount * bankTransfer.ACBankTransactionExchangeRate;
            item.ACBankTransactionItemTaxAmount = item.ACBankTransactionItemAmount * item.ACBankTransactionItemTaxPercent / 100;
            item.ACBankTransactionItemTotalAmount = item.ACBankTransactionItemAmount + item.ACBankTransactionItemTaxAmount;
            //item.ACBankTransactionItemTotalExchangeAmount = item.ACBankTransactionItemTotalAmount * bankTransfer.ACBankTransactionExchangeRate;
            item.ACBankTransactionItemTotalExchangeAmount = item.ACBankTransactionItemExchangeAmount - (item.ACBankTransactionItemTaxAmount + item.ACBankTransactionItemFeeAmount) * bankTransfer.ACBankTransactionExchangeRate;

            BOSApp.RoundByCurrency(item, "ACBankTransactionItemAmount", bankTransfer.FK_GECurrencyID);
            BOSApp.RoundByCurrency(item, "ACBankTransactionItemExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
            BOSApp.RoundByCurrency(item, "ACBankTransactionItemTotalAmount", bankTransfer.FK_GECurrencyID);
            BOSApp.RoundByCurrency(item, "ACBankTransactionItemTotalExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
        }

        public void ChangeBankTransferItemExchangeAmount(ACBankTransactionItemsInfo item)
        {
            UpdateTotalAmount();
        }

        /// <summary>
        /// Remove the selected bank transaction item from its list
        /// </summary>
        public void RemoveSelectedItem()
        {
            BankTransactionEntities entity = (BankTransactionEntities)CurrentModuleEntity;
            entity.BankTransactionItemList.RemoveSelectedRowObjectFromList();
            UpdateTotalAmount();
        }

        /// <summary>
        /// Inits the bank transfer report
        /// </summary>
        /// <param name="report">The report.</param>    
        /// <param name="bankTransferID">Bank transfer id</param>
        private static void InitBankTransferReport(XtraReport report, int bankTransferID)
        {
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
            ACBankTransactionsInfo objBankTransactionsInfo = (ACBankTransactionsInfo)objBankTransactionsController.GetObjectByID(bankTransferID);
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
        #endregion        

        #region Accounting
        protected override void UpdateDocumentEntries()
        {
            BankTransactionEntities entity = (BankTransactionEntities)CurrentModuleEntity;
            ACBankTransactionsInfo bankTransfer = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;

            CSCompanyBanksController objCSCompanyBanksController = new CSCompanyBanksController();
            CSCompanyBanksInfo objCSCompanyBanksInfo = (CSCompanyBanksInfo)objCSCompanyBanksController.GetObjectByID(bankTransfer.FK_CSCompanyBankID);
            ACObjectsController objectsController = new ACObjectsController();
            ACObjectsInfo objectsInfo = objectsController.GetObjectByIDAndType(bankTransfer.FK_ACObjectID, bankTransfer.ACObjectType);
            ACDocTypeEntrysController objDocTypeEntrysController = new ACDocTypeEntrysController();
            ACDocTypeEntrysInfo defaultEntry = objDocTypeEntrysController.GetEntryByDocumentTypeAndEntryType(
                                                                       AccDocumentType.NopTienVaoTaiKhoan.ToString(),
                                                                       AccEntryType.ThuTienNhaCungCap.ToString());
            foreach (ACBankTransactionItemsInfo item in entity.BankTransactionItemList)
            {
                if (objCSCompanyBanksInfo != null && objCSCompanyBanksInfo.FK_ACAcountID > 0)
                {
                    item.FK_ACDebitAccountID = objCSCompanyBanksInfo.FK_ACAcountID;
                }
                if (bankTransfer.ACBankTransactionCreateFrom == BankTransactionCreateFrom.SupplierRepaid.ToString())
                {
                    if (objectsInfo != null && objectsInfo.FK_ACAccountPurchaseID > 0)
                    {
                        item.FK_ACCreditAccountID = objectsInfo.FK_ACAccountPurchaseID;
                    }
                    else
                    {
                        item.FK_ACCreditAccountID = defaultEntry.ACDocTypeEntryAccountDefaultCredit;
                    }
                };
                BOSApp.RoundByCurrency(item, "ACBankTransactionItemAmount", bankTransfer.FK_GECurrencyID);
                BOSApp.RoundByCurrency(item, "ACBankTransactionItemTotalAmount", bankTransfer.FK_GECurrencyID);
                BOSApp.RoundByCurrency(item, "ACBankTransactionItemExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                BOSApp.RoundByCurrency(item, "ACBankTransactionItemTotalExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
            }
        }
        #endregion

        public void UpdateItemDesc()
        {
            BankTransactionEntities entity = (BankTransactionEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            foreach (ACBankTransactionItemsInfo item in entity.BankTransactionItemList)
            {
                item.ACBankTransactionItemDesc = mainObject.ACBankTransactionDesc;
            }
        }
        public void ActionPosted()
        {
            if (!CheckLock()) return;
            CurrentModuleEntity.SetPropertyChangeEventLock(false);
            BankTransactionEntities entity = (BankTransactionEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;
            mainObject.ACBankTransactionPostedStatus = PostedTransactionStatus.Posted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACBankTransactionID, PostedTransactionStatus.Posted.ToString());
            GLHelper.PostedTransactions(this.Name, mainObject.ACBankTransactionID, ModulePostingType.Accounting);
            InvalidateToolbar();
            if (mainObject.FK_ACLoanReceiptID > 0)
            {
                ACLoanReceiptItemsController objLoanReceiptItemsController = new ACLoanReceiptItemsController();
                objLoanReceiptItemsController.InsertLoanReceiptItemByTransactionNo(mainObject.ACBankTransactionNo, true);
            }
            CurrentModuleEntity.SetPropertyChangeEventLock(true);
        }

        public void ActionUnPosted()
        {
            if (!CheckLock()) return;
            CurrentModuleEntity.SetPropertyChangeEventLock(false);
            BankTransactionEntities entity = (BankTransactionEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;
            mainObject.ACBankTransactionPostedStatus = PostedTransactionStatus.UnPosted.ToString();
            string tableName = mainObject.ToString().Replace("BOSERP.", string.Empty).Replace("Info", string.Empty);
            GLHelper.UpdatePostedStatus(this.Name, tableName, mainObject.ACBankTransactionID, PostedTransactionStatus.UnPosted.ToString());
            GLHelper.UnPostedTransactions(this.Name, mainObject.ACBankTransactionID, ModulePostingType.Accounting);
            if (mainObject.FK_ACLoanReceiptID > 0)
            {
                ACLoanReceiptItemsController objLoanReceiptItemsController = new ACLoanReceiptItemsController();
                objLoanReceiptItemsController.InsertLoanReceiptItemByTransactionNo(mainObject.ACBankTransactionNo, false);
            }
            InvalidateToolbar();
            CurrentModuleEntity.SetPropertyChangeEventLock(true);
        }
        public override void InvalidateToolbar()
        {
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions, false);
            ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, false);
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, false);
            if (mainObject.ACBankTransactionID > 0)
            {
                if (mainObject.ACBankTransactionStatus == BankTransactionStatus.Completed.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, false);
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.PostedTransactions,
                            mainObject.ACBankTransactionPostedStatus != PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton(ToolbarButtons.UnPostedTransactions,
                            mainObject.ACBankTransactionPostedStatus == PostedTransactionStatus.Posted.ToString());
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonCancelComplete, true);
                }
            }
            if (Toolbar.IsEditAction())
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonDelete, true);
            }
            base.InvalidateToolbar();
        }

        public override void ActionNew()
        {
            base.ActionNew();
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            mainObject.ACBankTransactionCreateFrom = BankTransactionCreateFrom.Normal.ToString();
        }

        public void ActionNewFromAdvanceRefund()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                base.ActionNew();

                BankTransactionEntities entity = (BankTransactionEntities)CurrentModuleEntity;
                ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
                mainObject.ACBankTransactionCreateFrom = BankTransactionCreateFrom.NewFromAdvanceRefund.ToString();
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
                    mainObject.FK_ACObjectID = defaultRefund.FK_HREmployeeID;
                    mainObject.ACObjectType = ObjectType.Employee.ToString();
                    mainObject.FK_GECurrencyID = defaultRefund.FK_GECurrencyID;
                    mainObject.ACObjectAccessKey = mainObject.FK_ACObjectID + ";" + mainObject.ACObjectType;
                    decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateTransferByCurrencyAndDate(mainObject.FK_GECurrencyID, mainObject.ACBankTransactionDate);
                    mainObject.ACBankTransactionExchangeRate = (dCurrencyExchangeRate > 0) ? dCurrencyExchangeRate : defaultRefund.HRAdvanceRefundExchangeRate;
                    mainObject.ACBankTransactionDesc = String.Empty;

                    //Module Object
                    ACDocumentEntrysController entryController = new ACDocumentEntrysController();
                    ACDocumentEntrysInfo docEntry = entryController.GetDefaultDocumentEntryByEntryAndDocumentType(AccDocumentType.NopTienVaoTaiKhoan.ToString()
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
                        List<ACBankTransactionItemsInfo> listBankTransactionItemsInfo = new List<ACBankTransactionItemsInfo>();
                        ACBankTransactionItemsInfo objBankTransactionItemsInfo;
                        foreach (HRAdvanceRefundsInfo advanceRefund in guiFind.SelectedObjects)
                        {
                            objBankTransactionItemsInfo = new ACBankTransactionItemsInfo();
                            objBankTransactionItemsInfo.FK_ACEntryTypeID = docEntry.FK_ACEntryTypeID;
                            objBankTransactionItemsInfo.FK_ACCreditAccountID = docEntry.FK_ACCreditAccountID;
                            if (advanceRefund.FK_ACCreditAccountID > 0)
                                objBankTransactionItemsInfo.FK_ACCreditAccountID = advanceRefund.FK_ACCreditAccountID;
                            objBankTransactionItemsInfo.FK_ACDebitAccountID = docEntry.FK_ACDebitAccountID;
                            objBankTransactionItemsInfo.ACBankTransactionItemDesc = docEntry.ACDocumentEntryDesc + " - " + advanceRefund.HRAdvanceRefundNo;
                            objBankTransactionItemsInfo.FK_HRAdvanceRefundID = advanceRefund.HRAdvanceRefundID;
                            objBankTransactionItemsInfo.ACBankTransactionItemAmount = advanceRefund.HRAdvanceRefundTotalAmount - advanceRefund.HRAdvanceRefundExchangePaymentAmount;
                            objBankTransactionItemsInfo.ACBankTransactionItemExchangeAmount = objBankTransactionItemsInfo.ACBankTransactionItemAmount * mainObject.ACBankTransactionExchangeRate;
                            objBankTransactionItemsInfo.ACBankTransactionItemTaxAmount = objBankTransactionItemsInfo.ACBankTransactionItemAmount * objBankTransactionItemsInfo.ACBankTransactionItemTaxPercent / 100;
                            objBankTransactionItemsInfo.ACBankTransactionItemTotalAmount = objBankTransactionItemsInfo.ACBankTransactionItemAmount + objBankTransactionItemsInfo.ACBankTransactionItemTaxAmount;
                            objBankTransactionItemsInfo.ACBankTransactionItemTotalExchangeAmount = objBankTransactionItemsInfo.ACBankTransactionItemTotalAmount * mainObject.ACBankTransactionExchangeRate;
                            mainObject.ACBankTransactionDesc += advanceRefund.HRAdvanceRefundDesc + "\r\n";
                            objBankTransactionItemsInfo.ACBankTransactionItemReference = advanceRefund.HRAdvanceRefundNo;
                            objBankTransactionItemsInfo.FK_VMVehicleID = advanceRefund.FK_VMVehicleID;
                            listBankTransactionItemsInfo.Add(objBankTransactionItemsInfo);
                        }
                        entity.BankTransactionItemList.Invalidate(listBankTransactionItemsInfo);
                        entity.BankTransactionItemList.GridControl.RefreshDataSource();

                        UpdateTotalAmount();
                        entity.UpdateMainObjectBindingSource();
                    }
                }
                else
                {
                    ActionCancel();
                }
            }
        }
        public void ActionNewSupplierRepaid()
        {
            base.ActionNew();
            BankTransactionEntities entity = (BankTransactionEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            mainObject.ACBankTransactionCreateFrom = BankTransactionCreateFrom.SupplierRepaid.ToString();
            this.GenerateAccountingData();
            APReturnSuppliersController objReturnSuppliersController = new APReturnSuppliersController();
            List<APReturnSuppliersInfo> listReturnSuppliers = objReturnSuppliersController.GetReturnSuppliersForReceiptVoucher(mainObject.FK_BRBranchID);
            ShowSupplierRepaid(listReturnSuppliers);
        }

        private void ShowSupplierRepaid(List<APReturnSuppliersInfo> listReturnSuppliers)
        {
            BankTransactionEntities entity = (BankTransactionEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
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
                ACBankTransactionItemsInfo objBankTransactionItemsInfo;
                mainObject.ACBankTransactionDesc = ReceiptVoucherLocalizedResources.SupplierRepaidItemDesc;

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
                    mainObject.ACBankTransactionDesc += " " + item.ACObjectName + ",";
                    objBankTransactionItemsInfo = new ACBankTransactionItemsInfo();
                    objBankTransactionItemsInfo.ACBankTransactionItemReference = item.APReturnSupplierNo;
                    objBankTransactionItemsInfo.ACBankTransactionItemAmount = item.APReturnSupplierTotalCost;
                    objBankTransactionItemsInfo.ACBankTransactionItemExchangeAmount = item.APReturnSupplierTotalCost * mainObject.ACBankTransactionExchangeRate;
                    objBankTransactionItemsInfo.ACBankTransactionItemDesc = ReceiptVoucherLocalizedResources.SupplierRepaidItemDesc + " " + item.APReturnSupplierNo;
                    objBankTransactionItemsInfo.ACBankTransactionItemTaxAmount = objBankTransactionItemsInfo.ACBankTransactionItemAmount * objBankTransactionItemsInfo.ACBankTransactionItemTaxPercent / 100;
                    objBankTransactionItemsInfo.ACBankTransactionItemTotalAmount = objBankTransactionItemsInfo.ACBankTransactionItemAmount + objBankTransactionItemsInfo.ACBankTransactionItemTaxAmount;
                    objBankTransactionItemsInfo.ACBankTransactionItemTotalExchangeAmount = objBankTransactionItemsInfo.ACBankTransactionItemTotalAmount * mainObject.ACBankTransactionExchangeRate;
                    entity.BankTransactionItemList.Add(objBankTransactionItemsInfo);
                    entity.BankTransactionItemList.GridControl.RefreshDataSource();
                }
                mainObject.FK_GECurrencyID = results[0].FK_GECurrencyID;
                decimal dCurrencyExchangeRate = BOSApp.RealTimeExchageRateTransferByCurrencyAndDate(mainObject.FK_GECurrencyID, mainObject.ACBankTransactionDate);
                mainObject.ACBankTransactionExchangeRate = (dCurrencyExchangeRate > 0) ? dCurrencyExchangeRate : results[0].APReturnSupplierExchangeRate;
                mainObject.FK_ACObjectID = results[0].FK_ACObjectID;
                mainObject.ACObjectType = results[0].APObjectType;
                mainObject.ACObjectAccessKey = mainObject.FK_ACObjectID + ";" + mainObject.ACObjectType;
                mainObject.FK_PMProjectID = results[0].FK_PMProjectID;

                string[] str = mainObject.ACBankTransactionDesc.Split(',');
                mainObject.ACBankTransactionDesc = str[0];
                UpdateTotalAmount();
                entity.UpdateMainObjectBindingSource();
            }
            else
                ActionCancel();
        }
        public void ChangeSegment(int segmentID)
        {
            BankTransactionEntities entity = (BankTransactionEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            mainObject.FK_ACSegmentID = segmentID;

            entity.BankTransactionItemList.ForEach(o =>
            {
                o.FK_ACSegmentID = mainObject.FK_ACSegmentID;
            });
            UpdateDocumentEntries();
            entity.BankTransactionItemList.GridControl.RefreshDataSource();
        }

        public void ChangeExchangeRate()
        {
            BankTransactionEntities entity = (BankTransactionEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            entity.BankTransactionItemList.ForEach(o =>
            {
                o.ACBankTransactionItemExchangeAmount = mainObject.ACBankTransactionExchangeRate * o.ACBankTransactionItemAmount;
                o.ACBankTransactionItemTotalExchangeAmount = mainObject.ACBankTransactionExchangeRate * o.ACBankTransactionItemTotalAmount;
                BOSApp.RoundByCurrency(o, "ACBankTransactionItemAmount", mainObject.FK_GECurrencyID);
                BOSApp.RoundByCurrency(o, "ACBankTransactionItemExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                BOSApp.RoundByCurrency(o, "ACBankTransactionItemTotalAmount", mainObject.FK_GECurrencyID);
                BOSApp.RoundByCurrency(o, "ACBankTransactionItemTotalExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
            });

            UpdateTotalAmount();
            entity.BankTransactionItemList.GridControl.RefreshDataSource();
        }

        public override bool ActionComplete()
        {
            BankTransactionEntities entity = (BankTransactionEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            if(mainObject.FK_ACLoanReceiptID > 0)
            {
                ACLoanReceiptsInfo objLoanReceiptsInfo = (new ACLoanReceiptsController()).GetLoanReceiptByID(mainObject.FK_ACLoanReceiptID);
                if(objLoanReceiptsInfo != null)
                {
                    decimal totalReceiptAmount = entity.BankTransactionItemList.Where(o => o.FK_ACCreditAccountID == objLoanReceiptsInfo.FK_ACAccountID).Sum(o => o.ACBankTransactionItemAmount);
                    if(objLoanReceiptsInfo.ACLoanReceiptAmount < totalReceiptAmount)
                    {
                        MessageBox.Show("Tổng tiền giải ngân không được lớn hơn Số tiền nhận nợ ở khế ước vay"
                                        + Environment.NewLine + "Vui lòng kiểm tra lại!"
                                        , CommonLocalizedResources.MessageBoxDefaultCaption
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            ActionPosted();
            base.ModuleAfterCompleted();
        }

        public override bool ActionCancelComplete()
        {
            if (!CheckLock()) return false;
            if (!CheckRelativeDocument()) return false;
            ActionUnPosted();

            bool isComplete = base.ActionCancelComplete();
            if (isComplete)
            {
                InvalidateToolbar();
            }
            return isComplete;
        }

        private bool CheckRelativeDocument()
        {
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            ACDocumentsController objDocumentsController = new ACDocumentsController();
            List<ACDocumentsInfo> documentsList = objDocumentsController.GetRelativeDocumentListByBankTransactionID(mainObject.ACBankTransactionID);

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

        public void ChangeObject(string objectAccessKey)
        {
            BankTransactionEntities entity = (BankTransactionEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
            mainObject.ACObjectAccessKey = objectAccessKey;
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            objObjectsInfo = objObjectsController.GetObjectByIDAndType(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType);
            if (objObjectsInfo != null)
            {
                mainObject.FK_ACObjectID = objObjectsInfo.ACObjectID;
                mainObject.ACObjectType = objObjectsInfo.ACObjectType;
                mainObject.ACBankTransactionSenderName = objObjectsInfo.ACObjectName;
                mainObject.ACObjectName = objObjectsInfo.ACObjectName;
                mainObject.ACBankTransactionObjectTaxNumber = objObjectsInfo.ACObjectTaxNumber;
                entity.BankTransactionItemList.ForEach(x =>
                {
                    x.ACObjectAccessKey = mainObject.ACObjectAccessKey;
                    x.FK_ACObjectID = objObjectsInfo.ACObjectID;
                    x.ACObjectType = objObjectsInfo.ACObjectType;
                    x.ACObjectName = objObjectsInfo.ACObjectName;
                    x.ACBankTransactionItemTaxNumber = objObjectsInfo.ACObjectTaxNumber;
                    if (x.FK_ACCreditAccountID <= 0 || mainObject.ACBankTransactionCreateFrom == BankTransactionCreateFrom.Normal.ToString())
                    {
                        x.FK_ACCreditAccountID = objObjectsInfo.FK_ACAccountSaleID;
                    }
                });
                entity.UpdateMainObjectBindingSource();
                entity.BankTransactionItemList.GridControl?.RefreshDataSource();
            }
        }
        public override void ActionDuplicate()
        {
            BankTransactionEntities entity = (BankTransactionEntities)CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)CurrentModuleEntity.MainObject;
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

            entity.BankTransactionItemList.Duplicate();
            entity.BankTransactionItemList.GridControl?.RefreshDataSource();
            entity.DocumentEntryList.GridControl?.RefreshDataSource();
        }
    }
}
