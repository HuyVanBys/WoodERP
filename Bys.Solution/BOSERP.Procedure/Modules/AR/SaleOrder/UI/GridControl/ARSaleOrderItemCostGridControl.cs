using DevExpress.XtraEditors.Repository;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrder
{
    public class ARSaleOrderItemCostGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            SaleOrderEntities entity = (SaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ARSaleOrderItemCostList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            if (gridView.Columns["ARSaleOrderItemWorkProductQty"] != null)
            {
                gridView.Columns["ARSaleOrderItemWorkProductQty"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ARSaleOrderItemWorkProductUnitPrice"] != null)
            {
                gridView.Columns["ARSaleOrderItemWorkProductUnitPrice"].OptionsColumn.AllowEdit = true;
                InitColumnRepositoryText(gridView.Columns["ARSaleOrderItemWorkProductUnitPrice"], "n3");
            }
            if (gridView.Columns["ARSaleOrderItemWorkDiscountAmount"] != null)
            {
                gridView.Columns["ARSaleOrderItemWorkDiscountAmount"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ARSaleOrderItemWorkDiscountPerCent"] != null)
            {
                gridView.Columns["ARSaleOrderItemWorkDiscountPerCent"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ARSaleOrderItemWorkComment"] != null)
            {
                gridView.Columns["ARSaleOrderItemWorkComment"].OptionsColumn.AllowEdit = true;
            }
            if (gridView.Columns["ARSaleOrderItemWorkProductNo"] != null)
            {
                gridView.Columns["ARSaleOrderItemWorkProductNo"].Caption = SaleOrderLocalizedResources.ARSaleOrderItemWorkProductNo;
            }
            if (gridView.Columns["ARSaleOrderItemWorkProductName"] != null)
            {
                gridView.Columns["ARSaleOrderItemWorkProductName"].Caption = SaleOrderLocalizedResources.ARSaleOrderItemWorkProductName;
            }
            if (gridView.Columns["ARSaleOrderItemWorkTotalAmount"] != null)
            {
                gridView.Columns["ARSaleOrderItemWorkTotalAmount"].OptionsColumn.AllowEdit = false;
                InitColumnRepositoryText(gridView.Columns["ARSaleOrderItemWorkTotalAmount"], "n3");
            }

            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((SaleOrderModule)Screen.Module).DeleteItemFromSaleOrderItemCostList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            SaleOrderEntities entity = (SaleOrderEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ARSaleOrderItemCostList.CurrentIndex >= 0)
            {
                ARSaleOrderItemWorksInfo item = entity.ARSaleOrderItemCostList[entity.ARSaleOrderItemCostList.CurrentIndex];
                if (e.Column.FieldName == "ARSaleOrderItemWorkProductQty")
                {
                    ((SaleOrderModule)Screen.Module).ChangeQty(item);
                }
                if (e.Column.FieldName == "ARSaleOrderItemWorkProductUnitPrice")
                {
                    ((SaleOrderModule)Screen.Module).ChangeQty(item);
                }
                if (e.Column.FieldName == "ARSaleOrderItemWorkDiscountAmount")
                {
                    ((SaleOrderModule)Screen.Module).ChangeSaleOrderItemCostDiscountAmount();
                }
                if (e.Column.FieldName == "ARSaleOrderItemWorkDiscountPerCent")
                {
                    ((SaleOrderModule)Screen.Module).ChangeSaleOrderItemCostDiscountPerCent();
                }
            }
        }

        public void InitColumnRepositoryText(DevExpress.XtraGrid.Columns.GridColumn column, string fomatType)
        {
            RepositoryItemTextEdit repositoryItemTextEdit = new RepositoryItemTextEdit()
            {
                Mask =
                {
                    MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric,
                    EditMask = fomatType,
                    UseMaskAsDisplayFormat = true
                }
            };
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:" + fomatType + "}";
            column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemTextEdit;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
        }
    }
}
