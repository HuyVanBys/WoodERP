﻿using BOSLib;


namespace BOSERP
{
    #region HRTemplateStandards
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:HRTemplateStandardsController
    //Created Date:Tuesday, May 17, 2011
    //-----------------------------------------------------------

    public class HRTemplateStandardsController : BaseBusinessController
    {
        public HRTemplateStandardsController()
        {
            dal = new DALBaseProvider("HRTemplateStandards", typeof(HRTemplateStandardsInfo));
        }
    }
    #endregion
}