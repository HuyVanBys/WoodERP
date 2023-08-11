using System;
using System.Windows.Forms;

namespace BOSERP.Modules.ACDocumentType
{
    public partial class guiEditDocumentType : BOSERPScreen
    {
        public guiEditDocumentType()
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

        private void guiEditDocumentType_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.ACDocTypeEntryList.InitBOSListGridControl(fld_dgcACDocTypeEntrys);
            fld_lkeACEntryTypeID.InvalidateDataSourceToLookupEdit();
        }

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_lkeFK_ACEntryTypeID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int entryTypeID = Convert.ToInt32(fld_lkeACEntryTypeID.EditValue);
                if (entryTypeID == -1)
                {
                    ((ACDocumentTypeModule)Module).CreateNewEntryType(fld_lkeACEntryTypeID);
                }
                else
                {
                    ((ACDocumentTypeModule)Module).AddItemToDocTypeEntryList();
                }
            }
        }
    }
}
