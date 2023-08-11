using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace BOSERP
{
    public partial class guiPostDocument : BOSERPScreen
    {
        /// <summary>
        /// Gets or sets document list
        /// </summary>
        public List<ACDocumentsInfo> DocumentList { get; set; }

        public guiPostDocument()
        {
            InitializeComponent();
        }

        public guiPostDocument(List<ACDocumentsInfo> documentList)
        {
            InitializeComponent();
            DocumentList = documentList;
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

        private void guiPostDocument_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
            if (DocumentList.Count > 0)
            {
                ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                foreach (ACDocumentsInfo objDocumentsInfo in DocumentList)
                {
                    List<ACDocumentEntrysInfo> result = objDocumentEntrysController.GetDocumentEntryByDocumentID(objDocumentsInfo.ACDocumentID);
                    entries = entries.Concat(result).ToList();
                }
                fld_dgcDocumentEntrys.InvalidateDataSource(entries);
            }
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
