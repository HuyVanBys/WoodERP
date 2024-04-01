﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ACAllocationEquipmentTrans
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACAllocationEquipmentTransController
    //Created Date:Friday, February 22, 2019
    //-----------------------------------------------------------

    public class ACAllocationEquipmentTransController : BaseBusinessController
    {
        public ACAllocationEquipmentTransController()
        {
            dal = new DALBaseProvider("ACAllocationEquipmentTrans", typeof(ACAllocationEquipmentTransInfo));
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ACAllocationEquipmentTransInfo> allocationEquipmentTrans = new List<ACAllocationEquipmentTransInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ACAllocationEquipmentTransInfo objAllocationEquipmentTransInfo = (ACAllocationEquipmentTransInfo)GetObjectFromDataRow(row);
                    allocationEquipmentTrans.Add(objAllocationEquipmentTransInfo);
                }
            }
            ds.Dispose();
            return allocationEquipmentTrans;
        }
        public List<ACAllocationEquipmentTransInfo> GetAllocationEquipmentTransByDocumentID(int documentID)
        {
            DataSet ds = dal.GetDataSet("ACAllocationEquipmentTrans_GetAllocationEquipmentTransByDocumentID", documentID);
            return (List<ACAllocationEquipmentTransInfo>)GetListFromDataSet(ds);
        }
        public List<ACAllocationEquipmentTransInfo> GetAllocationEquipmentTransByMonthAndBranchIDs(DateTime dateTime, string branchs)
        {
            DataSet ds = dal.GetDataSet("ACAllocationEquipmentTrans_GetAllocationEquipmentTransByMonthAndBranchIDs", dateTime, branchs);
            return (List<ACAllocationEquipmentTransInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}