﻿using BOSLib;


namespace BOSERP
{
    #region HRBonusSales
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRBonusSalesController
    //Created Date:Thursday, February 14, 2019
    //-----------------------------------------------------------

    public class HRBonusSalesController : BaseBusinessController
    {
        public HRBonusSalesController()
        {
            dal = new DALBaseProvider("HRBonusSales", typeof(HRBonusSalesInfo));
        }
    }
    #endregion
}