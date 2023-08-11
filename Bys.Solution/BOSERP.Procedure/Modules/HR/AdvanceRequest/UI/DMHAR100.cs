using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.AdvanceRequest.UI
{
    /// <summary>
    /// Summary description for DMHAR100
    /// </summary>
    public partial class DMHAR100 : BOSERPScreen
    {

        public DMHAR100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnAdd_Click(object sender, EventArgs e)
        {
            ((AdvanceRequestModule)Module).AddItemToAdvanceRequestItemList();
        }

        private void fld_btnDelete_Click(object sender, EventArgs e)
        {
            ((AdvanceRequestModule)Module).RemoveSelectedItem();
        }

        private void fld_lkeHREmployeeID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ((AdvanceRequestModule)Module).AddItemToAdvanceRequestItemList();
        }

        private void fld_lkeHRAdvanceRequestType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (e.Value != null)
            {
                ((AdvanceRequestModule)Module).ChangeAdvanceRequestType(e.Value.ToString());
            }
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            if (lookup.OldEditValue != e.Value.ToString())
            {
                int currencyID = 0;
                if (int.TryParse(e.Value.ToString(), out currencyID))
                {
                    ((AdvanceRequestModule)Module).ChangeCurrency(currencyID);
                }
            }
        }
    }
}
