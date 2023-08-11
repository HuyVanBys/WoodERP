﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ICModels
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICModelsController
    //Created Date:Tuesday, January 12, 2016
    //-----------------------------------------------------------

    public class ICModelsController : BaseBusinessController
    {
        public ICModelsController()
        {
            dal = new DALBaseProvider("ICModels", typeof(ICModelsInfo));
        }

        public List<ICModelsInfo> GetallObjects()
        {
            DataSet ds = dal.GetAllObject();
            return (List<ICModelsInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ICModelsInfo> list = new List<ICModelsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICModelsInfo obj = (ICModelsInfo)GetObjectFromDataRow(row);
                    list.Add(obj);
                }
            }
            ds.Dispose();
            return list;
        }
    }
    #endregion
}