using BOSComponent;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Drawing;

namespace BOSERP.Modules.TransferPlan
{
    public class SaleReturnToTruckGridControl : BOSGridControl
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
            bandedView.CellValueChanged += new CellValueChangedEventHandler(gridView_CellValueChanged);
            //bandedView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
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
            guiSaleReturnToTruck screen = Screen as guiSaleReturnToTruck;
            BandedGridView bandedView = screen.InitBandedGridView();
            //  bandedView.EndSorting += new EventHandler(bandedView_EndSorting);
            return bandedView;
        }

        protected void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            BandedGridView gridView = (BandedGridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                DataRow row = gridView.GetDataRow(gridView.FocusedRowHandle);
                ((guiSaleReturnToTruck)Screen).ChangeRowItemlist(row);
            }
        }

        protected void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "ARDeliveryPlanItemRemainedQty")
            {
                if (Decimal.Parse(e.CellValue.ToString()) < 0)
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.BackColor2 = Color.OrangeRed;
                }
                else if (Decimal.Parse(e.CellValue.ToString()) == 0)
                {
                    e.Appearance.BackColor = Color.Green;
                }
            }
        }
    }
}
