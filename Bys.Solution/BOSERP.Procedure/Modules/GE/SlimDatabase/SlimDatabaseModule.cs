using BOSCommon.Constants;
using BOSLib;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.SlimDatabase
{
    public class SlimDatabaseModule : BaseModuleERP
    {
        public SlimDatabaseModule()
        {
            Name = "SlimDatabase";
            CurrentModuleEntity = new SlimDatabaseEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();
        }

        public void DeleteAccountPayableData(DateTime fromDate, DateTime toDate)
        {
            BOSProgressBar.Start(SlimDatabaseLocalizedResources.DeletingAccountPayableDataMessage);
            SlimDatabaseController slimDatabaseController = new SlimDatabaseController();
            DateTime endDate;
            string criteria = string.Empty;
            for (DateTime date = fromDate; date <= toDate; date = date.AddDays(30))
            {
                endDate = date.AddDays(29);
                if (endDate.Date > toDate.Date)
                    endDate = toDate;
                criteria = BuildCriteriaForDeleting(TableName.APProposalsTableName, date, endDate);
                bool isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.APProposalsTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                criteria = BuildCriteriaForDeleting(TableName.APPurchaseOrdersTableName, date, endDate);
                isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.APPurchaseOrdersTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                criteria = BuildCriteriaForDeleting(TableName.APInvoiceInsTableName, date, endDate);
                isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.APInvoiceInsTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                criteria = BuildCriteriaForDeleting(TableName.APReturnSuppliersTableName, date, endDate);
                isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.APReturnSuppliersTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                criteria = BuildCriteriaForDeleting(TableName.APOpenDocumentsTableName, date, endDate);
                isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.APOpenDocumentsTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                criteria = BuildCriteriaForDeleting(TableName.APDocumentPaymentsTableName, date, endDate);
                isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.APDocumentPaymentsTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                criteria = BuildCriteriaForDeleting(TableName.APSupplierPaymentsTableName, date, endDate);
                isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.APSupplierPaymentsTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                criteria = BuildCriteriaForDeleting(TableName.APPaymentVouchersTableName, date, endDate);
                isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.APPaymentVouchersTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            BOSProgressBar.Close();
        }

        public void DeleteAccountReceivableData(DateTime fromDate, DateTime toDate)
        {
            BOSProgressBar.Start(SlimDatabaseLocalizedResources.DeletingAccountReceivableDataMessage);
            SlimDatabaseController slimDatabaseController = new SlimDatabaseController();
            DateTime endDate;
            string criteria = string.Empty;
            for (DateTime date = fromDate; date <= toDate; date = date.AddDays(30))
            {
                endDate = date.AddDays(29);
                if (endDate.Date > toDate.Date)
                    endDate = toDate;
                criteria = BuildCriteriaForDeleting(TableName.ARCancelVouchersTableName, fromDate, endDate);
                bool isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.ARCancelVouchersTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                criteria = BuildCriteriaForDeleting(TableName.ARCreditNotesTableName, fromDate, endDate);
                isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.ARCreditNotesTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                criteria = BuildCriteriaForDeleting(TableName.ARCustomerPaymentsTableName, fromDate, endDate);
                isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.ARCustomerPaymentsTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                criteria = BuildCriteriaForDeleting(TableName.AROpenDocumentsTableName, fromDate, endDate);
                isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.AROpenDocumentsTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                criteria = BuildCriteriaForDeleting(TableName.ARInvoicesTableName, fromDate, endDate);
                isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.ARInvoicesTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                criteria = BuildCriteriaForDeleting(TableName.ARProposalsTableName, fromDate, endDate);
                isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.ARProposalsTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                criteria = BuildCriteriaForDeleting(TableName.ARReceiptVouchersTableName, fromDate, endDate);
                isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.ARReceiptVouchersTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                criteria = BuildCriteriaForDeleting(TableName.ARSaleOrdersTableName, fromDate, endDate);
                isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.ARSaleOrdersTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                criteria = BuildCriteriaForDeleting(TableName.ARSaleReturnsTableName, fromDate, endDate);
                isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.ARSaleReturnsTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            BOSProgressBar.Close();
        }

        public void DeleteInventoryControlData(DateTime fromDate, DateTime toDate)
        {
            BOSProgressBar.Start(SlimDatabaseLocalizedResources.DeletingInventoryControlDataMessage);
            SlimDatabaseController slimDatabaseController = new SlimDatabaseController();
            DateTime endDate;
            string criteria = string.Empty;
            for (DateTime date = fromDate; date <= toDate; date = date.AddDays(30))
            {
                endDate = date.AddDays(29);
                if (endDate.Date > toDate.Date)
                    endDate = toDate;
                criteria = BuildCriteriaForDeleting(TableName.ICReceiptsTableName, fromDate, endDate);
                bool isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.ICReceiptsTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                criteria = BuildCriteriaForDeleting(TableName.ICShipmentsTableName, fromDate, endDate);
                isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.ICShipmentsTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                criteria = BuildCriteriaForDeleting(TableName.ICTransfersTableName, fromDate, endDate);
                isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.ICTransfersTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                criteria = BuildCriteriaForDeleting(TableName.ICInventoryStockCountsTableName, fromDate, endDate);
                isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.ICInventoryStockCountsTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            BOSProgressBar.Close();
        }

        public void DeleteHumanResourcesData(DateTime fromDate, DateTime toDate)
        {
            BOSProgressBar.Start(SlimDatabaseLocalizedResources.DeletingHumanResourceDataMessage);
            SlimDatabaseController slimDatabaseController = new SlimDatabaseController();
            DateTime endDate;
            string criteria = string.Empty;
            for (DateTime date = fromDate; date <= toDate; date = date.AddDays(30))
            {
                endDate = date.AddDays(10);
                if (endDate.Date > toDate.Date)
                    endDate = toDate;
                criteria = BuildCriteriaForDeleting(TableName.HRTimeSheetsTableName, fromDate, endDate);
                bool isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.HRTimeSheetsTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                criteria = BuildCriteriaForDeleting(TableName.HRPayRollsTableName, fromDate, endDate);
                isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.HRPayRollsTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //criteria = BuildCriteriaForDeleting(TableName.HRCalendarsTableName, fromDate, toDate);
                //isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.HRCalendarsTableName, criteria);
                //if (!isSuccess)
                //{
                //    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
            }
            BOSProgressBar.Close();

        }

        public void DeleteAccountingData(DateTime fromDate, DateTime toDate)
        {
            BOSProgressBar.Start(SlimDatabaseLocalizedResources.DeletingAccountingDataMessage);
            SlimDatabaseController slimDatabaseController = new SlimDatabaseController();
            DateTime endDate;
            string criteria = string.Empty;
            for (DateTime date = fromDate; date <= toDate; date = date.AddDays(30))
            {
                endDate = date.AddDays(29);
                if (endDate.Date > toDate.Date)
                    endDate = toDate;
                criteria = BuildCriteriaForDeleting(TableName.ACAssetReceiptsTableName, fromDate, endDate);
                bool isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.ACAssetReceiptsTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                criteria = BuildCriteriaForDeleting(TableName.ACBankTransactionsTableName, fromDate, endDate);
                isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.ACBankTransactionsTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                criteria = BuildCriteriaForDeleting(TableName.ACDocumentsTableName, fromDate, endDate);
                isSuccess = slimDatabaseController.DeleteDataByTableNameAndSomeCriteria(TableName.ACDocumentsTableName, criteria);
                if (!isSuccess)
                {
                    BOSProgressBar.Close();
                    MessageBox.Show(SlimDatabaseLocalizedResources.DeleteDataUnsuccessfulMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            BOSProgressBar.Close();

        }

        private string BuildCriteriaForDeleting(string tableName, DateTime fromDate, DateTime toDate)
        {
            string sql = string.Empty;
            string columnName = tableName.Substring(0, tableName.Length - 1) + "Date";
            sql = "DATEDIFF(DD, '" + fromDate.ToString("yyyy-MM-dd") + "', " + columnName + ") >= 0";
            sql += " AND DATEDIFF(DD, '" + toDate.ToString("yyyy-MM-dd") + "', " + columnName + ") <= 0";
            return sql;
        }


    }
}
