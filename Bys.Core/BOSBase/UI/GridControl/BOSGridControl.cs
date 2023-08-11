using BOSComponent;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using System.ComponentModel;
namespace BOSERP
{
    public class BOSGridControl1 : BOSGridControl
    {
        public BOSGridControl1() : base()
        {
        }

        public BOSGridControl1(IContainer container) : base(container)
        {
        }

        protected override BaseView CreateDefaultView()
        {
            return CreateView("BOSBandedGridView");
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new BOSBandedGridInfoRegistrator());
        }
    }

}
