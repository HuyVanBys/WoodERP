﻿using BOSLib;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using BOSLib.Extensions;
using Dapper;

namespace BOSERP
{
    #region MMProductionNormItemConfigs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProductionNormItemConfigsController
    //Created Date:Monday, October 26, 2015
    //-----------------------------------------------------------

    public class MMProductionNormItemConfigsController : BaseBusinessController
    {
        public MMProductionNormItemConfigsController()
        {
            dal = new DALBaseProvider("MMProductionNormItemConfigs", typeof(MMProductionNormItemConfigsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<MMProductionNormItemConfigsInfo> ProductionNormItemConfigs = new List<MMProductionNormItemConfigsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMProductionNormItemConfigsInfo objProductionNormItemConfigsInfo = (MMProductionNormItemConfigsInfo)GetObjectFromDataRow(row);
                    ProductionNormItemConfigs.Add(objProductionNormItemConfigsInfo);
                }
            }

            ds.Dispose();
            return ProductionNormItemConfigs;
        }

        public List<MMProductionNormItemConfigsInfo> GetProductionNormItemConfigList()
        {
            DataSet ds = dal.GetDataSet("MMProductionNormItemConfigs_GetproductionNormItemConfigsList");
            return (List<MMProductionNormItemConfigsInfo>)GetListFromDataSet(ds);
        }
        public List<MMProductionNormItemConfigsInfo> GetProductionNormItemConfigByWoodTypeID(int woodTypeID)
        {
            DataSet ds = dal.GetDataSet("MMProductionNormItemConfigs_GetProductionNormItemConfigByWoodTypeID", woodTypeID);
            return (List<MMProductionNormItemConfigsInfo>)GetListFromDataSet(ds);
        }
        
        public List<MMProductionNormItemConfigsInfo> GetAllConfigByWoodTypeIds(List<int> woodTypeIds)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("AttributeWoodIds", woodTypeIds.ToDataTableIds(), DbType.Object, ParameterDirection.Input);
            var results = dal.Connection.ExecuteReader("MMProductionNormItemConfigs_GetAllConfigByWoodTypeIds", parameters, commandType: CommandType.StoredProcedure);
            return results.ConvertToList<MMProductionNormItemConfigsInfo>().ToList();
        }
    }
    #endregion
}