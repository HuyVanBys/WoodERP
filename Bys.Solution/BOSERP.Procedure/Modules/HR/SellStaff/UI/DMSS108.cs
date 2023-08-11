using System;

namespace BOSERP.Modules.SellStaff.UI
{
    /// <summary>
    /// Summary description for DMSS108
    /// </summary>
    public partial class DMSS108 : BOSERPScreen
    {

        public DMSS108()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddCertificate_Click(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).AddItemToCertificateList();
        }

        private void fld_btnEditCertificate_Click(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).ChangeSelectedItemFromCertificateList();
        }

        private void fld_btnDeleteCertificate_Click(object sender, EventArgs e)
        {
            ((SellStaffModule)Module).RemoveSelectedItemFromCertificateList();
        }

        private void fld_ckeTrainingCourse_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (e.Value != fld_ckeTrainingCourse.OldEditValue)
            {
                ((SellStaffModule)Module).ChangeTrainingCourse(e.Value.ToString());
            }
        }
    }
}
