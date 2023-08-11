using System;

namespace BOSERP.Modules.CompanyConstant.UI
{
    /// <summary>
    /// Summary description for DMCS107
    /// </summary>
    public partial class DMCS107 : BOSERPScreen
    {

        public DMCS107()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            int fromNumber = 0;
            int toNumber = 0;
            if (int.TryParse(fld_txtFromNumber.Text, out fromNumber) && int.TryParse(fld_txtToNumber.Text, out toNumber))
            {
                ((CompanyConstantModule)Module).PrintProductSerialNumber(fromNumber, toNumber);
            }
        }
    }
}
