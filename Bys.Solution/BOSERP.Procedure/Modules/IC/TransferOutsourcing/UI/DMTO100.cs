using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.TransferOutsourcing.UI
{
    /// <summary>
    /// Summary description for DMTO100
    /// </summary>
    public partial class DMTO100 : BOSERPScreen
    {

        public DMTO100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID_Validated(object sender, EventArgs e)
        {
            ((Modules.TransferOutsourcing.TransferOutsourcingModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_lkeFK_ICFromStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((TransferOutsourcingModule)Module).ChangeSourceStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ICToStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((TransferOutsourcingModule)Module).ChangeTargetStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((TransferOutsourcingModule)Module).AddItemToTransferItemsList();
            }
        }

        private void fld_lkeFK_MMOperationID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((TransferOutsourcingModule)Module).ChangeOperationItemList((int)e.Value);
            }
        }

        private void fld_lkeFK_MMBatchProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((TransferOutsourcingModule)Module).ChangeBatchProductItemList((int)e.Value);
            }
        }

        private void fld_btnShowInventoryStock_Click(object sender, EventArgs e)
        {
            ((TransferOutsourcingModule)Module).ShownInventoryStocks();
        }

        private void fld_btnCreateDocument_Click(object sender, EventArgs e)
        {
            ((TransferOutsourcingModule)Module).GenerateDocument();
        }

        private void fld_btnSaveAccounting_Click(object sender, EventArgs e)
        {
            ((TransferOutsourcingModule)Module).SaveAccounting();
        }

        private void fld_btnAddLumberProduct_Click(object sender, EventArgs e)
        {
            ((TransferOutsourcingModule)Module).ShowItemFromBatchProductLumberProduct();
        }

        private void fld_lkeFK_ICFromStockID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((TransferOutsourcingModule)Module).ChangeSourceStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ICToStockID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((TransferOutsourcingModule)Module).ChangeTargetStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_btnAddItemFromBatchProduct_Click(object sender, EventArgs e)
        {
            ((TransferOutsourcingModule)Module).ShowItemFromBatchProduct();
        }
    }
}
