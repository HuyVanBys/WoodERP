using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.MaterialShipmentConstruction.UI
{
    /// <summary>
    /// Summary description for DMMSC100
    /// </summary>
    public partial class DMMSC100 : BOSERPScreen
    {

        public DMMSC100()
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
                ((MaterialShipmentConstructionModule)Module).AddItemToShipmentItemsList();
            }
        }

        private void fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((MaterialShipmentConstructionModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeICShipmentShipmentType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            //BOSLookupEdit lke = (BOSLookupEdit)sender;
            //if (e.Value != lke.OldEditValue)
            //{
            //    ((MaterialShipmentConstructionModule)Module).ChangeAllocationProposalProductType(e.Value.ToString());
            //}      
        }

        private void fld_lkeICShipmentShipmentType_EditValueChanged(object sender, EventArgs e)
        {
            //MaterialShipmentEntities entity = ((MaterialShipmentConstructionModule)Module).CurrentModuleEntity as MaterialShipmentEntities;
            //ICShipmentsInfo mainObject = entity.MainObject as ICShipmentsInfo;
            //((MaterialShipmentConstructionModule)Module).ChangeAllocationProposalProductType(mainObject.ICShipmentShipmentType);
        }

        private void fld_lkeFK_MMOperationID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((MaterialShipmentConstructionModule)Module).ChangeOperation(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_HRDepartmentID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((MaterialShipmentConstructionModule)Module).ChangeDepartment(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ICImportAndExportReasonID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((MaterialShipmentConstructionModule)Module).ChangeImportAndExportReason(Convert.ToInt32(e.Value));
            }
        }
    }
}
