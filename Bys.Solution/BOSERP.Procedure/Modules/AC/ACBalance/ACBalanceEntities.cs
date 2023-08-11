using System;
using System.Collections.Generic;

namespace BOSERP.Modules.ACBalance
{
    public class ACBalanceEntities : ERPModuleEntities
    {
        public BOSList<ACBalancesInfo> ACBalanceList { get; set; }

        #region Constructor
        public ACBalanceEntities()
            : base()
        {
            ACBalanceList = new BOSList<ACBalancesInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitModuleObjects()
        {
            ModuleObjects.Add("ACBalances", new ACBalancesInfo());
        }

        public override void InitModuleObjectList()
        {
            ACBalanceList.InitBOSList(this,
                                           String.Empty,
                                           "ACBalances",
                                           BOSList<ACBalancesInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            ACBalanceList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                ACBalanceList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InitModuleEntity()
        {
            base.InitModuleEntity();

            InitDataToModuleObjectList();
        }

        public void InitDataToModuleObjectList()
        {
            ACBalancesController controller = new ACBalancesController();
            List<ACBalancesInfo> balances = controller.GetACBalancesForBeginning();
            ACBalanceList.Invalidate(balances);
        }
        #endregion
    }
}
