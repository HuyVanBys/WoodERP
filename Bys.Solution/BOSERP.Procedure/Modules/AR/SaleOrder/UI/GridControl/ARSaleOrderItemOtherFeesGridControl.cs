using BOSLib;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;

namespace BOSERP.Modules.SaleOrder
{
    public class ARSaleOrderItemOtherFeesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            SaleOrderEntities entity = (SaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.SaleOrderItemOtherFeeList;
            this.DataSource = bds;
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
            SaleOrderEntities entity = (SaleOrderEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.SaleOrderItemOtherFeeList.CurrentIndex >= 0)
            {
                ARSaleOrderItemOtherFeesInfo item = entity.SaleOrderItemOtherFeeList[entity.SaleOrderItemOtherFeeList.CurrentIndex];
                if (e.Column.FieldName == "ARSaleOrderItemOtherFeeQty"
                    || e.Column.FieldName == "ARSaleOrderItemOtherFeeUnitPrice")
                {
                    ((SaleOrderModule)Screen.Module).UpdateTotalSaleOrderItemOtherFee();
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((SaleOrderModule)Screen.Module).DeleteSaleOrderItemOtherFee();
            }
        }

        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);
            GridView gridView = (GridView)sender;
            ARSaleOrderItemOtherFeesInfo item = (ARSaleOrderItemOtherFeesInfo)gridView.GetRow(gridView.FocusedRowHandle);
            item.ARSaleOrderItemOtherFeeQty = 1;
        }

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);
            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn.FieldName == "ARSaleOrderItemOtherFeeQty")
            {
                if (e.Value != null)
                {
                    decimal feePercent = Convert.ToDecimal(e.Value);
                    if (feePercent <= 0)
                    {
                        e.ErrorText = "Vui lòng nhập số lượng lớn hơn 0";
                        e.Valid = false;
                    }
                }
            }
            //else if (gridView.FocusedColumn.FieldName == "ARSaleOrderItemOtherFeeUnitPrice")
            //{
            //    if (e.Value != null)
            //    {
            //        decimal feeUnitPrice = Convert.ToDecimal(e.Value);
            //        if (feeUnitPrice <= 0)
            //        {
            //            e.ErrorText = "Vui lòng nhập đơn giá lớn hơn 0";
            //            e.Valid = false;
            //        }
            //    }
            //}
        }
    }
}
