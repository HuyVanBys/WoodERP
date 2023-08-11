using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BOSLib;
using BOSERP.Utilities;
using DevExpress.XtraReports.UI;
using Localization;
using DevExpress.Utils;
using System.Linq;
using System.Web.Configuration;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public partial class RP076 : ReportForm
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
        private List<ARInvoiceItemsInfo> ReportDataSource;
        #endregion

        public RP076()
        {
            InitializeComponent();
        }

        private void RP076_Load(object sender, EventArgs e)
        {
            fld_dteSearchFromARInvoiceDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToARInvoiceDate.EditValue = BOSUtil.GetMonthEndDate();
            InitializeControls(Controls);
            fld_lblBranchName.Text = string.Empty;
            //ShowReportData();
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
            if (fld_dteSearchFromARInvoiceDate.DateTime != DateTime.MaxValue && fld_dteSearchToARInvoiceDate.DateTime != DateTime.MaxValue)
            {
                ShowReportData();
            }
        }

        /// <summary>
        /// Show report data based on the report's parameters
        /// </summary>
        private void ShowReportData()
        {
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int locationID = LocationID;
            int deparmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            int productGroupID = ICProductGroupID;
            DateTime from = Convert.ToDateTime(fld_dteSearchFromARInvoiceDate.EditValue);
            DateTime to = Convert.ToDateTime(fld_dteSearchToARInvoiceDate.EditValue);
            List<ARInvoiceItemsInfo> productGroups = GetReportDataSource();
            fld_dgcARRP076InvoiceItems.DataSource = productGroups;
            ReportDataSource = productGroups;
            if (productGroups.Count <= 0)
                fld_btnPrint.Enabled = false;
            else
                fld_btnPrint.Enabled = true;
        }


            /// <summary>
        /// Get product group filter list
        /// </summary>
        /// <returns>The list of product group filter</returns>
        private List<ARInvoiceItemsInfo> GetReportDataSource()
        {
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int locationID = LocationID;
            int deparmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            int productGroupID = ICProductGroupID;
            ADReportsController objReportsController = new ADReportsController();
            if (branchID > 0)
            {
                locationID = 0;
            }
            DateTime from = Convert.ToDateTime(fld_dteSearchFromARInvoiceDate.EditValue);
            DateTime to = Convert.ToDateTime(fld_dteSearchToARInvoiceDate.EditValue);

            List<ARInvoiceItemsInfo> aRInvoiceItemsInfoList = objReportsController.GetInvoiceRevenueBySomeCriteria(from, to, locationID, branchID, productGroupID);
            return aRInvoiceItemsInfoList;
        }

        #region Initialize export excel parameter
        protected override List<ExportExcelParameter> GetReportHeader()
        {
            List<ExportExcelParameter> lstHeaderParameter = base.GetReportHeader();
            lstHeaderParameter.Add(SetDefaultHeaderParameter(fld_lblBranchName.Text, 1, 5));
            lstHeaderParameter.Add(SetDefaultSubHeaderParameter(fld_lblTitle.Text, 2, 5));
            return lstHeaderParameter;
        }
        #endregion

        

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            //rp.LoadLayout(BOSCommon.Report.DevInvoiceItem1ReportPath);                                  
            DateTime from = Convert.ToDateTime(fld_dteSearchFromARInvoiceDate.EditValue);
            DateTime to = Convert.ToDateTime(fld_dteSearchToARInvoiceDate.EditValue);
            if (from != DateTime.MaxValue && to != DateTime.MaxValue)
            {
                BOSReport.RP076 rp = new BOSReport.RP076(ReportDataSource, from, to);
                BRBranchsController objBranchsController = new BRBranchsController();
                BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                List<ICProductGroupsInfo> productGroupList = new List<ICProductGroupsInfo>();
                XRLabel branchAddressLine3 = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
                if (branchAddressLine3 != null)
                    branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
                XRLabel branchPhone = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
                if (branchPhone != null)
                    branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
                XRLabel branchFax = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
                if (branchFax != null)
                    branchFax.Text = objBranchsInfo.BRBranchContactFax;
                XRLabel title = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchName"];
                if (title != null)
                {
                    title.Text += string.Format(" {0}", fld_lblBranchName.Text);
                }
                XRLabel dateTime = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
                dateTime.Text = fld_lbl_FromdateTodate.Text;
                guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Report.DevInvoiceItem1ReportPath, true);
                reviewer.Show();
            }
        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ICProductGroupsController objProductGroupsController=new ICProductGroupsController();
            int productGroupID = objProductGroupsController.GetObjectIDByName(Convert.ToString(fld_bedFK_ICProductGroupID.EditValue));
            int departmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(departmentID,productGroupID);
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

        
    }
   
}