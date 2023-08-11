using System;

namespace BOSERP.Modules.Customer.UI
{
    /// <summary>
    /// Summary description for DMCU103
    /// </summary>
    public partial class DMCU103 : BOSERPScreen
    {

        public DMCU103()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddContact_Click(object sender, EventArgs e)
        {
            ((CustomerModule)Module).AddItemToCustomerContactList();
        }

        private void fld_btnEditContact_Click(object sender, EventArgs e)
        {
            ((CustomerModule)Module).ChangeSelectedItemFromCustomerContactList();
        }

        private void fld_btnDeleteContact_Click(object sender, EventArgs e)
        {
            ((CustomerModule)Module).RemoveSelectedItemFromCustomerContactList();
        }
    }
}
