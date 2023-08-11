using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.SupplierPayment
{
    public partial class APSupplierPaymentDocumentsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SupplierPaymentEntities entity = (SupplierPaymentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SupplierPaymentDocumentList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.OptionsView.ShowFooter = true;

            GridColumn column = gridView.Columns["APSupplierPaymentDocumentAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                InitColumnSummary("APSupplierPaymentDocumentAmount", DevExpress.Data.SummaryItemType.Sum);
            }
            column = gridView.Columns["APSupplierPaymentDocumentExchangeAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                InitColumnSummary("APSupplierPaymentDocumentExchangeAmount", DevExpress.Data.SummaryItemType.Sum);
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
            column = gridView.Columns["APSupplierPaymentDocumentDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ACCostObjectID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ACUnfinishedConstructionCostID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
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
            if (e.Column.FieldName == "APSupplierPaymentDocumentAmount")
            {
                APSupplierPaymentDocumentsInfo objSupplierPaymentDocumentsInfo = (APSupplierPaymentDocumentsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objSupplierPaymentDocumentsInfo != null)
                {
                    BOSDbUtil dbUtil = new BOSDbUtil();
                    BusinessObject mainObject = ((BaseModuleERP)Screen.Module).CurrentModuleEntity.MainObject;

                    int currecyID = Convert.ToInt32(dbUtil.GetPropertyValue(mainObject, "FK_GECurrencyID"));
                    BOSApp.RoundByCurrency(objSupplierPaymentDocumentsInfo, "APSupplierPaymentDocumentAmount", currecyID);

                    string tableName = BOSUtil.GetTableNameFromBusinessObject(mainObject);
                    string tablePrefix = tableName.Substring(0, tableName.Length - 1);
                    decimal exchangeRate = Convert.ToDecimal(dbUtil.GetPropertyValue(mainObject, tablePrefix + "ExchangeRate"));
                    objSupplierPaymentDocumentsInfo.APSupplierPaymentDocumentExchangeAmount = objSupplierPaymentDocumentsInfo.APSupplierPaymentDocumentAmount * exchangeRate;
                    BOSApp.RoundByCurrency(objSupplierPaymentDocumentsInfo, "APSupplierPaymentDocumentExchangeAmount", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                BOSList<APSupplierPaymentDocumentsInfo> entries = (BOSList<APSupplierPaymentDocumentsInfo>)((BindingSource)DataSource).DataSource;
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
