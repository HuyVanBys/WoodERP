using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP095 : ReportForm
    {
        #region Variables
        private int ICProductGroupID = 0;

        /// <summary>
        /// Define location id
        /// </summary>
        private int LocationID = 0;

        /// <summary>
        /// A variable to store the report data source
        /// </summary>
        private DataTable ReportDataSource;
        #endregion

        public RP095()
        {
            InitializeComponent();
        }

        private void RP002_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dteSearchFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
            //fld_lkeBRBranchID.EditValue = BOSApp.CurrentCompanyInfo.FK_BRBranchID;
            fld_lkeGECurrencyID.EditValue = BOSApp.CurrentCompanyInfo.FK_GESaleCurrencyID;
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
            BRBranchsController objBranchsController = new BRBranchsController();
            int deparmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            int productID = Convert.ToInt32(fld_lkeICProductID.EditValue);
            int productGroupID = ICProductGroupID;
            DateTime from = Convert.ToDateTime(fld_dteSearchFromDate.EditValue);
            DateTime to = Convert.ToDateTime(fld_dteSearchToDate.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int currencyID = Convert.ToInt32(fld_lkeGECurrencyID.EditValue);
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(branchID);
            string branchNos = string.Empty;
            if (objBranchsInfo != null)
                branchNos = objBranchsInfo.BRBranchNo;
            ICProductsController productController = new ICProductsController();
            List<ICProductsInfo> datasource = productController.GetProductPriceHistory(productID, null, null, deparmentID, productGroupID, from, to, branchNos, currencyID);

            fld_dgcProductPriceHistory.DataSource = datasource;
            GridView gridView = (GridView)fld_dgcProductPriceHistory.MainView;
            gridView.ExpandAllGroups();
            fld_lbl_FromdateTodate.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                        ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);
            BOSProgressBar.Close();
        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            int productGroupID = objProductGroupsController.GetObjectIDByName(Convert.ToString(fld_bedFK_ICProductGroupID.EditValue));
            int departmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(departmentID, productGroupID);
            guiProductGroupTree.Module = this.Module;
            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {
                ICProductGroupsInfo objProductGroupInfo = (ICProductGroupsInfo)guiProductGroupTree.TreeList.GetSelectedObject();
                if (objProductGroupInfo != null)
                {
                    ICProductGroupID = objProductGroupInfo.ICProductGroupID;
                    fld_bedFK_ICProductGroupID.Text = guiProductGroupTree.GetSelectedProductGroupName();
                    fld_lkeFK_ICDepartmentID.EditValue = guiProductGroupTree.ICDepartmentID;
                }
                else
                {
                    ICProductGroupID = 0;
                    fld_bedFK_ICProductGroupID.Text = String.Empty;
                }
            }
        }

        private void fld_btnExcel_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)fld_dgcProductPriceHistory.MainView;
            ExportToExcel(gridView);
        }

        #region Initialize export excel parameter
        protected override List<ExportExcelParameter> GetReportHeader()
        {
            List<ExportExcelParameter> lstHeaderParameter = base.GetReportHeader();
            lstHeaderParameter.Add(SetDefaultHeaderParameter(fld_lblTitle.Text, 1, 4));
            return lstHeaderParameter;
        }
        #endregion
    }

}