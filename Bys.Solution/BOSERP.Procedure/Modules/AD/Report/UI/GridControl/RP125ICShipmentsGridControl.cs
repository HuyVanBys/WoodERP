using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public class RP125ICShipmentsGridControl : BOSGridControl
    {
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(gridView_FocusedRowChanged);
            gridView.OptionsView.ShowFooter = true;
            return gridView;
        }
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "MMBatchProductNo";
            column.Caption = ReportLocalizedResources.MMBatchProductNo;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ARCustomerName";
            column.Caption = ReportLocalizedResources.ARCustomerName;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICShipmentItemProductDesc";
            column.Caption = "Nguyên liệu";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ProductAttributeWoodType";
            column.Caption = ReportLocalizedResources.ProductAttributeWoodType;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ICShipmentItemHeight";
            column.Caption = "Dày";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "M3DinhMuc";
            column.Caption = ReportLocalizedResources.M3DinhMuc;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "M3ThucTeXuat";
            column.Caption = ReportLocalizedResources.M3ThucTeXuat;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "M3KHSD";
            column.Caption = ReportLocalizedResources.M3KHSD;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "M3LCP";
            column.Caption = "Khối lượng LCP";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "M3VuotDM";
            column.Caption = ReportLocalizedResources.M3VuotDM;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 10;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "M3ConLai";
            column.Caption = ReportLocalizedResources.M3ConLai;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 11;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMWoodPlanItemDetailDepreciationRate";
            column.Caption = ReportLocalizedResources.MMWoodPlanItemDepreciationRate;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 12;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "DepreciationRatePerBatchProduct";
            column.Caption = "Tỉ lệ tiêu hao theo LSX";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 13;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "M3TraVeTuLSX";
            column.Caption = "M3 trả về từ LSX";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 14;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "TongM3ThucTeXuat";
            column.Caption = "Tổng M3 thực tế xuất";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 15;
            gridView.Columns.Add(column);


        }
        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            DateTime value = DateTime.Now;
            if (e.CellValue != null && (e.Column.FieldName == "ACLoanReceiptDate" || e.Column.FieldName == "ACLoanReceiptDeadline"))
            {
                if (DateTime.TryParse(e.CellValue.ToString(), out value))
                {
                    if (value == DateTime.MinValue)
                    {
                        e.DisplayText = "";
                    }
                    if (value == DateTime.MaxValue)
                    {
                        e.DisplayText = "";
                    }
                }
            }

        }

        void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            base.GridView_FocusedRowChanged(sender, e);
            GridView gridView = (GridView)sender;
            if (gridView.FocusedColumn != null)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ICShipmentItemsInfo item = (ICShipmentItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                    if (item != null)
                    {
                        (((RP125)Screen)).GetAllData(item.BatchProductID, item.ICShipmentItemHeight, item.FK_ICProductAttributeWoodTypeID);
                    }
                }
            }
        }
    }
}
