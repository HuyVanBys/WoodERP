using DevExpress.XtraGrid.Views.BandedGrid;

namespace BOSERP
{
    class BOSBandedGridColumn : BandedGridColumn
    {
        private bool defaultBandColumn;

        public BOSBandedGridColumn()
            : base()
        {
        }

        public bool DefaultBandColumn
        {
            get
            {
                return defaultBandColumn;
            }
            set
            {
                defaultBandColumn = value;
            }
        }
    }
}
