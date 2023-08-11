using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using Localization;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.KPIRegistration
{
    public class HRKPIFormItemsGridControl : BOSComponent.BOSGridControl
    {
        public void InvalidateDataSource(List<HRKPIFormItemsInfo> kPIFormItems)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = kPIFormItems;
            this.DataSource = bds;
            RefreshDataSource();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();

            GridColumn column = new GridColumn();
            column.Caption = BaseLocalizedResources.Select;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Insert(0, column);
            column.VisibleIndex = 0;

            column = gridView.Columns["FK_HRKPIFormID"];
            if (column != null)
            {
                column.Group();
            }

            if (gridView.Columns["HRKPIFormItemMeasurementMethod"] != null)
            {
                RepositoryItemMemoEdit repositoryItemMemoEdit = new RepositoryItemMemoEdit();
                repositoryItemMemoEdit.AutoHeight = true;
                repositoryItemMemoEdit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                repositoryItemMemoEdit.WordWrap = true;
                gridView.GridControl.RepositoryItems.Add(repositoryItemMemoEdit);
                gridView.OptionsView.RowAutoHeight = true;
                gridView.Columns["HRKPIFormItemMeasurementMethod"].ColumnEdit = repositoryItemMemoEdit;
            }

            return gridView;
        }
    }
}
