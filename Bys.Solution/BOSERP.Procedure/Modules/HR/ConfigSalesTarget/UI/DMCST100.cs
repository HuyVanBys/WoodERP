using BOSComponent;
using System;

namespace BOSERP.Modules.ConfigSalesTarget.UI
{
    /// <summary>
    /// Summary description for DMCTP100
    /// </summary>
    public partial class DMCST100 : BOSERPScreen
    {

        public DMCST100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_dgcHRConfigSalesTargetItemsGridControl_Validated(object sender, EventArgs e)
        {
            ((ConfigSalesTargetModule)Module).ConfigSalesTargetItemsGridControl.InvalidateData();
        }

        private void fld_lkeHRConfigSalesTargetType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((ConfigSalesTargetModule)Module).ChangeConfigSalesTargetType(e.Value.ToString());
            }
        }

        private void fld_lkeHRConfigSalesTargetApplicableSubjects_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((ConfigSalesTargetModule)Module).ChangeConfigSalesTargetApplicableSubjects(e.Value.ToString());
            }
        }

        private void fld_lkeHRConfigSalesTargetApplyFromDate_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSDateEdit lke = (BOSDateEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                DateTime dt = DateTime.Now;
                if (DateTime.TryParse(e.Value.ToString(), out dt))
                {
                    ((ConfigSalesTargetModule)Module).ChangeConfigSalesTargetApplyFromDate(dt);
                }
            }
        }

        private void fld_lkeHRConfigSalesTargetApplyToDate_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSDateEdit lke = (BOSDateEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                DateTime dt = DateTime.Now;
                if (DateTime.TryParse(e.Value.ToString(), out dt))
                {
                    ((ConfigSalesTargetModule)Module).ChangeConfigSalesTargetApplyToDate(dt);
                }
            }
        }

        private void fld_lkeFK_HRConfigSalesTargetParentID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((ConfigSalesTargetModule)Module).ChangeConfigSalesTargetParent(int.Parse(e.Value.ToString()));
            }
        }
    }
}
