using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP122 : ReportForm
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
        //private List<ACAssetsInfo> AssetList;

        public RP122()
        {
            InitializeComponent();
        }

        private void RP122_Load(object sender, EventArgs e)
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

                    fld_dgcAPPurchaseOrders.ExportToXlsx(fileName);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The process cannot access the file") && ex.Message.Contains("because it is being used by another process."))
                    MessageBox.Show(ReportLocalizedResources.CannotExportToExcelFileBecauseTheFileIsBeingUsedByAnotherProcessMessage,
                                    ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(ReportLocalizedResources.ExportExelFileUnsuccessfullyMessage,
                                    ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            GetDataSearch();
        }

        public void GetDataSearch()
        {
            int supplierID = 0;

            int.TryParse(fld_lkeFK_APSupplierID.EditValue != null ? fld_lkeFK_APSupplierID.EditValue.ToString(): "", out supplierID);
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            int purchaseOrderID = 0;
            int.TryParse(fld_lkeAPPurchaseOrderID.EditValue != null ? fld_lkeAPPurchaseOrderID.EditValue.ToString() : "", out purchaseOrderID);
            ADReportsController objReportsController = new ADReportsController();
            List<APPurchaseOrdersInfo> purchaseOrdersList = objReportsController.GetAPPuchaseOrdersbyCustomerAndPurchaseorderID(supplierID, searchFromDate, searchToDate, purchaseOrderID);
            List<APPurchaseOrdersInfo> list = new List<APPurchaseOrdersInfo>();
            decimal TienNo = 0;
            foreach (APPurchaseOrdersInfo item in purchaseOrdersList)
            {
                item.Noqua5den15ngay = 0;
                item.Noqua16den30ngay = 0;
                item.Noquatren30ngay = 0;
                item.Notronghan = 0;
                if (item.PurchaseOrdertotalAmount != 0)
                {
                    TienNo = item.APInvoiceIntotalAmount - (item.APInvoiceIntotalAmount / item.PurchaseOrdertotalAmount * item.APPurchaseOrderPaymentTimeAmountDeposit) - item.TienDaTra;
                }
                else
                {
                    TienNo = item.APInvoiceIntotalAmount - item.TienDaTra;
                }
                if (item.deadline >= 0 && item.deadline <= 5)
                {
                    item.Notronghan = TienNo;
                    item.Noqua5den15ngay = 0;
                    item.Noqua16den30ngay = 0;
                    item.Noquatren30ngay = 0;
                }
                else if (item.deadline >= 5 && item.deadline <= 15)
                {
                    item.Notronghan = 0;
                    item.Noqua5den15ngay = TienNo;
                    item.Noqua16den30ngay = 0;
                    item.Noquatren30ngay = 0;
                }
                else if (item.deadline >= 16 && item.deadline <= 30)
                {
                    item.Notronghan = 0;
                    item.Noqua16den30ngay = TienNo;
                    item.Noquatren30ngay = 0;
                    item.Noqua5den15ngay = 0;
                }
                else if (item.deadline > 30)
                {
                    item.Notronghan = 0;
                    item.Noquatren30ngay = TienNo;
                    item.Noqua16den30ngay = 0;
                    item.Noqua5den15ngay = 0;
                }
                if (TienNo > 1)
                {
                    list.Add(item);
                }
            }
            fld_dgcAPPurchaseOrders.DataSource = list;

        }
    }
}
