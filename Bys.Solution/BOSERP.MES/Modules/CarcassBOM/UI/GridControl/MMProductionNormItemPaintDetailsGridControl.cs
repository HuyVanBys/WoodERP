using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.CarcassBOM
{
    public class MMProductionNormItemPaintDetailsGridControl : BOSGridControl
    {
        public void InitGridControlDataSource(List<MMProductionNormItemPaintDetailsInfo> itemPaintDetails)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = itemPaintDetails;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            foreach (GridColumn col in gridView.Columns)
            {
                col.OptionsColumn.AllowEdit = false;
            }
            GridColumn gridColumn = gridView.Columns["MMProductionNormItemPaintDetailProductNo"];
            if (gridColumn != null)
            {
                gridColumn.Group();
            }
            gridView.EndGrouping += GridView_EndGrouping;
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            return gridView;
        }

        private void GridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (gridView == null)
                return;

            gridView.ExpandAllGroups();
        }
        private void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridView gridView = (GridView)MainView;
            MMProductionNormItemPaintDetailsInfo objProductionNormItemPaintDetailsInfo = (MMProductionNormItemPaintDetailsInfo)gridView.GetRow(e.ListSourceRowIndex);
            if (objProductionNormItemPaintDetailsInfo == null)
                return;

            if (e.Column.FieldName == "FK_ICProductID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICProducts", "ICProductID", int.Parse(e.Value.ToString()), "ICProductNo");
                }
            }
        }
    }
}
