using System;
using BOSCommon.Constants;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Data;
using System.Windows.Forms;
using BOSLib;
using System.ComponentModel;
using System.Collections.Generic;

namespace BOSERP.Modules.Shipment
{
    public class ICShipmentItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            ShipmentEntities entity = (ShipmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ShipmentItemList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CellValueChanging += GridView_CellValueChanging;
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            GridColumn column = gridView.Columns["ICShipmentItemProductQty"];
            if (column != null)
            {
                STFieldFormatGroupsInfo formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ICShipmentItems", "ICShipmentItemProductQty", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(column, true, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            column = gridView.Columns["ICShipmentItemProductUnitPrice"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["ICShipmentItemTotalAmount"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["ICShipmentItemProductSerialNo"];
            if (column != null)
            {
                column.Caption = CommonLocalizedResources.SerialNoText;
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemLotNo"];
            if (column != null)
            {
                column.Caption = CommonLocalizedResources.LotNoText;
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ACUnfinishedConstructionCostID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                ACUnfinishedConstructionCostsController unController = new ACUnfinishedConstructionCostsController();
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ACUnfinishedConstructionCostName";
                repositoryItemLookUpEdit.ValueMember = "ACUnfinishedConstructionCostID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                DataSet ds = BOSApp.LookupTables[TableName.ACUnfinishedConstructionCostsTableName] as DataSet;
                if (ds == null)
                {
                    ACUnfinishedConstructionCostsController objUnfinishedConstructionCostsController = new ACUnfinishedConstructionCostsController();
                    repositoryItemLookUpEdit.DataSource = objUnfinishedConstructionCostsController.GetAllObjects();
                }
                else
                {
                    repositoryItemLookUpEdit.DataSource = ds.Tables[0];
                }
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACUnfinishedConstructionCostNo", "Mã chi phí"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACUnfinishedConstructionCostName", "Tên chi phí"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryItemLookUpEditUnfinishedConstructionCost_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridView.Columns["ICShipmentItemProductDesc"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["ICShipmentItemHasProductPackage"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["FK_ICImportAndExportReasonID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemIsSpecificCalculation"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemProductFactor"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["FK_ACSegmentID"];
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
            gridView.OptionsView.ShowFooter = true;
            InitColumnSummary("ICShipmentItemTotalAmount", DevExpress.Data.SummaryItemType.Sum);
            return gridView;
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
            }
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

        protected void repositoryItemLookUpEditUnfinishedConstructionCost_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            ACUnfinishedConstructionCostsController unController = new ACUnfinishedConstructionCostsController();
            List<ACUnfinishedConstructionCostsInfo> coList = unController.GetDataForLookupEditControl();
            List<ACUnfinishedConstructionCostsInfo> coListFinal = new List<ACUnfinishedConstructionCostsInfo>();
            coListFinal.Add(new ACUnfinishedConstructionCostsInfo());
            coListFinal.AddRange(coList);
            lookUpEdit.Properties.DataSource = coListFinal;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (e.Column.FieldName == "ICShipmentItemProductSerialNo"
                            || e.Column.FieldName == "ICShipmentItemLotNo")
                {
                    ((ShipmentModule)Screen.Module).ChangeItemSerieNo(item);
                    if (e.Column.FieldName == "ICShipmentItemProductSerialNo")
                    {
                        ((ShipmentModule)Screen.Module).UpdateLotNoItem(item);
                        gridView.RefreshData();
                    }
                    //((ShipmentModule)Screen.Module).CalculatedProductQtyByPackageVolumnConfig();
                }
                else if (e.Column.FieldName == "ICShipmentItemIsSpecificCalculation")
                {
                    ((ShipmentModule)Screen.Module).ChangeItemSerieNo(item);
                }
                else if (e.Column.FieldName == "FK_ICStockID")
                {
                    ((ShipmentModule)Screen.Module).SelectSeriesNoDefault(item);
                    ((ShipmentModule)Screen.Module).ChangeItemSerieNo(item);
                }
                //else if (e.Column.FieldName == "FK_ICMeasureUnitID")
                //{
                //    ((ShipmentModule)Screen.Module).ChangeItemMeasureUnit(item);
                //}

                else if (e.Column.FieldName == "FK_ICImportAndExportReasonID")
                {
                    ((ShipmentModule)Screen.Module).ChangeItemImportAndExportReason(item);
                }
                else if (e.Column.FieldName == "ICShipmentItemLength"
                        || e.Column.FieldName == "ICShipmentItemHeight"
                        || e.Column.FieldName == "ICShipmentItemWidth"
                        || e.Column.FieldName == "ICShipmentItemWoodQty")
                {
                    ((ShipmentModule)Screen.Module).CalculatedProductQtyByPackageVolumnConfig();
                    ((ShipmentModule)Screen.Module).ChangeItemSerieNo(item);
                }
                else if (e.Column.FieldName == "ICShipmentItemProductQty")
                {
                    ShipmentEntities entity = (ShipmentEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
                    entity.ModuleObjects[TableName.ICShipmentItemsTableName] = (ICShipmentItemsInfo)item.Clone();
                    ((ShipmentModule)Screen.Module).CalculatedWoodQtyByPackageVolumnConfig();
                    ((ShipmentModule)Screen.Module).ChangeItemFromShipmentItemsList();
                }
                else
                {
                    ShipmentEntities entity = (ShipmentEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
                    entity.ModuleObjects[TableName.ICShipmentItemsTableName] = (ICShipmentItemsInfo)item.Clone();
                    ((ShipmentModule)Screen.Module).ChangeItemFromShipmentItemsList();
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((ShipmentModule)Screen.Module).DeleteItemFromShipmentItemsList();
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

        private void GridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                {
                    ShipmentEntities entity = (ShipmentEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                    ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    item.FK_ICMeasureUnitBeforeChangeID = item.FK_ICMeasureUnitID;
                    GeneralHelper.ChangeShipmenttemMeasureUnitID(item, int.Parse(e.Value.ToString()));
                }
            }
        }

        protected override void GridView_Click(object sender, EventArgs e)
        {
            base.GridView_Click(sender, e);
            ShipmentEntities entity = (ShipmentEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;

            if (entity.ShipmentItemList.CurrentIndex >= 0)
            {
                ((ShipmentModule)Screen.Module).InitProductPictureImage(entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex].FK_ICProductID);
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ACUnfinishedConstructionCostID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ACUnfinishedConstructionCosts", "ACUnfinishedConstructionCostID", int.Parse(e.Value.ToString()), "ACUnfinishedConstructionCostName");
                }
            }
        }
    }
}
