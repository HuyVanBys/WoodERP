﻿using BOSLib;
using System.Data;


namespace BOSERP
{
    #region STModulePostings
    //-----------------------------------------------------------
    //Generated By: BOS Studio
    //Class:STModulePostingsController
    //Created Date:18 Tháng Mười Hai 2018
    //-----------------------------------------------------------

    public class STModulePostingsController : BaseBusinessController
    {
        public STModulePostingsController()
        {
            dal = new DALBaseProvider("STModulePostings", typeof(STModulePostingsInfo));
        }

        public STModulePostingsInfo GetObjectByModuleName(string moduleName)
        {
            DataSet ds = dal.GetDataSet("STModulePostings_GetObjectByModuleID", moduleName);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return (STModulePostingsInfo)this.GetObjectFromDataRow(ds.Tables[0].Rows[0]);
            }
            ds.Dispose();
            return null;
        }

        #region Posting With RefID

        public void STModulePostingStockFunction(string moduleName, int refid, bool post)
        {
            dal.ExecuteStoredProcedure("STModulePostings_STModulePostingStockFunction", moduleName, refid, post);
        }

        public void STModulePostingAccountingFunction(string moduleName, int refid, bool post)
        {
            dal.ExecuteStoredProcedure("STModulePostings_STModulePostingAccountingFunction", moduleName, refid, post);
        }

        public void STModulePostingSaleOrderFunction(string moduleName, int refid, bool post)
        {
            dal.ExecuteStoredProcedure("STModulePostings_STModulePostingSaleOrderFunction", moduleName, refid, post);
        }

        public void STModulePostingPurchaseFunction(string moduleName, int refid, bool post)
        {
            dal.ExecuteStoredProcedure("STModulePostings_STModulePostingPurchaseFunction", moduleName, refid, post);
        }

        public void STModulePostingAllocationPlanFunction(string moduleName, int refid, bool post)
        {
            dal.ExecuteStoredProcedure("STModulePostings_STModulePostingAllocationPlanFunction", moduleName, refid, post);
        }

        public void STModulePostingTransitInFunction(string moduleName, int refid, bool post)
        {
            dal.ExecuteStoredProcedure("STModulePostings_STModulePostingTransitInFunction", moduleName, refid, post);
        }

        public void STModulePostingTransitOutFunction(string moduleName, int refid, bool post)
        {
            dal.ExecuteStoredProcedure("STModulePostings_STModulePostingTransitOutFunction", moduleName, refid, post);
        }

        public void STModulePostingInvoiceTransFunction(string moduleName, int refid, bool post)
        {
            dal.ExecuteStoredProcedure("STModulePostings_STModulePostingInvoiceTransFunction", moduleName, refid, post);
        }

        public void STModulePostingInvoiceInTransFunction(string moduleName, int refid, bool post)
        {
            dal.ExecuteStoredProcedure("STModulePostings_STModulePostingInvoiceInTransFunction", moduleName, refid, post);
        }

        public void PostedARClearingDetails(string moduleName, int invoiceID, bool post)
        {
            dal.ExecuteStoredProcedure("ARInvoiceTransactions_PostedARClearingDetails", moduleName, invoiceID, post);
        }

        public void PostedAPClearingDetails(string moduleName, int invoiceInID, bool post)
        {
            dal.ExecuteStoredProcedure("APInvoiceInTransactions_PostedAPClearingDetails", moduleName, invoiceInID, post);
        }

        public void STModulePostingAllExitsFunction(string moduleName, int refid, bool post)
        {
            dal.ExecuteStoredProcedure("STModulePostings_STModulePostingAllExitsFunction", moduleName, refid, post);
        }
        #endregion


        #region Posting With RefItemID

        //public void STModulePostingStockFunction(string moduleName, string refItemID, bool post)
        //{
        //    dal.ExecuteStoredProcedure("STModulePostings_STModulePostingStockItemFunction", moduleName, refItemID, post);
        //}

        //public void STModulePostingAccountingFunction(string moduleName, string refItemID, bool post)
        //{
        //    dal.ExecuteStoredProcedure("STModulePostings_STModulePostingAccountingItemFunction", moduleName, refItemID, post);
        //}

        //public void STModulePostingSaleOrderFunction(string moduleName, string refItemID, bool post)
        //{
        //    dal.ExecuteStoredProcedure("STModulePostings_STModulePostingSaleOrderItemFunction", moduleName, refItemID, post);
        //}

        //public void STModulePostingPurchaseFunction(string moduleName, string refItemID, bool post)
        //{
        //    dal.ExecuteStoredProcedure("STModulePostings_STModulePostingPurchaseItemItemFunction", moduleName, refItemID, post);
        //}

        public void STModulePostingAllocationPlanItemFunction(string moduleName, int refID, string refItemID, bool post)
        {
            dal.ExecuteStoredProcedure("STModulePostings_STModulePostingAllocationPlanItemFunction", moduleName, refID, refItemID, post);
        }

        //public void STModulePostingTransitInFunction(string moduleName, string refItemID, bool post)
        //{
        //    dal.ExecuteStoredProcedure("STModulePostings_STModulePostingTransitInItemFunction", moduleName, refItemID, post);
        //}

        //public void STModulePostingTransitOutFunction(string moduleName, string refItemID, bool post)
        //{
        //    dal.ExecuteStoredProcedure("STModulePostings_STModulePostingTransitOutItemFunction", moduleName, refItemID, post);
        //}

        //public void STModulePostingInvoiceTransFunction(string moduleName, string refItemID, bool post)
        //{
        //    dal.ExecuteStoredProcedure("STModulePostings_STModulePostingInvoiceTransFunction", moduleName, refItemID, post);
        //}

        //public void STModulePostingInvoiceInTransFunction(string moduleName, string refItemID, bool post)
        //{
        //    dal.ExecuteStoredProcedure("STModulePostings_STModulePostingInvoiceInTransFunction", moduleName, refItemID, post);
        //}
        #endregion

        public void UpdatePostedStatus(string moduleName, string tableName, int id, string postedStatus)
        {
            dal.ExecuteStoredProcedure("STModulePostings_UpdatePostedStatus", moduleName, tableName, id, postedStatus);
        }
    }
    #endregion
}