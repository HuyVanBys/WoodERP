using BOSLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP117 : ReportForm
    {
        public RP117()
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
        private void RP115_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();
        }
        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            int batchProductID = Convert.ToInt32(fld_lkeFK_MMBatchProductID.EditValue);
            int customerID = Convert.ToInt32(fld_lkeARCustomerID.EditValue);

            MMBatchProductProductionNormItemsController objBatchProductProductionNormItemsController = new MMBatchProductProductionNormItemsController();
            List<MMBatchProductProductionNormItemsInfo> List = (List<MMBatchProductProductionNormItemsInfo>)objBatchProductProductionNormItemsController.GetItemForReportBTPSoChe(dateFrom, dateTo, batchProductID, customerID);
            fld_dgcRP117GridControls.DataSource = List;
        }
        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
