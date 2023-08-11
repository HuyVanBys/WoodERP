﻿using BOSLib;
using System.Data;


namespace BOSERP
{
    #region ADReportPermissions
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ADReportPermissionsController
    //Created Date:Friday, December 16, 2011
    //-----------------------------------------------------------

    public class ADReportPermissionsController : BaseBusinessController
    {
        public ADReportPermissionsController()
        {
            dal = new DALBaseProvider("ADReportPermissions", typeof(ADReportPermissionsInfo));
        }

        /// <summary>
        /// Get the report permission by user group id
        /// </summary>
        /// <param name="userGroupID">User group id</param>
        /// <returns>Data of the report permission</returns>
        public DataSet GetReportPermissionByUserGroupID(int userGroupID)
        {
            return dal.GetDataSet("ADReportPermissions_GetReportPermissionByUserGroupID", userGroupID);
        }
    }
    #endregion
}