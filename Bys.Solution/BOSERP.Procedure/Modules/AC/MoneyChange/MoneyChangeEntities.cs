using BOSCommon;
using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.MoneyChange
{
    public class MoneyChangeEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets bank transaction item list
        /// </summary>
        public BOSList<ACMoneyChangeItemsInfo> MoneyChangeItemList { get; set; }
        #endregion

        #region Constructor
        public MoneyChangeEntities()
            : base()
        {
            MoneyChangeItemList = new BOSList<ACMoneyChangeItemsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACMoneyChangesInfo();
            SearchObject = new ACMoneyChangesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ACMoneyChangeItemsTablename, new ACMoneyChangeItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            MoneyChangeItemList.InitBOSList(
                                                    this,
                                                    TableName.ACMoneyChangesTableName,
                                                    TableName.ACMoneyChangeItemsTablename,
                                                    BOSList<ACMoneyChangeItemsInfo>.cstRelationForeign);
            MoneyChangeItemList.ItemTableForeignKey = "FK_ACMoneyChangeID";
        }

        public override void InitGridControlInBOSList()
        {
            MoneyChangeItemList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ACMoneyChangesInfo objMoneyChangesInfo = (ACMoneyChangesInfo)MainObject;
            objMoneyChangesInfo.ACMoneyChangeDate = BOSApp.GetCurrentServerDate();
            objMoneyChangesInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                MoneyChangeItemList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Main Objects functions

        public override void InvalidateModuleObjects(int iObjectID)
        {
            MoneyChangeItemList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects and Main Object functions

        public override void SaveModuleObjects()
        {
            MoneyChangeItemList.SaveItemObjects();
        }
        #endregion

        public override bool CompleteTransaction()
        {
            ACMoneyChangesInfo objMoneyChangesInfo = (ACMoneyChangesInfo)MainObject;
            objMoneyChangesInfo.ACMoneyChangeStatus = MoneyChangeStatus.Completed.ToString();
            UpdateMainObject();
            return base.CompleteTransaction();
        }
    }
}
