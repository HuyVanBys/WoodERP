using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP131 : ReportForm
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
        //private List<ACAssetsInfo> AssetList;

        public RP131()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void RP093_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
            ACObjectsController objObjectsController = new ACObjectsController();
            fld_lkeACObjectAccessKey.Properties.DataSource = objObjectsController.GetAllObjects();
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

        private void fld_btnExportExcel_Click(object sender, EventArgs e)
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

                    fld_dgcRP131PurchaseOrder.ExportToXlsx(fileName);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The process cannot access the file") && ex.Message.Contains("because it is being used by another process."))
                    MessageBox.Show(ReportLocalizedResources.CannotExportToExcelFileBecauseTheFileIsBeingUsedByAnotherProcessMessage,
                                    ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(ReportLocalizedResources.ExportExelFileUnsuccessfullyMessage,
                                    ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            GetDataSearch();
        }

        public void GetDataSearch()
        {
            int supplierID = 0;
            int employeeID = 0;
            string acObjectAccessKey = string.Empty;
            if (fld_lkeACObjectAccessKey.EditValue != null)
                acObjectAccessKey = fld_lkeACObjectAccessKey.EditValue.ToString();
            if (fld_lkeHREmployeeID.EditValue != null)
                int.TryParse(fld_lkeHREmployeeID.EditValue.ToString(), out employeeID);

            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(acObjectAccessKey);
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            ADReportsController objReportsController = new ADReportsController();
            List<APPurchaseOrdersInfo> PurchaseOrderList = objReportsController.GetPurchaseOrderItemForReportShippedLate(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType, searchFromDate, searchToDate, employeeID);
            fld_dgcRP131PurchaseOrder.DataSource = PurchaseOrderList;

        }

        private void fld_lkeACObjectAccessKey_QueryPopUp(object sender, CancelEventArgs e)
        {
            AccObjectLookupEdit lke = (AccObjectLookupEdit)sender;
        }
    }
}
