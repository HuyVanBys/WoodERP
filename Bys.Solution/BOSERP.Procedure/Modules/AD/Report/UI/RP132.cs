using BOSLib;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP132 : ReportForm
    {
        public RP132()
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

        private void RP132_Load(object sender, EventArgs e)
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
            int batchProductID = Convert.ToInt32(fld_lkeMMBatchProductID.EditValue);
            int departmentID = Convert.ToInt32(fld_lkeICDepartmentID.EditValue);
            int employeeID = Convert.ToInt32(fld_lkeHREmployeeID.EditValue);
            if (departmentID == 0)
            {
                MessageBox.Show("Bạn chưa chọn ngành hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            ADReportsController objReportsController = new ADReportsController();
            List<APProposalItemsInfo> proposalItemList = objReportsController.GetAllProposalItemByBatchProductIDnotnull(purchaseOrderID, searchFromDate, searchToDate, employeeID, batchProductID, departmentID);
            //if (proposalItemList == null || proposalItemList.Count == 0)
            //{
            //    fld_dgcRP132ICReceiptItems.DataSource = null;
            //}
            fld_dgcRP132APProposalItems.DataSource = proposalItemList;
            GetAllData(proposalItemList.FirstOrDefault());
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        internal void GetAllData(APProposalItemsInfo item)
        {
            List<ICReceiptItemsInfo> ListDetail = new List<ICReceiptItemsInfo>();
            ADReportsController objReportsController = new ADReportsController();
            if (item != null)
            {
                ListDetail = objReportsController.GetICreceiptItemByProposalItemID(item.APProposalItemID);
            }
            fld_dgcRP132ICReceiptItems.DataSource = ListDetail;
        }

    }
}
