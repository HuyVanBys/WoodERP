﻿using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP140 : ReportForm
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
        //private List<ACAssetsInfo> AssetList;

        public RP140()
        {
            InitializeComponent();
        }

        private void RP137_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> ListProduct = objProductsController.GetProductByTypeProduct();
            //fld_dgcRP139ICProducts.DataSource = ListProduct;
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

                    fld_dgcRP139ICProducts.ExportToXlsx(fileName);
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
            List<ARInvoiceItemsInfo> listobject = new List<ARInvoiceItemsInfo>();
            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
            int ProductID = 0, customerid = 0, batchproduct = 0, arinvoiceID = 0;
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            if (fld_lkeFK_ICProductID.EditValue != null)
                int.TryParse(fld_lkeFK_ICProductID.EditValue.ToString(), out ProductID);
            if (fld_lkeFK_ARCustomerID.EditValue != null)
                int.TryParse(fld_lkeFK_ARCustomerID.EditValue.ToString(), out customerid);
            if (fld_lkeFK_MMBatchProduct.EditValue != null)
                int.TryParse(fld_lkeFK_MMBatchProduct.EditValue.ToString(), out batchproduct);
            //int.TryParse(fld_lkeFK_ARInvoiceID.EditValue.ToString(), out arinvoiceID);
            listobject = objInvoiceItemsController.GetItemsForReport140(searchFromDate, searchToDate, batchproduct, ProductID, customerid, arinvoiceID);
            fld_dgcRP139ICProducts.DataSource = listobject;
            //fld_dgcRP139ICProducts.

        }
    }
}