using BOSCommon;
using BOSCommon.Constants;
using BOSERP.Utilities;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.Report
{
    public partial class RP151 : ReportForm
    {
        /// <summary>
        /// A variable to store the list of all accounts
        /// </summary>
        private List<ACAccountsInfo> AccountList;

        public RP151()
        {
            InitializeComponent();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP151 report = new BOSReport.RP151();
            //report.LoadLayout(BOSCommon.Constants.Report.DevRP053Path);
            InitDataSourceReport(report);
            XtraReportHelper.SetFormatField(report);
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRP053Path, true);
            reviewer.Show();
        }

        private List<ACObjectsInfo> GetObjectList(ACAccountsInfo accountCheck)
        {
            ACObjectsController objObjectsController = new ACObjectsController();
            List<ACObjectsInfo> objects = new List<ACObjectsInfo>();
            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;
            int locationID = 0;
            int branchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
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
        private List<ACAccountsInfo> GetReportData()
        {
            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;
            int locationID = 0;
            int branchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
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
                //if (!account.ACAccountNo.StartsWith("131") 
                //    && !account.ACAccountNo.StartsWith("138") 
                //    && !account.ACAccountNo.StartsWith("141"))
                //{
                //    continue;
                //}

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

                        //// Đầu kỳ
                        //startBalance += objDocumentEntrysController.GetAccountBalanceByCompleteDocument(
                        //                                                        account.ACAccountNo,
                        //                                                        fromDate.AddDays(-1),
                        //                                                        aObject.ACObjectID,
                        //                                                        aObject.ACObjectType,
                        //                                                        null,
                        //                                                        null,
                        //                                                        null,
                        //                                                        branchID);
                        //if (startBalance > 0)
                        //{
                        //    account.StartPeriodCreditBalance += Math.Abs(startBalance);
                        //}
                        //else if (startBalance < 0)
                        //{
                        //    account.StartPeriodDebitBalance += Math.Abs(startBalance);
                        //}

                        //// Trong kỳ
                        //inPeriodBalanceDebit += objDocumentEntrysController.GetAccountDebitExchangeAmountByCurrency(
                        //                                                                            account.ACAccountNo,
                        //                                                                            aObject.ACObjectID,
                        //                                                                            aObject.ACObjectType,
                        //                                                                            null,
                        //                                                                            null,
                        //                                                                            null,
                        //                                                                            branchID,
                        //                                                                            fromDate,
                        //                                                                            toDate);
                        //account.ACDocumentEntryDebitAmount += inPeriodBalanceDebit;

                        //inPeriodBalanceCredit += objDocumentEntrysController.GetAccountCreditExchangeAmountByCurrency(
                        //                                                                            account.ACAccountNo,
                        //                                                                            aObject.ACObjectID,
                        //                                                                            aObject.ACObjectType,
                        //                                                                            null,
                        //                                                                            null,
                        //                                                                            null,
                        //                                                                            branchID,
                        //                                                                            fromDate,
                        //                                                                            toDate);
                        //account.ACDocumentEntryCreditAmount += inPeriodBalanceCredit;
                        //// Cuối kỳ
                        //endBalance = Math.Round(startBalance + inPeriodBalanceCredit - inPeriodBalanceDebit, 3);
                        //if (endBalance > 0)
                        //{
                        //    account.EndPeriodCreditBalance += Math.Abs(endBalance);
                        //}
                        //else
                        //{
                        //    account.EndPeriodDebitBalance += Math.Abs(endBalance);
                        //}

                        //obj1 = new ACAccountsInfo();
                        //obj1.ACAccountNo = aObject.ACObjectNo + " - " + account.ACAccountNo;
                        //obj1.ACAccountName = aObject.ACObjectName;
                        //if (startBalance > 0)
                        //{
                        //    obj1.StartPeriodCreditBalance = Math.Abs(startBalance);
                        //}
                        //else if (startBalance < 0)
                        //{
                        //    obj1.StartPeriodDebitBalance = Math.Abs(startBalance);
                        //}
                        //obj1.ACDocumentEntryDebitAmount = inPeriodBalanceDebit;
                        //obj1.ACDocumentEntryCreditAmount = inPeriodBalanceCredit;
                        //if (endBalance > 0)
                        //{
                        //    obj1.EndPeriodCreditBalance = Math.Abs(endBalance);
                        //}
                        //else
                        //{
                        //    obj1.EndPeriodDebitBalance = Math.Abs(endBalance);
                        //}
                        //objDetail.Add(obj1);
                    }
                }
                //objDetail.Add(account);


                result.Add(account);

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
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
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
            XRLabel date = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblDate"];
            if (date != null)
                date.Text = fld_dteSearchToDate.DateTime.Day.ToString("00");
            XRLabel month = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblMonth"];
            if (month != null)
                month.Text = fld_dteSearchToDate.DateTime.Month.ToString("00");
            XRLabel year = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblYear"];
            if (year != null)
                year.Text = fld_dteSearchToDate.DateTime.Year.ToString();

            //ACBalanceSheetsInfo objBalanceSheetsInfo = new ACBalanceSheetsInfo();
            //List<ACBalanceSheetsInfo> balanceSheetList = new List<ACBalanceSheetsInfo>();            
            //SetBalanceSheetValue(objBalanceSheetsInfo);
            //balanceSheetList.Add(objBalanceSheetsInfo);
            //report.DataSource = balanceSheetList;


            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;
            DateTime prevPeriodStartDate = BOSApp.GetPeriodStartDate(fromDate.AddDays(-1));
            DateTime prevPeriodEndDate = BOSApp.GetPeriodEndDate(fromDate.AddDays(-1));

            ACAccountsController objAccountsController = new ACAccountsController();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            AccountList = objAccountsController.GetAllAccountList();

            BRBranchsController branchController = new BRBranchsController();
            BRBranchsInfo branchsInfo = (BRBranchsInfo)branchController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);

            GEAccountingFormulaItemsController objAccountingFormulaItemsController = new GEAccountingFormulaItemsController();
            List<GEAccountingFormulaItemsInfo> ListItem = objAccountingFormulaItemsController.GetObjectForReport("Bảng cân đối kế toán");
            List<GEAccountingFormulaItemsInfo> ListParent = new List<GEAccountingFormulaItemsInfo>();
            List<GEAccountingFormulaItemsInfo> ListView = new List<GEAccountingFormulaItemsInfo>();
            List<GEAccountingFormulaItemsInfo> List = new List<GEAccountingFormulaItemsInfo>();
            if (ListItem != null && ListItem.Count > 0)
            {
                List<ACAccountsInfo> accountList = GetReportData();
                foreach (GEAccountingFormulaItemsInfo objAccountingFormulaItemsInfo in ListItem)
                {
                    if (!string.IsNullOrEmpty(objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccount))
                    {
                        ACAccountsInfo itemAccount = accountList.FirstOrDefault(t => t.ACAccountNo == objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccount);
                        if (itemAccount != null)
                        {
                            if (objAccountingFormulaItemsInfo.GEAccountingFormulaItemSpot == AccountingFormulaItemSpot.AccountingFormulaItemSpotTru.ToString())
                            {
                                if (itemAccount.ACAccountPostingRule == AccountPostingRule.IncreasingByDebit.ToString())
                                {
                                    objAccountingFormulaItemsInfo.StartYearBalance = -(itemAccount.StartPeriodDebitBalance - itemAccount.StartPeriodCreditBalance);
                                    objAccountingFormulaItemsInfo.EndYearBalance = -(itemAccount.EndPeriodDebitBalance - itemAccount.EndPeriodCreditBalance);
                                }
                                else
                                {
                                    objAccountingFormulaItemsInfo.StartYearBalance = -(-itemAccount.StartPeriodDebitBalance + itemAccount.StartPeriodCreditBalance);
                                    objAccountingFormulaItemsInfo.EndYearBalance = -(-itemAccount.EndPeriodDebitBalance + itemAccount.EndPeriodCreditBalance);
                                }
                                //if (objAccountingFormulaItemsInfo.GEAccountingFormulaItemType.ToUpper() == AccountingFormulaItemType.N.ToString())
                                //{
                                //    objAccountingFormulaItemsInfo.StartYearBalance = -GetAccountDebitBalance(new string[] { objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccount.Trim() },
                                //                                                                            prevPeriodEndDate);
                                //    objAccountingFormulaItemsInfo.EndYearBalance = -GetAccountDebitBalance(new string[] { objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccount.Trim() },
                                //                                                                            toDate);

                                //    //objAccountingFormulaItemsInfo.StartYearBalance = -(objDocumentEntrysController.GetAccountDebitAmountBySomeCriteria(objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccount.Trim(), null, null, null, null, null, prevPeriodEndDate, null));
                                //    //objAccountingFormulaItemsInfo.EndYearBalance = -(objDocumentEntrysController.GetAccountDebitAmountBySomeCriteria(objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccount.Trim(), null, null, null, null, null, toDate, null));

                                //}
                                //else if (objAccountingFormulaItemsInfo.GEAccountingFormulaItemType.ToUpper() == AccountingFormulaItemType.C.ToString())
                                //{
                                //    objAccountingFormulaItemsInfo.StartYearBalance = -GetAccountCreditBalance(new string[] { objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccount.Trim() },
                                //                                                                            prevPeriodEndDate);
                                //    objAccountingFormulaItemsInfo.EndYearBalance = -GetAccountCreditBalance(new string[] { objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccount.Trim() },
                                //                                                                            toDate);
                                //    //objAccountingFormulaItemsInfo.StartYearBalance = -(objDocumentEntrysController.GetAccountCreditAmountBySomeCriteria(objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccount.Trim(), null, null, null, null, null, prevPeriodEndDate, null));
                                //    //objAccountingFormulaItemsInfo.EndYearBalance = -(objDocumentEntrysController.GetAccountCreditAmountBySomeCriteria(objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccount.Trim(), null, null, null, null, null, toDate, null));
                                //}
                            }
                            else
                            {
                                if (itemAccount.ACAccountPostingRule == AccountPostingRule.IncreasingByDebit.ToString())
                                {
                                    objAccountingFormulaItemsInfo.StartYearBalance = (itemAccount.StartPeriodDebitBalance - itemAccount.StartPeriodCreditBalance);
                                    objAccountingFormulaItemsInfo.EndYearBalance = (itemAccount.EndPeriodDebitBalance - itemAccount.EndPeriodCreditBalance);
                                }
                                else
                                {
                                    objAccountingFormulaItemsInfo.StartYearBalance = (-itemAccount.StartPeriodDebitBalance + itemAccount.StartPeriodCreditBalance);
                                    objAccountingFormulaItemsInfo.EndYearBalance = (-itemAccount.EndPeriodDebitBalance + itemAccount.EndPeriodCreditBalance);
                                }
                                //if (objAccountingFormulaItemsInfo.GEAccountingFormulaItemType.ToUpper() == AccountingFormulaItemType.N.ToString())
                                //{
                                //    objAccountingFormulaItemsInfo.StartYearBalance = GetAccountDebitBalance(new string[] { objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccount.Trim() },
                                //                                                                            prevPeriodEndDate);
                                //    objAccountingFormulaItemsInfo.EndYearBalance = GetAccountDebitBalance(new string[] { objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccount.Trim() },
                                //                                                                            toDate);
                                //    //objAccountingFormulaItemsInfo.StartYearBalance = objDocumentEntrysController.GetAccountDebitAmountBySomeCriteria(objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccount.Trim(), null, null, null, null, null, prevPeriodEndDate, null);
                                //    //objAccountingFormulaItemsInfo.EndYearBalance = objDocumentEntrysController.GetAccountDebitAmountBySomeCriteria(objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccount.Trim(), null, null, null, null, null, toDate, null);
                                //}
                                //else if (objAccountingFormulaItemsInfo.GEAccountingFormulaItemType.ToUpper() == AccountingFormulaItemType.C.ToString())
                                //{
                                //    objAccountingFormulaItemsInfo.StartYearBalance = GetAccountCreditBalance(new string[] { objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccount.Trim() },
                                //                                                                            prevPeriodEndDate);
                                //    objAccountingFormulaItemsInfo.EndYearBalance = GetAccountCreditBalance(new string[] { objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccount.Trim() },
                                //                                                                            toDate);
                                //    //objAccountingFormulaItemsInfo.StartYearBalance = objDocumentEntrysController.GetAccountCreditAmountBySomeCriteria(objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccount.Trim(), null, null, null, null, null, prevPeriodEndDate, null);
                                //    //objAccountingFormulaItemsInfo.EndYearBalance = objDocumentEntrysController.GetAccountCreditAmountBySomeCriteria(objAccountingFormulaItemsInfo.GEAccountingFormulaItemAccount.Trim(), null, null, null, null, null, toDate, null);
                                //}
                            }
                        }
                        //List.Add(objAccountingFormulaItemsInfo);
                    }
                    //else
                    //{
                    //    ListParent.Add(objAccountingFormulaItemsInfo);
                    //}
                }
                //    foreach (GEAccountingFormulaItemsInfo parent in ListItem)
                //    {
                //        //if (!parent.GEAccountingFormulaItemAccountNo.Equals("110"))
                //        //{
                //        //    continue;
                //        //}
                //        if (!string.IsNullOrEmpty(parent.GEAccountingFormulaItemFormula))
                //        {
                //            string[] AssetNos = parent.GEAccountingFormulaItemFormula.Split('+');
                //            foreach (string item in AssetNos)
                //            {
                //                //List<GEAccountingFormulaItemsInfo> check = ListItem
                //                //GEAccountingFormulaItemsInfo objItems = (GEAccountingFormulaItemsInfo)objAccountingFormulaItemsController.GetItemByAccountNo(item.Trim());
                //                GEAccountingFormulaItemsInfo objItems = ListItem.Where(p => p.GEAccountingFormulaItemAccountNo.Equals(item.Trim())).FirstOrDefault();
                //                if (objItems != null)
                //                {
                //                    if (!string.IsNullOrEmpty(objItems.GEAccountingFormulaItemFormula))
                //                    {
                //                        objItems.StartYearBalance = 0;
                //                        objItems.EndYearBalance = 0;
                //                        string[] Nos = objItems.GEAccountingFormulaItemFormula.Split('+');
                //                        foreach (string no in Nos)
                //                        {
                //                            //GEAccountingFormulaItemsInfo obj = (GEAccountingFormulaItemsInfo)objAccountingFormulaItemsController.GetItemByAccountNo(no.Trim());
                //                            GEAccountingFormulaItemsInfo obj = ListItem.Where(p => p.GEAccountingFormulaItemAccountNo.Equals(no.Trim())).FirstOrDefault();
                //                            if (obj != null)
                //                            {
                //                                if (!string.IsNullOrEmpty(obj.GEAccountingFormulaItemFormula))
                //                                {
                //                                    CalculationBalance(obj, ListItem);
                //                                }
                //                                //else
                //                                //{
                //                                objItems.StartYearBalance += obj.StartYearBalance;
                //                                objItems.EndYearBalance += obj.EndYearBalance;
                //                                //}
                //                            }
                //                        }
                //                    }
                //                    //else
                //                    //{
                //                        parent.StartYearBalance += objItems.StartYearBalance;
                //                        parent.EndYearBalance += objItems.EndYearBalance;
                //                    //}
                //                }
                //            }
                //        }

                //        //List.Add(parent);
                //    }
                //}

                foreach (GEAccountingFormulaItemsInfo parent in ListItem)
                {
                    //if (!parent.GEAccountingFormulaItemAccountNo.Equals("110"))
                    //{
                    //    continue;
                    //}
                    if (!string.IsNullOrEmpty(parent.GEAccountingFormulaItemFormula) && parent.StartYearBalance == 0 && parent.EndYearBalance == 0)
                    {
                        //List = ListItem.Where(p => (parent.GEAccountingFormulaItemFormula.IndexOf(p.GEAccountingFormulaItemAccountNo + "+") >= 0
                        //|| parent.GEAccountingFormulaItemFormula.IndexOf("+" + p.GEAccountingFormulaItemAccountNo) >= 0
                        //)
                        //            && !parent.GEAccountingFormulaItemAccountNo.Equals(p.GEAccountingFormulaItemAccountNo)
                        //                && !p.GEAccountingFormulaItemAccountNo.Equals(String.Empty)).ToList();
                        List = getListByNo(parent.GEAccountingFormulaItemFormula, ListItem);
                        if (List.Count > 0)
                        {
                            parent.StartYearBalance = 0;
                            parent.EndYearBalance = 0;
                            CalculationBalance(parent, List, ListItem);
                        }
                    }
                }
            }

            foreach (GEAccountingFormulaItemsInfo obj in ListItem)
            {
                if (obj.GEAccountingFormulaItemShowPrint == true)
                {
                    ListView.Add(obj);
                }
            }

            ListView = ListView.OrderBy(item => item.GEAccountingFormulaItemNumber).ToList();
            report.DataSource = ListView;

        }


        /// <summary>
        /// Set balance sheet value
        /// </summary>
        /// <param name="objBalanceSheetsInfo">Given balace sheet</param>       
        /// 
        //private GEAccountingFormulaItemsInfo CalculationBalance(GEAccountingFormulaItemsInfo obj, List<GEAccountingFormulaItemsInfo> ListItem)
        //{
        //    GEAccountingFormulaItemsController objAccountingFormulaItemsController = new GEAccountingFormulaItemsController();

        //    if (!string.IsNullOrEmpty(obj.GEAccountingFormulaItemFormula))
        //    {
        //        string[] AssetNos = obj.GEAccountingFormulaItemFormula.Split('+');
        //        foreach (string asset in AssetNos)
        //        {
        //            //GEAccountingFormulaItemsInfo objItems = (GEAccountingFormulaItemsInfo)objAccountingFormulaItemsController.GetItemByAccountNo(asset.Trim());
        //            GEAccountingFormulaItemsInfo objItems = ListItem.Where(p => p.GEAccountingFormulaItemAccountNo.Equals(asset.Trim())).FirstOrDefault();
        //            if (objItems != null)
        //            {
        //                if (!string.IsNullOrEmpty(objItems.GEAccountingFormulaItemFormula))
        //                {
        //                    CalculationBalance(objItems, ListItem);
        //                }
        //                //else
        //                //{
        //                    obj.StartYearBalance += objItems.StartYearBalance;
        //                    obj.EndYearBalance += objItems.EndYearBalance;
        //                //}
        //            }
        //        }
        //    }
        //    return obj;
        //}

        private GEAccountingFormulaItemsInfo CalculationBalance(GEAccountingFormulaItemsInfo obj, List<GEAccountingFormulaItemsInfo> childList, List<GEAccountingFormulaItemsInfo> ListItem)
        {
            List<GEAccountingFormulaItemsInfo> check = new List<GEAccountingFormulaItemsInfo>();
            foreach (GEAccountingFormulaItemsInfo item in childList)
            {
                if (item == null)
                {
                    continue;
                }
                if (!string.IsNullOrEmpty(item.GEAccountingFormulaItemFormula) && item.StartYearBalance == 0 && item.EndYearBalance == 0)
                {
                    //check = ListItem.Where(p => (item.GEAccountingFormulaItemFormula.IndexOf(p.GEAccountingFormulaItemAccountNo+"+") >= 0
                    //    || item.GEAccountingFormulaItemFormula.IndexOf("+"+p.GEAccountingFormulaItemAccountNo) >= 0
                    //    )
                    //                && !item.GEAccountingFormulaItemAccountNo.Equals(p.GEAccountingFormulaItemAccountNo)
                    //                    && !p.GEAccountingFormulaItemAccountNo.Equals(String.Empty)).ToList();
                    check = getListByNo(item.GEAccountingFormulaItemFormula, ListItem);
                    if (check.Count > 0)
                    {
                        CalculationBalance(item, check, ListItem);
                    }
                }
                obj.StartYearBalance += item.StartYearBalance;
                obj.EndYearBalance += item.EndYearBalance;
            }
            return obj;
        }

        private List<GEAccountingFormulaItemsInfo> getListByNo(String formula, List<GEAccountingFormulaItemsInfo> ListItem)
        {
            List<GEAccountingFormulaItemsInfo> check = new List<GEAccountingFormulaItemsInfo>();
            string[] AssetNos = formula.Split('+');
            foreach (string asset in AssetNos)
            {
                GEAccountingFormulaItemsInfo objItems = ListItem.Where(p => p.GEAccountingFormulaItemAccountNo.Equals(asset.Trim())).FirstOrDefault();
                check.Add(objItems);
            }
            return check;
        }

        /// <summary>
        /// Get the total debit balance of accounts to a specific date
        /// </summary>
        /// <param name="accountNumbers">List of account numbers</param>
        /// <param name="date">Specific date</param>        
        /// <returns>Total balance</returns>
        private decimal GetAccountDebitBalance(string[] accountNumbers, DateTime date)
        {
            decimal balance = 0;
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            foreach (string accountNo in accountNumbers)
            {
                balance += objDocumentEntrysController.GetAccountBalance(accountNo, date);
            }

            //string postingRule = string.Empty;
            //ACAccountsInfo account = AccountList.Where(a => a.ACAccountNo == accountNumbers[0]).FirstOrDefault();            
            //if (account != null)
            //{
            //    postingRule = account.ACAccountPostingRule;
            //}

            //if (postingRule == AccountPostingRule.IncreasingByDebit.ToString())
            //{
            //    if (balance <= 0)
            //    {
            //        balance = 0;
            //    }
            //}
            //else if (postingRule == AccountPostingRule.IncreasingByCredit.ToString())
            //{
            //    if (balance >= 0)
            //    {
            //        balance = 0;
            //    }
            //    else
            //    {
            //        balance = Math.Abs(balance);
            //    }
            //}
            return balance;
        }

        /// <summary>
        /// Get the total credit balance of accounts to a specific date
        /// </summary>
        /// <param name="accountNumbers">List of account numbers</param>
        /// <param name="date">Specific date</param>        
        /// <returns>Total balance</returns>
        private decimal GetAccountCreditBalance(string[] accountNumbers, DateTime date)
        {
            decimal balance = 0;
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            ACAccountsController accountsController = new ACAccountsController();
            ACAccountsInfo accountsInfo;
            foreach (string accountNo in accountNumbers)
            {
                accountsInfo = (ACAccountsInfo)accountsController.GetObjectByNo(accountNo);
                if (accountsInfo != null)
                {

                    balance += objDocumentEntrysController.GetAccountBalance(accountNo, date);
                }
            }

            //string postingRule = string.Empty;
            //ACAccountsInfo account = AccountList.Where(a => a.ACAccountNo == accountNumbers[0]).FirstOrDefault();
            //if (account != null)
            //{
            //    postingRule = account.ACAccountPostingRule;
            //}

            //if (postingRule == AccountPostingRule.IncreasingByDebit.ToString())
            //{
            //    if (balance >= 0)
            //    {
            //        balance = 0;
            //    }
            //    else
            //    {
            //        balance = Math.Abs(balance);
            //    }                
            //}
            //else if (postingRule == AccountPostingRule.IncreasingByCredit.ToString())
            //{
            //    if (balance <= 0)
            //    {
            //        balance = 0;
            //    }
            //}
            return balance;
        }

        /// <summary>
        /// Get the debit balance of an account detailed to objects
        /// </summary>
        /// <param name="accountNo">Account no</param>        
        /// <param name="fromDate">Date the result is calculated from</param>
        /// <param name="toDate">Date the result is calculated to</param>
        /// <returns>Debit balance</returns>
        public decimal GetObjectDebitBalance(string accountNo, DateTime fromDate, DateTime toDate)
        {
            ACAccountsController objAccountsController = new ACAccountsController();
            ACAccountsInfo account = (ACAccountsInfo)objAccountsController.GetObjectByNo(accountNo);
            ACDocumentEntrysController documentEntryController = new ACDocumentEntrysController();
            decimal balance = 0;
            if (account != null)
            {
                ACObjectsController objObjectsController = new ACObjectsController();
                List<ACObjectsInfo> owingObjects = objObjectsController.GetOwingObjectsBySomeCriteria(accountNo, fromDate, toDate, null, null, null, null, true);
                foreach (ACObjectsInfo obj in owingObjects)
                {
                    if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByDebit.ToString())
                    {
                        if (obj.InitBalance + obj.AccountDebitAmount - obj.AccountCreditAmount > 0)
                        {
                            balance += obj.InitBalance + obj.AccountDebitAmount - obj.AccountCreditAmount;
                        }
                    }
                    else if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByCredit.ToString())
                    {
                        if (obj.InitBalance + obj.AccountCreditAmount - obj.AccountDebitAmount < 0)
                        {
                            balance += Math.Abs(obj.InitBalance + obj.AccountCreditAmount - obj.AccountDebitAmount);
                        }
                    }
                }
            }
            return balance;
        }

        /// <summary>
        /// Get the credit balance of an account detailed to objects
        /// </summary>
        /// <param name="accountNo">Account no</param>
        /// <param name="fromDate">Date the result is calculated from</param>
        /// <param name="toDate">Date the result is calculated to</param>
        /// <returns>Debit balance</returns>
        public decimal GetObjectCreditBalance(string accountNo, DateTime fromDate, DateTime toDate)
        {
            ACAccountsController objAccountsController = new ACAccountsController();
            ACAccountsInfo account = (ACAccountsInfo)objAccountsController.GetObjectByNo(accountNo);
            decimal balance = 0;
            if (account != null)
            {
                ACDocumentEntrysController documentEntryController = new ACDocumentEntrysController();

                ACObjectsController objObjectsController = new ACObjectsController();
                List<ACObjectsInfo> owingObjects = objObjectsController.GetOwingObjectsBySomeCriteria(accountNo, fromDate, toDate, null, null, null, null, true);
                foreach (ACObjectsInfo obj in owingObjects)
                {
                    if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByDebit.ToString())
                    {
                        if (obj.InitBalance + obj.AccountDebitAmount - obj.AccountCreditAmount < 0)
                        {
                            balance += Math.Abs(obj.InitBalance + obj.AccountDebitAmount - obj.AccountCreditAmount);
                        }
                    }
                    else if (account.ACAccountPostingRule == AccountPostingRule.IncreasingByCredit.ToString())
                    {
                        if (obj.InitBalance + obj.AccountCreditAmount - obj.AccountDebitAmount > 0)
                        {
                            balance += obj.InitBalance + obj.AccountCreditAmount - obj.AccountDebitAmount;
                        }
                    }
                }
            }
            return balance;
        }

        private void RP053_Load(object sender, EventArgs e)
        {
            fld_dteSearchFromDate.EditValue = BOSApp.GetPeriodStartDate(DateTime.Now);
            fld_dteSearchToDate.EditValue = BOSApp.GetPeriodEndDate(DateTime.Now);
        }
    }
}
