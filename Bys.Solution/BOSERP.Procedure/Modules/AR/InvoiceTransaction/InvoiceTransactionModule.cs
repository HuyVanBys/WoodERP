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

namespace BOSERP.Modules.InvoiceTransaction
{
    public class InvoiceTransactionModule : BaseModuleERP
    {
        #region Private properties
        private Workbook WorkBook;

        private Worksheet WorkSheet;

        private Microsoft.Office.Interop.Excel.Application App;
        #endregion

        public InvoiceTransactionModule()
        {
            Name = "InvoiceTransaction";
            CurrentModuleEntity = new InvoiceTransactionEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        public void SaveItem()
        {
            InvoiceTransactionEntities entity = (InvoiceTransactionEntities)CurrentModuleEntity;
            if (entity.InvoiceTransactionList.Count < 0)
                return;

            ARInvoiceTransactionsInfo validateObject = entity.InvoiceTransactionList.FirstOrDefault(o => o.FK_ACObjectID <= 0);
            if(validateObject != null)
            {
                MessageBox.Show("Vui lòng chọn Đối tượng cho tất cả các chứng từ!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            validateObject = entity.InvoiceTransactionList.FirstOrDefault(o => o.FK_GECurrencyID <= 0);
            if (validateObject != null)
            {
                MessageBox.Show("Vui lòng chọn Loại tiền tệ cho tất cả các chứng từ!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            validateObject = entity.InvoiceTransactionList.FirstOrDefault(o => o.FK_ACAccountID <= 0);
            if (validateObject != null)
            {
                MessageBox.Show("Vui lòng chọn Tài khoản công nợ cho tất cả các chứng từ!"
                                , CommonLocalizedResources.MessageBoxDefaultCaption
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            entity.InvoiceTransactionList.ForEach(o =>
            {
                o.FK_BRBRanchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                o.ARInvoiceTransactionReferenceDate = BOSApp.CurrentCompanyInfo.CSCompanyStartDate.AddDays(-1);
                o.AACreatedUser = BOSApp.CurrentUsersInfo.ADUserName;
                o.ARInvoiceTransactionModuleName = this.Name;
                o.ARInvoiceTransactionType = "Invoice";
                o.ARInvoiceTransactionOrigin = "Balance";
                o.ARInvoiceTransactionStatus = "New";
                o.ARInvoiceTransactionPaymentType = "Final Payment";
            });
            entity.InvoiceTransactionList.SaveItemObjects();
            MessageBox.Show(CommonLocalizedResources.SaveSuccessful, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeleteItem()
        {
            InvoiceTransactionEntities entity = (InvoiceTransactionEntities)CurrentModuleEntity;
            if (entity.InvoiceTransactionList.CurrentIndex < 0)
                return;
            ARInvoiceTransactionsInfo objInvoiceTransactionsInfo = entity.InvoiceTransactionList[entity.InvoiceTransactionList.CurrentIndex];
            ARInvoiceTransactionsController controller = new ARInvoiceTransactionsController();
            controller.DeleteObject(objInvoiceTransactionsInfo.ARInvoiceTransactionID);

            entity.InvoiceTransactionList.RemoveSelectedRowObjectFromList();
        }

        public void ChangedItem()
        {
            InvoiceTransactionEntities entity = (InvoiceTransactionEntities)CurrentModuleEntity;
            if (entity.InvoiceTransactionList.CurrentIndex < 0)
                return;
            ARInvoiceTransactionsInfo objInvoiceTransactionsInfo = entity.InvoiceTransactionList[entity.InvoiceTransactionList.CurrentIndex];
            UpdateAmount(objInvoiceTransactionsInfo);
        }

        private void UpdateAmount(ARInvoiceTransactionsInfo item)
        {
            item.ARInvoiceAmountExchange = item.ARInvoiceAmount * item.ARInvoiceTransactionExchangeRate;
            item.ARSaleOrderPaymentAmountExchange = item.ARSaleOrderPaymentAmount * item.ARInvoiceTransactionExchangeRate;
            item.ARInvoicePaymentAmountExchange = item.ARInvoicePaymentAmount * item.ARInvoiceTransactionExchangeRate;
        }

        #region Import bằng excel
        public void ImportInvoiceTransaction()
        {
            List<Range> ranges = InitializeDataImport();
            if (ranges == null)
                return;

            BOSProgressBar.Start(ImportDataLocalizedResources.ProgressBarMessage);

            Range range = ranges[0];

            ImportInvoiceTransactionFromExcel(range);

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

        private void ImportInvoiceTransactionFromExcel(Range range)
        {
            if (range == null)
                return;

            InvoiceTransactionEntities entity = (InvoiceTransactionEntities)CurrentModuleEntity;
            List<ARInvoiceTransactionsInfo> importInfoList = new List<ARInvoiceTransactionsInfo>();
            ARInvoiceTransactionsInfo objInvoiceTransactionsInfo = new ARInvoiceTransactionsInfo();
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
                objInvoiceTransactionsInfo = new ARInvoiceTransactionsInfo();
                objInvoiceTransactionsInfo.ARObjectNo = (range.Cells[row, 2] as Range).Text.ToString().Trim();
                objInvoiceTransactionsInfo.ARObjectName = (range.Cells[row, 3] as Range).Text.ToString().Trim();

                if (string.IsNullOrWhiteSpace(objInvoiceTransactionsInfo.ARObjectName) && string.IsNullOrWhiteSpace(objInvoiceTransactionsInfo.ARObjectNo))
                {
                    continue;
                }

                objectsInfo = BOSApp.AccountingObjects.FirstOrDefault(o => o.ACObjectName == objInvoiceTransactionsInfo.ARObjectName);
                if (objectsInfo == null)
                {
                    objectsInfo = BOSApp.AccountingObjects.FirstOrDefault(o => o.ACObjectNo == objInvoiceTransactionsInfo.ARObjectNo);
                }
                
                if (objectsInfo != null)
                {
                    objInvoiceTransactionsInfo.FK_ACObjectID = objectsInfo.ACObjectID;
                    objInvoiceTransactionsInfo.ARObjectType = objectsInfo.ACObjectType;
                    objInvoiceTransactionsInfo.ACObjectAccessKey = objectsInfo.ACObjectID + ";" + objectsInfo.ACObjectType;
                }  
                else
                {
                    objInvoiceTransactionsInfo.Selected = true;
                }

                cellValue = (range.Cells[row, 4] as Range).Text.ToString().Trim();
                accountsInfo = listAccounts.FirstOrDefault(o => o.ACAccountNo == cellValue);
                if(accountsInfo != null)
                {
                    objInvoiceTransactionsInfo.FK_ACAccountID = accountsInfo.ACAccountID;
                }    

                objInvoiceTransactionsInfo.ARInvoiceNo = (range.Cells[row, 5] as Range).Text.ToString().Trim();
                objInvoiceTransactionsInfo.ARInvoiceVatNo = (range.Cells[row, 6] as Range).Text.ToString().Trim();
                objInvoiceTransactionsInfo.ARInvoiceSymbol = (range.Cells[row, 7] as Range).Text.ToString().Trim();
                objInvoiceTransactionsInfo.ARInvoiceTransactionDesc = (range.Cells[row, 8] as Range).Text.ToString().Trim();

                cellValue = (range.Cells[row, 9] as Range).Text.ToString().Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objInvoiceTransactionsInfo.ARInvoiceDate = Convert.ToDateTime(cellValue);
                    }
                    catch (Exception ex)
                    {
                        objInvoiceTransactionsInfo.Selected = true;
                    }
                }

                cellValue = (range.Cells[row, 10] as Range).Text.ToString().Trim();
                if (!string.IsNullOrWhiteSpace(cellValue))
                {
                    try
                    {
                        objInvoiceTransactionsInfo.ARInvoiceTransactionEndDate = Convert.ToDateTime(cellValue);
                    }
                    catch (Exception ex)
                    {
                        objInvoiceTransactionsInfo.Selected = true;
                    }
                }

                cellValue = (range.Cells[row, 11] as Range).Text.ToString().Trim();
                currenciesInfo = listCurrenciesInfo.FirstOrDefault(o => o.GECurrencyName == cellValue || o.GECurrencyNo == cellValue);
                if(currenciesInfo != null)
                {
                    objInvoiceTransactionsInfo.FK_GECurrencyID = currenciesInfo.GECurrencyID;
                }

                cellValue = (range.Cells[row, 12] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                try
                {
                    objInvoiceTransactionsInfo.ARInvoiceTransactionExchangeRate = Convert.ToDecimal(cellValue);
                }
                catch (Exception ex)
                {
                    objInvoiceTransactionsInfo.ARInvoiceTransactionExchangeRate = 1;
                }

                cellValue = (range.Cells[row, 13] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                try
                {
                    objInvoiceTransactionsInfo.ARInvoiceAmount = Convert.ToDecimal(cellValue);
                }
                catch (Exception ex)
                {
                    objInvoiceTransactionsInfo.ARInvoiceAmount = 0;
                }

                cellValue = (range.Cells[row, 14] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                try
                {
                    objInvoiceTransactionsInfo.ARInvoiceAmountExchange = Convert.ToDecimal(cellValue);
                }
                catch (Exception ex)
                {
                    objInvoiceTransactionsInfo.ARInvoiceAmountExchange = 0;
                }

                cellValue = (range.Cells[row, 15] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                try
                {
                    objInvoiceTransactionsInfo.ARInvoicePaymentAmount = Convert.ToDecimal(cellValue);
                }
                catch (Exception ex)
                {
                    objInvoiceTransactionsInfo.ARInvoicePaymentAmount = 0;
                }

                cellValue = (range.Cells[row, 16] as Range).Text.ToString().Replace(",", string.Empty).Replace("-", string.Empty).Replace(".", ",").Trim();
                try
                {
                    objInvoiceTransactionsInfo.ARInvoicePaymentAmountExchange = Convert.ToDecimal(cellValue);
                }
                catch (Exception ex)
                {
                    objInvoiceTransactionsInfo.ARInvoicePaymentAmountExchange = 0;
                }

                if (string.IsNullOrWhiteSpace(objInvoiceTransactionsInfo.ARInvoiceNo))
                {
                    objInvoiceTransactionsInfo.ARInvoiceNo = "HDBDK-" + objInvoiceTransactionsInfo.ARObjectNo + objInvoiceTransactionsInfo.ARInvoiceVatNo;
                }
                if (string.IsNullOrWhiteSpace(objInvoiceTransactionsInfo.ARInvoiceTransactionReferenceNo))
                {
                    objInvoiceTransactionsInfo.ARInvoiceTransactionReferenceNo = objInvoiceTransactionsInfo.ARInvoiceNo;
                }
                
                objInvoiceTransactionsInfo.FK_BRBRanchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
                objInvoiceTransactionsInfo.ARInvoiceTransactionReferenceDate = BOSApp.CurrentCompanyInfo.CSCompanyStartDate.AddDays(-1);
                objInvoiceTransactionsInfo.AACreatedUser = BOSApp.CurrentUsersInfo.ADUserName;
                objInvoiceTransactionsInfo.ARInvoiceTransactionModuleName = this.Name;
                objInvoiceTransactionsInfo.ARInvoiceTransactionType = "Invoice";
                objInvoiceTransactionsInfo.ARInvoiceTransactionOrigin = "Balance";
                objInvoiceTransactionsInfo.ARInvoiceTransactionStatus = "New";
                objInvoiceTransactionsInfo.ARInvoiceTransactionPaymentType = "Final Payment";

                importInfoList.Add(objInvoiceTransactionsInfo);
            }
            entity.InvoiceTransactionList.AddRange(importInfoList);
            entity.InvoiceTransactionList.GridControl.RefreshDataSource();
        }
        #endregion
    }
}
