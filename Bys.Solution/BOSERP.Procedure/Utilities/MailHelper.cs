using BOSCommon;
using BOSLib;
using Localization;
using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace BOSERP.Utilities
{
    public class MailHelper
    {
        #region Constant
        private const string Bytes = "bytes";
        #endregion

        #region Declare Varibles
        private int FileSizeAttach;
        private int TempFileSizeAttach;
        private ListBox ListAttach;
        private CheckedListBox TempCheckListBox;
        private ListBox ListMailAttachment;
        private String SpaceString;
        #endregion

        #region Public Properties
        /// <summary>
        /// Mail From in email
        /// </summary>
        public String MailFrom { get; set; }
        /// <summary>
        /// Mail To
        /// </summary>
        public String MailTo { get; set; }
        /// <summary>
        /// Smtp Server
        /// </summary>
        public String MailSmtpServer { get; set; }
        /// <summary>
        /// Text Message
        /// </summary>
        public String TextMessage { get; set; }
        /// <summary>
        /// Subject of mail
        /// </summary>
        public String Subject { get; set; }
        /// <summary>
        /// Priority of mail
        /// </summary>
        public System.Net.Mail.MailPriority MailPriority { get; set; }

        #endregion

        #region Constructor
        public MailHelper()
        {
            ListAttach = new ListBox();
            TempCheckListBox = new CheckedListBox();
            TempFileSizeAttach = 0;
            ListMailAttachment = new ListBox();
            SpaceString = " ";
        }
        #endregion

        #region Validate Email
        /// <summary>
        /// Validate Email
        /// </summary>
        /// <param name="email">Email address</param>
        public bool ValidateEmail(string email)
        {

            Regex exp = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            Match m = exp.Match(email);

            if (m.Success && m.Value.Equals(email)) return true;

            else return false;

        }
        #endregion

        #region Send Email
        /// <summary>
        /// Send Email with SMTP
        /// </summary>
        /// <param name="html">Content of mail </param>
        /// <param name="listFile">List of file attachments</param>

        public bool Send(string html, ListBox listFile)
        {
            SmtpClient smtpClient = new SmtpClient();
            bool check = false;
            //get mail address and password of user
            Crypto crypto = new Crypto();
            HREmployeesController objEmployeesController = new HREmployeesController();
            HREmployeesInfo objEmployeesInfo = new HREmployeesInfo();
            objEmployeesInfo.HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objEmployeesInfo = (HREmployeesInfo)objEmployeesController.GetObjectByID(objEmployeesInfo.HREmployeeID);

            if (objEmployeesInfo != null)
            {
                string mailFrom = objEmployeesInfo.HREmployeeEmail1.ToString();
                string mailAccessSMTP = objEmployeesInfo.HREmployeeEmail1.ToString();
                string password = objEmployeesInfo.HREmployeePassword1.ToString();
                string passAccessSMTP = crypto.Decrypt(password);

                // Get value from ConfigurationManager
                System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string smtpServer = configuration.AppSettings.Settings["SmtpServer"].Value.ToString();
                int port = Convert.ToInt32(configuration.AppSettings.Settings["Port"].Value.ToString());
                int timeOut = Convert.ToInt32(configuration.AppSettings.Settings["TimeOut"].Value.ToString());

                try
                {
                    MailMessage mailMessage = new MailMessage();
                    smtpClient.Host = smtpServer;
                    smtpClient.Port = port;
                    mailMessage.To.Clear();
                    ///add the address of the receiver
                    try
                    {
                        //Mail To
                        if (AddMailTo(mailMessage, MailTo) == true)
                        {
                            // Mail Subject 
                            mailMessage.SubjectEncoding = Encoding.UTF8;
                            mailMessage.Subject = Subject;
                            // Mail Priority
                            mailMessage.Priority = MailPriority;
                            //Add mail body
                            mailMessage.BodyEncoding = Encoding.UTF8;
                            mailMessage.Body = html;
                            mailMessage.IsBodyHtml = true;
                            //Mail From
                            mailMessage.From = new MailAddress(mailFrom);

                            smtpClient.EnableSsl = true;
                            smtpClient.UseDefaultCredentials = false;
                            smtpClient.Credentials = new NetworkCredential(mailAccessSMTP, passAccessSMTP);

                            //Mail Attachment
                            AddMailAttachment(mailMessage, listFile);

                            smtpClient.Timeout = timeOut;
                            smtpClient.Send(mailMessage);

                            listFile.Items.Clear();
                            MessageBox.Show(CommonLocalizedResources.MailSentMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            check = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        check = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    check = false;
                }
            }
            return check;
        }
        #endregion

        #region Mail To
        /// <summary>
        /// Add list of mailTo to mailMessage
        /// </summary>
        /// <param name="mailMessage">A mail message</param>
        /// <param name="mailTo">List of mail addresses to send to</param>
        /// <returns></returns>
        private bool AddMailTo(MailMessage mailMessage, string mailTo)
        {
            bool check = true;
            try
            {
                string split = ";";
                if (MailTo.Contains(split))
                {
                    string[] toList = MailTo.Trim().Split(split.ToCharArray());
                    for (int i = 0; i < toList.Length; i++)
                    {
                        if (toList[i].Contains(SpaceString))
                            toList[i] = toList[i].Replace(SpaceString, String.Empty);
                        if (ValidateEmail(toList[i]) == true)
                            mailMessage.To.Add(toList[i].Trim());
                        else
                        {
                            MessageBox.Show(CommonLocalizedResources.MailAddressErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            check = false;
                            break;
                        }
                    }
                }
                else
                {
                    if (ValidateEmail(MailTo) == true)
                        mailMessage.To.Add(MailTo.Trim());
                    else
                    {
                        check = false;
                        MessageBox.Show(CommonLocalizedResources.MailAddressErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(CommonLocalizedResources.MailErrorMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
            return check;
        }
        #endregion

        #region File Attachment

        #region Add attachment to mail message
        /// <summary>
        /// Add attachment to mail message
        /// </summary>
        /// <param name="mailMessage">A mail message</param>
        /// <param name="listFile">List of file attachments of mail message</param>

        public void AddMailAttachment(MailMessage mailMessage, ListBox listFile)
        {
            try
            {
                System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                string mediaType = configuration.AppSettings.Settings["MediaType"].Value.ToString();
                string fileName = String.Empty;
                if (listFile.Items.Count > 0)
                {
                    for (int i = 0; i < listFile.Items.Count; i++)
                    {
                        listFile.SelectedIndex = i;
                        fileName = listFile.Text;
                        Attachment emailAttachment = new Attachment(fileName);
                        emailAttachment.ContentDisposition.Inline = false;
                        emailAttachment.ContentDisposition.DispositionType = DispositionTypeNames.Attachment;
                        emailAttachment.ContentType.MediaType = mediaType;
                        emailAttachment.ContentType.Name = Path.GetFileName(fileName);
                        mailMessage.Attachments.Add(emailAttachment);
                        ListMailAttachment.Items.Add(listFile.Items[i].ToString());
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Add File Attachment
        /// <summary>
        /// Add File Attachment from CheckListBox
        /// </summary>
        /// <param name="attachmentCheckedListBox">List file attachments that users want to add </param>
        /// <returns></returns>
        public ListBox AddFileAttachment(CheckedListBox attachmentCheckedListBox)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            int sizeFileConfig = Convert.ToInt32(configuration.AppSettings.Settings["FileSizeAttach"].Value);
            int sizeFile = sizeFileConfig;
            string fileName = String.Empty;
            int size = 0;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //File size attachment <= sizeFileConfig
                try
                {
                    UpdateFileSizeAttachment(attachmentCheckedListBox, -1);
                    if (attachmentCheckedListBox.Items.Count == 0)
                        FileSizeAttach = 0;
                    else
                        FileSizeAttach = TempFileSizeAttach;
                    FileSizeAttach = FileSizeAttach + Convert.ToInt32(openFileDialog.OpenFile().Length.ToString());
                    TempFileSizeAttach = FileSizeAttach;

                    ChangeSize changeSize = new ChangeSize();
                    double sizeConvert = changeSize.ConvertBytesToMegabytes(FileSizeAttach);
                    if (sizeConvert <= sizeFile)
                    {
                        size = Convert.ToInt32(openFileDialog.OpenFile().Length.ToString());
                        fileName = Path.GetFileName(openFileDialog.FileName);
                        attachmentCheckedListBox.Items.Add(fileName + Convert.ToChar(40) + size + " " + Bytes.ToString() + Convert.ToChar(41), true);
                        ListAttach.Items.Add(openFileDialog.FileName);
                    }
                    else
                    {
                        MessageBox.Show(string.Format(CommonLocalizedResources.InvalidAttachedFileSizeMessage, sizeFileConfig), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return ListAttach;
        }
        #endregion

        #region Get File Attachment
        /// <summary>
        /// Get files that have been checked in checklistbox
        /// </summary>
        /// <param name="attachmentCheckedListBox">List of file attachments that have been checked</param>
        /// <returns></returns>
        public ListBox GetFileAttachment(CheckedListBox attachmentCheckedListBox)
        {
            ListBox listFile = new ListBox();
            string fileName = String.Empty;
            CheckedListBox.CheckedItemCollection checkedItems = attachmentCheckedListBox.CheckedItems;
            for (int i = 0; i < checkedItems.Count; i++)
            {
                string fileCheck = checkedItems[i].ToString();
                char check = Convert.ToChar(40);
                int pos = fileCheck.LastIndexOf(check);
                fileName = fileCheck.Substring(0, pos - check.ToString().Length);
                for (int j = 0; j < ListAttach.Items.Count; j++)
                {
                    string listItem = ListAttach.Items[j].ToString();
                    if (listItem.Contains(fileName))
                    {
                        listFile.Items.Add(ListAttach.Items[j].ToString());
                    }
                }
            }
            ListAttach.Items.Clear();

            return listFile;
        }

        #endregion

        #region Update file size attachment
        /// <summary>
        /// Update file size of file attachments when user checks or unchecks an item in CheckedListBox file
        /// </summary>
        /// <param name="attachmentCheckedListBox">List of file attachments that have been checked</param>
        /// <param name="index">Index of list that user is selecting</param>
        public void UpdateFileSizeAttachment(CheckedListBox attachmentCheckedListBox, int index)
        {

            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            int sizeFileConfig = Convert.ToInt32(configuration.AppSettings.Settings["FileSizeAttach"].Value);
            int sizeFile = sizeFileConfig;
            ListBox listFile = new ListBox();
            string file = String.Empty;
            FileSizeAttach = 0;
            TempFileSizeAttach = 0;
            double sizeConvert = 0;
            ChangeSize changeSize = new ChangeSize();

            CheckedListBox.CheckedItemCollection checkedItems;
            checkedItems = attachmentCheckedListBox.CheckedItems;

            for (int i = 0; i < checkedItems.Count; i++)
            {
                string fileCheck = checkedItems[i].ToString();

                char check = Convert.ToChar(40);
                char checkEnd = Convert.ToChar(41);

                int pos = fileCheck.LastIndexOf(check);
                int posEnd = fileCheck.LastIndexOf(checkEnd);

                file = fileCheck;
                int length = posEnd - checkEnd.ToString().Length - Bytes.ToString().Length - pos - check.ToString().Length;
                file = fileCheck.Substring(pos + check.ToString().Length, length);

                int fileSize = Convert.ToInt32(file);

                FileSizeAttach = FileSizeAttach + fileSize;
                TempFileSizeAttach = FileSizeAttach;

                sizeConvert = changeSize.ConvertBytesToMegabytes(FileSizeAttach);
                if (sizeConvert > sizeFile)
                {
                    MessageBox.Show(string.Format(CommonLocalizedResources.InvalidAttachedFileSizeMessage, sizeFileConfig), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            sizeConvert = changeSize.ConvertBytesToMegabytes(FileSizeAttach);

            if (sizeConvert <= sizeFile)
            {
                if (index != -1)
                {
                    bool isCheck = attachmentCheckedListBox.GetItemChecked(index);
                    if (isCheck == false)
                        attachmentCheckedListBox.SetItemChecked(index, false);
                    else
                        attachmentCheckedListBox.SetItemChecked(index, true);
                }
            }
            if (sizeConvert > sizeFile)
            {
                if (index != -1)
                {
                    attachmentCheckedListBox.SetItemChecked(index, false);
                }
            }

        }

        #endregion

        #endregion


        #region HRMails
        /// <summary>
        /// Save an object mail to HRMails
        /// </summary>
        /// <param name="mailTo">Mail address to send to</param>
        /// <param name="mailFrom">Send from mail address</param>
        /// <param name="subject">Subject of mail</param>
        /// <param name="htmlString">Content of mail</param>
        /// <param name="priority">Priority of mail</param>
        public void SaveEmail(string mailTo, string mailFrom, string subject, string htmlString, System.Net.Mail.MailPriority priority)
        {
            HRMailsController objMailsController = new HRMailsController();
            HRMailsInfo objMailsInfo = new HRMailsInfo();
            string mailPriority = priority.ToString();
            objMailsInfo.HRMailDate = DateTime.Now;
            objMailsInfo.HRMailPriority = mailPriority;
            objMailsInfo.HRMailSendTo = mailTo;
            objMailsInfo.HRMailSubject = subject;
            objMailsInfo.HRMailSendFrom = mailFrom;
            objMailsInfo.HRMailType = MailType.SentItem.ToString();
            objMailsInfo.FK_HREmployeeID = BOSApp.CurrentUsersInfo.FK_HREmployeeID;
            objMailsController.CreateObject(objMailsInfo);

            GetMailAttachment(ListMailAttachment, objMailsInfo.HRMailID);

            //Save html string to file
            string pathMail = Application.StartupPath.ToString();
            pathMail = string.Format("{0}\\MailBox\\Inbox\\{1}.txt", pathMail, objMailsInfo.HRMailID.ToString());
            if (File.Exists(pathMail))
                File.Delete(pathMail);
            File.WriteAllText(pathMail, htmlString);
        }

        /// <summary>
        /// Set Priority of mail
        /// </summary>
        /// <param name="mailPriority">Priority of mail</param>
        /// <returns></returns>
        public System.Net.Mail.MailPriority SetPriority(string mailPriority)
        {
            System.Net.Mail.MailPriority priority = new System.Net.Mail.MailPriority();
            if (mailPriority == BOSCommon.MailPriority.High.ToString())
                priority = System.Net.Mail.MailPriority.High;
            else if (mailPriority == BOSCommon.MailPriority.Normal.ToString())
                priority = System.Net.Mail.MailPriority.Normal;
            else
                priority = System.Net.Mail.MailPriority.Low;
            return priority;
        }

        #endregion

        #region HRMailAttachments
        #region Get Mail Attachment value to save into Database
        /// <summary>
        /// Get Mail Attachment value to save into Database
        /// </summary>
        /// <param name="listFile">List of file name of file attachment</param>
        public void GetMailAttachment(ListBox listFile, int mailID)
        {
            string fileName = String.Empty;
            if (listFile.Items.Count > 0)
            {
                for (int i = 0; i < listFile.Items.Count; i++)
                {
                    listFile.SelectedIndex = i;
                    fileName = listFile.Items[i].ToString();

                    //get name of file
                    string dotMark = Convert.ToChar(92).ToString();
                    int posDotMark = fileName.LastIndexOf(dotMark);
                    string nameOfFile = fileName.Substring(posDotMark + dotMark.Length, fileName.Length - posDotMark - dotMark.Length);
                    //get file size
                    FileInfo fileInfo = new FileInfo(fileName);
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
                    SaveMailAttachment(fileName, mailID, nameOfFile, fileType, size);
                }
            }
        }

        #endregion

        #region Save mail attachment to database
        /// <summary>
        /// Save mail attachment value to database
        /// </summary>
        /// <param name="mailID">ID of mail</param>
        /// <param name="mailAttachmentName">name of file attachment</param>
        /// <param name="mailAttachmentFileType">type of file attachment</param>
        /// <param name="mailAttachmentFileSize">size of file attachment</param>
        public void SaveMailAttachment(string fileName, int mailID, string mailAttachmentName, string mailAttachmentFileType, double mailAttachmentFileSize)
        {

            HRMailAttachmentsController objMailAttachmentsController = new HRMailAttachmentsController();
            HRMailAttachmentsInfo objMailAttachmentsInfo = new HRMailAttachmentsInfo();
            objMailAttachmentsInfo.FK_HRMailID = Convert.ToInt32(mailID);
            objMailAttachmentsInfo.HRMailAttachmentName = mailAttachmentName.ToString();
            objMailAttachmentsInfo.HRMailAttachmentFileType = mailAttachmentFileType.ToString();
            objMailAttachmentsInfo.HRMailAttachmentFileSize = mailAttachmentFileSize.ToString();
            objMailAttachmentsController.CreateObject(objMailAttachmentsInfo);
            SaveAttachmentToFile(fileName, objMailAttachmentsInfo.HRMailAttachmentID, objMailAttachmentsInfo.HRMailAttachmentName);
        }
        #endregion

        #region Save Mail Attachment to File
        /// <summary>
        /// Save Mail Attachment to File
        /// </summary>
        /// <param name="fileName">Path of file</param>
        /// <param name="mailAttachmentID">ID of mail attachment</param>
        /// <param name="mailAttachmentName">Name of mail attachment</param>

        public void SaveAttachmentToFile(string fileName, int mailAttachmentID, string mailAttachmentName)
        {
            string pathAttachment = Application.StartupPath.ToString();
            string filePath = mailAttachmentID.ToString() + mailAttachmentName.ToString();

            if (filePath.Contains(SpaceString))
                filePath = filePath.Replace(SpaceString, String.Empty);
            pathAttachment = string.Format("{0}\\MailBox\\Attachment\\{1}", pathAttachment, filePath);
            if (File.Exists(pathAttachment))
                File.Delete(pathAttachment);
            File.Copy(fileName, pathAttachment);


        }
        #endregion
        #endregion
    }
}
