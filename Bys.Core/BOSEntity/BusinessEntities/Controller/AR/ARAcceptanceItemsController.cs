﻿using BOSLib;
using System.Collections.Generic;
using System.Data;

namespace BOSERP
{
    #region ARAcceptanceItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARAcceptanceItemsController
    //Created Date:10 Tháng Năm 2018
    //-----------------------------------------------------------

    public class ARAcceptanceItemsController : BaseBusinessController
    {
        public ARAcceptanceItemsController()
        {
            dal = new DALBaseProvider("ARAcceptanceItems", typeof(ARAcceptanceItemsInfo));
        }

        public List<ARAcceptanceItemsInfo> GetAcceptanceItemsByAcceptanceID(int acceptanceID)
        {
            DataSet ds = dal.GetDataSet("ARAcceptanceItems_GetAcceptanceItemsByAcceptanceID", acceptanceID);
            List<ARAcceptanceItemsInfo> acceptanceItemsList = new List<ARAcceptanceItemsInfo>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ARAcceptanceItemsInfo objAcceptanceItemsInfo = (ARAcceptanceItemsInfo)GetObjectFromDataRow(dr);
                    acceptanceItemsList.Add(objAcceptanceItemsInfo);
                }
            }
            return acceptanceItemsList;
        }

        public List<ARAcceptanceItemsInfo> GetAcceptanceItemsByAcceptanceIDToBalanceSheetReport(int acceptanceID)
        {
            List<ARAcceptanceItemsInfo> acceptanceItemsList = new List<ARAcceptanceItemsInfo>();
            DataSet ds = dal.GetDataSet("ARAcceptanceItems_GetAcceptanceItemsByAcceptanceIDToBalanceSheetReport", acceptanceID);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARAcceptanceItemsInfo objAcceptanceItemsInfo = (ARAcceptanceItemsInfo)GetObjectFromDataRow(row);
                    acceptanceItemsList.Add(objAcceptanceItemsInfo);
                }
            }
            return acceptanceItemsList;
        }

        public List<ARAcceptanceItemsInfo> GetAcceptanceItemsForReportByAcceptanceID(int acceptanceID)
        {
            DataSet ds = dal.GetDataSet("ARAcceptanceItems_GetAcceptanceItemsForReportByAcceptanceID", acceptanceID);
            List<ARAcceptanceItemsInfo> acceptanceItemsList = new List<ARAcceptanceItemsInfo>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ARAcceptanceItemsInfo objAcceptanceItemsInfo = (ARAcceptanceItemsInfo)GetObjectFromDataRow(dr);
                    acceptanceItemsList.Add(objAcceptanceItemsInfo);
                }
            }
            return acceptanceItemsList;
        }


        public List<ARAcceptanceItemsInfo> GetListItemForPrintMultiAcceptance(string acceptanceID, int companyID)
        {
            DataSet ds = dal.GetDataSet("ARAcceptanceItems_GetListItemForPrintMultiOrder", acceptanceID, companyID);
            List<ARAcceptanceItemsInfo> acceptanceItemsList = new List<ARAcceptanceItemsInfo>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ARAcceptanceItemsInfo objAcceptanceItemsInfo = (ARAcceptanceItemsInfo)GetObjectFromDataRow(dr);
                    acceptanceItemsList.Add(objAcceptanceItemsInfo);
                }
            }
            return acceptanceItemsList;
        }

        public List<ARAcceptanceItemsInfo> GetAcceptanceItemsByAcceptanceIDForInvoice(int acceptanceID)
        {
            DataSet ds = dal.GetDataSet("ARAcceptanceItems_GetAcceptanceItemsByAcceptanceIDForInvoice", acceptanceID);
            return (List<ARAcceptanceItemsInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ARAcceptanceItemsInfo> acceptanceItemList = new List<ARAcceptanceItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARAcceptanceItemsInfo objAcceptanceItemsInfo = (ARAcceptanceItemsInfo)GetObjectFromDataRow(row);
                    acceptanceItemList.Add(objAcceptanceItemsInfo);
                }
            }
            ds.Dispose();
            return acceptanceItemList;
        }
    }
    #endregion
}