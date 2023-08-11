using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleReturn
{
    public partial class guiChooseInvoiceItem : BOSERPScreen
    {
        /// <summary>
        /// Gets or sets the selected invoice
        /// </summary>
        public ARInvoiceItemsInfo SelectedInvoiceItem { get; set; }

        public List<ARInvoiceItemsInfo> SelectedObject { get; set; }

        public GridControlHelper gridControlHelper;
        public guiChooseInvoiceItem()
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
            SelectedObject = gridControlHelper.Selection.OfType<ARInvoiceItemsInfo>().ToList();
            if (SelectedObject.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void guiChooseInvoiceItem_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dteFromDate.DateTime = BOSUtil.GetYearBeginDate();
            fld_dteToDate.DateTime = BOSUtil.GetYearEndDate();

            SaleReturnEntities entity = (SaleReturnEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.RefundableInvoiceItems.InitBOSListGridControl(fld_dgcRefundableInvoiceItems);
            GridView gridView = (GridView)fld_dgcRefundableInvoiceItems.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.ExpandAllGroups();
            gridControlHelper = new GridControlHelper(gridView);
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
            string VATInvoiceNo = fld_txtARInvoiceVATInvoiceNo.Text;
            int customerID = Convert.ToInt32(fld_lkeARCustomerID.EditValue);
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            ((SaleReturnModule)Module).ShowRefundableInvoiceItems(invoiceNo, VATInvoiceNo, customerID, fromDate, toDate);
            GridView gridView = (GridView)fld_dgcRefundableInvoiceItems.MainView;
            
            if (gridView.Columns["ARInvoiceDate"] != null)
            {
                gridView.Columns["ARInvoiceDate"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            }
            gridView.ExpandAllGroups();
        }
    }
}
