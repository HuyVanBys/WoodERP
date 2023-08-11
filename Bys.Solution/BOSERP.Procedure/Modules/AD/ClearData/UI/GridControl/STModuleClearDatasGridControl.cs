using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.ClearData
{
    public class STModuleClearDatasGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ClearDataEntities entity = (ClearDataEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ClearDataList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            STModulesController objModulesController = new STModulesController();
            DataSet dsModules = objModulesController.GetAllModules();
            GridColumn column = new GridColumn();
            if (gridView.Columns["STModuleID"] != null)
            {
                column = gridView.Columns["STModuleID"];
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = (object)dsModules.Tables[0];
                repositoryItemLookUpEdit.ValueMember = "STModuleID";
                repositoryItemLookUpEdit.DisplayMember = "STModuleDescription";
                repositoryItemLookUpEdit.ShowHeader = false;
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                LookUpColumnInfo columnInfo = new LookUpColumnInfo();
                columnInfo.FieldName = "STModuleDescription";
                repositoryItemLookUpEdit.Columns.Add(columnInfo);
                repositoryItemLookUpEdit.PopupWidth = columnInfo.Width;
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemModuleLookupEdit_QueryPopUp);
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
            column = new GridColumn();
            column.Caption = "Xoá dữ liệu";
            column.FieldName = "ClearData";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            RepositoryItemHyperLinkEdit rpItemAddNewRow = new RepositoryItemHyperLinkEdit();
            rpItemAddNewRow.NullText = "Xoá dữ liệu";
            rpItemAddNewRow.Click += new EventHandler(rpClearData_Click);
            column.ColumnEdit = rpItemAddNewRow;
            gridView.Columns.Add(column);
        }

        private void repositoryItemModuleLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            STModulesController objModulesController = new STModulesController();
            DataSet dsModules = objModulesController.GetAllModules();
            lookUpEdit.Properties.DataSource = (object)dsModules.Tables[0];
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ClearDataModule)Screen.Module).DeleteItemFromModulePostingList();
            }
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            GridColumn column = gridView.Columns["STModuleID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["STModuleClearDataFunction"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }
        private void rpClearData_Click(object sender, EventArgs e)
        {
            ClearDataEntities entity = (ClearDataEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            if (entity.ClearDataList.CurrentIndex >= 0)
            {
                ((ClearDataModule)Screen.Module).ClearData(entity.ClearDataList[entity.ClearDataList.CurrentIndex]);
            }
        }
    }
}
