﻿using BOSLib;


namespace BOSERP
{
    #region ICInventoryPackages
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICInventoryPackagesController
    //Created Date:Thursday, October 06, 2011
    //-----------------------------------------------------------

    public class ICInventoryPackagesController : BaseBusinessController
    {
        public ICInventoryPackagesController()
        {
            dal = new DALBaseProvider("ICInventoryPackages", typeof(ICInventoryPackagesInfo));
        }

        /// <summary>
        /// Get inventory package by package id and stock id
        /// </summary>
        /// <param name="packageID">The package id</param>
        /// <param name="stockID">The stock id</param>
        /// <returns>Info of inventory package</returns>
        public ICInventoryPackagesInfo GetInventoryPackageByPackageIDAndStockIDAndProductID(int packageID, int stockID, int productID)
        {
            return (ICInventoryPackagesInfo)dal.GetDataObject("ICInventoryPackages_SelectByPackageAndStock", packageID, stockID, productID);
        }

    }
    #endregion
}