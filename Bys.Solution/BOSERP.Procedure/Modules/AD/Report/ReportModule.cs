using BOSERP.Utilities;
using BOSLib;
using System;


namespace BOSERP.Modules.Report
{
    #region ReportModule
    public class ReportModule : BaseModuleERP
    {
        #region Constants
        public const String cstReportTypeSale = "Sale";
        public const String cstReportTypeCustomer = "Customer";
        public const String cstReportTypeInventory = "Inventory";
        public const String cstReportTypePurchasing = "Purchasing";
        public const String cstReportTypeEmployee = "Employee";

        public const String cstReportSectionGeneral = "General";
        public const String cstReportSectionGraph = "Graph";
        public const String cstReportSectionMultiStore = "Multi-store";
        #endregion

        public ReportModule()
        {
            Name = "Report";
            InitializeModule();
        }

        public override void InitializeScreens()
        {
            guiReportCenter guiReportCenter = new guiReportCenter();
            guiReportCenter.ScreenNumber = "DMRP100";
            guiReportCenter.Module = this;
            Screens.Add(guiReportCenter);

            guiReportCenter.AddControlsToParentScreen();
        }

        public String GenerateInvoiceItemSearchQuery(DateTime from, DateTime to, int? departmentID, int? productGroupID, int? supplierID, int branchID, String groupBy)
        {
            return string.Empty;
        }

        public void InvalidateItemProductPicture(ICProductsInfo objProductsInfo)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            if (objProductsInfo.ICProductPrimaryImage != null)
                return;
            objProductsInfo.ICProductPrimaryImage = ApiClientHelper.GetProductPrimaryImage(objProductsInfo.ICProductID);
        }

        public void InvalidateItemProductPicture(ICInventoryStocksInfo objInventoryStocksInfo)
        {
            BOSDbUtil dbUtil = new BOSDbUtil();
            if (objInventoryStocksInfo.ICInventoryStockProductPrimaryImage != null)
                return;
            objInventoryStocksInfo.ICInventoryStockProductPrimaryImage = ApiClientHelper.GetProductPrimaryImage(objInventoryStocksInfo.FK_ICProductID);
        }
    }
    #endregion
}
