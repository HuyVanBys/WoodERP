using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP198 : ReportForm
    {
        public RP198()
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

        private void RP198_Load(object sender, EventArgs e)
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
            string proposalType = string.Empty;
            int proposalID = Convert.ToInt32(fld_lkeFK_MMProposalID.EditValue);
            int objectID = 0;
            string objectType = string.Empty;
            if (fld_lkeACObjectAccessKey.EditValue != null)
            {
                string[] objectKey = fld_lkeACObjectAccessKey.EditValue.ToString().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                objectID = Convert.ToInt32(objectKey[0]);
                objectType = objectKey[1];
            }
            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;

            MMProposalItemsController objProposalItemsController = new MMProposalItemsController();
            List<MMProposalItemsInfo> proposalItems = new List<MMProposalItemsInfo>();
            proposalItems = objProposalItemsController.GetProposalItemsForReport198(proposalType, proposalID, objectID, objectType, dateFrom, dateTo);
            fld_dgcRP198MMProposalItems.DataSource = proposalItems;
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            InitDataSource();
        }
    }
}
