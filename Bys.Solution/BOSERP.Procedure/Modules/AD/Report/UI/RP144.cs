using BOSComponent;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP144 : ReportForm
    {
        #region Variables




        /// <summary>
        /// A variable to store the report data source
        /// </summary>

        #endregion

        public RP144()
        {
            InitializeComponent();
        }

        private void RP002_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dteSearchFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
            List<ICReceiptsInfo> ListPackNo = new List<ICReceiptsInfo>();
            ICReceiptsController objReceiptsController = new ICReceiptsController();
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<string> ListSerial = new List<string>();
            ListPackNo = objReceiptsController.GetPackNoForReport144();
            ListSerial = objReceiptItemsController.GetSeriesNoForReport144(string.Empty);
            fld_lkePackNo.Properties.DataSource = ListPackNo;
            fld_lkeSerialNo.Properties.DataSource = ListSerial;

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
            string PackNo = string.Empty;
            string SerieNo = string.Empty;
            //int.TryParse(fld_txtICReceiptCDSerieNo.EditValue.ToString(), out BatchProductID);
            DateTime FromDate = Convert.ToDateTime(fld_dteSearchFromDate.EditValue);
            DateTime ToDate = Convert.ToDateTime(fld_dteSearchToDate.EditValue);
            if (fld_lkePackNo.EditValue != null)
            {
                PackNo = fld_lkePackNo.EditValue.ToString();
            }
            if (fld_lkeSerialNo.EditValue != null)
            {
                SerieNo = fld_lkeSerialNo.EditValue.ToString();
            }

            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<ICReceiptItemsInfo> List = objReceiptItemsController.GetReceiptCDItemForReport144(FromDate, ToDate, PackNo, SerieNo);

            fld_dgcICReceiptItems.DataSource = List;
            //GridView gridView = (GridView)fld_dgcICReceiptItems.MainView;
            //gridView.ExpandAllGroups();
            //gridView.BestFitColumns();

            BOSProgressBar.Close();
        }



        private void fld_btnExcel_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcICReceiptItems.MainView;
            ExportToExcel(gridView);
        }

        private void fld_lkePackNo_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.Value != null && e.Value != lke.OldEditValue)
            {
                ValidateSerieNo(e.Value.ToString());
            }
        }
        public void ValidateSerieNo(string PackNo)
        {
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<string> ListSerial = new List<string>();
            ListSerial = objReceiptItemsController.GetSeriesNoForReport144(PackNo);
            fld_lkeSerialNo.Properties.DataSource = ListSerial;
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