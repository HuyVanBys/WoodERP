﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMReuseSpecificateConfigs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMReuseSpecificateConfigsController
    //Created Date:Wednesday, October 21, 2015
    //-----------------------------------------------------------

    public class MMReuseSpecificateConfigsController : BaseBusinessController
    {
        public MMReuseSpecificateConfigsController()
        {
            dal = new DALBaseProvider("MMReuseSpecificateConfigs", typeof(MMReuseSpecificateConfigsInfo));
        }

        public List<MMReuseSpecificateConfigsInfo> GetReuseSpecificateConfigSomeCriteria(int woodType, decimal configThickGroup, int departmentAttributeID)
        {
            DataSet ds = dal.GetDataSet("MMReuseSpecificateConfigs_GetReuseSpecificateConfigSomeCriteria", woodType, configThickGroup, departmentAttributeID);
            List<MMReuseSpecificateConfigsInfo> reuseSpecificateConfigList = new List<MMReuseSpecificateConfigsInfo>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMReuseSpecificateConfigsInfo objReuseSpecificateConfigsInfo = (MMReuseSpecificateConfigsInfo)GetObjectFromDataRow(row);
                    reuseSpecificateConfigList.Add(objReuseSpecificateConfigsInfo);
                }
            }
            if (reuseSpecificateConfigList != null && reuseSpecificateConfigList.Count > 0)
            {
                ds.Dispose();
                return reuseSpecificateConfigList;
            }
            else
                ds.Dispose();
            return null;
        }

        public List<MMReuseSpecificateConfigsInfo> GetListFromDataSet(DataSet ds)
        {
            List<MMReuseSpecificateConfigsInfo> reuseSpecificateConfigs = new List<MMReuseSpecificateConfigsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMReuseSpecificateConfigsInfo reuseSpecificateConfig = (MMReuseSpecificateConfigsInfo)GetObjectFromDataRow(row);
                    reuseSpecificateConfigs.Add(reuseSpecificateConfig);
                }
            }

            ds.Dispose();
            return reuseSpecificateConfigs;
        }
    }
    #endregion
}