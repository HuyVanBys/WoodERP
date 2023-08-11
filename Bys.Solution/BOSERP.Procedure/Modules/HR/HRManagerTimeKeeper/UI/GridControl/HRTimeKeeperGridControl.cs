using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.ManagerTimeKeeper
{
    public partial class HRTimeKeeperGridControl : BOSComponent.BOSGridControl
    {
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit;
        public override void InitializeControl()
        {
            base.InitializeControl();
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            gridView.OptionsView.ShowFooter = true;
            GridColumn column = gridView.Columns["HRTimeKeeperDate"];
            if (column != null)
            {
                column.Group();
            }
            column = null;
            column = gridView.Columns["FK_HRMachineTimeKeeperID"];
            if (column != null)
            {
                //column.Group();
            }



            // repositoryItemDateEdit
            repositoryItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            repositoryItemDateEdit.AutoHeight = false;
            repositoryItemDateEdit.DisplayFormat.FormatString = "HH:mm:ss";
            repositoryItemDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit.Mask.EditMask = "HH:mm:ss";
            repositoryItemDateEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            repositoryItemDateEdit.Name = "repositoryItemDateEdit1";

            column = gridView.Columns["HRTimeKeeperTimeIn"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.ColumnEdit = repositoryItemDateEdit;
            }

            column = gridView.Columns["HRTimeKeeperTimeOut"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.ColumnEdit = repositoryItemDateEdit;
            }

        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = ManagerTimeKeeperLocalizedResources.EmployeeName;
            column.FieldName = "EmployeeName";
            column.OptionsColumn.AllowEdit = false;
            column.Group();
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ManagerTimeKeeperLocalizedResources.ThName;
            column.FieldName = "ThName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            //column = new GridColumn();
            //column = gridView.Columns["HRTimeKeeperTimeOut"];
            //if (column != null)
            //{
            //    column.OptionsColumn.AllowEdit = true;
            //}

            //column = new GridColumn();
            //column = gridView.Columns["HRTimeKeeperTimeIn"];
            //if (column != null)
            //{
            //    column.OptionsColumn.AllowEdit = true;
            //}
        }
        //protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        //{
        //    base.GridView_KeyUp(sender, e);

        //    if (e.KeyCode == Keys.Delete)
        //    {
        //        if (e.KeyCode == Keys.Delete)
        //        {
        //            GridView view = sender as GridView;
        //            view.DeleteRow(view.FocusedRowHandle);
        //        }
        //    }
        //}

    }
}
