using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConversion
{
    public partial class MMAllocationPlanItemsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<MMAllocationPlanItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            foreach (GridColumn item in gridView.Columns)
            {
                item.OptionsColumn.AllowEdit = false;
            }
            GridColumn column = gridView.Columns["MMAllocationPlanItemQty"];
            if (column != null)
            {
                column.Caption = "Số m3 xuất";
            }
            GridColumn column1 = gridView.Columns["Selected"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = true;
            }
            InitColumnSummary("MMAllocationPlanItemQty", DevExpress.Data.SummaryItemType.Sum);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            return gridView;
        }
        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                MMAllocationPlanItemsInfo obj = (MMAllocationPlanItemsInfo)gridView.GetRow(e.RowHandle);
                if (e.Column.FieldName == "FK_MMBatchProductID")
                {
                    if (obj != null && obj.MMBatchProductProductionNormItemQuantity <= obj.MMAllocationProposalItemShippedQty)
                    {
                        e.Appearance.BackColor = Color.Red;
                        e.Appearance.BackColor2 = Color.Red;
                    }

                }
                else if (e.Column.FieldName == "MMAllocationPlanItemNormQty" || e.Column.FieldName == "MMAllocationPlanItemQty")
                {
                    decimal shipmentQty = ((guiChooseItemShipment)Screen).GetSameShipmenttoatlQty(obj);
                    if (obj != null && obj.MMAllocationPlanItemNormQty > shipmentQty && obj.FK_ICProductSerieID > 0)
                    {
                        e.Appearance.BackColor = Color.Orange;
                        e.Appearance.BackColor2 = Color.Orange;
                    }
                }
            }
        }
        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", int.Parse(e.Value.ToString()), "ICProductNo");
                }
                else
                    e.DisplayText = "";
            }
            if (e.Column.FieldName == "FK_ICProductForBatchID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", int.Parse(e.Value.ToString()), "ICProductName2");
                }
                else
                    e.DisplayText = "";
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
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
            column.Caption = "Chọn";
            column.OptionsColumn.AllowEdit = true;
            column.FieldName = "Selected";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số thanh/tấm";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "MMAllocationPlanItemWoodQty";
            gridView.Columns.Add(column);
            InitColumnSummary("MMAllocationPlanItemWoodQty", DevExpress.Data.SummaryItemType.Sum);
            column = new GridColumn();
            column.Caption = "Số m3 KH còn lại";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "MMAllocationPlanItemNormQty";
            gridView.Columns.Add(column);
            InitColumnSummary("MMAllocationPlanItemNormQty", DevExpress.Data.SummaryItemType.Sum);
        }
    }
}
