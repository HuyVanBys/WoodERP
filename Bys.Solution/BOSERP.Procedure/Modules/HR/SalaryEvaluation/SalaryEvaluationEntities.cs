using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.SalaryEvaluation
{
    public class SalaryEvaluationEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the room list of the department
        /// </summary>
        public BOSList<HREmployeeSalaryEvaluationsInfo> EmployeeSalaryEvaluationList { get; set; }
        #endregion

        #region Constructor
        public SalaryEvaluationEntities()
            : base()
        {
            EmployeeSalaryEvaluationList = new BOSList<HREmployeeSalaryEvaluationsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRSalaryEvaluationsInfo();
            SearchObject = new HRSalaryEvaluationsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeeSalaryEvaluationsTableName, new HREmployeeSalaryEvaluationsInfo());
        }

        public override void InitModuleObjectList()
        {
            EmployeeSalaryEvaluationList.InitBOSList(
                                            this,
                                            TableName.HRSalaryEvaluationsTableName,
                                            TableName.HREmployeeSalaryEvaluationsTableName,
                                            BOSList<HRDepartmentsInfo>.cstRelationForeign);
            EmployeeSalaryEvaluationList.ItemTableForeignKey = "FK_HRSalaryEvaluationID";
        }

        public override void InitGridControlInBOSList()
        {
            EmployeeSalaryEvaluationList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HRSalaryEvaluationsInfo objSalaryEvaluationsInfo = (HRSalaryEvaluationsInfo)MainObject;
            objSalaryEvaluationsInfo.HRSalaryEvaluationDate = BOSApp.GetCurrentServerDate();
            objSalaryEvaluationsInfo.HRSalaryEvaluationStatus = SalaryEvaluationStatus.New.ToString();

            UpdateMainObjectBindingSource();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                EmployeeSalaryEvaluationList.SetDefaultListAndRefreshGridControl();
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
            HREmployeeSalaryEvaluationsController objEmployeeSalaryEvaluationsController = new HREmployeeSalaryEvaluationsController();
            List<HREmployeeSalaryEvaluationsInfo> list = objEmployeeSalaryEvaluationsController.GetListBySalaryEvaluationID(iObjectID);
            EmployeeSalaryEvaluationList.Invalidate(list);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            EmployeeSalaryEvaluationList.SaveItemObjects();
        }
        #endregion
    }
}
