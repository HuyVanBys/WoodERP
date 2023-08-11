﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMProcessChanges
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProcessChangesController
    //Created Date:Wednesday, November 14, 2018
    //-----------------------------------------------------------

    public class MMProcessChangesController : BaseBusinessController
    {
        public MMProcessChangesController()
        {
            dal = new DALBaseProvider("MMProcessChanges", typeof(MMProcessChangesInfo));
        }
        public List<MMProcessChangesInfo> GetChangeRefeInfoByProductionNormItem(int? batchProductID, int productionNormItem, string ProductType)
        {
            DataSet ds = dal.GetDataSet("MMProcessChanges_GetChangeRefeInfoByProductionNormItem", batchProductID, productionNormItem, ProductType);
            return (List<MMProcessChangesInfo>)GetListFromDataSet(ds);
        }
        public List<MMProcessChangesInfo> GetChangeRefeInfoByListNormItem(int? batchProductID, string lstNormItem, string ProductType)
        {
            DataSet ds = dal.GetDataSet("MMProcessChanges_GetChangeRefeInfoByListNormItem", batchProductID, lstNormItem, ProductType);
            return (List<MMProcessChangesInfo>)GetListFromDataSet(ds);
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<MMProcessChangesInfo> ProcessChanges = new List<MMProcessChangesInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMProcessChangesInfo objProcessChangesInfo = (MMProcessChangesInfo)GetObjectFromDataRow(row);
                    ProcessChanges.Add(objProcessChangesInfo);
                }
            }
            ds.Dispose();
            return ProcessChanges;
        }
    }
    #endregion
}