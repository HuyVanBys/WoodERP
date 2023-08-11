using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public class RP212HREmployeeWorkScheduleItemsGridControl : ReportGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column = new GridColumn();
            column.FieldName = "HREmployeeNo";
            column.Caption = "Mã nhân viên";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "HREmployeeWorkScheduleNo";
            column.Caption = "Mã chứng từ";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.FieldName = "HREmployeeWorkScheduleName";
            column.Caption = "Tên chứng từ";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "HREmployeeWorkScheduleDesc";
            column.Caption = "Mô tả";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "HREmployeeWorkScheduleDateFrom";
            column.Caption = "Từ ngày";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "HREmployeeWorkScheduleDateTo";
            column.Caption = "Đến ngày";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "HREmployeeWorkScheduleHourFrom";
            column.Caption = "Từ giờ";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "HREmployeeWorkScheduleHourTo";
            column.Caption = "Đến giờ";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "FK_HRDepartmentRoomID";
            column.Caption = "Bộ phận";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);
        }
        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.ExpandAllGroups();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            // gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            //gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            RepositoryItemDateEdit repositoryItemDateEdit = new RepositoryItemDateEdit();
            repositoryItemDateEdit.AutoHeight = false;
            repositoryItemDateEdit.DisplayFormat.FormatString = "HH:mm:ss";
            repositoryItemDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit.Mask.EditMask = "HH:mm:ss";
            repositoryItemDateEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            repositoryItemDateEdit.Name = "rpDate";

            GridColumn column = gridView.Columns["FK_HRDepartmentRoomID"];
            if (column != null)
            {
                column.Group();
            }

            column = gridView.Columns["HREmployeeWorkScheduleHourFrom"];
            if (column != null)
            {
                column.ColumnEdit = repositoryItemDateEdit;
            }

            column = gridView.Columns["HREmployeeWorkScheduleHourTo"];
            if (column != null)
            {
                column.ColumnEdit = repositoryItemDateEdit;
            }

            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            HRDepartmentRoomsInfo objDepartmentRoomsInfo = new HRDepartmentRoomsInfo();
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            if (e.Column.FieldName == "FK_HRDepartmentRoomID")
            {
                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        objDepartmentRoomsInfo = (HRDepartmentRoomsInfo)objDepartmentRoomsController.GetObjectByID(value);
                        if (objDepartmentRoomsInfo != null)
                        {
                            e.DisplayText = objDepartmentRoomsInfo.HRDepartmentRoomName;
                        }
                        else
                        {
                            e.DisplayText = "";
                        }
                    }
                }
                else
                {
                    e.DisplayText = "";
                }
            }
        }
    }
}
