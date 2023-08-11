using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP163 : ReportForm
    {
        #region Variables




        /// <summary>
        /// A variable to store the report data source
        /// </summary>

        #endregion

        public RP163()
        {
            InitializeComponent();
        }

        private void RP157_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dteSearchFromDate.DateTime = BOSUtil.GetMonthBeginDate();
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
            this.Close();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            if (fld_dteSearchFromDate.DateTime != DateTime.MaxValue && fld_dteSearchToDate.DateTime != DateTime.MaxValue)
            {
                ShowReportData();
            }
        }

        /// <summary>
        /// Show report data based on the report's parameters
        /// </summary>
        private void ShowReportData()
        {
            BOSProgressBar.Start(ReportLocalizedResources.LoadingData);

            DateTime FromDate = Convert.ToDateTime(fld_dteSearchFromDate.EditValue);
            DateTime ToDate = Convert.ToDateTime(fld_dteSearchToDate.EditValue);

            int objectID = 0;
            string objectType = string.Empty;
            if (fld_lkeFK_ACObjectID.EditValue != null)
            {
                string[] objectKey = fld_lkeFK_ACObjectID.EditValue.ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                if (objectKey.Count() == 2)
                {
                    objectID = Convert.ToInt32(objectKey[0]);
                    objectType = objectKey[1];
                }
            }

            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<ICReceiptItemsInfo> List = objReceiptItemsController.GetReceiptItemForReport163(FromDate, ToDate, objectID, objectType);
            fld_dgcRP163ICReceiptItems.DataSource = List;
            GridView gridView = (GridView)fld_dgcRP163ICReceiptItems.MainView;
            gridView.ExpandAllGroups();
            gridView.BestFitColumns();

            BOSProgressBar.Close();
        }


        private void fld_btnExcel_Click(object sender, EventArgs e)
        {
            GridView gridView = (GridView)fld_dgcRP163ICReceiptItems.MainView;
            XlsxExportOptionsEx options = new XlsxExportOptionsEx();
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = @"Tệp Excel (.xls)|*.xls|All files (.*)|*.*";
            saveDialog.FilterIndex = 2;
            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridView.ExportToXlsx(saveDialog.FileName + ".xlsx", options);
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Initialize export excel parameter
        //protected override List<ExportExcelParameter> GetReportHeader()
        //{
        //    //List<ExportExcelParameter> lstHeaderParameter = base.GetReportHeader();
        //    //lstHeaderParameter.Add(SetDefaultHeaderParameter(fld_lblTitle.Text, 1, 4));
        //    //return lstHeaderParameter;
        //}
        #endregion
    }

}