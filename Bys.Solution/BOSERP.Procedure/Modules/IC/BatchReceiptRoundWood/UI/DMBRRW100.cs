using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using BOSComponent;

namespace BOSERP.Modules.BatchReceiptRoundWood.UI
{
	/// <summary>
	/// Summary description for DMBRRW100
	/// </summary>
	public partial class DMBRRW100 : BOSERPScreen
	{

		public DMBRRW100()
		{
			//
			// Required designer variable
			//
			InitializeComponent();
		}


        private void fld_lkeFK_ICProductID1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((BatchReceiptRoundWoodModule)Module).AddItemToReceiptItemsList();
            }
        }

        private void fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((BatchReceiptRoundWoodModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }       
        }

        private void fld_txtICReceiptPackNo_Validated(object sender, EventArgs e)
        {
            ((BatchReceiptRoundWoodModule)Module).ChangePackNo();
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((BatchReceiptRoundWoodModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void bosLookupEdit1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
             BOSLookupEdit lke = (BOSLookupEdit)sender;
             if (e.Value != null && e.Value != lke.OldEditValue)
             {
                 ((BatchReceiptRoundWoodModule)Module).RoolbackTotalCost(e.Value.ToString());
                 ((BatchReceiptRoundWoodModule)Module).UpdateDocument(e.Value.ToString());
             }
        }

        private void fld_lkeFK_MMOperationID_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            //((BatchReceiptRoundWoodModule)Module).UpdateDocument();
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {

                ((BatchReceiptRoundWoodModule)Module).ChangeGECurrency(e.Value.ToString());
            } 
        }
	}
}
