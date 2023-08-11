using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;


namespace BOSERP.Modules.AllocationProposal
{
    public partial class MMAllocationPlanItemSearchResultGridControl : BOSSearchResultsGridControl
    {

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "MMAllocationPlanApprovedDate" ||
                e.Column.FieldName == "MMAllocationPlanDiscardDate" ||
                e.Column.FieldName == "MMAllocationPlanDeliveryDate" ||
                e.Column.FieldName == "MMAllocationPlanValidateDate")
            {
                if (e.Value != null)
                {
                    DateTime Date = DateTime.Parse(e.Value.ToString());
                    if (Date.Date == DateTime.MaxValue.Date)
                        e.DisplayText = "";
                }
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn gridColumn = new GridColumn();
            gridColumn.FieldName = "EmployeeReceiveName";
            gridColumn.Caption = "Người nhận";
            gridColumn.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(gridColumn);
        }
    }
}
