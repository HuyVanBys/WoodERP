using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.OutsourcingShipment.UI
{
    /// <summary>
    /// Summary description for DMOS100
    /// </summary>
    public partial class DMOS100 : BOSERPScreen
    {

        public DMOS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((OutsourcingShipmentModule)Module).AddItemToShipmentItemsList();
            }
        }

        private void fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((OutsourcingShipmentModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeICShipmentShipmentType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            //BOSLookupEdit lke = (BOSLookupEdit)sender;
            //if (e.Value != lke.OldEditValue)
            //{
            //    ((OutsourcingShipmentModule)Module).ChangeAllocationProposalProductType(e.Value.ToString());
            //}      
        }

        private void fld_lkeICShipmentShipmentType_EditValueChanged(object sender, EventArgs e)
        {
            //MaterialShipmentEntities entity = ((OutsourcingShipmentModule)Module).CurrentModuleEntity as MaterialShipmentEntities;
            //ICShipmentsInfo mainObject = entity.MainObject as ICShipmentsInfo;
            //((OutsourcingShipmentModule)Module).ChangeAllocationProposalProductType(mainObject.ICShipmentShipmentType);
        }

        private void fld_lkeFK_MMOperationID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((OutsourcingShipmentModule)Module).ChangeOperation(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_HRDepartmentID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((OutsourcingShipmentModule)Module).ChangeDepartment(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ICImportAndExportReasonID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((OutsourcingShipmentModule)Module).ChangeImportAndExportReason(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ICProductID2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((OutsourcingShipmentModule)Module).AddItemToMaterialShipmentItemsList();
            }
        }
    }
}
