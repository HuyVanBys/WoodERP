using BOSCommon;
using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP107 : ReportForm
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
      //  private List<ACAssetsInfo> AssetList;
        ///// <summary>
        ///// A variable to store the room list for selecting
        ///// </summary>
        //private List<HRDepartmentRoomsInfo> RoomList;
        public RP107()
        {
            InitializeComponent();
        }

        private void RP107_Load(object sender, EventArgs e)
        {

            InitializeControls(Controls);
            fld_dteSearchFromDate.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            fld_dteSearchToDate.DateTime = BOSUtil.GetMonthEndDate();
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

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void fld_btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.InitialDirectory = @"C:\";

                saveFileDialog1.Title = "Save Files";

                saveFileDialog1.DefaultExt = "xlsx";

                saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|(*.xlsx)|*.xlsx|All files (*.*)|*.*";

                saveFileDialog1.FilterIndex = 2;

                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    string fileName = saveFileDialog1.FileName;
                    //fld_dgcWoodPlantItemDetail.ExportToXlsx(fileName);
                    //fld_dgcRP100HardwareItems.ExportToXlsx(fileName);
                    //fld_lkeRP100PaintItems.ExportToXlsx(fileName);
                    //fld_lkeRP100PackagingsItem.ExportToXlsx(fileName);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The process cannot access the file") && ex.Message.Contains("because it is being used by another process."))
                    MessageBox.Show(ReportLocalizedResources.CannotExportToExcelFileBecauseTheFileIsBeingUsedByAnotherProcessMessage,
                                    CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(ReportLocalizedResources.ExportExelFileUnsuccessfullyMessage,
                                    CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            GetDataSearch();
        }
        public void GetDataSearch()
        {
            int allocationProposalID = 0;
            int.TryParse(fld_lkeMMAllocationProposalID1.EditValue.ToString(), out allocationProposalID);
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            string allocationProposalName = fld_txtMMAllocationProposalName.Text;
            int batchProductID = 0;
            int.TryParse(fld_lkeMMBatchProductNo.EditValue.ToString(), out batchProductID);
            ADReportsController objReportsController = new ADReportsController();
            List<MMAllocationProposalsInfo> allocationProposalList = objReportsController.GetAllMMAllocationProposals(allocationProposalID, searchFromDate, searchToDate, allocationProposalName, batchProductID);
            fld_dgcRP107MMAllocationProposals.DataSource = allocationProposalList;

        }
        internal void Getalldata(int allocationProposalID, string MMAllocationProposalProductType)
        {
            ADReportsController objReportsController = new ADReportsController();
            if (MMAllocationProposalProductType == AllocationProposalProductType.RoundWood.ToString())
            {
                //MMAllocationProposalItem
                List<MMAllocationProposalItemsInfo> allocationProposalItemList = objReportsController.GetAllMMAllocationProposalItemOtherByAllocationProposalID(allocationProposalID);
                fld_dgcRP107MMAllocationProposalItems.LoadGridViewByProductType(MMAllocationProposalProductType);
                fld_dgcRP107MMAllocationProposalItems.DataSource = allocationProposalItemList;
                //ProposalItem
                List<APProposalItemsInfo> proposalItemList = objReportsController.GetAllAPProposalItemOtherByAllocationProposalID(allocationProposalID);
                fld_dgcRP107APProposalItems.LoadGridViewByProductType(MMAllocationProposalProductType);
                fld_dgcRP107APProposalItems.DataSource = proposalItemList;
                // PurchaseOrderItem
                List<APPurchaseOrderItemsInfo> purchaseOrderItemList = objReportsController.GetAllPurchaseOrderItemOtherByAllocationProposalID(allocationProposalID);
                fld_dgcRP107APPurchaseOrderItems.LoadGridViewByProductType(MMAllocationProposalProductType);
                fld_dgcRP107APPurchaseOrderItems.DataSource = purchaseOrderItemList;
                //ICReceiptItem
                List<ICReceiptItemsInfo> receiptItemWoodsList = objReportsController.GetAllReceiptItemOtherByAllocationProposalID(allocationProposalID);
                fld_dgcRP107ICReceiptItem.LoadGridViewByProductType(MMAllocationProposalProductType);
                fld_dgcRP107ICReceiptItem.DataSource = receiptItemWoodsList;
            }
            else if (MMAllocationProposalProductType == AllocationProposalProductType.DryLumber.ToString() || MMAllocationProposalProductType == AllocationProposalProductType.FreshLumber.ToString())
            {
                //MMAllocationProposalItem
                List<MMAllocationProposalItemsInfo> allocationProposalItemList = objReportsController.GetAllMMAllocationProposalItemOtherByAllocationProposalID(allocationProposalID);
                fld_dgcRP107MMAllocationProposalItems.LoadGridViewByProductType(MMAllocationProposalProductType);
                fld_dgcRP107MMAllocationProposalItems.DataSource = allocationProposalItemList;
                //ProposalItem
                List<APProposalItemsInfo> proposalItemList = objReportsController.GetAllAPProposalItemOtherByAllocationProposalID(allocationProposalID);
                fld_dgcRP107APProposalItems.LoadGridViewByProductType(MMAllocationProposalProductType);
                fld_dgcRP107APProposalItems.DataSource = proposalItemList;
                // PurchaseOrderItem
                List<APPurchaseOrderItemsInfo> purchaseOrderItemList = objReportsController.GetAllPurchaseOrderItemOtherByAllocationProposalID(allocationProposalID);
                fld_dgcRP107APPurchaseOrderItems.LoadGridViewByProductType(MMAllocationProposalProductType);
                fld_dgcRP107APPurchaseOrderItems.DataSource = purchaseOrderItemList;
                //ICReceiptItem
                List<ICReceiptItemsInfo> receiptItemWoodsList = objReportsController.GetAllReceiptItemOtherByAllocationProposalID(allocationProposalID);
                fld_dgcRP107ICReceiptItem.LoadGridViewByProductType(MMAllocationProposalProductType);
                fld_dgcRP107ICReceiptItem.DataSource = receiptItemWoodsList;
            }
            else
            {
                //MMAllocationProposalItem
                List<MMAllocationProposalItemsInfo> allocationProposalItemList = objReportsController.GetAllMMAllocationProposalItemOtherByAllocationProposalID(allocationProposalID);
                fld_dgcRP107MMAllocationProposalItems.LoadGridViewByProductType(MMAllocationProposalProductType);
                fld_dgcRP107MMAllocationProposalItems.DataSource = allocationProposalItemList;
                //ProposalItem
                List<APProposalItemsInfo> proposalItemList = objReportsController.GetAllAPProposalItemOtherByAllocationProposalID(allocationProposalID);
                fld_dgcRP107APProposalItems.LoadGridViewByProductType(MMAllocationProposalProductType);
                fld_dgcRP107APProposalItems.DataSource = proposalItemList;
                // PurchaseOrderItem
                List<APPurchaseOrderItemsInfo> purchaseOrderItemList = objReportsController.GetAllPurchaseOrderItemOtherByAllocationProposalID(allocationProposalID);
                fld_dgcRP107APPurchaseOrderItems.LoadGridViewByProductType(MMAllocationProposalProductType);
                fld_dgcRP107APPurchaseOrderItems.DataSource = purchaseOrderItemList;
                //ICReceiptItem
                List<ICReceiptItemsInfo> receiptItemWoodsList = objReportsController.GetAllReceiptItemOtherByAllocationProposalID(allocationProposalID);
                fld_dgcRP107ICReceiptItem.LoadGridViewByProductType(MMAllocationProposalProductType);
                fld_dgcRP107ICReceiptItem.DataSource = receiptItemWoodsList;
            }

        }
    }
}
