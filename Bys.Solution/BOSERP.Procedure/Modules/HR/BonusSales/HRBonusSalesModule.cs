using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace BOSERP.Modules.BonusSales
{
    public class BonusSalesModule : BaseTransactionModule
    {
        #region Declare Constant
        /// <summary>
        /// The employee payroll grid control name
        /// </summary>
        public const string HRBonusSaleItemsGridControlName = "fld_dgcHRBonusSaleItems";
        #endregion

        #region Declare Variables
        /// <summary>
        /// Define employe payroll grid control
        /// </summary>
        private HRBonusSaleItemsGridControl BonusSaleItemsGridControl;
        #endregion

        public BonusSalesModule()
        {
            Name = "BonusSales";
            CurrentModuleEntity = new BonusSalesEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            BonusSaleItemsGridControl = (HRBonusSaleItemsGridControl)Controls[BonusSalesModule.HRBonusSaleItemsGridControlName];

        }

        public override void InvalidateToolbar()
        {
            HRBonusSalesInfo objBonusSalesInfo = (HRBonusSalesInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton("Approve", false);
            ParentScreen.SetEnableOfToolbarButton("Refresh", false);
            if (objBonusSalesInfo.HRBonusSaleID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton("Approve", true);
                ParentScreen.SetEnableOfToolbarButton("Refresh", true);
                if (objBonusSalesInfo.HRBonusSaleStatus == BonusSaleStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton("Refresh", false);
                }
            }

            base.InvalidateToolbar();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);

            BonusSalesEntities entity = (BonusSalesEntities)CurrentModuleEntity;
            HREmployeesController objEmployeesController = new HREmployeesController();
            List<HREmployeesInfo> employeeList = objEmployeesController.GetAllEmployees();
            foreach (HRBonusSaleItemsInfo objBonusSaleItemsInfo in entity.EmployeeBonusSaleList)
            {
                HREmployeesInfo objEmployeesInfo = employeeList.Where(e => e.HREmployeeID == objBonusSaleItemsInfo.FK_HREmployeeID).FirstOrDefault();
                if (objEmployeesInfo != null)
                {
                    objBonusSaleItemsInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
                    objBonusSaleItemsInfo.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
                }
            }
        }

        public void AddEmployee()
        {
            guiSearchEmployee guiEmployee = new guiSearchEmployee();
            guiEmployee.Module = this;
            if (guiEmployee.ShowDialog() == DialogResult.OK)
            {
                BonusSalesEntities entity = (BonusSalesEntities)CurrentModuleEntity;
                HRBonusSalesInfo objBonusSalesInfo = (HRBonusSalesInfo)entity.MainObject;
                HREmployeeAllowancesController objEmployeeAllowancesController = new HREmployeeAllowancesController();
                entity.EmployeeList.Invalidate(guiEmployee.SelectedEmployeeList);
                foreach (HREmployeesInfo objEmployeesInfo in entity.EmployeeList)
                {
                    if (objEmployeesInfo.Selected)
                    {
                        if (!entity.EmployeeBonusSaleList.Exists("FK_HREmployeeID", objEmployeesInfo.HREmployeeID))
                        {
                            HRTimesheetConfigsController objTimesheetConfigsController = new HRTimesheetConfigsController();
                            HRBonusSaleItemsInfo objBonusSaleItemsInfo = new HRBonusSaleItemsInfo();
                            objBonusSaleItemsInfo.FK_HRDepartmentID = objEmployeesInfo.FK_HRDepartmentID;
                            objBonusSaleItemsInfo.FK_HRDepartmentRoomID = objEmployeesInfo.FK_HRDepartmentRoomID;
                            objBonusSaleItemsInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
                            objBonusSaleItemsInfo.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
                            objBonusSaleItemsInfo.HRBonusSaleItemCardNumber = objEmployeesInfo.HREmployeeCardNumber;
                            objBonusSaleItemsInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;

                            HRTimeSheetsController objTimeSheetsController = new HRTimeSheetsController();
                            HREmployeeTimeSheetsController objEmployeeTimeSheetsController = new HREmployeeTimeSheetsController();
                            HRTimeSheetEntrysController objTimeSheetEntrysController = new HRTimeSheetEntrysController();

                            List<HRTimeSheetEntrysInfo> employeeTimeSheetEntryList = new List<HRTimeSheetEntrysInfo>();
                            //List<HREmployeeTimeSheetsInfo> employeeTimeSheetList = (List<HREmployeeTimeSheetsInfo>)objEmployeeTimeSheetsController.GetEmployeeTimeSheetByFromDateAndToDate(objEmployeesInfo.HREmployeeID, objBonusSalesInfo.HRBonusSaleFromDate, objBonusSalesInfo.HRBonusSaleToDate);
                            List<HREmployeeTimeSheetsInfo> employeeTimeSheetList = new List<HREmployeeTimeSheetsInfo>();
                            HREmployeeTimeSheetsInfo employeeTimeSheet = new HREmployeeTimeSheetsInfo();
                            if (employeeTimeSheetList.Count() > 0)
                            {
                                employeeTimeSheet = (HREmployeeTimeSheetsInfo)employeeTimeSheetList.LastOrDefault();
                            }
                            if (employeeTimeSheet == null)
                                continue;

                            HRTimeSheetsInfo objTimeSheetsInfo = (HRTimeSheetsInfo)objTimeSheetsController.GetObjectByID(employeeTimeSheet.FK_HRTimeSheetID);

                            if (objTimeSheetsInfo == null)
                                continue;

                            if (objEmployeesInfo.FK_HREmployeePayrollFormulaID > 0)
                            {
                                //objEmployeesInfo.HREmployeeDaysPerMonth = objTimesheetConfigsController.GetDaysPerMonthByEmployeeFormullaID(objEmployeesInfo.FK_HREmployeePayrollFormulaID, objBonusSalesInfo.HRBonusSaleDate.Month, objBonusSalesInfo.HRBonusSaleDate.Year);
                                objEmployeesInfo.HREmployeeDaysPerMonth = 0;
                                employeeTimeSheetEntryList = objTimeSheetEntrysController.GetTotalTimeSheetEntryByTimeSheetIDAndEmployeeTimeSheetID(objTimeSheetsInfo.HRTimeSheetID, employeeTimeSheet.HREmployeeTimeSheetID);

                                decimal totalSalaryFactor = 0;
                                decimal totalSalaryOTHours = 0;

                                HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
                                HRTimeSheetParamsInfo objTimeSheetParamsInfo = new HRTimeSheetParamsInfo();
                                foreach (HRTimeSheetEntrysInfo objTimeSheetEntrysInfo in employeeTimeSheetEntryList)
                                {
                                    objTimeSheetParamsInfo = (HRTimeSheetParamsInfo)objTimeSheetParamsController.GetObjectByID(objTimeSheetEntrysInfo.FK_HRTimeSheetParamID);
                                    if (objTimeSheetEntrysInfo.IsOT == false)
                                    {
                                        if (objTimeSheetParamsInfo.HRTimeSheetParamType != TimeSheetParamType.Common.ToString())
                                        {
                                            totalSalaryFactor += objTimeSheetEntrysInfo.HRTimeSheetEntryWorkingQty;
                                        }
                                    }
                                    else
                                    {
                                        totalSalaryOTHours += objTimeSheetEntrysInfo.HRTimeSheetEntryWorkingHours;
                                    }
                                }
                                // Công thực tế
                                objBonusSaleItemsInfo.HRBonusSaleItemWorkingQty = totalSalaryFactor;
                                objBonusSaleItemsInfo = CalculateBonusSaleRewardTargets(objBonusSaleItemsInfo, objEmployeesInfo);
                                entity.EmployeeBonusSaleList.Add(objBonusSaleItemsInfo);
                            }
                        }
                    }
                }
                CalculatePayRollTotalAmounts();
                entity.EmployeeBonusSaleList.GridControl.RefreshDataSource();
            }
        }

        public void ApproveBonusSales()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                BonusSalesEntities entity = (BonusSalesEntities)CurrentModuleEntity;
                HRBonusSalesInfo objBonusSalesInfo = (HRBonusSalesInfo)entity.MainObject;
                if (objBonusSalesInfo.HRBonusSaleID > 0)
                {
                    entity.SetPropertyChangeEventLock(false);
                    objBonusSalesInfo.HRBonusSaleStatus = BonusSaleStatus.Approved.ToString();
                    entity.UpdateMainObject();
                    InvalidateToolbar();
                }
            }
        }

        #region Calculate the Reward Targets of an employee's payroll
        /// <summary>
        /// Calculate the Reward Targets of an employee's payroll
        /// </summary>
        /// <param name="objBonusSaleItemsInfo">Given employee payroll</param>        
        public HRBonusSaleItemsInfo CalculateBonusSaleRewardTargets(HRBonusSaleItemsInfo objBonusSaleItemsInfo, HREmployeesInfo objEmployeesInfo)
        {
            if (objBonusSaleItemsInfo != null)
            {
                BonusSalesEntities entity = (BonusSalesEntities)CurrentModuleEntity;
                HRBonusSalesInfo objBonusSalesInfo = (HRBonusSalesInfo)entity.MainObject;
                DateTime dateFrom = objBonusSalesInfo.HRBonusSaleFromDate;
                DateTime dateTo = objBonusSalesInfo.HRBonusSaleToDate;
                DateTime startDate = new DateTime(objBonusSalesInfo.HRBonusSaleDate.Year, objBonusSalesInfo.HRBonusSaleDate.Month, 1);
                DateTime endDate = new DateTime(objBonusSalesInfo.HRBonusSaleDate.Year, objBonusSalesInfo.HRBonusSaleDate.Month, DateTime.DaysInMonth(objBonusSalesInfo.HRBonusSaleDate.Year, objBonusSalesInfo.HRBonusSaleDate.Month));
                HREmployeesController employeeController = new HREmployeesController();
                ADReportsController objReportsController = new ADReportsController();
                HRConfigSalesTargetsController objConfigSalesTargetsController = new HRConfigSalesTargetsController();
                HRConfigSalesTargetItemsController objConfigSalesTargetItemsController = new HRConfigSalesTargetItemsController();

                HRConfigSalesFormulaPayrollItemsController objConfigSalesFormulaPayrollItemsController = new HRConfigSalesFormulaPayrollItemsController();
                HRConfigSalesFormulaPayrollsController objConfigSalesFormulaPayrollsController = new HRConfigSalesFormulaPayrollsController();

                HRConfigSalesFormulaPayrollItemsInfo objConfigSalesFormulaPayrollItemsInfo = new HRConfigSalesFormulaPayrollItemsInfo();

                //List<HRConfigSalesTargetsInfo> configSalesTargets = objConfigSalesTargetsController.GetConfigSalesTargetsByConfigSalesTargetApplicableSubjects(ConfigSalesTargetApplicableSubjects.Employee.ToString(), dateFrom, dateTo);
                List<HRConfigSalesTargetItemsInfo> configSalesTargetItems =
                            objConfigSalesTargetItemsController.GetConfigSalesTargetItemsByConfigSalesTargetIDAndMonth(ConfigSalesTargetApplicableSubjects.Branch.ToString(), ConfigSalesTargetType.Month.ToString(), dateFrom, dateTo, objEmployeesInfo.FK_BRBranchID, ConfigSalesTargetApplicableSubjects.Branch.ToString(), dateTo.Month);

                HRConfigSalesTargetItemsInfo objConfigSalesTargetItemsInfo = new HRConfigSalesTargetItemsInfo();
                List<HRConfigSalesFormulaPayrollItemsInfo> configSalesFormulaPayrollItems = new List<HRConfigSalesFormulaPayrollItemsInfo>();
                List<HRConfigSalesFormulaPayrollsInfo> configSalesFormulaPayrolls = new List<HRConfigSalesFormulaPayrollsInfo>();
                HRConfigSalesFormulaPayrollsInfo objConfigSalesFormulaPayrollsInfo = new HRConfigSalesFormulaPayrollsInfo();

                List<HREmployeesInfo> objEmployeesCompany = objReportsController.GetEmployeeSaleSummaryList(0, 0, 0, startDate, endDate);
                List<HREmployeesInfo> objEmployeesBranch = objReportsController.GetEmployeeSaleSummaryList(0, objEmployeesInfo.FK_BRBranchID, 0, startDate, endDate);
                HRConfigSalesTargetItemsInfo objConfigSalesTargetItemsCompany =
                            (HRConfigSalesTargetItemsInfo)objConfigSalesTargetItemsController.GetConfigSalesTargetItemsByConfigSalesTargetIDAndMonth(ConfigSalesTargetApplicableSubjects.Company.ToString(), ConfigSalesTargetType.Month.ToString(), dateFrom, dateTo, 1, ConfigSalesTargetApplicableSubjects.Company.ToString(), dateTo.Month).LastOrDefault();

                if (configSalesTargetItems.Count() > 0)
                {
                    objConfigSalesTargetItemsInfo = (HRConfigSalesTargetItemsInfo)configSalesTargetItems.LastOrDefault();
                }

                HRPercentageRetainedsController objPercentageRetainedsController = new HRPercentageRetainedsController();
                List<HRPercentageRetainedsInfo> percentageRetainedsList = (List<HRPercentageRetainedsInfo>)objPercentageRetainedsController.GetListFromDataSet(objPercentageRetainedsController.GetAllObjects());

                bool isManager = false;
                //isManager = employeeController.IsManager(objBonusSaleItemsInfo.FK_HREmployeeID);

                if (!isManager)
                {
                    if (objConfigSalesTargetItemsInfo != null)
                    {
                        HREmployeesController objEmployeesController = new HREmployeesController();
                        List<HREmployeesInfo> listEmployeesNVBH = new List<HREmployeesInfo>();
                        //listEmployeesNVBH = (List<HREmployeesInfo>)objEmployeesController.GetHREmployeesByFK_BRBranchIDAndHRLevel(objEmployeesInfo.FK_BRBranchID);
                        int qtyNVBH = 0;
                        if (listEmployeesNVBH.Count() > 0)
                        {
                            qtyNVBH = listEmployeesNVBH.Count;
                        }
                        if (qtyNVBH > 0)
                        {
                            objBonusSaleItemsInfo.HRBonusSaleItemTarget = objConfigSalesTargetItemsInfo.HRConfigSalesTargetItemValue / qtyNVBH;
                        }
                        else
                        {
                            objBonusSaleItemsInfo.HRBonusSaleItemTarget = objConfigSalesTargetItemsInfo.HRConfigSalesTargetItemValue;
                        }
                    }

                    HREmployeesInfo objEmployeesInfo2 =
                                   (HREmployeesInfo)objReportsController.GetEmployeeSaleSummaryList(0, 0, objBonusSaleItemsInfo.FK_HREmployeeID, startDate, endDate).FirstOrDefault();

                    if (objEmployeesInfo2 != null)
                    {
                        objBonusSaleItemsInfo.HRBonusSaleItemAmount = objEmployeesInfo2.TotalSaleAmount;
                        objBonusSaleItemsInfo.HRBonusSaleItemDSBHNoVAT = objEmployeesInfo2.TotalSaleAmount;
                    }

                    if (percentageRetainedsList.Count() > 0)
                    {
                        HRPercentageRetainedsInfo objPercentageRetainedsInfo = (HRPercentageRetainedsInfo)percentageRetainedsList.LastOrDefault(o => o.HRPercentageRetainedType == PercentageRetainedType.Employee.ToString());
                        if (objPercentageRetainedsInfo != null)
                        {
                            objBonusSaleItemsInfo.HRBonusSaleItemPercentageRetained = objPercentageRetainedsInfo.HRPercentageRetainedRate;
                        }
                    }

                    configSalesFormulaPayrolls =
                           objConfigSalesFormulaPayrollsController.GetConfigSalesFormulaPayrollsByConfigSalesPayrollType(objBonusSalesInfo.HRBonusSaleFromDate, objBonusSalesInfo.HRBonusSaleToDate, ConfigSalesFormulaPayrollType.Seller.ToString());
                    if (configSalesFormulaPayrolls.Count() > 0)
                    {
                        objConfigSalesFormulaPayrollsInfo = (HRConfigSalesFormulaPayrollsInfo)configSalesFormulaPayrolls.LastOrDefault();
                        configSalesFormulaPayrollItems = (List<HRConfigSalesFormulaPayrollItemsInfo>)objConfigSalesFormulaPayrollItemsController.GetListFromDataSet(objConfigSalesFormulaPayrollItemsController.GetAllDataByForeignColumn("FK_HRConfigSalesFormulaPayrollID", objConfigSalesFormulaPayrollsInfo.HRConfigSalesFormulaPayrollID));
                        if (configSalesFormulaPayrollItems.Count() > 0)
                        {
                            if (objEmployeesInfo2 != null && objEmployeesBranch.Count() > 0 && objBonusSaleItemsInfo.HRBonusSaleItemTarget > 0)
                            {
                                decimal precentTarget = 0;
                                precentTarget = (objEmployeesInfo2.TotalSaleAmount / objBonusSaleItemsInfo.HRBonusSaleItemTarget) * 100;
                                objBonusSaleItemsInfo = CalculateBonusSaleRewardFormulas(precentTarget, objBonusSaleItemsInfo, configSalesFormulaPayrollItems, objConfigSalesTargetItemsCompany, objConfigSalesTargetItemsInfo, objEmployeesCompany, objEmployeesBranch);
                            }
                        }
                    }
                    objBonusSaleItemsInfo = CalculateBonusSaleReward(objBonusSaleItemsInfo, ConfigSalesFormulaPayrollType.Seller.ToString());
                }
                else
                {
                    if (objConfigSalesTargetItemsInfo != null)
                    {
                        objBonusSaleItemsInfo.HRBonusSaleItemTarget = objConfigSalesTargetItemsInfo.HRConfigSalesTargetItemValue;
                    }

                    if (objEmployeesBranch.Count() > 0)
                    {
                        objBonusSaleItemsInfo.HRBonusSaleItemManagementSalesAmount = (decimal)objEmployeesBranch.Sum(o => o.TotalSaleAmount);
                    }

                    if (percentageRetainedsList.Count() > 0)
                    {
                        HRPercentageRetainedsInfo objPercentageRetainedsInfo = (HRPercentageRetainedsInfo)percentageRetainedsList.LastOrDefault(o => o.HRPercentageRetainedType == PercentageRetainedType.Manager.ToString());
                        if (objPercentageRetainedsInfo != null)
                        {
                            objBonusSaleItemsInfo.HRBonusSaleItemPercentageRetained = objPercentageRetainedsInfo.HRPercentageRetainedRate;
                        }
                    }

                    configSalesFormulaPayrolls =
                           objConfigSalesFormulaPayrollsController.GetConfigSalesFormulaPayrollsByConfigSalesPayrollType(objBonusSalesInfo.HRBonusSaleFromDate, objBonusSalesInfo.HRBonusSaleToDate, ConfigSalesFormulaPayrollType.Management.ToString());
                    if (configSalesFormulaPayrolls.Count() > 0)
                    {
                        objConfigSalesFormulaPayrollsInfo = (HRConfigSalesFormulaPayrollsInfo)configSalesFormulaPayrolls.LastOrDefault();
                        configSalesFormulaPayrollItems = (List<HRConfigSalesFormulaPayrollItemsInfo>)objConfigSalesFormulaPayrollItemsController.GetListFromDataSet(objConfigSalesFormulaPayrollItemsController.GetAllDataByForeignColumn("FK_HRConfigSalesFormulaPayrollID", objConfigSalesFormulaPayrollsInfo.HRConfigSalesFormulaPayrollID));
                        if (configSalesFormulaPayrollItems.Count() > 0)
                        {
                            decimal totalSalse = objBonusSaleItemsInfo.HRBonusSaleItemTarget;
                            if (totalSalse > 0)
                            {
                                decimal precentTarget = 0;
                                precentTarget = (objBonusSaleItemsInfo.HRBonusSaleItemManagementSalesAmount / totalSalse) * 100;
                                objBonusSaleItemsInfo = CalculateBonusSaleRewardFormulas(precentTarget, objBonusSaleItemsInfo, configSalesFormulaPayrollItems, objConfigSalesTargetItemsCompany, objConfigSalesTargetItemsInfo, objEmployeesCompany, objEmployeesBranch);
                            }
                        }
                    }
                    objBonusSaleItemsInfo = CalculateBonusSaleReward(objBonusSaleItemsInfo, ConfigSalesFormulaPayrollType.Management.ToString());
                }
            }
            return objBonusSaleItemsInfo;
        }

        public HRBonusSaleItemsInfo CalculateBonusSaleRewardFormulas(decimal precentTarget, HRBonusSaleItemsInfo objBonusSaleItemsInfo, List<HRConfigSalesFormulaPayrollItemsInfo> configSalesFormulaPayrollItems, HRConfigSalesTargetItemsInfo objConfigSalesTargetItemsCompany, HRConfigSalesTargetItemsInfo objConfigSalesTargetItemsBranch, List<HREmployeesInfo> objEmployeesCompany, List<HREmployeesInfo> objEmployeesBranch)
        {
            decimal totalPrecentRewardTarget = 0;
            decimal precentTargetRemind = 0;
            decimal dependenceTargetCompany = 0;
            decimal dependenceTargetBranch = 0;
            decimal TotalSaleAmountBranch = 0;
            if (objEmployeesCompany.Count() > 0)
            {
                if (objConfigSalesTargetItemsCompany != null && objConfigSalesTargetItemsCompany.HRConfigSalesTargetItemValue > 0)
                {
                    dependenceTargetCompany = (decimal)objEmployeesCompany.Sum(o => o.TotalSaleAmount) / objConfigSalesTargetItemsCompany.HRConfigSalesTargetItemValue * 100;
                }
            }
            if (objEmployeesBranch.Count() > 0)
            {
                if (objConfigSalesTargetItemsBranch != null && objConfigSalesTargetItemsBranch.HRConfigSalesTargetItemValue > 0)
                {
                    dependenceTargetBranch = (decimal)objEmployeesBranch.Sum(o => o.TotalSaleAmount) / objConfigSalesTargetItemsBranch.HRConfigSalesTargetItemValue * 100;
                    TotalSaleAmountBranch = (decimal)objEmployeesBranch.Sum(o => o.TotalSaleAmount);
                }
            }
            if (precentTarget > 100)
            {
                precentTargetRemind = precentTarget - 100;
                precentTarget = 100;
            }
            if (configSalesFormulaPayrollItems != null)
            {
                configSalesFormulaPayrollItems.ForEach(o =>
                    {
                        if (precentTarget >= o.HRConfigSalesFormulaPayrollItemSalesFrom && precentTarget <= o.HRConfigSalesFormulaPayrollItemSalesTo && o.HRCircumstancesRewardType == CircumstancesRewardType.Sales.ToString())
                        {
                            if (string.IsNullOrEmpty(o.HRConfigSalesFormulaPayrollItemDependenceType))
                            {
                                if (o.HRConfigSalesFormulaPayrollItemRewardAmount <= 0)
                                {
                                    objBonusSaleItemsInfo.HRBonusSaleItemLevelAllowance = o.HRConfigSalesFormulaPayrollItemRewardPercent;
                                }
                                else
                                {
                                    objBonusSaleItemsInfo.HRBonusSaleItemLevelAllowance = 0;
                                    objBonusSaleItemsInfo.HRBonusSaleItemTotalAmount = o.HRConfigSalesFormulaPayrollItemRewardAmount;
                                }
                            }
                            else
                            {
                                if (o.HRConfigSalesFormulaPayrollItemDependenceType == ConfigSalesFormulaPayrollItemDependenceType.Company.ToString())
                                {
                                    if (dependenceTargetCompany >= o.HRConfigSalesFormulaPayrollItemDependenceSalesFrom && dependenceTargetCompany <= o.HRConfigSalesFormulaPayrollItemDependenceSalesTo && o.HRCircumstancesRewardType == CircumstancesRewardType.Sales.ToString())
                                    {
                                        if (o.HRConfigSalesFormulaPayrollItemRewardAmount <= 0)
                                        {
                                            objBonusSaleItemsInfo.HRBonusSaleItemLevelAllowance = o.HRConfigSalesFormulaPayrollItemRewardPercent;
                                        }
                                        else
                                        {
                                            objBonusSaleItemsInfo.HRBonusSaleItemTotalAmount = o.HRConfigSalesFormulaPayrollItemRewardAmount;
                                        }
                                    }
                                }
                                else if (o.HRConfigSalesFormulaPayrollItemDependenceType == ConfigSalesFormulaPayrollItemDependenceType.Branch.ToString())
                                {
                                    if (dependenceTargetBranch >= o.HRConfigSalesFormulaPayrollItemDependenceSalesFrom && dependenceTargetBranch <= o.HRConfigSalesFormulaPayrollItemDependenceSalesTo && o.HRCircumstancesRewardType == CircumstancesRewardType.Sales.ToString())
                                    {
                                        if (o.HRConfigSalesFormulaPayrollItemRewardAmount <= 0)
                                        {
                                            objBonusSaleItemsInfo.HRBonusSaleItemLevelAllowance = o.HRConfigSalesFormulaPayrollItemRewardPercent;
                                        }
                                        else
                                        {
                                            objBonusSaleItemsInfo.HRBonusSaleItemTotalAmount = o.HRConfigSalesFormulaPayrollItemRewardAmount;
                                        }
                                    }
                                }
                            }
                        }
                        if (precentTargetRemind > o.HRConfigSalesFormulaPayrollItemSalesFrom && precentTargetRemind <= o.HRConfigSalesFormulaPayrollItemSalesTo && o.HRCircumstancesRewardType == CircumstancesRewardType.OverTarget.ToString())
                        {
                            if (string.IsNullOrEmpty(o.HRConfigSalesFormulaPayrollItemDependenceType))
                            {
                                if (o.HRConfigSalesFormulaPayrollItemRewardAmount <= 0)
                                {
                                    objBonusSaleItemsInfo.HRBonusSaleItemBonusBeyondTarget = o.HRConfigSalesFormulaPayrollItemRewardPercent * (TotalSaleAmountBranch - objBonusSaleItemsInfo.HRBonusSaleItemTarget) / 100;
                                }
                                else
                                {
                                    if (objBonusSaleItemsInfo.HRBonusSaleItemTarget > 0)
                                    {
                                        objBonusSaleItemsInfo.HRBonusSaleItemBonusBeyondTarget = o.HRConfigSalesFormulaPayrollItemRewardAmount * (TotalSaleAmountBranch - objBonusSaleItemsInfo.HRBonusSaleItemTarget) / objBonusSaleItemsInfo.HRBonusSaleItemTarget * 100;
                                    }
                                }
                            }
                            else
                            {
                                if (o.HRConfigSalesFormulaPayrollItemDependenceType == ConfigSalesFormulaPayrollItemDependenceType.Company.ToString())
                                {
                                    if (dependenceTargetCompany >= o.HRConfigSalesFormulaPayrollItemDependenceSalesFrom && dependenceTargetCompany <= o.HRConfigSalesFormulaPayrollItemDependenceSalesTo && o.HRCircumstancesRewardType == CircumstancesRewardType.OverTarget.ToString())
                                    {
                                        if (o.HRConfigSalesFormulaPayrollItemRewardAmount <= 0)
                                        {
                                            objBonusSaleItemsInfo.HRBonusSaleItemBonusBeyondTarget = o.HRConfigSalesFormulaPayrollItemRewardPercent * (TotalSaleAmountBranch - objBonusSaleItemsInfo.HRBonusSaleItemTarget) / 100;
                                        }
                                        else
                                        {
                                            if (objBonusSaleItemsInfo.HRBonusSaleItemTarget > 0)
                                            {
                                                objBonusSaleItemsInfo.HRBonusSaleItemBonusBeyondTarget = o.HRConfigSalesFormulaPayrollItemRewardAmount * (TotalSaleAmountBranch - objBonusSaleItemsInfo.HRBonusSaleItemTarget) / objBonusSaleItemsInfo.HRBonusSaleItemTarget * 100;
                                            }
                                        }
                                    }
                                }
                                else if (o.HRConfigSalesFormulaPayrollItemDependenceType == ConfigSalesFormulaPayrollItemDependenceType.Branch.ToString())
                                {
                                    if (dependenceTargetBranch >= o.HRConfigSalesFormulaPayrollItemDependenceSalesFrom && dependenceTargetBranch <= o.HRConfigSalesFormulaPayrollItemDependenceSalesTo && o.HRCircumstancesRewardType == CircumstancesRewardType.OverTarget.ToString())
                                    {
                                        if (o.HRConfigSalesFormulaPayrollItemRewardAmount <= 0)
                                        {
                                            objBonusSaleItemsInfo.HRBonusSaleItemBonusBeyondTarget = o.HRConfigSalesFormulaPayrollItemRewardPercent * (TotalSaleAmountBranch - objBonusSaleItemsInfo.HRBonusSaleItemTarget) / 100;
                                        }
                                        else
                                        {
                                            if (objBonusSaleItemsInfo.HRBonusSaleItemTarget > 0)
                                            {
                                                objBonusSaleItemsInfo.HRBonusSaleItemBonusBeyondTarget = o.HRConfigSalesFormulaPayrollItemRewardAmount * (TotalSaleAmountBranch - objBonusSaleItemsInfo.HRBonusSaleItemTarget) / objBonusSaleItemsInfo.HRBonusSaleItemTarget * 100;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (precentTarget == 100)
                        {
                            if (string.IsNullOrEmpty(o.HRConfigSalesFormulaPayrollItemDependenceType))
                            {
                                if (o.HRConfigSalesFormulaPayrollItemRewardAmount <= 0)
                                {
                                    objBonusSaleItemsInfo.HRBonusSaleItemBonusReachTarget = o.HRConfigSalesFormulaPayrollItemRewardPercent * objBonusSaleItemsInfo.HRBonusSaleItemTarget / 100;
                                }
                                else
                                {
                                    objBonusSaleItemsInfo.HRBonusSaleItemBonusReachTarget = o.HRConfigSalesFormulaPayrollItemRewardAmount;
                                }
                            }
                            else
                            {
                                if (o.HRConfigSalesFormulaPayrollItemDependenceType == ConfigSalesFormulaPayrollItemDependenceType.Company.ToString())
                                {
                                    if (dependenceTargetCompany >= o.HRConfigSalesFormulaPayrollItemDependenceSalesFrom && dependenceTargetCompany <= o.HRConfigSalesFormulaPayrollItemDependenceSalesTo && o.HRCircumstancesRewardType == CircumstancesRewardType.SalesTargetOfMonth.ToString())
                                    {
                                        if (o.HRConfigSalesFormulaPayrollItemRewardAmount <= 0)
                                        {
                                            objBonusSaleItemsInfo.HRBonusSaleItemBonusReachTarget = o.HRConfigSalesFormulaPayrollItemRewardPercent * objBonusSaleItemsInfo.HRBonusSaleItemTarget / 100;
                                        }
                                        else
                                        {
                                            objBonusSaleItemsInfo.HRBonusSaleItemBonusReachTarget = o.HRConfigSalesFormulaPayrollItemRewardAmount;
                                        }
                                    }
                                }
                                else if (o.HRConfigSalesFormulaPayrollItemDependenceType == ConfigSalesFormulaPayrollItemDependenceType.Branch.ToString())
                                {
                                    if (dependenceTargetBranch >= o.HRConfigSalesFormulaPayrollItemDependenceSalesFrom && dependenceTargetBranch <= o.HRConfigSalesFormulaPayrollItemDependenceSalesTo && o.HRCircumstancesRewardType == CircumstancesRewardType.SalesTargetOfMonth.ToString())
                                    {
                                        if (o.HRConfigSalesFormulaPayrollItemRewardAmount <= 0)
                                        {
                                            objBonusSaleItemsInfo.HRBonusSaleItemBonusReachTarget = o.HRConfigSalesFormulaPayrollItemRewardPercent * objBonusSaleItemsInfo.HRBonusSaleItemTarget / 100;
                                        }
                                        else
                                        {
                                            objBonusSaleItemsInfo.HRBonusSaleItemBonusReachTarget = o.HRConfigSalesFormulaPayrollItemRewardAmount;
                                        }
                                    }
                                }
                            }
                        }
                    });
            }
            objBonusSaleItemsInfo.HRBonusSaleItemTotalAmount += objBonusSaleItemsInfo.HRBonusSaleItemBonusBeyondTarget + objBonusSaleItemsInfo.HRBonusSaleItemBonusReachTarget;
            return objBonusSaleItemsInfo;
        }
        #endregion

        public HRBonusSaleItemsInfo CalculateBonusSaleReward(HRBonusSaleItemsInfo objBonusSaleItemsInfo, string configSalesFormulaPayrollType)
        {
            if (configSalesFormulaPayrollType == ConfigSalesFormulaPayrollType.Seller.ToString())
            {
                objBonusSaleItemsInfo.HRBonusSaleItemAmountBonusSale = objBonusSaleItemsInfo.HRBonusSaleItemAmount * objBonusSaleItemsInfo.HRBonusSaleItemLevelAllowance / 100;
                objBonusSaleItemsInfo.HRBonusSaleItemAmountBonusSaleTT = objBonusSaleItemsInfo.HRBonusSaleItemAmountBonusSale * (decimal)0.3;
                objBonusSaleItemsInfo.HRBonusSaleItemAmountBonusSaleCN = objBonusSaleItemsInfo.HRBonusSaleItemAmountBonusSale * (decimal)0.7;
                if (objBonusSaleItemsInfo.HRBonusSaleItemPercentageRetained > 0)
                {
                    objBonusSaleItemsInfo.HRBonusSaleItemAllowanceCN = objBonusSaleItemsInfo.HRBonusSaleItemAmountBonusSaleCN * (100 - objBonusSaleItemsInfo.HRBonusSaleItemPercentageRetained) / 100;
                    objBonusSaleItemsInfo.HRBonusSaleItemRetainedAmount = objBonusSaleItemsInfo.HRBonusSaleItemAmountBonusSaleCN * objBonusSaleItemsInfo.HRBonusSaleItemPercentageRetained / 100;
                }
                else
                {
                    objBonusSaleItemsInfo.HRBonusSaleItemAllowanceCN = objBonusSaleItemsInfo.HRBonusSaleItemAmountBonusSaleCN;
                }
            }
            else
            {
                objBonusSaleItemsInfo.HRBonusSaleItemAmountBonusSale = objBonusSaleItemsInfo.HRBonusSaleItemManagementSalesAmount * objBonusSaleItemsInfo.HRBonusSaleItemLevelAllowance / 100;
                if (objBonusSaleItemsInfo.HRBonusSaleItemPercentageRetained > 0)
                {
                    objBonusSaleItemsInfo.HRBonusSaleItemTotalAmount = objBonusSaleItemsInfo.HRBonusSaleItemAmountBonusSale * (100 - objBonusSaleItemsInfo.HRBonusSaleItemPercentageRetained) / 100;
                    objBonusSaleItemsInfo.HRBonusSaleItemRetainedAmount = objBonusSaleItemsInfo.HRBonusSaleItemAmountBonusSale * objBonusSaleItemsInfo.HRBonusSaleItemPercentageRetained / 100;
                }
                else
                {
                    objBonusSaleItemsInfo.HRBonusSaleItemTotalAmount = objBonusSaleItemsInfo.HRBonusSaleItemAmountBonusSale;
                }
            }
            CalculatePayRollTotalAmounts();
            return objBonusSaleItemsInfo;
        }

        public void CalculatePayRollTotalAmounts(HRBonusSaleItemsInfo objBonusSaleItemsInfo)
        {
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
            objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBonusSaleItemsInfo.FK_HREmployeeID);
            bool isManager = false;
            //isManager = objEmployeesController.IsManager(objBonusSaleItemsInfo.FK_HREmployeeID);
            if (!isManager)
            {
                objBonusSaleItemsInfo = CalculateBonusSaleReward(objBonusSaleItemsInfo, ConfigSalesFormulaPayrollType.Seller.ToString());
            }
            else
            {
                objBonusSaleItemsInfo = CalculateBonusSaleReward(objBonusSaleItemsInfo, ConfigSalesFormulaPayrollType.Management.ToString());
            }
            CurrentModuleEntity.UpdateModuleObjectBindingSource(TableName.HRBonusSaleItemsTableName);
        }

        public void CalculatePayRollTotalAmounts()
        {
            BonusSalesEntities entity = (BonusSalesEntities)CurrentModuleEntity;
            HRBonusSalesInfo objBonusSalesInfo = (HRBonusSalesInfo)entity.MainObject;
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
            bool isManager = false;
            decimal totalWorkingQty = 0;
            decimal totalAmountBonusSaleTT = 0;
            entity.EmployeeBonusSaleList.ForEach(o =>
            {
                isManager = false;
                //isManager = objEmployeesController.IsManager(o.FK_HREmployeeID);
                if (!isManager)
                {
                    totalWorkingQty += o.HRBonusSaleItemWorkingQty;
                    totalAmountBonusSaleTT += o.HRBonusSaleItemAmountBonusSaleTT;
                }
                o.HRBonusSaleItemTotalAmount = 0;
            });
            entity.EmployeeBonusSaleList.ForEach(o =>
            {
                isManager = false;
                //isManager = objEmployeesController.IsManager(o.FK_HREmployeeID);
                if (!isManager)
                {
                    if (totalWorkingQty > 0)
                    {
                        o.HRBonusSaleItemAllowanceTT = o.HRBonusSaleItemWorkingQty / totalWorkingQty * totalAmountBonusSaleTT;
                    }
                    o.HRBonusSaleItemTotalAmount = o.HRBonusSaleItemAllowanceCN + o.HRBonusSaleItemAllowanceTT + o.HRBonusSaleItemBonusBeyondTarget + o.HRBonusSaleItemBonusReachTarget;
                }
                else
                {
                    if (o.HRBonusSaleItemPercentageRetained > 0)
                    {
                        o.HRBonusSaleItemTotalAmount = o.HRBonusSaleItemAmountBonusSale * (100 - o.HRBonusSaleItemPercentageRetained) / 100;
                        o.HRBonusSaleItemRetainedAmount = o.HRBonusSaleItemAmountBonusSale * o.HRBonusSaleItemPercentageRetained / 100;
                    }
                    else
                    {
                        o.HRBonusSaleItemTotalAmount = o.HRBonusSaleItemAmountBonusSale;
                    }
                    o.HRBonusSaleItemTotalAmount += o.HRBonusSaleItemBonusBeyondTarget + o.HRBonusSaleItemBonusReachTarget;
                }
            });
            entity.EmployeeBonusSaleList.GridControl.RefreshDataSource();
            //CurrentModuleEntity.UpdateModuleObjectBindingSource(TableName.HRBonusSaleItemsTableName);
        }

        public void RemoveBonusSaleItemsList()
        {
            BonusSalesEntities entity = (BonusSalesEntities)CurrentModuleEntity;
            entity.EmployeeBonusSaleList.RemoveSelectedRowObjectFromList();
            CalculatePayRollTotalAmounts();
        }

        public void RefreshBonusSales()
        {
            if (MessageBox.Show("Bạn có muốn làm mới thưởng doanh số không?", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Toolbar.IsEditAction())
                {
                    CalculateBonusSale();
                }
                else if (Toolbar.IsNullOrNoneAction())
                {
                    base.ActionEdit();
                    CalculateBonusSale();
                }
            }
        }

        public void CalculateBonusSale()
        {
            BonusSalesEntities entity = (BonusSalesEntities)CurrentModuleEntity;
            HRBonusSalesInfo objBonusSalesInfo = (HRBonusSalesInfo)entity.MainObject;

            HRTimeSheetsController objTimeSheetsController = new HRTimeSheetsController();
            HREmployeeTimeSheetsController objEmployeeTimeSheetsController = new HREmployeeTimeSheetsController();
            HRTimeSheetEntrysController objTimeSheetEntrysController = new HRTimeSheetEntrysController();
            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            HRTimesheetConfigsController objTimesheetConfigsController = new HRTimesheetConfigsController();

            List<HRTimeSheetEntrysInfo> employeeTimeSheetEntryList = new List<HRTimeSheetEntrysInfo>();
            HREmployeeTimeSheetsInfo employeeTimeSheet = new HREmployeeTimeSheetsInfo();
            HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();

            List<HRBonusSaleItemsInfo> bonusSaleItemsList = new List<HRBonusSaleItemsInfo>();
            HRBonusSaleItemsInfo objBonusSaleItemsClone = new HRBonusSaleItemsInfo();

            if (entity.EmployeeBonusSaleList.Count() > 0)
            {
                foreach (HRBonusSaleItemsInfo objBonusSaleItems in entity.EmployeeBonusSaleList)
                {
                    objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objBonusSaleItems.FK_HREmployeeID);
                    if (objEmployeesInfo != null)
                    {
                        List<HREmployeeTimeSheetsInfo> employeeTimeSheetList = new List<HREmployeeTimeSheetsInfo>();
                        //List <HREmployeeTimeSheetsInfo> employeeTimeSheetList = (List<HREmployeeTimeSheetsInfo>)objEmployeeTimeSheetsController.GetEmployeeTimeSheetByFromDateAndToDate(objEmployeesInfo.HREmployeeID, objBonusSalesInfo.HRBonusSaleFromDate, objBonusSalesInfo.HRBonusSaleToDate);
                        if (employeeTimeSheetList.Count() > 0)
                        {
                            employeeTimeSheet = (HREmployeeTimeSheetsInfo)employeeTimeSheetList.LastOrDefault();
                        }
                        if (employeeTimeSheet == null)
                            continue;

                        HRTimeSheetsInfo objTimeSheetsInfo = (HRTimeSheetsInfo)objTimeSheetsController.GetObjectByID(employeeTimeSheet.FK_HRTimeSheetID);

                        if (objTimeSheetsInfo == null)
                            continue;

                        if (objEmployeesInfo.FK_HREmployeePayrollFormulaID > 0)
                        {
                            objEmployeesInfo.HREmployeeDaysPerMonth = 0;
                            //objEmployeesInfo.HREmployeeDaysPerMonth = objTimesheetConfigsController.GetDaysPerMonthByEmployeeFormullaID(objEmployeesInfo.FK_HREmployeePayrollFormulaID, objBonusSalesInfo.HRBonusSaleDate.Month, objBonusSalesInfo.HRBonusSaleDate.Year);
                            employeeTimeSheetEntryList = objTimeSheetEntrysController.GetTotalTimeSheetEntryByTimeSheetIDAndEmployeeTimeSheetID(objTimeSheetsInfo.HRTimeSheetID, employeeTimeSheet.HREmployeeTimeSheetID);

                            decimal totalSalaryFactor = 0;
                            decimal totalSalaryOTHours = 0;

                            HRTimeSheetParamsInfo objTimeSheetParamsInfo = new HRTimeSheetParamsInfo();
                            foreach (HRTimeSheetEntrysInfo objTimeSheetEntrysInfo in employeeTimeSheetEntryList)
                            {
                                objTimeSheetParamsInfo = (HRTimeSheetParamsInfo)objTimeSheetParamsController.GetObjectByID(objTimeSheetEntrysInfo.FK_HRTimeSheetParamID);
                                if (objTimeSheetEntrysInfo.IsOT == false)
                                {
                                    if (objTimeSheetParamsInfo.HRTimeSheetParamType != TimeSheetParamType.Common.ToString())
                                    {
                                        totalSalaryFactor += objTimeSheetEntrysInfo.HRTimeSheetEntryWorkingQty;
                                    }
                                }
                                else
                                {
                                    totalSalaryOTHours += objTimeSheetEntrysInfo.HRTimeSheetEntryWorkingHours;
                                }
                            }
                            // Công thực tế
                            objBonusSaleItems.HRBonusSaleItemWorkingQty = totalSalaryFactor;
                            objBonusSaleItemsClone = CalculateBonusSaleRewardTargets(objBonusSaleItems, objEmployeesInfo);
                            bonusSaleItemsList.Add(objBonusSaleItemsClone);
                        }
                    }
                }
                entity.EmployeeBonusSaleList.Clear();
                if (bonusSaleItemsList.Count() > 0)
                {
                    bonusSaleItemsList.ForEach(o =>
                        {
                            entity.EmployeeBonusSaleList.Add(o);
                        });
                }
                CalculatePayRollTotalAmounts();
                entity.EmployeeBonusSaleList.GridControl.RefreshDataSource();
            }
        }
    }
}
