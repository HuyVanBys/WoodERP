using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public partial class RP105MMWoodPlansGridControl : ReportGridControl
    {

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "MMWoodPlanNo";
            column.Caption = "Mã hoạch định";
            gridView.Columns.Add(column);


        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn column in gridView.Columns)
            {


                if (column.FieldName == "MMWoodPlanItemDetailProductName")
                {
                    column.Group();
                }
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
                //if (column.FieldName == "MMWoodPlanNo")
                //{
                //    column.Group();
                //}
                //column.OptionsColumn.AllowEdit = false;
                //column.Visible = true;
                if (column.FieldName == "MMWoodPlanItemDetailHeight")
                {
                    column.Group();
                }
                column.OptionsColumn.AllowEdit = false;
                column.Visible = true;
            }
            return gridView;
        }

    }
}
