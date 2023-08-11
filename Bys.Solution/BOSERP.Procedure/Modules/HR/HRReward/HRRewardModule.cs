using BOSCommon;
using BOSComponent;
using Localization;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace BOSERP.Modules.HRReward
{
    public class HRRewardModule : BaseModuleERP
    {
        #region Constant
        public const string AddButtonControlName = "fld_btnAdd";
        public const string DeleteButtonControlName = "fld_btnDelete";
        public const string RewardTypeLookupEditName = "fld_lkeHRRewardType";
        public const string RewardValueTextBoxName = "fld_txtHRRewardValue";
        public const string RewardFromDateDateEditName = "fld_dteHRRewardFromDate";
        public const string RewardToDateDateEditName = "fld_dteHRRewardToDate";

        //NNThinh [MOD] [22/11/2013] [DB centre] [Search Reward by BRBranchID], START
        public const string SearchBranchLookupEditControlName = "fld_lkeFK_BRBranchID";
        //NNThinh [MOD] [22/11/2013] [DB centre] [Search Reward by BRBranchID], END
        #endregion
        #region Public properties
        //NNThinh [MOD] [22/11/2013] [DB centre] [Search Reward by BRBranchID], START
        //public BOSLookupEdit SearchBranchLookupEditControl;
        //public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        //public List<BRBranchsInfo> BranchList;
        //NNThinh [MOD] [22/11/2013] [DB centre] [Search Reward by BRBranchID], END
        #endregion
        public HRRewardModule()
        {
            Name = "HRReward";
            CurrentModuleEntity = new HRRewardEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            BOSDateEdit rewardFromDateDateEdit = (BOSDateEdit)Controls[HRRewardModule.RewardFromDateDateEditName];
            BOSDateEdit rewardToDateDateEdit = (BOSDateEdit)Controls[HRRewardModule.RewardToDateDateEditName];
            //HREmployeeRewardGridControl gridControl = (HREmployeeRewardGridControl)Controls[""];
        }


        protected override DataSet GetSearchData(ref string searchQuery)
        {
            HRRewardsController objRewardsController = new HRRewardsController();
            HRRewardsInfo searchObject = (HRRewardsInfo)CurrentModuleEntity.SearchObject;

            DataSet ds;

            ds = objRewardsController.GetRewardListByBranchID(
                                                           searchObject.HRRewardNo,
                                                           searchObject.HRRewardName,
                                                           searchObject.FK_BRBranchID);
            return ds;
        }

        public override void ActionNew()
        {
            base.ActionNew();
            HRRewardEntities entity = (HRRewardEntities)CurrentModuleEntity;
            HRRewardsInfo objRewardsInfo = (HRRewardsInfo)entity.MainObject;
            objRewardsInfo.HRRewardFromDate = DateTime.Now;
            objRewardsInfo.HRRewardToDate = DateTime.Now;
            SetEnableFNTL();
        }

        public override int ActionSave()
        {

            HRRewardEntities entity = (HRRewardEntities)CurrentModuleEntity;
            HRRewardsInfo objRewardsInfo = (HRRewardsInfo)entity.MainObject;
            DateTime fromDate = Convert.ToDateTime(objRewardsInfo.HRRewardFromDate);
            DateTime toDate = Convert.ToDateTime(objRewardsInfo.HRRewardToDate);
            objRewardsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;

            if (entity.HREmployeeRewardsList != null)
            {
                entity.HREmployeeRewardsList.EndCurrentEdit();
            }

            if (objRewardsInfo.HRRewardType.Equals(RewardType.Quarter.ToString()))
            {
                MessageBox.Show("Không thể lưu hình thức thưởng quý tại module khen thưởng.Vui lòng lưu hình thức này tại module thưởng quý");
                return 0;
            }


            if (toDate < fromDate)
            {
                MessageBox.Show(RewardLocalizedResources.DateErrorMessage.ToString(), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                base.ActionCancel();
            }

            if (objRewardsInfo.HRRewardType == RewardType.PNTL.ToString())
            {
                if (!CheckPNRemain())
                {
                    return 0;
                }
            }

            return base.ActionSave();
        }

        public override void Invalidate(int iObjectID)
        {
            base.Invalidate(iObjectID);
            SetMaskForTextBox();
            HRRewardsInfo objRewardsInfo = (HRRewardsInfo)CurrentModuleEntity.MainObject;
            SetEnableFNTL();
        }

        #region Add an employee
        /// <summary>
        /// Show screen to search employee from employee list and add to employee list that have reward
        /// </summary>
        public void AddEmployee()
        {
            HRRewardEntities entity = (HRRewardEntities)CurrentModuleEntity;
            HRRewardsInfo objRewardsInfo = (HRRewardsInfo)entity.MainObject;
            BOSERP.Modules.HRReward.UI.guiSearchEmployee guiEmployee = new BOSERP.Modules.HRReward.UI.guiSearchEmployee();
            guiEmployee.Module = this;

            if (objRewardsInfo.HRRewardType == RewardType.PNTL.ToString())
            {
                guiEmployee.reWardType = RewardType.PNTL.ToString();
            }

            if (guiEmployee.ShowDialog() == DialogResult.OK)
            {
                entity.HREmployeeList.Invalidate(guiEmployee.SelectedEmployeeList);
                foreach (HREmployeesInfo objEmployeesInfo in entity.HREmployeeList)
                {
                    if (objEmployeesInfo.Selected)
                    {
                        if (!entity.HREmployeeRewardsList.Exists("FK_HREmployeeID", objEmployeesInfo.HREmployeeID))
                        {
                            HREmployeeRewardsInfo objEmployeeRewardsInfo = new HREmployeeRewardsInfo();
                            entity.SetDefaultValuesFromEmployee(objEmployeeRewardsInfo, objEmployeesInfo);
                            entity.HREmployeeRewardsList.Add(objEmployeeRewardsInfo);
                        }
                    }
                }
                entity.HREmployeeRewardsList.GridControl.RefreshDataSource();
            }
        }
        #endregion

        #region Delete an employee
        /// <summary>
        /// Remove an item from the reward list of the current employee
        /// </summary>
        public void RemoveItemFromRewardList()
        {
            HRRewardEntities entity = (HRRewardEntities)CurrentModuleEntity;
            entity.HREmployeeRewardsList.RemoveSelectedRowObjectFromList();
        }
        #endregion

        #region SetMaskForTextBox
        /// <summary>
        /// Set Mask for TextBox of RewardValue when RewardType change
        /// </summary>
        public void SetMaskForTextBox()
        {
            BOSLookupEdit rewardTypeLookupEdit = (BOSLookupEdit)Controls[HRRewardModule.RewardTypeLookupEditName];
            BOSTextBox rewardValueTextBox = (BOSTextBox)Controls[HRRewardModule.RewardValueTextBoxName];
            HRRewardEntities entity = (HRRewardEntities)CurrentModuleEntity;
            HRRewardsInfo objRewardsInfo = (HRRewardsInfo)entity.MainObject;
            if (rewardTypeLookupEdit.EditValue.ToString() == RewardType.Percent.ToString())
            {
                rewardValueTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                rewardValueTextBox.Properties.Mask.EditMask = "n";
                rewardValueTextBox.Properties.Mask.UseMaskAsDisplayFormat = true;
            }
            if (rewardTypeLookupEdit.EditValue.ToString() == RewardType.Amount.ToString())
            {
                rewardValueTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                rewardValueTextBox.Properties.Mask.EditMask = "n";
                rewardValueTextBox.Properties.Mask.UseMaskAsDisplayFormat = true;
            }
            if (rewardTypeLookupEdit.EditValue.ToString() == RewardType.Other.ToString())
            {
                rewardValueTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
                rewardValueTextBox.Properties.Mask.UseMaskAsDisplayFormat = false;
            }

            SetEnableFNTL();
            entity.UpdateMainObjectBindingSource();
        }


        public void ChangeValueSelectedItemFromRewardsList(int fK_HREmployeeID)
        {
            float result = 0;
            HRRewardEntities entity = (HRRewardEntities)CurrentModuleEntity;
            HRRewardsInfo objRewardsInfo = (HRRewardsInfo)entity.MainObject;
            foreach (HREmployeeRewardsInfo obj in entity.HREmployeeRewardsList)
            {
                if (obj.FK_HREmployeeID == fK_HREmployeeID)
                {
                    if (!obj.HREmployeeRewardValue.Equals(String.Empty) && Single.TryParse(obj.HREmployeeRewardValue, out result))
                    {
                        HREmployeesController objEmployeesController = new HREmployeesController();
                        HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(fK_HREmployeeID);
                        if (objRewardsInfo.HRRewardType.Equals("WorkDay"))
                        {
                            if (objEmployeesInfo.HRPayRollCalculatedSalaryType.Equals("Working"))
                            {
                                decimal workDayAmount = objEmployeesInfo.HREmployeeWorkingSlrAmt / objEmployeesInfo.HREmployeeDaysPerMonth;
                                obj.HREmployeeRewardValueAmount = workDayAmount * Convert.ToDecimal(obj.HREmployeeRewardValue);
                                obj.HREmployeeRewardValueAmount = BOSApp.RoundingAmount(obj.HREmployeeRewardValueAmount, 1000);
                            }
                            else
                            {
                                decimal workDayAmount = objEmployeesInfo.HREmployeeContractSlrAmt * objEmployeesInfo.HREmployeeSalaryFactor / objEmployeesInfo.HREmployeeDaysPerMonth;
                                obj.HREmployeeRewardValueAmount = workDayAmount * Convert.ToDecimal(obj.HREmployeeRewardValue);
                                obj.HREmployeeRewardValueAmount = BOSApp.RoundingAmount(obj.HREmployeeRewardValueAmount, 1000);
                            }
                        }
                        else
                        {
                            obj.HREmployeeRewardValueAmount = Convert.ToDecimal(obj.HREmployeeRewardValue);
                            obj.HREmployeeRewardValueAmount = BOSApp.RoundingAmount(obj.HREmployeeRewardValueAmount, 1000);
                        }

                    }
                }
            }
            entity.HREmployeeRewardsList.GridControl.RefreshDataSource();
        }

        public void UpdateValue()
        {
            float result = 0;
            HRRewardEntities entity = (HRRewardEntities)CurrentModuleEntity;
            HRRewardsInfo objMainObject = (HRRewardsInfo)entity.MainObject;
            foreach (HREmployeeRewardsInfo item in entity.HREmployeeRewardsList)
            {
                item.HREmployeeRewardValue = objMainObject.HRRewardValue;
                if (!objMainObject.HRRewardValue.Equals(String.Empty) && Single.TryParse(objMainObject.HRRewardValue, out result))
                {
                    item.HREmployeeRewardValueAmount = Convert.ToDecimal(objMainObject.HRRewardValue);
                }
                else
                {
                    item.HREmployeeRewardValueAmount = 0;
                }
            }
            entity.HREmployeeRewardsList.GridControl.RefreshDataSource();
        }

        public void SetEnableFNTL()
        {
            HRRewardEntities entity = (HRRewardEntities)CurrentModuleEntity;
            HRRewardsInfo objMainObject = (HRRewardsInfo)entity.MainObject;
            HREmployeeRewardGridControl ProposalItemsGridControl = (HREmployeeRewardGridControl)entity.HREmployeeRewardsList.GridControl;
            ProposalItemsGridControl.EnablePNTL(objMainObject.HRRewardType);
        }

        public bool CheckPNRemain()
        {
            HRRewardEntities entity = (HRRewardEntities)CurrentModuleEntity;
            HRRewardsInfo objMainObject = (HRRewardsInfo)entity.MainObject;
            if (entity.HREmployeeRewardsList.Count() > 0)
            {
                string data = string.Empty;
                bool check = false;
                decimal soPN = 0;
                decimal soPNRemain = 0;
                HREmployeeRewardsController objEmployeeRewardsController = new HREmployeeRewardsController();
                HREmployeeRewardsInfo objEmployeeRewardsInfo = new HREmployeeRewardsInfo();

                HRLeaveDaysController objLeaveDaysController = new HRLeaveDaysController();

                entity.HREmployeeRewardsList.ForEach(o =>
                {
                    soPN = 0;
                    soPNRemain = 0;

                    objEmployeeRewardsInfo = new HREmployeeRewardsInfo();
                    objEmployeeRewardsInfo = objEmployeeRewardsController.GetSumPNInEmployeeRewards(o.FK_HREmployeeID, objMainObject.HRRewardID);
                    if (objEmployeeRewardsInfo != null)
                    {
                        soPN = objEmployeeRewardsInfo.HREmployeeRewardSPN;
                    }

                    soPNRemain = objLeaveDaysController.GetLeaveDayTotalQtyRemain(objMainObject.HRRewardToDate, o.FK_HREmployeeID);

                    if (o.HREmployeeRewardSPN > soPNRemain - soPN)
                    {
                        data += Environment.NewLine + o.HREmployeeNo;
                        check = true;
                    }
                });

                if (check)
                {
                    MessageBox.Show("Số phép năm tính lương vượt quá số lượng còn lại. Vui lòng kiểm tra nhân viên có mã:"
                                       + data
                                       , CommonLocalizedResources.MessageBoxDefaultCaption,
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}
