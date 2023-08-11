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
    public partial class RP030 : ReportForm
    {
        /// <summary>
        /// Chart control of branch's service
        /// </summary>
        private ChartControl InvoiceInItemsChartControl;

        private enum QtyOrAmount { Qty = 1, Amount = 2 }
        /// <summary>
        /// View type
        /// </summary>
        private QtyOrAmount QtyAmountType = QtyOrAmount.Qty;
        private List<APSuppliersInfo> supplierLists;
        public RP030()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public override void InitializeControls(System.Windows.Forms.Control.ControlCollection controls)
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

        private void RP030_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            QtyAmountType = QtyOrAmount.Amount;
            fld_chcInvoiceInItems.Titles[0].Text = fld_ctxItemAmount.Text;
            InvoiceInItemsChartControl = fld_chcInvoiceInItems;
            fld_dteDateFrom.DateTime = BOSUtil.GetYearBeginDate();
            fld_dteDateTo.DateTime = BOSUtil.GetYearEndDate();
            APSuppliersController objSuppliersController = new APSuppliersController();
            supplierLists = objSuppliersController.GetAllSuppliers();
            fld_cmbSuppliers.Properties.DataSource = supplierLists;
            //ShowReportData();
        }

        /// <summary>
        /// Show report's data based on the report's parameters
        /// </summary>
        private void ShowReportData()
        {
            ADReportsController objReportsController = new ADReportsController();
            DateTime dateFrom = fld_dteDateFrom.DateTime;
            DateTime dateTo = fld_dteDateTo.DateTime;
            //Set title report
            fld_lblSubTitleDate.Text = String.Format(" {0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, dateFrom.ToString("dd/MM/yyyy"),
                                                                    ReportLocalizedResources.ToDateTitle, dateTo.ToString("dd/MM/yyyy"));
            //int supplierQty = Convert.ToInt32(fld_cmbSuppliers.EditValue);
            //TNDLoc [ADD] [10/23/2014] [DB centre] [Report Permission], START
            int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
            string branchNos = GetSelectedBranchNosByBranchID(branchID);
            //TNDLoc [ADD] [10/23/2014] [DB centre] [Report Permission], END
            //NHAnh [ADD] [21/10/2016] [ADD supplierNoLists], START
            List<APSuppliersInfo> selectedSuppliers = GetStockList();
            string SupplierNoList = string.Empty;
            if (selectedSuppliers != null && selectedSuppliers.Count != 0)
            {
                foreach (APSuppliersInfo selectedStock in selectedSuppliers)
                {
                    if (!string.IsNullOrEmpty(SupplierNoList))
                        SupplierNoList += ", ";
                    SupplierNoList += selectedStock.APSupplierNo;
                }
            }
            else
            {
                if (selectedSuppliers == null)
                    selectedSuppliers = new List<APSuppliersInfo>();
                selectedSuppliers.Add(new APSuppliersInfo());
            }
            //NHAnh [ADD] [21/10/2016] [ADD supplierNoLists], END
            //TNDLoc [EDIT] [10/23/2014] [DB centre] [Report Permission], START
            //DataSet ds = objReportsController.GetSupplierList(supplierType, productID);
            List<APSuppliersInfo> suppliers = objReportsController.GetSupplierPurchaseSummaryByBranchNos(dateFrom, dateTo, branchNos, SupplierNoList);
            //DataSet suppliers = objReportsController.GetSupplierPurchaseSummaryByBranchNos(dateFrom, dateTo, branchNos, SupplierNoList);
            //TNDLoc [EDIT] [10/23/2014] [DB centre] [Report Permission], END
            suppliers = suppliers.Where(s => s.TotalOrderCost != 0).ToList();
            if (QtyAmountType == QtyOrAmount.Amount)
            {
                suppliers = suppliers.OrderByDescending(s => s.TotalOrderCost).ToList();
            }
            else if (QtyAmountType == QtyOrAmount.Qty)
            {
                suppliers = suppliers.OrderByDescending(s => s.TotalOrderQty).ToList();
            }
            //supplierQty = Math.Min(supplierQty, suppliers.Count);
            InvoiceInItemsChartControl.Series[0].Points.Clear();
            for (int i = 0; i < suppliers.Count; i++)
            {
                APSuppliersInfo objSuppliersInfo = suppliers[i];
                SeriesPoint point = new SeriesPoint();
                switch (QtyAmountType)
                {
                    case QtyOrAmount.Qty:
                        point = new SeriesPoint(objSuppliersInfo.APSupplierName, objSuppliersInfo.TotalOrderQty);
                        break;
                    case QtyOrAmount.Amount:
                        point = new SeriesPoint(objSuppliersInfo.APSupplierName, objSuppliersInfo.TotalOrderCost);
                        break;
                }
                InvoiceInItemsChartControl.Series[0].Points.Add(point);
            }
        }

        private void fld_ctxItemQty_Click(object sender, EventArgs e)
        {
            QtyAmountType = QtyOrAmount.Qty;
            fld_chcInvoiceInItems.Titles[0].Text = fld_ctxItemQty.Text;
            ShowReportData();
        }

        private void fld_ctxItemAmount_Click(object sender, EventArgs e)
        {
            QtyAmountType = QtyOrAmount.Amount;
            fld_chcInvoiceInItems.Titles[0].Text = fld_ctxItemAmount.Text;
            ShowReportData();
        }

        private void fld_btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fld_btnView_Click(object sender, EventArgs e)
        {
            ShowReportData();
        }
        public List<APSuppliersInfo> GetStockList()
        {
            List<APSuppliersInfo> supplierList = new List<APSuppliersInfo>();
            string[] SupplierIDs = fld_cmbSuppliers.EditValue.ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (SupplierIDs.Length > 0)
            {
                for (int i = 0; i < SupplierIDs.Length; i++)
                {
                    int SupplierID = Convert.ToInt32(SupplierIDs[i]);
                    APSuppliersInfo stock = supplierLists.FirstOrDefault(item => item.APSupplierID == SupplierID);
                    if (stock != null)
                        supplierList.Add(stock);
                }
            }

            if (supplierList.Count == 0)
            {
                DataSet ds = new DataSet();
                int branchID = Convert.ToInt32(fld_lkeBRBranchID.EditValue);
                if (branchID > 0)
                {
                    supplierList = supplierLists.Where(item => item.FK_BRBranchID == branchID).ToList();
                }
                else
                {
                    supplierList = supplierLists;
                }
            }

            //if (supplierList != null)
            //{
            //    BRBranchsController objBranchsController = new BRBranchsController();
            //    List<BRBranchsInfo> branches = objBranchsController.GetAllBranches();
            //    foreach (APSuppliersInfo stock in supplierList)
            //    {
            //        BRBranchsInfo branch = (BRBranchsInfo)branches.Where(b => b.BRBranchID == stock.FK_BRBranchID).FirstOrDefault();
            //        if (branch != null)
            //        {
            //            stock.BRBranchParentID = branch.BRBranchParentID;
            //        }
            //    }
            //}
            return supplierList;
        }
    }
}
