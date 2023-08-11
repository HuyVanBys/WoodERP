using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Windows.Forms;


namespace BOSERP.Modules.CompanyConstant
{
    public partial class ICProductTypeAccountConfigsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ICProductTypeAccountConfigsList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = true;
                if (col.FieldName == "FK_ACAccountID"
                    || col.FieldName == "FK_ACAccountRevenueInternalID"
                    || col.FieldName == "FK_ACAccountCostPriceID"
                    || col.FieldName == "FK_ACAccountRevenueID"
                    || col.FieldName == "FK_ACAccountSaleReturnID"
                    || col.FieldName == "FK_ACAccountRevenueHinterLandID"
                    || col.FieldName == "FK_ACAccountDiscountID")
                {
                    GenerateAccountColumn(col);
                }
            }
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ACAccountID"
                || e.Column.FieldName == "FK_ACAccountRevenueInternalID"
                || e.Column.FieldName == "FK_ACAccountCostPriceID"
                 || e.Column.FieldName == "FK_ACAccountRevenueID"
                 || e.Column.FieldName == "FK_ACAccountSaleReturnID"
                 || e.Column.FieldName == "FK_ACAccountRevenueHinterLandID"
                 || e.Column.FieldName == "FK_ACAccountDiscountID")
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
        public void GenerateAccountColumn(GridColumn column)
        {
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DisplayMember = "ACAccountNo";
            repositoryItemLookUpEdit.ValueMember = "ACAccountID";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            DataSet ds = BOSApp.LookupTables[TableName.ACAccountsTableName] as DataSet;
            if (ds == null)
            {
                ds = BOSApp.GetLookupTableData(TableName.ACAccountsTableName);
                BOSApp.LookupTables[TableName.ACAccountsTableName] = ds;
            }
            repositoryItemLookUpEdit.DataSource = ds.Tables[0];
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountNo", "Mã tài khoản"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountName", "Tên tài khoản"));
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditACAcount_QueryPopUp);
            column.ColumnEdit = repositoryItemLookUpEdit;
        }

        public void repositoryItemLookUpEditACAcount_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            DataSet ds = BOSApp.LookupTables[TableName.ACAccountsTableName] as DataSet;
            if (ds == null)
            {
                ds = BOSApp.GetLookupTableData(TableName.ACAccountsTableName);
                BOSApp.LookupTables[TableName.ACAccountsTableName] = ds;
            }
            lookUpEdit.Properties.DataSource = ds.Tables[0];
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
                    ((CompanyConstantModule)Screen.Module).RemoveProductTypeAccountConfig();
                }
            }
        }

        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ICProductTypeAccountConfigsInfo objProductTypeAccountConfigsInfo = entity.ICProductTypeAccountConfigsList[entity.ICProductTypeAccountConfigsList.CurrentIndex];
            if (e.Column.FieldName == "ICProductTypeCombo" && objProductTypeAccountConfigsInfo != null)
            {
                objProductTypeAccountConfigsInfo.ICProductTypeAccountConfigName = BOSApp.GetDisplayTextFromConfigValue("ProductType", objProductTypeAccountConfigsInfo.ICProductTypeCombo);
            }
        }
    }
}
