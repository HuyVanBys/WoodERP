using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP105 : ReportForm
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
      //  private List<ACAssetsInfo> AssetList;
        ///// <summary>
        ///// A variable to store the room list for selecting
        ///// </summary>
        //private List<HRDepartmentRoomsInfo> RoomList;
        public RP105()
        {
            InitializeComponent();
        }

        private void RP105_Load(object sender, EventArgs e)
        {

            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
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

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void fld_btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.InitialDirectory = @"C:\";

                saveFileDialog1.Title = "Save Files";

                saveFileDialog1.DefaultExt = "xlsx";

                saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|(*.xlsx)|*.xlsx|All files (*.*)|*.*";

                saveFileDialog1.FilterIndex = 2;

                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    string fileName = saveFileDialog1.FileName;
                    //fld_dgcWoodPlantItemDetail.ExportToXlsx(fileName);
                    //fld_dgcRP100HardwareItems.ExportToXlsx(fileName);
                    //fld_lkeRP100PaintItems.ExportToXlsx(fileName);
                    //fld_lkeRP100PackagingsItem.ExportToXlsx(fileName);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The process cannot access the file") && ex.Message.Contains("because it is being used by another process."))
                    MessageBox.Show(ReportLocalizedResources.CannotExportToExcelFileBecauseTheFileIsBeingUsedByAnotherProcessMessage,
                                    CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(ReportLocalizedResources.ExportExelFileUnsuccessfullyMessage,
                                    CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            GetDataSearch();
        }
        public void GetDataSearch()
        {
            int supplierID = 0;
            int.TryParse(fld_lkeARCustomerID1.EditValue.ToString(), out supplierID);
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            int saleOrderID = Convert.ToInt32(fld_lkeFK_ARSaleOrderID.EditValue);
            string batchProductNo = fld_lkeMMBatchProductNo.Text;
            ADReportsController objReportsController = new ADReportsController();
            List<MMBatchProductsInfo> batchproductList = objReportsController.GetAllMMBatchproduct(supplierID, searchFromDate, searchToDate, saleOrderID, batchProductNo);
            fld_dgcRP104MMBatchProducts.DataSource = batchproductList;

        }
        internal void Getalldata(int batchProductID)
        {
            ADReportsController objReportsController = new ADReportsController();
            List<MMWoodPlanItemDetailsInfo> woodPlansList = objReportsController.GetAllMMWoodPlansDetail(batchProductID);
            List<MMPurchasePlanItemsInfo> purchasePlanItemWoodsList = objReportsController.GetAllPurchasePlanItemWoodByBatchProductID(batchProductID);
            List<MMPurchasePlanItemsInfo> purchasePlanItemOthersList = objReportsController.GetAllPurchasePlanItemOtherByBatchProductID(batchProductID);
            List<APProposalItemsInfo> proposalItemWoodsList = objReportsController.GetAllProposalItemWoodByBatchProductID(batchProductID);
            List<APProposalItemsInfo> proposalItemOthersList = objReportsController.GetAllProposalItemOtherByBatchProductID(batchProductID);
            List<APPurchaseOrderItemsInfo> purchaseOrderItemWoodsList = objReportsController.GetAllPurchaseOrderItemWoodByBatchProductID(batchProductID);
            List<APPurchaseOrderItemsInfo> purchaseOrderItemOthersList = objReportsController.GetAllPurchaseOrderItemOtherByBatchProductID(batchProductID);
            List<APInvoiceInItemsInfo> invoiceInItemWoodList = objReportsController.GetAllInvoiceInItemWoodByBatchProductID(batchProductID);
            List<APInvoiceInItemsInfo> invoiceInItemOtherList = objReportsController.GetAllInvoiceInItemOtherByBatchProductID(batchProductID);
            List<ICReceiptItemsInfo> receiptItemWoodsList = objReportsController.GetAllReceiptItemWoodByBatchProductID(batchProductID);
            List<ICReceiptItemsInfo> receiptItemOthersList = objReportsController.GetAllReceiptItemOtherByBatchProductID(batchProductID);

            fld_dgcRP104MMWoodPlans.DataSource = woodPlansList;
            fld_dgcRP105PurchasePlanItemWoods.DataSource = purchasePlanItemWoodsList;
            fld_dgcRP105PurchasePlanItemOthers.DataSource = purchasePlanItemOthersList;
            fld_dgcRP105ProposalItemWoods.DataSource = proposalItemWoodsList;
            fld_dgcRP105ProposalItemOthers.DataSource = proposalItemOthersList;
            fld_dgcRP105PurchaseOrderItemWoods.DataSource = purchaseOrderItemWoodsList;
            fld_dgcRP105PurchaseOrderItemOthers.DataSource = purchaseOrderItemOthersList;
            fld_dgcRP105InvoiceInItemWoods.DataSource = invoiceInItemWoodList;
            fld_dgcRP105InvoiceInItemOthers.DataSource = invoiceInItemOtherList;
            fld_dgcRP105ReceiptItemWoods.DataSource = receiptItemWoodsList;
            fld_dgcRP105ReceiptItemOthers.DataSource = receiptItemOthersList;

        }
    }
}
