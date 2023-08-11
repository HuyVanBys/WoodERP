using BOSCommon;
using BOSComponent;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.HRReward
{
    public partial class HREmployeeRewardGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HRRewardEntities entity = (HRRewardEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HREmployeeRewardsList;
            DataSource = bds;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = RewardLocalizedResources.HREmployeeNo;
            column.FieldName = "HREmployeeNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Mã ID";
            column.FieldName = "HREmployeeCardNumber";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.Columns.Remove(gridView.Columns["HREmployeeRewardFromDate"]);
            gridView.Columns.Remove(gridView.Columns["HREmployeeRewardToDate"]);
            GridColumn column = gridView.Columns["HREmployeeRewardSPN"];
            if (column != null)
            {
                column.Visible = false;
                column.OptionsColumn.AllowEdit = true;
            }

            column = gridView.Columns["HREmployeeRewardValue"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["HREmployeeRewardValueAmount"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            column = gridView.Columns["FK_HRRewardID"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((HRRewardModule)Screen.Module).RemoveItemFromRewardList();
            }
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            HRRewardEntities entity = (HRRewardEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.HREmployeeRewardsList.CurrentIndex >= 0)
            {
                HREmployeeRewardsInfo item = entity.HREmployeeRewardsList[entity.HREmployeeRewardsList.CurrentIndex];
                ((HRRewardModule)Screen.Module).ChangeValueSelectedItemFromRewardsList(item.FK_HREmployeeID);
            }
        }

        public void EnablePNTL(string inputType)
        {
            GridView gridView = (GridView)MainView;

            GridColumn column = gridView.Columns["HREmployeeRewardSPN"];
            if (column != null)
            {
                if (inputType == RewardType.PNTL.ToString())
                {
                    column.DisplayFormat.FormatType = FormatType.Numeric;
                    column.DisplayFormat.FormatString = "{0:n2}";
                    column.OptionsColumn.AllowEdit = true;
                    column.Visible = true;
                }
                else
                {
                    column.Visible = false;
                    column.OptionsColumn.AllowEdit = false;
                }
                gridView.BestFitColumns();
            }
        }
    }
}
