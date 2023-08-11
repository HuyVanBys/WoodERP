using System;

namespace BOSERP.Modules.PriceAdjustment.UI
{
    /// <summary>
    /// Summary description for DMPAJ100
    /// </summary>
    public partial class DMPAJ100 : BOSERPScreen
    {

        public DMPAJ100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }
        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            ((PriceAdjustmentModule)Module).ShowFilter();
        }

        private void bosTextBox2_Validated(object sender, EventArgs e)
        {
            ((PriceAdjustmentModule)Module).ValidatedTotalCost();
        }
    }
}
