using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.AssembleProduct.UI
{
    /// <summary>
    /// Summary description for DMAP100
    /// </summary>
    public partial class DMAP100 : BOSERPScreen
    {

        public DMAP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void bosLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bosTextBox1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void bosPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fld_lkeProduct_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                int newProductID = 0;
                int oldProductID = 0;

                if (e.Value != null)
                {
                    int.TryParse(e.Value.ToString(), out newProductID);
                }

                if (lke.OldEditValue != null)
                {
                    int.TryParse(lke.OldEditValue.ToString(), out oldProductID);
                }

                ((AssembleProductModule)Module).ChangeProduct(newProductID, oldProductID);

            }
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((AssembleProductModule)Module).AddComponent();
        }

        private void fld_txtICAssembleProductQty_Validated(object sender, EventArgs e)
        {
            ((AssembleProductModule)Module).ChangeQty();
        }

        private void fld_btnRefreshInventory_Click(object sender, EventArgs e)
        {
            ((AssembleProductModule)Module).RefreshInventory();
        }

        private void fld_btnShowInventoryProduct_Click(object sender, EventArgs e)
        {
            ((AssembleProductModule)Module).ShowInventory();
        }

        private void fld_chkICAssembleProductIsAverageCalculation_CheckedChanged(object sender, EventArgs e)
        {
            ((AssembleProductModule)Module).ChangeAverageCalculation();
        }
    }
}
