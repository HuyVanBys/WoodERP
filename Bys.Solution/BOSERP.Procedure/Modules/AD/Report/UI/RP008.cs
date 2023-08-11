using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP008 : ReportForm
    {
        /// <summary>
        /// A variable to store the report data source
        /// </summary>
        private List<ARCustomersInfo> ReportDataSource;

        public RP008()
        {
            InitializeComponent();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            ShowReportData();
        }

        /// <summary>
        /// Show the report's data based on the report's parameters
        /// </summary>
        private void ShowReportData()
        {
            int customerLocationID = Convert.ToInt32(fld_lkeCustomerLocationID.EditValue);
            string customerType = Convert.ToString(fld_lkeARCustomerType.EditValue);
            int priceLevelID = Convert.ToInt32(fld_lkePriceLevel.EditValue);
            int locationID = Convert.ToInt32(fld_lkeGELocationID.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            ADReportsController objReportsController = new ADReportsController();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //List<ARCustomersInfo> customers = objReportsController.GetCustomerList(
            //                                                    customerLocationID,
            //                                                    customerType,
            //                                                    priceLevelID,
            //                                                    locationID,
            //                                                    branchID);

            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByLocationIDAndBranchID(locationID, branchID);
            List<ARCustomersInfo> customers = new List<ARCustomersInfo>();
            foreach (BRBranchsInfo branch in selectedBranches)
            {
                List<ARCustomersInfo> result = objReportsController.GetCustomerList(
                                                            customerLocationID,
                                                            customerType,
                                                            priceLevelID,
                                                            null,
                                                            branch.BRBranchID);
                customers.AddRange(result);
            }

            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            ReportDataSource = customers;
            fld_dgcARRP008Customer.DataSource = customers;
            if (customers.Count <= 0)
                fld_btnPrint.Enabled = false;
            else
                fld_btnPrint.Enabled = true;
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void RP008_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo branch = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            if (branch != null)
            {
                fld_lkeGELocationID.EditValue = branch.FK_GELocationID;
            }

            ShowReportData();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP008 report = new BOSReport.RP008();
            //report.LoadLayout(BOSCommon.Constants.Report.DevCustomerReportPath);

            //Set current branch
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;

            report.DataSource = ReportDataSource;
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevCustomerReportPath, true);
            reviewer.Show();
        }
    }
}