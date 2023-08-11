using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.MachineTimeKeeper
{
    public partial class HRTimeKeepersGridControl : BOSComponent.BOSGridControl
    {

        public override void InitializeControl()
        {
            base.InitializeControl();

        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Tên nhân viên";
            column.FieldName = "EmployeeName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
