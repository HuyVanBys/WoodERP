﻿using BOSLib;


namespace BOSERP
{
    #region ACAccountingSheets
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACAccountingSheetsController
    //Created Date:Tuesday, March 11, 2014
    //-----------------------------------------------------------

    public class ACAccountingSheetsController : BaseBusinessController
    {
        public ACAccountingSheetsController()
        {
            dal = new DALBaseProvider("ACAccountingSheets", typeof(ACAccountingSheetsInfo));
        }
    }
    #endregion
}