using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseReceipt
{
    public class ICReceiptItemPackagesGridControl : BOSGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = gridView.Columns["ICReceiptItemPackageQty"];
            if (column != null)
                column.OptionsColumn.AllowEdit = true;
            column = gridView.Columns["ICReceiptItemPackageSupplierNo"];
            if (column != null)
                column.OptionsColumn.AllowEdit = true;
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            return gridView;
        }

        /// <summary>
        /// Invalidate receipt item package grid control
        /// </summary>
        /// <param name="dataSource">Data source of reciept item grid control</param>
        public void InvalidateDataSource(IBOSList<ICReceiptItemPackagesInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);
            if (e.KeyCode == Keys.Delete)
            {
                ((PurchaseReceiptModule)Screen.Module).DeleteReceiptItemPackage(this);
            }
        }
    }
}
