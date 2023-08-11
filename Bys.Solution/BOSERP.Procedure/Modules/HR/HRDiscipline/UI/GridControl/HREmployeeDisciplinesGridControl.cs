using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;


namespace BOSERP.Modules.HRDiscipline
{
    public partial class HREmployeeDisciplinesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HRDisciplineEntities entity = (HRDisciplineEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HREmployeeDisciplinesList;
            DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = DisciplineLocalizedResources.HREmployeeNo;
            column.FieldName = "HREmployeeNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã ID";
            column.FieldName = "HREmployeeCardNumber";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn item in gridView.Columns)
            {
                item.OptionsColumn.AllowEdit = true;
            }

            GridColumn column = gridView.Columns["FK_HREmployeeID2"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["HREmployeeNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["HREmployeeCardNumber"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((HRDisciplineModule)Screen.Module).RemoveSelectedItemFromDisciplinesList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            HRDisciplineEntities entity = (HRDisciplineEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.HREmployeeDisciplinesList.CurrentIndex >= 0)
            {
                HREmployeeDisciplinesInfo item = entity.HREmployeeDisciplinesList[entity.HREmployeeDisciplinesList.CurrentIndex];
                ((HRDisciplineModule)Screen.Module).ChangeValueSelectedItemFromDisciplinesList(item.FK_HREmployeeID);
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
            HREmployeesController objEmployeesController = new HREmployeesController();

            if (e.Column.FieldName == "FK_HREmployeeID" || e.Column.FieldName == "FK_HREmployeeID2")
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
            else if (e.Column.FieldName == "FK_HRDepartmentRoomID")
            {
                HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
                HRDepartmentRoomsInfo objDepartmentRoomsInfo = new HRDepartmentRoomsInfo();

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
                    }
                }
            }
            else if (e.Column.FieldName == "FK_HRLevelID" || e.Column.FieldName == "FK_HRLevelID2")
            {
                HRLevelsController objLevelsController = new HRLevelsController();
                HRLevelsInfo objLevelsInfo = new HRLevelsInfo();

                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        objLevelsInfo = (HRLevelsInfo)objLevelsController.GetObjectByID(value);
                        if (objLevelsInfo != null)
                        {
                            e.DisplayText = objLevelsInfo.HRLevelName;
                        }
                    }
                }
            }
        }
    }
}
