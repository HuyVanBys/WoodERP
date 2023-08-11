using BOSCommon.Constants;
using BOSERP.Modules.IC.BatchShipmentDryLumber.Localization;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchShipmentDryLumber
{
    public class BatchShipmentDryLumbersGridControl : ItemGridControl
    {
        List<MMBatchProductItemsInfo> BatchitemList;
        public override void InitGridControlDataSource()
        {
            BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ShipmentItemList;
            this.DataSource = bds;
            BatchitemList = new List<MMBatchProductItemsInfo>();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn columnedit in gridView.Columns)
            {
                columnedit.OptionsColumn.AllowEdit = false;
            }
            GridColumn column = gridView.Columns["ICShipmentItemProductQty"];
            if (column != null)
            {
                column.Caption = BatchShipmentDryLumberLocalizedResources.ICShipmentItemProductQty;
                FormatNumbericColumn(column, false, "n6");
            }
            column = gridView.Columns["ICShipmentItemLengthMax"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICShipmentItemLengthMin"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICShipmentItemWidthMax"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICShipmentItemWidthMin"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICShipmentItemHeightMax"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICShipmentItemHeightMin"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICShipmentItemPerimeter"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICShipmentItemPerimeterMax"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICShipmentItemPerimeterMin"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICShipmentItemProductUnitPrice"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["ICShipmentItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.Caption = BatchShipmentDryLumberLocalizedResources.FK_ICProductSerieID;
            }
            column = gridView.Columns["FK_ICProductAttributeQualityID"];
            if (column != null)
            {
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));

                List<ICProductAttributesInfo> productAttributesList = ((BatchShipmentDryLumberModule)Screen.Module).GetProductItemAttributeQuality();
                repositoryItemLookUpEdit.DataSource = productAttributesList;

                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemAttributeQualityLookupEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridView.Columns["FK_ICProductAttributeWoodTypeID"];
            if (column != null)
            {
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));

                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemAttributeWoodTypeLookupEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridView.Columns["FK_ICProductForBatchID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICShipmentItemBatchProductItemProductSerial"];
            if (column != null)
            {
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "MMBatchProductItemProductSerial";
                repositoryItemLookUpEdit.ValueMember = "MMBatchProductItemID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMBatchProductItemProductSerial", "Mã lô SX"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMBatchProductItemProductNo", "Mã sản phẩm"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMBatchProductItemProductDesc", "Mô tả"));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(BatchProductItemProductSerial_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridView.Columns["ICShipmentItemIsSpecificCalculation"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemProductFactor"];
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
            column = gridView.Columns["ICShipmentItemTotalAmount"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["ICShipmentItemComment"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            //gridView.OptionsView.ShowFooter = true;
            //InitColumnSummary("ICShipmentItemProductQty", DevExpress.Data.SummaryItemType.Sum);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);

            return gridView;
        }

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
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

        private void BatchProductItemProductSerial_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                LookUpEdit lookUpEdit = (LookUpEdit)sender;
                BatchitemList = ((BatchShipmentDryLumberModule)Screen.Module).GetBatchProductItemSerialDataSource(item);
                lookUpEdit.Properties.DataSource = BatchitemList;
            }
        }

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (e.Value != null)
            {
                if (gridView.FocusedColumn.FieldName == "ICShipmentItemProductFactor")
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
                if (gridView.FocusedColumn.FieldName == "ICShipmentItemProductQty")
                {
                    if (!string.IsNullOrEmpty(e.Value.ToString()))
                    {
                        decimal itemExQty = Convert.ToDecimal(e.Value) * (item.ICShipmentItemProductFactor == 0 ? 1 : item.ICShipmentItemProductFactor);
                        if (new ICShipmentItemsController().IsValidQuantyForBatchShipmentDryLumber(itemExQty, item.FK_MMAllocationPlanItemID, item.Id))
                            return;
                        e.ErrorText = BatchShipmentDryLumberLocalizedResources.ShipmentQtyCannotBiggerThanAllocationQty;
                        e.Valid = false;
                    }
                }
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID" && e.Value != null)
            {
                e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", Int32.Parse(e.Value.ToString()), "ICProductNo");
            }

            if (e.Column.FieldName == "ICShipmentItemBatchProductItemProductSerial")
            {
                if (e.Value != null)
                    e.DisplayText = e.Value.ToString();
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = "Tên SP tiếng việt";
            column.FieldName = "ICShipmentItemProductName2";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Dài BTP";
            column.FieldName = "MMBatchProductProductionNormItemProductLength";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Rộng BTP";
            column.FieldName = "MMBatchProductProductionNormItemProductWidth";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Dày BTP";
            column.FieldName = "MMBatchProductProductionNormItemProductHeight";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã đơn hàng nội bộ";
            column.FieldName = "ICShipmentItemSOName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!((BatchShipmentDryLumberModule)Screen.Module).Toolbar.IsNullOrNoneAction())
            {
                base.GridView_CellValueChanged(sender, e);
                GridView gridView = (GridView)sender;
                if (gridView.FocusedRowHandle >= 0)
                {
                    ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (e.Column.FieldName == "ICShipmentItemProductSerialNo")
                    {
                        ((BatchShipmentDryLumberModule)Screen.Module).ChangeItemlist(item);
                        ((BatchShipmentDryLumberModule)Screen.Module).ChangeItemSerieNo(item);
                        ((BatchShipmentDryLumberModule)Screen.Module).CalculatedProductQtyByPackageVolumnConfig();
                    }
                    else if (e.Column.FieldName == "FK_ICStockID")
                    {
                        ((BatchShipmentDryLumberModule)Screen.Module).SelectSeriesNoDefault(item);
                        ((BatchShipmentDryLumberModule)Screen.Module).ChangeItemSerieNo(item);
                    }
                    else if (e.Column.FieldName == "FK_ICMeasureUnitID")
                    {
                        ((BatchShipmentDryLumberModule)Screen.Module).ChangeItemMeasureUnit(item);
                    }
                    else if (e.Column.FieldName == "FK_ACAccountID")
                    {
                        ((BatchShipmentDryLumberModule)Screen.Module).UpdateDocument();
                    }
                    else if (e.Column.FieldName == "ICShipmentItemBatchProductItemProductSerial")
                    {
                        if (item.FK_MMBatchProductProductionNormItemID > 0 && BatchitemList.Count() > 0)
                        {
                            MMBatchProductItemsInfo batchItemInfo = BatchitemList.Where(o => o.MMBatchProductItemID == item.FK_MMBatchProductItemID).FirstOrDefault();
                            if (batchItemInfo != null)
                            {
                                item.ICShipmentItemBatchProductItemProductSerial = batchItemInfo.MMBatchProductItemProductSerial;
                            }
                            return;
                        }
                        else
                        {
                            int BatchitemID = 0;
                            int.TryParse(e.Value.ToString(), out BatchitemID);
                            if (BatchitemID > 0)
                            {
                                MMBatchProductItemsInfo batchItemInfo = BatchitemList.Where(o => o.MMBatchProductItemID == BatchitemID).FirstOrDefault();
                                if (batchItemInfo != null)
                                {
                                    item.FK_MMBatchProductItemID = BatchitemID;
                                    item.ICShipmentItemBatchProductItemProductSerial = batchItemInfo.MMBatchProductItemProductSerial;
                                    item.FK_ICProductForBatchID = batchItemInfo.FK_ICProductID;
                                }
                            }
                        }
                    }
                    else if (e.Column.FieldName == "FK_MMBatchProductID" || e.Column.FieldName == "FK_MMOperationID")
                    {
                        if (item.FK_MMBatchProductProductionNormItemID > 0)
                        {
                            int oldID = 0;
                            int.TryParse(gridView.ActiveEditor.OldEditValue.ToString(), out oldID);
                            if (e.Column.FieldName == "FK_MMBatchProductID")
                                item.FK_MMBatchProductID = oldID;
                            else
                                item.FK_MMOperationID = oldID;
                            return;
                        }
                        else if (e.Column.FieldName == "FK_MMOperationID")
                        {
                            ((BatchShipmentDryLumberModule)Screen.Module).CheckItemOperationReceive(item);
                        }
                    }
                    else
                    {
                        BatchShipmentDryLumberEntities entity = (BatchShipmentDryLumberEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
                        entity.ModuleObjects[TableName.ICShipmentItemsTableName] = (ICShipmentItemsInfo)item.Clone();
                        ((BatchShipmentDryLumberModule)Screen.Module).ChangeItemFromShipmentItemsList();
                    }
                    if (e.Column.FieldName == "ICShipmentItemLength"
                       || e.Column.FieldName == "ICShipmentItemHeight"
                       || e.Column.FieldName == "ICShipmentItemWidth"
                       || e.Column.FieldName == "ICShipmentItemWoodQty")
                    {
                        ((BatchShipmentDryLumberModule)Screen.Module).CalculatedProductQtyByPackageVolumnConfig();
                    }
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((BatchShipmentDryLumberModule)Screen.Module).DeleteItemFromShipmentItemsList();
            }
        }

        void repositoryItemAttributeQualityLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductAttributesInfo> productAttributesList = ((BatchShipmentDryLumberModule)Screen.Module).GetProductItemAttributeQuality();
            lookUpEdit.Properties.DataSource = productAttributesList;
        }

        void repositoryItemAttributeWoodTypeLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductAttributesInfo> productAttributesList = ((BatchShipmentDryLumberModule)Screen.Module).GetProductItemAttributeWoodType();
            lookUpEdit.Properties.DataSource = productAttributesList;
        }

        void repositoryItemAttributeTTMTLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductAttributesInfo> productAttributesList = ((BatchShipmentDryLumberModule)Screen.Module).GetProductItemAttributeTTMT();
            lookUpEdit.Properties.DataSource = productAttributesList;
        }

        private void FormatNumbericColumn(GridColumn column, bool allowEdit, string formatType)
        {
            column.OptionsColumn.AllowEdit = true;
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

        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "FK_MMOperationID")
                {
                    ICShipmentItemsInfo obj = (ICShipmentItemsInfo)gridView.GetRow(e.RowHandle);
                    if (obj != null && obj.IsError)
                    {
                        e.Appearance.BackColor = Color.Red;
                        e.Appearance.BackColor2 = Color.Red;
                    }

                }
            }
        }
    }
}
