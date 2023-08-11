using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.HRAdjustSocialInsurance
{
    class HRAdjustSocialInsuranceEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<HREmployeeAdjustSocialInsurancesInfo> HREmployeeAdjustSocialInsurancesList { get; set; }
        public BOSList<HREmployeeArrearSocialInsurancesInfo> HREmployeeArrearSocialInsurancesList { get; set; }
        public BOSList<HREmployeeSocialInsuranceChangesInfo> HREmployeeSocialInsuranceChangesList { get; set; }
        public BOSList<HREmployeesInfo> EmployeeList { get; set; }
        #endregion

        #region Constructor
        public HRAdjustSocialInsuranceEntities()
            : base()
        {
            EmployeeList = new BOSList<HREmployeesInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRAdjustSocialInsurancesInfo();
            HREmployeeAdjustSocialInsurancesList = new BOSList<HREmployeeAdjustSocialInsurancesInfo>();
            HREmployeeArrearSocialInsurancesList = new BOSList<HREmployeeArrearSocialInsurancesInfo>();
            HREmployeeSocialInsuranceChangesList = new BOSList<HREmployeeSocialInsuranceChangesInfo>();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeeAdjustSocialInsurancesTableName, new HREmployeeAdjustSocialInsurancesInfo());
        }

        public override void InitModuleObjectList()
        {
            HREmployeeAdjustSocialInsurancesList.InitBOSList(
                                            this,
                                            TableName.HRAdjustSocialInsurancesTableName,
                                            TableName.HREmployeeAdjustSocialInsurancesTableName,
                                            BOSList<HREmployeeAdjustSocialInsurancesInfo>.cstRelationForeign);
            HREmployeeAdjustSocialInsurancesList.ItemTableForeignKey = "FK_HRAdjustSocialInsuranceID";

            HREmployeeArrearSocialInsurancesList.InitBOSList(
                                            this,
                                            TableName.HRAdjustSocialInsurancesTableName,
                                            TableName.HREmployeeArrearSocialInsurancesTableName,
                                            BOSList<HREmployeeArrearSocialInsurancesInfo>.cstRelationForeign);
            HREmployeeArrearSocialInsurancesList.ItemTableForeignKey = "FK_HRAdjustSocialInsuranceID";

            HREmployeeSocialInsuranceChangesList.InitBOSList(
                                            this,
                                            TableName.HRAdjustSocialInsurancesTableName,
                                            TableName.HREmployeeSocialInsuranceChangesTableName,
                                            BOSList<HREmployeeSocialInsuranceChangesInfo>.cstRelationForeign);
            HREmployeeSocialInsuranceChangesList.ItemTableForeignKey = "FK_HRAdjustSocialInsuranceID";

            EmployeeList.InitBOSList(
                                        this,
                                        String.Empty,
                                        TableName.HREmployeesTableName,
                                        BOSList<HREmployeesInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            HREmployeeAdjustSocialInsurancesList.InitBOSListGridControl();
            HREmployeeArrearSocialInsurancesList.InitBOSListGridControl();
            HREmployeeSocialInsuranceChangesList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HRAdjustSocialInsurancesInfo objAdjustSocialInsurancesInfo = (HRAdjustSocialInsurancesInfo)MainObject;
            objAdjustSocialInsurancesInfo.HRAdjustSocialInsuranceDate = DateTime.Now;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                HREmployeeAdjustSocialInsurancesList.SetDefaultListAndRefreshGridControl();
                HREmployeeArrearSocialInsurancesList.SetDefaultListAndRefreshGridControl();
                HREmployeeSocialInsuranceChangesList.SetDefaultListAndRefreshGridControl();
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
            HREmployeeAdjustSocialInsurancesList.Invalidate(iObjectID);
            HREmployeeArrearSocialInsurancesList.Invalidate(iObjectID);
            HREmployeeSocialInsuranceChangesList.Invalidate(iObjectID);

        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            HREmployeeAdjustSocialInsurancesList.SaveItemObjects();
            HREmployeeArrearSocialInsurancesList.SaveItemObjects();
            HREmployeeSocialInsuranceChangesList.SaveItemObjects();
        }
        #endregion
    }
}
