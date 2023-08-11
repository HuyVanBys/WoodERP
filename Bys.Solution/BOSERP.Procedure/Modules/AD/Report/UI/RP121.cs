using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP121 : ReportForm
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
        //private List<ACAssetsInfo> AssetList;
        public List<ARSaleOrdersInfo> SaleOrderList;
        public RP121()
        {
            InitializeComponent();
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

                    fld_dgcRP121ARSaleOrders.ExportToXlsx(fileName);
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
            if (fld_lkeFK_ACObjectID.EditValue == null || fld_lkeFK_ACObjectID.EditValue.ToString() == "0")
            {
                MessageBox.Show(ReportLocalizedResources.NeedSelectCustomerBeforeView,
                                    ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            GetDataSearch();
        }

        public void GetDataSearch()
        {
            int customerID = 0;
            int saleOrderID = 0;
            int objectID = 0;
            string objectType = string.Empty;
            if (fld_lkeFK_ACObjectID.EditValue != null)
            {
                string[] objectKey = fld_lkeFK_ACObjectID.EditValue.ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                objectID = Convert.ToInt32(objectKey[0]);
                objectType = objectKey[1];
            }
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            int.TryParse(fld_txtARSaleOrderID.EditValue.ToString(), out saleOrderID);
            ADReportsController objReportsController = new ADReportsController();
            SaleOrderList = objReportsController.GetSaleOrderToReportCNPT(objectID, objectType, searchFromDate, searchToDate, saleOrderID);

            fld_dgcRP121ARSaleOrders.DataSource = SaleOrderList;
        }

        public decimal SumList(List<ARSaleOrdersInfo> SaleOrderList)
        {
            decimal SumCoc = 0;
            string saleOrderNo = string.Empty;
            if (SaleOrderList != null)
            {
                foreach (ARSaleOrdersInfo item in SaleOrderList)
                {
                    if (!saleOrderNo.Contains(item.ReportSaleOrderNo))
                    {
                        SumCoc += item.TienCoc;
                        saleOrderNo += item.ReportSaleOrderNo;
                    }
                }
            }
            return SumCoc;
        }
    }
}
