﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region APPriceSheetItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APPriceSheetItemsController
    //Created Date:Friday, May 10, 2019
    //-----------------------------------------------------------

    public class APPriceSheetItemsController : BaseBusinessController
    {
        public APPriceSheetItemsController()
        {
            dal = new DALBaseProvider("APPriceSheetItems", typeof(APPriceSheetItemsInfo));
        }

        public List<APPriceSheetItemsInfo> GetProductPriceBelongCurrency(int productID, int currencyID, string acObjectAccessKey, DateTime purchaseOrderDate, int measureUnitID)
        {
            DataSet ds = dal.GetDataSet("APPriceSheetItems_GetProductPriceBelongCurrency", productID, currencyID, acObjectAccessKey, purchaseOrderDate, measureUnitID);
            return (List<APPriceSheetItemsInfo>)GetListFromDataSet(ds);
        }

        public APPriceSheetItemsInfo GetPriceSheetItemBySomeCriterias(int productID, int currencyID, int objectID, string objectType, DateTime purchaseOrderDate, int measureUnitID)
        {
            return (APPriceSheetItemsInfo)dal.GetDataObject("APPriceSheetItems_GetPriceSheetItemBySomeCriterias", productID, currencyID, objectID, objectType, purchaseOrderDate, measureUnitID);
        }

        public List<APPriceSheetItemsInfo> GetPriceSheetItemByPriceSheetID(int priceSheetID)
        {
            DataSet ds = dal.GetDataSet("APPriceSheetItems_GetPriceSheetItemByPriceSheetID", priceSheetID);
            return (List<APPriceSheetItemsInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<APPriceSheetItemsInfo> priceSheetItems = new List<APPriceSheetItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    APPriceSheetItemsInfo objPriceSheetItemsInfo = (APPriceSheetItemsInfo)GetObjectFromDataRow(row);
                    priceSheetItems.Add(objPriceSheetItemsInfo);
                }
            }
            return priceSheetItems;
        }
    }
    #endregion
}