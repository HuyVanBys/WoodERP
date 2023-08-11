﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARAllocationItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARAllocationItemsController
    //Created Date:Wednesday, May 16, 2018
    //-----------------------------------------------------------

    public class ARAllocationItemsController : BaseBusinessController
    {
        public ARAllocationItemsController()
        {
            dal = new DALBaseProvider("ARAllocationItems", typeof(ARAllocationItemsInfo));
        }

        public List<ARAllocationItemsInfo> GetAllocationItemsByAllocationID(int allocationID)
        {
            DataSet ds = this.GetAllDataByForeignColumn("FK_ARAllocationID", allocationID);

            return (List<ARAllocationItemsInfo>)GetListFromDataSet(ds);
        }

        public List<ARAllocationItemsInfo> GetAllocationItemsForReceptionItems()
        {
            DataSet ds = dal.GetDataSet("ARAllocationItems_GetAllocationItemsForReceptionItems");

            return (List<ARAllocationItemsInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ARAllocationItemsInfo> allocationItems = new List<ARAllocationItemsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARAllocationItemsInfo objAllocationItemsInfo = (ARAllocationItemsInfo)GetObjectFromDataRow(row);
                    allocationItems.Add(objAllocationItemsInfo);
                }
            }
            ds.Dispose();
            return allocationItems;
        }
    }
    #endregion
}