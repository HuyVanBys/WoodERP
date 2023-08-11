using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP194 : ReportForm
    {
        #region Variables
        #endregion

        public RP194()
        {
            InitializeComponent();
        }

        private void RP194_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dteSearchFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_lblBranchName.Text = string.Empty;
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
            this.Close();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            if (fld_dteSearchFromDate.DateTime != DateTime.MaxValue)
            {
                ShowReportData();
            }
        }

        /// <summary>
        /// Show report data based on the report's parameters
        /// </summary>
        private void ShowReportData()
        {
            BOSProgressBar.Start(ReportLocalizedResources.LoadingData);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            DateTime from = Convert.ToDateTime(fld_dteSearchFromDate.EditValue);

            fld_dgcHREmployees.DataSource = InitReportDataSource();

            BRBranchsController objBranchsController = new BRBranchsController();
            if (branchID > 0)
                fld_lblBranchName.Text = fld_lkeBRBranchID.Text;
            else
                fld_lblBranchName.Text = string.Empty;

            BOSProgressBar.Close();
        }

        ///// <summary>
        ///// Get product group filter list
        ///// </summary>
        ///// <returns>The list of product group filter</returns>
        //private List<HREmployeesInfo> GetEmployeeList(bool result, int employeeId)
        //{
        //    int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
        //    ADReportsController objReportsController = new ADReportsController();

        //    DateTime from = Convert.ToDateTime(fld_dteSearchFromDate.EditValue);
        //    DateTime to = Convert.ToDateTime(fld_dteSearchToDate.EditValue);
        //    List<HREmployeesInfo> EmployeesInfo = new List<HREmployeesInfo>();
        //    if (result)
        //    {
        //        EmployeesInfo = objReportsController.GetTotalOrderQtAndTotalOrderAmountByEmployeeID(from, to, 0, branchID);
        //    }
        //    else
        //    {
        //        DateTime fromBefore = from.AddYears(-1);
        //        DateTime toBefore = to.AddYears(-1);
        //        EmployeesInfo = objReportsController.GetTotalOrderQtAndTotalOrderAmountByEmployeeID(fromBefore, toBefore, employeeId, branchID);
        //    }

        //    return EmployeesInfo;
        //}

        #region Initialize export excel parameter
        protected override List<ExportExcelParameter> GetReportHeader()
        {
            List<ExportExcelParameter> lstHeaderParameter = base.GetReportHeader();
            lstHeaderParameter.Add(SetDefaultHeaderParameter(fld_lblBranchName.Text, 1, 5));
            lstHeaderParameter.Add(SetDefaultSubHeaderParameter(fld_lblTitle.Text, 2, 5));
            return lstHeaderParameter;
        }
        #endregion

        /// <summary>
        /// Get report table
        /// </summary>
        /// <param name="productRows">List of product group filter</param>
        /// <param name="from">The invoice date from</param>
        /// <param name="to">The invoice date to</param>
        /// <returns>The data table</returns>
        //public DataTable GetReportTable(DateTime from, DateTime to)
        //{
        //    DataTable dataSource = new DataTable();
        //    DevExpress.XtraGrid.Columns.GridColumn col = new DevExpress.XtraGrid.Columns.GridColumn();

        //    dataSource.Columns.Add(new DataColumn("HREmployeeName"));
        //    int dem = 0;
        //    while (dem <= 3)
        //    {
        //        string quantityColumnName = "InvoiceAmount_" + dem.ToString();
        //        dataSource.Columns.Add(new DataColumn(quantityColumnName, typeof(decimal)));
        //        dem++;
        //    }

        //    dataSource.Columns.Add(new DataColumn("Accumulation", typeof(decimal)));
        //    dataSource.Columns.Add(new DataColumn("SalesYearBefore", typeof(decimal)));
        //    dataSource.Columns.Add(new DataColumn("RatioGrowth", typeof(decimal)));
        //    dataSource.Columns.Add(new DataColumn("Note"));

        //    return dataSource;
        //}

        //private List<string> DistinctEmployeeNos(List<HREmployeesInfo> employeeList)
        //{
        //    List<string> employeeNos = new List<string>();
        //    if (employeeList != null)
        //    {
        //        foreach (HREmployeesInfo objEmployeesInfo in employeeList)
        //        {
        //            if (!employeeNos.Contains(objEmployeesInfo.HREmployeeNo))
        //                employeeNos.Add(objEmployeesInfo.HREmployeeNo);
        //        }
        //    }

        //    return employeeNos;
        //}

        public List<HREmployeesInfo> InitReportDataSource()
        {
            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            int? branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int? employeeID = Convert.ToInt32(fld_lkeHREmployeeID.EditValue);
            ADReportsController objReportsController = new ADReportsController();
            List<HREmployeesInfo> results = objReportsController.GetEmployeesForReport194(fromDate, branchID, employeeID);
            return results;
        }

        private void fld_btnExportExcelXls_Click(object sender, EventArgs e)
        {
            try
            {

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.InitialDirectory = @"C:\";

                saveFileDialog1.Title = "Save Files";

                saveFileDialog1.DefaultExt = "xlsx";

                saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|(*.xlsx)|*.xlsx|All files (*.*)|*.*";

                saveFileDialog1.FilterIndex = 2;

                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    string fileName = saveFileDialog1.FileName;
                    fld_dgcHREmployees.ExportToXlsx(fileName);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The process cannot access the file") && ex.Message.Contains("because it is being used by another process."))
                    MessageBox.Show(ReportLocalizedResources.CannotExportToExcelFileBecauseTheFileIsBeingUsedByAnotherProcessMessage,
                                    CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(ReportLocalizedResources.ExportExelFileUnsuccessfullyMessage,
                                    CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
