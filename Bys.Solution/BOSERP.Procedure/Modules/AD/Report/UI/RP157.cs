using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP157 : ReportForm
    {
        #region Variables




        /// <summary>
        /// A variable to store the report data source
        /// </summary>

        #endregion

        public RP157()
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
            //int.TryParse(fld_txtICReceiptCDSerieNo.EditValue.ToString(), out BatchProductID);
            DateTime FromDate = Convert.ToDateTime(fld_dteSearchFromDate.EditValue);
            DateTime ToDate = Convert.ToDateTime(fld_dteSearchToDate.EditValue);
            string lotno = fld_txtICReceiptItemLotNo.Text;

            ADReportsController objReportsController = new ADReportsController();
            List<ICShipmentItemsInfo> List = objReportsController.GetICShipmentItemForReport157(FromDate, ToDate, lotno);
            fld_dgcRP157ICShipmentItems.DataSource = List;
            GridView gridView = (GridView)fld_dgcRP157ICShipmentItems.MainView;
            gridView.ExpandAllGroups();
            gridView.BestFitColumns();

            BOSProgressBar.Close();
        }


        private void fld_btnExcel_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcRP157ICShipmentItems.MainView;
            ExportToExcel(gridView);
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