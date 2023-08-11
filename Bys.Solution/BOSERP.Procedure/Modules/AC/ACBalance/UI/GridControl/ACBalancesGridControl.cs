using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.ACBalance
{
    public partial class ACBalancesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ACBalanceEntities entity = (ACBalanceEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ACBalanceList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                gridView.Columns[i].OptionsColumn.AllowEdit = true;
            }

            RepositoryItemBOSLookupEdit rep;

            GridColumn column = gridView.Columns["FK_ACAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                rep = new RepositoryItemBOSLookupEdit();
                rep.DisplayMember = "ACAccountNo";
                rep.ValueMember = "ACAccountID";
                DataSet ds = BOSApp.LookupTables[TableName.ACAccountsTableName] as DataSet;
                if (ds == null)
                {
                    ds = BOSApp.GetLookupTableData(TableName.ACAccountsTableName);
                    BOSApp.LookupTables[TableName.ACAccountsTableName] = ds;
                }
                rep.DataSource = ds.Tables[0];
                rep.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                rep.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                rep.NullText = string.Empty;
                rep.Columns.Add(new LookUpColumnInfo("ACAccountNo", CommonLocalizedResources.ACAccountNo));
                rep.Columns.Add(new LookUpColumnInfo("ACAccountName", CommonLocalizedResources.ACAccountName));
                rep.QueryPopUp += new CancelEventHandler(repositoryLookupEdit_QueryPopUp);
                column.ColumnEdit = rep;
            }

            column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {
                rep = InitColumnLookupEdit(TableName.ICProductsTableName, string.Empty, column.FieldName);
                column.ColumnEdit = rep;
            }

            column = gridView.Columns["FK_GECurrencyID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                rep = new RepositoryItemBOSLookupEdit();
                rep.DisplayMember = "GECurrencyNo";
                rep.ValueMember = "GECurrencyID";
                DataSet ds = BOSApp.LookupTables[TableName.GECurrenyTableName] as DataSet;
                if (ds == null)
                {
                    ds = BOSApp.GetLookupTableData(TableName.GECurrenyTableName);
                    BOSApp.LookupTables[TableName.GECurrenyTableName] = ds;
                }
                rep.DataSource = ds.Tables[0];
                rep.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                rep.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                rep.NullText = string.Empty;
                rep.Columns.Add(new LookUpColumnInfo("GECurrencyNo", "Loại tiền tệ"));
                rep.QueryPopUp += new CancelEventHandler(repositoryLookupEditCurrency_QueryPopUp);
                column.ColumnEdit = rep;
            }

            column = gridView.Columns["FK_HREmployeeID"];
            if (column != null)
            {
                rep = InitColumnLookupEdit(TableName.HREmployeesTableName, string.Empty, column.FieldName);
                column.ColumnEdit = rep;
            }

            column = gridView.Columns["FK_BRBranchID"];
            if (column != null)
            {
                rep = InitColumnLookupEdit(TableName.BRBranchsTableName, string.Empty, column.FieldName);
                column.ColumnEdit = rep;
            }

            column = gridView.Columns["FK_ACCostCenterID"];
            if (column != null)
            {
                rep = InitColumnLookupEdit("ACCostCenters", string.Empty, column.FieldName);
                column.ColumnEdit = rep;
            }

            column = gridView.Columns["FK_ACSegmentID"];
            if (column != null)
            {
                rep = InitColumnLookupEdit(TableName.ACSegmentsTableName, string.Empty, column.FieldName);
                column.ColumnEdit = rep;
            }

            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.InitNewRow += new InitNewRowEventHandler(GridView_InitNewRow);
            gridView.OptionsView.ShowFooter = true;
            return gridView;
        }

        private void repositoryLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACAccountsController objAccountsController = new ACAccountsController();
            lookUpEdit.Properties.DataSource = objAccountsController.GetListAccountNotChild().Tables[0];
        }

        private void repositoryLookupEditCurrency_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            DataSet ds = BOSApp.LookupTables[TableName.GECurrenyTableName] as DataSet;
            if (ds == null)
            {
                ds = BOSApp.GetLookupTableData(TableName.GECurrenyTableName);
                BOSApp.LookupTables[TableName.GECurrenyTableName] = ds;
            }
            lookUpEdit.Properties.DataSource = ds.Tables[0];
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            column = new GridColumn();
            column.Caption = "Lưu";
            column.FieldName = "SaveItem";
            RepositoryItemHyperLinkEdit rpSaveItem = new RepositoryItemHyperLinkEdit();
            rpSaveItem.NullText = "Lưu";
            rpSaveItem.Click += new EventHandler(rpSaveItem_Click);
            column.ColumnEdit = rpSaveItem;
            gridView.Columns.Add(column);

            ACObjectsController objObjectsController = new ACObjectsController();
            GridColumn newColumn = new GridColumn();
            newColumn.Caption = "Mã đối tượng";
            newColumn.FieldName = "ACObjectAccessKey";
            newColumn.OptionsColumn.AllowEdit = true;
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DataSource = objObjectsController.GetObjectList(null, null);
            repositoryItemLookUpEdit.DisplayMember = "ACObjectNo";
            repositoryItemLookUpEdit.ValueMember = "ACObjectAccessKey";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectNo", "Mã đối tượng"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectName", "Tên đối tượng"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectContactAddressLine3", "Địa chỉ"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACObjectTaxNumber", "MST"));
            repositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditACObjectAccessKey_QueryPopUp);
            newColumn.ColumnEdit = repositoryItemLookUpEdit;
            gridView.Columns.Add(newColumn);

            newColumn = new GridColumn();
            newColumn.Caption = "Tên đối tượng";
            newColumn.FieldName = "ACObjectName";
            newColumn.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(newColumn);
        }

        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);

            GridView gridView = (GridView)sender;
            gridView.SetRowCellValue(e.RowHandle, "ACBalanceDate", BOSApp.CurrentCompanyInfo.CSCompanyStartDate.AddDays(-1));
            gridView.SetRowCellValue(e.RowHandle, "FK_BRBranchID", BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            gridView.SetRowCellValue(e.RowHandle, "FK_GECurrencyID", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
            gridView.SetRowCellValue(e.RowHandle, "FK_HREmployeeID", BOSApp.CurrentUsersInfo.FK_HREmployeeID);
        }

        private void rpSaveItem_Click(object sender, EventArgs e)
        {
            ((ACBalanceModule)Screen.Module).SaveItem();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ACBalanceModule)Screen.Module).DeleteItem();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            ACBalanceEntities entity = (ACBalanceEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ACBalanceList.CurrentIndex >= 0)
            {
                ACBalancesInfo item = (ACBalancesInfo)entity.ACBalanceList[entity.ACBalanceList.CurrentIndex];
                if (e.Column.FieldName == "ACObjectAccessKey")
                {
                    string[] objArr = item.ACObjectAccessKey.ToString().Split(';');
                    if (objArr.Length == 2)
                    {
                        int objectID = int.Parse(objArr[0]);
                        ACObjectsController objectController = new ACObjectsController();
                        ACObjectsInfo objObjectsInfo = objectController.GetObjectByIDAndType(objectID, objArr[1]);
                        if (objObjectsInfo != null)
                        {
                            item.FK_ACObjectID = objObjectsInfo.ACObjectID;
                            item.ACObjectType = objObjectsInfo.ACObjectType;
                            item.ACObjectName = objObjectsInfo.ACObjectName;
                        }
                    }
                }
                if (e.Column.FieldName == "FK_GECurrencyID")
                {
                    decimal dExchangeRate = BOSApp.RealTimeExchageRateByCurrencyAndDate(item.FK_GECurrencyID, BOSApp.GetCurrentServerDate());
                    item.ACBalanceExchangeRate = dExchangeRate > 0 ? dExchangeRate : 1;
                }
                if (e.Column.FieldName == "ACBalanceDebitAmount")
                {
                    item.ACBalanceCreditAmount = 0;
                    if (item.ACBalanceDebitExchangeAmount > 0)
                        item.ACBalanceExchangeRate = item.ACBalanceDebitExchangeAmount / (item.ACBalanceDebitAmount == 0 ? 1 : item.ACBalanceDebitAmount);
                }
                if (e.Column.FieldName == "ACBalanceCreditAmount")
                {
                    item.ACBalanceDebitAmount = 0;
                    if (item.ACBalanceCreditExchangeAmount > 0)
                        item.ACBalanceExchangeRate = item.ACBalanceCreditExchangeAmount / (item.ACBalanceCreditAmount == 0 ? 1 : item.ACBalanceCreditAmount);
                }
                GECurrenciesController objCurrenciesController = new GECurrenciesController();
                GECurrenciesInfo currenciesInfo = (GECurrenciesInfo)objCurrenciesController.GetObjectByID(item.FK_GECurrencyID);
                if (currenciesInfo == null)
                    return;
                if (currenciesInfo.GECurrencyNo != CurrencyNo.VND.ToString())
                {
                    if (e.Column.FieldName == "ACBalanceDebitExchangeAmount")
                    {
                        item.ACBalanceDebitAmount = item.ACBalanceDebitExchangeAmount / item.ACBalanceExchangeRate;
                        item.ACBalanceCreditAmount = 0;
                    }
                    if (e.Column.FieldName == "ACBalanceCreditExchangeAmount")
                    {
                        item.ACBalanceCreditAmount = item.ACBalanceCreditExchangeAmount / item.ACBalanceExchangeRate;
                        item.ACBalanceDebitAmount = 0;
                    }
                }
                ((ACBalanceModule)Screen.Module).ChangedItem();
            }
        }

        protected void repositoryItemLookUpEditACObjectAccessKey_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            ACObjectsController objectController = new ACObjectsController();
            List<ACObjectsInfo> objList = objectController.GetAllObjects();
            lke.Properties.DataSource = objList;

        }
    }
}
