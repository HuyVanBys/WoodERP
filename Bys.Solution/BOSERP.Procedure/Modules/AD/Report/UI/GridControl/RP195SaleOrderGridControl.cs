using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.Report
{
    public partial class RP195SaleOrderGridControl : ReportGridControl
    {
        Dictionary<string, string> RP195Columns = new Dictionary<string, string>()
        {
            {"JanuaryRevenuePlan","01-KH"}
            ,{"JanuaryRevenue","01-TH"}
            ,{"JanuaryCompletionPercent","01-TLHT"}
            , {"FebruaryRevenuePlan","02-KH"}
            , {"FebruaryRevenue","02-TH"}
            , {"FebruaryCompletionPercent","02-TLHT"}
            , {"MarchRevenuePlan","03-KH"}
            , {"MarchRevenue","03-TH"}
            , {"MarchCompletionPercent","03-TLHT"}
            , {"AprilRevenuePlan","04-KH"}
            , {"AprilRevenue","04-TH"}
            , {"AprilCompletionPercent","04-TLHT"}
            , {"MayRevenuePlan","05-KH"}
            , {"MayRevenue","05-TH"}
            , {"MayCompletionPercent","05-TLHT"}
            , {"JuneRevenuePlan","06-KH"}
            , {"JuneRevenue","06-TH"}
            , {"JuneCompletionPercent","06-TLHT"}
            , {"JulyRevenuePlan","07-KH"}
            , {"JulyRevenue","07-TH"}
            , {"JulyCompletionPercent","07-TLHT"}
            , {"AugustRevenuePlan","08-KH"}
            , {"AugustRevenue","08-TH"}
            , {"AugustCompletionPercent","08-TLHT"}
            , {"SeptemberRevenuePlan","09-KH"}
            , {"SeptemberRevenue","09-TH"}
            , {"SeptemberCompletionPercent","09-TLHT"}
            , {"OctoberRevenuePlan","10-KH"}
            , {"OctoberRevenue","10-TH"}
            , {"OctoberCompletionPercent","10-TLHT"}
            , {"NovemberRevenuePlan","11-KH"}
            , {"NovemberRevenue","11-TH"}
            , {"NovemberCompletionPercent","11-TLHT"}
            , {"DecemberRevenuePlan","12-KH"}
            , {"DecemberRevenue","12-TH"}
            , {"DecemberCompletionPercent","12-TLHT"}
        };

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;
            GridColumn column = new GridColumn();
            RP195Columns.All(o =>
            {
                column = gridView.Columns[o.Key];
                if (column != null)
                {
                    column.SummaryItem.FieldName = o.Key;
                    column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                    column.SummaryItem.DisplayFormat = "{0:n3}";
                }
                return true;
            });
            column = gridView.Columns["SaleAmount"];
            column.SummaryItem.FieldName = "SaleAmount";
            column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            column.SummaryItem.DisplayFormat = "{0:n3}";
            return gridView;
        }

        protected override void AddColumnsToGridView(String strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            GridColumn column = new GridColumn();
            column.Caption = "Nhân viên bán hàng";
            column.FieldName = "HREmployeeName";
            column.OptionsColumn.AllowEdit = false;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);
            int i = 1;
            RP195Columns.All(o =>
            {

                column = new GridColumn();
                column.Caption = o.Value;
                column.FieldName = o.Key;
                column.VisibleIndex = i + 1;
                FormatNumbericColumn(column, false, "N3");
                gridView.Columns.Add(column);
                i++;
                return true;
            });
            column = new GridColumn();
            column.Caption = "Lũy kế";
            column.FieldName = "SaleAmount";
            column.VisibleIndex = i + 1;
            FormatNumbericColumn(column, false, "N3");
            gridView.Columns.Add(column);
        }

        private void FormatNumbericColumn(GridColumn column, bool allowEdit, string formatType)
        {
            column.OptionsColumn.AllowEdit = allowEdit;
            column.DisplayFormat.FormatType = FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:" + formatType + "}"; ;
        }
    }
}
