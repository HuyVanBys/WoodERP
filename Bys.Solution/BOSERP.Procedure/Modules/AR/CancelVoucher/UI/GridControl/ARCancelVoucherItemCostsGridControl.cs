using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.CancelVoucher
{
    public class ARCancelVoucherItemCostsGridControl : ItemGridControl
    {
        public override void InitGridControlDataSource()
        {
            base.InitGridControlDataSource();
            CancelVoucherEntities entity = (CancelVoucherEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.CancelVoucherItemCostList;
            this.DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            if (gridView.Columns["ARCancelVoucherItemCostProductCancelQty"] != null)
                gridView.Columns["ARCancelVoucherItemCostProductCancelQty"].OptionsColumn.AllowEdit = true;
            return gridView;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);

            GridView gridView = sender as GridView;

            CancelVoucherEntities entity = (CancelVoucherEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            if (entity.CancelVoucherItemCostList.CurrentIndex >= 0)
            {
                ARCancelVoucherItemCostsInfo item = (ARCancelVoucherItemCostsInfo)entity.CancelVoucherItemCostList[entity.CancelVoucherItemCostList.CurrentIndex];

                if (item == null)
                    return;
                if (e.Column.FieldName == "ARCancelVoucherItemCostProductCancelQty")
                {
                    bool isValid = (entity.Module as CancelVoucherModule).CheckValidCostQty(item);
                    if (isValid)
                    {
                        ((CancelVoucherModule)Screen.Module).ChangeItemCostTotalAmount();
                    }
                }
            }
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            if (e.KeyCode == Keys.Delete)
            {
                ((CancelVoucherModule)Screen.Module).DeleteItemFromCancelVoucherItemCostList();
            }
        }
    }
}
