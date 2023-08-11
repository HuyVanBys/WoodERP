using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrder
{
    public partial class ARSaleOrderGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<ARSaleOrdersInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            gridView.ExpandAllGroups();
        }
    }
}
