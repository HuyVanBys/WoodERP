using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Linq;
using System;
using BOSLib;

namespace BOSERP.Modules.SaleOrder
{
    public class UpdateSaleOrderItemAllocationFeesGridControl : ItemGridControl
    {
        public List<ARSaleOrderItemAllocationFeesInfo> ListAllocationFee { get; set; }

        public void InvalidateDataSource(List<ARSaleOrderItemAllocationFeesInfo> listAllocationFee)
        {
            ListAllocationFee = listAllocationFee;
            BindingSource bds = new BindingSource();
            bds.DataSource = ListAllocationFee;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            SaleOrderEntities entity = (SaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            GridColumn column = new GridColumn();
            column.Caption = "Mã sản phẩm";
            column.FieldName = "ARSaleOrderItemVirtualID";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemLookUpEdit AttributeQualityIDLookUpEdit = new RepositoryItemLookUpEdit();
            AttributeQualityIDLookUpEdit.DisplayMember = "ARSaleOrderItemProductNo";
            AttributeQualityIDLookUpEdit.ValueMember = "ARSaleOrderItemVirtualID";
            AttributeQualityIDLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            AttributeQualityIDLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            AttributeQualityIDLookUpEdit.NullText = string.Empty;
            AttributeQualityIDLookUpEdit.DataSource = entity.ARSaleOrderItemsList;
            AttributeQualityIDLookUpEdit.Columns.Add(new LookUpColumnInfo("ARSaleOrderItemProductNo", "Mã sản phẩm"));
            AttributeQualityIDLookUpEdit.Columns.Add(new LookUpColumnInfo("ARSaleOrderItemProductQty", "Số lượng"));
            AttributeQualityIDLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(SaleOrderItemLookUpEdit_QueryPopUp);
            column.ColumnEdit = AttributeQualityIDLookUpEdit;
            gridView.Columns.Add(column);
        }

        void SaleOrderItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            SaleOrderEntities entity = (SaleOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            lookUpEdit.Properties.DataSource = entity.ARSaleOrderItemsList;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.OptionsView.ShowFooter = true;
            STFieldFormatGroupsInfo formatsInfo = new STFieldFormatGroupsInfo();
            GridColumn column = gridView.Columns["ARSaleOrderItemAllocationFeeProductNo"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["ARSaleOrderItemAllocationFeeProductName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ARSaleOrderItemAllocationFeeProductNoOfOldSys"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ARSaleOrderItemAllocationFeeProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ARSaleOrderItemAllocationFeeFeePercent"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ARSaleOrderItemAllocationFees", "ARSaleOrderItemAllocationFeeFeePercent", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(column, true, formatsInfo.STFieldFormatGroupFormatString);
                    column.SummaryItem.DisplayFormat = formatsInfo.STFieldFormatGroupFormatString;
                }
            }
            column = gridView.Columns["ARSaleOrderItemAllocationFeeFeeAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ARSaleOrderItemAllocationFees", "ARSaleOrderItemAllocationFeeFeeAmount", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(column, true, formatsInfo.STFieldFormatGroupFormatString);
                    column.SummaryItem.DisplayFormat = formatsInfo.STFieldFormatGroupFormatString;
                }
            }

            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)MainView;
            SaleOrderEntities entity = (SaleOrderEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ARSaleOrderItemAllocationFeesInfo item = (ARSaleOrderItemAllocationFeesInfo)gridView.GetRow(gridView.FocusedRowHandle);

            if (item != null)
            {
                if (e.Column.FieldName == "ARSaleOrderItemVirtualID")
                {
                    ARSaleOrderItemsInfo objSaleOrderItemsInfo = entity.ARSaleOrderItemsList.FirstOrDefault(o => o.ARSaleOrderItemVirtualID == item.ARSaleOrderItemVirtualID);
                    if (objSaleOrderItemsInfo != null)
                    {
                        item.FK_ICProductID = objSaleOrderItemsInfo.FK_ICProductID;
                        item.FK_ARSaleOrderItemID = objSaleOrderItemsInfo.ARSaleOrderItemID;
                        item.ARSaleOrderItemAllocationFeeProductQty = objSaleOrderItemsInfo.ARSaleOrderItemProductQty;
                        item.ARSaleOrderItemAllocationFeeProductNo = objSaleOrderItemsInfo.ARSaleOrderItemProductNo;
                        ICProductsInfo productsInfo = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductID);
                        if (productsInfo != null)
                        {
                            item.ARSaleOrderItemAllocationFeeProductNo = productsInfo.ICProductNo;
                            item.ARSaleOrderItemAllocationFeeProductName = productsInfo.ICProductName;
                            item.ARSaleOrderItemAllocationFeeProductNoOfOldSys = productsInfo.ICProductNoOfOldSys;
                        }
                    }
                    else
                    {
                        item.FK_ARSaleOrderItemID = 0;
                        item.FK_ICProductID = 0;
                        item.ARSaleOrderItemVirtualID = string.Empty;
                    }
                }
                else if (e.Column.FieldName == "ARSaleOrderItemAllocationFeeFeePercent")
                {
                    (this.Screen as guiUpdateOtherFees).RefreshData();
                }
                else if (e.Column.FieldName == "ARSaleOrderItemAllocationFeeFeeAmount")
                {
                    item.ARSaleOrderItemAllocationFeeFeePercent = (this.Screen as guiUpdateOtherFees).CalcuAllocationFeePercent(item.ARSaleOrderItemAllocationFeeFeeAmount);
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
                    ARSaleOrderItemAllocationFeesInfo item = (ARSaleOrderItemAllocationFeesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    ListAllocationFee.Remove(item);
                    (this.Screen as guiUpdateOtherFees).RefreshData();
                    (this.Screen as guiUpdateOtherFees).DeleteAllocationFee(item);
                }
            }
        }

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            base.GridView_ValidatingEditor(sender, e);
            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn.FieldName == "ARSaleOrderItemAllocationFeeFeePercent")
            {
                if (e.Value != null)
                {
                    decimal feePercent = Convert.ToDecimal(e.Value);
                    if (feePercent < 0)
                    {
                        e.ErrorText = "Vui lòng nhập % phân bổ lớn hơn hoặc bằng 0";
                        e.Valid = false;
                    }
                }
            }
            else if (gridView.FocusedColumn.FieldName == "ARSaleOrderItemVirtualID")
            {
                if (e.Value != null)
                {
                    string saleOrderItemVirtualID = e.Value.ToString();
                    if (!string.IsNullOrWhiteSpace(saleOrderItemVirtualID))
                    {
                        SaleOrderEntities entity = (SaleOrderEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                        ARSaleOrderItemAllocationFeesInfo item = entity.SaleOrderItemAllocationFeeList.FirstOrDefault(o => o.ARSaleOrderItemVirtualID == saleOrderItemVirtualID);
                        if(item != null)
                        {
                            e.ErrorText = "Sản phẩm này đã có trong danh sách phân bổ";
                            e.Valid = false;
                        }
                    }
                }
            }
        }
    }
}
