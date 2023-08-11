using BOSERP;
using System;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPICShipmentProposal : BaseReport
    {
        public RPICShipmentProposal()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

    }
}
