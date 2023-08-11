using BOSComponent;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.Barcode
{
    public partial class ICProductBarcodeGridControl : BOSGridControl
    {

        public override void InitGridControlDataSource()
        {
            BarcodeEntities entity = (BarcodeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            //bds.DataSource = entity.ProductsList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = BarcodeLocalizedResources.ICInventoryStockQuantity;
            column.FieldName = "ICInventoryStockQuantity";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = BarcodeLocalizedResources.ICInventoryStockQuantityToPrint;
            column.FieldName = "ICInventoryStockQuantityToPrint";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((BarcodeModule)Screen.Module).RemoveSelectedItemFromBarcodeList();
            }
        }
    }
}
