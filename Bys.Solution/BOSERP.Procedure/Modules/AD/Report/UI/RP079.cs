using BOSLib;
using DevExpress.Data;
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
    public partial class RP079 : ReportForm
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
        private List<ACAssetsInfo> AssetList;
        ///// <summary>
        ///// A variable to store the room list for selecting
        ///// </summary>
        //private List<HRDepartmentRoomsInfo> RoomList;
        public RP079()
        {
            InitializeComponent();
        }

        private void RP063_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteToDate.DateTime = BOSUtil.GetMonthEndDate();
            fld_dteFromDate.DateTime = BOSUtil.GetMonthBeginDate();

            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //ACAssetsController objAssetsController = new ACAssetsController();
            //AssetList = objAssetsController.GetAllAssets();
            //fld_dgcRP063Assets.DataSource = AssetList;
            Reloadassets();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END

            //HRDepartmentRoomsController objDepartmentRoomsController = new HRDepartmentRoomsController();
            //RoomList = objDepartmentRoomsController.GetAllRooms();
            //fld_dgcRP064DepartmentRooms.DataSource = RoomList;
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
                    form.FormHeader = ReportLocalizedResources.AssetDepreciation;
                    form.FormTitle = ReportLocalizedResources.AssetDepreciationSheet;
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
            List<ACAssetsInfo> selectedAssets = AssetList.Where(a => a.Selected == true).ToList();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            ACAccountsController objAccountsController = new ACAccountsController();
            ACAccountsInfo objAccountsInfo = null;
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            BRBranchsInfo selectedBranch = null;
            if (branchID > 0)
            {
                selectedBranch = (BRBranchsInfo)objBranchsController.GetObjectByID(branchID);
            }
            if (selectedBranch == null)
            {
                selectedBranch = new BRBranchsInfo();
            }
            string assetType = Convert.ToString(fld_lkeAssetType.EditValue);

            //List<HRDepartmentRoomsInfo> selectedRooms = RoomList.Where(r => r.Selected == true).ToList();
            //List<ACAssetsInfo> selectedAssetsByDepartmentRooms = new List<ACAssetsInfo>();
            //foreach (ACAssetsInfo asset in selectedAssets)
            //{
            //    foreach (HRDepartmentRoomsInfo item in selectedRooms)
            //    {
            //        if (asset.FK_HRDepartmentRoomID == item.HRDepartmentRoomID)
            //        {
            //            selectedAssetsByDepartmentRooms.Add(asset);
            //        }
            //    }
            //}
            foreach (ACAssetsInfo asset in selectedAssets)
            {

                List<ACDocumentEntrysInfo> depreciationEntries = objDocumentEntrysController.GetDepreciationEntriesByAssetID(asset.ACAssetID, null, toDate);
                asset.AssetOpenRemainedAmount = 0;
                asset.AssetEndRemainedAmount = 0;
                asset.ACAssetDepreciatedQty = 0;
                foreach (ACDocumentEntrysInfo objDocumentEntrysInfo in depreciationEntries)
                {
                    if (objDocumentEntrysInfo.ACDocumentDate.Date < fromDate.Date)
                    {
                        asset.AssetOpenDepreciatedAmount += objDocumentEntrysInfo.ACDocumentEntryExchangeAmount;
                    }
                    else if (objDocumentEntrysInfo.ACDocumentDate.Date >= fromDate.Date && objDocumentEntrysInfo.ACDocumentDate.Date <= toDate.Date)
                    {
                        asset.AssetTransactionDepreciatedAmount += objDocumentEntrysInfo.ACDocumentEntryExchangeAmount;
                    }
                    if (asset.ACAssetDepreciatedQty < 1)
                    {
                        asset.ACAssetDepreciatedQty = objDocumentEntrysInfo.ACAssetDepreciatedQty;
                    }
                }
                objAccountsInfo = (ACAccountsInfo)objAccountsController.GetObjectByID(asset.FK_ACDepreciationCostAccountID);
                if (objAccountsInfo != null)
                {
                    asset.ACAccountNo = objAccountsInfo.ACAccountNo;
                }
                if (asset.ACAssetDepreciatedQty < 1)
                    asset.ACAssetDepreciatedQty = 1;
                asset.AssetOpenRemainedAmount = asset.ACAssetDepreciatedQty * asset.ACAssetOriginalAmount - asset.AssetOpenDepreciatedAmount;
                asset.AssetEndRemainedAmount = asset.AssetOpenRemainedAmount - asset.AssetTransactionDepreciatedAmount;
            }
            report.DataSource = selectedAssets;
        }

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
            dt.Columns.Add(new DataColumn("ACAssetNo", typeof(string)));
            dt.Columns.Add(new DataColumn("ACAssetName", typeof(string)));
            dt.Columns.Add(new DataColumn("ACAssetModelNo", typeof(string)));
            dt.Columns.Add(new DataColumn("ACAssetAccountNo", typeof(string)));
            dt.Columns.Add(new DataColumn("ACAssetUsedDate", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("ACAssetExpiryMonths", typeof(int)));
            dt.Columns.Add(new DataColumn("ACAssetOriginalAmount", typeof(decimal)));
            dt.Columns.Add(new DataColumn("AssetOpenRemainedAmount", typeof(decimal)));


            foreach (string columnHeader in columnHeaders)
            {
                dt.Columns.Add(new DataColumn(columnHeader, typeof(decimal)));
            }

            dt.Columns.Add(new DataColumn("AssetTransactionDepreciatedAmount", typeof(decimal)));
            dt.Columns.Add(new DataColumn("AssetEndRemainedAmount", typeof(decimal)));

            return dt;
        }

        public DataTable InitReportDataSource(List<string> columnHeaders)
        {
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int roomID = Convert.ToInt32(fld_lkeHRDepartmentRoomID.EditValue);
            List<ACAssetsInfo> selectedAssets = AssetList.Where(a => a.Selected == true).ToList();

            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            ACAccountsController objAccountsController = new ACAccountsController();

            string assetType = Convert.ToString(fld_lkeAssetType.EditValue);

            DataTable dt = CreateDataTable(columnHeaders);

            foreach (ACAssetsInfo asset in selectedAssets)
            {
                List<ACDocumentEntrysInfo> depreciationEntries = objDocumentEntrysController.GetDepreciationEntriesByAssetID(asset.ACAssetID, null, toDate);
                if (depreciationEntries != null && depreciationEntries.Count != 0)
                {
                    asset.AssetOpenRemainedAmount = 0;
                    asset.AssetEndRemainedAmount = 0;
                    asset.ACAssetDepreciatedQty = 0;
                    asset.AssetOpenDepreciatedAmount = 0;
                    asset.AssetTransactionDepreciatedAmount = 0;

                    foreach (ACDocumentEntrysInfo objDocumentEntrysInfo in depreciationEntries)
                    {
                        if (objDocumentEntrysInfo.ACDocumentDate.Date < fromDate.Date)
                        {
                            asset.AssetOpenDepreciatedAmount += objDocumentEntrysInfo.ACDocumentEntryExchangeAmount;
                        }
                        else if (objDocumentEntrysInfo.ACDocumentDate.Date >= fromDate.Date && objDocumentEntrysInfo.ACDocumentDate.Date <= toDate.Date)
                        {
                            if ((roomID == 0 || objDocumentEntrysInfo.HRDepartmentRoomID == roomID) &&
                                (branchID == 0 || objDocumentEntrysInfo.FK_BRCostedBranchID == branchID))
                                asset.AssetTransactionDepreciatedAmount += objDocumentEntrysInfo.ACDocumentEntryExchangeAmount;
                            else
                            {
                                if (asset.AssetTransactionDepreciatedAmount == 0)
                                    asset.AssetOpenDepreciatedAmount += objDocumentEntrysInfo.ACDocumentEntryExchangeAmount;
                            }
                        }
                        if (asset.ACAssetDepreciatedQty < 1)
                        {
                            asset.ACAssetDepreciatedQty = objDocumentEntrysInfo.ACAssetDepreciatedQty;
                        }
                    }
                    if (asset.ACAssetDepreciatedQty < 1)
                        asset.ACAssetDepreciatedQty = 1;
                    asset.AssetOpenRemainedAmount = asset.ACAssetDepreciatedQty * asset.ACAssetOriginalAmount - asset.ACAssetInitDepreciatedAmount - asset.AssetOpenDepreciatedAmount;
                    asset.AssetEndRemainedAmount = asset.AssetOpenRemainedAmount - asset.AssetTransactionDepreciatedAmount;

                    if (asset.AssetOpenRemainedAmount != 0)
                    {
                        DataRow newRow = dt.NewRow();

                        newRow["ACAssetNo"] = asset.ACAssetNo;
                        newRow["ACAssetName"] = asset.ACAssetName;
                        newRow["ACAssetModelNo"] = asset.ACAssetModelNo;
                        newRow["ACAssetAccountNo"] = depreciationEntries[0].ACAssetAccountNo;
                        newRow["ACAssetUsedDate"] = asset.ACAssetUsedDate;
                        newRow["ACAssetExpiryMonths"] = asset.ACAssetExpiryMonths;
                        newRow["ACAssetOriginalAmount"] = asset.ACAssetOriginalAmount;
                        newRow["AssetOpenRemainedAmount"] = asset.AssetOpenRemainedAmount;
                        newRow["AssetTransactionDepreciatedAmount"] = asset.AssetTransactionDepreciatedAmount;
                        newRow["AssetEndRemainedAmount"] = asset.AssetEndRemainedAmount;

                        ACDocumentEntrysInfo newObject = depreciationEntries[0].Clone() as ACDocumentEntrysInfo;
                        decimal transactionDepreciatedAmountForEachMonth = 0;
                        SortedList<string, decimal> depreciationAmounts = new SortedList<string, decimal>();

                        foreach (string columnHeader in columnHeaders)
                        {
                            transactionDepreciatedAmountForEachMonth = 0;
                            foreach (ACDocumentEntrysInfo documentEntry in depreciationEntries)
                            {
                                if ((documentEntry.ACDocumentDate.Month + "-" + documentEntry.ACDocumentDate.Year) == columnHeader &&
                                    (roomID == 0 || documentEntry.HRDepartmentRoomID == roomID) &&
                                    (branchID == 0 || documentEntry.FK_BRCostedBranchID == branchID))
                                    transactionDepreciatedAmountForEachMonth += documentEntry.ACDocumentEntryExchangeAmount;

                            }
                            depreciationAmounts.Add(columnHeader, transactionDepreciatedAmountForEachMonth);
                        }

                        //set values to dynamic columns
                        foreach (string columnHeader in depreciationAmounts.Keys)
                        {
                            newRow[columnHeader] = depreciationAmounts[columnHeader];
                        }

                        dt.Rows.Add(newRow);
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
            bandedView.OptionsView.ShowFooter = true;

            GridBand[] gridBands = new GridBand[3];

            GridBand itemGridBand = new GridBand();
            itemGridBand.Caption = ReportLocalizedResources.Asset;
            itemGridBand.Name = "";
            itemGridBand.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

            BandedGridColumn bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = "ACAssetNo";
            bandedUserGroupSectionColumn.Caption = ReportLocalizedResources.AssetNo;
            bandedUserGroupSectionColumn.FieldName = "ACAssetNo";
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.OwnerBand = itemGridBand;
            bandedUserGroupSectionColumn.Width = 80;
            bandedView.Columns.Add(bandedUserGroupSectionColumn);

            bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = "ACAssetName";
            bandedUserGroupSectionColumn.Caption = ReportLocalizedResources.AssetName;
            bandedUserGroupSectionColumn.FieldName = "ACAssetName";
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.OwnerBand = itemGridBand;
            bandedUserGroupSectionColumn.Width = 150;
            bandedView.Columns.Add(bandedUserGroupSectionColumn);

            bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = "ACAssetModelNo";
            bandedUserGroupSectionColumn.Caption = ReportLocalizedResources.ModelNo;
            bandedUserGroupSectionColumn.FieldName = "ACAssetModelNo";
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.OwnerBand = itemGridBand;
            bandedUserGroupSectionColumn.Width = 80;
            bandedView.Columns.Add(bandedUserGroupSectionColumn);

            bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = "ACAssetAccountNo";
            bandedUserGroupSectionColumn.Caption = ReportLocalizedResources.AccountNo;
            bandedUserGroupSectionColumn.FieldName = "ACAssetAccountNo";
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.OwnerBand = itemGridBand;
            bandedUserGroupSectionColumn.Width = 80;
            bandedView.Columns.Add(bandedUserGroupSectionColumn);

            bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = "ACAssetUsedDate";
            bandedUserGroupSectionColumn.Caption = ReportLocalizedResources.UsedDate;
            bandedUserGroupSectionColumn.FieldName = "ACAssetUsedDate";
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.OwnerBand = itemGridBand;
            bandedUserGroupSectionColumn.Width = 80;
            bandedView.Columns.Add(bandedUserGroupSectionColumn);

            bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = "ACAssetExpiryMonths";
            bandedUserGroupSectionColumn.Caption = ReportLocalizedResources.ExpiryMonth;
            bandedUserGroupSectionColumn.FieldName = "ACAssetExpiryMonths";
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.OwnerBand = itemGridBand;
            bandedUserGroupSectionColumn.Width = 80;
            bandedView.Columns.Add(bandedUserGroupSectionColumn);

            bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = "ACAssetOriginalAmount";
            bandedUserGroupSectionColumn.Caption = ReportLocalizedResources.OriginalAmount;
            bandedUserGroupSectionColumn.FieldName = "ACAssetOriginalAmount";
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            bandedUserGroupSectionColumn.DisplayFormat.FormatString = "n2";
            bandedUserGroupSectionColumn.OwnerBand = itemGridBand;
            bandedUserGroupSectionColumn.Width = 80;
            InitColumnSummary(bandedUserGroupSectionColumn, "ACAssetOriginalAmount", SummaryItemType.Sum);
            bandedView.Columns.Add(bandedUserGroupSectionColumn);

            bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = "AssetOpenRemainedAmount";
            bandedUserGroupSectionColumn.Caption = ReportLocalizedResources.OpenRemainedAmount;
            bandedUserGroupSectionColumn.FieldName = "AssetOpenRemainedAmount";
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            bandedUserGroupSectionColumn.DisplayFormat.FormatString = "n2";
            bandedUserGroupSectionColumn.OwnerBand = itemGridBand;
            bandedUserGroupSectionColumn.Width = 80;
            InitColumnSummary(bandedUserGroupSectionColumn, "AssetOpenRemainedAmount", SummaryItemType.Sum);
            bandedView.Columns.Add(bandedUserGroupSectionColumn);

            //itemGridBand.Children.Add(subItemGridBand);
            itemGridBand.Fixed = FixedStyle.Left;
            gridBands[0] = itemGridBand;

            GridBand itemGridBand1 = new GridBand();
            itemGridBand1.Caption = ReportLocalizedResources.Depreciation;
            itemGridBand1.Name = "Band1";
            itemGridBand1.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            BandedGridColumn bandedColumn2;
            foreach (string columnHeader in columnHeaders)
            {
                bandedColumn2 = new BandedGridColumn();
                bandedColumn2.Name = columnHeader;
                bandedColumn2.Caption = columnHeader;
                bandedColumn2.FieldName = columnHeader;
                bandedColumn2.Visible = true;
                bandedColumn2.OptionsColumn.AllowEdit = false;
                bandedColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                bandedColumn2.DisplayFormat.FormatString = "n2";
                bandedColumn2.OwnerBand = itemGridBand1;
                bandedUserGroupSectionColumn.Width = 80;

                //InitColumnSummary
                InitColumnSummary(bandedColumn2, columnHeader, SummaryItemType.Sum);

                bandedView.Columns.Add(bandedColumn2);

            }

            gridBands[1] = itemGridBand1;

            GridBand itemGridBand2 = new GridBand();
            itemGridBand2.Caption = "";
            itemGridBand2.Name = "";
            itemGridBand2.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

            BandedGridColumn AssetTransactionDepreciatedAmountColumn = new BandedGridColumn();
            AssetTransactionDepreciatedAmountColumn.Name = "AssetTransactionDepreciatedAmount";
            AssetTransactionDepreciatedAmountColumn.Caption = ReportLocalizedResources.TransactionDepreciatedAmount;
            AssetTransactionDepreciatedAmountColumn.FieldName = "AssetTransactionDepreciatedAmount";
            AssetTransactionDepreciatedAmountColumn.Visible = true;
            AssetTransactionDepreciatedAmountColumn.OptionsColumn.AllowEdit = false;
            AssetTransactionDepreciatedAmountColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            AssetTransactionDepreciatedAmountColumn.DisplayFormat.FormatString = "n2";
            AssetTransactionDepreciatedAmountColumn.OwnerBand = itemGridBand2;
            bandedUserGroupSectionColumn.Width = 100;
            InitColumnSummary(AssetTransactionDepreciatedAmountColumn, "AssetTransactionDepreciatedAmount", SummaryItemType.Sum);
            bandedView.Columns.Add(AssetTransactionDepreciatedAmountColumn);

            BandedGridColumn AssetEndRemainedAmountColumn = new BandedGridColumn();

            AssetEndRemainedAmountColumn.Name = "AssetEndRemainedAmount";
            AssetEndRemainedAmountColumn.Caption = ReportLocalizedResources.EndRemainedAmount;
            AssetEndRemainedAmountColumn.FieldName = "AssetEndRemainedAmount";
            AssetEndRemainedAmountColumn.Visible = true;
            AssetEndRemainedAmountColumn.OptionsColumn.AllowEdit = false;
            AssetEndRemainedAmountColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            AssetEndRemainedAmountColumn.DisplayFormat.FormatString = "n2";
            AssetEndRemainedAmountColumn.OwnerBand = itemGridBand2;
            AssetEndRemainedAmountColumn.Width = 80;
            InitColumnSummary(AssetEndRemainedAmountColumn, "AssetEndRemainedAmount", SummaryItemType.Sum);
            bandedView.Columns.Add(AssetEndRemainedAmountColumn);
            itemGridBand2.Fixed = FixedStyle.Right;
            gridBands[2] = itemGridBand2;

            bandedView.Bands.AddRange(gridBands);

            return bandedView;
        }

        private void fld_chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            AssetList.ForEach(r => r.Selected = fld_chkSelectAll.Checked);
            fld_dgcRP063Assets.RefreshDataSource();
        }

        private void fld_lkeAssetType_EditValueChanged(object sender, EventArgs e)
        {
            Reloadassets();
        }

        private void fld_lkeBRBranchID_EditValueChanged(object sender, EventArgs e)
        {
            Reloadassets();
        }

        private void fld_lkeHRDepartmentRoomID_EditValueChanged(object sender, EventArgs e)
        {
            Reloadassets();
        }

        private void fld_dteFromDate_EditValueChanged(object sender, EventArgs e)
        {
            Reloadassets();
        }

        private void fld_dteToDate_EditValueChanged(object sender, EventArgs e)
        {
            Reloadassets();
        }

        private void Reloadassets()
        {
            ACAssetsController objAssetsController = new ACAssetsController();
            string assetType = Convert.ToString(fld_lkeAssetType.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByBranchID(branchID);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            int roomID = Convert.ToInt32(fld_lkeHRDepartmentRoomID.EditValue);
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            if (fromDate != DateTime.MinValue && toDate != DateTime.MinValue)
            {
                //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                AssetList = new List<ACAssetsInfo>();
                foreach (BRBranchsInfo branch in selectedBranches)
                {
                    List<ACAssetsInfo> list = objAssetsController.GetAssetsBySomeCriteria(fromDate, toDate, assetType, branch.BRBranchID, roomID);
                    AssetList.AddRange(list);
                }
                //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
                fld_dgcRP063Assets.DataSource = AssetList;
            }
        }

        private void InitColumnSummary(GridColumn column, string fieldName, SummaryItemType summaryType)
        {
            if (column != null)
            {
                column.SummaryItem.FieldName = fieldName;
                column.SummaryItem.SummaryType = summaryType;
                column.SummaryItem.DisplayFormat = "{0:n2}";
            }
        }
    }
}
