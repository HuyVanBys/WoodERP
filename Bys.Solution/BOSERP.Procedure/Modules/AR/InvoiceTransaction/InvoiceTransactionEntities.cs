using BOSCommon.Constants;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.InvoiceTransaction
{
    public class InvoiceTransactionEntities : ERPModuleEntities
    {
        public BOSList<ARInvoiceTransactionsInfo> InvoiceTransactionList { get; set; }

        #region Constructor
        public InvoiceTransactionEntities()
            : base()
        {
            InvoiceTransactionList = new BOSList<ARInvoiceTransactionsInfo>();
        }
        #endregion

        #region Init Main Object,Module Objects functions
        public override void InitModuleObjects()
        {
            ModuleObjects.Add("ARInvoiceTransactions", new ARInvoiceTransactionsInfo());
        }

        public override void InitModuleObjectList()
        {
            InvoiceTransactionList.InitBOSList(this,
                                           String.Empty,
                                           TableName.ARInvoiceTransactionsTableName,
                                           BOSList<ARInvoiceTransactionsInfo>.cstRelationNone);
        }

        public override void InitGridControlInBOSList()
        {
            InvoiceTransactionList.InitBOSListGridControl();
        }

        public override void SetDefaultModuleObjectsList()
        {
            try
            {
                InvoiceTransactionList.SetDefaultListAndRefreshGridControl();
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
            ARInvoiceTransactionsController controller = new ARInvoiceTransactionsController();
            List<ARInvoiceTransactionsInfo> listInvoiceTransactions = controller.GetListInvoiceTransactionsForBeginning(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            InvoiceTransactionList.Invalidate(listInvoiceTransactions);
        }
        #endregion
    }
}
