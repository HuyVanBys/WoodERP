﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ACCostCenters
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACCostCentersController
    //Created Date:Saturday, April 07, 2018
    //-----------------------------------------------------------

    public class ACCostCentersController : BaseBusinessController
    {
        public ACCostCentersController()
        {
            dal = new DALBaseProvider("ACCostCenters", typeof(ACCostCentersInfo));

        }

        public DataSet GetAllAliveAndActive()
        {
            return dal.GetDataSet("ACCostCenters_GetAllAliveAndActiveCostCenter");
        }

        public List<ACCostCentersInfo> GetAllAliveAndActiveCostCenter()
        {
            List<ACCostCentersInfo> costCenters = new List<ACCostCentersInfo>();
            DataSet ds = dal.GetDataSet("ACCostCenters_GetAllAliveAndActiveCostCenter");
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ACCostCentersInfo costCentersInfo = (ACCostCentersInfo)GetObjectFromDataRow(row);
                    costCenters.Add(costCentersInfo);
                }
            }
            return costCenters;
        }
    }
    #endregion
}