using BOSERP;
using System.Collections.Generic;

namespace BOSReport
{
    public partial class BatchProductRouting : BaseReport
    {
        public List<MMBatchProductItemOperationInfosInfo> listProcess { get; set; }
        public BatchProductRouting()
        {
            InitializeComponent();
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
        }

        private void xrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }
    }
}
