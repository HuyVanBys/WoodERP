using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP126 : ReportForm
    {
        public RP126()
        {
            InitializeComponent();
            CenterToScreen();
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

        private void RP126_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
        }

        void fld_lkeFK_MMBatchProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int customerID = Convert.ToInt32(fld_lkeICProductAttributeID.EditValue);

            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            List<MMBatchProductsInfo> objBatchProductList = objBatchProductsController.GetBatchProductByCustomerID(customerID);

            LookUpEdit lke = (LookUpEdit)sender;
            lke.Properties.DataSource = objBatchProductList;
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {

            int productattributeID = Convert.ToInt32(fld_lkeICProductAttributeID.EditValue);
            int height = 0;
            int.TryParse((fld_txtProductHeight.Text.ToString()), out height);
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            List<ICProductSeriesInfo> resultList = objProductSeriesController.GetItemForEditByproductAttributeIDAndProductheight(productattributeID, height);
            fld_dgcRP126ICProductSeries.DataSource = resultList;

        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        internal void GetAllData(int woodTypeID, int QualityTypeID, decimal productHeight)
        {
            ICProductSeriesController objProductSeriesController = new ICProductSeriesController();
            List<ICProductSeriesInfo> ListDetail = objProductSeriesController.GetProductSeriesForReportDetail(woodTypeID, QualityTypeID, productHeight);
            fld_dgcRP126ICProductSerieDetail.DataSource = ListDetail;
        }



    }
}
