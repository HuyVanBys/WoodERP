using BOSComponent;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.Home
{
    public class HRRequestLeaveDaysGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.LeaveApplicationsList;
            DataSource = bds;
        }
        protected override void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            entity.LeaveApplicationsList.SetEndCurrentEdit();
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
                HRRequestLeaveDaysInfo objLeaveApplicationsInfo = (HRRequestLeaveDaysInfo)gridView.GetRow(gridView.FocusedRowHandle);
                LeaveApplication.LeaveApplicationModule leaveApplicationModule = (LeaveApplication.LeaveApplicationModule)BOSApp.ShowModule("LeaveApplication");
                if (leaveApplicationModule == null)
                {
                    if (BOSApp.IsOpenedModule("LeaveApplication"))
                    {
                        ToolStripButton tsbtnModule = (ToolStripButton)BOSApp.MainScreen.OpenModulesToolStrip.Items["LeaveApplication"];
                        BOSApp.CheckOpenModuleToolStripButton(tsbtnModule);
                        BaseModuleERP module = (BaseModuleERP)BOSApp.OpenModules["LeaveApplication"];
                        module.ParentScreen.Activate();
                        module.ActionInvalidate(objLeaveApplicationsInfo.HRRequestLeaveDayID);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    leaveApplicationModule.ActionInvalidate(objLeaveApplicationsInfo.HRRequestLeaveDayID);
                }
            }
        }
    }
}
