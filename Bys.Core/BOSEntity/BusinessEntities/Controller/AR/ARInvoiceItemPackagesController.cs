﻿using BOSLib;


namespace BOSERP
{
    #region ARInvoiceItemPackages
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARInvoiceItemPackagesController
    //Created Date:Wednesday, October 19, 2011
    //-----------------------------------------------------------

    public class ARInvoiceItemPackagesController : BaseBusinessController
    {
        public ARInvoiceItemPackagesController()
        {
            dal = new DALBaseProvider("ARInvoiceItemPackages", typeof(ARInvoiceItemPackagesInfo));
        }
    }
    #endregion
}