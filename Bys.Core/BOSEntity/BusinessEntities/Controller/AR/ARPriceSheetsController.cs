﻿using BOSLib;
using System.Collections.Generic;
using System.Data;
using System;

namespace BOSERP
{
    #region ARPriceSheets
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARCanceledDeliveryPlansController
    //Created Date:Tuesday, June 26, 2018
    //-----------------------------------------------------------

    public class ARPriceSheetsController : BaseBusinessController
    {
        public ARPriceSheetsController()
        {
            dal = new DALBaseProvider("ARPriceSheets", typeof(ARPriceSheetsInfo));
        }

        public DataSet GetPriceSheetListByListOfBranchID(string documentNo,
                                                           string customerType,
                                                           int? employeeID,
                                                           DateTime? documentFrom,
                                                           DateTime? documentTo,
                                                           int? customerID,
                                                           int? productID,
                                                           List<BRBranchsInfo> branchList)
        {
            DataSet rtn = new DataSet();
            foreach (BRBranchsInfo ojbBranchsInfo in branchList)
            {
                DataSet ds = GetPriceSheetListByBranchID(documentNo, customerType, employeeID, documentFrom, documentTo, customerID, productID, ojbBranchsInfo.BRBranchID);
                rtn.Merge(ds);
            }

            return rtn;
        }

        public DataSet GetPriceSheetListByBranchID(string documentNo,
                                                    string customerType,
                                                    int? employeeID,
                                                    DateTime? documentFrom,
                                                    DateTime? documentTo,
                                                    int? customerID,
                                                    int? productID,
                                                    int? branchID)
        {

            return dal.GetDataSet("ARPriceSheets_GetPriceSheetListByBranchID", documentNo, customerType, employeeID, documentFrom, documentTo, customerID, productID, branchID);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ARPriceSheetsInfo> priceSheetList = new List<ARPriceSheetsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ARPriceSheetsInfo objPriceSheetsInfo = (ARPriceSheetsInfo)GetObjectFromDataRow(row);
                    priceSheetList.Add(objPriceSheetsInfo);
                }
            }
            ds.Dispose();
            return priceSheetList;
        }

        public List<ARPriceSheetsInfo> GetPriceSheetNotInProposalByPriceSheetID(int priceSheetID)
        {
            DataSet ds = dal.GetDataSet("ARPriceSheets_GetPriceSheetNotInProposalByPriceSheetID", priceSheetID);
            return (List<ARPriceSheetsInfo>)GetListFromDataSet(ds);
        }
    }
    #endregion
}