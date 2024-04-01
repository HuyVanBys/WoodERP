﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARProposalItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARProposalItemsController
    //Created Date:Friday, August 20, 2010
    //-----------------------------------------------------------

    public class ARProposalItemsController : BaseBusinessController
    {
        public ARProposalItemsController()
        {
            dal = new DALBaseProvider("ARProposalItems", typeof(ARProposalItemsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ARProposalItemsInfo> listItems = new List<ARProposalItemsInfo>();
            if (ds != null && ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARProposalItemsInfo item = (ARProposalItemsInfo)GetObjectFromDataRow(row);
                    listItems.Add(item);
                }
            }
            ds.Dispose();
            return listItems;
        }

        public List<ARProposalItemsInfo> GetProposalItemsByProposalID(int proposalID)
        {
            DataSet results = dal.GetDataSet("ARProposalItems_GetProposalItemsByProposalID", proposalID);
            return (List<ARProposalItemsInfo>)GetListFromDataSet(results);
        }

        public List<ARProposalItemsInfo> GetProposalItemsByProposalIDForReport(int proposalID)
        {
            DataSet results = dal.GetDataSet("ARProposalItems_GetProposalItemsByProposalIDForReport", proposalID);
            return (List<ARProposalItemsInfo>)GetListFromDataSet(results);
        }

        public List<ARProposalItemsInfo> GetDataSourceForRPProposalTV(int proposalID)
        {
            DataSet results = dal.GetDataSet("ARProposalItems_GetDataSourceForRPProposalTV", proposalID);
            return (List<ARProposalItemsInfo>)GetListFromDataSet(results);
        }

        public List<ARProposalItemsInfo> InvalidateModuleObject(int proposalID)
        {
            DataSet results = dal.GetDataSet("ARProposalItems_InvalidateModuleObject", proposalID);
            return (List<ARProposalItemsInfo>)GetListFromDataSet(results);
        }

        public List<ARProposalItemsInfo> GetitemForSaleOrderbyCustomerID(int customerID)
        {
            DataSet ds = dal.GetDataSet("ARProposalItems_GetitemForSaleOrderbyCustomerID", customerID);
            return (List<ARProposalItemsInfo>)GetListFromDataSet(ds);
        }

        public List<ARProposalItemsInfo> GetProposalsForOrdering()
        {
            DataSet results = dal.GetDataSet("ARProposalItems_GetProposalsForOrdering");
            return (List<ARProposalItemsInfo>)GetListFromDataSet(results);
        }
        public List<ARProposalItemsInfo> GetProposalsForOrderingBysUser(int userID)
        {
            DataSet results = dal.GetDataSet("ARProposalItems_GetProposalsForOrderingBysUser", userID);
            return (List<ARProposalItemsInfo>)GetListFromDataSet(results);
        }

        public List<ARProposalItemsInfo> GetProposalItemByIDForReportProposalLabel(int proposalID)
        {
            List<ARProposalItemsInfo> proposalItemList = new List<ARProposalItemsInfo>();
            DataSet results = dal.GetDataSet("ARProposalItems_GetProposalItemByIDForReportProposalLabel", proposalID);

            if (results.Tables.Count > 0)
            {
                foreach (DataRow row in results.Tables[0].Rows)
                {
                    ARProposalItemsInfo objProposalItemsInfo = (ARProposalItemsInfo)GetObjectFromDataRow(row);
                    proposalItemList.Add(objProposalItemsInfo);
                }
            }
            return proposalItemList;
        }
    }
    #endregion
}