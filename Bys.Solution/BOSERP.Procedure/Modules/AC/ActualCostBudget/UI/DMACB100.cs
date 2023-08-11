using DevExpress.XtraEditors;
using System;

namespace BOSERP.Modules.ActualCostBudget.UI
{
    /// <summary>
    /// Summary description for DMACB100
    /// </summary>
    public partial class DMACB100 : BOSERPScreen
    {

        public DMACB100()
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
                    ((ActualCostBudgetModule)Module).ChangeCurrency(currencyID);
                }
            }
        }

        private void fld_txtACActualCostBudgetExchangeRate_Validated(object sender, EventArgs e)
        {
            if (fld_txtACActualCostBudgetExchangeRate.EditValue != null)
            {
                decimal exRate = 0;
                if (decimal.TryParse(fld_txtACActualCostBudgetExchangeRate.EditValue.ToString(), out exRate))
                {
                    ((ActualCostBudgetModule)Module).ChangeExchangeRate(exRate);
                }
            }
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((ActualCostBudgetModule)Module).GetDetailExcelTemplate();
        }

        private void bosButton2_Click(object sender, EventArgs e)
        {
            ((ActualCostBudgetModule)Module).ImportFromExcel();
        }
    }
}
