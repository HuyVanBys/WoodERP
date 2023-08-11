using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using System.Data;
using System.Drawing;

namespace BOSERP.Modules.LumberProduct
{
    partial class SearchProductsGridControl : BOSSearchResultsGridControl
    {
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            //gridView.RowStyle += new RowStyleEventHandler(gridView_RowStyle);
            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductTypeAccountConfigID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProductTypeAccountConfigs", "ICProductTypeAccountConfigID", int.Parse(e.Value.ToString()), "ICProductTypeAccountConfigName");
                }
            }
        }
    }
}
