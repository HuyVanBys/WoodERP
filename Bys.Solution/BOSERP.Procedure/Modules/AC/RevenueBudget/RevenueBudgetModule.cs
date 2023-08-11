using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using Localization;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.RevenueBudget
{
    #region RevenueBudgetModule
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class: RevenueBudgetModule
    //Created Date:Friday, March 21, 2008
    //-----------------------------------------------------------

    public class RevenueBudgetModule : BaseModuleERP
    {
        #region Constants

        #endregion

        #region Public properties

        #endregion

        public RevenueBudgetModule()
        {
            Name = "RevenueBudget";
            CurrentModuleEntity = new RevenueBudgetEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
        }

        public void DeleteItemFromRevenueBudgetDetailsList()
        {
            RevenueBudgetEntities entity = (RevenueBudgetEntities)CurrentModuleEntity;
            entity.ACRevenueBudgetDetailsList.RemoveSelectedRowObjectFromList();

        }

        public override void InvalidateToolbar()
        {
            ACRevenueBudgetsInfo revenueBudget = (ACRevenueBudgetsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
            ParentScreen.SetEnableOfToolbarButton("Approve", false);
            ParentScreen.SetEnableOfToolbarButton("UnApprove", false);
            if (revenueBudget.ACRevenueBudgetID > 0)
            {
                if (revenueBudget.ACRevenueBudgetStatus == RevenueBudgetStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Approve", true);
                    ParentScreen.SetEnableOfToolbarButton("UnApprove", true);
                }
                else if (revenueBudget.ACRevenueBudgetStatus == RevenueBudgetStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton("UnApprove", true);
                }
                else if (revenueBudget.ACRevenueBudgetStatus == RevenueBudgetStatus.Canceled.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton("UnApprove", false);
                }
            }

            base.InvalidateToolbar();

            if (!Toolbar.IsNullOrNoneAction())
            {
                ParentScreen.SetEnableOfToolbarButton("Approve", false);
                ParentScreen.SetEnableOfToolbarButton("UnApprove", false);
            }
        }

        public void ApproveRevenueBudget()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                RevenueBudgetEntities entity = (RevenueBudgetEntities)CurrentModuleEntity;
                entity.SetPropertyChangeEventLock(false);
                ACRevenueBudgetsInfo revenueBudget = (ACRevenueBudgetsInfo)entity.MainObject;
                if (revenueBudget.ACRevenueBudgetStatus == RevenueBudgetStatus.New.ToString())
                {
                    revenueBudget.ACRevenueBudgetStatus = RevenueBudgetStatus.Approved.ToString();
                }
                entity.UpdateMainObject();
                entity.SetPropertyChangeEventLock(true);
                InvalidateToolbar();
            }
        }

        public void CancelRevenueBudget()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                DialogResult check = MessageBox.Show(CommonLocalizedResources.CancelDocumentMessageConfirm
                                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                                    , MessageBoxButtons.YesNo
                                                    , MessageBoxIcon.Question
                                                    );
                if (check == DialogResult.Yes)
                {
                    RevenueBudgetEntities entity = (RevenueBudgetEntities)CurrentModuleEntity;
                    entity.SetPropertyChangeEventLock(false);
                    ACRevenueBudgetsInfo revenueBudget = (ACRevenueBudgetsInfo)entity.MainObject;
                    revenueBudget.ACRevenueBudgetStatus = RevenueBudgetStatus.Canceled.ToString();
                    entity.UpdateMainObject();
                    entity.SetPropertyChangeEventLock(true);
                    InvalidateToolbar();
                }

            }
        }

        public void ChangeCurrency(int currencyID)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (MessageBox.Show(CommonLocalizedResources.CurrencyChangeConfirmMessage
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.YesNo
                                    , MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RevenueBudgetEntities entity = (RevenueBudgetEntities)CurrentModuleEntity;
                    foreach (ACRevenueBudgetDetailsInfo detail in entity.ACRevenueBudgetDetailsList)
                    {
                        detail.FK_GECurrencyID = currencyID;
                    }

                    entity.ACRevenueBudgetDetailsList.GridControl.RefreshDataSource();
                }
            }
        }

        public void ChangeExchangeRate(decimal exchangeRate)
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (MessageBox.Show(CommonLocalizedResources.ExchangeRateChangeConfirmMessage
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.YesNo
                                    , MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RevenueBudgetEntities entity = (RevenueBudgetEntities)CurrentModuleEntity;
                    foreach (ACRevenueBudgetDetailsInfo detail in entity.ACRevenueBudgetDetailsList)
                    {
                        detail.ACRevenueBudgetDetailExchangeRate = exchangeRate;
                    }

                    entity.ACRevenueBudgetDetailsList.GridControl.RefreshDataSource();
                }
            }
        }

        public override int ActionSave()
        {
            RevenueBudgetEntities entity = (RevenueBudgetEntities)CurrentModuleEntity;
            ACRevenueBudgetDetailsInfo invalidDetail
                    = entity.ACRevenueBudgetDetailsList.FirstOrDefault(t => t.ACRevenueBudgetDetailAmount == 0
                                                                        || t.FK_ACCreditAccountID == 0);
            if (invalidDetail != null)
            {
                MessageBox.Show(CommonLocalizedResources.NotBlankAmountOrCreditAccountMessage
                                    , CommonLocalizedResources.MessageBoxDefaultCaption
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);
                return 0;

            }

            return base.ActionSave();
        }

        public void GetDetailExcelTemplate()
        {

            List<ExportExcelParameter> lstParameter = new List<ExportExcelParameter>();
            lstParameter.AddRange(GetExcelContent());
            ExportToExcel(lstParameter);
        }
        public void ExportToExcel(List<ExportExcelParameter> lstParameter)
        {


            Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook exWorkBook = exApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet exSheet = (Worksheet)exWorkBook.Worksheets[1];
            exSheet.Activate();


            for (int i = 0; i < lstParameter.Count; i++)
            {

                ExportExcelParameter parameter = lstParameter[i];
                Range range = (Range)exSheet.Cells[parameter.PosX, parameter.PosY];

                range.Font.Color = ColorTranslator.ToOle(parameter.ForeColor);
                range.Font.Name = parameter.Font.Name;
                range.Font.Size = parameter.Font.Size;
                range.Font.Bold = parameter.Font.Bold;
                if (parameter.Value.GetType() == typeof(double))
                    range.NumberFormat = "#,##0.00";
                else if (parameter.Value.GetType() == typeof(float))
                    range.NumberFormat = "#,##0";
                if (parameter.BackColor != Color.Empty)
                    range.Interior.Color = ColorTranslator.ToOle(parameter.BackColor);
                range.Value2 = parameter.Value.ToString();

                if (parameter.Value.GetType() == typeof(System.Data.DataTable))
                {
                    System.Data.DataTable table = (System.Data.DataTable)parameter.Value;

                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        Range rangeCaption = (Range)exSheet.Cells[parameter.PosX, parameter.PosY + j];
                        rangeCaption.Value2 = table.Columns[j].Caption;
                        rangeCaption.ColumnWidth = table.Columns[j].DefaultValue;
                        rangeCaption.Font.Color = ColorTranslator.ToOle(Color.Black);
                        rangeCaption.Font.Size = "11";
                        rangeCaption.Font.Bold = FontStyle.Bold;
                        rangeCaption.Interior.Color = ColorTranslator.ToOle(Color.LightGray);

                    }
                }
            }
            exApp.Visible = true;
        }
        public List<ExportExcelParameter> GetExcelContent()
        {
            System.Data.DataTable table = new System.Data.DataTable();

            string[] colList = new string[]{"Từ ngày"
                                            ,   "Đến ngày"
                                            ,   "Chi nhánh (Mã)"
                                            ,   "Phòng ban (Mã)"
                                            ,   "Ngành hàng (Tên)"
                                            ,   "Nhóm hàng (Tên)"
                                            ,   "Sản phẩm (Mã)"
                                            ,   "Khách hàng (Mã)"
                                            ,   "Nhóm khách hàng"
                                            ,   "Vị trí (Tên)"
                                            ,   "Tài khoản có (Mã)"
                                            ,   "Tài khoản nợ (Mã)"
                                            ,   "Số tiền"
                                            ,   "Loại tiền tệ"
                                            ,   "Tỷ giá"

                                            };
            InitDataTableColumn(colList, table);
            List<ExportExcelParameter> lstContentParameter = new List<ExportExcelParameter>();
            lstContentParameter.Add(new ExportExcelParameter(1, 1, table));
            return lstContentParameter;
        }

        public void InitDataTableColumn(string[] colList, System.Data.DataTable table)
        {
            DataColumn col;
            foreach (string colName in colList)
            {
                col = new DataColumn();
                col.ColumnName = colName;
                table.Columns.Add(col);
            }

            int countCol = table.Columns.Count;
            DataRow dr = table.NewRow();
            for (int i = 0; i < countCol; i++)
            {
                dr[i] = string.Empty;
            }

            table.Rows.Add(dr);
        }


        public string GetStringFromExcelRange(object range)
        {
            string result = string.Empty;
            if (range != null)
            {
                result = (string)range;
            }

            return result;
        }

        public decimal GetDecimalFromExcelRange(object range)
        {
            double result = 0;
            if (range != null)
            {
                result = (double)range;
            }

            return (decimal)result;
        }

        public DateTime GetDateTimeFromExcelRange(object range)
        {
            DateTime result = DateTime.MaxValue;
            if (range != null)
            {
                result = DateTime.FromOADate((double)range);
            }

            return result;
        }

        public void ImportFromExcel()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {

                RevenueBudgetEntities entity = (RevenueBudgetEntities)CurrentModuleEntity;
                ACRevenueBudgetsInfo mainObject = (ACRevenueBudgetsInfo)entity.MainObject;

                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "Excel files 2002-2003 (*.xls)|*.xls|Excel files 2007-2010 (*.xlsx)|*.xlsx";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string curFile = openFileDialog.FileName.ToString();

                    if (File.Exists(curFile))
                    {
                        BOSProgressBar.Start("Đang import dữ liệu");
                        Microsoft.Office.Interop.Excel.Application xlApp;
                        Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                        Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                        Microsoft.Office.Interop.Excel.Range range;

                        xlApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                        xlWorkBook = xlApp.Workbooks.Open(curFile, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                        xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                        range = xlWorkSheet.UsedRange;

                        List<ACRevenueBudgetDetailsInfo> detailList = new List<ACRevenueBudgetDetailsInfo>();
                        ACRevenueBudgetDetailsInfo detail;

                        #region DATA compare
                        List<BRBranchsInfo> branchList = new List<BRBranchsInfo>();
                        BRBranchsInfo branch;

                        List<HRDepartmentsInfo> hrDepartmentList = new List<HRDepartmentsInfo>();
                        HRDepartmentsInfo hrDepartment;

                        List<ICProductsForViewInfo> productList = BOSApp.CurrentProductList;
                        ICProductsForViewInfo product;

                        List<ICProductGroupsInfo> productGroupList = new List<ICProductGroupsInfo>();
                        ICProductGroupsInfo productGroup;

                        List<ICDepartmentsInfo> icDepartmentList = new List<ICDepartmentsInfo>();
                        ICDepartmentsInfo icDepartment;

                        List<ARCustomersInfo> customerList = new List<ARCustomersInfo>();
                        ARCustomersInfo customer;

                        List<ADConfigValuesInfo> customerTypeList = new List<ADConfigValuesInfo>();
                        ADConfigValuesInfo configValue;

                        List<GELocationsInfo> locationList = new List<GELocationsInfo>();
                        GELocationsInfo location;

                        List<ACAccountsInfo> accountList = new List<ACAccountsInfo>();
                        ACAccountsInfo account;

                        List<GECurrenciesInfo> currencyList = new List<GECurrenciesInfo>();
                        GECurrenciesInfo currency;

                        BRBranchsController branchController = new BRBranchsController();
                        branchList = branchController.GetAllBranches();

                        HRDepartmentsController hrDepartmentController = new HRDepartmentsController();
                        hrDepartmentList = hrDepartmentController.GetAllList();

                        ICProductGroupsController pgController = new ICProductGroupsController();
                        productGroupList = pgController.GetAllObjectList();

                        ICDepartmentsController icDepartmentController = new ICDepartmentsController();
                        icDepartmentList = icDepartmentController.GetallObjects();

                        ARCustomersController customerController = new ARCustomersController();
                        customerList = customerController.GetAllCustomer();

                        ADConfigValuesController configValueController = new ADConfigValuesController();
                        DataSet ds = configValueController.GetADConfigValuesByGroup(ConfigValueGroup.CustomerType.ToString());
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            foreach (DataRow dr in ds.Tables[0].Rows)
                            {
                                ADConfigValuesInfo cv = new ADConfigValuesInfo();
                                cv = (ADConfigValuesInfo)configValueController.GetObjectFromDataRow(dr);
                                customerTypeList.Add(cv);
                            }
                        }

                        GELocationsController locationController = new GELocationsController();
                        locationList = locationController.GetAllLocationList();

                        ACAccountsController accountController = new ACAccountsController();
                        accountList = accountController.GetAllAccountList();

                        GECurrenciesController currencyController = new GECurrenciesController();
                        currencyList = currencyController.GetAllCurrencys();
                        #endregion
                        string errorMess = string.Empty;
                        for (int j = 2; j <= range.Rows.Count; j++)
                        {

                            detail = new ACRevenueBudgetDetailsInfo();
                            if ((range.Cells[j, 1] as Microsoft.Office.Interop.Excel.Range).Value2 == null
                                || string.IsNullOrEmpty((range.Cells[j, 1] as Microsoft.Office.Interop.Excel.Range).Value2.ToString()))
                            {
                                break;
                            }

                            DateTime fromDate = GetDateTimeFromExcelRange((range.Cells[j, 1] as Microsoft.Office.Interop.Excel.Range).Value2);
                            DateTime toDate = GetDateTimeFromExcelRange((range.Cells[j, 2] as Microsoft.Office.Interop.Excel.Range).Value2);
                            string branchNo = GetStringFromExcelRange((range.Cells[j, 3] as Microsoft.Office.Interop.Excel.Range).Value2);
                            string hrDepartmentNo = GetStringFromExcelRange((range.Cells[j, 4] as Microsoft.Office.Interop.Excel.Range).Value2);
                            string icDepartmentName = GetStringFromExcelRange((range.Cells[j, 5] as Microsoft.Office.Interop.Excel.Range).Value2);
                            string productGroupName = GetStringFromExcelRange((range.Cells[j, 6] as Microsoft.Office.Interop.Excel.Range).Value2);
                            string productNo = GetStringFromExcelRange((range.Cells[j, 7] as Microsoft.Office.Interop.Excel.Range).Value2);
                            string customerNo = GetStringFromExcelRange((range.Cells[j, 8] as Microsoft.Office.Interop.Excel.Range).Value2);
                            string customerType = GetStringFromExcelRange((range.Cells[j, 9] as Microsoft.Office.Interop.Excel.Range).Value2);
                            string locationName = GetStringFromExcelRange((range.Cells[j, 10] as Microsoft.Office.Interop.Excel.Range).Value2);
                            string creditAccountNo = GetStringFromExcelRange((range.Cells[j, 11] as Microsoft.Office.Interop.Excel.Range).Value2);
                            string debitAccountNo = GetStringFromExcelRange((range.Cells[j, 12] as Microsoft.Office.Interop.Excel.Range).Value2);
                            decimal amount = GetDecimalFromExcelRange((range.Cells[j, 13] as Microsoft.Office.Interop.Excel.Range).Value2);
                            string currencySTR = GetStringFromExcelRange((range.Cells[j, 14] as Microsoft.Office.Interop.Excel.Range).Value2);
                            decimal exRate = GetDecimalFromExcelRange((range.Cells[j, 15] as Microsoft.Office.Interop.Excel.Range).Value2);

                            detail.ACRevenueBudgetDetailFromDate = fromDate;
                            detail.ACRevenueBudgetDetailToDate = toDate;

                            branch = branchList.FirstOrDefault(t => t.BRBranchNo == branchNo);
                            if (branch != null)
                            {
                                detail.FK_BRBranchID = branch.BRBranchID;
                            }

                            product = productList.FirstOrDefault(t => t.ICProductNo == productNo);
                            if (product != null)
                            {
                                detail.FK_ICProductID = product.ICProductID;
                            }

                            hrDepartment = hrDepartmentList.FirstOrDefault(t => t.HRDepartmentNo == hrDepartmentNo);
                            if (hrDepartment != null)
                            {
                                detail.FK_HRDepartmentID = hrDepartment.HRDepartmentID;
                            }

                            icDepartment = icDepartmentList.FirstOrDefault(t => t.ICDepartmentName == icDepartmentName);
                            if (icDepartment != null)
                            {
                                detail.FK_ICDepartmentID = icDepartment.ICDepartmentID;
                            }

                            productGroup = productGroupList.FirstOrDefault(t => t.ICProductGroupName == productGroupName);
                            if (productGroup != null)
                            {
                                detail.FK_ICProductGroupID = productGroup.ICProductGroupID;
                            }

                            customer = customerList.FirstOrDefault(t => t.ARCustomerNo == customerNo);
                            if (customer != null)
                            {
                                detail.FK_ARCustomerID = customer.ARCustomerID;
                            }

                            configValue = customerTypeList.FirstOrDefault(t => t.ADConfigText == customerType);
                            if (configValue != null)
                            {
                                detail.ACCustomerType = configValue.ADConfigKeyValue;
                            }

                            location = locationList.FirstOrDefault(t => t.GELocationName == locationName);
                            if (location != null)
                            {
                                detail.FK_GELocationID = location.GELocationID;
                            }

                            account = accountList.FirstOrDefault(t => t.ACAccountNo == creditAccountNo);
                            if (account != null)
                            {
                                detail.FK_ACCreditAccountID = account.ACAccountID;
                            }

                            account = accountList.FirstOrDefault(t => t.ACAccountNo == debitAccountNo);
                            if (account != null)
                            {
                                detail.FK_ACDebitAccountID = account.ACAccountID;
                            }

                            detail.ACRevenueBudgetDetailAmount = amount;

                            currency = currencyList.FirstOrDefault(t => t.GECurrencyNo == currencySTR);
                            if (currency != null)
                            {
                                detail.FK_GECurrencyID = currency.GECurrencyID;
                            }

                            detail.ACRevenueBudgetDetailExchangeRate = exRate;
                            detailList.Add(detail);
                        }

                        entity.ACRevenueBudgetDetailsList.Clear();
                        entity.ACRevenueBudgetDetailsList.AddRange(detailList);
                        entity.ACRevenueBudgetDetailsList.GridControl.RefreshDataSource();
                        xlWorkBook.Close(true, null, null);
                        xlApp.Quit();

                        releaseObject(xlWorkSheet);
                        releaseObject(xlWorkBook);
                        releaseObject(xlApp);

                        BOSProgressBar.Close();
                    }
                }

            }



        }


        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        public override void ModuleAfterSaved(int iObjectID)
        {
            base.ModuleAfterSaved(iObjectID);

            InvalidateToolbar();
        }
    }
    #endregion
}