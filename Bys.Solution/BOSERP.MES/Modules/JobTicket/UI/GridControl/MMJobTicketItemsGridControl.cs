using BOSCommon;
using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.JobTicket
{
    public class MMJobTicketItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            JobTicketEntities entity = (JobTicketEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.JobTicketItem;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "MMJobTicketItemTodoQty"
                    || column.FieldName == "MMJobTicketItemExecutionFromDate"
                    || column.FieldName == "MMJobTicketItemExecutionToDate"
                    || column.FieldName == "MMJobTicketItemDesc"
                   )
                    column.OptionsColumn.AllowEdit = true;
            }

            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.OptionsView.ShowFooter = false;
            gridView.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridView_CellValueChanging);
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            gridView.DoubleClick += new EventHandler(gridView_DoubleClick);

            return gridView;
        }

        void gridView_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                if (gridView.FocusedColumn.FieldName == "MMJobTicketItemReceiptQty")
                {
                    MMJobTicketItemsInfo obj = (MMJobTicketItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (obj != null)
                    {
                        obj.Selected = true;
                        ((JobTicketModule)Screen.Module).UpdateJobticketQty(obj);
                    }
                }
            }

        }
        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.Column.FieldName == "MMJobTicketItemStatus")
            {
                if (e.RowHandle >= 0)
                {
                    MMJobTicketItemsInfo obj = (MMJobTicketItemsInfo)gridView.GetRow(e.RowHandle);
                    if (obj.MMJobTicketItemStatus == Status.New.ToString())
                    {
                        e.Appearance.BackColor = Color.White;
                        e.Appearance.BackColor2 = Color.White;
                    }
                    else if (obj.MMJobTicketItemStatus == Status.Canceled.ToString())
                    {
                        e.Appearance.BackColor = Color.Gainsboro;
                        e.Appearance.BackColor2 = Color.Gainsboro;
                    }
                    else if (obj.MMJobTicketItemStatus == Status.Approved.ToString())
                    {
                        e.Appearance.BackColor = Color.PaleTurquoise;
                        e.Appearance.BackColor2 = Color.PaleTurquoise;
                    }
                    else if (obj.MMJobTicketItemStatus == Status.Closed.ToString())
                    {
                        e.Appearance.BackColor = Color.Blue;
                        e.Appearance.BackColor2 = Color.Blue;
                    }
                }
            }
            if (e.Column.FieldName == "MMJobTicketItemReceiptQty")
            {
                if (e.RowHandle >= 0)
                {
                    MMJobTicketItemsInfo obj = (MMJobTicketItemsInfo)gridView.GetRow(e.RowHandle);
                    if (obj.MMJobTicketItemStatus == Status.Approved.ToString())
                    {
                        e.Appearance.BackColor = Color.LightGoldenrodYellow;
                        e.Appearance.BackColor2 = Color.LightGoldenrodYellow;
                        e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 9, FontStyle.Underline);
                    }
                }
            }

            if (e.Column.FieldName == "MMOperationDetailPlanItemChildProductName")
            {
                if (e.RowHandle >= 0)
                {
                    MMJobTicketItemsInfo obj = (MMJobTicketItemsInfo)gridView.GetRow(e.RowHandle);
                    if (obj.IsError)
                    {
                        e.Appearance.BackColor = Color.Red;
                        e.Appearance.BackColor2 = Color.Red;

                    }
                }
            }
            if (e.Column.FieldName == "MMJobTicketItemTodoQty")
            {
                e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 9, FontStyle.Bold);
            }
            if (e.Column.FieldName == "MMJobTicketItemExecutionToDate")
            {
                if (e.RowHandle >= 0)
                {
                    DateTime serverDate = BOSApp.GetCurrentServerDate();
                    MMJobTicketItemsInfo obj = (MMJobTicketItemsInfo)gridView.GetRow(e.RowHandle);
                    if (obj.MMJobTicketItemExecutionToDate <= serverDate)
                    {
                        if ((obj.MMJobTicketItemStatus == Status.Approved.ToString() || obj.MMJobTicketItemStatus == Status.New.ToString())
                            && (obj.MMJobTicketItemTodoQty > obj.MMJobTicketItemReceiptQty))
                        {
                            e.Appearance.BackColor = Color.Red;
                            e.Appearance.BackColor2 = Color.Red;
                        }
                    }
                }
            }
        }
        void gridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            JobTicketEntities entity = (JobTicketEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.JobTicketItem.CurrentIndex >= 0)
            {
                if (e.Column.FieldName == "Selected")
                    ((JobTicketModule)Screen.Module).IsChooseItemEdit = true;
                else
                    ((JobTicketModule)Screen.Module).IsChooseItemEdit = false;
            }
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Chọn";
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            column.VisibleIndex = 1;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Lệnh SX";
            column.FieldName = "FK_MMBatchProductID";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã kế hoạch";
            column.FieldName = "MMOperationDetailPlanNo";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã thành phẩm";
            column.FieldName = "MMOperationDetailPlanItemChildProductForBatchNo";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã lô SX";
            column.FieldName = "MMOperationDetailPlanItemChildProductSerial";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã cụm";
            column.FieldName = "MMOperationDetailPlanItemChildParentNo";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã chi tiết";
            column.FieldName = "MMOperationDetailPlanItemChildProductNo";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Tên chi tiết";
            column.FieldName = "MMOperationDetailPlanItemChildProductName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Loại gỗ";
            column.FieldName = "MMOperationDetailPlanItemChildProductWoodType";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Nhân công";
            column.FieldName = "Employee";
            column.VisibleIndex = 10;
            column.OptionsColumn.AllowEdit = true;
            RepositoryItemHyperLinkEdit rep2 = new RepositoryItemHyperLinkEdit();
            rep2.NullText = "Chi tiết";
            rep2.Click += new EventHandler(rep2_Click);
            column.ColumnEdit = rep2;
            gridView.Columns.Add(column);
        }

        void rep2_Click(object sender, EventArgs e)
        {
            GridView gridView = this.MainView as GridView;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMJobTicketItemsInfo obj = (MMJobTicketItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (obj != null && obj.MMJobTicketItemStatus == Status.New.ToString())
                {
                    ((JobTicketModule)Screen.Module).GetDataEmployee(obj, false);
                }
                else if (obj != null && obj.MMJobTicketItemStatus != Status.New.ToString())
                {
                    BOSApp.ShowMessage("Trạng thái chứng từ không phù hợp, bạn chỉ có thể xem!");
                    ((JobTicketModule)Screen.Module).GetDataEmployee(obj, true);

                }
            }
        }
        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_MMBatchProductID" && e.Value != null)
            {
                int objectID = 0;
                Int32.TryParse(e.Value.ToString(), out objectID);
                e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMBatchProducts", "MMBatchProductID", objectID, "MMBatchProductNo");
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                GridView gridView = (GridView)MainView;
                MMJobTicketItemsInfo bp = (MMJobTicketItemsInfo)gridView.GetFocusedRow();
                ((JobTicketModule)Screen.Module).RemoveItem(bp);
            }
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                JobTicketEntities entity = (JobTicketEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
                MMJobTicketItemsInfo item = (MMJobTicketItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (e.Column.FieldName == "MMJobTicketItemTodoQty")
                {
                    if (entity.JobTicketItem.CurrentIndex >= 0 && item != null)
                    {
                        if (item.MMJobTicketItemStatus != Status.New.ToString())
                        {
                            BOSApp.ShowMessage("Bạn chỉ được thay đổi thẻ có tình trạng tạo mới!");
                            item.MMJobTicketItemTodoQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                            return;
                        }
                        if (item.MMJobTicketItemTodoQty > (item.MMJobTicketItemPlanQty - item.MMJobTicketItemDeliveryQty))
                        {
                            BOSApp.ShowMessage("Số lượng cần làm không thể lớn hơn SL kế hoạch còn lại!");
                            item.MMJobTicketItemTodoQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                            return;
                        }
                        if (item.MMJobTicketItemTodoQty < 0)
                        {
                            BOSApp.ShowMessage("Số lượng cần làm không thể nhỏ hơn 0!");
                            item.MMJobTicketItemTodoQty = decimal.Parse(gridView.ActiveEditor.OldEditValue.ToString());
                            return;
                        }

                    }
                }
                if (e.Column.FieldName == "MMJobTicketItemExecutionFromDate"
                    || e.Column.FieldName == "MMJobTicketItemExecutionToDate")
                {
                    if (entity.JobTicketItem.CurrentIndex >= 0 && item != null)
                    {
                        if (item.MMJobTicketItemStatus != Status.New.ToString())
                        {
                            DateTime value = DateTime.Now;
                            BOSApp.ShowMessage("Bạn chỉ được thay đổi thẻ có tình trạng tạo mới!");
                            if (e.Column.FieldName == "MMJobTicketItemExecutionFromDate"
                                && DateTime.TryParse(gridView.ActiveEditor.OldEditValue.ToString(), out value))
                            {
                                item.MMJobTicketItemExecutionFromDate = value;
                            }
                            if (e.Column.FieldName == "MMJobTicketItemExecutionToDate"
                                && DateTime.TryParse(gridView.ActiveEditor.OldEditValue.ToString(), out value))
                            {
                                item.MMJobTicketItemExecutionToDate = value;
                            }
                            return;
                        }
                    }
                }

            }
        }
    }
}
