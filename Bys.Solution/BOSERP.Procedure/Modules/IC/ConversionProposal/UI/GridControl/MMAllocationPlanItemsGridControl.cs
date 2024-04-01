using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ConversionProposal
{
    public partial class MMAllocationPlanItemsGridControl : ItemGridControl
    {
        BOSList<MMAllocationPlanItemsInfo> AllocationItemList = new BOSList<MMAllocationPlanItemsInfo>();
        public void InvalidateDataSource(BOSList<MMAllocationPlanItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            AllocationItemList = dataSource;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            foreach (GridColumn item in gridView.Columns)
            {
                item.OptionsColumn.AllowEdit = false;
            }
            GridColumn column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["MMAllocationPlanItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["MMAllocationPlanItemSplitComment"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["Selected"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["MMAllocationPlanItemWoodQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["MMAllocationPlanItemLength"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Caption = "Dài sử dụng";
            }
            column = gridView.Columns["MMAllocationPlanItemLengthMin"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Caption = "Dài kiện";
            }
            column = gridView.Columns["MMAllocationPlanItemBPProductionNormItemQty"];
            if (column != null)
            {
                column.Caption = "M3 kế hoạch";
                InitColumnSummary("MMAllocationPlanItemBPProductionNormItemQty", DevExpress.Data.SummaryItemType.Sum);
            }
            column = gridView.Columns["MMAllocationPlanItemNormQty"];
            if (column != null)
            {
                column.Caption = "Số thanh kế hoạch";
                InitColumnSummary("MMAllocationPlanItemNormQty", DevExpress.Data.SummaryItemType.Sum);
            }
            column = gridView.Columns["MMAllocationPlanItemQty"];
            if (column != null)
            {
                column.Caption = "M3 sử dụng";
                InitColumnSummary("MMAllocationPlanItemQty", DevExpress.Data.SummaryItemType.Sum);
            }
            column = gridView.Columns["MMAllocationPlanItemProductionNormItemBlocks"];
            if (column != null)
            {
                column.Caption = "M3 kiện";
            }
            column = gridView.Columns["MMAllocationPlanItemInventoryStock"];
            if (column != null)
            {
                column.Caption = "Số thanh kiện";
            }
            column = gridView.Columns["MMAllocationProposalItemShippedQty"];
            if (column != null)
            {
                column.Caption = "Số thanh(Còn lại)";
            }

            column = new GridColumn();
            column.Caption = "Thêm dòng";
            column.FieldName = "AddNewRow";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;

            RepositoryItemHyperLinkEdit AddNewRow = new RepositoryItemHyperLinkEdit();
            AddNewRow.NullText = "Thêm dòng";
            AddNewRow.Click += new EventHandler(AddNewRow_Click);
            column.ColumnEdit = AddNewRow;

            gridView.Columns.Add(column);
            return gridView;
        }

        //private void gridView_EndGrouping(object sender, EventArgs e)
        //{
        //    GridView gridView = (GridView)sender;
        //    gridView.ExpandAllGroups();
        //}

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle < 0) return;
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", int.Parse(e.Value.ToString()), "ICProductNo");
                }
                else
                    e.DisplayText = "";
            }
        }
        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            //base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
                if (e.Column == gridView.Columns["MMAllocationPlanItemProductSerialNo"])
                {

                    if (!string.IsNullOrEmpty(item.MMAllocationPlanItemProductSerialNo))
                    {
                        
                        ICProductSeriesInfo objProductSeriesInfo = (ICProductSeriesInfo)objProductSeriesController.GetStockAndObjectByProductSerieID(item.FK_ICProductID, item.FK_ICStockID, item.MMAllocationPlanItemProductSerialNo.Trim(), DateTime.Now);
                        if (objProductSeriesInfo != null)
                        {
                            decimal sumQty = AllocationItemList.Where(o => o.Id != item.Id && o.FK_ICProductSerieID == objProductSeriesInfo.ICProductSerieID).Sum(o => o.MMAllocationPlanItemQty);
                            decimal sumWoodQty = AllocationItemList.Where(o => o.Id != item.Id && o.FK_ICProductSerieID == objProductSeriesInfo.ICProductSerieID).Sum(o => o.MMAllocationPlanItemWoodQty);
                            item.MMAllocationPlanItemProductionNormItemBlocks = objProductSeriesInfo.ICInventoryStockQuantity;
                            item.MMAllocationPlanItemInventoryStock = objProductSeriesInfo.ICProductSerieWoodQty;
                            item.MMAllocationPlanItemQty = objProductSeriesInfo.ICInventoryStockQuantity - sumQty;
                            item.MMAllocationPlanItemWoodQty = Math.Round(objProductSeriesInfo.ICProductSerieProductLength * objProductSeriesInfo.ICProductSerieProductWidth * objProductSeriesInfo.ICProductSerieProductHeight == 0 ? 0 :
                                item.MMAllocationPlanItemQty / (objProductSeriesInfo.ICProductSerieProductLength * objProductSeriesInfo.ICProductSerieProductWidth * objProductSeriesInfo.ICProductSerieProductHeight) * 1000000000, 0);
                            item.MMAllocationPlanItemHeight = objProductSeriesInfo.ICProductSerieProductHeight;
                            item.MMAllocationPlanItemWidth = objProductSeriesInfo.ICProductSerieProductWidth;
                            item.MMAllocationPlanItemLength = objProductSeriesInfo.ICProductSerieProductLength;
                            item.MMAllocationPlanItemLengthMin = objProductSeriesInfo.ICProductSerieProductLength;
                            item.FK_ICProductAttributeTTMTID = objProductSeriesInfo.FK_ICProductAttributeTTMTID;
                            item.MMAllocationPlanItemPositionName = objProductSeriesInfo.ICProductSeriePositionName;
                            item.ICProductNoOfOldSys = objProductSeriesInfo.ICProductAttributeTTMT;
                            item.FK_ICProductAttributeQualityID = objProductSeriesInfo.FK_ICProductAttributeQualityID;
                            item.APSupplierName = objProductSeriesInfo.APSupplierName;
                            item.FK_ICProductSerieID = objProductSeriesInfo.ICProductSerieID;
                            item.FK_ICProductAlternativeID = objProductSeriesInfo.FK_ICProductID; // Trường hợp dùng kiện  cùng loại gỗ khác độ dày => khác mã SP
                            item.MMAllocationPlanItemRemainQty = objProductSeriesInfo.ICInventoryStockQuantity - item.MMAllocationPlanItemQty - sumQty;
                            item.MMAllocationProposalItemShippedQty = objProductSeriesInfo.ICProductSerieWoodQty - item.MMAllocationPlanItemWoodQty - sumWoodQty;
                            item.FK_ICStockID = objProductSeriesInfo.FK_ICStockID;
                            item.Selected = true;
                        }
                    }
                    else
                    { 
                        item.Selected = false;
                        item.MMAllocationPlanItemProductionNormItemBlocks = 0;
                        item.MMAllocationPlanItemInventoryStock = 0;
                        item.APSupplierName = string.Empty;
                        item.MMAllocationPlanItemRemainQty = 0;
                        item.FK_ICStockID = 0;
                        item.FK_ICProductSerieID = 0;
                        item.FK_ICProductAlternativeID = 0;
                        item.MMAllocationProposalItemShippedQty = 0;
                        item.FK_ICProductAttributeTTMTID = 0;
                        item.FK_ICProductAttributeQualityID = 0;
                        item.ICProductNoOfOldSys = string.Empty;
                        item.MMAllocationPlanItemQty = item.MMAllocationPlanItemBPProductionNormItemQty;
                        item.MMAllocationPlanItemWoodQty = Math.Round(item.MMAllocationPlanItemHeightMax * item.MMAllocationPlanItemWidthMax * item.MMAllocationPlanItemLengthMax == 0 ? 0 :
                                item.MMAllocationPlanItemQty / (item.MMAllocationPlanItemHeightMax * item.MMAllocationPlanItemWidthMax * item.MMAllocationPlanItemLengthMax) * 1000000000, 0);
                    }
                }
                if ((e.Column == gridView.Columns["MMAllocationPlanItemWoodQty"] || e.Column == gridView.Columns["MMAllocationPlanItemLength"]) && !string.IsNullOrEmpty(item.MMAllocationPlanItemProductSerialNo))
                {
                    decimal sumQty = AllocationItemList.Where(o => o.Id != item.Id && o.FK_ICProductSerieID == item.FK_ICProductSerieID).Sum(o => o.MMAllocationPlanItemQty);
                    decimal sumWoodQty = AllocationItemList.Where(o => o.Id != item.Id && o.FK_ICProductSerieID == item.FK_ICProductSerieID).Sum(o => o.MMAllocationPlanItemWoodQty);
                    item.MMAllocationPlanItemQty = ((item.MMAllocationPlanItemHeight * item.MMAllocationPlanItemWidth * item.MMAllocationPlanItemLength) / 1000000000) * item.MMAllocationPlanItemWoodQty;
                    item.MMAllocationPlanItemRemainQty = item.MMAllocationPlanItemProductionNormItemBlocks - item.MMAllocationPlanItemQty - sumQty;
                    item.MMAllocationProposalItemShippedQty = item.MMAllocationPlanItemInventoryStock - item.MMAllocationPlanItemWoodQty - sumWoodQty;
                }
                else if (e.Column == gridView.Columns["MMAllocationPlanItemWoodQty"] && string.IsNullOrEmpty(item.MMAllocationPlanItemProductSerialNo))
                {
                    BOSApp.ShowMessage("Vui lòng chọn kiện trước");
                    item.MMAllocationPlanItemWoodQty = Math.Round(item.MMAllocationPlanItemHeightMax * item.MMAllocationPlanItemWidthMax * item.MMAllocationPlanItemLengthMax == 0 ? 0 :
                                item.MMAllocationPlanItemQty / (item.MMAllocationPlanItemHeightMax * item.MMAllocationPlanItemWidthMax * item.MMAllocationPlanItemLengthMax) * 1000000000, 0);
                }
                this.RefreshDataSource();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Chọn";
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Dài BTP";
            column.FieldName = "MMBatchProductProductionNormItemProductLength";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Rộng BTP";
            column.FieldName = "MMBatchProductProductionNormItemProductWidth";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Dày BTP";
            column.FieldName = "MMBatchProductProductionNormItemProductHeight";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã đơn hàng nội bộ";
            column.FieldName = "MMBatchProductItemSOName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số thanh (sử dụng)";
            column.FieldName = "MMAllocationPlanItemWoodQty";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            gridView.Columns.Add(column);
            InitColumnSummary("MMAllocationPlanItemWoodQty", DevExpress.Data.SummaryItemType.Sum);

            column = new GridColumn();
            column.Caption = "M3 còn lại";
            column.FieldName = "MMAllocationPlanItemRemainQty";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);
            column = gridView.Columns["MMAllocationProposalItemShippedQty"];
            if (column == null)
            {
                column = new GridColumn();
                column.Caption = "Số thanh (Còn lại)";
                column.FieldName = "MMAllocationProposalItemShippedQty";
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
                gridView.Columns.Add(column);
            }
            column = gridView.Columns["MMAllocationPlanItemNormQty"];
            if (column == null)
            {
                column = new GridColumn();
                column.Caption = "Số thanh kế hoạch";
                column.FieldName = "MMAllocationPlanItemNormQty";
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
                InitColumnSummary("MMAllocationPlanItemNormQty", DevExpress.Data.SummaryItemType.Sum);
                gridView.Columns.Add(column);
            }
            column = new GridColumn();
            column.Caption = "Ghi chú cắt tách";
            column.FieldName = "MMAllocationPlanItemSplitComment";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nhà cung cấp";
            column.FieldName = "APSupplierName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Vị trí";
            column.FieldName = "MMAllocationPlanItemPositionName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            //column = new GridColumn();
            //column.Caption = "Thêm dòng";
            //column.FieldName = "AddNewRow";
            //column.OptionsColumn.AllowEdit = true;
            //column.Visible = true;

            //RepositoryItemHyperLinkEdit AddNewRow = new RepositoryItemHyperLinkEdit();
            //AddNewRow.NullText = "Thêm dòng";
            //AddNewRow.Click += new EventHandler(AddNewRow_Click);
            //column.ColumnEdit = AddNewRow;

            //gridView.Columns.Add(column);


        }
        private void AddNewRow_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)this.ViewCollection[0];
            if (gridView.FocusedRowHandle >= 0)
            {
                MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (item != null)
                {
                    MMAllocationPlanItemsInfo itemNew = (MMAllocationPlanItemsInfo)item.Clone();
                    int index = AllocationItemList.IndexOf(item);
                    itemNew.Selected = false;
                    itemNew.MMAllocationPlanItemProductionNormItemBlocks = 0;
                    itemNew.APSupplierName = string.Empty;
                    itemNew.MMAllocationPlanItemRemainQty = 0;
                    itemNew.FK_ICStockID = 0;
                    itemNew.MMAllocationProposalItemShippedQty = 0;
                    itemNew.MMAllocationPlanItemInventoryStock = 0;
                    itemNew.MMAllocationPlanItemProductSerialNo = string.Empty;
                    decimal sumQty = AllocationItemList.Where(o => o.Id == item.Id ).Sum(o => o.MMAllocationPlanItemQty);
                    decimal sumWoodQty = AllocationItemList.Where(o => o.Id == item.Id).Sum(o => o.MMAllocationPlanItemWoodQty);
                    itemNew.MMAllocationPlanItemQty = itemNew.MMAllocationPlanItemBPProductionNormItemQty - sumQty;
                    itemNew.MMAllocationPlanItemHeight = itemNew.MMAllocationPlanItemHeightMax;
                    itemNew.MMAllocationPlanItemWidth = itemNew.MMAllocationPlanItemWidthMax;
                    itemNew.MMAllocationPlanItemLength = itemNew.MMAllocationPlanItemLengthMax;
                    
                    itemNew.MMAllocationPlanItemWoodQty = Math.Round(itemNew.MMAllocationPlanItemHeightMax * itemNew.MMAllocationPlanItemWidthMax * itemNew.MMAllocationPlanItemLengthMax == 0 ? 0 :
                                item.MMAllocationPlanItemQty / (itemNew.MMAllocationPlanItemHeightMax * itemNew.MMAllocationPlanItemWidthMax * itemNew.MMAllocationPlanItemLengthMax) * 1000000000, 0);
                    if (itemNew.MMAllocationPlanItemQty > 0)
                    {
                        AllocationItemList.Insert(index + 1, itemNew);
                        this.DataSource = AllocationItemList;
                        this.RefreshDataSource();
                    }
                    else
                    {
                        BOSApp.ShowMessage("M3 và số thanh đã sử dụng hết");
                    }
                }
            }
        }
    }
}
