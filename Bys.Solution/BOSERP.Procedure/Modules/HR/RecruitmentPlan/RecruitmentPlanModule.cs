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

namespace BOSERP.Modules.RecruitmentPlan
{
    public class RecruitmentPlanModule : BaseTransactionModule
    {
        #region Constant
        public const string SearchBranchLookupEditControlName = "fld_lkeSearchFK_BRBranchID";
        public const string DepartmentLookupEditControlName = "fld_lkeFK_HRDepartmentID";
        public const string DepartmentRoomLookupEditControlName = "fld_lkeFK_HRDepartmentRoomID";
        #endregion

        #region Public properties
        public BOSLookupEdit SearchBranchLookupEditControl;
        public List<ADDataViewPermissionsInfo> CurrentModuleDataViewPermissionList;
        public List<BRBranchsInfo> BranchList;
        public BOSLookupEdit DepartmentLookupEditControl;
        public BOSLookupEdit DepartmentRoomLookupEditControl;
        #endregion

        #region Constructor
        public RecruitmentPlanModule()
        {
            Name = ModuleName.RecruitmentPlan;
            CurrentModuleEntity = new RecruitmentPlanEntities();
            CurrentModuleEntity.Module = this;
            GetCurrentModuleDataViewPermission();

            InitializeModule();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[RecruitmentPlanModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            DepartmentLookupEditControl = (BOSLookupEdit)Controls[RecruitmentPlanModule.DepartmentLookupEditControlName];
            DepartmentRoomLookupEditControl = (BOSLookupEdit)Controls[RecruitmentPlanModule.DepartmentRoomLookupEditControlName];
            StartGettingInventoryThread();
        }
        #endregion

        #region GetSearchData
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            HRRecruitmentPlansInfo searchObject = (HRRecruitmentPlansInfo)CurrentModuleEntity.SearchObject;
            HRRecruitmentPlansController objHRRecruitmentPlansController = new HRRecruitmentPlansController();

            DataSet ds = new DataSet();
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objHRRecruitmentPlansController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objHRRecruitmentPlansController.GetRecruitmentPlanListDatasetByListOfBranchID(
                                                                searchObject.HRRecruitmentPlanNo,
                                                                searchObject.HRRecruitmentPlanFromDate,
                                                                searchObject.HRRecruitmentPlanToDate,
                                                                BranchList);
                }
            }
            else
            {
                ds = objHRRecruitmentPlansController.GetRecruitmentPlanListDataset(
                                                                searchObject.HRRecruitmentPlanNo,
                                                                searchObject.HRRecruitmentPlanFromDate,
                                                                searchObject.HRRecruitmentPlanToDate,
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
        #endregion

        #region Invalidate Toolbar
        public override void InvalidateToolbar()
        {
            base.InvalidateToolbar();
            RecruitmentPlanEntities entity = (RecruitmentPlanEntities)CurrentModuleEntity;
            HRRecruitmentPlansInfo objRecruitmentPlansInfo = (HRRecruitmentPlansInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton("Approve", false);
            ParentScreen.SetEnableOfToolbarButton("UnApprove", false);
            ParentScreen.SetEnableOfToolbarButton("NotApprove", false);
            if (objRecruitmentPlansInfo.HRRecruitmentPlanID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton("Approve", true);
                ParentScreen.SetEnableOfToolbarButton("UnApprove", false);
                ParentScreen.SetEnableOfToolbarButton("NotApprove", true);
                if (objRecruitmentPlansInfo.HRRecruitmentPlanStatus == RecruitmentPlanStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton("UnApprove", true);
                    ParentScreen.SetEnableOfToolbarButton("NotApprove", false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                }
                else if (objRecruitmentPlansInfo.HRRecruitmentPlanStatus == RecruitmentPlanStatus.NotApproved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton("UnApprove", false);
                    ParentScreen.SetEnableOfToolbarButton("NotApprove", false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                }
            }
        }
        #endregion 

        #region ActionSave, Approve
        public override int ActionSave()
        {
            RecruitmentPlanEntities entity = (RecruitmentPlanEntities)CurrentModuleEntity;
            HRRecruitmentPlansInfo mainObject = (HRRecruitmentPlansInfo)CurrentModuleEntity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            if (mainObject.FK_BRBranchID <= 0)
            {
                MessageBox.Show("Vui lòng chọn chi nhánh!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            if (mainObject.FK_HRDepartmentID <= 0)
            {
                MessageBox.Show("Vui lòng chọn phòng ban!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            if (mainObject.FK_HRDepartmentRoomID <= 0)
            {
                MessageBox.Show("Vui lòng chọn bộ phận!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            return base.ActionSave();
        }

        public void ApproveRecruitmentPlan()
        {
            RecruitmentPlanEntities entity = (RecruitmentPlanEntities)CurrentModuleEntity;
            entity.SetPropertyChangeEventLock(false);
            HRRecruitmentPlansInfo objRecruitmentPlansInfo = (HRRecruitmentPlansInfo)CurrentModuleEntity.MainObject;
            objRecruitmentPlansInfo.HRRecruitmentPlanStatus = RecruitmentPlanStatus.Approved.ToString();
            entity.UpdateMainObject();
            InvalidateToolbar();
        }
        public void UnApprove()
        {
            RecruitmentPlanEntities entity = (RecruitmentPlanEntities)CurrentModuleEntity;
            HRRecruitmentPlansInfo objRecruitmentPlansInfo = (HRRecruitmentPlansInfo)CurrentModuleEntity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            objRecruitmentPlansInfo.HRRecruitmentPlanStatus = TimeSheetStatus.New.ToString();
            entity.UpdateMainObject();
            InvalidateToolbar();
        }
        #endregion

        public void DeleteItemFromRecruitmentPlanItemsList()
        {
            RecruitmentPlanEntities entity = (RecruitmentPlanEntities)CurrentModuleEntity;
            entity.RecruitmentPlanItemsList.RemoveSelectedRowObjectFromList();
        }

        public void ActionNewFromRecruitmentNeed()
        {
            try
            {
                base.ActionNew();
                RecruitmentPlanEntities entity = (RecruitmentPlanEntities)CurrentModuleEntity;
                HRRecruitmentPlansInfo objRecruitmentPlansInfo = (HRRecruitmentPlansInfo)entity.MainObject;

                HRRecruitmentNeedsController objRecruitmentNeedsController = new HRRecruitmentNeedsController();
                HRRecruitmentNeedItemsController objRecruitmentNeedItemsController = new HRRecruitmentNeedItemsController();
                List<HRRecruitmentNeedItemsInfo> recruitmentNeedsList = (List<HRRecruitmentNeedItemsInfo>)objRecruitmentNeedItemsController.GetRecruitmentNeedItemsForRecruitmentPlan();

                guiFind<HRRecruitmentNeedItemsInfo> guiFind = new guiFind<HRRecruitmentNeedItemsInfo>(TableName.HRRecruitmentNeedItemsTableName, recruitmentNeedsList, this,
                                                                                                true, true, new[] { "HRRecruitmentNeedNo" });
                guiFind.Module = this;
                guiFind.ShowDialog();
                if (guiFind.DialogResult != DialogResult.OK)
                {
                    base.ActionCancel();
                }

                IList<HRRecruitmentNeedItemsInfo> results = guiFind.SelectedObjects;
                if (results.Count == 0)
                    return;

                HRRecruitmentNeedsInfo objRecruitmentNeedsInfo = (HRRecruitmentNeedsInfo)objRecruitmentNeedsController.GetObjectByID(results.FirstOrDefault().FK_HRRecruitmentNeedID);
                objRecruitmentPlansInfo.HRRecruitmentPlanDate = BOSApp.GetCurrentServerDate();
                if (objRecruitmentNeedsInfo != null)
                {
                    objRecruitmentPlansInfo.FK_HRDepartmentID = objRecruitmentNeedsInfo.FK_HRDepartmentID;
                    objRecruitmentPlansInfo.FK_HRDepartmentRoomID = objRecruitmentNeedsInfo.FK_HRDepartmentRoomID;
                }

                foreach (HRRecruitmentNeedItemsInfo item in results)
                {
                    entity.GenerateRecruitmentNeedItem(item);
                }
                entity.UpdateMainObjectBindingSource();
                entity.RecruitmentPlanItemsList.GridControl.RefreshDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi, vui lòng thử lại", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void NotApproveRecruitmentPlan()
        {
            RecruitmentPlanEntities entity = (RecruitmentPlanEntities)CurrentModuleEntity;
            HRRecruitmentPlansInfo objRecruitmentPlansInfo = (HRRecruitmentPlansInfo)CurrentModuleEntity.MainObject;
            if (objRecruitmentPlansInfo == null)
                return;

            entity.SetPropertyChangeEventLock(false);
            objRecruitmentPlansInfo.HRRecruitmentPlanStatus = RecruitmentPlanStatus.NotApproved.ToString();
            entity.UpdateMainObject();
            InvalidateToolbar();
        }

        public void ChangeBranch(int branchID)
        {
            HRDepartmentsController objDepartmentsController = new HRDepartmentsController();
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            List<HRDepartmentsInfo> departmentList = objDepartmentsController.GetListByFK_BRBranchID(branchID);
            List<HRDepartmentRoomsInfo> departmentRoomList = objDepartmentRoomsController.GetRoomListByBranchID(branchID);
            DepartmentLookupEditControl.Properties.DataSource = departmentList;
            DepartmentLookupEditControl.EditValue = 0;
            DepartmentRoomLookupEditControl.Properties.DataSource = departmentRoomList;
            DepartmentRoomLookupEditControl.EditValue = 0;
        }

        public void ChangeDepartment(int departmentID)
        {
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            List<HRDepartmentRoomsInfo> departmentRoomList = objDepartmentRoomsController.GetRoomList(departmentID);
            DepartmentRoomLookupEditControl.Properties.DataSource = departmentRoomList;
            DepartmentRoomLookupEditControl.EditValue = 0;
        }
    }
}