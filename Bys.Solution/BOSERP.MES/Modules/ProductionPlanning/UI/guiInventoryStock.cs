using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductionPlanning
{
    public partial class guiInventoryStock : BOSERPScreen
    {
        public string ListProduct;
        public guiInventoryStock()
        {
            InitializeComponent();
        }
        private void guiMMProductionNormItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            ICStocksController objStockController = new ICStocksController();
            List<ICStocksInfo> objStocksList = objStockController.GetListRealStock();
            ICProductsController objProductsController = new ICProductsController();
            DataTable resultTable = new DataTable();

            DataSet ds = objProductsController.GetICInventorySTocksByListProduct(ListProduct);
            if (ds.Tables.Count > 0)
                resultTable = ds.Tables[0];
            fld_dgcICProductGridControl.DataSource = resultTable;
            fld_dgcICProductGridControl.StockList = objStocksList;
            fld_dgcICProductGridControl.AddInventoryColumns();
            fld_dgcICProductGridControl.RefreshDataSource();
            fld_dgcICProductGridControl.Refresh();
            ds.Dispose();
        }
        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }






    }
}
