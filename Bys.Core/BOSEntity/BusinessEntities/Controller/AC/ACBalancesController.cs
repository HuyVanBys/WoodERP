﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ACBalances
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACBalancesController
    //Created Date:Tuesday, March 19, 2019
    //-----------------------------------------------------------

    public class ACBalancesController : BaseBusinessController
    {
        public ACBalancesController()
        {
            dal = new DALBaseProvider("ACBalances", typeof(ACBalancesInfo));
        }

        public List<ACBalancesInfo> GetACBalancesForBeginning()
        {
            DataSet ds = dal.GetDataSet("ACBalances_GetACBalancesForBeginning");
            return (List<ACBalancesInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ACBalancesInfo> list = new List<ACBalancesInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ACBalancesInfo obj = (ACBalancesInfo)GetObjectFromDataRow(row);
                    list.Add(obj);
                }
            }
            ds.Dispose();
            return list;
        }

        public void ClosingAccountBalances(DateTime closingDate)
        {
            dal.ExecuteStoredProcedure("ACBalances_ClosingAccountBalances", closingDate);
        }

        public bool CheckExitsClosingAccountBalances(DateTime closingDate)
        {
            DataSet ds = dal.GetDataSet("ACBalances_CheckExitsClosingAccountBalances", closingDate);
            return ds.Tables[0].Rows.Count > 0;
        }
    }
    #endregion
}