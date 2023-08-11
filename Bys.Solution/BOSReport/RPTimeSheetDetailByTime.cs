namespace BOSReport
{
    public partial class RPTimeSheetDetailByTime : BaseReport
    {
        public RPTimeSheetDetailByTime()
        {
            InitializeComponent();
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
        }

        //private void xrTableCell19_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        //{
        //    XRTableCell cel = (XRTableCell)sender;
        //    if (cel.DataBindings.Count > 0)
        //    {
        //        cel.DataBindings[0].FormatString = "{0:dd/MM/yyyy}";
        //    }
        //}
    }
}
