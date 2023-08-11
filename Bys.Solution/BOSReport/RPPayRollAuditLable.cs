using DevExpress.XtraReports.UI;
using System;

namespace BOSReport
{
    public partial class RPPayRollAuditLable : BaseReport
    {
        public RPPayRollAuditLable()
        {
            InitializeComponent();
            ////this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
        }

        private void TableCell_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRLabel tableCell = sender as XRLabel;
            if (tableCell == null)
                return;

            decimal value = 0;
            Decimal.TryParse(tableCell.Text, out value);
            if (value == 0)
            {
                tableCell.Text = "-";
            }
        }
    }
}
