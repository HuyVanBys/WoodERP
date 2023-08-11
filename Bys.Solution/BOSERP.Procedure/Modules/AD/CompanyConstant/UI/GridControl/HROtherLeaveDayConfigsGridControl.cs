using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public class HROtherLeaveDayConfigsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HROtherLeaveDayConfigsList;
            this.DataSource = bds;
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            GridColumn column = gridView.Columns["FK_HREmployeeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_HRDepartmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_HRLevelID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HROtherLeaveDayConfigQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            return gridView;
        }
        private void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveSelectOtherLeaveDayConfig();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridview = (GridView)sender;
            if (gridview.FocusedColumn.FieldName == "FK_HREmployeeID")
            {
                if (e.Value != null)
                {
                    HROtherLeaveDayConfigsInfo objOtherLeaveDayConfigsInfo = (HROtherLeaveDayConfigsInfo)gridview.GetRow(gridview.FocusedRowHandle);
                    if (objOtherLeaveDayConfigsInfo == null)
                        return;

                    int employeeID = Convert.ToInt32(e.Value);
                    ((CompanyConstantModule)Screen.Module).ChooseEmployeeOtherLeaveDay(employeeID, objOtherLeaveDayConfigsInfo);
                }
            }
        }
    }
}
