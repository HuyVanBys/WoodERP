using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.SemiProductReceipt
{
    public class ICReceiptPackageItemDetailsGridControl : BOSGridControl
    {
        private DataTable ConfigValueDataTable { get; set; }

        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            SemiProductReceiptEntities entity = (SemiProductReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ReceiptPackageItemDetailList;
            this.DataSource = bds;
        }

        public void InvalidateDataSource(List<ICReceiptPackageItemDetailsInfo> dataSource)
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
                col.OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ICReceiptPackageItemDetailQty"] != null)
            {
                SetFormat("ICReceiptPackageItemDetailQty", "n2", gridView);
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

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            SemiProductReceiptEntities entity = (SemiProductReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            if (e.KeyCode == Keys.Delete)
            {
                GridView view = sender as GridView;
                if (e.KeyData == Keys.Delete)
                {
                    int index = view.GetDataSourceRowIndex(view.FocusedRowHandle);
                    if (index >= 0)
                    {
                        entity.DeleteReceiptPackageItemDetailList.Add(entity.ReceiptPackageItemDetailList[index]);
                        entity.ReceiptPackageItemDetailList.RemoveAt(index);
                        this.DataSource = entity.ReceiptPackageItemDetailList;
                        RefreshDataSource();
                    }
                    e.Handled = true;
                }
            }
        }
    }
}
