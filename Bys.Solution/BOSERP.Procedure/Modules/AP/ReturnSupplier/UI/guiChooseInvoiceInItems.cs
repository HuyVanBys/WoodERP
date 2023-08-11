using BOSCommon.Constants;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ReturnSupplier
{
    public partial class guiChooseInvoiceInItems : BOSERPScreen
    {
        #region Variables
        private GridControlHelper GridControlHelper;

        public List<APInvoiceInItemsInfo> SelectedObjects { get; set; }

        private BOSList<APInvoiceInItemsInfo> InvoiceInItemList { get; set; }

        private int Count = 0;

        #endregion

        public guiChooseInvoiceInItems(List<APInvoiceInItemsInfo> invoiceInItemList)
        {
            InitializeComponent();
            InvoiceInItemList = new BOSList<APInvoiceInItemsInfo>(TableName.APInvoiceInItemsTableName);
            InvoiceInItemList.Invalidate(invoiceInItemList);
        }

        private void guiChooseInvoiceInItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcAPInvoiceInItemsGridControl.InvalidateDataSource(InvoiceInItemList);
            SelectedObjects = new List<APInvoiceInItemsInfo>();
            GridView gridView = (GridView)fld_dgcAPInvoiceInItemsGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            GridControlHelper = new GridControlHelper(gridView);
            fld_dteSearchFromDate.EditValue = BOSApp.GetCurrentServerDate().AddDays(-7);
            fld_dteSearchToDate.EditValue = BOSApp.GetCurrentServerDate();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = GridControlHelper.Selection.OfType<APInvoiceInItemsInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (SelectedObjects.Select(o => o.FK_APInvoiceInID).Distinct().Count() > 1)
            {
                MessageBox.Show(ReturnSupplierLocalizedResources.NotSamePurchaseReceipt, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            string acobjectAssetKey = fld_lkeFK_ACObjectID.EditValue == null ? string.Empty : fld_lkeFK_ACObjectID.EditValue.ToString();
            ACObjectsController objObjectsController = new ACObjectsController();
            ACObjectsInfo objObjectsInfo = objObjectsController.GetObjectByAccessKey(acobjectAssetKey);

            APInvoiceInItemsController objInvoiceInItemsController = new APInvoiceInItemsController();
            List<APInvoiceInItemsInfo> invoiceInItemList = objInvoiceInItemsController.GetInvoiceInItemForReturnSuplier(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType, (DateTime?)fld_dteSearchFromDate.EditValue, (DateTime?)fld_dteSearchToDate.EditValue);
            InvoiceInItemList.Invalidate(invoiceInItemList);
            fld_dgcAPInvoiceInItemsGridControl.InvalidateDataSource(InvoiceInItemList);
        }
    }
}
