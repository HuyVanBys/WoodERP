using DevExpress.XtraGrid.Columns;
using Localization;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.HRPayRoll
{
    public class HREmployeePayRollsGridControl2 : BOSComponent.BOSGridControl
    {
        public void InvalidateDataSource(List<HREmployeePayRollsInfo> employeePayRolls)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = employeePayRolls;
            this.DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            GridColumn column = new GridColumn();
            column.Caption = BaseLocalizedResources.Select;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Insert(0, column);
            column.VisibleIndex = 0;

            column = gridView.Columns["FK_HRDepartmentID"];
            if (column != null)
            {
                column.Group();
            }

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

            column = gridView.Columns["HRDepartmentRoomName"];
            if (column != null)
            {
                column.VisibleIndex = 4;
            }

            column = gridView.Columns["HRLevelName"];
            if (column != null)
            {
                column.VisibleIndex = 5;
            }

            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = PayRollLocalizedResources.HREmployeeNo;
            column.FieldName = "HREmployeeNo";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = PayRollLocalizedResources.HREmployeeName;
            column.FieldName = "HREmployeeName";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã ID";
            column.FieldName = "HREmployeeCardNumber";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Bộ phận";
            column.FieldName = "HRDepartmentRoomName";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Chức vụ";
            column.FieldName = "HRLevelName";
            gridView.Columns.Add(column);
        }
    }
}
