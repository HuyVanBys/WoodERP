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
    public partial class RP046I : ReportForm
    {
        /// <summary>
        /// A variable to store the account list
        /// </summary>
        private List<ACAccountsInfo> AccountList;

        public RP046I()
        {
            InitializeComponent();
        }

        private void RP046I_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();
            fld_lkeObjectType.EditValue = ObjectType.Supplier.ToString();
            fld_cmbViewType.SelectedIndex = 1;

            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo branch = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (branch != null)
            {
                fld_lkeGELocationID.EditValue = branch.FK_GELocationID;
            }

            InitAccounts();
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
            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            XtraReport report = null;
            if (currencyID > 0)
            {
                //BOSReport.RP046I report = new BOSReport.RP046I();
                report = new BOSReport.RP046();
                InitDataSourceReport(report);
            }
            else
            {
                report = new BOSReport.RP046Currencys();
                InitDataSourceForReportAllCurrency(report);
            }
            //InitDataSourceReport(report);
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
            fld_dgcACRP046IAccounts.DataSource = AccountList;
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


            report.DataSource = GetDataSourceForReportAllCurrency();
        }

        #region Luu.Nguyen delete
        //public decimal GetStartBalance(ACAccountsInfo objAccountsInfo
        //                            , ACObjectsInfo obj
        //                            , GECurrenciesInfo objGECurrenciesInfo
        //                            , BRBranchsInfo branch
        //                            , DateTime dateFrom
        //                            , List<ACAccountDetailsInfo> accountDetailListByBranch
        //                            , List<ACAccountDetailsInfo> accountDetailList
        //                            , List<ACDocumentEntrysInfo> accountEntries
        //                            , List<ACDocumentEntrysInfo> accountEntriesByBranch)
        //{

        //    decimal result = 0;
        //    decimal initBalance = 0;
        //    decimal debitAmount = 0;
        //    decimal creditAmount = 0;

        //    //init
        //    accountDetailListByBranch = accountDetailList.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                               && t.ACObjectType == obj.ACObjectType
        //                                               && t.FK_GECurrencyID == objGECurrenciesInfo.GECurrencyID).ToList();

        //    if (accountDetailListByBranch != null &&
        //        accountDetailListByBranch.Count > 0)
        //    {
        //        initBalance = accountDetailListByBranch.Sum(t => t.ACAccountDetailInitialBalanceByCurrency);
        //    }
        //    //debit init
        //    accountEntriesByBranch = accountEntries.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                               && t.ACObjectType == obj.ACObjectType
        //                                               && t.FK_BRBranchID == branch.BRBranchID
        //                                               && t.FK_GECurrencyID == objGECurrenciesInfo.GECurrencyID
        //                                               && t.ACDocumentEntryType == "Debit"
        //                                               && t.ACDocumentDate.Date < dateFrom.Date).ToList();
        //    if (accountEntriesByBranch != null && accountEntriesByBranch.Count > 0)
        //    {
        //        debitAmount = accountEntriesByBranch.Sum(t => t.ACDocumentEntryAmount);
        //    }

        //    // credit init
        //    accountEntriesByBranch = accountEntries.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                               && t.ACObjectType == obj.ACObjectType
        //                                               && t.FK_BRBranchID == branch.BRBranchID
        //                                               && t.FK_GECurrencyID == objGECurrenciesInfo.GECurrencyID
        //                                               && t.ACDocumentEntryType == "Credit"
        //                                               && t.ACDocumentDate.Date < dateFrom.Date).ToList();
        //    if (accountEntriesByBranch != null && accountEntriesByBranch.Count > 0)
        //    {
        //        creditAmount = accountEntriesByBranch.Sum(t => t.ACDocumentEntryAmount);
        //    }

        //    if (objAccountsInfo.ACAccountPostingRule == AccountPostingRule.IncreasingByDebit.ToString())
        //    {
        //        result = (initBalance + debitAmount - creditAmount);
        //    }
        //    else if (objAccountsInfo.ACAccountPostingRule == AccountPostingRule.IncreasingByCredit.ToString())
        //    {
        //        result = (initBalance + creditAmount - debitAmount);
        //    }

        //    return result;
        //}

        //public decimal GetStartBalance(ACAccountsInfo objAccountsInfo
        //                           , ACObjectsInfo obj
        //                           , GECurrenciesInfo objGECurrenciesInfo
        //                           , BRBranchsInfo branch
        //                           , DateTime dateFrom
        //                           , List<ACAccountDetailsInfo> accountDetailListByBranch
        //                           , List<ACAccountDetailsInfo> accountDetailList
        //                           , List<ACDocumentEntrysInfo> accountEntries
        //                           , List<ACDocumentEntrysInfo> accountEntriesByBranch
        //                           , ref decimal baseBalance)
        //{

        //    decimal result = 0;
        //    decimal initBalance = 0;
        //    decimal debitAmount = 0;
        //    decimal creditAmount = 0;

        //    decimal baseinitBalance = 0;
        //    decimal basedebitAmount = 0;
        //    decimal basecreditAmount = 0;

        //    //init
        //    accountDetailListByBranch = accountDetailList.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                               && t.ACObjectType == obj.ACObjectType
        //                                               && t.FK_GECurrencyID == objGECurrenciesInfo.GECurrencyID).ToList();

        //    if (accountDetailListByBranch != null &&
        //        accountDetailListByBranch.Count > 0)
        //    {
        //        initBalance = accountDetailListByBranch.Sum(t => t.ACAccountDetailInitialBalanceByCurrency);
        //        baseinitBalance = accountDetailListByBranch.Sum(t => t.ACAccountDetailInitialBalance);
        //    }
        //    //debit init
        //    accountEntriesByBranch = accountEntries.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                               && t.ACObjectType == obj.ACObjectType
        //                                               && t.FK_BRBranchID == branch.BRBranchID
        //                                               && t.FK_GECurrencyID == objGECurrenciesInfo.GECurrencyID
        //                                               && t.ACDocumentEntryType == "Debit"
        //                                               && t.ACDocumentDate.Date < dateFrom.Date).ToList();
        //    if (accountEntriesByBranch != null && accountEntriesByBranch.Count > 0)
        //    {
        //        debitAmount = accountEntriesByBranch.Sum(t => t.ACDocumentEntryAmount);
        //        basedebitAmount = accountEntriesByBranch.Sum(t => t.ACDocumentEntryExchangeAmount);
        //    }



        //    // credit init
        //    accountEntriesByBranch = accountEntries.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                               && t.ACObjectType == obj.ACObjectType
        //                                               && t.FK_BRBranchID == branch.BRBranchID
        //                                               && t.FK_GECurrencyID == objGECurrenciesInfo.GECurrencyID
        //                                               && t.ACDocumentEntryType == "Credit"
        //                                               && t.ACDocumentDate.Date < dateFrom.Date).ToList();
        //    if (accountEntriesByBranch != null && accountEntriesByBranch.Count > 0)
        //    {
        //        creditAmount = accountEntriesByBranch.Sum(t => t.ACDocumentEntryAmount);
        //        basecreditAmount = accountEntriesByBranch.Sum(t => t.ACDocumentEntryExchangeAmount);
        //    }

        //    if (objAccountsInfo.ACAccountPostingRule == AccountPostingRule.IncreasingByDebit.ToString())
        //    {
        //        result = (initBalance + debitAmount - creditAmount);
        //        baseBalance += (baseinitBalance + basedebitAmount - basecreditAmount);
        //    }
        //    else if (objAccountsInfo.ACAccountPostingRule == AccountPostingRule.IncreasingByCredit.ToString())
        //    {
        //        result = (initBalance + creditAmount - debitAmount);
        //        baseBalance += (baseinitBalance + basecreditAmount - basedebitAmount);
        //    }

        //    return result;
        //}

        #endregion

        /// <summary>
        /// Init data source report for displaying
        /// </summary>
        /// <param name="report">Given report</param>
        public void InitDataSourceForReportAllCurrency(XtraReport report)
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

            report.DataSource = GetDataSourceForReportAllCurrency();
        }

        private void fld_chkSellectAllAccount_CheckedChanged(object sender, EventArgs e)
        {
            BOSCheckEdit selectAllCheckEdit = (BOSCheckEdit)sender;
            foreach (ACAccountsInfo objAccountsInfo in AccountList)
            {
                objAccountsInfo.Selected = selectAllCheckEdit.Checked;
            }
            fld_dgcACRP046IAccounts.RefreshDataSource();
        }

        /// <summary>
        /// Get object list for the report
        /// </summary>
        private List<ACObjectsInfo> GetObjectList()
        {
            ACObjectsController objObjectsController = new ACObjectsController();
            List<ACObjectsInfo> objects = new List<ACObjectsInfo>();
            string objectAccessKey = Convert.ToString(fld_lkeACObjectID.EditValue);
            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;
            if (!string.IsNullOrEmpty(objectAccessKey))
            {
                ACObjectsInfo obj = (ACObjectsInfo)objObjectsController.GetObjectByAccessKey(objectAccessKey);
                obj = objObjectsController.GetObjectByIDAndType(obj.ACObjectID, obj.ACObjectType);
                objects.Add(obj);
            }
            else
            {
                ACAccountsController objAccountsController = new ACAccountsController();
                List<ACAccountsInfo> selectedAccounts = AccountList.Where(a => a.Selected == true).ToList();
                for (int i = 0; i < selectedAccounts.Count; i++)
                {
                    ACAccountsInfo account = selectedAccounts[i];
                    List<ACAccountsInfo> subAccounts = objAccountsController.GetSubAccountsByAccountNo(account.ACAccountNo);
                    foreach (ACAccountsInfo subAccount in subAccounts)
                    {
                        if (!selectedAccounts.Exists(a => a.ACAccountID == subAccount.ACAccountID))
                        {
                            selectedAccounts.Add(subAccount);
                        }
                    }
                }

                string objectType = Convert.ToString(fld_lkeObjectType.EditValue);
                int locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
                int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
                bool hasOwing = true;
                if (fld_cmbViewType.SelectedIndex == 0)
                {
                    hasOwing = false;
                }

                ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                SortedList<string, List<ACDocumentEntrysInfo>> owingEntries = new SortedList<string, List<ACDocumentEntrysInfo>>();
                foreach (ACAccountsInfo account in selectedAccounts)
                {
                    List<ACObjectsInfo> owingObjects = objObjectsController.GetOwingObjects(account.ACAccountNo, fromDate, toDate, objectType, locationID, branchID, hasOwing);
                    List<ACDocumentEntrysInfo> result = objDocumentEntrysController.GetEntriesByAccountID(
                                                                                   account.ACAccountID,
                                                                                   null,
                                                                                   objectType,
                                                                                   null,
                                                                                   null,
                                                                                   locationID,
                                                                                   branchID,
                                                                                   null,
                                                                                   toDate);
                    foreach (ACDocumentEntrysInfo entry in result)
                    {
                        if (entry.FK_ACObjectID > 0)
                        {
                            List<ACDocumentEntrysInfo> objectEntries = null;
                            string key = string.Format("{0}{1}", entry.FK_ACObjectID, entry.ACObjectType);
                            if (owingEntries.ContainsKey(key))
                            {
                                objectEntries = owingEntries[key];
                            }
                            else
                            {
                                objectEntries = new List<ACDocumentEntrysInfo>();
                                owingEntries.Add(key, objectEntries);
                            }
                            if (objectEntries != null)
                            {
                                objectEntries.Add(entry);
                            }
                        }
                        if (entry.FK_ACAssObjectID > 0)
                        {
                            List<ACDocumentEntrysInfo> objectEntries = null;
                            string key = string.Format("{0}{1}", entry.FK_ACAssObjectID, entry.ACAssObjectType);
                            if (owingEntries.ContainsKey(key))
                            {
                                objectEntries = owingEntries[key];
                            }
                            else
                            {
                                objectEntries = new List<ACDocumentEntrysInfo>();
                                owingEntries.Add(key, objectEntries);
                            }
                            if (objectEntries != null)
                            {
                                objectEntries.Add(entry);
                            }
                        }
                    }

                    foreach (ACObjectsInfo obj in owingObjects)
                    {
                        string key = string.Format("{0}{1}", obj.ACObjectID, obj.ACObjectType);
                        if (owingEntries.ContainsKey(key))
                        {
                            List<ACDocumentEntrysInfo> objectEntries = owingEntries[key];
                            obj.AccountDebitAmount = objectEntries.Where(e => e.ACDocumentDebitAccount != null && e.ACDocumentDebitAccount.StartsWith(account.ACAccountNo) &&
                                                                    e.FK_ACObjectID == obj.ACObjectID &&
                                                                    e.ACObjectType == obj.ACObjectType).Sum(e => e.ACDocumentEntryExchangeAmount);
                            obj.AccountCreditAmount = objectEntries.Where(e => e.ACDocumentCreditAccount != null && e.ACDocumentCreditAccount.StartsWith(account.ACAccountNo) &&
                                                                    (e.FK_ACObjectID == obj.ACObjectID &&
                                                                    e.FK_ACAssObjectID == 0 &&
                                                                    e.ACObjectType == obj.ACObjectType) ||
                                                                    (e.FK_ACAssObjectID == obj.ACObjectID &&
                                                                    e.FK_ACAssObjectID > 0 &&
                                                                    e.ACAssObjectType == obj.ACObjectType)).Sum(e => e.ACDocumentEntryExchangeAmount);
                        }
                    }

                    for (int i = 0; i < owingObjects.Count; i++)
                    {
                        ACObjectsInfo obj = owingObjects[i];
                        decimal endBalance = 0;
                        if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByDebit.ToString())
                        {
                            endBalance = obj.InitBalance + obj.AccountDebitAmount - obj.AccountCreditAmount;
                        }
                        else if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByCredit.ToString())
                        {
                            endBalance = obj.InitBalance + obj.AccountCreditAmount - obj.AccountDebitAmount;
                        }

                        bool isOwingObject = false;
                        if (endBalance != 0 && ((obj.AccountDebitAmount != obj.AccountCreditAmount) ||
                                                        (obj.AccountDebitAmount == obj.AccountCreditAmount &&
                                                         (branchID == 0 || obj.BRBranchID == branchID) &&
                                                         (locationID == 0 || obj.GELocationID == locationID || obj.GELocationParentID == locationID)
                                                        )))
                        {
                            isOwingObject = true;
                        }

                        if (!isOwingObject && !hasOwing)
                        {
                            string key = string.Format("{0}{1}", obj.ACObjectID, obj.ACObjectType);
                            if (owingEntries.ContainsKey(key))
                            {
                                if (owingEntries[key].Exists(e => ((e.FK_ACObjectID == obj.ACObjectID && e.ACObjectType == obj.ACObjectType) ||
                                                            (e.FK_ACAssObjectID == obj.ACObjectID && e.ACAssObjectType == obj.ACObjectType)) &&
                                                            e.ACDocumentDate.Date >= fromDate.Date &&
                                                            e.ACDocumentDate.Date <= toDate.Date))
                                {
                                    isOwingObject = true;
                                }
                            }
                        }

                        if (!isOwingObject)
                        {
                            owingObjects.RemoveAt(i);
                            i--;
                        }
                    }
                    objects = objects.Concat(owingObjects).ToList();
                }

                //Make the object list unique
                for (int i = 0; i < objects.Count; i++)
                {
                    for (int j = i + 1; j < objects.Count; j++)
                    {
                        if (objects[i].ACObjectID == objects[j].ACObjectID && objects[i].ACObjectType == objects[j].ACObjectType)
                        {
                            objects.RemoveAt(j);
                            j--;
                        }
                    }
                }
            }
            return objects;
        }

        private void fld_btnShowDetail_Click(object sender, EventArgs e)
        {
            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            if (currencyID > 0)
            {
                guiRP046ShowDetail guiRP046ShowDetail = new guiRP046ShowDetail(GetDataSourceForReportAllCurrency());
                guiRP046ShowDetail.Module = Module;
                guiRP046ShowDetail.ShowDialog();
            }
            else
            {
                guiRP046CurrencyShowDetail guiRP046CurrencyShowDetail = new guiRP046CurrencyShowDetail(GetDataSourceForReportAllCurrency());
                guiRP046CurrencyShowDetail.Module = Module;
                guiRP046CurrencyShowDetail.ShowDialog();
            }

        }

        #region Luu.Nguyen delete
        //public List<ACDocumentEntrysInfo> GetDataSourceReport()
        //{
        //    DateTime dateFrom = fld_dteSearchFromDate.DateTime;
        //    DateTime dateTo = fld_dteSearchToDate.DateTime;
        //    GECurrenciesController objCurrenciesController = new GECurrenciesController();

        //    int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
        //    if (currencyID == 0)
        //    {
        //        currencyID = 100000;
        //    }
        //    string currencyName = objCurrenciesController.GetObjectNameByID(currencyID);
        //    int locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
        //    int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
        //    List<ACAccountsInfo> selectedAccounts = AccountList.Where(acc => acc.Selected == true).ToList();
        //    string objectType = Convert.ToString(fld_lkeObjectType.EditValue);
        //    string objectAccessKey = Convert.ToString(fld_lkeACObjectID.EditValue);
        //    ACObjectsController objObjectsController = new ACObjectsController();
        //    List<ACObjectsInfo> objects = new List<ACObjectsInfo>();
        //    List<ACObjectsInfo> objectAll = new List<ACObjectsInfo>();
        //    objectAll = objObjectsController.GetObjectByIDAndTypeGeneral(0, objectType);
        //    if (!string.IsNullOrEmpty(objectAccessKey))
        //    {
        //        ACObjectsInfo obj = (ACObjectsInfo)objObjectsController.GetObjectByAccessKey(objectAccessKey, objectAll);
        //        if (obj != null)
        //            objects.Add(obj);
        //    }
        //    else
        //    {
        //        objects = objectAll;
        //    }
        //    //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
        //    List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByLocationIDAndBranchID(locationID, branchID);
        //    //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
        //    ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
        //    List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> accountEntries = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> accountEntriesByBranch = new List<ACDocumentEntrysInfo>();
        //    ACAccountDetailsController accountDetailController = new ACAccountDetailsController();
        //    List<ACAccountDetailsInfo> accountDetailList = new List<ACAccountDetailsInfo>();
        //    List<ACAccountDetailsInfo> accountDetailListByBranch = new List<ACAccountDetailsInfo>();
        //    List<ACDocumentEntrysInfo> financelIncomeList = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> financelIncomeListByBranch = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> financelCostList = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> financelCostListByBranch = new List<ACDocumentEntrysInfo>();

        //    foreach (ACAccountsInfo objAccountsInfo in selectedAccounts)
        //    {
        //        if ((objects.Count > 1))
        //        {
        //            accountEntries = objDocumentEntrysController.GetAllDocumentForReport(objAccountsInfo.ACAccountNo
        //                                                                                , objectType
        //                                                                                , 0
        //                                                                                , string.Empty
        //                                                                                , currencyID
        //                                                                                , locationID
        //                                                                                , branchID
        //                                                                                , dateTo);
        //            accountDetailList = accountDetailController.GetAccountDetailListByAccountNo(objAccountsInfo.ACAccountNo, 0, string.Empty, 0);
        //            financelIncomeList = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(objAccountsInfo.ACAccountNo
        //                                                                            , AccAccount.Acc515
        //                                                                            , 0
        //                                                                            , objectType
        //                                                                            , currencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                            , dateTo);
        //            financelCostList = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(AccAccount.Acc635
        //                                                                            , objAccountsInfo.ACAccountNo
        //                                                                            , 0
        //                                                                            , objectType
        //                                                                            , currencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                            , dateTo);
        //        }
        //        else
        //        {
        //            accountEntries = objDocumentEntrysController.GetAllDocumentForReport(objAccountsInfo.ACAccountNo
        //                                                                                , string.Empty
        //                                                                                , objects[0].ACObjectID
        //                                                                                , objects[0].ACObjectType
        //                                                                                , currencyID
        //                                                                                , locationID
        //                                                                                , branchID
        //                                                                                , dateTo);
        //            accountDetailList = accountDetailController.GetAccountDetailListByAccountNo(objAccountsInfo.ACAccountNo
        //                                                                            , objects[0].ACObjectID
        //                                                                            , objects[0].ACObjectType
        //                                                                            , currencyID);
        //            financelIncomeList = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(objAccountsInfo.ACAccountNo
        //                                                                            , AccAccount.Acc515
        //                                                                           , objects[0].ACObjectID
        //                                                                            , objects[0].ACObjectType
        //                                                                            , currencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                            , dateTo);
        //            financelCostList = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(AccAccount.Acc635
        //                                                                            , objAccountsInfo.ACAccountNo
        //                                                                             , objects[0].ACObjectID
        //                                                                            , objects[0].ACObjectType
        //                                                                            , currencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                              , dateTo);
        //        }

        //        foreach (ACObjectsInfo obj in objects)
        //        {
        //            string accountNoAndName = string.Format("{0} - {1}", objAccountsInfo.ACAccountNo, objAccountsInfo.ACAccountName);
        //            ACDocumentEntrysInfo entry = new ACDocumentEntrysInfo();
        //            entry.ACObjectNo = obj.ACObjectNo;
        //            entry.ACObjectName = obj.ACObjectName;
        //            entry.ACDocumentEntryAccountNo = objAccountsInfo.ACAccountNo;
        //            entry.ACDocumentEntryAccountNoDisplayText = accountNoAndName;
        //            entry.GECurrencyName = currencyName;

        //            decimal startBalance = 0;



        //            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
        //            foreach (BRBranchsInfo branch in selectedBranches)
        //            {
        //                decimal initBalance = 0;
        //                decimal debitAmount = 0;
        //                decimal creditAmount = 0;
        //                decimal financialIncome = 0;
        //                decimal financialCost = 0;
        //                //init
        //                accountDetailListByBranch = accountDetailList.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                           && t.ACObjectType == obj.ACObjectType
        //                    //&& t.FK_BRBranchID == branch.BRBranchID
        //                                                           && t.FK_GECurrencyID == currencyID).ToList();

        //                if (accountDetailListByBranch != null &&
        //                    accountDetailListByBranch.Count > 0)
        //                {
        //                    initBalance = accountDetailListByBranch.Sum(t => t.ACAccountDetailInitialBalanceByCurrency);
        //                }
        //                //debit init
        //                accountEntriesByBranch = accountEntries.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                           && t.ACObjectType == obj.ACObjectType
        //                                                           && t.FK_BRBranchID == branch.BRBranchID
        //                                                           && t.FK_GECurrencyID == currencyID
        //                                                           && t.ACDocumentEntryType == "Debit"
        //                                                           && t.ACDocumentDate.Date < dateFrom.Date).ToList();
        //                if (accountEntriesByBranch != null && accountEntriesByBranch.Count > 0)
        //                {
        //                    debitAmount = accountEntriesByBranch.Sum(t => t.ACDocumentEntryAmount);
        //                }



        //                // credit init
        //                accountEntriesByBranch = accountEntries.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                           && t.ACObjectType == obj.ACObjectType
        //                                                           && t.FK_BRBranchID == branch.BRBranchID
        //                                                           && t.FK_GECurrencyID == currencyID
        //                                                           && t.ACDocumentEntryType == "Credit"
        //                                                           && t.ACDocumentDate.Date < dateFrom.Date).ToList();
        //                if (accountEntriesByBranch != null && accountEntriesByBranch.Count > 0)
        //                {
        //                    creditAmount = accountEntriesByBranch.Sum(t => t.ACDocumentEntryAmount);
        //                }

        //                if (objAccountsInfo.ACAccountPostingRule == AccountPostingRule.IncreasingByDebit.ToString())
        //                {
        //                    startBalance += (initBalance + debitAmount - creditAmount);
        //                }
        //                else if (objAccountsInfo.ACAccountPostingRule == AccountPostingRule.IncreasingByCredit.ToString())
        //                {
        //                    startBalance += (initBalance + creditAmount - debitAmount);
        //                }

        //                //debit period
        //                accountEntriesByBranch = accountEntries.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                           && t.ACObjectType == obj.ACObjectType
        //                                                           && t.FK_BRBranchID == branch.BRBranchID
        //                                                           && t.FK_GECurrencyID == currencyID
        //                                                           && t.ACDocumentEntryType == "Debit"
        //                                                           && t.ACDocumentDate.Date <= dateTo.Date
        //                                                           && t.ACDocumentDate.Date >= dateFrom.Date).ToList();
        //                if (accountEntriesByBranch != null && accountEntriesByBranch.Count > 0)
        //                {
        //                    entry.ACDocumentEntryDebitAmount += accountEntriesByBranch.Sum(t => t.ACDocumentEntryAmount);
        //                }
        //                financelIncomeListByBranch = financelIncomeList.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                                     && t.ACObjectType == obj.ACObjectType
        //                                                                     && t.FK_BRBranchID == branch.BRBranchID).ToList();
        //                if (financelIncomeListByBranch != null && financelIncomeListByBranch.Count > 0)
        //                {
        //                    financialIncome = financelIncomeListByBranch.Sum(t => t.ACDocumentEntryAmount);
        //                    entry.ACDocumentEntryDebitAmount -= financialIncome;
        //                }
        //                //credit period
        //                accountEntriesByBranch = accountEntries.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                           && t.ACObjectType == obj.ACObjectType
        //                                                           && t.FK_BRBranchID == branch.BRBranchID
        //                                                           && t.FK_GECurrencyID == currencyID
        //                                                           && t.ACDocumentEntryType == "Credit"
        //                                                           && t.ACDocumentDate.Date <= dateTo.Date
        //                                                           && t.ACDocumentDate.Date >= dateFrom.Date).ToList();
        //                if (accountEntriesByBranch != null && accountEntriesByBranch.Count > 0)
        //                {
        //                    entry.ACDocumentEntryCreditAmount += accountEntriesByBranch.Sum(t => t.ACDocumentEntryAmount);
        //                }

        //                financelCostListByBranch = financelCostList.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                                     && t.ACObjectType == obj.ACObjectType
        //                                                                     && t.FK_BRBranchID == branch.BRBranchID).ToList();
        //                if (financelCostListByBranch != null && financelCostListByBranch.Count > 0)
        //                {
        //                    financialCost = financelCostListByBranch.Sum(t => t.ACDocumentEntryAmount);
        //                    entry.ACDocumentEntryCreditAmount -= financialCost;
        //                }


        //            }

        //            if (startBalance > 0)
        //            {
        //                entry.StartPeriodCreditBalance = Math.Abs(startBalance);
        //            }
        //            else if (startBalance < 0)
        //            {
        //                entry.StartPeriodDebitBalance = Math.Abs(startBalance);
        //            }

        //            decimal endBalance = Math.Round(startBalance + entry.ACDocumentEntryCreditAmount - entry.ACDocumentEntryDebitAmount, 3);
        //            if (endBalance > 0)
        //            {
        //                entry.EndPeriodCreditBalance = Math.Abs(endBalance);
        //            }
        //            else
        //            {
        //                entry.EndPeriodDebitBalance = Math.Abs(endBalance);
        //            }

        //            if (fld_cmbViewType.SelectedIndex == 0)
        //            {
        //                if (entry.ACDocumentEntryDebitAmount > 0 || entry.ACDocumentEntryCreditAmount > 0 || endBalance != 0)
        //                {
        //                    entries.Add(entry);
        //                }
        //            }
        //            else if (fld_cmbViewType.SelectedIndex == 1)
        //            {
        //                if (endBalance != 0)
        //                {
        //                    entries.Add(entry);
        //                }
        //            }
        //        }
        //    }
        //    return entries;
        //}
        #endregion

        private List<ACDocumentEntrysInfo> GetDataSourceForReportAllCurrency()
        {
            DateTime? fromDate = fld_dteSearchFromDate.DateTime;
            DateTime? toDate = fld_dteSearchToDate.DateTime;
            int? currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            int? locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
            int? branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            string objectType = fld_lkeObjectType.EditValue.ToString();
            string objectAccessKey = Convert.ToString(fld_lkeACObjectID.EditValue);
            string reportType = Convert.ToString(fld_cmbViewType.EditValue);
            int? objectID = 0;
            if (!string.IsNullOrEmpty(objectAccessKey))
            {
                string[] objects = objectAccessKey.Split(';');
                objectID = Convert.ToInt32(objects[0]);
                objectType = objects[1];
            }
            List<ACAccountsInfo> selectedAccounts = AccountList.Where(acc => acc.Selected == true).ToList();

            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            List<ACDocumentEntrysInfo> documentEntrys = new List<ACDocumentEntrysInfo>();
            foreach (ACAccountsInfo objAccountsInfo in selectedAccounts)
            {
                documentEntrys = documentEntrys.Concat(objDocumentEntrysController.GetDocumentEntrysForReportRP046I(fromDate, toDate, currencyID, objectType, objectID, reportType, branchID, objAccountsInfo.ACAccountID)).ToList();
            }
            return documentEntrys;
        }

        #region LuuNguyen delete
        //public List<ACDocumentEntrysInfo> GetDataSourceForReportAllCurrency()
        //{
        //    DateTime dateFrom = fld_dteSearchFromDate.DateTime;
        //    DateTime dateTo = fld_dteSearchToDate.DateTime;
        //    GECurrenciesController objCurrenciesController = new GECurrenciesController();

        //    int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
        //    string currencyName = objCurrenciesController.GetObjectNameByID(currencyID);
        //    int locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
        //    int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
        //    //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
        //    List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByLocationIDAndBranchID(locationID, branchID);
        //    //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
        //    List<ACAccountsInfo> selectedAccounts = AccountList.Where(acc => acc.Selected == true).ToList();
        //    //List<ACObjectsInfo> objects = GetObjectList();
        //    string objectType = Convert.ToString(fld_lkeObjectType.EditValue);
        //    string objectAccessKey = Convert.ToString(fld_lkeACObjectID.EditValue);
        //    ACObjectsController objObjectsController = new ACObjectsController();
        //    List<ACObjectsInfo> objects = new List<ACObjectsInfo>();
        //    List<ACObjectsInfo> objectAll = new List<ACObjectsInfo>();
        //    objectAll = objObjectsController.GetObjectByIDAndTypeGeneral(0, objectType);
        //    if (!string.IsNullOrEmpty(objectAccessKey))
        //    {
        //        ACObjectsInfo obj = (ACObjectsInfo)objObjectsController.GetObjectByAccessKey(objectAccessKey, objectAll);
        //        if (obj != null)
        //        {
        //            objects.Add(obj);
        //        }
        //    }
        //    else
        //    {
        //        objects = objectAll;
        //    }


        //    ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
        //    ACAccountDetailsController accountDetailController = new ACAccountDetailsController();
        //    List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
        //    #region VND

        //    List<ACDocumentEntrysInfo> accountEntries_VND = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> accountEntriesByBranch_VND = new List<ACDocumentEntrysInfo>();

        //    List<ACAccountDetailsInfo> accountDetailList_VND = new List<ACAccountDetailsInfo>();
        //    List<ACAccountDetailsInfo> accountDetailListByBranch_VND = new List<ACAccountDetailsInfo>();
        //    List<ACDocumentEntrysInfo> financelIncomeList_VND = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> financelIncomeListByBranch_VND = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> financelCostList_VND = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> financelCostListByBranch_VND = new List<ACDocumentEntrysInfo>();
        //    #endregion
        //    #region USD

        //    List<ACDocumentEntrysInfo> accountEntries_USD = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> accountEntriesByBranch_USD = new List<ACDocumentEntrysInfo>();
        //    List<ACAccountDetailsInfo> accountDetailList_USD = new List<ACAccountDetailsInfo>();
        //    List<ACAccountDetailsInfo> accountDetailListByBranch_USD = new List<ACAccountDetailsInfo>();
        //    List<ACDocumentEntrysInfo> financelIncomeList_USD = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> financelIncomeListByBranch_USD = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> financelCostList_USD = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> financelCostListByBranch_USD = new List<ACDocumentEntrysInfo>();
        //    #endregion
        //    #region EURO

        //    List<ACDocumentEntrysInfo> accountEntries_EURO = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> accountEntriesByBranch_EURO = new List<ACDocumentEntrysInfo>();
        //    List<ACAccountDetailsInfo> accountDetailList_EURO = new List<ACAccountDetailsInfo>();
        //    List<ACAccountDetailsInfo> accountDetailListByBranch_EURO = new List<ACAccountDetailsInfo>();
        //    List<ACDocumentEntrysInfo> financelIncomeList_EURO = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> financelIncomeListByBranch_EURO = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> financelCostList_EURO = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> financelCostListByBranch_EURO = new List<ACDocumentEntrysInfo>();
        //    #endregion
        //    #region RMB

        //    List<ACDocumentEntrysInfo> accountEntries_RMB = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> accountEntriesByBranch_RMB = new List<ACDocumentEntrysInfo>();
        //    List<ACAccountDetailsInfo> accountDetailList_RMB = new List<ACAccountDetailsInfo>();
        //    List<ACAccountDetailsInfo> accountDetailListByBranch_RMB = new List<ACAccountDetailsInfo>();
        //    List<ACDocumentEntrysInfo> financelIncomeList_RMB = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> financelIncomeListByBranch_RMB = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> financelCostList_RMB = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> financelCostListByBranch_RMB = new List<ACDocumentEntrysInfo>();
        //    #endregion

        //    #region SGD

        //    List<ACDocumentEntrysInfo> accountEntries_SGD = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> accountEntriesByBranch_SGD = new List<ACDocumentEntrysInfo>();
        //    List<ACAccountDetailsInfo> accountDetailList_SGD = new List<ACAccountDetailsInfo>();
        //    List<ACAccountDetailsInfo> accountDetailListByBranch_SGD = new List<ACAccountDetailsInfo>();
        //    List<ACDocumentEntrysInfo> financelIncomeList_SGD = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> financelIncomeListByBranch_SGD = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> financelCostList_SGD = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> financelCostListByBranch_SGD = new List<ACDocumentEntrysInfo>();
        //    #endregion

        //    #region GBP

        //    List<ACDocumentEntrysInfo> accountEntries_GBP = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> accountEntriesByBranch_GBP = new List<ACDocumentEntrysInfo>();
        //    List<ACAccountDetailsInfo> accountDetailList_GBP = new List<ACAccountDetailsInfo>();
        //    List<ACAccountDetailsInfo> accountDetailListByBranch_GBP = new List<ACAccountDetailsInfo>();
        //    List<ACDocumentEntrysInfo> financelIncomeList_GBP = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> financelIncomeListByBranch_GBP = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> financelCostList_GBP = new List<ACDocumentEntrysInfo>();
        //    List<ACDocumentEntrysInfo> financelCostListByBranch_GBP = new List<ACDocumentEntrysInfo>();
        //    #endregion

        //    GECurrenciesInfo objVNDGECurrenciesInfo = (GECurrenciesInfo)objCurrenciesController.GetObjectByNo("VND");
        //    GECurrenciesInfo objUSDGECurrenciesInfo = (GECurrenciesInfo)objCurrenciesController.GetObjectByNo("USD");
        //    GECurrenciesInfo objEUROGECurrenciesInfo = (GECurrenciesInfo)objCurrenciesController.GetObjectByNo("EURO");
        //    GECurrenciesInfo objRMBGECurrenciesInfo = (GECurrenciesInfo)objCurrenciesController.GetObjectByNo("RMB");
        //    GECurrenciesInfo objSGDGECurrenciesInfo = (GECurrenciesInfo)objCurrenciesController.GetObjectByNo("SGD");
        //    GECurrenciesInfo objGBPGECurrenciesInfo = (GECurrenciesInfo)objCurrenciesController.GetObjectByNo("GBP");

        //    //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
        //    bool showAllCurrency = false;
        //    foreach (ACAccountsInfo objAccountsInfo in selectedAccounts)
        //    {

        //        if ((objects.Count > 1))
        //        {
        //            #region VND
        //            accountEntries_VND = objDocumentEntrysController.GetAllDocumentForReport(objAccountsInfo.ACAccountNo
        //                                                                                    , objectType
        //                                                                                    , 0
        //                                                                                    , string.Empty
        //                                                                                    , objVNDGECurrenciesInfo.GECurrencyID
        //                                                                                    , locationID
        //                                                                                    , branchID
        //                                                                                    , dateTo);
        //            accountDetailList_VND = accountDetailController.GetAccountDetailListByAccountNo(objAccountsInfo.ACAccountNo, 0, string.Empty, objVNDGECurrenciesInfo.GECurrencyID);
        //            financelIncomeList_VND = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(objAccountsInfo.ACAccountNo
        //                                                                            , AccAccount.Acc515
        //                                                                            , 0
        //                                                                            , objectType
        //                                                                            , objVNDGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                            , dateTo);
        //            financelCostList_VND = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(AccAccount.Acc635
        //                                                                            , objAccountsInfo.ACAccountNo
        //                                                                            , 0
        //                                                                            , objectType
        //                                                                            , objVNDGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                            , dateTo);
        //            #endregion

        //            #region USD
        //            accountEntries_USD = objDocumentEntrysController.GetAllDocumentForReport(objAccountsInfo.ACAccountNo
        //                                                                                    , objectType
        //                                                                                    , 0
        //                                                                                    , string.Empty
        //                                                                                    , objUSDGECurrenciesInfo.GECurrencyID
        //                                                                                    , locationID
        //                                                                                    , branchID
        //                                                                                    , dateTo);
        //            accountDetailList_USD = accountDetailController.GetAccountDetailListByAccountNo(objAccountsInfo.ACAccountNo, 0, string.Empty, objUSDGECurrenciesInfo.GECurrencyID);
        //            financelIncomeList_USD = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(objAccountsInfo.ACAccountNo
        //                                                                            , AccAccount.Acc515
        //                                                                            , 0
        //                                                                            , objectType
        //                                                                            , objUSDGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                            , dateTo);
        //            financelCostList_USD = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(AccAccount.Acc635
        //                                                                            , objAccountsInfo.ACAccountNo
        //                                                                            , 0
        //                                                                            , objectType
        //                                                                            , objUSDGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                            , dateTo);
        //            #endregion

        //            #region EURO
        //            accountEntries_EURO = objDocumentEntrysController.GetAllDocumentForReport(objAccountsInfo.ACAccountNo
        //                                                                                    , objectType
        //                                                                                    , 0
        //                                                                                    , string.Empty
        //                                                                                    , objEUROGECurrenciesInfo.GECurrencyID
        //                                                                                    , locationID
        //                                                                                    , branchID
        //                                                                                    , dateTo);
        //            accountDetailList_EURO = accountDetailController.GetAccountDetailListByAccountNo(objAccountsInfo.ACAccountNo, 0, string.Empty, objEUROGECurrenciesInfo.GECurrencyID);
        //            financelIncomeList_EURO = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(objAccountsInfo.ACAccountNo
        //                                                                            , AccAccount.Acc515
        //                                                                            , 0
        //                                                                            , objectType
        //                                                                            , objEUROGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                            , dateTo);
        //            financelCostList_EURO = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(AccAccount.Acc635
        //                                                                            , objAccountsInfo.ACAccountNo
        //                                                                            , 0
        //                                                                            , objectType
        //                                                                            , objEUROGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                            , dateTo);
        //            #endregion

        //            #region RMB
        //            accountEntries_RMB = objDocumentEntrysController.GetAllDocumentForReport(objAccountsInfo.ACAccountNo
        //                                                                                    , objectType
        //                                                                                    , 0
        //                                                                                    , string.Empty
        //                                                                                    , objRMBGECurrenciesInfo.GECurrencyID
        //                                                                                    , locationID
        //                                                                                    , branchID
        //                                                                                    , dateTo);
        //            accountDetailList_RMB = accountDetailController.GetAccountDetailListByAccountNo(objAccountsInfo.ACAccountNo, 0, string.Empty, objRMBGECurrenciesInfo.GECurrencyID);
        //            financelIncomeList_RMB = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(objAccountsInfo.ACAccountNo
        //                                                                            , AccAccount.Acc515
        //                                                                            , 0
        //                                                                            , objectType
        //                                                                            , objRMBGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                            , dateTo);
        //            financelCostList_RMB = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(AccAccount.Acc635
        //                                                                            , objAccountsInfo.ACAccountNo
        //                                                                            , 0
        //                                                                            , objectType
        //                                                                            , objRMBGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                            , dateTo);
        //            #endregion

        //            #region SGD
        //            accountEntries_SGD = objDocumentEntrysController.GetAllDocumentForReport(objAccountsInfo.ACAccountNo
        //                                                                                    , objectType
        //                                                                                    , 0
        //                                                                                    , string.Empty
        //                                                                                    , objSGDGECurrenciesInfo.GECurrencyID
        //                                                                                    , locationID
        //                                                                                    , branchID
        //                                                                                    , dateTo);
        //            accountDetailList_SGD = accountDetailController.GetAccountDetailListByAccountNo(objAccountsInfo.ACAccountNo, 0, string.Empty, objSGDGECurrenciesInfo.GECurrencyID);
        //            financelIncomeList_SGD = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(objAccountsInfo.ACAccountNo
        //                                                                            , AccAccount.Acc515
        //                                                                            , 0
        //                                                                            , objectType
        //                                                                            , objSGDGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                            , dateTo);
        //            financelCostList_SGD = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(AccAccount.Acc635
        //                                                                            , objAccountsInfo.ACAccountNo
        //                                                                            , 0
        //                                                                            , objectType
        //                                                                            , objSGDGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                            , dateTo);
        //            #endregion

        //            #region GBP
        //            accountEntries_GBP = objDocumentEntrysController.GetAllDocumentForReport(objAccountsInfo.ACAccountNo
        //                                                                                    , objectType
        //                                                                                    , 0
        //                                                                                    , string.Empty
        //                                                                                    , objGBPGECurrenciesInfo.GECurrencyID
        //                                                                                    , locationID
        //                                                                                    , branchID
        //                                                                                    , dateTo);
        //            accountDetailList_GBP = accountDetailController.GetAccountDetailListByAccountNo(objAccountsInfo.ACAccountNo, 0, string.Empty, objGBPGECurrenciesInfo.GECurrencyID);
        //            financelIncomeList_GBP = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(objAccountsInfo.ACAccountNo
        //                                                                            , AccAccount.Acc515
        //                                                                            , 0
        //                                                                            , objectType
        //                                                                            , objGBPGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                            , dateTo);
        //            financelCostList_GBP = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(AccAccount.Acc635
        //                                                                            , objAccountsInfo.ACAccountNo
        //                                                                            , 0
        //                                                                            , objectType
        //                                                                            , objGBPGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                            , dateTo);
        //            #endregion
        //        }
        //        else
        //        {
        //            #region VND
        //            accountEntries_VND = objDocumentEntrysController.GetAllDocumentForReport(objAccountsInfo.ACAccountNo
        //                                                                                , string.Empty
        //                                                                                , objects[0].ACObjectID
        //                                                                                , objects[0].ACObjectType
        //                                                                                , objVNDGECurrenciesInfo.GECurrencyID
        //                                                                                , locationID
        //                                                                                , branchID
        //                                                                                , dateTo);
        //            accountDetailList_VND = accountDetailController.GetAccountDetailListByAccountNo(objAccountsInfo.ACAccountNo
        //                                                                            , objects[0].ACObjectID
        //                                                                            , objects[0].ACObjectType
        //                                                                            , objVNDGECurrenciesInfo.GECurrencyID);
        //            financelIncomeList_VND = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(objAccountsInfo.ACAccountNo
        //                                                                            , AccAccount.Acc515
        //                                                                           , objects[0].ACObjectID
        //                                                                            , objects[0].ACObjectType
        //                                                                            , objVNDGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                            , dateTo);
        //            financelCostList_VND = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(AccAccount.Acc635
        //                                                                            , objAccountsInfo.ACAccountNo
        //                                                                             , objects[0].ACObjectID
        //                                                                            , objects[0].ACObjectType
        //                                                                            , objVNDGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                              , dateTo);
        //            #endregion

        //            #region USD
        //            accountEntries_USD = objDocumentEntrysController.GetAllDocumentForReport(objAccountsInfo.ACAccountNo
        //                                                                                , string.Empty
        //                                                                                , objects[0].ACObjectID
        //                                                                                , objects[0].ACObjectType
        //                                                                                , objUSDGECurrenciesInfo.GECurrencyID
        //                                                                                , locationID
        //                                                                                , branchID
        //                                                                                , dateTo);
        //            accountDetailList_USD = accountDetailController.GetAccountDetailListByAccountNo(objAccountsInfo.ACAccountNo
        //                                                                            , objects[0].ACObjectID
        //                                                                            , objects[0].ACObjectType
        //                                                                            , objUSDGECurrenciesInfo.GECurrencyID);
        //            financelIncomeList_USD = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(objAccountsInfo.ACAccountNo
        //                                                                            , AccAccount.Acc515
        //                                                                           , objects[0].ACObjectID
        //                                                                            , objects[0].ACObjectType
        //                                                                            , objUSDGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                            , dateTo);
        //            financelCostList_USD = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(AccAccount.Acc635
        //                                                                            , objAccountsInfo.ACAccountNo
        //                                                                             , objects[0].ACObjectID
        //                                                                            , objects[0].ACObjectType
        //                                                                            , objUSDGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                              , dateTo);
        //            #endregion

        //            #region EURO
        //            accountEntries_EURO = objDocumentEntrysController.GetAllDocumentForReport(objAccountsInfo.ACAccountNo
        //                                                                                , string.Empty
        //                                                                                , objects[0].ACObjectID
        //                                                                                , objects[0].ACObjectType
        //                                                                                , objEUROGECurrenciesInfo.GECurrencyID
        //                                                                                , locationID
        //                                                                                , branchID
        //                                                                                , dateTo);
        //            accountDetailList_EURO = accountDetailController.GetAccountDetailListByAccountNo(objAccountsInfo.ACAccountNo
        //                                                                            , objects[0].ACObjectID
        //                                                                            , objects[0].ACObjectType
        //                                                                            , objEUROGECurrenciesInfo.GECurrencyID);
        //            financelIncomeList_EURO = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(objAccountsInfo.ACAccountNo
        //                                                                            , AccAccount.Acc515
        //                                                                           , objects[0].ACObjectID
        //                                                                            , objects[0].ACObjectType
        //                                                                            , objEUROGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                            , dateTo);
        //            financelCostList_EURO = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(AccAccount.Acc635
        //                                                                            , objAccountsInfo.ACAccountNo
        //                                                                             , objects[0].ACObjectID
        //                                                                            , objects[0].ACObjectType
        //                                                                            , objEUROGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                              , dateTo);
        //            #endregion

        //            #region RMB
        //            accountEntries_RMB = objDocumentEntrysController.GetAllDocumentForReport(objAccountsInfo.ACAccountNo
        //                                                                                , string.Empty
        //                                                                                , objects[0].ACObjectID
        //                                                                                , objects[0].ACObjectType
        //                                                                                , objRMBGECurrenciesInfo.GECurrencyID
        //                                                                                , locationID
        //                                                                                , branchID
        //                                                                                , dateTo);
        //            accountDetailList_RMB = accountDetailController.GetAccountDetailListByAccountNo(objAccountsInfo.ACAccountNo
        //                                                                            , objects[0].ACObjectID
        //                                                                            , objects[0].ACObjectType
        //                                                                            , objRMBGECurrenciesInfo.GECurrencyID);
        //            financelIncomeList_RMB = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(objAccountsInfo.ACAccountNo
        //                                                                            , AccAccount.Acc515
        //                                                                           , objects[0].ACObjectID
        //                                                                            , objects[0].ACObjectType
        //                                                                            , objRMBGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                            , dateTo);
        //            financelCostList_RMB = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(AccAccount.Acc635
        //                                                                            , objAccountsInfo.ACAccountNo
        //                                                                             , objects[0].ACObjectID
        //                                                                            , objects[0].ACObjectType
        //                                                                            , objRMBGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                              , dateTo);
        //            #endregion

        //            #region SGD
        //            accountEntries_SGD = objDocumentEntrysController.GetAllDocumentForReport(objAccountsInfo.ACAccountNo
        //                                                                                , string.Empty
        //                                                                                , objects[0].ACObjectID
        //                                                                                , objects[0].ACObjectType
        //                                                                                , objSGDGECurrenciesInfo.GECurrencyID
        //                                                                                , locationID
        //                                                                                , branchID
        //                                                                                , dateTo);
        //            accountDetailList_SGD = accountDetailController.GetAccountDetailListByAccountNo(objAccountsInfo.ACAccountNo
        //                                                                            , objects[0].ACObjectID
        //                                                                            , objects[0].ACObjectType
        //                                                                            , objSGDGECurrenciesInfo.GECurrencyID);
        //            financelIncomeList_SGD = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(objAccountsInfo.ACAccountNo
        //                                                                            , AccAccount.Acc515
        //                                                                           , objects[0].ACObjectID
        //                                                                            , objects[0].ACObjectType
        //                                                                            , objSGDGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                            , dateTo);
        //            financelCostList_SGD = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(AccAccount.Acc635
        //                                                                            , objAccountsInfo.ACAccountNo
        //                                                                             , objects[0].ACObjectID
        //                                                                            , objects[0].ACObjectType
        //                                                                            , objSGDGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                              , dateTo);
        //            #endregion

        //            #region GBP
        //            accountEntries_GBP = objDocumentEntrysController.GetAllDocumentForReport(objAccountsInfo.ACAccountNo
        //                                                                                , string.Empty
        //                                                                                , objects[0].ACObjectID
        //                                                                                , objects[0].ACObjectType
        //                                                                                , objGBPGECurrenciesInfo.GECurrencyID
        //                                                                                , locationID
        //                                                                                , branchID
        //                                                                                , dateTo);
        //            accountDetailList_GBP = accountDetailController.GetAccountDetailListByAccountNo(objAccountsInfo.ACAccountNo
        //                                                                            , objects[0].ACObjectID
        //                                                                            , objects[0].ACObjectType
        //                                                                            , objGBPGECurrenciesInfo.GECurrencyID);
        //            financelIncomeList_GBP = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(objAccountsInfo.ACAccountNo
        //                                                                            , AccAccount.Acc515
        //                                                                           , objects[0].ACObjectID
        //                                                                            , objects[0].ACObjectType
        //                                                                            , objGBPGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                            , dateTo);
        //            financelCostList_GBP = objDocumentEntrysController
        //                    .GetAccountAmountByCreditAndDebitAccountsAndCurrencyAll(AccAccount.Acc635
        //                                                                            , objAccountsInfo.ACAccountNo
        //                                                                             , objects[0].ACObjectID
        //                                                                            , objects[0].ACObjectType
        //                                                                            , objGBPGECurrenciesInfo.GECurrencyID
        //                                                                            , 0
        //                                                                            , dateFrom
        //                                                                              , dateTo);
        //            #endregion
        //        }

        //        foreach (ACObjectsInfo obj in objects)
        //        {
        //            decimal startBalanceVND = 0;
        //            decimal startBalanceUSD = 0;
        //            decimal startBalanceEURO = 0;
        //            decimal startBalanceRMB = 0;
        //            decimal startBalanceSGD = 0;
        //            decimal startBalanceGBP = 0;

        //            decimal baseOpenBalancetUSD = 0;
        //            decimal baseTransactionDebitUSD = 0;
        //            decimal baseTransactionCreditUSD = 0;
        //            //decimal baseEndDebitUSD = 0;
        //            //decimal baseEndCreditUSD = 0;

        //            decimal baseOpenBalanceEURO = 0;
        //            decimal baseTransactionDebitEURO = 0;
        //            decimal baseTransactionCreditEURO = 0;
        //            //decimal baseEndDebitEURO = 0;
        //            //decimal baseEndCreditEURO = 0;

        //            decimal baseOpenBalanceRMB = 0;
        //            decimal baseTransactionDebitRMB = 0;
        //            decimal baseTransactionCreditRMB = 0;
        //            //decimal baseEndDebitRMB = 0;
        //            //decimal baseEndCreditRMB = 0;

        //            decimal baseOpenBalanceSGD = 0;
        //            decimal baseTransactionDebitSGD = 0;
        //            decimal baseTransactionCreditSGD = 0;
        //            //decimal baseEndDebitSGD = 0;
        //            //decimal baseEndCreditSGD = 0;

        //            decimal baseOpenBalanceGBP = 0;
        //            decimal baseTransactionDebitGBP = 0;
        //            decimal baseTransactionCreditGBP = 0;
        //            //decimal baseEndDebitGBP = 0;
        //            //decimal baseEndCreditGBP = 0;

        //            //ACDocumentEntrysInfo entry = new ACDocumentEntrysInfo();
        //            decimal financialIncomeAmount = 0;
        //            decimal financialCostAmount = 0;

        //            string accountNoAndName = string.Format("{0} - {1}", objAccountsInfo.ACAccountNo, objAccountsInfo.ACAccountName);
        //            ACDocumentEntrysInfo entry = new ACDocumentEntrysInfo();
        //            entry.ACObjectNo = obj.ACObjectNo;
        //            entry.ACObjectName = obj.ACObjectName;
        //            entry.ACDocumentEntryAccountNo = objAccountsInfo.ACAccountNo;
        //            entry.ACDocumentEntryAccountNoDisplayText = accountNoAndName;
        //            entry.GECurrencyName = currencyName;

        //            foreach (BRBranchsInfo branch in selectedBranches)
        //            {

        //                // Init
        //                startBalanceVND += GetStartBalance(objAccountsInfo
        //                                                    , obj
        //                                                    , objVNDGECurrenciesInfo
        //                                                    , branch
        //                                                    , dateFrom
        //                                                    , accountDetailListByBranch_VND
        //                                                    , accountDetailList_VND
        //                                                    , accountEntries_VND
        //                                                    , accountEntriesByBranch_VND);
        //                startBalanceUSD += GetStartBalance(objAccountsInfo
        //                                                    , obj
        //                                                    , objUSDGECurrenciesInfo
        //                                                    , branch
        //                                                    , dateFrom
        //                                                    , accountDetailListByBranch_USD
        //                                                    , accountDetailList_USD
        //                                                    , accountEntries_USD
        //                                                    , accountEntriesByBranch_USD, ref baseOpenBalancetUSD);

        //                startBalanceEURO += GetStartBalance(objAccountsInfo
        //                                                    , obj
        //                                                    , objEUROGECurrenciesInfo
        //                                                    , branch
        //                                                    , dateFrom
        //                                                    , accountDetailListByBranch_EURO
        //                                                    , accountDetailList_EURO
        //                                                    , accountEntries_EURO
        //                                                    , accountEntriesByBranch_EURO, ref baseOpenBalanceEURO);
        //                startBalanceRMB += GetStartBalance(objAccountsInfo
        //                                                    , obj
        //                                                    , objRMBGECurrenciesInfo
        //                                                    , branch
        //                                                    , dateFrom
        //                                                    , accountDetailListByBranch_RMB
        //                                                    , accountDetailList_RMB
        //                                                    , accountEntries_RMB
        //                                                    , accountEntriesByBranch_RMB, ref baseOpenBalanceRMB);
        //                startBalanceSGD += GetStartBalance(objAccountsInfo
        //                                                    , obj
        //                                                    , objSGDGECurrenciesInfo
        //                                                    , branch
        //                                                    , dateFrom
        //                                                    , accountDetailListByBranch_SGD
        //                                                    , accountDetailList_SGD
        //                                                    , accountEntries_SGD
        //                                                    , accountEntriesByBranch_SGD, ref baseOpenBalanceSGD);
        //                startBalanceGBP += GetStartBalance(objAccountsInfo
        //                                                    , obj
        //                                                    , objGBPGECurrenciesInfo
        //                                                    , branch
        //                                                    , dateFrom
        //                                                    , accountDetailListByBranch_GBP
        //                                                    , accountDetailList_GBP
        //                                                    , accountEntries_GBP
        //                                                    , accountEntriesByBranch_GBP, ref baseOpenBalanceGBP);

        //                //Period

        //                //VND period debit
        //                accountEntriesByBranch_VND = accountEntries_VND.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                           && t.ACObjectType == obj.ACObjectType
        //                                                           && t.FK_BRBranchID == branch.BRBranchID
        //                                                           && t.FK_GECurrencyID == objVNDGECurrenciesInfo.GECurrencyID
        //                                                           && t.ACDocumentEntryType == "Debit"
        //                                                           && t.ACDocumentDate.Date <= dateTo.Date
        //                                                           && t.ACDocumentDate.Date >= dateFrom.Date).ToList();
        //                if (accountEntriesByBranch_VND != null && accountEntriesByBranch_VND.Count > 0)
        //                {
        //                    entry.TransactionDebitAccountVND += accountEntriesByBranch_VND.Sum(t => t.ACDocumentEntryAmount);
        //                }
        //                //VND period credit
        //                accountEntriesByBranch_VND = accountEntries_VND.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                           && t.ACObjectType == obj.ACObjectType
        //                                                           && t.FK_BRBranchID == branch.BRBranchID
        //                                                           && t.FK_GECurrencyID == objVNDGECurrenciesInfo.GECurrencyID
        //                                                           && t.ACDocumentEntryType == "Credit"
        //                                                           && t.ACDocumentDate.Date <= dateTo.Date
        //                                                           && t.ACDocumentDate.Date >= dateFrom.Date).ToList();
        //                if (accountEntriesByBranch_VND != null && accountEntriesByBranch_VND.Count > 0)
        //                {
        //                    entry.TransactionCreditAccountVND += accountEntriesByBranch_VND.Sum(t => t.ACDocumentEntryAmount);
        //                }
        //                // USD period debit
        //                accountEntriesByBranch_USD = accountEntries_USD.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                           && t.ACObjectType == obj.ACObjectType
        //                                                           && t.FK_BRBranchID == branch.BRBranchID
        //                                                           && t.FK_GECurrencyID == objUSDGECurrenciesInfo.GECurrencyID
        //                                                           && t.ACDocumentEntryType == "Debit"
        //                                                           && t.ACDocumentDate.Date <= dateTo.Date
        //                                                           && t.ACDocumentDate.Date >= dateFrom.Date).ToList();
        //                if (accountEntriesByBranch_USD != null && accountEntriesByBranch_USD.Count > 0)
        //                {
        //                    entry.TransactionDebitAccountUSD += accountEntriesByBranch_USD.Sum(t => t.ACDocumentEntryAmount);
        //                    baseTransactionDebitUSD = accountEntriesByBranch_USD.Sum(t => t.ACDocumentEntryExchangeAmount);
        //                    entry.TransactionDebitAccountVND4USD += baseTransactionDebitUSD;
        //                }

        //                //USD period credit  
        //                accountEntriesByBranch_USD = accountEntries_USD.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                          && t.ACObjectType == obj.ACObjectType
        //                                                          && t.FK_BRBranchID == branch.BRBranchID
        //                                                          && t.FK_GECurrencyID == objUSDGECurrenciesInfo.GECurrencyID
        //                                                          && t.ACDocumentEntryType == "Credit"
        //                                                          && t.ACDocumentDate.Date <= dateTo.Date
        //                                                          && t.ACDocumentDate.Date >= dateFrom.Date).ToList();
        //                if (accountEntriesByBranch_USD != null && accountEntriesByBranch_USD.Count > 0)
        //                {
        //                    entry.TransactionCreditAccountUSD += accountEntriesByBranch_USD.Sum(t => t.ACDocumentEntryAmount);
        //                    baseTransactionCreditUSD = accountEntriesByBranch_USD.Sum(t => t.ACDocumentEntryExchangeAmount);
        //                    entry.TransactionCreditAccountVND4USD += baseTransactionCreditUSD;
        //                }

        //                // EURO period debit
        //                accountEntriesByBranch_EURO = accountEntries_EURO.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                           && t.ACObjectType == obj.ACObjectType
        //                                                           && t.FK_BRBranchID == branch.BRBranchID
        //                                                           && t.FK_GECurrencyID == objEUROGECurrenciesInfo.GECurrencyID
        //                                                           && t.ACDocumentEntryType == "Debit"
        //                                                           && t.ACDocumentDate.Date <= dateTo.Date
        //                                                           && t.ACDocumentDate.Date >= dateFrom.Date).ToList();
        //                if (accountEntriesByBranch_EURO != null && accountEntriesByBranch_EURO.Count > 0)
        //                {
        //                    entry.TransactionDebitAccountEURO += accountEntriesByBranch_EURO.Sum(t => t.ACDocumentEntryAmount);
        //                    baseTransactionDebitEURO = accountEntriesByBranch_EURO.Sum(t => t.ACDocumentEntryExchangeAmount);
        //                    entry.TransactionDebitAccountVND4EURO += baseTransactionDebitEURO;
        //                }

        //                //EURO period credit  
        //                accountEntriesByBranch_EURO = accountEntries_EURO.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                          && t.ACObjectType == obj.ACObjectType
        //                                                          && t.FK_BRBranchID == branch.BRBranchID
        //                                                          && t.FK_GECurrencyID == objEUROGECurrenciesInfo.GECurrencyID
        //                                                          && t.ACDocumentEntryType == "Credit"
        //                                                          && t.ACDocumentDate.Date <= dateTo.Date
        //                                                          && t.ACDocumentDate.Date >= dateFrom.Date).ToList();
        //                if (accountEntriesByBranch_EURO != null && accountEntriesByBranch_EURO.Count > 0)
        //                {
        //                    entry.TransactionCreditAccountEURO += accountEntriesByBranch_EURO.Sum(t => t.ACDocumentEntryAmount);
        //                    baseTransactionCreditEURO = accountEntriesByBranch_EURO.Sum(t => t.ACDocumentEntryExchangeAmount);
        //                    entry.TransactionCreditAccountVND4EURO += baseTransactionCreditEURO;
        //                }

        //                // RMB period debit
        //                accountEntriesByBranch_RMB = accountEntries_RMB.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                           && t.ACObjectType == obj.ACObjectType
        //                                                           && t.FK_BRBranchID == branch.BRBranchID
        //                                                           && t.FK_GECurrencyID == objRMBGECurrenciesInfo.GECurrencyID
        //                                                           && t.ACDocumentEntryType == "Debit"
        //                                                           && t.ACDocumentDate.Date <= dateTo.Date
        //                                                           && t.ACDocumentDate.Date >= dateFrom.Date).ToList();
        //                if (accountEntriesByBranch_RMB != null && accountEntriesByBranch_RMB.Count > 0)
        //                {
        //                    entry.TransactionDebitAccountRMB += accountEntriesByBranch_RMB.Sum(t => t.ACDocumentEntryAmount);
        //                    baseTransactionDebitRMB = accountEntriesByBranch_RMB.Sum(t => t.ACDocumentEntryExchangeAmount);
        //                    entry.TransactionDebitAccountVND4RMB += baseTransactionDebitRMB;
        //                }

        //                //RMB period credit  
        //                accountEntriesByBranch_RMB = accountEntries_RMB.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                          && t.ACObjectType == obj.ACObjectType
        //                                                          && t.FK_BRBranchID == branch.BRBranchID
        //                                                          && t.FK_GECurrencyID == objRMBGECurrenciesInfo.GECurrencyID
        //                                                          && t.ACDocumentEntryType == "Credit"
        //                                                          && t.ACDocumentDate.Date <= dateTo.Date
        //                                                          && t.ACDocumentDate.Date >= dateFrom.Date).ToList();
        //                if (accountEntriesByBranch_RMB != null && accountEntriesByBranch_RMB.Count > 0)
        //                {
        //                    entry.TransactionCreditAccountRMB += accountEntriesByBranch_RMB.Sum(t => t.ACDocumentEntryAmount);
        //                    baseTransactionCreditRMB = accountEntriesByBranch_RMB.Sum(t => t.ACDocumentEntryExchangeAmount);
        //                    entry.TransactionCreditAccountVND4RMB += baseTransactionCreditRMB;
        //                }

        //                // SGD period debit
        //                accountEntriesByBranch_SGD = accountEntries_SGD.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                           && t.ACObjectType == obj.ACObjectType
        //                                                           && t.FK_BRBranchID == branch.BRBranchID
        //                                                           && t.FK_GECurrencyID == objSGDGECurrenciesInfo.GECurrencyID
        //                                                           && t.ACDocumentEntryType == "Debit"
        //                                                           && t.ACDocumentDate.Date <= dateTo.Date
        //                                                           && t.ACDocumentDate.Date >= dateFrom.Date).ToList();
        //                if (accountEntriesByBranch_SGD != null && accountEntriesByBranch_SGD.Count > 0)
        //                {
        //                    entry.TransactionDebitAccountSGD += accountEntriesByBranch_SGD.Sum(t => t.ACDocumentEntryAmount);
        //                    baseTransactionDebitSGD = accountEntriesByBranch_SGD.Sum(t => t.ACDocumentEntryExchangeAmount);
        //                    entry.TransactionDebitAccountVND4SGD += baseTransactionDebitSGD;
        //                }

        //                //SGD period credit  
        //                accountEntriesByBranch_SGD = accountEntries_SGD.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                          && t.ACObjectType == obj.ACObjectType
        //                                                          && t.FK_BRBranchID == branch.BRBranchID
        //                                                          && t.FK_GECurrencyID == objSGDGECurrenciesInfo.GECurrencyID
        //                                                          && t.ACDocumentEntryType == "Credit"
        //                                                          && t.ACDocumentDate.Date <= dateTo.Date
        //                                                          && t.ACDocumentDate.Date >= dateFrom.Date).ToList();
        //                if (accountEntriesByBranch_SGD != null && accountEntriesByBranch_SGD.Count > 0)
        //                {
        //                    entry.TransactionCreditAccountSGD += accountEntriesByBranch_SGD.Sum(t => t.ACDocumentEntryAmount);
        //                    baseTransactionCreditSGD = accountEntriesByBranch_SGD.Sum(t => t.ACDocumentEntryExchangeAmount);
        //                    entry.TransactionCreditAccountVND4SGD += baseTransactionCreditSGD;
        //                }

        //                // GBP period debit
        //                accountEntriesByBranch_GBP = accountEntries_GBP.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                           && t.ACObjectType == obj.ACObjectType
        //                                                           && t.FK_BRBranchID == branch.BRBranchID
        //                                                           && t.FK_GECurrencyID == objGBPGECurrenciesInfo.GECurrencyID
        //                                                           && t.ACDocumentEntryType == "Debit"
        //                                                           && t.ACDocumentDate.Date <= dateTo.Date
        //                                                           && t.ACDocumentDate.Date >= dateFrom.Date).ToList();
        //                if (accountEntriesByBranch_GBP != null && accountEntriesByBranch_GBP.Count > 0)
        //                {
        //                    entry.TransactionDebitAccountGBP += accountEntriesByBranch_GBP.Sum(t => t.ACDocumentEntryAmount);
        //                    baseTransactionDebitGBP = accountEntriesByBranch_GBP.Sum(t => t.ACDocumentEntryExchangeAmount);
        //                    entry.TransactionDebitAccountVND4GBP += baseTransactionDebitGBP;
        //                }

        //                //GBP period credit  
        //                accountEntriesByBranch_GBP = accountEntries_GBP.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                          && t.ACObjectType == obj.ACObjectType
        //                                                          && t.FK_BRBranchID == branch.BRBranchID
        //                                                          && t.FK_GECurrencyID == objGBPGECurrenciesInfo.GECurrencyID
        //                                                          && t.ACDocumentEntryType == "Credit"
        //                                                          && t.ACDocumentDate.Date <= dateTo.Date
        //                                                          && t.ACDocumentDate.Date >= dateFrom.Date).ToList();
        //                if (accountEntriesByBranch_GBP != null && accountEntriesByBranch_GBP.Count > 0)
        //                {
        //                    entry.TransactionCreditAccountGBP += accountEntriesByBranch_GBP.Sum(t => t.ACDocumentEntryAmount);
        //                    baseTransactionCreditGBP = accountEntriesByBranch_GBP.Sum(t => t.ACDocumentEntryExchangeAmount);
        //                    entry.TransactionCreditAccountVND4GBP += baseTransactionCreditGBP;
        //                }

        //                if (fld_cmbViewType.SelectedIndex != 0)
        //                {
        //                    //VND

        //                    financelIncomeListByBranch_VND = financelIncomeList_VND.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                                    && t.ACObjectType == obj.ACObjectType
        //                                                                    && t.FK_BRBranchID == branch.BRBranchID).ToList();
        //                    if (financelIncomeListByBranch_VND != null && financelIncomeListByBranch_VND.Count > 0)
        //                    {
        //                        financialIncomeAmount = financelIncomeListByBranch_VND.Sum(t => t.ACDocumentEntryAmount);
        //                        entry.TransactionDebitAccountVND -= financialIncomeAmount;
        //                    }

        //                    financelCostListByBranch_VND = financelCostList_VND.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                                     && t.ACObjectType == obj.ACObjectType
        //                                                                     && t.FK_BRBranchID == branch.BRBranchID).ToList();
        //                    if (financelCostListByBranch_VND != null && financelCostListByBranch_VND.Count > 0)
        //                    {
        //                        financialCostAmount = financelCostListByBranch_VND.Sum(t => t.ACDocumentEntryAmount);
        //                        entry.TransactionCreditAccountVND -= financialCostAmount;
        //                    }



        //                    //USD
        //                    financelIncomeListByBranch_USD = financelIncomeList_USD.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                                    && t.ACObjectType == obj.ACObjectType
        //                                                                    && t.FK_BRBranchID == branch.BRBranchID).ToList();
        //                    if (financelIncomeListByBranch_USD != null && financelIncomeListByBranch_USD.Count > 0)
        //                    {
        //                        financialIncomeAmount = financelIncomeListByBranch_USD.Sum(t => t.ACDocumentEntryAmount);
        //                        entry.TransactionDebitAccountUSD -= financialIncomeAmount;
        //                    }

        //                    financelCostListByBranch_USD = financelCostList_USD.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                                     && t.ACObjectType == obj.ACObjectType
        //                                                                     && t.FK_BRBranchID == branch.BRBranchID).ToList();
        //                    if (financelCostListByBranch_USD != null && financelCostListByBranch_USD.Count > 0)
        //                    {
        //                        financialCostAmount = financelCostListByBranch_USD.Sum(t => t.ACDocumentEntryAmount);
        //                        entry.TransactionCreditAccountUSD -= financialCostAmount;
        //                    }

        //                    //EURO
        //                    financelIncomeListByBranch_EURO = financelIncomeList_EURO.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                                    && t.ACObjectType == obj.ACObjectType
        //                                                                    && t.FK_BRBranchID == branch.BRBranchID).ToList();
        //                    if (financelIncomeListByBranch_EURO != null && financelIncomeListByBranch_EURO.Count > 0)
        //                    {
        //                        financialIncomeAmount = financelIncomeListByBranch_EURO.Sum(t => t.ACDocumentEntryAmount);
        //                        entry.TransactionDebitAccountEURO -= financialIncomeAmount;
        //                    }

        //                    financelCostListByBranch_EURO = financelCostList_EURO.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                                     && t.ACObjectType == obj.ACObjectType
        //                                                                     && t.FK_BRBranchID == branch.BRBranchID).ToList();
        //                    if (financelCostListByBranch_EURO != null && financelCostListByBranch_EURO.Count > 0)
        //                    {
        //                        financialCostAmount = financelCostListByBranch_EURO.Sum(t => t.ACDocumentEntryAmount);
        //                        entry.TransactionCreditAccountEURO -= financialCostAmount;
        //                    }


        //                    //RMB
        //                    financelIncomeListByBranch_RMB = financelIncomeList_RMB.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                                   && t.ACObjectType == obj.ACObjectType
        //                                                                   && t.FK_BRBranchID == branch.BRBranchID).ToList();
        //                    if (financelIncomeListByBranch_RMB != null && financelIncomeListByBranch_RMB.Count > 0)
        //                    {
        //                        financialIncomeAmount = financelIncomeListByBranch_RMB.Sum(t => t.ACDocumentEntryAmount);
        //                        entry.TransactionDebitAccountRMB -= financialIncomeAmount;
        //                    }

        //                    financelCostListByBranch_RMB = financelCostList_RMB.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                                     && t.ACObjectType == obj.ACObjectType
        //                                                                     && t.FK_BRBranchID == branch.BRBranchID).ToList();
        //                    if (financelCostListByBranch_RMB != null && financelCostListByBranch_RMB.Count > 0)
        //                    {
        //                        financialCostAmount = financelCostListByBranch_RMB.Sum(t => t.ACDocumentEntryAmount);
        //                        entry.TransactionCreditAccountRMB -= financialCostAmount;
        //                    }

        //                    //SGD
        //                    financelIncomeListByBranch_SGD = financelIncomeList_SGD.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                                    && t.ACObjectType == obj.ACObjectType
        //                                                                    && t.FK_BRBranchID == branch.BRBranchID).ToList();
        //                    if (financelIncomeListByBranch_SGD != null && financelIncomeListByBranch_SGD.Count > 0)
        //                    {
        //                        financialIncomeAmount = financelIncomeListByBranch_SGD.Sum(t => t.ACDocumentEntryAmount);
        //                        entry.TransactionDebitAccountSGD -= financialIncomeAmount;
        //                    }

        //                    financelCostListByBranch_SGD = financelCostList_SGD.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                                     && t.ACObjectType == obj.ACObjectType
        //                                                                     && t.FK_BRBranchID == branch.BRBranchID).ToList();
        //                    if (financelCostListByBranch_SGD != null && financelCostListByBranch_SGD.Count > 0)
        //                    {
        //                        financialCostAmount = financelCostListByBranch_SGD.Sum(t => t.ACDocumentEntryAmount);
        //                        entry.TransactionCreditAccountSGD -= financialCostAmount;
        //                    }


        //                    //GBP
        //                    financelIncomeListByBranch_GBP = financelIncomeList_GBP.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                                   && t.ACObjectType == obj.ACObjectType
        //                                                                   && t.FK_BRBranchID == branch.BRBranchID).ToList();
        //                    if (financelIncomeListByBranch_GBP != null && financelIncomeListByBranch_GBP.Count > 0)
        //                    {
        //                        financialIncomeAmount = financelIncomeListByBranch_GBP.Sum(t => t.ACDocumentEntryAmount);
        //                        entry.TransactionDebitAccountGBP -= financialIncomeAmount;
        //                    }

        //                    financelCostListByBranch_GBP = financelCostList_GBP.Where(t => t.FK_ACObjectID == obj.ACObjectID
        //                                                                     && t.ACObjectType == obj.ACObjectType
        //                                                                     && t.FK_BRBranchID == branch.BRBranchID).ToList();
        //                    if (financelCostListByBranch_GBP != null && financelCostListByBranch_GBP.Count > 0)
        //                    {
        //                        financialCostAmount = financelCostListByBranch_GBP.Sum(t => t.ACDocumentEntryAmount);
        //                        entry.TransactionCreditAccountGBP -= financialCostAmount;
        //                    }
        //                }
        //            }
        //            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END

        //            if (startBalanceVND > 0)
        //            {
        //                entry.OpenBalanceCreditAmountVND = Math.Abs(startBalanceVND);
        //            }
        //            else if (startBalanceVND < 0)
        //            {
        //                entry.OpenBalanceDebitAmountVND = Math.Abs(startBalanceVND);
        //            }

        //            decimal endBalanceVND = Math.Round(startBalanceVND + entry.TransactionCreditAccountVND - entry.TransactionDebitAccountVND, 3);
        //            if (endBalanceVND > 0)
        //            {
        //                entry.EndCreditAccountVND = Math.Abs(endBalanceVND);
        //            }
        //            else
        //            {
        //                entry.EndDebitAccountVND = Math.Abs(endBalanceVND);
        //            }
        //            //usd
        //            if (startBalanceUSD > 0)
        //                entry.OpenBalanceCreditAmountUSD = Math.Abs(startBalanceUSD);
        //            else
        //                entry.OpenBalanceDebitAmountUSD = Math.Abs(startBalanceUSD);
        //            if (baseOpenBalancetUSD > 0)
        //                entry.OpenBalanceCreditAmountVND4USD = Math.Abs(baseOpenBalancetUSD);
        //            else
        //                entry.OpenBalanceDebitAmountVND4USD = Math.Abs(baseOpenBalancetUSD);


        //            decimal endBalanceUSD = Math.Round(startBalanceUSD + entry.TransactionCreditAccountUSD - entry.TransactionDebitAccountUSD, 3);
        //            decimal baseEndBalanceUSD = Math.Round(baseOpenBalancetUSD + entry.TransactionCreditAccountVND4USD - entry.TransactionDebitAccountVND4USD, 3);
        //            if (endBalanceUSD > 0)
        //                entry.EndCreditAccountUSD = Math.Abs(endBalanceUSD);
        //            else
        //                entry.EndDebitAccountUSD = Math.Abs(endBalanceUSD);
        //            if (baseEndBalanceUSD > 0)
        //                entry.EndCreditAccountVND4USD = Math.Abs(baseEndBalanceUSD);
        //            else
        //                entry.EndDebitAccountVND4USD = Math.Abs(baseEndBalanceUSD);

        //            //EURO
        //            if (startBalanceEURO > 0)
        //                entry.OpenBalanceCreditAmountEURO = Math.Abs(startBalanceEURO);
        //            else if (startBalanceEURO < 0)
        //                entry.OpenBalanceDebitAmountEURO = Math.Abs(startBalanceEURO);
        //            if (baseOpenBalanceEURO > 0)
        //                entry.OpenBalanceCreditAmountVND4EURO = Math.Abs(baseOpenBalanceEURO);
        //            else
        //                entry.OpenBalanceDebitAmountVND4EURO = Math.Abs(baseOpenBalanceEURO);

        //            decimal endBalanceEURO = Math.Round(startBalanceEURO + entry.TransactionCreditAccountEURO - entry.TransactionDebitAccountEURO, 3);
        //            decimal endBalanceVND4EURO = Math.Round(baseOpenBalanceEURO + entry.TransactionCreditAccountVND4EURO - entry.TransactionDebitAccountVND4EURO, 3);
        //            if (endBalanceEURO > 0)
        //                entry.EndCreditAccountEURO = Math.Abs(endBalanceEURO);
        //            else
        //                entry.EndDebitAccountEURO = Math.Abs(endBalanceEURO);
        //            if (endBalanceVND4EURO > 0)
        //                entry.EndCreditAccountVND4EURO = Math.Abs(endBalanceVND4EURO);
        //            else
        //                entry.EndDebitAccountVND4EURO = Math.Abs(endBalanceVND4EURO);

        //            //RMB
        //            if (startBalanceRMB > 0)
        //                entry.OpenBalanceCreditAmountRMB = Math.Abs(startBalanceRMB);
        //            else if (startBalanceRMB < 0)
        //                entry.OpenBalanceDebitAmountRMB = Math.Abs(startBalanceRMB);
        //            if (baseOpenBalanceRMB > 0)
        //                entry.OpenBalanceCreditAmountVND4RMB = Math.Abs(baseOpenBalanceRMB);
        //            else
        //                entry.OpenBalanceDebitAmountVND4RMB = Math.Abs(baseOpenBalanceRMB);


        //            decimal endBalanceRMB = Math.Round(startBalanceRMB + entry.TransactionCreditAccountRMB - entry.TransactionDebitAccountRMB, 3);
        //            decimal endBalanceVND4RMB = Math.Round(baseOpenBalanceRMB + entry.TransactionCreditAccountVND4RMB - entry.TransactionDebitAccountVND4RMB, 3);
        //            if (endBalanceRMB > 0)
        //                entry.EndCreditAccountRMB = Math.Abs(endBalanceRMB);
        //            else
        //                entry.EndDebitAccountRMB = Math.Abs(endBalanceRMB);
        //            if (endBalanceVND4RMB > 0)
        //                entry.EndCreditAccountVND4RMB = Math.Abs(endBalanceVND4RMB);
        //            else
        //                entry.EndDebitAccountVND4RMB = Math.Abs(endBalanceVND4RMB);


        //            //SGD
        //            if (startBalanceSGD > 0)
        //                entry.OpenBalanceCreditAmountSGD = Math.Abs(startBalanceSGD);
        //            else if (startBalanceSGD < 0)
        //                entry.OpenBalanceDebitAmountSGD = Math.Abs(startBalanceSGD);
        //            if (baseOpenBalanceSGD > 0)
        //                entry.OpenBalanceCreditAmountVND4SGD = Math.Abs(baseOpenBalanceSGD);
        //            else
        //                entry.OpenBalanceDebitAmountVND4SGD = Math.Abs(baseOpenBalanceSGD);

        //            decimal endBalanceSGD = Math.Round(startBalanceSGD + entry.TransactionCreditAccountSGD - entry.TransactionDebitAccountSGD, 3);
        //            decimal endBalanceVND4SGD = Math.Round(baseOpenBalanceSGD + entry.TransactionCreditAccountVND4SGD - entry.TransactionDebitAccountVND4SGD, 3);
        //            if (endBalanceSGD > 0)
        //                entry.EndCreditAccountSGD = Math.Abs(endBalanceSGD);
        //            else
        //                entry.EndDebitAccountSGD = Math.Abs(endBalanceSGD);
        //            if (endBalanceVND4SGD > 0)
        //                entry.EndCreditAccountVND4SGD = Math.Abs(endBalanceVND4SGD);
        //            else
        //                entry.EndDebitAccountVND4SGD = Math.Abs(endBalanceVND4SGD);

        //            //GBP
        //            if (startBalanceGBP > 0)
        //                entry.OpenBalanceCreditAmountGBP = Math.Abs(startBalanceGBP);
        //            else if (startBalanceGBP < 0)
        //                entry.OpenBalanceDebitAmountGBP = Math.Abs(startBalanceGBP);
        //            if (baseOpenBalanceGBP > 0)
        //                entry.OpenBalanceCreditAmountVND4GBP = Math.Abs(baseOpenBalanceGBP);
        //            else
        //                entry.OpenBalanceDebitAmountVND4GBP = Math.Abs(baseOpenBalanceGBP);


        //            decimal endBalanceGBP = Math.Round(startBalanceGBP + entry.TransactionCreditAccountGBP - entry.TransactionDebitAccountGBP, 3);
        //            decimal endBalanceVND4GBP = Math.Round(baseOpenBalanceGBP + entry.TransactionCreditAccountVND4GBP - entry.TransactionDebitAccountVND4GBP, 3);
        //            if (endBalanceGBP > 0)
        //                entry.EndCreditAccountGBP = Math.Abs(endBalanceGBP);
        //            else
        //                entry.EndDebitAccountGBP = Math.Abs(endBalanceGBP);
        //            if (endBalanceVND4GBP > 0)
        //                entry.EndCreditAccountVND4GBP = Math.Abs(endBalanceVND4GBP);
        //            else
        //                entry.EndDebitAccountVND4GBP = Math.Abs(endBalanceVND4GBP);


        //            ////old code
        //            //if (fld_cmbViewType.SelectedIndex == 0)
        //            //{
        //            //    if ((entry.TransactionDebitAccountVND > 0 || entry.TransactionCreditAccountVND > 0 || endBalanceVND != 0) ||
        //            //        (entry.TransactionDebitAccountUSD > 0 || entry.TransactionCreditAccountUSD > 0 || endBalanceUSD != 0) ||
        //            //        (entry.TransactionDebitAccountEURO > 0 || entry.TransactionCreditAccountEURO > 0 || endBalanceEURO != 0) ||
        //            //        (entry.TransactionDebitAccountRMB > 0 || entry.TransactionCreditAccountRMB > 0 || endBalanceRMB != 0))
        //            //    {
        //            //        entries.Add(entry);
        //            //    }
        //            //}
        //            //else if (fld_cmbViewType.SelectedIndex == 1)
        //            //{
        //            //    if ((endBalanceVND != 0) || (endBalanceUSD != 0) || (endBalanceEURO != 0) || (endBalanceRMB != 0))
        //            //    {
        //            //        entries.Add(entry);
        //            //    }
        //            //}

        //            showAllCurrency = false;
        //            if (fld_cmbViewType.SelectedIndex == 0)
        //            {
        //                if ((entry.TransactionDebitAccountVND > 0 || entry.TransactionCreditAccountVND > 0 || endBalanceVND != 0) ||
        //                    (entry.TransactionDebitAccountUSD > 0 || entry.TransactionCreditAccountUSD > 0 || endBalanceUSD != 0) ||
        //                    (entry.TransactionDebitAccountEURO > 0 || entry.TransactionCreditAccountEURO > 0 || endBalanceEURO != 0) ||
        //                    (entry.TransactionDebitAccountRMB > 0 || entry.TransactionCreditAccountRMB > 0 || endBalanceRMB != 0) ||
        //                    (entry.TransactionDebitAccountSGD > 0 || entry.TransactionCreditAccountSGD > 0 || endBalanceSGD != 0) ||
        //                    (entry.TransactionDebitAccountGBP > 0 || entry.TransactionCreditAccountGBP > 0 || endBalanceGBP != 0))
        //                {
        //                    showAllCurrency = true;
        //                }
        //            }

        //            //VND
        //            if (showAllCurrency || endBalanceVND != 0)
        //            {
        //                ACDocumentEntrysInfo documentEntry4VND = new ACDocumentEntrysInfo();
        //                documentEntry4VND.ACObjectNo = obj.ACObjectNo;
        //                documentEntry4VND.ACObjectName = obj.ACObjectName;
        //                documentEntry4VND.ACDocumentEntryAccountNo = objAccountsInfo.ACAccountNo;
        //                documentEntry4VND.ACDocumentEntryAccountNoDisplayText = accountNoAndName;
        //                documentEntry4VND.GECurrencyName = objVNDGECurrenciesInfo.GECurrencyName;

        //                //documentEntry4VND.OpenBalanceCreditAmount = entry.OpenBalanceCreditAmountVND;
        //                documentEntry4VND.OpenBalanceCreditExchangeAmount = entry.OpenBalanceCreditAmountVND;
        //                documentEntry4VND.OpenBalanceCreditAmountVND = entry.OpenBalanceCreditAmountVND;

        //                //documentEntry4VND.OpenBalanceDebitAmount = entry.OpenBalanceDebitAmountVND;
        //                documentEntry4VND.OpenBalanceDebitExchangeAmount = entry.OpenBalanceDebitAmountVND;
        //                documentEntry4VND.OpenBalanceDebitAmountVND = entry.OpenBalanceDebitAmountVND;

        //                //documentEntry4VND.TransactionCreditAccount = entry.TransactionCreditAccountVND;
        //                documentEntry4VND.TransactionCreditExchangeAccount = entry.TransactionCreditAccountVND;
        //                documentEntry4VND.TransactionCreditAccountVND = entry.TransactionCreditAccountVND;

        //                //documentEntry4VND.TransactionDebitAccount = entry.TransactionDebitAccountVND;
        //                documentEntry4VND.TransactionDebitExchangeAccount = entry.TransactionDebitAccountVND;
        //                documentEntry4VND.TransactionDebitAccountVND = entry.TransactionDebitAccountVND;

        //                //documentEntry4VND.EndCreditAccount = entry.EndCreditAccountVND;
        //                documentEntry4VND.EndCreditExchangeAccount = entry.EndCreditAccountVND;
        //                documentEntry4VND.EndCreditAccountVND = entry.EndCreditAccountVND;

        //                //documentEntry4VND.EndDebitAccount = entry.EndDebitAccountVND;
        //                documentEntry4VND.EndDebitExchangeAccount = entry.EndDebitAccountVND;
        //                documentEntry4VND.EndDebitAccountVND = entry.EndDebitAccountVND;
        //                entries.Add(documentEntry4VND);
        //            }

        //            //USD
        //            if (showAllCurrency || endBalanceUSD != 0 || baseOpenBalancetUSD != 0)
        //            {
        //                ACDocumentEntrysInfo documentEntry4USD = new ACDocumentEntrysInfo();
        //                documentEntry4USD.ACObjectNo = obj.ACObjectNo;
        //                documentEntry4USD.ACObjectName = obj.ACObjectName;
        //                documentEntry4USD.ACDocumentEntryAccountNo = objAccountsInfo.ACAccountNo;
        //                documentEntry4USD.ACDocumentEntryAccountNoDisplayText = accountNoAndName;
        //                documentEntry4USD.GECurrencyName = objUSDGECurrenciesInfo.GECurrencyName;

        //                documentEntry4USD.OpenBalanceCreditAmount = entry.OpenBalanceCreditAmountUSD;
        //                documentEntry4USD.OpenBalanceCreditExchangeAmount = entry.OpenBalanceCreditAmountVND4USD;
        //                documentEntry4USD.OpenBalanceCreditAmountUSD = entry.OpenBalanceCreditAmountUSD;
        //                documentEntry4USD.OpenBalanceCreditAmountVND4USD = entry.OpenBalanceCreditAmountVND4USD;

        //                documentEntry4USD.OpenBalanceDebitAmount = entry.OpenBalanceDebitAmountUSD;
        //                documentEntry4USD.OpenBalanceDebitExchangeAmount = entry.OpenBalanceDebitAmountVND4USD;
        //                documentEntry4USD.OpenBalanceDebitAmountUSD = entry.OpenBalanceDebitAmountUSD;
        //                documentEntry4USD.OpenBalanceDebitAmountVND4USD = entry.OpenBalanceDebitAmountVND4USD;

        //                documentEntry4USD.TransactionCreditAccount = entry.TransactionCreditAccountUSD;
        //                documentEntry4USD.TransactionCreditExchangeAccount = entry.TransactionCreditAccountVND4USD;
        //                documentEntry4USD.TransactionCreditAccountUSD = entry.TransactionCreditAccountUSD;
        //                documentEntry4USD.TransactionCreditAccountVND4USD = entry.TransactionCreditAccountVND4USD;

        //                documentEntry4USD.TransactionDebitAccount = entry.TransactionDebitAccountUSD;
        //                documentEntry4USD.TransactionDebitExchangeAccount = entry.TransactionDebitAccountVND4USD;
        //                documentEntry4USD.TransactionDebitAccountUSD = entry.TransactionDebitAccountUSD;
        //                documentEntry4USD.TransactionDebitAccountVND4USD = entry.TransactionDebitAccountVND4USD;

        //                documentEntry4USD.EndCreditAccount = entry.EndCreditAccountUSD;
        //                documentEntry4USD.EndCreditExchangeAccount = entry.EndCreditAccountVND4USD;
        //                documentEntry4USD.EndCreditAccountUSD = entry.EndCreditAccountUSD;
        //                documentEntry4USD.EndCreditAccountVND4USD = entry.EndCreditAccountVND4USD;

        //                documentEntry4USD.EndDebitAccount = entry.EndDebitAccountUSD;
        //                documentEntry4USD.EndDebitExchangeAccount = entry.EndDebitAccountVND4USD;
        //                documentEntry4USD.EndDebitAccountUSD = entry.EndDebitAccountUSD;
        //                documentEntry4USD.EndDebitAccountVND4USD = entry.EndDebitAccountVND4USD;

        //                entries.Add(documentEntry4USD);
        //            }

        //            //EURO
        //            if (showAllCurrency || endBalanceEURO != 0 || baseOpenBalanceEURO != 0)
        //            {
        //                ACDocumentEntrysInfo documentEntry4EURO = new ACDocumentEntrysInfo();
        //                documentEntry4EURO.ACObjectNo = obj.ACObjectNo;
        //                documentEntry4EURO.ACObjectName = obj.ACObjectName;
        //                documentEntry4EURO.ACDocumentEntryAccountNo = objAccountsInfo.ACAccountNo;
        //                documentEntry4EURO.ACDocumentEntryAccountNoDisplayText = accountNoAndName;
        //                documentEntry4EURO.GECurrencyName = objEUROGECurrenciesInfo.GECurrencyName;

        //                documentEntry4EURO.OpenBalanceCreditAmount = entry.OpenBalanceCreditAmountEURO;
        //                documentEntry4EURO.OpenBalanceCreditExchangeAmount = entry.OpenBalanceCreditAmountVND4EURO;
        //                documentEntry4EURO.OpenBalanceCreditAmountEURO = entry.OpenBalanceCreditAmountEURO;
        //                documentEntry4EURO.OpenBalanceCreditAmountVND4EURO = entry.OpenBalanceCreditAmountVND4EURO;

        //                documentEntry4EURO.OpenBalanceDebitAmount = entry.OpenBalanceDebitAmountEURO;
        //                documentEntry4EURO.OpenBalanceDebitExchangeAmount = entry.OpenBalanceDebitAmountVND4EURO;
        //                documentEntry4EURO.OpenBalanceDebitAmountEURO = entry.OpenBalanceDebitAmountEURO;
        //                documentEntry4EURO.OpenBalanceDebitAmountVND4EURO = entry.OpenBalanceDebitAmountVND4EURO;

        //                documentEntry4EURO.TransactionCreditAccount = entry.TransactionCreditAccountEURO;
        //                documentEntry4EURO.TransactionCreditExchangeAccount = entry.TransactionCreditAccountVND4EURO;
        //                documentEntry4EURO.TransactionCreditAccountEURO = entry.TransactionCreditAccountEURO;
        //                documentEntry4EURO.TransactionCreditAccountVND4EURO = entry.TransactionCreditAccountVND4EURO;

        //                documentEntry4EURO.TransactionDebitAccount = entry.TransactionDebitAccountEURO;
        //                documentEntry4EURO.TransactionDebitExchangeAccount = entry.TransactionDebitAccountVND4EURO;
        //                documentEntry4EURO.TransactionDebitAccountEURO = entry.TransactionDebitAccountEURO;
        //                documentEntry4EURO.TransactionDebitAccountVND4EURO = entry.TransactionDebitAccountVND4EURO;

        //                documentEntry4EURO.EndCreditAccount = entry.EndCreditAccountEURO;
        //                documentEntry4EURO.EndCreditExchangeAccount = entry.EndCreditAccountVND4EURO;
        //                documentEntry4EURO.EndCreditAccountEURO = entry.EndCreditAccountEURO;
        //                documentEntry4EURO.EndCreditAccountVND4EURO = entry.EndCreditAccountVND4EURO;

        //                documentEntry4EURO.EndDebitAccount = entry.EndDebitAccountEURO;
        //                documentEntry4EURO.EndDebitExchangeAccount = entry.EndDebitAccountVND4EURO;
        //                documentEntry4EURO.EndDebitAccountEURO = entry.EndDebitAccountEURO;
        //                documentEntry4EURO.EndDebitAccountVND4EURO = entry.EndDebitAccountVND4EURO;

        //                entries.Add(documentEntry4EURO);
        //            }

        //            //RMB
        //            if (showAllCurrency || endBalanceVND4RMB != 0 || baseOpenBalanceRMB != 0)
        //            {
        //                ACDocumentEntrysInfo documentEntry4RMB = new ACDocumentEntrysInfo();
        //                documentEntry4RMB.ACObjectNo = obj.ACObjectNo;
        //                documentEntry4RMB.ACObjectName = obj.ACObjectName;
        //                documentEntry4RMB.ACDocumentEntryAccountNo = objAccountsInfo.ACAccountNo;
        //                documentEntry4RMB.ACDocumentEntryAccountNoDisplayText = accountNoAndName;
        //                documentEntry4RMB.GECurrencyName = objRMBGECurrenciesInfo.GECurrencyName;

        //                documentEntry4RMB.OpenBalanceCreditAmount = entry.OpenBalanceCreditAmountRMB;
        //                documentEntry4RMB.OpenBalanceCreditExchangeAmount = entry.OpenBalanceCreditAmountVND4RMB;
        //                documentEntry4RMB.OpenBalanceCreditAmountRMB = entry.OpenBalanceCreditAmountRMB;
        //                documentEntry4RMB.OpenBalanceCreditAmountVND4RMB = entry.OpenBalanceCreditAmountVND4RMB;

        //                documentEntry4RMB.OpenBalanceDebitAmount = entry.OpenBalanceDebitAmountRMB;
        //                documentEntry4RMB.OpenBalanceDebitExchangeAmount = entry.OpenBalanceDebitAmountVND4RMB;
        //                documentEntry4RMB.OpenBalanceDebitAmountRMB = entry.OpenBalanceDebitAmountRMB;
        //                documentEntry4RMB.OpenBalanceDebitAmountVND4RMB = entry.OpenBalanceDebitAmountVND4RMB;

        //                documentEntry4RMB.TransactionCreditAccount = entry.TransactionCreditAccountRMB;
        //                documentEntry4RMB.TransactionCreditExchangeAccount = entry.TransactionCreditAccountVND4RMB;
        //                documentEntry4RMB.TransactionCreditAccountRMB = entry.TransactionCreditAccountRMB;
        //                documentEntry4RMB.TransactionCreditAccountVND4RMB = entry.TransactionCreditAccountVND4RMB;

        //                documentEntry4RMB.TransactionDebitAccount = entry.TransactionDebitAccountRMB;
        //                documentEntry4RMB.TransactionDebitExchangeAccount = entry.TransactionDebitAccountVND4RMB;
        //                documentEntry4RMB.TransactionDebitAccountRMB = entry.TransactionDebitAccountRMB;
        //                documentEntry4RMB.TransactionDebitAccountVND4RMB = entry.TransactionDebitAccountVND4RMB;

        //                documentEntry4RMB.EndCreditAccount = entry.EndCreditAccountRMB;
        //                documentEntry4RMB.EndCreditExchangeAccount = entry.EndCreditAccountVND4RMB;
        //                documentEntry4RMB.EndCreditAccountRMB = entry.EndCreditAccountRMB;
        //                documentEntry4RMB.EndCreditAccountVND4RMB = entry.EndCreditAccountVND4RMB;

        //                documentEntry4RMB.EndDebitAccount = entry.EndDebitAccountRMB;
        //                documentEntry4RMB.EndDebitExchangeAccount = entry.EndDebitAccountVND4RMB;
        //                documentEntry4RMB.EndDebitAccountRMB = entry.EndDebitAccountRMB;
        //                documentEntry4RMB.EndDebitAccountVND4RMB = entry.EndDebitAccountVND4RMB;

        //                entries.Add(documentEntry4RMB);
        //            }

        //            //SGD
        //            if (showAllCurrency || endBalanceSGD != 0 || baseOpenBalanceSGD != 0)
        //            {
        //                ACDocumentEntrysInfo documentEntry4SGD = new ACDocumentEntrysInfo();
        //                documentEntry4SGD.ACObjectNo = obj.ACObjectNo;
        //                documentEntry4SGD.ACObjectName = obj.ACObjectName;
        //                documentEntry4SGD.ACDocumentEntryAccountNo = objAccountsInfo.ACAccountNo;
        //                documentEntry4SGD.ACDocumentEntryAccountNoDisplayText = accountNoAndName;
        //                documentEntry4SGD.GECurrencyName = objSGDGECurrenciesInfo.GECurrencyName;

        //                documentEntry4SGD.OpenBalanceCreditAmount = entry.OpenBalanceCreditAmountSGD;
        //                documentEntry4SGD.OpenBalanceCreditExchangeAmount = entry.OpenBalanceCreditAmountVND4SGD;
        //                documentEntry4SGD.OpenBalanceCreditAmountSGD = entry.OpenBalanceCreditAmountSGD;
        //                documentEntry4SGD.OpenBalanceCreditAmountVND4SGD = entry.OpenBalanceCreditAmountVND4SGD;

        //                documentEntry4SGD.OpenBalanceDebitAmount = entry.OpenBalanceDebitAmountSGD;
        //                documentEntry4SGD.OpenBalanceDebitExchangeAmount = entry.OpenBalanceDebitAmountVND4SGD;
        //                documentEntry4SGD.OpenBalanceDebitAmountSGD = entry.OpenBalanceDebitAmountSGD;
        //                documentEntry4SGD.OpenBalanceDebitAmountVND4SGD = entry.OpenBalanceDebitAmountVND4SGD;

        //                documentEntry4SGD.TransactionCreditAccount = entry.TransactionCreditAccountSGD;
        //                documentEntry4SGD.TransactionCreditExchangeAccount = entry.TransactionCreditAccountVND4SGD;
        //                documentEntry4SGD.TransactionCreditAccountSGD = entry.TransactionCreditAccountSGD;
        //                documentEntry4SGD.TransactionCreditAccountVND4SGD = entry.TransactionCreditAccountVND4SGD;

        //                documentEntry4SGD.TransactionDebitAccount = entry.TransactionDebitAccountSGD;
        //                documentEntry4SGD.TransactionDebitExchangeAccount = entry.TransactionDebitAccountVND4SGD;
        //                documentEntry4SGD.TransactionDebitAccountSGD = entry.TransactionDebitAccountSGD;
        //                documentEntry4SGD.TransactionDebitAccountVND4SGD = entry.TransactionDebitAccountVND4SGD;

        //                documentEntry4SGD.EndCreditAccount = entry.EndCreditAccountSGD;
        //                documentEntry4SGD.EndCreditExchangeAccount = entry.EndCreditAccountVND4SGD;
        //                documentEntry4SGD.EndCreditAccountSGD = entry.EndCreditAccountSGD;
        //                documentEntry4SGD.EndCreditAccountVND4SGD = entry.EndCreditAccountVND4SGD;

        //                documentEntry4SGD.EndDebitAccount = entry.EndDebitAccountSGD;
        //                documentEntry4SGD.EndDebitExchangeAccount = entry.EndDebitAccountVND4SGD;
        //                documentEntry4SGD.EndDebitAccountSGD = entry.EndDebitAccountSGD;
        //                documentEntry4SGD.EndDebitAccountVND4SGD = entry.EndDebitAccountVND4SGD;

        //                entries.Add(documentEntry4SGD);
        //            }

        //            //GBP
        //            if (showAllCurrency || endBalanceVND4GBP != 0 || baseOpenBalanceGBP != 0)
        //            {
        //                ACDocumentEntrysInfo documentEntry4GBP = new ACDocumentEntrysInfo();
        //                documentEntry4GBP.ACObjectNo = obj.ACObjectNo;
        //                documentEntry4GBP.ACObjectName = obj.ACObjectName;
        //                documentEntry4GBP.ACDocumentEntryAccountNo = objAccountsInfo.ACAccountNo;
        //                documentEntry4GBP.ACDocumentEntryAccountNoDisplayText = accountNoAndName;
        //                documentEntry4GBP.GECurrencyName = objGBPGECurrenciesInfo.GECurrencyName;

        //                documentEntry4GBP.OpenBalanceCreditAmount = entry.OpenBalanceCreditAmountGBP;
        //                documentEntry4GBP.OpenBalanceCreditExchangeAmount = entry.OpenBalanceCreditAmountVND4GBP;
        //                documentEntry4GBP.OpenBalanceCreditAmountGBP = entry.OpenBalanceCreditAmountGBP;
        //                documentEntry4GBP.OpenBalanceCreditAmountVND4GBP = entry.OpenBalanceCreditAmountVND4GBP;

        //                documentEntry4GBP.OpenBalanceDebitAmount = entry.OpenBalanceDebitAmountGBP;
        //                documentEntry4GBP.OpenBalanceDebitExchangeAmount = entry.OpenBalanceDebitAmountVND4GBP;
        //                documentEntry4GBP.OpenBalanceDebitAmountGBP = entry.OpenBalanceDebitAmountGBP;
        //                documentEntry4GBP.OpenBalanceDebitAmountVND4GBP = entry.OpenBalanceDebitAmountVND4GBP;

        //                documentEntry4GBP.TransactionCreditAccount = entry.TransactionCreditAccountGBP;
        //                documentEntry4GBP.TransactionCreditExchangeAccount = entry.TransactionCreditAccountVND4GBP;
        //                documentEntry4GBP.TransactionCreditAccountGBP = entry.TransactionCreditAccountGBP;
        //                documentEntry4GBP.TransactionCreditAccountVND4GBP = entry.TransactionCreditAccountVND4GBP;

        //                documentEntry4GBP.TransactionDebitAccount = entry.TransactionDebitAccountGBP;
        //                documentEntry4GBP.TransactionDebitExchangeAccount = entry.TransactionDebitAccountVND4GBP;
        //                documentEntry4GBP.TransactionDebitAccountGBP = entry.TransactionDebitAccountGBP;
        //                documentEntry4GBP.TransactionDebitAccountVND4GBP = entry.TransactionDebitAccountVND4GBP;

        //                documentEntry4GBP.EndCreditAccount = entry.EndCreditAccountGBP;
        //                documentEntry4GBP.EndCreditExchangeAccount = entry.EndCreditAccountVND4GBP;
        //                documentEntry4GBP.EndCreditAccountGBP = entry.EndCreditAccountGBP;
        //                documentEntry4GBP.EndCreditAccountVND4GBP = entry.EndCreditAccountVND4GBP;

        //                documentEntry4GBP.EndDebitAccount = entry.EndDebitAccountGBP;
        //                documentEntry4GBP.EndDebitExchangeAccount = entry.EndDebitAccountVND4GBP;
        //                documentEntry4GBP.EndDebitAccountGBP = entry.EndDebitAccountGBP;
        //                documentEntry4GBP.EndDebitAccountVND4GBP = entry.EndDebitAccountVND4GBP;

        //                entries.Add(documentEntry4GBP);
        //            }
        //        }
        //    }
        //    return entries;
        //}
        #endregion
    }
}
