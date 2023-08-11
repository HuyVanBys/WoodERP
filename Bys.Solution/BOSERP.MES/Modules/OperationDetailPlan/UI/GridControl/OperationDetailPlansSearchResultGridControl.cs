using DevExpress.XtraGrid.Views.Base;
using System;


namespace BOSERP.Modules.OperationDetailPlan
{
    public partial class OperationDetailPlansSearchResultGridControl : BOSSearchResultsGridControl
    {

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            return gridView;
        }
        void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "MMOperationDetailPlanToApprovedDate" ||
                e.Column.FieldName == "MMOperationDetailPlanFromDate" ||
                e.Column.FieldName == "MMOperationDetailPlanToDate")
            {
                if (e.Value != null)
                {
                    DateTime Date = DateTime.Parse(e.Value.ToString());
                    if (Date.Date == DateTime.MaxValue.Date)
                        e.DisplayText = "";
                }

            }
        }
    }
}
