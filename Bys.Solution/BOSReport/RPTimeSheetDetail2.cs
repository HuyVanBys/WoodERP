using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPTimeSheetDetail2 : BaseReport
    {
        public int StartDate = 1;
        public int EndDate = 15;
        public RPTimeSheetDetail2()
        {
            InitializeComponent();
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(RPTimeSheetDetail2_BeforePrint);
            xrPictureBox2.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
            ////this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
        }

        void RPTimeSheetDetail2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            int range = EndDate - StartDate;
            for (int i = 0; i < xrTable2.Rows[0].Cells.Count; i++)
            {
                if (i <= range)
                {
                    xrTable2.Rows[0].Cells[i].Text = (StartDate + i).ToString();
                }
                else xrTable2.Rows[0].Cells[i].Text = "";
            }
        }
    }
}
