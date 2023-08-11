using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.SellStaff
{
    public partial class HRRewardsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SellStaffEntities entity = (SellStaffEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.RewardList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            gridView.Columns.Clear();

            GridColumn column = new GridColumn();
            column.Caption = "Mã chứng từ";
            column.FieldName = "HRRewardNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tên chứng từ";
            column.FieldName = "HRRewardName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Loại chứng từ";
            column.FieldName = "HRRewardOptionName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Giá trị";
            column.FieldName = "HREmployeeRewardValueAmount";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày chứng từ";
            column.FieldName = "HRRewardFromDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            return gridView;
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                HRRewardsController objRewardsController = new HRRewardsController();
                HRRewardsInfo objRewardsInfo = (HRRewardsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objRewardsInfo != null)
                {
                    BOSERP.Modules.HRReward.HRRewardModule rewardModule = (BOSERP.Modules.HRReward.HRRewardModule)BOSApp.ShowModule(ModuleName.HRReward);
                    if (rewardModule != null)
                    {
                        rewardModule.ActionInvalidate(objRewardsInfo.HRRewardID);
                    }
                }
            }
        }
    }

}
