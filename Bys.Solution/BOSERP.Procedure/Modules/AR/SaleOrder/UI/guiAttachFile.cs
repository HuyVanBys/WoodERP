using BOSERP.Utilities;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrder
{
    public partial class guiAttachFile : BOSERPScreen
    {
        public string DocumentFileName { get; set; }

        public List<ARSaleOrderPaymentTimeTemplatesInfo> PaymentTimeTemplates { get; set; }

        public guiAttachFile(List<ARSaleOrderPaymentTimeTemplatesInfo> paymentTimeTemplates)
        {
            InitializeComponent();
            PaymentTimeTemplates = paymentTimeTemplates;
        }

        private void guiAttachFile_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcSaleOrderPaymentTimeTemplatesGridControl.InvalidateDataSource(PaymentTimeTemplates);
        }

        public override void InitializeControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                InitializeControl(ctrl);
                InitializeFieldFormat(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    InitializeControls(ctrl.Controls);
                }
            }
        }

        private void fld_btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void fld_btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Chọn file";
            //dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.Filter = "Text files (*.txt;*.doc;*.docx;*.xls;*.xlsx;*.pdf)|*.txt;*.doc;*.docx;*.xls;*.xlsx;*.pdf";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fld_txtFilePath.Text = dialog.FileName;
                DocumentFileName = dialog.SafeFileName;
            }
        }

        private void fld_btnAddPaymentTimeTemplate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fld_txtFilePath.Text))
                return;

            if (PaymentTimeTemplates.Exists(o => o.ARSaleOrderPaymentTimeTemplateName.Equals(DocumentFileName)))
            {
                MessageBox.Show(SaleOrderLocalizedResources.DuplicateFileName,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            HREmployeesController objEmployeesController = new HREmployeesController();
            ARSaleOrderPaymentTimeTemplatesInfo objSaleOrderPaymentTimeTemplatesInfo = new ARSaleOrderPaymentTimeTemplatesInfo();
            objSaleOrderPaymentTimeTemplatesInfo.ARSaleOrderPaymentTimeTemplateName = DocumentFileName;
            objSaleOrderPaymentTimeTemplatesInfo.AACreatedUser = BOSApp.CurrentUser;
            objSaleOrderPaymentTimeTemplatesInfo.UserCreatedFullname = objEmployeesController.GetObjectNameByID(BOSApp.CurrentUsersInfo.FK_HREmployeeID);
            objSaleOrderPaymentTimeTemplatesInfo.FullPathFile = fld_txtFilePath.Text.Trim();
            PaymentTimeTemplates.Add(objSaleOrderPaymentTimeTemplatesInfo);
            fld_dgcSaleOrderPaymentTimeTemplatesGridControl.DataSource = PaymentTimeTemplates;
            fld_dgcSaleOrderPaymentTimeTemplatesGridControl.RefreshDataSource();
        }

        public void RemovePaymentTimeTemplatesList(int PaymentTimeTemplateID)
        {
            PaymentTimeTemplates.RemoveAll(o => o.ARSaleOrderPaymentTimeTemplateID == PaymentTimeTemplateID);
            fld_dgcSaleOrderPaymentTimeTemplatesGridControl.DataSource = PaymentTimeTemplates;
            fld_dgcSaleOrderPaymentTimeTemplatesGridControl.RefreshDataSource();
        }

        public void DownloadPaymentTimeTemplates(int paymentTimeTemplateID)
        {
            ARSaleOrderPaymentTimeTemplatesInfo objSaleOrderPaymentTimeTemplatesInfo = PaymentTimeTemplates.Where(o => o.ARSaleOrderPaymentTimeTemplateID == paymentTimeTemplateID).FirstOrDefault();
            if (objSaleOrderPaymentTimeTemplatesInfo == null)
                return;

            if (string.IsNullOrEmpty(objSaleOrderPaymentTimeTemplatesInfo.ARSaleOrderPaymentTimeTemplateFileGUID))
            {
                MessageBox.Show(SaleOrderLocalizedResources.FileNotFoundErrorMessage,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ApiClientHelper.DownloadFile(objSaleOrderPaymentTimeTemplatesInfo.ARSaleOrderPaymentTimeTemplateFileGUID, objSaleOrderPaymentTimeTemplatesInfo.ARSaleOrderPaymentTimeTemplateName);
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
