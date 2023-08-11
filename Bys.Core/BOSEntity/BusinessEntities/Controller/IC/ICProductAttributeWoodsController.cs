﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ICProductAttributeWoods
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICProductAttributeWoodsController
    //Created Date:20 December 2018
    //-----------------------------------------------------------

    public class ICProductAttributeWoodsController : BaseBusinessController
    {
        public ICProductAttributeWoodsController()
        {
            dal = new DALBaseProvider("ICProductAttributeWoods", typeof(ICProductAttributeWoodsInfo));
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ICProductAttributeWoodsInfo> productGroups = new List<ICProductAttributeWoodsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICProductAttributeWoodsInfo objProductGroupsInfo = (ICProductAttributeWoodsInfo)GetObjectFromDataRow(row);
                    productGroups.Add(objProductGroupsInfo);
                }
            }
            ds.Dispose();
            return productGroups;
        }
    }
    #endregion
}