﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMBatchProductAdjustLogs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMBatchProductAdjustLogsController
    //Created Date:Friday, December 27, 2019
    //-----------------------------------------------------------

    public class MMBatchProductAdjustLogsController : BaseBusinessController
    {
        public MMBatchProductAdjustLogsController()
        {
            dal = new DALBaseProvider("MMBatchProductAdjustLogs", typeof(MMBatchProductAdjustLogsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<MMBatchProductAdjustLogsInfo> items = new List<MMBatchProductAdjustLogsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMBatchProductAdjustLogsInfo item = (MMBatchProductAdjustLogsInfo)GetObjectFromDataRow(row);
                    items.Add(item);
                }
            }
            ds.Dispose();
            return items;
        }

        public bool CheckValidChangeNorm(int batchProductID)
        {
            return (bool)dal.GetSingleValue("MMBatchProductAdjustLogs_CheckValidChangeNorm", batchProductID);
        }

        public void UpdateMaterialChanged(int batchProductID)
        {
            dal.ExecuteStoredProcedure("MMBatchProductAdjustLogs_UpdateMaterialChanged", batchProductID);
        }
    }
    #endregion
}