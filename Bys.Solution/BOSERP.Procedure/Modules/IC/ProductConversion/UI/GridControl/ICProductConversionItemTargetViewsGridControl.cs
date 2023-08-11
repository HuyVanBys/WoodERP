using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConversion
{
    public class ICProductConversionItemTargetViewsGridControl : BOSGridControl
    {
        public void InitGridControlDataSource(BOSList<ICProductConversionItemsInfo> ListItem)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = ListItem;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Mã đơn hàng";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "FK_ARSaleOrderID";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã hàng";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "FK_ICProductForBatchID";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã kiện gốc";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "ICProductConversionItemSourceSerialNo";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Chọn";
            column.OptionsColumn.AllowEdit = true;
            column.FieldName = "Selected";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "M3 còn lại";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "ICProductConversionItemUsedQty";
            gridView.Columns.Add(column);
            InitColumnSummary("ICProductConversionItemUsedQty", DevExpress.Data.SummaryItemType.Sum);

            column = new GridColumn();
            column.Caption = "Số thanh còn lại";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "ICProductConversionItemWoodUsedQty";
            gridView.Columns.Add(column);
            InitColumnSummary("ICProductConversionItemWoodUsedQty", DevExpress.Data.SummaryItemType.Sum);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            GridColumn column1 = gridView.Columns["Selected"];
            if (column1 != null)
            {
                column1.OptionsColumn.AllowEdit = true;
            }
            InitColumnSummary("ICProductConversionItemProductQty", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("ICProductConversionItemWoodQty", DevExpress.Data.SummaryItemType.Sum);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            return gridView;
        }
        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "ICProductConversionItemProductQty" 
                    || e.Column.FieldName == "ICProductConversionItemWoodUsedQty"
                    || e.Column.FieldName == "ICProductConversionItemUsedQty"
                    || e.Column.FieldName == "ICProductConversionItemProductSerialNo"
                    )
                {
                    ICProductConversionItemsInfo obj = (ICProductConversionItemsInfo)gridView.GetRow(e.RowHandle);
                    if (obj != null && obj.ICProductConversionItemUsedQty == 0)
                    {
                        e.Appearance.BackColor = Color.YellowGreen;
                        e.Appearance.BackColor2 = Color.YellowGreen;
                    }
                    else if (obj != null && obj.ICProductConversionItemUsedQty < 0)
                    {
                        e.Appearance.BackColor = Color.Red;
                        e.Appearance.BackColor2 = Color.Red;
                    }

                }

            }
        }
        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ARSaleOrderID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ARSaleOrders", "ARSaleOrderID", int.Parse(e.Value.ToString()), "ARSaleOrderNo");
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
        protected override void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);
            GridView gridView = (GridView)sender;
            if (gridView == null)
                return;

            ICProductConversionItemsInfo item = (ICProductConversionItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            ((guiChooseItemShipment)Screen).CurrentObject = item;
            ((guiChooseItemShipment)Screen).ChangeFocusAllocationPlanItem(item);
        }
    }
}
