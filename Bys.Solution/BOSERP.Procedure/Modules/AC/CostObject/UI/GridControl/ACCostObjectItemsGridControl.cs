using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.CostObject
{
    public class ACCostObjectItemsGridControl : BOSComponent.BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CostObjectEntities entity = (CostObjectEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CostObjectItemList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.RowStyle += new RowStyleEventHandler(gridView_RowStyle);
            GridColumn column = gridView.Columns["ACCostObjectItemRefNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ACCostObjectItemStartDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ACCostObjectItemAllocationMonths"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_PMProjectID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACCostCenterID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACSegmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_HRDepartmentRoomID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_HRDepartmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ACCostObjectItemAllocationMonths"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            CostObjectEntities entity = (CostObjectEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.CostObjectItemList.CurrentIndex >= 0)
            {
                if (e.Column.FieldName == "ACCostObjectItemAllocationMonths")
                {
                    ((CostObjectModule)Screen.Module).ResetAllocationMonthAmount();
                }
            }
        }

        private void gridView_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView gridview = sender as GridView;
            if (e.RowHandle >= 0)
            {
                CostObjectEntities entity = (CostObjectEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
                ACCostObjectItemsInfo item = (ACCostObjectItemsInfo)gridview.GetRow(e.RowHandle);
                if (item != null && item.ACCostObjectItemIsAllocated)
                {
                    e.Appearance.BackColor2 = Color.Yellow;
                    e.Appearance.BackColor = Color.Yellow;
                    e.HighPriority = true;
                }
            }
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);
            GridView gridview = sender as GridView;
            if (gridview.FocusedRowHandle >= 0)
            {
                CostObjectEntities entity = (CostObjectEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
                ACCostObjectItemsInfo item = (ACCostObjectItemsInfo)gridview.GetRow(gridview.FocusedRowHandle);
                if (item != null && item.ACCostObjectItemIsAllocated)
                {
                    e.ErrorText = "Không được chỉnh sửa chứng từ vì đã chạy phân bổ";
                    e.Valid = false;
                }
            }
        }
    }
}
