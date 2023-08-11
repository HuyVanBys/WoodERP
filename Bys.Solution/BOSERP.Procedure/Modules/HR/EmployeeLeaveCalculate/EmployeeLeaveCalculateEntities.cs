using BOSCommon.Constants;
using System;

namespace BOSERP.Modules.EmployeeLeaveCalculate
{
    public class EmployeeLeaveCalculateEntities : ERPModuleEntities
    {
        #region Declare all entities variables
        public readonly static string strHREmployeesObjectName = "HREmployees";
        #endregion

        #region Public Properties
        /// <summary>
        /// </summary>
        public BOSList<HREmployeeLRegsInfo> EmployeeLRegList { get; set; }
        public BOSList<HREmployeesInfo> EmployeeList { get; set; }
        #endregion

        #region Constructor
        public EmployeeLeaveCalculateEntities()
            : base()
        {
            EmployeeLRegList = new BOSList<HREmployeeLRegsInfo>(this, string.Empty, TableName.HREmployeeLRegsTableName);
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeesTableName, new HREmployeesInfo());
            ModuleObjects.Add(TableName.HREmployeeLRegsTableName, new HREmployeeLRegsInfo());
        }

        public override void InitModuleObjectList()
        {
            EmployeeLRegList.InitBOSList(
                                            this,
                                            String.Empty,
                                            TableName.HREmployeeLRegsTableName,
                                            BOSList<HREmployeeLRegsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            EmployeeLRegList.InitBOSListGridControl(EmployeeLeaveCalculateModule.EmployeeLeaveCalculateGridControlName);
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {

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
            EmployeeLRegList.Invalidate(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }

        public override void SaveModuleObjects()
        {

        }
        #endregion                
    }
}
