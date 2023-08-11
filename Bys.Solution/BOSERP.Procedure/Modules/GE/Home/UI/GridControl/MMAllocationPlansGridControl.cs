using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System.Windows.Forms;

namespace BOSERP.Modules.Home
{
    public partial class MMAllocationPlansGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.AllocationPlanList;
            DataSource = bds;
        }
        protected override void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            entity.AllocationPlanList.SetEndCurrentEdit();
            return;
        }
        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
            column.Caption = HomeLocalizedResources.ARSaleOrderNo;
            column.FieldName = "ARSaleOrderNo";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = HomeLocalizedResources.ARSaleOrderSaleAgreement;
            column.FieldName = "ARSaleOrderSaleAgreement";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
    }
}
