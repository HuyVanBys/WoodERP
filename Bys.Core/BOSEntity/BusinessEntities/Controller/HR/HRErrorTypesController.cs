﻿using BOSLib;


namespace BOSERP
{
    #region HRErrorTypes
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRErrorTypesController
    //Created Date:Monday, October 01, 2018
    //-----------------------------------------------------------

    public class HRErrorTypesController : BaseBusinessController
    {
        public HRErrorTypesController()
        {
            dal = new DALBaseProvider("HRErrorTypes", typeof(HRErrorTypesInfo));
        }
    }
    #endregion
}