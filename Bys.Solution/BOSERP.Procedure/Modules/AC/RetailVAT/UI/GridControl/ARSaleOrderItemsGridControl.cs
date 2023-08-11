using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Invoice
{
    public class ARSaleOrderItemsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<ARSaleOrderItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        public void InvalidateDataSource(List<ARSaleOrderItemsInfo> dataSource, string strActionNewFrom)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
            LoadGridViewForInvoice(strActionNewFrom);
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            GridColumn column = null;
            column = gridView.Columns["ARSaleOrderItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                FormatNumbericColumn(column, true, "n5");
            }
            return gridView;
        }

        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
        }

        public void LoadGridViewForInvoice(string strActionNewFrom)
        {
            GridView gridView = (GridView)MainView;
            GridColumn column = gridView.Columns["FK_ARSaleOrderID"];
            if (column != null)
            {
                column.Group();
            }
        }
    }
}
