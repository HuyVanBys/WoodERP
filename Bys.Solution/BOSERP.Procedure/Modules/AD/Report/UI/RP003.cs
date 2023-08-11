using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP003 : ReportForm
    {
        public RP003()
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

        private void RP003_Load(object sender, EventArgs e)
        {
            //initalize default date is today
            fld_dteSearchFromARInvoiceDate.EditValue = DateTime.Now;
            fld_dteSearchToARInvoiceDate.EditValue = DateTime.Now.AddDays(1);
            InitializeControls(Controls);
            fld_btnApply_Click(new object(), new EventArgs());
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            StringBuilder queryBuilder = new StringBuilder();
            queryBuilder.Append(GenerateSearchQuery(BOSUtil.GetTableNameFromBusinessObjectType(typeof(ARInvoicesInfo))));
            ARInvoicesController objInvoicesController = new ARInvoicesController();
            DataSet ds = objInvoicesController.GetDataSet(queryBuilder.ToString());
            fld_dgcARRP003Invoices.DataSource = ds.Tables[0];

        }

        private void fld_btnExcel_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcARRP003Invoices.MainView;
            ExportToExcel(gridView);

        }

        #region Initialize export excel parameter
        protected override List<ExportExcelParameter> GetReportHeader()
        {
            List<ExportExcelParameter> lstHeaderParameter = base.GetReportHeader();
            lstHeaderParameter.Add(SetDefaultHeaderParameter(fld_lblTitle.Text, 1, 3));
            return lstHeaderParameter;
        }

        protected override List<ExportExcelParameter> GetReportContent(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            List<DataTable> lstDataTable = new List<DataTable>();
            DataTable table = GetDefaultTableFromGridView(gridView);
            List<int> lstBranchID = new List<int>();

            //Init data row for datatable
            for (int i = 0; i < ((DataView)gridView.DataSource).Table.Rows.Count; i++)
            {
                if (gridView.GetRow(i) != null)
                {
                    int branchID = (int)gridView.GetRowCellValue(i, gridView.Columns["FK_BRBranchID"]);
                    DataTable tempTable = new DataTable();
                    if (lstBranchID.Count == 0 || !lstBranchID.Contains(branchID))
                    {
                        lstBranchID.Add(branchID);
                        tempTable = table.Clone();
                        tempTable.TableName = ((BRBranchsInfo)new BRBranchsController().GetObjectByID(branchID)).BRBranchName;
                        lstDataTable.Add(tempTable);
                    }
                    tempTable = lstDataTable[lstBranchID.IndexOf(branchID)];
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
                    lstDataTable[lstBranchID.IndexOf(branchID)].Rows.Add(row);
                }
            }
            //Create content parameter from datatable
            List<ExportExcelParameter> lstParameter = new List<ExportExcelParameter>();
            foreach (DataTable tableItem in lstDataTable)
            {
                lstParameter.Add(SetDefaultSubHeaderParameter(tableItem.TableName, ContentRowIndex, 1));
                lstParameter.Add(new ExportExcelParameter(ContentRowIndex + 1, 1, tableItem));
                ContentRowIndex += tableItem.Rows.Count + 3;
            }
            SummaryRowIndex = ContentRowIndex - 1;

            return lstParameter;
        }
        #endregion


    }
}