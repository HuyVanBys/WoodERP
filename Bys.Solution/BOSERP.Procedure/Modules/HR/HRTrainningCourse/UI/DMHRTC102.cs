using System;

namespace BOSERP.Modules.HRTrainningCourse.UI
{
    /// <summary>
    /// Summary description for DMHRTC102
    /// </summary>
    public partial class DMHRTC102 : BOSERPScreen
    {

        public DMHRTC102()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
        }

        private void fld_btnCreateSchedule_Click(object sender, EventArgs e)
        {
            ((HRTrainningCourseModule)Module).CreateSchedules();
        }

        private void fld_btnArangeSchedule_Click(object sender, EventArgs e)
        {
            ((HRTrainningCourseModule)Module).ArrangeSchedules();
        }
    }
}
