﻿using BOSLib;
using System.Data;


namespace BOSERP
{
    #region ICTransferItemPackages
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICTransferItemPackagesController
    //Created Date:Wednesday, October 12, 2011
    //-----------------------------------------------------------

    public class ICTransferItemPackagesController : BaseBusinessController
    {
        public ICTransferItemPackagesController()
        {
            dal = new DALBaseProvider("ICTransferItemPackages", typeof(ICTransferItemPackagesInfo));
        }

        /// <summary>
        /// Get transfer item packages associated with a transfer item
        /// </summary>
        /// <param name="transferItemID">Transfer item id</param>
        /// <returns>List of transfer item packages</returns>
        public DataSet GetTransferItemPackagesByTransferItemID(int transferItemID)
        {
            return dal.GetDataSet("ICTransferItemPackages_GetTransferItemPackagesByTransferItemID", transferItemID);
        }
    }
    #endregion
}