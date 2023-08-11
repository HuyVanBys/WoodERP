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
    public partial class RP064 : ReportForm
    {
        /// <summary>
        /// A variable to store the room list for selecting
        /// </summary>
        private List<HRDepartmentRoomsInfo> RoomList;

        public RP064()
        {
            InitializeComponent();
        }

        private void RP064_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteToDate.DateTime = BOSUtil.GetMonthEndDate();

            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            RoomList = objDepartmentRoomsController.GetAllRooms();
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            RoomList = RoomList.Where(room => BranchList.Any(branch => branch.BRBranchID == room.FK_BRBranchID)).ToList();
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            fld_dgcRP064DepartmentRooms.DataSource = RoomList;
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
            if (!RoomList.Exists(r => r.Selected == true))
            {
                MessageBox.Show(ReportLocalizedResources.ChooseRoomMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            BOSReport.RP064 report = new BOSReport.RP064();
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
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            BRBranchsController objBranchsController = new BRBranchsController();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = String.Format("Điện thoại: {0}", objBranchsInfo.BRBranchContactPhone);
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = String.Format("Fax: {0}", objBranchsInfo.BRBranchContactFax);
            XRLabel dateTime = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblFromdateTodate"];
            dateTime.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteFromDate.Text, ReportLocalizedResources.ToDateTitle, fld_dteToDate.Text);

            List<HRDepartmentRoomsInfo> selectedRooms = RoomList.Where(r => r.Selected == true).ToList();
            ACAssetsController objAssetsController = new ACAssetsController();
            List<ACAssetsInfo> assets = objAssetsController.GetAllAssets();
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
            foreach (HRDepartmentRoomsInfo room in selectedRooms)
            {
                foreach (ACAssetsInfo asset in assets)
                {
                    List<ACDocumentEntrysInfo> assetEntries = GetAssetHistory(asset, room, fromDate, toDate);
                    entries = entries.Concat(assetEntries).ToList();
                }
            }
            report.DataSource = entries;
        }

        /// <summary>
        /// Get the history of an asset relating to a room, including increasing and decreasing 
        /// relative entries
        /// </summary>
        /// <param name="asset">Given asset</param>
        /// <param name="room">Given room</param>
        /// <param name="fromDate">Date the result is filtered from</param>
        /// <param name="toDate">Date the result is filtered to</param>
        /// <returns>Entry list represents the asset history</returns>
        private List<ACDocumentEntrysInfo> GetAssetHistory(ACAssetsInfo asset, HRDepartmentRoomsInfo room, DateTime fromDate, DateTime toDate)
        {
            //Add receipt entries
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
            ACDocumentEntrysInfo receiptEntry = new ACDocumentEntrysInfo();
            ACAssetReceiptItemsController objAssetReceiptItemsController = new ACAssetReceiptItemsController();
            ACAssetReceiptItemsInfo receiptItem = objAssetReceiptItemsController.GetItemByAssetID(asset.ACAssetID, fromDate, toDate);
            if (receiptItem != null && receiptItem.FK_HRDepartmentRoomID == room.HRDepartmentRoomID)
            {
                receiptEntry.ReceiptDocumentNo = receiptItem.ACAssetReceiptNo;
                receiptEntry.ACDocumentDate = receiptItem.ACAssetReceiptDate;
                receiptEntry.ReceiptDocumentDate = receiptEntry.ACDocumentDate.ToString("dd/MM/yyyy");
                receiptEntry.ACDocumentDesc = receiptItem.ACAssetReceiptDesc;
                receiptEntry.AssetReceiptedQty = receiptItem.ACAssetReceiptItemQty;
            }
            else
            {
                if (asset.FK_HRInitRoomID == room.HRDepartmentRoomID)
                {
                    if (asset.ACAssetPurchasedDate.Date >= fromDate.Date && asset.ACAssetPurchasedDate.Date <= toDate.Date)
                    {
                        receiptEntry.ACDocumentDate = asset.ACAssetPurchasedDate;
                        receiptEntry.ReceiptDocumentDate = receiptEntry.ACDocumentDate.ToString("dd/MM/yyyy");
                        receiptEntry.ACDocumentDesc = ReportLocalizedResources.SpecifyAssetInitialBalance;
                        receiptEntry.AssetReceiptedQty = asset.ACAssetInitQty;
                    }
                }
            }
            if (receiptEntry.AssetReceiptedQty > 0)
            {
                receiptEntry.ACAssetOriginalAmount = asset.ACAssetOriginalAmount;
                receiptEntry.AssetReceiptedAmount = receiptEntry.ACAssetOriginalAmount * receiptEntry.AssetReceiptedQty;
                entries.Add(receiptEntry);
            }

            //Add transfer entries
            ACAssetTransferItemsController objAssetTransferItemsController = new ACAssetTransferItemsController();
            List<ACAssetTransferItemsInfo> transferItems = objAssetTransferItemsController.GetItemsByAssetID(asset.ACAssetID, fromDate, toDate);
            foreach (ACAssetTransferItemsInfo item in transferItems)
            {
                if (item.ACAssetTransferItemQty > 0)
                {
                    if (item.FK_HRToRoomID == room.HRDepartmentRoomID)
                    {
                        receiptEntry = new ACDocumentEntrysInfo();
                        receiptEntry.ReceiptDocumentNo = item.ACDocumentNo;
                        receiptEntry.ACDocumentDate = item.ACDocumentDate;
                        receiptEntry.ReceiptDocumentDate = receiptEntry.ACDocumentDate.ToString("dd/MM/yyyy");
                        receiptEntry.ACDocumentDesc = item.ACDocumentDesc;
                        receiptEntry.AssetReceiptedQty = item.ACAssetTransferItemQty;
                        receiptEntry.ACAssetOriginalAmount = asset.ACAssetOriginalAmount;
                        receiptEntry.AssetReceiptedAmount = receiptEntry.ACAssetOriginalAmount * receiptEntry.AssetReceiptedQty;
                        entries.Add(receiptEntry);
                    }
                    else if (item.FK_HRFromRoomID == room.HRDepartmentRoomID)
                    {
                        ACDocumentEntrysInfo shipmentEntry = new ACDocumentEntrysInfo();
                        shipmentEntry.ShipmentDocumentNo = item.ACDocumentNo;
                        shipmentEntry.ACDocumentDate = item.ACDocumentDate;
                        shipmentEntry.ShipmentDocumentDate = shipmentEntry.ACDocumentDate.ToString("dd/MM/yyyy");
                        shipmentEntry.ShipmentDocumentDesc = item.ACDocumentDesc;
                        shipmentEntry.AssetShippedQty = item.ACAssetTransferItemQty;
                        shipmentEntry.AssetShippedAmount = asset.ACAssetOriginalAmount * shipmentEntry.AssetShippedQty;
                        entries.Add(shipmentEntry);
                    }
                }
            }

            //Add shipment entries
            ACAssetShipmentItemsController objAssetShipmentItemsController = new ACAssetShipmentItemsController();
            ACAssetShipmentItemsInfo shipmentItem = objAssetShipmentItemsController.GetItemByAssetID(asset.ACAssetID, fromDate, toDate);
            if (shipmentItem != null && shipmentItem.ACAssetShipmentItemQty > 0 && shipmentItem.FK_HRDepartmentRoomID == room.HRDepartmentRoomID)
            {
                ACDocumentEntrysInfo shipmentEntry = new ACDocumentEntrysInfo();
                shipmentEntry.ShipmentDocumentNo = shipmentItem.ACDocumentNo;
                shipmentEntry.ACDocumentDate = shipmentItem.ACDocumentDate;
                shipmentEntry.ShipmentDocumentDate = shipmentEntry.ACDocumentDate.ToString("dd/MM/yyyy");
                shipmentEntry.ShipmentDocumentDesc = shipmentItem.ACDocumentDesc;
                shipmentEntry.AssetShippedQty = shipmentItem.ACAssetShipmentItemQty;
                shipmentEntry.AssetShippedAmount = asset.ACAssetOriginalAmount * shipmentEntry.AssetShippedQty;
                entries.Add(shipmentEntry);
            }

            if (entries.Count > 0)
            {
                entries = entries.OrderBy(e => e.ACDocumentDate).ToList();
                foreach (ACDocumentEntrysInfo entry in entries)
                {
                    entry.HRDepartmentRoomNo = room.HRDepartmentRoomNo;
                    entry.HRDepartmentRoomName = room.HRDepartmentRoomName;
                    entry.ACAssetNo = asset.ACAssetNo;
                    entry.ACAssetName = asset.ACAssetName;
                    entry.ICMeasureUnitName = asset.ICMeasureUnitName;
                }
            }

            return entries;
        }

        private void fld_chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            RoomList.ForEach(r => r.Selected = fld_chkSelectAll.Checked);
            fld_dgcRP064DepartmentRooms.RefreshDataSource();
        }
    }
}
