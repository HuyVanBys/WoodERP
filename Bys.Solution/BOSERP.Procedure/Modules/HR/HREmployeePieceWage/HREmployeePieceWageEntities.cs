using BOSCommon.Constants;
using System;
using System.Data;

namespace BOSERP.Modules.HREmployeePieceWage
{
    public class HREmployeePieceWageEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<HREmployeePieceWageItemsInfo> HREmployeePieceWageItemList { get; set; }
        public BOSList<HREmployeesInfo> HREmployeeList { get; set; }
        #endregion

        #region Constructor
        public HREmployeePieceWageEntities()
            : base()
        {
            HREmployeeList = new BOSList<HREmployeesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HREmployeePieceWagesInfo();
            HREmployeePieceWageItemList = new BOSList<HREmployeePieceWageItemsInfo>();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeePieceWageItemsTableName, new HREmployeePieceWageItemsInfo());
            ModuleObjects.Add(TableName.HREmployeesTableName, new HREmployeesInfo());
        }

        public override void InitModuleObjectList()
        {
            HREmployeePieceWageItemList.InitBOSList(
                                            this,
                                            TableName.HREmployeePieceWagesTableName,
                                            TableName.HREmployeePieceWageItemsTableName,
                                            BOSList<HREmployeePieceWageItemsInfo>.cstRelationForeign);
            HREmployeePieceWageItemList.ItemTableForeignKey = "FK_HREmployeePieceWageID";

            HREmployeeList.InitBOSList(
                                       this,
                                       String.Empty,
                                       TableName.HREmployeesTableName,
                                       BOSList<HREmployeesInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            HREmployeePieceWageItemList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HREmployeePieceWagesInfo objEmployeePieceWagesInfo = (HREmployeePieceWagesInfo)MainObject;
            objEmployeePieceWagesInfo.HREmployeePieceWageDate = BOSApp.GetCurrentServerDate();
            objEmployeePieceWagesInfo.HREmployeePieceWageFromDate = BOSApp.GetCurrentServerDate();
            objEmployeePieceWagesInfo.HREmployeePieceWageToDate = BOSApp.GetCurrentServerDate();
            objEmployeePieceWagesInfo.HREmployeePieceWageDateEnd = BOSApp.GetCurrentServerDate();
            objEmployeePieceWagesInfo.HREmployeePieceWageStatus = "New";
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                HREmployeePieceWageItemList.SetDefaultListAndRefreshGridControl();
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
            HREmployeePieceWageItemsController objEmployeeOTsController = new HREmployeePieceWageItemsController();
            DataSet ds = objEmployeeOTsController.GetAllDataByEmployeePieceWageID(iObjectID);
            HREmployeePieceWageItemList.Invalidate(ds);
            HREmployeesController objEmployeesController = new HREmployeesController();
            foreach (var item in HREmployeePieceWageItemList)
            {
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(item.FK_HREmployeeID);
                if (objEmployeesInfo != null)
                    item.HREmployeePieceWageItemCardNumber = objEmployeesInfo.HREmployeeCardNumber;
            }
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            HREmployeePieceWagesInfo objEmployeePieceWagesInfo = (HREmployeePieceWagesInfo)MainObject;
            objEmployeePieceWagesInfo.HREmployeePieceWageDate = objEmployeePieceWagesInfo.HREmployeePieceWageDate.Date;
            try
            {

                //int time1 = objEmployeePieceWagesInfo.HREmployeePieceWageFromDate.Hour * 60 + objEmployeePieceWagesInfo.HREmployeePieceWageFromDate.Minute;
                //int time2 = objEmployeePieceWagesInfo.HREmployeePieceWageToDate.Hour * 60 + objEmployeePieceWagesInfo.HREmployeePieceWageToDate.Minute;
                //objEmployeePieceWagesInfo.HREmployeePieceWageFromDate = objEmployeePieceWagesInfo.HREmployeePieceWageDate.AddMinutes(time1);
                //objEmployeePieceWagesInfo.HREmployeePieceWageToDate = objEmployeePieceWagesInfo.HREmployeePieceWageDate.AddMinutes(time2);
            }
            catch (Exception) { }
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            HREmployeePieceWageItemList.SaveItemObjects();
        }
        #endregion
    }
}
