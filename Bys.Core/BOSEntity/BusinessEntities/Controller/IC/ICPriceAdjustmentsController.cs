﻿using BOSLib;


namespace BOSERP
{
    #region ICPriceAdjustments
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICPriceAdjustmentsController
    //Created Date:Tuesday, September 06, 2016
    //-----------------------------------------------------------

    public class ICPriceAdjustmentsController : BaseBusinessController
    {
        public ICPriceAdjustmentsController()
        {
            dal = new DALBaseProvider("ICPriceAdjustments", typeof(ICPriceAdjustmentsInfo));
        }
    }
    #endregion
}