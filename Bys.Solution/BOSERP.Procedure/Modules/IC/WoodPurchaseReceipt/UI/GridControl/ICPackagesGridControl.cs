using BOSComponent;
using DevExpress.XtraGrid.Columns;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.WoodPurchaseReceipt
{
    public class ICPackagesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            WoodPurchaseReceiptEntities entity = (WoodPurchaseReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PackageList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = WoodPurchaseReceiptLocalizedResources.Selected;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
            column.VisibleIndex = 0;
        }
    }
}
