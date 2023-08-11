using BOSComponent;
using System;

namespace BOSERP.Modules.SaleCost.UI
{
    /// <summary>
    /// Summary description for DMSOC100
    /// </summary>
    public partial class DMSOC100 : BOSERPScreen
    {

        public DMSOC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_txtACDocumentExchangeRate_EditValueChanged(object sender, EventArgs e)
        {
            ((SaleCostModule)Module).ChangeExchangeRate();
        }

        private void bosLookupEdit8_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {

        }

        private void fld_tcDetail_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            ((SaleCostModule)Module).FocusTabName = fld_tcDetail.SelectedTabPage.Name;
        }

        private void fld_lkeFK_ACObjectID_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            ((SaleCostModule)Module).ChangeObject();
        }

        private void bosButton6_Click(object sender, EventArgs e)
        {
            ((SaleCostModule)Module).AddInvoice();
        }

        private void fld_lkeFK_PMProjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int projectID = 0;
                if (int.TryParse(e.Value.ToString(), out projectID))
                {
                    ((SaleCostModule)Module).ChangeProject(projectID);
                }
            }
        }

        private void bosTextBox12_EditValueChanged(object sender, EventArgs e)
        {
            ((SaleCostModule)Module).ChangeExchangeRate();
        }
    }
}
