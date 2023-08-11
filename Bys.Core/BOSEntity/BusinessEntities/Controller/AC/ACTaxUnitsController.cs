﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ACTaxUnits
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACTaxUnitsController
    //Created Date:Wednesday, January 22, 2020
    //-----------------------------------------------------------

    public class ACTaxUnitsController : BaseBusinessController
    {
        public ACTaxUnitsController()
        {
            dal = new DALBaseProvider("ACTaxUnits", typeof(ACTaxUnitsInfo));
        }

        public List<ACTaxUnitsInfo> GetAllACTaxUnits()
        {
            DataSet ds = GetAllObjects();
            return (List<ACTaxUnitsInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ACTaxUnitsInfo> cashFunds = new List<ACTaxUnitsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ACTaxUnitsInfo cashFund = (ACTaxUnitsInfo)GetObjectFromDataRow(row);
                    cashFunds.Add(cashFund);
                }
            }
            return cashFunds;
        }
    }
    #endregion
}