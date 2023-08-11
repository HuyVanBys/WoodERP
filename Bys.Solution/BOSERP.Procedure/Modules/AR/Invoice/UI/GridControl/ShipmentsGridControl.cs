using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Invoice
{
    public class ShipmentsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<ICShipmentsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
            LoadGridViewForInvoice();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            return gridView;
        }

        //protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        //{
        //    base.AddColumnsToGridView(strTableName, gridView);

        //    GridColumn column = new GridColumn();
        //    column.FieldName = "ARSaleOrderNo";
        //    column.Caption = "Mã ĐBH";
        //    column.OptionsColumn.AllowEdit = false;
        //    column.Visible = true;
        //    gridView.Columns.Add(column);
        //}

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
        }

        public void LoadGridViewForInvoice()
        {
            GridView gridView = (GridView)MainView;
            GridColumn column = gridView.Columns["ARSaleOrderNo"];
            if (column != null)
            {
                column.Group();
            }
        }
    }
}
