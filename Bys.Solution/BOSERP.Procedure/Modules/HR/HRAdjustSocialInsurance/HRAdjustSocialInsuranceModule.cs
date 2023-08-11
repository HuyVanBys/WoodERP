using BOSCommon;
using BOSComponent;
using BOSReport;
using DevExpress.XtraGrid.Views.BandedGrid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.HRAdjustSocialInsurance
{
    class HRAdjustSocialInsuranceModule : BaseModuleERP
    {

        #region Constants

        public const string EmployeeLookupEditControlName = "fld_lkeHREmployeeID";

        #endregion Constants

        BOSLookupEdit EmployeeLookupEditControl;

        public HRAdjustSocialInsuranceModule()
        {
            Name = "HRAdjustSocialInsurance";
            CurrentModuleEntity = new HRAdjustSocialInsuranceEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            EmployeeLookupEditControl = (BOSLookupEdit)Controls[EmployeeLookupEditControlName];
        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
        }

        #region Print
        public void PrintTruyThu()
        {
            HRAdjustSocialInsuranceEntities entity = (HRAdjustSocialInsuranceEntities)CurrentModuleEntity;
            RPBHXH_D01b report = new RPBHXH_D01b();
            report.CreateDocument();
            HREmployeesController objEmployeesController = new HREmployeesController();
            HRAdjustSocialInsurancesInfo objAdjustSocialInsurancesInfo = (HRAdjustSocialInsurancesInfo)entity.MainObject;
            for (int i = 0; i < entity.HREmployeeArrearSocialInsurancesList.Count; i++)
            {
                entity.HREmployeeArrearSocialInsurancesList[i].STT = (i + 1).ToString();
                entity.HREmployeeArrearSocialInsurancesList[i].HRAdjustSocialInsuranceBHXHRate = objAdjustSocialInsurancesInfo.HRAdjustSocialInsuranceBHXHRate / 100;
                entity.HREmployeeArrearSocialInsurancesList[i].HRAdjustSocialInsuranceBHYTRate = objAdjustSocialInsurancesInfo.HRAdjustSocialInsuranceBHYTRate / 100;
            }
            foreach (var item in entity.HREmployeeArrearSocialInsurancesList)
            {
                if (item.FK_HREmployeeID > 0)
                {
                    HREmployeesInfo obj = (HREmployeesInfo)objEmployeesController.GetObjectByID(item.FK_HREmployeeID);
                    item.HREmployeeName = obj.HREmployeeName;
                    if (obj.HREmployeeGenderCombo.ToLower().Equals("Female".ToLower()))
                    {
                        item.HREmployeeGender = "X";
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                RPBHXH_TruyThu rp = new RPBHXH_TruyThu();
                rp.DataSource = entity.HREmployeeArrearSocialInsurancesList;
                rp.CreateDocument();
                report.Pages.AddRange(rp.Pages);
            }
            guiReportPreview reviewer = new guiReportPreview(report);
            reviewer.CreateReport = false;
            reviewer.Show();
        }
        public void PrintBHYT()
        {
            RPBHXH_D01b report = new RPBHXH_D01b();
            guiReportPreview reviewer = new guiReportPreview(report);
            reviewer.Show();
        }
        public void PrintDeNghi()
        {
            HRAdjustSocialInsuranceEntities entity = (HRAdjustSocialInsuranceEntities)CurrentModuleEntity;
            RPBHXH_D07 report = new RPBHXH_D07();
            report.DataSource = entity.HREmployeeSocialInsuranceChangesList;
            int val = 1;
            HREmployeesController objEmployeesController = new HREmployeesController();
            foreach (var item in entity.HREmployeeSocialInsuranceChangesList)
            {
                item.STT = val.ToString();
                val++;
                if (item.FK_HREmployeeID > 0)
                {
                    HREmployeesInfo obj = (HREmployeesInfo)objEmployeesController.GetObjectByID(item.FK_HREmployeeID);
                    item.HREmployeeName = obj.HREmployeeName;
                }
            }
            report.CreateDocument();
            for (int i = 0; i < 2; i++)
            {
                RPBHXH_D07 rp = new RPBHXH_D07();
                rp.DataSource = entity.HREmployeeSocialInsuranceChangesList;
                rp.CreateDocument();
                report.Pages.AddRange(rp.Pages);
            }
            guiReportPreview reviewer = new guiReportPreview(report);
            reviewer.CreateReport = false;
            reviewer.Show();
        }
        public void PrintDS()
        {
            HRAdjustSocialInsuranceEntities entity = (HRAdjustSocialInsuranceEntities)CurrentModuleEntity;
            HRAdjustSocialInsurancesInfo objAdjustSocialInsurancesInfo = (HRAdjustSocialInsurancesInfo)entity.MainObject;
            HREmployeesController objEmployeesController = new HREmployeesController();
            HRLevelsController objLevelsController = new HRLevelsController();
            GENationalitysController objNationalitysController = new GENationalitysController();
            GEStateProvincesController objStateProvincesController = new GEStateProvincesController();
            HREmployeeContactsController objEmployeeContactsController = new HREmployeeContactsController();
            foreach (var item in entity.HREmployeeAdjustSocialInsurancesList)
            {
                if (item.HREmployeeSocialInsuranceType == EmployeeSocialInsuranceType.IncreaseBHTN.ToString() ||
                    item.HREmployeeSocialInsuranceType == EmployeeSocialInsuranceType.IncreaseBHYT.ToString() ||
                    item.HREmployeeSocialInsuranceType == EmployeeSocialInsuranceType.IncreaseLabor.ToString() ||
                    item.HREmployeeSocialInsuranceType == EmployeeSocialInsuranceType.IncreaseRate.ToString())
                {
                    item.InsuranceType = "1";
                    item.InsuranceTypeName = "  I     Tăng";
                    if (item.HREmployeeSocialInsuranceType == EmployeeSocialInsuranceType.IncreaseBHTN.ToString())
                    {
                        item.InsuranceTypeDetail = "4";
                        item.InsuranceTypeDetailName = " I.     Bảo hiểm thất nghiệp";
                    }
                    else if (item.HREmployeeSocialInsuranceType == EmployeeSocialInsuranceType.IncreaseBHYT.ToString())
                    {
                        item.InsuranceTypeDetail = "3";
                        item.InsuranceTypeDetailName = " I.     Bảo hiểm y tế";
                    }
                    else if (item.HREmployeeSocialInsuranceType == EmployeeSocialInsuranceType.IncreaseLabor.ToString())
                    {
                        item.InsuranceTypeDetail = "1";
                        item.InsuranceTypeDetailName = " I.     Lao động";
                    }
                    else if (item.HREmployeeSocialInsuranceType == EmployeeSocialInsuranceType.IncreaseRate.ToString())
                    {
                        item.InsuranceTypeDetail = "2";
                        item.InsuranceTypeDetailName = " I.     Mức đóng";
                    }
                }
                else if (item.HREmployeeSocialInsuranceType == EmployeeSocialInsuranceType.DecreaseBHTN.ToString() ||
                    item.HREmployeeSocialInsuranceType == EmployeeSocialInsuranceType.DecreaseBHYT.ToString() ||
                    item.HREmployeeSocialInsuranceType == EmployeeSocialInsuranceType.DecreaseLabor.ToString() ||
                    item.HREmployeeSocialInsuranceType == EmployeeSocialInsuranceType.DecreaseRate.ToString())
                {
                    item.InsuranceType = "2";
                    item.InsuranceTypeName = " II    Giảm";
                    if (item.HREmployeeSocialInsuranceType == EmployeeSocialInsuranceType.DecreaseBHTN.ToString())
                    {
                        item.InsuranceTypeDetail = "4";
                        item.InsuranceTypeDetailName = "II.    Bảo hiểm thất nghiệp";
                    }
                    else if (item.HREmployeeSocialInsuranceType == EmployeeSocialInsuranceType.DecreaseBHYT.ToString())
                    {
                        item.InsuranceTypeDetail = "3";
                        item.InsuranceTypeDetailName = "II.    Bảo hiểm y tế";
                    }
                    else if (item.HREmployeeSocialInsuranceType == EmployeeSocialInsuranceType.DecreaseLabor.ToString())
                    {
                        item.InsuranceTypeDetail = "1";
                        item.InsuranceTypeDetailName = "II.    Lao động";
                    }
                    else if (item.HREmployeeSocialInsuranceType == EmployeeSocialInsuranceType.DecreaseRate.ToString())
                    {
                        item.InsuranceTypeDetail = "2";
                        item.InsuranceTypeDetailName = "II.    Mức đóng";
                    }
                }
                else if (item.HREmployeeSocialInsuranceType == EmployeeSocialInsuranceType.Change.ToString())
                {
                    item.InsuranceType = "3";
                    item.InsuranceTypeName = "III   Thay đổi chức danh công việc, nghề, điều kiện, nơi làm việc";
                }
                if (item.FK_HREmployeeID > 0)
                {
                    HREmployeesInfo obj = (HREmployeesInfo)objEmployeesController.GetObjectByID(item.FK_HREmployeeID);
                    item.HREmployeeName = obj.HREmployeeName;
                    if (obj.HREmployeeGenderCombo.ToLower().Equals("Female".ToLower()))
                    {
                        item.HREmployeeGender = "X";
                    }
                    GENationalitysInfo objNationalitysInfo = (GENationalitysInfo)objNationalitysController.GetObjectByID(obj.FK_GENationalityID);
                    //dân tộc
                    if (objNationalitysInfo != null)
                    {
                        item.GENationalityName = objNationalitysInfo.GENationalityName;
                    }
                    //cmnd
                    item.HREmployeeIDNumber = obj.HREmployeeIDNumber;
                    item.HREmployeeIDCardDate = obj.HREmployeeIDCardDate;
                    GEStateProvincesInfo objStateProvincesInfo = (GEStateProvincesInfo)objStateProvincesController.GetObjectByID(obj.FK_GEIDCardStateProvinceID);
                    if (objStateProvincesInfo != null)
                    {
                        item.GEIDCardStateProvinceName = objStateProvincesInfo.GEStateProvinceCode;
                    }
                    //địa chỉ
                    HREmployeeContactsInfo objEmployeeContactsInfo = objEmployeeContactsController.GetAddressConstByEmployeeID(obj.HREmployeeID);
                    if (objEmployeeContactsInfo != null)
                    {
                        item.HREmployeeAddress = objEmployeeContactsInfo.HREmployeeContactAddress;
                    }
                    //KCB
                    objStateProvincesInfo = (GEStateProvincesInfo)objStateProvincesController.GetObjectByID(obj.FK_GEStateProvinceIDBHXH);
                    if (objStateProvincesInfo != null)
                    {
                        item.HREmployeeStateProvinceKCB = objStateProvincesInfo.GEStateProvinceName;
                    }
                    //bệnh viện KCB
                    item.HREmployeeHealthInsRegisteredPlace = obj.HREmployeeHealthInsRegisteredPlace;
                    if (item.HREmployeeSocialInsuranceLedger) item.HREmployeeSocialInsuranceLedgerName = "X";
                    else item.HREmployeeSocialInsuranceLedgerName = "";
                }
                if (item.FK_HRLevelID > 0)
                {
                    item.HREmployeeLevel = ((HRLevelsInfo)objLevelsController.GetObjectByID(item.FK_HRLevelID)).HRLevelName;
                }
                if (item.FK_HRLevelIDNew > 0 && item.InsuranceType == "3")
                {
                    item.HREmployeeLevelNew = ((HRLevelsInfo)objLevelsController.GetObjectByID(item.FK_HRLevelIDNew)).HRLevelName;
                }
                else item.HREmployeeLevelNew = "";
            }
            int n = 1;
            List<int> list = new List<int>();
            List<int> list2 = new List<int>();
            List<int> list3 = new List<int>();
            if (entity.HREmployeeAdjustSocialInsurancesList.Exists(p => (p.InsuranceType == "1" &&
                p.InsuranceTypeDetail == "1")))
            {
                list.Add(n++);
            }
            else list.Add(n);
            if (entity.HREmployeeAdjustSocialInsurancesList.Exists(p => (p.InsuranceType == "1" &&
                p.InsuranceTypeDetail == "2")))
            {
                list.Add(n++);
            }
            else list.Add(n);
            if (entity.HREmployeeAdjustSocialInsurancesList.Exists(p => (p.InsuranceType == "1" &&
                p.InsuranceTypeDetail == "3")))
            {
                list.Add(n++);
            }
            else list.Add(n);
            if (entity.HREmployeeAdjustSocialInsurancesList.Exists(p => (p.InsuranceType == "1" &&
                p.InsuranceTypeDetail == "4")))
            {
                list.Add(n++);
            }
            else list.Add(n);
            n = 1;
            if (entity.HREmployeeAdjustSocialInsurancesList.Exists(p => (p.InsuranceType == "2" &&
                p.InsuranceTypeDetail == "1")))
            {
                list2.Add(n++);
            }
            else list2.Add(n);
            if (entity.HREmployeeAdjustSocialInsurancesList.Exists(p => (p.InsuranceType == "2" &&
                p.InsuranceTypeDetail == "2")))
            {
                list2.Add(n++);
            }
            else list2.Add(n);
            if (entity.HREmployeeAdjustSocialInsurancesList.Exists(p => (p.InsuranceType == "2" &&
                p.InsuranceTypeDetail == "3")))
            {
                list2.Add(n++);
            }
            else list2.Add(n);
            if (entity.HREmployeeAdjustSocialInsurancesList.Exists(p => (p.InsuranceType == "2" &&
                p.InsuranceTypeDetail == "4")))
            {
                list2.Add(n++);
            }
            else list2.Add(n);
            n = 1;
            if (entity.HREmployeeAdjustSocialInsurancesList.Exists(p => p.InsuranceType == "1"))
            {
                list3.Add(n++);
            }
            else list3.Add(n);
            if (entity.HREmployeeAdjustSocialInsurancesList.Exists(p => p.InsuranceType == "2"))
            {
                list3.Add(n++);
            }
            else list3.Add(n);
            if (entity.HREmployeeAdjustSocialInsurancesList.Exists(p => p.InsuranceType == "3"))
            {
                list3.Add(n++);
            }
            else list3.Add(n);
            foreach (var item in entity.HREmployeeAdjustSocialInsurancesList)
            {
                if (string.IsNullOrEmpty(item.InsuranceTypeDetailName)) continue;
                int index = item.InsuranceTypeDetailName.IndexOf('.');
                if (item.InsuranceType == "1")
                {
                    item.InsuranceTypeDetailName = item.InsuranceTypeDetailName.Substring(0, index + 1)
                        + list[int.Parse(item.InsuranceTypeDetail) - 1] + item.InsuranceTypeDetailName.Substring(index + 1);
                }
                else if (item.InsuranceType == "2")
                {
                    item.InsuranceTypeDetailName = item.InsuranceTypeDetailName.Substring(0, index + 1)
                        + list2[int.Parse(item.InsuranceTypeDetail) - 1] + item.InsuranceTypeDetailName.Substring(index + 1);
                }
            }
            string[] pt = new string[] { "I", "II", "III" };
            foreach (var item in entity.HREmployeeAdjustSocialInsurancesList)
            {
                int index = item.InsuranceTypeName.IndexOf(pt[int.Parse(item.InsuranceType) - 1]);
                if (index > -1)
                {
                    item.InsuranceTypeName = item.InsuranceTypeName.Substring(0, index)
                        + pt[list3[int.Parse(item.InsuranceType) - 1] - 1] + item.InsuranceTypeName.Substring(index + pt[int.Parse(item.InsuranceType) - 1].Length);
                }

                index = (item.InsuranceTypeDetailName ?? "").IndexOf(pt[int.Parse(item.InsuranceType) - 1]);
                if (index > -1)
                {
                    item.InsuranceTypeDetailName = item.InsuranceTypeDetailName.Substring(0, index)
                        + pt[list3[int.Parse(item.InsuranceType) - 1] - 1] + item.InsuranceTypeDetailName.Substring(index + pt[int.Parse(item.InsuranceType) - 1].Length);
                }
            }
            List<int> zzz = new List<int> { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            foreach (var item in entity.HREmployeeAdjustSocialInsurancesList)
            {
                if (string.IsNullOrEmpty(item.InsuranceTypeDetailName))
                {
                    item.STT = zzz[int.Parse(item.InsuranceType) - 1].ToString();
                    zzz[int.Parse(item.InsuranceType) - 1] = zzz[int.Parse(item.InsuranceType) - 1] + 1;
                }
                else
                {
                    item.STT = zzz[(int.Parse(item.InsuranceType) + 3) * int.Parse(item.InsuranceTypeDetail)].ToString();
                    zzz[(int.Parse(item.InsuranceType) + 3) * int.Parse(item.InsuranceTypeDetail)] = zzz[(int.Parse(item.InsuranceType) + 3) * int.Parse(item.InsuranceTypeDetail)] + 1;
                }
            }
            RPBHXH_DSLD report = new RPBHXH_DSLD();
            report.DataSource = entity.HREmployeeAdjustSocialInsurancesList;
            report.CreateDocument();
            RPBHXH_DSLD report2 = new RPBHXH_DSLD();
            report2.DataSource = entity.HREmployeeAdjustSocialInsurancesList;
            report2.CreateDocument();
            report.Pages.AddRange(report2.Pages);
            List<HREmployeeAdjustSocialInsurancesInfo> listIns = new List<HREmployeeAdjustSocialInsurancesInfo>();
            if (entity.HREmployeeAdjustSocialInsurancesList.Exists(p => p.InsuranceType == "1"))
            {
                listIns = entity.HREmployeeAdjustSocialInsurancesList.Where(p => p.InsuranceType == "1").ToList();
                int val = 1;
                foreach (var item in listIns)
                {
                    item.STT = val.ToString();
                    val++;
                }
                for (int i = 0; i < 3; i++)
                {
                    RPBHXH_DSCapSo rp = new RPBHXH_DSCapSo();
                    rp.DataSource = listIns;
                    rp.CreateDocument();
                    report.Pages.AddRange(rp.Pages);
                }
                for (int i = 0; i < 2 * listIns.Count; i++)
                {
                    RPBHXH_ToKhaiBHXH rp = new RPBHXH_ToKhaiBHXH();
                    rp.CreateDocument();
                    report.Pages.AddRange(rp.Pages);
                }
                BRBranchsController objBranchsController = new BRBranchsController();
                BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                for (int i = 0; i < listIns.Count; i++)
                {
                    if (objBranchsInfo.FK_GELocationID != 56)
                    {
                        RPBHXH_C15aHCM rp = new RPBHXH_C15aHCM();
                        rp.CreateDocument();
                        report.Pages.AddRange(rp.Pages);
                    }
                    else
                    {
                        RPBHXH_C15aLA rp = new RPBHXH_C15aLA();
                        rp.CreateDocument();
                        report.Pages.AddRange(rp.Pages);
                    }
                }
            }
            if (entity.HREmployeeAdjustSocialInsurancesList.Exists(p => p.InsuranceType == "2"))
            {
                RPBHXH_D01b rp = new RPBHXH_D01b();
                rp.CreateDocument();
                report.Pages.AddRange(rp.Pages);
            }
            if (entity.HREmployeeAdjustSocialInsurancesList.Exists(p => p.InsuranceType == "3"))
            {
                RPBHXH_D01b rp = new RPBHXH_D01b();
                rp.CreateDocument();
                report.Pages.AddRange(rp.Pages);
            }
            guiReportPreview reviewer = new guiReportPreview(report);
            reviewer.CreateReport = false;
            reviewer.Show();
        }
        #endregion

        public override int ActionSave()
        {
            HRAdjustSocialInsuranceEntities entity = (HRAdjustSocialInsuranceEntities)CurrentModuleEntity;
            foreach (var item in entity.HREmployeeAdjustSocialInsurancesList)
            {
                if (string.IsNullOrEmpty(item.HREmployeeSocialInsuranceType))
                {
                    MessageBox.Show("Vui lòng chọn loại điều chỉnh cho tất cả nhân viên",
                        CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            return base.ActionSave();
        }

        public void RemoveSelectedItem()
        {
            HRAdjustSocialInsuranceEntities entity = (HRAdjustSocialInsuranceEntities)CurrentModuleEntity;
            BandedGridView bandedView = (BandedGridView)entity.HREmployeeAdjustSocialInsurancesList.GridControl.MainView;
            if (bandedView.FocusedRowHandle >= 0)
            {
                int index = bandedView.GetDataSourceRowIndex(bandedView.FocusedRowHandle);
                entity.HREmployeeAdjustSocialInsurancesList.RemoveAt(index);
                bandedView.RefreshData();
            }
        }

        public void RemoveSelectedItemArrear()
        {
            HRAdjustSocialInsuranceEntities entity = (HRAdjustSocialInsuranceEntities)CurrentModuleEntity;
            BandedGridView bandedView = (BandedGridView)entity.HREmployeeArrearSocialInsurancesList.GridControl.MainView;
            if (bandedView.FocusedRowHandle >= 0)
            {
                int index = bandedView.GetDataSourceRowIndex(bandedView.FocusedRowHandle);
                entity.HREmployeeArrearSocialInsurancesList.RemoveAt(index);
                bandedView.RefreshData();
            }
        }

        public void RemoveItemFromList()
        {
            HRAdjustSocialInsuranceEntities entity = (HRAdjustSocialInsuranceEntities)CurrentModuleEntity;
            entity.HREmployeeSocialInsuranceChangesList.RemoveSelectedRowObjectFromList();
        }

        //public void InitEmployeeList(int BRBranchID)
        //{
        //    HREmployeesController objEmployeesController = new HREmployeesController();
        //    DataSet ds = objEmployeesController.GetEmployeeListByBranchID(BRBranchID);
        //    EmployeeLookupEditControl.Properties.DataSource = ds.Tables[0];
        //}

        //public void InitEmployeeList(int BRBranchID)
        //{
        //    HREmployeesController objEmployeesController = new HREmployeesController();
        //    DataSet ds = objEmployeesController.GetEmployeeListByBranchID(BRBranchID);
        //    HRAdjustSocialInsuranceEntities entity = (HRAdjustSocialInsuranceEntities)CurrentModuleEntity;
        //    entity.EmployeeList.Invalidate(ds);
        //}

        public void AddItemToAdvanceRequestItemList()
        {
            try
            {
                HRAdjustSocialInsuranceEntities entity = (HRAdjustSocialInsuranceEntities)CurrentModuleEntity;
                guiSearchEmployee guiEmployee = new guiSearchEmployee();
                guiEmployee.Module = this;
                if (guiEmployee.ShowDialog() == DialogResult.OK)
                {
                    entity.EmployeeList.Invalidate(guiEmployee.SelectedEmployeeList);
                    BOSLib.ADConfigValuesController objConfigValuesController = new BOSLib.ADConfigValuesController();
                    foreach (HREmployeesInfo objEmployeesInfo in entity.EmployeeList)
                    {
                        HREmployeeAdjustSocialInsurancesInfo obj = new HREmployeeAdjustSocialInsurancesInfo();
                        obj.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                        obj.HREmployeeSocialInsuranceBirthday = objEmployeesInfo.HREmployeeDob;
                        obj.HREmployeeSocialInsuranceName = objEmployeesInfo.HREmployeeName;
                        obj.HREmployeeSocialInsuranceNo = objEmployeesInfo.HREmployeeSocialInsNo;
                        BOSLib.ADConfigValuesInfo objConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue("Gender", objEmployeesInfo.HREmployeeGenderCombo);
                        if (objConfigValuesInfo != null)
                        {
                            obj.HREmployeeSocialInsuranceGender = objConfigValuesInfo.ADConfigText;
                        }
                        obj.FK_HRLevelID = objEmployeesInfo.FK_HRLevelID;
                        if (objEmployeesInfo.HRInsCalculatedSalaryType == CalculatedSalaryType.Basic.ToString())
                        {
                            obj.HREmployeeSocialInsuranceOldSalaryAmount = objEmployeesInfo.HREmployeeContractSlrAmt;
                        }
                        else
                        {
                            obj.HREmployeeSocialInsuranceOldSalaryAmount = objEmployeesInfo.HREmployeeWorkingSlrAmt;
                        }
                        entity.HREmployeeAdjustSocialInsurancesList.Add(obj);
                        entity.HREmployeeAdjustSocialInsurancesList.GridControl.RefreshDataSource();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi, vui lòng thử lại", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddItemToAdvanceRequestArearItemList()
        {
            try
            {
                HRAdjustSocialInsuranceEntities entity = (HRAdjustSocialInsuranceEntities)CurrentModuleEntity;
                guiSearchEmployee guiEmployee = new guiSearchEmployee();
                guiEmployee.Module = this;
                if (guiEmployee.ShowDialog() == DialogResult.OK)
                {
                    entity.EmployeeList.Invalidate(guiEmployee.SelectedEmployeeList);
                    BOSLib.ADConfigValuesController objConfigValuesController = new BOSLib.ADConfigValuesController();
                    foreach (HREmployeesInfo objEmployeesInfo in entity.EmployeeList)
                    {
                        HREmployeeArrearSocialInsurancesInfo obj = new HREmployeeArrearSocialInsurancesInfo();
                        obj.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                        obj.HREmployeeName = objEmployeesInfo.HREmployeeName;
                        obj.HREmployeeArrearSocialInsuranceNo = objEmployeesInfo.HREmployeeSocialInsNo;
                        if (objEmployeesInfo.HRInsCalculatedSalaryType == CalculatedSalaryType.Basic.ToString())
                        {
                            obj.HREmployeeArrearSocialInsuranceSalary = objEmployeesInfo.HREmployeeContractSlrAmt;
                        }
                        else
                        {
                            obj.HREmployeeArrearSocialInsuranceSalary = objEmployeesInfo.HREmployeeWorkingSlrAmt;
                        }
                        entity.HREmployeeArrearSocialInsurancesList.Add(obj);
                        entity.HREmployeeArrearSocialInsurancesList.GridControl.RefreshDataSource();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi, vui lòng thử lại", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddItemToChangeList()
        {
            try
            {
                HRAdjustSocialInsuranceEntities entity = (HRAdjustSocialInsuranceEntities)CurrentModuleEntity;
                guiSearchEmployee guiEmployee = new guiSearchEmployee();
                guiEmployee.Module = this;
                if (guiEmployee.ShowDialog() == DialogResult.OK)
                {
                    entity.EmployeeList.Invalidate(guiEmployee.SelectedEmployeeList);
                    BOSLib.ADConfigValuesController objConfigValuesController = new BOSLib.ADConfigValuesController();
                    foreach (HREmployeesInfo objEmployeesInfo in entity.EmployeeList)
                    {
                        HREmployeeSocialInsuranceChangesInfo obj = new HREmployeeSocialInsuranceChangesInfo();
                        obj.FK_HREmployeeID = objEmployeesInfo.HREmployeeID;
                        obj.HREmployeeName = objEmployeesInfo.HREmployeeName;
                        obj.HREmployeeSocialInsuranceChangeNo = objEmployeesInfo.HREmployeeSocialInsNo;
                        entity.HREmployeeSocialInsuranceChangesList.Add(obj);
                        entity.HREmployeeSocialInsuranceChangesList.GridControl.RefreshDataSource();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi, vui lòng thử lại", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CalcEmployeeArrearSocialInsurance(HREmployeeArrearSocialInsurancesInfo obj)
        {
            HRAdjustSocialInsurancesInfo objAdjustSocialInsurancesInfo = (HRAdjustSocialInsurancesInfo)CurrentModuleEntity.MainObject;
            obj.HREmployeeArrearSocialInsuranceTotalMonth = TotalMonth(obj.HREmployeeArrearSocialInsuranceFromDate, obj.HREmployeeArrearSocialInsuranceToDate) + 1;
            if (obj.HREmployeeArrearSocialInsuranceTotalMonth < 0) obj.HREmployeeArrearSocialInsuranceTotalMonth = 0;
            obj.HREmployeeArrearSocialInsuranceNi = (TotalMonth(obj.HREmployeeArrearSocialInsuranceFromDate, objAdjustSocialInsurancesInfo.HRAdjustSocialInsuranceDate)
                + TotalMonth(obj.HREmployeeArrearSocialInsuranceToDate, objAdjustSocialInsurancesInfo.HRAdjustSocialInsuranceDate)) * obj.HREmployeeArrearSocialInsuranceTotalMonth / 2;
            obj.HREmployeeArrearSocialInsuranceBHXHInterest = obj.HREmployeeArrearSocialInsuranceSalary
                * (obj.HREmployeeArrearSocialInsuranceBHXHRate / 100)
                * (Pow((1 + objAdjustSocialInsurancesInfo.HRAdjustSocialInsuranceBHXHRate / 100),
                    TotalMonth(obj.HREmployeeArrearSocialInsuranceToDate, objAdjustSocialInsurancesInfo.HRAdjustSocialInsuranceDate))
                * (Pow((1 + objAdjustSocialInsurancesInfo.HRAdjustSocialInsuranceBHXHRate / 100),
                    (int)obj.HREmployeeArrearSocialInsuranceTotalMonth) - 1) / ((1 + objAdjustSocialInsurancesInfo.HRAdjustSocialInsuranceBHXHRate / 100) - 1) - obj.HREmployeeArrearSocialInsuranceTotalMonth);

            obj.HREmployeeArrearSocialInsuranceBHTNInterest = obj.HREmployeeArrearSocialInsuranceSalary
                * (obj.HREmployeeArrearSocialInsuranceBHTNRate / 100)
                * (Pow((1 + objAdjustSocialInsurancesInfo.HRAdjustSocialInsuranceBHXHRate / 100),
                    TotalMonth(obj.HREmployeeArrearSocialInsuranceToDate, objAdjustSocialInsurancesInfo.HRAdjustSocialInsuranceDate))
                * (Pow((1 + objAdjustSocialInsurancesInfo.HRAdjustSocialInsuranceBHXHRate / 100),
                    (int)obj.HREmployeeArrearSocialInsuranceTotalMonth) - 1) / ((1 + objAdjustSocialInsurancesInfo.HRAdjustSocialInsuranceBHXHRate / 100) - 1) - obj.HREmployeeArrearSocialInsuranceTotalMonth);

            obj.HREmployeeArrearSocialInsuranceBHYTInterest = obj.HREmployeeArrearSocialInsuranceSalary
                * (obj.HREmployeeArrearSocialInsuranceBHYTRate / 100)
                * (Pow((1 + objAdjustSocialInsurancesInfo.HRAdjustSocialInsuranceBHYTRate / 100),
                    TotalMonth(obj.HREmployeeArrearSocialInsuranceToDate, objAdjustSocialInsurancesInfo.HRAdjustSocialInsuranceDate))
                * (Pow((1 + objAdjustSocialInsurancesInfo.HRAdjustSocialInsuranceBHYTRate / 100),
                    (int)obj.HREmployeeArrearSocialInsuranceTotalMonth) - 1) / ((1 + objAdjustSocialInsurancesInfo.HRAdjustSocialInsuranceBHYTRate / 100) - 1) - obj.HREmployeeArrearSocialInsuranceTotalMonth);

            obj.HREmployeeArrearSocialInsuranceInterestTotal = obj.HREmployeeArrearSocialInsuranceBHXHInterest +
                obj.HREmployeeArrearSocialInsuranceBHTNInterest +
                obj.HREmployeeArrearSocialInsuranceBHYTInterest;
        }

        private decimal GetValue(HRAdjustSocialInsurancesInfo objAdjustSocialInsurancesInfo, HREmployeeArrearSocialInsurancesInfo obj, decimal rate, decimal rateTH)
        {
            decimal val = 0;
            val = obj.HREmployeeArrearSocialInsuranceSalary;
            val *= (obj.HREmployeeArrearSocialInsuranceBHXHRate / 100);
            rateTH /= 100;
            rate /= 100;
            int totalMonth = TotalMonth(obj.HREmployeeArrearSocialInsuranceToDate, objAdjustSocialInsurancesInfo.HRAdjustSocialInsuranceDate);
            decimal val2 = Pow(rateTH + 1, totalMonth);
            val2 *= Pow(rateTH + 1, (int)obj.HREmployeeArrearSocialInsuranceTotalMonth) - 1;
            val2 /= rateTH;
            val2 -= obj.HREmployeeArrearSocialInsuranceTotalMonth;
            val *= val2;
            return val;
        }

        private decimal Pow(decimal n, int x)
        {
            decimal re = 1;
            for (int i = 1; i <= x; i++)
            {
                re *= n;
            }
            return re;
        }

        private int TotalMonth(DateTime d1, DateTime d2)
        {
            return (d2.Year * 12 + d2.Month) - (d1.Year * 12 + d1.Month);
        }
    }
}
