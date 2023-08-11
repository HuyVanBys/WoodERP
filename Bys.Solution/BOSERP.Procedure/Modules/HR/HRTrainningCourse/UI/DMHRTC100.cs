using System.ComponentModel;

namespace BOSERP.Modules.HRTrainningCourse.UI
{
    /// <summary>
    /// Summary description for DMHRTC100
    /// </summary>
    public partial class DMHRTC100 : BOSERPScreen
    {
        /// <summary>
        /// Gets or sets error to check start date and end date of trainning course
        /// </summary>
        public static bool IsError { get; set; }
        public DMHRTC100()
        {
            //
            // Required designer variable
            //
            InitializeComponent();
            IsError = false;
        }

        private void fld_dteHRTranningCourseStartDate_Validating(object sender, CancelEventArgs e)
        {
            ((HRTrainningCourseModule)Module).InvalidateDatetime();
            e.Cancel = IsError;
        }

        private void fld_dteHRTrainningCourseEndDate_Validating(object sender, CancelEventArgs e)
        {
            ((HRTrainningCourseModule)Module).InvalidateDatetime();
            e.Cancel = IsError;
        }
    }
}
