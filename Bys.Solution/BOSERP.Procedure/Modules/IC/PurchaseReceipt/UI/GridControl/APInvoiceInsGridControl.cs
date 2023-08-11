using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseReceipt
{
    public partial class APInvoiceInsGridControl : BOSGridControl
    {

        public void InvalidateDataSource(List<APInvoiceInsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            this.DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = null;
            column = gridView.Columns["APInvoiceInTotalQuantity"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                FormatNumbericColumn(column, true, "n5");
            }
            return gridView;
        }

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            gridView.ExpandAllGroups();
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Đơn mua hàng";
            column.FieldName = "APPurchaseOrderNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

        }
    }
}
