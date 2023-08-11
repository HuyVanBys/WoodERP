using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using BOSComponent;

namespace BOSERP.Modules.BatchShipmentRoundWood.UI
{
	/// <summary>
	/// Summary description for DMBSR100
	/// </summary>
	public partial class DMBSR100 : BOSERPScreen
	{

		public DMBSR100()
		{
			//
			// Required designer variable
			//
			InitializeComponent();
		}

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((BatchShipmentRoundWoodModule)Module).AddItemToShipmentItemsList();
            }
        }

        private void fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
             BOSLookupEdit lke = (BOSLookupEdit)sender;
             if (e.Value != null && e.Value != lke.OldEditValue)
             {
                 ((BatchShipmentRoundWoodModule)Module).ChangeItemStorck((Int32.Parse(e.Value.ToString())));
             }
        }

        private void fld_btnShowInventoryStock_Click(object sender, EventArgs e)
        {
            ((BatchShipmentRoundWoodModule)Module).ShownInventoryStocks();
        }

        private void fld_lkeFK_ICProductAttributeTTMTID_EditValueChanged(object sender, EventArgs e)
        {
            ((BatchShipmentRoundWoodModule)Module).UpdateTTMT(int.Parse(fld_lkeFK_ICProductAttributeTTMTID.EditValue.ToString()));
        }

        private void fld_lkeFK_MMOperationID_EditValueChanged(object sender, EventArgs e)
        {
            ((BatchShipmentRoundWoodModule)Module).UpdateOperation(int.Parse(fld_lkeFK_MMOperationID.EditValue.ToString()));
        }

        private void fld_lkeFK_MMBatchProductID_EditValueChanged(object sender, EventArgs e)
        {
            ((BatchShipmentRoundWoodModule)Module).UpdateBatchProductID(int.Parse(fld_lkeFK_MMBatchProductID.EditValue.ToString()));
        }

        private void fld_lkeFK_MMOperationID_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
           ((BatchShipmentRoundWoodModule)Module).UpdateDocument();
        }

        private void bosLookupEdit1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {

        }

        private void bosLookupEdit1_CloseUp_1(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((BatchShipmentRoundWoodModule)Module).ChangeAcceptanceType((e.Value.ToString()));
            }
        }
	}
}
