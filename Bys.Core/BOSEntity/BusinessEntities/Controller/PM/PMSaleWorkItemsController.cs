﻿using BOSLib;


namespace BOSERP
{
    #region PMSaleWorkItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:PMSaleWorkItemsController
    //Created Date:Thursday, May 17, 2018
    //-----------------------------------------------------------

    public class PMSaleWorkItemsController : BaseBusinessController
    {
        public PMSaleWorkItemsController()
        {
            dal = new DALBaseProvider("PMSaleWorkItems", typeof(PMSaleWorkItemsInfo));
        }
    }
    #endregion
}