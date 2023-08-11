using BOSCommon;
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
    public partial class RP065 : ReportForm
    {
        /// <summary>
        /// A variable to store the room list for selecting
        /// </summary>
        private List<HRDepartmentRoomsInfo> RoomList;

        public RP065()
        {
            InitializeComponent();
        }

        private void RP065_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteToDate.DateTime = BOSUtil.GetMonthEndDate();

            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            RoomList = objDepartmentRoomsController.GetAllRooms();
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            RoomList = RoomList.Where(room => BranchList.Any(branch => branch.BRBranchID == room.FK_BRBranchID)).ToList();
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            fld_dgcRP065DepartmentRooms.DataSource = RoomList;
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
            //if (!RoomList.Exists(r => r.Selected == true))
            //{
            //    MessageBox.Show(ReportLocalizedResources.ChooseRoomMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}
            BOSReport.RP065 report = new BOSReport.RP065();
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
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;
            XRLabel dateTime = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xr_lblFromdateTodate"];
            dateTime.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteFromDate.Text, ReportLocalizedResources.ToDateTitle, fld_dteToDate.Text);

            List<HRDepartmentRoomsInfo> selectedRooms = RoomList.Where(r => r.Selected == true).ToList();
            ICProductsController objProductsController = new ICProductsController();
            List<ICProductsInfo> equipments = objProductsController.GetAllEquipments();
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
            if (selectedRooms.Count == 0) selectedRooms.Add(new HRDepartmentRoomsInfo());
            foreach (HRDepartmentRoomsInfo room in selectedRooms)
            {
                //foreach (ICProductsInfo equipment in equipments)
                //{                    
                //    List<ACDocumentEntrysInfo> equipmentEntries = GetEquipmentHistory(equipment, room, fromDate, toDate);
                //    entries = entries.Concat(equipmentEntries).ToList();
                //}  
                List<ACDocumentEntrysInfo> equipmentEntries = GetEquipmentHistory(room, fromDate, toDate);
                entries = entries.Concat(equipmentEntries).ToList();
            }
            report.DataSource = entries;
        }

        private List<ACDocumentEntrysInfo> GetEquipmentHistory(HRDepartmentRoomsInfo room, DateTime fromDate, DateTime toDate)
        {
            //Add receipt entries
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentItems = objShipmentItemsController.GetItemsByDepartmentRoomID(room.HRDepartmentRoomID, fromDate, toDate);
            //shipmentItems = shipmentItems.Where(i => i.FK_HRDepartmentRoomID == room.HRDepartmentRoomID).ToList();
            foreach (ICShipmentItemsInfo item in shipmentItems)
            {
                if (item.ICShipmentType == ShipmentType.EquipmentShipment.ToString() || item.ICShipmentType == ShipmentType.EquipmentIncreasing.ToString())
                {
                    ACDocumentEntrysInfo receiptEntry = new ACDocumentEntrysInfo();
                    receiptEntry.ICMeasureUnitName = item.ICMeasureUnitName;
                    receiptEntry.ReceiptDocumentNo = item.ICShipmentNo;
                    receiptEntry.ACDocumentDate = item.ICShipmentDate;
                    receiptEntry.ReceiptDocumentDate = receiptEntry.ACDocumentDate.ToString("dd/MM/yyyy");
                    receiptEntry.ACDocumentDesc = item.ICShipmentDesc;
                    receiptEntry.EquipmentNo = item.ICProductNo;
                    receiptEntry.EquipmentName = item.ICProductName;
                    receiptEntry.EquipmentReceiptedQty = item.ICShipmentItemProductQty;
                    receiptEntry.EquipmentOriginalAmount = item.ICShipmentItemProductUnitPrice;
                    receiptEntry.EquipmentReceiptedAmount = receiptEntry.EquipmentOriginalAmount * receiptEntry.EquipmentReceiptedQty;
                    entries.Add(receiptEntry);
                }
                else if (item.ICShipmentType == ShipmentType.EquipmentDecreasing.ToString())
                {
                    ACDocumentEntrysInfo shipmentEntry = new ACDocumentEntrysInfo();
                    shipmentEntry.ICMeasureUnitName = item.ICMeasureUnitName;
                    shipmentEntry.ShipmentDocumentNo = item.ICShipmentNo;
                    shipmentEntry.ACDocumentDate = item.ICShipmentDate;
                    shipmentEntry.ShipmentDocumentDate = shipmentEntry.ACDocumentDate.ToString("dd/MM/yyyy");
                    shipmentEntry.ShipmentDocumentDesc = item.ICShipmentDesc;
                    shipmentEntry.EquipmentNo = item.ICProductNo;
                    shipmentEntry.EquipmentName = item.ICProductName;
                    shipmentEntry.EquipmentShippedQty = item.ICShipmentItemProductQty;
                    shipmentEntry.EquipmentShippedAmount = item.ICShipmentItemProductUnitPrice * item.ICShipmentItemProductQty;
                    entries.Add(shipmentEntry);
                }
            }

            //Add transfer entries
            ACEquipmentTransferItemsController objEquipmentTransferItemsController = new ACEquipmentTransferItemsController();
            List<ACEquipmentTransferItemsInfo> transferItems = objEquipmentTransferItemsController.GetItemsByDepartmentRoomID(room.HRDepartmentRoomID, fromDate, toDate);
            foreach (ACEquipmentTransferItemsInfo item in transferItems)
            {
                if (item.ACEquipmentTransferItemQty > 0)
                {
                    if (room.HRDepartmentRoomID == 0)
                    {
                        ACDocumentEntrysInfo receiptEntry = new ACDocumentEntrysInfo();
                        receiptEntry.ICMeasureUnitName = item.ICMeasureUnitName;
                        receiptEntry.ReceiptDocumentNo = item.ACDocumentNo;
                        receiptEntry.ACDocumentDate = item.ACDocumentDate;
                        receiptEntry.ReceiptDocumentDate = receiptEntry.ACDocumentDate.ToString("dd/MM/yyyy");
                        receiptEntry.ACDocumentDesc = item.ACDocumentDesc;
                        receiptEntry.EquipmentNo = item.ICProductNo;
                        receiptEntry.EquipmentName = item.ICProductName;
                        receiptEntry.EquipmentReceiptedQty = item.ACEquipmentTransferItemQty;
                        receiptEntry.EquipmentOriginalAmount = item.ACEquipmentTransferItemUnitPrice;
                        receiptEntry.EquipmentReceiptedAmount = receiptEntry.EquipmentOriginalAmount * receiptEntry.EquipmentReceiptedQty;
                        receiptEntry.EquipmentShippedQty = item.ACEquipmentTransferItemQty;
                        receiptEntry.EquipmentShippedAmount = item.ACEquipmentTransferItemUnitPrice * item.EquipmentShippedQty;
                        entries.Add(receiptEntry);
                    }
                    else if (item.FK_HRToRoomID == room.HRDepartmentRoomID)
                    {
                        ACDocumentEntrysInfo receiptEntry = new ACDocumentEntrysInfo();
                        receiptEntry.ICMeasureUnitName = item.ICMeasureUnitName;
                        receiptEntry.ReceiptDocumentNo = item.ACDocumentNo;
                        receiptEntry.ACDocumentDate = item.ACDocumentDate;
                        receiptEntry.ReceiptDocumentDate = receiptEntry.ACDocumentDate.ToString("dd/MM/yyyy");
                        receiptEntry.ACDocumentDesc = item.ACDocumentDesc;
                        receiptEntry.EquipmentNo = item.ICProductNo;
                        receiptEntry.EquipmentName = item.ICProductName;
                        receiptEntry.EquipmentReceiptedQty = item.ACEquipmentTransferItemQty;
                        receiptEntry.EquipmentOriginalAmount = item.ACEquipmentTransferItemUnitPrice;
                        receiptEntry.EquipmentReceiptedAmount = receiptEntry.EquipmentOriginalAmount * receiptEntry.EquipmentReceiptedQty;
                        entries.Add(receiptEntry);
                    }
                    else if (item.FK_HRFromRoomID == room.HRDepartmentRoomID)
                    {
                        ACDocumentEntrysInfo shipmentEntry = new ACDocumentEntrysInfo();
                        shipmentEntry.ICMeasureUnitName = item.ICMeasureUnitName;
                        shipmentEntry.ShipmentDocumentNo = item.ACDocumentNo;
                        shipmentEntry.ACDocumentDate = item.ACDocumentDate;
                        shipmentEntry.ShipmentDocumentDate = shipmentEntry.ACDocumentDate.ToString("dd/MM/yyyy");
                        shipmentEntry.ShipmentDocumentDesc = item.ACDocumentDesc;
                        shipmentEntry.EquipmentNo = item.ICProductNo;
                        shipmentEntry.EquipmentName = item.ICProductName;
                        shipmentEntry.EquipmentShippedQty = item.ACEquipmentTransferItemQty;
                        shipmentEntry.EquipmentShippedAmount = item.ACEquipmentTransferItemUnitPrice * shipmentEntry.EquipmentShippedQty;
                        entries.Add(shipmentEntry);
                    }
                }
            }

            if (entries.Count > 0)
            {
                entries = entries.OrderBy(e => e.ACDocumentDate).ToList();
                foreach (ACDocumentEntrysInfo entry in entries)
                {
                    entry.HRDepartmentRoomNo = room.HRDepartmentRoomNo;
                    entry.HRDepartmentRoomName = room.HRDepartmentRoomName;
                    //entry.ICMeasureUnitName = equipment.ICMeasureUnitName;
                }
            }

            return entries;
        }

        /// <summary>
        /// Get the history of an equipment relating to a room, including increasing and decreasing 
        /// relative entries
        /// </summary>
        /// <param name="equipment">Given equipment</param>
        /// <param name="room">Given room</param>
        /// <param name="fromDate">Date the result is filtered from</param>
        /// <param name="toDate">Date the result is filtered to</param>
        /// <returns>Entry list represents the equipment history</returns>
        private List<ACDocumentEntrysInfo> GetEquipmentHistory(ICProductsInfo equipment, HRDepartmentRoomsInfo room, DateTime fromDate, DateTime toDate)
        {
            //Add receipt entries
            List<ACDocumentEntrysInfo> entries = new List<ACDocumentEntrysInfo>();

            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentItems = objShipmentItemsController.GetItemsByEquipmentID(equipment.ICProductID, fromDate, toDate);
            shipmentItems = shipmentItems.Where(i => i.FK_HRDepartmentRoomID == room.HRDepartmentRoomID).ToList();
            foreach (ICShipmentItemsInfo item in shipmentItems)
            {
                if (item.ICShipmentType == ShipmentType.EquipmentShipment.ToString() || item.ICShipmentType == ShipmentType.EquipmentIncreasing.ToString())
                {
                    ACDocumentEntrysInfo receiptEntry = new ACDocumentEntrysInfo();
                    receiptEntry.ReceiptDocumentNo = item.ICShipmentNo;
                    receiptEntry.ACDocumentDate = item.ICShipmentDate;
                    receiptEntry.ReceiptDocumentDate = receiptEntry.ACDocumentDate.ToString("dd/MM/yyyy");
                    receiptEntry.ACDocumentDesc = item.ICShipmentDesc;
                    receiptEntry.EquipmentNo = item.ICProductNo;
                    receiptEntry.EquipmentName = string.Format("{0} / {1}", equipment.ICProductName, item.ICShipmentItemProductSerialNo);
                    receiptEntry.EquipmentReceiptedQty = item.ICShipmentItemProductQty;
                    receiptEntry.EquipmentOriginalAmount = item.ICShipmentItemProductUnitPrice;
                    receiptEntry.EquipmentReceiptedAmount = receiptEntry.EquipmentOriginalAmount * receiptEntry.EquipmentReceiptedQty;
                    entries.Add(receiptEntry);
                }
                else if (item.ICShipmentType == ShipmentType.EquipmentDecreasing.ToString())
                {
                    ACDocumentEntrysInfo shipmentEntry = new ACDocumentEntrysInfo();
                    shipmentEntry.ShipmentDocumentNo = item.ICShipmentNo;
                    shipmentEntry.ACDocumentDate = item.ICShipmentDate;
                    shipmentEntry.ShipmentDocumentDate = shipmentEntry.ACDocumentDate.ToString("dd/MM/yyyy");
                    shipmentEntry.ShipmentDocumentDesc = item.ICShipmentDesc;
                    shipmentEntry.EquipmentNo = item.ICProductNo;
                    shipmentEntry.EquipmentName = string.Format("{0} / {1}", equipment.ICProductName, item.ICShipmentItemProductSerialNo);
                    shipmentEntry.EquipmentShippedQty = item.ICShipmentItemProductQty;
                    shipmentEntry.EquipmentShippedAmount = item.ICShipmentItemProductUnitPrice * item.ICShipmentItemProductQty;
                    entries.Add(shipmentEntry);
                }
            }

            //Add transfer entries
            ACEquipmentTransferItemsController objEquipmentTransferItemsController = new ACEquipmentTransferItemsController();
            List<ACEquipmentTransferItemsInfo> transferItems = objEquipmentTransferItemsController.GetItemsByEquipmentID(equipment.ICProductID, fromDate, toDate);
            foreach (ACEquipmentTransferItemsInfo item in transferItems)
            {
                if (item.ACEquipmentTransferItemQty > 0)
                {
                    if (item.FK_HRToRoomID == room.HRDepartmentRoomID)
                    {
                        ACDocumentEntrysInfo receiptEntry = new ACDocumentEntrysInfo();
                        receiptEntry.ReceiptDocumentNo = item.ACDocumentNo;
                        receiptEntry.ACDocumentDate = item.ACDocumentDate;
                        receiptEntry.ReceiptDocumentDate = receiptEntry.ACDocumentDate.ToString("dd/MM/yyyy");
                        receiptEntry.ACDocumentDesc = item.ACDocumentDesc;
                        receiptEntry.EquipmentNo = item.ICProductNo;
                        receiptEntry.EquipmentName = string.Format("{0} / {1}", equipment.ICProductName, item.ICProductSerieNo);
                        receiptEntry.EquipmentReceiptedQty = item.ACEquipmentTransferItemQty;
                        receiptEntry.EquipmentOriginalAmount = item.ACEquipmentTransferItemUnitPrice;
                        receiptEntry.EquipmentReceiptedAmount = receiptEntry.EquipmentOriginalAmount * receiptEntry.EquipmentReceiptedQty;
                        entries.Add(receiptEntry);
                    }
                    else if (item.FK_HRFromRoomID == room.HRDepartmentRoomID)
                    {
                        ACDocumentEntrysInfo shipmentEntry = new ACDocumentEntrysInfo();
                        shipmentEntry.ShipmentDocumentNo = item.ACDocumentNo;
                        shipmentEntry.ACDocumentDate = item.ACDocumentDate;
                        shipmentEntry.ShipmentDocumentDate = shipmentEntry.ACDocumentDate.ToString("dd/MM/yyyy");
                        shipmentEntry.ShipmentDocumentDesc = item.ACDocumentDesc;
                        shipmentEntry.EquipmentNo = item.ICProductNo;
                        shipmentEntry.EquipmentName = string.Format("{0} / {1}", equipment.ICProductName, item.ICProductSerieNo);
                        shipmentEntry.EquipmentShippedQty = item.ACEquipmentTransferItemQty;
                        shipmentEntry.EquipmentShippedAmount = item.ACEquipmentTransferItemUnitPrice * shipmentEntry.EquipmentShippedQty;
                        entries.Add(shipmentEntry);
                    }
                }
            }

            if (entries.Count > 0)
            {
                entries = entries.OrderBy(e => e.ACDocumentDate).ToList();
                foreach (ACDocumentEntrysInfo entry in entries)
                {
                    entry.HRDepartmentRoomNo = room.HRDepartmentRoomNo;
                    entry.HRDepartmentRoomName = room.HRDepartmentRoomName;
                    entry.ICMeasureUnitName = equipment.ICMeasureUnitName;
                }
            }

            return entries;
        }

        private void fld_chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            RoomList.ForEach(r => r.Selected = fld_chkSelectAll.Checked);
            fld_dgcRP065DepartmentRooms.RefreshDataSource();
        }
    }
}
