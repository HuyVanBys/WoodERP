using DevExpress.XtraEditors;
using System;

namespace BOSERP.Modules.RevenueBudget.UI
{
    /// <summary>
    /// Summary description for DMRB100
    /// </summary>
    public partial class DMRB100 : BOSERPScreen
    {

        public DMRB100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;

            if (lke.OldEditValue != e.Value)
            {
                int currencyID = 0;
                if (int.TryParse(e.Value.ToString(), out currencyID))
                {
                    ((RevenueBudgetModule)Module).ChangeCurrency(currencyID);
                }
            }
        }

        private void fld_txtACRevenueBudgetExchangeRate_Validated(object sender, EventArgs e)
        {
            if (fld_txtACRevenueBudgetExchangeRate.EditValue != null)
            {
                decimal exRate = 0;
                if (decimal.TryParse(fld_txtACRevenueBudgetExchangeRate.EditValue.ToString(), out exRate))
                {
                    ((RevenueBudgetModule)Module).ChangeExchangeRate(exRate);
                }
            }
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((RevenueBudgetModule)Module).GetDetailExcelTemplate();
        }

        private void bosButton2_Click(object sender, EventArgs e)
        {
            ((RevenueBudgetModule)Module).ImportFromExcel();
        }
    }
}
