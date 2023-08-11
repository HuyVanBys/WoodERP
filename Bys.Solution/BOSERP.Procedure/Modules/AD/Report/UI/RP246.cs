using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP246 : ReportForm
    {
        /// <summary>
        /// Define location id
        /// </summary>
        private int LocationID = 0;

        /// <summary>
        /// A variable to store the list of selected employees
        /// </summary>
        private List<HREmployeesInfo> SelectedEmployeeList = new List<HREmployeesInfo>();

        /// <summary>
        /// A variable to store the report data soruce
        /// </summary>
        private List<ICShipmentItemsInfo> ReportDataSource = new List<ICShipmentItemsInfo>();
        private DateTime dateFrom;
        private DateTime dateTo;
        public RP246()
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

        private void RP245_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = DateTime.Now;
            fld_dteSearchToDate.DateTime = DateTime.Now;
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Init data source for report
        /// </summary>
        public void InitDataSource()
        {
            int locationID = LocationID;
            dateFrom = fld_dteSearchFromDate.DateTime;
            dateTo = fld_dteSearchToDate.DateTime;
            int deparmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            int productGroupID = Convert.ToInt32(fld_lkeFK_ICProductGroupID.EditValue);
            ADReportsController objReportsController = new ADReportsController();
            List<ICShipmentItemsInfo> shipmentItemsList = new List<ICShipmentItemsInfo>();
            shipmentItemsList = objReportsController.GetDetailShipmentByBatchProduct(dateFrom,
                                                                          dateTo,
                                                                          deparmentID,
                                                                          productGroupID);
            fld_dgcARRP246ICShipmentItems.DataSource = shipmentItemsList;
            fld_dgcARRP246ICShipmentItems.DataSource = shipmentItemsList;
            ReportDataSource = shipmentItemsList;
            if (shipmentItemsList.Count == 0)
                fld_btnPrint.Enabled = false;
            else
                fld_btnPrint.Enabled = true;
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP246 rp = new BOSReport.RP246();
            XRLabel xrDate = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xrDate"];
            if (xrDate != null)
                xrDate.Text = "Từ ngày " + dateFrom.ToString("dd-MM-yyyy") + " đến " + dateTo.ToString("dd-MM-yyyy");

            rp.DataSource = ReportDataSource;
            guiReportPreview reviewer = new guiReportPreview(rp, "Reports\\PhoXinh\\RP245.repx", true);
            reviewer.Show();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            InitDataSource();
        }

        private void fld_bedGELocationName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
        }

        private void fld_bedEmployees_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
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
                    fld_dgcARRP246ICShipmentItems.ExportToXlsx(fileName);
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
