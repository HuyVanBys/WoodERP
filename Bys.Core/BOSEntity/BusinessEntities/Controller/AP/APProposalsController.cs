﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region APProposals
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APProposalsController
    //Created Date:Friday, September 16, 2011
    //-----------------------------------------------------------

    public class APProposalsController : BaseBusinessController
    {
        public APProposalsController()
        {
            dal = new DALBaseProvider("APProposals", typeof(APProposalsInfo));
        }
        public DataSet GetAllProposalsForLookupControl()
        {
            DataSet ds = dal.GetDataSet("APProposals_GetAllAPProposalsForLookupControl");
            return ds;
        }
        /// <summary>
        /// Get proposal list based on some criteria
        /// </summary>
        /// <param name="proposalNo">Proposal no</param>
        /// <param name="branchID">Branch id</param>
        /// <param name="proposalType">Proposal type</param>
        /// <param name="proposalStatus">Proposal status</param>
        /// <param name="fromDate">Date the result is filtered from</param>
        /// <param name="toDate">Date the result is filtered to</param>
        /// <returns>List of proposals</returns>
        public List<APProposalsInfo> GetProposalList(
                                                string proposalNo,
                                                int? branchID,
                                                string proposalType,
                                                string proposalStatus,
                                                DateTime? fromDate,
                                                DateTime? toDate)
        {
            DataSet ds = dal.GetDataSet("APProposals_GetProposalList",
                                        proposalNo,
                                        branchID,
                                        proposalType,
                                        proposalStatus,
                                        fromDate,
                                        toDate);
            return (List<APProposalsInfo>)GetListFromDataSet(ds);
        }


        /// <summary>
        /// Get proposal list based on some criteria
        /// </summary>
        /// <param name="fromDate">Date the result is filtered from</param>
        /// <param name="toDate">Date the result is filtered to</param>
        /// <returns>List of proposals</returns>
        public List<APProposalsInfo> GetProposalList(DateTime? fromDate, DateTime? toDate)
        {
            return GetProposalList(null, null, null, null, fromDate, toDate);
        }

        /// <summary>
        /// Get proposals by a specific status
        /// </summary>
        /// <param name="status">Given status</param>
        /// <returns>List of proposals</returns>
        public List<APProposalsInfo> GetProposalsByStatus(string status)
        {
            return GetProposalList(null, null, null, status, null, null);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<APProposalsInfo> proposals = new List<APProposalsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    APProposalsInfo proposal = (APProposalsInfo)GetObjectFromDataRow(row);
                    proposals.Add(proposal);
                }
            }
            ds.Dispose();
            return proposals;
        }

        /// <summary>
        /// Confirm a proposal
        /// </summary>
        /// <param name="proposalID">Proposal id</param>
        public void ConfirmProposal(int proposalID)
        {
            dal.ExecuteStoredProcedure("APProposals_ConfirmProposal", proposalID);
        }

        public DataSet GetPurchaseProposalListDatasetByListOfBranchID(
                                        string proposalNo,
                                        int? employeeID,
                                        DateTime? fromDate,
                                        DateTime? toDate,
                                        List<BRBranchsInfo> branchList)
        {
            DataSet rtn = new DataSet();
            foreach (BRBranchsInfo ojbBranchsInfo in branchList)
            {
                DataSet ds = GetPurchaseProposalListDataset(proposalNo,
                                        employeeID,
                                        fromDate,
                                        toDate,
                                        ojbBranchsInfo.BRBranchID);
                rtn.Merge(ds);
            }

            return rtn;
        }

        public DataSet GetPurchaseProposalListDataset(
                                        string proposalNo,
                                        int? employeeID,
                                        DateTime? fromDate,
                                        DateTime? toDate,
                                        int? branchID)
        {
            return dal.GetDataSet("APProposals_GetPurchaseProposalListDataset",
                                        proposalNo,
                                        employeeID,
                                        fromDate,
                                        toDate,
                                        branchID);
        }

        public List<APProposalsInfo> GetAllPurchaseProposalsForHome(DateTime? proposalFromDate, DateTime? proposalToDate, string proposalStatus)
        {
            DataSet ds = dal.GetDataSet("APProposals_GetAllPurchaseProposalsForHome", proposalFromDate, proposalToDate, proposalStatus);
            return (List<APProposalsInfo>)GetListFromDataSet(ds);
        }

        public APProposalsInfo GetObjectForPurchaseProposalReport(int proposalID)
        {
            return (APProposalsInfo)dal.GetDataObject("GetObjectForPurchaseProposalReport", proposalID);
        }

        public List<APProposalsInfo> GetProposalListByCancelPurchaseProposalID(int cancelProposalID)
        {
            DataSet ds = dal.GetDataSet("APProposals_GetProposalListByCancelPurchaseProposalID", cancelProposalID);
            return (List<APProposalsInfo>)GetListFromDataSet(ds);
        }
        public APProposalsInfo GeProposalByID(int proposalID)
        {
            return (APProposalsInfo)dal.GetDataObject("APProposals_GeProposalByID", proposalID);
        }
    }
    #endregion
}