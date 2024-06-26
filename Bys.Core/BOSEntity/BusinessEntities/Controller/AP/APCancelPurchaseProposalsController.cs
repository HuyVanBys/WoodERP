﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region APCancelPurchaseProposals
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APCancelPurchaseProposalsController
    //Created Date:Thursday, July 14, 2016
    //-----------------------------------------------------------

    public class APCancelPurchaseProposalsController : BaseBusinessController
    {
        public APCancelPurchaseProposalsController()
        {
            dal = new DALBaseProvider("APCancelPurchaseProposals", typeof(APCancelPurchaseProposalsInfo));
        }
        public DataSet GetCancelPurchaseProposalListDatasetByListOfBranchID(
                                       string cancelProposalNo,
                                       int? employeeID,
                                       DateTime? fromDate,
                                       DateTime? toDate,
                                       List<BRBranchsInfo> branchList)
        {
            DataSet rtn = new DataSet();
            foreach (BRBranchsInfo ojbBranchsInfo in branchList)
            {
                DataSet ds = GetCancelPurchaseProposalListDataset(cancelProposalNo,
                                        employeeID,
                                        fromDate,
                                        toDate,
                                        ojbBranchsInfo.BRBranchID);
                rtn.Merge(ds);
            }

            return rtn;
        }

        public DataSet GetCancelPurchaseProposalListDataset(
                                       string cancelProposalNo,
                                       int? employeeID,
                                       DateTime? fromDate,
                                       DateTime? toDate,
                                       int? branchID)
        {
            return dal.GetDataSet("APCancelPurchaseProposals_GetCancelPurchaseProposalListDataset",
                                        cancelProposalNo,
                                        employeeID,
                                        fromDate,
                                        toDate,
                                        branchID);
        }
    }
    #endregion
}