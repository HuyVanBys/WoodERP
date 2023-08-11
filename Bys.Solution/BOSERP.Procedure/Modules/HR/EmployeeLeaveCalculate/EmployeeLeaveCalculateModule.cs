using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.EmployeeLeaveCalculate
{
    public class EmployeeLeaveCalculateModule : BaseModuleERP
    {
        #region Constants
        public const string EmployeeLeaveCalculateGridControlName = "fld_dgcHREmployeeLRegs";
        //public const string BranchLookupEditName = "fld_lkeBRBranchID";
        public const string DateControlName = "fld_dteYearDate";
        //public const string ToDateControlName = "fld_dteSearchToDate";
        //public const string EmployeeStatusLookupEditName = "fld_lkeHREmployeeStatus";
        #endregion
        public BOSDateEdit dteDate;
        public EmployeeLeaveCalculateModule()
        {
            Name = ModuleName.EmployeeLeaveCalculate;
            CurrentModuleEntity = new EmployeeLeaveCalculateEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            DateTime dateYear = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            dteDate = (BOSDateEdit)Controls[EmployeeLeaveCalculateModule.DateControlName];
            dteDate.DateTime = dateYear;
            UpdateLastTimeCalculate();
        }

        public void SearchEmployeeLReg()
        {
            EmployeeLeaveCalculateEntities entity = (EmployeeLeaveCalculateEntities)CurrentModuleEntity;
            int iYear;
            dteDate = (BOSDateEdit)Controls[EmployeeLeaveCalculateModule.DateControlName];
            if (dteDate == null) return;
            iYear = (int)dteDate.DateTime.Year;
            if (iYear == 0)
            {
                MessageBox.Show("Chọn năm cần xem!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataSet ds = new HREmployeeLRegsController().GetEmployeeLRegByYear(iYear);
            entity.EmployeeLRegList.Invalidate(ds);
            entity.EmployeeLRegList.GridControl.RefreshDataSource();
            if (entity.EmployeeLRegList.Count == 0)
                MessageBox.Show("Năm " + iYear + " chưa chốt phép!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void RemoveEmployeeLRegs_Click()
        {
            EmployeeLeaveCalculateEntities entity = (EmployeeLeaveCalculateEntities)CurrentModuleEntity;
            int iYear;
            dteDate = (BOSDateEdit)Controls[EmployeeLeaveCalculateModule.DateControlName];
            if (dteDate == null) return;
            iYear = (int)dteDate.DateTime.Year;
            if (iYear == 0)
            {
                MessageBox.Show("Chọn năm cần xem!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dal = MessageBox.Show("Bạn có chắc chắc xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dal == DialogResult.Yes)
            {
                DataSet ds = new HREmployeeLRegsController().GetEmployeeLRegByYear(iYear + 1);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Đã có dữ liệu chốt phép " + (iYear + 1).ToString() + " không thể xóa chốt phép", "Thông báo");
                    return;
                }
                new HREmployeeLRegsController().DeleteAllEmployeeLRegByYear(iYear);
                entity.EmployeeLRegList.Clear();
                entity.EmployeeLRegList.GridControl.RefreshDataSource();
                UpdateLastTimeCalculate();
            }
        }

        public void CalculateEmployeeLeave_Click()
        {
            EmployeeLeaveCalculateEntities entity = (EmployeeLeaveCalculateEntities)CurrentModuleEntity;
            dteDate = (BOSDateEdit)Controls[EmployeeLeaveCalculateModule.DateControlName];
            if (dteDate == null) return;
            int iYear, iDftDays = 0, iEmployeeLeaveConfigID = 0, iExpDayTMonth = 0;
            bool isPreDays = false, isExpDays = false;
            iYear = (int)dteDate.DateTime.Year;
            HREmployeesController objEmployeesCtrl = new HREmployeesController();
            HREmployeeLRegsController objHREmployeeLRegCtrl = new HREmployeeLRegsController();
            DataSet ds = objHREmployeeLRegCtrl.GetEmployeeLRegByYear(iYear);
            if (ds.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show("Đã chốt phép năm " + iYear + ", nhấn nút xem để xem kết quả", "Thông báo");
                return;
            }
            BOSProgressBar.Start("Xử lý chốt phép");
            DataSet dsEmployeeList = objEmployeesCtrl.GetAllObjects();
            List<HREmployeesInfo> EmployeeList = new List<HREmployeesInfo>();
            EmployeeList = (List<HREmployeesInfo>)objEmployeesCtrl.GetListFromDataSet(dsEmployeeList);
            entity.EmployeeLRegList.Clear();
            //lấy cấu hình phép
            DataSet dsEmpLeaveCfs = new HRAnnualLeaveDayConfigsController().GetAllObjects();
            List<HRAnnualLeaveDayConfigsInfo> lstCfs = (List<HRAnnualLeaveDayConfigsInfo>)new HRAnnualLeaveDayConfigsController().GetListFromDataSet(dsEmpLeaveCfs);
            for (int i = lstCfs.Count - 1; i >= 0; i--)
            {
                HRAnnualLeaveDayConfigsInfo item = (HRAnnualLeaveDayConfigsInfo)lstCfs[i];
                if ((int)item.HRAnnualLeaveDayConfigDate.Year <= iYear)
                {
                    iDftDays = (int)item.HRAnnualLeaveDayConfigQty; //Số ngày phép năm tiêu chuẩn
                    isPreDays = item.HRAnnualLeaveDayConfigAdditionalLastYear; //Có cộng dồn phép năm trước
                    isExpDays = item.HRAnnualLeaveDayConfigAdditionalSeniority; //Có cộng dồn phép thâm niên
                    iEmployeeLeaveConfigID = item.HRAnnualLeaveDayConfigID;
                    iExpDayTMonth = (int)item.HRAnnualLeaveDayConfigExpiryDate; // Phép tồn được dùng đến tháng
                    break;
                }
            }
            //
            List<HREmployeeLRegsInfo> lstHREmployeeLRegs = new List<HREmployeeLRegsInfo>();
            foreach (HREmployeesInfo objEmployee in EmployeeList)
            {
                if (CheckEmployeeWorkingInYear(objEmployee, iYear)) //kiểm tra nhân viên có làm việc ở năm đang tính 
                {
                    HREmployeeLRegsInfo HREmployeeLRegInfo = new HREmployeeLRegsInfo();
                    HREmployeeLRegInfo.FK_HREmployeeID = objEmployee.HREmployeeID;
                    HREmployeeLRegInfo.HREmployeeLRegYear = iYear;
                    HREmployeeLRegInfo.HREmployeeLRegDateCal = BOSApp.GetCurrentServerDate();
                    ProcessCalculateEmployeeLeave(objEmployee, HREmployeeLRegInfo, iYear, iDftDays, isPreDays, isExpDays, iEmployeeLeaveConfigID, iExpDayTMonth);
                    //objHREmployeeLRegCtrl.CreateObject(HREmployeeLRegInfo);
                    entity.EmployeeLRegList.Add(HREmployeeLRegInfo);
                }
            }
            entity.EmployeeLRegList.ForEach(o =>
            {
                o.HREmployeeName = EmployeeList.Where(x => x.HREmployeeID == o.FK_HREmployeeID).ToList().FirstOrDefault().HREmployeeName;
                o.HREmployeeStartWorkingDate = EmployeeList.Where(x => x.HREmployeeID == o.FK_HREmployeeID).ToList().FirstOrDefault().HREmployeeStartWorkingDate;
            });
            entity.EmployeeLRegList.GridControl.RefreshDataSource();
            UpdateLastTimeCalculate();
            BOSProgressBar.Close();
        }

        public Boolean CheckEmployeeWorkingInYear(HREmployeesInfo objEmployeesInfo, int iyear)
        {
            if ((objEmployeesInfo.HREmployeeStartWorkingDate.Year <= iyear && objEmployeesInfo.HREmployeeStopWorkingDate == DateTime.MaxValue) ||
                (objEmployeesInfo.HREmployeeStartWorkingDate.Year <= iyear && objEmployeesInfo.HREmployeeStopWorkingDate.Year >= iyear))
                return true;
            return false;
        }

        public void ProcessCalculateEmployeeLeave(HREmployeesInfo objHREmployeeInfo, HREmployeeLRegsInfo objHREmployeeLRegInfo, int iYear, int iDftDays, bool isPreDays, bool isExpDays, int iEmployeeLeaveConfigID, int iExpDayTMonth)
        {

            DateTime dt = new DateTime(iYear, 12, 31);
            DateTime dttemp = new DateTime(dt.AddYears(-1).Year, 12, 31);
            decimal dbExpYear = 0;
            decimal dbRemainDaysOldYear = 0, dbNoxiouDay = 0;
            HREmployeeLRegsController objHREmployeeLRegCtrl = new HREmployeeLRegsController();
            //Lấy Phép tiêu chuẩn của năm
            objHREmployeeLRegInfo.HREmployeeLRegDftDays = iDftDays;
            //lấy phép tồn năm trước
            HREmployeeLRegsInfo objHREmployeeLRegOldYear = (HREmployeeLRegsInfo)objHREmployeeLRegCtrl.GetEmployeeLRegByEmployeeIDAndYear(objHREmployeeLRegInfo.FK_HREmployeeID, iYear - 1);

            if (objHREmployeeLRegOldYear != null)
            {
                dbRemainDaysOldYear = objHREmployeeLRegOldYear.HREmployeeLRegRemainDays;
            }

            //Tính phép cho năm đã chọn

            if (isPreDays == true)  //nếu có lấy phép tồn năm trước
            {
                objHREmployeeLRegInfo.HREmployeeLRegPreviousDays = dbRemainDaysOldYear; //Phép tồn năm trước
                objHREmployeeLRegInfo.HREmployeeLRegPreviousDayUsed = dbRemainDaysOldYear; //Phép tồn năm trước đã dùng
            }
            else
            {
                objHREmployeeLRegInfo.HREmployeeLRegPreviousDays = 0;
            }

            //phép cộng theo khu vực khác
            DataSet dsAnnualLeaveOther = new HRDepartmentRoomLeaveDayConfigsController().GetAllDataByForeignColumn("FK_HRDepartmentRoomID", objHREmployeeInfo.FK_HRDepartmentRoomID);
            if (dsAnnualLeaveOther != null && dsAnnualLeaveOther.Tables.Count > 0 && dsAnnualLeaveOther.Tables[0].Rows.Count > 0)
            {
                List<HRDepartmentRoomLeaveDayConfigsInfo> lstAnnualLeaveOther = (List<HRDepartmentRoomLeaveDayConfigsInfo>)new HRDepartmentRoomLeaveDayConfigsController().GetListFromDataSet(dsAnnualLeaveOther);
                foreach (HRDepartmentRoomLeaveDayConfigsInfo objItem in lstAnnualLeaveOther)
                {
                    if (objItem.FK_HRDepartmentRoomID > 0)
                        if (objHREmployeeInfo.FK_HRDepartmentRoomID != objItem.FK_HRDepartmentRoomID) continue;

                    objHREmployeeLRegInfo.HREmployeeLRegAnnualLeaveOtherDays = objItem.HRDepartmentRoomLeaveDayConfigQty; //dòng nào thỏa điều kiện cuối cùng nhất sẽ lấy
                }
            }

            //phép cộng năm khác
            HROtherLeaveDayConfigsController objOtherLeaveDayConfigsController = new HROtherLeaveDayConfigsController();
            List<HROtherLeaveDayConfigsInfo> lstOtherLeaveDayConfigs = (List<HROtherLeaveDayConfigsInfo>)objOtherLeaveDayConfigsController.GetListFromDataSet(objOtherLeaveDayConfigsController.GetAllObjects());
            lstOtherLeaveDayConfigs.Where(o => o.FK_HREmployeeID == objHREmployeeInfo.HREmployeeID && o.FK_HRDepartmentID == objHREmployeeInfo.FK_HRDepartmentID && o.FK_HRLevelID == objHREmployeeInfo.FK_HRLevelID && o.HROtherLeaveDayConfigQty > 0).ToList().ForEach(x =>
            {
                objHREmployeeLRegInfo.HREmployeeLRegNoxiouDays = x.HROtherLeaveDayConfigQty;
            });

            //tính lại số ngày nghỉ và cập nhật số ngày phép còn lại
            CalculatorLeaveDays(objHREmployeeLRegInfo, objHREmployeeInfo, iYear, iExpDayTMonth, isExpDays, iEmployeeLeaveConfigID);
        }

        public int SoThangLamviec(DateTime dtEnd, DateTime dtStart)
        {
            int iSoThang = 1 + (dtEnd.Year * 12 + dtEnd.Month) - (dtStart.Year * 12 + dtStart.Month);
            //if (dtStart.Day < 16)
            //    iSoThang = iSoThang + 1;
            if (iSoThang < 0) iSoThang = 0;
            return iSoThang;
        }

        public decimal SoThangLamviecDenLucNghi(DateTime dtEnd, DateTime dtStart)
        {
            decimal dbSoThang = 1 + (dtEnd.Year * 12 + dtEnd.Month) - (dtStart.Year * 12 + dtStart.Month);
            //if (dtEnd.Day > 15)
            //    dbSoThang = dbSoThang + 1;
            if (dbSoThang < 0) dbSoThang = 0;
            return dbSoThang;
        }

        private void CalculatorLeaveDays(HREmployeeLRegsInfo objHREmployeeLRegsInfo, HREmployeesInfo objHREmployeeInfo, int iyear, int iExpDayTMonth, bool isExpDays, int iEmployeeLeaveConfigID)
        {
            decimal dbnumber = 0, dbDftDay = 0, dbSoNgayConLai = 0, dbExpYear = 0, dbSothanglamviec = 0;
            DateTime dtFirstOfYear = new DateTime(iyear, 1, 1);
            DateTime dtEndOfYear = new DateTime(iyear, 12, 31);
            //Tính lại tổng ngày phép được hưởng trong năm
            if (objHREmployeeInfo.HREmployeeStartWorkingDate != DateTime.MaxValue)
            {
                dbSothanglamviec = SoThangLamviec(dtEndOfYear, objHREmployeeInfo.HREmployeeStartWorkingDate);
                dbDftDay = objHREmployeeLRegsInfo.HREmployeeLRegDftDays;
                if (objHREmployeeInfo.HREmployeeStartWorkingDate.Year < iyear)
                {
                    //Nhân viên nghỉ việc
                    if (objHREmployeeInfo.HREmployeeStopWorkingDate != DateTime.MaxValue)
                    {
                        if (objHREmployeeInfo.HREmployeeStopWorkingDate.Year == iyear)
                        {
                            dbSothanglamviec = SoThangLamviecDenLucNghi(objHREmployeeInfo.HREmployeeStopWorkingDate, objHREmployeeInfo.HREmployeeStartWorkingDate);
                            dbDftDay = SoThangLamviecDenLucNghi(objHREmployeeInfo.HREmployeeStopWorkingDate, dtFirstOfYear);
                            dbDftDay = Math.Round(dbDftDay, 2);
                        }
                    }
                }
                else //năm vào làm=năm tính phép
                {
                    dbDftDay = SoThangLamviec(dtEndOfYear, objHREmployeeInfo.HREmployeeStartWorkingDate);
                    //Nhân viên nghỉ việc
                    if (objHREmployeeInfo.HREmployeeStopWorkingDate != DateTime.MaxValue)
                    {
                        if (objHREmployeeInfo.HREmployeeStopWorkingDate.Year == iyear)
                        {
                            dbDftDay = SoThangLamviecDenLucNghi(objHREmployeeInfo.HREmployeeStopWorkingDate, objHREmployeeInfo.HREmployeeStartWorkingDate);
                        }
                    }
                    dbSothanglamviec = dbDftDay;
                    dbDftDay = Math.Round(dbDftDay, 2);
                }
            }
            //tính số phép thâm niên
            if (isExpDays == true)
            {
                if (objHREmployeeInfo.HREmployeeStartWorkingDate != null)
                {
                    dbExpYear = dbSothanglamviec / 12;
                    if (dbExpYear > 0)
                    {
                        DataSet ds = new HRSeniorityLeaveDayConfigsController().GetAllObjects();
                        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            objHREmployeeLRegsInfo.HREmployeeLRegExpDays = 0;
                            List<HRSeniorityLeaveDayConfigsInfo> lst = (List<HRSeniorityLeaveDayConfigsInfo>)new HRSeniorityLeaveDayConfigsController().GetListFromDataSet(ds);
                            foreach (HRSeniorityLeaveDayConfigsInfo item in lst)
                            {
                                if ((dbExpYear >= item.HRSeniorityLeaveDayConfigFrom) && (dbExpYear <= item.HRSeniorityLeaveDayConfigTo || item.HRSeniorityLeaveDayConfigTo == 0))
                                {
                                    objHREmployeeLRegsInfo.HREmployeeLRegExpDays = item.HRSeniorityLeaveDayConfigQty;
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        objHREmployeeLRegsInfo.HREmployeeLRegExpDays = 0;
                    }
                }
                else
                {
                    objHREmployeeLRegsInfo.HREmployeeLRegExpDays = 0;
                }
            }
            else
            {
                objHREmployeeLRegsInfo.HREmployeeLRegExpDays = 0;
            }
            if (iExpDayTMonth > 0 && iExpDayTMonth <= 12)
            {
                for (int i = 1; i <= iExpDayTMonth; i++)
                {
                    DateTime dtFirstDayOfMonthCal = new DateTime(iyear, i, 1);
                    dbnumber += TinhSoNgayNghiPhepNamChoNhanVienTrongThang(objHREmployeeInfo, dtFirstDayOfMonthCal);
                }
                if (objHREmployeeLRegsInfo.HREmployeeLRegPreviousDayUsed > dbnumber) objHREmployeeLRegsInfo.HREmployeeLRegPreviousDayUsed = dbnumber;
                for (int i = iExpDayTMonth + 1; i <= 12; i++)
                {
                    DateTime dtFirstDayOfMonthCal = new DateTime(iyear, i, 1);
                    dbnumber += TinhSoNgayNghiPhepNamChoNhanVienTrongThang(objHREmployeeInfo, dtFirstDayOfMonthCal);
                }
            }
            else
            {

                for (int i = 1; i <= 12; i++)
                {
                    DateTime dtFirstDayOfMonthCal = new DateTime(iyear, i, 1);
                    dbnumber += TinhSoNgayNghiPhepNamChoNhanVienTrongThang(objHREmployeeInfo, dtFirstDayOfMonthCal);
                }
            }
            objHREmployeeLRegsInfo.HREmployeeLRegLeaveDays = dbnumber;
            objHREmployeeLRegsInfo.HREmployeeLRegTotDays = dbDftDay + objHREmployeeLRegsInfo.HREmployeeLRegNoxiouDays + objHREmployeeLRegsInfo.HREmployeeLRegAnnualLeaveOtherDays + objHREmployeeLRegsInfo.HREmployeeLRegExpDays + objHREmployeeLRegsInfo.HREmployeeLRegPreviousDayUsed;
            dbSoNgayConLai = objHREmployeeLRegsInfo.HREmployeeLRegTotDays - objHREmployeeLRegsInfo.HREmployeeLRegLeaveDays;
            if (dbSoNgayConLai > 0)
                objHREmployeeLRegsInfo.HREmployeeLRegRemainDays = dbSoNgayConLai;
            else
                objHREmployeeLRegsInfo.HREmployeeLRegRemainDays = 0;
        }

        public decimal TinhSoNgayNghiPhepNamChoNhanVienTrongThang(HREmployeesInfo objHREmployeeInfo, DateTime dtFirstDayOfMonth)
        {
            decimal dbTongngaynghi = 0;
            List<HRLeaveDaysInfo> lstHREmployeeOffWorks = LayTatCaDangKyNghiPhepNamCuaNhanVien(objHREmployeeInfo.HREmployeeID, dtFirstDayOfMonth, dtFirstDayOfMonth.AddMonths(1).AddDays(-1));
            foreach (HRLeaveDaysInfo objHREmployeeOffWorkInfo in lstHREmployeeOffWorks)
            {
                dbTongngaynghi += objHREmployeeOffWorkInfo.HRTimeSheetParamValue1;
            }
            return dbTongngaynghi;
        }

        public decimal TinhSoNgayNghiCuaNhanVienTheoThang(HREmployeesInfo objHREmployeeInfo, HRRequestLeaveDaysInfo objHREmployeeOffWorkInfo, DateTime dtOffWorkFrom, DateTime dtOffWorkTo, String strHRTCSrlTypeCombo, int iHREmployeeLeaveTypeID)
        {
            decimal dbSoNgayDaNghi = 0;
            return Convert.ToDecimal((dtOffWorkTo - dtOffWorkFrom).TotalDays);
            for (int i = 0; i <= (dtOffWorkTo - dtOffWorkFrom).TotalDays; i++)
            {
                DateTime dtCurrentDay = dtOffWorkFrom.AddDays(i);

                if (KiemTraNghiPhepChinhThucCuaNhanVien(objHREmployeeInfo, dtCurrentDay))
                {
                    continue;
                }
                else
                {
                    decimal dbSoNgayNghi = 1;
                    if ((objHREmployeeOffWorkInfo.HRRequestLeaveDayFromDate - objHREmployeeOffWorkInfo.HRRequestLeaveDayToDate).Days > 0 && (objHREmployeeOffWorkInfo.HRRequestLeaveDayFromDate - objHREmployeeOffWorkInfo.HRRequestLeaveDayToDate).Days <= 1)
                    {
                        dbSoNgayNghi = (objHREmployeeOffWorkInfo.HRRequestLeaveDayFromDate - objHREmployeeOffWorkInfo.HRRequestLeaveDayToDate).Days;
                    }

                    if (dbSoNgayNghi + dbSoNgayDaNghi <= (objHREmployeeOffWorkInfo.HRRequestLeaveDayFromDate - objHREmployeeOffWorkInfo.HRRequestLeaveDayToDate).Days)
                    {
                        dbSoNgayDaNghi += dbSoNgayNghi;
                    }
                }
            }
            return dbSoNgayDaNghi;
        }

        public Boolean KiemTraNghiPhepChinhThucCuaNhanVien(HREmployeesInfo objHREmployeeInfo, DateTime dtCurrentDay)
        {
            return false;
            //if (objHREmployeeInfo.HREmployeeTCSlrTypeCombo == EmployeeSalaryProcedure.cstLoaiTinhCongDefault)
            //{
            //    return ExpertERP.Procedure.HR.BonusAllowanceProcedure.KiemTraCoPhaiNgayNghiTrongTuan(dtCurrentDay);
            //}
            //else if (objHREmployeeInfo.HREmployeeTCSlrTypeCombo == ExpertERP.Procedure.HR.EmployeeSalaryProcedure.cstLoaiTinhCongTheoBangXepCa)
            //{
            //    if (ExpertERP.Procedure.HR.BonusAllowanceProcedure.KiemTraCoPhaiNgayNghiTrongBangXepCa(dtCurrentDay, objHREmployeeInfo.HREmployeeID))
            //    {
            //        return true;
            //    }
            //}
            //return false;
        }

        public Boolean LayThoiGianNghiPhepTrongThang(DateTime dtFirstDayOfMonth, HRLeaveDaysInfo objHREmployeeOffWorkInfo, ref DateTime dtOffWorkInMonthFrom, ref DateTime dtOffWorkInMonthTo)
        {
            dtOffWorkInMonthFrom = (DateTime)objHREmployeeOffWorkInfo.HRLeaveDayDate;
            dtOffWorkInMonthTo = (DateTime)objHREmployeeOffWorkInfo.HRLeaveDayDate;
            if ((dtOffWorkInMonthFrom.Year * 12 + dtOffWorkInMonthFrom.Month <= dtFirstDayOfMonth.Year * 12 + dtFirstDayOfMonth.Month) &&
                (dtOffWorkInMonthTo.Year * 12 + dtOffWorkInMonthTo.Month >= dtFirstDayOfMonth.Year * 12 + dtFirstDayOfMonth.Month))
            {
                if (dtOffWorkInMonthFrom < dtFirstDayOfMonth)
                {
                    dtOffWorkInMonthFrom = dtFirstDayOfMonth;
                }
                if (dtOffWorkInMonthTo > dtFirstDayOfMonth.AddMonths(1).AddDays(-1))
                {
                    dtOffWorkInMonthTo = dtFirstDayOfMonth.AddMonths(1).AddDays(-1);
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        public List<HRLeaveDaysInfo> LayTatCaDangKyNghiPhepNamCuaNhanVien(int iHREmployeeID, DateTime dtFrom, DateTime dtTo)
        {

            HRLeaveDaysController objLeaveDaysController = new HRLeaveDaysController();
            List<HRLeaveDaysInfo> lstHRLeaveDays = new List<HRLeaveDaysInfo>();
            DataSet dsHREmployeeOffWork = objLeaveDaysController.GetAllDataByEmployeeLeaveFromTo(iHREmployeeID, dtFrom, dtTo);//loại là phép năm ?? còn loại 1/2 năm
            if (dsHREmployeeOffWork != null && dsHREmployeeOffWork.Tables.Count > 0)
            {
                List<HRLeaveDaysInfo> lstHREmployeeOffworkTemp = (List<HRLeaveDaysInfo>)objLeaveDaysController.GetListFromDataSet(dsHREmployeeOffWork);
                foreach (HRLeaveDaysInfo objHREmployeeOffWorkInfo in lstHREmployeeOffworkTemp)
                {
                    if (objHREmployeeOffWorkInfo != null)
                    {
                        lstHRLeaveDays.Add(objHREmployeeOffWorkInfo);
                    }
                }
            }
            return lstHRLeaveDays;
        }

        public void UpdateLastTimeCalculate()
        {
            BOSLabel lblLastMonth = (BOSLabel)GetControlByName("fld_lblLastYear");
            BOSLabel lblLastDateCal = (BOSLabel)GetControlByName("fld_lblLastDateCal");
            if (lblLastMonth == null || lblLastDateCal == null) return;
            lblLastMonth.Text = "";
            lblLastDateCal.Text = "";
            HREmployeeLRegsInfo objEmployeeLRegsInfo = new HREmployeeLRegsController().GetmaxYearCal();
            if (objEmployeeLRegsInfo != null)
            {
                if (objEmployeeLRegsInfo.AAUpdatedDate != DateTime.MaxValue)
                {
                    lblLastMonth.Text = objEmployeeLRegsInfo.HREmployeeLRegYear.ToString() + " (tính đến 31/12/" + objEmployeeLRegsInfo.HREmployeeLRegYear.ToString() + ")";
                    lblLastDateCal.Text = objEmployeeLRegsInfo.HREmployeeLRegDateCal.ToString("dd/M/yyyy");
                }
                else
                {
                    lblLastMonth.Text = "Chưa có dữ liệu chốt phép năm!";
                    lblLastDateCal.Text = "Chưa có dữ liệu chốt phép năm!";
                }
            }
        }

        /// <summary>
        /// Update the total leave days of an employee
        /// </summary>
        /// <param name="leaveDay">Object represents leave days of the employee</param>
        public void UpdateTotalLeaveDays(HRLeaveDaysInfo leaveDay)
        {
        }

        public void SaveLeaveDays()
        {
            EmployeeLeaveCalculateEntities entity = (EmployeeLeaveCalculateEntities)CurrentModuleEntity;
            HREmployeeLRegsController objHREmployeeLRegCtrl = new HREmployeeLRegsController();

            entity.EmployeeLRegList.ForEach(o =>
            {
                if (o.HREmployeeLRegID > 0)
                {
                    o.AAUpdatedDate = BOSApp.GetCurrentServerDate();
                    o.HREmployeeLRegDateCal = BOSApp.GetCurrentServerDate();
                    o.AAUpdatedUser = BOSApp.CurrentUser;
                    objHREmployeeLRegCtrl.UpdateObject(o);
                }
                else
                {
                    o.AAUpdatedDate = BOSApp.GetCurrentServerDate();
                    o.HREmployeeLRegDateCal = BOSApp.GetCurrentServerDate();
                    o.AACreatedUser = BOSApp.CurrentUser;
                    objHREmployeeLRegCtrl.CreateObject(o);
                }
            });
            UpdateLastTimeCalculate();
            MessageBox.Show("Lưu thành công!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
