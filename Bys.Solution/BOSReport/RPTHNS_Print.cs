using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Drawing;

namespace BOSReport
{
    public partial class RPTHNS_Print : BaseReport
    {



        /// <summary>
        /// Gets or sets stock list
        /// </summary>
        public RPTHNS_Print(string dateStr)
        {
            InitializeComponent();
            xr_lblFromdateTodate.Text = dateStr;

        }



        private void xrTableCell5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ADReportsInfo item = (ADReportsInfo)GetCurrentRow();
            XRTableCell tableCell = (XRTableCell)sender;
            if (item.ReportItemType == "Group")
            {

                tableCell.Font = new Font(tableCell.Font, FontStyle.Bold | FontStyle.Italic);
                tableCell.BackColor = Color.LightBlue;

            }
            else
            {
                tableCell.Font = new Font(tableCell.Font, FontStyle.Regular);
                tableCell.BackColor = Color.Transparent;
            }


            if (!string.IsNullOrEmpty(tableCell.Text))
            {
                XRBinding biding = tableCell.DataBindings[0];
                double cellValue = 0;
                if (double.TryParse(tableCell.Text, out cellValue))
                {
                    if (cellValue < 0)
                    {
                        if (tableCell.Text.StartsWith("-"))
                        {
                            tableCell.Text = tableCell.Text.Remove(0, 1);
                        }
                        tableCell.Text = string.Format("({0})", tableCell.Text);
                        tableCell.ForeColor = Color.Red;
                    }
                    else if (cellValue > 0)
                    {
                        tableCell.ForeColor = Color.Black;
                    }
                    else if (cellValue == 0)
                    {
                        tableCell.Text = string.Empty;
                    }
                }
                else
                {
                    DateTime dateTime = DateTime.MaxValue;
                    if (DateTime.TryParse(tableCell.Text, out dateTime))
                    {
                        if (dateTime.Date == DateTime.MaxValue.Date)
                        {
                            tableCell.Text = string.Empty;
                        }
                    }
                }
            }

        }

    }
}
