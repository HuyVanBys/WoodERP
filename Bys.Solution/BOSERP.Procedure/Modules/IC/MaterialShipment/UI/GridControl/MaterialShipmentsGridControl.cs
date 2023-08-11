using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.MaterialShipment
{

    public class MaterialShipmentsGridControl : ItemGridControl
    {
        List<MMBatchProductItemsInfo> BatchitemList;
        public override void InitGridControlDataSource()
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ShipmentItemList;
            this.DataSource = bds;
            BatchitemList = new List<MMBatchProductItemsInfo>();
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

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);

            foreach (GridColumn columnedit in gridView.Columns)
            {
                columnedit.OptionsColumn.AllowEdit = false;
            }
            GridColumn column = gridView.Columns["ICShipmentItemWoodQty"];
            if (column != null)
            {
                //FormatNumbericColumn(column, false, "n5");
            }
            column = gridView.Columns["ICShipmentItemProductQty"];
            if (column != null)
            {
                //FormatNumbericColumn(column, false, "n6");
            }
            column = gridView.Columns["ICShipmentItemProductExchangeQty"];
            if (column != null)
            {
                //FormatNumbericColumn(column, false, "n6");
            }
            column = gridView.Columns["ICShipmentItemProductUnitPrice"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["FK_ACAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
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
            column = gridView.Columns["FK_ICProductAttributeTTMTID"];
            if (column != null)
            {
                RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
                repositoryItemLookUpEdit.DisplayMember = "ICProductAttributeValue";
                repositoryItemLookUpEdit.ValueMember = "ICProductAttributeID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ICProductAttributeValue", "Đặc tính"));

                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemAttributeTTMTLookupEdit_QueryPopUp);
                column.ColumnEdit = repositoryItemLookUpEdit;
            }
            column = gridView.Columns["FK_ICModelID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
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
            column = gridView.Columns["ICShipmentItemIsSpecificCalculation"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["ICShipmentItemTotalAmount"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
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
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            return gridView;
        }

        public void repositoryItemLookUpEditModelDetail_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ICShipmentItemsInfo item = (ICShipmentItemsInfo)entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex];
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
            column.Caption = "Mã đơn hàng nội bộ";
            column.FieldName = "ICShipmentItemSOName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle < 0)
                return;

            BOSDbUtil dbUtil = new BOSDbUtil();
            MaterialShipmentEntities entity = (MaterialShipmentEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
            ICShipmentsInfo objShipmentsInfo = (ICShipmentsInfo)entity.MainObject;
            ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (e.Column.FieldName == "FK_ICModelID")
            {
                ((MaterialShipmentModule)Screen.Module).ResetModelDetail(item);
            }

            if (e.Column.FieldName == "ICShipmentItemProductFactor"
               || e.Column.FieldName == "ICShipmentItemProductQty"
               || e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                if (((MaterialShipmentModule)Screen.Module).IsValidShipmentQty(item, e.Column.FieldName))
                {
                    item.ICShipmentItemProductExchangeQty = item.ICShipmentItemProductQty * item.ICShipmentItemProductFactor;
                    item.ICShipmentItemProductExchangeQty = Math.Round(item.ICShipmentItemProductExchangeQty, 4, MidpointRounding.AwayFromZero);
                    item.ICShipmentItemProductUnitCost = AccountHelper.GetProductUnitCost(item.FK_ICStockID, item.FK_ICProductID, item.ICShipmentItemProductSerialNo, objShipmentsInfo.ICShipmentDate) * item.ICShipmentItemProductFactor;
                    entity.SetProductPriceByProductUnitPrice(item);
                    gridView.RefreshData();
                    return;
                }
                dbUtil.SetPropertyValue(item, e.Column.FieldName, gridView.ActiveEditor.OldEditValue);
                gridView.ActiveEditor.EditValue = gridView.ActiveEditor.OldEditValue;
                gridView.RefreshData();
            }
            if (e.Column.FieldName == "ICShipmentItemProductSerialNo")
            {
                ((MaterialShipmentModule)Screen.Module).ChangeItemSerieNo(item);
                ((MaterialShipmentModule)Screen.Module).CalculatedProductQtyByPackageVolumnConfig();

            }
            if (e.Column.FieldName == "FK_ICStockID")
            {
                ((MaterialShipmentModule)Screen.Module).SelectSeriesNoDefault(item);
                ((MaterialShipmentModule)Screen.Module).ChangeItemSerieNo(item);
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
                item.IsError = false;
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
                    ((MaterialShipmentModule)Screen.Module).CheckItemOperationReceive(item);
                }
            }
            if (e.Column.FieldName == "ICShipmentItemLength"
                || e.Column.FieldName == "ICShipmentItemHeight"
                || e.Column.FieldName == "ICShipmentItemWidth"
                || e.Column.FieldName == "ICShipmentItemWoodQty")
            {
                ((MaterialShipmentModule)Screen.Module).CalculatedProductQtyByPackageVolumnConfig();
            }
            ((MaterialShipmentModule)Screen.Module).ChangeItemFromShipmentItemsList();
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

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((MaterialShipmentModule)Screen.Module).DeleteItemFromShipmentItemsList();
            }
        }

        private void repositoryItemAttributeQualityLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductAttributesInfo> productAttributesList = ((MaterialShipmentModule)Screen.Module).GetProductItemAttributeQuality();
            lookUpEdit.Properties.DataSource = productAttributesList;
        }

        private void repositoryItemAttributeWoodTypeLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductAttributesInfo> productAttributesList = ((MaterialShipmentModule)Screen.Module).GetProductItemAttributeWoodType();
            lookUpEdit.Properties.DataSource = productAttributesList;
        }

        private void BatchProductItemProductSerial_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                LookUpEdit lookUpEdit = (LookUpEdit)sender;
                BatchitemList = ((MaterialShipmentModule)Screen.Module).GetBatchProductItemSerialDataSource(item);
                lookUpEdit.Properties.DataSource = BatchitemList;
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

        private void repositoryItemAttributeTTMTLookupEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            List<ICProductAttributesInfo> productAttributesList = ((MaterialShipmentModule)Screen.Module).GetProductItemAttributeTTMT();
            lookUpEdit.Properties.DataSource = productAttributesList;
        }

        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductID" && e.Value != null)
            {
                e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", Int32.Parse(e.Value.ToString()), "ICProductNo");
            }
            if (e.Column.FieldName == "FK_ACUnfinishedConstructionCostID")
            {
                if (e.Value != null)
                {
                    int matchCodeID = int.Parse(e.Value.ToString());
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche(TableName.ACUnfinishedConstructionCostsTableName, "ACUnfinishedConstructionCostID", matchCodeID, "ACUnfinishedConstructionCostName");
                }
                else
                    e.DisplayText = "";
            }
            if (e.Column.FieldName == "ICShipmentItemBatchProductItemProductSerial")
            {
                if (e.Value != null)
                    e.DisplayText = e.Value.ToString();
            }
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
