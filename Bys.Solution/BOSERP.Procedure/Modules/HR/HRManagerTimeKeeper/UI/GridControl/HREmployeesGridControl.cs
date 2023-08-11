using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.ManagerTimeKeeper
{
    public partial class HREmployeesGridControl : BOSComponent.BOSGridControl
    {
        public void InvalidateDataSource(List<HREmployeesInfo> employees)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = employees;
            this.DataSource = bds;
            RefreshDataSource();
        }

        public override void InitializeControl()
        {
            base.InitializeControl();
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            GridColumn column = new GridColumn();
            //column.Caption = BaseLocalizedResources.Select;
            //column.FieldName = "Selected";
            //column.OptionsColumn.AllowEdit = true;
            //gridView.Columns.Insert(0, column);
            //column.VisibleIndex = 0;

            column = gridView.Columns["HREmployeeCardNumber"];
            if (column != null)
            {
                column.VisibleIndex = 1;
            }

            column = gridView.Columns["HREmployeeNo"];
            if (column != null)
            {
                column.VisibleIndex = 2;
            }

            column = gridView.Columns["HREmployeeName"];
            if (column != null)
            {
                column.VisibleIndex = 3;
            }

            column = gridView.Columns["FK_HRDepartmentID"];
            if (column != null)
            {
                column.VisibleIndex = 4;
            }

            column = gridView.Columns["FK_HRDepartmentRoomID"];
            if (column != null)
            {
                column.VisibleIndex = 5;
            }
            column = gridView.Columns["HRTimeSheetParamNo"];
            if (column != null)
            {
                column.VisibleIndex = 6;
            }
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Mã nghỉ phép";
            column.FieldName = "HRTimeSheetParamNo";
            column.OptionsColumn.AllowEdit = false;
            //column.Group();
            gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = "Tên nhân viên";
            //column.FieldName = "EmployeeName";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);
        }
    }
}
