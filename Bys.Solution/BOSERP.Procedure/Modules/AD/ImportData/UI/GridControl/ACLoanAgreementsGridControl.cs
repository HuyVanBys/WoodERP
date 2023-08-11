using BOSComponent;
using System.Windows.Forms;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.ImportData
{
    public partial class ACLoanAgreementsGridControl : BOSGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
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
            column.FieldName = "ACLoanAgreementNo";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngân hàng";
            column.FieldName = "FK_CSCompanyBankID";
            RepositoryItemLookUpEdit repository = new RepositoryItemLookUpEdit();
            CSCompanyBanksController controller = new CSCompanyBanksController();
            List<CSCompanyBanksInfo> companyBanksInfo = controller.GetAllBanks();
            repository.DataSource = companyBanksInfo;
            repository.DisplayMember = "CSCompanyBankName";
            repository.ValueMember = "CSCompanyBankID";
            repository.NullText = string.Empty;
            repository.Columns.Add(new LookUpColumnInfo("CSCompanyBankCode", "Mã ngân hàng"));
            repository.Columns.Add(new LookUpColumnInfo("CSCompanyBankName", "Tên ngân hàng"));
            repository.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryCompanyBanks_QueryPopUp);
            column.ColumnEdit = repository;
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày hợp đồng";
            column.FieldName = "ACLoanAgreementDate";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày hết hạn hợp đồng";
            column.FieldName = "ACLoanAgreementDeadline";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tổng hạn mức";
            column.FieldName = "ACLoanAgreementTotalLimit";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tổng hạn mức vay";
            column.FieldName = "ACLoanAgreementAmount";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Hạn mức LC";
            column.FieldName = "ACLoanAgreementLCLimit";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số nhận nợ";
            column.FieldName = "ACLoanAgreementReceiptAmount";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Còn lại";
            column.FieldName = "ACLoanAgreementRemainAmount";
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
        }

        private void repositoryCompanyBanks_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            CSCompanyBanksController controller = new CSCompanyBanksController();
            List<CSCompanyBanksInfo> companyBanksInfo = controller.GetAllBanks();
            lookUpEdit.Properties.DataSource = companyBanksInfo;
            lookUpEdit.Properties.DisplayMember = "CSCompanyBankName";
            lookUpEdit.Properties.ValueMember = "CSCompanyBankID";
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
            ACLoanAgreementsInfo objLoanAgreementsInfo = (ACLoanAgreementsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            objLoanAgreementsInfo.FK_BRBranchID = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            gridView.SetRowCellValue(e.RowHandle, "FK_BRBranchID", BOSApp.CurrentCompanyInfo.FK_BRBranchID);
        }
    }
}
