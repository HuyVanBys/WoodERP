using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Template
{
    public class TemplateItemTasksGridControl : BOSGridControl
    {
        public void InvalidateDataSource(List<PMTemplateItemTasksInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();

            if (gridView.Columns["FK_HRDepartmentID"] != null)
            {
                gridView.Columns["FK_HRDepartmentID"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["FK_HRDepartmentRoomID"] != null)
            {
                gridView.Columns["FK_HRDepartmentRoomID"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["FK_HREmployeeID"] != null)
            {
                gridView.Columns["FK_HREmployeeID"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["PMTemplateItemTaskQty"] != null)
            {
                gridView.Columns["PMTemplateItemTaskQty"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["PMTemplateItemTaskEstimatedStartDate"] != null)
            {
                gridView.Columns["PMTemplateItemTaskEstimatedStartDate"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["PMTemplateItemTaskActualStartDate"] != null)
            {
                gridView.Columns["PMTemplateItemTaskActualStartDate"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["PMTemplateItemTaskEstimatedEndDate"] != null)
            {
                gridView.Columns["PMTemplateItemTaskEstimatedEndDate"].OptionsColumn.AllowEdit = true;
            }

            if (gridView.Columns["PMTemplateItemTaskActualEndDate"] != null)
            {
                gridView.Columns["PMTemplateItemTaskActualEndDate"].OptionsColumn.AllowEdit = true;
            }
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.KeyUp += new KeyEventHandler(GridView_KeyUp);
            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            gridView.OptionsView.ShowAutoFilterRow = true;
            return gridView;
        }

        private void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            //ShowInventory();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }
    }
}
