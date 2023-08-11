using BOSLib;
using Localization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP103 : ReportForm
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
        //  private List<ACAssetsInfo> AssetList;
        ///// <summary>
        ///// A variable to store the room list for selecting
        ///// </summary>
        //private List<HRDepartmentRoomsInfo> RoomList;
        public RP103()
        {
            InitializeComponent();
        }

        private void RP103_Load(object sender, EventArgs e)
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
            int supplierID = 0;
            int.TryParse(fld_lkeARCustomerID1.EditValue.ToString(), out supplierID);
            DateTime searchFromDate = fld_dteSearchFromDate.DateTime;
            DateTime searchToDate = fld_dteSearchToDate.DateTime;
            int saleOrderID = Convert.ToInt32(fld_lkeFK_ARSaleOrderID.EditValue);
            string batchProductNo = fld_lkeMMBatchProductNo.Text;
            ADReportsController objReportsController = new ADReportsController();
            List<MMBatchProductsInfo> batchproductList = objReportsController.GetAllMMBatchproduct(supplierID, searchFromDate, searchToDate, saleOrderID, batchProductNo);
            fld_dgcRP103MMBatchProducts.DataSource = batchproductList;
            if (batchproductList.Count > 0)
            {
                GetallTabdata(batchproductList[0].MMBatchProductID);
            }
            //List<MMWoodPlansInfo> WoodPlansList = new List<MMWoodPlansInfo>();
            //List<MMAllocationPlansInfo> AllocationPlansList = new List<MMAllocationPlansInfo>();
            //List<MMAllocationProposalsInfo> AllocationProposalsList = new List<MMAllocationProposalsInfo>();
            //List<ICShipmentsInfo> ShipmentsList = new List<ICShipmentsInfo>();
            //foreach (MMBatchProductsInfo item in batchproductList)
            //{
            //    List<MMWoodPlansInfo> woodPlansList = objReportsController.GetAllMMWoodPlans(item.MMBatchProductID);
            //    WoodPlansList.AddRange(woodPlansList);
            //    List<MMAllocationPlansInfo> AllocationPlansInfoList = objReportsController.GetAllAllocationPlans(item.MMBatchProductID);
            //    AllocationPlansList.AddRange(AllocationPlansInfoList);
            //    List<MMAllocationProposalsInfo> AllocationProposalsInfoList=objReportsController.GetAllAllocationProposals(item.MMBatchProductID);
            //    AllocationProposalsList.AddRange(AllocationProposalsInfoList);
            //    List<ICShipmentsInfo> ShipmentsInfoList = objReportsController.GetAllShipments(item.MMBatchProductID);
            //    ShipmentsList.AddRange(ShipmentsInfoList);
            //}
            //fld_dgcRP103MMWoodPlans.DataSource = WoodPlansList;
            //fld_dgcRP103MMAllocationPlans.DataSource = AllocationPlansList;
            //fld_lkeRP103MMAllocationProposals.DataSource = AllocationProposalsList;
            //fld_lkeRP103ICReceipts.DataSource = ShipmentsList;

        }
        internal void GetallTabdata(int batchproductid)
        {
            ADReportsController objReportsController = new ADReportsController();
            List<MMWoodPlansInfo> woodPlansList = objReportsController.GetAllMMWoodPlans(batchproductid);
            //WoodPlansList.AddRange(woodPlansList);
            List<MMAllocationPlansInfo> AllocationPlansInfoList = objReportsController.GetAllAllocationPlans(batchproductid);
            //AllocationPlansList.AddRange(AllocationPlansInfoList);
            List<MMAllocationProposalsInfo> AllocationProposalsInfoList = objReportsController.GetAllAllocationProposals(batchproductid);
            //AllocationProposalsList.AddRange(AllocationProposalsInfoList);
            List<ICShipmentsInfo> ShipmentsInfoList = objReportsController.GetAllShipments(batchproductid);
            //ShipmentsList.AddRange(ShipmentsInfoList);
            fld_dgcRP103MMWoodPlans.DataSource = woodPlansList;
            fld_dgcRP103MMAllocationPlans.DataSource = AllocationPlansInfoList;
            fld_lkeRP103MMAllocationProposals.DataSource = AllocationProposalsInfoList;
            fld_lkeRP103ICReceipts.DataSource = ShipmentsInfoList;
        }
    }
}
