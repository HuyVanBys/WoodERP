using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.ATMCardPayroll
{
    public class ATMCardPayrollEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the room list of the department
        /// </summary>
        public BOSList<HREmployeeATMCardPayrollsInfo> EmployeeATMCardPayrollList { get; set; }
        #endregion

        #region Constructor
        public ATMCardPayrollEntities()
            : base()
        {
            EmployeeATMCardPayrollList = new BOSList<HREmployeeATMCardPayrollsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRATMCardPayrollsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeeATMCardPayrollsTableName, new HREmployeeATMCardPayrollsInfo());
        }

        public override void InitModuleObjectList()
        {
            EmployeeATMCardPayrollList.InitBOSList(
                                            this,
                                            TableName.HRATMCardPayrollsTableName,
                                            TableName.HREmployeeATMCardPayrollsTableName,
                                            BOSList<HRATMCardPayrollsInfo>.cstRelationForeign);
            EmployeeATMCardPayrollList.ItemTableForeignKey = "FK_HRATMCardPayrollID";
        }

        public override void InitGridControlInBOSList()
        {
            EmployeeATMCardPayrollList.InitBOSListGridControl();
        }
        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();

            HRATMCardPayrollsInfo mainbObject = (HRATMCardPayrollsInfo)MainObject;
            mainbObject.HRATMCardPayrollDate = BOSApp.GetCurrentServerDate();
        }
        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                EmployeeATMCardPayrollList.SetDefaultListAndRefreshGridControl();
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
            EmployeeATMCardPayrollList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            EmployeeATMCardPayrollList.SaveItemObjects();
        }
        #endregion
    }
}
