using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.HRPayRoll
{
    public class HRPayRollEntities : BaseTransactionEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the employee payroll list
        /// </summary>
        public BOSList<HREmployeePayRollsInfo> EmployeePayRollList { get; set; }
        /// <summary>
        /// Gets or sets the employee list
        /// </summary>
        public BOSList<HREmployeesInfo> EmployeeList { get; set; }
        #endregion

        #region Constructor
        public HRPayRollEntities()
            : base()
        {
            EmployeePayRollList = new BOSList<HREmployeePayRollsInfo>();
            EmployeeList = new BOSList<HREmployeesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRPayRollsInfo();

        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeePayRollsTableName, new HREmployeePayRollsInfo());
            ModuleObjects.Add(TableName.HREmployeesTableName, new HREmployeesInfo());
        }

        public override void InitModuleObjectList()
        {
            EmployeePayRollList.InitBOSList(
                                            this,
                                            TableName.HRPayRollsTableName,
                                            TableName.HREmployeePayRollsTableName,
                                            BOSList<HREmployeePayRollsInfo>.cstRelationForeign);
            EmployeePayRollList.ItemTableForeignKey = "FK_HRPayRollID";

            EmployeeList.InitBOSList(
                                        this,
                                        String.Empty,
                                        TableName.HREmployeesTableName,
                                        BOSList<HREmployeesInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            EmployeePayRollList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HRPayRollsInfo objPayRollsInfo = (HRPayRollsInfo)MainObject;
            objPayRollsInfo.HRPayRollDate = DateTime.Now;
            objPayRollsInfo.HRPayRollType = PayRollType.Hour.ToString();
            objPayRollsInfo.HRPayRollStatus = PayRollStatus.New.ToString();
            objPayRollsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                EmployeePayRollList.SetDefaultListAndRefreshGridControl();
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
            HREmployeePayRollsController objEmployeePayRollsController = new HREmployeePayRollsController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            //TNDLoc [ADD][19/04/2016][Employee Permission],START
            // Origin: List<HREmployeePayRollsInfo> employeePayRollList = objEmployeePayRollsController.GetEmployeePayRollListByPayRollID(iObjectID);
            List<HREmployeePayRollsInfo> employeePayRollList = objEmployeePayRollsController.GetEmployeePayRollByPayRollIDAndUserGroup(iObjectID, BOSApp.CurrentUserGroupInfo.ADUserGroupID);
            //TNDLoc [ADD][19/04/2016][Employee Permission],END
            EmployeePayRollList.Invalidate(employeePayRollList);
            HREmployeePayrollDetailsController objEmployeePayrollDetailsController = new HREmployeePayrollDetailsController();
            foreach (HREmployeePayRollsInfo obj in EmployeePayRollList)
            {
                obj.HREmployeePayrollDetailsList = objEmployeePayrollDetailsController.GetListEmployeePayrollDetailByEmployeePayroll(
                                                                               obj.HREmployeePayRollID);
            }
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            int payRollID = base.SaveMainObject();

            HRPayRollsInfo payroll = (HRPayRollsInfo)MainObject;
            if (payroll.FK_HRTimeSheetID > 0)
            {
                HRTimeSheetsController objTimeSheetsController = new HRTimeSheetsController();
                HRTimeSheetsInfo timeSheet = (HRTimeSheetsInfo)objTimeSheetsController.GetObjectByID(payroll.FK_HRTimeSheetID);
                if (timeSheet != null)
                {
                    timeSheet.HRTimeSheetStatus = TimeSheetStatus.SalaryCalculated.ToString();
                    objTimeSheetsController.UpdateObject(timeSheet);
                }
            }

            return payRollID;
        }

        public override void SaveModuleObjects()
        {
            EmployeePayRollList.SaveItemObjects();
            HREmployeePayrollDetailsController objEmployeePayrollDetailsController = new HREmployeePayrollDetailsController();
            foreach (HREmployeePayRollsInfo objEmployeePayRollsInfo in EmployeePayRollList)
            {
                objEmployeePayrollDetailsController.DeleteByForeignColumn("FK_HREmployeePayRollID", objEmployeePayRollsInfo.HREmployeePayRollID);
                foreach (HREmployeePayrollDetailsInfo obj in objEmployeePayRollsInfo.HREmployeePayrollDetailsList)
                {
                    obj.FK_HREmployeePayrollID = objEmployeePayRollsInfo.HREmployeePayRollID;
                    objEmployeePayrollDetailsController.CreateObject(obj);
                }
            }
        }
        #endregion

        public override void DeleteObjectRelations(string strTableName, int iObjectID)
        {
            base.DeleteObjectRelations(strTableName, iObjectID);

            if (strTableName == TableName.HRPayRollsTableName)
            {
                HREmployeePayRollsController objEmployeePayRollsController = new HREmployeePayRollsController();
                objEmployeePayRollsController.DeleteByForeignColumn("FK_HRPayRollID", iObjectID);
            }
        }
    }
}
