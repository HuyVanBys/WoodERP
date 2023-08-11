using BOSComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.SemiProductShipment.UI
{
    /// <summary>
    /// Summary description for DMSPSM100
    /// </summary>
    public partial class DMSPSM100 : BOSERPScreen
    {
        public List<ICProductsInfo> ListProduct = new List<ICProductsInfo>();
        public DMSPSM100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }


        private void fld_lkeFK_MMBatchProductID_EditValueChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (int.TryParse(fld_lkeFK_MMBatchProductID.EditValue.ToString(), out i))
            {
                ((SemiProductShipmentModule)Module).BatchProductChange(i);
            }
        }

        private void fld_btnShowReceiptList_Click(object sender, EventArgs e)
        {
            ((SemiProductShipmentModule)Module).ShowReceiptList(false);
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((SemiProductShipmentModule)Module).AddItemToShipmentItemsList();
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((SemiProductShipmentModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((SemiProductShipmentModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_MMOperationID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((SemiProductShipmentModule)Module).ChangeOperation(Convert.ToInt32(e.Value));
            }
        }

        private void fld_btnShowInventoryStock_Click(object sender, EventArgs e)
        {
            ((SemiProductShipmentModule)Module).ShownInventoryStocks();
        }

        private void fld_lkeFK_MMBatchProductTrasnferID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                GeneralProductInControl(e.Value.ToString());
            }
        }
        public void GeneralProductInControl(string ChangeBatchProductID)
        {
            int tempID = 0;
            int.TryParse(ChangeBatchProductID, out tempID);
            ICProductsController objProductsController = new ICProductsController();
            ListProduct = objProductsController.GetListProductByBatchProductID(tempID);
            //fld_lkeICProductTrasnferID.Properties.DataSource = ListProduct;
        }

        private void fld_lkeICShipmentTypeCombo_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                // ((SemiProductShipmentModule)Module).ChangeShipmentTypeCombo(e.Value.ToString());
            }
        }
        private void fld_lkeFK_ICImportAndExportReasonID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((SemiProductShipmentModule)Module).ChangeImportAndExportReason(Convert.ToInt32(e.Value));
            }
        }

        private void Fld_lkeFK_MMOperationID_QueryPopUp(object sender, CancelEventArgs e)
        {
            ((SemiProductShipmentModule)Module).InitializeOperationlookupDataSource();
        }

        private void fld_lkeFK_MMReceiveOperationID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((SemiProductShipmentModule)Module).ChangeAllItemInfo(Convert.ToInt32(e.Value), 1);
            }
        }

        private void fld_lkeFK_MMWorkShopID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((SemiProductShipmentModule)Module).ChangeAllItemInfo(Convert.ToInt32(e.Value), 2);
            }
        }

        private void fld_lkeFK_LineID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((SemiProductShipmentModule)Module).ChangeAllItemInfo(Convert.ToInt32(e.Value), 3);
            }
        }

        private void fld_lkeFK_HRDepartmentRoomGroupItemID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((SemiProductShipmentModule)Module).ChangeAllItemInfo(Convert.ToInt32(e.Value), 4);
            }
        }

        private void fld_lkeFK_MMMachineUnitID_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (BOSApp.LookupTables.ContainsKey("MMMachineUnits"))
            {
                DataSet ds = (DataSet)BOSApp.LookupTables["MMMachineUnits"];
                if (ds != null)
                    fld_lkeFK_MMMachineUnitID.Properties.DataSource = ds.Tables[0];
            }
        }

        private void fld_lkeFK_MMReceiveOperationID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int operationID = 0;
            if (fld_lkeFK_MMOperationID.EditValue != null)
            {
                int.TryParse(fld_lkeFK_MMOperationID.EditValue.ToString(), out operationID);
            }
            fld_lkeFK_MMReceiveOperationID.Properties.DataSource = ((SemiProductShipmentModule)Module).InitializeReceiptOperationDataSource(operationID);
        }

        private void fld_lkeFK_MMMachineUnitID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((SemiProductShipmentModule)Module).ChangeAllItemInfo(Convert.ToInt32(e.Value), 5);
            }
        }

        private void fld_lkeFK_APPurchaseOrderID_QueryPopUp(object sender, CancelEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke == null)
                return;

            List<APPurchaseOrdersInfo> purchareOrderList = ((SemiProductShipmentModule)Module).GetPurcharseOrderOfBatchProduct();
            purchareOrderList.Insert(0, new APPurchaseOrdersInfo());
            lke.Properties.DataSource = purchareOrderList;
        }
    }
}
