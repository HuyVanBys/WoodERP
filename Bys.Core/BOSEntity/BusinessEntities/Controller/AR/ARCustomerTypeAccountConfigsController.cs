﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARCustomerTypeAccountConfigs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARCustomerTypeAccountConfigsController
    //Created Date:Wednesday, May 30, 2018
    //-----------------------------------------------------------

    public class ARCustomerTypeAccountConfigsController : BaseBusinessController
    {
        public ARCustomerTypeAccountConfigsController()
        {
            dal = new DALBaseProvider("ARCustomerTypeAccountConfigs", typeof(ARCustomerTypeAccountConfigsInfo));

        }

        public List<ARCustomerTypeAccountConfigsInfo> GetAllAliveCustomerTypeAccountConfig()
        {
            List<ARCustomerTypeAccountConfigsInfo> invoices = new List<ARCustomerTypeAccountConfigsInfo>();
            DataSet ds = dal.GetDataSet("ARCustomerTypeAccountConfigs_GetAllAliveCustomerTypeAccountConfig");
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARCustomerTypeAccountConfigsInfo objInvoicesInfo = (ARCustomerTypeAccountConfigsInfo)GetObjectFromDataRow(row);
                    invoices.Add(objInvoicesInfo);
                }
            }
            return invoices;
        }
    }
    #endregion
}