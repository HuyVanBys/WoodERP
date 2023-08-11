using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.InvBalance
{
    public class InvBalanceEntities : ERPModuleEntities
    {
        public BOSList<ICInvBalancesInfo> InvBalanceList { get; set; }

        #region Constructor
        public InvBalanceEntities()
            : base()
        {
            InvBalanceList = new BOSList<ICInvBalancesInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICInvBalancesTableName, new ICInvBalancesInfo());
        }

        public override void InitModuleObjectList()
        {
            InvBalanceList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ICInvBalancesTableName,
                                           BOSList<ICInvBalancesInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            InvBalanceList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                InvBalanceList.SetDefaultListAndRefreshGridControl();
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
            ICInvBalancesController controller = new ICInvBalancesController();
            List<ICInvBalancesInfo> balances = controller.GetInvBalancesForBeginning();
            InvBalanceList.Invalidate(balances);
        }
        #endregion
    }
}
