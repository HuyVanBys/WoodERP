using BOSCommon.Constants;
using System;
using System.Data;

namespace BOSERP.Modules.Dormitory
{
    public class DormitoryEntities : BaseTransactionEntities
    {
        public BOSItemsEntityList<HRDormitoryItemsInfo> DormitoryItemList { get; set; }
        public DormitoryEntities()
            : base()
        {
            DormitoryItemList = new BOSItemsEntityList<HRDormitoryItemsInfo>();
        }

        public override void InitMainObject()
        {
            MainObject = new HRDormitorysInfo();
            SearchObject = new HRDormitorysInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRDormitoryItemsTableName, new HRDormitoryItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            DormitoryItemList = new BOSItemsEntityList<HRDormitoryItemsInfo>();
            DormitoryItemList.InitBOSList(this, TableName.HRDormitorysTableName, TableName.HRDormitoryItemsTableName);
        }

        public override void InitGridControlInBOSList()
        {
            DormitoryItemList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HRDormitorysInfo objDormitorysInfo = (HRDormitorysInfo)MainObject;
            objDormitorysInfo.HRDormitoryDate = DateTime.Now;
            objDormitorysInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objDormitorysInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            objDormitorysInfo.HRDormitoryAcreage = 50;
            objDormitorysInfo.HRDormitoryCapacity = 10;
            UpdateMainObjectBindingSource();
        }

        public override void SetDefaultModuleObjects()
        {
            base.SetDefaultModuleObjects();
            try
            {
                DormitoryItemList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            base.InvalidateModuleObjects(iObjectID);
            ICProductsController objProductsController = new ICProductsController();
            HRDormitoryItemsController objDormitoryItemsController = new HRDormitoryItemsController();
            DataSet ds = objDormitoryItemsController.GetAllDataByDormitoryID(iObjectID);
            DormitoryItemList.Invalidate(ds);
            if (DormitoryItemList != null && DormitoryItemList.Count > 0)
            {
                foreach (HRDormitoryItemsInfo item in DormitoryItemList)
                {
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectByID(item.FK_ICProductID);
                    item.HRDormitoryItemProductPicture = objProductsInfo.ICProductPicture;
                }
            }
        }

        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            DormitoryItemList.SaveItemObjects();
        }
    }
}
