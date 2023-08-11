﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMOperationDetailPlanCancels
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMOperationDetailPlanCancelsController
    //Created Date:Wednesday, November 09, 2016
    //-----------------------------------------------------------

    public class MMOperationDetailPlanCancelsController : BaseBusinessController
    {
        public MMOperationDetailPlanCancelsController()
        {
            dal = new DALBaseProvider("MMOperationDetailPlanCancels", typeof(MMOperationDetailPlanCancelsInfo));
        }

        public DataSet GetBySomeConditions(string no, int employeeID, string status, int operationDetailPlanID, DateTime fromDate, DateTime toDate)
        {
            DataSet ds = dal.GetDataSet("MMOperationDetailPlanCancels_GetBySomeConditions", no, employeeID, status, operationDetailPlanID, fromDate, toDate);
            return ds;
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<MMOperationDetailPlanCancelsInfo> OperationDetailPlanCancels = new List<MMOperationDetailPlanCancelsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMOperationDetailPlanCancelsInfo objOperationDetailPlanCancelsInfo = (MMOperationDetailPlanCancelsInfo)GetObjectFromDataRow(row);
                    OperationDetailPlanCancels.Add(objOperationDetailPlanCancelsInfo);
                }
            }
            ds.Dispose();
            return OperationDetailPlanCancels;
        }

    }
    #endregion
}