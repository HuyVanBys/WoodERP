using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.UserManagement
{
    public partial class guiUserManagement_AppStaff : BOSERPScreen
    {
        private SortedList<string, BOSERPScreen> Screens;
        /// <summary>
        /// Index of current screen in screen list
        /// </summary>
        private int ScreenIndex = 0;
        private GridControlHelper selection;
        public guiUserManagement_AppStaff()
        {
            InitializeComponent();

            Screens = new SortedList<string, BOSERPScreen>();
        }

        /// <summary>
        /// Set permission for selected screen of module
        /// </summary>
        /// <param name="sender">The selected screen of module</param>
        /// <param name="e"></param>
        private void fld_tabScreenContainer_MouseClick(object sender, MouseEventArgs e)
        {
            BOSTabControl tabControl = (BOSTabControl)sender;
            if (e.Button == MouseButtons.Left)
            {
                if (tabControl.SelectedTabPageIndex >= 0)
                {
                    ScreenIndex = tabControl.SelectedTabPageIndex;
                    XtraTabPage tabPage = tabControl.TabPages[tabControl.SelectedTabPageIndex];
                    ContextMenu popupMenu = new ContextMenu();
                    STScreenPermissionsController objScreenPermissionsController = new STScreenPermissionsController();
                    STScreenPermissionsInfo objScreenPermissionsInfo = new STScreenPermissionsInfo();
                    objScreenPermissionsInfo = (STScreenPermissionsInfo)objScreenPermissionsController
                        .GetScreenPermissionByUserGroupIDAndModuleNameAndScreenName(
                                ((UserManagementModule)Module).CurrentUserGroup.ADUserGroupID,
                                ((UserManagementModule)Module).CurrentModule.STModuleName,
                                Screens.Values[tabControl.SelectedTabPageIndex].Name);

                    if (objScreenPermissionsInfo == null
                        || objScreenPermissionsInfo.STScreenPermissionType == Convert.ToByte(FieldPermissionType.None))
                    {
                        MenuItem item = popupMenu.MenuItems.Add(UserManagementLocalizedResources.Hide, new EventHandler(HideScreen_Click));
                        item.Tag = tabPage;
                    }
                    else if (objScreenPermissionsInfo.STScreenPermissionType == Convert.ToByte(FieldPermissionType.Hided))
                    {
                        MenuItem item = popupMenu.MenuItems.Add(UserManagementLocalizedResources.Show, new EventHandler(ShowScreen_Click));
                        item.Tag = tabPage;
                    }
                    popupMenu.Show(tabPage, new Point(e.X, e.Y));
                }
            }
        }

        /// <summary>
        /// Show screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowScreen_Click(object sender, EventArgs e)
        {
            XtraTabPage tabPage = (XtraTabPage)((MenuItem)sender).Tag;
            STScreenPermissionsController objScreenPermissionsController = new STScreenPermissionsController();
            STScreenPermissionsInfo objScreenPermissionsInfo = new STScreenPermissionsInfo();
            objScreenPermissionsInfo = (STScreenPermissionsInfo)objScreenPermissionsController
                .GetScreenPermissionByUserGroupIDAndModuleNameAndScreenName(
                        ((UserManagementModule)Module).CurrentUserGroup.ADUserGroupID,
                        ((UserManagementModule)Module).CurrentModule.STModuleName,
                        Screens.Values[ScreenIndex].Name);
            objScreenPermissionsInfo.STScreenPermissionType = Convert.ToByte(FieldPermissionType.None);
            objScreenPermissionsController.UpdateObject(objScreenPermissionsInfo);
            DrawScreen(tabPage, objScreenPermissionsInfo);
        }

        /// <summary>
        /// Hide screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HideScreen_Click(object sender, EventArgs e)
        {
            XtraTabPage tabPage = (XtraTabPage)((MenuItem)sender).Tag;
            STScreenPermissionsController objScreenPermissionsController = new STScreenPermissionsController();
            STScreenPermissionsInfo objScreenPermissionsInfo = new STScreenPermissionsInfo();
            objScreenPermissionsInfo = (STScreenPermissionsInfo)objScreenPermissionsController
                .GetScreenPermissionByUserGroupIDAndModuleNameAndScreenName(
                        ((UserManagementModule)Module).CurrentUserGroup.ADUserGroupID,
                        ((UserManagementModule)Module).CurrentModule.STModuleName,
                        Screens.Values[ScreenIndex].Name);
            if (objScreenPermissionsInfo == null)
            {
                objScreenPermissionsInfo = new STScreenPermissionsInfo();
                objScreenPermissionsInfo.FK_ADUserGroupID = ((UserManagementModule)Module).CurrentUserGroup.ADUserGroupID;
                objScreenPermissionsInfo.STModuleName = ((UserManagementModule)Module).CurrentModule.STModuleName;
                objScreenPermissionsInfo.STScreenName = Screens.Values[ScreenIndex].Name;
                objScreenPermissionsInfo.STScreenPermissionType = Convert.ToByte(FieldPermissionType.Hided);
                objScreenPermissionsController.CreateObject(objScreenPermissionsInfo);
            }
            else
            {
                objScreenPermissionsInfo.STScreenPermissionType = Convert.ToByte(FieldPermissionType.Hided);
                objScreenPermissionsController.UpdateObject(objScreenPermissionsInfo);
            }
            DrawScreen(tabPage, objScreenPermissionsInfo);
        }

        /// <summary>
        /// Change screen status to hide or show
        /// </summary>
        /// <param name="tabPage">Tab page of screen</param>
        /// <param name="objScreenPermissionsInfo">Screen permission</param>
        private void DrawScreen(XtraTabPage tabPage, STScreenPermissionsInfo objScreenPermissionsInfo)
        {
            if (objScreenPermissionsInfo == null
                    || objScreenPermissionsInfo.STScreenPermissionType == Convert.ToByte(FieldPermissionType.None))
                tabPage.Appearance.Header.ForeColor = Color.Black;
            else
                tabPage.Appearance.Header.ForeColor = Color.Red;
        }

        #region User Group Management
        private void fld_trlstUserGroup_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeListNode node = fld_trlstUserGroup_AppStaff.FocusedNode;
                if (node != null)
                {
                    if (node.Level == 0)
                    {
                        ContextMenu popupMenu = new ContextMenu();
                        popupMenu.MenuItems.Add(UserManagementLocalizedResources.AddUserGroup, new EventHandler(AddUserGroup_Clicked));
                        popupMenu.Show(fld_trlstUserGroup_AppStaff, new Point(e.X, e.Y));

                    }
                    else if (node.Level == 1)
                    {
                        ContextMenu popupMenu = new ContextMenu();
                        popupMenu.MenuItems.Add(UserManagementLocalizedResources.AddUser, new EventHandler(AddSection_Clicked));
                        popupMenu.MenuItems.Add(UserManagementLocalizedResources.EditUserGroup, new EventHandler(EditUserGroup_Clicked));
                        popupMenu.MenuItems.Add(UserManagementLocalizedResources.DeleteUserGroup, new EventHandler(DeleteUserGroup_Clicked));
                        popupMenu.Show(fld_trlstUserGroup_AppStaff, new Point(e.X, e.Y));
                    }
                    else if (node.Level == 2)
                    {
                        ContextMenu popupMenu = new ContextMenu();
                        popupMenu.MenuItems.Add("Xóa nhân viên", new EventHandler(DeleteSection_Clicked));
                        popupMenu.Show(fld_trlstUserGroup_AppStaff, new Point(e.X, e.Y));
                    }
                }
            }
            else
            {
                UserManagementEntities entity = (UserManagementEntities)((BaseModuleERP)Module).CurrentModuleEntity;
                TreeListNode node = fld_trlstUserGroup_AppStaff.FocusedNode;
                if (node != null)
                {
                    HREmployeeGroupAppStaffsController objEmployeeGroupAppStaffsController = new HREmployeeGroupAppStaffsController();
                    ADGroupAppStaffsController objGroupAppStaffsController = new ADGroupAppStaffsController();
                    if (node.Level == 1)
                    {
                        int userGroupID = Convert.ToInt32(node.Tag);
                        ADGroupAppStaffsInfo objGroupAppStaffsInfo = (ADGroupAppStaffsInfo)entity.GroupAppStaffsList.Where(o => o.ADGroupAppStaffID == userGroupID).FirstOrDefault();
                        if (objGroupAppStaffsInfo != null)
                        {
                            fld_lblTitleAppStaff.Text = "Phân quyền cho nhóm " + objGroupAppStaffsInfo.ADGroupAppStaffName;
                        }
                        fld_dgcADDataViewPermissionAppStaffs.Enabled = true;
                        ((UserManagementModule)Module).InvalidateAppStaff(objGroupAppStaffsInfo);
                    }
                    else if (node.Level == 2)
                    {
                        fld_dgcADDataViewPermissionAppStaffs.Enabled = false;
                    }
                }
            }
        }

        private void AddUserGroup_Clicked(object sender, EventArgs e)
        {
            guiAddUserGroups_AppStaff _guiAddUserGroups_AppStaff = new guiAddUserGroups_AppStaff(fld_trlstUserGroup_AppStaff, AddUserGroup_AppStaffMode.Add);
            _guiAddUserGroups_AppStaff.Module = this.Module;
            _guiAddUserGroups_AppStaff.ShowDialog();
        }

        private void EditUserGroup_Clicked(object sender, EventArgs e)
        {
            guiAddUserGroups_AppStaff guiAddUserGroups_AppStaff = new guiAddUserGroups_AppStaff(fld_trlstUserGroup_AppStaff, AddUserGroup_AppStaffMode.Edit);
            guiAddUserGroups_AppStaff.Module = this.Module;
            guiAddUserGroups_AppStaff.fld_txtUserGroup_AppStaff.Text = fld_trlstUserGroup_AppStaff.FocusedNode.GetDisplayText(fld_trlstUserGroup_AppStaff.Columns[0]);
            guiAddUserGroups_AppStaff.ShowDialog();
        }

        private void AddSection_Clicked(object sender, EventArgs e)
        {
            guiManageUser_AppStaff _guiManageUser_AppStaff = new guiManageUser_AppStaff(fld_trlstUserGroup_AppStaff, AddUserGroup_AppStaffMode.Add);
            _guiManageUser_AppStaff.Module = this.Module;
            _guiManageUser_AppStaff.ShowDialog();
        }

        private void EditSection_Clicked(object sender, EventArgs e)
        {
            guiManageUser_AppStaff _guiManageUser_AppStaff = new guiManageUser_AppStaff(fld_trlstUserGroup_AppStaff, AddUserGroup_AppStaffMode.Edit);
            _guiManageUser_AppStaff.Module = this.Module;
            _guiManageUser_AppStaff.ShowDialog();
        }

        private void DeleteSection_Clicked(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên !", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UserManagementEntities entity = (UserManagementEntities)((BaseModuleERP)Module).CurrentModuleEntity;
                TreeListNode node = fld_trlstUserGroup_AppStaff.FocusedNode;
                HREmployeeGroupAppStaffsController objHREmployeeGroupsController = new HREmployeeGroupAppStaffsController();
                HREmployeeGroupAppStaffsInfo objHREmployeeGroupsInfo = (HREmployeeGroupAppStaffsInfo)objHREmployeeGroupsController.GetObjectByID((int)node.Tag);
                objHREmployeeGroupsController.DeleteObject(objHREmployeeGroupsInfo.HREmployeeGroupAppStaffID);
                ((UserManagementModule)Module).InitializeTreeList_AppStaff(fld_trlstUserGroup_AppStaff);
            }
        }

        private void DeleteUserGroup_Clicked(object sender, EventArgs e)
        {
            if (MessageBox.Show(UserManagementLocalizedResources.ConfirmDeleteUserGroupMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TreeListNode node = fld_trlstUserGroup_AppStaff.FocusedNode;
                ADGroupAppStaffsController objGroupAppStaffsController = new ADGroupAppStaffsController();
                ADGroupAppStaffsInfo objGroupAppStaffsInfo = (ADGroupAppStaffsInfo)objGroupAppStaffsController.GetObjectByID((int)node.Tag);
                objGroupAppStaffsController.DeleteObject(objGroupAppStaffsInfo.ADGroupAppStaffID);
                HREmployeeGroupAppStaffsController objHREmployeeGroupsController = new HREmployeeGroupAppStaffsController();
                objHREmployeeGroupsController.DeleteByForeignColumn("FK_ADGroupAppStaffID", objGroupAppStaffsInfo.ADGroupAppStaffID);
                ((UserManagementModule)Module).InitializeTreeList_AppStaff(fld_trlstUserGroup_AppStaff);
                fld_lblTitleAppStaff.Text = "Phân quyền";
            }
        }

        private void AddModule_Clicked(object sender, EventArgs e)
        {
            guiAddModules _guiAddModules = new guiAddModules(fld_trlstUserGroup_AppStaff);
            _guiAddModules.Module = this.Module;
            _guiAddModules.ShowDialog();
        }
        #endregion

        #region Do drag/drop
        /// <summary>
        /// Do drag/drop tree list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private TreeListHitInfo downHitInfo;

        private void fld_trlstUserGroup_DragDrop(object sender, DragEventArgs e)
        {
            TreeListHitInfo hitInfo = fld_trlstUserGroup_AppStaff.CalcHitInfo(fld_trlstUserGroup_AppStaff.PointToClient(new Point(e.X, e.Y)));
            TreeListNode targetNode = hitInfo.Node;
            TreeListNode sourceNode = downHitInfo.Node;
            if (targetNode != null)
            {
                if (targetNode.Level == 3 && sourceNode.Level == 3 && targetNode.ParentNode == sourceNode.ParentNode)
                {
                    STModuleToUserGroupSectionsController objSTModuleToUserGroupSectionController = new STModuleToUserGroupSectionsController();
                    STModuleToUserGroupSectionsInfo objModuleToUserGroupSectionsInfoSource = (STModuleToUserGroupSectionsInfo)objSTModuleToUserGroupSectionController.GetModuleToUserGroupSectionByUserGroupSectionIDAndModuleID((int)sourceNode.ParentNode.Tag, (int)sourceNode.Tag);
                    STModuleToUserGroupSectionsInfo objModuleToUserGroupSectionsInfoTarget = (STModuleToUserGroupSectionsInfo)objSTModuleToUserGroupSectionController.GetModuleToUserGroupSectionByUserGroupSectionIDAndModuleID((int)targetNode.ParentNode.Tag, (int)targetNode.Tag);

                    int sortOrderSrc = objModuleToUserGroupSectionsInfoSource.STModuleToUserGroupSectionSortOrder;
                    objModuleToUserGroupSectionsInfoSource.STModuleToUserGroupSectionSortOrder = objModuleToUserGroupSectionsInfoTarget.STModuleToUserGroupSectionSortOrder;
                    objModuleToUserGroupSectionsInfoTarget.STModuleToUserGroupSectionSortOrder = sortOrderSrc;

                    //Update
                    objSTModuleToUserGroupSectionController.UpdateObject(objModuleToUserGroupSectionsInfoSource);
                    objSTModuleToUserGroupSectionController.UpdateObject(objModuleToUserGroupSectionsInfoTarget);
                    ((UserManagementModule)Module).InitializeTreeList(fld_trlstUserGroup_AppStaff);
                }
                else if (targetNode.Level == 2 && sourceNode.Level == 2 && targetNode.ParentNode == sourceNode.ParentNode)
                {
                    ADUserGroupSectionsController objUserGroupSectionsController = new ADUserGroupSectionsController();
                    ADUserGroupSectionsInfo objUserGroupSectionsInfoSource = (ADUserGroupSectionsInfo)objUserGroupSectionsController.GetObjectByID((int)sourceNode.Tag);
                    ADUserGroupSectionsInfo objUserGroupSectionsInfoTarget = (ADUserGroupSectionsInfo)objUserGroupSectionsController.GetObjectByID((int)targetNode.Tag);

                    int sortOrderSrc = objUserGroupSectionsInfoSource.ADUserGroupSectionSortOrder;
                    objUserGroupSectionsInfoSource.ADUserGroupSectionSortOrder = objUserGroupSectionsInfoTarget.ADUserGroupSectionSortOrder;
                    objUserGroupSectionsInfoTarget.ADUserGroupSectionSortOrder = sortOrderSrc;

                    //Update
                    objUserGroupSectionsController.UpdateObject(objUserGroupSectionsInfoSource);
                    objUserGroupSectionsController.UpdateObject(objUserGroupSectionsInfoTarget);
                    ((UserManagementModule)Module).InitializeTreeList(fld_trlstUserGroup_AppStaff);
                }
                else
                    return;
            }
        }

        private void fld_trlstUserGroup_DragOver(object sender, DragEventArgs e)
        {
            TreeListHitInfo hi = fld_trlstUserGroup_AppStaff.CalcHitInfo(fld_trlstUserGroup_AppStaff.PointToClient(new Point(e.X, e.Y)));
            TreeListNode node = GetDragNode(e.Data);
            if (node == null)
            {
                if (hi.HitInfoType == HitInfoType.Empty || hi.Node != null)
                    e.Effect = DragDropEffects.Move;
                else
                    e.Effect = DragDropEffects.None;
            }
        }

        private void fld_trlstUserGroup_MouseDown(object sender, MouseEventArgs e)
        {
            downHitInfo = null;
            TreeListHitInfo hitInfo = fld_trlstUserGroup_AppStaff.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None) return;
            if (e.Button == MouseButtons.Left)
                downHitInfo = hitInfo;
        }



        private TreeListNode GetDragNode(IDataObject data)
        {
            return data.GetData(typeof(TreeListNode)) as TreeListNode;
        }

        private void fld_trlstUserGroup_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && downHitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfo.MousePoint.X - dragSize.Width / 2,
                    downHitInfo.MousePoint.Y - dragSize.Height / 2), dragSize);

                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    fld_trlstUserGroup_AppStaff.DoDragDrop(downHitInfo, DragDropEffects.All);
                    downHitInfo = null;
                }
            }
        }
        #endregion

        #region Permission Management
        /// <summary>
        /// Display user list when user group node is focused
        /// Display screens when module node is focused
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fld_trlstUserGroup_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UserManagementEntities entity = (UserManagementEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            if (e.Button == MouseButtons.Left)
            {
                HREmployeeGroupAppStaffsController objEmployeeGroupAppStaffsController = new HREmployeeGroupAppStaffsController();
                ADGroupAppStaffsController objGroupAppStaffsController = new ADGroupAppStaffsController();
                TreeListNode node = fld_trlstUserGroup_AppStaff.FocusedNode;
                if (node.Level == 1)
                {
                    //while (node.Level > 1)
                    //    node = node.ParentNode;
                    int userGroupID = Convert.ToInt32(node.Tag);
                    //ADGroupAppStaffsInfo objGroupAppStaffsInfo = (ADGroupAppStaffsInfo)objGroupAppStaffsController.GetObjectByID(userGroupID);
                    ADGroupAppStaffsInfo objGroupAppStaffsInfo = (ADGroupAppStaffsInfo)entity.GroupAppStaffsList.Where(o => o.ADGroupAppStaffID == userGroupID).FirstOrDefault();
                    if (objGroupAppStaffsInfo != null)
                    {
                        fld_lblTitleAppStaff.Text = "Phân quyền cho nhóm " + objGroupAppStaffsInfo.ADGroupAppStaffName;
                    }
                    fld_dgcADDataViewPermissionAppStaffs.Enabled = true;
                    ((UserManagementModule)Module).InvalidateAppStaff(objGroupAppStaffsInfo);
                    //Load module's screens
                }
                if (node.Level == 2)
                {
                    TreeListNode node2 = node;
                    while (node2.Level > 1)
                        node2 = node2.ParentNode;
                    int groupID = Convert.ToInt32(node2.Tag);
                    ADGroupAppStaffsInfo objGroupAppStaffsInfo = (ADGroupAppStaffsInfo)entity.GroupAppStaffsList.Where(o => o.ADGroupAppStaffID == groupID).FirstOrDefault();
                    if (objGroupAppStaffsInfo != null)
                    {
                        fld_lblTitleAppStaff.Text = "Phân quyền cho nhóm " + objGroupAppStaffsInfo.ADGroupAppStaffName;
                    }
                    fld_dgcADDataViewPermissionAppStaffs.Enabled = false;
                    //((UserManagementModule)Module).InvalidateAppStaff(objGroupAppStaffsInfo);
                }
                //if (node.Level == 2)
                //{
                //    TreeListNode node2 = node;
                //    while (node2.Level > 1)
                //        node2 = node2.ParentNode;
                //    int groupID = Convert.ToInt32(node2.Tag);
                //    int userGroupID = Convert.ToInt32(node.Tag);
                //    //HREmployeeGroupAppStaffsInfo objEmployeeGroupAppStaffsInfo = (HREmployeeGroupAppStaffsInfo)objEmployeeGroupAppStaffsController.GetObjectByID(userGroupID);
                //    HREmployeeGroupAppStaffsInfo objEmployeeGroupAppStaffsInfo = (HREmployeeGroupAppStaffsInfo)entity.EmployeeGroupAppStaffsList.Where(o => o.HREmployeeGroupAppStaffID == userGroupID).FirstOrDefault();
                //    ADGroupAppStaffsInfo objGroupAppStaffsInfo = (ADGroupAppStaffsInfo)entity.GroupAppStaffsList.Where(o => o.ADGroupAppStaffID == groupID).FirstOrDefault();                    
                //    ((UserManagementModule)Module).InvalidateAppStaff(objEmployeeGroupAppStaffsInfo, objGroupAppStaffsInfo);
                //}
            }
        }

        public void RefreshDataViewPermissionGridControlDataSource(DataTable dt)
        {
            fld_dgcADDataViewPermissionAppStaffs.RefreshDataSource(dt);
        }

        /// <summary>
        /// Load user list of the current group
        /// </summary>
        private void LoadUserList()
        {

        }

        /// <summary>
        /// Load all screens of the current module
        /// </summary>
        private void LoadModuleScreens()
        {
            STModulesInfo objModulesInfo = ((UserManagementModule)Module).CurrentModule;
            if (objModulesInfo != null)
            {
                fld_tabScreenContainer.TabPages.Clear();
                Screens.Clear();
                if (objModulesInfo.STModuleName == ModuleName.Report)
                {
                    guiReportPermission guiReportPermission = new guiReportPermission();
                    guiReportPermission.Module = Module;
                    Screens.Add(guiReportPermission.Name, guiReportPermission);
                    guiReportPermission.GetFields();
                    guiReportPermission.InitializeControls();
                    AddScreenToScreenContainer(guiReportPermission);
                }
                else if (objModulesInfo.STModuleName == ModuleName.InventoryPermission)
                {
                    guiInventoryPermission guiInventoryPermission = new guiInventoryPermission();
                    guiInventoryPermission.Module = Module;
                    Screens.Add(guiInventoryPermission.Name, guiInventoryPermission);
                    guiInventoryPermission.GetFields();
                    guiInventoryPermission.InitializeControls();
                    AddScreenToScreenContainer(guiInventoryPermission);
                }
                else
                {
                    STScreensController objScreensController = new STScreensController();
                    DataSet ds = objScreensController.GetScreenByModuleNameAndUserGroupID(objModulesInfo.STModuleName, BOSApp.UserGroupAdmin);
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            STScreensInfo objSTScreensInfo = (STScreensInfo)objScreensController.GetObjectFromDataRow(row);
                            if (objSTScreensInfo.STScreenVisible)
                            {
                                BOSERPScreen scr = BOSERPScreenFactory.GetScreen(objSTScreensInfo.STScreenNumber, (objModulesInfo.STModuleName));
                                scr.Module = Module;
                                scr.Text = objSTScreensInfo.STScreenText;
                                scr.ScreenNumber = objSTScreensInfo.STScreenNumber;
                                scr.Name = objSTScreensInfo.STScreenName;
                                scr.ScreenID = objSTScreensInfo.STScreenID;
                                Screens.Add(scr.Name, scr);
                            }
                        }
                    }

                    if (Screens.Values.Count > 0)
                    {
                        ((UserManagementModule)Module).CurrentScreen = Screens.Values[0];
                    }

                    foreach (BOSERPScreen screen in Screens.Values)
                    {
                        screen.GetFields();
                        //screen.CustomizeControls(screen.Controls);
                        InitializeControls(screen.Controls);
                        AddScreenToScreenContainer(screen);
                    }
                }
            }
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                    InitializeControls(ctrl.Controls);
            }
        }

        /// <summary>
        /// Remove the control's events and add some events for permission settings
        /// </summary>
        /// <param name="ctrl"></param>
        /// <returns></returns>
        public override Control InitializeControl(Control ctrl)
        {
            BOSControlUtil.RemoveControlEvents(ctrl);
            ctrl.Enabled = true;
            ctrl.Cursor = Cursors.Arrow;
            if (!String.IsNullOrEmpty(ctrl.Name))
            {
                if (ctrl is XtraTabPage)
                {
                    XtraTabPage tabPage = (XtraTabPage)ctrl;
                    TabPageControlPaint(tabPage);
                }
                else
                    ctrl.Paint += new PaintEventHandler(Control_Paint);
                ctrl.MouseDown += new MouseEventHandler(Control_MouseDown);
            }
            return ctrl;
        }

        /// <summary>
        /// Show context menu to allow user to set permission on tab page control
        /// </summary>
        /// <param name="tabPage">The tab page control</param>
        /// <param name="popupMenu">The popup menu</param>
        private void ShowContextMenuTabPageControl(XtraTabPage tabPage, ContextMenu popupMenu)
        {
            STFieldPermissionsController objFieldPermissionsController = new STFieldPermissionsController();
            STFieldPermissionsInfo objFieldPermissionsInfo = objFieldPermissionsController.GetFieldPermissionByUserGroupIDAndModuleNameAndScreenNameAndFieldName(
                                                                    ((UserManagementModule)Module).CurrentUserGroup.ADUserGroupID,
                                                                    ((UserManagementModule)Module).CurrentModule.STModuleName,
                                                                    ((UserManagementModule)Module).CurrentScreen.Name,
                                                                    tabPage.Name);
            if (objFieldPermissionsInfo == null || objFieldPermissionsInfo.STFieldPermissionType == Convert.ToByte(FieldPermissionType.None))
            {
                MenuItem item = popupMenu.MenuItems.Add(UserManagementLocalizedResources.Hide, new EventHandler(HideControl_Click));
                item.Tag = tabPage;
            }
            else if (objFieldPermissionsInfo.STFieldPermissionType == Convert.ToByte(FieldPermissionType.Hided))
            {
                MenuItem item = popupMenu.MenuItems.Add(UserManagementLocalizedResources.Show, new EventHandler(ShowControl_Click));
                item.Tag = tabPage;
            }
        }

        /// <summary>
        /// Show context menu to allow user to set permission on control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            Control ctrl = (Control)sender;
            if (e.Button == MouseButtons.Left)
            {
                ContextMenu popupMenu = new ContextMenu();
                if (ctrl is BOSTabControl)
                {
                    BOSTabControl tabControl = (BOSTabControl)ctrl;
                    if (tabControl.SelectedTabPageIndex >= 0)
                    {
                        XtraTabPage tabPage = tabControl.TabPages[tabControl.SelectedTabPageIndex];
                        ShowContextMenuTabPageControl(tabPage, popupMenu);
                    }
                }
                else
                {
                    STFieldPermissionsController objFieldPermissionsController = new STFieldPermissionsController();
                    STFieldPermissionsInfo objFieldPermissionsInfo = objFieldPermissionsController.GetFieldPermissionByUserGroupIDAndModuleNameAndScreenNameAndFieldName(
                                                                            ((UserManagementModule)Module).CurrentUserGroup.ADUserGroupID,
                                                                            ((UserManagementModule)Module).CurrentModule.STModuleName,
                                                                            ((UserManagementModule)Module).CurrentScreen.Name,
                                                                            ctrl.Name);

                    if (objFieldPermissionsInfo == null || objFieldPermissionsInfo.STFieldPermissionType == Convert.ToByte(FieldPermissionType.None))
                    {

                        MenuItem item = popupMenu.MenuItems.Add(UserManagementLocalizedResources.Hide, new EventHandler(HideControl_Click));
                        item.Tag = ctrl;
                        item = popupMenu.MenuItems.Add(UserManagementLocalizedResources.Disable, new EventHandler(DisableControl_Click));
                        item.Tag = ctrl;
                        if (ctrl is BOSGridControl)
                        {
                            item = popupMenu.MenuItems.Add(UserManagementLocalizedResources.ColumnPermission, new EventHandler(UpdateColumnPermission_Click));
                            item.Tag = ctrl;
                        }
                    }
                    else if (objFieldPermissionsInfo.STFieldPermissionType == Convert.ToByte(FieldPermissionType.Disabled))
                    {
                        MenuItem item = popupMenu.MenuItems.Add(UserManagementLocalizedResources.Hide, new EventHandler(HideControl_Click));
                        item.Tag = ctrl;
                        item = popupMenu.MenuItems.Add(UserManagementLocalizedResources.Enable, new EventHandler(EnableControl_Click));
                        item.Tag = ctrl;
                        if (ctrl is BOSGridControl)
                        {
                            item = popupMenu.MenuItems.Add(UserManagementLocalizedResources.ColumnPermission, new EventHandler(UpdateColumnPermission_Click));
                            item.Tag = ctrl;
                        }
                    }
                    else if (objFieldPermissionsInfo.STFieldPermissionType == Convert.ToByte(FieldPermissionType.Hided) ||
                             objFieldPermissionsInfo.STFieldPermissionType == Convert.ToByte(FieldPermissionType.HidedDisabled))
                    {

                        MenuItem item = popupMenu.MenuItems.Add(UserManagementLocalizedResources.Show, new EventHandler(ShowControl_Click));
                        item.Tag = ctrl;
                        if (ctrl is BOSGridControl)
                        {
                            item = popupMenu.MenuItems.Add(UserManagementLocalizedResources.ColumnPermission, new EventHandler(UpdateColumnPermission_Click));
                            item.Tag = ctrl;
                        }
                    }
                }
                popupMenu.Show(ctrl, new Point(e.X, e.Y));
            }
        }

        /// <summary>
        /// Redraw the control based on its permission when user resize, minimize or maximize the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Control_Paint(object sender, PaintEventArgs e)
        {
            Control ctrl = (Control)sender;
            STFieldPermissionsController objFieldPermissionController = new STFieldPermissionsController();
            STFieldPermissionsInfo objFieldPermissionsInfo = objFieldPermissionController.GetFieldPermissionByUserGroupIDAndModuleNameAndScreenNameAndFieldName(
                                                                                    ((UserManagementModule)Module).CurrentUserGroup.ADUserGroupID,
                                                                                    ((UserManagementModule)Module).CurrentModule.STModuleName,
                                                                                    ((UserManagementModule)Module).CurrentScreen.Name,
                                                                                    ctrl.Name);
            if (objFieldPermissionsInfo != null)
                DrawControl(ctrl, objFieldPermissionsInfo);
        }

        /// <summary>
        /// Tabs the page control paint
        /// </summary>
        /// <param name="tabPage">The tab page control</param>
        private void TabPageControlPaint(XtraTabPage tabPage)
        {
            STFieldPermissionsController objFieldPermissionController = new STFieldPermissionsController();
            STFieldPermissionsInfo objFieldPermissionsInfo = objFieldPermissionController.GetFieldPermissionByUserGroupIDAndModuleNameAndScreenNameAndFieldName(
                                                                        ((UserManagementModule)Module).CurrentUserGroup.ADUserGroupID,
                                                                        ((UserManagementModule)Module).CurrentModule.STModuleName,
                                                                        ((UserManagementModule)Module).CurrentScreen.Name,
                                                                        tabPage.Name);
            if (objFieldPermissionsInfo != null)
                DrawTabPageControl(tabPage, objFieldPermissionsInfo);
        }

        /// <summary>
        /// Update the permission of the control to database and redraw it to reflect the changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowControl_Click(object sender, EventArgs e)
        {
            Control ctrl = (Control)((MenuItem)sender).Tag;
            STFieldPermissionsController objFieldPermissionController = new STFieldPermissionsController();
            STFieldPermissionsInfo objFieldPermissionsInfo = objFieldPermissionController.GetFieldPermissionByUserGroupIDAndModuleNameAndScreenNameAndFieldName(
                                                                                    ((UserManagementModule)Module).CurrentUserGroup.ADUserGroupID,
                                                                                    ((UserManagementModule)Module).CurrentModule.STModuleName,
                                                                                    ((UserManagementModule)Module).CurrentScreen.Name,
                                                                                    ctrl.Name);
            if (objFieldPermissionsInfo != null)
            {
                objFieldPermissionsInfo.STFieldPermissionType = Convert.ToByte(objFieldPermissionsInfo.STFieldPermissionType & ~Convert.ToByte(FieldPermissionType.Hided));
                objFieldPermissionController.UpdateObject(objFieldPermissionsInfo);
                if (ctrl is XtraTabPage)
                {
                    XtraTabPage tabPage = (XtraTabPage)ctrl;
                    DrawTabPageControl(tabPage, objFieldPermissionsInfo);
                }
                else
                    DrawControl(ctrl, objFieldPermissionsInfo);
            }
        }

        /// <summary>
        /// Update the permission of the control to database and redraw it to reflect the changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HideControl_Click(object sender, EventArgs e)
        {
            Control ctrl = (Control)((MenuItem)sender).Tag;
            STFieldPermissionsController objFieldPermissionController = new STFieldPermissionsController();
            STFieldPermissionsInfo objFieldPermissionsInfo = objFieldPermissionController.GetFieldPermissionByUserGroupIDAndModuleNameAndScreenNameAndFieldName(
                                                                                   ((UserManagementModule)Module).CurrentUserGroup.ADUserGroupID,
                                                                                   ((UserManagementModule)Module).CurrentModule.STModuleName,
                                                                                   ((UserManagementModule)Module).CurrentScreen.Name,
                                                                                   ctrl.Name);
            if (objFieldPermissionsInfo == null)
            {
                objFieldPermissionsInfo = new STFieldPermissionsInfo();
                objFieldPermissionsInfo.FK_ADUserGroupID = ((UserManagementModule)Module).CurrentUserGroup.ADUserGroupID;
                objFieldPermissionsInfo.STModuleName = ((UserManagementModule)Module).CurrentModule.STModuleName;
                objFieldPermissionsInfo.STScreenName = ((UserManagementModule)Module).CurrentScreen.Name;
                objFieldPermissionsInfo.STFieldName = ctrl.Name;
                objFieldPermissionsInfo.STFieldPermissionType = Convert.ToByte(FieldPermissionType.Hided);
                objFieldPermissionController.CreateObject(objFieldPermissionsInfo);
            }
            else
            {
                objFieldPermissionsInfo.STFieldPermissionType = Convert.ToByte(objFieldPermissionsInfo.STFieldPermissionType | Convert.ToByte(FieldPermissionType.Hided));
                objFieldPermissionController.UpdateObject(objFieldPermissionsInfo);
            }
            if (ctrl is XtraTabPage)
            {
                XtraTabPage tabPage = (XtraTabPage)ctrl;
                DrawTabPageControl(tabPage, objFieldPermissionsInfo);
            }
            else
                DrawControl(ctrl, objFieldPermissionsInfo);
        }

        /// <summary>
        /// Update the permission of the control to database and redraw it to reflect the changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnableControl_Click(object sender, EventArgs e)
        {
            Control ctrl = (Control)((MenuItem)sender).Tag;
            STFieldPermissionsController objFieldPermissionController = new STFieldPermissionsController();
            STFieldPermissionsInfo objFieldPermissionsInfo = objFieldPermissionController.GetFieldPermissionByUserGroupIDAndModuleNameAndScreenNameAndFieldName(
                                                                                   ((UserManagementModule)Module).CurrentUserGroup.ADUserGroupID,
                                                                                   ((UserManagementModule)Module).CurrentModule.STModuleName,
                                                                                   ((UserManagementModule)Module).CurrentScreen.Name,
                                                                                   ctrl.Name);
            if (objFieldPermissionsInfo != null)
            {
                objFieldPermissionsInfo.STFieldPermissionType = Convert.ToByte(objFieldPermissionsInfo.STFieldPermissionType & ~Convert.ToByte(FieldPermissionType.Disabled));
                objFieldPermissionController.UpdateObject(objFieldPermissionsInfo);
                DrawControl(ctrl, objFieldPermissionsInfo);
            }

        }

        /// <summary>
        /// Update the permission of the control to database and redraw it to reflect the changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisableControl_Click(object sender, EventArgs e)
        {
            Control ctrl = (Control)((MenuItem)sender).Tag;
            STFieldPermissionsController objFieldPermissionController = new STFieldPermissionsController();
            STFieldPermissionsInfo objFieldPermissionsInfo = objFieldPermissionController.GetFieldPermissionByUserGroupIDAndModuleNameAndScreenNameAndFieldName(
                                                                                    ((UserManagementModule)Module).CurrentUserGroup.ADUserGroupID,
                                                                                    ((UserManagementModule)Module).CurrentModule.STModuleName,
                                                                                    ((UserManagementModule)Module).CurrentScreen.Name,
                                                                                    ctrl.Name);
            if (objFieldPermissionsInfo == null)
            {
                objFieldPermissionsInfo = new STFieldPermissionsInfo();
                objFieldPermissionsInfo.FK_ADUserGroupID = ((UserManagementModule)Module).CurrentUserGroup.ADUserGroupID;
                objFieldPermissionsInfo.STModuleName = ((UserManagementModule)Module).CurrentModule.STModuleName;
                objFieldPermissionsInfo.STScreenName = ((UserManagementModule)Module).CurrentScreen.Name;
                objFieldPermissionsInfo.STFieldName = ctrl.Name;
                objFieldPermissionsInfo.STFieldPermissionType = Convert.ToByte(FieldPermissionType.Disabled);
                objFieldPermissionController.CreateObject(objFieldPermissionsInfo);
            }
            else
            {
                objFieldPermissionsInfo.STFieldPermissionType = Convert.ToByte(objFieldPermissionsInfo.STFieldPermissionType | Convert.ToByte(FieldPermissionType.Disabled));
                objFieldPermissionController.UpdateObject(objFieldPermissionsInfo);
            }
            DrawControl(ctrl, objFieldPermissionsInfo);
        }

        /// <summary>
        /// Update permission of grid control's columns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateColumnPermission_Click(object sender, EventArgs e)
        {
            BOSGridControl gridControl = (BOSGridControl)((MenuItem)sender).Tag;
            string tableName = gridControl.BOSDataSource;
            ((UserManagementModule)Module).ShowColumnPermission(tableName);
        }

        /// <summary>
        /// Draw the control based on its permission
        /// </summary>
        /// <param name="ctrl">Control to be drawn</param>
        /// <param name="objFieldPermissionInfo">Object represents the permission of the control</param>
        private void DrawControl(Control ctrl, STFieldPermissionsInfo objFieldPermissionInfo)
        {
            if (objFieldPermissionInfo.STFieldPermissionType == Convert.ToByte(FieldPermissionType.None))
                DrawControl(ctrl, Color.White);
            if (objFieldPermissionInfo.STFieldPermissionType == Convert.ToByte(FieldPermissionType.Hided))
                DrawControl(ctrl, Color.Red);
            else if (objFieldPermissionInfo.STFieldPermissionType == Convert.ToByte(FieldPermissionType.Disabled))
                DrawControl(ctrl, Color.Gray);
            else if (objFieldPermissionInfo.STFieldPermissionType == Convert.ToByte(FieldPermissionType.HidedDisabled))
                DrawControl(ctrl, Color.Red);
        }


        /// <summary>
        /// Draws the tab page control based on its permission
        /// </summary>
        /// <param name="tabPage">The tab page to be drawn</param>
        /// <param name="objFieldPermissionInfo">Object represents the permission of the tab page control</param>
        private void DrawTabPageControl(XtraTabPage tabPage, STFieldPermissionsInfo objFieldPermissionInfo)
        {
            if (objFieldPermissionInfo == null
                    || objFieldPermissionInfo.STFieldPermissionType == Convert.ToByte(FieldPermissionType.None))
                tabPage.Appearance.Header.ForeColor = Color.Black;
            else
                tabPage.Appearance.Header.ForeColor = Color.Red;
        }

        /// <summary>
        /// Draw the control with the specified color
        /// </summary>
        /// <param name="ctrl">Control to be drawn</param>
        /// <param name="color">Color is used to draw</param>
        private void DrawControl(Control ctrl, Color color)
        {
            Graphics grph = Graphics.FromHwnd(ctrl.Parent.Handle);
            Pen pen = new Pen(color, 2);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            grph.DrawRectangle(pen, ctrl.Bounds);
        }

        /// <summary>
        /// Add the screen's controls to the screen container of this GUI
        /// </summary>
        /// <param name="screen">Screen to be added</param>
        private void AddScreenToScreenContainer(BOSERPScreen screen)
        {
            XtraTabPage tabPage = new XtraTabPage();
            tabPage.Text = screen.Text;
            tabPage.Name = screen.Name;
            tabPage.AutoScroll = true;
            //tabPage.AutoScrollMinSize = new Size(1050, 700);
            fld_tabScreenContainer.TabPages.Add(tabPage);
            InitializeScreen(screen, tabPage);
            for (int i = 0; i < screen.Controls.Count; i++)
            {
                fld_tabScreenContainer.TabPages[fld_tabScreenContainer.TabPages.Count - 1].Controls.Add(screen.Controls[i]);
                i--;
            }
        }

        /// <summary>
        /// Initialize screen in first load module
        /// </summary>
        /// <param name="screen">Current screen</param>
        /// <param name="tabPage">Currnt tab page</param>
        private void InitializeScreen(BOSERPScreen screen, XtraTabPage tabPage)
        {
            STScreenPermissionsController objScreenPermissionsController = new STScreenPermissionsController();
            STScreenPermissionsInfo objScreenPermissionsInfo = new STScreenPermissionsInfo();
            objScreenPermissionsInfo = (STScreenPermissionsInfo)objScreenPermissionsController
                .GetScreenPermissionByUserGroupIDAndModuleNameAndScreenName(
                        ((UserManagementModule)Module).CurrentUserGroup.ADUserGroupID,
                        ((UserManagementModule)Module).CurrentModule.STModuleName,
                        screen.Name);
            DrawScreen(tabPage, objScreenPermissionsInfo);
        }

        #endregion

        private void fld_btnSave_Click(object sender, EventArgs e)
        {
            ((UserManagementModule)Module).SaveFieldPermissionDataAppStaff();
            UserManagementEntities entity = (UserManagementEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            ADGroupAppStaffsController objGroupAppStaffsController = new ADGroupAppStaffsController();
            TreeListNode node = fld_trlstUserGroup_AppStaff.FocusedNode;
            if (node.Level == 1)
            {
                int userGroupID = Convert.ToInt32(node.Tag);
                ADGroupAppStaffsInfo objGroupAppStaffsInfo = (ADGroupAppStaffsInfo)entity.GroupAppStaffsList.Where(o => o.ADGroupAppStaffID == userGroupID).FirstOrDefault();
                if (objGroupAppStaffsInfo != null)
                {
                    fld_lblTitleAppStaff.Text = "Phân quyền cho nhóm " + objGroupAppStaffsInfo.ADGroupAppStaffName;
                }
                ((UserManagementModule)Module).InvalidateAppStaff(objGroupAppStaffsInfo);
            }
        }

        private void fld_tabScreenContainer_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            if (e.Page != null)
            {
                ((UserManagementModule)Module).CurrentScreen = Screens[e.Page.Name];
            }
        }

        public override void InitializeScreen()
        {
            fld_dgcADDataViewPermissionAppStaffs.Screen = this;
            fld_dgcADDataViewPermissionAppStaffs.InitializeControl();
            UserManagementEntities entity = (UserManagementEntities)((BaseModuleERP)Module).CurrentModuleEntity;
        }

        private void guiUserManagement_AppStaff_Load(object sender, EventArgs e)
        {
            //BandedGridView bandedGridView = (BandedGridView)fld_dgcADDataViewPermissionAppStaffs.MainView;

        }
    }
}