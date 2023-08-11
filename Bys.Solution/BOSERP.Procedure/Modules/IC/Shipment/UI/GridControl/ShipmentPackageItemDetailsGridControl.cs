using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Shipment
{
    public class ShipmentPackageItemDetailsGridControl : BOSGridControl
    {
        private DataTable ConfigValueDataTable { get; set; }
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            ShipmentEntities entity = (ShipmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ShipmentPackageItemDetailShowList;
            this.DataSource = bds;
        }

        public void InvalidateDataSource(List<ICShipmentPackageItemDetailsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            this.DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = false;
            }
            if (gridView.Columns["ICShipmentPackageItemDetailQty"] != null)
            {
                SetFormat("ICShipmentPackageItemDetailQty", "n2", gridView);
            }
            return gridView;
        }

        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            ShipmentEntities entity = (ShipmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            if (e.KeyCode == Keys.Delete)
            {
                GridView view = sender as GridView;
                if (e.KeyData == Keys.Delete)
                {
                    int index = view.GetDataSourceRowIndex(view.FocusedRowHandle);
                    if (index >= 0)
                    {
                        //entity.DeletePOPackageItemDetailList.Add(entity.POPackageItemDetailList[index]);
                        //entity.POPackageItemDetailList.RemoveAt(index);
                        //this.DataSource = entity.POPackageItemDetailList;
                        RefreshDataSource();
                    }
                    e.Handled = true;
                }
            }
        }
    }
}
