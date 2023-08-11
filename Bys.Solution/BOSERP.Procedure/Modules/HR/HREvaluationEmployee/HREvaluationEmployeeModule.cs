using BOSCommon;
using BOSComponent;
using BOSReport;
using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.HREvaluationEmployee
{
    public class HREvaluationEmployeeModule : BaseModuleERP
    {
        #region Declare Constant
        public const string HREmployeeEvaluatedGridControlName = "fld_dgcHREmployeeEvaluations1";
        public const string HREvaluationDetailsGridControlName = "fld_dgcHREvaluationDetails";
        public const string HREmployeeEvaluatedLookupEditName = "fld_lkeFK_HREmployeeID2";
        #endregion

        #region Declare Variables
        private HREmployeeEvaluatedGridControl EmployeeEvaluatedGridControl;
        #endregion

        public HREvaluationEmployeeModule()
        {
            Name = "HREvaluationEmployee";
            CurrentModuleEntity = new HREvaluationEmployeeEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            EmployeeEvaluatedGridControl = (HREmployeeEvaluatedGridControl)Controls[HREvaluationEmployeeModule.HREmployeeEvaluatedGridControlName];
        }

        #region Local
        /// <summary>
        /// Add employee to the employee evaluating list
        /// </summary>
        public void AddEmployeeToEmployeeEvaluatingList(int employeeID)
        {
            HREvaluationEmployeeEntities entity = (HREvaluationEmployeeEntities)CurrentModuleEntity;
            HREmployeeEvaluationsInfo objEmployeeEvaluationsInfo = entity.HREmployeeEvaluatingList[entity.HREmployeeEvaluatingList.CurrentIndex];
            if (employeeID > 0)
            {
                HREmployeesController objEmployeesController = new HREmployeesController();
                HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
                objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(employeeID);
                objEmployeeEvaluationsInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                objEmployeeEvaluationsInfo.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
                objEmployeeEvaluationsInfo.HREmployeeEvaluationType = EmployeeEvaluationType.Evaluating.ToString();
                entity.HREmployeeEvaluatingList[entity.HREmployeeEvaluatingList.CurrentIndex] = objEmployeeEvaluationsInfo;
            }
        }

        /// <summary>
        /// Check current employee is existed or not in employee evaluating list
        /// </summary>
        /// <param name="employeeID">ID of employee</param>
        /// <returns>Existing of employee in employee evaluating list</returns>
        public bool CheckEvaluatingEmployeeExist(int employeeID)
        {
            HREvaluationEmployeeEntities entity = (HREvaluationEmployeeEntities)CurrentModuleEntity;
            if (entity.HREmployeeEvaluatingList.Where(e => e.FK_HREmployeeID == employeeID).FirstOrDefault() != null)
                return true;
            return false;
        }

        /// <summary>
        /// Add employee to the employee evaluated list
        /// </summary>
        public void AddEmployeeToEmployeeEvaluatedList(int employeeID)
        {
            HREvaluationEmployeeEntities entity = (HREvaluationEmployeeEntities)CurrentModuleEntity;
            HREmployeeEvaluationsInfo objEmployeeEvaluationsInfo = entity.HREmployeeEvaluatedList[entity.HREmployeeEvaluatedList.CurrentIndex];
            if (employeeID > 0)
            {
                HREmployeesController objEmployeesController = new HREmployeesController();
                HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
                objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(employeeID);
                objEmployeeEvaluationsInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                objEmployeeEvaluationsInfo.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
                objEmployeeEvaluationsInfo.HREmployeeEvaluationType = EmployeeEvaluationType.Evaluated.ToString();
                objEmployeeEvaluationsInfo.FK_HREvaluationRankID = 0;
                objEmployeeEvaluationsInfo.FK_HRTemplateRankID = 0;
                objEmployeeEvaluationsInfo.HREmployeeEvaluationResult = 0;
                entity.HREmployeeEvaluatedList[entity.HREmployeeEvaluatedList.CurrentIndex] = objEmployeeEvaluationsInfo;
            }
        }

        /// <summary>
        /// Check current evaluated employee is existed or not in evaluated employee list
        /// </summary>
        /// <param name="employeeID">ID of employee</param>
        /// <returns>Existing of evaluated employee</returns>
        public bool CheckEvaluatedEmployeeExist(int employeeID)
        {
            HREvaluationEmployeeEntities entity = (HREvaluationEmployeeEntities)CurrentModuleEntity;
            if (entity.HREmployeeEvaluatedList.Where(e => e.FK_HREmployeeID == employeeID).FirstOrDefault() != null)
                return true;
            return false;
        }

        /// <summary>
        /// Invalidate employee evaluated list and its grid control when the result changes
        /// </summary>
        /// <param name="objEmployeeEvaluationsInfo">Infomation of employee evaluation</param>
        public void InvalidateEmployeeEvaluatedList(HREmployeeEvaluationsInfo objEmployeeEvaluationsInfo)
        {
            HREvaluationEmployeeEntities entity = (HREvaluationEmployeeEntities)CurrentModuleEntity;
            HREvaluationsInfo objEvaluationsInfo = (HREvaluationsInfo)entity.MainObject;
            HRTemplateRanksInfo objTemplateRanksInfo = new HRTemplateRanksInfo();
            HRTemplateRanksController objTemplateRanksController = new HRTemplateRanksController();
            objTemplateRanksInfo = objTemplateRanksController.GetDataByEvaluationTemplateIDAndFromValueToValue(objEvaluationsInfo.FK_HREvaluationTemplateID, objEmployeeEvaluationsInfo.HREmployeeEvaluationResult);
            if (objTemplateRanksInfo != null)
            {
                objEmployeeEvaluationsInfo.FK_HRTemplateRankID = objTemplateRanksInfo.HRTemplateRankID;
                objEmployeeEvaluationsInfo.FK_HREvaluationRankID = objTemplateRanksInfo.FK_HREvaluationRankID;
            }
            else
                objEmployeeEvaluationsInfo.FK_HREvaluationRankID = 0;
            entity.UpdateModuleObjectsBindingSource();
        }
        #endregion

        #region override action new, action save, action print
        public override void ActionNew()
        {
            base.ActionNew();
            HREvaluationEmployeeEntities entity = (HREvaluationEmployeeEntities)CurrentModuleEntity;
            EmployeeEvaluatedGridControl.IsAllowEidt = false;
            EmployeeEvaluatedGridControl.InitializeControl();
        }

        public override int ActionSave()
        {
            HREvaluationEmployeeEntities entity = (HREvaluationEmployeeEntities)CurrentModuleEntity;
            entity.SaveEvaluationDetails();
            HREvaluationsInfo objEvaluationsInfo = (HREvaluationsInfo)entity.MainObject;
            BOSLookupEdit employeeEvaluatedLookupEdit = (BOSLookupEdit)Controls[HREvaluationEmployeeModule.HREmployeeEvaluatedLookupEditName];

            HREmployeeEvaluationsController objEmployeeEvaluationsController = new HREmployeeEvaluationsController();
            HREmployeeEvaluationsInfo objEmployeeEvaluationsInfo = new HREmployeeEvaluationsInfo();
            objEmployeeEvaluationsInfo = (HREmployeeEvaluationsInfo)objEmployeeEvaluationsController
                        .GetEmployeeEvaluationByEvaluationIDAndEmployeeID(objEvaluationsInfo.HREvaluationID,
                                                                    Convert.ToInt32(employeeEvaluatedLookupEdit.EditValue));
            // Update employee evaluation result
            if (objEmployeeEvaluationsInfo != null)
            {
                HREvaluationDetailsController objEvaluationDetailsController = new HREvaluationDetailsController();
                objEmployeeEvaluationsInfo.HREmployeeEvaluationResult = objEvaluationDetailsController
                            .GetSumEvaluationDetailResultByEvaluationIDAndEmployeeID(objEvaluationsInfo.HREvaluationID,
                                                                        Convert.ToInt32(employeeEvaluatedLookupEdit.EditValue));

                InvalidateEmployeeEvaluatedList(objEmployeeEvaluationsInfo);

                entity.UpdateEmployeeEvaluatedResult(objEmployeeEvaluationsInfo);

                entity.InvalidateEmployeeEvaluated(objEvaluationsInfo.HREvaluationID);
            }
            return base.ActionSave();
        }

        public override void ActionPrint()
        {
            HREvaluationEmployeeEntities entity = (HREvaluationEmployeeEntities)CurrentModuleEntity;
            HREvaluationsInfo objEvaluationsInfo = (HREvaluationsInfo)entity.MainObject;
            ADReportsController objReportsController = new ADReportsController();
            RPEvaluationEmployee report = new RPEvaluationEmployee();
            //report.LoadLayout(BOSCommon.Constants.Report.DevEvaluationEmployeeReportPath);

            //Set current branch
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;

            report.DataSource = objReportsController.GetEmployeeEvaluationByEvaluationIDAndType(objEvaluationsInfo.HREvaluationID, EmployeeEvaluationType.Evaluated.ToString());
            report.DataMember = BOSCommon.Constants.Report.DevEvaluationTemplateReportName;
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevEvaluationEmployeeReportPath, true);
            reviewer.Show();
        }
        #endregion

        /// <summary>
        /// Invalidate evaluation details of employee when evaluated employee lookup edit validated
        /// </summary>
        public void InvalidateEvaluationDetails()
        {
            HREvaluationEmployeeEntities entity = (HREvaluationEmployeeEntities)CurrentModuleEntity;
            HREvaluationsInfo objEvaluationsInfo = (HREvaluationsInfo)entity.MainObject;
            entity.InvalidateEvaluationDetails(objEvaluationsInfo.HREvaluationID);
        }
    }
}
