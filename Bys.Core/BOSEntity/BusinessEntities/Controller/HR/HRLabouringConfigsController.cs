﻿using BOSLib;


namespace BOSERP
{
    #region HRLabouringConfigs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRLabouringConfigsController
    //Created Date:Tuesday, April 04, 2017
    //-----------------------------------------------------------

    public class HRLabouringConfigsController : BaseBusinessController
    {
        public HRLabouringConfigsController()
        {
            dal = new DALBaseProvider("HRLabouringConfigs", typeof(HRLabouringConfigsInfo));
        }
    }
    #endregion
}