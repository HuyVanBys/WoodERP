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
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.AllocationProposal
{
    public class MMAllocationPlanItemPackagingsGridControl : BOSGridControl
    {
        List<AAColumnAliasInfo> LstCustomAliasList { get; set; }
        public override void InitGridControlDataSource()
        {
            AllocationProposalEntities entity = (AllocationProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.AllocationPlanItemPackagingList;
            this.DataSource = bds;
        }

        protected override AAColumnAliasInfo GetColumnAliasInLookupEditCtrl(RepositoryItemBOSLookupEdit lke)
        {
            return LstCustomAliasList.Where(o => o.AAColumnAliasName == lke.ColumnName).FirstOrDefault();
        }

        protected override void AddColumnsFromColumnAlias(string strTableName, GridView gridView, List<AAColumnAliasInfo> lstColumnAlias)
        {
            LstCustomAliasList = new List<AAColumnAliasInfo>();
            //AddGridColumn(strTableName, "FK_MMBatchProductID", "Mã LSX", "MMBatchProducts", "MMBatchProductNo", "MMBatchProductID");
            AddGridColumn(strTableName, "FK_ICProductID", "Mã vật tư", "ICProducts", "ICProductNo", "ICProductID");
            AddGridColumn(strTableName, "MMAllocationPlanItemProductName", "Tên vật tư");
            AddGridColumn(strTableName, "MMAllocationPlanItemProductDesc", "Mô tả");
            AddGridColumn(strTableName, "MMAllocationPlanItemHeight", "Dày");
            AddGridColumn(strTableName, "MMAllocationPlanItemWidth", "Rộng");
            AddGridColumn(strTableName, "MMAllocationPlanItemLength", "Dài");
            AddGridColumn(strTableName, "MMAllocationPlanItemQty", "Số lượng");
            AddGridColumn(strTableName, "ICInventoryStockQty", "SL tồn kho");
            AddGridColumn(strTableName, "MMAllocationProposalItemQty", "SL đã cấp phát");
            AddGridColumn(strTableName, "MMAllocationPlanItemComment", "Ghi chú");
            AddGridColumn(strTableName, "MMAllocationPlanItemDeliveryDate", "Ngày cần");

            AddGridColumn(strTableName, "FK_ICProductAttributeTTMTID", "TTMT", "ICProductAttributes", "ICProductAttributeValue", "ICProductAttributeID", "ICProductAttributeGroup", "TTMT");
            AddGridColumn(strTableName, "FK_ICMeasureUnitID", "ĐVT", "ICMeasureUnits", "ICMeasureUnitName", "ICMeasureUnitID");
            AddGridColumn(strTableName, "FK_MMOperationID", "Công đoạn", "MMOperations", "MMOperationName", "MMOperationID");
            AddGridColumn(strTableName, "FK_MMWorkShopID", "Xưởng", "MMWorkShops", "MMWorkShopName", "MMWorkShopID");
            AddGridColumn(strTableName, "FK_MMLineID", "Chuyền", "MMLines", "MMLineName", "MMLineID");
            AddGridColumn(strTableName, "FK_HRDepartmentRoomGroupItemID", "Tổ", "HRDepartmentRoomGroupItems", "HRDepartmentRoomGroupItemName", "HRDepartmentRoomGroupItemID");
            AddGridColumn(strTableName, "MMAllocationPlanItemStatus", "Trạng thái");
            AddGridColumn(strTableName, "FK_HREmployeeIDReceive", "Người nhận", "HREmployees", "HREmployeeName", "HREmployeeID");
            base.AddColumnsFromColumnAlias(strTableName, gridView, LstCustomAliasList);
        }

        private void AddGridColumn(string strTableName, string strColumnName, string strCaption, string referenceTable = "", string displayedMember = "", string valueMember = "", string filteredColumn = "", string filteredValues = "")
        {

            LstCustomAliasList.Add(new AAColumnAliasInfo
            {
                AAColumnAliasCaption = strCaption,
                AATableName = strTableName,
                AAColumnAliasName = strColumnName,
                AAReferenceTable = referenceTable,
                AADisplayedMember = displayedMember,
                GELookupTableValueColumn = valueMember,
                AAFilteredColumn = filteredColumn,
                AAFilteredValues = filteredValues,
                AAAllowDummy = true,
                Visible = true
            });
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                AllocationProposalEntities entity = (AllocationProposalEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                ((AllocationProposalModule)Screen.Module).RemoveItemFromList(entity.AllocationPlanItemPackagingList);
            }
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn gridColumn = gridView.Columns["FK_ICProductID"];
            if (gridColumn != null)
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
                repositoryItemLookupEdit.DataSource = BOSApp.CurrentProductList.Where(o => o.ICProductType == ProductType.IngredientPackaging.ToString()).ToList();
                repositoryItemLookupEdit.BestFitMode = BestFitMode.BestFitResizePopup;
                repositoryItemLookupEdit.MaxLength = 1000;
                gridColumn.ColumnEdit = repositoryItemLookupEdit;
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
            gridColumn = gridView.Columns["FK_MMBatchProductID"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["MMAllocationPlanItemQty"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["MMAllocationPlanItemLength"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["MMAllocationPlanItemWidth"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["MMAllocationPlanItemHeight"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["MMAllocationPlanItemComment"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["FK_ICProductAttributeTTMTID"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["MMAllocationPlanItemDeliveryDate"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["FK_MMWorkShopID"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["FK_MMLineID"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["FK_HRDepartmentRoomGroupItemID"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["FK_HREmployeeIDReceive"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["FK_MMOperationID"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            gridView.OptionsView.ShowFooter = true;

            gridView.OptionsBehavior.AlignGroupSummaryInGroupRow = DefaultBoolean.True;
            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            gridView.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DefaultBoolean.True;
            gridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DefaultBoolean.True;

            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            gridView.ValidatingEditor += new BaseContainerValidateEditorEventHandler(gridView_ValidatingEditor);
            return gridView;
        }

        private void gridView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            GridView gridView = (GridView)sender;
            MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item == null)
                return;

            if (item.MMAllocationPlanItemStatus != AllocationPlanItemStatus.New.ToString())
            {
                e.ErrorText = "Vật tư ở trạng thái không thể sửa đổi.";
                e.Valid = false;
            }
        }

        private void rpMeasureUnitt_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
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

        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = (GridView)sender;
            AllocationProposalEntities entity = (AllocationProposalEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item == null)
                return;

            if (e.Column.FieldName == "FK_ICProductID")
            {
                ((AllocationProposalModule)Screen.Module).ChangeProduct(entity.AllocationPlanItemPackagingList, item, AllocationPlanItemGroup.IngredientPackaging.ToString());
            }
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ShowInventory();
        }

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
                if (productID > 0)
                {
                    int modelID = dbUtil.GetPropertyIntValue(item, "FK_ICModelID");
                    int modelDetailID = dbUtil.GetPropertyIntValue(item, "FK_ICModelDetailID");
                    ((BaseTransactionModule)Screen.Module).ShowInventory(productID, desc, modelID, modelDetailID);
                }
            }
        }

        private void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle < 0)
                return;

            MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(e.RowHandle);
            if (item == null)
                return;

            if (e.Column.FieldName == "MMAllocationPlanItemDeliveryDate"
                || e.Column.FieldName == "FK_MMOperationID"
                || e.Column.FieldName == "FK_MMLineID"
                || e.Column.FieldName == "FK_MMWorkShopID"
                || e.Column.FieldName == "FK_HRDepartmentRoomGroupItemID")
            {
                e.Appearance.BackColor = Color.LightGoldenrodYellow;
                e.Appearance.BackColor2 = Color.LightGoldenrodYellow;
            }
            if (e.Column.FieldName == "MMAllocationPlanItemDeliveryDate" && item.MMAllocationPlanItemDeliveryDate.Year != 9999)
            {
                e.Appearance.BackColor = Color.LightGreen;
                e.Appearance.BackColor2 = Color.LightGreen;
            }
            if (e.Column.FieldName == "FK_MMOperationID" && item.FK_MMOperationID > 0)
            {
                e.Appearance.BackColor = Color.LightGreen;
                e.Appearance.BackColor2 = Color.LightGreen;
            }
            if (e.Column.FieldName == "FK_MMLineID" && item.FK_MMLineID > 0)
            {
                e.Appearance.BackColor = Color.LightGreen;
                e.Appearance.BackColor2 = Color.LightGreen;
            }
            if (e.Column.FieldName == "FK_MMWorkShopID" && item.FK_MMWorkShopID > 0)
            {
                e.Appearance.BackColor = Color.LightGreen;
                e.Appearance.BackColor2 = Color.LightGreen;
            }
            if (e.Column.FieldName == "FK_HRDepartmentRoomGroupItemID" && item.FK_HRDepartmentRoomGroupItemID > 0)
            {
                e.Appearance.BackColor = Color.LightGreen;
                e.Appearance.BackColor2 = Color.LightGreen;
            }
            if (e.Column.FieldName == "ICInventoryStockQty")
            {
                e.Appearance.BackColor = Color.LightGreen;
                e.Appearance.BackColor2 = Color.LightGreen;
                if (item.ICInventoryStockQty < item.MMAllocationPlanItemQty - item.MMAllocationPlanItemPlanedQty
                    && item.MMAllocationPlanItemStatus != AllocationPlanItemStatus.Approved.ToString()
                    && item.MMAllocationPlanItemStatus != AllocationPlanItemStatus.Allocated.ToString())
                {
                    e.Appearance.BackColor = Color.OrangeRed;
                    e.Appearance.BackColor2 = Color.OrangeRed;
                }
            }

            if (e.Column.FieldName == "MMAllocationPlanItemQty")
            {
                if (item.ICInventoryStockQty < item.MMAllocationPlanItemQty - item.MMAllocationPlanItemPlanedQty
                    && item.MMAllocationPlanItemStatus != AllocationPlanItemStatus.Approved.ToString()
                    && item.MMAllocationPlanItemStatus != AllocationPlanItemStatus.Allocated.ToString())
                {
                    e.Appearance.BackColor = Color.OrangeRed;
                    e.Appearance.BackColor2 = Color.OrangeRed;
                }
            }
            if (e.Column.FieldName == "MMAllocationPlanItemStatus")
            {
                if (item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Planed.ToString())
                {
                    e.Appearance.BackColor = Color.LightGoldenrodYellow;
                    e.Appearance.BackColor2 = Color.LightGoldenrodYellow;
                }
                else if (item.MMAllocationPlanItemStatus == AllocationPlanItemStatus.Approved.ToString())
                {
                    e.Appearance.BackColor = Color.LightGreen;
                    e.Appearance.BackColor2 = Color.LightGreen;
                }
            }
        }

    }
}
