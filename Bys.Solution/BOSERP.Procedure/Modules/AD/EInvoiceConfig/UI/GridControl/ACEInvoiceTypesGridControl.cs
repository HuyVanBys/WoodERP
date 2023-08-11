using BOSCommon;
using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;


namespace BOSERP.Modules.EInvoiceConfig
{
    public partial class ACEInvoiceTypesGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            EInvoiceConfigEntities entity = (EInvoiceConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.ACEInvoiceTypesList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn col in gridView.Columns)
                col.OptionsColumn.AllowEdit = true;
            return gridView;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((EInvoiceConfigModule)Screen.Module).RemoveSelectedEInvoiceTypesList();
                }
            }
        }

        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);
            GridView gridView = (GridView)sender;
            ACEInvoiceTypesInfo objEInvoiceTypesInfo = (ACEInvoiceTypesInfo)gridView.GetRow(e.RowHandle);
            objEInvoiceTypesInfo.ACEInvoiceTypeCombo = InvoiceTypeCombo.Sell.ToString();
        }

    }
}
