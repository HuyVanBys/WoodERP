using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP142 : ReportForm
    {
        private List<MMBatchProductsInfo> batchProductList;
        //private List<ADConfigValuesInfo> batchproducttype;

        public RP142()
        {
            InitializeComponent();
        }

        private void RP142_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            batchProductList = objBatchProductsController.GetAllObject();
            fld_dgcMMBatchProducts.DataSource = batchProductList;
            // fld_cmbBatchProduct.Properties.DataSource = batchProductList;
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

                    fld_dgcRP142BatchProductProductionNormItems.ExportToXlsx(fileName);
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
            string batchProductType = string.Empty;
            if (fld_lkeMMBatchProductType.EditValue == null)
            {
                MessageBox.Show(ReportLocalizedResources.BatchProductType, ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                batchProductType = fld_lkeMMBatchProductType.EditValue.ToString();
                DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
                DateTime searchToDate = fld_dteSearchToDate.DateTime;
                // List<MMBatchProductsInfo> selectedBatchProdcuts = GetbatchProduct();
                List<MMBatchProductsInfo> selectedBatchProdcuts = new List<MMBatchProductsInfo>();
                foreach (MMBatchProductsInfo batchProduct in batchProductList)
                {
                    if (batchProduct.MMBatchProductActiveCheck == true)
                    {
                        selectedBatchProdcuts.Add(batchProduct);
                    }
                }
                // List<MMBatchProductsInfo> selectedBatchProdcuts = batchProductList.Where(p => p.MMBatchProductActiveCheck = true).ToList();
                string batchProductNoList = string.Empty;
                if (selectedBatchProdcuts != null && selectedBatchProdcuts.Count != 0)
                {
                    foreach (MMBatchProductsInfo selectedBatchProdcut in selectedBatchProdcuts)
                    {
                        if (!string.IsNullOrEmpty(batchProductNoList))
                            batchProductNoList += ", ";
                        batchProductNoList += selectedBatchProdcut.MMBatchProductNo;
                    }
                }
                else
                {
                    if (selectedBatchProdcuts == null)
                        selectedBatchProdcuts = new List<MMBatchProductsInfo>();
                    selectedBatchProdcuts.Add(new MMBatchProductsInfo());
                }

                ADReportsController objReportsController = new ADReportsController();
                List<MMBatchProductProductionNormItemsInfo> BatchProductProductionNormItemList = objReportsController.GetProductionNormByBatchproductNosAndType(batchProductType, batchProductNoList, searchFromDate, searchToDate);
                fld_dgcRP142BatchProductProductionNormItems.DataSource = BatchProductProductionNormItemList;
            }

        }
        /// <summary>
        /// Get batchProduct list
        /// </summary>        
        /// <returns>List of stocks</returns>
        //public List<MMBatchProductsInfo> GetbatchProduct()
        //{
        //    List<MMBatchProductsInfo> batchProductLists = new List<MMBatchProductsInfo>();
        //    string[] batchProductIDs = fld_cmbBatchProduct.EditValue.ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        //    if (batchProductIDs.Length > 0)
        //    {
        //        for (int i = 0; i < batchProductIDs.Length; i++)
        //        {
        //            int batchProductID = Convert.ToInt32(batchProductIDs[i]);
        //            MMBatchProductsInfo batchProduct = batchProductList.FirstOrDefault(item => item.MMBatchProductID == batchProductID);
        //            if (batchProduct != null)
        //                batchProductLists.Add(batchProduct);
        //        }
        //    }
        //    return batchProductLists;
        //}

        private void fld_lkeMMBatchProductType_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            string batchProductType = string.Empty;
            if (fld_lkeMMBatchProductType.EditValue == null)
            {
                MessageBox.Show(ReportLocalizedResources.BatchProductType, ReportLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                batchProductType = fld_lkeMMBatchProductType.EditValue.ToString();
            }

            if (fld_dgcRP142BatchProductProductionNormItems != null)
            {
                fld_dgcRP142BatchProductProductionNormItems.LoadGridViewForBatchProductType(batchProductType);
            }
        }
    }
}
