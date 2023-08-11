using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using BOSCommon;
using DevExpress.Utils;

namespace BOSERP.Modules.Receipt
{
    public class ICReceiptItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            ReceiptEntities entity = (ReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ReceiptItemsList;
            this.DataSource = bds;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            ReceiptEntities entity = (ReceiptEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ReceiptItemsList.CurrentIndex >= 0)
            {
                GridView gridView = (GridView)sender;
                ICReceiptItemsInfo item = (ICReceiptItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (e.Column.FieldName == "ICReceiptItemProductSerialNo")
                {
                    ((ReceiptModule)Screen.Module).ChangeItemSerieNo(item);
                }
                #region Validate capacity
                if (e.Column.FieldName == "ICReceiptItemProductQty")
                    if (item.FK_MMOperationDetailPlanCapacityItemID > 0 && !((ReceiptModule)Screen.Module).CheckCapacityQty(item))
                    {
                        item.ICReceiptItemProductQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                        return;
                    }
                if (e.Column.FieldName == "FK_ICProductID")
                {
                    ICProductsInfo product = BOSApp.GetProductFromCurrentProductList(item.FK_ICProductID);
                    if (product != null)
                    {
                        item.ICReceiptItemProductName = product.ICProductName;
                        item.ICReceiptItemProductDesc = product.ICProductDesc;
                        item.FK_ICMeasureUnitID = product.FK_ICProductBasicUnitID;
                    }
                }
                #endregion
                if (e.Column.FieldName == "FK_ICImportAndExportReasonID")
                {
                    ((ReceiptModule)Screen.Module).ChangeItemImportAndExportReason(item);
                }
                else
                {
                    if (e.Column.FieldName == "ICReceiptItemProductQty")
                    {
                        ((ReceiptModule)Screen.Module).CalculatedTotalWoodQtyByPackageVolumnConfig();
                    }

                    entity.ModuleObjects[TableName.ICReceiptItemsTableName] = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex].Clone();
                    ((ReceiptModule)Screen.Module).ChangeItemFromReceiptItemsList();
                }
                if(e.Column.FieldName == "ICReceiptItemProductLength"
                    || e.Column.FieldName == "ICReceiptItemProductHeight"
                    || e.Column.FieldName == "ICReceiptItemProductWidth"
                    || e.Column.FieldName == "ICReceiptItemWoodQty")
                {
                    ((ReceiptModule)Screen.Module).CalculatedProductQtyByPackageVolumnConfig();
                }    
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((ReceiptModule)Screen.Module).DeleteItemFromReceiptItemsList();
            }
            else if (e.KeyCode == Keys.F1)
            {
                ShowInventory();
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CellValueChanging += GridView_CellValueChanging;
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);

            if (gridView.Columns["ICReceiptItemProductQty"] != null)
            {
                gridView.Columns["ICReceiptItemProductQty"].OptionsColumn.AllowEdit = true;
                gridView.Columns["ICReceiptItemProductQty"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView.Columns["ICReceiptItemProductQty"].DisplayFormat.FormatString = "{0:n3}";
            }

            if (gridView.Columns["ICReceiptItemProductUnitCost"] != null)
                gridView.Columns["ICReceiptItemProductUnitCost"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["FK_ICStockID"] != null)
                gridView.Columns["FK_ICStockID"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["FK_ICImportAndExportReasonID"] != null)
                gridView.Columns["FK_ICImportAndExportReasonID"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["ICReceiptItemProductDesc"] != null)
                gridView.Columns["ICReceiptItemProductDesc"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["FK_ACAccountID"] != null)
                gridView.Columns["FK_ACAccountID"].OptionsColumn.AllowEdit = true;

            GridColumn column = gridView.Columns["ICReceiptItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Caption = CommonLocalizedResources.SerialNoText;
            }

            column = gridView.Columns["ICReceiptItemLotNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Caption = CommonLocalizedResources.LotNoText;
            }

            column = gridView.Columns["ICReceiptItemHasProductPackage"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICReceiptItemIsAverageCalculation"];
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

            column = gridView.Columns["ICReceiptItemProductFactor"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICReceiptStatus"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["ICReceiptItemProductDiscount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemProductTaxPercent"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemProductLength"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemProductPerimeter"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICProductAttributeQualityID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICProductAttributeTTMTID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_GECountryID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemWidthMax"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemLenghtMax"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemWidthMin"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemLenghtMin"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemProductWidth"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }    
            gridView.OptionsView.ShowFooter = true;
            InitColumnSummary("ICReceiptItemTotalCost", DevExpress.Data.SummaryItemType.Sum);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID")
            {
                int value = 0;
                if (e.Value != null && int.TryParse(e.Value.ToString(), out value))
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", value, "ICProductNo");
            }
        }


        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ShowInventory();
        }

        /// <summary>
        /// Show inventory details of the current item
        /// </summary>
        private void ShowInventory()
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                BusinessObject item = (BusinessObject)gridView.GetRow(gridView.FocusedRowHandle);
                BOSDbUtil dbUtil = new BOSDbUtil();
                int productID = dbUtil.GetPropertyIntValue(item, "FK_ICProductID");
                string itemTableName = BOSUtil.GetTableNameFromBusinessObject(item);
                String columnName = String.Empty;
                columnName = itemTableName.Substring(0, itemTableName.Length - 1) + "ProductDesc";
                string desc = dbUtil.GetPropertyStringValue(item, columnName);
                int modelID = dbUtil.GetPropertyIntValue(item, "FK_ICModelID");
                int modelDetailID = dbUtil.GetPropertyIntValue(item, "FK_ICModelDetailID");
                ((BaseTransactionModule)Screen.Module).ShowInventory(productID, desc, modelID, modelDetailID);
            }
        }

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            ICReceiptItemsInfo item = (ICReceiptItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "ICReceiptItemProductFactor")
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

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICReceiptItemsInfo item = (ICReceiptItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
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
        private void GridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                {
                    ReceiptEntities entity = (ReceiptEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                    ICReceiptItemsInfo item = (ICReceiptItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    item.FK_ICMeasureUnitBeforeChangeID = item.FK_ICMeasureUnitID;
                    GeneralHelper.ChangePurchaseItemMeasureUnitID(item, int.Parse(e.Value.ToString()));
                }
            }
        }

        protected override void GridView_Click(object sender, EventArgs e)
        {
            base.GridView_Click(sender, e);
            ReceiptEntities entity = (ReceiptEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.ReceiptItemsList.CurrentIndex >= 0)
            {
                ((ReceiptModule)Screen.Module).InitProductPictureImage(entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex].FK_ICProductID);
            }
        }
        private void FormatNumbericColumn(GridColumn column, bool allowEdit, string formatType)
        {
            RepositoryItemTextEdit repositoryItemTextEdit = new RepositoryItemTextEdit()
            {
                Mask =
                {
                    MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric,
                    EditMask = formatType,
                    UseMaskAsDisplayFormat = true
                }
            };
            repositoryItemTextEdit.DisplayFormat.FormatType = FormatType.Numeric;
            repositoryItemTextEdit.DisplayFormat.FormatString = formatType;
            column.OptionsColumn.AllowEdit = allowEdit;
            column.ColumnEdit = repositoryItemTextEdit;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
        }
    }
}
