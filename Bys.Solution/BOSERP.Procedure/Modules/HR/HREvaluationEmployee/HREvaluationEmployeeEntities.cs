using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using System;
using System.Data;

namespace BOSERP.Modules.HREvaluationEmployee
{
    public class HREvaluationEmployeeEntities : ERPModuleEntities
    {
        #region Declare Constant

        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the employee evaluation list with type is evaluating
        /// </summary>
        public BOSList<HREmployeeEvaluationsInfo> HREmployeeEvaluatingList { get; set; }
        /// <summary>
        /// Gets or sets the employee evaluation list with type is evaluated
        /// </summary>
        public BOSList<HREmployeeEvaluationsInfo> HREmployeeEvaluatedList { get; set; }
        /// <summary>
        /// Gets or sets the evaluation details list of an employee
        /// </summary>
        public BOSList<HREvaluationDetailsInfo> HREvaluationDetailsList { get; set; }
        #endregion

        #region Constructor
        public HREvaluationEmployeeEntities()
            : base()
        {
            HREmployeeEvaluatingList = new BOSList<HREmployeeEvaluationsInfo>();
            HREmployeeEvaluatedList = new BOSList<HREmployeeEvaluationsInfo>();
            HREvaluationDetailsList = new BOSList<HREvaluationDetailsInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HREvaluationsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeeEvaluationsTableName, new HREmployeeEvaluationsInfo());
            ModuleObjects.Add(TableName.HREvaluationDetailsTableName, new HREvaluationDetailsInfo());
        }

        public override void InitModuleObjectList()
        {
            HREmployeeEvaluatingList.InitBOSList(this,
                                                 TableName.HREvaluationsTableName,
                                                 TableName.HREmployeeEvaluationsTableName,
                                                 BOSList<HREmployeeEvaluationsInfo>.cstRelationForeign);
            HREmployeeEvaluatingList.ItemTableForeignKey = "FK_HREvaluationID";

            HREmployeeEvaluatedList.InitBOSList(this,
                                                  TableName.HREvaluationsTableName,
                                                  TableName.HREmployeeEvaluationsTableName,
                                                  BOSList<HREmployeeEvaluationsInfo>.cstRelationForeign);
            HREmployeeEvaluatedList.ItemTableForeignKey = "FK_HREvaluationID";

            HREvaluationDetailsList.InitBOSList(this,
                                                    TableName.HREvaluationsTableName,
                                                    TableName.HREvaluationDetailsTableName,
                                                    BOSList<HREvaluationDetailsInfo>.cstRelationForeign);
            HREvaluationDetailsList.ItemTableForeignKey = "FK_HREvaluationID";
        }

