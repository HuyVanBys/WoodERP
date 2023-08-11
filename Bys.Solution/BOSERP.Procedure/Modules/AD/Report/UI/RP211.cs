using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP211 : ReportForm
    {
        #region Variables
        #endregion

        public RP211()
        {
            InitializeComponent();
        }

        private void RP195_Load(object sender, EventArgs e)
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

        public List<HREmployeesInfo> InitReportDataSource()
        {
            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            int? branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            string productType = string.Empty;
            ADReportsController objReportsController = new ADReportsController();
            List<HREmployeesInfo> results = objReportsController.GetEmployeesForReport211(fromDate, branchID, productType);
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
