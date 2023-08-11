﻿using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP154 : ReportForm
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
        //private List<ACAssetsInfo> AssetList;

        public RP154()
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

                    fld_dgcRP154PurchaseOrderItems.ExportToXlsx(fileName);
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
            int purchaseOrderID = 0;
            int batchProductID = 0;
            int customerID = 0;
            int supplierID = 0;
            string acObjectAccessKey = string.Empty;
            string acAssObjectAccessKey = string.Empty;
            if (fld_lkeACObjectAccessKey.EditValue != null)
                acObjectAccessKey = fld_lkeACObjectAccessKey.EditValue.ToString();
            if (fld_lkeACAssObjectAccessKey.EditValue != null)
                acAssObjectAccessKey = fld_lkeACAssObjectAccessKey.EditValue.ToString();

            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectSuppliersInfo = objObjectsController.GetObjectByAccessKey(acObjectAccessKey);
            ACObjectsInfo objObjectCustomersInfo = objObjectsController.GetObjectByAccessKey(acAssObjectAccessKey);
            int.TryParse(fld_lkeAPPurchaseOrderID.EditValue.ToString(), out purchaseOrderID);
            int.TryParse(fld_lkeMMBatchProductID.EditValue.ToString(), out batchProductID);
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            ADReportsController objReportsController = new ADReportsController();
            List<APPurchaseOrderItemsInfo> List = objReportsController.GetPurchaseOrderItemForReport154(objObjectSuppliersInfo.ACObjectID, objObjectSuppliersInfo.ACObjectType, searchFromDate, searchToDate, objObjectCustomersInfo.ACObjectID, objObjectCustomersInfo.ACObjectType, purchaseOrderID, batchProductID);
            fld_dgcRP154PurchaseOrderItems.DataSource = List;

        }
    }
}