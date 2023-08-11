using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ACEndingAllocations
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACEndingAllocationsController
    //Created Date:Wednesday, November 14, 2018
    //-----------------------------------------------------------

    public class ACEndingAllocationsController : BaseBusinessController
    {
        public ACEndingAllocationsController()
        {
            dal = new DALBaseProvider("ACEndingAllocations", typeof(ACEndingAllocationsInfo));
        }


        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ACEndingAllocationsInfo> customers = new List<ACEndingAllocationsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ACEndingAllocationsInfo objCustomersInfo = (ACEndingAllocationsInfo)GetObjectFromDataRow(row);
                    customers.Add(objCustomersInfo);
                }
            }
            ds.Dispose();
            return customers;
        }

        public List<ACEndingAllocationsInfo> GetByDeclarationID(int declarationID, DateTime fromDate, DateTime toDate)
        {
            DataSet ds = dal.GetDataSet("ACEndingAllocations_GetByDeclarationID", declarationID, fromDate, toDate);
            return (List<ACEndingAllocationsInfo>)GetListFromDataSet(ds);
        }


    }
    #endregion
}