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

namespace BOSERP.Modules.HRDiscipline
{
    class HRDisciplineModule : BaseModuleERP
    {
        #region Constant
        public const string DisciplineFromDateDateEditName = "fld_dteHRDisciplineFromDate";
        public const string DisciplineToDateDateEditName = "fld_dteHRDisciplineToDate";
        public const string DisciplineTypeLookupEditName = "fld_lkeHRDisciplineType";
        public const string DisciplineValueTextBoxName = "fld_txtHRDisciplineValue";
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        #endregion

        #region Public properties
        //NNThinh [MOD] [22/11/2013] [DB centre] [Search Discipline by BRBranchID], START
        //public BOSLookupEdit SearchBranchLookupEditControl;
        //public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        //public List<BRBranchsInfo> BranchList;
        //NNThinh [MOD] [22/11/2013] [DB centre] [Search Discipline by BRBranchID], END
        #endregion

        public HRDisciplineModule()
        {
            Name = "HRDiscipline";
            CurrentModuleEntity = new HRDisciplineEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

        }


        protected override DataSet GetSearchData(ref string searchQuery)
        {
            HRDisciplinesController objDisciplinesController = new HRDisciplinesController();
            HRDisciplinesInfo searchObject = (HRDisciplinesInfo)CurrentModuleEntity.SearchObject;

            DataSet ds;

            ds = objDisciplinesController.GetDisciplineListByBranchID(
                                                           searchObject.HRDisciplineNo,
                                                           searchObject.HRDisciplineName,
                                                           searchObject.FK_BRBranchID);

            return ds;
        }

        public override void ActionNew()
        {
            base.ActionNew();
            HRDisciplineEntities entity = (HRDisciplineEntities)CurrentModuleEntity;
            HRDisciplinesInfo objDisciplinesInfo = (HRDisciplinesInfo)entity.MainObject;
            objDisciplinesInfo.HRDisciplineFromDate = DateTime.Now;
            objDisciplinesInfo.HRDisciplineToDate = DateTime.Now;
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            SetMaskForDisciplineValue();
            CurrentModuleEntity.UpdateMainObjectBindingSource();
        }

        public override int ActionSave()
        {
            HRDisciplineEntities entity = (HRDisciplineEntities)CurrentModuleEntity;
            HRDisciplinesInfo objDisciplinesInfo = (HRDisciplinesInfo)entity.MainObject;
            DateTime fromDate = Convert.ToDateTime(objDisciplinesInfo.HRDisciplineFromDate);
            DateTime toDate = Convert.ToDateTime(objDisciplinesInfo.HRDisciplineToDate);
            objDisciplinesInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            //if (toDate < fromDate)
            //{
            //    MessageBox.Show(DisciplineLocalizedResources.DateErrorMessage.ToString(), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    base.ActionCancel();
            //}
            return base.ActionSave();
        }

        #region Add an employee
        /// <summary>
        /// Show screen to search employee from employee list and add employee is disciplined to employee list
        /// </summary>
        public void AddEmployee()
        {
            guiSearchEmployee guiSearchEmployee = new guiSearchEmployee();
            guiSearchEmployee.Module = this;
            if (guiSearchEmployee.ShowDialog() == DialogResult.OK)
            {
                HRDisciplineEntities entity = (HRDisciplineEntities)CurrentModuleEntity;
                entity.HREmployeeList.Invalidate(guiSearchEmployee.SelectedEmployeeList);
                foreach (HREmployeesInfo objEmployeesInfo in entity.HREmployeeList)
                {
                    if (objEmployeesInfo.Selected)
                    {
                        if (!entity.HREmployeeDisciplinesList.Exists("FK_HREmployeeID", objEmployeesInfo.HREmployeeID))
                        {
                            HREmployeeDisciplinesInfo objEmployeeDisciplinesInfo = new HREmployeeDisciplinesInfo();
                            entity.SetDefaultValuesFromEmployee(objEmployeeDisciplinesInfo, objEmployeesInfo);
                            entity.HREmployeeDisciplinesList.Add(objEmployeeDisciplinesInfo);
                        }
                    }
                }
                entity.HREmployeeDisciplinesList.GridControl.RefreshDataSource();
            }
        }

