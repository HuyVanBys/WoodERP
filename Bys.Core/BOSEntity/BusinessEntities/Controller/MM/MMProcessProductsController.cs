﻿using BOSLib;


namespace BOSERP
{
    #region MMProcessProducts
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProcessProductsController
    //Created Date:Wednesday, October 31, 2018
    //-----------------------------------------------------------

    public class MMProcessProductsController : BaseBusinessController
    {
        public MMProcessProductsController()
        {
            dal = new DALBaseProvider("MMProcessProducts", typeof(MMProcessProductsInfo));
        }
    }
    #endregion
}