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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace BOSERP.Modules.PurchaseOrder
{
    public partial class APPurchaseOrderItemsGridControl : BOSGridControl
    {
        private List<MMOperationsInfo> OperationDataSource = new List<MMOperationsInfo>();
        public override void InitGridControlDataSource()
        {
            PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.PurchaseOrderItemList;
            this.DataSource = bds;

            MMOperationsController objOperationsController = new MMOperationsController();
            DataSet ds = BOSApp.LookupTables[TableName.MMOperationsTableName] as DataSet;
            if (ds == null)
            {
                ds = BOSApp.GetLookupTableData(TableName.MMOperationsTableName);
            }
            OperationDataSource = (List<MMOperationsInfo>)objOperationsController.GetListFromDataSet(ds);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.KeyUp += new KeyEventHandler(gridView_KeyUp);
            gridView.CellValueChanging += GridView_CellValueChanging;
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            GridColumn column = gridView.Columns["APPurchaseOrderItemProductQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APPurchaseOrderItemQty2"];
            if (column != null)
            {
                column.Visible = false;
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["APPurchaseOrderItemProductUnitCost"];
            if (column != null)
            {
                RepositoryItemButtonEdit buttonEdit = InitColumnRepositoryItemButtonEdit();
                column.ColumnEdit = buttonEdit;
                InitColumnRepositoryFormat(column, TableName.APPurchaseOrderItemsTableName, "APPurchaseOrderItemProductUnitCost");
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APPurchaseOrderItemProductDiscount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APPurchaseOrderItemProductTaxPercent"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APPurchaseOrderItemDeliveryDate"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APPurchaseOrderItemType"];
            if (column != null)
            {
                RepositoryItemLookUpEdit rep = InitRepositoryForConfigValues(ADConfigValueUtility.ConfigValues.Tables[ConfigValueGroup.PurchaseOrderType + "Search"]);
                column.ColumnEdit = rep;
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["APPurchaseOrderItemUnitVolumn"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APPurchaseOrderItemComment"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["APPurchaseOrderItemProductDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APPurchaseOrderItemProductionNormItemTotalPaint"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.Visible = false;
            }
            column = gridView.Columns["APPurchaseOrderItemProductionNormItemTotalBlocks"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.Visible = false;
            }
            column = gridView.Columns["FK_ICProductAttributeTTMTID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICProductAttributeQualityID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICProductAttributeWoodTypeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryAttributeWood = new RepositoryItemLookUpEdit();
                repositoryAttributeWood.DisplayMember = "ICProductAttributeValue";
                repositoryAttributeWood.ValueMember = "ICProductAttributeID";
                repositoryAttributeWood.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryAttributeWood.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                List<ICProductAttributesInfo> list = (new ICProductAttributesController()).GetProductAttributeValueByWoodType();
                repositoryAttributeWood.DataSource = list;
                repositoryAttributeWood.NullText = string.Empty;
                repositoryAttributeWood.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Loại gỗ"));
                repositoryAttributeWood.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryAttributeWood_QueryPopUp);
                column.ColumnEdit = repositoryAttributeWood;
            }

            column = gridView.Columns["FK_ICModelID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            //[NKVung]  [Fillter Model Detail By Model] [START]
            column = gridView.Columns["FK_ICModelDetailID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICModelDetailsName";
                repositoryItemLookUpEdit.ValueMember = "ICModelDetailID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICModelDetailsName", PurchaseOrderLocalizedResources.ICModelDetailsName));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditModelDetail_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridView.Columns["APPurchaseOrderItemProductUnitCostTam"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.DisplayFormat.FormatType = FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
            }
            column = gridView.Columns["APPurchaseOrderItemTotalCostTam"];
            if (column != null)
            {
                column.DisplayFormat.FormatType = FormatType.Numeric;
                column.DisplayFormat.FormatString = "{0:n2}";
            }

            column = gridView.Columns["APPurchaseOrderItemProductLenght"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["APPurchaseOrderItemProductWidth"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["APPurchaseOrderItemHasProductPackage"];
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

            column = gridView.Columns["APPurchaseOrderItemProductFactor"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["FK_ARSaleOrderID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACCostCenterID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APPurchaseOrderItemOperation"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemCheckedComboBoxEdit operationRepositoryItem = new RepositoryItemCheckedComboBoxEdit();
                operationRepositoryItem.DisplayMember = "MMOperationName";
                operationRepositoryItem.ValueMember = "MMOperationID";
                operationRepositoryItem.NullText = string.Empty;
                operationRepositoryItem.DataSource = OperationDataSource;
                operationRepositoryItem.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpOperationName_QueryPopUp);
                column.ColumnEdit = operationRepositoryItem;
            }
            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICProductOrigin"];
            if (column != null)
            {
                //column.OptionsColumn.AllowEdit = true;
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["APPurchaseOrderItemProductPerimeter"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APPurchaseOrderItemProductHeight"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APPurchaseOrderItemWoodQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APPurchaseOrderItemProductLenghtMin"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APPurchaseOrderItemProductWidthMin"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APPurchaseOrderItemProductLenghtMax"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["APPurchaseOrderItemProductWidthMax"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        private void GridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                {
                    PurchaseOrderEntities entity = (PurchaseOrderEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                    APPurchaseOrderItemsInfo item = (APPurchaseOrderItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    item.FK_ICMeasureUnitBeforeChangeID = item.FK_ICMeasureUnitID;
                    GeneralHelper.ChangePurchaseItemMeasureUnitID(item, int.Parse(e.Value.ToString()));
                }
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn newColumn = new GridColumn();
            newColumn.Caption = "Xuất xứ";
            newColumn.FieldName = "FK_GECountryID";
            newColumn.OptionsColumn.AllowEdit = true;
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            DataSet ds = BOSApp.LookupTables["GECountrys"] as DataSet;
            if (ds == null)
            {
                ds = BOSApp.GetLookupTableData("GECountrys");
                BOSApp.LookupTables["GECountrys"] = ds;
            }
            repositoryItemLookUpEdit.DataSource = ds.Tables[0];
            repositoryItemLookUpEdit.DisplayMember = "GECountryName";
            repositoryItemLookUpEdit.ValueMember = "GECountryID";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("GECountryName", "Xuất xứ"));
            repositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditGECountry_QueryPopUp);
            newColumn.ColumnEdit = repositoryItemLookUpEdit;
            gridView.Columns.Add(newColumn);

            newColumn = new GridColumn();
            newColumn.Caption = "SL tồn kho";
            newColumn.FieldName = "ICInventoryStockQty";
            STFieldFormatGroupsInfo formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("APPurchaseOrderItems", "APPurchaseOrderItemProductQty", this.Screen.Module.ModuleID);
            if (formatsInfo != null)
            {
                newColumn.DisplayFormat.FormatType = BOSUtil.GetFormatTypeFromText(formatsInfo.STFieldFormatGroupFormatType);
                newColumn.DisplayFormat.FormatString = formatsInfo.STFieldFormatGroupFormatString;
            }
            gridView.Columns.Add(newColumn);

            newColumn = new GridColumn();
            newColumn.Caption = "ĐMH gần nhất";
            newColumn.FieldName = "APPurchaseOrderNo";
            newColumn.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(newColumn);

            newColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            newColumn.Caption = "Mã đơn hàng nội bộ";
            newColumn.FieldName = "MMBatchProductSOName";
            newColumn.OptionsColumn.AllowEdit = false;
            newColumn.Visible = true;
            gridView.Columns.Add(newColumn);
        }

        protected void repositoryItemLookUpEditGECountry_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            DataSet ds = BOSApp.LookupTables["GECountrys"] as DataSet;
            if (ds == null)
            {
                ds = BOSApp.GetLookupTableData("GECountrys");
            }
            lke.Properties.DataSource = ds.Tables[0];
        }

        private void gridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ((PurchaseOrderModule)Screen.Module).DeleteItemFromPurchaseOrderItemsList();
            }
        }

        public void repositoryItemLookUpEditModelDetail_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            PurchaseOrderEntities entity = (PurchaseOrderEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            APPurchaseOrderItemsInfo item = (APPurchaseOrderItemsInfo)entity.PurchaseOrderItemList[entity.PurchaseOrderItemList.CurrentIndex];
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICModelDetailsController objModelDetailsController = new ICModelDetailsController();
            List<ICModelDetailsInfo> ModelDetailsList = new List<ICModelDetailsInfo>();
            ICModelDetailsInfo objModelDetailsInfo = new ICModelDetailsInfo();
            objModelDetailsInfo.ICModelDetailID = 0;
            if (item != null)
            {
                ModelDetailsList = objModelDetailsController.GetModelDetailByModelID(item.FK_ICModelID);
            }
            if (ModelDetailsList != null)
            {
                if (ModelDetailsList.Count > 0)
                {
                    ModelDetailsList.Insert(0, objModelDetailsInfo);
                }
                lookUpEdit.Properties.DataSource = ModelDetailsList;
            }
            lookUpEdit.Properties.DisplayMember = "ICModelDetailsName";
            lookUpEdit.Properties.ValueMember = "ICModelDetailID";
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            PurchaseOrderEntities entity = (PurchaseOrderEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            APPurchaseOrdersInfo objPurchaseOrdersInfo = (APPurchaseOrdersInfo)entity.MainObject;
            APPurchaseOrderItemsInfo item = entity.PurchaseOrderItemList[entity.PurchaseOrderItemList.CurrentIndex];
            if (item == null)
                return;

            BOSDbUtil dbUtil = new BOSDbUtil();
            if (e.Column.FieldName == "FK_ICModelID")
            {
                ((PurchaseOrderModule)Screen.Module).ResetModelDetail(item);
            }
            if (e.Column.FieldName == "APPurchaseOrderItemOperation"
                || e.Column.FieldName == "APPurchaseOrderItemProductFactor"
                || e.Column.FieldName == "APPurchaseOrderItemProductQty"
                || e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                if (!((PurchaseOrderModule)Screen.Module).IsValidPurchaseQty(item, e.Column.FieldName))
                {
                    dbUtil.SetPropertyValue(item, e.Column.FieldName, gridView.ActiveEditor.OldEditValue);
                    gridView.ActiveEditor.EditValue = gridView.ActiveEditor.OldEditValue;
                    gridView.RefreshData();
                    return;
                }
                item.APPurchaseOrderItemProductExchangeQty = item.APPurchaseOrderItemProductQty * item.APPurchaseOrderItemProductFactor;
                if (objPurchaseOrdersInfo.APPurchaseOrderReceiptTypeCombo == PurchaseOrderReceiptType.IngredientPaint.ToString())
                    item.APPurchaseOrderItemProductExchangeQty = Math.Round(item.APPurchaseOrderItemProductExchangeQty, 5, MidpointRounding.AwayFromZero);
                else
                    item.APPurchaseOrderItemProductExchangeQty = Math.Round(item.APPurchaseOrderItemProductExchangeQty, 3, MidpointRounding.AwayFromZero);
                item.APPurchaseOrderItemRemainedQty = item.APPurchaseOrderItemProductQty - item.APPurchaseOrderItemProductCanceledQty - item.APPurchaseOrderItemReceiptedQty;
                gridView.RefreshData();
            }
            if (e.Column.FieldName == "APPurchaseOrderItemProductDiscount" || e.Column.FieldName == "APPurchaseOrderItemProductTaxPercent")
            {
                ((PurchaseOrderModule)Screen.Module).UpdateTotalCost();
            }
            if ((e.Column.FieldName == "APPurchaseOrderItemProductLenght" || e.Column.FieldName == "APPurchaseOrderItemProductWidth")
                && item.APPurchaseOrderItemProductType == ProductType.Glasses.ToString())
            {
                item.APPurchaseOrderItemProductQty = item.APPurchaseOrderItemProductLenght * item.APPurchaseOrderItemProductWidth * Convert.ToDecimal(Math.Pow(10, -6));
            }
            if (e.Column.FieldName == "APPurchaseOrderItemProductUnitCost")
            {
                ((PurchaseOrderModule)Screen.Module).ChangePaymentTimeAmount(objPurchaseOrdersInfo.FK_GEPaymentTermID);
            }
            if (e.Column.FieldName == "APPurchaseOrderItemProductUnitCostTam" || e.Column.FieldName == "APPurchaseOrderItemWoodQty")
            {
                ((PurchaseOrderModule)Screen.Module).UpdateTotalCostTam(item);
            }
            decimal unitChangeCost = 0;
            if (e.Column.FieldName == "APPurchaseOrderItemProductUnitCost" && item != null )
            {
                entity.PurchaseOrderItemList[entity.PurchaseOrderItemList.CurrentIndex].APPurchaseOrderItemProductUnitCost = Math.Abs(decimal.Parse(e.Value.ToString()));
                unitChangeCost = Math.Abs(decimal.Parse(e.Value.ToString()));
            }
            
            ((PurchaseOrderModule)Screen.Module).ChangePurchaseOrderItem(item, unitChangeCost);
            ((PurchaseOrderModule)Screen.Module).CheckPaymentTimeAmount();
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {

            if (e.Column.FieldName == "FK_ICModelDetailID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICModelDetails", "ICModelDetailID", matchCodeID, "ICModelDetailsName");
                }
                else
                    e.DisplayText = "";
            }
            if (e.Column.FieldName == "FK_ICProductEquipmentID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", matchCodeID, "ICProductDesc");
                }
                else
                    e.DisplayText = "";
            }
            if (e.Column.FieldName == "APPurchaseOrderItemOperation")
            {
                if (e.Value != null)
                {
                    e.DisplayText = GetOperationDisplayText(e.Value.ToString());
                }
            }
            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", matchCodeID, "ICProductNo");
                }
                else
                    e.DisplayText = "";
            }
        }
        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.F1)
            {
                ShowInventory();
            }
        }

        public RepositoryItemButtonEdit InitColumnRepositoryItemButtonEdit()
        {
            RepositoryItemButtonEdit rep = new RepositoryItemButtonEdit();
            rep.ButtonClick += new ButtonPressedEventHandler(ShowFormCompareProductUnitCost);
            return rep;
        }

        private void ShowFormCompareProductUnitCost(object sender, ButtonPressedEventArgs e)
        {
            ((PurchaseOrderModule)Screen.Module).ShowFormCompareProductUnitCost();
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
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
                int modelID = dbUtil.GetPropertyIntValue(item, "FK_ICModelID");
                int modelDetailID = dbUtil.GetPropertyIntValue(item, "FK_ICModelDetailID");
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */
                ((BaseModuleERP)Screen.Module).ShowInventory(productID, desc, modelID, modelDetailID);
            }
        }

        public void LoadGridViewForRoundWood(string productType)
        {
            GridView gridView = (GridView)MainView;

            GridColumn column = gridView.Columns["APPurchaseOrderItemWoodQty"];
            if (column != null && column.FieldName == "APPurchaseOrderItemWoodQty")
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Lumber.ToString() || productType == ProductType.Verneer.ToString()
                    || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.Visible = true;
                    column.OptionsColumn.AllowEdit = true;
                    column.VisibleIndex = 7;
                }
                else
                    column.Visible = false;
            }
            column = gridView.Columns["APPurchaseOrderItemProductHeight"];
            if (column != null && column.FieldName == "APPurchaseOrderItemProductHeight")
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Lumber.ToString() || productType == ProductType.Verneer.ToString()
                    || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 8;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                    column.Visible = false;
            }
            column = gridView.Columns["APPurchaseOrderItemProductWidth"];
            if (column != null && column.FieldName == "APPurchaseOrderItemProductWidth")
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Lumber.ToString() || productType == ProductType.Verneer.ToString()
                    || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 9;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                    column.Visible = false;
            }
            column = gridView.Columns["APPurchaseOrderItemProductWidthMax"];
            if (column != null && column.FieldName == "APPurchaseOrderItemProductWidthMax")
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Lumber.ToString() || productType == ProductType.Verneer.ToString()
                    || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 10;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                    column.Visible = false;
            }
            column = gridView.Columns["APPurchaseOrderItemProductLenght"];
            if (column != null && column.FieldName == "APPurchaseOrderItemProductLenght")
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 11;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                    column.Visible = false;
            }
            column = gridView.Columns["APPurchaseOrderItemProductLenghtMax"];
            if (column != null && column.FieldName == "APPurchaseOrderItemProductLenghtMax")
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Lumber.ToString() || productType == ProductType.Verneer.ToString()
                    || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 12;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                    column.Visible = false;
            }
            column = gridView.Columns["APPurchaseOrderItemProductPerimeter"];
            if (column != null && column.FieldName == "APPurchaseOrderItemProductPerimeter")
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Roundwood.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 10;
                    column.OptionsColumn.AllowEdit = true;
                }
                else
                    column.Visible = false;
            }
            column = gridView.Columns["APPurchaseOrderItemProductQty"];
            if (column != null && column.FieldName == "APPurchaseOrderItemProductQty")
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    if (productType == ProductType.Verneer.ToString())
                    {
                        column.Caption = PurchaseOrderLocalizedResources.VerneerM2;
                    }
                    //else
                    //{
                    //    column.Caption = "Khối lượng (m3)";
                    //}
                    column.Visible = true;
                    column.VisibleIndex = 5;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
                else if (productType == ProductType.IngredientPaint.ToString())
                {
                    column.Caption = "Số lượng";
                    column.Visible = true;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n5}";
                }
                else
                {
                    column.Caption = "Số lượng";
                    column.Visible = true;
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                }
            }
            column = gridView.Columns["APPurchaseOrderItemReceiptedQty"];
            if (column != null && column.FieldName == "APPurchaseOrderItemReceiptedQty")
            {
                column.OptionsColumn.AllowEdit = false;
                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString())
                {
                    column.Caption = "Khối lượng đã nhận";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
                else if (productType == ProductType.IngredientPaint.ToString())
                {
                    column.Caption = "Số lượng đã nhận";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n5}";
                }
                else
                {
                    column.Caption = "Số lượng đã nhận";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                }
            }
            column = gridView.Columns["APPurchaseOrderItemPackagedQty"];
            if (column != null && column.FieldName == "APPurchaseOrderItemPackagedQty")
            {
                column.Visible = false;
                column.OptionsColumn.AllowEdit = false;
                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString())
                {
                    column.Visible = false;
                    column.Caption = "Khối lượng đóng hàng";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
                else if (productType == ProductType.IngredientPaint.ToString())
                {
                    column.Caption = "Số lượng đóng hàng";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n5}";
                    column.Visible = false;
                }
                else
                {
                    column.Caption = "Số lượng đóng hàng";
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                    column.Visible = false;
                }
            }
            if (column != null && column.FieldName == "APPurchaseOrderItemProductExchangeQty")
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString()
                    || productType == ProductType.Verneer.ToString() || productType == ProductType.ArtificialBoard.ToString())
                {
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n4}";
                }
                else if (productType == ProductType.IngredientPaint.ToString())
                {
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n5}";
                }
                else
                {
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n3}";
                }
            }
            column = gridView.Columns["APPurchaseOrderItemQty2"];
            if (column != null && column.FieldName == "APPurchaseOrderItemQty2")
            {
                column.OptionsColumn.AllowEdit = false;
                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString())
                {
                    column.Visible = false;
                    column.VisibleIndex = 10;
                }
                else
                    column.Visible = false;
            }

            column = gridView.Columns["FK_ICProductAttributeWoodTypeID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.Visible = false;
            }
            column = gridView.Columns["FK_ICProductAttributeTTMTID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 3;
                }
                else
                    column.Visible = false;
            }
            column = gridView.Columns["FK_ICProductAttributeQualityID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 4;
                }
                else
                    column.Visible = false;
            }
            column = gridView.Columns["FK_ICMeasureUnitID"];
            if (column != null)
            {
                if (productType == ProductType.Roundwood.ToString() || productType == ProductType.Lumber.ToString())
                {
                    column.Visible = true;
                    column.VisibleIndex = 5;
                }
            }
            column = gridView.Columns["FK_GECountryID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;

                column.Visible = true;

            }
            column = gridView.Columns["APPurchaseOrderItemProductionNormItemTotalPaint"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.Visible = false;
            }
            column = gridView.Columns["APPurchaseOrderItemProductionNormItemTotalBlocks"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.Visible = false;
            }

            if (productType == ProductType.Service.ToString())
            {
                column = gridView.Columns["FK_ICProductEquipmentID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                    column.Visible = true;
                }

                column = gridView.Columns["APPurchaseOrderItemServiceToDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                    column.Caption = "Đến ngày";
                    column.Visible = true;
                }

                column = gridView.Columns["FK_ACAssetID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                    column.Visible = true;
                }

                column = gridView.Columns["APPurchaseOrderItemServiceFromDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = true;
                    column.Caption = "Từ ngày";
                    column.Visible = true;
                }
            }
            else
            {
                column = gridView.Columns["FK_ICProductEquipmentID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = false;
                }

                column = gridView.Columns["APPurchaseOrderItemServiceToDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = false;
                }

                column = gridView.Columns["FK_ACAssetID"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = false;
                }

                column = gridView.Columns["APPurchaseOrderItemServiceFromDate"];
                if (column != null)
                {
                    column.OptionsColumn.AllowEdit = false;
                    column.Visible = false;
                }
            }
            gridView.BestFitColumns();
        }

        public void LoadGridViewForPurchaseOrderOutSourcing()
        {
            GridView gridView = (GridView)MainView;
            GridColumn column = gridView.Columns["APPurchaseOrderItemProductionNormItemTotalPaint"];
            if (column != null && column.FieldName == "APPurchaseOrderItemProductionNormItemTotalPaint")
            {
                column.Visible = true;
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["APPurchaseOrderItemProductionNormItemTotalBlocks"];
            if (column != null && column.FieldName == "APPurchaseOrderItemProductionNormItemTotalBlocks")
            {
                column.Visible = true;
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["APPurchaseOrderItemUnitVolumn"];
            if (column != null && column.FieldName == "APPurchaseOrderItemUnitVolumn")
            {
                column.Visible = true;
                column.OptionsColumn.AllowEdit = false;
            }

            gridView.BestFitColumns();
        }

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            APPurchaseOrderItemsInfo item = (APPurchaseOrderItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
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
            APPurchaseOrderItemsInfo item = (APPurchaseOrderItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "APPurchaseOrderItemProductFactor")
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

        private string GetOperationDisplayText(string operationRef)
        {
            if (string.IsNullOrWhiteSpace(operationRef))
                return string.Empty;

            List<int> operation = operationRef.Split(',').Select(o => Int32.Parse(o)).ToList();
            return string.Join(", ", OperationDataSource.Where(o => operation.Contains(o.MMOperationID)).Select(o => o.MMOperationName).ToArray());
        }

        private void rpOperationName_QueryPopUp(object sender, CancelEventArgs e)
        {
            CheckedComboBoxEdit lke = (CheckedComboBoxEdit)sender;
            if (lke == null)
                return;

            GridView gridView = (GridView)MainView;
            APPurchaseOrderItemsInfo item = (APPurchaseOrderItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item == null)
                item = new APPurchaseOrderItemsInfo();

            lke.Properties.DataSource = ((PurchaseOrderModule)Screen.Module).GetOperationDataSourceOfSemiProduct(item.FK_APProposalItemID);
            lke.Properties.DisplayMember = "MMOperationName";
            lke.Properties.ValueMember = "MMOperationID";
        }

        private void repositoryAttributeWood_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductAttributesInfo> list = (new ICProductAttributesController()).GetProductAttributeValueByWoodType();
            lookUpEdit.Properties.DataSource = list;
        }

        protected override void GridView_Click(object sender, EventArgs e)
        {
            base.GridView_Click(sender, e);
            PurchaseOrderEntities entity = (PurchaseOrderEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.PurchaseOrderItemList.CurrentIndex >= 0)
            {
                ((PurchaseOrderModule)Screen.Module).InitProductPictureImage(entity.PurchaseOrderItemList[entity.PurchaseOrderItemList.CurrentIndex].FK_ICProductID);
            }
        }

        private void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle < 0)
                return;

            APPurchaseOrderItemsInfo item = (APPurchaseOrderItemsInfo)gridView.GetRow(e.RowHandle);
            if (e.Column.FieldName == "ICInventoryStockQty" && e.CellValue != null)
            {
                if (item.IsCheckInventory)
                {
                    if (item.APPurchaseOrderItemProductQty > item.ICInventoryStockQty)
                    {
                        e.Appearance.BackColor = Color.DarkOrange;
                        e.Appearance.BackColor2 = Color.DarkOrange;
                    }
                    else
                    {
                        e.Appearance.BackColor = Color.Green;
                        e.Appearance.BackColor2 = Color.Green;
                    }
                }
            }
        }
    }
}
