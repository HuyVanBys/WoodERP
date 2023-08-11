using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.InvoiceInTransaction
{
    public partial class APInvoiceInTransactionsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            InvoiceInTransactionEntities entity = (InvoiceInTransactionEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.InvoiceInTransactionList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                gridView.Columns[i].OptionsColumn.AllowEdit = true;
            }

            RepositoryItemBOSLookupEdit rep = new RepositoryItemBOSLookupEdit(); ;

            GridColumn column = gridView.Columns["FK_ACAccountID"];
            if (column != null)
            {
                rep.ValueMember = "ACAccountID";
                rep.DisplayMember = "ACAccountNo";
                rep.TextEditStyle = TextEditStyles.Standard;
                rep.Columns.Add(new LookUpColumnInfo("ACAccountNo", CommonLocalizedResources.ACAccountNo));
                rep.Columns.Add(new LookUpColumnInfo("ACAccountName", CommonLocalizedResources.ACAccountName));
                DataSet ds = ((IBaseModuleERP)Screen.Module).GetLookupTableData("ACAccounts");
                if (ds == null || (ds != null && ds.Tables.Count == 0))
                {
                    ACAccountsController objAccountsController = new ACAccountsController();
                    ds = objAccountsController.GetAllAccountSet();
                }
                rep.DataSource = ds.Tables[0];
                rep.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryLookupEdit_QueryPopUp);
                column.ColumnEdit = rep;
            }

            column = gridView.Columns["FK_GECurrencyID"];
            if (column != null)
            {
                rep = new RepositoryItemBOSLookupEdit();
                rep.ValueMember = "GECurrencyID";
                rep.DisplayMember = "GECurrencyNo";
                rep.TextEditStyle = TextEditStyles.Standard;
                rep.Columns.Add(new LookUpColumnInfo("GECurrencyNo", SupplierLocalizedResources.GECurrencyName));
                DataSet ds = ((IBaseModuleERP)Screen.Module).GetLookupTableData("GECurrencies");
                if (ds == null || (ds != null && ds.Tables.Count == 0))
                {
                    GECurrenciesController objCurrenciesController = new GECurrenciesController();
                    rep.DataSource = objCurrenciesController.GetAllCurrencys();
                }
                else
                {
                    rep.DataSource = ds.Tables[0];
                }
                column.ColumnEdit = rep;
            }

            column = gridView.Columns["APInvoiceInTransactionMethod"];
            if (column != null)
            {
                rep = new RepositoryItemBOSLookupEdit();
                rep.ValueMember = "Value";
                rep.DisplayMember = "Text";
                rep.TextEditStyle = TextEditStyles.Standard;
                rep.Columns.Add(new LookUpColumnInfo("Text", BankTransactionLocalizedResources.PaymentMethod));
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                DataSet ds = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup(BankTransactionLocalizedResources.PaymentMethodKeyGroup);
                rep.DataSource = ds.Tables[0];
                column.ColumnEdit = rep;
            }

            column = gridView.Columns["APInvoiceInAmountExchange"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
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

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            //column = new GridColumn();
            //column.Caption = "Lưu";
            //column.FieldName = "SaveItem";
            //RepositoryItemHyperLinkEdit rpSaveItem = new RepositoryItemHyperLinkEdit();
            //rpSaveItem.NullText = "Lưu";
            //rpSaveItem.Click += new EventHandler(rpSaveItem_Click);
            //column.ColumnEdit = rpSaveItem;
            //gridView.Columns.Add(column);

            ACObjectsController objObjectsController = new ACObjectsController();
            GridColumn newColumn = new GridColumn();
            newColumn.Caption = "Mã đối tượng";
            newColumn.FieldName = "ACObjectAccessKey";
            newColumn.OptionsColumn.AllowEdit = true;
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DataSource = objObjectsController.GetObjectList(null, null);
            repositoryItemLookUpEdit.DisplayMember = "ACObjectName";
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
        }

        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);

            GridView gridView = (GridView)sender;
            gridView.SetRowCellValue(e.RowHandle, "APInvoiceInTransactionReferenceDate", BOSApp.CurrentCompanyInfo.CSCompanyStartDate.AddDays(-1));
            gridView.SetRowCellValue(e.RowHandle, "FK_BRBranchID", BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            gridView.SetRowCellValue(e.RowHandle, "FK_GECurrencyID", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
            gridView.SetRowCellValue(e.RowHandle, "APInvoiceInTransactionExchangeRate", 1);
            gridView.SetRowCellValue(e.RowHandle, "APInvoiceInDate", DateTime.Now);
            gridView.SetRowCellValue(e.RowHandle, "APInvoiceInTransactionEndDate", DateTime.Now);
        }

        private void rpSaveItem_Click(object sender, EventArgs e)
        {
            ((InvoiceInTransactionModule)Screen.Module).SaveItem();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((InvoiceInTransactionModule)Screen.Module).DeleteItem();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            InvoiceInTransactionEntities entity = (InvoiceInTransactionEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.InvoiceInTransactionList.CurrentIndex >= 0)
            {
                APInvoiceInTransactionsInfo item = (APInvoiceInTransactionsInfo)entity.InvoiceInTransactionList[entity.InvoiceInTransactionList.CurrentIndex];
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
                            item.ARObjectType = objObjectsInfo.ACObjectType;
                            item.APObjectName = objObjectsInfo.ACObjectName;
                        }
                    }
                }
                ((InvoiceInTransactionModule)Screen.Module).ChangedItem();
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
