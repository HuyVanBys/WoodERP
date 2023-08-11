using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.EmployeeSchedule.UI
{
    public partial class HREmployee2sGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = CommonLocalizedResources.Selected;
            column.FieldName = "Selected";
            gridView.Columns.Add(column);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["HREmployeeName"];
            if (column != null)
            {
                column.Caption = CommonLocalizedResources.HREmployeeName;
            }
            return gridView;
        }
    }
}
