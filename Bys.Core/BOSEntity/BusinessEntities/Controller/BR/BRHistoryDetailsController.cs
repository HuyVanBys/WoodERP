﻿using BOSLib;


namespace BOSERP
{
    #region BRHistoryDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:BRHistoryDetailsController
    //Created Date:Friday, April 01, 2016
    //-----------------------------------------------------------

    public class BRHistoryDetailsController : BaseBusinessController
    {
        public BRHistoryDetailsController()
        {
            dal = new DALBaseProvider("BRHistoryDetails", typeof(BRHistoryDetailsInfo));
        }
    }
    #endregion
}