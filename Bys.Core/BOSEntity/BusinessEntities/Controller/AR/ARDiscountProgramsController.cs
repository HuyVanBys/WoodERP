﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARDiscountPrograms
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARDiscountProgramsController
    //Created Date:Friday, July 19, 2019
    //-----------------------------------------------------------

    public class ARDiscountProgramsController : BaseBusinessController
    {
        public ARDiscountProgramsController()
        {
            dal = new DALBaseProvider("ARDiscountPrograms", typeof(ARDiscountProgramsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ARDiscountProgramsInfo> discountProgramsList = new List<ARDiscountProgramsInfo>();
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARDiscountProgramsInfo objDiscountProgramsInfo = (ARDiscountProgramsInfo)GetObjectFromDataRow(row);
                    discountProgramsList.Add(objDiscountProgramsInfo);
                }
            }
            ds.Dispose();
            return discountProgramsList;
        }

        public List<ARDiscountProgramsInfo> GetDiscountProgramForSaleOrder(int distributionChannelID, DateTime toDate)
        {
            DataSet ds = dal.GetDataSet("ARDiscountPrograms_GetDiscountProgramForSaleOrder", distributionChannelID, toDate);
            return (List<ARDiscountProgramsInfo>)GetListFromDataSet(ds);
        }

        public List<ARDiscountProgramsInfo> GetDiscountProgramForSaleOrder(int? branchID, int? distributionChannelID, int objectID, string objectType, DateTime toDate)
        {
            DataSet ds = dal.GetDataSet("ARDiscountPrograms_GetDiscountProgramForSaleOrder", branchID, distributionChannelID, objectID, objectType, toDate);
            return (List<ARDiscountProgramsInfo>)GetListFromDataSet(ds);
        }

        public List<ARDiscountProgramsInfo> GetDiscountProgramForCalculate(string discountProgramNo
                                                                          , string discountProgramName
                                                                          , int customerDistributionChannelID
                                                                          , int objectID
                                                                          , string objectType
                                                                          , DateTime fromDate
                                                                          , DateTime toDate)
        {
            DataSet ds = dal.GetDataSet("ARDiscountPrograms_GetDiscountProgramForCalculate", discountProgramNo, discountProgramName, customerDistributionChannelID, objectID, objectType, fromDate, toDate);
            return (List<ARDiscountProgramsInfo>)GetListFromDataSet(ds);
        }

        public DataSet GetDataSetDiscountProgramListByListBranch(string billOfLadingNo,
                                           int? acObjectID,
                                           string acObjectType,
                                           DateTime? dateFrom,
                                           DateTime? dateTo,
                                           List<BRBranchsInfo> branchList)
        {
            DataSet rtn = new DataSet();
            foreach (BRBranchsInfo ojbBranchsInfo in branchList)
            {
                DataSet ds = GetDataSetDiscountProgramListByBranchID(billOfLadingNo, acObjectID, acObjectType, dateFrom, dateTo, ojbBranchsInfo.BRBranchID);
                rtn.Merge(ds);
            }

            return rtn;
        }

        public DataSet GetDataSetDiscountProgramListByBranchID(string billOfLadingNo,
                                            int? acObjectID,
                                            string acObjectType,
                                            DateTime? dateFrom,
                                            DateTime? dateTo,
                                            int? branchID)
        {
            DataSet ds = dal.GetDataSet("ARDiscountPrograms_GetDataSetDiscountProgramListByBranchID", billOfLadingNo, acObjectID, acObjectType, dateFrom, dateTo, branchID);
            return ds;
        }

        public ARDiscountProgramsInfo CheckDiscoutCodeExists(string code, DateTime fromDate, DateTime toDate)
        {
            DataSet ds = dal.GetDataSet("ARDiscountPrograms_CheckDiscountCode", code, fromDate, toDate);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return (ARDiscountProgramsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            return null;
        }
    }
    #endregion
}