using BOSCommon;
using BOSCommon.Constants;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.ProductConversion
{
    public partial class guiChooseRecieptItems : BOSERPScreen
    {
        #region Variables
        public List<ICReceiptItemsInfo> SelectedObjects { get; set; }
        #endregion

        public guiChooseRecieptItems()
        {
            InitializeComponent();
            SelectedObjects = new List<ICReceiptItemsInfo>();
        }

        private void guiChooseRecieptItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            DateTime currentDate = ((ProductConversionModule)Module).GetServerDate();
            fld_dteFromDate.EditValue = BOSUtil.GetMonthBeginDate(currentDate);
            fld_dteToDate.EditValue = BOSUtil.GetMonthEndDate(currentDate);

            ICReceiptsController objReceiptsController = new ICReceiptsController();
            List<ICReceiptsInfo> datasourceList = objReceiptsController.GetReceiptCompleteDataSource(ReceiptType.PurchaseReceipt.ToString());
            datasourceList.Insert(0, new ICReceiptsInfo());
            fld_lkeICReceiptID.Properties.DataSource = datasourceList;
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            SelectedObjects.Clear();
            GridView gridView = (GridView)fld_dgcICReceiptItemsGridControl.MainView;
            int[] rowSelected = gridView.GetSelectedRows();
            ICReceiptItemsInfo item = new ICReceiptItemsInfo();
            foreach (int i in rowSelected)
            {
                if (i < 0)
                    continue;

                item = (ICReceiptItemsInfo)gridView.GetRow(i);
                if (item == null)
                    continue;

                SelectedObjects.Add(item);
            }
            if (!SelectedObjects.Any())
            {
                MessageBox.Show(BaseLocalizedResources.ChooseObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fld_btnFind_Click(object sender, EventArgs e)
        {
            ProductConversionEntities entity = ((ProductConversionModule)Module).CurrentModuleEntity as ProductConversionEntities;
            int receiptID = fld_lkeICReceiptID.EditValue == null ? 0 : (int)fld_lkeICReceiptID.EditValue;
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            ICReceiptItemsController objReceiptItemsController = new ICReceiptItemsController();
            List<ICReceiptItemsInfo> receiptItemList = objReceiptItemsController.GetShipmentFromProductConversion(receiptID, fromDate, toDate, BOSApp.CurrentUsersInfo.ADUserID
                                                                                                                        , this.Module.Name
                                                                                                                        , ADDataViewPermissionType.Module
                                                                                                                        , BOSApp.CurrentCompanyInfo.FK_BRBranchID);

            List<int> curentReceiptItemList = entity.CurrentConversionItemList.Select(o => o.FK_ICReceiptItemID).ToList();
            receiptItemList.RemoveAll(o => curentReceiptItemList.Contains(o.Id));
            fld_dgcICReceiptItemsGridControl.DataSource = receiptItemList;
            fld_dgcICReceiptItemsGridControl.RefreshDataSource();
        }
    }
}