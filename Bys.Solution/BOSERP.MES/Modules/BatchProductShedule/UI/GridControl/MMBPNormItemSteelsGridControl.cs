using BOSCommon;
using BOSComponent;
using BOSLib;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.BatchProductShedule
{
    public class MMBPNormItemSteelsGridControl : BOSGridControl
    {
        List<AAColumnAliasInfo> LstCustomAliasList { get; set; }

        public override void InitGridControlDataSource()
        {
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.BPProductionNormItemOtherMaterialList;
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
            AddGridColumn(strTableName, "MMAllocationPlanItemHeight", "Dày BTP");
            AddGridColumn(strTableName, "MMAllocationPlanItemWidth", "Rộng BTP");
            AddGridColumn(strTableName, "MMAllocationPlanItemLength", "Dài BTP");
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
            GridColumn gridColumn = gridView.Columns["MMAllocationPlanItemHeight"];
            if (gridColumn != null)
            {
                FormatNumbericColumn(gridColumn, false, "n3");
            }
            gridColumn = gridView.Columns["MMAllocationPlanItemWidth"];
            if (gridColumn != null)
            {
                FormatNumbericColumn(gridColumn, false, "n3");
            }
            gridColumn = gridView.Columns["MMAllocationPlanItemLength"];
            if (gridColumn != null)
            {
                FormatNumbericColumn(gridColumn, false, "n3");
            }
            gridColumn = gridView.Columns["MMBatchProductProductionNormItemQuantity"];
            if (gridColumn != null)
            {
                FormatNumbericColumn(gridColumn, false, "n4");
            }
            gridColumn = gridView.Columns["MMAllocationPlanItemQty"];
            if (gridColumn != null)
            {
                FormatNumbericColumn(gridColumn, true, "n4");
            }
            gridColumn = gridView.Columns["MMWoodPlanItemDetailProductQty"];
            if (gridColumn != null)
            {
                FormatNumbericColumn(gridColumn, false, "n4");
            }
            gridColumn = gridView.Columns["MMAllocationProposalItemQty"];
            if (gridColumn != null)
            {
                FormatNumbericColumn(gridColumn, false, "n4");
            }
            gridColumn = gridView.Columns["MMAllocationPlanItemDeliveryDate"];
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
            gridColumn = gridView.Columns["MMBatchProductProductionNormItemComment"];
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
            sum.DisplayFormat = "{0:n4}";
            sum.ShowInGroupColumnFooter = gridView.Columns["MMAllocationPlanItemQty"];
            gridView.GroupSummary.Add(sum);

            sum = new GridGroupSummaryItem();
            sum.FieldName = "MMAllocationProposalItemQty";
            sum.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            sum.DisplayFormat = "{0:n4}";
            sum.ShowInGroupColumnFooter = gridView.Columns["MMAllocationProposalItemQty"];
            gridView.GroupSummary.Add(sum);

            sum = new GridGroupSummaryItem();
            sum.FieldName = "MMBatchProductProductionNormItemQuantity";
            sum.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            sum.DisplayFormat = "{0:n4}";
            sum.ShowInGroupColumnFooter = gridView.Columns["MMBatchProductProductionNormItemQuantity"];
            gridView.GroupSummary.Add(sum);

            gridView.OptionsBehavior.AlignGroupSummaryInGroupRow = DefaultBoolean.True;
            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            gridView.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DefaultBoolean.True;
            gridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DefaultBoolean.True;
            //gridView.OptionsSelection.
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
                ((BatchProductSheduleModule)Screen.Module).ChangeItemWoodQty(entity.BPProductionNormItemOtherMaterialList, item, oldItemQty);
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
            MMBatchProductProductionNormItemsInfo objBatchProductProductionNormItemsInfo = (MMBatchProductProductionNormItemsInfo)gridView.GetRow(e.ListSourceRowIndex);
            if (objBatchProductProductionNormItemsInfo == null)
                return;

            //if (e.Column.FieldName == "FK_MMBatchProductID")
            //{
            //    if (e.Value != null)
            //    {
            //        e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMBatchProducts", "MMBatchProductID", int.Parse(e.Value.ToString()), "MMBatchProductNo");
            //    }
            //}
            //if (e.Column.FieldName == "FK_ICProductID"
            //    || e.Column.FieldName == "FK_ICProductForBatchID")
            //{
            //    if (e.Value != null)
            //    {
            //        e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", int.Parse(e.Value.ToString()), "ICProductNo");
            //    }
            //}
            //if (e.Column.FieldName == "FK_ICProductAttributeWoodTypeID")
            //{
            //    if (e.Value != null)
            //    {
            //        e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProductAttributes", "ICProductAttributeID", int.Parse(e.Value.ToString()), "ICProductAttributeValue");
            //    }
            //}
            //if (e.Column.FieldName == "FK_MMWorkShopID")
            //{
            //    if (e.Value != null)
            //    {
            //        e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMWorkShops", "MMWorkShopID", int.Parse(e.Value.ToString()), "MMWorkShopName");
            //    }
            //}
            //if (e.Column.FieldName == "FK_MMLineID")
            //{
            //    if (e.Value != null)
            //    {
            //        e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMLines", "MMLineID", int.Parse(e.Value.ToString()), "MMLineName");
            //    }
            //}
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
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                DXMenuItem menuItem;
                int rowHandle = e.HitInfo.RowHandle;
                if (e.HitInfo.InGroupRow)
                {
                    menuItem = new DXMenuItem("Xem nhu cầu sử dụng chi tiết", new EventHandler(ItemInGroupViewOperationDetailPlan_Click));
                    menuItem.Tag = new RowInfo(gridView, rowHandle);
                    menuItem.BeginGroup = true;
                    e.Menu.Items.Add(menuItem);

                    menuItem = new DXMenuItem("Duyệt KH (nhiều) vật tư", new EventHandler(PlanItemInGroupAllocation_Click));
                    menuItem.Tag = new RowInfo(gridView, rowHandle);
                    menuItem.BeginGroup = true;
                    e.Menu.Items.Add(menuItem);

                    menuItem = new DXMenuItem("Duyệt cấp phát (nhiều) vật tư", new EventHandler(ApproveItemInGroupAllocation_Click));
                    menuItem.Tag = new RowInfo(gridView, rowHandle);
                    menuItem.BeginGroup = true;
                    e.Menu.Items.Add(menuItem);
                }
                else if (e.HitInfo.InDataRow)
                {
                    MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetFocusedRow();
                    if (!((BatchProductSheduleModule)Screen.Module).IsEditable())
                    {
                        if (IsShowMergeItemSameGroup(gridView))
                        {
                            menuItem = new DXMenuItem("Gộp số lượng", new EventHandler(MergeItemSameGroup_Click));
                            menuItem.Tag = new RowInfo(gridView, rowHandle);
                            menuItem.BeginGroup = true;
                            e.Menu.Items.Add(menuItem);
                        }
                        if (IsShowAllocationQty(gridView))
                        {
                            menuItem = new DXMenuItem("Phân bổ nhanh SL kế hoạch", new EventHandler(AllocationQty_Click));
                            menuItem.Tag = new RowInfo(gridView, rowHandle);
                            menuItem.BeginGroup = true;
                            e.Menu.Items.Add(menuItem);
                        }
                        if (item != null && item.FK_ICProductAlternativeID > 0 && item.FK_ICProductAlternativeID != item.FK_ICProductID)
                        {
                            menuItem = new DXMenuItem("Huỷ thay thế", new EventHandler(CancelAlternative_Click));
                            menuItem.Tag = new RowInfo(gridView, rowHandle);
                            menuItem.BeginGroup = true;
                            e.Menu.Items.Add(menuItem);
                        }
                        else
                        {
                            menuItem = new DXMenuItem("Thay thế vật tư", new EventHandler(Alternative_Click));
                            menuItem.Tag = new RowInfo(gridView, rowHandle);
                            menuItem.BeginGroup = true;
                            e.Menu.Items.Add(menuItem);
                        }
                    }
                    menuItem = new DXMenuItem("Duyệt KH vật tư", new EventHandler(PlanItemAllocation_Click));
                    menuItem.Tag = new RowInfo(gridView, rowHandle);
                    menuItem.BeginGroup = true;
                    e.Menu.Items.Add(menuItem);

                    menuItem = new DXMenuItem("Duyệt cấp phát vật tư", new EventHandler(ApproveItemAllocation_Click));
                    menuItem.Tag = new RowInfo(gridView, rowHandle);
                    menuItem.BeginGroup = true;
                    e.Menu.Items.Add(menuItem);
                }
            }
        }

        public bool IsShowMergeItemSameGroup(GridView gridView)
        {
            int[] rowSelected = gridView.GetSelectedRows();
            List<MMAllocationPlanItemsInfo> selectedList = new List<MMAllocationPlanItemsInfo>();
            foreach (int i in rowSelected)
            {
                MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(i);
                if (item == null || i < 0)
                    continue;

                selectedList.Add(item);
            }
            int countSameItem = selectedList.Select(o => new { o.FK_MMBatchProductProductionNormItemID, o.FK_MMBatchProductItemOutSourcingID, o.FK_MMBatchProductProductionNormItemMeterialID })
                                            .Distinct()
                                            .Count();
            if (countSameItem == 1)
                return true;

            return false;
        }

        public bool IsShowAllocationQty(GridView gridView)
        {
            int[] rowSelected = gridView.GetSelectedRows();
            List<MMAllocationPlanItemsInfo> selectedList = new List<MMAllocationPlanItemsInfo>();
            foreach (int i in rowSelected)
            {
                MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(i);
                if (item == null || i < 0)
                    continue;

                selectedList.Add(item);
            }
            if (selectedList.Count() < 2 || selectedList.Where(o => o.MMAllocationPlanItemStatus != AllocationPlanItemStatus.New.ToString()).Count() > 0)
                return false;

            int countSameItem = selectedList.Select(o => o.FK_ICProductID).Distinct().Count();
            if (countSameItem == 1)
                return true;

            return false;
        }

        public void Alternative_Click(object sender, EventArgs e)
        {
            DXMenuItem menuItem = sender as DXMenuItem;
            if (menuItem == null)
                return;
            if (((BatchProductSheduleModule)Screen.Module).Toolbar.IsNullOrNoneAction()) ((BatchProductSheduleModule)Screen.Module).ActionEdit();
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            GridView gridView = (GridView)MainView;
            RowInfo info = menuItem.Tag as RowInfo;
            MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(info.RowHandle);
            if (item != null)
                ((BatchProductSheduleModule)Screen.Module).AlternativeItems(entity.BPProductionNormItemOtherMaterialList, item, true, false);
        }
        public void CancelAlternative_Click(object sender, EventArgs e)
        {
            DXMenuItem menuItem = sender as DXMenuItem;
            if (menuItem == null)
                return;
            if (((BatchProductSheduleModule)Screen.Module).Toolbar.IsNullOrNoneAction()) ((BatchProductSheduleModule)Screen.Module).ActionEdit();
            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            GridView gridView = (GridView)MainView;
            RowInfo info = menuItem.Tag as RowInfo;
            MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(info.RowHandle);
            if (item != null && item.FK_ICProductAlternativeID > 0)
            {
                ((BatchProductSheduleModule)Screen.Module).CancelAlternativeItems(entity.BPProductionNormItemOtherMaterialList, item, true);
            }
        }
        public void ApproveItemInGroupAllocation_Click(object sender, EventArgs e)
        {
            DXMenuItem menuItem = sender as DXMenuItem;
            if (menuItem == null)
                return;

            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            GridView gridView = (GridView)MainView;
            RowInfo info = menuItem.Tag as RowInfo;
            List<MMAllocationPlanItemsInfo> materialList = SelectGroupRows(info.RowHandle);
            ((BatchProductSheduleModule)Screen.Module).ApproveGroupItems(entity.BPProductionNormItemOtherMaterialList, AllocationPlanItemGroup.OtherMaterial.ToString(), materialList);
        }
        public void PlanItemInGroupAllocation_Click(object sender, EventArgs e)
        {
            DXMenuItem menuItem = sender as DXMenuItem;
            if (menuItem == null)
                return;

            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            GridView gridView = (GridView)MainView;
            RowInfo info = menuItem.Tag as RowInfo;
            List<MMAllocationPlanItemsInfo> materialList = SelectGroupRows(info.RowHandle);
            ((BatchProductSheduleModule)Screen.Module).PlanGroupItems(entity.BPProductionNormItemOtherMaterialList, AllocationPlanItemGroup.OtherMaterial.ToString(), materialList);
        }

        public void PlanItemAllocation_Click(object sender, EventArgs e)
        {
            DXMenuItem menuItem = sender as DXMenuItem;
            if (menuItem == null)
                return;

            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            GridView gridView = (GridView)MainView;
            RowInfo info = menuItem.Tag as RowInfo;
            MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(info.RowHandle);
            List<MMAllocationPlanItemsInfo> materialList = new List<MMAllocationPlanItemsInfo>();
            materialList.Add(item);
            ((BatchProductSheduleModule)Screen.Module).PlanGroupItems(entity.BPProductionNormItemOtherMaterialList, AllocationPlanItemGroup.OtherMaterial.ToString(), materialList);
        }

        public void AllocationQty_Click(object sender, EventArgs e)
        {
            DXMenuItem menuItem = sender as DXMenuItem;
            if (menuItem == null)
                return;

            GridView gridView = (GridView)MainView;
            int[] rowSelected = gridView.GetSelectedRows();
            List<MMAllocationPlanItemsInfo> selectedList = new List<MMAllocationPlanItemsInfo>();
            foreach (int i in rowSelected)
            {
                MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(i);
                if (item == null || i < 0)
                    continue;

                selectedList.Add(item);
            }
            guiAllocationQty guiFind = new guiAllocationQty();
            guiFind.NormQty = selectedList.Sum(o => o.MMAllocationPlanItemQty);
            guiFind.Module = Screen.Module;
            DialogResult rs = guiFind.ShowDialog();
            if (rs != DialogResult.OK)
                return;

            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ((BatchProductSheduleModule)Screen.Module).AllocationQty(entity.BPProductionNormItemOtherMaterialList, guiFind.AllocationQty, guiFind.IsRate, guiFind.RoundNum);
        }

        public void MergeItemSameGroup_Click(object sender, EventArgs e)
        {
            DXMenuItem menuItem = sender as DXMenuItem;
            if (menuItem == null)
                return;

            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            GridView gridView = (GridView)MainView;
            RowInfo info = menuItem.Tag as RowInfo;
            ((BatchProductSheduleModule)Screen.Module).MergeSameGroupItems(entity.BPProductionNormItemOtherMaterialList);
        }

        public void ApproveItemAllocation_Click(object sender, EventArgs e)
        {
            DXMenuItem menuItem = sender as DXMenuItem;
            if (menuItem == null)
                return;

            BatchProductSheduleEntities entity = (BatchProductSheduleEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            GridView gridView = (GridView)MainView;
            RowInfo info = menuItem.Tag as RowInfo;
            MMAllocationPlanItemsInfo item = (MMAllocationPlanItemsInfo)gridView.GetRow(info.RowHandle);
            List<MMAllocationPlanItemsInfo> materialList = new List<MMAllocationPlanItemsInfo>();
            materialList.Add(item);
            ((BatchProductSheduleModule)Screen.Module).ApproveGroupItems(entity.BPProductionNormItemOtherMaterialList, AllocationPlanItemGroup.OtherMaterial.ToString(), materialList);
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
            guiFind.OperationDetailPlanType = AllocationPlanItemGroup.OtherMaterial.ToString();
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
                ((BatchProductSheduleModule)Screen.Module).RemoveItemFromList(entity.BPProductionNormItemOtherMaterialList, AllocationPlanItemGroup.OtherMaterial.ToString());
            }
        }
    }
}