        public override void InitGridControlInBOSList()
        {
            HREmployeeEvaluatingList.InitBOSListGridControl();
            HREmployeeEvaluatedList.InitBOSListGridControl();
            HREmployeeEvaluatedList.GridControl = (HREmployeeEvaluatedGridControl)Module.Controls[HREvaluationEmployeeModule.HREmployeeEvaluatedGridControlName];
            HREvaluationDetailsList.InitBOSListGridControl(HREvaluationEmployeeModule.HREvaluationDetailsGridControlName);
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HREvaluationsInfo objEvaluationsInfo = (HREvaluationsInfo)MainObject;
            objEvaluationsInfo.HREvaluationFromDate = BOSUtil.GetMonthBeginDate();
            objEvaluationsInfo.HREvaluationToDate = BOSUtil.GetMonthEndDate();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                HREmployeeEvaluatingList.SetDefaultListAndRefreshGridControl();
                HREmployeeEvaluatedList.SetDefaultListAndRefreshGridControl();
                HREvaluationDetailsList.SetDefaultListAndRefreshGridControl();
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
            HREvaluationsInfo objEvaluationsInfo = (HREvaluationsInfo)MainObject;
            HREmployeeEvaluatedGridControl evaluatedGridControl = (HREmployeeEvaluatedGridControl)Module.Controls[HREvaluationEmployeeModule.HREmployeeEvaluatedGridControlName];
            if (objEvaluationsInfo.HREvaluationStatus.Equals(EvaluationStatus.InProgress.ToString()))
                evaluatedGridControl.IsAllowEidt = true;
            else
                evaluatedGridControl.IsAllowEidt = false;
            evaluatedGridControl.InitializeControl();
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            HREmployeeEvaluationsController objEmployeeEvaluationsController = new HREmployeeEvaluationsController();
            DataSet dsEvaluating = objEmployeeEvaluationsController.GetEmployeeEvaluationByEvaluationIDAndType(iObjectID, EmployeeEvaluationType.Evaluating.ToString());
            HREmployeeEvaluatingList.Invalidate(dsEvaluating);
            // Invalidate employee evaluated list
            InvalidateEmployeeEvaluated(iObjectID);
            // Invalidate evaluation details list
            BOSLookupEdit employeeEvaluatedLookupEdit = (BOSLookupEdit)Module.Controls[HREvaluationEmployeeModule.HREmployeeEvaluatedLookupEditName];
            employeeEvaluatedLookupEdit.EditValue = 0;
            InvalidateEvaluationDetails(iObjectID);
        }
        /// <summary>
        /// Invalidate evaluation details of an employee by evaluationID.
        /// </summary>
        /// <param name="evaluationID">ID of evaluation</param>
        public void InvalidateEvaluationDetails(int evaluationID)
        {
            HREvaluationDetailsController objEvaluationDetailsController = new HREvaluationDetailsController();
            // Invalidate Employee evaluated lookup edit datasource
            HREmployeeEvaluationsController objEmployeeEvaluationsController = new HREmployeeEvaluationsController();
            DataSet dsEvaluated = objEmployeeEvaluationsController.GetEmployeeEvaluationByEvaluationIDAndEvaluationType(evaluationID, EmployeeEvaluationType.Evaluated.ToString());
            BOSLookupEdit employeeEvaluatedLookupEdit = (BOSLookupEdit)Module.Controls[HREvaluationEmployeeModule.HREmployeeEvaluatedLookupEditName];
            employeeEvaluatedLookupEdit.Properties.DataSource = dsEvaluated.Tables[0];
            int employeeID = 0;
            if (employeeEvaluatedLookupEdit.EditValue != DBNull.Value && employeeEvaluatedLookupEdit.EditValue != null)
            {
                employeeID = Convert.ToInt32(employeeEvaluatedLookupEdit.EditValue);
            }
            DataSet dsEvaluationDetails = objEvaluationDetailsController
                    .GetEmployeeEvaluationDetailsByEvaluationIDAndEmployeeID(evaluationID, employeeID);
            HREvaluationDetailsList.Invalidate(dsEvaluationDetails);
        }

        /// <summary>
        /// Invalidate employee evaluated gridcontrol to update employee evaluated result
        /// </summary>
        /// <param name="evaluationID">ID of evaluation</param>
        public void InvalidateEmployeeEvaluated(int evaluationID)
        {
            HREmployeeEvaluationsController objEmployeeEvaluationsController = new HREmployeeEvaluationsController();
            DataSet dsEvaluated = objEmployeeEvaluationsController.GetEmployeeEvaluationByEvaluationIDAndType(evaluationID, EmployeeEvaluationType.Evaluated.ToString());
            HREmployeeEvaluatedList.Invalidate(dsEvaluated);
            HREmployeeEvaluatedList.GridControl.RefreshDataSource();
        }
        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {
            HREmployeeEvaluatingList.SaveItemObjects();
            HREmployeeEvaluatedList.SaveItemObjects();
        }

        /// <summary>
        /// Save evaluation details
        /// </summary>
        public void SaveEvaluationDetails()
        {
            HREvaluationsInfo objEvaluationsInfo = (HREvaluationsInfo)MainObject;
            BOSLookupEdit employeeEvaluatedLookupEdit = (BOSLookupEdit)Module.Controls[HREvaluationEmployeeModule.HREmployeeEvaluatedLookupEditName];
            int employeeID = Convert.ToInt32(employeeEvaluatedLookupEdit.EditValue);
            if (employeeID > 0)
            {
                foreach (HREvaluationDetailsInfo objEvaluationDetailsInfo in HREvaluationDetailsList)
                {
                    objEvaluationDetailsInfo.FK_HREvaluationID = objEvaluationsInfo.HREvaluationID;
                    objEvaluationDetailsInfo.FK_HREmployeeID = employeeID;
                }
                HREvaluationDetailsList.EndCurrentEdit();
                HREvaluationDetailsList.SaveItemObjects();
            }
        }
        #endregion
        /// <summary>
        /// Update employee evaluation to validate employee evaluated result
        /// </summary>
        /// <param name="objEmployeeEvaluationsInfo">Employee evaluation object</param>
        public void UpdateEmployeeEvaluatedResult(HREmployeeEvaluationsInfo objEmployeeEvaluationsInfo)
        {
            HREmployeeEvaluationsController objEmployeeEvaluationsController = new HREmployeeEvaluationsController();
            objEmployeeEvaluationsController.UpdateObject(objEmployeeEvaluationsInfo);
        }
    }
}
