using System;
using System.Windows.Forms;

namespace BOSERP.Modules.InventoryAdjustment.UI
{
    /// <summary>
    /// Summary description for DMQA100
    /// </summary>
    public partial class DMICA100 : BOSERPScreen
    {

        public DMICA100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }
        private void fld_lkeFK_HREmployeeID_Validated(object sender, EventArgs e)
        {
            ((Modules.InventoryAdjustment.InventoryAdjustmentModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_lkeFK_ICProductAttributeID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((InventoryAdjustmentModule)Module).AddItemToAdjustmentItemsList();
            }
        }
    }
}
