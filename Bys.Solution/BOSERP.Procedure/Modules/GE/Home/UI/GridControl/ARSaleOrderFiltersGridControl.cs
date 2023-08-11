using BOSComponent;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Home
{
    public partial class ARSaleOrderFiltersGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SaleOrdersFilterList;
            DataSource = bds;
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
                ARSaleOrdersInfo objSaleOrdersInfo = (ARSaleOrdersInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objSaleOrdersInfo != null)
                {
                    ((HomeModule)Screen.Module).ShowSaleOrderScreen(objSaleOrdersInfo.ARSaleOrderID, objSaleOrdersInfo.ARSaleOrderType);
                }
            }
        }
        protected override void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            entity.SaleOrdersFilterList.SetEndCurrentEdit();
            return;
        }
    }
}
