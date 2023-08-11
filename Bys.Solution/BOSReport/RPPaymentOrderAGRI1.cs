namespace BOSReport
{
    public partial class RPPaymentOrderAGRI1 : BaseReport
    {
        public RPPaymentOrderAGRI1()
        {
            InitializeComponent();
        }

        private void rp_xrlTotalAmount_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rp_xrlTotalAmount.Text = "";
        }
    }
}
