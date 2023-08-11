using BOSLib;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP063 : ReportForm
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
        private List<ACAssetsInfo> AssetList;

        public RP063()
        {
            InitializeComponent();
        }

        private void RP063_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteToDate.DateTime = BOSUtil.GetMonthEndDate();

            ACAssetsController objAssetsController = new ACAssetsController();
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            List<HRDepartmentRoomsInfo> roomList = objDepartmentRoomsController.GetAllRooms();
            roomList = roomList.Where(room => BranchList.Any(branch => branch.BRBranchID == room.FK_BRBranchID)).ToList();

            if (roomList == null)
                roomList = new List<HRDepartmentRoomsInfo>();
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            AssetList = objAssetsController.GetAllAssets();
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            //AssetList = AssetList.Where(asset => roomList.Any(room => room.HRDepartmentRoomID == asset.FK_HRDepartmentRoomID)).ToList();
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            fld_dgcRP063Assets.DataSource = AssetList;
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

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            if (!AssetList.Exists(a => a.Selected == true))
            {
                MessageBox.Show(ReportLocalizedResources.ChooseAssetMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            BOSReport.RP063 report = new BOSReport.RP063();
            InitReportDataSource(report);
            guiReportPreview viewer = new guiReportPreview(report);
            viewer.Show();
        }

        /// <summary>
        /// Init the data source for the report
        /// </summary>
        /// <param name="report">Given report</param>        
        public void InitReportDataSource(XtraReport report)
        {
            DateTime toDate = fld_dteToDate.DateTime;
            BRBranchsController objBranchsController = new BRBranchsController();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = String.Format("Fax: {0}", objBranchsInfo.BRBranchContactFax);
            XRLabel dateTime = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblFromdateTodate"];
            dateTime.Text = string.Format("{0} {1}", ReportLocalizedResources.DateTitle, fld_dteToDate.Text);

            List<ACAssetsInfo> selectedAssets = AssetList.Where(a => a.Selected == true).ToList();
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
            foreach (ACAssetsInfo asset in selectedAssets)
            {
                List<ACDocumentEntrysInfo> result = GetAssetCard(asset, toDate);
                entries = entries.Concat(result).ToList();
            }
            report.DataSource = entries;
        }

        /// <summary>
        /// Get asset card of an asset
        /// </summary>
        /// <param name="asset">Given asset</param>
        /// <param name="toDate">Date the result is filtered to</param>
        /// <returns>Entry list represents the asset card</returns>
        private List<ACDocumentEntrysInfo> GetAssetCard(ACAssetsInfo asset, DateTime toDate)
        {
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
            ACDocumentEntrysInfo receiptEntry = new ACDocumentEntrysInfo();
            receiptEntry.ACAssetOriginalAmount = asset.ACAssetOriginalAmount;

            ACAssetReceiptItemsController objAssetReceiptItemsController = new ACAssetReceiptItemsController();
            ACAssetReceiptItemsInfo receiptItem = objAssetReceiptItemsController.GetItemByAssetID(asset.ACAssetID, null, toDate);
            if (receiptItem != null)
            {
                receiptEntry.ACDocumentNo = receiptItem.ACAssetReceiptNo;
                receiptEntry.ACDocumentDate = receiptItem.ACAssetReceiptDate;
                receiptEntry.ACDocumentDesc = receiptItem.ACAssetReceiptDesc;
                entries.Add(receiptEntry);
            }
            else
            {
                if (asset.ACAssetPurchasedDate.Date <= toDate.Date)
                {
                    receiptEntry.ACDocumentDate = asset.ACAssetPurchasedDate;
                    receiptEntry.ACDocumentDesc = ReportLocalizedResources.SpecifyAssetInitialBalance;
                    receiptEntry.ACAssetDepreciationDate = asset.ACAssetDepreciationDate;
                    receiptEntry.ACAssetDepreciatedAmount = asset.ACAssetInitDepreciatedAmount;
                    receiptEntry.ACAssetTotalDepreciatedAmount = asset.ACAssetInitDepreciatedAmount;
                    entries.Add(receiptEntry);
                }
            }

            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            List<ACDocumentEntrysInfo> depreciationEntries = objDocumentEntrysController.GetDepreciationEntriesByAssetID(asset.ACAssetID, null, toDate);
            decimal totalDepreciatedAmount = receiptEntry.ACAssetTotalDepreciatedAmount;
            foreach (ACDocumentEntrysInfo depreciationEntry in depreciationEntries)
            {
                totalDepreciatedAmount += depreciationEntry.ACDocumentEntryExchangeAmount;
                depreciationEntry.ACAssetDepreciatedAmount = depreciationEntry.ACDocumentEntryExchangeAmount;
                depreciationEntry.ACAssetTotalDepreciatedAmount = totalDepreciatedAmount;
                entries.Add(depreciationEntry);
            }

            ACAssetShipmentItemsController objAssetShipmentItemsController = new ACAssetShipmentItemsController();
            ACAssetShipmentItemsInfo shipmentItem = objAssetShipmentItemsController.GetItemByAssetID(asset.ACAssetID, null, toDate);
            if (shipmentItem != null)
            {
                foreach (ACDocumentEntrysInfo entry in entries)
                {
                    entry.ShipmentDocumentNo = shipmentItem.ACDocumentNo;
                    entry.ShipmentDocumentDate = shipmentItem.ACDocumentDate.ToString("dd/MM/yyyy");
                    entry.ShipmentDocumentDesc = shipmentItem.ACDocumentDesc;
                }
            }

            if (entries.Count > 0)
            {
                HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
                entries = entries.OrderBy(e => e.ACDocumentDate).ToList();
                foreach (ACDocumentEntrysInfo entry in entries)
                {
                    entry.ACAssetNo = asset.ACAssetNo;
                    entry.ACAssetName = asset.ACAssetName;
                    entry.ACAssetModelNo = asset.ACAssetModelNo;
                    entry.HRDepartmentRoomName = objDepartmentRoomsController.GetObjectNameByID(asset.FK_HRDepartmentRoomID);
                    entry.ACAssetPurchasedDate = asset.ACAssetPurchasedDate;
                    entry.ACAssetUsedDate = asset.ACAssetUsedDate;
                    entry.ACAssetComment = asset.ACAssetComment;
                    entry.ACAssetOriginalAmount = asset.ACAssetOriginalAmount;
                    entry.ACAssetDepreciationPercent = asset.ACAssetDepreciationPercent;
                    entry.ACAssetDepreciationAmount = asset.ACAssetDepreciationAmount;
                    entry.ACAssetExpiryMonths = asset.ACAssetExpiryMonths;
                }
            }

            return entries;
        }
    }
}
