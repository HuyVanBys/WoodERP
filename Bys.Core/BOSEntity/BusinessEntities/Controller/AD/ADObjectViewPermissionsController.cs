﻿using BOSLib;


namespace BOSERP
{
    #region ADObjectViewPermissions
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ADObjectViewPermissionsController
    //Created Date:Thursday, April 18, 2019
    //-----------------------------------------------------------

    public class ADObjectViewPermissionsController : BaseBusinessController
    {
        public ADObjectViewPermissionsController()
        {
            dal = new DALBaseProvider("ADObjectViewPermissions", typeof(ADObjectViewPermissionsInfo));
        }
    }
    #endregion
}