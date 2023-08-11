using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP196 : ReportForm
    {
        /// <summary>
        /// Define location id
        /// </summary>
        private int LocationID = 0;

        /// <summary>
        /// A variable to store the list of selected employees
        /// </summary>
        private List<HREmployeesInfo> SelectedEmployeeList = new List<HREmployeesInfo>();

        /// <summary>
        /// A variable to store the report data soruce
        /// </summary>
        private List<ARDeliveryPlanItemsInfo> ReportDataSource = new List<ARDeliveryPlanItemsInfo>();

        public RP196()
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

        private void RP196_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = DateTime.Now;
            fld_dteSearchToDate.DateTime = DateTime.Now;
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Init data source for report
        /// </summary>
        public void InitDataSource()
        {
            string deliveryPlanType = string.Empty;
            deliveryPlanType = Convert.ToString(fld_lkeARDeliveryPlanType.EditValue);
            string saleOrderSaleAgreement = string.Empty;
            saleOrderSaleAgreement = Convert.ToString(fld_txtARSaleOrderSaleAgreement.EditValue);
            int saleOrderID = Convert.ToInt32(fld_lkeFK_ARSaleOrderID.EditValue);
            int objectID = 0;
            string objectType = string.Empty;
            if (fld_lkeFK_ACObjectID.EditValue != null)
            {
                string[] objectKey = fld_lkeFK_ACObjectID.EditValue.ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                objectID = Convert.ToInt32(objectKey[0]);
                objectType = objectKey[1];
            }
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            ADReportsController objReportsController = new ADReportsController();
            ARDeliveryPlanItemsController objDeliveryPlanItemsController = new ARDeliveryPlanItemsController();
            List<ARDeliveryPlanItemsInfo> DeliveryPlanItemsList = new List<ARDeliveryPlanItemsInfo>();
            DeliveryPlanItemsList = objDeliveryPlanItemsController.GetDeliveryPlanItemsForReport196(
                                                                                           deliveryPlanType,
                                                                                           saleOrderID,
                                                                                           objectID,
                                                                                           objectType,
                                                                                           saleOrderSaleAgreement,
                                                                                           dateFrom,
                                                                                           dateTo);
            HREmployeesController objEmployeesController = new HREmployeesController();

            fld_dgcARDeliveryPlanItems.DataSource = DeliveryPlanItemsList;
            ReportDataSource = DeliveryPlanItemsList;
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            BOSReport.RP196 rp = new BOSReport.RP196();
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;

            //XRLabel title = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblTitle"];
            //if (title != null)
            //{
            //    if (objBranchsInfo.BRBranchID > 0)
            //        title.Text += " Chi nhánh " + string.Format(" {0}", objBranchsInfo.BRBranchName);
            //}
            XRLabel dateTime = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            dateTime.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                             ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);

            rp.DataSource = ReportDataSource;
            guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Constants.Report.DevRP196Path, true);
            reviewer.Show();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            InitDataSource();
        }
    }
}
