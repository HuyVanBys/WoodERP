using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.PurchaseProposal
{
    public partial class guiAllocationPlanItems : BOSERPScreen
    {
        #region Variables
        private GridControlHelper GridControlHelper;

        public List<MMAllocationPlanItemsInfo> SelectedObjects { get; set; }

        private List<MMAllocationPlanItemsInfo> AllocationPlanItemsList { get; set; }

        public string AllocationPlanItemGroup { get; set; }

        public int MMBatchProductID { get; set; }
        #endregion

        public guiAllocationPlanItems()
        {
            InitializeComponent();
            AllocationPlanItemsList = new BOSList<MMAllocationPlanItemsInfo>();
        }

        private void guiAllocationPlanItems_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_lkeFK_MMBatchProductID.EditValue = MMBatchProductID;
            EnableLookupEdit(fld_lkeFK_MMBatchProductID, MMBatchProductID > 0 ? false : true);
            MMBatchProductsController objBatchProductsController = new MMBatchProductsController();
            MMBatchProductsInfo objBatchProductsInfo = (MMBatchProductsInfo)objBatchProductsController.GetObjectByID(MMBatchProductID);
            DateTime fromDate = objBatchProductsInfo == null ? BOSApp.GetCurrentServerDate() : objBatchProductsInfo.MMBatchProductDate;
            bool isChanged = true;
            string value = ADConfigValueUtility.GetConfigTextByGroupAndValue("PurchaseProposalFromBatchProductDate", "true");
            isChanged = bool.Parse(value != string.Empty ? value : "false");
            if (isChanged)
            {
                fld_dteFromDate.EditValue = BOSApp.GetCurrentServerDate().AddMonths(-1);
                fld_dteToDate.EditValue = BOSApp.GetCurrentServerDate().AddMonths(1);
            }
            else
            {
                fld_dteFromDate.EditValue = fromDate;
                fld_dteToDate.EditValue = fromDate.Year == 9999 ? BOSApp.GetCurrentServerDate().AddMonths(1) : fromDate.AddMonths(1);
            }
            fld_dgcMMAllocationPlanItemsGridControl.InvalidateDataSource(AllocationPlanItemsList);
            SelectedObjects = new List<MMAllocationPlanItemsInfo>();
            GridView gridView = (GridView)fld_dgcMMAllocationPlanItemsGridControl.MainView;
            GridControlHelper = new GridControlHelper(gridView);
        }

        private void EnableLookupEdit(BOSLookupEdit lookupEdit, bool isEnable)
        {
            if (lookupEdit == null)
                return;

            lookupEdit.Enabled = isEnable;
            lookupEdit.ReadOnly = !isEnable;
            lookupEdit.BackColor = isEnable ? Color.White : Color.WhiteSmoke;
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            SelectedObjects = GridControlHelper.Selection.OfType<MMAllocationPlanItemsInfo>().ToList();
            if (SelectedObjects.Count == 0)
            {
                BOSApp.ShowMessage(BaseLocalizedResources.ChooseObjectMessage);
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
            GridControlHelper.Selection.Clear();
            int batchProductID = fld_lkeFK_MMBatchProductID.EditValue == null ? 0 : int.Parse(fld_lkeFK_MMBatchProductID.EditValue.ToString());
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            //if(Math.Abs((toDate - fromDate).TotalDays) > 90)
            //{
            //    MessageBox.Show(PurchaseProposalLocalizedResources.PleaseSearchDuringThirtyDay, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            MMAllocationPlanItemsController objAllocationPlanItemsController = new MMAllocationPlanItemsController();
            AllocationPlanItemsList = objAllocationPlanItemsController.GetItemForPurchaseProposal(AllocationPlanItemGroup
                                                                                                  , batchProductID
                                                                                                  , fromDate
                                                                                                  , toDate
                                                                                                  , BOSApp.CurrentUsersInfo.ADUserID
                                                                                                  , ModuleName.BatchProductShedule
                                                                                                  , ADDataViewPermissionType.Module
                                                                                                  , BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            PurchaseProposalEntities entity = (PurchaseProposalEntities)((BaseModuleERP)Module).CurrentModuleEntity;
            entity.PurchaseProposalItemList.ForEach(o =>
            {
                AllocationPlanItemsList.RemoveAll(item => item.Id == o.FK_MMAllocationProposalID);
            });
            fld_dgcMMAllocationPlanItemsGridControl.DataSource = AllocationPlanItemsList;
            fld_dgcMMAllocationPlanItemsGridControl.RefreshDataSource();
        }

        private void fld_hlcShowInventoryStock_Click(object sender, EventArgs e)
        {
            SelectedObjects = GridControlHelper.Selection.OfType<MMAllocationPlanItemsInfo>().ToList();
            string productRef = string.Join(",", SelectedObjects.Select(o => o.FK_ICProductID).Distinct().ToArray());
            ICTransactionsController objTransactionsController = new ICTransactionsController();
            List<ICTransactionsInfo> inventoryStocks = objTransactionsController.GetAvailableInventoryStockQty(productRef);
            ICTransactionsInfo objTransactionsInfo = new ICTransactionsInfo();
            decimal availableQty = 0;
            AllocationPlanItemsList.ForEach(o =>
            {
                o.IsCheckInventory = false;
                o.ICInventoryStockQty = 0;
            });
            SelectedObjects.ForEach(o =>
            {
                o.IsCheckInventory = true;
                objTransactionsInfo = inventoryStocks.Where(iv => iv.FK_ICProductID == o.FK_ICProductID).FirstOrDefault();
                if (objTransactionsInfo == null)
                    objTransactionsInfo = new ICTransactionsInfo();

                availableQty = objTransactionsInfo.ICInventoryStockQuantity - objTransactionsInfo.ICTransactionReceiptQty - objTransactionsInfo.ICInventoryStockAllocationPlanQuantity;
                if (availableQty < 0)
                    availableQty = 0;

                o.ICInventoryStockQty = availableQty / (o.ICProductMeasureUnitFactor == 0 ? 1 : o.ICProductMeasureUnitFactor);
                o.ICInventoryStockQty = Math.Round(o.ICInventoryStockQty, 6, MidpointRounding.AwayFromZero);

                o.MMAllocationPlanItemQty = o.MMAllocationPlanItemBPQty - o.APProposalItemProductQty;
                o.MMAllocationPlanItemQty = o.MMAllocationPlanItemQty - o.ICInventoryStockQty;
                if (o.MMAllocationPlanItemQty < 0)
                    o.MMAllocationPlanItemQty = 0;

                objTransactionsInfo.ICTransactionReceiptQty += o.MMAllocationPlanItemQty * (o.ICProductMeasureUnitFactor == 0 ? 1 : o.ICProductMeasureUnitFactor);
                objTransactionsInfo.ICTransactionReceiptQty = Math.Round(objTransactionsInfo.ICTransactionReceiptQty, 6, MidpointRounding.AwayFromZero);
            });
            fld_dgcMMAllocationPlanItemsGridControl.RefreshDataSource();
        }
    }
}
