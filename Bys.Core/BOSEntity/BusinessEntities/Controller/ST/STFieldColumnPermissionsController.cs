﻿using BOSLib;
using System.Data;


namespace BOSERP
{
    #region STFieldColumnPermissions
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:STFieldColumnPermissionsController
    //Created Date:Tuesday, November 08, 2011
    //-----------------------------------------------------------

    public class STFieldColumnPermissionsController : BaseBusinessController
    {
        public STFieldColumnPermissionsController()
        {
            dal = new DALBaseProvider("STFieldColumnPermissions", typeof(STFieldColumnPermissionsInfo));
        }

        /// <summary>
        /// Get column permission of a table by an user group
        /// </summary>        
        /// <param name="userGroupID">User group id</param>
        /// <param name="moduleName">Module name</param>
        /// <param name="tableName">Table name</param>        
        /// <returns>Column permission list</returns>
        public DataSet GetColumnPermissionByUserGroupIDAndModuleNameAndTableName(int userGroupID, string moduleName, string tableName)
        {
            return dal.GetDataSet("STFieldColumnPermissions_GetColumnPermissionByUserGroupIDAndModuleNameAndTableName", userGroupID, moduleName, tableName);
        }
    }
    #endregion
}