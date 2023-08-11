using BOSComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;
namespace BOSERP.Modules.Transfer.UI
{
    /// <summary>
    /// Summary description for DMTS100
    /// </summary>
    public partial class DMTS100 : BOSERPScreen
    {

        public DMTS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_HREmployeeID_Validated(object sender, EventArgs e)
        {
            ((Modules.Transfer.TransferModule)this.Module).ChangeStaff(sender, e);
        }

        private void fld_lkeFK_ICFromStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((TransferModule)Module).ChangeSourceStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ICToStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((TransferModule)Module).ChangeTargetStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((TransferModule)Module).AddItemToTransferItemsList();
            }
        }

        private void fld_lkeFK_MMOperationID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((TransferModule)Module).ChangeOperationItemList((int)e.Value);
            }
        }

        private void fld_lkeFK_MMBatchProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((TransferModule)Module).ChangeBatchProductItemList((int)e.Value);
            }
        }

        private void fld_btnShowInventoryStock_Click(object sender, EventArgs e)
        {
            ((TransferModule)Module).ShownInventoryStocks();
        }

        private void fld_btnCreateDocument_Click(object sender, EventArgs e)
        {
            ((TransferModule)Module).GenerateDocument();
        }

        private void fld_btnSaveAccounting_Click(object sender, EventArgs e)
        {
            ((TransferModule)Module).SaveAccounting();
        }

        private void fld_lkeFK_ICProductID_QueryCloseUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke == null)
                return;

            lke.Properties.DataSource = BOSApp.CurrentProductList;
        }

        private void fld_lkeFK_APPurchaseOrderID_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke == null)
                return;

            List<APPurchaseOrdersInfo> purchareOrderList = ((TransferModule)Module).GetPurcharseOrderOfBatchProduct();
            purchareOrderList.Insert(0, new APPurchaseOrdersInfo());
            lke.Properties.DataSource = purchareOrderList;
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value == null)
            {
                ((TransferModule)Module).ChangeObject(string.Empty);
            }
            else if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((TransferModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void fld_btnImportTemplate_Click(object sender, EventArgs e)
        {
            ((TransferModule)Module).ImportTransferItem();
        }

        private void fld_btnAutoSelectProductSerialNo_Click(object sender, EventArgs e)
        {
            ((TransferModule)Module).AutoSelectProductSerialNo();
        }
    }
}
