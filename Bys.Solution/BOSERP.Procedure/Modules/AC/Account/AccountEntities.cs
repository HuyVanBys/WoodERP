using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.Account
{
    public class AccountEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the account list
        /// </summary>
        public BOSTreeList ACAccountList { get; set; }
        #endregion

        #region Constructor
        public AccountEntities()
            : base()
        {
            ACAccountList = new BOSTreeList();
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
            ACAccountList.InitBOSList(this,
                                    String.Empty,
                                    TableName.ACAccountsTableName,
                                    BOSTreeList.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            ACAccountList.InitBOSTreeListControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ACAccountList.SetDefaultListAndRefreshTreeListControl();
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
            ACAccountList.InvalidateTreeList(iObjectID);
        }

        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            ACAccountList.SaveItemObjects();
        }

        #endregion
    }
}
