using System;

namespace BOSERP.Modules.Candidate.UI
{
    /// <summary>
    /// Summary description for DMCM100
    /// </summary>
    public partial class DMCM102 : BOSERPScreen
    {

        public DMCM102()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddCertificate_Click(object sender, EventArgs e)
        {
            ((CandidateModule)Module).AddItemToCertificateList();
        }

        private void fld_btnEditCertificate_Click(object sender, EventArgs e)
        {
            ((CandidateModule)Module).ChangeSelectedItemFromCertificateList();
        }

        private void fld_btnDeleteCertificate_Click(object sender, EventArgs e)
        {
            ((CandidateModule)Module).RemoveSelectedItemFromCertificateList();
        }

    }

}
