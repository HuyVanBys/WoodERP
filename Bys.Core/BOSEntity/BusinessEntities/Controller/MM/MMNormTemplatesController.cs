﻿using BOSLib;


namespace BOSERP
{
    #region MMNormTemplates
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMNormTemplatesController
    //Created Date:Tuesday, November 06, 2018
    //-----------------------------------------------------------

    public class MMNormTemplatesController : BaseBusinessController
    {
        public MMNormTemplatesController()
        {
            dal = new DALBaseProvider("MMNormTemplates", typeof(MMNormTemplatesInfo));
        }
    }
    #endregion
}