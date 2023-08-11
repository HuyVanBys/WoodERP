using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchReceiptHeat.UI
{
    /// <summary>
    /// Summary description for DMBRH100
    /// </summary>
    public partial class DMBRH100 : BOSERPScreen
    {

        public DMBRH100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }



        private void fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((BatchReceiptHeatModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_txtICReceiptPackNo_Validated(object sender, EventArgs e)
        {
            //((BatchReceiptHeatModule)Module).ChangePackNo();
        }



        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((BatchReceiptHeatModule)Module).AddItemToReceiptItemsList();
            }
        }
    }
}
