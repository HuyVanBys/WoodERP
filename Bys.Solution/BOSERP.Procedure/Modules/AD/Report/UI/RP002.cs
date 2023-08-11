using BOSLib;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP002 : ReportForm
    {
        #region Variables
        private int ICProductGroupID = 0;

        /// <summary>
        /// Define location id
        /// </summary>
        private int LocationID = 0;

        /// <summary>
        /// A variable to store the report data source
        /// </summary>
        private DataTable ReportDataSource;
        #endregion

        public RP002()
        {
            InitializeComponent();
        }

        private void RP002_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dteSearchFromARInvoiceDate.DateTime = BOSUtil.GetMonthBeginDate().AddMonths(-2);
            fld_dteSearchToARInvoiceDate.DateTime = BOSUtil.GetMonthBeginDate();
            fld_lblBranchName.Text = string.Empty;
            //ShowReportData();
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
            this.Close();
        }

        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            if (fld_dteSearchFromARInvoiceDate.DateTime != DateTime.MaxValue && fld_dteSearchToARInvoiceDate.DateTime != DateTime.MaxValue)
            {
                ShowReportData();
            }
        }

        /// <summary>
        /// Show report data based on the report's parameters
        /// </summary>
        private void ShowReportData()
        {
            BOSProgressBar.Start(ReportLocalizedResources.LoadingData);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int locationID = LocationID;
            int deparmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            int productGroupID = ICProductGroupID;
            DateTime from = Convert.ToDateTime(fld_dteSearchFromARInvoiceDate.EditValue);
            DateTime to = Convert.ToDateTime(fld_dteSearchToARInvoiceDate.EditValue);
            List<ProductGroupFilter> productGroups = GetListProductGroupFilter();

            fld_dgcARRP002InvoiceItems.DataSource = productGroups;
            ReportDataSource = GetReportTable(productGroups, from, to);
            fld_dgcARRP002InvoiceItems.AddDataSource(ReportDataSource, from, to, fld_cmbTimeType.SelectedIndex);

            if (productGroups.Count <= 0)
                fld_btnPrint.Enabled = false;
            else
                fld_btnPrint.Enabled = true;
            fld_dgcARRP002InvoiceItems.RefreshDataSource();
            GridView gridView = (GridView)fld_dgcARRP002InvoiceItems.MainView;
            gridView.ExpandAllGroups();
            fld_lblBranchName.Text = string.Empty;
            BRBranchsController objBranchsController = new BRBranchsController();
            if (branchID > 0)
                fld_lblBranchName.Text = fld_lkeBRBranchID.Text;
            else
                fld_lblBranchName.Text = fld_bedGELocationName.Text;
            if (fld_cmbTimeType.SelectedIndex == 0)
            {
                fld_lbl_FromdateTodate.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromMonth, fld_dteSearchFromARInvoiceDate.Text,
                                                                                        ReportLocalizedResources.ToMonth, fld_dteSearchToARInvoiceDate.Text);
            }
            else if (fld_cmbTimeType.SelectedIndex == 1)
            {
                fld_lbl_FromdateTodate.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromYear, fld_dteSearchFromARInvoiceDate.Text,
                                                                                        ReportLocalizedResources.ToYear, fld_dteSearchToARInvoiceDate.Text);
            }
            BOSProgressBar.Close();
        }

        /// <summary>
        /// Get product group filter list
        /// </summary>
        /// <returns>The list of product group filter</returns>
        private List<ProductGroupFilter> GetListProductGroupFilter()
        {
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            int locationID = LocationID;
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
            string branchNos = GetSelectedBranchNosByLocationIDAndBranchID(locationID, branchID);
            //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            int deparmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            int productGroupID = ICProductGroupID;
            ADReportsController objReportsController = new ADReportsController();
            if (branchID > 0)
            {
                locationID = 0;
            }
            DateTime from = Convert.ToDateTime(fld_dteSearchFromARInvoiceDate.EditValue);
            DateTime to = Convert.ToDateTime(fld_dteSearchToARInvoiceDate.EditValue);

            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
            //[TKChinh] Fix Issue Get Leaf 
            List<ICProductGroupsInfo> productGroups = objProductGroupsController.GetLeafProductGroupList(deparmentID, productGroupID, 3);
            List<ProductGroupFilter> productGroupFilters = new List<ProductGroupFilter>();
            //Parallel.ForEach<ICProductGroupsInfo>(productGroups, (objProductGroupsInfo) =>
            foreach (ICProductGroupsInfo objProductGroupsInfo in productGroups)
            {
                ProductGroupFilter objProductGroupFilter = new ProductGroupFilter();
                objProductGroupFilter.ProductGroupName = objProductGroupsInfo.ICProductGroupName;
                objProductGroupFilter.ProductGroupParentName = objProductGroupsInfo.ICProductGroupParentName;
                objProductGroupFilter.ICDepartmentName = objProductGroupsInfo.ICDepartmentName;
                productGroupFilters.Add(objProductGroupFilter);

                DataTable dataTable = new DataTable();
                if (fld_cmbTimeType.SelectedIndex == 0)
                {
                    //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                    //dataTable = objReportsController.GetInvoiceItemsByMonthAndSomeCriteria(from, to, locationID, branchID, objProductGroupsInfo.ICProductGroupID);
                    dataTable = objReportsController.GetInvoiceItemsByMonthAndBranchNoListAndSomeCriteria(from, to, null, branchNos, objProductGroupsInfo.ICProductGroupID);
                    //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END

                }
                else
                {
                    //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
                    //dataTable = objReportsController.GetInvoiceItemsByYearAndSomeCriteria(from, to, locationID, branchID, objProductGroupsInfo.ICProductGroupID);
                    dataTable = objReportsController.GetInvoiceItemsByYearAndBranchNoListAndSomeCriteria(from, to, null, branchNos, objProductGroupsInfo.ICProductGroupID);
                    //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    ARInvoiceItemsInfo objInvoiceItemsInfo = (ARInvoiceItemsInfo)objInvoiceItemsController.GetObjectFromDataRow(row);
                    objProductGroupFilter.Details.Add(new DateTime(objInvoiceItemsInfo.ARInvoiceDate.Year, objInvoiceItemsInfo.ARInvoiceDate.Month, 1),
                                                    new ProductGroupInDateTime()
                                                    {
                                                        Quantity = objInvoiceItemsInfo.ARInvoiceItemProductQty,
                                                        Total = objInvoiceItemsInfo.ARInvoiceItemTotalAmount
                                                    });
                }
            }//);
            //foreach (ICProductGroupsInfo objProductGroupsInfo in productGroups)                
            //{
            //    ProductGroupFilter objProductGroupFilter = new ProductGroupFilter();
            //    objProductGroupFilter.ProductGroupName = objProductGroupsInfo.ICProductGroupName;
            //    objProductGroupFilter.ProductGroupParentName = objProductGroupsInfo.ICProductGroupParentName;
            //    objProductGroupFilter.ICDepartmentName = objProductGroupsInfo.ICDepartmentName;
            //    productGroupFilters.Add(objProductGroupFilter);

            //    DataTable dataTable = new DataTable();
            //    if (fld_cmbTimeType.SelectedIndex == 0)
            //    {
            //        dataTable = objReportsController.GetInvoiceItemsByMonthAndSomeCriteria(from, to, locationID, branchID, objProductGroupsInfo.ICProductGroupID);
            //    }
            //    else
            //    {
            //        dataTable = objReportsController.GetInvoiceItemsByYearAndSomeCriteria(from, to, locationID, branchID, objProductGroupsInfo.ICProductGroupID);
            //    }

            //    foreach (DataRow row in dataTable.Rows)
            //    {
            //        ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
            //        ARInvoiceItemsInfo objInvoiceItemsInfo = (ARInvoiceItemsInfo)objInvoiceItemsController.GetObjectFromDataRow(row);
            //        objProductGroupFilter.Details.Add(new DateTime(objInvoiceItemsInfo.ARInvoiceDate.Year, objInvoiceItemsInfo.ARInvoiceDate.Month, 1),
            //                                        new ProductGroupInDateTime()
            //                                        {
            //                                            Quantity = objInvoiceItemsInfo.ARInvoiceItemProductQty,
            //                                            Total = objInvoiceItemsInfo.ARInvoiceItemTotalAmount
            //                                        });
            //    }
            //}
            productGroupFilters = productGroupFilters.Where(o1 => o1.Details.Sum(o2 => o2.Value.Total) != 0).ToList();
            return productGroupFilters;
        }

        #region Initialize export excel parameter
        protected override List<ExportExcelParameter> GetReportHeader()
        {
            List<ExportExcelParameter> lstHeaderParameter = base.GetReportHeader();
            lstHeaderParameter.Add(SetDefaultHeaderParameter(fld_lblBranchName.Text, 1, 5));
            lstHeaderParameter.Add(SetDefaultSubHeaderParameter(fld_lblTitle.Text, 2, 5));
            return lstHeaderParameter;
        }
        #endregion

        /// <summary>
        /// Get report table
        /// </summary>
        /// <param name="productRows">List of product group filter</param>
        /// <param name="from">The invoice date from</param>
        /// <param name="to">The invoice date to</param>
        /// <returns>The data table</returns>
        public DataTable GetReportTable(List<ProductGroupFilter> productRows, DateTime from, DateTime to)
        {
            DataTable dataSource = new DataTable();
            DevExpress.XtraGrid.Columns.GridColumn col = new DevExpress.XtraGrid.Columns.GridColumn();
            DateTime index = new DateTime(from.Year, from.Month, 1);
            if (fld_cmbTimeType.SelectedIndex == 1)
            {
                index = new DateTime(from.Year, 1, 1);
            }
            dataSource.Columns.Add(new DataColumn("ICProductGroupName"));
            dataSource.Columns.Add(new DataColumn("ICProductGroupParentName"));
            dataSource.Columns.Add(new DataColumn("ICDepartmentName"));

            while (index <= to)
            {
                if (fld_cmbTimeType.SelectedIndex == 0)
                {
                    string quantityColumnName = "Quantity_" + index.ToString("MM/yyyy");
                    dataSource.Columns.Add(new DataColumn(quantityColumnName, typeof(decimal)));
                    string totalColumnName = "Total_" + index.ToString("MM/yyyy");
                    dataSource.Columns.Add(new DataColumn(totalColumnName, typeof(decimal)));
                    string percentColName = "Percent_" + index.ToString("MM/yyyy");
                    dataSource.Columns.Add(new DataColumn(percentColName));
                    index = index.AddMonths(1);
                }
                else
                {
                    string quantityColumnName = "Quantity_" + index.ToString("yyyy");
                    dataSource.Columns.Add(new DataColumn(quantityColumnName, typeof(decimal)));
                    string totalColumnName = "Total_" + index.ToString("yyyy");
                    dataSource.Columns.Add(new DataColumn(totalColumnName, typeof(decimal)));
                    string percentColName = "Percent_" + index.ToString("yyyy");
                    dataSource.Columns.Add(new DataColumn(percentColName));
                    index = index.AddYears(1);
                }
            }

            foreach (ProductGroupFilter item in productRows)
            {
                Dictionary<DateTime, decimal> percents = new Dictionary<DateTime, decimal>();
                index = new DateTime(from.Year, from.Month, 1);
                if (fld_cmbTimeType.SelectedIndex == 1)
                {
                    index = new DateTime(from.Year, 1, 1);
                }
                DataRow newRow = dataSource.NewRow();
                newRow["ICProductGroupName"] = item.ProductGroupName;
                newRow["ICProductGroupParentName"] = item.ProductGroupParentName;
                newRow["ICDepartmentName"] = item.ICDepartmentName;
                while (index <= to)
                {
                    if (fld_cmbTimeType.SelectedIndex == 0)
                    {
                        string quantityColumnName = "Quantity_" + index.ToString("MM/yyyy");
                        string totalColumnName = "Total_" + index.ToString("MM/yyyy");
                        string percentColName = "Percent_" + index.ToString("MM/yyyy");
                        decimal quantity = 0;
                        decimal total = 0;

                        ProductGroupInDateTime objProductGroupInMonth = null;
                        if (item.Details.TryGetValue(index, out objProductGroupInMonth))
                        {
                            quantity = objProductGroupInMonth.Quantity;
                            total = objProductGroupInMonth.Total;
                        }
                        decimal percent = 0;
                        if (index == from)
                        {
                            percents[index] = total;
                        }
                        else
                        {
                            DateTime preDate = index.AddMonths(-1);
                            if (percents.ContainsKey(preDate))
                            {
                                decimal preTotal = percents[preDate];
                                percents[index] = total;
                                if (preTotal == 0)
                                    percent = 0;
                                else
                                {
                                    percent = (total / preTotal) * 100 - 100;
                                    percent = Math.Round(percent, 2);
                                }
                            }
                        }
                        newRow[quantityColumnName] = quantity;
                        newRow[totalColumnName] = total;
                        if (percent >= 0)
                            newRow[percentColName] = string.Format("{0}{1}", percent, "%");
                        else
                            newRow[percentColName] = string.Format("{0}{1}{2}{3}", "(", Math.Abs(percent), ")", "%");
                        index = index.AddMonths(1);
                    }
                    else
                    {
                        string quantityColumnName = "Quantity_" + index.ToString("yyyy");
                        string totalColumnName = "Total_" + index.ToString("yyyy");
                        string percentColName = "Percent_" + index.ToString("yyyy");
                        decimal quantity = 0;
                        decimal total = 0;

                        ProductGroupInDateTime objProductGroupInDateTime = null;
                        if (item.Details.TryGetValue(index, out objProductGroupInDateTime))
                        {
                            quantity = objProductGroupInDateTime.Quantity;
                            total = objProductGroupInDateTime.Total;
                        }
                        decimal percent = 0;
                        if (index.Year == from.Year)
                        {
                            percents[index] = total;
                        }
                        else
                        {
                            DateTime preDate = index.AddYears(-1);
                            if (percents.ContainsKey(preDate))
                            {
                                decimal preTotal = percents[preDate];
                                percents[index] = total;
                                if (preTotal == 0)
                                    percent = 0;
                                else
                                {
                                    percent = (total / preTotal) * 100 - 100;
                                    percent = Math.Round(percent, 2);
                                }
                            }
                        }
                        newRow[quantityColumnName] = quantity;
                        newRow[totalColumnName] = total;
                        if (percent > 0)
                            newRow[percentColName] = string.Format("{0}{1}", percent, "%");
                        else
                            newRow[percentColName] = string.Format("{0}{1}{2}{3}", "(", Math.Abs(percent), ")", "%");
                        index = index.AddYears(1);
                    }
                }
                dataSource.Rows.Add(newRow);
            }
            return dataSource;
        }

        private void fld_btnPrint_Click(object sender, EventArgs e)
        {
            //rp.LoadLayout(BOSCommon.Constants.Report.DevInvoiceItem1ReportPath);                                  
            DateTime from = Convert.ToDateTime(fld_dteSearchFromARInvoiceDate.EditValue);
            DateTime to = Convert.ToDateTime(fld_dteSearchToARInvoiceDate.EditValue);
            if (from != DateTime.MaxValue && to != DateTime.MaxValue)
            {
                BOSReport.RP002 rp = new BOSReport.RP002(ReportDataSource, from, to, fld_cmbTimeType.SelectedIndex);
                BRBranchsController objBranchsController = new BRBranchsController();
                BRBranchsInfo objBranchsInfo = (BRBranchsInfo)objBranchsController.GetObjectByID(BOSApp.CurrentCompanyInfo.FK_BRBranchID);
                List<ICProductGroupsInfo> productGroupList = new List<ICProductGroupsInfo>();
                XRLabel branchAddressLine3 = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchAddressLine3"];
                if (branchAddressLine3 != null)
                    branchAddressLine3.Text = objBranchsInfo.BRBranchContactAddressLine3;
                XRLabel branchPhone = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchPhone"];
                if (branchPhone != null)
                    branchPhone.Text = objBranchsInfo.BRBranchContactPhone;
                XRLabel branchFax = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchFax"];
                if (branchFax != null)
                    branchFax.Text = objBranchsInfo.BRBranchContactFax;
                XRLabel title = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblBRBranchName"];
                if (title != null)
                {
                    title.Text += string.Format(" {0}", fld_lblBranchName.Text);
                }
                XRLabel dateTime = (XRLabel)rp.Bands[BandKind.ReportHeader].Controls["xr_lblFromdateTodate"];
                dateTime.Text = fld_lbl_FromdateTodate.Text;
                guiReportPreview reviewer = new guiReportPreview(rp, BOSCommon.Constants.Report.DevInvoiceItem1ReportPath, true);
                reviewer.Show();
            }
        }

        private void fld_bedFK_ICProductGroupID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            int productGroupID = objProductGroupsController.GetObjectIDByName(Convert.ToString(fld_bedFK_ICProductGroupID.EditValue));
            int departmentID = Convert.ToInt32(fld_lkeFK_ICDepartmentID.EditValue);
            guiProductGroupTree guiProductGroupTree = new guiProductGroupTree(departmentID, productGroupID);
            guiProductGroupTree.Module = this.Module;
            if (guiProductGroupTree.ShowDialog() == DialogResult.OK)
            {
                ICProductGroupsInfo objProductGroupInfo = (ICProductGroupsInfo)guiProductGroupTree.TreeList.GetSelectedObject();
                if (objProductGroupInfo != null)
                {
                    ICProductGroupID = objProductGroupInfo.ICProductGroupID;
                    fld_bedFK_ICProductGroupID.Text = guiProductGroupTree.GetSelectedProductGroupName();
                    fld_lkeFK_ICDepartmentID.EditValue = guiProductGroupTree.ICDepartmentID;
                }
                else
                {
                    ICProductGroupID = 0;
                    fld_bedFK_ICProductGroupID.Text = String.Empty;
                }
            }
        }

        private void fld_cmbTimeType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (fld_cmbTimeType.SelectedIndex == 0)
            {
                fld_lblFrom.Text = ReportLocalizedResources.FromMonth;
                fld_dteSearchFromARInvoiceDate.EditValue = BOSUtil.GetMonthBeginDate();
                fld_dteSearchToARInvoiceDate.EditValue = BOSUtil.GetMonthEndDate();

                fld_dteSearchFromARInvoiceDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
                fld_dteSearchFromARInvoiceDate.Properties.DisplayFormat.FormatString = "MM/yyyy";
                fld_dteSearchFromARInvoiceDate.Properties.EditFormat.FormatString = "MM/yyyy";
                fld_dteSearchFromARInvoiceDate.Properties.EditMask = "MM/yyyy";


                fld_dteSearchToARInvoiceDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
                fld_dteSearchToARInvoiceDate.Properties.DisplayFormat.FormatString = "MM/yyyy";
                fld_dteSearchToARInvoiceDate.Properties.EditFormat.FormatString = "MM/yyyy";
                fld_dteSearchToARInvoiceDate.Properties.EditMask = "MM/yyyy";
            }
            else
            {
                fld_lblFrom.Text = ReportLocalizedResources.FromYear;
                fld_dteSearchFromARInvoiceDate.DateTime = BOSUtil.GetYearBeginDate();
                fld_dteSearchToARInvoiceDate.DateTime = BOSUtil.GetYearEndDate();

                fld_dteSearchFromARInvoiceDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
                fld_dteSearchFromARInvoiceDate.Properties.DisplayFormat.FormatString = "yyyy";
                fld_dteSearchFromARInvoiceDate.Properties.EditFormat.FormatString = "yyyy";
                fld_dteSearchFromARInvoiceDate.Properties.EditMask = "yyyy";

                fld_dteSearchToARInvoiceDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
                fld_dteSearchToARInvoiceDate.Properties.DisplayFormat.FormatString = "yyyy";
                fld_dteSearchToARInvoiceDate.Properties.EditFormat.FormatString = "yyyy";
                fld_dteSearchToARInvoiceDate.Properties.EditMask = "yyyy";

            }
        }

        private void fld_bedGELocationName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            guiChooseLocation locationForm = new guiChooseLocation(LocationID);
            locationForm.Module = Module;
            if (locationForm.ShowDialog() == DialogResult.OK)
            {
                GELocationsController objLocationsController = new GELocationsController();
                GELocationsInfo objLocationsInfo = (GELocationsInfo)locationForm.LocationTreeList.GetSelectedObject();
                if (objLocationsInfo != null && objLocationsInfo.Selected)
                {
                    LocationID = objLocationsInfo.GELocationID;
                    fld_bedGELocationName.EditValue = objLocationsController.GetFullLocationNameByID(objLocationsInfo.GELocationID);
                }
                else
                {
                    LocationID = 0;
                    fld_bedGELocationName.EditValue = string.Empty;
                }
            }
        }
    }

}