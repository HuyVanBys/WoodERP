using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Localization;
using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace BOSLib
{
    public class ReportLoader
    {
        protected ReportDocument _reportDoc;
        protected int _deliveryMethod;
        protected String _printerName;
        protected int _numberOfCopies = 0;
        protected int _startPage = 1;
        protected int _endPage = 1;
        protected String _emailAddress;
        protected String _emailSubject;
        protected String _emailBody;
        protected String _faxNo;

        public ReportLoader()
        {
            SetDBLogon();
        }

        public ReportLoader(ReportDocument _rptDoc)
        {
            ReportDoc = _rptDoc;
            SetDBLogon();
        }

        public ReportLoader(String strReportName, String strModuleName)
        {

            String strReportPath = Application.StartupPath + ConfigurationManager.AppSettings["ReportPath"];
            ReportDoc = new ReportDocument();
            ReportDoc.FileName = strReportPath + "\\" + strModuleName + "\\" + strReportName + ".rpt";
            InitReportMembers(strReportName);
            SetDBLogon();
        }

        /// <summary>
        /// Process report by passed parameter Values and Display report base on Delivery Method
        /// </summary>
        /// <param name="paramValues">List of parameter values will be passed in to report parameters</param>
        public void DisplayReport(Hashtable paramValues)
        {
            SetParamValues(paramValues);
            switch (DeliveryMethod)
            {
                //Print preview
                case 0:
                    {
                        guiBOSReportViewer _guiBOSReportViewer = new guiBOSReportViewer();
                        _guiBOSReportViewer.BOSReportViewer.ReportSource = this.ReportDoc;
                        _guiBOSReportViewer.Show();
                        break;
                    }
                //Send to specified printer
                case 1:
                    {
                        ReportDoc.PrintOptions.PrinterName = PrinterName;
                        ReportDoc.PrintToPrinter(NumOfCopies, false, StartPage, EndPage);
                        MessageBox.Show(string.Format(CommonLocalizedResources.PrintReportSuccessfullyMessage, PrinterName), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                //Send email to specified Email
                case 2:
                    {
                        ExportReport();
                        String strAttachFile = GetReportExportPath() + "\\" + GetReportFileName(ReportDoc) + ".doc";
                        CreateEmail(strAttachFile);
                        break;
                    }
                //Fax to specified Fax No
                case 3:
                    {
                        break;
                    }
            }
        }


        public void DisplayReportFromDataSet(Hashtable paramValues, DataSet ds, bool showGroupViewer)
        {
            ReportDoc.SetDataSource(ds);

            //At first Don't need SetParamValues(paramValues); 

            switch (DeliveryMethod)
            {
                //Print preview
                case 0:
                    {
                        guiBOSReportViewer _guiBOSReportViewer = new guiBOSReportViewer();
                        _guiBOSReportViewer.BOSReportViewer.ReportSource = this.ReportDoc;
                        _guiBOSReportViewer.BOSReportViewer.DisplayGroupTree = showGroupViewer;
                        _guiBOSReportViewer.Show();
                        break;
                    }
                //Send to specified printer
                case 1:
                    {
                        ReportDoc.PrintOptions.PrinterName = PrinterName;
                        ReportDoc.PrintToPrinter(NumOfCopies, false, StartPage, EndPage);
                        MessageBox.Show(string.Format(CommonLocalizedResources.PrintReportSuccessfullyMessage, PrinterName), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                //Send email to specified Email
                case 2:
                    {
                        ExportReport();
                        String strAttachFile = GetReportExportPath() + "\\" + GetReportFileName(ReportDoc) + ".doc";
                        CreateEmail(strAttachFile);
                        break;
                    }
                //Fax to specified Fax No
                case 3:
                    {
                        break;
                    }
            }
        }


        public void DisplayReportFromDataTable(DataTable tbl)
        {
            ReportDoc.SetDataSource(tbl);
            switch (DeliveryMethod)
            {
                //Print preview
                case 0:
                    {
                        guiBOSReportViewer _guiBOSReportViewer = new guiBOSReportViewer();
                        _guiBOSReportViewer.BOSReportViewer.ReportSource = this.ReportDoc;

                        _guiBOSReportViewer.Show();
                        break;
                    }
                //Send to specified printer
                case 1:
                    {
                        ReportDoc.PrintOptions.PrinterName = PrinterName;
                        ReportDoc.PrintToPrinter(NumOfCopies, false, StartPage, EndPage);
                        MessageBox.Show(string.Format(CommonLocalizedResources.PrintReportSuccessfullyMessage, PrinterName), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                //Send email to specified Email
                case 2:
                    {
                        ExportReport();
                        String strAttachFile = GetReportExportPath() + "\\" + GetReportFileName(ReportDoc) + ".doc";
                        CreateEmail(strAttachFile);
                        break;
                    }
                //Fax to specified Fax No
                case 3:
                    {
                        break;
                    }
            }
        }

        public void DisplayReportFromDataTableWithParameters(Hashtable paramValues, DataTable tbl, Boolean bShowTreeViewer)
        {
            ReportDoc.SetDataSource(tbl);
            SetParamValues(paramValues);

            switch (DeliveryMethod)
            {
                //Print preview
                case 0:
                    {
                        guiBOSReportViewer _guiBOSReportViewer = new guiBOSReportViewer();
                        _guiBOSReportViewer.BOSReportViewer.ReportSource = this.ReportDoc;
                        _guiBOSReportViewer.BOSReportViewer.DisplayGroupTree = bShowTreeViewer;
                        _guiBOSReportViewer.Show();
                        break;
                    }
                //Send to specified printer
                case 1:
                    {
                        ReportDoc.PrintOptions.PrinterName = PrinterName;
                        ReportDoc.PrintToPrinter(NumOfCopies, false, StartPage, EndPage);
                        MessageBox.Show(string.Format(CommonLocalizedResources.PrintReportSuccessfullyMessage, PrinterName), CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                //Send email to specified Email
                case 2:
                    {
                        ExportReport();
                        String strAttachFile = GetReportExportPath() + "\\" + GetReportFileName(ReportDoc) + ".doc";
                        CreateEmail(strAttachFile);
                        break;
                    }
                //Fax to specified Fax No
                case 3:
                    {
                        break;
                    }
            }
        }

        /// <summary>
        /// Set database lon on for report
        /// </summary>
        private void SetDBLogon()
        {
            try
            {
                ConnectionInfo objReportConnection = GetDbReportConnection();
                foreach (Table reportTable in ReportDoc.Database.Tables)
                {
                    TableLogOnInfo _tableLogonInfo = reportTable.LogOnInfo;
                    _tableLogonInfo.ConnectionInfo = objReportConnection;
                    reportTable.ApplyLogOnInfo(_tableLogonInfo);
                }

            }
            catch (Exception)
            {
                MessageBox.Show(CommonLocalizedResources.CannotLogOnDatabaseMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private ConnectionInfo GetDbReportConnection()
        {
            ConnectionInfo objReportConnection = new ConnectionInfo();
            objReportConnection.ServerName = ConfigurationManager.AppSettings["ServerName"];
            if (objReportConnection.ServerName.Contains("local") == true)
            {
                MessageBox.Show("Cannot connect to Local");
            }

            objReportConnection.DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
            //[DDCan] [MOD] [21/05/2013] [Encrypt user id and password of database], START
            //objReportConnection.UserID = ConfigurationManager.AppSettings["UserID"];
            //objReportConnection.Password = ConfigurationManager.AppSettings["Password"];
            Crypto cryp = new Crypto();
            objReportConnection.UserID = cryp.DecryptNew(ConfigurationManager.AppSettings["UserID"], true);
            objReportConnection.Password = cryp.DecryptNew(ConfigurationManager.AppSettings["Password"], true);
            //[DDCan] [MOD] [21/05/2013] [Encrypt user id and password of database], END
            return objReportConnection;
        }

        /// <summary>
        /// Set Param Values for report parameters
        /// </summary>
        /// <param name="paramValues"></param>
        private void SetParamValues(Hashtable paramValues)
        {
            foreach (ParameterField paramField in ReportDoc.ParameterFields)
            {
                Object objValue = paramValues[paramField.Name];
                if (objValue != null)
                    ReportDoc.SetParameterValue(paramField.Name, paramValues[paramField.Name]);
            }
        }

        #region "Utility Functions"

        private void CreateEmail(String strAttachFileName)
        {
            try
            {
                Outlook.ApplicationClass objOutlookApp = new Outlook.ApplicationClass();
                Outlook.MailItem mailmsg = (Outlook.MailItem)objOutlookApp.CreateItem(Outlook.OlItemType.olMailItem);
                mailmsg.To = EmailAddress;
                mailmsg.Subject = EmailSubject;
                mailmsg.Body = EmailBody;
                object objFileName = strAttachFileName;
                mailmsg.Attachments.Add(objFileName, Outlook.OlAttachmentType.olByValue, 1, objFileName);
                mailmsg.Display(false);
            }
            catch (Exception e)
            {
                MessageBox.Show("Create Email:" + e.Message);
            }
        }

        private void ExportReport()
        {
            ReportDoc.ExportToDisk(ExportFormatType.WordForWindows, GetReportExportPath() + "\\" + GetReportFileName(ReportDoc) + ".doc");
        }

        private String GetReportPath()
        {
            return Application.StartupPath + ConfigurationManager.AppSettings["ReportPath"];
        }

        private String GetReportExportPath()
        {
            return Application.StartupPath + ConfigurationManager.AppSettings["ReportPath"] + "\\Exports";
        }

        private String GetReportFileName(ReportDocument rptDoc)
        {
            String strFileName = rptDoc.FileName;
            int index = strFileName.LastIndexOf("\\");
            return strFileName.Substring(index + 1, strFileName.Length - index - 5);
        }

        private void InitReportMembers(String strReportName)
        {
            PRReportsController objReportController = new PRReportsController();
            if (objReportController.IsExist(strReportName))
            {
                PRReportsInfo objPRReportsInfo = (PRReportsInfo)objReportController.GetObjectByName(strReportName);
                DeliveryMethod = objPRReportsInfo.PRReportDeliveryMethod;
                if (objPRReportsInfo.PRReportDeliveryMethod == 1)
                {
                    PrinterName = objPRReportsInfo.PRReportPrinter;
                    NumOfCopies = objPRReportsInfo.PRReportNumOfCopies;
                }
                else if (objPRReportsInfo.PRReportDeliveryMethod == 2)
                {
                    //for testing                    
                    EmailSubject = objPRReportsInfo.PRReportEmailSubject;
                    EmailBody = objPRReportsInfo.PRReportEmailBody;
                }
            }
            else
            {
                DeliveryMethod = 0;
            }
        }

        #endregion

        #region "public properties"
        public ReportDocument ReportDoc
        {
            get { return _reportDoc; }
            set { _reportDoc = value; }
        }

        public int DeliveryMethod
        {
            get { return _deliveryMethod; }
            set { _deliveryMethod = value; }
        }

        public String PrinterName
        {
            get { return _printerName; }
            set { _printerName = value; }
        }

        public int NumOfCopies
        {
            get { return _numberOfCopies; }
            set { _numberOfCopies = value; }
        }

        public int StartPage
        {
            get { return _startPage; }
            set { _startPage = value; }
        }

        public int EndPage
        {
            get { return _endPage; }
            set { _endPage = value; }
        }

        public String EmailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }

        public String EmailSubject
        {
            get { return _emailSubject; }
            set { _emailSubject = value; }
        }

        public String EmailBody
        {
            get { return _emailBody; }
            set { _emailBody = value; }
        }

        public String FaxNumber
        {
            get { return _faxNo; }
            set { _faxNo = value; }
        }
        #endregion

    }
}
