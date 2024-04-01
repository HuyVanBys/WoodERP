using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.SemiProductReceipt
{
    public class ICReceiptItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SemiProductReceiptEntities entity = (SemiProductReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ReceiptItemsList;
            this.DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "MMOperationDetailPlanCapacityItemCanSync";
            column.Caption = "SL đồng bộ tối đa";
            column.Visible = true;
            column.OptionsColumn.AllowEdit = false;
            STFieldFormatGroupsInfo formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ICReceiptItems", "ICReceiptItemProductQty", this.Screen.Module.ModuleID);
            if (formatsInfo != null)
            {
                column.DisplayFormat.FormatType = BOSUtil.GetFormatTypeFromText(formatsInfo.STFieldFormatGroupFormatType);
                column.DisplayFormat.FormatString = formatsInfo.STFieldFormatGroupFormatString;
            }
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICReceiptItemSOName";
            column.Caption = "Mã đơn hàng nội bộ";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "FK_MMUpdatePositionItemID";
            column.Caption = "Vị trí";
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemLookUpEdit rep = new RepositoryItemLookUpEdit();
            rep.ValueMember = "MMUpdatePositionItemID";
            rep.DisplayMember = "MMUpdatePositionItemPositionName";
            rep.NullText = String.Empty;
            rep.TextEditStyle = TextEditStyles.Standard;
            rep.SearchMode = SearchMode.AutoFilter;
            rep.Columns.Add(new LookUpColumnInfo("MMUpdatePositionItemPositionName", "Vị trí"));
            rep.QueryPopUp += new System.ComponentModel.CancelEventHandler(rep_QueryPopUp);
            gridView.Columns.Add(column);
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            SemiProductReceiptEntities entity = (SemiProductReceiptEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ICReceiptsInfo mainObject = (ICReceiptsInfo)entity.MainObject;
            MMOperationsController objOperationsController = new MMOperationsController();
            MMOperationsInfo objOperationsInfo = (MMOperationsInfo)objOperationsController.GetObjectByID(mainObject.FK_MMOperationID);
            if (entity.ReceiptItemsList.CurrentIndex >= 0)
            {
                GridView gridView = (GridView)sender;
                ICReceiptItemsInfo item = (ICReceiptItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (item != null) { item.IsError = false; item.IsError1 = false; }
                if (e.Column.FieldName == "ICReceiptItemProductSerialNo")
                {
                    bool isvalid = true;
                    if (objOperationsInfo != null)
                    {
                        if (objOperationsInfo.MMOperationNo == OperationNo.Thanhpham.ToString())
                        {
                            isvalid = false;
                            item.ICReceiptItemProductSerialNo = gridView.ActiveEditor.OldEditValue.ToString();
                        }
                    }
                    if (isvalid)
                        ((SemiProductReceiptModule)Screen.Module).ChangeItemSerieNo(item);
                }
                if (e.Column.FieldName == "FK_ICMeasureUnitID")
                {
                    ((SemiProductReceiptModule)Screen.Module).ChangeItemMeasureUnit(item);
                }
                else
                {
                    bool isValid = true;
                    if (e.Column.FieldName == "ICReceiptItemProductQty")
                    {
                        if (!((SemiProductReceiptModule)Screen.Module).CheckValidQuantity(decimal.Parse(e.Value.ToString())))
                        {
                            item.ICReceiptItemProductQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                            return;
                        }
                        if (item.ICReceiptItemHasProductPackage)
                        {
                            BOSApp.ShowMessage(string.Format("Chi tiết thuộc kiện {0}, bạn không thể thay đổi!", item.ICReceiptItemLotNo));
                            item.ICReceiptItemProductQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                            return;
                        }
                        #region Validate capacity
                        if (item.FK_MMOperationDetailPlanCapacityItemID > 0 && !((SemiProductReceiptModule)Screen.Module).CheckCapacityQty(item))
                        {
                            isValid = false;
                            item.ICReceiptItemProductQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                            return;
                        }
                        #endregion
                        item.ICReceiptItemProductExchangeQty = item.ICReceiptItemProductQty * item.ICReceiptItemProductFactor;
                    }

                    if (isValid)
                    {
                        entity.ModuleObjects[TableName.ICReceiptItemsTableName] = (ICReceiptItemsInfo)entity.ReceiptItemsList[entity.ReceiptItemsList.CurrentIndex].Clone();
                        ((SemiProductReceiptModule)Screen.Module).ChangeItemFromReceiptItemsList();
                    }
                }
                if (e.Column.FieldName == "ICReceiptItemHasProductPackage")
                {
                    // ((SemiProductReceiptModule)Screen.Module).ChangeHasProductPackage();
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                GridView gridView = this.MainView as GridView;
                ICReceiptItemsInfo item = (ICReceiptItemsInfo)gridView.GetFocusedRow();
                if (item != null && item.ICReceiptItemHasProductPackage)
                {
                    if (BOSApp.ShowMessageYesNo(string.Join("Chi tiết thuộc kiện {0}, bạn muốn xoá kiện này không?", item.ICReceiptItemLotNo)) == DialogResult.Yes)
                    {
                        ((SemiProductReceiptModule)Screen.Module).DeleteItemPackage(item.ICReceiptItemLotNo);
                    }
                }
                else
                    ((SemiProductReceiptModule)Screen.Module).DeleteItemFromReceiptItemsList();
            }
            else if (e.KeyCode == Keys.F1)
            {
                ShowInventory();
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);

            if (gridView.Columns["ICReceiptItemProductQty"] != null)
            {
                STFieldFormatGroupsInfo formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ICReceiptItems", "ICReceiptItemProductQty", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(gridView.Columns["ICReceiptItemProductQty"], true, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            if (gridView.Columns["ICReceiptItemProductQty"] != null)
            {
                gridView.Columns["ICReceiptItemProductQty"].OptionsColumn.AllowEdit = true;
                gridView.Columns["ICReceiptItemProductQty"].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns["ICReceiptItemProductQty"].DisplayFormat.FormatString = "n6";
            }

            if (gridView.Columns["ICReceiptItemProductUnitCost"] != null)
                gridView.Columns["ICReceiptItemProductUnitCost"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["FK_ICStockID"] != null)
                gridView.Columns["FK_ICStockID"].OptionsColumn.AllowEdit = true;

            if (gridView.Columns["ICReceiptItemBPProductionNormItemQty"] != null)
                gridView.Columns["ICReceiptItemBPProductionNormItemQty"].OptionsColumn.AllowEdit = false;
            if (gridView.Columns["FK_ACAccountID"] != null)
                gridView.Columns["FK_ACAccountID"].OptionsColumn.AllowEdit = true;

            GridColumn column = gridView.Columns["ICReceiptItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            // TNDLoc [ADD][04/03/2016][SL => KL] ,START
            column = gridView.Columns["ICReceiptItemWoodQty"];
            if (column != null)
            {
                column.Caption = SemiProductReceiptLocalizedResources.ICReceiptItemProductQty;
                column.OptionsColumn.AllowEdit = true;
            }
            // TNDLoc [ADD][04/03/2016][SL => KL] ,END
            column = gridView.Columns["ICReceiptItemComment"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICReceiptItemProductPackageQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
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
                if (ds != null)
                    rpMeasureUnit.DataSource = ds.Tables[0];
                rpMeasureUnit.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpMeasureUnitt_QueryPopUp);
                column.ColumnEdit = rpMeasureUnit;

            }

            column = gridView.Columns["ICReceiptItemProductFactor"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["MMOperationDetailPlanCapacityItemCanSync"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemHyperLinkEdit buttonEdit = new RepositoryItemHyperLinkEdit();
                buttonEdit.NullText = "Xem";
                buttonEdit.Click += new EventHandler(ButtonEdit_ButtonClick);
                column.ColumnEdit = buttonEdit;
            }

            column = gridView.Columns["FK_ICImportAndExportReasonID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemLookUpEdit rpImportAndExportReason = new RepositoryItemLookUpEdit();
                rpImportAndExportReason.DisplayMember = "ICImportAndExportReasonName";
                rpImportAndExportReason.ValueMember = "ICImportAndExportReasonID";
                rpImportAndExportReason.NullText = string.Empty;
                rpImportAndExportReason.Columns.Add(new LookUpColumnInfo("ICImportAndExportReasonName", "Lý do nhập xuất"));
                ICImportAndExportReasonsController objImportAndExportReasonsController = new ICImportAndExportReasonsController();
                rpImportAndExportReason.DataSource = objImportAndExportReasonsController.GetListImportAndExportReasonsByType(ImportAndExportReasonType.Import.ToString());
                rpImportAndExportReason.QueryPopUp += new System.ComponentModel.CancelEventHandler(rpImportAndExportReason_QueryPopUp);
                column.ColumnEdit = rpImportAndExportReason;
            }

            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);

            gridView.OptionsView.ShowFooter = true;
            InitColumnSummary("ICReceiptItemTotalCost", DevExpress.Data.SummaryItemType.Sum);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            gridView.PopupMenuShowing += new PopupMenuShowingEventHandler(GridView_PopupMenuShowing);
            return gridView;
        }
        private void GridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.MenuType == GridMenuType.Row)
            {
                DXMenuItem menuItem;
                int rowHandle = e.HitInfo.RowHandle;
                if (e.HitInfo.InDataRow)
                {
                    menuItem = new DXMenuItem("Chuyển mã", new EventHandler(Convert_Click));
                    menuItem.Tag = new RowInfo(gridView, rowHandle);
                    menuItem.BeginGroup = true;
                    e.Menu.Items.Add(menuItem);

                }
            }
        }
        public void Convert_Click(object sender, EventArgs e)
        {
            DXMenuItem menuItem = sender as DXMenuItem;
            if (menuItem == null)
                return;

            GridView gridView = (GridView)MainView;
            RowInfo info = menuItem.Tag as RowInfo;
            ICReceiptItemsInfo item = (ICReceiptItemsInfo)gridView.GetRow(info.RowHandle);
            if (item.Id > 0)
            {
                SemiProductReceiptEntities entity = (SemiProductReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                ICReceiptsInfo objReceiptsInfo = (ICReceiptsInfo)entity.MainObject;
                if (objReceiptsInfo.ICReceiptStatus == Status.Complete.ToString())
                {
                    BaseModuleERP ProductConversion = BaseModuleFactory.GetModule("ProductConversion");
                    if (ProductConversion != null)
                    {
                        ProductConversion = BOSApp.ShowModule("ProductConversion");
                        List<ICReceiptItemsInfo> list = new List<ICReceiptItemsInfo>();
                        list.Add(item);
                        ProductConversion.CallFunctionFromAnotherProject(list, "ActionNewFromSemiProductReceipt");
                    }
                }
                else
                {
                    BOSApp.ShowMessage("Chứng từ chưa duyệt!");
                }
            }
            else
            {
                BOSApp.ShowMessage("Chi tiết chưa lưu!");
            }
        }
        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "MMOperationDetailPlanCapacityItemCanSync")
                {
                    ICReceiptItemsInfo obj = (ICReceiptItemsInfo)gridView.GetRow(e.RowHandle);
                    if (obj != null && obj.IsError)
                    {
                        e.Appearance.BackColor = Color.Red;
                        e.Appearance.BackColor2 = Color.Red;
                    }

                }
                if (e.Column.FieldName == "ICReceiptItemLotNo")
                {
                    ICReceiptItemsInfo obj = (ICReceiptItemsInfo)gridView.GetRow(e.RowHandle);
                    if (obj != null && obj.IsError1)
                    {
                        e.Appearance.BackColor = Color.Red;
                        e.Appearance.BackColor2 = Color.Red;
                    }

                }
                if (e.Column.FieldName == "FK_MMOperationID")
                {
                    ICReceiptItemsInfo obj = (ICReceiptItemsInfo)gridView.GetRow(e.RowHandle);
                    if (obj != null && obj.IsError2)
                    {
                        e.Appearance.BackColor = Color.Red;
                        e.Appearance.BackColor2 = Color.Red;
                    }

                }
            }
        }
        private void ButtonEdit_ButtonClick(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                SemiProductReceiptEntities entity = (SemiProductReceiptEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                ICReceiptsInfo mainObject = (ICReceiptsInfo)entity.MainObject;
                ICReceiptItemsInfo obj = (ICReceiptItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                MMBatchProductProductionNormItemsInfo objBatchProductProductionNormItemsInfo = new MMBatchProductProductionNormItemsInfo();
                if (mainObject.ICReceiptSemiProductType == ReceiptSemiProductType.BatchProduct.ToString()) return; // loại nhập ngoài định mức
                if (obj != null && (obj.FK_MMBatchProductItemID > 0 || obj.FK_MMBatchProductProductionNormItemID > 0))
                {
                    if (obj.FK_MMOperationID == 0 && mainObject.FK_MMOperationID > 0)
                        obj.FK_MMOperationID = mainObject.FK_MMOperationID;
                    if (obj.FK_MMBatchProductItemID == 0 && mainObject.FK_MMBatchProductItemID > 0)
                        obj.FK_MMBatchProductItemID = mainObject.FK_MMBatchProductItemID;
                    MMBatchProductProductionNormItemsController controler = new MMBatchProductProductionNormItemsController();
                    objBatchProductProductionNormItemsInfo
                       = controler.GetItemCanSyncData(obj.FK_MMBatchProductItemID
                                                   , obj.FK_ICProductForBatchID
                                                   , obj.FK_ICProductID
                                                   , obj.FK_MMOperationID
                                                   , obj.FK_MMBatchProductProductionNormItemID
                                                   , obj.Id);

                }
                if (obj != null && objBatchProductProductionNormItemsInfo != null && objBatchProductProductionNormItemsInfo.SyncProductCheck)
                {
                    guiViewSync gui = new guiViewSync();
                    gui.NormID = obj.FK_MMBatchProductProductionNormItemID;
                    gui.OperationID = obj.FK_MMOperationID;
                    gui.PlanQty = obj.ICReceiptItemProductQty;
                    gui.ReceiptItemID = obj.Id;
                    gui.Module = this.Screen.Module;
                    gui.Show();
                    //ICReceiptItemBPProductionNormItemQty : Đã trừ SL nhập khác
                    obj.MMOperationDetailPlanCapacityItemCanSync = Math.Round(gui.SyncPerCent * objBatchProductProductionNormItemsInfo.MMBatchProductProductionNormItemQuantity, 1);
                }
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
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  START */
                int modelID = dbUtil.GetPropertyIntValue(item, "FK_ICModelID");
                int modelDetailID = dbUtil.GetPropertyIntValue(item, "FK_ICModelDetailID");
                /*  TNDLoc : Tồn kho CCDC theo ICModelID, ICModelDetail,  END */
                ((BaseTransactionModule)Screen.Module).ShowInventory(productID, desc, modelID, modelDetailID);
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductAttributeColorID"
                || e.Column.FieldName == "FK_ICProductAttributeWoodTypeID")
            {
                if (e.Value != null)
                {
                    int objectID = 0;
                    Int32.TryParse(e.Value.ToString(), out objectID);
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProductAttributes", "ICProductAttributeID", objectID, "ICProductAttributeNo");
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
        private void rpImportAndExportReason_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ICImportAndExportReasonsController objImportAndExportReasonsController = new ICImportAndExportReasonsController();
            lookUpEdit.Properties.DataSource = objImportAndExportReasonsController.GetListImportAndExportReasonsByType(ImportAndExportReasonType.Import.ToString());
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
        private void rep_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICReceiptsInfo item = (ICReceiptsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (item != null)
            {
                MMUpdatePositionItemsController controller = new MMUpdatePositionItemsController();
                List<MMUpdatePositionItemsInfo> updatePositionItems = controller.GetAllLocationNameByProduct(item.FK_ICProductID, item.FK_ICStockID, 0);
                if (updatePositionItems != null)
                {
                    lookUpEdit.Properties.DataSource = updatePositionItems;
                    lookUpEdit.Properties.DisplayMember = "MMUpdatePositionItemPositionName";
                    lookUpEdit.Properties.ValueMember = "MMUpdatePositionItemID";
                }
            }
        }
    }
}
