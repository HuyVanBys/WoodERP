using BOSERP.Utilities;
using System;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class guiSendEmail : BOSERPScreen
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets content of RichTextBox
        /// </summary>
        public String ContentRtb { get; set; }

        /// <summary>
        /// Gets or sets items that have been checked in checklistbox
        /// </summary>
        public ListBox ListFileChecked { get; set; }

        /// <summary>
        /// Gets or sets items in HRMailsInfo
        /// </summary>

        public HRMailsInfo MailInfo { get; set; }
        #endregion

        #region Private Variables
        private MailHelper MailHelper;
        #endregion

        public guiSendEmail()
        {
            InitializeComponent();
            MailHelper = new MailHelper();
            MailInfo = new HRMailsInfo();
        }

        private void guiSendEmail_Load(object sender, EventArgs e)
        {
            //Initialize controls
            InitializeControls(Controls);
            if (MailInfo != null)
            {
                fld_txtMEPatientContactEmail.Text = MailInfo.HRMailSendTo;
                fld_txtSubject.Text = MailInfo.HRMailSubject;
                fld_rtbContent.RichTextBox.Rtf = ContentRtb;
            }
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

        private void fld_btnSend_Click(object sender, EventArgs e)
        {

            ListFileChecked = MailHelper.GetFileAttachment(fld_chklstHRMailAttachment);
            DialogResult = DialogResult.OK;
            if (MailInfo != null)
            {
                MailInfo.HRMailSendTo = fld_txtMEPatientContactEmail.Text;
                MailInfo.HRMailSubject = fld_txtSubject.Text;
                ContentRtb = fld_rtbContent.RichTextBox.Rtf;
                MailInfo.HRMailPriority = fld_lkeHRMailPriority.EditValue.ToString();
                HREmployeesController objEmployeesController = new HREmployeesController();
                HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
                objEmployeesInfo.HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
                objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objEmployeesInfo.HREmployeeID);
                if (objEmployeesInfo != null)
                {
                    string mailFrom = objEmployeesInfo.HREmployeeEmail1.ToString();
                    MailInfo.HRMailSendFrom = mailFrom;
                }
            }
            Close();
        }

        private void fld_linklblAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MailHelper.AddFileAttachment(fld_chklstHRMailAttachment);
        }

        private void fld_chklstHRMailAttachment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = fld_chklstHRMailAttachment.SelectedIndex;
            MailHelper.UpdateFileSizeAttachment(fld_chklstHRMailAttachment, index);
        }







    }
}
