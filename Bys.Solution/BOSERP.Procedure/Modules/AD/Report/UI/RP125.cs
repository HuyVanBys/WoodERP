using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP125 : ReportForm
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
        //private List<ACAssetsInfo> AssetList;
        List<ICShipmentItemsInfo> ShipmentItemList;
        public RP125()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void RP093_Load(object sender, EventArgs e)
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

                    fld_dgcRP125ICShipments.ExportToXlsx(fileName);
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
            BOSProgressBar.Start(ReportLocalizedResources.LoadingData);
            int customerID = 0;
            int batchProductID = 0;
            int.TryParse(fld_lkeARCustomerID.EditValue.ToString(), out customerID);
            int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out batchProductID);
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            ADReportsController objReportsController = new ADReportsController();
            ShipmentItemList = objReportsController.GetICShipmentItemForReport(customerID, batchProductID, searchFromDate, searchToDate);

            foreach (ICShipmentItemsInfo item in ShipmentItemList)
            {
                //decimal totalThucTeXuat = 0;
                //decimal totalM3DM = 0;
                //foreach (ICShipmentItemsInfo item1 in ShipmentItemList)
                //{
                //    if (item1.BatchProductID == item.BatchProductID)
                //    {
                //        totalThucTeXuat += item1.TongM3ThucTeXuat;
                //        totalM3DM += item1.M3DinhMuc;
                //    }
                //}
                //if (totalM3DM != 0)
                //{
                //    item.DepreciationRatePerBatchProduct = totalThucTeXuat / totalM3DM;
                //}
                if (item.M3DinhMuc != 0)
                {
                    item.DepreciationRatePerBatchProduct = item.TongM3ThucTeXuat / item.M3DinhMuc;
                    item.MMWoodPlanItemDetailDepreciationRate = item.KLPhachKhoHD / item.M3DinhMuc;
                }
            }
            fld_dgcRP125ICShipments.DataSource = ShipmentItemList;
            BOSProgressBar.Close();
        }

        internal void GetAllData(int batchProductID, decimal shipmentItemHeight, int woodTypeID)
        {
            ADReportsController objReportsController = new ADReportsController();
            List<ICShipmentItemsInfo> ShipmentItemListDetailvan = objReportsController.GetICShipmentItemForReportDetailvan(batchProductID, shipmentItemHeight, woodTypeID);
            fld_dgcRP125ICShipmentItemVan.DataSource = ShipmentItemListDetailvan;
            List<ICShipmentItemsInfo> ShipmentItemListDetailgo = objReportsController.GetICShipmentItemForReportDetailgo(batchProductID, shipmentItemHeight, woodTypeID);
            fld_dgcRP125ICShipmentItemgo.DataSource = ShipmentItemListDetailgo;
        }
        public decimal GetDepreciationRateAmount()
        {
            decimal totalAmount = 0;
            decimal TongM3ThucTeXuat = 0;
            decimal M3TraVeTuLSX = 0;
            decimal M3DinhMuc = 0;
            TongM3ThucTeXuat = ShipmentItemList.Sum(s => s.TongM3ThucTeXuat);
            M3TraVeTuLSX = ShipmentItemList.Sum(s => s.M3TraVeTuLSX);
            M3DinhMuc = ShipmentItemList.Sum(s => s.M3DinhMuc);
            if (M3DinhMuc == 0)
            {
                totalAmount = TongM3ThucTeXuat - M3TraVeTuLSX;
            }
            else
            {
                totalAmount = (TongM3ThucTeXuat - M3TraVeTuLSX) / M3DinhMuc;
            }
            return totalAmount;
        }
    }
}
