using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP031 : ReportForm
    {
        /// <summary>
        /// The selected product group id
        /// </summary>
        private int ProductGroupID = 0;

        /// <summary>
        /// A variable to store the report data source
        /// </summary>
        private DataSet ReportDataSource;

        public RP031()
        {
            InitializeComponent();
            CenterToScreen();
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

        private void RP031_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromAPProposalDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToAPProposalDate.EditValue = BOSUtil.GetMonthEndDate();
            InitializeDataSource();
            GridView gridView = (GridView)fld_dgcAPRP031ProposalItems.MainView;
            gridView.ExpandAllGroups();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Initialize data source for proposal grid control
        /// </summary>
        public void InitializeDataSource()
        {
            ADReportsController objReportsController = new ADReportsController();
            int departmentID = Convert.ToInt32(fld_lkeICDepartmentID.EditValue);
            int objectID = 0;
            string objectType = string.Empty;
            if (fld_lkeFK_ACObjectID.EditValue != null)
            {
                string[] objectKey = fld_lkeFK_ACObjectID.EditValue.ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                objectID = Convert.ToInt32(objectKey[0]);
                objectType = objectKey[1];
            }
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            string status = Convert.ToString(fld_lkeAPPurchaseProposalItemStatus.EditValue);
            DateTime dateFrom = fld_dteSearchFromAPProposalDate.DateTime;
            DateTime dateTo = fld_dteSearchToAPProposalDate.DateTime;
            //Set title report
            fld_lblSubTitle.Text = fld_lkeBRBranchID.Text;
            fld_lblSubTitleDate.Text = String.Format(" {0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, dateFrom.ToString("dd/MM/yyyy"),
                                                                    ReportLocalizedResources.ToDateTitle, dateTo.ToString("dd/MM/yyyy"));

            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //DataSet ds = objReportsController.GetProposalItemsBySomeCriteria(
            //                                        departmentID,
            //                                        ProductGroupID,
            //                                        supplierID,
            //                                        branchID,
            //                                        status,
            //                                        dateFrom,
            //                                        dateTo);
            DataSet ds;
            if (branchID == 0)
            {
                ds = new DataSet();
                foreach (BRBranchsInfo branch in BranchList)
                {
                    DataSet ds1 = objReportsController.GetProposalItemsBySomeCriteria(
                                                        departmentID,
                                                        ProductGroupID,
                                                        objectID,
                                                        objectType,
                                                        branch.BRBranchID,
                                                        status,
                                                        dateFrom,
                                                        dateTo);
                    ds.Merge(ds1);
                }
            }
            else
                ds = objReportsController.GetProposalItemsBySomeCriteria(
                                                        departmentID,
                                                        ProductGroupID,
                                                        objectID,
                                                        objectType,
                                                        branchID,
                                                        status,
                                                        dateFrom,
                                                        dateTo);
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            ReportDataSource = ds;
            fld_dgcAPRP031ProposalItems.DataSource = ds.Tables[0];
            if (ds.Tables[0].Rows.Count <= 0)
                fld_btnPrint.Enabled = false;
            else
                fld_btnPrint.Enabled = true;
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            InitializeDataSource();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP031 report = new BOSReport.RP031();
            //report.LoadLayout(BOSCommon.Constants.Report.DevProposalReportPath);            
            report.DataSource = ReportDataSource;
            report.DataMember = BOSCommon.Constants.Report.DevProposalReportName;
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
            //Set title report
            XRLabel title = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblTitle"];
            if (title != null)
                title.Text += string.Format(" {0}", fld_lkeBRBranchID.Text.ToUpper());
            XRLabel subTitle = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblSubTitle"];
            if (subTitle != null)
                subTitle.Text = fld_lblSubTitleDate.Text;
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevProposalReportPath, true);
            reviewer.Show();
        }

        private void fld_bteICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            int productGroupID = objProductGroupsController.GetObjectIDByName(Convert.ToString(fld_bteICProductGroupID.EditValue));
            int departmentID = Convert.ToInt32(fld_lkeICDepartmentID.EditValue);
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(departmentID, productGroupID);
            guiProductGroupTree.Module = this.Module;
            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {
                ICProductGroupsInfo objProductGroupInfo = (ICProductGroupsInfo)guiProductGroupTree.TreeList.GetSelectedObject();
                if (objProductGroupInfo != null)
                {
                    ProductGroupID = objProductGroupInfo.ICProductGroupID;
                    fld_bteICProductGroupID.Text = guiProductGroupTree.GetSelectedProductGroupName();
                    fld_lkeICDepartmentID.EditValue = guiProductGroupTree.ICDepartmentID;
                }
                else
                {
                    ProductGroupID = 0;
                    fld_bteICProductGroupID.Text = String.Empty;
                }
            }
        }
    }
}
