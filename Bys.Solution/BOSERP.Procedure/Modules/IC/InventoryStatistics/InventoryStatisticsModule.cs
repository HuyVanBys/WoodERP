using BOSComponent;
using BOSERP.Utilities;
using DevExpress.XtraReports.UI;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BOSERP.Modules.InventoryStatistics
{
    public class InventoryStatisticsModule : BaseModuleERP
    {
        public const string FromDateDateEditControlName = "fld_dteFromDate";

        public const string ToDateDateEditControlName = "fld_dteToDate";

        public const string StockLookupControlName = "fld_lkeICStockID";

        public const string ProductLookupControlName = "fld_lkeICProductID";

        public const string DepartmentLookupControlName = "fld_lkeICDepartmentID";

        public const string ProductGroupLookupControlName = "fld_lkeICProductGroupID";

        public const string SupplierLookupControlName = "fld_lkeFK_APSupplierID";

        public const string BatchProductLookupControlName = "fld_lkeMMBatchProductID";

        public const string ViewTypeControlName = "fld_cmbViewType";

        public const string IsGroupByStockControlName = "fld_chkIsGroupByStock";

        public const string InventoryStatisticsGridControlName = "fld_dgcInventoryStatistics";

        public BOSDateEdit FromDateDateEdit;

        public BOSDateEdit ToDateDateEdit;

        public BOSLookupEdit StockLookup;

        public BOSLookupEdit ProductLookup;

        public BOSLookupEdit DepartmentLookup;

        public BOSLookupEdit ProductGroupLookup;

        public BOSLookupEdit SupplierLookup;

        public BOSLookupEdit BatchProductLookup;

        public BOSComboBox ViewTypeControl;

        public BOSCheckEdit IsGroupByStock;

        public InventoryStatisticsModule()
        {
            Name = "InventoryStatistics";
            CurrentModuleEntity = new InventoryStatisticsEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            FromDateDateEdit = (BOSDateEdit)Controls[InventoryStatisticsModule.FromDateDateEditControlName];
            ToDateDateEdit = (BOSDateEdit)Controls[InventoryStatisticsModule.ToDateDateEditControlName];
            StockLookup = (BOSLookupEdit)Controls[InventoryStatisticsModule.StockLookupControlName];
            ProductLookup = (BOSLookupEdit)Controls[InventoryStatisticsModule.ProductLookupControlName];
            DepartmentLookup = (BOSLookupEdit)Controls[InventoryStatisticsModule.DepartmentLookupControlName];
            ProductGroupLookup = (BOSLookupEdit)Controls[InventoryStatisticsModule.ProductGroupLookupControlName];
            SupplierLookup = (BOSLookupEdit)Controls[InventoryStatisticsModule.SupplierLookupControlName];
            BatchProductLookup = (BOSLookupEdit)Controls[InventoryStatisticsModule.BatchProductLookupControlName];
            ViewTypeControl = (BOSComboBox)Controls[InventoryStatisticsModule.ViewTypeControlName];
            IsGroupByStock = (BOSCheckEdit)Controls[InventoryStatisticsModule.IsGroupByStockControlName];
            FromDateDateEdit.EditValue = BOSApp.GetPeriodStartDate(BOSApp.GetCurrentServerDate());
            ToDateDateEdit.EditValue = BOSApp.GetPeriodEndDate(BOSApp.GetCurrentServerDate());
        }

        public void InventoryStatistics()
        {
            int? stockID = StockLookup.EditValue == null ? (int?)null : Convert.ToInt32(StockLookup.EditValue);
            int? productID = ProductLookup.EditValue == null ? (int?)null : Convert.ToInt32(ProductLookup.EditValue);
            int? departmentID = DepartmentLookup.EditValue == null ? (int?)null : Convert.ToInt32(DepartmentLookup.EditValue);
            int? productGroupID = ProductGroupLookup.EditValue == null ? (int?)null : Convert.ToInt32(ProductGroupLookup.EditValue);
            int? supplierID = SupplierLookup.EditValue == null ? (int?)null : Convert.ToInt32(SupplierLookup.EditValue);
            int? batchID = BatchProductLookup.EditValue == null ? (int?)null : Convert.ToInt32(BatchProductLookup.EditValue);
            bool isGroupByStock = IsGroupByStock.Checked;
            DateTime fromDate = Convert.ToDateTime(FromDateDateEdit.EditValue);
            DateTime toDate = Convert.ToDateTime(ToDateDateEdit.EditValue);

            ICTransactionsController controller = new ICTransactionsController();
            List<ICTransactionsInfo> inventoryStatistics = controller.GetInventoryStatistics(fromDate, toDate, productID, departmentID, productGroupID, supplierID, stockID, batchID, isGroupByStock);

            if (ViewTypeControl.SelectedIndex == 1)
            {
                inventoryStatistics = inventoryStatistics.Where(o => o.ICTransactionEndQty > 0).ToList();
            }

            InventoryStatisticsEntities entity = (InventoryStatisticsEntities)CurrentModuleEntity;
            entity.ICTransactionStatisticsList.Invalidate(inventoryStatistics);
        }

        public void ShowInventoryLeadgerModule()
        {
            InventoryStatisticsEntities entity = (InventoryStatisticsEntities)CurrentModuleEntity;
            if (entity.ICTransactionStatisticsList.CurrentIndex < 0)
                return;
            ICTransactionsInfo item = entity.ICTransactionStatisticsList[entity.ICTransactionStatisticsList.CurrentIndex];
            if (item == null)
                return;

            InventoryLeadger.InventoryLeadgerModule inventoryLeadgerModule = BOSApp.IsOpenedModule("InventoryLeadger")
                                                                             ? ((Modules.InventoryLeadger.InventoryLeadgerModule)BOSApp.OpenModules["InventoryLeadger"])
                                                                             : (Modules.InventoryLeadger.InventoryLeadgerModule)BOSApp.ShowModule("InventoryLeadger");
            if (inventoryLeadgerModule == null)
                return;

            DateTime fromDate = Convert.ToDateTime(FromDateDateEdit.EditValue);
            DateTime toDate = Convert.ToDateTime(ToDateDateEdit.EditValue);

            inventoryLeadgerModule.FromDateDateEdit.EditValue = fromDate;
            inventoryLeadgerModule.ToDateDateEdit.EditValue = toDate;
            inventoryLeadgerModule.StockLookup.EditValue = item.FK_ICStockID;
            inventoryLeadgerModule.ProductLookup.EditValue = item.FK_ICProductID;
            inventoryLeadgerModule.StockLookup.Refresh();
            inventoryLeadgerModule.ProductLookup.Refresh();
            inventoryLeadgerModule.InventoryLeadger();

            inventoryLeadgerModule.ParentScreen.Activate();
        }

        public void PrintClick()
        {
            BOSReport.RP052I report = new BOSReport.RP052I();
            InitDataSourceReport(report);

            XtraReportHelper.SetFormatField(report);
            guiReportPreview reviewer = new guiReportPreview(report, BOSCommon.Constants.Report.DevRP052IPath, true);
            reviewer.Show();
        }

        public void InitDataSourceReport(XtraReport report)
        {
            int? stockID = StockLookup.EditValue == null ? (int?)null : Convert.ToInt32(StockLookup.EditValue);
            int? productID = ProductLookup.EditValue == null ? (int?)null : Convert.ToInt32(ProductLookup.EditValue);
            int? departmentID = DepartmentLookup.EditValue == null ? (int?)null : Convert.ToInt32(DepartmentLookup.EditValue);
            int? productGroupID = ProductGroupLookup.EditValue == null ? (int?)null : Convert.ToInt32(ProductGroupLookup.EditValue);
            int? supplierID = SupplierLookup.EditValue == null ? (int?)null : Convert.ToInt32(SupplierLookup.EditValue);
            int? batchID = BatchProductLookup.EditValue == null ? (int?)null : Convert.ToInt32(BatchProductLookup.EditValue);
            bool isGroupByStock = IsGroupByStock.Checked;
            DateTime fromDate = Convert.ToDateTime(FromDateDateEdit.EditValue);
            DateTime toDate = Convert.ToDateTime(ToDateDateEdit.EditValue);

            ICTransactionsController controller = new ICTransactionsController();
            List<ICTransactionsInfo> inventoryStatistics = controller.GetInventoryStatistics(fromDate, toDate, productID, departmentID, productGroupID, supplierID, stockID, batchID, isGroupByStock);

            if (ViewTypeControl.SelectedIndex == 1)
            {
                inventoryStatistics = inventoryStatistics.Where(o => o.ICTransactionEndQty > 0).ToList();
            }

            string StockName = string.Empty;
            BRBranchsController objBranchsController = new BRBranchsController();
            GECurrenciesController objCurrenciesController = new GECurrenciesController();
            ICStocksController objStocksController = new ICStocksController();
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
            dateTime.Text = string.Format("{0} {1} {2} {3}", ReportLocalizedResources.FromDateTitle, fromDate.ToString("dd/MM/yyyy"),
                                                                                    ReportLocalizedResources.ToDateTitle, toDate.ToString("dd/MM/yyyy"));
            int iStockID = 0;
            if (stockID != null && stockID > 0)
            {
                iStockID = stockID ?? default(int);
                ICStocksInfo objStocksInfo = objStocksController.GetObjectByID(iStockID) as ICStocksInfo;
                XRLabel stockName = (XRLabel)report.Bands[BandKind.ReportHeader].Controls["xr_lblICStockName"];
                if (stockName != null)
                    stockName.Text = StockName;
            }

            report.DataSource = inventoryStatistics;
        }
    }
}
