using System.Reflection;

namespace BOSReport
{
    public partial class PackingList : BaseReport
    {
        public PackingList()
        {
            InitializeComponent();
            ////this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
            logoCompany.ImageUrl = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\Logo\logo.png";
        }
    }
}
