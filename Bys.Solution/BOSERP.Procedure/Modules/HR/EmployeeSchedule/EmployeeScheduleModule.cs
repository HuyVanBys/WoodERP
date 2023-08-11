using BOSCommon;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace BOSERP.Modules.EmployeeSchedule
{
    class EmployeeScheduleModule : BaseModuleERP
    {
        #region Const

        #endregion
        public CheckedComboBoxEdit EmployeeControl;
        public bool isEditOrNew = false;

        public EmployeeScheduleModule()
        {
            Name = "EmployeeSchedule";
            CurrentModuleEntity = new EmployeeScheduleEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

        }

        public void ReRangeModuleList()
        {
            EmployeeScheduleEntities entity = (EmployeeScheduleEntities)CurrentModuleEntity;
            HRSchedulesInfo objMainInfo = (HRSchedulesInfo)entity.MainObject;
            //StampR:
            //    foreach (HREmployeeSchedulesInfo compareInfo in entity.EmployeeScheduleList)
            for (int i = 0; i < entity.EmployeeScheduleList.Count; i++)
            {
                HREmployeeSchedulesInfo compareInfo = entity.EmployeeScheduleList[i];
                if (compareInfo.HREmployeeScheduleWorkDate < objMainInfo.HRScheduleFromDate || compareInfo.HREmployeeScheduleWorkDate > objMainInfo.HRScheduleToDate)
                {
                    entity.EmployeeScheduleList.RemoveAt(i);
                    i--;
                }
            }
        }
        public void removeSelectRow()
        {
            EmployeeScheduleEntities entity = (EmployeeScheduleEntities)CurrentModuleEntity;
            entity.EmployeeScheduleList.RemoveSelectedRowObjectFromList();
        }
        public void AddEmployee()
        {
            if (isEditOrNew)
            {
                try
                {
                    EmployeeScheduleEntities entity = (EmployeeScheduleEntities)CurrentModuleEntity;
                    HRSchedulesInfo objMain = (HRSchedulesInfo)entity.MainObject;
                    if (objMain.HRScheduleFromDate == null || objMain.HRScheduleToDate == null)
                    {
                        MessageBox.Show("Vui lòng chọn thời gian lịch làm việc (Từ ngày, đến ngày)", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        BOSERP.Modules.EmployeeSchedule.UI.guiSearchEmployee guiEmployee = new BOSERP.Modules.EmployeeSchedule.UI.guiSearchEmployee();
                        guiEmployee.Module = this;

                        if (guiEmployee.ShowDialog() == DialogResult.OK)
                        {

                            if (guiEmployee.SelectedEmployeeList.Count > 0)
                            {
                                entity.EmployeeList.Invalidate(guiEmployee.SelectedEmployeeList);
                                HRWorkingShiftsController objWorkingShiftController = new HRWorkingShiftsController();
                                List<HRWorkingShiftsInfo> objWorkingShiftInfoList = objWorkingShiftController.GetWorkingShiftByPayrollFormulaID(guiEmployee.guiEmployeePayrollFormulaID);
                                List<string> workingName = new List<string>();
                                foreach (HRWorkingShiftsInfo info in objWorkingShiftInfoList)
                                {
                                    if (workingName.Count == 0)
                                    {
                                        workingName.Add(info.HRWorkingShiftName);
                                    }
                                    else
                                    {
                                        bool isNameExist = false;
                                        for (int b = 0; b < workingName.Count; b++)
                                        {
                                            if (info.HRWorkingShiftName == workingName[b])
                                            {
                                                isNameExist = true;
                                                break;
                                            }
                                        }
                                        if (!isNameExist)
                                        {
                                            workingName.Add(info.HRWorkingShiftName);
                                        }
                                    }
                                }
                                lst = string.Empty;
                                for (int q = 0; q < workingName.Count; q++)
                                {
                                    if (q == workingName.Count - 1)
                                    {
                                        lst += workingName[q];
                                    }
                                    else
                                    {
                                        lst += workingName[q] + ",";
                                    }
                                }

                                for (int i = 0; i < objWorkingShiftInfoList.Count; i++)
                                {
                                    if (!objWorkingShiftInfoList[i].HRWorkingShiftIsDefault)
                                    {
                                        objWorkingShiftInfoList.RemoveAt(i);
                                        i--;
                                    }
                                }
                                BOSList<HREmployeeSchedulesInfo> lstFinal = new BOSList<HREmployeeSchedulesInfo>();
                                _toDate = objMain.HRScheduleToDate;
                                _fromDate = objMain.HRScheduleFromDate;


                                DateTime toDate = objMain.HRScheduleToDate;
                                DateTime fromDate = objMain.HRScheduleFromDate;
                                usedWorkingShift = new List<HRWorkingShiftsInfo>();
                                while (fromDate <= toDate)
                                {
                                    string sheet = string.Empty;
                                    int fk_HRWorkingShiftID = 0;

                                    foreach (HRWorkingShiftsInfo winfo in objWorkingShiftInfoList)
                                    {

                                        if (getDayOfWeek(fromDate) == winfo.HRWorkingShiftDayOffWeek)
                                        {
                                            sheet = winfo.HRWorkingShiftName;
                                            fk_HRWorkingShiftID = winfo.HRWorkingShiftID;
                                            usedWorkingShift.Add(winfo);
                                        }
                                        if (sheet == string.Empty && winfo.HRWorkingShiftDayOffWeek == "All")
                                        {
                                            sheet = winfo.HRWorkingShiftName;
                                            fk_HRWorkingShiftID = winfo.HRWorkingShiftID;
                                            usedWorkingShift.Add(winfo);
                                        }
                                    }
                                    foreach (HREmployeesInfo info in entity.EmployeeList)
                                    {
                                        lstFinal.Add(new HREmployeeSchedulesInfo
                                        {
                                            EmployeeName = info.HREmployeeName,
                                            EmployeeNo = info.HREmployeeNo,
                                            HREmployeeScheduleWorkDate = fromDate,
                                            Sheet = sheet,
                                            FK_HRWorkingShiftID = fk_HRWorkingShiftID,
                                            FK_HREmployeeID = info.HREmployeeID
                                        });
                                    }
                                    fromDate = fromDate.AddDays(1);
                                }

                                if (entity.EmployeeScheduleList.Count > 0)
                                {
                                    //TNDLoc [MOD][23/09/2015][Improve Code],START
                                    //    foreach (HREmployeeSchedulesInfo checkInfo in lstFinal)
                                    for (int i = 0; i < entity.EmployeeScheduleList.Count; i++)
                                    {
                                        HREmployeeSchedulesInfo compareInfo = entity.EmployeeScheduleList[i];
                                        for (int j = 0; j < lstFinal.Count; j++)
                                        {
                                            HREmployeeSchedulesInfo checkInfo = lstFinal[j];
                                            if (checkInfo.FK_HREmployeeID == compareInfo.FK_HREmployeeID && checkInfo.HREmployeeScheduleWorkDate == compareInfo.HREmployeeScheduleWorkDate)
                                            {
                                                lstFinal.RemoveAt(j);
                                                j--;
                                            }
                                        }
                                    }
                                    foreach (HREmployeeSchedulesInfo addInfo in lstFinal)
                                    {
                                        entity.EmployeeScheduleList.Add(addInfo);
                                    }
                                    HRSchedulesInfo objMainInfo = (HRSchedulesInfo)entity.MainObject;
                                    //TNDLoc [MOD][23/09/2015][Improve Code],START
                                    //    foreach (HREmployeeSchedulesInfo compareInfo in entity.EmployeeScheduleList)
                                    for (int i = 0; i < entity.EmployeeScheduleList.Count; i++)
                                    {
                                        HREmployeeSchedulesInfo compareInfo = entity.EmployeeScheduleList[i];
                                        if (compareInfo.HREmployeeScheduleWorkDate < objMainInfo.HRScheduleFromDate || compareInfo.HREmployeeScheduleWorkDate > objMainInfo.HRScheduleToDate)
                                        {
                                            entity.EmployeeScheduleList.RemoveAt(i);
                                            i--;
                                        }
                                    }
                                    //   lstFinal = entity.EmployeeScheduleList;
                                }
                                if (entity.EmployeeScheduleList.Count == 0)
                                {
                                    entity.EmployeeScheduleList.Invalidate(lstFinal);
                                }

                                //[Remove SunDay, Start]
                                HRCalendarEntrysController objCalendarEntrysController = new HRCalendarEntrysController();
                                DateTime firstDay = new DateTime(DateTime.Now.Year, 1, 1);
                                DateTime lastDay = new DateTime(DateTime.Now.Year, 12, 31);
                                List<HRCalendarEntrysInfo> objCalendarEntrysList = objCalendarEntrysController.GetCalendarEntryByDateAndCalenderType(CalenderType.Holiday.ToString(), firstDay, lastDay);
                                List<DateTime> objHolidayTimesList = new List<DateTime>();
                                foreach (HRCalendarEntrysInfo calendar in objCalendarEntrysList)
                                {
                                    objHolidayTimesList.Add(calendar.HRCalendarEntryDate.Date);
                                }

                                for (int i = 0; i < entity.EmployeeScheduleList.Count; i++)
                                {
                                    HREmployeeSchedulesInfo objEmployeeSchedule = entity.EmployeeScheduleList[i];
                                    if (getDayOfWeek(objEmployeeSchedule.HREmployeeScheduleWorkDate) == "CN")
                                    {
                                        entity.EmployeeScheduleList.RemoveAt(i);
                                        i--;
                                    }
                                    else if (objHolidayTimesList.Contains(objEmployeeSchedule.HREmployeeScheduleWorkDate.Date))
                                    {
                                        entity.EmployeeScheduleList.RemoveAt(i);
                                        i--;
                                    }
                                }
                                //[Remove SunDay, End]

                                UpdateEmployeeScheduleList(entity);
                                // initRLKEDataSource();
                                //entity.EmployeeScheduleList.Clear();
                                //entity.EmployeeScheduleList.Invalidate(lstFinal);
                                entity.initRLKEDataSource();
                                entity.EmployeeScheduleList.GridControl.RefreshDataSource();

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi, vui lòng thử lại", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void UpdateEmployeeScheduleList(EmployeeScheduleEntities entity)
        {
            HRWorkingShiftsController objWSController = new HRWorkingShiftsController();
            HRWorkingShiftsInfo objWSInfo = new HRWorkingShiftsInfo();
            List<HREmployeeSchedulesInfo> lst = new List<HREmployeeSchedulesInfo>();
            foreach (HREmployeeSchedulesInfo objEmployeeSchedule in entity.EmployeeScheduleList)
            {
                objWSInfo = (HRWorkingShiftsInfo)objWSController.GetObjectByID(objEmployeeSchedule.FK_HRWorkingShiftID);
                if (objWSInfo != null)
                {
                    objEmployeeSchedule.Sheet = objWSInfo.HRWorkingShiftName;
                    objEmployeeSchedule.HREmployeeScheduleFromTime = new DateTime(objEmployeeSchedule.HREmployeeScheduleWorkDate.Year, objEmployeeSchedule.HREmployeeScheduleWorkDate.Month, objEmployeeSchedule.HREmployeeScheduleWorkDate.Day, objWSInfo.HRWorkingShiftFromTime.Hour, objWSInfo.HRWorkingShiftFromTime.Minute, 0);
                    objEmployeeSchedule.HREmployeeScheduleToTime = new DateTime(objEmployeeSchedule.HREmployeeScheduleWorkDate.Year, objEmployeeSchedule.HREmployeeScheduleWorkDate.Month, objEmployeeSchedule.HREmployeeScheduleWorkDate.Day, objWSInfo.HRWorkingShiftToTime.Hour, objWSInfo.HRWorkingShiftToTime.Minute, 0);
                }
                lst.Add(objEmployeeSchedule);
            }
            entity.EmployeeScheduleList.GridControl.RefreshDataSource();

        }
        public void UpdateEmployeeScheduleList()
        {
            EmployeeScheduleEntities entity = (EmployeeScheduleEntities)CurrentModuleEntity;
            HRWorkingShiftsController objWSController = new HRWorkingShiftsController();
            HRWorkingShiftsInfo objWSInfo = new HRWorkingShiftsInfo();
            List<HREmployeeSchedulesInfo> lst = new List<HREmployeeSchedulesInfo>();
            foreach (HREmployeeSchedulesInfo objEmployeeSchedule in entity.EmployeeScheduleList)
            {
                objWSInfo = (HRWorkingShiftsInfo)objWSController.GetObjectByID(objEmployeeSchedule.FK_HRWorkingShiftID);
                objEmployeeSchedule.Sheet = objWSInfo.HRWorkingShiftName;
                objEmployeeSchedule.HREmployeeScheduleFromTime = new DateTime(objEmployeeSchedule.HREmployeeScheduleWorkDate.Year, objEmployeeSchedule.HREmployeeScheduleWorkDate.Month, objEmployeeSchedule.HREmployeeScheduleWorkDate.Day, objWSInfo.HRWorkingShiftFromTime.Hour, objWSInfo.HRWorkingShiftFromTime.Minute, 0);
                objEmployeeSchedule.HREmployeeScheduleToTime = new DateTime(objEmployeeSchedule.HREmployeeScheduleWorkDate.Year, objEmployeeSchedule.HREmployeeScheduleWorkDate.Month, objEmployeeSchedule.HREmployeeScheduleWorkDate.Day, objWSInfo.HRWorkingShiftToTime.Hour, objWSInfo.HRWorkingShiftToTime.Minute, 0);
                lst.Add(objEmployeeSchedule);
            }
            entity.EmployeeScheduleList.GridControl.RefreshDataSource();

        }
        public List<HRWorkingShiftsInfo> usedWorkingShift = null;
        public string getWorkingShiftString(List<HRWorkingShiftsInfo> objWorkingShiftInfoList)
        {
            HRWorkingShiftsController objWorkingShiftController = new HRWorkingShiftsController();

            List<string> workingName = new List<string>();
            foreach (HRWorkingShiftsInfo info in objWorkingShiftInfoList)
            {
                if (workingName.Count == 0)
                {
                    workingName.Add(info.HRWorkingShiftName);
                }
                else
                {
                    bool isNameExist = false;
                    for (int b = 0; b < workingName.Count; b++)
                    {
                        if (info.HRWorkingShiftName == workingName[b])
                        {
                            isNameExist = true;
                            break;
                        }
                    }
                    if (!isNameExist)
                    {
                        workingName.Add(info.HRWorkingShiftName);
                    }
                }
            }
            string returnLst = string.Empty;
            for (int q = 0; q < workingName.Count; q++)
            {
                if (q == workingName.Count - 1)
                {
                    returnLst += workingName[q];
                }
                else
                {
                    returnLst += workingName[q] + ",";
                }
            }
            return returnLst;
        }
        public string getDayOfWeek(DateTime day)
        {
            switch (day.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    return "T2";
                case DayOfWeek.Tuesday:
                    return "T3";
                case DayOfWeek.Wednesday:
                    return "T4";
                case DayOfWeek.Thursday:
                    return "T5";
                case DayOfWeek.Friday:
                    return "T6";
                case DayOfWeek.Saturday:
                    return "T7";
                default:
                    return "CN";
            }
        }
        public DateTime _toDate;
        public DateTime _fromDate;
        public List<ExportExcelParameter> GetExcelContent()
        {

            EmployeeScheduleEntities entity = (EmployeeScheduleEntities)CurrentModuleEntity;
            List<HREmployeeSchedulesInfo> employeeScheduleList = entity.EmployeeScheduleList;
            DataTable table = new DataTable();

            //Init Column EmployeeID, EmployeeName, Date [Start]
            //Column [EmployeeNo]
            DataColumn col = new DataColumn();
            col.ColumnName = "Mã nhân viên";
            table.Columns.Add(col);
            //Column [EmployeeName]
            col = new DataColumn();
            col.ColumnName = "Tên nhân viên";
            table.Columns.Add(col);
            //Column [WorkingDate]
            DateTime DateFrom = _fromDate;
            DateTime DateTo = _toDate;

            while (DateFrom <= DateTo)
            {
                col = new DataColumn();
                col.ColumnName = String.Format("{0:MM/dd/yyyy}", DateFrom);
                table.Columns.Add(col);
                DateFrom = DateFrom.AddDays(1);
            }
            //Init Column EmployeeID, EmployeeName, Date [End]
            //Get EmployeeNo, EmployeeName [Start]
            List<string> lstEmployeeNo = new List<string>();
            List<string> lstNameStr = new List<string>();
            foreach (var objEmployeeSchedule in employeeScheduleList)
            {
                //if (lstEmployeeNo.Count == 0)
                //{
                //    lstEmployeeNo.Add(objEmployeeSchedule.EmployeeNo);
                //    lstNameStr.Add(objEmployeeSchedule.EmployeeName);
                //}
                //else
                //{
                //    bool isEmployeeNoExist = false;
                //    foreach (string objEmployeeNo in lstEmployeeNo)
                //    {
                //        if (objEmployeeNo == objEmployeeSchedule.EmployeeNo)
                //        {
                //            isEmployeeNoExist = true;
                //        }
                //    }
                //    if (!isEmployeeNoExist)
                //    {
                //        lstEmployeeNo.Add(objEmployeeSchedule.EmployeeNo);
                //        lstNameStr.Add(objEmployeeSchedule.EmployeeName);
                //    }
                //}
                if (!lstEmployeeNo.Contains(objEmployeeSchedule.EmployeeNo))
                {
                    lstEmployeeNo.Add(objEmployeeSchedule.EmployeeNo);
                    lstNameStr.Add(objEmployeeSchedule.EmployeeName);
                }

            }
            //Get EmployeeNo, EmployeeName [End]
            for (int i = 0; i < lstEmployeeNo.Count; i++)
            {

                DataRow row = table.NewRow();
                row[0] = lstEmployeeNo[i];
                row[1] = lstNameStr[i];
                int introw = 2;
                for (int j = 0; j < employeeScheduleList.Count; j++)
                {
                    if (employeeScheduleList[j].EmployeeName == lstNameStr[i])
                    {
                        string columnName = String.Format("{0:MM/dd/yyyy}", employeeScheduleList[j].HREmployeeScheduleWorkDate);

                        row[columnName] = employeeScheduleList[j].Sheet;
                        introw++;
                    }

                }
                table.Rows.Add(row);
            }

            List<ExportExcelParameter> lstContentParameter = new List<ExportExcelParameter>();
            lstContentParameter.Add(new ExportExcelParameter(1, 1, table));
            return lstContentParameter;
        }

        public string lst = string.Empty;
        public void ExportToExcel()
        {
            if (isEditOrNew)
            {
                EmployeeScheduleEntities entity = (EmployeeScheduleEntities)CurrentModuleEntity;
                HRSchedulesInfo mainInfo = (HRSchedulesInfo)entity.MainObject;
                _toDate = mainInfo.HRScheduleToDate;
                _fromDate = mainInfo.HRScheduleFromDate;
                if (entity.EmployeeScheduleList.Count > 0)
                {
                    if (lst == string.Empty)
                    {
                        HREmployeesController controller = new HREmployeesController();
                        HREmployeesInfo info = (HREmployeesInfo)controller.GetObjectByID(entity.EmployeeScheduleList[0].FK_HREmployeeID);
                        HRWorkingShiftsController wController = new HRWorkingShiftsController();
                        List<HRWorkingShiftsInfo> lstWorkingShift = wController.GetWorkingShiftByPayrollFormulaID(info.FK_HREmployeePayrollFormulaID);
                        lst = getWorkingShiftString(lstWorkingShift);
                    }
                    List<ExportExcelParameter> lstParameter = new List<ExportExcelParameter>();
                    lstParameter.AddRange(GetExcelContent());
                    ExcelExporter.ExportToExcel(lstParameter, lst);
                }
            }
        }

        public override void ActionNew()
        {
            base.ActionNew();
            isEditOrNew = true;
        }

        public override void ActionEdit()
        {
            base.ActionEdit();
            isEditOrNew = true;
        }
        public override void ActionCancel()
        {
            isEditOrNew = false;
            base.ActionCancel();

        }
        public override int ActionSave()
        {
            isEditOrNew = false;
            int iObjectID = 0;
            if (!Toolbar.IsNullOrNoneAction())
            {
                Cursor.Current = Cursors.WaitCursor;
                if (!IsInvalidInput())
                {
                    try
                    {
                        iObjectID = Toolbar.Save();
                        if (iObjectID > 0)
                        {
                            CurrentModuleEntity.MainObject.OldObject = (BusinessObject)CurrentModuleEntity.MainObject.Clone();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(BaseLocalizedResources.SaveObjectErrorMessage,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    if (iObjectID > 0)
                    {
                        ModuleAfterSaved(iObjectID);
                        if (Owner != null)
                        {
                            ModuleParentScreen ownerParentScreen = Owner.ParentScreen;
                            Owner = null;
                            ownerParentScreen.Activate();
                        }
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            return iObjectID;

        }

        public override void Invalidate(int iObjectID)
        {
            isEditOrNew = false;
            base.Invalidate(iObjectID);
            isEditOrNew = false;
            lst = string.Empty;
        }
        #region Import From Excel
        private TextEdit FileTextEdit;

        public string ChooseFile()
        {
            if (isEditOrNew)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "Excel files 2002-2003 (*.xls)|*.xls|Excel files 2007-2010 (*.xlsx)|*.xlsx";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                FileTextEdit = new TextEdit();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileTextEdit.Text = openFileDialog.FileName.ToString();
                }
                return FileTextEdit.Text;
            }
            return "";
        }

        public void ImportCommissionFromExcel()
        {
            try
            {
                if (isEditOrNew)
                {
                    if (FileTextEdit != null)
                    {
                        BOSProgressBar.Start("Đang xử lý dữ liệu");
                        string curFile = FileTextEdit.Text;

                        if (File.Exists(curFile))
                        {
                            EmployeeScheduleEntities entity = (EmployeeScheduleEntities)CurrentModuleEntity;

                            Microsoft.Office.Interop.Excel.Application xlApp;
                            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                            Microsoft.Office.Interop.Excel.Range range;

                            xlApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                            xlWorkBook = xlApp.Workbooks.Open(curFile, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                            range = xlWorkSheet.UsedRange;
                            //Init HREmployeeScheduleList [START]
                            BOSList<HREmployeeSchedulesInfo> list = entity.EmployeeScheduleList;

                            HRWorkingShiftsController objWorkingShiftsController = new HRWorkingShiftsController();
                            List<HRWorkingShiftsInfo> lstWorkingShiftsInfo = new List<HRWorkingShiftsInfo>();
                            HREmployeesController objEmployeesController = new HREmployeesController();
                            HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
                            List<int> deleteList = new List<int>();

                            int count = 0;
                            List<HREmployeeSchedulesInfo> dataFromExcel = new List<HREmployeeSchedulesInfo>();

                            for (int i = 3; i <= range.Columns.Count; i++)
                            {

                                for (int j = 2; j <= range.Rows.Count; j++)
                                {

                                    string EmployeeNo = (string)(range.Cells[j, 1] as Microsoft.Office.Interop.Excel.Range).Value2;
                                    string EmployeeName = (string)(range.Cells[j, 2] as Microsoft.Office.Interop.Excel.Range).Value2;
                                    DateTime WorkingDate = DateTime.FromOADate((double)(range.Cells[1, i] as Microsoft.Office.Interop.Excel.Range).Value2);

                                    string WorkingShift = (string)(range.Cells[j, i] as Microsoft.Office.Interop.Excel.Range).Value2;

                                    dataFromExcel.Add(new HREmployeeSchedulesInfo
                                    {
                                        HREmployeeScheduleID = count,
                                        HREmployeeScheduleWorkDate = WorkingDate,
                                        EmployeeName = EmployeeName,
                                        EmployeeNo = EmployeeNo,
                                        Sheet = WorkingShift
                                    });
                                    count++;


                                }
                            }
                            List<int> indexForDelete = new List<int>();
                            for (int i = 0; i < entity.EmployeeScheduleList.Count; i++)
                            {
                                foreach (HREmployeeSchedulesInfo infos in dataFromExcel)
                                {


                                    if (infos.EmployeeNo == entity.EmployeeScheduleList[i].EmployeeNo && infos.HREmployeeScheduleWorkDate == entity.EmployeeScheduleList[i].HREmployeeScheduleWorkDate)
                                    {
                                        if (infos.Sheet == null || infos.Sheet == "")
                                        {
                                            indexForDelete.Add(i);
                                        }
                                        else
                                        {

                                            objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(entity.EmployeeScheduleList[i].FK_HREmployeeID);
                                            lstWorkingShiftsInfo = objWorkingShiftsController.GetWorkingShiftByPayrollFormulaID(objEmployeesInfo.FK_HREmployeePayrollFormulaID);
                                            foreach (HRWorkingShiftsInfo wks in lstWorkingShiftsInfo)
                                            {
                                                if (wks.HRWorkingShiftName == infos.Sheet)
                                                {
                                                    entity.EmployeeScheduleList[i].FK_HRWorkingShiftID = wks.HRWorkingShiftID;
                                                    entity.EmployeeScheduleList[i].Sheet = wks.HRWorkingShiftName;
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }

                            }
                            foreach (HREmployeeSchedulesInfo infos in dataFromExcel)
                            {
                                if (infos.Sheet != null)
                                {
                                    bool isExist = false;
                                    foreach (var einfo in entity.EmployeeScheduleList)
                                    {
                                        if (infos.EmployeeNo == einfo.EmployeeNo && einfo.HREmployeeScheduleWorkDate == infos.HREmployeeScheduleWorkDate)
                                        {
                                            isExist = true;
                                            break;
                                        }
                                    }
                                    if (!isExist)
                                    {
                                        int FK_EmployeeID = 0;
                                        foreach (var einfo in entity.EmployeeScheduleList)
                                        {
                                            if (infos.EmployeeNo == einfo.EmployeeNo)
                                            {
                                                FK_EmployeeID = einfo.FK_HREmployeeID;
                                                break;
                                            }
                                        }
                                        infos.FK_HREmployeeID = FK_EmployeeID;
                                        foreach (HRWorkingShiftsInfo wks in lstWorkingShiftsInfo)
                                        {
                                            if (wks.HRWorkingShiftName == infos.Sheet)
                                            {
                                                infos.FK_HRWorkingShiftID = wks.HRWorkingShiftID;

                                                break;
                                            }
                                        }
                                        entity.EmployeeScheduleList.Add(infos);
                                    }
                                }

                            }
                            List<HREmployeeSchedulesInfo> deletelist = new List<HREmployeeSchedulesInfo>();
                            foreach (int id in indexForDelete)
                            {
                                deletelist.Add(entity.EmployeeScheduleList[id]);

                            }
                            foreach (HREmployeeSchedulesInfo d in deletelist)
                            {
                                entity.EmployeeScheduleList.Remove(d);
                            }
                            UpdateEmployeeScheduleList(entity);
                            // entity.EmployeeScheduleList.Invalidate(list);

                            entity.EmployeeScheduleList.GridControl.RefreshDataSource();
                            //Init HREmployeeScheduleList [END]
                            xlWorkBook.Close(true, null, null);
                            xlApp.Quit();

                            releaseObject(xlWorkSheet);
                            releaseObject(xlWorkBook);
                            releaseObject(xlApp);
                            BOSProgressBar.Close();
                            MessageBox.Show("Import Successfull", "#Message#", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                BOSProgressBar.Close();
                MessageBox.Show("Dữ liệu Import không đúng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        #endregion
        #region LookupEdit gridControl]
        public RepositoryItemLookUpEdit reLKEWorkingShift;
        public void initRLKEWorkingShift()
        {
            reLKEWorkingShift = new RepositoryItemLookUpEdit();
            reLKEWorkingShift.AutoHeight = false;
            //reLKEWorkingShift.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            //new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reLKEWorkingShift.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRWorkingShiftName", "Ca làm việc")});
            reLKEWorkingShift.DisplayMember = "HRWorkingShiftName";
            reLKEWorkingShift.ValueMember = "HRWorkingShiftID";

        }
        public List<HRWorkingShiftsInfo> getRLKEDataSource()
        {
            EmployeeScheduleEntities entity = (EmployeeScheduleEntities)CurrentModuleEntity;
            List<HRWorkingShiftsInfo> returnList = new List<HRWorkingShiftsInfo>();
            if (entity.EmployeeScheduleList.Count > 0)
            {
                HREmployeesController employeeController = new HREmployeesController();
                HREmployeesInfo employeeInfo = (HREmployeesInfo)employeeController.GetObjectByID(entity.EmployeeScheduleList[0].FK_HREmployeeID);
                HRWorkingShiftsController workingController = new HRWorkingShiftsController();
                returnList = workingController.GetWorkingShiftByPayrollFormulaID(employeeInfo.FK_HREmployeePayrollFormulaID);
            }
            return returnList;
        }
        public void initRLKEDataSource()
        {
            initRLKEWorkingShift();
            reLKEWorkingShift.DataSource = getRLKEDataSource();
            EmployeeScheduleEntities entity = (EmployeeScheduleEntities)CurrentModuleEntity;

            entity.EmployeeScheduleList.GridControl.Columns["Sheet"].ColumnEdit = reLKEWorkingShift;

        }
        #endregion
    }
}
