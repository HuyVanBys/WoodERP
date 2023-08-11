using BOSERP;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPEvaluationTemplate : BaseReport
    {
        public RPEvaluationTemplate()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }

    }
}
