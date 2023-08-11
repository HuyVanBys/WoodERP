using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.SemiProductShipment
{
    public class ICShipmentItemPreviewGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<ICShipmentItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            foreach (GridColumn item in gridView.Columns)
            {
                item.OptionsColumn.AllowEdit = false;
            }
            GridColumn column = gridView.Columns["ICShipmentItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle < 0)
                return;

            SemiProductShipmentEntities entity = (SemiProductShipmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            item.ICShipmentItemProductExchangeQty = item.ICShipmentItemProductQty * item.ICShipmentItemProductFactor;
            entity.SetProductPriceByProductUnitPrice(item);
        }
    }
}
