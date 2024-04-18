using System;

namespace BOSERP.Modules.FalseConditional.UI
{
    /// <summary>
    /// Summary description for DMLM100
    /// </summary>
    public partial class DMFC100 : BOSERPScreen
    {

        public DMFC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_txtMMFalseConditionalHyperLink_Click(object sender, EventArgs e)
        {
            string matchCode = Convert.ToString(fld_txtMMFalseConditionalHyperLink.EditValue);
            if (!string.IsNullOrEmpty(matchCode))
            {
                System.Diagnostics.Process.Start(matchCode);
            }
        }

        private void bosTextBox4_Validated(object sender, EventArgs e)
        {
            BOSComponent.BOSTextBox tb = (BOSComponent.BOSTextBox)sender;
            if (tb.OldEditValue != null && tb.OldEditValue != tb.EditValue)
            {
                ((FalseConditionalModule)Module).AddItemToFalseConditionalItemList();
            }
        }
    }
}
