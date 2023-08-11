using BOSComponent;
using DevExpress.XtraGrid.Columns;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseOrder
{
    public partial class APPurchaseOrderGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PurchaseOrderList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();

            column.Caption = ReportLocalizedResources.Selected;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            PurchaseOrderEntities entity = (PurchaseOrderEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            (entity.Module as PurchaseOrderModule).ActionCancel();
        }
    }
}
