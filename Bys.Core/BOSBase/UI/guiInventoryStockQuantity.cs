using BOSCommon;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP
{
    public partial class guiInventoryStockQuantity : BOSERPScreen
    {
        public bool WoodType { get; set; }
        public bool IsRoundWood { get; set; }
        public ICProductsInfo Product { get; set; }
        public InventoryStockQuantityGridControl InventoryStockQuantityGridControl
        {
            get { return fld_dgcInventoryStocks; }
        }
        public guiInventoryStockQuantity()
        {
            InitializeComponent();
        }

        public guiInventoryStockQuantity(bool woodType, bool isRoundWood)
        {
            InitializeComponent();
            WoodType = woodType;
            IsRoundWood = isRoundWood;
        }

        private void guiInventoryStockQuantity_Load(object sender, EventArgs e)
        {
            fld_dgcInventoryStocks.Screen = this;
            fld_dgcInventoryStocks.InitializeControl();
            (fld_dgcInventoryStocks.MainView as GridView).ExpandAllGroups();

            List<ICInventoryStocksInfo> inventoryStocks = (List<ICInventoryStocksInfo>)fld_dgcInventoryStocks.DataSource;
            decimal onHandQty = inventoryStocks.Where(i => i.InventoryType == InventoryType.OnHand.ToString())
                                                .Sum(i => i.ICInventoryStockQuantity);
            decimal saleOrderQty = inventoryStocks.Where(i => i.InventoryType == InventoryType.SaleOrder.ToString())
                                                .Sum(i => i.ICInventoryStockQuantity);
            //decimal availableQty = onHandQty - saleOrderQty;
            decimal purchaseOrderQty = inventoryStocks.Where(i => i.InventoryType == InventoryType.PurchaseOrder.ToString())
                                                .Sum(i => i.ICInventoryStockQuantity);
            decimal transitInQty = inventoryStocks.Where(i => i.InventoryType == InventoryType.TransitIn.ToString())
                                                .Sum(i => i.ICInventoryStockQuantity);
            decimal transitOutQty = inventoryStocks.Where(i => i.InventoryType == InventoryType.TransitOut.ToString())
                                                .Sum(i => i.ICInventoryStockQuantity);
            decimal woodPlanQty = inventoryStocks.Where(i => i.InventoryType == InventoryType.AllocationPlan.ToString())
                                                .Sum(i => i.ICInventoryStockQuantity);
            //NHAnh [ADD][02.01.2016][availableQty],START
            decimal purchasePlanQty = inventoryStocks.Where(i => i.InventoryType == InventoryType.PurchasePlan.ToString())
                                               .Sum(i => i.ICInventoryStockQuantity);

            decimal availableQty = (onHandQty + purchaseOrderQty + transitInQty + transitOutQty) - (saleOrderQty + woodPlanQty);

            fld_lblOnHandQty.Text = BOSUtil.GetNumberDisplayFormat(onHandQty, "FormatGroupN4");
            fld_lblSOQty.Text = BOSUtil.GetNumberDisplayFormat(saleOrderQty, "FormatGroupN4");
            fld_lblAvailableQty.Text = BOSUtil.GetNumberDisplayFormat(availableQty, "FormatGroupN4");
            fld_lblPOQty.Text = BOSUtil.GetNumberDisplayFormat(purchaseOrderQty, "FormatGroupN4");
            fld_lblTransitInQty.Text = BOSUtil.GetNumberDisplayFormat(transitInQty, "FormatGroupN4");
            fld_lblTransitOutQty.Text = BOSUtil.GetNumberDisplayFormat(transitOutQty, "FormatGroupN4");
            fld_lblWoodPlanQty.Text = BOSUtil.GetNumberDisplayFormat(woodPlanQty, "FormatGroupN4");
            fld_lblPurchasePlanQty.Text = BOSUtil.GetNumberDisplayFormat(purchasePlanQty, "FormatGroupN4");
            //}

            foreach (ICInventoryStocksInfo inventoryStock in inventoryStocks)
            {
                if (inventoryStock.InventoryType == InventoryType.OnHand.ToString())
                {
                    inventoryStock.InventoryType = BaseLocalizedResources.OnHandQuantity;
                }
                else if (inventoryStock.InventoryType == InventoryType.SaleOrder.ToString())
                {
                    inventoryStock.InventoryType = BaseLocalizedResources.SaleOrderQuantity;
                }
                else if (inventoryStock.InventoryType == InventoryType.PurchaseOrder.ToString())
                {
                    inventoryStock.InventoryType = BaseLocalizedResources.PurchaseOrderQuantity;
                }
                else if (inventoryStock.InventoryType == InventoryType.TransitIn.ToString())
                {
                    inventoryStock.InventoryType = BaseLocalizedResources.TransitInQuantity;
                }
                else if (inventoryStock.InventoryType == InventoryType.TransitOut.ToString())
                {
                    inventoryStock.InventoryType = BaseLocalizedResources.TransitOutQuantity;
                }
                else if (inventoryStock.InventoryType == InventoryType.AllocationPlan.ToString())
                {
                    inventoryStock.InventoryType = BaseLocalizedResources.WoodPlanQuantity;
                }
                else if (inventoryStock.InventoryType == InventoryType.PurchasePlan.ToString())
                {
                    inventoryStock.InventoryType = BaseLocalizedResources.PurchasePlanQuantity;
                }
            }
            GridView gridView = (GridView)fld_dgcInventoryStocks.MainView;

            GridColumn column = new GridColumn();

            column = new GridColumn();
            column.FieldName = "ICProductSerieContainerNo";
            column.Caption = "Mã Container";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 15;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieProductLength";
            column.Caption = "Dài(mm)";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 6;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductSerieProductWidth";
            column.Caption = "Rộng(mm)";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 8;
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n2}";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICProductAttributeTTMTName";
            column.Caption = "TTMT";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "GECountryName";
            column.Caption = "Xuất xứ";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);

            if (Product.ICProductType == ProductType.Verneer.ToString()
                || Product.ICProductType == ProductType.Roundwood.ToString()
                || Product.ICProductType == ProductType.Reuse.ToString()
                || Product.ICProductType == ProductType.Lumber.ToString()
                || Product.ICProductType == ProductType.ArtificialBoard.ToString())
            {
                column = new GridColumn();
                column.FieldName = "ICInventoryStockWoodQuantity";
                column.Caption = CommonLocalizedResources.WoodQtyText;
                column.OptionsColumn.AllowEdit = false;
                column.VisibleIndex = 3;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
                gridView.Columns.Add(column);
            }
            if (Product.ICProductType == ProductType.Roundwood.ToString())
            {
                column = new GridColumn();
                column.FieldName = "ICProductSerieProductDesc";
                column.Caption = "Mô tả";
                column.OptionsColumn.AllowEdit = false;
                column.VisibleIndex = 5;
                gridView.Columns.Add(column);

                column = new GridColumn();
                column.FieldName = "ICProductSerieProductPerimeter";
                column.Caption = "Hoành(mm)";
                column.OptionsColumn.AllowEdit = false;
                column.VisibleIndex = 7;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
                gridView.Columns.Add(column);

                column = new GridColumn();
                column.FieldName = "ICProductAttributeWoodTypeName";
                column.Caption = "Loại nguyên liệu";
                column.OptionsColumn.AllowEdit = false;
                column.VisibleIndex = 8;
                gridView.Columns.Add(column);

            }
            if (Product.ICProductType == ProductType.IngredientPackaging.ToString())
            {
                column = new GridColumn();
                column.FieldName = "ICProductSerieProductDesc";
                column.Caption = "Mô tả";
                column.OptionsColumn.AllowEdit = false;
                column.VisibleIndex = 5;
                gridView.Columns.Add(column);
            }

            if (Product.ICProductType == ProductType.Equipment.ToString())
            {
                column = new GridColumn();
                column.FieldName = "ICModelName";
                column.Caption = "Nhãn hiệu";
                column.OptionsColumn.AllowEdit = false;
                column.VisibleIndex = 5;
                gridView.Columns.Add(column);

                column = new GridColumn();
                column.FieldName = "ICModelDetailName";
                column.Caption = "Model";
                column.OptionsColumn.AllowEdit = false;
                column.VisibleIndex = 5;
                gridView.Columns.Add(column);
            }
            if (Product.ICProductType == ProductType.Verneer.ToString()
                 || Product.ICProductType == ProductType.Reuse.ToString()
                 || Product.ICProductType == ProductType.Lumber.ToString())
            {
                column = new GridColumn();
                column.FieldName = "ICTransactionLengthMin";
                column.Caption = "Dài Min(mm)";
                column.OptionsColumn.AllowEdit = false;
                column.VisibleIndex = 6;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
                gridView.Columns.Add(column);

                column = new GridColumn();
                column.FieldName = "ICTransactionLengthMax";
                column.Caption = "Dài Max(mm)";
                column.OptionsColumn.AllowEdit = false;
                column.VisibleIndex = 7;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
                gridView.Columns.Add(column);

                column = new GridColumn();
                column.FieldName = "ICTransactionWidthMin";
                column.Caption = "Rộng Min(mm)";
                column.OptionsColumn.AllowEdit = false;
                column.VisibleIndex = 8;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
                gridView.Columns.Add(column);

                column = new GridColumn();
                column.FieldName = "ICTransactionWidthMax";
                column.Caption = "Rộng Max(mm)";
                column.OptionsColumn.AllowEdit = false;
                column.VisibleIndex = 9;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
                gridView.Columns.Add(column);

                column = new GridColumn();
                column.FieldName = "ICProductSerieProductHeight";
                column.Caption = "Dày(mm)";
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
                column.OptionsColumn.AllowEdit = false;
                column.VisibleIndex = 10;
                gridView.Columns.Add(column);

                column = new GridColumn();
                column.FieldName = "ICTransactionPerimeter";
                column.Caption = "Hoành(mm)";
                column.OptionsColumn.AllowEdit = false;
                column.VisibleIndex = 11;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
                gridView.Columns.Add(column);

                column = new GridColumn();
                column.FieldName = "ICProductAttributeQualityName";
                column.Caption = "Chất lượng";
                column.OptionsColumn.AllowEdit = false;
                column.VisibleIndex = 12;
                gridView.Columns.Add(column);
                //}
            }
            if (Product.ICProductType == ProductType.ArtificialBoard.ToString())
            {
                column = new GridColumn();
                column.FieldName = "ICProductSerieProductHeight";
                column.Caption = "Dày(mm)";
                column.OptionsColumn.AllowEdit = false;
                column.VisibleIndex = 10;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
                gridView.Columns.Add(column);

            }

            foreach (GridColumn colum in gridView.Columns)
            {
                if (colum.FieldName == "ICInventoryStockQuantity")
                {
                    if (Product.ICProductType == ProductType.Verneer.ToString()
               || Product.ICProductType == ProductType.Roundwood.ToString()
               || Product.ICProductType == ProductType.Reuse.ToString()
               || Product.ICProductType == ProductType.Lumber.ToString()
               || Product.ICProductType == ProductType.ArtificialBoard.ToString())
                    {
                        colum.Caption = "Khối lượng";
                    }
                    else
                    {
                        colum.Caption = "Số lượng";
                    }
                    colum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    colum.DisplayFormat.FormatString = "{0:n5}";
                }
                if (colum.FieldName == "FK_BRBranchID")
                {
                    colum.Visible = false;
                }
                if (colum.FieldName == "InventoryType")
                {
                    colum.SummaryItem.DisplayFormat = "{0:0.####}";
                }
                if (colum.FieldName == "ICInventoryStockInitQty")
                {
                    colum.SummaryItem.DisplayFormat = "{0:0.####}";
                }
                if (colum.FieldName == "ICInventoryStockQuantity")
                {
                    colum.SummaryItem.DisplayFormat = "{0:0.####}";
                }
                if (colum.FieldName == "ICInventoryStockProposalQuantity")
                {
                    colum.SummaryItem.DisplayFormat = "{0:0.####}";
                }
                if (colum.FieldName == "ICInventoryStockSaleOrderQuantity")
                {
                    colum.SummaryItem.DisplayFormat = "{0:0.####}";
                }
                if (colum.FieldName == "ICInventoryStockPurchaseOrderQuantity")
                {
                    colum.SummaryItem.DisplayFormat = "{0:0.####}";
                }
            }
            //gridView.GroupFormat = "[#image]{1}: {2}";
            //column = gridView.Columns["InventoryType"];
            //if (column != null)
            //{
            //    column.Group();
            //    //GridGroupSummaryItem summaryItem = (GridGroupSummaryItem)gridView.GroupSummary.Add(
            //    //                                                    SummaryItemType.Sum,
            //    //                                                    "ICInventoryStockQuantity");
            //    //summaryItem.DisplayFormat = "{0:0.####}";
            //}
            if (Product.ICProductType == ProductType.Verneer.ToString()
               || Product.ICProductType == ProductType.Roundwood.ToString()
               || Product.ICProductType == ProductType.Reuse.ToString()
               || Product.ICProductType == ProductType.Lumber.ToString()
               || Product.ICProductType == ProductType.ArtificialBoard.ToString())
            {
                GridColumn column2 = gridView.Columns["ICProductSerieNo"];
                if (column2 != null)
                    column2.Caption = CommonLocalizedResources.SerialNoText;
                column2 = gridView.Columns["ICProductSerieLotNo"];
                if (column2 != null)
                    column2.Caption = CommonLocalizedResources.LotNoText;
            }
            else
            {
                GridColumn column2 = gridView.Columns["ICProductSerieNo"];
                if (column2 != null)
                    column2.Caption = CommonLocalizedResources.LotNoText;
                column2 = gridView.Columns["ICProductSerieLotNo"];
                if (column2 != null)
                    column2.Visible = false;
            }
            gridView.GridControl.DataSource = inventoryStocks;
            gridView.GridControl?.RefreshDataSource();
            fld_dgcInventoryStocks.ReInitFormat("N2", "N2");
            gridView.BestFitColumns();
            gridView.ExpandAllGroups();
            // Will be implement soon
            if (gridView.GroupSummary.Count > 1)
            {
                for (int i = gridView.GroupSummary.Count; i > 1; i--)
                {
                    gridView.GroupSummary.RemoveAt(i - 1);
                }
            }
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
