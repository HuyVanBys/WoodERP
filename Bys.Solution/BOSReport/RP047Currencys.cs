using BOSERP;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP047Currencys : BaseReport
    {
        public RP047Currencys()
        {
            InitializeComponent();
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell32_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell32.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell32.Text = string.Empty;
            else
            {
                xrTableCell32.Text = String.Format("{0:#,##0}", text);
            }
            int OrderNum = (int)GetCurrentColumnValue("OrderNum");
            if (OrderNum == 0 || OrderNum == 3 || OrderNum == 4)
            {
                xrTableCell32.Font = new Font(xrTableCell32.Font.FontFamily, xrTableCell32.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell32.Font = new Font(xrTableCell32.Font.FontFamily, xrTableCell32.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell33_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal text = 0;
            decimal.TryParse(xrTableCell33.Text.ToString(), out text);
            decimal so = Math.Round(text, 0);
            if (so == 0)
                xrTableCell33.Text = string.Empty;
            else
            {
                xrTableCell33.Text = String.Format("{0:#,##0}", text);
            }
            int OrderNum = (int)GetCurrentColumnValue("OrderNum");
            if (OrderNum == 0 || OrderNum == 3 || OrderNum == 4)
            {
                xrTableCell33.Font = new Font(xrTableCell33.Font.FontFamily, xrTableCell33.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell33.Font = new Font(xrTableCell33.Font.FontFamily, xrTableCell33.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell30_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            int OrderNum = (int)GetCurrentColumnValue("OrderNum");
            if (OrderNum == 0 || OrderNum == 3 || OrderNum == 4)
            {
                xrTableCell30.Font = new Font(xrTableCell30.Font.FontFamily, xrTableCell30.Font.Size, FontStyle.Bold);
            }
            else
            {
                xrTableCell30.Font = new Font(xrTableCell30.Font.FontFamily, xrTableCell30.Font.Size, FontStyle.Regular);
            }
        }

        private void xrTableCell27_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            int OrderNum = (int)GetCurrentColumnValue("OrderNum");
            if (OrderNum == 0)
            {
                xrTableCell27.Text = string.Empty;
            }
        }
    }
}
