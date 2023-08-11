using BOSComponent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseReceipt
{
    public class ICReceiptItemContFeesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            PurchaseReceiptEntities entity = (PurchaseReceiptEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ReceiptItemContFeeList;
            this.DataSource = bds;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            PurchaseReceiptEntities entity = (PurchaseReceiptEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            GridView gridView = (GridView)sender;
            ICReceiptItemContFeesInfo item = (ICReceiptItemContFeesInfo)gridView.GetFocusedRow();
            ((PurchaseReceiptModule)Screen.Module).UpdateTotalAmountForDSContFees(item);
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                //((PurchaseReceiptModule)Screen.Module).DeleteItemFromReceiptItemContFeesList();
            }
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.HeaderFilterButtonShowMode = FilterButtonShowMode.Default;
            GridColumn column = gridView.Columns["ICReceiptItemContFeeUnitCost"];
            if (column != null)
            {
                column.OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }
    }
}
