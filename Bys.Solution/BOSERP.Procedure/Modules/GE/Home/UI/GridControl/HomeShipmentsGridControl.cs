using BOSComponent;
using DevExpress.XtraGrid.Views.Base;
using System.Windows.Forms;

namespace BOSERP.Modules.Home
{
    public partial class HomeShipmentsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ShipmentSaleOrderList;
            DataSource = bds;
        }
        protected override void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            entity.ShipmentSaleOrderList.SetEndCurrentEdit();
            return;
        }
    }
}
