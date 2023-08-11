using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BankTransaction
{
    public partial class BankTransactionItemGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            BankTransactionEntities entity = (BankTransactionEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.BankTransactionItemList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.OptionsView.ShowFooter = true;
            GridColumn column = gridView.Columns["ACBankTransactionItemAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                InitColumnSummary("ACBankTransactionItemAmount", DevExpress.Data.SummaryItemType.Sum);
            }
            column = gridView.Columns["ACBankTransactionItemExchangeAmount"];
            if (column != null)
            {
                InitColumnSummary("ACBankTransactionItemExchangeAmount", DevExpress.Data.SummaryItemType.Sum);
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ACBankTransactionItemTotalExchangeAmount"];
            if (column != null)
            {
                InitColumnSummary("ACBankTransactionItemTotalExchangeAmount", DevExpress.Data.SummaryItemType.Sum);
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACDebitAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }

            column = gridView.Columns["FK_ACCreditAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ACBankTransactionItemDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACSegmentID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;

            }
            column = gridView.Columns["FK_ACCostCenterID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACCostObjectID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_VMVehicleID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ACBankTransactionItemFeeAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            BankTransactionEntities entity = (BankTransactionEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            ACBankTransactionsInfo bankTransfer = (ACBankTransactionsInfo)entity.MainObject;
            ACBankTransactionItemsInfo objBankTransactionItemsInfo = entity.BankTransactionItemList[entity.BankTransactionItemList.CurrentIndex];

            if (objBankTransactionItemsInfo != null)
            {
                if (gridView.FocusedColumn.FieldName == "ACBankTransactionItemAmount")
                {
                    ((BankTransactionModule)Screen.Module).ChangeBankTransferItemAmount(objBankTransactionItemsInfo);
                }
                else if (gridView.FocusedColumn.FieldName == "ACBankTransactionItemExchangeAmount")
                {
                    objBankTransactionItemsInfo.ACBankTransactionItemTotalExchangeAmount = objBankTransactionItemsInfo.ACBankTransactionItemExchangeAmount - (objBankTransactionItemsInfo.ACBankTransactionItemTaxAmount + objBankTransactionItemsInfo.ACBankTransactionItemFeeAmount) * bankTransfer.ACBankTransactionExchangeRate;
                    ((BankTransactionModule)Screen.Module).ChangeBankTransferItemExchangeAmount(objBankTransactionItemsInfo);
                }
                else if (gridView.FocusedColumn.FieldName == "ACBankTransactionItemTotalExchangeAmount")
                {
                    ((BankTransactionModule)Screen.Module).ChangeBankTransferItemExchangeAmount(objBankTransactionItemsInfo);
                }
                else if (gridView.FocusedColumn.FieldName == "ACBankTransactionItemFeeAmount")
                {
                    if (objBankTransactionItemsInfo.ACBankTransactionItemFeeAmount > objBankTransactionItemsInfo.ACBankTransactionItemAmount)
                    {
                        MessageBox.Show(CustomerPaymentTimePaymentLocalizedResources.ErrorBankFeeAmount,
                                        CommonLocalizedResources.MessageBoxDefaultCaption,
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        objBankTransactionItemsInfo.ACBankTransactionItemFeeAmount = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                    }
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((BankTransactionModule)Screen.Module).RemoveSelectedItem();
            }
        }

        protected override void GridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);

            GridView gridView = (GridView)sender;
            BankTransactionEntities entity = (BankTransactionEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;
            ACBankTransactionItemsInfo objBankTransactionItemsInfo = entity.BankTransactionItemList[entity.BankTransactionItemList.CurrentIndex];

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
            else if (gridView.FocusedColumn.FieldName == "ACBankTransactionItemFeeAmount")
            {
                if (objBankTransactionItemsInfo.ACBankTransactionItemFeeAmount > objBankTransactionItemsInfo.ACBankTransactionItemAmount)
                {
                    e.ErrorText = CustomerPaymentTimePaymentLocalizedResources.ErrorBankFeeAmount;
                    e.Valid = false;
                }
            }
            else if (gridView.FocusedColumn.FieldName == "ACBankTransactionItemExchangeAmount")
            {
                decimal chenhlech = Math.Abs(mainObject.ACBankTransactionExchangeRate * objBankTransactionItemsInfo.ACBankTransactionItemAmount - Convert.ToDecimal(e.Value));
                if (chenhlech > 0 && mainObject.ACBankTransactionExchangeRate * objBankTransactionItemsInfo.ACBankTransactionItemAmount > 0)
                {
                    decimal phantram = chenhlech / (mainObject.ACBankTransactionExchangeRate * objBankTransactionItemsInfo.ACBankTransactionItemAmount) * 100;
                    if (phantram > 5)
                    {
                        e.ErrorText = "Số tiền quy đổi lệch quá nhiều so với tính toán theo Tỷ giá";
                        e.Valid = false;
                    }
                }
            }
            else if (gridView.FocusedColumn.FieldName == "ACBankTransactionItemTotalExchangeAmount")
            {
                decimal chenhlech = Math.Abs(mainObject.ACBankTransactionExchangeRate * objBankTransactionItemsInfo.ACBankTransactionItemTotalAmount - Convert.ToDecimal(e.Value));
                if (chenhlech > 0 && mainObject.ACBankTransactionExchangeRate * objBankTransactionItemsInfo.ACBankTransactionItemTotalAmount > 0)
                {
                    decimal phantram = chenhlech / (mainObject.ACBankTransactionExchangeRate * objBankTransactionItemsInfo.ACBankTransactionItemTotalAmount) * 100;
                    if (phantram > 5)
                    {
                        e.ErrorText = "Số tiền quy đổi lệch quá nhiều so với tính toán theo Tỷ giá";
                        e.Valid = false;
                    }
                }
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = PaymentOrderLocalizedResources.ACLoanReceiptNo;
            column.FieldName = "ACBankTransactionItemReference";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);
            BankTransactionEntities entity = (BankTransactionEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;
            CSCompanyBanksController objCompanyBanksController = new CSCompanyBanksController();
            CSCompanyBanksInfo objCompanyBanksInfo = (CSCompanyBanksInfo)objCompanyBanksController.GetObjectByID(mainObject.FK_CSCompanyBankID);
            ACLoanReceiptsInfo objLoanReceiptsInfo = (new ACLoanReceiptsController()).GetLoanReceiptByID(mainObject.FK_ACLoanReceiptID);

            GridView gridView = (GridView)sender;
            ACBankTransactionItemsInfo objBankTransactionItemsInfo = (ACBankTransactionItemsInfo)gridView.GetRow(e.RowHandle);
            objBankTransactionItemsInfo.ACBankTransactionItemDesc = mainObject.ACBankTransactionDesc;
            if (objCompanyBanksInfo != null)
            {
                objBankTransactionItemsInfo.FK_ACDebitAccountID = objCompanyBanksInfo.FK_ACAcountID;
            }

            ACObjectsInfo objObjectsInfo = BOSApp.AccountingObjects.FirstOrDefault(o => o.ACObjectID == mainObject.FK_ACObjectID && o.ACObjectType == mainObject.ACObjectType);
            if (objObjectsInfo != null && objObjectsInfo.FK_ACAccountSaleID > 0)
            {
                objBankTransactionItemsInfo.FK_ACCreditAccountID = objObjectsInfo.FK_ACAccountSaleID;
            }
            else if(objLoanReceiptsInfo != null && objLoanReceiptsInfo.FK_ACAccountID > 0)
            {
                objBankTransactionItemsInfo.FK_ACCreditAccountID = objLoanReceiptsInfo.FK_ACAccountID;
            }    
        }
    }
}
