using System;

namespace BOSERP.Modules.InventoryLeadger
{
    public class InventoryLeadgerEntities : ERPModuleEntities
    {
        public BOSList<ICTransactionsInfo> ICTransactionsList { get; set; }

        #region Constructor
        public InventoryLeadgerEntities()
            : base()
        {
            ICTransactionsList = new BOSList<ICTransactionsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitModuleObjects()
        {
            ModuleObjects.Add("ICTransactions", new ICTransactionsInfo());
        }

        public override void InitModuleObjectList()
        {
            ICTransactionsList.InitBOSList(this, String.Empty, "ICTransactions", BOSList<ICTransactionsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            ICTransactionsList.InitBOSListGridControl(InventoryLeadgerModule.InventoryLeadgerGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ICTransactionsList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion
    }
}
