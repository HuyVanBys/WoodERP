using System;

namespace BOSERP.Modules.Customer.UI
{
    public partial class DMCU104 : BOSERPScreen
    {
        public DMCU104()
        {
            InitializeComponent();
        }

        private void fld_btnAddRemind_Click(object sender, EventArgs e)
        {
            ((CustomerModule)Module).AddItemToRemindList();
        }

        private void fld_btnEditRemind_Click(object sender, EventArgs e)
        {
            ((CustomerModule)Module).EditItemRemindList();
        }

        private void fld_btnDeleteRemind_Click(object sender, EventArgs e)
        {
            ((CustomerModule)Module).DeleteItemRemindList();
        }
    }
}
