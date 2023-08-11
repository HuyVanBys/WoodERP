using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.ManagerTimeKeeper
{
    public partial class HRTimeKeeperCompleteViewsGridControl : BOSComponent.BOSGridControl
    {
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit;

        public override void InitGridControlDataSource()
        {
            ManagerTimeKeeperEntities entity = (ManagerTimeKeeperEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.TimeKeeperCompleteListView;
            this.DataSource = bds;
        }

        public override void InitializeControl()
        {
            base.InitializeControl();
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = ManagerTimeKeeperLocalizedResources.EmployeeName;
            column.FieldName = "EmployeeName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ManagerTimeKeeperLocalizedResources.ThName;
            column.FieldName = "ThName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Bộ phận";
            column.FieldName = "HRDepartmentRoomName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tổ";
            column.FieldName = "HRDepartmentRoomGroupItemName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nhóm chấm công";
            column.FieldName = "HREmployeePayrollFormulaName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ManagerTimeKeeperLocalizedResources.TypeInput;
            column.FieldName = "HRTimeKeeperCompleteInOutMode";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã nhân viên";
            column.FieldName = "EmployeeNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column = gridView.Columns["HRTimeKeeperCompleteDate"];
            if (column != null)
            {
                column.Group();
                //column.OptionsColumn.AllowEdit = true;
            }

            column = new GridColumn();
            column = gridView.Columns["HRTimeKeeperCompletesEmployeeCardNo"];
            if (column != null)
            {
                column.Group();
            }

            //column = new GridColumn();
            //column = gridView.Columns["HRTimeKeeperCompleteTimeCheck"];
            //if (column != null)
            //{
            //    column.OptionsColumn.AllowEdit = true;
            //}
            //column = new GridColumn();
            //column = gridView.Columns["HRTimeKeeperCompleteComment"];
            //if (column != null)
            //{
            //    column.OptionsColumn.AllowEdit = true;
            //}
            //column = new GridColumn();
            //column.Caption = "Máy chấm công";
            //column.FieldName = "HRTimeKeeperCompleteMachineName";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);

        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.ExpandAllGroups();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            repositoryItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();

            // repositoryItemDateEdit
            repositoryItemDateEdit.AutoHeight = false;
            repositoryItemDateEdit.DisplayFormat.FormatString = "HH:mm:ss";
            repositoryItemDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit.Mask.EditMask = "HH:mm:ss";
            repositoryItemDateEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            repositoryItemDateEdit.Name = "repositoryItemDateEdit1";
            GridColumn column = gridView.Columns["HRTimeKeeperCompleteTimeCheck"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.ColumnEdit = repositoryItemDateEdit;
            }
            column = gridView.Columns["HRTimeKeeperCompleteInOutMode"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                //column.ColumnEdit = repositoryItemDateEdit;
            }
            gridView.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(gridView_InvalidRowException);
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.RowStyle += new RowStyleEventHandler(gridView_RowStyle);
            return gridView;
        }
        void gridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            ManagerTimeKeeperEntities entity = (ManagerTimeKeeperEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            GridView view = sender as GridView;
            GridView gridView = (GridView)MainView;
            if (e.RowHandle >= 0)
            {
                if (e.RowHandle == gridView.FocusedRowHandle)
                {
                    e.Appearance.ForeColor = Color.Black;
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                }


                HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo = (HRTimeKeeperCompletesInfo)gridView.GetRow(e.RowHandle);
                if (objTimeKeeperCompletesInfo != null)
                {
                    //bool isSameTime = ((ManagerTimeKeeperModule)Screen.Module).CheckSameTime(objTimeKeeperCompletesInfo, (List<HRTimeKeeperCompletesInfo>)this.DataSource);
                    bool isSameTime = ((ManagerTimeKeeperModule)Screen.Module).CheckSameTime(objTimeKeeperCompletesInfo, entity.TimeKeeperCompleteListView);
                    if (isSameTime)
                    {
                        e.Appearance.BackColor2 = Color.Red;
                        e.Appearance.BackColor = Color.Red;
                    }
                }
            }
        }


        void gridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            throw new NotImplementedException();
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    GridView view = sender as GridView;
                    view.DeleteRow(view.FocusedRowHandle);
                }
            }
        }

    }
}
