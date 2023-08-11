﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMAllocationOperationConfigs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMAllocationOperationConfigsController
    //Created Date:Friday, June 12, 2020
    //-----------------------------------------------------------

    public class MMAllocationOperationConfigsController : BaseBusinessController
    {
        public MMAllocationOperationConfigsController()
        {
            dal = new DALBaseProvider("MMAllocationOperationConfigs", typeof(MMAllocationOperationConfigsInfo));
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<MMAllocationOperationConfigsInfo> lists = new List<MMAllocationOperationConfigsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMAllocationOperationConfigsInfo objsInfo = (MMAllocationOperationConfigsInfo)GetObjectFromDataRow(row);
                    lists.Add(objsInfo);
                }
            }
            ds.Dispose();
            return lists;
        }
        public DataSet GetAllocationOperationConfigList()
        {
            return dal.GetDataSet("MMAllocationOperationConfigs_GetAllocationOperationConfigList");
        }
        public MMAllocationOperationConfigsInfo GetDefualtAllocationOperationConfigs()
        {
            DataSet ds = dal.GetDataSet("MMAllocationOperationConfigs_GetDefualtAllocationOperationConfigs");
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                MMAllocationOperationConfigsInfo objInfo = (MMAllocationOperationConfigsInfo)GetObjectFromDataRow(ds.Tables[0].Rows[0]);
                return objInfo;
            }
            return null;
        }
    }
    #endregion
}