using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.ManagerTimeKeeper.UI;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using zkemkeeper;

namespace BOSERP.Modules.ManagerTimeKeeper
{
    public class ManagerTimeKeeperModule : BaseModuleERP
    {
        #region Constants
        List<HRMachineTimeKeepersInfo> MachineTimeKeeperSConnectedList;
        public const string DataFromName = "fld_dteSearchFromDate";
        public const string DataToName = "fld_dteSearchToDate";
        public const string TimeKeepersGridCompleteControlName = "fld_dgcHRTimeKeeperCompletes";
        public const string TimeKeepersGridControlName = "fld_dgcHRTimeKeepers";
        public const string MachineTimeKeeperLookupEditName = "fld_lkeHRMachineTimeKeeperID";
        public const string MachineTimeKeeperLookupEditName2 = "fld_lkeHRMachineTimeKeeperID2";
        public const string MachineTimeKeeperLookupEditName3 = "fld_lkeHRMachineTimeKeeperID3";
        public const string MachineTimeKeeperCalculateLookupEditName = "fld_lkeHRMachineTimeKeeperCalculateID";
        public const string MachineTimeKeeperTypeRadioGroupName = "radioGroup";
        public const string MachineTimeKeeperName = "fld_dgcHRMachineTimeKeepers";
        public const string CustomerLookupEditControlName = "fld_lkeHREmployeeID";
        public const string CustomerLookupEditControlName2 = "fld_lkeHREmployeeID2";
        public const string DataCalculateFromName = "fld_dteSearchCalculateFromDate";
        public const string DataCalculateToName = "fld_dteSearchCalculateToDate";
        public const string HRTimeKeeperHistoryDetailsGridControlName = "fld_dgcHRTimeKeeperHistoryDetails";

        public BOSDateEdit DateFromControl;
        public BOSDateEdit DateToControl;
        public BOSDateEdit DateCalculateFromControl;
        public BOSDateEdit DateCalculateToControl;
        public HRTimeKeeperCompletesGridControl TimeKeeperCompletesGridControl;
        public BOSLookupEdit MachineTimeKeeperLookupEdit;
        public BOSLookupEdit MachineTimeKeeperLookupEdit2;
        public BOSLookupEdit MachineTimeKeeperLookupEdit3;
        public BOSLookupEdit MachineTimeKeeperCalculateLookupEdit;
        public BOSRadioGroup MachineTimeKeeperTypeRadioGroup;
        public HRMachineTimeKeepersGridControl MachineTimeKeeperControl;
        public HRMachineTimeKeepersInfo CurenMachineTimeKeeper;
        public BOSLookupEdit CustomerLookupEditControl;
        public BOSLookupEdit CustomerLookupEditControl2;
        public HRTimeKeeperGridControl TimeKeepersGridControl;

        public const string DepartmentLookupEditName = "fld_lkeFK_HRDepartmentID";
        public const string DepartmentRoomLookupEditName = "fld_lkeFK_HRDepartmentRoomID";
        public const string EmployeeSearchLookupEditName = "fld_lkeHREmployeeID2";

        public const string MachineTimeKeeperToLookupEditName = "fld_lkeHRMachineTimeKeeperToID";
        //103
        public const string SearchFromDateViewName = "fld_dteSearchFromDateView";
        public const string SearchHistoryFromDateViewName = "fld_dteSearchHistoryFromDateView";
        public const string SearchToDateViewName = "fld_dteSearchToDateView";
        public const string SearchHistoryToDateViewName = "fld_dteSearchHistoryToDateView";
        public const string HRMachineTimeKeeperIDViewName = "fld_lkeHRMachineTimeKeeperIDView";
        public const string HRTimeKeeperCompletesViewName = "fld_dgcHRTimeKeeperCompletesView";
        public const string DepartmentLookupEditViewName = "fld_lkeFK_HRDepartmentIDView";
        public const string HRDepartmentIDHistoryViewName = "fld_lkeFK_HRDepartmentIDHistoryView";
        public const string DepartmentRoomLookupEditViewName = "fld_lkeFK_HRDepartmentRoomIDView";
        public const string HRDepartmentRoomIDHistoryViewName = "fld_lkeFK_HRDepartmentRoomIDHistoryView";
        public const string EmployeeSearchLookupEditViewName = "fld_lkeHREmployeeIDView";
        public const string HREmployeeIDHistoryViewName = "fld_lkeHREmployeeIDHistoryView";
        public const string PayrollFormulaSearchLookupEditViewName = "fld_lkeFK_HREmployeePayrollFormulaIDView";
        public const string MMWorkShopIDLookupEditViewName = "fld_lkeMMWorkShopID";
        public const string MMWorkShopID1LookupEditViewName = "fld_lkeMMWorkShopID1";
        public const string PayrollFormulaSearchLookupEditViewName1 = "fld_lkeFK_HREmployeePayrollFormulaID1";
        public const string PayrollFormulaSearchLookupEditViewName2 = "fld_lkeFK_HREmployeePayrollFormulaID2";

        public const string DepartmentRoomGroupItemIDViewLookupEditViewName = "fld_lkeFK_HRDepartmentRoomGroupItemIDView";
        public const string DepartmentRoomGroupTeamItemIDViewLookupEditViewName = "fld_lkeFK_HRDepartmentRoomGroupTeamItemIDView";
        public const string DepartmentRoomGroupItemIDLookupEditViewName = "fld_lkeFK_HRDepartmentRoomGroupItemID";
        public const string DepartmentRoomGroupTeamItemIDLookupEditViewName = "fld_lkeFK_HRDepartmentRoomGroupTeamItemID";
        //fld_lkeHRMachineTimeKeeperToID

        public BOSLookupEdit DepartmentLookupEdit;
        public BOSLookupEdit DepartmentRoomLookupEdit;
        public BOSLookupEdit EmployeeSearchLookupEdit;
        public BOSLookupEdit MMWorkShopIDLookupEdit;
        public BOSLookupEdit MMWorkShopIDLookupEdit1;
        public BOSLookupEdit MachineTimeKeeperToLookupEdit;
        //103
        public BOSDateEdit SearchFromDateView;
        public BOSDateEdit SearchHistoryFromDateView;
        public BOSDateEdit SearchHistoryToDateView;
        public BOSDateEdit SearchToDateView;
        public BOSLookupEdit HRMachineTimeKeeperIDView;
        public HRTimeKeeperCompleteViewsGridControl HRTimeKeeperCompletesView;
        public BOSLookupEdit DepartmentLookupEditView;
        public BOSLookupEdit DepartmentRoomLookupEditView;
        public BOSLookupEdit EmployeeSearchLookupEditView;
        public BOSLookupEdit PayrollFormulaSearchLookupEditView;
        public BOSLookupEdit PayrollFormulaSearchLookupEdit1;
        public BOSLookupEdit PayrollFormulaSearchLookupEdit2;
        public BOSLookupEdit HRDepartmentIDHistoryView;
        public BOSLookupEdit HRDepartmentRoomIDHistoryView;
        public BOSLookupEdit HREmployeeIDHistoryView;

