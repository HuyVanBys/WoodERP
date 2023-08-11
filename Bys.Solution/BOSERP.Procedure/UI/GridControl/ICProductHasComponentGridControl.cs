using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP
{
    public class ICProductHasComponentGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<ICProductsForViewInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            gridView.ExpandAllGroups();
            return gridView;
        }

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            gridView.ExpandAllGroups();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Số lượng";
            column.FieldName = "ICProductItemQty";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

        }
    }
}
