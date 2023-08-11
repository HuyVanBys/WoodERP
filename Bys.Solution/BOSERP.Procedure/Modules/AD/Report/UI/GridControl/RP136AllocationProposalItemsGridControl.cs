using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public class RP136AllocationProposalItemsGridControl : BOSGridControl
    {
        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "HREmployeeName";
            column.Caption = ReportLocalizedResources.HREmployeeName;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "HREmployeeName1";
            column.Caption = ReportLocalizedResources.HREmployeeName1;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 7;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "HRDepartmentName";
            column.Caption = ReportLocalizedResources.HRDepartmentName;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 8;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "HRDepartmentRoomName";
            column.Caption = ReportLocalizedResources.HRDepartmentRoomName;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 9;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ADConfigText";
            column.Caption = ReportLocalizedResources.ADConfigText;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 10;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMAllocationProposalNo";
            column.Caption = ReportLocalizedResources.AllocationProposalNo;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "MMAllocationProposalDate";
            column.Caption = ReportLocalizedResources.DocumentDate;
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 11;
            gridView.Columns.Add(column);

        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["FK_ICMeasureUnitID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
                column.VisibleIndex = 5;
            }
            column = gridView.Columns["FK_ICProductID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
                column.VisibleIndex = 3;
            }
            column = gridView.Columns["MMAllocationProposalItemProductName"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
                column.VisibleIndex = 4;
            }
            column = gridView.Columns["MMAllocationProposalItemQty"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
                column.VisibleIndex = 6;
            }
            column = gridView.Columns["MMAllocationProposalItemComment"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
                column.VisibleIndex = 12;
            }
            return gridView;
        }
        protected override void GridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            DateTime value = DateTime.Now;
            if (e.CellValue != null && (e.Column.FieldName == "MMAllocationProposalDate"))
            {
                if (DateTime.TryParse(e.CellValue.ToString(), out value))
                {
                    if (value.Date == DateTime.MinValue.Date)
                    {
                        e.DisplayText = "";
                    }
                    if (value.Date == DateTime.MaxValue.Date)
                    {
                        e.DisplayText = "";
                    }
                }
            }

        }


    }
}
