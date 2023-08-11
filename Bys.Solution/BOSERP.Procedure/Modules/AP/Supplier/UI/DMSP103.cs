using System;

namespace BOSERP.Modules.Supplier.UI
{
    /// <summary>
    /// Summary description for DMSP103
    /// </summary>
    public partial class DMSP103 : BOSERPScreen
    {

        public DMSP103()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAddContact_Click(object sender, EventArgs e)
        {
            ((SupplierModule)Module).AddItemToSupplierContactList();
        }

        private void fld_btnEditContact_Click(object sender, EventArgs e)
        {
            ((SupplierModule)Module).ChangeSelectedItemFromSupplierContactList();
        }

        private void fld_btnDeleteContact_Click(object sender, EventArgs e)
        {
            ((SupplierModule)Module).RemoveSelectedItemFromSupplierContactList();
        }
    }
}
