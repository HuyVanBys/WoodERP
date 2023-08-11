using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP212 : ReportForm
    {
        public List<HREmployeeWorkScheduleItemsInfo> EmployeeWorkScheduleItemsList;

        public RP212()
        {
            InitializeComponent();
        }

        private void RP212_Load(object sender, EventArgs e)
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
            int branchID = 0;
            if (fld_lkeBRBranchID.EditValue != null)
                Int32.TryParse(fld_lkeBRBranchID.EditValue.ToString(), out branchID);
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            ADReportsController objReportsController = new ADReportsController();
            EmployeeWorkScheduleItemsList = objReportsController.GetEmployeeWorkScheduleItemsForReport212(searchFromDate, searchToDate, branchID);
            if (EmployeeWorkScheduleItemsList.Count() > 0)
            {
                EmployeeWorkScheduleItemsList.ForEach(o =>
                {
                    //o.HREmployeeWorkScheduleHourFrom = o.HREmployeeWorkScheduleDateFrom;
                    //o.HREmployeeWorkScheduleHourTo = o.HREmployeeWorkScheduleDateTo;
                });
            }
            fld_dgcRP212HREmployeeWorkScheduleItems.DataSource = EmployeeWorkScheduleItemsList;
            GridView gridView = (GridView)fld_dgcRP212HREmployeeWorkScheduleItems.MainView;
            gridView.ExpandAllGroups();
        }
    }
}
