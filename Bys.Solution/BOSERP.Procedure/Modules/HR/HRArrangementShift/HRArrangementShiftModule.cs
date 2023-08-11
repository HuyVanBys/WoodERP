using BOSCommon.Constants;
using BOSERP.Modules.HRArrangementShift.UI;
using BOSLib;
using DevExpress.XtraGrid.Views.BandedGrid;
using Localization;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.HRArrangementShift
{
    public class HRArrangementShiftModule : BaseTransactionModule
    {
        #region Constants
        /// <summary>
        /// The employee time sheet gird control name
        /// </summary>
        public const string HREmployeeArrangementShiftsGridControlName = "fld_dgcHREmployeeArrangementShifts";
        private decimal HoursPerDay = 0;
        //BXLuong [MOD] [22/11/2013] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //BXLuong [MOD] [22/11/2013] [DB centre] [Search document by BRBranchID], END
        public bool isCustomDrawCell = false;
        #endregion

        #region Variable
        /// <summary>
        /// Define application in excel
        /// </summary>
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

        #region Public Properties

        #endregion

        public HRArrangementShiftModule()
        {
            Name = "HRArrangementShift";
            CurrentModuleEntity = new HRArrangementShiftEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            HRArrangementShiftsController objArrangementShiftsController = new HRArrangementShiftsController();
            HRArrangementShiftsInfo searchObject = (HRArrangementShiftsInfo)CurrentModuleEntity.SearchObject;

            DataSet ds = new DataSet();

            ds = objArrangementShiftsController.GetArrangementShiftList(searchObject.HRArrangementShiftNo,
                                                            searchObject.HRArrangementShiftName,
                                                            searchObject.FK_BRBranchID,
                                                            searchObject.HRArrangementShiftFromDate,
                                                            searchObject.HRArrangementShiftToDate);
            return ds;
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            HRArrangementShiftEntities entity = (HRArrangementShiftEntities)CurrentModuleEntity;
            HRDepartmentsController objDepartmentsController = new HRDepartmentsController();
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            foreach (var objEmployeeArrangementShiftsInfo in entity.EmployeeArrangementShiftList)
            {
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objEmployeeArrangementShiftsInfo.FK_HREmployeeID);
                HRDepartmentsInfo objDepartmentsInfo = (HRDepartmentsInfo)objDepartmentsController.GetObjectByID(objEmployeesInfo.FK_HRDepartmentID);
                if (objDepartmentsInfo != null)
                {
                    objEmployeeArrangementShiftsInfo.HRDepartmentName = objDepartmentsInfo.HRDepartmentName;
                }
                HRDepartmentRoomsInfo objDepartmentRoomsInfo = (HRDepartmentRoomsInfo)objDepartmentRoomsController.GetObjectByID(objEmployeesInfo.FK_HRDepartmentRoomID);
                if (objDepartmentRoomsInfo != null)
                {
                    objEmployeeArrangementShiftsInfo.HRDepartmentRoomName = objDepartmentRoomsInfo.HRDepartmentRoomName;
                }
            }
            InitializeArrangementShiftEntryGridControl();
            isCustomDrawCell = false;
        }

        public override void ActionNew()
        {
            base.ActionNew();
            HRArrangementShiftEntities entity = (HRArrangementShiftEntities)CurrentModuleEntity;
            HRArrangementShiftsInfo mainObject = (HRArrangementShiftsInfo)entity.MainObject;
            InitializeArrangementShiftEntryGridControl();
        }

        public override int ActionSave()
        {
            HRArrangementShiftEntities entity = (HRArrangementShiftEntities)CurrentModuleEntity;
            entity.EmployeeArrangementShiftList.EndCurrentEdit();
            //UpdateArrangementShiftTotalQty();

            return base.ActionSave();
        }

        /// <summary>
        /// Add employee to the current time sheet
        /// </summary>
        public void AddEmployeeToArrangementShift()
        {
            try
            {
                guiSearchEmployeeShift guiEmployee = new guiSearchEmployeeShift();
                guiEmployee.Module = this;
                if (guiEmployee.ShowDialog() == DialogResult.OK)
                {
                    HRArrangementShiftEntities entity = (HRArrangementShiftEntities)CurrentModuleEntity;
                    HRArrangementShiftsInfo arrangementShift = (HRArrangementShiftsInfo)entity.MainObject;
                    entity.EmployeeList.Invalidate(guiEmployee.SelectedEmployeeList);
                    List<HRWorkingShiftsInfo> workingShifts = entity.WorkingShifts;
                    HRWorkingShiftsController objWorkingShiftsController = new HRWorkingShiftsController();
                    HRWorkingShiftsInfo defaultParam = (HRWorkingShiftsInfo)workingShifts.FirstOrDefault();

                    foreach (HREmployeesInfo objEmployeesInfo in entity.EmployeeList)
                    {
                        if (objEmployeesInfo.Selected)
                        {
                            if (!entity.EmployeeArrangementShiftList.Exists("FK_HREmployeeID", objEmployeesInfo.HREmployeeID))
                            {
                                HREmployeeArrangementShiftsInfo objEmployeeArrangementShiftsInfo = SetEmployeeArrangementShiftsInfoFromEmployee(objEmployeesInfo);
                                //AddDefaulArrangementShiftEntries(objEmployeeArrangementShiftsInfo, objEmployeesInfo);
                                List<HRArrangementShiftEntrysInfo> arrangementShiftEntrys = objEmployeeArrangementShiftsInfo.HRArrangementShiftEntrysList.Where(o => o.FK_HREmployeeID == objEmployeeArrangementShiftsInfo.FK_HREmployeeID).ToList();
                                objEmployeeArrangementShiftsInfo.HRArrangementShiftEntrysList = arrangementShiftEntrys;
                                entity.SetEmployeeArrangementShiftValue(objEmployeeArrangementShiftsInfo);
                                entity.EmployeeArrangementShiftList.Add(objEmployeeArrangementShiftsInfo);
                            }
                        }
                    }
                    entity.EmployeeArrangementShiftList.GridControl.RefreshDataSource();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi, vui lòng thử lại", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //public void AddDefaulArrangementShiftEntries(HREmployeeArrangementShiftsInfo objEmployeeArrangementShiftsInfo, HREmployeesInfo objEmployeesInfo)
        //{
        //    objEmployeeArrangementShiftsInfo.HRArrangementShiftEntrysList.Clear();

        //    HRArrangementShiftEntities entity = (HRArrangementShiftEntities)CurrentModuleEntity;
        //    HRArrangementShiftsInfo objArrangementShiftsInfo = (HRArrangementShiftsInfo)entity.MainObject;
        //    ADWorkingShiftsController objWorkingShiftsController = new ADWorkingShiftsController();
        //    List<ADWorkingShiftsInfo> workingShifts = entity.WorkingShifts;
        //    HRWorkingShiftsInfo defaultParam = (HRWorkingShiftsInfo)workingShifts.Where(o => o.WorkingShiftID == objEmployeesInfo.FK_HRWorkingShiftID).FirstOrDefault();

        //    if (defaultParam != null)
        //    {
        //        BOSDbUtil dbUtil = new BOSDbUtil();
        //        int numDays = NumOfDayInMonth();
        //        for (int i = 1; i <= numDays; i++)
        //        {
        //            DateTime currentDate = objArrangementShiftsInfo.HRArrangementShiftFromDate.Date.AddDays(i - 1);
        //            HRArrangementShiftEntrysInfo entry = new HRArrangementShiftEntrysInfo();
        //            entry.FK_HREmployeeID = objEmployeeArrangementShiftsInfo.FK_HREmployeeID;
        //            entry.FK_HRArrangementShiftID = objEmployeeArrangementShiftsInfo.FK_HRArrangementShiftID;
        //            entry.FK_HREmployeeArrangementShiftID = objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftID;
        //            entry.HRArrangementShiftEntryDate = currentDate;
        //            entry.FK_HRWorkingShiftID = defaultParam.ADWorkingShiftID;

        //            //String propertyName = String.Format("{0}{1}", "HREmployeeArrangementShiftDate", i);
        //            objEmployeeArrangementShiftsInfo.HRArrangementShiftEntrysList.Add(entry);
        //        }
        //    }
        //}

        /// <summary>
        /// Number of days in month
        /// </summary>
        /// <returns></returns>
        public int NumOfDayInMonth()
        {
            HRArrangementShiftEntities entity = (HRArrangementShiftEntities)CurrentModuleEntity;
            HRArrangementShiftsInfo objArrangementShiftsInfo = (HRArrangementShiftsInfo)entity.MainObject;
            int numDays = (int)(objArrangementShiftsInfo.HRArrangementShiftToDate.Date - objArrangementShiftsInfo.HRArrangementShiftFromDate.Date).TotalDays + 1;
            return numDays;
        }

        /// <summary>
        ///  Initialize grid control
        /// </summary>
        public void InitializeArrangementShiftEntryGridControl()
        {
            HRArrangementShiftEntities entity = (HRArrangementShiftEntities)CurrentModuleEntity;
            HRArrangementShiftsInfo objArrangementShiftsInfo = (HRArrangementShiftsInfo)entity.MainObject;
            HREmployeeArrangementShiftsGridControl gridControl = (HREmployeeArrangementShiftsGridControl)Controls[HRArrangementShiftModule.HREmployeeArrangementShiftsGridControlName];
            gridControl.InitializeControl();
        }

        /// <summary>
        /// Remove the selected employee from the current employee time sheet list
        /// </summary>
        public void RemoveEmployeeFromArrangementShiftList()
        {
            HRArrangementShiftEntities entity = (HRArrangementShiftEntities)CurrentModuleEntity;
            BandedGridView bandedView = (BandedGridView)entity.EmployeeArrangementShiftList.GridControl.MainView;
            if (bandedView.FocusedRowHandle >= 0)
            {
                int index = bandedView.GetDataSourceRowIndex(bandedView.FocusedRowHandle);
                entity.EmployeeArrangementShiftList.RemoveAt(index);
                bandedView.RefreshData();
            }
        }

        /// <summary>
        /// Called from the screen, when the user changes the time of time sheet
        /// </summary>
        public void ChangeArrangementShiftTime()
        {
            HRArrangementShiftEntities entity = (HRArrangementShiftEntities)CurrentModuleEntity;
            HRArrangementShiftsInfo objArrangementShiftsInfo = (HRArrangementShiftsInfo)entity.MainObject;
            int numDays = NumOfDayInMonth();
            if (numDays > 31)
            {
                MessageBox.Show("Bạn không thể chọn thời gian xếp ca quá 31 ngày!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objArrangementShiftsInfo.HRArrangementShiftToDate = objArrangementShiftsInfo.HRArrangementShiftFromDate;
                entity.UpdateMainObjectBindingSource();
            }
            InvalidateArrangementShiftValues();
            InitializeArrangementShiftEntryGridControl();
            UpdateEmployeeArrangementShift();
        }

        /// <summary>
        /// Invalidate values for the current time sheet
        /// </summary>
        private void InvalidateArrangementShiftValues()
        {
            HRArrangementShiftEntities entity = (HRArrangementShiftEntities)CurrentModuleEntity;
            foreach (HREmployeeArrangementShiftsInfo employeeArrangementShift in entity.EmployeeArrangementShiftList)
            {
                entity.SetEmployeeArrangementShiftValue(employeeArrangementShift);
            }
        }

        private HREmployeeArrangementShiftsInfo SetEmployeeArrangementShiftsInfoFromEmployee(HREmployeesInfo objEmployeesInfo)
        {
            HREmployeeArrangementShiftsInfo objEmployeeArrangementShiftsInfo = new HREmployeeArrangementShiftsInfo();

            if (objEmployeesInfo != null)
            {
                objEmployeeArrangementShiftsInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                objEmployeeArrangementShiftsInfo.FK_HRDepartmentRoomID = objEmployeesInfo.FK_HRDepartmentRoomID;
                objEmployeeArrangementShiftsInfo.HRDepartmentName = objEmployeesInfo.HRDepartmentName;
                objEmployeeArrangementShiftsInfo.HRDepartmentRoomName = objEmployeesInfo.HRDepartmentRoomName;
                objEmployeeArrangementShiftsInfo.HRDepartmentRoomGroupName = objEmployeesInfo.HRDepartmentRoomGroupItemName;
                objEmployeeArrangementShiftsInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
                objEmployeeArrangementShiftsInfo.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
                objEmployeeArrangementShiftsInfo.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
            }
            return objEmployeeArrangementShiftsInfo;
        }

        public void UpdateArrangementShift(HREmployeeArrangementShiftsInfo objEmployeeArrangementShiftsInfo)
        {
            HRArrangementShiftEntities entity = (HRArrangementShiftEntities)CurrentModuleEntity;
            HRArrangementShiftsInfo objArrangementShiftsInfo = (HRArrangementShiftsInfo)entity.MainObject;
            List<int> employeeArrangementShiftValueList = new List<int> {   objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate1, objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate2,
                                                                        objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate3, objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate4,
                                                                        objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate5, objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate6,
                                                                        objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate7, objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate8,
                                                                        objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate9, objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate10,
                                                                        objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate11, objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate12,
                                                                        objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate13, objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate14,
                                                                        objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate15, objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate16,
                                                                        objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate17, objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate18,
                                                                        objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate19, objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate20,
                                                                        objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate21, objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate22,
                                                                        objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate23, objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate24,
                                                                        objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate25, objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate26,
                                                                        objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate27, objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate28,
                                                                        objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate29, objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate30,
                                                                        objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftDate31
                                                                         };
            int numDays = NumOfDayInMonth();
            for (int i = 0; i < numDays; i++)
            {
                int paramNumbers = employeeArrangementShiftValueList[i];

                DateTime currentDate = objArrangementShiftsInfo.HRArrangementShiftFromDate.AddDays(i);
                decimal mainEntryValue = 0;

                HRWorkingShiftsInfo param = entity.WorkingShifts.Where(o => o.HRWorkingShiftID == paramNumbers).FirstOrDefault();
                if (param != null)
                {
                    HRArrangementShiftEntrysInfo arrangementShiftEntrys = objEmployeeArrangementShiftsInfo.HRArrangementShiftEntrysList.Where(o => o.HRArrangementShiftEntryDate.Date == currentDate.Date &&
                                                                                                                                                //o.FK_HRWorkingShiftID == paramNumbers &&
                                                                                                                                                objEmployeeArrangementShiftsInfo.FK_HREmployeeID == o.FK_HREmployeeID)
                                                                                                                                                .FirstOrDefault();

                    if (arrangementShiftEntrys == null)
                    {
                        arrangementShiftEntrys = new HRArrangementShiftEntrysInfo();
                        arrangementShiftEntrys.FK_HRWorkingShiftID = paramNumbers;
                        objEmployeeArrangementShiftsInfo.HRArrangementShiftEntrysList.Add(arrangementShiftEntrys);
                    }
                    arrangementShiftEntrys.FK_HREmployeeArrangementShiftID = objEmployeeArrangementShiftsInfo.HREmployeeArrangementShiftID;
                    arrangementShiftEntrys.FK_HRArrangementShiftID = objEmployeeArrangementShiftsInfo.FK_HRArrangementShiftID;
                    arrangementShiftEntrys.FK_HREmployeeID = objEmployeeArrangementShiftsInfo.FK_HREmployeeID;
                    arrangementShiftEntrys.FK_HRWorkingShiftID = paramNumbers;
                    arrangementShiftEntrys.HRArrangementShiftEntryDate = currentDate;
                }
            }
            entity.UpdateMainObjectBindingSource();
        }

        public void ActionNewFromArrangementShift()
        {
            try
            {
                base.ActionNew();
                HRArrangementShiftEntities entity = (HRArrangementShiftEntities)CurrentModuleEntity;
                HRArrangementShiftsInfo objArrangementShiftsInfo = (HRArrangementShiftsInfo)entity.MainObject;

                HRArrangementShiftsController objArrangementShiftsController = new HRArrangementShiftsController();
                List<HRArrangementShiftsInfo> arrangementShiftsList = (List<HRArrangementShiftsInfo>)objArrangementShiftsController.GetListFromDataSet(objArrangementShiftsController.GetAllObjects());

                guiFind<HRArrangementShiftsInfo> guiFind = new guiFind<HRArrangementShiftsInfo>(TableName.HRArrangementShiftsTableName, arrangementShiftsList, this, false);
                guiFind.Module = this;
                guiFind.ShowDialog();
                if (guiFind.DialogResult != DialogResult.OK)
                {
                    base.ActionCancel();
                }

                IList<HRArrangementShiftsInfo> results = guiFind.SelectedObjects;
                if (results.Count == 0)
                    return;

                foreach (HRArrangementShiftsInfo item in results)
                {
                    objArrangementShiftsInfo.HRArrangementShiftFromDate = BOSApp.GetCurrentServerDate();
                    objArrangementShiftsInfo.HRArrangementShiftToDate = BOSApp.GetCurrentServerDate();
                    objArrangementShiftsInfo.HRArrangementShiftDesc = item.HRArrangementShiftDesc;
                    entity.GenerateEmployeeArrangementShift(item);
                }
                entity.UpdateMainObjectBindingSource();
                entity.EmployeeArrangementShiftList.GridControl.RefreshDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi, vui lòng thử lại", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateEmployeeArrangementShift()
        {
            HRArrangementShiftEntities entity = (HRArrangementShiftEntities)CurrentModuleEntity;
            HRArrangementShiftsInfo objArrangementShiftsInfo = (HRArrangementShiftsInfo)entity.MainObject;
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo;
            entity.EmployeeArrangementShiftList.ForEach(o =>
            {
                objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(o.FK_HREmployeeID);
                if (objEmployeesInfo != null)
                {
                    //AddDefaulArrangementShiftEntries(o, objEmployeesInfo);
                    List<HRArrangementShiftEntrysInfo> arrangementShiftEntrys = o.HRArrangementShiftEntrysList.Where(i => i.FK_HREmployeeID == o.FK_HREmployeeID).ToList();
                    o.HRArrangementShiftEntrysList = arrangementShiftEntrys;
                    entity.SetEmployeeArrangementShiftValue(o);
                }
            });
            entity.EmployeeArrangementShiftList.GridControl.RefreshDataSource();
        }

        public List<string> GetColumnFieldNameByTypeEndOfWeek()
        {
            HRArrangementShiftEntities entity = (HRArrangementShiftEntities)CurrentModuleEntity;
            HRArrangementShiftsInfo objArrangementShiftsInfo = (HRArrangementShiftsInfo)entity.MainObject;
            HRTimeKeeperHistoryDetailsController objTimeKeeperHistoryDetailsController = new HRTimeKeeperHistoryDetailsController();
            List<string> list = new List<string>();
            int numDays = NumOfDayInMonth();
            for (int i = 1; i <= numDays; i++)
            {
                DateTime dt = objArrangementShiftsInfo.HRArrangementShiftFromDate.Date.AddDays(i - 1);
                bool isDayOfWeek = (BOSApp.IsEndOfWeek(objArrangementShiftsInfo.HRArrangementShiftFromDate.Date.AddDays(i - 1).DayOfWeek));
                if (isDayOfWeek)
                {
                    string columnName = String.Format("{0}{1}", "HREmployeeArrangementShiftDate", i.ToString());
                    list.Add(columnName);
                }
            }
            return list;
        }

        public void ActionSetArrangementShift()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                HRArrangementShiftEntities entity = (HRArrangementShiftEntities)CurrentModuleEntity;
                HRArrangementShiftsInfo objArrangementShiftsInfo = (HRArrangementShiftsInfo)entity.MainObject;
                if (entity.EmployeeArrangementShiftList != null && entity.EmployeeArrangementShiftList.Count > 0)
                {
                    guiChooseArrangementShift guiChooseArrangementShift = new guiChooseArrangementShift(entity.EmployeeArrangementShiftList);
                    guiChooseArrangementShift.Fromdate = objArrangementShiftsInfo.HRArrangementShiftFromDate;
                    guiChooseArrangementShift.Todate = objArrangementShiftsInfo.HRArrangementShiftToDate;
                    guiChooseArrangementShift.Module = this;
                    guiChooseArrangementShift.ShowDialog();
                    if (guiChooseArrangementShift.DialogResult != DialogResult.OK)
                        return;
                    DateTime fromDate = guiChooseArrangementShift.Fromdate;
                    DateTime toDate = guiChooseArrangementShift.Todate;
                    foreach (HREmployeeArrangementShiftsInfo item in guiChooseArrangementShift.SelectedObjects)
                    {
                        SetArrangementShift(item.FK_HREmployeeID, guiChooseArrangementShift.paramID, fromDate, toDate);
                    }
                }
            }
        }

        public void SetArrangementShift(int employeeID, int paramID, DateTime fromDate, DateTime toDate)
        {
            HRArrangementShiftEntities entity = (HRArrangementShiftEntities)CurrentModuleEntity;
            HRArrangementShiftsInfo objArrangementShiftsInfo = (HRArrangementShiftsInfo)entity.MainObject;
            BOSDbUtil dbUtil = new BOSDbUtil();
            int numDays = (int)(toDate.Date - fromDate.Date).TotalDays + 1;
            if (numDays > 31)
            {
                MessageBox.Show("Bạn không thể chọn thời gian xếp ca quá 31 ngày!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HREmployeeArrangementShiftsInfo employeeArrangementShift = entity.EmployeeArrangementShiftList.Where(et => et.FK_HREmployeeID == employeeID).FirstOrDefault();
            if (employeeArrangementShift != null)
            {
                HRWorkingShiftsInfo param;
                List<string> columnFieldNameEndOfWeek = GetColumnFieldNameByTypeEndOfWeek();
                DateTime dateFrom = objArrangementShiftsInfo.HRArrangementShiftFromDate;
                DateTime dateTo = toDate;
                DateTime date = fromDate;
                int i = 1;
                if (date.Date >= dateFrom.Date)
                {
                    i = (int)(date.Date - dateFrom.Date).TotalDays + 1;
                }

                while (date.Date <= dateTo.Date)
                {
                    if (paramID != 0)
                    {
                        String propertyName = String.Format("{0}{1}", "HREmployeeArrangementShiftDate", i);
                        //bool isEndOfWeek = columnFieldNameEndOfWeek.Exists(delegate(string endOfWeek) { return propertyName == endOfWeek; });
                        //if (!isEndOfWeek)
                        //{
                        param = entity.WorkingShifts.Where(p => p.HRWorkingShiftID == paramID).FirstOrDefault();
                        if (employeeID > 0)
                        {
                            if (param != null)
                            {
                                dbUtil.SetPropertyValue(employeeArrangementShift, string.Format("HREmployeeArrangementShiftDate{0}", i), param.HRWorkingShiftID);
                            }
                            UpdateArrangementShift(employeeArrangementShift);
                        }
                        //}
                    }
                    date = date.AddDays(1);
                    i++;
                }
            }

            entity.EmployeeArrangementShiftList.GridControl.RefreshDataSource();
        }
    }
}
