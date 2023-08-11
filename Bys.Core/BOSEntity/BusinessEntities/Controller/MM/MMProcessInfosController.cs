﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMProcessInfos
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMProcessInfosController
    //Created Date:Friday, April 13, 2018
    //-----------------------------------------------------------

    public class MMProcessInfosController : BaseBusinessController
    {
        public MMProcessInfosController()
        {
            dal = new DALBaseProvider("MMProcessInfos", typeof(MMProcessInfosInfo));
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<MMProcessInfosInfo> ProcessInfos = new List<MMProcessInfosInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMProcessInfosInfo objProcessInfosInfo = (MMProcessInfosInfo)GetObjectFromDataRow(row);
                    ProcessInfos.Add(objProcessInfosInfo);
                }
            }
            ds.Dispose();
            return ProcessInfos;
        }
    }
    #endregion
}