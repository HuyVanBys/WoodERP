using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ACDocumentType
{
    public class ACDocTypeEntryFunctionMappingsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ACDocTypeEntryFunctionMappingList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            STModulesController objModulesController = new STModulesController();
            DataSet dsModules = objModulesController.GetAllModules();
            GridColumn column = gridView.Columns["FK_STModuleID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                //RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                //repositoryItemLookUpEdit.DataSource = (object)dsModules.Tables[0];
                //repositoryItemLookUpEdit.ValueMember = "STModuleID";
                //repositoryItemLookUpEdit.DisplayMember = "STModuleDescription";
                //repositoryItemLookUpEdit.ShowHeader = false;
                //repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                //LookUpColumnInfo columnInfo = new LookUpColumnInfo();
                //columnInfo.FieldName = "STModuleDescription";
                //repositoryItemLookUpEdit.Columns.Add(columnInfo);
                //repositoryItemLookUpEdit.PopupWidth = columnInfo.Width;
                //column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                //repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemModuleLookupEdit_QueryPopUp);
                //this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }

            STToolbarsController objToolbarsController = new STToolbarsController();
            DataSet dsToolbars = objToolbarsController.GetAllObjects();
            column = gridView.Columns["FK_STToolbarID"];
            if (column != null)
            {
                //GridColumn column = gridView.Columns["FK_STToolbarID"];
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = (object)dsToolbars.Tables[0];
                repositoryItemLookUpEdit.ValueMember = "STToolbarID";
                repositoryItemLookUpEdit.DisplayMember = "STToolbarCaption";
                repositoryItemLookUpEdit.ShowHeader = false;
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                LookUpColumnInfo columnInfo = new LookUpColumnInfo();
                columnInfo.FieldName = "STToolbarCaption";
                repositoryItemLookUpEdit.Columns.Add(columnInfo);
                repositoryItemLookUpEdit.PopupWidth = columnInfo.Width;
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemToolbarLookupEdit_QueryPopUp);
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }

            ACDocumentTypesController objDocumentTypesController = new ACDocumentTypesController();
            DataSet dsDocumentTypes = objDocumentTypesController.GetAllObjects();
            column = gridView.Columns["FK_ACDocumentTypeID"];
            if (column != null)
            {
                //GridColumn column = gridView.Columns["FK_ACDocumentTypeID"];
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = (object)dsDocumentTypes.Tables[0];
                repositoryItemLookUpEdit.ValueMember = "ACDocumentTypeID";
                repositoryItemLookUpEdit.DisplayMember = "ACDocumentTypeDesc";
                repositoryItemLookUpEdit.ShowHeader = false;
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                LookUpColumnInfo columnInfo = new LookUpColumnInfo();
                columnInfo.FieldName = "ACDocumentTypeDesc";
                repositoryItemLookUpEdit.Columns.Add(columnInfo);
                repositoryItemLookUpEdit.PopupWidth = columnInfo.Width;
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }

            ACEntryTypesController objACEntryTypesController = new ACEntryTypesController();
            DataSet dsACEntryType = objACEntryTypesController.GetAllObjects();
            column = gridView.Columns["FK_ACEntryTypeID"];
            if (column != null)
            {
                //GridColumn column = gridView.Columns["FK_ACEntryTypeID"];
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DataSource = (object)dsACEntryType.Tables[0];
                repositoryItemLookUpEdit.ValueMember = "ACEntryTypeID";
                repositoryItemLookUpEdit.DisplayMember = "ACEntryTypeDesc";
                repositoryItemLookUpEdit.ShowHeader = false;
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                LookUpColumnInfo columnInfo = new LookUpColumnInfo();
                columnInfo.FieldName = "ACEntryTypeDesc";
                repositoryItemLookUpEdit.Columns.Add(columnInfo);
                repositoryItemLookUpEdit.PopupWidth = columnInfo.Width;
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
                this.RepositoryItems.Add(repositoryItemLookUpEdit);
            }
        }

        private void repositoryItemToolbarLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            GridView gridview = (GridView)MainView;
            ACDocTypeEntryFunctionMappingsInfo objDTEFMappingsInfo = (ACDocTypeEntryFunctionMappingsInfo)gridview.GetRow(gridview.FocusedRowHandle);
            if (objDTEFMappingsInfo != null && objDTEFMappingsInfo.FK_STModuleID >= 0)
            {
                STToolbarsController objToolbarsController = new STToolbarsController();
                DataSet dsToolbars = objToolbarsController.GetSTToolbarsBySTModuleIDAndSTUserGroupIDAndSTToolbarGroup(objDTEFMappingsInfo.FK_STModuleID, 1, BaseToolbar.ToolbarAction);
                List<STToolbarsInfo> toolbars = new List<STToolbarsInfo>();
                List<STToolbarsInfo> Result = new List<STToolbarsInfo>();
                if (dsToolbars.Tables.Count > 0)
                {
                    foreach (DataRow row in dsToolbars.Tables[0].Rows)
                    {
                        STToolbarsInfo objToolbarsInfo = (STToolbarsInfo)objToolbarsController.GetObjectFromDataRow(row);
                        toolbars.Add(objToolbarsInfo);
                    }
                }
                STToolbarsInfo objToolbarNew = toolbars.FirstOrDefault(o => o.STToolbarName == "fld_barbtnNew");
                if (objToolbarNew != null)
                {
                    Result = toolbars.Where(o => o.STToolbarName == "fld_barbtnNew" || o.STToolbarParentID == objToolbarNew.STToolbarID).ToList();
                    if (Result != null)
                    {
                        List<STToolbarsInfo> ResultChild = toolbars.Where(t => Result.Any(c => c.STToolbarID == t.STToolbarParentID && c.STToolbarName != "fld_barbtnNew") && t.STToolbarName != "fld_barbtnNew").ToList();
                        if (ResultChild != null)
                            Result.AddRange(ResultChild);
                    }
                }
                else
                    Result = toolbars.Where(o => o.STToolbarName == "fld_barbtnNew").ToList();
                lookUpEdit.Properties.DataSource = (object)Result;
            }
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
                ((ACDocumentTypeModule)Screen.Module).DeleteItemFromDocTypeEntryFunctionMappings();
            }
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            GridColumn column = gridView.Columns["FK_STModuleID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_STToolbarID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ACDocumentTypeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ACEntryTypeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }
    }
}
