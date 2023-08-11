using BOSComponent;
using DevExpress.XtraGrid.Columns;
using System.Windows.Forms;

namespace BOSERP.Modules.GeneralAccounting
{
    public partial class BranchGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            GeneralAccountingEntities entity = (GeneralAccountingEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.BranchList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Chọn";
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tình trạng";
            column.FieldName = "BRBranchTransferMessage";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
