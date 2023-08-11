using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using System.Windows.Forms;


namespace BOSERP.Modules.CompanyConstant
{
    public partial class ICProductTemplateConfigsTreeListControl : BOSTreeListControl
    {
        #region  properties
        //private List<AAColumnAliasInfo> ColumnAliasList { get; set; }

        public enum ProductTemplatesColumnName
        {
            ICProductTemplateConfigNo,
            ICProductTemplateConfigName
        }
        #endregion

        protected override void InitTreeListDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            DataSource = entity.ProductTemplatesTreeList;
        }

        public override void InitializeControl()
        {
            base.InitializeControl();
            this.ExpandAll();
            this.OptionsView.AutoWidth = false;
            this.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Auto;
            this.OptionsView.ShowSummaryFooter = true;
            this.BOSDisplayRoot = false;
            this.BOSDisplayOption = true;
            this.ForceInitialize();
            this.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(ICCollectionItemsTreeListControl_CellValueChanged);
            this.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(TreeList_FocusedNodeChanged);
        }

        private void TreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {

        }

        private void ICCollectionItemsTreeListControl_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            string columnName = ((DevExpress.XtraTreeList.CellEventArgs)(e)).Column.FieldName;
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            TreeListNode node = entity.ProductTemplatesTreeList.TreeListControl.GetSelectedNode();
        }

        public override void InitTreeListColumns(string strTableName)
        {
            //base.InitTreeListColumns(strTableName);
            AddTreeListColumns(1, ProductTemplatesColumnName.ICProductTemplateConfigNo, true, false);
            AddTreeListColumns(2, ProductTemplatesColumnName.ICProductTemplateConfigName, false, true);

        }

        public void AddTreeListColumns(int index, ProductTemplatesColumnName fieldName, bool readOnly, bool allowEdit)
        {
            this.BeginUpdate();
            TreeListColumn column = Columns.Add();
            column.Visible = true;
            column.VisibleIndex = index;
            column.OptionsColumn.ReadOnly = readOnly;
            column.OptionsColumn.AllowEdit = allowEdit;
            this.OptionsView.AutoWidth = false;
            column.OptionsColumn.FixedWidth = false;
            column.FieldName = fieldName.ToString();
            RepositoryItemLookUpEdit repositoryItemLookUpEdit;
            RepositoryItemTextEdit repositoryItemTextEdit;
            LookUpColumnInfo columnInfo;
            switch (fieldName)
            {
                case ProductTemplatesColumnName.ICProductTemplateConfigNo:
                    column.Caption = "Mã khu vực";
                    column.MinWidth = 100;
                    break;
                case ProductTemplatesColumnName.ICProductTemplateConfigName:
                    column.Caption = "Tên khu vực";
                    column.MinWidth = 400;
                    break;

            }

            this.EndUpdate();
            this.Update();
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.KeyCode == Keys.Delete)
            {
                ((CompanyConstantModule)Screen.Module).ProductTemplateConfigsTreeList();
            }
        }
    }
}
