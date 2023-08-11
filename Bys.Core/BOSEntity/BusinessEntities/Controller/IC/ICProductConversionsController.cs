﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace BOSERP
{
    #region ICProductConversions
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICProductConversionsController
    //Created Date:Monday, May 27, 2019
    //-----------------------------------------------------------

    public class ICProductConversionsController : BaseBusinessController
    {
        public ICProductConversionsController()
        {
            dal = new DALBaseProvider("ICProductConversions", typeof(ICProductConversionsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ICProductConversionsInfo> listProductConversions = new List<ICProductConversionsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICProductConversionsInfo objProductConversionsInfo = (ICProductConversionsInfo)GetObjectFromDataRow(row);
                    listProductConversions.Add(objProductConversionsInfo);
                }
            }
            ds.Dispose();
            return listProductConversions;
        }

        public DataSet GetSearchData(string productConversionNo,
                                      string productConversionName,
                                      int? employeeID,
                                      List<BRBranchsInfo> branchList,
                                      int? fromStockID,
                                      int? toStockID,
                                      DateTime? dateFrom,
                                      DateTime? dateTo)
        {
            string branchs = string.Join(",", branchList.Select(o => o.BRBranchID).ToArray());
            return dal.GetDataSet("ICProductConversions_GetSearchData", productConversionNo, productConversionName, employeeID, branchs, fromStockID, toStockID, dateFrom, dateTo);
        }

        public DataSet GetSearchData(string productConversionNo,
                                      string productConversionName,
                                      int? employeeID,
                                      int? branchID,
                                      int? fromStockID,
                                      int? toStockID,
                                      DateTime? dateFrom,
                                      DateTime? dateTo)
        {
            return dal.GetDataSet("ICProductConversions_GetSearchDataByBranchID", productConversionNo, productConversionName, employeeID, branchID, fromStockID, toStockID, dateFrom, dateTo);
        }

        public bool IsAllowCancelComplete(int productConversionID)
        {
            return (bool)dal.GetSingleValue("ICProductConversions_IsAllowCancelComplete", productConversionID);
        }
    }
    #endregion
}