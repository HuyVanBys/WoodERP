using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.AverageCost
{
    public class AverageCostEntities : ERPModuleEntities
    {
        public BOSList<ICAverageCostsInfo> AverageCostList { get; set; }

        #region Constructor
        public AverageCostEntities()
            : base()
        {
            AverageCostList = new BOSList<ICAverageCostsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ICAverageCostsTableName, new ICAverageCostsInfo());
        }

        public override void InitModuleObjectList()
        {
            AverageCostList.InitBOSList(this,
                                        String.Empty,
                                        TableName.ICAverageCostsTableName,
                                        BOSList<ICAverageCostsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            AverageCostList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                AverageCostList.SetDefaultListAndRefreshGridControl();
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
            ICAverageCostsController controller = new ICAverageCostsController();
            List<ICAverageCostsInfo> averageCosts = new List<ICAverageCostsInfo>(); //controller.GetAverageCostsForBeginning();
            AverageCostList.Invalidate(averageCosts);
        }
        #endregion
    }
}
