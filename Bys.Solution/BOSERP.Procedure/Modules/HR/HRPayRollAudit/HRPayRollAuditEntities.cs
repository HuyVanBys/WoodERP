using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.HRPayRollAudit
{
    public class HRPayRollAuditEntities : BaseTransactionEntities
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the employee payroll list
        /// </summary>
        public BOSList<HREmployeePayRollAuditsInfo> EmployeePayRollAuditList { get; set; }
        /// <summary>
        /// Gets or sets the employee list
        /// </summary>
        public BOSList<HREmployeesInfo> EmployeeList { get; set; }
        #endregion

        #region Constructor
        public HRPayRollAuditEntities()
            : base()
        {
            EmployeePayRollAuditList = new BOSList<HREmployeePayRollAuditsInfo>();
            EmployeeList = new BOSList<HREmployeesInfo>();
        }

        #endregion

        public override void InitMainObject()
        {
            MainObject = new HRPayRollAuditsInfo();

        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeePayRollAuditsTableName, new HREmployeePayRollAuditsInfo());
            ModuleObjects.Add(TableName.HREmployeesTableName, new HREmployeesInfo());
        }

        public override void InitModuleObjectList()
        {
            EmployeePayRollAuditList.InitBOSList(
                                            this,
                                            TableName.HRPayRollAuditsTableName,
                                            TableName.HREmployeePayRollAuditsTableName,
                                            BOSList<HREmployeePayRollAuditsInfo>.cstRelationForeign);
            EmployeePayRollAuditList.ItemTableForeignKey = "FK_HRPayRollAuditID";

            EmployeeList.InitBOSList(
                                        this,
                                        String.Empty,
                                        TableName.HREmployeesTableName,
                                        BOSList<HREmployeesInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            EmployeePayRollAuditList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HRPayRollAuditsInfo objPayRollAuditsInfo = (HRPayRollAuditsInfo)MainObject;
            objPayRollAuditsInfo.HRPayRollAuditDate = BOSApp.GetCurrentServerDate();
            objPayRollAuditsInfo.HRPayRollAuditType = PayRollAuditType.Hour.ToString();
            objPayRollAuditsInfo.HRPayRollAuditStatus = PayRollAuditStatus.New.ToString();
            objPayRollAuditsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                EmployeePayRollAuditList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        #region Invalidate Module Objects functions
        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void InvalidateModuleObjects(int iObjectID)
        {
            HREmployeePayRollAuditsController objEmployeePayRollAuditsController = new HREmployeePayRollAuditsController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            List<HREmployeePayRollAuditsInfo> employeePayRollList = objEmployeePayRollAuditsController.GetEmployeePayRollAuditByPayRollAuditIDAndUserGroup(iObjectID, BOSApp.CurrentUserGroupInfo.ADUserGroupID);
            EmployeePayRollAuditList.Invalidate(employeePayRollList);
            HREmployeePayRollAuditDetailsController objEmployeePayRollAuditDetailsController = new HREmployeePayRollAuditDetailsController();
            foreach (HREmployeePayRollAuditsInfo obj in EmployeePayRollAuditList)
            {
                obj.HREmployeePayRollAuditDetailsList = objEmployeePayRollAuditDetailsController.GetListEmployeePayRollAuditDetailByEmployeePayRollAudit(
                                                                               obj.HREmployeePayRollAuditID);
            }
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            int payRollAuditID = base.SaveMainObject();

            HRPayRollAuditsInfo payRollAudit = (HRPayRollAuditsInfo)MainObject;
            if (payRollAudit.FK_HRTimeSheetAuditID > 0)
            {
                HRTimeSheetAuditsController objTimeSheetAuditsController = new HRTimeSheetAuditsController();
                HRTimeSheetAuditsInfo timeSheetAudit = (HRTimeSheetAuditsInfo)objTimeSheetAuditsController.GetObjectByID(payRollAudit.FK_HRTimeSheetAuditID);
                if (timeSheetAudit != null)
                {
                    timeSheetAudit.HRTimeSheetAuditStatus = TimeSheetAuditStatus.SalaryCalculated.ToString();
                    objTimeSheetAuditsController.UpdateObject(timeSheetAudit);
                }
            }
            return payRollAuditID;
        }

        public override void SaveModuleObjects()
        {
            EmployeePayRollAuditList.SaveItemObjects();
            HREmployeePayRollAuditDetailsController objEmployeePayRollAuditDetailsController = new HREmployeePayRollAuditDetailsController();
            foreach (HREmployeePayRollAuditsInfo objEmployeePayRollAuditsInfo in EmployeePayRollAuditList)
            {
                objEmployeePayRollAuditDetailsController.DeleteByForeignColumn("FK_HREmployeePayRollAuditID", objEmployeePayRollAuditsInfo.HREmployeePayRollAuditID);
                foreach (HREmployeePayRollAuditDetailsInfo obj in objEmployeePayRollAuditsInfo.HREmployeePayRollAuditDetailsList)
                {
                    obj.FK_HREmployeePayRollAuditID = objEmployeePayRollAuditsInfo.HREmployeePayRollAuditID;
                    objEmployeePayRollAuditDetailsController.CreateObject(obj);
                }
            }
        }
        #endregion

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);

            if (strTableName == TableName.HRPayRollsTableName)
            {
                HREmployeePayRollAuditsController objEmployeePayRollAuditsController = new HREmployeePayRollAuditsController();
                objEmployeePayRollAuditsController.DeleteByForeignColumn("FK_HRPayRollAuditID", iObjectID);
            }
        }
    }
}
