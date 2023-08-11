using BOSCommon;
using BOSComponent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;

namespace BOSERP.Modules.JobTicket
{
    public class MMJobTicketItemSelectViewsGridControl : BOSGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            foreach (GridColumn column in gridView.Columns)
            {
                if (column.FieldName == "MMJobTicketItemTodoQty"
                    || column.FieldName == "MMJobTicketItemExecutionFromDate"
                    || column.FieldName == "MMJobTicketItemExecutionToDate")
                {
                    column.OptionsColumn.AllowEdit = true;
                }
            }

            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.OptionsView.ShowAutoFilterRow = false;
            gridView.OptionsView.ShowFooter = false;
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            return gridView;
        }


        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();

            column.Caption = "Chọn";
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            column.VisibleIndex = 1;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã chi tiết";
            column.FieldName = "FK_ICProductID";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Tên chi tiết";
            column.FieldName = "MMOperationDetailPlanItemChildProductName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Loại gỗ";
            column.FieldName = "MMOperationDetailPlanItemChildProductWoodType";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "SL đã giao";
            column.FieldName = "MMJobTicketItemDeliveryQty";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Lệnh SX";
            column.FieldName = "FK_MMBatchProductID";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã kế hoạch";
            column.FieldName = "MMOperationDetailPlanNo";
            column.OptionsColumn.AllowEdit = true;
            column.Visible = true;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã thành phẩm";
            column.FieldName = "MMOperationDetailPlanItemChildProductForBatchNo";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 10;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã lô SX";
            column.FieldName = "MMOperationDetailPlanItemChildProductSerial";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 11;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã cụm";
            column.FieldName = "MMOperationDetailPlanItemChildParentNo";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 12;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Nhân công";
            column.FieldName = "Employee";
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
                if (obj != null)
                {
                    BOSERP.Modules.JobTicket.guiChooseDetailPlan form = (BOSERP.Modules.JobTicket.guiChooseDetailPlan)this.Screen;
                    if (form != null)
                        form.GetDataEmployee(obj);
                }
            }
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                MMJobTicketItemsInfo item = (MMJobTicketItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (e.Column.FieldName == "MMJobTicketItemTodoQty")
                {
                    if (item != null)
                    {
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
            }
        }
        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "MMJobTicketItemTodoQty")
                {
                    if (e.RowHandle >= 0)
                    {
                        MMJobTicketItemsInfo obj = (MMJobTicketItemsInfo)gridView.GetRow(e.RowHandle);
                        if (obj != null && obj.IsError)
                        {
                            e.Appearance.BackColor = Color.Red;
                            e.Appearance.BackColor2 = Color.Red;

                        }

                    }
                    e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 9, FontStyle.Bold);
                }
                if (e.Column.FieldName == "MMJobTicketItemReceiptQty")
                {
                    e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 9, FontStyle.Bold);
                }
            }
        }
        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Cancel")
            {
                GridView gridView = (GridView)MainView;
                MMJobTicketItemsInfo bp = (MMJobTicketItemsInfo)gridView.GetFocusedRow();
                if (bp != null)
                {
                    if (bp.MMJobTicketItemStatus == Status.Canceled.ToString())
                    {
                        e.DisplayText = string.Empty;
                    }
                }
            }
            if (e.Column.FieldName == "FK_MMBatchProductID")
            {
                if (e.Value != null)
                {
                    int objectID = 0;
                    Int32.TryParse(e.Value.ToString(), out objectID);
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("MMBatchProducts", "MMBatchProductID", objectID, "MMBatchProductNo");
                }
            }
        }

    }
}
