using System;
using System.Collections;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP023 : guiReportViewer
    {
        public RP023()
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

        private void RP023_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromARInvoiceDate.EditValue = DateTime.Now;
            fld_dteSearchToARInvoiceDate.EditValue = DateTime.Now;
        }

        public override Hashtable GetParamValue()
        {
            Hashtable hashtable = base.GetParamValue();
            hashtable.Add("prFromDate", Convert.ToDateTime(fld_dteSearchFromARInvoiceDate.EditValue));
            hashtable.Add("prToDate", Convert.ToDateTime(fld_dteSearchToARInvoiceDate.EditValue));
            return hashtable;
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            InitializeReport(BOSCommon.Constants.Report.BranchSaleStatisticsReportName);
        }
    }
}
