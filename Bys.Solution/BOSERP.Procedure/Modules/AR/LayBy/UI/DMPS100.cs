using System;
using System.Windows.Forms;

namespace BOSERP.Modules.LayBy.UI
{
    /// <summary>
    /// Summary description for DMPS100
    /// </summary>
    public partial class DMPS100 : BOSERPScreen
    {

        public DMPS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID_Validated(object sender, EventArgs e)
        {
            ((Modules.LayBy.LayByModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_lblViewCustomer_Click(object sender, EventArgs e)
        {
            ((Modules.LayBy.LayByModule)this.Module).SetDefaultValuesFromCustomer();
        }

        private void fld_txtARSaleOrderDiscountFix_Validated(object sender, EventArgs e)
        {
            ((Modules.LayBy.LayByModule)this.Module).ChangeDiscountAmount();
        }

        private void fld_txtARSaleOrderDiscountPerCent_Validated(object sender, EventArgs e)
        {
            ((Modules.LayBy.LayByModule)this.Module).ChangeDiscountPercent();
        }

        private void fld_lkeFK_ARCustomerID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((Modules.LayBy.LayByModule)this.Module).ChangeCustomer(sender, e);
        }

        private void fld_lkeFK_ARPriceLevelID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            ((Modules.LayBy.LayByModule)this.Module).ChangePriceLevel(sender, e);
        }

        private void fld_lkeFK_ICProductAttributeID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((LayByModule)Module).AddItemToSaleOrderItemsList();
            }
        }
    }
}
