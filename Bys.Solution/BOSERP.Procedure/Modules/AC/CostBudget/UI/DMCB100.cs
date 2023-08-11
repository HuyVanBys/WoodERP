using DevExpress.XtraEditors;
using System;

namespace BOSERP.Modules.CostBudget.UI
{
    /// <summary>
    /// Summary description for DMCB100
    /// </summary>
    public partial class DMCB100 : BOSERPScreen
    {

        public DMCB100()
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
                    ((CostBudgetModule)Module).ChangeCurrency(currencyID);
                }
            }
        }

        private void fld_txtACCostBudgetExchangeRate_Validated(object sender, EventArgs e)
        {
            if (fld_txtACCostBudgetExchangeRate.EditValue != null)
            {
                decimal exRate = 0;
                if (decimal.TryParse(fld_txtACCostBudgetExchangeRate.EditValue.ToString(), out exRate))
                {
                    ((CostBudgetModule)Module).ChangeExchangeRate(exRate);
                }
            }
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((CostBudgetModule)Module).GetDetailExcelTemplate();
        }

        private void bosButton2_Click(object sender, EventArgs e)
        {
            ((CostBudgetModule)Module).ImportFromExcel();
        }

        private void bosDateEdit1_Validated(object sender, EventArgs e)
        {
            ((CostBudgetModule)Module).UpdateCostBudgetDate();
        }

        private void bosDateEdit2_Validated(object sender, EventArgs e)
        {
            ((CostBudgetModule)Module).UpdateCostBudgetDate();
        }
    }
}
