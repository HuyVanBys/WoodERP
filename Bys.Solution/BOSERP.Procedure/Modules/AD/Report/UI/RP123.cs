using BOSComponent;
using BOSLib;
using BOSReport;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP123 : ReportForm
    {

        public List<MMBatchProductProductionNormItemsInfo> resultPaintList;
        public RP123()
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

        private void RP123_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();

            //fld_lkeFK_MMBatchProductID.QueryPopUp += new CancelEventHandler(fld_lkeFK_MMBatchProductID_QueryPopUp);

        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;

            int customerID = Convert.ToInt32(fld_lkeFK_ARCustomerID.EditValue);
            int batchProductID = Convert.ToInt32(fld_lkeFK_MMBatchProductID.EditValue);

            MMBatchProductProductionNormItemsController objBPPNIsController = new MMBatchProductProductionNormItemsController();

            //List<MMBatchProductProductionNormItemsInfo> resultPaintList = objBPPNIsController.GetMMBatchProductIDAndTypeisIngredientPaint(customerID, batchProductID, dateFrom, dateTo);
            List<MMBatchProductProductionNormItemsInfo> resultpaintList = resultPaintList.Where(p => p.MMProductIsReuse == true).ToList();
            List<MMBatchProductProductionNormItemsInfo> checkList = null;
            MMBatchProductProductionNormItemsInfo objBatchProductProductionNormItemsInfo = (MMBatchProductProductionNormItemsInfo)resultpaintList.FirstOrDefault();
            if (objBatchProductProductionNormItemsInfo != null)
            {
                checkList = resultpaintList.Where(p => p.FK_MMBatchProductID != objBatchProductProductionNormItemsInfo.FK_MMBatchProductID).ToList();
            }
            if (checkList == null || checkList.Count > 0)
            {
                if (checkList == null)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm để in.", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(ReportLocalizedResources.OneMMBatchProductID, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                foreach (MMBatchProductProductionNormItemsInfo item in resultpaintList)
                {
                    if (item.ICShipmentItemProductQty >= item.MMBatchProductProductionNormItemQuantity)
                    {
                        item.SLVuotDM = item.ICShipmentItemProductQty - item.MMBatchProductProductionNormItemQuantity;
                        item.SLdu = 0;
                    }
                    else
                    {
                        item.SLdu = item.MMBatchProductProductionNormItemQuantity - item.ICShipmentItemProductQty;
                        item.SLVuotDM = 0;
                    }
                }
                RP_BatchProductPaint report = new RP_BatchProductPaint();
                InitReportDataSource(report, resultpaintList);
                report.DataSource = resultpaintList;
                guiReportPreview viewer = new guiReportPreview(report);
                viewer.Show();
            }

        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void InitReportDataSource(XtraReport report, List<MMBatchProductProductionNormItemsInfo> resultPaintList)
        {
            MMBatchProductProductionNormItemsInfo objBatchProductProductionNormItemsInfo = new MMBatchProductProductionNormItemsInfo();
            objBatchProductProductionNormItemsInfo = (MMBatchProductProductionNormItemsInfo)resultPaintList.FirstOrDefault();
            if (objBatchProductProductionNormItemsInfo != null)
            {
                XRLabel BatchProductName = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xrLabel2"];
                if (BatchProductName != null)
                    BatchProductName.Text = objBatchProductProductionNormItemsInfo.MMBatchProductNo;//+ "_" + objBatchProductProductionNormItemsInfo.MMBatchProductItemProductName;
            }

        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            BOSProgressBar.Start("Đang xử lí dữ liệu");
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            string BatchProductNo = string.Empty;

            int customerID = Convert.ToInt32(fld_lkeFK_ARCustomerID.EditValue);
            int batchProductID = Convert.ToInt32(fld_lkeFK_MMBatchProductID.EditValue);
            MMBatchProductProductionNormItemsController objBPPNIsController = new MMBatchProductProductionNormItemsController();

            resultPaintList = objBPPNIsController.GetMMBatchProductIDAndTypeisIngredientPaint(customerID, batchProductID, dateFrom, dateTo);
            if (customerID > 0)
            {
                resultPaintList = resultPaintList.Where(x => x.FK_ARCustomerID == customerID).ToList();
            }

            fld_dgcRP123MMBatchProductProductionNormItems.DataSource = resultPaintList;
            BOSProgressBar.Close();
        }

        private void fld_chkSellectAllProductNorm_CheckedChanged(object sender, EventArgs e)
        {
            BOSCheckEdit selectAllCheckEdit = (BOSCheckEdit)sender;
            if (resultPaintList != null)
            {
                foreach (MMBatchProductProductionNormItemsInfo item in resultPaintList)
                {
                    item.MMProductIsReuse = selectAllCheckEdit.Checked;
                }
            }
            fld_dgcRP123MMBatchProductProductionNormItems.RefreshDataSource();
        }


    }
}
