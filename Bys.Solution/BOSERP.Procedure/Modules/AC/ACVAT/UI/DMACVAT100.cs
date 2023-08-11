using BOSComponent;
using System;
using System.ComponentModel;

namespace BOSERP.Modules.ACVAT.UI
{
    /// <summary>
    /// Summary description for DMAS100
    /// </summary>
    public partial class DMACVAT100 : BOSERPScreen
    {

        public DMACVAT100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null)
            {
                ((ACVATModule)Module).ChangeObject(e.Value.ToString());
            }
            else if (e.Value == null)
            {
                ((ACVATModule)Module).ChangeObject("");
            }
        }

        private void fld_txtACVATAmount_Validated(object sender, EventArgs e)
        {
            ((ACVATModule)Module).ChangeVATAmount();
        }

        private void fld_txtACVATTaxPercent_Validated(object sender, EventArgs e)
        {
            ((ACVATModule)Module).ChangeVATTaxPercent();
        }

        private void fld_txtACVATTaxAmount_Validated(object sender, EventArgs e)
        {
            ((ACVATModule)Module).ChangeVATTaxAmount();
        }

        private void fld_lkeACVATDocumentType_QueryPopUp(object sender, CancelEventArgs e)
        {

        }

        private void fld_lkeACVATDocumentType_EditValueChanged(object sender, EventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke.EditValue != lke.OldEditValue)
            {
                ((ACVATModule)Module).ChangeVATDocumentType(fld_lkeACVATDocumentType.EditValue.ToString());
            }
        }

        private void fld_lkeACVATInvoiceType_EditValueChanged(object sender, EventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke.EditValue != lke.OldEditValue)
            {
                string type = string.Empty;
                if (fld_lkeACVATInvoiceType.EditValue != null)
                    type = fld_lkeACVATInvoiceType.EditValue.ToString();
                fld_lkeACVATDocumentType.Properties.DataSource = ((ACVATModule)Module).GetVATDocumentTypeDatasource(type);
                fld_lkeACVATDocumentType.Properties.DisplayMember = "ADConfigText";
                fld_lkeACVATDocumentType.Properties.ValueMember = "ADConfigKeyValue";
            }
        }
    }
}
