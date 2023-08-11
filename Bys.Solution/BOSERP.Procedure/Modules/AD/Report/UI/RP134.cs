using BOSLib;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP134 : ReportForm
    {


        public RP134()
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

        private void RP134_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
        }

        void fld_lkeFK_MMBatchProductID_QueryPopUp(object sender, CancelEventArgs e)
        {
            int customerID = Convert.ToInt32(fld_lkeAPPurchaseOrderID.EditValue);

            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            List<MMBatchProductsInfo> objBatchProductList = objBatchProductsController.GetBatchProductByCustomerID(customerID);

            LookUpEdit lke = (LookUpEdit)sender;
            lke.Properties.DataSource = objBatchProductList;
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            int purchaseOrderID = Convert.ToInt32(fld_lkeAPPurchaseOrderID.EditValue);
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            ADReportsController objReportsController = new ADReportsController();
            List<APProposalItemsInfo> proposalItemList = objReportsController.GetAllProposalItemByAllocationProposalID(purchaseOrderID, searchFromDate, searchToDate);
            int a = proposalItemList.Count;
            fld_dgcRP134APProposalItems.DataSource = proposalItemList;

        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        internal void GetAllData(APProposalItemsInfo item)
        {
            List<ICReceiptItemsInfo> ListDetail = new List<ICReceiptItemsInfo>();
            ADReportsController objReportsController = new ADReportsController();
            ListDetail = objReportsController.GetICreceiptItemByProposalItemID(item.APProposalItemID);
            fld_dgcRP134ICReceiptItems.DataSource = ListDetail;
        }

    }
}
