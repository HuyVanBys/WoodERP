namespace BOSERP.Modules.SalaryCalculation
{
    public partial class ACSalaryCalculationsGridControl : BOSSearchResultsGridControl
    {
        //public override void InitGridControlDataSource()
        //{
        //    SalaryCalculationEntities entity = (SalaryCalculationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
        //    BindingSource bds = new BindingSource();
        //    //bds.DataSource = entity.SalaryDocumentsList;
        //    DataSource = bds;
        //}

        //protected override GridView InitializeGridView()
        //{
        //    GridView gridView = base.InitializeGridView();
        //    gridView.OptionsCustomization.AllowSort = false;

        //    gridView.Columns.Clear();

        //    GridColumn column = new GridColumn();
        //    column.Caption = "Hạch toán";
        //    column.FieldName = "ACSalaryCalculationDesc";
        //    column.OptionsColumn.AllowEdit = true;
        //    column.VisibleIndex = 0;
        //    column.Width = 200;
        //    gridView.Columns.Add(column);

        //    return gridView;
        //}
    }
}
