using BOSCommon;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.HREmployeeWorkSchedule
{
    class HREmployeeWorkScheduleModule : BaseModuleERP
    {
        public HREmployeeWorkScheduleModule()
        {
            Name = "HREmployeeWorkSchedule";
            CurrentModuleEntity = new HREmployeeWorkScheduleEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        public void AddEmployeeToOTList()
        {
            HREmployeeWorkScheduleEntities entity = (HREmployeeWorkScheduleEntities)CurrentModuleEntity;
            HREmployeeWorkSchedulesInfo obj = (HREmployeeWorkSchedulesInfo)entity.MainObject;
            guiSearchEmployee guiEmployee = new guiSearchEmployee();
            guiEmployee.Module = this;
            if (guiEmployee.ShowDialog() == DialogResult.OK)
            {
                entity.HREmployeeList.Invalidate(guiEmployee.SelectedEmployeeList);
                foreach (HREmployeesInfo objEmployeesInfo in entity.HREmployeeList)
                {
                    if (objEmployeesInfo.Selected)
                    {
                        if (!entity.HREmployeeWorkScheduleList.Exists("FK_HREmployeeID", objEmployeesInfo.HREmployeeID))
                        {
                            HREmployeeWorkScheduleItemsInfo objEmployeeWorkScheduleItemsInfo = new HREmployeeWorkScheduleItemsInfo();
                            objEmployeeWorkScheduleItemsInfo.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                            objEmployeeWorkScheduleItemsInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
                            objEmployeeWorkScheduleItemsInfo.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
                            objEmployeeWorkScheduleItemsInfo.HREmployeeCardNumber = objEmployeesInfo.HREmployeeCardNumber;
                            obj.HREmployeeCardNumber += objEmployeesInfo.HREmployeeCardNumber;
                            obj.HREmployeeName += objEmployeesInfo.HREmployeeName;
                            if (entity.HREmployeeList.Count > 1)
                            {
                                obj.HREmployeeCardNumber = obj.HREmployeeCardNumber + ";";
                                obj.HREmployeeName = obj.HREmployeeName + ";";
                            }
                            entity.HREmployeeWorkScheduleList.Add(objEmployeeWorkScheduleItemsInfo);
                        }
                    }
                }
                entity.HREmployeeWorkScheduleList.GridControl.RefreshDataSource();
            }
        }

        public override void ActionNew()
        {
            base.ActionNew();

            HREmployeeWorkScheduleEntities entity = (HREmployeeWorkScheduleEntities)CurrentModuleEntity;
            HREmployeeWorkSchedulesInfo obj = (HREmployeeWorkSchedulesInfo)entity.MainObject;
            DateTime d = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            obj.HREmployeeWorkScheduleFromDate = d;
            obj.HREmployeeWorkScheduleToDate = d;
            obj.HREmployeeWorkScheduleDateFrom = d;
            obj.HREmployeeWorkScheduleDateTo = d;
        }

        public override void ActionPrint()
        {
            if (Toolbar.IsNullOrNoneAction() && Toolbar.CurrentObjectID > 0)
            {
                HREmployeesController objEmployeesController = new HREmployeesController();
                HREmployeesInfo objCurrenUser = objEmployeesController.GetEmployeeByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
                HREmployeeWorkScheduleEntities entity = (HREmployeeWorkScheduleEntities)CurrentModuleEntity;
                HREmployeeWorkSchedulesInfo objEmployeeWorkSchedulesInfo = (HREmployeeWorkSchedulesInfo)entity.MainObject;
                foreach (HREmployeeWorkScheduleItemsInfo obj in entity.HREmployeeWorkScheduleList)
                {
                    HREmployeesInfo objEmployee = (HREmployeesInfo)objEmployeesController.GetEmployeeByID(obj.FK_HREmployeeID);
                    obj.HREmployeeName = objEmployee.HREmployeeName;
                    obj.HRDepartmentName = objEmployee.HRDepartmentName;
                    obj.HRDepartmentRoomName = objEmployee.HRDepartmentRoomName;
                    obj.HREmployeeWorkScheduleItemDesc = objEmployeeWorkSchedulesInfo.HREmployeeWorkScheduleDesc;

                    obj.HREmployeeNameCreate = objCurrenUser.HREmployeeName;
                    obj.HRDepartmentNameCreate = objCurrenUser.HRDepartmentName;
                    obj.HRDepartmentRoomNameCreate = objCurrenUser.HRDepartmentRoomName;
                    obj.HREmployeeEndDate = objEmployeeWorkSchedulesInfo.HREmployeeWorkScheduleDateTo;
                }
                if (entity.HREmployeeWorkScheduleList.Count > 0)
                {
                    RPWorkSchedule report = new RPWorkSchedule(entity.HREmployeeWorkScheduleList);
                    report.DataSource = entity.HREmployeeWorkScheduleList;

                    SetDefaultCurrentBranchAndTitle(report, BOSApp.CurrentCompanyInfo.FK_BRBranchID);


                    guiReportPreview reviewer = new guiReportPreview(report);
                    reviewer.Show();
                }
            }
        }

        public void SetDefaultCurrentBranchAndTitle(XtraReport report, int branchID)
        {
            CSCompanysController objCompanysController = new CSCompanysController();
            CSCompanysInfo objCompanyInfo = (CSCompanysInfo)objCompanysController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);

            if (objCompanyInfo != null)
            {

                XRTableCell tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrThue"].Controls["xr_tbcThue"];
                if (tablecell != null)
                {
                    tablecell.Text += objCompanyInfo.CSCompanyTaxNumber;
                }
                tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrdchd"].Controls["xrtbcdiachihoadon"];
                if (tablecell != null)
                {
                    tablecell.Text += objCompanyInfo.CSCompanyAddressLine1;
                }
                tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrAddress"].Controls["xrtbcdiachinhamay"];
                if (tablecell != null)
                {
                    tablecell.Text += objCompanyInfo.CSCompanyAddressLine2;
                }

                tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrWeb"].Controls["xr_tbcWebsite"];
                if (tablecell != null)
                {
                    tablecell.Text += objCompanyInfo.CSCompanyWebsite;
                }

                tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrEmail"].Controls["xr_tbcEmail"];
                if (tablecell != null)
                {
                    tablecell.Text += objCompanyInfo.CSCompanyEmail;
                }
                tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrCellphone"].Controls["xr_tbcCellphone"];
                if (tablecell != null)
                {
                    tablecell.Text = objCompanyInfo.CSCompanyCellPhone;
                }

                tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrCompanyphone"].Controls["xr_tbcCompanyphone"];
                if (tablecell != null)
                {
                    tablecell.Text += objCompanyInfo.CSCompanyPhone;
                }
                tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls[0].Controls[0];
                if (tablecell != null)
                {
                    tablecell.Text = objCompanyInfo.CSCompanyDesc;
                }

            }
        }

        public override int ActionSave()
        {
            HREmployeeWorkScheduleEntities entity = (HREmployeeWorkScheduleEntities)CurrentModuleEntity;
            HREmployeeWorkSchedulesInfo obj = (HREmployeeWorkSchedulesInfo)entity.MainObject;
            DateTime d = obj.HREmployeeWorkScheduleFromDate;
            DateTime dto = obj.HREmployeeWorkScheduleToDate;
            obj.HREmployeeWorkScheduleDateFrom = new DateTime(d.Year, d.Month, d.Day, obj.HREmployeeWorkScheduleDateFrom.Hour, obj.HREmployeeWorkScheduleDateFrom.Minute, 0);
            obj.HREmployeeWorkScheduleDateTo = new DateTime(dto.Year, dto.Month, dto.Day, obj.HREmployeeWorkScheduleDateTo.Hour, obj.HREmployeeWorkScheduleDateTo.Minute, 0);
            obj.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            return base.ActionSave();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            HREmployeeWorkScheduleEntities entity = (HREmployeeWorkScheduleEntities)CurrentModuleEntity;
            HREmployeeWorkSchedulesInfo obj = (HREmployeeWorkSchedulesInfo)entity.MainObject;
            obj.HREmployeeWorkScheduleFromDate = obj.HREmployeeWorkScheduleDateFrom;
            obj.HREmployeeWorkScheduleToDate = obj.HREmployeeWorkScheduleDateTo;
            entity.UpdateMainObjectBindingSource();
        }

        public void RemoveEmployeeFromList()
        {
            HREmployeeWorkScheduleEntities entity = (HREmployeeWorkScheduleEntities)CurrentModuleEntity;
            entity.HREmployeeWorkScheduleList.RemoveSelectedRowObjectFromList();
        }
        public void Approve()
        {
            HREmployeeWorkScheduleEntities entity = (HREmployeeWorkScheduleEntities)CurrentModuleEntity;
            HREmployeeWorkSchedulesInfo obj = (HREmployeeWorkSchedulesInfo)CurrentModuleEntity.MainObject;
            ADUsersInfo objUsersInfo = BOSApp.CurrentUsersInfo;
            entity.SetPropertyChangeEventLock(false);
            obj.HREmployeeWorkScheduleStatus = EmployeeWorkScheduleStatus.Approved.ToString();
            entity.UpdateMainObject();
            InvalidateToolbar();
        }
        public void UnApprove()
        {
            HREmployeeWorkScheduleEntities entity = (HREmployeeWorkScheduleEntities)CurrentModuleEntity;
            HREmployeeWorkSchedulesInfo obj = (HREmployeeWorkSchedulesInfo)CurrentModuleEntity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            obj.HREmployeeWorkScheduleStatus = EmployeeWorkScheduleStatus.UnApproved.ToString();
            entity.UpdateMainObject();
            InvalidateToolbar();
        }

        public void CancelScheduleNo()
        {
            HREmployeeWorkScheduleEntities entity = (HREmployeeWorkScheduleEntities)CurrentModuleEntity;
            HREmployeeWorkSchedulesInfo obj = (HREmployeeWorkSchedulesInfo)CurrentModuleEntity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            obj.HREmployeeWorkScheduleStatus = EmployeeWorkScheduleStatus.CancelScheduleNo.ToString();
            entity.UpdateMainObject();
            InvalidateToolbar();
        }
        #region Invalidate Toolbar
        public override void InvalidateToolbar()
        {
            HREmployeeWorkScheduleEntities entity = (HREmployeeWorkScheduleEntities)CurrentModuleEntity;
            HREmployeeWorkSchedulesInfo mainObj = (HREmployeeWorkSchedulesInfo)entity.MainObject;
            ParentScreen.SetEnableOfToolbarButton("Approve", false);
            //ParentScreen.SetEnableOfToolbarButton("Edit", false);
            ParentScreen.SetEnableOfToolbarButton("UnApprove", false);
            ParentScreen.SetEnableOfToolbarButton("CancelScheduleNo", false);
            if (mainObj.HREmployeeWorkScheduleID > 0)
            {
                if (mainObj.HREmployeeWorkScheduleStatus == EmployeeWorkScheduleStatus.New.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Approve", true);
                    ParentScreen.SetEnableOfToolbarButton("UnApprove", true);
                    //ParentScreen.SetEnableOfToolbarButton("Edit", true);
                    ParentScreen.SetEnableOfToolbarButton("CancelScheduleNo", true);
                }
                else if (mainObj.HREmployeeWorkScheduleStatus == EmployeeWorkScheduleStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton("UnApprove", false);
                    ParentScreen.SetEnableOfToolbarButton("Edit", false);
                    ParentScreen.SetEnableOfToolbarButton("CancelScheduleNo", false);
                }
                else if (mainObj.HREmployeeWorkScheduleStatus == EmployeeWorkScheduleStatus.UnApproved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton("UnApprove", false);
                    ParentScreen.SetEnableOfToolbarButton("Edit", false);
                    ParentScreen.SetEnableOfToolbarButton("CancelScheduleNo", false);
                }
                else if (mainObj.HREmployeeWorkScheduleStatus == EmployeeWorkScheduleStatus.CancelScheduleNo.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton("UnApprove", false);
                    ParentScreen.SetEnableOfToolbarButton("Edit", false);
                    ParentScreen.SetEnableOfToolbarButton("CancelScheduleNo", false);
                }
            }
            base.InvalidateToolbar();
        }
        #endregion 

    }
}
