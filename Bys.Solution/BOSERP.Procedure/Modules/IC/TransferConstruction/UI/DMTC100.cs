using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.TransferConstruction.UI
{
    /// <summary>
    /// Summary description for DMTC100
    /// </summary>
    public partial class DMTC100 : BOSERPScreen
    {

        public DMTC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID_Validated(object sender, EventArgs e)
        {
            ((Modules.TransferConstruction.TransferConstructionModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_lkeFK_ICFromStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((TransferConstructionModule)Module).ChangeSourceStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ICToStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((TransferConstructionModule)Module).ChangeTargetStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((TransferConstructionModule)Module).AddItemToTransferItemsList();
            }
        }

        private void fld_lkeFK_MMOperationID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((TransferConstructionModule)Module).ChangeOperationItemList((int)e.Value);
            }
        }

        private void fld_lkeFK_MMBatchProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((TransferConstructionModule)Module).ChangeBatchProductItemList((int)e.Value);
            }
        }

        private void fld_btnCreateDocument_Click(object sender, EventArgs e)
        {
            ((TransferConstructionModule)Module).GenerateDocument();
        }

        private void fld_btnSaveAccounting_Click(object sender, EventArgs e)
        {
            ((TransferConstructionModule)Module).SaveAccounting();
        }
    }
}
