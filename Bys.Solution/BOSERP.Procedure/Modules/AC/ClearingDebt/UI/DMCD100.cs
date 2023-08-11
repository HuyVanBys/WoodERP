using DevExpress.XtraEditors;
using System;

namespace BOSERP.Modules.ClearingDebt.UI
{
    /// <summary>
    /// Summary description for DMDC100
    /// </summary>
    public partial class DMCD100 : BOSERPScreen
    {

        public DMCD100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        //public override Control InitializeControl(Control ctrl)
        //{
        //    ctrl = base.InitializeControl(ctrl);

        //    if (ctrl.Name == "fld_lkeFK_ACObjectID2")
        //    {
        //        (ctrl as BOSLookupEdit).Properties.ValueMember = "ACObjectAccessKey2";
        //    }
        //    return ctrl;
        //}

        private void fld_lkeFK_ACObjectID_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (e.Value != null)
                ((ClearingDebtModule)Module).ChangeFK_ACObjectID(e.Value.ToString());
            else
                ((ClearingDebtModule)Module).ChangeFK_ACObjectID(string.Empty);
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            if (lookup.OldEditValue != e.Value.ToString())
            {
                int currencyID = 0;
                if (int.TryParse(e.Value.ToString(), out currencyID))
                {
                    ((ClearingDebtModule)Module).ChangeCurrency(currencyID);
                }
            }
        }

        private void fld_btnInvoice_Click(object sender, EventArgs e)
        {
            ((ClearingDebtModule)Module).ShowInvoiceList();
        }

        private void fld_lkeFK_ACObjectID2_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (e.Value != null)
            {
                string object2AccessKey = e.Value.ToString();
                ((ClearingDebtModule)Module).ChangeObject2(object2AccessKey);
            }
            else
            {
                string object2AccessKey = string.Empty;
                ((ClearingDebtModule)Module).ChangeObject2(object2AccessKey);
            }
        }

        private void fld_btnInvoiceIn_Click(object sender, EventArgs e)
        {
            ((ClearingDebtModule)Module).ShowInvoiceInList();
        }

        private void fld_txtACClearingDebtAmountClearing_Validated(object sender, EventArgs e)
        {
            if (!((ClearingDebtModule)Module).UpdateTotalAmount())
            {
                ACClearingDebtsInfo mainObject = (ACClearingDebtsInfo)((ClearingDebtModule)Module).CurrentModuleEntity.MainObject;
                if (fld_txtACClearingDebtAmountClearing.OldEditValue != null)
                {
                    mainObject.ACClearingDebtAmountClearing = (String.IsNullOrEmpty(fld_txtACClearingDebtAmountClearing.OldEditValue.ToString()) ? 0 : Convert.ToDecimal(fld_txtACClearingDebtAmountClearing.OldEditValue));
                }
                ((ClearingDebtModule)Module).UpdateTotalAmount();
            }
        }
    }
}
