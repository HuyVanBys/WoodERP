using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleReturn
{
    public partial class RefundableInvoiceItemGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SaleReturnEntities entity = (SaleReturnEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.RefundableInvoiceItems;
            DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = new GridColumn();
            //column.Caption = BaseLocalizedResources.Select;
            //column.FieldName = "Selected";
            //column.OptionsColumn.AllowEdit = true;
            //gridView.Columns.Insert(0, column);
            //column.VisibleIndex = 0;
            if (gridView.Columns["ARInvoiceDate"] != null)
            {
                gridView.Columns["ARInvoiceDate"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            }
            if (gridView.Columns["FK_ARInvoiceID"] != null)
            {
                gridView.Columns["FK_ARInvoiceID"].Group();
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ARInvoiceNo";
                repositoryItemLookUpEdit.ValueMember = "ARInvoiceID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                DataSet ds = BOSApp.LookupTables[TableName.ARInvoicesTableName] as DataSet;
                if (ds == null)
                {
                    ds = BOSApp.GetLookupTableData(TableName.ARInvoicesTableName);
                    BOSApp.LookupTables[TableName.ARInvoicesTableName] = ds;
                }
                repositoryItemLookUpEdit.DataSource = ds.Tables[0];
                gridView.Columns["FK_ARInvoiceID"].ColumnEdit = repositoryItemLookUpEdit;
            }            
            gridView.ExpandAllGroups();
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Số lượng đã trả hàng";
            column.FieldName = "ARInvoiceItemReturnQty";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n3}";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày chứng từ";
            column.FieldName = "ARInvoiceDate";
            column.OptionsColumn.AllowEdit = false;
            column.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            gridView.Columns.Add(column);
        }

        //private void GridView_DoubleClick(object sender, EventArgs e)
        //{
        //    ((guiChooseInvoiceItem)Screen).ChooseInvoiceItem();
        //}
    }
}
