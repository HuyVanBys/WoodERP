using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.CostObject
{
    public class CostObjectEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<ACCostObjectItemsInfo> CostObjectItemList { get; set; }
        #endregion

        #region Constructor
        public CostObjectEntities()
            : base()
        {
            CostObjectItemList = new BOSList<ACCostObjectItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new ACCostObjectsInfo();
            SearchObject = new ACCostObjectsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ACCostObjectItemsTableName, new ACCostObjectItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            CostObjectItemList.InitBOSList(this,
                                            TableName.ACCostObjectsTableName,
                                            TableName.ACCostObjectItemsTableName,
                                            BOSList<ACBankTransactionsInfo>.cstRelationForeign);
            CostObjectItemList.ItemTableForeignKey = "FK_ACCostObjectID";
        }

        public override void InitGridControlInBOSList()
        {
            CostObjectItemList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            ACCostObjectsInfo costObject = (ACCostObjectsInfo)MainObject;
            costObject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            costObject.FK_BRCostedBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            costObject.ACCostObjectStartDate = DateTime.Now;
            //costObject.ACCostObjectEndDate = DateTime.Now.AddDays(30);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                CostObjectItemList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #endregion

        #region Invalidate Module Objects functions
        public override void InvalidateModuleObjects(int iObjectID)
        {
            ACCostObjectItemsController objCostObjectItemsController = new ACCostObjectItemsController();
            List<ACCostObjectItemsInfo> listCostObjectItem = objCostObjectItemsController.GetListCostObjectItemsByCostObjectID(iObjectID);
            CostObjectItemList.Invalidate(listCostObjectItem);
        }

        #endregion

        #region Save Module Objects functions        
        public override void SaveModuleObjects()
        {
            CostObjectItemList.SaveItemObjects();
        }
        #endregion
    }
}
