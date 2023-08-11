using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.HRAllowanceManage
{
    class HRAllowanceManageModule : BaseModuleERP
    {
        #region Constant
        public const string AllowanceTypeLookupEditName = "fld_lkeHRAllowanceType";
        public const string AllowanceValueTextBoxName = "fld_txtHRAllowanceValue";
        public const string AllowanceOptionLookupEditName = "bosLookupEdit1";

        //DaoLC [MOD] [22/11/2013] [DB centre] [Search document by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //DaoLC [MOD] [22/11/2013] [DB centre] [Search document by BRBranchID], END
        #endregion
        #region Public properties
        ////DaoLC [MOD] [22/11/2013] [DB centre] [Search document by BRBranchID], START
        //public BOSLookupEdit SearchBranchLookupEditControl;
        //public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        //public List<BRBranchsInfo> BranchList;
        ////DaoLC [MOD] [22/11/2013] [DB centre] [Search document by BRBranchID], END

        BOSLookupEdit AllowanceOptionLookupEdit;
        #endregion
        public HRAllowanceManageModule()
        {
            Name = "HRAllowanceManage";
            CurrentModuleEntity = new HRAllowanceManageEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            //DaoLC [MOD] [22/11/2013] [DB centre] [Search document by BRBranchID], START
            //GetCurrentModuleDataViewPermission();
            //SearchBranchLookupEditControl = (BOSLookupEdit)Controls[SearchBranchLookupEditControlName];
            //SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            //DaoLC [MOD] [22/11/2013] [DB centre] [Search document by BRBranchID], END
            AllowanceOptionLookupEdit = (BOSLookupEdit)Controls[AllowanceOptionLookupEditName];
            //InvalidateBOSLookupEdit(AllowanceOptionLookupEdit);
        }

        public void InvalidateBOSLookupEdit(BOSLookupEdit controlName)
        {
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = objConfigValuesController.GetADConfigValuesByGroup("EmployeePayrollFormulaSalaryTypeOption");
            controlName.Properties.DataSource = ds.Tables[0];
            controlName.Properties.DisplayMember = "ADConfigText";
            controlName.Properties.ValueMember = "ADConfigKeyValue";
            controlName.Properties.ForceInitialize();
        }

        public void ValidCellValue(int row)
        {
            decimal productivity = 0, quality = 0, manage = 0;

            HRAllowanceManageEntities entity = (HRAllowanceManageEntities)CurrentModuleEntity;
            HREmployeeAllowancesInfo objEmployeeAllowancesInfo = entity.HREmployeeAllowancesList[row];
            if (objEmployeeAllowancesInfo == null)
                return;

            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objEmployeeAllowancesInfo.FK_HREmployeeID);
            if (objEmployeesInfo == null)
                return;

            HRAllowanceConfigsController objAllowanceConfigsController = new HRAllowanceConfigsController();
            List<HRAllowanceConfigsInfo> listAllowanceConfigsInfo = objAllowanceConfigsController.GetAllowanceConfigByFKEmployeePayrollFormula(objEmployeesInfo.FK_HREmployeePayrollFormulaID);
            if (listAllowanceConfigsInfo != null)
            {
                foreach (HRAllowanceConfigsInfo item in listAllowanceConfigsInfo)
                {
                    if (item.HRAllowanceConfigName == AllowanceConfigName.Productivity.ToString())
                        productivity = item.HRAllowanceConfigPercent;
                    if (item.HRAllowanceConfigName == AllowanceConfigName.Quality.ToString())
                        quality = item.HRAllowanceConfigPercent;
                    if (item.HRAllowanceConfigName == AllowanceConfigName.Manage.ToString())
                        manage = item.HRAllowanceConfigPercent;
                }
            }

            if (objEmployeeAllowancesInfo.HREmployeeAllowanceProductivityCriteria > productivity)
                objEmployeeAllowancesInfo.HREmployeeAllowanceProductivityCriteria = productivity;
            if (objEmployeeAllowancesInfo.HREmployeeAllowanceQualityCriteria > quality)
                objEmployeeAllowancesInfo.HREmployeeAllowanceQualityCriteria = quality;
            if (objEmployeeAllowancesInfo.HREmployeeAllowanceManageCriteria > manage)
                objEmployeeAllowancesInfo.HREmployeeAllowanceManageCriteria = manage;

            entity.HREmployeeAllowancesList.GridControl.RefreshDataSource();
        }

        public void ResetValueAmount(int row)
        {
            HRAllowanceManageEntities entity = (HRAllowanceManageEntities)CurrentModuleEntity;
            HREmployeeAllowancesInfo objEmployeeAllowancesInfo = entity.HREmployeeAllowancesList[row];
            if (objEmployeeAllowancesInfo == null)
                return;

            objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = objEmployeeAllowancesInfo.HREmployeeAllowanceProductivityCriteria * objEmployeeAllowancesInfo.HREmployeeAllowanceConfiguredProductivityAmount / 100
                                                                        + objEmployeeAllowancesInfo.HREmployeeAllowanceQualityCriteria * objEmployeeAllowancesInfo.HREmployeeAllowanceConfiguredQualityAmount / 100
                                                                        + objEmployeeAllowancesInfo.HREmployeeAllowanceManageCriteria * objEmployeeAllowancesInfo.HREmployeeAllowanceConfiguredManageAmount / 100;

            //objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = objEmployeeAllowancesInfo.HREmployeeAllowanceAmount * (objEmployeeAllowancesInfo.HREmployeeAllowanceProductivityCriteria +
            //    objEmployeeAllowancesInfo.HREmployeeAllowanceQualityCriteria + objEmployeeAllowancesInfo.HREmployeeAllowanceManageCriteria) / 100;

            entity.HREmployeeAllowancesList.GridControl.RefreshDataSource();
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            HRAllowancesController objAllownacesController = new HRAllowancesController();
            HRAllowancesInfo searchObject = (HRAllowancesInfo)CurrentModuleEntity.SearchObject;
            DataSet ds = objAllownacesController.GetAllowanceList(
                                                            searchObject.HRAllowanceNo,
                                                            BOSUtil.GetSearchString(searchObject.HRAllowanceName),
                                                            AllowanceCategory.ForManage.ToString(),
                                                            searchObject.FK_BRBranchID);
            return ds;
        }

        public override void ResetSearchObject()
        {
            base.ResetSearchObject();

            HRAllowancesInfo searchObject = (HRAllowancesInfo)CurrentModuleEntity.SearchObject;
            searchObject.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
        }

        public override void ActionNew()
        {
            base.ActionNew();
            HRAllowanceManageEntities entity = (HRAllowanceManageEntities)CurrentModuleEntity;
            HRAllowancesInfo objAllowancesInfo = (HRAllowancesInfo)entity.MainObject;
            objAllowancesInfo.HRAllowanceFromDate = DateTime.Now;
            objAllowancesInfo.HRAllowanceToDate = DateTime.Now;
            objAllowancesInfo.HRAllowanceCategory = AllowanceCategory.ForManage.ToString();
            objAllowancesInfo.HRAllowanceType = AllowanceType.Effective.ToString();
            objAllowancesInfo.HRAllowanceOption = AllowanceOption.AddToSalary.ToString();
        }

        public void ActionNewFromAllowance()
        {
            ActionNew();

            HRAllowanceManageEntities entity = (HRAllowanceManageEntities)CurrentModuleEntity;
            HRAllowancesInfo mainObject = (HRAllowancesInfo)entity.MainObject;
            HRAllowancesController objAllowancesController = new HRAllowancesController();
            List<HRAllowancesInfo> allowanceList = objAllowancesController.GetAllAllowances();
            guiFind<HRAllowancesInfo> guiFind = new guiFind<HRAllowancesInfo>(TableName.HRAllowancesTableName, allowanceList, null, this);
            guiFind.ShowDialog();
            if (guiFind.DialogResult == DialogResult.OK)
            {
                int allowanceID = Convert.ToInt32(guiFind.Tag.ToString());
                HRAllowancesInfo objAllowancesInfo = (HRAllowancesInfo)objAllowancesController.GetObjectByID(allowanceID);
                if (objAllowancesInfo != null)
                {
                    HREmployeeAllowancesController objEmployeeAllowancesController = new HREmployeeAllowancesController();
                    List<HREmployeeAllowancesInfo> itemList = objEmployeeAllowancesController.GetEmployeeAllowanceListByAllowanceID2(allowanceID);
                    mainObject.HRAllowanceName = objAllowancesInfo.HRAllowanceName;
                    mainObject.HRAllowanceDesc = objAllowancesInfo.HRAllowanceDesc;
                    mainObject.HRAllowanceType = objAllowancesInfo.HRAllowanceType;
                    mainObject.HRAllowanceOption = objAllowancesInfo.HRAllowanceOption;
                    mainObject.HRAllowanceValue = objAllowancesInfo.HRAllowanceValue;
                    entity.InvalidateEmployeeAllowancesList(allowanceID);
                    foreach (HREmployeeAllowancesInfo item in itemList)
                    {

                    }

                }
            }
        }
        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            SetMaskForAllowanceValue();
        }

        public override int ActionSave()
        {
            HRAllowanceManageEntities entity = (HRAllowanceManageEntities)CurrentModuleEntity;
            HRAllowancesInfo objAllowancesInfo = (HRAllowancesInfo)entity.MainObject;
            DateTime fromDate = Convert.ToDateTime(objAllowancesInfo.HRAllowanceFromDate);
            DateTime toDate = Convert.ToDateTime(objAllowancesInfo.HRAllowanceToDate);
            objAllowancesInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            if (toDate < fromDate)
            {
                //MessageBox.Show(DisciplineLocalizedResources.DateErrorMessage.ToString(), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                base.ActionCancel();
            }
            return base.ActionSave();
        }

        #region Add an employee
        /// <summary>
        /// Show screen to search employee from employee list and add employee is disciplined to employee list
        /// </summary>
        public void AddEmployee()
        {
            BOSERP.Modules.HRAllowance.UI.guiSearchEmployee guiSearchEmployee = new BOSERP.Modules.HRAllowance.UI.guiSearchEmployee();
            guiSearchEmployee.Module = this;
            if (guiSearchEmployee.ShowDialog() == DialogResult.OK)
            {
                HRAllowanceManageEntities entity = (HRAllowanceManageEntities)CurrentModuleEntity;
                entity.HREmployeeList.Invalidate(guiSearchEmployee.SelectedEmployeeList);
                foreach (HREmployeesInfo objEmployeesInfo in entity.HREmployeeList)
                {
                    if (objEmployeesInfo.Selected)
                    {
                        if (!entity.HREmployeeAllowancesList.Exists("FK_HREmployeeID", objEmployeesInfo.HREmployeeID))
                        {
                            HREmployeeAllowancesInfo objEmployeeAllowancesInfo = new HREmployeeAllowancesInfo();
                            entity.SetDefaultValuesFromEmployee(objEmployeeAllowancesInfo, objEmployeesInfo);
                            entity.HREmployeeAllowancesList.Add(objEmployeeAllowancesInfo);
                        }
                    }
                }
                entity.HREmployeeAllowancesList.GridControl.RefreshDataSource();
            }
        }
        #endregion

        #region Delete an employee
        /// <summary>
        /// Remove selected item from employee discipline list
        /// </summary>
        public void RemoveSelectedItemFromAllowancesList()
        {
            HRAllowanceManageEntities entity = (HRAllowanceManageEntities)CurrentModuleEntity;
            entity.HREmployeeAllowancesList.RemoveSelectedRowObjectFromList();
        }
        #endregion

        #region Set mask for discipline value
        /// <summary>
        /// Set Mask for TextBox of Discipline value when Discipline type change
        /// </summary>
        public void SetMaskForAllowanceValue()
        {
            BOSLookupEdit allowanceTypeLookupEdit = (BOSLookupEdit)Controls[HRAllowanceManageModule.AllowanceTypeLookupEditName];
            BOSTextBox allowanceValueTextBox = (BOSTextBox)Controls[HRAllowanceManageModule.AllowanceValueTextBoxName];

            if (allowanceTypeLookupEdit.EditValue.ToString() == AllowanceType.Percent.ToString() ||
                                        allowanceTypeLookupEdit.EditValue.ToString() == AllowanceType.Amount.ToString())
            {
                allowanceValueTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                allowanceValueTextBox.Properties.Mask.EditMask = "n";
                allowanceValueTextBox.Properties.Mask.UseMaskAsDisplayFormat = true;
            }
            if (allowanceTypeLookupEdit.EditValue.ToString() == AllowanceType.Other.ToString())
            {
                allowanceValueTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
                allowanceValueTextBox.Properties.Mask.UseMaskAsDisplayFormat = false;
            }

        }
        #endregion

        #region Extra method
        //DaoLC [MOD] [22/11/2013] [DB centre] [Search document by BRBranchID], START
        //public void GetCurrentModuleDataViewPermission()
        //{
        //    CurrentModuleDataViewPermissionList = BOSApp.CurrentADDataViewPermissionList.Where(i => i.STModuleName == Name && i.ADDataViewPermissionType == ADDataViewPermissionType.Module).ToList();

        //    List<int> branchIDList = new List<int>();
        //    foreach (ADDataViewPermissionsInfo dataViewPermissionsInfo in CurrentModuleDataViewPermissionList)
        //    {
        //        branchIDList.Add(dataViewPermissionsInfo.FK_BRBranchID);
        //    }

        //    if (branchIDList.Count == 0)
        //    {
        //        BranchList = new List<BRBranchsInfo>();
        //    }
        //    else
        //    {
        //        BRBranchsController objBranchsController = new BRBranchsController();
        //        List<BRBranchsInfo> branchList = objBranchsController.GetAllBranches();

        //        BranchList = branchList.Where(i => branchIDList.IndexOf(i.BRBranchID) > -1).ToList();
        //    }
        //}
        //protected override DataSet GetSearchData(ref string searchQuery)
        //{
        //    bool reset = false;
        //    if (!string.IsNullOrEmpty(searchQuery)) reset = true;
        //    base.GetSearchData(ref searchQuery);
        //    if (reset || (SearchBranchLookupEditControl != null && SearchBranchLookupEditControl.EditValue != null &&
        //        (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")))
        //    {
        //        if (BranchList.Count == 0)
        //        {
        //            searchQuery += string.Format(" and FK_BRBranchID = -1");
        //        }
        //        else
        //        {
        //            string str = "";
        //            foreach (var item in BranchList)
        //            {
        //                str += "," + item.BRBranchID.ToString();
        //            }
        //            searchQuery += string.Format(" and FK_BRBranchID in ({0})", str.Substring(1));
        //        }
        //    }
        //    else if (SearchBranchLookupEditControl != null && SearchBranchLookupEditControl.EditValue != null)
        //    {
        //        searchQuery += string.Format(" and FK_BRBranchID = {0}", SearchBranchLookupEditControl.EditValue.ToString());
        //    }
        //    string mainObjectControllerName = BOSUtil.GetBusinessControllerNameFromBusinessObject(CurrentModuleEntity.MainObject);
        //    BaseBusinessController objCurrentObjectController = BusinessControllerFactory.GetBusinessController(mainObjectControllerName);
        //    DataSet ds = objCurrentObjectController.GetDataSet(searchQuery);
        //    return ds;
        //}
        //Daolc [MOD] [22/11/2013] [DB centre] [Search document by BRBranchID], END
        #endregion

        public decimal CalValueAllowance(decimal defAllowance, decimal percentConfig, decimal percentReal)
        {
            decimal result = (((defAllowance / 100) * percentConfig) / 100)
                                * percentReal;

            return result;
        }


        public void CalAllowanceAmount(HREmployeeAllowancesInfo allowance)
        {
            HRAllowanceManageEntities entity = (HRAllowanceManageEntities)CurrentModuleEntity;
            HRAllowancesInfo objAllowancesInfo = (HRAllowancesInfo)entity.MainObject;

            HRAllowanceManageConfigsController amcController = new HRAllowanceManageConfigsController();
            HRAllowanceManageConfigsInfo amcInfo = amcController.GetAllowanceManageByEmployeeeID(allowance.FK_HREmployeeID).FirstOrDefault();
            allowance.HREmployeeAllowanceConfiguredManageAmount = 0;
            allowance.HREmployeeAllowanceConfiguredProductivityAmount = 0;
            allowance.HREmployeeAllowanceConfiguredQualityAmount = 0;
            allowance.HREmployeeAllowanceValueAmount = 0;
            allowance.HREmployeeAllowanceExactlyAmount = 0;
            allowance.HREmployeeAllowanceValue = string.Empty;
            if (amcInfo != null)
            {
                allowance.HREmployeeAllowanceValue = amcInfo.HRAllowanceManageConfigName;
                // (1) Phụ cấp quản lý = % đánh giá quản lý * (mức phụ cấp (trong quản lý nhân viên) * % quản lý (theo cấu hình mức phụ cấp trong cấu hình hệ thống)) 
                allowance.HREmployeeAllowanceConfiguredManageAmount
                    = CalValueAllowance(allowance.HREmployeeAllowanceAmount
                                        , amcInfo.HRAllowanceManageConfigManageCriteria
                                        , allowance.HREmployeeAllowanceManageCriteria);

                // (2) Phụ cấp năng suất = % đánh giá năng suất * (mức phụ cấp (trong quản lý nhân viên) * % tiến độ (theo cấu hình mức phụ cấp trong cấu hình hệ thống))
                allowance.HREmployeeAllowanceConfiguredProductivityAmount
                   = CalValueAllowance(allowance.HREmployeeAllowanceAmount
                                       , amcInfo.HRAllowanceManageConfigProductivityCriteria
                                       , allowance.HREmployeeAllowanceProductivityCriteria);

                // (3) Phụ cấp chất lượng = % đánh giá chất lượng * (mức phụ cấp (trong quản lý nhân viên) * % chất lượng (theo cấu hình mức phụ cấp trong cấu hình hệ thống)) 
                allowance.HREmployeeAllowanceConfiguredQualityAmount
                   = CalValueAllowance(allowance.HREmployeeAllowanceAmount
                                       , amcInfo.HRAllowanceManageConfigQualityCriteria
                                       , allowance.HREmployeeAllowanceQualityCriteria);

                // (4) Phụ cấp chính xác = % đánh giá chính xác * (mức phụ cấp (trong quản lý nhân viên) * % chất lượng (theo cấu hình mức phụ cấp trong cấu hình hệ thống)) 
                allowance.HREmployeeAllowanceExactlyAmount
                   = CalValueAllowance(allowance.HREmployeeAllowanceAmount
                                       , amcInfo.HRAllowanceManageConfigExactlyCriteria
                                       , allowance.HREmployeeAllowanceExactlyCriteria);

                // (5) Tổng tền phụ cấp trách nhiệm (có thể nhận được) = (1) + (2) + (3)
                decimal canRecieveAmount = allowance.HREmployeeAllowanceConfiguredManageAmount
                                        + allowance.HREmployeeAllowanceConfiguredProductivityAmount
                                        + allowance.HREmployeeAllowanceConfiguredQualityAmount
                                        + allowance.HREmployeeAllowanceExactlyAmount;

                allowance.HREmployeeAllowanceValueAmount = canRecieveAmount;
            }
        }
    }
}
