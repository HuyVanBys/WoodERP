using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public class ProductWorkItemMaterialsGridControl : ItemGridControl
    {
        BOSList<ICProductWorkItemsInfo> ProductWorkItemList { get; set; }
        public void InvalidateDataSource(BOSList<ICProductWorkItemsInfo> dataSource)
        {
            ProductWorkItemList = new BOSList<ICProductWorkItemsInfo>();
            ProductWorkItemList = dataSource;
            DataSource = ProductWorkItemList;
            RefreshDataSource();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = WorkProductLocalizedResources.ICProductWorkItemProductNo;
            column.FieldName = "ICProductWorkItemProductNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = WorkProductLocalizedResources.ICProductWorkItemProductName;
            column.FieldName = "ICProductWorkItemProductName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = WorkProductLocalizedResources.ICProductWorkItemProductDesc;
            column.FieldName = "ICProductWorkItemProductDesc";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            if (gridView.Columns["ICProductWorkItemQty"] != null)
            {
                gridView.Columns["ICProductWorkItemQty"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ICProductWorkItemDesc"] != null)
            {
                gridView.Columns["ICProductWorkItemDesc"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ICProductWorkItemProductChargeCheck"] != null)
            {
                gridView.Columns["ICProductWorkItemProductChargeCheck"].OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            GridView gridView = sender as GridView;
            string productNo = gridView.FocusedValue.ToString();
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ProductWorkItemList.Remove(ProductWorkItemList.Where(o => o.ICProductWorkItemProductNo.Equals(productNo)).FirstOrDefault());
            }
            RefreshDataSource();
        }
    }
}
