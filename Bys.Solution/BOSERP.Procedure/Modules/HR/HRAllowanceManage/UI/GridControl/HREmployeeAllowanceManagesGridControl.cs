using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;


namespace BOSERP.Modules.HRAllowanceManage
{
    public partial class HREmployeeAllowanceManagesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HRAllowanceManageEntities entity = (HRAllowanceManageEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HREmployeeAllowancesList;
            DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = AllowanceManageLocalizedResources.HREmployeeNo;
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
            GridColumn column = gridView.Columns["HREmployeeAllowanceValue"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["HREmployeeAllowanceValueAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["HREmployeeAllowanceProductivityCriteria"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["HREmployeeAllowanceQualityCriteria"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["HREmployeeAllowanceManageCriteria"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["HREmployeeAllowanceExactlyCriteria"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridView_CellValueChanged);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //((HRAllowanceManageModule)Screen.Module).ValidCellValue(e.RowHandle);
            if (e.RowHandle >= 0)
            {
                GridView gridView = (GridView)MainView;
                HRAllowanceManageEntities entity = (HRAllowanceManageEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                //HREmployeeAllowancesInfo allowance = entity.HREmployeeAllowancesList[e.RowHandle];
                HREmployeeAllowancesInfo allowance = (HREmployeeAllowancesInfo)gridView.GetRow(e.RowHandle);
                if (allowance != null)
                {
                    if (e.Column.FieldName == "HREmployeeAllowanceManageCriteria"
                        || e.Column.FieldName == "HREmployeeAllowanceQualityCriteria"
                        || e.Column.FieldName == "HREmployeeAllowanceProductivityCriteria"
                        || e.Column.FieldName == "HREmployeeAllowanceExactlyCriteria")
                    {
                        ((HRAllowanceManageModule)Screen.Module).CalAllowanceAmount(allowance);
                        entity.HREmployeeAllowancesList.GridControl.RefreshDataSource();
                    }
                }
            }
            //((HRAllowanceManageModule)Screen.Module).ResetValueAmount(e.RowHandle);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((HRAllowanceManageModule)Screen.Module).RemoveSelectedItemFromAllowancesList();
            }
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
