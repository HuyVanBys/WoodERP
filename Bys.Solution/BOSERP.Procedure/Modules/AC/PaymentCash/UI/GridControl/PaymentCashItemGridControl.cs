using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.PaymentCash
{
    public partial class PaymentCashItemGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            PaymentCashEntities entity = (PaymentCashEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)((BaseModuleERP)Screen.Module).CurrentModuleEntity.MainObject;
            entity.BankTransactionItemList.ForEach(x => x.ACDocumentNo = mainObject.ACBankTransactionReference);
            bds.DataSource = entity.BankTransactionItemList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = PaymentCashLocalizedResources.ACDocumentNo;
            column.FieldName = "ACDocumentNo";
            gridView.Columns.Add(column);
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

            column = gridView.Columns["FK_ACDebitAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
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
            gridView.InitNewRow += new InitNewRowEventHandler(gridView1_InitNewRow);
            return gridView;
        }

        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            PaymentCashEntities entity = (PaymentCashEntities)((BaseTransactionModule)Screen.Module).CurrentModuleEntity;
            ACBankTransactionsInfo mainObject = (ACBankTransactionsInfo)entity.MainObject;
            ACBankTransactionItemsInfo item = (ACBankTransactionItemsInfo)view.GetRow(e.RowHandle);
            item.ACBankTransactionItemDesc = mainObject.ACBankTransactionDesc;
            if (item != null)
            {
                ((PaymentCashModule)Screen.Module).SetItemDefaultAccount(item);
            }
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            ACBankTransactionItemsInfo objBankTransactionItemsInfo = (ACBankTransactionItemsInfo)gridView.GetRow(e.RowHandle);
            if (objBankTransactionItemsInfo != null)
            {
                if (gridView.FocusedColumn.FieldName == "ACBankTransactionItemAmount")
                {
                    ((PaymentCashModule)Screen.Module).ChangePaymentCashItemAmount(objBankTransactionItemsInfo);
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((PaymentCashModule)Screen.Module).RemoveSelectedItem();
            }
        }
    }
}
