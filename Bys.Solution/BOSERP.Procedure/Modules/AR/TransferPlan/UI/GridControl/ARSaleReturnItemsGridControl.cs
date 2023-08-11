using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.TransferPlan
{
    public class ARSaleReturnItemsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<ARSaleReturnItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        //public enum SaleReturnItemsColumnName
        //{
        //    FK_ARSaleReturnID
        //}

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            GridColumn column = new GridColumn();
            column.Caption = BaseLocalizedResources.Select;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Insert(0, column);
            column.VisibleIndex = 0;

            column = new GridColumn();
            //column.Caption = TransferPlanLocalizedResources.Object;
            column.Caption = "Đối tượng";
            column.FieldName = "ACObjectName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = gridView.Columns["FK_ARSaleReturnID"];
            if (column != null)
            {
                column.Group();
            }

            //new SaleReturnItemsColumnName[]
            //{
            //    SaleOrderItemsColumnName.FK_ARSaleReturnID,
            //    SaleOrderItemsColumnName.FK_ACAssetID,
            //    SaleOrderItemsColumnName.FK_ICProductAttributeQualityID,
            //    SaleOrderItemsColumnName.ARSaleOrderItemLentghMax,
            //    SaleOrderItemsColumnName.ARSaleOrderItemLengthMin,
            //    SaleOrderItemsColumnName.ARSaleOrderItemPerimeter,
            //    SaleOrderItemsColumnName.ARSaleOrderItemPerimeterMax,
            //    SaleOrderItemsColumnName.ARSaleOrderItemPerimeterMin,
            //    SaleOrderItemsColumnName.ARSaleOrderItemProductInventoryQty,
            //    SaleOrderItemsColumnName.ARSaleOrderItemBlock,
            //    SaleOrderItemsColumnName.ARSaleOrderItemLotNo,
            //    SaleOrderItemsColumnName.ARSaleOrderItemProductSupplierNo,
            //    SaleOrderItemsColumnName.ARSaleOrderItemProductCustomerNumber,
            //    SaleOrderItemsColumnName.FK_ICModelDetailID,
            //    SaleOrderItemsColumnName.FK_GECountryID,
            //    SaleOrderItemsColumnName.ARSaleOrderItemHTText,
            //    SaleOrderItemsColumnName.ARSaleOrderItemWoodTypeText,
            //    SaleOrderItemsColumnName.ARSaleOrderItemColorText,
            //    SaleOrderItemsColumnName.ARSaleOrderItemWidthMax,
            //    SaleOrderItemsColumnName.ARSaleOrderItemWidthMin,
            //    SaleOrderItemsColumnName.ARSaleOrderItemPONo,
            //    SaleOrderItemsColumnName.ARSaleOrderItemPrice,
            //    SaleOrderItemsColumnName.ARSaleOrderItemProductAttribute,
            //    SaleOrderItemsColumnName.FK_ICProductAttributeTTMTID,
            //    SaleOrderItemsColumnName.ICProductUnitPrice,
            //    SaleOrderItemsColumnName.ARSaleOrderItemProductUnitPrice,
            //    SaleOrderItemsColumnName.ARSaleOrderItemTotalAmount2,
            //    SaleOrderItemsColumnName.ARSaleOrderItemProductDiscount,
            //    SaleOrderItemsColumnName.ARSaleOrderItemDiscountAmount
            //}
            //.Select(o => gridView.Columns[o.ToString()])
            //.Where(o => o != null)
            //.ToList()
            //.ForEach(o => gridView.Columns.Remove(o));

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

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            //if (e.KeyCode == Keys.Delete)
            //{
            //    ((SaleOrderModule)Screen.Module).DeleteItemFromSaleOrderItemsList();
            //}
        }
    }
}