        public BOSLookupEdit DepartmentRoomGroupItemIDView;
        public BOSLookupEdit DepartmentRoomGroupTeamItemIDView;
        public BOSLookupEdit DepartmentRoomGroupItemID;
        public BOSLookupEdit DepartmentRoomGroupTeamItemID;
        public List<HREmployeeOTsInfo> AllEmployeeOTList;
        public List<HREmployeesInfo> EmployeeWorkingShiftList;
        public HRTimeKeeperHistoryDetailsGridControl TimeKeeperHistoryDetailsGridControl;
        #endregion
        public ManagerTimeKeeperModule()
        {
            Name = ModuleName.ManagerTimeKeeper;
            CurrentModuleEntity = new ManagerTimeKeeperEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            DateFromControl = (BOSDateEdit)Controls[DataFromName];
            DateToControl = (BOSDateEdit)Controls[DataToName];
            DateCalculateFromControl = (BOSDateEdit)Controls[DataCalculateFromName];
            DateCalculateToControl = (BOSDateEdit)Controls[DataCalculateToName];
            TimeKeeperCompletesGridControl = (HRTimeKeeperCompletesGridControl)Controls[TimeKeepersGridCompleteControlName];
            DateFromControl.EditValue = BOSApp.GetCurrentServerDate().AddDays(-1);
            DateToControl.EditValue = BOSApp.GetCurrentServerDate().AddDays(-1);
            DateCalculateFromControl.EditValue = BOSApp.GetCurrentServerDate().AddDays(-1);
            DateCalculateToControl.EditValue = BOSApp.GetCurrentServerDate().AddDays(-1);
            MachineTimeKeeperLookupEdit = (BOSLookupEdit)Controls[MachineTimeKeeperLookupEditName];
            MachineTimeKeeperLookupEdit2 = (BOSLookupEdit)Controls[MachineTimeKeeperLookupEditName2];
            MachineTimeKeeperLookupEdit3 = (BOSLookupEdit)Controls[MachineTimeKeeperLookupEditName3];
            MachineTimeKeeperCalculateLookupEdit = (BOSLookupEdit)Controls[MachineTimeKeeperCalculateLookupEditName];
            MachineTimeKeeperTypeRadioGroup = (BOSRadioGroup)Controls[MachineTimeKeeperTypeRadioGroupName];
            MachineTimeKeeperControl = (HRMachineTimeKeepersGridControl)Controls[MachineTimeKeeperName];
            HRMachineTimeKeepersController objMachineTimeKeepersController = new HRMachineTimeKeepersController();
            List<HRMachineTimeKeepersInfo> list = objMachineTimeKeepersController.GetAllObjectList();
            MachineTimeKeeperControl.DataSource = list;
            CustomerLookupEditControl = (BOSLookupEdit)Controls[CustomerLookupEditControlName];
            CustomerLookupEditControl2 = (BOSLookupEdit)Controls[CustomerLookupEditControlName2];
            TimeKeepersGridControl = (HRTimeKeeperGridControl)Controls[TimeKeepersGridControlName];
            // CurenMachineTimeKeeper = new HRMachineTimeKeepersInfo();
            //InvalidateMachineTimeKeeperList();
            DepartmentLookupEdit = (BOSLookupEdit)Controls[DepartmentLookupEditName];
            DepartmentRoomLookupEdit = (BOSLookupEdit)Controls[DepartmentRoomLookupEditName];
            EmployeeSearchLookupEdit = (BOSLookupEdit)Controls[EmployeeSearchLookupEditName];
            MachineTimeKeeperToLookupEdit = (BOSLookupEdit)Controls[MachineTimeKeeperToLookupEditName];
            TimeKeeperHistoryDetailsGridControl = (HRTimeKeeperHistoryDetailsGridControl)Controls[HRTimeKeeperHistoryDetailsGridControlName];
            //103
            SearchFromDateView = (BOSDateEdit)Controls[SearchFromDateViewName];
            SearchHistoryFromDateView = (BOSDateEdit)Controls[SearchHistoryFromDateViewName];
            SearchHistoryToDateView = (BOSDateEdit)Controls[SearchHistoryToDateViewName];
            SearchToDateView = (BOSDateEdit)Controls[SearchToDateViewName];
            HRMachineTimeKeeperIDView = (BOSLookupEdit)Controls[HRMachineTimeKeeperIDViewName];
            HRTimeKeeperCompletesView = (HRTimeKeeperCompleteViewsGridControl)Controls[HRTimeKeeperCompletesViewName];
            DepartmentLookupEditView = (BOSLookupEdit)Controls[DepartmentLookupEditViewName];
            HRDepartmentIDHistoryView = (BOSLookupEdit)Controls[HRDepartmentIDHistoryViewName];
            HRDepartmentRoomIDHistoryView = (BOSLookupEdit)Controls[HRDepartmentRoomIDHistoryViewName];
            HREmployeeIDHistoryView = (BOSLookupEdit)Controls[HREmployeeIDHistoryViewName];
            DepartmentRoomLookupEditView = (BOSLookupEdit)Controls[DepartmentRoomLookupEditViewName];
            EmployeeSearchLookupEditView = (BOSLookupEdit)Controls[EmployeeSearchLookupEditViewName];
            PayrollFormulaSearchLookupEditView = (BOSLookupEdit)Controls[PayrollFormulaSearchLookupEditViewName];
            MMWorkShopIDLookupEdit = (BOSLookupEdit)Controls[MMWorkShopIDLookupEditViewName];
            MMWorkShopIDLookupEdit1 = (BOSLookupEdit)Controls[MMWorkShopID1LookupEditViewName];
            HREmployeePayrollFormulasController objEmployeePayrollFormulasController = new HREmployeePayrollFormulasController();
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            HRDepartmentRoomIDHistoryView.Properties.DataSource = (List<HRDepartmentRoomsInfo>)objDepartmentRoomsController.GetRoomListForLookup();
            //set defauld valie
            SearchFromDateView.EditValue = BOSApp.GetCurrentServerDate().AddDays(-1);
            SearchToDateView.EditValue = BOSApp.GetCurrentServerDate().AddDays(-1);
            SearchHistoryFromDateView.EditValue = BOSApp.GetCurrentServerDate().AddDays(-1);
            SearchHistoryToDateView.EditValue = BOSApp.GetCurrentServerDate();
            PayrollFormulaSearchLookupEdit1 = (BOSLookupEdit)Controls[PayrollFormulaSearchLookupEditViewName1];
            PayrollFormulaSearchLookupEdit2 = (BOSLookupEdit)Controls[PayrollFormulaSearchLookupEditViewName2];
            DepartmentRoomGroupItemIDView = (BOSLookupEdit)Controls[DepartmentRoomGroupItemIDViewLookupEditViewName];
            DepartmentRoomGroupTeamItemIDView = (BOSLookupEdit)Controls[DepartmentRoomGroupTeamItemIDViewLookupEditViewName];
            DepartmentRoomGroupItemID = (BOSLookupEdit)Controls[DepartmentRoomGroupItemIDLookupEditViewName];
            DepartmentRoomGroupTeamItemID = (BOSLookupEdit)Controls[DepartmentRoomGroupTeamItemIDLookupEditViewName];
        }
        public void TestConnect()
        {
            ManagerTimeKeeperEntities entity = (ManagerTimeKeeperEntities)CurrentModuleEntity;
            HRMachineTimeKeepersInfo objMachineTimeKeepersInfo = (HRMachineTimeKeepersInfo)entity.MainObject;
            objMachineTimeKeepersInfo = Connect(objMachineTimeKeepersInfo);
            if (objMachineTimeKeepersInfo.HRMachineTimeKeeperIsConnected)
            {
                MessageBox.Show(MachineTimeKeeperLocalizedResources.ConnectSuccess, MachineTimeKeeperLocalizedResources.TestConnect, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisConnect(objMachineTimeKeepersInfo);
            }
            else
            {
                MessageBox.Show(MachineTimeKeeperLocalizedResources.ConnectFalse, MachineTimeKeeperLocalizedResources.TestConnect, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public HRMachineTimeKeepersInfo Connect(HRMachineTimeKeepersInfo objMachineTimeKeepersInfo)
        {
            objMachineTimeKeepersInfo.CZKEMMachine = new CZKEMClass();
            objMachineTimeKeepersInfo.HRMachineTimeKeeperIsConnected = objMachineTimeKeepersInfo.CZKEMMachine.Connect_Net(objMachineTimeKeepersInfo.HRMachineTimeKeeperIP, Convert.ToInt32(objMachineTimeKeepersInfo.HRMachineTimeKeeperPortID));
            return objMachineTimeKeepersInfo;
        }
        public HRMachineTimeKeepersInfo DisConnect(HRMachineTimeKeepersInfo objMachineTimeKeepersInfo)
        {
            if (objMachineTimeKeepersInfo.HRMachineTimeKeeperIsConnected)
            {
                if (objMachineTimeKeepersInfo.CZKEMMachine != null)
                    objMachineTimeKeepersInfo.CZKEMMachine.Disconnect();
            }
            objMachineTimeKeepersInfo.HRMachineTimeKeeperIsConnected = false;
            return objMachineTimeKeepersInfo;
        }
        public void DisConnect()
        {
            ManagerTimeKeeperEntities entity = (ManagerTimeKeeperEntities)CurrentModuleEntity;
            HRMachineTimeKeepersInfo objMachineTimeKeepersInfo = (HRMachineTimeKeepersInfo)entity.MainObject;
            objMachineTimeKeepersInfo = DisConnect(objMachineTimeKeepersInfo);
        }

        public List<HRTimeKeepersInfo> DownloadData(int typeIndex)
        {
            List<HRTimeKeepersInfo> timeKeeperList = new List<HRTimeKeepersInfo>();
            DateTime dateFrom = Convert.ToDateTime(DateFromControl.EditValue);
            DateTime dateTo = Convert.ToDateTime(DateToControl.EditValue);
            if (typeIndex == 0)
            {
                if (CurenMachineTimeKeeper == null || CurenMachineTimeKeeper.HRMachineTimeKeeperIP == string.Empty)
                {
                    CurenMachineTimeKeeper = (HRMachineTimeKeepersInfo)MachineTimeKeeperControl.MainView.GetRow(0);
                }
                CurenMachineTimeKeeper = Connect(CurenMachineTimeKeeper);
                BOSProgressBar.Start("Đã kết nối...");
                if (!CurenMachineTimeKeeper.HRMachineTimeKeeperIsConnected)
                {
                    MessageBox.Show(MachineTimeKeeperLocalizedResources.ConnectFalse, MachineTimeKeeperLocalizedResources.TestConnect, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return timeKeeperList;
                }
                else
                    timeKeeperList = GetGeneralLogData(CurenMachineTimeKeeper.HRMachineTimeKeeperID, CurenMachineTimeKeeper.CZKEMMachine, true, dateFrom, dateTo, CurenMachineTimeKeeper.FK_MMWorkShopID);
            }
            else
            {
                HRMachineTimeKeepersController objHRMachineTimeKeepersController = new HRMachineTimeKeepersController();
                List<HRMachineTimeKeepersInfo> list = objHRMachineTimeKeepersController.GetAllObjectList();
                List<HRTimeKeepersInfo> currentTimeKeeperList = new List<HRTimeKeepersInfo>();
                HRMachineTimeKeepersInfo objMachineTimeKeepersInfo;
                foreach (HRMachineTimeKeepersInfo item in list)
                {
                    objMachineTimeKeepersInfo = (HRMachineTimeKeepersInfo)item.Clone();
                    objMachineTimeKeepersInfo = Connect(objMachineTimeKeepersInfo);
                    if (!objMachineTimeKeepersInfo.HRMachineTimeKeeperIsConnected)
                    {
                        MessageBox.Show(MachineTimeKeeperLocalizedResources.ConnectFalse, MachineTimeKeeperLocalizedResources.TestConnect, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return timeKeeperList;
                    }
                    else
                        currentTimeKeeperList = GetGeneralLogData(objMachineTimeKeepersInfo.HRMachineTimeKeeperID, objMachineTimeKeepersInfo.CZKEMMachine, true, dateFrom, dateTo, objMachineTimeKeepersInfo.FK_MMWorkShopID);
                    DisConnect(item);
                    timeKeeperList.AddRange(currentTimeKeeperList);
                }

            }
            //objMachineTimeKeepersInfo = DisConnect(objMachineTimeKeepersInfo);
            return timeKeeperList;
        }
        public List<HRTimeKeepersInfo> GetGeneralLogData(int machineTimeKeeperID, CZKEMClass machine, bool FilterByDay, DateTime FromDate, DateTime ToDate, int workShop)
        {
            List<HRTimeKeepersInfo> timeKeeperList = new List<HRTimeKeepersInfo>();
            HRTimeKeepersInfo objTimeKeeper;
            string str = "";
            int dwVerifyMode = 0;
            int dwInOutMode = 0;
            int dwYear = 0;
            int dwMonth = 0;
            int dwDay = 0;
            int dwHour = 0;
            int dwMinute = 0;
            int dwSecond = 0;
            int dwWorkCode = 0;
            int num14 = 0;
            int dwEMachineNumber = 0;
            int dwTMachineNumber = 0;
            int dwEnrollNumber = 0;

            DateTime time;
            DateTime time2;
            // machine.EnableDevice(machineTimeKeeperID, false);
            // machine.ClearWorkCode();
            if (!machine.IsTFTMachine(machineTimeKeeperID))
            {
                BOSProgressBar.Start("Not TFT machine read...");
                machine.EnableDevice(machineTimeKeeperID, false);
                BOSProgressBar.Start("EnableDevice Not TFT machine...");
                try
                {
                    if (machine.ReadAllGLogData(machineTimeKeeperID) == true)
                    {
                        BOSProgressBar.Start("Đang đọc...");
                        while (machine.GetGeneralLogData(machineTimeKeeperID, ref dwTMachineNumber, ref dwEnrollNumber, ref dwEMachineNumber, ref dwVerifyMode, ref dwInOutMode, ref dwYear, ref dwMonth, ref dwDay, ref dwHour, ref dwMinute))
                        {
                            num14++;
                            try
                            {
                                time = Convert.ToDateTime(string.Concat(new object[] { dwYear, "/", dwMonth, "/", dwDay }));
                                time2 = Convert.ToDateTime(string.Concat(new object[] { dwYear, "/", dwMonth, "/", dwDay, " ", dwHour, ":", dwMinute }));
                                str = dwEnrollNumber.ToString();
                                if (FilterByDay)
                                {
                                    if ((time >= FromDate.Date) && (time <= ToDate.Date))
                                    {
                                        objTimeKeeper = new HRTimeKeepersInfo(str, time, time2, dwInOutMode, machineTimeKeeperID, workShop);
                                        timeKeeperList.Add(objTimeKeeper);
                                    }
                                }
                            }
                            catch (Exception xe)
                            {
                                MessageBox.Show(xe.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }
                    }
                }
                catch (Exception xe)
                {
                    MessageBox.Show(xe.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                BOSProgressBar.Start("Release Device Not TFT machine...");
            }
            else
            {
                BOSProgressBar.Start("TFT machine read...");
                machine.EnableDevice(machineTimeKeeperID, false);
                BOSProgressBar.Start("EnableDevice TFT...");
                if (machine.ReadAllGLogData(machineTimeKeeperID) == true)
                {
                    BOSProgressBar.Start("Đang đọc...");
                    while (machine.SSR_GetGeneralLogData(machineTimeKeeperID, out str, out dwVerifyMode, out dwInOutMode, out dwYear, out dwMonth, out dwDay, out dwHour, out dwMinute, out dwSecond, ref dwWorkCode))
                    {
                        num14++;
                        time = Convert.ToDateTime(string.Concat(new object[] { dwYear, "/", dwMonth, "/", dwDay }));
                        time2 = Convert.ToDateTime(string.Concat(new object[] { dwYear, "/", dwMonth, "/", dwDay, " ", dwHour, ":", dwMinute }));
                        if (FilterByDay)
                        {
                            if ((time >= FromDate.Date) && (time <= ToDate.Date))
                            {
                                objTimeKeeper = new HRTimeKeepersInfo(str, time, time2, dwInOutMode, machineTimeKeeperID, workShop);
                                timeKeeperList.Add(objTimeKeeper);
                            }
                        }
                    }
                }
                BOSProgressBar.Start("Out While...");
            }
            // machine.EnableDevice(machineTimeKeeperID, true);
            return timeKeeperList;
        }
        public string GetThName(DateTime date)
        {
            string[] thu = { "Chủ nhật", "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7" };
            int indexThu = 0;
            indexThu = (int)date.DayOfWeek;
            return thu[indexThu];
        }
        public void DownloadAndShowData()
        {
            BOSProgressBar.Start("Đang xử lý dữ liệu");
            int index = MachineTimeKeeperTypeRadioGroup.SelectedIndex;
            List<HRTimeKeepersInfo> timeKeeperList = DownloadData(index);
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo;
            foreach (HRTimeKeepersInfo item in timeKeeperList)
            {
                objEmployeesInfo = objEmployeesController.GetEmployeeByCardNumber(item.HRTimeKeeperEmployeeCardNo);
                if (objEmployeesInfo != null)
                {
                    item.HRTimeKeeperEmployeeNo = objEmployeesInfo.HREmployeeNo;
                    item.EmployeeName = objEmployeesInfo.HREmployeeName;
                }
                item.ThName = GetThName(item.HRTimeKeeperDate);
            }
            TimeKeepersGridControl.DataSource = timeKeeperList;
            SaveData(timeKeeperList, false);

            SearchFromDateView.EditValue = DateFromControl.DateTime;
            SearchToDateView.EditValue = DateToControl.DateTime;
            DateCalculateFromControl.EditValue = DateFromControl.DateTime;
            DateCalculateToControl.EditValue = DateToControl.DateTime;

            //HRTimeKeepersController objTimeKeepersController = new HRTimeKeepersController();
            //List<HRTimeKeepersInfo> keeperList;
            //DateTime dataFrom = Convert.ToDateTime(DateFromControl.EditValue);
            //DateTime dataTo = Convert.ToDateTime(DateToControl.EditValue);
            //if (index == 0)
            //    keeperList = objTimeKeepersController.GetTimeKeeperByMachineAndByDate(CurenMachineTimeKeeper.HRMachineTimeKeeperID, dataFrom, dataTo);
            //else
            //    keeperList = objTimeKeepersController.GetTimeKeeperByMachineAndByDate(null, dataFrom, dataTo);
            //List<HRTimeKeeperCompletesInfo> listComplate = ConvertTimeKeeperListToComplete(keeperList);
            //TimeKeeperCompletesGridControl.DataSource = listComplate;
            BOSProgressBar.Close();
            MessageBox.Show(MachineTimeKeeperLocalizedResources.SaveSuccess, "Lưu dữ liệu vào hệ thống");
        }
        private string GetEmployeeName(string CardNo)
        {
            string result = string.Empty;
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = objEmployeesController.GetEmployeeByCardNumber(CardNo);
            if (objEmployeesInfo != null)
                result = objEmployeesInfo.HREmployeeName;
            return result;
        }
        private List<HRTimeKeeperCompletesInfo> ConvertTimeKeeperListToComplete2(List<HRTimeKeepersInfo> timeKeeperList)
        {
            List<HRTimeKeeperCompletesInfo> list = new List<HRTimeKeeperCompletesInfo>();
            Hashtable listEmployee = new Hashtable();
            foreach (HRTimeKeepersInfo item in timeKeeperList)
            {
                if (!listEmployee.ContainsKey(item.HRTimeKeeperEmployeeCardNo))
                {
                    listEmployee.Add(item.HRTimeKeeperEmployeeCardNo, item.HRTimeKeeperEmployeeNo);
                }
            }
            List<HRTimeKeepersInfo> listTemp = new List<HRTimeKeepersInfo>();
            foreach (var item in listEmployee.Keys)
            {
                listTemp = timeKeeperList.Where(p => p.HRTimeKeeperEmployeeCardNo == item.ToString())
                    .OrderBy(p => p.HRTimeKeeperTimeOut).ToList();
                int i = 0;
                for (int j = 0; j < listTemp.Count - 1; j++)
                {
                    if (listTemp[j].HRTimeKeeperDate == listTemp[j + 1].HRTimeKeeperDate
                        && listTemp[j].HRTimeKeeperTimeOut == listTemp[j + 1].HRTimeKeeperTimeOut
                        && listTemp[j].HRTimeKeeperEmployeeCardNo == listTemp[j + 1].HRTimeKeeperEmployeeCardNo)
                    {
                        listTemp.RemoveAt(j + 1);
                    }
                }
                if (listTemp.Count == 0) continue;
                if (listTemp[0].HRTimeKeeperTimeInOutModeName.Equals("Out")) i = 1;
                if (listTemp[0].HRTimeKeeperTimeInOutModeName.Equals("Out") && listTemp.Count == 1) continue;

                DateTime date;
                try
                {
                    while (i < listTemp.Count)
                    {
                        if (string.IsNullOrEmpty(listTemp[i].HRTimeKeeperTimeInOutModeName))
                        {
                            HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo = new HRTimeKeeperCompletesInfo();
                            objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDate = listTemp[i].HRTimeKeeperDate;
                            objTimeKeeperCompletesInfo.HRTimeKeeperCompletesEmployeeCardNo = listTemp[i].HRTimeKeeperEmployeeCardNo;
                            objTimeKeeperCompletesInfo.HRTimeKeeperCompleteTimeCheck = listTemp[i].HRTimeKeeperTimeOut;
                            objTimeKeeperCompletesInfo.HRTimeKeeperCompleteInOutMode = 0;
                            objTimeKeeperCompletesInfo.HRTimeKeeperCompleteInOutModeName =
                                i % 2 == 0 ? ManagerTimeKeeperLocalizedResources.In.ToString() : ManagerTimeKeeperLocalizedResources.Out.ToString();
                            objTimeKeeperCompletesInfo.EmployeeName = GetEmployeeName(listTemp[i].HRTimeKeeperEmployeeCardNo);
                            objTimeKeeperCompletesInfo.ThName = GetThName(listTemp[i].HRTimeKeeperDate);
                            objTimeKeeperCompletesInfo.FK_HRMachineTimeKeeperID = listTemp[i].FK_HRMachineTimeKeeperID;
                            list.Add(objTimeKeeperCompletesInfo);
                            date = listTemp[i].HRTimeKeeperDate;
                            i++;
                        }
                        else
                        {
                            if (listTemp[i].HRTimeKeeperTimeInOutModeName.Equals("In"))
                            {
                                //in
                                HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo = new HRTimeKeeperCompletesInfo();
                                objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDate = listTemp[i].HRTimeKeeperDate;
                                objTimeKeeperCompletesInfo.HRTimeKeeperCompletesEmployeeCardNo = listTemp[i].HRTimeKeeperEmployeeCardNo;
                                objTimeKeeperCompletesInfo.HRTimeKeeperCompleteTimeCheck = listTemp[i].HRTimeKeeperTimeOut;
                                objTimeKeeperCompletesInfo.HRTimeKeeperCompleteInOutMode = 0;
                                objTimeKeeperCompletesInfo.HRTimeKeeperCompleteInOutModeName = ManagerTimeKeeperLocalizedResources.In.ToString();
                                objTimeKeeperCompletesInfo.EmployeeName = GetEmployeeName(listTemp[i].HRTimeKeeperEmployeeCardNo);
                                objTimeKeeperCompletesInfo.ThName = GetThName(listTemp[i].HRTimeKeeperDate);
                                objTimeKeeperCompletesInfo.FK_HRMachineTimeKeeperID = listTemp[i].FK_HRMachineTimeKeeperID;
                                list.Add(objTimeKeeperCompletesInfo);
                                date = listTemp[i].HRTimeKeeperDate;
                                i++;
                            }
                            else
                            {
                                HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo = new HRTimeKeeperCompletesInfo();
                                objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDate = listTemp[i].HRTimeKeeperDate;
                                objTimeKeeperCompletesInfo.HRTimeKeeperCompletesEmployeeCardNo = listTemp[i].HRTimeKeeperEmployeeCardNo;
                                objTimeKeeperCompletesInfo.HRTimeKeeperCompleteTimeCheck = listTemp[i].HRTimeKeeperTimeOut;
                                objTimeKeeperCompletesInfo.HRTimeKeeperCompleteInOutMode = 0;
                                objTimeKeeperCompletesInfo.HRTimeKeeperCompleteInOutModeName = ManagerTimeKeeperLocalizedResources.In.ToString();
                                objTimeKeeperCompletesInfo.EmployeeName = GetEmployeeName(listTemp[i].HRTimeKeeperEmployeeCardNo);
                                objTimeKeeperCompletesInfo.ThName = GetThName(listTemp[i].HRTimeKeeperDate);
                                objTimeKeeperCompletesInfo.FK_HRMachineTimeKeeperID = listTemp[i].FK_HRMachineTimeKeeperID;
                                date = listTemp[i].HRTimeKeeperDate;
                                list.Add(objTimeKeeperCompletesInfo);
                            }

                            if (listTemp[i].HRTimeKeeperTimeInOutModeName.Equals("Out"))
                            {
                                HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo = new HRTimeKeeperCompletesInfo();
                                objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDate = date;
                                objTimeKeeperCompletesInfo.HRTimeKeeperCompletesEmployeeCardNo = listTemp[i].HRTimeKeeperEmployeeCardNo;
                                objTimeKeeperCompletesInfo.HRTimeKeeperCompleteTimeCheck = listTemp[i].HRTimeKeeperTimeOut;
                                objTimeKeeperCompletesInfo.HRTimeKeeperCompleteInOutMode = 0;
                                objTimeKeeperCompletesInfo.HRTimeKeeperCompleteInOutModeName = ManagerTimeKeeperLocalizedResources.Out.ToString();
                                objTimeKeeperCompletesInfo.EmployeeName = GetEmployeeName(listTemp[i].HRTimeKeeperEmployeeCardNo);
                                objTimeKeeperCompletesInfo.ThName = GetThName(date);
                                objTimeKeeperCompletesInfo.FK_HRMachineTimeKeeperID = listTemp[i].FK_HRMachineTimeKeeperID;
                                list.Add(objTimeKeeperCompletesInfo);
                                i++;
                            }
                            else
                            {
                                HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo = new HRTimeKeeperCompletesInfo();
                                objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDate = date;
                                objTimeKeeperCompletesInfo.HRTimeKeeperCompletesEmployeeCardNo = listTemp[i].HRTimeKeeperEmployeeCardNo;
                                objTimeKeeperCompletesInfo.HRTimeKeeperCompleteTimeCheck = listTemp[i].HRTimeKeeperTimeOut;
                                objTimeKeeperCompletesInfo.HRTimeKeeperCompleteInOutMode = 0;
                                objTimeKeeperCompletesInfo.HRTimeKeeperCompleteInOutModeName = ManagerTimeKeeperLocalizedResources.Out.ToString();
                                objTimeKeeperCompletesInfo.EmployeeName = GetEmployeeName(listTemp[i].HRTimeKeeperEmployeeCardNo);
                                objTimeKeeperCompletesInfo.ThName = GetThName(date);
                                objTimeKeeperCompletesInfo.FK_HRMachineTimeKeeperID = listTemp[i].FK_HRMachineTimeKeeperID;
                                list.Add(objTimeKeeperCompletesInfo);
                            }
                        }
                    }
                }
                catch (ArgumentOutOfRangeException)
                {

                }
            }
            //for (int i = 0; i < list.Count - 1; i++)
            //{
            //    listTemp[i].HRTimeKeeperDate = listTemp[i + 1].HRTimeKeeperDate;
            //}
            return list;
        }
        private List<HRTimeKeeperCompletesInfo> ConvertTimeKeeperListToComplete(List<HRTimeKeepersInfo> timeKeeperList)
        {
            List<HRTimeKeeperCompletesInfo> list = new List<HRTimeKeeperCompletesInfo>();
            //timeKeeperList = DistinctList(timeKeeperList);
            DateTime dataFrom = Convert.ToDateTime(DateCalculateFromControl.EditValue);
            DateTime dataTo = Convert.ToDateTime(DateCalculateToControl.EditValue);
            DateTime from = dataFrom.Date;
            DateTime to = dataTo.Date;
            HREmployeeOTsController objEmployeeOTsController = new HREmployeeOTsController();
            List<HREmployeeOTsInfo> EmployeeOTList = (List<HREmployeeOTsInfo>)objEmployeeOTsController.GetListOTDiffDates(null, from.AddDays(-1), to);

            Hashtable listEmployee = new Hashtable();
            foreach (HRTimeKeepersInfo item in timeKeeperList)
            {
                if (!listEmployee.ContainsKey(item.HRTimeKeeperEmployeeCardNo))
                {
                    listEmployee.Add(item.HRTimeKeeperEmployeeCardNo, item.HRTimeKeeperEmployeeNo);
                }
            }
            string cardNo = string.Empty;
            List<HRTimeKeepersInfo> listTemp = new List<HRTimeKeepersInfo>();
            HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo;
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo employeesInfo;
            List<HREmployeesInfo> EmployeeList = objEmployeesController.GetEmployeeCardNumberList(null, null, null, null);

            HRBreakTimesController objBreakTimesController = new HRBreakTimesController();
            List<HRBreakTimesInfo> BreakTimeList = objBreakTimesController.GetBreakTimeList();
            List<HRArrangementShiftEntrysInfo> arrangementShiftEntrys = new List<HRArrangementShiftEntrysInfo>();
            HRArrangementShiftEntrysController objArrangementShiftEntrysController = new HRArrangementShiftEntrysController();
            foreach (var item in listEmployee.Keys)
            {
                cardNo = item.ToString();
                employeesInfo = EmployeeList.Where(x => x.HREmployeeCardNumber == cardNo).FirstOrDefault(); ;
                if (employeesInfo != null)
                {
                    bool checkarrangementShift = true;
                    from = dataFrom.Date;
                    while (from <= to)
                    {
                        listTemp = timeKeeperList.Where(p => (p.HRTimeKeeperEmployeeCardNo == cardNo &&
                                p.HRTimeKeeperDate.Date == from.Date)).OrderBy(p => p.HRTimeKeeperTimeOut).ToList();

                        if (employeesInfo.HREmployeePayRollCalculatedWorkType == EmployeePayRollCalculatedWorkType.TableWork.ToString())
                        {
                            arrangementShiftEntrys = (List<HRArrangementShiftEntrysInfo>)objArrangementShiftEntrysController.GetKHRArrangementShiftEntryByFK_HREmployeeIDAndDate(employeesInfo.HREmployeeID, from.Date);
                            if (arrangementShiftEntrys.Count() > 0)
                            {
                                checkarrangementShift = true;
                            }
                            else
                            {
                                checkarrangementShift = false;
                            }
                        }

                        if (checkarrangementShift)
                        {
                            if (listTemp.Count >= 1)
                            {
                                HRBreakTimesInfo objBreakTimesInfo = new HRBreakTimesInfo();
                                if (BreakTimeList != null)
                                    objBreakTimesInfo = BreakTimeList.Where(x => x.FK_HREmployeePayrollFormulaID == employeesInfo.FK_HREmployeePayrollFormulaID).FirstOrDefault();

                                int leftTime = 0;
                                int BreakTimeMinRegisterOverTime = 0;
                                if (objBreakTimesInfo != null)
                                {
                                    leftTime = objBreakTimesInfo.HRBreakTimeMaxOutTime;
                                    BreakTimeMinRegisterOverTime = objBreakTimesInfo.HRBreakTimeMinRegisterOverTime;
                                }

                                List<HRTimeKeeperCompletesInfo> completeListItemReult = ConvertTimeKeeperMultiInOutToComplete(listTemp, employeesInfo, leftTime, EmployeeOTList, timeKeeperList, BreakTimeMinRegisterOverTime);

                                foreach (HRTimeKeeperCompletesInfo completeListItemReultItem in completeListItemReult)
                                {
                                    HRTimeKeeperCompletesInfo objTimeKeeperCompleteSamesInfo = completeListItemReult.Where(x => x.HRTimeKeeperCompleteDate == completeListItemReultItem.HRTimeKeeperCompleteDate &&
                                                                                                           x.HRTimeKeeperCompletesEmployeeCardNo == completeListItemReultItem.HRTimeKeeperCompletesEmployeeCardNo &&
                                                                                                           x.HRTimeKeeperCompleteTimeCheck == completeListItemReultItem.HRTimeKeeperCompleteTimeCheck &&
                                                                                                           x.HRTimeKeeperCompleteInOutMode != completeListItemReultItem.HRTimeKeeperCompleteInOutMode).FirstOrDefault();
                                    if (objTimeKeeperCompleteSamesInfo != null)
                                    {
                                        completeListItemReultItem.SameDateTime = "False";
                                    }
                                }
                                list.AddRange(completeListItemReult);

                            }
                        }
                        from = from.AddDays(1);
                    }
                }
            }
            return list;
        }

        public List<HRTimeKeeperCompletesInfo> ConvertTimeKeeperMultiInOutToComplete(List<HRTimeKeepersInfo> listTemp
                                                                                    , HREmployeesInfo employeesInfo
                                                                                    , int leftTime
                                                                                    , List<HREmployeeOTsInfo> EmployeeOTList
                                                                                    , List<HRTimeKeepersInfo> timeKeeperList
                                                                                    , int minRegisOvertime)
        {
            ManagerTimeKeeperEntities entity = (ManagerTimeKeeperEntities)CurrentModuleEntity;

            List<HRTimeKeeperCompletesInfo> completeList = new List<HRTimeKeeperCompletesInfo>();

            int nextMode = 0;
            string nextModeS = ManagerTimeKeeperLocalizedResources.In.ToString();
            int j = 0;
            for (int i = 0; i <= listTemp.Count - 1; i++)
            {
                HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo;
                // Check has left timespan > leftTime
                List<HRTimeKeeperCompletesInfo> objTimeKeeperCheck = completeList.Where(x => x.HRTimeKeeperCompleteDateCheck.AddMinutes(leftTime).TimeOfDay >= listTemp[i].HRTimeKeeperTimeOut.TimeOfDay).ToList();
                if (objTimeKeeperCheck == null || objTimeKeeperCheck.Count == 0)
                {

                    #region Check OT diff date and clear time Out
                    // Check OT diff date

                    //27/05/2019
                    //HREmployeeOTsInfo objEmployeeOTDiffDateInsInfo = EmployeeOTList.Where(x => x.HREmployeeCardNumber == listTemp[i].HRTimeKeeperEmployeeCardNo
                    //                                                                            && x.HREmployeeOTToDate.Date == listTemp[i].HRTimeKeeperTimeOut.Date
                    //                                                                            && x.HREmployeeOTToDate.AddMinutes(leftTime).TimeOfDay >= listTemp[i].HRTimeKeeperTimeOut.TimeOfDay).FirstOrDefault();

                    HREmployeeOTsInfo objEmployeeOTDiffDateInsInfo = new HREmployeeOTsInfo();
                    #endregion
                    //Có Tồn tại OT qua ngày đến thời gian này.
                    //??? Cần xem xét lại trường hợp OT quá giờ quy định.
                    // Ví dụ đăng ký OT tới 6h chấm ra 8h
                    if (objEmployeeOTDiffDateInsInfo == null || objEmployeeOTDiffDateInsInfo.HREmployeeOTID == 0)
                    {
                        objTimeKeeperCompletesInfo = new HRTimeKeeperCompletesInfo();
                        objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDate = listTemp[i].HRTimeKeeperDate;
                        objTimeKeeperCompletesInfo.HRTimeKeeperCompletesEmployeeCardNo = listTemp[i].HRTimeKeeperEmployeeCardNo;
                        objTimeKeeperCompletesInfo.HRTimeKeeperCompleteTimeCheck = listTemp[i].HRTimeKeeperTimeOut;
                        objTimeKeeperCompletesInfo.EmployeeName = employeesInfo.HREmployeeName;
                        objTimeKeeperCompletesInfo.ThName = GetThName(listTemp[i].HRTimeKeeperDate);
                        objTimeKeeperCompletesInfo.FK_HRMachineTimeKeeperID = listTemp[i].FK_HRMachineTimeKeeperID;
                        objTimeKeeperCompletesInfo.FK_HRDepartmentID = employeesInfo.FK_HRDepartmentID;
                        objTimeKeeperCompletesInfo.FK_HRLevelID = employeesInfo.FK_HRLevelID;
                        objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDateCheck = listTemp[i].HRTimeKeeperTimeOut;
                        objTimeKeeperCompletesInfo.FK_HRTimeKeeperID = listTemp[i].HRTimeKeeperID;
                        objTimeKeeperCompletesInfo.HRDepartmentRoomName = listTemp[i].HRDepartmentRoomName;
                        objTimeKeeperCompletesInfo.HRDepartmentRoomGroupItemName = listTemp[i].HRDepartmentRoomGroupItemName;
                        objTimeKeeperCompletesInfo.HREmployeePayrollFormulaName = listTemp[i].HREmployeePayrollFormulaName;

                        objTimeKeeperCompletesInfo.HRTimeKeeperCompleteInOutMode = nextMode;
                        objTimeKeeperCompletesInfo.HRTimeKeeperCompleteInOutModeName = nextModeS;
                        objTimeKeeperCompletesInfo.EmployeeNo = employeesInfo.HREmployeeNo;
                        if (nextMode == 0)
                        {
                            nextMode = 1;
                            nextModeS = ManagerTimeKeeperLocalizedResources.Out.ToString();
                        }
                        else
                        {
                            nextMode = 0;
                            nextModeS = ManagerTimeKeeperLocalizedResources.In.ToString();
                        }
                        //Kiểm tra Ko DK tăng ca
                        if (objTimeKeeperCompletesInfo.HRTimeKeeperCompleteInOutMode == 1)
                        {
                            if (CheckNotInOverTime(objTimeKeeperCompletesInfo, minRegisOvertime, false))
                            {
                                objTimeKeeperCompletesInfo.NotInOverTime = "False";
                            }
                            if (CheckOverTimeAbsence(objTimeKeeperCompletesInfo, minRegisOvertime, false))
                            {
                                objTimeKeeperCompletesInfo.OverTimeAbsence = "False";
                            }

                        }

                        completeList.Add(objTimeKeeperCompletesInfo);
                    }
                }
                j++;
            }
            //completeList = AddTimeKeeperToTimeKeeperComplete(completeList, EmployeeOTList, employeesInfo, listTemp, objBreakTimesInfo, objTimesheetEmployeeLatesInfo); add ngoai biên
            #region Check OT diff date and get time out type  OR Add plus if the End InOutMode = In
            // Check OT diff date and get time out type 
            if (completeList != null && completeList.Count > 0 && completeList.Count % 2 == 1)
            {
                if (completeList[completeList.Count - 1].HRTimeKeeperCompleteInOutMode == 0)
                {
                    HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo;
                    // Check OT diff date
                    if (EmployeeOTList != null)
                    {
                        objTimeKeeperCompletesInfo = GetOutModeTimeFromOverTimeList(EmployeeOTList
                                                                        , timeKeeperList
                                                                        , listTemp[0]
                                                                        , employeesInfo);
                        if (objTimeKeeperCompletesInfo != null)
                        {
                            completeList.Add(objTimeKeeperCompletesInfo);
                        }
                        else // Không tồng tại danh sách OT
                        {
                            objTimeKeeperCompletesInfo = new HRTimeKeeperCompletesInfo();
                            //Lay ngay cham cong là ngày trước OT: listTemp[0].HRTimeKeeperDate
                            objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDate = completeList[completeList.Count - 1].HRTimeKeeperCompleteDate;
                            objTimeKeeperCompletesInfo.HRTimeKeeperCompletesEmployeeCardNo = completeList[completeList.Count - 1].HRTimeKeeperCompletesEmployeeCardNo;
                            objTimeKeeperCompletesInfo.HRTimeKeeperCompleteTimeCheck = completeList[completeList.Count - 1].HRTimeKeeperCompleteTimeCheck;
                            objTimeKeeperCompletesInfo.EmployeeName = employeesInfo.HREmployeeName;
                            objTimeKeeperCompletesInfo.ThName = completeList[completeList.Count - 1].ThName;
                            objTimeKeeperCompletesInfo.FK_HRMachineTimeKeeperID = completeList[completeList.Count - 1].FK_HRMachineTimeKeeperID;
                            objTimeKeeperCompletesInfo.FK_HRDepartmentID = employeesInfo.FK_HRDepartmentID;
                            objTimeKeeperCompletesInfo.FK_HRLevelID = employeesInfo.FK_HRLevelID;
                            objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDateCheck = completeList[completeList.Count - 1].HRTimeKeeperCompleteDateCheck;
                            objTimeKeeperCompletesInfo.HRTimeKeeperCompleteInOutMode = nextMode;
                            objTimeKeeperCompletesInfo.HRTimeKeeperCompleteInOutModeName = nextModeS;
                            objTimeKeeperCompletesInfo.SameDateTime = "False";
                            objTimeKeeperCompletesInfo.HREmployeePayrollFormulaName = employeesInfo.HREmployeePayrollFomularName;
                            objTimeKeeperCompletesInfo.EmployeeNo = employeesInfo.HREmployeeNo;

                            if (objTimeKeeperCompletesInfo.HRTimeKeeperCompleteInOutMode == 1)
                            {
                                if (CheckNotInOverTime(objTimeKeeperCompletesInfo, minRegisOvertime, false))
                                {
                                    objTimeKeeperCompletesInfo.NotInOverTime = "False";
                                }
                                if (CheckOverTimeAbsence(objTimeKeeperCompletesInfo, minRegisOvertime, false))
                                {
                                    objTimeKeeperCompletesInfo.OverTimeAbsence = "False";
                                }
                            }
                            completeList.Add(objTimeKeeperCompletesInfo);
                            HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo2 = (HRTimeKeeperCompletesInfo)objTimeKeeperCompletesInfo.Clone();
                            //if (objTimeKeeperCompletesInfo2 != null)
                            //entity.TimeKeeperCompleteBackupList.Add(objTimeKeeperCompletesInfo2);
                        }
                    }
                }

            }
            #endregion

            return completeList;
        }

        public HRTimeKeeperCompletesInfo GetOutModeTimeFromOverTimeList(List<HREmployeeOTsInfo> EmployeeOTList
                                                                        , List<HRTimeKeepersInfo> timeKeeperList
                                                                        , HRTimeKeepersInfo timeKeepersCompleteDate
                                                                        , HREmployeesInfo employeesInfo)
        {
            HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo;
            int nextMode = 0;
            string nextModeS = ManagerTimeKeeperLocalizedResources.In.ToString();
            // Check OT diff date
            HREmployeeOTsInfo objEmployeeOTDiffDateInsInfo = EmployeeOTList.Where(x => x.HREmployeeCardNumber == timeKeepersCompleteDate.HRTimeKeeperEmployeeCardNo
                                                                                        && x.HREmployeeOTDate.Date == timeKeepersCompleteDate.HRTimeKeeperTimeOut.Date).FirstOrDefault();
            if (objEmployeeOTDiffDateInsInfo != null)
            {
                nextMode = 1;
                nextModeS = ManagerTimeKeeperLocalizedResources.Out.ToString();
                //Lấy theo ngày kết thúc OT
                List<HRTimeKeepersInfo> listTempNextDate = timeKeeperList.Where(p => (p.HRTimeKeeperEmployeeCardNo == timeKeepersCompleteDate.HRTimeKeeperEmployeeCardNo &&
                        p.HRTimeKeeperDate.Date == objEmployeeOTDiffDateInsInfo.HREmployeeOTDateEnd.Date)).OrderBy(p => p.HRTimeKeeperTimeOut).ToList();

                if (listTempNextDate == null || listTempNextDate.Count == 0)
                {
                    List<HRTimeKeepersInfo> timeKeeperListreget = new List<HRTimeKeepersInfo>();
                    HRTimeKeepersController objTimeKeepersController = new HRTimeKeepersController();
                    DateTime dataFrom = Convert.ToDateTime(DateCalculateFromControl.EditValue);
                    DateTime dataTo = Convert.ToDateTime(DateCalculateToControl.EditValue).AddDays(2);
                    //int machineId = Convert.ToInt32(MachineTimeKeeperCalculateLookupEdit.EditValue);
                    int machineId = 0;
                    int departmentID = Convert.ToInt32(DepartmentLookupEdit.EditValue);
                    int departmentRoomID = Convert.ToInt32(DepartmentRoomLookupEdit.EditValue);
                    int employeePayrollFormulaID = 0;
                    if (PayrollFormulaSearchLookupEdit1.EditValue != null)
                        int.TryParse(PayrollFormulaSearchLookupEdit1.EditValue.ToString(), out employeePayrollFormulaID);
                    int employeeID = employeesInfo.HREmployeeID;
                    int departmentRoomGroupItemID = Convert.ToInt32(DepartmentRoomGroupItemID.EditValue);
                    int departmentRoomGroupItemTeamID = Convert.ToInt32(DepartmentRoomGroupTeamItemID.EditValue);
                    //   int employeeID = Convert.ToInt32(EmployeeSearchLookupEdit.EditValue == null ? "0" : EmployeeSearchLookupEdit.EditValue.ToString());
                    if (machineId != 0)
                    {
                        timeKeeperListreget = objTimeKeepersController.GetTimeKeeperByConditions(departmentID, departmentRoomID, departmentRoomGroupItemID, departmentRoomGroupItemTeamID, employeeID, employeePayrollFormulaID, machineId, dataFrom, dataTo);
                    }
                    else
                    {
                        timeKeeperListreget = objTimeKeepersController.GetTimeKeeperByConditions(departmentID, departmentRoomID, departmentRoomGroupItemID, departmentRoomGroupItemTeamID, employeeID, employeePayrollFormulaID, null, dataFrom, dataTo);
                    }

                    listTempNextDate = timeKeeperListreget.Where(p => (p.HRTimeKeeperEmployeeCardNo == timeKeepersCompleteDate.HRTimeKeeperEmployeeCardNo &&
                        p.HRTimeKeeperDate.Date == objEmployeeOTDiffDateInsInfo.HREmployeeOTDateEnd.Date)).OrderBy(p => p.HRTimeKeeperTimeOut).ToList();
                }
                //if (listTempNextDate != null && listTempNextDate.Count >= 0)
                else
                {
                    objTimeKeeperCompletesInfo = new HRTimeKeeperCompletesInfo();
                    //Lay ngay cham cong là ngày trước OT: listTemp[0].HRTimeKeeperDate
                    objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDate = timeKeepersCompleteDate.HRTimeKeeperDate;
                    objTimeKeeperCompletesInfo.HRTimeKeeperCompletesEmployeeCardNo = listTempNextDate[0].HRTimeKeeperEmployeeCardNo;
                    objTimeKeeperCompletesInfo.HRTimeKeeperCompleteTimeCheck = listTempNextDate[0].HRTimeKeeperTimeOut;
                    objTimeKeeperCompletesInfo.EmployeeName = employeesInfo.HREmployeeName;
                    objTimeKeeperCompletesInfo.ThName = GetThName(listTempNextDate[0].HRTimeKeeperDate);
                    objTimeKeeperCompletesInfo.FK_HRMachineTimeKeeperID = listTempNextDate[0].FK_HRMachineTimeKeeperID;
                    objTimeKeeperCompletesInfo.FK_HRDepartmentID = employeesInfo.FK_HRDepartmentID;
                    objTimeKeeperCompletesInfo.FK_HRLevelID = employeesInfo.FK_HRLevelID;
                    objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDateCheck = listTempNextDate[0].HRTimeKeeperTimeOut;
                    objTimeKeeperCompletesInfo.FK_HRTimeKeeperID = listTempNextDate[0].HRTimeKeeperID;

                    objTimeKeeperCompletesInfo.HRTimeKeeperCompleteInOutMode = nextMode;
                    objTimeKeeperCompletesInfo.HRTimeKeeperCompleteInOutModeName = nextModeS;

                    objTimeKeeperCompletesInfo.HREmployeePayrollFormulaName = employeesInfo.HREmployeePayrollFomularName;
                    objTimeKeeperCompletesInfo.EmployeeNo = employeesInfo.HREmployeeNo;

                    return objTimeKeeperCompletesInfo;
                }

            }
            return null;

        }
        public bool CheckExistConvertTimeKeeperComplete(HRTimeKeepersInfo objTimeKeepersInfo, List<HRTimeKeeperCompletesInfo> timeKeeperCompleteList)
        {
            bool result = false;
            HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo = timeKeeperCompleteList.Where(x => x.FK_HRTimeKeeperID == objTimeKeepersInfo.HRTimeKeeperID).FirstOrDefault();
            if (objTimeKeeperCompletesInfo != null && objTimeKeeperCompletesInfo.FK_HRTimeKeeperID > 0)
            {
                result = true;
            }
            return result;
        }
        private bool Check(List<HRTimeKeepersInfo> timeKeeperList, int machine, DateTime date)
        {
            foreach (HRTimeKeepersInfo item in timeKeeperList)
            {
                if (item.FK_HRMachineTimeKeeperID == machine && item.HRTimeKeeperDate.Date == date.Date)
                    return true;
            }
            return false;
        }
        private bool CheckDataComplete(List<HRTimeKeeperCompletesInfo> timeKeeperCompleteList, int machine, DateTime date, string employeeCardNo)
        {
            foreach (HRTimeKeeperCompletesInfo item in timeKeeperCompleteList)
            {
                if (item.FK_HRMachineTimeKeeperID == machine && item.HRTimeKeeperCompleteDate.Date == date.Date && item.HRTimeKeeperCompletesEmployeeCardNo == employeeCardNo)
                    return true;
            }
            return false;
        }
        private int SetAllUserInfo4AllMachine()
        {
            HRMachineTimeKeepersController objHRMachineTimeKeepersController = new HRMachineTimeKeepersController();
            List<HRMachineTimeKeepersInfo> list = objHRMachineTimeKeepersController.GetAllObjectList();
            HREmployeesController objEmployeesController = new HREmployeesController();
            List<HREmployeesInfo> listEmployee = objEmployeesController.GetEmployeeList(null, null, null);
            int count = 0;
            int customerID = Convert.ToInt32(CustomerLookupEditControl.EditValue);
            if (customerID == 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    HRMachineTimeKeepersInfo objMachineTimeKeepersInfo = list[i];
                    objMachineTimeKeepersInfo = Connect(objMachineTimeKeepersInfo);
                    if (objMachineTimeKeepersInfo.HRMachineTimeKeeperIsConnected == true)
                    {
                        foreach (HREmployeesInfo objEmployeesInfo in listEmployee)
                        {
                            if (SetUserInfo(objMachineTimeKeepersInfo, objEmployeesInfo))
                                count++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kết nối tới máy chấm công " + objMachineTimeKeepersInfo.HRMachineTimeKeeperName + " không thành công", "Lỗi kết nối");
                    }
                }
            }
            else
            {
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(customerID);
                foreach (HRMachineTimeKeepersInfo objMachineTimeKeepersInfo in list)
                {
                    if (SetUserInfo(objMachineTimeKeepersInfo, objEmployeesInfo))
                        count++;
                }
            }
            return count;
        }
        private int SetAllUserInfoPerMachine(HRMachineTimeKeepersInfo objMachineTimeKeepersInfo)
        {

            int count = 0;
            HREmployeesController objEmployeesController = new HREmployeesController();
            int customerID = Convert.ToInt32(CustomerLookupEditControl.EditValue);
            int machineTo = Convert.ToInt32(MachineTimeKeeperToLookupEdit.EditValue);
            HRMachineTimeKeepersController objMachineTimeKeepersController = new HRMachineTimeKeepersController();
            HRMachineTimeKeepersInfo MachineTimeKeepersInfoTo = null;
            if (machineTo > 0)
            {
                MachineTimeKeepersInfoTo = (HRMachineTimeKeepersInfo)objMachineTimeKeepersController.GetObjectByID(machineTo);
            }
            if (customerID == 0)
            {
                //objMachineTimeKeepersInfo.CZKEMMachine.SSR_SetUserTmpStr(
                //objMachineTimeKeepersInfo.CZKEMMachine.SSR_GetUserTmpStr(
                //objMachineTimeKeepersInfo.CZKEMMachine.SSR_GetAllUserInfo(
                //objMachineTimeKeepersInfo.CZKEMMachine.GetAllUserID(
                //List<HREmployeesInfo> listEmployee = objEmployeesController.GetEmployeeList(null, null, null);
                //foreach (HREmployeesInfo objEmployeesInfo in listEmployee)
                //{
                //    if (SetUserInfo(objMachineTimeKeepersInfo, objEmployeesInfo))
                //        count++;
                //}
                string cardNo = string.Empty;
                string employeeName = string.Empty;
                string employeePass = string.Empty;
                int level = 0;
                bool enable = true;

                int lenght = 0;
                string templete = string.Empty;
                if (machineTo > 0)
                {
                    if (MachineTimeKeepersInfoTo != null)
                    {
                        MachineTimeKeepersInfoTo = Connect(MachineTimeKeepersInfoTo);
                        if (MachineTimeKeepersInfoTo.HRMachineTimeKeeperIsConnected)
                        {
                            if (objMachineTimeKeepersInfo.CZKEMMachine.ReadAllUserID(objMachineTimeKeepersInfo.HRMachineTimeKeeperID))
                            {
                                if (objMachineTimeKeepersInfo.CZKEMMachine.ReadAllTemplate(objMachineTimeKeepersInfo.HRMachineTimeKeeperID))
                                {
                                    while (objMachineTimeKeepersInfo.CZKEMMachine.SSR_GetAllUserInfo(objMachineTimeKeepersInfo.HRMachineTimeKeeperID, out cardNo, out employeeName, out employeePass, out level, out enable))
                                    {
                                        //set info
                                        if (MachineTimeKeepersInfoTo.CZKEMMachine.SSR_SetUserInfo(MachineTimeKeepersInfoTo.HRMachineTimeKeeperID, cardNo, employeeName, employeePass, level, enable))
                                        {
                                            count++;
                                        }
                                        //set templete
                                        if (objMachineTimeKeepersInfo.CZKEMMachine.SSR_GetUserTmpStr(MachineTimeKeepersInfoTo.HRMachineTimeKeeperID, cardNo, 15, out templete, out lenght))
                                        {
                                            MachineTimeKeepersInfoTo.CZKEMMachine.SSR_SetUserTmpStr(MachineTimeKeepersInfoTo.HRMachineTimeKeeperID, cardNo, 15, templete);
                                        }
                                    }
                                }
                            }
                        }
                        else
                            MessageBox.Show("Lỗi kết nối đến máy chấm công " + MachineTimeKeepersInfoTo.HRMachineTimeKeeperName, "Lỗi kết nối");
                    }
                }
            }
            else
            {

                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(customerID);
                string templete2 = string.Empty;
                int lenght2 = 0;
                MachineTimeKeepersInfoTo = Connect(MachineTimeKeepersInfoTo);
                if (MachineTimeKeepersInfoTo.HRMachineTimeKeeperIsConnected)
                {
                    if (MachineTimeKeepersInfoTo.CZKEMMachine.SSR_SetUserInfo(MachineTimeKeepersInfoTo.HRMachineTimeKeeperID, objEmployeesInfo.HREmployeeCardNumber, ConvertVN(objEmployeesInfo.HREmployeeName), string.Empty, 0, true))
                    {
                        if (objMachineTimeKeepersInfo.CZKEMMachine.SSR_GetUserTmpStr(MachineTimeKeepersInfoTo.HRMachineTimeKeeperID, objEmployeesInfo.HREmployeeCardNumber, 15, out templete2, out lenght2))
                        {
                            MachineTimeKeepersInfoTo.CZKEMMachine.SSR_SetUserTmpStr(MachineTimeKeepersInfoTo.HRMachineTimeKeeperID, objEmployeesInfo.HREmployeeCardNumber, 15, templete2);
                            count++;
                        }
                    }
                }
                else
                    MessageBox.Show("Lỗi kết nối đến máy chấm công " + MachineTimeKeepersInfoTo.HRMachineTimeKeeperName, "Lỗi kết nối");
            }
            return count;
        }
        private bool SetUserInfo(HRMachineTimeKeepersInfo objMachineTimeKeepersInfo, HREmployeesInfo objEmployeesInfo)
        {
            bool checkUpdate = false;
            if (!objMachineTimeKeepersInfo.HRMachineTimeKeeperIsConnected || objMachineTimeKeepersInfo.CZKEMMachine == null)
                objMachineTimeKeepersInfo = Connect(objMachineTimeKeepersInfo);
            if (objEmployeesInfo.HREmployeeID > 0)
            {
                objEmployeesInfo.HREmployeeName = ConvertVN(objEmployeesInfo.HREmployeeName);
                checkUpdate = objMachineTimeKeepersInfo.CZKEMMachine.SSR_SetUserInfo(objMachineTimeKeepersInfo.HRMachineTimeKeeperID, objEmployeesInfo.HREmployeeCardNumber.ToString(), objEmployeesInfo.HREmployeeName, string.Empty, 0, true);
            }
            return checkUpdate;
        }

        public void SaveData(List<HRTimeKeepersInfo> timeKeeperList, bool import)
        {
            BOSProgressBar.Start("Đang lưu dữ liệu...");
            ManagerTimeKeeperEntities entity = (ManagerTimeKeeperEntities)CurrentModuleEntity;
            DateTime dateFrom = Convert.ToDateTime(DateFromControl.EditValue);
            DateTime dateTo = Convert.ToDateTime(DateToControl.EditValue);
            HRTimeKeepersController objTimeKeepersController = new HRTimeKeepersController();
            int index = MachineTimeKeeperTypeRadioGroup.SelectedIndex;
            List<HRTimeKeepersInfo> timeKeepersListCheck = new List<HRTimeKeepersInfo>();
            HRTimeKeepersInfo objTimeKeepersInfoCheck = new HRTimeKeepersInfo();

            //if (index == 0)
            //{
            //    if (CurenMachineTimeKeeper == null || CurenMachineTimeKeeper.HRMachineTimeKeeperIP == string.Empty)
            //    {
            //        CurenMachineTimeKeeper = (HRMachineTimeKeepersInfo)MachineTimeKeeperControl.MainView.GetRow(0);
            //        if (!import)
            //            objTimeKeepersController.DeleteDataByMachineAndByDate(CurenMachineTimeKeeper.HRMachineTimeKeeperID, dateFrom.Date, dateTo.Date);
            //    }

            //}

            if (!import)
            {
                if (index == 0)
                {
                    if (CurenMachineTimeKeeper == null || CurenMachineTimeKeeper.HRMachineTimeKeeperIP == string.Empty)
                    {
                        CurenMachineTimeKeeper = (HRMachineTimeKeepersInfo)MachineTimeKeeperControl.MainView.GetRow(0);
                    }
                    timeKeepersListCheck = (List<HRTimeKeepersInfo>)objTimeKeepersController.GetTimeKeeperByMachineAndDate(CurenMachineTimeKeeper.HRMachineTimeKeeperID, dateFrom.Date, dateTo.Date);
                    if (timeKeepersListCheck != null)
                    {
                        timeKeepersListCheck.ForEach(o =>
                        {
                            objTimeKeepersInfoCheck = CheckDataTimeKeepers(timeKeeperList, o.FK_HRMachineTimeKeeperID, o.HRTimeKeeperDate, o.HRTimeKeeperDateCheck, o.HRTimeKeeperEmployeeCardNo);
                            if (objTimeKeepersInfoCheck != null)
                            {
                                timeKeeperList.Remove(objTimeKeepersInfoCheck);
                            }
                        });
                    }
                }
                else
                {
                    HRMachineTimeKeepersController objHRMachineTimeKeepersController = new HRMachineTimeKeepersController();
                    List<HRMachineTimeKeepersInfo> list = objHRMachineTimeKeepersController.GetAllObjectList();
                    List<HRTimeKeepersInfo> currentTimeKeeperList = new List<HRTimeKeepersInfo>();
                    foreach (HRMachineTimeKeepersInfo item in list)
                    {
                        timeKeepersListCheck = (List<HRTimeKeepersInfo>)objTimeKeepersController.GetTimeKeeperByMachineAndDate(item.HRMachineTimeKeeperID, dateFrom.Date, dateTo.Date);
                        timeKeepersListCheck.ForEach(o =>
                        {
                            objTimeKeepersInfoCheck = CheckDataTimeKeepers(timeKeeperList, o.FK_HRMachineTimeKeeperID, o.HRTimeKeeperDate, o.HRTimeKeeperDateCheck, o.HRTimeKeeperEmployeeCardNo);
                            if (objTimeKeepersInfoCheck != null)
                            {
                                timeKeeperList.Remove(objTimeKeepersInfoCheck);
                            }
                        });
                    }
                }
            }
            else
            {
                List<HRTimeKeepersInfo> timeKeeperList2 = new List<HRTimeKeepersInfo>();
                foreach (HRTimeKeepersInfo item in timeKeeperList)
                {
                    if (!Check(timeKeeperList2, item.FK_HRMachineTimeKeeperID, item.HRTimeKeeperDate))
                    {
                        timeKeeperList2.Add(item);
                    }
                }
                foreach (HRTimeKeepersInfo item in timeKeeperList2)
                {
                    objTimeKeepersController = new HRTimeKeepersController();
                    int check = objTimeKeepersController.CheckExistData(item.FK_HRMachineTimeKeeperID, item.HRTimeKeeperDate);
                    if (check > 0)
                    {
                        objTimeKeepersController.DeleteData(item.FK_HRMachineTimeKeeperID, item.HRTimeKeeperDate);
                    }
                }
            }
            entity.SaveData(timeKeeperList);
        }

        private HRTimeKeepersInfo CheckDataTimeKeepers(List<HRTimeKeepersInfo> timeKeeperList, int machine, DateTime date, DateTime dateCheck, string employeeCardNo)
        {
            foreach (HRTimeKeepersInfo item in timeKeeperList)
            {
                if (item.FK_HRMachineTimeKeeperID == machine && item.HRTimeKeeperDate.Date == date.Date
                    && item.HRTimeKeeperEmployeeCardNo == employeeCardNo && item.HRTimeKeeperDateCheck == dateCheck)
                    return item;
            }
            return null;
        }

        private HRTimeKeepersInfo ConvertFromLine(string[] parts)
        {

            DateTime dateTime = Convert.ToDateTime(parts[1]);
            DateTime Date = dateTime.Date;
            HRTimeKeepersInfo objHRTimeKeepersInfo = new HRTimeKeepersInfo(parts[0], Date, dateTime, Convert.ToInt32(parts[3]), Convert.ToInt32(parts[2]), 0);
            return objHRTimeKeepersInfo;
        }
        public void ReadFileTxt()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            string fileName = string.Empty;
            dialog.Filter = "dat files (*.dat)|*.dat|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fileName = dialog.FileName;
                // of the array is one line of the file. 
                string[] lines = System.IO.File.ReadAllLines(fileName);
                HRTimeKeepersInfo objTimeKeepersInfo;
                List<HRTimeKeepersInfo> timeKeeperList = new List<HRTimeKeepersInfo>();
                if (lines != null && lines.Length > 0)
                {
                    char[] delimiters;
                    for (int i = 1; i < lines.Length; i++)
                    {
                        delimiters = new char[] { '\t', };
                        string[] parts = lines[i].Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                        objTimeKeepersInfo = ConvertFromLine(parts);
                        timeKeeperList.Add(objTimeKeepersInfo);
                    }
                    TimeKeeperCompletesGridControl.DataSource = timeKeeperList;
                    SaveData(timeKeeperList, true);
                    MessageBox.Show(MachineTimeKeeperLocalizedResources.SaveSuccess, "Lưu dữ liệu vào hệ thống");
                    //timeKeeperList = DistinctList(timeKeeperList);
                    //List<HRTimeKeeperCompletesInfo> listComplate = ConvertTimeKeeperListToComplete(timeKeeperList);
                    //TimeKeeperCompletesGridControl.DataSource = listComplate;
                }
            }
        }

        public void ConnectAll()
        {
            HRMachineTimeKeepersController objHRMachineTimeKeepersController = new HRMachineTimeKeepersController();
            List<HRMachineTimeKeepersInfo> list = objHRMachineTimeKeepersController.GetAllObjectList();
            foreach (HRMachineTimeKeepersInfo item in list)
            {
                Connect(item);
            }
        }

        public void DisConnectAll()
        {
            List<HRMachineTimeKeepersInfo> listConnectedBackup = MachineTimeKeeperSConnectedList.ToList();
            foreach (HRMachineTimeKeepersInfo objMachineTimeKeepersInfo in listConnectedBackup)
            {
                DisConnect(objMachineTimeKeepersInfo);
            }
        }

        public void UpdateEmplyeesToMachineTimeKeeper()
        {

            BOSProgressBar.Start("Đang đồng bộ thông tin nhân viên");
            int machineID = Convert.ToInt32(MachineTimeKeeperLookupEdit.EditValue);
            int count = 0;

            //if (machineID == 0)
            //{
            //    count = SetAllUserInfo4AllMachine();

            //}
            //else
            //{
            HRMachineTimeKeepersController objMachineTimeKeepersController = new HRMachineTimeKeepersController();
            HRMachineTimeKeepersInfo objMachineTimeKeepersInfo = (HRMachineTimeKeepersInfo)objMachineTimeKeepersController.GetObjectByID(machineID);
            objMachineTimeKeepersInfo = Connect(objMachineTimeKeepersInfo);
            if (objMachineTimeKeepersInfo.HRMachineTimeKeeperIsConnected == true)
            {
                count = SetAllUserInfoPerMachine(objMachineTimeKeepersInfo);
                MessageBox.Show("Đã câp nhật " + count.ToString() + " nhân viên cho máy chấm công " + objMachineTimeKeepersInfo.HRMachineTimeKeeperName, MachineTimeKeeperLocalizedResources.UpDateEmployeeCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //objMachineTimeKeepersInfo.CZKEMMachine.EnableDevice(objMachineTimeKeepersInfo.HRMachineTimeKeeperID, true);
            }
            else
            {
                MessageBox.Show("Kết nối đến máy chấm công " + objMachineTimeKeepersInfo.HRMachineTimeKeeperName + " không thành công", "Lỗi kết nối");
            }
            //}
            BOSProgressBar.Close();

        }
        public void UpdateTeamplateOfEmplyeesToMachineTimeKeeper()
        {
            BOSProgressBar.Start("Đang đồng bộ vân tay");
            int machineID = Convert.ToInt32(MachineTimeKeeperLookupEdit2.EditValue);
            int count = 0;

            if (machineID == 0)
            {
                count = SetAllTemplateUser4AllMachine();
            }
            else
            {
                HRMachineTimeKeepersController objMachineTimeKeepersController = new HRMachineTimeKeepersController();
                HRMachineTimeKeepersInfo objMachineTimeKeepersInfo = (HRMachineTimeKeepersInfo)objMachineTimeKeepersController.GetObjectByID(machineID);
                count = SetAllTamplateUserPerMachine(objMachineTimeKeepersInfo);
                MessageBox.Show("Đã câp nhật " + count.ToString() + " vân tay cho máy chấm công " + objMachineTimeKeepersInfo.HRMachineTimeKeeperName, MachineTimeKeeperLocalizedResources.UpDateEmployeeCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            BOSProgressBar.Close();
        }
        private Hashtable getALLTamplate()
        {
            HRMachineTimeKeepersController objMachineTimeKeepersController = new HRMachineTimeKeepersController();
            HRMachineTimeKeepersInfo objMachineTimeKeepersInfo = new HRMachineTimeKeepersInfo();
            int lenght = 0;
            int flat;
            string dataTamplate = string.Empty;
            HREmployeesController objEmployeesController = new HREmployeesController();
            List<HREmployeesInfo> listEmployee = objEmployeesController.GetAllEmployees();
            List<HRMachineTimeKeepersInfo> listMachine = objMachineTimeKeepersController.GetAllObjectList();
            bool get = false;
            //bool set = false;
            //int count = 0;
            Hashtable hashTemplate = new Hashtable();
            //connect
            for (int j = 0; j < listMachine.Count; j++)
            {
                objMachineTimeKeepersInfo = listMachine[j];
                objMachineTimeKeepersInfo = Connect(objMachineTimeKeepersInfo);
            }
            int customerID = Convert.ToInt32(CustomerLookupEditControl2.EditValue);
            if (customerID == 0)
            {
                foreach (HREmployeesInfo employee in listEmployee)
                {
                    foreach (HRMachineTimeKeepersInfo machine in listMachine)
                    {
                        get = machine.CZKEMMachine.SSR_GetUserTmpStr(machine.HRMachineTimeKeeperID, employee.HREmployeeCardNumber, 15, out dataTamplate, out lenght);
                        if (get && dataTamplate != string.Empty && dataTamplate != null)
                        {
                            if (!hashTemplate.ContainsKey(employee.HREmployeeCardNumber))
                            {
                                hashTemplate.Add(employee.HREmployeeCardNumber, dataTamplate);
                            }
                            dataTamplate = string.Empty;
                        }
                    }
                }
            }
            else
            {
                HREmployeesInfo objHREmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(customerID);
                foreach (HRMachineTimeKeepersInfo machine in listMachine)
                {
                    get = machine.CZKEMMachine.SSR_GetUserTmpStr(machine.HRMachineTimeKeeperID, objHREmployeesInfo.HREmployeeCardNumber, 15, out dataTamplate, out lenght);
                    if (get && dataTamplate != string.Empty && dataTamplate != null)
                    {
                        if (!hashTemplate.ContainsKey(objHREmployeesInfo.HREmployeeCardNumber))
                        {
                            hashTemplate.Add(objHREmployeesInfo.HREmployeeCardNumber, dataTamplate);
                        }
                        dataTamplate = string.Empty;
                    }
                }


            }
            return hashTemplate;
        }
        private int SetAllTamplateUserPerMachine(HRMachineTimeKeepersInfo objMachineTimeKeepersInfo)
        {
            Hashtable hashTemplate = getALLTamplate();
            return SetAllTamplateUserPerMachine(hashTemplate, objMachineTimeKeepersInfo);
        }
        private int SetAllTamplateUserPerMachine(Hashtable hashTemplate, HRMachineTimeKeepersInfo objMachineTimeKeepersInfo)
        {
            IDictionaryEnumerator enumz = hashTemplate.GetEnumerator();
            if (objMachineTimeKeepersInfo.CZKEMMachine == null && objMachineTimeKeepersInfo.HRMachineTimeKeeperIsConnected == false)
                objMachineTimeKeepersInfo = Connect(objMachineTimeKeepersInfo);
            string dataTamplate = string.Empty;
            int count = 0;
            bool set = false;
            while (enumz.MoveNext())
            {
                set = objMachineTimeKeepersInfo.CZKEMMachine.SSR_SetUserTmpStr(objMachineTimeKeepersInfo.HRMachineTimeKeeperID, enumz.Key.ToString(), 15, enumz.Value.ToString());
                dataTamplate = string.Empty;
                if (set)
                {
                    count++;
                }
            }
            return count;
        }
        private int SetAllTemplateUser4AllMachine()
        {
            Hashtable hashTemplate = getALLTamplate();
            HRMachineTimeKeepersController objMachineTimeKeepersController = new HRMachineTimeKeepersController();
            List<HRMachineTimeKeepersInfo> machineTimeKeeperList = objMachineTimeKeepersController.GetAllObjectList();
            HRMachineTimeKeepersInfo MachineTimeKeepersInfo;
            for (int i = 0; i < machineTimeKeeperList.Count; i++)
            {
                MachineTimeKeepersInfo = machineTimeKeeperList[i];
                SetAllTamplateUserPerMachine(hashTemplate, MachineTimeKeepersInfo);
            }
            return 0;
        }
        public void InvalidateMachineTimeKeeperList()
        {
            ManagerTimeKeeperEntities entity = (ManagerTimeKeeperEntities)CurrentModuleEntity;
            HRMachineTimeKeepersController objMachineTimeKeepersController = new HRMachineTimeKeepersController();
            DataSet ds = objMachineTimeKeepersController.GetAllObjects();
            entity.MachineTimeKeeperList.Invalidate(ds);
        }
        public void ChangeSelectedMachine(int row)
        {
            if (row > 0)
            {
                CurenMachineTimeKeeper = (HRMachineTimeKeepersInfo)MachineTimeKeeperControl.MainView.GetRow(row);
            }
            else
            {
                CurenMachineTimeKeeper = (HRMachineTimeKeepersInfo)MachineTimeKeeperControl.MainView.GetRow(0);
            }
        }
        public string ConvertVN(string chucodau)
        {
            const string FindText = "áàảãạâấầẩẫậăắằẳẵặđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵÁÀẢÃẠÂẤẦẨẪẬĂẮẰẲẴẶĐÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴ";
            const string ReplText = "aaaaaaaaaaaaaaaaadeeeeeeeeeeeiiiiiooooooooooooooooouuuuuuuuuuuyyyyyAAAAAAAAAAAAAAAAADEEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOOOUUUUUUUUUUUYYYYY";
            int index = -1;
            char[] arrChar = FindText.ToCharArray();
            while ((index = chucodau.IndexOfAny(arrChar)) != -1)
            {
                int index2 = FindText.IndexOf(chucodau[index]);
                chucodau = chucodau.Replace(chucodau[index], ReplText[index2]);
            }
            return chucodau;
        }
        public void ChangeCompleteDate(HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo)
        {
            if (objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDate.Date != objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDateCheck.Date)
            {
                objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDateCheck = DateTime.ParseExact(objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDate.ToString("dd/MM/yyyy") + " "
                                     + objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDateCheck.ToString("HH:mm:ss"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                objTimeKeeperCompletesInfo.HRTimeKeeperCompleteTimeCheck = DateTime.ParseExact(objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDate.ToString("dd/MM/yyyy") + " "
                                     + objTimeKeeperCompletesInfo.HRTimeKeeperCompleteTimeCheck.ToString("HH:mm:ss"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            }
        }
        public void UpdateID()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            string fileName = string.Empty;
            dialog.Filter = "dat files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fileName = dialog.FileName;
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = (Microsoft.Office.Interop.Excel._Worksheet)xlWorkbook.Sheets[1];
                Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;
                HREmployeesController objEmployeesController = new HREmployeesController();
                List<HREmployeesInfo> list = objEmployeesController.GetAllEmployees();
                Hashtable hash = new Hashtable();
                string name = string.Empty;
                string iD = string.Empty;
                for (int i = 3; i <= rowCount; i++)
                {
                    name = (string)(xlRange.Cells[i, 2] as Microsoft.Office.Interop.Excel.Range).Value2;
                    iD = string.Format("{0}", (xlRange.Cells[i, 4] as Microsoft.Office.Interop.Excel.Range).Value2);
                    try
                    {
                        hash.Add(name, iD);
                    }
                    catch (Exception ex)
                    {


                    }

                }
                HREmployeesInfo objEmployeesInfo;
                for (int i = 0; i < list.Count; i++)
                {
                    objEmployeesInfo = list[i];
                    if (hash.ContainsKey(objEmployeesInfo.HREmployeeName))
                    {
                        objEmployeesInfo.HREmployeeCardNumber = (string)hash[objEmployeesInfo.HREmployeeName];
                    }
                }
                BOSList<HREmployeesInfo> TimeKeeperList = new BOSList<HREmployeesInfo>(null, string.Empty, TableName.HREmployeesTableName);
                TimeKeeperList.AddRange(list);
                TimeKeeperList.SaveItemObjects();
            }
        }

        public void ClearAllData()
        {
            BOSProgressBar.Start("Đang xóa dữ liệu chấm công trên máy chấm công");
            int machineID = Convert.ToInt32(MachineTimeKeeperLookupEdit3.EditValue);
            Exception error = null;
            try
            {
                if (machineID > 0)
                {
                    HRMachineTimeKeepersController objMachineTimeKeepersController = new HRMachineTimeKeepersController();
                    HRMachineTimeKeepersInfo objHRMachineTimeKeepersInfo = (HRMachineTimeKeepersInfo)objMachineTimeKeepersController.GetObjectByID(machineID);
                    if (MessageBox.Show("Bạn muốn xóa dữ liệu chấm công của " + objHRMachineTimeKeepersInfo.HRMachineTimeKeeperName + " ?", "Xóa dữ liệu chấm công", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        objHRMachineTimeKeepersInfo = Connect(objHRMachineTimeKeepersInfo);
                        if (objHRMachineTimeKeepersInfo.HRMachineTimeKeeperIsConnected == true)
                            objHRMachineTimeKeepersInfo.CZKEMMachine.ClearSLog(objHRMachineTimeKeepersInfo.HRMachineTimeKeeperID);
                        else
                            MessageBox.Show("Không thể kết nối tới máy chấm công " + objHRMachineTimeKeepersInfo.HRMachineTimeKeeperName, "Lỗi kết nối máy chấm công");
                    }
                }
                else
                {
                    if (MessageBox.Show("Bạn muốn xóa dữ liệu chấm công của tất cả các máy ?", "Xóa hết dữ liệu chấm công", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        HRMachineTimeKeepersController objMachineTimeKeepersController = new HRMachineTimeKeepersController();
                        List<HRMachineTimeKeepersInfo> machineList = objMachineTimeKeepersController.GetAllObjectList();
                        HRMachineTimeKeepersInfo objHRMachineTimeKeepersInfo;

                        for (int i = 0; i < machineList.Count; i++)
                        {
                            objHRMachineTimeKeepersInfo = machineList[i];
                            objHRMachineTimeKeepersInfo = Connect(objHRMachineTimeKeepersInfo);
                            if (objHRMachineTimeKeepersInfo.HRMachineTimeKeeperIsConnected == true)
                            {
                                objHRMachineTimeKeepersInfo.CZKEMMachine.ClearSLog(objHRMachineTimeKeepersInfo.HRMachineTimeKeeperID);
                            }
                            else
                                MessageBox.Show("Không thể kết nối tới máy chấm công " + objHRMachineTimeKeepersInfo.HRMachineTimeKeeperName, "Lỗi kết nối máy chấm công");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex;
            }
            if (error != null)
            {
                MessageBox.Show("Có lỗi trong quá trình xóa dữ liệu chấm công", "Lỗi trong quá trình xóa dữ liệu");
            }
            else
            {
                MessageBox.Show("Đã xóa dữ liệu chấm công thành công", "Xóa dữ liệu chấm công");
            }
            BOSProgressBar.Close();
        }

        public void Export()
        {
            List<HRTimeKeepersInfo> list = LoadTimeKeeper();
            TimeKeeperCompletesGridControl.DataSource = list;
        }
        public List<HRTimeKeepersInfo> LoadTimeKeeper()
        {
            List<HRTimeKeepersInfo> timeEntries = new List<HRTimeKeepersInfo>();
            HRTimeKeepersController objTimeKeepersController = new HRTimeKeepersController();
            DateTime dataFrom = Convert.ToDateTime(DateFromControl.EditValue);
            DateTime dataTo = Convert.ToDateTime(DateToControl.EditValue);
            List<HRTimeKeepersInfo> list = (List<HRTimeKeepersInfo>)TimeKeeperCompletesGridControl.DataSource;
            BOSProgressBar.Start("Đang xử lý dữ liệu");
            Hashtable listEmployee = new Hashtable();
            foreach (HRTimeKeepersInfo item in list)
            {
                if (!listEmployee.ContainsKey(item.HRTimeKeeperEmployeeCardNo))
                {
                    listEmployee.Add(item.HRTimeKeeperEmployeeCardNo, item.HRTimeKeeperEmployeeNo);
                }
            }
            IDictionaryEnumerator enumz = listEmployee.GetEnumerator();
            string dataTamplate = string.Empty;
            string cardNo = string.Empty;
            DateTime from = dataFrom.Date;
            DateTime to = dataTo.Date;
            while (from <= to)
            {
                while (enumz.MoveNext())
                {
                    cardNo = enumz.Key.ToString();
                    List<HRTimeKeepersInfo> listTemp = DistinctList(list.Where(p => (p.HRTimeKeeperEmployeeCardNo == cardNo &&
                            p.HRTimeKeeperTimeOut.Date == from.Date)).OrderBy(p => p.HRTimeKeeperTimeOut).ToList());
                    if (listTemp.Count == 1)
                    {
                        //in
                        HRTimeKeepersInfo objTimeKeepersInfo = new HRTimeKeepersInfo();
                        objTimeKeepersInfo.HRTimeKeeperEmployeeCardNo = cardNo;
                        objTimeKeepersInfo.HRTimeKeeperDate = from;
                        objTimeKeepersInfo.HRTimeKeeperTimeOut = listTemp[0].HRTimeKeeperTimeOut; ;//listTemp[j + 1].HRTimeKeeperTimeOut;
                        objTimeKeepersInfo.HRTimeKeeperTimeInOutMode = 0;
                        objTimeKeepersInfo.HRTimeKeeperTimeInOutModeName = "Vào";
                        objTimeKeepersInfo.ThName = GetThName(from);
                        timeEntries.Add(objTimeKeepersInfo);
                        //out
                        objTimeKeepersInfo = new HRTimeKeepersInfo();
                        objTimeKeepersInfo.HRTimeKeeperEmployeeCardNo = cardNo;
                        objTimeKeepersInfo.HRTimeKeeperDate = from;
                        objTimeKeepersInfo.HRTimeKeeperTimeOut = from;
                        objTimeKeepersInfo.HRTimeKeeperTimeInOutMode = 1;
                        objTimeKeepersInfo.HRTimeKeeperTimeInOutModeName = "Ra";
                        objTimeKeepersInfo.ThName = GetThName(from);
                        timeEntries.Add(objTimeKeepersInfo);
                    }
                    for (int j = 0; j < listTemp.Count - 1; j += 2)
                    {
                        //in
                        HRTimeKeepersInfo objTimeKeepersInfo = new HRTimeKeepersInfo();
                        objTimeKeepersInfo.HRTimeKeeperEmployeeCardNo = cardNo;
                        objTimeKeepersInfo.HRTimeKeeperDate = from;
                        objTimeKeepersInfo.HRTimeKeeperTimeOut = listTemp[j].HRTimeKeeperTimeOut; ;//listTemp[j + 1].HRTimeKeeperTimeOut;
                        objTimeKeepersInfo.HRTimeKeeperTimeInOutMode = 0;
                        objTimeKeepersInfo.HRTimeKeeperTimeInOutModeName = "Vào";
                        objTimeKeepersInfo.ThName = GetThName(from);
                        timeEntries.Add(objTimeKeepersInfo);
                        //out
                        objTimeKeepersInfo = new HRTimeKeepersInfo();
                        objTimeKeepersInfo.HRTimeKeeperEmployeeCardNo = cardNo;
                        objTimeKeepersInfo.HRTimeKeeperDate = from;
                        objTimeKeepersInfo.HRTimeKeeperTimeOut = listTemp[j + 1].HRTimeKeeperTimeOut;
                        objTimeKeepersInfo.HRTimeKeeperTimeInOutMode = 1;
                        objTimeKeepersInfo.HRTimeKeeperTimeInOutModeName = "Ra";
                        objTimeKeepersInfo.ThName = GetThName(from);
                        timeEntries.Add(objTimeKeepersInfo);
                    }
                }
                from = from.AddDays(1);
            }
            BOSProgressBar.Close();
            return timeEntries;
        }
        private bool CheckExist(List<HRTimeKeepersInfo> list, HRTimeKeepersInfo item)
        {
            foreach (HRTimeKeepersInfo objTimeKeepersInfo in list)
            {
                if (objTimeKeepersInfo.HRTimeKeeperEmployeeCardNo == item.HRTimeKeeperEmployeeCardNo && objTimeKeepersInfo.HRTimeKeeperDate == item.HRTimeKeeperDate &&
                    objTimeKeepersInfo.HRTimeKeeperTimeOut == item.HRTimeKeeperTimeOut)
                    return true;
            }
            return false;
        }
        private List<HRTimeKeepersInfo> DistinctList(List<HRTimeKeepersInfo> list)
        {
            List<HRTimeKeepersInfo> listResult = new List<HRTimeKeepersInfo>();
            foreach (HRTimeKeepersInfo item in list)
            {
                if (!CheckExist(listResult, item))
                {
                    listResult.Add(item);
                }
            }
            return listResult;
        }
        public void SaveDataComplete()
        {
            BOSProgressBar.Start("Đang cập nhật giờ chấm công");
            ManagerTimeKeeperEntities entity = (ManagerTimeKeeperEntities)CurrentModuleEntity;
            List<HRTimeKeeperCompletesInfo> timeKeeperCompleteList = (List<HRTimeKeeperCompletesInfo>)TimeKeeperCompletesGridControl.DataSource;
            HRTimeKeeperCompletesController objTimeKeepersController = new HRTimeKeeperCompletesController();
            List<string> list = new List<string>();
            HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo = timeKeeperCompleteList.Where(x => x.HRTimeKeeperCompleteDateCheck.Hour == 0 && x.HRTimeKeeperCompleteDateCheck.Minute == 0).FirstOrDefault();
            List<HRTimeKeeperCompletesInfo> timeKeeperList2 = new List<HRTimeKeeperCompletesInfo>();
            if (objTimeKeeperCompletesInfo != null && objTimeKeeperCompletesInfo.HRTimeKeeperCompletesEmployeeCardNo != string.Empty)
            {
                if (MessageBox.Show("Giờ vào/ra đang chứa giá trị 00:00", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    BOSProgressBar.Close();
                    return;
                }
            }
            DateTime dataFrom = Convert.ToDateTime(DateCalculateFromControl.EditValue);
            DateTime dataTo = Convert.ToDateTime(DateCalculateToControl.EditValue);
            bool isCancel = false;
            List<HRTimeKeeperCompletesInfo> listDataComplete = (List<HRTimeKeeperCompletesInfo>)TimeKeeperCompletesGridControl.DataSource;
            foreach (HRTimeKeeperCompletesInfo item in timeKeeperCompleteList)
            {

                bool isSameData = CheckSameTime(item, listDataComplete);
                if (isSameData)
                {
                    if (isCancel)
                        continue;
                    DialogResult dlgResult = MessageBox.Show(item.EmployeeName + "-" + item.HRTimeKeeperCompleteDate +
                                       Environment.NewLine + ": Giờ vào/ra trùng nhau, bạn có muốn tiếp tục không?"
                                       + Environment.NewLine + "Cancel: Lưu và không kiểm tra."
                                       + Environment.NewLine + "Yes: Lưu và kiểm tra"
                                       + Environment.NewLine + "No: không lưu và Thoát."
                                       , CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dlgResult == DialogResult.No)
                    {
                        BOSProgressBar.Close();
                        return;
                    }
                    else if (dlgResult == DialogResult.Cancel)
                    {
                        isCancel = true;
                        continue;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (!CheckDataComplete(timeKeeperList2, item.FK_HRMachineTimeKeeperID, item.HRTimeKeeperCompleteDate, item.HRTimeKeeperCompletesEmployeeCardNo))
                {
                    timeKeeperList2.Add(item);
                }
            }
            entity.TimeKeeperCompleteBackupList2.ForEach(x =>
            {
                if (entity.CompareList.Where(o => o.HRTimeKeeperCompleteDate == x.HRTimeKeeperCompleteDate
                                                            && o.HRTimeKeeperCompletesEmployeeCardNo == x.HRTimeKeeperCompletesEmployeeCardNo
                                                            && o.FK_HRTimeKeeperID == x.FK_HRTimeKeeperID).Count() > 0)
                {
                    HRTimeKeeperCompletesInfo objTimeKeeperCompletesOldValue = entity.CompareList.Where(o => o.HRTimeKeeperCompleteDate == x.HRTimeKeeperCompleteDate
                                                                                && o.HRTimeKeeperCompletesEmployeeCardNo == x.HRTimeKeeperCompletesEmployeeCardNo
                                                                                && o.FK_HRTimeKeeperID == x.FK_HRTimeKeeperID).FirstOrDefault();
                    AddBackupListBeforeChanged(objTimeKeeperCompletesOldValue);
                }
            });
            foreach (HRTimeKeeperCompletesInfo item in entity.CompareList)
            {
                int check = objTimeKeepersController.CheckExistData(item.FK_HRMachineTimeKeeperID, item.HRTimeKeeperCompleteDate, item.HRTimeKeeperCompletesEmployeeCardNo);
                if (check > 0)
                {
                    objTimeKeepersController.DeleteData(item.FK_HRMachineTimeKeeperID, item.HRTimeKeeperCompleteDate, item.HRTimeKeeperCompletesEmployeeCardNo);
                }
            }
            entity.SaveDataComplete(timeKeeperCompleteList);
            MessageBox.Show(MachineTimeKeeperLocalizedResources.SaveSuccess, "Lưu dữ liệu vào hệ thống");
            BOSProgressBar.Close();
        }

        public void CalculateData()
        {
            ManagerTimeKeeperEntities entity = (ManagerTimeKeeperEntities)CurrentModuleEntity;
            BOSProgressBar.Start("Đang xử lý dữ liệu");
            HRTimeKeepersController objTimeKeepersController = new HRTimeKeepersController();
            HREmployeeOTsController objEmployeeOTsController = new HREmployeeOTsController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            List<HRTimeKeepersInfo> keeperList;
            DateTime dataFrom = Convert.ToDateTime(DateCalculateFromControl.EditValue);
            DateTime dataTo = Convert.ToDateTime(DateCalculateToControl.EditValue);
            //int machineId = Convert.ToInt32(MachineTimeKeeperCalculateLookupEdit.EditValue);
            int machineId = 0;
            int departmentID = Convert.ToInt32(DepartmentLookupEdit.EditValue);
            int departmentRoomID = Convert.ToInt32(DepartmentRoomLookupEdit.EditValue);
            int employeeID = Convert.ToInt32(EmployeeSearchLookupEdit.EditValue);
            int employeePayrollFormulaID = 0;
            if (PayrollFormulaSearchLookupEdit1.EditValue != null)
                int.TryParse(PayrollFormulaSearchLookupEdit1.EditValue.ToString(), out employeePayrollFormulaID);
            AllEmployeeOTList = (List<HREmployeeOTsInfo>)objEmployeeOTsController.GetAllListOTByDate(dataFrom, dataTo);
            EmployeeWorkingShiftList = objEmployeesController.GetEmployeeWorkingShiftList();

            int departmentRoomGroupItemID = Convert.ToInt32(DepartmentRoomGroupItemID.EditValue);
            int departmentRoomGroupItemTeamID = Convert.ToInt32(DepartmentRoomGroupTeamItemID.EditValue);

            if (machineId != 0)
            {
                keeperList = objTimeKeepersController.GetTimeKeeperByConditions(departmentID, departmentRoomID, departmentRoomGroupItemID, departmentRoomGroupItemTeamID, employeeID, employeePayrollFormulaID, machineId, dataFrom, dataTo);
            }
            else
            {
                keeperList = objTimeKeepersController.GetTimeKeeperByConditions(departmentID, departmentRoomID, departmentRoomGroupItemID, departmentRoomGroupItemTeamID, employeeID, employeePayrollFormulaID, null, dataFrom, dataTo);
            }

            List<HRTimeKeeperCompletesInfo> listComplate = ConvertTimeKeeperListToComplete(keeperList);
            TimeKeeperCompletesGridControl.DataSource = listComplate;
            entity.CompareList.Clear();
            listComplate.ForEach(o =>
            {
                HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo = (HRTimeKeeperCompletesInfo)o.Clone();
                entity.CompareList.Add(objTimeKeeperCompletesInfo);
            });
            GridView view = (GridView)TimeKeeperCompletesGridControl.MainView;
            view.ExpandAllGroups();
            BOSProgressBar.Close();
        }

        public void GetDataCompleted()
        {
            ManagerTimeKeeperEntities entity = (ManagerTimeKeeperEntities)CurrentModuleEntity;
            DateTime dateFrom = Convert.ToDateTime(SearchFromDateView.EditValue);
            DateTime dateTo = Convert.ToDateTime(SearchToDateView.EditValue);
            int machineId = Convert.ToInt32(HRMachineTimeKeeperIDView.EditValue);
            HRTimeKeeperCompletesController objTimeKeeperCompletesController = new HRTimeKeeperCompletesController();
            List<HRTimeKeeperCompletesInfo> listDataComplete = new List<HRTimeKeeperCompletesInfo>();
            //List<HRTimeKeeperCompletesInfo> listDataComplete = objTimeKeeperCompletesController.GetDataCompletes(machineId, dateFrom, dateTo);
            int departmentID = Convert.ToInt32(DepartmentLookupEditView.EditValue);
            int departmentRoomID = Convert.ToInt32(DepartmentRoomLookupEditView.EditValue);
            int employeeID = Convert.ToInt32(EmployeeSearchLookupEditView.EditValue);
            int worShopID = Convert.ToInt32(MMWorkShopIDLookupEdit1.EditValue);
            int employeePayrollFormulaID = 0;
            if (PayrollFormulaSearchLookupEdit2.EditValue != null)
                int.TryParse(PayrollFormulaSearchLookupEdit2.EditValue.ToString(), out employeePayrollFormulaID);

            int departmentRoomGroupItemIDView = Convert.ToInt32(DepartmentRoomGroupItemIDView.EditValue);
            int departmentRoomGroupItemTeamIDView = Convert.ToInt32(DepartmentRoomGroupTeamItemIDView.EditValue);
            if (machineId != 0)
            {
                listDataComplete = objTimeKeeperCompletesController.GetDataCompleteByConditions(departmentID, departmentRoomID, departmentRoomGroupItemIDView, departmentRoomGroupItemTeamIDView, employeeID, employeePayrollFormulaID, machineId, dateFrom, dateTo, worShopID);
            }
            else
            {
                listDataComplete = objTimeKeeperCompletesController.GetDataCompleteByConditions(departmentID, departmentRoomID, departmentRoomGroupItemIDView, departmentRoomGroupItemTeamIDView, employeeID, employeePayrollFormulaID, null, dateFrom, dateTo, worShopID);
            }
            foreach (HRTimeKeeperCompletesInfo item in listDataComplete)
            {
                item.ThName = GetThName(item.HRTimeKeeperCompleteTimeCheck);
            }
            //HRTimeKeeperCompletesView.DataSource = listDataComplete;
            entity.TimeKeeperCompleteListView.Invalidate(listDataComplete);
            GridView view = (GridView)HRTimeKeeperCompletesView.MainView;
            view.ExpandAllGroups();
        }
        public void GetDataForTimeKeeperHistoryDetails()
        {
            ManagerTimeKeeperEntities entity = (ManagerTimeKeeperEntities)CurrentModuleEntity;
            int employeePayrollFormulaID = 0;
            if (PayrollFormulaSearchLookupEditView.EditValue != null)
                int.TryParse(PayrollFormulaSearchLookupEditView.EditValue.ToString(), out employeePayrollFormulaID);
            int employeeIDHistoryView = 0;
            if (HREmployeeIDHistoryView.EditValue != null)
                int.TryParse(HREmployeeIDHistoryView.EditValue.ToString(), out employeeIDHistoryView);
            DateTime searchHistoryFromDateView = Convert.ToDateTime(SearchHistoryFromDateView.EditValue);
            DateTime searchHistoryToDateView = Convert.ToDateTime(SearchHistoryToDateView.EditValue);
            int departmentIDHistoryView = 0;
            if (HRDepartmentIDHistoryView.EditValue != null)
                int.TryParse(HRDepartmentIDHistoryView.EditValue.ToString(), out departmentIDHistoryView);
            int departmentRoomIDHistoryView = 0;
            if (HRDepartmentRoomIDHistoryView.EditValue != null)
                int.TryParse(HRDepartmentRoomIDHistoryView.EditValue.ToString(), out departmentRoomIDHistoryView);

            TimeKeeperHistoryDetailsGridControl.DataSource = entity.GetDataForTimeKeeperHistoryDetailsGridControl(departmentIDHistoryView, departmentRoomIDHistoryView, employeeIDHistoryView, employeePayrollFormulaID, searchHistoryFromDateView, searchHistoryToDateView);
        }
        public bool CheckChangedTime(HRTimeKeeperHistoryDetailsInfo objTimeKeeperHistoryDetailsInfo)
        {
            if (objTimeKeeperHistoryDetailsInfo == null)
                return false;
            if ((objTimeKeeperHistoryDetailsInfo.HRTimeKeeperHistoryDate - objTimeKeeperHistoryDetailsInfo.HRTimeKeeperCompleteDate).Days > 2)
                return true;
            return false;
        }
        public bool CheckSameTime(HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo, List<HRTimeKeeperCompletesInfo> listDataComplete)
        {
            if (TimeKeeperCompletesGridControl == null)
                return false;
            bool result = false;
            //List<HRTimeKeeperCompletesInfo> listDataComplete = (List<HRTimeKeeperCompletesInfo>)TimeKeeperCompletesGridControl.DataSource;
            if (listDataComplete != null)
            {
                HRTimeKeeperCompletesInfo objTimeKeeperCompleteSamesInfo = listDataComplete.Where(x => x.HRTimeKeeperCompleteDate == objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDate &&
                                                                                                        x.HRTimeKeeperCompletesEmployeeCardNo == objTimeKeeperCompletesInfo.HRTimeKeeperCompletesEmployeeCardNo &&
                                                                                                        x.HRTimeKeeperCompleteTimeCheck == objTimeKeeperCompletesInfo.HRTimeKeeperCompleteTimeCheck &&
                                                                                                        x.HRTimeKeeperCompleteInOutMode != objTimeKeeperCompletesInfo.HRTimeKeeperCompleteInOutMode).FirstOrDefault();
                if (objTimeKeeperCompleteSamesInfo != null)
                {
                    objTimeKeeperCompleteSamesInfo.SameDateTime = "False";
                    objTimeKeeperCompletesInfo.SameDateTime = "False";
                    result = true;
                }
                else
                {
                    objTimeKeeperCompletesInfo.SameDateTime = "";
                }
            }
            return result;
        }
        public bool CheckNotInOverTime(HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo, int MinRegisterOverTime, bool isChangeTimeCheck)
        {
            if (TimeKeeperCompletesGridControl == null)
                return false;
            bool result = false;
            //List<HRTimeKeeperCompletesInfo> listDataComplete = (List<HRTimeKeeperCompletesInfo>)TimeKeeperCompletesGridControl.DataSource;
            if (EmployeeWorkingShiftList != null)
            {
                HREmployeesInfo WorkingShift = EmployeeWorkingShiftList.Where(x => x.HREmployeeCardNumber == objTimeKeeperCompletesInfo.HRTimeKeeperCompletesEmployeeCardNo).FirstOrDefault();
                if (WorkingShift != null)
                {
                    DateTime d1 = DateTime.ParseExact(objTimeKeeperCompletesInfo.HRTimeKeeperCompleteTimeCheck.ToString("dd/MM/yyyy") + " "
                        + WorkingShift.HRWorkingShiftToTime.ToString("HH:mm:ss"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                    if (objTimeKeeperCompletesInfo.HRTimeKeeperCompleteInOutMode == 1 // Thoi gian ra lon hon thoi gian lam viec + 60 phut => la tang ca
                        && objTimeKeeperCompletesInfo.HRTimeKeeperCompleteTimeCheck >= d1.AddMinutes((double)MinRegisterOverTime))
                    {
                        //Kiểm tra đăng ký TC
                        HREmployeeOTsInfo objEmployeeOTsInfo = AllEmployeeOTList.Where(x => x.FK_HREmployeeID == WorkingShift.HREmployeeID
                                                                                        && x.HREmployeeOTDate.Date == objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDate).FirstOrDefault();
                        if (objEmployeeOTsInfo == null || objEmployeeOTsInfo.HREmployeeOTID == 0)
                        {
                            result = true;

                        }
                        else
                        {
                            if (isChangeTimeCheck)
                            {
                                objTimeKeeperCompletesInfo.NotInOverTime = "";
                            }
                        }

                    }
                    else
                    {
                        objTimeKeeperCompletesInfo.NotInOverTime = "";
                    }
                }

            }
            return result;
        }

        public bool CheckOverTimeAbsence(HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo, int MinRegisterOverTime, bool isChangeTimeCheck)
        {
            if (TimeKeeperCompletesGridControl == null)
                return false;
            bool result = false;
            //List<HRTimeKeeperCompletesInfo> listDataComplete = (List<HRTimeKeeperCompletesInfo>)TimeKeeperCompletesGridControl.DataSource;
            if (EmployeeWorkingShiftList != null)
            {
                HREmployeeOTsInfo objEmployeeOTsInfo = AllEmployeeOTList.Where(x => x.HREmployeeCardNumber == objTimeKeeperCompletesInfo.HRTimeKeeperCompletesEmployeeCardNo
                                                                                        && x.HREmployeeOTDate.Date == objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDate).FirstOrDefault();
                if (objEmployeeOTsInfo != null && objEmployeeOTsInfo.HREmployeeOTID > 0)
                {
                    HREmployeesInfo WorkingShift = EmployeeWorkingShiftList.Where(x => x.HREmployeeCardNumber == objTimeKeeperCompletesInfo.HRTimeKeeperCompletesEmployeeCardNo).FirstOrDefault();
                    if (WorkingShift != null && WorkingShift.HREmployeeID > 0)
                    {
                        DateTime d1 = DateTime.ParseExact(objEmployeeOTsInfo.HREmployeeOTDate.ToString("dd/MM/yyyy") + " "
                        + objEmployeeOTsInfo.HREmployeeOTFromDate.ToString("HH:mm:ss"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                        if (objTimeKeeperCompletesInfo.HRTimeKeeperCompleteInOutMode == 1 // Thoi gian ra lon hon thoi gian lam viec + 60 phut => la tang ca
                            && objTimeKeeperCompletesInfo.HRTimeKeeperCompleteTimeCheck <= d1.AddMinutes((double)MinRegisterOverTime))
                        {
                            //Kiểm tra đăng ký TC
                            result = true;
                            objTimeKeeperCompletesInfo.RegisterOverTimeAbsence = DateTime.ParseExact(objEmployeeOTsInfo.HREmployeeOTDateEnd.ToString("dd/MM/yyyy") + " "
                        + objEmployeeOTsInfo.HREmployeeOTToDate.ToString("HH:mm:ss"), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                        }
                        else
                        {
                            if (isChangeTimeCheck)
                            {
                                objTimeKeeperCompletesInfo.OverTimeAbsence = "";
                            }
                        }
                    }
                }
            }
            return result;
        }

        public void ViewHistory()
        {
            HRTimeKeepersController objTimeKeepersController = new HRTimeKeepersController();
            DateTime dateFrom = Convert.ToDateTime(DateFromControl.EditValue);
            DateTime dateTo = Convert.ToDateTime(DateToControl.EditValue);
            List<HRTimeKeepersInfo> listTimekeeper = objTimeKeepersController.GetTimeKeeperDistinctByDate(null, dateFrom, dateTo);
            TimeKeepersGridControl.DataSource = listTimekeeper;
            SearchFromDateView.EditValue = DateFromControl.DateTime;
            SearchToDateView.EditValue = DateToControl.DateTime;
            DateCalculateFromControl.EditValue = DateFromControl.DateTime;
            DateCalculateToControl.EditValue = DateToControl.DateTime;
        }
        #region read from Excel
        #region Private variable
        private Microsoft.Office.Interop.Excel.Application App;
        /// <summary>
        /// Define work book in excel
        /// </summary>
        private Workbook WorkBook;
        /// <summary>
        /// Define work sheet in excel
        /// </summary>
        private Worksheet WorkSheet;
        #endregion
        public void ImportProductFromRawExcel()
        {
            //lấy sheet 3 "Att.log report"
            Range range = InitializeDataImport(3);
            if (range != null)
            {
                int count = 0;
                if (MessageBox.Show(ImportDataLocalizedResources.QuestionImportDataMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BOSProgressBar.Start(ImportDataLocalizedResources.ProgressBarMessage);
                    HRTimeKeepersInfo objTimeKeepersInfo;
                    List<HRTimeKeepersInfo> timeKeeperList = new List<HRTimeKeepersInfo>();
                    #region Get fromdate to date
                    string fromDateTodate = (range.Cells[3, 3] as Range).Text.ToString().Trim();
                    int dayFrom = 0;
                    int dayTo = 0;
                    int monthFrom = 0;
                    int monthTo = 0;
                    int yearFrom = 0;
                    int yearTo = 0;
                    int machineNumber = 1;
                    // lấy ngày bắt đầu, kết thúc
                    if (fromDateTodate != null && fromDateTodate != string.Empty)
                    {
                        string[] DateTodate = fromDateTodate.Split('~');
                        if (DateTodate != null && DateTodate.Length > 0)
                        {
                            string[] DateFrom = DateTodate[0].Split('-');
                            string[] DateTo = DateTodate[1].Split('-');

                            if (DateFrom != null && DateFrom.Length > 0)
                            {
                                yearFrom = int.Parse(DateFrom[0].ToString());
                                monthFrom = int.Parse(DateFrom[1].ToString());
                                dayFrom = int.Parse(DateFrom[2].ToString());
                            }

                            if (DateTo != null && DateTo.Length > 0)
                            {
                                yearTo = int.Parse(DateTo[0].ToString());
                                monthTo = int.Parse(DateTo[1].ToString());
                                dayTo = int.Parse(DateTo[2].ToString());
                            }

                        }
                    }

                    #endregion

                    if (dayFrom == 0 || monthFrom == 0 || yearFrom == 0 ||
                        dayTo == 0 || monthTo == 0 || yearTo == 0)
                    {
                        MessageBox.Show("Định dạng file chưa đúng, không thể lấy được ngày bắt đầu và kết thúc chấm công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ReleaseDataImport();
                        return;
                    }
                    //loop từ row số 4
                    #region Loop All row in file : start row = 4
                    int percent = 0;
                    int workShop = 0;
                    for (int row = 4; row <= range.Rows.Count; row++)
                    {
                        percent++;
                        double pct = (percent * 100) / range.Rows.Count;
                        BOSProgressBar.Start("Xử lý dữ liệu: " + Math.Round(pct) + " % ");

                        // lấy mã chấm công 
                        string isMaChamCong = (range.Cells[row, 1] as Range).Text.ToString().Trim();
                        string data = string.Empty;
                        if (isMaChamCong.Contains("Mã:"))
                        {
                            data = (range.Cells[row, 3] as Range).Text.ToString().Trim();
                        }
                        //trường hợp ko lấy dc mã, loop dòng tiếp theo
                        if (data == string.Empty)
                            continue;
                        string dateString = string.Empty;
                        int dem = 1;
                        #region Loop all date
                        for (int date = dayFrom; date <= dayTo; date++)
                        {
                            List<InOut> inOutList = new List<InOut>();
                            // lấy dữ liệu chấm công dòng bên dưới Mã 
                            dateString = (range.Cells[row + 1, dem] as Range).Text.ToString().Trim();
                            if (dateString != null)
                            {
                                #region Split ':' and loop to get In and Out time of Date
                                string[] DateInOut = dateString.Split(':');
                                if (DateInOut != null && DateInOut.Length > 0)
                                {
                                    bool loaiVao = false;
                                    InOut obj = new InOut();
                                    #region Loop data in Cell split In and Out Time
                                    for (int i = 0; i < DateInOut.Length; i++)
                                    {
                                        int time = 0;
                                        int minute = 0;

                                        if (DateInOut[i].ToString().Length == 2)
                                        {
                                            #region phần Đầu tien length = 2


                                            if (i == 0)
                                            {
                                                time = int.Parse(DateInOut[i].ToString());
                                            }
                                            else
                                            {
                                                // phần tử sau cùng là phút đã Add prev step
                                                continue;
                                            }
                                            // check out of range
                                            if (i + 1 < DateInOut.Length)
                                            {
                                                string minutePlus = DateInOut[i + 1].ToString();
                                                string minuteString = minutePlus.Substring(0, 2);
                                                if (minuteString != string.Empty)
                                                {
                                                    minute = int.Parse(minuteString);
                                                    // Add giờ vào/ra khi đã dũ info
                                                    obj.InOutHour = time;
                                                    obj.InOutMinute = minute;
                                                    obj.OutType = loaiVao;

                                                    InOut objAdd = new InOut();
                                                    objAdd.InOutHour = time;
                                                    objAdd.InOutMinute = minute;
                                                    objAdd.OutType = loaiVao;
                                                    inOutList.Add(objAdd);

                                                    //reset loai next time
                                                    if (loaiVao)
                                                        loaiVao = false;
                                                    else
                                                        loaiVao = true;
                                                }
                                            }
                                            #endregion
                                        }
                                        else if (DateInOut[i].ToString().Length == 4)
                                        {
                                            #region Phần tử length = 4 trong chuổi

                                            // check out of range
                                            if (i + 1 < DateInOut.Length)
                                            {
                                                string minutePlus = DateInOut[i + 1].ToString();
                                                string minuteString = minutePlus.Substring(0, 2);
                                                string hourNextString = string.Empty;
                                                if (DateInOut[i].ToString().Length == 4)
                                                    hourNextString = DateInOut[i].ToString().Substring(2, 2);

                                                if (minuteString != string.Empty)
                                                {
                                                    minute = int.Parse(minuteString);
                                                    int nextHour = 0;
                                                    if (hourNextString != string.Empty)
                                                        nextHour = int.Parse(hourNextString);

                                                    #region Compare with added Prev time Case same time then Next record value
                                                    if (nextHour == obj.InOutHour)
                                                    {
                                                        // check out of range
                                                        if (i + 2 < DateInOut.Length)
                                                        {
                                                            string nextMinuteString = DateInOut[i + 2].ToString();


                                                            string NextminuteString = minutePlus.Substring(0, 2);
                                                            string NexthourString = minutePlus.Substring(2, 2);

                                                            int nextMinute = int.Parse(NextminuteString);
                                                            if (nextMinute - obj.InOutMinute <= 5)
                                                            {
                                                                //duplicate check
                                                                continue;
                                                            }
                                                            else
                                                            {
                                                                time = nextHour;
                                                            }
                                                        }

                                                    }
                                                    else
                                                    {
                                                        string timePlus = DateInOut[i].ToString().Substring(2, 2);
                                                        time = int.Parse(timePlus);
                                                    }
                                                    #endregion
                                                    // Add giờ vào/ra khi đã dũ info
                                                    if (time > 0 && minute > 0)
                                                    {
                                                        InOut objAdd = new InOut();
                                                        objAdd.InOutHour = time;
                                                        objAdd.InOutMinute = minute;
                                                        objAdd.OutType = loaiVao;
                                                        inOutList.Add(objAdd);

                                                        //reset loai next time
                                                        if (loaiVao)
                                                            loaiVao = false;
                                                        else
                                                            loaiVao = true;
                                                    }
                                                }
                                            }
                                            #endregion
                                        }
                                        else
                                        {
                                            #region Add data case null
                                            InOut objInAdd = new InOut();
                                            objInAdd.InOutHour = 0;
                                            objInAdd.InOutMinute = 0;
                                            objInAdd.OutType = false;
                                            //inOutList.Add(objInAdd);
                                            InOut objAdd = new InOut();
                                            objAdd.InOutHour = 0;
                                            objAdd.InOutMinute = 0;
                                            objAdd.OutType = true;
                                            //inOutList.Add(objAdd);
                                            #endregion
                                        }
                                    }
                                    #endregion
                                }
                                #endregion

                            }
                            else
                            {
                                #region Add data case null
                                InOut objInAdd = new InOut();
                                objInAdd.InOutHour = 0;
                                objInAdd.InOutMinute = 0;
                                objInAdd.OutType = false;
                                //inOutList.Add(objInAdd);
                                InOut objAdd = new InOut();
                                objAdd.InOutHour = 0;
                                objAdd.InOutMinute = 0;
                                objAdd.OutType = true;
                                //inOutList.Add(objAdd);
                                #endregion
                            }

                            #region Add data to TimeKeeper list datasource
                            foreach (InOut item in inOutList)
                            {
                                DateTime dateIn = new DateTime(yearFrom, monthFrom, date, item.InOutHour, item.InOutMinute, 0);
                                int mode = 0;
                                if (item.OutType)
                                    mode = 1;
                                objTimeKeepersInfo = new HRTimeKeepersInfo(data, dateIn, dateIn, mode, machineNumber, workShop);
                                timeKeeperList.Add(objTimeKeepersInfo);
                            }
                            #endregion
                            dem++;

                        }
                        #endregion
                    }
                    #endregion

                    if (timeKeeperList != null)
                        count = timeKeeperList.Count;
                    string resultMessage = ImportDataLocalizedResources.TotalRecordNumberImportSuccessMessage.Replace("{0}", count.ToString());
                    HREmployeesInfo objEmployeesInfo;
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    #region Mapping Employee


                    foreach (HRTimeKeepersInfo item in timeKeeperList)
                    {
                        objEmployeesInfo = objEmployeesController.GetEmployeeByCardNumber(item.HRTimeKeeperEmployeeCardNo);
                        if (objEmployeesInfo != null)
                        {
                            item.HRTimeKeeperEmployeeNo = objEmployeesInfo.HREmployeeNo;
                            item.EmployeeName = objEmployeesInfo.HREmployeeName;
                        }
                        item.ThName = GetThName(item.HRTimeKeeperDate);
                    }
                    #endregion

                    #region Reset serch date
                    SearchFromDateView.EditValue = new DateTime(yearFrom, monthFrom, dayFrom);
                    SearchToDateView.EditValue = new DateTime(yearTo, monthTo, dayTo);
                    DateFromControl.EditValue = new DateTime(yearFrom, monthFrom, dayFrom);
                    DateToControl.EditValue = new DateTime(yearTo, monthTo, dayTo);
                    DateCalculateFromControl.EditValue = new DateTime(yearFrom, monthFrom, dayFrom);
                    DateCalculateToControl.EditValue = new DateTime(yearTo, monthTo, dayTo);
                    #endregion]

                    // reset data source and save data
                    TimeKeepersGridControl.DataSource = timeKeeperList;
                    SaveData(timeKeeperList, false);


                    BOSProgressBar.Close();
                    MessageBox.Show(resultMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //file.Close();
                ReleaseDataImport();
            }
        }

        /// <summary>
        /// Initialize data import from file excel
        /// </summary>
        /// <returns>Range of file excel</returns>
        public Range InitializeDataImport(int sheetID)
        {
            string filePath = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = ImportDataLocalizedResources.DialogFilter;
            if (dialog.ShowDialog() != DialogResult.Cancel)
                filePath = dialog.FileName;
            if (!String.IsNullOrEmpty(filePath))
            {
                App = new Microsoft.Office.Interop.Excel.ApplicationClass();
                WorkBook = App.Workbooks.Open(filePath, 0, true, 5, string.Empty, string.Empty, true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                WorkSheet = (Worksheet)WorkBook.Worksheets.get_Item(sheetID);
                Range range = WorkSheet.UsedRange;
                return range;
            }
            return null;
        }
        /// <summary>
        /// Release data import from file excel
        /// </summary>
        public void ReleaseDataImport()
        {
            WorkBook.Close(true, null, null);
            App.Quit();
            ReleaseObject(WorkSheet);
            ReleaseObject(WorkBook);
            ReleaseObject(App);
        }

        /// <summary>
        /// Release object
        /// </summary>
        /// <param name="obj">Given object</param>
        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        #endregion

        public void AddBackupList(HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo)
        {
            ManagerTimeKeeperEntities entity = (ManagerTimeKeeperEntities)CurrentModuleEntity;
            if (entity.TimeKeeperCompleteBackupList2.Where(o => o.HRTimeKeeperCompleteDate == objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDate
                                                                && o.HRTimeKeeperCompletesEmployeeCardNo == objTimeKeeperCompletesInfo.HRTimeKeeperCompletesEmployeeCardNo
                                                                && o.FK_HRTimeKeeperID == objTimeKeeperCompletesInfo.FK_HRTimeKeeperID).Count() == 0)
            {
                entity.TimeKeeperCompleteBackupList2.Add(objTimeKeeperCompletesInfo);
            }
            else
            {
                entity.TimeKeeperCompleteBackupList2.Remove(entity.TimeKeeperCompleteBackupList2.Where(o => o.HRTimeKeeperCompleteDate == objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDate
                                                            && o.HRTimeKeeperCompletesEmployeeCardNo == objTimeKeeperCompletesInfo.HRTimeKeeperCompletesEmployeeCardNo
                                                            && o.FK_HRTimeKeeperID == objTimeKeeperCompletesInfo.FK_HRTimeKeeperID).FirstOrDefault());

                entity.TimeKeeperCompleteBackupList2.Add(objTimeKeeperCompletesInfo);
            }
        }
        public void AddBackupListBeforeChanged(HRTimeKeeperCompletesInfo objTimeKeeperCompletesInfo)
        {
            ManagerTimeKeeperEntities entity = (ManagerTimeKeeperEntities)CurrentModuleEntity;
            if (entity.TimeKeeperCompleteBackupList.Where(o => o.HRTimeKeeperCompleteDate == objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDate
                                                                && o.HRTimeKeeperCompletesEmployeeCardNo == objTimeKeeperCompletesInfo.HRTimeKeeperCompletesEmployeeCardNo
                                                                && o.FK_HRTimeKeeperID == objTimeKeeperCompletesInfo.FK_HRTimeKeeperID).Count() == 0)
            {
                entity.TimeKeeperCompleteBackupList.Add(objTimeKeeperCompletesInfo);
            }
            else
            {
                entity.TimeKeeperCompleteBackupList.Remove(entity.TimeKeeperCompleteBackupList.Where(o => o.HRTimeKeeperCompleteDate == objTimeKeeperCompletesInfo.HRTimeKeeperCompleteDate
                                                            && o.HRTimeKeeperCompletesEmployeeCardNo == objTimeKeeperCompletesInfo.HRTimeKeeperCompletesEmployeeCardNo
                                                            && o.FK_HRTimeKeeperID == objTimeKeeperCompletesInfo.FK_HRTimeKeeperID).FirstOrDefault());

                entity.TimeKeeperCompleteBackupList.Add(objTimeKeeperCompletesInfo);
            }
        }
        public string CheckChangedColumn(HRTimeKeeperHistoryDetailsInfo objTimeKeeperHistoryDetailsInfo)
        {
            if (objTimeKeeperHistoryDetailsInfo == null)
                return string.Empty;
            if (objTimeKeeperHistoryDetailsInfo.HRTimeKeeperHistoryDetailColumnName == "Thời gian")
                return "h:mm:ss tt";
            if (objTimeKeeperHistoryDetailsInfo.HRTimeKeeperHistoryDetailColumnName == "Ngày Vào/Ra")
                return "dd/MM/yyyy";
            return string.Empty;
        }

        public void ActionQuickImportTimeSheet()
        {
            ManagerTimeKeeperEntities entity = (ManagerTimeKeeperEntities)CurrentModuleEntity;
            guiQuickImportTimeSheet guiFind = new guiQuickImportTimeSheet();
            guiFind.Module = this;
            guiFind.ShowDialog();
            if (guiFind.DialogResult != DialogResult.OK)
                return;

            DateTime timeIn = guiFind.TimeIn;
            DateTime timeOut = guiFind.TimeOut;

            List<HRTimeKeepersInfo> list = new List<HRTimeKeepersInfo>();
            foreach (HREmployeesInfo objEmployeesInfo in guiFind.SelectEmployeesList)
            {
                if (timeIn.TimeOfDay != DateTime.MinValue.TimeOfDay)
                {
                    foreach (HRTimeKeepersInfo item in guiFind.SelectTimeKeepersList)
                    {
                        HRTimeKeepersInfo objTimeKeepersInfo = new HRTimeKeepersInfo();
                        if (objEmployeesInfo != null)
                        {
                            objTimeKeepersInfo.HRTimeKeeperEmployeeNo = objEmployeesInfo.HREmployeeNo;
                            objTimeKeepersInfo.EmployeeName = objEmployeesInfo.HREmployeeName;
                            objTimeKeepersInfo.HRTimeKeeperEmployeeCardNo = objEmployeesInfo.HREmployeeCardNumber;
                        }
                        objTimeKeepersInfo.ThName = item.ThName;
                        objTimeKeepersInfo.HRTimeKeeperDate = new DateTime(item.HRTimeKeeperQuickImportDate.Year, item.HRTimeKeeperQuickImportDate.Month, item.HRTimeKeeperQuickImportDate.Day);
                        objTimeKeepersInfo.HRTimeKeeperTimeIn = new DateTime(item.HRTimeKeeperQuickImportDate.Year, item.HRTimeKeeperQuickImportDate.Month, item.HRTimeKeeperQuickImportDate.Day);
                        objTimeKeepersInfo.HRTimeKeeperTimeInOutMode = 0;
                        objTimeKeepersInfo.HRTimeKeeperTimeOut = new DateTime(item.HRTimeKeeperQuickImportDate.Year, item.HRTimeKeeperQuickImportDate.Month, item.HRTimeKeeperQuickImportDate.Day, guiFind.TimeIn.Hour, guiFind.TimeIn.Minute, guiFind.TimeIn.Second);
                        objTimeKeepersInfo.HRTimeKeeperDateCheck = new DateTime(item.HRTimeKeeperQuickImportDate.Year, item.HRTimeKeeperQuickImportDate.Month, item.HRTimeKeeperQuickImportDate.Day);
                        list.Add(objTimeKeepersInfo);
                    }
                }

                if (timeOut.TimeOfDay != DateTime.MinValue.TimeOfDay)
                {
                    foreach (HRTimeKeepersInfo item2 in guiFind.SelectTimeKeepersList)
                    {
                        HRTimeKeepersInfo objTimeKeepersInfo = new HRTimeKeepersInfo();
                        if (objEmployeesInfo != null)
                        {
                            objTimeKeepersInfo.HRTimeKeeperEmployeeNo = objEmployeesInfo.HREmployeeNo;
                            objTimeKeepersInfo.EmployeeName = objEmployeesInfo.HREmployeeName;
                            objTimeKeepersInfo.HRTimeKeeperEmployeeCardNo = objEmployeesInfo.HREmployeeCardNumber;
                        }
                        objTimeKeepersInfo.HRTimeKeeperDate = new DateTime(item2.HRTimeKeeperQuickImportDate.Year, item2.HRTimeKeeperQuickImportDate.Month, item2.HRTimeKeeperQuickImportDate.Day);
                        objTimeKeepersInfo.HRTimeKeeperTimeIn = new DateTime(item2.HRTimeKeeperQuickImportDate.Year, item2.HRTimeKeeperQuickImportDate.Month, item2.HRTimeKeeperQuickImportDate.Day);
                        objTimeKeepersInfo.HRTimeKeeperTimeInOutMode = 0;
                        objTimeKeepersInfo.HRTimeKeeperTimeOut = new DateTime(item2.HRTimeKeeperQuickImportDate.Year, item2.HRTimeKeeperQuickImportDate.Month, item2.HRTimeKeeperQuickImportDate.Day, guiFind.TimeOut.Hour, guiFind.TimeOut.Minute, guiFind.TimeOut.Second);
                        objTimeKeepersInfo.HRTimeKeeperDateCheck = new DateTime(item2.HRTimeKeeperQuickImportDate.Year, item2.HRTimeKeeperQuickImportDate.Month, item2.HRTimeKeeperQuickImportDate.Day);
                        list.Add(objTimeKeepersInfo);
                    }
                }
            }

            TimeKeepersGridControl.DataSource = list;
            entity.SaveData(list);
        }

        public void SaveDataCompletedView()
        {
            ManagerTimeKeeperEntities entity = (ManagerTimeKeeperEntities)CurrentModuleEntity;
            entity.TimeKeeperCompleteListView.SaveItemObjects();
        }
    }

    public class InOut
    {
        public InOut()
        {
            InOutHour = 0;
            InOutMinute = 0;
            OutType = false;
        }
        public InOut(int gio, int phut, bool loai)
        {
            InOutHour = gio;
            InOutMinute = phut;
            OutType = loai;
        }
        public int InOutHour { get; set; }
        public int InOutMinute { get; set; }
        public bool OutType { get; set; }
    }
}

