using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.DormitoryCost
{
    public class DormitoryCostEntities : ERPModuleEntities
    {
        public BOSList<HRDormitoryCostItemsInfo> DormitoryCostItemList { get; set; }
        public DormitoryCostEntities()
            : base()
        {
            DormitoryCostItemList = new BOSList<HRDormitoryCostItemsInfo>();
        }

        public override void InitMainObject()
        {
            MainObject = new HRDormitoryCostsInfo();
            SearchObject = new HRDormitoryCostsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRDormitoryCostItemsTableName, new HRDormitoryCostItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            DormitoryCostItemList.InitBOSList(this, TableName.HRDormitoryCostsTableName,
                                                        TableName.HRDormitoryCostItemsTableName,
                                                        BOSList<HRDormitoryCostItemsInfo>.cstRelationForeign);
            DormitoryCostItemList.ItemTableForeignKey = "FK_HRDormitoryCostID";
        }

        public override void InitGridControlInBOSList()
        {
            DormitoryCostItemList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            HRDormitoryCostsInfo objHRDormitoryCostsInfo = (HRDormitoryCostsInfo)MainObject;
            objHRDormitoryCostsInfo.HRDormitoryCostFromDate = BOSUtil.GetMonthBeginDate();
            objHRDormitoryCostsInfo.HRDormitoryCostToDate = BOSUtil.GetYearEndDate();
            objHRDormitoryCostsInfo.HRDormitoryCostDate = DateTime.Now;
            UpdateMainObjectBindingSource();
        }

        public override void SetDefaultModuleObjects()
        {
            base.SetDefaultModuleObjects();
            try
            {
                DormitoryCostItemList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            DormitoryCostItemList.Invalidate(iObjectID);

            HRDormitorysController objDormitorysController = new HRDormitorysController();
            List<HRDormitorysInfo> dormitorylist = objDormitorysController.GetAllDormitoryList();
            DormitoryCostItemList.ForEach(o =>
            {
                HRDormitorysInfo objDormitorysInfo = dormitorylist.FirstOrDefault(p => p.HRDormitoryID == o.FK_HRDormitoryID);
                if (objDormitorysInfo != null)
                    o.HRDormitoryNo = objDormitorysInfo.HRDormitoryNo;
            });
        }
        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            DormitoryCostItemList.SaveItemObjects();
        }
    }
}
