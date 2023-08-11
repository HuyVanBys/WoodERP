﻿using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ATMCardPayroll
{
    #region ATMCardPayrollModule
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:DepartmentModule
    //Created Date:Thursday, February 17, 2011
    //-----------------------------------------------------------

    public class ATMCardPayrollModule : BaseTransactionModule
    {
        public ATMCardPayrollModule()
        {
            Name = ModuleName.ATMCardPayroll;
            CurrentModuleEntity = new ATMCardPayrollEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        /// <summary>
        /// Remove an item from the room list of the current department
        /// </summary>
        public void RemoveItemFromList()
        {
            ATMCardPayrollEntities entity = (ATMCardPayrollEntities)CurrentModuleEntity;
            entity.EmployeeATMCardPayrollList.RemoveSelectedRowObjectFromList();
        }
        public override int ActionSave()
        {
            ATMCardPayrollEntities entity = (ATMCardPayrollEntities)CurrentModuleEntity;
            entity.EmployeeATMCardPayrollList.EndCurrentEdit();

            return base.ActionSave();
        }

        public void Approve()
        {
            if (Toolbar.IsNullOrNoneAction())
            {
                ATMCardPayrollEntities entity = (ATMCardPayrollEntities)CurrentModuleEntity;
                entity.SetPropertyChangeEventLock(false);
                HRATMCardPayrollsInfo objATMCardPayrollsInfo = (HRATMCardPayrollsInfo)entity.MainObject;
                objATMCardPayrollsInfo.HRATMCardPayrollStatus = ATMCardPayrollStatus.Approved.ToString();
                entity.UpdateMainObject();
                InvalidateToolbar();
            }
        }

        public void ActionNewFromPayroll()
        {
            ActionNew();

            ATMCardPayrollEntities entity = (ATMCardPayrollEntities)CurrentModuleEntity;
            HRATMCardPayrollsInfo mainObject = (HRATMCardPayrollsInfo)entity.MainObject;
            HRPayRollsController objPayRollsController = new HRPayRollsController();
            HREmployeePayRollsController objEmployeePayRollsController = new HREmployeePayRollsController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            List<HREmployeesInfo> employeeList = objEmployeesController.GetAllEmployees();
            CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(mainObject.FK_CSCompanyBankID);
            if (objCompanyBanksInfo == null)
                objCompanyBanksInfo = new CSCompanyBanksInfo();
            List<HRPayRollsInfo> PayRollList = (List<HRPayRollsInfo>)objPayRollsController.GetPayRollsForATMCardPayroll();
            guiFind<HRPayRollsInfo> guiPayRolls = new guiFind<HRPayRollsInfo>("HRPayRolls", PayRollList, null, this);
            guiPayRolls.Module = this;
            guiPayRolls.ShowDialog();
            if (guiPayRolls.DialogResult != DialogResult.OK)
            {
                ActionCancel();
                return;
            }

            int payrollID = Convert.ToInt32(guiPayRolls.Tag.ToString());
            HRPayRollsInfo objPayRollsInfo = (HRPayRollsInfo)objPayRollsController.GetObjectByID(payrollID);
            if (objPayRollsInfo == null)
                return;

            mainObject.FK_HRPayRollID = objPayRollsInfo.HRPayRollID;
            mainObject.HRATMCardPayrollMonthDate = objPayRollsInfo.HRPayRollDate;

            List<HREmployeePayRollsInfo> employeePayRollList = objEmployeePayRollsController.GetEmployeePayRollListByPayRollID(payrollID);
            employeePayRollList.ForEach(o =>
            {
                HREmployeesInfo objEmployeesInfo = employeeList.FirstOrDefault(p => p.HREmployeeID == o.FK_HREmployeeID && !string.IsNullOrEmpty(p.HREmployeeBankAccount1));
                if (objEmployeesInfo != null)
                {
                    HREmployeeATMCardPayrollsInfo objEmployeeATMCardPayrollsInfo = new HREmployeeATMCardPayrollsInfo();
                    objEmployeeATMCardPayrollsInfo.FK_HREmployeeID = o.FK_HREmployeeID;
                    objEmployeeATMCardPayrollsInfo.HREmployeeATMCardPayrollAmount = o.HREmployeePayRollTotalSalary;
                    objEmployeeATMCardPayrollsInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
                    objEmployeeATMCardPayrollsInfo.HREmployeeATMCardPayrollBankAccount = objEmployeesInfo.HREmployeeBankAccount1;
                    objEmployeeATMCardPayrollsInfo.HREmployeeATMCardPayrollCompanyAccount = objCompanyBanksInfo.CSCompanyBankAccount;
                    objEmployeeATMCardPayrollsInfo.HREmployeeATMCardPayrollCompanyAccountHolder = "CÔNG TY CP LÂM VIỆT";
                    objEmployeeATMCardPayrollsInfo.FK_BRBranch1 = mainObject.FK_BRBranchID;
                    objEmployeeATMCardPayrollsInfo.FK_BRBranch2 = mainObject.FK_BRBranchID;
                    objEmployeeATMCardPayrollsInfo.HREmployeeATMCardPayrollBankCN1 = mainObject.HRATMCardPayrollBankCN;
                    objEmployeeATMCardPayrollsInfo.HREmployeeATMCardPayrollBankCN2 = mainObject.HRATMCardPayrollBankCN;
                    objEmployeeATMCardPayrollsInfo.HREmployeeATMCardPayrollDesc = mainObject.HRATMCardPayrollDesc;

                    entity.EmployeeATMCardPayrollList.Add(objEmployeeATMCardPayrollsInfo);
                }
            });

            if (entity.EmployeeATMCardPayrollList.GridControl != null)
                entity.EmployeeATMCardPayrollList.GridControl.RefreshDataSource();
            entity.UpdateMainObjectBindingSource();
        }

        public void ChangeCompanyBank(int companyBankID)
        {
            ATMCardPayrollEntities entity = (ATMCardPayrollEntities)CurrentModuleEntity;
            HRATMCardPayrollsInfo mainObject = (HRATMCardPayrollsInfo)entity.MainObject;
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(companyBankID);
            if (objCompanyBanksInfo == null)
                return;

            entity.EmployeeATMCardPayrollList.ForEach(o =>
            {
                o.HREmployeeATMCardPayrollCompanyAccount = objCompanyBanksInfo.CSCompanyBankAccount;
                o.HREmployeeATMCardPayrollCompanyAccountHolder = "CÔNG TY CP LÂM VIỆT";
            });

            entity.EmployeeATMCardPayrollList.GridControl.RefreshDataSource();
        }

        public void ChangeBranch()
        {
            ATMCardPayrollEntities entity = (ATMCardPayrollEntities)CurrentModuleEntity;
            HRATMCardPayrollsInfo mainObject = (HRATMCardPayrollsInfo)entity.MainObject;

            entity.EmployeeATMCardPayrollList.ForEach(o =>
            {
                o.HREmployeeATMCardPayrollBankCN1 = mainObject.HRATMCardPayrollBankCN;
                o.HREmployeeATMCardPayrollBankCN2 = mainObject.HRATMCardPayrollBankCN;
            });

            entity.EmployeeATMCardPayrollList.GridControl.RefreshDataSource();
        }

        public void ChangeDesc()
        {
            ATMCardPayrollEntities entity = (ATMCardPayrollEntities)CurrentModuleEntity;
            HRATMCardPayrollsInfo mainObject = (HRATMCardPayrollsInfo)entity.MainObject;
            entity.EmployeeATMCardPayrollList.ForEach(o =>
            {
                o.HREmployeeATMCardPayrollDesc = mainObject.HRATMCardPayrollDesc;
            });

            if (entity.EmployeeATMCardPayrollList.GridControl != null)
                entity.EmployeeATMCardPayrollList.GridControl.RefreshDataSource();
        }

        public void AddEmployeeToList()
        {
            ATMCardPayrollEntities entity = (ATMCardPayrollEntities)CurrentModuleEntity;
            HRATMCardPayrollsInfo mainObject = (HRATMCardPayrollsInfo)entity.MainObject;

            HREmployeePayRollsController objEmployeePayRollsController = new HREmployeePayRollsController();
            HREmployeesController objEmployeesController = new HREmployeesController();
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(mainObject.FK_CSCompanyBankID);
            if (objCompanyBanksInfo == null)
                return;

            entity.EmployeeATMCardPayrollList.ForEach(o =>
            {
                o.HREmployeeATMCardPayrollCompanyAccount = objCompanyBanksInfo.CSCompanyBankAccount;
                o.HREmployeeATMCardPayrollCompanyAccountHolder = "CÔNG TY CP LÂM VIỆT";
            });
            List<HREmployeePayRollsInfo> employeePayRollList = objEmployeePayRollsController.GetEmployeePayRollListByPayRollID(mainObject.FK_HRPayRollID);
            List<HREmployeesInfo> employeeList = objEmployeesController.GetEmployeeByPayrollID(mainObject.FK_HRPayRollID);
            entity.EmployeeATMCardPayrollList.ForEach(o =>
            {
                employeeList.RemoveAll(p => p.HREmployeeID == o.FK_HREmployeeID || string.IsNullOrEmpty(p.HREmployeeBankAccount1));
            });
            if (employeeList.Count() == 0)
            {
                MessageBox.Show("Không có nhân viên nào để thêm !", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            guiFind<HREmployeesInfo> guiEmployees = new guiFind<HREmployeesInfo>(TableName.HREmployeesTableName, employeeList, this, true);
            guiEmployees.Module = this;
            guiEmployees.ShowDialog();
            if (guiEmployees.DialogResult != DialogResult.OK)
                return;

            if (guiEmployees.SelectedObjects.Count() == 0)
                return;

            List<HREmployeesInfo> employeeSelectedList = (List<HREmployeesInfo>)guiEmployees.SelectedObjects;
            employeePayRollList.ForEach(o =>
            {
                HREmployeesInfo objEmployeesInfo = employeeSelectedList.FirstOrDefault(p => p.HREmployeeID == o.FK_HREmployeeID);
                if (objEmployeesInfo != null)
                {
                    HREmployeeATMCardPayrollsInfo objEmployeeATMCardPayrollsInfo = new HREmployeeATMCardPayrollsInfo();
                    objEmployeeATMCardPayrollsInfo.FK_HREmployeeID = o.FK_HREmployeeID;
                    objEmployeeATMCardPayrollsInfo.HREmployeeATMCardPayrollAmount = o.HREmployeePayRollTotalSalary;
                    objEmployeeATMCardPayrollsInfo.HREmployeeName = objEmployeesInfo.HREmployeeName;
                    objEmployeeATMCardPayrollsInfo.HREmployeeATMCardPayrollBankAccount = objEmployeesInfo.HREmployeeBankAccount1;
                    objEmployeeATMCardPayrollsInfo.HREmployeeATMCardPayrollCompanyAccount = objCompanyBanksInfo.CSCompanyBankAccount;
                    objEmployeeATMCardPayrollsInfo.HREmployeeATMCardPayrollCompanyAccountHolder = "CÔNG TY CP LÂM VIỆT";
                    objEmployeeATMCardPayrollsInfo.FK_BRBranch1 = mainObject.FK_BRBranchID;
                    objEmployeeATMCardPayrollsInfo.FK_BRBranch2 = mainObject.FK_BRBranchID;
                    objEmployeeATMCardPayrollsInfo.HREmployeeATMCardPayrollBankCN1 = mainObject.HRATMCardPayrollBankCN;
                    objEmployeeATMCardPayrollsInfo.HREmployeeATMCardPayrollBankCN2 = mainObject.HRATMCardPayrollBankCN;
                    objEmployeeATMCardPayrollsInfo.HREmployeeATMCardPayrollDesc = mainObject.HRATMCardPayrollDesc;

                    entity.EmployeeATMCardPayrollList.Add(objEmployeeATMCardPayrollsInfo);
                }
            });

            entity.EmployeeATMCardPayrollList.GridControl.RefreshDataSource();
        }

        public override void ActionPrint()
        {
            ATMCardPayrollEntities entity = (ATMCardPayrollEntities)CurrentModuleEntity;
            HRATMCardPayrollsInfo mainObject = (HRATMCardPayrollsInfo)entity.MainObject;

            BaseReport rp = null;
            rp = new RPATMCardPayroll();
            if (rp == null)
                return;
            entity.EmployeeATMCardPayrollList.EndCurrentEdit();
            if (mainObject.HRATMCardPayrollStatus != ATMCardPayrollStatus.Approved.ToString())
            {
                MessageBox.Show("Vui lòng duyệt chứng từ trước khi in !", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<HREmployeeATMCardPayrollsInfo> list = entity.EmployeeATMCardPayrollList;

            HREmployeesController objEmployeesController = new HREmployeesController();
            BRBranchsController objBranchsController = new BRBranchsController();
            List<HREmployeesInfo> allEmployeeList = objEmployeesController.GetAllEmployees();
            HREmployeesInfo objEmployeesInfo;

            decimal sumTongTien = 0;

            foreach (var item in list)
            {
                objEmployeesInfo = allEmployeeList.FirstOrDefault(p => p.HREmployeeID == item.FK_HREmployeeID);
                if (objEmployeesInfo != null)
                    item.HREmployeeName = objEmployeesInfo.HREmployeeName;
                sumTongTien += item.HREmployeeATMCardPayrollAmount;
                item.TongTien = sumTongTien;
            }

            XRLabel xrDate = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xrDate"];
            if (xrDate != null)
            {
                xrDate.Text = "BẢNG CHUYỂN KHOẢN LƯƠNG THÁNG " + mainObject.HRATMCardPayrollMonthDate.ToString("MM/yyyy");
            }

            rp.DataSource = list;
            guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Constants.Report.DevInvoiceItemReportPath, false);
            reviewer.ShowDialog();
        }

        public override void InvalidateToolbar()
        {
            ATMCardPayrollEntities entity = (ATMCardPayrollEntities)CurrentModuleEntity;
            HRATMCardPayrollsInfo mainObject = (HRATMCardPayrollsInfo)entity.MainObject;
            ParentScreen.SetEnableOfToolbarButton("Approved", false);
            if (mainObject.HRATMCardPayrollID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton("Approved", true);
                if (mainObject.HRATMCardPayrollStatus == ATMCardPayrollStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Approved", false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                }
            }

            base.InvalidateToolbar();
        }
    }
    #endregion
}