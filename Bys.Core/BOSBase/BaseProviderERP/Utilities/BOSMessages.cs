using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using eMASLib;
namespace eMASERP
{
    public partial class eMASMessage : Form
    {
        #region Properties

            private String myMessage;
            public String MyMessage
            {
                get { return myMessage; }
                set { myMessage = value; }
            }

            private String myTitle;
            public String MyTitle
            {
                get { return myTitle; }
                set { myTitle = value; }
            }

            private MessageBoxButtons messType;
            public MessageBoxButtons MessButtonsType
            {
                get { return messType; }
                set { messType = value; }
            }

            private MessageBoxIcon messIconType;
            public MessageBoxIcon MessIconType
                {
                    get { return messIconType; }
                    set { messIconType = value; }
                }

            private Boolean isMessageHidden;
            public Boolean IsMessageHidden
            {
                get { return isMessageHidden; }
                set { isMessageHidden = value; }
            }

            private GEMessagesInfo messInfo;
            private GEMessagesController messController;

            private GEUserMessagesHiddenController messHiddenController;
            private GEUserMessagesHiddenInfo messHiddenInfo;

    #endregion

        #region Constructor    
        public eMASMessage()
        {
            InitializeComponent();
            messController = new GEMessagesController();
            messInfo = new GEMessagesInfo();
            messHiddenController = new GEUserMessagesHiddenController();
            messHiddenInfo = new GEUserMessagesHiddenInfo();
        }
    #endregion

        #region Main Functions
      
        public DialogResult ShowMessage(String messageNo, params object[] values)
        {
            ConfigureData(messageNo, values);

            isMessageHidden = IsHidden();
            if (isMessageHidden)
            {
                messHiddenInfo.GEMessageHiddenCount += 1;
                if (messHiddenInfo.GEMessageHiddenCount > messInfo.GEMessagesHiddenMaxCount)
                    { messHiddenController.DeleteObject(messHiddenInfo.GEUserMessagesHiddenID); }
                else
                    { messHiddenController.UpdateObject(messHiddenInfo); }
                                       
                return DialogResult.None;
            }
            
            ConfigureLayout(myMessage, myTitle);
            return this.ShowDialog();
        }

        public Boolean IsHidden()
        {          
                int iADUserID = new ADUsersController().GetObjectIDByName(eMASApp.CurrentUser);
                int iGEMessagesID = messInfo.GEMessagesID;

                messHiddenInfo = (GEUserMessagesHiddenInfo)messHiddenController.GetObjectByUserIDAndMessageID(iADUserID, iGEMessagesID);
                return (messHiddenInfo !=null ) ;
        }

        private void ConfigureData(String messageNo,  params object[] values)
        {
            messInfo = (GEMessagesInfo)messController.GetObjectByNo(messageNo);
            
            switch (eMASApp.CurrentLang)
            {
                case "vn":
                    MyMessage = messInfo.GEMessagesContentVN;
                    MyTitle = messInfo.GEMessagesTitleVN;
                    this.checkEdit1.Text = "Khong xuat hien lan sau";
                    break;
                case "fr":
                    MyMessage = messInfo.GEMessagesContentFR;
                    MyTitle = messInfo.GEMessagesTitleFR;
                    this.checkEdit1.Text = "shfjkdgk fgj fkjl shfh fgjf gfgh";
                    break;
                case "ge":
                    MyMessage = messInfo.GEMessagesContentGE;
                    MyTitle = messInfo.GEMessagesTitleGE;
                    this.checkEdit1.Text = "dgfdhgjhgf5vrtv fdgd 55454 gh 5";
                    break;
                default: //=="en"
                    MyMessage = messInfo.GEMessagesContentEN;
                    MyMessage=MyMessage.Replace("\\n", Environment.NewLine);
                    MyTitle = messInfo.GEMessagesTitleEN;
                    this.checkEdit1.Text = "Don't show again...";
                    break;
            }
            MessButtonsType = (MessageBoxButtons)messInfo.GEMessagesButtonsType;
            MessIconType = (MessageBoxIcon)messInfo.GEMessagesType;

            try
            {
               MyMessage= String.Format(MyMessage, values);
            }
            catch (System.Exception e)
            {
                MessageBox.Show("Error in Message..", "Check input parameters", MessageBoxButtons.OK);
            }
           

        }

