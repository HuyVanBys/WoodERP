using BOSComponent;
using System;

namespace BOSERP.Modules.InventoryLeadger.UI
{
    /// <summary>
    /// Summary description for DMIL100
    /// </summary>
    public partial class DMIL100 : BOSERPScreen
    {
        public DMIL100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnInventoryCard_Click(object sender, EventArgs e)
        {
            int productID = 0;
            if (fld_lkeICProductID.EditValue != null) int.TryParse(fld_lkeICProductID.EditValue.ToString(), out productID);
            if (productID > 0)
                ((InventoryLeadgerModule)this.Module).InventoryLeadger();
            else
                BOSApp.ShowMessage("Vui lòng chọn sản phẩm!");
        }

        private void fld_lkeICProductID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            fld_lkeICProductSerieID.Enabled = false;
            fld_lkeICProductSerieID.EditValue = 0;
            int productID = 0;
            if (e.Value != null) int.TryParse(e.Value.ToString(), out productID);
            if (productID > 0)
            {
                ((InventoryLeadgerModule)Module).GetDataSerieList(productID);
                fld_lkeICProductSerieID.Enabled = true;
            }
        }
    }
}
