using BOSERP;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP_TransferShipment : BaseReport
    {
        public RP_TransferShipment()
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

        private void xrTableCell25_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (!string.IsNullOrEmpty(xrTableCell25.Text))
            {
                double text = double.Parse(xrTableCell25.Text.ToString());
                double so = Math.Round(text, 0);
                xrTableCell25.Text = so.ToString();
                xrTableCell25.Padding = 2;
            }
        }

        private void xrTableCell27_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (!string.IsNullOrEmpty(xrTableCell27.Text))
            {
                double text = double.Parse(xrTableCell27.Text.ToString());
                double so = Math.Round(text, 0);
                xrTableCell27.Text = so.ToString();
                xrTableCell27.Padding = 2;
            }
        }

        //private void xrLabel32_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        //{
        //    DateTime dt = DateTime.Parse
        //    double text = double.Parse(xrLabel32.Text.ToString());
        //    double so = Math.Round(text, 4);
        //    xrLabel32.Text = so.ToString();
        //}

        private void XrLabel35_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (!string.IsNullOrEmpty(xrLabel35.Text.ToString()))
            {
                DateTime date = DateTime.Parse(xrLabel35.Text.ToString());
                TimeSpan ts = DateTime.MaxValue - date;
                double NumberOfDays = ts.TotalDays;

                if (NumberOfDays < 1)
                {
                    xrLabel35.Text = "";
                }
            }
        }
    }
}
