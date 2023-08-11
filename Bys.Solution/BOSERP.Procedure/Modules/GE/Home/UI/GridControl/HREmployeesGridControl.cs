using BOSComponent;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Home
{
    public class HREmployeesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.EmployeesList;
            DataSource = bds;
        }
        protected override void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            entity.EmployeesList.SetEndCurrentEdit();
            return;
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                HREmployeesInfo objEmployeesInfo = (HREmployeesInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objEmployeesInfo != null)
                {
                    SellStaff.SellStaffModule sellStaffModule = (SellStaff.SellStaffModule)BOSApp.ShowModule("SellStaff");
                    if (sellStaffModule == null)
                        return;
                    sellStaffModule.ActionInvalidate(objEmployeesInfo.HREmployeeID);
                }
            }
        }
    }
}
