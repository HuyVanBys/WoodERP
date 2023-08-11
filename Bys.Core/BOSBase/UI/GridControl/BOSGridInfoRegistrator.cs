using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;

namespace BOSERP
{
    public class BOSBandedGridInfoRegistrator : BandedGridInfoRegistrator
    {
        public override BaseView CreateView(GridControl grid)
        {
            return new BOSBandedGridView(grid);
        }

        public override string ViewName
        {
            get
            {
                return "BOSBandedGridView";
            }
        }
    }
}
