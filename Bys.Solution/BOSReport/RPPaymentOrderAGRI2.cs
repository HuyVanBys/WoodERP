namespace BOSReport
{
    public partial class RPPaymentOrderAGRI2 : BaseReport
    {
        public RPPaymentOrderAGRI2()
        {
            InitializeComponent();
        }

        private void rp_xrlTotalAmount_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rp_xrlTotalAmount.Text = "";
        }
    }
}
