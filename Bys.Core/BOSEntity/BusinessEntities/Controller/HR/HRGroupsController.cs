﻿using BOSLib;


namespace BOSERP
{
    #region HRGroups
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRGroupsController
    //Created Date:20 Tháng Sáu 2018
    //-----------------------------------------------------------

    public class HRGroupsController : BaseBusinessController
    {
        public HRGroupsController()
        {
            dal = new DALBaseProvider("HRGroups", typeof(HRGroupsInfo));
        }
    }
    #endregion
}