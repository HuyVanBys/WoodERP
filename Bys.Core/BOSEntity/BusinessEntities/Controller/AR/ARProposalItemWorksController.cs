using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARProposalItemWorks
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARProposalItemWorksController
    //Created Date:30 Tha�ng Ba 2018
    //-----------------------------------------------------------

    public class ARProposalItemWorksController : BaseBusinessController
    {
        public ARProposalItemWorksController()
        {
            dal = new DALBaseProvider("ARProposalItemWorks", typeof(ARProposalItemWorksInfo));
        }

        public List<ARProposalItemWorksInfo> GetItemWorksByProposalID(int proposalID)
        {
            DataSet ds = dal.GetDataSet("ARProposalItemWorks_GetProposalItemWorksByProposalID", proposalID);
            List<ARProposalItemWorksInfo> itemWorks = new List<ARProposalItemWorksInfo>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                ARProposalItemWorksController objProposalItemWorksController = new ARProposalItemWorksController();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARProposalItemWorksInfo objProposalItemWorksInfo = (ARProposalItemWorksInfo)objProposalItemWorksController.GetObjectFromDataRow(row);
                    itemWorks.Add(objProposalItemWorksInfo);
                }
            }
            return itemWorks;
        }

        public List<ARProposalItemWorksInfo> GetProposalItemWorkCostsByProposalID(int proposalID)
        {
            DataSet ds = dal.GetDataSet("ARProposalItemWorks_GetProposalItemWorkCostsByProposalID", proposalID);
            List<ARProposalItemWorksInfo> itemWorks = new List<ARProposalItemWorksInfo>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                ARProposalItemWorksController objProposalItemWorksController = new ARProposalItemWorksController();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARProposalItemWorksInfo objProposalItemWorksInfo = (ARProposalItemWorksInfo)objProposalItemWorksController.GetObjectFromDataRow(row);
                    itemWorks.Add(objProposalItemWorksInfo);
                }
            }
            return itemWorks;
        }

        public void DeleteProposalItemWorksByParentID(int parentID)
        {
            dal.ExecuteStoredProcedure("ARProposalItemWorks_DeleteProposalItemWorksByParentID", parentID);
        }
    }
    #endregion
}