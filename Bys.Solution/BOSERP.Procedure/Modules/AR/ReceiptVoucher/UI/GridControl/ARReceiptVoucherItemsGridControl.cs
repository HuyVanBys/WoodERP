using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ReceiptVoucher
{
    public class ARReceiptVoucherItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ReceiptVoucherEntities entity = (ReceiptVoucherEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ReceiptVoucherItemList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.OptionsView.ShowFooter = true;
            gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(gridView_FocusedRowChanged);
            GridColumn column = gridView.Columns["ARReceiptVoucherItemAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                InitColumnSummary("ARReceiptVoucherItemAmount", DevExpress.Data.SummaryItemType.Sum);
            }
            column = gridView.Columns["ARReceiptVoucherItemExchangeAmount"];
            if (column != null)
            {
                InitColumnSummary("ARReceiptVoucherItemExchangeAmount", DevExpress.Data.SummaryItemType.Sum);
                column.OptionsColumn.AllowEdit = true;
            }

            //RepositoryItemBOSLookupEdit rep = InitColumnLookupEdit(TableName.ACAccountsTableName, CommonLocalizedResources.ACAccountNo);
            //rep.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", CommonLocalizedResources.ACAccountName));

            column = gridView.Columns["FK_ACDebitAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                //column.ColumnEdit = rep;
            }

            column = gridView.Columns["FK_ACCreditAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                //column.ColumnEdit = rep;
            }

            column = gridView.Columns["ARReceiptVoucherItemDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ReceiptVoucherEntities entity = (ReceiptVoucherEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ARReceiptVouchersInfo objARReceiptVouchersInfo = (ARReceiptVouchersInfo)entity.MainObject;
            ARReceiptVoucherItemsInfo objARReceiptVoucherItemsInfo = (ARReceiptVoucherItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (objARReceiptVoucherItemsInfo != null)
            {
                //ACAccountsController accountController = new ACAccountsController();
                //ACAccountsInfo account = accountController.GetObjectByNo(AccAccount.Acc1111) as ACAccountsInfo;
                //if (account != null && objReceiptVoucherItemsInfo.FK_ACDebitAccountID != account.ACAccountID)
                //    objReceiptVoucherItemsInfo.FK_ACDebitAccountID = account.ACAccountID;
                CSCashFundsController objCSCashFundsController = new CSCashFundsController();
                CSCashFundsInfo objCSCashFundsInfo = (CSCashFundsInfo)objCSCashFundsController.GetObjectByID(objARReceiptVouchersInfo.FK_CSCashFundID);
                if (objCSCashFundsInfo != null && objCSCashFundsInfo.FK_ACAcountID > 0)
                {
                    objARReceiptVoucherItemsInfo.FK_ACDebitAccountID = objCSCashFundsInfo.FK_ACAcountID;
                }
            }
        }


        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ARReceiptVoucherItemsInfo objReceiptVoucherItemsInfo = (ARReceiptVoucherItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (objReceiptVoucherItemsInfo != null)
            {
                if (gridView.FocusedColumn.FieldName == "ARReceiptVoucherItemAmount")
                {
                    ((ReceiptVoucherModule)Screen.Module).ChangeReceiptVoucherItemAmount(objReceiptVoucherItemsInfo);
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ReceiptVoucherModule)Screen.Module).RemoveSelectedItem();
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

        private void repositoryLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACAccountsController objAccountsController = new ACAccountsController();
            lookUpEdit.Properties.DataSource = objAccountsController.GetListAccountNotChild().Tables[0];
        }
        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);
            ReceiptVoucherEntities entity = (ReceiptVoucherEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ARReceiptVouchersInfo mainObject = (ARReceiptVouchersInfo)entity.MainObject;
            GridView gridView = (GridView)sender;
            ARReceiptVoucherItemsInfo objReceiptVoucherItemsInfo = (ARReceiptVoucherItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            objReceiptVoucherItemsInfo.ARReceiptVoucherItemDesc = mainObject.ARReceiptVoucherDesc;
            
            CSCashFundsInfo objCSCashFundsInfo = (CSCashFundsInfo)(new CSCashFundsController()).GetObjectByID(mainObject.FK_CSCashFundID);
            if (objCSCashFundsInfo != null && objCSCashFundsInfo.FK_ACAcountID > 0)
            {
                objReceiptVoucherItemsInfo.FK_ACDebitAccountID = objCSCashFundsInfo.FK_ACAcountID;
            }
            ACObjectsInfo objObjectsInfo = BOSApp.AccountingObjects.FirstOrDefault(o => o.ACObjectID == mainObject.FK_ACObjectID && o.ACObjectType == mainObject.ARObjectType);
            if (objObjectsInfo != null && objObjectsInfo.FK_ACAccountSaleID > 0)
            {
                objReceiptVoucherItemsInfo.FK_ACCreditAccountID = objObjectsInfo.FK_ACAccountSaleID;
            }
        }
    }
}
