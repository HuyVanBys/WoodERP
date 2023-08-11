using BOSComponent;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.AssemblyShipment.UI
{
    /// <summary>
    /// Summary description for DMASH100
    /// </summary>
    public partial class DMASH100 : BOSERPScreen
    {

        public DMASH100()
        {
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID1_Validated(object sender, EventArgs e)
        {
            ((AssemblyShipmentModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((AssemblyShipmentModule)Module).AddItemToShipmentItemsList();
            }
        }

        private void fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((AssemblyShipmentModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((AssemblyShipmentModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void fld_lkeFK_ICImportAndExportReasonID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((AssemblyShipmentModule)Module).ChangeImportAndExportReason(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ICProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke == null)
                return;
            lke.Properties.DataSource = ((AssemblyShipmentModule)Module).GetDataSourceForProductLookupEdit();
        }
    }
}
