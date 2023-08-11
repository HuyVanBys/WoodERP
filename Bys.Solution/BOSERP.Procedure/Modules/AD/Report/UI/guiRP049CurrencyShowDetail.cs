using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class guiRP049CurrencyShowDetail : BOSERPScreen
    {
        public List<ACDocumentEntrysInfo> DocumentEntryList { get; set; }
        public DateTime FromDate, ToDate;
        public guiRP049CurrencyShowDetail(List<ACDocumentEntrysInfo> documentEntrys, DateTime fromDate, DateTime toDate, string currencyName, string objectName, string type)
        {
            this.DocumentEntryList = documentEntrys;
            this.FromDate = fromDate;
            this.ToDate = toDate;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.label_ObjectName.Text += objectName;
            this.label_FromDateToDate.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, FromDate.Date.ToString("dd/MM/yyyy"),
                                                                                                ReportLocalizedResources.ToDateTitle, ToDate.Date.ToString("dd/MM/yyyy"));
            if (type == "RP046" || type == "RP047")
            {
                this.Title.Text = "Chi tiết công nợ phải trả";
                this.Text = "Chi tiết công nợ phải trả";
            }
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
        private void guiRP049Show_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            InitializeDataSource();
        }
        private void InitializeDataSource()
        {
            fld_dgcRP049DetailCurrencyACDocumentEntrys.DataSource = DocumentEntryList;
            fld_dgcRP049DetailCurrencyACDocumentEntrys.RefreshDataSource();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
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
                    fld_dgcRP049DetailCurrencyACDocumentEntrys.ExportToXlsx(fileName);
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
    }
}