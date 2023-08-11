using BOSCommon.Constants;
using BOSLib;
using System;
using Dapper;
using Localization;

namespace BOSERP
{
    public class GLHelper
    {
        #region Constructor
        public GLHelper()
            : base()
        {

        }
        #endregion

        public static void PostedTransactions(string module, int refid, params string[] PostingType)
        {
            STModulePostingsController controller = new STModulePostingsController();
            foreach (string type in PostingType)
            {
                try
                {
                    switch (type)
                    {
                        case ModulePostingType.Stock:
                            controller.STModulePostingStockFunction(module, refid, true);
                            break;
                        case ModulePostingType.Accounting:
                            controller.STModulePostingAccountingFunction(module, refid, true);
                            break;
                        case ModulePostingType.SaleOrder:
                            controller.STModulePostingSaleOrderFunction(module, refid, true);
                            break;
                        case ModulePostingType.Purchase:
                            controller.STModulePostingPurchaseFunction(module, refid, true);
                            break;
                        case ModulePostingType.Allocation:
                            controller.STModulePostingAllocationPlanFunction(module, refid, true);
                            break;
                        case ModulePostingType.TransitIn:
                            controller.STModulePostingTransitInFunction(module, refid, true);
                            break;
                        case ModulePostingType.TransitOut:
                            controller.STModulePostingTransitOutFunction(module, refid, true);
                            break;
                        case ModulePostingType.InvoiceTrans:
                            controller.STModulePostingInvoiceTransFunction(module, refid, true);
                            break;
                        case ModulePostingType.InvoiceInTrans:
                            controller.STModulePostingInvoiceInTransFunction(module, refid, true);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    TransactionLogger log = new TransactionLogger();
                    log.AACreatedDate = BysGateway.CurrentServerDate;
                    log.AACreatedUser = BysGateway.CurrentUsersInfo?.ADUserName;
                    log.STModuleName = module;
                    log.STTransactionObjectID = refid;
                    log.STTransactionType = TransactionPostedAction.Posted;
                    log.STTransactionActionName = type;
                    log.STTransactionErrorMessage = e.Message;
                    SqlDatabaseHelper.Insert(log);
                    throw new Exception(CommonLocalizedResources.PostedTransationErrorMessage);
                }
            }

        }

        public static void UnPostedTransactions(string module, int refid, params string[] PostingType)
        {
            STModulePostingsController controller = new STModulePostingsController();
            foreach (string type in PostingType)
            {
                try
                {
                    switch (type)
                    {
                        case ModulePostingType.Stock:
                            controller.STModulePostingStockFunction(module, refid, false);
                            break;
                        case ModulePostingType.Accounting:
                            controller.STModulePostingAccountingFunction(module, refid, false);
                            break;
                        case ModulePostingType.SaleOrder:
                            controller.STModulePostingSaleOrderFunction(module, refid, false);
                            break;
                        case ModulePostingType.Purchase:
                            controller.STModulePostingPurchaseFunction(module, refid, false);
                            break;
                        case ModulePostingType.Allocation:
                            controller.STModulePostingAllocationPlanFunction(module, refid, false);
                            break;
                        case ModulePostingType.TransitIn:
                            controller.STModulePostingTransitInFunction(module, refid, false);
                            break;
                        case ModulePostingType.TransitOut:
                            controller.STModulePostingTransitOutFunction(module, refid, false);
                            break;
                        case ModulePostingType.InvoiceTrans:
                            controller.STModulePostingInvoiceTransFunction(module, refid, false);
                            break;
                        case ModulePostingType.InvoiceInTrans:
                            controller.STModulePostingInvoiceInTransFunction(module, refid, false);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    TransactionLogger log = new TransactionLogger();
                    log.AACreatedDate = BysGateway.CurrentServerDate;
                    log.AACreatedUser = BysGateway.CurrentUsersInfo?.ADUserName;
                    log.STModuleName = module;
                    log.STTransactionObjectID = refid;
                    log.STTransactionType = type;
                    log.STTransactionActionName = TransactionPostedAction.UnPosted;
                    log.STTransactionErrorMessage = e.Message;
                    SqlDatabaseHelper.Insert(log);
                    throw new Exception(CommonLocalizedResources.PostedTransationErrorMessage);
                }
            }
        }

        public static void UpdatePostedStatus(string moduleName, string tableName, int id, string postedStatus)
        {
            STModulePostingsController controller = new STModulePostingsController();
            controller.UpdatePostedStatus(moduleName, tableName, id, postedStatus);
        }
    }
}
