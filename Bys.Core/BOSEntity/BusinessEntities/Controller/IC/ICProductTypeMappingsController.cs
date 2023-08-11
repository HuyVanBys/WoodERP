﻿using BOSLib;
using System.Collections.Generic;
using System.Data;

namespace BOSERP
{
    #region ICCommodityProductTypeMappings
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICCommodityProductTypeMappingsController
    //Created Date:Tuesday, January 08, 2019
    //-----------------------------------------------------------

    public class ICProductTypeMappingsController : BaseBusinessController
    {
        public ICProductTypeMappingsController()
        {
            dal = new DALBaseProvider("ICProductTypeMappings", typeof(ICProductTypeMappingsInfo));
        }
        public List<ICProductTypeMappingsInfo> GetAllProductTypeBySaleOrderType(string saleOrderType)
        {
            DataSet ds = dal.GetDataSet("ICProductTypeMappings_GetAllProductTypeBySaleOrderType", saleOrderType);
            return (List<ICProductTypeMappingsInfo>)GetListFromDataSet(ds);
        }
        public List<ICProductTypeMappingsInfo> GetListFromDataSet(DataSet ds)
        {
            List<ICProductTypeMappingsInfo> commodityMappingList = new List<ICProductTypeMappingsInfo>();
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICProductTypeMappingsInfo objProductTypeMappingsInfo = (ICProductTypeMappingsInfo)GetObjectFromDataRow(row);
                    commodityMappingList.Add(objProductTypeMappingsInfo);
                }
                ds.Dispose();
            }
            return commodityMappingList;
        }
    }
    #endregion
}