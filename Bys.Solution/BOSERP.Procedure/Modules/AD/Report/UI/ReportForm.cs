using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class ReportForm : BOSERPScreen
    {
        #region Variable
        protected int ContentStartYIndex;
        protected int ContentRowIndex;
        protected List<string> VisibleColumns;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets summary row index
        /// </summary>
        public int SummaryRowIndex { get; set; }
        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
        public List<BRBranchsInfo> BranchList { get; set; }
        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END

        #endregion

        public ReportForm()
        {
            InitializeComponent();
            ContentStartYIndex = 1;
            base.Load += new EventHandler(ReportForm_Load);
        }

        void ReportForm_Load(object sender, EventArgs e)
        {
            ControlBox = true;
            MaximizeBox = true;
            MinimizeBox = true;
        }
        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateBranchLookupControlDatasourceByUserPermission(this.Controls);

        }

        protected void UpdateBranchLookupControlDatasourceByUserPermission(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is IBOSControl && ctrl.Name.Contains("BranchID"))
                {
                    List<BRBranchsInfo> branches = new List<BRBranchsInfo>();
                    if (BranchList != null && BranchList.Count != 0)
                    {
                        branches.Add(new BRBranchsInfo());
                        branches.AddRange(BranchList);
                    }
                    ((BOSLookupEdit)ctrl).Properties.DataSource = branches;
                    return;
                }
                UpdateBranchLookupControlDatasourceByUserPermission(ctrl.Controls);
            }
        }

        public void GetBranchListByUserPermission()
        {
            BRBranchsController branchController = new BRBranchsController();
            BranchList = branchController.GetAllBranchesByUserPermission(BOSApp.CurrentUsersInfo.ADUserID,
                                                                                            this.Name, ADDataViewPermissionType.Report);
            if (BranchList == null)
            {
                BranchList = new List<BRBranchsInfo>();
            }
        }

        public List<BRBranchsInfo> GetBranchsByLocation(int locationID)
        {
            List<BRBranchsInfo> result = new List<BRBranchsInfo>();

            if (BranchList != null)
            {
                List<GELocationsInfo> collection = new List<GELocationsInfo>();
                GetLocationsByLocationParentID(collection, locationID);
                result = BranchList.Where(item => item.FK_GELocationID == locationID ||
                                            collection.Any(location => location.GELocationID == item.FK_GELocationID)).ToList();

            }

            return result;
        }

        public string GetListOfBranchNosFromBranchList(List<BRBranchsInfo> branchList)
        {
            string branchNos = string.Empty;
            if (branchList != null)
            {
                foreach (BRBranchsInfo branch in branchList)
                {
                    if (!string.IsNullOrEmpty(branchNos))
                        branchNos += ", ";
                    branchNos += branch.BRBranchNo;
                }
            }
            return branchNos;
        }

        public List<BRBranchsInfo> GetSelectedBranchesByBranchID(int branchID)
        {
            List<BRBranchsInfo> selectedBranches;
            if (branchID != 0)
            {
                selectedBranches = new List<BRBranchsInfo>();
                BRBranchsInfo branch = BranchList.FirstOrDefault(item => item.BRBranchID == branchID);
                if (branch != null)
                {
                    selectedBranches.Add(branch);
                }
            }
            else
            {
                selectedBranches = BranchList;
            }
            return selectedBranches;
        }


        public List<BRBranchsInfo> GetSelectedBranchesByLocationIDAndBranchID(int locationID, int branchID)
        {
            List<BRBranchsInfo> selectedBranches;
            if (branchID != 0)
            {
                selectedBranches = new List<BRBranchsInfo>();
                BRBranchsInfo branch = BranchList.FirstOrDefault(item => item.BRBranchID == branchID);
                if (branch != null)
                {
                    selectedBranches.Add(branch);
                }
            }
            else
            {
                if (locationID != 0)
                {
                    selectedBranches = GetBranchsByLocation(locationID);
                }
                else
                    selectedBranches = BranchList;
            }
            return selectedBranches;
        }

        public string GetSelectedBranchNosByBranchID(int branchID)
        {
            string selectedBranchNos = string.Empty;
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByBranchID(branchID);
            if (selectedBranches != null)
            {
                foreach (BRBranchsInfo branch in selectedBranches)
                {
                    if (!string.IsNullOrEmpty(selectedBranchNos))
                        selectedBranchNos += ", ";
                    selectedBranchNos += branch.BRBranchNo;
                }
            }
            return selectedBranchNos;
        }


        public string GetSelectedBranchNosByLocationIDAndBranchID(int locationID, int branchID)
        {
            string selectedBranchNos = string.Empty;
            List<BRBranchsInfo> selectedBranches = GetSelectedBranchesByLocationIDAndBranchID(locationID, branchID);
            if (selectedBranches != null)
            {
                foreach (BRBranchsInfo branch in selectedBranches)
                {
                    if (!string.IsNullOrEmpty(selectedBranchNos))
                        selectedBranchNos += ", ";
                    selectedBranchNos += branch.BRBranchNo;
                }
            }
            return selectedBranchNos;
        }

        private void GetLocationsByLocationParentID(List<GELocationsInfo> collection, int locationParentID)
        {
            if (collection != null)
            {
                GELocationsController locationController = new GELocationsController();
                DataSet ds = locationController.GetAllObjectsByObjectParentID(locationParentID);
                if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                    return;

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    GELocationsInfo location = locationController.GetObjectFromDataRow(row) as GELocationsInfo;
                    collection.Add(location);
                    GetLocationsByLocationParentID(collection, location.GELocationID);
                }

            }
        }
        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END

        /// <summary>
        /// Set content row index
        /// </summary>
        /// <returns>Rown index</returns>
        protected virtual int SetContentRowIndex()
        {
            return 0;
        }

        protected virtual List<ExportExcelParameter> GetReportHeader()
        {
            return new List<ExportExcelParameter>();
        }

        protected virtual List<ExportExcelParameter> GetReportContent(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            DataTable table = GetDefaultTableFromGridView(gridView);

            for (int i = 0; i < gridView.RowCount; i++)
            {
                DataRow row = table.NewRow();
                bool acceptNewRow = false;
                for (int j = 0; j < VisibleColumns.Count; j++)
                {
                    String value = gridView.GetRowCellDisplayText(i, gridView.Columns[table.Columns[j].ColumnName]);
                    if (!string.IsNullOrEmpty(value))
                    {
                        if (table.Columns[j].DataType == typeof(double))
                            row[j] = double.Parse(value);
                        else if (table.Columns[j].DataType == typeof(float))
                            row[j] = float.Parse(value);
                        else
                            row[j] = value;
                        acceptNewRow = true;
                    }
                }
                if (acceptNewRow)
                {
                    table.Rows.Add(row);
                }
            }
            SummaryRowIndex = table.Rows.Count + ContentRowIndex + 1;
            List<ExportExcelParameter> lstContentParameter = new List<ExportExcelParameter>();
            lstContentParameter.Add(new ExportExcelParameter(ContentRowIndex, ContentStartYIndex, table));

            return lstContentParameter;
        }

        protected virtual List<ExportExcelParameter> GetReportSummary(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            List<ExportExcelParameter> lstParameter = new List<ExportExcelParameter>();
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView.Columns)
            {
                if (column.SummaryItem.SummaryValue != null)
                {
                    if (column.SummaryItem.SummaryType != DevExpress.Data.SummaryItemType.None)
                    {
                        object summaryValue = null;

                        if (column.SummaryItem.DisplayFormat.Equals("{0:n2}"))
                            summaryValue = double.Parse(column.SummaryItem.SummaryValue.ToString());
                        else if (column.SummaryItem.DisplayFormat.Equals("{0:n0}"))
                            summaryValue = float.Parse(column.SummaryItem.SummaryValue.ToString());
                        else if (column.ColumnType == typeof(double))
                            summaryValue = double.Parse(column.SummaryItem.SummaryValue.ToString());
                        else
                            summaryValue = column.SummaryItem.SummaryValue;
                        lstParameter.Add(SetDefaultSummaryParameter(summaryValue, SummaryRowIndex, ContentStartYIndex + column.VisibleIndex));
                    }
                }
            }
            return lstParameter;
        }

        protected virtual List<ExportExcelParameter> GetReportFooter()
        {
            return new List<ExportExcelParameter>();
        }

        protected virtual void ExportToExcel(GridView gridView)
        {
            List<ExportExcelParameter> lstParameter = new List<ExportExcelParameter>();
            lstParameter.AddRange(GetReportHeader().ToArray());
            ContentRowIndex = lstParameter.Count + 2 + SetContentRowIndex();
            lstParameter.AddRange(GetReportContent(gridView).ToArray());
            lstParameter.AddRange(GetReportSummary(gridView).ToArray());
            lstParameter.AddRange(GetReportFooter().ToArray());
            ExcelExporter.ExportToExcel(lstParameter);
        }

        /// <summary>
        /// Export a grid to an excel file used the built-in function of the grid
        /// </summary>
        /// <param name="gridView">Given grid view</param>
        public virtual void ExportToXls(GridView gridView)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = App.ExcelDialogFilter;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    gridView.ExportToXls(sfd.FileName);
                    Process.Start(sfd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message,
                                CommonLocalizedResources.MessageBoxDefaultCaption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        #region Set default display
        public ExportExcelParameter SetDefaultHeaderParameter(String headerText, int posX, int posY)
        {
            return new ExportExcelParameter(posX, posY, headerText, Color.FromArgb(20, 120, 190), Color.Empty, new Font("Calibri", 16, FontStyle.Bold));
        }

        public ExportExcelParameter SetDefaultSubHeaderParameter(String headerText, int posX, int posY)
        {
            return new ExportExcelParameter(posX, posY, headerText, Color.FromArgb(20, 120, 190), Color.Empty, new Font("Calibri", 13, FontStyle.Bold));
        }

        public ExportExcelParameter SetDefaultTableNameParameter(String headerText, int posX, int posY)
        {
            return new ExportExcelParameter(posX, posY, headerText, Color.FromArgb(20, 120, 190), Color.Empty, new Font("Calibri", 13, FontStyle.Bold));
        }

        public ExportExcelParameter SetDefaultSubTableNameParameter(String headerText, int posX, int posY)
        {
            return new ExportExcelParameter(posX, posY, headerText, Color.FromArgb(20, 120, 190), Color.Empty, new Font("Calibri", 12, FontStyle.Bold));
        }

        public ExportExcelParameter SetDefaultSummaryParameter(object value, int posX, int posY)
        {
            return new ExportExcelParameter(posX, posY, value, Color.Black, Color.LightGray, new Font("Calibri", 11, FontStyle.Bold));
        }
        #endregion

        /// <summary>
        /// Create a data table with all columns which are format datatype and sort by visible index (have not data) 
        /// </summary>
        /// <param name="gridView"></param>
        /// <returns></returns>
        protected DataTable GetDefaultTableFromGridView(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            DataTable table = new DataTable();
            VisibleColumns = new List<string>();
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                if (gridView.Columns[i].VisibleIndex >= 0)
                {
                    VisibleColumns.Add(gridView.Columns[i].FieldName);
                    DataColumn col = new DataColumn();
                    table.Columns.Add(col);
                }
            }
            for (int i = 0; i < VisibleColumns.Count; i++)
            {
                table.Columns[gridView.Columns[VisibleColumns[i]].VisibleIndex].Caption = gridView.Columns[VisibleColumns[i]].Caption;
                table.Columns[gridView.Columns[VisibleColumns[i]].VisibleIndex].ColumnName = gridView.Columns[VisibleColumns[i]].FieldName;
                table.Columns[gridView.Columns[VisibleColumns[i]].VisibleIndex].DefaultValue = (gridView.Columns[VisibleColumns[i]].Width / 8).ToString();

                STFieldFormatGroupsController objFieldFormatGroupsController = new STFieldFormatGroupsController();
                BOSComponent.BOSGridControl gridControl = (BOSComponent.BOSGridControl)gridView.GridControl;
                //STFieldFormatGroupsInfo objFieldFormatGroupsInfo = objFieldFormatGroupsController.GetFieldFormatGroupByTableNameAndColumnName(gridControl.BOSDataSource, gridView.Columns[VisibleColumns[i]].FieldName);
                STFieldFormatGroupsInfo objFieldFormatGroupsInfo = BOSApp.FieldFormatList.Where(f => f.TableName == gridControl.BOSDataSource
                                                                                            && f.ColumnName == gridView.Columns[VisibleColumns[i]].FieldName).FirstOrDefault();
                if (objFieldFormatGroupsInfo != null)
                {
                    if (objFieldFormatGroupsInfo.STFieldFormatGroupMaskType.Equals("Numeric"))
                    {
                        switch (objFieldFormatGroupsInfo.STFieldFormatGroupMaskEdit)
                        {
                            case "n":
                                table.Columns[gridView.Columns[VisibleColumns[i]].VisibleIndex].DataType = typeof(double);
                                break;
                            case "n0":
                                table.Columns[gridView.Columns[VisibleColumns[i]].VisibleIndex].DataType = typeof(float);
                                break;
                        }
                    }
                }
                else
                {
                    if (gridView.Columns[VisibleColumns[i]].DisplayFormat.FormatType == DevExpress.Utils.FormatType.Numeric)
                    {
                        switch (gridView.Columns[VisibleColumns[i]].DisplayFormat.FormatString)
                        {
                            case "{0:n2}":
                                table.Columns[gridView.Columns[VisibleColumns[i]].VisibleIndex].DataType = typeof(double);
                                break;
                            case "{0:n0}":
                                table.Columns[gridView.Columns[VisibleColumns[i]].VisibleIndex].DataType = typeof(float);
                                break;
                        }
                    }
                }
            }
            return table;
        }

        protected void SetDefaultCurrentBranchAndTitle(XtraReport report, int branchID)
        {
            CSCompanysController objCompanysController = new CSCompanysController();
            CSCompanysInfo objCompanyInfo = (CSCompanysInfo)objCompanysController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);

            if (objCompanyInfo != null)
            {

                XRTableCell tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrThue"].Controls["xr_tbcThue"];
                if (tablecell != null)
                {
                    tablecell.Text += objCompanyInfo.CSCompanyTaxNumber;
                }
                tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrdchd"].Controls["xrtbcdiachihoadon"];
                if (tablecell != null)
                {
                    tablecell.Text += objCompanyInfo.CSCompanyAddressLine1;
                }
                tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrAddress"].Controls["xrtbcdiachinhamay"];
                if (tablecell != null)
                {
                    tablecell.Text += objCompanyInfo.CSCompanyAddressLine2;
                }

                tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrWeb"].Controls["xr_tbcWebsite"];
                if (tablecell != null)
                {
                    tablecell.Text += objCompanyInfo.CSCompanyWebsite;
                }

                tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrEmail"].Controls["xr_tbcEmail"];
                if (tablecell != null)
                {
                    tablecell.Text += objCompanyInfo.CSCompanyEmail;
                }
                tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrCellphone"].Controls["xr_tbcCellphone"];
                if (tablecell != null)
                {
                    tablecell.Text = objCompanyInfo.CSCompanyCellPhone;
                }

                tablecell = (XRTableCell)report.Bands[BandKind.ReportHeader].Controls["xrTbcompany"].Controls["xrtbrCompanyphone"].Controls["xr_tbcCompanyphone"];
                if (tablecell != null)
                {
                    tablecell.Text += objCompanyInfo.CSCompanyPhone;
                }
            }
        }
    }
}