using BOSCommon.Constants;
using BOSLib;
using System;
using System.Data;

namespace BOSERP.Modules.RegisterDormitory
{
    public class RegisterDormitoryEntities : BaseTransactionEntities
    {
        public BOSList<HRRegisterDormitoryItemsInfo> RegisterDormitoryItemList { get; set; }
        public RegisterDormitoryEntities()
            : base()
        {
            RegisterDormitoryItemList = new BOSList<HRRegisterDormitoryItemsInfo>();
        }

        public override void InitMainObject()
        {
            MainObject = new HRRegisterDormitorysInfo();
            SearchObject = new HRRegisterDormitorysInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HRRegisterDormitoryItemsTableName, new HRRegisterDormitoryItemsInfo());
        }

        public override void InitModuleObjectList()
        {
            RegisterDormitoryItemList.InitBOSList(this, TableName.HRRegisterDormitorysTableName,
                                                        TableName.HRRegisterDormitoryItemsTableName,
                                                        BOSList<HRRegisterDormitoryItemsInfo>.cstRelationForeign);
            RegisterDormitoryItemList.ItemTableForeignKey = "FK_HRRegisterDormitoryID";
        }

        public override void InitGridControlInBOSList()
        {
            RegisterDormitoryItemList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            HRRegisterDormitorysInfo objRegisterDormitorysInfo = (HRRegisterDormitorysInfo)MainObject;
            objRegisterDormitorysInfo.HRRegisterDormitoryFromDate = BOSUtil.GetMonthBeginDate();
            objRegisterDormitorysInfo.HRRegisterDormitoryToDate = BOSUtil.GetYearEndDate();
            objRegisterDormitorysInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objRegisterDormitorysInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            UpdateMainObjectBindingSource();
        }

        public override void SetDefaultModuleObjects()
        {
            base.SetDefaultModuleObjects();
            try
            {
                RegisterDormitoryItemList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
            HREmployeesController objEmployeesController = new HREmployeesController();
            HRRegisterDormitoryItemsController objRegisterDormitoryItemsController = new HRRegisterDormitoryItemsController();
            DataSet ds = objRegisterDormitoryItemsController.GetAllDataByRegisterDormitoryID(iObjectID);
            RegisterDormitoryItemList.Invalidate(ds);

        }

        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            RegisterDormitoryItemList.SaveItemObjects();
        }
    }
}
