using DevExpress.XtraGrid.Columns;

namespace BOSERP.Modules.SaleForecast
{
    public class ARHistorySaleForecastGridControl : BOSComponent.BOSGridControl
    {

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn collumn = new GridColumn();
            collumn = new GridColumn();
            collumn.FieldName = "Selected";
            collumn.Caption = "Chọn";
            gridView.Columns.Add(collumn);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            //gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            return gridView;
        }

    }
}
