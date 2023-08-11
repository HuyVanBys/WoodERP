using BOSCommon;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.Report
{
    public partial class RP112ICInventoryStocksGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();

            column = new GridColumn();
            column.Caption = "Thành tiền";
            column.FieldName = "ICInventoryStockTotoAmount";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = "Mã sản phẩm";
            //column.FieldName = "FK_ICProductID";
            //column.OptionsColumn.AllowEdit = false;
            //gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên sản phẩm";
            column.FieldName = "ICProductName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã lô";
            column.FieldName = "ICProductSerieNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mô tả";
            column.FieldName = "ICProductDesc";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số lượng";
            column.FieldName = "ICInventoryStockInitQty";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Đơn giá";
            column.FieldName = "ICInventoryStockUnitCost";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Hoàng(mm)";
            column.FieldName = "ICProductSerieProductPerimeter";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Dày(mm)";
            column.FieldName = "ICProductSerieProductHeight";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Rộng(mm)";
            column.FieldName = "ICProductSerieProductWidth";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Dài(mm)";
            column.FieldName = "ICProductSerieProductLength";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Rộng max(mm)";
            column.FieldName = "ICProductSerieProductWidthMax";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Dài max (mm)";
            column.FieldName = "ICProductSerieProductLengthMax";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
        public void LoadGridViewByProductType(string productType)
        {
            GridView gridView = (GridView)MainView;
            GridColumn column = gridView.Columns["FK_ICProductAttributeTTMTID"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString() ||
                    productType == AllocationProposalProductType.DryLumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 5;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["ICProductSerieProductHeight"];
            if (column != null)
            {
                if (
                    productType == ProposalAPType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 9;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["ICProductSerieProductWidth"];
            if (column != null)
            {
                if (
                    productType == ProposalAPType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 7;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["ICProductSerieProductLength"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString() ||
                    productType == ProposalAPType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 5;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["ICProductSerieProductWidthMax"];
            if (column != null)
            {
                if (
                    productType == ProposalAPType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 8;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["ICProductSerieProductLengthMax"];
            if (column != null)
            {
                if (
                    productType == ProposalAPType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 6;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["ICProductSerieProductPerimeter"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 6;
                }
                else
                {
                    column.Visible = false;
                }
            }
            column = gridView.Columns["ICInventoryStockQuantity"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString() ||
                    productType == ProposalAPType.Lumber.ToString())
                {
                    column.Caption = ReportLocalizedResources.ProductQty1;
                    column.Visible = true;
                    column.VisibleIndex = 13;
                }
                else
                {
                    column.Caption = ReportLocalizedResources.ProductQty;
                    column.Visible = true;
                    column.VisibleIndex = 5;
                }
            }
            column = gridView.Columns["ICInventoryStockUnitCost"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString()
                    || productType == ProposalAPType.Lumber.ToString())
                {
                    column.VisibleIndex = 14;
                }
            }
            column = gridView.Columns["ICInventoryStockTotoAmount"];
            if (column != null)
            {
                if (productType == AllocationProposalProductType.RoundWood.ToString()
                    || productType == ProposalAPType.Lumber.ToString())
                {
                    column.VisibleIndex = 15;
                }
            }
        }
    }
}
