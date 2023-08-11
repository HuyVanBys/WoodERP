using BOSComponent;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public partial class RP202BatchProductProductionNormItemsGridControl : BOSGridControl
    {

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }
        public GridView GridViewMain { get; set; }

        public override void InitializeControl()
        {
            base.InitializeControl();
            BandedGridView bandedView = InitializeBandedGridView(GridViewMain);
            MainView = bandedView;
            ViewCollection.AddRange(new BaseView[] { bandedView });
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridViewMain = gridView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            return gridView;
        }
        public BandedGridView InitializeBandedGridView(GridView gridView)
        {
            RP202 screen = Screen as RP202;
            BandedGridView bandedView = screen.InitBandedGridView();
            //  bandedView.EndSorting += new EventHandler(bandedView_EndSorting);
            return bandedView;
        }
        //protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        //{
        //    base.AddColumnsToGridView(strTableName, gridView);
        //    GridColumn column = new GridColumn();

        //    column.FieldName = "SLNhap";
        //    column.Caption = ReportLocalizedResources.ReceiptedQty;
        //    column.OptionsColumn.AllowEdit = false;
        //    column.Visible = true;
        //    column.VisibleIndex = 13;
        //    gridView.Columns.Add(column);

        //    column = new GridColumn();
        //    column.FieldName = "Slhoantat";
        //    column.Caption = "% hoàn thành";
        //    column.OptionsColumn.AllowEdit = false;
        //    column.Visible = true;
        //    column.VisibleIndex = 14;
        //    gridView.Columns.Add(column);

        //    column = new GridColumn();
        //    column.FieldName = "ICProductNo";
        //    column.Caption = ReportLocalizedResources.ICProductNo;
        //    column.OptionsColumn.AllowEdit = false;
        //    column.Visible = true;
        //    column.VisibleIndex = 2;
        //    gridView.Columns.Add(column);

        //    column = new GridColumn();
        //    column.FieldName = "MMOperationName";
        //    column.Caption = ReportLocalizedResources.Operation;
        //    column.OptionsColumn.AllowEdit = false;
        //    column.Visible = true;
        //    column.VisibleIndex = 3;
        //    gridView.Columns.Add(column);

        //}

        //protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        //{
        //    GridView gridView = base.InitializeGridView();
        //   // gridView.OptionsView.ShowAutoFilterRow = true;
        //    GridColumn column = gridView.Columns["MMBatchProductNo"];
        //    if (column != null)
        //    {
        //        column.Group();
        //        column.VisibleIndex = 1;
        //    }
        //    column = gridView.Columns["ICProductNo"];
        //    if (column != null)
        //    {
        //        column.Group();                
        //        column.VisibleIndex = 2;
        //    }
        //    column = gridView.Columns["MMOperationName"];
        //    if (column != null)
        //    {
        //        column.Group();                
        //        column.VisibleIndex = 3;
        //    }
        //    column = gridView.Columns["MMBatchProductProductionNormItemNo"];
        //    if (column != null)
        //    {
        //        column.Visible = true;
        //        column.Caption = ReportLocalizedResources.Machitiet;
        //        column.VisibleIndex = 4;
        //    }
        //    column = gridView.Columns["MMBatchProductProductionNormItemProductName"];
        //    if (column != null)
        //    {
        //        column.Visible = true;
        //        column.Caption = ReportLocalizedResources.TenchitietSP;
        //        column.VisibleIndex = 5;
        //    }
        //    column = gridView.Columns["MMBatchProductProductionNormItemProductHeight"];
        //    if (column != null)
        //    {
        //        column.Visible = true;
        //        column.VisibleIndex = 6;
        //    }
        //    column = gridView.Columns["MMBatchProductProductionNormItemProductWidth"];
        //    if (column != null)
        //    {
        //        column.Visible = true;
        //        column.VisibleIndex = 7;
        //    }
        //    column = gridView.Columns["MMBatchProductProductionNormItemProductLength"];
        //    if (column != null)
        //    {
        //        column.Visible = true;
        //        column.VisibleIndex = 8;
        //    }

        //    column = gridView.Columns["MMBatchProductProductionNormItemProductdesc"];
        //    if (column != null)
        //    {
        //        column.Visible = true;
        //        column.Caption = ReportLocalizedResources.ProductDesc;
        //        column.VisibleIndex = 9;
        //    }
        //    column = gridView.Columns["MMBatchProductProductionNormItemQuantity"];
        //    if (column != null)
        //    {
        //        column.Visible = true;
        //        column.Caption = ReportLocalizedResources.Quantity;
        //        column.VisibleIndex = 10;
        //    }
        //    column = gridView.Columns["SLNhap"];
        //    if (column != null)
        //    {
        //        column.Visible = true;
        //        column.VisibleIndex = 11;
        //    }
        //    column = gridView.Columns["Slhoantat"];
        //    if (column != null)
        //    {
        //        column.Visible = true;
        //        column.VisibleIndex = 12;
        //    }
        //    gridView.OptionsView.ShowFooter = true;
        //    return gridView;
        //}
    }
}
