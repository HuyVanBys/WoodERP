using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.BillOfLading.UI
{
    /// <summary>
    /// Summary description for DMBOL100
    /// </summary>
    public partial class DMBOL100 : BOSERPScreen
    {

        public DMBOL100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }
        private void fld_txtAPBillOfLadingExchangeRate_Validated(object sender, EventArgs e)
        {

            ((BillOfLadingModule)Module).ChangeExchangeRate();
        }

        private void fld_txtAPBillOfLadingImportTaxPercent_Validated(object sender, EventArgs e)
        {
            if (fld_txtAPBillOfLadingImportTaxPercent.EditValue != fld_txtAPBillOfLadingImportTaxPercent.OldEditValue)
                if (MessageBox.Show(CommonLocalizedResources.ChangeAllItemMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ((BillOfLadingModule)Module).ChangeImportTaxPercent(true);
                }
                else
                {
                    fld_txtAPBillOfLadingImportTaxPercent.EditValue = fld_txtAPBillOfLadingImportTaxPercent.OldEditValue;
                }
        }

        private void fld_txtAPBillOfLadingVATTaxPercent_Validated(object sender, EventArgs e)
        {
            if (fld_txtAPBillOfLadingVATTaxPercent.EditValue != fld_txtAPBillOfLadingVATTaxPercent.OldEditValue)
                if (MessageBox.Show(CommonLocalizedResources.ChangeAllItemMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ((BillOfLadingModule)Module).ChangeVATTaxPercent(true);
                }
                else
                {
                    fld_txtAPBillOfLadingVATTaxPercent.EditValue = fld_txtAPBillOfLadingVATTaxPercent.OldEditValue;
                }
        }

        private void fld_txtAPBillOfLadingConsumptionTaxPercent_Validated(object sender, EventArgs e)
        {
            if (fld_txtAPBillOfLadingConsumptionTaxPercent.EditValue != fld_txtAPBillOfLadingConsumptionTaxPercent.OldEditValue)
                if (MessageBox.Show(CommonLocalizedResources.ChangeAllItemMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ((BillOfLadingModule)Module).ChangeConsumptionTaxPercent(true);
                }
                else
                {
                    fld_txtAPBillOfLadingConsumptionTaxPercent.EditValue = fld_txtAPBillOfLadingConsumptionTaxPercent.OldEditValue;
                }
        }

        private void fld_txtAPBillOfLadingEnviromentTaxPercent_Validated(object sender, EventArgs e)
        {
            if (fld_txtAPBillOfLadingEnviromentTaxPercent.EditValue != fld_txtAPBillOfLadingEnviromentTaxPercent.OldEditValue)
                if (MessageBox.Show(CommonLocalizedResources.ChangeAllItemMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ((BillOfLadingModule)Module).ChangeEnviromentTaxPercent(true);
                }
                else
                {
                    fld_txtAPBillOfLadingEnviromentTaxPercent.EditValue = fld_txtAPBillOfLadingEnviromentTaxPercent.OldEditValue;
                }
        }
    }
}
