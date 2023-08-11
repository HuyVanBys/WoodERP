using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Data;

namespace BOSERP.Modules.EmployeeTransmit
{
    public class EmployeeTransmitEntities : BaseTransactionEntities
    {
        public BOSList<HREmployeeTransmitItemsInfo> EmployeeTransmitItemList { get; set; }
        public BOSList<HREmployeesInfo> HREmployeeList { get; set; }
        public EmployeeTransmitEntities()
            : base()
        {
            EmployeeTransmitItemList = new BOSList<HREmployeeTransmitItemsInfo>();
            HREmployeeList = new BOSList<HREmployeesInfo>();
        }

        public override void InitMainObject()
        {
            MainObject = new HREmployeeTransmitsInfo();
            SearchObject = new HREmployeeTransmitsInfo();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeeTransmitItemsTableName, new HREmployeeTransmitItemsInfo());
            ModuleObjects.Add(TableName.HREmployeesTableName, new HREmployeesInfo());
        }

        public override void InitModuleObjectList()
        {
            EmployeeTransmitItemList.InitBOSList(this, TableName.HREmployeeTransmitsTableName,
                                                        TableName.HREmployeeTransmitItemsTableName,
                                                        BOSList<HREmployeeTransmitItemsInfo>.cstRelationForeign);
            EmployeeTransmitItemList.ItemTableForeignKey = "FK_HREmployeeTransmitID";

            HREmployeeList.InitBOSList(
                                       this,
                                       String.Empty,
                                       TableName.HREmployeesTableName,
                                       BOSList<HREmployeesInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            EmployeeTransmitItemList.InitBOSListGridControl();
        }

        public override void SetDefaultMainObject()
        {
            base.SetDefaultMainObject();
            HRWorkingShiftsController workingShiftController = new HRWorkingShiftsController();
            HRWorkingShiftsInfo objWorkingShiftsInfo = workingShiftController.GetDefaultWorkingShiftByPayrollFormulaIDAndWorkingShiftDayOfWeek(null, null);
            HREmployeeTransmitsInfo objEmployeeTransmitsInfo = (HREmployeeTransmitsInfo)MainObject;
            DateTime severDate = BOSApp.GetCurrentServerDate();
            objEmployeeTransmitsInfo.HREmployeeTransmitFromDate = severDate;
            objEmployeeTransmitsInfo.HREmployeeTransmitToDate = severDate;
            objEmployeeTransmitsInfo.HREmployeeTransmitDate = severDate;
            objEmployeeTransmitsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;

            if (objWorkingShiftsInfo != null)
            {
                objEmployeeTransmitsInfo.HREmployeeTransmitDateStart = objWorkingShiftsInfo.HRWorkingShiftFromTime;
                objEmployeeTransmitsInfo.HREmployeeTransmitDateEnd = objWorkingShiftsInfo.HRWorkingShiftToTime;
            }
            objEmployeeTransmitsInfo.HREmployeeTransmitStatus = EmployeeTransmitStatus.New.ToString();
            UpdateMainObjectBindingSource();
        }

        public override void SetDefaultModuleObjects()
        {
            base.SetDefaultModuleObjects();
            try
            {
                EmployeeTransmitItemList.SetDefaultListAndRefreshGridControl();
                HREmployeeList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InvalidateMainObject(int iObjectID)
        {
            base.InvalidateMainObject(iObjectID);
        }

        public override void SaveModuleObjects()
        {
            base.SaveModuleObjects();
            EmployeeTransmitItemList.SaveItemObjects();
        }
        public override void InvalidateModuleObjects(int iObjectID)
        {
            HREmployeeTransmitItemsController objEmployeeTransmitItemsController = new HREmployeeTransmitItemsController();
            DataSet ds = objEmployeeTransmitItemsController.GetAllDataByEmployeeTransmitID(iObjectID);
            EmployeeTransmitItemList.Invalidate(ds);
            ds.Dispose();
            HREmployeeList.Clear();
        }


    }
}
