using BOSERP;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RP073 : BaseReport
    {
        public RP073()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

        public override void SetTextTableCell(XRTableCell tableCell)
        {
            base.SetTextTableCell(tableCell);

            if (tableCell.DataBindings.Count > 0)
            {
                XRBinding binding = tableCell.DataBindings[0];
                if (binding.DataMember.Contains("Ratio") && !string.IsNullOrEmpty(tableCell.Text))
                {
                    tableCell.Text += "%";
                }
            }
        }
    }
}
