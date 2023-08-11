using BOSComponent;
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
    public partial class RP148 : ReportForm
    {
        /// <summary>
        /// Gets or sets products
        /// </summary>
        public List<ICProductsInfo> SelectedProductList { get; set; }
        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
        private List<ICStocksInfo> stockListByUserGroup;
        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END

        #region Constructor
        public RP148()
        {
            InitializeComponent();
        }
        #endregion

        #region Override
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
        #endregion

        #region Events
        private void RP148_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteSearchFromDate.EditValue = BOSUtil.GetMonthBeginDate();
            fld_dteSearchToDate.EditValue = BOSUtil.GetMonthEndDate();
            SelectedProductList = new List<ICProductsInfo>();
            fld_dgcICRP148Equipment.DataSource = SelectedProductList;


        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {


            XtraReport report = null;

            report = new BOSReport.RP148();
            InitDataSourceReport(report);
            //XtraReportHelper.SetFormatField(report);

            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRP043Path, true);
            reviewer.Show();

        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (fld_chkSelectAll.Checked)
            {
                foreach (ICProductsInfo objProductsInfo in SelectedProductList)
                {
                    objProductsInfo.Selected = true;
                }
            }
            else
            {
                foreach (ICProductsInfo objProductsInfo in SelectedProductList)
                {
                    objProductsInfo.Selected = false;
                }
            }
            fld_dgcICRP148Equipment.RefreshDataSource();
        }
        #endregion

        #region Methods      
        /// <summary>
        /// Init data source report for displaying
        /// </summary>
        /// <param name="report">Given report</param>
        public void InitDataSourceReport(XtraReport report)
        {

            DateTime dateFrom = fld_dteSearchFromDate.DateTime;
            DateTime dateTo = fld_dteSearchToDate.DateTime;
            int RomID = 0;
            if (fld_lkeHRDepartmentRoomID.EditValue != null)
                int.TryParse(fld_lkeHRDepartmentRoomID.EditValue.ToString(), out RomID);

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
            dateTime.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromDate.Text,
                                                                                    ReportLocalizedResources.ToDateTitle, fld_dteSearchToDate.Text);
            XRLabel DepartmenRoomName = (XRLabel)report.Bands[BandKind.GroupHeader].Controls["xrLabel38"];
            if (DepartmenRoomName != null)
            {
                if (RomID == 0)
                {
                    DepartmenRoomName.Visible = false;
                }
            }

            report.DataSource = GetStockCardListBySomeCriteria();

        }

        /// <summary>
        /// Get stock card list by some criteria
        /// </summary>
        /// <returns>List of stock card</returns>
        private List<ICShipmentItemsInfo> GetStockCardListBySomeCriteria()
        {
            List<ICShipmentItemsInfo> ListShipmentItem = new List<ICShipmentItemsInfo>();
            ICShipmentItemsController objICShipmentItemsController = new ICShipmentItemsController();
            DateTime fromDate = fld_dteSearchFromDate.DateTime;
            DateTime toDate = fld_dteSearchToDate.DateTime;
            int departmentRoomID = 0;
            int branchID = 0;
            if (fld_lkeHRDepartmentRoomID.EditValue != null)
                int.TryParse(fld_lkeHRDepartmentRoomID.EditValue.ToString(), out departmentRoomID);
            if (fld_lkeBRBranchID.EditValue != null)
                int.TryParse(fld_lkeBRBranchID.EditValue.ToString(), out branchID);
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByBranchID(branchID);
            string branchNos = GetSelectedBranchNosByBranchID(branchID);
            List<ICShipmentItemsInfo> prevEquipmentCardEntries = new List<ICShipmentItemsInfo>();
            List<ICShipmentItemsInfo> equipmentCardEntries = new List<ICShipmentItemsInfo>();
            List<ICShipmentItemsInfo> equipmentEntries = new List<ICShipmentItemsInfo>();

            HRDepartmentRoomsController departmentRoomController = new HRDepartmentRoomsController();
            ICStocksController objStocksController = new ICStocksController();
            List<HRDepartmentRoomsInfo> departmentRooms = new List<HRDepartmentRoomsInfo>();
            List<ICShipmentItemsInfo> prevEquipmentIncreasingEntries = null;
            List<ICShipmentItemsInfo> temp = null;
            List<ICShipmentItemsInfo> temp1 = null;
            string departmentRoomNos = string.Empty;




            if (departmentRoomID > 0)
            {
                HRDepartmentRoomsInfo departmentRoom = departmentRoomController.GetObjectByID(departmentRoomID) as HRDepartmentRoomsInfo;
                departmentRoomNos = departmentRoom.HRDepartmentRoomNo;
                departmentRooms.Add(departmentRoom);
            }
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            else //if (stockID == 0)
            {
                departmentRooms = departmentRoomController.GetRoomListByBranchNos(branchNos);
                foreach (HRDepartmentRoomsInfo departmentRoom in departmentRooms)
                {
                    if (!string.IsNullOrEmpty(departmentRoomNos))
                        departmentRoomNos += ";";
                    departmentRoomNos += departmentRoom.HRDepartmentRoomNo;
                }
                //stocks = stockListByUserGroup;
                //stocks = stocks.Where(s => s.ICStockType == StockType.Sale.ToString() || s.ICStockType == StockType.Central.ToString()).ToList();
                //stocks = stocks.Where(s => !stocks.Exists(s1 => s1.ICStockParentID == s.ICStockID)).ToList();
            }
            List<ReportDic> reportDic = new List<ReportDic>();
            foreach (ICProductsInfo objProductsInfo in SelectedProductList)
            {
                if (objProductsInfo.Selected)
                {
                    temp1 = objICShipmentItemsController.GetListShipmentItemForReport148(null, fromDate.AddDays(-1), objProductsInfo.ICProductID, departmentRoomNos, branchNos);
                    prevEquipmentCardEntries = prevEquipmentCardEntries.Concat(temp1).ToList();
                    temp1 = objICShipmentItemsController.GetListShipmentItemForReport148(fromDate, toDate, objProductsInfo.ICProductID, departmentRoomNos, branchNos);
                    equipmentCardEntries = equipmentCardEntries.Concat(temp1).ToList();
                }
            }


            foreach (ICShipmentItemsInfo item in equipmentCardEntries)
            {
                if (reportDic.FirstOrDefault(t => t.BranchID == item.FK_BRBranchID
                                            && t.ProductSerieID == item.FK_ICProductSerieID
                                            && t.RoomID == item.HRDepartmentRoomID) == null)
                {
                    reportDic.Add(new ReportDic(item.FK_BRBranchID, item.HRDepartmentRoomID, item.FK_ICProductSerieID));
                }
            }
            foreach (ICProductsInfo objProductsInfo in SelectedProductList)
            {
                if (objProductsInfo.Selected)
                {
                    decimal endBalance = 0;
                    decimal endBalanceAmount = 0;
                    decimal endDepriciatedAmount = 0;
                    foreach (HRDepartmentRoomsInfo departmentRoom in departmentRooms)
                    {

                        List<ReportDic> reportCurrentDic = reportDic.Where(t => t.RoomID == departmentRoom.HRDepartmentRoomID).ToList();
                        if (reportCurrentDic != null && reportCurrentDic.Count > 0)
                        {
                            foreach (ReportDic rpdic in reportCurrentDic)
                            {
                                temp = temp1.Where(t => t.FK_ICProductSerieID == rpdic.ProductSerieID).ToList();

                                decimal openingBalance = 0;
                                decimal openingBalanceAmount = 0;
                                decimal openingDepreciatedAmount = 0;
                                decimal shipmentQty = 0;
                                decimal remainQty = 0;
                                decimal depreciatedAmount = 0;

                                //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                                //if (stock.ICStockID > 0)
                                openingBalance = prevEquipmentCardEntries.Where(sc => sc.FK_ICProductID == objProductsInfo.ICProductID
                                                                                    && sc.HRDepartmentRoomID == departmentRoom.HRDepartmentRoomID
                                                                                     && sc.EquipmentCardType != "PhanBoCCDC"
                                                                                       && sc.FK_ICProductSerieID == rpdic.ProductSerieID)
                                                                 .Sum(sc => sc.EquipmentCardReceiptItemProductQty - sc.EquipmentCardShipmentItemProductQty);

                                openingBalanceAmount = prevEquipmentCardEntries.Where(sc => sc.FK_ICProductID == objProductsInfo.ICProductID
                                                                                    && sc.HRDepartmentRoomID == departmentRoom.HRDepartmentRoomID
                                                                                    && sc.EquipmentCardType != "PhanBoCCDC"
                                                                                     && sc.FK_ICProductSerieID == rpdic.ProductSerieID)
                                                            .Sum(sc => sc.EquipmentCardReceiptAmount - sc.EquipmentCardShipmentAmount)
                                                             - prevEquipmentCardEntries.Where(sc => sc.FK_ICProductID == objProductsInfo.ICProductID
                                                                                    && sc.HRDepartmentRoomID == departmentRoom.HRDepartmentRoomID
                                                                                    && sc.EquipmentCardType == "PhanBoCCDC"
                                                                                     && sc.FK_ICProductSerieID == rpdic.ProductSerieID)
                                                                                                                           .Sum(sc => sc.EquipmentCardDepreciatedAmount);

                                prevEquipmentIncreasingEntries = prevEquipmentCardEntries.Where(sc => sc.FK_ICProductID == objProductsInfo.ICProductID
                                                                                    && sc.HRDepartmentRoomID == departmentRoom.HRDepartmentRoomID
                                                                                    && (sc.EquipmentCardType == "EquipmentIncreasing"
                                                                                        || sc.EquipmentCardType == "EquipmentTransferTo")
                                                                                         && sc.FK_ICProductSerieID == rpdic.ProductSerieID).ToList();

                                if (prevEquipmentIncreasingEntries != null)
                                {

                                    foreach (ICShipmentItemsInfo entry in prevEquipmentIncreasingEntries)
                                    {
                                        shipmentQty = prevEquipmentCardEntries.Where(sc => sc.FK_ICProductID == objProductsInfo.ICProductID
                                                                                    && sc.HRDepartmentRoomID == departmentRoom.HRDepartmentRoomID
                                                                                    && sc.ACEquipmentTransferItemID == entry.ACEquipmentTransferItemID
                                                                                    && sc.Id == entry.Id
                                                                                    && (sc.EquipmentCardType == "EquipmentDecreasing"
                                                                                        || sc.EquipmentCardType == "EquipmentTransferFrom"))
                                                                 .Sum(sc => sc.EquipmentCardShipmentItemProductQty);
                                        remainQty = entry.EquipmentCardReceiptItemProductQty - shipmentQty;
                                        depreciatedAmount = prevEquipmentCardEntries.Where(sc => sc.FK_ICProductID == objProductsInfo.ICProductID
                                                                                    && sc.HRDepartmentRoomID == departmentRoom.HRDepartmentRoomID
                                                                                    && sc.ACEquipmentTransferItemID == entry.ACEquipmentTransferItemID
                                                                                    && sc.Id == entry.Id
                                                                                    && (sc.EquipmentCardType == "PhanBoCCDC"))
                                                                                    .Sum(sc => sc.EquipmentCardDepreciatedAmount / sc.EquipmentCardDepreciatedProductQty);
                                        //.Sum(sc => sc.EquipmentCardDepreciatedAmount/sc.EquipmentCardDepreciatedProductQty);
                                        openingDepreciatedAmount +=
                                            // ((entry.EquipmentCardReceiptDepreciatedAmount / entry.EquipmentCardReceiptItemProductQty)
                                            ((entry.EquipmentCardReceiptDepreciatedAmount)
                                                                    + depreciatedAmount) * remainQty;


                                    }
                                }


                                temp = equipmentCardEntries.Where(s => s.FK_ICProductID == objProductsInfo.ICProductID
                                                                        && s.HRDepartmentRoomID == departmentRoom.HRDepartmentRoomID
                                                                         && s.FK_ICProductSerieID == rpdic.ProductSerieID).ToList();

                                if (openingBalance > 0 && temp.Count == 0)
                                {
                                    ICShipmentItemsInfo stockCard = new ICShipmentItemsInfo();
                                    stockCard.ICProductNo = objProductsInfo.ICProductNo;
                                    stockCard.ICProductSupplierNumber = objProductsInfo.ICProductSupplierNumber;
                                    stockCard.ICProductName = objProductsInfo.ICProductName;
                                    stockCard.ICProductDesc = objProductsInfo.ICProductDesc;
                                    stockCard.ICMeasureUnitName = objProductsInfo.ICMeasureUnitName;
                                    stockCard.HRDepartmentRoomName = departmentRoom.HRDepartmentRoomName;
                                    temp.Add(stockCard);
                                }
                                temp = temp.OrderBy(sc => sc.EquipmentCardDate).ToList();
                                if (temp.Count > 0)
                                {
                                    //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
                                    //if (roomID == 0)
                                    //    temp.ForEach(sc => sc.HRDepartmentRoomName = string.Empty);
                                    //else
                                    //    //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
                                    //    temp.ForEach(sc => sc.HRDepartmentRoomName = departmentRoom.HRDepartmentRoomName);
                                    temp[0].EquipmentCardOpeningBalance = openingBalance;
                                    temp[0].EquipmentCardOpeningBalanceAmount = openingBalanceAmount;
                                    temp[0].EquipmentCardOpeningDepreciatedAmount = openingDepreciatedAmount;
                                    temp[temp.Count - 1].EquipmentCardEndBalance = openingBalance + temp.Where(sc => sc.EquipmentCardType != "PhanBoCCDC")
                                                                                                            .Sum(sc => sc.EquipmentCardReceiptItemProductQty -
                                                                                                                    sc.EquipmentCardShipmentItemProductQty);

                                    //Giá trị còn lại = Giá trị đầu kì + giá trị nhập - phân bổ - giá trị xuất
                                    temp[temp.Count - 1].EquipmentCardEndBalanceAmount = openingBalanceAmount + temp.Where(sc => sc.EquipmentCardType != "PhanBoCCDC")
                                                                                                                            .Sum(sc => sc.EquipmentCardReceiptAmount -
                                                                                                                                sc.EquipmentCardShipmentAmount)
                                                                                                                                - temp.Where(sc => sc.EquipmentCardType == "PhanBoCCDC")
                                                                                                                            .Sum(sc => sc.EquipmentCardDepreciatedAmount);
                                    //Phân bổ = phân bổ nhập + phân bổ - phân bổ xuất
                                    temp[temp.Count - 1].EquipmentCardEndDepreciatedAmount = openingDepreciatedAmount + temp.Sum(sc => (sc.EquipmentCardReceiptDepreciatedAmount * sc.EquipmentCardReceiptItemProductQty +
                                                                                                                            ((sc.EquipmentCardDepreciatedAmount)) -
                                                                                                                            sc.EquipmentCardShipmentDepreciatedAmount * sc.EquipmentCardShipmentItemProductQty));
                                    //temp[temp.Count - 1].EquipmentCardEndDepreciatedAmount = openingDepreciatedAmount + temp.Sum(sc => (sc.EquipmentCardDepreciatedAmount));

                                    //    temp[temp.Count - 1].EquipmentCardEndBalanceAmount -= temp[temp.Count - 1].EquipmentCardEndDepreciatedAmount;

                                    endBalance += temp[temp.Count - 1].EquipmentCardEndBalance;
                                    endBalanceAmount += (temp[temp.Count - 1].EquipmentCardEndBalanceAmount);
                                    endDepriciatedAmount += temp[temp.Count - 1].EquipmentCardEndDepreciatedAmount;
                                    foreach (ICShipmentItemsInfo shipmentItem in temp)
                                    {

                                        if (shipmentItem.EquipmentCardReceiptItemProductQty != 0)
                                        {
                                            shipmentItem.EquipmentCardReceiptNo = shipmentItem.EquipmentCardNo;
                                            shipmentItem.EquipmentCardNo = string.Empty;
                                            shipmentItem.ICShipmentItemProductQty = shipmentItem.EquipmentCardReceiptItemProductQty;
                                            shipmentItem.ICShipmentItemTotalAmount = shipmentItem.EquipmentCardReceiptAmount;
                                            shipmentItem.ICShipmentItemDepreciatedAmount = shipmentItem.EquipmentCardReceiptDepreciatedAmount * shipmentItem.EquipmentCardReceiptItemProductQty;
                                        }
                                        if (shipmentItem.EquipmentCardShipmentItemProductQty != 0)
                                        {
                                            shipmentItem.EquipmentCardShipmentNo = shipmentItem.EquipmentCardNo;
                                            shipmentItem.EquipmentCardNo = string.Empty;
                                            shipmentItem.ICShipmentItemProductQty = shipmentItem.EquipmentCardShipmentItemProductQty;
                                            shipmentItem.ICShipmentItemTotalAmount = shipmentItem.EquipmentCardShipmentAmount;
                                            shipmentItem.ICShipmentItemDepreciatedAmount = shipmentItem.EquipmentCardShipmentDepreciatedAmount * shipmentItem.EquipmentCardShipmentItemProductQty;
                                        }
                                        if (shipmentItem.EquipmentCardDepreciatedProductQty != 0)
                                        {
                                            //shipmentItem.EquipmentCardShipmentNo = shipmentItem.EquipmentCardNo;
                                            shipmentItem.ICShipmentItemProductQty = shipmentItem.EquipmentCardDepreciatedProductQty;
                                            shipmentItem.ICShipmentItemTotalAmount = openingBalanceAmount;
                                            shipmentItem.ICShipmentItemDepreciatedAmount = shipmentItem.EquipmentCardDepreciatedAmount;
                                        }

                                        shipmentItem.EquipmentCardBalanceProductQty = openingBalance;
                                        shipmentItem.EquipmentCardBalanceAmount = openingBalanceAmount;
                                        shipmentItem.EquipmentCardDepreciatedAmount = openingDepreciatedAmount;

                                        if (shipmentItem.EquipmentCardDepreciatedProductQty == 0)
                                        {
                                            shipmentItem.EquipmentCardBalanceProductQty += shipmentItem.EquipmentCardReceiptItemProductQty
                                                                                  - shipmentItem.EquipmentCardShipmentItemProductQty
                                                                                  ;
                                            shipmentItem.EquipmentCardBalanceAmount += shipmentItem.EquipmentCardReceiptAmount
                                                                                  - shipmentItem.EquipmentCardShipmentAmount;

                                        }
                                        if (shipmentItem.EquipmentCardDepreciatedProductQty != 0)
                                        {
                                            shipmentItem.EquipmentCardDepreciatedAmount += shipmentItem.ICShipmentItemDepreciatedAmount;
                                            shipmentItem.EquipmentCardBalanceAmount -= shipmentItem.ICShipmentItemDepreciatedAmount;
                                            //shipmentItem.ICShipmentItemTotalAmount = shipmentItem.EquipmentCardBalanceAmount + shipmentItem.ICShipmentItemDepreciatedAmount;
                                        }
                                        if (shipmentItem.EquipmentCardReceiptItemProductQty != 0)
                                        {
                                            shipmentItem.EquipmentCardDepreciatedAmount = shipmentItem.ICShipmentItemDepreciatedAmount;
                                            shipmentItem.EquipmentCardBalanceAmount = shipmentItem.ICShipmentItemTotalAmount;
                                        }
                                        //if (shipmentItem.EquipmentCardDepreciatedProductQty != 0 || shipmentItem.EquipmentCardReceiptItemProductQty != 0)
                                        //{
                                        //    shipmentItem.EquipmentCardDepreciatedAmount += shipmentItem.ICShipmentItemDepreciatedAmount;
                                        //    shipmentItem.EquipmentCardBalanceAmount -= shipmentItem.ICShipmentItemDepreciatedAmount;
                                        //    //shipmentItem.ICShipmentItemTotalAmount = shipmentItem.EquipmentCardBalanceAmount + shipmentItem.ICShipmentItemDepreciatedAmount;
                                        //}
                                        if (shipmentItem.EquipmentCardShipmentItemProductQty != 0)
                                        {
                                            shipmentItem.EquipmentCardDepreciatedAmount -= shipmentItem.ICShipmentItemDepreciatedAmount;
                                            //shipmentItem.EquipmentCardBalanceAmount += shipmentItem.ICShipmentItemDepreciatedAmount;
                                            //shipmentItem.ICShipmentItemTotalAmount = shipmentItem.EquipmentCardBalanceAmount + shipmentItem.ICShipmentItemDepreciatedAmount;
                                        }
                                        openingBalance = shipmentItem.EquipmentCardBalanceProductQty;
                                        openingBalanceAmount = shipmentItem.EquipmentCardBalanceAmount;
                                        openingDepreciatedAmount = shipmentItem.EquipmentCardDepreciatedAmount;
                                        equipmentEntries.Add(shipmentItem);
                                    }
                                }
                            }
                        }
                    }

                    //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
                    //if (roomID == 0)
                    //    break;
                    //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END

                    if (equipmentEntries.Count != 0)
                    {
                        equipmentEntries[equipmentEntries.Count - 1].EquipmentCardEndBalance1 = endBalance;
                        equipmentEntries[equipmentEntries.Count - 1].EquipmentCardEndBalanceAmount1 = endBalanceAmount;
                        equipmentEntries[equipmentEntries.Count - 1].EquipmentCardEndDepreciatedAmount1 = endDepriciatedAmount;
                    }
                }
            }
            //equipmentCardEntries = equipmentCardEntries.OrderBy(sc => sc.EquipmentCardDate).ToList();

            return equipmentEntries;


        }

        #endregion

        private void fld_lkeICProductID_KeyUp(object sender, KeyEventArgs e)
        {
            BOSLookupEdit lke = (BOSLookupEdit)sender;
            if (e.KeyCode == Keys.Enter)
            {
                ICProductsController objProductsController = new ICProductsController();
                int productID = Convert.ToInt32(lke.EditValue);
                ICProductsInfo objProductsInfo = SelectedProductList.Where(p => p.ICProductID == productID).FirstOrDefault();
                if (objProductsInfo == null)
                {
                    objProductsInfo = (ICProductsInfo)objProductsController.GetProductByID(productID);
                    objProductsInfo.Selected = true;
                    SelectedProductList.Add(objProductsInfo);
                }
                fld_dgcICRP148Equipment.RefreshDataSource();
            }
        }
    }
    public class ReportDic
    {
        public int BranchID;
        public int RoomID;
        public int ProductSerieID;

        public ReportDic(int branchID, int roomID, int productSerieID)
        {
            BranchID = branchID;
            RoomID = roomID;
            ProductSerieID = productSerieID;
        }

    }

}
