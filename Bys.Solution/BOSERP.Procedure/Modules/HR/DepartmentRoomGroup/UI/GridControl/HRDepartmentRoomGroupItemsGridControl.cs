using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.DepartmentRoomGroup
{
    public class HRDepartmentRoomGroupItemsGridControl : BOSGridControl
    {
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        public override void InitGridControlDataSource()
        {
            DepartmentRoomGroupEntities entity = (DepartmentRoomGroupEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.DepartmentRoomGroupItemList;
            this.DataSource = bds;
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            GridColumn column = gridView.Columns["HRDepartmentRoomGroupItemNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HRDepartmentRoomGroupItemName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["HRDepartmentRoomGroupItemDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["HRDepartmentRoomGroupItemParentID"];
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
                ((DepartmentRoomGroupModule)Screen.Module).removeSelectRow();
            }
        }
        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            //      ((EmployeeScheduleModule)Screen.Module).UpdateEmployeeScheduleList();
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Công đoạn";
            column.FieldName = "Operation";
            column.VisibleIndex = 10;
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit rep2 = new RepositoryItemHyperLinkEdit();
            rep2.NullText = "Chi tiết";
            rep2.Click += new EventHandler(Operation_Click);
            column.ColumnEdit = rep2;
            gridView.Columns.Add(column);

        }
        void Operation_Click(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                HRDepartmentRoomGroupItemsInfo obj = (HRDepartmentRoomGroupItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null)
                {
                    ((DepartmentRoomGroupModule)Screen.Module).GetDataOperation(obj);
                }
            }
        }
    }
}
