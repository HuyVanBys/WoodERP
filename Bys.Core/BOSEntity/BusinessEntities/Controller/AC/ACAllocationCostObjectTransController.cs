﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ACAllocationCostObjectTrans
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACAllocationCostObjectTransController
    //Created Date:Thursday, July 18, 2019
    //-----------------------------------------------------------

    public class ACAllocationCostObjectTransController : BaseBusinessController
    {
        public ACAllocationCostObjectTransController()
        {
            dal = new DALBaseProvider("ACAllocationCostObjectTrans", typeof(ACAllocationCostObjectTransInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ACAllocationCostObjectTransInfo> listAllocationCostObjectTransInfo = new List<ACAllocationCostObjectTransInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ACAllocationCostObjectTransInfo objAllocationCostObjectTransInfo = (ACAllocationCostObjectTransInfo)GetObjectFromDataRow(row);
                    listAllocationCostObjectTransInfo.Add(objAllocationCostObjectTransInfo);
                }
            }
            ds.Dispose();
            return listAllocationCostObjectTransInfo;
        }

        public List<ACAllocationCostObjectTransInfo> GetAllocationCostObjectTransByMonthAndBranchIDs(DateTime dateTime, string branchs)
        {
            DataSet ds = dal.GetDataSet("ACAllocationCostObjectTrans_GetAllocationCostObjectTransByMonthAndBranchIDs", dateTime, branchs);
            return (List<ACAllocationCostObjectTransInfo>)GetListFromDataSet(ds);
        }

        public List<ACAllocationCostObjectTransInfo> GetAllocationCostObjectTransByDocumentID(int objectiD)
        {
            DataSet ds = dal.GetDataSet("ACAllocationCostObjectTrans_GetAllocationCostObjectTransByDocumentID", objectiD);
            return (List<ACAllocationCostObjectTransInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}