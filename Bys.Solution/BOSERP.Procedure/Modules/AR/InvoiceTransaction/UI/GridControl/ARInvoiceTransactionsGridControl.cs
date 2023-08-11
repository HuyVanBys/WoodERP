using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BOSERP.Modules.InvoiceTransaction
{
    public partial class ARInvoiceTransactionsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            InvoiceTransactionEntities entity = (InvoiceTransactionEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.InvoiceTransactionList;
            DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.RowStyle += new RowStyleEventHandler(gridView_RowStyle);

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

            column = gridView.Columns["ARInvoiceTransactionMethod"];
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

            column = gridView.Columns["ARInvoiceAmountExchange"];
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
            gridView.SetRowCellValue(e.RowHandle, "ARInvoiceTransactionReferenceDate", BOSApp.CurrentCompanyInfo.CSCompanyStartDate.AddDays(-1));
            gridView.SetRowCellValue(e.RowHandle, "FK_BRBranchID", BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            gridView.SetRowCellValue(e.RowHandle, "FK_GECurrencyID", BOSApp.CurrentCompanyInfo.FK_GECurrencyID);
            gridView.SetRowCellValue(e.RowHandle, "ARInvoiceTransactionExchangeRate", 1);
            gridView.SetRowCellValue(e.RowHandle, "ARInvoiceDate", DateTime.Now);
            gridView.SetRowCellValue(e.RowHandle, "ARInvoiceTransactionEndDate", DateTime.Now);
        }

        private void rpSaveItem_Click(object sender, EventArgs e)
        {
            ((InvoiceTransactionModule)Screen.Module).SaveItem();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((InvoiceTransactionModule)Screen.Module).DeleteItem();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            InvoiceTransactionEntities entity = (InvoiceTransactionEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.InvoiceTransactionList.CurrentIndex >= 0)
            {
                ARInvoiceTransactionsInfo item = (ARInvoiceTransactionsInfo)entity.InvoiceTransactionList[entity.InvoiceTransactionList.CurrentIndex];
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
                            item.ARObjectName = objObjectsInfo.ACObjectName;
                        }
                    }
                }
                ((InvoiceTransactionModule)Screen.Module).ChangedItem();
            }
        }

        protected void repositoryItemLookUpEditACObjectAccessKey_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            lke.Properties.DataSource = BOSApp.AccountingObjects;
        }

        private void gridView_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView gridview = sender as GridView;
            if (e.RowHandle >= 0)
            {
                InvoiceTransactionEntities entity = (InvoiceTransactionEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;

                ARInvoiceTransactionsInfo objInvoicesInfo = entity.InvoiceTransactionList[e.RowHandle];
                if (objInvoicesInfo != null)
                {
                    if (objInvoicesInfo.Selected)
                    {
                        e.Appearance.BackColor2 = Color.White;
                        e.Appearance.BackColor = Color.White;
                        e.HighPriority = true;
                    }
                    else
                    {
                        e.Appearance.BackColor2 = Color.Yellow;
                        e.Appearance.BackColor = Color.White;
                        e.HighPriority = true;
                    }
                }
            }
        }

    }
}
