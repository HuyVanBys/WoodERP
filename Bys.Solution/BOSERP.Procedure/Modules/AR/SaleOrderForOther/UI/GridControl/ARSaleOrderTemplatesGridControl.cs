using DevExpress.XtraGrid.Columns;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrderForOther
{
    public class ARSaleOrderTemplatesGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SaleOrderForOtherEntities entity = (SaleOrderForOtherEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SaleOrderTemplatesList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = SaleOrderLocalizedResources.UserCreatedName;
            column.FieldName = "UserCreatedFullname";
            gridView.Columns.Add(column);
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["UserCreatedFullname"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            return gridView;
        }

    }
}
