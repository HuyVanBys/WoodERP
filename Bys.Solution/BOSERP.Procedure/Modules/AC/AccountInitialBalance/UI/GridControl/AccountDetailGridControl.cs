using BOSCommon;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.AccountInitialBalance
{
    public partial class AccountDetailGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            AccountInitialBalanceEntities entity = (AccountInitialBalanceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.AccountDetailList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = AccountInitialBalanceLocalizedResource.ACObjectName;
            column.FieldName = "ACObjectName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = AccountInitialBalanceLocalizedResource.AccountNo;
            column.FieldName = "ACAccountNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = AccountInitialBalanceLocalizedResource.AccountName;
            column.FieldName = "ACAccountName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = AccountInitialBalanceLocalizedResource.AccountDebitBalance;
            column.FieldName = "AccountDebitBalanceByCurrency";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);


            column = new GridColumn();
            column.Caption = AccountInitialBalanceLocalizedResource.AccountDebitExchangeBalance;
            column.FieldName = "AccountDebitBalance";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = AccountInitialBalanceLocalizedResource.AccountCreditBalance;
            column.FieldName = "AccountCreditBalanceByCurrency";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = AccountInitialBalanceLocalizedResource.AccountCreditExchangeBalance;
            column.FieldName = "AccountCreditBalance";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            GridColumn column = gridView.Columns["ACAccountDetailExchangeRate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            GridView gridView = (GridView)sender;
            string fieldName = gridView.FocusedColumn.FieldName;
            AccountInitialBalanceEntities entity = (AccountInitialBalanceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ACAccountsInfo account = (ACAccountsInfo)entity.AccountList.CurrentObject;
            if (!account.ACAccountType.Equals(AccAccountType.DebitCreditBalance.ToString()))
            {
                if (fieldName == "AccountCreditBalanceByCurrency" || fieldName == "AccountCreditBalance")
                {
                    if (account.ACAccountType.Equals(AccAccountType.DebitBalance.ToString()))
                    {
                        if (Convert.ToDouble(e.Value) != 0)
                        {
                            e.ErrorText = AccountInitialBalanceLocalizedResource.NotAllowInputInitialBalanceCreditErrorText;
                            e.Valid = false;
                            return;
                        }
                    }
                }
                else if (fieldName == "AccountDebitBalanceByCurrency" || fieldName == "AccountDebitBalance")
                {
                    if (account.ACAccountType.Equals(AccAccountType.CreditBalance.ToString()))
                    {
                        if (Convert.ToDouble(e.Value) != 0)
                        {
                            e.ErrorText = AccountInitialBalanceLocalizedResource.NotAllowInputInitialBalanceDebitErrorText;
                            e.Valid = false;
                            return;
                        }
                    }
                }
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                if (e.Column.FieldName == "AccountDebitBalanceByCurrency" ||
                    e.Column.FieldName == "AccountCreditBalanceByCurrency" ||
                    e.Column.FieldName == "ACAccountDetailExchangeRate")
                {
                    ACAccountDetailsInfo accountDetail = (ACAccountDetailsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    ((AccountInitialBalanceModule)Screen.Module).ChangeExchangeInfo(accountDetail);
                }
            }
        }
    }
}
