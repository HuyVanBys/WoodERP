using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.PriceSheet
{
    public class ICProductsGridControl : BOSGridControl
    {
        public void InvalidateDataSource(BOSList<ICProductsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            GridColumn column = gridView.Columns["ARCustomerName"];
            //if (column != null)
            //{
            //    gridView.Columns.Remove(column);
            //}
            column = gridView.Columns["FK_ICDepartmentID"];
            if (column != null)
            {
                column.Group();
            }
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            column = new GridColumn();
            column.Caption = BaseLocalizedResources.Select;
            column.FieldName = "Selected";
            column.OptionsColumn.AllowEdit = true;
            gridView.Columns.Insert(0, column);
            column.VisibleIndex = 0;
            gridView.ExpandAllGroups();
            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICDepartmentID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICDepartments", "ICDepartmentID", int.Parse(e.Value.ToString()), "ICDepartmentName");
                }
            }
        }

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            gridView.ExpandAllGroups();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }
    }
}
