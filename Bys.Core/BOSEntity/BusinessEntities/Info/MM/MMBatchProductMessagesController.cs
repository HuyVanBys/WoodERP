using BOSLib;
using System.Collections.Generic;
using System.Data;

namespace BOSERP
{
    public class MMBatchProductMessagesController : BaseBusinessController
    {
        public MMBatchProductMessagesController()
        {
            dal = new DALBaseProvider("MMBatchProductMessages", typeof(MMBatchProductMessagesInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<MMBatchProductMessagesInfo> batchProductMessageList = new List<MMBatchProductMessagesInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMBatchProductMessagesInfo objBatchProductMessagesInfo = (MMBatchProductMessagesInfo)GetObjectFromDataRow(row);
                    batchProductMessageList.Add(objBatchProductMessagesInfo);
                }
            }
            ds.Dispose();
            return batchProductMessageList;
        }

        public List<MMBatchProductMessagesInfo> ValidateCloseBatchProduct(int batchProductID, int batchProductItemID = 0)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductMessages_ValidateCloseBatchProduct", batchProductID, batchProductItemID);
            return (List<MMBatchProductMessagesInfo>)GetListFromDataSet(ds);
        }

        public List<MMBatchProductMessagesInfo> ValidateCloseBatchProductOutSourcing(int batchProductID, string oursourcingRef)
        {
            DataSet ds = dal.GetDataSet("MMBatchProductMessages_ValidateCloseBatchProductOutSourcing", batchProductID, oursourcingRef);
            return (List<MMBatchProductMessagesInfo>)GetListFromDataSet(ds);
        }
    }
}
