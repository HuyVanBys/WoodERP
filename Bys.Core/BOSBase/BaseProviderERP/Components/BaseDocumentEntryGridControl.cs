using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class BaseDocumentEntryGridControl : BOSGridControl
    {
        /// <summary>
        /// Invalidate data source of the document entry grid control
        /// </summary>
        /// <param name="documentEntryList">Document entry list</param>
        public void InvalidateDataSource(List<ACDocumentEntrysInfo> documentEntryList)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = documentEntryList;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.OptionsView.ShowFooter = true;

            GridColumn column = gridView.Columns["ACDocumentEntryAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                InitColumnSummary("ACDocumentEntryAmount", DevExpress.Data.SummaryItemType.Sum);
            }
            column = gridView.Columns["ACDocumentEntryExchangeAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                InitColumnSummary("ACDocumentEntryExchangeAmount", DevExpress.Data.SummaryItemType.Sum);
            }

            column = gridView.Columns["FK_ACDebitAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                //column.ColumnEdit = rep;
            }

            column = gridView.Columns["FK_ACCreditAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                //column.ColumnEdit = rep;
            }

            column = gridView.Columns["ACDocumentEntryDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ACCostObjectID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ACDocumentEntryAllocatedAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ACObjectNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["ACObjectName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["FK_ACUnfinishedConstructionCostID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_PMProjectID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "ARInvoiceNo";
            column.OptionsColumn.AllowEdit = false;
            column.Caption = "Hóa đơn";
            gridView.Columns.Add(column);
        }
        private void repositoryLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACAccountsController objAccountsController = new ACAccountsController();
            lookUpEdit.Properties.DataSource = objAccountsController.GetListAccountNotChild().Tables[0];
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            if (e.Column.FieldName == "ACDocumentEntryAmount")
            {
                ACDocumentEntrysInfo objDocumentEntrysInfo = (ACDocumentEntrysInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objDocumentEntrysInfo != null)
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    BusinessObject mainObject = ((BaseModuleERP)Screen.Module).CurrentModuleEntity.MainObject;

                    int currecyID = Convert.ToInt32(dbUtil.GetPropertyValue(mainObject, "FK_GECurrencyID"));
                    BOSApp.RoundByCurrency(objDocumentEntrysInfo, "ACDocumentEntryAmount", currecyID);

                    string tableName = BOSUtil.GetTableNameFromBusinessObject(mainObject);
                    string tablePrefix = tableName.Substring(0, tableName.Length - 1);
                    decimal exchangeRate = Convert.ToDecimal(dbUtil.GetPropertyValue(mainObject, tablePrefix + "ExchangeRate"));
                    objDocumentEntrysInfo.ACDocumentEntryExchangeAmount = objDocumentEntrysInfo.ACDocumentEntryAmount * exchangeRate;
                    BOSApp.RoundByCurrency(objDocumentEntrysInfo, "ACDocumentEntryExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                BOSList<ACDocumentEntrysInfo> entries = (BOSList<ACDocumentEntrysInfo>)((BindingSource)DataSource).DataSource;
                entries.RemoveSelectedRowObjectFromList();
            }
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn.FieldName == "FK_ACDebitAccountID" || gridView.FocusedColumn.FieldName == "FK_ACCreditAccountID")
            {
                ACAccountsController objAccountsController = new ACAccountsController();
                ACAccountsInfo account = objAccountsController.GetAccountByID(Convert.ToInt32(e.Value));
                if (account != null && account.HasChildAccount)
                {
                    e.ErrorText = CommonLocalizedResources.CannotMakeEntryWithParentAccountMessage;
                    e.Valid = false;
                }
            }
        }
    }
}

