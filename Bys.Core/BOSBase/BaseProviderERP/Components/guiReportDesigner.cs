using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using Localization;
using System;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class guiReportDesigner : BOSERPScreen
    {
        /// <summary>
        /// Gets or sets the report is editted
        /// </summary>
        public XtraReport ReportEdit { get; private set; }
        /// <summary>
        /// Gets or sets file path of report
        /// </summary>
        public string ReportFileName { get; set; }
        public guiReportDesigner()
        {
            InitializeComponent();
        }

        public guiReportDesigner(XtraReport report, string fileName)
        {
            InitializeComponent();
            ReportEdit = report;
            ReportFileName = fileName;
        }

        public void commandBarItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xrDesignPanel1.AddCommandHandler(new SaveCommandHandler(xrDesignPanel1, ReportFileName));
        }

        private void guiReportDesigner_Load(object sender, EventArgs e)
        {
            xrDesignBarManager1.XRDesignPanel.OpenReport(ReportEdit);
        }
    }

    public class SaveCommandHandler : ICommandHandler
    {
        /// <summary>
        /// Panel which contain report in it
        /// </summary>
        private XRDesignPanel ReportPanel;
        /// <summary>
        /// The file path of report
        /// </summary>
        private string RepportFileName = string.Empty;

        private bool defaultHandler = false;

        public SaveCommandHandler(XRDesignPanel panel, string fileName)
        {
            ReportPanel = panel;
            RepportFileName = fileName;
        }

        private void SaveReport()
        {
            if (ReportPanel.ReportState != ReportState.Changed)
                return;
            if (string.IsNullOrEmpty(RepportFileName))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(string.Format("Không thể lưu! Chưa cấu hình tệp mẫu!"));
                return;
            }
            ReportPanel.Report.SaveLayout(RepportFileName);
            // Prevent the "Report has been changed" dialog from being shown.
            ReportPanel.ReportState = ReportState.Saved;
            DevExpress.XtraEditors.XtraMessageBox.Show(BaseLocalizedResources.SaveSuccessfullyMessage, BaseLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenProperties(object[] args)
        {
            ISelectionService selectionServ = ReportPanel.GetService(typeof(ISelectionService)) as ISelectionService;
            if (selectionServ != null && selectionServ.PrimarySelection is XRSubreport)
            {
                //if(args.Length > 0 && args[0] is XRSubreport) {
                XRSubreport loSubReport = selectionServ.PrimarySelection as XRSubreport;
                if (loSubReport != null)
                {
                    XtraMessageBox.Show("Properties");
                }
            }
            else
            {
                defaultHandler = true;
                ReportPanel.ExecCommand(ReportCommand.PropertiesWindow, args); //error die loop
                defaultHandler = false;
            }
        }

        public virtual void HandleCommand(ReportCommand command, object[] args)
        {
            bool handler = false;
            if (!CanHandleCommand(command, ref handler)) return;
            SaveReport();
        }

        public virtual bool CanHandleCommand(ReportCommand command, ref bool useNextHandler)
        {
            useNextHandler = !(command == ReportCommand.SaveFile || command == ReportCommand.SaveFileAs || command == ReportCommand.Closing);
            return command == ReportCommand.SaveFile || command == ReportCommand.SaveFileAs || command == ReportCommand.Closing;
        }
    }
}
