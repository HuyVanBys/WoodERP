﻿using BOSCommon;
using BOSCommon.Constants;
using BOSERP.Utilities;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ATMCardManage
{
    #region ATMCardManageModule
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:DepartmentModule
    //Created Date:Thursday, February 17, 2011
    //-----------------------------------------------------------

    public class ATMCardManageModule : BaseModuleERP
    {
        public ATMCardManageModule()
        {
            Name = ModuleName.ATMCardManage;
            CurrentModuleEntity = new ATMCardManageEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        /// <summary>
        /// Remove an item from the room list of the current department
        /// </summary>
        public void RemoveItemFromList()
        {
            ATMCardManageEntities entity = (ATMCardManageEntities)CurrentModuleEntity;
            entity.EmployeeATMCardManageList.RemoveSelectedRowObjectFromList();
        }
        public override int ActionSave()
        {
            ATMCardManageEntities entity = (ATMCardManageEntities)CurrentModuleEntity;
            entity.EmployeeATMCardManageList.EndCurrentEdit();

            int objectID = base.ActionSave();
            return objectID;
        }

        public void AddEmployeeToOTList()
        {
            ATMCardManageEntities entity = (ATMCardManageEntities)CurrentModuleEntity;
            HRATMCardManagesInfo mainObject = (HRATMCardManagesInfo)entity.MainObject;
            guiSearchEmployee guiSearchEmployee = new guiSearchEmployee();
            guiSearchEmployee.Module = this;
            if (guiSearchEmployee.ShowDialog() != DialogResult.OK)
                return;
            List<HREmployeesInfo> selectEmployee = guiSearchEmployee.SelectedEmployeeList;
            foreach (HREmployeesInfo item in selectEmployee)
            {
                if (!entity.EmployeeATMCardManageList.Exists("FK_HREmployeeID", item.HREmployeeID))
                {
                    HREmployeeATMCardManagesInfo objEmployeeATMCardManagesInfo = new HREmployeeATMCardManagesInfo();
                    entity.SetDefaultValuesFromEmployee(objEmployeeATMCardManagesInfo, item);
                    UpdateCardManageStatus(objEmployeeATMCardManagesInfo);
                    entity.EmployeeATMCardManageList.Add(objEmployeeATMCardManagesInfo);
                }
            }
            entity.EmployeeATMCardManageList.GridControl.RefreshDataSource();
        }

        public void Approve()
        {
            ATMCardManageEntities entity = (ATMCardManageEntities)CurrentModuleEntity;
            HRATMCardManagesInfo mainObject = (HRATMCardManagesInfo)entity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            mainObject.HRATMCardManageStatus = EmployeeATMCardManageStatus.Approved.ToString();
            entity.UpdateMainObject();
            InvalidateToolbar();
        }

        public override void InvalidateToolbar()
        {
            ATMCardManageEntities entity = (ATMCardManageEntities)CurrentModuleEntity;
            HRATMCardManagesInfo mainObject = (HRATMCardManagesInfo)entity.MainObject;
            ParentScreen.SetEnableOfToolbarButton("Approved", false);
            if (mainObject.HRATMCardManageID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton("Approved", true);
                if (mainObject.HRATMCardManageStatus == EmployeeATMCardManageStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Approved", false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                }
            }

            base.InvalidateToolbar();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);

            ATMCardManageEntities entity = (ATMCardManageEntities)CurrentModuleEntity;
            HRATMCardManagesInfo mainObject = (HRATMCardManagesInfo)entity.MainObject;
            HREmployeesController objEmployeesController = new HREmployeesController();
            List<HREmployeesInfo> employeeList = objEmployeesController.GetAllEmployees();
            entity.EmployeeATMCardManageList.ForEach(o =>
            {
                HREmployeesInfo objEmployeesInfo = employeeList.FirstOrDefault(p => p.HREmployeeID == o.FK_HREmployeeID);
                if (objEmployeesInfo != null)
                {
                    o.HREmployeeNo = objEmployeesInfo.HREmployeeNo;
                    o.HREmployeeName = objEmployeesInfo.HREmployeeName;
                }
            });
        }

        public void PrintForm1()
        {
            ATMCardManageEntities entity = (ATMCardManageEntities)CurrentModuleEntity;
            BaseReport rp = null;
            rp = new RPATMForm1Mul();
            if (rp == null)
                return;
            entity.EmployeeATMCardManageList.EndCurrentEdit();
            List<HREmployeeATMCardManagesInfo> list = entity.EmployeeATMCardManageList.Where(p => p.Selected).ToList();
            if (list.Count() == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên trước khi in !", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HRATMCardManagesInfo mainObject = (HRATMCardManagesInfo)entity.MainObject;
            HREmployeesController objEmployeesController = new HREmployeesController();
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            GENationalitysController objNationalitysController = new GENationalitysController();
            GEReligionsController objReligionsController = new GEReligionsController();
            GEStateProvincesController objStateProvincesController = new GEStateProvincesController();
            HREmployeeContactsController objEmployeeContactsController = new HREmployeeContactsController();
            HRLevelsController objLevelsController = new HRLevelsController();
            ADConfigValuesInfo objConfigValuesInfo;
            HREmployeesInfo objEmployeesInfo;
            GENationalitysInfo objNationalitysInfo;
            GEReligionsInfo objReligionsInfo;
            GEStateProvincesInfo objStateProvincesInfo;
            HREmployeeContactsInfo objEmployeeContactsInfo;
            HRLevelsInfo objLevelsInfo;
            List<HREmployeesInfo> allEmployeeList = objEmployeesController.GetAllEmployees();

            foreach (var item in list)
            {
                objEmployeesInfo = allEmployeeList.FirstOrDefault(p => p.HREmployeeID == item.FK_HREmployeeID);
                if (objEmployeesInfo != null)
                {
                    item.HREmployeeDob = objEmployeesInfo.HREmployeeDob;
                    item.HREmployeeIDNumber = objEmployeesInfo.HREmployeeIDNumber;
                    item.HREmployeeIDCardDate = objEmployeesInfo.HREmployeeIDCardDate;

                    objConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue("EmployeeGender", objEmployeesInfo.HREmployeeGenderCombo);
                    if (objConfigValuesInfo != null)
                    {
                        item.HREmployeeGenderCombo = objConfigValuesInfo.ADConfigText.ToString();
                    }

                    objNationalitysInfo = (GENationalitysInfo)objNationalitysController.GetObjectByID(objEmployeesInfo.FK_GENationalityID);
                    if (objNationalitysInfo != null)
                    {
                        item.GENationalityName = objNationalitysInfo.GENationalityName;
                    }

                    objReligionsInfo = (GEReligionsInfo)objReligionsController.GetObjectByID(objEmployeesInfo.FK_GEReligionID);
                    if (objReligionsInfo != null)
                    {
                        item.GEReligionName = objReligionsInfo.GEReligionName;
                    }

                    objStateProvincesInfo = (GEStateProvincesInfo)objStateProvincesController.GetObjectByID(objEmployeesInfo.FK_GEIDCardStateProvinceID);
                    if (objStateProvincesInfo != null)
                    {
                        item.GEIDCardStateProvinceName = objStateProvincesInfo.GEStateProvinceName;
                    }

                    objEmployeeContactsInfo = objEmployeeContactsController.GetEmployeeContactByEmployeeIDAndType(objEmployeesInfo.HREmployeeID
                                                                                                                                    , EmployeeContactType.DiaChiThuongTru.ToString());
                    if (objEmployeeContactsInfo != null)
                    {
                        item.HREmployeeContactAddress = objEmployeeContactsInfo.HREmployeeContactAddress;
                    }

                    objLevelsInfo = (HRLevelsInfo)objLevelsController.GetObjectByID(objEmployeesInfo.FK_HRLevelID);
                    if (objLevelsInfo != null)
                    {
                        item.HRLevelName = objLevelsInfo.HRLevelName;
                    }
                }
            }

            XRLabel xrLabel134 = (XRLabel)rp.Bands[BandKind.Detail].Controls["xrLabel134"];
            if (xrLabel134 != null)
            {
                xrLabel134.Text = xrLabel134.Text.Replace("#d", mainObject.HRATMCardManageDate.ToString("dd"));
                xrLabel134.Text = xrLabel134.Text.Replace("#M", mainObject.HRATMCardManageDate.ToString("MM"));
                xrLabel134.Text = xrLabel134.Text.Replace("#y", mainObject.HRATMCardManageDate.ToString("yyyy"));
            }

            rp.DataSource = list;
            guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Constants.Report.DevInvoiceItemReportPath, false);
            reviewer.ShowDialog();
        }

        public void PrintForm3()
        {
            ATMCardManageEntities entity = (ATMCardManageEntities)CurrentModuleEntity;
            BaseReport rp = null;
            rp = new RPATMForm3Mul();
            if (rp == null)
                return;
            entity.EmployeeATMCardManageList.EndCurrentEdit();
            List<HREmployeeATMCardManagesInfo> list = entity.EmployeeATMCardManageList.Where(p => p.Selected).ToList();
            if (list.Count() == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên trước khi in !", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HRATMCardManagesInfo mainObject = (HRATMCardManagesInfo)entity.MainObject;
            HREmployeesController objEmployeesController = new HREmployeesController();
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            GENationalitysController objNationalitysController = new GENationalitysController();
            GEReligionsController objReligionsController = new GEReligionsController();
            GEStateProvincesController objStateProvincesController = new GEStateProvincesController();
            HREmployeeContactsController objEmployeeContactsController = new HREmployeeContactsController();
            HRLevelsController objLevelsController = new HRLevelsController();
            ADConfigValuesInfo objConfigValuesInfo;
            HREmployeesInfo objEmployeesInfo;
            GENationalitysInfo objNationalitysInfo;
            GEReligionsInfo objReligionsInfo;
            GEStateProvincesInfo objStateProvincesInfo;
            HREmployeeContactsInfo objEmployeeContactsInfo;
            HRLevelsInfo objLevelsInfo;
            List<HREmployeesInfo> allEmployeeList = objEmployeesController.GetAllEmployees();

            foreach (var item in list)
            {
                objEmployeesInfo = allEmployeeList.FirstOrDefault(p => p.HREmployeeID == item.FK_HREmployeeID);
                if (objEmployeesInfo != null)
                {
                    item.HREmployeeDob = objEmployeesInfo.HREmployeeDob;
                    item.HREmployeeIDNumber = objEmployeesInfo.HREmployeeIDNumber;
                    item.HREmployeeIDCardDate = objEmployeesInfo.HREmployeeIDCardDate;

                    objConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue("EmployeeGender", objEmployeesInfo.HREmployeeGenderCombo);
                    if (objConfigValuesInfo != null)
                    {
                        item.HREmployeeGenderCombo = objConfigValuesInfo.ADConfigText.ToString();
                    }

                    objNationalitysInfo = (GENationalitysInfo)objNationalitysController.GetObjectByID(objEmployeesInfo.FK_GENationalityID);
                    if (objNationalitysInfo != null)
                    {
                        item.GENationalityName = objNationalitysInfo.GENationalityName;
                    }

                    objReligionsInfo = (GEReligionsInfo)objReligionsController.GetObjectByID(objEmployeesInfo.FK_GEReligionID);
                    if (objReligionsInfo != null)
                    {
                        item.GEReligionName = objReligionsInfo.GEReligionName;
                    }

                    objStateProvincesInfo = (GEStateProvincesInfo)objStateProvincesController.GetObjectByID(objEmployeesInfo.FK_GEIDCardStateProvinceID);
                    if (objStateProvincesInfo != null)
                    {
                        item.GEIDCardStateProvinceName = objStateProvincesInfo.GEStateProvinceName;
                    }

                    objEmployeeContactsInfo = objEmployeeContactsController.GetEmployeeContactByEmployeeIDAndType(objEmployeesInfo.HREmployeeID
                                                                                                                                    , EmployeeContactType.DiaChiThuongTru.ToString());
                    if (objEmployeeContactsInfo != null)
                    {
                        item.HREmployeeContactAddress = objEmployeeContactsInfo.HREmployeeContactAddress;
                    }

                    objLevelsInfo = (HRLevelsInfo)objLevelsController.GetObjectByID(objEmployeesInfo.FK_HRLevelID);
                    if (objLevelsInfo != null)
                    {
                        item.HRLevelName = objLevelsInfo.HRLevelName;
                    }
                }

                //XRLabel labelDate = (XRLabel)rp.Bands[BandKind.Detail].Controls["xrDiaChiThuongTru"];
                //if (labelDate != null)
                //{
                //    labelDate.Text = item.HREmployeeContactAddress;
                //}

                //labelDate = (XRLabel)rp.Bands[BandKind.Detail].Controls["xrCMND"];
                //if (labelDate != null)
                //{
                //    labelDate.Text = item.HREmployeeIDNumber;
                //}
            }

            XRLabel xrLabel2 = (XRLabel)rp.Bands[BandKind.Detail].Controls["xrLabel2"];
            if (xrLabel2 != null)
            {
                xrLabel2.Text = xrLabel2.Text.Replace("#d", mainObject.HRATMCardManageDate.ToString("dd"));
                xrLabel2.Text = xrLabel2.Text.Replace("#M", mainObject.HRATMCardManageDate.ToString("MM"));
                xrLabel2.Text = xrLabel2.Text.Replace("#y", mainObject.HRATMCardManageDate.ToString("yyyy"));
            }

            XRLabel xrLabel343 = (XRLabel)rp.Bands[BandKind.Detail].Controls["xrLabel343"];
            if (xrLabel343 != null)
            {
                xrLabel343.Text = xrLabel343.Text.Replace("#d", mainObject.HRATMCardManageDate.ToString("dd"));
                xrLabel343.Text = xrLabel343.Text.Replace("#M", mainObject.HRATMCardManageDate.ToString("MM"));
                xrLabel343.Text = xrLabel343.Text.Replace("#y", mainObject.HRATMCardManageDate.ToString("yyyy"));
            }

            rp.DataSource = list;
            guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Constants.Report.DevInvoiceItemReportPath, false);
            reviewer.ShowDialog();
        }

        public void PrintForm2()
        {
            ATMCardManageEntities entity = (ATMCardManageEntities)CurrentModuleEntity;
            BaseReport rp = null;
            rp = new RPATMForm2Mul();
            if (rp == null)
                return;
            entity.EmployeeATMCardManageList.EndCurrentEdit();
            List<HREmployeeATMCardManagesInfo> list = entity.EmployeeATMCardManageList.Where(p => p.Selected).ToList();
            if (list.Count() == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên trước khi in !", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HRATMCardManagesInfo mainObject = (HRATMCardManagesInfo)entity.MainObject;
            HREmployeesController objEmployeesController = new HREmployeesController();
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            GENationalitysController objNationalitysController = new GENationalitysController();
            GEReligionsController objReligionsController = new GEReligionsController();
            GEStateProvincesController objStateProvincesController = new GEStateProvincesController();
            HREmployeeContactsController objEmployeeContactsController = new HREmployeeContactsController();
            HRLevelsController objLevelsController = new HRLevelsController();
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            HRDepartmentRoomGroupItemsController objDepartmentRoomGroupItemsController = new HRDepartmentRoomGroupItemsController();
            ADConfigValuesInfo objConfigValuesInfo;
            HREmployeesInfo objEmployeesInfo;
            GENationalitysInfo objNationalitysInfo;
            GEReligionsInfo objReligionsInfo;
            GEStateProvincesInfo objStateProvincesInfo;
            HREmployeeContactsInfo objEmployeeContactsInfo;
            HRLevelsInfo objLevelsInfo;
            HRDepartmentRoomsInfo objDepartmentRoomsInfo;
            HRDepartmentRoomGroupItemsInfo objDepartmentRoomGroupItemsInfo;
            List<HREmployeesInfo> allEmployeeList = objEmployeesController.GetAllEmployees();

            foreach (var item in list)
            {
                objEmployeesInfo = allEmployeeList.FirstOrDefault(p => p.HREmployeeID == item.FK_HREmployeeID);
                if (objEmployeesInfo != null)
                {
                    item.HREmployeeDob = objEmployeesInfo.HREmployeeDob;
                    item.HREmployeeIDNumber = objEmployeesInfo.HREmployeeIDNumber;
                    item.HREmployeeIDCardDate = objEmployeesInfo.HREmployeeIDCardDate;

                    objConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue("EmployeeGender", objEmployeesInfo.HREmployeeGenderCombo);
                    if (objConfigValuesInfo != null)
                    {
                        item.HREmployeeGenderCombo = objConfigValuesInfo.ADConfigText.ToString();
                    }

                    objConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue("EmployeeATMCardManageStatus", item.HREmployeeATMCardManageStatus);
                    if (objConfigValuesInfo != null)
                    {
                        item.HREmployeeATMCardManageStatusDesc = objConfigValuesInfo.ADConfigText.ToString();
                    }

                    objDepartmentRoomsInfo = (HRDepartmentRoomsInfo)objDepartmentRoomsController.GetObjectByID(objEmployeesInfo.FK_HRDepartmentRoomID);
                    if (objDepartmentRoomsInfo != null)
                    {
                        item.HRDepartmentRoomName = objDepartmentRoomsInfo.HRDepartmentRoomName;
                    }

                    objDepartmentRoomGroupItemsInfo = (HRDepartmentRoomGroupItemsInfo)objDepartmentRoomGroupItemsController.GetObjectByID(objEmployeesInfo.FK_HRDepartmentRoomGroupItemID);
                    if (objDepartmentRoomGroupItemsInfo != null)
                    {
                        item.HRDepartmentRoomGroupItemName = objDepartmentRoomGroupItemsInfo.HRDepartmentRoomGroupItemName;
                    }

                    objNationalitysInfo = (GENationalitysInfo)objNationalitysController.GetObjectByID(objEmployeesInfo.FK_GENationalityID);
                    if (objNationalitysInfo != null)
                    {
                        item.GENationalityName = objNationalitysInfo.GENationalityName;
                    }

                    objReligionsInfo = (GEReligionsInfo)objReligionsController.GetObjectByID(objEmployeesInfo.FK_GEReligionID);
                    if (objReligionsInfo != null)
                    {
                        item.GEReligionName = objReligionsInfo.GEReligionName;
                    }

                    objStateProvincesInfo = (GEStateProvincesInfo)objStateProvincesController.GetObjectByID(objEmployeesInfo.FK_GEIDCardStateProvinceID);
                    if (objStateProvincesInfo != null)
                    {
                        item.GEIDCardStateProvinceName = objStateProvincesInfo.GEStateProvinceName;
                    }

                    objEmployeeContactsInfo = objEmployeeContactsController.GetEmployeeContactByEmployeeIDAndType(objEmployeesInfo.HREmployeeID
                                                                                                                                    , EmployeeContactType.DiaChiThuongTru.ToString());
                    if (objEmployeeContactsInfo != null)
                    {
                        item.HREmployeeContactAddress = objEmployeeContactsInfo.HREmployeeContactAddress;
                    }

                    objLevelsInfo = (HRLevelsInfo)objLevelsController.GetObjectByID(objEmployeesInfo.FK_HRLevelID);
                    if (objLevelsInfo != null)
                    {
                        item.HRLevelName = objLevelsInfo.HRLevelName;
                    }
                }
            }

            CSCompanysController objCompanysController = new CSCompanysController();
            CSCompanysInfo objCompanyInfo = (CSCompanysInfo)objCompanysController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (objCompanyInfo != null)
            {
                XRLabel label = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xrDiachinhamay"];
                if (label != null)
                {
                    label.Text = objCompanyInfo.CSCompanyAddressLine2;
                }

                label = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xrTenCongTy"];
                if (label != null)
                {
                    label.Text = objCompanyInfo.CSCompanyDesc;
                }

                //label = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xrEmail"];
                //if (label != null)
                //{
                //    label.Text = objCompanyInfo.CSCompanyEmail;
                //}

                label = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xrFax"];
                if (label != null)
                {
                    label.Text = objCompanyInfo.CSCompanyFax;
                }

                label = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xrCompanyphone"];
                if (label != null)
                {
                    label.Text = objCompanyInfo.CSCompanyPhone;
                }
            }

            objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            if (objEmployeesInfo != null)
            {
                XRLabel xrNguoitao = (XRLabel)rp.Bands[BandKind.ReportFooter].Controls["xrNguoitao"];
                if (xrNguoitao != null)
                {
                    xrNguoitao.Text = objEmployeesInfo.HREmployeeName;
                }

                XRLabel xrEmailnguoitao = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xrEmailnguoitao"];
                if (xrEmailnguoitao != null)
                {
                    xrEmailnguoitao.Text = objEmployeesInfo.HREmployeeEmail1;
                }
            }

            if (list.Count > 0)
            {
                decimal totalAmount = 0;
                list.ForEach(o => totalAmount += o.HREmployeeATMCardManageAmount);
                XRLabel xrTienbangchu = (XRLabel)rp.Bands[BandKind.ReportFooter].Controls["xrTienbangchu"];
                if (xrTienbangchu != null)
                {
                    xrTienbangchu.Text = ConvertAmountToWord.ReadAmount(totalAmount.ToString("n0"), 100000);
                }
            }

            XRLabel xrDate = (XRLabel)rp.Bands[BandKind.ReportFooter].Controls["xrDate"];
            if (xrDate != null)
            {
                xrDate.Text = xrDate.Text.Replace("#d", mainObject.HRATMCardManageDate.ToString("dd"));
                xrDate.Text = xrDate.Text.Replace("#M", mainObject.HRATMCardManageDate.ToString("MM"));
                xrDate.Text = xrDate.Text.Replace("#y", mainObject.HRATMCardManageDate.ToString("yyyy"));
            }

            rp.DataSource = list;
            guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Constants.Report.DevInvoiceItemReportPath, false);
            reviewer.ShowDialog();
        }

        public void UpdateCardManageStatus(HREmployeeATMCardManagesInfo item)
        {
            ATMCardManageEntities entity = (ATMCardManageEntities)CurrentModuleEntity;
            HRATMCardManagesInfo mainObject = (HRATMCardManagesInfo)entity.MainObject;
            HRATMCardManageConfigsController objATMCardManageConfigsController = new HRATMCardManageConfigsController();
            List<HRATMCardManageConfigsInfo> ATMCardManageConfigList = objATMCardManageConfigsController.GetAllATMCardManageConfigList();
            decimal amount = 0;

            if (item != null && ATMCardManageConfigList.Count() > 0)
            {
                amount = ATMCardManageConfigList.LastOrDefault(o => o.HREmployeeATMCardManageStatus.ToString() == item.HREmployeeATMCardManageStatus.ToString()).HRATMCardManageConfigAmount;
                item.HREmployeeATMCardManageAmount = amount;
            }

            entity.EmployeeATMCardManageList.GridControl.RefreshDataSource();
        }

        public void ChangeEmloyeeCardStatus(string status)
        {
            ATMCardManageEntities entity = (ATMCardManageEntities)CurrentModuleEntity;
            if (entity.EmployeeATMCardManageList.Count() > 0)
            {
                entity.EmployeeATMCardManageList.ForEach(o =>
                {
                    o.HREmployeeATMCardManageStatus = status;
                    UpdateCardManageStatus(o);
                });
                entity.EmployeeATMCardManageList.GridControl.RefreshDataSource();
            }
        }
    }
    #endregion
}