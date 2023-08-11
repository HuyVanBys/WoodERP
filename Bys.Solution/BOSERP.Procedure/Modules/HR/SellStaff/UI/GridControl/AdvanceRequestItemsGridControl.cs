using BOSCommon.Constants;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.SellStaff
{
    public partial class AdvanceRequestItemsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SellStaffEntities entity = (SellStaffEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.HRAdvanceRequestItemList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn column = new GridColumn();
            column.Caption = SellStaffLocalizedResource.HRAdvanceRequestNoCaption;
            column.FieldName = "HRAdvanceRequestNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = SellStaffLocalizedResource.HRAdvanceRequestDescCaption;
            column.FieldName = "HRAdvanceRequestDesc";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = SellStaffLocalizedResource.ACSegmentNameCaption;
            column.FieldName = "ACSegmentName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = SellStaffLocalizedResource.GECurrencyNameCaption;
            column.FieldName = "GECurrencyName";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = SellStaffLocalizedResource.HRAdvanceRequestExchangeRateCaption;
            column.FieldName = "HRAdvanceRequestExchangeRate";
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
                HRAdvanceRequestItemsController objAdvanceRequestItemsController = new HRAdvanceRequestItemsController();
                HRAdvanceRequestItemsInfo objAdvanceRequestItemsInfo = (HRAdvanceRequestItemsInfo)gridView.GetRow(gridView.FocusedRowHandle);
                if (objAdvanceRequestItemsInfo != null)
                {
                    BOSERP.Modules.AdvanceRequest.AdvanceRequestModule rewardModule = (BOSERP.Modules.AdvanceRequest.AdvanceRequestModule)BOSApp.ShowModule(ModuleName.AdvanceRequest);
                    if (rewardModule != null)
                    {
                        rewardModule.ActionInvalidate(objAdvanceRequestItemsInfo.FK_HRAdvanceRequestID);
                    }
                }
            }
        }
    }

}
