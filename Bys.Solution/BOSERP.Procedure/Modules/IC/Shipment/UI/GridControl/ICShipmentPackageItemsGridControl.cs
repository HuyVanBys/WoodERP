using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Shipment
{
    public class ICShipmentPackageItemsGridControl : BOSGridControl
    {
        private DataTable ConfigValueDataTable { get; set; }
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            ShipmentEntities entity = (ShipmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ShipmentPackageItemList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column1 = new DevExpress.XtraGrid.Columns.GridColumn();
            column1.Caption = "Thêm chi tiết";
            column1.FieldName = "ICProductPackageItemComponent";
            column1.OptionsColumn.AllowEdit = true;

            RepositoryItemHyperLinkEdit rpItemComponent = new RepositoryItemHyperLinkEdit();
            rpItemComponent.NullText = "Thêm chi tiết";
            rpItemComponent.Click += new EventHandler(RpItemComponent_Click);
            column1.ColumnEdit = rpItemComponent;

            gridView.Columns.Add(column1);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ShipmentModule)Screen.Module).DeleteItemShipmentPackageItemsList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                ShipmentEntities entity = (ShipmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                ICShipmentPackageItemsInfo objPOPackageItemsInfo = (ICShipmentPackageItemsInfo)gridView.GetRow(e.RowHandle);
                if (objPOPackageItemsInfo != null)
                {
                    if (e.Column.FieldName == "ICShipmentPackageItemQty")
                    {
                        ((ShipmentModule)Screen.Module).UpdateItemDetailShowListQty(entity.ShipmentPackageItemList[entity.ShipmentPackageItemList.CurrentIndex].ICShipmentPackageItemQty);
                    }
                }
            }
            ((ShipmentModule)Screen.Module).SetDefaultShipmentPackageItemList();
        }

        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            ((ShipmentModule)Screen.Module).AddProductPackageItemDetails();
        }
    }
}
