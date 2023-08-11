using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using BOSCommon.Constants;

namespace BOSERP.Modules.GeneralAccounting
{
    public partial class DocumentEntryGridControl : BaseDocumentEntryGridControl
    {
        public override void InitGridControlDataSource()
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.BriefDocumentEntryList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "ARInvoiceNo";
            column.OptionsColumn.AllowEdit = false;
            column.Caption = "Hóa đơn";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "FK_ACCreditAccountID";
            column.OptionsColumn.AllowEdit = false;
            column.Caption = "Tài khoản đối ứng";
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            DataSet ds = BOSApp.LookupTables[TableName.ACAccountsTableName] as DataSet;
            if (ds == null)
            {
                ds = BOSApp.GetLookupTableData(TableName.ACAccountsTableName);
                BOSApp.LookupTables[TableName.ACAccountsTableName] = ds;
            }
            repositoryItemLookUpEdit.DataSource = ds.Tables[0];
            repositoryItemLookUpEdit.ValueMember = "ACAccountID";
            repositoryItemLookUpEdit.DisplayMember = "ACAccountNo";
            repositoryItemLookUpEdit.NullText = string.Empty;
            column.ColumnEdit = repositoryItemLookUpEdit;
            gridView.Columns.Add(column);
        }
    }
}
