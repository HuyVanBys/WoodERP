using BOSERP;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_ProductConversion : BaseReport
    {
        public RP_ProductConversion()
        {
            InitializeComponent();
            xrPictureBox2.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell20_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (!string.IsNullOrEmpty(xrTableCell20.Text))
            {
                double text = double.Parse(xrTableCell20.Text.ToString());
                double so = Math.Round(text, 0);
                xrTableCell20.Text = so.ToString();
                xrTableCell20.Padding = 2;
            }
        }

        private void xrTableCell11_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (!string.IsNullOrEmpty(xrTableCell11.Text))
            {
                double text = double.Parse(xrTableCell11.Text.ToString());
                double so = Math.Round(text, 0);
                xrTableCell11.Text = so.ToString();
                xrTableCell11.Padding = 2;
            }
        }

        private void xrTableCell18_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (!string.IsNullOrEmpty(xrTableCell18.Text))
            {
                double text = double.Parse(xrTableCell18.Text.ToString());
                double so = Math.Round(text, 0);
                xrTableCell18.Text = so.ToString();
                xrTableCell18.Padding = 2;
            }
        }

        private void xrTableCell15_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (!string.IsNullOrEmpty(xrTableCell15.Text))
            {
                double text = double.Parse(xrTableCell15.Text.ToString());
                double so = Math.Round(text, 0);
                xrTableCell15.Text = so.ToString();
                xrTableCell15.Padding = 2;
            }
        }

        private void xrTableCell17_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (!string.IsNullOrEmpty(xrTableCell17.Text))
            {
                double text = double.Parse(xrTableCell17.Text.ToString());
                double so = Math.Round(text, 5);
                if (text != so)
                    xrTableCell17.Text = so.ToString();
            }
        }

        //private void xrLabel32_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        //{
        //    double text = double.Parse(xrLabel32.Text.ToString());
        //    double so = Math.Round(text, 4);
        //    xrLabel32.Text = so.ToString();
        //}

    }
}
