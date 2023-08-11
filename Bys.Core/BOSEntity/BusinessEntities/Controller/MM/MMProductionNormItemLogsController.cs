using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMProductionNormItemLogs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProductionNormItemLogsController
    //Created Date:Saturday, March 09, 2019
    //-----------------------------------------------------------

    public class MMProductionNormItemLogsController : BaseBusinessController
    {
        public MMProductionNormItemLogsController()
        {
            dal = new DALBaseProvider("MMProductionNormItemLogs", typeof(MMProductionNormItemLogsInfo));

        }
        public List<MMProductionNormItemLogsInfo> GetBySomeConditions(int batchProductID, int productionNormID, string changeType)
        {
            DataSet ds = dal.GetDataSet("MMProductionNormItemLogs_GetBySomeConditions", batchProductID, productionNormID, changeType);
            List<MMProductionNormItemLogsInfo> invoiceList = new List<MMProductionNormItemLogsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMProductionNormItemLogsInfo objInvoicesInfo = (MMProductionNormItemLogsInfo)GetObjectFromDataRow(row);
                    invoiceList.Add(objInvoicesInfo);
                }
            }
            ds.Dispose();
            return invoiceList;
        }
        public List<MMProductionNormItemLogsInfo> GetByApproveID(int approveLogID)
        {
            DataSet ds = dal.GetDataSet("MMProductionNormItemLogs_GetByApproveID", approveLogID);
            List<MMProductionNormItemLogsInfo> invoiceList = new List<MMProductionNormItemLogsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMProductionNormItemLogsInfo objInvoicesInfo = (MMProductionNormItemLogsInfo)GetObjectFromDataRow(row);
                    invoiceList.Add(objInvoicesInfo);
                }
            }
            ds.Dispose();
            return invoiceList;
        }



    }
    #endregion
}