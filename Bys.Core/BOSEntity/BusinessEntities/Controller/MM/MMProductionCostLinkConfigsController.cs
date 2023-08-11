﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMProductionCostLinkConfigs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProductionCostLinkConfigsController
    //Created Date:Friday, September 6, 2019
    //-----------------------------------------------------------

    public class MMProductionCostLinkConfigsController : BaseBusinessController
    {
        public MMProductionCostLinkConfigsController()
        {
            dal = new DALBaseProvider("MMProductionCostLinkConfigs", typeof(MMProductionCostLinkConfigsInfo));
        }

        public List<MMProductionCostLinkConfigsInfo> GetAllAliveLinkConfigs()
        {
            List<MMProductionCostLinkConfigsInfo> obj = new List<MMProductionCostLinkConfigsInfo>();
            DataSet ds = dal.GetDataSet("MMProductionCostLinkConfigs_GetAllAliveLinkConfigs");
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMProductionCostLinkConfigsInfo objProductionCostLinkConfigsInfo = (MMProductionCostLinkConfigsInfo)GetObjectFromDataRow(row);
                    obj.Add(objProductionCostLinkConfigsInfo);
                }
            }
            ds.Dispose();
            return obj;
        }

        public List<MMProductionCostLinkConfigsInfo> GetDataByInProgressClassifyType(string productionCostInProgressClassifyType)
        {
            List<MMProductionCostLinkConfigsInfo> obj = new List<MMProductionCostLinkConfigsInfo>();
            DataSet ds = dal.GetDataSet("MMProductionCostLinkConfigs_GetDataByInProgressClassifyType", productionCostInProgressClassifyType);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMProductionCostLinkConfigsInfo objProductionCostLinkConfigsInfo = (MMProductionCostLinkConfigsInfo)GetObjectFromDataRow(row);
                    obj.Add(objProductionCostLinkConfigsInfo);
                }
            }
            ds.Dispose();
            return obj;
        }
    }
    #endregion
}