﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMInProgressStatisticDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMInProgressStatisticDetailsController
    //Created Date:Thursday, September 27, 2018
    //-----------------------------------------------------------

    public class MMInProgressStatisticDetailsController : BaseBusinessController
    {
        public MMInProgressStatisticDetailsController()
        {
            dal = new DALBaseProvider("MMInProgressStatisticDetails", typeof(MMInProgressStatisticDetailsInfo));
        }

        public List<MMInProgressStatisticDetailsInfo> GetInProgressDetailQtyForProductionCost(DateTime fromDate, int formulaID)
        {
            List<MMInProgressStatisticDetailsInfo> invoices = new List<MMInProgressStatisticDetailsInfo>();
            DataSet ds = dal.GetDataSet("MMInProgressStatisticDetails_GetInProgressDetailQtyForProductionCost", fromDate, formulaID);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMInProgressStatisticDetailsInfo objInvoicesInfo = (MMInProgressStatisticDetailsInfo)GetObjectFromDataRow(row);
                    invoices.Add(objInvoicesInfo);
                }
            }
            ds.Dispose();
            return invoices;
        }

        public List<MMInProgressStatisticDetailsInfo> GetInProgressDetailByDate(DateTime fromDate)
        {
            List<MMInProgressStatisticDetailsInfo> objList = new List<MMInProgressStatisticDetailsInfo>();
            DataSet ds = dal.GetDataSet("MMInProgressStatisticDetails_GetInProgressDetailByDate", fromDate);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMInProgressStatisticDetailsInfo objDetail = (MMInProgressStatisticDetailsInfo)GetObjectFromDataRow(row);
                    objList.Add(objDetail);
                }
            }
            ds.Dispose();
            return objList;
        }

        public List<MMInProgressStatisticDetailsInfo> GetInProgressDetailNotIDByDate(int InProgressStatisticID, DateTime fromDate)
        {
            List<MMInProgressStatisticDetailsInfo> objList = new List<MMInProgressStatisticDetailsInfo>();
            DataSet ds = dal.GetDataSet("MMInProgressStatisticDetails_GetInProgressDetailNotIDByDate", InProgressStatisticID, fromDate);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMInProgressStatisticDetailsInfo objDetail = (MMInProgressStatisticDetailsInfo)GetObjectFromDataRow(row);
                    objList.Add(objDetail);
                }
            }
            ds.Dispose();
            return objList;
        }

        public List<MMInProgressStatisticDetailsInfo> GetInProgressDetailNotIDByDateAndClassifyType(int InProgressStatisticID, int productionCostFormulaID, string InProgressClassifyType, DateTime fromDate)
        {
            List<MMInProgressStatisticDetailsInfo> objList = new List<MMInProgressStatisticDetailsInfo>();
            DataSet ds = dal.GetDataSet("MMInProgressStatisticDetails_GetInProgressDetailNotIDByDateAndClassifyType", InProgressStatisticID, productionCostFormulaID, InProgressClassifyType, fromDate);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMInProgressStatisticDetailsInfo objDetail = (MMInProgressStatisticDetailsInfo)GetObjectFromDataRow(row);
                    objList.Add(objDetail);
                }
            }
            ds.Dispose();
            return objList;
        }

    }
    #endregion
}