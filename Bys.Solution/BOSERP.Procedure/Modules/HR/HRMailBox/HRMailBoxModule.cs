using BOSCommon;
using BOSCommon.Constants;
using BOSComponent;
using BOSERP.Modules.HR.HRMailBox.UI;
using BOSERP.Modules.HRMailBox.UI;
using BOSERP.Utilities;
using BOSLib;
using DevExpress.XtraNavBar;
using Localization;
using OpenPop.Mime;
using OpenPop.Mime.Header;
using OpenPop.Pop3;
using System;
using System.Configuration;
using System.Data;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace BOSERP.Modules.HRMailBox
{
    public class HRMailBoxModule : BaseModuleERP
    {
        #region Constant
        public const string PnlScreenContainerName = "fld_pnlScreenContainer";
        public const string NavBarMailName = "fld_navbarMail";
        public const string InboxScreenNumber = "DMHRMB100";
        public const string SentItemsScreenNumber = "DMHRMB101";
        public const string MainScreenNumber = "DMCS";
        public const string WebBrowserInboxName = "fld_wbsContentMail100";
        public const string WebBrowserSentItemName = "fld_wbsMailContent";
        public const string StatusStripMailName = "fld_statusStripMail";
        public const string SpaceString = " ";
        #endregion

        #region Private Variables
        private DateTime MaxDate;
        private BOSPanel PnlScreenContainer;
        private NavBarControl NavBarMail;
        private WebBrowser WebBrowserInbox;
        private WebBrowser WebBrowserSentItem;
        private String Link;
        private StatusStrip StatusStrip;
        private ToolStripStatusLabel ToolStripStatusLabel;
        private String MailMessageType;
        #endregion

        public HRMailBoxModule()
        {
            Name = "HRMailBox";
            CurrentModuleEntity = new HRMailBoxEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            MailMessageType = MailType.Inbox.ToString();
            StatusStrip = (StatusStrip)Controls[HRMailBoxModule.StatusStripMailName];
            StatusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            StatusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            ToolStripStatusLabel = new ToolStripStatusLabel();

            Link = MailBoxLocalizedResources.Inbox;
            InvalidateMailList(Link);
            InvalidateData(MailMessageType);
        }

        public override void InitializeScreens()
        {
            guiMailBox guiMailBox = new guiMailBox();
            guiMailBox.ScreenNumber = HRMailBoxModule.MainScreenNumber;
            guiMailBox.Module = this;
            guiMailBox.InitializeControls(guiMailBox.Controls);
            guiMailBox.AddControlsToParentScreen();
        }

        public override void Show()
        {
            base.Show();

            NavBarMail = (NavBarControl)Controls[HRMailBoxModule.NavBarMailName];
            // Create a Local group.
            NavBarGroup groupMail = new NavBarGroup(MailBoxLocalizedResources.MailBox);
            // Create an Inbox item .
            NavBarItem itemInbox = new NavBarItem(MailBoxLocalizedResources.Inbox);
            // Create a Sent Items item.
            NavBarItem itemSentItems = new NavBarItem(MailBoxLocalizedResources.SentItems);
            // Add the created items to the group and the group to the NavBarControl.
            // Prevent excessive updates using the BeginUpdate and EndUpdate methods.
            NavBarMail.BeginUpdate();
            NavBarMail.AllowSelectedLink = true;
            groupMail.SelectedLinkIndex = 0;
            NavBarMail.Groups.Add(groupMail);
            groupMail.ItemLinks.Add(itemInbox);
            groupMail.ItemLinks.Add(itemSentItems);
            groupMail.Expanded = true;
            NavBarMail.EndUpdate();
            //// Specify the event handler which will be invoked when any link is clicked.
            NavBarMail.LinkClicked += new NavBarLinkEventHandler(NavBarMail_LinkClicked);
        }

        public void NavBarMail_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            StatusStrip.Visible = false;
            if (e.Link.Caption.ToString() == MailBoxLocalizedResources.Inbox)
            {
                Link = e.Link.Caption.ToString();
            }

            if (e.Link.Caption.ToString() == MailBoxLocalizedResources.SentItems)
            {
                Link = e.Link.Caption.ToString();
            }

            InvalidateMailList(Link);
            InvalidateData(MailMessageType);

        }

        /// <summary>
        /// Invalidate mail list and its grid control when user change link in NavBar
        /// </summary>
        /// <param name="link">Selected link in NavBar Control</param>

        public void InvalidateMailList(string link)
        {
            if (link == MailBoxLocalizedResources.Inbox)
            {
                DMHRMB100 guiInbox = new DMHRMB100();
                guiInbox.ScreenNumber = HRMailBoxModule.InboxScreenNumber;
                guiInbox.Module = this;
                LoadScreen(guiInbox);
                MailMessageType = MailType.Inbox.ToString();

            }

            if (link == MailBoxLocalizedResources.SentItems)
            {
                DMHRMB101 guiSentItems = new DMHRMB101();
                guiSentItems.ScreenNumber = HRMailBoxModule.SentItemsScreenNumber;
                guiSentItems.Module = this;
                LoadScreen(guiSentItems);
                MailMessageType = MailType.SentItem.ToString();
            }

        }

        private void LoadScreen(BOSERPScreen screen)
        {
            PnlScreenContainer = (BOSPanel)Controls[HRMailBoxModule.PnlScreenContainerName];
            PnlScreenContainer.Controls.Clear();
            screen.AddCustomControls(this.Screens);
            screen.CustomizeControls(screen.Controls);
            screen.InitializeControls(screen.Controls);
            for (int i = 0; i < screen.Controls.Count; i++)
            {
                PnlScreenContainer.Controls.Add(screen.Controls[i]);
                i--;
            }
        }

        /// <summary>
        /// Invalidate data of mail list and its grid control 
        /// </summary>
        /// <param name="mailType">Type of mail:Inbox or SentItem</param>
        public void InvalidateData(string mailType)
        {
            int mailID = -1;
            HRMailBoxEntities entity = (HRMailBoxEntities)CurrentModuleEntity;
            HRMailsController objMailsController = new HRMailsController();
            int employeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            DataSet ds = objMailsController.GetMailListByMailTypeAndEmployeeID(mailType, employeeID);

            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                HRMailsInfo objMailsInfo = (HRMailsInfo)objMailsController.GetObjectFromDataRow(row);
                MaxDate = objMailsInfo.MaxDate;
                mailID = objMailsInfo.HRMailID;

            }
            else
            {
                MaxDate = DateTime.MaxValue;
            }

            entity.HRMailsList.Invalidate(ds);

            if (mailID != -1)
            {
                if (Link == MailBoxLocalizedResources.Inbox)
                    LoadInboxContentMail(mailID);
                else
                    LoadSentItemContentMail(mailID);
            }

        }

        /// <summary>
        ///  Load mail content of Inbox items into Web Browser
        /// </summary>
        /// <param name="mailID">ID of mail</param>
        public void LoadInboxContentMail(int mailID)
        {
            WebBrowserInbox = (WebBrowser)Controls[HRMailBoxModule.WebBrowserInboxName];
            string htmlContent = ShowHtmlMessage(mailID);
            WebBrowserInbox.DocumentText = htmlContent;

        }

        /// <summary>
        ///  Load mail content of Sent Item into Web Browser
        /// </summary>
        /// <param name="mailID">ID of mail</param>
        public void LoadSentItemContentMail(int mailID)
        {
            WebBrowserSentItem = (WebBrowser)Controls[HRMailBoxModule.WebBrowserSentItemName];
            string htmlContent = ShowHtmlMessage(mailID);
            WebBrowserSentItem.DocumentText = htmlContent;
        }

        /// <summary>
        ///  get all messages from a POP3 server
        /// </summary>

        public void GetAllMessages()
        {
            string userName = String.Empty;
            string password = String.Empty;
            //Update MaxDate
            InvalidateData(MailType.Inbox.ToString());
            //Update Status
            ToolStripStatusLabel.Text = MailBoxLocalizedResources.ReceivingMessage;
            StatusStrip.Visible = true;
            StatusStrip.Items.Add(ToolStripStatusLabel);
            StatusStrip.Update();

            // Get value from ConfigurationManager
            System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string hostName = configuration.AppSettings.Settings["Pop3Server"].Value.ToString();
            int port = Convert.ToInt32(configuration.AppSettings.Settings["Pop3Port"].Value.ToString());
            bool useSsl = true;

            //get username and decryption password
            Crypto crypto = new Crypto();
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
            objEmployeesInfo.HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objEmployeesInfo.HREmployeeID);

            if (objEmployeesInfo != null)
            {
                userName = objEmployeesInfo.HREmployeeEmail1.ToString();
                string passAccessSMTP = objEmployeesInfo.HREmployeePassword1.ToString();
                password = crypto.Decrypt(passAccessSMTP);
                #region Pop3
                Pop3Client client = new Pop3Client();

                try
                {
                    if (client.Connected)
                        client.Disconnect();
                    // Connect to the server
                    client.Connect(hostName, port, useSsl);

                    // Authenticate towards the server
                    client.Authenticate(userName, password);

                    // Get the number of messages in the inbox
                    int messageCount = client.GetMessageCount();


                    OpenPop.Mime.Message message;

                    // Messages are numbered in the interval: [messageCount,1]

                    for (int i = messageCount; i >= 1; i -= 1)
                    {
                        try
                        {
                            MessageHeader headers = client.GetMessageHeaders(i);

                            if (headers.DateSent > MaxDate)
                            {
                                message = client.GetMessage(i);

                                SaveAllNewMessage(message);
                            }
                            if (headers.DateSent <= MaxDate)
                                break;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            #endregion
            //Update status and grid control when mails complete receiving
            if (Link == MailBoxLocalizedResources.Inbox)
            {
                InvalidateMailList(Link);
                InvalidateData(MailMessageType);
                ToolStripStatusLabel.Text = MailBoxLocalizedResources.CompleteReceiveMessage;
                StatusStrip.Items.Add(ToolStripStatusLabel);
                StatusStrip.Update();
            }
            else
            {
                ToolStripStatusLabel.Text = MailBoxLocalizedResources.CompleteReceiveMessage;
                StatusStrip.Items.Add(ToolStripStatusLabel);
                StatusStrip.Update();
            }


        }

        /// <summary>
        ///  Save all messages which get from POP3 server 
        /// </summary>
        /// <param name="msg">Mail message that get from POP3 server</param>
        private void SaveAllNewMessage(OpenPop.Mime.Message msg)
        {

            MailMessage message = new MailMessage();
            message = msg.ToMailMessage();
            System.Net.Mail.MailPriority mailPriority = msg.Headers.Importance;

            HRMailBoxEntities entity = (HRMailBoxEntities)CurrentModuleEntity;
            HRMailsController objMailsController = new HRMailsController();
            HRMailsInfo objMailsInfo = new HRMailsInfo();
            objMailsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objMailsInfo.HRMailDate = msg.Headers.DateSent;
            objMailsInfo.HRMailPriority = mailPriority.ToString();
            objMailsInfo.HRMailSendFrom = message.From.ToString();
            objMailsInfo.HRMailSendTo = message.To.ToString();
            objMailsInfo.HRMailSubject = message.Subject;
            objMailsInfo.HRMailType = MailType.Inbox.ToString();
            entity.ModuleObjects[TableName.HRMailsTableName] = objMailsInfo;
            int mailID = entity.SaveEmail();

            //Get file attachment
            GetFileAttachment(msg, mailID);

            // Save Body of mail to file .txt
            string pathMail = Application.StartupPath.ToString();
            pathMail = string.Format("{0}\\MailBox\\Inbox\\{1}.txt", pathMail, mailID.ToString());
            if (File.Exists(pathMail))
                File.Delete(pathMail);
            FindHtmlInMessage(msg, pathMail);

        }

        #region HTML string
        /// <summary>
        ///  Find a html version in a Message
        /// </summary>
        /// <param name="message"> message which get from server</param>
        /// <param name="fileName">name of file to save html string</param>

        public void FindHtmlInMessage(OpenPop.Mime.Message message, string fileName)
        {
            MessagePart html = message.FindFirstHtmlVersion();
            if (html != null)
            {
                string htmlString = html.GetBodyAsText();
                File.WriteAllText(fileName, htmlString, Encoding.UTF8);
            }
        }

        /// <summary>
        /// Show all of content of mail in web browser
        /// </summary>
        /// <param name="mailID">ID of mail</param>
        /// <returns></returns>
        public string ShowHtmlMessage(int mailID)
        {
            string htmlString = String.Empty;
            string mailContent = String.Empty;
            //get body of mail
            string pathMail = Application.StartupPath;
            pathMail = string.Format("{0}\\MailBox\\Inbox\\{1}.txt", pathMail, mailID.ToString());
            if (File.Exists(pathMail))
                htmlString = File.ReadAllText(pathMail, Encoding.UTF8);

            //get html string for attachment
            string contentAttachment = ShowAttachment(mailID);

            //Picture link
            string pathMailAttachment = Application.StartupPath.ToString();
            pathMailAttachment = string.Format("{0}\\img\\{1}", pathMailAttachment, "attachment.jpg");
            string pathEnvelope = Application.StartupPath.ToString();
            pathEnvelope = string.Format("{0}\\img\\{1}", pathEnvelope, "email.png");

            //get MailFrom and DateSent
            HRMailsController objMailsController = new HRMailsController();
            HRMailsInfo objMailsInfo = new HRMailsInfo();
            objMailsInfo.HRMailID = mailID;
            objMailsInfo = (HRMailsInfo)objMailsController.GetObjectByID(objMailsInfo.HRMailID);

            //Mail Content
            if (objMailsInfo != null)
            {
                mailContent = "<html>" +
                                   " <body>" +
                                   "<table border='0' width='100%'>" +
                                   "<tr>" +
                                   "<td>" + MailBoxLocalizedResources.MailTo + " " + objMailsInfo.HRMailSendFrom + "</td>" +
                                   "<td rowspan='2'>" + "<img src='" + pathEnvelope + "' alt=''/>" + "</td>" +
                                   "</tr>" +
                                   "<tr>" +
                                   "<td>" + MailBoxLocalizedResources.Time + " " + objMailsInfo.HRMailDate + "</td>" +
                                   "</tr>" +
                                   "</table>";
                if (contentAttachment != String.Empty)
                {
                    mailContent += "<p>" + MailBoxLocalizedResources.AttachmentFile + " " +
                                    "<img src='" + pathMailAttachment + "' alt=''/>" +
                                    contentAttachment + "</p>" +
                                    "<p> <hr align='center' color='lightgray'></p>" +
                                    "<p>" + MailBoxLocalizedResources.MailContent + " " + "</p>" +
                                    "<p>" + htmlString + "</p>" +
                                    "</body></html>";
                }
                else
                {
                    mailContent += "<p> <hr align='center' color='lightgray'></p>" +
                                     "<p>" + MailBoxLocalizedResources.MailContent + " " + "</p>" +
                                     "<p>" + htmlString + "</p>" +
                                     "</body></html>";
                }
            }
            return mailContent;
        }

        #endregion

        #region Attachment
        /// <summary>
        /// Add file attachment into html string
        /// </summary>
        /// <param name="mailID">ID of mail</param>
        /// <returns></returns>
        public string ShowAttachment(int mailID)
        {
            HRMailBoxEntities entity = (HRMailBoxEntities)CurrentModuleEntity;
            HRMailAttachmentsController objMailAttachmentsController = new HRMailAttachmentsController();
            string content = String.Empty;
            string pathMailAttachment = String.Empty;


            //get dataset of mail attachment
            DataSet ds = objMailAttachmentsController.GetAllDataByForeignColumn("FK_HRMailID", mailID);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    HRMailAttachmentsInfo objMailAttachmentsInfo = (HRMailAttachmentsInfo)objMailAttachmentsController.GetObjectFromDataRow(row);
                    string fileName = (objMailAttachmentsInfo.HRMailAttachmentID + objMailAttachmentsInfo.HRMailAttachmentName).ToString();
                    if (fileName.Contains(SpaceString))
                        fileName = fileName.Replace(SpaceString, String.Empty);
                    pathMailAttachment = Application.StartupPath.ToString();
                    pathMailAttachment = string.Format("{0}\\MailBox\\Attachment\\{1}", pathMailAttachment, fileName);
                    string linkFile = objMailAttachmentsInfo.HRMailAttachmentName.ToString() +
                                        Convert.ToChar(40).ToString() +
                                        objMailAttachmentsInfo.HRMailAttachmentFileSize +
                                        " " + objMailAttachmentsInfo.HRMailAttachmentFileType +
                                        Convert.ToChar(41).ToString();
                    content +=
                        "<a href='" + pathMailAttachment + "'>" + linkFile + "</a> ; ";
                }
            }
            return content;
        }

        /// <summary>
        /// Get value of File Attachment from message
        /// </summary>
        /// <param name="message">Message which get from server</param>
        /// <param name="mailID">ID of mail that have attachment file</param>
        public void GetFileAttachment(OpenPop.Mime.Message message, int mailID)
        {
            foreach (MessagePart attachment in message.FindAllAttachments())
            {
                string fileAttachment = attachment.FileName;

                //get file name
                string nameOfFile = fileAttachment.Substring(0, fileAttachment.Length);

                //save temp file to get file size
                string pathAttachment = Application.StartupPath.ToString();
                pathAttachment = string.Format("{0}\\MailBox\\Attachment\\{1}", pathAttachment, attachment.FileName);
                if (File.Exists(pathAttachment))
                    File.Delete(pathAttachment);
                File.WriteAllBytes(pathAttachment, attachment.Body);

                //get size of file
                FileInfo fileInfo = new FileInfo(pathAttachment);
                long bytes = fileInfo.Length;

                //get file type
                string fileType = String.Empty;
                ChangeSize changeSize = new ChangeSize();
                double size = changeSize.ConvertBytesToMegabytes(bytes);
                if (size >= 1)
                    fileType = AttachmentFileType.MB.ToString();
                else
                {
                    size = changeSize.ConvertBytesToKiloBytes(bytes);
                    fileType = AttachmentFileType.KB.ToString();
                }

                SaveAttachment(pathAttachment, nameOfFile, fileType, size, mailID);

            }

        }

        /// <summary>
        /// Save Attachment to database
        /// </summary>
        /// <param name="fileTemp">Temp picture file that to get picture size</param>
        /// <param name="mailAttachmentName">Name of file attachment</param>
        /// <param name="mailAttachmentFileType">Type of file attachment to save into database: KB or MB</param>
        /// <param name="mailAttachmentFileSize">Size of file attachment</param>
        /// <param name="mailID">ID of mail</param>
        public void SaveAttachment(string fileTemp, string mailAttachmentName, string mailAttachmentFileType, double mailAttachmentFileSize, int mailID)
        {
            HRMailBoxEntities entity = (HRMailBoxEntities)CurrentModuleEntity;
            HRMailAttachmentsController objMailAttachmentsController = new HRMailAttachmentsController();
            HRMailAttachmentsInfo objMailAttachmentsInfo = new HRMailAttachmentsInfo();
            objMailAttachmentsInfo.FK_HRMailID = mailID;
            objMailAttachmentsInfo.HRMailAttachmentName = mailAttachmentName;
            objMailAttachmentsInfo.HRMailAttachmentFileType = mailAttachmentFileType;
            objMailAttachmentsInfo.HRMailAttachmentFileSize = mailAttachmentFileSize.ToString();
            entity.ModuleObjects[TableName.HRMailAttachmentsTableName] = objMailAttachmentsInfo;

            string fileName = entity.SaveAttachment();
            if (fileName.Contains(SpaceString))
                fileName = fileName.Replace(SpaceString, String.Empty);

            //get file path to save file
            string pathAttachment = Application.StartupPath.ToString();
            pathAttachment = string.Format("{0}\\MailBox\\Attachment\\{1}", pathAttachment, fileName);
            if (File.Exists(pathAttachment))
                File.Delete(pathAttachment);
            File.Copy(fileTemp, pathAttachment);

            //Delete file temp
            if (File.Exists(fileTemp))
                File.Delete(fileTemp);
        }
        #endregion

        #region Send Email
        /// <summary>
        /// Show screen to send a new mail
        /// </summary>
        public void ShowEmail()
        {
            guiSendEmail guiSendEmail = new guiSendEmail();
            guiSendEmail.Module = this;
            MailHelper sendMail = new MailHelper();

            // Set value for guiSendMail Variables
            HRMailsInfo objMailsInfo = guiSendEmail.MailInfo;
            if (objMailsInfo != null)
            {
                objMailsInfo.HRMailSendTo = String.Empty;
                objMailsInfo.HRMailSubject = String.Empty;
                guiSendEmail.ContentRtb = String.Empty;
            }

            if (guiSendEmail.ShowDialog() == DialogResult.OK)
            {
                if (objMailsInfo != null)
                {
                    string mailFrom = objMailsInfo.HRMailSendFrom.ToString();
                    string contactMail = objMailsInfo.HRMailSendTo.ToString();
                    string subject = objMailsInfo.HRMailSubject;
                    RichTextBoxExtended contentRtb = new RichTextBoxExtended();
                    contentRtb.RichTextBox.Rtf = guiSendEmail.ContentRtb;
                    System.Windows.Forms.ListBox listFile = new System.Windows.Forms.ListBox();
                    listFile = guiSendEmail.ListFileChecked;
                    System.Net.Mail.MailPriority mailPriority = sendMail.SetPriority(objMailsInfo.HRMailPriority.ToString());
                    ToolStripStatusLabel.Text = MailBoxLocalizedResources.SendingMessage;
                    StatusStrip.Visible = true;
                    StatusStrip.Items.Add(ToolStripStatusLabel);
                    StatusStrip.Update();
                    Send(mailFrom, contactMail, subject, contentRtb, listFile, mailPriority);
                }
            }
        }

        /// <summary>
        /// Send email
        /// </summary>
        /// <param name="mailTo">Mail address to send to</param>
        /// <param name="subject">Subject of mail</param>
        /// <param name="mailFrom">Send from mail address</param>
        /// <param name="contentRichTextBoxExtended">Control that contains content of mail</param>
        /// <param name="attachmentListBox">List contains attachment file</param>
        /// <param name="mailPriority">Priority of mail</param>
        public void Send(string mailFrom, string mailTo, string subject, RichTextBoxExtended contentRichTextBoxExtended, System.Windows.Forms.ListBox attachmentListBox, System.Net.Mail.MailPriority mailPriority)
        {

            MailHelper sendMail = new MailHelper();
            sendMail.MailTo = mailTo;
            sendMail.Subject = subject;
            sendMail.MailFrom = mailFrom;
            sendMail.MailPriority = mailPriority;
            RtfConverter rtfConverter = new RtfConverter();
            rtfConverter.RichTextBoxExtended = contentRichTextBoxExtended.RichTextBox.Rtf;
            string htmlString = rtfConverter.Html;

            bool check = sendMail.Send(htmlString, attachmentListBox);
            if (check == true)
                sendMail.SaveEmail(mailTo, mailFrom, subject, htmlString, mailPriority);

            //Update status when mail completes sending
            ToolStripStatusLabel.Text = MailBoxLocalizedResources.CompleteSendMessage;
            StatusStrip.Items.Add(ToolStripStatusLabel);
            StatusStrip.Update();

            //Update navbar and Invalidate Sent Item mail list and its grid control
            if (Link == MailBoxLocalizedResources.SentItems)
            {
                InvalidateMailList(Link);
                InvalidateData(MailMessageType);
            }

        }
        #endregion

        #region Search Mail
        /// <summary>
        /// Show screen to search mail
        /// </summary>
        public void ShowSearchMail()
        {
            guiSearchMail guiSearchMail = new guiSearchMail();
            guiSearchMail.Module = this;
            if (guiSearchMail.ShowDialog() == DialogResult.OK)
            {
                string searchQuery = guiSearchMail.SearchQuery.ToString();
                Search(searchQuery, BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            }
        }

        /// <summary>
        /// Search mail when user push button Search
        /// </summary>
        /// <param name="searchQuery">Query string to get dataset</param>
        /// <param name="employeeID">ID of employee</param>
        public void Search(string searchQuery, int employeeID)
        {
            string mailType = String.Empty;
            if (Link == MailBoxLocalizedResources.Inbox)
                mailType = MailType.Inbox.ToString();
            else
                mailType = MailType.SentItem.ToString();

            StringBuilder queryBuilder = new StringBuilder();
            queryBuilder.Append(searchQuery);
            queryBuilder.Append(string.Format("and (HRMailType = '{0}')", mailType));
            queryBuilder.Append(string.Format("and (FK_HREmployeeID= '{0}')", employeeID));
            queryBuilder.Append(string.Format("order by HRMailDate {0}", "desc"));
            SearchMail(queryBuilder.ToString());
        }

        /// <summary>
        /// Search mail from query
        /// </summary>
        /// <param name="searchQuery">Query string to search mail</param>
        public void SearchMail(string searchQuery)
        {
            int mailID = -1;
            HRMailBoxEntities entity = (HRMailBoxEntities)CurrentModuleEntity;
            HRMailsController objMailsController = new HRMailsController();
            DataSet dsMail = null;
            HREmployeesController objEmployeesController = new HREmployeesController();
            DataSet ds = objEmployeesController.GetDataSet(searchQuery);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Columns.Add("AASelected", typeof(Boolean));
                dsMail = ds;
                DataRow row = ds.Tables[0].Rows[0];
                HRMailsInfo objMailsInfo = (HRMailsInfo)objMailsController.GetObjectFromDataRow(row);
                mailID = Convert.ToInt32(objMailsInfo.HRMailID.ToString());
            }
            entity.HRMailsList.Invalidate(ds);
            InvalidateMailList(Link);
            if (mailID != -1)
            {
                if (Link == MailBoxLocalizedResources.Inbox)
                    LoadInboxContentMail(mailID);
                else
                    LoadSentItemContentMail(mailID);
            }
        }

        #endregion

        #region Web Browser 
        /// <summary>
        /// Get link of file attachment that was clicked on web browser
        /// </summary>
        /// <param name="webBrowser">control that contains content of mail</param>
        public void GetLink(WebBrowser webBrowser)
        {
            HtmlElementCollection links = webBrowser.Document.GetElementsByTagName("A");
            foreach (HtmlElement link in links)
            {
                link.MouseDown += new HtmlElementEventHandler(Link_MouseDown);
            }
        }

        private void Link_MouseDown(object sender, HtmlElementEventArgs e)
        {
            if (e.MouseButtonsPressed == MouseButtons.Left)
            {
                HtmlElement html = (HtmlElement)sender;
                string url = html.GetAttribute("href").ToString();
                url = url.Replace("file:///", String.Empty);
                //get file name
                string mark = Convert.ToChar(47).ToString();
                if (url != String.Empty)
                {
                    if (url.Contains(mark))
                    {
                        int posMark = url.LastIndexOf(mark);
                        string fileName = url.Substring(posMark + mark.Length, url.Length - posMark - mark.Length);
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.FileName = fileName;
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            url = Uri.UnescapeDataString(url);
                            string destFile = saveFileDialog.FileName;
                            File.Copy(url, destFile, true);
                        }
                    }
                }
            }
        }
        #endregion
    }
}
