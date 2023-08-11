using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using BOSCommon;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList;
using BOSLib;
using System.Linq;


namespace BOSERP.Modules.ProductTemplate
{
    public partial class ICProductTemplateItemsTreeListControl : BOSTreeListControl
    {
        #region  properties
        private List<AAColumnAliasInfo> ColumnAliasList { get; set; }

        public enum ProductTemplatesColumnName
        {
            ICProductTemplateItemNo,
            ICProductTemplateItemName,
            ICProductTemplateItemDesc,
            ICProductTemplateItemCatalog,
            FK_ICProductTemplateConfigID,
            ICProductTemplateItemType,
            ICProductTemplateItemRefValue01,
            ICProductTemplateItemRefValue02,
            ICProductTemplateItemRefValue03,
            ICProductTemplateItemRefValue04
        }
        #endregion

        protected override void InitTreeListDataSource()
        {
            ProductTemplateEntities entity = (ProductTemplateEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            DataSource = entity.ProductTemplateItemsTreeList;
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
            ProductTemplateEntities entity = (ProductTemplateEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            //TreeListNode node = entity.ProductTemplatesTreeList.TreeListControl.GetSelectedNode();
        }

        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);

            ColumnAliasList = new List<AAColumnAliasInfo>();
            AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
            DataSet dsColumns = objAAColumnAliasController.GetAAColumnAliasByTableName(TableName.ICProductTemplateItemsTableName);

            foreach (DataRow rowColumn in dsColumns.Tables[0].Rows)
            {
                AAColumnAliasInfo objAAColumnAliasInfo = (AAColumnAliasInfo)objAAColumnAliasController.GetObjectFromDataRow(rowColumn);
                ColumnAliasList.Add(objAAColumnAliasInfo);
            }

            AddTreeListColumns(1, ProductTemplatesColumnName.ICProductTemplateItemNo, true, false);
            AddTreeListColumns(2, ProductTemplatesColumnName.ICProductTemplateItemName, true, false);
            AddTreeListColumns(3, ProductTemplatesColumnName.ICProductTemplateItemCatalog, false, true);
            AddTreeListColumns(4, ProductTemplatesColumnName.ICProductTemplateItemDesc, false, true);
            AddTreeListColumns(5, ProductTemplatesColumnName.ICProductTemplateItemType, false, true);
            AddTreeListColumns(6, ProductTemplatesColumnName.ICProductTemplateItemRefValue01, false, true);
            AddTreeListColumns(7, ProductTemplatesColumnName.ICProductTemplateItemRefValue02, false, true);
            AddTreeListColumns(8, ProductTemplatesColumnName.ICProductTemplateItemRefValue03, false, true);
            AddTreeListColumns(9, ProductTemplatesColumnName.ICProductTemplateItemRefValue04, false, true);
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
                case ProductTemplatesColumnName.ICProductTemplateItemNo:
                    column.MinWidth = 100;
                    break;

                case ProductTemplatesColumnName.ICProductTemplateItemName:
                    column.MinWidth = 150;
                    break;

                case ProductTemplatesColumnName.ICProductTemplateItemCatalog:
                    column.MinWidth = 150;
                    break;

                case ProductTemplatesColumnName.ICProductTemplateItemDesc:
                    column.MinWidth = 400;
                    break;

                case ProductTemplatesColumnName.ICProductTemplateItemType:
                    column.MinWidth = 100;
                    repositoryItemLookUpEdit = InitRepositoryForConfigValues(ADConfigValueUtility.ConfigValues.Tables["ProductTemplateItemType"]);
                    column.ColumnEdit = repositoryItemLookUpEdit;
                    break;

                case ProductTemplatesColumnName.ICProductTemplateItemRefValue01:
                    column.MinWidth = 150;
                    repositoryItemLookUpEdit = InitRepositoryForCustomize();
                    column.ColumnEdit = repositoryItemLookUpEdit;
                    break;

                case ProductTemplatesColumnName.ICProductTemplateItemRefValue02:
                    column.MinWidth = 150;
                    repositoryItemLookUpEdit = InitRepositoryForCustomize();
                    column.ColumnEdit = repositoryItemLookUpEdit;
                    break;
                case ProductTemplatesColumnName.ICProductTemplateItemRefValue03:
                    column.MinWidth = 150;
                    repositoryItemLookUpEdit = InitRepositoryForCustomize();
                    column.ColumnEdit = repositoryItemLookUpEdit;
                    break;
                case ProductTemplatesColumnName.ICProductTemplateItemRefValue04:
                    column.MinWidth = 150;
                    repositoryItemLookUpEdit = InitRepositoryForCustomize();
                    column.ColumnEdit = repositoryItemLookUpEdit;
                    break;
            }

