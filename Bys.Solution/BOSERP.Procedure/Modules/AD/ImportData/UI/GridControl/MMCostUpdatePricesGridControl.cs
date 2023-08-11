using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.ImportData
{
    public partial class MMCostUpdatePricesGridControl : BOSGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            //if (gridView.Columns["Selected"] != null)
            //    gridView.Columns["Selected"].OptionsColumn.AllowEdit = true;
            //if (gridView.Columns["MMProductionCostCalculationNoUpdate"] != null)
            //    gridView.Columns["MMProductionCostCalculationNoUpdate"].OptionsColumn.AllowEdit = true;
            //if (gridView.Columns["TongchiphiTranfer"] != null)
            //    gridView.Columns["TongchiphiTranfer"].OptionsColumn.AllowEdit = true;
          
            return gridView;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            //GridColumn column = new GridColumn();
            //column = new GridColumn();
            //column.Caption = "Chọn";
            //column.FieldName = "Selected";
            //RepositoryItemCheckEdit rep = new RepositoryItemCheckEdit();
            //column.ColumnEdit = rep;
            //column.OptionsColumn.AllowEdit = true;
            //gridView.Columns.Add(column);


        }
    }
}
