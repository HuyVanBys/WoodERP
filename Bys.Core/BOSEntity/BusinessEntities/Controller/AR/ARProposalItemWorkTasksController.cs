﻿using BOSLib;
using System.Collections.Generic;
using System.Data;

namespace BOSERP
{
    #region ARProposalItemWorkTasks
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARProposalItemWorkTasksController
    //Created Date:Wednesday, June 13, 2018
    //-----------------------------------------------------------

    public class ARProposalItemWorkTasksController : BaseBusinessController
    {
        public ARProposalItemWorkTasksController()
        {
            dal = new DALBaseProvider("ARProposalItemWorkTasks", typeof(ARProposalItemWorkTasksInfo));
        }

        public List<ARProposalItemWorkTasksInfo> GetProposalItemWorkTaskByProposalID(int proposalID)
        {
            DataSet ds = dal.GetDataSet("ARProposalItemWorkTasks_ARProposalItemWorkTaskByProposalID", proposalID);
            return (List<ARProposalItemWorkTasksInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ARProposalItemWorkTasksInfo> proposalItemWorkTaskList = new List<ARProposalItemWorkTasksInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARProposalItemWorkTasksInfo objProposalItemWorkTasksInfo = (ARProposalItemWorkTasksInfo)GetObjectFromDataRow(row);
                    proposalItemWorkTaskList.Add(objProposalItemWorkTasksInfo);
                }
            }
            ds.Dispose();
            return proposalItemWorkTaskList;
        }
    }
    #endregion
}