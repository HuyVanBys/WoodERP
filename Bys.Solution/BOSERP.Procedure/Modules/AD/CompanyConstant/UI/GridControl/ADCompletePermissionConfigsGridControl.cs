using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.CompanyConstant
{
    public partial class ADCompletePermissionConfigsGridControl : BOSGridControl
    {

        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CompletePermissionConfigList;
            this.DataSource = bds;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle < 0)
            {
                SendKeys.Send("{TAB}");
                return;
            }
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
                column.OptionsColumn.AllowEdit = true;

            GridColumn gridColumn = gridView.Columns["FK_STModuleID"];
            if (gridColumn != null)
            {
                STModuleCompletePermissionsController controller = new STModuleCompletePermissionsController();
                List<STModuleCompletePermissionsInfo> moduleList = controller.GetAllModuleFromConfig();
                gridColumn.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit ModuleLookUpEdit = new RepositoryItemLookUpEdit();
                ModuleLookUpEdit.DisplayMember = "STModuleDescription";
                ModuleLookUpEdit.ValueMember = "FK_STModuleID";
                ModuleLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                ModuleLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                ModuleLookUpEdit.NullText = string.Empty;
                ModuleLookUpEdit.Columns.Add(new LookUpColumnInfo("STModuleDescription", "Tên Module"));
                ModuleLookUpEdit.DataSource = moduleList;
                ModuleLookUpEdit.EditValueChanged += ModuleLookUpEdit_EditValueChanged;
                gridColumn.ColumnEdit = ModuleLookUpEdit;
            }
            gridColumn = gridView.Columns["ADCompletePermissionConfigCriteriaOperator"];
            if (gridColumn != null)
            {
                RepositoryItemButtonEdit repoWhereClause = new RepositoryItemButtonEdit();
                repoWhereClause.NullText = string.Empty;
                repoWhereClause.ButtonClick += RepoWhereClause_ButtonClick;
                repoWhereClause.TextEditStyle = TextEditStyles.DisableTextEditor;
                gridColumn.ColumnEdit = repoWhereClause;
            }
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            return gridView;
        }

        private void ModuleLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lookUp = sender as LookUpEdit;
            STModuleCompletePermissionsInfo module = (STModuleCompletePermissionsInfo)lookUp.GetSelectedDataRow();
            GridView gridView = (GridView)MainView;
            ADCompletePermissionConfigsInfo item = (ADCompletePermissionConfigsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            item.STSchemaTableName = module?.STSchemaTableName ?? string.Empty;
            gridView.RefreshData();
        }

        private void RepoWhereClause_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ButtonEdit btn = sender as ButtonEdit;
            if (gridView.FocusedRowHandle < 0)
                return;

            ADCompletePermissionConfigsInfo item = (ADCompletePermissionConfigsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            guiAddCompleteRules guiRules = new guiAddCompleteRules(item.STSchemaTableName, btn.Text);
            guiRules.ShowDialog();

            btn.EditValue = guiRules.WhereClause;
            item.ADCompletePermissionConfigCriteriaOperator = guiRules.WhereClause;
            item.ADCompletePermissionConfigSqlWhereClause = guiRules.SqlWhereClause;
            item.ADCompletePermissionConfigLinqWhereClause = guiRules.LinqWhereClause;
            gridView.RefreshData();
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ADCompletePermissionConfigSaleType")
            {
                if (e.Value != null)
                {
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    ADConfigValuesInfo objConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue("SaleOrderDocumentType", Convert.ToString(e.Value));
                    e.DisplayText = objConfigValuesInfo == null ? string.Empty : objConfigValuesInfo.ADConfigText;
                }
                else
                    e.DisplayText = "";
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).RemoveCompletePermissionConfig();
            }
        }

        private void SaleTypeLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (lookUpEdit == null)
                return;

            lookUpEdit.Properties.DataSource = GetDataSourceSaleType();
        }

        public List<ADConfigValuesInfo> GetDataSourceSaleType()
        {
            GridView gridView = (GridView)MainView;
            BOSDbUtil dbUtil = new BOSDbUtil();
            if (gridView.FocusedRowHandle < 0)
                return new List<ADConfigValuesInfo>();

            BusinessObject item = (BusinessObject)gridView.GetRow(gridView.FocusedRowHandle);

            int moduleID = dbUtil.GetPropertyIntValue(item, "FK_STModuleID");
            STModulesController objModulesController = new STModulesController();
            string moduleName = objModulesController.GetObjectNameByID(moduleID);
            List<ADConfigValuesInfo> configValueList = new List<ADConfigValuesInfo>();

            if (moduleName != ModuleName.SaleOrder)
                return configValueList;

            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = new DataSet();

            ADConfigValuesInfo objConfigValuesInfo = new ADConfigValuesInfo();
            ds = objConfigValuesController.GetADConfigValuesByGroup("SaleOrderDocumentType");

            if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    objConfigValuesInfo = new ADConfigValuesInfo();
                    objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectFromDataRow(row);
                    configValueList.Add(objConfigValuesInfo);
                }
            }
            configValueList.Insert(0, new ADConfigValuesInfo());
            return configValueList;
        }
    }
}
