using DevExpress.XtraReports.UI;
using System;

namespace BOSReport
{
    public partial class RPBHXH_DSLD : BaseReport
    {
        public RPBHXH_DSLD()
        {
            InitializeComponent();
        }

        private void GroupHeader1_AfterPrint(object sender, EventArgs e)
        {

        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //GroupHeaderBand gh = (GroupHeaderBand)sender;
            //XRLabel lb = (XRLabel)gh.Controls["xrLabel32"];
            //if (string.IsNullOrEmpty(lb.Text) || lb.Text.ToLower().Equals("xrLabel32".ToLower()))
            //{
            //    gh.Visible = false;
            //}
            //else gh.Visible = true;
        }

        private void xrTable3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTable tb = (XRTable)sender;
            if (!string.IsNullOrEmpty(((XRTableCell)tb.Rows[0].Controls["xrTableCellLevelNew"]).Text))
            {
                tb.Visible = true;
                tb.TopF = 0;
            }
            else
            {
                tb.Visible = false;
            }
            //Detail.HeightF = tb.HeightF;
        }

        private void xrTable2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTable tb = (XRTable)sender;
            string s = ((XRTableCell)tb.Rows[0].Controls["xrTableCell41"]).Text;
            if (string.IsNullOrEmpty(s))
            {
                tb.Visible = true;
                tb.TopF = 0;
            }
            else
            {
                tb.Visible = false;
            }
        }
    }
}
