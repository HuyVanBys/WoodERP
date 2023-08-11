﻿using BOSLib;
using System;


namespace BOSERP
{
    #region ACLoanReceiptItems
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:ACLoanReceiptItemsController
    //Created Date:Tuesday, March 15, 2016
    //-----------------------------------------------------------

    public class ACLoanReceiptItemsController : BaseBusinessController
    {
        public ACLoanReceiptItemsController()
        {
            dal = new DALBaseProvider("ACLoanReceiptItems", typeof(ACLoanReceiptItemsInfo));
        }

        public bool InsertLoanReceiptItemByTransactionNo(string transactionNo, bool isPosted)
        {
            try
            {
                dal.ExecuteStoredProcedure("ACLoanReceiptItems_InsertLoanReceiptItemByTransactionNo", transactionNo, isPosted);
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