using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseReceipt
{
    public partial class APPurchaseOrderItemsGridControl : BOSGridControl
    {

        public void InvalidateDataSource(List<APPurchaseOrderItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            this.DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);

            GridColumn column = gridView.Columns["APPurchaseOrderReceiptTypeCombo"];
            if (column != null)
            {
                //column.Group();
            }

            column = gridView.Columns["APPurchaseOrderNo"];
            if (column != null)
            {
                column.Group();
            }

            column = gridView.Columns["FK_APPurchaseOrderID"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
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

            column = new GridColumn();
            column.Caption = "Loại đơn hàng";
            column.FieldName = "APPurchaseOrderReceiptTypeCombo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày chứng từ";
            column.FieldName = "APPurchaseOrderDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Thành tiền";
            column.FieldName = "APPurchaseOrderTotalCost";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n3}";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã đơn hàng nội bộ";
            column.FieldName = "MMBatchProductSOName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);
        }
    }
}
