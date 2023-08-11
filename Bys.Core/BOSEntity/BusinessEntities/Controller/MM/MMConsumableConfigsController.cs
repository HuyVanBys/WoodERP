﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMConsumableConfigs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMConsumableConfigsController
    //Created Date:Thursday, October 22, 2015
    //-----------------------------------------------------------

    public class MMConsumableConfigsController : BaseBusinessController
    {
        public MMConsumableConfigsController()
        {
            dal = new DALBaseProvider("MMConsumableConfigs", typeof(MMConsumableConfigsInfo));
        }
        public List<MMConsumableConfigsInfo> GetListFromDataSet(DataSet ds)
        {
            List<MMConsumableConfigsInfo> ProductionNormItemConfigs = new List<MMConsumableConfigsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMConsumableConfigsInfo objProductionNormItemConfigsInfo = (MMConsumableConfigsInfo)GetObjectFromDataRow(row);
                    ProductionNormItemConfigs.Add(objProductionNormItemConfigsInfo);
                }
            }

            ds.Dispose();
            return ProductionNormItemConfigs;
        }
        public List<MMConsumableConfigsInfo> GetConsumableConfigsByProductAttributeID(int attributeID)
        {
            DataSet ds = dal.GetDataSet("MMConsumableConfigs_GetConsumableConfigsByProductAttributeID", attributeID);
            return (List<MMConsumableConfigsInfo>)GetListFromDataSet(ds);
        }
        public MMConsumableConfigsInfo GetConsumableConfigsByProductWoodID(int ProductID)
        {
            DataSet ds = dal.GetDataSet("MMConsumableConfigs_GetConsumableConfigsByProductWoodID", ProductID);
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    return (MMConsumableConfigsInfo)GetObjectFromDataRow(row);
                }
            }
            return null;

        }
        public List<MMConsumableConfigsInfo> GetConsumableConfigsByProductAttributeValue(string attributeValue)
        {
            DataSet ds = dal.GetDataSet("MMConsumableConfigs_GetConsumableConfigsByProductAttributeValue", attributeValue);
            return (List<MMConsumableConfigsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}