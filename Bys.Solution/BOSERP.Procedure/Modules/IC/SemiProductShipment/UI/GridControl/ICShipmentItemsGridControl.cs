using BOSCommon;
using BOSCommon.Constants;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Drawing;
using System.Windows.Forms;
using BOSLib;
using BOSComponent;
using DevExpress.XtraEditors;
using System.Collections.Generic;

namespace BOSERP.Modules.SemiProductShipment
{
    public class ICShipmentItemsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            SemiProductShipmentEntities entity = (SemiProductShipmentEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ShipmentItemList;
            this.DataSource = bds;
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
            column.Caption = "Mã đơn hàng nội bộ";
            column.FieldName = "ICShipmentItemSOName";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
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

        private void AddNewRow_Click(object sender, EventArgs e)
        {
            SemiProductShipmentEntities entity = (SemiProductShipmentEntities)(this.Screen.Module as SemiProductShipmentModule).CurrentModuleEntity;
            ICShipmentsInfo mainobject = (ICShipmentsInfo)entity.MainObject;
            if (mainobject.ICShipmentStatus != ShipmentStatus.Complete.ToString())
            {
                (this.Screen.Module as SemiProductShipmentModule).ActionEdit();
            }
            ICShipmentItemsInfo objShipmentItemsInfo = new ICShipmentItemsInfo();
            objShipmentItemsInfo = (ICShipmentItemsInfo)entity.ShipmentItemList[entity.ShipmentItemList.CurrentIndex].Clone();
            objShipmentItemsInfo.Id = 0;
            entity.ShipmentItemList.Add(objShipmentItemsInfo);
            entity.ShipmentItemList.GridControl.RefreshDataSource();
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
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
            column = gridView.Columns["FK_ACAccountID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemComment"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["ICShipmentItemTotalAmount"];
            if (column != null)
            {
                gridView.Columns.Remove(column);
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
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_MMReceiveOperationID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            InitColumnSummary("ICShipmentItemTotalAmount", DevExpress.Data.SummaryItemType.Sum);
            gridView.OptionsView.ShowFooter = true;
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(GridView_ValidatingEditor);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            return gridView;
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
                else if (e.Column.FieldName == "FK_MMReceiveOperationID")
                {
                    ICShipmentItemsInfo obj = (ICShipmentItemsInfo)gridView.GetRow(e.RowHandle);
                    if (obj != null && obj.IsError1)
                    {
                        e.Appearance.BackColor = Color.Red;
                        e.Appearance.BackColor2 = Color.Red;
                    }

                }
            }
        }
        public void FormatNumbericColumn(GridColumn column, bool allowEdit, string formatType)
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
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (item != null) { item.IsError = false; item.IsError1 = false; }
                if (e.Column.FieldName == "ICShipmentItemProductSerialNo")
                {
                    ((SemiProductShipmentModule)Screen.Module).ChangeItemSerieNo(item);
                    ((SemiProductShipmentModule)Screen.Module).UpdatePositionItem(item);
                }
                else if (e.Column.FieldName == "FK_ICStockID")
                {
                    ((SemiProductShipmentModule)Screen.Module).SelectSeriesNoDefault();
                    ((SemiProductShipmentModule)Screen.Module).ChangStockInGridView(item);
                    ((SemiProductShipmentModule)Screen.Module).ChangeItemSerieNo(item);
                }
                else if (e.Column.FieldName == "FK_MMReceiveOperationID" || e.Column.FieldName == "FK_MMOperationID")
                {
                    ((SemiProductShipmentModule)Screen.Module).CheckItemOperationReceive(item);
                }
                else
                {
                    SemiProductShipmentEntities entity = (SemiProductShipmentEntities)(Screen.Module as BaseModuleERP).CurrentModuleEntity;
                    entity.ModuleObjects[TableName.ICShipmentItemsTableName] = (ICShipmentItemsInfo)item.Clone();
                    ((SemiProductShipmentModule)Screen.Module).ChangeItemFromShipmentItemsList();
                }
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
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((SemiProductShipmentModule)Screen.Module).DeleteItemFromShipmentItemsList();
            }
        }
        private void rep_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
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
