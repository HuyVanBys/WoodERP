﻿using BOSLib;


namespace BOSERP
{
    #region ICProductCriteriaItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICProductCriteriaItemsController
    //Created Date:Friday, March 30, 2018
    //-----------------------------------------------------------

    public class ICProductCriteriaItemsController : BaseBusinessController
    {
        public ICProductCriteriaItemsController()
        {
            dal = new DALBaseProvider("ICProductCriteriaItems", typeof(ICProductCriteriaItemsInfo));
        }
    }
    #endregion
}