using BOSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP193 : ReportForm
    {
        public List<ARSaleOrderItemsInfo> SaleOrderItemList;

        private List<BRBranchsInfo> BranchList { get; set; }

        public RP193()
        {
            InitializeComponent();
            BRBranchsController objBranchsController = new BRBranchsController();
            BranchList = objBranchsController.GetAllBranches();
            BranchList.Insert(0, new BRBranchsInfo());
        }

        private void RP093_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
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
            Close();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            GetDataSearch();
        }

        public void GetDataSearch()
        {
            string acObjectAccessKey = string.Empty;
            if (fld_lkeACObjectAccessKey.EditValue != null)
                acObjectAccessKey = fld_lkeACObjectAccessKey.EditValue.ToString();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(acObjectAccessKey);
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            int branchID = fld_lkeBranchID.EditValue == null ? 0 : Int32.Parse(fld_lkeBranchID.EditValue.ToString());
            int employeeID = fld_lkeHREmployeeID.EditValue == null ? 0 : Int32.Parse(fld_lkeHREmployeeID.EditValue.ToString());

            ADReportsController objReportsController = new ADReportsController();
            SaleOrderItemList = objReportsController.GetSaleOrderItemsForToReport193(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType, searchFromDate, searchToDate, branchID, employeeID);
            fld_dgcRP193ARSaleOrderItems.DataSource = SaleOrderItemList;
        }

        private void fld_lkeBranchID_QueryPopUp(object sender, CancelEventArgs e)
        {
            fld_lkeBranchID.Properties.DataSource = BranchList;
        }
    }
}
