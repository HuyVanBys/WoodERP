using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP089 : ReportForm
    {

        /// <summary>
        /// Gets or sets the grid view main
        /// </summary>
        public GridView GridViewMain
        {
            get
            {
                return (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcACDocumentEntrys.ViewCollection[0];
            }
        }
        public DataTable DataSource { get; set; }
        public BandedGridView BandedGridView { get; set; }

        public string FormHeader
        {
            set
            {
                this.Text = value;
            }
        }

        public string FormTitle
        {
            set
            {
                fld_lblTitle.Text = value;
            }
        }

        public string SubTitle
        {
            set
            {
                fld_lblFromdateTodate.Text = value;
            }
        }


        public RP089()
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

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RP089_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dgcACDocumentEntrys.RefreshDataSource(DataSource);
        }

        /// <summary>
        /// Create Banded Grid View
        /// </summary>
        /// <param name="gridView">GridView</param>
        /// <returns></returns>
        public BandedGridView InitBandedGridView(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            return BandedGridView;
        }

        private void fld_btnExportFile_Click(object sender, EventArgs e)
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

                    fld_dgcACDocumentEntrys.ExportToXlsx(fileName);
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