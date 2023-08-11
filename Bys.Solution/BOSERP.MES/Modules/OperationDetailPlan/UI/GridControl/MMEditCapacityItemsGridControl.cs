using BOSCommon;
using BOSComponent;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlan
{
    public class MMEditCapacityItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = new BOSList<MMOperationDetailPlanCapacityItemsInfo>();
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Chọn";
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Phiếu nhập";
            column.FieldName = "ICReceiptNo";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Lưu";
            column.FieldName = "SaveEdit";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nhân công";
            column.FieldName = "Employee";
            column.VisibleIndex = 2;
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = false;
                col.Visible = true;
                if (col.VisibleIndex == -1)
                    col.VisibleIndex = 0;
                if (col.FieldName == "MMOperationDetailPlanCapacityItemProductQty"
                    || col.FieldName == "MMOperationDetailPlanCapacityItemFailProductQty"
                    || col.FieldName == "MMOperationDetailPlanCapacityItemProcessTime"
                    || col.FieldName == "MMOperationDetailPlanCapacityItemPlanDesc"
                    || col.FieldName == "FK_HREmployeeGiveID"
                    || col.FieldName == "FK_HREmployeeTakeID"
                    || col.FieldName == "FK_HREmployeeQCID"
                    || col.FieldName == "MMOperationDetailPlanCapacityItemFromTime"
                    || col.FieldName == "MMOperationDetailPlanCapacityItemToTime"
                    || col.FieldName == "MMOperationDetailPlanCapacityItemLossTime"
                    || col.FieldName == "Selected")
                    col.OptionsColumn.AllowEdit = true;

                if (col.FieldName == "SaveEdit")
                {
                    col.OptionsColumn.AllowEdit = true;
                    RepositoryItemHyperLinkEdit buttonSave = new RepositoryItemHyperLinkEdit();
                    buttonSave.NullText = "Lưu";
                    buttonSave.Click += new EventHandler(ButtonSave_ButtonClick);
                    col.ColumnEdit = buttonSave;
                }
                else if (col.FieldName == "Employee")
                {
                    col.VisibleIndex = 2;
                    col.OptionsColumn.AllowEdit = true;
                    RepositoryItemHyperLinkEdit rep1 = new RepositoryItemHyperLinkEdit();
                    rep1.NullText = "Chi tiết";
                    rep1.Click += new EventHandler(ViewEmployee_Click);
                    col.ColumnEdit = rep1;
                }
                else if (col.FieldName == "MMOperationDetailPlanCapacityItemFromTime" || col.FieldName == "MMOperationDetailPlanCapacityItemToTime")
                {
                    FormatNumbericColumn(col, true, "dd/MM/yyyy hh:mm tt", DevExpress.XtraEditors.Mask.MaskType.DateTime, FormatType.DateTime);
                }
            }

            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridView_CellValueChanged);
            return gridView;
        }
        public void FormatNumbericColumn(GridColumn column, bool allowEdit, string formatType, DevExpress.XtraEditors.Mask.MaskType maskType, FormatType numFormatType)
        {
            RepositoryItemTextEdit repositoryItemTextEdit = new RepositoryItemTextEdit()
            {
                Mask =
                {
                    MaskType = maskType,
                    EditMask = formatType,
                    UseMaskAsDisplayFormat = true
                }
            };
            repositoryItemTextEdit.DisplayFormat.FormatType = numFormatType;
            repositoryItemTextEdit.DisplayFormat.FormatString = formatType;
            column.OptionsColumn.AllowEdit = allowEdit;
            column.ColumnEdit = repositoryItemTextEdit;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
        }
        void ViewEmployee_Click(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMOperationDetailPlanCapacityItemsInfo obj = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null)
                {
                    MMOperationDetailPlanItemChildsInfo planItem = new MMOperationDetailPlanItemChildsInfo();
                    BOSUtil.CopyObject(obj, planItem);
                    planItem.MMOperationDetailPlanItemChildID = obj.FK_MMOperationDetailPlanItemChildID;
                    guiViewEditCapacity guiEditCapacity = this.Screen as guiViewEditCapacity;
                    if (obj.HumanFocusedList == null || obj.HumanFocusedList.Count == 0)
                    {
                        if (guiEditCapacity != null)
                            obj.HumanFocusedList = guiEditCapacity.HumanList.Where(h => h.FK_MMOperationDetailPlanCapacityItemID == obj.MMOperationDetailPlanCapacityItemID).ToList();
                    }
                    if (obj.HumanFocusedList.Count() > 0)
                    {
                        List<MMDetailPlanHumanUnitsInfo> humanFocusedList = new List<MMDetailPlanHumanUnitsInfo>();
                        obj.HumanFocusedList.ForEach(h =>
                        {
                            MMDetailPlanHumanUnitsInfo human = new MMDetailPlanHumanUnitsInfo();
                            human.FK_HRDepartmentRoomGroupItemID = h.FK_HRDepartmentRoomGroupItemID;
                            human.FK_MMOperationDetailPlanItemChildID = h.FK_MMOperationDetailPlanItemChildID;
                            human.FK_HREmployeeID = h.FK_HREmployeeID;
                            human.MMDetailPlanHumanUnitDesc = h.MMCapacityHumanUnitDesc;
                            humanFocusedList.Add(human);
                        });
                        planItem.HumanFocusedList = humanFocusedList;
                    }
                    List<MMOperationDetailPlanItemChildsInfo> selectedList = new List<MMOperationDetailPlanItemChildsInfo>();
                    if (planItem != null) selectedList.Add(planItem);
                    guiEditHuman guiEditHuman = new guiEditHuman();
                    guiEditHuman.Module = this.Screen.Module;
                    guiEditHuman.HumanDetailPlanItemsList = selectedList;
                    if (guiEditHuman.ShowDialog() == DialogResult.OK)
                    {
                        foreach (MMOperationDetailPlanItemChildsInfo ticketRow in guiEditHuman.HumanDetailPlanItemsList)
                        {
                            List<MMCapacityHumanUnitsInfo> humanFocusedList = new List<MMCapacityHumanUnitsInfo>();
                            ticketRow.HumanFocusedList.ForEach(h =>
                            {
                                MMCapacityHumanUnitsInfo human = obj.HumanFocusedList.Where(f => f.FK_HREmployeeID == h.FK_HREmployeeID && f.FK_MMOperationDetailPlanItemChildID == h.FK_MMOperationDetailPlanItemChildID).FirstOrDefault();
                                if (human == null || human.MMCapacityHumanUnitID == 0)
                                {
                                    human = new MMCapacityHumanUnitsInfo();
                                    human.FK_HRDepartmentRoomGroupItemID = h.FK_HRDepartmentRoomGroupItemID;
                                    human.FK_MMOperationDetailPlanItemChildID = h.FK_MMOperationDetailPlanItemChildID;
                                    human.FK_HREmployeeID = h.FK_HREmployeeID;
                                    human.MMCapacityHumanUnitDesc = h.MMDetailPlanHumanUnitDesc;
                                }
                                human.MMCapacityHumanUnitAbstract = obj.MMOperationDetailPlanCapacityItemAbstract;
                                human.FK_MMOperationDetailPlanCapacityItemID = obj.MMOperationDetailPlanCapacityItemID;
                                humanFocusedList.Add(human);
                            });
                            obj.HumanFocusedList = humanFocusedList;
                        }
                    }
                }
            }
        }
        private void ButtonSave_ButtonClick(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMOperationDetailPlanCapacityItemsInfo obj = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null)
                {
                    if (obj.ItemStatus != DetailPlanItemChildStatus.JobCreated.ToString())
                    {
                        BOSApp.ShowMessage("Trạng thái thẻ không phù hợp, bạn chỉ được xem!");
                        obj.MMOperationDetailPlanCapacityItemProductQty = decimal.Parse(gridView.ActiveEditor.OldEditValue != null ? gridView.ActiveEditor.OldEditValue.ToString() : "0");
                        return;
                    }
                    if (obj.MMOperationDetailPlanCapacityItemProductQty < obj.MMOperationDetailPlanCapacityItemCapacityProductQty)
                    {
                        BOSApp.ShowMessage("Số lượng thay đổi nhỏ hơn SL đã nhập tại module NKBTP");
                        obj.MMOperationDetailPlanCapacityItemProductQty = obj.MMOperationDetailPlanCapacityItemCapacityProductQty;
                        return;
                    }
                    if (obj.MMOperationDetailPlanCapacityItemProductQty > obj.MMOperationDetailPlanCapacityItemCompletedProductQty)
                    {
                        BOSApp.ShowMessage("Số lượng được phép thay đổi không thể lớn hơn SL đạt trước đó!");
                        obj.MMOperationDetailPlanCapacityItemProductQty = obj.MMOperationDetailPlanCapacityItemCompletedProductQty;
                        return;
                    }
                    (new MMOperationDetailPlanCapacityItemsController()).UpdateObject(obj);
                    //Save Human
                    if (obj.HumanFocusedList != null && obj.HumanFocusedList.Count() > 0)
                    {
                        //HumanList
                        guiViewEditCapacity guiEditCapacity = this.Screen as guiViewEditCapacity;
                        if (guiEditCapacity != null && guiEditCapacity.HumanList.Count() > 0)
                        {
                            List<MMCapacityHumanUnitsInfo> deleteHuman = guiEditCapacity.HumanList.Where(h => h.FK_MMOperationDetailPlanCapacityItemID == obj.MMOperationDetailPlanCapacityItemID
                                                                                                        && obj.HumanFocusedList.Any(f => f.MMCapacityHumanUnitID != h.MMCapacityHumanUnitID)).ToList();
                            if (deleteHuman.Count() > 0)
                                SaveItemWithDataTableType.DeleteItem<MMCapacityHumanUnitsInfo>(deleteHuman, "MMCapacityHumanUnits", BOSApp.CurrentUsersInfo.ADUserName);
                        }
                        SaveItemWithDataTableType.SaveItemWithoutDelete<MMCapacityHumanUnitsInfo>(obj.HumanFocusedList, "MMCapacityHumanUnitID", "MMCapacityHumanUnits", 0, BOSApp.CurrentUsersInfo.ADUserName);
                    }
                    BOSApp.ShowMessage("Cập nhật thành công!");
                }
            }
        }
        public void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMOperationDetailPlanCapacityItemsInfo item = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (e.Column.FieldName == "MMOperationDetailPlanCapacityItemProductQty")
                {
                    if (item != null)
                    {
                        if (item.ItemStatus != DetailPlanItemChildStatus.JobCreated.ToString())
                        {
                            BOSApp.ShowMessage("Trạng thái thẻ không phù hợp, bạn chỉ được xem!");
                            item.MMOperationDetailPlanCapacityItemProductQty = decimal.Parse(gridView.ActiveEditor.OldEditValue != null ? gridView.ActiveEditor.OldEditValue.ToString() : "0");
                            return;
                        }
                        if (item.MMOperationDetailPlanCapacityItemProductQty > item.MMOperationDetailPlanCapacityItemCompletedProductQty)
                        {
                            BOSApp.ShowMessage("Số lượng được phép thay đổi không thể lớn hơn SL đã nhập!");
                            item.MMOperationDetailPlanCapacityItemProductQty = decimal.Parse(gridView.ActiveEditor.OldEditValue != null ? gridView.ActiveEditor.OldEditValue.ToString() : "0");
                            return;
                        }
                    }
                }
                else if (e.Column.FieldName == "MMOperationDetailPlanCapacityItemFromTime" || e.Column.FieldName == "MMOperationDetailPlanCapacityItemToTime")
                {
                    if (item != null)
                    {
                        if ((item.MMOperationDetailPlanCapacityItemToTime - item.MMOperationDetailPlanCapacityItemFromTime).TotalMinutes >= 0)
                            item.MMOperationDetailPlanCapacityItemProcessTime = (decimal)(item.MMOperationDetailPlanCapacityItemToTime - item.MMOperationDetailPlanCapacityItemFromTime).TotalMinutes;
                        else
                        {
                            BOSApp.ShowMessage("Thời gian kết thúc nhỏ hơn thời gian bắt đầu !");
                            item.MMOperationDetailPlanCapacityItemProductQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                            return;
                        }
                    }
                }
            }
        }

        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "MMOperationDetailPlanCapacityItemProductQty" ||
                    e.Column.FieldName == "MMOperationDetailPlanCapacityItemFailProductQty" ||
                    e.Column.FieldName == "MMOperationDetailPlanCapacityItemProcessTime" ||
                    e.Column.FieldName == "MMOperationDetailPlanCapacityItemFromTime" ||
                    e.Column.FieldName == "MMOperationDetailPlanCapacityItemToTime" ||
                    e.Column.FieldName == "MMOperationDetailPlanCapacityItemLossTime" ||
                    e.Column.FieldName == "MMOperationDetailPlanCapacityItemCanSync")
                {
                    if (e.Column.FieldName != "MMOperationDetailPlanCapacityItemCanSync")
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 9, FontStyle.Bold);
                        e.Appearance.BackColor = Color.PaleTurquoise;
                        e.Appearance.BackColor2 = Color.PaleTurquoise;
                    }
                    MMOperationDetailPlanCapacityItemsInfo obj = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetRow(e.RowHandle);
                    if (obj.IsError)
                    {
                        e.Appearance.BackColor = Color.Red;
                        e.Appearance.BackColor2 = Color.Red;
                    }

                }
                if (e.Column.FieldName == "MMOperationDetailPlanCapacityItemPlanProductQty"
                    || e.Column.FieldName == "MMOperationDetailPlanCapacityItemCompletedProductQty"
                    || e.Column.FieldName == "MMOperationDetailPlanCapacityItemFailProductQty"
                    || e.Column.FieldName == "MMOperationDetailPlanCapacityItemProcessTime")
                {
                    e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 9, FontStyle.Bold);
                }
            }
        }
    }
}
