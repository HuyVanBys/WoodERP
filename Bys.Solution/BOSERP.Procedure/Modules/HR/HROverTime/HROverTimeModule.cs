using BOSCommon;
using BOSComponent;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.HROverTime
{
    public class HROverTimeModule : BaseModuleERP
    {
        public HROverTimeModule()
        {
            Name = "HROverTime";
            CurrentModuleEntity = new HROverTimeEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }
        public override int ActionSave()
        {
            HROverTimeEntities entity = (HROverTimeEntities)CurrentModuleEntity;
            HROverTimesInfo obj = (HROverTimesInfo)entity.MainObject;
            DateTime d = obj.HROverTimeDate;
            DateTime dto = obj.HROverTimeDateEnd;
            obj.HROverTimeFromDate = new DateTime(d.Year, d.Month, d.Day, obj.HROverTimeFromDate.Hour, obj.HROverTimeFromDate.Minute, 0);
            obj.HROverTimeToDate = new DateTime(dto.Year, dto.Month, dto.Day, obj.HROverTimeToDate.Hour, obj.HROverTimeToDate.Minute, 0);
            Check();

            #region Nếu NV dưới 18 thì không lưu
            string arrID = " ";
            entity.HREmployeeOTList.ForEach(o => arrID += o.FK_HREmployeeID.ToString() + ",");
            arrID = arrID.Substring(0, arrID.Length - 1);
            HREmployeesController objEmployeesController = new HREmployeesController();
            List<HREmployeesInfo> lstEmployees = objEmployeesController.GetAllObjectsByIDList(arrID);
            if (lstEmployees.Exists(o => (o.HREmployeeDob.Date != DateTime.MaxValue.Date && o.HREmployeeDob.Date < DateTime.MaxValue.AddYears(-18).Date && (o.HREmployeeDob.AddYears(18) > BOSApp.GetCurrentServerDate()))))
            {
                string arrEmployeeName = " ";
                lstEmployees.Where(o => o.HREmployeeDob.AddYears(18) > BOSApp.GetCurrentServerDate()).ToList().ForEach(o => arrEmployeeName += o.HREmployeeName.ToString() + ",");
                arrEmployeeName = arrEmployeeName.Substring(0, arrEmployeeName.Length - 1);
                MessageBox.Show(string.Format("Nhân viên: {0} hiện đang dưới 18 tuổi!", arrEmployeeName), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            #endregion

            return base.ActionSave();
        }

        public override void InvalidateToolbar()
        {
            HROverTimesInfo objOverTimesInfo = (HROverTimesInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton("Approved", false);
            ParentScreen.SetEnableOfToolbarButton("UnApproved", false);
            if (objOverTimesInfo.HROverTimeID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton("Approved", false);
                ParentScreen.SetEnableOfToolbarButton("UnApproved", false);
                ParentScreen.SetEnableOfToolbarButton("Confirmed", true);
                if (objOverTimesInfo.HROverTimeStatus == OverTimeStatus.Confirmed.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonComplete, true);
                    ParentScreen.SetEnableOfToolbarButton("Confirmed", false);
                    ParentScreen.SetEnableOfToolbarButton("Approved", true);
                    ParentScreen.SetEnableOfToolbarButton("UnApproved", false);
                }
                if (objOverTimesInfo.HROverTimeStatus == OverTimeStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Confirmed", false);
                    ParentScreen.SetEnableOfToolbarButton("Approved", false);
                    ParentScreen.SetEnableOfToolbarButton("UnApproved", true);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                }
            }

            base.InvalidateToolbar();
        }

        /// <summary>
        /// Add employee to the current overtime list
        /// </summary>
        public void AddEmployeeToOTList()
        {
            HROverTimeEntities entity = (HROverTimeEntities)CurrentModuleEntity;
            HROverTimesInfo objOverTimesInfo = (HROverTimesInfo)entity.MainObject;
            BOSERP.Modules.HROverTime.UI.guiSearchEmployee guiEmployee = new BOSERP.Modules.HROverTime.UI.guiSearchEmployee();
            guiEmployee.Module = this;
            guiEmployee.EmployeeOTDate = objOverTimesInfo.HROverTimeDate;
            guiEmployee.EmployeeOTDateEnd = objOverTimesInfo.HROverTimeDateEnd;
            guiEmployee.EmployeeOTFromDate = objOverTimesInfo.HROverTimeFromDate;
            guiEmployee.EmployeeOTToDate = objOverTimesInfo.HROverTimeToDate;
            if (guiEmployee.ShowDialog() == DialogResult.OK)
            {
                entity.HREmployeeList.Invalidate(guiEmployee.SelectedEmployeeList);
                foreach (HREmployeesInfo objEmployeesInfo in entity.HREmployeeList)
                {
                    if (objEmployeesInfo.Selected)
                    {
                        if (!entity.HREmployeeOTList.Exists("FK_HREmployeeID", objEmployeesInfo.HREmployeeID))
                        {
                            DateTime employeeOTDate = objEmployeesInfo.HREmployeeOTDate;
                            DateTime employeeOTDateEnd = objEmployeesInfo.HREmployeeOTDateEnd;
                            HREmployeeOTsInfo objEmployeeOTsInfo = new HREmployeeOTsInfo();
                            objEmployeeOTsInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                            objEmployeeOTsInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
                            objEmployeeOTsInfo.FK_HRDepartmentID = objEmployeesInfo.FK_HRDepartmentID;
                            objEmployeeOTsInfo.FK_HRDepartmentRoomID = objEmployeesInfo.FK_HRDepartmentRoomID;
                            objEmployeeOTsInfo.FK_HRDepartmentRoomGroupItemID = objEmployeesInfo.FK_HRDepartmentRoomGroupItemID;
                            objEmployeeOTsInfo.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
                            objOverTimesInfo.HREmployeeCardNumber += objEmployeesInfo.HREmployeeCardNumber;
                            objOverTimesInfo.HREmployeeName += objEmployeesInfo.HREmployeeName;
                            objEmployeeOTsInfo.HREmployeeOTDate = employeeOTDate;
                            objEmployeeOTsInfo.HROverTimeDate = employeeOTDate;
                            objEmployeeOTsInfo.HREmployeeOTDateEnd = employeeOTDateEnd;
                            objEmployeeOTsInfo.HREmployeeOTFromDate = new DateTime(employeeOTDate.Year, employeeOTDate.Month, employeeOTDate.Day, objEmployeesInfo.HREmployeeOTFromDate.Hour, objEmployeesInfo.HREmployeeOTFromDate.Minute, 0);
                            objEmployeeOTsInfo.HREmployeeOTToDate = new DateTime(employeeOTDateEnd.Year, employeeOTDateEnd.Month, employeeOTDateEnd.Day, objEmployeesInfo.HREmployeeOTToDate.Hour, objEmployeesInfo.HREmployeeOTToDate.Minute, 0);
                            if (entity.HREmployeeList.Count > 1)
                            {
                                objOverTimesInfo.HREmployeeCardNumber = objOverTimesInfo.HREmployeeCardNumber + ";";
                                objOverTimesInfo.HREmployeeName = objOverTimesInfo.HREmployeeName + ";";
                            }
                            objEmployeeOTsInfo.HREmployeeOTFactor = objOverTimesInfo.HROverTimeFactor;
                            entity.HREmployeeOTList.Add(objEmployeeOTsInfo);
                        }
                    }
                }
                entity.HREmployeeOTList.GridControl.RefreshDataSource();
            }
        }

        public void AddEmployeeToOTListByCard()
        {
            HROverTimeEntities entity = (HROverTimeEntities)CurrentModuleEntity;
            HROverTimesInfo objOverTimesInfo = (HROverTimesInfo)entity.MainObject;
            HREmployeesController iCEmployeesController = new HREmployeesController();
            HREmployeesInfo iCEmployeesInfo = new HREmployeesInfo();

            int companyID = BOSApp.CurrentCompanyInfo.CSCompanyID;
            string listEmployeeCardNumber = string.Empty;

            guiChooseEmployee guiGetEmployeeCardNumberNo = new guiChooseEmployee();
            guiGetEmployeeCardNumberNo.Module = this;
            if (guiGetEmployeeCardNumberNo.ShowDialog() == DialogResult.OK)
            {
                listEmployeeCardNumber = guiGetEmployeeCardNumberNo.ListEmployee;
            }
            List<HREmployeesInfo> EmployeesList;


            if (listEmployeeCardNumber.Trim() != string.Empty)
            {
                EmployeesList = new List<HREmployeesInfo>();
                string[] EmployeeNo = listEmployeeCardNumber.Split(',');
                if (EmployeeNo.Length > 350)
                {
                    string splitEmployeeCardNumber = string.Empty;
                    int count = 0;
                    for (int i = 0; i < EmployeeNo.Length; i++)
                    {
                        if (count == 350 || i == EmployeeNo.Length - 1)
                        {
                            List<HREmployeesInfo> EmployeesListsplit = iCEmployeesController.GetEmployeeListEmployeeNo(splitEmployeeCardNumber);
                            if (EmployeesListsplit != null)
                            {
                                EmployeesList.AddRange(EmployeesListsplit);
                            }
                            count = 0;
                            splitEmployeeCardNumber = string.Empty;
                        }
                        if (splitEmployeeCardNumber == string.Empty)
                            splitEmployeeCardNumber = EmployeeNo[i];
                        else
                            splitEmployeeCardNumber = splitEmployeeCardNumber + "," + EmployeeNo[i];
                        count++;
                    }
                }
                else
                {
                    EmployeesList = iCEmployeesController.GetEmployeeListEmployeeNo(listEmployeeCardNumber);
                }
                if (EmployeesList != null && EmployeesList.Count > 0)
                {
                    entity.HREmployeeList.Invalidate(EmployeesList);
                    foreach (HREmployeesInfo objEmployeesInfo in entity.HREmployeeList)
                    {
                        if (!entity.HREmployeeOTList.Exists("FK_HREmployeeID", objEmployeesInfo.HREmployeeID))
                        {
                            HREmployeeOTsInfo objEmployeeOTsInfo = new HREmployeeOTsInfo();
                            objEmployeeOTsInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                            objEmployeeOTsInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
                            objEmployeeOTsInfo.FK_HRDepartmentID = objEmployeesInfo.FK_HRDepartmentID;
                            objEmployeeOTsInfo.FK_HRDepartmentRoomID = objEmployeesInfo.FK_HRDepartmentRoomID;
                            objEmployeeOTsInfo.FK_HRDepartmentRoomGroupItemID = objEmployeesInfo.FK_HRDepartmentRoomGroupItemID;
                            objEmployeeOTsInfo.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
                            objOverTimesInfo.HREmployeeCardNumber += objEmployeesInfo.HREmployeeCardNumber;
                            objOverTimesInfo.HREmployeeName += objEmployeesInfo.HREmployeeName;
                            objEmployeeOTsInfo.HREmployeeOTDate = objOverTimesInfo.HROverTimeDate;
                            objEmployeeOTsInfo.HREmployeeOTDateEnd = objOverTimesInfo.HROverTimeDateEnd;
                            objEmployeeOTsInfo.HREmployeeOTFromDate = objOverTimesInfo.HROverTimeFromDate;
                            objEmployeeOTsInfo.HREmployeeOTToDate = objOverTimesInfo.HROverTimeToDate;

                            if (entity.HREmployeeList.Count > 1)
                            {
                                objOverTimesInfo.HREmployeeCardNumber = objOverTimesInfo.HREmployeeCardNumber + ";";
                                objOverTimesInfo.HREmployeeName = objOverTimesInfo.HREmployeeName + ";";
                            }
                            entity.HREmployeeOTList.Add(objEmployeeOTsInfo);
                        }
                    }
                    entity.HREmployeeOTList.GridControl.RefreshDataSource();
                }
            }
        }
        public override void ActionEdit()
        {
            if (!isInvalidate)
            {
                base.ActionEdit();
            }



        }

        public bool isInvalidate = false;
        public override void Invalidate(int iObjectID)
        {
            isInvalidate = true;
            base.Invalidate(iObjectID);
            BOSTextBox t1 = (BOSTextBox)this.Controls["fld_txtHROverTimeFromDate"];
            BOSTextBox t2 = (BOSTextBox)this.Controls["fld_txtHROverTimeToDate"];
            HROverTimeEntities entity = (HROverTimeEntities)CurrentModuleEntity;
            HROverTimesInfo objOverTimesInfo = (HROverTimesInfo)entity.MainObject;
            t1.Text = objOverTimesInfo.HROverTimeFromDate.ToString("HH:mm");
            t2.Text = objOverTimesInfo.HROverTimeToDate.ToString("HH:mm");
            isInvalidate = false;
        }

        /// <summary>
        /// Remove the selected employee from the current overtime list
        /// </summary>
        public void RemoveEmployeeFromOTList()
        {
            HROverTimeEntities entity = (HROverTimeEntities)CurrentModuleEntity;
            entity.HREmployeeOTList.RemoveSelectedRowObjectFromList();
        }

        public override void ActionNew()
        {
            base.ActionNew();
            ((BOSTextBox)this.Controls["fld_txtHROverTimeFromDate"]).Text = "00:00";
            ((BOSTextBox)this.Controls["fld_txtHROverTimeToDate"]).Text = "00:00";
            ((BOSTextBox)this.Controls["fld_txtHROverTimeName1"]).Text = BOSApp.GetCurrentServerDate().ToString("dd/M/yyyy");
        }

        public override void ActionPrint()
        {
            HROverTimeEntities entity = (HROverTimeEntities)CurrentModuleEntity;
            HROverTimesInfo mainObject = (HROverTimesInfo)CurrentModuleEntity.MainObject;

            if (mainObject.HROverTimeID == 0)
            {
                MessageBox.Show("Vui lòng lưu chứng từ trước khi in !", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (entity.HREmployeeOTList.Count() == 0)
                return;

            List<HREmployeeOTsInfo> list = entity.HREmployeeOTList;

            BaseReport rp = null;
            rp = new RPOverTimeNew();
            if (rp == null)
                return;
            entity.HREmployeeOTList.EndCurrentEdit();


            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            HRDepartmentsController objDepartmentsController = new HRDepartmentsController();
            HRDepartmentRoomGroupItemsController objDepartmentRoomGroupItemsController = new HRDepartmentRoomGroupItemsController();
            HRLevelsController objLevelsController = new HRLevelsController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo;


            foreach (var item in list)
            {
                objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(item.FK_HREmployeeID);
                if (objEmployeesInfo == null)
                    continue;

                item.HREmployeeName = objEmployeesInfo.HREmployeeName;
                item.HREmployeeNo = objEmployeesInfo.HREmployeeNo;

                HRLevelsInfo objLevelsInfo = (HRLevelsInfo)objLevelsController.GetObjectByID(objEmployeesInfo.FK_HRLevelID);
                if (objLevelsInfo != null)
                    item.HRLevelName = objLevelsInfo.HRLevelName;
                HRDepartmentsInfo objDepartmentsInfo = (HRDepartmentsInfo)objDepartmentsController.GetObjectByID(objEmployeesInfo.FK_HRDepartmentID);
                if (objDepartmentsInfo != null)
                    item.HRDepartmentName = objDepartmentsInfo.HRDepartmentName;
                HRDepartmentRoomsInfo objDepartmentRoomsInfo = (HRDepartmentRoomsInfo)objDepartmentRoomsController.GetObjectByID(objEmployeesInfo.FK_HRDepartmentRoomID);
                if (objDepartmentRoomsInfo != null)
                    item.HRDepartmentRoomName = objDepartmentRoomsInfo.HRDepartmentRoomName;
                HRDepartmentRoomGroupItemsInfo objDepartmentRoomGroupItemsInfo = (HRDepartmentRoomGroupItemsInfo)objDepartmentRoomGroupItemsController.GetObjectByID(objEmployeesInfo.FK_HRDepartmentRoomGroupItemID);
                if (objDepartmentRoomGroupItemsInfo != null)
                    item.HRDepartmentRoomGroupItemName = objDepartmentRoomGroupItemsInfo.HRDepartmentRoomGroupItemName;

                TimeSpan countTime = item.HREmployeeOTToDate.TimeOfDay - item.HREmployeeOTFromDate.TimeOfDay;
                if (countTime != null)
                {
                    item.CountTime = countTime.Hours.ToString() + "h" + countTime.Minutes.ToString() + "p";
                }
            }


            XRLabel xrDate1 = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xrDate"];
            if (xrDate1 != null)
            {
                xrDate1.Text = mainObject.HROverTimeDate.ToString("dd/MM/yyyy");
            }
            rp.DataSource = list;
            guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Constants.Report.DevInvoiceItemReportPath, false);
            reviewer.ShowDialog();
        }

        /// <summary>
        /// Search employee from query
        /// </summary>
        /// <param name="searchQuery"></param>
        public void SearchEmployee(string searchQuery)
        {
            HROverTimeEntities entity = (HROverTimeEntities)CurrentModuleEntity;
            HREmployeesController objEmployeesController = new HREmployeesController();
            DataSet ds = objEmployeesController.GetDataSet(searchQuery);
            entity.HREmployeeList.Invalidate(ds);
            entity.HREmployeeList.GridView.RefreshData();
        }

        /// <summary>
        /// Select all employee when checked
        /// </summary>
        /// <param name="check"></param>
        public void SelectAllEmployee(bool check)
        {
            HROverTimeEntities entity = (HROverTimeEntities)CurrentModuleEntity;
            foreach (HREmployeesInfo objEmployeesInfo in entity.HREmployeeList)
            {
                objEmployeesInfo.Selected = check;
            }
            entity.HREmployeeList.GridView.RefreshData();
        }

        public void UpdateDateEnd()
        {
            HROverTimeEntities entity = (HROverTimeEntities)CurrentModuleEntity;
            HROverTimesInfo objOverTimesInfo = (HROverTimesInfo)entity.MainObject;
            objOverTimesInfo.HROverTimeDateEnd = objOverTimesInfo.HROverTimeDate;
            objOverTimesInfo.HROverTimeFromDate = objOverTimesInfo.HROverTimeDate;
            objOverTimesInfo.HROverTimeToDate = objOverTimesInfo.HROverTimeDate;
        }
        public void UpdateDateTo()
        {
            HROverTimeEntities entity = (HROverTimeEntities)CurrentModuleEntity;
            HROverTimesInfo objOverTimesInfo = (HROverTimesInfo)entity.MainObject;
            objOverTimesInfo.HROverTimeToDate = objOverTimesInfo.HROverTimeDateEnd;
        }
        public void Check()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                HROverTimeEntities entity = (HROverTimeEntities)CurrentModuleEntity;
                HROverTimesInfo objOverTimesInfo = (HROverTimesInfo)entity.MainObject;
                DateTime from = objOverTimesInfo.HROverTimeDate.Date.AddHours(objOverTimesInfo.HROverTimeFromDate.Hour).AddMinutes(objOverTimesInfo.HROverTimeFromDate.Minute);
                DateTime to = objOverTimesInfo.HROverTimeDateEnd.Date.AddHours(objOverTimesInfo.HROverTimeToDate.Hour).AddMinutes(objOverTimesInfo.HROverTimeToDate.Minute);
                double n = (to - from).TotalHours;
                //if (n > 2)
                //{
                //    objOverTimesInfo.HROverTimeHaveMeal = true;
                //}
            }
        }
        public bool ChangeFromTimeOT()
        {
            HROverTimeEntities entity = (HROverTimeEntities)CurrentModuleEntity;
            if (entity.HREmployeeOTList == null || entity.HREmployeeOTList.Count == 0)
                return true;
            if (MessageBox.Show("Thay đổi của bạn sẽ thay đổi chi tiết theo từng nhân viên, bạn thật sự muốn đổi? ", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return false;
            }
            else
            {

                HROverTimesInfo objOverTimesInfo = (HROverTimesInfo)entity.MainObject;
                DateTime d = objOverTimesInfo.HROverTimeDate;
                foreach (HREmployeeOTsInfo item in entity.HREmployeeOTList)
                {
                    item.HREmployeeOTFromDate = new DateTime(d.Year, d.Month, d.Day, objOverTimesInfo.HROverTimeFromDate.Hour, objOverTimesInfo.HROverTimeFromDate.Minute, 0);
                    item.HREmployeeOTDate = objOverTimesInfo.HROverTimeDate;
                }
                return true;
            }
        }

        public bool ChangeToTimeOT()
        {
            HROverTimeEntities entity = (HROverTimeEntities)CurrentModuleEntity;
            if (entity.HREmployeeOTList == null || entity.HREmployeeOTList.Count == 0)
                return true;
            if (MessageBox.Show("Thay đổi của bạn sẽ thay đổi chi tiết theo từng nhân viên, bạn thật sự muốn đổi? ", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return false;
            }
            else
            {
                HROverTimesInfo objOverTimesInfo = (HROverTimesInfo)entity.MainObject;
                DateTime d = objOverTimesInfo.HROverTimeDateEnd;
                foreach (HREmployeeOTsInfo item in entity.HREmployeeOTList)
                {
                    item.HREmployeeOTToDate = new DateTime(d.Year, d.Month, d.Day, objOverTimesInfo.HROverTimeToDate.Hour, objOverTimesInfo.HROverTimeToDate.Minute, 0);
                    item.HREmployeeOTDateEnd = objOverTimesInfo.HROverTimeDateEnd;
                }
                entity.HREmployeeOTList.GridControl.RefreshDataSource();
                return true;
            }
        }

        #region Update OT

        public void UpdateHREmployeeOTByOTFactor()
        {
            HROverTimeEntities entity = (HROverTimeEntities)CurrentModuleEntity;
            HROverTimesInfo objOverTimesInfo = (HROverTimesInfo)entity.MainObject;
            if (!Toolbar.IsNullOrNoneAction() && objOverTimesInfo.HROverTimeFactor >= 0)
            {
                if (entity.HREmployeeOTList.Count > 0)
                {
                    if (MessageBox.Show(OverTimeLocalizedResources.MessageChangeOTFactorValue, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        objOverTimesInfo.HROverTimeFactor = entity.HREmployeeOTList.Count > 0 ? entity.HREmployeeOTList[0].HREmployeeOTFactor : 0;
                        entity.UpdateMainObjectBindingSource();
                        return;
                    }
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    foreach (HREmployeeOTsInfo employeeOT in entity.HREmployeeOTList)
                    {
                        dbUtil.SetPropertyValue(employeeOT, "HREmployeeOTFactor", objOverTimesInfo.HROverTimeFactor);
                    }
                    entity.HREmployeeOTList.GridControl.RefreshDataSource();
                }
            }
            else
            {
                objOverTimesInfo.HROverTimeFactor = entity.HREmployeeOTList.Count > 0 ? entity.HREmployeeOTList[0].HREmployeeOTFactor : 0;
                entity.UpdateMainObjectBindingSource();
            }
        }
        #endregion

        public void Approve()
        {
            HROverTimeEntities entity = (HROverTimeEntities)CurrentModuleEntity;
            HROverTimesInfo objOverTimesInfo = (HROverTimesInfo)CurrentModuleEntity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            objOverTimesInfo.HROverTimeStatus = OverTimeStatus.Approved.ToString();
            entity.UpdateMainObject();
            InvalidateToolbar();
        }

        public void UnApprove()
        {
            HROverTimeEntities entity = (HROverTimeEntities)CurrentModuleEntity;
            HROverTimesInfo objOverTimesInfo = (HROverTimesInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            objOverTimesInfo.HROverTimeStatus = OverTimeStatus.New.ToString();
            entity.UpdateMainObject();
            InvalidateToolbar();
        }

        public void ActionConfirmed()
        {

            HROverTimeEntities entity = (HROverTimeEntities)CurrentModuleEntity;
            HROverTimesInfo objOverTimesInfo = (HROverTimesInfo)entity.MainObject;
            entity.HREmployeeOTList.EndCurrentEdit();

            entity.SetPropertyChangeEventLock(false);
            objOverTimesInfo.HROverTimeStatus = OverTimeStatus.Confirmed.ToString();
            entity.UpdateMainObject();
            entity.SetPropertyChangeEventLock(true);

            InvalidateToolbar();
        }
    }
}