        public void UpdateDate()
        {
            HRDisciplineEntities entity = (HRDisciplineEntities)CurrentModuleEntity;
            HRDisciplinesInfo objMainObject = (HRDisciplinesInfo)entity.MainObject;
            foreach (HREmployeeDisciplinesInfo item in entity.HREmployeeDisciplinesList)
            {
                item.HREmployeeDisciplineDate = objMainObject.HRDisciplineFromDate;
            }
        }

        public void ChangeDisciplineNumber()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                HRDisciplineEntities entity = (HRDisciplineEntities)CurrentModuleEntity;
                HRDisciplinesInfo objMainObject = (HRDisciplinesInfo)entity.MainObject;

                if (MessageBox.Show("Bạn muốn thay đổi Số biên bản cho tất cả nhân viên?",
                    CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (HREmployeeDisciplinesInfo item in entity.HREmployeeDisciplinesList)
                    {
                        item.HREmployeeDisciplineNo = objMainObject.HRDisciplineNumber;
                    }
                    entity.HREmployeeDisciplinesList.GridControl.RefreshDataSource();
                }
            }
        }

        public void ChangeDisciplineValue()
        {
            if (!Toolbar.IsNullOrNoneAction())
            {
                if (MessageBox.Show("Bạn muốn thay đổi Số tiền kỷ luật cho tất cả nhân viên?",
                        CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    float result = 0;
                    HRDisciplineEntities entity = (HRDisciplineEntities)CurrentModuleEntity;
                    HRDisciplinesInfo objMainObject = (HRDisciplinesInfo)entity.MainObject;
                    decimal amount = 0;
                    foreach (HREmployeeDisciplinesInfo item in entity.HREmployeeDisciplinesList)
                    {
                        item.HREmployeeDisciplineValue = objMainObject.HRDisciplineValue;
                        if (!objMainObject.HRDisciplineValue.Equals(String.Empty) && Single.TryParse(objMainObject.HRDisciplineValue, out result))
                        {
                            decimal.TryParse(objMainObject.HRDisciplineValue, out amount);
                            item.HREmployeeDisciplineValueAmount = amount;
                        }
                        else
                        {
                            item.HREmployeeDisciplineValueAmount = 0;
                        }
                    }
                    entity.HREmployeeDisciplinesList.GridControl.RefreshDataSource();
                }
            }
        }
        #endregion

        public void PrintKyLuatDinhChi()
        {
            if (Toolbar.CurrentObjectID > 0)
            {
                HRDisciplineEntities entity = (HRDisciplineEntities)CurrentModuleEntity;
                if (entity.HREmployeeDisciplinesList.Count > 0)
                {
                    RPKyLuat rp = new RPKyLuat();
                    List<HREmployeeDisciplinesInfo> list = entity.HREmployeeDisciplinesList.ToList();
                    HRDisciplinesInfo objMainObject = (HRDisciplinesInfo)entity.MainObject;
                    HREmployeesController objEmployeesController = new HREmployeesController();
                    HRLevelsController objLevelsController = new HRLevelsController();
                    BRBranchsController objBranchsController = new BRBranchsController();
                    GEStateProvincesController objStateProvincesController = new GEStateProvincesController();
                    HRDepartmentsController objDepartmentsController = new HRDepartmentsController();
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    HRAllowancesController objAllowancesController = new HRAllowancesController();
                    HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
                    BRBranchsInfo objBranchsInfo;
                    HREmployeesInfo objEmployeesInfo;
                    HRLevelsInfo objLevelsInfo;
                    GEStateProvincesInfo objStateProvincesInfo;
                    HRDepartmentsInfo objDepartmentsInfo;
                    HRDepartmentRoomsInfo objDepartmentRoomsInfo;
                    ADConfigValuesInfo objConfigValuesInfo;
                    List<HREmployeeDisciplinesInfo> listPrintf = new List<HREmployeeDisciplinesInfo>();
                    foreach (var item in list)
                    {
                        XRLabel label = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xrLabelDate"];
                        if (label != null)
                        {
                            label.Text = "Đà Nẵng, ngày " + BOSApp.GetCurrentServerDate().ToString("dd") + " tháng " + BOSApp.GetCurrentServerDate().ToString("MM") + " năm " + BOSApp.GetCurrentServerDate().ToString("yyyy");
                        }
                        objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(item.FK_HREmployeeID);
                        if (objEmployeesInfo != null)
                        {
                            item.HREmployeeName = objEmployeesInfo.HREmployeeName;
                            objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(objEmployeesInfo.FK_BRBranchID);
                            if (objBranchsInfo != null)
                            {
                                item.HREmployeeBranchName = objBranchsInfo.BRBranchCompanyName;
                            }
                        }
                        objLevelsInfo = (HRLevelsInfo)objLevelsController.GetObjectByID(objEmployeesInfo.FK_HRLevelID);
                        if (objLevelsInfo != null)
                        {
                            item.HREmployeeLevelName = objLevelsInfo.HRLevelName;
                        }
                        objDepartmentRoomsInfo = (HRDepartmentRoomsInfo)objDepartmentRoomsController.GetObjectByID(item.FK_HRDepartmentRoomID);
                        if (objDepartmentRoomsInfo != null)
                        {
                            item.HRDepartmentRoomName = objDepartmentRoomsInfo.HRDepartmentRoomName;
                        }
                        //item.HREmployeeDisciplineReason = objMainObject.HRDisciplineName;
                        item.HREmployeeDisciplineDate = objMainObject.HRDisciplineFromDate;

                        label = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xrLabelCompanyName"];
                        if (label != null)
                        {
                            label.Text = item.HREmployeeBranchName.ToUpper();
                        }
                        objConfigValuesInfo = (ADConfigValuesInfo)objConfigValuesController.GetObjectByGroupAndValue("DisciplineType", objMainObject.HRDisciplineType);
                        if (objConfigValuesInfo != null)
                        {
                            label = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xrLabelHTKL"];
                            if (label != null)
                            {
                                label.Text = "(V/v: " + objConfigValuesInfo.ADConfigText + " nhân viên)";
                            }
                            label = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xrLabelDisciplneType"];
                            if (label != null)
                            {
                                label.Text = objConfigValuesInfo.ADConfigText;
                            }
                            label = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xrLabelNDKL"];
                            if (label != null)
                            {
                                label.Text = objConfigValuesInfo.ADConfigText + " đối với Anh/chị";
                            }
                        }
                        listPrintf.Add(item);
                    }
                    BindingSource bds = new BindingSource();
                    rp.DataSource = listPrintf;
                    //bds.DataSource = (HREmployeeDisciplinesInfo)list[0].Clone();
                    //rp.DataSource = bds;
                    //rp.CreateDocument();
                    //for (int i = 1; i < list.Count; i++)
                    //{
                    //    RPKyLuat rp2 = new RPKyLuat();
                    //    bds = new BindingSource();
                    //    bds.DataSource = (HREmployeeDisciplinesInfo)list[i].Clone();
                    //    rp2.DataSource = bds;
                    //    rp2.CreateDocument();
                    //    rp.Pages.AddRange(rp2.Pages);
                    //}
                    guiReportPreview reviewer = new guiReportPreview(rp);
                    reviewer.CreateReport = false;
                    reviewer.Show();
                }
            }
        }

        #region Delete an employee
        /// <summary>
        /// Remove selected item from employee discipline list
        /// </summary>
        public void RemoveSelectedItemFromDisciplinesList()
        {
            HRDisciplineEntities entity = (HRDisciplineEntities)CurrentModuleEntity;
            entity.HREmployeeDisciplinesList.RemoveSelectedRowObjectFromList();
        }

        public void ChangeValueSelectedItemFromDisciplinesList(int fK_HREmployeeID)
        {
            float result = 0;
            HRDisciplineEntities entity = (HRDisciplineEntities)CurrentModuleEntity;
            HRDisciplinesInfo objDisciplinesInfo = (HRDisciplinesInfo)entity.MainObject;
            foreach (HREmployeeDisciplinesInfo obj in entity.HREmployeeDisciplinesList)
            {
                if (obj.FK_HREmployeeID == fK_HREmployeeID)
                {
                    if (!obj.HREmployeeDisciplineValue.Equals(String.Empty) && Single.TryParse(obj.HREmployeeDisciplineValue, out result))
                    {
                        HREmployeesController objEmployeesController = new HREmployeesController();
                        HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(fK_HREmployeeID);
                        if (objDisciplinesInfo.HRDisciplineType.Equals("WorkDay"))
                        {
                            if (objEmployeesInfo.HRPayRollCalculatedSalaryType.Equals("Working"))
                            {
                                decimal workDayAmount = objEmployeesInfo.HREmployeeWorkingSlrAmt / objEmployeesInfo.HREmployeeDaysPerMonth;
                                obj.HREmployeeDisciplineValueAmount = workDayAmount * Convert.ToDecimal(obj.HREmployeeDisciplineValue);
                                //obj.HREmployeeDisciplineValueAmount = BOSApp.RoundingAmount(obj.HREmployeeDisciplineValueAmount, 1000);
                            }
                            else
                            {
                                decimal workDayAmount = objEmployeesInfo.HREmployeeContractSlrAmt * objEmployeesInfo.HREmployeeSalaryFactor / objEmployeesInfo.HREmployeeDaysPerMonth;
                                obj.HREmployeeDisciplineValueAmount = workDayAmount * Convert.ToDecimal(obj.HREmployeeDisciplineValue);
                                //obj.HREmployeeDisciplineValueAmount = BOSApp.RoundingAmount(obj.HREmployeeDisciplineValueAmount, 1000);
                            }
                        }
                        else
                        {
                            obj.HREmployeeDisciplineValueAmount = Convert.ToDecimal(obj.HREmployeeDisciplineValue);
                            //obj.HREmployeeDisciplineValueAmount = BOSApp.RoundingAmount(obj.HREmployeeDisciplineValueAmount, 1000);
                        }

                    }
                }
            }
            entity.HREmployeeDisciplinesList.GridControl.RefreshDataSource();
        }
        #endregion

        #region Set mask for discipline value
        /// <summary>
        /// Set Mask for TextBox of Discipline value when Discipline type change
        /// </summary>
        public void SetMaskForDisciplineValue()
        {
            BOSLookupEdit disciplineTypeLookupEdit = (BOSLookupEdit)Controls[HRDisciplineModule.DisciplineTypeLookupEditName];
            BOSTextBox disciplineValueTextBox = (BOSTextBox)Controls[HRDisciplineModule.DisciplineValueTextBoxName];

            if (disciplineTypeLookupEdit.EditValue.ToString() == DisciplineType.Percent.ToString() ||
                                        disciplineTypeLookupEdit.EditValue.ToString() == DisciplineType.Amount.ToString())
            {
                disciplineValueTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                disciplineValueTextBox.Properties.Mask.EditMask = "n";
                disciplineValueTextBox.Properties.Mask.UseMaskAsDisplayFormat = true;
            }
            if (disciplineTypeLookupEdit.EditValue.ToString() == DisciplineType.Other.ToString())
            {
                disciplineValueTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
                disciplineValueTextBox.Properties.Mask.UseMaskAsDisplayFormat = false;
            }

        }
        #endregion
    }
}
