using BOSERP;
using System.Collections.Generic;

namespace BOSReport
{
    public partial class OperationRouting : BaseReport
    {
        public List<MMBatchProductItemOperationInfosInfo> listProcess { get; set; }
        public OperationRouting()
        {
            InitializeComponent();
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
        }

        private void xrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //XRLabel label = (XRLabel)sender;
            //int ID = Convert.ToInt32(label.Text);
            //if (ID > 0)
            //{
            //    List<MMBatchProductItemOperationInfosInfo> listProcessItem = listProcess.Where(x => x.FK_MMBatchProductProductionNormItemID == ID).ToList();
            //    if (listProcessItem != null)
            //    {
            //        bdsOperationProcess.DataSource = listProcessItem;
            //    }
            //    label.Text = string.Empty;
            //}
        }
    }
}
