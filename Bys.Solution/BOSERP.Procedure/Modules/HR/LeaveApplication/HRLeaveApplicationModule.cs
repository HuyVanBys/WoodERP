using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.LeaveApplication
{
    public class LeaveApplicationModule : BaseTransactionModule
    {
        #region Constant
        public const string SearchBranchLookupEditControlName = "fld_lkeSearchFK_BRBranchID";
        #endregion

        #region Public properties
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        #endregion

        public LeaveApplicationModule()
        {
            Name = "LeaveApplication";
            CurrentModuleEntity = new LeaveApplicationEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
            GetCurrentModuleDataViewPermission();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[LeaveApplicationModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
        }

        protected override DataSet GetSearchData(ref string searchQuery)
        {
            HRRequestLeaveDaysInfo searchObject = (HRRequestLeaveDaysInfo)CurrentModuleEntity.SearchObject;
            HRRequestLeaveDaysController objLeaveApplicationsController = new HRRequestLeaveDaysController();

            DataSet ds = new DataSet();
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objLeaveApplicationsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objLeaveApplicationsController.GetLeaveApplicationListDatasetByListOfBranchID(
                                                                searchObject.HRRequestLeaveDayNo,
                                                                searchObject.HRRequestLeaveDayNote,
                                                                searchObject.LeaveApplicationSearchFromDate,
                                                                searchObject.LeaveApplicationSearchToDate,
                                                                BranchList);
                }
            }
            else
            {
                ds = objLeaveApplicationsController.GetLeaveApplicationListDataset(
                                                                searchObject.HRRequestLeaveDayNo,
                                                                searchObject.HRRequestLeaveDayNote,
                                                                searchObject.LeaveApplicationSearchFromDate,
                                                                searchObject.LeaveApplicationSearchToDate,
                                                                searchObject.FK_BRBranchID);
            }

            return ds;
        }

        public void GetCurrentModuleDataViewPermission()
        {
            CurrentModuleDataViewPermissionList = BOSApp.CurrentADDataViewPermissionList.Where(i => i.STModuleName == Name && i.ADDataViewPermissionType == ADDataViewPermissionType.Module).ToList();

            List<int> branchIDList = new List<int>();
            foreach (ADDataViewPermissionsInfo dataViewPermissionsInfo in CurrentModuleDataViewPermissionList)
            {
                branchIDList.Add(dataViewPermissionsInfo.FK_BRBranchID);
            }

            if (branchIDList.Count == 0)
            {
                BranchList = new List<BRBranchsInfo>();
            }
            else
            {
                BRBranchsController objBranchsController = new BRBranchsController();
                List<BRBranchsInfo> branchList = objBranchsController.GetAllBranches();

                BranchList = branchList.Where(i => branchIDList.IndexOf(i.BRBranchID) > -1).ToList();
            }
        }

        #region Invalidate Toolbar
        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            LeaveApplicationEntities entity = (LeaveApplicationEntities)CurrentModuleEntity;
            HRRequestLeaveDaysInfo objHRRequestLeaveDaysInfo = (HRRequestLeaveDaysInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton("Approve", false);
            if (objHRRequestLeaveDaysInfo.HRRequestLeaveDayID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton("Approve", true);
                if (objHRRequestLeaveDaysInfo.HRRequestLeaveDayStatus == LeaveApplicationStatus.Approve.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                }
            }
        }
        #endregion 

        public override int ActionSave()
        {
            LeaveApplicationEntities entity = (LeaveApplicationEntities)CurrentModuleEntity;
            HRRequestLeaveDaysInfo obj = (HRRequestLeaveDaysInfo)entity.MainObject;
            DateTime d = obj.HRRequestLeaveDayFromHour;
            DateTime dto = obj.HRRequestLeaveDayToHour;
            obj.HRRequestLeaveDayFromDate =
                new DateTime(obj.HRRequestLeaveDayFromDate.Year, obj.HRRequestLeaveDayFromDate.Month, obj.HRRequestLeaveDayFromDate.Day, d.Hour, d.Minute, 0);
            obj.HRRequestLeaveDayToDate =
                new DateTime(obj.HRRequestLeaveDayToDate.Year, obj.HRRequestLeaveDayToDate.Month, obj.HRRequestLeaveDayToDate.Day, dto.Hour, dto.Minute, 0);
            if (obj.FK_HRTimeSheetParamID == 0)
            {
                MessageBox.Show("Vui lòng chọn loại nghỉ phép!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return base.ActionSave();
        }

        public override void ActionEdit()
        {
            if (!isInvalidate)
            {
                base.ActionEdit();
            }
        }

        public void Approve()
        {
            LeaveApplicationEntities entity = (LeaveApplicationEntities)CurrentModuleEntity;
            HRRequestLeaveDaysInfo objHRRequestLeaveDaysInfo = (HRRequestLeaveDaysInfo)CurrentModuleEntity.MainObject;
            ADUsersInfo objUsersInfo = BOSApp.CurrentUsersInfo;
            entity.SetPropertyChangeEventLock(false);
            if (objUsersInfo != null)
            {
                objHRRequestLeaveDaysInfo.FK_HRApproveEmployeeID = objUsersInfo.FK_HREmployeeID;
            }
            objHRRequestLeaveDaysInfo.HRRequestLeaveDayStatus = LeaveApplicationStatus.Approve.ToString();
            entity.GenerateLeaveDay(objHRRequestLeaveDaysInfo);
            entity.UpdateMainObject();
            InvalidateToolbar();
        }

        public bool isInvalidate = false;
        public override void Invalidate(int iObjectID)
        {
            isInvalidate = true;
            base.Invalidate(iObjectID);
            BOSTextBox t1 = (BOSTextBox)this.Controls["fld_txtHRRequestLeaveDayFromHour"];
            BOSTextBox t2 = (BOSTextBox)this.Controls["fld_txtHRRequestLeaveDayToHour"];
            LeaveApplicationEntities entity = (LeaveApplicationEntities)CurrentModuleEntity;
            HRRequestLeaveDaysInfo objOverTimesInfo = (HRRequestLeaveDaysInfo)entity.MainObject;
            t1.Text = objOverTimesInfo.HRRequestLeaveDayFromDate.ToString("HH:mm");
            t2.Text = objOverTimesInfo.HRRequestLeaveDayToDate.ToString("HH:mm");
            entity.LeaveApplicationList.Clear();
            entity.LeaveApplicationList.Add(objOverTimesInfo);
            entity.LeaveApplicationList.GridControl.RefreshDataSource();
            isInvalidate = false;
        }

        public override void ActionNew()
        {
            base.ActionNew();
            ((BOSTextBox)this.Controls["fld_txtHRRequestLeaveDayFromHour"]).Text = "00:00";
            ((BOSTextBox)this.Controls["fld_txtHRRequestLeaveDayToHour"]).Text = "00:00";
        }
    }
}
