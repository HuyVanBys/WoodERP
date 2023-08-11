using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP082 : ReportForm
    {
        public RP082()
        {
            InitializeComponent();
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

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP082 report = new BOSReport.RP082();
            bool canShowReport = InitDataSourceReport(report);
            if (canShowReport)
            {
                guiReportPreview reviewer = new guiReportPreview(report);
                reviewer.Show();
            }
        }

        /// <summary>
        /// Init Datasource for Report
        /// </summary>
        /// <param name="report"></param>
        public bool InitDataSourceReport(XtraReport report)
        {
            int segmentID = 0;
            int objectID = 0;
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            string objectType = string.Empty;
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END

            if (fld_lkeACSegmentID.EditValue != null)
            {
                segmentID = Convert.ToInt32(fld_lkeACSegmentID.EditValue);
            }

            if (segmentID <= 0)
            {
                MessageBox.Show(ReportLocalizedResources.PleaseSelectSegment, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (fld_lkeACObjectAccessKey.EditValue != null)
            {
                objectID = Convert.ToInt32(fld_lkeACObjectAccessKey.EditValue.ToString().Split(';')[0]);
                //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
                objectType = Convert.ToString(fld_lkeACObjectAccessKey.EditValue.ToString().Split(';')[1]);
                //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            }

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

            ACSegmentsController objSegmentController = new ACSegmentsController();
            if (segmentID > 0)
            {
                ACSegmentsInfo objSegmentsInfo = (ACSegmentsInfo)objSegmentController.GetObjectByID(segmentID);
                XRLabel segment = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblSegment"];
                if (segment != null)
                    segment.Text = objSegmentsInfo.ACSegmentName;
            }

            ACObjectsController objObjectsController = new ACObjectsController();
            if (objectID > 0)
            {
                //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByIDAndType(objectID, objectType);
                if (objObjectsInfo != null)
                {
                    XRLabel acObject = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblObject"];
                    if (acObject != null)
                        acObject.Text = objObjectsInfo.ACObjectName;
                }
                //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            }

            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByBranchID(branchID);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END

            ARReceiptVouchersController objReceiptVouchersController = new ARReceiptVouchersController();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            List<ARReceiptVouchersInfo> objReceiptVouchers = new List<ARReceiptVouchersInfo>();
            foreach (BRBranchsInfo branch in selectedBranches)
            {
                List<ARReceiptVouchersInfo> list = objReceiptVouchersController.GetSegmentsForReport(segmentID, objectID, branch.BRBranchID);
                objReceiptVouchers.AddRange(list);
            }
            objReceiptVouchers = objReceiptVouchers.OrderBy(item => item.ARReceiptVoucherDate).ToList();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            report.DataSource = objReceiptVouchers;
            return true;
        }

        private void RP082_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}