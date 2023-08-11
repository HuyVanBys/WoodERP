using BOSLib;
using System;
using System.Windows.Forms;

namespace BOSERP.Modules.SupplierPayment
{
    public partial class guiOwingInvoiceIn : BOSERPScreen
    {

        public guiOwingInvoiceIn()
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

        private void guiOwingInvoiceIn_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            SupplierPaymentEntities entity = (SupplierPaymentEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.OwingInvoiceInList.InitBOSListGridControl(fld_dgcAPOwingInvoiceInsGridControl);
            fld_dteSearchFromAPInvoiceInDate.DateTime = BOSUtil.GetYearBeginDate();
            fld_dteSearchToAPInvoiceInDate.DateTime = BOSUtil.GetYearEndDate();

            ((SupplierPaymentModule)Module).GetAllOwingInvoiceIns(
                                                        fld_txtAPInvoiceInNo.Text,
                                                        Convert.ToDateTime(fld_dteSearchFromAPInvoiceInDate.EditValue),
                                                        Convert.ToDateTime(fld_dteSearchToAPInvoiceInDate.EditValue),
                                                        fld_chkSelectAllOwingInvoiceIn,
                                                        fld_txtAPInvoiceInSupplierReference.Text,
                                                        fld_txtAPInvoiceInPackNo.Text);
        }

        private void fld_btnFilter1_Click(object sender, EventArgs e)
        {
            ((SupplierPaymentModule)Module).GetAllOwingInvoiceIns(
                                                fld_txtAPInvoiceInNo.Text,
                                                Convert.ToDateTime(fld_dteSearchFromAPInvoiceInDate.EditValue),
                                                Convert.ToDateTime(fld_dteSearchToAPInvoiceInDate.EditValue),
                                                fld_chkSelectAllOwingInvoiceIn,
                                                fld_txtAPInvoiceInSupplierReference.Text,
                                                fld_txtAPInvoiceInPackNo.Text);
        }

        private void fld_btnOk_Click(object sender, EventArgs e)
        {
            bool isValid = ((SupplierPaymentModule)Module).CheckForValidOwingInvoices();
            if (!isValid)
            {
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_chkSelectAllOwingInvoiceIn_EditValueChanged(object sender, EventArgs e)
        {
            ((SupplierPaymentModule)Module).SelectAllOwingInvoices(fld_chkSelectAllOwingInvoiceIn);
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}