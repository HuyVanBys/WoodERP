using DevExpress.XtraReports.UI;
namespace BOSReport
{
    public partial class RPTimeSheetAudit : BaseReport
    {
        public RPTimeSheetAudit()
        {
            InitializeComponent();
            //logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void xrTableCell109_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextTableCell(tableCell);
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
        }

        /// <summary>
        /// Set text for table cell 
        /// </summary>
        /// <param name="tableCell">Given table cell</param>
        public override void SetTextTableCell(XRTableCell tableCell)
        {
            //if (!string.IsNullOrEmpty(tableCell.Text))
            //{
            //    XRBinding biding = tableCell.DataBindings[0];
            //    double cellValue = 0;
            //    if (double.TryParse(tableCell.Text, out cellValue))
            //    {
            //        if (cellValue < 0)
            //        {
            //            if (tableCell.Text.StartsWith("-"))
            //            {
            //                tableCell.Text = tableCell.Text.Remove(0, 1);
            //            }
            //            tableCell.Text = string.Format("({0})", tableCell.Text);
            //            tableCell.ForeColor = Color.Red;
            //        }
            //        else if (cellValue > 0)
            //        {
            //            tableCell.ForeColor = Color.Black;
            //            tableCell.Text = string.Format("{0:n2}", cellValue);
            //        }
            //        else if (cellValue == 0)
            //        {
            //            tableCell.Text = string.Empty;
            //        }
            //    }
            //    else
            //    {
            //        DateTime dateTime = DateTime.MaxValue;
            //        if (DateTime.TryParse(tableCell.Text, out dateTime))
            //        {
            //            if (dateTime.Date == DateTime.MaxValue.Date)
            //            {
            //                tableCell.Text = string.Empty;
            //            }
            //        }
            //    }
            //}
        }

        private void xrTableCell21_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell cell = (XRTableCell)sender;
            double number = 0;
            double.TryParse(GetCurrentColumnValue("HREmployeeAbsentPermission").ToString(), out number);
            if (number == 0)
            {
                xrTableCell21.Text = "";
            }
            else
            {
                xrTableCell21.Text = number.ToString();
            }
        }

        private void xrTableCell23_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell cell = (XRTableCell)sender;
            double number = 0;
            double.TryParse(GetCurrentColumnValue("HREmployeeOTAtNight").ToString(), out number);
            if (number == 0)
            {
                xrTableCell23.Text = "";
            }
            else
            {
                xrTableCell23.Text = number.ToString();
            }
        }

        private void xrTableCell4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell cell = (XRTableCell)sender;
            double number = 0;
            double.TryParse(GetCurrentColumnValue("HREmployeeAbsentUnpermission").ToString(), out number);
            if (number == 0)
            {
                xrTableCell4.Text = "";
            }
            else
            {
                xrTableCell4.Text = number.ToString();
            }
        }

        private void xrTableCell22_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            XRTableCell cell = (XRTableCell)sender;
            double number = 0;
            double.TryParse(GetCurrentColumnValue("HREmployeeOTAtDay").ToString(), out number);
            if (number == 0)
            {
                xrTableCell22.Text = "";
            }
            else
            {
                xrTableCell22.Text = number.ToString();
            }
        }

        private void xrTableCell2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell cell = (XRTableCell)sender;
            double number = 0;
            double.TryParse(GetCurrentColumnValue("HREmployeeOTOnSundayAtDay").ToString(), out number);
            if (number == 0)
            {
                xrTableCell2.Text = "";
            }
            else
            {
                xrTableCell2.Text = number.ToString();
            }
        }

        private void xrTableCell7_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell cell = (XRTableCell)sender;
            double number = 0;
            double.TryParse(GetCurrentColumnValue("HREmployeeOTOnSundayAtNight").ToString(), out number);
            if (number == 0)
            {
                xrTableCell7.Text = "";
            }
            else
            {
                xrTableCell7.Text = number.ToString();
            }
        }

        private void xrTableCell30_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell cell = (XRTableCell)sender;
            double number = 0;
            double.TryParse(GetCurrentColumnValue("HREmployeeOTLeAtDay").ToString(), out number);
            if (number == 0)
            {
                xrTableCell30.Text = "";
            }
            else
            {
                xrTableCell30.Text = number.ToString();
            }
        }

        private void xrTableCell6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell cell = (XRTableCell)sender;
            double number = 0;
            double.TryParse(GetCurrentColumnValue("HREmployeeOTLeAtNight").ToString(), out number);
            if (number == 0)
            {
                xrTableCell6.Text = "";
            }
            else
            {
                xrTableCell6.Text = number.ToString();
            }
        }

        private void xrTableCell19_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell cell = (XRTableCell)sender;
            double number = 0;
            double.TryParse(GetCurrentColumnValue("HREmployeeAnnualLeave").ToString(), out number);
            if (number == 0)
            {
                xrTableCell19.Text = "";
            }
            else
            {
                xrTableCell19.Text = number.ToString();
            }
        }
    }
}
