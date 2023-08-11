using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using BOSComponent;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.SaleReturn
{
    public partial class RefundableInvoiceGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            SaleReturnEntities entity = (SaleReturnEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.RefundableInvoices;
            DataSource = bds;
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            return gridView;
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ((guiChooseInvoice)Screen).ChooseInvoice();
        }
    }
}
