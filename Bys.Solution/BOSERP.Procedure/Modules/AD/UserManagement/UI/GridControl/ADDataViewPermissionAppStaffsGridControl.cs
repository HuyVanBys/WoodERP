using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.UserManagement
{
    public partial class ADDataViewPermissionAppStaffsGridControl : BOSGridControl
    {
        /// <summary>
        /// Gets or sets the grid view main
        /// </summary>
        public GridView GridViewMain { get; set; }

        public override void InitializeControl()
        {
            base.InitializeControl();
            BandedGridView bandedView = InitializeBandedGridView(GridViewMain);
            bandedView.CellValueChanging += new CellValueChangedEventHandler(bandedView_CellValueChanging);
            MainView = bandedView;
            ViewCollection.AddRange(new BaseView[] { bandedView });
            if (bandedView.Columns["ADPrivilegeAppSatffGroup"] != null)
            {
                bandedView.Columns["ADPrivilegeAppSatffGroup"].Group();
            }
            bandedView.ExpandAllGroups();
            bandedView.OptionsBehavior.AutoExpandAllGroups = true;
        }

        void bandedView_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            GridView gridView = (GridView)sender;

            DataRowView obj = (System.Data.DataRowView)gridView.GetRow(e.RowHandle);
            if (obj != null)
            {
                DataRow row = obj.Row;
                if (row != null)
                {
                    bool currentValue = (bool)row[gridView.FocusedColumn.FieldName];
                    row[gridView.FocusedColumn.FieldName] = !currentValue;

                    if (gridView.FocusedColumn.FieldName == ADDataViewPermissionColumnNames.RowSelection)
                    {
                        if (e.RowHandle == 0)
                            ((UserManagementModule)Screen.Module).SelectAppStaffAll(!currentValue, this.Tag.ToString());
                        else
                            ((UserManagementModule)Screen.Module).SelectAppStaffFullRow(obj.Row);
                    }
                    else if (gridView.FocusedColumn.FieldName != ADDataViewPermissionAppStaffColumnNames.ADGroupAppStaffID &&
                        gridView.FocusedColumn.FieldName != ADDataViewPermissionAppStaffColumnNames.ADPrivilegeAppSatffName &&
                        gridView.FocusedColumn.FieldName != ADDataViewPermissionAppStaffColumnNames.RowSelection)
                    {
                        if (e.RowHandle == 0)
                            ((UserManagementModule)Screen.Module).SelectAppStaffFullColumn(gridView.FocusedColumn.FieldName, !currentValue);
                        else
                            ((UserManagementModule)Screen.Module).SelectionAppStaffChanged(row, gridView.FocusedColumn.FieldName, !currentValue);
                    }
                }
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridViewMain = gridView;
            gridView.ExpandAllGroups();
            return gridView;
        }

        public override void InitGridControlDataSource()
        {
            BindingSource bds = new BindingSource();
            DataTable dt = new DataTable();
            bds.DataSource = dt;
            this.DataSource = bds;
        }

        public void RefreshDataSource(DataTable datatable)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = datatable;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        private BandedGridView InitializeBandedGridView(GridView gridView)
        {
            UserManagementModule module = (UserManagementModule)Screen.Module;
            return module.InitBandedGridViewAppStaff(gridView);
        }

    }
}
