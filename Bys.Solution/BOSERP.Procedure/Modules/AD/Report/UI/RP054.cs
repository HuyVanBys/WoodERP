using BOSCommon;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP054 : ReportForm
    {
        public RP054()
        {
            InitializeComponent();
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

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP054 report = new BOSReport.RP054();
            //report.LoadLayout(BOSCommon.Constants.Report.DevRP048Path);
            InitDataSourceReport(report);
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRP048Path, true);
            reviewer.Show();
        }

        /// <summary>
        /// Init data source report for displaying
        /// </summary>
        /// <param name="report">Given report</param>
        public void InitDataSourceReport(XtraReport report)
        {
            ADReportsController objReportsController = new ADReportsController();
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
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
            XRLabel dateTime = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            dateTime.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                    ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);
            List<ACAccountsInfo> accountList = GetReportData();
            if (accountList.Count > 0)
            {
                ACAccountsInfo account = accountList[accountList.Count - 1];
                account.TotalStartPeriodDebitBalance = accountList.Where(a => a.ACAccountNo.Length == 3).Sum(a => a.StartPeriodDebitBalance);
                account.TotalStartPeriodCreditBalance = accountList.Where(a => a.ACAccountNo.Length == 3).Sum(a => a.StartPeriodCreditBalance);
                account.TotalDebitAmount = accountList.Where(a => a.ACAccountNo.Length == 3).Sum(a => a.ACDocumentEntryDebitAmount);
                account.TotalCreditAmount = accountList.Where(a => a.ACAccountNo.Length == 3).Sum(a => a.ACDocumentEntryCreditAmount);
                account.TotalEndPeriodDebitBalance = accountList.Where(a => a.ACAccountNo.Length == 3).Sum(a => a.EndPeriodDebitBalance);
                account.TotalEndPeriodCreditBalance = accountList.Where(a => a.ACAccountNo.Length == 3).Sum(a => a.EndPeriodCreditBalance);

            }
            report.DataSource = accountList;
        }

        /// <summary>
        /// Get the data for the report
        /// </summary>
        /// <returns>List of accounts represents the report data</returns>
        private List<ACAccountsInfo> GetReportData()
        {
            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;
            int locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            string branchNos = GetSelectedBranchNosByLocationIDAndBranchID(locationID, branchID);
            ACAccountsController objAccountsController = new ACAccountsController();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            List<ACAccountsInfo> accounts = objAccountsController.GetAllAccountList();
            List<ACAccountsInfo> result = new List<ACAccountsInfo>();

            List<ACAccountsInfo> objDetail = new List<ACAccountsInfo>();
            ACAccountsInfo obj1;
            foreach (ACAccountsInfo account in accounts)
            {
                if (objAccountsController.IsBuiltInAccount(account.ACAccountNo))
                {
                    account.GroupValue = ReportLocalizedResources.BuiltInAccount;
                }
                else
                {
                    account.GroupValue = ReportLocalizedResources.NotBuiltInAccount;
                }
                if
                    //(!account.ACAccountNo.StartsWith("621")
                    //&& !account.ACAccountNo.StartsWith("627")
                    //&& !account.ACAccountNo.StartsWith("632")
                    //)
                    (!account.ACAccountNo.StartsWith("3311")
                    && !account.ACAccountNo.StartsWith("3312"))
                {
                    //continue;
                }

                if (account.ACAccountType != AccountType.DebitCreditBalance.ToString())
                {
                    decimal startBalance = 0;
                    startBalance += objDocumentEntrysController.GetAccountBalanceByBranchNoList(account.ACAccountNo, fromDate.AddDays(-1), null, null, null, null, branchNos);
                    account.ACDocumentEntryDebitAmount += objDocumentEntrysController.GetAccountDebitAmountBySomeCriteria(account.ACAccountNo, null, null, null, null, fromDate, toDate, branchNos);
                    account.ACDocumentEntryCreditAmount += objDocumentEntrysController.GetAccountCreditAmountBySomeCriteria(account.ACAccountNo, null, null, null, null, fromDate, toDate, branchNos);

                    if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByDebit.ToString())
                    {
                        if (startBalance > 0)
                        {
                            account.StartPeriodDebitBalance = Math.Abs(startBalance);
                        }
                        else if (startBalance < 0)
                        {
                            account.StartPeriodCreditBalance = Math.Abs(startBalance);
                        }
                    }
                    else if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByCredit.ToString())
                    {
                        if (startBalance > 0)
                        {
                            account.StartPeriodCreditBalance = Math.Abs(startBalance);
                        }
                        else if (startBalance < 0)
                        {
                            account.StartPeriodDebitBalance = Math.Abs(startBalance);
                        }
                    }

                    decimal endBalance = 0;
                    if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByDebit.ToString())
                    {
                        endBalance = startBalance + account.ACDocumentEntryDebitAmount - account.ACDocumentEntryCreditAmount;
                        if (endBalance > 0)
                        {
                            account.EndPeriodDebitBalance = Math.Abs(endBalance);
                        }
                        else if (endBalance < 0)
                        {
                            account.EndPeriodCreditBalance = Math.Abs(endBalance);
                        }
                    }
                    else if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByCredit.ToString())
                    {
                        endBalance = startBalance + account.ACDocumentEntryCreditAmount - account.ACDocumentEntryDebitAmount;
                        if (endBalance > 0)
                        {
                            account.EndPeriodCreditBalance = Math.Abs(endBalance);
                        }
                        else if (endBalance < 0)
                        {
                            account.EndPeriodDebitBalance = Math.Abs(endBalance);
                        }
                    }
                }
                else //Tài khoản lưỡng tính
                {
                    //Trong kỳ
                    account.ACDocumentEntryDebitAmount += objDocumentEntrysController.GetAccountDebitAmountBySomeCriteria(account.ACAccountNo, null, null, null, null, fromDate, toDate, branchNos);
                    account.ACDocumentEntryCreditAmount += objDocumentEntrysController.GetAccountCreditAmountBySomeCriteria(account.ACAccountNo, null, null, null, null, fromDate, toDate, branchNos);

                    //Đầu kỳ & Cuối kỳ
                    //ACObjectsController objObjectsController = new ACObjectsController();
                    //List<ACObjectsInfo> initObjectList = objObjectsController.GetDistinctOjbectListInAccountDetail(account.ACAccountNo);

                    //List<ACObjectsInfo> startObjectList = objObjectsController.GetDistinctOjbectListInDocumentEntry(account.ACAccountNo, null, fromDate.AddDays(-1), branchNos);
                    //List<ACObjectsInfo> inPeriodObjectList = objObjectsController.GetDistinctOjbectListInDocumentEntry(account.ACAccountNo, fromDate, toDate, branchNos);

                    //var allObjectList = inPeriodObjectList.Union(startObjectList.Union(initObjectList)).Distinct();
                    List<ACObjectsInfo> allObjectList = new List<ACObjectsInfo>();
                    //var itemList = inPeriodObjectList.Where(item => !allObjectList.Any(item1 => item1.ACObjectID == item.ACObjectID
                    //                                                    && item1.ACObjectType == item.ACObjectType)).ToList();
                    //allObjectList.AddRange(itemList);
                    //itemList = startObjectList.Where(item => !allObjectList.Any(item1 => item1.ACObjectID == item.ACObjectID
                    //                                                    && item1.ACObjectType == item.ACObjectType)).ToList();
                    //allObjectList.AddRange(itemList);
                    //itemList = initObjectList.Where(item => !allObjectList.Any(item1 => item1.ACObjectID == item.ACObjectID
                    //                                                    && item1.ACObjectType == item.ACObjectType)).ToList();
                    //allObjectList.AddRange(itemList);

                    allObjectList = GetObjectList(account);
                    foreach (var aObject in allObjectList)
                    {
                        decimal initBalance = 0;
                        decimal startBalanceDebit = 0;
                        decimal startBalanceCredit = 0;
                        decimal startBalance = 0;
                        decimal inPeriodBalanceDebit = 0;
                        decimal inPeriodBalanceCredit = 0;
                        decimal endBalance = 0;
                        decimal endBalanceDebit = 0;
                        decimal endBalanceCredit = 0;

                        //Đầu kỳ
                        ACAccountsInfo initAccount = new ACAccountsInfo();

                        initAccount = objAccountsController.GetAccountInitialBalanceByObjectID(account.ACAccountNo, aObject.ACObjectID, aObject.ACObjectType, null, null, branchNos);
                        if (initAccount != null)
                        {
                            initBalance = initAccount.ACAccountInitialBalance;
                        }

                        //Phát sinh đầu kỳ
                        startBalanceDebit = objDocumentEntrysController.GetAccountDebitAmountByObjectID(account.ACAccountNo, aObject.ACObjectID, aObject.ACObjectType, null, null, null, fromDate.AddDays(-1), branchNos);
                        startBalanceCredit = objDocumentEntrysController.GetAccountCreditAmountByObjectID(account.ACAccountNo, aObject.ACObjectID, aObject.ACObjectType, null, null, null, fromDate.AddDays(-1), branchNos);

                        startBalance = initBalance + startBalanceDebit - startBalanceCredit;

                        if (startBalance > 0)
                        {
                            startBalanceDebit = startBalance;
                            startBalanceCredit = 0;
                        }
                        else
                        {
                            startBalanceDebit = 0;
                            startBalanceCredit = Math.Abs(startBalance);
                        }

                        account.StartPeriodDebitBalance = account.StartPeriodDebitBalance + startBalanceDebit;
                        account.StartPeriodCreditBalance = account.StartPeriodCreditBalance + startBalanceCredit;

                        //Trong kỳ
                        inPeriodBalanceDebit = objDocumentEntrysController.GetAccountDebitAmountByObjectID(account.ACAccountNo, aObject.ACObjectID, aObject.ACObjectType, null, null, fromDate, toDate, branchNos);
                        inPeriodBalanceCredit = objDocumentEntrysController.GetAccountCreditAmountByObjectID(account.ACAccountNo, aObject.ACObjectID, aObject.ACObjectType, null, null, fromDate, toDate, branchNos);


                        endBalance = startBalanceDebit - startBalanceCredit + inPeriodBalanceDebit - inPeriodBalanceCredit;

                        if (endBalance > 0)
                        {
                            endBalanceDebit = endBalance;
                            endBalanceCredit = 0;
                        }
                        else
                        {
                            endBalanceDebit = 0;
                            endBalanceCredit = Math.Abs(endBalance);
                        }
                        account.EndPeriodDebitBalance = account.EndPeriodDebitBalance + endBalanceDebit;
                        account.EndPeriodCreditBalance = account.EndPeriodCreditBalance + endBalanceCredit;

                        // Xuất ra data theo từng đối tượng
                        //obj1 = new ACAccountsInfo();
                        //obj1.ACAccountNo = aObject.ACObjectNo;
                        //obj1.ACAccountName = aObject.ACObjectName;
                        //if (startBalance > 0)
                        //{
                        //    obj1.StartPeriodDebitBalance = Math.Abs(startBalance);
                        //}
                        //else if (startBalance < 0)
                        //{
                        //    obj1.StartPeriodCreditBalance = Math.Abs(startBalance);
                        //}
                        //obj1.ACDocumentEntryDebitAmount = inPeriodBalanceDebit;
                        //obj1.ACDocumentEntryCreditAmount = inPeriodBalanceCredit;
                        //if (endBalance > 0)
                        //{
                        //    obj1.EndPeriodDebitBalance = Math.Abs(endBalance);
                        //}
                        //else
                        //{
                        //    obj1.EndPeriodCreditBalance = Math.Abs(endBalance);
                        //}
                        //objDetail.Add(obj1);
                    }
                }
                //objDetail.Add(account);

                if (account.StartPeriodDebitBalance == 1) account.StartPeriodDebitBalance = 0;
                if (account.StartPeriodCreditBalance == 1) account.StartPeriodCreditBalance = 0;
                if (account.EndPeriodDebitBalance == 1) account.EndPeriodDebitBalance = 0;
                if (account.EndPeriodCreditBalance == 1) account.EndPeriodCreditBalance = 0;
                if (account.ACDocumentEntryDebitAmount == 1) account.ACDocumentEntryDebitAmount = 0;
                if (account.ACDocumentEntryCreditAmount == 1) account.ACDocumentEntryCreditAmount = 0;

                if (fld_chkIncludeZeroAmount.Checked == false)
                {
                    if (account.StartPeriodDebitBalance != 0
                        || account.StartPeriodCreditBalance != 0
                        || account.EndPeriodDebitBalance != 0
                        || account.EndPeriodCreditBalance != 0
                        || account.ACDocumentEntryDebitAmount != 0
                        || account.ACDocumentEntryCreditAmount != 0)
                    {
                        result.Add(account);
                    }
                }
                else
                {
                    result.Add(account);
                }
                //DDCan [ADD] [11/04/2016] [Đối với Tài khoản lưỡng tính thì Số đầu kỳ và số cuối kỳ sum theo từng đối tượng], END
            }

            List<ACAccountsInfo> check = new List<ACAccountsInfo>();
            foreach (ACAccountsInfo account in result)
            {
                if (account.ACAccountType == AccountType.DebitCreditBalance.ToString())
                {
                    check = result.Where(p => p.ACAccountParentID == account.ACAccountID).ToList();
                    if (check.Count > 0)
                    {
                        account.EndPeriodDebitBalance = 0;
                        account.EndPeriodCreditBalance = 0;
                        account.StartPeriodDebitBalance = 0;
                        account.StartPeriodCreditBalance = 0;
                        GetSumAccountChild(check, account);
                    }
                }
            }
            return result;
            //return objDetail;
        }

        private ACAccountsInfo GetSumAccountChild(List<ACAccountsInfo> result, ACAccountsInfo objParent)
        {
            List<ACAccountsInfo> check = new List<ACAccountsInfo>();

            foreach (ACAccountsInfo account in result)
            {
                check = result.Where(p => p.ACAccountParentID == account.ACAccountID).ToList();
                if (check.Count > 0)
                {
                    GetSumAccountChild(check, objParent);
                }
                else
                {
                    objParent.EndPeriodDebitBalance += account.EndPeriodDebitBalance;
                    objParent.EndPeriodCreditBalance += account.EndPeriodCreditBalance;
                    objParent.StartPeriodDebitBalance += account.StartPeriodDebitBalance;
                    objParent.StartPeriodCreditBalance += account.StartPeriodCreditBalance;
                }
            }
            return objParent;
        }

        private void RP054_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSApp.GetPeriodStartDate(DateTime.Now);
            fld_dteSearchToDate.EditValue = BOSApp.GetPeriodEndDate(DateTime.Now);

            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo branch = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (branch != null)
            {
                fld_lkeGELocationID.EditValue = branch.FK_GELocationID;
            }
        }

        private List<ACObjectsInfo> GetObjectList(ACAccountsInfo accountCheck)
        {
            ACObjectsController objObjectsController = new ACObjectsController();
            List<ACObjectsInfo> objects = new List<ACObjectsInfo>();
            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;
            int locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            bool hasOwing = false;
            ACAccountsController objAccountsController = new ACAccountsController();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            SortedList<string, List<ACDocumentEntrysInfo>> owingEntries = new SortedList<string, List<ACDocumentEntrysInfo>>();
            //ACAccountsInfo accountCheck = (ACAccountsInfo)objAccountsController.GetObjectByNo(accountNo);
            List<ACAccountsInfo> subAccounts = objAccountsController.GetSubAccountsByAccountNo(accountCheck.ACAccountNo);
            List<ACAccountsInfo> selectedAccounts = new List<ACAccountsInfo>();
            selectedAccounts.Add(accountCheck);
            foreach (ACAccountsInfo subAccount in subAccounts)
            {
                if (!selectedAccounts.Exists(a => a.ACAccountID == subAccount.ACAccountID))
                {
                    selectedAccounts.Add(subAccount);
                }
            }
            foreach (ACAccountsInfo account in selectedAccounts)
            {
                List<ACObjectsInfo> owingObjects = objObjectsController.GetOwingObjects(account.ACAccountNo, fromDate, toDate, null, locationID, branchID, hasOwing);
                List<ACDocumentEntrysInfo> result = objDocumentEntrysController.GetEntriesByAccountID(
                                                                               account.ACAccountID,
                                                                               null,
                                                                               null,
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

            return objects;
        }
    }
}
