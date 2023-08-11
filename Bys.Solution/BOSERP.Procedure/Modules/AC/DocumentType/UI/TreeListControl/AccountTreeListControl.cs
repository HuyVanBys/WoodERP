using BOSComponent;
using DevExpress.XtraTreeList.Columns;
using Localization;

namespace BOSERP.Modules.ACDocumentType
{
    public class AccountTreeListControl : BOSTreeListControl
    {
        public override void InitializeControl()
        {
            base.InitializeControl();
            this.ExpandAll();
        }

        protected override void InitTreeListDataSource()
        {
            ACDocumentTypeEntities entity = (ACDocumentTypeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BOSTreeList dataSource = new BOSTreeList();
            dataSource.Add(new ACAccountsInfo(DocumentTypeLocalizedResources.AccountNo, DocumentTypeLocalizedResources.AccountName));
            ACAccountsController objAccountsController = new ACAccountsController();

            dataSource[0].SubList = entity.ACAccountList;
            DataSource = dataSource;
        }

        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);

            TreeListColumn column = Columns["ACAccountNo"];
            column.VisibleIndex = 1;
            column.OptionsColumn.AllowEdit = false;

            column = Columns["ACAccountName"];
            column.VisibleIndex = 2;
            column.OptionsColumn.AllowEdit = false;

            column = Columns["Selected"];
            column.Caption = "Chọn";
            column.VisibleIndex = 3;
            column.OptionsColumn.AllowEdit = true;
        }
    }
}
