using BOSCommon;
using BOSComponent;
using BOSLib;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP091 : ReportForm
    {
        /// <summary>
        /// A variable to store the account list
        /// </summary>
        private List<ACAccountsInfo> AccountList;

        public RP091()
        {
            InitializeComponent();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
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

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            string objectAccessKey = Convert.ToString(fld_lkeACObjectID.EditValue);
            if (string.IsNullOrEmpty(objectAccessKey))
            {
                MessageBox.Show(ReportLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            BOSReport.RP091 report = new BOSReport.RP091();
            //report.LoadLayout(BOSCommon.Constants.Report.DevRP047Path);            
            InitDataSourceReport(report);
            guiReportPreview reviewer = new guiReportPreview(report, false);
            reviewer.Show();
        }


        /// <summary>
        /// Init accounts for the report
        /// </summary>
        public void InitAccounts()
        {
            ACAccountsController objAccountsController = new ACAccountsController();
            AccountList = objAccountsController.GetPayableAccounts();
            fld_dgcACRP047Accounts.DataSource = AccountList;
        }

        /// <summary>
        /// Init data source report for displaying
        /// </summary>
        /// <param name="report">Given report</param>
        public void InitDataSourceReport(XtraReport report)
        {
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;
            XRLabel dateTimeReport = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblFromdateTodate"];
            if (dateTimeReport != null)
                dateTimeReport.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                        ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);

            DateTime? fromDate = fld_dteSearchFromDate.DateTime;
            DateTime? toDate = fld_dteSearchToDate.DateTime;
            int? currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            int? locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
            int? branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            string objectType = fld_lkeObjectType.EditValue.ToString();
            string objectAccessKey = Convert.ToString(fld_lkeACObjectID.EditValue);
            int? objectID = 0;
            if (!string.IsNullOrEmpty(objectAccessKey))
            {
                string[] objects = objectAccessKey.Split(';');
                objectID = Convert.ToInt32(objects[0]);
                objectType = objects[1];
            }
            List<ACAccountsInfo> selectedAccounts = AccountList.Where(acc => acc.Selected == true).ToList();
            List<ACDocumentsInfo> documents = new List<ACDocumentsInfo>();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            List<ACDocumentEntrysInfo> documentEntries = new List<ACDocumentEntrysInfo>();
            foreach (ACAccountsInfo objAccountsInfo in selectedAccounts)
            {
                documentEntries = documentEntries.Concat(objDocumentEntrysController.GetDocumentEntrysForReportRP047(fromDate, toDate, currencyID, objectType, objectID, branchID, objAccountsInfo.ACAccountID)).ToList();
                if (documentEntries.Count > 0)
                {
                    decimal account = documentEntries.First().OpenBalanceDebitAmount - documentEntries.First().OpenBalanceCreditAmount;
                    decimal accountExchange = documentEntries.First().OpenBalanceDebitExchangeAmount - documentEntries.First().OpenBalanceCreditExchangeAmount;
                    documentEntries.ForEach(o =>
                    {
                        account = account + o.ACDocumentEntryDebitAmountUSD - o.ACDocumentEntryCreditAmountUSD;
                        accountExchange = accountExchange + o.ACDocumentEntryDebitAmount - o.ACDocumentEntryCreditAmount;
                        if (account > 0)
                        {
                            o.AccountBalance = account;
                            o.EndDebitAccount = o.AccountBalance;
                        }
                        else
                        {
                            o.AccountBalance = account;
                            o.EndCreditAccount = o.AccountBalance;
                        }
                        if (accountExchange > 0)
                        {
                            o.AccountExchangeBalance = accountExchange;
                            o.EndDebitExchangeAccount = o.AccountExchangeBalance;
                        }
                        else
                        {
                            o.AccountExchangeBalance = accountExchange;
                            o.EndCreditExchangeAccount = o.AccountExchangeBalance;
                        }
                    });
                }
            }
            report.DataSource = documentEntries;
        }

        #region delete by HoanVo
        /*public void InitDataSourceReport(XtraReport report)
        {
            ADReportsController objReportsController = new ADReportsController();
            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;
            BRBranchsController objBranchsController = new BRBranchsController();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;
            XRLabel dateTimeReport = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblFromdateTodate"];
            if (dateTimeReport != null)
                dateTimeReport.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                        ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);

            ACDocumentsController objDocumentsController = new ACDocumentsController();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            List<ACDocumentEntrysInfo> result = new List<ACDocumentEntrysInfo>();
            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            string currencyName = objCurrenciesController.GetObjectNameByID(currencyID);
            int locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByLocationIDAndBranchID(locationID, branchID);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            ACObjectsController objObjectsController = new ACObjectsController();
            string objectAccessKey = Convert.ToString(fld_lkeACObjectID.EditValue);
            ACObjectsInfo selectedObject = objObjectsController.GetObjectByAccessKey(objectAccessKey);
            selectedObject = objObjectsController.GetObjectByIDAndType(selectedObject.ACObjectID, selectedObject.ACObjectType);
            if (selectedObject != null)
            {
                ACAccountsController objAccountsController = new ACAccountsController();
                List<ACAccountsInfo> selectedAccounts = AccountList.Where(a => a.Selected == true).ToList();
                //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                List<ACDocumentEntrysInfo> entries;
                foreach (ACAccountsInfo objAccountsInfo in selectedAccounts)
                {                    
                    if (objAccountsInfo.Selected)
                    {
                        decimal startBalance = 0;
                        decimal startExchangeBalance = 0;
                        entries = new List<ACDocumentEntrysInfo>();

                        foreach (BRBranchsInfo branch in selectedBranches)
                        {
                             List<ACDocumentEntrysInfo> list = objDocumentEntrysController.GetEntriesByAccountID(
                                                                                                        objAccountsInfo.ACAccountID,
                                                                                                        selectedObject.ACObjectID,
                                                                                                        selectedObject.ACObjectType,
                                                                                                        currencyID,
                                                                                                        null,
                                                                                                        null,
                                                                                                        branch.BRBranchID,
                                                                                                        fromDate,
                                                                                                        toDate);
                             entries.AddRange(list);
                            
                            if (currencyID > 0)
                            {
                                startBalance += objDocumentEntrysController.GetAccountBalanceByCurrency(
                                                                                            objAccountsInfo.ACAccountNo,
                                                                                            fromDate.AddDays(-1),
                                                                                            selectedObject.ACObjectID,
                                                                                            selectedObject.ACObjectType,
                                                                                            currencyID,
                                                                                            null,
                                                                                            null,
                                                                                            branch.BRBranchID);
                                startExchangeBalance += objDocumentEntrysController.GetAccountExchangeBalanceByCurrency(
                                                                                            objAccountsInfo.ACAccountNo,
                                                                                            fromDate.AddDays(-1),
                                                                                            selectedObject.ACObjectID,
                                                                                            selectedObject.ACObjectType,
                                                                                            currencyID,
                                                                                            null,
                                                                                            null,
                                                                                            branch.BRBranchID);
                            }
                            else
                            {
                                startBalance += objDocumentEntrysController.GetAccountBalance(
                                                                                            objAccountsInfo.ACAccountNo,
                                                                                            fromDate.AddDays(-1),
                                                                                            selectedObject.ACObjectID,
                                                                                            selectedObject.ACObjectType,
                                                                                            currencyID,
                                                                                            null,
                                                                                            null,
                                                                                            branch.BRBranchID);

                                startExchangeBalance = startBalance;
                            }
                        }

                        entries = entries.OrderBy(item => item.ACDocumentDate).ToList();
                        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
                        decimal endBalance = startBalance;
                        decimal endExchangeBalance = startExchangeBalance;

                        foreach (ACDocumentEntrysInfo entry in entries)
                        {
                            entry.ACObjectNo = selectedObject.ACObjectNo;
                            entry.ACObjectName = selectedObject.ACObjectName;
                            entry.ACDocumentEntryAccountNoDisplayText = string.Format("{0} - {1}", objAccountsInfo.ACAccountNo, objAccountsInfo.ACAccountName);
                            entry.GECurrencyName = currencyName;
                            entry.GroupValue = string.Format("{0}{1}", selectedObject.ACObjectNo, objAccountsInfo.ACAccountNo);
                            if (entry.ACDocumentDebitAccount.StartsWith(objAccountsInfo.ACAccountNo))
                            {
                                if (entry.FK_ACAssObjectID == 0 || entry.FK_ACObjectID == selectedObject.ACObjectID)
                                {
                                    entry.ACDocumentEntryAccountNo = entry.ACDocumentDebitAccount;
                                    entry.ACDocumentEntryContraAccountNo = entry.ACDocumentCreditAccount;
                                    if (currencyID > 0)
                                    {
                                        //entry.ACDocumentEntryDebitAmount = entry.ACDocumentEntryAmount;
                                        entry.TransactionDebitAccount = entry.ACDocumentEntryAmount;
                                    }
                                    else
                                    {
                                        //entry.ACDocumentEntryDebitAmount = entry.ACDocumentEntryExchangeAmount;
                                        entry.TransactionDebitAccount = entry.ACDocumentEntryExchangeAmount;
                                        
                                    }
                                    entry.TransactionDebitExchangeAccount = entry.ACDocumentEntryExchangeAmount;
                                }
                            }
                            if (entry.ACDocumentCreditAccount.StartsWith(objAccountsInfo.ACAccountNo))
                            {
                                if (entry.FK_ACAssObjectID == 0 || entry.FK_ACAssObjectID == selectedObject.ACObjectID)
                                {
                                    entry.ACDocumentEntryAccountNo = entry.ACDocumentCreditAccount;
                                    entry.ACDocumentEntryContraAccountNo = entry.ACDocumentDebitAccount;
                                    if (currencyID > 0)
                                    {
                                        //entry.ACDocumentEntryCreditAmount = entry.ACDocumentEntryAmount;
                                        entry.TransactionCreditAccount = entry.ACDocumentEntryAmount;
                                    }
                                    else
                                    {
                                        //entry.ACDocumentEntryCreditAmount = entry.ACDocumentEntryExchangeAmount;
                                        entry.TransactionCreditAccount = entry.ACDocumentEntryExchangeAmount;
                                    }
                                    entry.TransactionCreditExchangeAccount = entry.ACDocumentEntryExchangeAmount;
                                }
                            }
                            //endBalance = endBalance + entry.ACDocumentEntryCreditAmount - entry.ACDocumentEntryDebitAmount;
                            endBalance = endBalance + entry.TransactionCreditAccount - entry.TransactionDebitAccount;
                            endExchangeBalance = endExchangeBalance + entry.TransactionCreditExchangeAccount - entry.TransactionDebitExchangeAccount;
                            if (endBalance > 0)
                            {                             
                                entry.EndCreditAccount = Math.Abs(endBalance);                                
                            }
                            else
                            {                             
                                entry.EndDebitAccount = Math.Abs(endBalance);
                            }

                            if (endExchangeBalance > 0)
                            {                                                            
                                entry.EndCreditExchangeAccount = Math.Abs(endExchangeBalance);
                            }
                            else
                            {
                                entry.EndDebitExchangeAccount = Math.Abs(endExchangeBalance);
                            }
                        }

                        if (entries.Count == 0 && (startBalance != 0 || startExchangeBalance != 0))
                        {
                            ACDocumentEntrysInfo entry = new ACDocumentEntrysInfo();
                            entry.ACObjectNo = selectedObject.ACObjectNo;
                            entry.ACObjectName = selectedObject.ACObjectName;
                            entry.ACDocumentEntryAccountNoDisplayText = string.Format("{0} - {1}", objAccountsInfo.ACAccountNo, objAccountsInfo.ACAccountName);
                            entry.GECurrencyName = currencyName;
                            entry.GroupValue = string.Format("{0}{1}", selectedObject.ACObjectNo, objAccountsInfo.ACAccountNo);
                            entries.Add(entry);
                        }

                        if (entries.Count > 0)
                        {
                            ACDocumentEntrysInfo startEntry = entries[0];
                            ACDocumentEntrysInfo endEntry = entries[entries.Count - 1];
                            if (startBalance > 0)
                            {
                                startEntry.OpenBalanceCreditAmount = Math.Abs(startBalance);                                
                            }
                            else
                            {
                                startEntry.OpenBalanceDebitAmount = Math.Abs(startBalance);
                            }

                            if (startExchangeBalance > 0)
                            {
                                startEntry.OpenBalanceCreditExchangeAmount = Math.Abs(startExchangeBalance);
                            }
                            else
                            {
                                startEntry.OpenBalanceDebitExchangeAmount = Math.Abs(startExchangeBalance);
                            }
                            if (endBalance > 0)
                            {
                                endEntry.EndCreditAccount = Math.Abs(endBalance);
                            }
                            else
                            {
                                endEntry.EndDebitAccount = Math.Abs(endBalance);
                            }

                            if (endExchangeBalance > 0)
                            {
                                endEntry.EndCreditExchangeAccount = Math.Abs(endExchangeBalance);
                            }
                            else
                            {
                                endEntry.EndDebitExchangeAccount = Math.Abs(endExchangeBalance);
                            }        
                        }
                        result = result.Concat(entries).ToList();
                    }
                }
            }
            report.DataSource = result;
        }
        */
        #endregion

        private void RP047_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();
            fld_lkeObjectType.EditValue = ObjectType.Supplier.ToString();

            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo branch = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (branch != null)
            {
                fld_lkeGELocationID.EditValue = branch.FK_GELocationID;
            }

            InitAccounts();
        }

        private void fld_chkSellectAllAccount_CheckedChanged(object sender, EventArgs e)
        {
            BOSCheckEdit selectAllCheckEdit = (BOSCheckEdit)sender;
            foreach (ACAccountsInfo objAccountsInfo in AccountList)
            {
                objAccountsInfo.Selected = selectAllCheckEdit.Checked;
            }
            fld_dgcACRP047Accounts.RefreshDataSource();
        }
    }
}
