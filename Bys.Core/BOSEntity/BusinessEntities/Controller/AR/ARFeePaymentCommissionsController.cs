﻿using BOSLib;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARFeePaymentCommissions
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARFeePaymentCommissionsController
    //Created Date:06 January 2020
    //-----------------------------------------------------------

    public class ARFeePaymentCommissionsController : BaseBusinessController
    {
        public ARFeePaymentCommissionsController()
        {
            dal = new DALBaseProvider("ARFeePaymentCommissions", typeof(ARFeePaymentCommissionsInfo));
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ARFeePaymentCommissionsInfo> listFeePaymentCommissionsInfo = new List<ARFeePaymentCommissionsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARFeePaymentCommissionsInfo objFeePaymentCommissionsInfo = (ARFeePaymentCommissionsInfo)GetObjectFromDataRow(row);
                    listFeePaymentCommissionsInfo.Add(objFeePaymentCommissionsInfo);
                }
            }
            ds.Dispose();
            return listFeePaymentCommissionsInfo;
        }

        public List<ARFeePaymentCommissionsInfo> GetFeePaymentCommissionsForSaleCost(int branchID)
        {
            DataSet ds = dal.GetDataSet("ARFeePaymentCommissions_GetFeePaymentCommissionsForSaleCost", branchID);
            return (List<ARFeePaymentCommissionsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}