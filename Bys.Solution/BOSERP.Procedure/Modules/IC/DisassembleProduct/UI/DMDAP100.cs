using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.DisassembleProduct.UI
{
    /// <summary>
    /// Summary description for DMDAP100
    /// </summary>
    public partial class DMDAP100 : BOSERPScreen
    {

        public DMDAP100()
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

                ((DisassembleProductModule)Module).ChangeProduct(newProductID, oldProductID);

            }
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((DisassembleProductModule)Module).AddComponent();
        }

        private void fld_txtICDisassembleProductQty_Validated(object sender, EventArgs e)
        {
            ((DisassembleProductModule)Module).ChangeQty();
        }

        private void fld_btnShowInventoryProduct_Click(object sender, EventArgs e)
        {
            ((DisassembleProductModule)Module).ShowInventory();
        }

        private void fld_lkeFK_ICStockID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
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

                ((DisassembleProductModule)Module).ChangeStock(newProductID, oldProductID);

            }
        }

        private void fld_lkeFK_ICProductSerieID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
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

                ((DisassembleProductModule)Module).ChangeProductSerie(newProductID, oldProductID);

            }
        }
    }
}
