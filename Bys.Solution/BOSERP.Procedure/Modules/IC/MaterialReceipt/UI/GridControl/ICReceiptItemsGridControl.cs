using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.MaterialReceipt
{
    public class ICReceiptItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            MaterialReceiptEntities entity = (MaterialReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ReceiptItemsList;
            this.DataSource = bds;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            MaterialReceiptEntities entity = (MaterialReceiptEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.ReceiptItemsList.CurrentIndex >= 0)
            {
                GridView gridView = (GridView)sender;
                ICReceiptItemsInfo item = (ICReceiptItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (e.Column.FieldName == "ICReceiptItemProductSerialNo")
                {
                    ((MaterialReceiptModule)Screen.Module).ChangeItemSerieNo(item);
                }
                else
                if (e.Column.FieldName == "FK_ICStockID")
                {
                    ((MaterialReceiptModule)Screen.Module).ChangeStockInItem(item);
                    entity.ModuleObjects[TableName.ICReceiptItemsTableName] = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex].Clone();
                    ((MaterialReceiptModule)Screen.Module).ChangeItemFromReceiptItemsList();
                }
                if (e.Column.FieldName == "FK_ICMeasureUnitID")
                {
                    ((MaterialReceiptModule)Screen.Module).ChangeItemMeasureUnit(item);
                }
                else
                {
                    if (e.Column.FieldName == "ICReceiptItemProductLength"
                     || e.Column.FieldName == "ICReceiptItemProductHeight"
                     || e.Column.FieldName == "ICReceiptItemProductWidth"
                     || e.Column.FieldName == "ICReceiptItemWoodQty")
                    {
                        ((MaterialReceiptModule)Screen.Module).CalculatedProductQtyByPackageVolumnConfig();
                    }
                    entity.ModuleObjects[TableName.ICReceiptItemsTableName] = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex].Clone();
                    ((MaterialReceiptModule)Screen.Module).ChangeItemFromReceiptItemsList();
                }
              
                if (e.Column.FieldName == "ICReceiptItemProductQty")
                {
                    ((MaterialReceiptModule)Screen.Module).CalculatedTotalWoodQtyByPackageVolumnConfig();
                    entity.ModuleObjects[TableName.ICReceiptItemsTableName] = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex].Clone();
                    ((MaterialReceiptModule)Screen.Module).ChangeItemFromReceiptItemsList();
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((MaterialReceiptModule)Screen.Module).DeleteItemFromReceiptItemsList();
            }
            else if (e.KeyCode == Keys.F1)
            {
                ShowInventory();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Mã phiếu xuất";
            column.FieldName = "FK_ICShipmentID";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã đơn hàng nội địa";
            column.FieldName = "ICRêciptItemSOName";
            column.Visible = true;
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn gridColumn = gridView.Columns["ICReceiptItemWoodQty"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = false;
                gridColumn.Visible = false;
            }

            gridColumn = gridView.Columns["ICReceiptItemComment"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["ICReceiptItemProductLength"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["ICReceiptItemProductHeight"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["ICReceiptItemProductWidth"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["ICReceiptItemLenghtMax"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["ICReceiptItemHeightMax"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["ICReceiptItemWidthMax"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["ICReceiptItemProductWith"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["FK_ICStockID"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["ICReceiptItemProductPerimeter"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["ICReceiptItemProductQty"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
                gridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridColumn.DisplayFormat.FormatString = "{0:n6}";
            }
            gridColumn = gridView.Columns["ICReceiptItemProductExchangeQty"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
                gridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridColumn.DisplayFormat.FormatString = "{0:n5}";
            }
            gridColumn = gridView.Columns["ICReceiptItemContainerNo"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["ICReceiptItemProductDesc"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["ICReceiptItemProductUnitCost"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["FK_MMWorkShopID"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["ICReceiptItemProductSerialNo"];
            if (gridColumn != null)
            {
                gridColumn.Caption = WoodPurchaseReceiptLocalizedResources.LotNoCaption;
                gridColumn.OptionsColumn.AllowEdit = true;
                //column.VisibleIndex = 4;
            }
            gridColumn = gridView.Columns["ICReceiptItemLotNo"];
            if (gridColumn != null)
            {
                gridColumn.Visible = true;
                gridColumn.Caption = WoodPurchaseReceiptLocalizedResources.LotNo;
                gridColumn.OptionsColumn.AllowEdit = true;
                //column.VisibleIndex = 1;
            }
            gridView.OptionsView.ShowFooter = true;
            InitColumnSummary("ICReceiptItemTotalCost", DevExpress.Data.SummaryItemType.Sum);

            gridColumn = gridView.Columns["FK_ICProductAttributeQualityID"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["FK_ICProductAttributeWoodTypeID"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                //repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ADConfigText", "Mã"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));

                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemAttributeWoodTypeLookupEdit_QueryPopUp);
                gridColumn.ColumnEdit = repositoryItemLookUpEdit;
            }
            gridColumn = gridView.Columns["FK_GECountryID"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["ICReceiptItemIsAverageCalculation"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }

            gridColumn = gridView.Columns["FK_ICMeasureUnitID"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit rpMeasureUnit = new RepositoryItemLookUpEdit();
                rpMeasureUnit.DisplayMember = "ICMeasureUnitName";
                rpMeasureUnit.ValueMember = "ICMeasureUnitID";
                rpMeasureUnit.NullText = string.Empty;
                rpMeasureUnit.Columns.Add(new LookUpColumnInfo("ICMeasureUnitName", "ĐVT"));
                DataSet ds = BOSApp.LookupTables[TableName.ICMeasureUnitsTableName] as DataSet;
                rpMeasureUnit.DataSource = ds.Tables[0];
                rpMeasureUnit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpMeasureUnitt_QueryPopUp);
                gridColumn.ColumnEdit = rpMeasureUnit;
            }
            gridColumn = gridView.Columns["ICReceiptItemProductFactor"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = false;
            }

            gridColumn = gridView.Columns["FK_MMBatchProductID"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ShowInventory();
        }

        void repositoryItemAttributeWoodTypeLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductAttributesInfo> productAttributesList = ((MaterialReceiptModule)Screen.Module).GetProductItemAttributeWoodType();
            lookUpEdit.Properties.DataSource = productAttributesList;
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
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
                int modelID = dbUtil.GetPropertyIntValue(item, "FK_ICModelID");
                int modelDetailID = dbUtil.GetPropertyIntValue(item, "FK_ICModelDetailID");
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */
                ((BaseTransactionModule)Screen.Module).ShowInventory(productID, desc, modelID, modelDetailID);
            }
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            ICProductsInfo objProductsInfo = new ICProductsInfo();
            ICProductsController objProductsController = new ICProductsController();
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    int value = 0;
                    if (int.TryParse(e.Value.ToString(), out value))
                    {
                        objProductsInfo = BOSApp.GetProductFromCurrentProductList(value);
                        if (objProductsInfo != null)
                        {
                            e.DisplayText = objProductsInfo.ICProductNo;
                        }
                        else
                        {
                            e.DisplayText = "";
                        }
                    }
                }
                else
                {
                    e.DisplayText = "";
                }
            }
            if (e.Column.FieldName == "FK_ICShipmentID")
            {
                if (e.Value != null)
                {
                    int id = e.Value == null || e.Value == DBNull.Value ? 0 : Convert.ToInt32(e.Value);
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICShipments", "ICShipmentID", id, "ICShipmentNo");
                }
                else
                {
                    e.DisplayText = "";
                }
            }

        }

        public void LoadGridview(string receiptTypeCombo)
        {
            GridView gridView = (GridView)MainView;

            if (gridView.Columns["ICReceiptItemWoodQty"] != null)
            {
                gridView.Columns["ICReceiptItemWoodQty"].OptionsColumn.AllowEdit = false;
                gridView.Columns["ICReceiptItemWoodQty"].Visible = false;
            }
            if (gridView.Columns["ICReceiptItemComment"] != null)
                gridView.Columns["ICReceiptItemComment"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemProductLength"] != null)
                gridView.Columns["ICReceiptItemProductLength"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemProductHeight"] != null)
                gridView.Columns["ICReceiptItemProductHeight"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemProductWidth"] != null)
                gridView.Columns["ICReceiptItemProductWidth"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemLenghtMax"] != null)
                gridView.Columns["ICReceiptItemLenghtMax"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemHeightMax"] != null)
                gridView.Columns["ICReceiptItemHeightMax"].Visible = false;

            if (gridView.Columns["ICReceiptItemWidthMax"] != null)
                gridView.Columns["ICReceiptItemWidthMax"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemProductWith"] != null)
                gridView.Columns["ICReceiptItemProductWith"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["FK_ICStockID"] != null)
                gridView.Columns["FK_ICStockID"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemProductPerimeter"] != null)
                gridView.Columns["ICReceiptItemProductPerimeter"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemProductQty"] != null)
            {
                gridView.Columns["ICReceiptItemProductQty"].OptionsColumn.AllowEdit = true;
                gridView.Columns["ICReceiptItemProductQty"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView.Columns["ICReceiptItemProductQty"].DisplayFormat.FormatString = "{0:n6}";
            }

            if (gridView.Columns["ICReceiptItemContainerNo"] != null)
                gridView.Columns["ICReceiptItemContainerNo"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemProductDesc"] != null)
                gridView.Columns["ICReceiptItemProductDesc"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemProductUnitCost"] != null)
                gridView.Columns["ICReceiptItemProductUnitCost"].OptionsColumn.AllowEdit = true;
            if (gridView.Columns["FK_ACAccountID"] != null)
                gridView.Columns["FK_ACAccountID"].OptionsColumn.AllowEdit = true;

            GridColumn column = gridView.Columns["ICReceiptItemProductSerialNo"];
            if (column != null)
            {
                column.Caption = WoodPurchaseReceiptLocalizedResources.LotNoCaption;
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICReceiptItemLotNo"];
            if (column != null)
            {
                column.Visible = true;
                column.Caption = WoodPurchaseReceiptLocalizedResources.LotNo;
                column.OptionsColumn.AllowEdit = true;
            }
            gridView.OptionsView.ShowFooter = true;
            InitColumnSummary("ICReceiptItemTotalCost", DevExpress.Data.SummaryItemType.Sum);

            column = gridView.Columns["FK_ICProductAttributeQualityID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICProductAttributeWoodTypeID"];
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

            if (receiptTypeCombo == ReceiptType.MaterialReceipt.ToString())
            {
                column = gridView.Columns["FK_ICModelID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                }

                column = gridView.Columns["FK_ICModelDetailID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                }
            }
            else
            {
                column = gridView.Columns["FK_ICModelID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                }

                column = gridView.Columns["FK_ICModelDetailID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
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

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            MaterialReceiptEntities entity = (MaterialReceiptEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ICReceiptsInfo mainObject = (ICReceiptsInfo)entity.MainObject;
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
                if (gridView.FocusedColumn.FieldName == "ICReceiptItemProductQty"
                    && mainObject.STToolbarActionName.Equals("NewFromMaterialShipment"))
                {
                    //decimal itemExQty = Convert.ToDecimal(e.Value) * (item.ICReceiptItemProductFactor == 0 ? 1 : item.ICReceiptItemProductFactor);
                    //if (new ICShipmentItemsController().IsValidQuantyForMaterialReceipt(item.FK_ICShipmentItemID, itemExQty, item.Id))
                    //    return;

                    //e.ErrorText = MaterialReceiptLocalizedResources.TheReceiptQtyCannotBiggerThanShipmentQty;
                    //e.Valid = false;
                }
            }
        }
    }
}
