using BOSLib;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP090 : ReportForm
    {
        /// <summary>
        /// A variable to store the asset list for selecting
        /// </summary>
        private List<ACCostObjectsInfo> CostObjectList;
        ///// <summary>
        ///// A variable to store the room list for selecting
        ///// </summary>
        //private List<HRDepartmentRoomsInfo> RoomList;
        public RP090()
        {
            InitializeComponent();
            CostObjectList = new List<ACCostObjectsInfo>();
        }

        private void RP063_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dteToDate.DateTime = BOSUtil.GetMonthEndDate();
            fld_dteFromDate.DateTime = BOSUtil.GetMonthBeginDate();

            ACCostObjectsController costObjectController = new ACCostObjectsController();

            DataSet ds = costObjectController.GetAllObjects();
            CostObjectList.Clear();

            if (ds != null && ds.Tables.Count != 0 && ds.Tables[0].Rows.Count != 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ACCostObjectsInfo costObject = costObjectController.GetObjectFromDataRow(row) as ACCostObjectsInfo;
                    //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
                    bool hasExist = BranchList.Exists(item => item.BRBranchID == costObject.FK_BRCostedBranchID);
                    if (hasExist)
                        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
                        CostObjectList.Add(costObject);
                }
            }
            fld_dgcACCostObjects.DataSource = CostObjectList;

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
            if (!CostObjectList.Exists(a => a.Selected == true))
            {
                MessageBox.Show(ReportLocalizedResources.ChooseCostObjectMessage, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    form.FormHeader = ReportLocalizedResources.CostAllocation;
                    form.FormTitle = ReportLocalizedResources.CostAllocationSheet;
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
            dt.Columns.Add(new DataColumn("ACCostObjectNo", typeof(string)));
            dt.Columns.Add(new DataColumn("ACCostObjectName", typeof(string)));
            dt.Columns.Add(new DataColumn("CostObjectAccountNo", typeof(string)));
            dt.Columns.Add(new DataColumn("ACCostObjectAllocationMonths", typeof(int)));
            dt.Columns.Add(new DataColumn("ACCostObjectStartDate", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("CostObjectOriginalAmount", typeof(decimal)));
            dt.Columns.Add(new DataColumn("CostObjectOpenRemainedAmount", typeof(decimal)));


            foreach (string columnHeader in columnHeaders)
            {
                dt.Columns.Add(new DataColumn(columnHeader, typeof(decimal)));
            }

            dt.Columns.Add(new DataColumn("CostObjectTransactionDepreciatedAmount", typeof(decimal)));
            dt.Columns.Add(new DataColumn("ACCostObjectEndDate", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("CostObjectEndRemainedAmount", typeof(decimal)));

            return dt;
        }

        public DataTable InitReportDataSource(List<string> columnHeaders)
        {
            DateTime fromDate = fld_dteFromDate.DateTime;
            DateTime toDate = fld_dteToDate.DateTime;
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            List<ACCostObjectsInfo> dataSource = fld_dgcACCostObjects.DataSource as List<ACCostObjectsInfo>;
            List<ACCostObjectsInfo> selectedCostObjects = dataSource.Where(a => a.Selected == true).ToList();

            BRBranchsController branchController = new BRBranchsController();
            ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
            ACAccountsController objAccountsController = new ACAccountsController();

            BRBranchsInfo centreBranch = branchController.GetCentre();
            BRBranchsInfo branch = branchController.GetObjectByID(branchID) as BRBranchsInfo;
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            if (branch == null)
                branch = new BRBranchsInfo();
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            List<ACDocumentEntrysInfo> depreciationEntries = null;
            List<ACDocumentEntrysInfo> result;

            DataTable dt = CreateDataTable(columnHeaders);

            foreach (ACCostObjectsInfo costObject in selectedCostObjects)
            {
                depreciationEntries = null;
                result = null;

                if (centreBranch != null)
                {
                    if (centreBranch.BRBranchID == branchID)
                    {
                        //get depreciation entries for a cost object from the current branch
                        result = objDocumentEntrysController.GetDepreciationEntriesByCostObjectID(costObject.ACCostObjectNo, branchID, null, toDate);
                    }
                    else
                    {
                        if (branchID != centreBranch.BRBranchID)
                        {
                            //get depreciation entries for a cost object from the centre branch
                            depreciationEntries = GetDepreciationEntriesByCostObjectIDAndBranchID(centreBranch.BRBranchID, branchID, costObject.ACCostObjectNo, toDate);

                            if (branch != null && branch.BRBranchParentID != centreBranch.BRBranchID)
                            {
                                //get depreciation entries for a cost object from its parent branch
                                result = GetDepreciationEntriesByCostObjectIDAndBranchID(branch.BRBranchParentID, branchID, costObject.ACCostObjectNo, toDate);
                                if (depreciationEntries == null)
                                    depreciationEntries = new List<ACDocumentEntrysInfo>();
                                MergeDocumentEntries(result, depreciationEntries);
                            }
                            //get depreciation entries for a cost object from its cost branch
                            result = GetDepreciationEntriesByCostObjectIDAndBranchID(branch.BRBranchID, branchID, costObject.ACCostObjectNo, toDate);
                        }
                    }
                }
                else
                {
                    //get depreciation entries for a cost object from the current branch
                    result = objDocumentEntrysController.GetDepreciationEntriesByCostObjectID(costObject.ACCostObjectNo, branchID, null, toDate);
                }
                if (depreciationEntries == null)
                    depreciationEntries = new List<ACDocumentEntrysInfo>();
                MergeDocumentEntries(result, depreciationEntries);


                if (depreciationEntries != null && depreciationEntries.Count != 0)
                {
                    decimal costObjOpenDepreciatedAmount = 0;
                    decimal costObjTransactionDepreciatedAmount = 0;
                    decimal costObjOpenRemainAmount = 0;
                    decimal costObjEndRemainAmount = 0;

                    foreach (ACDocumentEntrysInfo objDocumentEntrysInfo in depreciationEntries)
                    {
                        if (objDocumentEntrysInfo.ACDocumentDate.Date < fromDate.Date)
                        {
                            costObjOpenDepreciatedAmount += objDocumentEntrysInfo.ACDocumentEntryExchangeAmount;
                        }
                        else if (objDocumentEntrysInfo.ACDocumentDate.Date >= fromDate.Date && objDocumentEntrysInfo.ACDocumentDate.Date <= toDate.Date)
                        {
                            costObjTransactionDepreciatedAmount += objDocumentEntrysInfo.ACDocumentEntryExchangeAmount;
                        }
                    }

                    costObjOpenRemainAmount = depreciationEntries[0].CostObjectOriginalAmount - costObjOpenDepreciatedAmount;
                    costObjEndRemainAmount = costObjOpenRemainAmount - costObjTransactionDepreciatedAmount;
                    if (costObjOpenRemainAmount != 0)
                    {
                        DataRow newRow = dt.NewRow();

                        newRow["ACCostObjectNo"] = costObject.ACCostObjectNo;
                        newRow["ACCostObjectName"] = costObject.ACCostObjectName;
                        newRow["ACCostObjectStartDate"] = costObject.ACCostObjectStartDate;
                        newRow["ACCostObjectAllocationMonths"] = costObject.ACCostObjectAllocationMonths;

                        newRow["CostObjectAccountNo"] = depreciationEntries[0].CostObjectAccountNo;
                        newRow["CostObjectOriginalAmount"] = depreciationEntries[0].CostObjectOriginalAmount;
                        newRow["CostObjectOpenRemainedAmount"] = costObjOpenRemainAmount;
                        newRow["CostObjectTransactionDepreciatedAmount"] = costObjTransactionDepreciatedAmount;
                        newRow["ACCostObjectEndDate"] = costObject.ACCostObjectEndDate;
                        newRow["CostObjectEndRemainedAmount"] = costObjEndRemainAmount;

                        ACDocumentEntrysInfo newObject = depreciationEntries[0].Clone() as ACDocumentEntrysInfo;
                        decimal transactionDepreciatedAmount = 0;
                        SortedList<string, decimal> depreciationAmounts = new SortedList<string, decimal>();

                        foreach (string columnHeader in columnHeaders)
                        {
                            transactionDepreciatedAmount = 0;
                            foreach (ACDocumentEntrysInfo documentEntry in depreciationEntries)
                            {
                                if ((documentEntry.ACDocumentDate.Month + "-" + documentEntry.ACDocumentDate.Year) == columnHeader)
                                    transactionDepreciatedAmount += documentEntry.ACDocumentEntryExchangeAmount;

                            }
                            depreciationAmounts.Add(columnHeader, transactionDepreciatedAmount);
                        }

                        //set values for dynamic columns
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
            itemGridBand.Caption = ReportLocalizedResources.CostAllocation;
            itemGridBand.Name = "";
            itemGridBand.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

            BandedGridColumn bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = "ACCostObjectNo";
            bandedUserGroupSectionColumn.Caption = ReportLocalizedResources.CostObjectNo;
            bandedUserGroupSectionColumn.FieldName = "ACCostObjectNo";
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.OwnerBand = itemGridBand;
            bandedUserGroupSectionColumn.Width = 80;
            bandedView.Columns.Add(bandedUserGroupSectionColumn);

            bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = "ACCostObjectName";
            bandedUserGroupSectionColumn.Caption = ReportLocalizedResources.CostObjectName;
            bandedUserGroupSectionColumn.FieldName = "ACCostObjectName";
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.OwnerBand = itemGridBand;
            bandedUserGroupSectionColumn.Width = 150;
            bandedView.Columns.Add(bandedUserGroupSectionColumn);

            bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = "CostObjectAccountNo";
            bandedUserGroupSectionColumn.Caption = ReportLocalizedResources.AccountNo;
            bandedUserGroupSectionColumn.FieldName = "CostObjectAccountNo";
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.OwnerBand = itemGridBand;
            bandedUserGroupSectionColumn.Width = 80;
            bandedView.Columns.Add(bandedUserGroupSectionColumn);

            bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = "ACCostObjectStartDate";
            bandedUserGroupSectionColumn.Caption = ReportLocalizedResources.StartDate;
            bandedUserGroupSectionColumn.FieldName = "ACCostObjectStartDate";
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.OwnerBand = itemGridBand;
            bandedUserGroupSectionColumn.Width = 80;
            bandedView.Columns.Add(bandedUserGroupSectionColumn);



            bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = "ACCostObjectAllocationMonths";
            bandedUserGroupSectionColumn.Caption = ReportLocalizedResources.AllocationMonth;
            bandedUserGroupSectionColumn.FieldName = "ACCostObjectAllocationMonths";
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.OwnerBand = itemGridBand;
            bandedUserGroupSectionColumn.Width = 80;
            bandedView.Columns.Add(bandedUserGroupSectionColumn);

            bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = "CostObjectOriginalAmount";
            bandedUserGroupSectionColumn.Caption = ReportLocalizedResources.TotalAmount;
            bandedUserGroupSectionColumn.FieldName = "CostObjectOriginalAmount";
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            bandedUserGroupSectionColumn.DisplayFormat.FormatString = "n2";
            bandedUserGroupSectionColumn.OwnerBand = itemGridBand;
            bandedUserGroupSectionColumn.Width = 80;
            InitColumnSummary(bandedUserGroupSectionColumn, "CostObjectOriginalAmount", SummaryItemType.Sum);
            bandedView.Columns.Add(bandedUserGroupSectionColumn);

            bandedUserGroupSectionColumn = new BandedGridColumn();
            bandedUserGroupSectionColumn.Name = "CostObjectOpenRemainedAmount";
            bandedUserGroupSectionColumn.Caption = ReportLocalizedResources.OpenRemainedAmount;
            bandedUserGroupSectionColumn.FieldName = "CostObjectOpenRemainedAmount";
            bandedUserGroupSectionColumn.Visible = true;
            bandedUserGroupSectionColumn.OptionsColumn.AllowEdit = false;
            bandedUserGroupSectionColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            bandedUserGroupSectionColumn.DisplayFormat.FormatString = "n2";
            bandedUserGroupSectionColumn.OwnerBand = itemGridBand;
            bandedUserGroupSectionColumn.Width = 80;
            InitColumnSummary(bandedUserGroupSectionColumn, "CostObjectOpenRemainedAmount", SummaryItemType.Sum);
            bandedView.Columns.Add(bandedUserGroupSectionColumn);

            //itemGridBand.Children.Add(subItemGridBand);
            itemGridBand.Fixed = FixedStyle.Left;
            gridBands[0] = itemGridBand;

            GridBand itemGridBand1 = new GridBand();
            itemGridBand1.Caption = ReportLocalizedResources.AllocatedCost;
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
                bandedUserGroupSectionColumn.Width = 100;

                InitColumnSummary(bandedColumn2, columnHeader, SummaryItemType.Sum);
                bandedView.Columns.Add(bandedColumn2);


            }

            gridBands[1] = itemGridBand1;

            GridBand itemGridBand2 = new GridBand();
            itemGridBand2.Caption = "";
            itemGridBand2.Name = "";
            itemGridBand2.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

            BandedGridColumn AssetTransactionDepreciatedAmountColumn = new BandedGridColumn();
            AssetTransactionDepreciatedAmountColumn.Name = "CostObjectTransactionDepreciatedAmount";
            AssetTransactionDepreciatedAmountColumn.Caption = ReportLocalizedResources.TotalCost;
            AssetTransactionDepreciatedAmountColumn.FieldName = "CostObjectTransactionDepreciatedAmount";
            AssetTransactionDepreciatedAmountColumn.Visible = true;
            AssetTransactionDepreciatedAmountColumn.OptionsColumn.AllowEdit = false;
            AssetTransactionDepreciatedAmountColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            AssetTransactionDepreciatedAmountColumn.DisplayFormat.FormatString = "n2";
            AssetTransactionDepreciatedAmountColumn.OwnerBand = itemGridBand2;
            bandedUserGroupSectionColumn.Width = 80;
            InitColumnSummary(AssetTransactionDepreciatedAmountColumn, "CostObjectTransactionDepreciatedAmount", SummaryItemType.Sum);
            bandedView.Columns.Add(AssetTransactionDepreciatedAmountColumn);

            BandedGridColumn CostObjectEnddateColumn = new BandedGridColumn();
            CostObjectEnddateColumn.Name = "ACCostObjectEndDate";
            CostObjectEnddateColumn.Caption = ReportLocalizedResources.EndDate;
            CostObjectEnddateColumn.FieldName = "ACCostObjectEndDate";
            CostObjectEnddateColumn.Visible = true;
            CostObjectEnddateColumn.OptionsColumn.AllowEdit = false;
            CostObjectEnddateColumn.OwnerBand = itemGridBand2;
            CostObjectEnddateColumn.Width = 80;
            bandedView.Columns.Add(CostObjectEnddateColumn);

            BandedGridColumn AssetEndRemainedAmountColumn = new BandedGridColumn();

            AssetEndRemainedAmountColumn.Name = "CostObjectEndRemainedAmount";
            AssetEndRemainedAmountColumn.Caption = ReportLocalizedResources.EndRemainedAmount;
            AssetEndRemainedAmountColumn.FieldName = "CostObjectEndRemainedAmount";
            AssetEndRemainedAmountColumn.Visible = true;
            AssetEndRemainedAmountColumn.OptionsColumn.AllowEdit = false;
            AssetEndRemainedAmountColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            AssetEndRemainedAmountColumn.DisplayFormat.FormatString = "n2";
            AssetEndRemainedAmountColumn.OwnerBand = itemGridBand2;
            AssetEndRemainedAmountColumn.Width = 80;
            InitColumnSummary(AssetEndRemainedAmountColumn, "CostObjectEndRemainedAmount", SummaryItemType.Sum);
            bandedView.Columns.Add(AssetEndRemainedAmountColumn);
            itemGridBand2.Fixed = FixedStyle.Right;
            gridBands[2] = itemGridBand2;

            bandedView.Bands.AddRange(gridBands);

            return bandedView;
        }

        private void fld_chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            CostObjectList.ForEach(r => r.Selected = fld_chkSelectAll.Checked);
            fld_dgcACCostObjects.RefreshDataSource();
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

        private void Reloadassets()
        {
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            List<ACCostObjectsInfo> filterObjects = CostObjectList.Where(item => branchID == 0 || item.FK_BRCostedBranchID == branchID).ToList();
            fld_dgcACCostObjects.DataSource = filterObjects;
        }

        private List<ACDocumentEntrysInfo> GetDepreciationEntriesByCostObjectIDAndBranchID(int branchID, int costedBranchID, string costObjectNo, DateTime toDate)
        {
            List<ACDocumentEntrysInfo> depreciationEntries = null;
            try
            {
                BOSApp.SwitchConnection(branchID);
                if (BOSApp.TestCurrentConnection())
                {
                    ACDocumentEntrysController objDocumentEntrysController = new ACDocumentEntrysController();
                    depreciationEntries = objDocumentEntrysController.GetDepreciationEntriesByCostObjectID(costObjectNo, costedBranchID, null, toDate);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                BOSApp.RollbackLocalConnection();
            }
            return depreciationEntries;
        }

        private void MergeDocumentEntries(List<ACDocumentEntrysInfo> source, List<ACDocumentEntrysInfo> destination)
        {
            if (source != null && destination != null)
            {
                foreach (ACDocumentEntrysInfo docEntry in source)
                {
                    ACDocumentEntrysInfo foundItem = destination.FirstOrDefault(item => item.ACDocumentNo == docEntry.ACDocumentNo);
                    if (foundItem != null)
                        foundItem.CostObjectOriginalAmount = docEntry.CostObjectOriginalAmount;
                    else
                        destination.Add(docEntry);
                }
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
