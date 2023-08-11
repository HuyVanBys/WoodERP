using BOSComponent;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Home
{
    public partial class ShipmentSaleOrdersGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ShipmentUnExecutedInvoiceList;
            DataSource = bds;
        }
        protected override void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            entity.ShipmentUnExecutedInvoiceList.SetEndCurrentEdit();
            return;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            return gridView;
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objShipmentsInfo != null)
                {
                    ((HomeModule)Screen.Module).ShowShipmentSaleOrderScreen(objShipmentsInfo.ICShipmentID);
                }
            }
        }
    }
}
