using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Localization;
using BOSComponent;
using System.Data;
using BOSCommon;

namespace BOSERP.Modules.ProductionNorm
{
    public partial class InventoryStocksGridControl : BOSGridControl
    {
        
        public override void InitGridControlDataSource()
        {
            ProductionNormEntities entity = (ProductionNormEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.InventoryStockList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column;

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductsConst.ICProductNameCaption;
            column.FieldName = ProductsConst.ICProductName;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductsConst.ICProductThickCaption;
            column.FieldName = ProductsConst.ICProductThick;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductsConst.ICProductWidthCaption;
            column.FieldName = ProductsConst.ICProductWidth;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductsConst.ICProductLongCaption;
            column.FieldName = ProductsConst.ICProductLong;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductsConst.ICProductJoineryCaption;
            column.FieldName = ProductsConst.ICProductJoinery;
            column.OptionsColumn.AllowEdit = false;
            column.DisplayFormat.FormatString = ProductionNormConst.ProducttionNormFormatN4;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductsConst.ICproductBlocksCaption;
            column.FieldName = ProductsConst.ICproductBlocks;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = ProductsConst.ICProductAttributeCaption;
            column.FieldName = ProductsConst.ICProductAttribute;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
         }
    }
}
