using System;

namespace BOSERP.Modules.Project.UI
{
    /// <summary>
    /// Summary description for DMPM101
    /// </summary>
    public partial class DMPM101 : BOSERPScreen
    {

        public DMPM101()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddContact_Click(object sender, EventArgs e)
        {
            ((ProjectModule)Module).AddItemToProjectContactList();
        }

        private void fld_btnEditContact_Click(object sender, EventArgs e)
        {
            ((ProjectModule)Module).ChangeSelectedItemFromProjectContactList();
        }

        private void fld_btnDeleteContact_Click(object sender, EventArgs e)
        {
            ((ProjectModule)Module).RemoveSelectedItemFromProjectContactList();
        }
    }
}
