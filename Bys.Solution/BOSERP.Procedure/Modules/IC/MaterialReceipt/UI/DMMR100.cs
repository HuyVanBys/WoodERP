using BOSComponent;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.MaterialReceipt.UI
{
    /// <summary>
    /// Summary description for DMMR100
    /// </summary>
    public partial class DMMR100 : BOSERPScreen
    {

        public DMMR100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeFK_ICProductID1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((MaterialReceiptModule)Module).AddItemToReceiptItemsList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((MaterialReceiptModule)Module).ShowBatchShipmentForReceipt();
        }

        private void fld_lkeFK_MMBatchProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((MaterialReceiptModule)Module).ChangeBatchProductItemList((int)e.Value);
            }
        }

        private void fld_lkeFK_MMOperationID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((MaterialReceiptModule)Module).ChangeOperationItemList((int)e.Value);
            }
        }

        private void fld_lkeFK_ICProductAttributeWoodTypeID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((MaterialReceiptModule)Module).ChangeWoodTypeItemList((int)e.Value);
            }
        }

        private void fld_txtICReceiptReceiptType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((MaterialReceiptModule)Module).ChangeReceiptReceiptType(e.Value.ToString());
            }
        }

        private void fld_txtICReceiptReceiptType_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.LookUpEdit lookupEdit = (DevExpress.XtraEditors.LookUpEdit)sender;
            string selectedValue = lookupEdit.EditValue == null ? string.Empty : lookupEdit.EditValue.ToString();
            ((MaterialReceiptModule)Module).UpdateProductLookupEditControlDataSource(selectedValue);
        }

        private void fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((MaterialReceiptModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_GECurrencyID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {

                ((MaterialReceiptModule)Module).ChangeGECurrency(e.Value.ToString());
            }
        }

        private void fld_txtICReceiptExchangeRate_Validated(object sender, EventArgs e)
        {
            ((MaterialReceiptModule)Module).ChangeExchangeRate();
        }

        private void fld_lkeFK_MMBatchProductItemID_QueryPopUp(object sender, CancelEventArgs e)
        {
            fld_lkeFK_MMBatchProductItemID.Properties.DataSource = ((MaterialReceiptModule)Module).GetBatchProductItemSerialDataSource();
        }

        private void fld_lkeFK_MMBatchProductItemID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                string result = ((MaterialReceiptModule)Module).ChangeBatchProductItem(int.Parse(e.Value.ToString()));
            }
        }

        private void fld_lkeFK_MMWorkShopID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((MaterialReceiptModule)Module).ChangeAllItemInfo(Convert.ToInt32(e.Value), 2);
            }
        }
        private void fld_lkeFK_MMWorkShopID_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (BOSApp.LookupTables.ContainsKey("MMWorkShops"))
            {
                DataSet ds = (DataSet)BOSApp.LookupTables["MMWorkShops"];
                if (ds != null)
                    fld_lkeFK_MMWorkShopID.Properties.DataSource = ds.Tables[0];
            }
        }

        private void fld_lkeFK_ICImportAndExportReasonID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((MaterialReceiptModule)Module).ChangeImportAndExportReason(Convert.ToInt32(e.Value));
            }
        }
    }
}
