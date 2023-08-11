﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ICProductTemplateItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICProductTemplateItemsController
    //Created Date:Friday, April 26, 2019
    //-----------------------------------------------------------

    public class ICProductTemplateItemsController : BaseBusinessController
    {
        public ICProductTemplateItemsController()
        {
            dal = new DALBaseProvider("ICProductTemplateItems", typeof(ICProductTemplateItemsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ICProductTemplateItemsInfo> productTemplateItems = new List<ICProductTemplateItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICProductTemplateItemsInfo objProductTemplateItemsInfo = (ICProductTemplateItemsInfo)GetObjectFromDataRow(row);
                    productTemplateItems.Add(objProductTemplateItemsInfo);
                }
            }
            ds.Dispose();
            return productTemplateItems;
        }

        public List<ICProductTemplateItemsInfo> GetProductTemplateItemByProductTemplateID(int productTemplateID)
        {
            DataSet ds = dal.GetDataSet("ICProductTemplateItems_GetProductTemplateItemByProductTemplateID", productTemplateID);
            return (List<ICProductTemplateItemsInfo>)GetListFromDataSet(ds);
        }

        public List<ICProductTemplateItemsInfo> GetProductTemplateItemByProductID(int productID)
        {
            DataSet ds = dal.GetDataSet("ICProductTemplateItems_GetProductTemplateItemByProductID", productID);
            return (List<ICProductTemplateItemsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}