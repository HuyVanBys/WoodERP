using BOSLib;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP213 : ReportForm
    {
        #region Variables
        private List<ICReceiptItemsInfo> returnList;
        #endregion

        public RP213()
        {
            InitializeComponent();
        }

        private void RP213_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            //InitializeDataSource();
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
            this.Close();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            InitializeDataSource();
        }

        /// <summary>
        /// Show report data based on the report's parameters
        /// </summary>
        private void InitializeDataSource()
        {
            returnList = new List<ICReceiptItemsInfo>();
            if (fld_lkeICProductType.EditValue != null)
            {
                string productType = fld_lkeICProductType.EditValue.ToString();
                ADReportsController objADReportsController = new ADReportsController();
                List<ICReceiptItemsInfo> receiptList = objADReportsController.GetReport213(productType);
                foreach (ICReceiptItemsInfo item in receiptList)
                {
                    if (item.ICInventoryStockInitQty > 0)
                    {
                        item.ICReceiptDate = item.ICProductSerieReceiptDate;
                        item.ICReceiptItemProductQty = item.ICInventoryStockInitQty;
                        item.ICReceiptItemTotalCost = item.ICInventoryStockInitQty * item.ICInventoryStockUnitCost;
                    }
                    else if (item.ICReceiptItemProductQty == 0)
                    {
                        item.ICReceiptItemProductQty = item.ICReceiptItemReturnProductQty;
                        item.ICReceiptItemTotalCost = item.ICReceiptItemReturnedTotalCost;
                    }
                    item.ICInventoryStockTotalCost = item.ICInventoryStockUnitCost * item.ICInventoryStockQuantity;

                    TimeSpan sn = DateTime.Now.Date - item.ICReceiptDate.Date;
                    item.ICReceiptStorageDay = Convert.ToInt32(sn.TotalDays) - item.ICProductStorageDay;

                    if (item.ICReceiptStorageDay > 0)
                        returnList.Add(item);
                }
                fld_dgcRP213ICReceiptItems.DataSource = returnList;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm trước khi xem", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP213 rp = new BOSReport.RP213();
            if (returnList != null && returnList.Count > 0)
            {
                rp.DataSource = returnList;
                string productType = string.Empty;
                if (fld_lkeICProductType.EditValue != null)
                {
                    productType = fld_lkeICProductType.EditValue.ToString();
                }
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                ADConfigValuesInfo objConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue("ProductType", productType);
                XRLabel productTypeText = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblProductType"];
                if (objConfigValuesInfo != null)
                {
                    if (productTypeText != null)
                    {
                        productTypeText.Text = objConfigValuesInfo.ADConfigText;
                    }
                }
            }
            else
            {
                returnList = new List<ICReceiptItemsInfo>();
                if (fld_lkeICProductType.EditValue != null)
                {
                    string productType = fld_lkeICProductType.EditValue.ToString();
                    ADReportsController objADReportsController = new ADReportsController();
                    ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                    List<ICReceiptItemsInfo> receiptList = objADReportsController.GetReport213(productType);
                    foreach (ICReceiptItemsInfo item in receiptList)
                    {
                        if (item.ICInventoryStockInitQty > 0)
                        {
                            item.ICReceiptDate = item.ICProductSerieReceiptDate;
                            item.ICReceiptItemProductQty = item.ICInventoryStockInitQty;
                            item.ICReceiptItemTotalCost = item.ICInventoryStockInitQty * item.ICInventoryStockUnitCost;
                        }
                        else if (item.ICReceiptItemProductQty == 0)
                        {
                            item.ICReceiptItemProductQty = item.ICReceiptItemReturnProductQty;
                            item.ICReceiptItemTotalCost = item.ICReceiptItemReturnedTotalCost;
                        }
                        item.ICInventoryStockTotalCost = item.ICInventoryStockUnitCost * item.ICInventoryStockQuantity;

                        TimeSpan sn = DateTime.Now.Date - item.ICReceiptDate.Date;
                        item.ICReceiptStorageDay = Convert.ToInt32(sn.TotalDays) - item.ICProductStorageDay;

                        if (item.ICReceiptStorageDay > 0)
                            returnList.Add(item);
                    }
                    rp.DataSource = returnList;
                    ADConfigValuesInfo objConfigValuesInfo = objConfigValuesController.GetObjectByGroupAndValue("ProductType", productType);
                    XRLabel productTypeText = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblProductType"];
                    if (objConfigValuesInfo != null)
                    {
                        if (productTypeText != null)
                        {
                            productTypeText.Text = objConfigValuesInfo.ADConfigText;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn loại sản phẩm trước khi xem", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Constants.Report.DevInvoiceItem1ReportPath, true);
            reviewer.Show();
        }

        private void fld_btnExcel_Click(object sender, EventArgs e)
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

                    fld_dgcRP213ICReceiptItems.ExportToXlsx(fileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ReportLocalizedResources.ExportExelFileUnsuccessfullyMessage,
                                ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}