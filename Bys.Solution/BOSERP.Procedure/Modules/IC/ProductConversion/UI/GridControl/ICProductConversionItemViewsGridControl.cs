using BOSCommon;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConversion
{
    public class ICProductConversionItemViewsGridControl : BOSGridControl
    {
        public void InitGridControlDataSource(List<ICProductConversionItemsInfo> ListItem)
        {
            ProductConversionEntities entity = (ProductConversionEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = ListItem;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Áp giá đích danh";
            column.FieldName = "ICProductConversionItemIsSpecificCalculation";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Chênh lệch trên";
            column.FieldName = "ICProductConversionItemConfigType";
            RepositoryItemBOSLookupEdit lookupEdit = InitRepositoryForConfigValues(ADConfigValueUtility.ConfigValues.Tables["ProductConfigRateType"]);
            column.ColumnEdit = lookupEdit;
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Số lượng/Tỷ lệ";
            column.FieldName = "ICProductConversionItemConfigValue";
            FormatNumbericColumn(column, true, "n2");
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Phí chuyển mã";
            column.FieldName = "ICProductConversionItemCost";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tổng phí chuyển mã";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "ICProductConversionItemTotalFeeCost";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Loại";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "ICProductConversionItemType";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã kiện gốc";
            column.OptionsColumn.AllowEdit = false;
            column.FieldName = "ICProductConversionItemSourceSerialNo";
            column.Group();
            gridView.Columns.Add(column);

        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            InitColumnSummary("ICProductConversionItemProductQty", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("ICProductConversionItemWoodQty", DevExpress.Data.SummaryItemType.Sum);
            return gridView;
        }

        protected override void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);
            GridView gridView = (GridView)sender;
            if (gridView == null)
                return;

            ((ProductConversionModule)Screen.Module).CurrentObject = (ICProductConversionItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            ((ProductConversionModule)Screen.Module).ChangeFocusSourceProduct();
        }

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICProductConversionItemsInfo item = (ICProductConversionItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (item != null)
            {
                ICMeasureUnitsController controller = new ICMeasureUnitsController();
                DataSet measureUnits = controller.GetMeasureUnitByProductID(item.FK_ICProductID);
                if (measureUnits != null)
                {
                    lookUpEdit.Properties.DataSource = measureUnits.Tables[0];
                    lookUpEdit.Properties.DisplayMember = "ICMeasureUnitName";
                    lookUpEdit.Properties.ValueMember = "ICMeasureUnitID";
                }
                measureUnits.Dispose();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            ProductConversionEntities entity = (ProductConversionEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ICProductConversionItemsInfo item = (ICProductConversionItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item == null)
                return;
            if (e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                ((ProductConversionModule)Screen.Module).ChangeItemMeasureUnit(item, false);
            }
            if (e.Column.FieldName == "FK_ICProductID")
            {
                ((ProductConversionModule)Screen.Module).ChangeSourceProduct(item);
            }
            ((ProductConversionModule)Screen.Module).ChangeProductConversionItem(entity.ProductConversionItemsList);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            GridView gridView = (GridView)sender;
            ICProductConversionItemsInfo item = (ICProductConversionItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (e.KeyCode == Keys.Delete && item != null)
            {
                ((ProductConversionModule)Screen.Module).DeleteProductViewList(item);
                ((guiShowAll)Screen).RemoveItemList(item);
                this.RefreshDataSource();
            }
        }

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            ICProductConversionItemsInfo item = (ICProductConversionItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "ICProductConversionItemProductFactor")
                {
                    if (!string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        ICProductMeasureUnitsController controller = new ICProductMeasureUnitsController();
                        ICProductMeasureUnitsInfo measureUnit = controller.GetProductMeasureUnitByProductIDAndMeasureUnitID(item.FK_ICProductID, item.FK_ICMeasureUnitID);
                        if (measureUnit != null && measureUnit.ICProductMeasureUnitIsEdit)
                            return;
                        e.ErrorText = "Hệ số không được phép thay đổi.";
                        e.Valid = false;
                    }
                }
            }
        }

        private void repositoryLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACAccountsController objAccountsController = new ACAccountsController();
            lookUpEdit.Properties.DataSource = objAccountsController.GetListAccountNotChild().Tables[0];
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
            if (e.Column.FieldName == "ICProductConversionItemType")
            {
                if (e.Value != null)
                {

                    e.DisplayText = e.Value.ToString() == ProductConversionItemType.Source.ToString() ? "Gốc" : "Đích";
                }
                else
                    e.DisplayText = "";
            }
        }
    }
}
