using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace BOSERP.Modules.OperationDetailPlan
{
    public class MMCapacityItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CapacityDataList;
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
            column.Caption = "Lịch sử";
            column.FieldName = "History";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMOperationDetailPlanCapacityItemCanSync";
            column.Caption = "SL đồng bộ tối đa";
            column.Visible = true;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:n}";
            gridView.Columns.Add(column);
        }
        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMOperationDetailPlanCapacityItemsInfo obj = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null && obj.MMOperationDetailPlanCapacityItemSyncProductCheck)
                {
                    guiViewSync gui = new guiViewSync();
                    gui.NormID = obj.FK_MMBatchProductProductionNormItemID;
                    gui.OperationID = obj.FK_MMOperationID;
                    gui.PlanQty = obj.MMOperationDetailPlanCapacityItemPlanProductQty;
                    gui.Module = this.Screen.Module;
                    gui.Show();
                    obj.MMOperationDetailPlanCapacityItemCanSync = gui.SyncPerCent * obj.MMOperationDetailPlanCapacityItemRemainProductQty;
                }

            }
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
                    || col.FieldName == "FK_HRToDepartmentRoomGroupItemID"
                    || col.FieldName == "MMOperationDetailPlanCapacityItemFromTime"
                    || col.FieldName == "MMOperationDetailPlanCapacityItemToTime"
                    || col.FieldName == "MMOperationDetailPlanCapacityItemLossTime"
                    || col.FieldName == "Selected")
                    col.OptionsColumn.AllowEdit = true;

                if (col.FieldName == "MMOperationDetailPlanCapacityItemCanSync")
                {
                    col.OptionsColumn.AllowEdit = true;
                    RepositoryItemHyperLinkEdit buttonEdit = new RepositoryItemHyperLinkEdit();
                    buttonEdit.NullText = "Xem";
                    buttonEdit.Click += new EventHandler(ButtonEdit_ButtonClick);
                    col.ColumnEdit = buttonEdit;
                }
                else if (col.FieldName == "History")
                {
                    col.OptionsColumn.AllowEdit = true;
                    RepositoryItemHyperLinkEdit linkEdit = new RepositoryItemHyperLinkEdit();
                    linkEdit.NullText = "Xem";
                    linkEdit.Click += new EventHandler(rep2_Click);
                    col.ColumnEdit = linkEdit;
                }
                else if (col.FieldName == "MMOperationDetailPlanCapacityItemFromTime" || col.FieldName == "MMOperationDetailPlanCapacityItemToTime")
                {
                    FormatNumbericColumn(col, true, "dd/MM/yyyy hh:mm tt", DevExpress.XtraEditors.Mask.MaskType.DateTime, FormatType.DateTime);
                }
            }
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridView_CellValueChanged);
            gridView.KeyDown += new KeyEventHandler(gridView_KeyDown);
            gridView.KeyUp += new KeyEventHandler(gridView_KeyUp);
            gridView.DoubleClick += GridView_DoubleClick;
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
        private void ButtonEdit_ButtonClick(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMOperationDetailPlanCapacityItemsInfo obj = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null && obj.MMOperationDetailPlanCapacityItemSyncProductCheck)
                {
                    guiViewSync gui = new guiViewSync();
                    gui.NormID = obj.FK_MMBatchProductProductionNormItemID;
                    gui.OperationID = obj.FK_MMOperationID;
                    gui.PlanQty = obj.MMOperationDetailPlanCapacityItemPlanProductQty;
                    gui.Module = this.Screen.Module;
                    gui.Show();
                    obj.MMOperationDetailPlanCapacityItemCanSync = Math.Round(gui.SyncPerCent * obj.MMOperationDetailPlanCapacityItemTotalProductQty, 1);
                }

            }
        }

        void gridView_KeyUp(object sender, KeyEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                if (gridView.FocusedColumn.FieldName == "MMOperationDetailPlanCapacityItemProductQty")
                {
                    MMOperationDetailPlanCapacityItemsInfo item = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (item != null && item.MMOperationDetailPlanCapacityItemProductQty == 0)
                        item.MMOperationDetailPlanCapacityItemProductQty = item.MMOperationDetailPlanCapacityItemPlanProductQty - item.MMOperationDetailPlanCapacityItemCompletedProductQty;

                }
            }
        }

        void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                if (gridView.FocusedColumn.FieldName == "MMOperationDetailPlanCapacityItemProductQty")
                {
                    MMOperationDetailPlanCapacityItemsInfo item = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (item != null && item.MMOperationDetailPlanCapacityItemProductQty == 0)
                        item.MMOperationDetailPlanCapacityItemProductQty = item.MMOperationDetailPlanCapacityItemPlanProductQty - item.MMOperationDetailPlanCapacityItemCompletedProductQty;

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
                        OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                        if (!((OperationDetailPlanModule)this.Screen.Module).SyncTicketItem(item, entity.CapacityDataList))
                        {
                            guiViewSync gui = new guiViewSync();
                            gui.NormID = item.FK_MMBatchProductProductionNormItemID;
                            gui.OperationID = item.FK_MMOperationID;
                            gui.PlanQty = item.MMOperationDetailPlanCapacityItemPlanProductQty;
                            gui.Module = this.Screen.Module;
                            gui.ShowDialog();
                            item.MMOperationDetailPlanCapacityItemProductQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                            return;
                        }
                        if (item.MMOperationDetailPlanCapacityItemProductQty > (item.MMOperationDetailPlanCapacityItemPlanProductQty - item.MMOperationDetailPlanCapacityItemCompletedProductQty))
                        {
                            BOSApp.ShowMessage("Số lượng cần làm không thể lớn hơn SL kế hoạch còn lại!");
                            item.MMOperationDetailPlanCapacityItemProductQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                            return;
                        }
                        item.IsError = false;
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
                    e.Column.FieldName == "MMOperationDetailPlanCapacityItemCanSync")
                {
                    if (e.Column.FieldName != "MMOperationDetailPlanCapacityItemCanSync")
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 9, FontStyle.Bold);
                        e.Appearance.BackColor = Color.PaleTurquoise;
                        e.Appearance.BackColor2 = Color.PaleTurquoise;
                    }
                    else
                    {
                        e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 9, FontStyle.Bold);
                        e.Appearance.BackColor = Color.Orange;
                        e.Appearance.BackColor2 = Color.Orange;
                    }
                    MMOperationDetailPlanCapacityItemsInfo obj = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetRow(e.RowHandle);
                    if (obj != null && obj.IsError && e.Column.FieldName == "MMOperationDetailPlanCapacityItemProductQty")
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

        void rep2_Click(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                OperationDetailPlanEntities entity = (OperationDetailPlanEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
                MMOperationDetailPlansInfo mainObject = (MMOperationDetailPlansInfo)entity.MainObject;
                MMOperationDetailPlanCapacityItemsInfo obj = (MMOperationDetailPlanCapacityItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null)
                {
                    guiViewEditCapacity gui = new guiViewEditCapacity();
                    gui.NormID = obj.FK_MMBatchProductProductionNormItemID;
                    gui.OperationID = obj.FK_MMOperationID;
                    gui.Fromdate = mainObject.MMOperationDetailPlanFromDate;
                    gui.Todate = DateTime.Now;
                    gui.BatchID = obj.FK_MMBatchProductID;
                    gui.ProductOfBatchID = obj.FK_ICProductForBatchID;
                    gui.SemiProductNo = obj.MMOperationDetailPlanCapacityItemProductNo;
                    gui.SemiProductName = obj.MMOperationDetailPlanCapacityItemProductName;
                    gui.Module = this.Screen.Module;
                    gui.ShowDialog();
                }
            }
        }

    }
}
