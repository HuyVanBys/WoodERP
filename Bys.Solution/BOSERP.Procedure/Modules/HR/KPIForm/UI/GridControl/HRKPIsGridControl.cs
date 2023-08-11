using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using Localization;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.KPIForm
{
    public class HRKPIsGridControl : BOSComponent.BOSGridControl
    {
        public void InvalidateDataSource(List<HRKPIsInfo> kPIForms)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = kPIForms;
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

            column = gridView.Columns["HRKPIID"];
            if (column != null)
            {
                column.Group();
            }

            if (gridView.Columns["HRKPIMeasurementMethod"] != null)
            {
                RepositoryItemMemoEdit repositoryItemMemoEdit = new RepositoryItemMemoEdit();
                repositoryItemMemoEdit.AutoHeight = true;
                repositoryItemMemoEdit.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                repositoryItemMemoEdit.WordWrap = true;
                gridView.GridControl.RepositoryItems.Add(repositoryItemMemoEdit);
                gridView.OptionsView.RowAutoHeight = true;
                gridView.Columns["HRKPIMeasurementMethod"].ColumnEdit = repositoryItemMemoEdit;
            }

            return gridView;
        }
    }
}
