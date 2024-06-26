using BOSComponent;
using DevExpress.XtraGrid.Columns;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.CancelVoucher
{
    public class ARSaleOrderItemWorksGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<ARSaleOrderItemWorksInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            return gridView;
        }
    }
}
