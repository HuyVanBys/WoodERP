using System;
using System.Data;
using System.Threading;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;
using System.Linq;
using BOSLib;
using Localization;

namespace BOSERP.Modules.InvoiceInTransaction
{
    public class InvoiceInTransactionModule : BaseModuleERP
    {
        #region Private properties
        private Workbook WorkBook;

        private Worksheet WorkSheet;

        private Microsoft.Office.Interop.Excel.Application App;
        #endregion

        public InvoiceInTransactionModule()
        {
            Name = "InvoiceInTransaction";
            CurrentModuleEntity = new InvoiceInTransactionEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        public void SaveItem()
        {
            InvoiceInTransactionEntities entity = (InvoiceInTransactionEntities)CurrentModuleEntity;
            if (entity.InvoiceInTransactionList.CurrentIndex < 0)
                return;

            APInvoiceInTransactionsInfo validateObject = entity.InvoiceInTransactionList.FirstOrDefault(o => o.FK_ACObjectID <= 0);
            if (validateObject != null)
            {
                MessageBox.Show("Vui lòng chọn Đối tượng cho tất cả các chứng từ!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            validateObject = entity.InvoiceInTransactionList.FirstOrDefault(o => o.FK_GECurrencyID <= 0);
            if (validateObject != null)
            {
                MessageBox.Show("Vui lòng chọn Loại tiền tệ cho tất cả các chứng từ!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            validateObject = entity.InvoiceInTransactionList.FirstOrDefault(o => o.FK_ACAccountID <= 0);
            if (validateObject != null)
            {
                MessageBox.Show("Vui lòng chọn Tài khoản công nợ cho tất cả các chứng từ!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            entity.InvoiceInTransactionList.SaveItemObjects();
            MessageBox.Show(CommonLocalizedResources.SaveSuccessful, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeleteItem()
        {
            InvoiceInTransactionEntities entity = (InvoiceInTransactionEntities)CurrentModuleEntity;
            if (entity.InvoiceInTransactionList.CurrentIndex < 0)
                return;
            APInvoiceInTransactionsInfo objInvoiceInTransactionsInfo = entity.InvoiceInTransactionList[entity.InvoiceInTransactionList.CurrentIndex];
            APInvoiceInTransactionsController controller = new APInvoiceInTransactionsController();
            controller.DeleteObject(objInvoiceInTransactionsInfo.APInvoiceInTransactionID);
            entity.InvoiceInTransactionList.RemoveSelectedRowObjectFromList();
        }

        public void ChangedItem()
        {
            InvoiceInTransactionEntities entity = (InvoiceInTransactionEntities)CurrentModuleEntity;
            if (entity.InvoiceInTransactionList.CurrentIndex < 0)
                return;
            APInvoiceInTransactionsInfo objInvoiceInTransactionsInfo = entity.InvoiceInTransactionList[entity.InvoiceInTransactionList.CurrentIndex];
            UpdateAmount(objInvoiceInTransactionsInfo);
        }

        private void UpdateAmount(APInvoiceInTransactionsInfo item)
        {
            item.APInvoiceInAmountExchange = item.APInvoiceInAmount * item.APInvoiceInTransactionExchangeRate;
            item.APPurchaseOrderPaymentAmountExchange = item.APPurchaseOrderPaymentAmount * item.APInvoiceInTransactionExchangeRate;
            item.APInvoiceInPaymentAmountExchange = item.APInvoiceInPaymentAmount * item.APInvoiceInTransactionExchangeRate;
        }

        #region Import bằng excel
        public void ImportInvoiceInTransaction()
        {
            List<Range> ranges = InitializeDataImport();
            if (ranges == null)
                return;

            BOSProgressBar.Start(ImportDataLocalizedResources.ProgressBarMessage);

            Range range = ranges[0];

            ImportInvoiceInTransactionFromExcel(range);

            BOSProgressBar.Close();
        }

        public List<Range> InitializeDataImport()
        {
            string filePath = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = ImportDataLocalizedResources.DialogFilter;
            if (dialog.ShowDialog() != DialogResult.Cancel)
            {
                filePath = dialog.FileName;
            }

            if (!String.IsNullOrEmpty(filePath))
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");

                App = new ApplicationClass();
                WorkBook = App.Workbooks.Open(filePath, 0, true, 5, string.Empty, string.Empty, true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                List<Range> result = new List<Range>();
                for (int i = 1; i <= WorkBook.Worksheets.Count; i++)
                {
                    WorkSheet = (Worksheet)WorkBook.Worksheets.get_Item(i);
                    Range range = WorkSheet.UsedRange;
                    result.Add(range);
                }
                return result;
            }
            return null;
        }

        private void ImportInvoiceInTransactionFromExcel(Range range)
        {
            if (range == null)
                return;

            InvoiceInTransactionEntities entity = (InvoiceInTransactionEntities)CurrentModuleEntity;
            List<APInvoiceInTransactionsInfo> importInfoList = new List<APInvoiceInTransactionsInfo>();
            APInvoiceInTransactionsInfo objInvoiceInTransactionsInfo = new APInvoiceInTransactionsInfo();
            string cellValue = string.Empty;
            decimal value = 0;
            ACObjectsInfo objectsInfo;
            GECurrenciesInfo currenciesInfo;
            ACAccountsInfo accountsInfo;
            ACAccountsController accountsController = new ACAccountsController();

            List<GECurrenciesInfo> listCurrenciesInfo = (new GECurrenciesController()).GetAllCurrencys();

            DataSet ds = accountsController.GetListAccountNotChild();
            List<ACAccountsInfo> listAccounts = (List<ACAccountsInfo>)accountsController.GetListFromDataSet(ds);

            for (int row = 2; row <= range.Rows.Count; row++)
            {
                objInvoiceInTransactionsInfo = new APInvoiceInTransactionsInfo();
                objInvoiceInTransactionsInfo.APObjectNo = (range.Cells[row, 2] as Range).Text.ToString().Trim();
                objInvoiceInTransactionsInfo.APObjectName = (range.Cells[row, 3] as Range).Text.ToString().Trim();

                if (string.IsNullOrWhiteSpace(objInvoiceInTransactionsInfo.APObjectName) && string.IsNullOrWhiteSpace(objInvoiceInTransactionsInfo.APObjectNo))
                {
                    continue;
                }

                objectsInfo = BOSApp.AccountingObjects.FirstOrDefault(o => o.ACObjectName == objInvoiceInTransactionsInfo.APObjectName);
                if (objectsInfo == null)
                {
                    objectsInfo = BOSApp.AccountingObjects.FirstOrDefault(o => o.ACObjectNo == objInvoiceInTransactionsInfo.APObjectNo);
                }

                if (objectsInfo != null)
                {
                    objInvoiceInTransactionsInfo.FK_ACObjectID = objectsInfo.ACObjectID;
                    objInvoiceInTransactionsInfo.ARObjectType = objectsInfo.ACObjectType;
                    objInvoiceInTransactionsInfo.ACObjectAccessKey = objectsInfo.ACObjectID + ";" + objectsInfo.ACObjectType;
                }
                else
                {
                    objInvoiceInTransactionsInfo.Selected = true;
                }

                cellValue = (range.Cells[row, 4] as Range).Text.ToString().Trim();
                accountsInfo = listAccounts.FirstOrDefault(o => o.ACAccountNo == cellValue);
                if (accountsInfo != null)
                {
                    objInvoiceInTransactionsInfo.FK_ACAccountID = accountsInfo.ACAccountID;
                }

                objInvoiceInTransactionsInfo.APInvoiceInNo = (range.Cells[row, 5] as Range).Text.ToString().Trim();
                objInvoiceInTransactionsInfo.APInvoiceInVatNo = (range.Cells[row, 6] as Range).Text.ToString().Trim();
                objInvoiceInTransactionsInfo.APInvoiceInSymbol = (range.Cells[row, 7] as Range).Text.ToString().Trim();
                objInvoiceInTransactionsInfo.APInvoiceInTransactionDesc = (range.Cells[row, 8] as Range).Text.ToString().Trim();

                cellValue = (range.Cells[row, 9] as Range).Text.ToString().Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objInvoiceInTransactionsInfo.APInvoiceInDate = Convert.ToDateTime(cellValue);
                    }
                    catch (Exception ex)
                    {
                        objInvoiceInTransactionsInfo.Selected = true;
                    }
                }

                cellValue = (range.Cells[row, 10] as Range).Text.ToString().Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objInvoiceInTransactionsInfo.APInvoiceInTransactionEndDate = Convert.ToDateTime(cellValue);
                    }
                    catch (Exception ex)
                    {
                        objInvoiceInTransactionsInfo.Selected = true;
                    }
                }

                cellValue = (range.Cells[row, 11] as Range).Text.ToString().Trim();
                currenciesInfo = listCurrenciesInfo.FirstOrDefault(o => o.GECurrencyName == cellValue || o.GECurrencyNo == cellValue);
                if (currenciesInfo != null)
                {
                    objInvoiceInTransactionsInfo.FK_GECurrencyID = currenciesInfo.GECurrencyID;
                }

                cellValue = (range.Cells[row, 12] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                try
                {
                    objInvoiceInTransactionsInfo.APInvoiceInTransactionExchangeRate = Convert.ToDecimal(cellValue);
                }
                catch (Exception ex)
                {
                    objInvoiceInTransactionsInfo.APInvoiceInTransactionExchangeRate = 1;
                }

                cellValue = (range.Cells[row, 13] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                try
                {
                    objInvoiceInTransactionsInfo.APInvoiceInAmount = Convert.ToDecimal(cellValue);
                }
                catch (Exception ex)
                {
                    objInvoiceInTransactionsInfo.APInvoiceInAmount = 0;
                }

                cellValue = (range.Cells[row, 14] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                try
                {
                    objInvoiceInTransactionsInfo.APInvoiceInAmountExchange = Convert.ToDecimal(cellValue);
                }
                catch (Exception ex)
                {
                    objInvoiceInTransactionsInfo.APInvoiceInAmountExchange = 0;
                }

                cellValue = (range.Cells[row, 15] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                try
                {
                    objInvoiceInTransactionsInfo.APInvoiceInPaymentAmount = Convert.ToDecimal(cellValue);
                }
                catch (Exception ex)
                {
                    objInvoiceInTransactionsInfo.APInvoiceInPaymentAmount = 0;
                }

                cellValue = (range.Cells[row, 16] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                try
                {
                    objInvoiceInTransactionsInfo.APInvoiceInPaymentAmountExchange = Convert.ToDecimal(cellValue);
                }
                catch (Exception ex)
                {
                    objInvoiceInTransactionsInfo.APInvoiceInPaymentAmountExchange = 0;
                }

                if(string.IsNullOrWhiteSpace(objInvoiceInTransactionsInfo.APInvoiceInNo))
                {
                    objInvoiceInTransactionsInfo.APInvoiceInNo = "HDMDK-" + objInvoiceInTransactionsInfo.APObjectNo + objInvoiceInTransactionsInfo.APInvoiceInVatNo;
                }
                if (string.IsNullOrWhiteSpace(objInvoiceInTransactionsInfo.APInvoiceInTransactionReferenceNo))
                {
                    objInvoiceInTransactionsInfo.APInvoiceInTransactionReferenceNo = objInvoiceInTransactionsInfo.APInvoiceInNo;
                }

                objInvoiceInTransactionsInfo.FK_BRBRanchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                objInvoiceInTransactionsInfo.APInvoiceInTransactionReferenceDate = BOSApp.CurrentCompanyInfo.CSCompanyStartDate.AddDays(-1);
                objInvoiceInTransactionsInfo.AACreatedUser = BOSApp.CurrentUsersInfo.ADUserName;
                objInvoiceInTransactionsInfo.APInvoiceInTransactionModuleName = this.Name;
                objInvoiceInTransactionsInfo.APInvoiceInTransactionType = "InvoiceIn";
                objInvoiceInTransactionsInfo.APInvoiceInTransactionOrigin = "Balance";
                objInvoiceInTransactionsInfo.APInvoiceInTransactionStatus = "New";
                objInvoiceInTransactionsInfo.APInvoiceInTransactionPaymentType = "Final Payment";

                importInfoList.Add(objInvoiceInTransactionsInfo);
            }
            entity.InvoiceInTransactionList.AddRange(importInfoList);
            entity.InvoiceInTransactionList.GridControl.RefreshDataSource();
        }
        #endregion
    }
}
