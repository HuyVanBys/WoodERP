using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.RecruitmentNeed
{
    public class RecruitmentNeedModule : BaseTransactionModule
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
        public RecruitmentNeedModule()
        {
            Name = ModuleName.RecruitmentNeed;
            CurrentModuleEntity = new RecruitmentNeedEntities();
            CurrentModuleEntity.Module = this;
            GetCurrentModuleDataViewPermission();
            InitializeModule();
            SearchBranchLookupEditControl = (BOSLookupEdit)Controls[RecruitmentNeedModule.SearchBranchLookupEditControlName];
            SearchBranchLookupEditControl.Properties.DataSource = BranchList;
            DepartmentLookupEditControl = (BOSLookupEdit)Controls[RecruitmentNeedModule.DepartmentLookupEditControlName];
            DepartmentRoomLookupEditControl = (BOSLookupEdit)Controls[RecruitmentNeedModule.DepartmentRoomLookupEditControlName];
            StartGettingInventoryThread();
        }
        #endregion

        #region GetSearchData
        protected override DataSet GetSearchData(ref string searchQuery)
        {
            HRRecruitmentNeedsInfo searchObject = (HRRecruitmentNeedsInfo)CurrentModuleEntity.SearchObject;
            HRRecruitmentNeedsController objHRRecruitmentNeedsController = new HRRecruitmentNeedsController();

            DataSet ds = new DataSet();
            if (SearchBranchLookupEditControl.EditValue.ToString() == "" || SearchBranchLookupEditControl.EditValue.ToString() == "0")
            {
                if (BranchList.Count == 0)
                {
                    ds = objHRRecruitmentNeedsController.GetDataSetByID(-1);
                }
                else
                {
                    ds = objHRRecruitmentNeedsController.GetRecruitmentNeedListDatasetByListOfBranchID(
                                                                searchObject.HRRecruitmentNeedNo,
                                                                searchObject.HRRecruitmentNeedFromDate,
                                                                searchObject.HRRecruitmentNeedToDate,
                                                                BranchList);
                }
            }
            else
            {
                ds = objHRRecruitmentNeedsController.GetRecruitmentNeedListDataset(
                                                                searchObject.HRRecruitmentNeedNo,
                                                                searchObject.HRRecruitmentNeedFromDate,
                                                                searchObject.HRRecruitmentNeedToDate,
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
            RecruitmentNeedEntities entity = (RecruitmentNeedEntities)CurrentModuleEntity;
            HRRecruitmentNeedsInfo objRecruitmentNeedsInfo = (HRRecruitmentNeedsInfo)CurrentModuleEntity.MainObject;
            ParentScreen.SetEnableOfToolbarButton("Approve", false);
            ParentScreen.SetEnableOfToolbarButton("UnApprove", false);
            ParentScreen.SetEnableOfToolbarButton("NotApprove", false);
            if (objRecruitmentNeedsInfo.HRRecruitmentNeedID > 0)
            {
                ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, true);
                ParentScreen.SetEnableOfToolbarButton("Approve", true);
                ParentScreen.SetEnableOfToolbarButton("UnApprove", false);
                ParentScreen.SetEnableOfToolbarButton("NotApprove", true);
                if (objRecruitmentNeedsInfo.HRRecruitmentNeedStatus == RecruitmentNeedStatus.Approved.ToString())
                {
                    ParentScreen.SetEnableOfToolbarButton("Approve", false);
                    ParentScreen.SetEnableOfToolbarButton("UnApprove", true);
                    ParentScreen.SetEnableOfToolbarButton("NotApprove", false);
                    ParentScreen.SetEnableOfToolbarButton(BaseToolbar.ToolbarButtonEdit, false);
                }
                if (objRecruitmentNeedsInfo.HRRecruitmentNeedStatus == RecruitmentNeedStatus.NotApproved.ToString())
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
            RecruitmentNeedEntities entity = (RecruitmentNeedEntities)CurrentModuleEntity;
            HRRecruitmentNeedsInfo mainObject = (HRRecruitmentNeedsInfo)CurrentModuleEntity.MainObject;
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

        public void ApproveRecruitmentNeed()
        {
            RecruitmentNeedEntities entity = (RecruitmentNeedEntities)CurrentModuleEntity;
            entity.SetPropertyChangeEventLock(false);
            HRRecruitmentNeedsInfo objRecruitmentNeedsInfo = (HRRecruitmentNeedsInfo)CurrentModuleEntity.MainObject;
            objRecruitmentNeedsInfo.HRRecruitmentNeedStatus = RecruitmentNeedStatus.Approved.ToString();
            entity.UpdateMainObject();
            InvalidateToolbar();
        }
        public void UnApprove()
        {
            RecruitmentNeedEntities entity = (RecruitmentNeedEntities)CurrentModuleEntity;
            HRRecruitmentNeedsInfo objRecruitmentNeedsInfo = (HRRecruitmentNeedsInfo)CurrentModuleEntity.MainObject;
            entity.SetPropertyChangeEventLock(false);
            objRecruitmentNeedsInfo.HRRecruitmentNeedStatus = TimeSheetStatus.New.ToString();
            entity.UpdateMainObject();
            InvalidateToolbar();
        }
        #endregion

        public void DeleteItemFromRecruitmentNeedItemsList()
        {
            RecruitmentNeedEntities entity = (RecruitmentNeedEntities)CurrentModuleEntity;
            entity.RecruitmentNeedItemsList.RemoveSelectedRowObjectFromList();
        }

        public void NotApproveRecruitmentNeed()
        {
            RecruitmentNeedEntities entity = (RecruitmentNeedEntities)CurrentModuleEntity;
            HRRecruitmentNeedsInfo objRecruitmentNeedsInfo = (HRRecruitmentNeedsInfo)CurrentModuleEntity.MainObject;
            if (objRecruitmentNeedsInfo == null)
                return;

            entity.SetPropertyChangeEventLock(false);
            objRecruitmentNeedsInfo.HRRecruitmentNeedStatus = RecruitmentNeedStatus.NotApproved.ToString();
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