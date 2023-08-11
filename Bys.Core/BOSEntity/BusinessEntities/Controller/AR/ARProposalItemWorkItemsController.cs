using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARProposalItemWorkItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARProposalItemWorkItemsController
    //Created Date:03 Tha�ng T� 2018
    //-----------------------------------------------------------

    public class ARProposalItemWorkItemsController : BaseBusinessController
    {
        public ARProposalItemWorkItemsController()
        {
            dal = new DALBaseProvider("ARProposalItemWorkItems", typeof(ARProposalItemWorkItemsInfo));
        }

        public List<ARProposalItemWorkItemsInfo> GetItemWorkItemsByProposalID(int proposalID)
        {
            DataSet ds = dal.GetDataSet("ARProposalItemWorkItems_GetProposalItemWorkItemsByProposalID", proposalID);
            List<ARProposalItemWorkItemsInfo> itemWorkItems = new List<ARProposalItemWorkItemsInfo>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                ARProposalItemWorkItemsController objProposalItemWorkItemsController = new ARProposalItemWorkItemsController();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARProposalItemWorkItemsInfo objProposalItemWorkItemsInfo = (ARProposalItemWorkItemsInfo)objProposalItemWorkItemsController.GetObjectFromDataRow(row);
                    itemWorkItems.Add(objProposalItemWorkItemsInfo);
                }
            }
            return itemWorkItems;
        }
    }
    #endregion
}