using System;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class guiReportShowProductSerie : BOSERPScreen
    {
        /// <summary>
        /// Gets or sets product object
        /// </summary>
        public ICProductsInfo ProductsObject { get; set; }

        public guiReportShowProductSerie()
        {
            InitializeComponent();
        }

        public guiReportShowProductSerie(ICProductsInfo objProductsInfo)
        {
            InitializeComponent();
            ProductsObject = objProductsInfo;
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }
        private void guiReportShowProductSerie_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            InitializeDataSource();
        }
        private void InitializeDataSource()
        {
            ADReportsController objReportsController = new ADReportsController();
            DataSet ds = objReportsController.GetInventoryProductSeriesByProductIDAndStockID(ProductsObject.ICProductID, ProductsObject.ICStockID);
            fld_dgcICInventoryStocks.DataSource = ds.Tables[0];
            fld_dgcICInventoryStocks.RefreshDataSource();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}