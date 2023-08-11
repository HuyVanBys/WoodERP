using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraTreeList.Nodes;
using Localization;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace BOSERP.Modules.Account
{
    public class AccountModule : BaseModuleERP
    {
        #region Constants
        public const string AccountTreeListControlName = "fld_trlACAccounts";
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public AccountModule()
        {
            Name = "Account";
            CurrentModuleEntity = new AccountEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

        }
        #endregion

        #region Context Menu
        /// <summary>
        /// Show Context Menu when user clicks right button of mouse
        /// </summary>
        public void ShowContextMenu(MouseEventArgs e)
        {
            ContextMenu contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add(AccountLocalizedResources.NewAccount, new System.EventHandler(NewAccount_Click));
            contextMenu.MenuItems.Add(AccountLocalizedResources.EditAccount, new System.EventHandler(EditAccount_Click));
            contextMenu.MenuItems.Add(AccountLocalizedResources.DeleteAccount, new System.EventHandler(DeleteAccount_Click));

            BOSTreeListControl accountTreeListControl = (BOSTreeListControl)Controls[AccountModule.AccountTreeListControlName];
            contextMenu.Show(accountTreeListControl, new Point(e.X, e.Y));

        }

        /// <summary>
        /// Add new account to account list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void NewAccount_Click(Object sender, System.EventArgs e)
        {
            ShowAccount(AccountLocalizedResources.NewAccount);
        }

        /// <summary>
        /// Edit account in account list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void EditAccount_Click(object sender, System.EventArgs e)
        {
            ShowAccount(AccountLocalizedResources.EditAccount);
        }


        /// <summary>
        /// Delete account in account list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DeleteAccount_Click(object sender, System.EventArgs e)
        {
            ACAccountsController objAccountsController = new ACAccountsController();
            AccountEntities entity = (AccountEntities)CurrentModuleEntity;
            ACAccountsInfo objAccountsInfo = ProcessBeforeShowAccount(AccountLocalizedResources.DeleteAccount);
            entity.ACAccountList.RemoveSelectedRowObjectFromList();
            objAccountsController.DeleteObject(objAccountsInfo.ACAccountID);
            objAccountsController.DeleteAccountsByAccountParentID(objAccountsInfo.ACAccountID);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Show screen to add new account
        /// </summary>
        private void ShowAccount(string eventName)
        {
            int accountParentID = 0;
            ACAccountsController objAccountsController = new ACAccountsController();
            ACAccountsInfo objAccountsInfo = ProcessBeforeShowAccount(eventName);
            AccountEntities entity = (AccountEntities)CurrentModuleEntity;
            AccountTreeListControl treeListControl = (AccountTreeListControl)entity.ACAccountList.TreeListControl;
            guiAddNewAccount guiAddNewAccount = new guiAddNewAccount();
            guiAddNewAccount.Module = this;
            if (guiAddNewAccount.ShowDialog() == DialogResult.OK)
            {
                treeListControl.EndCurrentEdit();
                if (eventName.Equals(AccountLocalizedResources.NewAccount))
                {
                    accountParentID = objAccountsInfo.ACAccountID;
                    AddItemToAccountList(objAccountsInfo, accountParentID);
                }
                else if (eventName.Equals(AccountLocalizedResources.EditAccount))
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    BOSTreeListObject currentObject = entity.ACAccountList.CurrentObject;
                    PropertyInfo[] props = currentObject.GetType().GetProperties();
                    foreach (PropertyInfo prop in props)
                        if (typeof(BOSTreeListObject).GetProperty(prop.Name) == null)
                            dbUtil.SetPropertyValue(currentObject, prop.Name, dbUtil.GetPropertyValue(objAccountsInfo, prop.Name));
                    objAccountsController.UpdateObject(objAccountsInfo);
                    UpdateChildAccount(objAccountsInfo);
                }
            }
            treeListControl.RefreshDataSource();
            treeListControl.ExpandAll();
        }

        /// <summary>
        /// Process before show account
        /// </summary>
        /// <param name="eventName">event name</param>
        /// <returns>Account info</returns>
        private ACAccountsInfo ProcessBeforeShowAccount(string eventName)
        {
            ACAccountsInfo objAccountsInfo = new ACAccountsInfo();
            AccountEntities entity = (AccountEntities)CurrentModuleEntity;
            TreeListNode node = entity.ACAccountList.TreeListControl.GetSelectedNode();
            if (node != null && node.Level > 0)
            {
                objAccountsInfo = (ACAccountsInfo)entity.ModuleObjects[TableName.ACAccountsTableName];
                if (eventName.Equals(AccountLocalizedResources.NewAccount))
                {
                    objAccountsInfo = (ACAccountsInfo)entity.ModuleObjects[TableName.ACAccountsTableName];
                    objAccountsInfo.ACAccountNo = string.Empty;
                    objAccountsInfo.ACAccountName = string.Empty;
                }
            }
            return objAccountsInfo;
        }

        /// <summary>
        /// Add item to account list
        /// </summary>
        public void AddItemToAccountList(ACAccountsInfo objAccountsInfo, int accountParentID)
        {
            ACAccountsController objAccountsController = new ACAccountsController();
            AccountEntities entity = (AccountEntities)CurrentModuleEntity;
            objAccountsInfo = (ACAccountsInfo)entity.ModuleObjects[TableName.ACAccountsTableName];
            objAccountsInfo.ACAccountParentID = accountParentID;
            objAccountsInfo.SubList = new BOSTreeList();
            if (entity.ACAccountList.CurrentObject.SubList == null)
            {
                entity.ACAccountList.CurrentObject.SubList = new BOSTreeList();
            }
            entity.ACAccountList.CurrentObject.SubList.Add(objAccountsInfo);
            objAccountsController.CreateObject(objAccountsInfo);
        }

        /// <summary>
        /// Update the child account when parent account changed
        /// </summary>
        /// <param name="objAccountsInfo">Given account info</param>
        public void UpdateChildAccount(ACAccountsInfo objAccountsInfo)
        {
            ACAccountsController objAccountsController = new ACAccountsController();
            AccountEntities entity = (AccountEntities)CurrentModuleEntity;
            if (objAccountsInfo.HasChildren())
            {
                foreach (ACAccountsInfo currentAccount in objAccountsInfo.SubList)
                {
                    currentAccount.ACAccountType = objAccountsInfo.ACAccountType;
                    currentAccount.ACAccountPostingRule = objAccountsInfo.ACAccountPostingRule;
                    currentAccount.IsActive = objAccountsInfo.IsActive;
                    objAccountsController.UpdateObject(currentAccount);
                    if (currentAccount.SubList != null && currentAccount.SubList.Count > 0)
                        UpdateChildAccount(currentAccount);
                }
            }
        }

        #endregion
    }
}