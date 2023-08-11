using DevExpress.XtraGrid.Columns;
using Localization;
using System;

namespace BOSERP.Modules.Report
{
    public partial class HRRP019EmployeesGridControl : ReportGridControl
    {
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;
            gridView.OptionsBehavior.Editable = false;
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);

            InitColumnSummary("TotalSaleAmount", DevExpress.Data.SummaryItemType.Sum);
            InitColumnSummary("TotalSaleQty", DevExpress.Data.SummaryItemType.Sum);
            GridColumn column = gridView.Columns["FK_HRDepartmentRoomID"];
            if (column != null)
                column.Group();
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = ReportLocalizedResources.TotalSaleAmount;
            column.FieldName = "TotalSaleAmount";
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = ReportLocalizedResources.TotalSaleQty;
            column.FieldName = "TotalSaleQty";
            gridView.Columns.Add(column);
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ((RP019)Screen).SwitchView();
        }
    }
}
