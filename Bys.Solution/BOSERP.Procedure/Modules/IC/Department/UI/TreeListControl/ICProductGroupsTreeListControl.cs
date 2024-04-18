using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList.Columns;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Department
{
    public partial class ICProductGroupsTreeListControl : BOSComponent.BOSTreeListControl
    {
        public override void InitializeControl()
        {
            base.InitializeControl();

            DepartmentEntities entity = (DepartmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            foreach (DevExpress.XtraTreeList.Columns.TreeListColumn column in this.Columns)
                column.OptionsColumn.AllowEdit = true;
            //this.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(ICProductGroupsTreeListControl_ValidatingEditor);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(ICProductGroupsTreeListControl_KeyUp);
        }

        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);

            this.Columns["ICProductGroupName"].VisibleIndex = 0;
            this.Columns["ICProductGroupNo"].VisibleIndex = 1;
            //this.Columns["FK_ICProductTypeAccountConfigID"].VisibleIndex = 3;
            TreeListColumn column = Columns.Add();
            column.Caption = ICDepartmentLocalizedResources.IsShowWebCaption;
            column.Visible = true;
            column.VisibleIndex = 2;
            column.FieldName = "ICProductGroupIsShowWeb";
            this.OptionsView.AutoWidth = true;
            column.OptionsColumn.FixedWidth = false;
            RepositoryItemCheckEdit repositoryItemCheckEdit = new RepositoryItemCheckEdit();
            column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemCheckEdit;
            this.RepositoryItems.Add(repositoryItemCheckEdit);

            this.Columns["ICProductGroupConfigStart"].VisibleIndex = 3;
            this.Columns["ICProductGroupConfigLength"].VisibleIndex = 4;
            this.Columns["ICProductGroupConfigGroupNoLength"].VisibleIndex = 5;

            column = Columns.Add();
            column.Caption = "% Thuế";
            column.Visible = true;
            column.VisibleIndex = 6;
            column.FieldName = "FK_GEVATID";
            RepositoryItemLookUpEdit rep = new RepositoryItemLookUpEdit();
            rep.DataSource = (new GEVATsController()).GetAllAliveVats();
            rep.ValueMember = "GEVATID";
            rep.DisplayMember = "GEVATPercentValue";
            rep.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GEVATPercentValue", "% thuế", 10, DevExpress.Utils.FormatType.Numeric, "n0", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default));
            if (!LookupTables.ContainsKey("GEVATs"))
                LookupTables.Add("GEVATs", (new GEVATsController()).GetAllObjects());
            if (!LookupTablesUpdatedDate.ContainsKey("GEVATs"))
                LookupTablesUpdatedDate.Add("GEVATs", BOSApp.GetCurrentServerDate());
            column.ColumnEdit = rep;
            column.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.Format.FormatString = "{0:n0}";
            this.RepositoryItems.Add(rep);

            column = Columns.Add();
            column.Caption = "Tên viết tắt";
            column.Visible = true;
            column.OptionsColumn.AllowEdit = true;
            column.VisibleIndex = 7;
            column.FieldName = "ICProductGroupAbbreviation";
            //TreeListColumn column2 = Columns.Add();
            //column2.Caption = "Nhóm tài khoản";
            //column2.Visible = true;
            //column2.VisibleIndex = 3;
            //column2.FieldName = "FK_ICProductTypeAccountConfigID";
            //column2.OptionsColumn.AllowEdit = true;
            //RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            //DataTable ProductTypeAccountConfigDataTable = new DataTable();
            //ICProductTypeAccountConfigsController objProductTypeAccountConfigsController = new ICProductTypeAccountConfigsController();
            //DataSet ds = objProductTypeAccountConfigsController.GetAllObjects();
            //if (ds != null)
            //    ProductTypeAccountConfigDataTable = ds.Tables[0];

            //repositoryItemLookUpEdit.DataSource = ProductTypeAccountConfigDataTable;
            //repositoryItemLookUpEdit.ValueMember = "ICProductTypeAccountConfigID";
            //repositoryItemLookUpEdit.DisplayMember = "ICProductTypeAccountConfigName";
            //repositoryItemLookUpEdit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductTypeAccountConfigName", "Nhóm tài khoản"));
            //column2.FieldName = "ICProductTypeAccountConfigName";
            //column2.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemLookUpEdit;
            //this.RepositoryItems.Add(repositoryItemLookUpEdit);
        }

        protected override void InitTreeListDataSource()
        {
            DepartmentEntities entity = (DepartmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BOSTreeList lst = new BOSTreeList();
            if (this.BOSDisplayRoot)
            {
                lst.Add(new ICProductGroupsInfo(ICDepartmentLocalizedResources.Category));
                lst[0].SubList = entity.ICProductGroupsList;
            }
            else
                lst = entity.ICProductGroupsList;
            this.DataSource = lst;
        }

        public void ICProductGroupsTreeListControl_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            BOSTreeListControl treeListControl = (BOSTreeListControl)sender;
            if (treeListControl.FocusedColumn.FieldName == "ICProductGroupNo")
            {
                if (e.Value == null || e.Value.ToString() == String.Empty)
                {
                    e.ErrorText = ICDepartmentLocalizedResources.CategoryNumberRequiredMessage;
                    e.Valid = false;
                    return;
                }

                DepartmentEntities entity = (DepartmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                ICProductGroupsInfo objCurrentProductGroupsInfo = (ICProductGroupsInfo)entity.ICProductGroupsList.CurrentObject;
                ICProductGroupsInfo objExistingProductGroupsInfo = (ICProductGroupsInfo)entity.ICProductGroupsList.GetObjectByPropertyNameAndValue("ICProductGroupNo", e.Value.ToString());
                if (objExistingProductGroupsInfo != null && objExistingProductGroupsInfo != objCurrentProductGroupsInfo)
                {
                    e.ErrorText = ICDepartmentLocalizedResources.CategoryNumberExistsMessage;
                    e.Valid = false;
                    return;
                }
            }
            else if (treeListControl.FocusedColumn.FieldName == "ICProductGroupName")
            {
                if (e.Value == null || e.Value.ToString() == String.Empty)
                {
                    e.ErrorText = ICDepartmentLocalizedResources.CategoryNameRequiredMessage;
                    e.Valid = false;
                    return;
                }
            }
        }

        private void ICProductGroupsTreeListControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((DepartmentModule)Screen.Module).DeleteProductGroupFromTreeList();
            }
        }
    }
}
