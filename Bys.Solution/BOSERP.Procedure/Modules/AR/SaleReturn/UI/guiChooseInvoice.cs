using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;

namespace BOSERP.Modules.SaleReturn
{
    public partial class guiChooseInvoice : BOSERPScreen
    {
        /// <summary>
        /// Gets or sets the selected invoice
        /// </summary>
        public ARInvoicesInfo SelectedInvoice { get; set; }

        public guiChooseInvoice()
        {
            InitializeComponent();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void fld_btnChoose_Click(object sender, EventArgs e)
        {
            ChooseInvoice();
        }

        /// <summary>
        /// Called when the user chooses an invoice from the grid
        /// </summary>
        public void ChooseInvoice()
        {
            GridView gridView = (GridView)fld_dgcRefundableInvoices.MainView;
            SelectedInvoice = (ARInvoicesInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if (SelectedInvoice != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(SaleReturnLocalizedResources.ChooseInvoiceMessage,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }

        private void guiChooseInvoice_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dteFromDate.DateTime = BOSUtil.GetYearBeginDate();
            fld_dteToDate.DateTime = BOSUtil.GetYearEndDate();

            SaleReturnEntities entity = (SaleReturnEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.RefundableInvoices.InitBOSListGridControl(fld_dgcRefundableInvoices);            
        }

        private void GridView_DoubleClick(GridView sender, EventArgs e)
        {
            ChooseInvoice();
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

        private void fld_btnView_Click(object sender, EventArgs e)
        {
            string invoiceNo = fld_txtARInvoiceNo.Text;
            int customerID = Convert.ToInt32(fld_lkeARCustomerID.EditValue);
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            ((SaleReturnModule)Module).ShowRefundableInvoices(invoiceNo, customerID, fromDate, toDate);            
        }
    }
}
