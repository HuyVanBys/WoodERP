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
    public partial class guiChooseReceiptItems : BOSERPScreen
    {
        #region Variables
        private GridControlHelper GridControlHelper;

        public List<ICReceiptItemsInfo> SelectedObjects { get; set; }

        private BOSList<ICReceiptItemsInfo> ReceiptItemList { get; set; }

        private int Count = 0;

        #endregion

        public guiChooseReceiptItems(List<ICReceiptItemsInfo> receiptItemList)
        {
            InitializeComponent();
            ReceiptItemList = new BOSList<ICReceiptItemsInfo>(TableName.ICReceiptItemsTableName);
            ReceiptItemList.Invalidate(receiptItemList);
            ICReceiptItemsInfo objReceiptItemsInfo = receiptItemList.FirstOrDefault();
        }

        private void guiChooseReceiptItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcReceiptItemsGridControl.InvalidateDataSource(ReceiptItemList);
            SelectedObjects = new List<ICReceiptItemsInfo>();
            GridView gridView = (GridView)fld_dgcReceiptItemsGridControl.MainView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            GridControlHelper = new GridControlHelper(gridView);
            fld_dteSearchFromDate.EditValue = BOSApp.GetCurrentServerDate().AddDays(-7);
            fld_dteSearchToDate.EditValue = BOSApp.GetCurrentServerDate();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = GridControlHelper.Selection.OfType<ICReceiptItemsInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (SelectedObjects.Select(o => o.FK_ICReceiptID).Distinct().Count() > 1)
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

            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<ICReceiptItemsInfo> receiptItemList = objReceiptItemsController.GetReceiptItemForReturnSuplier(objObjectsInfo.ACObjectID, objObjectsInfo.ACObjectType, (DateTime?)fld_dteSearchFromDate.EditValue, (DateTime?)fld_dteSearchToDate.EditValue);
            ReceiptItemList.Invalidate(receiptItemList);
            fld_dgcReceiptItemsGridControl.InvalidateDataSource(ReceiptItemList);
        }
    }
}
