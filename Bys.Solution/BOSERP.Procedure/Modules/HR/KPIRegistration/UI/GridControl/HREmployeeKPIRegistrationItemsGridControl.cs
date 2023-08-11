using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.KPIRegistration
{
    public class HREmployeeKPIRegistrationItemsGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            KPIRegistrationEntities entity = (KPIRegistrationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EmployeeKPIRegistrationItemsList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["HREmployeeKPIRegistrationItemNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["HREmployeeKPIRegistrationItemName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["FK_HRDepartmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["FK_HRDepartmentRoomID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["HREmployeeKPIRegistrationItemTotalAmountBonus"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["IsExcessReward"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            gridView.Click += new EventHandler(GridView_Click);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);

            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((KPIRegistrationModule)Screen.Module).DeleteItemFromEmployeeItemsList();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }
        void GridView_Click(object sender, EventArgs e)
        {
            KPIRegistrationModule module = (KPIRegistrationModule)Screen.Module;
            module.InitDataViewScreen();
        }

        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName == "HREmployeeKPIRegistrationItemTotalAmountBonus")
            {
                e.Appearance.BackColor2 = Color.Yellow;
                e.Appearance.BackColor = Color.Yellow;
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            KPIRegistrationEntities entity = (KPIRegistrationEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.EmployeeKPIRegistrationItemsList.CurrentIndex >= 0)
            {
                HREmployeeKPIRegistrationItemsInfo employee = (HREmployeeKPIRegistrationItemsInfo)entity.EmployeeKPIRegistrationItemsList[entity.EmployeeKPIRegistrationItemsList.CurrentIndex];
                if (e.Column.FieldName == "HREmployeeKPIRegistrationItemTotalAmountBonus")
                {
                    if (employee != null)
                    {
                        ((KPIRegistrationModule)entity.Module).ChangeItemWeightEmployee(employee);
                    }
                }
            }
        }

    }
}
