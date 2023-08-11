using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.Report
{
    public partial class RP211SaleOrderGridControl : ReportGridControl
    {
        Dictionary<string, string> RP195Columns = new Dictionary<string, string>()
        {
            {"JanuaryRevenuePlan","01-KH"}
            ,{"JanuaryRevenue","01-TH"}
            , {"FebruaryRevenuePlan","02-KH"}
            , {"FebruaryRevenue","02-TH"}
            , {"MarchRevenuePlan","03-KH"}
            , {"MarchRevenue","03-TH"}
            , {"AprilRevenuePlan","04-KH"}
            , {"AprilRevenue","04-TH"}
            , {"MayRevenuePlan","05-KH"}
            , {"MayRevenue","05-TH"}
            , {"JuneRevenuePlan","06-KH"}
            , {"JuneRevenue","06-TH"}
            , {"JulyRevenuePlan","07-KH"}
            , {"JulyRevenue","07-TH"}
            , {"AugustRevenuePlan","08-KH"}
            , {"AugustRevenue","08-TH"}
            , {"SeptemberRevenuePlan","09-KH"}
            , {"SeptemberRevenue","09-TH"}
            , {"OctoberRevenuePlan","10-KH"}
            , {"OctoberRevenue","10-TH"}
            , {"NovemberRevenuePlan","11-KH"}
            , {"NovemberRevenue","11-TH"}
            , {"DecemberRevenuePlan","12-KH"}
            , {"DecemberRevenue","12-TH"}
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
            column.Caption = "Nhóm hàng hóa";
            column.FieldName = "ProductType";
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
