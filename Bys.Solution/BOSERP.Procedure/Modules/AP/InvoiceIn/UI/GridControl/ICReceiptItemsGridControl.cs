using BOSComponent;
using DevExpress.XtraGrid.Columns;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.InvoiceIn
{
    public class ICReceiptItemsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<ICReceiptsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            this.DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = false;
            }
            return gridView;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Ghi chú";
            column.FieldName = "APPurchaseOrderComment";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

    }
}
