using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.DeliveryPlan
{
    public partial class ARDeliveryPlanForPrintsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<ARDeliveryPlansInfo> datasouce)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = datasouce;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            return gridView;
        }
    }
}
