using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public partial class HRRP018EmployeesGridControl : ReportGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsBehavior.Editable = true;
            GridColumn column = gridView.Columns["FK_HRDepartmentRoomID"];
            if (column != null)
            {
                column.Group();
            }
            return gridView;
        }
    }
}
