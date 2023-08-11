﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region APInvoiceInPackageItemDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APInvoiceInPackageItemDetailsController
    //Created Date:Monday, November 05, 2018
    //-----------------------------------------------------------

    public class APInvoiceInPackageItemDetailsController : BaseBusinessController
    {
        public APInvoiceInPackageItemDetailsController()
        {
            dal = new DALBaseProvider("APInvoiceInPackageItemDetails", typeof(APInvoiceInPackageItemDetailsInfo));
        }

        public List<APInvoiceInPackageItemDetailsInfo> GetPackageItemDetailsListByPackageItemID(int packageItemID)
        {
            DataSet ds = dal.GetDataSet("APInvoiceInPackageItemDetails_GetPackageItemDetailsListByPackageItemID", packageItemID);
            List<APInvoiceInPackageItemDetailsInfo> InvoiceInPackageItemDetailsList = new List<APInvoiceInPackageItemDetailsInfo>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    APInvoiceInPackageItemDetailsInfo objInvoiceInPackageItemDetailsInfo = (APInvoiceInPackageItemDetailsInfo)GetObjectFromDataRow(row);
                    InvoiceInPackageItemDetailsList.Add(objInvoiceInPackageItemDetailsInfo);
                }
            }
            return InvoiceInPackageItemDetailsList;
        }
    }
    #endregion
}