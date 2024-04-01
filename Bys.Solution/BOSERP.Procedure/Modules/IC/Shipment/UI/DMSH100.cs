using BOSComponent;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.Shipment.UI
{
    /// <summary>
    /// Summary description for DMSH100
    /// </summary>
    public partial class DMSH100 : BOSERPScreen
    {

        public DMSH100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID1_Validated(object sender, EventArgs e)
        {
            ((Modules.Shipment.ShipmentModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((ShipmentModule)Module).AddItemToShipmentItemsList();
            }
        }

        private void fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((ShipmentModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((ShipmentModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void fld_lkeFK_ICImportAndExportReasonID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((ShipmentModule)Module).ChangeImportAndExportReason(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ICProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke == null)
                return;
            string type = fld_lkeICShipmentProductType.EditValue != null ? fld_lkeICShipmentProductType.EditValue.ToString() : string.Empty;
            lke.Properties.DataSource = ((ShipmentModule)Module).GetDataSourceForProductLookupEdit(type);
        }

        private void fld_lkeFK_MMBatchProductID_Validated(object sender, EventArgs e)
        {
            ((ShipmentModule)Module).ChangeBatchProduct();
        }

        private void Fld_lkeFK_ACSegmentID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((ShipmentModule)Module).ChangeSegment(Convert.ToInt32(e.Value));
            }
        }

        private void Fld_lkeICShipmentProductType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((ShipmentModule)Module).ChangeInputType(e.Value.ToString());
            }
        }

        private void fld_lkeFK_ACUnfinishedConstructionCostID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((ShipmentModule)Module).ChangeUnfinishedConstructionCost(Convert.ToInt32(e.Value));
            }
        }

        private void fld_btnAutoSelectProductSerialNo_Click(object sender, EventArgs e)
        {
            ((ShipmentModule)Module).AutoSelectProductSerialNo();
        }

        private void fld_btnExportTemplate_Click(object sender, EventArgs e)
        {
            ((ShipmentModule)Module).ExportShipmentItemTemplate();
        }

        private void fld_btnImportTemplate_Click(object sender, EventArgs e)
        {
            ((ShipmentModule)Module).ImportShipmentItemExcel();
        }
    }
}
