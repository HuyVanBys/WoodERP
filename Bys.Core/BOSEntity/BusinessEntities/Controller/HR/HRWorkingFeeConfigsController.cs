﻿using BOSLib;


namespace BOSERP
{
    #region HRWorkingFeeConfigs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRWorkingFeeConfigsController
    //Created Date:Wednesday, May 29, 2019
    //-----------------------------------------------------------

    public class HRWorkingFeeConfigsController : BaseBusinessController
    {
        public HRWorkingFeeConfigsController()
        {
            dal = new DALBaseProvider("HRWorkingFeeConfigs", typeof(HRWorkingFeeConfigsInfo));
        }
    }
    #endregion
}