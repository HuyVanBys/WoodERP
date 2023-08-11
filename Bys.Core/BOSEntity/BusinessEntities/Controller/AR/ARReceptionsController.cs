﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ARReceptions
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ARReceptionsController
    //Created Date:Friday, May 18, 2018
    //-----------------------------------------------------------

    public class ARReceptionsController : BaseBusinessController
    {
        public ARReceptionsController()
        {
            dal = new DALBaseProvider("ARReceptions", typeof(ARReceptionsInfo));
        }

        public DataSet GetReceptionListByListOfBranchID(string receptionNo,
                                                           string receptionName,
                                                           int? employeeID,
                                                           DateTime? receptionDateFrom,
                                                           DateTime? receptionDateTo,
                                                           int? branchID,
                                                           List<BRBranchsInfo> branchList)
        {
            DataSet rtn = new DataSet();
            foreach (BRBranchsInfo ojbBranchsInfo in branchList)
            {
                DataSet ds = GetReceptionListByBranchID(receptionNo, receptionName, employeeID, receptionDateFrom, receptionDateTo, ojbBranchsInfo.BRBranchID);
                rtn.Merge(ds);
            }

            return rtn;
        }

        public DataSet GetReceptionListByBranchID(string receptionNo,
                                                   string receptionName,
                                                   int? employeeID,
                                                   DateTime? receptionDateFrom,
                                                   DateTime? receptionDateTo,
                                                   int? branchID)
        {
            return dal.GetDataSet("ARReceptions_GetReceptionListByListOfBranchID", receptionNo, receptionName, employeeID, receptionDateFrom, receptionDateTo, branchID);
        }
    }
    #endregion
}