using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP072 : BaseReport
    {
        public RP072()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void DetailRow_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell cell = (XRTableCell)sender;
            int recordNumber = Convert.ToInt32(GetCurrentColumnValue("RecordNumber"));
            if (cell.DataBindings.Count > 0)
            {
                XRBinding binding = cell.DataBindings[0];
                if (binding.DataMember == "DocumentPaymentAmount")
                {
                    if (recordNumber > 0)
                    {
                        cell.Font = new Font(cell.Font, FontStyle.Bold);
                    }
                    else
                    {
                        cell.Font = new Font(cell.Font, FontStyle.Regular);
                    }
                }
                else if (binding.DataMember == "DocumentReceiptAmount")
                {
                    if (recordNumber > 0)
                    {
                        cell.Font = new Font(cell.Font, FontStyle.Bold);
                    }
                    else
                    {
                        cell.Font = new Font(cell.Font, FontStyle.Regular);
                    }
                }
            }
        }
    }
}
