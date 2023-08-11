using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.HRAllowance
{
    class HRAllowanceModule : BaseModuleERP
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
        public HRAllowanceModule()
        {
            Name = "HRAllowance";
            CurrentModuleEntity = new HRAllowanceEntities();
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

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            HRAllowancesController objAllownacesController = new HRAllowancesController();
            HRAllowancesInfo searchObject = (HRAllowancesInfo)CurrentModuleEntity.SearchObject;
            DataSet ds = objAllownacesController.GetAllowanceList(
                                                            searchObject.HRAllowanceNo,
                                                            BOSUtil.GetSearchString(searchObject.HRAllowanceName),
                                                            AllowanceCategory.Normal.ToString(),
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
            HRAllowanceEntities entity = (HRAllowanceEntities)CurrentModuleEntity;
            HRAllowancesInfo objAllowancesInfo = (HRAllowancesInfo)entity.MainObject;
            objAllowancesInfo.HRAllowanceFromDate = DateTime.Now;
            objAllowancesInfo.HRAllowanceToDate = DateTime.Now;
            objAllowancesInfo.HRAllowanceCategory = AllowanceCategory.Normal.ToString();
        }

        public void ActionNewFromAllowance()
        {
            ActionNew();

            HRAllowanceEntities entity = (HRAllowanceEntities)CurrentModuleEntity;
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
            HRAllowanceEntities entity = (HRAllowanceEntities)CurrentModuleEntity;
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
            HRAllowanceEntities entity = (HRAllowanceEntities)CurrentModuleEntity;
            HRAllowancesInfo objAllowancesInfo = (HRAllowancesInfo)entity.MainObject;

            string allowanceValue = objAllowancesInfo.HRAllowanceValue;
            double value = 0;
            double.TryParse(allowanceValue, out value);


            BOSERP.Modules.HRAllowance.UI.guiSearchEmployee guiSearchEmployee = new BOSERP.Modules.HRAllowance.UI.guiSearchEmployee(objAllowancesInfo.HRAllowanceFromDate, objAllowancesInfo.HRAllowanceType);
            guiSearchEmployee.Module = this;
            if (guiSearchEmployee.ShowDialog() == DialogResult.OK)
            {
                entity.HREmployeeList.Invalidate(guiSearchEmployee.SelectedEmployeeList);
                foreach (HREmployeesInfo objEmployeesInfo in entity.HREmployeeList)
                {
                    if (objEmployeesInfo.Selected)
                    {
                        if (!entity.HREmployeeAllowancesList.Exists("FK_HREmployeeID", objEmployeesInfo.HREmployeeID))
                        {
                            HREmployeeAllowancesInfo objEmployeeAllowancesInfo = new HREmployeeAllowancesInfo();
                            entity.SetDefaultValuesFromEmployee(objEmployeeAllowancesInfo, objEmployeesInfo);
                            //TNDLoc [ADD][10/12/2015][Issue change allowance value],START
                            //objEmployeeAllowancesInfo.HREmployeeAllowanceValueAmount = value;
                            //TNDLoc [ADD][10/12/2015][Issue change allowance value],END
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
            HRAllowanceEntities entity = (HRAllowanceEntities)CurrentModuleEntity;
            entity.HREmployeeAllowancesList.RemoveSelectedRowObjectFromList();
        }
        #endregion

        #region Set mask for discipline value
        /// <summary>
        /// Set Mask for TextBox of Discipline value when Discipline type change
        /// </summary>
        public void SetMaskForAllowanceValue()
        {
            BOSLookupEdit allowanceTypeLookupEdit = (BOSLookupEdit)Controls[HRAllowanceModule.AllowanceTypeLookupEditName];
            BOSTextBox allowanceValueTextBox = (BOSTextBox)Controls[HRAllowanceModule.AllowanceValueTextBoxName];

            // Old
            if (allowanceTypeLookupEdit.EditValue != null)
            {
                if (allowanceTypeLookupEdit.EditValue.ToString() == AllowanceType.Percent.ToString() ||
                                            allowanceTypeLookupEdit.EditValue.ToString() == AllowanceType.Amount.ToString())
                {
                    if (allowanceValueTextBox != null)
                    {
                        allowanceValueTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                        allowanceValueTextBox.Properties.Mask.EditMask = "n";
                        allowanceValueTextBox.Properties.Mask.UseMaskAsDisplayFormat = true;
                    }
                }
                if (allowanceTypeLookupEdit.EditValue.ToString() == AllowanceType.Other.ToString())
                {
                    if (allowanceValueTextBox != null)
                    {
                        allowanceValueTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
                        allowanceValueTextBox.Properties.Mask.UseMaskAsDisplayFormat = false;
                    }
                }
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

        //TNDLoc [ADD][10/12/2015][Issue change allowance value],START
        public void ChangeAllowanceValue()
        {
            HRAllowanceEntities entity = (HRAllowanceEntities)CurrentModuleEntity;
            HRAllowancesInfo objAllowancesInfo = (HRAllowancesInfo)entity.MainObject;
            HREmployeesController objEmployeesController = new HREmployeesController();
            foreach (HREmployeeAllowancesInfo detail in entity.HREmployeeAllowancesList)
            {
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(detail.FK_HREmployeeID);
                detail.HREmployeeAllowanceAmount = objAllowancesInfo.HRAllowanceConfigValue;
                entity.SetDefaultValuesFromEmployee(detail, objEmployeesInfo, objAllowancesInfo.HRAllowanceConfigValue);
            }


            entity.HREmployeeAllowancesList.GridControl.RefreshDataSource();
        }
        //TNDLoc [ADD][10/12/2015][Issue change allowance value],END
    }
}
