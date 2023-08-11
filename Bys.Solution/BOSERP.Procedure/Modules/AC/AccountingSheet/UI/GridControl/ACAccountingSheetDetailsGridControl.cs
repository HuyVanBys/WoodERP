using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace BOSERP.Modules.AccountingSheet
{
    public partial class ACAccountingSheetDetailsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            AccountingSheetEntities entity = (AccountingSheetEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.AccountingSheetDetailsList;
            DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["ACAccountingSheetDetailType"];
            if (column != null)
            {
                //  column.GroupIndex = 1;
                //  column.Group();
            }
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn col = new GridColumn();
            col.Caption = "Loại";
            col.FieldName = "ACAccountingSheetDetailType";
            col.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(col);
        }
    }
}
