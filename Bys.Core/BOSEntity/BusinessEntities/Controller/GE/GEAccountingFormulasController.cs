﻿using BOSLib;


namespace BOSERP
{
    #region GEAccountingFormulas
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:GEAccountingFormulasController
    //Created Date:04 Tháng Mười 2016
    //-----------------------------------------------------------

    public class GEAccountingFormulasController : BaseBusinessController
    {
        public GEAccountingFormulasController()
        {
            dal = new DALBaseProvider("GEAccountingFormulas", typeof(GEAccountingFormulasInfo));
        }
    }
    #endregion
}