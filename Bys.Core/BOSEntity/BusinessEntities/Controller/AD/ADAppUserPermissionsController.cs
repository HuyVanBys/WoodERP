﻿using BOSLib;


namespace BOSERP
{
    #region ADAppUserPermissions
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ADAppUserPermissionsController
    //Created Date:Wednesday, September 19, 2018
    //-----------------------------------------------------------

    public class ADAppUserPermissionsController : BaseBusinessController
    {
        public ADAppUserPermissionsController()
        {
            dal = new DALBaseProvider("ADAppUserPermissions", typeof(ADAppUserPermissionsInfo));
        }
    }
    #endregion
}