using BOSERP;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPWorkSchedule : BaseReport
    {
        public RPWorkSchedule(List<HREmployeeWorkScheduleItemsInfo> objEmployeeWorkScheduleItemsInfo)
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
            this.DataSource = objEmployeeWorkScheduleItemsInfo;
        }
    }
}
