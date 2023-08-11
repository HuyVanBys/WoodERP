using BOSComponent;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;

namespace BOSERP.Modules.Report
{
    public partial class RPEquipmentRegGridControl : BOSGridControl
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
            RPEquipmentReg screen = Screen as RPEquipmentReg;
            BandedGridView bandedView = screen.InitBandedGridView();
            // bandedView.RowCellStyle += BandedView_RowCellStyle;
            bandedView.CustomDrawCell += BandedView_CustomDrawCell;
            return bandedView;
        }

        private void BandedView_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName.Contains("Planed_"))
            {
                e.Appearance.BackColor = Color.YellowGreen;
                e.Appearance.BackColor2 = Color.White;
            }
            else if (e.Column.FieldName.Contains("Available_"))
            {
                e.Appearance.BackColor = Color.PaleTurquoise;
                e.Appearance.BackColor2 = Color.White;
            }
        }

    }
}
