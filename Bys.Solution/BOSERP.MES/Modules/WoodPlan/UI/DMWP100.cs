using BOSComponent;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.WoodPlan.UI
{
    /// <summary>
    /// Summary description for DMWP100
    /// </summary>
    public partial class DMWP100 : BOSERPScreen
    {

        public DMWP100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_lkeICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int productID = 0;
                if (int.TryParse(fld_lkeICProductID.EditValue.ToString(), out productID))
                {
                    ((WoodPlanModule)Module).AddNewItem(productID);
                }
            }
        }

        private void fld_btnUpdateInventoryStock_Click(object sender, EventArgs e)
        {
            ((WoodPlanModule)Module).ShowInventoryTotalQty();
        }

        private void bosButton1_Click(object sender, EventArgs e)
        {
            ((WoodPlanModule)Module).ShowBathProduct();
        }

        private void fld_btnChangeMaterials_Click(object sender, EventArgs e)
        {
            ((WoodPlanModule)Module).ChangeMaterials();
        }

        private void fld_lkeMaterials_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            ((WoodPlanModule)Module).UpdateTotalMaterialQty();

        }

        private void fld_lkeFK_MMWorkShopID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((WoodPlanModule)Module).WorkShopValueChanged(Convert.ToInt32(e.Value));
            }
        }

        private void fld_lkeFK_MMLineID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ((WoodPlanModule)Module).LineValueChanged(Convert.ToInt32(e.Value));
            }
        }
    }
}
