using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.InvoiceIn
{
    public class APInvoiceInPackageItemDetailReportsGridControl : BOSGridControl
    {
        private DataTable ConfigValueDataTable { get; set; }
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            InvoiceInEntities entity = (InvoiceInEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.InvoiceInPackageItemDetailReportList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column = new GridColumn();
            column.Caption = "Số lượng MH";
            column.FieldName = "APInvoiceInItemQty";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = false;
            gridView.Columns.Add(column);
            SetFormat("APInvoiceInItemQty", "n2", gridView);


            column = new GridColumn();
            column.Caption = "Số lượng đã đóng kiện";
            column.FieldName = "APInvoiceInItemPackagedQty1";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = false;
            gridView.Columns.Add(column);
            SetFormat("APInvoiceInItemPackagedQty1", "n2", gridView);
        }

        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }

        public void InvalidateDataSource(List<APInvoiceInPackageItemDetailsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            this.DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = false;
            }
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            InvoiceInEntities entity = (InvoiceInEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            if (e.KeyCode == Keys.Delete)
            {
                GridView view = sender as GridView;
                if (e.KeyData == Keys.Delete)
                {
                    int index = view.GetDataSourceRowIndex(view.FocusedRowHandle);
                    if (index >= 0)
                    {
                        entity.InvoiceInPackageItemDetailList.RemoveAt(index);
                        this.DataSource = entity.InvoiceInPackageItemDetailList;
                        RefreshDataSource();
                    }
                    e.Handled = true;
                }
            }
        }
    }
}
