using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class guiRP049Show : BOSERPScreen
    {
        public BOSList<ACDocumentEntrysInfo> DocumentEntryList { get; set; }
        public DateTime FromDate, ToDate;
        List<string> ListAccountID;
        int CurrencyID, BranchID;
        string Type;
        public guiRP049Show(BOSList<ACDocumentEntrysInfo> documentEntrys, DateTime fromDate, DateTime toDate, List<ACAccountsInfo> selectedAccounts, int currencyID, int branchID, string type)
        {
            this.DocumentEntryList = documentEntrys;
            this.FromDate = fromDate;
            this.ToDate = toDate;
            this.CurrencyID = currencyID;
            this.BranchID = branchID;
            this.ListAccountID = selectedAccounts.Select(x => x.ACAccountID.ToString()).Distinct().ToList();
            this.Type = type;
            List<string> accountNo = selectedAccounts.Select(x => x.ACAccountNo.ToString()).Distinct().ToList();
            List<string> accountName = selectedAccounts.Select(x => x.ACAccountName.ToString()).Distinct().ToList();
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.label_FromDateToDate.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, FromDate.Date.ToString("dd/MM/yyyy"),
                                                                                                ReportLocalizedResources.ToDateTitle, ToDate.Date.ToString("dd/MM/yyyy"));
            this.label_Account.Text += string.Join(",", accountNo.ToArray()) + " - " + string.Join(",", accountName.ToArray());
            this.label_GECurrencyName.Text += documentEntrys[0].GECurrencyName.ToString();
            if (this.Type == "RP046")
            {
                this.Title.Text = "Tổng hợp công nợ phải trả";
                this.Text = "Tổng hợp công nợ phải trả";
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
            fld_dgcRP049ACDocumentEntrys.DataSource = DocumentEntryList;
            fld_dgcRP049ACDocumentEntrys.RefreshDataSource();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_dgcRP049ACDocumentEntrys_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = ((GridControl)sender).MainView as GridView;
            if (gridView == null)
                return;
            if (gridView.FocusedRowHandle < 0)
                return;

            ACDocumentEntrysInfo entry = (ACDocumentEntrysInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (entry != null)
            {
                ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
                entries = objDocumentEntrysController.GetDocumentEntryGroupByAcountSoChitietCN(FromDate, ToDate, string.Join(",", ListAccountID.ToArray())
                    , CurrencyID, entry.FK_ACObjectID, entry.ACObjectType, BranchID);

                if (entries != null && entries.Any())
                {
                    guiRP049ShowDetail gui = new guiRP049ShowDetail(entries, FromDate, ToDate, entry.GECurrencyName, entry.ACObjectName, Type);
                    gui.Module = Module;
                    gui.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tồn tại dữ liệu", CommonLocalizedResources.MessageBoxDefaultCaption,
                                                                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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
                    fld_dgcRP049ACDocumentEntrys.ExportToXlsx(fileName);
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