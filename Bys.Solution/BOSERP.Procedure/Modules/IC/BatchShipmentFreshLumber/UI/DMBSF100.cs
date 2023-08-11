using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchShipmentFreshLumber.UI
{
    /// <summary>
    /// Summary description for DMBSF100
    /// </summary>
    public partial class DMBSF100 : BOSERPScreen
    {

        public DMBSF100()
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
                ((BatchShipmentFreshLumberModule)Module).AddItemToShipmentItemsList();
            }
        }

        private void fld_lkeFK_ACObjectID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((BatchShipmentFreshLumberModule)Module).ChangeObject(e.Value.ToString());
            }
        }

        private void fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int stockID = 0;
                if (int.TryParse(e.Value.ToString(), out stockID))
                {
                    ((BatchShipmentFreshLumberModule)Module).SetShipmentItemStock(stockID);
                }
            }

        }

        private void fld_btnShowInventoryStock_Click(object sender, EventArgs e)
        {
            ((BatchShipmentFreshLumberModule)Module).ShownInventoryStocks();

        }

        private void fld_lkeFK_ICProductAttributeTTMTID_EditValueChanged(object sender, EventArgs e)
        {
            ((BatchShipmentFreshLumberModule)Module).UpdateTTMT(int.Parse(fld_lkeFK_ICProductAttributeTTMTID.EditValue.ToString()));
        }

        private void fld_lkeFK_MMBatchProductID_EditValueChanged(object sender, EventArgs e)
        {
            ((BatchShipmentFreshLumberModule)Module).UpdateBatchProductID(int.Parse(fld_lkeFK_MMBatchProductID.EditValue.ToString()));
        }

        private void fld_lkeFK_GECountryID_EditValueChanged(object sender, EventArgs e)
        {
            ((BatchShipmentFreshLumberModule)Module).UpdateGECountryID(int.Parse(fld_lkeFK_GECountryID.EditValue.ToString()));
        }

        private void fld_lkeFK_ICProductAttributeWoodTypeID_EditValueChanged(object sender, EventArgs e)
        {
            ((BatchShipmentFreshLumberModule)Module).UpdateWoodTypeID(int.Parse(fld_lkeFK_ICProductAttributeWoodTypeID.EditValue.ToString()));
        }

        //private void fld_lkeFK_MMOperationID_EditValueChanged(object sender, EventArgs e)
        //{

        //    ((BatchShipmentFreshLumberModule)Module).UpdateOperation(int.Parse(fld_lkeFK_MMOperationID.EditValue.ToString()));
        //}

        private void fld_lkeFK_MMOperationID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {

            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                int OperationID = 0;
                if (int.TryParse(e.Value.ToString(), out OperationID))
                {
                    ((BatchShipmentFreshLumberModule)Module).UpdateOperation(OperationID);
                }
            }
        }
    }
}
