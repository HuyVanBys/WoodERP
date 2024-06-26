using BOSLib;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BOSERP.Modules.SaleOrder
{
    public class UpdateSaleOrderItemOtherFeesGridControl : BOSGridControl
    {
        public List<ARSaleOrderItemOtherFeesInfo> ListOtherFee { get; set; }

        public void InvalidateDataSource(List<ARSaleOrderItemOtherFeesInfo> listOtherFee)
        {
            ListOtherFee = listOtherFee;
            BindingSource bds = new BindingSource();
            bds.DataSource = ListOtherFee;
            this.DataSource = bds;
            RefreshDataSource();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.OptionsView.ShowFooter = true;
            STFieldFormatGroupsInfo formatsInfo = new STFieldFormatGroupsInfo();
            GridColumn column = gridView.Columns["ARSaleOrderItemOtherFeeName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARSaleOrderItemOtherFeeQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ARSaleOrderItemOtherFees", "ARSaleOrderItemOtherFeeQty", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(column, true, formatsInfo.STFieldFormatGroupFormatString);
                    column.SummaryItem.DisplayFormat = formatsInfo.STFieldFormatGroupFormatString;
                }
            }
            column = gridView.Columns["ARSaleOrderItemOtherFeeUnitPrice"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ARSaleOrderItemOtherFeeTotalPrice"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ARSaleOrderItemOtherFees", "ARSaleOrderItemOtherFeeTotalPrice", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(column, false, formatsInfo.STFieldFormatGroupFormatString);
                    column.SummaryItem.DisplayFormat = formatsInfo.STFieldFormatGroupFormatString;
                }
            }
            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)MainView;
            //SaleOrderEntities entity = (SaleOrderEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ARSaleOrderItemOtherFeesInfo item = (ARSaleOrderItemOtherFeesInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item != null)
            {
                if (e.Column.FieldName == "ARSaleOrderItemOtherFeeQty"
                    || e.Column.FieldName == "ARSaleOrderItemOtherFeeUnitPrice")
                {
                    item.ARSaleOrderItemOtherFeeTotalPrice = item.ARSaleOrderItemOtherFeeUnitPrice * item.ARSaleOrderItemOtherFeeQty;
                    RefreshDataSource();
                    (this.Screen as guiUpdateOtherFees).RefreshData();
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                GridView gridView = (GridView)MainView;
                if (gridView != null && gridView.FocusedRowHandle >= 0)
                {
                    ARSaleOrderItemOtherFeesInfo item = (ARSaleOrderItemOtherFeesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    ListOtherFee.Remove(item);
                    (this.Screen as guiUpdateOtherFees).RefreshData();
                    (this.Screen as guiUpdateOtherFees).DeleteOtherFee(item);
                }
            }
        }

        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);
            GridView gridView = (GridView)sender;
            ARSaleOrderItemOtherFeesInfo item = (ARSaleOrderItemOtherFeesInfo)gridView.GetRow(gridView.FocusedRowHandle);
            item.ARSaleOrderItemOtherFeeQty = 1;
        }
    }
}
