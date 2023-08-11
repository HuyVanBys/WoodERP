using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.ATMCardManage
{
    public partial class HREmployeeATMCardManagesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ATMCardManageEntities entity = (ATMCardManageEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EmployeeATMCardManageList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = ReportLocalizedResources.Selected;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            GridColumn column = gridView.Columns["HREmployeeATMCardManageAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HREmployeeATMCardManageBankAccount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HREmployeeATMCardManagePhone"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HREmployeeATMCardManageRegisterInsurance"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HREmployeeATMCardManageCardRank"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HREmployeeATMCardManageStatus"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            ATMCardManageEntities entity = (ATMCardManageEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            HRATMCardManagesInfo mainObject = (HRATMCardManagesInfo)entity.MainObject;

            if (entity.EmployeeATMCardManageList.CurrentIndex >= 0)
            {
                HREmployeeATMCardManagesInfo item = entity.EmployeeATMCardManageList[entity.EmployeeATMCardManageList.CurrentIndex];
                if (e.Column.FieldName == "HREmployeeATMCardManageStatus")
                {
                    ((ATMCardManageModule)Screen.Module).UpdateCardManageStatus(item);
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ATMCardManageModule)Screen.Module).RemoveItemFromList();
            }
        }
    }
}
