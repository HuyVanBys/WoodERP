using BOSComponent;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.AllocationCost
{
    public partial class APAllocationCostItemInvoicesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            AllocationCostEntities entity = (AllocationCostEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.InvoiceInItemList;
            this.DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.OptionsView.ShowFooter = true;
            gridView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways;

            if (gridView.Columns["FK_APInvoiceInID"] != null)
            {
                gridView.Columns["FK_APInvoiceInID"].Group();
            }

            GridGroupSummaryItem item = new GridGroupSummaryItem();
            item.FieldName = "APAllocationCostItemInvoiceFeeAmount";
            item.ShowInGroupColumnFooter = gridView.Columns["APAllocationCostItemInvoiceFeeAmount"];
            item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            item.DisplayFormat = "{0:n0}";
            gridView.GroupSummary.Add(item);



            gridView.EndGrouping += new EventHandler(gridView_EndGrouping);
            return gridView;
        }
        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }
        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            AllocationCostEntities entity = (AllocationCostEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            APAllocationCostsInfo bol = (APAllocationCostsInfo)entity.MainObject;
            if (entity.InvoiceInItemList.CurrentIndex >= 0)
            {
                //      ((AllocationCostModule)Screen.Module).ChangeInvoiceItemUnitCost(entity.InvoiceInItemList[entity.InvoiceInItemList.CurrentIndex]);
            }

        }
    }
}
