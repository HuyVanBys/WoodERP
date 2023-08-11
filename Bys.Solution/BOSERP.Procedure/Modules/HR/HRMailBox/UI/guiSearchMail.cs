using BOSCommon.Constants;
using BOSLib;
using System;
using System.Text;
using System.Windows.Forms;

namespace BOSERP.Modules.HR.HRMailBox.UI
{
    public partial class guiSearchMail : BOSERPScreen
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets query string
        /// </summary>
        public StringBuilder SearchQuery { get; set; }
        #endregion

        #region Private Variables

        #endregion

        public guiSearchMail()
        {
            InitializeComponent();
        }

        private void guiSearchMail_Load(object sender, EventArgs e)
        {
            //Initialize controls
            InitializeControls(Controls);

            fld_dteSearchFromDateFrom100.DateTime = BOSUtil.GetYearBeginDate();
            fld_dteSearchToDateTo100.DateTime = BOSUtil.GetYearEndDate();
            fld_txtSubject100.Text = string.Empty;
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void fld_btnSearch_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            SearchQuery = new StringBuilder();
            SearchQuery.Append(GenerateSearchQuery(TableName.HRMailsTableName));
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
