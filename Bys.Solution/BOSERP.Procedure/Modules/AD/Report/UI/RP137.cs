using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP137 : ReportForm
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
        //private List<ACAssetsInfo> AssetList;

        public RP137()
        {
            InitializeComponent();
        }

        private void RP137_Load(object sender, EventArgs e)
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

                    fld_dgcRP137ICReceiptItems.ExportToXlsx(fileName);
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
            int woodTypeID = 0;
            string lotno = string.Empty;
            int.TryParse(fld_lkeICProductAttributeID.EditValue.ToString(), out woodTypeID);
            lotno = fld_txtICReceiptItemLotNo.Text;
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            ADReportsController objReportsController = new ADReportsController();
            ///// Giá trị trong kỳ
            List<ICReceiptItemsInfo> receiptItemList = objReportsController.GetAllReceiptItemsAndShipmentbyLotno(woodTypeID, lotno, searchFromDate, searchToDate);
            // Giá trị đầu kỳ
            List<ICReceiptItemsInfo> prevreceiptItemList = objReportsController.GetReceiptItemsAndShipmentbyLotno(woodTypeID, lotno, null, searchFromDate.AddDays(-1));
            foreach (ICReceiptItemsInfo item in receiptItemList)
            {
                if (prevreceiptItemList != null && prevreceiptItemList.Count > 0)
                {
                    item.SLDauky += prevreceiptItemList.Where(p => p.ICReceiptItemLotNo == item.ICReceiptItemLotNo).Sum(p => p.ICReceiptItemWoodQty - p.ICShipmentItemWoodQty);
                    item.KLDauky += prevreceiptItemList.Where(p => p.ICReceiptItemLotNo == item.ICReceiptItemLotNo).Sum(p => p.ICReceiptItemProductQty - p.ICShipmentItemProductQty);
                    item.Tongdaitondau += prevreceiptItemList.Where(p => p.ICReceiptItemLotNo == item.ICReceiptItemLotNo).Sum(p => p.Tongdainhap - p.Tongdaixuat);
                }
                item.SLTonkho = item.SLDauky + item.ICReceiptItemWoodQty - item.ICShipmentItemWoodQty;
                item.KLTonkho = item.KLDauky + item.ICReceiptItemProductQty - item.ICShipmentItemProductQty;
                item.Tongdaiton = item.Tongdaitondau + item.Tongdainhap - item.Tongdaixuat;
                if (item.ICShipmentItemProductQty != 0)
                {
                    //item.Tilethuhoi = item.ICShipmentItemProductQty / item.ICReceiptItemProductQtyLumber;
                    //Tỉ lệ thu hồi : - Công thức đúng: (KL nhập gỗ xẻ) / (KL xuất gỗ tròn)
                    item.Tilethuhoi = (item.ICReceiptItemProductQtyLumber / item.ICShipmentItemProductQty) * 100;
                }
                else
                    item.Tilethuhoi = 0;
            }
            fld_dgcRP137ICReceiptItems.DataSource = receiptItemList;

        }
    }
}
