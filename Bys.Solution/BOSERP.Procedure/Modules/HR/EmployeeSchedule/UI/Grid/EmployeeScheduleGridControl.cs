using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace BOSERP.Modules.EmployeeSchedule
{
    public class EmployeeScheduleGridControl : BOSGridControl
    {
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        public override void InitGridControlDataSource()
        {
            EmployeeScheduleEntities entity = (EmployeeScheduleEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EmployeeScheduleList;
            this.DataSource = bds;
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }
        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((EmployeeScheduleModule)Screen.Module).removeSelectRow();
            }
        }
        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            ((EmployeeScheduleModule)Screen.Module).UpdateEmployeeScheduleList();
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            // repositoryItemDateEdit
            repositoryItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            repositoryItemDateEdit.AutoHeight = false;
            repositoryItemDateEdit.DisplayFormat.FormatString = "HH:mm";
            repositoryItemDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit.EditFormat.FormatString = "HH:mm";
            repositoryItemDateEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit.Mask.EditMask = "HH:mm";
            repositoryItemDateEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            repositoryItemDateEdit.Name = "repositoryItemDateEdit1";
            // repositoryItemDateEdit
            repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            repositoryItemDateEdit2.AutoHeight = false;
            repositoryItemDateEdit2.DisplayFormat.FormatString = "dd/MM/yyyy";
            repositoryItemDateEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit2.EditFormat.FormatString = "dd/MM/yyyy";
            repositoryItemDateEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit2.Mask.EditMask = "dd/MM/yyyy";
            repositoryItemDateEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";

            GridColumn column = new GridColumn();
            column.Caption = "Mã nhân viên";
            column.FieldName = "EmployeeNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên nhân viên";
            column.FieldName = "EmployeeName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày";
            column.FieldName = "HREmployeeScheduleWorkDate";
            column.OptionsColumn.AllowEdit = false;
            column.ColumnEdit = repositoryItemDateEdit2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ca làm việc";
            column.FieldName = "FK_HRWorkingShiftID";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Từ giờ";
            column.FieldName = "HREmployeeScheduleFromTime";
            column.OptionsColumn.AllowEdit = false;
            column.ColumnEdit = repositoryItemDateEdit;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Đến giờ";
            column.FieldName = "HREmployeeScheduleToTime";
            column.ColumnEdit = repositoryItemDateEdit;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);


        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
            HREmployeesController objEmployeesController = new HREmployeesController();
            if (e.Column.FieldName == "FK_HREmployeeID")
            {
                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(value);
                        if (objEmployeesInfo != null)
                        {
                            e.DisplayText = objEmployeesInfo.HREmployeeName;
                        }
                    }
                }
            }
        }


    }
}
