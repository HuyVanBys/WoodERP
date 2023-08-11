using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ImportData
{
    public partial class ACLoanReceiptsGridControl : BOSGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            //gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.InitNewRow += new InitNewRowEventHandler(GridView_InitNewRow);
            gridView.OptionsView.ShowFooter = true;
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            gridView.Columns.Clear();

            GridColumn column = new GridColumn();
            column.Caption = "Số hợp đồng";
            column.FieldName = "FK_ACLoanAgreementID";
            RepositoryItemLookUpEdit repository = new RepositoryItemLookUpEdit();
            DataSet ds = (new ACLoanAgreementsController()).GetAllObjects();
            repository.DataSource = ds.Tables[0];
            repository.DisplayMember = "ACLoanAgreementNo";
            repository.ValueMember = "ACLoanAgreementID";
            repository.NullText = string.Empty;
            repository.Columns.Add(new LookUpColumnInfo("ACLoanAgreementNo", "Số hợp đồng"));
            repository.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryLoanAgreement_QueryPopUp);
            column.ColumnEdit = repository;
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã khế ước";
            column.FieldName = "ACLoanReceiptNo";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Loại khế ước";
            column.FieldName = "FK_ACLoanReceiptTypeID";
            repository = new RepositoryItemLookUpEdit();
            ds = (new ACLoanReceiptTypesController()).GetAllObjects();
            repository.DataSource = ds.Tables[0];
            repository.DisplayMember = "ACLoanReceiptTypeNanme";
            repository.ValueMember = "ACLoanReceiptTypeID";
            repository.NullText = string.Empty;
            repository.Columns.Add(new LookUpColumnInfo("ACLoanReceiptTypeNanme", "Loại khế ước"));
            repository.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryCurrencies_QueryPopUp);
            column.ColumnEdit = repository;
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày nhận nợ";
            column.FieldName = "ACLoanReceiptDate";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày đáo hạn";
            column.FieldName = "ACLoanReceiptDeadline";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Kỳ hạn (tháng)";
            column.FieldName = "ACLoanReceiptLimit";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Loại tiền tệ";
            column.FieldName = "FK_GECurrencyID";
            repository = new RepositoryItemLookUpEdit();
            GECurrenciesController currenciesController = new GECurrenciesController();
            List<GECurrenciesInfo> currenciesInfo = currenciesController.GetAllCurrencys();
            repository.DataSource = currenciesInfo;
            repository.DisplayMember = "GECurrencyName";
            repository.ValueMember = "GECurrencyID";
            repository.NullText = string.Empty;
            repository.Columns.Add(new LookUpColumnInfo("GECurrencyName", "Loại tiền tệ"));
            repository.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryCurrencies_QueryPopUp);
            column.ColumnEdit = repository;
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tỷ giá";
            column.FieldName = "ACLoanReceiptExchangeRate";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Lãi suất năm";
            column.FieldName = "ACLoanReceiptInterestRate";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Lãi suất quá hạn";
            column.FieldName = "ACLoanReceiptOverdueInterestRate";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số tiền nhận nợ";
            column.FieldName = "ACLoanReceiptAmount";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số tiền nhận nợ quy đổi";
            column.FieldName = "ACLoanReceiptExchangeAmount";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số tiền đã trả";
            column.FieldName = "ACLoanReceiptOpeningPaidAmount";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số tiền còn lại";
            column.FieldName = "ACLoanReceiptRemainAmount";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }

        private void repositoryLoanAgreement_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            DataSet ds = (new ACLoanAgreementsController()).GetAllObjects();
            lookUpEdit.Properties.DataSource = ds.Tables[0];
            lookUpEdit.Properties.DisplayMember = "ACLoanAgreementNo";
            lookUpEdit.Properties.ValueMember = "ACLoanAgreementID";
        }

        private void repositoryLoanReceiptType_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            DataSet ds = (new ACLoanReceiptTypesController()).GetAllObjects();
            lookUpEdit.Properties.DataSource = ds.Tables[0];
            lookUpEdit.Properties.DisplayMember = "ACLoanReceiptTypeNanme";
            lookUpEdit.Properties.ValueMember = "ACLoanReceiptTypeID";
        }

        private void repositoryCurrencies_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            GECurrenciesController currenciesController = new GECurrenciesController();
            List<GECurrenciesInfo> currenciesInfo = currenciesController.GetAllCurrencys();
            lookUpEdit.Properties.DataSource = currenciesInfo;
            lookUpEdit.Properties.DisplayMember = "GECurrencyName";
            lookUpEdit.Properties.ValueMember = "GECurrencyID";
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                GridView gridView = (GridView)sender;
                gridView.DeleteSelectedRows();
            }
        }

        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);

            GridView gridView = (GridView)sender;
            gridView.SetRowCellValue(e.RowHandle, "FK_BRBranchID", BOSApp.CurrentCompanyInfo.FK_BRBranchID);
        }
    }
}
