using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.AccountInitialBalance
{
    public class AccountInitialBalanceEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the account list
        /// </summary>
        public BOSTreeList AccountList { get; set; }

        /// <summary>
        /// Gets or sets the details of an account
        /// </summary>
        public BOSList<ACAccountDetailsInfo> AccountDetailList { get; set; }
        #endregion

        #region Constructor
        public AccountInitialBalanceEntities()
            : base()
        {
            AccountList = new BOSTreeList();
            AccountDetailList = new BOSList<ACAccountDetailsInfo>(TableName.ACAccountDetailsTableName);
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {

        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ACAccountsTableName, new ACAccountsInfo());
        }

        public override void InitModuleObjectList()
        {
            AccountList.InitBOSList(this,
                                    String.Empty,
                                    TableName.ACAccountsTableName,
                                    BOSTreeList.cstRelationNone);
            AccountDetailList.InitBOSList(this, string.Empty, TableName.ACAccountDetailsTableName);
        }

        public override void InitGridControlInBOSList()
        {
            AccountList.InitBOSTreeListControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                AccountList.SetDefaultListAndRefreshTreeListControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {

        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            AccountList.InvalidateTreeList(iObjectID);
        }

        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            AccountList.SaveItemObjects();
        }

        #endregion
    }
}
