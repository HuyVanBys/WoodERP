﻿using BOSLib;


namespace BOSERP
{
    #region MMProcessItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProcessItemsController
    //Created Date:Monday, October 29, 2018
    //-----------------------------------------------------------

    public class MMProcessItemsController : BaseBusinessController
    {
        public MMProcessItemsController()
        {
            dal = new DALBaseProvider("MMProcessItems", typeof(MMProcessItemsInfo));
        }
    }
    #endregion
}