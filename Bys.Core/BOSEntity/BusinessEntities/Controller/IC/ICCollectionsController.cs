﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ICCollections
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ICCollectionsController
    //Created Date:04 Tháng Ba 2018
    //-----------------------------------------------------------

    public class ICCollectionsController : BaseBusinessController
    {
        public ICCollectionsController()
        {
            dal = new DALBaseProvider("ICCollections", typeof(ICCollectionsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ICCollectionsInfo> Collections = new List<ICCollectionsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICCollectionsInfo objICCollectionsInfo = (ICCollectionsInfo)GetObjectFromDataRow(row);
                    Collections.Add(objICCollectionsInfo);
                }
            }
            ds.Dispose();
            return Collections;
        }
    }
    #endregion
}