using BOSCommon;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.HRPayRoll
{
    public class HREmployeePayRollValidatesGridControl : BOSComponent.BOSGridControl
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
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_HREmployeeValidateBranchID")
            {
                if (e.Value != null)
                {
                    int branchID = int.Parse(e.Value.ToString());
                    BRBranchsController objBranchsController = new BRBranchsController();
                    BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(branchID);
                    if (objBranchsInfo != null)
                    {
                        e.DisplayText = objBranchsInfo.BRBranchName;
                    }
                }
            }
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            gridView.Columns.Clear();

            GridColumn column = new GridColumn();
            column.Caption = PayRollLocalizedResources.HREmployeeNo;
            column.FieldName = "HREmployeeNo";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = PayRollLocalizedResources.HREmployeeName;
            column.FieldName = "HREmployeeName";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tiền thưởng KPI";
            column.FieldName = "HREmployeePayRollValidateTienThuongKPI";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tiền thưởng đạt được";
            column.FieldName = "HREmployeePayRollValidateTienThuongResult";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Diễn giải";
            column.FieldName = "HREmployeePayRollValidateComment";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số tiền thường";
            column.FieldName = "HREmployeePayRollValidateSoTienThuong";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày áp dụng";
            column.FieldName = "HREmployeePayRollValidateDate";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số tiền phạt";
            column.FieldName = "HREmployeePayRollValidateSoTienPhat";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Chi nhánh";
            column.FieldName = "FK_HREmployeeValidateBranchID";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số lượng bốc";
            column.FieldName = "HREmployeePayRollValidateSoLuongBoc";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Lương khoán";
            column.FieldName = "HREmployeePayRollValidateLuongKhoan";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Phòng ban";
            column.FieldName = "HRDepartmentName";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Bộ phận";
            column.FieldName = "HRDepartmentRoomName";
            gridView.Columns.Add(column);
        }

        public void LoadGridViewByType(string type)
        {
            GridView gridView = (GridView)MainView;

            foreach (GridColumn columnedit in gridView.Columns)
            {
                columnedit.Visible = false;
            }

            if (type == ValidatePayRoll.PieceWage.ToString())
            {
                GridColumn column = gridView.Columns["HREmployeeNo"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 1;
                }

                column = gridView.Columns["HREmployeeName"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 2;
                }

                column = gridView.Columns["FK_HREmployeeValidateBranchID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 3;
                }

                column = gridView.Columns["HRDepartmentName"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 4;
                }

                column = gridView.Columns["HRDepartmentRoomName"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 5;
                }

                column = gridView.Columns["HREmployeePayRollValidateSoLuongBoc"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n2}";
                    column.VisibleIndex = 6;
                }

                column = gridView.Columns["HREmployeePayRollValidateLuongKhoan"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n2}";
                    column.VisibleIndex = 7;
                }
                column = gridView.Columns["HREmployeePayRollValidateComment"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 8;
                }
                gridView.BestFitColumns();
            }
            else if (type == ValidatePayRoll.KPI.ToString())
            {
                GridColumn column = gridView.Columns["HREmployeeNo"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 1;
                }

                column = gridView.Columns["HREmployeeName"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 2;
                }

                column = gridView.Columns["FK_HREmployeeValidateBranchID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 3;
                }

                column = gridView.Columns["HRDepartmentName"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 4;
                }

                column = gridView.Columns["HRDepartmentRoomName"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 5;
                }

                column = gridView.Columns["HREmployeePayRollValidateTienThuongKPI"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n2}";
                    column.VisibleIndex = 6;
                }

                column = gridView.Columns["HREmployeePayRollValidateTienThuongResult"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n2}";
                    column.VisibleIndex = 7;
                }

                column = gridView.Columns["HREmployeePayRollValidateComment"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 8;
                }
                gridView.BestFitColumns();
            }
            else if (type == ValidatePayRoll.Allowance.ToString())
            {
                GridColumn column = gridView.Columns["HREmployeeNo"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 1;
                }

                column = gridView.Columns["HREmployeeName"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 2;
                }

                column = gridView.Columns["FK_HREmployeeValidateBranchID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 3;
                }

                column = gridView.Columns["HRDepartmentName"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 4;
                }

                column = gridView.Columns["HRDepartmentRoomName"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 5;
                }

                column = gridView.Columns["HREmployeePayRollValidateDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 6;
                }

                column = gridView.Columns["HREmployeePayRollValidateSoTienThuong"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n2}";
                    column.VisibleIndex = 7;
                }

                column = gridView.Columns["HREmployeePayRollValidateComment"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 8;
                }
                gridView.BestFitColumns();
            }
            else if (type == ValidatePayRoll.Discipline.ToString())
            {
                GridColumn column = gridView.Columns["HREmployeeNo"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 1;
                }

                column = gridView.Columns["HREmployeeName"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 2;
                }

                column = gridView.Columns["FK_HREmployeeValidateBranchID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 3;
                }

                column = gridView.Columns["HRDepartmentName"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 4;
                }

                column = gridView.Columns["HRDepartmentRoomName"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 5;
                }

                column = gridView.Columns["HREmployeePayRollValidateDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 6;
                }

                column = gridView.Columns["HREmployeePayRollValidateSoTienPhat"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n2}";
                    column.VisibleIndex = 7;
                }

                column = gridView.Columns["HREmployeePayRollValidateComment"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.VisibleIndex = 8;
                }
                gridView.BestFitColumns();
            }
        }
    }
}
