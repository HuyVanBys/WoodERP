﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARProposalPaymentTimes
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARProposalPaymentTimesController
    //Created Date:Thursday, July 5, 2018
    //-----------------------------------------------------------

    public class ARProposalPaymentTimesController : BaseBusinessController
    {
        public ARProposalPaymentTimesController()
        {
            dal = new DALBaseProvider("ARProposalPaymentTimes", typeof(ARProposalPaymentTimesInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ARProposalPaymentTimesInfo> proposalPaymentTimes = new List<ARProposalPaymentTimesInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARProposalPaymentTimesInfo objProposalPaymentTimesInfo = (ARProposalPaymentTimesInfo)GetObjectFromDataRow(row);
                    proposalPaymentTimes.Add(objProposalPaymentTimesInfo);
                }
            }
            ds.Dispose();
            return proposalPaymentTimes;
        }

        public List<ARProposalPaymentTimesInfo> GetProposalPaymentTimesByProposalID(int proposalID)
        {
            DataSet ds = dal.GetDataSet("ARProposalPaymentTimes_GetProposalPaymentTimesByProposalID", proposalID);

            return (List<ARProposalPaymentTimesInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}