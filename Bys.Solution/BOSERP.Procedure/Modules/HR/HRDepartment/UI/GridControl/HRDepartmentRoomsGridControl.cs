using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.HRDepartment
{
    public partial class HRDepartmentRoomsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HRDepartmentEntities entity = (HRDepartmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.DepartmentRoomList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            GridColumn column = gridView.Columns["HRDepartmentRoomNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRDepartmentRoomName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRDepartmentRoomDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_BRBranchID"];
            if (column != null)
            {
                //column.OptionsColumn.AllowEdit = true;
                column.Visible = false;
            }

            column = gridView.Columns["HRDepartmentRoomBoundary"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((HRDepartmentModule)Screen.Module).RemoveItemFromList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            HRDepartmentEntities entity = (HRDepartmentEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.DepartmentRoomList.CurrentIndex >= 0)
            {
                if (e.Column.FieldName == "HRDepartmentRoomBoundary")
                {
                    ((HRDepartmentModule)Screen.Module).ChangeDepartmentRoomBoundary();

                }
            }
        }
    }
}
