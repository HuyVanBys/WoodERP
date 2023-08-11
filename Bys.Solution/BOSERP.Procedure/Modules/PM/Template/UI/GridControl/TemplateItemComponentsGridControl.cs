using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Template
{
    public class TemplateItemComponentsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<PMTemplateItemComponentsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override GridView InitializeGridView()
        {
            DataTable TemplateItemWorkTypeDataTable = new DataTable();
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup("TemplateItemWorkType");
            if (ds != null)
                TemplateItemWorkTypeDataTable = ds.Tables[0];
            RepositoryItemLookUpEdit repositoryItemLookUpEdit;

            GridView gridView = base.InitializeGridView();
            if (gridView.Columns["PMTemplateItemComponentWorkType"] != null)
            {
                GridColumn column = gridView.Columns["PMTemplateItemComponentWorkType"];
                column.MinWidth = 100;
                column.OptionsColumn.AllowEdit = true;
                repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = (object)TemplateItemWorkTypeDataTable;
                repositoryItemLookUpEdit.ValueMember = "Value";
                repositoryItemLookUpEdit.DisplayMember = "Text";
                repositoryItemLookUpEdit.ShowHeader = false;
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                LookUpColumnInfo columnInfo = new LookUpColumnInfo();
                columnInfo.FieldName = "Text";
                columnInfo.Width = 100;
                repositoryItemLookUpEdit.Columns.Add(columnInfo);
                repositoryItemLookUpEdit.PopupWidth = columnInfo.Width;
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }

            if (gridView.Columns["PMTemplateItemComponentQty"] != null)
            {
                gridView.Columns["PMTemplateItemComponentQty"].OptionsColumn.AllowEdit = true;
            }
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            gridView.OptionsView.ShowAutoFilterRow = true;
            return gridView;
        }

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            //ShowInventory();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }
    }
}
