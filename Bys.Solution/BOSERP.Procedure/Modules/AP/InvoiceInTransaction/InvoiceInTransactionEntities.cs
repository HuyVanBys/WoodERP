using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.InvoiceInTransaction
{
    public class InvoiceInTransactionEntities : ERPModuleEntities
    {
        public BOSList<APInvoiceInTransactionsInfo> InvoiceInTransactionList { get; set; }

        #region Constructor
        public InvoiceInTransactionEntities()
            : base()
        {
            InvoiceInTransactionList = new BOSList<APInvoiceInTransactionsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitModuleObjects()
        {
            ModuleObjects.Add("APInvoiceInTransactions", new APInvoiceInTransactionsInfo());
        }

        public override void InitModuleObjectList()
        {
            InvoiceInTransactionList.InitBOSList(this,
                                           String.Empty,
                                           TableName.APInvoiceInTransactionsTableName,
                                           BOSList<APInvoiceInTransactionsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            InvoiceInTransactionList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                InvoiceInTransactionList.SetDefaultListAndRefreshGridControl();
            }
            catch (Exception)
            {
                return;
            }
        }

        public override void InitModuleEntity()
        {
            base.InitModuleEntity();

            InitDataToModuleObjectList();
        }

        public void InitDataToModuleObjectList()
        {
            APInvoiceInTransactionsController controller = new APInvoiceInTransactionsController();
            List<APInvoiceInTransactionsInfo> listInvoiceInTransactions = controller.GetListInvoiceInTransactionsForBeginning(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            InvoiceInTransactionList.Invalidate(listInvoiceInTransactions);
        }
        #endregion
    }
}