        private void ConfigureLayout(String myMessage, String myTitle)
        {

            this.checkEdit1.Checked = IsMessageHidden;
            tabGroup.SelectedTabPage.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            switch (MessButtonsType)
            {
                case MessageBoxButtons.OK:
                    tabGroup.SelectedTabPage = OkOnly;
                    break;
                case MessageBoxButtons.OKCancel:
                    tabGroup.SelectedTabPage = OKCancel;
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    tabGroup.SelectedTabPage = AbortRetryIgnore;
                    break;
                case MessageBoxButtons.YesNoCancel:
                    tabGroup.SelectedTabPage = YesNoCancel;
                    break;
                case MessageBoxButtons.YesNo:
                    tabGroup.SelectedTabPage = YesNo;
                    break;
                case MessageBoxButtons.RetryCancel:
                    tabGroup.SelectedTabPage = RetryCancel;
                    break;
            }      
            tabGroup.SelectedTabPage.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

            Icon messIcon = GetIconFromMessageBoxIcon(MessIconType);
            iconBox.Image = messIcon.ToBitmap();

            this.SuspendLayout();
            labelControl1.Text = myMessage;
            labelControl2.Text = myMessage;
            this.Text = myTitle;
            this.ResumeLayout();

            layoutControlItem1.MinSize = labelControl2.PreferredSize;
            this.Width = layoutControlGroup1.MinSize.Width + 40;
            this.Height = layoutControlGroup1.MinSize.Height + 70;


        }

        private Icon GetIconFromMessageBoxIcon(MessageBoxIcon icon)
        {
            if (icon == MessageBoxIcon.None) return null;
            if (icon == MessageBoxIcon.Asterisk) return SystemIcons.Asterisk;
            if (icon == MessageBoxIcon.Error) return SystemIcons.Error;
            if (icon == MessageBoxIcon.Exclamation) return SystemIcons.Exclamation;
            if (icon == MessageBoxIcon.Hand) return SystemIcons.Hand;
            if (icon == MessageBoxIcon.Information) return SystemIcons.Information;
            if (icon == MessageBoxIcon.Question) return SystemIcons.Question;
            if (icon == MessageBoxIcon.Warning) return SystemIcons.Warning;
            if (icon == MessageBoxIcon.Stop) return SystemIcons.Error;

            return null;
        }
        #endregion

        #region Click Button Return DialogResult

        private void btnOK1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void btnOK2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Dispose();
        }

        private void bntRetry1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Dispose();
        }
        
        private void btnIgnore_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
            this.Dispose();
        }

        private void btnYes1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Dispose();
        }

        private void btnNo1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Dispose();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void btnYes2_Click(object sender, EventArgs e)
        {
             this.DialogResult = DialogResult.Yes;
            this.Dispose();
        }

        private void btnNo2_Click(object sender, EventArgs e)
        {
                  this.DialogResult = DialogResult.No;
                 this.Dispose();
        }

        private void btnRetry2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Dispose();
        }

        private void bnCancel3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }
        #endregion

        private void eMASMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            isMessageHidden = this.checkEdit1.Checked;
            if (isMessageHidden)
            {
                messHiddenInfo = new GEUserMessagesHiddenInfo();
                int iADUserID = new ADUsersController().GetObjectIDByName(eMASApp.CurrentUser);
                messHiddenInfo.ADUserID = iADUserID;
                messHiddenInfo.GEMessagesID = messInfo.GEMessagesID;
                messHiddenInfo.GEMessageHiddenCount = 0;
                messHiddenController.CreateObject(messHiddenInfo);
                
            }
        }
    }
}
