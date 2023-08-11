using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Windows.Forms;

//NUThao [ADD] [08/04/2014] [DB centre] [Permission configuration], START
namespace BOSERP.Modules.UserManagement
{
    public partial class ADDataViewPermissionsGridControl : BOSGridControl
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
                            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                            //((UserManagementModule)Screen.Module).SelectAll(!currentValue);
                            ((UserManagementModule)Screen.Module).SelectAll(!currentValue, this.Tag.ToString());
                        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
                        else
                            ((UserManagementModule)Screen.Module).SelectFullRow(obj.Row);
                    }
                    else if (gridView.FocusedColumn.FieldName != ADDataViewPermissionColumnNames.ADUserGroupSectionName &&
                        gridView.FocusedColumn.FieldName != ADDataViewPermissionColumnNames.STModuleName &&
                        gridView.FocusedColumn.FieldName != ADDataViewPermissionColumnNames.RowSelection)
                    {
                        if (e.RowHandle == 0)
                            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                            //1((UserManagementModule)Screen.Module).SelectFullColumn(gridView.FocusedColumn.FieldName, !currentValue);
                            ((UserManagementModule)Screen.Module).SelectFullColumn(gridView.FocusedColumn.FieldName, !currentValue, this.Tag.ToString());
                        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
                        else
                            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                            //((UserManagementModule)Screen.Module).SelectionChanged(row, gridView.FocusedColumn.FieldName, !currentValue);
                            ((UserManagementModule)Screen.Module).SelectionChanged(row, gridView.FocusedColumn.FieldName, !currentValue, this.Tag.ToString());
                        //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
                    }
                }
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridViewMain = gridView;
            return gridView;
        }

        public override void InitGridControlDataSource()
        {
            BindingSource bds = new BindingSource();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //bds.DataSource = ((UserManagementModule)Screen.Module).InitProductLocationBranchPricesDataSource();
            bds.DataSource = ((UserManagementModule)Screen.Module).InitProductLocationBranchPricesDataSource(this.Tag.ToString());
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
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
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //return module.InitBandedGridView(gridView);
            return module.InitBandedGridView(gridView, this.Tag.ToString());
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
        }

    }
}
//NUThao [ADD] [08/04/2014] [DB centre] [Permission configuration], END
