using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using BOSComponent;

namespace BOSERP.Modules.DiscountProgram.UI
{
    /// <summary>
    /// Summary description for DMDP100
    /// </summary>
    public partial class DMDP100 : BOSERPScreen
    {

        public DMDP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            AccObjectLookupEdit lke = (AccObjectLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                //((DiscountProgramModule)Module).ChangeObject(Convert.ToString(e.Value));
            }
        }

        private void Fld_lkeARDiscountProgramIsExhibit_CheckedChanged(object sender, EventArgs e)
        {
            BOSCheckEdit checkEdit = (BOSCheckEdit)sender;
            if (checkEdit == null)
                return;

            ((DiscountProgramModule)Module).ResetDiscountProgramTarget(checkEdit.Checked);
        }

        private void Fld_lkeARDiscountProgramType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((DiscountProgramModule)Module).ChangeDiscountProgramType(e.Value.ToString());
            }
        }

        private void Fld_btnChooseProduct_Click(object sender, EventArgs e)
        {
            ((DiscountProgramModule)Module).ChooseProduct();
        }

        private void Fld_lkeARDiscountProgramApplyType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((DiscountProgramModule)Module).ChangeDiscountProgramApplyType(e.Value.ToString());
            }
        }

        private void Fld_lkeARDiscountProgramApplyOn_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((DiscountProgramModule)Module).ChangeDiscountProgramApplyOn(e.Value.ToString());
            }
        }

        private void Fld_lkeFK_ARCustomerDistributionChannelID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int distributionChannelID = 0;
                Int32.TryParse(e.Value.ToString(), out distributionChannelID);
                ((DiscountProgramModule)Module).ChangeDistributionChannel(distributionChannelID);
            }
        }

        private void Fld_txtARDiscountProgramItemValue_Validated(object sender, EventArgs e)
        {
            ((DiscountProgramModule)Module).ChangeProgramItemValue();
        }

        private void Fld_chkARDiscountProgramIsExhibit_Click(object sender, EventArgs e)
        {
            BOSCheckEdit checkEdit = (BOSCheckEdit)sender;
            if (checkEdit == null)
                return;
            
            if (((DiscountProgramModule)Module).ChangeDiscountProgramIsExhibit(checkEdit.Checked))
                checkEdit.Checked = !checkEdit.Checked;
        }

        private void Fld_chkARDiscountProgramIsExhibit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Fld_chkARDiscountProgramIsVoucher_CheckedChanged(object sender, EventArgs e)
        {
            fld_txtARDiscountProgramCode.Enabled = fld_chkARDiscountProgramIsVoucher.Checked;
            fld_txtARDiscountProgramCode.BackColor = fld_chkARDiscountProgramIsVoucher.Checked ? Color.White : Color.WhiteSmoke;
        }
    }
}
