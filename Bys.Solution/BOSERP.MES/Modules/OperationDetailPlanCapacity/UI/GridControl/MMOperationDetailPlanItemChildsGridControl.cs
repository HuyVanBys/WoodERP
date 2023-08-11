using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlanCapacity
{
    public partial class MMOperationDetailPlanItemChildsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            OperationDetailPlanCapacityEntities entity = (OperationDetailPlanCapacityEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.OperationDetailPlanItemChildsList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = OperationDetailPlanCapacityLocalizedResources.Selected;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = OperationDetailPlanCapacityLocalizedResources.MMOperationDetailPlanNoMessage;
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "MMOperationDetailPlanNo";
            column.Visible = true;
            column.Group();
            column.GroupIndex = 0;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Công đoạn KH";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "MMOperationName";
            column.Visible = true;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            return gridView;
        }
    }
}
