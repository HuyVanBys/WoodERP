﻿using BOSLib;


namespace BOSERP
{
    #region ACBudgetTrackingItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACBudgetTrackingItemsController
    //Created Date:Thursday, August 02, 2018
    //-----------------------------------------------------------

    public class ACBudgetTrackingItemsController : BaseBusinessController
    {
        public ACBudgetTrackingItemsController()
        {
            dal = new DALBaseProvider("ACBudgetTrackingItems", typeof(ACBudgetTrackingItemsInfo));
        }
    }
    #endregion
}