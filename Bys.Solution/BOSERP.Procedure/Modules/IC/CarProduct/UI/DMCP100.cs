using BOSComponent;
using DevExpress.XtraEditors;
using System;

namespace BOSERP.Modules.CarProduct.UI
{
    /// <summary>
    /// Summary description for DMPD100
    /// </summary>
    public partial class DMCP100 : BOSERPScreen
    {
        public DMCP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lnkEditPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((CarProductModule)Module).ShowPriceLevelForm();
        }

        private void fld_lnkEditUnitOfMeasure_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((CarProductModule)Module).ShowMeasureOfUnits();
        }

        private void fld_bedICProductAttribute_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((CarProductModule)Module).ShowEditAttributeForm();
        }

        private void fld_btnMoveUp_Click(object sender, EventArgs e)
        {
            ((CarProductModule)Module).SortProductComponentList("MoveUp");
        }

        private void fld_btnMoveDown_Click(object sender, EventArgs e)
        {
            ((CarProductModule)Module).SortProductComponentList("MoveDown");
        }

        private void fld_lnkOpenSupplier_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((CarProductModule)Module).ShowSuppliersForm();
        }

        private void fld_lnkOpenBranchPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((CarProductModule)Module).ShowProductBranchPrice();
        }

        private void fld_lnkSetDefaultDesc_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((CarProductModule)Module).SetDefaultProductDesc();
        }

        private void fld_lnkEditPurchasePrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((CarProductModule)Module).EditPurchasePriceByCurrency();
        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ((CarProductModule)Module).ShowCategoryTree();
        }
        private void fld_lnkShowHistoryBranchPrice_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            ((CarProductModule)Module).ShowProductBranchPriceHistory();
        }

        private void fld_lkeICProductTrademark_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            if (lke.OldEditValue != lke.EditValue)
                ((CarProductModule)Module).ShowTrademarkInProductDesc((int)lke.OldEditValue, lke.Text);
        }
        public void fld_lkeFK_HREmployeeID1_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (lke != null)
            {
                lke.Properties.DataSource = ((CarProductModule)Module).GetDataForEmployees();
            }
        }
    }
}
