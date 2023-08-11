using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP104 : ReportForm
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
      //  private List<ACAssetsInfo> AssetList;
        ///// <summary>
        ///// A variable to store the room list for selecting
        ///// </summary>
        //private List<HRDepartmentRoomsInfo> RoomList;
        public RP104()
        {
            InitializeComponent();
        }

        private void RP104_Load(object sender, EventArgs e)
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
                String[] arrGridName;
                arrGridName = new string[6] { "fld_dgcRP104MMBatchProducts", "fld_dgcRP104MMPurchasePlans", "fld_lkeRP104APProposals", "fld_lkeRP104APPurchaseOrders", "fld_lkeRP104APInvoiceIns", "fld_lke104ICReceipts" };
                foreach (string str in arrGridName)
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                    saveFileDialog1.InitialDirectory = @"C:\";

                    saveFileDialog1.Title = "Save Files";

                    saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|(*.xlsx)|*.xlsx|All files (*.*)|*.*";

                    saveFileDialog1.DefaultExt = ".xls";

                    saveFileDialog1.FilterIndex = 1;

                    saveFileDialog1.RestoreDirectory = true;

                    GridView gridView = new GridView();
                    bool isValid = false;
                    if (str == "fld_dgcRP104MMBatchProducts")
                    {
                        gridView = (GridView)fld_dgcRP104MMBatchProducts.MainView;
                        List<MMBatchProductsInfo> lst = gridView.DataSource as List<MMBatchProductsInfo>;
                        if (lst != null && lst.Count > 0)
                            isValid = true;
                        saveFileDialog1.Title = "Lưu Files Danh sách lệnh sản xuất";
                    }
                    else if (str == "fld_dgcRP104MMPurchasePlans")
                    {
                        gridView = (GridView)fld_dgcRP104MMPurchasePlans.MainView;
                        List<MMPurchasePlansInfo> lst = gridView.DataSource as List<MMPurchasePlansInfo>;
                        if (lst != null && lst.Count > 0)
                            isValid = true;
                        saveFileDialog1.Title = "Lưu Files Danh sách Kế hoạch mua hàng";
                    }
                    else if (str == "fld_lkeRP104APProposals")
                    {
                        gridView = (GridView)fld_lkeRP104APProposals.MainView;
                        List<APProposalsInfo> lst = gridView.DataSource as List<APProposalsInfo>;
                        if (lst != null && lst.Count > 0)
                            isValid = true;
                        saveFileDialog1.Title = "Lưu Files Danh sách Đề nghị mua hàng";
                    }
                    else if (str == "fld_lkeRP104APPurchaseOrders")
                    {
                        gridView = (GridView)fld_lkeRP104APPurchaseOrders.MainView;
                        List<APPurchaseOrdersInfo> lst = gridView.DataSource as List<APPurchaseOrdersInfo>;
                        if (lst != null && lst.Count > 0)
                            isValid = true;
                        saveFileDialog1.Title = "Lưu Files Danh sách Đơn mua hàng";
                    }
                    else if (str == "fld_lkeRP104APInvoiceIns")
                    {
                        gridView = (GridView)fld_lkeRP104APInvoiceIns.MainView;
                        List<APInvoiceInsInfo> lst = gridView.DataSource as List<APInvoiceInsInfo>;
                        if (lst != null && lst.Count > 0)
                            isValid = true;
                        saveFileDialog1.Title = "Lưu Files Danh sách Hóa đơn mua hàng";
                    }
                    else if (str == "fld_lke104ICReceipts")
                    {
                        gridView = (GridView)fld_lke104ICReceipts.MainView;
                        List<ICReceiptsInfo> lst = gridView.DataSource as List<ICReceiptsInfo>;
                        if (lst != null && lst.Count > 0)
                            isValid = true;
                        saveFileDialog1.Title = "Lưu Files Danh sách Nhập kho mua hàng";
                    }

                    if (isValid && saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        gridView.ExportToXls(saveFileDialog1.FileName);
                    }
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
            if (fld_lkeARCustomerID1.EditValue != null)
                int.TryParse(fld_lkeARCustomerID1.EditValue.ToString(), out supplierID);
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            int saleOrderID = Convert.ToInt32(fld_lkeFK_ARSaleOrderID.EditValue);
            string batchProductNo = fld_lkeMMBatchProductNo.Text;
            ADReportsController objReportsController = new ADReportsController();
            List<MMBatchProductsInfo> batchproductList = objReportsController.GetAllMMBatchproduct(supplierID, searchFromDate, searchToDate, saleOrderID, batchProductNo);
            fld_dgcRP104MMBatchProducts.DataSource = batchproductList;
            if (batchproductList.Count > 0)
            {
                Getalldata(batchproductList[0].MMBatchProductID);
            }

        }
        internal void Getalldata(int batchproductid)
        {
            ADReportsController objReportsController = new ADReportsController();
            List<MMWoodPlansInfo> woodPlansList = objReportsController.GetAllMMWoodPlans(batchproductid);
            List<MMPurchasePlansInfo> purchasePlansInfoList = objReportsController.GetAllPurchasePlans(batchproductid);
            List<APProposalsInfo> ProposalsInfoList = objReportsController.GetAllProposals(batchproductid);
            List<APPurchaseOrdersInfo> PurchaseOrdersInfoList = objReportsController.GetAllPurchaseOrders(batchproductid);
            List<APInvoiceInsInfo> invoiceInList = objReportsController.GetAllInvoiceIn(batchproductid);
            List<ICReceiptsInfo> receiptsList = objReportsController.GetAllReceipts(batchproductid);
            fld_dgcRP104MMWoodPlans.DataSource = woodPlansList;
            fld_dgcRP104MMPurchasePlans.DataSource = purchasePlansInfoList;
            fld_lkeRP104APProposals.DataSource = ProposalsInfoList;
            fld_lkeRP104APPurchaseOrders.DataSource = PurchaseOrdersInfoList;
            fld_lkeRP104APInvoiceIns.DataSource = invoiceInList;
            fld_lke104ICReceipts.DataSource = receiptsList;
        }
    }
}
