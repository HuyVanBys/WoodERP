using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;


namespace BOSERP.Modules.HRAllowance
{
    public partial class HREmployeeAllowancesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HRAllowanceEntities entity = (HRAllowanceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HREmployeeAllowancesList;
            DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = AllowanceLocalizedResources.HREmployeeNo;
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
            gridView.Columns.Remove(gridView.Columns["HREmployeeAllowanceQualityCriteria"]);
            gridView.Columns.Remove(gridView.Columns["HREmployeeAllowanceProductivityCriteria"]);
            gridView.Columns.Remove(gridView.Columns["HREmployeeAllowanceManageCriteria"]);
            gridView.Columns.Remove(gridView.Columns["HREmployeeAllowanceConfiguredProductivityAmount"]);
            gridView.Columns.Remove(gridView.Columns["HREmployeeAllowanceConfiguredQualityAmount"]);
            gridView.Columns.Remove(gridView.Columns["HREmployeeAllowanceConfiguredManageAmount"]);
            gridView.Columns.Remove(gridView.Columns["HREmployeeAllowanceAmount"]);
            gridView.Columns.Remove(gridView.Columns["HREmployeeAllowanceExactlyCriteria"]);
            gridView.Columns.Remove(gridView.Columns["HREmployeeAllowanceExactlyAmount"]);

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
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((HRAllowanceModule)Screen.Module).RemoveSelectedItemFromAllowancesList();
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
