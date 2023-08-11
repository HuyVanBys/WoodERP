using BOSComponent;
using BOSLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BOSERP.Modules.InventoryLeadger
{
    public class InventoryLeadgerModule : BaseModuleERP
    {
        public const string FromDateDateEditControlName = "fld_dteFromDate";

        public const string ToDateDateEditControlName = "fld_dteToDate";

        public const string StockLookupControlName = "fld_lkeICStockID";

        public const string ProductLookupControlName = "fld_lkeICProductID";
        public const string SerieLookupControlName = "fld_lkeICProductSerieID";
        public const string InventoryLeadgerGridControlName = "fld_dgcInventoryLeadger";
        public const string fld_chkIsGetAccumulatedQty = "fld_chkIsGetAccumulatedQty";

        public BOSDateEdit FromDateDateEdit;

        public BOSDateEdit ToDateDateEdit;

        public BOSLookupEdit StockLookup;

        public BOSLookupEdit ProductLookup;
        public BOSLookupEdit SerieLookup;
public BOSCheckEdit IsGetAccumulatedQtyControlName;
        public InventoryLeadgerModule()
        {
            Name = "InventoryLeadger";
            CurrentModuleEntity = new InventoryLeadgerEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();

            FromDateDateEdit = (BOSDateEdit)Controls[InventoryLeadgerModule.FromDateDateEditControlName];
            ToDateDateEdit = (BOSDateEdit)Controls[InventoryLeadgerModule.ToDateDateEditControlName];
            StockLookup = (BOSLookupEdit)Controls[InventoryLeadgerModule.StockLookupControlName];
            ProductLookup = (BOSLookupEdit)Controls[InventoryLeadgerModule.ProductLookupControlName];
            SerieLookup = (BOSLookupEdit)Controls[InventoryLeadgerModule.SerieLookupControlName];
            IsGetAccumulatedQtyControlName = (BOSCheckEdit)Controls[InventoryLeadgerModule.fld_chkIsGetAccumulatedQty];
            if (IsGetAccumulatedQtyControlName != null) IsGetAccumulatedQtyControlName.Checked = false;
            FromDateDateEdit.EditValue = BOSApp.GetPeriodStartDate(BOSApp.GetCurrentServerDate());
            ToDateDateEdit.EditValue = BOSApp.GetPeriodEndDate(BOSApp.GetCurrentServerDate());
        }

        public void InventoryLeadger()
        {
            BOSProgressBar.Start("Hệ thống đang tải dữ liệu!");
            int? stockID = StockLookup.EditValue == null ? (int?)null : Convert.ToInt32(StockLookup.EditValue);
            int? productID = ProductLookup.EditValue == null ? (int?)null : Convert.ToInt32(ProductLookup.EditValue);
            int? serieID = SerieLookup.EditValue == null ? (int?)null : Convert.ToInt32(SerieLookup.EditValue);
            DateTime fromDate = Convert.ToDateTime(FromDateDateEdit.EditValue);
            DateTime toDate = Convert.ToDateTime(ToDateDateEdit.EditValue);
            bool isGetAccumulatedQty = IsGetAccumulatedQtyControlName!= null? IsGetAccumulatedQtyControlName.Checked: false;
            ICTransactionsController controller = new ICTransactionsController();
            List<ICTransactionsInfo> inventoryCards = controller.GetInventoryCardBySomeCriteria(fromDate, toDate, productID, stockID, serieID, isGetAccumulatedQty);

            InventoryLeadgerEntities entity = (InventoryLeadgerEntities)CurrentModuleEntity;
            entity.ICTransactionsList.Invalidate(inventoryCards);
            BOSProgressBar.Close();
        }

        public void ShowReffModule()
        {
            InventoryLeadgerEntities entity = (InventoryLeadgerEntities)CurrentModuleEntity;
            if (entity.ICTransactionsList.CurrentIndex < 0)
                return;
            ICTransactionsInfo item = entity.ICTransactionsList[entity.ICTransactionsList.CurrentIndex];
            if (item == null)
                return;
            if (!string.IsNullOrEmpty(item.ICTransactionModuleName))
            {
                BaseModuleERP currModule = BOSApp.IsOpenedModule(item.ICTransactionModuleName)
                                           ? ((BaseModuleERP)BOSApp.OpenModules[item.ICTransactionModuleName])
                                           : (BaseModuleERP)BOSApp.ShowModule(item.ICTransactionModuleName);
                if (currModule == null)
                    return;
                currModule.Invalidate(item.ICTransactionReferenceID);
                currModule.ParentScreen.Activate();
            }
        }
        public void GetDataSerieList(int productID)
        {
            List<ICProductSeriesInfo> seriesInfos = (new ICProductSeriesController()).GetProductSerieByProductID(productID);
            if (seriesInfos.Count() > 0) seriesInfos.Insert(0, new ICProductSeriesInfo());
            if (SerieLookup != null) SerieLookup.Properties.DataSource = seriesInfos;
        }
    }
}
