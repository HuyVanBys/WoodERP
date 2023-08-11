using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP012 : ReportForm
    {
        public RP012()
        {
            InitializeComponent();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void RP012_Load(object sender, EventArgs e)
        {
            BOSProgressBar.Start("Loading item list");
            InitializeControls(Controls);
            fld_lblBRBranchName.Text = ((BRBranchsInfo)new BRBranchsController().GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID)).BRBranchName;
            InitializeDataSource();
            BOSProgressBar.Close();
        }

        public void InitializeDataSource()
        {
            ADReportsController objReportsController = new ADReportsController();
            ICProductsController objProductsController = new ICProductsController();
            ICStocksController objStocksController = new ICStocksController();
            DataSet stockDataSet = objStocksController.GetAllDataByForeignColumn("FK_BRBranchID", BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            DataTable resultTable = null;
            DataColumn totalQtyColumn = null;
            foreach (DataRow row in stockDataSet.Tables[0].Rows)
            {
                ICStocksInfo objStocksInfo = (ICStocksInfo)objStocksController.GetObjectFromDataRow(row);
                //NUThao [EDIT] [08/04/2014] [DB centre] [CSCompany issue], START
                //DataSet ds = objReportsController.GetAllInventoryProducts(objStocksInfo.ICStockID);
                int companyID = BOSApp.CurrentCompanyInfo.CSCompanyID;
                DataSet ds = objReportsController.GetAllInventoryProducts(companyID, objStocksInfo.ICStockID);
                //NUThao [EDIT] [08/04/2014] [DB centre] [CSCompany issue], END
                if (ds.Tables.Count > 0)
                {
                    DataTable table = ds.Tables[0];
                    if (resultTable == null)
                    {
                        resultTable = table;
                        totalQtyColumn = resultTable.Columns.Add("ICInventoryStockTotalQty", typeof(double));
                    }
                    resultTable.Columns.Add(objStocksInfo.ICStockID.ToString(), typeof(double));
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectFromDataRow(table.Rows[i]);
                        resultTable.Rows[i][objStocksInfo.ICStockID.ToString()] = objProductsInfo.ICInventoryStockQuantity;
                        if (resultTable.Rows[i][totalQtyColumn].Equals(DBNull.Value))
                        {
                            resultTable.Rows[i][totalQtyColumn] = 0;
                        }
                        resultTable.Rows[i][totalQtyColumn] = Convert.ToDecimal(resultTable.Rows[i][totalQtyColumn]) + objProductsInfo.ICInventoryStockQuantity;
                    }
                }
            }

            fld_dgcICRP012Products.DataSource = resultTable;
            fld_dgcICRP012Products.RefreshDataSource();
        }

        private void fld_btnExcel_Click(object sender, EventArgs e)
        {
            BOSProgressBar.Start("Exporting");
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcICRP012Products.MainView;
            ExportToExcel(gridView);
            BOSProgressBar.Close();
        }

        #region Initialize export excel parameter
        protected override List<ExportExcelParameter> GetReportHeader()
        {
            List<ExportExcelParameter> lstHeaderParameter = base.GetReportHeader();
            lstHeaderParameter.Add(SetDefaultHeaderParameter(fld_lblBRBranchName.Text, 1, 4));
            lstHeaderParameter.Add(SetDefaultSubHeaderParameter(fld_lblTitle.Text, 2, 4));
            return lstHeaderParameter;
        }

        protected override List<ExportExcelParameter> GetReportContent(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            List<DataTable> lstDataTable = new List<DataTable>();
            DataTable table = GetDefaultTableFromGridView(gridView);
            List<string> lstDepartmentAndProductGroupID = new List<string>();

            //Init data row for datatable
            for (int i = 0; i < ((BOSList<ICProductsInfo>)gridView.DataSource).Count; i++)
            {
                if (gridView.GetRow(i) != null)
                {
                    int departmentID = (int)gridView.GetRowCellValue(i, gridView.Columns["FK_ICDepartmentID"]);
                    int productGroupID = (int)gridView.GetRowCellValue(i, gridView.Columns["FK_ICProductGroupID"]);
                    String strDepartmentAndProductGroupID = String.Format("{0};{1}", departmentID.ToString(), productGroupID.ToString());
                    DataTable tempTable = new DataTable();
                    if (lstDepartmentAndProductGroupID.Count == 0 || !lstDepartmentAndProductGroupID.Contains(strDepartmentAndProductGroupID))
                    {
                        lstDepartmentAndProductGroupID.Add(strDepartmentAndProductGroupID);
                        tempTable = table.Clone();
                        tempTable.TableName = strDepartmentAndProductGroupID;
                        lstDataTable.Add(tempTable);
                    }
                    tempTable = lstDataTable[lstDepartmentAndProductGroupID.IndexOf(strDepartmentAndProductGroupID)];
                    DataRow row = tempTable.NewRow();
                    for (int j = 0; j < VisibleColumns.Count; j++)
                    {
                        String value = gridView.GetRowCellDisplayText(i, gridView.Columns[tempTable.Columns[j].ColumnName]);
                        if (table.Columns[j].DataType == typeof(double))
                            row[j] = double.Parse(value);
                        else if (table.Columns[j].DataType == typeof(float))
                            row[j] = float.Parse(value);
                        else
                            row[j] = value;
                    }
                    lstDataTable[lstDepartmentAndProductGroupID.IndexOf(strDepartmentAndProductGroupID)].Rows.Add(row);
                }
            }

            List<ExportExcelParameter> lstParameter = new List<ExportExcelParameter>();
            String filterDepartment = String.Empty;
            foreach (DataTable tableItem in lstDataTable)
            {
                String[] strDepartmentAndProductGroupID = tableItem.TableName.Split(new char[] { ';' });
                String departmentName = ((ICDepartmentsInfo)new ICDepartmentsController().GetObjectByID(int.Parse(strDepartmentAndProductGroupID[0]))).ICDepartmentName;
                String productGroupName = ((ICProductGroupsInfo)new ICProductGroupsController().GetObjectByID(int.Parse(strDepartmentAndProductGroupID[1]))).ICProductGroupName;

                if (!departmentName.Equals(filterDepartment))
                    lstParameter.Add(SetDefaultTableNameParameter(departmentName, ContentRowIndex, 1));

                lstParameter.Add(SetDefaultSubTableNameParameter(productGroupName, ContentRowIndex + 1, 2));
                lstParameter.Add(new ExportExcelParameter(ContentRowIndex + 2, 2, tableItem));
                ContentRowIndex += tableItem.Rows.Count + 3;
                filterDepartment = departmentName;
            }
            SummaryRowIndex = ContentRowIndex;
            ContentStartYIndex = 2;
            return lstParameter;
        }
        #endregion
    }
}