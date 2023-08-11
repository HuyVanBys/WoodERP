﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region APPOPackageItemDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APPOPackageItemDetailsController
    //Created Date:Friday, November 02, 2018
    //-----------------------------------------------------------

    public class APPOPackageItemDetailsController : BaseBusinessController
    {
        public APPOPackageItemDetailsController()
        {
            dal = new DALBaseProvider("APPOPackageItemDetails", typeof(APPOPackageItemDetailsInfo));
        }

        public List<APPOPackageItemDetailsInfo> GetPackageItemDetailsListByPackageItemID(int packageItemID)
        {
            DataSet ds = dal.GetDataSet("APPOPackageItemDetails_GetPackageItemDetailsListByPackageItemID", packageItemID);
            List<APPOPackageItemDetailsInfo> ProductPackageItemDetailsList = new List<APPOPackageItemDetailsInfo>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    APPOPackageItemDetailsInfo objPOPackageItemDetailsInfo = (APPOPackageItemDetailsInfo)GetObjectFromDataRow(row);
                    ProductPackageItemDetailsList.Add(objPOPackageItemDetailsInfo);
                }
            }
            return ProductPackageItemDetailsList;
        }
    }
    #endregion
}