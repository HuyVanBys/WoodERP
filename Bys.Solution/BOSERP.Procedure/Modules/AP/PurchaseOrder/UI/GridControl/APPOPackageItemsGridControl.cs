using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseOrder
{
    public class APPOPackageItemsGridControl : BOSGridControl
    {
        private DataTable ConfigValueDataTable { get; set; }
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.POPackageItemList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column1 = new DevExpress.XtraGrid.Columns.GridColumn();
            column1.Caption = "Thêm chi tiết";
            column1.FieldName = "APProductPackageItemComponent";
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
                ((PurchaseOrderModule)Screen.Module).DeleteItemPOPackageItemsList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                APPOPackageItemsInfo objPOPackageItemsInfo = (APPOPackageItemsInfo)gridView.GetRow(e.RowHandle);
                if (objPOPackageItemsInfo != null)
                {
                    if (e.Column.FieldName == "APPOPackageItemQty")
                    {
                        ((PurchaseOrderModule)Screen.Module).UpdateItemDetailShowListQty(entity.POPackageItemList[entity.POPackageItemList.CurrentIndex].APPOPackageItemQty);
                    }
                }
            }
            ((PurchaseOrderModule)Screen.Module).SetDefaultPOPackageItemList();
        }

        private void RpItemComponent_Click(object sender, EventArgs e)
        {
            ((PurchaseOrderModule)Screen.Module).AddProductPackageItemDetails();
        }
    }
}
