using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.Product
{
    public class ICProductWorkItemAssetsGridControl : ItemGridControl
    {
        public const string ICProductWorkItemProductNo = "ICProductWorkItemProductNo";
        public const string ICProductWorkItemProductName = "ICProductWorkItemProductName";
        public const string ICProductWorkItemProductDesc = "ICProductWorkItemProductDesc";
        public const string ICProductWorkItemQty = "ICProductWorkItemQty";
        public const string ICProductWorkItemDesc = "ICProductWorkItemDesc";
        public const string ICProductWorkItemProductChargeCheck = "ICProductWorkItemProductChargeCheck";
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            ProductEntities entity = (ProductEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICProductWorkItemAssetList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductLocalizedResources.ICProductWorkItemAssetNo;
            column.FieldName = ICProductWorkItemProductNo;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductLocalizedResources.ICProductWorkItemAssetName;
            column.FieldName = ICProductWorkItemProductName;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = WorkProductLocalizedResources.ICProductWorkItemProductDesc;
            column.FieldName = ICProductWorkItemProductDesc;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            if (gridView.Columns[ICProductWorkItemQty] != null)
            {
                gridView.Columns[ICProductWorkItemQty].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns[ICProductWorkItemDesc] != null)
            {
                gridView.Columns[ICProductWorkItemDesc].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns[ICProductWorkItemProductChargeCheck] != null)
            {
                gridView.Columns[ICProductWorkItemProductChargeCheck].OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }
    }
}
