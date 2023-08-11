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
    public partial class RP069 : ReportForm
    {
        /// <summary>
        /// A variable to store the room list for selecting
        /// </summary>
        private List<HRDepartmentRoomsInfo> RoomList;

        public RP069()
        {
            InitializeComponent();
        }

        private void RP069_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteToDate.DateTime = BOSUtil.GetMonthEndDate();

            HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            RoomList = objDepartmentRoomsController.GetAllRooms();
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            RoomList = RoomList.Where(room => BranchList.Any(branch => branch.BRBranchID == room.FK_BRBranchID)).ToList();
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            fld_dgcRP069DepartmentRooms.DataSource = RoomList;
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
            BOSReport.RP069 report = new BOSReport.RP069();
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

            //List<HRDepartmentRoomsInfo> selectedRooms = RoomList.Where(r => r.Selected == true).ToList();
            //ICProductsController objProductsController = new ICProductsController();
            //List<ICProductsInfo> equipments = objProductsController.GetAllEquipments();
            //List<ICShipmentItemsInfo> entries = new List<ICShipmentItemsInfo>();
            //List<ICShipmentItemsInfo> equipmentEntries = new List<ICShipmentItemsInfo>();
            //foreach (HRDepartmentRoomsInfo room in selectedRooms)
            //{
            //    foreach (ICProductsInfo equipment in equipments)
            //    {
            //        List<ICShipmentItemsInfo> equipmentEntries = GetEquipmentHistory(equipment, room, fromDate, toDate);
            //        entries = entries.Concat(equipmentEntries).ToList();
            //    }            
            //}
            List<HRDepartmentRoomsInfo> selectedRooms = RoomList.Where(r => r.Selected == true).ToList();
            List<ICShipmentItemsInfo> entries = new List<ICShipmentItemsInfo>();
            foreach (HRDepartmentRoomsInfo room in selectedRooms)
            {
                List<ICShipmentItemsInfo> equipmentEntries = GetEquipmentHistory(room, fromDate, toDate);
                entries = entries.Concat(equipmentEntries).ToList();
            }
            report.DataSource = entries;
        }

        private List<ICShipmentItemsInfo> GetEquipmentHistory(HRDepartmentRoomsInfo room, DateTime fromDate, DateTime toDate)
        {
            //Add equipment increasing and decreasing items
            List<ICShipmentItemsInfo> history = new List<ICShipmentItemsInfo>();
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentItems = objShipmentItemsController.GetItemsByDepartmentRoomID(room.HRDepartmentRoomID, fromDate, toDate);
            //shipmentItems = shipmentItems.Where(i => i.FK_HRDepartmentRoomID == room.HRDepartmentRoomID).ToList();
            foreach (ICShipmentItemsInfo item in shipmentItems)
            {
                if (item.ICShipmentType == ShipmentType.EquipmentShipment.ToString() || item.ICShipmentType == ShipmentType.EquipmentIncreasing.ToString())
                {
                    history.Add(item);
                }
                else if (item.ICShipmentType == ShipmentType.EquipmentDecreasing.ToString())
                {
                    ICShipmentItemsInfo decreasingItem = new ICShipmentItemsInfo();
                    decreasingItem.ICProductNo = item.ICProductNo;
                    decreasingItem.ICProductName = item.ICProductName;
                    decreasingItem.ICMeasureUnitName = item.ICMeasureUnitName;
                    decreasingItem.ICProductModelNo = item.ICProductModelNo;
                    decreasingItem.EquipmentDecreasingNo = item.ICShipmentNo;
                    decreasingItem.EquipmentDecreasingDate = item.ICShipmentDate;
                    decreasingItem.EquipmentDecreasingDesc = item.ICShipmentDesc;
                    decreasingItem.EquipmentShippedQty = item.ICShipmentItemProductQty;
                    decreasingItem.ICShipmentItemDepreciatedAmount = item.ICShipmentItemDepreciatedAmount;
                    decreasingItem.ICShipmentItemRemainedAmount = item.ICShipmentItemRemainedAmount;
                    history.Add(decreasingItem);
                }
            }
            //Add equipment transfer items
            ACEquipmentTransferItemsController objEquipmentTransferItemsController = new ACEquipmentTransferItemsController();
            List<ACEquipmentTransferItemsInfo> transferItems = objEquipmentTransferItemsController.GetItemsByDepartmentRoomID(room.HRDepartmentRoomID, fromDate, toDate);
            foreach (ACEquipmentTransferItemsInfo item in transferItems)
            {
                if (item.ACEquipmentTransferItemQty > 0)
                {
                    if (item.FK_HRToRoomID == room.HRDepartmentRoomID)
                    {
                        ICShipmentItemsInfo increasingItem = new ICShipmentItemsInfo();
                        increasingItem.ICProductNo = item.ICProductNo;
                        increasingItem.ICProductName = item.ICProductName;
                        increasingItem.ICMeasureUnitName = item.ICMeasureUnitName;
                        increasingItem.ICProductModelNo = item.ICProductModelNo;
                        increasingItem.ICShipmentNo = item.ACDocumentNo;
                        increasingItem.ICShipmentDate = item.ACDocumentDate;
                        increasingItem.ICShipmentDesc = item.ACDocumentDesc;
                        increasingItem.ICShipmentItemProductQty = item.ACEquipmentTransferItemQty;
                        increasingItem.ICShipmentItemProductUnitPrice = item.ACEquipmentTransferItemUnitPrice;
                        increasingItem.ICShipmentItemDepreciatedAmount = item.ACEquipmentTransferItemDepreciatedAmount;
                        increasingItem.ICShipmentItemRemainedAmount = item.EquipmentRemainedAmount;
                        history.Add(increasingItem);
                    }
                    else if (item.FK_HRFromRoomID == room.HRDepartmentRoomID)
                    {
                        ICShipmentItemsInfo decreasingItem = new ICShipmentItemsInfo();
                        decreasingItem.ICProductNo = item.ICProductNo;
                        decreasingItem.ICProductName = item.ICProductName;
                        decreasingItem.ICMeasureUnitName = item.ICMeasureUnitName;
                        decreasingItem.ICProductModelNo = item.ICProductModelNo;
                        decreasingItem.EquipmentDecreasingNo = item.ACDocumentNo;
                        decreasingItem.EquipmentDecreasingDate = item.ACDocumentDate;
                        decreasingItem.EquipmentDecreasingDesc = item.ACDocumentDesc;
                        decreasingItem.EquipmentShippedQty = item.ACEquipmentTransferItemQty;
                        decreasingItem.ICShipmentItemDepreciatedAmount = item.ACEquipmentTransferItemDepreciatedAmount;
                        decreasingItem.ICShipmentItemRemainedAmount = item.EquipmentRemainedAmount;
                        history.Add(decreasingItem);
                    }
                }
            }

            if (history.Count > 0)
            {
                history = history.OrderBy(p => p.ICShipmentDate).ThenBy(p => p.EquipmentDecreasingDate).ToList();
                history.ForEach(p => p.HRDepartmentRoomName = room.HRDepartmentRoomName);
            }

            return history;
        }

        /// <summary>
        /// Get the history of an equipment relating to a room, including increasing and decreasing 
        /// relative entries
        /// </summary>
        /// <param name="equipment">Given equipment</param>
        /// <param name="room">Given room</param>
        /// <param name="fromDate">Date the result is filtered from</param>
        /// <param name="toDate">Date the result is filtered to</param>
        /// <returns>Shipment items represents the equipment history</returns>
        private List<ICShipmentItemsInfo> GetEquipmentHistory(ICProductsInfo equipment, HRDepartmentRoomsInfo room, DateTime fromDate, DateTime toDate)
        {
            //Add equipment increasing and decreasing items
            List<ICShipmentItemsInfo> history = new List<ICShipmentItemsInfo>();
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentItems = objShipmentItemsController.GetItemsByEquipmentID(equipment.ICProductID, fromDate, toDate);
            shipmentItems = shipmentItems.Where(i => i.FK_HRDepartmentRoomID == room.HRDepartmentRoomID).ToList();
            foreach (ICShipmentItemsInfo item in shipmentItems)
            {
                if (item.ICShipmentType == ShipmentType.EquipmentShipment.ToString() || item.ICShipmentType == ShipmentType.EquipmentIncreasing.ToString())
                {
                    item.ICShipmentItemProductName = string.Format("{0} / {1}", equipment.ICProductName, item.ICShipmentItemProductSerialNo);
                    history.Add(item);
                }
                else if (item.ICShipmentType == ShipmentType.EquipmentDecreasing.ToString())
                {
                    ICShipmentItemsInfo decreasingItem = new ICShipmentItemsInfo();
                    decreasingItem.EquipmentDecreasingNo = item.ICShipmentNo;
                    decreasingItem.EquipmentDecreasingDate = item.ICShipmentDate;
                    decreasingItem.EquipmentDecreasingDesc = item.ICShipmentDesc;
                    decreasingItem.ICShipmentItemProductName = string.Format("{0} / {1}", equipment.ICProductName, item.ICShipmentItemProductSerialNo);
                    decreasingItem.EquipmentShippedQty = item.ICShipmentItemProductQty;
                    decreasingItem.ICShipmentItemDepreciatedAmount = item.ICShipmentItemDepreciatedAmount;
                    decreasingItem.ICShipmentItemRemainedAmount = item.ICShipmentItemRemainedAmount;
                    history.Add(decreasingItem);
                }
            }

            //Add equipment transfer items
            ACEquipmentTransferItemsController objEquipmentTransferItemsController = new ACEquipmentTransferItemsController();
            List<ACEquipmentTransferItemsInfo> transferItems = objEquipmentTransferItemsController.GetItemsByEquipmentID(equipment.ICProductID, fromDate, toDate);
            foreach (ACEquipmentTransferItemsInfo item in transferItems)
            {
                if (item.ACEquipmentTransferItemQty > 0)
                {
                    if (item.FK_HRToRoomID == room.HRDepartmentRoomID)
                    {
                        ICShipmentItemsInfo increasingItem = new ICShipmentItemsInfo();
                        increasingItem.ICShipmentNo = item.ACDocumentNo;
                        increasingItem.ICShipmentDate = item.ACDocumentDate;
                        increasingItem.ICShipmentDesc = item.ACDocumentDesc;
                        increasingItem.ICShipmentItemProductName = string.Format("{0} / {1}", equipment.ICProductName, item.ICProductSerieNo);
                        increasingItem.ICShipmentItemProductQty = item.ACEquipmentTransferItemQty;
                        increasingItem.ICShipmentItemProductUnitPrice = item.ACEquipmentTransferItemUnitPrice;
                        increasingItem.ICShipmentItemDepreciatedAmount = item.ACEquipmentTransferItemDepreciatedAmount;
                        increasingItem.ICShipmentItemRemainedAmount = item.EquipmentRemainedAmount;
                        history.Add(increasingItem);
                    }
                    else if (item.FK_HRFromRoomID == room.HRDepartmentRoomID)
                    {
                        ICShipmentItemsInfo decreasingItem = new ICShipmentItemsInfo();
                        decreasingItem.EquipmentDecreasingNo = item.ACDocumentNo;
                        decreasingItem.EquipmentDecreasingDate = item.ACDocumentDate;
                        decreasingItem.EquipmentDecreasingDesc = item.ACDocumentDesc;
                        decreasingItem.ICShipmentItemProductName = string.Format("{0} / {1}", equipment.ICProductName, item.ICProductSerieNo);
                        decreasingItem.EquipmentShippedQty = item.ACEquipmentTransferItemQty;
                        decreasingItem.ICShipmentItemDepreciatedAmount = item.ACEquipmentTransferItemDepreciatedAmount;
                        decreasingItem.ICShipmentItemRemainedAmount = item.EquipmentRemainedAmount;
                        history.Add(decreasingItem);
                    }
                }
            }

            if (history.Count > 0)
            {
                history = (from i in history
                           orderby i.ICShipmentDate, i.EquipmentDecreasingDate
                           select i).ToList();
                foreach (ICShipmentItemsInfo item in history)
                {
                    item.ICProductNo = equipment.ICProductNo;
                    item.ICProductName = equipment.ICProductName;
                    item.ICMeasureUnitName = equipment.ICMeasureUnitName;
                    item.ICProductModelNo = equipment.ICProductModelNo;
                    item.HRDepartmentRoomName = room.HRDepartmentRoomName;
                }
            }

            return history;
        }

        private void fld_chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            RoomList.ForEach(r => r.Selected = fld_chkSelectAll.Checked);
            fld_dgcRP069DepartmentRooms.RefreshDataSource();
        }
    }
}
