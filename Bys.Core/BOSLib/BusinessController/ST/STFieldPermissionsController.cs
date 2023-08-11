﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region STFieldPermissions
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:STFieldPermissionsController
    //Created Date:Saturday, November 06, 2010
    //-----------------------------------------------------------

    public class STFieldPermissionsController : BaseBusinessController
    {
        public STFieldPermissionsController()
        {
            dal = new DALBaseProvider("STFieldPermissions", typeof(STFieldPermissionsInfo));
        }

        /// <summary>
        /// Get the list of field permission based on some criteria
        /// </summary>
        /// <param name="userGroupID">User group id, pass null to skip it</param>
        /// <param name="moduleName">Module name, pass null to skip it</param>
        /// <param name="fieldName">Field name, pass null to skip it</param>
        /// <param name="toolbarName">Toolbar name, pass null to skip it</param>
        /// <param name="screenName">Screen name, pass null to skip it</param>
        /// <returns></returns>
        public List<STFieldPermissionsInfo> GetFieldPermissionList(int? userGroupID,
                                              String moduleName,
                                              String fieldName,
                                              String toolbarName,
                                              String screenName)
        {
            DataSet ds = dal.GetDataSet("STFieldPermissions_GetFieldPermissionList", userGroupID, moduleName, fieldName, toolbarName, screenName);
            List<STFieldPermissionsInfo> fieldPermissions = new List<STFieldPermissionsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    STFieldPermissionsInfo objFieldPermissionsInfo = (STFieldPermissionsInfo)GetObjectFromDataRow(row);
                    fieldPermissions.Add(objFieldPermissionsInfo);
                }
            }
            ds.Dispose();
            return fieldPermissions;
        }

        /// <summary>
        /// Get field permission for a control
        /// </summary>
        /// <param name="userGroupID">User group id</param>
        /// <param name="moduleName">Module name</param>
        /// <param name="fieldName">Field name</param>
        /// <returns></returns>
        public STFieldPermissionsInfo GetFieldPermissionByUserGroupIDAndModuleNameAndScreenNameAndFieldName(int userGroupID, string moduleName, String screenName, String fieldName)
        {
            List<STFieldPermissionsInfo> fieldPermissions = GetFieldPermissionList(userGroupID, moduleName, fieldName, null, screenName);
            if (fieldPermissions.Count > 0)
            {
                return fieldPermissions[0];
            }
            return null;
        }

        /// <summary>
        /// Get permission of a toolbar button
        /// </summary>
        /// <param name="userGroupID">User group id</param>
        /// <param name="moduleName">Module name</param>
        /// <param name="toolbarName">Toolbar button name</param>
        /// <returns></returns>
        public STFieldPermissionsInfo GetFieldPermissionByUserGroupIDAndModuleNameAndToolbarName(int userGroupID, string moduleName, string toolbarName)
        {
            List<STFieldPermissionsInfo> fieldPermissions = GetFieldPermissionList(userGroupID, moduleName, null, toolbarName, null);
            if (fieldPermissions.Count > 0)
            {
                return fieldPermissions[0];
            }
            return null;
        }

        /// <summary>
        /// Get permission list of all controls of a screen
        /// </summary>
        /// <param name="userGroupID">User group id</param>
        /// <param name="moduleName">Module name</param>
        /// <param name="screenName">Name to specify the screen</param>
        /// <returns>Permission list</returns>
        public List<STFieldPermissionsInfo> GetFieldPermissionsByUserGroupIDAndModuleNameAndScreenName(int userGroupID, string moduleName, string screenName)
        {
            return GetFieldPermissionList(userGroupID, moduleName, null, null, screenName);
        }
    }
    #endregion
}