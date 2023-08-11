using BOSComponent;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BOSERP.Modules.CompanyConstant
{
    public partial class ACEquipmentTypeAccountConfigsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            CompanyConstantEntities entity = (CompanyConstantEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ACEquipmentTypeAccountConfigsList;
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
                    || col.FieldName == "FK_ACDepreciationAccountID"
                    || col.FieldName == "FK_ACDepreciationCostAccountID")
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
                || e.Column.FieldName == "FK_ACDepreciationAccountID"
                || e.Column.FieldName == "FK_ACDepreciationCostAccountID")
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
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountNo", "Mã tài khoản"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACAccountName", "Tên tài khoản"));
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditACAcount_QueryPopUp);
            column.ColumnEdit = repositoryItemLookUpEdit;
        }

        public void repositoryItemLookUpEditACAcount_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACAccountsController objAccountsController = new ACAccountsController();
            List<ACAccountsInfo> accountList = new List<ACAccountsInfo>();
            accountList = objAccountsController.GetAllAccountList();
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
                    ((CompanyConstantModule)Screen.Module).RemoveEquipmentTypeAccountConfig();
                }
            }
        }
    }
}
