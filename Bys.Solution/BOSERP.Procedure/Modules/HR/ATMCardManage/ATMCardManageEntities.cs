using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.ATMCardManage
{
    public class ATMCardManageEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the room list of the department
        /// </summary>
        public BOSList<HREmployeeATMCardManagesInfo> EmployeeATMCardManageList { get; set; }
        #endregion

        #region Constructor
        public ATMCardManageEntities()
            : base()
        {
            EmployeeATMCardManageList = new BOSList<HREmployeeATMCardManagesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRATMCardManagesInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeeATMCardManagesTableName, new HREmployeeATMCardManagesInfo());
        }

        public override void InitModuleObjectList()
        {
            EmployeeATMCardManageList.InitBOSList(
                                            this,
                                            TableName.HRATMCardManagesTableName,
                                            TableName.HREmployeeATMCardManagesTableName,
                                            BOSList<HRDepartmentsInfo>.cstRelationForeign);
            EmployeeATMCardManageList.ItemTableForeignKey = "FK_HRATMCardManageID";
        }

        public override void InitGridControlInBOSList()
        {
            EmployeeATMCardManageList.InitBOSListGridControl();
        }
        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            HRATMCardManagesInfo mainObject = (HRATMCardManagesInfo)MainObject;
            mainObject.HRATMCardManageDate = BOSApp.GetCurrentServerDate().AddDays(-1);
        }
        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                EmployeeATMCardManageList.SetDefaultListAndRefreshGridControl();
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
            EmployeeATMCardManageList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            EmployeeATMCardManageList.SaveItemObjects();
        }

        public void SetDefaultValuesFromEmployee(HREmployeeATMCardManagesInfo objEmployeeATMCardManagesInfo, HREmployeesInfo objEmployeesInfo)
        {
            objEmployeeATMCardManagesInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
            objEmployeeATMCardManagesInfo.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
            objEmployeeATMCardManagesInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
            objEmployeeATMCardManagesInfo.HREmployeeATMCardManageBankAccount = objEmployeesInfo.HREmployeeBankAccount1;
            objEmployeeATMCardManagesInfo.HREmployeeATMCardManagePhone = objEmployeesInfo.HREmployeeTel1;

            UpdateModuleObjectBindingSource(TableName.HREmployeeATMCardManagesTableName);
        }
        #endregion
    }
}
