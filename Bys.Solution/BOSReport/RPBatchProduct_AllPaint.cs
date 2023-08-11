using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPBatchProduct_AllPaint : BaseReport
    {
        public RPBatchProduct_AllPaint(decimal totalPaint, string customerName, string lsx)
        {
            InitializeComponent();
            TotalPaint = totalPaint;
            CustomerName = customerName;
            LSX = lsx;
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
            xrPictureBoxLogo.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        public decimal TotalPaint = 0;
        public string CustomerName = string.Empty;
        public string LSX = string.Empty;


        private void RPBatchProduct_AllPaint_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xr_lblCustomerName.Text = CustomerName;

            xr_lblLSX.Text = LSX;
            xr_lblTotalPaint.Text = TotalPaint.ToString();
        }
    }
}
