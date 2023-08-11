using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using Localization;
using System.Collections.Generic;

namespace BOSERP.Modules.Account
{
    public partial class AccountTreeListControl : BOSTreeListControl
    {
        public override void InitializeControl()
        {
            base.InitializeControl();
            this.ExpandAll();
            this.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(TreeList_FocusedNodeChanged);
        }

        protected override void InitTreeListDataSource()
        {
            AccountEntities entity = (AccountEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BOSTreeList dataSource = new BOSTreeList();
            //dataSource.Add(new ACAccountsInfo(AccountLocalizedResources.AccountNo, AccountLocalizedResources.AccountName, AccountLocalizedResources.ACAccountType, AccountLocalizedResources.ACAccountPostingRule));
            dataSource.Add(new ACAccountsInfo(AccountLocalizedResources.AccountDesc));
            ACAccountsController objAccountsController = new ACAccountsController();

            List<ACAccountsInfo> rootAccounts = objAccountsController.GetAllRootAccounts();
            entity.ACAccountList.Invalidate(rootAccounts);
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

            column = Columns["ACAccountType"];
            column.VisibleIndex = 3;
            column.OptionsColumn.AllowEdit = false;

            column = Columns["ACAccountPostingRule"];
            column.VisibleIndex = 4;
            column.OptionsColumn.AllowEdit = false;

            RepositoryItemCheckEdit rep = new RepositoryItemCheckEdit();
            column = Columns["IsActive"];
            column.VisibleIndex = 5;
            column.ColumnEdit = rep;
            column.OptionsColumn.AllowEdit = false;

            RepositoryItemCheckEdit repItemExpense = new RepositoryItemCheckEdit();
            column = Columns["ACAccountItemExpense"];
            column.VisibleIndex = 6;
            column.ColumnEdit = repItemExpense;
            column.OptionsColumn.AllowEdit = false;

            RepositoryItemCheckEdit repCenterExpense = new RepositoryItemCheckEdit();
            column = Columns["ACAccountCenterExpense"];
            column.VisibleIndex = 7;
            column.ColumnEdit = repCenterExpense;
            column.OptionsColumn.AllowEdit = false;

            RepositoryItemCheckEdit repProject = new RepositoryItemCheckEdit();
            column = Columns["ACAccountProject"];
            column.VisibleIndex = 8;
            column.ColumnEdit = repProject;
            column.OptionsColumn.AllowEdit = false;


            column = Columns["ACAccountControlAccountItemExpense"];
            column.VisibleIndex = 9;
            column.OptionsColumn.AllowEdit = false;

            column = Columns["ACAccountControlAccountCenterExpense"];
            column.VisibleIndex = 10;
            column.OptionsColumn.AllowEdit = false;

            column = Columns["ACAccountControlAccountProject"];
            column.VisibleIndex = 11;
            column.OptionsColumn.AllowEdit = false;

        }

        private void TreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            AccountEntities entity = (AccountEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            TreeListNode node = entity.ACAccountList.TreeListControl.GetSelectedNode();

            if (node != null && node.Level > 0)
            {
                ACAccountsInfo objAccountsInfo = (ACAccountsInfo)entity.ACAccountList.CurrentObject;
            }
        }
    }
}
