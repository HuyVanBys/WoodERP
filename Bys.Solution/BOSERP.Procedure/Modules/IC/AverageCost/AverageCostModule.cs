using BOSCommon.Constants;
using BOSComponent;
using BOSLib;
using System;
using System.Collections.Generic;

namespace BOSERP.Modules.AverageCost
{
    public class AverageCostModule : BaseModuleERP
    {
        public const string MonthLookupControlName = "fld_lkeMonth";

        public const string YearTextBoxControlName = "fld_txtYear";

        public const string StockLookupControlName = "fld_lkeICStockID";

        public const string ProductGroupLookupControlName = "fld_lkeICProductGroupID";

        public const string ProductLookupControlName = "fld_lkeICProductID";

        public BOSLookupEdit MonthLookup;

        public BOSTextBox YearTextBox;

        public BOSLookupEdit StockLookup;

        public BOSLookupEdit ProductGroupLookup;

        public BOSLookupEdit ProductLookup;

        public AverageCostModule()
        {
            Name = "AverageCost";
            CurrentModuleEntity = new AverageCostEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            MonthLookup = (BOSLookupEdit)Controls[AverageCostModule.MonthLookupControlName];
            YearTextBox = (BOSTextBox)Controls[AverageCostModule.YearTextBoxControlName];
            StockLookup = (BOSLookupEdit)Controls[AverageCostModule.StockLookupControlName];
            ProductGroupLookup = (BOSLookupEdit)Controls[AverageCostModule.ProductGroupLookupControlName];
            ProductLookup = (BOSLookupEdit)Controls[AverageCostModule.ProductLookupControlName];
        }

        public void CalculatorCost()
        {
            int month = MonthLookup.EditValue == null ? BOSApp.GetCurrentServerDate().Month : Convert.ToInt32(MonthLookup.EditValue);
            int year = YearTextBox.EditValue == null ? BOSApp.GetCurrentServerDate().Year : Convert.ToInt32(YearTextBox.EditValue);
            int? stockID = StockLookup.EditValue == null ? (int?)null : Convert.ToInt32(StockLookup.EditValue);
            int? productGroupID = ProductGroupLookup.EditValue == null ? (int?)null : Convert.ToInt32(ProductGroupLookup.EditValue);
            int? productID = ProductLookup.EditValue == null ? (int?)null : Convert.ToInt32(ProductLookup.EditValue);
            DateTime fromDate = new DateTime(year, month, BOSApp.GetPeriodStartDate(BOSApp.GetCurrentServerDate()).Day);
            ICAverageCostsController controller = new ICAverageCostsController();
            List<ICAverageCostsInfo> costs = controller.CalculatorCost(month, year, stockID, productGroupID, productID, fromDate);
            AverageCostEntities entity = (AverageCostEntities)CurrentModuleEntity;
            entity.AverageCostList.Invalidate(costs);
        }

        public void ApplyCost()
        {
            BOSProgressBar.Start("Hệ thống đang thực hiện áp giá !");
            try
            {
                int? month = MonthLookup.EditValue == null ? (int?)null : Convert.ToInt32(MonthLookup.EditValue);
                int? year = YearTextBox.EditValue == null ? (int?)null : Convert.ToInt32(YearTextBox.EditValue);
                int? stockID = StockLookup.EditValue == null ? (int?)null : Convert.ToInt32(StockLookup.EditValue);
                int? productGroupID = ProductGroupLookup.EditValue == null ? (int?)null : Convert.ToInt32(ProductGroupLookup.EditValue);
                int? productID = ProductLookup.EditValue == null ? (int?)null : Convert.ToInt32(ProductLookup.EditValue);
                ICAverageCostsController controller = new ICAverageCostsController();
                controller.ApplyCostReceiptItems(month, year, stockID, productGroupID, productID);
                controller.ApplyCostSaleReturnItems(month, year, stockID, productGroupID, productID);
                controller.ApplyCostShipmentItems(month, year, stockID, productGroupID, productID);
                controller.ApplyCostInvoiceItems(month, year, stockID, productGroupID, productID);
                controller.ApplyCostTransferItems(month, year, stockID, productGroupID, productID);
                controller.ApplyCostOthers(month, year, stockID, productGroupID, productID);
                ICTransactionsController objTransactionsController = new ICTransactionsController();
                List<ICTransactionsInfo> transactions = objTransactionsController.GetTransactionApplyCost(month, year, stockID, productGroupID, productID);
                transactions.ForEach(o =>
                {
                    GLHelper.PostedTransactions(o.ICTransactionModuleName, o.ICTransactionReferenceID, ModulePostingType.Stock, ModulePostingType.Accounting, ModulePostingType.SaleOrder);
                });

                controller.ApplyCosts(month, year, stockID, productGroupID, productID);
            }
            catch (Exception ex)
            {
                BOSProgressBar.Close();
            }
            BOSProgressBar.Close();
        }
    }
}
