﻿using BOSLib;


namespace BOSERP
{
    #region ICShipmentPackageItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICShipmentPackageItemsController
    //Created Date:Thursday, November 08, 2018
    //-----------------------------------------------------------

    public class ICShipmentPackageItemsController : BaseBusinessController
    {
        public ICShipmentPackageItemsController()
        {
            dal = new DALBaseProvider("ICShipmentPackageItems", typeof(ICShipmentPackageItemsInfo));
        }
    }
    #endregion
}