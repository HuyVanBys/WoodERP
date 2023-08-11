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
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.MaterialShipment
{

    public class ICShipmentItemVMsGridControl : ItemGridControl
    {
        List<MMBatchProductItemsInfo> BatchitemList;
        MMAllocationOperationConfigsInfo DefualtAOConfigs { get; set; }
        public override void InitGridControlDataSource()
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.TotalShipmentItemsList;
            this.DataSource = bds;
            BatchitemList = new List<MMBatchProductItemsInfo>();
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            column = new GridColumn();
            column.Caption = BatchShipmentRoundWoodLocalizedResources.AddNewRow;
            column.FieldName = "AddNewRow";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;

            RepositoryItemHyperLinkEdit AddNewRow = new RepositoryItemHyperLinkEdit();
            AddNewRow.NullText = BatchShipmentRoundWoodLocalizedResources.AddNewRow;
            AddNewRow.Click += new EventHandler(AddNewRow_Click);
            column.ColumnEdit = AddNewRow;

            gridView.Columns.Add(column);

            column = new GridColumn();
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

        private void AddNewRow_Click(object sender, EventArgs e)
        {
            MaterialShipmentEntities entity = (MaterialShipmentEntities)(this.Screen.Module as MaterialShipmentModule).CurrentModuleEntity;
            ICShipmentsInfo ShipmentItemsInfo = (ICShipmentsInfo)entity.MainObject;
            if (ShipmentItemsInfo.ICShipmentStatus != ShipmentStatus.Complete.ToString())
            {
                ((MaterialShipmentModule)Screen.Module).ActionEdit();
            }
            ((MaterialShipmentModule)Screen.Module).CopyNewItemVM();
        }

        protected override void GridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            ICShipmentItemVMsInfo item = (ICShipmentItemVMsInfo)gridView.GetRow(gridView.FocusedRowHandle);
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
            GridColumn column = gridView.Columns["ICShipmentItemProductQty"];
            if (column != null)
            {
                STFieldFormatGroupsInfo formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ICShipmentItems", "ICShipmentItemProductQty", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(column, true, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            column = gridView.Columns["ICShipmentItemProductExchangeQty"];
            if (column != null)
            {
                STFieldFormatGroupsInfo formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ICShipmentItems", "ICShipmentItemProductExchangeQty", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(column, false, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            column = gridView.Columns["ICShipmentItemProductUnitCost"];
            if (column != null)
            {
                STFieldFormatGroupsInfo formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("ICShipmentItems", "ICShipmentItemProductUnitCost", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(column, false, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
                column.Caption = BatchShipmentFreshLumberLocalizedResources.MMBatchProductID;
            }
            column = gridView.Columns["ICShipmentItemProductUnitPrice"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
            }
            column = gridView.Columns["ICShipmentItemProductSerialNo"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICStockID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemComment"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_ICProductForBatchID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["FK_MMBatchProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemProductUnitCost"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemBatchProductItemProductSerial"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
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
                column.OptionsColumn.AllowEdit = false;
            }
            column = gridView.Columns["FK_MMOperationID"];
            if (column != null)
            {
                DefualtAOConfigs = (new MMAllocationOperationConfigsController().GetDefualtAllocationOperationConfigs());
                column.OptionsColumn.AllowEdit = true;
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "MMOperationName";
                repositoryItemLookUpEdit.ValueMember = "MMOperationID";
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMOperationNo", "Mã", 150));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("MMOperationName", "Tên công đoạn", 150));
                repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(reqOperation_QueryPopUp);

                column.ColumnEdit = repositoryItemLookUpEdit;
                column.MinWidth = 150;
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
            return gridView;
        }
        public void reqOperation_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (BOSApp.LookupTables.Contains(TableName.MMOperationsTableName))
            {
                MMOperationsController control = new MMOperationsController();
                DataSet ds = (DataSet)BOSApp.LookupTables[TableName.MMOperationsTableName];
                if (ds != null && ds.Tables.Count > 0)
                {
                    List<MMOperationsInfo> operationList = (List<MMOperationsInfo>)control.GetListFromDataSet(ds);
                    if (operationList != null) operationList = operationList.Where(o =>
                        (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsPlan.ToString() && o.MMOperationIsPlan)
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsStock.ToString() && o.MMOperationInOutStockCheck)
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsPlanAndStock.ToString() && o.MMOperationInOutStockCheck && o.MMOperationIsPlan)
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.IsPlanOrStock.ToString() && (o.MMOperationInOutStockCheck || o.MMOperationIsPlan))
                        || (DefualtAOConfigs != null && DefualtAOConfigs.MMAllocationOperationConfigType == AllocationOperationConfigType.AllOperation.ToString())
                        || (DefualtAOConfigs == null)
                        ).ToList();
                    lookUpEdit.Properties.DataSource = operationList;
                }
            }
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

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle < 0)
                return;

            ICShipmentItemVMsInfo item = (ICShipmentItemVMsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item == null)
                return;

            BOSDbUtil dbUtil = new BOSDbUtil();
            if (e.Column.FieldName == "ICShipmentItemProductQty"
                || e.Column.FieldName == "ICShipmentItemProductFactor"
                || e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                bool isSuccess;
                ((MaterialShipmentModule)Screen.Module).ChangeShipmentItemVMQty(item, e.Column.FieldName, out isSuccess);
                if (!isSuccess)
                {
                    dbUtil.SetPropertyValue(item, e.Column.FieldName, gridView.ActiveEditor.OldEditValue);
                    gridView.ActiveEditor.EditValue = gridView.ActiveEditor.OldEditValue;
                    gridView.RefreshData();
                }
            }
            else if (e.Column.FieldName == "ICShipmentItemProductSerialNo"
                 || e.Column.FieldName == "FK_ICStockID")
            {
                ((MaterialShipmentModule)Screen.Module).ChangeItemVMProductUnitCost(item);                
                ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo()
                {
                    FK_ICProductID = item.FK_ICProductID,
                    ICShipmentItemLength = item.ICShipmentItemLength,
                    ICShipmentItemHeight = item.ICShipmentItemHeight,
                    ICShipmentItemWidth = item.ICShipmentItemWidth,
                    ICShipmentItemWoodQty = item.ICShipmentItemWoodQty,
                    ICShipmentItemProductQty = item.ICShipmentItemProductQty,
                    FK_ICProductSerieID = item.FK_ICProductSerieID
                };
                ((MaterialShipmentModule)Screen.Module).CalculatedProductQtyByPackageVolumnConfig();
                item.ICShipmentItemLength = objShipmentItemsInfo.ICShipmentItemLength;
                item.ICShipmentItemHeight = objShipmentItemsInfo.ICShipmentItemHeight;
                item.ICShipmentItemWidth = objShipmentItemsInfo.ICShipmentItemWidth;
                item.ICShipmentItemProductQty = objShipmentItemsInfo.ICShipmentItemProductQty;
            }
            else if (e.Column.FieldName == "ICShipmentItemBatchProductItemProductSerial")
            {
                int BatchitemID = 0;
                int.TryParse(e.Value.ToString(), out BatchitemID);
                if (BatchitemID > 0)
                {
                    MMBatchProductItemsInfo batchItemInfo = BatchitemList.Where(o => o.MMBatchProductItemID == BatchitemID).FirstOrDefault();
                    if (batchItemInfo != null)
                    {
                        item.FK_MMBatchProductItemID = BatchitemID;
                        item.FK_MMBatchProductID = batchItemInfo.FK_MMBatchProductID;
                        item.ICShipmentItemBatchProductItemProductSerial = batchItemInfo.MMBatchProductItemProductSerial;
                        item.FK_ICProductForBatchID = batchItemInfo.FK_ICProductID;
                    }
                }
            }
            if (e.Column.FieldName == "ICShipmentItemLength"
                || e.Column.FieldName == "ICShipmentItemHeight"
                || e.Column.FieldName == "ICShipmentItemWidth"
                || e.Column.FieldName == "ICShipmentItemWoodQty")
            {
                ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo()
                {
                    FK_ICProductID = item.FK_ICProductID,
                    ICShipmentItemLength = item.ICShipmentItemLength,
                    ICShipmentItemHeight = item.ICShipmentItemHeight,
                    ICShipmentItemWidth = item.ICShipmentItemWidth,
                    ICShipmentItemWoodQty = item.ICShipmentItemWoodQty,
                    ICShipmentItemProductQty = item.ICShipmentItemProductQty,
                    FK_ICProductSerieID = item.FK_ICProductSerieID
                };
                ((MaterialShipmentModule)Screen.Module).CalculatedProductQtyByPackageVolumnConfig();
                item.ICShipmentItemLength = objShipmentItemsInfo.ICShipmentItemLength;
                item.ICShipmentItemHeight = objShipmentItemsInfo.ICShipmentItemHeight;
                item.ICShipmentItemWidth = objShipmentItemsInfo.ICShipmentItemWidth;
                item.ICShipmentItemProductQty = objShipmentItemsInfo.ICShipmentItemProductQty;
            }
            ((MaterialShipmentModule)Screen.Module).ChangeItemVM(item);
        }

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICShipmentItemVMsInfo item = (ICShipmentItemVMsInfo)gridView.GetRow(gridView.FocusedRowHandle);
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
                ((MaterialShipmentModule)Screen.Module).DeleteItemVM();
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
                LookUpEdit lookUpEdit = (LookUpEdit)sender;
                ICShipmentItemVMsInfo item = (ICShipmentItemVMsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                BatchitemList = ((MaterialShipmentModule)Screen.Module).GetBatchProductItemSerialDataSource(item);
                lookUpEdit.Properties.DataSource = BatchitemList;
            }
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
            if (e.Column.FieldName == "FK_MMOperationID" && e.Value != null)
            {
                int id = 0;
                int.TryParse(e.Value.ToString(), out id);
                if (id > 0)
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMOperations", "MMOperationID", id, "MMOperationName");
            }
        }
    }
}
