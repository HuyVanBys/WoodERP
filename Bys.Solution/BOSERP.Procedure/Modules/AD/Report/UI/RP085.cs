using BOSCommon;
using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP085 : ReportForm
    {
        /// <summary>
        /// A variable to store the equipment list for selecting
        /// </summary>
        private List<ICProductsInfo> equipments;

        public RP085()
        {
            InitializeComponent();
        }

        private void RP080_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteFromDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_dteToDate.DateTime = BOSUtil.GetMonthEndDate();

            GetEquipmentsBySomeCriteria();
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
            if (!equipments.Exists(r => r.Selected == true))
            {
                MessageBox.Show(ReportLocalizedResources.ChooseRoomMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //BOSReport.RP085 report = new BOSReport.RP085();
            //InitReportDataSource(report);
            //guiReportPreview viewer = new guiReportPreview(report);
            //viewer.Show();

            List<string> columnHeaders = GetColumnHeaders();

            if (columnHeaders != null && columnHeaders.Count != 0)
            {
                DataTable dataSource = InitReportDataSource(columnHeaders);
                RP089 form = new RP089();
                if (form != null)
                {
                    BandedGridView bandedGridView = InitBandedGridView(form.GridViewMain, columnHeaders);
                    form.BandedGridView = bandedGridView;
                    form.DataSource = dataSource;
                    form.Module = this.Module;
                    form.FormHeader = ReportLocalizedResources.EquipmentAllocation;
                    form.FormTitle = ReportLocalizedResources.EquipmentAllocationSheet;
                    StringBuilder sb = new StringBuilder();
                    if (columnHeaders.Count > 1)
                    {
                        sb.Append(ReportLocalizedResources.From).Append(" ");
                        sb.Append(columnHeaders[0]).Append(" ");
                        sb.Append(ReportLocalizedResources.To).Append(" ");
                        sb.Append(columnHeaders[columnHeaders.Count - 1]);
                        form.SubTitle = sb.ToString();
                    }
                    else
                    {
                        sb.Append(ReportLocalizedResources.Month).Append(" ");
                        sb.Append(columnHeaders[0]);
                        form.SubTitle = sb.ToString();
                    }
                    form.Show();
                }
            }
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
            XRLabel branchAddressLine3 = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
            if (branchAddressLine3 != null)
                branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
            XRLabel branchPhone = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
            if (branchPhone != null)
                branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
            XRLabel branchFax = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
            if (branchFax != null)
                branchFax.Text = objBranchsInfo.BRBranchContactFax;
            XRLabel dateTime = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
            dateTime.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteFromDate.Text, ReportLocalizedResources.ToDateTitle, fld_dteToDate.Text);

            // List<HRDepartmentRoomsInfo> selectedRooms = RoomList.Where(r => r.Selected == true).ToList();
            // ICProductsController objProductsController = new ICProductsController();
            //<ICProductsInfo> equipments = objProductsController.GetAllEquipments();
            List<ICProductsInfo> selectedEquipments = equipments.Where(r => r.Selected == true).ToList();
            List<ICShipmentItemsInfo> entries = new List<ICShipmentItemsInfo>();
            foreach (ICProductsInfo equipment in selectedEquipments)
            {
                List<ICShipmentItemsInfo> equipmentEntries = GetEquipmentHistory(equipment, fromDate, toDate);
                entries = entries.Concat(equipmentEntries).ToList();
            }

            report.DataSource = entries;
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
        private List<ICShipmentItemsInfo> GetEquipmentHistory(ICProductsInfo equipment, DateTime fromDate, DateTime toDate)
        {
            //Add equipment increasing and decreasing items
            List<ICShipmentItemsInfo> history = new List<ICShipmentItemsInfo>();
            ICShipmentItemsController objShipmentItemsController = new ICShipmentItemsController();
            List<ICShipmentItemsInfo> shipmentItems = objShipmentItemsController.GetItemsByEquipmentID(equipment.ICProductID, null, null);
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            List<ACDocumentEntrysInfo> documentEntryList = null;
            ACAccountsController objAccountsController = new ACAccountsController();
            ACAccountsInfo objAccountsInfo = null;
            foreach (ICShipmentItemsInfo item in shipmentItems)
            {
                if (item.ICShipmentType == ShipmentType.EquipmentShipment.ToString() || item.ICShipmentType == ShipmentType.EquipmentIncreasing.ToString())
                {
                    item.ICShipmentItemProductName = string.Format("{0} / {1}", equipment.ICProductName, item.ICShipmentItemProductSerialNo);
                    history.Add(item);
                }
            }

            foreach (ICShipmentItemsInfo objShipmentItemsInfo in history)
            {
                documentEntryList = objDocumentEntrysController.GetDepreciationEntriesByShipmentItemID(objShipmentItemsInfo.Id, null, toDate);
                objShipmentItemsInfo.EquipmentOpenDepreciatedAmount = 0;
                objShipmentItemsInfo.EquipmentTransactionDepreciatedAmount = 0;
                objShipmentItemsInfo.EquipmentEndRemainedAmount = 0;
                objShipmentItemsInfo.EquipmentDepreciatedTotalAmount = 0;
                if (documentEntryList != null && documentEntryList.Count > 0)
                {
                    foreach (ACDocumentEntrysInfo objDocumentEntrysInfo in documentEntryList)
                    {
                        if (objDocumentEntrysInfo.ACDocumentDate.Date <= fromDate)
                        {
                            objShipmentItemsInfo.EquipmentOpenDepreciatedAmount += objDocumentEntrysInfo.ACDocumentEntryExchangeAmount;
                        }
                        else if (objDocumentEntrysInfo.ACDocumentDate.Date >= fromDate && objDocumentEntrysInfo.ACDocumentDate.Date <= toDate)
                        {
                            objShipmentItemsInfo.EquipmentTransactionDepreciatedAmount += objDocumentEntrysInfo.ACDocumentEntryExchangeAmount;
                        }
                        objShipmentItemsInfo.EquipmentDepreciatedTotalAmount += objDocumentEntrysInfo.ACDocumentEntryExchangeAmount;
                    }
                    objShipmentItemsInfo.EquipmentOpenRemainedAmount = objShipmentItemsInfo.ICShipmentItemTotalAmount - objShipmentItemsInfo.EquipmentOpenDepreciatedAmount;
                    objShipmentItemsInfo.EquipmentEndRemainedAmount = objShipmentItemsInfo.EquipmentOpenRemainedAmount - objShipmentItemsInfo.EquipmentTransactionDepreciatedAmount;
                }
                //copy value
                objShipmentItemsInfo.ICProductNo = equipment.ICProductNo;
                objShipmentItemsInfo.ICProductName = equipment.ICProductName;
                objShipmentItemsInfo.ICMeasureUnitName = equipment.ICMeasureUnitName;
                objShipmentItemsInfo.ICProductModelNo = equipment.ICProductModelNo;
                objShipmentItemsInfo.ICProductDepreciationMonths = equipment.ICProductDepreciationMonths;
                objAccountsInfo = objAccountsController.GetAccountByID(objShipmentItemsInfo.FK_ACDepreciationCostAccountID);
                if (objAccountsInfo != null)
                {
                    objShipmentItemsInfo.EquipmentACAccountNo = objAccountsInfo.ACAccountNo;
                }
            }
            history = (from i in history
                       orderby i.FK_ICProductID, i.ICShipmentDate
                       select i).ToList();
            return history;
        }

        private void fld_chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            equipments.ForEach(r => r.Selected = fld_chkSelectAll.Checked);
            fld_dgEquipmentGridControl.RefreshDataSource();
        }


        #region NewRegion
        private List<string> GetColumnHeaders()
        {
            List<string> columnHeaders = new List<string>();
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            List<DateTime> dates = Enumerable.Range(0, (toDate.Year - fromDate.Year) * 12 + (toDate.Month - fromDate.Month + 1))
                     .Select(m => new DateTime(fromDate.Year, fromDate.Month, 1).AddMonths(m)).ToList();

            foreach (DateTime date in dates)
            {
                string columnHeader = date.Month.ToString() + "-" + date.Year.ToString();
                columnHeaders.Add(columnHeader);
            }
            return columnHeaders;
        }

        private DataTable CreateDataTable(List<string> columnHeaders)
        {
            //create new datatable
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ICProductNo", typeof(string)));
            dt.Columns.Add(new DataColumn("ICProductName", typeof(string)));
            dt.Columns.Add(new DataColumn("ICProductSerieNo", typeof(string)));
            dt.Columns.Add(new DataColumn("EquipmentUnitPrice", typeof(decimal)));
            dt.Columns.Add(new DataColumn("ICEquipmentVoucherNo", typeof(string)));
            dt.Columns.Add(new DataColumn("EquipmentOpenRemainedAmount", typeof(decimal)));

            foreach (string columnHeader in columnHeaders)
            {
                dt.Columns.Add(new DataColumn(columnHeader + "Qty", typeof(decimal)));
                dt.Columns.Add(new DataColumn(columnHeader + "Amount", typeof(decimal)));
            }
            dt.Columns.Add(new DataColumn("EquipmentTransactionDepreciatedAmount", typeof(decimal)));
            dt.Columns.Add(new DataColumn("EquipmentEndRemainedAmount", typeof(decimal)));

            return dt;
        }

        public DataTable InitReportDataSource(List<string> columnHeaders)
        {
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int roomID = Convert.ToInt32(fld_lkeHRDepartmentRoomID.EditValue);

            List<ICProductsInfo> selectedEquipments = equipments.Where(a => a.Selected == true).ToList();

            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            ACAccountsController objAccountsController = new ACAccountsController();

            decimal openRemainedAmount = 0;
            decimal openDepreciatedAmount = 0;
            decimal transactionDepreciatedAmount = 0;
            decimal endRemainedAmount = 0;
            decimal transactionDepreciatedQty = 0;
            decimal equipmentUnitPrice = 0;
            string monthYear = string.Empty;
            int referenceID = 0;
            SortedList<string, List<ACDocumentEntrysInfo>> collection = new SortedList<string, List<ACDocumentEntrysInfo>>();
            string key = string.Empty;
            SortedList<string, ACDocumentEntrysInfo> depreciationAmounts = new SortedList<string, ACDocumentEntrysInfo>();

            //string assetType = Convert.ToString(fld_lkeAssetType.EditValue);

            DataTable dt = CreateDataTable(columnHeaders);

            foreach (ICProductsInfo equipment in selectedEquipments)
            {
                List<ACDocumentEntrysInfo> depreciationEntries = objDocumentEntrysController.GetDepreciationEntriesByEquipmentID(equipment.ICProductID, 0, 0, fromDate, toDate);
                if (depreciationEntries != null && depreciationEntries.Count != 0)
                {
                    collection.Clear();
                    depreciationAmounts.Clear();

                    foreach (ACDocumentEntrysInfo documentEntry in depreciationEntries)
                    {
                        key = documentEntry.ICProductSerieNo + ";" + documentEntry.ICEquipmentVoucherNo;
                        if (!collection.ContainsKey(key))
                        {
                            List<ACDocumentEntrysInfo> values = new List<ACDocumentEntrysInfo>();
                            if (documentEntry.ICEquipmentShipmentItemID != 0)
                                GetEquipmentDepreciationEntries(depreciationEntries, ref values, documentEntry.ICEquipmentShipmentItemID, documentEntry.ACDocumentDate);
                            else if (documentEntry.ACEquipmentTransferItemID != 0)
                                GetEquipmentDepreciationEntries(depreciationEntries, ref values, documentEntry.ACEquipmentTransferItemID, documentEntry.ACDocumentDate);
                            collection.Add(key, values);
                            collection[key].Insert(0, documentEntry);
                        }
                        else
                            collection[key].Add(documentEntry);
                    }


                    foreach (string itemKey in collection.Keys)
                    {
                        openDepreciatedAmount = 0;
                        openRemainedAmount = 0;
                        transactionDepreciatedAmount = 0;
                        endRemainedAmount = 0;
                        monthYear = string.Empty;
                        referenceID = 0;
                        if (collection[itemKey][0] != null)
                        {
                            if (collection[itemKey][0].ICEquipmentShipmentItemID != 0)
                                referenceID = collection[itemKey][0].ICEquipmentShipmentItemID;
                            else if (collection[itemKey][0].ACEquipmentTransferItemID != 0)
                                referenceID = collection[itemKey][0].ACEquipmentTransferItemID;
                        }
                        foreach (ACDocumentEntrysInfo objDocumentEntrysInfo in collection[itemKey])
                        {
                            if (monthYear != (objDocumentEntrysInfo.ACDocumentDate.Month + "-" + objDocumentEntrysInfo.ACDocumentDate.Year))
                            {
                                if (objDocumentEntrysInfo.ACDocumentDate.Date < fromDate.Date)
                                {
                                    openDepreciatedAmount += (objDocumentEntrysInfo.ICEquipmentDepreciatedQty != 0) ? (objDocumentEntrysInfo.ACDocumentEntryExchangeAmount / objDocumentEntrysInfo.ICEquipmentDepreciatedQty) : 0;
                                }
                                else if (objDocumentEntrysInfo.ACDocumentDate.Date >= fromDate.Date && objDocumentEntrysInfo.ACDocumentDate.Date <= toDate.Date)
                                {
                                    if ((roomID == 0 || objDocumentEntrysInfo.HRDepartmentRoomID == roomID) &&
                                        (branchID == 0 || objDocumentEntrysInfo.FK_BRCostedBranchID == branchID))
                                    {
                                        if (itemKey.Contains(objDocumentEntrysInfo.ICEquipmentVoucherNo))
                                            transactionDepreciatedAmount += (objDocumentEntrysInfo.ICEquipmentDepreciatedQty != 0) ? (objDocumentEntrysInfo.ACDocumentEntryExchangeAmount / objDocumentEntrysInfo.ICEquipmentDepreciatedQty) : 0;
                                        else if (objDocumentEntrysInfo.ReferedItemID == referenceID)
                                            openDepreciatedAmount += objDocumentEntrysInfo.ICEquipmentDepreciatedQty != 0 ? (objDocumentEntrysInfo.ACDocumentEntryExchangeAmount / objDocumentEntrysInfo.ICEquipmentDepreciatedQty) : 0;
                                    }
                                    else
                                    {
                                        if (objDocumentEntrysInfo.ReferedItemID == referenceID)
                                            openDepreciatedAmount += objDocumentEntrysInfo.ICEquipmentDepreciatedQty != 0 ? (objDocumentEntrysInfo.ACDocumentEntryExchangeAmount / objDocumentEntrysInfo.ICEquipmentDepreciatedQty) : 0;
                                    }
                                }
                                equipmentUnitPrice = objDocumentEntrysInfo.ICProductUnitPrice;
                                monthYear = objDocumentEntrysInfo.ACDocumentDate.Month + "-" + objDocumentEntrysInfo.ACDocumentDate.Year;
                            }
                        }

                        openRemainedAmount = equipmentUnitPrice - openDepreciatedAmount;
                        endRemainedAmount = openRemainedAmount - transactionDepreciatedAmount;
                        if (openRemainedAmount != 0)
                        {
                            DataRow newRow = dt.NewRow();

                            newRow["ICProductNo"] = equipment.ICProductNo;
                            newRow["ICProductName"] = equipment.ICProductName;
                            newRow["ICProductSerieNo"] = itemKey.Split(';')[0];
                            newRow["ICEquipmentVoucherNo"] = itemKey.Split(';')[1];
                            newRow["EquipmentUnitPrice"] = equipmentUnitPrice;
                            newRow["EquipmentOpenRemainedAmount"] = openRemainedAmount;
                            newRow["EquipmentTransactionDepreciatedAmount"] = transactionDepreciatedAmount;
                            newRow["EquipmentEndRemainedAmount"] = endRemainedAmount;

                            depreciationAmounts.Clear();
                            foreach (string columnHeader in columnHeaders)
                            {
                                transactionDepreciatedAmount = 0;
                                transactionDepreciatedQty = 0;
                                foreach (ACDocumentEntrysInfo documentEntry in collection[itemKey])
                                {
                                    if ((documentEntry.ACDocumentDate.Month + "-" + documentEntry.ACDocumentDate.Year) == columnHeader &&
                                     (roomID == 0 || documentEntry.HRDepartmentRoomID == roomID) &&
                                     (branchID == 0 || documentEntry.FK_BRCostedBranchID == branchID) &&
                                     itemKey.Contains(documentEntry.ICEquipmentVoucherNo))
                                    {
                                        transactionDepreciatedAmount += documentEntry.ACDocumentEntryExchangeAmount;
                                        transactionDepreciatedQty += documentEntry.ICEquipmentDepreciatedQty;
                                    }

                                }
                                depreciationAmounts.Add(columnHeader,
                                    new ACDocumentEntrysInfo()
                                    {
                                        ICEquipmentDepreciatedQty = transactionDepreciatedQty,
                                        ICEquipmentDepreciatedAmount = transactionDepreciatedAmount
                                    });
                            }

                            //set values for dynamic columns
                            foreach (string columnHeader in depreciationAmounts.Keys)
                            {
                                newRow[columnHeader + "Qty"] = depreciationAmounts[columnHeader].ICEquipmentDepreciatedQty;
                                newRow[columnHeader + "Amount"] = depreciationAmounts[columnHeader].ICEquipmentDepreciatedAmount;
                            }

                            dt.Rows.Add(newRow);
                        }
                    }
                }
            }

            return dt;
        }

        /// <summary>
        /// Create Banded Grid View
        /// </summary>
        /// <param name="gridView">GridView</param>
        /// <returns></returns>
        public BandedGridView InitBandedGridView(DevExpress.XtraGrid.Views.Grid.GridView gridView, List<string> columnHeaders)
        {
            BandedGridView bandedView = new BandedGridView();
            bandedView.GridControl = gridView.GridControl;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;

            GridBand[] gridBands = new GridBand[3];

            GridBand itemGridBand = new GridBand();
            itemGridBand.Caption = ReportLocalizedResources.Equipment;
            itemGridBand.Name = "";
            itemGridBand.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

            BandedGridColumn groupColumn = new BandedGridColumn();
            groupColumn.Name = "ICProductNo";
            groupColumn.Caption = ReportLocalizedResources.EquipmentNo;
            groupColumn.FieldName = "ICProductNo";
            groupColumn.Visible = true;
            groupColumn.OptionsColumn.AllowEdit = false;
            groupColumn.OwnerBand = itemGridBand;
            groupColumn.Width = 80;
            groupColumn.OptionsColumn.AllowGroup = DefaultBoolean.True;
            bandedView.Columns.Add(groupColumn);

            BandedGridColumn bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = "ICProductName";
            bandedUserGroupSectionColumn.Caption = ReportLocalizedResources.EquipmentName;
            bandedUserGroupSectionColumn.FieldName = "ICProductName";
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.OwnerBand = itemGridBand;
            bandedUserGroupSectionColumn.Width = 200;
            bandedView.Columns.Add(bandedUserGroupSectionColumn);

            bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = "ICProductSerieNo";
            bandedUserGroupSectionColumn.Caption = ReportLocalizedResources.SerieNo;
            bandedUserGroupSectionColumn.FieldName = "ICProductSerieNo";
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.OwnerBand = itemGridBand;
            bandedUserGroupSectionColumn.Width = 80;
            bandedView.Columns.Add(bandedUserGroupSectionColumn);

            bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = "EquipmentUnitPrice";
            bandedUserGroupSectionColumn.Caption = ReportLocalizedResources.UnitPrice;
            bandedUserGroupSectionColumn.FieldName = "EquipmentUnitPrice";
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            bandedUserGroupSectionColumn.DisplayFormat.FormatString = "n0";
            bandedUserGroupSectionColumn.OwnerBand = itemGridBand;
            bandedUserGroupSectionColumn.Width = 80;
            bandedView.Columns.Add(bandedUserGroupSectionColumn);

            bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = "ICEquipmentVoucherNo";
            bandedUserGroupSectionColumn.Caption = ReportLocalizedResources.VoucherNo;
            bandedUserGroupSectionColumn.FieldName = "ICEquipmentVoucherNo";
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.OwnerBand = itemGridBand;
            bandedUserGroupSectionColumn.Width = 80;
            bandedView.Columns.Add(bandedUserGroupSectionColumn);

            bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = "EquipmentOpenRemainedAmount";
            bandedUserGroupSectionColumn.Caption = ReportLocalizedResources.OpenRemainedAmount;
            bandedUserGroupSectionColumn.FieldName = "EquipmentOpenRemainedAmount";
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            bandedUserGroupSectionColumn.DisplayFormat.FormatString = "n0";
            bandedUserGroupSectionColumn.OwnerBand = itemGridBand;
            bandedUserGroupSectionColumn.Width = 80;
            bandedView.Columns.Add(bandedUserGroupSectionColumn);

            //itemGridBand.Children.Add(subItemGridBand);
            itemGridBand.Fixed = FixedStyle.Left;
            gridBands[0] = itemGridBand;

            GridBand itemGridBand1 = new GridBand();
            itemGridBand1.Caption = ReportLocalizedResources.Allocation;
            itemGridBand1.Name = "Band1";
            itemGridBand1.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            GridBand subItemGridBand;
            BandedGridColumn bandedColumn2;
            foreach (string columnHeader in columnHeaders)
            {
                subItemGridBand = new GridBand();
                subItemGridBand.Caption = columnHeader;
                subItemGridBand.Name = columnHeader;
                subItemGridBand.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

                bandedColumn2 = new BandedGridColumn();
                bandedColumn2.Name = columnHeader + "Qty";
                bandedColumn2.Caption = ReportLocalizedResources.Quantity;
                bandedColumn2.FieldName = columnHeader + "Qty";
                bandedColumn2.Visible = true;
                bandedColumn2.OptionsColumn.AllowEdit = false;
                bandedColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                bandedColumn2.DisplayFormat.FormatString = "n0";
                bandedColumn2.OwnerBand = subItemGridBand;
                bandedUserGroupSectionColumn.Width = 100;
                bandedView.Columns.Add(bandedColumn2);

                bandedColumn2 = new BandedGridColumn();
                bandedColumn2.Name = columnHeader + "Amount";
                bandedColumn2.Caption = ReportLocalizedResources.Amount;
                bandedColumn2.FieldName = columnHeader + "Amount";
                bandedColumn2.Visible = true;
                bandedColumn2.OptionsColumn.AllowEdit = false;
                bandedColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                bandedColumn2.DisplayFormat.FormatString = "n0";
                bandedColumn2.OwnerBand = subItemGridBand;
                bandedUserGroupSectionColumn.Width = 100;
                bandedView.Columns.Add(bandedColumn2);

                itemGridBand1.Children.Add(subItemGridBand);

            }

            gridBands[1] = itemGridBand1;

            GridBand itemGridBand2 = new GridBand();
            itemGridBand2.Caption = "";
            itemGridBand2.Name = "";
            itemGridBand2.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

            BandedGridColumn AssetTransactionDepreciatedAmountColumn = new BandedGridColumn();
            AssetTransactionDepreciatedAmountColumn.Name = "EquipmentTransactionDepreciatedAmount";
            AssetTransactionDepreciatedAmountColumn.Caption = ReportLocalizedResources.TransactionDepreciatedAmount;
            AssetTransactionDepreciatedAmountColumn.FieldName = "EquipmentTransactionDepreciatedAmount";
            AssetTransactionDepreciatedAmountColumn.Visible = true;
            AssetTransactionDepreciatedAmountColumn.OptionsColumn.AllowEdit = false;
            AssetTransactionDepreciatedAmountColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            AssetTransactionDepreciatedAmountColumn.DisplayFormat.FormatString = "n0";
            AssetTransactionDepreciatedAmountColumn.OwnerBand = itemGridBand2;
            bandedUserGroupSectionColumn.Width = 100;
            bandedView.Columns.Add(AssetTransactionDepreciatedAmountColumn);

            BandedGridColumn AssetEndRemainedAmountColumn = new BandedGridColumn();

            AssetEndRemainedAmountColumn.Name = "EquipmentEndRemainedAmount";
            AssetEndRemainedAmountColumn.Caption = ReportLocalizedResources.EndRemainedAmount;
            AssetEndRemainedAmountColumn.FieldName = "EquipmentEndRemainedAmount";
            AssetEndRemainedAmountColumn.Visible = true;
            AssetEndRemainedAmountColumn.OptionsColumn.AllowEdit = false;
            AssetEndRemainedAmountColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            AssetEndRemainedAmountColumn.DisplayFormat.FormatString = "n0";
            AssetEndRemainedAmountColumn.OwnerBand = itemGridBand2;
            AssetEndRemainedAmountColumn.Width = 100;
            bandedView.Columns.Add(AssetEndRemainedAmountColumn);


            itemGridBand2.Fixed = FixedStyle.Right;
            gridBands[2] = itemGridBand2;

            bandedView.Bands.AddRange(gridBands);
            bandedView.BeginSort();
            try
            {
                bandedView.ClearGrouping();
                groupColumn.GroupIndex = 0;
            }
            finally
            {
                bandedView.EndSort();
            }

            return bandedView;
        }


        private void GetEquipmentsBySomeCriteria()
        {
            ACAssetsController objAssetsController = new ACAssetsController();
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int roomID = Convert.ToInt32(fld_lkeHRDepartmentRoomID.EditValue);
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;

            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByBranchID(branchID);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END

            if (fromDate != DateTime.MinValue && toDate != DateTime.MinValue)
            {
                ICProductsController objProductsController = new ICProductsController();
                //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
                equipments = new List<ICProductsInfo>();
                foreach (BRBranchsInfo branch in selectedBranches)
                {
                    List<ICProductsInfo> result = objProductsController.GetEquipmentsBySomeCriteria(branch.BRBranchID, roomID, fld_dteFromDate.DateTime, fld_dteToDate.DateTime);
                    equipments.AddRange(result);
                }
                //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
                equipments = objProductsController.GetEquipmentsBySomeCriteria(branchID, roomID, fld_dteFromDate.DateTime, fld_dteToDate.DateTime);
                fld_dgEquipmentGridControl.DataSource = equipments;
            }
        }

        #endregion NewRegion

        private void fld_dteFromDate_EditValueChanged(object sender, EventArgs e)
        {
            GetEquipmentsBySomeCriteria();
        }

        private void fld_dteToDate_EditValueChanged(object sender, EventArgs e)
        {
            GetEquipmentsBySomeCriteria();
        }

        private void fld_lkeBRBranchID_EditValueChanged(object sender, EventArgs e)
        {
            GetEquipmentsBySomeCriteria();
        }

        private void fld_lkeHRDepartmentRoomID_EditValueChanged(object sender, EventArgs e)
        {
            GetEquipmentsBySomeCriteria();
        }

        private void GetEquipmentDepreciationEntries(List<ACDocumentEntrysInfo> source, ref List<ACDocumentEntrysInfo> destination, int parentID, DateTime toDate)
        {
            if (source != null && destination != null)
            {
                var foundItems = source.Where(item => item.ReferedItemID == parentID && item.ACDocumentDate < toDate);
                if (foundItems != null && foundItems.Any())
                {
                    foreach (ACDocumentEntrysInfo documentEntry in foundItems)
                    {
                        destination.Add(documentEntry);
                        if (documentEntry.ICEquipmentShipmentItemID != 0)
                            GetEquipmentDepreciationEntries(source, ref destination, documentEntry.ICEquipmentShipmentItemID, documentEntry.ACDocumentDate);
                        else if (documentEntry.ACEquipmentTransferItemID != 0)
                            GetEquipmentDepreciationEntries(source, ref destination, documentEntry.ACEquipmentTransferItemID, documentEntry.ACDocumentDate);
                    }
                }
                else
                    return;
            }
        }

    }
}
