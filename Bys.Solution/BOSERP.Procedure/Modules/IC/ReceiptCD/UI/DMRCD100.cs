using BOSComponent;
using System;
using System.ComponentModel;

namespace BOSERP.Modules.ReceiptCD.UI
{
    /// <summary>
    /// Summary description for DMRCD100
    /// </summary>
    public partial class DMRCD100 : BOSERPScreen
    {

        public DMRCD100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void bosLookupEdit1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((ReceiptCDModule)Module).ChangeReceiptCDAcceptanceType(e.Value.ToString());
            }
        }
        private void fld_lkeReceiptCDLotNo_QueryPopUp(object sender, CancelEventArgs e)
        {
            ((ReceiptCDModule)Module).GeneralDataSourceForLotNoLookupControl();
        }

        private void fld_btnLumber_Click(object sender, EventArgs e)
        {
            ((ReceiptCDModule)Module).GeneralProductForLumber();
        }

        private void fld_lkeFK_ICProductAttributeWoodTypeID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((ReceiptCDModule)Module).ChangeProductAttributeWoodTypeID(int.Parse(e.Value.ToString()));
            }
        }

        private void fld_lkeFK_GECountryID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((ReceiptCDModule)Module).ChangeGECountryID(int.Parse(e.Value.ToString()));
            }
        }

        private void fld_lkeFK_ICProductAttributeTTMTID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((ReceiptCDModule)Module).ChangeProductAttributeTTMTID(int.Parse(e.Value.ToString()));
            }
        }

        private void fld_lkeProductAttributeQualityID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((ReceiptCDModule)Module).ChangeProductAttributeQualityID(int.Parse(e.Value.ToString()));
            }
        }

        private void fld_txtICReceiptCDHeight_Validated(object sender, EventArgs e)
        {
            ((ReceiptCDModule)Module).ChangeReceiptCDHeight(int.Parse(fld_txtICReceiptCDHeight.EditValue.ToString()));
        }

        private void fld_lkeReceiptAcceptanceType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((ReceiptCDModule)Module).ChangeReceiptCDAcceptanceType(e.Value.ToString());
            }
        }

        private void fld_lkeFK_ICStockID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((ReceiptCDModule)Module).ChangeReceiptStock(int.Parse(e.Value.ToString()));
            }
        }




    }
}
