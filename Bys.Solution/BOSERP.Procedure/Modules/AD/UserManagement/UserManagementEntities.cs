using BOSCommon.Constants;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.UserManagement
{
    public class UserManagementEntities : ERPModuleEntities
    {
        #region Declare Constant
        #endregion

        #region Declare all entities variables
        #endregion

        #region Public Properties
        public BOSList<ADUsersInfo> ADUserList { get; set; }
        public BOSTreeList STToolbarsTreeList { get; set; }
        /// <summary>
        /// Gets or sets column permission list of a table
        /// </summary>
        public BOSList<STFieldColumnPermissionsInfo> STFieldColumnPermissionList { get; set; }
        /// <summary>
        /// Gets or sets report list
        /// </summary>
        public BOSList<ADReportPermissionsInfo> ReportPermissionsList { get; set; }
        /// <summary>
        /// Gets or sets stock list
        /// </summary>
        public BOSList<ICInventoryPermissionsInfo> InventoryPermissionsList { get; set; }
        //public BOSList<ADDataViewPermissionAppStaffsInfo> DataViewPermissionAppStaffsList { get; set; }
        public List<HREmployeeGroupAppStaffsInfo> EmployeeGroupAppStaffsList { get; set; }
        public List<ADGroupAppStaffsInfo> GroupAppStaffsList { get; set; }
        public BOSList<ADGroupTimeSheetPermissionsInfo> GroupTimeSheetPermissionList { get; set; }
        #endregion

        #region Constructor
        public UserManagementEntities()
        {
            ADUserList = new BOSList<ADUsersInfo>();
            STToolbarsTreeList = new BOSTreeList();
            STFieldColumnPermissionList = new BOSList<STFieldColumnPermissionsInfo>();
            ReportPermissionsList = new BOSList<ADReportPermissionsInfo>();
            InventoryPermissionsList = new BOSList<ICInventoryPermissionsInfo>();
            //DataViewPermissionAppStaffsList = new BOSList<ADDataViewPermissionAppStaffsInfo>();
            GroupTimeSheetPermissionList = new BOSList<ADGroupTimeSheetPermissionsInfo>();
        }
        #endregion

        #region Module Objects functions
        public override void InitModuleObjects()
        {
            ModuleObjects.Add(TableName.ADUsersTableName, new ADUsersInfo());
            ModuleObjects.Add(TableName.STFieldColumnPermissionsTableName, new STFieldColumnPermissionsInfo());
            ModuleObjects.Add(TableName.ADDataViewPermissionAppStaffsTableName, new ADDataViewPermissionAppStaffsInfo());
        }

        public override void InitModuleObjectList()
        {
            ADUserList.InitBOSList(this, string.Empty, TableName.ADUsersTableName, BOSList<ADUsersInfo>.cstRelationNone);
            STFieldColumnPermissionList.InitBOSList(this, string.Empty, TableName.STFieldColumnPermissionsTableName,
                                                    BOSList<STFieldColumnPermissionsInfo>.cstRelationNone);

            ReportPermissionsList.InitBOSList(this, string.Empty, TableName.ADReportPermissionsTableName, BOSList<ADReportPermissionsInfo>.cstRelationNone);
            InventoryPermissionsList.InitBOSList(this, string.Empty, TableName.ICInventoryPermissionsTableName, BOSList<ICInventoryPermissionsInfo>.cstRelationNone);
            GroupTimeSheetPermissionList.InitBOSList(this, string.Empty, TableName.ADGroupTimeSheetPermissionsTableName, BOSList<ADGroupTimeSheetPermissionsInfo>.cstRelationNone);

            STToolbarsTreeList.InitBOSList(this,
                                            TableName.STModulesTableName,
                                            TableName.STToolbarsTableName,
                                            BOSTreeList.cstRelationForeign);
            STToolbarsTreeList.ItemTableForeignKey = "STModuleID";
            //DataViewPermissionAppStaffsList.InitBOSList(this,
            //                                            TableName.ADDataViewPermissionAppStaffsTableName,
            //                                            TableName.ADDataViewPermissionAppStaffsTableName,
            //                                           BOSList<ADDataViewPermissionAppStaffsInfo>.cstRelationNone);
        }
        public override void InitGridControlInBOSList()
        {
            STToolbarsTreeList.InitBOSTreeListControl();
            //DataViewPermissionAppStaffsList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                STToolbarsTreeList.SetDefaultListAndRefreshTreeListControl();
            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion

        #region Save Module Objects functions
        public override void SaveModuleObjects()
        {

        }

        public void SaveUser()
        {
            ADUsersController objUsersController = new ADUsersController();
            ADUsersInfo objUsersInfo = (ADUsersInfo)ModuleObjects[TableName.ADUsersTableName];
            ADUserLocationsController objUserLocationsController = new ADUserLocationsController();
            if (objUsersInfo.ADUserID == 0)
            {
                objUsersInfo.ADUserStyle = "Skin";
                objUsersInfo.ADUserStyleSkin = "Black";
                objUsersController.CreateUser(objUsersInfo);
                ADUserLocationsInfo objUserLocationsInfo = new ADUserLocationsInfo();
                objUserLocationsInfo.FK_ADUserID = objUsersInfo.ADUserID;
                objUserLocationsInfo.ADUserLocationLastDate = BOSApp.GetCurrentServerDate();
                objUserLocationsController.CreateObject(objUserLocationsInfo);
            }
            else
            {
                objUsersController.UpdateUser(objUsersInfo, true);
            }
        }

        public void DeleteUser(int userID)
        {
            ADUsersController objUsersController = new ADUsersController();
            objUsersController.DeleteObject(userID);
        }

        /// <summary>
        /// Save field premission 
        /// </summary>
        /// <param name="userGroupID">User group id</param>
        /// <param name="moduleName">Module name</param>
        public void SaveFieldPermission(int userGroupID, string moduleName)
        {
            SaveFieldPermission(STToolbarsTreeList, userGroupID, moduleName);
        }

        /// <summary>
        /// Save field permission. 
        /// The function is called recursively for toolbar tree list
        /// </summary>
        /// <param name="toolbarTreeList">Toolbar tree list</param>
        /// <param name="userGroupID">User group id</param>
        /// <param name="moduleName">Module name</param>
        private void SaveFieldPermission(IBOSTreeList toolbarTreeList, int userGroupID, string moduleName)
        {
            STFieldPermissionsController objFieldPermissionsController = new STFieldPermissionsController();
            STToolbarsController objToolbarsController = new STToolbarsController();
            for (int i = 0; i < toolbarTreeList.Count; i++)
            {
                STToolbarsInfo objToolbarsInfo = toolbarTreeList[i] as STToolbarsInfo;
                STFieldPermissionsInfo objFieldPermissionsInfo = objFieldPermissionsController.GetFieldPermissionByUserGroupIDAndModuleNameAndToolbarName(
                                                                                                        userGroupID,
                                                                                                        moduleName,
                                                                                                        objToolbarsInfo.STToolbarName);
                if (objFieldPermissionsInfo != null)
                {
                    if (objToolbarsInfo.SubList != null 
                        && objToolbarsInfo.SubList.Count > 0
                        && objToolbarsInfo.SubList.Where(o => o.Selected == true).FirstOrDefault() != null)
                    {
                        toolbarTreeList[i].Selected = true;
                    }    
                    if (toolbarTreeList[i].Selected)
                    {
                        objFieldPermissionsInfo.STFieldPermissionType = (int)FieldPermissionType.None;
                    }    
                    else
                    {
                        objFieldPermissionsInfo.STFieldPermissionType = (int)FieldPermissionType.Hided;
                    }   
                    objFieldPermissionsController.UpdateObject(objFieldPermissionsInfo);
                }
                else
                {
                    if (objToolbarsInfo.SubList != null
                       && objToolbarsInfo.SubList.Count > 0
                       && objToolbarsInfo.SubList.Where(o => o.Selected == true).FirstOrDefault() != null)
                    {
                        toolbarTreeList[i].Selected = true;
                    }

                    objFieldPermissionsInfo = new STFieldPermissionsInfo();
                    objFieldPermissionsInfo.FK_ADUserGroupID = userGroupID;
                    objFieldPermissionsInfo.STModuleName = moduleName;
                    objFieldPermissionsInfo.STToolbarName = objToolbarsInfo.STToolbarName;
                    if (toolbarTreeList[i].Selected)
                        objFieldPermissionsInfo.STFieldPermissionType = (int)FieldPermissionType.None;
                    else
                        objFieldPermissionsInfo.STFieldPermissionType = (int)FieldPermissionType.Hided;
                    objFieldPermissionsController.CreateObject(objFieldPermissionsInfo);
                }

                if (objToolbarsInfo.SubList != null && objToolbarsInfo.SubList.Count > 0)
                {
                    SaveFieldPermission(objToolbarsInfo.SubList, userGroupID, moduleName);
                }
            }
        }

        /// <summary>
        /// Save column permission
        /// </summary>
        /// <param name="tableName">Table name of grid control</param>
        /// <param name="userGroupID">Current user group id</param>
        /// <param name="moduleName">Current module name</param>
        public void SaveColumnPermissionList(string tableName, int userGroupID, string moduleName)
        {
            foreach (STFieldColumnPermissionsInfo objFieldColumnPermissionsInfo in STFieldColumnPermissionList)
            {
                objFieldColumnPermissionsInfo.STTableName = tableName;
                objFieldColumnPermissionsInfo.FK_ADUserGroupID = userGroupID;
                objFieldColumnPermissionsInfo.STModuleName = moduleName;
                if (objFieldColumnPermissionsInfo.IsCheck)
                    objFieldColumnPermissionsInfo.STFieldColumnPermissionType = Convert.ToByte(FieldPermissionType.Hided);
                else
                    objFieldColumnPermissionsInfo.STFieldColumnPermissionType = Convert.ToByte(FieldPermissionType.None);
            }
            STFieldColumnPermissionList.SaveItemObjects();
        }

        /// <summary>
        /// Save report permission
        /// </summary>
        /// <param name="userGroupID">User group ID</param>
        public void SaveReportPermission(int userGroupID)
        {
            ADReportPermissionsController objReportPermissionsController = new ADReportPermissionsController();
            foreach (ADReportPermissionsInfo objReportPermissionsInfo in ReportPermissionsList)
            {
                //Set value for report permission
                objReportPermissionsInfo.FK_ADReportID = objReportPermissionsInfo.ADReportID;
                objReportPermissionsInfo.FK_ADUserGroupID = userGroupID;
                if (objReportPermissionsInfo.Selected)
                    objReportPermissionsInfo.ADReportPermissionType = Convert.ToByte(FieldPermissionType.None);
                else
                    objReportPermissionsInfo.ADReportPermissionType = Convert.ToByte(FieldPermissionType.Hided);

                //Create or update report permission
                if (objReportPermissionsInfo.ADReportPermissionID > 0)
                    objReportPermissionsController.UpdateObject(objReportPermissionsInfo);
                else
                    objReportPermissionsController.CreateObject(objReportPermissionsInfo);
            }
        }

        //[NKVung]  [Group Time Sheet Permissions]  [START]
        public void SaveGroupTimeSheetPermission(int userGroupID)
        {
            ADGroupTimeSheetPermissionsController objReportPermissionsController = new ADGroupTimeSheetPermissionsController();
            foreach (ADGroupTimeSheetPermissionsInfo objGroupTimeSheetPermissionsInfo in GroupTimeSheetPermissionList)
            {
                //Set value for group time sheet permission
                objGroupTimeSheetPermissionsInfo.FK_HREmployeePayrollFormulaID = objGroupTimeSheetPermissionsInfo.HREmployeePayrollFormulaID;
                objGroupTimeSheetPermissionsInfo.FK_ADUserGroupID = userGroupID;
                if (objGroupTimeSheetPermissionsInfo.Selected)
                    objGroupTimeSheetPermissionsInfo.ADGroupTimeSheetPermissionType = Convert.ToByte(FieldPermissionType.None);
                else
                    objGroupTimeSheetPermissionsInfo.ADGroupTimeSheetPermissionType = Convert.ToByte(FieldPermissionType.Hided);

                //Create or update group time sheet permission
                if (objGroupTimeSheetPermissionsInfo.ADGroupTimeSheetPermissionID > 0)
                    objReportPermissionsController.UpdateObject(objGroupTimeSheetPermissionsInfo);
                else
                    objReportPermissionsController.CreateObject(objGroupTimeSheetPermissionsInfo);
            }
        }
        //[NKVung]  [Group Time Sheet Permissions]  [END]

        /// <summary>
        /// Save inventory permission
        /// </summary>
        /// <param name="userGroupID">User group ID</param>
        public void SaveInventoryPermission(int userGroupID)
        {
            ICInventoryPermissionsController objInventoryPermissionsController = new ICInventoryPermissionsController();
            foreach (ICInventoryPermissionsInfo objInventoryPermissionsInfo in InventoryPermissionsList)
            {
                //Set value for report permission
                objInventoryPermissionsInfo.FK_ICStockID = objInventoryPermissionsInfo.ICStockID;
                objInventoryPermissionsInfo.FK_ADUserGroupID = userGroupID;
                if (objInventoryPermissionsInfo.Selected)
                    objInventoryPermissionsInfo.ICInventoryPermissionType = Convert.ToByte(FieldPermissionType.None);
                else
                    objInventoryPermissionsInfo.ICInventoryPermissionType = Convert.ToByte(FieldPermissionType.Hided);

                //Creat or update report permission
                if (objInventoryPermissionsInfo.ICInventoryPermissionID > 0)
                    objInventoryPermissionsController.UpdateObject(objInventoryPermissionsInfo);
                else
                    objInventoryPermissionsController.CreateObject(objInventoryPermissionsInfo);
            }
        }
        #endregion
    }
}
