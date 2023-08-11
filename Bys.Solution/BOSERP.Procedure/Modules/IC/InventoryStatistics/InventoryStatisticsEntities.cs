using System;

namespace BOSERP.Modules.InventoryStatistics
{
    public class InventoryStatisticsEntities : ERPModuleEntities
    {
        public BOSList<ICTransactionsInfo> ICTransactionStatisticsList { get; set; }

        #region Constructor
        public InventoryStatisticsEntities()
            : base()
        {
            ICTransactionStatisticsList = new BOSList<ICTransactionsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitModuleObjects()
        {
            ModuleObjects.Add("ICTransactions", new ICTransactionsInfo());
        }

        public override void InitModuleObjectList()
        {
            ICTransactionStatisticsList.InitBOSList(this, String.Empty, "ICTransactions", BOSList<ICTransactionsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            ICTransactionStatisticsList.InitBOSListGridControl(InventoryStatisticsModule.InventoryStatisticsGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ICTransactionStatisticsList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion
    }
}
