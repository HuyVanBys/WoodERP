using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BOSERP.Modules.ElectronicInvoiceMInvoice
{
    public partial class guiChooseReportPeriod : BOSERPScreen
    {
        /// <summary>
        /// Gets or sets the start date of a report period
        /// </summary>
        public DateTime FromDate { get; set; }

        /// <summary>
        /// Gets or sets the end date of a report period
        /// </summary>
        public DateTime ToDate { get; set; }

        public guiChooseReportPeriod()
        {
            InitializeComponent();
        }

        public guiChooseReportPeriod(DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();

            fld_dteFromDate.DateTime = fromDate;
            fld_dteToDate.DateTime = toDate;
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            FromDate = fld_dteFromDate.DateTime;
            ToDate = fld_dteToDate.DateTime;

            DialogResult = DialogResult.OK;
            Close();
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in Controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }
    }
}
