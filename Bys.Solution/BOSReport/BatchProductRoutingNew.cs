using BOSERP;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace BOSReport
{
    public partial class BatchProductRoutingNew : BaseReport
    {
        public List<MMBatchProductItemOperationInfosInfo> listProcess { get; set; }
        public BatchProductRoutingNew()
        {
            InitializeComponent();
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
        }

        private void xrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }

        private void xrLabel26_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRLabel label = (XRLabel)sender;
            decimal value = 0;
            decimal.TryParse(label.Text, out value);
            if (value == 0)
                label.Text = string.Empty;
        }
    }
}
