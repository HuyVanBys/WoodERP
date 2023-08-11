using System;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductionPlanning.UI
{
    /// <summary>
    /// Summary description for DMOSS100
    /// </summary>
    public partial class DMOSS100 : BOSERPScreen
    {

        public DMOSS100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnChosePi_Click(object sender, EventArgs e)
        {
            ((ProductionPlanningModule)Module).ShownSaleOrder();

        }
        private void fld_dteARProductionPlanningDelivery_Validated(object sender, EventArgs e)
        {
            if (fld_dteARProductionPlanningDelivery.EditValue != fld_dteARProductionPlanningDelivery.OldEditValue)
            {
                ((ProductionPlanningModule)Module).UpdatePlanningName();
            }
        }

        private void bosDateEdit1_Validated(object sender, EventArgs e)
        {

            if (bosDateEdit1.EditValue != bosDateEdit1.OldEditValue)
            {
                ((ProductionPlanningModule)Module).UpdatePlanningName();
            }
        }

        private void fld_btnXemVatTu_Click(object sender, EventArgs e)
        {
            ((ProductionPlanningModule)Module).ShowProductSpecific();
        }

        private void bosLookupEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (!string.IsNullOrEmpty(bosLookupEdit1.EditValue.ToString()))
            {
                ProductionPlanningEntities entity = (ProductionPlanningEntities)(((ProductionPlanningModule)Module).CurrentModuleEntity);
                entity.ProductionPlanningItemList.ForEach(i => i.ARProductionPlanningItemSources = bosLookupEdit1.EditValue.ToString());
            }
        }

        private void fld_btnClosePlaning_Click(object sender, EventArgs e)
        {
            ((ProductionPlanningModule)Module).CloseProductionPlanningItems();
        }

        private void fld_lkeFK_ICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            ((ProductionPlanningModule)Module).AddItemToProductionPlanning();
        }

        private void fld_lkeARProductionPlanningSaleType_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            ((ProductionPlanningModule)Module).ChangeSaleType();
        }

        private void fld_txtARProductionPlanningSaleOrderName_Validated(object sender, EventArgs e)
        {
            ((ProductionPlanningModule)Module).ChangeSaleOrderName();
        }
    }
}
