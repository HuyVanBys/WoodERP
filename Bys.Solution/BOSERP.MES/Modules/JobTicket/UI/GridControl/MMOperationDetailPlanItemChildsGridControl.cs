using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP.Modules.JobTicket
{
    public class MMOperationDetailPlanItemChildsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            JobTicketEntities entity = (JobTicketEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.DetailPlanList;
            this.DataSource = bds;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
            return gridView;
        }

        void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "MMOperationDetailPlanNo" || e.Column.FieldName == "MMOperationDetailPlanItemChildProductNo")
                {
                    if (e.CellValue != null && (e.CellValue.ToString()).Trim() != string.Empty)
                    {
                        if (e.RowHandle >= 0)
                        {
                            MMOperationDetailPlanItemChildsInfo obj = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(e.RowHandle);
                            Color result = GetColorFilter(obj);
                            e.Appearance.BackColor = result;
                            e.Appearance.BackColor2 = result;
                        }
                    }
                }
                if (e.Column.FieldName == "MMOperationDetailPlanItemChildExecutionToDate")
                {
                    if (e.CellValue != null && (e.CellValue.ToString()).Trim() != string.Empty)
                    {
                        if (e.RowHandle >= 0)
                        {
                            MMOperationDetailPlanItemChildsInfo obj = (MMOperationDetailPlanItemChildsInfo)gridView.GetRow(e.RowHandle);
                            Color result = GetLateColor(obj);
                            e.Appearance.BackColor = result;
                            e.Appearance.BackColor2 = result;
                        }
                    }
                }
                if (e.Column.FieldName == "MMJobTicketItemTodoQty" || e.Column.FieldName == "MMOperationDetailPlanItemChildPlanProductQty")
                {
                    e.Appearance.Font = new Font(e.Appearance.Font.FontFamily, 9, FontStyle.Bold);
                }
            }
        }
        public Color GetColorFilter(MMOperationDetailPlanItemChildsInfo obj)
        {
            Color result = Color.White;
            DateTime serverDate = BOSApp.GetCurrentServerDate();

            if (obj.MMJobTicketItemTodoQty == obj.MMOperationDetailPlanItemChildPlanProductQty - obj.MMOperationDetailPlanItemChildCancelQty)
                result = Color.White;
            if (obj.MMJobTicketItemTodoQty < obj.MMOperationDetailPlanItemChildPlanProductQty - obj.MMOperationDetailPlanItemChildCancelQty && obj.MMJobTicketItemTodoQty > 0)
                result = Color.Yellow;
            if (obj.MMJobTicketItemPlanReceiptQty == obj.MMOperationDetailPlanItemChildPlanProductQty - obj.MMOperationDetailPlanItemChildCancelQty)
                result = Color.Blue;
            return result;
        }
        public Color GetLateColor(MMOperationDetailPlanItemChildsInfo obj)
        {
            Color result = Color.White;
            DateTime serverDate = BOSApp.GetCurrentServerDate();

            if (obj.MMOperationDetailPlanItemChildExecutionToDate <= serverDate
                //tạm thời sài  SL da nhap theo KH
                && obj.MMJobTicketItemPlanReceiptQty <= obj.MMOperationDetailPlanItemChildPlanProductQty - obj.MMOperationDetailPlanItemChildCancelQty)
                result = Color.Red;
            return result;
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
            column.Caption = "Mã lô SX";
            column.FieldName = "MMOperationDetailPlanItemChildProductSerial";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            //column = new DevExpress.XtraGrid.Columns.GridColumn();
            //column.Caption = "Mã c.tiết/cụm";
            //column.FieldName = "FK_ICProductID";
            //column.OptionsColumn.AllowEdit = false;
            //column.VisibleIndex = 3;
            //gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Tên c.tiết/cụm";
            column.FieldName = "MMOperationDetailPlanItemChildProductName";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "SL hoạch định";
            column.FieldName = "MMOperationDetailPlanItemChildPlanProductQty";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "SL chưa giao việc";
            column.FieldName = "MMJobTicketItemTodoQty";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "SL đã giao";
            column.FieldName = "MMJobTicketItemDeliveryQty";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Ngày giao gần nhất";
            column.FieldName = "MMJobTicketItemExecutionMaxDate";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "SL CT/SP";
            column.FieldName = "MMOperationDetailPlanItemChildProductQty";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "SL đã hủy";
            column.FieldName = "MMOperationDetailPlanItemChildCancelQty";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 10;
            gridView.Columns.Add(column);
            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Từ ngày";
            column.FieldName = "MMOperationDetailPlanItemChildExecutionFromDate";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 11;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Đến ngày";
            column.FieldName = "MMOperationDetailPlanItemChildExecutionToDate";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 12;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Ghi chú đặc tính";
            column.FieldName = "MMOperationDetailPlanItemChildComment";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 13;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Dày";
            column.FieldName = "MMOperationDetailPlanItemChildProductHeight";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 14;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Rộng";
            column.FieldName = "MMOperationDetailPlanItemChildProductWidth";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 15;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Dài";
            column.FieldName = "MMOperationDetailPlanItemChildProductLength";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 16;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Loại gỗ";
            column.FieldName = "MMOperationDetailPlanItemChildProductWoodType";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 17;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "KHSX CT";
            column.FieldName = "MMOperationDetailPlanNo";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 18;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Mã SP";
            column.FieldName = "MMOperationDetailPlanItemChildProductForBatchNo";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 19;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "ĐBH";
            column.FieldName = "ARSaleOrderNo";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 20;
            gridView.Columns.Add(column);

            column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = "Tên K.hàng";
            column.FieldName = "ARCustomerName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 20;
            gridView.Columns.Add(column);
        }
    }
}
