using BOSCommon;
using BOSCommon.Constants;
using System;
using System.Collections.Generic;
using System.Data;

namespace BOSERP.Modules.HRAllowance
{
    class HRAllowanceEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<HREmployeeAllowancesInfo> HREmployeeAllowancesList { get; set; }
        public BOSList<HRAllowanceItemsInfo> HRAllowanceItemsList { get; set; }
        public BOSList<HREmployeesInfo> HREmployeeList { get; set; }
        #endregion

        #region Constructor
        public HRAllowanceEntities()
            : base()
        {
            HREmployeeList = new BOSList<HREmployeesInfo>();
        }

        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitMainObject()
        {
            MainObject = new HRAllowancesInfo();
            SearchObject = new HRAllowancesInfo();
            HREmployeeAllowancesList = new BOSList<HREmployeeAllowancesInfo>();
            HRAllowanceItemsList = new BOSList<HRAllowanceItemsInfo>();
        }

        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.HREmployeeAllowancesTableName, new HREmployeeAllowancesInfo());
            ModuleObjects.Add(TableName.HREmployeesTableName, new HREmployeesInfo());
        }

        public override void InitModuleObjectList()
        {
            HREmployeeAllowancesList.InitBOSList(
                                            this,
                                            TableName.HRAllowancesTableName,
                                            TableName.HREmployeeAllowancesTableName,
                                            BOSList<HREmployeeAllowancesInfo>.cstRelationForeign);
            HREmployeeAllowancesList.ItemTableForeignKey = "FK_HRAllowanceID";

            HRAllowanceItemsList.InitBOSList(
                                            this,
                                            TableName.HRAllowancesTableName,
                                            TableName.HRAllowanceItemsTableName,
                                            BOSList<HRAllowanceItemsInfo>.cstRelationForeign);
            HRAllowanceItemsList.ItemTableForeignKey = "FK_HRAllowanceID";

            HREmployeeList.InitBOSList(
                                        this,
                                        String.Empty,
                                        TableName.HREmployeesTableName,
                                        BOSList<HREmployeesInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            HREmployeeAllowancesList.InitBOSListGridControl();
            HRAllowanceItemsList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                HREmployeeAllowancesList.SetDefaultListAndRefreshGridControl();
                HRAllowanceItemsList.SetDefaultListAndRefreshGridControl();
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
            HREmployeeAllowancesList.Invalidate(iObjectID);
            HRAllowanceItemsList.Invalidate(iObjectID);
            InvalidateEmployeeAllowancesList(iObjectID);
        }
        #endregion

        #region Save Module Objects functions
        public override int SaveMainObject()
        {
            return base.SaveMainObject();
        }
        public override void SaveModuleObjects()
        {
            HREmployeeAllowancesList.SaveItemObjects();
        }
        #endregion

        /// <summary>
        /// Set default values employee Allowance from employee
        /// </summary>
        /// <param name="objEmployeeAllowancesInfo">Info of table HREmployeeAllowances</param>
        /// <param name="objEmployeesInfo">Info of table HREmployees</param>
        public void SetDefaultValuesFromEmployee(HREmployeeAllowancesInfo objEmployeeAllowancesInfo, HREmployeesInfo objEmployeesInfo)
        {
            HRAllowancesInfo objAllowancesInfo = (HRAllowancesInfo)MainObject;
            objEmployeeAllowancesInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
            objEmployeeAllowancesInfo.FK_HRAllowanceID = objAllowancesInfo.HRAllowanceID;
            //objEmployeeAllowancesInfo.HREmployeeAllowanceValue = objAllowancesInfo.HRAllowanceValue;
            objEmployeeAllowancesInfo.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
            objEmployeeAllowancesInfo.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
            objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = objAllowancesInfo.HRAllowanceConfigValue;
            objEmployeeAllowancesInfo.HREmployeeAllowanceValue = objAllowancesInfo.HRAllowanceValue;

            // Set default config
            //Khanh Huy 16-07-2019
            //int timeSpan = GetTimeSpan(objEmployeesInfo.HREmployeeStartWorkingDate);
            //HRAllowanceConfigsController objAllowanceConfigsController = new HRAllowanceConfigsController();
            //List<HRAllowanceConfigsInfo> listAllowanceConfigsInfo = objAllowanceConfigsController.GetAllowanceConfigByFKEmployeePayrollFormula(objEmployeesInfo.FK_HREmployeePayrollFormulaID);
            //if (listAllowanceConfigsInfo != null)
            //{
            //    HREmployeeTimeSheetsController objEmployeeTimeSheetsController = new HREmployeeTimeSheetsController();
            //    HREmployeeTimeSheetsInfo objEmployeeTimeSheetsInfo = objEmployeeTimeSheetsController.GetEmployeeTimeSheetBySomeCriteria(objEmployeesInfo.HREmployeeID, objAllowancesInfo.HRAllowanceFromDate);
            //    HRTimesheetConfigsController objTimesheetConfigsController = new HRTimesheetConfigsController();
            //    int dateQty = objTimesheetConfigsController.GetDaysPerMonthByEmployeeFormullaID(objEmployeesInfo.FK_HREmployeePayrollFormulaID, objAllowancesInfo.HRAllowanceFromDate.Month);

            //    foreach (HRAllowanceConfigsInfo item in listAllowanceConfigsInfo)
            //    {
            //        if (item.HRAllowanceConfigName == AllowanceConfigName.Diligence.ToString() && objAllowancesInfo.HRAllowanceType == AllowanceType.Diligence.ToString())
            //        {
            //            objEmployeeAllowancesInfo.HREmployeeAllowanceAmount = item.HRAllowanceConfigAmount;
            //            if (objEmployeeTimeSheetsInfo != null && objEmployeeTimeSheetsInfo.HREmployeeTimeSheetWorkingQty + objEmployeeTimeSheetsInfo.HREmployeeTimeSheetLeaveQty >= dateQty)
            //            {
            //                if (!item.HRAllowanceConfigIsTimeKeeping)
            //                    objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = item.HRAllowanceConfigAmount;
            //                else
            //                    objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = item.HRAllowanceConfigAmount * objEmployeeTimeSheetsInfo.HREmployeeTimeSheetWorkingQty;
            //            }
            //        }
            //        if (item.HRAllowanceConfigName == AllowanceConfigName.HeavyToxic.ToString() && objAllowancesInfo.HRAllowanceType == AllowanceType.HeavyToxic.ToString())
            //        {
            //            objEmployeeAllowancesInfo.HREmployeeAllowanceAmount = item.HRAllowanceConfigAmount;
            //            if (item.HRAllowanceConfigIsTimeKeeping)
            //            {
            //                if (objEmployeeTimeSheetsInfo != null)
            //                    objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetWorkingQty * item.HRAllowanceConfigAmount;
            //            }
            //            else
            //                objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = item.HRAllowanceConfigAmount;
            //        }
            //        if (item.HRAllowanceConfigName == AllowanceConfigName.Perennial.ToString() && objAllowancesInfo.HRAllowanceType == AllowanceType.Perennial.ToString())
            //        {
            //            if (timeSpan >= item.HRAllowanceConfigFromDate && timeSpan < item.HRAllowanceConfigToDate)
            //            {
            //                objEmployeeAllowancesInfo.HREmployeeAllowanceAmount = item.HRAllowanceConfigAmount;
            //                if (item.HRAllowanceConfigIsTimeKeeping)
            //                {
            //                    if (objEmployeeTimeSheetsInfo != null)
            //                        objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetWorkingQty * item.HRAllowanceConfigAmount;
            //                }
            //                else
            //                {
            //                    objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = item.HRAllowanceConfigAmount;
            //                }
            //            }
            //        }
            //        //TNDLoc [ADD][22/12/2015][Other allowance],START
            //        if (item.HRAllowanceConfigName == AllowanceConfigName.Other.ToString() && objAllowancesInfo.HRAllowanceType == AllowanceType.Other.ToString())
            //        {
            //            objEmployeeAllowancesInfo.HREmployeeAllowanceAmount = item.HRAllowanceConfigAmount;
            //            if (item.HRAllowanceConfigIsTimeKeeping)
            //            {
            //                if (objEmployeeTimeSheetsInfo != null)
            //                    objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetWorkingQty * item.HRAllowanceConfigAmount;
            //            }
            //            else
            //                objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = item.HRAllowanceConfigAmount;
            //        }
            //        //TNDLoc [ADD][22/12/2015][Other allowance],END
            //    }
            //}

            //float result;
            //// Set Amount Bus
            //if (objAllowancesInfo.HRAllowanceType == AllowanceType.Bus.ToString())
            //{
            //    if (!objAllowancesInfo.HRAllowanceValue.Equals(String.Empty) && Single.TryParse(objAllowancesInfo.HRAllowanceValue, out result))
            //    {
            //        objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = Convert.ToDecimal(objAllowancesInfo.HRAllowanceValue);
            //    }
            //    else
            //    {
            //        objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = 0;
            //    }
            //}  

            //if (objAllowancesInfo.HRAllowanceType.Contains("Amount"))
            //{
            //    if (!objAllowancesInfo.HRAllowanceValue.Equals(String.Empty) && Single.TryParse(objAllowancesInfo.HRAllowanceValue, out result))
            //    {
            //        objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = Convert.ToDecimal(objAllowancesInfo.HRAllowanceValue);
            //    }
            //    else
            //    {
            //        objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = 0;
            //    }                
            //}  
            //16-07-2019
            UpdateModuleObjectBindingSource(TableName.HREmployeeAllowancesTableName);
        }
        //TNDLoc [ADD][18/12/2015][Update Employee Allowance],START
        public void SetDefaultValuesFromEmployee(HREmployeeAllowancesInfo objEmployeeAllowancesInfo, HREmployeesInfo objEmployeesInfo, decimal configValue)
        {
            HRAllowancesInfo objAllowancesInfo = (HRAllowancesInfo)MainObject;
            //objEmployeeAllowancesInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
            //objEmployeeAllowancesInfo.FK_HRAllowanceID = objAllowancesInfo.HRAllowanceID;
            //objEmployeeAllowancesInfo.HREmployeeAllowanceValue = objAllowancesInfo.HRAllowanceValue;
            //objEmployeeAllowancesInfo.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
            //objEmployeeAllowancesInfo.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;

            // Set default config
            int timeSpan = GetTimeSpan(objEmployeesInfo.HREmployeeStartWorkingDate);
            HRAllowanceConfigsController objAllowanceConfigsController = new HRAllowanceConfigsController();
            List<HRAllowanceConfigsInfo> listAllowanceConfigsInfo = objAllowanceConfigsController.GetAllowanceConfigByFKEmployeePayrollFormula(objEmployeesInfo.FK_HREmployeePayrollFormulaID);
            if (listAllowanceConfigsInfo != null)
            {
                HREmployeeTimeSheetsController objEmployeeTimeSheetsController = new HREmployeeTimeSheetsController();
                HREmployeeTimeSheetsInfo objEmployeeTimeSheetsInfo = objEmployeeTimeSheetsController.GetEmployeeTimeSheetBySomeCriteria(objEmployeesInfo.HREmployeeID, objAllowancesInfo.HRAllowanceFromDate);
                HRTimesheetConfigsController objTimesheetConfigsController = new HRTimesheetConfigsController();
                int dateQty = objTimesheetConfigsController.GetDaysPerMonthByEmployeeFormullaID(objEmployeesInfo.FK_HREmployeePayrollFormulaID, objAllowancesInfo.HRAllowanceFromDate.Month);

                foreach (HRAllowanceConfigsInfo item in listAllowanceConfigsInfo)
                {
                    if (item.HRAllowanceConfigName == AllowanceConfigName.Diligence.ToString() && objAllowancesInfo.HRAllowanceType == AllowanceType.Diligence.ToString())
                    {
                        objEmployeeAllowancesInfo.HREmployeeAllowanceAmount = configValue;
                        if (objEmployeeTimeSheetsInfo != null && objEmployeeTimeSheetsInfo.HREmployeeTimeSheetWorkingQty + objEmployeeTimeSheetsInfo.HREmployeeTimeSheetLeaveQty >= dateQty)
                        {
                            if (!item.HRAllowanceConfigIsTimeKeeping)
                                objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = configValue;
                            else
                                objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = configValue * objEmployeeTimeSheetsInfo.HREmployeeTimeSheetWorkingQty;
                        }
                    }
                    if (item.HRAllowanceConfigName == AllowanceConfigName.HeavyToxic.ToString() && objAllowancesInfo.HRAllowanceType == AllowanceType.HeavyToxic.ToString())
                    {
                        objEmployeeAllowancesInfo.HREmployeeAllowanceAmount = configValue;
                        if (item.HRAllowanceConfigIsTimeKeeping)
                        {
                            if (objEmployeeTimeSheetsInfo != null)
                                objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetWorkingQty * configValue;
                        }
                        else
                            objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = configValue;
                    }
                    if (item.HRAllowanceConfigName == AllowanceConfigName.Perennial.ToString() && objAllowancesInfo.HRAllowanceType == AllowanceType.Perennial.ToString())
                    {
                        if (timeSpan >= item.HRAllowanceConfigFromDate && timeSpan < item.HRAllowanceConfigToDate)
                        {
                            objEmployeeAllowancesInfo.HREmployeeAllowanceAmount = configValue;
                            if (item.HRAllowanceConfigIsTimeKeeping)
                            {
                                if (objEmployeeTimeSheetsInfo != null)
                                    objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetWorkingQty * configValue;
                            }
                            else
                            {
                                objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = configValue;
                            }
                        }
                    }
                    if (item.HRAllowanceConfigName == AllowanceConfigName.Other.ToString() && objAllowancesInfo.HRAllowanceType == AllowanceType.Other.ToString())
                    {
                        objEmployeeAllowancesInfo.HREmployeeAllowanceAmount = configValue;
                        if (item.HRAllowanceConfigIsTimeKeeping)
                        {
                            if (objEmployeeTimeSheetsInfo != null)
                                objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = objEmployeeTimeSheetsInfo.HREmployeeTimeSheetWorkingQty * configValue;
                        }
                        else
                            objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = configValue;
                    }
                }
            }

            float result;
            // Set Amount Bus
            if (objAllowancesInfo.HRAllowanceType == AllowanceType.Bus.ToString())
            {
                if (!objAllowancesInfo.HRAllowanceValue.Equals(String.Empty) && Single.TryParse(objAllowancesInfo.HRAllowanceValue, out result))
                {
                    objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = Convert.ToDecimal(objAllowancesInfo.HRAllowanceValue);
                }
                else
                {
                    objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = 0;
                }
            }

            if (objAllowancesInfo.HRAllowanceType.Contains("Amount"))
            {
                if (!objAllowancesInfo.HRAllowanceValue.Equals(String.Empty) && Single.TryParse(objAllowancesInfo.HRAllowanceValue, out result))
                {
                    objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = Convert.ToDecimal(objAllowancesInfo.HRAllowanceValue);
                }
                else
                {
                    objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = 0;
                }
            }
            UpdateModuleObjectBindingSource(TableName.HREmployeeAllowancesTableName);
        }
        //TNDLoc [ADD][18/12/2015][Update Employee Allowance],END
        // Get Time Span
        public int GetTimeSpan(DateTime startDate)
        {
            DateTime currentDate = DateTime.Now;
            int result = currentDate.Year - startDate.Year;
            if (result <= 0)
                return 0;
            if (currentDate.Month < startDate.Month)
                result--;
            if (currentDate.Month == startDate.Month)
                if (currentDate.Day < startDate.Day)
                    result--;
            return result;
        }

        /// <summary>
        /// Invalidate employee Allowance list and its grid control
        /// </summary>
        /// <param name="AllowanceID">ID of Allowance</param>
        public void InvalidateEmployeeAllowancesList(int allowanceID)
        {
            HREmployeeAllowancesController objEmployeeAllowancesController = new HREmployeeAllowancesController();
            DataSet dsEmployeeAllowance = objEmployeeAllowancesController.GetEmployeeAllowanceListByAllowanceID(allowanceID);
            HREmployeeAllowancesList.Invalidate(dsEmployeeAllowance);
            HREmployeesController objEmployeesController = new HREmployeesController();
            foreach (var item in HREmployeeAllowancesList)
            {
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(item.FK_HREmployeeID);
                item.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
            }
        }
    }
}
