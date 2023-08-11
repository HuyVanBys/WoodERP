using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.LeaveDay
{
    public class LeaveDayModule : BaseModuleERP
    {
        #region Constants
        public const string LeaveDayGridControlName = "fld_dgcLeaveDays";
        public const string BranchLookupEditName = "fld_lkeBRBranchID";
        public const string FromDateControlName = "fld_dteSearchFromDate";
        public const string ToDateControlName = "fld_dteSearchToDate";
        public const string EmployeeStatusLookupEditName = "fld_lkeHREmployeeStatus";
        public List<string> ColumnFieldNameList = new List<string>();
        #endregion
        public BOSDateEdit dteFrom;
        public BOSDateEdit dteTo;
        public List<HRTimeSheetParamsInfo> commomParams;
        public LeaveDayModule()
        {
            Name = ModuleName.LeaveDay;
            CurrentModuleEntity = new LeaveDayEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            BOSLookupEdit lke = (BOSLookupEdit)Controls[LeaveDayModule.BranchLookupEditName];
            lke.EditValue = BOSApp.CurrentCompanyInfo.FK_BRBranchID;

            DateTime dateFrom = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime dateTo = dateFrom.AddMonths(1).AddDays(-1);
            //DateTime dateTo = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));

            dteFrom = (BOSDateEdit)Controls[LeaveDayModule.FromDateControlName];
            dteFrom.DateTime = dateFrom;

            dteTo = (BOSDateEdit)Controls[LeaveDayModule.ToDateControlName];
            dteTo.DateTime = dateTo;

            lke = (BOSLookupEdit)Controls[LeaveDayModule.EmployeeStatusLookupEditName];
            if (lke != null)
            {
                lke.EditValue = EmployeeStatus.Working;
            }

            commomParams = new List<HRTimeSheetParamsInfo>();
        }

        /// <summary>
        /// Update the total leave days of an employee
        /// </summary>
        /// <param name="leaveDay">Object represents leave days of the employee</param>
        public void UpdateTotalLeaveDays(HRLeaveDaysInfo leaveDay)
        {
            HRLeaveDaysController objLeaveDaysController = new HRLeaveDaysController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            //HREmployeesInfo obj = (HREmployeesInfo)objEmployeesController.GetObjectByID(leaveDay.FK_HREmployeeID);
            //double leaveDays = 0;
            //if (obj != null)
            //{   
            //    List<HRLeaveDaysInfo> leaveDayList = new List<HRLeaveDaysInfo>();
            //    leaveDayList = objLeaveDaysController.GetLeaveDayOnYearByHREmployeeID(leaveDay.FK_HREmployeeID);
            //    foreach (HRLeaveDaysInfo item in leaveDayList)
            //    {
            //        HRTimeSheetParamsInfo itemParams = commomParams.Where(p => p.HRTimeSheetParamID == item.FK_HRTimeSheetParamID).FirstOrDefault();
            //        if (itemParams != null)
            //        {
            //            if (itemParams.HRTimeSheetParamType == TimeSheetParamType.PN.ToString())
            //            {
            //                leaveDays = leaveDays + 1;
            //            }
            //            else if (itemParams.HRTimeSheetParamType == TimeSheetParamType.PN1P2.ToString())
            //            {
            //                leaveDays = leaveDays + 0.5;
            //            }
            //        }
            //    }
            //}
            BOSDbUtil dbUtil = new BOSDbUtil();
            LeaveDayEntities entity = (LeaveDayEntities)CurrentModuleEntity;
            leaveDay.TotalLeaveDays = 0;
            decimal phepNam = 0;
            for (int i = 1; i <= 31; i++)
            {
                string[] paramNumbers = dbUtil.GetPropertyStringValue(leaveDay, string.Format("HRLeaveDayDate{0}", i)).Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < paramNumbers.Length; j++)
                {
                    string paramNo = paramNumbers[j].Trim();
                    //string paramNo = dbUtil.GetPropertyStringValue(leaveDay, string.Format("HRLeaveDayDate{0}", i));
                    HRTimeSheetParamsInfo itemParams = commomParams.Where(p => p.HRTimeSheetParamNo == paramNo).FirstOrDefault();
                    if (itemParams != null)
                    {
                        if (itemParams.HRTimeSheetParamType == TimeSheetParamType.PN1P2.ToString()
                            || itemParams.HRTimeSheetParamType == TimeSheetParamType.NCP1P2.ToString()
                            || itemParams.HRTimeSheetParamType == TimeSheetParamType.NKP1P2.ToString()
                            )
                        {
                            leaveDay.TotalLeaveDays = leaveDay.TotalLeaveDays + decimal.Parse("0.5");
                        }
                        else
                        {
                            if (itemParams.HRTimeSheetParamValue1 == 4)
                            {
                                leaveDay.TotalLeaveDays = leaveDay.TotalLeaveDays + decimal.Parse("0.5");
                            }
                            else if (itemParams.HRTimeSheetParamValue1 == 8)
                            {
                                leaveDay.TotalLeaveDays = leaveDay.TotalLeaveDays + 1;
                            }
                        }

                        if (itemParams.HRTimeSheetParamType == TimeSheetParamType.PN1P2.ToString())
                        {
                            phepNam = phepNam + decimal.Parse("0.5");
                        }
                        else if (itemParams.HRTimeSheetParamType == TimeSheetParamType.PN.ToString())
                        {
                            if (itemParams.HRTimeSheetParamValue1 == 4)
                            {
                                phepNam = phepNam + decimal.Parse("0.5");
                            }
                            else if (itemParams.HRTimeSheetParamValue1 == 8)
                            {
                                phepNam = phepNam + 1;
                            }
                        }
                    }
                }
            }
            HREmployeeRewardsController objHRRewardsController = new HREmployeeRewardsController();
            HREmployeeRewardsInfo objEmployeeRewardsInfo = objHRRewardsController.GetSumSPNEmployeesDaTinhLuong(leaveDay.FK_HREmployeeID);
            if (objEmployeeRewardsInfo != null)
            {
                leaveDay.SPNDaTinhLuong = objEmployeeRewardsInfo.HREmployeeRewardSPN;
            }

            leaveDay.HRLeaveDayTotalQtyRemain = CalculatorLeaveDay(leaveDay) - phepNam;
            leaveDay.SPNTinhLuongConLai = leaveDay.HRLeaveDayTotalQtyRemain - leaveDay.SPNDaTinhLuong;
            entity.LeaveDayList.GridControl.RefreshDataSource();
        }

        /// <summary>
        /// Called from the screen, view leave days of employees searched by some criteria
        /// </summary>
        /// <param name="branchID">Branch id</param>
        /// <param name="departmentID">Department id</param>
        /// <param name="departmentRoomID">Department room id</param>
        /// <param name="employeeID">Employee id</param>
        /// <param name="date">Month of leave days</param>
        /// <param name="status">Employee status: working or resigned</param>
        public void ViewLeaveDays(int branchID, int departmentID, int departmentRoomID, int employeeID, DateTime dateFrom, DateTime dateTo, string status, int employeePayrollFormulaID)
        {
            BOSProgressBar.Start("Đang xử lý dữ liệu...");
            BOSDbUtil dbUtil = new BOSDbUtil();
            HRLeaveDaysController objLeaveDaysController = new HRLeaveDaysController();
            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            List<HRLeaveDaysInfo> leaveDays = objLeaveDaysController.GetLeaveDayList(branchID, departmentID, departmentRoomID, employeeID, dateFrom, dateTo, employeePayrollFormulaID);
            commomParams = objTimeSheetParamsController.GetTimeSheetParamsByCommonType();
            LeaveDayEntities entity = (LeaveDayEntities)CurrentModuleEntity;
            entity.LeaveDayList.Clear();
            entity.LeaveDayListBackup.Clear();
            HREmployeesController objEmployeesController = new HREmployeesController();
            List<HREmployeesInfo> employees = new List<HREmployeesInfo>();
            if (employeeID == 0)
            {
                //employees = objEmployeesController.GetEmployeeList(branchID, departmentID, departmentRoomID, status);
                employees = objEmployeesController.GetEmployeeListByModuleLeaveDay(branchID, departmentID, departmentRoomID, employeePayrollFormulaID, status);
            }
            else
            {
                HREmployeesInfo employee = (HREmployeesInfo)objEmployeesController.GetObjectByID(employeeID);
                employees.Add(employee);
            }

            int numDays = (int)(dteTo.DateTime.Date - dteFrom.DateTime.Date).TotalDays + 1;
            foreach (HRLeaveDaysInfo leaveDay in leaveDays)
            {
                if (!employees.Exists(p => p.HREmployeeID == leaveDay.FK_HREmployeeID)) continue;
                HRLeaveDaysInfo employeeLeaveDay = entity.LeaveDayList.Where(ld => ld.FK_HREmployeeID == leaveDay.FK_HREmployeeID).FirstOrDefault();
                if (employeeLeaveDay == null)
                {
                    employeeLeaveDay = new HRLeaveDaysInfo();
                    entity.LeaveDayList.Add(employeeLeaveDay);
                }
                if (employeeLeaveDay != null)
                {
                    employeeLeaveDay.FK_HREmployeeID = leaveDay.FK_HREmployeeID;
                    employeeLeaveDay.HREmployeeNo = leaveDay.HREmployeeNo;
                    employeeLeaveDay.HREmployeeName = leaveDay.HREmployeeName;
                    employeeLeaveDay.HRLeaveDayDate = dateFrom;
                    employeeLeaveDay.HREmployeeCardNumber = leaveDay.HREmployeeCardNumber;
                    HRTimeSheetParamsInfo param = commomParams.Where(p => p.HRTimeSheetParamID == leaveDay.FK_HRTimeSheetParamID).FirstOrDefault();
                    for (int i = 1; i <= numDays; i++)
                    {
                        if (param != null)
                        {
                            //dbUtil.SetPropertyValue(employeeLeaveDay, string.Format("HRLeaveDayDate{0}", leaveDay.HRLeaveDayDate.Date.Day), param.HRTimeSheetParamNo);
                            if (dteFrom.DateTime.Date.AddDays(i - 1) == leaveDay.HRLeaveDayDate.Date)
                            {
                                string paramTemp = dbUtil.GetPropertyStringValue(employeeLeaveDay, string.Format("HRLeaveDayDate{0}", leaveDay.HRLeaveDayDate.Date.Day));
                                if (string.IsNullOrEmpty(paramTemp))
                                {
                                    dbUtil.SetPropertyValue(employeeLeaveDay, string.Format("HRLeaveDayDate{0}", i), param.HRTimeSheetParamNo);
                                }
                                else
                                {
                                    dbUtil.SetPropertyValue(employeeLeaveDay, string.Format("HRLeaveDayDate{0}", i), paramTemp + ", " + param.HRTimeSheetParamNo);
                                }
                            }
                        }
                    }
                }
            }

            foreach (HREmployeesInfo employee in employees)
            {
                if (!entity.LeaveDayList.Exists(ld => ld.FK_HREmployeeID == employee.HREmployeeID))
                {
                    HRLeaveDaysInfo leaveDay = new HRLeaveDaysInfo();
                    leaveDay.FK_HREmployeeID = employee.HREmployeeID;
                    leaveDay.HREmployeeNo = employee.HREmployeeNo;
                    leaveDay.HREmployeeName = employee.HREmployeeName;
                    leaveDay.HRLeaveDayDate = dateFrom;
                    leaveDay.HREmployeeCardNumber = employee.HREmployeeCardNumber;
                    entity.LeaveDayList.Add(leaveDay);
                }
            }

            foreach (HRLeaveDaysInfo leaveDay in entity.LeaveDayList)
            {
                entity.LeaveDayListBackup.Add((HRLeaveDaysInfo)leaveDay.Clone());
                UpdateTotalLeaveDays(leaveDay);
                leaveDay.BackupObject = (HRLeaveDaysInfo)leaveDay.Clone();
            }

            LeaveDayGridControl gridControl = entity.LeaveDayList.GridControl as LeaveDayGridControl;
            gridControl.ViewDate = dateFrom;
            gridControl.FromDate = dateFrom;
            gridControl.ToDate = dateTo;
            //gridControl.InitializeControl();

            foreach (var item in entity.LeaveDayList)
            {
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(item.FK_HREmployeeID);
                if (objEmployeesInfo != null)
                    item.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
            }
            ColumnFieldNameList = GetColumnFieldNameByTypeEndOfWeek();
            gridControl.RefreshDataSource();
            BOSProgressBar.Close();
        }

        /// <summary>
        ///  Initialize grid control
        /// </summary>
        public void InitializeLeaveDayFromGridControl()
        {
            LeaveDayEntities entity = (LeaveDayEntities)CurrentModuleEntity;
            HRTimeSheetsInfo objTimeSheetsInfo = (HRTimeSheetsInfo)entity.MainObject;
            LeaveDayGridControl gridControl = (LeaveDayGridControl)Controls["fld_dgcLeaveDays"];
            gridControl.FromDate = dteFrom.DateTime;
            if (dteFrom.DateTime > dteTo.DateTime)
            {
                dteTo.DateTime = dteFrom.DateTime;
            }
            else if ((dteTo.DateTime - dteFrom.DateTime).TotalDays > 31)
            {
                dteTo.DateTime = dteFrom.DateTime.AddDays(30);
            }
            gridControl.ToDate = dteTo.DateTime;
            gridControl.InitializeControl();
        }

        public void InitializeLeaveDayToGridControl()
        {
            LeaveDayEntities entity = (LeaveDayEntities)CurrentModuleEntity;
            HRTimeSheetsInfo objTimeSheetsInfo = (HRTimeSheetsInfo)entity.MainObject;
            LeaveDayGridControl gridControl = (LeaveDayGridControl)Controls["fld_dgcLeaveDays"];
            gridControl.ToDate = dteTo.DateTime;
            if (dteFrom.DateTime > dteTo.DateTime)
            {
                dteFrom.DateTime = dteTo.DateTime;
            }
            else if ((dteTo.DateTime - dteFrom.DateTime).TotalDays > 31)
            {
                dteFrom.DateTime = dteTo.DateTime.AddDays(-30);
            }
            gridControl.FromDate = dteFrom.DateTime;
            gridControl.InitializeControl();
        }

        public void UpdateGridDateAlias()
        {
            LeaveDayEntities entity = (LeaveDayEntities)CurrentModuleEntity;
            LeaveDayGridControl gridControl = entity.LeaveDayList.GridControl as LeaveDayGridControl;
            if (gridControl != null)
                gridControl.UpdateDateAlias();
        }

        /// <summary>
        /// Save leave days of employees
        /// </summary>
        public void SaveLeaveDays()
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            LeaveDayEntities entity = (LeaveDayEntities)CurrentModuleEntity;
            HRTimeSheetParamsController objTimeSheetParamsController = new HRTimeSheetParamsController();
            commomParams = objTimeSheetParamsController.GetTimeSheetParamsByCommonType();
            HRLeaveDaysController objLeaveDaysController = new HRLeaveDaysController();

            ADUsersInfo objUsersInfo = BOSApp.CurrentUsersInfo;

            foreach (HRLeaveDaysInfo employeeLeaveDay in entity.LeaveDayList)
            {
                //objLeaveDaysController.DeleteByEmployeeIDAndDate(employeeLeaveDay.FK_HREmployeeID, employeeLeaveDay.HRLeaveDayDate);
                for (int i = 1; i <= 31; i++)
                {
                    string[] paramNumbers = dbUtil.GetPropertyStringValue(employeeLeaveDay, string.Format("HRLeaveDayDate{0}", i)).Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    HRLeaveDaysInfo leaveDayBackup = (HRLeaveDaysInfo)entity.LeaveDayListBackup.LastOrDefault(o => o.FK_HREmployeeID == employeeLeaveDay.FK_HREmployeeID);
                    bool check = true;
                    if (leaveDayBackup != null)
                    {
                        string paramString = dbUtil.GetPropertyStringValue(employeeLeaveDay, string.Format("HRLeaveDayDate{0}", i));
                        string paramStringBackup = dbUtil.GetPropertyStringValue(leaveDayBackup, string.Format("HRLeaveDayDate{0}", i));
                        if (paramString == paramStringBackup)
                        {
                            check = false;
                        }
                    }
                    if (check)
                    {
                        if (dteFrom.DateTime.Date.AddDays(i - 1) <= dteTo.DateTime.Date)
                        {
                            objLeaveDaysController.DeleteByEmployeeIDAndDate(employeeLeaveDay.FK_HREmployeeID, dteFrom.DateTime.Date.AddDays(i - 1), objUsersInfo != null ? objUsersInfo.ADUserName : null);
                        }
                        for (int j = 0; j < paramNumbers.Length; j++)
                        {
                            string paramNo = paramNumbers[j].Trim();
                            //string paramNo = dbUtil.GetPropertyStringValue(employeeLeaveDay, string.Format("HRLeaveDayDate{0}", i));
                            if (!string.IsNullOrEmpty(paramNo))
                            {
                                HRTimeSheetParamsInfo param = commomParams.Where(p => p.HRTimeSheetParamNo == paramNo).FirstOrDefault();
                                if (param != null)
                                {
                                    HRLeaveDaysInfo leaveDay = new HRLeaveDaysInfo();
                                    leaveDay.FK_HREmployeeID = employeeLeaveDay.FK_HREmployeeID;
                                    leaveDay.FK_HRTimeSheetParamID = param.HRTimeSheetParamID;
                                    //leaveDay.HRLeaveDayDate = new DateTime(employeeLeaveDay.HRLeaveDayDate.Year, employeeLeaveDay.HRLeaveDayDate.Month, i);
                                    leaveDay.HRLeaveDayDate = dteFrom.DateTime.Date.AddDays(i - 1);
                                    //objLeaveDaysController.DeleteByEmployeeIDAndDate(employeeLeaveDay.FK_HREmployeeID, leaveDay.HRLeaveDayDate);
                                    if (objUsersInfo != null)
                                    {
                                        leaveDay.AACreatedUser = objUsersInfo.ADUserName;
                                    }
                                    objLeaveDaysController.CreateObject(leaveDay);
                                }
                            }
                            //else
                            //{
                            //    objLeaveDaysController.DeleteByEmployeeIDAndDate(employeeLeaveDay.FK_HREmployeeID, dteFrom.DateTime.Date.AddDays(i - 1));
                            //}
                        }
                    }
                }
            }

            MessageBox.Show(LeaveDayLocalizedResources.SaveSuccessfullyMessage,
                            CommonLocalizedResources.MessageBoxDefaultCaption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        public void ExportExcel()
        {
            LeaveDayEntities entity = (LeaveDayEntities)CurrentModuleEntity;
            LeaveDayGridControl gridControl = entity.LeaveDayList.GridControl as LeaveDayGridControl;
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.InitialDirectory = @"C:\";

                saveFileDialog1.Title = "Save Files";

                saveFileDialog1.DefaultExt = "xlsx";

                saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|(*.xlsx)|*.xlsx|All files (*.*)|*.*";

                saveFileDialog1.FilterIndex = 2;

                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    string fileName = saveFileDialog1.FileName;

                    gridControl.ExportToXlsx(fileName);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The process cannot access the file") && ex.Message.Contains("because it is being used by another process."))
                    MessageBox.Show(ReportLocalizedResources.CannotExportToExcelFileBecauseTheFileIsBeingUsedByAnotherProcessMessage,
                                    CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(ReportLocalizedResources.ExportExelFileUnsuccessfullyMessage,
                                    CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public List<string> GetColumnFieldNameByTypeEndOfWeek()
        {
            LeaveDayEntities entity = (LeaveDayEntities)CurrentModuleEntity;
            HRLeaveDaysInfo objLeaveDaysInfo = (HRLeaveDaysInfo)entity.MainObject;
            List<string> list = new List<string>();
            foreach (HRLeaveDaysInfo employeeLeaveDay in entity.LeaveDayList)
            {
                for (int i = 1; i <= 31; i++)
                {
                    DateTime dt = employeeLeaveDay.HRLeaveDayDate.Date.AddDays(i - 1);
                    bool isDayOfWeek = (BOSApp.IsEndOfWeek(employeeLeaveDay.HRLeaveDayDate.Date.AddDays(i - 1).DayOfWeek));
                    if (isDayOfWeek)
                    {
                        string columnName = String.Format("{0}{1}", "HRLeaveDayDate", i.ToString());
                        if (!list.Exists(o => o == columnName))
                        {
                            list.Add(columnName);
                        }
                    }
                }
            }
            return list;
        }

        public decimal CalculatorLeaveDay(HRLeaveDaysInfo leaveDay)
        {
            LeaveDayEntities entity = (LeaveDayEntities)CurrentModuleEntity;
            HRLeaveDaysInfo objLeaveDaysInfo = (HRLeaveDaysInfo)entity.MainObject;
            HREmployeeLRegsController objEmployeeLRegsController = new HREmployeeLRegsController();
            HREmployeeLRegsInfo objEmployeeLRegsInfo = new HREmployeeLRegsInfo();
            objEmployeeLRegsInfo = (HREmployeeLRegsInfo)objEmployeeLRegsController.GetEmployeeLRegByEmployeeIDAndYear(leaveDay.FK_HREmployeeID, dteTo.DateTime.AddYears(-1).Year);

            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(leaveDay.FK_HREmployeeID);

            DateTime dtFirstOfYear = new DateTime(dteTo.DateTime.Year, 1, 1);
            //DateTime dtEndOfYear = new DateTime(dteTo.DateTime.Year, 12, 31).AddYears(-1);
            DateTime dtEndDate = BOSApp.GetCurrentServerDate();
            if (objEmployeesInfo.HREmployeeStatusCombo == EmployeeStatus.ThoiViec.ToString() && objEmployeesInfo.HREmployeeEndWorkingDate != null && objEmployeesInfo.HREmployeeEndWorkingDate != DateTime.MaxValue)
            {
                dtEndDate = objEmployeesInfo.HREmployeeEndWorkingDate;
            }
            decimal result = 0;
            decimal departmentRoomLeaveDay = 0;
            decimal otherLeaveDay = 0;
            decimal expDay = 0;
            decimal dbSothanglamviec = 0, dbDftDay = 0;

            if (objEmployeeLRegsInfo != null)
            {
                result += objEmployeeLRegsInfo.HREmployeeLRegRemainDays;
            }

            //phép cộng theo khu vực khác
            DataSet dsAnnualLeaveOther = new HRDepartmentRoomLeaveDayConfigsController().GetAllDataByForeignColumn("FK_HRDepartmentRoomID", objEmployeesInfo.FK_HRDepartmentRoomID);
            if (dsAnnualLeaveOther != null && dsAnnualLeaveOther.Tables.Count > 0 && dsAnnualLeaveOther.Tables[0].Rows.Count > 0)
            {
                List<HRDepartmentRoomLeaveDayConfigsInfo> lstAnnualLeaveOther = (List<HRDepartmentRoomLeaveDayConfigsInfo>)new HRDepartmentRoomLeaveDayConfigsController().GetListFromDataSet(dsAnnualLeaveOther);

                lstAnnualLeaveOther.ForEach(o =>
                {
                    if (o.FK_HRDepartmentRoomID > 0 && o.FK_HRDepartmentRoomID == objEmployeesInfo.FK_HRDepartmentRoomID)
                    {
                        departmentRoomLeaveDay = o.HRDepartmentRoomLeaveDayConfigQty; //dòng nào thỏa điều kiện cuối cùng nhất sẽ lấy
                    }
                });
            }

            //phép cộng năm khác
            HROtherLeaveDayConfigsController objOtherLeaveDayConfigsController = new HROtherLeaveDayConfigsController();
            List<HROtherLeaveDayConfigsInfo> lstOtherLeaveDayConfigs = (List<HROtherLeaveDayConfigsInfo>)objOtherLeaveDayConfigsController.GetListFromDataSet(objOtherLeaveDayConfigsController.GetAllObjects());
            lstOtherLeaveDayConfigs.Where(o => o.FK_HREmployeeID == objEmployeesInfo.HREmployeeID && o.FK_HRDepartmentID == objEmployeesInfo.FK_HRDepartmentID && o.FK_HRLevelID == objEmployeesInfo.FK_HRLevelID && o.HROtherLeaveDayConfigQty > 0).ToList().ForEach(x =>
            {
                otherLeaveDay = x.HROtherLeaveDayConfigQty;
            });

            //Tính phép thâm niên
            if (objEmployeesInfo.HREmployeeStartWorkingDate != null)
            {
                dbSothanglamviec = GetMonth(dtEndDate.Date, objEmployeesInfo.HREmployeeStartWorkingDate);
                decimal dbExpYear = dbSothanglamviec / 12;
                if (dbExpYear > 0)
                {
                    DataSet ds = new HRSeniorityLeaveDayConfigsController().GetAllObjects();
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        List<HRSeniorityLeaveDayConfigsInfo> lst = (List<HRSeniorityLeaveDayConfigsInfo>)new HRSeniorityLeaveDayConfigsController().GetListFromDataSet(ds);
                        foreach (HRSeniorityLeaveDayConfigsInfo item in lst)
                        {
                            if ((dbExpYear >= item.HRSeniorityLeaveDayConfigFrom) && (dbExpYear <= item.HRSeniorityLeaveDayConfigTo || item.HRSeniorityLeaveDayConfigTo == 0))
                            {
                                expDay = item.HRSeniorityLeaveDayConfigQty;
                                break;
                            }
                        }
                    }
                }
            }

            //Tính lại tổng ngày phép được hưởng trong năm
            if (objEmployeesInfo.HREmployeeStartWorkingDate != DateTime.MaxValue)
            {
                //năm vào làm = năm tính phép
                if (objEmployeesInfo.HREmployeeStartWorkingDate.Year == dteTo.DateTime.Year)
                {
                    dbDftDay = SoThangLamviec(dteTo.DateTime, objEmployeesInfo.HREmployeeStartWorkingDate);
                }
                else if (objEmployeesInfo.HREmployeeStartWorkingDate.Year < dteTo.DateTime.Year)
                {
                    dbDftDay = SoThangLamviec(dteTo.DateTime, new DateTime(dteTo.DateTime.Year, 1, 1));
                }
            }

            //Số ngày nghỉ trong năm
            HRLeaveDaysController objLeaveDaysController = new HRLeaveDaysController();
            decimal ngayNghi = (decimal)objLeaveDaysController.GetSumPNLeavedays(leaveDay.FK_HREmployeeID, dteFrom.DateTime, dteTo.DateTime);
            result += departmentRoomLeaveDay + dbDftDay + expDay + otherLeaveDay - ngayNghi;

            return result;
        }

        public int SoThangLamviec(DateTime dtEnd, DateTime dtStart)
        {
            int iSoThang = (dtEnd.Year * 12 + dtEnd.Month) - (dtStart.Year * 12 + dtStart.Month);
            if (dtStart.Day < 16)
                iSoThang = iSoThang + 1;
            if (iSoThang < 0) iSoThang = 0;
            return iSoThang;
        }

        public decimal GetMonth(DateTime dtEnd, DateTime dtStart)
        {
            decimal months = (dtEnd.Month - dtStart.Month) + 12 * (dtEnd.Year - dtStart.Year);
            if (dtEnd.Day < dtStart.Day)
            {
                months--;
            }
            return months;
        }
    }
}
