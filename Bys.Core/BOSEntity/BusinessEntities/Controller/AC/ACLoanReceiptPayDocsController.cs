﻿using BOSLib;
using System;
using System.Collections.Generic;
using System.Data;


namespace BOSERP
{
    #region ACLoanReceiptPayDocs
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACLoanReceiptPayDocsController
    //Created Date:Tuesday, March 15, 2016
    //-----------------------------------------------------------

    public class ACLoanReceiptPayDocsController : BaseBusinessController
    {
        public ACLoanReceiptPayDocsController()
        {
            dal = new DALBaseProvider("ACLoanReceiptPayDocs", typeof(ACLoanReceiptPayDocsInfo));
        }
        //public List<ACLoanReceiptPayDocsInfo> GetLoanReceiptPayDocByDocumentID(int documentID)
        //{
        //    DataSet ds = dal.GetDataSet("ACLoanReceiptPayDocs_GetLoanReceiptPayDocByDocumentID", documentID);
        //    List<ACLoanReceiptPayDocsInfo> LoanReceiptList = new List<ACLoanReceiptPayDocsInfo>();
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        ACLoanReceiptPayDocsController objLoanReceiptsController = new ACLoanReceiptPayDocsController();
        //        foreach (DataRow dr in ds.Tables[0].Rows)
        //        {
        //            ACLoanReceiptPayDocsInfo objLoanReceiptsInfo = new ACLoanReceiptPayDocsInfo();
        //            objLoanReceiptsInfo = (ACLoanReceiptPayDocsInfo)objLoanReceiptsController.GetObjectFromDataRow(dr);
        //            LoanReceiptList.Add(objLoanReceiptsInfo);
        //        }
        //    }
        //    return LoanReceiptList;
        //}
        public ACLoanReceiptPayDocsInfo GetLoanReceiptPayDocByDocumentID(int documentID)
        {
            return (ACLoanReceiptPayDocsInfo)dal.GetDataObject("ACLoanReceiptPayDocs_GetLoanReceiptPayDocByDocumentID", documentID);
        }


        /// <summary>
        /// Get assets for broadcasting to a branch
        /// </summary>
        /// <param name="branchID">Branch id</param>
        /// <returns>List of broadcasted assets</returns>
        public List<ACLoanReceiptPayDocsInfo> GetLoanReceiptPayDocsByLoanReceiptID(int loanReceiptID)
        {
            DataSet ds = dal.GetDataSet("ACLoanReceiptPayDocs_GetLoanReceiptPayDocsByLoanReceiptID", loanReceiptID);
            return (List<ACLoanReceiptPayDocsInfo>)GetListFromDataSet(ds);
        }

        public override System.Collections.IList GetListFromDataSet(DataSet ds)
        {
            List<ACLoanReceiptPayDocsInfo> loanReceiptPayDocs = new List<ACLoanReceiptPayDocsInfo>();
            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ACLoanReceiptPayDocsInfo loanReceiptPayDoc = (ACLoanReceiptPayDocsInfo)GetObjectFromDataRow(row);
                    loanReceiptPayDocs.Add(loanReceiptPayDoc);
                }
            }
            ds.Dispose();
            return loanReceiptPayDocs;
        }

        public bool InsertLoanReceiptPayDocByDocumentPaymentNo(string documentPaymentNo, int loanReceiptID, bool isPosted)
        {
            try
            {
                dal.ExecuteStoredProcedure("ACLoanReceiptPayDocs_InsertLoanReceiptPayDocByDocumentPaymentNo", documentPaymentNo, loanReceiptID, isPosted);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
    #endregion
}