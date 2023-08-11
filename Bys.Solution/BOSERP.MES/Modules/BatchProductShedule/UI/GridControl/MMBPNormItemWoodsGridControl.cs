using BOSCommon;
using BOSCommon.Enums;
using BOSComponent;
using BOSLib;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProductShedule
{
    public class MMBPNormItemWoodsGridControl : BOSGridControl
    {
        List<AAColumnAliasInfo> LstCustomAliasList { get; set; }

        public override void InitGridControlDataSource()
        {
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.BPProductionNormItemMaterialList;
            this.DataSource = bds;
        }

        protected override void AddColumnsFromColumnAlias(string strTableName, GridView gridView, List<AAColumnAliasInfo> lstColumnAlias)
        {
            LstCustomAliasList = new List<AAColumnAliasInfo>();
            AddGridColumn(strTableName, "MMBatchProductNo", "Mã LSX");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemNo", "Mã chi tiết");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductName", "Tên chi tiết");
            AddGridColumn(strTableName, "ICProductCode", "Mã code");
            AddGridColumn(strTableName, "ICProductNo", "Mã vật tư");
            AddGridColumn(strTableName, "MMAllocationPlanItemProductName", "Tên vật tư");
            AddGridColumn(strTableName, "MMAllocationPlanItemProductDesc", "Mô tả vật tư");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductHeight", "Dày BTP");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductWidth", "Rộng BTP");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemProductLength", "Dài BTP");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemQuantity", "Tổng SL BTP");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemQuantityPerOne", "SL CT/ 1SP");
            AddGridColumn(strTableName, "MMBatchProductItemProductQty", "SL Thành phẩm");
            AddGridColumn(strTableName, "MMAllocationPlanItemHeight", "Dày");
            AddGridColumn(strTableName, "MMAllocationPlanItemWidth", "Rộng");
            AddGridColumn(strTableName, "MMAllocationPlanItemLength", "Dài");
            AddGridColumn(strTableName, "FK_ICProductAttributeWoodTypeID", "Loại gỗ", "ICProductAttributes", "ICProductAttributeValue", "ICProductAttributeID");
            AddGridColumn(strTableName, "ICProductFBNo", "Mã thành phẩm");
            AddGridColumn(strTableName, "ICProductFBName", "Tên thành phẩm");
            AddGridColumn(strTableName, "ICProductName2", "Tên SP tiếng việt");
            AddGridColumn(strTableName, "FK_ICProductAttributeTTMTID", "TTMT");
            AddGridColumn(strTableName, "MMAllocationPlanItemBPQty", "KL ĐM");
            AddGridColumn(strTableName, "MMAllocationPlanItemQty", "KL kế hoạch");
            AddGridColumn(strTableName, "FK_ICMeasureUnitID", "ĐVT", "ICMeasureUnits", "ICMeasureUnitName", "ICMeasureUnitID");
            AddGridColumn(strTableName, "ICInventoryStockQty", "KL tồn kho");
            AddGridColumn(strTableName, "MMAllocationProposalItemQty", "KL đã cấp phát");
            AddGridColumn(strTableName, "MMAllocationPlanItemDeliveryDate", "Thời gian cần");
            AddGridColumn(strTableName, "FK_MMOperationID", "Công đoạn", "MMOperations", "MMOperationName", "MMOperationID");
            AddGridColumn(strTableName, "FK_MMLineID", "Chuyền", "MMLines", "MMLineName", "MMLineID");
            AddGridColumn(strTableName, "FK_MMWorkShopID", "Xưởng", "MMWorkShops", "MMWorkShopName", "MMWorkShopID");
            AddGridColumn(strTableName, "FK_HRDepartmentRoomGroupItemID", "Tổ", "HRDepartmentRoomGroupItems", "HRDepartmentRoomGroupItemName", "HRDepartmentRoomGroupItemID");
            AddGridColumn(strTableName, "MMAllocationPlanItemStatus", "Trạng thái");
            AddGridColumn(strTableName, "FK_HREmployeeIDReceive", "Người nhận");
            AddGridColumn(strTableName, "AllocationTypeText", "Loại cấp phát");
            AddGridColumn(strTableName, "MMAllocationPlanItemComment", "Ghi chú");
            AddGridColumn(strTableName, "MMBatchProductItemProductSerial", "Mã lô LSX");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemTSHH", "Tỉ số tiêu hao BTP");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemKLBTP", "Khối lượng BTP/TP");
            AddGridColumn(strTableName, "MMBatchProductProductionNormItemTotalKLBTP", "Tổng khối lượng BTP");
            base.AddColumnsFromColumnAlias(strTableName, gridView, LstCustomAliasList);
        }

        protected override AAColumnAliasInfo GetColumnAliasInLookupEditCtrl(RepositoryItemBOSLookupEdit lke)
        {
            return LstCustomAliasList.Where(o => o.AAColumnAliasName == lke.ColumnName).FirstOrDefault();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = false;
            }
            STFieldFormatGroupsInfo formatsInfo = new STFieldFormatGroupsInfo();
            GridColumn gridColumn = gridView.Columns["MMAllocationPlanItemHeight"];
            if (gridColumn != null)
            {
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("MMAllocationPlanItems", "MMAllocationPlanItemHeight", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(gridColumn, false, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            gridColumn = gridView.Columns["MMAllocationPlanItemWidth"];
            if (gridColumn != null)
            {
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("MMAllocationPlanItems", "MMAllocationPlanItemWidth", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(gridColumn, false, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            gridColumn = gridView.Columns["MMAllocationPlanItemLength"];
            if (gridColumn != null)
            {
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("MMAllocationPlanItems", "MMAllocationPlanItemLength", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(gridColumn, false, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            gridColumn = gridView.Columns["MMAllocationPlanItemBPQty"];
            if (gridColumn != null)
            {
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("MMAllocationPlanItems", "MMAllocationPlanItemBPQty", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(gridColumn, false, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            gridColumn = gridView.Columns["MMAllocationPlanItemQty"];
            if (gridColumn != null)
            {
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("MMAllocationPlanItems", "MMAllocationPlanItemQty", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(gridColumn, true, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            gridColumn = gridView.Columns["MMAllocationProposalItemQty"];
            if (gridColumn != null)
            {
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("MMAllocationPlanItems", "MMAllocationProposalItemQty", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(gridColumn, false, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            gridColumn = gridView.Columns["MMAllocationPlanItemRemainQty"];
            if (gridColumn != null)
            {
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("MMAllocationPlanItems", "MMAllocationPlanItemRemainQty", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(gridColumn, false, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            gridColumn = gridView.Columns["ICInventoryStockQty"];
            if (gridColumn != null)
            {
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("MMAllocationPlanItems", "ICInventoryStockQty", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(gridColumn, false, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            gridColumn = gridView.Columns["MMBatchProductProductionNormItemTSHH"];
            if (gridColumn != null)
            {
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("MMAllocationPlanItems", "MMBatchProductProductionNormItemTSHH", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(gridColumn, false, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            gridColumn = gridView.Columns["MMBatchProductProductionNormItemKLBTP"];
            if (gridColumn != null)
            {
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("MMAllocationPlanItems", "MMBatchProductProductionNormItemKLBTP", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(gridColumn, false, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            gridColumn = gridView.Columns["MMBatchProductProductionNormItemTotalKLBTP"];
            if (gridColumn != null)
            {
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("MMAllocationPlanItems", "MMBatchProductProductionNormItemTotalKLBTP", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(gridColumn, false, formatsInfo.STFieldFormatGroupFormatString);
                }
            }

            gridColumn = gridView.Columns["MMBatchProductProductionNormItemQuantity"];
            if (gridColumn != null)
            {
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("MMAllocationPlanItems", "MMBatchProductProductionNormItemQuantity", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(gridColumn, false, formatsInfo.STFieldFormatGroupFormatString);
                }
            }
            gridColumn = gridView.Columns["MMBatchProductItemProductQty"];
            if (gridColumn != null)
            {
                formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("MMAllocationPlanItems", "MMBatchProductItemProductQty", this.Screen.Module.ModuleID);
                if (formatsInfo != null)
                {
                    FormatNumbericColumn(gridColumn, false, formatsInfo.STFieldFormatGroupFormatString);
                }
            }


            gridColumn = gridView.Columns["MMAllocationPlanItemDeliveryDate"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["MMAllocationPlanItemComment"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["FK_MMLineID"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = true;
            }
            gridColumn = gridView.Columns["FK_MMWorkShopID"];
            if (gridColumn != null)
            {
                gridColumn.OptionsColumn.AllowEdit = false;
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
                RepositoryItemBOSLookupEdit repositoryItemLookUpEdit = new RepositoryItemBOSLookupEdit();
                repositoryItemLookUpEdit.DisplayMember = "HREmployeeName";
                repositoryItemLookUpEdit.ValueMember = "HREmployeeID";
                repositoryItemLookUpEdit.DataSource = GetDataSourceForEmployeeReceiveItemLookUpEdit();
                repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                repositoryItemLookUpEdit.NullText = string.Empty;
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("HREmployeeNo", "Mã"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("HREmployeeName", "Tên"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("HRDepartmentName", "Phòng ban"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("HRDepartmentRoomName", "Bộ phận"));
                repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("HRDepartmentRoomGroupItemName", "Tổ"));
                repositoryItemLookUpEdit.QueryPopUp += new CancelEventHandler(repositoryEmployeeReceiveItemLookUpEdit_QueryPopUp);
                gridColumn.ColumnEdit = repositoryItemLookUpEdit;
            }
            GridGroupSummaryItem sum = new GridGroupSummaryItem();
            sum.FieldName = "MMAllocationPlanItemQty";
            sum.SummaryType = DevExpress.Data.SummaryItemType.Sum;            
            formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("MMAllocationPlanItems", "MMAllocationPlanItemQty", this.Screen.Module.ModuleID);
            if (formatsInfo != null)
            {
                sum.DisplayFormat = formatsInfo.STFieldFormatGroupFormatString;
                sum.ShowInGroupColumnFooter = gridView.Columns["MMAllocationPlanItemQty"];
                gridView.GroupSummary.Add(sum);
            }
            sum = new GridGroupSummaryItem();
            sum.FieldName = "MMAllocationProposalItemQty";
            sum.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("MMAllocationPlanItems", "MMAllocationProposalItemQty", this.Screen.Module.ModuleID);
            if (formatsInfo != null)
            {
                sum.DisplayFormat = formatsInfo.STFieldFormatGroupFormatString;
                sum.ShowInGroupColumnFooter = gridView.Columns["MMAllocationProposalItemQty"];
                gridView.GroupSummary.Add(sum);
            }
            sum = new GridGroupSummaryItem();
            sum.FieldName = "MMAllocationPlanItemBPQty";
            sum.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            formatsInfo = ((BaseModuleERP)Screen.Module).GetColumnFormat("MMAllocationPlanItems", "MMAllocationPlanItemBPQty", this.Screen.Module.ModuleID);
            if (formatsInfo != null)
            {
                sum.DisplayFormat = formatsInfo.STFieldFormatGroupFormatString;
                sum.ShowInGroupColumnFooter = gridView.Columns["MMAllocationPlanItemBPQty"];
                gridView.GroupSummary.Add(sum);
            }

            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsBehavior.AlignGroupSummaryInGroupRow = DefaultBoolean.True;
            //gridView.OptionsBehavior.AllowPartialGroups = DefaultBoolean.True;
            gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            gridView.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DefaultBoolean.True;
            gridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DefaultBoolean.True;
            gridView.OptionsSelection.EnableAppearanceFocusedRow = false;
            gridView.ExpandAllGroups();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            gridView.PopupMenuShowing += new PopupMenuShowingEventHandler(GridView_PopupMenuShowing);
            gridView.CustomDrawGroupRow += GridView_CustomDrawGroupRow;
            return gridView;
        }

        private void GridView_CustomDrawGroupRow(object sender, RowObjectCustomDrawEventArgs e)
        {
            GridView gridView = sender as GridView;
            GridGroupRowInfo row = e.Info as GridGroupRowInfo;
            MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(row.RowHandle);
            if (item == null || row.EditValue == null)
                return;

            if (row.Column.FieldName == "FK_ICProductID"
                || row.Column.FieldName == "FK_ICProductForBatchID")
            {
                string productNo = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", int.Parse(row.EditValue.ToString()), "ICProductNo");
                string productName = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", int.Parse(row.EditValue.ToString()), "ICProductName");
                row.GroupText = productNo + (string.IsNullOrEmpty(productName) ? string.Empty : "(" + productName + ")");
            }
        }

        protected override void GridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle < 0)
                return;

            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (item == null)
                return;

            if (e.Column.FieldName == "MMAllocationPlanItemQty")
            {
                decimal oldItemQty = gridView.ActiveEditor.OldEditValue == null ? 0 : decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                ((BatchProductSheduleModule)Screen.Module).ChangeItemWoodQty(entity.BPProductionNormItemMaterialList, item, oldItemQty);
            }
        }

        private void AddGridColumn(string strTableName, string strColumnName, string strCaption, string referenceTable = "", string displayedMember = "", string valueMember = "")
        {

            LstCustomAliasList.Add(new AAColumnAliasInfo
            {
                AAColumnAliasCaption = strCaption,
                AATableName = strTableName,
                AAColumnAliasName = strColumnName,
                AAReferenceTable = referenceTable,
                AADisplayedMember = displayedMember,
                GELookupTableValueColumn = valueMember,
                AAAllowDummy = true,
                Visible = true
            });
        }

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
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
                if (productID > 0)
                {
                    int modelID = dbUtil.GetPropertyIntValue(item, "FK_ICModelID");
                    int modelDetailID = dbUtil.GetPropertyIntValue(item, "FK_ICModelDetailID");
                    ((BaseTransactionModule)Screen.Module).ShowInventory(productID, desc, modelID, modelDetailID);
                }
            }
        }

        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(e.ListSourceRowIndex);
            if (item == null)
                return;

            if (e.Column.FieldName == "FK_ICProductAttributeTTMTID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProductAttributes", "ICProductAttributeID", int.Parse(e.Value.ToString()), "ICProductAttributeValue");
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

        private void GridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.MenuType == GridMenuType.Row)
            {
                int rowHandle = e.HitInfo.RowHandle;
                e.Menu.Items.Clear();
                if (e.HitInfo.InGroupRow)
                {
                    e.Menu.Items.Add(new DXMenuItem("Duyệt KH (nhiều) vật tư", new EventHandler(MenuItem_Click)) { BeginGroup = true, Tag = new RowInfo(gridView, ScheduleMenuTag.PlanInGroup, rowHandle) });
                    e.Menu.Items.Add(new DXMenuItem("Duyệt cấp phát (nhiều) vật tư", new EventHandler(MenuItem_Click)) { Tag = new RowInfo(gridView, ScheduleMenuTag.ApproveInGroup, rowHandle) });
                    e.Menu.Items.Add(new DXMenuItem("Xem nhu cầu sử dụng chi tiết", new EventHandler(MenuItem_Click)) { Tag = new RowInfo(gridView, ScheduleMenuTag.ViewOperationDetailPlan, rowHandle) });
                }
                else if (e.HitInfo.InDataRow)
                {
                    e.Menu.Items.Add(new DXMenuItem("Gộp số lượng", new EventHandler(MenuItem_Click)) { BeginGroup = true, Tag = new RowInfo(gridView, ScheduleMenuTag.MergeSameProduct, rowHandle) });
                    e.Menu.Items.Add(new DXMenuItem("Thay thế vật tư", new EventHandler(MenuItem_Click)) { Tag = new RowInfo(gridView, ScheduleMenuTag.Alternative, rowHandle) });
                    e.Menu.Items.Add(new DXMenuItem("Hủy thay thế vật tư", new EventHandler(MenuItem_Click)) { Tag = new RowInfo(gridView, ScheduleMenuTag.CancelAlternative, rowHandle) });
                    e.Menu.Items.Add(new DXMenuItem("Phân bổ nhanh SL kế hoạch", new EventHandler(MenuItem_Click)) { Tag = new RowInfo(gridView, ScheduleMenuTag.AllocationQty, rowHandle) });
                    e.Menu.Items.Add(new DXMenuItem("Duyệt KH vật tư", new EventHandler(MenuItem_Click)) { BeginGroup = true, Tag = new RowInfo(gridView, ScheduleMenuTag.PlanInRow, rowHandle) });
                    e.Menu.Items.Add(new DXMenuItem("Duyệt cấp phát vật tư", new EventHandler(MenuItem_Click)) { Tag = new RowInfo(gridView, ScheduleMenuTag.ApproveInRow, rowHandle) });
                }
                EnabledPopupMenu(e.Menu.Items);
            }
        }

        public void EnabledPopupMenu(DXMenuItemCollection menuItems)
        {
            foreach (var menuItem in menuItems)
            {
                if (menuItem is DXMenuItem)
                    ((DXMenuItem)menuItem).Enabled = IsEnabledMenuItem(((DXMenuItem)menuItem).Tag);
            }
        }

        private bool IsEnabledMenuItem(object tag)
        {
            RowInfo info = tag as RowInfo;
            List<MMAllocationPlanItemsInfo> seletedItems = GetSeletedItems(info.View, info);
            if (!seletedItems.Any())
                return false;

            bool isEdit = !((BatchProductSheduleModule)Screen.Module).IsEditable();
            bool isEnabled = true;
            switch (info.TagName)
            {
                case ScheduleMenuTag.PlanInRow:
                case ScheduleMenuTag.PlanInGroup:
                    isEnabled = !isEdit && !seletedItems.Any(o => o.MMAllocationPlanItemStatus != AllocationPlanItemStatus.New.ToString());
                    break;
                case ScheduleMenuTag.ApproveInRow:
                case ScheduleMenuTag.ApproveInGroup:
                    isEnabled = !isEdit && !seletedItems.Any(o => o.MMAllocationPlanItemStatus != AllocationPlanItemStatus.Planed.ToString());
                    break;
                case ScheduleMenuTag.MergeSameProduct:
                    isEnabled = seletedItems.Count() > 1
                                    && !seletedItems.Any(o => o.MMAllocationPlanItemStatus != AllocationPlanItemStatus.New.ToString())
                                    && !(seletedItems.Select(o => new { o.FK_MMBatchProductItemOutSourcingID, o.FK_MMBatchProductProductionNormItemID, o.FK_MMBatchProductProductionNormItemMeterialID })
                                                 .Distinct().Count() > 1);
                    break;
                case ScheduleMenuTag.AllocationQty:
                    isEnabled = isEdit && seletedItems.Count() > 1 && seletedItems.Select(o => o.FK_ICProductID).Distinct().Count() == 1;
                    break;
                case ScheduleMenuTag.Alternative:
                    isEnabled = isEdit && !(seletedItems.Any(o => o.FK_ICProductAlternativeID != 0 && o.FK_ICProductID != o.FK_ICProductAlternativeID)
                                            || seletedItems.Any(o => o.MMAllocationPlanItemDepreciationRate != 0 && o.MMAllocationPlanItemDepreciationRate != o.MMBatchProductProductionNormItemTSHH));
                    break;
                case ScheduleMenuTag.CancelAlternative:
                    isEnabled = isEdit && !(seletedItems.Any(o => o.FK_ICProductAlternativeID == 0 || o.FK_ICProductID == o.FK_ICProductAlternativeID)
                                            && seletedItems.Any(o => o.MMAllocationPlanItemDepreciationRate == 0 || o.MMAllocationPlanItemDepreciationRate == o.MMBatchProductProductionNormItemTSHH));
                    break;
                case ScheduleMenuTag.ViewOperationDetailPlan:
                    isEnabled = seletedItems.Any();
                    break;
            }
            return isEnabled;
        }

        public void MenuItem_Click(object sender, EventArgs e)
        {
            DXMenuItem menuItem = sender as DXMenuItem;
            if (menuItem == null)
                return;

            RowInfo info = menuItem.Tag as RowInfo;
            List<MMAllocationPlanItemsInfo> seletedItems = GetSeletedItems(info.View, info);
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            switch (info.TagName)
            {
                case ScheduleMenuTag.PlanInRow:
                case ScheduleMenuTag.PlanInGroup:
                    ((BatchProductSheduleModule)Screen.Module).PlanGroupItems(entity.BPProductionNormItemMaterialList, AllocationPlanItemGroup.Material.ToString(), seletedItems);
                    break;
                case ScheduleMenuTag.ApproveInGroup:
                case ScheduleMenuTag.ApproveInRow:
                    ((BatchProductSheduleModule)Screen.Module).ApproveGroupItems(entity.BPProductionNormItemMaterialList, AllocationPlanItemGroup.Material.ToString(), seletedItems);
                    break;
                case ScheduleMenuTag.MergeSameProduct:
                    ((BatchProductSheduleModule)Screen.Module).MergeSameGroupItems(entity.BPProductionNormItemMaterialList);
                    break;
                case ScheduleMenuTag.Alternative:
                    AlternativePlanItems(seletedItems);
                    break;
                case ScheduleMenuTag.CancelAlternative:
                    ((BatchProductSheduleModule)Screen.Module).CancelAlternativeItems(entity.BPProductionNormItemMaterialList, seletedItems, true);
                    break;
                case ScheduleMenuTag.AllocationQty:
                    AllocationQty(seletedItems);
                    break;
                case ScheduleMenuTag.ViewOperationDetailPlan:
                    ItemInGroupViewOperationDetailPlan_Click(sender, e);
                    break;
                default:
                    break;
            }
        }

        public List<MMAllocationPlanItemsInfo> GetSeletedItems(GridView gridView, RowInfo info = null)
        {
            List<MMAllocationPlanItemsInfo> seletedItems = new List<MMAllocationPlanItemsInfo>();
            int[] rowSelected = gridView.GetSelectedRows();
            if (!rowSelected.Contains(info.RowHandle) && rowSelected.Any())
                return seletedItems;

            foreach (int i in rowSelected)
            {
                MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(i);
                if (item == null || i < 0)
                    continue;

                seletedItems.Add(item);
            }
            if (!seletedItems.Any() && info != null)
            {
                if (gridView.IsGroupRow(info.RowHandle))
                {
                    for (int i = 0; i < gridView.GetChildRowCount(info.RowHandle); i++)
                    {
                        int rowHandle = gridView.GetChildRowHandle(info.RowHandle, i);
                        if (gridView.IsGroupRow(rowHandle))
                        {
                            List<MMAllocationPlanItemsInfo> materialChildList = new List<MMAllocationPlanItemsInfo>();
                            materialChildList = SelectGroupRows(rowHandle);
                            if (materialChildList.Any())
                            {
                                seletedItems.AddRange(materialChildList);
                            }
                        }
                        else
                        {
                            MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(rowHandle);
                            seletedItems.Add(item);
                        }
                    }
                }
                else
                {
                    MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(info.RowHandle);
                    if (item != null)
                        seletedItems.Add(item);
                }
            }
            return seletedItems;
        }

        private void AlternativePlanItems(List<MMAllocationPlanItemsInfo> seletedItems)
        {
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            if (seletedItems.Count() == 1)
                ((BatchProductSheduleModule)Screen.Module).AlternativeItems(entity.BPProductionNormItemMaterialList, seletedItems.FirstOrDefault(), true, true);
            else
            {
                if (seletedItems.Any(o => o.MMAllocationPlanItemStatus != AllocationPlanItemStatus.New.ToString()))
                {
                    MessageBox.Show("Trạng thái vật tư không hợp lệ. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (seletedItems.Where(o => o.FK_ICProductAlternativeID > 0 && o.FK_ICProductAlternativeID != o.FK_ICProductID).Any())
                {
                    MessageBox.Show("Vật tư đã có thay thế khác vui lòng hủy thay thế trước khi thao tác này!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                seletedItems.ForEach(o =>
                {
                    o.VirtualID = Guid.NewGuid().ToString();
                    o.ICProductAlternativeProductQty = o.MMAllocationPlanItemQty;
                });
                guiAlternativeMulti guiFind = new guiAlternativeMulti(AllocationPlanItemGroup.Material.ToString());
                guiFind.PlanItems = seletedItems.Select(o => (MMAllocationPlanItemsInfo)o.Clone()).ToList();
                guiFind.Module = Screen.Module;
                guiFind.IsAlterOverConfigMaterial = true;
                DialogResult rs = guiFind.ShowDialog();
                if (rs != DialogResult.OK)
                    return;

                ((BatchProductSheduleModule)Screen.Module).AlternativeMulti(entity.BPProductionNormItemMaterialList, seletedItems, guiFind.PlanItems, guiFind.SelectedObject, true);
            }
        }

        public void AllocationQty(List<MMAllocationPlanItemsInfo> selectedList)
        {
            if (selectedList.Any(o => o.MMAllocationPlanItemStatus != AllocationPlanItemStatus.New.ToString()))
            {
                MessageBox.Show("Trạng thái vật tư không hợp lệ. Vui lòng kiểm tra lại!", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            guiAllocationQty guiFind = new guiAllocationQty();
            guiFind.NormQty = selectedList.Sum(o => o.MMAllocationPlanItemQty);
            guiFind.Module = Screen.Module;
            DialogResult rs = guiFind.ShowDialog();
            if (rs != DialogResult.OK)
                return;

            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ((BatchProductSheduleModule)Screen.Module).AllocationQty(entity.BPProductionNormItemMaterialList, guiFind.AllocationQty, guiFind.IsRate, guiFind.RoundNum);
        }

        private List<MMAllocationPlanItemsInfo> SelectGroupRows(int groupRowHandle)
        {
            GridView gridView = (GridView)MainView;
            List<MMAllocationPlanItemsInfo> materialList = new List<MMAllocationPlanItemsInfo>();
            for (int i = 0; i < gridView.GetChildRowCount(groupRowHandle); i++)
            {
                int rowHandle = gridView.GetChildRowHandle(groupRowHandle, i);
                if (gridView.IsGroupRow(rowHandle))
                {
                    List<MMAllocationPlanItemsInfo> materialChildList = new List<MMAllocationPlanItemsInfo>();
                    materialChildList = SelectGroupRows(rowHandle);
                    if (materialChildList.Count() > 0)
                    {
                        materialList.AddRange(materialChildList);
                    }
                }
                else
                {
                    MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(rowHandle);
                    materialList.Add(item);
                }
            }
            return materialList;
        }

        public void ItemInGroupViewOperationDetailPlan_Click(object sender, EventArgs e)
        {
            DXMenuItem menuItem = sender as DXMenuItem;
            if (menuItem == null)
                return;

            GridView gridView = (GridView)MainView;
            RowInfo info = menuItem.Tag as RowInfo;
            MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(info.RowHandle);
            if (item == null)
                return;

            guiShowOperationDetailPlanMaterial guiFind = new guiShowOperationDetailPlanMaterial(item.FK_MMBatchProductID, 0, 0, item.FK_ICProductID, item.MMBatchProductDate);
            guiFind.Module = Screen.Module;
            guiFind.OperationDetailPlanType = AllocationPlanItemGroup.Material.ToString();
            guiFind.ShowDialog();
        }

        void repositoryEmployeeReceiveItemLookUpEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = (LookUpEdit)sender;
            if (lookUpEdit != null)
            {
                lookUpEdit.Properties.DataSource = GetDataSourceForEmployeeReceiveItemLookUpEdit();
            }
        }

        List<HREmployeesInfo> GetDataSourceForEmployeeReceiveItemLookUpEdit()
        {
            List<HREmployeesInfo> employeeReceiveList = (List<HREmployeesInfo>)(new HREmployeesController())
                    .GetListFromDataSet(new HREmployeesController()
                    .GetAllEmployeesForLookupControl());
            if (employeeReceiveList != null)
                employeeReceiveList.Insert(0, new HREmployeesInfo());
            return employeeReceiveList;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                BatchProductSheduleEntities entity = (BatchProductSheduleEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                ((BatchProductSheduleModule)Screen.Module).RemoveItemFromList(entity.BPProductionNormItemMaterialList, AllocationPlanItemGroup.Material.ToString());
            }
        }
    }
}
