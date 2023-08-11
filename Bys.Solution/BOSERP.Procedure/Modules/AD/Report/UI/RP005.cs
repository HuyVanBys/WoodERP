using BOSLib;
using DevExpress.XtraCharts;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BOSERP.Modules.Report
{
    public partial class RP005 : ReportForm
    {
        #region Private variables
        /// <summary>
        /// Argument of chart
        /// </summary>
        private String Argument = string.Empty;

        /// <summary>
        /// Title of AxisY of chart
        /// </summary>
       // private String TitleAxisY=string.Empty;

        /// <summary>
        /// Variable to keep parent of group
        /// </summary>
        private int ProductParentGroupID = 0;

        /// <summary>
        /// Variable to keep department id
        /// </summary>
        private int DepartmentID = 0;
        #endregion

        public RP005()
        {
            InitializeComponent();
            Argument = String.Empty;

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

        private void RP005_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);

            fld_dteSearchFromARInvoiceDate.DateTime = BOSUtil.GetYearBeginDate();
            fld_dteSearchToARInvoiceDate.DateTime = BOSUtil.GetYearEndDate();

            XYDiagram diagram = (XYDiagram)fld_cctrlARRP005InvoiceItems.Diagram;
            //CustomizeChartControl(fld_cctrlARRP005InvoiceItems.Titles[0].Text);
            //InitializeDataChartControl(fld_cctrlARRP005InvoiceItems.Titles[1].Text.Trim(), fld_cctrlARRP005InvoiceItems.Titles[0].Text, null, null);
        }

        /// <summary>
        /// Customize interface of control in chart
        /// </summary>
        /// <param name="axisY">Y axis title</param>
        public void CustomizeChartControl(string axisY)
        {
            string axisYTitle = String.Empty;

            #region Customize AxisX of diagram
            // Cast the chart's diagram to the XYDiagram type,
            // to access its axes.
            XYDiagram diagram = (XYDiagram)fld_cctrlARRP005InvoiceItems.Diagram;

            // Add a prefix to the X-axis labels, and rotate them.
            diagram.AxisX.Label.Angle = -35;
            diagram.AxisX.Label.Antialiasing = true;

            #endregion

            #region  Customize Chart Title
            BRBranchsController objBranchsController = new BRBranchsController();
            BRBranchsInfo objBranchsInfo = new BRBranchsInfo();
            string branchName = String.Empty;
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            if (branchID != 0)
            {
                objBranchsInfo.BRBranchID = branchID;
                branchName = objBranchsController.GetObjectNameByID(objBranchsInfo.BRBranchID);
            }
            fld_lblBranchName.Text = branchName;
            fld_lblFromdateTodate.Text = string.Format(" {0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fld_dteSearchFromARInvoiceDate.Text,
                                                                                    ReportLocalizedResources.ToDateTitle, fld_dteSearchToARInvoiceDate.Text);
            #endregion

            //Customize lengend

            fld_cctrlARRP005InvoiceItems.Legend.Visible = false;

        }

        public void InitializeDataChartControl(String strDataAxisX, String strDataAxisY, int? departmentID, int? productGroupID)
        {
            String strGroupBy = String.Empty;
            DateTime fromDate = Convert.ToDateTime(fld_dteSearchFromARInvoiceDate.EditValue);
            DateTime toDate = Convert.ToDateTime(fld_dteSearchToARInvoiceDate.EditValue);
            ADReportsController objReportsController = new ADReportsController();
            DataSet dsInvoiceItems = new DataSet();
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);

            if (strDataAxisX.Contains(ReportLocalizedResources.Supplier))
                //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
                if (branchID == 0)
                {
                    foreach (BRBranchsInfo branch in BranchList)
                    {
                        DataSet ds = objReportsController.GetInvoiceItemsGroupedBySupplier(fromDate, toDate, branch.BRBranchID);
                        dsInvoiceItems.Merge(ds);
                    }
                }
                else
                    //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
                    dsInvoiceItems = objReportsController.GetInvoiceItemsGroupedBySupplier(fromDate, toDate, branchID);
            else
            {
                //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
                if (branchID == 0)
                {
                    foreach (BRBranchsInfo branch in BranchList)
                    {
                        DataSet ds = objReportsController.GetInvoiceItemsGroupedByDepartment(fromDate, toDate, departmentID, productGroupID, branch.BRBranchID);
                        dsInvoiceItems.Merge(ds);
                    }
                }
                else
                    //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
                    dsInvoiceItems = objReportsController.GetInvoiceItemsGroupedByDepartment(fromDate, toDate, departmentID, productGroupID, branchID);
            }

            BOSList<ARInvoiceItemsInfo> lstARInvoiceItems = new BOSList<ARInvoiceItemsInfo>();
            fld_cctrlARRP005InvoiceItems.Series[0].Points.Clear();
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], START
            //if (dsInvoiceItems.Tables[0].Rows.Count > 0)
            if (dsInvoiceItems.Tables.Count != 0 && dsInvoiceItems.Tables[0].Rows.Count > 0)
            //NUThao [EDIT] [10/16/2014] [DB centre] [Report Permission], END
            {
                ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
                ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
                ICProductsController objProductsController = new ICProductsController();
                APSuppliersController objSuppliersController = new APSuppliersController();
                ICProductGroupsInfo objProductGroupsInfo = new ICProductGroupsInfo();
                ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
                //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
                Dictionary<string, List<ARInvoiceItemsInfo>> collection = new Dictionary<string, List<ARInvoiceItemsInfo>>();
                //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
                foreach (DataRow row in dsInvoiceItems.Tables[0].Rows)
                {
                    ARInvoiceItemsInfo objARInvoiceItemsInfo = (ARInvoiceItemsInfo)objInvoiceItemsController.GetObjectFromDataRow(row);
                    if (objARInvoiceItemsInfo != null)
                    {
                        String strArgumemtName = String.Empty;
                        if (strDataAxisX.Contains(ReportLocalizedResources.Department))
                            strArgumemtName = objDepartmentsController.GetObjectNameByID(objARInvoiceItemsInfo.FK_ICDepartmentID);
                        else if (strDataAxisX.Contains(ReportLocalizedResources.Supplier))
                            strArgumemtName = objSuppliersController.GetObjectNameByID(Convert.ToInt32(row["APSupplierID"]));
                        else
                        {
                            objProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectFromDataRow(row);
                            strArgumemtName = objProductGroupsInfo.ICProductGroupName;
                        }
                        //NUThao [DELETE] [10/16/2014] [DB centre] [Report Permission], START
                        //if (!String.IsNullOrEmpty(strArgumemtName))
                        //{
                        //    if (strDataAxisY.Contains(ReportLocalizedResources.Cost))
                        //        fld_cctrlARRP005InvoiceItems.Series[0].Points.Add(new SeriesPoint(strArgumemtName, new decimal[] { Convert.Todecimal(objARInvoiceItemsInfo.ARInvoiceItemTotalCost) }));
                        //    else if (strDataAxisY.Contains(ReportLocalizedResources.Qty))
                        //        fld_cctrlARRP005InvoiceItems.Series[0].Points.Add(new SeriesPoint(strArgumemtName, new decimal[] { Convert.Todecimal(objARInvoiceItemsInfo.ARInvoiceItemProductQty) }));
                        //    else
                        //        fld_cctrlARRP005InvoiceItems.Series[0].Points.Add(new SeriesPoint(strArgumemtName, new decimal[] { Convert.Todecimal(objARInvoiceItemsInfo.ARInvoiceItemTotalAmount) }));
                        //}
                        //NUThao [DELETE] [10/16/2014] [DB centre] [Report Permission], END

                        //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], START
                        if (!collection.ContainsKey(strArgumemtName))
                            collection.Add(strArgumemtName, new List<ARInvoiceItemsInfo>());
                        collection[strArgumemtName].Add(objARInvoiceItemsInfo);
                    }
                }

                foreach (string key in collection.Keys)
                {
                    if (!String.IsNullOrEmpty(key))
                    {
                        decimal value;
                        if (strDataAxisY.Contains(ReportLocalizedResources.Cost))
                        {
                            value = collection[key].Sum(item => item.ARInvoiceItemTotalCost);
                            fld_cctrlARRP005InvoiceItems.Series[0].Points.Add(new SeriesPoint(key, new decimal[] { Convert.ToDecimal(value) }));
                        }
                        else if (strDataAxisY.Contains(ReportLocalizedResources.Qty))
                        {
                            value = collection[key].Sum(item => item.ARInvoiceItemProductQty);
                            fld_cctrlARRP005InvoiceItems.Series[0].Points.Add(new SeriesPoint(key, new decimal[] { Convert.ToDecimal(value) }));
                        }
                        else
                        {
                            value = collection[key].Sum(item => item.ARInvoiceItemTotalAmount);
                            fld_cctrlARRP005InvoiceItems.Series[0].Points.Add(new SeriesPoint(key, new decimal[] { Convert.ToDecimal(value) }));
                        }
                    }
                }

                //NUThao [ADD] [10/16/2014] [DB centre] [Report Permission], END
            }

        }

        /// <summary>
        /// Initialize source of chart control by product group parent id and invalidate chart control
        /// </summary>
        /// <param name="strDataAxisX">Value of X axis' title of chart</param>
        /// <param name="strDataAxisY">Value of Y axis' title of chart</param>
        public void InitializeDataChartControlByDepartmentID(String strDataAxisX, String strDataAxisY, int departmentID, int productGroupParentID)
        {
            DateTime fromDate = Convert.ToDateTime(fld_dteSearchFromARInvoiceDate.EditValue);
            DateTime toDate = Convert.ToDateTime(fld_dteSearchToARInvoiceDate.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);

            ADReportsController objReportsController = new ADReportsController();
            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
            ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            ICProductGroupsInfo objProductGroupsInfo = new ICProductGroupsInfo();

            DataSet dsProductGroups = objReportsController.GetProductGroupByDepartmentID(fromDate, toDate, departmentID, productGroupParentID, branchID);
            fld_cctrlARRP005InvoiceItems.Series[0].Points.Clear();

            if (dsProductGroups.Tables[0].Rows.Count > 0)
            {
                fld_cctrlARRP005InvoiceItems.Series[0].Points.Clear();
                foreach (DataRow row in dsProductGroups.Tables[0].Rows)
                {
                    objProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectFromDataRow(row);
                    string strArgumemtName = objProductGroupsInfo.ICProductGroupName;
                    if (!String.IsNullOrEmpty(strArgumemtName))
                    {
                        if (strDataAxisY.Contains(ReportLocalizedResources.Cost))
                            fld_cctrlARRP005InvoiceItems.Series[0].Points.Add(new SeriesPoint(strArgumemtName, new decimal[] { Convert.ToDecimal(objProductGroupsInfo.TotalItemCost) }));
                        else if (strDataAxisY.Contains(ReportLocalizedResources.Qty))
                            fld_cctrlARRP005InvoiceItems.Series[0].Points.Add(new SeriesPoint(strArgumemtName, new decimal[] { Convert.ToDecimal(objProductGroupsInfo.TotalItemQty) }));
                        else
                            fld_cctrlARRP005InvoiceItems.Series[0].Points.Add(new SeriesPoint(strArgumemtName, new decimal[] { Convert.ToDecimal(objProductGroupsInfo.TotalItemAmount) }));
                    }

                }
                InitSubChartControlSource(strDataAxisX, strDataAxisY, departmentID, productGroupParentID, false);
            }
            else
            {
                objProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(ProductParentGroupID);
                if (CheckProduct(objProductGroupsInfo.ICProductGroupID))
                {
                    InitSubChartControlSource(strDataAxisX, strDataAxisY, departmentID, objProductGroupsInfo.ICProductGroupID, true);
                }
                if (objProductGroupsInfo != null && CheckProduct(objProductGroupsInfo.ICProductGroupID) == false)
                {
                    ProductParentGroupID = objProductGroupsInfo.ICProductGroupParentID;
                }
            }

        }

        /// <summary>
        /// Initialize sub chart of main chart control and invalidate sub chart control
        /// </summary>
        /// <param name="strDataAxisX">X axis title</param>
        /// <param name="strDataAxisY">Y axis title</param>
        /// <param name="productGroupID">ID of the product group to get all products belonging to it</param>
        /// <param name="clearPoints">Value indicates whether all points of the chart should be cleared first</param>
        public void InitSubChartControlSource(String strDataAxisX, String strDataAxisY, int departmentID, int productGroupID, bool clearPoints)
        {
            ARInvoiceItemsController objInvoiceItemsController = new ARInvoiceItemsController();
            ICProductGroupsInfo objProductGroupsInfo = new ICProductGroupsInfo();
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            ICProductsController objProductsController = new ICProductsController();
            BOSList<ICProductsInfo> lstProducts = new BOSList<ICProductsInfo>();
            ADReportsController objReportsController = new ADReportsController();

            DateTime fromDate = Convert.ToDateTime(fld_dteSearchFromARInvoiceDate.EditValue);
            DateTime toDate = Convert.ToDateTime(fld_dteSearchToARInvoiceDate.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);

            ProductParentGroupID = productGroupID;
            DataSet ds = objReportsController.GetProductByProductGroupID(fromDate, toDate, departmentID, productGroupID, branchID);
            if (clearPoints)
            {
                fld_cctrlARRP005InvoiceItems.Series[0].Points.Clear();
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    ICProductsInfo objProductsInfo = (ICProductsInfo)objProductsController.GetObjectFromDataRow(row);
                    String strArgumemtName = String.Empty;
                    strArgumemtName = objProductsInfo.ICProductName;

                    if (!String.IsNullOrEmpty(strArgumemtName))
                    {
                        if (strDataAxisY.Contains(ReportLocalizedResources.Cost))
                            fld_cctrlARRP005InvoiceItems.Series[0].Points.Add(new SeriesPoint(strArgumemtName, new decimal[] { Convert.ToDecimal(objProductsInfo.ARInvoiceItemTotalCost) }));
                        else if (strDataAxisY.Contains(ReportLocalizedResources.Qty))
                            fld_cctrlARRP005InvoiceItems.Series[0].Points.Add(new SeriesPoint(strArgumemtName, new decimal[] { Convert.ToDecimal(objProductsInfo.ARInvoiceItemProductQty) }));
                        else
                            fld_cctrlARRP005InvoiceItems.Series[0].Points.Add(new SeriesPoint(strArgumemtName, new decimal[] { Convert.ToDecimal(objProductsInfo.ARInvoiceItemTotalAmount) }));
                    }

                }
            }
        }
        #region Events
        private void fld_btnApply_Click(object sender, EventArgs e)
        {
            XYDiagram diagram = (XYDiagram)fld_cctrlARRP005InvoiceItems.Diagram;
            if (fld_cctrlARRP005InvoiceItems.Titles[1].Text.Contains(ReportLocalizedResources.Department))
                InitializeDataChartControl(fld_cctrlARRP005InvoiceItems.Titles[1].Text.Trim().Trim(), fld_cctrlARRP005InvoiceItems.Titles[0].Text, 0, 0);
            else
            {
                fld_cctrlARRP005InvoiceItems.Titles[1].Text = ReportLocalizedResources.Department;
                InitializeDataChartControl(fld_cctrlARRP005InvoiceItems.Titles[1].Text.Trim().Trim(), fld_cctrlARRP005InvoiceItems.Titles[0].Text, 0, 0);
            }
            CustomizeChartControl(fld_cctrlARRP005InvoiceItems.Titles[0].Text);
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fld_btnBack_Click(object sender, EventArgs e)
        {
            if (fld_cctrlARRP005InvoiceItems.Titles[1].Text.Trim().Contains(ReportLocalizedResources.Supplier))
                return;
            else if (fld_cctrlARRP005InvoiceItems.Titles[1].Text.Trim().Contains(ReportLocalizedResources.Department))
            {
                fld_cctrlARRP005InvoiceItems.Titles[1].Text = ReportLocalizedResources.Department;
                InitializeDataChartControl(fld_cctrlARRP005InvoiceItems.Titles[1].Text.Trim(), fld_cctrlARRP005InvoiceItems.Titles[0].Text, 0, 0);
            }
            else
            {
                int productGroupParentID = ProductParentGroupID;
                XYDiagram diagram = (XYDiagram)fld_cctrlARRP005InvoiceItems.Diagram;

                ICProductGroupsInfo objProductGroupsInfo = new ICProductGroupsInfo();
                ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
                objProductGroupsInfo.ICProductGroupID = ProductParentGroupID;
                objProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByID(objProductGroupsInfo.ICProductGroupID);

                if (objProductGroupsInfo != null)
                {
                    fld_cctrlARRP005InvoiceItems.Titles[1].Text = ReportLocalizedResources.Category;
                    productGroupParentID = objProductGroupsInfo.ICProductGroupParentID;
                    ProductParentGroupID = objProductGroupsInfo.ICProductGroupParentID;
                    InitializeDataChartControlByDepartmentID(diagram.AxisX.Title.Text.Trim(), fld_cctrlARRP005InvoiceItems.Titles[0].Text, DepartmentID, productGroupParentID);
                }
                else
                {
                    fld_cctrlARRP005InvoiceItems.Titles[1].Text = ReportLocalizedResources.Department;
                    InitializeDataChartControl(fld_cctrlARRP005InvoiceItems.Titles[1].Text.Trim(), fld_cctrlARRP005InvoiceItems.Titles[0].Text, 0, 0);
                }
            }
        }

        private void axisYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fld_cctrlARRP005InvoiceItems.Titles[0].Text = (sender as ToolStripMenuItem).Text;
            CustomizeChartControl(fld_cctrlARRP005InvoiceItems.Titles[0].Text);
            if (fld_cctrlARRP005InvoiceItems.Titles[1].Text.Trim().Contains(ReportLocalizedResources.Department) || fld_cctrlARRP005InvoiceItems.Titles[1].Text.Trim().Contains(ReportLocalizedResources.Supplier))
                InitializeDataChartControl(fld_cctrlARRP005InvoiceItems.Titles[1].Text.Trim().Trim(), fld_cctrlARRP005InvoiceItems.Titles[0].Text, 0, ProductParentGroupID);
            else
                InitializeDataChartControlByDepartmentID(fld_cctrlARRP005InvoiceItems.Titles[1].Text.Trim(), fld_cctrlARRP005InvoiceItems.Titles[0].Text, DepartmentID, ProductParentGroupID);
        }

        private void axisXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fld_cctrlARRP005InvoiceItems.Titles[1].Text = (sender as ToolStripMenuItem).Text;
            CustomizeChartControl(fld_cctrlARRP005InvoiceItems.Titles[0].Text);
            if (fld_cctrlARRP005InvoiceItems.Titles[1].Text.Trim().Contains(ReportLocalizedResources.Department))
                InitializeDataChartControl(fld_cctrlARRP005InvoiceItems.Titles[1].Text.Trim().Trim(), fld_cctrlARRP005InvoiceItems.Titles[0].Text, DepartmentID, ProductParentGroupID);
            else
                InitializeDataChartControlByDepartmentID(fld_cctrlARRP005InvoiceItems.Titles[1].Text.Trim(), fld_cctrlARRP005InvoiceItems.Titles[0].Text, DepartmentID, ProductParentGroupID);
        }

        private void fld_cctrlARRP005InvoiceItems_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime fromDate = Convert.ToDateTime(fld_dteSearchFromARInvoiceDate.EditValue);
            DateTime toDate = Convert.ToDateTime(fld_dteSearchToARInvoiceDate.EditValue);
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);

            XYDiagram diagram = (XYDiagram)fld_cctrlARRP005InvoiceItems.Diagram;
            string strDataAxisX = fld_cctrlARRP005InvoiceItems.Titles[1].Text.Trim().Trim();
            string strDataAxisY = fld_cctrlARRP005InvoiceItems.Titles[0].Text;
            // Obtain the object being clicked.
            ChartHitInfo chartHitInfo = fld_cctrlARRP005InvoiceItems.CalcHitInfo(e.X, e.Y);

            // Check whether it was a series point, and if so - 
            // obtain its argument, and pass it to the detail series.
            SeriesPoint point = chartHitInfo.SeriesPoint;

            if (point != null)
            {
                Argument = point.Argument.ToString();

                if (strDataAxisX.Contains(ReportLocalizedResources.Supplier))
                {
                    return;
                }
                else if (strDataAxisX.Contains(ReportLocalizedResources.Department))
                {

                    ICDepartmentsInfo objDepartmentsInfo = new ICDepartmentsInfo();
                    ICDepartmentsController objDepartmentsController = new ICDepartmentsController();
                    objDepartmentsInfo = (ICDepartmentsInfo)objDepartmentsController.GetObjectByName(Argument);
                    fld_cctrlARRP005InvoiceItems.Titles[1].Text = ReportLocalizedResources.Category;
                    DepartmentID = objDepartmentsInfo.ICDepartmentID;
                    InitializeDataChartControlByDepartmentID(fld_cctrlARRP005InvoiceItems.Titles[1].Text.Trim(), strDataAxisY, objDepartmentsInfo.ICDepartmentID, 0);
                }
                else if (strDataAxisX.Contains(ReportLocalizedResources.Category))
                {
                    int productGroupParentID = GetProductGroupParent(Argument);
                    if (productGroupParentID != -1)
                    {
                        InitializeDataChartControlByDepartmentID(strDataAxisX, strDataAxisY, DepartmentID, productGroupParentID);
                    }
                }
                diagram.AxisX.Label.Angle = -35;
                diagram.AxisX.Label.Antialiasing = true;
            }
        }
        #endregion

        /// <summary>
        /// Get parent of product group
        /// </summary>
        /// <param name="argument">Product group name</param>
        /// <returns>Product group parent ID</returns>
        public int GetProductGroupParent(string argument)
        {
            int groupParentID = -1;
            string strDataAxisX = fld_cctrlARRP005InvoiceItems.Titles[1].Text.Trim().Trim();
            string strDataAxisY = fld_cctrlARRP005InvoiceItems.Titles[0].Text;
            ICProductGroupsInfo objProductGroupsInfo = new ICProductGroupsInfo();
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            objProductGroupsInfo.ICProductGroupName = argument;
            objProductGroupsInfo = (ICProductGroupsInfo)objProductGroupsController.GetObjectByName(argument);
            if (objProductGroupsInfo != null)
            {
                DataSet ds = objProductGroupsController.GetProductGroupByProductGroupParentID(objProductGroupsInfo.ICProductGroupID);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    groupParentID = objProductGroupsInfo.ICProductGroupID;
                    ProductParentGroupID = groupParentID;
                }
            }
            return groupParentID;
        }

        /// <summary>
        /// Check product group has product
        /// </summary>
        /// <param name="productGroupID">ID of product group</param>
        /// <returns>True or false</returns>
        private bool CheckProduct(int productGroupID)
        {
            ICProductGroupsController objProductGroupsController = new ICProductGroupsController();
            int count = objProductGroupsController.GetProductCountByProductGroupID(productGroupID);
            if (count > 0)
            {
                return true;
            }
            return false;
        }
    }
}