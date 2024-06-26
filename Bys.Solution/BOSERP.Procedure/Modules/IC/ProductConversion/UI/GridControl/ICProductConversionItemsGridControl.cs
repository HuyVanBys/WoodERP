using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConversion
{
    public class ICProductConversionItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            ProductConversionEntities entity = (ProductConversionEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ProductConversionItemsList;
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
            column.Caption = PurchaseReceiptLocalizedResources.Selected;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["ICProductConversionItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICMeasureUnitID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit rpMeasureUnit = new RepositoryItemLookUpEdit();
                rpMeasureUnit.DisplayMember = "ICMeasureUnitName";
                rpMeasureUnit.ValueMember = "ICMeasureUnitID";
                rpMeasureUnit.NullText = string.Empty;
                rpMeasureUnit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));
                DataSet ds = BOSApp.LookupTables[TableName.ICMeasureUnitsTableName] as DataSet;
                rpMeasureUnit.DataSource = ds.Tables[0];
                rpMeasureUnit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpMeasureUnitt_QueryPopUp);
                column.ColumnEdit = rpMeasureUnit;
            }
            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICProductConversionItemProductFactor"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICProductConversionItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICProductConversionItemIsSpecificCalculation"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICProductAttributeQualityID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACAccountID"];
            if (column != null)
            {
                RepositoryItemLookUpEdit rep = new RepositoryItemLookUpEdit();
                rep.DisplayMember = "ACAccountNo";
                rep.ValueMember = "ACAccountID";
                rep.NullText = string.Empty;
                rep.Columns.Add(new LookUpColumnInfo("ACAccountNo", CommonLocalizedResources.ACAccountNo));
                rep.Columns.Add(new LookUpColumnInfo("ACAccountName", CommonLocalizedResources.ACAccountName));
                DataSet ds = BOSApp.LookupTables[TableName.ACAccountsTableName] as DataSet;
                if (ds == null)
                {
                    ds = BOSApp.GetLookupTableData(TableName.ACAccountsTableName);
                    BOSApp.LookupTables[TableName.ACAccountsTableName] = ds;
                }
                rep.DataSource = ds.Tables[0];
                rep.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryLookupEdit_QueryPopUp);
                column.ColumnEdit = rep;
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {

                RepositoryItemBOSLookupEdit repositoryItemLookupEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookupEdit.DisplayMember = "ICProductNo";
                repositoryItemLookupEdit.ValueMember = "ICProductID";
                repositoryItemLookupEdit.TextEditStyle = TextEditStyles.Standard;
                repositoryItemLookupEdit.SearchMode = SearchMode.AutoFilter;
                repositoryItemLookupEdit.NullText = string.Empty;
                repositoryItemLookupEdit.Columns.Add(new LookUpColumnInfo("ICProductNo", "Mã nguyên liệu"));
                repositoryItemLookupEdit.Columns.Add(new LookUpColumnInfo("ICProductName", "Tên nguyên liệu"));
                repositoryItemLookupEdit.Columns.Add(new LookUpColumnInfo("ICProductDesc", "Mô tả"));
                repositoryItemLookupEdit.Columns.Add(new LookUpColumnInfo("ICProductCode", "Mã Code"));
                repositoryItemLookupEdit.DataSource = BOSApp.CurrentProductList.ToList();
                repositoryItemLookupEdit.BestFitMode = BestFitMode.BestFitResizePopup;
                repositoryItemLookupEdit.MaxLength = 1000;
                repositoryItemLookupEdit.QueryPopUp += RepositoryItemLookupEdit_QueryPopUp;
                column.ColumnEdit = repositoryItemLookupEdit;
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICProductConversionItemPerimeter"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICProductConversionItemHeightMin"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICProductConversionItemWidthMin"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICProductConversionItemWidthMax"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICProductConversionItemLengthMax"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICProductConversionItemProductLength"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
            }
            column = gridView.Columns["ICProductConversionItemProductWidth"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
            }
            column = gridView.Columns["ICProductConversionItemProductHeight"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
            }
            column = gridView.Columns["ICProductConversionItemWoodQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n0}";
            }
            column = gridView.Columns["ICProductConversionItemLengthMin"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.OptionsView.ShowFooter = true;
            gridView.CustomColumnDisplayText += GridView_CustomColumnDisplayText;
            return gridView;
        }

        private void GridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    int productID = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", productID, "ICProductNo");
                }
                else
                    e.DisplayText = "";
            }
        }

        private void RepositoryItemLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            lookUpEdit.Properties.DataSource = ((ProductConversionModule)Screen.Module).GetProductDataSourceByProductType();
            lookUpEdit.Properties.DisplayMember = "ICProductNo";
            lookUpEdit.Properties.ValueMember = "ICProductID";
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
            else if (e.Column.FieldName == "ICProductConversionItemProductSerialNo"
                || e.Column.FieldName == "FK_ICStockID")
            {
                ((ProductConversionModule)Screen.Module).ChangeItemProductUnitCost(item);
                ((ProductConversionModule)Screen.Module).UpdateLotNoItem(item);
                ((ProductConversionModule)Screen.Module).ChangeProductConversionItem(entity.ProductConversionItemsList);
            }
            else if (e.Column.FieldName == "FK_ICProductID")
            {
                ((ProductConversionModule)Screen.Module).ChangeSourceProduct(item);
            }
            else if (e.Column.FieldName == "ICProductConversionItemProductLength"
                   || e.Column.FieldName == "ICProductConversionItemProductHeight"
                   || e.Column.FieldName == "ICProductConversionItemProductWidth"
                   || e.Column.FieldName == "ICProductConversionItemWoodQty")
            {
                ((ProductConversionModule)Screen.Module).CalculatedProductConversionItemQtyByPackageVolumnConfig();
            }
            else if (e.Column.FieldName == "ICProductConversionItemSplitQty" 
                    || e.Column.FieldName == "ICProductConversionItemSplitRate")
            {
                ((ProductConversionModule)Screen.Module).CalculatedProductConversionItemWoodQtyBySplitQtyAndRate();
            }    
            ((ProductConversionModule)Screen.Module).ChangeProductConversionItem(entity.ProductConversionItemsList);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ProductConversionModule)Screen.Module).DeleteProductSourceItemList();
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

        public void LoadGridView(string productConversionType)
        {
            GridView gridView = (GridView)MainView;
            if (productConversionType == ProductConversionType.ManyTarget.ToString())
            {
                GridColumn column = gridView.Columns["ICProductConversionItemCost"];
                if (column != null)
                {
                    column.Visible = true;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                {
                    column = new GridColumn();
                    column.Caption = "Phí chuyển mã";
                    column.FieldName = "ICProductConversionItemCost";
                    column.Visible = true;
                    column.OptionsColumn.AllowEdit = true;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n2}";
                    gridView.Columns.Add(column);
                }

                column = gridView.Columns["ICProductConversionItemTotalFeeCost"];
                if (column != null)
                {
                    column.Visible = true;
                    column.OptionsColumn.AllowEdit = false;
                }
                else
                {
                    column = new GridColumn();
                    column.Caption = "Tổng phí chuyển mã";
                    column.FieldName = "ICProductConversionItemTotalFeeCost";
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = true;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n2}";
                    gridView.Columns.Add(column);
                }
                column = gridView.Columns["ICProductConversionItemSplitQty"];
                if (column != null)
                {
                    gridView.Columns.Remove(column);
                }
                column = gridView.Columns["ICProductConversionItemSplitRate"];
                if (column != null)
                {
                    gridView.Columns.Remove(column);
                }
                column = gridView.Columns["ICProductConversionItemSimilarSerialNo"];
                if (column != null)
                {
                    gridView.Columns.Remove(column);
                }
            }
            else
            {
                GridColumn column = gridView.Columns["ICProductConversionItemCost"];
                if (column != null)
                {
                    gridView.Columns.Remove(column);
                }
                column = gridView.Columns["ICProductConversionItemTotalFeeCost"];
                if (column != null)
                {
                    gridView.Columns.Remove(column);
                }
                column = gridView.Columns["ICProductConversionItemSplitQty"];
                if (column != null)
                {
                    column.Visible = true;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                {
                    column = new GridColumn();
                    column.Caption = "Số lượng cần cắt tách";
                    column.FieldName = "ICProductConversionItemSplitQty";
                    column.OptionsColumn.AllowEdit = true;
                    column.Visible = true;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n2}";
                    gridView.Columns.Add(column);
                }

                column = gridView.Columns["ICProductConversionItemSplitRate"];
                if (column != null)
                {
                    column.Visible = true;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                {
                    column = new GridColumn();
                    column.Caption = "Hệ số cắt tách";
                    column.FieldName = "ICProductConversionItemSplitRate";
                    column.OptionsColumn.AllowEdit = true;
                    column.Visible = true;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n2}";
                    gridView.Columns.Add(column);
                }
                column = gridView.Columns["ICProductConversionItemSimilarSerialNo"];
                if (column != null)
                {
                    column.Visible = true;
                    column.OptionsColumn.AllowEdit = true;
                }    
                else
                {
                    column = new GridColumn();
                    column.Caption = "Mã lô tương tự";
                    column.FieldName = "ICProductConversionItemSimilarSerialNo";
                    column.OptionsColumn.AllowEdit = true;
                    column.Visible = true;
                    gridView.Columns.Add(column);

                    RepositoryItemHyperLinkEdit rpItemSimilarSerialNo = new RepositoryItemHyperLinkEdit();
                    rpItemSimilarSerialNo.NullText = "Mã lô tương tự";
                    rpItemSimilarSerialNo.Click += new EventHandler(RpItemSimilarSerialNo_Click);
                    column.ColumnEdit = rpItemSimilarSerialNo;
                    gridView.Columns.Add(column);
                }

            }
        }
        private void RpItemSimilarSerialNo_Click(object sender, EventArgs e)
        {
            ((ProductConversionModule)Screen.Module).ShowItemSimilarSerialNo();
        }
    }
}
