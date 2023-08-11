﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region APClearInvoiceIns
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:APClearInvoiceInsController
    //Created Date:Monday, July 30, 2018
    //-----------------------------------------------------------

    public class APClearInvoiceInsController : BaseBusinessController
    {
        public APClearInvoiceInsController()
        {
            dal = new DALBaseProvider("APClearInvoiceIns", typeof(APClearInvoiceInsInfo));
        }
        public DataSet GetClearingDebtListByBranchID(string clearInvoiceInNo,
                                   int? objectID,
                                   string objectType,
                                   int? employeeID,
                                   DateTime? fromDate,
                                   DateTime? toDate,
                                   int? branchID)
        {
            return dal.GetDataSet("APClearInvoiceIns_GetClearInvoiceInListByBranchID",
                                clearInvoiceInNo,
                                objectID,
                                objectType,
                                employeeID,
                                fromDate,
                                toDate,
                                branchID);
        }
        public DataSet GetClearingDebtListByListOfBranchID(string clearInvoiceInNo,
                                                                int? objectID,
                                                                string objectType,
                                                                int? employeeID,
                                                                DateTime? fromDate,
                                                                DateTime? toDate,
                                                                List<BRBranchsInfo> branchList)
        {
            DataSet rtn = new DataSet();
            foreach (BRBranchsInfo ojbBranchsInfo in branchList)
            {
                DataSet ds = GetClearingDebtListByBranchID(clearInvoiceInNo, objectID, objectType, employeeID, fromDate, toDate
                                                                , ojbBranchsInfo.BRBranchID);
                rtn.Merge(ds);
            }

            return rtn;
        }
    }
    #endregion
}