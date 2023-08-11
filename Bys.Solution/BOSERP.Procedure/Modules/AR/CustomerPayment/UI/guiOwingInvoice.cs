using BOSLib;
using Localization;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.CustomerPayment
{
    public partial class guiOwingInvoice : BOSERPScreen
    {

        public guiOwingInvoice()
        {
            InitializeComponent();

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

        private void guiOwingInvoice_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            CustomerPaymentEntities entity = (CustomerPaymentEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.OwingInvoicesList.InitBOSListGridControl(fld_dgcAROwingInvoicesGridControl);
            fld_dteSearchFromARInvoiceDate.DateTime = BOSUtil.GetYearBeginDate();
            fld_dteSearchToARInvoiceDate.DateTime = BOSUtil.GetYearEndDate();
            ((CustomerPaymentModule)Module).GetAllOwingInvoices(fld_txtARInvoiceNo.Text, Convert.ToDateTime(fld_dteSearchFromARInvoiceDate.EditValue), Convert.ToDateTime(fld_dteSearchToARInvoiceDate.EditValue), fld_chkSelectAllOwingInvoice);
        }

        private void fld_btnFilter1_Click(object sender, EventArgs e)
        {
            ((CustomerPaymentModule)Module).GetAllOwingInvoices(fld_txtARInvoiceNo.Text, Convert.ToDateTime(fld_dteSearchFromARInvoiceDate.EditValue), Convert.ToDateTime(fld_dteSearchToARInvoiceDate.EditValue), fld_chkSelectAllOwingInvoice);
        }

        private void fld_chkSelectAllOwingInvoice_EditValueChanged(object sender, EventArgs e)
        {
            ((CustomerPaymentModule)Module).SelectAllOwingInvoices(fld_chkSelectAllOwingInvoice);
        }

        private void fld_btnOk_Click(object sender, EventArgs e)
        {
            bool isValid = ((CustomerPaymentModule)Module).CheckForValidOwingInvoices();
            if (!isValid)
            {
                return;
            }

            CustomerPaymentEntities entity = (CustomerPaymentEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            if (!entity.OwingInvoicesList.Exists(i => i.Selected == true))
            {
                MessageBox.Show(CustomerPaymentLocalizedResources.ChooseOwingInvoiceMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}