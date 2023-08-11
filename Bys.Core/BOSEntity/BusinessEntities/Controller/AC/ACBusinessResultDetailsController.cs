﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ACBusinessResultDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACBusinessResultDetailsController
    //Created Date:Wednesday, March 12, 2014
    //-----------------------------------------------------------

    public class ACBusinessResultDetailsController : BaseBusinessController
    {
        public ACBusinessResultDetailsController()
        {
            dal = new DALBaseProvider("ACBusinessResultDetails", typeof(ACBusinessResultDetailsInfo));
        }

        public decimal GetValueBusinessResultDetails(int businessResultID, String accountNo)
        {
            return Convert.ToDecimal(dal.GetSingleValue("ACBusinessResultDetails_GetValueBusinessResultDetails", businessResultID, accountNo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ACBusinessResultDetailsInfo> list = new List<ACBusinessResultDetailsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ACBusinessResultDetailsInfo obj = (ACBusinessResultDetailsInfo)GetObjectFromDataRow(row);
                    list.Add(obj);
                }
            }
            ds.Dispose();
            return list;
        }

        public List<ACBusinessResultDetailsInfo> GetBusinessResultDetails(DateTime? businessResultFromDate
            , DateTime? businessResultToDate
            , DateTime? businessResultOpeningFromDate
            , DateTime? businessResultOpeningToDate
            , int? branchID
            , int? branchCentralID)
        {
            List<ACBusinessResultDetailsInfo> results = new List<ACBusinessResultDetailsInfo>();
            DataSet ds = dal.GetDataSet("ACBusinessResultDetails_GetBusinessResultDetails", businessResultFromDate
                                        , businessResultToDate
                                        , businessResultOpeningFromDate
                                        , businessResultOpeningToDate
                                        , branchID
                                        , branchCentralID);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                    results.Add((ACBusinessResultDetailsInfo)GetObjectFromDataRow(row));
            }
            return results;
        }
    }
    #endregion
}