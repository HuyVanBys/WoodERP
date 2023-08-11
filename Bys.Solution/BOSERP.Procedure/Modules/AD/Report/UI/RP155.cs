using BOSLib;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP155 : ReportForm
    {


        public RP155()
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

        private void RP155_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();

            //fld_lkeFK_MMBatchProductID.QueryPopUp += new CancelEventHandler(fld_lkeFK_MMBatchProductID_QueryPopUp);

        }

        void fld_lkeFK_MMBatchProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int customerID = Convert.ToInt32(fld_lkeFK_ARCustomerID.EditValue);

            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            List<MMBatchProductsInfo> objBatchProductList = objBatchProductsController.GetBatchProductByCustomerID(customerID);

            LookUpEdit lke = (LookUpEdit)sender;
            lke.Properties.DataSource = objBatchProductList;
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            int customerID = Convert.ToInt32(fld_lkeFK_ARCustomerID.EditValue);
            int batchProductID = Convert.ToInt32(fld_lkeFK_MMBatchProductID.EditValue);
            //int supplierID = Convert.ToInt32(fld_lkeFK_APSupplierID.EditValue);
            int objectID = 0;
            string objectType = string.Empty;
            if (fld_lkeFK_ACObjectID.EditValue != null)
            {
                string[] objectKey = fld_lkeFK_ACObjectID.EditValue.ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                objectID = Convert.ToInt32(objectKey[0]);
                objectType = objectKey[1];
            }
            int purchaseOrderID = Convert.ToInt32(fld_lkeFK_APPurchaseOrderID.EditValue);
            ADReportsController objReportsController = new ADReportsController();
            List<APProposalItemsInfo> resultList = objReportsController.GetProposalItemsReportByACObjectID(dateFrom, dateTo, batchProductID, objectID, objectType, customerID, purchaseOrderID);
            //List<APProposalItemsInfo> resultList = objReportsController.GetProposalItemsReport155(dateFrom, dateTo, batchProductID, objectID, customerID, purchaseOrderID);
            int a = resultList.Count;
            fld_dgcRP155APProposalItems.DataSource = resultList;
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
