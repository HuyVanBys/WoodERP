using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP102Item : ReportForm
    {

        List<ACDocumentsInfo> DocumentList = new List<ACDocumentsInfo>();



        public RP102Item(List<ACDocumentsInfo> documentList)
        {
            InitializeComponent();
            DocumentList = documentList;
            RP143ACDocumentItems.DataSource = DocumentList;
            RP143ACDocumentItems.Refresh();
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

        private void RP001_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);


        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {

            GridView gridView = null;

            gridView = (GridView)RP143ACDocumentItems.MainView;

            if (gridView != null)
            {
                ExportToXls(gridView);
            }
        }


    }
}