﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARCommissions
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARCommissionsController
    //Created Date:Tuesday, May 7, 2019
    //-----------------------------------------------------------

    public class ARCommissionsController : BaseBusinessController
    {
        public ARCommissionsController()
        {
            dal = new DALBaseProvider("ARCommissions", typeof(ARCommissionsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ARCommissionsInfo> item = new List<ARCommissionsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARCommissionsInfo objCommissionsInfo = (ARCommissionsInfo)GetObjectFromDataRow(row);
                    item.Add(objCommissionsInfo);
                }
            }
            ds.Dispose();
            return item;
        }

        public List<ARCommissionsInfo> GetARCommissionsBySaleOrderID(int saleOrderID)
        {
            DataSet ds = dal.GetDataSet("ARCommissions_GetARCommissionsBySaleOrderID", saleOrderID);
            return (List<ARCommissionsInfo>)GetListFromDataSet(ds);
        }

        public DataSet GetDataByCustomerID(int customerID)
        {
            return dal.GetDataSet("ARCommissions_GetDataByCustomerID", customerID);
        }

        public List<ARCommissionsInfo> GetARCommissionsBySaleOrderIDs(string saleOrderIDs)
        {
            DataSet ds = dal.GetDataSet("ARCommissions_GetARCommissionsBySaleOrderIDs", saleOrderIDs);
            return (List<ARCommissionsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}