            AAColumnAliasInfo objColumnAliasInfo = ColumnAliasList.Where(s => s.AAColumnAliasName == fieldName.ToString()).FirstOrDefault();
            column.Caption = objColumnAliasInfo == null ? column.Caption : objColumnAliasInfo.AAColumnAliasCaption;

            this.EndUpdate();
            this.Update();
        }

        protected RepositoryItemLookUpEdit InitRepositoryForConfigValues(DataTable dataSource)
        {
            RepositoryItemLookUpEdit repLookupEdit = new RepositoryItemLookUpEdit();
            repLookupEdit.DataSource = dataSource;
            repLookupEdit.ValueMember = "Value";
            repLookupEdit.DisplayMember = "Text";
            repLookupEdit.ShowHeader = false;
            repLookupEdit.TextEditStyle = TextEditStyles.Standard;
            DevExpress.XtraEditors.Controls.LookUpColumnInfo repColumn = new DevExpress.XtraEditors.Controls.LookUpColumnInfo();
            repColumn.FieldName = "Text";
            repColumn.Width = 100;
            repLookupEdit.Columns.Add(repColumn);
            repLookupEdit.PopupWidth = repColumn.Width;
            return repLookupEdit;
        }

        protected RepositoryItemLookUpEdit InitRepositoryForCustomize()
        {
            RepositoryItemLookUpEdit repLookupEdit = new RepositoryItemLookUpEdit();
            repLookupEdit.DataSource = InitDataSource(string.Empty);
            repLookupEdit.ValueMember = "ObjectKey";
            repLookupEdit.DisplayMember = "Name";
            repLookupEdit.ShowHeader = false;
            repLookupEdit.TextEditStyle = TextEditStyles.Standard;
            repLookupEdit.Columns.Add(new LookUpColumnInfo() { FieldName = "No", Width = 100 });
            repLookupEdit.Columns.Add(new LookUpColumnInfo() { FieldName = "Name", Width = 150 });
            repLookupEdit.Columns.Add(new LookUpColumnInfo() { FieldName = "Desc", Width = 250 });
            repLookupEdit.PopupWidth = 500;
            repLookupEdit.QueryPopUp += new CancelEventHandler(repLookupEdit_QueryPopUp);
            return repLookupEdit;
        }

        private void repLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ProductTemplateEntities entity = (ProductTemplateEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ICProductTemplateItemsInfo item = (ICProductTemplateItemsInfo)entity.ProductTemplateItemsTreeList.CurrentObject;
            List<ADCustomizeLookupsInfo> datasource = new List<ADCustomizeLookupsInfo>();
            if (item == null)
            {
                datasource.Insert(0, new ADCustomizeLookupsInfo());
            }
            else
            {
                datasource = InitDataSource(item.ICProductTemplateItemType);
            }
            lookUpEdit.Properties.DataSource = datasource;
        }

        private List<ADCustomizeLookupsInfo> InitDataSource(string type)
        {
            ADCustomizeLookupsController controller = new ADCustomizeLookupsController();
            List<ADCustomizeLookupsInfo> datasource = controller.GetDataSourceForProductTempalteByType(type);
            datasource.Insert(0, new ADCustomizeLookupsInfo());
            return datasource;
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.KeyCode == Keys.Delete)
            {
                ((ProductTemplateModule)Screen.Module).DeleteProductTemplateItemTreeList();
            }
        }
    }
}
