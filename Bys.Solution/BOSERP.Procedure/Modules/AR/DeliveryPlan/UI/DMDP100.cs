using BOSComponent;
using System;
using System.Drawing;

namespace BOSERP.Modules.DeliveryPlan.UI
{
    /// <summary>
    /// Summary description for DMDP100
    /// </summary>
    public partial class DMDP100 : BOSERPScreen
    {

        public DMDP100()
        {
            //
            // Required designer variable
            //
            DevExpress.XtraRichEdit.RichEditControlCompatibility.DefaultFontName = "Arial"; DevExpress.XtraRichEdit.RichEditControlCompatibility.DefaultFontSize = 10f;
            InitializeComponent();
        }

        private void fld_btnDistributionTruck_Click(object sender, EventArgs e)
        {
            ((DeliveryPlanModule)Module).AddDeliveryPlanTrucksList();
        }

        private void fld_btnDistributionEmployee_Click(object sender, EventArgs e)
        {
            ((DeliveryPlanModule)Module).ShowTasksList();
        }

        private void fld_btnAddProduct_Click(object sender, EventArgs e)
        {
            ((DeliveryPlanModule)Module).AddProduct();
        }

        private void fld_btnAddWork_Click(object sender, EventArgs e)
        {
            ((DeliveryPlanModule)Module).AddDeliveryPlanWork();
        }

        private void fld_btnAddMaterial_Click(object sender, EventArgs e)
        {
            ((DeliveryPlanModule)Module).AddDeliveryPlanWorkMaterial();
        }

        private void fld_btnAddAsset_Click(object sender, EventArgs e)
        {
            ((DeliveryPlanModule)Module).AddDeliveryPlanWorkAsset();
        }

        private void fld_btnAttributionItemTruck_Click(object sender, EventArgs e)
        {
            ((DeliveryPlanModule)Module).AttributionItemTruck();
        }

        private void fld_btnAttributionSaleOrderTruck_Click(object sender, EventArgs e)
        {
            ((DeliveryPlanModule)Module).AttributionSaleOrderTruck();
        }

        private void fld_dteARDeliveryPlanBeginDate_Validated(object sender, EventArgs e)
        {
            ((DeliveryPlanModule)Module).ChangeDeliveryPlanBeginDate();
        }

        private void Fld_lkeFK_ICStockID1_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((DeliveryPlanModule)Module).ChangeStock(Convert.ToInt32(e.Value));
            }
        }

        private void Fld_lkeFK_ICProductAttributeTTMTID_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((DeliveryPlanModule)Module).ChangeProductAttributeTTMT(Convert.ToInt32(e.Value));
            }
        }

        private void Fld_lkeDeliveryPlanProductType_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != lke.OldEditValue)
            {
                ((DeliveryPlanModule)Module).ChangeInputType(e.Value.ToString());
            }
        }
    }
}
