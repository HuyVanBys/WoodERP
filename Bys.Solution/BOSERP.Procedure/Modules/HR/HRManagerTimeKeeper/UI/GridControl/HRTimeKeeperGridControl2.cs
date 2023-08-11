using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.ManagerTimeKeeper
{
    public partial class HRTimeKeeperGridControl2 : BOSComponent.BOSGridControl
    {
        public void InvalidateDataSource(List<HRTimeKeepersInfo> timeKeepers)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = timeKeepers;
            this.DataSource = bds;
            RefreshDataSource();
        }

        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit;
        public override void InitializeControl()
        {
            base.InitializeControl();
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            GridColumn column = new GridColumn();

            //column.Caption = BaseLocalizedResources.Select;
            //column.FieldName = "Selected";
            //column.OptionsColumn.AllowEdit = true;
            //gridView.Columns.Insert(0, column);
            //column.VisibleIndex = 0;

            // repositoryItemDateEdit
            repositoryItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            repositoryItemDateEdit.AutoHeight = false;
            repositoryItemDateEdit.DisplayFormat.FormatString = "dd/MM";
            repositoryItemDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit.Mask.EditMask = "dd/MM";
            repositoryItemDateEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            repositoryItemDateEdit.Name = "repositoryItemDateEdit1";

            column = gridView.Columns["HRTimeKeeperQuickImportDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.ColumnEdit = repositoryItemDateEdit;
            }
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            gridView.Columns.Clear();

            GridColumn column = new GridColumn();

            column = new GridColumn();
            column.Caption = "Ngày";
            column.FieldName = "HRTimeKeeperQuickImportDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ManagerTimeKeeperLocalizedResources.ThName;
            column.FieldName = "ThName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
