using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP108 : ReportForm
    {
        #region Variables




        /// <summary>
        /// A variable to store the report data source
        /// </summary>
        private DataTable ReportDataSource;
        #endregion

        public RP108()
        {
            InitializeComponent();
        }

        private void RP002_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
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
            ShowReportData();
        }

        /// <summary>
        /// Show report data based on the report's parameters
        /// </summary>
        private void ShowReportData()
        {
            BOSProgressBar.Start(ReportLocalizedResources.LoadingData);
            int productionNormID = Convert.ToInt32(fld_lkeMMProductionNormID.EditValue);

            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            List<MMBatchProductsInfo> objBatchProductList = objBatchProductsController.GetByProductionNormID(productionNormID);
            fld_dgcMMBatchProducts.DataSource = objBatchProductList;
            //GridView gridView = (GridView)fld_dgcMMBatchProducts.MainView;
            //gridView.ExpandAllGroups();
            //fld_lbl_FromdateTodate.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
            //                                                                            ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);        
            BOSProgressBar.Close();
        }



        private void fld_btnExcel_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcMMBatchProducts.MainView;
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