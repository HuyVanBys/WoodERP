using DevExpress.XtraGrid.Views.BandedGrid;

namespace BOSERP
{
    class BOSBandedGridColumnCollection : BandedGridColumnCollection
    {
        public BOSBandedGridColumnCollection(DevExpress.XtraGrid.Views.Base.ColumnView view)
            : base(view)
        {
        }

        protected override DevExpress.XtraGrid.Columns.GridColumn CreateColumn()
        {
            return new BOSBandedGridColumn();
        }
    }
}
