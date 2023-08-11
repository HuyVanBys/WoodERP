﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region MMCapacityHumanUnits
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:MMCapacityHumanUnitsController
    //Created Date:Tuesday, March 3, 2020
    //-----------------------------------------------------------

    public class MMCapacityHumanUnitsController : BaseBusinessController
    {
        public MMCapacityHumanUnitsController()
        {
            dal = new DALBaseProvider("MMCapacityHumanUnits", typeof(MMCapacityHumanUnitsInfo));
        }
        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<MMCapacityHumanUnitsInfo> List = new List<MMCapacityHumanUnitsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    MMCapacityHumanUnitsInfo item = (MMCapacityHumanUnitsInfo)GetObjectFromDataRow(row);
                    List.Add(item);
                }
            }
            ds.Dispose();
            return List;
        }
        public List<MMCapacityHumanUnitsInfo> GetHistoryCapacityBySomeCriteria(DateTime? fromdate
                                                                                            , DateTime? todate
                                                                                            , int? batchID
                                                                                            , int? productOfBatchID
                                                                                            , string operationID
                                                                                            , string humanID
                                                                                            , string machineID
                                                                                            , string semiProductNo
                                                                                            , string semiProductName
                                                                                            , int? NormID)
        {
            DataSet ds = dal.GetDataSet("MMCapacityHumanUnits_GetHistoryHumanCapacityBySomeCriteria", fromdate
                                                                                                            , todate
                                                                                                            , batchID
                                                                                                            , productOfBatchID
                                                                                                            , operationID
                                                                                                            , humanID
                                                                                                            , machineID
                                                                                                            , semiProductNo
                                                                                                            , semiProductName
                                                                                                            , NormID);
            return (List<MMCapacityHumanUnitsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}