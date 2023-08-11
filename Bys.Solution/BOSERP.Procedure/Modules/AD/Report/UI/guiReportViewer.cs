using BOSLib;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class guiReportViewer : BOSERPScreen
    {
        public guiReportViewer()
        {
            InitializeComponent();
            SetDockFill();
        }

        /// <summary>
        /// Get param value
        /// </summary>
        /// <returns></returns>
        public virtual Hashtable GetParamValue()
        {
            // Create and return new Hashtable.
            Hashtable hashtable = new Hashtable();
            return hashtable;
        }

        /// <summary>
        /// Initialize report
        /// </summary>
        /// <param name="reportName">String reportName</param>
        protected virtual void InitializeReport(String reportName)
        {
            ReportDocument report = new ReportDocument();
            report.Load(reportName);
            ReportHelper.ReportDoc = report;
            ReportHelper.ApplyReportLogon();
            ReportHelper.ReportDoc.VerifyDatabase();
            if (GetParamValue().Count > 0)
                ReportHelper.SetParamValues(GetParamValue());
            else
                report.Refresh();
            fld_rptReportViewer.ReportSource = report;
        }

        /// <summary>
        /// Boolean flag set anchor
        /// </summary>
        public virtual Boolean FlagSetDockFill { get; set; }

        /// <summary>
        /// Set anchor full
        /// </summary>
        protected virtual void SetDockFill()
        {
            if (FlagSetDockFill)
                fld_rptReportViewer.Dock = DockStyle.Fill;
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
