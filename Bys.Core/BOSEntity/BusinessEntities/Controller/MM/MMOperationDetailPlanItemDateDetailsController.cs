﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMOperationDetailPlanItemDateDetails
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMOperationDetailPlanItemDateDetailsController
    //Created Date:Tuesday, August 09, 2016
    //-----------------------------------------------------------

    public class MMOperationDetailPlanItemDateDetailsController : BaseBusinessController
    {
        public MMOperationDetailPlanItemDateDetailsController()
        {
            dal = new DALBaseProvider("MMOperationDetailPlanItemDateDetails", typeof(MMOperationDetailPlanItemDateDetailsInfo));
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<MMOperationDetailPlanItemDateDetailsInfo> list = new List<MMOperationDetailPlanItemDateDetailsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMOperationDetailPlanItemDateDetailsInfo obj = (MMOperationDetailPlanItemDateDetailsInfo)GetObjectFromDataRow(row);
                    ds.Dispose();
                    list.Add(obj);
                }
            }
            ds.Dispose();
            return list;
        }
    }
    #endregion
}