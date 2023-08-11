using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AccountInitialBalance
{
    public partial class AccountTreeListControl : BOSTreeListControl
    {
        public override void InitializeControl()
        {
            base.InitializeControl();
            ExpandAll();
            FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(TreeList_FocusedNodeChanged);
            ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(AccountTreeListControl_ValidatingEditor);
            CellValueChanged += new CellValueChangedEventHandler(AccountTreeListControl_CellValueChanged);
            MouseClick += new MouseEventHandler(AccountTreeListControl_MouseClick);
        }

        private void AccountTreeListControl_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            BOSTreeListControl treeListControl = (BOSTreeListControl)sender;
            AccountInitialBalanceEntities entity = (AccountInitialBalanceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ACAccountsInfo objAccountsInfo = (ACAccountsInfo)entity.AccountList.CurrentObject;
            if (objAccountsInfo.ACAccountType.Equals(AccAccountType.DebitCreditBalance.ToString()))
            {
                if (treeListControl.FocusedColumn.FieldName == "ACAccountInitialBalanceCredit")
                {
                    if (objAccountsInfo.ACAccountInitialBalanceCredit != 0)
                        objAccountsInfo.ACAccountInitialBalanceDebit = 0;

                }
                if (treeListControl.FocusedColumn.FieldName == "ACAccountInitialBalanceDebit")
                {
                    if (objAccountsInfo.ACAccountInitialBalanceDebit != 0)
                        objAccountsInfo.ACAccountInitialBalanceCredit = 0;
                }
            }
            ((AccountInitialBalanceModule)Screen.Module).UpdateInitialBalanceAccountParent(objAccountsInfo);
            treeListControl.RefreshDataSource();
        }


        private void AccountTreeListControl_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            BOSTreeListControl treeListControl = (BOSTreeListControl)sender;
            AccountInitialBalanceEntities entity = (AccountInitialBalanceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ACAccountsInfo objAccountsInfo = (ACAccountsInfo)entity.AccountList.CurrentObject;
            if (!objAccountsInfo.ACAccountType.Equals(AccAccountType.DebitCreditBalance.ToString()))
            {
                if (treeListControl.FocusedColumn.FieldName == "ACAccountInitialBalanceCredit")
                {
                    if (objAccountsInfo.ACAccountType.Equals(AccAccountType.DebitBalance.ToString()))
                    {
                        if (Convert.ToDouble(e.Value) != 0)
                        {
                            e.ErrorText = AccountInitialBalanceLocalizedResource.NotAllowInputInitialBalanceCreditErrorText;
                            e.Valid = false;
                            return;
                        }
                    }
                }
                if (treeListControl.FocusedColumn.FieldName == "ACAccountInitialBalanceDebit")
                {
                    if (objAccountsInfo.ACAccountType.Equals(AccAccountType.CreditBalance.ToString()))
                    {
                        if (Convert.ToDouble(e.Value) != 0)
                        {
                            e.ErrorText = AccountInitialBalanceLocalizedResource.NotAllowInputInitialBalanceDebitErrorText;
                            e.Valid = false;
                            return;
                        }
                    }
                }
            }
        }

        protected override void InitTreeListDataSource()
        {
            AccountInitialBalanceEntities entity = (AccountInitialBalanceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BOSTreeList dataSource = new BOSTreeList();
            dataSource.Add(new ACAccountsInfo(AccountInitialBalanceLocalizedResource.ACAccountInitialBalanceDesc));
            ACAccountsController objAccountsController = new ACAccountsController();

            List<ACAccountsInfo> rootAccounts = objAccountsController.GetAllRootAccounts();
            rootAccounts = rootAccounts.Where(a => a.ACAccountType != AccountType.NoBalance.ToString()).ToList();
            entity.AccountList.Invalidate(rootAccounts);
            ((AccountInitialBalanceModule)Screen.Module).InvalidateAccountList();
            dataSource[0].SubList = entity.AccountList;
            DataSource = dataSource;
        }

        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);

            TreeListColumn column = Columns["ACAccountNo"];
            column.VisibleIndex = 1;
            column.OptionsColumn.AllowEdit = false;

            column = Columns["ACAccountName"];
            column.Width = 350;
            column.VisibleIndex = 2;
            column.OptionsColumn.AllowEdit = false;

            DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repText = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            repText.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            repText.Mask.EditMask = "n0";
            repText.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            repText.Mask.UseMaskAsDisplayFormat = true;

            column = InitTreeListColumn(TableName.ACAccountsTableName, 3, "ACAccountInitialBalanceDebit", AccountInitialBalanceLocalizedResource.AccountDebitBalance, 150);
            Columns.AddRange(new TreeListColumn[] { column });
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            column.ColumnEdit = repText;
            RepositoryItems.Add(column.ColumnEdit);
            column.OptionsColumn.AllowEdit = false;

            column = InitTreeListColumn(TableName.ACAccountsTableName, 4, "ACAccountInitialBalanceCredit", AccountInitialBalanceLocalizedResource.AccountCreditBalance, 150);
            Columns.AddRange(new TreeListColumn[] { column });
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            column.ColumnEdit = repText;
            RepositoryItems.Add(column.ColumnEdit);
            column.OptionsColumn.AllowEdit = false;
        }

        private void TreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            AccountInitialBalanceEntities entity = (AccountInitialBalanceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            TreeListNode node = entity.AccountList.TreeListControl.GetSelectedNode();
            if (node != null && node.Level > 0)
            {
                ACAccountsInfo objAccountsInfo = (ACAccountsInfo)entity.AccountList.CurrentObject;
            }
        }

        private void AccountTreeListControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((AccountInitialBalanceModule)Screen.Module).ShowContextMenu(e.X, e.Y);
            }
        }
    }
}
