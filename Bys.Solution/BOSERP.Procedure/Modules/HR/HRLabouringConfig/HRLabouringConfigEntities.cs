using BOSCommon;
using System;

namespace BOSERP.Modules.HRLabouringConfig
{
    public class HRLabouringConfigEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<HRLabouringConfigItemsInfo> HRLabouringConfigItemList { get; set; }
        #endregion

        #region Constructor
        public HRLabouringConfigEntities()
            : base()
        {
            HRLabouringConfigItemList = new BOSList<HRLabouringConfigItemsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRLabouringConfigsInfo();
            HRLabouringConfigItemList = new BOSList<HRLabouringConfigItemsInfo>();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add("HRLabouringConfigItems", new HRLabouringConfigItemsInfo());

        }

        public override void InitModuleObjectList()
        {
            HRLabouringConfigItemList.InitBOSList(
                                            this,
                                            "HRLabouringConfigs",
                                            "HRLabouringConfigItems",
                                            BOSList<HRLabouringConfigItemsInfo>.cstRelationForeign);
            HRLabouringConfigItemList.ItemTableForeignKey = "FK_HRLabouringConfigID";

        }

        public override void InitGridControlInBOSList()
        {
            HRLabouringConfigItemList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HRLabouringConfigsInfo objOverTimesInfo = (HRLabouringConfigsInfo)MainObject;
            objOverTimesInfo.HRLabouringConfigDate = DateTime.Now.Date;
            objOverTimesInfo.HRLabouringConfigDateType = LabouringConfigDateType.Date.ToString();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                HRLabouringConfigItemList.SetDefaultListAndRefreshGridControl();
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
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            HRLabouringConfigItemList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            HRLabouringConfigItemList.SaveItemObjects();
        }

        public override void DuplicateModuleObjectList()
        {
            HRLabouringConfigItemList.Duplicate();
            foreach (HRLabouringConfigItemsInfo item in HRLabouringConfigItemList)
            {
                //item.HRLabouringConfigItemOverTimeQty = 0;
                //item.HRLabouringConfigItemQty = 0;
                //item.HRLabouringConfigItemOverTimeRate = 0;
                //item.HRLabouringConfigItemTotalQty = 0;
            }
        }
        #endregion
    }
}
