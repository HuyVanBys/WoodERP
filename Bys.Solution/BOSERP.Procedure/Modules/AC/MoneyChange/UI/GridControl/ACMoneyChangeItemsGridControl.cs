using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.MoneyChange
{
    public partial class ACMoneyChangeItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            MoneyChangeEntities entity = (MoneyChangeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.MoneyChangeItemList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.OptionsView.ShowFooter = true;
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                gridView.Columns[i].OptionsColumn.AllowEdit = true;
            }

            GridColumn column = gridView.Columns["ACObjectAccessKey"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACObjectName";
                repositoryItemLookUpEdit.ValueMember = "ACObjectAccessKey";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.DataSource = GetDataSourceFormObjectLookup();
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectNo", CommonLocalizedResources.ACObjectNo));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectName", CommonLocalizedResources.ACObjectName));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectContactAddress", CommonLocalizedResources.ACObjectContactAddress));
                repositoryItemLookUpEdit.CloseUp += new CloseUpEventHandler(repositoryItemLookUpEdit_CloseUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            column = gridView.Columns["ACMoneyChangeItemDebitExchangeAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                InitColumnSummary("ACMoneyChangeItemDebitExchangeAmount", DevExpress.Data.SummaryItemType.Sum);
            }
            column = gridView.Columns["ACMoneyChangeItemCreditExchangeAmount"];
            if (column != null)
            {
                InitColumnSummary("ACMoneyChangeItemCreditExchangeAmount", DevExpress.Data.SummaryItemType.Sum);
                column.OptionsColumn.AllowEdit = false;
            }

            gridView.InitNewRow += new InitNewRowEventHandler(gridView1_InitNewRow);
            return gridView;
        }

        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            MoneyChangeEntities entity = (MoneyChangeEntities)((BaseTransactionModule)Screen.Module).CurrentModuleEntity;
            ACMoneyChangesInfo mainObject = (ACMoneyChangesInfo)entity.MainObject;
            ACMoneyChangeItemsInfo item = (ACMoneyChangeItemsInfo)view.GetRow(e.RowHandle);
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            ACMoneyChangeItemsInfo item = (ACMoneyChangeItemsInfo)gridView.GetRow(e.RowHandle);
            if (item == null)
                return;

            if (gridView.FocusedColumn.FieldName == "FK_CSCashFundID")
            {
                ((MoneyChangeModule)Screen.Module).ChangeCashFund(item);
            }
            if (gridView.FocusedColumn.FieldName == "FK_CSCompanyBankID")
            {
                ((MoneyChangeModule)Screen.Module).ChangeCompanyBank(item);
            }
            if (gridView.FocusedColumn.FieldName == "ACMoneyChangeItemDebitAmount"
                || gridView.FocusedColumn.FieldName == "ACMoneyChangeItemExchangeRate"
                || gridView.FocusedColumn.FieldName == "ACMoneyChangeItemCreditAmount")
            {
                ((MoneyChangeModule)Screen.Module).ChangeItemAmount(item);
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((MoneyChangeModule)Screen.Module).RemoveSelectedItem();
            }
        }

        private void repositoryItemLookUpEdit_CloseUp(object sender, CloseUpEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            if (e.Value != null && lke.OldEditValue != e.Value)
            {
                ((MoneyChangeModule)Screen.Module).ChangeItemObject(Convert.ToString(e.Value));
            }
        }

        public List<ACObjectsInfo> GetDataSourceFormObjectLookup()
        {
            List<ACObjectsInfo> objectList = BOSApp.AccountingObjects;
            objectList.Insert(0, new ACObjectsInfo());
            return objectList;
        }
    }
}
