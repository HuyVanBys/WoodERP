using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace BOSERP.Modules.CompanyConstant
{
    public partial class ICImportAndExportReasonGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICImportAndExportReasonList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = new GridColumn();
            column.Caption = CompanyConstantLocalizedResources.Account;
            column.FieldName = "FK_ACAcountID";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            GridColumn column = gridView.Columns["ICImportAndExportReasonNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICImportAndExportReasonName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICImportAndExportReasonType"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ACAcountID"];
            if (column != null)
            {
                column.Caption = CompanyConstantLocalizedResources.Account;
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACAccountNo";
                repositoryItemLookUpEdit.ValueMember = "ACAccountID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountNo", CompanyConstantLocalizedResources.AccountNo));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountName", CompanyConstantLocalizedResources.AccountName));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditACAcount_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            column = gridView.Columns["FK_STModuleID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                DataSet dsModules = (new STModulesController()).GetAllModules();
                repositoryItemLookUpEdit.DataSource = dsModules.Tables[0];
                repositoryItemLookUpEdit.ValueMember = "STModuleID";
                repositoryItemLookUpEdit.DisplayMember = "STModuleDescription";
                repositoryItemLookUpEdit.ShowHeader = false;
                repositoryItemLookUpEdit.TextEditStyle = TextEditStyles.Standard;
                LookUpColumnInfo columnInfo = new LookUpColumnInfo();
                columnInfo.FieldName = "STModuleDescription";
                repositoryItemLookUpEdit.Columns.Add(columnInfo);
                repositoryItemLookUpEdit.PopupWidth = columnInfo.Width;
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemModuleLookupEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }

            return gridView;
        }

        private void repositoryItemModuleLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            STModulesController objModulesController = new STModulesController();
            DataSet dsModules = objModulesController.GetAllModules();
            lookUpEdit.Properties.DataSource = dsModules.Tables[0];
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ACAcountID")
            {
                if (e.Value != null)
                {
                    int accountID = int.Parse(e.Value.ToString());
                    ACAccountsController objAccountsController = new ACAccountsController();
                    ACAccountsInfo objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByID(accountID);
                    if (objAccountsInfo != null)
                        e.DisplayText = objAccountsInfo.ACAccountNo;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }
        }

        public void repositoryItemLookUpEditACAcount_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACAccountsController objAccountsController = new ACAccountsController();
            List<ACAccountsInfo> accountList = new List<ACAccountsInfo>();
            accountList = objAccountsController.GetAllAccountList();//GetListAccountAndParentByACAccountID(AccAccount.Acc112);
            if (accountList != null)
            {
                lookUpEdit.Properties.DataSource = accountList;
            }
            lookUpEdit.Properties.DisplayMember = "ACAccountNo";
            lookUpEdit.Properties.ValueMember = "ACAccountID";
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((CompanyConstantModule)Screen.Module).RemoveSelectedImportAndExportReason();
                }
            }
        }
    }
}
