using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.OperationDetailPlan
{
    public partial class guiPrintFilter : BOSERPScreen
    {
        public int SaleOrderID;
        public int ProductID;
        public string ProductSerialNo;
        public guiPrintFilter()
        {
            InitializeComponent();
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

        private void guiPrintFilter_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_lkeARSaleOrderID.QueryPopUp += new CancelEventHandler(fld_lkeFK_MMBatchProductID_QueryPopUp);
            fld_lkeICProductID.QueryPopUp += new CancelEventHandler(fld_lkeICProductID_QueryPopUp);
            fld_lkeProductSerieNo.QueryPopUp += new CancelEventHandler(fld_lkeProductSerieNo_QueryPopUp);
        }

        void fld_lkeProductSerieNo_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            int SaleOrderID = 0;
            int.TryParse(fld_lkeARSaleOrderID.EditValue.ToString(), out SaleOrderID);
            int productID = 0;
            int.TryParse(fld_lkeICProductID.EditValue.ToString(), out productID);

            List<ICProductSeriesInfo> productSerieList = new List<ICProductSeriesInfo>();
            productSerieList.Add(new ICProductSeriesInfo());
            lookup.Properties.DataSource = productSerieList;

        }

        void fld_lkeICProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            List<ICProductsInfo> productList = new List<ICProductsInfo>();
            productList.Add(new ICProductsInfo());
            int SaleOrderID = 0;
            int.TryParse(fld_lkeARSaleOrderID.EditValue.ToString(), out SaleOrderID);
            //List<ICProductsInfo> products = ((OperationDetailPlanModule)Module).GetProductList(SaleOrderID);
            // productList.AddRange(products);
            lookup.Properties.DataSource = productList;

        }

        void fld_lkeFK_MMBatchProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookup = (LookUpEdit)sender;
            List<ARSaleOrdersInfo> batchProductList = new List<ARSaleOrdersInfo>();
            batchProductList.Add(new ARSaleOrdersInfo());
            //List<ARSaleOrdersInfo> batchProducts = ((OperationDetailPlanModule)Module).GetSaleOrderList();
            // batchProductList.AddRange(batchProducts);

            lookup.Properties.DataSource = batchProductList;
        }



        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            Accept();
        }
        public void Accept()
        {
            SaleOrderID = 0;
            if (fld_lkeARSaleOrderID.EditValue != null)
                int.TryParse(fld_lkeARSaleOrderID.EditValue.ToString(), out SaleOrderID);

            ProductID = 0;
            if (fld_lkeICProductID.EditValue != null)
                int.TryParse(fld_lkeICProductID.EditValue.ToString(), out ProductID);

            ProductSerialNo = string.Empty;
            if (fld_lkeProductSerieNo.EditValue != null)
                ProductSerialNo = fld_lkeProductSerieNo.EditValue.ToString();

            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
