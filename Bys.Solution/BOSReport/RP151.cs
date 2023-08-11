using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP151 : BaseReport
    {
        public RP151()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell11_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell cell = (XRTableCell)sender;
            string formatText = Convert.ToString(GetCurrentColumnValue("GEAccountingFormulaItemBold"));
            string category = Convert.ToString(GetCurrentColumnValue("GEAccountingFormulaItemCategory"));
            if (formatText.Equals("H"))
            {
                cell.Text = category.ToUpper();
                cell.Font = new Font(cell.Font, FontStyle.Bold);
            }
            else if (formatText.Equals("C"))
            {
                cell.Font = new Font(cell.Font, FontStyle.Bold);
            }
            else
            {
                cell.Font = new Font(cell.Font, FontStyle.Regular);
            }
        }

        private void xrTableCell13_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell cell = (XRTableCell)sender;
            string formatText = Convert.ToString(GetCurrentColumnValue("GEAccountingFormulaItemBold"));
            if (formatText.Equals("H"))
            {
                cell.Font = new Font(cell.Font, FontStyle.Bold);
            }
            else if (formatText.Equals("C"))
            {
                cell.Font = new Font(cell.Font, FontStyle.Bold);
            }
            else
            {
                cell.Font = new Font(cell.Font, FontStyle.Regular);
            }
        }

        private void xrTableCell14_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell cell = (XRTableCell)sender;
            string formatText = Convert.ToString(GetCurrentColumnValue("GEAccountingFormulaItemBold"));
            if (formatText.Equals("H"))
            {
                cell.Font = new Font(cell.Font, FontStyle.Bold);
            }
            else if (formatText.Equals("C"))
            {
                cell.Font = new Font(cell.Font, FontStyle.Bold);
            }
            else
            {
                cell.Font = new Font(cell.Font, FontStyle.Regular);
            }
        }

        private void xrTableCell30_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell cell = (XRTableCell)sender;
            string formatText = Convert.ToString(GetCurrentColumnValue("GEAccountingFormulaItemBold"));
            if (formatText.Equals("H"))
            {
                cell.Font = new Font(cell.Font, FontStyle.Bold);
            }
            else if (formatText.Equals("C"))
            {
                cell.Font = new Font(cell.Font, FontStyle.Bold);
            }
            else
            {
                cell.Font = new Font(cell.Font, FontStyle.Regular);
            }
        }

        private void xrTableCell12_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell cell = (XRTableCell)sender;
            string formatText = Convert.ToString(GetCurrentColumnValue("GEAccountingFormulaItemBold"));
            if (formatText.Equals("H"))
            {
                cell.Font = new Font(cell.Font, FontStyle.Bold);
            }
            else if (formatText.Equals("C"))
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
