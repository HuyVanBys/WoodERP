using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.UserManagement
{
    public class UserManagementModule : BaseModuleERP
    {
        //NUThao [ADD] [08/04/2014] [DB centre] [Permission configuration], START
        #region Private Variable
        private bool moduleStart = false;
        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
        //public DataTable tableResult = new DataTable();
        public DataTable tblModules = new DataTable();
        public DataTable tblReports = new DataTable();
        public DataTable tblAppStaffs = new DataTable();
        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
        private guiListUsers guiListUsers;
        //private guiUserManagement_AppStaff guiUserManagement_AppStaffs;
        private List<ADDataViewPermissionsInfo> originalDataViewPermissionList;
        private List<ADDataViewPermissionAppStaffsInfo> originalDataViewPermissionAppStaffsList;
        BandedGridView _View;
        GridBand[] _Bands;
        #endregion

        #region Public variables
        public string Add = "Add";
        public string Delete = "Delete";
        #endregion Public variables
        //NUThao [ADD] [08/04/2014] [DB centre] [Permission configuration], END

        #region Private Variable       
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the current user group
        /// </summary>
        public ADUserGroupsInfo CurrentUserGroup { get; set; }

        /// <summary>
        /// Gets or sets the current module
        /// </summary>
        public STModulesInfo CurrentModule { get; set; }

        /// <summary>
        /// Gets or sets the current screen
        /// </summary>
        public BOSERPScreen CurrentScreen { get; set; }
        public HREmployeeGroupAppStaffsInfo EmployeeGroupAppStaffsCurrent { get; set; }
        #endregion

        public UserManagementModule()
        {
            Name = BaseModuleERP.cstUserManagementModule;
            CurrentModuleEntity = new UserManagementEntities();
            CurrentModuleEntity.Module = this;
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            originalDataViewPermissionList = new List<ADDataViewPermissionsInfo>();
            originalDataViewPermissionAppStaffsList = new List<ADDataViewPermissionAppStaffsInfo>();
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            InitializeModule();
        }

        public override void InitializeScreens()
        {
            guiUserManagement _guiUserManagement = new guiUserManagement();
            _guiUserManagement.ScreenNumber = "DMUM100";
            _guiUserManagement.Module = this;
            Screens.Add(_guiUserManagement);
            InitializeTreeList(_guiUserManagement.fld_trlstUserGroup);
            _guiUserManagement.AddControlsToParentScreen();

            guiListUsers = new guiListUsers();
            guiListUsers.ScreenNumber = "DMUM101";
            guiListUsers.Module = this;
            Screens.Add(guiListUsers);
            guiListUsers.InitializeScreen();
            guiListUsers.AddControlsToParentScreen();

            //guiUserManagement_CRM _guiUserManagement_CRM = new guiUserManagement_CRM();
            //_guiUserManagement_CRM.ScreenNumber = "DMUM102";
            //_guiUserManagement_CRM.Module = this;
            //Screens.Add(_guiUserManagement_CRM);
            //InitializeTreeList_CRM(_guiUserManagement_CRM.fld_trlstUserGroup_CRM);
            //_guiUserManagement_CRM.AddControlsToParentScreen();

            //guiUserManagement_AppStaffs = new guiUserManagement_AppStaff();
            //guiUserManagement_AppStaffs.ScreenNumber = "DMUM103";
            //guiUserManagement_AppStaffs.Module = this;
            //Screens.Add(guiUserManagement_AppStaffs);
            //guiUserManagement_AppStaffs.InitializeScreen();
            //InitializeTreeList_AppStaff(guiUserManagement_AppStaffs.fld_trlstUserGroup_AppStaff);
            //guiUserManagement_AppStaffs.AddControlsToParentScreen();

            //guiUserManagement_OrderWeb _guiUserManagement_OrderWeb = new guiUserManagement_OrderWeb();
            //_guiUserManagement_OrderWeb.ScreenNumber = "DMUM104";
            //_guiUserManagement_OrderWeb.Module = this;
            //Screens.Add(_guiUserManagement_OrderWeb);
            //_guiUserManagement_OrderWeb.InitializeScreen();
            //InitializeTreeList_OrderWeb(_guiUserManagement_OrderWeb.fld_trlstUserGroup_OrderWeb);
            //_guiUserManagement_OrderWeb.AddControlsToParentScreen();

            InvalidateUserList();
        }

        #region initialze treelist
        public void InitializeTreeList_CRM(TreeList fld_trlstUserGroup_CRM)
        {
            List<HRGroupsInfo> lstNode = new List<HRGroupsInfo>();
            TreeListNode prevFocusedNode = fld_trlstUserGroup_CRM.FocusedNode;
            fld_trlstUserGroup_CRM.Nodes.Clear();
            HRGroupsController objHRGroupsController = new HRGroupsController();
            DataSet dsHRGroups = objHRGroupsController.GetAllObjects();
            if (dsHRGroups != null)
            {
                foreach (DataRow row in dsHRGroups.Tables[0].Rows)
                {
                    HRGroupsInfo objHRGroupsInfo = (HRGroupsInfo)objHRGroupsController.GetObjectFromDataRow(row);
                    if (objHRGroupsInfo != null)
                    {
                        lstNode.Add(objHRGroupsInfo);
                    }
                }
            }
            CreateTreeView_CRM(fld_trlstUserGroup_CRM, lstNode, null);
            if (prevFocusedNode != null)
            {
                TreeListNode currentFocusedNode = fld_trlstUserGroup_CRM.FindNodeByID(prevFocusedNode.Id);
                while (currentFocusedNode != null)
                {
                    if (currentFocusedNode.Level > 0)
                    {
                        currentFocusedNode.ExpandAll();
                    }
                    else
                    {
                        currentFocusedNode.Expanded = true;
                    }
                    currentFocusedNode = currentFocusedNode.ParentNode;
                }
            }
        }
        private void CreateTreeView_CRM(TreeList fld_trlstUserGroup_CRM, List<HRGroupsInfo> lstNodeName, DevExpress.XtraTreeList.Nodes.TreeListNode ParentNode)
        {
            fld_trlstUserGroup_CRM.BeginUnboundLoad();
            TreeListNode treeListNode;
            treeListNode = fld_trlstUserGroup_CRM.AppendNode(new object[] { UserManagementLocalizedResources.UserGroup, 0 }, ParentNode);
            for (int i = 0; i < lstNodeName.Count; i++)
            {
                treeListNode = fld_trlstUserGroup_CRM.AppendNode(new object[] { lstNodeName[i].HRGroupName, 1 }, 0);
                treeListNode.Tag = lstNodeName[i].HRGroupID;
                treeListNode.HasChildren = HasChild_CRM(lstNodeName[i].HRGroupID);

                if (treeListNode.HasChildren)
                {
                    HREmployeeGroupsController objEmployeeGroupsController = new HREmployeeGroupsController();
                    DataSet dsEmplyeeGroupChild = objEmployeeGroupsController.GetHREmployeeByHRGroupID(lstNodeName[i].HRGroupID);
                    if (dsEmplyeeGroupChild != null)
                    {
                        foreach (DataRow row in dsEmplyeeGroupChild.Tables[0].Rows)
                        {
                            HREmployeeGroupsInfo objHREmployeeGroupsInfo = (HREmployeeGroupsInfo)objEmployeeGroupsController.GetObjectFromDataRow(row);
                            if (objHREmployeeGroupsInfo != null)
                            {
                                HREmployeesInfo objEmployee = (HREmployeesInfo)new HREmployeesController().GetObjectByID(objHREmployeeGroupsInfo.FK_HREmployeeID);
                                TreeListNode treeListChildNode = fld_trlstUserGroup_CRM.AppendNode(new object[] { objEmployee.HREmployeeName, treeListNode.Level + 1 }, treeListNode);
                                treeListChildNode.Tag = objHREmployeeGroupsInfo.HREmployeeGroupID;
                            }
                        }
                    }

                }
            }
            fld_trlstUserGroup_CRM.EndUnboundLoad();
        }

        public void InitializeTreeList(TreeList fld_trlstUserGroup)
        {
            List<ADUserGroupsInfo> lstNode = new List<ADUserGroupsInfo>();
            TreeListNode prevFocusedNode = fld_trlstUserGroup.FocusedNode;
            fld_trlstUserGroup.Nodes.Clear();
            ADUserGroupsController objADUserGroupsController = new ADUserGroupsController();
            DataSet dsADUserGroups = objADUserGroupsController.GetAllObjects();
            if (dsADUserGroups != null)
            {
                foreach (DataRow row in dsADUserGroups.Tables[0].Rows)
                {
                    ADUserGroupsInfo objADUserGroupsInfo = (ADUserGroupsInfo)objADUserGroupsController.GetObjectFromDataRow(row);
                    if (objADUserGroupsInfo != null)
                    {
                        lstNode.Add(objADUserGroupsInfo);
                    }
                }
            }
            CreateTreeView(fld_trlstUserGroup, lstNode, null);
            if (prevFocusedNode != null)
            {
                TreeListNode currentFocusedNode = fld_trlstUserGroup.FindNodeByID(prevFocusedNode.Id);
                while (currentFocusedNode != null)
                {
                    if (currentFocusedNode.Level > 0)
                    {
                        currentFocusedNode.ExpandAll();
                    }
                    else
                    {
                        currentFocusedNode.Expanded = true;
                    }
                    currentFocusedNode = currentFocusedNode.ParentNode;
                }
            }
            dsADUserGroups.Dispose();
        }

        private void CreateTreeView(TreeList fld_trlstUserGroup, List<ADUserGroupsInfo> lstNodeName, DevExpress.XtraTreeList.Nodes.TreeListNode ParentNode)
        {
            fld_trlstUserGroup.BeginUnboundLoad();
            TreeListNode treeListNode;
            treeListNode = fld_trlstUserGroup.AppendNode(new object[] { UserManagementLocalizedResources.UserGroup, 0 }, ParentNode);
            STModuleToUserGroupSectionsController objModuleToUserGroupSectionsController = new STModuleToUserGroupSectionsController();
            List<STModuleToUserGroupSectionsInfo> ModuleToUserGroupSectionList = objModuleToUserGroupSectionsController.GetAllDataByModules();
            if (ModuleToUserGroupSectionList == null)
                ModuleToUserGroupSectionList = new List<STModuleToUserGroupSectionsInfo>();
            for (int i = 0; i < lstNodeName.Count; i++)
            {
                treeListNode = fld_trlstUserGroup.AppendNode(new object[] { lstNodeName[i].ADUserGroupName, 1 }, 0);
                treeListNode.Tag = lstNodeName[i].ADUserGroupID;
                treeListNode.HasChildren = HasChild(lstNodeName[i].ADUserGroupID);

                if (treeListNode.HasChildren)
                {
                    ADUserGroupSectionsController objUserGroupSectionsController = new ADUserGroupSectionsController();
                    DataSet dsUserGroupChild = objUserGroupSectionsController.GetUserGroupSectionByUserGroupID(lstNodeName[i].ADUserGroupID);
                    if (dsUserGroupChild != null)
                    {
                        foreach (DataRow row in dsUserGroupChild.Tables[0].Rows)
                        {
                            ADUserGroupSectionsInfo objADUserGroupSectionsInfo = (ADUserGroupSectionsInfo)objUserGroupSectionsController.GetObjectFromDataRow(row);
                            if (objADUserGroupSectionsInfo != null)
                            {
                                TreeListNode treeListChildNode = fld_trlstUserGroup.AppendNode(new object[] { objADUserGroupSectionsInfo.ADUserGroupSectionName, treeListNode.Level + 1 }, treeListNode);
                                treeListChildNode.Tag = objADUserGroupSectionsInfo.ADUserGroupSectionID;
                                AddModuleNode(fld_trlstUserGroup, objADUserGroupSectionsInfo.ADUserGroupSectionID, treeListChildNode, ModuleToUserGroupSectionList);
                            }
                        }
                    }
                    dsUserGroupChild.Dispose();

                }
            }
            fld_trlstUserGroup.EndUnboundLoad();
        }
        private void AddModuleNode(TreeList fld_trlstUserGroup, int iUserGroupSectionID, TreeListNode parentNode, List<STModuleToUserGroupSectionsInfo> ModuleToUserGroupSectionList)
        {
            STModuleToUserGroupSectionsController objSTModuleToUserGroupSectionsController = new STModuleToUserGroupSectionsController();
            List<STModuleToUserGroupSectionsInfo> dsModuleUserGroupSections = ModuleToUserGroupSectionList.Where(x => x.STUserGroupSectionID == iUserGroupSectionID).ToList();
            if (dsModuleUserGroupSections != null)
            {
                foreach (STModuleToUserGroupSectionsInfo objSTModuleToUserGroupSectionsInfo in dsModuleUserGroupSections)
                {
                    if (objSTModuleToUserGroupSectionsInfo != null)
                    {
                        STModulesInfo objSTModulesInfo = BOSApp.ModuleList.FirstOrDefault(x => x.STModuleID == objSTModuleToUserGroupSectionsInfo.STModuleID);
                        if (objSTModulesInfo != null)
                        {
                            STModuleDescriptionsInfo objModuleDescriptionsInfo = BOSApp.ModuleDescriptionList.Where(x => x.STModuleName != null && x.STModuleName.ToLower().Trim() == objSTModulesInfo.STModuleName.ToLower().Trim() && x.GELanguageName.ToLower().Trim() == BOSApp.CurrentLang.ToLower().Trim()).ToList().FirstOrDefault();
                            if (objModuleDescriptionsInfo != null)
                            {
                                objSTModulesInfo.STModuleDescription = objModuleDescriptionsInfo.STModuleDescriptionDescription;
                            }
                            TreeListNode treeListModuleNode = fld_trlstUserGroup.AppendNode(new object[] { objSTModulesInfo.STModuleDescription, parentNode.Level + 1 }, parentNode);
                            treeListModuleNode.Tag = objSTModulesInfo.STModuleID;
                        }
                    }
                }
            }
        }
        public bool HasChild(int iUserGroupID)
        {
            DataSet ds = new ADUserGroupSectionsController().GetAllDataByForeignColumn("ADUserGroupID", iUserGroupID);
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ds.Dispose();
                    return true;
                }
            }
            return false;
        }

        public bool HasChild_CRM(int iGroupID)
        {
            DataSet ds = new HREmployeeGroupsController().GetAllDataByForeignColumn("FK_HRGroupID", iGroupID);
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                    return true;
            }
            return false;
        }

        #endregion

        #region User
        public void AddUser()
        {
            UserManagementEntities entity = (UserManagementEntities)CurrentModuleEntity;
            entity.SetDefaultModuleObject(TableName.ADUsersTableName);
            guiManageUser _guiManageUser = new guiManageUser();
            _guiManageUser.Module = this;
            if (_guiManageUser.ShowDialog() == DialogResult.OK)
            {
                entity.SaveUser();
            }
            InvalidateUserList();
        }

        public void EditUser()
        {
            UserManagementEntities entity = (UserManagementEntities)CurrentModuleEntity;
            if (entity.ADUserList.CurrentIndex >= 0)
            {
                guiManageUser _guiManageUser = new guiManageUser();
                _guiManageUser.Module = this;
                ADUsersInfo objUsersInfo = (ADUsersInfo)entity.ModuleObjects[TableName.ADUsersTableName];
                objUsersInfo.ADPassword = string.Empty;
                entity.UpdateModuleObjectBindingSource(TableName.ADUsersTableName);
                if (_guiManageUser.ShowDialog() == DialogResult.OK)
                {
                    entity.SaveUser();
                    InvalidateUserList();
                }
            }
        }

        public void DeleteUser()
        {
            UserManagementEntities entity = (UserManagementEntities)CurrentModuleEntity;
            if (entity.ADUserList.CurrentIndex >= 0)
            {
                if (MessageBox.Show(UserManagementLocalizedResources.ConfirmDeleteUserMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    ADUsersInfo objUsersInfo = entity.ADUserList[entity.ADUserList.CurrentIndex];
                    entity.DeleteUser(objUsersInfo.ADUserID);
                    InvalidateUserList();
                }
            }
        }

        /// <summary>
        /// Invalidate user list
        /// </summary>
        public void InvalidateUserList()
        {
            UserManagementEntities entity = (UserManagementEntities)CurrentModuleEntity;
            ADUsersController objUsersController = new ADUsersController();
            DataSet ds = objUsersController.GetAllObjects();
            entity.ADUserList.Invalidate(ds);
            ds.Dispose();
        }
        #endregion

        #region Field permission
        /// <summary>
        /// Save field permission
        /// </summary>
        /// <param name="treeListNode"></param>
        public void SaveFieldPermission(TreeListNode treeListNode)
        {
            UserManagementEntities entity = (UserManagementEntities)CurrentModuleEntity;
            if (treeListNode.Level == 3)
            {
                TreeListNode userGroupNode = treeListNode.ParentNode.ParentNode;
                ADUserGroupsController objUserGroupsController = new ADUserGroupsController();
                int userGroupID = Convert.ToInt32(userGroupNode.Tag);
                STModulesController objSTModulesController = new STModulesController();
                int moduleID = Convert.ToInt32(treeListNode.Tag);
                string moduleName = objSTModulesController.GetObjectNameByID(moduleID);

                STFieldPermissionsController objFieldPermissionsController = new STFieldPermissionsController();
                guiConfigureToolbar guiConfigToolbar = new guiConfigureToolbar();
                entity.STToolbarsTreeList.InvalidateTreeList(moduleID, true);
                entity.STToolbarsTreeList.ForEach(o => o.Selected = false);
                List<STFieldPermissionsInfo> fieldPermissions = objFieldPermissionsController.GetFieldPermissionList(userGroupID, moduleName, null, null, null);
                foreach (STFieldPermissionsInfo objFieldPermissionsInfo in fieldPermissions)
                {
                    STToolbarsInfo objToolbarsInfo = (STToolbarsInfo)entity.STToolbarsTreeList.GetObjectByPropertyNameAndValue("STToolbarName", objFieldPermissionsInfo.STToolbarName);
                    if (objToolbarsInfo != null)
                    {
                        if (objFieldPermissionsInfo.STFieldPermissionType.Equals((int)FieldPermissionType.None))
                        {
                            objToolbarsInfo.Selected = true;
                        }
                        else
                        {
                            objToolbarsInfo.Selected = false;
                        }
                    }
                }
                guiConfigToolbar.Module = this;
                guiConfigToolbar.InitializeControls();
                if (guiConfigToolbar.ShowDialog() == DialogResult.OK)
                {
                    entity.SaveFieldPermission(userGroupID, moduleName);
                    MessageBox.Show(UserManagementLocalizedResources.SaveSuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Show columns of a table to make permission
        /// </summary>
        /// <param name="tableName">Table name</param>
        public void ShowColumnPermission(string tableName)
        {
            UserManagementEntities entity = (UserManagementEntities)CurrentModuleEntity;
            guiColumnPermission columnPermissionForm = new guiColumnPermission(tableName);
            columnPermissionForm.Module = this;
            if (columnPermissionForm.ShowDialog() == DialogResult.OK)
            {
                entity.SaveColumnPermissionList(tableName, CurrentUserGroup.ADUserGroupID, CurrentModule.STModuleName);
                MessageBox.Show(UserManagementLocalizedResources.SaveSuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Invalidate column permission list of selected grid control
        /// </summary>
        /// <param name="tableName">Table name of selected grid control</param>
        public void InvalidateColumnPermissionList(string tableName)
        {
            UserManagementEntities entity = (UserManagementEntities)CurrentModuleEntity;
            STFieldColumnPermissionsController objFieldColumnPermissionsController = new STFieldColumnPermissionsController();
            DataSet ds = objFieldColumnPermissionsController.GetColumnPermissionByUserGroupIDAndModuleNameAndTableName(
                                                                                                        CurrentUserGroup.ADUserGroupID,
                                                                                                        CurrentModule.STModuleName,
                                                                                                        tableName);
            if (ds.Tables[0].Rows.Count > 0)
            {
                List<STFieldColumnPermissionsInfo> columnPermissionList = new List<STFieldColumnPermissionsInfo>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    STFieldColumnPermissionsInfo objFieldColumnPermissionsInfo =
                        (STFieldColumnPermissionsInfo)objFieldColumnPermissionsController.GetObjectFromDataRow(dr);
                    if (objFieldColumnPermissionsInfo.STFieldColumnPermissionType == Convert.ToByte(FieldPermissionType.Hided))
                        objFieldColumnPermissionsInfo.IsCheck = true;
                    columnPermissionList.Add(objFieldColumnPermissionsInfo);
                }
                entity.STFieldColumnPermissionList.Invalidate(columnPermissionList);
            }
            else
            {
                AAColumnAliasController objColumnAliasController = new AAColumnAliasController();
                ds = objColumnAliasController.GetColumnPermissionByTableName(tableName);
                entity.STFieldColumnPermissionList.Invalidate(ds);
            }
            ds.Dispose();
        }
        #endregion

        #region Report permission
        /// <summary>
        /// Invalidate report permission list of selected grid control
        /// </summary>
        public void InvalidateReportPermissionList()
        {
            UserManagementEntities entity = (UserManagementEntities)CurrentModuleEntity;
            ADReportPermissionsController objReportPermissionsController = new ADReportPermissionsController();
            DataSet ds = objReportPermissionsController.GetReportPermissionByUserGroupID(CurrentUserGroup.ADUserGroupID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                List<ADReportPermissionsInfo> reportPermissionList = new List<ADReportPermissionsInfo>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ADReportPermissionsInfo objReportPermissionsInfo = (ADReportPermissionsInfo)objReportPermissionsController.GetObjectFromDataRow(row);
                    if (objReportPermissionsInfo.ADReportPermissionType == Convert.ToByte(FieldPermissionType.None))
                        objReportPermissionsInfo.Selected = true;
                    reportPermissionList.Add(objReportPermissionsInfo);
                }
                entity.ReportPermissionsList.Invalidate(reportPermissionList);
            }
            ds.Dispose();
        }

        /// <summary>
        /// Save report permission
        /// </summary>
        public void SaveReportPermission()
        {
            UserManagementEntities entity = (UserManagementEntities)CurrentModuleEntity;
            entity.SaveReportPermission(CurrentUserGroup.ADUserGroupID);
            MessageBox.Show(UserManagementLocalizedResources.SaveSuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Called when user wants to choose all or discard all reports for permission
        /// </summary>
        /// <param name="isChecked">A value indicates whether the action is choosing all or discarding all</param>
        public void ChooseAllReports(bool isChecked)
        {
            UserManagementEntities entity = (UserManagementEntities)CurrentModuleEntity;
            entity.ReportPermissionsList.ForEach(ip => ip.Selected = isChecked);
            entity.ReportPermissionsList.GridControl.RefreshDataSource();
        }
        #endregion 

        //[NKVung]  [Group Time Sheet Permissions]  [START]
        #region Group Time Sheet Permissions
        /// <summary>
        /// Invalidate report permission list of selected grid control
        /// </summary>
        public void InvalidateGroupTimeSheetPermissionList()
        {
            UserManagementEntities entity = (UserManagementEntities)CurrentModuleEntity;
            ADGroupTimeSheetPermissionsController objGroupTimeSheetPermissionsController = new ADGroupTimeSheetPermissionsController();
            DataSet ds = objGroupTimeSheetPermissionsController.GetGroupTimeSheetPermissionByUserGroupID(CurrentUserGroup.ADUserGroupID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                List<ADGroupTimeSheetPermissionsInfo> groupTimeSheetPermissionList = new List<ADGroupTimeSheetPermissionsInfo>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ADGroupTimeSheetPermissionsInfo objGroupTimeSheetPermissionsInfo = (ADGroupTimeSheetPermissionsInfo)objGroupTimeSheetPermissionsController.GetObjectFromDataRow(row);
                    if (objGroupTimeSheetPermissionsInfo.ADGroupTimeSheetPermissionType == Convert.ToByte(FieldPermissionType.None))
                        objGroupTimeSheetPermissionsInfo.Selected = true;
                    groupTimeSheetPermissionList.Add(objGroupTimeSheetPermissionsInfo);
                }
                entity.GroupTimeSheetPermissionList.Invalidate(groupTimeSheetPermissionList);
            }
            ds.Dispose();
        }

        /// <summary>
        /// Save report permission
        /// </summary>
        public void SaveGroupTimeSheetPermission()
        {
            UserManagementEntities entity = (UserManagementEntities)CurrentModuleEntity;
            entity.SaveGroupTimeSheetPermission(CurrentUserGroup.ADUserGroupID);
            MessageBox.Show(UserManagementLocalizedResources.SaveSuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Called when user wants to choose all or discard all reports for permission
        /// </summary>
        /// <param name="isChecked">A value indicates whether the action is choosing all or discarding all</param>
        public void ChooseAllGroupTimeSheets(bool isChecked)
        {
            UserManagementEntities entity = (UserManagementEntities)CurrentModuleEntity;
            entity.GroupTimeSheetPermissionList.ForEach(ip => ip.Selected = isChecked);
            entity.GroupTimeSheetPermissionList.GridControl.RefreshDataSource();
        }
        #endregion 
        //[NKVung]  [Group Time Sheet Permissions]  [END]

        #region Inventory permission
        /// <summary>
        /// Invalidate Inventory permission list of selected grid control
        /// </summary>
        public void InvalidateInventoryPermissionList()
        {
            UserManagementEntities entity = (UserManagementEntities)CurrentModuleEntity;
            ICInventoryPermissionsController objInventoryPermissionsController = new ICInventoryPermissionsController();
            List<ICInventoryPermissionsInfo> invPermissions = objInventoryPermissionsController.GetInventoryPermissionByUserGroupID(CurrentUserGroup.ADUserGroupID);
            foreach (ICInventoryPermissionsInfo objInventoryPermissionsInfo in invPermissions)
            {
                if (objInventoryPermissionsInfo.ICInventoryPermissionType == Convert.ToByte(FieldPermissionType.None))
                {
                    objInventoryPermissionsInfo.Selected = true;
                }
            }
            entity.InventoryPermissionsList.Invalidate(invPermissions);
        }

        /// <summary>
        /// Save inventory permission
        /// </summary>
        public void SaveInventoryPermission()
        {
            UserManagementEntities entity = (UserManagementEntities)CurrentModuleEntity;
            entity.SaveInventoryPermission(CurrentUserGroup.ADUserGroupID);
            MessageBox.Show(UserManagementLocalizedResources.SaveSuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Called when user wants to choose all or discard all stocks for permission
        /// </summary>
        /// <param name="isChecked">A value indicates whether the action is choosing all or discarding all</param>
        public void ChooseAllStocks(bool isChecked)
        {
            UserManagementEntities entity = (UserManagementEntities)CurrentModuleEntity;
            entity.InventoryPermissionsList.ForEach(ip => ip.Selected = isChecked);
            entity.InventoryPermissionsList.GridControl.RefreshDataSource();
        }
        #endregion

        //NUThao [ADD] [08/04/2014] [DB centre] [Permission configuration], START
        #region Data view permission
        /// <summary>
        /// Create Banded Grid View
        /// </summary>
        /// <param name="gridView">GridView</param>
        /// <returns></returns>
        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
        //public BandedGridView InitBandedGridView(GridView gridView)
        public BandedGridView InitBandedGridView(GridView gridView, string dataViewPermissionType)
        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
        {
            GELocationsController objLocationsController = new GELocationsController();
            BRBranchsController objBranchsController = new BRBranchsController();
            //int locationID = 0;
            List<GELocationsInfo> locations = objLocationsController.GetLocationsHaveBranch();
            List<BRBranchsInfo> activebranches = objBranchsController.GetAllBranches();
            //if (locationID > 0)
            //    locations = locations.Where(p => p.GELocationID == locationID).ToList();

            BandedGridView bandedView = new BandedGridView();
            bandedView.GridControl = gridView.GridControl;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;

            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                bandedView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
                        ConvertToBandedGridColumn(gridView.Columns[i], false)});
            }

            GridBand[] gridBands = new GridBand[locations.Count + 1];

            GridBand itemGridBand = new GridBand();
            itemGridBand.Caption = "";
            itemGridBand.Name = "";

            BandedGridColumn bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = ADDataViewPermissionColumnNames.ADUserGroupSectionName;
            bandedUserGroupSectionColumn.Caption = UserManagementLocalizedResources.UserGroupSection;
            bandedUserGroupSectionColumn.FieldName = ADDataViewPermissionColumnNames.ADUserGroupSectionName;
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.OwnerBand = itemGridBand;
            bandedUserGroupSectionColumn.Width = 100;
            bandedView.Columns.Add(bandedUserGroupSectionColumn);


            BandedGridColumn bandedModuleNameColumn = new BandedGridColumn();
            bandedModuleNameColumn.Name = ADDataViewPermissionColumnNames.STModuleName;
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //bandedModuleNameColumn.Caption = UserManagementLocalizedResources.ModuleName;
            if (dataViewPermissionType == ADDataViewPermissionType.Module)
                bandedModuleNameColumn.Caption = UserManagementLocalizedResources.ModuleName;
            else
                bandedModuleNameColumn.Caption = UserManagementLocalizedResources.ReportName;
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            bandedModuleNameColumn.FieldName = ADDataViewPermissionColumnNames.STModuleName;
            bandedModuleNameColumn.Visible = true;
            bandedModuleNameColumn.OptionsColumn.AllowEdit = false;
            bandedModuleNameColumn.OwnerBand = itemGridBand;
            bandedModuleNameColumn.Width = 200;
            bandedView.Columns.Add(bandedModuleNameColumn);

            BandedGridColumn bandedColumn1 = new BandedGridColumn();
            bandedColumn1.Name = ADDataViewPermissionColumnNames.RowSelection;
            bandedColumn1.Caption = " ";
            bandedColumn1.FieldName = ADDataViewPermissionColumnNames.RowSelection;
            bandedColumn1.Visible = true;
            bandedColumn1.OptionsColumn.AllowEdit = true;
            RepositoryItemCheckEdit chk1 = new RepositoryItemCheckEdit();
            bandedColumn1.ColumnEdit = chk1;
            bandedColumn1.OwnerBand = itemGridBand;
            bandedView.Columns.Add(bandedColumn1);

            //itemGridBand.Children.Add(subItemGridBand);
            itemGridBand.Fixed = FixedStyle.Left;
            gridBands[0] = itemGridBand;

            for (int i = 0; i < locations.Count; i++)
            {
                GridBand itemGridBand1 = new GridBand();
                itemGridBand1.Caption = locations[i].GELocationName;
                itemGridBand1.Name = locations[i].GELocationID.ToString();
                itemGridBand1.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

                if (activebranches != null)
                {

                    List<BRBranchsInfo> branchs = activebranches.Where(p => p.FK_GELocationID == locations[i].GELocationID).ToList();

                    for (int j = 0; j < branchs.Count; j++)
                    {

                        BandedGridColumn bandedColumn2 = new BandedGridColumn();
                        bandedColumn2.Name = branchs[j].BRBranchID.ToString() + branchs[j].BRBranchName;
                        bandedColumn2.Caption = branchs[j].BRBranchName;
                        bandedColumn2.FieldName = branchs[j].BRBranchID.ToString() + branchs[j].BRBranchName;
                        bandedColumn2.Visible = true;
                        bandedColumn2.OptionsColumn.AllowEdit = true;
                        RepositoryItemCheckEdit chk2 = new RepositoryItemCheckEdit();
                        bandedColumn2.ColumnEdit = chk2;
                        bandedColumn2.OwnerBand = itemGridBand1;
                        bandedView.Columns.Add(bandedColumn2);

                    }
                }
                gridBands[i + 1] = itemGridBand1;
            }

            bandedView.Bands.AddRange(gridBands);

            //bandedView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            //        new DevExpress.XtraGrid.Columns.GridColumnSortInfo(bandedUserGroupSectionColumn, DevExpress.Data.ColumnSortOrder.Ascending)});
            //bandedUserGroupSectionColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;

            //bandedView.BeginSort();
            //try
            //{
            //    bandedView.ClearGrouping();

            //    bandedUserGroupSectionColumn.GroupIndex = 0;
            //}
            //finally
            //{
            //    bandedView.ExpandAllGroups();
            //    bandedView.EndSort();
            //}

            return bandedView;
        }

        /// <summary>
        /// Convert a column to a banded column one
        /// </summary>
        /// <param name="gridColumn">Column of GridView</param>
        /// <param name="isAllowEdit">A variable indicates whether the column is editable</param>
        /// <returns>Banded grid column</returns>
        public BandedGridColumn ConvertToBandedGridColumn(GridColumn gridColumn, bool isAllowEdit)
        {
            BandedGridColumn bandedColumn = new BandedGridColumn();
            bandedColumn.Name = gridColumn.Name;
            bandedColumn.FieldName = gridColumn.FieldName;
            bandedColumn.Caption = gridColumn.Caption;
            bandedColumn.OptionsColumn.AllowEdit = isAllowEdit;
            bandedColumn.Visible = true;
            bandedColumn.Width = gridColumn.Width;
            return bandedColumn;
        }

        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
        /// <summary>
        /// Init DataSource
        /// </summary>
        public void InitDataViewPermissionScreen()
        {
            if (!moduleStart)
            {
                UserManagementEntities entity = CurrentModuleEntity as UserManagementEntities;
                ADUsersInfo user = entity.ModuleObjects[TableName.ADUsersTableName] as ADUsersInfo;
                if (user != null)
                {
                    originalDataViewPermissionList.Clear();
                    PrepareDataForGrid(user.ADUserID, ADDataViewPermissionType.Module);
                    PrepareDataForGrid(user.ADUserID, ADDataViewPermissionType.Report);
                }
            }
        }
        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END

        /// <summary>
        /// Init DataSource
        /// </summary>
        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
        //public DataTable InitProductLocationBranchPricesDataSource()
        public DataTable InitProductLocationBranchPricesDataSource(string dataViewPermissionType)
        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
        {
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            DataTable dt = null;
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            if (!moduleStart)
            {
                UserManagementEntities entity = CurrentModuleEntity as UserManagementEntities;
                ADUsersInfo user = entity.ModuleObjects[TableName.ADUsersTableName] as ADUsersInfo;
                if (user != null)
                    //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                    //dt = PrepareDataForGrid(user.ADUserID);
                    dt = PrepareDataForGrid(user.ADUserID, dataViewPermissionType);
                //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            }
            moduleStart = false;
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //return tableResult;
            return dt;
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
        }

        /// <summary>
        /// Prepare data before apply for grid
        /// </summary>
        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
        //public void PrepareDataForGrid(int userID)
        public DataTable PrepareDataForGrid(int userID, string dataViewPermissionType)
        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
        {
            ADDataViewPermissionsController dataViewPermissionController = new ADDataViewPermissionsController();
            UserManagementEntities entity = CurrentModuleEntity as UserManagementEntities;

            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //tableResult = dataViewPermissionController.GetDataViewPermissions(userID, ADDataViewPermissionType.Module);
            //guiListUsers.RefreshDataVewPermissionGridControlDataSource(tableResult);

            ////store the original data view permission list
            //originalDataViewPermissionList = ConvertDataTableToListObject();

            DataTable dt;
            if (dataViewPermissionType == ADDataViewPermissionType.Module)
            {
                //module 
                tblModules = dataViewPermissionController.GetDataViewPermissions(userID, ADDataViewPermissionType.Module);
                guiListUsers.RefreshDataViewPermissionGridControlDataSource(tblModules);
                //store the original data view permission list
                List<ADDataViewPermissionsInfo> list = ConvertDataTableToListObject(tblModules, ADDataViewPermissionType.Module);
                if (list != null)
                    originalDataViewPermissionList.AddRange(list);

                dt = tblModules;
            }
            else
            {
                tblReports = dataViewPermissionController.GetDataViewPermissions(userID, ADDataViewPermissionType.Report);
                guiListUsers.RefreshReportViewPermissionGridControlDataSource(tblReports);
                //store the original data view permission list
                List<ADDataViewPermissionsInfo> list = ConvertDataTableToListObject(tblReports, ADDataViewPermissionType.Report);
                if (list != null)
                    originalDataViewPermissionList.AddRange(list);

                dt = tblReports;
            }

            return dt;
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
        }

        public void SaveDataViewPermissions()
        {
            UserManagementEntities entity = CurrentModuleEntity as UserManagementEntities;
            ADUsersInfo user = entity.ModuleObjects[TableName.ADUsersTableName] as ADUsersInfo;
            //NUThao [DELETE] [10/16/2014] [DB centre] [Report Permission], START
            //ADDataViewPermissionsController dataViewPermissionController = new ADDataViewPermissionsController();
            //NUThao [DELETE] [10/16/2014] [DB centre] [Report Permission], END

            if (user != null)
            {

                try
                {
                    //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                    //List<ADDataViewPermissionsInfo> currentList = ConvertDataTableToListObject();
                    //List<ADDataViewPermissionsInfo> newList = FilterChangedObjects(currentList, Add);
                    //List<ADDataViewPermissionsInfo> deletedList = FilterChangedObjects(currentList, Delete);
                    //ADDataViewPermissionsInfo originalDataViewPermission = null;
                    ////add new item list
                    //if (newList != null && newList.Count != 0)
                    //{
                    //    foreach (ADDataViewPermissionsInfo dataViewPermission in newList)
                    //    {
                    //        originalDataViewPermission = dataViewPermissionController.GetDataViewPermissionsByUserIDAndBranchIDAndSTModuleOrReportIDAndDataViewPermissionType(
                    //                                   dataViewPermission.FK_ADUserID, dataViewPermission.FK_BRBranchID, dataViewPermission.FK_STModuleOrReportID, "Module");
                    //        if (originalDataViewPermission == null)
                    //            dataViewPermissionController.CreateObject(dataViewPermission);
                    //    }
                    //}
                    ////delete 
                    //if (deletedList != null && deletedList.Count != 0)
                    //{
                    //    foreach (ADDataViewPermissionsInfo dataViewPermission in deletedList)
                    //    {
                    //        originalDataViewPermission = dataViewPermissionController.GetDataViewPermissionsByUserIDAndBranchIDAndSTModuleOrReportIDAndDataViewPermissionType(
                    //                                    dataViewPermission.FK_ADUserID, dataViewPermission.FK_BRBranchID, dataViewPermission.FK_STModuleOrReportID, "Module");
                    //        if (originalDataViewPermission != null)
                    //            dataViewPermissionController.DeleteObject(originalDataViewPermission.ADDataViewPermissionID);
                    //    }
                    //}

                    SaveDataViewPermision(tblModules, ADDataViewPermissionType.Module);
                    SaveDataViewPermision(tblReports, ADDataViewPermissionType.Report);
                    //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END

                    MessageBox.Show(UserManagementLocalizedResources.SaveSuccessfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(UserManagementLocalizedResources.SaveUnsuccessfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        public void SaveFieldPermissionDataAppStaff()
        {
            UserManagementEntities entity = CurrentModuleEntity as UserManagementEntities;
            ADUsersInfo user = entity.ModuleObjects[TableName.ADUsersTableName] as ADUsersInfo;
            if (user != null)
            {

                try
                {
                    SaveDataViewPermisionAppStaff(tblAppStaffs);
                    MessageBox.Show(UserManagementLocalizedResources.SaveSuccessfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(UserManagementLocalizedResources.SaveUnsuccessfullyMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
        private void SaveDataViewPermision(DataTable dt, string dataViewPermissionType)
        {
            List<ADDataViewPermissionsInfo> currentList;
            ADDataViewPermissionsController dataViewPermissionController = new ADDataViewPermissionsController();
            currentList = ConvertDataTableToListObject(dt, dataViewPermissionType);
            List<ADDataViewPermissionsInfo> newList = FilterChangedObjects(currentList, originalDataViewPermissionList, Add);
            List<ADDataViewPermissionsInfo> deletedList = FilterChangedObjects(currentList, originalDataViewPermissionList, Delete);
            List<ADDataViewPermissionsInfo> addedItems = new List<ADDataViewPermissionsInfo>();
            ADDataViewPermissionsInfo originalDataViewPermission = null;
            //add new item list
            if (newList != null && newList.Count != 0)
            {
                foreach (ADDataViewPermissionsInfo dataViewPermission in newList)
                {
                    originalDataViewPermission = dataViewPermissionController.GetDataViewPermissionsByUserIDAndBranchIDAndSTModuleOrReportIDAndDataViewPermissionType(
                                               dataViewPermission.FK_ADUserID, dataViewPermission.FK_BRBranchID, dataViewPermission.FK_STModuleOrReportID, dataViewPermissionType);
                    if (originalDataViewPermission == null)
                    {
                        dataViewPermissionController.CreateObject(dataViewPermission);
                        addedItems.Add(dataViewPermission);
                    }
                }
            }
            //delete 
            if (deletedList != null && deletedList.Count != 0)
            {
                foreach (ADDataViewPermissionsInfo dataViewPermission in deletedList)
                {
                    originalDataViewPermission = dataViewPermissionController.GetDataViewPermissionsByUserIDAndBranchIDAndSTModuleOrReportIDAndDataViewPermissionType(
                                                dataViewPermission.FK_ADUserID, dataViewPermission.FK_BRBranchID, dataViewPermission.FK_STModuleOrReportID, dataViewPermissionType);
                    if (originalDataViewPermission != null)
                        dataViewPermissionController.DeleteObject(originalDataViewPermission.ADDataViewPermissionID);
                }
            }

            //update original list
            MergeDataPermissionList(addedItems, originalDataViewPermissionList);
            MergeDataPermissionList(deletedList, originalDataViewPermissionList);
        }

        private void MergeDataPermissionList(List<ADDataViewPermissionsInfo> source, List<ADDataViewPermissionsInfo> des)
        {
            if (source != null && des != null)
            {
                foreach (ADDataViewPermissionsInfo item in source)
                {
                    ADDataViewPermissionsInfo foundItem = des.FirstOrDefault(i => i.FK_STModuleOrReportID == item.FK_STModuleOrReportID && i.ADDataViewPermissionType == item.ADDataViewPermissionType);
                    if (foundItem != null)
                        foundItem.ADUserGroupSectionChecked = item.ADUserGroupSectionChecked;
                }
            }
        }
        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END

        /// <summary>
        /// Convert data view permissions from a datatable to a list 
        /// </summary>
        /// <returns></returns>
        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
        //private List<ADDataViewPermissionsInfo> ConvertDataTableToListObject()
        private List<ADDataViewPermissionsInfo> ConvertDataTableToListObject(DataTable dt, string dataViewPermissionType)
        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
        {
            List<ADDataViewPermissionsInfo> list = new List<ADDataViewPermissionsInfo>();
            BRBranchsController branchController = new BRBranchsController();
            List<BRBranchsInfo> branches = branchController.GetAllBranches();

            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //if (tableResult != null && tableResult.Rows.Count != 0)
            //{
            //    for (int index = 1; index < tableResult.Rows.Count; index++)
            //    {
            //        DataRow row = tableResult.Rows[index];
            //        if (branches != null)
            //        {
            //            foreach (BRBranchsInfo branch in branches)
            //            {
            //                ADDataViewPermissionsInfo dataViewPermission = new ADDataViewPermissionsInfo();
            //                dataViewPermission.ADDataViewPermissionID = int.Parse(row[ADDataViewPermissionColumnNames.ADDataViewPermissionID].ToString());
            //                dataViewPermission.ADDataViewPermissionType = ADDataViewPermissionType.Module;
            //                dataViewPermission.FK_ADUserID = int.Parse(row[ADDataViewPermissionColumnNames.UserID].ToString());
            //                dataViewPermission.FK_BRBranchID = branch.BRBranchID;
            //                dataViewPermission.FK_STModuleOrReportID = int.Parse(row[ADDataViewPermissionColumnNames.FK_STModuleOrReportID].ToString());
            //                dataViewPermission.ADUserGroupSectionChecked = bool.Parse(row[branch.BRBranchID.ToString() + branch.BRBranchName].ToString());
            //                list.Add(dataViewPermission);
            //            }
            //        }
            //    }
            //}

            if (dt != null && dt.Rows.Count != 0)
            {
                for (int index = 1; index < dt.Rows.Count; index++)
                {
                    DataRow row = dt.Rows[index];
                    if (branches != null)
                    {
                        foreach (BRBranchsInfo branch in branches)
                        {
                            ADDataViewPermissionsInfo dataViewPermission = new ADDataViewPermissionsInfo();
                            dataViewPermission.ADDataViewPermissionID = int.Parse(row[ADDataViewPermissionColumnNames.ADDataViewPermissionID].ToString());
                            dataViewPermission.FK_ADUserID = int.Parse(row[ADDataViewPermissionColumnNames.UserID].ToString());
                            dataViewPermission.FK_BRBranchID = branch.BRBranchID;
                            dataViewPermission.FK_STModuleOrReportID = int.Parse(row[ADDataViewPermissionColumnNames.FK_STModuleOrReportID].ToString());
                            dataViewPermission.ADUserGroupSectionChecked = bool.Parse(row[branch.BRBranchID.ToString() + branch.BRBranchName].ToString());
                            dataViewPermission.ADDataViewPermissionType = dataViewPermissionType;
                            list.Add(dataViewPermission);
                        }
                    }
                }
            }
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            return list;
        }

        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
        //private List<ADDataViewPermissionsInfo> FilterChangedObjects(List<ADDataViewPermissionsInfo> currentList, string filteredType)
        private List<ADDataViewPermissionsInfo> FilterChangedObjects(List<ADDataViewPermissionsInfo> currentList, List<ADDataViewPermissionsInfo> originalList, string filteredType)
        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
        {
            List<ADDataViewPermissionsInfo> list = new List<ADDataViewPermissionsInfo>();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //if (currentList != null && originalDataViewPermissionList != null)
            //{
            //    if (filteredType == Add)
            //        list = currentList.Where(item => item.ADUserGroupSectionChecked == true &&
            //                                        originalDataViewPermissionList.Any(originalItem => originalItem.FK_BRBranchID == item.FK_BRBranchID
            //                                                                                        && originalItem.FK_STModuleOrReportID == item.FK_STModuleOrReportID
            //            //&& originalItem.ADUserGroupSectionChecked == false
            //                                                                            )
            //                                ).ToList();
            //    else if (filteredType == Delete)
            //    {
            //        list = currentList.Where(item => item.ADUserGroupSectionChecked == false &&
            //                                        originalDataViewPermissionList.Any(originalItem => originalItem.FK_BRBranchID == item.FK_BRBranchID
            //                                                                                        && originalItem.FK_STModuleOrReportID == item.FK_STModuleOrReportID
            //                                                                                        && originalItem.ADUserGroupSectionChecked == true
            //                                                                            )
            //                                ).ToList();

            if (currentList != null && originalList != null)
            {
                if (filteredType == Add)
                    list = currentList.Where(item => item.ADUserGroupSectionChecked == true &&
                                                    originalList.Any(originalItem => originalItem.FK_BRBranchID == item.FK_BRBranchID
                                                                                     && originalItem.FK_STModuleOrReportID == item.FK_STModuleOrReportID
                                                                                     && originalItem.ADDataViewPermissionType == item.ADDataViewPermissionType
                                                                    //&& originalItem.ADUserGroupSectionChecked == false
                                                                    )
                                            ).ToList();
                else if (filteredType == Delete)
                {
                    list = currentList.Where(item => item.ADUserGroupSectionChecked == false &&
                                                    originalList.Any(originalItem => originalItem.FK_BRBranchID == item.FK_BRBranchID
                                                                                     && originalItem.FK_STModuleOrReportID == item.FK_STModuleOrReportID
                                                                                     && originalItem.ADUserGroupSectionChecked == true
                                                                                     && originalItem.ADDataViewPermissionType == item.ADDataViewPermissionType
                                                                    )
                                            ).ToList();
                }
                //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            }

            return list;
        }

        public void SelectFullRow(DataRow row)
        {
            if (row != null)
            {
                bool selected = (bool)row[ADDataViewPermissionColumnNames.RowSelection];
                BRBranchsController branchController = new BRBranchsController();
                List<BRBranchsInfo> branches = branchController.GetAllBranches();
                foreach (BRBranchsInfo branch in branches)
                {
                    row[branch.BRBranchID.ToString() + branch.BRBranchName] = selected;
                }
            }
        }

        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
        //public void SelectFullColumn(string columnName, bool selectedValue)
        public void SelectFullColumn(string columnName, bool selectedValue, string dataViewPermissionType)
        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
        {
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //if (tableResult != null && tableResult.Rows.Count != 0)
            //{
            //    foreach (DataRow row in tableResult.Rows)
            //    {
            //        row[columnName] = selectedValue;
            //    }
            //}

            DataTable dt;
            if (dataViewPermissionType == ADDataViewPermissionType.Module)
                dt = tblModules;
            else
                dt = tblReports;

            if (dt != null && dt.Rows.Count != 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    row[columnName] = selectedValue;
                }
            }
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
        }

        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
        //public void SelectAll(bool selectedValue)
        public void SelectAll(bool selectedValue, string dataViewPermissionType)
        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
        {
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //if (tableResult != null && tableResult.Rows.Count != 0)
            //{
            //    BRBranchsController branchController = new BRBranchsController();
            //    List<BRBranchsInfo> branches = branchController.GetAllBranches();

            //    foreach (DataRow row in tableResult.Rows)
            //    {
            //        row[ADDataViewPermissionColumnNames.RowSelection] = selectedValue;
            //        foreach (BRBranchsInfo branch in branches)
            //        {
            //            row[branch.BRBranchID.ToString() + branch.BRBranchName] = selectedValue;
            //        }
            //    }
            //}

            DataTable dt;
            if (dataViewPermissionType == ADDataViewPermissionType.Module)
                dt = tblModules;
            else
                dt = tblReports;

            if (dt != null && dt.Rows.Count != 0)
            {
                BRBranchsController branchController = new BRBranchsController();
                List<BRBranchsInfo> branches = branchController.GetAllBranches();

                foreach (DataRow row in dt.Rows)
                {
                    row[ADDataViewPermissionColumnNames.RowSelection] = selectedValue;
                    foreach (BRBranchsInfo branch in branches)
                    {
                        row[branch.BRBranchID.ToString() + branch.BRBranchName] = selectedValue;
                    }
                }
            }
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
        }

        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
        //public void SelectionChanged(DataRow row, string columnName, bool selectedValue)
        public void SelectionChanged(DataRow row, string columnName, bool selectedValue, string dataViewPermissionType)
        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
        {
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //if (tableResult != null && tableResult.Rows.Count != 0)
            //{
            //    BRBranchsController branchController = new BRBranchsController();
            //    List<BRBranchsInfo> branches = branchController.GetAllBranches();

            //    if (!selectedValue)
            //    {
            //        row[ADDataViewPermissionColumnNames.RowSelection] = false;
            //        tableResult.Rows[0][columnName] = false;
            //    }
            //    else
            //    {
            //        int countRowSelection = 0;
            //        int countColumnSelection = 0;
            //        //select row
            //        foreach (BRBranchsInfo branch in branches)
            //        {
            //            if ((bool)row[branch.BRBranchID.ToString() + branch.BRBranchName] == true)
            //                countRowSelection++;
            //        }
            //        if (countRowSelection == branches.Count)
            //            row[ADDataViewPermissionColumnNames.RowSelection] = true;

            //        foreach (DataRow dtRow in tableResult.Rows)
            //        {
            //            if ((bool)dtRow[columnName] == true)
            //                countColumnSelection++;
            //        }

            //        if (countColumnSelection == tableResult.Rows.Count - 1)
            //            tableResult.Rows[0][columnName] = true;
            //    }
            //}

            DataTable dt;
            if (dataViewPermissionType == ADDataViewPermissionType.Module)
                dt = tblModules;
            else
                dt = tblReports;

            if (dt != null && dt.Rows.Count != 0)
            {
                BRBranchsController branchController = new BRBranchsController();
                List<BRBranchsInfo> branches = branchController.GetAllBranches();

                if (!selectedValue)
                {
                    row[ADDataViewPermissionColumnNames.RowSelection] = false;
                    dt.Rows[0][columnName] = false;
                }
                else
                {
                    int countRowSelection = 0;
                    int countColumnSelection = 0;
                    //select row
                    foreach (BRBranchsInfo branch in branches)
                    {
                        if ((bool)row[branch.BRBranchID.ToString() + branch.BRBranchName] == true)
                            countRowSelection++;
                    }
                    if (countRowSelection == branches.Count)
                        row[ADDataViewPermissionColumnNames.RowSelection] = true;

                    foreach (DataRow dtRow in dt.Rows)
                    {
                        if ((bool)dtRow[columnName] == true)
                            countColumnSelection++;
                    }

                    if (countColumnSelection == dt.Rows.Count - 1)
                        dt.Rows[0][columnName] = true;
                }
            }
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
        }

        #endregion Data view permission
        //NUThao [ADD] [08/04/2014] [DB centre] [Permission configuration], END

        #region InitializeTreeList_AppStaff
        public void InitializeTreeList_AppStaff(TreeList fld_trlstUserGroup_AppStaff)
        {
            UserManagementEntities entity = (UserManagementEntities)CurrentModuleEntity;
            entity.EmployeeGroupAppStaffsList = new List<HREmployeeGroupAppStaffsInfo>();
            entity.GroupAppStaffsList = new List<ADGroupAppStaffsInfo>();
            List<ADGroupAppStaffsInfo> lstNode = new List<ADGroupAppStaffsInfo>();
            TreeListNode prevFocusedNode = fld_trlstUserGroup_AppStaff.FocusedNode;
            fld_trlstUserGroup_AppStaff.Nodes.Clear();
            ADGroupAppStaffsController objGroupAppStaffsController = new ADGroupAppStaffsController();
            DataSet dsHRGroups = objGroupAppStaffsController.GetAllObjects();
            if (dsHRGroups != null)
            {
                foreach (DataRow row in dsHRGroups.Tables[0].Rows)
                {
                    ADGroupAppStaffsInfo objGroupAppStaffsInfo = (ADGroupAppStaffsInfo)objGroupAppStaffsController.GetObjectFromDataRow(row);
                    ADDataViewPermissionAppStaffsController objDataViewPermissionAppStaffsController = new ADDataViewPermissionAppStaffsController();
                    if (objGroupAppStaffsInfo != null)
                    {
                        lstNode.Add(objGroupAppStaffsInfo);
                        //objGroupAppStaffsInfo.DataViewPermissionAppStaffsList = new BOSList<ADDataViewPermissionAppStaffsInfo>();
                        //objGroupAppStaffsInfo.DataViewPermissionAppStaffsList.InitBOSList(entity,
                        //                                                            TableName.ADDataViewPermissionAppStaffsTableName,
                        //                                                            TableName.ADDataViewPermissionAppStaffsTableName,
                        //                                                            BOSList<ADDataViewPermissionAppStaffsInfo>.cstRelationNone);

                        //List<ADDataViewPermissionAppStaffsInfo> dataViewPermissionAppStaffs =
                        //    objDataViewPermissionAppStaffsController.GetDataViewPermissionAppStaffsByGroupAppStaffID(objGroupAppStaffsInfo.ADGroupAppStaffID, ADDataViewPermissionAppStaffGroupType.UserGroup.ToString());
                        //objGroupAppStaffsInfo.DataViewPermissionAppStaffsList.Invalidate(dataViewPermissionAppStaffs);
                        entity.GroupAppStaffsList.Add(objGroupAppStaffsInfo);
                    }
                }
            }
            CreateTreeView_AppStaff(fld_trlstUserGroup_AppStaff, lstNode, null);
            if (prevFocusedNode != null)
            {
                TreeListNode currentFocusedNode = fld_trlstUserGroup_AppStaff.FindNodeByID(prevFocusedNode.Id);
                while (currentFocusedNode != null)
                {
                    if (currentFocusedNode.Level > 0)
                    {
                        currentFocusedNode.ExpandAll();
                    }
                    else
                    {
                        currentFocusedNode.Expanded = true;
                    }
                    currentFocusedNode = currentFocusedNode.ParentNode;
                }
            }
        }
        private void CreateTreeView_AppStaff(TreeList fld_trlstUserGroup_AppStaff, List<ADGroupAppStaffsInfo> lstNodeName, DevExpress.XtraTreeList.Nodes.TreeListNode ParentNode)
        {
            UserManagementEntities entity = (UserManagementEntities)CurrentModuleEntity;
            fld_trlstUserGroup_AppStaff.BeginUnboundLoad();
            TreeListNode treeListNode;
            treeListNode = fld_trlstUserGroup_AppStaff.AppendNode(new object[] { UserManagementLocalizedResources.UserGroup, 0 }, ParentNode);
            for (int i = 0; i < lstNodeName.Count; i++)
            {
                treeListNode = fld_trlstUserGroup_AppStaff.AppendNode(new object[] { lstNodeName[i].ADGroupAppStaffName, 1 }, 0);
                treeListNode.Tag = lstNodeName[i].ADGroupAppStaffID;
                treeListNode.HasChildren = HasChild_AppStaff(lstNodeName[i].ADGroupAppStaffID);

                if (treeListNode.HasChildren)
                {
                    HREmployeeGroupAppStaffsController objEmployeeGroupAppStaffsController = new HREmployeeGroupAppStaffsController();
                    ADDataViewPermissionAppStaffsController objDataViewPermissionAppStaffsController = new ADDataViewPermissionAppStaffsController();
                    DataSet dsEmplyeeGroupChild = objEmployeeGroupAppStaffsController.GetHREmployeeByADGroupAppStaffID(lstNodeName[i].ADGroupAppStaffID);
                    if (dsEmplyeeGroupChild != null)
                    {
                        foreach (DataRow row in dsEmplyeeGroupChild.Tables[0].Rows)
                        {
                            HREmployeeGroupAppStaffsInfo objEmployeeGroupAppStaffsInfo = (HREmployeeGroupAppStaffsInfo)objEmployeeGroupAppStaffsController.GetObjectFromDataRow(row);
                            if (objEmployeeGroupAppStaffsInfo != null)
                            {
                                HREmployeesInfo objEmployee = (HREmployeesInfo)new HREmployeesController().GetObjectByID(objEmployeeGroupAppStaffsInfo.FK_HREmployeeID);
                                TreeListNode treeListChildNode = fld_trlstUserGroup_AppStaff.AppendNode(new object[] { objEmployee.HREmployeeName, treeListNode.Level + 1 }, treeListNode);
                                treeListChildNode.Tag = objEmployeeGroupAppStaffsInfo.HREmployeeGroupAppStaffID;
                                //objEmployeeGroupAppStaffsInfo.DataViewPermissionAppStaffsList = new BOSList<ADDataViewPermissionAppStaffsInfo>();
                                //objEmployeeGroupAppStaffsInfo.DataViewPermissionAppStaffsList.InitBOSList(entity,
                                //                                                            TableName.ADDataViewPermissionAppStaffsTableName,
                                //                                                            TableName.ADDataViewPermissionAppStaffsTableName,
                                //                                                            BOSList<ADDataViewPermissionAppStaffsInfo>.cstRelationNone);

                                //List<ADDataViewPermissionAppStaffsInfo> dataViewPermissionAppStaffs =
                                //    objDataViewPermissionAppStaffsController.GetDataViewPermissionAppStaffsByEmployeeGroupAppStaffID(objEmployeeGroupAppStaffsInfo.FK_ADGroupAppStaffID, objEmployeeGroupAppStaffsInfo.HREmployeeGroupAppStaffID, ADDataViewPermissionAppStaffGroupType.User.ToString());
                                //objEmployeeGroupAppStaffsInfo.DataViewPermissionAppStaffsList.Invalidate(dataViewPermissionAppStaffs);
                                entity.EmployeeGroupAppStaffsList.Add(objEmployeeGroupAppStaffsInfo);
                            }
                        }
                    }
                }
            }
            fld_trlstUserGroup_AppStaff.EndUnboundLoad();
        }

        public bool HasChild_AppStaff(int iGroupID)
        {
            DataSet ds = new HREmployeeGroupAppStaffsController().GetAllDataByForeignColumn("FK_ADGroupAppStaffID", iGroupID);
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                    return true;
            }
            return false;
        }
        #endregion

        #region AppStaff

        public void SelectAppStaffFullColumn(string columnName, bool selectedValue)
        {
            DataTable dt = new DataTable();
            dt = tblAppStaffs;

            if (dt != null && dt.Rows.Count != 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    row[columnName] = selectedValue;
                }
            }
        }

        //public void InvalidateAppStaff(ADGroupAppStaffsInfo objGroupAppStaffsInfo)
        //{
        //    UserManagementEntities entity = (UserManagementEntities)CurrentModuleEntity;
        //    ADDataViewPermissionAppStaffsController objDataViewPermissionAppStaffsController = new ADDataViewPermissionAppStaffsController();
        //    if (objGroupAppStaffsInfo != null)
        //    {
        //        DataTable dt;
        //        originalDataViewPermissionAppStaffsList.Clear();
        //        tblAppStaffs = objDataViewPermissionAppStaffsController.GetDataViewPermissionsByGroupID(objGroupAppStaffsInfo.ADGroupAppStaffID);
        //        dt = tblAppStaffs;
        //        guiUserManagement_AppStaffs.RefreshDataViewPermissionGridControlDataSource(tblAppStaffs);
        //        //store the original data view permission list
        //        List<ADDataViewPermissionAppStaffsInfo> list = ConvertDataTableToListObject(tblAppStaffs);
        //        if (list != null)
        //            originalDataViewPermissionAppStaffsList.AddRange(list);
        //    }
        //}

        private List<ADDataViewPermissionAppStaffsInfo> ConvertDataTableToListObject(DataTable dt)
        {
            List<ADDataViewPermissionAppStaffsInfo> list = new List<ADDataViewPermissionAppStaffsInfo>();
            BRBranchsController branchController = new BRBranchsController();
            List<BRBranchsInfo> branches = branchController.GetAllBranches();

            if (dt != null && dt.Rows.Count != 0)
            {
                for (int index = 1; index < dt.Rows.Count; index++)
                {
                    DataRow row = dt.Rows[index];
                    if (branches != null)
                    {
                        foreach (BRBranchsInfo branch in branches)
                        {
                            ADDataViewPermissionAppStaffsInfo dataViewPermission = new ADDataViewPermissionAppStaffsInfo();
                            dataViewPermission.ADDataViewPermissionAppStaffID = int.Parse(row[ADDataViewPermissionAppStaffColumnNames.ADDataViewPermissionAppStaffID].ToString());
                            dataViewPermission.FK_ADGroupAppStaffID = int.Parse(row[ADDataViewPermissionAppStaffColumnNames.ADGroupAppStaffID].ToString());
                            dataViewPermission.FK_BRBranchID = branch.BRBranchID;
                            dataViewPermission.FK_ADPrivilegeAppSatffID = int.Parse(row[ADDataViewPermissionAppStaffColumnNames.FK_ADPrivilegeAppSatffID].ToString());
                            dataViewPermission.ADUserGroupSectionChecked = bool.Parse(row[branch.BRBranchID.ToString() + branch.BRBranchName].ToString());
                            //dataViewPermission.ADDataViewPermissionType = dataViewPermissionType;
                            list.Add(dataViewPermission);
                        }
                    }
                }
            }
            return list;
        }

        public void SelectAppStaffAll(bool selectedValue, string dataViewPermissionType)
        {
            DataTable dt = new DataTable();
            dt = tblAppStaffs;

            if (dt != null && dt.Rows.Count != 0)
            {
                BRBranchsController branchController = new BRBranchsController();
                List<BRBranchsInfo> branches = branchController.GetAllBranches();

                foreach (DataRow row in dt.Rows)
                {
                    row[ADDataViewPermissionAppStaffColumnNames.RowSelection] = selectedValue;
                    foreach (BRBranchsInfo branch in branches)
                    {
                        row[branch.BRBranchID.ToString() + branch.BRBranchName] = selectedValue;
                    }
                }
            }
        }

        public void SelectAppStaffFullRow(DataRow row)
        {
            if (row != null)
            {
                bool selected = (bool)row[ADDataViewPermissionAppStaffColumnNames.RowSelection];
                BRBranchsController branchController = new BRBranchsController();
                List<BRBranchsInfo> branches = branchController.GetAllBranches();
                foreach (BRBranchsInfo branch in branches)
                {
                    row[branch.BRBranchID.ToString() + branch.BRBranchName] = selected;
                }
            }
        }

        public void SelectionAppStaffChanged(DataRow row, string columnName, bool selectedValue)
        {
            DataTable dt = new DataTable();
            dt = tblAppStaffs;

            if (dt != null && dt.Rows.Count != 0)
            {
                BRBranchsController branchController = new BRBranchsController();
                List<BRBranchsInfo> branches = branchController.GetAllBranches();

                if (!selectedValue)
                {
                    row[ADDataViewPermissionAppStaffColumnNames.RowSelection] = false;
                    dt.Rows[0][columnName] = false;
                }
                else
                {
                    int countRowSelection = 0;
                    int countColumnSelection = 0;
                    foreach (BRBranchsInfo branch in branches)
                    {
                        if ((bool)row[branch.BRBranchID.ToString() + branch.BRBranchName] == true)
                            countRowSelection++;
                    }
                    if (countRowSelection == branches.Count)
                        row[ADDataViewPermissionAppStaffColumnNames.RowSelection] = true;

                    foreach (DataRow dtRow in dt.Rows)
                    {
                        if ((bool)dtRow[columnName] == true)
                            countColumnSelection++;
                    }

                    if (countColumnSelection == dt.Rows.Count - 1)
                        dt.Rows[0][columnName] = true;
                }
            }
        }
        #region phân quyền App
        //GridCheckMarksSelection helper;
        public BandedGridView InitBandedGridViewAppStaff(GridView gridView)
        {
            GELocationsController objLocationsController = new GELocationsController();
            BRBranchsController objBranchsController = new BRBranchsController();
            List<GELocationsInfo> locations = objLocationsController.GetLocationsHaveBranch();
            List<BRBranchsInfo> activebranches = objBranchsController.GetAllBranches();

            BandedGridView bandedView = new BandedGridView();
            bandedView.GridControl = gridView.GridControl;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;
            bandedView.OptionsSelection.MultiSelect = true;
            bandedView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                bandedView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
                        ConvertToBandedGridColumn(gridView.Columns[i], false)});
            }

            GridBand[] gridBands = new GridBand[locations.Count + 2];

            GridBand itemGridBand = new GridBand();
            itemGridBand.Caption = "";
            itemGridBand.Name = "";

            GridBand gridBandGen = new GridBand();
            gridBandGen.Caption = "";
            gridBandGen.Name = "";

            BandedGridColumn bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = "ADPrivilegeAppSatffGroup";
            bandedUserGroupSectionColumn.Caption = "Nhóm";
            bandedUserGroupSectionColumn.FieldName = "ADPrivilegeAppSatffGroup";
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.OwnerBand = gridBandGen;
            bandedUserGroupSectionColumn.Width = 100;
            bandedUserGroupSectionColumn.Group();
            bandedUserGroupSectionColumn.GroupIndex = 1;
            bandedUserGroupSectionColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            bandedView.Columns.Add(bandedUserGroupSectionColumn);

            bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = ADDataViewPermissionAppStaffColumnNames.ADPrivilegeAppSatffName;
            bandedUserGroupSectionColumn.Caption = "Chức năng";
            bandedUserGroupSectionColumn.FieldName = ADDataViewPermissionAppStaffColumnNames.ADPrivilegeAppSatffName;
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.OwnerBand = itemGridBand;
            bandedUserGroupSectionColumn.Width = 100;
            bandedView.Columns.Add(bandedUserGroupSectionColumn);

            BandedGridColumn bandedColumn1 = new BandedGridColumn();
            bandedColumn1.Name = ADDataViewPermissionColumnNames.RowSelection;
            bandedColumn1.Caption = " ";
            bandedColumn1.FieldName = ADDataViewPermissionColumnNames.RowSelection;
            bandedColumn1.Visible = true;
            bandedColumn1.OptionsColumn.AllowEdit = true;
            RepositoryItemCheckEdit chk1 = new RepositoryItemCheckEdit();
            bandedColumn1.ColumnEdit = chk1;
            bandedColumn1.OwnerBand = itemGridBand;
            bandedView.Columns.Add(bandedColumn1);

            itemGridBand.Fixed = FixedStyle.Left;
            gridBands[1] = itemGridBand;

            gridBandGen.Fixed = FixedStyle.Left;
            gridBands[0] = gridBandGen;

            for (int i = 1; i <= locations.Count; i++)
            {
                GridBand itemGridBand1 = new GridBand();
                itemGridBand1.Caption = locations[i - 1].GELocationName;
                itemGridBand1.Name = locations[i - 1].GELocationID.ToString();
                itemGridBand1.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

                if (activebranches != null)
                {

                    List<BRBranchsInfo> branchs = activebranches.Where(p => p.FK_GELocationID == locations[i - 1].GELocationID).ToList();

                    for (int j = 0; j < branchs.Count; j++)
                    {

                        BandedGridColumn bandedColumn2 = new BandedGridColumn();
                        bandedColumn2.Name = branchs[j].BRBranchID.ToString() + branchs[j].BRBranchName;
                        bandedColumn2.Caption = branchs[j].BRBranchName;
                        bandedColumn2.FieldName = branchs[j].BRBranchID.ToString() + branchs[j].BRBranchName;
                        bandedColumn2.Visible = true;
                        bandedColumn2.OptionsColumn.AllowEdit = true;
                        RepositoryItemCheckEdit chk2 = new RepositoryItemCheckEdit();
                        bandedColumn2.ColumnEdit = chk2;
                        bandedColumn2.OwnerBand = itemGridBand1;
                        bandedView.Columns.Add(bandedColumn2);

                    }
                }
                gridBands[i + 1] = itemGridBand1;
            }

            bandedView.Bands.AddRange(gridBands);
            bandedView.BeginSort();
            try
            {
                bandedView.ClearGrouping();
                if (bandedView.Columns["ADPrivilegeAppSatffGroup"] != null)
                {
                    bandedView.Columns["ADPrivilegeAppSatffGroup"].GroupIndex = 1;
                }
            }
            finally
            {
                bandedView.EndSort();
            }
            bandedView.ExpandAllGroups();
            //helper = new GridCheckMarksSelection(bandedView);
            return bandedView;
        }
        #endregion
        private void SaveDataViewPermisionAppStaff(DataTable dt)
        {
            List<ADDataViewPermissionAppStaffsInfo> currentList;
            ADDataViewPermissionAppStaffsController dataViewPermissionAppStaffController = new ADDataViewPermissionAppStaffsController();
            currentList = ConvertDataTableToListObject(dt);
            List<ADDataViewPermissionAppStaffsInfo> newList = FilterChangedAppStaffObjects(currentList, originalDataViewPermissionAppStaffsList, Add);
            List<ADDataViewPermissionAppStaffsInfo> deletedList = FilterChangedAppStaffObjects(currentList, originalDataViewPermissionAppStaffsList, Delete);
            List<ADDataViewPermissionAppStaffsInfo> addedItems = new List<ADDataViewPermissionAppStaffsInfo>();
            ADDataViewPermissionAppStaffsInfo originalPermissionAppStaff = null;
            //add new item list
            if (newList != null && newList.Count != 0)
            {
                foreach (ADDataViewPermissionAppStaffsInfo dataViewPermissionAppStaff in newList)
                {
                    originalPermissionAppStaff = dataViewPermissionAppStaffController.GetDataViewPermissionAppStaffsByADGroupAppStaffIDAndBranchIDAndADPrivilegeAppSatffID(dataViewPermissionAppStaff.FK_ADGroupAppStaffID, dataViewPermissionAppStaff.FK_BRBranchID, dataViewPermissionAppStaff.FK_ADPrivilegeAppSatffID);
                    if (originalPermissionAppStaff == null)
                    {
                        dataViewPermissionAppStaff.ADDataViewPermissionAppStaffGroupType = ADDataViewPermissionAppStaffGroupType.UserGroup.ToString();
                        dataViewPermissionAppStaffController.CreateObject(dataViewPermissionAppStaff);
                        addedItems.Add(dataViewPermissionAppStaff);
                    }
                }
            }
            //delete 
            if (deletedList != null && deletedList.Count != 0)
            {
                foreach (ADDataViewPermissionAppStaffsInfo dataViewPermissionAppStaff in deletedList)
                {
                    originalPermissionAppStaff = dataViewPermissionAppStaffController.GetDataViewPermissionAppStaffsByADGroupAppStaffIDAndBranchIDAndADPrivilegeAppSatffID(dataViewPermissionAppStaff.FK_ADGroupAppStaffID, dataViewPermissionAppStaff.FK_BRBranchID, dataViewPermissionAppStaff.FK_ADPrivilegeAppSatffID);
                    if (originalPermissionAppStaff != null)
                    {
                        dataViewPermissionAppStaffController.DeleteObject(originalPermissionAppStaff.ADDataViewPermissionAppStaffID);
                    }
                }
            }

            //update original list
            MergeDataPermissionAppStaffList(addedItems, originalDataViewPermissionAppStaffsList);
            MergeDataPermissionAppStaffList(deletedList, originalDataViewPermissionAppStaffsList);
        }

        private List<ADDataViewPermissionAppStaffsInfo> FilterChangedAppStaffObjects(List<ADDataViewPermissionAppStaffsInfo> currentList, List<ADDataViewPermissionAppStaffsInfo> originalList, string filteredType)
        {
            List<ADDataViewPermissionAppStaffsInfo> list = new List<ADDataViewPermissionAppStaffsInfo>();
            if (currentList != null && originalList != null)
            {
                if (filteredType == Add)
                    list = currentList.Where(item => item.ADUserGroupSectionChecked == true &&
                                                    originalList.Any(originalItem => originalItem.FK_BRBranchID == item.FK_BRBranchID
                                                                                     && originalItem.FK_ADPrivilegeAppSatffID == item.FK_ADPrivilegeAppSatffID
                                            )).ToList();
                else if (filteredType == Delete)
                {
                    list = currentList.Where(item => item.ADUserGroupSectionChecked == false &&
                                                    originalList.Any(originalItem => originalItem.FK_BRBranchID == item.FK_BRBranchID
                                                                                     && originalItem.FK_ADPrivilegeAppSatffID == item.FK_ADPrivilegeAppSatffID
                                                                                     && originalItem.ADUserGroupSectionChecked == true
                                                                    )).ToList();
                }
            }

            return list;
        }
        private void MergeDataPermissionAppStaffList(List<ADDataViewPermissionAppStaffsInfo> source, List<ADDataViewPermissionAppStaffsInfo> des)
        {
            if (source != null && des != null)
            {
                foreach (ADDataViewPermissionAppStaffsInfo item in source)
                {
                    ADDataViewPermissionAppStaffsInfo foundItem = des.FirstOrDefault(i => i.FK_ADPrivilegeAppSatffID == item.FK_ADPrivilegeAppSatffID);
                    if (foundItem != null)
                        foundItem.ADUserGroupSectionChecked = item.ADUserGroupSectionChecked;
                }
            }
        }
        #endregion 

        #region initialze treelist OrderWeb
        public void InitializeTreeList_OrderWeb(TreeList fld_trlstUserGroup_OrderWeb)
        {
            List<ADGroupOrderWebsInfo> lstNode = new List<ADGroupOrderWebsInfo>();
            TreeListNode prevFocusedNode = fld_trlstUserGroup_OrderWeb.FocusedNode;
            fld_trlstUserGroup_OrderWeb.Nodes.Clear();
            ADGroupOrderWebsController objADGroupOrderWebsController = new ADGroupOrderWebsController();
            DataSet dsHRGroups = objADGroupOrderWebsController.GetAllObjects();
            if (dsHRGroups != null)
            {
                foreach (DataRow row in dsHRGroups.Tables[0].Rows)
                {
                    ADGroupOrderWebsInfo objADGroupOrderWebsInfo = (ADGroupOrderWebsInfo)objADGroupOrderWebsController.GetObjectFromDataRow(row);
                    if (objADGroupOrderWebsInfo != null)
                    {
                        lstNode.Add(objADGroupOrderWebsInfo);
                    }
                }
            }
            CreateTreeView_OrderWeb(fld_trlstUserGroup_OrderWeb, lstNode, null);
            if (prevFocusedNode != null)
            {
                TreeListNode currentFocusedNode = fld_trlstUserGroup_OrderWeb.FindNodeByID(prevFocusedNode.Id);
                while (currentFocusedNode != null)
                {
                    if (currentFocusedNode.Level > 0)
                    {
                        currentFocusedNode.ExpandAll();
                    }
                    else
                    {
                        currentFocusedNode.Expanded = true;
                    }
                    currentFocusedNode = currentFocusedNode.ParentNode;
                }
            }
        }
        private void CreateTreeView_OrderWeb(TreeList fld_trlstUserGroup_OrderWeb, List<ADGroupOrderWebsInfo> lstNodeName, DevExpress.XtraTreeList.Nodes.TreeListNode ParentNode)
        {
            fld_trlstUserGroup_OrderWeb.BeginUnboundLoad();
            TreeListNode treeListNode;
            treeListNode = fld_trlstUserGroup_OrderWeb.AppendNode(new object[] { UserManagementLocalizedResources.UserGroup, 0 }, ParentNode);
            for (int i = 0; i < lstNodeName.Count; i++)
            {
                treeListNode = fld_trlstUserGroup_OrderWeb.AppendNode(new object[] { lstNodeName[i].ADGroupOrderWebName, 1 }, 0);
                treeListNode.Tag = lstNodeName[i].ADGroupOrderWebID;
                treeListNode.HasChildren = HasChild_OrderWeb(lstNodeName[i].ADGroupOrderWebID);

                if (treeListNode.HasChildren)
                {
                    HREmployeeGroupOrderWebsController objHREmployeeGroupOrderWebsController = new HREmployeeGroupOrderWebsController();
                    DataSet dsEmplyeeGroupChild = objHREmployeeGroupOrderWebsController.GetHREmployeeByADGroupOrderWebID(lstNodeName[i].ADGroupOrderWebID);
                    if (dsEmplyeeGroupChild != null)
                    {
                        foreach (DataRow row in dsEmplyeeGroupChild.Tables[0].Rows)
                        {
                            HREmployeeGroupOrderWebsInfo objHREmployeeGroupOrderWebsInfo = (HREmployeeGroupOrderWebsInfo)objHREmployeeGroupOrderWebsController.GetObjectFromDataRow(row);
                            if (objHREmployeeGroupOrderWebsInfo != null)
                            {
                                HREmployeesInfo objEmployee = (HREmployeesInfo)new HREmployeesController().GetObjectByID(objHREmployeeGroupOrderWebsInfo.FK_HREmployeeID);
                                TreeListNode treeListChildNode = fld_trlstUserGroup_OrderWeb.AppendNode(new object[] { objEmployee.HREmployeeName, treeListNode.Level + 1 }, treeListNode);
                                treeListChildNode.Tag = objHREmployeeGroupOrderWebsInfo.HREmployeeGroupOrderWebID;
                            }
                        }
                    }

                }
            }
            fld_trlstUserGroup_OrderWeb.EndUnboundLoad();
        }

        public bool HasChild_OrderWeb(int iUserGroupID)
        {
            DataSet ds = new HREmployeeGroupOrderWebsController().GetAllDataByForeignColumn("FK_ADGroupOrderWebID", iUserGroupID);
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                    return true;
            }
            return false;
        }
        #endregion
    }
}
